grammar MathLang;

options {
  language=CSharp3;
  output=AST;

  backtrack=true;
  memoize=true;
}


tokens {
  UNKNOWN             ;
  PRINT   = 'print'   ;
  INPUT   = 'input'   ;
  IF = 'if'           ;
  ELSE = 'else'		  ;
  FOR = 'for'         ;
  FUNCTION = 'function' ;
  RETURN = 'return'   ;
  WHILE = 'while'     ;
  DO = 'do'     ;
  BLOCK               ;
  PROGRAM             ;
  PARAMS              ;
  VARDECLARATION ;
  FUNCDECLARATION ;
  ARRAYDECLARATION ;
  VARASSIGNMENT ;
  ARRAYELEMENTASSIGNMENT;
  ARRAYELEMENT ;
  NEWVAR;
  ARRAY_INITIALIZER ;
  OBJECT_INITIALIZER;
  FUNC_CALL ;
  RETURN_TYPE;
  PARAMETERS ;
  STATIC_DECLARATION;
  CLASSBLOCK;
  CLASS_WORD = 'class';
  CALL;
  VARS;
  MULT_ARRAY_DECL;
  FOR_INITIALIZATION;
  FOR_CONDITION;
  FOR_ITERATION;
  ARRAY_SIZE;
  EXTENDED_ID;
}


@lexer::namespace { MathLang }
@parser::namespace { MathLang }
@lexer::members
{
	public override void ReportError(RecognitionException e)
    {
        base.ReportError(e);
		ErrorService.Instance.Handle(e);
    }
}

@parser::members
{
	public override void ReportError(RecognitionException e)
    {
        base.ReportError(e);
		ErrorService.Instance.Handle(e);
    }
}

/*
 * Parser Rules
 */

public execute:
	class_list EOF!  -> ^(PROGRAM class_list) 
;

class_declaration: MODIFIER? CLASS_WORD ID class_block -> ^(CLASS_WORD ID class_block) ;

class_block: '{'! static_func_or_var_declaration* '}'! -> ^(CLASSBLOCK static_func_or_var_declaration * );

static_func_or_var_declaration: static_declaration | funcdeclaration ;

class_list:  class_declaration* ;

func_list : funcdeclaration* -> ^(PROGRAM funcdeclaration*)  ;

statement: ( declaration 
	| assignment
	| ifstatement
	| whilestatement
	| dowhilestatement
	| forstatement
	| returnstatement
	| funccall
	| newexpression
	| emptystatement
	 ) ;

type: TYPE ;
array_type: t+=TYPE t+=ARRAY_DECLARATION_MARK ;
any_type: array_type | type | VOID;
number :  NUMBER
		| extended_id
		| funccallbody
		| CHAR
		| arrayelement
		
		;
mathexpression: term ;

expression:  
			 newexpression
		| funccallbody
		| boolexpression
		| mathexpression
		
		
;
extended_id: ID (DOT! ID)? -> ^(EXTENDED_ID ID ID?);

arrayelement:  extended_id OPEN_SQUARE_BRACE mathexpression CLOSE_SQUARE_BRACE -> ^(ARRAYELEMENT extended_id mathexpression) ;
static_declaration:  MODIFIER declaration -> ^(STATIC_DECLARATION declaration);

declaration: var_declaration 
 | array_declaration;
var_declaration: t=type! d_list[t.Tree] ';'!;
array_declaration: at=array_type! d_array_list[at.Tree] ';'!;

d_list[object type]: d[type] (','! d[type])* ;
d_array_list[object type]: d_array[type] (','! d_array[type])* ;

d[object type]: declarationbody_d[type] | longdeclarationbody_d[type] ;
d_array[object type]: declarationbody_array_d[type] | longdeclarationbody_array_d[type];

declarationbody_d[object type]: (ID -> ^(VARDECLARATION ^(RETURN_TYPE {$type}) ID) );				
declarationbody_array_d[object type]: ( ID -> ^(ARRAYDECLARATION ^(RETURN_TYPE {$type}) ID));

longdeclarationbody_d[object type]: (ID ASSIGN expression  -> ^(VARDECLARATION ^(RETURN_TYPE {$type}) ID expression));
longdeclarationbody_array_d[object type]: (ID ASSIGN expression -> ^(ARRAYDECLARATION ^(RETURN_TYPE {$type}) ID expression));


//declarationbody: (type ID -> ^(VARDECLARATION type ID) )
//				| (array_type ID -> ^(ARRAYDECLARATION array_type) ID)
//				;
declarationbody: 
					type ID -> ^(VARDECLARATION ^(RETURN_TYPE type) ID )
			| array_type ID -> ^(ARRAYDECLARATION ^(RETURN_TYPE array_type) ID)
		 ;

longdeclarationbody: ( type ID ASSIGN expression  -> ^(VARDECLARATION ^(RETURN_TYPE type) ID expression))
					| (array_type ID ASSIGN expression -> ^(ARRAYDECLARATION ^(RETURN_TYPE array_type) ID expression))
					;

add: mul ( (ADD | SUB)^ mul )*;
mul: group ( (MUL | DIV)^ group)*;
compare: add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS)^ add )?  ;
term: add;
group: (SUB^)? (OPEN_BRACE! term CLOSE_BRACE! | number);

assignment: assignmentbody ';'!;
assignmentbody: (extended_id ASSIGN expression -> ^(VARASSIGNMENT extended_id expression)) | 
	( arrayelement ASSIGN expression -> ^(ARRAYELEMENTASSIGNMENT arrayelement expression));

boolexpression: boolterm ;
boolterm: or ( (EQ | NEQ)^ or )?;
or: and (OR^ and)*;
and: boolgroup (AND^ boolgroup)*;
boolgroup: (NOT^)? ( OPEN_BRACE! boolterm CLOSE_BRACE! | boolvar );
boolvar: TRUE
		| FALSE
		| compare;
		
block_or_statement: block | statement;
ifstatement: IF^ OPEN_BRACE! boolexpression CLOSE_BRACE! block_or_statement (ELSE! block_or_statement)* ;
whilestatement: WHILE^ OPEN_BRACE! boolexpression CLOSE_BRACE! block_or_statement  ;
forstatement: FOR^ OPEN_BRACE! longdeclarationbody? ';'! boolexpression? ';'! assignmentbody? CLOSE_BRACE! block_or_statement
		-> ^(FOR ^(FOR_INITIALIZATION longdeclarationbody) ^(FOR_CONDITION boolexpression) ^(FOR_ITERATION assignmentbody) block_or_statement);
returnstatement: RETURN^ expression? ';'! ;
dowhilestatement: DO^ (block | statement) WHILE! OPEN_BRACE! boolexpression CLOSE_BRACE! ';'! ;
emptystatement: ';'! ;

funcdeclaration: MODIFIER any_type ID^ ( OPEN_BRACE! paramsdeclaration CLOSE_BRACE! ) block 
		-> ^(FUNCDECLARATION ID ^(RETURN_TYPE any_type) OPEN_BRACE! paramsdeclaration CLOSE_BRACE! block);
paramsdeclaration: ( declarationbody ( ','! declarationbody)* )?  -> ^(PARAMETERS ( declarationbody)* );

funccallbody: extended_id^ OPEN_BRACE expressioncommalist? CLOSE_BRACE -> ^(FUNC_CALL extended_id ^(PARAMETERS expressioncommalist)?);
funccall: funccallbody ';'!;
expressioncommalist: expression ( ','! expression)*;

/*ARRAY HERE*/
object_initializer:  '{' expressioncommalist '}' -> expressioncommalist ;
newexpression: KNEW! initializer;
initializer: (simple_var_initializer | array_initializer);
simple_var_initializer: type OPEN_BRACE CLOSE_BRACE -> ^(NEWVAR type);
array_initializer: type ((OPEN_SQUARE_BRACE mathexpression CLOSE_SQUARE_BRACE) | ARRAY_DECLARATION_MARK) object_initializer?
		-> ^(ARRAY_INITIALIZER type ^(ARRAY_SIZE mathexpression?) ^(PARAMETERS object_initializer?));

block: '{'! statementlist '}'!;

statementlist: statement* -> ^(BLOCK statement*) ;

/*console_write_statement: CONSOLE_WORD '.'! ('WriteLine' | 'Write') OPEN_BRACE! expression CLOSE_BRACE! ';'! -> ^(PRINT expression)  ;
console_read_statement: console_read_body ';'! ;

console_read_body: CONSOLE_WORD '.'! ('ReadLine' | 'Read') OPEN_BRACE CLOSE_BRACE -> INPUT  ;
*/

/*
 * Lexer Rules
 */
KNEW: 'new';
ARRAY_DECLARATION_MARK: OPEN_SQUARE_BRACE CLOSE_SQUARE_BRACE;
OPEN_SQUARE_BRACE:'[';
CLOSE_SQUARE_BRACE:']';
OPEN_BRACE: '(';
CLOSE_BRACE: ')';
TYPE: 'int' | 'bool' | 'char';
VOID: 'void';
NUMBER: ('0'..'9')+ ;
ADD:    '+'     ;
SUB:    '-'     ;
MUL:    '*'     ;
DIV:    '/'     ;
ASSIGN: '='     ;
RETURN:	'return';
TRUE:   'true'  ;
FALSE:  'false' ; 
EQ:		'=='	;
NEQ:	'!='	;
GR:		'>'		;
GREQ:   '>='	;
LS:		'<'		;
LSEQ:	'<='	;
NOT:	'!'		;
OR:		'||'	;
AND:	'&&'	;
WS:
  ( ' ' | '\t' |  '\f' | '\r' | '\n' )+ {
    $channel=Hidden;
  }
;
DOT: '.';
MODIFIER: 'static';
//CHAR:  '\''('a'..'z')'\'' ;
CHAR:  '\'' . '\'' ;
ID:		( 'a'..'z' | 'A'..'Z' | '_' )
        ( 'a'..'z' | 'A'..'Z' | '_' | '0'..'9' )*
;


SL_COMMENT:
  '//' (options { greedy=false; }: .)* '\r'? '\n' {
    $channel=Hidden;
  }
;
ML_COMMENT:
  '/*' (options { greedy=false; }: .)* '*/' {
    $channel=Hidden;
  }
;



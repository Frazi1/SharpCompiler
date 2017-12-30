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
  FOR_INITIALIZATION;
  FOR_CONDITION;
  FOR_ITERATION;
  ARRAY_SIZE;
  EXTENDED_ID;
  MODIFIERS;
  FUNCTION_BODY;
  ATTRIBUTES;
  ATTRIBUTE_USAGE;
  NAMESPACE_DECLARATION;
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
	class_list -> ^(PROGRAM ^(NAMESPACE_DECLARATION) class_list) |
	namespace_declaration -> ^(PROGRAM namespace_declaration)
	EOF!
;

namespace_declaration: NAMESPACE extended_id OPEN_CURLY_BRACE class_list? CLOSE_CURLY_BRACE -> ^(NAMESPACE_DECLARATION extended_id class_list?); 
modifiers: MODIFIER* -> ^(MODIFIERS MODIFIER*);

class_declaration: modifiers CLASS_WORD ID class_block -> ^(CLASS_WORD ID modifiers class_block) ;

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

type: array_type | type | extended_id ;
array_type: t+=TYPE t+=ARRAY_DECLARATION_MARK ;
any_type: array_type | type | VOID;
number :  NUMBER
		| extended_id
		| funccallbody
		| CHAR
		| arrayelement
		| STRING
		;
mathexpression: term ;

expression:  
			 newexpression
		| boolexpression
		| mathexpression
	//	| funccallbody
;
extended_id: ID (DOT ID)* -> ^(EXTENDED_ID ID*);

arrayelement:  extended_id OPEN_SQUARE_BRACE mathexpression CLOSE_SQUARE_BRACE -> ^(ARRAYELEMENT extended_id mathexpression) ;
static_declaration:  MODIFIER declaration -> ^(STATIC_DECLARATION declaration);

declaration: var_declaration 
;
var_declaration: t=type! d_list[t.Tree] ';'!;

d_list[object type]: d[type] (','! d[type])* ;

d[object type]: declarationbody_d[type] | longdeclarationbody_d[type] ;

declarationbody_d[object type]: (ID -> ^(VARDECLARATION ^(RETURN_TYPE {$type}) ID) );				

longdeclarationbody_d[object type]: (ID ASSIGN expression  -> ^(VARDECLARATION ^(RETURN_TYPE {$type}) ID expression));

declarationbody: 
					type ID -> ^(VARDECLARATION ^(RETURN_TYPE type) ID )
;

longdeclarationbody: ( type ID ASSIGN expression  -> ^(VARDECLARATION ^(RETURN_TYPE type) ID expression))
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
for_initialization: (longdeclarationbody?) -> ^(FOR_INITIALIZATION longdeclarationbody?)
			| (assignmentbody?) -> ^(FOR_INITIALIZATION assignmentbody?)
			;
forstatement: FOR^ OPEN_BRACE! for_initialization ';'! boolexpression? ';'! assignmentbody? CLOSE_BRACE! block_or_statement
		-> ^(FOR for_initialization ^(FOR_CONDITION boolexpression?) ^(FOR_ITERATION assignmentbody?) block_or_statement);
returnstatement: RETURN^ expression? ';'! ;
dowhilestatement: DO^ (block | statement) WHILE! OPEN_BRACE! boolexpression CLOSE_BRACE! ';'! ;
emptystatement: ';'! ;

funcdeclaration: attribute_usage* modifiers any_type ID^ ( OPEN_BRACE! paramsdeclaration CLOSE_BRACE! ) (block | ';') 
		-> ^(FUNCDECLARATION ID modifiers ^(ATTRIBUTES attribute_usage*) ^(RETURN_TYPE any_type) paramsdeclaration ^(FUNCTION_BODY block?));
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

attribute_usage: OPEN_SQUARE_BRACE extended_id OPEN_BRACE expressioncommalist? CLOSE_BRACE CLOSE_SQUARE_BRACE 
	-> ^(ATTRIBUTE_USAGE extended_id ^(PARAMETERS expressioncommalist)?) ;


/*
 * Lexer Rules
 */
KNEW: 'new';
ARRAY_DECLARATION_MARK: OPEN_SQUARE_BRACE CLOSE_SQUARE_BRACE;
OPEN_SQUARE_BRACE:'[';
CLOSE_SQUARE_BRACE:']';
OPEN_BRACE: '(';
CLOSE_BRACE: ')';
OPEN_CURLY_BRACE: '{';
CLOSE_CURLY_BRACE : '}';

TYPE: 'int' 
	| 'bool'
	| 'char'
	| 'string'
;

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
USING: 'using';
NAMESPACE: 'namespace';
DOT: '.';
MODIFIER: 'static' | 'public' | 'extern' | 'private' | 'protected' | 'internal';
//CHAR:  '\''('a'..'z')'\'' ;
ID:		( 'a'..'z' | 'A'..'Z' | '_' )
        ( 'a'..'z' | 'A'..'Z' | '_' | '0'..'9' )*
;
STRING: '"' .*'"';
CHAR:  '\'' . '\'' ;


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
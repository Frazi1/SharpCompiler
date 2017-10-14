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
  MULT_DECL;
}


@lexer::namespace { MathLang }
@parser::namespace { MathLang }

/*
 * Parser Rules
 */

public execute:
	class_list EOF!  -> ^(PROGRAM class_list) 
;

class_declaration: MODIFIER CLASS_WORD ID class_block -> ^(CLASS_WORD ID class_block) ;

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
	
	 ) ;

type: TYPE ;
array_type: TYPE ARRAY_DECLARATION_MARK!;
any_type: type | array_type | VOID;
number :  NUMBER
		| extended_id
		| funccallbody
		| CHAR
		| arrayelement;
mathexpression: term ;

expression:  
			 newexpression
		| funccallbody
		| boolexpression
		| mathexpression
		
		
;
extended_id: ID (DOT! ID)? -> ^(ID ID?);

arrayelement:  extended_id OPEN_SQUARE_BRACE number CLOSE_SQUARE_BRACE -> ^(ARRAYELEMENT extended_id number) ;
static_declaration:  MODIFIER declaration -> ^(STATIC_DECLARATION declaration);

declaration: type d_list ';' -> ^(MULT_DECL type d_list) ;

d_list: d (','! d)* -> ^( VARS d d * ) ;

d: declarationbody_d | longdeclarationbody_d ;

/*declaration:  declarationbody ';'!
			| longdeclarationbody ';'! ;

*/
/*var_declaration: ID -> ^(VARDECLARATION ID);
array_declaration: ID -> ^(ARRAYDECLARATION ID))
*/

declarationbody_d: (ID -> ^(VARDECLARATION ID) )
				//| (array_type ID -> ^(ARRAYDECLARATION array_type ID))
				;
longdeclarationbody_d: (ID ASSIGN expression  -> ^(VARDECLARATION ID expression))
					//| (array_type ID ASSIGN newexpression -> ^(ARRAYDECLARATION array_type ID newexpression))
					;


declarationbody: (type ID -> ^(VARDECLARATION type ID) )
				| (array_type ID -> ^(ARRAYDECLARATION array_type ID))
				;
longdeclarationbody: ( type ID ASSIGN expression  -> ^(VARDECLARATION type ID expression))
					| (array_type ID ASSIGN newexpression -> ^(ARRAYDECLARATION array_type ID newexpression))
					;

add: mul ( (ADD | SUB)^ mul )*;
mul: group ( (MUL | DIV)^ group)*;
compare: add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS)^ add )?  ;
term: add;
group: (SUB^)? OPEN_BRACE! term CLOSE_BRACE! | number;

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
		
ifstatement: IF^ OPEN_BRACE! boolexpression CLOSE_BRACE! (block | statement) (ELSE! (block | statement))* ;
whilestatement: WHILE^ OPEN_BRACE! boolexpression CLOSE_BRACE! (block | statement);
forstatement: FOR^ OPEN_BRACE! longdeclarationbody ';'! boolexpression ';'! assignmentbody CLOSE_BRACE! (block | statement);
returnstatement: RETURN^ expression ';'! ;
dowhilestatement: DO^ (block | statement) WHILE! OPEN_BRACE! boolexpression CLOSE_BRACE! ';'! ;

funcdeclaration: MODIFIER any_type ID^ ( OPEN_BRACE! paramsdeclaration? CLOSE_BRACE! ) block -> ^(FUNCDECLARATION ID ^(RETURN_TYPE any_type) OPEN_BRACE! paramsdeclaration? CLOSE_BRACE! block);
paramsdeclaration: ( declarationbody ( ','! declarationbody)* )  -> ^(PARAMETERS ( declarationbody)* );

funccallbody: extended_id^ OPEN_BRACE expressioncommalist? CLOSE_BRACE -> ^(FUNC_CALL extended_id ^(PARAMETERS expressioncommalist)?);
funccall: funccallbody ';'!;
expressioncommalist: expression ( ','! expression)*;

/*ARRAY HERE*/
object_initializer:  '{' expressioncommalist '}' -> ^(PARAMETERS expressioncommalist) ;
newexpression: KNEW! initializer;
initializer: (simple_var_initializer | array_initializer);
simple_var_initializer: type OPEN_BRACE CLOSE_BRACE -> ^(NEWVAR type);
array_initializer: type ((OPEN_SQUARE_BRACE number CLOSE_SQUARE_BRACE) | ARRAY_DECLARATION_MARK) object_initializer? -> ^(ARRAY_INITIALIZER type number? object_initializer?);

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
CONSOLE_WORD: 'Console';
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



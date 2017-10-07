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
  BLOCK               ;
  PROGRAM             ;
  PARAMS              ;
  VARDECLARATION = 'vardeclaration';
  FUNCDECLARATION = 'funcdeclaration';
  ARRAYDECLARATION = 'arraydeclaration';
  VARASSIGNMENT = 'varassignment';
  ARRAYELEMENTASSIGNMENT = 'arrayelementassignment';
  ARRAYELEMENT = 'arrayelement';
  NEWWORD = 'newword';
  NEWVAR = 'newvar';
  ARRAY_INITIALIZER = 'array_initializer';
  OBJECT_INITIALIZER = 'object_initializer';
}


@lexer::namespace { MathLang }
@parser::namespace { MathLang }

/*
 * Parser Rules
 */

public execute:
	statementlist EOF!
;

statement: ( declaration 
	| assignment
	| ifstatement
	| whilestatement
	| forstatement
	| funcdeclaration
	| returnstatement
	| funccall
	| newexpression ';'!) ;

type: TYPE ;
//array_type: TYPE ('[' ']')+ ; 
array_type: TYPE ARRAY_DECLARATION_MARK;
any_type: type | array_type | VOID;
number :  NUMBER
		| ID
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

arrayelement:  ID '[' number ']' -> ^(ARRAYELEMENT ID number) ;

declaration: declarationbody ';'!
			| longdeclaration;

declarationbody: (type ID -> ^(VARDECLARATION type ID) )
				| (array_type ID -> ^(ARRAYDECLARATION array_type ID))
				;
longdeclaration: longdeclarationbody ';'! ;
longdeclarationbody: (type ID ASSIGN expression  -> ^(VARDECLARATION type ID expression))
					| (array_type ID ASSIGN expression -> ^(ARRAYDECLARATION array_type ID expression));

add: mul ( (ADD | SUB)^ mul )*;
mul: group ( (MUL | DIV)^ group)*;
compare: add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS)^ add )?  ;
term: add;
group: (SUB^)? '('! term ')'! | number;

assignment: assignmentbody ';'!;
assignmentbody: (ID ASSIGN expression -> ^(VARASSIGNMENT ID expression)) | 
	( arrayelement ASSIGN expression -> ^(ARRAYELEMENTASSIGNMENT arrayelement expression));

boolexpression: boolterm ;
boolterm: or ( (EQ | NEQ)^ or )?;
or: and (OR^ and)*;
and: boolgroup (AND^ boolgroup)*;
boolgroup: (NOT^)? ( '('! boolterm ')'! | boolvar );
boolvar: TRUE
		| FALSE
		| compare;

ifstatement: IF^ '('! boolexpression ')'! (block | statement) (ELSE! (block | statement))* ;
whilestatement: WHILE^ '('! boolexpression ')'! (block | statement);
forstatement: FOR^ '('! longdeclarationbody ';'! boolexpression ';'! assignmentbody ')'! (block | statement);
returnstatement: RETURN^ expression ';'! ;

funcdeclaration: any_type ID^ '('! paramsdeclaration? ')'! block -> ^(FUNCDECLARATION ID ^(RETURNS any_type) '('! paramsdeclaration? ')'! block);
paramsdeclaration: ( declarationbody ( ','! declarationbody)* )  -> ^(PARAMETERS ( declarationbody)* );

funccallbody: ID^ '(' expressioncommalist? ')';
funccall: funccallbody ';'!;
expressioncommalist: expression ( ','! expression)* -> ^(PARAMETERS (expression)* );

/*ARRAY HERE*/
object_initializer:  '{' expressioncommalist '}' -> ^(OBJECT_INITIALIZER expressioncommalist) ;
newexpression: simple_var_initializer | array_initializer ;
simple_var_initializer: KNEW type '(' expressioncommalist? ')' object_initializer? -> ^(NEWVAR type expressioncommalist? object_initializer?);
array_initializer: KNEW type '[' number ']' object_initializer? -> ^(ARRAY_INITIALIZER type '['! number? ']'! object_initializer?);

block: '{'! statementlist '}'!;

statementlist: statement* -> ^(BLOCK statement*) ;

/*
 * Lexer Rules
 */
KNEW: 'new';
ARRAY_DECLARATION_MARK: (SQRBL ','* SQRBR)+;
SQRBL:'[';
SQRBR:']';

TYPE: 'int' | 'bool' | 'char';
VOID: 'void';
ACCESS_MODIFIER: 'public' | 'private';
NUMBER: ('0'..'9')+ ;
ADD:    '+'     ;
SUB:    '-'     ;
MUL:    '*'     ;
DIV:    '/'     ;
ASSIGN: '='     ;
RETURN:	'return';
RETURNS:'returns';
TRUE: 'true'    ;
FALSE: 'false'  ; 
EQ:		'=='	;
NEQ:	'!='	;
GR:		'>'		;
GREQ:   '>='	;
LS:		'<'		;
LSEQ:	'<='	;
NOT:	'!'		;
PARAMETERS: 'parameters';
OR:		'||'	;
AND:	'&&'	;
WS:
  ( ' ' | '\t' |  '\f' | '\r' | '\n' )+ {
    $channel=Hidden;
  }
;
CHAR:  '\''('a'..'z')'\'' ;
ID:		('a'..'z')+;



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



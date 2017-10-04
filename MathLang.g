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
  VARASSIGNMENT = 'varassignment';
  ARRAYELEMENTASSIGNMENT = 'arrayelementassignment';
  ARRAYELEMENT = 'arrayelement';
  NEWWORD = 'newword';
  NEWVAR = 'newvar';
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
	| funccall) ;

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

declarationbody: TYPE ID -> ^(VARDECLARATION TYPE ID) ;
longdeclaration: longdeclarationbody ';'! ;
longdeclarationbody: (TYPE0 ID ASSIGN expression -> ^(VARDECLARATION TYPE0 ID expression)) 
		| (TYPE ID ASSIGN expression -> ^(VARDECLARATION TYPE ID expression) );

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

funcdeclaration: TYPE ID^ '('! paramsdeclaration? ')'! block -> ^(FUNCDECLARATION ID ^(RETURNS TYPE) '('! paramsdeclaration? ')'! block);
paramsdeclaration: ( declarationbody ( ','! declarationbody)* )  -> ^(PARAMETERS ( declarationbody)* );

funccallbody: ID^ '(' expressioncommalist? ')';
funccall: funccallbody ';'!;
expressioncommalist: expression ( ','! expression)* -> ^(PARAMETERS (expression)* );

/*ARRAY HERE*/
newexpression: (KNEW TYPE0 SQRBL! NUMBER SQRBR! NUMBER -> ^(NEWWORD TYPE0 NUMBER))  
		| (KNEW TYPE0 '()' -> ^(NEWVAR TYPE0));

block: '{'! statementlist '}'!;

statementlist: statement* -> ^(BLOCK statement*) ;

/*
 * Lexer Rules
 */
KNEW: 'new';
SQRBL:'[';
SQRBR:']';

TYPE:	('int' | 'bool' | 'char') SQRBL SQRBR;
TYPE0:	('int' | 'bool' | 'char') ;
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



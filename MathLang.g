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

number :	NUMBER
		| ID
		| CHAR;
mathexpression: term ;

expression:  funccallbody
			| boolexpression
			| mathexpression;

declaration: TYPE^ ID ';'!
			| longdeclaration;

declarationbody: TYPE^ ID ;

longdeclaration:TYPE ID ASSIGN expression ';'! -> ^(ASSIGN ^(TYPE ID) expression) ;

longdeclarationbody: TYPE ID ASSIGN expression -> ^(ASSIGN ^(TYPE ID) expression) ;

variable: (TYPE | ARRAY)^ ID;
add: mul ( (ADD | SUB)^ mul )*;
mul: group ( (MUL | DIV)^ group)*;
compare: add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS)^ add )?  ;

term: add;

group: '('! term ')'! | number;

assignment: ID ASSIGN^ expression ';'!;
assignmentbody: ID ASSIGN^ expression ;

boolexpression: boolterm;
boolterm: or ( (EQ | NEQ)^ or )?;
or: and (OR^ and)*;
and: boolgroup (AND^ boolgroup)*;
boolgroup: '('! boolterm ')'! | boolvar;
boolvar: TRUE
		| FALSE
		| compare;

ifstatement: IF^ '('! boolexpression ')'! (block | statement) (ELSE! (block | statement))* ;

whilestatement: WHILE^ '('! boolexpression ')'! (block | statement);

forstatement: FOR^ '('! longdeclarationbody ';'! boolexpression ';'! assignmentbody ')'! (block | statement);

funcdeclaration: TYPE ID^ '('! paramsdeclaration? ')'! block;

funccallbody: ID^ '(' expressioncommalist? ')';

funccall: funccallbody ';'!;

expressioncommalist: expression ( ','! expression)* -> ^(PARAMETERS (expression)* );

paramsdeclaration: ( declarationbody ( ','! declarationbody)* )  -> ^(PARAMETERS ( declarationbody)* );

block: '{'! statementlist '}'!;

statementlist: statement* -> ^(BLOCK statement*) ;

returnstatement: RETURN^ expression ';'! ;

/*
 * Lexer Rules
 */
ARRAY: (TYPE '[]');
TYPE:	'int' | 'bool' | 'char';
ACCESS_MODIFIER: 'public' | 'private';
NUMBER: ('0'..'9')+ ;
ADD:    '+'     ;
SUB:    '-'     ;
MUL:    '*'     ;
DIV:    '/'     ;
ASSIGN: '='     ;
RETURN:'return';
TRUE: 'true'    ;
FALSE: 'false'  ; 
EQ:		'=='	;
NEQ:	'!='	;
GR:		'>'		;
GREQ:   '>='	;
LS:		'<'		;
LSEQ:	'<='	;
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



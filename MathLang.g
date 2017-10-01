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
  FOR = 'for'         ;
  FUNCTION = 'function' ;
  RETURN = 'return'   ;
  WHILE = 'while'     ;
  BLOCK               ;
  PROGRAM             ;
  PARAMS              ;
  VAR				;
}


@lexer::namespace { MathLang }
@parser::namespace { MathLang }

/*
 * Parser Rules
 */

public execute:
	statement*
;

statement: (expression | declaration) ';'! ;
number :	NUMBER ;
expression: term ;
declaration: variable (ASSIGN expression)? -> ^(ASSIGN (variable expression)?);
variable: (TYPE | ARRAY) ID;
add: mul ( (ADD | SUB)^ mul )*;
mul: group ( (MUL | DIV)^ group)*;

term: add;

group: '(' term ')' | number;
/*
 * Lexer Rules
 */
ARRAY: (TYPE '[]');
TYPE:	'int';
NUMBER: ('0'..'9')+ ;
ID:		('a'..'z')+;
ADD:    '+'     ;
SUB:    '-'     ;
MUL:    '*'     ;
DIV:    '/'     ;
ASSIGN: '='     ;
WS:
  ( ' ' | '\t' |  '\f' | '\r' | '\n' )+ {
    $channel=Hidden;
  }
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



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

statement: (expression 
	| declaration 
	| assignment) ;

number :	NUMBER
		| ID;
mathexpression: term ;

expression:mathexpression
			| boolexpression;

declaration: TYPE^ ID ';'!
			| longdeclaration;
longdeclaration:TYPE ID ASSIGN expression ';'! -> ^(ASSIGN ^(TYPE ID) expression) ;

variable: (TYPE | ARRAY)^ ID;
add: mul ( (ADD | SUB)^ mul )*;
mul: group ( (MUL | DIV)^ group)*;
compare: add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS)^ add )?  ;

term: add;

group: '('! term ')'! | number;

assignment: ID ASSIGN^ expression ';'!;
boolexpression: boolterm;
boolterm: or;
or: and (OR^ and)*;
and: boolgroup (AND^ boolgroup)*;
boolgroup: '('! boolterm ')'! | boolvar;
boolvar: TRUE
		| FALSE
		| compare;


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

TRUE: 'true'    ;
FALSE: 'false'  ; 
EQ:		'=='	;
NEQ:	'!='	;
GR:		'>'		;
GREQ:   '>='	;
LS:		'<'		;
LSEQ:	'<='	;

OR:		'||'	;
AND:	'&&'	;
WS:
  ( ' ' | '\t' |  '\f' | '\r' | '\n' )+ {
    $channel=Hidden;
  }
;
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



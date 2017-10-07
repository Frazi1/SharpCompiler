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
  VARDECLARATION = 'vardeclaration';
  FUNCDECLARATION = 'funcdeclaration';
  ARRAYDECLARATION = 'arraydeclaration';
  VARASSIGNMENT = 'varassignment';
  ARRAYELEMENTASSIGNMENT = 'arrayelementassignment';
  ARRAYELEMENT = 'arrayelement';
  NEWVAR = 'newvar';
  ARRAY_INITIALIZER = 'array_initializer';
  OBJECT_INITIALIZER = 'object_initializer';
  FUNC_CALL = 'func_call';
  RETURN_TYPE = 'return_type';
  PARAMETERS = 'parameters';
}


@lexer::namespace { MathLang }
@parser::namespace { MathLang }

/*
 * Parser Rules
 */

public execute:
	func_list EOF!
;

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
	| console_write_statement
	| console_read_statement ) ;

type: TYPE ;
array_type: TYPE ARRAY_DECLARATION_MARK!;
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
		| console_read_body
		
;

arrayelement:  ID '[' number ']' -> ^(ARRAYELEMENT ID number) ;

declaration: declarationbody ';'!
			| longdeclaration;

declarationbody: (type ID -> ^(VARDECLARATION type ID) )
				| (array_type ID -> ^(ARRAYDECLARATION array_type ID))
				;
longdeclaration: longdeclarationbody ';'! ;
longdeclarationbody: (type ID ASSIGN expression  -> ^(VARDECLARATION type ID expression))
					| (array_type ID ASSIGN newexpression -> ^(ARRAYDECLARATION array_type ID newexpression));

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
dowhilestatement: DO^ (block | statement) WHILE! '('! boolexpression ')'! ';'! ;

funcdeclaration: any_type ID^ ( '('! paramsdeclaration? ')'! | '()'!) block -> ^(FUNCDECLARATION ID ^(RETURN_TYPE any_type) '('! paramsdeclaration? ')'! block);
paramsdeclaration: ( declarationbody ( ','! declarationbody)* )  -> ^(PARAMETERS ( declarationbody)* );

funccallbody: ID^ '(' expressioncommalist? ')' -> ^(FUNC_CALL ^(ID ^(PARAMETERS expressioncommalist)?));
funccall: funccallbody ';'!;
expressioncommalist: expression ( ','! expression)*;

/*ARRAY HERE*/
object_initializer:  '{' expressioncommalist '}' -> ^(PARAMETERS expressioncommalist) ;
newexpression: KNEW! initializer;
initializer: (simple_var_initializer | array_initializer);
simple_var_initializer: type '(' ')' -> ^(NEWVAR type);
array_initializer: type (('[' number ']') | ARRAY_DECLARATION_MARK) object_initializer? -> ^(ARRAY_INITIALIZER type number? object_initializer?);

block: '{'! statementlist '}'!;

statementlist: statement* -> ^(BLOCK statement*) ;

console_write_statement: CONSOLE_WORD '.'! ('WriteLine' | 'Write') '('! expression ')'! ';'! -> ^(PRINT expression)  ;
console_read_statement: console_read_body ';'! ;

console_read_body: CONSOLE_WORD '.'! ('ReadLine' | 'Read') '()' -> INPUT  ;

/*
 * Lexer Rules
 */
KNEW: 'new';
CONSOLE_WORD: 'Console';
ARRAY_DECLARATION_MARK: SQRBL SQRBR;
SQRBL:'[';
SQRBR:']';
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



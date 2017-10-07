// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-10-06 23:25:57

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;

namespace  MathLang 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:50:56")]
[System.CLSCompliant(false)]
public partial class MathLangLexer : Antlr.Runtime.Lexer
{
	public const int EOF=-1;
	public const int T__57=57;
	public const int T__58=58;
	public const int T__59=59;
	public const int T__60=60;
	public const int T__61=61;
	public const int T__62=62;
	public const int UNKNOWN=4;
	public const int PRINT=5;
	public const int INPUT=6;
	public const int IF=7;
	public const int ELSE=8;
	public const int FOR=9;
	public const int FUNCTION=10;
	public const int RETURN=11;
	public const int WHILE=12;
	public const int BLOCK=13;
	public const int PROGRAM=14;
	public const int PARAMS=15;
	public const int VARDECLARATION=16;
	public const int FUNCDECLARATION=17;
	public const int ARRAYDECLARATION=18;
	public const int VARASSIGNMENT=19;
	public const int ARRAYELEMENTASSIGNMENT=20;
	public const int ARRAYELEMENT=21;
	public const int NEWWORD=22;
	public const int NEWVAR=23;
	public const int ARRAY_INITIALIZER=24;
	public const int OBJECT_INITIALIZER=25;
	public const int TYPE=26;
	public const int ARRAY_DECLARATION_MARK=27;
	public const int VOID=28;
	public const int NUMBER=29;
	public const int ID=30;
	public const int CHAR=31;
	public const int ASSIGN=32;
	public const int ADD=33;
	public const int SUB=34;
	public const int MUL=35;
	public const int DIV=36;
	public const int GREQ=37;
	public const int LSEQ=38;
	public const int NEQ=39;
	public const int EQ=40;
	public const int GR=41;
	public const int LS=42;
	public const int OR=43;
	public const int AND=44;
	public const int NOT=45;
	public const int TRUE=46;
	public const int FALSE=47;
	public const int KNEW=48;
	public const int SQRBL=49;
	public const int SQRBR=50;
	public const int ACCESS_MODIFIER=51;
	public const int RETURNS=52;
	public const int PARAMETERS=53;
	public const int WS=54;
	public const int SL_COMMENT=55;
	public const int ML_COMMENT=56;

    // delegates
    // delegators

	public MathLangLexer()
	{
		OnCreated();
	}

	public MathLangLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public MathLangLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{


		OnCreated();
	}
	public override string GrammarFileName { get { return "MathLang.g"; } }

	private static readonly bool[] decisionCanBacktrack = new bool[0];


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void Enter_PRINT();
	partial void Leave_PRINT();

	// $ANTLR start "PRINT"
	[GrammarRule("PRINT")]
	private void mPRINT()
	{
		Enter_PRINT();
		EnterRule("PRINT", 1);
		TraceIn("PRINT", 1);
		try
		{
			int _type = PRINT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:9:7: ( 'print' )
			DebugEnterAlt(1);
			// MathLang.g:9:9: 'print'
			{
			DebugLocation(9, 9);
			Match("print"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PRINT", 1);
			LeaveRule("PRINT", 1);
			Leave_PRINT();
		}
	}
	// $ANTLR end "PRINT"

	partial void Enter_INPUT();
	partial void Leave_INPUT();

	// $ANTLR start "INPUT"
	[GrammarRule("INPUT")]
	private void mINPUT()
	{
		Enter_INPUT();
		EnterRule("INPUT", 2);
		TraceIn("INPUT", 2);
		try
		{
			int _type = INPUT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:10:7: ( 'input' )
			DebugEnterAlt(1);
			// MathLang.g:10:9: 'input'
			{
			DebugLocation(10, 9);
			Match("input"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("INPUT", 2);
			LeaveRule("INPUT", 2);
			Leave_INPUT();
		}
	}
	// $ANTLR end "INPUT"

	partial void Enter_IF();
	partial void Leave_IF();

	// $ANTLR start "IF"
	[GrammarRule("IF")]
	private void mIF()
	{
		Enter_IF();
		EnterRule("IF", 3);
		TraceIn("IF", 3);
		try
		{
			int _type = IF;
			int _channel = DefaultTokenChannel;
			// MathLang.g:11:4: ( 'if' )
			DebugEnterAlt(1);
			// MathLang.g:11:6: 'if'
			{
			DebugLocation(11, 6);
			Match("if"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IF", 3);
			LeaveRule("IF", 3);
			Leave_IF();
		}
	}
	// $ANTLR end "IF"

	partial void Enter_ELSE();
	partial void Leave_ELSE();

	// $ANTLR start "ELSE"
	[GrammarRule("ELSE")]
	private void mELSE()
	{
		Enter_ELSE();
		EnterRule("ELSE", 4);
		TraceIn("ELSE", 4);
		try
		{
			int _type = ELSE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:12:6: ( 'else' )
			DebugEnterAlt(1);
			// MathLang.g:12:8: 'else'
			{
			DebugLocation(12, 8);
			Match("else"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ELSE", 4);
			LeaveRule("ELSE", 4);
			Leave_ELSE();
		}
	}
	// $ANTLR end "ELSE"

	partial void Enter_FOR();
	partial void Leave_FOR();

	// $ANTLR start "FOR"
	[GrammarRule("FOR")]
	private void mFOR()
	{
		Enter_FOR();
		EnterRule("FOR", 5);
		TraceIn("FOR", 5);
		try
		{
			int _type = FOR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:13:5: ( 'for' )
			DebugEnterAlt(1);
			// MathLang.g:13:7: 'for'
			{
			DebugLocation(13, 7);
			Match("for"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FOR", 5);
			LeaveRule("FOR", 5);
			Leave_FOR();
		}
	}
	// $ANTLR end "FOR"

	partial void Enter_FUNCTION();
	partial void Leave_FUNCTION();

	// $ANTLR start "FUNCTION"
	[GrammarRule("FUNCTION")]
	private void mFUNCTION()
	{
		Enter_FUNCTION();
		EnterRule("FUNCTION", 6);
		TraceIn("FUNCTION", 6);
		try
		{
			int _type = FUNCTION;
			int _channel = DefaultTokenChannel;
			// MathLang.g:14:10: ( 'function' )
			DebugEnterAlt(1);
			// MathLang.g:14:12: 'function'
			{
			DebugLocation(14, 12);
			Match("function"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FUNCTION", 6);
			LeaveRule("FUNCTION", 6);
			Leave_FUNCTION();
		}
	}
	// $ANTLR end "FUNCTION"

	partial void Enter_WHILE();
	partial void Leave_WHILE();

	// $ANTLR start "WHILE"
	[GrammarRule("WHILE")]
	private void mWHILE()
	{
		Enter_WHILE();
		EnterRule("WHILE", 7);
		TraceIn("WHILE", 7);
		try
		{
			int _type = WHILE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:15:7: ( 'while' )
			DebugEnterAlt(1);
			// MathLang.g:15:9: 'while'
			{
			DebugLocation(15, 9);
			Match("while"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WHILE", 7);
			LeaveRule("WHILE", 7);
			Leave_WHILE();
		}
	}
	// $ANTLR end "WHILE"

	partial void Enter_VARDECLARATION();
	partial void Leave_VARDECLARATION();

	// $ANTLR start "VARDECLARATION"
	[GrammarRule("VARDECLARATION")]
	private void mVARDECLARATION()
	{
		Enter_VARDECLARATION();
		EnterRule("VARDECLARATION", 8);
		TraceIn("VARDECLARATION", 8);
		try
		{
			int _type = VARDECLARATION;
			int _channel = DefaultTokenChannel;
			// MathLang.g:16:16: ( 'vardeclaration' )
			DebugEnterAlt(1);
			// MathLang.g:16:18: 'vardeclaration'
			{
			DebugLocation(16, 18);
			Match("vardeclaration"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("VARDECLARATION", 8);
			LeaveRule("VARDECLARATION", 8);
			Leave_VARDECLARATION();
		}
	}
	// $ANTLR end "VARDECLARATION"

	partial void Enter_FUNCDECLARATION();
	partial void Leave_FUNCDECLARATION();

	// $ANTLR start "FUNCDECLARATION"
	[GrammarRule("FUNCDECLARATION")]
	private void mFUNCDECLARATION()
	{
		Enter_FUNCDECLARATION();
		EnterRule("FUNCDECLARATION", 9);
		TraceIn("FUNCDECLARATION", 9);
		try
		{
			int _type = FUNCDECLARATION;
			int _channel = DefaultTokenChannel;
			// MathLang.g:17:17: ( 'funcdeclaration' )
			DebugEnterAlt(1);
			// MathLang.g:17:19: 'funcdeclaration'
			{
			DebugLocation(17, 19);
			Match("funcdeclaration"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FUNCDECLARATION", 9);
			LeaveRule("FUNCDECLARATION", 9);
			Leave_FUNCDECLARATION();
		}
	}
	// $ANTLR end "FUNCDECLARATION"

	partial void Enter_ARRAYDECLARATION();
	partial void Leave_ARRAYDECLARATION();

	// $ANTLR start "ARRAYDECLARATION"
	[GrammarRule("ARRAYDECLARATION")]
	private void mARRAYDECLARATION()
	{
		Enter_ARRAYDECLARATION();
		EnterRule("ARRAYDECLARATION", 10);
		TraceIn("ARRAYDECLARATION", 10);
		try
		{
			int _type = ARRAYDECLARATION;
			int _channel = DefaultTokenChannel;
			// MathLang.g:18:18: ( 'arraydeclaration' )
			DebugEnterAlt(1);
			// MathLang.g:18:20: 'arraydeclaration'
			{
			DebugLocation(18, 20);
			Match("arraydeclaration"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ARRAYDECLARATION", 10);
			LeaveRule("ARRAYDECLARATION", 10);
			Leave_ARRAYDECLARATION();
		}
	}
	// $ANTLR end "ARRAYDECLARATION"

	partial void Enter_VARASSIGNMENT();
	partial void Leave_VARASSIGNMENT();

	// $ANTLR start "VARASSIGNMENT"
	[GrammarRule("VARASSIGNMENT")]
	private void mVARASSIGNMENT()
	{
		Enter_VARASSIGNMENT();
		EnterRule("VARASSIGNMENT", 11);
		TraceIn("VARASSIGNMENT", 11);
		try
		{
			int _type = VARASSIGNMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:19:15: ( 'varassignment' )
			DebugEnterAlt(1);
			// MathLang.g:19:17: 'varassignment'
			{
			DebugLocation(19, 17);
			Match("varassignment"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("VARASSIGNMENT", 11);
			LeaveRule("VARASSIGNMENT", 11);
			Leave_VARASSIGNMENT();
		}
	}
	// $ANTLR end "VARASSIGNMENT"

	partial void Enter_ARRAYELEMENTASSIGNMENT();
	partial void Leave_ARRAYELEMENTASSIGNMENT();

	// $ANTLR start "ARRAYELEMENTASSIGNMENT"
	[GrammarRule("ARRAYELEMENTASSIGNMENT")]
	private void mARRAYELEMENTASSIGNMENT()
	{
		Enter_ARRAYELEMENTASSIGNMENT();
		EnterRule("ARRAYELEMENTASSIGNMENT", 12);
		TraceIn("ARRAYELEMENTASSIGNMENT", 12);
		try
		{
			int _type = ARRAYELEMENTASSIGNMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:20:24: ( 'arrayelementassignment' )
			DebugEnterAlt(1);
			// MathLang.g:20:26: 'arrayelementassignment'
			{
			DebugLocation(20, 26);
			Match("arrayelementassignment"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ARRAYELEMENTASSIGNMENT", 12);
			LeaveRule("ARRAYELEMENTASSIGNMENT", 12);
			Leave_ARRAYELEMENTASSIGNMENT();
		}
	}
	// $ANTLR end "ARRAYELEMENTASSIGNMENT"

	partial void Enter_ARRAYELEMENT();
	partial void Leave_ARRAYELEMENT();

	// $ANTLR start "ARRAYELEMENT"
	[GrammarRule("ARRAYELEMENT")]
	private void mARRAYELEMENT()
	{
		Enter_ARRAYELEMENT();
		EnterRule("ARRAYELEMENT", 13);
		TraceIn("ARRAYELEMENT", 13);
		try
		{
			int _type = ARRAYELEMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:21:14: ( 'arrayelement' )
			DebugEnterAlt(1);
			// MathLang.g:21:16: 'arrayelement'
			{
			DebugLocation(21, 16);
			Match("arrayelement"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ARRAYELEMENT", 13);
			LeaveRule("ARRAYELEMENT", 13);
			Leave_ARRAYELEMENT();
		}
	}
	// $ANTLR end "ARRAYELEMENT"

	partial void Enter_NEWWORD();
	partial void Leave_NEWWORD();

	// $ANTLR start "NEWWORD"
	[GrammarRule("NEWWORD")]
	private void mNEWWORD()
	{
		Enter_NEWWORD();
		EnterRule("NEWWORD", 14);
		TraceIn("NEWWORD", 14);
		try
		{
			int _type = NEWWORD;
			int _channel = DefaultTokenChannel;
			// MathLang.g:22:9: ( 'newword' )
			DebugEnterAlt(1);
			// MathLang.g:22:11: 'newword'
			{
			DebugLocation(22, 11);
			Match("newword"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NEWWORD", 14);
			LeaveRule("NEWWORD", 14);
			Leave_NEWWORD();
		}
	}
	// $ANTLR end "NEWWORD"

	partial void Enter_NEWVAR();
	partial void Leave_NEWVAR();

	// $ANTLR start "NEWVAR"
	[GrammarRule("NEWVAR")]
	private void mNEWVAR()
	{
		Enter_NEWVAR();
		EnterRule("NEWVAR", 15);
		TraceIn("NEWVAR", 15);
		try
		{
			int _type = NEWVAR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:23:8: ( 'newvar' )
			DebugEnterAlt(1);
			// MathLang.g:23:10: 'newvar'
			{
			DebugLocation(23, 10);
			Match("newvar"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NEWVAR", 15);
			LeaveRule("NEWVAR", 15);
			Leave_NEWVAR();
		}
	}
	// $ANTLR end "NEWVAR"

	partial void Enter_ARRAY_INITIALIZER();
	partial void Leave_ARRAY_INITIALIZER();

	// $ANTLR start "ARRAY_INITIALIZER"
	[GrammarRule("ARRAY_INITIALIZER")]
	private void mARRAY_INITIALIZER()
	{
		Enter_ARRAY_INITIALIZER();
		EnterRule("ARRAY_INITIALIZER", 16);
		TraceIn("ARRAY_INITIALIZER", 16);
		try
		{
			int _type = ARRAY_INITIALIZER;
			int _channel = DefaultTokenChannel;
			// MathLang.g:24:19: ( 'array_initializer' )
			DebugEnterAlt(1);
			// MathLang.g:24:21: 'array_initializer'
			{
			DebugLocation(24, 21);
			Match("array_initializer"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ARRAY_INITIALIZER", 16);
			LeaveRule("ARRAY_INITIALIZER", 16);
			Leave_ARRAY_INITIALIZER();
		}
	}
	// $ANTLR end "ARRAY_INITIALIZER"

	partial void Enter_OBJECT_INITIALIZER();
	partial void Leave_OBJECT_INITIALIZER();

	// $ANTLR start "OBJECT_INITIALIZER"
	[GrammarRule("OBJECT_INITIALIZER")]
	private void mOBJECT_INITIALIZER()
	{
		Enter_OBJECT_INITIALIZER();
		EnterRule("OBJECT_INITIALIZER", 17);
		TraceIn("OBJECT_INITIALIZER", 17);
		try
		{
			int _type = OBJECT_INITIALIZER;
			int _channel = DefaultTokenChannel;
			// MathLang.g:25:20: ( 'object_initializer' )
			DebugEnterAlt(1);
			// MathLang.g:25:22: 'object_initializer'
			{
			DebugLocation(25, 22);
			Match("object_initializer"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OBJECT_INITIALIZER", 17);
			LeaveRule("OBJECT_INITIALIZER", 17);
			Leave_OBJECT_INITIALIZER();
		}
	}
	// $ANTLR end "OBJECT_INITIALIZER"

	partial void Enter_T__57();
	partial void Leave_T__57();

	// $ANTLR start "T__57"
	[GrammarRule("T__57")]
	private void mT__57()
	{
		Enter_T__57();
		EnterRule("T__57", 18);
		TraceIn("T__57", 18);
		try
		{
			int _type = T__57;
			int _channel = DefaultTokenChannel;
			// MathLang.g:26:7: ( ';' )
			DebugEnterAlt(1);
			// MathLang.g:26:9: ';'
			{
			DebugLocation(26, 9);
			Match(';'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__57", 18);
			LeaveRule("T__57", 18);
			Leave_T__57();
		}
	}
	// $ANTLR end "T__57"

	partial void Enter_T__58();
	partial void Leave_T__58();

	// $ANTLR start "T__58"
	[GrammarRule("T__58")]
	private void mT__58()
	{
		Enter_T__58();
		EnterRule("T__58", 19);
		TraceIn("T__58", 19);
		try
		{
			int _type = T__58;
			int _channel = DefaultTokenChannel;
			// MathLang.g:27:7: ( '(' )
			DebugEnterAlt(1);
			// MathLang.g:27:9: '('
			{
			DebugLocation(27, 9);
			Match('('); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__58", 19);
			LeaveRule("T__58", 19);
			Leave_T__58();
		}
	}
	// $ANTLR end "T__58"

	partial void Enter_T__59();
	partial void Leave_T__59();

	// $ANTLR start "T__59"
	[GrammarRule("T__59")]
	private void mT__59()
	{
		Enter_T__59();
		EnterRule("T__59", 20);
		TraceIn("T__59", 20);
		try
		{
			int _type = T__59;
			int _channel = DefaultTokenChannel;
			// MathLang.g:28:7: ( ')' )
			DebugEnterAlt(1);
			// MathLang.g:28:9: ')'
			{
			DebugLocation(28, 9);
			Match(')'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__59", 20);
			LeaveRule("T__59", 20);
			Leave_T__59();
		}
	}
	// $ANTLR end "T__59"

	partial void Enter_T__60();
	partial void Leave_T__60();

	// $ANTLR start "T__60"
	[GrammarRule("T__60")]
	private void mT__60()
	{
		Enter_T__60();
		EnterRule("T__60", 21);
		TraceIn("T__60", 21);
		try
		{
			int _type = T__60;
			int _channel = DefaultTokenChannel;
			// MathLang.g:29:7: ( ',' )
			DebugEnterAlt(1);
			// MathLang.g:29:9: ','
			{
			DebugLocation(29, 9);
			Match(','); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__60", 21);
			LeaveRule("T__60", 21);
			Leave_T__60();
		}
	}
	// $ANTLR end "T__60"

	partial void Enter_T__61();
	partial void Leave_T__61();

	// $ANTLR start "T__61"
	[GrammarRule("T__61")]
	private void mT__61()
	{
		Enter_T__61();
		EnterRule("T__61", 22);
		TraceIn("T__61", 22);
		try
		{
			int _type = T__61;
			int _channel = DefaultTokenChannel;
			// MathLang.g:30:7: ( '{' )
			DebugEnterAlt(1);
			// MathLang.g:30:9: '{'
			{
			DebugLocation(30, 9);
			Match('{'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__61", 22);
			LeaveRule("T__61", 22);
			Leave_T__61();
		}
	}
	// $ANTLR end "T__61"

	partial void Enter_T__62();
	partial void Leave_T__62();

	// $ANTLR start "T__62"
	[GrammarRule("T__62")]
	private void mT__62()
	{
		Enter_T__62();
		EnterRule("T__62", 23);
		TraceIn("T__62", 23);
		try
		{
			int _type = T__62;
			int _channel = DefaultTokenChannel;
			// MathLang.g:31:7: ( '}' )
			DebugEnterAlt(1);
			// MathLang.g:31:9: '}'
			{
			DebugLocation(31, 9);
			Match('}'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__62", 23);
			LeaveRule("T__62", 23);
			Leave_T__62();
		}
	}
	// $ANTLR end "T__62"

	partial void Enter_KNEW();
	partial void Leave_KNEW();

	// $ANTLR start "KNEW"
	[GrammarRule("KNEW")]
	private void mKNEW()
	{
		Enter_KNEW();
		EnterRule("KNEW", 24);
		TraceIn("KNEW", 24);
		try
		{
			int _type = KNEW;
			int _channel = DefaultTokenChannel;
			// MathLang.g:134:5: ( 'new' )
			DebugEnterAlt(1);
			// MathLang.g:134:7: 'new'
			{
			DebugLocation(134, 7);
			Match("new"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("KNEW", 24);
			LeaveRule("KNEW", 24);
			Leave_KNEW();
		}
	}
	// $ANTLR end "KNEW"

	partial void Enter_ARRAY_DECLARATION_MARK();
	partial void Leave_ARRAY_DECLARATION_MARK();

	// $ANTLR start "ARRAY_DECLARATION_MARK"
	[GrammarRule("ARRAY_DECLARATION_MARK")]
	private void mARRAY_DECLARATION_MARK()
	{
		Enter_ARRAY_DECLARATION_MARK();
		EnterRule("ARRAY_DECLARATION_MARK", 25);
		TraceIn("ARRAY_DECLARATION_MARK", 25);
		try
		{
			int _type = ARRAY_DECLARATION_MARK;
			int _channel = DefaultTokenChannel;
			// MathLang.g:135:23: ( ( SQRBL ( ',' )* SQRBR )+ )
			DebugEnterAlt(1);
			// MathLang.g:135:25: ( SQRBL ( ',' )* SQRBR )+
			{
			DebugLocation(135, 25);
			// MathLang.g:135:25: ( SQRBL ( ',' )* SQRBR )+
			int cnt2=0;
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
				int LA2_0 = input.LA(1);

				if ((LA2_0=='['))
				{
					alt2=1;
				}


				} finally { DebugExitDecision(2); }
				switch (alt2)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:135:26: SQRBL ( ',' )* SQRBR
					{
					DebugLocation(135, 26);
					mSQRBL(); 
					DebugLocation(135, 32);
					// MathLang.g:135:32: ( ',' )*
					try { DebugEnterSubRule(1);
					while (true)
					{
						int alt1=2;
						try { DebugEnterDecision(1, decisionCanBacktrack[1]);
						int LA1_0 = input.LA(1);

						if ((LA1_0==','))
						{
							alt1=1;
						}


						} finally { DebugExitDecision(1); }
						switch ( alt1 )
						{
						case 1:
							DebugEnterAlt(1);
							// MathLang.g:135:32: ','
							{
							DebugLocation(135, 32);
							Match(','); 

							}
							break;

						default:
							goto loop1;
						}
					}

					loop1:
						;

					} finally { DebugExitSubRule(1); }

					DebugLocation(135, 37);
					mSQRBR(); 

					}
					break;

				default:
					if (cnt2 >= 1)
						goto loop2;

					EarlyExitException eee2 = new EarlyExitException( 2, input );
					DebugRecognitionException(eee2);
					throw eee2;
				}
				cnt2++;
			}
			loop2:
				;

			} finally { DebugExitSubRule(2); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ARRAY_DECLARATION_MARK", 25);
			LeaveRule("ARRAY_DECLARATION_MARK", 25);
			Leave_ARRAY_DECLARATION_MARK();
		}
	}
	// $ANTLR end "ARRAY_DECLARATION_MARK"

	partial void Enter_SQRBL();
	partial void Leave_SQRBL();

	// $ANTLR start "SQRBL"
	[GrammarRule("SQRBL")]
	private void mSQRBL()
	{
		Enter_SQRBL();
		EnterRule("SQRBL", 26);
		TraceIn("SQRBL", 26);
		try
		{
			int _type = SQRBL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:136:6: ( '[' )
			DebugEnterAlt(1);
			// MathLang.g:136:7: '['
			{
			DebugLocation(136, 7);
			Match('['); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SQRBL", 26);
			LeaveRule("SQRBL", 26);
			Leave_SQRBL();
		}
	}
	// $ANTLR end "SQRBL"

	partial void Enter_SQRBR();
	partial void Leave_SQRBR();

	// $ANTLR start "SQRBR"
	[GrammarRule("SQRBR")]
	private void mSQRBR()
	{
		Enter_SQRBR();
		EnterRule("SQRBR", 27);
		TraceIn("SQRBR", 27);
		try
		{
			int _type = SQRBR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:137:6: ( ']' )
			DebugEnterAlt(1);
			// MathLang.g:137:7: ']'
			{
			DebugLocation(137, 7);
			Match(']'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SQRBR", 27);
			LeaveRule("SQRBR", 27);
			Leave_SQRBR();
		}
	}
	// $ANTLR end "SQRBR"

	partial void Enter_TYPE();
	partial void Leave_TYPE();

	// $ANTLR start "TYPE"
	[GrammarRule("TYPE")]
	private void mTYPE()
	{
		Enter_TYPE();
		EnterRule("TYPE", 28);
		TraceIn("TYPE", 28);
		try
		{
			int _type = TYPE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:139:5: ( 'int' | 'bool' | 'char' )
			int alt3=3;
			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
			switch (input.LA(1))
			{
			case 'i':
				{
				alt3=1;
				}
				break;
			case 'b':
				{
				alt3=2;
				}
				break;
			case 'c':
				{
				alt3=3;
				}
				break;
			default:
				{
					NoViableAltException nvae = new NoViableAltException("", 3, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(3); }
			switch (alt3)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:139:7: 'int'
				{
				DebugLocation(139, 7);
				Match("int"); 


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:139:15: 'bool'
				{
				DebugLocation(139, 15);
				Match("bool"); 


				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:139:24: 'char'
				{
				DebugLocation(139, 24);
				Match("char"); 


				}
				break;

			}
			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TYPE", 28);
			LeaveRule("TYPE", 28);
			Leave_TYPE();
		}
	}
	// $ANTLR end "TYPE"

	partial void Enter_VOID();
	partial void Leave_VOID();

	// $ANTLR start "VOID"
	[GrammarRule("VOID")]
	private void mVOID()
	{
		Enter_VOID();
		EnterRule("VOID", 29);
		TraceIn("VOID", 29);
		try
		{
			int _type = VOID;
			int _channel = DefaultTokenChannel;
			// MathLang.g:140:5: ( 'void' )
			DebugEnterAlt(1);
			// MathLang.g:140:7: 'void'
			{
			DebugLocation(140, 7);
			Match("void"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("VOID", 29);
			LeaveRule("VOID", 29);
			Leave_VOID();
		}
	}
	// $ANTLR end "VOID"

	partial void Enter_ACCESS_MODIFIER();
	partial void Leave_ACCESS_MODIFIER();

	// $ANTLR start "ACCESS_MODIFIER"
	[GrammarRule("ACCESS_MODIFIER")]
	private void mACCESS_MODIFIER()
	{
		Enter_ACCESS_MODIFIER();
		EnterRule("ACCESS_MODIFIER", 30);
		TraceIn("ACCESS_MODIFIER", 30);
		try
		{
			int _type = ACCESS_MODIFIER;
			int _channel = DefaultTokenChannel;
			// MathLang.g:141:16: ( 'public' | 'private' )
			int alt4=2;
			try { DebugEnterDecision(4, decisionCanBacktrack[4]);
			int LA4_0 = input.LA(1);

			if ((LA4_0=='p'))
			{
				int LA4_1 = input.LA(2);

				if ((LA4_1=='u'))
				{
					alt4=1;
				}
				else if ((LA4_1=='r'))
				{
					alt4=2;
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 4, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 4, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(4); }
			switch (alt4)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:141:18: 'public'
				{
				DebugLocation(141, 18);
				Match("public"); 


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:141:29: 'private'
				{
				DebugLocation(141, 29);
				Match("private"); 


				}
				break;

			}
			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ACCESS_MODIFIER", 30);
			LeaveRule("ACCESS_MODIFIER", 30);
			Leave_ACCESS_MODIFIER();
		}
	}
	// $ANTLR end "ACCESS_MODIFIER"

	partial void Enter_NUMBER();
	partial void Leave_NUMBER();

	// $ANTLR start "NUMBER"
	[GrammarRule("NUMBER")]
	private void mNUMBER()
	{
		Enter_NUMBER();
		EnterRule("NUMBER", 31);
		TraceIn("NUMBER", 31);
		try
		{
			int _type = NUMBER;
			int _channel = DefaultTokenChannel;
			// MathLang.g:142:7: ( ( '0' .. '9' )+ )
			DebugEnterAlt(1);
			// MathLang.g:142:9: ( '0' .. '9' )+
			{
			DebugLocation(142, 9);
			// MathLang.g:142:9: ( '0' .. '9' )+
			int cnt5=0;
			try { DebugEnterSubRule(5);
			while (true)
			{
				int alt5=2;
				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
				int LA5_0 = input.LA(1);

				if (((LA5_0>='0' && LA5_0<='9')))
				{
					alt5=1;
				}


				} finally { DebugExitDecision(5); }
				switch (alt5)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:142:10: '0' .. '9'
					{
					DebugLocation(142, 10);
					MatchRange('0','9'); 

					}
					break;

				default:
					if (cnt5 >= 1)
						goto loop5;

					EarlyExitException eee5 = new EarlyExitException( 5, input );
					DebugRecognitionException(eee5);
					throw eee5;
				}
				cnt5++;
			}
			loop5:
				;

			} finally { DebugExitSubRule(5); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NUMBER", 31);
			LeaveRule("NUMBER", 31);
			Leave_NUMBER();
		}
	}
	// $ANTLR end "NUMBER"

	partial void Enter_ADD();
	partial void Leave_ADD();

	// $ANTLR start "ADD"
	[GrammarRule("ADD")]
	private void mADD()
	{
		Enter_ADD();
		EnterRule("ADD", 32);
		TraceIn("ADD", 32);
		try
		{
			int _type = ADD;
			int _channel = DefaultTokenChannel;
			// MathLang.g:143:4: ( '+' )
			DebugEnterAlt(1);
			// MathLang.g:143:9: '+'
			{
			DebugLocation(143, 9);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ADD", 32);
			LeaveRule("ADD", 32);
			Leave_ADD();
		}
	}
	// $ANTLR end "ADD"

	partial void Enter_SUB();
	partial void Leave_SUB();

	// $ANTLR start "SUB"
	[GrammarRule("SUB")]
	private void mSUB()
	{
		Enter_SUB();
		EnterRule("SUB", 33);
		TraceIn("SUB", 33);
		try
		{
			int _type = SUB;
			int _channel = DefaultTokenChannel;
			// MathLang.g:144:4: ( '-' )
			DebugEnterAlt(1);
			// MathLang.g:144:9: '-'
			{
			DebugLocation(144, 9);
			Match('-'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SUB", 33);
			LeaveRule("SUB", 33);
			Leave_SUB();
		}
	}
	// $ANTLR end "SUB"

	partial void Enter_MUL();
	partial void Leave_MUL();

	// $ANTLR start "MUL"
	[GrammarRule("MUL")]
	private void mMUL()
	{
		Enter_MUL();
		EnterRule("MUL", 34);
		TraceIn("MUL", 34);
		try
		{
			int _type = MUL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:145:4: ( '*' )
			DebugEnterAlt(1);
			// MathLang.g:145:9: '*'
			{
			DebugLocation(145, 9);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MUL", 34);
			LeaveRule("MUL", 34);
			Leave_MUL();
		}
	}
	// $ANTLR end "MUL"

	partial void Enter_DIV();
	partial void Leave_DIV();

	// $ANTLR start "DIV"
	[GrammarRule("DIV")]
	private void mDIV()
	{
		Enter_DIV();
		EnterRule("DIV", 35);
		TraceIn("DIV", 35);
		try
		{
			int _type = DIV;
			int _channel = DefaultTokenChannel;
			// MathLang.g:146:4: ( '/' )
			DebugEnterAlt(1);
			// MathLang.g:146:9: '/'
			{
			DebugLocation(146, 9);
			Match('/'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DIV", 35);
			LeaveRule("DIV", 35);
			Leave_DIV();
		}
	}
	// $ANTLR end "DIV"

	partial void Enter_ASSIGN();
	partial void Leave_ASSIGN();

	// $ANTLR start "ASSIGN"
	[GrammarRule("ASSIGN")]
	private void mASSIGN()
	{
		Enter_ASSIGN();
		EnterRule("ASSIGN", 36);
		TraceIn("ASSIGN", 36);
		try
		{
			int _type = ASSIGN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:147:7: ( '=' )
			DebugEnterAlt(1);
			// MathLang.g:147:9: '='
			{
			DebugLocation(147, 9);
			Match('='); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ASSIGN", 36);
			LeaveRule("ASSIGN", 36);
			Leave_ASSIGN();
		}
	}
	// $ANTLR end "ASSIGN"

	partial void Enter_RETURN();
	partial void Leave_RETURN();

	// $ANTLR start "RETURN"
	[GrammarRule("RETURN")]
	private void mRETURN()
	{
		Enter_RETURN();
		EnterRule("RETURN", 37);
		TraceIn("RETURN", 37);
		try
		{
			int _type = RETURN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:148:7: ( 'return' )
			DebugEnterAlt(1);
			// MathLang.g:148:9: 'return'
			{
			DebugLocation(148, 9);
			Match("return"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RETURN", 37);
			LeaveRule("RETURN", 37);
			Leave_RETURN();
		}
	}
	// $ANTLR end "RETURN"

	partial void Enter_RETURNS();
	partial void Leave_RETURNS();

	// $ANTLR start "RETURNS"
	[GrammarRule("RETURNS")]
	private void mRETURNS()
	{
		Enter_RETURNS();
		EnterRule("RETURNS", 38);
		TraceIn("RETURNS", 38);
		try
		{
			int _type = RETURNS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:149:8: ( 'returns' )
			DebugEnterAlt(1);
			// MathLang.g:149:9: 'returns'
			{
			DebugLocation(149, 9);
			Match("returns"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RETURNS", 38);
			LeaveRule("RETURNS", 38);
			Leave_RETURNS();
		}
	}
	// $ANTLR end "RETURNS"

	partial void Enter_TRUE();
	partial void Leave_TRUE();

	// $ANTLR start "TRUE"
	[GrammarRule("TRUE")]
	private void mTRUE()
	{
		Enter_TRUE();
		EnterRule("TRUE", 39);
		TraceIn("TRUE", 39);
		try
		{
			int _type = TRUE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:150:5: ( 'true' )
			DebugEnterAlt(1);
			// MathLang.g:150:7: 'true'
			{
			DebugLocation(150, 7);
			Match("true"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TRUE", 39);
			LeaveRule("TRUE", 39);
			Leave_TRUE();
		}
	}
	// $ANTLR end "TRUE"

	partial void Enter_FALSE();
	partial void Leave_FALSE();

	// $ANTLR start "FALSE"
	[GrammarRule("FALSE")]
	private void mFALSE()
	{
		Enter_FALSE();
		EnterRule("FALSE", 40);
		TraceIn("FALSE", 40);
		try
		{
			int _type = FALSE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:151:6: ( 'false' )
			DebugEnterAlt(1);
			// MathLang.g:151:8: 'false'
			{
			DebugLocation(151, 8);
			Match("false"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FALSE", 40);
			LeaveRule("FALSE", 40);
			Leave_FALSE();
		}
	}
	// $ANTLR end "FALSE"

	partial void Enter_EQ();
	partial void Leave_EQ();

	// $ANTLR start "EQ"
	[GrammarRule("EQ")]
	private void mEQ()
	{
		Enter_EQ();
		EnterRule("EQ", 41);
		TraceIn("EQ", 41);
		try
		{
			int _type = EQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:152:3: ( '==' )
			DebugEnterAlt(1);
			// MathLang.g:152:6: '=='
			{
			DebugLocation(152, 6);
			Match("=="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EQ", 41);
			LeaveRule("EQ", 41);
			Leave_EQ();
		}
	}
	// $ANTLR end "EQ"

	partial void Enter_NEQ();
	partial void Leave_NEQ();

	// $ANTLR start "NEQ"
	[GrammarRule("NEQ")]
	private void mNEQ()
	{
		Enter_NEQ();
		EnterRule("NEQ", 42);
		TraceIn("NEQ", 42);
		try
		{
			int _type = NEQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:153:4: ( '!=' )
			DebugEnterAlt(1);
			// MathLang.g:153:6: '!='
			{
			DebugLocation(153, 6);
			Match("!="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NEQ", 42);
			LeaveRule("NEQ", 42);
			Leave_NEQ();
		}
	}
	// $ANTLR end "NEQ"

	partial void Enter_GR();
	partial void Leave_GR();

	// $ANTLR start "GR"
	[GrammarRule("GR")]
	private void mGR()
	{
		Enter_GR();
		EnterRule("GR", 43);
		TraceIn("GR", 43);
		try
		{
			int _type = GR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:154:3: ( '>' )
			DebugEnterAlt(1);
			// MathLang.g:154:6: '>'
			{
			DebugLocation(154, 6);
			Match('>'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GR", 43);
			LeaveRule("GR", 43);
			Leave_GR();
		}
	}
	// $ANTLR end "GR"

	partial void Enter_GREQ();
	partial void Leave_GREQ();

	// $ANTLR start "GREQ"
	[GrammarRule("GREQ")]
	private void mGREQ()
	{
		Enter_GREQ();
		EnterRule("GREQ", 44);
		TraceIn("GREQ", 44);
		try
		{
			int _type = GREQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:155:5: ( '>=' )
			DebugEnterAlt(1);
			// MathLang.g:155:9: '>='
			{
			DebugLocation(155, 9);
			Match(">="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GREQ", 44);
			LeaveRule("GREQ", 44);
			Leave_GREQ();
		}
	}
	// $ANTLR end "GREQ"

	partial void Enter_LS();
	partial void Leave_LS();

	// $ANTLR start "LS"
	[GrammarRule("LS")]
	private void mLS()
	{
		Enter_LS();
		EnterRule("LS", 45);
		TraceIn("LS", 45);
		try
		{
			int _type = LS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:156:3: ( '<' )
			DebugEnterAlt(1);
			// MathLang.g:156:6: '<'
			{
			DebugLocation(156, 6);
			Match('<'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LS", 45);
			LeaveRule("LS", 45);
			Leave_LS();
		}
	}
	// $ANTLR end "LS"

	partial void Enter_LSEQ();
	partial void Leave_LSEQ();

	// $ANTLR start "LSEQ"
	[GrammarRule("LSEQ")]
	private void mLSEQ()
	{
		Enter_LSEQ();
		EnterRule("LSEQ", 46);
		TraceIn("LSEQ", 46);
		try
		{
			int _type = LSEQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:157:5: ( '<=' )
			DebugEnterAlt(1);
			// MathLang.g:157:7: '<='
			{
			DebugLocation(157, 7);
			Match("<="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LSEQ", 46);
			LeaveRule("LSEQ", 46);
			Leave_LSEQ();
		}
	}
	// $ANTLR end "LSEQ"

	partial void Enter_NOT();
	partial void Leave_NOT();

	// $ANTLR start "NOT"
	[GrammarRule("NOT")]
	private void mNOT()
	{
		Enter_NOT();
		EnterRule("NOT", 47);
		TraceIn("NOT", 47);
		try
		{
			int _type = NOT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:158:4: ( '!' )
			DebugEnterAlt(1);
			// MathLang.g:158:6: '!'
			{
			DebugLocation(158, 6);
			Match('!'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NOT", 47);
			LeaveRule("NOT", 47);
			Leave_NOT();
		}
	}
	// $ANTLR end "NOT"

	partial void Enter_PARAMETERS();
	partial void Leave_PARAMETERS();

	// $ANTLR start "PARAMETERS"
	[GrammarRule("PARAMETERS")]
	private void mPARAMETERS()
	{
		Enter_PARAMETERS();
		EnterRule("PARAMETERS", 48);
		TraceIn("PARAMETERS", 48);
		try
		{
			int _type = PARAMETERS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:159:11: ( 'parameters' )
			DebugEnterAlt(1);
			// MathLang.g:159:13: 'parameters'
			{
			DebugLocation(159, 13);
			Match("parameters"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PARAMETERS", 48);
			LeaveRule("PARAMETERS", 48);
			Leave_PARAMETERS();
		}
	}
	// $ANTLR end "PARAMETERS"

	partial void Enter_OR();
	partial void Leave_OR();

	// $ANTLR start "OR"
	[GrammarRule("OR")]
	private void mOR()
	{
		Enter_OR();
		EnterRule("OR", 49);
		TraceIn("OR", 49);
		try
		{
			int _type = OR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:160:3: ( '||' )
			DebugEnterAlt(1);
			// MathLang.g:160:6: '||'
			{
			DebugLocation(160, 6);
			Match("||"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OR", 49);
			LeaveRule("OR", 49);
			Leave_OR();
		}
	}
	// $ANTLR end "OR"

	partial void Enter_AND();
	partial void Leave_AND();

	// $ANTLR start "AND"
	[GrammarRule("AND")]
	private void mAND()
	{
		Enter_AND();
		EnterRule("AND", 50);
		TraceIn("AND", 50);
		try
		{
			int _type = AND;
			int _channel = DefaultTokenChannel;
			// MathLang.g:161:4: ( '&&' )
			DebugEnterAlt(1);
			// MathLang.g:161:6: '&&'
			{
			DebugLocation(161, 6);
			Match("&&"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("AND", 50);
			LeaveRule("AND", 50);
			Leave_AND();
		}
	}
	// $ANTLR end "AND"

	partial void Enter_WS();
	partial void Leave_WS();

	// $ANTLR start "WS"
	[GrammarRule("WS")]
	private void mWS()
	{
		Enter_WS();
		EnterRule("WS", 51);
		TraceIn("WS", 51);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:162:3: ( ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+ )
			DebugEnterAlt(1);
			// MathLang.g:163:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			{
			DebugLocation(163, 3);
			// MathLang.g:163:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			int cnt6=0;
			try { DebugEnterSubRule(6);
			while (true)
			{
				int alt6=2;
				try { DebugEnterDecision(6, decisionCanBacktrack[6]);
				int LA6_0 = input.LA(1);

				if (((LA6_0>='\t' && LA6_0<='\n')||(LA6_0>='\f' && LA6_0<='\r')||LA6_0==' '))
				{
					alt6=1;
				}


				} finally { DebugExitDecision(6); }
				switch (alt6)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:
					{
					DebugLocation(163, 3);
					if ((input.LA(1)>='\t' && input.LA(1)<='\n')||(input.LA(1)>='\f' && input.LA(1)<='\r')||input.LA(1)==' ')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				default:
					if (cnt6 >= 1)
						goto loop6;

					EarlyExitException eee6 = new EarlyExitException( 6, input );
					DebugRecognitionException(eee6);
					throw eee6;
				}
				cnt6++;
			}
			loop6:
				;

			} finally { DebugExitSubRule(6); }

			DebugLocation(163, 41);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 51);
			LeaveRule("WS", 51);
			Leave_WS();
		}
	}
	// $ANTLR end "WS"

	partial void Enter_CHAR();
	partial void Leave_CHAR();

	// $ANTLR start "CHAR"
	[GrammarRule("CHAR")]
	private void mCHAR()
	{
		Enter_CHAR();
		EnterRule("CHAR", 52);
		TraceIn("CHAR", 52);
		try
		{
			int _type = CHAR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:167:5: ( '\\'' ( 'a' .. 'z' ) '\\'' )
			DebugEnterAlt(1);
			// MathLang.g:167:8: '\\'' ( 'a' .. 'z' ) '\\''
			{
			DebugLocation(167, 8);
			Match('\''); 
			DebugLocation(167, 12);
			// MathLang.g:167:12: ( 'a' .. 'z' )
			DebugEnterAlt(1);
			// MathLang.g:167:13: 'a' .. 'z'
			{
			DebugLocation(167, 13);
			MatchRange('a','z'); 

			}

			DebugLocation(167, 22);
			Match('\''); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CHAR", 52);
			LeaveRule("CHAR", 52);
			Leave_CHAR();
		}
	}
	// $ANTLR end "CHAR"

	partial void Enter_ID();
	partial void Leave_ID();

	// $ANTLR start "ID"
	[GrammarRule("ID")]
	private void mID()
	{
		Enter_ID();
		EnterRule("ID", 53);
		TraceIn("ID", 53);
		try
		{
			int _type = ID;
			int _channel = DefaultTokenChannel;
			// MathLang.g:168:3: ( ( 'a' .. 'z' )+ )
			DebugEnterAlt(1);
			// MathLang.g:168:6: ( 'a' .. 'z' )+
			{
			DebugLocation(168, 6);
			// MathLang.g:168:6: ( 'a' .. 'z' )+
			int cnt7=0;
			try { DebugEnterSubRule(7);
			while (true)
			{
				int alt7=2;
				try { DebugEnterDecision(7, decisionCanBacktrack[7]);
				int LA7_0 = input.LA(1);

				if (((LA7_0>='a' && LA7_0<='z')))
				{
					alt7=1;
				}


				} finally { DebugExitDecision(7); }
				switch (alt7)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:168:7: 'a' .. 'z'
					{
					DebugLocation(168, 7);
					MatchRange('a','z'); 

					}
					break;

				default:
					if (cnt7 >= 1)
						goto loop7;

					EarlyExitException eee7 = new EarlyExitException( 7, input );
					DebugRecognitionException(eee7);
					throw eee7;
				}
				cnt7++;
			}
			loop7:
				;

			} finally { DebugExitSubRule(7); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ID", 53);
			LeaveRule("ID", 53);
			Leave_ID();
		}
	}
	// $ANTLR end "ID"

	partial void Enter_SL_COMMENT();
	partial void Leave_SL_COMMENT();

	// $ANTLR start "SL_COMMENT"
	[GrammarRule("SL_COMMENT")]
	private void mSL_COMMENT()
	{
		Enter_SL_COMMENT();
		EnterRule("SL_COMMENT", 54);
		TraceIn("SL_COMMENT", 54);
		try
		{
			int _type = SL_COMMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:172:11: ( '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n' )
			DebugEnterAlt(1);
			// MathLang.g:173:3: '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n'
			{
			DebugLocation(173, 3);
			Match("//"); 

			DebugLocation(173, 8);
			// MathLang.g:173:8: ( options {greedy=false; } : . )*
			try { DebugEnterSubRule(8);
			while (true)
			{
				int alt8=2;
				try { DebugEnterDecision(8, decisionCanBacktrack[8]);
				int LA8_0 = input.LA(1);

				if ((LA8_0=='\r'))
				{
					alt8=2;
				}
				else if ((LA8_0=='\n'))
				{
					alt8=2;
				}
				else if (((LA8_0>='\u0000' && LA8_0<='\t')||(LA8_0>='\u000B' && LA8_0<='\f')||(LA8_0>='\u000E' && LA8_0<='\uFFFF')))
				{
					alt8=1;
				}


				} finally { DebugExitDecision(8); }
				switch ( alt8 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:173:36: .
					{
					DebugLocation(173, 36);
					MatchAny(); 

					}
					break;

				default:
					goto loop8;
				}
			}

			loop8:
				;

			} finally { DebugExitSubRule(8); }

			DebugLocation(173, 40);
			// MathLang.g:173:40: ( '\\r' )?
			int alt9=2;
			try { DebugEnterSubRule(9);
			try { DebugEnterDecision(9, decisionCanBacktrack[9]);
			int LA9_0 = input.LA(1);

			if ((LA9_0=='\r'))
			{
				alt9=1;
			}
			} finally { DebugExitDecision(9); }
			switch (alt9)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:173:40: '\\r'
				{
				DebugLocation(173, 40);
				Match('\r'); 

				}
				break;

			}
			} finally { DebugExitSubRule(9); }

			DebugLocation(173, 46);
			Match('\n'); 
			DebugLocation(173, 51);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SL_COMMENT", 54);
			LeaveRule("SL_COMMENT", 54);
			Leave_SL_COMMENT();
		}
	}
	// $ANTLR end "SL_COMMENT"

	partial void Enter_ML_COMMENT();
	partial void Leave_ML_COMMENT();

	// $ANTLR start "ML_COMMENT"
	[GrammarRule("ML_COMMENT")]
	private void mML_COMMENT()
	{
		Enter_ML_COMMENT();
		EnterRule("ML_COMMENT", 55);
		TraceIn("ML_COMMENT", 55);
		try
		{
			int _type = ML_COMMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:177:11: ( '/*' ( options {greedy=false; } : . )* '*/' )
			DebugEnterAlt(1);
			// MathLang.g:178:3: '/*' ( options {greedy=false; } : . )* '*/'
			{
			DebugLocation(178, 3);
			Match("/*"); 

			DebugLocation(178, 8);
			// MathLang.g:178:8: ( options {greedy=false; } : . )*
			try { DebugEnterSubRule(10);
			while (true)
			{
				int alt10=2;
				try { DebugEnterDecision(10, decisionCanBacktrack[10]);
				int LA10_0 = input.LA(1);

				if ((LA10_0=='*'))
				{
					int LA10_1 = input.LA(2);

					if ((LA10_1=='/'))
					{
						alt10=2;
					}
					else if (((LA10_1>='\u0000' && LA10_1<='.')||(LA10_1>='0' && LA10_1<='\uFFFF')))
					{
						alt10=1;
					}


				}
				else if (((LA10_0>='\u0000' && LA10_0<=')')||(LA10_0>='+' && LA10_0<='\uFFFF')))
				{
					alt10=1;
				}


				} finally { DebugExitDecision(10); }
				switch ( alt10 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:178:36: .
					{
					DebugLocation(178, 36);
					MatchAny(); 

					}
					break;

				default:
					goto loop10;
				}
			}

			loop10:
				;

			} finally { DebugExitSubRule(10); }

			DebugLocation(178, 40);
			Match("*/"); 

			DebugLocation(178, 45);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ML_COMMENT", 55);
			LeaveRule("ML_COMMENT", 55);
			Leave_ML_COMMENT();
		}
	}
	// $ANTLR end "ML_COMMENT"

	public override void mTokens()
	{
		// MathLang.g:1:8: ( PRINT | INPUT | IF | ELSE | FOR | FUNCTION | WHILE | VARDECLARATION | FUNCDECLARATION | ARRAYDECLARATION | VARASSIGNMENT | ARRAYELEMENTASSIGNMENT | ARRAYELEMENT | NEWWORD | NEWVAR | ARRAY_INITIALIZER | OBJECT_INITIALIZER | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | KNEW | ARRAY_DECLARATION_MARK | SQRBL | SQRBR | TYPE | VOID | ACCESS_MODIFIER | NUMBER | ADD | SUB | MUL | DIV | ASSIGN | RETURN | RETURNS | TRUE | FALSE | EQ | NEQ | GR | GREQ | LS | LSEQ | NOT | PARAMETERS | OR | AND | WS | CHAR | ID | SL_COMMENT | ML_COMMENT )
		int alt11=55;
		try { DebugEnterDecision(11, decisionCanBacktrack[11]);
		try
		{
			alt11 = dfa11.Predict(input);
		}
		catch (NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
			throw;
		}
		} finally { DebugExitDecision(11); }
		switch (alt11)
		{
		case 1:
			DebugEnterAlt(1);
			// MathLang.g:1:10: PRINT
			{
			DebugLocation(1, 10);
			mPRINT(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// MathLang.g:1:16: INPUT
			{
			DebugLocation(1, 16);
			mINPUT(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// MathLang.g:1:22: IF
			{
			DebugLocation(1, 22);
			mIF(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// MathLang.g:1:25: ELSE
			{
			DebugLocation(1, 25);
			mELSE(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// MathLang.g:1:30: FOR
			{
			DebugLocation(1, 30);
			mFOR(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// MathLang.g:1:34: FUNCTION
			{
			DebugLocation(1, 34);
			mFUNCTION(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// MathLang.g:1:43: WHILE
			{
			DebugLocation(1, 43);
			mWHILE(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// MathLang.g:1:49: VARDECLARATION
			{
			DebugLocation(1, 49);
			mVARDECLARATION(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// MathLang.g:1:64: FUNCDECLARATION
			{
			DebugLocation(1, 64);
			mFUNCDECLARATION(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// MathLang.g:1:80: ARRAYDECLARATION
			{
			DebugLocation(1, 80);
			mARRAYDECLARATION(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// MathLang.g:1:97: VARASSIGNMENT
			{
			DebugLocation(1, 97);
			mVARASSIGNMENT(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// MathLang.g:1:111: ARRAYELEMENTASSIGNMENT
			{
			DebugLocation(1, 111);
			mARRAYELEMENTASSIGNMENT(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// MathLang.g:1:134: ARRAYELEMENT
			{
			DebugLocation(1, 134);
			mARRAYELEMENT(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// MathLang.g:1:147: NEWWORD
			{
			DebugLocation(1, 147);
			mNEWWORD(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// MathLang.g:1:155: NEWVAR
			{
			DebugLocation(1, 155);
			mNEWVAR(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// MathLang.g:1:162: ARRAY_INITIALIZER
			{
			DebugLocation(1, 162);
			mARRAY_INITIALIZER(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// MathLang.g:1:180: OBJECT_INITIALIZER
			{
			DebugLocation(1, 180);
			mOBJECT_INITIALIZER(); 

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// MathLang.g:1:199: T__57
			{
			DebugLocation(1, 199);
			mT__57(); 

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// MathLang.g:1:205: T__58
			{
			DebugLocation(1, 205);
			mT__58(); 

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// MathLang.g:1:211: T__59
			{
			DebugLocation(1, 211);
			mT__59(); 

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// MathLang.g:1:217: T__60
			{
			DebugLocation(1, 217);
			mT__60(); 

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// MathLang.g:1:223: T__61
			{
			DebugLocation(1, 223);
			mT__61(); 

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// MathLang.g:1:229: T__62
			{
			DebugLocation(1, 229);
			mT__62(); 

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// MathLang.g:1:235: KNEW
			{
			DebugLocation(1, 235);
			mKNEW(); 

			}
			break;
		case 25:
			DebugEnterAlt(25);
			// MathLang.g:1:240: ARRAY_DECLARATION_MARK
			{
			DebugLocation(1, 240);
			mARRAY_DECLARATION_MARK(); 

			}
			break;
		case 26:
			DebugEnterAlt(26);
			// MathLang.g:1:263: SQRBL
			{
			DebugLocation(1, 263);
			mSQRBL(); 

			}
			break;
		case 27:
			DebugEnterAlt(27);
			// MathLang.g:1:269: SQRBR
			{
			DebugLocation(1, 269);
			mSQRBR(); 

			}
			break;
		case 28:
			DebugEnterAlt(28);
			// MathLang.g:1:275: TYPE
			{
			DebugLocation(1, 275);
			mTYPE(); 

			}
			break;
		case 29:
			DebugEnterAlt(29);
			// MathLang.g:1:280: VOID
			{
			DebugLocation(1, 280);
			mVOID(); 

			}
			break;
		case 30:
			DebugEnterAlt(30);
			// MathLang.g:1:285: ACCESS_MODIFIER
			{
			DebugLocation(1, 285);
			mACCESS_MODIFIER(); 

			}
			break;
		case 31:
			DebugEnterAlt(31);
			// MathLang.g:1:301: NUMBER
			{
			DebugLocation(1, 301);
			mNUMBER(); 

			}
			break;
		case 32:
			DebugEnterAlt(32);
			// MathLang.g:1:308: ADD
			{
			DebugLocation(1, 308);
			mADD(); 

			}
			break;
		case 33:
			DebugEnterAlt(33);
			// MathLang.g:1:312: SUB
			{
			DebugLocation(1, 312);
			mSUB(); 

			}
			break;
		case 34:
			DebugEnterAlt(34);
			// MathLang.g:1:316: MUL
			{
			DebugLocation(1, 316);
			mMUL(); 

			}
			break;
		case 35:
			DebugEnterAlt(35);
			// MathLang.g:1:320: DIV
			{
			DebugLocation(1, 320);
			mDIV(); 

			}
			break;
		case 36:
			DebugEnterAlt(36);
			// MathLang.g:1:324: ASSIGN
			{
			DebugLocation(1, 324);
			mASSIGN(); 

			}
			break;
		case 37:
			DebugEnterAlt(37);
			// MathLang.g:1:331: RETURN
			{
			DebugLocation(1, 331);
			mRETURN(); 

			}
			break;
		case 38:
			DebugEnterAlt(38);
			// MathLang.g:1:338: RETURNS
			{
			DebugLocation(1, 338);
			mRETURNS(); 

			}
			break;
		case 39:
			DebugEnterAlt(39);
			// MathLang.g:1:346: TRUE
			{
			DebugLocation(1, 346);
			mTRUE(); 

			}
			break;
		case 40:
			DebugEnterAlt(40);
			// MathLang.g:1:351: FALSE
			{
			DebugLocation(1, 351);
			mFALSE(); 

			}
			break;
		case 41:
			DebugEnterAlt(41);
			// MathLang.g:1:357: EQ
			{
			DebugLocation(1, 357);
			mEQ(); 

			}
			break;
		case 42:
			DebugEnterAlt(42);
			// MathLang.g:1:360: NEQ
			{
			DebugLocation(1, 360);
			mNEQ(); 

			}
			break;
		case 43:
			DebugEnterAlt(43);
			// MathLang.g:1:364: GR
			{
			DebugLocation(1, 364);
			mGR(); 

			}
			break;
		case 44:
			DebugEnterAlt(44);
			// MathLang.g:1:367: GREQ
			{
			DebugLocation(1, 367);
			mGREQ(); 

			}
			break;
		case 45:
			DebugEnterAlt(45);
			// MathLang.g:1:372: LS
			{
			DebugLocation(1, 372);
			mLS(); 

			}
			break;
		case 46:
			DebugEnterAlt(46);
			// MathLang.g:1:375: LSEQ
			{
			DebugLocation(1, 375);
			mLSEQ(); 

			}
			break;
		case 47:
			DebugEnterAlt(47);
			// MathLang.g:1:380: NOT
			{
			DebugLocation(1, 380);
			mNOT(); 

			}
			break;
		case 48:
			DebugEnterAlt(48);
			// MathLang.g:1:384: PARAMETERS
			{
			DebugLocation(1, 384);
			mPARAMETERS(); 

			}
			break;
		case 49:
			DebugEnterAlt(49);
			// MathLang.g:1:395: OR
			{
			DebugLocation(1, 395);
			mOR(); 

			}
			break;
		case 50:
			DebugEnterAlt(50);
			// MathLang.g:1:398: AND
			{
			DebugLocation(1, 398);
			mAND(); 

			}
			break;
		case 51:
			DebugEnterAlt(51);
			// MathLang.g:1:402: WS
			{
			DebugLocation(1, 402);
			mWS(); 

			}
			break;
		case 52:
			DebugEnterAlt(52);
			// MathLang.g:1:405: CHAR
			{
			DebugLocation(1, 405);
			mCHAR(); 

			}
			break;
		case 53:
			DebugEnterAlt(53);
			// MathLang.g:1:410: ID
			{
			DebugLocation(1, 410);
			mID(); 

			}
			break;
		case 54:
			DebugEnterAlt(54);
			// MathLang.g:1:413: SL_COMMENT
			{
			DebugLocation(1, 413);
			mSL_COMMENT(); 

			}
			break;
		case 55:
			DebugEnterAlt(55);
			// MathLang.g:1:424: ML_COMMENT
			{
			DebugLocation(1, 424);
			mML_COMMENT(); 

			}
			break;

		}

	}


	#region DFA
	DFA11 dfa11;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa11 = new DFA11(this);
	}

	private class DFA11 : DFA
	{
		private const string DFA11_eotS =
			"\x1\xFFFF\x9\x23\x6\xFFFF\x1\x33\x1\xFFFF\x2\x23\x4\xFFFF\x1\x39\x1"+
			"\x3B\x2\x23\x1\x3F\x1\x41\x1\x43\x5\xFFFF\x4\x23\x1\x49\xA\x23\x2\xFFFF"+
			"\x2\x23\x5\xFFFF\x2\x23\x6\xFFFF\x4\x23\x1\x5D\x1\xFFFF\x1\x23\x1\x5F"+
			"\x6\x23\x1\x69\xA\x23\x1\xFFFF\x1\x74\x1\xFFFF\x5\x23\x1\x7B\x3\x23\x1"+
			"\xFFFF\x1\x23\x2\x5D\x1\x23\x1\x81\x1\x82\x3\x23\x1\x86\x1\xFFFF\x2\x23"+
			"\x1\x89\x1\x8A\x2\x23\x1\xFFFF\x5\x23\x2\xFFFF\x1\x23\x1\x95\x1\x23\x1"+
			"\xFFFF\x2\x23\x2\xFFFF\x4\x23\x1\xFFFF\x1\x23\x1\x9E\x1\x23\x1\xA1\x1"+
			"\x95\x1\xFFFF\x7\x23\x1\xA9\x2\xFFFF\x1\xAA\x1\xFFFF\x1\x23\x1\xAC\x5"+
			"\x23\x2\xFFFF\x1\x23\x1\xFFFF\x5\x23\x1\xB8\x5\x23\x1\xFFFF\x9\x23\x1"+
			"\xC8\x2\x23\x1\xCB\x2\x23\x1\xFFFF\x1\x23\x1\xCF\x1\xFFFF\x2\x23\x1\xD2"+
			"\x1\xFFFF\x2\x23\x1\xFFFF\x1\xD5\x1\x23\x1\xFFFF\x5\x23\x1\xDC\x1\xFFFF";
		private const string DFA11_eofS =
			"\xDD\xFFFF";
		private const string DFA11_minS =
			"\x1\x9\x1\x61\x1\x66\x1\x6C\x1\x61\x1\x68\x1\x61\x1\x72\x1\x65\x1\x62"+
			"\x6\xFFFF\x1\x2C\x1\xFFFF\x1\x6F\x1\x68\x4\xFFFF\x1\x2A\x1\x3D\x1\x65"+
			"\x1\x72\x3\x3D\x5\xFFFF\x1\x69\x1\x62\x1\x72\x1\x70\x1\x61\x1\x73\x1"+
			"\x72\x1\x6E\x1\x6C\x1\x69\x1\x72\x1\x69\x1\x72\x1\x77\x1\x6A\x2\xFFFF"+
			"\x1\x6F\x1\x61\x5\xFFFF\x1\x74\x1\x75\x6\xFFFF\x1\x6E\x1\x6C\x1\x61\x1"+
			"\x75\x1\x61\x1\xFFFF\x1\x65\x1\x61\x1\x63\x1\x73\x1\x6C\x1\x61\x1\x64"+
			"\x2\x61\x1\x65\x1\x6C\x1\x72\x1\x75\x1\x65\x1\x74\x1\x61\x1\x69\x1\x6D"+
			"\x1\x74\x1\xFFFF\x1\x61\x1\xFFFF\x1\x64\x3\x65\x1\x73\x1\x61\x1\x79\x1"+
			"\x6F\x1\x61\x1\xFFFF\x1\x63\x2\x61\x1\x72\x2\x61\x1\x74\x1\x63\x1\x65"+
			"\x1\x61\x1\xFFFF\x1\x69\x1\x65\x2\x61\x1\x63\x1\x73\x1\xFFFF\x1\x5F\x2"+
			"\x72\x1\x74\x1\x6E\x2\xFFFF\x1\x65\x1\x61\x1\x74\x1\xFFFF\x1\x6F\x1\x63"+
			"\x2\xFFFF\x1\x6C\x1\x69\x1\x65\x1\x6C\x1\xFFFF\x1\x64\x1\x61\x1\x5F\x2"+
			"\x61\x1\xFFFF\x1\x65\x1\x6E\x1\x6C\x1\x61\x1\x67\x1\x63\x1\x65\x1\x61"+
			"\x2\xFFFF\x1\x61\x1\xFFFF\x1\x72\x2\x61\x1\x72\x1\x6E\x1\x6C\x1\x6D\x2"+
			"\xFFFF\x1\x73\x1\xFFFF\x1\x72\x1\x61\x1\x6D\x1\x61\x1\x65\x2\x61\x1\x74"+
			"\x1\x65\x1\x72\x1\x6E\x1\xFFFF\x1\x74\x1\x69\x1\x6E\x1\x61\x1\x74\x1"+
			"\x69\x1\x6F\x2\x74\x1\x61\x1\x6F\x1\x6E\x1\x61\x1\x69\x1\x73\x1\xFFFF"+
			"\x1\x6E\x1\x61\x1\xFFFF\x1\x6F\x1\x73\x1\x61\x1\xFFFF\x1\x6E\x1\x69\x1"+
			"\xFFFF\x1\x61\x1\x67\x1\xFFFF\x1\x6E\x1\x6D\x1\x65\x1\x6E\x1\x74\x1\x61"+
			"\x1\xFFFF";
		private const string DFA11_maxS =
			"\x1\x7D\x1\x75\x1\x6E\x1\x6C\x1\x75\x1\x68\x1\x6F\x1\x72\x1\x65\x1\x62"+
			"\x6\xFFFF\x1\x5D\x1\xFFFF\x1\x6F\x1\x68\x4\xFFFF\x1\x2F\x1\x3D\x1\x65"+
			"\x1\x72\x3\x3D\x5\xFFFF\x1\x69\x1\x62\x1\x72\x1\x74\x1\x7A\x1\x73\x1"+
			"\x72\x1\x6E\x1\x6C\x1\x69\x1\x72\x1\x69\x1\x72\x1\x77\x1\x6A\x2\xFFFF"+
			"\x1\x6F\x1\x61\x5\xFFFF\x1\x74\x1\x75\x6\xFFFF\x1\x76\x1\x6C\x1\x61\x1"+
			"\x75\x1\x7A\x1\xFFFF\x1\x65\x1\x7A\x1\x63\x1\x73\x1\x6C\x2\x64\x1\x61"+
			"\x1\x7A\x1\x65\x1\x6C\x1\x72\x1\x75\x1\x65\x1\x74\x1\x61\x1\x69\x1\x6D"+
			"\x1\x74\x1\xFFFF\x1\x7A\x1\xFFFF\x1\x74\x3\x65\x1\x73\x1\x7A\x1\x79\x1"+
			"\x6F\x1\x61\x1\xFFFF\x1\x63\x2\x7A\x1\x72\x2\x7A\x1\x74\x1\x63\x1\x65"+
			"\x1\x7A\x1\xFFFF\x1\x69\x1\x65\x2\x7A\x1\x63\x1\x73\x1\xFFFF\x1\x65\x2"+
			"\x72\x1\x74\x1\x6E\x2\xFFFF\x1\x65\x1\x7A\x1\x74\x1\xFFFF\x1\x6F\x1\x63"+
			"\x2\xFFFF\x1\x6C\x1\x69\x1\x65\x1\x6C\x1\xFFFF\x1\x64\x1\x7A\x1\x5F\x2"+
			"\x7A\x1\xFFFF\x1\x65\x1\x6E\x1\x6C\x1\x61\x1\x67\x1\x63\x1\x65\x1\x7A"+
			"\x2\xFFFF\x1\x7A\x1\xFFFF\x1\x72\x1\x7A\x1\x61\x1\x72\x1\x6E\x1\x6C\x1"+
			"\x6D\x2\xFFFF\x1\x73\x1\xFFFF\x1\x72\x1\x61\x1\x6D\x1\x61\x1\x65\x1\x7A"+
			"\x1\x61\x1\x74\x1\x65\x1\x72\x1\x6E\x1\xFFFF\x1\x74\x1\x69\x1\x6E\x1"+
			"\x61\x1\x74\x1\x69\x1\x6F\x2\x74\x1\x7A\x1\x6F\x1\x6E\x1\x7A\x1\x69\x1"+
			"\x73\x1\xFFFF\x1\x6E\x1\x7A\x1\xFFFF\x1\x6F\x1\x73\x1\x7A\x1\xFFFF\x1"+
			"\x6E\x1\x69\x1\xFFFF\x1\x7A\x1\x67\x1\xFFFF\x1\x6E\x1\x6D\x1\x65\x1\x6E"+
			"\x1\x74\x1\x7A\x1\xFFFF";
		private const string DFA11_acceptS =
			"\xA\xFFFF\x1\x12\x1\x13\x1\x14\x1\x15\x1\x16\x1\x17\x1\xFFFF\x1\x1B"+
			"\x2\xFFFF\x1\x1F\x1\x20\x1\x21\x1\x22\x7\xFFFF\x1\x31\x1\x32\x1\x33\x1"+
			"\x34\x1\x35\xF\xFFFF\x1\x1A\x1\x19\x2\xFFFF\x1\x36\x1\x37\x1\x23\x1\x29"+
			"\x1\x24\x2\xFFFF\x1\x2A\x1\x2F\x1\x2C\x1\x2B\x1\x2E\x1\x2D\x5\xFFFF\x1"+
			"\x3\x13\xFFFF\x1\x1C\x1\xFFFF\x1\x5\x9\xFFFF\x1\x18\xA\xFFFF\x1\x4\x6"+
			"\xFFFF\x1\x1D\x5\xFFFF\x1\x27\x1\x1\x3\xFFFF\x1\x2\x2\xFFFF\x1\x28\x1"+
			"\x7\x4\xFFFF\x1\x10\x5\xFFFF\x1\x1E\x8\xFFFF\x1\xF\x1\x11\x1\xFFFF\x1"+
			"\x25\x7\xFFFF\x1\xE\x1\x26\x1\xFFFF\x1\x6\xB\xFFFF\x1\x30\xF\xFFFF\x1"+
			"\xD\x2\xFFFF\x1\xB\x3\xFFFF\x1\x8\x2\xFFFF\x1\x9\x2\xFFFF\x1\xA\x6\xFFFF"+
			"\x1\xC";
		private const string DFA11_specialS =
			"\xDD\xFFFF}>";
		private static readonly string[] DFA11_transitionS =
			{
				"\x2\x21\x1\xFFFF\x2\x21\x12\xFFFF\x1\x21\x1\x1C\x4\xFFFF\x1\x20\x1"+
				"\x22\x1\xB\x1\xC\x1\x17\x1\x15\x1\xD\x1\x16\x1\xFFFF\x1\x18\xA\x14\x1"+
				"\xFFFF\x1\xA\x1\x1E\x1\x19\x1\x1D\x1C\xFFFF\x1\x10\x1\xFFFF\x1\x11\x3"+
				"\xFFFF\x1\x7\x1\x12\x1\x13\x1\x23\x1\x3\x1\x4\x2\x23\x1\x2\x4\x23\x1"+
				"\x8\x1\x9\x1\x1\x1\x23\x1\x1A\x1\x23\x1\x1B\x1\x23\x1\x6\x1\x5\x3\x23"+
				"\x1\xE\x1\x1F\x1\xF",
				"\x1\x26\x10\xFFFF\x1\x24\x2\xFFFF\x1\x25",
				"\x1\x28\x7\xFFFF\x1\x27",
				"\x1\x29",
				"\x1\x2C\xD\xFFFF\x1\x2A\x5\xFFFF\x1\x2B",
				"\x1\x2D",
				"\x1\x2E\xD\xFFFF\x1\x2F",
				"\x1\x30",
				"\x1\x31",
				"\x1\x32",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x34\x30\xFFFF\x1\x34",
				"",
				"\x1\x35",
				"\x1\x36",
				"",
				"",
				"",
				"",
				"\x1\x38\x4\xFFFF\x1\x37",
				"\x1\x3A",
				"\x1\x3C",
				"\x1\x3D",
				"\x1\x3E",
				"\x1\x40",
				"\x1\x42",
				"",
				"",
				"",
				"",
				"",
				"\x1\x44",
				"\x1\x45",
				"\x1\x46",
				"\x1\x47\x3\xFFFF\x1\x48",
				"\x1A\x23",
				"\x1\x4A",
				"\x1\x4B",
				"\x1\x4C",
				"\x1\x4D",
				"\x1\x4E",
				"\x1\x4F",
				"\x1\x50",
				"\x1\x51",
				"\x1\x52",
				"\x1\x53",
				"",
				"",
				"\x1\x54",
				"\x1\x55",
				"",
				"",
				"",
				"",
				"",
				"\x1\x56",
				"\x1\x57",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x58\x7\xFFFF\x1\x59",
				"\x1\x5A",
				"\x1\x5B",
				"\x1\x5C",
				"\x1A\x23",
				"",
				"\x1\x5E",
				"\x1A\x23",
				"\x1\x60",
				"\x1\x61",
				"\x1\x62",
				"\x1\x64\x2\xFFFF\x1\x63",
				"\x1\x65",
				"\x1\x66",
				"\x15\x23\x1\x68\x1\x67\x3\x23",
				"\x1\x6A",
				"\x1\x6B",
				"\x1\x6C",
				"\x1\x6D",
				"\x1\x6E",
				"\x1\x6F",
				"\x1\x70",
				"\x1\x71",
				"\x1\x72",
				"\x1\x73",
				"",
				"\x1A\x23",
				"",
				"\x1\x76\xF\xFFFF\x1\x75",
				"\x1\x77",
				"\x1\x78",
				"\x1\x79",
				"\x1\x7A",
				"\x1A\x23",
				"\x1\x7C",
				"\x1\x7D",
				"\x1\x7E",
				"",
				"\x1\x7F",
				"\x1A\x23",
				"\x1A\x23",
				"\x1\x80",
				"\x1A\x23",
				"\x1A\x23",
				"\x1\x83",
				"\x1\x84",
				"\x1\x85",
				"\x1A\x23",
				"",
				"\x1\x87",
				"\x1\x88",
				"\x1A\x23",
				"\x1A\x23",
				"\x1\x8B",
				"\x1\x8C",
				"",
				"\x1\x8F\x4\xFFFF\x1\x8D\x1\x8E",
				"\x1\x90",
				"\x1\x91",
				"\x1\x92",
				"\x1\x93",
				"",
				"",
				"\x1\x94",
				"\x1A\x23",
				"\x1\x96",
				"",
				"\x1\x97",
				"\x1\x98",
				"",
				"",
				"\x1\x99",
				"\x1\x9A",
				"\x1\x9B",
				"\x1\x9C",
				"",
				"\x1\x9D",
				"\x1A\x23",
				"\x1\x9F",
				"\x12\x23\x1\xA0\x7\x23",
				"\x1A\x23",
				"",
				"\x1\xA2",
				"\x1\xA3",
				"\x1\xA4",
				"\x1\xA5",
				"\x1\xA6",
				"\x1\xA7",
				"\x1\xA8",
				"\x1A\x23",
				"",
				"",
				"\x1A\x23",
				"",
				"\x1\xAB",
				"\x1A\x23",
				"\x1\xAD",
				"\x1\xAE",
				"\x1\xAF",
				"\x1\xB0",
				"\x1\xB1",
				"",
				"",
				"\x1\xB2",
				"",
				"\x1\xB3",
				"\x1\xB4",
				"\x1\xB5",
				"\x1\xB6",
				"\x1\xB7",
				"\x1A\x23",
				"\x1\xB9",
				"\x1\xBA",
				"\x1\xBB",
				"\x1\xBC",
				"\x1\xBD",
				"",
				"\x1\xBE",
				"\x1\xBF",
				"\x1\xC0",
				"\x1\xC1",
				"\x1\xC2",
				"\x1\xC3",
				"\x1\xC4",
				"\x1\xC5",
				"\x1\xC6",
				"\x1\xC7\x19\x23",
				"\x1\xC9",
				"\x1\xCA",
				"\x1A\x23",
				"\x1\xCC",
				"\x1\xCD",
				"",
				"\x1\xCE",
				"\x1A\x23",
				"",
				"\x1\xD0",
				"\x1\xD1",
				"\x1A\x23",
				"",
				"\x1\xD3",
				"\x1\xD4",
				"",
				"\x1A\x23",
				"\x1\xD6",
				"",
				"\x1\xD7",
				"\x1\xD8",
				"\x1\xD9",
				"\x1\xDA",
				"\x1\xDB",
				"\x1A\x23",
				""
			};

		private static readonly short[] DFA11_eot = DFA.UnpackEncodedString(DFA11_eotS);
		private static readonly short[] DFA11_eof = DFA.UnpackEncodedString(DFA11_eofS);
		private static readonly char[] DFA11_min = DFA.UnpackEncodedStringToUnsignedChars(DFA11_minS);
		private static readonly char[] DFA11_max = DFA.UnpackEncodedStringToUnsignedChars(DFA11_maxS);
		private static readonly short[] DFA11_accept = DFA.UnpackEncodedString(DFA11_acceptS);
		private static readonly short[] DFA11_special = DFA.UnpackEncodedString(DFA11_specialS);
		private static readonly short[][] DFA11_transition;

		static DFA11()
		{
			int numStates = DFA11_transitionS.Length;
			DFA11_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA11_transition[i] = DFA.UnpackEncodedString(DFA11_transitionS[i]);
			}
		}

		public DFA11( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 11;
			this.eot = DFA11_eot;
			this.eof = DFA11_eof;
			this.min = DFA11_min;
			this.max = DFA11_max;
			this.accept = DFA11_accept;
			this.special = DFA11_special;
			this.transition = DFA11_transition;
		}

		public override string Description { get { return "1:1: Tokens : ( PRINT | INPUT | IF | ELSE | FOR | FUNCTION | WHILE | VARDECLARATION | FUNCDECLARATION | ARRAYDECLARATION | VARASSIGNMENT | ARRAYELEMENTASSIGNMENT | ARRAYELEMENT | NEWWORD | NEWVAR | ARRAY_INITIALIZER | OBJECT_INITIALIZER | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | KNEW | ARRAY_DECLARATION_MARK | SQRBL | SQRBR | TYPE | VOID | ACCESS_MODIFIER | NUMBER | ADD | SUB | MUL | DIV | ASSIGN | RETURN | RETURNS | TRUE | FALSE | EQ | NEQ | GR | GREQ | LS | LSEQ | NOT | PARAMETERS | OR | AND | WS | CHAR | ID | SL_COMMENT | ML_COMMENT );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}

} // namespace  MathLang 

// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-10-07 22:54:57

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
	public const int T__58=58;
	public const int T__59=59;
	public const int T__60=60;
	public const int T__61=61;
	public const int T__62=62;
	public const int T__63=63;
	public const int T__64=64;
	public const int T__65=65;
	public const int T__66=66;
	public const int T__67=67;
	public const int T__68=68;
	public const int T__69=69;
	public const int UNKNOWN=4;
	public const int PRINT=5;
	public const int INPUT=6;
	public const int IF=7;
	public const int ELSE=8;
	public const int FOR=9;
	public const int FUNCTION=10;
	public const int RETURN=11;
	public const int WHILE=12;
	public const int DO=13;
	public const int BLOCK=14;
	public const int PROGRAM=15;
	public const int PARAMS=16;
	public const int VARDECLARATION=17;
	public const int FUNCDECLARATION=18;
	public const int ARRAYDECLARATION=19;
	public const int VARASSIGNMENT=20;
	public const int ARRAYELEMENTASSIGNMENT=21;
	public const int ARRAYELEMENT=22;
	public const int NEWVAR=23;
	public const int ARRAY_INITIALIZER=24;
	public const int OBJECT_INITIALIZER=25;
	public const int FUNC_CALL=26;
	public const int RETURN_TYPE=27;
	public const int PARAMETERS=28;
	public const int TYPE=29;
	public const int ARRAY_DECLARATION_MARK=30;
	public const int VOID=31;
	public const int NUMBER=32;
	public const int ID=33;
	public const int CHAR=34;
	public const int ASSIGN=35;
	public const int ADD=36;
	public const int SUB=37;
	public const int MUL=38;
	public const int DIV=39;
	public const int GREQ=40;
	public const int LSEQ=41;
	public const int NEQ=42;
	public const int EQ=43;
	public const int GR=44;
	public const int LS=45;
	public const int OR=46;
	public const int AND=47;
	public const int NOT=48;
	public const int TRUE=49;
	public const int FALSE=50;
	public const int KNEW=51;
	public const int CONSOLE_WORD=52;
	public const int SQRBL=53;
	public const int SQRBR=54;
	public const int WS=55;
	public const int SL_COMMENT=56;
	public const int ML_COMMENT=57;

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

	partial void Enter_DO();
	partial void Leave_DO();

	// $ANTLR start "DO"
	[GrammarRule("DO")]
	private void mDO()
	{
		Enter_DO();
		EnterRule("DO", 8);
		TraceIn("DO", 8);
		try
		{
			int _type = DO;
			int _channel = DefaultTokenChannel;
			// MathLang.g:16:4: ( 'do' )
			DebugEnterAlt(1);
			// MathLang.g:16:6: 'do'
			{
			DebugLocation(16, 6);
			Match("do"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DO", 8);
			LeaveRule("DO", 8);
			Leave_DO();
		}
	}
	// $ANTLR end "DO"

	partial void Enter_VARDECLARATION();
	partial void Leave_VARDECLARATION();

	// $ANTLR start "VARDECLARATION"
	[GrammarRule("VARDECLARATION")]
	private void mVARDECLARATION()
	{
		Enter_VARDECLARATION();
		EnterRule("VARDECLARATION", 9);
		TraceIn("VARDECLARATION", 9);
		try
		{
			int _type = VARDECLARATION;
			int _channel = DefaultTokenChannel;
			// MathLang.g:17:16: ( 'vardeclaration' )
			DebugEnterAlt(1);
			// MathLang.g:17:18: 'vardeclaration'
			{
			DebugLocation(17, 18);
			Match("vardeclaration"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("VARDECLARATION", 9);
			LeaveRule("VARDECLARATION", 9);
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
		EnterRule("FUNCDECLARATION", 10);
		TraceIn("FUNCDECLARATION", 10);
		try
		{
			int _type = FUNCDECLARATION;
			int _channel = DefaultTokenChannel;
			// MathLang.g:18:17: ( 'funcdeclaration' )
			DebugEnterAlt(1);
			// MathLang.g:18:19: 'funcdeclaration'
			{
			DebugLocation(18, 19);
			Match("funcdeclaration"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FUNCDECLARATION", 10);
			LeaveRule("FUNCDECLARATION", 10);
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
		EnterRule("ARRAYDECLARATION", 11);
		TraceIn("ARRAYDECLARATION", 11);
		try
		{
			int _type = ARRAYDECLARATION;
			int _channel = DefaultTokenChannel;
			// MathLang.g:19:18: ( 'arraydeclaration' )
			DebugEnterAlt(1);
			// MathLang.g:19:20: 'arraydeclaration'
			{
			DebugLocation(19, 20);
			Match("arraydeclaration"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ARRAYDECLARATION", 11);
			LeaveRule("ARRAYDECLARATION", 11);
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
		EnterRule("VARASSIGNMENT", 12);
		TraceIn("VARASSIGNMENT", 12);
		try
		{
			int _type = VARASSIGNMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:20:15: ( 'varassignment' )
			DebugEnterAlt(1);
			// MathLang.g:20:17: 'varassignment'
			{
			DebugLocation(20, 17);
			Match("varassignment"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("VARASSIGNMENT", 12);
			LeaveRule("VARASSIGNMENT", 12);
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
		EnterRule("ARRAYELEMENTASSIGNMENT", 13);
		TraceIn("ARRAYELEMENTASSIGNMENT", 13);
		try
		{
			int _type = ARRAYELEMENTASSIGNMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:21:24: ( 'arrayelementassignment' )
			DebugEnterAlt(1);
			// MathLang.g:21:26: 'arrayelementassignment'
			{
			DebugLocation(21, 26);
			Match("arrayelementassignment"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ARRAYELEMENTASSIGNMENT", 13);
			LeaveRule("ARRAYELEMENTASSIGNMENT", 13);
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
		EnterRule("ARRAYELEMENT", 14);
		TraceIn("ARRAYELEMENT", 14);
		try
		{
			int _type = ARRAYELEMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:22:14: ( 'arrayelement' )
			DebugEnterAlt(1);
			// MathLang.g:22:16: 'arrayelement'
			{
			DebugLocation(22, 16);
			Match("arrayelement"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ARRAYELEMENT", 14);
			LeaveRule("ARRAYELEMENT", 14);
			Leave_ARRAYELEMENT();
		}
	}
	// $ANTLR end "ARRAYELEMENT"

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

	partial void Enter_FUNC_CALL();
	partial void Leave_FUNC_CALL();

	// $ANTLR start "FUNC_CALL"
	[GrammarRule("FUNC_CALL")]
	private void mFUNC_CALL()
	{
		Enter_FUNC_CALL();
		EnterRule("FUNC_CALL", 18);
		TraceIn("FUNC_CALL", 18);
		try
		{
			int _type = FUNC_CALL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:26:11: ( 'func_call' )
			DebugEnterAlt(1);
			// MathLang.g:26:13: 'func_call'
			{
			DebugLocation(26, 13);
			Match("func_call"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FUNC_CALL", 18);
			LeaveRule("FUNC_CALL", 18);
			Leave_FUNC_CALL();
		}
	}
	// $ANTLR end "FUNC_CALL"

	partial void Enter_RETURN_TYPE();
	partial void Leave_RETURN_TYPE();

	// $ANTLR start "RETURN_TYPE"
	[GrammarRule("RETURN_TYPE")]
	private void mRETURN_TYPE()
	{
		Enter_RETURN_TYPE();
		EnterRule("RETURN_TYPE", 19);
		TraceIn("RETURN_TYPE", 19);
		try
		{
			int _type = RETURN_TYPE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:27:13: ( 'return_type' )
			DebugEnterAlt(1);
			// MathLang.g:27:15: 'return_type'
			{
			DebugLocation(27, 15);
			Match("return_type"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RETURN_TYPE", 19);
			LeaveRule("RETURN_TYPE", 19);
			Leave_RETURN_TYPE();
		}
	}
	// $ANTLR end "RETURN_TYPE"

	partial void Enter_PARAMETERS();
	partial void Leave_PARAMETERS();

	// $ANTLR start "PARAMETERS"
	[GrammarRule("PARAMETERS")]
	private void mPARAMETERS()
	{
		Enter_PARAMETERS();
		EnterRule("PARAMETERS", 20);
		TraceIn("PARAMETERS", 20);
		try
		{
			int _type = PARAMETERS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:28:12: ( 'parameters' )
			DebugEnterAlt(1);
			// MathLang.g:28:14: 'parameters'
			{
			DebugLocation(28, 14);
			Match("parameters"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PARAMETERS", 20);
			LeaveRule("PARAMETERS", 20);
			Leave_PARAMETERS();
		}
	}
	// $ANTLR end "PARAMETERS"

	partial void Enter_T__58();
	partial void Leave_T__58();

	// $ANTLR start "T__58"
	[GrammarRule("T__58")]
	private void mT__58()
	{
		Enter_T__58();
		EnterRule("T__58", 21);
		TraceIn("T__58", 21);
		try
		{
			int _type = T__58;
			int _channel = DefaultTokenChannel;
			// MathLang.g:29:7: ( ';' )
			DebugEnterAlt(1);
			// MathLang.g:29:9: ';'
			{
			DebugLocation(29, 9);
			Match(';'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__58", 21);
			LeaveRule("T__58", 21);
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
		EnterRule("T__59", 22);
		TraceIn("T__59", 22);
		try
		{
			int _type = T__59;
			int _channel = DefaultTokenChannel;
			// MathLang.g:30:7: ( '(' )
			DebugEnterAlt(1);
			// MathLang.g:30:9: '('
			{
			DebugLocation(30, 9);
			Match('('); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__59", 22);
			LeaveRule("T__59", 22);
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
		EnterRule("T__60", 23);
		TraceIn("T__60", 23);
		try
		{
			int _type = T__60;
			int _channel = DefaultTokenChannel;
			// MathLang.g:31:7: ( ')' )
			DebugEnterAlt(1);
			// MathLang.g:31:9: ')'
			{
			DebugLocation(31, 9);
			Match(')'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__60", 23);
			LeaveRule("T__60", 23);
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
		EnterRule("T__61", 24);
		TraceIn("T__61", 24);
		try
		{
			int _type = T__61;
			int _channel = DefaultTokenChannel;
			// MathLang.g:32:7: ( '()' )
			DebugEnterAlt(1);
			// MathLang.g:32:9: '()'
			{
			DebugLocation(32, 9);
			Match("()"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__61", 24);
			LeaveRule("T__61", 24);
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
		EnterRule("T__62", 25);
		TraceIn("T__62", 25);
		try
		{
			int _type = T__62;
			int _channel = DefaultTokenChannel;
			// MathLang.g:33:7: ( ',' )
			DebugEnterAlt(1);
			// MathLang.g:33:9: ','
			{
			DebugLocation(33, 9);
			Match(','); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__62", 25);
			LeaveRule("T__62", 25);
			Leave_T__62();
		}
	}
	// $ANTLR end "T__62"

	partial void Enter_T__63();
	partial void Leave_T__63();

	// $ANTLR start "T__63"
	[GrammarRule("T__63")]
	private void mT__63()
	{
		Enter_T__63();
		EnterRule("T__63", 26);
		TraceIn("T__63", 26);
		try
		{
			int _type = T__63;
			int _channel = DefaultTokenChannel;
			// MathLang.g:34:7: ( '{' )
			DebugEnterAlt(1);
			// MathLang.g:34:9: '{'
			{
			DebugLocation(34, 9);
			Match('{'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__63", 26);
			LeaveRule("T__63", 26);
			Leave_T__63();
		}
	}
	// $ANTLR end "T__63"

	partial void Enter_T__64();
	partial void Leave_T__64();

	// $ANTLR start "T__64"
	[GrammarRule("T__64")]
	private void mT__64()
	{
		Enter_T__64();
		EnterRule("T__64", 27);
		TraceIn("T__64", 27);
		try
		{
			int _type = T__64;
			int _channel = DefaultTokenChannel;
			// MathLang.g:35:7: ( '}' )
			DebugEnterAlt(1);
			// MathLang.g:35:9: '}'
			{
			DebugLocation(35, 9);
			Match('}'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__64", 27);
			LeaveRule("T__64", 27);
			Leave_T__64();
		}
	}
	// $ANTLR end "T__64"

	partial void Enter_T__65();
	partial void Leave_T__65();

	// $ANTLR start "T__65"
	[GrammarRule("T__65")]
	private void mT__65()
	{
		Enter_T__65();
		EnterRule("T__65", 28);
		TraceIn("T__65", 28);
		try
		{
			int _type = T__65;
			int _channel = DefaultTokenChannel;
			// MathLang.g:36:7: ( '.' )
			DebugEnterAlt(1);
			// MathLang.g:36:9: '.'
			{
			DebugLocation(36, 9);
			Match('.'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__65", 28);
			LeaveRule("T__65", 28);
			Leave_T__65();
		}
	}
	// $ANTLR end "T__65"

	partial void Enter_T__66();
	partial void Leave_T__66();

	// $ANTLR start "T__66"
	[GrammarRule("T__66")]
	private void mT__66()
	{
		Enter_T__66();
		EnterRule("T__66", 29);
		TraceIn("T__66", 29);
		try
		{
			int _type = T__66;
			int _channel = DefaultTokenChannel;
			// MathLang.g:37:7: ( 'WriteLine' )
			DebugEnterAlt(1);
			// MathLang.g:37:9: 'WriteLine'
			{
			DebugLocation(37, 9);
			Match("WriteLine"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__66", 29);
			LeaveRule("T__66", 29);
			Leave_T__66();
		}
	}
	// $ANTLR end "T__66"

	partial void Enter_T__67();
	partial void Leave_T__67();

	// $ANTLR start "T__67"
	[GrammarRule("T__67")]
	private void mT__67()
	{
		Enter_T__67();
		EnterRule("T__67", 30);
		TraceIn("T__67", 30);
		try
		{
			int _type = T__67;
			int _channel = DefaultTokenChannel;
			// MathLang.g:38:7: ( 'Write' )
			DebugEnterAlt(1);
			// MathLang.g:38:9: 'Write'
			{
			DebugLocation(38, 9);
			Match("Write"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__67", 30);
			LeaveRule("T__67", 30);
			Leave_T__67();
		}
	}
	// $ANTLR end "T__67"

	partial void Enter_T__68();
	partial void Leave_T__68();

	// $ANTLR start "T__68"
	[GrammarRule("T__68")]
	private void mT__68()
	{
		Enter_T__68();
		EnterRule("T__68", 31);
		TraceIn("T__68", 31);
		try
		{
			int _type = T__68;
			int _channel = DefaultTokenChannel;
			// MathLang.g:39:7: ( 'ReadLine' )
			DebugEnterAlt(1);
			// MathLang.g:39:9: 'ReadLine'
			{
			DebugLocation(39, 9);
			Match("ReadLine"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__68", 31);
			LeaveRule("T__68", 31);
			Leave_T__68();
		}
	}
	// $ANTLR end "T__68"

	partial void Enter_T__69();
	partial void Leave_T__69();

	// $ANTLR start "T__69"
	[GrammarRule("T__69")]
	private void mT__69()
	{
		Enter_T__69();
		EnterRule("T__69", 32);
		TraceIn("T__69", 32);
		try
		{
			int _type = T__69;
			int _channel = DefaultTokenChannel;
			// MathLang.g:40:7: ( 'Read' )
			DebugEnterAlt(1);
			// MathLang.g:40:9: 'Read'
			{
			DebugLocation(40, 9);
			Match("Read"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__69", 32);
			LeaveRule("T__69", 32);
			Leave_T__69();
		}
	}
	// $ANTLR end "T__69"

	partial void Enter_KNEW();
	partial void Leave_KNEW();

	// $ANTLR start "KNEW"
	[GrammarRule("KNEW")]
	private void mKNEW()
	{
		Enter_KNEW();
		EnterRule("KNEW", 33);
		TraceIn("KNEW", 33);
		try
		{
			int _type = KNEW;
			int _channel = DefaultTokenChannel;
			// MathLang.g:148:5: ( 'new' )
			DebugEnterAlt(1);
			// MathLang.g:148:7: 'new'
			{
			DebugLocation(148, 7);
			Match("new"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("KNEW", 33);
			LeaveRule("KNEW", 33);
			Leave_KNEW();
		}
	}
	// $ANTLR end "KNEW"

	partial void Enter_CONSOLE_WORD();
	partial void Leave_CONSOLE_WORD();

	// $ANTLR start "CONSOLE_WORD"
	[GrammarRule("CONSOLE_WORD")]
	private void mCONSOLE_WORD()
	{
		Enter_CONSOLE_WORD();
		EnterRule("CONSOLE_WORD", 34);
		TraceIn("CONSOLE_WORD", 34);
		try
		{
			int _type = CONSOLE_WORD;
			int _channel = DefaultTokenChannel;
			// MathLang.g:149:13: ( 'Console' )
			DebugEnterAlt(1);
			// MathLang.g:149:15: 'Console'
			{
			DebugLocation(149, 15);
			Match("Console"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CONSOLE_WORD", 34);
			LeaveRule("CONSOLE_WORD", 34);
			Leave_CONSOLE_WORD();
		}
	}
	// $ANTLR end "CONSOLE_WORD"

	partial void Enter_ARRAY_DECLARATION_MARK();
	partial void Leave_ARRAY_DECLARATION_MARK();

	// $ANTLR start "ARRAY_DECLARATION_MARK"
	[GrammarRule("ARRAY_DECLARATION_MARK")]
	private void mARRAY_DECLARATION_MARK()
	{
		Enter_ARRAY_DECLARATION_MARK();
		EnterRule("ARRAY_DECLARATION_MARK", 35);
		TraceIn("ARRAY_DECLARATION_MARK", 35);
		try
		{
			int _type = ARRAY_DECLARATION_MARK;
			int _channel = DefaultTokenChannel;
			// MathLang.g:150:23: ( SQRBL SQRBR )
			DebugEnterAlt(1);
			// MathLang.g:150:25: SQRBL SQRBR
			{
			DebugLocation(150, 25);
			mSQRBL(); 
			DebugLocation(150, 31);
			mSQRBR(); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ARRAY_DECLARATION_MARK", 35);
			LeaveRule("ARRAY_DECLARATION_MARK", 35);
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
		EnterRule("SQRBL", 36);
		TraceIn("SQRBL", 36);
		try
		{
			int _type = SQRBL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:151:6: ( '[' )
			DebugEnterAlt(1);
			// MathLang.g:151:7: '['
			{
			DebugLocation(151, 7);
			Match('['); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SQRBL", 36);
			LeaveRule("SQRBL", 36);
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
		EnterRule("SQRBR", 37);
		TraceIn("SQRBR", 37);
		try
		{
			int _type = SQRBR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:152:6: ( ']' )
			DebugEnterAlt(1);
			// MathLang.g:152:7: ']'
			{
			DebugLocation(152, 7);
			Match(']'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SQRBR", 37);
			LeaveRule("SQRBR", 37);
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
		EnterRule("TYPE", 38);
		TraceIn("TYPE", 38);
		try
		{
			int _type = TYPE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:153:5: ( 'int' | 'bool' | 'char' )
			int alt1=3;
			try { DebugEnterDecision(1, decisionCanBacktrack[1]);
			switch (input.LA(1))
			{
			case 'i':
				{
				alt1=1;
				}
				break;
			case 'b':
				{
				alt1=2;
				}
				break;
			case 'c':
				{
				alt1=3;
				}
				break;
			default:
				{
					NoViableAltException nvae = new NoViableAltException("", 1, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(1); }
			switch (alt1)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:153:7: 'int'
				{
				DebugLocation(153, 7);
				Match("int"); 


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:153:15: 'bool'
				{
				DebugLocation(153, 15);
				Match("bool"); 


				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:153:24: 'char'
				{
				DebugLocation(153, 24);
				Match("char"); 


				}
				break;

			}
			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TYPE", 38);
			LeaveRule("TYPE", 38);
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
		EnterRule("VOID", 39);
		TraceIn("VOID", 39);
		try
		{
			int _type = VOID;
			int _channel = DefaultTokenChannel;
			// MathLang.g:154:5: ( 'void' )
			DebugEnterAlt(1);
			// MathLang.g:154:7: 'void'
			{
			DebugLocation(154, 7);
			Match("void"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("VOID", 39);
			LeaveRule("VOID", 39);
			Leave_VOID();
		}
	}
	// $ANTLR end "VOID"

	partial void Enter_NUMBER();
	partial void Leave_NUMBER();

	// $ANTLR start "NUMBER"
	[GrammarRule("NUMBER")]
	private void mNUMBER()
	{
		Enter_NUMBER();
		EnterRule("NUMBER", 40);
		TraceIn("NUMBER", 40);
		try
		{
			int _type = NUMBER;
			int _channel = DefaultTokenChannel;
			// MathLang.g:155:7: ( ( '0' .. '9' )+ )
			DebugEnterAlt(1);
			// MathLang.g:155:9: ( '0' .. '9' )+
			{
			DebugLocation(155, 9);
			// MathLang.g:155:9: ( '0' .. '9' )+
			int cnt2=0;
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
				int LA2_0 = input.LA(1);

				if (((LA2_0>='0' && LA2_0<='9')))
				{
					alt2=1;
				}


				} finally { DebugExitDecision(2); }
				switch (alt2)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:155:10: '0' .. '9'
					{
					DebugLocation(155, 10);
					MatchRange('0','9'); 

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
			TraceOut("NUMBER", 40);
			LeaveRule("NUMBER", 40);
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
		EnterRule("ADD", 41);
		TraceIn("ADD", 41);
		try
		{
			int _type = ADD;
			int _channel = DefaultTokenChannel;
			// MathLang.g:156:4: ( '+' )
			DebugEnterAlt(1);
			// MathLang.g:156:9: '+'
			{
			DebugLocation(156, 9);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ADD", 41);
			LeaveRule("ADD", 41);
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
		EnterRule("SUB", 42);
		TraceIn("SUB", 42);
		try
		{
			int _type = SUB;
			int _channel = DefaultTokenChannel;
			// MathLang.g:157:4: ( '-' )
			DebugEnterAlt(1);
			// MathLang.g:157:9: '-'
			{
			DebugLocation(157, 9);
			Match('-'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SUB", 42);
			LeaveRule("SUB", 42);
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
		EnterRule("MUL", 43);
		TraceIn("MUL", 43);
		try
		{
			int _type = MUL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:158:4: ( '*' )
			DebugEnterAlt(1);
			// MathLang.g:158:9: '*'
			{
			DebugLocation(158, 9);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MUL", 43);
			LeaveRule("MUL", 43);
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
		EnterRule("DIV", 44);
		TraceIn("DIV", 44);
		try
		{
			int _type = DIV;
			int _channel = DefaultTokenChannel;
			// MathLang.g:159:4: ( '/' )
			DebugEnterAlt(1);
			// MathLang.g:159:9: '/'
			{
			DebugLocation(159, 9);
			Match('/'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DIV", 44);
			LeaveRule("DIV", 44);
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
		EnterRule("ASSIGN", 45);
		TraceIn("ASSIGN", 45);
		try
		{
			int _type = ASSIGN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:160:7: ( '=' )
			DebugEnterAlt(1);
			// MathLang.g:160:9: '='
			{
			DebugLocation(160, 9);
			Match('='); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ASSIGN", 45);
			LeaveRule("ASSIGN", 45);
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
		EnterRule("RETURN", 46);
		TraceIn("RETURN", 46);
		try
		{
			int _type = RETURN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:161:7: ( 'return' )
			DebugEnterAlt(1);
			// MathLang.g:161:9: 'return'
			{
			DebugLocation(161, 9);
			Match("return"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RETURN", 46);
			LeaveRule("RETURN", 46);
			Leave_RETURN();
		}
	}
	// $ANTLR end "RETURN"

	partial void Enter_TRUE();
	partial void Leave_TRUE();

	// $ANTLR start "TRUE"
	[GrammarRule("TRUE")]
	private void mTRUE()
	{
		Enter_TRUE();
		EnterRule("TRUE", 47);
		TraceIn("TRUE", 47);
		try
		{
			int _type = TRUE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:162:5: ( 'true' )
			DebugEnterAlt(1);
			// MathLang.g:162:9: 'true'
			{
			DebugLocation(162, 9);
			Match("true"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TRUE", 47);
			LeaveRule("TRUE", 47);
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
		EnterRule("FALSE", 48);
		TraceIn("FALSE", 48);
		try
		{
			int _type = FALSE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:163:6: ( 'false' )
			DebugEnterAlt(1);
			// MathLang.g:163:9: 'false'
			{
			DebugLocation(163, 9);
			Match("false"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FALSE", 48);
			LeaveRule("FALSE", 48);
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
		EnterRule("EQ", 49);
		TraceIn("EQ", 49);
		try
		{
			int _type = EQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:164:3: ( '==' )
			DebugEnterAlt(1);
			// MathLang.g:164:6: '=='
			{
			DebugLocation(164, 6);
			Match("=="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EQ", 49);
			LeaveRule("EQ", 49);
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
		EnterRule("NEQ", 50);
		TraceIn("NEQ", 50);
		try
		{
			int _type = NEQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:165:4: ( '!=' )
			DebugEnterAlt(1);
			// MathLang.g:165:6: '!='
			{
			DebugLocation(165, 6);
			Match("!="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NEQ", 50);
			LeaveRule("NEQ", 50);
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
		EnterRule("GR", 51);
		TraceIn("GR", 51);
		try
		{
			int _type = GR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:166:3: ( '>' )
			DebugEnterAlt(1);
			// MathLang.g:166:6: '>'
			{
			DebugLocation(166, 6);
			Match('>'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GR", 51);
			LeaveRule("GR", 51);
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
		EnterRule("GREQ", 52);
		TraceIn("GREQ", 52);
		try
		{
			int _type = GREQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:167:5: ( '>=' )
			DebugEnterAlt(1);
			// MathLang.g:167:9: '>='
			{
			DebugLocation(167, 9);
			Match(">="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GREQ", 52);
			LeaveRule("GREQ", 52);
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
		EnterRule("LS", 53);
		TraceIn("LS", 53);
		try
		{
			int _type = LS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:168:3: ( '<' )
			DebugEnterAlt(1);
			// MathLang.g:168:6: '<'
			{
			DebugLocation(168, 6);
			Match('<'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LS", 53);
			LeaveRule("LS", 53);
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
		EnterRule("LSEQ", 54);
		TraceIn("LSEQ", 54);
		try
		{
			int _type = LSEQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:169:5: ( '<=' )
			DebugEnterAlt(1);
			// MathLang.g:169:7: '<='
			{
			DebugLocation(169, 7);
			Match("<="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LSEQ", 54);
			LeaveRule("LSEQ", 54);
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
		EnterRule("NOT", 55);
		TraceIn("NOT", 55);
		try
		{
			int _type = NOT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:170:4: ( '!' )
			DebugEnterAlt(1);
			// MathLang.g:170:6: '!'
			{
			DebugLocation(170, 6);
			Match('!'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NOT", 55);
			LeaveRule("NOT", 55);
			Leave_NOT();
		}
	}
	// $ANTLR end "NOT"

	partial void Enter_OR();
	partial void Leave_OR();

	// $ANTLR start "OR"
	[GrammarRule("OR")]
	private void mOR()
	{
		Enter_OR();
		EnterRule("OR", 56);
		TraceIn("OR", 56);
		try
		{
			int _type = OR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:171:3: ( '||' )
			DebugEnterAlt(1);
			// MathLang.g:171:6: '||'
			{
			DebugLocation(171, 6);
			Match("||"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OR", 56);
			LeaveRule("OR", 56);
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
		EnterRule("AND", 57);
		TraceIn("AND", 57);
		try
		{
			int _type = AND;
			int _channel = DefaultTokenChannel;
			// MathLang.g:172:4: ( '&&' )
			DebugEnterAlt(1);
			// MathLang.g:172:6: '&&'
			{
			DebugLocation(172, 6);
			Match("&&"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("AND", 57);
			LeaveRule("AND", 57);
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
		EnterRule("WS", 58);
		TraceIn("WS", 58);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:173:3: ( ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+ )
			DebugEnterAlt(1);
			// MathLang.g:174:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			{
			DebugLocation(174, 3);
			// MathLang.g:174:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			int cnt3=0;
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=2;
				try { DebugEnterDecision(3, decisionCanBacktrack[3]);
				int LA3_0 = input.LA(1);

				if (((LA3_0>='\t' && LA3_0<='\n')||(LA3_0>='\f' && LA3_0<='\r')||LA3_0==' '))
				{
					alt3=1;
				}


				} finally { DebugExitDecision(3); }
				switch (alt3)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:
					{
					DebugLocation(174, 3);
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
					if (cnt3 >= 1)
						goto loop3;

					EarlyExitException eee3 = new EarlyExitException( 3, input );
					DebugRecognitionException(eee3);
					throw eee3;
				}
				cnt3++;
			}
			loop3:
				;

			} finally { DebugExitSubRule(3); }

			DebugLocation(174, 41);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 58);
			LeaveRule("WS", 58);
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
		EnterRule("CHAR", 59);
		TraceIn("CHAR", 59);
		try
		{
			int _type = CHAR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:178:5: ( '\\'' ( 'a' .. 'z' ) '\\'' )
			DebugEnterAlt(1);
			// MathLang.g:178:8: '\\'' ( 'a' .. 'z' ) '\\''
			{
			DebugLocation(178, 8);
			Match('\''); 
			DebugLocation(178, 12);
			// MathLang.g:178:12: ( 'a' .. 'z' )
			DebugEnterAlt(1);
			// MathLang.g:178:13: 'a' .. 'z'
			{
			DebugLocation(178, 13);
			MatchRange('a','z'); 

			}

			DebugLocation(178, 22);
			Match('\''); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CHAR", 59);
			LeaveRule("CHAR", 59);
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
		EnterRule("ID", 60);
		TraceIn("ID", 60);
		try
		{
			int _type = ID;
			int _channel = DefaultTokenChannel;
			// MathLang.g:179:3: ( ( 'a' .. 'z' )+ )
			DebugEnterAlt(1);
			// MathLang.g:179:6: ( 'a' .. 'z' )+
			{
			DebugLocation(179, 6);
			// MathLang.g:179:6: ( 'a' .. 'z' )+
			int cnt4=0;
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_0 = input.LA(1);

				if (((LA4_0>='a' && LA4_0<='z')))
				{
					alt4=1;
				}


				} finally { DebugExitDecision(4); }
				switch (alt4)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:179:7: 'a' .. 'z'
					{
					DebugLocation(179, 7);
					MatchRange('a','z'); 

					}
					break;

				default:
					if (cnt4 >= 1)
						goto loop4;

					EarlyExitException eee4 = new EarlyExitException( 4, input );
					DebugRecognitionException(eee4);
					throw eee4;
				}
				cnt4++;
			}
			loop4:
				;

			} finally { DebugExitSubRule(4); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ID", 60);
			LeaveRule("ID", 60);
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
		EnterRule("SL_COMMENT", 61);
		TraceIn("SL_COMMENT", 61);
		try
		{
			int _type = SL_COMMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:183:11: ( '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n' )
			DebugEnterAlt(1);
			// MathLang.g:184:3: '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n'
			{
			DebugLocation(184, 3);
			Match("//"); 

			DebugLocation(184, 8);
			// MathLang.g:184:8: ( options {greedy=false; } : . )*
			try { DebugEnterSubRule(5);
			while (true)
			{
				int alt5=2;
				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
				int LA5_0 = input.LA(1);

				if ((LA5_0=='\r'))
				{
					alt5=2;
				}
				else if ((LA5_0=='\n'))
				{
					alt5=2;
				}
				else if (((LA5_0>='\u0000' && LA5_0<='\t')||(LA5_0>='\u000B' && LA5_0<='\f')||(LA5_0>='\u000E' && LA5_0<='\uFFFF')))
				{
					alt5=1;
				}


				} finally { DebugExitDecision(5); }
				switch ( alt5 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:184:36: .
					{
					DebugLocation(184, 36);
					MatchAny(); 

					}
					break;

				default:
					goto loop5;
				}
			}

			loop5:
				;

			} finally { DebugExitSubRule(5); }

			DebugLocation(184, 40);
			// MathLang.g:184:40: ( '\\r' )?
			int alt6=2;
			try { DebugEnterSubRule(6);
			try { DebugEnterDecision(6, decisionCanBacktrack[6]);
			int LA6_0 = input.LA(1);

			if ((LA6_0=='\r'))
			{
				alt6=1;
			}
			} finally { DebugExitDecision(6); }
			switch (alt6)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:184:40: '\\r'
				{
				DebugLocation(184, 40);
				Match('\r'); 

				}
				break;

			}
			} finally { DebugExitSubRule(6); }

			DebugLocation(184, 46);
			Match('\n'); 
			DebugLocation(184, 51);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SL_COMMENT", 61);
			LeaveRule("SL_COMMENT", 61);
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
		EnterRule("ML_COMMENT", 62);
		TraceIn("ML_COMMENT", 62);
		try
		{
			int _type = ML_COMMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:188:11: ( '/*' ( options {greedy=false; } : . )* '*/' )
			DebugEnterAlt(1);
			// MathLang.g:189:3: '/*' ( options {greedy=false; } : . )* '*/'
			{
			DebugLocation(189, 3);
			Match("/*"); 

			DebugLocation(189, 8);
			// MathLang.g:189:8: ( options {greedy=false; } : . )*
			try { DebugEnterSubRule(7);
			while (true)
			{
				int alt7=2;
				try { DebugEnterDecision(7, decisionCanBacktrack[7]);
				int LA7_0 = input.LA(1);

				if ((LA7_0=='*'))
				{
					int LA7_1 = input.LA(2);

					if ((LA7_1=='/'))
					{
						alt7=2;
					}
					else if (((LA7_1>='\u0000' && LA7_1<='.')||(LA7_1>='0' && LA7_1<='\uFFFF')))
					{
						alt7=1;
					}


				}
				else if (((LA7_0>='\u0000' && LA7_0<=')')||(LA7_0>='+' && LA7_0<='\uFFFF')))
				{
					alt7=1;
				}


				} finally { DebugExitDecision(7); }
				switch ( alt7 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:189:36: .
					{
					DebugLocation(189, 36);
					MatchAny(); 

					}
					break;

				default:
					goto loop7;
				}
			}

			loop7:
				;

			} finally { DebugExitSubRule(7); }

			DebugLocation(189, 40);
			Match("*/"); 

			DebugLocation(189, 45);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ML_COMMENT", 62);
			LeaveRule("ML_COMMENT", 62);
			Leave_ML_COMMENT();
		}
	}
	// $ANTLR end "ML_COMMENT"

	public override void mTokens()
	{
		// MathLang.g:1:8: ( PRINT | INPUT | IF | ELSE | FOR | FUNCTION | WHILE | DO | VARDECLARATION | FUNCDECLARATION | ARRAYDECLARATION | VARASSIGNMENT | ARRAYELEMENTASSIGNMENT | ARRAYELEMENT | NEWVAR | ARRAY_INITIALIZER | OBJECT_INITIALIZER | FUNC_CALL | RETURN_TYPE | PARAMETERS | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | KNEW | CONSOLE_WORD | ARRAY_DECLARATION_MARK | SQRBL | SQRBR | TYPE | VOID | NUMBER | ADD | SUB | MUL | DIV | ASSIGN | RETURN | TRUE | FALSE | EQ | NEQ | GR | GREQ | LS | LSEQ | NOT | OR | AND | WS | CHAR | ID | SL_COMMENT | ML_COMMENT )
		int alt8=62;
		try { DebugEnterDecision(8, decisionCanBacktrack[8]);
		try
		{
			alt8 = dfa8.Predict(input);
		}
		catch (NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
			throw;
		}
		} finally { DebugExitDecision(8); }
		switch (alt8)
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
			// MathLang.g:1:49: DO
			{
			DebugLocation(1, 49);
			mDO(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// MathLang.g:1:52: VARDECLARATION
			{
			DebugLocation(1, 52);
			mVARDECLARATION(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// MathLang.g:1:67: FUNCDECLARATION
			{
			DebugLocation(1, 67);
			mFUNCDECLARATION(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// MathLang.g:1:83: ARRAYDECLARATION
			{
			DebugLocation(1, 83);
			mARRAYDECLARATION(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// MathLang.g:1:100: VARASSIGNMENT
			{
			DebugLocation(1, 100);
			mVARASSIGNMENT(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// MathLang.g:1:114: ARRAYELEMENTASSIGNMENT
			{
			DebugLocation(1, 114);
			mARRAYELEMENTASSIGNMENT(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// MathLang.g:1:137: ARRAYELEMENT
			{
			DebugLocation(1, 137);
			mARRAYELEMENT(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// MathLang.g:1:150: NEWVAR
			{
			DebugLocation(1, 150);
			mNEWVAR(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// MathLang.g:1:157: ARRAY_INITIALIZER
			{
			DebugLocation(1, 157);
			mARRAY_INITIALIZER(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// MathLang.g:1:175: OBJECT_INITIALIZER
			{
			DebugLocation(1, 175);
			mOBJECT_INITIALIZER(); 

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// MathLang.g:1:194: FUNC_CALL
			{
			DebugLocation(1, 194);
			mFUNC_CALL(); 

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// MathLang.g:1:204: RETURN_TYPE
			{
			DebugLocation(1, 204);
			mRETURN_TYPE(); 

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// MathLang.g:1:216: PARAMETERS
			{
			DebugLocation(1, 216);
			mPARAMETERS(); 

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// MathLang.g:1:227: T__58
			{
			DebugLocation(1, 227);
			mT__58(); 

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// MathLang.g:1:233: T__59
			{
			DebugLocation(1, 233);
			mT__59(); 

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// MathLang.g:1:239: T__60
			{
			DebugLocation(1, 239);
			mT__60(); 

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// MathLang.g:1:245: T__61
			{
			DebugLocation(1, 245);
			mT__61(); 

			}
			break;
		case 25:
			DebugEnterAlt(25);
			// MathLang.g:1:251: T__62
			{
			DebugLocation(1, 251);
			mT__62(); 

			}
			break;
		case 26:
			DebugEnterAlt(26);
			// MathLang.g:1:257: T__63
			{
			DebugLocation(1, 257);
			mT__63(); 

			}
			break;
		case 27:
			DebugEnterAlt(27);
			// MathLang.g:1:263: T__64
			{
			DebugLocation(1, 263);
			mT__64(); 

			}
			break;
		case 28:
			DebugEnterAlt(28);
			// MathLang.g:1:269: T__65
			{
			DebugLocation(1, 269);
			mT__65(); 

			}
			break;
		case 29:
			DebugEnterAlt(29);
			// MathLang.g:1:275: T__66
			{
			DebugLocation(1, 275);
			mT__66(); 

			}
			break;
		case 30:
			DebugEnterAlt(30);
			// MathLang.g:1:281: T__67
			{
			DebugLocation(1, 281);
			mT__67(); 

			}
			break;
		case 31:
			DebugEnterAlt(31);
			// MathLang.g:1:287: T__68
			{
			DebugLocation(1, 287);
			mT__68(); 

			}
			break;
		case 32:
			DebugEnterAlt(32);
			// MathLang.g:1:293: T__69
			{
			DebugLocation(1, 293);
			mT__69(); 

			}
			break;
		case 33:
			DebugEnterAlt(33);
			// MathLang.g:1:299: KNEW
			{
			DebugLocation(1, 299);
			mKNEW(); 

			}
			break;
		case 34:
			DebugEnterAlt(34);
			// MathLang.g:1:304: CONSOLE_WORD
			{
			DebugLocation(1, 304);
			mCONSOLE_WORD(); 

			}
			break;
		case 35:
			DebugEnterAlt(35);
			// MathLang.g:1:317: ARRAY_DECLARATION_MARK
			{
			DebugLocation(1, 317);
			mARRAY_DECLARATION_MARK(); 

			}
			break;
		case 36:
			DebugEnterAlt(36);
			// MathLang.g:1:340: SQRBL
			{
			DebugLocation(1, 340);
			mSQRBL(); 

			}
			break;
		case 37:
			DebugEnterAlt(37);
			// MathLang.g:1:346: SQRBR
			{
			DebugLocation(1, 346);
			mSQRBR(); 

			}
			break;
		case 38:
			DebugEnterAlt(38);
			// MathLang.g:1:352: TYPE
			{
			DebugLocation(1, 352);
			mTYPE(); 

			}
			break;
		case 39:
			DebugEnterAlt(39);
			// MathLang.g:1:357: VOID
			{
			DebugLocation(1, 357);
			mVOID(); 

			}
			break;
		case 40:
			DebugEnterAlt(40);
			// MathLang.g:1:362: NUMBER
			{
			DebugLocation(1, 362);
			mNUMBER(); 

			}
			break;
		case 41:
			DebugEnterAlt(41);
			// MathLang.g:1:369: ADD
			{
			DebugLocation(1, 369);
			mADD(); 

			}
			break;
		case 42:
			DebugEnterAlt(42);
			// MathLang.g:1:373: SUB
			{
			DebugLocation(1, 373);
			mSUB(); 

			}
			break;
		case 43:
			DebugEnterAlt(43);
			// MathLang.g:1:377: MUL
			{
			DebugLocation(1, 377);
			mMUL(); 

			}
			break;
		case 44:
			DebugEnterAlt(44);
			// MathLang.g:1:381: DIV
			{
			DebugLocation(1, 381);
			mDIV(); 

			}
			break;
		case 45:
			DebugEnterAlt(45);
			// MathLang.g:1:385: ASSIGN
			{
			DebugLocation(1, 385);
			mASSIGN(); 

			}
			break;
		case 46:
			DebugEnterAlt(46);
			// MathLang.g:1:392: RETURN
			{
			DebugLocation(1, 392);
			mRETURN(); 

			}
			break;
		case 47:
			DebugEnterAlt(47);
			// MathLang.g:1:399: TRUE
			{
			DebugLocation(1, 399);
			mTRUE(); 

			}
			break;
		case 48:
			DebugEnterAlt(48);
			// MathLang.g:1:404: FALSE
			{
			DebugLocation(1, 404);
			mFALSE(); 

			}
			break;
		case 49:
			DebugEnterAlt(49);
			// MathLang.g:1:410: EQ
			{
			DebugLocation(1, 410);
			mEQ(); 

			}
			break;
		case 50:
			DebugEnterAlt(50);
			// MathLang.g:1:413: NEQ
			{
			DebugLocation(1, 413);
			mNEQ(); 

			}
			break;
		case 51:
			DebugEnterAlt(51);
			// MathLang.g:1:417: GR
			{
			DebugLocation(1, 417);
			mGR(); 

			}
			break;
		case 52:
			DebugEnterAlt(52);
			// MathLang.g:1:420: GREQ
			{
			DebugLocation(1, 420);
			mGREQ(); 

			}
			break;
		case 53:
			DebugEnterAlt(53);
			// MathLang.g:1:425: LS
			{
			DebugLocation(1, 425);
			mLS(); 

			}
			break;
		case 54:
			DebugEnterAlt(54);
			// MathLang.g:1:428: LSEQ
			{
			DebugLocation(1, 428);
			mLSEQ(); 

			}
			break;
		case 55:
			DebugEnterAlt(55);
			// MathLang.g:1:433: NOT
			{
			DebugLocation(1, 433);
			mNOT(); 

			}
			break;
		case 56:
			DebugEnterAlt(56);
			// MathLang.g:1:437: OR
			{
			DebugLocation(1, 437);
			mOR(); 

			}
			break;
		case 57:
			DebugEnterAlt(57);
			// MathLang.g:1:440: AND
			{
			DebugLocation(1, 440);
			mAND(); 

			}
			break;
		case 58:
			DebugEnterAlt(58);
			// MathLang.g:1:444: WS
			{
			DebugLocation(1, 444);
			mWS(); 

			}
			break;
		case 59:
			DebugEnterAlt(59);
			// MathLang.g:1:447: CHAR
			{
			DebugLocation(1, 447);
			mCHAR(); 

			}
			break;
		case 60:
			DebugEnterAlt(60);
			// MathLang.g:1:452: ID
			{
			DebugLocation(1, 452);
			mID(); 

			}
			break;
		case 61:
			DebugEnterAlt(61);
			// MathLang.g:1:455: SL_COMMENT
			{
			DebugLocation(1, 455);
			mSL_COMMENT(); 

			}
			break;
		case 62:
			DebugEnterAlt(62);
			// MathLang.g:1:466: ML_COMMENT
			{
			DebugLocation(1, 466);
			mML_COMMENT(); 

			}
			break;

		}

	}


	#region DFA
	DFA8 dfa8;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa8 = new DFA8(this);
	}

	private class DFA8 : DFA
	{
		private const string DFA8_eotS =
			"\x1\xFFFF\xB\x28\x1\xFFFF\x1\x3A\x8\xFFFF\x1\x3D\x1\xFFFF\x2\x28\x4"+
			"\xFFFF\x1\x43\x1\x45\x1\x28\x1\x48\x1\x4A\x1\x4C\x5\xFFFF\x3\x28\x1\x51"+
			"\x5\x28\x1\x57\x6\x28\x6\xFFFF\x2\x28\x5\xFFFF\x1\x28\x6\xFFFF\x3\x28"+
			"\x1\x66\x1\xFFFF\x1\x28\x1\x68\x3\x28\x1\xFFFF\x3\x28\x1\x71\x2\x28\x2"+
			"\xFFFF\x6\x28\x1\xFFFF\x1\x7C\x1\xFFFF\x5\x28\x1\x84\x2\x28\x1\xFFFF"+
			"\x2\x28\x1\xFFFF\x1\x8B\x2\x66\x1\x8C\x1\x8D\x1\x28\x1\x8F\x1\xFFFF\x2"+
			"\x28\x1\xFFFF\x1\x92\x1\x93\x2\x28\x1\xFFFF\x4\x28\x1\x9D\x4\xFFFF\x1"+
			"\x28\x1\xFFFF\x2\x28\x2\xFFFF\x4\x28\x1\xFFFF\x1\xA5\x1\x28\x1\xA8\x2"+
			"\xFFFF\x7\x28\x4\xFFFF\x1\x28\x1\xB1\x6\x28\x1\xFFFF\x5\x28\x1\xBD\x5"+
			"\x28\x1\xFFFF\x9\x28\x1\xCD\x2\x28\x1\xD0\x2\x28\x1\xFFFF\x1\x28\x1\xD4"+
			"\x1\xFFFF\x2\x28\x1\xD7\x1\xFFFF\x2\x28\x1\xFFFF\x1\xDA\x1\x28\x1\xFFFF"+
			"\x5\x28\x1\xE1\x1\xFFFF";
		private const string DFA8_eofS =
			"\xE2\xFFFF";
		private const string DFA8_minS =
			"\x1\x9\x1\x61\x1\x66\x1\x6C\x1\x61\x1\x68\x1\x6F\x1\x61\x1\x72\x1\x65"+
			"\x1\x62\x1\x65\x1\xFFFF\x1\x29\x5\xFFFF\x1\x72\x1\x65\x1\xFFFF\x1\x5D"+
			"\x1\xFFFF\x1\x6F\x1\x68\x4\xFFFF\x1\x2A\x1\x3D\x1\x72\x3\x3D\x5\xFFFF"+
			"\x1\x69\x1\x72\x1\x70\x1\x61\x1\x73\x1\x72\x1\x6E\x1\x6C\x1\x69\x1\x61"+
			"\x1\x72\x1\x69\x1\x72\x1\x77\x1\x6A\x1\x74\x2\xFFFF\x1\x69\x1\x61\x2"+
			"\xFFFF\x1\x6F\x1\x61\x5\xFFFF\x1\x75\x6\xFFFF\x1\x6E\x1\x61\x1\x75\x1"+
			"\x61\x1\xFFFF\x1\x65\x1\x61\x1\x63\x1\x73\x1\x6C\x1\xFFFF\x1\x61\x1\x64"+
			"\x2\x61\x1\x65\x1\x75\x1\x74\x1\x64\x1\x6C\x1\x72\x1\x65\x1\x74\x1\x6D"+
			"\x1\x74\x1\xFFFF\x1\x61\x1\xFFFF\x1\x5F\x3\x65\x1\x73\x1\x61\x1\x79\x1"+
			"\x61\x1\xFFFF\x1\x63\x1\x72\x1\x65\x1\x4C\x4\x61\x1\x65\x1\x61\x1\xFFFF"+
			"\x1\x69\x1\x65\x1\xFFFF\x2\x61\x1\x63\x1\x73\x1\xFFFF\x1\x5F\x1\x72\x1"+
			"\x74\x1\x6E\x1\x4C\x4\xFFFF\x1\x74\x1\xFFFF\x1\x6F\x1\x63\x2\xFFFF\x1"+
			"\x6C\x1\x69\x1\x65\x1\x6C\x1\xFFFF\x1\x61\x2\x5F\x2\xFFFF\x1\x65\x1\x6E"+
			"\x1\x6C\x1\x61\x1\x67\x1\x63\x1\x65\x4\xFFFF\x1\x72\x2\x61\x1\x72\x1"+
			"\x6E\x1\x6C\x1\x6D\x1\x73\x1\xFFFF\x1\x72\x1\x61\x1\x6D\x1\x61\x1\x65"+
			"\x2\x61\x1\x74\x1\x65\x1\x72\x1\x6E\x1\xFFFF\x1\x74\x1\x69\x1\x6E\x1"+
			"\x61\x1\x74\x1\x69\x1\x6F\x2\x74\x1\x61\x1\x6F\x1\x6E\x1\x61\x1\x69\x1"+
			"\x73\x1\xFFFF\x1\x6E\x1\x61\x1\xFFFF\x1\x6F\x1\x73\x1\x61\x1\xFFFF\x1"+
			"\x6E\x1\x69\x1\xFFFF\x1\x61\x1\x67\x1\xFFFF\x1\x6E\x1\x6D\x1\x65\x1\x6E"+
			"\x1\x74\x1\x61\x1\xFFFF";
		private const string DFA8_maxS =
			"\x1\x7D\x1\x72\x1\x6E\x1\x6C\x1\x75\x1\x68\x2\x6F\x1\x72\x1\x65\x1\x62"+
			"\x1\x65\x1\xFFFF\x1\x29\x5\xFFFF\x1\x72\x1\x65\x1\xFFFF\x1\x5D\x1\xFFFF"+
			"\x1\x6F\x1\x68\x4\xFFFF\x1\x2F\x1\x3D\x1\x72\x3\x3D\x5\xFFFF\x1\x69\x1"+
			"\x72\x1\x74\x1\x7A\x1\x73\x1\x72\x1\x6E\x1\x6C\x1\x69\x1\x7A\x1\x72\x1"+
			"\x69\x1\x72\x1\x77\x1\x6A\x1\x74\x2\xFFFF\x1\x69\x1\x61\x2\xFFFF\x1\x6F"+
			"\x1\x61\x5\xFFFF\x1\x75\x6\xFFFF\x1\x6E\x1\x61\x1\x75\x1\x7A\x1\xFFFF"+
			"\x1\x65\x1\x7A\x1\x63\x1\x73\x1\x6C\x1\xFFFF\x2\x64\x1\x61\x1\x7A\x1"+
			"\x65\x1\x75\x1\x74\x1\x64\x1\x6C\x1\x72\x1\x65\x1\x74\x1\x6D\x1\x74\x1"+
			"\xFFFF\x1\x7A\x1\xFFFF\x1\x74\x3\x65\x1\x73\x1\x7A\x1\x79\x1\x61\x1\xFFFF"+
			"\x1\x63\x1\x72\x1\x65\x1\x4C\x4\x7A\x1\x65\x1\x7A\x1\xFFFF\x1\x69\x1"+
			"\x65\x1\xFFFF\x2\x7A\x1\x63\x1\x73\x1\xFFFF\x1\x65\x1\x72\x1\x74\x1\x6E"+
			"\x1\x4C\x4\xFFFF\x1\x74\x1\xFFFF\x1\x6F\x1\x63\x2\xFFFF\x1\x6C\x1\x69"+
			"\x1\x65\x1\x6C\x1\xFFFF\x1\x7A\x1\x5F\x1\x7A\x2\xFFFF\x1\x65\x1\x6E\x1"+
			"\x6C\x1\x61\x1\x67\x1\x63\x1\x65\x4\xFFFF\x1\x72\x1\x7A\x1\x61\x1\x72"+
			"\x1\x6E\x1\x6C\x1\x6D\x1\x73\x1\xFFFF\x1\x72\x1\x61\x1\x6D\x1\x61\x1"+
			"\x65\x1\x7A\x1\x61\x1\x74\x1\x65\x1\x72\x1\x6E\x1\xFFFF\x1\x74\x1\x69"+
			"\x1\x6E\x1\x61\x1\x74\x1\x69\x1\x6F\x2\x74\x1\x7A\x1\x6F\x1\x6E\x1\x7A"+
			"\x1\x69\x1\x73\x1\xFFFF\x1\x6E\x1\x7A\x1\xFFFF\x1\x6F\x1\x73\x1\x7A\x1"+
			"\xFFFF\x1\x6E\x1\x69\x1\xFFFF\x1\x7A\x1\x67\x1\xFFFF\x1\x6E\x1\x6D\x1"+
			"\x65\x1\x6E\x1\x74\x1\x7A\x1\xFFFF";
		private const string DFA8_acceptS =
			"\xC\xFFFF\x1\x15\x1\xFFFF\x1\x17\x1\x19\x1\x1A\x1\x1B\x1\x1C\x2\xFFFF"+
			"\x1\x22\x1\xFFFF\x1\x25\x2\xFFFF\x1\x28\x1\x29\x1\x2A\x1\x2B\x6\xFFFF"+
			"\x1\x38\x1\x39\x1\x3A\x1\x3B\x1\x3C\x10\xFFFF\x1\x18\x1\x16\x2\xFFFF"+
			"\x1\x24\x1\x23\x2\xFFFF\x1\x3D\x1\x3E\x1\x2C\x1\x31\x1\x2D\x1\xFFFF\x1"+
			"\x32\x1\x37\x1\x34\x1\x33\x1\x36\x1\x35\x4\xFFFF\x1\x3\x5\xFFFF\x1\x8"+
			"\xE\xFFFF\x1\x26\x1\xFFFF\x1\x5\x8\xFFFF\x1\x21\xA\xFFFF\x1\x4\x2\xFFFF"+
			"\x1\x12\x4\xFFFF\x1\x27\x5\xFFFF\x1\x1F\x1\x20\x1\x2F\x1\x1\x1\xFFFF"+
			"\x1\x2\x2\xFFFF\x1\x30\x1\x7\x4\xFFFF\x1\x10\x3\xFFFF\x1\x1D\x1\x1E\x7"+
			"\xFFFF\x1\xF\x1\x11\x1\x13\x1\x2E\x8\xFFFF\x1\x6\xB\xFFFF\x1\x14\xF\xFFFF"+
			"\x1\xE\x2\xFFFF\x1\xC\x3\xFFFF\x1\x9\x2\xFFFF\x1\xA\x2\xFFFF\x1\xB\x6"+
			"\xFFFF\x1\xD";
		private const string DFA8_specialS =
			"\xE2\xFFFF}>";
		private static readonly string[] DFA8_transitionS =
			{
				"\x2\x26\x1\xFFFF\x2\x26\x12\xFFFF\x1\x26\x1\x21\x4\xFFFF\x1\x25\x1"+
				"\x27\x1\xD\x1\xE\x1\x1D\x1\x1B\x1\xF\x1\x1C\x1\x12\x1\x1E\xA\x1A\x1"+
				"\xFFFF\x1\xC\x1\x23\x1\x1F\x1\x22\x4\xFFFF\x1\x15\xE\xFFFF\x1\x14\x4"+
				"\xFFFF\x1\x13\x3\xFFFF\x1\x16\x1\xFFFF\x1\x17\x3\xFFFF\x1\x8\x1\x18"+
				"\x1\x19\x1\x6\x1\x3\x1\x4\x2\x28\x1\x2\x4\x28\x1\x9\x1\xA\x1\x1\x1\x28"+
				"\x1\xB\x1\x28\x1\x20\x1\x28\x1\x7\x1\x5\x3\x28\x1\x10\x1\x24\x1\x11",
				"\x1\x2A\x10\xFFFF\x1\x29",
				"\x1\x2C\x7\xFFFF\x1\x2B",
				"\x1\x2D",
				"\x1\x30\xD\xFFFF\x1\x2E\x5\xFFFF\x1\x2F",
				"\x1\x31",
				"\x1\x32",
				"\x1\x33\xD\xFFFF\x1\x34",
				"\x1\x35",
				"\x1\x36",
				"\x1\x37",
				"\x1\x38",
				"",
				"\x1\x39",
				"",
				"",
				"",
				"",
				"",
				"\x1\x3B",
				"\x1\x3C",
				"",
				"\x1\x3E",
				"",
				"\x1\x3F",
				"\x1\x40",
				"",
				"",
				"",
				"",
				"\x1\x42\x4\xFFFF\x1\x41",
				"\x1\x44",
				"\x1\x46",
				"\x1\x47",
				"\x1\x49",
				"\x1\x4B",
				"",
				"",
				"",
				"",
				"",
				"\x1\x4D",
				"\x1\x4E",
				"\x1\x4F\x3\xFFFF\x1\x50",
				"\x1A\x28",
				"\x1\x52",
				"\x1\x53",
				"\x1\x54",
				"\x1\x55",
				"\x1\x56",
				"\x1A\x28",
				"\x1\x58",
				"\x1\x59",
				"\x1\x5A",
				"\x1\x5B",
				"\x1\x5C",
				"\x1\x5D",
				"",
				"",
				"\x1\x5E",
				"\x1\x5F",
				"",
				"",
				"\x1\x60",
				"\x1\x61",
				"",
				"",
				"",
				"",
				"",
				"\x1\x62",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x63",
				"\x1\x64",
				"\x1\x65",
				"\x1A\x28",
				"",
				"\x1\x67",
				"\x1A\x28",
				"\x1\x69",
				"\x1\x6A",
				"\x1\x6B",
				"",
				"\x1\x6D\x2\xFFFF\x1\x6C",
				"\x1\x6E",
				"\x1\x6F",
				"\x15\x28\x1\x70\x4\x28",
				"\x1\x72",
				"\x1\x73",
				"\x1\x74",
				"\x1\x75",
				"\x1\x76",
				"\x1\x77",
				"\x1\x78",
				"\x1\x79",
				"\x1\x7A",
				"\x1\x7B",
				"",
				"\x1A\x28",
				"",
				"\x1\x7F\x4\xFFFF\x1\x7E\xF\xFFFF\x1\x7D",
				"\x1\x80",
				"\x1\x81",
				"\x1\x82",
				"\x1\x83",
				"\x1A\x28",
				"\x1\x85",
				"\x1\x86",
				"",
				"\x1\x87",
				"\x1\x88",
				"\x1\x89",
				"\x1\x8A",
				"\x1A\x28",
				"\x1A\x28",
				"\x1A\x28",
				"\x1A\x28",
				"\x1\x8E",
				"\x1A\x28",
				"",
				"\x1\x90",
				"\x1\x91",
				"",
				"\x1A\x28",
				"\x1A\x28",
				"\x1\x94",
				"\x1\x95",
				"",
				"\x1\x98\x4\xFFFF\x1\x96\x1\x97",
				"\x1\x99",
				"\x1\x9A",
				"\x1\x9B",
				"\x1\x9C",
				"",
				"",
				"",
				"",
				"\x1\x9E",
				"",
				"\x1\x9F",
				"\x1\xA0",
				"",
				"",
				"\x1\xA1",
				"\x1\xA2",
				"\x1\xA3",
				"\x1\xA4",
				"",
				"\x1A\x28",
				"\x1\xA6",
				"\x1\xA7\x1\xFFFF\x1A\x28",
				"",
				"",
				"\x1\xA9",
				"\x1\xAA",
				"\x1\xAB",
				"\x1\xAC",
				"\x1\xAD",
				"\x1\xAE",
				"\x1\xAF",
				"",
				"",
				"",
				"",
				"\x1\xB0",
				"\x1A\x28",
				"\x1\xB2",
				"\x1\xB3",
				"\x1\xB4",
				"\x1\xB5",
				"\x1\xB6",
				"\x1\xB7",
				"",
				"\x1\xB8",
				"\x1\xB9",
				"\x1\xBA",
				"\x1\xBB",
				"\x1\xBC",
				"\x1A\x28",
				"\x1\xBE",
				"\x1\xBF",
				"\x1\xC0",
				"\x1\xC1",
				"\x1\xC2",
				"",
				"\x1\xC3",
				"\x1\xC4",
				"\x1\xC5",
				"\x1\xC6",
				"\x1\xC7",
				"\x1\xC8",
				"\x1\xC9",
				"\x1\xCA",
				"\x1\xCB",
				"\x1\xCC\x19\x28",
				"\x1\xCE",
				"\x1\xCF",
				"\x1A\x28",
				"\x1\xD1",
				"\x1\xD2",
				"",
				"\x1\xD3",
				"\x1A\x28",
				"",
				"\x1\xD5",
				"\x1\xD6",
				"\x1A\x28",
				"",
				"\x1\xD8",
				"\x1\xD9",
				"",
				"\x1A\x28",
				"\x1\xDB",
				"",
				"\x1\xDC",
				"\x1\xDD",
				"\x1\xDE",
				"\x1\xDF",
				"\x1\xE0",
				"\x1A\x28",
				""
			};

		private static readonly short[] DFA8_eot = DFA.UnpackEncodedString(DFA8_eotS);
		private static readonly short[] DFA8_eof = DFA.UnpackEncodedString(DFA8_eofS);
		private static readonly char[] DFA8_min = DFA.UnpackEncodedStringToUnsignedChars(DFA8_minS);
		private static readonly char[] DFA8_max = DFA.UnpackEncodedStringToUnsignedChars(DFA8_maxS);
		private static readonly short[] DFA8_accept = DFA.UnpackEncodedString(DFA8_acceptS);
		private static readonly short[] DFA8_special = DFA.UnpackEncodedString(DFA8_specialS);
		private static readonly short[][] DFA8_transition;

		static DFA8()
		{
			int numStates = DFA8_transitionS.Length;
			DFA8_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA8_transition[i] = DFA.UnpackEncodedString(DFA8_transitionS[i]);
			}
		}

		public DFA8( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 8;
			this.eot = DFA8_eot;
			this.eof = DFA8_eof;
			this.min = DFA8_min;
			this.max = DFA8_max;
			this.accept = DFA8_accept;
			this.special = DFA8_special;
			this.transition = DFA8_transition;
		}

		public override string Description { get { return "1:1: Tokens : ( PRINT | INPUT | IF | ELSE | FOR | FUNCTION | WHILE | DO | VARDECLARATION | FUNCDECLARATION | ARRAYDECLARATION | VARASSIGNMENT | ARRAYELEMENTASSIGNMENT | ARRAYELEMENT | NEWVAR | ARRAY_INITIALIZER | OBJECT_INITIALIZER | FUNC_CALL | RETURN_TYPE | PARAMETERS | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | KNEW | CONSOLE_WORD | ARRAY_DECLARATION_MARK | SQRBL | SQRBR | TYPE | VOID | NUMBER | ADD | SUB | MUL | DIV | ASSIGN | RETURN | TRUE | FALSE | EQ | NEQ | GR | GREQ | LS | LSEQ | NOT | OR | AND | WS | CHAR | ID | SL_COMMENT | ML_COMMENT );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}

} // namespace  MathLang 

// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-10-07 21:09:16

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
	public const int SQRBL=52;
	public const int SQRBR=53;
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

	partial void Enter_T__57();
	partial void Leave_T__57();

	// $ANTLR start "T__57"
	[GrammarRule("T__57")]
	private void mT__57()
	{
		Enter_T__57();
		EnterRule("T__57", 21);
		TraceIn("T__57", 21);
		try
		{
			int _type = T__57;
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
			TraceOut("T__57", 21);
			LeaveRule("T__57", 21);
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
		EnterRule("T__58", 22);
		TraceIn("T__58", 22);
		try
		{
			int _type = T__58;
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
			TraceOut("T__58", 22);
			LeaveRule("T__58", 22);
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
		EnterRule("T__59", 23);
		TraceIn("T__59", 23);
		try
		{
			int _type = T__59;
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
			TraceOut("T__59", 23);
			LeaveRule("T__59", 23);
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
		EnterRule("T__60", 24);
		TraceIn("T__60", 24);
		try
		{
			int _type = T__60;
			int _channel = DefaultTokenChannel;
			// MathLang.g:32:7: ( ',' )
			DebugEnterAlt(1);
			// MathLang.g:32:9: ','
			{
			DebugLocation(32, 9);
			Match(','); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__60", 24);
			LeaveRule("T__60", 24);
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
		EnterRule("T__61", 25);
		TraceIn("T__61", 25);
		try
		{
			int _type = T__61;
			int _channel = DefaultTokenChannel;
			// MathLang.g:33:7: ( '{' )
			DebugEnterAlt(1);
			// MathLang.g:33:9: '{'
			{
			DebugLocation(33, 9);
			Match('{'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__61", 25);
			LeaveRule("T__61", 25);
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
		EnterRule("T__62", 26);
		TraceIn("T__62", 26);
		try
		{
			int _type = T__62;
			int _channel = DefaultTokenChannel;
			// MathLang.g:34:7: ( '}' )
			DebugEnterAlt(1);
			// MathLang.g:34:9: '}'
			{
			DebugLocation(34, 9);
			Match('}'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__62", 26);
			LeaveRule("T__62", 26);
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
		EnterRule("KNEW", 27);
		TraceIn("KNEW", 27);
		try
		{
			int _type = KNEW;
			int _channel = DefaultTokenChannel;
			// MathLang.g:139:5: ( 'new' )
			DebugEnterAlt(1);
			// MathLang.g:139:7: 'new'
			{
			DebugLocation(139, 7);
			Match("new"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("KNEW", 27);
			LeaveRule("KNEW", 27);
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
		EnterRule("ARRAY_DECLARATION_MARK", 28);
		TraceIn("ARRAY_DECLARATION_MARK", 28);
		try
		{
			int _type = ARRAY_DECLARATION_MARK;
			int _channel = DefaultTokenChannel;
			// MathLang.g:140:23: ( SQRBL SQRBR )
			DebugEnterAlt(1);
			// MathLang.g:140:25: SQRBL SQRBR
			{
			DebugLocation(140, 25);
			mSQRBL(); 
			DebugLocation(140, 31);
			mSQRBR(); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ARRAY_DECLARATION_MARK", 28);
			LeaveRule("ARRAY_DECLARATION_MARK", 28);
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
		EnterRule("SQRBL", 29);
		TraceIn("SQRBL", 29);
		try
		{
			int _type = SQRBL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:141:6: ( '[' )
			DebugEnterAlt(1);
			// MathLang.g:141:7: '['
			{
			DebugLocation(141, 7);
			Match('['); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SQRBL", 29);
			LeaveRule("SQRBL", 29);
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
		EnterRule("SQRBR", 30);
		TraceIn("SQRBR", 30);
		try
		{
			int _type = SQRBR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:142:6: ( ']' )
			DebugEnterAlt(1);
			// MathLang.g:142:7: ']'
			{
			DebugLocation(142, 7);
			Match(']'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SQRBR", 30);
			LeaveRule("SQRBR", 30);
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
		EnterRule("TYPE", 31);
		TraceIn("TYPE", 31);
		try
		{
			int _type = TYPE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:143:5: ( 'int' | 'bool' | 'char' )
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
				// MathLang.g:143:7: 'int'
				{
				DebugLocation(143, 7);
				Match("int"); 


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:143:15: 'bool'
				{
				DebugLocation(143, 15);
				Match("bool"); 


				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:143:24: 'char'
				{
				DebugLocation(143, 24);
				Match("char"); 


				}
				break;

			}
			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TYPE", 31);
			LeaveRule("TYPE", 31);
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
		EnterRule("VOID", 32);
		TraceIn("VOID", 32);
		try
		{
			int _type = VOID;
			int _channel = DefaultTokenChannel;
			// MathLang.g:144:5: ( 'void' )
			DebugEnterAlt(1);
			// MathLang.g:144:7: 'void'
			{
			DebugLocation(144, 7);
			Match("void"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("VOID", 32);
			LeaveRule("VOID", 32);
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
		EnterRule("NUMBER", 33);
		TraceIn("NUMBER", 33);
		try
		{
			int _type = NUMBER;
			int _channel = DefaultTokenChannel;
			// MathLang.g:145:7: ( ( '0' .. '9' )+ )
			DebugEnterAlt(1);
			// MathLang.g:145:9: ( '0' .. '9' )+
			{
			DebugLocation(145, 9);
			// MathLang.g:145:9: ( '0' .. '9' )+
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
					// MathLang.g:145:10: '0' .. '9'
					{
					DebugLocation(145, 10);
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
			TraceOut("NUMBER", 33);
			LeaveRule("NUMBER", 33);
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
		EnterRule("ADD", 34);
		TraceIn("ADD", 34);
		try
		{
			int _type = ADD;
			int _channel = DefaultTokenChannel;
			// MathLang.g:146:4: ( '+' )
			DebugEnterAlt(1);
			// MathLang.g:146:9: '+'
			{
			DebugLocation(146, 9);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ADD", 34);
			LeaveRule("ADD", 34);
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
		EnterRule("SUB", 35);
		TraceIn("SUB", 35);
		try
		{
			int _type = SUB;
			int _channel = DefaultTokenChannel;
			// MathLang.g:147:4: ( '-' )
			DebugEnterAlt(1);
			// MathLang.g:147:9: '-'
			{
			DebugLocation(147, 9);
			Match('-'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SUB", 35);
			LeaveRule("SUB", 35);
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
		EnterRule("MUL", 36);
		TraceIn("MUL", 36);
		try
		{
			int _type = MUL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:148:4: ( '*' )
			DebugEnterAlt(1);
			// MathLang.g:148:9: '*'
			{
			DebugLocation(148, 9);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MUL", 36);
			LeaveRule("MUL", 36);
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
		EnterRule("DIV", 37);
		TraceIn("DIV", 37);
		try
		{
			int _type = DIV;
			int _channel = DefaultTokenChannel;
			// MathLang.g:149:4: ( '/' )
			DebugEnterAlt(1);
			// MathLang.g:149:9: '/'
			{
			DebugLocation(149, 9);
			Match('/'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DIV", 37);
			LeaveRule("DIV", 37);
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
		EnterRule("ASSIGN", 38);
		TraceIn("ASSIGN", 38);
		try
		{
			int _type = ASSIGN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:150:7: ( '=' )
			DebugEnterAlt(1);
			// MathLang.g:150:9: '='
			{
			DebugLocation(150, 9);
			Match('='); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ASSIGN", 38);
			LeaveRule("ASSIGN", 38);
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
		EnterRule("RETURN", 39);
		TraceIn("RETURN", 39);
		try
		{
			int _type = RETURN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:151:7: ( 'return' )
			DebugEnterAlt(1);
			// MathLang.g:151:9: 'return'
			{
			DebugLocation(151, 9);
			Match("return"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RETURN", 39);
			LeaveRule("RETURN", 39);
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
		EnterRule("TRUE", 40);
		TraceIn("TRUE", 40);
		try
		{
			int _type = TRUE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:152:5: ( 'true' )
			DebugEnterAlt(1);
			// MathLang.g:152:9: 'true'
			{
			DebugLocation(152, 9);
			Match("true"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TRUE", 40);
			LeaveRule("TRUE", 40);
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
		EnterRule("FALSE", 41);
		TraceIn("FALSE", 41);
		try
		{
			int _type = FALSE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:153:6: ( 'false' )
			DebugEnterAlt(1);
			// MathLang.g:153:9: 'false'
			{
			DebugLocation(153, 9);
			Match("false"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FALSE", 41);
			LeaveRule("FALSE", 41);
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
		EnterRule("EQ", 42);
		TraceIn("EQ", 42);
		try
		{
			int _type = EQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:154:3: ( '==' )
			DebugEnterAlt(1);
			// MathLang.g:154:6: '=='
			{
			DebugLocation(154, 6);
			Match("=="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EQ", 42);
			LeaveRule("EQ", 42);
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
		EnterRule("NEQ", 43);
		TraceIn("NEQ", 43);
		try
		{
			int _type = NEQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:155:4: ( '!=' )
			DebugEnterAlt(1);
			// MathLang.g:155:6: '!='
			{
			DebugLocation(155, 6);
			Match("!="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NEQ", 43);
			LeaveRule("NEQ", 43);
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
		EnterRule("GR", 44);
		TraceIn("GR", 44);
		try
		{
			int _type = GR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:156:3: ( '>' )
			DebugEnterAlt(1);
			// MathLang.g:156:6: '>'
			{
			DebugLocation(156, 6);
			Match('>'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GR", 44);
			LeaveRule("GR", 44);
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
		EnterRule("GREQ", 45);
		TraceIn("GREQ", 45);
		try
		{
			int _type = GREQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:157:5: ( '>=' )
			DebugEnterAlt(1);
			// MathLang.g:157:9: '>='
			{
			DebugLocation(157, 9);
			Match(">="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GREQ", 45);
			LeaveRule("GREQ", 45);
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
		EnterRule("LS", 46);
		TraceIn("LS", 46);
		try
		{
			int _type = LS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:158:3: ( '<' )
			DebugEnterAlt(1);
			// MathLang.g:158:6: '<'
			{
			DebugLocation(158, 6);
			Match('<'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LS", 46);
			LeaveRule("LS", 46);
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
		EnterRule("LSEQ", 47);
		TraceIn("LSEQ", 47);
		try
		{
			int _type = LSEQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:159:5: ( '<=' )
			DebugEnterAlt(1);
			// MathLang.g:159:7: '<='
			{
			DebugLocation(159, 7);
			Match("<="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LSEQ", 47);
			LeaveRule("LSEQ", 47);
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
		EnterRule("NOT", 48);
		TraceIn("NOT", 48);
		try
		{
			int _type = NOT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:160:4: ( '!' )
			DebugEnterAlt(1);
			// MathLang.g:160:6: '!'
			{
			DebugLocation(160, 6);
			Match('!'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NOT", 48);
			LeaveRule("NOT", 48);
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
		EnterRule("OR", 49);
		TraceIn("OR", 49);
		try
		{
			int _type = OR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:161:3: ( '||' )
			DebugEnterAlt(1);
			// MathLang.g:161:6: '||'
			{
			DebugLocation(161, 6);
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
			// MathLang.g:162:4: ( '&&' )
			DebugEnterAlt(1);
			// MathLang.g:162:6: '&&'
			{
			DebugLocation(162, 6);
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
			// MathLang.g:163:3: ( ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+ )
			DebugEnterAlt(1);
			// MathLang.g:164:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			{
			DebugLocation(164, 3);
			// MathLang.g:164:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
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
					DebugLocation(164, 3);
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

			DebugLocation(164, 41);

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
			// MathLang.g:168:5: ( '\\'' ( 'a' .. 'z' ) '\\'' )
			DebugEnterAlt(1);
			// MathLang.g:168:8: '\\'' ( 'a' .. 'z' ) '\\''
			{
			DebugLocation(168, 8);
			Match('\''); 
			DebugLocation(168, 12);
			// MathLang.g:168:12: ( 'a' .. 'z' )
			DebugEnterAlt(1);
			// MathLang.g:168:13: 'a' .. 'z'
			{
			DebugLocation(168, 13);
			MatchRange('a','z'); 

			}

			DebugLocation(168, 22);
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
			// MathLang.g:169:3: ( ( 'a' .. 'z' )+ )
			DebugEnterAlt(1);
			// MathLang.g:169:6: ( 'a' .. 'z' )+
			{
			DebugLocation(169, 6);
			// MathLang.g:169:6: ( 'a' .. 'z' )+
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
					// MathLang.g:169:7: 'a' .. 'z'
					{
					DebugLocation(169, 7);
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
			// MathLang.g:173:11: ( '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n' )
			DebugEnterAlt(1);
			// MathLang.g:174:3: '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n'
			{
			DebugLocation(174, 3);
			Match("//"); 

			DebugLocation(174, 8);
			// MathLang.g:174:8: ( options {greedy=false; } : . )*
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
					// MathLang.g:174:36: .
					{
					DebugLocation(174, 36);
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

			DebugLocation(174, 40);
			// MathLang.g:174:40: ( '\\r' )?
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
				// MathLang.g:174:40: '\\r'
				{
				DebugLocation(174, 40);
				Match('\r'); 

				}
				break;

			}
			} finally { DebugExitSubRule(6); }

			DebugLocation(174, 46);
			Match('\n'); 
			DebugLocation(174, 51);

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
			// MathLang.g:178:11: ( '/*' ( options {greedy=false; } : . )* '*/' )
			DebugEnterAlt(1);
			// MathLang.g:179:3: '/*' ( options {greedy=false; } : . )* '*/'
			{
			DebugLocation(179, 3);
			Match("/*"); 

			DebugLocation(179, 8);
			// MathLang.g:179:8: ( options {greedy=false; } : . )*
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
					// MathLang.g:179:36: .
					{
					DebugLocation(179, 36);
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

			DebugLocation(179, 40);
			Match("*/"); 

			DebugLocation(179, 45);

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
		// MathLang.g:1:8: ( PRINT | INPUT | IF | ELSE | FOR | FUNCTION | WHILE | DO | VARDECLARATION | FUNCDECLARATION | ARRAYDECLARATION | VARASSIGNMENT | ARRAYELEMENTASSIGNMENT | ARRAYELEMENT | NEWVAR | ARRAY_INITIALIZER | OBJECT_INITIALIZER | FUNC_CALL | RETURN_TYPE | PARAMETERS | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | KNEW | ARRAY_DECLARATION_MARK | SQRBL | SQRBR | TYPE | VOID | NUMBER | ADD | SUB | MUL | DIV | ASSIGN | RETURN | TRUE | FALSE | EQ | NEQ | GR | GREQ | LS | LSEQ | NOT | OR | AND | WS | CHAR | ID | SL_COMMENT | ML_COMMENT )
		int alt8=55;
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
			// MathLang.g:1:227: T__57
			{
			DebugLocation(1, 227);
			mT__57(); 

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// MathLang.g:1:233: T__58
			{
			DebugLocation(1, 233);
			mT__58(); 

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// MathLang.g:1:239: T__59
			{
			DebugLocation(1, 239);
			mT__59(); 

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// MathLang.g:1:245: T__60
			{
			DebugLocation(1, 245);
			mT__60(); 

			}
			break;
		case 25:
			DebugEnterAlt(25);
			// MathLang.g:1:251: T__61
			{
			DebugLocation(1, 251);
			mT__61(); 

			}
			break;
		case 26:
			DebugEnterAlt(26);
			// MathLang.g:1:257: T__62
			{
			DebugLocation(1, 257);
			mT__62(); 

			}
			break;
		case 27:
			DebugEnterAlt(27);
			// MathLang.g:1:263: KNEW
			{
			DebugLocation(1, 263);
			mKNEW(); 

			}
			break;
		case 28:
			DebugEnterAlt(28);
			// MathLang.g:1:268: ARRAY_DECLARATION_MARK
			{
			DebugLocation(1, 268);
			mARRAY_DECLARATION_MARK(); 

			}
			break;
		case 29:
			DebugEnterAlt(29);
			// MathLang.g:1:291: SQRBL
			{
			DebugLocation(1, 291);
			mSQRBL(); 

			}
			break;
		case 30:
			DebugEnterAlt(30);
			// MathLang.g:1:297: SQRBR
			{
			DebugLocation(1, 297);
			mSQRBR(); 

			}
			break;
		case 31:
			DebugEnterAlt(31);
			// MathLang.g:1:303: TYPE
			{
			DebugLocation(1, 303);
			mTYPE(); 

			}
			break;
		case 32:
			DebugEnterAlt(32);
			// MathLang.g:1:308: VOID
			{
			DebugLocation(1, 308);
			mVOID(); 

			}
			break;
		case 33:
			DebugEnterAlt(33);
			// MathLang.g:1:313: NUMBER
			{
			DebugLocation(1, 313);
			mNUMBER(); 

			}
			break;
		case 34:
			DebugEnterAlt(34);
			// MathLang.g:1:320: ADD
			{
			DebugLocation(1, 320);
			mADD(); 

			}
			break;
		case 35:
			DebugEnterAlt(35);
			// MathLang.g:1:324: SUB
			{
			DebugLocation(1, 324);
			mSUB(); 

			}
			break;
		case 36:
			DebugEnterAlt(36);
			// MathLang.g:1:328: MUL
			{
			DebugLocation(1, 328);
			mMUL(); 

			}
			break;
		case 37:
			DebugEnterAlt(37);
			// MathLang.g:1:332: DIV
			{
			DebugLocation(1, 332);
			mDIV(); 

			}
			break;
		case 38:
			DebugEnterAlt(38);
			// MathLang.g:1:336: ASSIGN
			{
			DebugLocation(1, 336);
			mASSIGN(); 

			}
			break;
		case 39:
			DebugEnterAlt(39);
			// MathLang.g:1:343: RETURN
			{
			DebugLocation(1, 343);
			mRETURN(); 

			}
			break;
		case 40:
			DebugEnterAlt(40);
			// MathLang.g:1:350: TRUE
			{
			DebugLocation(1, 350);
			mTRUE(); 

			}
			break;
		case 41:
			DebugEnterAlt(41);
			// MathLang.g:1:355: FALSE
			{
			DebugLocation(1, 355);
			mFALSE(); 

			}
			break;
		case 42:
			DebugEnterAlt(42);
			// MathLang.g:1:361: EQ
			{
			DebugLocation(1, 361);
			mEQ(); 

			}
			break;
		case 43:
			DebugEnterAlt(43);
			// MathLang.g:1:364: NEQ
			{
			DebugLocation(1, 364);
			mNEQ(); 

			}
			break;
		case 44:
			DebugEnterAlt(44);
			// MathLang.g:1:368: GR
			{
			DebugLocation(1, 368);
			mGR(); 

			}
			break;
		case 45:
			DebugEnterAlt(45);
			// MathLang.g:1:371: GREQ
			{
			DebugLocation(1, 371);
			mGREQ(); 

			}
			break;
		case 46:
			DebugEnterAlt(46);
			// MathLang.g:1:376: LS
			{
			DebugLocation(1, 376);
			mLS(); 

			}
			break;
		case 47:
			DebugEnterAlt(47);
			// MathLang.g:1:379: LSEQ
			{
			DebugLocation(1, 379);
			mLSEQ(); 

			}
			break;
		case 48:
			DebugEnterAlt(48);
			// MathLang.g:1:384: NOT
			{
			DebugLocation(1, 384);
			mNOT(); 

			}
			break;
		case 49:
			DebugEnterAlt(49);
			// MathLang.g:1:388: OR
			{
			DebugLocation(1, 388);
			mOR(); 

			}
			break;
		case 50:
			DebugEnterAlt(50);
			// MathLang.g:1:391: AND
			{
			DebugLocation(1, 391);
			mAND(); 

			}
			break;
		case 51:
			DebugEnterAlt(51);
			// MathLang.g:1:395: WS
			{
			DebugLocation(1, 395);
			mWS(); 

			}
			break;
		case 52:
			DebugEnterAlt(52);
			// MathLang.g:1:398: CHAR
			{
			DebugLocation(1, 398);
			mCHAR(); 

			}
			break;
		case 53:
			DebugEnterAlt(53);
			// MathLang.g:1:403: ID
			{
			DebugLocation(1, 403);
			mID(); 

			}
			break;
		case 54:
			DebugEnterAlt(54);
			// MathLang.g:1:406: SL_COMMENT
			{
			DebugLocation(1, 406);
			mSL_COMMENT(); 

			}
			break;
		case 55:
			DebugEnterAlt(55);
			// MathLang.g:1:417: ML_COMMENT
			{
			DebugLocation(1, 417);
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
			"\x1\xFFFF\xB\x24\x6\xFFFF\x1\x35\x1\xFFFF\x2\x24\x4\xFFFF\x1\x3B\x1"+
			"\x3D\x1\x24\x1\x40\x1\x42\x1\x44\x5\xFFFF\x3\x24\x1\x49\x5\x24\x1\x4F"+
			"\x6\x24\x2\xFFFF\x2\x24\x5\xFFFF\x1\x24\x6\xFFFF\x3\x24\x1\x5C\x1\xFFFF"+
			"\x1\x24\x1\x5E\x3\x24\x1\xFFFF\x3\x24\x1\x67\x8\x24\x1\xFFFF\x1\x70\x1"+
			"\xFFFF\x5\x24\x1\x78\x2\x24\x1\xFFFF\x2\x24\x2\x5C\x1\x7D\x1\x7E\x1\x24"+
			"\x1\x80\x1\xFFFF\x2\x24\x1\xFFFF\x1\x83\x1\x84\x2\x24\x1\xFFFF\x4\x24"+
			"\x2\xFFFF\x1\x24\x1\xFFFF\x2\x24\x2\xFFFF\x4\x24\x1\xFFFF\x1\x94\x1\x24"+
			"\x1\x97\x7\x24\x4\xFFFF\x1\x24\x1\xA0\x6\x24\x1\xFFFF\x5\x24\x1\xAC\x5"+
			"\x24\x1\xFFFF\x9\x24\x1\xBC\x2\x24\x1\xBF\x2\x24\x1\xFFFF\x1\x24\x1\xC3"+
			"\x1\xFFFF\x2\x24\x1\xC6\x1\xFFFF\x2\x24\x1\xFFFF\x1\xC9\x1\x24\x1\xFFFF"+
			"\x5\x24\x1\xD0\x1\xFFFF";
		private const string DFA8_eofS =
			"\xD1\xFFFF";
		private const string DFA8_minS =
			"\x1\x9\x1\x61\x1\x66\x1\x6C\x1\x61\x1\x68\x1\x6F\x1\x61\x1\x72\x1\x65"+
			"\x1\x62\x1\x65\x6\xFFFF\x1\x5D\x1\xFFFF\x1\x6F\x1\x68\x4\xFFFF\x1\x2A"+
			"\x1\x3D\x1\x72\x3\x3D\x5\xFFFF\x1\x69\x1\x72\x1\x70\x1\x61\x1\x73\x1"+
			"\x72\x1\x6E\x1\x6C\x1\x69\x1\x61\x1\x72\x1\x69\x1\x72\x1\x77\x1\x6A\x1"+
			"\x74\x2\xFFFF\x1\x6F\x1\x61\x5\xFFFF\x1\x75\x6\xFFFF\x1\x6E\x1\x61\x1"+
			"\x75\x1\x61\x1\xFFFF\x1\x65\x1\x61\x1\x63\x1\x73\x1\x6C\x1\xFFFF\x1\x61"+
			"\x1\x64\x2\x61\x1\x65\x1\x75\x1\x6C\x1\x72\x1\x65\x1\x74\x1\x6D\x1\x74"+
			"\x1\xFFFF\x1\x61\x1\xFFFF\x1\x5F\x3\x65\x1\x73\x1\x61\x1\x79\x1\x61\x1"+
			"\xFFFF\x1\x63\x1\x72\x4\x61\x1\x65\x1\x61\x1\xFFFF\x1\x69\x1\x65\x1\xFFFF"+
			"\x2\x61\x1\x63\x1\x73\x1\xFFFF\x1\x5F\x1\x72\x1\x74\x1\x6E\x2\xFFFF\x1"+
			"\x74\x1\xFFFF\x1\x6F\x1\x63\x2\xFFFF\x1\x6C\x1\x69\x1\x65\x1\x6C\x1\xFFFF"+
			"\x1\x61\x2\x5F\x1\x65\x1\x6E\x1\x6C\x1\x61\x1\x67\x1\x63\x1\x65\x4\xFFFF"+
			"\x1\x72\x2\x61\x1\x72\x1\x6E\x1\x6C\x1\x6D\x1\x73\x1\xFFFF\x1\x72\x1"+
			"\x61\x1\x6D\x1\x61\x1\x65\x2\x61\x1\x74\x1\x65\x1\x72\x1\x6E\x1\xFFFF"+
			"\x1\x74\x1\x69\x1\x6E\x1\x61\x1\x74\x1\x69\x1\x6F\x2\x74\x1\x61\x1\x6F"+
			"\x1\x6E\x1\x61\x1\x69\x1\x73\x1\xFFFF\x1\x6E\x1\x61\x1\xFFFF\x1\x6F\x1"+
			"\x73\x1\x61\x1\xFFFF\x1\x6E\x1\x69\x1\xFFFF\x1\x61\x1\x67\x1\xFFFF\x1"+
			"\x6E\x1\x6D\x1\x65\x1\x6E\x1\x74\x1\x61\x1\xFFFF";
		private const string DFA8_maxS =
			"\x1\x7D\x1\x72\x1\x6E\x1\x6C\x1\x75\x1\x68\x2\x6F\x1\x72\x1\x65\x1\x62"+
			"\x1\x65\x6\xFFFF\x1\x5D\x1\xFFFF\x1\x6F\x1\x68\x4\xFFFF\x1\x2F\x1\x3D"+
			"\x1\x72\x3\x3D\x5\xFFFF\x1\x69\x1\x72\x1\x74\x1\x7A\x1\x73\x1\x72\x1"+
			"\x6E\x1\x6C\x1\x69\x1\x7A\x1\x72\x1\x69\x1\x72\x1\x77\x1\x6A\x1\x74\x2"+
			"\xFFFF\x1\x6F\x1\x61\x5\xFFFF\x1\x75\x6\xFFFF\x1\x6E\x1\x61\x1\x75\x1"+
			"\x7A\x1\xFFFF\x1\x65\x1\x7A\x1\x63\x1\x73\x1\x6C\x1\xFFFF\x2\x64\x1\x61"+
			"\x1\x7A\x1\x65\x1\x75\x1\x6C\x1\x72\x1\x65\x1\x74\x1\x6D\x1\x74\x1\xFFFF"+
			"\x1\x7A\x1\xFFFF\x1\x74\x3\x65\x1\x73\x1\x7A\x1\x79\x1\x61\x1\xFFFF\x1"+
			"\x63\x1\x72\x4\x7A\x1\x65\x1\x7A\x1\xFFFF\x1\x69\x1\x65\x1\xFFFF\x2\x7A"+
			"\x1\x63\x1\x73\x1\xFFFF\x1\x65\x1\x72\x1\x74\x1\x6E\x2\xFFFF\x1\x74\x1"+
			"\xFFFF\x1\x6F\x1\x63\x2\xFFFF\x1\x6C\x1\x69\x1\x65\x1\x6C\x1\xFFFF\x1"+
			"\x7A\x1\x5F\x1\x7A\x1\x65\x1\x6E\x1\x6C\x1\x61\x1\x67\x1\x63\x1\x65\x4"+
			"\xFFFF\x1\x72\x1\x7A\x1\x61\x1\x72\x1\x6E\x1\x6C\x1\x6D\x1\x73\x1\xFFFF"+
			"\x1\x72\x1\x61\x1\x6D\x1\x61\x1\x65\x1\x7A\x1\x61\x1\x74\x1\x65\x1\x72"+
			"\x1\x6E\x1\xFFFF\x1\x74\x1\x69\x1\x6E\x1\x61\x1\x74\x1\x69\x1\x6F\x2"+
			"\x74\x1\x7A\x1\x6F\x1\x6E\x1\x7A\x1\x69\x1\x73\x1\xFFFF\x1\x6E\x1\x7A"+
			"\x1\xFFFF\x1\x6F\x1\x73\x1\x7A\x1\xFFFF\x1\x6E\x1\x69\x1\xFFFF\x1\x7A"+
			"\x1\x67\x1\xFFFF\x1\x6E\x1\x6D\x1\x65\x1\x6E\x1\x74\x1\x7A\x1\xFFFF";
		private const string DFA8_acceptS =
			"\xC\xFFFF\x1\x15\x1\x16\x1\x17\x1\x18\x1\x19\x1\x1A\x1\xFFFF\x1\x1E"+
			"\x2\xFFFF\x1\x21\x1\x22\x1\x23\x1\x24\x6\xFFFF\x1\x31\x1\x32\x1\x33\x1"+
			"\x34\x1\x35\x10\xFFFF\x1\x1D\x1\x1C\x2\xFFFF\x1\x36\x1\x37\x1\x25\x1"+
			"\x2A\x1\x26\x1\xFFFF\x1\x2B\x1\x30\x1\x2D\x1\x2C\x1\x2F\x1\x2E\x4\xFFFF"+
			"\x1\x3\x5\xFFFF\x1\x8\xC\xFFFF\x1\x1F\x1\xFFFF\x1\x5\x8\xFFFF\x1\x1B"+
			"\x8\xFFFF\x1\x4\x2\xFFFF\x1\x12\x4\xFFFF\x1\x20\x4\xFFFF\x1\x28\x1\x1"+
			"\x1\xFFFF\x1\x2\x2\xFFFF\x1\x29\x1\x7\x4\xFFFF\x1\x10\xA\xFFFF\x1\xF"+
			"\x1\x11\x1\x13\x1\x27\x8\xFFFF\x1\x6\xB\xFFFF\x1\x14\xF\xFFFF\x1\xE\x2"+
			"\xFFFF\x1\xC\x3\xFFFF\x1\x9\x2\xFFFF\x1\xA\x2\xFFFF\x1\xB\x6\xFFFF\x1"+
			"\xD";
		private const string DFA8_specialS =
			"\xD1\xFFFF}>";
		private static readonly string[] DFA8_transitionS =
			{
				"\x2\x22\x1\xFFFF\x2\x22\x12\xFFFF\x1\x22\x1\x1D\x4\xFFFF\x1\x21\x1"+
				"\x23\x1\xD\x1\xE\x1\x19\x1\x17\x1\xF\x1\x18\x1\xFFFF\x1\x1A\xA\x16\x1"+
				"\xFFFF\x1\xC\x1\x1F\x1\x1B\x1\x1E\x1C\xFFFF\x1\x12\x1\xFFFF\x1\x13\x3"+
				"\xFFFF\x1\x8\x1\x14\x1\x15\x1\x6\x1\x3\x1\x4\x2\x24\x1\x2\x4\x24\x1"+
				"\x9\x1\xA\x1\x1\x1\x24\x1\xB\x1\x24\x1\x1C\x1\x24\x1\x7\x1\x5\x3\x24"+
				"\x1\x10\x1\x20\x1\x11",
				"\x1\x26\x10\xFFFF\x1\x25",
				"\x1\x28\x7\xFFFF\x1\x27",
				"\x1\x29",
				"\x1\x2C\xD\xFFFF\x1\x2A\x5\xFFFF\x1\x2B",
				"\x1\x2D",
				"\x1\x2E",
				"\x1\x2F\xD\xFFFF\x1\x30",
				"\x1\x31",
				"\x1\x32",
				"\x1\x33",
				"\x1\x34",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x36",
				"",
				"\x1\x37",
				"\x1\x38",
				"",
				"",
				"",
				"",
				"\x1\x3A\x4\xFFFF\x1\x39",
				"\x1\x3C",
				"\x1\x3E",
				"\x1\x3F",
				"\x1\x41",
				"\x1\x43",
				"",
				"",
				"",
				"",
				"",
				"\x1\x45",
				"\x1\x46",
				"\x1\x47\x3\xFFFF\x1\x48",
				"\x1A\x24",
				"\x1\x4A",
				"\x1\x4B",
				"\x1\x4C",
				"\x1\x4D",
				"\x1\x4E",
				"\x1A\x24",
				"\x1\x50",
				"\x1\x51",
				"\x1\x52",
				"\x1\x53",
				"\x1\x54",
				"\x1\x55",
				"",
				"",
				"\x1\x56",
				"\x1\x57",
				"",
				"",
				"",
				"",
				"",
				"\x1\x58",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x59",
				"\x1\x5A",
				"\x1\x5B",
				"\x1A\x24",
				"",
				"\x1\x5D",
				"\x1A\x24",
				"\x1\x5F",
				"\x1\x60",
				"\x1\x61",
				"",
				"\x1\x63\x2\xFFFF\x1\x62",
				"\x1\x64",
				"\x1\x65",
				"\x15\x24\x1\x66\x4\x24",
				"\x1\x68",
				"\x1\x69",
				"\x1\x6A",
				"\x1\x6B",
				"\x1\x6C",
				"\x1\x6D",
				"\x1\x6E",
				"\x1\x6F",
				"",
				"\x1A\x24",
				"",
				"\x1\x73\x4\xFFFF\x1\x72\xF\xFFFF\x1\x71",
				"\x1\x74",
				"\x1\x75",
				"\x1\x76",
				"\x1\x77",
				"\x1A\x24",
				"\x1\x79",
				"\x1\x7A",
				"",
				"\x1\x7B",
				"\x1\x7C",
				"\x1A\x24",
				"\x1A\x24",
				"\x1A\x24",
				"\x1A\x24",
				"\x1\x7F",
				"\x1A\x24",
				"",
				"\x1\x81",
				"\x1\x82",
				"",
				"\x1A\x24",
				"\x1A\x24",
				"\x1\x85",
				"\x1\x86",
				"",
				"\x1\x89\x4\xFFFF\x1\x87\x1\x88",
				"\x1\x8A",
				"\x1\x8B",
				"\x1\x8C",
				"",
				"",
				"\x1\x8D",
				"",
				"\x1\x8E",
				"\x1\x8F",
				"",
				"",
				"\x1\x90",
				"\x1\x91",
				"\x1\x92",
				"\x1\x93",
				"",
				"\x1A\x24",
				"\x1\x95",
				"\x1\x96\x1\xFFFF\x1A\x24",
				"\x1\x98",
				"\x1\x99",
				"\x1\x9A",
				"\x1\x9B",
				"\x1\x9C",
				"\x1\x9D",
				"\x1\x9E",
				"",
				"",
				"",
				"",
				"\x1\x9F",
				"\x1A\x24",
				"\x1\xA1",
				"\x1\xA2",
				"\x1\xA3",
				"\x1\xA4",
				"\x1\xA5",
				"\x1\xA6",
				"",
				"\x1\xA7",
				"\x1\xA8",
				"\x1\xA9",
				"\x1\xAA",
				"\x1\xAB",
				"\x1A\x24",
				"\x1\xAD",
				"\x1\xAE",
				"\x1\xAF",
				"\x1\xB0",
				"\x1\xB1",
				"",
				"\x1\xB2",
				"\x1\xB3",
				"\x1\xB4",
				"\x1\xB5",
				"\x1\xB6",
				"\x1\xB7",
				"\x1\xB8",
				"\x1\xB9",
				"\x1\xBA",
				"\x1\xBB\x19\x24",
				"\x1\xBD",
				"\x1\xBE",
				"\x1A\x24",
				"\x1\xC0",
				"\x1\xC1",
				"",
				"\x1\xC2",
				"\x1A\x24",
				"",
				"\x1\xC4",
				"\x1\xC5",
				"\x1A\x24",
				"",
				"\x1\xC7",
				"\x1\xC8",
				"",
				"\x1A\x24",
				"\x1\xCA",
				"",
				"\x1\xCB",
				"\x1\xCC",
				"\x1\xCD",
				"\x1\xCE",
				"\x1\xCF",
				"\x1A\x24",
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

		public override string Description { get { return "1:1: Tokens : ( PRINT | INPUT | IF | ELSE | FOR | FUNCTION | WHILE | DO | VARDECLARATION | FUNCDECLARATION | ARRAYDECLARATION | VARASSIGNMENT | ARRAYELEMENTASSIGNMENT | ARRAYELEMENT | NEWVAR | ARRAY_INITIALIZER | OBJECT_INITIALIZER | FUNC_CALL | RETURN_TYPE | PARAMETERS | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | KNEW | ARRAY_DECLARATION_MARK | SQRBL | SQRBR | TYPE | VOID | NUMBER | ADD | SUB | MUL | DIV | ASSIGN | RETURN | TRUE | FALSE | EQ | NEQ | GR | GREQ | LS | LSEQ | NOT | OR | AND | WS | CHAR | ID | SL_COMMENT | ML_COMMENT );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}

} // namespace  MathLang 

// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-10-04 17:57:44

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
	public const int T__53=53;
	public const int T__54=54;
	public const int T__55=55;
	public const int T__56=56;
	public const int T__57=57;
	public const int T__58=58;
	public const int T__59=59;
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
	public const int VARASSIGNMENT=18;
	public const int ARRAYELEMENTASSIGNMENT=19;
	public const int ARRAYELEMENT=20;
	public const int NEWWORD=21;
	public const int NEWVAR=22;
	public const int NUMBER=23;
	public const int ID=24;
	public const int CHAR=25;
	public const int TYPE=26;
	public const int TYPE0=27;
	public const int ASSIGN=28;
	public const int ADD=29;
	public const int SUB=30;
	public const int MUL=31;
	public const int DIV=32;
	public const int GREQ=33;
	public const int LSEQ=34;
	public const int NEQ=35;
	public const int EQ=36;
	public const int GR=37;
	public const int LS=38;
	public const int OR=39;
	public const int AND=40;
	public const int NOT=41;
	public const int TRUE=42;
	public const int FALSE=43;
	public const int KNEW=44;
	public const int SQRBL=45;
	public const int SQRBR=46;
	public const int ACCESS_MODIFIER=47;
	public const int RETURNS=48;
	public const int PARAMETERS=49;
	public const int WS=50;
	public const int SL_COMMENT=51;
	public const int ML_COMMENT=52;

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

	partial void Enter_VARASSIGNMENT();
	partial void Leave_VARASSIGNMENT();

	// $ANTLR start "VARASSIGNMENT"
	[GrammarRule("VARASSIGNMENT")]
	private void mVARASSIGNMENT()
	{
		Enter_VARASSIGNMENT();
		EnterRule("VARASSIGNMENT", 10);
		TraceIn("VARASSIGNMENT", 10);
		try
		{
			int _type = VARASSIGNMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:18:15: ( 'varassignment' )
			DebugEnterAlt(1);
			// MathLang.g:18:17: 'varassignment'
			{
			DebugLocation(18, 17);
			Match("varassignment"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("VARASSIGNMENT", 10);
			LeaveRule("VARASSIGNMENT", 10);
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
		EnterRule("ARRAYELEMENTASSIGNMENT", 11);
		TraceIn("ARRAYELEMENTASSIGNMENT", 11);
		try
		{
			int _type = ARRAYELEMENTASSIGNMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:19:24: ( 'arrayelementassignment' )
			DebugEnterAlt(1);
			// MathLang.g:19:26: 'arrayelementassignment'
			{
			DebugLocation(19, 26);
			Match("arrayelementassignment"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ARRAYELEMENTASSIGNMENT", 11);
			LeaveRule("ARRAYELEMENTASSIGNMENT", 11);
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
		EnterRule("ARRAYELEMENT", 12);
		TraceIn("ARRAYELEMENT", 12);
		try
		{
			int _type = ARRAYELEMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:20:14: ( 'arrayelement' )
			DebugEnterAlt(1);
			// MathLang.g:20:16: 'arrayelement'
			{
			DebugLocation(20, 16);
			Match("arrayelement"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ARRAYELEMENT", 12);
			LeaveRule("ARRAYELEMENT", 12);
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
		EnterRule("NEWWORD", 13);
		TraceIn("NEWWORD", 13);
		try
		{
			int _type = NEWWORD;
			int _channel = DefaultTokenChannel;
			// MathLang.g:21:9: ( 'newword' )
			DebugEnterAlt(1);
			// MathLang.g:21:11: 'newword'
			{
			DebugLocation(21, 11);
			Match("newword"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NEWWORD", 13);
			LeaveRule("NEWWORD", 13);
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
		EnterRule("NEWVAR", 14);
		TraceIn("NEWVAR", 14);
		try
		{
			int _type = NEWVAR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:22:8: ( 'newvar' )
			DebugEnterAlt(1);
			// MathLang.g:22:10: 'newvar'
			{
			DebugLocation(22, 10);
			Match("newvar"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NEWVAR", 14);
			LeaveRule("NEWVAR", 14);
			Leave_NEWVAR();
		}
	}
	// $ANTLR end "NEWVAR"

	partial void Enter_T__53();
	partial void Leave_T__53();

	// $ANTLR start "T__53"
	[GrammarRule("T__53")]
	private void mT__53()
	{
		Enter_T__53();
		EnterRule("T__53", 15);
		TraceIn("T__53", 15);
		try
		{
			int _type = T__53;
			int _channel = DefaultTokenChannel;
			// MathLang.g:23:7: ( ';' )
			DebugEnterAlt(1);
			// MathLang.g:23:9: ';'
			{
			DebugLocation(23, 9);
			Match(';'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__53", 15);
			LeaveRule("T__53", 15);
			Leave_T__53();
		}
	}
	// $ANTLR end "T__53"

	partial void Enter_T__54();
	partial void Leave_T__54();

	// $ANTLR start "T__54"
	[GrammarRule("T__54")]
	private void mT__54()
	{
		Enter_T__54();
		EnterRule("T__54", 16);
		TraceIn("T__54", 16);
		try
		{
			int _type = T__54;
			int _channel = DefaultTokenChannel;
			// MathLang.g:24:7: ( '(' )
			DebugEnterAlt(1);
			// MathLang.g:24:9: '('
			{
			DebugLocation(24, 9);
			Match('('); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__54", 16);
			LeaveRule("T__54", 16);
			Leave_T__54();
		}
	}
	// $ANTLR end "T__54"

	partial void Enter_T__55();
	partial void Leave_T__55();

	// $ANTLR start "T__55"
	[GrammarRule("T__55")]
	private void mT__55()
	{
		Enter_T__55();
		EnterRule("T__55", 17);
		TraceIn("T__55", 17);
		try
		{
			int _type = T__55;
			int _channel = DefaultTokenChannel;
			// MathLang.g:25:7: ( ')' )
			DebugEnterAlt(1);
			// MathLang.g:25:9: ')'
			{
			DebugLocation(25, 9);
			Match(')'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__55", 17);
			LeaveRule("T__55", 17);
			Leave_T__55();
		}
	}
	// $ANTLR end "T__55"

	partial void Enter_T__56();
	partial void Leave_T__56();

	// $ANTLR start "T__56"
	[GrammarRule("T__56")]
	private void mT__56()
	{
		Enter_T__56();
		EnterRule("T__56", 18);
		TraceIn("T__56", 18);
		try
		{
			int _type = T__56;
			int _channel = DefaultTokenChannel;
			// MathLang.g:26:7: ( ',' )
			DebugEnterAlt(1);
			// MathLang.g:26:9: ','
			{
			DebugLocation(26, 9);
			Match(','); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__56", 18);
			LeaveRule("T__56", 18);
			Leave_T__56();
		}
	}
	// $ANTLR end "T__56"

	partial void Enter_T__57();
	partial void Leave_T__57();

	// $ANTLR start "T__57"
	[GrammarRule("T__57")]
	private void mT__57()
	{
		Enter_T__57();
		EnterRule("T__57", 19);
		TraceIn("T__57", 19);
		try
		{
			int _type = T__57;
			int _channel = DefaultTokenChannel;
			// MathLang.g:27:7: ( '()' )
			DebugEnterAlt(1);
			// MathLang.g:27:9: '()'
			{
			DebugLocation(27, 9);
			Match("()"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__57", 19);
			LeaveRule("T__57", 19);
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
		EnterRule("T__58", 20);
		TraceIn("T__58", 20);
		try
		{
			int _type = T__58;
			int _channel = DefaultTokenChannel;
			// MathLang.g:28:7: ( '{' )
			DebugEnterAlt(1);
			// MathLang.g:28:9: '{'
			{
			DebugLocation(28, 9);
			Match('{'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__58", 20);
			LeaveRule("T__58", 20);
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
		EnterRule("T__59", 21);
		TraceIn("T__59", 21);
		try
		{
			int _type = T__59;
			int _channel = DefaultTokenChannel;
			// MathLang.g:29:7: ( '}' )
			DebugEnterAlt(1);
			// MathLang.g:29:9: '}'
			{
			DebugLocation(29, 9);
			Match('}'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__59", 21);
			LeaveRule("T__59", 21);
			Leave_T__59();
		}
	}
	// $ANTLR end "T__59"

	partial void Enter_KNEW();
	partial void Leave_KNEW();

	// $ANTLR start "KNEW"
	[GrammarRule("KNEW")]
	private void mKNEW()
	{
		Enter_KNEW();
		EnterRule("KNEW", 22);
		TraceIn("KNEW", 22);
		try
		{
			int _type = KNEW;
			int _channel = DefaultTokenChannel;
			// MathLang.g:122:5: ( 'new' )
			DebugEnterAlt(1);
			// MathLang.g:122:7: 'new'
			{
			DebugLocation(122, 7);
			Match("new"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("KNEW", 22);
			LeaveRule("KNEW", 22);
			Leave_KNEW();
		}
	}
	// $ANTLR end "KNEW"

	partial void Enter_SQRBL();
	partial void Leave_SQRBL();

	// $ANTLR start "SQRBL"
	[GrammarRule("SQRBL")]
	private void mSQRBL()
	{
		Enter_SQRBL();
		EnterRule("SQRBL", 23);
		TraceIn("SQRBL", 23);
		try
		{
			int _type = SQRBL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:123:6: ( '[' )
			DebugEnterAlt(1);
			// MathLang.g:123:7: '['
			{
			DebugLocation(123, 7);
			Match('['); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SQRBL", 23);
			LeaveRule("SQRBL", 23);
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
		EnterRule("SQRBR", 24);
		TraceIn("SQRBR", 24);
		try
		{
			int _type = SQRBR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:124:6: ( ']' )
			DebugEnterAlt(1);
			// MathLang.g:124:7: ']'
			{
			DebugLocation(124, 7);
			Match(']'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SQRBR", 24);
			LeaveRule("SQRBR", 24);
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
		EnterRule("TYPE", 25);
		TraceIn("TYPE", 25);
		try
		{
			int _type = TYPE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:126:5: ( ( 'int' | 'bool' | 'char' ) SQRBL SQRBR )
			DebugEnterAlt(1);
			// MathLang.g:126:7: ( 'int' | 'bool' | 'char' ) SQRBL SQRBR
			{
			DebugLocation(126, 7);
			// MathLang.g:126:7: ( 'int' | 'bool' | 'char' )
			int alt1=3;
			try { DebugEnterSubRule(1);
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
				// MathLang.g:126:8: 'int'
				{
				DebugLocation(126, 8);
				Match("int"); 


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:126:16: 'bool'
				{
				DebugLocation(126, 16);
				Match("bool"); 


				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:126:25: 'char'
				{
				DebugLocation(126, 25);
				Match("char"); 


				}
				break;

			}
			} finally { DebugExitSubRule(1); }

			DebugLocation(126, 33);
			mSQRBL(); 
			DebugLocation(126, 39);
			mSQRBR(); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TYPE", 25);
			LeaveRule("TYPE", 25);
			Leave_TYPE();
		}
	}
	// $ANTLR end "TYPE"

	partial void Enter_TYPE0();
	partial void Leave_TYPE0();

	// $ANTLR start "TYPE0"
	[GrammarRule("TYPE0")]
	private void mTYPE0()
	{
		Enter_TYPE0();
		EnterRule("TYPE0", 26);
		TraceIn("TYPE0", 26);
		try
		{
			int _type = TYPE0;
			int _channel = DefaultTokenChannel;
			// MathLang.g:127:6: ( ( 'int' | 'bool' | 'char' ) )
			DebugEnterAlt(1);
			// MathLang.g:127:8: ( 'int' | 'bool' | 'char' )
			{
			DebugLocation(127, 8);
			// MathLang.g:127:8: ( 'int' | 'bool' | 'char' )
			int alt2=3;
			try { DebugEnterSubRule(2);
			try { DebugEnterDecision(2, decisionCanBacktrack[2]);
			switch (input.LA(1))
			{
			case 'i':
				{
				alt2=1;
				}
				break;
			case 'b':
				{
				alt2=2;
				}
				break;
			case 'c':
				{
				alt2=3;
				}
				break;
			default:
				{
					NoViableAltException nvae = new NoViableAltException("", 2, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(2); }
			switch (alt2)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:127:9: 'int'
				{
				DebugLocation(127, 9);
				Match("int"); 


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:127:17: 'bool'
				{
				DebugLocation(127, 17);
				Match("bool"); 


				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:127:26: 'char'
				{
				DebugLocation(127, 26);
				Match("char"); 


				}
				break;

			}
			} finally { DebugExitSubRule(2); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TYPE0", 26);
			LeaveRule("TYPE0", 26);
			Leave_TYPE0();
		}
	}
	// $ANTLR end "TYPE0"

	partial void Enter_ACCESS_MODIFIER();
	partial void Leave_ACCESS_MODIFIER();

	// $ANTLR start "ACCESS_MODIFIER"
	[GrammarRule("ACCESS_MODIFIER")]
	private void mACCESS_MODIFIER()
	{
		Enter_ACCESS_MODIFIER();
		EnterRule("ACCESS_MODIFIER", 27);
		TraceIn("ACCESS_MODIFIER", 27);
		try
		{
			int _type = ACCESS_MODIFIER;
			int _channel = DefaultTokenChannel;
			// MathLang.g:128:16: ( 'public' | 'private' )
			int alt3=2;
			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
			int LA3_0 = input.LA(1);

			if ((LA3_0=='p'))
			{
				int LA3_1 = input.LA(2);

				if ((LA3_1=='u'))
				{
					alt3=1;
				}
				else if ((LA3_1=='r'))
				{
					alt3=2;
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 3, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 3, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(3); }
			switch (alt3)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:128:18: 'public'
				{
				DebugLocation(128, 18);
				Match("public"); 


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:128:29: 'private'
				{
				DebugLocation(128, 29);
				Match("private"); 


				}
				break;

			}
			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ACCESS_MODIFIER", 27);
			LeaveRule("ACCESS_MODIFIER", 27);
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
		EnterRule("NUMBER", 28);
		TraceIn("NUMBER", 28);
		try
		{
			int _type = NUMBER;
			int _channel = DefaultTokenChannel;
			// MathLang.g:129:7: ( ( '0' .. '9' )+ )
			DebugEnterAlt(1);
			// MathLang.g:129:9: ( '0' .. '9' )+
			{
			DebugLocation(129, 9);
			// MathLang.g:129:9: ( '0' .. '9' )+
			int cnt4=0;
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_0 = input.LA(1);

				if (((LA4_0>='0' && LA4_0<='9')))
				{
					alt4=1;
				}


				} finally { DebugExitDecision(4); }
				switch (alt4)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:129:10: '0' .. '9'
					{
					DebugLocation(129, 10);
					MatchRange('0','9'); 

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
			TraceOut("NUMBER", 28);
			LeaveRule("NUMBER", 28);
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
		EnterRule("ADD", 29);
		TraceIn("ADD", 29);
		try
		{
			int _type = ADD;
			int _channel = DefaultTokenChannel;
			// MathLang.g:130:4: ( '+' )
			DebugEnterAlt(1);
			// MathLang.g:130:9: '+'
			{
			DebugLocation(130, 9);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ADD", 29);
			LeaveRule("ADD", 29);
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
		EnterRule("SUB", 30);
		TraceIn("SUB", 30);
		try
		{
			int _type = SUB;
			int _channel = DefaultTokenChannel;
			// MathLang.g:131:4: ( '-' )
			DebugEnterAlt(1);
			// MathLang.g:131:9: '-'
			{
			DebugLocation(131, 9);
			Match('-'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SUB", 30);
			LeaveRule("SUB", 30);
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
		EnterRule("MUL", 31);
		TraceIn("MUL", 31);
		try
		{
			int _type = MUL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:132:4: ( '*' )
			DebugEnterAlt(1);
			// MathLang.g:132:9: '*'
			{
			DebugLocation(132, 9);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MUL", 31);
			LeaveRule("MUL", 31);
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
		EnterRule("DIV", 32);
		TraceIn("DIV", 32);
		try
		{
			int _type = DIV;
			int _channel = DefaultTokenChannel;
			// MathLang.g:133:4: ( '/' )
			DebugEnterAlt(1);
			// MathLang.g:133:9: '/'
			{
			DebugLocation(133, 9);
			Match('/'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DIV", 32);
			LeaveRule("DIV", 32);
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
		EnterRule("ASSIGN", 33);
		TraceIn("ASSIGN", 33);
		try
		{
			int _type = ASSIGN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:134:7: ( '=' )
			DebugEnterAlt(1);
			// MathLang.g:134:9: '='
			{
			DebugLocation(134, 9);
			Match('='); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ASSIGN", 33);
			LeaveRule("ASSIGN", 33);
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
		EnterRule("RETURN", 34);
		TraceIn("RETURN", 34);
		try
		{
			int _type = RETURN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:135:7: ( 'return' )
			DebugEnterAlt(1);
			// MathLang.g:135:9: 'return'
			{
			DebugLocation(135, 9);
			Match("return"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RETURN", 34);
			LeaveRule("RETURN", 34);
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
		EnterRule("RETURNS", 35);
		TraceIn("RETURNS", 35);
		try
		{
			int _type = RETURNS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:136:8: ( 'returns' )
			DebugEnterAlt(1);
			// MathLang.g:136:9: 'returns'
			{
			DebugLocation(136, 9);
			Match("returns"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RETURNS", 35);
			LeaveRule("RETURNS", 35);
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
		EnterRule("TRUE", 36);
		TraceIn("TRUE", 36);
		try
		{
			int _type = TRUE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:137:5: ( 'true' )
			DebugEnterAlt(1);
			// MathLang.g:137:7: 'true'
			{
			DebugLocation(137, 7);
			Match("true"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TRUE", 36);
			LeaveRule("TRUE", 36);
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
		EnterRule("FALSE", 37);
		TraceIn("FALSE", 37);
		try
		{
			int _type = FALSE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:138:6: ( 'false' )
			DebugEnterAlt(1);
			// MathLang.g:138:8: 'false'
			{
			DebugLocation(138, 8);
			Match("false"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FALSE", 37);
			LeaveRule("FALSE", 37);
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
		EnterRule("EQ", 38);
		TraceIn("EQ", 38);
		try
		{
			int _type = EQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:139:3: ( '==' )
			DebugEnterAlt(1);
			// MathLang.g:139:6: '=='
			{
			DebugLocation(139, 6);
			Match("=="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EQ", 38);
			LeaveRule("EQ", 38);
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
		EnterRule("NEQ", 39);
		TraceIn("NEQ", 39);
		try
		{
			int _type = NEQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:140:4: ( '!=' )
			DebugEnterAlt(1);
			// MathLang.g:140:6: '!='
			{
			DebugLocation(140, 6);
			Match("!="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NEQ", 39);
			LeaveRule("NEQ", 39);
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
		EnterRule("GR", 40);
		TraceIn("GR", 40);
		try
		{
			int _type = GR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:141:3: ( '>' )
			DebugEnterAlt(1);
			// MathLang.g:141:6: '>'
			{
			DebugLocation(141, 6);
			Match('>'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GR", 40);
			LeaveRule("GR", 40);
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
		EnterRule("GREQ", 41);
		TraceIn("GREQ", 41);
		try
		{
			int _type = GREQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:142:5: ( '>=' )
			DebugEnterAlt(1);
			// MathLang.g:142:9: '>='
			{
			DebugLocation(142, 9);
			Match(">="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GREQ", 41);
			LeaveRule("GREQ", 41);
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
		EnterRule("LS", 42);
		TraceIn("LS", 42);
		try
		{
			int _type = LS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:143:3: ( '<' )
			DebugEnterAlt(1);
			// MathLang.g:143:6: '<'
			{
			DebugLocation(143, 6);
			Match('<'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LS", 42);
			LeaveRule("LS", 42);
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
		EnterRule("LSEQ", 43);
		TraceIn("LSEQ", 43);
		try
		{
			int _type = LSEQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:144:5: ( '<=' )
			DebugEnterAlt(1);
			// MathLang.g:144:7: '<='
			{
			DebugLocation(144, 7);
			Match("<="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LSEQ", 43);
			LeaveRule("LSEQ", 43);
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
		EnterRule("NOT", 44);
		TraceIn("NOT", 44);
		try
		{
			int _type = NOT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:145:4: ( '!' )
			DebugEnterAlt(1);
			// MathLang.g:145:6: '!'
			{
			DebugLocation(145, 6);
			Match('!'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NOT", 44);
			LeaveRule("NOT", 44);
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
		EnterRule("PARAMETERS", 45);
		TraceIn("PARAMETERS", 45);
		try
		{
			int _type = PARAMETERS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:146:11: ( 'parameters' )
			DebugEnterAlt(1);
			// MathLang.g:146:13: 'parameters'
			{
			DebugLocation(146, 13);
			Match("parameters"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PARAMETERS", 45);
			LeaveRule("PARAMETERS", 45);
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
		EnterRule("OR", 46);
		TraceIn("OR", 46);
		try
		{
			int _type = OR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:147:3: ( '||' )
			DebugEnterAlt(1);
			// MathLang.g:147:6: '||'
			{
			DebugLocation(147, 6);
			Match("||"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OR", 46);
			LeaveRule("OR", 46);
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
		EnterRule("AND", 47);
		TraceIn("AND", 47);
		try
		{
			int _type = AND;
			int _channel = DefaultTokenChannel;
			// MathLang.g:148:4: ( '&&' )
			DebugEnterAlt(1);
			// MathLang.g:148:6: '&&'
			{
			DebugLocation(148, 6);
			Match("&&"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("AND", 47);
			LeaveRule("AND", 47);
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
		EnterRule("WS", 48);
		TraceIn("WS", 48);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:149:3: ( ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+ )
			DebugEnterAlt(1);
			// MathLang.g:150:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			{
			DebugLocation(150, 3);
			// MathLang.g:150:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			int cnt5=0;
			try { DebugEnterSubRule(5);
			while (true)
			{
				int alt5=2;
				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
				int LA5_0 = input.LA(1);

				if (((LA5_0>='\t' && LA5_0<='\n')||(LA5_0>='\f' && LA5_0<='\r')||LA5_0==' '))
				{
					alt5=1;
				}


				} finally { DebugExitDecision(5); }
				switch (alt5)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:
					{
					DebugLocation(150, 3);
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

			DebugLocation(150, 41);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 48);
			LeaveRule("WS", 48);
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
		EnterRule("CHAR", 49);
		TraceIn("CHAR", 49);
		try
		{
			int _type = CHAR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:154:5: ( '\\'' ( 'a' .. 'z' ) '\\'' )
			DebugEnterAlt(1);
			// MathLang.g:154:8: '\\'' ( 'a' .. 'z' ) '\\''
			{
			DebugLocation(154, 8);
			Match('\''); 
			DebugLocation(154, 12);
			// MathLang.g:154:12: ( 'a' .. 'z' )
			DebugEnterAlt(1);
			// MathLang.g:154:13: 'a' .. 'z'
			{
			DebugLocation(154, 13);
			MatchRange('a','z'); 

			}

			DebugLocation(154, 22);
			Match('\''); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CHAR", 49);
			LeaveRule("CHAR", 49);
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
		EnterRule("ID", 50);
		TraceIn("ID", 50);
		try
		{
			int _type = ID;
			int _channel = DefaultTokenChannel;
			// MathLang.g:155:3: ( ( 'a' .. 'z' )+ )
			DebugEnterAlt(1);
			// MathLang.g:155:6: ( 'a' .. 'z' )+
			{
			DebugLocation(155, 6);
			// MathLang.g:155:6: ( 'a' .. 'z' )+
			int cnt6=0;
			try { DebugEnterSubRule(6);
			while (true)
			{
				int alt6=2;
				try { DebugEnterDecision(6, decisionCanBacktrack[6]);
				int LA6_0 = input.LA(1);

				if (((LA6_0>='a' && LA6_0<='z')))
				{
					alt6=1;
				}


				} finally { DebugExitDecision(6); }
				switch (alt6)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:155:7: 'a' .. 'z'
					{
					DebugLocation(155, 7);
					MatchRange('a','z'); 

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


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ID", 50);
			LeaveRule("ID", 50);
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
		EnterRule("SL_COMMENT", 51);
		TraceIn("SL_COMMENT", 51);
		try
		{
			int _type = SL_COMMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:159:11: ( '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n' )
			DebugEnterAlt(1);
			// MathLang.g:160:3: '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n'
			{
			DebugLocation(160, 3);
			Match("//"); 

			DebugLocation(160, 8);
			// MathLang.g:160:8: ( options {greedy=false; } : . )*
			try { DebugEnterSubRule(7);
			while (true)
			{
				int alt7=2;
				try { DebugEnterDecision(7, decisionCanBacktrack[7]);
				int LA7_0 = input.LA(1);

				if ((LA7_0=='\r'))
				{
					alt7=2;
				}
				else if ((LA7_0=='\n'))
				{
					alt7=2;
				}
				else if (((LA7_0>='\u0000' && LA7_0<='\t')||(LA7_0>='\u000B' && LA7_0<='\f')||(LA7_0>='\u000E' && LA7_0<='\uFFFF')))
				{
					alt7=1;
				}


				} finally { DebugExitDecision(7); }
				switch ( alt7 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:160:36: .
					{
					DebugLocation(160, 36);
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

			DebugLocation(160, 40);
			// MathLang.g:160:40: ( '\\r' )?
			int alt8=2;
			try { DebugEnterSubRule(8);
			try { DebugEnterDecision(8, decisionCanBacktrack[8]);
			int LA8_0 = input.LA(1);

			if ((LA8_0=='\r'))
			{
				alt8=1;
			}
			} finally { DebugExitDecision(8); }
			switch (alt8)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:160:40: '\\r'
				{
				DebugLocation(160, 40);
				Match('\r'); 

				}
				break;

			}
			} finally { DebugExitSubRule(8); }

			DebugLocation(160, 46);
			Match('\n'); 
			DebugLocation(160, 51);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SL_COMMENT", 51);
			LeaveRule("SL_COMMENT", 51);
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
		EnterRule("ML_COMMENT", 52);
		TraceIn("ML_COMMENT", 52);
		try
		{
			int _type = ML_COMMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:164:11: ( '/*' ( options {greedy=false; } : . )* '*/' )
			DebugEnterAlt(1);
			// MathLang.g:165:3: '/*' ( options {greedy=false; } : . )* '*/'
			{
			DebugLocation(165, 3);
			Match("/*"); 

			DebugLocation(165, 8);
			// MathLang.g:165:8: ( options {greedy=false; } : . )*
			try { DebugEnterSubRule(9);
			while (true)
			{
				int alt9=2;
				try { DebugEnterDecision(9, decisionCanBacktrack[9]);
				int LA9_0 = input.LA(1);

				if ((LA9_0=='*'))
				{
					int LA9_1 = input.LA(2);

					if ((LA9_1=='/'))
					{
						alt9=2;
					}
					else if (((LA9_1>='\u0000' && LA9_1<='.')||(LA9_1>='0' && LA9_1<='\uFFFF')))
					{
						alt9=1;
					}


				}
				else if (((LA9_0>='\u0000' && LA9_0<=')')||(LA9_0>='+' && LA9_0<='\uFFFF')))
				{
					alt9=1;
				}


				} finally { DebugExitDecision(9); }
				switch ( alt9 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:165:36: .
					{
					DebugLocation(165, 36);
					MatchAny(); 

					}
					break;

				default:
					goto loop9;
				}
			}

			loop9:
				;

			} finally { DebugExitSubRule(9); }

			DebugLocation(165, 40);
			Match("*/"); 

			DebugLocation(165, 45);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ML_COMMENT", 52);
			LeaveRule("ML_COMMENT", 52);
			Leave_ML_COMMENT();
		}
	}
	// $ANTLR end "ML_COMMENT"

	public override void mTokens()
	{
		// MathLang.g:1:8: ( PRINT | INPUT | IF | ELSE | FOR | FUNCTION | WHILE | VARDECLARATION | FUNCDECLARATION | VARASSIGNMENT | ARRAYELEMENTASSIGNMENT | ARRAYELEMENT | NEWWORD | NEWVAR | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | KNEW | SQRBL | SQRBR | TYPE | TYPE0 | ACCESS_MODIFIER | NUMBER | ADD | SUB | MUL | DIV | ASSIGN | RETURN | RETURNS | TRUE | FALSE | EQ | NEQ | GR | GREQ | LS | LSEQ | NOT | PARAMETERS | OR | AND | WS | CHAR | ID | SL_COMMENT | ML_COMMENT )
		int alt10=52;
		try { DebugEnterDecision(10, decisionCanBacktrack[10]);
		try
		{
			alt10 = dfa10.Predict(input);
		}
		catch (NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
			throw;
		}
		} finally { DebugExitDecision(10); }
		switch (alt10)
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
			// MathLang.g:1:80: VARASSIGNMENT
			{
			DebugLocation(1, 80);
			mVARASSIGNMENT(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// MathLang.g:1:94: ARRAYELEMENTASSIGNMENT
			{
			DebugLocation(1, 94);
			mARRAYELEMENTASSIGNMENT(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// MathLang.g:1:117: ARRAYELEMENT
			{
			DebugLocation(1, 117);
			mARRAYELEMENT(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// MathLang.g:1:130: NEWWORD
			{
			DebugLocation(1, 130);
			mNEWWORD(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// MathLang.g:1:138: NEWVAR
			{
			DebugLocation(1, 138);
			mNEWVAR(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// MathLang.g:1:145: T__53
			{
			DebugLocation(1, 145);
			mT__53(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// MathLang.g:1:151: T__54
			{
			DebugLocation(1, 151);
			mT__54(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// MathLang.g:1:157: T__55
			{
			DebugLocation(1, 157);
			mT__55(); 

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// MathLang.g:1:163: T__56
			{
			DebugLocation(1, 163);
			mT__56(); 

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// MathLang.g:1:169: T__57
			{
			DebugLocation(1, 169);
			mT__57(); 

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// MathLang.g:1:175: T__58
			{
			DebugLocation(1, 175);
			mT__58(); 

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// MathLang.g:1:181: T__59
			{
			DebugLocation(1, 181);
			mT__59(); 

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// MathLang.g:1:187: KNEW
			{
			DebugLocation(1, 187);
			mKNEW(); 

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// MathLang.g:1:192: SQRBL
			{
			DebugLocation(1, 192);
			mSQRBL(); 

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// MathLang.g:1:198: SQRBR
			{
			DebugLocation(1, 198);
			mSQRBR(); 

			}
			break;
		case 25:
			DebugEnterAlt(25);
			// MathLang.g:1:204: TYPE
			{
			DebugLocation(1, 204);
			mTYPE(); 

			}
			break;
		case 26:
			DebugEnterAlt(26);
			// MathLang.g:1:209: TYPE0
			{
			DebugLocation(1, 209);
			mTYPE0(); 

			}
			break;
		case 27:
			DebugEnterAlt(27);
			// MathLang.g:1:215: ACCESS_MODIFIER
			{
			DebugLocation(1, 215);
			mACCESS_MODIFIER(); 

			}
			break;
		case 28:
			DebugEnterAlt(28);
			// MathLang.g:1:231: NUMBER
			{
			DebugLocation(1, 231);
			mNUMBER(); 

			}
			break;
		case 29:
			DebugEnterAlt(29);
			// MathLang.g:1:238: ADD
			{
			DebugLocation(1, 238);
			mADD(); 

			}
			break;
		case 30:
			DebugEnterAlt(30);
			// MathLang.g:1:242: SUB
			{
			DebugLocation(1, 242);
			mSUB(); 

			}
			break;
		case 31:
			DebugEnterAlt(31);
			// MathLang.g:1:246: MUL
			{
			DebugLocation(1, 246);
			mMUL(); 

			}
			break;
		case 32:
			DebugEnterAlt(32);
			// MathLang.g:1:250: DIV
			{
			DebugLocation(1, 250);
			mDIV(); 

			}
			break;
		case 33:
			DebugEnterAlt(33);
			// MathLang.g:1:254: ASSIGN
			{
			DebugLocation(1, 254);
			mASSIGN(); 

			}
			break;
		case 34:
			DebugEnterAlt(34);
			// MathLang.g:1:261: RETURN
			{
			DebugLocation(1, 261);
			mRETURN(); 

			}
			break;
		case 35:
			DebugEnterAlt(35);
			// MathLang.g:1:268: RETURNS
			{
			DebugLocation(1, 268);
			mRETURNS(); 

			}
			break;
		case 36:
			DebugEnterAlt(36);
			// MathLang.g:1:276: TRUE
			{
			DebugLocation(1, 276);
			mTRUE(); 

			}
			break;
		case 37:
			DebugEnterAlt(37);
			// MathLang.g:1:281: FALSE
			{
			DebugLocation(1, 281);
			mFALSE(); 

			}
			break;
		case 38:
			DebugEnterAlt(38);
			// MathLang.g:1:287: EQ
			{
			DebugLocation(1, 287);
			mEQ(); 

			}
			break;
		case 39:
			DebugEnterAlt(39);
			// MathLang.g:1:290: NEQ
			{
			DebugLocation(1, 290);
			mNEQ(); 

			}
			break;
		case 40:
			DebugEnterAlt(40);
			// MathLang.g:1:294: GR
			{
			DebugLocation(1, 294);
			mGR(); 

			}
			break;
		case 41:
			DebugEnterAlt(41);
			// MathLang.g:1:297: GREQ
			{
			DebugLocation(1, 297);
			mGREQ(); 

			}
			break;
		case 42:
			DebugEnterAlt(42);
			// MathLang.g:1:302: LS
			{
			DebugLocation(1, 302);
			mLS(); 

			}
			break;
		case 43:
			DebugEnterAlt(43);
			// MathLang.g:1:305: LSEQ
			{
			DebugLocation(1, 305);
			mLSEQ(); 

			}
			break;
		case 44:
			DebugEnterAlt(44);
			// MathLang.g:1:310: NOT
			{
			DebugLocation(1, 310);
			mNOT(); 

			}
			break;
		case 45:
			DebugEnterAlt(45);
			// MathLang.g:1:314: PARAMETERS
			{
			DebugLocation(1, 314);
			mPARAMETERS(); 

			}
			break;
		case 46:
			DebugEnterAlt(46);
			// MathLang.g:1:325: OR
			{
			DebugLocation(1, 325);
			mOR(); 

			}
			break;
		case 47:
			DebugEnterAlt(47);
			// MathLang.g:1:328: AND
			{
			DebugLocation(1, 328);
			mAND(); 

			}
			break;
		case 48:
			DebugEnterAlt(48);
			// MathLang.g:1:332: WS
			{
			DebugLocation(1, 332);
			mWS(); 

			}
			break;
		case 49:
			DebugEnterAlt(49);
			// MathLang.g:1:335: CHAR
			{
			DebugLocation(1, 335);
			mCHAR(); 

			}
			break;
		case 50:
			DebugEnterAlt(50);
			// MathLang.g:1:340: ID
			{
			DebugLocation(1, 340);
			mID(); 

			}
			break;
		case 51:
			DebugEnterAlt(51);
			// MathLang.g:1:343: SL_COMMENT
			{
			DebugLocation(1, 343);
			mSL_COMMENT(); 

			}
			break;
		case 52:
			DebugEnterAlt(52);
			// MathLang.g:1:354: ML_COMMENT
			{
			DebugLocation(1, 354);
			mML_COMMENT(); 

			}
			break;

		}

	}


	#region DFA
	DFA10 dfa10;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa10 = new DFA10(this);
	}

	private class DFA10 : DFA
	{
		private const string DFA10_eotS =
			"\x1\xFFFF\x8\x22\x1\xFFFF\x1\x31\x6\xFFFF\x2\x22\x4\xFFFF\x1\x36\x1"+
			"\x38\x2\x22\x1\x3C\x1\x3E\x1\x40\x5\xFFFF\x4\x22\x1\x46\x8\x22\x2\xFFFF"+
			"\x2\x22\x5\xFFFF\x2\x22\x6\xFFFF\x4\x22\x1\x59\x1\xFFFF\x1\x22\x1\x5B"+
			"\x5\x22\x1\x64\x9\x22\x2\xFFFF\x1\x6E\x1\xFFFF\x8\x22\x1\xFFFF\x2\x59"+
			"\x1\x22\x1\x79\x1\x7A\x3\x22\x1\x7E\x1\xFFFF\x2\x22\x1\x81\x1\x82\x6"+
			"\x22\x2\xFFFF\x1\x22\x1\x8A\x1\x22\x1\xFFFF\x2\x22\x2\xFFFF\x4\x22\x1"+
			"\x92\x1\x94\x1\x8A\x1\xFFFF\x6\x22\x1\x9B\x1\xFFFF\x1\x9C\x1\xFFFF\x1"+
			"\x22\x1\x9E\x4\x22\x2\xFFFF\x1\x22\x1\xFFFF\x4\x22\x1\xA8\x4\x22\x1\xFFFF"+
			"\x7\x22\x1\xB5\x2\x22\x1\xB8\x1\x22\x1\xFFFF\x1\x22\x1\xBB\x1\xFFFF\x1"+
			"\x22\x1\xBD\x1\xFFFF\x1\x22\x1\xFFFF\x6\x22\x1\xC5\x1\xFFFF";
		private const string DFA10_eofS =
			"\xC6\xFFFF";
		private const string DFA10_minS =
			"\x1\x9\x1\x61\x1\x66\x1\x6C\x1\x61\x1\x68\x1\x61\x1\x72\x1\x65\x1\xFFFF"+
			"\x1\x29\x6\xFFFF\x1\x6F\x1\x68\x4\xFFFF\x1\x2A\x1\x3D\x1\x65\x1\x72\x3"+
			"\x3D\x5\xFFFF\x1\x69\x1\x62\x1\x72\x1\x70\x1\x61\x1\x73\x1\x72\x1\x6E"+
			"\x1\x6C\x1\x69\x2\x72\x1\x77\x2\xFFFF\x1\x6F\x1\x61\x5\xFFFF\x1\x74\x1"+
			"\x75\x6\xFFFF\x1\x6E\x1\x6C\x1\x61\x1\x75\x1\x5B\x1\xFFFF\x1\x65\x1\x61"+
			"\x1\x63\x1\x73\x1\x6C\x3\x61\x1\x6C\x1\x72\x1\x75\x1\x65\x1\x74\x1\x61"+
			"\x1\x69\x1\x6D\x1\x74\x2\xFFFF\x1\x61\x1\xFFFF\x1\x64\x3\x65\x1\x73\x1"+
			"\x79\x1\x6F\x1\x61\x1\xFFFF\x2\x5B\x1\x72\x2\x61\x1\x74\x1\x63\x1\x65"+
			"\x1\x61\x1\xFFFF\x1\x69\x1\x65\x2\x61\x1\x63\x1\x73\x1\x65\x2\x72\x1"+
			"\x6E\x2\xFFFF\x1\x65\x1\x61\x1\x74\x1\xFFFF\x1\x6F\x1\x63\x2\xFFFF\x1"+
			"\x6C\x1\x69\x1\x6C\x1\x64\x3\x61\x1\xFFFF\x1\x65\x1\x6E\x1\x6C\x1\x61"+
			"\x1\x67\x1\x65\x1\x61\x1\xFFFF\x1\x61\x1\xFFFF\x1\x72\x2\x61\x1\x72\x1"+
			"\x6E\x1\x6D\x2\xFFFF\x1\x73\x1\xFFFF\x1\x72\x1\x61\x1\x6D\x1\x65\x2\x61"+
			"\x1\x74\x1\x65\x1\x6E\x1\xFFFF\x1\x74\x1\x69\x1\x6E\x1\x74\x1\x69\x1"+
			"\x6F\x1\x74\x1\x61\x1\x6F\x1\x6E\x1\x61\x1\x73\x1\xFFFF\x1\x6E\x1\x61"+
			"\x1\xFFFF\x1\x73\x1\x61\x1\xFFFF\x1\x69\x1\xFFFF\x1\x67\x1\x6E\x1\x6D"+
			"\x1\x65\x1\x6E\x1\x74\x1\x61\x1\xFFFF";
		private const string DFA10_maxS =
			"\x1\x7D\x1\x75\x1\x6E\x1\x6C\x1\x75\x1\x68\x1\x61\x1\x72\x1\x65\x1\xFFFF"+
			"\x1\x29\x6\xFFFF\x1\x6F\x1\x68\x4\xFFFF\x1\x2F\x1\x3D\x1\x65\x1\x72\x3"+
			"\x3D\x5\xFFFF\x1\x69\x1\x62\x1\x72\x1\x74\x1\x7A\x1\x73\x1\x72\x1\x6E"+
			"\x1\x6C\x1\x69\x2\x72\x1\x77\x2\xFFFF\x1\x6F\x1\x61\x5\xFFFF\x1\x74\x1"+
			"\x75\x6\xFFFF\x1\x76\x1\x6C\x1\x61\x1\x75\x1\x7A\x1\xFFFF\x1\x65\x1\x7A"+
			"\x1\x63\x1\x73\x1\x6C\x1\x64\x1\x61\x1\x7A\x1\x6C\x1\x72\x1\x75\x1\x65"+
			"\x1\x74\x1\x61\x1\x69\x1\x6D\x1\x74\x2\xFFFF\x1\x7A\x1\xFFFF\x1\x74\x3"+
			"\x65\x1\x73\x1\x79\x1\x6F\x1\x61\x1\xFFFF\x2\x7A\x1\x72\x2\x7A\x1\x74"+
			"\x1\x63\x1\x65\x1\x7A\x1\xFFFF\x1\x69\x1\x65\x2\x7A\x1\x63\x1\x73\x1"+
			"\x65\x2\x72\x1\x6E\x2\xFFFF\x1\x65\x1\x7A\x1\x74\x1\xFFFF\x1\x6F\x1\x63"+
			"\x2\xFFFF\x1\x6C\x1\x69\x1\x6C\x1\x64\x3\x7A\x1\xFFFF\x1\x65\x1\x6E\x1"+
			"\x6C\x1\x61\x1\x67\x1\x65\x1\x7A\x1\xFFFF\x1\x7A\x1\xFFFF\x1\x72\x1\x7A"+
			"\x1\x61\x1\x72\x1\x6E\x1\x6D\x2\xFFFF\x1\x73\x1\xFFFF\x1\x72\x1\x61\x1"+
			"\x6D\x1\x65\x1\x7A\x1\x61\x1\x74\x1\x65\x1\x6E\x1\xFFFF\x1\x74\x1\x69"+
			"\x1\x6E\x1\x74\x1\x69\x1\x6F\x1\x74\x1\x7A\x1\x6F\x1\x6E\x1\x7A\x1\x73"+
			"\x1\xFFFF\x1\x6E\x1\x7A\x1\xFFFF\x1\x73\x1\x7A\x1\xFFFF\x1\x69\x1\xFFFF"+
			"\x1\x67\x1\x6E\x1\x6D\x1\x65\x1\x6E\x1\x74\x1\x7A\x1\xFFFF";
		private const string DFA10_acceptS =
			"\x9\xFFFF\x1\xF\x1\xFFFF\x1\x11\x1\x12\x1\x14\x1\x15\x1\x17\x1\x18\x2"+
			"\xFFFF\x1\x1C\x1\x1D\x1\x1E\x1\x1F\x7\xFFFF\x1\x2E\x1\x2F\x1\x30\x1\x31"+
			"\x1\x32\xD\xFFFF\x1\x13\x1\x10\x2\xFFFF\x1\x33\x1\x34\x1\x20\x1\x26\x1"+
			"\x21\x2\xFFFF\x1\x27\x1\x2C\x1\x29\x1\x28\x1\x2B\x1\x2A\x5\xFFFF\x1\x3"+
			"\x11\xFFFF\x1\x19\x1\x1A\x1\xFFFF\x1\x5\x8\xFFFF\x1\x16\x9\xFFFF\x1\x4"+
			"\xA\xFFFF\x1\x24\x1\x1\x3\xFFFF\x1\x2\x2\xFFFF\x1\x25\x1\x7\x7\xFFFF"+
			"\x1\x1B\x7\xFFFF\x1\xE\x1\xFFFF\x1\x22\x6\xFFFF\x1\xD\x1\x23\x1\xFFFF"+
			"\x1\x6\x9\xFFFF\x1\x2D\xC\xFFFF\x1\xC\x2\xFFFF\x1\xA\x2\xFFFF\x1\x8\x1"+
			"\xFFFF\x1\x9\x7\xFFFF\x1\xB";
		private const string DFA10_specialS =
			"\xC6\xFFFF}>";
		private static readonly string[] DFA10_transitionS =
			{
				"\x2\x20\x1\xFFFF\x2\x20\x12\xFFFF\x1\x20\x1\x1B\x4\xFFFF\x1\x1F\x1"+
				"\x21\x1\xA\x1\xB\x1\x16\x1\x14\x1\xC\x1\x15\x1\xFFFF\x1\x17\xA\x13\x1"+
				"\xFFFF\x1\x9\x1\x1D\x1\x18\x1\x1C\x1C\xFFFF\x1\xF\x1\xFFFF\x1\x10\x3"+
				"\xFFFF\x1\x7\x1\x11\x1\x12\x1\x22\x1\x3\x1\x4\x2\x22\x1\x2\x4\x22\x1"+
				"\x8\x1\x22\x1\x1\x1\x22\x1\x19\x1\x22\x1\x1A\x1\x22\x1\x6\x1\x5\x3\x22"+
				"\x1\xD\x1\x1E\x1\xE",
				"\x1\x25\x10\xFFFF\x1\x23\x2\xFFFF\x1\x24",
				"\x1\x27\x7\xFFFF\x1\x26",
				"\x1\x28",
				"\x1\x2B\xD\xFFFF\x1\x29\x5\xFFFF\x1\x2A",
				"\x1\x2C",
				"\x1\x2D",
				"\x1\x2E",
				"\x1\x2F",
				"",
				"\x1\x30",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x32",
				"\x1\x33",
				"",
				"",
				"",
				"",
				"\x1\x35\x4\xFFFF\x1\x34",
				"\x1\x37",
				"\x1\x39",
				"\x1\x3A",
				"\x1\x3B",
				"\x1\x3D",
				"\x1\x3F",
				"",
				"",
				"",
				"",
				"",
				"\x1\x41",
				"\x1\x42",
				"\x1\x43",
				"\x1\x44\x3\xFFFF\x1\x45",
				"\x1A\x22",
				"\x1\x47",
				"\x1\x48",
				"\x1\x49",
				"\x1\x4A",
				"\x1\x4B",
				"\x1\x4C",
				"\x1\x4D",
				"\x1\x4E",
				"",
				"",
				"\x1\x4F",
				"\x1\x50",
				"",
				"",
				"",
				"",
				"",
				"\x1\x51",
				"\x1\x52",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x53\x7\xFFFF\x1\x54",
				"\x1\x55",
				"\x1\x56",
				"\x1\x57",
				"\x1\x58\x5\xFFFF\x1A\x22",
				"",
				"\x1\x5A",
				"\x1A\x22",
				"\x1\x5C",
				"\x1\x5D",
				"\x1\x5E",
				"\x1\x60\x2\xFFFF\x1\x5F",
				"\x1\x61",
				"\x15\x22\x1\x63\x1\x62\x3\x22",
				"\x1\x65",
				"\x1\x66",
				"\x1\x67",
				"\x1\x68",
				"\x1\x69",
				"\x1\x6A",
				"\x1\x6B",
				"\x1\x6C",
				"\x1\x6D",
				"",
				"",
				"\x1A\x22",
				"",
				"\x1\x70\xF\xFFFF\x1\x6F",
				"\x1\x71",
				"\x1\x72",
				"\x1\x73",
				"\x1\x74",
				"\x1\x75",
				"\x1\x76",
				"\x1\x77",
				"",
				"\x1\x58\x5\xFFFF\x1A\x22",
				"\x1\x58\x5\xFFFF\x1A\x22",
				"\x1\x78",
				"\x1A\x22",
				"\x1A\x22",
				"\x1\x7B",
				"\x1\x7C",
				"\x1\x7D",
				"\x1A\x22",
				"",
				"\x1\x7F",
				"\x1\x80",
				"\x1A\x22",
				"\x1A\x22",
				"\x1\x83",
				"\x1\x84",
				"\x1\x85",
				"\x1\x86",
				"\x1\x87",
				"\x1\x88",
				"",
				"",
				"\x1\x89",
				"\x1A\x22",
				"\x1\x8B",
				"",
				"\x1\x8C",
				"\x1\x8D",
				"",
				"",
				"\x1\x8E",
				"\x1\x8F",
				"\x1\x90",
				"\x1\x91",
				"\x1A\x22",
				"\x12\x22\x1\x93\x7\x22",
				"\x1A\x22",
				"",
				"\x1\x95",
				"\x1\x96",
				"\x1\x97",
				"\x1\x98",
				"\x1\x99",
				"\x1\x9A",
				"\x1A\x22",
				"",
				"\x1A\x22",
				"",
				"\x1\x9D",
				"\x1A\x22",
				"\x1\x9F",
				"\x1\xA0",
				"\x1\xA1",
				"\x1\xA2",
				"",
				"",
				"\x1\xA3",
				"",
				"\x1\xA4",
				"\x1\xA5",
				"\x1\xA6",
				"\x1\xA7",
				"\x1A\x22",
				"\x1\xA9",
				"\x1\xAA",
				"\x1\xAB",
				"\x1\xAC",
				"",
				"\x1\xAD",
				"\x1\xAE",
				"\x1\xAF",
				"\x1\xB0",
				"\x1\xB1",
				"\x1\xB2",
				"\x1\xB3",
				"\x1\xB4\x19\x22",
				"\x1\xB6",
				"\x1\xB7",
				"\x1A\x22",
				"\x1\xB9",
				"",
				"\x1\xBA",
				"\x1A\x22",
				"",
				"\x1\xBC",
				"\x1A\x22",
				"",
				"\x1\xBE",
				"",
				"\x1\xBF",
				"\x1\xC0",
				"\x1\xC1",
				"\x1\xC2",
				"\x1\xC3",
				"\x1\xC4",
				"\x1A\x22",
				""
			};

		private static readonly short[] DFA10_eot = DFA.UnpackEncodedString(DFA10_eotS);
		private static readonly short[] DFA10_eof = DFA.UnpackEncodedString(DFA10_eofS);
		private static readonly char[] DFA10_min = DFA.UnpackEncodedStringToUnsignedChars(DFA10_minS);
		private static readonly char[] DFA10_max = DFA.UnpackEncodedStringToUnsignedChars(DFA10_maxS);
		private static readonly short[] DFA10_accept = DFA.UnpackEncodedString(DFA10_acceptS);
		private static readonly short[] DFA10_special = DFA.UnpackEncodedString(DFA10_specialS);
		private static readonly short[][] DFA10_transition;

		static DFA10()
		{
			int numStates = DFA10_transitionS.Length;
			DFA10_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA10_transition[i] = DFA.UnpackEncodedString(DFA10_transitionS[i]);
			}
		}

		public DFA10( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 10;
			this.eot = DFA10_eot;
			this.eof = DFA10_eof;
			this.min = DFA10_min;
			this.max = DFA10_max;
			this.accept = DFA10_accept;
			this.special = DFA10_special;
			this.transition = DFA10_transition;
		}

		public override string Description { get { return "1:1: Tokens : ( PRINT | INPUT | IF | ELSE | FOR | FUNCTION | WHILE | VARDECLARATION | FUNCDECLARATION | VARASSIGNMENT | ARRAYELEMENTASSIGNMENT | ARRAYELEMENT | NEWWORD | NEWVAR | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | KNEW | SQRBL | SQRBR | TYPE | TYPE0 | ACCESS_MODIFIER | NUMBER | ADD | SUB | MUL | DIV | ASSIGN | RETURN | RETURNS | TRUE | FALSE | EQ | NEQ | GR | GREQ | LS | LSEQ | NOT | PARAMETERS | OR | AND | WS | CHAR | ID | SL_COMMENT | ML_COMMENT );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}

} // namespace  MathLang 

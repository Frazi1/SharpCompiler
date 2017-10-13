// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-10-13 23:35:04

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
	public const int STATIC_DECLARATION=29;
	public const int CLASSBLOCK=30;
	public const int CLASS_WORD=31;
	public const int CALL=32;
	public const int MODIFIER=33;
	public const int ID=34;
	public const int TYPE=35;
	public const int ARRAY_DECLARATION_MARK=36;
	public const int VOID=37;
	public const int NUMBER=38;
	public const int CHAR=39;
	public const int DOT=40;
	public const int ASSIGN=41;
	public const int ADD=42;
	public const int SUB=43;
	public const int MUL=44;
	public const int DIV=45;
	public const int GREQ=46;
	public const int LSEQ=47;
	public const int NEQ=48;
	public const int EQ=49;
	public const int GR=50;
	public const int LS=51;
	public const int OPEN_BRACE=52;
	public const int CLOSE_BRACE=53;
	public const int OR=54;
	public const int AND=55;
	public const int NOT=56;
	public const int TRUE=57;
	public const int FALSE=58;
	public const int KNEW=59;
	public const int OPEN_SQUARE_BRACE=60;
	public const int CLOSE_SQUARE_BRACE=61;
	public const int CONSOLE_WORD=62;
	public const int WS=63;
	public const int SL_COMMENT=64;
	public const int ML_COMMENT=65;

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

	partial void Enter_CLASS_WORD();
	partial void Leave_CLASS_WORD();

	// $ANTLR start "CLASS_WORD"
	[GrammarRule("CLASS_WORD")]
	private void mCLASS_WORD()
	{
		Enter_CLASS_WORD();
		EnterRule("CLASS_WORD", 9);
		TraceIn("CLASS_WORD", 9);
		try
		{
			int _type = CLASS_WORD;
			int _channel = DefaultTokenChannel;
			// MathLang.g:17:12: ( 'class' )
			DebugEnterAlt(1);
			// MathLang.g:17:14: 'class'
			{
			DebugLocation(17, 14);
			Match("class"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CLASS_WORD", 9);
			LeaveRule("CLASS_WORD", 9);
			Leave_CLASS_WORD();
		}
	}
	// $ANTLR end "CLASS_WORD"

	partial void Enter_T__66();
	partial void Leave_T__66();

	// $ANTLR start "T__66"
	[GrammarRule("T__66")]
	private void mT__66()
	{
		Enter_T__66();
		EnterRule("T__66", 10);
		TraceIn("T__66", 10);
		try
		{
			int _type = T__66;
			int _channel = DefaultTokenChannel;
			// MathLang.g:18:7: ( '{' )
			DebugEnterAlt(1);
			// MathLang.g:18:9: '{'
			{
			DebugLocation(18, 9);
			Match('{'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__66", 10);
			LeaveRule("T__66", 10);
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
		EnterRule("T__67", 11);
		TraceIn("T__67", 11);
		try
		{
			int _type = T__67;
			int _channel = DefaultTokenChannel;
			// MathLang.g:19:7: ( '}' )
			DebugEnterAlt(1);
			// MathLang.g:19:9: '}'
			{
			DebugLocation(19, 9);
			Match('}'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__67", 11);
			LeaveRule("T__67", 11);
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
		EnterRule("T__68", 12);
		TraceIn("T__68", 12);
		try
		{
			int _type = T__68;
			int _channel = DefaultTokenChannel;
			// MathLang.g:20:7: ( ';' )
			DebugEnterAlt(1);
			// MathLang.g:20:9: ';'
			{
			DebugLocation(20, 9);
			Match(';'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__68", 12);
			LeaveRule("T__68", 12);
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
		EnterRule("T__69", 13);
		TraceIn("T__69", 13);
		try
		{
			int _type = T__69;
			int _channel = DefaultTokenChannel;
			// MathLang.g:21:7: ( ',' )
			DebugEnterAlt(1);
			// MathLang.g:21:9: ','
			{
			DebugLocation(21, 9);
			Match(','); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__69", 13);
			LeaveRule("T__69", 13);
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
		EnterRule("KNEW", 14);
		TraceIn("KNEW", 14);
		try
		{
			int _type = KNEW;
			int _channel = DefaultTokenChannel;
			// MathLang.g:164:5: ( 'new' )
			DebugEnterAlt(1);
			// MathLang.g:164:7: 'new'
			{
			DebugLocation(164, 7);
			Match("new"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("KNEW", 14);
			LeaveRule("KNEW", 14);
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
		EnterRule("CONSOLE_WORD", 15);
		TraceIn("CONSOLE_WORD", 15);
		try
		{
			int _type = CONSOLE_WORD;
			int _channel = DefaultTokenChannel;
			// MathLang.g:165:13: ( 'Console' )
			DebugEnterAlt(1);
			// MathLang.g:165:15: 'Console'
			{
			DebugLocation(165, 15);
			Match("Console"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CONSOLE_WORD", 15);
			LeaveRule("CONSOLE_WORD", 15);
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
		EnterRule("ARRAY_DECLARATION_MARK", 16);
		TraceIn("ARRAY_DECLARATION_MARK", 16);
		try
		{
			int _type = ARRAY_DECLARATION_MARK;
			int _channel = DefaultTokenChannel;
			// MathLang.g:166:23: ( OPEN_SQUARE_BRACE CLOSE_SQUARE_BRACE )
			DebugEnterAlt(1);
			// MathLang.g:166:25: OPEN_SQUARE_BRACE CLOSE_SQUARE_BRACE
			{
			DebugLocation(166, 25);
			mOPEN_SQUARE_BRACE(); 
			DebugLocation(166, 43);
			mCLOSE_SQUARE_BRACE(); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ARRAY_DECLARATION_MARK", 16);
			LeaveRule("ARRAY_DECLARATION_MARK", 16);
			Leave_ARRAY_DECLARATION_MARK();
		}
	}
	// $ANTLR end "ARRAY_DECLARATION_MARK"

	partial void Enter_OPEN_SQUARE_BRACE();
	partial void Leave_OPEN_SQUARE_BRACE();

	// $ANTLR start "OPEN_SQUARE_BRACE"
	[GrammarRule("OPEN_SQUARE_BRACE")]
	private void mOPEN_SQUARE_BRACE()
	{
		Enter_OPEN_SQUARE_BRACE();
		EnterRule("OPEN_SQUARE_BRACE", 17);
		TraceIn("OPEN_SQUARE_BRACE", 17);
		try
		{
			int _type = OPEN_SQUARE_BRACE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:167:18: ( '[' )
			DebugEnterAlt(1);
			// MathLang.g:167:19: '['
			{
			DebugLocation(167, 19);
			Match('['); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OPEN_SQUARE_BRACE", 17);
			LeaveRule("OPEN_SQUARE_BRACE", 17);
			Leave_OPEN_SQUARE_BRACE();
		}
	}
	// $ANTLR end "OPEN_SQUARE_BRACE"

	partial void Enter_CLOSE_SQUARE_BRACE();
	partial void Leave_CLOSE_SQUARE_BRACE();

	// $ANTLR start "CLOSE_SQUARE_BRACE"
	[GrammarRule("CLOSE_SQUARE_BRACE")]
	private void mCLOSE_SQUARE_BRACE()
	{
		Enter_CLOSE_SQUARE_BRACE();
		EnterRule("CLOSE_SQUARE_BRACE", 18);
		TraceIn("CLOSE_SQUARE_BRACE", 18);
		try
		{
			int _type = CLOSE_SQUARE_BRACE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:168:19: ( ']' )
			DebugEnterAlt(1);
			// MathLang.g:168:20: ']'
			{
			DebugLocation(168, 20);
			Match(']'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CLOSE_SQUARE_BRACE", 18);
			LeaveRule("CLOSE_SQUARE_BRACE", 18);
			Leave_CLOSE_SQUARE_BRACE();
		}
	}
	// $ANTLR end "CLOSE_SQUARE_BRACE"

	partial void Enter_OPEN_BRACE();
	partial void Leave_OPEN_BRACE();

	// $ANTLR start "OPEN_BRACE"
	[GrammarRule("OPEN_BRACE")]
	private void mOPEN_BRACE()
	{
		Enter_OPEN_BRACE();
		EnterRule("OPEN_BRACE", 19);
		TraceIn("OPEN_BRACE", 19);
		try
		{
			int _type = OPEN_BRACE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:169:11: ( '(' )
			DebugEnterAlt(1);
			// MathLang.g:169:13: '('
			{
			DebugLocation(169, 13);
			Match('('); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OPEN_BRACE", 19);
			LeaveRule("OPEN_BRACE", 19);
			Leave_OPEN_BRACE();
		}
	}
	// $ANTLR end "OPEN_BRACE"

	partial void Enter_CLOSE_BRACE();
	partial void Leave_CLOSE_BRACE();

	// $ANTLR start "CLOSE_BRACE"
	[GrammarRule("CLOSE_BRACE")]
	private void mCLOSE_BRACE()
	{
		Enter_CLOSE_BRACE();
		EnterRule("CLOSE_BRACE", 20);
		TraceIn("CLOSE_BRACE", 20);
		try
		{
			int _type = CLOSE_BRACE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:170:12: ( ')' )
			DebugEnterAlt(1);
			// MathLang.g:170:14: ')'
			{
			DebugLocation(170, 14);
			Match(')'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CLOSE_BRACE", 20);
			LeaveRule("CLOSE_BRACE", 20);
			Leave_CLOSE_BRACE();
		}
	}
	// $ANTLR end "CLOSE_BRACE"

	partial void Enter_TYPE();
	partial void Leave_TYPE();

	// $ANTLR start "TYPE"
	[GrammarRule("TYPE")]
	private void mTYPE()
	{
		Enter_TYPE();
		EnterRule("TYPE", 21);
		TraceIn("TYPE", 21);
		try
		{
			int _type = TYPE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:171:5: ( 'int' | 'bool' | 'char' )
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
				// MathLang.g:171:7: 'int'
				{
				DebugLocation(171, 7);
				Match("int"); 


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:171:15: 'bool'
				{
				DebugLocation(171, 15);
				Match("bool"); 


				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:171:24: 'char'
				{
				DebugLocation(171, 24);
				Match("char"); 


				}
				break;

			}
			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TYPE", 21);
			LeaveRule("TYPE", 21);
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
		EnterRule("VOID", 22);
		TraceIn("VOID", 22);
		try
		{
			int _type = VOID;
			int _channel = DefaultTokenChannel;
			// MathLang.g:172:5: ( 'void' )
			DebugEnterAlt(1);
			// MathLang.g:172:7: 'void'
			{
			DebugLocation(172, 7);
			Match("void"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("VOID", 22);
			LeaveRule("VOID", 22);
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
		EnterRule("NUMBER", 23);
		TraceIn("NUMBER", 23);
		try
		{
			int _type = NUMBER;
			int _channel = DefaultTokenChannel;
			// MathLang.g:173:7: ( ( '0' .. '9' )+ )
			DebugEnterAlt(1);
			// MathLang.g:173:9: ( '0' .. '9' )+
			{
			DebugLocation(173, 9);
			// MathLang.g:173:9: ( '0' .. '9' )+
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
					// MathLang.g:173:10: '0' .. '9'
					{
					DebugLocation(173, 10);
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
			TraceOut("NUMBER", 23);
			LeaveRule("NUMBER", 23);
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
		EnterRule("ADD", 24);
		TraceIn("ADD", 24);
		try
		{
			int _type = ADD;
			int _channel = DefaultTokenChannel;
			// MathLang.g:174:4: ( '+' )
			DebugEnterAlt(1);
			// MathLang.g:174:9: '+'
			{
			DebugLocation(174, 9);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ADD", 24);
			LeaveRule("ADD", 24);
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
		EnterRule("SUB", 25);
		TraceIn("SUB", 25);
		try
		{
			int _type = SUB;
			int _channel = DefaultTokenChannel;
			// MathLang.g:175:4: ( '-' )
			DebugEnterAlt(1);
			// MathLang.g:175:9: '-'
			{
			DebugLocation(175, 9);
			Match('-'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SUB", 25);
			LeaveRule("SUB", 25);
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
		EnterRule("MUL", 26);
		TraceIn("MUL", 26);
		try
		{
			int _type = MUL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:176:4: ( '*' )
			DebugEnterAlt(1);
			// MathLang.g:176:9: '*'
			{
			DebugLocation(176, 9);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MUL", 26);
			LeaveRule("MUL", 26);
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
		EnterRule("DIV", 27);
		TraceIn("DIV", 27);
		try
		{
			int _type = DIV;
			int _channel = DefaultTokenChannel;
			// MathLang.g:177:4: ( '/' )
			DebugEnterAlt(1);
			// MathLang.g:177:9: '/'
			{
			DebugLocation(177, 9);
			Match('/'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DIV", 27);
			LeaveRule("DIV", 27);
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
		EnterRule("ASSIGN", 28);
		TraceIn("ASSIGN", 28);
		try
		{
			int _type = ASSIGN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:178:7: ( '=' )
			DebugEnterAlt(1);
			// MathLang.g:178:9: '='
			{
			DebugLocation(178, 9);
			Match('='); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ASSIGN", 28);
			LeaveRule("ASSIGN", 28);
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
		EnterRule("RETURN", 29);
		TraceIn("RETURN", 29);
		try
		{
			int _type = RETURN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:179:7: ( 'return' )
			DebugEnterAlt(1);
			// MathLang.g:179:9: 'return'
			{
			DebugLocation(179, 9);
			Match("return"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RETURN", 29);
			LeaveRule("RETURN", 29);
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
		EnterRule("TRUE", 30);
		TraceIn("TRUE", 30);
		try
		{
			int _type = TRUE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:180:5: ( 'true' )
			DebugEnterAlt(1);
			// MathLang.g:180:9: 'true'
			{
			DebugLocation(180, 9);
			Match("true"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TRUE", 30);
			LeaveRule("TRUE", 30);
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
		EnterRule("FALSE", 31);
		TraceIn("FALSE", 31);
		try
		{
			int _type = FALSE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:181:6: ( 'false' )
			DebugEnterAlt(1);
			// MathLang.g:181:9: 'false'
			{
			DebugLocation(181, 9);
			Match("false"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FALSE", 31);
			LeaveRule("FALSE", 31);
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
		EnterRule("EQ", 32);
		TraceIn("EQ", 32);
		try
		{
			int _type = EQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:182:3: ( '==' )
			DebugEnterAlt(1);
			// MathLang.g:182:6: '=='
			{
			DebugLocation(182, 6);
			Match("=="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EQ", 32);
			LeaveRule("EQ", 32);
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
		EnterRule("NEQ", 33);
		TraceIn("NEQ", 33);
		try
		{
			int _type = NEQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:183:4: ( '!=' )
			DebugEnterAlt(1);
			// MathLang.g:183:6: '!='
			{
			DebugLocation(183, 6);
			Match("!="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NEQ", 33);
			LeaveRule("NEQ", 33);
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
		EnterRule("GR", 34);
		TraceIn("GR", 34);
		try
		{
			int _type = GR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:184:3: ( '>' )
			DebugEnterAlt(1);
			// MathLang.g:184:6: '>'
			{
			DebugLocation(184, 6);
			Match('>'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GR", 34);
			LeaveRule("GR", 34);
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
		EnterRule("GREQ", 35);
		TraceIn("GREQ", 35);
		try
		{
			int _type = GREQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:185:5: ( '>=' )
			DebugEnterAlt(1);
			// MathLang.g:185:9: '>='
			{
			DebugLocation(185, 9);
			Match(">="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GREQ", 35);
			LeaveRule("GREQ", 35);
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
		EnterRule("LS", 36);
		TraceIn("LS", 36);
		try
		{
			int _type = LS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:186:3: ( '<' )
			DebugEnterAlt(1);
			// MathLang.g:186:6: '<'
			{
			DebugLocation(186, 6);
			Match('<'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LS", 36);
			LeaveRule("LS", 36);
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
		EnterRule("LSEQ", 37);
		TraceIn("LSEQ", 37);
		try
		{
			int _type = LSEQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:187:5: ( '<=' )
			DebugEnterAlt(1);
			// MathLang.g:187:7: '<='
			{
			DebugLocation(187, 7);
			Match("<="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LSEQ", 37);
			LeaveRule("LSEQ", 37);
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
		EnterRule("NOT", 38);
		TraceIn("NOT", 38);
		try
		{
			int _type = NOT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:188:4: ( '!' )
			DebugEnterAlt(1);
			// MathLang.g:188:6: '!'
			{
			DebugLocation(188, 6);
			Match('!'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NOT", 38);
			LeaveRule("NOT", 38);
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
		EnterRule("OR", 39);
		TraceIn("OR", 39);
		try
		{
			int _type = OR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:189:3: ( '||' )
			DebugEnterAlt(1);
			// MathLang.g:189:6: '||'
			{
			DebugLocation(189, 6);
			Match("||"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OR", 39);
			LeaveRule("OR", 39);
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
		EnterRule("AND", 40);
		TraceIn("AND", 40);
		try
		{
			int _type = AND;
			int _channel = DefaultTokenChannel;
			// MathLang.g:190:4: ( '&&' )
			DebugEnterAlt(1);
			// MathLang.g:190:6: '&&'
			{
			DebugLocation(190, 6);
			Match("&&"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("AND", 40);
			LeaveRule("AND", 40);
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
		EnterRule("WS", 41);
		TraceIn("WS", 41);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:191:3: ( ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+ )
			DebugEnterAlt(1);
			// MathLang.g:192:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			{
			DebugLocation(192, 3);
			// MathLang.g:192:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
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
					DebugLocation(192, 3);
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

			DebugLocation(192, 41);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 41);
			LeaveRule("WS", 41);
			Leave_WS();
		}
	}
	// $ANTLR end "WS"

	partial void Enter_DOT();
	partial void Leave_DOT();

	// $ANTLR start "DOT"
	[GrammarRule("DOT")]
	private void mDOT()
	{
		Enter_DOT();
		EnterRule("DOT", 42);
		TraceIn("DOT", 42);
		try
		{
			int _type = DOT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:196:4: ( '.' )
			DebugEnterAlt(1);
			// MathLang.g:196:6: '.'
			{
			DebugLocation(196, 6);
			Match('.'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DOT", 42);
			LeaveRule("DOT", 42);
			Leave_DOT();
		}
	}
	// $ANTLR end "DOT"

	partial void Enter_MODIFIER();
	partial void Leave_MODIFIER();

	// $ANTLR start "MODIFIER"
	[GrammarRule("MODIFIER")]
	private void mMODIFIER()
	{
		Enter_MODIFIER();
		EnterRule("MODIFIER", 43);
		TraceIn("MODIFIER", 43);
		try
		{
			int _type = MODIFIER;
			int _channel = DefaultTokenChannel;
			// MathLang.g:197:9: ( 'static' )
			DebugEnterAlt(1);
			// MathLang.g:197:11: 'static'
			{
			DebugLocation(197, 11);
			Match("static"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MODIFIER", 43);
			LeaveRule("MODIFIER", 43);
			Leave_MODIFIER();
		}
	}
	// $ANTLR end "MODIFIER"

	partial void Enter_CHAR();
	partial void Leave_CHAR();

	// $ANTLR start "CHAR"
	[GrammarRule("CHAR")]
	private void mCHAR()
	{
		Enter_CHAR();
		EnterRule("CHAR", 44);
		TraceIn("CHAR", 44);
		try
		{
			int _type = CHAR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:199:5: ( '\\'' . '\\'' )
			DebugEnterAlt(1);
			// MathLang.g:199:8: '\\'' . '\\''
			{
			DebugLocation(199, 8);
			Match('\''); 
			DebugLocation(199, 13);
			MatchAny(); 
			DebugLocation(199, 15);
			Match('\''); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CHAR", 44);
			LeaveRule("CHAR", 44);
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
		EnterRule("ID", 45);
		TraceIn("ID", 45);
		try
		{
			int _type = ID;
			int _channel = DefaultTokenChannel;
			// MathLang.g:200:3: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )* )
			DebugEnterAlt(1);
			// MathLang.g:200:6: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )*
			{
			DebugLocation(200, 6);
			if ((input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z'))
			{
				input.Consume();

			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;}

			DebugLocation(201, 9);
			// MathLang.g:201:9: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_0 = input.LA(1);

				if (((LA4_0>='0' && LA4_0<='9')||(LA4_0>='A' && LA4_0<='Z')||LA4_0=='_'||(LA4_0>='a' && LA4_0<='z')))
				{
					alt4=1;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:
					{
					DebugLocation(201, 9);
					if ((input.LA(1)>='0' && input.LA(1)<='9')||(input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z'))
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
					goto loop4;
				}
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
			TraceOut("ID", 45);
			LeaveRule("ID", 45);
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
		EnterRule("SL_COMMENT", 46);
		TraceIn("SL_COMMENT", 46);
		try
		{
			int _type = SL_COMMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:205:11: ( '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n' )
			DebugEnterAlt(1);
			// MathLang.g:206:3: '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n'
			{
			DebugLocation(206, 3);
			Match("//"); 

			DebugLocation(206, 8);
			// MathLang.g:206:8: ( options {greedy=false; } : . )*
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
					// MathLang.g:206:36: .
					{
					DebugLocation(206, 36);
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

			DebugLocation(206, 40);
			// MathLang.g:206:40: ( '\\r' )?
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
				// MathLang.g:206:40: '\\r'
				{
				DebugLocation(206, 40);
				Match('\r'); 

				}
				break;

			}
			} finally { DebugExitSubRule(6); }

			DebugLocation(206, 46);
			Match('\n'); 
			DebugLocation(206, 51);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SL_COMMENT", 46);
			LeaveRule("SL_COMMENT", 46);
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
		EnterRule("ML_COMMENT", 47);
		TraceIn("ML_COMMENT", 47);
		try
		{
			int _type = ML_COMMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:210:11: ( '/*' ( options {greedy=false; } : . )* '*/' )
			DebugEnterAlt(1);
			// MathLang.g:211:3: '/*' ( options {greedy=false; } : . )* '*/'
			{
			DebugLocation(211, 3);
			Match("/*"); 

			DebugLocation(211, 8);
			// MathLang.g:211:8: ( options {greedy=false; } : . )*
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
					// MathLang.g:211:36: .
					{
					DebugLocation(211, 36);
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

			DebugLocation(211, 40);
			Match("*/"); 

			DebugLocation(211, 45);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ML_COMMENT", 47);
			LeaveRule("ML_COMMENT", 47);
			Leave_ML_COMMENT();
		}
	}
	// $ANTLR end "ML_COMMENT"

	public override void mTokens()
	{
		// MathLang.g:1:8: ( PRINT | INPUT | IF | ELSE | FOR | FUNCTION | WHILE | DO | CLASS_WORD | T__66 | T__67 | T__68 | T__69 | KNEW | CONSOLE_WORD | ARRAY_DECLARATION_MARK | OPEN_SQUARE_BRACE | CLOSE_SQUARE_BRACE | OPEN_BRACE | CLOSE_BRACE | TYPE | VOID | NUMBER | ADD | SUB | MUL | DIV | ASSIGN | RETURN | TRUE | FALSE | EQ | NEQ | GR | GREQ | LS | LSEQ | NOT | OR | AND | WS | DOT | MODIFIER | CHAR | ID | SL_COMMENT | ML_COMMENT )
		int alt8=47;
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
			// MathLang.g:1:52: CLASS_WORD
			{
			DebugLocation(1, 52);
			mCLASS_WORD(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// MathLang.g:1:63: T__66
			{
			DebugLocation(1, 63);
			mT__66(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// MathLang.g:1:69: T__67
			{
			DebugLocation(1, 69);
			mT__67(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// MathLang.g:1:75: T__68
			{
			DebugLocation(1, 75);
			mT__68(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// MathLang.g:1:81: T__69
			{
			DebugLocation(1, 81);
			mT__69(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// MathLang.g:1:87: KNEW
			{
			DebugLocation(1, 87);
			mKNEW(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// MathLang.g:1:92: CONSOLE_WORD
			{
			DebugLocation(1, 92);
			mCONSOLE_WORD(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// MathLang.g:1:105: ARRAY_DECLARATION_MARK
			{
			DebugLocation(1, 105);
			mARRAY_DECLARATION_MARK(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// MathLang.g:1:128: OPEN_SQUARE_BRACE
			{
			DebugLocation(1, 128);
			mOPEN_SQUARE_BRACE(); 

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// MathLang.g:1:146: CLOSE_SQUARE_BRACE
			{
			DebugLocation(1, 146);
			mCLOSE_SQUARE_BRACE(); 

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// MathLang.g:1:165: OPEN_BRACE
			{
			DebugLocation(1, 165);
			mOPEN_BRACE(); 

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// MathLang.g:1:176: CLOSE_BRACE
			{
			DebugLocation(1, 176);
			mCLOSE_BRACE(); 

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// MathLang.g:1:188: TYPE
			{
			DebugLocation(1, 188);
			mTYPE(); 

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// MathLang.g:1:193: VOID
			{
			DebugLocation(1, 193);
			mVOID(); 

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// MathLang.g:1:198: NUMBER
			{
			DebugLocation(1, 198);
			mNUMBER(); 

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// MathLang.g:1:205: ADD
			{
			DebugLocation(1, 205);
			mADD(); 

			}
			break;
		case 25:
			DebugEnterAlt(25);
			// MathLang.g:1:209: SUB
			{
			DebugLocation(1, 209);
			mSUB(); 

			}
			break;
		case 26:
			DebugEnterAlt(26);
			// MathLang.g:1:213: MUL
			{
			DebugLocation(1, 213);
			mMUL(); 

			}
			break;
		case 27:
			DebugEnterAlt(27);
			// MathLang.g:1:217: DIV
			{
			DebugLocation(1, 217);
			mDIV(); 

			}
			break;
		case 28:
			DebugEnterAlt(28);
			// MathLang.g:1:221: ASSIGN
			{
			DebugLocation(1, 221);
			mASSIGN(); 

			}
			break;
		case 29:
			DebugEnterAlt(29);
			// MathLang.g:1:228: RETURN
			{
			DebugLocation(1, 228);
			mRETURN(); 

			}
			break;
		case 30:
			DebugEnterAlt(30);
			// MathLang.g:1:235: TRUE
			{
			DebugLocation(1, 235);
			mTRUE(); 

			}
			break;
		case 31:
			DebugEnterAlt(31);
			// MathLang.g:1:240: FALSE
			{
			DebugLocation(1, 240);
			mFALSE(); 

			}
			break;
		case 32:
			DebugEnterAlt(32);
			// MathLang.g:1:246: EQ
			{
			DebugLocation(1, 246);
			mEQ(); 

			}
			break;
		case 33:
			DebugEnterAlt(33);
			// MathLang.g:1:249: NEQ
			{
			DebugLocation(1, 249);
			mNEQ(); 

			}
			break;
		case 34:
			DebugEnterAlt(34);
			// MathLang.g:1:253: GR
			{
			DebugLocation(1, 253);
			mGR(); 

			}
			break;
		case 35:
			DebugEnterAlt(35);
			// MathLang.g:1:256: GREQ
			{
			DebugLocation(1, 256);
			mGREQ(); 

			}
			break;
		case 36:
			DebugEnterAlt(36);
			// MathLang.g:1:261: LS
			{
			DebugLocation(1, 261);
			mLS(); 

			}
			break;
		case 37:
			DebugEnterAlt(37);
			// MathLang.g:1:264: LSEQ
			{
			DebugLocation(1, 264);
			mLSEQ(); 

			}
			break;
		case 38:
			DebugEnterAlt(38);
			// MathLang.g:1:269: NOT
			{
			DebugLocation(1, 269);
			mNOT(); 

			}
			break;
		case 39:
			DebugEnterAlt(39);
			// MathLang.g:1:273: OR
			{
			DebugLocation(1, 273);
			mOR(); 

			}
			break;
		case 40:
			DebugEnterAlt(40);
			// MathLang.g:1:276: AND
			{
			DebugLocation(1, 276);
			mAND(); 

			}
			break;
		case 41:
			DebugEnterAlt(41);
			// MathLang.g:1:280: WS
			{
			DebugLocation(1, 280);
			mWS(); 

			}
			break;
		case 42:
			DebugEnterAlt(42);
			// MathLang.g:1:283: DOT
			{
			DebugLocation(1, 283);
			mDOT(); 

			}
			break;
		case 43:
			DebugEnterAlt(43);
			// MathLang.g:1:287: MODIFIER
			{
			DebugLocation(1, 287);
			mMODIFIER(); 

			}
			break;
		case 44:
			DebugEnterAlt(44);
			// MathLang.g:1:296: CHAR
			{
			DebugLocation(1, 296);
			mCHAR(); 

			}
			break;
		case 45:
			DebugEnterAlt(45);
			// MathLang.g:1:301: ID
			{
			DebugLocation(1, 301);
			mID(); 

			}
			break;
		case 46:
			DebugEnterAlt(46);
			// MathLang.g:1:304: SL_COMMENT
			{
			DebugLocation(1, 304);
			mSL_COMMENT(); 

			}
			break;
		case 47:
			DebugEnterAlt(47);
			// MathLang.g:1:315: ML_COMMENT
			{
			DebugLocation(1, 315);
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
			"\x1\xFFFF\x7\x25\x4\xFFFF\x2\x25\x1\x33\x3\xFFFF\x2\x25\x4\xFFFF\x1"+
			"\x39\x1\x3B\x2\x25\x1\x3F\x1\x41\x1\x43\x4\xFFFF\x1\x25\x2\xFFFF\x2\x25"+
			"\x1\x48\x5\x25\x1\x4E\x4\x25\x2\xFFFF\x2\x25\x5\xFFFF\x2\x25\x6\xFFFF"+
			"\x3\x25\x1\x5A\x1\xFFFF\x1\x25\x1\x5C\x3\x25\x1\xFFFF\x2\x25\x1\x62\x8"+
			"\x25\x1\xFFFF\x1\x6B\x1\xFFFF\x4\x25\x1\x5A\x1\xFFFF\x1\x25\x1\x5A\x1"+
			"\x71\x1\x25\x1\x73\x1\x25\x1\x75\x1\x76\x1\xFFFF\x1\x25\x1\x78\x1\x79"+
			"\x1\x7A\x1\x25\x1\xFFFF\x1\x25\x1\xFFFF\x1\x25\x2\xFFFF\x1\x25\x3\xFFFF"+
			"\x1\x25\x1\x80\x1\x81\x1\x25\x1\x83\x2\xFFFF\x1\x84\x2\xFFFF";
		private const string DFA8_eofS =
			"\x85\xFFFF";
		private const string DFA8_minS =
			"\x1\x9\x1\x72\x1\x66\x1\x6C\x1\x61\x1\x68\x1\x6F\x1\x68\x4\xFFFF\x1"+
			"\x65\x1\x6F\x1\x5D\x3\xFFFF\x2\x6F\x4\xFFFF\x1\x2A\x1\x3D\x1\x65\x1\x72"+
			"\x3\x3D\x4\xFFFF\x1\x74\x2\xFFFF\x1\x69\x1\x70\x1\x30\x1\x73\x1\x72\x1"+
			"\x6E\x1\x6C\x1\x69\x1\x30\x2\x61\x1\x77\x1\x6E\x2\xFFFF\x1\x6F\x1\x69"+
			"\x5\xFFFF\x1\x74\x1\x75\x6\xFFFF\x1\x61\x1\x6E\x1\x75\x1\x30\x1\xFFFF"+
			"\x1\x65\x1\x30\x1\x63\x1\x73\x1\x6C\x1\xFFFF\x1\x73\x1\x72\x1\x30\x1"+
			"\x73\x1\x6C\x1\x64\x1\x75\x1\x65\x3\x74\x1\xFFFF\x1\x30\x1\xFFFF\x1\x74"+
			"\x2\x65\x1\x73\x1\x30\x1\xFFFF\x1\x6F\x2\x30\x1\x72\x1\x30\x1\x69\x2"+
			"\x30\x1\xFFFF\x1\x69\x3\x30\x1\x6C\x1\xFFFF\x1\x6E\x1\xFFFF\x1\x63\x2"+
			"\xFFFF\x1\x6F\x3\xFFFF\x1\x65\x2\x30\x1\x6E\x1\x30\x2\xFFFF\x1\x30\x2"+
			"\xFFFF";
		private const string DFA8_maxS =
			"\x1\x7D\x1\x72\x1\x6E\x1\x6C\x1\x75\x1\x68\x1\x6F\x1\x6C\x4\xFFFF\x1"+
			"\x65\x1\x6F\x1\x5D\x3\xFFFF\x2\x6F\x4\xFFFF\x1\x2F\x1\x3D\x1\x65\x1\x72"+
			"\x3\x3D\x4\xFFFF\x1\x74\x2\xFFFF\x1\x69\x1\x74\x1\x7A\x1\x73\x1\x72\x1"+
			"\x6E\x1\x6C\x1\x69\x1\x7A\x2\x61\x1\x77\x1\x6E\x2\xFFFF\x1\x6F\x1\x69"+
			"\x5\xFFFF\x1\x74\x1\x75\x6\xFFFF\x1\x61\x1\x6E\x1\x75\x1\x7A\x1\xFFFF"+
			"\x1\x65\x1\x7A\x1\x63\x1\x73\x1\x6C\x1\xFFFF\x1\x73\x1\x72\x1\x7A\x1"+
			"\x73\x1\x6C\x1\x64\x1\x75\x1\x65\x3\x74\x1\xFFFF\x1\x7A\x1\xFFFF\x1\x74"+
			"\x2\x65\x1\x73\x1\x7A\x1\xFFFF\x1\x6F\x2\x7A\x1\x72\x1\x7A\x1\x69\x2"+
			"\x7A\x1\xFFFF\x1\x69\x3\x7A\x1\x6C\x1\xFFFF\x1\x6E\x1\xFFFF\x1\x63\x2"+
			"\xFFFF\x1\x6F\x3\xFFFF\x1\x65\x2\x7A\x1\x6E\x1\x7A\x2\xFFFF\x1\x7A\x2"+
			"\xFFFF";
		private const string DFA8_acceptS =
			"\x8\xFFFF\x1\xA\x1\xB\x1\xC\x1\xD\x3\xFFFF\x1\x12\x1\x13\x1\x14\x2\xFFFF"+
			"\x1\x17\x1\x18\x1\x19\x1\x1A\x7\xFFFF\x1\x27\x1\x28\x1\x29\x1\x2A\x1"+
			"\xFFFF\x1\x2C\x1\x2D\xD\xFFFF\x1\x11\x1\x10\x2\xFFFF\x1\x2E\x1\x2F\x1"+
			"\x1B\x1\x20\x1\x1C\x2\xFFFF\x1\x21\x1\x26\x1\x23\x1\x22\x1\x25\x1\x24"+
			"\x4\xFFFF\x1\x3\x5\xFFFF\x1\x8\xB\xFFFF\x1\x15\x1\xFFFF\x1\x5\x5\xFFFF"+
			"\x1\xE\x8\xFFFF\x1\x4\x5\xFFFF\x1\x16\x1\xFFFF\x1\x1E\x1\xFFFF\x1\x1"+
			"\x1\x2\x1\xFFFF\x1\x1F\x1\x7\x1\x9\x5\xFFFF\x1\x1D\x1\x2B\x1\xFFFF\x1"+
			"\xF\x1\x6";
		private const string DFA8_specialS =
			"\x85\xFFFF}>";
		private static readonly string[] DFA8_transitionS =
			{
				"\x2\x21\x1\xFFFF\x2\x21\x12\xFFFF\x1\x21\x1\x1C\x4\xFFFF\x1\x20\x1"+
				"\x24\x1\x10\x1\x11\x1\x17\x1\x15\x1\xB\x1\x16\x1\x22\x1\x18\xA\x14\x1"+
				"\xFFFF\x1\xA\x1\x1E\x1\x19\x1\x1D\x2\xFFFF\x2\x25\x1\xD\x17\x25\x1\xE"+
				"\x1\xFFFF\x1\xF\x1\xFFFF\x1\x25\x1\xFFFF\x1\x25\x1\x12\x1\x7\x1\x6\x1"+
				"\x3\x1\x4\x2\x25\x1\x2\x4\x25\x1\xC\x1\x25\x1\x1\x1\x25\x1\x1A\x1\x23"+
				"\x1\x1B\x1\x25\x1\x13\x1\x5\x3\x25\x1\x8\x1\x1F\x1\x9",
				"\x1\x26",
				"\x1\x28\x7\xFFFF\x1\x27",
				"\x1\x29",
				"\x1\x2C\xD\xFFFF\x1\x2A\x5\xFFFF\x1\x2B",
				"\x1\x2D",
				"\x1\x2E",
				"\x1\x30\x3\xFFFF\x1\x2F",
				"",
				"",
				"",
				"",
				"\x1\x31",
				"\x1\x32",
				"\x1\x34",
				"",
				"",
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
				"\x1\x44",
				"",
				"",
				"\x1\x45",
				"\x1\x46\x3\xFFFF\x1\x47",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\x49",
				"\x1\x4A",
				"\x1\x4B",
				"\x1\x4C",
				"\x1\x4D",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\x4F",
				"\x1\x50",
				"\x1\x51",
				"\x1\x52",
				"",
				"",
				"\x1\x53",
				"\x1\x54",
				"",
				"",
				"",
				"",
				"",
				"\x1\x55",
				"\x1\x56",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x57",
				"\x1\x58",
				"\x1\x59",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"",
				"\x1\x5B",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\x5D",
				"\x1\x5E",
				"\x1\x5F",
				"",
				"\x1\x60",
				"\x1\x61",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\x63",
				"\x1\x64",
				"\x1\x65",
				"\x1\x66",
				"\x1\x67",
				"\x1\x68",
				"\x1\x69",
				"\x1\x6A",
				"",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"",
				"\x1\x6C",
				"\x1\x6D",
				"\x1\x6E",
				"\x1\x6F",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"",
				"\x1\x70",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\x72",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\x74",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"",
				"\x1\x77",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\x7B",
				"",
				"\x1\x7C",
				"",
				"\x1\x7D",
				"",
				"",
				"\x1\x7E",
				"",
				"",
				"",
				"\x1\x7F",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\x82",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"",
				"",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"",
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

		public override string Description { get { return "1:1: Tokens : ( PRINT | INPUT | IF | ELSE | FOR | FUNCTION | WHILE | DO | CLASS_WORD | T__66 | T__67 | T__68 | T__69 | KNEW | CONSOLE_WORD | ARRAY_DECLARATION_MARK | OPEN_SQUARE_BRACE | CLOSE_SQUARE_BRACE | OPEN_BRACE | CLOSE_BRACE | TYPE | VOID | NUMBER | ADD | SUB | MUL | DIV | ASSIGN | RETURN | TRUE | FALSE | EQ | NEQ | GR | GREQ | LS | LSEQ | NOT | OR | AND | WS | DOT | MODIFIER | CHAR | ID | SL_COMMENT | ML_COMMENT );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}

} // namespace  MathLang 

// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-10-01 12:57:58

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
	public const int T__39=39;
	public const int T__40=40;
	public const int T__41=41;
	public const int UNKNOWN=4;
	public const int PRINT=5;
	public const int INPUT=6;
	public const int IF=7;
	public const int FOR=8;
	public const int FUNCTION=9;
	public const int RETURN=10;
	public const int WHILE=11;
	public const int BLOCK=12;
	public const int PROGRAM=13;
	public const int PARAMS=14;
	public const int VAR=15;
	public const int NUMBER=16;
	public const int ID=17;
	public const int TYPE=18;
	public const int ASSIGN=19;
	public const int ARRAY=20;
	public const int ADD=21;
	public const int SUB=22;
	public const int MUL=23;
	public const int DIV=24;
	public const int GREQ=25;
	public const int LSEQ=26;
	public const int NEQ=27;
	public const int EQ=28;
	public const int GR=29;
	public const int LS=30;
	public const int OR=31;
	public const int AND=32;
	public const int TRUE=33;
	public const int FALSE=34;
	public const int ACCESS_MODIFIER=35;
	public const int WS=36;
	public const int SL_COMMENT=37;
	public const int ML_COMMENT=38;

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

	partial void Enter_FOR();
	partial void Leave_FOR();

	// $ANTLR start "FOR"
	[GrammarRule("FOR")]
	private void mFOR()
	{
		Enter_FOR();
		EnterRule("FOR", 4);
		TraceIn("FOR", 4);
		try
		{
			int _type = FOR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:12:5: ( 'for' )
			DebugEnterAlt(1);
			// MathLang.g:12:7: 'for'
			{
			DebugLocation(12, 7);
			Match("for"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FOR", 4);
			LeaveRule("FOR", 4);
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
		EnterRule("FUNCTION", 5);
		TraceIn("FUNCTION", 5);
		try
		{
			int _type = FUNCTION;
			int _channel = DefaultTokenChannel;
			// MathLang.g:13:10: ( 'function' )
			DebugEnterAlt(1);
			// MathLang.g:13:12: 'function'
			{
			DebugLocation(13, 12);
			Match("function"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FUNCTION", 5);
			LeaveRule("FUNCTION", 5);
			Leave_FUNCTION();
		}
	}
	// $ANTLR end "FUNCTION"

	partial void Enter_RETURN();
	partial void Leave_RETURN();

	// $ANTLR start "RETURN"
	[GrammarRule("RETURN")]
	private void mRETURN()
	{
		Enter_RETURN();
		EnterRule("RETURN", 6);
		TraceIn("RETURN", 6);
		try
		{
			int _type = RETURN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:14:8: ( 'return' )
			DebugEnterAlt(1);
			// MathLang.g:14:10: 'return'
			{
			DebugLocation(14, 10);
			Match("return"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RETURN", 6);
			LeaveRule("RETURN", 6);
			Leave_RETURN();
		}
	}
	// $ANTLR end "RETURN"

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

	partial void Enter_T__39();
	partial void Leave_T__39();

	// $ANTLR start "T__39"
	[GrammarRule("T__39")]
	private void mT__39()
	{
		Enter_T__39();
		EnterRule("T__39", 8);
		TraceIn("T__39", 8);
		try
		{
			int _type = T__39;
			int _channel = DefaultTokenChannel;
			// MathLang.g:16:7: ( ';' )
			DebugEnterAlt(1);
			// MathLang.g:16:9: ';'
			{
			DebugLocation(16, 9);
			Match(';'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__39", 8);
			LeaveRule("T__39", 8);
			Leave_T__39();
		}
	}
	// $ANTLR end "T__39"

	partial void Enter_T__40();
	partial void Leave_T__40();

	// $ANTLR start "T__40"
	[GrammarRule("T__40")]
	private void mT__40()
	{
		Enter_T__40();
		EnterRule("T__40", 9);
		TraceIn("T__40", 9);
		try
		{
			int _type = T__40;
			int _channel = DefaultTokenChannel;
			// MathLang.g:17:7: ( '(' )
			DebugEnterAlt(1);
			// MathLang.g:17:9: '('
			{
			DebugLocation(17, 9);
			Match('('); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__40", 9);
			LeaveRule("T__40", 9);
			Leave_T__40();
		}
	}
	// $ANTLR end "T__40"

	partial void Enter_T__41();
	partial void Leave_T__41();

	// $ANTLR start "T__41"
	[GrammarRule("T__41")]
	private void mT__41()
	{
		Enter_T__41();
		EnterRule("T__41", 10);
		TraceIn("T__41", 10);
		try
		{
			int _type = T__41;
			int _channel = DefaultTokenChannel;
			// MathLang.g:18:7: ( ')' )
			DebugEnterAlt(1);
			// MathLang.g:18:9: ')'
			{
			DebugLocation(18, 9);
			Match(')'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__41", 10);
			LeaveRule("T__41", 10);
			Leave_T__41();
		}
	}
	// $ANTLR end "T__41"

	partial void Enter_ARRAY();
	partial void Leave_ARRAY();

	// $ANTLR start "ARRAY"
	[GrammarRule("ARRAY")]
	private void mARRAY()
	{
		Enter_ARRAY();
		EnterRule("ARRAY", 11);
		TraceIn("ARRAY", 11);
		try
		{
			int _type = ARRAY;
			int _channel = DefaultTokenChannel;
			// MathLang.g:77:6: ( ( TYPE '[]' ) )
			DebugEnterAlt(1);
			// MathLang.g:77:8: ( TYPE '[]' )
			{
			DebugLocation(77, 8);
			// MathLang.g:77:8: ( TYPE '[]' )
			DebugEnterAlt(1);
			// MathLang.g:77:9: TYPE '[]'
			{
			DebugLocation(77, 9);
			mTYPE(); 
			DebugLocation(77, 14);
			Match("[]"); 


			}


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ARRAY", 11);
			LeaveRule("ARRAY", 11);
			Leave_ARRAY();
		}
	}
	// $ANTLR end "ARRAY"

	partial void Enter_TYPE();
	partial void Leave_TYPE();

	// $ANTLR start "TYPE"
	[GrammarRule("TYPE")]
	private void mTYPE()
	{
		Enter_TYPE();
		EnterRule("TYPE", 12);
		TraceIn("TYPE", 12);
		try
		{
			int _type = TYPE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:78:5: ( 'int' | 'bool' | 'char' )
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
				// MathLang.g:78:7: 'int'
				{
				DebugLocation(78, 7);
				Match("int"); 


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:78:15: 'bool'
				{
				DebugLocation(78, 15);
				Match("bool"); 


				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:78:24: 'char'
				{
				DebugLocation(78, 24);
				Match("char"); 


				}
				break;

			}
			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TYPE", 12);
			LeaveRule("TYPE", 12);
			Leave_TYPE();
		}
	}
	// $ANTLR end "TYPE"

	partial void Enter_ACCESS_MODIFIER();
	partial void Leave_ACCESS_MODIFIER();

	// $ANTLR start "ACCESS_MODIFIER"
	[GrammarRule("ACCESS_MODIFIER")]
	private void mACCESS_MODIFIER()
	{
		Enter_ACCESS_MODIFIER();
		EnterRule("ACCESS_MODIFIER", 13);
		TraceIn("ACCESS_MODIFIER", 13);
		try
		{
			int _type = ACCESS_MODIFIER;
			int _channel = DefaultTokenChannel;
			// MathLang.g:79:16: ( 'public' | 'private' )
			int alt2=2;
			try { DebugEnterDecision(2, decisionCanBacktrack[2]);
			int LA2_0 = input.LA(1);

			if ((LA2_0=='p'))
			{
				int LA2_1 = input.LA(2);

				if ((LA2_1=='u'))
				{
					alt2=1;
				}
				else if ((LA2_1=='r'))
				{
					alt2=2;
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 2, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 2, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(2); }
			switch (alt2)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:79:18: 'public'
				{
				DebugLocation(79, 18);
				Match("public"); 


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:79:29: 'private'
				{
				DebugLocation(79, 29);
				Match("private"); 


				}
				break;

			}
			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ACCESS_MODIFIER", 13);
			LeaveRule("ACCESS_MODIFIER", 13);
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
		EnterRule("NUMBER", 14);
		TraceIn("NUMBER", 14);
		try
		{
			int _type = NUMBER;
			int _channel = DefaultTokenChannel;
			// MathLang.g:80:7: ( ( '0' .. '9' )+ )
			DebugEnterAlt(1);
			// MathLang.g:80:9: ( '0' .. '9' )+
			{
			DebugLocation(80, 9);
			// MathLang.g:80:9: ( '0' .. '9' )+
			int cnt3=0;
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=2;
				try { DebugEnterDecision(3, decisionCanBacktrack[3]);
				int LA3_0 = input.LA(1);

				if (((LA3_0>='0' && LA3_0<='9')))
				{
					alt3=1;
				}


				} finally { DebugExitDecision(3); }
				switch (alt3)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:80:10: '0' .. '9'
					{
					DebugLocation(80, 10);
					MatchRange('0','9'); 

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


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NUMBER", 14);
			LeaveRule("NUMBER", 14);
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
		EnterRule("ADD", 15);
		TraceIn("ADD", 15);
		try
		{
			int _type = ADD;
			int _channel = DefaultTokenChannel;
			// MathLang.g:81:4: ( '+' )
			DebugEnterAlt(1);
			// MathLang.g:81:9: '+'
			{
			DebugLocation(81, 9);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ADD", 15);
			LeaveRule("ADD", 15);
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
		EnterRule("SUB", 16);
		TraceIn("SUB", 16);
		try
		{
			int _type = SUB;
			int _channel = DefaultTokenChannel;
			// MathLang.g:82:4: ( '-' )
			DebugEnterAlt(1);
			// MathLang.g:82:9: '-'
			{
			DebugLocation(82, 9);
			Match('-'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SUB", 16);
			LeaveRule("SUB", 16);
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
		EnterRule("MUL", 17);
		TraceIn("MUL", 17);
		try
		{
			int _type = MUL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:83:4: ( '*' )
			DebugEnterAlt(1);
			// MathLang.g:83:9: '*'
			{
			DebugLocation(83, 9);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MUL", 17);
			LeaveRule("MUL", 17);
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
		EnterRule("DIV", 18);
		TraceIn("DIV", 18);
		try
		{
			int _type = DIV;
			int _channel = DefaultTokenChannel;
			// MathLang.g:84:4: ( '/' )
			DebugEnterAlt(1);
			// MathLang.g:84:9: '/'
			{
			DebugLocation(84, 9);
			Match('/'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DIV", 18);
			LeaveRule("DIV", 18);
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
		EnterRule("ASSIGN", 19);
		TraceIn("ASSIGN", 19);
		try
		{
			int _type = ASSIGN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:85:7: ( '=' )
			DebugEnterAlt(1);
			// MathLang.g:85:9: '='
			{
			DebugLocation(85, 9);
			Match('='); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ASSIGN", 19);
			LeaveRule("ASSIGN", 19);
			Leave_ASSIGN();
		}
	}
	// $ANTLR end "ASSIGN"

	partial void Enter_TRUE();
	partial void Leave_TRUE();

	// $ANTLR start "TRUE"
	[GrammarRule("TRUE")]
	private void mTRUE()
	{
		Enter_TRUE();
		EnterRule("TRUE", 20);
		TraceIn("TRUE", 20);
		try
		{
			int _type = TRUE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:87:5: ( 'true' )
			DebugEnterAlt(1);
			// MathLang.g:87:7: 'true'
			{
			DebugLocation(87, 7);
			Match("true"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TRUE", 20);
			LeaveRule("TRUE", 20);
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
		EnterRule("FALSE", 21);
		TraceIn("FALSE", 21);
		try
		{
			int _type = FALSE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:88:6: ( 'false' )
			DebugEnterAlt(1);
			// MathLang.g:88:8: 'false'
			{
			DebugLocation(88, 8);
			Match("false"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FALSE", 21);
			LeaveRule("FALSE", 21);
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
		EnterRule("EQ", 22);
		TraceIn("EQ", 22);
		try
		{
			int _type = EQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:89:3: ( '==' )
			DebugEnterAlt(1);
			// MathLang.g:89:6: '=='
			{
			DebugLocation(89, 6);
			Match("=="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EQ", 22);
			LeaveRule("EQ", 22);
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
		EnterRule("NEQ", 23);
		TraceIn("NEQ", 23);
		try
		{
			int _type = NEQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:90:4: ( '!=' )
			DebugEnterAlt(1);
			// MathLang.g:90:6: '!='
			{
			DebugLocation(90, 6);
			Match("!="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NEQ", 23);
			LeaveRule("NEQ", 23);
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
		EnterRule("GR", 24);
		TraceIn("GR", 24);
		try
		{
			int _type = GR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:91:3: ( '>' )
			DebugEnterAlt(1);
			// MathLang.g:91:6: '>'
			{
			DebugLocation(91, 6);
			Match('>'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GR", 24);
			LeaveRule("GR", 24);
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
		EnterRule("GREQ", 25);
		TraceIn("GREQ", 25);
		try
		{
			int _type = GREQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:92:5: ( '>=' )
			DebugEnterAlt(1);
			// MathLang.g:92:9: '>='
			{
			DebugLocation(92, 9);
			Match(">="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GREQ", 25);
			LeaveRule("GREQ", 25);
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
		EnterRule("LS", 26);
		TraceIn("LS", 26);
		try
		{
			int _type = LS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:93:3: ( '<' )
			DebugEnterAlt(1);
			// MathLang.g:93:6: '<'
			{
			DebugLocation(93, 6);
			Match('<'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LS", 26);
			LeaveRule("LS", 26);
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
		EnterRule("LSEQ", 27);
		TraceIn("LSEQ", 27);
		try
		{
			int _type = LSEQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:94:5: ( '<=' )
			DebugEnterAlt(1);
			// MathLang.g:94:7: '<='
			{
			DebugLocation(94, 7);
			Match("<="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LSEQ", 27);
			LeaveRule("LSEQ", 27);
			Leave_LSEQ();
		}
	}
	// $ANTLR end "LSEQ"

	partial void Enter_OR();
	partial void Leave_OR();

	// $ANTLR start "OR"
	[GrammarRule("OR")]
	private void mOR()
	{
		Enter_OR();
		EnterRule("OR", 28);
		TraceIn("OR", 28);
		try
		{
			int _type = OR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:96:3: ( '||' )
			DebugEnterAlt(1);
			// MathLang.g:96:6: '||'
			{
			DebugLocation(96, 6);
			Match("||"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OR", 28);
			LeaveRule("OR", 28);
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
		EnterRule("AND", 29);
		TraceIn("AND", 29);
		try
		{
			int _type = AND;
			int _channel = DefaultTokenChannel;
			// MathLang.g:97:4: ( '&&' )
			DebugEnterAlt(1);
			// MathLang.g:97:6: '&&'
			{
			DebugLocation(97, 6);
			Match("&&"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("AND", 29);
			LeaveRule("AND", 29);
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
		EnterRule("WS", 30);
		TraceIn("WS", 30);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:98:3: ( ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+ )
			DebugEnterAlt(1);
			// MathLang.g:99:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			{
			DebugLocation(99, 3);
			// MathLang.g:99:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			int cnt4=0;
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_0 = input.LA(1);

				if (((LA4_0>='\t' && LA4_0<='\n')||(LA4_0>='\f' && LA4_0<='\r')||LA4_0==' '))
				{
					alt4=1;
				}


				} finally { DebugExitDecision(4); }
				switch (alt4)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:
					{
					DebugLocation(99, 3);
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

			DebugLocation(99, 41);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 30);
			LeaveRule("WS", 30);
			Leave_WS();
		}
	}
	// $ANTLR end "WS"

	partial void Enter_ID();
	partial void Leave_ID();

	// $ANTLR start "ID"
	[GrammarRule("ID")]
	private void mID()
	{
		Enter_ID();
		EnterRule("ID", 31);
		TraceIn("ID", 31);
		try
		{
			int _type = ID;
			int _channel = DefaultTokenChannel;
			// MathLang.g:103:3: ( ( 'a' .. 'z' )+ )
			DebugEnterAlt(1);
			// MathLang.g:103:6: ( 'a' .. 'z' )+
			{
			DebugLocation(103, 6);
			// MathLang.g:103:6: ( 'a' .. 'z' )+
			int cnt5=0;
			try { DebugEnterSubRule(5);
			while (true)
			{
				int alt5=2;
				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
				int LA5_0 = input.LA(1);

				if (((LA5_0>='a' && LA5_0<='z')))
				{
					alt5=1;
				}


				} finally { DebugExitDecision(5); }
				switch (alt5)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:103:7: 'a' .. 'z'
					{
					DebugLocation(103, 7);
					MatchRange('a','z'); 

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
			TraceOut("ID", 31);
			LeaveRule("ID", 31);
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
		EnterRule("SL_COMMENT", 32);
		TraceIn("SL_COMMENT", 32);
		try
		{
			int _type = SL_COMMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:106:11: ( '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n' )
			DebugEnterAlt(1);
			// MathLang.g:107:3: '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n'
			{
			DebugLocation(107, 3);
			Match("//"); 

			DebugLocation(107, 8);
			// MathLang.g:107:8: ( options {greedy=false; } : . )*
			try { DebugEnterSubRule(6);
			while (true)
			{
				int alt6=2;
				try { DebugEnterDecision(6, decisionCanBacktrack[6]);
				int LA6_0 = input.LA(1);

				if ((LA6_0=='\r'))
				{
					alt6=2;
				}
				else if ((LA6_0=='\n'))
				{
					alt6=2;
				}
				else if (((LA6_0>='\u0000' && LA6_0<='\t')||(LA6_0>='\u000B' && LA6_0<='\f')||(LA6_0>='\u000E' && LA6_0<='\uFFFF')))
				{
					alt6=1;
				}


				} finally { DebugExitDecision(6); }
				switch ( alt6 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:107:36: .
					{
					DebugLocation(107, 36);
					MatchAny(); 

					}
					break;

				default:
					goto loop6;
				}
			}

			loop6:
				;

			} finally { DebugExitSubRule(6); }

			DebugLocation(107, 40);
			// MathLang.g:107:40: ( '\\r' )?
			int alt7=2;
			try { DebugEnterSubRule(7);
			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
			int LA7_0 = input.LA(1);

			if ((LA7_0=='\r'))
			{
				alt7=1;
			}
			} finally { DebugExitDecision(7); }
			switch (alt7)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:107:40: '\\r'
				{
				DebugLocation(107, 40);
				Match('\r'); 

				}
				break;

			}
			} finally { DebugExitSubRule(7); }

			DebugLocation(107, 46);
			Match('\n'); 
			DebugLocation(107, 51);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SL_COMMENT", 32);
			LeaveRule("SL_COMMENT", 32);
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
		EnterRule("ML_COMMENT", 33);
		TraceIn("ML_COMMENT", 33);
		try
		{
			int _type = ML_COMMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:111:11: ( '/*' ( options {greedy=false; } : . )* '*/' )
			DebugEnterAlt(1);
			// MathLang.g:112:3: '/*' ( options {greedy=false; } : . )* '*/'
			{
			DebugLocation(112, 3);
			Match("/*"); 

			DebugLocation(112, 8);
			// MathLang.g:112:8: ( options {greedy=false; } : . )*
			try { DebugEnterSubRule(8);
			while (true)
			{
				int alt8=2;
				try { DebugEnterDecision(8, decisionCanBacktrack[8]);
				int LA8_0 = input.LA(1);

				if ((LA8_0=='*'))
				{
					int LA8_1 = input.LA(2);

					if ((LA8_1=='/'))
					{
						alt8=2;
					}
					else if (((LA8_1>='\u0000' && LA8_1<='.')||(LA8_1>='0' && LA8_1<='\uFFFF')))
					{
						alt8=1;
					}


				}
				else if (((LA8_0>='\u0000' && LA8_0<=')')||(LA8_0>='+' && LA8_0<='\uFFFF')))
				{
					alt8=1;
				}


				} finally { DebugExitDecision(8); }
				switch ( alt8 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:112:36: .
					{
					DebugLocation(112, 36);
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

			DebugLocation(112, 40);
			Match("*/"); 

			DebugLocation(112, 45);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ML_COMMENT", 33);
			LeaveRule("ML_COMMENT", 33);
			Leave_ML_COMMENT();
		}
	}
	// $ANTLR end "ML_COMMENT"

	public override void mTokens()
	{
		// MathLang.g:1:8: ( PRINT | INPUT | IF | FOR | FUNCTION | RETURN | WHILE | T__39 | T__40 | T__41 | ARRAY | TYPE | ACCESS_MODIFIER | NUMBER | ADD | SUB | MUL | DIV | ASSIGN | TRUE | FALSE | EQ | NEQ | GR | GREQ | LS | LSEQ | OR | AND | WS | ID | SL_COMMENT | ML_COMMENT )
		int alt9=33;
		try { DebugEnterDecision(9, decisionCanBacktrack[9]);
		try
		{
			alt9 = dfa9.Predict(input);
		}
		catch (NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
			throw;
		}
		} finally { DebugExitDecision(9); }
		switch (alt9)
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
			// MathLang.g:1:25: FOR
			{
			DebugLocation(1, 25);
			mFOR(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// MathLang.g:1:29: FUNCTION
			{
			DebugLocation(1, 29);
			mFUNCTION(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// MathLang.g:1:38: RETURN
			{
			DebugLocation(1, 38);
			mRETURN(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// MathLang.g:1:45: WHILE
			{
			DebugLocation(1, 45);
			mWHILE(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// MathLang.g:1:51: T__39
			{
			DebugLocation(1, 51);
			mT__39(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// MathLang.g:1:57: T__40
			{
			DebugLocation(1, 57);
			mT__40(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// MathLang.g:1:63: T__41
			{
			DebugLocation(1, 63);
			mT__41(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// MathLang.g:1:69: ARRAY
			{
			DebugLocation(1, 69);
			mARRAY(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// MathLang.g:1:75: TYPE
			{
			DebugLocation(1, 75);
			mTYPE(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// MathLang.g:1:80: ACCESS_MODIFIER
			{
			DebugLocation(1, 80);
			mACCESS_MODIFIER(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// MathLang.g:1:96: NUMBER
			{
			DebugLocation(1, 96);
			mNUMBER(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// MathLang.g:1:103: ADD
			{
			DebugLocation(1, 103);
			mADD(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// MathLang.g:1:107: SUB
			{
			DebugLocation(1, 107);
			mSUB(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// MathLang.g:1:111: MUL
			{
			DebugLocation(1, 111);
			mMUL(); 

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// MathLang.g:1:115: DIV
			{
			DebugLocation(1, 115);
			mDIV(); 

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// MathLang.g:1:119: ASSIGN
			{
			DebugLocation(1, 119);
			mASSIGN(); 

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// MathLang.g:1:126: TRUE
			{
			DebugLocation(1, 126);
			mTRUE(); 

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// MathLang.g:1:131: FALSE
			{
			DebugLocation(1, 131);
			mFALSE(); 

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// MathLang.g:1:137: EQ
			{
			DebugLocation(1, 137);
			mEQ(); 

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// MathLang.g:1:140: NEQ
			{
			DebugLocation(1, 140);
			mNEQ(); 

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// MathLang.g:1:144: GR
			{
			DebugLocation(1, 144);
			mGR(); 

			}
			break;
		case 25:
			DebugEnterAlt(25);
			// MathLang.g:1:147: GREQ
			{
			DebugLocation(1, 147);
			mGREQ(); 

			}
			break;
		case 26:
			DebugEnterAlt(26);
			// MathLang.g:1:152: LS
			{
			DebugLocation(1, 152);
			mLS(); 

			}
			break;
		case 27:
			DebugEnterAlt(27);
			// MathLang.g:1:155: LSEQ
			{
			DebugLocation(1, 155);
			mLSEQ(); 

			}
			break;
		case 28:
			DebugEnterAlt(28);
			// MathLang.g:1:160: OR
			{
			DebugLocation(1, 160);
			mOR(); 

			}
			break;
		case 29:
			DebugEnterAlt(29);
			// MathLang.g:1:163: AND
			{
			DebugLocation(1, 163);
			mAND(); 

			}
			break;
		case 30:
			DebugEnterAlt(30);
			// MathLang.g:1:167: WS
			{
			DebugLocation(1, 167);
			mWS(); 

			}
			break;
		case 31:
			DebugEnterAlt(31);
			// MathLang.g:1:170: ID
			{
			DebugLocation(1, 170);
			mID(); 

			}
			break;
		case 32:
			DebugEnterAlt(32);
			// MathLang.g:1:173: SL_COMMENT
			{
			DebugLocation(1, 173);
			mSL_COMMENT(); 

			}
			break;
		case 33:
			DebugEnterAlt(33);
			// MathLang.g:1:184: ML_COMMENT
			{
			DebugLocation(1, 184);
			mML_COMMENT(); 

			}
			break;

		}

	}


	#region DFA
	DFA9 dfa9;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa9 = new DFA9(this);
	}

	private class DFA9 : DFA
	{
		private const string DFA9_eotS =
			"\x1\xFFFF\x5\x18\x3\xFFFF\x2\x18\x4\xFFFF\x1\x26\x1\x28\x1\x18\x1\xFFFF"+
			"\x1\x2B\x1\x2D\x4\xFFFF\x3\x18\x1\x32\x7\x18\x5\xFFFF\x1\x18\x4\xFFFF"+
			"\x3\x18\x1\x3F\x1\xFFFF\x1\x41\xB\x18\x3\xFFFF\x4\x18\x2\x3F\x1\x51\x1"+
			"\x52\x2\x18\x1\x55\x1\x18\x1\x57\x1\x18\x1\x59\x2\xFFFF\x1\x18\x1\x5B"+
			"\x1\xFFFF\x1\x18\x1\xFFFF\x1\x5D\x1\xFFFF\x1\x5B\x1\xFFFF\x1\x18\x1\xFFFF"+
			"\x1\x5F\x1\xFFFF";
		private const string DFA9_eofS =
			"\x60\xFFFF";
		private const string DFA9_minS =
			"\x1\x9\x1\x72\x1\x66\x1\x61\x1\x65\x1\x68\x3\xFFFF\x1\x6F\x1\x68\x4"+
			"\xFFFF\x1\x2A\x1\x3D\x1\x72\x1\xFFFF\x2\x3D\x4\xFFFF\x1\x69\x1\x62\x1"+
			"\x70\x1\x61\x1\x72\x1\x6E\x1\x6C\x1\x74\x1\x69\x1\x6F\x1\x61\x5\xFFFF"+
			"\x1\x75\x4\xFFFF\x1\x6E\x1\x6C\x1\x75\x1\x5B\x1\xFFFF\x1\x61\x1\x63\x1"+
			"\x73\x1\x75\x2\x6C\x1\x72\x1\x65\x1\x74\x1\x61\x1\x69\x1\x74\x3\xFFFF"+
			"\x1\x74\x1\x65\x1\x72\x1\x65\x2\x5B\x2\x61\x1\x74\x1\x63\x1\x61\x1\x69"+
			"\x1\x61\x1\x6E\x1\x61\x2\xFFFF\x1\x65\x1\x61\x1\xFFFF\x1\x6F\x1\xFFFF"+
			"\x1\x61\x1\xFFFF\x1\x61\x1\xFFFF\x1\x6E\x1\xFFFF\x1\x61\x1\xFFFF";
		private const string DFA9_maxS =
			"\x1\x7C\x1\x75\x1\x6E\x1\x75\x1\x65\x1\x68\x3\xFFFF\x1\x6F\x1\x68\x4"+
			"\xFFFF\x1\x2F\x1\x3D\x1\x72\x1\xFFFF\x2\x3D\x4\xFFFF\x1\x69\x1\x62\x1"+
			"\x74\x1\x7A\x1\x72\x1\x6E\x1\x6C\x1\x74\x1\x69\x1\x6F\x1\x61\x5\xFFFF"+
			"\x1\x75\x4\xFFFF\x1\x76\x1\x6C\x1\x75\x1\x7A\x1\xFFFF\x1\x7A\x1\x63\x1"+
			"\x73\x1\x75\x2\x6C\x1\x72\x1\x65\x1\x74\x1\x61\x1\x69\x1\x74\x3\xFFFF"+
			"\x1\x74\x1\x65\x1\x72\x1\x65\x4\x7A\x1\x74\x1\x63\x1\x7A\x1\x69\x1\x7A"+
			"\x1\x6E\x1\x7A\x2\xFFFF\x1\x65\x1\x7A\x1\xFFFF\x1\x6F\x1\xFFFF\x1\x7A"+
			"\x1\xFFFF\x1\x7A\x1\xFFFF\x1\x6E\x1\xFFFF\x1\x7A\x1\xFFFF";
		private const string DFA9_acceptS =
			"\x6\xFFFF\x1\x8\x1\x9\x1\xA\x2\xFFFF\x1\xE\x1\xF\x1\x10\x1\x11\x3\xFFFF"+
			"\x1\x17\x2\xFFFF\x1\x1C\x1\x1D\x1\x1E\x1\x1F\xB\xFFFF\x1\x20\x1\x21\x1"+
			"\x12\x1\x16\x1\x13\x1\xFFFF\x1\x19\x1\x18\x1\x1B\x1\x1A\x4\xFFFF\x1\x3"+
			"\xC\xFFFF\x1\xC\x1\xB\x1\x4\xF\xFFFF\x1\x14\x1\x1\x2\xFFFF\x1\x2\x1\xFFFF"+
			"\x1\x15\x1\xFFFF\x1\x7\x1\xFFFF\x1\xD\x1\xFFFF\x1\x6\x1\xFFFF\x1\x5";
		private const string DFA9_specialS =
			"\x60\xFFFF}>";
		private static readonly string[] DFA9_transitionS =
			{
				"\x2\x17\x1\xFFFF\x2\x17\x12\xFFFF\x1\x17\x1\x12\x4\xFFFF\x1\x16\x1"+
				"\xFFFF\x1\x7\x1\x8\x1\xE\x1\xC\x1\xFFFF\x1\xD\x1\xFFFF\x1\xF\xA\xB\x1"+
				"\xFFFF\x1\x6\x1\x14\x1\x10\x1\x13\x22\xFFFF\x1\x18\x1\x9\x1\xA\x2\x18"+
				"\x1\x3\x2\x18\x1\x2\x6\x18\x1\x1\x1\x18\x1\x4\x1\x18\x1\x11\x2\x18\x1"+
				"\x5\x3\x18\x1\xFFFF\x1\x15",
				"\x1\x19\x2\xFFFF\x1\x1A",
				"\x1\x1C\x7\xFFFF\x1\x1B",
				"\x1\x1F\xD\xFFFF\x1\x1D\x5\xFFFF\x1\x1E",
				"\x1\x20",
				"\x1\x21",
				"",
				"",
				"",
				"\x1\x22",
				"\x1\x23",
				"",
				"",
				"",
				"",
				"\x1\x25\x4\xFFFF\x1\x24",
				"\x1\x27",
				"\x1\x29",
				"",
				"\x1\x2A",
				"\x1\x2C",
				"",
				"",
				"",
				"",
				"\x1\x2E",
				"\x1\x2F",
				"\x1\x30\x3\xFFFF\x1\x31",
				"\x1A\x18",
				"\x1\x33",
				"\x1\x34",
				"\x1\x35",
				"\x1\x36",
				"\x1\x37",
				"\x1\x38",
				"\x1\x39",
				"",
				"",
				"",
				"",
				"",
				"\x1\x3A",
				"",
				"",
				"",
				"",
				"\x1\x3B\x7\xFFFF\x1\x3C",
				"\x1\x3D",
				"\x1\x3E",
				"\x1\x40\x5\xFFFF\x1A\x18",
				"",
				"\x1A\x18",
				"\x1\x42",
				"\x1\x43",
				"\x1\x44",
				"\x1\x45",
				"\x1\x46",
				"\x1\x47",
				"\x1\x48",
				"\x1\x49",
				"\x1\x4A",
				"\x1\x4B",
				"\x1\x4C",
				"",
				"",
				"",
				"\x1\x4D",
				"\x1\x4E",
				"\x1\x4F",
				"\x1\x50",
				"\x1\x40\x5\xFFFF\x1A\x18",
				"\x1\x40\x5\xFFFF\x1A\x18",
				"\x1A\x18",
				"\x1A\x18",
				"\x1\x53",
				"\x1\x54",
				"\x1A\x18",
				"\x1\x56",
				"\x1A\x18",
				"\x1\x58",
				"\x1A\x18",
				"",
				"",
				"\x1\x5A",
				"\x1A\x18",
				"",
				"\x1\x5C",
				"",
				"\x1A\x18",
				"",
				"\x1A\x18",
				"",
				"\x1\x5E",
				"",
				"\x1A\x18",
				""
			};

		private static readonly short[] DFA9_eot = DFA.UnpackEncodedString(DFA9_eotS);
		private static readonly short[] DFA9_eof = DFA.UnpackEncodedString(DFA9_eofS);
		private static readonly char[] DFA9_min = DFA.UnpackEncodedStringToUnsignedChars(DFA9_minS);
		private static readonly char[] DFA9_max = DFA.UnpackEncodedStringToUnsignedChars(DFA9_maxS);
		private static readonly short[] DFA9_accept = DFA.UnpackEncodedString(DFA9_acceptS);
		private static readonly short[] DFA9_special = DFA.UnpackEncodedString(DFA9_specialS);
		private static readonly short[][] DFA9_transition;

		static DFA9()
		{
			int numStates = DFA9_transitionS.Length;
			DFA9_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA9_transition[i] = DFA.UnpackEncodedString(DFA9_transitionS[i]);
			}
		}

		public DFA9( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 9;
			this.eot = DFA9_eot;
			this.eof = DFA9_eof;
			this.min = DFA9_min;
			this.max = DFA9_max;
			this.accept = DFA9_accept;
			this.special = DFA9_special;
			this.transition = DFA9_transition;
		}

		public override string Description { get { return "1:1: Tokens : ( PRINT | INPUT | IF | FOR | FUNCTION | RETURN | WHILE | T__39 | T__40 | T__41 | ARRAY | TYPE | ACCESS_MODIFIER | NUMBER | ADD | SUB | MUL | DIV | ASSIGN | TRUE | FALSE | EQ | NEQ | GR | GREQ | LS | LSEQ | OR | AND | WS | ID | SL_COMMENT | ML_COMMENT );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}

} // namespace  MathLang 

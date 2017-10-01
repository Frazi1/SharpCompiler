// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-10-01 16:03:27

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
	public const int T__42=42;
	public const int T__43=43;
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

	partial void Enter_RETURN();
	partial void Leave_RETURN();

	// $ANTLR start "RETURN"
	[GrammarRule("RETURN")]
	private void mRETURN()
	{
		Enter_RETURN();
		EnterRule("RETURN", 7);
		TraceIn("RETURN", 7);
		try
		{
			int _type = RETURN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:15:8: ( 'return' )
			DebugEnterAlt(1);
			// MathLang.g:15:10: 'return'
			{
			DebugLocation(15, 10);
			Match("return"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RETURN", 7);
			LeaveRule("RETURN", 7);
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
		EnterRule("WHILE", 8);
		TraceIn("WHILE", 8);
		try
		{
			int _type = WHILE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:16:7: ( 'while' )
			DebugEnterAlt(1);
			// MathLang.g:16:9: 'while'
			{
			DebugLocation(16, 9);
			Match("while"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WHILE", 8);
			LeaveRule("WHILE", 8);
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
		EnterRule("T__39", 9);
		TraceIn("T__39", 9);
		try
		{
			int _type = T__39;
			int _channel = DefaultTokenChannel;
			// MathLang.g:17:7: ( ';' )
			DebugEnterAlt(1);
			// MathLang.g:17:9: ';'
			{
			DebugLocation(17, 9);
			Match(';'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__39", 9);
			LeaveRule("T__39", 9);
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
		EnterRule("T__40", 10);
		TraceIn("T__40", 10);
		try
		{
			int _type = T__40;
			int _channel = DefaultTokenChannel;
			// MathLang.g:18:7: ( '(' )
			DebugEnterAlt(1);
			// MathLang.g:18:9: '('
			{
			DebugLocation(18, 9);
			Match('('); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__40", 10);
			LeaveRule("T__40", 10);
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
		EnterRule("T__41", 11);
		TraceIn("T__41", 11);
		try
		{
			int _type = T__41;
			int _channel = DefaultTokenChannel;
			// MathLang.g:19:7: ( ')' )
			DebugEnterAlt(1);
			// MathLang.g:19:9: ')'
			{
			DebugLocation(19, 9);
			Match(')'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__41", 11);
			LeaveRule("T__41", 11);
			Leave_T__41();
		}
	}
	// $ANTLR end "T__41"

	partial void Enter_T__42();
	partial void Leave_T__42();

	// $ANTLR start "T__42"
	[GrammarRule("T__42")]
	private void mT__42()
	{
		Enter_T__42();
		EnterRule("T__42", 12);
		TraceIn("T__42", 12);
		try
		{
			int _type = T__42;
			int _channel = DefaultTokenChannel;
			// MathLang.g:20:7: ( '{' )
			DebugEnterAlt(1);
			// MathLang.g:20:9: '{'
			{
			DebugLocation(20, 9);
			Match('{'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__42", 12);
			LeaveRule("T__42", 12);
			Leave_T__42();
		}
	}
	// $ANTLR end "T__42"

	partial void Enter_T__43();
	partial void Leave_T__43();

	// $ANTLR start "T__43"
	[GrammarRule("T__43")]
	private void mT__43()
	{
		Enter_T__43();
		EnterRule("T__43", 13);
		TraceIn("T__43", 13);
		try
		{
			int _type = T__43;
			int _channel = DefaultTokenChannel;
			// MathLang.g:21:7: ( '}' )
			DebugEnterAlt(1);
			// MathLang.g:21:9: '}'
			{
			DebugLocation(21, 9);
			Match('}'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__43", 13);
			LeaveRule("T__43", 13);
			Leave_T__43();
		}
	}
	// $ANTLR end "T__43"

	partial void Enter_ARRAY();
	partial void Leave_ARRAY();

	// $ANTLR start "ARRAY"
	[GrammarRule("ARRAY")]
	private void mARRAY()
	{
		Enter_ARRAY();
		EnterRule("ARRAY", 14);
		TraceIn("ARRAY", 14);
		try
		{
			int _type = ARRAY;
			int _channel = DefaultTokenChannel;
			// MathLang.g:86:6: ( ( TYPE '[]' ) )
			DebugEnterAlt(1);
			// MathLang.g:86:8: ( TYPE '[]' )
			{
			DebugLocation(86, 8);
			// MathLang.g:86:8: ( TYPE '[]' )
			DebugEnterAlt(1);
			// MathLang.g:86:9: TYPE '[]'
			{
			DebugLocation(86, 9);
			mTYPE(); 
			DebugLocation(86, 14);
			Match("[]"); 


			}


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ARRAY", 14);
			LeaveRule("ARRAY", 14);
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
		EnterRule("TYPE", 15);
		TraceIn("TYPE", 15);
		try
		{
			int _type = TYPE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:87:5: ( 'int' | 'bool' | 'char' )
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
				// MathLang.g:87:7: 'int'
				{
				DebugLocation(87, 7);
				Match("int"); 


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:87:15: 'bool'
				{
				DebugLocation(87, 15);
				Match("bool"); 


				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:87:24: 'char'
				{
				DebugLocation(87, 24);
				Match("char"); 


				}
				break;

			}
			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TYPE", 15);
			LeaveRule("TYPE", 15);
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
		EnterRule("ACCESS_MODIFIER", 16);
		TraceIn("ACCESS_MODIFIER", 16);
		try
		{
			int _type = ACCESS_MODIFIER;
			int _channel = DefaultTokenChannel;
			// MathLang.g:88:16: ( 'public' | 'private' )
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
				// MathLang.g:88:18: 'public'
				{
				DebugLocation(88, 18);
				Match("public"); 


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:88:29: 'private'
				{
				DebugLocation(88, 29);
				Match("private"); 


				}
				break;

			}
			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ACCESS_MODIFIER", 16);
			LeaveRule("ACCESS_MODIFIER", 16);
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
		EnterRule("NUMBER", 17);
		TraceIn("NUMBER", 17);
		try
		{
			int _type = NUMBER;
			int _channel = DefaultTokenChannel;
			// MathLang.g:89:7: ( ( '0' .. '9' )+ )
			DebugEnterAlt(1);
			// MathLang.g:89:9: ( '0' .. '9' )+
			{
			DebugLocation(89, 9);
			// MathLang.g:89:9: ( '0' .. '9' )+
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
					// MathLang.g:89:10: '0' .. '9'
					{
					DebugLocation(89, 10);
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
			TraceOut("NUMBER", 17);
			LeaveRule("NUMBER", 17);
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
		EnterRule("ADD", 18);
		TraceIn("ADD", 18);
		try
		{
			int _type = ADD;
			int _channel = DefaultTokenChannel;
			// MathLang.g:90:4: ( '+' )
			DebugEnterAlt(1);
			// MathLang.g:90:9: '+'
			{
			DebugLocation(90, 9);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ADD", 18);
			LeaveRule("ADD", 18);
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
		EnterRule("SUB", 19);
		TraceIn("SUB", 19);
		try
		{
			int _type = SUB;
			int _channel = DefaultTokenChannel;
			// MathLang.g:91:4: ( '-' )
			DebugEnterAlt(1);
			// MathLang.g:91:9: '-'
			{
			DebugLocation(91, 9);
			Match('-'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SUB", 19);
			LeaveRule("SUB", 19);
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
		EnterRule("MUL", 20);
		TraceIn("MUL", 20);
		try
		{
			int _type = MUL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:92:4: ( '*' )
			DebugEnterAlt(1);
			// MathLang.g:92:9: '*'
			{
			DebugLocation(92, 9);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MUL", 20);
			LeaveRule("MUL", 20);
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
		EnterRule("DIV", 21);
		TraceIn("DIV", 21);
		try
		{
			int _type = DIV;
			int _channel = DefaultTokenChannel;
			// MathLang.g:93:4: ( '/' )
			DebugEnterAlt(1);
			// MathLang.g:93:9: '/'
			{
			DebugLocation(93, 9);
			Match('/'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DIV", 21);
			LeaveRule("DIV", 21);
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
		EnterRule("ASSIGN", 22);
		TraceIn("ASSIGN", 22);
		try
		{
			int _type = ASSIGN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:94:7: ( '=' )
			DebugEnterAlt(1);
			// MathLang.g:94:9: '='
			{
			DebugLocation(94, 9);
			Match('='); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ASSIGN", 22);
			LeaveRule("ASSIGN", 22);
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
		EnterRule("TRUE", 23);
		TraceIn("TRUE", 23);
		try
		{
			int _type = TRUE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:96:5: ( 'true' )
			DebugEnterAlt(1);
			// MathLang.g:96:7: 'true'
			{
			DebugLocation(96, 7);
			Match("true"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TRUE", 23);
			LeaveRule("TRUE", 23);
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
		EnterRule("FALSE", 24);
		TraceIn("FALSE", 24);
		try
		{
			int _type = FALSE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:97:6: ( 'false' )
			DebugEnterAlt(1);
			// MathLang.g:97:8: 'false'
			{
			DebugLocation(97, 8);
			Match("false"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FALSE", 24);
			LeaveRule("FALSE", 24);
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
		EnterRule("EQ", 25);
		TraceIn("EQ", 25);
		try
		{
			int _type = EQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:98:3: ( '==' )
			DebugEnterAlt(1);
			// MathLang.g:98:6: '=='
			{
			DebugLocation(98, 6);
			Match("=="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EQ", 25);
			LeaveRule("EQ", 25);
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
		EnterRule("NEQ", 26);
		TraceIn("NEQ", 26);
		try
		{
			int _type = NEQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:99:4: ( '!=' )
			DebugEnterAlt(1);
			// MathLang.g:99:6: '!='
			{
			DebugLocation(99, 6);
			Match("!="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NEQ", 26);
			LeaveRule("NEQ", 26);
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
		EnterRule("GR", 27);
		TraceIn("GR", 27);
		try
		{
			int _type = GR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:100:3: ( '>' )
			DebugEnterAlt(1);
			// MathLang.g:100:6: '>'
			{
			DebugLocation(100, 6);
			Match('>'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GR", 27);
			LeaveRule("GR", 27);
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
		EnterRule("GREQ", 28);
		TraceIn("GREQ", 28);
		try
		{
			int _type = GREQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:101:5: ( '>=' )
			DebugEnterAlt(1);
			// MathLang.g:101:9: '>='
			{
			DebugLocation(101, 9);
			Match(">="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GREQ", 28);
			LeaveRule("GREQ", 28);
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
		EnterRule("LS", 29);
		TraceIn("LS", 29);
		try
		{
			int _type = LS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:102:3: ( '<' )
			DebugEnterAlt(1);
			// MathLang.g:102:6: '<'
			{
			DebugLocation(102, 6);
			Match('<'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LS", 29);
			LeaveRule("LS", 29);
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
		EnterRule("LSEQ", 30);
		TraceIn("LSEQ", 30);
		try
		{
			int _type = LSEQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:103:5: ( '<=' )
			DebugEnterAlt(1);
			// MathLang.g:103:7: '<='
			{
			DebugLocation(103, 7);
			Match("<="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LSEQ", 30);
			LeaveRule("LSEQ", 30);
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
		EnterRule("OR", 31);
		TraceIn("OR", 31);
		try
		{
			int _type = OR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:105:3: ( '||' )
			DebugEnterAlt(1);
			// MathLang.g:105:6: '||'
			{
			DebugLocation(105, 6);
			Match("||"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OR", 31);
			LeaveRule("OR", 31);
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
		EnterRule("AND", 32);
		TraceIn("AND", 32);
		try
		{
			int _type = AND;
			int _channel = DefaultTokenChannel;
			// MathLang.g:106:4: ( '&&' )
			DebugEnterAlt(1);
			// MathLang.g:106:6: '&&'
			{
			DebugLocation(106, 6);
			Match("&&"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("AND", 32);
			LeaveRule("AND", 32);
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
		EnterRule("WS", 33);
		TraceIn("WS", 33);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:107:3: ( ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+ )
			DebugEnterAlt(1);
			// MathLang.g:108:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			{
			DebugLocation(108, 3);
			// MathLang.g:108:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
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
					DebugLocation(108, 3);
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

			DebugLocation(108, 41);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 33);
			LeaveRule("WS", 33);
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
		EnterRule("ID", 34);
		TraceIn("ID", 34);
		try
		{
			int _type = ID;
			int _channel = DefaultTokenChannel;
			// MathLang.g:112:3: ( ( 'a' .. 'z' )+ )
			DebugEnterAlt(1);
			// MathLang.g:112:6: ( 'a' .. 'z' )+
			{
			DebugLocation(112, 6);
			// MathLang.g:112:6: ( 'a' .. 'z' )+
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
					// MathLang.g:112:7: 'a' .. 'z'
					{
					DebugLocation(112, 7);
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
			TraceOut("ID", 34);
			LeaveRule("ID", 34);
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
		EnterRule("SL_COMMENT", 35);
		TraceIn("SL_COMMENT", 35);
		try
		{
			int _type = SL_COMMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:115:11: ( '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n' )
			DebugEnterAlt(1);
			// MathLang.g:116:3: '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n'
			{
			DebugLocation(116, 3);
			Match("//"); 

			DebugLocation(116, 8);
			// MathLang.g:116:8: ( options {greedy=false; } : . )*
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
					// MathLang.g:116:36: .
					{
					DebugLocation(116, 36);
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

			DebugLocation(116, 40);
			// MathLang.g:116:40: ( '\\r' )?
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
				// MathLang.g:116:40: '\\r'
				{
				DebugLocation(116, 40);
				Match('\r'); 

				}
				break;

			}
			} finally { DebugExitSubRule(7); }

			DebugLocation(116, 46);
			Match('\n'); 
			DebugLocation(116, 51);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SL_COMMENT", 35);
			LeaveRule("SL_COMMENT", 35);
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
		EnterRule("ML_COMMENT", 36);
		TraceIn("ML_COMMENT", 36);
		try
		{
			int _type = ML_COMMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:120:11: ( '/*' ( options {greedy=false; } : . )* '*/' )
			DebugEnterAlt(1);
			// MathLang.g:121:3: '/*' ( options {greedy=false; } : . )* '*/'
			{
			DebugLocation(121, 3);
			Match("/*"); 

			DebugLocation(121, 8);
			// MathLang.g:121:8: ( options {greedy=false; } : . )*
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
					// MathLang.g:121:36: .
					{
					DebugLocation(121, 36);
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

			DebugLocation(121, 40);
			Match("*/"); 

			DebugLocation(121, 45);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ML_COMMENT", 36);
			LeaveRule("ML_COMMENT", 36);
			Leave_ML_COMMENT();
		}
	}
	// $ANTLR end "ML_COMMENT"

	public override void mTokens()
	{
		// MathLang.g:1:8: ( PRINT | INPUT | IF | ELSE | FOR | FUNCTION | RETURN | WHILE | T__39 | T__40 | T__41 | T__42 | T__43 | ARRAY | TYPE | ACCESS_MODIFIER | NUMBER | ADD | SUB | MUL | DIV | ASSIGN | TRUE | FALSE | EQ | NEQ | GR | GREQ | LS | LSEQ | OR | AND | WS | ID | SL_COMMENT | ML_COMMENT )
		int alt9=36;
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
			// MathLang.g:1:43: RETURN
			{
			DebugLocation(1, 43);
			mRETURN(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// MathLang.g:1:50: WHILE
			{
			DebugLocation(1, 50);
			mWHILE(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// MathLang.g:1:56: T__39
			{
			DebugLocation(1, 56);
			mT__39(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// MathLang.g:1:62: T__40
			{
			DebugLocation(1, 62);
			mT__40(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// MathLang.g:1:68: T__41
			{
			DebugLocation(1, 68);
			mT__41(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// MathLang.g:1:74: T__42
			{
			DebugLocation(1, 74);
			mT__42(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// MathLang.g:1:80: T__43
			{
			DebugLocation(1, 80);
			mT__43(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// MathLang.g:1:86: ARRAY
			{
			DebugLocation(1, 86);
			mARRAY(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// MathLang.g:1:92: TYPE
			{
			DebugLocation(1, 92);
			mTYPE(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// MathLang.g:1:97: ACCESS_MODIFIER
			{
			DebugLocation(1, 97);
			mACCESS_MODIFIER(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// MathLang.g:1:113: NUMBER
			{
			DebugLocation(1, 113);
			mNUMBER(); 

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// MathLang.g:1:120: ADD
			{
			DebugLocation(1, 120);
			mADD(); 

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// MathLang.g:1:124: SUB
			{
			DebugLocation(1, 124);
			mSUB(); 

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// MathLang.g:1:128: MUL
			{
			DebugLocation(1, 128);
			mMUL(); 

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// MathLang.g:1:132: DIV
			{
			DebugLocation(1, 132);
			mDIV(); 

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// MathLang.g:1:136: ASSIGN
			{
			DebugLocation(1, 136);
			mASSIGN(); 

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// MathLang.g:1:143: TRUE
			{
			DebugLocation(1, 143);
			mTRUE(); 

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// MathLang.g:1:148: FALSE
			{
			DebugLocation(1, 148);
			mFALSE(); 

			}
			break;
		case 25:
			DebugEnterAlt(25);
			// MathLang.g:1:154: EQ
			{
			DebugLocation(1, 154);
			mEQ(); 

			}
			break;
		case 26:
			DebugEnterAlt(26);
			// MathLang.g:1:157: NEQ
			{
			DebugLocation(1, 157);
			mNEQ(); 

			}
			break;
		case 27:
			DebugEnterAlt(27);
			// MathLang.g:1:161: GR
			{
			DebugLocation(1, 161);
			mGR(); 

			}
			break;
		case 28:
			DebugEnterAlt(28);
			// MathLang.g:1:164: GREQ
			{
			DebugLocation(1, 164);
			mGREQ(); 

			}
			break;
		case 29:
			DebugEnterAlt(29);
			// MathLang.g:1:169: LS
			{
			DebugLocation(1, 169);
			mLS(); 

			}
			break;
		case 30:
			DebugEnterAlt(30);
			// MathLang.g:1:172: LSEQ
			{
			DebugLocation(1, 172);
			mLSEQ(); 

			}
			break;
		case 31:
			DebugEnterAlt(31);
			// MathLang.g:1:177: OR
			{
			DebugLocation(1, 177);
			mOR(); 

			}
			break;
		case 32:
			DebugEnterAlt(32);
			// MathLang.g:1:180: AND
			{
			DebugLocation(1, 180);
			mAND(); 

			}
			break;
		case 33:
			DebugEnterAlt(33);
			// MathLang.g:1:184: WS
			{
			DebugLocation(1, 184);
			mWS(); 

			}
			break;
		case 34:
			DebugEnterAlt(34);
			// MathLang.g:1:187: ID
			{
			DebugLocation(1, 187);
			mID(); 

			}
			break;
		case 35:
			DebugEnterAlt(35);
			// MathLang.g:1:190: SL_COMMENT
			{
			DebugLocation(1, 190);
			mSL_COMMENT(); 

			}
			break;
		case 36:
			DebugEnterAlt(36);
			// MathLang.g:1:201: ML_COMMENT
			{
			DebugLocation(1, 201);
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
			"\x1\xFFFF\x6\x1B\x5\xFFFF\x2\x1B\x4\xFFFF\x1\x2A\x1\x2C\x1\x1B\x1\xFFFF"+
			"\x1\x2F\x1\x31\x4\xFFFF\x3\x1B\x1\x36\x8\x1B\x5\xFFFF\x1\x1B\x4\xFFFF"+
			"\x3\x1B\x1\x44\x1\xFFFF\x1\x1B\x1\x47\xB\x1B\x2\xFFFF\x1\x53\x1\xFFFF"+
			"\x4\x1B\x2\x44\x1\x58\x1\x59\x2\x1B\x1\x5C\x1\xFFFF\x1\x1B\x1\x5E\x1"+
			"\x1B\x1\x60\x2\xFFFF\x1\x1B\x1\x62\x1\xFFFF\x1\x1B\x1\xFFFF\x1\x64\x1"+
			"\xFFFF\x1\x62\x1\xFFFF\x1\x1B\x1\xFFFF\x1\x66\x1\xFFFF";
		private const string DFA9_eofS =
			"\x67\xFFFF";
		private const string DFA9_minS =
			"\x1\x9\x1\x72\x1\x66\x1\x6C\x1\x61\x1\x65\x1\x68\x5\xFFFF\x1\x6F\x1"+
			"\x68\x4\xFFFF\x1\x2A\x1\x3D\x1\x72\x1\xFFFF\x2\x3D\x4\xFFFF\x1\x69\x1"+
			"\x62\x1\x70\x1\x61\x1\x73\x1\x72\x1\x6E\x1\x6C\x1\x74\x1\x69\x1\x6F\x1"+
			"\x61\x5\xFFFF\x1\x75\x4\xFFFF\x1\x6E\x1\x6C\x1\x75\x1\x5B\x1\xFFFF\x1"+
			"\x65\x1\x61\x1\x63\x1\x73\x1\x75\x2\x6C\x1\x72\x1\x65\x1\x74\x1\x61\x1"+
			"\x69\x1\x74\x2\xFFFF\x1\x61\x1\xFFFF\x1\x74\x1\x65\x1\x72\x1\x65\x2\x5B"+
			"\x2\x61\x1\x74\x1\x63\x1\x61\x1\xFFFF\x1\x69\x1\x61\x1\x6E\x1\x61\x2"+
			"\xFFFF\x1\x65\x1\x61\x1\xFFFF\x1\x6F\x1\xFFFF\x1\x61\x1\xFFFF\x1\x61"+
			"\x1\xFFFF\x1\x6E\x1\xFFFF\x1\x61\x1\xFFFF";
		private const string DFA9_maxS =
			"\x1\x7D\x1\x75\x1\x6E\x1\x6C\x1\x75\x1\x65\x1\x68\x5\xFFFF\x1\x6F\x1"+
			"\x68\x4\xFFFF\x1\x2F\x1\x3D\x1\x72\x1\xFFFF\x2\x3D\x4\xFFFF\x1\x69\x1"+
			"\x62\x1\x74\x1\x7A\x1\x73\x1\x72\x1\x6E\x1\x6C\x1\x74\x1\x69\x1\x6F\x1"+
			"\x61\x5\xFFFF\x1\x75\x4\xFFFF\x1\x76\x1\x6C\x1\x75\x1\x7A\x1\xFFFF\x1"+
			"\x65\x1\x7A\x1\x63\x1\x73\x1\x75\x2\x6C\x1\x72\x1\x65\x1\x74\x1\x61\x1"+
			"\x69\x1\x74\x2\xFFFF\x1\x7A\x1\xFFFF\x1\x74\x1\x65\x1\x72\x1\x65\x4\x7A"+
			"\x1\x74\x1\x63\x1\x7A\x1\xFFFF\x1\x69\x1\x7A\x1\x6E\x1\x7A\x2\xFFFF\x1"+
			"\x65\x1\x7A\x1\xFFFF\x1\x6F\x1\xFFFF\x1\x7A\x1\xFFFF\x1\x7A\x1\xFFFF"+
			"\x1\x6E\x1\xFFFF\x1\x7A\x1\xFFFF";
		private const string DFA9_acceptS =
			"\x7\xFFFF\x1\x9\x1\xA\x1\xB\x1\xC\x1\xD\x2\xFFFF\x1\x11\x1\x12\x1\x13"+
			"\x1\x14\x3\xFFFF\x1\x1A\x2\xFFFF\x1\x1F\x1\x20\x1\x21\x1\x22\xC\xFFFF"+
			"\x1\x23\x1\x24\x1\x15\x1\x19\x1\x16\x1\xFFFF\x1\x1C\x1\x1B\x1\x1E\x1"+
			"\x1D\x4\xFFFF\x1\x3\xD\xFFFF\x1\xF\x1\xE\x1\xFFFF\x1\x5\xB\xFFFF\x1\x4"+
			"\x4\xFFFF\x1\x17\x1\x1\x2\xFFFF\x1\x2\x1\xFFFF\x1\x18\x1\xFFFF\x1\x8"+
			"\x1\xFFFF\x1\x10\x1\xFFFF\x1\x7\x1\xFFFF\x1\x6";
		private const string DFA9_specialS =
			"\x67\xFFFF}>";
		private static readonly string[] DFA9_transitionS =
			{
				"\x2\x1A\x1\xFFFF\x2\x1A\x12\xFFFF\x1\x1A\x1\x15\x4\xFFFF\x1\x19\x1"+
				"\xFFFF\x1\x8\x1\x9\x1\x11\x1\xF\x1\xFFFF\x1\x10\x1\xFFFF\x1\x12\xA\xE"+
				"\x1\xFFFF\x1\x7\x1\x17\x1\x13\x1\x16\x22\xFFFF\x1\x1B\x1\xC\x1\xD\x1"+
				"\x1B\x1\x3\x1\x4\x2\x1B\x1\x2\x6\x1B\x1\x1\x1\x1B\x1\x5\x1\x1B\x1\x14"+
				"\x2\x1B\x1\x6\x3\x1B\x1\xA\x1\x18\x1\xB",
				"\x1\x1C\x2\xFFFF\x1\x1D",
				"\x1\x1F\x7\xFFFF\x1\x1E",
				"\x1\x20",
				"\x1\x23\xD\xFFFF\x1\x21\x5\xFFFF\x1\x22",
				"\x1\x24",
				"\x1\x25",
				"",
				"",
				"",
				"",
				"",
				"\x1\x26",
				"\x1\x27",
				"",
				"",
				"",
				"",
				"\x1\x29\x4\xFFFF\x1\x28",
				"\x1\x2B",
				"\x1\x2D",
				"",
				"\x1\x2E",
				"\x1\x30",
				"",
				"",
				"",
				"",
				"\x1\x32",
				"\x1\x33",
				"\x1\x34\x3\xFFFF\x1\x35",
				"\x1A\x1B",
				"\x1\x37",
				"\x1\x38",
				"\x1\x39",
				"\x1\x3A",
				"\x1\x3B",
				"\x1\x3C",
				"\x1\x3D",
				"\x1\x3E",
				"",
				"",
				"",
				"",
				"",
				"\x1\x3F",
				"",
				"",
				"",
				"",
				"\x1\x40\x7\xFFFF\x1\x41",
				"\x1\x42",
				"\x1\x43",
				"\x1\x45\x5\xFFFF\x1A\x1B",
				"",
				"\x1\x46",
				"\x1A\x1B",
				"\x1\x48",
				"\x1\x49",
				"\x1\x4A",
				"\x1\x4B",
				"\x1\x4C",
				"\x1\x4D",
				"\x1\x4E",
				"\x1\x4F",
				"\x1\x50",
				"\x1\x51",
				"\x1\x52",
				"",
				"",
				"\x1A\x1B",
				"",
				"\x1\x54",
				"\x1\x55",
				"\x1\x56",
				"\x1\x57",
				"\x1\x45\x5\xFFFF\x1A\x1B",
				"\x1\x45\x5\xFFFF\x1A\x1B",
				"\x1A\x1B",
				"\x1A\x1B",
				"\x1\x5A",
				"\x1\x5B",
				"\x1A\x1B",
				"",
				"\x1\x5D",
				"\x1A\x1B",
				"\x1\x5F",
				"\x1A\x1B",
				"",
				"",
				"\x1\x61",
				"\x1A\x1B",
				"",
				"\x1\x63",
				"",
				"\x1A\x1B",
				"",
				"\x1A\x1B",
				"",
				"\x1\x65",
				"",
				"\x1A\x1B",
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

		public override string Description { get { return "1:1: Tokens : ( PRINT | INPUT | IF | ELSE | FOR | FUNCTION | RETURN | WHILE | T__39 | T__40 | T__41 | T__42 | T__43 | ARRAY | TYPE | ACCESS_MODIFIER | NUMBER | ADD | SUB | MUL | DIV | ASSIGN | TRUE | FALSE | EQ | NEQ | GR | GREQ | LS | LSEQ | OR | AND | WS | ID | SL_COMMENT | ML_COMMENT );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}

} // namespace  MathLang 

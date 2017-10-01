// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-09-30 23:41:06

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
	public const int T__28=28;
	public const int T__29=29;
	public const int T__30=30;
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
	public const int ASSIGN=17;
	public const int TYPE=18;
	public const int ARRAY=19;
	public const int ID=20;
	public const int ADD=21;
	public const int SUB=22;
	public const int MUL=23;
	public const int DIV=24;
	public const int WS=25;
	public const int SL_COMMENT=26;
	public const int ML_COMMENT=27;

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

	partial void Enter_T__28();
	partial void Leave_T__28();

	// $ANTLR start "T__28"
	[GrammarRule("T__28")]
	private void mT__28()
	{
		Enter_T__28();
		EnterRule("T__28", 8);
		TraceIn("T__28", 8);
		try
		{
			int _type = T__28;
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
			TraceOut("T__28", 8);
			LeaveRule("T__28", 8);
			Leave_T__28();
		}
	}
	// $ANTLR end "T__28"

	partial void Enter_T__29();
	partial void Leave_T__29();

	// $ANTLR start "T__29"
	[GrammarRule("T__29")]
	private void mT__29()
	{
		Enter_T__29();
		EnterRule("T__29", 9);
		TraceIn("T__29", 9);
		try
		{
			int _type = T__29;
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
			TraceOut("T__29", 9);
			LeaveRule("T__29", 9);
			Leave_T__29();
		}
	}
	// $ANTLR end "T__29"

	partial void Enter_T__30();
	partial void Leave_T__30();

	// $ANTLR start "T__30"
	[GrammarRule("T__30")]
	private void mT__30()
	{
		Enter_T__30();
		EnterRule("T__30", 10);
		TraceIn("T__30", 10);
		try
		{
			int _type = T__30;
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
			TraceOut("T__30", 10);
			LeaveRule("T__30", 10);
			Leave_T__30();
		}
	}
	// $ANTLR end "T__30"

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
			// MathLang.g:53:6: ( ( TYPE '[]' ) )
			DebugEnterAlt(1);
			// MathLang.g:53:8: ( TYPE '[]' )
			{
			DebugLocation(53, 8);
			// MathLang.g:53:8: ( TYPE '[]' )
			DebugEnterAlt(1);
			// MathLang.g:53:9: TYPE '[]'
			{
			DebugLocation(53, 9);
			mTYPE(); 
			DebugLocation(53, 14);
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
			// MathLang.g:54:5: ( 'int' )
			DebugEnterAlt(1);
			// MathLang.g:54:7: 'int'
			{
			DebugLocation(54, 7);
			Match("int"); 


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

	partial void Enter_NUMBER();
	partial void Leave_NUMBER();

	// $ANTLR start "NUMBER"
	[GrammarRule("NUMBER")]
	private void mNUMBER()
	{
		Enter_NUMBER();
		EnterRule("NUMBER", 13);
		TraceIn("NUMBER", 13);
		try
		{
			int _type = NUMBER;
			int _channel = DefaultTokenChannel;
			// MathLang.g:55:7: ( ( '0' .. '9' )+ )
			DebugEnterAlt(1);
			// MathLang.g:55:9: ( '0' .. '9' )+
			{
			DebugLocation(55, 9);
			// MathLang.g:55:9: ( '0' .. '9' )+
			int cnt1=0;
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, decisionCanBacktrack[1]);
				int LA1_0 = input.LA(1);

				if (((LA1_0>='0' && LA1_0<='9')))
				{
					alt1=1;
				}


				} finally { DebugExitDecision(1); }
				switch (alt1)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:55:10: '0' .. '9'
					{
					DebugLocation(55, 10);
					MatchRange('0','9'); 

					}
					break;

				default:
					if (cnt1 >= 1)
						goto loop1;

					EarlyExitException eee1 = new EarlyExitException( 1, input );
					DebugRecognitionException(eee1);
					throw eee1;
				}
				cnt1++;
			}
			loop1:
				;

			} finally { DebugExitSubRule(1); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NUMBER", 13);
			LeaveRule("NUMBER", 13);
			Leave_NUMBER();
		}
	}
	// $ANTLR end "NUMBER"

	partial void Enter_ID();
	partial void Leave_ID();

	// $ANTLR start "ID"
	[GrammarRule("ID")]
	private void mID()
	{
		Enter_ID();
		EnterRule("ID", 14);
		TraceIn("ID", 14);
		try
		{
			int _type = ID;
			int _channel = DefaultTokenChannel;
			// MathLang.g:56:3: ( ( 'a' .. 'z' )+ )
			DebugEnterAlt(1);
			// MathLang.g:56:6: ( 'a' .. 'z' )+
			{
			DebugLocation(56, 6);
			// MathLang.g:56:6: ( 'a' .. 'z' )+
			int cnt2=0;
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
				int LA2_0 = input.LA(1);

				if (((LA2_0>='a' && LA2_0<='z')))
				{
					alt2=1;
				}


				} finally { DebugExitDecision(2); }
				switch (alt2)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:56:7: 'a' .. 'z'
					{
					DebugLocation(56, 7);
					MatchRange('a','z'); 

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
			TraceOut("ID", 14);
			LeaveRule("ID", 14);
			Leave_ID();
		}
	}
	// $ANTLR end "ID"

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
			// MathLang.g:57:4: ( '+' )
			DebugEnterAlt(1);
			// MathLang.g:57:9: '+'
			{
			DebugLocation(57, 9);
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
			// MathLang.g:58:4: ( '-' )
			DebugEnterAlt(1);
			// MathLang.g:58:9: '-'
			{
			DebugLocation(58, 9);
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
			// MathLang.g:59:4: ( '*' )
			DebugEnterAlt(1);
			// MathLang.g:59:9: '*'
			{
			DebugLocation(59, 9);
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
			// MathLang.g:60:4: ( '/' )
			DebugEnterAlt(1);
			// MathLang.g:60:9: '/'
			{
			DebugLocation(60, 9);
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
			// MathLang.g:61:7: ( '=' )
			DebugEnterAlt(1);
			// MathLang.g:61:9: '='
			{
			DebugLocation(61, 9);
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

	partial void Enter_WS();
	partial void Leave_WS();

	// $ANTLR start "WS"
	[GrammarRule("WS")]
	private void mWS()
	{
		Enter_WS();
		EnterRule("WS", 20);
		TraceIn("WS", 20);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:62:3: ( ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+ )
			DebugEnterAlt(1);
			// MathLang.g:63:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			{
			DebugLocation(63, 3);
			// MathLang.g:63:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
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
					DebugLocation(63, 3);
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

			DebugLocation(63, 41);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 20);
			LeaveRule("WS", 20);
			Leave_WS();
		}
	}
	// $ANTLR end "WS"

	partial void Enter_SL_COMMENT();
	partial void Leave_SL_COMMENT();

	// $ANTLR start "SL_COMMENT"
	[GrammarRule("SL_COMMENT")]
	private void mSL_COMMENT()
	{
		Enter_SL_COMMENT();
		EnterRule("SL_COMMENT", 21);
		TraceIn("SL_COMMENT", 21);
		try
		{
			int _type = SL_COMMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:69:11: ( '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n' )
			DebugEnterAlt(1);
			// MathLang.g:70:3: '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n'
			{
			DebugLocation(70, 3);
			Match("//"); 

			DebugLocation(70, 8);
			// MathLang.g:70:8: ( options {greedy=false; } : . )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_0 = input.LA(1);

				if ((LA4_0=='\r'))
				{
					alt4=2;
				}
				else if ((LA4_0=='\n'))
				{
					alt4=2;
				}
				else if (((LA4_0>='\u0000' && LA4_0<='\t')||(LA4_0>='\u000B' && LA4_0<='\f')||(LA4_0>='\u000E' && LA4_0<='\uFFFF')))
				{
					alt4=1;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:70:36: .
					{
					DebugLocation(70, 36);
					MatchAny(); 

					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }

			DebugLocation(70, 40);
			// MathLang.g:70:40: ( '\\r' )?
			int alt5=2;
			try { DebugEnterSubRule(5);
			try { DebugEnterDecision(5, decisionCanBacktrack[5]);
			int LA5_0 = input.LA(1);

			if ((LA5_0=='\r'))
			{
				alt5=1;
			}
			} finally { DebugExitDecision(5); }
			switch (alt5)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:70:40: '\\r'
				{
				DebugLocation(70, 40);
				Match('\r'); 

				}
				break;

			}
			} finally { DebugExitSubRule(5); }

			DebugLocation(70, 46);
			Match('\n'); 
			DebugLocation(70, 51);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SL_COMMENT", 21);
			LeaveRule("SL_COMMENT", 21);
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
		EnterRule("ML_COMMENT", 22);
		TraceIn("ML_COMMENT", 22);
		try
		{
			int _type = ML_COMMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:74:11: ( '/*' ( options {greedy=false; } : . )* '*/' )
			DebugEnterAlt(1);
			// MathLang.g:75:3: '/*' ( options {greedy=false; } : . )* '*/'
			{
			DebugLocation(75, 3);
			Match("/*"); 

			DebugLocation(75, 8);
			// MathLang.g:75:8: ( options {greedy=false; } : . )*
			try { DebugEnterSubRule(6);
			while (true)
			{
				int alt6=2;
				try { DebugEnterDecision(6, decisionCanBacktrack[6]);
				int LA6_0 = input.LA(1);

				if ((LA6_0=='*'))
				{
					int LA6_1 = input.LA(2);

					if ((LA6_1=='/'))
					{
						alt6=2;
					}
					else if (((LA6_1>='\u0000' && LA6_1<='.')||(LA6_1>='0' && LA6_1<='\uFFFF')))
					{
						alt6=1;
					}


				}
				else if (((LA6_0>='\u0000' && LA6_0<=')')||(LA6_0>='+' && LA6_0<='\uFFFF')))
				{
					alt6=1;
				}


				} finally { DebugExitDecision(6); }
				switch ( alt6 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:75:36: .
					{
					DebugLocation(75, 36);
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

			DebugLocation(75, 40);
			Match("*/"); 

			DebugLocation(75, 45);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ML_COMMENT", 22);
			LeaveRule("ML_COMMENT", 22);
			Leave_ML_COMMENT();
		}
	}
	// $ANTLR end "ML_COMMENT"

	public override void mTokens()
	{
		// MathLang.g:1:8: ( PRINT | INPUT | IF | FOR | FUNCTION | RETURN | WHILE | T__28 | T__29 | T__30 | ARRAY | TYPE | NUMBER | ID | ADD | SUB | MUL | DIV | ASSIGN | WS | SL_COMMENT | ML_COMMENT )
		int alt7=22;
		try { DebugEnterDecision(7, decisionCanBacktrack[7]);
		try
		{
			alt7 = dfa7.Predict(input);
		}
		catch (NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
			throw;
		}
		} finally { DebugExitDecision(7); }
		switch (alt7)
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
			// MathLang.g:1:51: T__28
			{
			DebugLocation(1, 51);
			mT__28(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// MathLang.g:1:57: T__29
			{
			DebugLocation(1, 57);
			mT__29(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// MathLang.g:1:63: T__30
			{
			DebugLocation(1, 63);
			mT__30(); 

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
			// MathLang.g:1:80: NUMBER
			{
			DebugLocation(1, 80);
			mNUMBER(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// MathLang.g:1:87: ID
			{
			DebugLocation(1, 87);
			mID(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// MathLang.g:1:90: ADD
			{
			DebugLocation(1, 90);
			mADD(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// MathLang.g:1:94: SUB
			{
			DebugLocation(1, 94);
			mSUB(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// MathLang.g:1:98: MUL
			{
			DebugLocation(1, 98);
			mMUL(); 

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// MathLang.g:1:102: DIV
			{
			DebugLocation(1, 102);
			mDIV(); 

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// MathLang.g:1:106: ASSIGN
			{
			DebugLocation(1, 106);
			mASSIGN(); 

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// MathLang.g:1:113: WS
			{
			DebugLocation(1, 113);
			mWS(); 

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// MathLang.g:1:116: SL_COMMENT
			{
			DebugLocation(1, 116);
			mSL_COMMENT(); 

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// MathLang.g:1:127: ML_COMMENT
			{
			DebugLocation(1, 127);
			mML_COMMENT(); 

			}
			break;

		}

	}


	#region DFA
	DFA7 dfa7;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa7 = new DFA7(this);
	}

	private class DFA7 : DFA
	{
		private const string DFA7_eotS =
			"\x1\xFFFF\x5\xA\x8\xFFFF\x1\x1A\x2\xFFFF\x2\xA\x1\x1E\x4\xA\x3\xFFFF"+
			"\x2\xA\x1\x25\x1\xFFFF\x1\x27\x5\xA\x3\xFFFF\x3\xA\x1\x30\x1\x31\x2\xA"+
			"\x1\x34\x2\xFFFF\x1\xA\x1\x36\x1\xFFFF\x1\xA\x1\xFFFF\x1\x38\x1\xFFFF";
		private const string DFA7_eofS =
			"\x39\xFFFF";
		private const string DFA7_minS =
			"\x1\x9\x1\x72\x1\x66\x1\x6F\x1\x65\x1\x68\x8\xFFFF\x1\x2A\x2\xFFFF\x1"+
			"\x69\x1\x70\x1\x61\x1\x72\x1\x6E\x1\x74\x1\x69\x3\xFFFF\x1\x6E\x1\x75"+
			"\x1\x5B\x1\xFFFF\x1\x61\x1\x63\x1\x75\x1\x6C\x2\x74\x3\xFFFF\x1\x74\x1"+
			"\x72\x1\x65\x2\x61\x1\x69\x1\x6E\x1\x61\x2\xFFFF\x1\x6F\x1\x61\x1\xFFFF"+
			"\x1\x6E\x1\xFFFF\x1\x61\x1\xFFFF";
		private const string DFA7_maxS =
			"\x1\x7A\x1\x72\x1\x6E\x1\x75\x1\x65\x1\x68\x8\xFFFF\x1\x2F\x2\xFFFF"+
			"\x1\x69\x1\x74\x1\x7A\x1\x72\x1\x6E\x1\x74\x1\x69\x3\xFFFF\x1\x6E\x1"+
			"\x75\x1\x7A\x1\xFFFF\x1\x7A\x1\x63\x1\x75\x1\x6C\x2\x74\x3\xFFFF\x1\x74"+
			"\x1\x72\x1\x65\x2\x7A\x1\x69\x1\x6E\x1\x7A\x2\xFFFF\x1\x6F\x1\x7A\x1"+
			"\xFFFF\x1\x6E\x1\xFFFF\x1\x7A\x1\xFFFF";
		private const string DFA7_acceptS =
			"\x6\xFFFF\x1\x8\x1\x9\x1\xA\x1\xD\x1\xE\x1\xF\x1\x10\x1\x11\x1\xFFFF"+
			"\x1\x13\x1\x14\x7\xFFFF\x1\x15\x1\x16\x1\x12\x3\xFFFF\x1\x3\x6\xFFFF"+
			"\x1\xC\x1\xB\x1\x4\x8\xFFFF\x1\x1\x1\x2\x2\xFFFF\x1\x7\x1\xFFFF\x1\x6"+
			"\x1\xFFFF\x1\x5";
		private const string DFA7_specialS =
			"\x39\xFFFF}>";
		private static readonly string[] DFA7_transitionS =
			{
				"\x2\x10\x1\xFFFF\x2\x10\x12\xFFFF\x1\x10\x7\xFFFF\x1\x7\x1\x8\x1\xD"+
				"\x1\xB\x1\xFFFF\x1\xC\x1\xFFFF\x1\xE\xA\x9\x1\xFFFF\x1\x6\x1\xFFFF\x1"+
				"\xF\x23\xFFFF\x5\xA\x1\x3\x2\xA\x1\x2\x6\xA\x1\x1\x1\xA\x1\x4\x4\xA"+
				"\x1\x5\x3\xA",
				"\x1\x11",
				"\x1\x13\x7\xFFFF\x1\x12",
				"\x1\x14\x5\xFFFF\x1\x15",
				"\x1\x16",
				"\x1\x17",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x19\x4\xFFFF\x1\x18",
				"",
				"",
				"\x1\x1B",
				"\x1\x1C\x3\xFFFF\x1\x1D",
				"\x1A\xA",
				"\x1\x1F",
				"\x1\x20",
				"\x1\x21",
				"\x1\x22",
				"",
				"",
				"",
				"\x1\x23",
				"\x1\x24",
				"\x1\x26\x5\xFFFF\x1A\xA",
				"",
				"\x1A\xA",
				"\x1\x28",
				"\x1\x29",
				"\x1\x2A",
				"\x1\x2B",
				"\x1\x2C",
				"",
				"",
				"",
				"\x1\x2D",
				"\x1\x2E",
				"\x1\x2F",
				"\x1A\xA",
				"\x1A\xA",
				"\x1\x32",
				"\x1\x33",
				"\x1A\xA",
				"",
				"",
				"\x1\x35",
				"\x1A\xA",
				"",
				"\x1\x37",
				"",
				"\x1A\xA",
				""
			};

		private static readonly short[] DFA7_eot = DFA.UnpackEncodedString(DFA7_eotS);
		private static readonly short[] DFA7_eof = DFA.UnpackEncodedString(DFA7_eofS);
		private static readonly char[] DFA7_min = DFA.UnpackEncodedStringToUnsignedChars(DFA7_minS);
		private static readonly char[] DFA7_max = DFA.UnpackEncodedStringToUnsignedChars(DFA7_maxS);
		private static readonly short[] DFA7_accept = DFA.UnpackEncodedString(DFA7_acceptS);
		private static readonly short[] DFA7_special = DFA.UnpackEncodedString(DFA7_specialS);
		private static readonly short[][] DFA7_transition;

		static DFA7()
		{
			int numStates = DFA7_transitionS.Length;
			DFA7_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA7_transition[i] = DFA.UnpackEncodedString(DFA7_transitionS[i]);
			}
		}

		public DFA7( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 7;
			this.eot = DFA7_eot;
			this.eof = DFA7_eof;
			this.min = DFA7_min;
			this.max = DFA7_max;
			this.accept = DFA7_accept;
			this.special = DFA7_special;
			this.transition = DFA7_transition;
		}

		public override string Description { get { return "1:1: Tokens : ( PRINT | INPUT | IF | FOR | FUNCTION | RETURN | WHILE | T__28 | T__29 | T__30 | ARRAY | TYPE | NUMBER | ID | ADD | SUB | MUL | DIV | ASSIGN | WS | SL_COMMENT | ML_COMMENT );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}

} // namespace  MathLang 

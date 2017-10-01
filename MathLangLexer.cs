// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-10-01 17:34:36

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
	public const int T__42=42;
	public const int T__43=43;
	public const int T__44=44;
	public const int T__45=45;
	public const int T__46=46;
	public const int T__47=47;
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
	public const int CHAR=18;
	public const int TYPE=19;
	public const int ASSIGN=20;
	public const int ARRAY=21;
	public const int ADD=22;
	public const int SUB=23;
	public const int MUL=24;
	public const int DIV=25;
	public const int GREQ=26;
	public const int LSEQ=27;
	public const int NEQ=28;
	public const int EQ=29;
	public const int GR=30;
	public const int LS=31;
	public const int OR=32;
	public const int AND=33;
	public const int TRUE=34;
	public const int FALSE=35;
	public const int ACCESS_MODIFIER=36;
	public const int FUNCT=37;
	public const int PARAMETERS=38;
	public const int WS=39;
	public const int SL_COMMENT=40;
	public const int ML_COMMENT=41;

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

	partial void Enter_T__42();
	partial void Leave_T__42();

	// $ANTLR start "T__42"
	[GrammarRule("T__42")]
	private void mT__42()
	{
		Enter_T__42();
		EnterRule("T__42", 9);
		TraceIn("T__42", 9);
		try
		{
			int _type = T__42;
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
			TraceOut("T__42", 9);
			LeaveRule("T__42", 9);
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
		EnterRule("T__43", 10);
		TraceIn("T__43", 10);
		try
		{
			int _type = T__43;
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
			TraceOut("T__43", 10);
			LeaveRule("T__43", 10);
			Leave_T__43();
		}
	}
	// $ANTLR end "T__43"

	partial void Enter_T__44();
	partial void Leave_T__44();

	// $ANTLR start "T__44"
	[GrammarRule("T__44")]
	private void mT__44()
	{
		Enter_T__44();
		EnterRule("T__44", 11);
		TraceIn("T__44", 11);
		try
		{
			int _type = T__44;
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
			TraceOut("T__44", 11);
			LeaveRule("T__44", 11);
			Leave_T__44();
		}
	}
	// $ANTLR end "T__44"

	partial void Enter_T__45();
	partial void Leave_T__45();

	// $ANTLR start "T__45"
	[GrammarRule("T__45")]
	private void mT__45()
	{
		Enter_T__45();
		EnterRule("T__45", 12);
		TraceIn("T__45", 12);
		try
		{
			int _type = T__45;
			int _channel = DefaultTokenChannel;
			// MathLang.g:20:7: ( ',' )
			DebugEnterAlt(1);
			// MathLang.g:20:9: ','
			{
			DebugLocation(20, 9);
			Match(','); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__45", 12);
			LeaveRule("T__45", 12);
			Leave_T__45();
		}
	}
	// $ANTLR end "T__45"

	partial void Enter_T__46();
	partial void Leave_T__46();

	// $ANTLR start "T__46"
	[GrammarRule("T__46")]
	private void mT__46()
	{
		Enter_T__46();
		EnterRule("T__46", 13);
		TraceIn("T__46", 13);
		try
		{
			int _type = T__46;
			int _channel = DefaultTokenChannel;
			// MathLang.g:21:7: ( '{' )
			DebugEnterAlt(1);
			// MathLang.g:21:9: '{'
			{
			DebugLocation(21, 9);
			Match('{'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__46", 13);
			LeaveRule("T__46", 13);
			Leave_T__46();
		}
	}
	// $ANTLR end "T__46"

	partial void Enter_T__47();
	partial void Leave_T__47();

	// $ANTLR start "T__47"
	[GrammarRule("T__47")]
	private void mT__47()
	{
		Enter_T__47();
		EnterRule("T__47", 14);
		TraceIn("T__47", 14);
		try
		{
			int _type = T__47;
			int _channel = DefaultTokenChannel;
			// MathLang.g:22:7: ( '}' )
			DebugEnterAlt(1);
			// MathLang.g:22:9: '}'
			{
			DebugLocation(22, 9);
			Match('}'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__47", 14);
			LeaveRule("T__47", 14);
			Leave_T__47();
		}
	}
	// $ANTLR end "T__47"

	partial void Enter_ARRAY();
	partial void Leave_ARRAY();

	// $ANTLR start "ARRAY"
	[GrammarRule("ARRAY")]
	private void mARRAY()
	{
		Enter_ARRAY();
		EnterRule("ARRAY", 15);
		TraceIn("ARRAY", 15);
		try
		{
			int _type = ARRAY;
			int _channel = DefaultTokenChannel;
			// MathLang.g:102:6: ( ( TYPE '[]' ) )
			DebugEnterAlt(1);
			// MathLang.g:102:8: ( TYPE '[]' )
			{
			DebugLocation(102, 8);
			// MathLang.g:102:8: ( TYPE '[]' )
			DebugEnterAlt(1);
			// MathLang.g:102:9: TYPE '[]'
			{
			DebugLocation(102, 9);
			mTYPE(); 
			DebugLocation(102, 14);
			Match("[]"); 


			}


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ARRAY", 15);
			LeaveRule("ARRAY", 15);
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
		EnterRule("TYPE", 16);
		TraceIn("TYPE", 16);
		try
		{
			int _type = TYPE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:103:5: ( 'int' | 'bool' | 'char' )
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
				// MathLang.g:103:7: 'int'
				{
				DebugLocation(103, 7);
				Match("int"); 


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:103:15: 'bool'
				{
				DebugLocation(103, 15);
				Match("bool"); 


				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:103:24: 'char'
				{
				DebugLocation(103, 24);
				Match("char"); 


				}
				break;

			}
			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TYPE", 16);
			LeaveRule("TYPE", 16);
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
		EnterRule("ACCESS_MODIFIER", 17);
		TraceIn("ACCESS_MODIFIER", 17);
		try
		{
			int _type = ACCESS_MODIFIER;
			int _channel = DefaultTokenChannel;
			// MathLang.g:104:16: ( 'public' | 'private' )
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
				// MathLang.g:104:18: 'public'
				{
				DebugLocation(104, 18);
				Match("public"); 


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:104:29: 'private'
				{
				DebugLocation(104, 29);
				Match("private"); 


				}
				break;

			}
			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ACCESS_MODIFIER", 17);
			LeaveRule("ACCESS_MODIFIER", 17);
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
		EnterRule("NUMBER", 18);
		TraceIn("NUMBER", 18);
		try
		{
			int _type = NUMBER;
			int _channel = DefaultTokenChannel;
			// MathLang.g:105:7: ( ( '0' .. '9' )+ )
			DebugEnterAlt(1);
			// MathLang.g:105:9: ( '0' .. '9' )+
			{
			DebugLocation(105, 9);
			// MathLang.g:105:9: ( '0' .. '9' )+
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
					// MathLang.g:105:10: '0' .. '9'
					{
					DebugLocation(105, 10);
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
			TraceOut("NUMBER", 18);
			LeaveRule("NUMBER", 18);
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
		EnterRule("ADD", 19);
		TraceIn("ADD", 19);
		try
		{
			int _type = ADD;
			int _channel = DefaultTokenChannel;
			// MathLang.g:106:4: ( '+' )
			DebugEnterAlt(1);
			// MathLang.g:106:9: '+'
			{
			DebugLocation(106, 9);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ADD", 19);
			LeaveRule("ADD", 19);
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
		EnterRule("SUB", 20);
		TraceIn("SUB", 20);
		try
		{
			int _type = SUB;
			int _channel = DefaultTokenChannel;
			// MathLang.g:107:4: ( '-' )
			DebugEnterAlt(1);
			// MathLang.g:107:9: '-'
			{
			DebugLocation(107, 9);
			Match('-'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SUB", 20);
			LeaveRule("SUB", 20);
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
		EnterRule("MUL", 21);
		TraceIn("MUL", 21);
		try
		{
			int _type = MUL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:108:4: ( '*' )
			DebugEnterAlt(1);
			// MathLang.g:108:9: '*'
			{
			DebugLocation(108, 9);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MUL", 21);
			LeaveRule("MUL", 21);
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
		EnterRule("DIV", 22);
		TraceIn("DIV", 22);
		try
		{
			int _type = DIV;
			int _channel = DefaultTokenChannel;
			// MathLang.g:109:4: ( '/' )
			DebugEnterAlt(1);
			// MathLang.g:109:9: '/'
			{
			DebugLocation(109, 9);
			Match('/'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DIV", 22);
			LeaveRule("DIV", 22);
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
		EnterRule("ASSIGN", 23);
		TraceIn("ASSIGN", 23);
		try
		{
			int _type = ASSIGN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:110:7: ( '=' )
			DebugEnterAlt(1);
			// MathLang.g:110:9: '='
			{
			DebugLocation(110, 9);
			Match('='); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ASSIGN", 23);
			LeaveRule("ASSIGN", 23);
			Leave_ASSIGN();
		}
	}
	// $ANTLR end "ASSIGN"

	partial void Enter_FUNCT();
	partial void Leave_FUNCT();

	// $ANTLR start "FUNCT"
	[GrammarRule("FUNCT")]
	private void mFUNCT()
	{
		Enter_FUNCT();
		EnterRule("FUNCT", 24);
		TraceIn("FUNCT", 24);
		try
		{
			int _type = FUNCT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:111:6: ( 'funct' )
			DebugEnterAlt(1);
			// MathLang.g:111:7: 'funct'
			{
			DebugLocation(111, 7);
			Match("funct"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FUNCT", 24);
			LeaveRule("FUNCT", 24);
			Leave_FUNCT();
		}
	}
	// $ANTLR end "FUNCT"

	partial void Enter_TRUE();
	partial void Leave_TRUE();

	// $ANTLR start "TRUE"
	[GrammarRule("TRUE")]
	private void mTRUE()
	{
		Enter_TRUE();
		EnterRule("TRUE", 25);
		TraceIn("TRUE", 25);
		try
		{
			int _type = TRUE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:112:5: ( 'true' )
			DebugEnterAlt(1);
			// MathLang.g:112:7: 'true'
			{
			DebugLocation(112, 7);
			Match("true"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TRUE", 25);
			LeaveRule("TRUE", 25);
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
		EnterRule("FALSE", 26);
		TraceIn("FALSE", 26);
		try
		{
			int _type = FALSE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:113:6: ( 'false' )
			DebugEnterAlt(1);
			// MathLang.g:113:8: 'false'
			{
			DebugLocation(113, 8);
			Match("false"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FALSE", 26);
			LeaveRule("FALSE", 26);
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
		EnterRule("EQ", 27);
		TraceIn("EQ", 27);
		try
		{
			int _type = EQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:114:3: ( '==' )
			DebugEnterAlt(1);
			// MathLang.g:114:6: '=='
			{
			DebugLocation(114, 6);
			Match("=="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EQ", 27);
			LeaveRule("EQ", 27);
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
		EnterRule("NEQ", 28);
		TraceIn("NEQ", 28);
		try
		{
			int _type = NEQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:115:4: ( '!=' )
			DebugEnterAlt(1);
			// MathLang.g:115:6: '!='
			{
			DebugLocation(115, 6);
			Match("!="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NEQ", 28);
			LeaveRule("NEQ", 28);
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
		EnterRule("GR", 29);
		TraceIn("GR", 29);
		try
		{
			int _type = GR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:116:3: ( '>' )
			DebugEnterAlt(1);
			// MathLang.g:116:6: '>'
			{
			DebugLocation(116, 6);
			Match('>'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GR", 29);
			LeaveRule("GR", 29);
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
		EnterRule("GREQ", 30);
		TraceIn("GREQ", 30);
		try
		{
			int _type = GREQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:117:5: ( '>=' )
			DebugEnterAlt(1);
			// MathLang.g:117:9: '>='
			{
			DebugLocation(117, 9);
			Match(">="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GREQ", 30);
			LeaveRule("GREQ", 30);
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
		EnterRule("LS", 31);
		TraceIn("LS", 31);
		try
		{
			int _type = LS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:118:3: ( '<' )
			DebugEnterAlt(1);
			// MathLang.g:118:6: '<'
			{
			DebugLocation(118, 6);
			Match('<'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LS", 31);
			LeaveRule("LS", 31);
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
		EnterRule("LSEQ", 32);
		TraceIn("LSEQ", 32);
		try
		{
			int _type = LSEQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:119:5: ( '<=' )
			DebugEnterAlt(1);
			// MathLang.g:119:7: '<='
			{
			DebugLocation(119, 7);
			Match("<="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LSEQ", 32);
			LeaveRule("LSEQ", 32);
			Leave_LSEQ();
		}
	}
	// $ANTLR end "LSEQ"

	partial void Enter_PARAMETERS();
	partial void Leave_PARAMETERS();

	// $ANTLR start "PARAMETERS"
	[GrammarRule("PARAMETERS")]
	private void mPARAMETERS()
	{
		Enter_PARAMETERS();
		EnterRule("PARAMETERS", 33);
		TraceIn("PARAMETERS", 33);
		try
		{
			int _type = PARAMETERS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:120:11: ( 'parameters' )
			DebugEnterAlt(1);
			// MathLang.g:120:13: 'parameters'
			{
			DebugLocation(120, 13);
			Match("parameters"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PARAMETERS", 33);
			LeaveRule("PARAMETERS", 33);
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
		EnterRule("OR", 34);
		TraceIn("OR", 34);
		try
		{
			int _type = OR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:121:3: ( '||' )
			DebugEnterAlt(1);
			// MathLang.g:121:6: '||'
			{
			DebugLocation(121, 6);
			Match("||"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OR", 34);
			LeaveRule("OR", 34);
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
		EnterRule("AND", 35);
		TraceIn("AND", 35);
		try
		{
			int _type = AND;
			int _channel = DefaultTokenChannel;
			// MathLang.g:122:4: ( '&&' )
			DebugEnterAlt(1);
			// MathLang.g:122:6: '&&'
			{
			DebugLocation(122, 6);
			Match("&&"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("AND", 35);
			LeaveRule("AND", 35);
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
		EnterRule("WS", 36);
		TraceIn("WS", 36);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:123:3: ( ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+ )
			DebugEnterAlt(1);
			// MathLang.g:124:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			{
			DebugLocation(124, 3);
			// MathLang.g:124:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
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
					DebugLocation(124, 3);
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

			DebugLocation(124, 41);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 36);
			LeaveRule("WS", 36);
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
		EnterRule("CHAR", 37);
		TraceIn("CHAR", 37);
		try
		{
			int _type = CHAR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:128:5: ( '\\'' ( 'a' .. 'z' ) '\\'' )
			DebugEnterAlt(1);
			// MathLang.g:128:8: '\\'' ( 'a' .. 'z' ) '\\''
			{
			DebugLocation(128, 8);
			Match('\''); 
			DebugLocation(128, 12);
			// MathLang.g:128:12: ( 'a' .. 'z' )
			DebugEnterAlt(1);
			// MathLang.g:128:13: 'a' .. 'z'
			{
			DebugLocation(128, 13);
			MatchRange('a','z'); 

			}

			DebugLocation(128, 22);
			Match('\''); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CHAR", 37);
			LeaveRule("CHAR", 37);
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
		EnterRule("ID", 38);
		TraceIn("ID", 38);
		try
		{
			int _type = ID;
			int _channel = DefaultTokenChannel;
			// MathLang.g:129:3: ( ( 'a' .. 'z' )+ )
			DebugEnterAlt(1);
			// MathLang.g:129:6: ( 'a' .. 'z' )+
			{
			DebugLocation(129, 6);
			// MathLang.g:129:6: ( 'a' .. 'z' )+
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
					// MathLang.g:129:7: 'a' .. 'z'
					{
					DebugLocation(129, 7);
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
			TraceOut("ID", 38);
			LeaveRule("ID", 38);
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
		EnterRule("SL_COMMENT", 39);
		TraceIn("SL_COMMENT", 39);
		try
		{
			int _type = SL_COMMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:133:11: ( '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n' )
			DebugEnterAlt(1);
			// MathLang.g:134:3: '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n'
			{
			DebugLocation(134, 3);
			Match("//"); 

			DebugLocation(134, 8);
			// MathLang.g:134:8: ( options {greedy=false; } : . )*
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
					// MathLang.g:134:36: .
					{
					DebugLocation(134, 36);
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

			DebugLocation(134, 40);
			// MathLang.g:134:40: ( '\\r' )?
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
				// MathLang.g:134:40: '\\r'
				{
				DebugLocation(134, 40);
				Match('\r'); 

				}
				break;

			}
			} finally { DebugExitSubRule(7); }

			DebugLocation(134, 46);
			Match('\n'); 
			DebugLocation(134, 51);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SL_COMMENT", 39);
			LeaveRule("SL_COMMENT", 39);
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
		EnterRule("ML_COMMENT", 40);
		TraceIn("ML_COMMENT", 40);
		try
		{
			int _type = ML_COMMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:138:11: ( '/*' ( options {greedy=false; } : . )* '*/' )
			DebugEnterAlt(1);
			// MathLang.g:139:3: '/*' ( options {greedy=false; } : . )* '*/'
			{
			DebugLocation(139, 3);
			Match("/*"); 

			DebugLocation(139, 8);
			// MathLang.g:139:8: ( options {greedy=false; } : . )*
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
					// MathLang.g:139:36: .
					{
					DebugLocation(139, 36);
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

			DebugLocation(139, 40);
			Match("*/"); 

			DebugLocation(139, 45);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ML_COMMENT", 40);
			LeaveRule("ML_COMMENT", 40);
			Leave_ML_COMMENT();
		}
	}
	// $ANTLR end "ML_COMMENT"

	public override void mTokens()
	{
		// MathLang.g:1:8: ( PRINT | INPUT | IF | ELSE | FOR | FUNCTION | RETURN | WHILE | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | ARRAY | TYPE | ACCESS_MODIFIER | NUMBER | ADD | SUB | MUL | DIV | ASSIGN | FUNCT | TRUE | FALSE | EQ | NEQ | GR | GREQ | LS | LSEQ | PARAMETERS | OR | AND | WS | CHAR | ID | SL_COMMENT | ML_COMMENT )
		int alt9=40;
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
			// MathLang.g:1:56: T__42
			{
			DebugLocation(1, 56);
			mT__42(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// MathLang.g:1:62: T__43
			{
			DebugLocation(1, 62);
			mT__43(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// MathLang.g:1:68: T__44
			{
			DebugLocation(1, 68);
			mT__44(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// MathLang.g:1:74: T__45
			{
			DebugLocation(1, 74);
			mT__45(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// MathLang.g:1:80: T__46
			{
			DebugLocation(1, 80);
			mT__46(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// MathLang.g:1:86: T__47
			{
			DebugLocation(1, 86);
			mT__47(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// MathLang.g:1:92: ARRAY
			{
			DebugLocation(1, 92);
			mARRAY(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// MathLang.g:1:98: TYPE
			{
			DebugLocation(1, 98);
			mTYPE(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// MathLang.g:1:103: ACCESS_MODIFIER
			{
			DebugLocation(1, 103);
			mACCESS_MODIFIER(); 

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// MathLang.g:1:119: NUMBER
			{
			DebugLocation(1, 119);
			mNUMBER(); 

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// MathLang.g:1:126: ADD
			{
			DebugLocation(1, 126);
			mADD(); 

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// MathLang.g:1:130: SUB
			{
			DebugLocation(1, 130);
			mSUB(); 

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// MathLang.g:1:134: MUL
			{
			DebugLocation(1, 134);
			mMUL(); 

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// MathLang.g:1:138: DIV
			{
			DebugLocation(1, 138);
			mDIV(); 

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// MathLang.g:1:142: ASSIGN
			{
			DebugLocation(1, 142);
			mASSIGN(); 

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// MathLang.g:1:149: FUNCT
			{
			DebugLocation(1, 149);
			mFUNCT(); 

			}
			break;
		case 25:
			DebugEnterAlt(25);
			// MathLang.g:1:155: TRUE
			{
			DebugLocation(1, 155);
			mTRUE(); 

			}
			break;
		case 26:
			DebugEnterAlt(26);
			// MathLang.g:1:160: FALSE
			{
			DebugLocation(1, 160);
			mFALSE(); 

			}
			break;
		case 27:
			DebugEnterAlt(27);
			// MathLang.g:1:166: EQ
			{
			DebugLocation(1, 166);
			mEQ(); 

			}
			break;
		case 28:
			DebugEnterAlt(28);
			// MathLang.g:1:169: NEQ
			{
			DebugLocation(1, 169);
			mNEQ(); 

			}
			break;
		case 29:
			DebugEnterAlt(29);
			// MathLang.g:1:173: GR
			{
			DebugLocation(1, 173);
			mGR(); 

			}
			break;
		case 30:
			DebugEnterAlt(30);
			// MathLang.g:1:176: GREQ
			{
			DebugLocation(1, 176);
			mGREQ(); 

			}
			break;
		case 31:
			DebugEnterAlt(31);
			// MathLang.g:1:181: LS
			{
			DebugLocation(1, 181);
			mLS(); 

			}
			break;
		case 32:
			DebugEnterAlt(32);
			// MathLang.g:1:184: LSEQ
			{
			DebugLocation(1, 184);
			mLSEQ(); 

			}
			break;
		case 33:
			DebugEnterAlt(33);
			// MathLang.g:1:189: PARAMETERS
			{
			DebugLocation(1, 189);
			mPARAMETERS(); 

			}
			break;
		case 34:
			DebugEnterAlt(34);
			// MathLang.g:1:200: OR
			{
			DebugLocation(1, 200);
			mOR(); 

			}
			break;
		case 35:
			DebugEnterAlt(35);
			// MathLang.g:1:203: AND
			{
			DebugLocation(1, 203);
			mAND(); 

			}
			break;
		case 36:
			DebugEnterAlt(36);
			// MathLang.g:1:207: WS
			{
			DebugLocation(1, 207);
			mWS(); 

			}
			break;
		case 37:
			DebugEnterAlt(37);
			// MathLang.g:1:210: CHAR
			{
			DebugLocation(1, 210);
			mCHAR(); 

			}
			break;
		case 38:
			DebugEnterAlt(38);
			// MathLang.g:1:215: ID
			{
			DebugLocation(1, 215);
			mID(); 

			}
			break;
		case 39:
			DebugEnterAlt(39);
			// MathLang.g:1:218: SL_COMMENT
			{
			DebugLocation(1, 218);
			mSL_COMMENT(); 

			}
			break;
		case 40:
			DebugEnterAlt(40);
			// MathLang.g:1:229: ML_COMMENT
			{
			DebugLocation(1, 229);
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
			"\x1\xFFFF\x6\x1D\x6\xFFFF\x2\x1D\x4\xFFFF\x1\x2D\x1\x2F\x1\x1D\x1\xFFFF"+
			"\x1\x32\x1\x34\x5\xFFFF\x4\x1D\x1\x3A\x8\x1D\x5\xFFFF\x1\x1D\x4\xFFFF"+
			"\x4\x1D\x1\x49\x1\xFFFF\x1\x1D\x1\x4C\xC\x1D\x2\xFFFF\x1\x59\x1\xFFFF"+
			"\x4\x1D\x2\x49\x1\x5E\x1\x5F\x3\x1D\x1\x63\x1\xFFFF\x1\x65\x1\x66\x1"+
			"\x1D\x1\x68\x2\xFFFF\x1\x1D\x1\x6A\x1\x1D\x1\xFFFF\x1\x1D\x2\xFFFF\x1"+
			"\x6D\x1\xFFFF\x1\x6A\x1\xFFFF\x2\x1D\x1\xFFFF\x1\x1D\x1\x71\x1\x1D\x1"+
			"\xFFFF\x1\x73\x1\xFFFF";
		private const string DFA9_eofS =
			"\x74\xFFFF";
		private const string DFA9_minS =
			"\x1\x9\x1\x61\x1\x66\x1\x6C\x1\x61\x1\x65\x1\x68\x6\xFFFF\x1\x6F\x1"+
			"\x68\x4\xFFFF\x1\x2A\x1\x3D\x1\x72\x1\xFFFF\x2\x3D\x5\xFFFF\x1\x69\x1"+
			"\x62\x1\x72\x1\x70\x1\x61\x1\x73\x1\x72\x1\x6E\x1\x6C\x1\x74\x1\x69\x1"+
			"\x6F\x1\x61\x5\xFFFF\x1\x75\x4\xFFFF\x1\x6E\x1\x6C\x1\x61\x1\x75\x1\x5B"+
			"\x1\xFFFF\x1\x65\x1\x61\x1\x63\x1\x73\x1\x75\x2\x6C\x1\x72\x1\x65\x1"+
			"\x74\x1\x61\x1\x69\x1\x6D\x1\x74\x2\xFFFF\x1\x61\x1\xFFFF\x1\x74\x1\x65"+
			"\x1\x72\x1\x65\x2\x5B\x2\x61\x1\x74\x1\x63\x1\x65\x1\x61\x1\xFFFF\x2"+
			"\x61\x1\x6E\x1\x61\x2\xFFFF\x1\x65\x1\x61\x1\x74\x1\xFFFF\x1\x6F\x2\xFFFF"+
			"\x1\x61\x1\xFFFF\x1\x61\x1\xFFFF\x1\x65\x1\x6E\x1\xFFFF\x1\x72\x1\x61"+
			"\x1\x73\x1\xFFFF\x1\x61\x1\xFFFF";
		private const string DFA9_maxS =
			"\x1\x7D\x1\x75\x1\x6E\x1\x6C\x1\x75\x1\x65\x1\x68\x6\xFFFF\x1\x6F\x1"+
			"\x68\x4\xFFFF\x1\x2F\x1\x3D\x1\x72\x1\xFFFF\x2\x3D\x5\xFFFF\x1\x69\x1"+
			"\x62\x1\x72\x1\x74\x1\x7A\x1\x73\x1\x72\x1\x6E\x1\x6C\x1\x74\x1\x69\x1"+
			"\x6F\x1\x61\x5\xFFFF\x1\x75\x4\xFFFF\x1\x76\x1\x6C\x1\x61\x1\x75\x1\x7A"+
			"\x1\xFFFF\x1\x65\x1\x7A\x1\x63\x1\x73\x1\x75\x2\x6C\x1\x72\x1\x65\x1"+
			"\x74\x1\x61\x1\x69\x1\x6D\x1\x74\x2\xFFFF\x1\x7A\x1\xFFFF\x1\x74\x1\x65"+
			"\x1\x72\x1\x65\x4\x7A\x1\x74\x1\x63\x1\x65\x1\x7A\x1\xFFFF\x2\x7A\x1"+
			"\x6E\x1\x7A\x2\xFFFF\x1\x65\x1\x7A\x1\x74\x1\xFFFF\x1\x6F\x2\xFFFF\x1"+
			"\x7A\x1\xFFFF\x1\x7A\x1\xFFFF\x1\x65\x1\x6E\x1\xFFFF\x1\x72\x1\x7A\x1"+
			"\x73\x1\xFFFF\x1\x7A\x1\xFFFF";
		private const string DFA9_acceptS =
			"\x7\xFFFF\x1\x9\x1\xA\x1\xB\x1\xC\x1\xD\x1\xE\x2\xFFFF\x1\x12\x1\x13"+
			"\x1\x14\x1\x15\x3\xFFFF\x1\x1C\x2\xFFFF\x1\x22\x1\x23\x1\x24\x1\x25\x1"+
			"\x26\xD\xFFFF\x1\x27\x1\x28\x1\x16\x1\x1B\x1\x17\x1\xFFFF\x1\x1E\x1\x1D"+
			"\x1\x20\x1\x1F\x5\xFFFF\x1\x3\xE\xFFFF\x1\x10\x1\xF\x1\xFFFF\x1\x5\xC"+
			"\xFFFF\x1\x4\x4\xFFFF\x1\x19\x1\x1\x3\xFFFF\x1\x2\x1\xFFFF\x1\x18\x1"+
			"\x1A\x1\xFFFF\x1\x8\x1\xFFFF\x1\x11\x2\xFFFF\x1\x7\x3\xFFFF\x1\x6\x1"+
			"\xFFFF\x1\x21";
		private const string DFA9_specialS =
			"\x74\xFFFF}>";
		private static readonly string[] DFA9_transitionS =
			{
				"\x2\x1B\x1\xFFFF\x2\x1B\x12\xFFFF\x1\x1B\x1\x16\x4\xFFFF\x1\x1A\x1"+
				"\x1C\x1\x8\x1\x9\x1\x12\x1\x10\x1\xA\x1\x11\x1\xFFFF\x1\x13\xA\xF\x1"+
				"\xFFFF\x1\x7\x1\x18\x1\x14\x1\x17\x22\xFFFF\x1\x1D\x1\xD\x1\xE\x1\x1D"+
				"\x1\x3\x1\x4\x2\x1D\x1\x2\x6\x1D\x1\x1\x1\x1D\x1\x5\x1\x1D\x1\x15\x2"+
				"\x1D\x1\x6\x3\x1D\x1\xB\x1\x19\x1\xC",
				"\x1\x20\x10\xFFFF\x1\x1E\x2\xFFFF\x1\x1F",
				"\x1\x22\x7\xFFFF\x1\x21",
				"\x1\x23",
				"\x1\x26\xD\xFFFF\x1\x24\x5\xFFFF\x1\x25",
				"\x1\x27",
				"\x1\x28",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x29",
				"\x1\x2A",
				"",
				"",
				"",
				"",
				"\x1\x2C\x4\xFFFF\x1\x2B",
				"\x1\x2E",
				"\x1\x30",
				"",
				"\x1\x31",
				"\x1\x33",
				"",
				"",
				"",
				"",
				"",
				"\x1\x35",
				"\x1\x36",
				"\x1\x37",
				"\x1\x38\x3\xFFFF\x1\x39",
				"\x1A\x1D",
				"\x1\x3B",
				"\x1\x3C",
				"\x1\x3D",
				"\x1\x3E",
				"\x1\x3F",
				"\x1\x40",
				"\x1\x41",
				"\x1\x42",
				"",
				"",
				"",
				"",
				"",
				"\x1\x43",
				"",
				"",
				"",
				"",
				"\x1\x44\x7\xFFFF\x1\x45",
				"\x1\x46",
				"\x1\x47",
				"\x1\x48",
				"\x1\x4A\x5\xFFFF\x1A\x1D",
				"",
				"\x1\x4B",
				"\x1A\x1D",
				"\x1\x4D",
				"\x1\x4E",
				"\x1\x4F",
				"\x1\x50",
				"\x1\x51",
				"\x1\x52",
				"\x1\x53",
				"\x1\x54",
				"\x1\x55",
				"\x1\x56",
				"\x1\x57",
				"\x1\x58",
				"",
				"",
				"\x1A\x1D",
				"",
				"\x1\x5A",
				"\x1\x5B",
				"\x1\x5C",
				"\x1\x5D",
				"\x1\x4A\x5\xFFFF\x1A\x1D",
				"\x1\x4A\x5\xFFFF\x1A\x1D",
				"\x1A\x1D",
				"\x1A\x1D",
				"\x1\x60",
				"\x1\x61",
				"\x1\x62",
				"\x1A\x1D",
				"",
				"\x8\x1D\x1\x64\x11\x1D",
				"\x1A\x1D",
				"\x1\x67",
				"\x1A\x1D",
				"",
				"",
				"\x1\x69",
				"\x1A\x1D",
				"\x1\x6B",
				"",
				"\x1\x6C",
				"",
				"",
				"\x1A\x1D",
				"",
				"\x1A\x1D",
				"",
				"\x1\x6E",
				"\x1\x6F",
				"",
				"\x1\x70",
				"\x1A\x1D",
				"\x1\x72",
				"",
				"\x1A\x1D",
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

		public override string Description { get { return "1:1: Tokens : ( PRINT | INPUT | IF | ELSE | FOR | FUNCTION | RETURN | WHILE | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | ARRAY | TYPE | ACCESS_MODIFIER | NUMBER | ADD | SUB | MUL | DIV | ASSIGN | FUNCT | TRUE | FALSE | EQ | NEQ | GR | GREQ | LS | LSEQ | PARAMETERS | OR | AND | WS | CHAR | ID | SL_COMMENT | ML_COMMENT );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}

} // namespace  MathLang 

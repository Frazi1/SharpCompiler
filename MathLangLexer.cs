// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-10-02 14:07:45

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
	public const int T__44=44;
	public const int T__45=45;
	public const int T__46=46;
	public const int T__47=47;
	public const int T__48=48;
	public const int T__49=49;
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
	public const int NOT=34;
	public const int TRUE=35;
	public const int FALSE=36;
	public const int TYPEDEF=37;
	public const int ACCESS_MODIFIER=38;
	public const int RETURNS=39;
	public const int PARAMETERS=40;
	public const int WS=41;
	public const int SL_COMMENT=42;
	public const int ML_COMMENT=43;

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

	partial void Enter_T__44();
	partial void Leave_T__44();

	// $ANTLR start "T__44"
	[GrammarRule("T__44")]
	private void mT__44()
	{
		Enter_T__44();
		EnterRule("T__44", 8);
		TraceIn("T__44", 8);
		try
		{
			int _type = T__44;
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
			TraceOut("T__44", 8);
			LeaveRule("T__44", 8);
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
		EnterRule("T__45", 9);
		TraceIn("T__45", 9);
		try
		{
			int _type = T__45;
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
			TraceOut("T__45", 9);
			LeaveRule("T__45", 9);
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
		EnterRule("T__46", 10);
		TraceIn("T__46", 10);
		try
		{
			int _type = T__46;
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
			TraceOut("T__46", 10);
			LeaveRule("T__46", 10);
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
		EnterRule("T__47", 11);
		TraceIn("T__47", 11);
		try
		{
			int _type = T__47;
			int _channel = DefaultTokenChannel;
			// MathLang.g:19:7: ( ',' )
			DebugEnterAlt(1);
			// MathLang.g:19:9: ','
			{
			DebugLocation(19, 9);
			Match(','); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__47", 11);
			LeaveRule("T__47", 11);
			Leave_T__47();
		}
	}
	// $ANTLR end "T__47"

	partial void Enter_T__48();
	partial void Leave_T__48();

	// $ANTLR start "T__48"
	[GrammarRule("T__48")]
	private void mT__48()
	{
		Enter_T__48();
		EnterRule("T__48", 12);
		TraceIn("T__48", 12);
		try
		{
			int _type = T__48;
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
			TraceOut("T__48", 12);
			LeaveRule("T__48", 12);
			Leave_T__48();
		}
	}
	// $ANTLR end "T__48"

	partial void Enter_T__49();
	partial void Leave_T__49();

	// $ANTLR start "T__49"
	[GrammarRule("T__49")]
	private void mT__49()
	{
		Enter_T__49();
		EnterRule("T__49", 13);
		TraceIn("T__49", 13);
		try
		{
			int _type = T__49;
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
			TraceOut("T__49", 13);
			LeaveRule("T__49", 13);
			Leave_T__49();
		}
	}
	// $ANTLR end "T__49"

	partial void Enter_TYPE();
	partial void Leave_TYPE();

	// $ANTLR start "TYPE"
	[GrammarRule("TYPE")]
	private void mTYPE()
	{
		Enter_TYPE();
		EnterRule("TYPE", 14);
		TraceIn("TYPE", 14);
		try
		{
			int _type = TYPE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:103:5: ( TYPEDEF | ARRAY )
			int alt1=2;
			try { DebugEnterDecision(1, decisionCanBacktrack[1]);
			try
			{
				alt1 = dfa1.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(1); }
			switch (alt1)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:103:7: TYPEDEF
				{
				DebugLocation(103, 7);
				mTYPEDEF(); 

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:103:17: ARRAY
				{
				DebugLocation(103, 17);
				mARRAY(); 

				}
				break;

			}
			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TYPE", 14);
			LeaveRule("TYPE", 14);
			Leave_TYPE();
		}
	}
	// $ANTLR end "TYPE"

	partial void Enter_TYPEDEF();
	partial void Leave_TYPEDEF();

	// $ANTLR start "TYPEDEF"
	[GrammarRule("TYPEDEF")]
	private void mTYPEDEF()
	{
		Enter_TYPEDEF();
		EnterRule("TYPEDEF", 15);
		TraceIn("TYPEDEF", 15);
		try
		{
			int _type = TYPEDEF;
			int _channel = DefaultTokenChannel;
			// MathLang.g:104:8: ( 'int' | 'bool' | 'char' )
			int alt2=3;
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
				// MathLang.g:104:10: 'int'
				{
				DebugLocation(104, 10);
				Match("int"); 


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:104:18: 'bool'
				{
				DebugLocation(104, 18);
				Match("bool"); 


				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:104:27: 'char'
				{
				DebugLocation(104, 27);
				Match("char"); 


				}
				break;

			}
			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TYPEDEF", 15);
			LeaveRule("TYPEDEF", 15);
			Leave_TYPEDEF();
		}
	}
	// $ANTLR end "TYPEDEF"

	partial void Enter_ARRAY();
	partial void Leave_ARRAY();

	// $ANTLR start "ARRAY"
	[GrammarRule("ARRAY")]
	private void mARRAY()
	{
		Enter_ARRAY();
		EnterRule("ARRAY", 16);
		TraceIn("ARRAY", 16);
		try
		{
			int _type = ARRAY;
			int _channel = DefaultTokenChannel;
			// MathLang.g:105:6: ( ( TYPEDEF '[]' ) )
			DebugEnterAlt(1);
			// MathLang.g:105:8: ( TYPEDEF '[]' )
			{
			DebugLocation(105, 8);
			// MathLang.g:105:8: ( TYPEDEF '[]' )
			DebugEnterAlt(1);
			// MathLang.g:105:9: TYPEDEF '[]'
			{
			DebugLocation(105, 9);
			mTYPEDEF(); 
			DebugLocation(105, 17);
			Match("[]"); 


			}


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ARRAY", 16);
			LeaveRule("ARRAY", 16);
			Leave_ARRAY();
		}
	}
	// $ANTLR end "ARRAY"

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
			// MathLang.g:106:16: ( 'public' | 'private' )
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
				// MathLang.g:106:18: 'public'
				{
				DebugLocation(106, 18);
				Match("public"); 


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:106:29: 'private'
				{
				DebugLocation(106, 29);
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
			// MathLang.g:107:7: ( ( '0' .. '9' )+ )
			DebugEnterAlt(1);
			// MathLang.g:107:9: ( '0' .. '9' )+
			{
			DebugLocation(107, 9);
			// MathLang.g:107:9: ( '0' .. '9' )+
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
					// MathLang.g:107:10: '0' .. '9'
					{
					DebugLocation(107, 10);
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
			// MathLang.g:108:4: ( '+' )
			DebugEnterAlt(1);
			// MathLang.g:108:9: '+'
			{
			DebugLocation(108, 9);
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
			// MathLang.g:109:4: ( '-' )
			DebugEnterAlt(1);
			// MathLang.g:109:9: '-'
			{
			DebugLocation(109, 9);
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
			// MathLang.g:110:4: ( '*' )
			DebugEnterAlt(1);
			// MathLang.g:110:9: '*'
			{
			DebugLocation(110, 9);
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
			// MathLang.g:111:4: ( '/' )
			DebugEnterAlt(1);
			// MathLang.g:111:9: '/'
			{
			DebugLocation(111, 9);
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
			// MathLang.g:112:7: ( '=' )
			DebugEnterAlt(1);
			// MathLang.g:112:9: '='
			{
			DebugLocation(112, 9);
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

	partial void Enter_RETURN();
	partial void Leave_RETURN();

	// $ANTLR start "RETURN"
	[GrammarRule("RETURN")]
	private void mRETURN()
	{
		Enter_RETURN();
		EnterRule("RETURN", 24);
		TraceIn("RETURN", 24);
		try
		{
			int _type = RETURN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:113:7: ( 'return' )
			DebugEnterAlt(1);
			// MathLang.g:113:9: 'return'
			{
			DebugLocation(113, 9);
			Match("return"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RETURN", 24);
			LeaveRule("RETURN", 24);
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
		EnterRule("RETURNS", 25);
		TraceIn("RETURNS", 25);
		try
		{
			int _type = RETURNS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:114:8: ( 'returns' )
			DebugEnterAlt(1);
			// MathLang.g:114:9: 'returns'
			{
			DebugLocation(114, 9);
			Match("returns"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RETURNS", 25);
			LeaveRule("RETURNS", 25);
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
		EnterRule("TRUE", 26);
		TraceIn("TRUE", 26);
		try
		{
			int _type = TRUE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:115:5: ( 'true' )
			DebugEnterAlt(1);
			// MathLang.g:115:7: 'true'
			{
			DebugLocation(115, 7);
			Match("true"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TRUE", 26);
			LeaveRule("TRUE", 26);
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
		EnterRule("FALSE", 27);
		TraceIn("FALSE", 27);
		try
		{
			int _type = FALSE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:116:6: ( 'false' )
			DebugEnterAlt(1);
			// MathLang.g:116:8: 'false'
			{
			DebugLocation(116, 8);
			Match("false"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FALSE", 27);
			LeaveRule("FALSE", 27);
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
		EnterRule("EQ", 28);
		TraceIn("EQ", 28);
		try
		{
			int _type = EQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:117:3: ( '==' )
			DebugEnterAlt(1);
			// MathLang.g:117:6: '=='
			{
			DebugLocation(117, 6);
			Match("=="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EQ", 28);
			LeaveRule("EQ", 28);
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
		EnterRule("NEQ", 29);
		TraceIn("NEQ", 29);
		try
		{
			int _type = NEQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:118:4: ( '!=' )
			DebugEnterAlt(1);
			// MathLang.g:118:6: '!='
			{
			DebugLocation(118, 6);
			Match("!="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NEQ", 29);
			LeaveRule("NEQ", 29);
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
		EnterRule("GR", 30);
		TraceIn("GR", 30);
		try
		{
			int _type = GR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:119:3: ( '>' )
			DebugEnterAlt(1);
			// MathLang.g:119:6: '>'
			{
			DebugLocation(119, 6);
			Match('>'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GR", 30);
			LeaveRule("GR", 30);
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
		EnterRule("GREQ", 31);
		TraceIn("GREQ", 31);
		try
		{
			int _type = GREQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:120:5: ( '>=' )
			DebugEnterAlt(1);
			// MathLang.g:120:9: '>='
			{
			DebugLocation(120, 9);
			Match(">="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GREQ", 31);
			LeaveRule("GREQ", 31);
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
		EnterRule("LS", 32);
		TraceIn("LS", 32);
		try
		{
			int _type = LS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:121:3: ( '<' )
			DebugEnterAlt(1);
			// MathLang.g:121:6: '<'
			{
			DebugLocation(121, 6);
			Match('<'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LS", 32);
			LeaveRule("LS", 32);
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
		EnterRule("LSEQ", 33);
		TraceIn("LSEQ", 33);
		try
		{
			int _type = LSEQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:122:5: ( '<=' )
			DebugEnterAlt(1);
			// MathLang.g:122:7: '<='
			{
			DebugLocation(122, 7);
			Match("<="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LSEQ", 33);
			LeaveRule("LSEQ", 33);
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
		EnterRule("NOT", 34);
		TraceIn("NOT", 34);
		try
		{
			int _type = NOT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:123:4: ( '!' )
			DebugEnterAlt(1);
			// MathLang.g:123:6: '!'
			{
			DebugLocation(123, 6);
			Match('!'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NOT", 34);
			LeaveRule("NOT", 34);
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
		EnterRule("PARAMETERS", 35);
		TraceIn("PARAMETERS", 35);
		try
		{
			int _type = PARAMETERS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:124:11: ( 'parameters' )
			DebugEnterAlt(1);
			// MathLang.g:124:13: 'parameters'
			{
			DebugLocation(124, 13);
			Match("parameters"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PARAMETERS", 35);
			LeaveRule("PARAMETERS", 35);
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
		EnterRule("OR", 36);
		TraceIn("OR", 36);
		try
		{
			int _type = OR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:125:3: ( '||' )
			DebugEnterAlt(1);
			// MathLang.g:125:6: '||'
			{
			DebugLocation(125, 6);
			Match("||"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OR", 36);
			LeaveRule("OR", 36);
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
		EnterRule("AND", 37);
		TraceIn("AND", 37);
		try
		{
			int _type = AND;
			int _channel = DefaultTokenChannel;
			// MathLang.g:126:4: ( '&&' )
			DebugEnterAlt(1);
			// MathLang.g:126:6: '&&'
			{
			DebugLocation(126, 6);
			Match("&&"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("AND", 37);
			LeaveRule("AND", 37);
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
		EnterRule("WS", 38);
		TraceIn("WS", 38);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:127:3: ( ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+ )
			DebugEnterAlt(1);
			// MathLang.g:128:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			{
			DebugLocation(128, 3);
			// MathLang.g:128:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
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
					DebugLocation(128, 3);
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

			DebugLocation(128, 41);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 38);
			LeaveRule("WS", 38);
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
		EnterRule("CHAR", 39);
		TraceIn("CHAR", 39);
		try
		{
			int _type = CHAR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:132:5: ( '\\'' ( 'a' .. 'z' ) '\\'' )
			DebugEnterAlt(1);
			// MathLang.g:132:8: '\\'' ( 'a' .. 'z' ) '\\''
			{
			DebugLocation(132, 8);
			Match('\''); 
			DebugLocation(132, 12);
			// MathLang.g:132:12: ( 'a' .. 'z' )
			DebugEnterAlt(1);
			// MathLang.g:132:13: 'a' .. 'z'
			{
			DebugLocation(132, 13);
			MatchRange('a','z'); 

			}

			DebugLocation(132, 22);
			Match('\''); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CHAR", 39);
			LeaveRule("CHAR", 39);
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
		EnterRule("ID", 40);
		TraceIn("ID", 40);
		try
		{
			int _type = ID;
			int _channel = DefaultTokenChannel;
			// MathLang.g:133:3: ( ( 'a' .. 'z' )+ )
			DebugEnterAlt(1);
			// MathLang.g:133:6: ( 'a' .. 'z' )+
			{
			DebugLocation(133, 6);
			// MathLang.g:133:6: ( 'a' .. 'z' )+
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
					// MathLang.g:133:7: 'a' .. 'z'
					{
					DebugLocation(133, 7);
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
			TraceOut("ID", 40);
			LeaveRule("ID", 40);
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
		EnterRule("SL_COMMENT", 41);
		TraceIn("SL_COMMENT", 41);
		try
		{
			int _type = SL_COMMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:137:11: ( '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n' )
			DebugEnterAlt(1);
			// MathLang.g:138:3: '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n'
			{
			DebugLocation(138, 3);
			Match("//"); 

			DebugLocation(138, 8);
			// MathLang.g:138:8: ( options {greedy=false; } : . )*
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
					// MathLang.g:138:36: .
					{
					DebugLocation(138, 36);
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

			DebugLocation(138, 40);
			// MathLang.g:138:40: ( '\\r' )?
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
				// MathLang.g:138:40: '\\r'
				{
				DebugLocation(138, 40);
				Match('\r'); 

				}
				break;

			}
			} finally { DebugExitSubRule(8); }

			DebugLocation(138, 46);
			Match('\n'); 
			DebugLocation(138, 51);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SL_COMMENT", 41);
			LeaveRule("SL_COMMENT", 41);
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
		EnterRule("ML_COMMENT", 42);
		TraceIn("ML_COMMENT", 42);
		try
		{
			int _type = ML_COMMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:142:11: ( '/*' ( options {greedy=false; } : . )* '*/' )
			DebugEnterAlt(1);
			// MathLang.g:143:3: '/*' ( options {greedy=false; } : . )* '*/'
			{
			DebugLocation(143, 3);
			Match("/*"); 

			DebugLocation(143, 8);
			// MathLang.g:143:8: ( options {greedy=false; } : . )*
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
					// MathLang.g:143:36: .
					{
					DebugLocation(143, 36);
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

			DebugLocation(143, 40);
			Match("*/"); 

			DebugLocation(143, 45);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ML_COMMENT", 42);
			LeaveRule("ML_COMMENT", 42);
			Leave_ML_COMMENT();
		}
	}
	// $ANTLR end "ML_COMMENT"

	public override void mTokens()
	{
		// MathLang.g:1:8: ( PRINT | INPUT | IF | ELSE | FOR | FUNCTION | WHILE | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 | TYPE | TYPEDEF | ARRAY | ACCESS_MODIFIER | NUMBER | ADD | SUB | MUL | DIV | ASSIGN | RETURN | RETURNS | TRUE | FALSE | EQ | NEQ | GR | GREQ | LS | LSEQ | NOT | PARAMETERS | OR | AND | WS | CHAR | ID | SL_COMMENT | ML_COMMENT )
		int alt10=42;
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
			// MathLang.g:1:49: T__44
			{
			DebugLocation(1, 49);
			mT__44(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// MathLang.g:1:55: T__45
			{
			DebugLocation(1, 55);
			mT__45(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// MathLang.g:1:61: T__46
			{
			DebugLocation(1, 61);
			mT__46(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// MathLang.g:1:67: T__47
			{
			DebugLocation(1, 67);
			mT__47(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// MathLang.g:1:73: T__48
			{
			DebugLocation(1, 73);
			mT__48(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// MathLang.g:1:79: T__49
			{
			DebugLocation(1, 79);
			mT__49(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// MathLang.g:1:85: TYPE
			{
			DebugLocation(1, 85);
			mTYPE(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// MathLang.g:1:90: TYPEDEF
			{
			DebugLocation(1, 90);
			mTYPEDEF(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// MathLang.g:1:98: ARRAY
			{
			DebugLocation(1, 98);
			mARRAY(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// MathLang.g:1:104: ACCESS_MODIFIER
			{
			DebugLocation(1, 104);
			mACCESS_MODIFIER(); 

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// MathLang.g:1:120: NUMBER
			{
			DebugLocation(1, 120);
			mNUMBER(); 

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// MathLang.g:1:127: ADD
			{
			DebugLocation(1, 127);
			mADD(); 

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// MathLang.g:1:131: SUB
			{
			DebugLocation(1, 131);
			mSUB(); 

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// MathLang.g:1:135: MUL
			{
			DebugLocation(1, 135);
			mMUL(); 

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// MathLang.g:1:139: DIV
			{
			DebugLocation(1, 139);
			mDIV(); 

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// MathLang.g:1:143: ASSIGN
			{
			DebugLocation(1, 143);
			mASSIGN(); 

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// MathLang.g:1:150: RETURN
			{
			DebugLocation(1, 150);
			mRETURN(); 

			}
			break;
		case 25:
			DebugEnterAlt(25);
			// MathLang.g:1:157: RETURNS
			{
			DebugLocation(1, 157);
			mRETURNS(); 

			}
			break;
		case 26:
			DebugEnterAlt(26);
			// MathLang.g:1:165: TRUE
			{
			DebugLocation(1, 165);
			mTRUE(); 

			}
			break;
		case 27:
			DebugEnterAlt(27);
			// MathLang.g:1:170: FALSE
			{
			DebugLocation(1, 170);
			mFALSE(); 

			}
			break;
		case 28:
			DebugEnterAlt(28);
			// MathLang.g:1:176: EQ
			{
			DebugLocation(1, 176);
			mEQ(); 

			}
			break;
		case 29:
			DebugEnterAlt(29);
			// MathLang.g:1:179: NEQ
			{
			DebugLocation(1, 179);
			mNEQ(); 

			}
			break;
		case 30:
			DebugEnterAlt(30);
			// MathLang.g:1:183: GR
			{
			DebugLocation(1, 183);
			mGR(); 

			}
			break;
		case 31:
			DebugEnterAlt(31);
			// MathLang.g:1:186: GREQ
			{
			DebugLocation(1, 186);
			mGREQ(); 

			}
			break;
		case 32:
			DebugEnterAlt(32);
			// MathLang.g:1:191: LS
			{
			DebugLocation(1, 191);
			mLS(); 

			}
			break;
		case 33:
			DebugEnterAlt(33);
			// MathLang.g:1:194: LSEQ
			{
			DebugLocation(1, 194);
			mLSEQ(); 

			}
			break;
		case 34:
			DebugEnterAlt(34);
			// MathLang.g:1:199: NOT
			{
			DebugLocation(1, 199);
			mNOT(); 

			}
			break;
		case 35:
			DebugEnterAlt(35);
			// MathLang.g:1:203: PARAMETERS
			{
			DebugLocation(1, 203);
			mPARAMETERS(); 

			}
			break;
		case 36:
			DebugEnterAlt(36);
			// MathLang.g:1:214: OR
			{
			DebugLocation(1, 214);
			mOR(); 

			}
			break;
		case 37:
			DebugEnterAlt(37);
			// MathLang.g:1:217: AND
			{
			DebugLocation(1, 217);
			mAND(); 

			}
			break;
		case 38:
			DebugEnterAlt(38);
			// MathLang.g:1:221: WS
			{
			DebugLocation(1, 221);
			mWS(); 

			}
			break;
		case 39:
			DebugEnterAlt(39);
			// MathLang.g:1:224: CHAR
			{
			DebugLocation(1, 224);
			mCHAR(); 

			}
			break;
		case 40:
			DebugEnterAlt(40);
			// MathLang.g:1:229: ID
			{
			DebugLocation(1, 229);
			mID(); 

			}
			break;
		case 41:
			DebugEnterAlt(41);
			// MathLang.g:1:232: SL_COMMENT
			{
			DebugLocation(1, 232);
			mSL_COMMENT(); 

			}
			break;
		case 42:
			DebugEnterAlt(42);
			// MathLang.g:1:243: ML_COMMENT
			{
			DebugLocation(1, 243);
			mML_COMMENT(); 

			}
			break;

		}

	}


	#region DFA
	DFA1 dfa1;
	DFA10 dfa10;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa1 = new DFA1(this);
		dfa10 = new DFA10(this);
	}

	private class DFA1 : DFA
	{
		private const string DFA1_eotS =
			"\x7\xFFFF\x1\xA\x4\xFFFF\x2\xA";
		private const string DFA1_eofS =
			"\xE\xFFFF";
		private const string DFA1_minS =
			"\x1\x62\x1\x6E\x1\x6F\x1\x68\x1\x74\x1\x6F\x1\x61\x1\x5B\x1\x6C\x1\x72"+
			"\x2\xFFFF\x2\x5B";
		private const string DFA1_maxS =
			"\x1\x69\x1\x6E\x1\x6F\x1\x68\x1\x74\x1\x6F\x1\x61\x1\x5B\x1\x6C\x1\x72"+
			"\x2\xFFFF\x2\x5B";
		private const string DFA1_acceptS =
			"\xA\xFFFF\x1\x1\x1\x2\x2\xFFFF";
		private const string DFA1_specialS =
			"\xE\xFFFF}>";
		private static readonly string[] DFA1_transitionS =
			{
				"\x1\x2\x1\x3\x5\xFFFF\x1\x1",
				"\x1\x4",
				"\x1\x5",
				"\x1\x6",
				"\x1\x7",
				"\x1\x8",
				"\x1\x9",
				"\x1\xB",
				"\x1\xC",
				"\x1\xD",
				"",
				"",
				"\x1\xB",
				"\x1\xB"
			};

		private static readonly short[] DFA1_eot = DFA.UnpackEncodedString(DFA1_eotS);
		private static readonly short[] DFA1_eof = DFA.UnpackEncodedString(DFA1_eofS);
		private static readonly char[] DFA1_min = DFA.UnpackEncodedStringToUnsignedChars(DFA1_minS);
		private static readonly char[] DFA1_max = DFA.UnpackEncodedStringToUnsignedChars(DFA1_maxS);
		private static readonly short[] DFA1_accept = DFA.UnpackEncodedString(DFA1_acceptS);
		private static readonly short[] DFA1_special = DFA.UnpackEncodedString(DFA1_specialS);
		private static readonly short[][] DFA1_transition;

		static DFA1()
		{
			int numStates = DFA1_transitionS.Length;
			DFA1_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA1_transition[i] = DFA.UnpackEncodedString(DFA1_transitionS[i]);
			}
		}

		public DFA1( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 1;
			this.eot = DFA1_eot;
			this.eof = DFA1_eof;
			this.min = DFA1_min;
			this.max = DFA1_max;
			this.accept = DFA1_accept;
			this.special = DFA1_special;
			this.transition = DFA1_transition;
		}

		public override string Description { get { return "103:1: TYPE : ( TYPEDEF | ARRAY );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA10 : DFA
	{
		private const string DFA10_eotS =
			"\x1\xFFFF\x5\x1D\x6\xFFFF\x2\x1D\x4\xFFFF\x1\x2C\x1\x2E\x2\x1D\x1\x32"+
			"\x1\x34\x1\x36\x5\xFFFF\x4\x1D\x1\x3C\x7\x1D\x5\xFFFF\x2\x1D\x6\xFFFF"+
			"\x4\x1D\x1\x4B\x1\xFFFF\x1\x1D\x1\x4E\xC\x1D\x2\xFFFF\x1\x5C\x1\xFFFF"+
			"\x3\x1D\x2\x4B\x1\x1D\x1\x61\x1\x62\x3\x1D\x1\x66\x2\xFFFF\x1\x1D\x1"+
			"\x68\x1\x69\x1\x1D\x2\xFFFF\x1\x1D\x1\x6C\x1\x1D\x1\xFFFF\x1\x1D\x2\xFFFF"+
			"\x1\x70\x1\x6C\x1\xFFFF\x2\x1D\x1\x73\x1\xFFFF\x1\x1D\x1\x75\x1\xFFFF"+
			"\x1\x1D\x1\xFFFF\x1\x77\x1\xFFFF";
		private const string DFA10_eofS =
			"\x78\xFFFF";
		private const string DFA10_minS =
			"\x1\x9\x1\x61\x1\x66\x1\x6C\x1\x61\x1\x68\x6\xFFFF\x1\x6F\x1\x68\x4"+
			"\xFFFF\x1\x2A\x1\x3D\x1\x65\x1\x72\x3\x3D\x5\xFFFF\x1\x69\x1\x62\x1\x72"+
			"\x1\x70\x1\x61\x1\x73\x1\x72\x1\x6E\x1\x6C\x1\x69\x1\x6F\x1\x61\x5\xFFFF"+
			"\x1\x74\x1\x75\x6\xFFFF\x1\x6E\x1\x6C\x1\x61\x1\x75\x1\x5B\x1\xFFFF\x1"+
			"\x65\x1\x61\x1\x63\x1\x73\x2\x6C\x1\x72\x1\x75\x1\x65\x1\x74\x1\x61\x1"+
			"\x69\x1\x6D\x1\x74\x1\xFFFF\x1\x5D\x1\x61\x1\xFFFF\x1\x74\x2\x65\x2\x5B"+
			"\x1\x72\x2\x61\x1\x74\x1\x63\x1\x65\x1\x61\x2\xFFFF\x1\x69\x2\x61\x1"+
			"\x6E\x2\xFFFF\x1\x65\x1\x61\x1\x74\x1\xFFFF\x1\x6F\x2\xFFFF\x2\x61\x1"+
			"\xFFFF\x1\x65\x1\x6E\x1\x61\x1\xFFFF\x1\x72\x1\x61\x1\xFFFF\x1\x73\x1"+
			"\xFFFF\x1\x61\x1\xFFFF";
		private const string DFA10_maxS =
			"\x1\x7D\x1\x75\x1\x6E\x1\x6C\x1\x75\x1\x68\x6\xFFFF\x1\x6F\x1\x68\x4"+
			"\xFFFF\x1\x2F\x1\x3D\x1\x65\x1\x72\x3\x3D\x5\xFFFF\x1\x69\x1\x62\x1\x72"+
			"\x1\x74\x1\x7A\x1\x73\x1\x72\x1\x6E\x1\x6C\x1\x69\x1\x6F\x1\x61\x5\xFFFF"+
			"\x1\x74\x1\x75\x6\xFFFF\x1\x76\x1\x6C\x1\x61\x1\x75\x1\x7A\x1\xFFFF\x1"+
			"\x65\x1\x7A\x1\x63\x1\x73\x2\x6C\x1\x72\x1\x75\x1\x65\x1\x74\x1\x61\x1"+
			"\x69\x1\x6D\x1\x74\x1\xFFFF\x1\x5D\x1\x7A\x1\xFFFF\x1\x74\x2\x65\x2\x7A"+
			"\x1\x72\x2\x7A\x1\x74\x1\x63\x1\x65\x1\x7A\x2\xFFFF\x1\x69\x2\x7A\x1"+
			"\x6E\x2\xFFFF\x1\x65\x1\x7A\x1\x74\x1\xFFFF\x1\x6F\x2\xFFFF\x2\x7A\x1"+
			"\xFFFF\x1\x65\x1\x6E\x1\x7A\x1\xFFFF\x1\x72\x1\x7A\x1\xFFFF\x1\x73\x1"+
			"\xFFFF\x1\x7A\x1\xFFFF";
		private const string DFA10_acceptS =
			"\x6\xFFFF\x1\x8\x1\x9\x1\xA\x1\xB\x1\xC\x1\xD\x2\xFFFF\x1\x12\x1\x13"+
			"\x1\x14\x1\x15\x7\xFFFF\x1\x24\x1\x25\x1\x26\x1\x27\x1\x28\xC\xFFFF\x1"+
			"\x29\x1\x2A\x1\x16\x1\x1C\x1\x17\x2\xFFFF\x1\x1D\x1\x22\x1\x1F\x1\x1E"+
			"\x1\x21\x1\x20\x5\xFFFF\x1\x3\xE\xFFFF\x1\xE\x2\xFFFF\x1\x5\xC\xFFFF"+
			"\x1\xE\x1\x4\x4\xFFFF\x1\x1A\x1\x1\x3\xFFFF\x1\x2\x1\xFFFF\x1\x1B\x1"+
			"\x7\x2\xFFFF\x1\x11\x3\xFFFF\x1\x18\x2\xFFFF\x1\x19\x1\xFFFF\x1\x6\x1"+
			"\xFFFF\x1\x23";
		private const string DFA10_specialS =
			"\x78\xFFFF}>";
		private static readonly string[] DFA10_transitionS =
			{
				"\x2\x1B\x1\xFFFF\x2\x1B\x12\xFFFF\x1\x1B\x1\x16\x4\xFFFF\x1\x1A\x1"+
				"\x1C\x1\x7\x1\x8\x1\x11\x1\xF\x1\x9\x1\x10\x1\xFFFF\x1\x12\xA\xE\x1"+
				"\xFFFF\x1\x6\x1\x18\x1\x13\x1\x17\x22\xFFFF\x1\x1D\x1\xC\x1\xD\x1\x1D"+
				"\x1\x3\x1\x4\x2\x1D\x1\x2\x6\x1D\x1\x1\x1\x1D\x1\x14\x1\x1D\x1\x15\x2"+
				"\x1D\x1\x5\x3\x1D\x1\xA\x1\x19\x1\xB",
				"\x1\x20\x10\xFFFF\x1\x1E\x2\xFFFF\x1\x1F",
				"\x1\x22\x7\xFFFF\x1\x21",
				"\x1\x23",
				"\x1\x26\xD\xFFFF\x1\x24\x5\xFFFF\x1\x25",
				"\x1\x27",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x28",
				"\x1\x29",
				"",
				"",
				"",
				"",
				"\x1\x2B\x4\xFFFF\x1\x2A",
				"\x1\x2D",
				"\x1\x2F",
				"\x1\x30",
				"\x1\x31",
				"\x1\x33",
				"\x1\x35",
				"",
				"",
				"",
				"",
				"",
				"\x1\x37",
				"\x1\x38",
				"\x1\x39",
				"\x1\x3A\x3\xFFFF\x1\x3B",
				"\x1A\x1D",
				"\x1\x3D",
				"\x1\x3E",
				"\x1\x3F",
				"\x1\x40",
				"\x1\x41",
				"\x1\x42",
				"\x1\x43",
				"",
				"",
				"",
				"",
				"",
				"\x1\x44",
				"\x1\x45",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x46\x7\xFFFF\x1\x47",
				"\x1\x48",
				"\x1\x49",
				"\x1\x4A",
				"\x1\x4C\x5\xFFFF\x1A\x1D",
				"",
				"\x1\x4D",
				"\x1A\x1D",
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
				"\x1\x59",
				"\x1\x5A",
				"",
				"\x1\x5B",
				"\x1A\x1D",
				"",
				"\x1\x5D",
				"\x1\x5E",
				"\x1\x5F",
				"\x1\x4C\x5\xFFFF\x1A\x1D",
				"\x1\x4C\x5\xFFFF\x1A\x1D",
				"\x1\x60",
				"\x1A\x1D",
				"\x1A\x1D",
				"\x1\x63",
				"\x1\x64",
				"\x1\x65",
				"\x1A\x1D",
				"",
				"",
				"\x1\x67",
				"\x1A\x1D",
				"\x1A\x1D",
				"\x1\x6A",
				"",
				"",
				"\x1\x6B",
				"\x1A\x1D",
				"\x1\x6D",
				"",
				"\x1\x6E",
				"",
				"",
				"\x12\x1D\x1\x6F\x7\x1D",
				"\x1A\x1D",
				"",
				"\x1\x71",
				"\x1\x72",
				"\x1A\x1D",
				"",
				"\x1\x74",
				"\x1A\x1D",
				"",
				"\x1\x76",
				"",
				"\x1A\x1D",
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

		public override string Description { get { return "1:1: Tokens : ( PRINT | INPUT | IF | ELSE | FOR | FUNCTION | WHILE | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 | TYPE | TYPEDEF | ARRAY | ACCESS_MODIFIER | NUMBER | ADD | SUB | MUL | DIV | ASSIGN | RETURN | RETURNS | TRUE | FALSE | EQ | NEQ | GR | GREQ | LS | LSEQ | NOT | PARAMETERS | OR | AND | WS | CHAR | ID | SL_COMMENT | ML_COMMENT );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}

} // namespace  MathLang 

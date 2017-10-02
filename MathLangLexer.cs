// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-10-02 21:03:14

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
	public const int T__49=49;
	public const int T__50=50;
	public const int T__51=51;
	public const int T__52=52;
	public const int T__53=53;
	public const int T__54=54;
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
	public const int NUMBER=19;
	public const int ID=20;
	public const int CHAR=21;
	public const int TYPE=22;
	public const int ASSIGN=23;
	public const int ADD=24;
	public const int SUB=25;
	public const int MUL=26;
	public const int DIV=27;
	public const int GREQ=28;
	public const int LSEQ=29;
	public const int NEQ=30;
	public const int EQ=31;
	public const int GR=32;
	public const int LS=33;
	public const int OR=34;
	public const int AND=35;
	public const int NOT=36;
	public const int TRUE=37;
	public const int FALSE=38;
	public const int KNEW=39;
	public const int TYPE0=40;
	public const int SQRBL=41;
	public const int SQRBR=42;
	public const int ACCESS_MODIFIER=43;
	public const int RETURNS=44;
	public const int PARAMETERS=45;
	public const int WS=46;
	public const int SL_COMMENT=47;
	public const int ML_COMMENT=48;

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

	partial void Enter_T__49();
	partial void Leave_T__49();

	// $ANTLR start "T__49"
	[GrammarRule("T__49")]
	private void mT__49()
	{
		Enter_T__49();
		EnterRule("T__49", 11);
		TraceIn("T__49", 11);
		try
		{
			int _type = T__49;
			int _channel = DefaultTokenChannel;
			// MathLang.g:19:7: ( ';' )
			DebugEnterAlt(1);
			// MathLang.g:19:9: ';'
			{
			DebugLocation(19, 9);
			Match(';'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__49", 11);
			LeaveRule("T__49", 11);
			Leave_T__49();
		}
	}
	// $ANTLR end "T__49"

	partial void Enter_T__50();
	partial void Leave_T__50();

	// $ANTLR start "T__50"
	[GrammarRule("T__50")]
	private void mT__50()
	{
		Enter_T__50();
		EnterRule("T__50", 12);
		TraceIn("T__50", 12);
		try
		{
			int _type = T__50;
			int _channel = DefaultTokenChannel;
			// MathLang.g:20:7: ( '(' )
			DebugEnterAlt(1);
			// MathLang.g:20:9: '('
			{
			DebugLocation(20, 9);
			Match('('); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__50", 12);
			LeaveRule("T__50", 12);
			Leave_T__50();
		}
	}
	// $ANTLR end "T__50"

	partial void Enter_T__51();
	partial void Leave_T__51();

	// $ANTLR start "T__51"
	[GrammarRule("T__51")]
	private void mT__51()
	{
		Enter_T__51();
		EnterRule("T__51", 13);
		TraceIn("T__51", 13);
		try
		{
			int _type = T__51;
			int _channel = DefaultTokenChannel;
			// MathLang.g:21:7: ( ')' )
			DebugEnterAlt(1);
			// MathLang.g:21:9: ')'
			{
			DebugLocation(21, 9);
			Match(')'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__51", 13);
			LeaveRule("T__51", 13);
			Leave_T__51();
		}
	}
	// $ANTLR end "T__51"

	partial void Enter_T__52();
	partial void Leave_T__52();

	// $ANTLR start "T__52"
	[GrammarRule("T__52")]
	private void mT__52()
	{
		Enter_T__52();
		EnterRule("T__52", 14);
		TraceIn("T__52", 14);
		try
		{
			int _type = T__52;
			int _channel = DefaultTokenChannel;
			// MathLang.g:22:7: ( ',' )
			DebugEnterAlt(1);
			// MathLang.g:22:9: ','
			{
			DebugLocation(22, 9);
			Match(','); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__52", 14);
			LeaveRule("T__52", 14);
			Leave_T__52();
		}
	}
	// $ANTLR end "T__52"

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
			// MathLang.g:23:7: ( '{' )
			DebugEnterAlt(1);
			// MathLang.g:23:9: '{'
			{
			DebugLocation(23, 9);
			Match('{'); 

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
			// MathLang.g:24:7: ( '}' )
			DebugEnterAlt(1);
			// MathLang.g:24:9: '}'
			{
			DebugLocation(24, 9);
			Match('}'); 

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

	partial void Enter_KNEW();
	partial void Leave_KNEW();

	// $ANTLR start "KNEW"
	[GrammarRule("KNEW")]
	private void mKNEW()
	{
		Enter_KNEW();
		EnterRule("KNEW", 17);
		TraceIn("KNEW", 17);
		try
		{
			int _type = KNEW;
			int _channel = DefaultTokenChannel;
			// MathLang.g:112:5: ( 'new' )
			DebugEnterAlt(1);
			// MathLang.g:112:7: 'new'
			{
			DebugLocation(112, 7);
			Match("new"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("KNEW", 17);
			LeaveRule("KNEW", 17);
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
		EnterRule("SQRBL", 18);
		TraceIn("SQRBL", 18);
		try
		{
			int _type = SQRBL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:113:6: ( '[' )
			DebugEnterAlt(1);
			// MathLang.g:113:7: '['
			{
			DebugLocation(113, 7);
			Match('['); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SQRBL", 18);
			LeaveRule("SQRBL", 18);
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
		EnterRule("SQRBR", 19);
		TraceIn("SQRBR", 19);
		try
		{
			int _type = SQRBR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:114:6: ( ']' )
			DebugEnterAlt(1);
			// MathLang.g:114:7: ']'
			{
			DebugLocation(114, 7);
			Match(']'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SQRBR", 19);
			LeaveRule("SQRBR", 19);
			Leave_SQRBR();
		}
	}
	// $ANTLR end "SQRBR"

	partial void Enter_TYPE0();
	partial void Leave_TYPE0();

	// $ANTLR start "TYPE0"
	[GrammarRule("TYPE0")]
	private void mTYPE0()
	{
		Enter_TYPE0();
		EnterRule("TYPE0", 20);
		TraceIn("TYPE0", 20);
		try
		{
			int _type = TYPE0;
			int _channel = DefaultTokenChannel;
			// MathLang.g:115:6: ( 'int' | 'bool' | 'char' )
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
				// MathLang.g:115:8: 'int'
				{
				DebugLocation(115, 8);
				Match("int"); 


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:115:16: 'bool'
				{
				DebugLocation(115, 16);
				Match("bool"); 


				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:115:25: 'char'
				{
				DebugLocation(115, 25);
				Match("char"); 


				}
				break;

			}
			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TYPE0", 20);
			LeaveRule("TYPE0", 20);
			Leave_TYPE0();
		}
	}
	// $ANTLR end "TYPE0"

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
			// MathLang.g:116:5: ( TYPE0 ( SQRBL SQRBR )+ )
			DebugEnterAlt(1);
			// MathLang.g:116:7: TYPE0 ( SQRBL SQRBR )+
			{
			DebugLocation(116, 7);
			mTYPE0(); 
			DebugLocation(116, 13);
			// MathLang.g:116:13: ( SQRBL SQRBR )+
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
					// MathLang.g:116:14: SQRBL SQRBR
					{
					DebugLocation(116, 14);
					mSQRBL(); 
					DebugLocation(116, 20);
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
			TraceOut("TYPE", 21);
			LeaveRule("TYPE", 21);
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
		EnterRule("ACCESS_MODIFIER", 22);
		TraceIn("ACCESS_MODIFIER", 22);
		try
		{
			int _type = ACCESS_MODIFIER;
			int _channel = DefaultTokenChannel;
			// MathLang.g:117:16: ( 'public' | 'private' )
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
				// MathLang.g:117:18: 'public'
				{
				DebugLocation(117, 18);
				Match("public"); 


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:117:29: 'private'
				{
				DebugLocation(117, 29);
				Match("private"); 


				}
				break;

			}
			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ACCESS_MODIFIER", 22);
			LeaveRule("ACCESS_MODIFIER", 22);
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
		EnterRule("NUMBER", 23);
		TraceIn("NUMBER", 23);
		try
		{
			int _type = NUMBER;
			int _channel = DefaultTokenChannel;
			// MathLang.g:118:7: ( ( '0' .. '9' )+ )
			DebugEnterAlt(1);
			// MathLang.g:118:9: ( '0' .. '9' )+
			{
			DebugLocation(118, 9);
			// MathLang.g:118:9: ( '0' .. '9' )+
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
					// MathLang.g:118:10: '0' .. '9'
					{
					DebugLocation(118, 10);
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
			// MathLang.g:119:4: ( '+' )
			DebugEnterAlt(1);
			// MathLang.g:119:9: '+'
			{
			DebugLocation(119, 9);
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
			// MathLang.g:120:4: ( '-' )
			DebugEnterAlt(1);
			// MathLang.g:120:9: '-'
			{
			DebugLocation(120, 9);
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
			// MathLang.g:121:4: ( '*' )
			DebugEnterAlt(1);
			// MathLang.g:121:9: '*'
			{
			DebugLocation(121, 9);
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
			// MathLang.g:122:4: ( '/' )
			DebugEnterAlt(1);
			// MathLang.g:122:9: '/'
			{
			DebugLocation(122, 9);
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
			// MathLang.g:123:7: ( '=' )
			DebugEnterAlt(1);
			// MathLang.g:123:9: '='
			{
			DebugLocation(123, 9);
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
			// MathLang.g:124:7: ( 'return' )
			DebugEnterAlt(1);
			// MathLang.g:124:9: 'return'
			{
			DebugLocation(124, 9);
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

	partial void Enter_RETURNS();
	partial void Leave_RETURNS();

	// $ANTLR start "RETURNS"
	[GrammarRule("RETURNS")]
	private void mRETURNS()
	{
		Enter_RETURNS();
		EnterRule("RETURNS", 30);
		TraceIn("RETURNS", 30);
		try
		{
			int _type = RETURNS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:125:8: ( 'returns' )
			DebugEnterAlt(1);
			// MathLang.g:125:9: 'returns'
			{
			DebugLocation(125, 9);
			Match("returns"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RETURNS", 30);
			LeaveRule("RETURNS", 30);
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
		EnterRule("TRUE", 31);
		TraceIn("TRUE", 31);
		try
		{
			int _type = TRUE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:126:5: ( 'true' )
			DebugEnterAlt(1);
			// MathLang.g:126:7: 'true'
			{
			DebugLocation(126, 7);
			Match("true"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TRUE", 31);
			LeaveRule("TRUE", 31);
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
		EnterRule("FALSE", 32);
		TraceIn("FALSE", 32);
		try
		{
			int _type = FALSE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:127:6: ( 'false' )
			DebugEnterAlt(1);
			// MathLang.g:127:8: 'false'
			{
			DebugLocation(127, 8);
			Match("false"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FALSE", 32);
			LeaveRule("FALSE", 32);
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
		EnterRule("EQ", 33);
		TraceIn("EQ", 33);
		try
		{
			int _type = EQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:128:3: ( '==' )
			DebugEnterAlt(1);
			// MathLang.g:128:6: '=='
			{
			DebugLocation(128, 6);
			Match("=="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EQ", 33);
			LeaveRule("EQ", 33);
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
		EnterRule("NEQ", 34);
		TraceIn("NEQ", 34);
		try
		{
			int _type = NEQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:129:4: ( '!=' )
			DebugEnterAlt(1);
			// MathLang.g:129:6: '!='
			{
			DebugLocation(129, 6);
			Match("!="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NEQ", 34);
			LeaveRule("NEQ", 34);
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
		EnterRule("GR", 35);
		TraceIn("GR", 35);
		try
		{
			int _type = GR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:130:3: ( '>' )
			DebugEnterAlt(1);
			// MathLang.g:130:6: '>'
			{
			DebugLocation(130, 6);
			Match('>'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GR", 35);
			LeaveRule("GR", 35);
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
		EnterRule("GREQ", 36);
		TraceIn("GREQ", 36);
		try
		{
			int _type = GREQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:131:5: ( '>=' )
			DebugEnterAlt(1);
			// MathLang.g:131:9: '>='
			{
			DebugLocation(131, 9);
			Match(">="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GREQ", 36);
			LeaveRule("GREQ", 36);
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
		EnterRule("LS", 37);
		TraceIn("LS", 37);
		try
		{
			int _type = LS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:132:3: ( '<' )
			DebugEnterAlt(1);
			// MathLang.g:132:6: '<'
			{
			DebugLocation(132, 6);
			Match('<'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LS", 37);
			LeaveRule("LS", 37);
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
		EnterRule("LSEQ", 38);
		TraceIn("LSEQ", 38);
		try
		{
			int _type = LSEQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:133:5: ( '<=' )
			DebugEnterAlt(1);
			// MathLang.g:133:7: '<='
			{
			DebugLocation(133, 7);
			Match("<="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LSEQ", 38);
			LeaveRule("LSEQ", 38);
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
		EnterRule("NOT", 39);
		TraceIn("NOT", 39);
		try
		{
			int _type = NOT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:134:4: ( '!' )
			DebugEnterAlt(1);
			// MathLang.g:134:6: '!'
			{
			DebugLocation(134, 6);
			Match('!'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NOT", 39);
			LeaveRule("NOT", 39);
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
		EnterRule("PARAMETERS", 40);
		TraceIn("PARAMETERS", 40);
		try
		{
			int _type = PARAMETERS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:135:11: ( 'parameters' )
			DebugEnterAlt(1);
			// MathLang.g:135:13: 'parameters'
			{
			DebugLocation(135, 13);
			Match("parameters"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PARAMETERS", 40);
			LeaveRule("PARAMETERS", 40);
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
		EnterRule("OR", 41);
		TraceIn("OR", 41);
		try
		{
			int _type = OR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:136:3: ( '||' )
			DebugEnterAlt(1);
			// MathLang.g:136:6: '||'
			{
			DebugLocation(136, 6);
			Match("||"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OR", 41);
			LeaveRule("OR", 41);
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
		EnterRule("AND", 42);
		TraceIn("AND", 42);
		try
		{
			int _type = AND;
			int _channel = DefaultTokenChannel;
			// MathLang.g:137:4: ( '&&' )
			DebugEnterAlt(1);
			// MathLang.g:137:6: '&&'
			{
			DebugLocation(137, 6);
			Match("&&"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("AND", 42);
			LeaveRule("AND", 42);
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
		EnterRule("WS", 43);
		TraceIn("WS", 43);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:138:3: ( ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+ )
			DebugEnterAlt(1);
			// MathLang.g:139:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			{
			DebugLocation(139, 3);
			// MathLang.g:139:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
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
					DebugLocation(139, 3);
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

			DebugLocation(139, 41);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 43);
			LeaveRule("WS", 43);
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
		EnterRule("CHAR", 44);
		TraceIn("CHAR", 44);
		try
		{
			int _type = CHAR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:143:5: ( '\\'' ( 'a' .. 'z' ) '\\'' )
			DebugEnterAlt(1);
			// MathLang.g:143:8: '\\'' ( 'a' .. 'z' ) '\\''
			{
			DebugLocation(143, 8);
			Match('\''); 
			DebugLocation(143, 12);
			// MathLang.g:143:12: ( 'a' .. 'z' )
			DebugEnterAlt(1);
			// MathLang.g:143:13: 'a' .. 'z'
			{
			DebugLocation(143, 13);
			MatchRange('a','z'); 

			}

			DebugLocation(143, 22);
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
			// MathLang.g:144:3: ( ( 'a' .. 'z' )+ )
			DebugEnterAlt(1);
			// MathLang.g:144:6: ( 'a' .. 'z' )+
			{
			DebugLocation(144, 6);
			// MathLang.g:144:6: ( 'a' .. 'z' )+
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
					// MathLang.g:144:7: 'a' .. 'z'
					{
					DebugLocation(144, 7);
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
			// MathLang.g:148:11: ( '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n' )
			DebugEnterAlt(1);
			// MathLang.g:149:3: '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n'
			{
			DebugLocation(149, 3);
			Match("//"); 

			DebugLocation(149, 8);
			// MathLang.g:149:8: ( options {greedy=false; } : . )*
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
					// MathLang.g:149:36: .
					{
					DebugLocation(149, 36);
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

			DebugLocation(149, 40);
			// MathLang.g:149:40: ( '\\r' )?
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
				// MathLang.g:149:40: '\\r'
				{
				DebugLocation(149, 40);
				Match('\r'); 

				}
				break;

			}
			} finally { DebugExitSubRule(8); }

			DebugLocation(149, 46);
			Match('\n'); 
			DebugLocation(149, 51);

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
			// MathLang.g:153:11: ( '/*' ( options {greedy=false; } : . )* '*/' )
			DebugEnterAlt(1);
			// MathLang.g:154:3: '/*' ( options {greedy=false; } : . )* '*/'
			{
			DebugLocation(154, 3);
			Match("/*"); 

			DebugLocation(154, 8);
			// MathLang.g:154:8: ( options {greedy=false; } : . )*
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
					// MathLang.g:154:36: .
					{
					DebugLocation(154, 36);
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

			DebugLocation(154, 40);
			Match("*/"); 

			DebugLocation(154, 45);

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
		// MathLang.g:1:8: ( PRINT | INPUT | IF | ELSE | FOR | FUNCTION | WHILE | VARDECLARATION | FUNCDECLARATION | VARASSIGNMENT | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | KNEW | SQRBL | SQRBR | TYPE0 | TYPE | ACCESS_MODIFIER | NUMBER | ADD | SUB | MUL | DIV | ASSIGN | RETURN | RETURNS | TRUE | FALSE | EQ | NEQ | GR | GREQ | LS | LSEQ | NOT | PARAMETERS | OR | AND | WS | CHAR | ID | SL_COMMENT | ML_COMMENT )
		int alt10=47;
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
			// MathLang.g:1:94: T__49
			{
			DebugLocation(1, 94);
			mT__49(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// MathLang.g:1:100: T__50
			{
			DebugLocation(1, 100);
			mT__50(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// MathLang.g:1:106: T__51
			{
			DebugLocation(1, 106);
			mT__51(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// MathLang.g:1:112: T__52
			{
			DebugLocation(1, 112);
			mT__52(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// MathLang.g:1:118: T__53
			{
			DebugLocation(1, 118);
			mT__53(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// MathLang.g:1:124: T__54
			{
			DebugLocation(1, 124);
			mT__54(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// MathLang.g:1:130: KNEW
			{
			DebugLocation(1, 130);
			mKNEW(); 

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// MathLang.g:1:135: SQRBL
			{
			DebugLocation(1, 135);
			mSQRBL(); 

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// MathLang.g:1:141: SQRBR
			{
			DebugLocation(1, 141);
			mSQRBR(); 

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// MathLang.g:1:147: TYPE0
			{
			DebugLocation(1, 147);
			mTYPE0(); 

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// MathLang.g:1:153: TYPE
			{
			DebugLocation(1, 153);
			mTYPE(); 

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// MathLang.g:1:158: ACCESS_MODIFIER
			{
			DebugLocation(1, 158);
			mACCESS_MODIFIER(); 

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// MathLang.g:1:174: NUMBER
			{
			DebugLocation(1, 174);
			mNUMBER(); 

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// MathLang.g:1:181: ADD
			{
			DebugLocation(1, 181);
			mADD(); 

			}
			break;
		case 25:
			DebugEnterAlt(25);
			// MathLang.g:1:185: SUB
			{
			DebugLocation(1, 185);
			mSUB(); 

			}
			break;
		case 26:
			DebugEnterAlt(26);
			// MathLang.g:1:189: MUL
			{
			DebugLocation(1, 189);
			mMUL(); 

			}
			break;
		case 27:
			DebugEnterAlt(27);
			// MathLang.g:1:193: DIV
			{
			DebugLocation(1, 193);
			mDIV(); 

			}
			break;
		case 28:
			DebugEnterAlt(28);
			// MathLang.g:1:197: ASSIGN
			{
			DebugLocation(1, 197);
			mASSIGN(); 

			}
			break;
		case 29:
			DebugEnterAlt(29);
			// MathLang.g:1:204: RETURN
			{
			DebugLocation(1, 204);
			mRETURN(); 

			}
			break;
		case 30:
			DebugEnterAlt(30);
			// MathLang.g:1:211: RETURNS
			{
			DebugLocation(1, 211);
			mRETURNS(); 

			}
			break;
		case 31:
			DebugEnterAlt(31);
			// MathLang.g:1:219: TRUE
			{
			DebugLocation(1, 219);
			mTRUE(); 

			}
			break;
		case 32:
			DebugEnterAlt(32);
			// MathLang.g:1:224: FALSE
			{
			DebugLocation(1, 224);
			mFALSE(); 

			}
			break;
		case 33:
			DebugEnterAlt(33);
			// MathLang.g:1:230: EQ
			{
			DebugLocation(1, 230);
			mEQ(); 

			}
			break;
		case 34:
			DebugEnterAlt(34);
			// MathLang.g:1:233: NEQ
			{
			DebugLocation(1, 233);
			mNEQ(); 

			}
			break;
		case 35:
			DebugEnterAlt(35);
			// MathLang.g:1:237: GR
			{
			DebugLocation(1, 237);
			mGR(); 

			}
			break;
		case 36:
			DebugEnterAlt(36);
			// MathLang.g:1:240: GREQ
			{
			DebugLocation(1, 240);
			mGREQ(); 

			}
			break;
		case 37:
			DebugEnterAlt(37);
			// MathLang.g:1:245: LS
			{
			DebugLocation(1, 245);
			mLS(); 

			}
			break;
		case 38:
			DebugEnterAlt(38);
			// MathLang.g:1:248: LSEQ
			{
			DebugLocation(1, 248);
			mLSEQ(); 

			}
			break;
		case 39:
			DebugEnterAlt(39);
			// MathLang.g:1:253: NOT
			{
			DebugLocation(1, 253);
			mNOT(); 

			}
			break;
		case 40:
			DebugEnterAlt(40);
			// MathLang.g:1:257: PARAMETERS
			{
			DebugLocation(1, 257);
			mPARAMETERS(); 

			}
			break;
		case 41:
			DebugEnterAlt(41);
			// MathLang.g:1:268: OR
			{
			DebugLocation(1, 268);
			mOR(); 

			}
			break;
		case 42:
			DebugEnterAlt(42);
			// MathLang.g:1:271: AND
			{
			DebugLocation(1, 271);
			mAND(); 

			}
			break;
		case 43:
			DebugEnterAlt(43);
			// MathLang.g:1:275: WS
			{
			DebugLocation(1, 275);
			mWS(); 

			}
			break;
		case 44:
			DebugEnterAlt(44);
			// MathLang.g:1:278: CHAR
			{
			DebugLocation(1, 278);
			mCHAR(); 

			}
			break;
		case 45:
			DebugEnterAlt(45);
			// MathLang.g:1:283: ID
			{
			DebugLocation(1, 283);
			mID(); 

			}
			break;
		case 46:
			DebugEnterAlt(46);
			// MathLang.g:1:286: SL_COMMENT
			{
			DebugLocation(1, 286);
			mSL_COMMENT(); 

			}
			break;
		case 47:
			DebugEnterAlt(47);
			// MathLang.g:1:297: ML_COMMENT
			{
			DebugLocation(1, 297);
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
			"\x1\xFFFF\x6\x21\x6\xFFFF\x1\x21\x2\xFFFF\x2\x21\x4\xFFFF\x1\x32\x1"+
			"\x34\x2\x21\x1\x38\x1\x3A\x1\x3C\x5\xFFFF\x4\x21\x1\x42\x9\x21\x5\xFFFF"+
			"\x2\x21\x6\xFFFF\x4\x21\x1\x53\x1\xFFFF\x1\x21\x1\x56\x4\x21\x1\x5C\x9"+
			"\x21\x2\xFFFF\x1\x66\x1\xFFFF\x5\x21\x1\xFFFF\x2\x53\x1\x21\x1\x6E\x1"+
			"\x6F\x3\x21\x1\x73\x1\xFFFF\x2\x21\x1\x76\x1\x77\x3\x21\x2\xFFFF\x1\x21"+
			"\x1\x7C\x1\x21\x1\xFFFF\x2\x21\x2\xFFFF\x2\x21\x1\x83\x1\x7C\x1\xFFFF"+
			"\x5\x21\x1\x89\x1\xFFFF\x1\x21\x1\x8B\x3\x21\x1\xFFFF\x1\x21\x1\xFFFF"+
			"\x3\x21\x1\x93\x3\x21\x1\xFFFF\x8\x21\x1\x9F\x1\x21\x1\xA1\x1\xFFFF\x1"+
			"\xA2\x2\xFFFF";
		private const string DFA10_eofS =
			"\xA3\xFFFF";
		private const string DFA10_minS =
			"\x1\x9\x1\x61\x1\x66\x1\x6C\x1\x61\x1\x68\x1\x61\x6\xFFFF\x1\x65\x2"+
			"\xFFFF\x1\x6F\x1\x68\x4\xFFFF\x1\x2A\x1\x3D\x1\x65\x1\x72\x3\x3D\x5\xFFFF"+
			"\x1\x69\x1\x62\x1\x72\x1\x70\x1\x61\x1\x73\x1\x72\x1\x6E\x1\x6C\x1\x69"+
			"\x1\x72\x1\x77\x1\x6F\x1\x61\x5\xFFFF\x1\x74\x1\x75\x6\xFFFF\x1\x6E\x1"+
			"\x6C\x1\x61\x1\x75\x1\x5B\x1\xFFFF\x1\x65\x1\x61\x1\x63\x1\x73\x1\x6C"+
			"\x2\x61\x1\x6C\x1\x72\x1\x75\x1\x65\x1\x74\x1\x61\x1\x69\x1\x6D\x1\x74"+
			"\x2\xFFFF\x1\x61\x1\xFFFF\x1\x64\x3\x65\x1\x73\x1\xFFFF\x2\x5B\x1\x72"+
			"\x2\x61\x1\x74\x1\x63\x1\x65\x1\x61\x1\xFFFF\x1\x69\x1\x65\x2\x61\x1"+
			"\x63\x1\x73\x1\x6E\x2\xFFFF\x1\x65\x1\x61\x1\x74\x1\xFFFF\x1\x6F\x1\x63"+
			"\x2\xFFFF\x1\x6C\x1\x69\x2\x61\x1\xFFFF\x1\x65\x1\x6E\x1\x6C\x1\x61\x1"+
			"\x67\x1\x61\x1\xFFFF\x1\x72\x2\x61\x1\x72\x1\x6E\x1\xFFFF\x1\x73\x1\xFFFF"+
			"\x1\x72\x1\x61\x1\x6D\x2\x61\x1\x74\x1\x65\x1\xFFFF\x1\x74\x1\x69\x1"+
			"\x6E\x1\x69\x1\x6F\x1\x74\x1\x6F\x1\x6E\x1\x61\x1\x6E\x1\x61\x1\xFFFF"+
			"\x1\x61\x2\xFFFF";
		private const string DFA10_maxS =
			"\x1\x7D\x1\x75\x1\x6E\x1\x6C\x1\x75\x1\x68\x1\x61\x6\xFFFF\x1\x65\x2"+
			"\xFFFF\x1\x6F\x1\x68\x4\xFFFF\x1\x2F\x1\x3D\x1\x65\x1\x72\x3\x3D\x5\xFFFF"+
			"\x1\x69\x1\x62\x1\x72\x1\x74\x1\x7A\x1\x73\x1\x72\x1\x6E\x1\x6C\x1\x69"+
			"\x1\x72\x1\x77\x1\x6F\x1\x61\x5\xFFFF\x1\x74\x1\x75\x6\xFFFF\x1\x76\x1"+
			"\x6C\x1\x61\x1\x75\x1\x7A\x1\xFFFF\x1\x65\x1\x7A\x1\x63\x1\x73\x1\x6C"+
			"\x1\x64\x1\x7A\x1\x6C\x1\x72\x1\x75\x1\x65\x1\x74\x1\x61\x1\x69\x1\x6D"+
			"\x1\x74\x2\xFFFF\x1\x7A\x1\xFFFF\x1\x74\x3\x65\x1\x73\x1\xFFFF\x2\x7A"+
			"\x1\x72\x2\x7A\x1\x74\x1\x63\x1\x65\x1\x7A\x1\xFFFF\x1\x69\x1\x65\x2"+
			"\x7A\x1\x63\x1\x73\x1\x6E\x2\xFFFF\x1\x65\x1\x7A\x1\x74\x1\xFFFF\x1\x6F"+
			"\x1\x63\x2\xFFFF\x1\x6C\x1\x69\x2\x7A\x1\xFFFF\x1\x65\x1\x6E\x1\x6C\x1"+
			"\x61\x1\x67\x1\x7A\x1\xFFFF\x1\x72\x1\x7A\x1\x61\x1\x72\x1\x6E\x1\xFFFF"+
			"\x1\x73\x1\xFFFF\x1\x72\x1\x61\x1\x6D\x1\x7A\x1\x61\x1\x74\x1\x65\x1"+
			"\xFFFF\x1\x74\x1\x69\x1\x6E\x1\x69\x1\x6F\x1\x74\x1\x6F\x1\x6E\x1\x7A"+
			"\x1\x6E\x1\x7A\x1\xFFFF\x1\x7A\x2\xFFFF";
		private const string DFA10_acceptS =
			"\x7\xFFFF\x1\xB\x1\xC\x1\xD\x1\xE\x1\xF\x1\x10\x1\xFFFF\x1\x12\x1\x13"+
			"\x2\xFFFF\x1\x17\x1\x18\x1\x19\x1\x1A\x7\xFFFF\x1\x29\x1\x2A\x1\x2B\x1"+
			"\x2C\x1\x2D\xE\xFFFF\x1\x2E\x1\x2F\x1\x1B\x1\x21\x1\x1C\x2\xFFFF\x1\x22"+
			"\x1\x27\x1\x24\x1\x23\x1\x26\x1\x25\x5\xFFFF\x1\x3\x10\xFFFF\x1\x14\x1"+
			"\x15\x1\xFFFF\x1\x5\x5\xFFFF\x1\x11\x9\xFFFF\x1\x4\x7\xFFFF\x1\x1F\x1"+
			"\x1\x3\xFFFF\x1\x2\x2\xFFFF\x1\x20\x1\x7\x4\xFFFF\x1\x16\x6\xFFFF\x1"+
			"\x1D\x5\xFFFF\x1\x1E\x1\xFFFF\x1\x6\x7\xFFFF\x1\x28\xB\xFFFF\x1\xA\x1"+
			"\xFFFF\x1\x8\x1\x9";
		private const string DFA10_specialS =
			"\xA3\xFFFF}>";
		private static readonly string[] DFA10_transitionS =
			{
				"\x2\x1F\x1\xFFFF\x2\x1F\x12\xFFFF\x1\x1F\x1\x1A\x4\xFFFF\x1\x1E\x1"+
				"\x20\x1\x8\x1\x9\x1\x15\x1\x13\x1\xA\x1\x14\x1\xFFFF\x1\x16\xA\x12\x1"+
				"\xFFFF\x1\x7\x1\x1C\x1\x17\x1\x1B\x1C\xFFFF\x1\xE\x1\xFFFF\x1\xF\x3"+
				"\xFFFF\x1\x21\x1\x10\x1\x11\x1\x21\x1\x3\x1\x4\x2\x21\x1\x2\x4\x21\x1"+
				"\xD\x1\x21\x1\x1\x1\x21\x1\x18\x1\x21\x1\x19\x1\x21\x1\x6\x1\x5\x3\x21"+
				"\x1\xB\x1\x1D\x1\xC",
				"\x1\x24\x10\xFFFF\x1\x22\x2\xFFFF\x1\x23",
				"\x1\x26\x7\xFFFF\x1\x25",
				"\x1\x27",
				"\x1\x2A\xD\xFFFF\x1\x28\x5\xFFFF\x1\x29",
				"\x1\x2B",
				"\x1\x2C",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x2D",
				"",
				"",
				"\x1\x2E",
				"\x1\x2F",
				"",
				"",
				"",
				"",
				"\x1\x31\x4\xFFFF\x1\x30",
				"\x1\x33",
				"\x1\x35",
				"\x1\x36",
				"\x1\x37",
				"\x1\x39",
				"\x1\x3B",
				"",
				"",
				"",
				"",
				"",
				"\x1\x3D",
				"\x1\x3E",
				"\x1\x3F",
				"\x1\x40\x3\xFFFF\x1\x41",
				"\x1A\x21",
				"\x1\x43",
				"\x1\x44",
				"\x1\x45",
				"\x1\x46",
				"\x1\x47",
				"\x1\x48",
				"\x1\x49",
				"\x1\x4A",
				"\x1\x4B",
				"",
				"",
				"",
				"",
				"",
				"\x1\x4C",
				"\x1\x4D",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x4E\x7\xFFFF\x1\x4F",
				"\x1\x50",
				"\x1\x51",
				"\x1\x52",
				"\x1\x54\x5\xFFFF\x1A\x21",
				"",
				"\x1\x55",
				"\x1A\x21",
				"\x1\x57",
				"\x1\x58",
				"\x1\x59",
				"\x1\x5B\x2\xFFFF\x1\x5A",
				"\x1A\x21",
				"\x1\x5D",
				"\x1\x5E",
				"\x1\x5F",
				"\x1\x60",
				"\x1\x61",
				"\x1\x62",
				"\x1\x63",
				"\x1\x64",
				"\x1\x65",
				"",
				"",
				"\x1A\x21",
				"",
				"\x1\x68\xF\xFFFF\x1\x67",
				"\x1\x69",
				"\x1\x6A",
				"\x1\x6B",
				"\x1\x6C",
				"",
				"\x1\x54\x5\xFFFF\x1A\x21",
				"\x1\x54\x5\xFFFF\x1A\x21",
				"\x1\x6D",
				"\x1A\x21",
				"\x1A\x21",
				"\x1\x70",
				"\x1\x71",
				"\x1\x72",
				"\x1A\x21",
				"",
				"\x1\x74",
				"\x1\x75",
				"\x1A\x21",
				"\x1A\x21",
				"\x1\x78",
				"\x1\x79",
				"\x1\x7A",
				"",
				"",
				"\x1\x7B",
				"\x1A\x21",
				"\x1\x7D",
				"",
				"\x1\x7E",
				"\x1\x7F",
				"",
				"",
				"\x1\x80",
				"\x1\x81",
				"\x12\x21\x1\x82\x7\x21",
				"\x1A\x21",
				"",
				"\x1\x84",
				"\x1\x85",
				"\x1\x86",
				"\x1\x87",
				"\x1\x88",
				"\x1A\x21",
				"",
				"\x1\x8A",
				"\x1A\x21",
				"\x1\x8C",
				"\x1\x8D",
				"\x1\x8E",
				"",
				"\x1\x8F",
				"",
				"\x1\x90",
				"\x1\x91",
				"\x1\x92",
				"\x1A\x21",
				"\x1\x94",
				"\x1\x95",
				"\x1\x96",
				"",
				"\x1\x97",
				"\x1\x98",
				"\x1\x99",
				"\x1\x9A",
				"\x1\x9B",
				"\x1\x9C",
				"\x1\x9D",
				"\x1\x9E",
				"\x1A\x21",
				"\x1\xA0",
				"\x1A\x21",
				"",
				"\x1A\x21",
				"",
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

		public override string Description { get { return "1:1: Tokens : ( PRINT | INPUT | IF | ELSE | FOR | FUNCTION | WHILE | VARDECLARATION | FUNCDECLARATION | VARASSIGNMENT | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | KNEW | SQRBL | SQRBR | TYPE0 | TYPE | ACCESS_MODIFIER | NUMBER | ADD | SUB | MUL | DIV | ASSIGN | RETURN | RETURNS | TRUE | FALSE | EQ | NEQ | GR | GREQ | LS | LSEQ | NOT | PARAMETERS | OR | AND | WS | CHAR | ID | SL_COMMENT | ML_COMMENT );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}

} // namespace  MathLang 

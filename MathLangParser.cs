// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-10-04 17:57:41

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;
using Map = System.Collections.IDictionary;
using HashMap = System.Collections.Generic.Dictionary<object, object>;

using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;

namespace  MathLang 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:50:56")]
[System.CLSCompliant(false)]
public partial class MathLangParser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "UNKNOWN", "PRINT", "INPUT", "IF", "ELSE", "FOR", "FUNCTION", "RETURN", "WHILE", "BLOCK", "PROGRAM", "PARAMS", "VARDECLARATION", "FUNCDECLARATION", "VARASSIGNMENT", "ARRAYELEMENTASSIGNMENT", "ARRAYELEMENT", "NEWWORD", "NEWVAR", "NUMBER", "ID", "CHAR", "TYPE", "TYPE0", "ASSIGN", "ADD", "SUB", "MUL", "DIV", "GREQ", "LSEQ", "NEQ", "EQ", "GR", "LS", "OR", "AND", "NOT", "TRUE", "FALSE", "KNEW", "SQRBL", "SQRBR", "ACCESS_MODIFIER", "RETURNS", "PARAMETERS", "WS", "SL_COMMENT", "ML_COMMENT", "';'", "'('", "')'", "','", "'()'", "'{'", "'}'"
	};
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

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, true, false, false, false, false, true, false, false, 
				false, false, false, false, false, true, false, false, false, true, 
				false, false, false, false, false, false, false, false, , false
			};
	#else
		private static readonly bool[] decisionCanBacktrack = new bool[0];
	#endif
	public MathLangParser( ITokenStream input )
		: this( input, new RecognizerSharedState() )
	{
	}
	public MathLangParser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{
		this.state.ruleMemo = new System.Collections.Generic.Dictionary<int, int>[83+1];

		ITreeAdaptor treeAdaptor = null;
		CreateTreeAdaptor(ref treeAdaptor);
		TreeAdaptor = treeAdaptor ?? new CommonTreeAdaptor();

		OnCreated();
	}
		
	// Implement this function in your helper file to use a custom tree adaptor
	partial void CreateTreeAdaptor(ref ITreeAdaptor adaptor);

	private ITreeAdaptor adaptor;

	public ITreeAdaptor TreeAdaptor
	{
		get
		{
			return adaptor;
		}
		set
		{
			this.adaptor = value;
		}
	}

	public override string[] TokenNames { get { return MathLangParser.tokenNames; } }
	public override string GrammarFileName { get { return "MathLang.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules
	public class execute_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_execute();
	partial void Leave_execute();

	// $ANTLR start "execute"
	// MathLang.g:42:8: public execute : statementlist EOF ;
	[GrammarRule("execute")]
	public MathLangParser.execute_return execute()
	{
		Enter_execute();
		EnterRule("execute", 1);
		TraceIn("execute", 1);
		MathLangParser.execute_return retval = new MathLangParser.execute_return();
		retval.Start = (IToken)input.LT(1);
		int execute_StartIndex = input.Index;
		object root_0 = null;

		IToken EOF2=null;
		MathLangParser.statementlist_return statementlist1 = default(MathLangParser.statementlist_return);

		object EOF2_tree=null;

		try { DebugEnterRule(GrammarFileName, "execute");
		DebugLocation(42, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 1)) { return retval; }
			// MathLang.g:42:15: ( statementlist EOF )
			DebugEnterAlt(1);
			// MathLang.g:43:2: statementlist EOF
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(43, 2);
			PushFollow(Follow._statementlist_in_execute326);
			statementlist1=statementlist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementlist1.Tree);
			DebugLocation(43, 19);
			EOF2=(IToken)Match(input,EOF,Follow._EOF_in_execute328); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("execute", 1);
			LeaveRule("execute", 1);
			Leave_execute();
			if (state.backtracking > 0) { Memoize(input, 1, execute_StartIndex); }
		}
		DebugLocation(44, 0);
		} finally { DebugExitRule(GrammarFileName, "execute"); }
		return retval;

	}
	// $ANTLR end "execute"

	public class statement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_statement();
	partial void Leave_statement();

	// $ANTLR start "statement"
	// MathLang.g:46:1: statement : ( declaration | assignment | ifstatement | whilestatement | forstatement | funcdeclaration | returnstatement | funccall ) ;
	[GrammarRule("statement")]
	private MathLangParser.statement_return statement()
	{
		Enter_statement();
		EnterRule("statement", 2);
		TraceIn("statement", 2);
		MathLangParser.statement_return retval = new MathLangParser.statement_return();
		retval.Start = (IToken)input.LT(1);
		int statement_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.declaration_return declaration3 = default(MathLangParser.declaration_return);
		MathLangParser.assignment_return assignment4 = default(MathLangParser.assignment_return);
		MathLangParser.ifstatement_return ifstatement5 = default(MathLangParser.ifstatement_return);
		MathLangParser.whilestatement_return whilestatement6 = default(MathLangParser.whilestatement_return);
		MathLangParser.forstatement_return forstatement7 = default(MathLangParser.forstatement_return);
		MathLangParser.funcdeclaration_return funcdeclaration8 = default(MathLangParser.funcdeclaration_return);
		MathLangParser.returnstatement_return returnstatement9 = default(MathLangParser.returnstatement_return);
		MathLangParser.funccall_return funccall10 = default(MathLangParser.funccall_return);


		try { DebugEnterRule(GrammarFileName, "statement");
		DebugLocation(46, 13);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 2)) { return retval; }
			// MathLang.g:46:10: ( ( declaration | assignment | ifstatement | whilestatement | forstatement | funcdeclaration | returnstatement | funccall ) )
			DebugEnterAlt(1);
			// MathLang.g:46:12: ( declaration | assignment | ifstatement | whilestatement | forstatement | funcdeclaration | returnstatement | funccall )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(46, 12);
			// MathLang.g:46:12: ( declaration | assignment | ifstatement | whilestatement | forstatement | funcdeclaration | returnstatement | funccall )
			int alt1=8;
			try { DebugEnterSubRule(1);
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
				// MathLang.g:46:14: declaration
				{
				DebugLocation(46, 14);
				PushFollow(Follow._declaration_in_statement339);
				declaration3=declaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, declaration3.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:47:4: assignment
				{
				DebugLocation(47, 4);
				PushFollow(Follow._assignment_in_statement345);
				assignment4=assignment();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment4.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:48:4: ifstatement
				{
				DebugLocation(48, 4);
				PushFollow(Follow._ifstatement_in_statement350);
				ifstatement5=ifstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ifstatement5.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:49:4: whilestatement
				{
				DebugLocation(49, 4);
				PushFollow(Follow._whilestatement_in_statement355);
				whilestatement6=whilestatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, whilestatement6.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:50:4: forstatement
				{
				DebugLocation(50, 4);
				PushFollow(Follow._forstatement_in_statement360);
				forstatement7=forstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forstatement7.Tree);

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// MathLang.g:51:4: funcdeclaration
				{
				DebugLocation(51, 4);
				PushFollow(Follow._funcdeclaration_in_statement365);
				funcdeclaration8=funcdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funcdeclaration8.Tree);

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// MathLang.g:52:4: returnstatement
				{
				DebugLocation(52, 4);
				PushFollow(Follow._returnstatement_in_statement370);
				returnstatement9=returnstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, returnstatement9.Tree);

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// MathLang.g:53:4: funccall
				{
				DebugLocation(53, 4);
				PushFollow(Follow._funccall_in_statement375);
				funccall10=funccall();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccall10.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(1); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("statement", 2);
			LeaveRule("statement", 2);
			Leave_statement();
			if (state.backtracking > 0) { Memoize(input, 2, statement_StartIndex); }
		}
		DebugLocation(53, 13);
		} finally { DebugExitRule(GrammarFileName, "statement"); }
		return retval;

	}
	// $ANTLR end "statement"

	public class number_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_number();
	partial void Leave_number();

	// $ANTLR start "number"
	// MathLang.g:55:1: number : ( NUMBER | ID | funccallbody | CHAR | arrayelement );
	[GrammarRule("number")]
	private MathLangParser.number_return number()
	{
		Enter_number();
		EnterRule("number", 3);
		TraceIn("number", 3);
		MathLangParser.number_return retval = new MathLangParser.number_return();
		retval.Start = (IToken)input.LT(1);
		int number_StartIndex = input.Index;
		object root_0 = null;

		IToken NUMBER11=null;
		IToken ID12=null;
		IToken CHAR14=null;
		MathLangParser.funccallbody_return funccallbody13 = default(MathLangParser.funccallbody_return);
		MathLangParser.arrayelement_return arrayelement15 = default(MathLangParser.arrayelement_return);

		object NUMBER11_tree=null;
		object ID12_tree=null;
		object CHAR14_tree=null;

		try { DebugEnterRule(GrammarFileName, "number");
		DebugLocation(55, 16);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 3)) { return retval; }
			// MathLang.g:55:8: ( NUMBER | ID | funccallbody | CHAR | arrayelement )
			int alt2=5;
			try { DebugEnterDecision(2, decisionCanBacktrack[2]);
			switch (input.LA(1))
			{
			case NUMBER:
				{
				alt2=1;
				}
				break;
			case ID:
				{
				switch (input.LA(2))
				{
				case 54:
					{
					alt2=3;
					}
					break;
				case SQRBL:
					{
					alt2=5;
					}
					break;
				case EOF:
				case ADD:
				case SUB:
				case MUL:
				case DIV:
				case GREQ:
				case LSEQ:
				case NEQ:
				case EQ:
				case GR:
				case LS:
				case OR:
				case AND:
				case SQRBR:
				case 53:
				case 55:
				case 56:
					{
					alt2=2;
					}
					break;
				default:
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 2, 2, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}

				}
				break;
			case CHAR:
				{
				alt2=4;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
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
				// MathLang.g:55:11: NUMBER
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(55, 11);
				NUMBER11=(IToken)Match(input,NUMBER,Follow._NUMBER_in_number386); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				NUMBER11_tree = (object)adaptor.Create(NUMBER11);
				adaptor.AddChild(root_0, NUMBER11_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:56:5: ID
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(56, 5);
				ID12=(IToken)Match(input,ID,Follow._ID_in_number392); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				ID12_tree = (object)adaptor.Create(ID12);
				adaptor.AddChild(root_0, ID12_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:57:5: funccallbody
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(57, 5);
				PushFollow(Follow._funccallbody_in_number398);
				funccallbody13=funccallbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody13.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:58:5: CHAR
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(58, 5);
				CHAR14=(IToken)Match(input,CHAR,Follow._CHAR_in_number404); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				CHAR14_tree = (object)adaptor.Create(CHAR14);
				adaptor.AddChild(root_0, CHAR14_tree);
				}

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:59:5: arrayelement
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(59, 5);
				PushFollow(Follow._arrayelement_in_number410);
				arrayelement15=arrayelement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayelement15.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("number", 3);
			LeaveRule("number", 3);
			Leave_number();
			if (state.backtracking > 0) { Memoize(input, 3, number_StartIndex); }
		}
		DebugLocation(59, 16);
		} finally { DebugExitRule(GrammarFileName, "number"); }
		return retval;

	}
	// $ANTLR end "number"

	public class mathexpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_mathexpression();
	partial void Leave_mathexpression();

	// $ANTLR start "mathexpression"
	// MathLang.g:60:1: mathexpression : term ;
	[GrammarRule("mathexpression")]
	private MathLangParser.mathexpression_return mathexpression()
	{
		Enter_mathexpression();
		EnterRule("mathexpression", 4);
		TraceIn("mathexpression", 4);
		MathLangParser.mathexpression_return retval = new MathLangParser.mathexpression_return();
		retval.Start = (IToken)input.LT(1);
		int mathexpression_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.term_return term16 = default(MathLangParser.term_return);


		try { DebugEnterRule(GrammarFileName, "mathexpression");
		DebugLocation(60, 21);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 4)) { return retval; }
			// MathLang.g:60:15: ( term )
			DebugEnterAlt(1);
			// MathLang.g:60:17: term
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(60, 17);
			PushFollow(Follow._term_in_mathexpression416);
			term16=term();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term16.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("mathexpression", 4);
			LeaveRule("mathexpression", 4);
			Leave_mathexpression();
			if (state.backtracking > 0) { Memoize(input, 4, mathexpression_StartIndex); }
		}
		DebugLocation(60, 21);
		} finally { DebugExitRule(GrammarFileName, "mathexpression"); }
		return retval;

	}
	// $ANTLR end "mathexpression"

	public class expression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expression();
	partial void Leave_expression();

	// $ANTLR start "expression"
	// MathLang.g:62:1: expression : ( newexpression | funccallbody | boolexpression | mathexpression );
	[GrammarRule("expression")]
	private MathLangParser.expression_return expression()
	{
		Enter_expression();
		EnterRule("expression", 5);
		TraceIn("expression", 5);
		MathLangParser.expression_return retval = new MathLangParser.expression_return();
		retval.Start = (IToken)input.LT(1);
		int expression_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.newexpression_return newexpression17 = default(MathLangParser.newexpression_return);
		MathLangParser.funccallbody_return funccallbody18 = default(MathLangParser.funccallbody_return);
		MathLangParser.boolexpression_return boolexpression19 = default(MathLangParser.boolexpression_return);
		MathLangParser.mathexpression_return mathexpression20 = default(MathLangParser.mathexpression_return);


		try { DebugEnterRule(GrammarFileName, "expression");
		DebugLocation(62, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 5)) { return retval; }
			// MathLang.g:62:11: ( newexpression | funccallbody | boolexpression | mathexpression )
			int alt3=4;
			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
			try
			{
				alt3 = dfa3.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(3); }
			switch (alt3)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:63:5: newexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(63, 5);
				PushFollow(Follow._newexpression_in_expression430);
				newexpression17=newexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, newexpression17.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:64:5: funccallbody
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(64, 5);
				PushFollow(Follow._funccallbody_in_expression436);
				funccallbody18=funccallbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody18.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:65:5: boolexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(65, 5);
				PushFollow(Follow._boolexpression_in_expression442);
				boolexpression19=boolexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression19.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:66:5: mathexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(66, 5);
				PushFollow(Follow._mathexpression_in_expression448);
				mathexpression20=mathexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mathexpression20.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expression", 5);
			LeaveRule("expression", 5);
			Leave_expression();
			if (state.backtracking > 0) { Memoize(input, 5, expression_StartIndex); }
		}
		DebugLocation(68, 0);
		} finally { DebugExitRule(GrammarFileName, "expression"); }
		return retval;

	}
	// $ANTLR end "expression"

	public class arrayelement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_arrayelement();
	partial void Leave_arrayelement();

	// $ANTLR start "arrayelement"
	// MathLang.g:70:1: arrayelement : ID '[' number ']' -> ^( ARRAYELEMENT ID number ) ;
	[GrammarRule("arrayelement")]
	private MathLangParser.arrayelement_return arrayelement()
	{
		Enter_arrayelement();
		EnterRule("arrayelement", 6);
		TraceIn("arrayelement", 6);
		MathLangParser.arrayelement_return retval = new MathLangParser.arrayelement_return();
		retval.Start = (IToken)input.LT(1);
		int arrayelement_StartIndex = input.Index;
		object root_0 = null;

		IToken ID21=null;
		IToken char_literal22=null;
		IToken char_literal24=null;
		MathLangParser.number_return number23 = default(MathLangParser.number_return);

		object ID21_tree=null;
		object char_literal22_tree=null;
		object char_literal24_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_SQRBR=new RewriteRuleITokenStream(adaptor,"token SQRBR");
		RewriteRuleITokenStream stream_SQRBL=new RewriteRuleITokenStream(adaptor,"token SQRBL");
		RewriteRuleSubtreeStream stream_number=new RewriteRuleSubtreeStream(adaptor,"rule number");
		try { DebugEnterRule(GrammarFileName, "arrayelement");
		DebugLocation(70, 62);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 6)) { return retval; }
			// MathLang.g:70:13: ( ID '[' number ']' -> ^( ARRAYELEMENT ID number ) )
			DebugEnterAlt(1);
			// MathLang.g:70:16: ID '[' number ']'
			{
			DebugLocation(70, 16);
			ID21=(IToken)Match(input,ID,Follow._ID_in_arrayelement460); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID21);

			DebugLocation(70, 19);
			char_literal22=(IToken)Match(input,SQRBL,Follow._SQRBL_in_arrayelement462); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_SQRBL.Add(char_literal22);

			DebugLocation(70, 23);
			PushFollow(Follow._number_in_arrayelement464);
			number23=number();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_number.Add(number23.Tree);
			DebugLocation(70, 30);
			char_literal24=(IToken)Match(input,SQRBR,Follow._SQRBR_in_arrayelement466); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_SQRBR.Add(char_literal24);



			{
			// AST REWRITE
			// elements: ID, number
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 70:34: -> ^( ARRAYELEMENT ID number )
			{
				DebugLocation(70, 37);
				// MathLang.g:70:37: ^( ARRAYELEMENT ID number )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(70, 39);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYELEMENT, "ARRAYELEMENT"), root_1);

				DebugLocation(70, 52);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(70, 55);
				adaptor.AddChild(root_1, stream_number.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("arrayelement", 6);
			LeaveRule("arrayelement", 6);
			Leave_arrayelement();
			if (state.backtracking > 0) { Memoize(input, 6, arrayelement_StartIndex); }
		}
		DebugLocation(70, 62);
		} finally { DebugExitRule(GrammarFileName, "arrayelement"); }
		return retval;

	}
	// $ANTLR end "arrayelement"

	public class declaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_declaration();
	partial void Leave_declaration();

	// $ANTLR start "declaration"
	// MathLang.g:72:1: declaration : ( declarationbody ';' | longdeclaration );
	[GrammarRule("declaration")]
	private MathLangParser.declaration_return declaration()
	{
		Enter_declaration();
		EnterRule("declaration", 7);
		TraceIn("declaration", 7);
		MathLangParser.declaration_return retval = new MathLangParser.declaration_return();
		retval.Start = (IToken)input.LT(1);
		int declaration_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal26=null;
		MathLangParser.declarationbody_return declarationbody25 = default(MathLangParser.declarationbody_return);
		MathLangParser.longdeclaration_return longdeclaration27 = default(MathLangParser.longdeclaration_return);

		object char_literal26_tree=null;

		try { DebugEnterRule(GrammarFileName, "declaration");
		DebugLocation(72, 20);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 7)) { return retval; }
			// MathLang.g:72:12: ( declarationbody ';' | longdeclaration )
			int alt4=2;
			try { DebugEnterDecision(4, decisionCanBacktrack[4]);
			int LA4_0 = input.LA(1);

			if ((LA4_0==TYPE))
			{
				int LA4_1 = input.LA(2);

				if ((LA4_1==ID))
				{
					int LA4_3 = input.LA(3);

					if ((LA4_3==ASSIGN))
					{
						alt4=2;
					}
					else if ((LA4_3==53))
					{
						alt4=1;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 4, 3, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 4, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else if ((LA4_0==TYPE0))
			{
				alt4=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 4, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(4); }
			switch (alt4)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:72:14: declarationbody ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(72, 14);
				PushFollow(Follow._declarationbody_in_declaration484);
				declarationbody25=declarationbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, declarationbody25.Tree);
				DebugLocation(72, 33);
				char_literal26=(IToken)Match(input,53,Follow._53_in_declaration486); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:73:6: longdeclaration
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(73, 6);
				PushFollow(Follow._longdeclaration_in_declaration494);
				longdeclaration27=longdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclaration27.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("declaration", 7);
			LeaveRule("declaration", 7);
			Leave_declaration();
			if (state.backtracking > 0) { Memoize(input, 7, declaration_StartIndex); }
		}
		DebugLocation(73, 20);
		} finally { DebugExitRule(GrammarFileName, "declaration"); }
		return retval;

	}
	// $ANTLR end "declaration"

	public class declarationbody_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_declarationbody();
	partial void Leave_declarationbody();

	// $ANTLR start "declarationbody"
	// MathLang.g:75:1: declarationbody : TYPE ID -> ^( VARDECLARATION TYPE ID ) ;
	[GrammarRule("declarationbody")]
	private MathLangParser.declarationbody_return declarationbody()
	{
		Enter_declarationbody();
		EnterRule("declarationbody", 8);
		TraceIn("declarationbody", 8);
		MathLangParser.declarationbody_return retval = new MathLangParser.declarationbody_return();
		retval.Start = (IToken)input.LT(1);
		int declarationbody_StartIndex = input.Index;
		object root_0 = null;

		IToken TYPE28=null;
		IToken ID29=null;

		object TYPE28_tree=null;
		object ID29_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");

		try { DebugEnterRule(GrammarFileName, "declarationbody");
		DebugLocation(75, 54);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 8)) { return retval; }
			// MathLang.g:75:16: ( TYPE ID -> ^( VARDECLARATION TYPE ID ) )
			DebugEnterAlt(1);
			// MathLang.g:75:18: TYPE ID
			{
			DebugLocation(75, 18);
			TYPE28=(IToken)Match(input,TYPE,Follow._TYPE_in_declarationbody501); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE28);

			DebugLocation(75, 23);
			ID29=(IToken)Match(input,ID,Follow._ID_in_declarationbody503); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID29);



			{
			// AST REWRITE
			// elements: ID, TYPE
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 75:26: -> ^( VARDECLARATION TYPE ID )
			{
				DebugLocation(75, 29);
				// MathLang.g:75:29: ^( VARDECLARATION TYPE ID )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(75, 31);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDECLARATION, "VARDECLARATION"), root_1);

				DebugLocation(75, 46);
				adaptor.AddChild(root_1, stream_TYPE.NextNode());
				DebugLocation(75, 51);
				adaptor.AddChild(root_1, stream_ID.NextNode());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("declarationbody", 8);
			LeaveRule("declarationbody", 8);
			Leave_declarationbody();
			if (state.backtracking > 0) { Memoize(input, 8, declarationbody_StartIndex); }
		}
		DebugLocation(75, 54);
		} finally { DebugExitRule(GrammarFileName, "declarationbody"); }
		return retval;

	}
	// $ANTLR end "declarationbody"

	public class longdeclaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_longdeclaration();
	partial void Leave_longdeclaration();

	// $ANTLR start "longdeclaration"
	// MathLang.g:76:1: longdeclaration : longdeclarationbody ';' ;
	[GrammarRule("longdeclaration")]
	private MathLangParser.longdeclaration_return longdeclaration()
	{
		Enter_longdeclaration();
		EnterRule("longdeclaration", 9);
		TraceIn("longdeclaration", 9);
		MathLangParser.longdeclaration_return retval = new MathLangParser.longdeclaration_return();
		retval.Start = (IToken)input.LT(1);
		int longdeclaration_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal31=null;
		MathLangParser.longdeclarationbody_return longdeclarationbody30 = default(MathLangParser.longdeclarationbody_return);

		object char_literal31_tree=null;

		try { DebugEnterRule(GrammarFileName, "longdeclaration");
		DebugLocation(76, 42);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 9)) { return retval; }
			// MathLang.g:76:16: ( longdeclarationbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:76:18: longdeclarationbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(76, 18);
			PushFollow(Follow._longdeclarationbody_in_longdeclaration520);
			longdeclarationbody30=longdeclarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclarationbody30.Tree);
			DebugLocation(76, 41);
			char_literal31=(IToken)Match(input,53,Follow._53_in_longdeclaration522); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("longdeclaration", 9);
			LeaveRule("longdeclaration", 9);
			Leave_longdeclaration();
			if (state.backtracking > 0) { Memoize(input, 9, longdeclaration_StartIndex); }
		}
		DebugLocation(76, 42);
		} finally { DebugExitRule(GrammarFileName, "longdeclaration"); }
		return retval;

	}
	// $ANTLR end "longdeclaration"

	public class longdeclarationbody_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_longdeclarationbody();
	partial void Leave_longdeclarationbody();

	// $ANTLR start "longdeclarationbody"
	// MathLang.g:77:1: longdeclarationbody : ( ( TYPE0 ID ASSIGN expression -> ^( VARDECLARATION TYPE0 ID expression ) ) | ( TYPE ID ASSIGN expression -> ^( VARDECLARATION TYPE ID expression ) ) );
	[GrammarRule("longdeclarationbody")]
	private MathLangParser.longdeclarationbody_return longdeclarationbody()
	{
		Enter_longdeclarationbody();
		EnterRule("longdeclarationbody", 10);
		TraceIn("longdeclarationbody", 10);
		MathLangParser.longdeclarationbody_return retval = new MathLangParser.longdeclarationbody_return();
		retval.Start = (IToken)input.LT(1);
		int longdeclarationbody_StartIndex = input.Index;
		object root_0 = null;

		IToken TYPE032=null;
		IToken ID33=null;
		IToken ASSIGN34=null;
		IToken TYPE36=null;
		IToken ID37=null;
		IToken ASSIGN38=null;
		MathLangParser.expression_return expression35 = default(MathLangParser.expression_return);
		MathLangParser.expression_return expression39 = default(MathLangParser.expression_return);

		object TYPE032_tree=null;
		object ID33_tree=null;
		object ASSIGN34_tree=null;
		object TYPE36_tree=null;
		object ID37_tree=null;
		object ASSIGN38_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_TYPE0=new RewriteRuleITokenStream(adaptor,"token TYPE0");
		RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "longdeclarationbody");
		DebugLocation(77, 72);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 10)) { return retval; }
			// MathLang.g:77:20: ( ( TYPE0 ID ASSIGN expression -> ^( VARDECLARATION TYPE0 ID expression ) ) | ( TYPE ID ASSIGN expression -> ^( VARDECLARATION TYPE ID expression ) ) )
			int alt5=2;
			try { DebugEnterDecision(5, decisionCanBacktrack[5]);
			int LA5_0 = input.LA(1);

			if ((LA5_0==TYPE0))
			{
				alt5=1;
			}
			else if ((LA5_0==TYPE))
			{
				alt5=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 5, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(5); }
			switch (alt5)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:77:22: ( TYPE0 ID ASSIGN expression -> ^( VARDECLARATION TYPE0 ID expression ) )
				{
				DebugLocation(77, 22);
				// MathLang.g:77:22: ( TYPE0 ID ASSIGN expression -> ^( VARDECLARATION TYPE0 ID expression ) )
				DebugEnterAlt(1);
				// MathLang.g:77:23: TYPE0 ID ASSIGN expression
				{
				DebugLocation(77, 23);
				TYPE032=(IToken)Match(input,TYPE0,Follow._TYPE0_in_longdeclarationbody531); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_TYPE0.Add(TYPE032);

				DebugLocation(77, 29);
				ID33=(IToken)Match(input,ID,Follow._ID_in_longdeclarationbody533); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID33);

				DebugLocation(77, 32);
				ASSIGN34=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclarationbody535); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN34);

				DebugLocation(77, 39);
				PushFollow(Follow._expression_in_longdeclarationbody537);
				expression35=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression35.Tree);


				{
				// AST REWRITE
				// elements: TYPE0, expression, ID
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 77:50: -> ^( VARDECLARATION TYPE0 ID expression )
				{
					DebugLocation(77, 53);
					// MathLang.g:77:53: ^( VARDECLARATION TYPE0 ID expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(77, 55);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDECLARATION, "VARDECLARATION"), root_1);

					DebugLocation(77, 70);
					adaptor.AddChild(root_1, stream_TYPE0.NextNode());
					DebugLocation(77, 76);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(77, 79);
					adaptor.AddChild(root_1, stream_expression.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:78:5: ( TYPE ID ASSIGN expression -> ^( VARDECLARATION TYPE ID expression ) )
				{
				DebugLocation(78, 5);
				// MathLang.g:78:5: ( TYPE ID ASSIGN expression -> ^( VARDECLARATION TYPE ID expression ) )
				DebugEnterAlt(1);
				// MathLang.g:78:6: TYPE ID ASSIGN expression
				{
				DebugLocation(78, 6);
				TYPE36=(IToken)Match(input,TYPE,Follow._TYPE_in_longdeclarationbody558); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE36);

				DebugLocation(78, 11);
				ID37=(IToken)Match(input,ID,Follow._ID_in_longdeclarationbody560); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID37);

				DebugLocation(78, 14);
				ASSIGN38=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclarationbody562); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN38);

				DebugLocation(78, 21);
				PushFollow(Follow._expression_in_longdeclarationbody564);
				expression39=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression39.Tree);


				{
				// AST REWRITE
				// elements: expression, TYPE, ID
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 78:32: -> ^( VARDECLARATION TYPE ID expression )
				{
					DebugLocation(78, 35);
					// MathLang.g:78:35: ^( VARDECLARATION TYPE ID expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(78, 37);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDECLARATION, "VARDECLARATION"), root_1);

					DebugLocation(78, 52);
					adaptor.AddChild(root_1, stream_TYPE.NextNode());
					DebugLocation(78, 57);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(78, 60);
					adaptor.AddChild(root_1, stream_expression.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}


				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("longdeclarationbody", 10);
			LeaveRule("longdeclarationbody", 10);
			Leave_longdeclarationbody();
			if (state.backtracking > 0) { Memoize(input, 10, longdeclarationbody_StartIndex); }
		}
		DebugLocation(78, 72);
		} finally { DebugExitRule(GrammarFileName, "longdeclarationbody"); }
		return retval;

	}
	// $ANTLR end "longdeclarationbody"

	public class add_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_add();
	partial void Leave_add();

	// $ANTLR start "add"
	// MathLang.g:80:1: add : mul ( ( ADD | SUB ) mul )* ;
	[GrammarRule("add")]
	private MathLangParser.add_return add()
	{
		Enter_add();
		EnterRule("add", 11);
		TraceIn("add", 11);
		MathLangParser.add_return retval = new MathLangParser.add_return();
		retval.Start = (IToken)input.LT(1);
		int add_StartIndex = input.Index;
		object root_0 = null;

		IToken set41=null;
		MathLangParser.mul_return mul40 = default(MathLangParser.mul_return);
		MathLangParser.mul_return mul42 = default(MathLangParser.mul_return);

		object set41_tree=null;

		try { DebugEnterRule(GrammarFileName, "add");
		DebugLocation(80, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 11)) { return retval; }
			// MathLang.g:80:4: ( mul ( ( ADD | SUB ) mul )* )
			DebugEnterAlt(1);
			// MathLang.g:80:6: mul ( ( ADD | SUB ) mul )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(80, 6);
			PushFollow(Follow._mul_in_add585);
			mul40=mul();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul40.Tree);
			DebugLocation(80, 10);
			// MathLang.g:80:10: ( ( ADD | SUB ) mul )*
			try { DebugEnterSubRule(6);
			while (true)
			{
				int alt6=2;
				try { DebugEnterDecision(6, decisionCanBacktrack[6]);
				int LA6_0 = input.LA(1);

				if (((LA6_0>=ADD && LA6_0<=SUB)))
				{
					alt6=1;
				}


				} finally { DebugExitDecision(6); }
				switch ( alt6 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:80:12: ( ADD | SUB ) mul
					{
					DebugLocation(80, 12);
					set41=(IToken)input.LT(1);
					set41=(IToken)input.LT(1);
					if ((input.LA(1)>=ADD && input.LA(1)<=SUB))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set41), root_0);
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(80, 25);
					PushFollow(Follow._mul_in_add598);
					mul42=mul();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul42.Tree);

					}
					break;

				default:
					goto loop6;
				}
			}

			loop6:
				;

			} finally { DebugExitSubRule(6); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("add", 11);
			LeaveRule("add", 11);
			Leave_add();
			if (state.backtracking > 0) { Memoize(input, 11, add_StartIndex); }
		}
		DebugLocation(80, 30);
		} finally { DebugExitRule(GrammarFileName, "add"); }
		return retval;

	}
	// $ANTLR end "add"

	public class mul_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_mul();
	partial void Leave_mul();

	// $ANTLR start "mul"
	// MathLang.g:81:1: mul : group ( ( MUL | DIV ) group )* ;
	[GrammarRule("mul")]
	private MathLangParser.mul_return mul()
	{
		Enter_mul();
		EnterRule("mul", 12);
		TraceIn("mul", 12);
		MathLangParser.mul_return retval = new MathLangParser.mul_return();
		retval.Start = (IToken)input.LT(1);
		int mul_StartIndex = input.Index;
		object root_0 = null;

		IToken set44=null;
		MathLangParser.group_return group43 = default(MathLangParser.group_return);
		MathLangParser.group_return group45 = default(MathLangParser.group_return);

		object set44_tree=null;

		try { DebugEnterRule(GrammarFileName, "mul");
		DebugLocation(81, 33);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 12)) { return retval; }
			// MathLang.g:81:4: ( group ( ( MUL | DIV ) group )* )
			DebugEnterAlt(1);
			// MathLang.g:81:6: group ( ( MUL | DIV ) group )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(81, 6);
			PushFollow(Follow._group_in_mul607);
			group43=group();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group43.Tree);
			DebugLocation(81, 12);
			// MathLang.g:81:12: ( ( MUL | DIV ) group )*
			try { DebugEnterSubRule(7);
			while (true)
			{
				int alt7=2;
				try { DebugEnterDecision(7, decisionCanBacktrack[7]);
				int LA7_0 = input.LA(1);

				if (((LA7_0>=MUL && LA7_0<=DIV)))
				{
					alt7=1;
				}


				} finally { DebugExitDecision(7); }
				switch ( alt7 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:81:14: ( MUL | DIV ) group
					{
					DebugLocation(81, 14);
					set44=(IToken)input.LT(1);
					set44=(IToken)input.LT(1);
					if ((input.LA(1)>=MUL && input.LA(1)<=DIV))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set44), root_0);
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(81, 27);
					PushFollow(Follow._group_in_mul620);
					group45=group();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group45.Tree);

					}
					break;

				default:
					goto loop7;
				}
			}

			loop7:
				;

			} finally { DebugExitSubRule(7); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("mul", 12);
			LeaveRule("mul", 12);
			Leave_mul();
			if (state.backtracking > 0) { Memoize(input, 12, mul_StartIndex); }
		}
		DebugLocation(81, 33);
		} finally { DebugExitRule(GrammarFileName, "mul"); }
		return retval;

	}
	// $ANTLR end "mul"

	public class compare_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_compare();
	partial void Leave_compare();

	// $ANTLR start "compare"
	// MathLang.g:82:1: compare : add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )? ;
	[GrammarRule("compare")]
	private MathLangParser.compare_return compare()
	{
		Enter_compare();
		EnterRule("compare", 13);
		TraceIn("compare", 13);
		MathLangParser.compare_return retval = new MathLangParser.compare_return();
		retval.Start = (IToken)input.LT(1);
		int compare_StartIndex = input.Index;
		object root_0 = null;

		IToken set47=null;
		MathLangParser.add_return add46 = default(MathLangParser.add_return);
		MathLangParser.add_return add48 = default(MathLangParser.add_return);

		object set47_tree=null;

		try { DebugEnterRule(GrammarFileName, "compare");
		DebugLocation(82, 60);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 13)) { return retval; }
			// MathLang.g:82:8: ( add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )? )
			DebugEnterAlt(1);
			// MathLang.g:82:10: add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(82, 10);
			PushFollow(Follow._add_in_compare628);
			add46=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add46.Tree);
			DebugLocation(82, 14);
			// MathLang.g:82:14: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
			int alt8=2;
			try { DebugEnterSubRule(8);
			try { DebugEnterDecision(8, decisionCanBacktrack[8]);
			int LA8_0 = input.LA(1);

			if (((LA8_0>=NEQ && LA8_0<=EQ)))
			{
				int LA8_1 = input.LA(2);

				if ((EvaluatePredicate(synpred26_MathLang_fragment)))
				{
					alt8=1;
				}
			}
			else if (((LA8_0>=GREQ && LA8_0<=LSEQ)||(LA8_0>=GR && LA8_0<=LS)))
			{
				alt8=1;
			}
			} finally { DebugExitDecision(8); }
			switch (alt8)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:82:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
				{
				DebugLocation(82, 16);
				set47=(IToken)input.LT(1);
				set47=(IToken)input.LT(1);
				if ((input.LA(1)>=GREQ && input.LA(1)<=LS))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set47), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(82, 53);
				PushFollow(Follow._add_in_compare658);
				add48=add();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add48.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(8); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("compare", 13);
			LeaveRule("compare", 13);
			Leave_compare();
			if (state.backtracking > 0) { Memoize(input, 13, compare_StartIndex); }
		}
		DebugLocation(82, 60);
		} finally { DebugExitRule(GrammarFileName, "compare"); }
		return retval;

	}
	// $ANTLR end "compare"

	public class term_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_term();
	partial void Leave_term();

	// $ANTLR start "term"
	// MathLang.g:83:1: term : add ;
	[GrammarRule("term")]
	private MathLangParser.term_return term()
	{
		Enter_term();
		EnterRule("term", 14);
		TraceIn("term", 14);
		MathLangParser.term_return retval = new MathLangParser.term_return();
		retval.Start = (IToken)input.LT(1);
		int term_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.add_return add49 = default(MathLangParser.add_return);


		try { DebugEnterRule(GrammarFileName, "term");
		DebugLocation(83, 9);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 14)) { return retval; }
			// MathLang.g:83:5: ( add )
			DebugEnterAlt(1);
			// MathLang.g:83:7: add
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(83, 7);
			PushFollow(Follow._add_in_term669);
			add49=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add49.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("term", 14);
			LeaveRule("term", 14);
			Leave_term();
			if (state.backtracking > 0) { Memoize(input, 14, term_StartIndex); }
		}
		DebugLocation(83, 9);
		} finally { DebugExitRule(GrammarFileName, "term"); }
		return retval;

	}
	// $ANTLR end "term"

	public class group_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_group();
	partial void Leave_group();

	// $ANTLR start "group"
	// MathLang.g:84:1: group : ( ( SUB )? '(' term ')' | number );
	[GrammarRule("group")]
	private MathLangParser.group_return group()
	{
		Enter_group();
		EnterRule("group", 15);
		TraceIn("group", 15);
		MathLangParser.group_return retval = new MathLangParser.group_return();
		retval.Start = (IToken)input.LT(1);
		int group_StartIndex = input.Index;
		object root_0 = null;

		IToken SUB50=null;
		IToken char_literal51=null;
		IToken char_literal53=null;
		MathLangParser.term_return term52 = default(MathLangParser.term_return);
		MathLangParser.number_return number54 = default(MathLangParser.number_return);

		object SUB50_tree=null;
		object char_literal51_tree=null;
		object char_literal53_tree=null;

		try { DebugEnterRule(GrammarFileName, "group");
		DebugLocation(84, 38);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 15)) { return retval; }
			// MathLang.g:84:6: ( ( SUB )? '(' term ')' | number )
			int alt10=2;
			try { DebugEnterDecision(10, decisionCanBacktrack[10]);
			int LA10_0 = input.LA(1);

			if ((LA10_0==SUB||LA10_0==54))
			{
				alt10=1;
			}
			else if (((LA10_0>=NUMBER && LA10_0<=CHAR)))
			{
				alt10=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 10, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(10); }
			switch (alt10)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:84:8: ( SUB )? '(' term ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(84, 8);
				// MathLang.g:84:8: ( SUB )?
				int alt9=2;
				try { DebugEnterSubRule(9);
				try { DebugEnterDecision(9, decisionCanBacktrack[9]);
				int LA9_0 = input.LA(1);

				if ((LA9_0==SUB))
				{
					alt9=1;
				}
				} finally { DebugExitDecision(9); }
				switch (alt9)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:84:9: SUB
					{
					DebugLocation(84, 12);
					SUB50=(IToken)Match(input,SUB,Follow._SUB_in_group676); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					SUB50_tree = (object)adaptor.Create(SUB50);
					root_0 = (object)adaptor.BecomeRoot(SUB50_tree, root_0);
					}

					}
					break;

				}
				} finally { DebugExitSubRule(9); }

				DebugLocation(84, 19);
				char_literal51=(IToken)Match(input,54,Follow._54_in_group681); if (state.failed) return retval;
				DebugLocation(84, 21);
				PushFollow(Follow._term_in_group684);
				term52=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term52.Tree);
				DebugLocation(84, 29);
				char_literal53=(IToken)Match(input,55,Follow._55_in_group686); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:84:33: number
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(84, 33);
				PushFollow(Follow._number_in_group691);
				number54=number();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, number54.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("group", 15);
			LeaveRule("group", 15);
			Leave_group();
			if (state.backtracking > 0) { Memoize(input, 15, group_StartIndex); }
		}
		DebugLocation(84, 38);
		} finally { DebugExitRule(GrammarFileName, "group"); }
		return retval;

	}
	// $ANTLR end "group"

	public class assignment_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_assignment();
	partial void Leave_assignment();

	// $ANTLR start "assignment"
	// MathLang.g:86:1: assignment : assignmentbody ';' ;
	[GrammarRule("assignment")]
	private MathLangParser.assignment_return assignment()
	{
		Enter_assignment();
		EnterRule("assignment", 16);
		TraceIn("assignment", 16);
		MathLangParser.assignment_return retval = new MathLangParser.assignment_return();
		retval.Start = (IToken)input.LT(1);
		int assignment_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal56=null;
		MathLangParser.assignmentbody_return assignmentbody55 = default(MathLangParser.assignmentbody_return);

		object char_literal56_tree=null;

		try { DebugEnterRule(GrammarFileName, "assignment");
		DebugLocation(86, 31);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 16)) { return retval; }
			// MathLang.g:86:11: ( assignmentbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:86:13: assignmentbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(86, 13);
			PushFollow(Follow._assignmentbody_in_assignment698);
			assignmentbody55=assignmentbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentbody55.Tree);
			DebugLocation(86, 31);
			char_literal56=(IToken)Match(input,53,Follow._53_in_assignment700); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("assignment", 16);
			LeaveRule("assignment", 16);
			Leave_assignment();
			if (state.backtracking > 0) { Memoize(input, 16, assignment_StartIndex); }
		}
		DebugLocation(86, 31);
		} finally { DebugExitRule(GrammarFileName, "assignment"); }
		return retval;

	}
	// $ANTLR end "assignment"

	public class assignmentbody_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_assignmentbody();
	partial void Leave_assignmentbody();

	// $ANTLR start "assignmentbody"
	// MathLang.g:87:1: assignmentbody : ( ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) ) | ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) ) );
	[GrammarRule("assignmentbody")]
	private MathLangParser.assignmentbody_return assignmentbody()
	{
		Enter_assignmentbody();
		EnterRule("assignmentbody", 17);
		TraceIn("assignmentbody", 17);
		MathLangParser.assignmentbody_return retval = new MathLangParser.assignmentbody_return();
		retval.Start = (IToken)input.LT(1);
		int assignmentbody_StartIndex = input.Index;
		object root_0 = null;

		IToken ID57=null;
		IToken ASSIGN58=null;
		IToken ASSIGN61=null;
		MathLangParser.expression_return expression59 = default(MathLangParser.expression_return);
		MathLangParser.arrayelement_return arrayelement60 = default(MathLangParser.arrayelement_return);
		MathLangParser.expression_return expression62 = default(MathLangParser.expression_return);

		object ID57_tree=null;
		object ASSIGN58_tree=null;
		object ASSIGN61_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_arrayelement=new RewriteRuleSubtreeStream(adaptor,"rule arrayelement");
		try { DebugEnterRule(GrammarFileName, "assignmentbody");
		DebugLocation(87, 87);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 17)) { return retval; }
			// MathLang.g:87:15: ( ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) ) | ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) ) )
			int alt11=2;
			try { DebugEnterDecision(11, decisionCanBacktrack[11]);
			int LA11_0 = input.LA(1);

			if ((LA11_0==ID))
			{
				int LA11_1 = input.LA(2);

				if ((LA11_1==ASSIGN))
				{
					alt11=1;
				}
				else if ((LA11_1==SQRBL))
				{
					alt11=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 11, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 11, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(11); }
			switch (alt11)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:87:17: ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) )
				{
				DebugLocation(87, 17);
				// MathLang.g:87:17: ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) )
				DebugEnterAlt(1);
				// MathLang.g:87:18: ID ASSIGN expression
				{
				DebugLocation(87, 18);
				ID57=(IToken)Match(input,ID,Follow._ID_in_assignmentbody708); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID57);

				DebugLocation(87, 21);
				ASSIGN58=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignmentbody710); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN58);

				DebugLocation(87, 28);
				PushFollow(Follow._expression_in_assignmentbody712);
				expression59=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression59.Tree);


				{
				// AST REWRITE
				// elements: ID, expression
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 87:39: -> ^( VARASSIGNMENT ID expression )
				{
					DebugLocation(87, 42);
					// MathLang.g:87:42: ^( VARASSIGNMENT ID expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(87, 44);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARASSIGNMENT, "VARASSIGNMENT"), root_1);

					DebugLocation(87, 58);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(87, 61);
					adaptor.AddChild(root_1, stream_expression.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:88:2: ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) )
				{
				DebugLocation(88, 2);
				// MathLang.g:88:2: ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) )
				DebugEnterAlt(1);
				// MathLang.g:88:4: arrayelement ASSIGN expression
				{
				DebugLocation(88, 4);
				PushFollow(Follow._arrayelement_in_assignmentbody731);
				arrayelement60=arrayelement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_arrayelement.Add(arrayelement60.Tree);
				DebugLocation(88, 17);
				ASSIGN61=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignmentbody733); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN61);

				DebugLocation(88, 24);
				PushFollow(Follow._expression_in_assignmentbody735);
				expression62=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression62.Tree);


				{
				// AST REWRITE
				// elements: expression, arrayelement
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 88:35: -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression )
				{
					DebugLocation(88, 38);
					// MathLang.g:88:38: ^( ARRAYELEMENTASSIGNMENT arrayelement expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(88, 40);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYELEMENTASSIGNMENT, "ARRAYELEMENTASSIGNMENT"), root_1);

					DebugLocation(88, 63);
					adaptor.AddChild(root_1, stream_arrayelement.NextTree());
					DebugLocation(88, 76);
					adaptor.AddChild(root_1, stream_expression.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}


				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("assignmentbody", 17);
			LeaveRule("assignmentbody", 17);
			Leave_assignmentbody();
			if (state.backtracking > 0) { Memoize(input, 17, assignmentbody_StartIndex); }
		}
		DebugLocation(88, 87);
		} finally { DebugExitRule(GrammarFileName, "assignmentbody"); }
		return retval;

	}
	// $ANTLR end "assignmentbody"

	public class boolexpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_boolexpression();
	partial void Leave_boolexpression();

	// $ANTLR start "boolexpression"
	// MathLang.g:90:1: boolexpression : boolterm ;
	[GrammarRule("boolexpression")]
	private MathLangParser.boolexpression_return boolexpression()
	{
		Enter_boolexpression();
		EnterRule("boolexpression", 18);
		TraceIn("boolexpression", 18);
		MathLangParser.boolexpression_return retval = new MathLangParser.boolexpression_return();
		retval.Start = (IToken)input.LT(1);
		int boolexpression_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.boolterm_return boolterm63 = default(MathLangParser.boolterm_return);


		try { DebugEnterRule(GrammarFileName, "boolexpression");
		DebugLocation(90, 25);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 18)) { return retval; }
			// MathLang.g:90:15: ( boolterm )
			DebugEnterAlt(1);
			// MathLang.g:90:17: boolterm
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(90, 17);
			PushFollow(Follow._boolterm_in_boolexpression753);
			boolterm63=boolterm();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm63.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("boolexpression", 18);
			LeaveRule("boolexpression", 18);
			Leave_boolexpression();
			if (state.backtracking > 0) { Memoize(input, 18, boolexpression_StartIndex); }
		}
		DebugLocation(90, 25);
		} finally { DebugExitRule(GrammarFileName, "boolexpression"); }
		return retval;

	}
	// $ANTLR end "boolexpression"

	public class boolterm_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_boolterm();
	partial void Leave_boolterm();

	// $ANTLR start "boolterm"
	// MathLang.g:91:1: boolterm : or ( ( EQ | NEQ ) or )? ;
	[GrammarRule("boolterm")]
	private MathLangParser.boolterm_return boolterm()
	{
		Enter_boolterm();
		EnterRule("boolterm", 19);
		TraceIn("boolterm", 19);
		MathLangParser.boolterm_return retval = new MathLangParser.boolterm_return();
		retval.Start = (IToken)input.LT(1);
		int boolterm_StartIndex = input.Index;
		object root_0 = null;

		IToken set65=null;
		MathLangParser.or_return or64 = default(MathLangParser.or_return);
		MathLangParser.or_return or66 = default(MathLangParser.or_return);

		object set65_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolterm");
		DebugLocation(91, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 19)) { return retval; }
			// MathLang.g:91:9: ( or ( ( EQ | NEQ ) or )? )
			DebugEnterAlt(1);
			// MathLang.g:91:11: or ( ( EQ | NEQ ) or )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(91, 11);
			PushFollow(Follow._or_in_boolterm760);
			or64=or();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or64.Tree);
			DebugLocation(91, 14);
			// MathLang.g:91:14: ( ( EQ | NEQ ) or )?
			int alt12=2;
			try { DebugEnterSubRule(12);
			try { DebugEnterDecision(12, decisionCanBacktrack[12]);
			int LA12_0 = input.LA(1);

			if (((LA12_0>=NEQ && LA12_0<=EQ)))
			{
				alt12=1;
			}
			} finally { DebugExitDecision(12); }
			switch (alt12)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:91:16: ( EQ | NEQ ) or
				{
				DebugLocation(91, 16);
				set65=(IToken)input.LT(1);
				set65=(IToken)input.LT(1);
				if ((input.LA(1)>=NEQ && input.LA(1)<=EQ))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set65), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(91, 28);
				PushFollow(Follow._or_in_boolterm773);
				or66=or();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or66.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(12); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("boolterm", 19);
			LeaveRule("boolterm", 19);
			Leave_boolterm();
			if (state.backtracking > 0) { Memoize(input, 19, boolterm_StartIndex); }
		}
		DebugLocation(91, 32);
		} finally { DebugExitRule(GrammarFileName, "boolterm"); }
		return retval;

	}
	// $ANTLR end "boolterm"

	public class or_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_or();
	partial void Leave_or();

	// $ANTLR start "or"
	// MathLang.g:92:1: or : and ( OR and )* ;
	[GrammarRule("or")]
	private MathLangParser.or_return or()
	{
		Enter_or();
		EnterRule("or", 20);
		TraceIn("or", 20);
		MathLangParser.or_return retval = new MathLangParser.or_return();
		retval.Start = (IToken)input.LT(1);
		int or_StartIndex = input.Index;
		object root_0 = null;

		IToken OR68=null;
		MathLangParser.and_return and67 = default(MathLangParser.and_return);
		MathLangParser.and_return and69 = default(MathLangParser.and_return);

		object OR68_tree=null;

		try { DebugEnterRule(GrammarFileName, "or");
		DebugLocation(92, 18);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 20)) { return retval; }
			// MathLang.g:92:3: ( and ( OR and )* )
			DebugEnterAlt(1);
			// MathLang.g:92:5: and ( OR and )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(92, 5);
			PushFollow(Follow._and_in_or782);
			and67=and();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and67.Tree);
			DebugLocation(92, 9);
			// MathLang.g:92:9: ( OR and )*
			try { DebugEnterSubRule(13);
			while (true)
			{
				int alt13=2;
				try { DebugEnterDecision(13, decisionCanBacktrack[13]);
				int LA13_0 = input.LA(1);

				if ((LA13_0==OR))
				{
					alt13=1;
				}


				} finally { DebugExitDecision(13); }
				switch ( alt13 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:92:10: OR and
					{
					DebugLocation(92, 12);
					OR68=(IToken)Match(input,OR,Follow._OR_in_or785); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR68_tree = (object)adaptor.Create(OR68);
					root_0 = (object)adaptor.BecomeRoot(OR68_tree, root_0);
					}
					DebugLocation(92, 14);
					PushFollow(Follow._and_in_or788);
					and69=and();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and69.Tree);

					}
					break;

				default:
					goto loop13;
				}
			}

			loop13:
				;

			} finally { DebugExitSubRule(13); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("or", 20);
			LeaveRule("or", 20);
			Leave_or();
			if (state.backtracking > 0) { Memoize(input, 20, or_StartIndex); }
		}
		DebugLocation(92, 18);
		} finally { DebugExitRule(GrammarFileName, "or"); }
		return retval;

	}
	// $ANTLR end "or"

	public class and_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_and();
	partial void Leave_and();

	// $ANTLR start "and"
	// MathLang.g:93:1: and : boolgroup ( AND boolgroup )* ;
	[GrammarRule("and")]
	private MathLangParser.and_return and()
	{
		Enter_and();
		EnterRule("and", 21);
		TraceIn("and", 21);
		MathLangParser.and_return retval = new MathLangParser.and_return();
		retval.Start = (IToken)input.LT(1);
		int and_StartIndex = input.Index;
		object root_0 = null;

		IToken AND71=null;
		MathLangParser.boolgroup_return boolgroup70 = default(MathLangParser.boolgroup_return);
		MathLangParser.boolgroup_return boolgroup72 = default(MathLangParser.boolgroup_return);

		object AND71_tree=null;

		try { DebugEnterRule(GrammarFileName, "and");
		DebugLocation(93, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 21)) { return retval; }
			// MathLang.g:93:4: ( boolgroup ( AND boolgroup )* )
			DebugEnterAlt(1);
			// MathLang.g:93:6: boolgroup ( AND boolgroup )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(93, 6);
			PushFollow(Follow._boolgroup_in_and796);
			boolgroup70=boolgroup();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup70.Tree);
			DebugLocation(93, 16);
			// MathLang.g:93:16: ( AND boolgroup )*
			try { DebugEnterSubRule(14);
			while (true)
			{
				int alt14=2;
				try { DebugEnterDecision(14, decisionCanBacktrack[14]);
				int LA14_0 = input.LA(1);

				if ((LA14_0==AND))
				{
					alt14=1;
				}


				} finally { DebugExitDecision(14); }
				switch ( alt14 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:93:17: AND boolgroup
					{
					DebugLocation(93, 20);
					AND71=(IToken)Match(input,AND,Follow._AND_in_and799); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND71_tree = (object)adaptor.Create(AND71);
					root_0 = (object)adaptor.BecomeRoot(AND71_tree, root_0);
					}
					DebugLocation(93, 22);
					PushFollow(Follow._boolgroup_in_and802);
					boolgroup72=boolgroup();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup72.Tree);

					}
					break;

				default:
					goto loop14;
				}
			}

			loop14:
				;

			} finally { DebugExitSubRule(14); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("and", 21);
			LeaveRule("and", 21);
			Leave_and();
			if (state.backtracking > 0) { Memoize(input, 21, and_StartIndex); }
		}
		DebugLocation(93, 32);
		} finally { DebugExitRule(GrammarFileName, "and"); }
		return retval;

	}
	// $ANTLR end "and"

	public class boolgroup_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_boolgroup();
	partial void Leave_boolgroup();

	// $ANTLR start "boolgroup"
	// MathLang.g:94:1: boolgroup : ( NOT )? ( '(' boolterm ')' | boolvar ) ;
	[GrammarRule("boolgroup")]
	private MathLangParser.boolgroup_return boolgroup()
	{
		Enter_boolgroup();
		EnterRule("boolgroup", 22);
		TraceIn("boolgroup", 22);
		MathLangParser.boolgroup_return retval = new MathLangParser.boolgroup_return();
		retval.Start = (IToken)input.LT(1);
		int boolgroup_StartIndex = input.Index;
		object root_0 = null;

		IToken NOT73=null;
		IToken char_literal74=null;
		IToken char_literal76=null;
		MathLangParser.boolterm_return boolterm75 = default(MathLangParser.boolterm_return);
		MathLangParser.boolvar_return boolvar77 = default(MathLangParser.boolvar_return);

		object NOT73_tree=null;
		object char_literal74_tree=null;
		object char_literal76_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolgroup");
		DebugLocation(94, 51);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 22)) { return retval; }
			// MathLang.g:94:10: ( ( NOT )? ( '(' boolterm ')' | boolvar ) )
			DebugEnterAlt(1);
			// MathLang.g:94:12: ( NOT )? ( '(' boolterm ')' | boolvar )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(94, 12);
			// MathLang.g:94:12: ( NOT )?
			int alt15=2;
			try { DebugEnterSubRule(15);
			try { DebugEnterDecision(15, decisionCanBacktrack[15]);
			int LA15_0 = input.LA(1);

			if ((LA15_0==NOT))
			{
				alt15=1;
			}
			} finally { DebugExitDecision(15); }
			switch (alt15)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:94:13: NOT
				{
				DebugLocation(94, 16);
				NOT73=(IToken)Match(input,NOT,Follow._NOT_in_boolgroup811); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				NOT73_tree = (object)adaptor.Create(NOT73);
				root_0 = (object)adaptor.BecomeRoot(NOT73_tree, root_0);
				}

				}
				break;

			}
			} finally { DebugExitSubRule(15); }

			DebugLocation(94, 20);
			// MathLang.g:94:20: ( '(' boolterm ')' | boolvar )
			int alt16=2;
			try { DebugEnterSubRule(16);
			try { DebugEnterDecision(16, decisionCanBacktrack[16]);
			int LA16_0 = input.LA(1);

			if ((LA16_0==54))
			{
				int LA16_1 = input.LA(2);

				if ((EvaluatePredicate(synpred35_MathLang_fragment)))
				{
					alt16=1;
				}
				else if ((true))
				{
					alt16=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 16, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else if (((LA16_0>=NUMBER && LA16_0<=CHAR)||LA16_0==SUB||(LA16_0>=TRUE && LA16_0<=FALSE)))
			{
				alt16=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 16, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(16); }
			switch (alt16)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:94:22: '(' boolterm ')'
				{
				DebugLocation(94, 25);
				char_literal74=(IToken)Match(input,54,Follow._54_in_boolgroup818); if (state.failed) return retval;
				DebugLocation(94, 27);
				PushFollow(Follow._boolterm_in_boolgroup821);
				boolterm75=boolterm();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm75.Tree);
				DebugLocation(94, 39);
				char_literal76=(IToken)Match(input,55,Follow._55_in_boolgroup823); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:94:43: boolvar
				{
				DebugLocation(94, 43);
				PushFollow(Follow._boolvar_in_boolgroup828);
				boolvar77=boolvar();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolvar77.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(16); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("boolgroup", 22);
			LeaveRule("boolgroup", 22);
			Leave_boolgroup();
			if (state.backtracking > 0) { Memoize(input, 22, boolgroup_StartIndex); }
		}
		DebugLocation(94, 51);
		} finally { DebugExitRule(GrammarFileName, "boolgroup"); }
		return retval;

	}
	// $ANTLR end "boolgroup"

	public class boolvar_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_boolvar();
	partial void Leave_boolvar();

	// $ANTLR start "boolvar"
	// MathLang.g:95:1: boolvar : ( TRUE | FALSE | compare );
	[GrammarRule("boolvar")]
	private MathLangParser.boolvar_return boolvar()
	{
		Enter_boolvar();
		EnterRule("boolvar", 23);
		TraceIn("boolvar", 23);
		MathLangParser.boolvar_return retval = new MathLangParser.boolvar_return();
		retval.Start = (IToken)input.LT(1);
		int boolvar_StartIndex = input.Index;
		object root_0 = null;

		IToken TRUE78=null;
		IToken FALSE79=null;
		MathLangParser.compare_return compare80 = default(MathLangParser.compare_return);

		object TRUE78_tree=null;
		object FALSE79_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolvar");
		DebugLocation(95, 11);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 23)) { return retval; }
			// MathLang.g:95:8: ( TRUE | FALSE | compare )
			int alt17=3;
			try { DebugEnterDecision(17, decisionCanBacktrack[17]);
			switch (input.LA(1))
			{
			case TRUE:
				{
				alt17=1;
				}
				break;
			case FALSE:
				{
				alt17=2;
				}
				break;
			case NUMBER:
			case ID:
			case CHAR:
			case SUB:
			case 54:
				{
				alt17=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 17, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(17); }
			switch (alt17)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:95:10: TRUE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(95, 10);
				TRUE78=(IToken)Match(input,TRUE,Follow._TRUE_in_boolvar836); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				TRUE78_tree = (object)adaptor.Create(TRUE78);
				adaptor.AddChild(root_0, TRUE78_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:96:5: FALSE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(96, 5);
				FALSE79=(IToken)Match(input,FALSE,Follow._FALSE_in_boolvar842); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				FALSE79_tree = (object)adaptor.Create(FALSE79);
				adaptor.AddChild(root_0, FALSE79_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:97:5: compare
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(97, 5);
				PushFollow(Follow._compare_in_boolvar848);
				compare80=compare();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare80.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("boolvar", 23);
			LeaveRule("boolvar", 23);
			Leave_boolvar();
			if (state.backtracking > 0) { Memoize(input, 23, boolvar_StartIndex); }
		}
		DebugLocation(97, 11);
		} finally { DebugExitRule(GrammarFileName, "boolvar"); }
		return retval;

	}
	// $ANTLR end "boolvar"

	public class ifstatement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_ifstatement();
	partial void Leave_ifstatement();

	// $ANTLR start "ifstatement"
	// MathLang.g:99:1: ifstatement : IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )* ;
	[GrammarRule("ifstatement")]
	private MathLangParser.ifstatement_return ifstatement()
	{
		Enter_ifstatement();
		EnterRule("ifstatement", 24);
		TraceIn("ifstatement", 24);
		MathLangParser.ifstatement_return retval = new MathLangParser.ifstatement_return();
		retval.Start = (IToken)input.LT(1);
		int ifstatement_StartIndex = input.Index;
		object root_0 = null;

		IToken IF81=null;
		IToken char_literal82=null;
		IToken char_literal84=null;
		IToken ELSE87=null;
		MathLangParser.boolexpression_return boolexpression83 = default(MathLangParser.boolexpression_return);
		MathLangParser.block_return block85 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement86 = default(MathLangParser.statement_return);
		MathLangParser.block_return block88 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement89 = default(MathLangParser.statement_return);

		object IF81_tree=null;
		object char_literal82_tree=null;
		object char_literal84_tree=null;
		object ELSE87_tree=null;

		try { DebugEnterRule(GrammarFileName, "ifstatement");
		DebugLocation(99, 91);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 24)) { return retval; }
			// MathLang.g:99:12: ( IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )* )
			DebugEnterAlt(1);
			// MathLang.g:99:14: IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(99, 16);
			IF81=(IToken)Match(input,IF,Follow._IF_in_ifstatement855); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			IF81_tree = (object)adaptor.Create(IF81);
			root_0 = (object)adaptor.BecomeRoot(IF81_tree, root_0);
			}
			DebugLocation(99, 21);
			char_literal82=(IToken)Match(input,54,Follow._54_in_ifstatement858); if (state.failed) return retval;
			DebugLocation(99, 23);
			PushFollow(Follow._boolexpression_in_ifstatement861);
			boolexpression83=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression83.Tree);
			DebugLocation(99, 41);
			char_literal84=(IToken)Match(input,55,Follow._55_in_ifstatement863); if (state.failed) return retval;
			DebugLocation(99, 43);
			// MathLang.g:99:43: ( block | statement )
			int alt18=2;
			try { DebugEnterSubRule(18);
			try { DebugEnterDecision(18, decisionCanBacktrack[18]);
			int LA18_0 = input.LA(1);

			if ((LA18_0==58))
			{
				alt18=1;
			}
			else if ((LA18_0==IF||LA18_0==FOR||(LA18_0>=RETURN && LA18_0<=WHILE)||LA18_0==ID||(LA18_0>=TYPE && LA18_0<=TYPE0)))
			{
				alt18=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 18, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(18); }
			switch (alt18)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:99:44: block
				{
				DebugLocation(99, 44);
				PushFollow(Follow._block_in_ifstatement867);
				block85=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block85.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:99:52: statement
				{
				DebugLocation(99, 52);
				PushFollow(Follow._statement_in_ifstatement871);
				statement86=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement86.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(18); }

			DebugLocation(99, 63);
			// MathLang.g:99:63: ( ELSE ( block | statement ) )*
			try { DebugEnterSubRule(20);
			while (true)
			{
				int alt20=2;
				try { DebugEnterDecision(20, decisionCanBacktrack[20]);
				int LA20_0 = input.LA(1);

				if ((LA20_0==ELSE))
				{
					int LA20_1 = input.LA(2);

					if ((EvaluatePredicate(synpred40_MathLang_fragment)))
					{
						alt20=1;
					}


				}


				} finally { DebugExitDecision(20); }
				switch ( alt20 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:99:64: ELSE ( block | statement )
					{
					DebugLocation(99, 68);
					ELSE87=(IToken)Match(input,ELSE,Follow._ELSE_in_ifstatement875); if (state.failed) return retval;
					DebugLocation(99, 70);
					// MathLang.g:99:70: ( block | statement )
					int alt19=2;
					try { DebugEnterSubRule(19);
					try { DebugEnterDecision(19, decisionCanBacktrack[19]);
					int LA19_0 = input.LA(1);

					if ((LA19_0==58))
					{
						alt19=1;
					}
					else if ((LA19_0==IF||LA19_0==FOR||(LA19_0>=RETURN && LA19_0<=WHILE)||LA19_0==ID||(LA19_0>=TYPE && LA19_0<=TYPE0)))
					{
						alt19=2;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 19, 0, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
					} finally { DebugExitDecision(19); }
					switch (alt19)
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:99:71: block
						{
						DebugLocation(99, 71);
						PushFollow(Follow._block_in_ifstatement879);
						block88=block();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block88.Tree);

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// MathLang.g:99:79: statement
						{
						DebugLocation(99, 79);
						PushFollow(Follow._statement_in_ifstatement883);
						statement89=statement();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement89.Tree);

						}
						break;

					}
					} finally { DebugExitSubRule(19); }


					}
					break;

				default:
					goto loop20;
				}
			}

			loop20:
				;

			} finally { DebugExitSubRule(20); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("ifstatement", 24);
			LeaveRule("ifstatement", 24);
			Leave_ifstatement();
			if (state.backtracking > 0) { Memoize(input, 24, ifstatement_StartIndex); }
		}
		DebugLocation(99, 91);
		} finally { DebugExitRule(GrammarFileName, "ifstatement"); }
		return retval;

	}
	// $ANTLR end "ifstatement"

	public class whilestatement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_whilestatement();
	partial void Leave_whilestatement();

	// $ANTLR start "whilestatement"
	// MathLang.g:100:1: whilestatement : WHILE '(' boolexpression ')' ( block | statement ) ;
	[GrammarRule("whilestatement")]
	private MathLangParser.whilestatement_return whilestatement()
	{
		Enter_whilestatement();
		EnterRule("whilestatement", 25);
		TraceIn("whilestatement", 25);
		MathLangParser.whilestatement_return retval = new MathLangParser.whilestatement_return();
		retval.Start = (IToken)input.LT(1);
		int whilestatement_StartIndex = input.Index;
		object root_0 = null;

		IToken WHILE90=null;
		IToken char_literal91=null;
		IToken char_literal93=null;
		MathLangParser.boolexpression_return boolexpression92 = default(MathLangParser.boolexpression_return);
		MathLangParser.block_return block94 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement95 = default(MathLangParser.statement_return);

		object WHILE90_tree=null;
		object char_literal91_tree=null;
		object char_literal93_tree=null;

		try { DebugEnterRule(GrammarFileName, "whilestatement");
		DebugLocation(100, 67);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 25)) { return retval; }
			// MathLang.g:100:15: ( WHILE '(' boolexpression ')' ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:100:17: WHILE '(' boolexpression ')' ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(100, 22);
			WHILE90=(IToken)Match(input,WHILE,Follow._WHILE_in_whilestatement893); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			WHILE90_tree = (object)adaptor.Create(WHILE90);
			root_0 = (object)adaptor.BecomeRoot(WHILE90_tree, root_0);
			}
			DebugLocation(100, 27);
			char_literal91=(IToken)Match(input,54,Follow._54_in_whilestatement896); if (state.failed) return retval;
			DebugLocation(100, 29);
			PushFollow(Follow._boolexpression_in_whilestatement899);
			boolexpression92=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression92.Tree);
			DebugLocation(100, 47);
			char_literal93=(IToken)Match(input,55,Follow._55_in_whilestatement901); if (state.failed) return retval;
			DebugLocation(100, 49);
			// MathLang.g:100:49: ( block | statement )
			int alt21=2;
			try { DebugEnterSubRule(21);
			try { DebugEnterDecision(21, decisionCanBacktrack[21]);
			int LA21_0 = input.LA(1);

			if ((LA21_0==58))
			{
				alt21=1;
			}
			else if ((LA21_0==IF||LA21_0==FOR||(LA21_0>=RETURN && LA21_0<=WHILE)||LA21_0==ID||(LA21_0>=TYPE && LA21_0<=TYPE0)))
			{
				alt21=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 21, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(21); }
			switch (alt21)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:100:50: block
				{
				DebugLocation(100, 50);
				PushFollow(Follow._block_in_whilestatement905);
				block94=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block94.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:100:58: statement
				{
				DebugLocation(100, 58);
				PushFollow(Follow._statement_in_whilestatement909);
				statement95=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement95.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(21); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("whilestatement", 25);
			LeaveRule("whilestatement", 25);
			Leave_whilestatement();
			if (state.backtracking > 0) { Memoize(input, 25, whilestatement_StartIndex); }
		}
		DebugLocation(100, 67);
		} finally { DebugExitRule(GrammarFileName, "whilestatement"); }
		return retval;

	}
	// $ANTLR end "whilestatement"

	public class forstatement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_forstatement();
	partial void Leave_forstatement();

	// $ANTLR start "forstatement"
	// MathLang.g:101:1: forstatement : FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement ) ;
	[GrammarRule("forstatement")]
	private MathLangParser.forstatement_return forstatement()
	{
		Enter_forstatement();
		EnterRule("forstatement", 26);
		TraceIn("forstatement", 26);
		MathLangParser.forstatement_return retval = new MathLangParser.forstatement_return();
		retval.Start = (IToken)input.LT(1);
		int forstatement_StartIndex = input.Index;
		object root_0 = null;

		IToken FOR96=null;
		IToken char_literal97=null;
		IToken char_literal99=null;
		IToken char_literal101=null;
		IToken char_literal103=null;
		MathLangParser.longdeclarationbody_return longdeclarationbody98 = default(MathLangParser.longdeclarationbody_return);
		MathLangParser.boolexpression_return boolexpression100 = default(MathLangParser.boolexpression_return);
		MathLangParser.assignmentbody_return assignmentbody102 = default(MathLangParser.assignmentbody_return);
		MathLangParser.block_return block104 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement105 = default(MathLangParser.statement_return);

		object FOR96_tree=null;
		object char_literal97_tree=null;
		object char_literal99_tree=null;
		object char_literal101_tree=null;
		object char_literal103_tree=null;

		try { DebugEnterRule(GrammarFileName, "forstatement");
		DebugLocation(101, 108);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 26)) { return retval; }
			// MathLang.g:101:13: ( FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:101:15: FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(101, 18);
			FOR96=(IToken)Match(input,FOR,Follow._FOR_in_forstatement916); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			FOR96_tree = (object)adaptor.Create(FOR96);
			root_0 = (object)adaptor.BecomeRoot(FOR96_tree, root_0);
			}
			DebugLocation(101, 23);
			char_literal97=(IToken)Match(input,54,Follow._54_in_forstatement919); if (state.failed) return retval;
			DebugLocation(101, 25);
			PushFollow(Follow._longdeclarationbody_in_forstatement922);
			longdeclarationbody98=longdeclarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclarationbody98.Tree);
			DebugLocation(101, 48);
			char_literal99=(IToken)Match(input,53,Follow._53_in_forstatement924); if (state.failed) return retval;
			DebugLocation(101, 50);
			PushFollow(Follow._boolexpression_in_forstatement927);
			boolexpression100=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression100.Tree);
			DebugLocation(101, 68);
			char_literal101=(IToken)Match(input,53,Follow._53_in_forstatement929); if (state.failed) return retval;
			DebugLocation(101, 70);
			PushFollow(Follow._assignmentbody_in_forstatement932);
			assignmentbody102=assignmentbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentbody102.Tree);
			DebugLocation(101, 88);
			char_literal103=(IToken)Match(input,55,Follow._55_in_forstatement934); if (state.failed) return retval;
			DebugLocation(101, 90);
			// MathLang.g:101:90: ( block | statement )
			int alt22=2;
			try { DebugEnterSubRule(22);
			try { DebugEnterDecision(22, decisionCanBacktrack[22]);
			int LA22_0 = input.LA(1);

			if ((LA22_0==58))
			{
				alt22=1;
			}
			else if ((LA22_0==IF||LA22_0==FOR||(LA22_0>=RETURN && LA22_0<=WHILE)||LA22_0==ID||(LA22_0>=TYPE && LA22_0<=TYPE0)))
			{
				alt22=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 22, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(22); }
			switch (alt22)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:101:91: block
				{
				DebugLocation(101, 91);
				PushFollow(Follow._block_in_forstatement938);
				block104=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block104.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:101:99: statement
				{
				DebugLocation(101, 99);
				PushFollow(Follow._statement_in_forstatement942);
				statement105=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement105.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(22); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("forstatement", 26);
			LeaveRule("forstatement", 26);
			Leave_forstatement();
			if (state.backtracking > 0) { Memoize(input, 26, forstatement_StartIndex); }
		}
		DebugLocation(101, 108);
		} finally { DebugExitRule(GrammarFileName, "forstatement"); }
		return retval;

	}
	// $ANTLR end "forstatement"

	public class returnstatement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_returnstatement();
	partial void Leave_returnstatement();

	// $ANTLR start "returnstatement"
	// MathLang.g:102:1: returnstatement : RETURN expression ';' ;
	[GrammarRule("returnstatement")]
	private MathLangParser.returnstatement_return returnstatement()
	{
		Enter_returnstatement();
		EnterRule("returnstatement", 27);
		TraceIn("returnstatement", 27);
		MathLangParser.returnstatement_return retval = new MathLangParser.returnstatement_return();
		retval.Start = (IToken)input.LT(1);
		int returnstatement_StartIndex = input.Index;
		object root_0 = null;

		IToken RETURN106=null;
		IToken char_literal108=null;
		MathLangParser.expression_return expression107 = default(MathLangParser.expression_return);

		object RETURN106_tree=null;
		object char_literal108_tree=null;

		try { DebugEnterRule(GrammarFileName, "returnstatement");
		DebugLocation(102, 41);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 27)) { return retval; }
			// MathLang.g:102:16: ( RETURN expression ';' )
			DebugEnterAlt(1);
			// MathLang.g:102:18: RETURN expression ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(102, 24);
			RETURN106=(IToken)Match(input,RETURN,Follow._RETURN_in_returnstatement949); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			RETURN106_tree = (object)adaptor.Create(RETURN106);
			root_0 = (object)adaptor.BecomeRoot(RETURN106_tree, root_0);
			}
			DebugLocation(102, 26);
			PushFollow(Follow._expression_in_returnstatement952);
			expression107=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression107.Tree);
			DebugLocation(102, 40);
			char_literal108=(IToken)Match(input,53,Follow._53_in_returnstatement954); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("returnstatement", 27);
			LeaveRule("returnstatement", 27);
			Leave_returnstatement();
			if (state.backtracking > 0) { Memoize(input, 27, returnstatement_StartIndex); }
		}
		DebugLocation(102, 41);
		} finally { DebugExitRule(GrammarFileName, "returnstatement"); }
		return retval;

	}
	// $ANTLR end "returnstatement"

	public class funcdeclaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_funcdeclaration();
	partial void Leave_funcdeclaration();

	// $ANTLR start "funcdeclaration"
	// MathLang.g:104:1: funcdeclaration : TYPE ID '(' ( paramsdeclaration )? ')' block -> ^( FUNCDECLARATION ID ^( RETURNS TYPE ) ( paramsdeclaration )? block ) ;
	[GrammarRule("funcdeclaration")]
	private MathLangParser.funcdeclaration_return funcdeclaration()
	{
		Enter_funcdeclaration();
		EnterRule("funcdeclaration", 28);
		TraceIn("funcdeclaration", 28);
		MathLangParser.funcdeclaration_return retval = new MathLangParser.funcdeclaration_return();
		retval.Start = (IToken)input.LT(1);
		int funcdeclaration_StartIndex = input.Index;
		object root_0 = null;

		IToken TYPE109=null;
		IToken ID110=null;
		IToken char_literal111=null;
		IToken char_literal113=null;
		MathLangParser.paramsdeclaration_return paramsdeclaration112 = default(MathLangParser.paramsdeclaration_return);
		MathLangParser.block_return block114 = default(MathLangParser.block_return);

		object TYPE109_tree=null;
		object ID110_tree=null;
		object char_literal111_tree=null;
		object char_literal113_tree=null;
		RewriteRuleITokenStream stream_55=new RewriteRuleITokenStream(adaptor,"token 55");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_54=new RewriteRuleITokenStream(adaptor,"token 54");
		RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");
		RewriteRuleSubtreeStream stream_paramsdeclaration=new RewriteRuleSubtreeStream(adaptor,"rule paramsdeclaration");
		RewriteRuleSubtreeStream stream_block=new RewriteRuleSubtreeStream(adaptor,"rule block");
		try { DebugEnterRule(GrammarFileName, "funcdeclaration");
		DebugLocation(104, 136);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 28)) { return retval; }
			// MathLang.g:104:16: ( TYPE ID '(' ( paramsdeclaration )? ')' block -> ^( FUNCDECLARATION ID ^( RETURNS TYPE ) ( paramsdeclaration )? block ) )
			DebugEnterAlt(1);
			// MathLang.g:104:18: TYPE ID '(' ( paramsdeclaration )? ')' block
			{
			DebugLocation(104, 18);
			TYPE109=(IToken)Match(input,TYPE,Follow._TYPE_in_funcdeclaration963); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE109);

			DebugLocation(104, 25);
			ID110=(IToken)Match(input,ID,Follow._ID_in_funcdeclaration965); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID110);

			DebugLocation(104, 30);
			char_literal111=(IToken)Match(input,54,Follow._54_in_funcdeclaration968); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_54.Add(char_literal111);

			DebugLocation(104, 32);
			// MathLang.g:104:32: ( paramsdeclaration )?
			int alt23=2;
			try { DebugEnterSubRule(23);
			try { DebugEnterDecision(23, decisionCanBacktrack[23]);
			int LA23_0 = input.LA(1);

			if ((LA23_0==TYPE))
			{
				alt23=1;
			}
			} finally { DebugExitDecision(23); }
			switch (alt23)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: paramsdeclaration
				{
				DebugLocation(104, 32);
				PushFollow(Follow._paramsdeclaration_in_funcdeclaration971);
				paramsdeclaration112=paramsdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_paramsdeclaration.Add(paramsdeclaration112.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(23); }

			DebugLocation(104, 54);
			char_literal113=(IToken)Match(input,55,Follow._55_in_funcdeclaration974); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_55.Add(char_literal113);

			DebugLocation(104, 56);
			PushFollow(Follow._block_in_funcdeclaration977);
			block114=block();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_block.Add(block114.Tree);


			{
			// AST REWRITE
			// elements: block, ID, paramsdeclaration, TYPE
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 104:62: -> ^( FUNCDECLARATION ID ^( RETURNS TYPE ) ( paramsdeclaration )? block )
			{
				DebugLocation(104, 65);
				// MathLang.g:104:65: ^( FUNCDECLARATION ID ^( RETURNS TYPE ) ( paramsdeclaration )? block )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(104, 67);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNCDECLARATION, "FUNCDECLARATION"), root_1);

				DebugLocation(104, 83);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(104, 86);
				// MathLang.g:104:86: ^( RETURNS TYPE )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(104, 88);
				root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(RETURNS, "RETURNS"), root_2);

				DebugLocation(104, 96);
				adaptor.AddChild(root_2, stream_TYPE.NextNode());

				adaptor.AddChild(root_1, root_2);
				}
				DebugLocation(104, 107);
				// MathLang.g:104:107: ( paramsdeclaration )?
				if ( stream_paramsdeclaration.HasNext )
				{
					DebugLocation(104, 107);
					adaptor.AddChild(root_1, stream_paramsdeclaration.NextTree());

				}
				stream_paramsdeclaration.Reset();
				DebugLocation(104, 131);
				adaptor.AddChild(root_1, stream_block.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("funcdeclaration", 28);
			LeaveRule("funcdeclaration", 28);
			Leave_funcdeclaration();
			if (state.backtracking > 0) { Memoize(input, 28, funcdeclaration_StartIndex); }
		}
		DebugLocation(104, 136);
		} finally { DebugExitRule(GrammarFileName, "funcdeclaration"); }
		return retval;

	}
	// $ANTLR end "funcdeclaration"

	public class paramsdeclaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_paramsdeclaration();
	partial void Leave_paramsdeclaration();

	// $ANTLR start "paramsdeclaration"
	// MathLang.g:105:1: paramsdeclaration : ( declarationbody ( ',' declarationbody )* ) -> ^( PARAMETERS ( declarationbody )* ) ;
	[GrammarRule("paramsdeclaration")]
	private MathLangParser.paramsdeclaration_return paramsdeclaration()
	{
		Enter_paramsdeclaration();
		EnterRule("paramsdeclaration", 29);
		TraceIn("paramsdeclaration", 29);
		MathLangParser.paramsdeclaration_return retval = new MathLangParser.paramsdeclaration_return();
		retval.Start = (IToken)input.LT(1);
		int paramsdeclaration_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal116=null;
		MathLangParser.declarationbody_return declarationbody115 = default(MathLangParser.declarationbody_return);
		MathLangParser.declarationbody_return declarationbody117 = default(MathLangParser.declarationbody_return);

		object char_literal116_tree=null;
		RewriteRuleITokenStream stream_56=new RewriteRuleITokenStream(adaptor,"token 56");
		RewriteRuleSubtreeStream stream_declarationbody=new RewriteRuleSubtreeStream(adaptor,"rule declarationbody");
		try { DebugEnterRule(GrammarFileName, "paramsdeclaration");
		DebugLocation(105, 102);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 29)) { return retval; }
			// MathLang.g:105:18: ( ( declarationbody ( ',' declarationbody )* ) -> ^( PARAMETERS ( declarationbody )* ) )
			DebugEnterAlt(1);
			// MathLang.g:105:20: ( declarationbody ( ',' declarationbody )* )
			{
			DebugLocation(105, 20);
			// MathLang.g:105:20: ( declarationbody ( ',' declarationbody )* )
			DebugEnterAlt(1);
			// MathLang.g:105:22: declarationbody ( ',' declarationbody )*
			{
			DebugLocation(105, 22);
			PushFollow(Follow._declarationbody_in_paramsdeclaration1010);
			declarationbody115=declarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declarationbody.Add(declarationbody115.Tree);
			DebugLocation(105, 38);
			// MathLang.g:105:38: ( ',' declarationbody )*
			try { DebugEnterSubRule(24);
			while (true)
			{
				int alt24=2;
				try { DebugEnterDecision(24, decisionCanBacktrack[24]);
				int LA24_0 = input.LA(1);

				if ((LA24_0==56))
				{
					alt24=1;
				}


				} finally { DebugExitDecision(24); }
				switch ( alt24 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:105:40: ',' declarationbody
					{
					DebugLocation(105, 43);
					char_literal116=(IToken)Match(input,56,Follow._56_in_paramsdeclaration1014); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_56.Add(char_literal116);

					DebugLocation(105, 45);
					PushFollow(Follow._declarationbody_in_paramsdeclaration1017);
					declarationbody117=declarationbody();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_declarationbody.Add(declarationbody117.Tree);

					}
					break;

				default:
					goto loop24;
				}
			}

			loop24:
				;

			} finally { DebugExitSubRule(24); }


			}



			{
			// AST REWRITE
			// elements: declarationbody
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 105:66: -> ^( PARAMETERS ( declarationbody )* )
			{
				DebugLocation(105, 69);
				// MathLang.g:105:69: ^( PARAMETERS ( declarationbody )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(105, 71);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_1);

				DebugLocation(105, 82);
				// MathLang.g:105:82: ( declarationbody )*
				while ( stream_declarationbody.HasNext )
				{
					DebugLocation(105, 84);
					adaptor.AddChild(root_1, stream_declarationbody.NextTree());

				}
				stream_declarationbody.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("paramsdeclaration", 29);
			LeaveRule("paramsdeclaration", 29);
			Leave_paramsdeclaration();
			if (state.backtracking > 0) { Memoize(input, 29, paramsdeclaration_StartIndex); }
		}
		DebugLocation(105, 102);
		} finally { DebugExitRule(GrammarFileName, "paramsdeclaration"); }
		return retval;

	}
	// $ANTLR end "paramsdeclaration"

	public class funccallbody_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_funccallbody();
	partial void Leave_funccallbody();

	// $ANTLR start "funccallbody"
	// MathLang.g:107:1: funccallbody : ID '(' ( expressioncommalist )? ')' ;
	[GrammarRule("funccallbody")]
	private MathLangParser.funccallbody_return funccallbody()
	{
		Enter_funccallbody();
		EnterRule("funccallbody", 30);
		TraceIn("funccallbody", 30);
		MathLangParser.funccallbody_return retval = new MathLangParser.funccallbody_return();
		retval.Start = (IToken)input.LT(1);
		int funccallbody_StartIndex = input.Index;
		object root_0 = null;

		IToken ID118=null;
		IToken char_literal119=null;
		IToken char_literal121=null;
		MathLangParser.expressioncommalist_return expressioncommalist120 = default(MathLangParser.expressioncommalist_return);

		object ID118_tree=null;
		object char_literal119_tree=null;
		object char_literal121_tree=null;

		try { DebugEnterRule(GrammarFileName, "funccallbody");
		DebugLocation(107, 46);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 30)) { return retval; }
			// MathLang.g:107:13: ( ID '(' ( expressioncommalist )? ')' )
			DebugEnterAlt(1);
			// MathLang.g:107:15: ID '(' ( expressioncommalist )? ')'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(107, 17);
			ID118=(IToken)Match(input,ID,Follow._ID_in_funccallbody1042); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			ID118_tree = (object)adaptor.Create(ID118);
			root_0 = (object)adaptor.BecomeRoot(ID118_tree, root_0);
			}
			DebugLocation(107, 19);
			char_literal119=(IToken)Match(input,54,Follow._54_in_funccallbody1045); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal119_tree = (object)adaptor.Create(char_literal119);
			adaptor.AddChild(root_0, char_literal119_tree);
			}
			DebugLocation(107, 23);
			// MathLang.g:107:23: ( expressioncommalist )?
			int alt25=2;
			try { DebugEnterSubRule(25);
			try { DebugEnterDecision(25, decisionCanBacktrack[25]);
			int LA25_0 = input.LA(1);

			if (((LA25_0>=NUMBER && LA25_0<=CHAR)||LA25_0==SUB||(LA25_0>=NOT && LA25_0<=KNEW)||LA25_0==54))
			{
				alt25=1;
			}
			} finally { DebugExitDecision(25); }
			switch (alt25)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: expressioncommalist
				{
				DebugLocation(107, 23);
				PushFollow(Follow._expressioncommalist_in_funccallbody1047);
				expressioncommalist120=expressioncommalist();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expressioncommalist120.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(25); }

			DebugLocation(107, 44);
			char_literal121=(IToken)Match(input,55,Follow._55_in_funccallbody1050); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal121_tree = (object)adaptor.Create(char_literal121);
			adaptor.AddChild(root_0, char_literal121_tree);
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("funccallbody", 30);
			LeaveRule("funccallbody", 30);
			Leave_funccallbody();
			if (state.backtracking > 0) { Memoize(input, 30, funccallbody_StartIndex); }
		}
		DebugLocation(107, 46);
		} finally { DebugExitRule(GrammarFileName, "funccallbody"); }
		return retval;

	}
	// $ANTLR end "funccallbody"

	public class funccall_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_funccall();
	partial void Leave_funccall();

	// $ANTLR start "funccall"
	// MathLang.g:108:1: funccall : funccallbody ';' ;
	[GrammarRule("funccall")]
	private MathLangParser.funccall_return funccall()
	{
		Enter_funccall();
		EnterRule("funccall", 31);
		TraceIn("funccall", 31);
		MathLangParser.funccall_return retval = new MathLangParser.funccall_return();
		retval.Start = (IToken)input.LT(1);
		int funccall_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal123=null;
		MathLangParser.funccallbody_return funccallbody122 = default(MathLangParser.funccallbody_return);

		object char_literal123_tree=null;

		try { DebugEnterRule(GrammarFileName, "funccall");
		DebugLocation(108, 27);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 31)) { return retval; }
			// MathLang.g:108:9: ( funccallbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:108:11: funccallbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(108, 11);
			PushFollow(Follow._funccallbody_in_funccall1056);
			funccallbody122=funccallbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody122.Tree);
			DebugLocation(108, 27);
			char_literal123=(IToken)Match(input,53,Follow._53_in_funccall1058); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("funccall", 31);
			LeaveRule("funccall", 31);
			Leave_funccall();
			if (state.backtracking > 0) { Memoize(input, 31, funccall_StartIndex); }
		}
		DebugLocation(108, 27);
		} finally { DebugExitRule(GrammarFileName, "funccall"); }
		return retval;

	}
	// $ANTLR end "funccall"

	public class expressioncommalist_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expressioncommalist();
	partial void Leave_expressioncommalist();

	// $ANTLR start "expressioncommalist"
	// MathLang.g:109:1: expressioncommalist : expression ( ',' expression )* -> ^( PARAMETERS ( expression )* ) ;
	[GrammarRule("expressioncommalist")]
	private MathLangParser.expressioncommalist_return expressioncommalist()
	{
		Enter_expressioncommalist();
		EnterRule("expressioncommalist", 32);
		TraceIn("expressioncommalist", 32);
		MathLangParser.expressioncommalist_return retval = new MathLangParser.expressioncommalist_return();
		retval.Start = (IToken)input.LT(1);
		int expressioncommalist_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal125=null;
		MathLangParser.expression_return expression124 = default(MathLangParser.expression_return);
		MathLangParser.expression_return expression126 = default(MathLangParser.expression_return);

		object char_literal125_tree=null;
		RewriteRuleITokenStream stream_56=new RewriteRuleITokenStream(adaptor,"token 56");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "expressioncommalist");
		DebugLocation(109, 83);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 32)) { return retval; }
			// MathLang.g:109:20: ( expression ( ',' expression )* -> ^( PARAMETERS ( expression )* ) )
			DebugEnterAlt(1);
			// MathLang.g:109:22: expression ( ',' expression )*
			{
			DebugLocation(109, 22);
			PushFollow(Follow._expression_in_expressioncommalist1065);
			expression124=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression124.Tree);
			DebugLocation(109, 33);
			// MathLang.g:109:33: ( ',' expression )*
			try { DebugEnterSubRule(26);
			while (true)
			{
				int alt26=2;
				try { DebugEnterDecision(26, decisionCanBacktrack[26]);
				int LA26_0 = input.LA(1);

				if ((LA26_0==56))
				{
					alt26=1;
				}


				} finally { DebugExitDecision(26); }
				switch ( alt26 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:109:35: ',' expression
					{
					DebugLocation(109, 38);
					char_literal125=(IToken)Match(input,56,Follow._56_in_expressioncommalist1069); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_56.Add(char_literal125);

					DebugLocation(109, 40);
					PushFollow(Follow._expression_in_expressioncommalist1072);
					expression126=expression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_expression.Add(expression126.Tree);

					}
					break;

				default:
					goto loop26;
				}
			}

			loop26:
				;

			} finally { DebugExitSubRule(26); }



			{
			// AST REWRITE
			// elements: expression
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 109:53: -> ^( PARAMETERS ( expression )* )
			{
				DebugLocation(109, 56);
				// MathLang.g:109:56: ^( PARAMETERS ( expression )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(109, 58);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_1);

				DebugLocation(109, 69);
				// MathLang.g:109:69: ( expression )*
				while ( stream_expression.HasNext )
				{
					DebugLocation(109, 70);
					adaptor.AddChild(root_1, stream_expression.NextTree());

				}
				stream_expression.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expressioncommalist", 32);
			LeaveRule("expressioncommalist", 32);
			Leave_expressioncommalist();
			if (state.backtracking > 0) { Memoize(input, 32, expressioncommalist_StartIndex); }
		}
		DebugLocation(109, 83);
		} finally { DebugExitRule(GrammarFileName, "expressioncommalist"); }
		return retval;

	}
	// $ANTLR end "expressioncommalist"

	public class newexpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_newexpression();
	partial void Leave_newexpression();

	// $ANTLR start "newexpression"
	// MathLang.g:112:1: newexpression : ( ( KNEW TYPE0 SQRBL NUMBER SQRBR NUMBER -> ^( NEWWORD TYPE0 NUMBER ) ) | ( KNEW TYPE0 '()' -> ^( NEWVAR TYPE0 ) ) );
	[GrammarRule("newexpression")]
	private MathLangParser.newexpression_return newexpression()
	{
		Enter_newexpression();
		EnterRule("newexpression", 33);
		TraceIn("newexpression", 33);
		MathLangParser.newexpression_return retval = new MathLangParser.newexpression_return();
		retval.Start = (IToken)input.LT(1);
		int newexpression_StartIndex = input.Index;
		object root_0 = null;

		IToken KNEW127=null;
		IToken TYPE0128=null;
		IToken SQRBL129=null;
		IToken NUMBER130=null;
		IToken SQRBR131=null;
		IToken NUMBER132=null;
		IToken KNEW133=null;
		IToken TYPE0134=null;
		IToken string_literal135=null;

		object KNEW127_tree=null;
		object TYPE0128_tree=null;
		object SQRBL129_tree=null;
		object NUMBER130_tree=null;
		object SQRBR131_tree=null;
		object NUMBER132_tree=null;
		object KNEW133_tree=null;
		object TYPE0134_tree=null;
		object string_literal135_tree=null;
		RewriteRuleITokenStream stream_57=new RewriteRuleITokenStream(adaptor,"token 57");
		RewriteRuleITokenStream stream_SQRBR=new RewriteRuleITokenStream(adaptor,"token SQRBR");
		RewriteRuleITokenStream stream_KNEW=new RewriteRuleITokenStream(adaptor,"token KNEW");
		RewriteRuleITokenStream stream_TYPE0=new RewriteRuleITokenStream(adaptor,"token TYPE0");
		RewriteRuleITokenStream stream_SQRBL=new RewriteRuleITokenStream(adaptor,"token SQRBL");
		RewriteRuleITokenStream stream_NUMBER=new RewriteRuleITokenStream(adaptor,"token NUMBER");

		try { DebugEnterRule(GrammarFileName, "newexpression");
		DebugLocation(112, 40);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 33)) { return retval; }
			// MathLang.g:112:14: ( ( KNEW TYPE0 SQRBL NUMBER SQRBR NUMBER -> ^( NEWWORD TYPE0 NUMBER ) ) | ( KNEW TYPE0 '()' -> ^( NEWVAR TYPE0 ) ) )
			int alt27=2;
			try { DebugEnterDecision(27, decisionCanBacktrack[27]);
			int LA27_0 = input.LA(1);

			if ((LA27_0==KNEW))
			{
				int LA27_1 = input.LA(2);

				if ((LA27_1==TYPE0))
				{
					int LA27_2 = input.LA(3);

					if ((LA27_2==SQRBL))
					{
						alt27=1;
					}
					else if ((LA27_2==57))
					{
						alt27=2;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 27, 2, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 27, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 27, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(27); }
			switch (alt27)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:112:16: ( KNEW TYPE0 SQRBL NUMBER SQRBR NUMBER -> ^( NEWWORD TYPE0 NUMBER ) )
				{
				DebugLocation(112, 16);
				// MathLang.g:112:16: ( KNEW TYPE0 SQRBL NUMBER SQRBR NUMBER -> ^( NEWWORD TYPE0 NUMBER ) )
				DebugEnterAlt(1);
				// MathLang.g:112:17: KNEW TYPE0 SQRBL NUMBER SQRBR NUMBER
				{
				DebugLocation(112, 17);
				KNEW127=(IToken)Match(input,KNEW,Follow._KNEW_in_newexpression1096); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_KNEW.Add(KNEW127);

				DebugLocation(112, 22);
				TYPE0128=(IToken)Match(input,TYPE0,Follow._TYPE0_in_newexpression1098); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_TYPE0.Add(TYPE0128);

				DebugLocation(112, 33);
				SQRBL129=(IToken)Match(input,SQRBL,Follow._SQRBL_in_newexpression1100); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_SQRBL.Add(SQRBL129);

				DebugLocation(112, 35);
				NUMBER130=(IToken)Match(input,NUMBER,Follow._NUMBER_in_newexpression1103); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_NUMBER.Add(NUMBER130);

				DebugLocation(112, 47);
				SQRBR131=(IToken)Match(input,SQRBR,Follow._SQRBR_in_newexpression1105); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_SQRBR.Add(SQRBR131);

				DebugLocation(112, 49);
				NUMBER132=(IToken)Match(input,NUMBER,Follow._NUMBER_in_newexpression1108); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_NUMBER.Add(NUMBER132);



				{
				// AST REWRITE
				// elements: NUMBER, TYPE0
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 112:56: -> ^( NEWWORD TYPE0 NUMBER )
				{
					DebugLocation(112, 59);
					// MathLang.g:112:59: ^( NEWWORD TYPE0 NUMBER )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(112, 61);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(NEWWORD, "NEWWORD"), root_1);

					DebugLocation(112, 69);
					adaptor.AddChild(root_1, stream_TYPE0.NextNode());
					DebugLocation(112, 75);
					adaptor.AddChild(root_1, stream_NUMBER.NextNode());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:113:5: ( KNEW TYPE0 '()' -> ^( NEWVAR TYPE0 ) )
				{
				DebugLocation(113, 5);
				// MathLang.g:113:5: ( KNEW TYPE0 '()' -> ^( NEWVAR TYPE0 ) )
				DebugEnterAlt(1);
				// MathLang.g:113:6: KNEW TYPE0 '()'
				{
				DebugLocation(113, 6);
				KNEW133=(IToken)Match(input,KNEW,Follow._KNEW_in_newexpression1128); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_KNEW.Add(KNEW133);

				DebugLocation(113, 11);
				TYPE0134=(IToken)Match(input,TYPE0,Follow._TYPE0_in_newexpression1130); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_TYPE0.Add(TYPE0134);

				DebugLocation(113, 17);
				string_literal135=(IToken)Match(input,57,Follow._57_in_newexpression1132); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_57.Add(string_literal135);



				{
				// AST REWRITE
				// elements: TYPE0
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 113:22: -> ^( NEWVAR TYPE0 )
				{
					DebugLocation(113, 25);
					// MathLang.g:113:25: ^( NEWVAR TYPE0 )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(113, 27);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(NEWVAR, "NEWVAR"), root_1);

					DebugLocation(113, 34);
					adaptor.AddChild(root_1, stream_TYPE0.NextNode());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}


				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("newexpression", 33);
			LeaveRule("newexpression", 33);
			Leave_newexpression();
			if (state.backtracking > 0) { Memoize(input, 33, newexpression_StartIndex); }
		}
		DebugLocation(113, 40);
		} finally { DebugExitRule(GrammarFileName, "newexpression"); }
		return retval;

	}
	// $ANTLR end "newexpression"

	public class block_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_block();
	partial void Leave_block();

	// $ANTLR start "block"
	// MathLang.g:115:1: block : '{' statementlist '}' ;
	[GrammarRule("block")]
	private MathLangParser.block_return block()
	{
		Enter_block();
		EnterRule("block", 34);
		TraceIn("block", 34);
		MathLangParser.block_return retval = new MathLangParser.block_return();
		retval.Start = (IToken)input.LT(1);
		int block_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal136=null;
		IToken char_literal138=null;
		MathLangParser.statementlist_return statementlist137 = default(MathLangParser.statementlist_return);

		object char_literal136_tree=null;
		object char_literal138_tree=null;

		try { DebugEnterRule(GrammarFileName, "block");
		DebugLocation(115, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 34)) { return retval; }
			// MathLang.g:115:6: ( '{' statementlist '}' )
			DebugEnterAlt(1);
			// MathLang.g:115:8: '{' statementlist '}'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(115, 11);
			char_literal136=(IToken)Match(input,58,Follow._58_in_block1148); if (state.failed) return retval;
			DebugLocation(115, 13);
			PushFollow(Follow._statementlist_in_block1151);
			statementlist137=statementlist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementlist137.Tree);
			DebugLocation(115, 30);
			char_literal138=(IToken)Match(input,59,Follow._59_in_block1153); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("block", 34);
			LeaveRule("block", 34);
			Leave_block();
			if (state.backtracking > 0) { Memoize(input, 34, block_StartIndex); }
		}
		DebugLocation(115, 30);
		} finally { DebugExitRule(GrammarFileName, "block"); }
		return retval;

	}
	// $ANTLR end "block"

	public class statementlist_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_statementlist();
	partial void Leave_statementlist();

	// $ANTLR start "statementlist"
	// MathLang.g:117:1: statementlist : ( statement )* -> ^( BLOCK ( statement )* ) ;
	[GrammarRule("statementlist")]
	private MathLangParser.statementlist_return statementlist()
	{
		Enter_statementlist();
		EnterRule("statementlist", 35);
		TraceIn("statementlist", 35);
		MathLangParser.statementlist_return retval = new MathLangParser.statementlist_return();
		retval.Start = (IToken)input.LT(1);
		int statementlist_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.statement_return statement139 = default(MathLangParser.statement_return);

		RewriteRuleSubtreeStream stream_statement=new RewriteRuleSubtreeStream(adaptor,"rule statement");
		try { DebugEnterRule(GrammarFileName, "statementlist");
		DebugLocation(117, 49);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 35)) { return retval; }
			// MathLang.g:117:14: ( ( statement )* -> ^( BLOCK ( statement )* ) )
			DebugEnterAlt(1);
			// MathLang.g:117:16: ( statement )*
			{
			DebugLocation(117, 16);
			// MathLang.g:117:16: ( statement )*
			try { DebugEnterSubRule(28);
			while (true)
			{
				int alt28=2;
				try { DebugEnterDecision(28, decisionCanBacktrack[28]);
				int LA28_0 = input.LA(1);

				if ((LA28_0==IF||LA28_0==FOR||(LA28_0>=RETURN && LA28_0<=WHILE)||LA28_0==ID||(LA28_0>=TYPE && LA28_0<=TYPE0)))
				{
					alt28=1;
				}


				} finally { DebugExitDecision(28); }
				switch ( alt28 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: statement
					{
					DebugLocation(117, 16);
					PushFollow(Follow._statement_in_statementlist1161);
					statement139=statement();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_statement.Add(statement139.Tree);

					}
					break;

				default:
					goto loop28;
				}
			}

			loop28:
				;

			} finally { DebugExitSubRule(28); }



			{
			// AST REWRITE
			// elements: statement
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 117:27: -> ^( BLOCK ( statement )* )
			{
				DebugLocation(117, 30);
				// MathLang.g:117:30: ^( BLOCK ( statement )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(117, 32);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

				DebugLocation(117, 38);
				// MathLang.g:117:38: ( statement )*
				while ( stream_statement.HasNext )
				{
					DebugLocation(117, 38);
					adaptor.AddChild(root_1, stream_statement.NextTree());

				}
				stream_statement.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("statementlist", 35);
			LeaveRule("statementlist", 35);
			Leave_statementlist();
			if (state.backtracking > 0) { Memoize(input, 35, statementlist_StartIndex); }
		}
		DebugLocation(117, 49);
		} finally { DebugExitRule(GrammarFileName, "statementlist"); }
		return retval;

	}
	// $ANTLR end "statementlist"

	partial void Enter_synpred13_MathLang_fragment();
	partial void Leave_synpred13_MathLang_fragment();

	// $ANTLR start synpred13_MathLang
	public void synpred13_MathLang_fragment()
	{
		Enter_synpred13_MathLang_fragment();
		EnterRule("synpred13_MathLang_fragment", 48);
		TraceIn("synpred13_MathLang_fragment", 48);
		try
		{
			// MathLang.g:64:5: ( funccallbody )
			DebugEnterAlt(1);
			// MathLang.g:64:5: funccallbody
			{
			DebugLocation(64, 5);
			PushFollow(Follow._funccallbody_in_synpred13_MathLang436);
			funccallbody();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred13_MathLang_fragment", 48);
			LeaveRule("synpred13_MathLang_fragment", 48);
			Leave_synpred13_MathLang_fragment();
		}
	}
	// $ANTLR end synpred13_MathLang

	partial void Enter_synpred14_MathLang_fragment();
	partial void Leave_synpred14_MathLang_fragment();

	// $ANTLR start synpred14_MathLang
	public void synpred14_MathLang_fragment()
	{
		Enter_synpred14_MathLang_fragment();
		EnterRule("synpred14_MathLang_fragment", 49);
		TraceIn("synpred14_MathLang_fragment", 49);
		try
		{
			// MathLang.g:65:5: ( boolexpression )
			DebugEnterAlt(1);
			// MathLang.g:65:5: boolexpression
			{
			DebugLocation(65, 5);
			PushFollow(Follow._boolexpression_in_synpred14_MathLang442);
			boolexpression();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred14_MathLang_fragment", 49);
			LeaveRule("synpred14_MathLang_fragment", 49);
			Leave_synpred14_MathLang_fragment();
		}
	}
	// $ANTLR end synpred14_MathLang

	partial void Enter_synpred26_MathLang_fragment();
	partial void Leave_synpred26_MathLang_fragment();

	// $ANTLR start synpred26_MathLang
	public void synpred26_MathLang_fragment()
	{
		Enter_synpred26_MathLang_fragment();
		EnterRule("synpred26_MathLang_fragment", 61);
		TraceIn("synpred26_MathLang_fragment", 61);
		try
		{
			// MathLang.g:82:16: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )
			DebugEnterAlt(1);
			// MathLang.g:82:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
			{
			DebugLocation(82, 16);
			if ((input.LA(1)>=GREQ && input.LA(1)<=LS))
			{
				input.Consume();
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}

			DebugLocation(82, 53);
			PushFollow(Follow._add_in_synpred26_MathLang658);
			add();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred26_MathLang_fragment", 61);
			LeaveRule("synpred26_MathLang_fragment", 61);
			Leave_synpred26_MathLang_fragment();
		}
	}
	// $ANTLR end synpred26_MathLang

	partial void Enter_synpred35_MathLang_fragment();
	partial void Leave_synpred35_MathLang_fragment();

	// $ANTLR start synpred35_MathLang
	public void synpred35_MathLang_fragment()
	{
		Enter_synpred35_MathLang_fragment();
		EnterRule("synpred35_MathLang_fragment", 70);
		TraceIn("synpred35_MathLang_fragment", 70);
		try
		{
			// MathLang.g:94:22: ( '(' boolterm ')' )
			DebugEnterAlt(1);
			// MathLang.g:94:22: '(' boolterm ')'
			{
			DebugLocation(94, 22);
			Match(input,54,Follow._54_in_synpred35_MathLang818); if (state.failed) return;
			DebugLocation(94, 27);
			PushFollow(Follow._boolterm_in_synpred35_MathLang821);
			boolterm();
			PopFollow();
			if (state.failed) return;
			DebugLocation(94, 36);
			Match(input,55,Follow._55_in_synpred35_MathLang823); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred35_MathLang_fragment", 70);
			LeaveRule("synpred35_MathLang_fragment", 70);
			Leave_synpred35_MathLang_fragment();
		}
	}
	// $ANTLR end synpred35_MathLang

	partial void Enter_synpred40_MathLang_fragment();
	partial void Leave_synpred40_MathLang_fragment();

	// $ANTLR start synpred40_MathLang
	public void synpred40_MathLang_fragment()
	{
		Enter_synpred40_MathLang_fragment();
		EnterRule("synpred40_MathLang_fragment", 75);
		TraceIn("synpred40_MathLang_fragment", 75);
		try
		{
			// MathLang.g:99:64: ( ELSE ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:99:64: ELSE ( block | statement )
			{
			DebugLocation(99, 64);
			Match(input,ELSE,Follow._ELSE_in_synpred40_MathLang875); if (state.failed) return;
			DebugLocation(99, 70);
			// MathLang.g:99:70: ( block | statement )
			int alt30=2;
			try { DebugEnterSubRule(30);
			try { DebugEnterDecision(30, decisionCanBacktrack[30]);
			int LA30_0 = input.LA(1);

			if ((LA30_0==58))
			{
				alt30=1;
			}
			else if ((LA30_0==IF||LA30_0==FOR||(LA30_0>=RETURN && LA30_0<=WHILE)||LA30_0==ID||(LA30_0>=TYPE && LA30_0<=TYPE0)))
			{
				alt30=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				NoViableAltException nvae = new NoViableAltException("", 30, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(30); }
			switch (alt30)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:99:71: block
				{
				DebugLocation(99, 71);
				PushFollow(Follow._block_in_synpred40_MathLang879);
				block();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:99:79: statement
				{
				DebugLocation(99, 79);
				PushFollow(Follow._statement_in_synpred40_MathLang883);
				statement();
				PopFollow();
				if (state.failed) return;

				}
				break;

			}
			} finally { DebugExitSubRule(30); }


			}

		}
		finally
		{
			TraceOut("synpred40_MathLang_fragment", 75);
			LeaveRule("synpred40_MathLang_fragment", 75);
			Leave_synpred40_MathLang_fragment();
		}
	}
	// $ANTLR end synpred40_MathLang
	#endregion Rules

	#region Synpreds
	private bool EvaluatePredicate(System.Action fragment)
	{
		bool success = false;
		state.backtracking++;
		try { DebugBeginBacktrack(state.backtracking);
		int start = input.Mark();
		try
		{
			fragment();
		}
		catch ( RecognitionException re )
		{
			System.Console.Error.WriteLine("impossible: "+re);
		}
		success = !state.failed;
		input.Rewind(start);
		} finally { DebugEndBacktrack(state.backtracking, success); }
		state.backtracking--;
		state.failed=false;
		return success;
	}
	#endregion Synpreds


	#region DFA
	DFA1 dfa1;
	DFA3 dfa3;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa1 = new DFA1( this );
		dfa3 = new DFA3( this, SpecialStateTransition3 );
	}

	private class DFA1 : DFA
	{
		private const string DFA1_eotS =
			"\xC\xFFFF";
		private const string DFA1_eofS =
			"\xC\xFFFF";
		private const string DFA1_minS =
			"\x1\x7\x1\x18\x1\xFFFF\x1\x1C\x4\xFFFF\x1\x1C\x3\xFFFF";
		private const string DFA1_maxS =
			"\x1\x1B\x1\x18\x1\xFFFF\x1\x36\x4\xFFFF\x1\x36\x3\xFFFF";
		private const string DFA1_acceptS =
			"\x2\xFFFF\x1\x1\x1\xFFFF\x1\x3\x1\x4\x1\x5\x1\x7\x1\xFFFF\x1\x2\x1\x8"+
			"\x1\x6";
		private const string DFA1_specialS =
			"\xC\xFFFF}>";
		private static readonly string[] DFA1_transitionS =
			{
				"\x1\x4\x1\xFFFF\x1\x6\x1\xFFFF\x1\x7\x1\x5\xB\xFFFF\x1\x3\x1\xFFFF"+
				"\x1\x1\x1\x2",
				"\x1\x8",
				"",
				"\x1\x9\x10\xFFFF\x1\x9\x8\xFFFF\x1\xA",
				"",
				"",
				"",
				"",
				"\x1\x2\x18\xFFFF\x1\x2\x1\xB",
				"",
				"",
				""
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

		public override string Description { get { return "46:12: ( declaration | assignment | ifstatement | whilestatement | forstatement | funcdeclaration | returnstatement | funccall )"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA3 : DFA
	{
		private const string DFA3_eotS =
			"\xC\xFFFF";
		private const string DFA3_eofS =
			"\xC\xFFFF";
		private const string DFA3_minS =
			"\x1\x17\x1\xFFFF\x1\x0\x1\xFFFF\x1\x0\x2\xFFFF\x3\x0\x2\xFFFF";
		private const string DFA3_maxS =
			"\x1\x36\x1\xFFFF\x1\x0\x1\xFFFF\x1\x0\x2\xFFFF\x3\x0\x2\xFFFF";
		private const string DFA3_acceptS =
			"\x1\xFFFF\x1\x1\x1\xFFFF\x1\x3\x6\xFFFF\x1\x2\x1\x4";
		private const string DFA3_specialS =
			"\x2\xFFFF\x1\x0\x1\xFFFF\x1\x1\x2\xFFFF\x1\x2\x1\x3\x1\x4\x2\xFFFF}>";
		private static readonly string[] DFA3_transitionS =
			{
				"\x1\x8\x1\x2\x1\x9\x4\xFFFF\x1\x7\xA\xFFFF\x3\x3\x1\x1\x9\xFFFF\x1"+
				"\x4",
				"",
				"\x1\xFFFF",
				"",
				"\x1\xFFFF",
				"",
				"",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"",
				""
			};

		private static readonly short[] DFA3_eot = DFA.UnpackEncodedString(DFA3_eotS);
		private static readonly short[] DFA3_eof = DFA.UnpackEncodedString(DFA3_eofS);
		private static readonly char[] DFA3_min = DFA.UnpackEncodedStringToUnsignedChars(DFA3_minS);
		private static readonly char[] DFA3_max = DFA.UnpackEncodedStringToUnsignedChars(DFA3_maxS);
		private static readonly short[] DFA3_accept = DFA.UnpackEncodedString(DFA3_acceptS);
		private static readonly short[] DFA3_special = DFA.UnpackEncodedString(DFA3_specialS);
		private static readonly short[][] DFA3_transition;

		static DFA3()
		{
			int numStates = DFA3_transitionS.Length;
			DFA3_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA3_transition[i] = DFA.UnpackEncodedString(DFA3_transitionS[i]);
			}
		}

		public DFA3( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 3;
			this.eot = DFA3_eot;
			this.eof = DFA3_eof;
			this.min = DFA3_min;
			this.max = DFA3_max;
			this.accept = DFA3_accept;
			this.special = DFA3_special;
			this.transition = DFA3_transition;
		}

		public override string Description { get { return "62:1: expression : ( newexpression | funccallbody | boolexpression | mathexpression );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition3(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA3_2 = input.LA(1);


				int index3_2 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred13_MathLang_fragment)) ) {s = 10;}

				else if ( (EvaluatePredicate(synpred14_MathLang_fragment)) ) {s = 3;}

				else if ( (true) ) {s = 11;}


				input.Seek(index3_2);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA3_4 = input.LA(1);


				int index3_4 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred14_MathLang_fragment)) ) {s = 3;}

				else if ( (true) ) {s = 11;}


				input.Seek(index3_4);
				if ( s>=0 ) return s;
				break;
			case 2:
				int LA3_7 = input.LA(1);


				int index3_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred14_MathLang_fragment)) ) {s = 3;}

				else if ( (true) ) {s = 11;}


				input.Seek(index3_7);
				if ( s>=0 ) return s;
				break;
			case 3:
				int LA3_8 = input.LA(1);


				int index3_8 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred14_MathLang_fragment)) ) {s = 3;}

				else if ( (true) ) {s = 11;}


				input.Seek(index3_8);
				if ( s>=0 ) return s;
				break;
			case 4:
				int LA3_9 = input.LA(1);


				int index3_9 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred14_MathLang_fragment)) ) {s = 3;}

				else if ( (true) ) {s = 11;}


				input.Seek(index3_9);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 3, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}

	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _statementlist_in_execute326 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_execute328 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declaration_in_statement339 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assignment_in_statement345 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ifstatement_in_statement350 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _whilestatement_in_statement355 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _forstatement_in_statement360 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funcdeclaration_in_statement365 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _returnstatement_in_statement370 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccall_in_statement375 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NUMBER_in_number386 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_number392 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_number398 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CHAR_in_number404 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrayelement_in_number410 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _term_in_mathexpression416 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _newexpression_in_expression430 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_expression436 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolexpression_in_expression442 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathexpression_in_expression448 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_arrayelement460 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _SQRBL_in_arrayelement462 = new BitSet(new ulong[]{0x3800000UL});
		public static readonly BitSet _number_in_arrayelement464 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _SQRBR_in_arrayelement466 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declarationbody_in_declaration484 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _53_in_declaration486 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _longdeclaration_in_declaration494 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_declarationbody501 = new BitSet(new ulong[]{0x1000000UL});
		public static readonly BitSet _ID_in_declarationbody503 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _longdeclarationbody_in_longdeclaration520 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _53_in_longdeclaration522 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE0_in_longdeclarationbody531 = new BitSet(new ulong[]{0x1000000UL});
		public static readonly BitSet _ID_in_longdeclarationbody533 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _ASSIGN_in_longdeclarationbody535 = new BitSet(new ulong[]{0x401E0043800000UL});
		public static readonly BitSet _expression_in_longdeclarationbody537 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_longdeclarationbody558 = new BitSet(new ulong[]{0x1000000UL});
		public static readonly BitSet _ID_in_longdeclarationbody560 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _ASSIGN_in_longdeclarationbody562 = new BitSet(new ulong[]{0x401E0043800000UL});
		public static readonly BitSet _expression_in_longdeclarationbody564 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mul_in_add585 = new BitSet(new ulong[]{0x60000002UL});
		public static readonly BitSet _set_in_add589 = new BitSet(new ulong[]{0x400E0043800000UL});
		public static readonly BitSet _mul_in_add598 = new BitSet(new ulong[]{0x60000002UL});
		public static readonly BitSet _group_in_mul607 = new BitSet(new ulong[]{0x180000002UL});
		public static readonly BitSet _set_in_mul611 = new BitSet(new ulong[]{0x400E0043800000UL});
		public static readonly BitSet _group_in_mul620 = new BitSet(new ulong[]{0x180000002UL});
		public static readonly BitSet _add_in_compare628 = new BitSet(new ulong[]{0x7E00000002UL});
		public static readonly BitSet _set_in_compare632 = new BitSet(new ulong[]{0x400E0043800000UL});
		public static readonly BitSet _add_in_compare658 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _add_in_term669 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _SUB_in_group676 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _54_in_group681 = new BitSet(new ulong[]{0x401E0043800000UL});
		public static readonly BitSet _term_in_group684 = new BitSet(new ulong[]{0x80000000000000UL});
		public static readonly BitSet _55_in_group686 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _number_in_group691 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assignmentbody_in_assignment698 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _53_in_assignment700 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_assignmentbody708 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _ASSIGN_in_assignmentbody710 = new BitSet(new ulong[]{0x401E0043800000UL});
		public static readonly BitSet _expression_in_assignmentbody712 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrayelement_in_assignmentbody731 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _ASSIGN_in_assignmentbody733 = new BitSet(new ulong[]{0x401E0043800000UL});
		public static readonly BitSet _expression_in_assignmentbody735 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolterm_in_boolexpression753 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _or_in_boolterm760 = new BitSet(new ulong[]{0x1800000002UL});
		public static readonly BitSet _set_in_boolterm764 = new BitSet(new ulong[]{0x400E0043800000UL});
		public static readonly BitSet _or_in_boolterm773 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _and_in_or782 = new BitSet(new ulong[]{0x8000000002UL});
		public static readonly BitSet _OR_in_or785 = new BitSet(new ulong[]{0x400E0043800000UL});
		public static readonly BitSet _and_in_or788 = new BitSet(new ulong[]{0x8000000002UL});
		public static readonly BitSet _boolgroup_in_and796 = new BitSet(new ulong[]{0x10000000002UL});
		public static readonly BitSet _AND_in_and799 = new BitSet(new ulong[]{0x400E0043800000UL});
		public static readonly BitSet _boolgroup_in_and802 = new BitSet(new ulong[]{0x10000000002UL});
		public static readonly BitSet _NOT_in_boolgroup811 = new BitSet(new ulong[]{0x400E0043800000UL});
		public static readonly BitSet _54_in_boolgroup818 = new BitSet(new ulong[]{0x400E0043800000UL});
		public static readonly BitSet _boolterm_in_boolgroup821 = new BitSet(new ulong[]{0x80000000000000UL});
		public static readonly BitSet _55_in_boolgroup823 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolvar_in_boolgroup828 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TRUE_in_boolvar836 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FALSE_in_boolvar842 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _compare_in_boolvar848 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_ifstatement855 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _54_in_ifstatement858 = new BitSet(new ulong[]{0x400E0043800000UL});
		public static readonly BitSet _boolexpression_in_ifstatement861 = new BitSet(new ulong[]{0x80000000000000UL});
		public static readonly BitSet _55_in_ifstatement863 = new BitSet(new ulong[]{0x40000000F801A80UL});
		public static readonly BitSet _block_in_ifstatement867 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement871 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _ELSE_in_ifstatement875 = new BitSet(new ulong[]{0x40000000F801A80UL});
		public static readonly BitSet _block_in_ifstatement879 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement883 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _WHILE_in_whilestatement893 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _54_in_whilestatement896 = new BitSet(new ulong[]{0x400E0043800000UL});
		public static readonly BitSet _boolexpression_in_whilestatement899 = new BitSet(new ulong[]{0x80000000000000UL});
		public static readonly BitSet _55_in_whilestatement901 = new BitSet(new ulong[]{0x40000000F801A80UL});
		public static readonly BitSet _block_in_whilestatement905 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_whilestatement909 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_forstatement916 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _54_in_forstatement919 = new BitSet(new ulong[]{0xC000000UL});
		public static readonly BitSet _longdeclarationbody_in_forstatement922 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _53_in_forstatement924 = new BitSet(new ulong[]{0x400E0043800000UL});
		public static readonly BitSet _boolexpression_in_forstatement927 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _53_in_forstatement929 = new BitSet(new ulong[]{0x3800000UL});
		public static readonly BitSet _assignmentbody_in_forstatement932 = new BitSet(new ulong[]{0x80000000000000UL});
		public static readonly BitSet _55_in_forstatement934 = new BitSet(new ulong[]{0x40000000F801A80UL});
		public static readonly BitSet _block_in_forstatement938 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_forstatement942 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _RETURN_in_returnstatement949 = new BitSet(new ulong[]{0x401E0043800000UL});
		public static readonly BitSet _expression_in_returnstatement952 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _53_in_returnstatement954 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_funcdeclaration963 = new BitSet(new ulong[]{0x1000000UL});
		public static readonly BitSet _ID_in_funcdeclaration965 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _54_in_funcdeclaration968 = new BitSet(new ulong[]{0x80000004000000UL});
		public static readonly BitSet _paramsdeclaration_in_funcdeclaration971 = new BitSet(new ulong[]{0x80000000000000UL});
		public static readonly BitSet _55_in_funcdeclaration974 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _block_in_funcdeclaration977 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declarationbody_in_paramsdeclaration1010 = new BitSet(new ulong[]{0x100000000000002UL});
		public static readonly BitSet _56_in_paramsdeclaration1014 = new BitSet(new ulong[]{0x4000000UL});
		public static readonly BitSet _declarationbody_in_paramsdeclaration1017 = new BitSet(new ulong[]{0x100000000000002UL});
		public static readonly BitSet _ID_in_funccallbody1042 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _54_in_funccallbody1045 = new BitSet(new ulong[]{0xC01E0043800000UL});
		public static readonly BitSet _expressioncommalist_in_funccallbody1047 = new BitSet(new ulong[]{0x80000000000000UL});
		public static readonly BitSet _55_in_funccallbody1050 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_funccall1056 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _53_in_funccall1058 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_expressioncommalist1065 = new BitSet(new ulong[]{0x100000000000002UL});
		public static readonly BitSet _56_in_expressioncommalist1069 = new BitSet(new ulong[]{0x401E0043800000UL});
		public static readonly BitSet _expression_in_expressioncommalist1072 = new BitSet(new ulong[]{0x100000000000002UL});
		public static readonly BitSet _KNEW_in_newexpression1096 = new BitSet(new ulong[]{0x8000000UL});
		public static readonly BitSet _TYPE0_in_newexpression1098 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _SQRBL_in_newexpression1100 = new BitSet(new ulong[]{0x800000UL});
		public static readonly BitSet _NUMBER_in_newexpression1103 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _SQRBR_in_newexpression1105 = new BitSet(new ulong[]{0x800000UL});
		public static readonly BitSet _NUMBER_in_newexpression1108 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _KNEW_in_newexpression1128 = new BitSet(new ulong[]{0x8000000UL});
		public static readonly BitSet _TYPE0_in_newexpression1130 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _57_in_newexpression1132 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _58_in_block1148 = new BitSet(new ulong[]{0xC0000000F801A80UL});
		public static readonly BitSet _statementlist_in_block1151 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_block1153 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_statementlist1161 = new BitSet(new ulong[]{0x40000000F801A82UL});
		public static readonly BitSet _funccallbody_in_synpred13_MathLang436 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolexpression_in_synpred14_MathLang442 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_synpred26_MathLang632 = new BitSet(new ulong[]{0x400E0043800000UL});
		public static readonly BitSet _add_in_synpred26_MathLang658 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _54_in_synpred35_MathLang818 = new BitSet(new ulong[]{0x400E0043800000UL});
		public static readonly BitSet _boolterm_in_synpred35_MathLang821 = new BitSet(new ulong[]{0x80000000000000UL});
		public static readonly BitSet _55_in_synpred35_MathLang823 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ELSE_in_synpred40_MathLang875 = new BitSet(new ulong[]{0x40000000F801A80UL});
		public static readonly BitSet _block_in_synpred40_MathLang879 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_synpred40_MathLang883 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  MathLang 

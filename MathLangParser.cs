// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-10-01 15:37:21

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "UNKNOWN", "PRINT", "INPUT", "IF", "ELSE", "FOR", "FUNCTION", "RETURN", "WHILE", "BLOCK", "PROGRAM", "PARAMS", "NUMBER", "ID", "TYPE", "ASSIGN", "ARRAY", "ADD", "SUB", "MUL", "DIV", "GREQ", "LSEQ", "NEQ", "EQ", "GR", "LS", "OR", "AND", "TRUE", "FALSE", "ACCESS_MODIFIER", "WS", "SL_COMMENT", "ML_COMMENT", "';'", "'('", "')'", "'{'", "'}'"
	};
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

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, true, false, false, false, false, false, false, false, 
				true, false, false, false, true, false, false, false
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
		this.state.ruleMemo = new System.Collections.Generic.Dictionary<int, int>[58+1];

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
	// MathLang.g:35:8: public execute : statementlist EOF ;
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
		DebugLocation(35, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 1)) { return retval; }
			// MathLang.g:35:15: ( statementlist EOF )
			DebugEnterAlt(1);
			// MathLang.g:36:2: statementlist EOF
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(36, 2);
			PushFollow(Follow._statementlist_in_execute259);
			statementlist1=statementlist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementlist1.Tree);
			DebugLocation(36, 19);
			EOF2=(IToken)Match(input,EOF,Follow._EOF_in_execute261); if (state.failed) return retval;

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
		DebugLocation(37, 0);
		} finally { DebugExitRule(GrammarFileName, "execute"); }
		return retval;

	}
	// $ANTLR end "execute"

	public class statementlist_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_statementlist();
	partial void Leave_statementlist();

	// $ANTLR start "statementlist"
	// MathLang.g:39:1: statementlist : ( statement )* -> ^( BLOCK ( statement )* ) ;
	[GrammarRule("statementlist")]
	private MathLangParser.statementlist_return statementlist()
	{
		Enter_statementlist();
		EnterRule("statementlist", 2);
		TraceIn("statementlist", 2);
		MathLangParser.statementlist_return retval = new MathLangParser.statementlist_return();
		retval.Start = (IToken)input.LT(1);
		int statementlist_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.statement_return statement3 = default(MathLangParser.statement_return);

		RewriteRuleSubtreeStream stream_statement=new RewriteRuleSubtreeStream(adaptor,"rule statement");
		try { DebugEnterRule(GrammarFileName, "statementlist");
		DebugLocation(39, 49);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 2)) { return retval; }
			// MathLang.g:39:14: ( ( statement )* -> ^( BLOCK ( statement )* ) )
			DebugEnterAlt(1);
			// MathLang.g:39:16: ( statement )*
			{
			DebugLocation(39, 16);
			// MathLang.g:39:16: ( statement )*
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, decisionCanBacktrack[1]);
				int LA1_0 = input.LA(1);

				if ((LA1_0==IF||LA1_0==FOR||LA1_0==WHILE||(LA1_0>=ID && LA1_0<=TYPE)))
				{
					alt1=1;
				}


				} finally { DebugExitDecision(1); }
				switch ( alt1 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: statement
					{
					DebugLocation(39, 16);
					PushFollow(Follow._statement_in_statementlist270);
					statement3=statement();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_statement.Add(statement3.Tree);

					}
					break;

				default:
					goto loop1;
				}
			}

			loop1:
				;

			} finally { DebugExitSubRule(1); }



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
			// 39:27: -> ^( BLOCK ( statement )* )
			{
				DebugLocation(39, 30);
				// MathLang.g:39:30: ^( BLOCK ( statement )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(39, 32);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

				DebugLocation(39, 38);
				// MathLang.g:39:38: ( statement )*
				while ( stream_statement.HasNext )
				{
					DebugLocation(39, 38);
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
			TraceOut("statementlist", 2);
			LeaveRule("statementlist", 2);
			Leave_statementlist();
			if (state.backtracking > 0) { Memoize(input, 2, statementlist_StartIndex); }
		}
		DebugLocation(39, 49);
		} finally { DebugExitRule(GrammarFileName, "statementlist"); }
		return retval;

	}
	// $ANTLR end "statementlist"

	public class statement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_statement();
	partial void Leave_statement();

	// $ANTLR start "statement"
	// MathLang.g:41:1: statement : ( declaration | assignment | ifstatement | whilestatement | forstatement ) ;
	[GrammarRule("statement")]
	private MathLangParser.statement_return statement()
	{
		Enter_statement();
		EnterRule("statement", 3);
		TraceIn("statement", 3);
		MathLangParser.statement_return retval = new MathLangParser.statement_return();
		retval.Start = (IToken)input.LT(1);
		int statement_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.declaration_return declaration4 = default(MathLangParser.declaration_return);
		MathLangParser.assignment_return assignment5 = default(MathLangParser.assignment_return);
		MathLangParser.ifstatement_return ifstatement6 = default(MathLangParser.ifstatement_return);
		MathLangParser.whilestatement_return whilestatement7 = default(MathLangParser.whilestatement_return);
		MathLangParser.forstatement_return forstatement8 = default(MathLangParser.forstatement_return);


		try { DebugEnterRule(GrammarFileName, "statement");
		DebugLocation(41, 17);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 3)) { return retval; }
			// MathLang.g:41:10: ( ( declaration | assignment | ifstatement | whilestatement | forstatement ) )
			DebugEnterAlt(1);
			// MathLang.g:41:12: ( declaration | assignment | ifstatement | whilestatement | forstatement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(41, 12);
			// MathLang.g:41:12: ( declaration | assignment | ifstatement | whilestatement | forstatement )
			int alt2=5;
			try { DebugEnterSubRule(2);
			try { DebugEnterDecision(2, decisionCanBacktrack[2]);
			switch (input.LA(1))
			{
			case TYPE:
				{
				alt2=1;
				}
				break;
			case ID:
				{
				alt2=2;
				}
				break;
			case IF:
				{
				alt2=3;
				}
				break;
			case WHILE:
				{
				alt2=4;
				}
				break;
			case FOR:
				{
				alt2=5;
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
				// MathLang.g:42:2: declaration
				{
				DebugLocation(42, 2);
				PushFollow(Follow._declaration_in_statement291);
				declaration4=declaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, declaration4.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:43:4: assignment
				{
				DebugLocation(43, 4);
				PushFollow(Follow._assignment_in_statement297);
				assignment5=assignment();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment5.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:44:4: ifstatement
				{
				DebugLocation(44, 4);
				PushFollow(Follow._ifstatement_in_statement302);
				ifstatement6=ifstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ifstatement6.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:45:4: whilestatement
				{
				DebugLocation(45, 4);
				PushFollow(Follow._whilestatement_in_statement307);
				whilestatement7=whilestatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, whilestatement7.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:46:4: forstatement
				{
				DebugLocation(46, 4);
				PushFollow(Follow._forstatement_in_statement312);
				forstatement8=forstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forstatement8.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(2); }


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
			TraceOut("statement", 3);
			LeaveRule("statement", 3);
			Leave_statement();
			if (state.backtracking > 0) { Memoize(input, 3, statement_StartIndex); }
		}
		DebugLocation(46, 17);
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
	// MathLang.g:48:1: number : ( NUMBER | ID );
	[GrammarRule("number")]
	private MathLangParser.number_return number()
	{
		Enter_number();
		EnterRule("number", 4);
		TraceIn("number", 4);
		MathLangParser.number_return retval = new MathLangParser.number_return();
		retval.Start = (IToken)input.LT(1);
		int number_StartIndex = input.Index;
		object root_0 = null;

		IToken set9=null;

		object set9_tree=null;

		try { DebugEnterRule(GrammarFileName, "number");
		DebugLocation(48, 6);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 4)) { return retval; }
			// MathLang.g:48:8: ( NUMBER | ID )
			DebugEnterAlt(1);
			// MathLang.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(48, 8);
			set9=(IToken)input.LT(1);
			if ((input.LA(1)>=NUMBER && input.LA(1)<=ID))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set9));
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
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
			TraceOut("number", 4);
			LeaveRule("number", 4);
			Leave_number();
			if (state.backtracking > 0) { Memoize(input, 4, number_StartIndex); }
		}
		DebugLocation(49, 6);
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
	// MathLang.g:50:1: mathexpression : term ;
	[GrammarRule("mathexpression")]
	private MathLangParser.mathexpression_return mathexpression()
	{
		Enter_mathexpression();
		EnterRule("mathexpression", 5);
		TraceIn("mathexpression", 5);
		MathLangParser.mathexpression_return retval = new MathLangParser.mathexpression_return();
		retval.Start = (IToken)input.LT(1);
		int mathexpression_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.term_return term10 = default(MathLangParser.term_return);


		try { DebugEnterRule(GrammarFileName, "mathexpression");
		DebugLocation(50, 21);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 5)) { return retval; }
			// MathLang.g:50:15: ( term )
			DebugEnterAlt(1);
			// MathLang.g:50:17: term
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(50, 17);
			PushFollow(Follow._term_in_mathexpression334);
			term10=term();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term10.Tree);

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
			TraceOut("mathexpression", 5);
			LeaveRule("mathexpression", 5);
			Leave_mathexpression();
			if (state.backtracking > 0) { Memoize(input, 5, mathexpression_StartIndex); }
		}
		DebugLocation(50, 21);
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
	// MathLang.g:52:1: expression : ( mathexpression | boolexpression );
	[GrammarRule("expression")]
	private MathLangParser.expression_return expression()
	{
		Enter_expression();
		EnterRule("expression", 6);
		TraceIn("expression", 6);
		MathLangParser.expression_return retval = new MathLangParser.expression_return();
		retval.Start = (IToken)input.LT(1);
		int expression_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.mathexpression_return mathexpression11 = default(MathLangParser.mathexpression_return);
		MathLangParser.boolexpression_return boolexpression12 = default(MathLangParser.boolexpression_return);


		try { DebugEnterRule(GrammarFileName, "expression");
		DebugLocation(52, 19);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 6)) { return retval; }
			// MathLang.g:52:11: ( mathexpression | boolexpression )
			int alt3=2;
			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
			switch (input.LA(1))
			{
			case 40:
				{
				int LA3_1 = input.LA(2);

				if ((EvaluatePredicate(synpred7_MathLang_fragment)))
				{
					alt3=1;
				}
				else if ((true))
				{
					alt3=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 3, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			case NUMBER:
			case ID:
				{
				int LA3_2 = input.LA(2);

				if ((EvaluatePredicate(synpred7_MathLang_fragment)))
				{
					alt3=1;
				}
				else if ((true))
				{
					alt3=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 3, 2, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			case TRUE:
			case FALSE:
				{
				alt3=2;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 3, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(3); }
			switch (alt3)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:52:13: mathexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(52, 13);
				PushFollow(Follow._mathexpression_in_expression342);
				mathexpression11=mathexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mathexpression11.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:53:6: boolexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(53, 6);
				PushFollow(Follow._boolexpression_in_expression349);
				boolexpression12=boolexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression12.Tree);

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
			TraceOut("expression", 6);
			LeaveRule("expression", 6);
			Leave_expression();
			if (state.backtracking > 0) { Memoize(input, 6, expression_StartIndex); }
		}
		DebugLocation(53, 19);
		} finally { DebugExitRule(GrammarFileName, "expression"); }
		return retval;

	}
	// $ANTLR end "expression"

	public class declaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_declaration();
	partial void Leave_declaration();

	// $ANTLR start "declaration"
	// MathLang.g:55:1: declaration : ( TYPE ID ';' | longdeclaration );
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

		IToken TYPE13=null;
		IToken ID14=null;
		IToken char_literal15=null;
		MathLangParser.longdeclaration_return longdeclaration16 = default(MathLangParser.longdeclaration_return);

		object TYPE13_tree=null;
		object ID14_tree=null;
		object char_literal15_tree=null;

		try { DebugEnterRule(GrammarFileName, "declaration");
		DebugLocation(55, 20);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 7)) { return retval; }
			// MathLang.g:55:12: ( TYPE ID ';' | longdeclaration )
			int alt4=2;
			try { DebugEnterDecision(4, decisionCanBacktrack[4]);
			int LA4_0 = input.LA(1);

			if ((LA4_0==TYPE))
			{
				int LA4_1 = input.LA(2);

				if ((LA4_1==ID))
				{
					int LA4_2 = input.LA(3);

					if ((LA4_2==39))
					{
						alt4=1;
					}
					else if ((LA4_2==ASSIGN))
					{
						alt4=2;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 4, 2, input);

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
				// MathLang.g:55:14: TYPE ID ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(55, 18);
				TYPE13=(IToken)Match(input,TYPE,Follow._TYPE_in_declaration356); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				TYPE13_tree = (object)adaptor.Create(TYPE13);
				root_0 = (object)adaptor.BecomeRoot(TYPE13_tree, root_0);
				}
				DebugLocation(55, 20);
				ID14=(IToken)Match(input,ID,Follow._ID_in_declaration359); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				ID14_tree = (object)adaptor.Create(ID14);
				adaptor.AddChild(root_0, ID14_tree);
				}
				DebugLocation(55, 25);
				char_literal15=(IToken)Match(input,39,Follow._39_in_declaration360); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:56:6: longdeclaration
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(56, 6);
				PushFollow(Follow._longdeclaration_in_declaration368);
				longdeclaration16=longdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclaration16.Tree);

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
		DebugLocation(56, 20);
		} finally { DebugExitRule(GrammarFileName, "declaration"); }
		return retval;

	}
	// $ANTLR end "declaration"

	public class longdeclaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_longdeclaration();
	partial void Leave_longdeclaration();

	// $ANTLR start "longdeclaration"
	// MathLang.g:57:1: longdeclaration : TYPE ID ASSIGN expression ';' -> ^( ASSIGN ^( TYPE ID ) expression ) ;
	[GrammarRule("longdeclaration")]
	private MathLangParser.longdeclaration_return longdeclaration()
	{
		Enter_longdeclaration();
		EnterRule("longdeclaration", 8);
		TraceIn("longdeclaration", 8);
		MathLangParser.longdeclaration_return retval = new MathLangParser.longdeclaration_return();
		retval.Start = (IToken)input.LT(1);
		int longdeclaration_StartIndex = input.Index;
		object root_0 = null;

		IToken TYPE17=null;
		IToken ID18=null;
		IToken ASSIGN19=null;
		IToken char_literal21=null;
		MathLangParser.expression_return expression20 = default(MathLangParser.expression_return);

		object TYPE17_tree=null;
		object ID18_tree=null;
		object ASSIGN19_tree=null;
		object char_literal21_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_39=new RewriteRuleITokenStream(adaptor,"token 39");
		RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "longdeclaration");
		DebugLocation(57, 83);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 8)) { return retval; }
			// MathLang.g:57:16: ( TYPE ID ASSIGN expression ';' -> ^( ASSIGN ^( TYPE ID ) expression ) )
			DebugEnterAlt(1);
			// MathLang.g:57:18: TYPE ID ASSIGN expression ';'
			{
			DebugLocation(57, 18);
			TYPE17=(IToken)Match(input,TYPE,Follow._TYPE_in_longdeclaration374); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE17);

			DebugLocation(57, 23);
			ID18=(IToken)Match(input,ID,Follow._ID_in_longdeclaration376); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID18);

			DebugLocation(57, 26);
			ASSIGN19=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclaration378); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN19);

			DebugLocation(57, 33);
			PushFollow(Follow._expression_in_longdeclaration380);
			expression20=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression20.Tree);
			DebugLocation(57, 47);
			char_literal21=(IToken)Match(input,39,Follow._39_in_longdeclaration382); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_39.Add(char_literal21);



			{
			// AST REWRITE
			// elements: expression, TYPE, ASSIGN, ID
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 57:49: -> ^( ASSIGN ^( TYPE ID ) expression )
			{
				DebugLocation(57, 52);
				// MathLang.g:57:52: ^( ASSIGN ^( TYPE ID ) expression )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(57, 54);
				root_1 = (object)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_1);

				DebugLocation(57, 61);
				// MathLang.g:57:61: ^( TYPE ID )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(57, 63);
				root_2 = (object)adaptor.BecomeRoot(stream_TYPE.NextNode(), root_2);

				DebugLocation(57, 68);
				adaptor.AddChild(root_2, stream_ID.NextNode());

				adaptor.AddChild(root_1, root_2);
				}
				DebugLocation(57, 72);
				adaptor.AddChild(root_1, stream_expression.NextTree());

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
			TraceOut("longdeclaration", 8);
			LeaveRule("longdeclaration", 8);
			Leave_longdeclaration();
			if (state.backtracking > 0) { Memoize(input, 8, longdeclaration_StartIndex); }
		}
		DebugLocation(57, 83);
		} finally { DebugExitRule(GrammarFileName, "longdeclaration"); }
		return retval;

	}
	// $ANTLR end "longdeclaration"

	public class declarationbody_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_declarationbody();
	partial void Leave_declarationbody();

	// $ANTLR start "declarationbody"
	// MathLang.g:59:1: declarationbody : TYPE ID ;
	[GrammarRule("declarationbody")]
	private MathLangParser.declarationbody_return declarationbody()
	{
		Enter_declarationbody();
		EnterRule("declarationbody", 9);
		TraceIn("declarationbody", 9);
		MathLangParser.declarationbody_return retval = new MathLangParser.declarationbody_return();
		retval.Start = (IToken)input.LT(1);
		int declarationbody_StartIndex = input.Index;
		object root_0 = null;

		IToken TYPE22=null;
		IToken ID23=null;

		object TYPE22_tree=null;
		object ID23_tree=null;

		try { DebugEnterRule(GrammarFileName, "declarationbody");
		DebugLocation(59, 26);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 9)) { return retval; }
			// MathLang.g:59:16: ( TYPE ID )
			DebugEnterAlt(1);
			// MathLang.g:59:18: TYPE ID
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(59, 22);
			TYPE22=(IToken)Match(input,TYPE,Follow._TYPE_in_declarationbody405); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			TYPE22_tree = (object)adaptor.Create(TYPE22);
			root_0 = (object)adaptor.BecomeRoot(TYPE22_tree, root_0);
			}
			DebugLocation(59, 24);
			ID23=(IToken)Match(input,ID,Follow._ID_in_declarationbody408); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			ID23_tree = (object)adaptor.Create(ID23);
			adaptor.AddChild(root_0, ID23_tree);
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
			TraceOut("declarationbody", 9);
			LeaveRule("declarationbody", 9);
			Leave_declarationbody();
			if (state.backtracking > 0) { Memoize(input, 9, declarationbody_StartIndex); }
		}
		DebugLocation(59, 26);
		} finally { DebugExitRule(GrammarFileName, "declarationbody"); }
		return retval;

	}
	// $ANTLR end "declarationbody"

	public class longdeclarationbody_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_longdeclarationbody();
	partial void Leave_longdeclarationbody();

	// $ANTLR start "longdeclarationbody"
	// MathLang.g:60:1: longdeclarationbody : TYPE ID ASSIGN expression -> ^( ASSIGN ^( TYPE ID ) expression ) ;
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

		IToken TYPE24=null;
		IToken ID25=null;
		IToken ASSIGN26=null;
		MathLangParser.expression_return expression27 = default(MathLangParser.expression_return);

		object TYPE24_tree=null;
		object ID25_tree=null;
		object ASSIGN26_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "longdeclarationbody");
		DebugLocation(60, 83);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 10)) { return retval; }
			// MathLang.g:60:20: ( TYPE ID ASSIGN expression -> ^( ASSIGN ^( TYPE ID ) expression ) )
			DebugEnterAlt(1);
			// MathLang.g:60:22: TYPE ID ASSIGN expression
			{
			DebugLocation(60, 22);
			TYPE24=(IToken)Match(input,TYPE,Follow._TYPE_in_longdeclarationbody415); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE24);

			DebugLocation(60, 27);
			ID25=(IToken)Match(input,ID,Follow._ID_in_longdeclarationbody417); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID25);

			DebugLocation(60, 30);
			ASSIGN26=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclarationbody419); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN26);

			DebugLocation(60, 37);
			PushFollow(Follow._expression_in_longdeclarationbody421);
			expression27=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression27.Tree);


			{
			// AST REWRITE
			// elements: ASSIGN, ID, expression, TYPE
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 60:49: -> ^( ASSIGN ^( TYPE ID ) expression )
			{
				DebugLocation(60, 52);
				// MathLang.g:60:52: ^( ASSIGN ^( TYPE ID ) expression )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(60, 54);
				root_1 = (object)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_1);

				DebugLocation(60, 61);
				// MathLang.g:60:61: ^( TYPE ID )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(60, 63);
				root_2 = (object)adaptor.BecomeRoot(stream_TYPE.NextNode(), root_2);

				DebugLocation(60, 68);
				adaptor.AddChild(root_2, stream_ID.NextNode());

				adaptor.AddChild(root_1, root_2);
				}
				DebugLocation(60, 72);
				adaptor.AddChild(root_1, stream_expression.NextTree());

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
			TraceOut("longdeclarationbody", 10);
			LeaveRule("longdeclarationbody", 10);
			Leave_longdeclarationbody();
			if (state.backtracking > 0) { Memoize(input, 10, longdeclarationbody_StartIndex); }
		}
		DebugLocation(60, 83);
		} finally { DebugExitRule(GrammarFileName, "longdeclarationbody"); }
		return retval;

	}
	// $ANTLR end "longdeclarationbody"

	public class variable_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_variable();
	partial void Leave_variable();

	// $ANTLR start "variable"
	// MathLang.g:62:1: variable : ( TYPE | ARRAY ) ID ;
	[GrammarRule("variable")]
	private MathLangParser.variable_return variable()
	{
		Enter_variable();
		EnterRule("variable", 11);
		TraceIn("variable", 11);
		MathLangParser.variable_return retval = new MathLangParser.variable_return();
		retval.Start = (IToken)input.LT(1);
		int variable_StartIndex = input.Index;
		object root_0 = null;

		IToken set28=null;
		IToken ID29=null;

		object set28_tree=null;
		object ID29_tree=null;

		try { DebugEnterRule(GrammarFileName, "variable");
		DebugLocation(62, 28);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 11)) { return retval; }
			// MathLang.g:62:9: ( ( TYPE | ARRAY ) ID )
			DebugEnterAlt(1);
			// MathLang.g:62:11: ( TYPE | ARRAY ) ID
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(62, 11);
			set28=(IToken)input.LT(1);
			set28=(IToken)input.LT(1);
			if (input.LA(1)==TYPE||input.LA(1)==ARRAY)
			{
				input.Consume();
				if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set28), root_0);
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}

			DebugLocation(62, 27);
			ID29=(IToken)Match(input,ID,Follow._ID_in_variable453); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			ID29_tree = (object)adaptor.Create(ID29);
			adaptor.AddChild(root_0, ID29_tree);
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
			TraceOut("variable", 11);
			LeaveRule("variable", 11);
			Leave_variable();
			if (state.backtracking > 0) { Memoize(input, 11, variable_StartIndex); }
		}
		DebugLocation(62, 28);
		} finally { DebugExitRule(GrammarFileName, "variable"); }
		return retval;

	}
	// $ANTLR end "variable"

	public class add_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_add();
	partial void Leave_add();

	// $ANTLR start "add"
	// MathLang.g:63:1: add : mul ( ( ADD | SUB ) mul )* ;
	[GrammarRule("add")]
	private MathLangParser.add_return add()
	{
		Enter_add();
		EnterRule("add", 12);
		TraceIn("add", 12);
		MathLangParser.add_return retval = new MathLangParser.add_return();
		retval.Start = (IToken)input.LT(1);
		int add_StartIndex = input.Index;
		object root_0 = null;

		IToken set31=null;
		MathLangParser.mul_return mul30 = default(MathLangParser.mul_return);
		MathLangParser.mul_return mul32 = default(MathLangParser.mul_return);

		object set31_tree=null;

		try { DebugEnterRule(GrammarFileName, "add");
		DebugLocation(63, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 12)) { return retval; }
			// MathLang.g:63:4: ( mul ( ( ADD | SUB ) mul )* )
			DebugEnterAlt(1);
			// MathLang.g:63:6: mul ( ( ADD | SUB ) mul )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(63, 6);
			PushFollow(Follow._mul_in_add459);
			mul30=mul();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul30.Tree);
			DebugLocation(63, 10);
			// MathLang.g:63:10: ( ( ADD | SUB ) mul )*
			try { DebugEnterSubRule(5);
			while (true)
			{
				int alt5=2;
				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
				int LA5_0 = input.LA(1);

				if (((LA5_0>=ADD && LA5_0<=SUB)))
				{
					alt5=1;
				}


				} finally { DebugExitDecision(5); }
				switch ( alt5 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:63:12: ( ADD | SUB ) mul
					{
					DebugLocation(63, 12);
					set31=(IToken)input.LT(1);
					set31=(IToken)input.LT(1);
					if ((input.LA(1)>=ADD && input.LA(1)<=SUB))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set31), root_0);
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(63, 25);
					PushFollow(Follow._mul_in_add472);
					mul32=mul();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul32.Tree);

					}
					break;

				default:
					goto loop5;
				}
			}

			loop5:
				;

			} finally { DebugExitSubRule(5); }


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
			TraceOut("add", 12);
			LeaveRule("add", 12);
			Leave_add();
			if (state.backtracking > 0) { Memoize(input, 12, add_StartIndex); }
		}
		DebugLocation(63, 30);
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
	// MathLang.g:64:1: mul : group ( ( MUL | DIV ) group )* ;
	[GrammarRule("mul")]
	private MathLangParser.mul_return mul()
	{
		Enter_mul();
		EnterRule("mul", 13);
		TraceIn("mul", 13);
		MathLangParser.mul_return retval = new MathLangParser.mul_return();
		retval.Start = (IToken)input.LT(1);
		int mul_StartIndex = input.Index;
		object root_0 = null;

		IToken set34=null;
		MathLangParser.group_return group33 = default(MathLangParser.group_return);
		MathLangParser.group_return group35 = default(MathLangParser.group_return);

		object set34_tree=null;

		try { DebugEnterRule(GrammarFileName, "mul");
		DebugLocation(64, 33);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 13)) { return retval; }
			// MathLang.g:64:4: ( group ( ( MUL | DIV ) group )* )
			DebugEnterAlt(1);
			// MathLang.g:64:6: group ( ( MUL | DIV ) group )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(64, 6);
			PushFollow(Follow._group_in_mul481);
			group33=group();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group33.Tree);
			DebugLocation(64, 12);
			// MathLang.g:64:12: ( ( MUL | DIV ) group )*
			try { DebugEnterSubRule(6);
			while (true)
			{
				int alt6=2;
				try { DebugEnterDecision(6, decisionCanBacktrack[6]);
				int LA6_0 = input.LA(1);

				if (((LA6_0>=MUL && LA6_0<=DIV)))
				{
					alt6=1;
				}


				} finally { DebugExitDecision(6); }
				switch ( alt6 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:64:14: ( MUL | DIV ) group
					{
					DebugLocation(64, 14);
					set34=(IToken)input.LT(1);
					set34=(IToken)input.LT(1);
					if ((input.LA(1)>=MUL && input.LA(1)<=DIV))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set34), root_0);
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(64, 27);
					PushFollow(Follow._group_in_mul494);
					group35=group();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group35.Tree);

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
			TraceOut("mul", 13);
			LeaveRule("mul", 13);
			Leave_mul();
			if (state.backtracking > 0) { Memoize(input, 13, mul_StartIndex); }
		}
		DebugLocation(64, 33);
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
	// MathLang.g:65:1: compare : add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )? ;
	[GrammarRule("compare")]
	private MathLangParser.compare_return compare()
	{
		Enter_compare();
		EnterRule("compare", 14);
		TraceIn("compare", 14);
		MathLangParser.compare_return retval = new MathLangParser.compare_return();
		retval.Start = (IToken)input.LT(1);
		int compare_StartIndex = input.Index;
		object root_0 = null;

		IToken set37=null;
		MathLangParser.add_return add36 = default(MathLangParser.add_return);
		MathLangParser.add_return add38 = default(MathLangParser.add_return);

		object set37_tree=null;

		try { DebugEnterRule(GrammarFileName, "compare");
		DebugLocation(65, 60);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 14)) { return retval; }
			// MathLang.g:65:8: ( add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )? )
			DebugEnterAlt(1);
			// MathLang.g:65:10: add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(65, 10);
			PushFollow(Follow._add_in_compare502);
			add36=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add36.Tree);
			DebugLocation(65, 14);
			// MathLang.g:65:14: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
			int alt7=2;
			try { DebugEnterSubRule(7);
			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
			int LA7_0 = input.LA(1);

			if (((LA7_0>=GREQ && LA7_0<=LS)))
			{
				alt7=1;
			}
			} finally { DebugExitDecision(7); }
			switch (alt7)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:65:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
				{
				DebugLocation(65, 16);
				set37=(IToken)input.LT(1);
				set37=(IToken)input.LT(1);
				if ((input.LA(1)>=GREQ && input.LA(1)<=LS))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set37), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(65, 53);
				PushFollow(Follow._add_in_compare532);
				add38=add();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add38.Tree);

				}
				break;

			}
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
			TraceOut("compare", 14);
			LeaveRule("compare", 14);
			Leave_compare();
			if (state.backtracking > 0) { Memoize(input, 14, compare_StartIndex); }
		}
		DebugLocation(65, 60);
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
	// MathLang.g:67:1: term : add ;
	[GrammarRule("term")]
	private MathLangParser.term_return term()
	{
		Enter_term();
		EnterRule("term", 15);
		TraceIn("term", 15);
		MathLangParser.term_return retval = new MathLangParser.term_return();
		retval.Start = (IToken)input.LT(1);
		int term_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.add_return add39 = default(MathLangParser.add_return);


		try { DebugEnterRule(GrammarFileName, "term");
		DebugLocation(67, 9);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 15)) { return retval; }
			// MathLang.g:67:5: ( add )
			DebugEnterAlt(1);
			// MathLang.g:67:7: add
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(67, 7);
			PushFollow(Follow._add_in_term544);
			add39=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add39.Tree);

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
			TraceOut("term", 15);
			LeaveRule("term", 15);
			Leave_term();
			if (state.backtracking > 0) { Memoize(input, 15, term_StartIndex); }
		}
		DebugLocation(67, 9);
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
	// MathLang.g:69:1: group : ( '(' term ')' | number );
	[GrammarRule("group")]
	private MathLangParser.group_return group()
	{
		Enter_group();
		EnterRule("group", 16);
		TraceIn("group", 16);
		MathLangParser.group_return retval = new MathLangParser.group_return();
		retval.Start = (IToken)input.LT(1);
		int group_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal40=null;
		IToken char_literal42=null;
		MathLangParser.term_return term41 = default(MathLangParser.term_return);
		MathLangParser.number_return number43 = default(MathLangParser.number_return);

		object char_literal40_tree=null;
		object char_literal42_tree=null;

		try { DebugEnterRule(GrammarFileName, "group");
		DebugLocation(69, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 16)) { return retval; }
			// MathLang.g:69:6: ( '(' term ')' | number )
			int alt8=2;
			try { DebugEnterDecision(8, decisionCanBacktrack[8]);
			int LA8_0 = input.LA(1);

			if ((LA8_0==40))
			{
				alt8=1;
			}
			else if (((LA8_0>=NUMBER && LA8_0<=ID)))
			{
				alt8=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 8, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(8); }
			switch (alt8)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:69:8: '(' term ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(69, 11);
				char_literal40=(IToken)Match(input,40,Follow._40_in_group551); if (state.failed) return retval;
				DebugLocation(69, 13);
				PushFollow(Follow._term_in_group554);
				term41=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term41.Tree);
				DebugLocation(69, 21);
				char_literal42=(IToken)Match(input,41,Follow._41_in_group556); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:69:25: number
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(69, 25);
				PushFollow(Follow._number_in_group561);
				number43=number();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, number43.Tree);

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
			TraceOut("group", 16);
			LeaveRule("group", 16);
			Leave_group();
			if (state.backtracking > 0) { Memoize(input, 16, group_StartIndex); }
		}
		DebugLocation(69, 30);
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
	// MathLang.g:71:1: assignment : ID ASSIGN expression ';' ;
	[GrammarRule("assignment")]
	private MathLangParser.assignment_return assignment()
	{
		Enter_assignment();
		EnterRule("assignment", 17);
		TraceIn("assignment", 17);
		MathLangParser.assignment_return retval = new MathLangParser.assignment_return();
		retval.Start = (IToken)input.LT(1);
		int assignment_StartIndex = input.Index;
		object root_0 = null;

		IToken ID44=null;
		IToken ASSIGN45=null;
		IToken char_literal47=null;
		MathLangParser.expression_return expression46 = default(MathLangParser.expression_return);

		object ID44_tree=null;
		object ASSIGN45_tree=null;
		object char_literal47_tree=null;

		try { DebugEnterRule(GrammarFileName, "assignment");
		DebugLocation(71, 38);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 17)) { return retval; }
			// MathLang.g:71:11: ( ID ASSIGN expression ';' )
			DebugEnterAlt(1);
			// MathLang.g:71:13: ID ASSIGN expression ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(71, 13);
			ID44=(IToken)Match(input,ID,Follow._ID_in_assignment568); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			ID44_tree = (object)adaptor.Create(ID44);
			adaptor.AddChild(root_0, ID44_tree);
			}
			DebugLocation(71, 22);
			ASSIGN45=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignment570); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			ASSIGN45_tree = (object)adaptor.Create(ASSIGN45);
			root_0 = (object)adaptor.BecomeRoot(ASSIGN45_tree, root_0);
			}
			DebugLocation(71, 24);
			PushFollow(Follow._expression_in_assignment573);
			expression46=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression46.Tree);
			DebugLocation(71, 38);
			char_literal47=(IToken)Match(input,39,Follow._39_in_assignment575); if (state.failed) return retval;

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
			TraceOut("assignment", 17);
			LeaveRule("assignment", 17);
			Leave_assignment();
			if (state.backtracking > 0) { Memoize(input, 17, assignment_StartIndex); }
		}
		DebugLocation(71, 38);
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
	// MathLang.g:72:1: assignmentbody : ID ASSIGN expression ;
	[GrammarRule("assignmentbody")]
	private MathLangParser.assignmentbody_return assignmentbody()
	{
		Enter_assignmentbody();
		EnterRule("assignmentbody", 18);
		TraceIn("assignmentbody", 18);
		MathLangParser.assignmentbody_return retval = new MathLangParser.assignmentbody_return();
		retval.Start = (IToken)input.LT(1);
		int assignmentbody_StartIndex = input.Index;
		object root_0 = null;

		IToken ID48=null;
		IToken ASSIGN49=null;
		MathLangParser.expression_return expression50 = default(MathLangParser.expression_return);

		object ID48_tree=null;
		object ASSIGN49_tree=null;

		try { DebugEnterRule(GrammarFileName, "assignmentbody");
		DebugLocation(72, 38);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 18)) { return retval; }
			// MathLang.g:72:15: ( ID ASSIGN expression )
			DebugEnterAlt(1);
			// MathLang.g:72:17: ID ASSIGN expression
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(72, 17);
			ID48=(IToken)Match(input,ID,Follow._ID_in_assignmentbody582); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			ID48_tree = (object)adaptor.Create(ID48);
			adaptor.AddChild(root_0, ID48_tree);
			}
			DebugLocation(72, 26);
			ASSIGN49=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignmentbody584); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			ASSIGN49_tree = (object)adaptor.Create(ASSIGN49);
			root_0 = (object)adaptor.BecomeRoot(ASSIGN49_tree, root_0);
			}
			DebugLocation(72, 28);
			PushFollow(Follow._expression_in_assignmentbody587);
			expression50=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression50.Tree);

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
			TraceOut("assignmentbody", 18);
			LeaveRule("assignmentbody", 18);
			Leave_assignmentbody();
			if (state.backtracking > 0) { Memoize(input, 18, assignmentbody_StartIndex); }
		}
		DebugLocation(72, 38);
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
	// MathLang.g:74:1: boolexpression : boolterm ;
	[GrammarRule("boolexpression")]
	private MathLangParser.boolexpression_return boolexpression()
	{
		Enter_boolexpression();
		EnterRule("boolexpression", 19);
		TraceIn("boolexpression", 19);
		MathLangParser.boolexpression_return retval = new MathLangParser.boolexpression_return();
		retval.Start = (IToken)input.LT(1);
		int boolexpression_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.boolterm_return boolterm51 = default(MathLangParser.boolterm_return);


		try { DebugEnterRule(GrammarFileName, "boolexpression");
		DebugLocation(74, 24);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 19)) { return retval; }
			// MathLang.g:74:15: ( boolterm )
			DebugEnterAlt(1);
			// MathLang.g:74:17: boolterm
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(74, 17);
			PushFollow(Follow._boolterm_in_boolexpression595);
			boolterm51=boolterm();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm51.Tree);

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
			TraceOut("boolexpression", 19);
			LeaveRule("boolexpression", 19);
			Leave_boolexpression();
			if (state.backtracking > 0) { Memoize(input, 19, boolexpression_StartIndex); }
		}
		DebugLocation(74, 24);
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
	// MathLang.g:75:1: boolterm : or ;
	[GrammarRule("boolterm")]
	private MathLangParser.boolterm_return boolterm()
	{
		Enter_boolterm();
		EnterRule("boolterm", 20);
		TraceIn("boolterm", 20);
		MathLangParser.boolterm_return retval = new MathLangParser.boolterm_return();
		retval.Start = (IToken)input.LT(1);
		int boolterm_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.or_return or52 = default(MathLangParser.or_return);


		try { DebugEnterRule(GrammarFileName, "boolterm");
		DebugLocation(75, 12);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 20)) { return retval; }
			// MathLang.g:75:9: ( or )
			DebugEnterAlt(1);
			// MathLang.g:75:11: or
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(75, 11);
			PushFollow(Follow._or_in_boolterm601);
			or52=or();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or52.Tree);

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
			TraceOut("boolterm", 20);
			LeaveRule("boolterm", 20);
			Leave_boolterm();
			if (state.backtracking > 0) { Memoize(input, 20, boolterm_StartIndex); }
		}
		DebugLocation(75, 12);
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
	// MathLang.g:76:1: or : and ( OR and )* ;
	[GrammarRule("or")]
	private MathLangParser.or_return or()
	{
		Enter_or();
		EnterRule("or", 21);
		TraceIn("or", 21);
		MathLangParser.or_return retval = new MathLangParser.or_return();
		retval.Start = (IToken)input.LT(1);
		int or_StartIndex = input.Index;
		object root_0 = null;

		IToken OR54=null;
		MathLangParser.and_return and53 = default(MathLangParser.and_return);
		MathLangParser.and_return and55 = default(MathLangParser.and_return);

		object OR54_tree=null;

		try { DebugEnterRule(GrammarFileName, "or");
		DebugLocation(76, 18);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 21)) { return retval; }
			// MathLang.g:76:3: ( and ( OR and )* )
			DebugEnterAlt(1);
			// MathLang.g:76:5: and ( OR and )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(76, 5);
			PushFollow(Follow._and_in_or607);
			and53=and();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and53.Tree);
			DebugLocation(76, 9);
			// MathLang.g:76:9: ( OR and )*
			try { DebugEnterSubRule(9);
			while (true)
			{
				int alt9=2;
				try { DebugEnterDecision(9, decisionCanBacktrack[9]);
				int LA9_0 = input.LA(1);

				if ((LA9_0==OR))
				{
					alt9=1;
				}


				} finally { DebugExitDecision(9); }
				switch ( alt9 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:76:10: OR and
					{
					DebugLocation(76, 12);
					OR54=(IToken)Match(input,OR,Follow._OR_in_or610); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR54_tree = (object)adaptor.Create(OR54);
					root_0 = (object)adaptor.BecomeRoot(OR54_tree, root_0);
					}
					DebugLocation(76, 14);
					PushFollow(Follow._and_in_or613);
					and55=and();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and55.Tree);

					}
					break;

				default:
					goto loop9;
				}
			}

			loop9:
				;

			} finally { DebugExitSubRule(9); }


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
			TraceOut("or", 21);
			LeaveRule("or", 21);
			Leave_or();
			if (state.backtracking > 0) { Memoize(input, 21, or_StartIndex); }
		}
		DebugLocation(76, 18);
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
	// MathLang.g:77:1: and : boolgroup ( AND boolgroup )* ;
	[GrammarRule("and")]
	private MathLangParser.and_return and()
	{
		Enter_and();
		EnterRule("and", 22);
		TraceIn("and", 22);
		MathLangParser.and_return retval = new MathLangParser.and_return();
		retval.Start = (IToken)input.LT(1);
		int and_StartIndex = input.Index;
		object root_0 = null;

		IToken AND57=null;
		MathLangParser.boolgroup_return boolgroup56 = default(MathLangParser.boolgroup_return);
		MathLangParser.boolgroup_return boolgroup58 = default(MathLangParser.boolgroup_return);

		object AND57_tree=null;

		try { DebugEnterRule(GrammarFileName, "and");
		DebugLocation(77, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 22)) { return retval; }
			// MathLang.g:77:4: ( boolgroup ( AND boolgroup )* )
			DebugEnterAlt(1);
			// MathLang.g:77:6: boolgroup ( AND boolgroup )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(77, 6);
			PushFollow(Follow._boolgroup_in_and621);
			boolgroup56=boolgroup();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup56.Tree);
			DebugLocation(77, 16);
			// MathLang.g:77:16: ( AND boolgroup )*
			try { DebugEnterSubRule(10);
			while (true)
			{
				int alt10=2;
				try { DebugEnterDecision(10, decisionCanBacktrack[10]);
				int LA10_0 = input.LA(1);

				if ((LA10_0==AND))
				{
					alt10=1;
				}


				} finally { DebugExitDecision(10); }
				switch ( alt10 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:77:17: AND boolgroup
					{
					DebugLocation(77, 20);
					AND57=(IToken)Match(input,AND,Follow._AND_in_and624); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND57_tree = (object)adaptor.Create(AND57);
					root_0 = (object)adaptor.BecomeRoot(AND57_tree, root_0);
					}
					DebugLocation(77, 22);
					PushFollow(Follow._boolgroup_in_and627);
					boolgroup58=boolgroup();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup58.Tree);

					}
					break;

				default:
					goto loop10;
				}
			}

			loop10:
				;

			} finally { DebugExitSubRule(10); }


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
			TraceOut("and", 22);
			LeaveRule("and", 22);
			Leave_and();
			if (state.backtracking > 0) { Memoize(input, 22, and_StartIndex); }
		}
		DebugLocation(77, 32);
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
	// MathLang.g:78:1: boolgroup : ( '(' boolterm ')' | boolvar );
	[GrammarRule("boolgroup")]
	private MathLangParser.boolgroup_return boolgroup()
	{
		Enter_boolgroup();
		EnterRule("boolgroup", 23);
		TraceIn("boolgroup", 23);
		MathLangParser.boolgroup_return retval = new MathLangParser.boolgroup_return();
		retval.Start = (IToken)input.LT(1);
		int boolgroup_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal59=null;
		IToken char_literal61=null;
		MathLangParser.boolterm_return boolterm60 = default(MathLangParser.boolterm_return);
		MathLangParser.boolvar_return boolvar62 = default(MathLangParser.boolvar_return);

		object char_literal59_tree=null;
		object char_literal61_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolgroup");
		DebugLocation(78, 39);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 23)) { return retval; }
			// MathLang.g:78:10: ( '(' boolterm ')' | boolvar )
			int alt11=2;
			try { DebugEnterDecision(11, decisionCanBacktrack[11]);
			int LA11_0 = input.LA(1);

			if ((LA11_0==40))
			{
				int LA11_1 = input.LA(2);

				if ((EvaluatePredicate(synpred23_MathLang_fragment)))
				{
					alt11=1;
				}
				else if ((true))
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
			else if (((LA11_0>=NUMBER && LA11_0<=ID)||(LA11_0>=TRUE && LA11_0<=FALSE)))
			{
				alt11=2;
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
				// MathLang.g:78:12: '(' boolterm ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(78, 15);
				char_literal59=(IToken)Match(input,40,Follow._40_in_boolgroup635); if (state.failed) return retval;
				DebugLocation(78, 17);
				PushFollow(Follow._boolterm_in_boolgroup638);
				boolterm60=boolterm();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm60.Tree);
				DebugLocation(78, 29);
				char_literal61=(IToken)Match(input,41,Follow._41_in_boolgroup640); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:78:33: boolvar
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(78, 33);
				PushFollow(Follow._boolvar_in_boolgroup645);
				boolvar62=boolvar();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolvar62.Tree);

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
			TraceOut("boolgroup", 23);
			LeaveRule("boolgroup", 23);
			Leave_boolgroup();
			if (state.backtracking > 0) { Memoize(input, 23, boolgroup_StartIndex); }
		}
		DebugLocation(78, 39);
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
	// MathLang.g:79:1: boolvar : ( TRUE | FALSE | compare );
	[GrammarRule("boolvar")]
	private MathLangParser.boolvar_return boolvar()
	{
		Enter_boolvar();
		EnterRule("boolvar", 24);
		TraceIn("boolvar", 24);
		MathLangParser.boolvar_return retval = new MathLangParser.boolvar_return();
		retval.Start = (IToken)input.LT(1);
		int boolvar_StartIndex = input.Index;
		object root_0 = null;

		IToken TRUE63=null;
		IToken FALSE64=null;
		MathLangParser.compare_return compare65 = default(MathLangParser.compare_return);

		object TRUE63_tree=null;
		object FALSE64_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolvar");
		DebugLocation(79, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 24)) { return retval; }
			// MathLang.g:79:8: ( TRUE | FALSE | compare )
			int alt12=3;
			try { DebugEnterDecision(12, decisionCanBacktrack[12]);
			switch (input.LA(1))
			{
			case TRUE:
				{
				alt12=1;
				}
				break;
			case FALSE:
				{
				alt12=2;
				}
				break;
			case NUMBER:
			case ID:
			case 40:
				{
				alt12=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 12, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(12); }
			switch (alt12)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:79:10: TRUE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(79, 10);
				TRUE63=(IToken)Match(input,TRUE,Follow._TRUE_in_boolvar651); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				TRUE63_tree = (object)adaptor.Create(TRUE63);
				adaptor.AddChild(root_0, TRUE63_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:80:5: FALSE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(80, 5);
				FALSE64=(IToken)Match(input,FALSE,Follow._FALSE_in_boolvar657); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				FALSE64_tree = (object)adaptor.Create(FALSE64);
				adaptor.AddChild(root_0, FALSE64_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:81:5: compare
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(81, 5);
				PushFollow(Follow._compare_in_boolvar663);
				compare65=compare();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare65.Tree);

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
			TraceOut("boolvar", 24);
			LeaveRule("boolvar", 24);
			Leave_boolvar();
			if (state.backtracking > 0) { Memoize(input, 24, boolvar_StartIndex); }
		}
		DebugLocation(82, 0);
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
	// MathLang.g:84:1: ifstatement : IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )* ;
	[GrammarRule("ifstatement")]
	private MathLangParser.ifstatement_return ifstatement()
	{
		Enter_ifstatement();
		EnterRule("ifstatement", 25);
		TraceIn("ifstatement", 25);
		MathLangParser.ifstatement_return retval = new MathLangParser.ifstatement_return();
		retval.Start = (IToken)input.LT(1);
		int ifstatement_StartIndex = input.Index;
		object root_0 = null;

		IToken IF66=null;
		IToken char_literal67=null;
		IToken char_literal69=null;
		IToken ELSE72=null;
		MathLangParser.boolexpression_return boolexpression68 = default(MathLangParser.boolexpression_return);
		MathLangParser.block_return block70 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement71 = default(MathLangParser.statement_return);
		MathLangParser.block_return block73 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement74 = default(MathLangParser.statement_return);

		object IF66_tree=null;
		object char_literal67_tree=null;
		object char_literal69_tree=null;
		object ELSE72_tree=null;

		try { DebugEnterRule(GrammarFileName, "ifstatement");
		DebugLocation(84, 91);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 25)) { return retval; }
			// MathLang.g:84:12: ( IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )* )
			DebugEnterAlt(1);
			// MathLang.g:84:14: IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(84, 16);
			IF66=(IToken)Match(input,IF,Follow._IF_in_ifstatement671); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			IF66_tree = (object)adaptor.Create(IF66);
			root_0 = (object)adaptor.BecomeRoot(IF66_tree, root_0);
			}
			DebugLocation(84, 21);
			char_literal67=(IToken)Match(input,40,Follow._40_in_ifstatement674); if (state.failed) return retval;
			DebugLocation(84, 23);
			PushFollow(Follow._boolexpression_in_ifstatement677);
			boolexpression68=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression68.Tree);
			DebugLocation(84, 41);
			char_literal69=(IToken)Match(input,41,Follow._41_in_ifstatement679); if (state.failed) return retval;
			DebugLocation(84, 43);
			// MathLang.g:84:43: ( block | statement )
			int alt13=2;
			try { DebugEnterSubRule(13);
			try { DebugEnterDecision(13, decisionCanBacktrack[13]);
			int LA13_0 = input.LA(1);

			if ((LA13_0==42))
			{
				alt13=1;
			}
			else if ((LA13_0==IF||LA13_0==FOR||LA13_0==WHILE||(LA13_0>=ID && LA13_0<=TYPE)))
			{
				alt13=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 13, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(13); }
			switch (alt13)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:84:44: block
				{
				DebugLocation(84, 44);
				PushFollow(Follow._block_in_ifstatement683);
				block70=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block70.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:84:52: statement
				{
				DebugLocation(84, 52);
				PushFollow(Follow._statement_in_ifstatement687);
				statement71=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement71.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(13); }

			DebugLocation(84, 63);
			// MathLang.g:84:63: ( ELSE ( block | statement ) )*
			try { DebugEnterSubRule(15);
			while (true)
			{
				int alt15=2;
				try { DebugEnterDecision(15, decisionCanBacktrack[15]);
				int LA15_0 = input.LA(1);

				if ((LA15_0==ELSE))
				{
					int LA15_2 = input.LA(2);

					if ((EvaluatePredicate(synpred28_MathLang_fragment)))
					{
						alt15=1;
					}


				}


				} finally { DebugExitDecision(15); }
				switch ( alt15 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:84:64: ELSE ( block | statement )
					{
					DebugLocation(84, 68);
					ELSE72=(IToken)Match(input,ELSE,Follow._ELSE_in_ifstatement691); if (state.failed) return retval;
					DebugLocation(84, 70);
					// MathLang.g:84:70: ( block | statement )
					int alt14=2;
					try { DebugEnterSubRule(14);
					try { DebugEnterDecision(14, decisionCanBacktrack[14]);
					int LA14_0 = input.LA(1);

					if ((LA14_0==42))
					{
						alt14=1;
					}
					else if ((LA14_0==IF||LA14_0==FOR||LA14_0==WHILE||(LA14_0>=ID && LA14_0<=TYPE)))
					{
						alt14=2;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 14, 0, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
					} finally { DebugExitDecision(14); }
					switch (alt14)
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:84:71: block
						{
						DebugLocation(84, 71);
						PushFollow(Follow._block_in_ifstatement695);
						block73=block();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block73.Tree);

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// MathLang.g:84:79: statement
						{
						DebugLocation(84, 79);
						PushFollow(Follow._statement_in_ifstatement699);
						statement74=statement();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement74.Tree);

						}
						break;

					}
					} finally { DebugExitSubRule(14); }


					}
					break;

				default:
					goto loop15;
				}
			}

			loop15:
				;

			} finally { DebugExitSubRule(15); }


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
			TraceOut("ifstatement", 25);
			LeaveRule("ifstatement", 25);
			Leave_ifstatement();
			if (state.backtracking > 0) { Memoize(input, 25, ifstatement_StartIndex); }
		}
		DebugLocation(84, 91);
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
	// MathLang.g:86:1: whilestatement : WHILE '(' boolexpression ')' ( block | statement ) ;
	[GrammarRule("whilestatement")]
	private MathLangParser.whilestatement_return whilestatement()
	{
		Enter_whilestatement();
		EnterRule("whilestatement", 26);
		TraceIn("whilestatement", 26);
		MathLangParser.whilestatement_return retval = new MathLangParser.whilestatement_return();
		retval.Start = (IToken)input.LT(1);
		int whilestatement_StartIndex = input.Index;
		object root_0 = null;

		IToken WHILE75=null;
		IToken char_literal76=null;
		IToken char_literal78=null;
		MathLangParser.boolexpression_return boolexpression77 = default(MathLangParser.boolexpression_return);
		MathLangParser.block_return block79 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement80 = default(MathLangParser.statement_return);

		object WHILE75_tree=null;
		object char_literal76_tree=null;
		object char_literal78_tree=null;

		try { DebugEnterRule(GrammarFileName, "whilestatement");
		DebugLocation(86, 67);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 26)) { return retval; }
			// MathLang.g:86:15: ( WHILE '(' boolexpression ')' ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:86:17: WHILE '(' boolexpression ')' ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(86, 22);
			WHILE75=(IToken)Match(input,WHILE,Follow._WHILE_in_whilestatement710); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			WHILE75_tree = (object)adaptor.Create(WHILE75);
			root_0 = (object)adaptor.BecomeRoot(WHILE75_tree, root_0);
			}
			DebugLocation(86, 27);
			char_literal76=(IToken)Match(input,40,Follow._40_in_whilestatement713); if (state.failed) return retval;
			DebugLocation(86, 29);
			PushFollow(Follow._boolexpression_in_whilestatement716);
			boolexpression77=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression77.Tree);
			DebugLocation(86, 47);
			char_literal78=(IToken)Match(input,41,Follow._41_in_whilestatement718); if (state.failed) return retval;
			DebugLocation(86, 49);
			// MathLang.g:86:49: ( block | statement )
			int alt16=2;
			try { DebugEnterSubRule(16);
			try { DebugEnterDecision(16, decisionCanBacktrack[16]);
			int LA16_0 = input.LA(1);

			if ((LA16_0==42))
			{
				alt16=1;
			}
			else if ((LA16_0==IF||LA16_0==FOR||LA16_0==WHILE||(LA16_0>=ID && LA16_0<=TYPE)))
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
				// MathLang.g:86:50: block
				{
				DebugLocation(86, 50);
				PushFollow(Follow._block_in_whilestatement722);
				block79=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block79.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:86:58: statement
				{
				DebugLocation(86, 58);
				PushFollow(Follow._statement_in_whilestatement726);
				statement80=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement80.Tree);

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
			TraceOut("whilestatement", 26);
			LeaveRule("whilestatement", 26);
			Leave_whilestatement();
			if (state.backtracking > 0) { Memoize(input, 26, whilestatement_StartIndex); }
		}
		DebugLocation(86, 67);
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
	// MathLang.g:88:1: forstatement : FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement ) ;
	[GrammarRule("forstatement")]
	private MathLangParser.forstatement_return forstatement()
	{
		Enter_forstatement();
		EnterRule("forstatement", 27);
		TraceIn("forstatement", 27);
		MathLangParser.forstatement_return retval = new MathLangParser.forstatement_return();
		retval.Start = (IToken)input.LT(1);
		int forstatement_StartIndex = input.Index;
		object root_0 = null;

		IToken FOR81=null;
		IToken char_literal82=null;
		IToken char_literal84=null;
		IToken char_literal86=null;
		IToken char_literal88=null;
		MathLangParser.longdeclarationbody_return longdeclarationbody83 = default(MathLangParser.longdeclarationbody_return);
		MathLangParser.boolexpression_return boolexpression85 = default(MathLangParser.boolexpression_return);
		MathLangParser.assignmentbody_return assignmentbody87 = default(MathLangParser.assignmentbody_return);
		MathLangParser.block_return block89 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement90 = default(MathLangParser.statement_return);

		object FOR81_tree=null;
		object char_literal82_tree=null;
		object char_literal84_tree=null;
		object char_literal86_tree=null;
		object char_literal88_tree=null;

		try { DebugEnterRule(GrammarFileName, "forstatement");
		DebugLocation(88, 105);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 27)) { return retval; }
			// MathLang.g:88:13: ( FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:88:15: FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(88, 15);
			FOR81=(IToken)Match(input,FOR,Follow._FOR_in_forstatement734); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			FOR81_tree = (object)adaptor.Create(FOR81);
			adaptor.AddChild(root_0, FOR81_tree);
			}
			DebugLocation(88, 22);
			char_literal82=(IToken)Match(input,40,Follow._40_in_forstatement736); if (state.failed) return retval;
			DebugLocation(88, 24);
			PushFollow(Follow._longdeclarationbody_in_forstatement739);
			longdeclarationbody83=longdeclarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclarationbody83.Tree);
			DebugLocation(88, 44);
			char_literal84=(IToken)Match(input,39,Follow._39_in_forstatement741); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal84_tree = (object)adaptor.Create(char_literal84);
			adaptor.AddChild(root_0, char_literal84_tree);
			}
			DebugLocation(88, 48);
			PushFollow(Follow._boolexpression_in_forstatement743);
			boolexpression85=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression85.Tree);
			DebugLocation(88, 63);
			char_literal86=(IToken)Match(input,39,Follow._39_in_forstatement745); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal86_tree = (object)adaptor.Create(char_literal86);
			adaptor.AddChild(root_0, char_literal86_tree);
			}
			DebugLocation(88, 67);
			PushFollow(Follow._assignmentbody_in_forstatement747);
			assignmentbody87=assignmentbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentbody87.Tree);
			DebugLocation(88, 85);
			char_literal88=(IToken)Match(input,41,Follow._41_in_forstatement749); if (state.failed) return retval;
			DebugLocation(88, 87);
			// MathLang.g:88:87: ( block | statement )
			int alt17=2;
			try { DebugEnterSubRule(17);
			try { DebugEnterDecision(17, decisionCanBacktrack[17]);
			int LA17_0 = input.LA(1);

			if ((LA17_0==42))
			{
				alt17=1;
			}
			else if ((LA17_0==IF||LA17_0==FOR||LA17_0==WHILE||(LA17_0>=ID && LA17_0<=TYPE)))
			{
				alt17=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 17, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(17); }
			switch (alt17)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:88:88: block
				{
				DebugLocation(88, 88);
				PushFollow(Follow._block_in_forstatement753);
				block89=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block89.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:88:96: statement
				{
				DebugLocation(88, 96);
				PushFollow(Follow._statement_in_forstatement757);
				statement90=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement90.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(17); }


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
			TraceOut("forstatement", 27);
			LeaveRule("forstatement", 27);
			Leave_forstatement();
			if (state.backtracking > 0) { Memoize(input, 27, forstatement_StartIndex); }
		}
		DebugLocation(88, 105);
		} finally { DebugExitRule(GrammarFileName, "forstatement"); }
		return retval;

	}
	// $ANTLR end "forstatement"

	public class block_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_block();
	partial void Leave_block();

	// $ANTLR start "block"
	// MathLang.g:90:1: block : '{' statementlist '}' ;
	[GrammarRule("block")]
	private MathLangParser.block_return block()
	{
		Enter_block();
		EnterRule("block", 28);
		TraceIn("block", 28);
		MathLangParser.block_return retval = new MathLangParser.block_return();
		retval.Start = (IToken)input.LT(1);
		int block_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal91=null;
		IToken char_literal93=null;
		MathLangParser.statementlist_return statementlist92 = default(MathLangParser.statementlist_return);

		object char_literal91_tree=null;
		object char_literal93_tree=null;

		try { DebugEnterRule(GrammarFileName, "block");
		DebugLocation(90, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 28)) { return retval; }
			// MathLang.g:90:6: ( '{' statementlist '}' )
			DebugEnterAlt(1);
			// MathLang.g:90:8: '{' statementlist '}'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(90, 11);
			char_literal91=(IToken)Match(input,42,Follow._42_in_block765); if (state.failed) return retval;
			DebugLocation(90, 13);
			PushFollow(Follow._statementlist_in_block768);
			statementlist92=statementlist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementlist92.Tree);
			DebugLocation(90, 30);
			char_literal93=(IToken)Match(input,43,Follow._43_in_block770); if (state.failed) return retval;

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
			TraceOut("block", 28);
			LeaveRule("block", 28);
			Leave_block();
			if (state.backtracking > 0) { Memoize(input, 28, block_StartIndex); }
		}
		DebugLocation(90, 30);
		} finally { DebugExitRule(GrammarFileName, "block"); }
		return retval;

	}
	// $ANTLR end "block"

	partial void Enter_synpred7_MathLang_fragment();
	partial void Leave_synpred7_MathLang_fragment();

	// $ANTLR start synpred7_MathLang
	public void synpred7_MathLang_fragment()
	{
		Enter_synpred7_MathLang_fragment();
		EnterRule("synpred7_MathLang_fragment", 35);
		TraceIn("synpred7_MathLang_fragment", 35);
		try
		{
			// MathLang.g:52:13: ( mathexpression )
			DebugEnterAlt(1);
			// MathLang.g:52:13: mathexpression
			{
			DebugLocation(52, 13);
			PushFollow(Follow._mathexpression_in_synpred7_MathLang342);
			mathexpression();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred7_MathLang_fragment", 35);
			LeaveRule("synpred7_MathLang_fragment", 35);
			Leave_synpred7_MathLang_fragment();
		}
	}
	// $ANTLR end synpred7_MathLang

	partial void Enter_synpred23_MathLang_fragment();
	partial void Leave_synpred23_MathLang_fragment();

	// $ANTLR start synpred23_MathLang
	public void synpred23_MathLang_fragment()
	{
		Enter_synpred23_MathLang_fragment();
		EnterRule("synpred23_MathLang_fragment", 51);
		TraceIn("synpred23_MathLang_fragment", 51);
		try
		{
			// MathLang.g:78:12: ( '(' boolterm ')' )
			DebugEnterAlt(1);
			// MathLang.g:78:12: '(' boolterm ')'
			{
			DebugLocation(78, 12);
			Match(input,40,Follow._40_in_synpred23_MathLang635); if (state.failed) return;
			DebugLocation(78, 17);
			PushFollow(Follow._boolterm_in_synpred23_MathLang638);
			boolterm();
			PopFollow();
			if (state.failed) return;
			DebugLocation(78, 26);
			Match(input,41,Follow._41_in_synpred23_MathLang640); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred23_MathLang_fragment", 51);
			LeaveRule("synpred23_MathLang_fragment", 51);
			Leave_synpred23_MathLang_fragment();
		}
	}
	// $ANTLR end synpred23_MathLang

	partial void Enter_synpred28_MathLang_fragment();
	partial void Leave_synpred28_MathLang_fragment();

	// $ANTLR start synpred28_MathLang
	public void synpred28_MathLang_fragment()
	{
		Enter_synpred28_MathLang_fragment();
		EnterRule("synpred28_MathLang_fragment", 56);
		TraceIn("synpred28_MathLang_fragment", 56);
		try
		{
			// MathLang.g:84:64: ( ELSE ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:84:64: ELSE ( block | statement )
			{
			DebugLocation(84, 64);
			Match(input,ELSE,Follow._ELSE_in_synpred28_MathLang691); if (state.failed) return;
			DebugLocation(84, 70);
			// MathLang.g:84:70: ( block | statement )
			int alt18=2;
			try { DebugEnterSubRule(18);
			try { DebugEnterDecision(18, decisionCanBacktrack[18]);
			int LA18_0 = input.LA(1);

			if ((LA18_0==42))
			{
				alt18=1;
			}
			else if ((LA18_0==IF||LA18_0==FOR||LA18_0==WHILE||(LA18_0>=ID && LA18_0<=TYPE)))
			{
				alt18=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				NoViableAltException nvae = new NoViableAltException("", 18, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(18); }
			switch (alt18)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:84:71: block
				{
				DebugLocation(84, 71);
				PushFollow(Follow._block_in_synpred28_MathLang695);
				block();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:84:79: statement
				{
				DebugLocation(84, 79);
				PushFollow(Follow._statement_in_synpred28_MathLang699);
				statement();
				PopFollow();
				if (state.failed) return;

				}
				break;

			}
			} finally { DebugExitSubRule(18); }


			}

		}
		finally
		{
			TraceOut("synpred28_MathLang_fragment", 56);
			LeaveRule("synpred28_MathLang_fragment", 56);
			Leave_synpred28_MathLang_fragment();
		}
	}
	// $ANTLR end synpred28_MathLang
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


	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _statementlist_in_execute259 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_execute261 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_statementlist270 = new BitSet(new ulong[]{0x61282UL});
		public static readonly BitSet _declaration_in_statement291 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assignment_in_statement297 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ifstatement_in_statement302 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _whilestatement_in_statement307 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _forstatement_in_statement312 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_number0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _term_in_mathexpression334 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathexpression_in_expression342 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolexpression_in_expression349 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_declaration356 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _ID_in_declaration359 = new BitSet(new ulong[]{0x8000000000UL});
		public static readonly BitSet _39_in_declaration360 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _longdeclaration_in_declaration368 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_longdeclaration374 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _ID_in_longdeclaration376 = new BitSet(new ulong[]{0x80000UL});
		public static readonly BitSet _ASSIGN_in_longdeclaration378 = new BitSet(new ulong[]{0x10600030000UL});
		public static readonly BitSet _expression_in_longdeclaration380 = new BitSet(new ulong[]{0x8000000000UL});
		public static readonly BitSet _39_in_longdeclaration382 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_declarationbody405 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _ID_in_declarationbody408 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_longdeclarationbody415 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _ID_in_longdeclarationbody417 = new BitSet(new ulong[]{0x80000UL});
		public static readonly BitSet _ASSIGN_in_longdeclarationbody419 = new BitSet(new ulong[]{0x10600030000UL});
		public static readonly BitSet _expression_in_longdeclarationbody421 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_variable444 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _ID_in_variable453 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mul_in_add459 = new BitSet(new ulong[]{0x600002UL});
		public static readonly BitSet _set_in_add463 = new BitSet(new ulong[]{0x10000030000UL});
		public static readonly BitSet _mul_in_add472 = new BitSet(new ulong[]{0x600002UL});
		public static readonly BitSet _group_in_mul481 = new BitSet(new ulong[]{0x1800002UL});
		public static readonly BitSet _set_in_mul485 = new BitSet(new ulong[]{0x10000030000UL});
		public static readonly BitSet _group_in_mul494 = new BitSet(new ulong[]{0x1800002UL});
		public static readonly BitSet _add_in_compare502 = new BitSet(new ulong[]{0x7E000002UL});
		public static readonly BitSet _set_in_compare506 = new BitSet(new ulong[]{0x10000030000UL});
		public static readonly BitSet _add_in_compare532 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _add_in_term544 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _40_in_group551 = new BitSet(new ulong[]{0x10000030000UL});
		public static readonly BitSet _term_in_group554 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _41_in_group556 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _number_in_group561 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_assignment568 = new BitSet(new ulong[]{0x80000UL});
		public static readonly BitSet _ASSIGN_in_assignment570 = new BitSet(new ulong[]{0x10600030000UL});
		public static readonly BitSet _expression_in_assignment573 = new BitSet(new ulong[]{0x8000000000UL});
		public static readonly BitSet _39_in_assignment575 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_assignmentbody582 = new BitSet(new ulong[]{0x80000UL});
		public static readonly BitSet _ASSIGN_in_assignmentbody584 = new BitSet(new ulong[]{0x10600030000UL});
		public static readonly BitSet _expression_in_assignmentbody587 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolterm_in_boolexpression595 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _or_in_boolterm601 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _and_in_or607 = new BitSet(new ulong[]{0x80000002UL});
		public static readonly BitSet _OR_in_or610 = new BitSet(new ulong[]{0x10600030000UL});
		public static readonly BitSet _and_in_or613 = new BitSet(new ulong[]{0x80000002UL});
		public static readonly BitSet _boolgroup_in_and621 = new BitSet(new ulong[]{0x100000002UL});
		public static readonly BitSet _AND_in_and624 = new BitSet(new ulong[]{0x10600030000UL});
		public static readonly BitSet _boolgroup_in_and627 = new BitSet(new ulong[]{0x100000002UL});
		public static readonly BitSet _40_in_boolgroup635 = new BitSet(new ulong[]{0x10600030000UL});
		public static readonly BitSet _boolterm_in_boolgroup638 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _41_in_boolgroup640 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolvar_in_boolgroup645 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TRUE_in_boolvar651 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FALSE_in_boolvar657 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _compare_in_boolvar663 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_ifstatement671 = new BitSet(new ulong[]{0x10000000000UL});
		public static readonly BitSet _40_in_ifstatement674 = new BitSet(new ulong[]{0x10600030000UL});
		public static readonly BitSet _boolexpression_in_ifstatement677 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _41_in_ifstatement679 = new BitSet(new ulong[]{0x40000061380UL});
		public static readonly BitSet _block_in_ifstatement683 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement687 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _ELSE_in_ifstatement691 = new BitSet(new ulong[]{0x40000061380UL});
		public static readonly BitSet _block_in_ifstatement695 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement699 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _WHILE_in_whilestatement710 = new BitSet(new ulong[]{0x10000000000UL});
		public static readonly BitSet _40_in_whilestatement713 = new BitSet(new ulong[]{0x10600030000UL});
		public static readonly BitSet _boolexpression_in_whilestatement716 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _41_in_whilestatement718 = new BitSet(new ulong[]{0x40000061280UL});
		public static readonly BitSet _block_in_whilestatement722 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_whilestatement726 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_forstatement734 = new BitSet(new ulong[]{0x10000000000UL});
		public static readonly BitSet _40_in_forstatement736 = new BitSet(new ulong[]{0x40000UL});
		public static readonly BitSet _longdeclarationbody_in_forstatement739 = new BitSet(new ulong[]{0x8000000000UL});
		public static readonly BitSet _39_in_forstatement741 = new BitSet(new ulong[]{0x10600030000UL});
		public static readonly BitSet _boolexpression_in_forstatement743 = new BitSet(new ulong[]{0x8000000000UL});
		public static readonly BitSet _39_in_forstatement745 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _assignmentbody_in_forstatement747 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _41_in_forstatement749 = new BitSet(new ulong[]{0x40000061280UL});
		public static readonly BitSet _block_in_forstatement753 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_forstatement757 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _42_in_block765 = new BitSet(new ulong[]{0x61280UL});
		public static readonly BitSet _statementlist_in_block768 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _43_in_block770 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathexpression_in_synpred7_MathLang342 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _40_in_synpred23_MathLang635 = new BitSet(new ulong[]{0x10600030000UL});
		public static readonly BitSet _boolterm_in_synpred23_MathLang638 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _41_in_synpred23_MathLang640 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ELSE_in_synpred28_MathLang691 = new BitSet(new ulong[]{0x40000061280UL});
		public static readonly BitSet _block_in_synpred28_MathLang695 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_synpred28_MathLang699 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  MathLang 

// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-10-01 17:34:35

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "UNKNOWN", "PRINT", "INPUT", "IF", "ELSE", "FOR", "FUNCTION", "RETURN", "WHILE", "BLOCK", "PROGRAM", "PARAMS", "NUMBER", "ID", "CHAR", "TYPE", "ASSIGN", "ARRAY", "ADD", "SUB", "MUL", "DIV", "GREQ", "LSEQ", "NEQ", "EQ", "GR", "LS", "OR", "AND", "TRUE", "FALSE", "ACCESS_MODIFIER", "FUNCT", "PARAMETERS", "WS", "SL_COMMENT", "ML_COMMENT", "';'", "'('", "')'", "','", "'{'", "'}'"
	};
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

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, true, false, false, false, true, false, false, false, false, 
				true, false, false, false, true, false, false, false, false, false, 
				false
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
		this.state.ruleMemo = new System.Collections.Generic.Dictionary<int, int>[66+1];

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
			PushFollow(Follow._statementlist_in_execute263);
			statementlist1=statementlist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementlist1.Tree);
			DebugLocation(36, 19);
			EOF2=(IToken)Match(input,EOF,Follow._EOF_in_execute265); if (state.failed) return retval;

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

	public class statement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_statement();
	partial void Leave_statement();

	// $ANTLR start "statement"
	// MathLang.g:39:1: statement : ( declaration | assignment | ifstatement | whilestatement | forstatement | funcdeclaration ) ;
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


		try { DebugEnterRule(GrammarFileName, "statement");
		DebugLocation(39, 20);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 2)) { return retval; }
			// MathLang.g:39:10: ( ( declaration | assignment | ifstatement | whilestatement | forstatement | funcdeclaration ) )
			DebugEnterAlt(1);
			// MathLang.g:39:12: ( declaration | assignment | ifstatement | whilestatement | forstatement | funcdeclaration )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(39, 12);
			// MathLang.g:39:12: ( declaration | assignment | ifstatement | whilestatement | forstatement | funcdeclaration )
			int alt1=6;
			try { DebugEnterSubRule(1);
			try { DebugEnterDecision(1, decisionCanBacktrack[1]);
			switch (input.LA(1))
			{
			case TYPE:
				{
				int LA1_1 = input.LA(2);

				if ((LA1_1==ID))
				{
					int LA1_6 = input.LA(3);

					if ((LA1_6==ASSIGN||LA1_6==42))
					{
						alt1=1;
					}
					else if ((LA1_6==43))
					{
						alt1=6;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 1, 6, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 1, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			case ID:
				{
				alt1=2;
				}
				break;
			case IF:
				{
				alt1=3;
				}
				break;
			case WHILE:
				{
				alt1=4;
				}
				break;
			case FOR:
				{
				alt1=5;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
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
				// MathLang.g:39:14: declaration
				{
				DebugLocation(39, 14);
				PushFollow(Follow._declaration_in_statement276);
				declaration3=declaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, declaration3.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:40:4: assignment
				{
				DebugLocation(40, 4);
				PushFollow(Follow._assignment_in_statement282);
				assignment4=assignment();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment4.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:41:4: ifstatement
				{
				DebugLocation(41, 4);
				PushFollow(Follow._ifstatement_in_statement287);
				ifstatement5=ifstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ifstatement5.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:42:4: whilestatement
				{
				DebugLocation(42, 4);
				PushFollow(Follow._whilestatement_in_statement292);
				whilestatement6=whilestatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, whilestatement6.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:43:4: forstatement
				{
				DebugLocation(43, 4);
				PushFollow(Follow._forstatement_in_statement297);
				forstatement7=forstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forstatement7.Tree);

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// MathLang.g:44:4: funcdeclaration
				{
				DebugLocation(44, 4);
				PushFollow(Follow._funcdeclaration_in_statement302);
				funcdeclaration8=funcdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funcdeclaration8.Tree);

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
		DebugLocation(44, 20);
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
	// MathLang.g:46:1: number : ( NUMBER | ID | CHAR );
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

		IToken set9=null;

		object set9_tree=null;

		try { DebugEnterRule(GrammarFileName, "number");
		DebugLocation(46, 8);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 3)) { return retval; }
			// MathLang.g:46:8: ( NUMBER | ID | CHAR )
			DebugEnterAlt(1);
			// MathLang.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(46, 8);
			set9=(IToken)input.LT(1);
			if ((input.LA(1)>=NUMBER && input.LA(1)<=CHAR))
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
			TraceOut("number", 3);
			LeaveRule("number", 3);
			Leave_number();
			if (state.backtracking > 0) { Memoize(input, 3, number_StartIndex); }
		}
		DebugLocation(48, 8);
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
	// MathLang.g:49:1: mathexpression : term ;
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

		MathLangParser.term_return term10 = default(MathLangParser.term_return);


		try { DebugEnterRule(GrammarFileName, "mathexpression");
		DebugLocation(49, 21);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 4)) { return retval; }
			// MathLang.g:49:15: ( term )
			DebugEnterAlt(1);
			// MathLang.g:49:17: term
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(49, 17);
			PushFollow(Follow._term_in_mathexpression330);
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
			TraceOut("mathexpression", 4);
			LeaveRule("mathexpression", 4);
			Leave_mathexpression();
			if (state.backtracking > 0) { Memoize(input, 4, mathexpression_StartIndex); }
		}
		DebugLocation(49, 21);
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
	// MathLang.g:51:1: expression : ( mathexpression | boolexpression );
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

		MathLangParser.mathexpression_return mathexpression11 = default(MathLangParser.mathexpression_return);
		MathLangParser.boolexpression_return boolexpression12 = default(MathLangParser.boolexpression_return);


		try { DebugEnterRule(GrammarFileName, "expression");
		DebugLocation(51, 19);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 5)) { return retval; }
			// MathLang.g:51:11: ( mathexpression | boolexpression )
			int alt2=2;
			try { DebugEnterDecision(2, decisionCanBacktrack[2]);
			switch (input.LA(1))
			{
			case 43:
				{
				int LA2_1 = input.LA(2);

				if ((EvaluatePredicate(synpred8_MathLang_fragment)))
				{
					alt2=1;
				}
				else if ((true))
				{
					alt2=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 2, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			case NUMBER:
			case ID:
			case CHAR:
				{
				int LA2_2 = input.LA(2);

				if ((EvaluatePredicate(synpred8_MathLang_fragment)))
				{
					alt2=1;
				}
				else if ((true))
				{
					alt2=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 2, 2, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			case TRUE:
			case FALSE:
				{
				alt2=2;
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
				// MathLang.g:51:12: mathexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(51, 12);
				PushFollow(Follow._mathexpression_in_expression337);
				mathexpression11=mathexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mathexpression11.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:52:6: boolexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(52, 6);
				PushFollow(Follow._boolexpression_in_expression344);
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
			TraceOut("expression", 5);
			LeaveRule("expression", 5);
			Leave_expression();
			if (state.backtracking > 0) { Memoize(input, 5, expression_StartIndex); }
		}
		DebugLocation(52, 19);
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
	// MathLang.g:54:1: declaration : ( TYPE ID ';' | longdeclaration );
	[GrammarRule("declaration")]
	private MathLangParser.declaration_return declaration()
	{
		Enter_declaration();
		EnterRule("declaration", 6);
		TraceIn("declaration", 6);
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
		DebugLocation(54, 20);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 6)) { return retval; }
			// MathLang.g:54:12: ( TYPE ID ';' | longdeclaration )
			int alt3=2;
			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
			int LA3_0 = input.LA(1);

			if ((LA3_0==TYPE))
			{
				int LA3_1 = input.LA(2);

				if ((LA3_1==ID))
				{
					int LA3_2 = input.LA(3);

					if ((LA3_2==42))
					{
						alt3=1;
					}
					else if ((LA3_2==ASSIGN))
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
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 3, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 3, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(3); }
			switch (alt3)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:54:14: TYPE ID ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(54, 18);
				TYPE13=(IToken)Match(input,TYPE,Follow._TYPE_in_declaration351); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				TYPE13_tree = (object)adaptor.Create(TYPE13);
				root_0 = (object)adaptor.BecomeRoot(TYPE13_tree, root_0);
				}
				DebugLocation(54, 20);
				ID14=(IToken)Match(input,ID,Follow._ID_in_declaration354); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				ID14_tree = (object)adaptor.Create(ID14);
				adaptor.AddChild(root_0, ID14_tree);
				}
				DebugLocation(54, 26);
				char_literal15=(IToken)Match(input,42,Follow._42_in_declaration356); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:55:6: longdeclaration
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(55, 6);
				PushFollow(Follow._longdeclaration_in_declaration364);
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
			TraceOut("declaration", 6);
			LeaveRule("declaration", 6);
			Leave_declaration();
			if (state.backtracking > 0) { Memoize(input, 6, declaration_StartIndex); }
		}
		DebugLocation(55, 20);
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
	// MathLang.g:57:1: declarationbody : TYPE ID ;
	[GrammarRule("declarationbody")]
	private MathLangParser.declarationbody_return declarationbody()
	{
		Enter_declarationbody();
		EnterRule("declarationbody", 7);
		TraceIn("declarationbody", 7);
		MathLangParser.declarationbody_return retval = new MathLangParser.declarationbody_return();
		retval.Start = (IToken)input.LT(1);
		int declarationbody_StartIndex = input.Index;
		object root_0 = null;

		IToken TYPE17=null;
		IToken ID18=null;

		object TYPE17_tree=null;
		object ID18_tree=null;

		try { DebugEnterRule(GrammarFileName, "declarationbody");
		DebugLocation(57, 26);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 7)) { return retval; }
			// MathLang.g:57:16: ( TYPE ID )
			DebugEnterAlt(1);
			// MathLang.g:57:18: TYPE ID
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(57, 22);
			TYPE17=(IToken)Match(input,TYPE,Follow._TYPE_in_declarationbody371); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			TYPE17_tree = (object)adaptor.Create(TYPE17);
			root_0 = (object)adaptor.BecomeRoot(TYPE17_tree, root_0);
			}
			DebugLocation(57, 24);
			ID18=(IToken)Match(input,ID,Follow._ID_in_declarationbody374); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			ID18_tree = (object)adaptor.Create(ID18);
			adaptor.AddChild(root_0, ID18_tree);
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
			TraceOut("declarationbody", 7);
			LeaveRule("declarationbody", 7);
			Leave_declarationbody();
			if (state.backtracking > 0) { Memoize(input, 7, declarationbody_StartIndex); }
		}
		DebugLocation(57, 26);
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
	// MathLang.g:59:1: longdeclaration : TYPE ID ASSIGN expression ';' -> ^( ASSIGN ^( TYPE ID ) expression ) ;
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

		IToken TYPE19=null;
		IToken ID20=null;
		IToken ASSIGN21=null;
		IToken char_literal23=null;
		MathLangParser.expression_return expression22 = default(MathLangParser.expression_return);

		object TYPE19_tree=null;
		object ID20_tree=null;
		object ASSIGN21_tree=null;
		object char_literal23_tree=null;
		RewriteRuleITokenStream stream_42=new RewriteRuleITokenStream(adaptor,"token 42");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "longdeclaration");
		DebugLocation(59, 82);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 8)) { return retval; }
			// MathLang.g:59:16: ( TYPE ID ASSIGN expression ';' -> ^( ASSIGN ^( TYPE ID ) expression ) )
			DebugEnterAlt(1);
			// MathLang.g:59:17: TYPE ID ASSIGN expression ';'
			{
			DebugLocation(59, 17);
			TYPE19=(IToken)Match(input,TYPE,Follow._TYPE_in_longdeclaration381); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE19);

			DebugLocation(59, 22);
			ID20=(IToken)Match(input,ID,Follow._ID_in_longdeclaration383); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID20);

			DebugLocation(59, 25);
			ASSIGN21=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclaration385); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN21);

			DebugLocation(59, 32);
			PushFollow(Follow._expression_in_longdeclaration387);
			expression22=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression22.Tree);
			DebugLocation(59, 46);
			char_literal23=(IToken)Match(input,42,Follow._42_in_longdeclaration389); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_42.Add(char_literal23);



			{
			// AST REWRITE
			// elements: expression, ID, TYPE, ASSIGN
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 59:48: -> ^( ASSIGN ^( TYPE ID ) expression )
			{
				DebugLocation(59, 51);
				// MathLang.g:59:51: ^( ASSIGN ^( TYPE ID ) expression )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(59, 53);
				root_1 = (object)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_1);

				DebugLocation(59, 60);
				// MathLang.g:59:60: ^( TYPE ID )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(59, 62);
				root_2 = (object)adaptor.BecomeRoot(stream_TYPE.NextNode(), root_2);

				DebugLocation(59, 67);
				adaptor.AddChild(root_2, stream_ID.NextNode());

				adaptor.AddChild(root_1, root_2);
				}
				DebugLocation(59, 71);
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
		DebugLocation(59, 82);
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
	// MathLang.g:61:1: longdeclarationbody : TYPE ID ASSIGN expression -> ^( ASSIGN ^( TYPE ID ) expression ) ;
	[GrammarRule("longdeclarationbody")]
	private MathLangParser.longdeclarationbody_return longdeclarationbody()
	{
		Enter_longdeclarationbody();
		EnterRule("longdeclarationbody", 9);
		TraceIn("longdeclarationbody", 9);
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
		DebugLocation(61, 82);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 9)) { return retval; }
			// MathLang.g:61:20: ( TYPE ID ASSIGN expression -> ^( ASSIGN ^( TYPE ID ) expression ) )
			DebugEnterAlt(1);
			// MathLang.g:61:22: TYPE ID ASSIGN expression
			{
			DebugLocation(61, 22);
			TYPE24=(IToken)Match(input,TYPE,Follow._TYPE_in_longdeclarationbody412); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE24);

			DebugLocation(61, 27);
			ID25=(IToken)Match(input,ID,Follow._ID_in_longdeclarationbody414); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID25);

			DebugLocation(61, 30);
			ASSIGN26=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclarationbody416); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN26);

			DebugLocation(61, 37);
			PushFollow(Follow._expression_in_longdeclarationbody418);
			expression27=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression27.Tree);


			{
			// AST REWRITE
			// elements: expression, ID, ASSIGN, TYPE
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 61:48: -> ^( ASSIGN ^( TYPE ID ) expression )
			{
				DebugLocation(61, 51);
				// MathLang.g:61:51: ^( ASSIGN ^( TYPE ID ) expression )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(61, 53);
				root_1 = (object)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_1);

				DebugLocation(61, 60);
				// MathLang.g:61:60: ^( TYPE ID )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(61, 62);
				root_2 = (object)adaptor.BecomeRoot(stream_TYPE.NextNode(), root_2);

				DebugLocation(61, 67);
				adaptor.AddChild(root_2, stream_ID.NextNode());

				adaptor.AddChild(root_1, root_2);
				}
				DebugLocation(61, 71);
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
			TraceOut("longdeclarationbody", 9);
			LeaveRule("longdeclarationbody", 9);
			Leave_longdeclarationbody();
			if (state.backtracking > 0) { Memoize(input, 9, longdeclarationbody_StartIndex); }
		}
		DebugLocation(61, 82);
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
	// MathLang.g:63:1: variable : ( TYPE | ARRAY ) ID ;
	[GrammarRule("variable")]
	private MathLangParser.variable_return variable()
	{
		Enter_variable();
		EnterRule("variable", 10);
		TraceIn("variable", 10);
		MathLangParser.variable_return retval = new MathLangParser.variable_return();
		retval.Start = (IToken)input.LT(1);
		int variable_StartIndex = input.Index;
		object root_0 = null;

		IToken set28=null;
		IToken ID29=null;

		object set28_tree=null;
		object ID29_tree=null;

		try { DebugEnterRule(GrammarFileName, "variable");
		DebugLocation(63, 28);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 10)) { return retval; }
			// MathLang.g:63:9: ( ( TYPE | ARRAY ) ID )
			DebugEnterAlt(1);
			// MathLang.g:63:11: ( TYPE | ARRAY ) ID
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(63, 11);
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

			DebugLocation(63, 27);
			ID29=(IToken)Match(input,ID,Follow._ID_in_variable449); if (state.failed) return retval;
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
			TraceOut("variable", 10);
			LeaveRule("variable", 10);
			Leave_variable();
			if (state.backtracking > 0) { Memoize(input, 10, variable_StartIndex); }
		}
		DebugLocation(63, 28);
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
	// MathLang.g:64:1: add : mul ( ( ADD | SUB ) mul )* ;
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

		IToken set31=null;
		MathLangParser.mul_return mul30 = default(MathLangParser.mul_return);
		MathLangParser.mul_return mul32 = default(MathLangParser.mul_return);

		object set31_tree=null;

		try { DebugEnterRule(GrammarFileName, "add");
		DebugLocation(64, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 11)) { return retval; }
			// MathLang.g:64:4: ( mul ( ( ADD | SUB ) mul )* )
			DebugEnterAlt(1);
			// MathLang.g:64:6: mul ( ( ADD | SUB ) mul )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(64, 6);
			PushFollow(Follow._mul_in_add455);
			mul30=mul();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul30.Tree);
			DebugLocation(64, 10);
			// MathLang.g:64:10: ( ( ADD | SUB ) mul )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_0 = input.LA(1);

				if (((LA4_0>=ADD && LA4_0<=SUB)))
				{
					alt4=1;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:64:12: ( ADD | SUB ) mul
					{
					DebugLocation(64, 12);
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

					DebugLocation(64, 25);
					PushFollow(Follow._mul_in_add468);
					mul32=mul();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul32.Tree);

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
		DebugLocation(64, 30);
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
	// MathLang.g:65:1: mul : group ( ( MUL | DIV ) group )* ;
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

		IToken set34=null;
		MathLangParser.group_return group33 = default(MathLangParser.group_return);
		MathLangParser.group_return group35 = default(MathLangParser.group_return);

		object set34_tree=null;

		try { DebugEnterRule(GrammarFileName, "mul");
		DebugLocation(65, 33);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 12)) { return retval; }
			// MathLang.g:65:4: ( group ( ( MUL | DIV ) group )* )
			DebugEnterAlt(1);
			// MathLang.g:65:6: group ( ( MUL | DIV ) group )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(65, 6);
			PushFollow(Follow._group_in_mul477);
			group33=group();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group33.Tree);
			DebugLocation(65, 12);
			// MathLang.g:65:12: ( ( MUL | DIV ) group )*
			try { DebugEnterSubRule(5);
			while (true)
			{
				int alt5=2;
				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
				int LA5_0 = input.LA(1);

				if (((LA5_0>=MUL && LA5_0<=DIV)))
				{
					alt5=1;
				}


				} finally { DebugExitDecision(5); }
				switch ( alt5 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:65:14: ( MUL | DIV ) group
					{
					DebugLocation(65, 14);
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

					DebugLocation(65, 27);
					PushFollow(Follow._group_in_mul490);
					group35=group();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group35.Tree);

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
			TraceOut("mul", 12);
			LeaveRule("mul", 12);
			Leave_mul();
			if (state.backtracking > 0) { Memoize(input, 12, mul_StartIndex); }
		}
		DebugLocation(65, 33);
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
	// MathLang.g:66:1: compare : add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )? ;
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

		IToken set37=null;
		MathLangParser.add_return add36 = default(MathLangParser.add_return);
		MathLangParser.add_return add38 = default(MathLangParser.add_return);

		object set37_tree=null;

		try { DebugEnterRule(GrammarFileName, "compare");
		DebugLocation(66, 60);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 13)) { return retval; }
			// MathLang.g:66:8: ( add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )? )
			DebugEnterAlt(1);
			// MathLang.g:66:10: add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(66, 10);
			PushFollow(Follow._add_in_compare498);
			add36=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add36.Tree);
			DebugLocation(66, 14);
			// MathLang.g:66:14: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
			int alt6=2;
			try { DebugEnterSubRule(6);
			try { DebugEnterDecision(6, decisionCanBacktrack[6]);
			int LA6_0 = input.LA(1);

			if (((LA6_0>=NEQ && LA6_0<=EQ)))
			{
				int LA6_1 = input.LA(2);

				if ((EvaluatePredicate(synpred20_MathLang_fragment)))
				{
					alt6=1;
				}
			}
			else if (((LA6_0>=GREQ && LA6_0<=LSEQ)||(LA6_0>=GR && LA6_0<=LS)))
			{
				alt6=1;
			}
			} finally { DebugExitDecision(6); }
			switch (alt6)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:66:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
				{
				DebugLocation(66, 16);
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

				DebugLocation(66, 53);
				PushFollow(Follow._add_in_compare528);
				add38=add();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add38.Tree);

				}
				break;

			}
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
			TraceOut("compare", 13);
			LeaveRule("compare", 13);
			Leave_compare();
			if (state.backtracking > 0) { Memoize(input, 13, compare_StartIndex); }
		}
		DebugLocation(66, 60);
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
	// MathLang.g:68:1: term : add ;
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

		MathLangParser.add_return add39 = default(MathLangParser.add_return);


		try { DebugEnterRule(GrammarFileName, "term");
		DebugLocation(68, 9);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 14)) { return retval; }
			// MathLang.g:68:5: ( add )
			DebugEnterAlt(1);
			// MathLang.g:68:7: add
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(68, 7);
			PushFollow(Follow._add_in_term540);
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
			TraceOut("term", 14);
			LeaveRule("term", 14);
			Leave_term();
			if (state.backtracking > 0) { Memoize(input, 14, term_StartIndex); }
		}
		DebugLocation(68, 9);
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
	// MathLang.g:70:1: group : ( '(' term ')' | number );
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

		IToken char_literal40=null;
		IToken char_literal42=null;
		MathLangParser.term_return term41 = default(MathLangParser.term_return);
		MathLangParser.number_return number43 = default(MathLangParser.number_return);

		object char_literal40_tree=null;
		object char_literal42_tree=null;

		try { DebugEnterRule(GrammarFileName, "group");
		DebugLocation(70, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 15)) { return retval; }
			// MathLang.g:70:6: ( '(' term ')' | number )
			int alt7=2;
			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
			int LA7_0 = input.LA(1);

			if ((LA7_0==43))
			{
				alt7=1;
			}
			else if (((LA7_0>=NUMBER && LA7_0<=CHAR)))
			{
				alt7=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 7, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(7); }
			switch (alt7)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:70:8: '(' term ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(70, 11);
				char_literal40=(IToken)Match(input,43,Follow._43_in_group547); if (state.failed) return retval;
				DebugLocation(70, 13);
				PushFollow(Follow._term_in_group550);
				term41=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term41.Tree);
				DebugLocation(70, 21);
				char_literal42=(IToken)Match(input,44,Follow._44_in_group552); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:70:25: number
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(70, 25);
				PushFollow(Follow._number_in_group557);
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
			TraceOut("group", 15);
			LeaveRule("group", 15);
			Leave_group();
			if (state.backtracking > 0) { Memoize(input, 15, group_StartIndex); }
		}
		DebugLocation(70, 30);
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
	// MathLang.g:72:1: assignment : ID ASSIGN expression ';' ;
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

		IToken ID44=null;
		IToken ASSIGN45=null;
		IToken char_literal47=null;
		MathLangParser.expression_return expression46 = default(MathLangParser.expression_return);

		object ID44_tree=null;
		object ASSIGN45_tree=null;
		object char_literal47_tree=null;

		try { DebugEnterRule(GrammarFileName, "assignment");
		DebugLocation(72, 38);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 16)) { return retval; }
			// MathLang.g:72:11: ( ID ASSIGN expression ';' )
			DebugEnterAlt(1);
			// MathLang.g:72:13: ID ASSIGN expression ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(72, 13);
			ID44=(IToken)Match(input,ID,Follow._ID_in_assignment564); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			ID44_tree = (object)adaptor.Create(ID44);
			adaptor.AddChild(root_0, ID44_tree);
			}
			DebugLocation(72, 22);
			ASSIGN45=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignment566); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			ASSIGN45_tree = (object)adaptor.Create(ASSIGN45);
			root_0 = (object)adaptor.BecomeRoot(ASSIGN45_tree, root_0);
			}
			DebugLocation(72, 24);
			PushFollow(Follow._expression_in_assignment569);
			expression46=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression46.Tree);
			DebugLocation(72, 38);
			char_literal47=(IToken)Match(input,42,Follow._42_in_assignment571); if (state.failed) return retval;

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
		DebugLocation(72, 38);
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
	// MathLang.g:73:1: assignmentbody : ID ASSIGN expression ;
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

		IToken ID48=null;
		IToken ASSIGN49=null;
		MathLangParser.expression_return expression50 = default(MathLangParser.expression_return);

		object ID48_tree=null;
		object ASSIGN49_tree=null;

		try { DebugEnterRule(GrammarFileName, "assignmentbody");
		DebugLocation(73, 38);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 17)) { return retval; }
			// MathLang.g:73:15: ( ID ASSIGN expression )
			DebugEnterAlt(1);
			// MathLang.g:73:17: ID ASSIGN expression
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(73, 17);
			ID48=(IToken)Match(input,ID,Follow._ID_in_assignmentbody578); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			ID48_tree = (object)adaptor.Create(ID48);
			adaptor.AddChild(root_0, ID48_tree);
			}
			DebugLocation(73, 26);
			ASSIGN49=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignmentbody580); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			ASSIGN49_tree = (object)adaptor.Create(ASSIGN49);
			root_0 = (object)adaptor.BecomeRoot(ASSIGN49_tree, root_0);
			}
			DebugLocation(73, 28);
			PushFollow(Follow._expression_in_assignmentbody583);
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
			TraceOut("assignmentbody", 17);
			LeaveRule("assignmentbody", 17);
			Leave_assignmentbody();
			if (state.backtracking > 0) { Memoize(input, 17, assignmentbody_StartIndex); }
		}
		DebugLocation(73, 38);
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
	// MathLang.g:75:1: boolexpression : boolterm ;
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

		MathLangParser.boolterm_return boolterm51 = default(MathLangParser.boolterm_return);


		try { DebugEnterRule(GrammarFileName, "boolexpression");
		DebugLocation(75, 24);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 18)) { return retval; }
			// MathLang.g:75:15: ( boolterm )
			DebugEnterAlt(1);
			// MathLang.g:75:17: boolterm
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(75, 17);
			PushFollow(Follow._boolterm_in_boolexpression591);
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
			TraceOut("boolexpression", 18);
			LeaveRule("boolexpression", 18);
			Leave_boolexpression();
			if (state.backtracking > 0) { Memoize(input, 18, boolexpression_StartIndex); }
		}
		DebugLocation(75, 24);
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
	// MathLang.g:76:1: boolterm : or ( ( EQ | NEQ ) or )? ;
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

		IToken set53=null;
		MathLangParser.or_return or52 = default(MathLangParser.or_return);
		MathLangParser.or_return or54 = default(MathLangParser.or_return);

		object set53_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolterm");
		DebugLocation(76, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 19)) { return retval; }
			// MathLang.g:76:9: ( or ( ( EQ | NEQ ) or )? )
			DebugEnterAlt(1);
			// MathLang.g:76:11: or ( ( EQ | NEQ ) or )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(76, 11);
			PushFollow(Follow._or_in_boolterm597);
			or52=or();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or52.Tree);
			DebugLocation(76, 14);
			// MathLang.g:76:14: ( ( EQ | NEQ ) or )?
			int alt8=2;
			try { DebugEnterSubRule(8);
			try { DebugEnterDecision(8, decisionCanBacktrack[8]);
			int LA8_0 = input.LA(1);

			if (((LA8_0>=NEQ && LA8_0<=EQ)))
			{
				alt8=1;
			}
			} finally { DebugExitDecision(8); }
			switch (alt8)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:76:16: ( EQ | NEQ ) or
				{
				DebugLocation(76, 16);
				set53=(IToken)input.LT(1);
				set53=(IToken)input.LT(1);
				if ((input.LA(1)>=NEQ && input.LA(1)<=EQ))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set53), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(76, 28);
				PushFollow(Follow._or_in_boolterm610);
				or54=or();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or54.Tree);

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
			TraceOut("boolterm", 19);
			LeaveRule("boolterm", 19);
			Leave_boolterm();
			if (state.backtracking > 0) { Memoize(input, 19, boolterm_StartIndex); }
		}
		DebugLocation(76, 32);
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
	// MathLang.g:77:1: or : and ( OR and )* ;
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

		IToken OR56=null;
		MathLangParser.and_return and55 = default(MathLangParser.and_return);
		MathLangParser.and_return and57 = default(MathLangParser.and_return);

		object OR56_tree=null;

		try { DebugEnterRule(GrammarFileName, "or");
		DebugLocation(77, 18);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 20)) { return retval; }
			// MathLang.g:77:3: ( and ( OR and )* )
			DebugEnterAlt(1);
			// MathLang.g:77:5: and ( OR and )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(77, 5);
			PushFollow(Follow._and_in_or619);
			and55=and();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and55.Tree);
			DebugLocation(77, 9);
			// MathLang.g:77:9: ( OR and )*
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
					// MathLang.g:77:10: OR and
					{
					DebugLocation(77, 12);
					OR56=(IToken)Match(input,OR,Follow._OR_in_or622); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR56_tree = (object)adaptor.Create(OR56);
					root_0 = (object)adaptor.BecomeRoot(OR56_tree, root_0);
					}
					DebugLocation(77, 14);
					PushFollow(Follow._and_in_or625);
					and57=and();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and57.Tree);

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
			TraceOut("or", 20);
			LeaveRule("or", 20);
			Leave_or();
			if (state.backtracking > 0) { Memoize(input, 20, or_StartIndex); }
		}
		DebugLocation(77, 18);
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
	// MathLang.g:78:1: and : boolgroup ( AND boolgroup )* ;
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

		IToken AND59=null;
		MathLangParser.boolgroup_return boolgroup58 = default(MathLangParser.boolgroup_return);
		MathLangParser.boolgroup_return boolgroup60 = default(MathLangParser.boolgroup_return);

		object AND59_tree=null;

		try { DebugEnterRule(GrammarFileName, "and");
		DebugLocation(78, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 21)) { return retval; }
			// MathLang.g:78:4: ( boolgroup ( AND boolgroup )* )
			DebugEnterAlt(1);
			// MathLang.g:78:6: boolgroup ( AND boolgroup )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(78, 6);
			PushFollow(Follow._boolgroup_in_and633);
			boolgroup58=boolgroup();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup58.Tree);
			DebugLocation(78, 16);
			// MathLang.g:78:16: ( AND boolgroup )*
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
					// MathLang.g:78:17: AND boolgroup
					{
					DebugLocation(78, 20);
					AND59=(IToken)Match(input,AND,Follow._AND_in_and636); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND59_tree = (object)adaptor.Create(AND59);
					root_0 = (object)adaptor.BecomeRoot(AND59_tree, root_0);
					}
					DebugLocation(78, 22);
					PushFollow(Follow._boolgroup_in_and639);
					boolgroup60=boolgroup();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup60.Tree);

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
			TraceOut("and", 21);
			LeaveRule("and", 21);
			Leave_and();
			if (state.backtracking > 0) { Memoize(input, 21, and_StartIndex); }
		}
		DebugLocation(78, 32);
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
	// MathLang.g:79:1: boolgroup : ( '(' boolterm ')' | boolvar );
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

		IToken char_literal61=null;
		IToken char_literal63=null;
		MathLangParser.boolterm_return boolterm62 = default(MathLangParser.boolterm_return);
		MathLangParser.boolvar_return boolvar64 = default(MathLangParser.boolvar_return);

		object char_literal61_tree=null;
		object char_literal63_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolgroup");
		DebugLocation(79, 39);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 22)) { return retval; }
			// MathLang.g:79:10: ( '(' boolterm ')' | boolvar )
			int alt11=2;
			try { DebugEnterDecision(11, decisionCanBacktrack[11]);
			int LA11_0 = input.LA(1);

			if ((LA11_0==43))
			{
				int LA11_1 = input.LA(2);

				if ((EvaluatePredicate(synpred26_MathLang_fragment)))
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
			else if (((LA11_0>=NUMBER && LA11_0<=CHAR)||(LA11_0>=TRUE && LA11_0<=FALSE)))
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
				// MathLang.g:79:12: '(' boolterm ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(79, 15);
				char_literal61=(IToken)Match(input,43,Follow._43_in_boolgroup647); if (state.failed) return retval;
				DebugLocation(79, 17);
				PushFollow(Follow._boolterm_in_boolgroup650);
				boolterm62=boolterm();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm62.Tree);
				DebugLocation(79, 29);
				char_literal63=(IToken)Match(input,44,Follow._44_in_boolgroup652); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:79:33: boolvar
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(79, 33);
				PushFollow(Follow._boolvar_in_boolgroup657);
				boolvar64=boolvar();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolvar64.Tree);

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
			TraceOut("boolgroup", 22);
			LeaveRule("boolgroup", 22);
			Leave_boolgroup();
			if (state.backtracking > 0) { Memoize(input, 22, boolgroup_StartIndex); }
		}
		DebugLocation(79, 39);
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
	// MathLang.g:80:1: boolvar : ( TRUE | FALSE | compare );
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

		IToken TRUE65=null;
		IToken FALSE66=null;
		MathLangParser.compare_return compare67 = default(MathLangParser.compare_return);

		object TRUE65_tree=null;
		object FALSE66_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolvar");
		DebugLocation(80, 11);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 23)) { return retval; }
			// MathLang.g:80:8: ( TRUE | FALSE | compare )
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
			case CHAR:
			case 43:
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
				// MathLang.g:80:10: TRUE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(80, 10);
				TRUE65=(IToken)Match(input,TRUE,Follow._TRUE_in_boolvar663); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				TRUE65_tree = (object)adaptor.Create(TRUE65);
				adaptor.AddChild(root_0, TRUE65_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:81:5: FALSE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(81, 5);
				FALSE66=(IToken)Match(input,FALSE,Follow._FALSE_in_boolvar669); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				FALSE66_tree = (object)adaptor.Create(FALSE66);
				adaptor.AddChild(root_0, FALSE66_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:82:5: compare
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(82, 5);
				PushFollow(Follow._compare_in_boolvar675);
				compare67=compare();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare67.Tree);

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
		DebugLocation(82, 11);
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
		EnterRule("ifstatement", 24);
		TraceIn("ifstatement", 24);
		MathLangParser.ifstatement_return retval = new MathLangParser.ifstatement_return();
		retval.Start = (IToken)input.LT(1);
		int ifstatement_StartIndex = input.Index;
		object root_0 = null;

		IToken IF68=null;
		IToken char_literal69=null;
		IToken char_literal71=null;
		IToken ELSE74=null;
		MathLangParser.boolexpression_return boolexpression70 = default(MathLangParser.boolexpression_return);
		MathLangParser.block_return block72 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement73 = default(MathLangParser.statement_return);
		MathLangParser.block_return block75 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement76 = default(MathLangParser.statement_return);

		object IF68_tree=null;
		object char_literal69_tree=null;
		object char_literal71_tree=null;
		object ELSE74_tree=null;

		try { DebugEnterRule(GrammarFileName, "ifstatement");
		DebugLocation(84, 91);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 24)) { return retval; }
			// MathLang.g:84:12: ( IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )* )
			DebugEnterAlt(1);
			// MathLang.g:84:14: IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(84, 16);
			IF68=(IToken)Match(input,IF,Follow._IF_in_ifstatement682); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			IF68_tree = (object)adaptor.Create(IF68);
			root_0 = (object)adaptor.BecomeRoot(IF68_tree, root_0);
			}
			DebugLocation(84, 21);
			char_literal69=(IToken)Match(input,43,Follow._43_in_ifstatement685); if (state.failed) return retval;
			DebugLocation(84, 23);
			PushFollow(Follow._boolexpression_in_ifstatement688);
			boolexpression70=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression70.Tree);
			DebugLocation(84, 41);
			char_literal71=(IToken)Match(input,44,Follow._44_in_ifstatement690); if (state.failed) return retval;
			DebugLocation(84, 43);
			// MathLang.g:84:43: ( block | statement )
			int alt13=2;
			try { DebugEnterSubRule(13);
			try { DebugEnterDecision(13, decisionCanBacktrack[13]);
			int LA13_0 = input.LA(1);

			if ((LA13_0==46))
			{
				alt13=1;
			}
			else if ((LA13_0==IF||LA13_0==FOR||LA13_0==WHILE||LA13_0==ID||LA13_0==TYPE))
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
				PushFollow(Follow._block_in_ifstatement694);
				block72=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block72.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:84:52: statement
				{
				DebugLocation(84, 52);
				PushFollow(Follow._statement_in_ifstatement698);
				statement73=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement73.Tree);

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
					int LA15_1 = input.LA(2);

					if ((EvaluatePredicate(synpred31_MathLang_fragment)))
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
					ELSE74=(IToken)Match(input,ELSE,Follow._ELSE_in_ifstatement702); if (state.failed) return retval;
					DebugLocation(84, 70);
					// MathLang.g:84:70: ( block | statement )
					int alt14=2;
					try { DebugEnterSubRule(14);
					try { DebugEnterDecision(14, decisionCanBacktrack[14]);
					int LA14_0 = input.LA(1);

					if ((LA14_0==46))
					{
						alt14=1;
					}
					else if ((LA14_0==IF||LA14_0==FOR||LA14_0==WHILE||LA14_0==ID||LA14_0==TYPE))
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
						PushFollow(Follow._block_in_ifstatement706);
						block75=block();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block75.Tree);

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// MathLang.g:84:79: statement
						{
						DebugLocation(84, 79);
						PushFollow(Follow._statement_in_ifstatement710);
						statement76=statement();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement76.Tree);

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
			TraceOut("ifstatement", 24);
			LeaveRule("ifstatement", 24);
			Leave_ifstatement();
			if (state.backtracking > 0) { Memoize(input, 24, ifstatement_StartIndex); }
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
		EnterRule("whilestatement", 25);
		TraceIn("whilestatement", 25);
		MathLangParser.whilestatement_return retval = new MathLangParser.whilestatement_return();
		retval.Start = (IToken)input.LT(1);
		int whilestatement_StartIndex = input.Index;
		object root_0 = null;

		IToken WHILE77=null;
		IToken char_literal78=null;
		IToken char_literal80=null;
		MathLangParser.boolexpression_return boolexpression79 = default(MathLangParser.boolexpression_return);
		MathLangParser.block_return block81 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement82 = default(MathLangParser.statement_return);

		object WHILE77_tree=null;
		object char_literal78_tree=null;
		object char_literal80_tree=null;

		try { DebugEnterRule(GrammarFileName, "whilestatement");
		DebugLocation(86, 67);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 25)) { return retval; }
			// MathLang.g:86:15: ( WHILE '(' boolexpression ')' ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:86:17: WHILE '(' boolexpression ')' ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(86, 22);
			WHILE77=(IToken)Match(input,WHILE,Follow._WHILE_in_whilestatement721); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			WHILE77_tree = (object)adaptor.Create(WHILE77);
			root_0 = (object)adaptor.BecomeRoot(WHILE77_tree, root_0);
			}
			DebugLocation(86, 27);
			char_literal78=(IToken)Match(input,43,Follow._43_in_whilestatement724); if (state.failed) return retval;
			DebugLocation(86, 29);
			PushFollow(Follow._boolexpression_in_whilestatement727);
			boolexpression79=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression79.Tree);
			DebugLocation(86, 47);
			char_literal80=(IToken)Match(input,44,Follow._44_in_whilestatement729); if (state.failed) return retval;
			DebugLocation(86, 49);
			// MathLang.g:86:49: ( block | statement )
			int alt16=2;
			try { DebugEnterSubRule(16);
			try { DebugEnterDecision(16, decisionCanBacktrack[16]);
			int LA16_0 = input.LA(1);

			if ((LA16_0==46))
			{
				alt16=1;
			}
			else if ((LA16_0==IF||LA16_0==FOR||LA16_0==WHILE||LA16_0==ID||LA16_0==TYPE))
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
				PushFollow(Follow._block_in_whilestatement733);
				block81=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block81.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:86:58: statement
				{
				DebugLocation(86, 58);
				PushFollow(Follow._statement_in_whilestatement737);
				statement82=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement82.Tree);

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
			TraceOut("whilestatement", 25);
			LeaveRule("whilestatement", 25);
			Leave_whilestatement();
			if (state.backtracking > 0) { Memoize(input, 25, whilestatement_StartIndex); }
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
		EnterRule("forstatement", 26);
		TraceIn("forstatement", 26);
		MathLangParser.forstatement_return retval = new MathLangParser.forstatement_return();
		retval.Start = (IToken)input.LT(1);
		int forstatement_StartIndex = input.Index;
		object root_0 = null;

		IToken FOR83=null;
		IToken char_literal84=null;
		IToken char_literal86=null;
		IToken char_literal88=null;
		IToken char_literal90=null;
		MathLangParser.longdeclarationbody_return longdeclarationbody85 = default(MathLangParser.longdeclarationbody_return);
		MathLangParser.boolexpression_return boolexpression87 = default(MathLangParser.boolexpression_return);
		MathLangParser.assignmentbody_return assignmentbody89 = default(MathLangParser.assignmentbody_return);
		MathLangParser.block_return block91 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement92 = default(MathLangParser.statement_return);

		object FOR83_tree=null;
		object char_literal84_tree=null;
		object char_literal86_tree=null;
		object char_literal88_tree=null;
		object char_literal90_tree=null;

		try { DebugEnterRule(GrammarFileName, "forstatement");
		DebugLocation(88, 108);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 26)) { return retval; }
			// MathLang.g:88:13: ( FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:88:15: FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(88, 18);
			FOR83=(IToken)Match(input,FOR,Follow._FOR_in_forstatement745); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			FOR83_tree = (object)adaptor.Create(FOR83);
			root_0 = (object)adaptor.BecomeRoot(FOR83_tree, root_0);
			}
			DebugLocation(88, 23);
			char_literal84=(IToken)Match(input,43,Follow._43_in_forstatement748); if (state.failed) return retval;
			DebugLocation(88, 25);
			PushFollow(Follow._longdeclarationbody_in_forstatement751);
			longdeclarationbody85=longdeclarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclarationbody85.Tree);
			DebugLocation(88, 48);
			char_literal86=(IToken)Match(input,42,Follow._42_in_forstatement753); if (state.failed) return retval;
			DebugLocation(88, 50);
			PushFollow(Follow._boolexpression_in_forstatement756);
			boolexpression87=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression87.Tree);
			DebugLocation(88, 68);
			char_literal88=(IToken)Match(input,42,Follow._42_in_forstatement758); if (state.failed) return retval;
			DebugLocation(88, 70);
			PushFollow(Follow._assignmentbody_in_forstatement761);
			assignmentbody89=assignmentbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentbody89.Tree);
			DebugLocation(88, 88);
			char_literal90=(IToken)Match(input,44,Follow._44_in_forstatement763); if (state.failed) return retval;
			DebugLocation(88, 90);
			// MathLang.g:88:90: ( block | statement )
			int alt17=2;
			try { DebugEnterSubRule(17);
			try { DebugEnterDecision(17, decisionCanBacktrack[17]);
			int LA17_0 = input.LA(1);

			if ((LA17_0==46))
			{
				alt17=1;
			}
			else if ((LA17_0==IF||LA17_0==FOR||LA17_0==WHILE||LA17_0==ID||LA17_0==TYPE))
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
				// MathLang.g:88:91: block
				{
				DebugLocation(88, 91);
				PushFollow(Follow._block_in_forstatement767);
				block91=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block91.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:88:99: statement
				{
				DebugLocation(88, 99);
				PushFollow(Follow._statement_in_forstatement771);
				statement92=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement92.Tree);

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
			TraceOut("forstatement", 26);
			LeaveRule("forstatement", 26);
			Leave_forstatement();
			if (state.backtracking > 0) { Memoize(input, 26, forstatement_StartIndex); }
		}
		DebugLocation(88, 108);
		} finally { DebugExitRule(GrammarFileName, "forstatement"); }
		return retval;

	}
	// $ANTLR end "forstatement"

	public class funcdeclaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_funcdeclaration();
	partial void Leave_funcdeclaration();

	// $ANTLR start "funcdeclaration"
	// MathLang.g:90:1: funcdeclaration : TYPE ID '(' ( paramsdeclaration )? ')' block ;
	[GrammarRule("funcdeclaration")]
	private MathLangParser.funcdeclaration_return funcdeclaration()
	{
		Enter_funcdeclaration();
		EnterRule("funcdeclaration", 27);
		TraceIn("funcdeclaration", 27);
		MathLangParser.funcdeclaration_return retval = new MathLangParser.funcdeclaration_return();
		retval.Start = (IToken)input.LT(1);
		int funcdeclaration_StartIndex = input.Index;
		object root_0 = null;

		IToken TYPE93=null;
		IToken ID94=null;
		IToken char_literal95=null;
		IToken char_literal97=null;
		MathLangParser.paramsdeclaration_return paramsdeclaration96 = default(MathLangParser.paramsdeclaration_return);
		MathLangParser.block_return block98 = default(MathLangParser.block_return);

		object TYPE93_tree=null;
		object ID94_tree=null;
		object char_literal95_tree=null;
		object char_literal97_tree=null;

		try { DebugEnterRule(GrammarFileName, "funcdeclaration");
		DebugLocation(90, 60);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 27)) { return retval; }
			// MathLang.g:90:16: ( TYPE ID '(' ( paramsdeclaration )? ')' block )
			DebugEnterAlt(1);
			// MathLang.g:90:18: TYPE ID '(' ( paramsdeclaration )? ')' block
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(90, 18);
			TYPE93=(IToken)Match(input,TYPE,Follow._TYPE_in_funcdeclaration779); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			TYPE93_tree = (object)adaptor.Create(TYPE93);
			adaptor.AddChild(root_0, TYPE93_tree);
			}
			DebugLocation(90, 25);
			ID94=(IToken)Match(input,ID,Follow._ID_in_funcdeclaration781); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			ID94_tree = (object)adaptor.Create(ID94);
			root_0 = (object)adaptor.BecomeRoot(ID94_tree, root_0);
			}
			DebugLocation(90, 30);
			char_literal95=(IToken)Match(input,43,Follow._43_in_funcdeclaration784); if (state.failed) return retval;
			DebugLocation(90, 32);
			// MathLang.g:90:32: ( paramsdeclaration )?
			int alt18=2;
			try { DebugEnterSubRule(18);
			try { DebugEnterDecision(18, decisionCanBacktrack[18]);
			int LA18_0 = input.LA(1);

			if ((LA18_0==TYPE))
			{
				alt18=1;
			}
			} finally { DebugExitDecision(18); }
			switch (alt18)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: paramsdeclaration
				{
				DebugLocation(90, 32);
				PushFollow(Follow._paramsdeclaration_in_funcdeclaration787);
				paramsdeclaration96=paramsdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, paramsdeclaration96.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(18); }

			DebugLocation(90, 54);
			char_literal97=(IToken)Match(input,44,Follow._44_in_funcdeclaration790); if (state.failed) return retval;
			DebugLocation(90, 56);
			PushFollow(Follow._block_in_funcdeclaration793);
			block98=block();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block98.Tree);

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
			TraceOut("funcdeclaration", 27);
			LeaveRule("funcdeclaration", 27);
			Leave_funcdeclaration();
			if (state.backtracking > 0) { Memoize(input, 27, funcdeclaration_StartIndex); }
		}
		DebugLocation(90, 60);
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
	// MathLang.g:92:1: paramsdeclaration : ( declarationbody ( ',' declarationbody )* ) -> ^( PARAMETERS ( declarationbody )* ) ;
	[GrammarRule("paramsdeclaration")]
	private MathLangParser.paramsdeclaration_return paramsdeclaration()
	{
		Enter_paramsdeclaration();
		EnterRule("paramsdeclaration", 28);
		TraceIn("paramsdeclaration", 28);
		MathLangParser.paramsdeclaration_return retval = new MathLangParser.paramsdeclaration_return();
		retval.Start = (IToken)input.LT(1);
		int paramsdeclaration_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal100=null;
		MathLangParser.declarationbody_return declarationbody99 = default(MathLangParser.declarationbody_return);
		MathLangParser.declarationbody_return declarationbody101 = default(MathLangParser.declarationbody_return);

		object char_literal100_tree=null;
		RewriteRuleITokenStream stream_45=new RewriteRuleITokenStream(adaptor,"token 45");
		RewriteRuleSubtreeStream stream_declarationbody=new RewriteRuleSubtreeStream(adaptor,"rule declarationbody");
		try { DebugEnterRule(GrammarFileName, "paramsdeclaration");
		DebugLocation(92, 99);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 28)) { return retval; }
			// MathLang.g:92:18: ( ( declarationbody ( ',' declarationbody )* ) -> ^( PARAMETERS ( declarationbody )* ) )
			DebugEnterAlt(1);
			// MathLang.g:92:20: ( declarationbody ( ',' declarationbody )* )
			{
			DebugLocation(92, 20);
			// MathLang.g:92:20: ( declarationbody ( ',' declarationbody )* )
			DebugEnterAlt(1);
			// MathLang.g:92:21: declarationbody ( ',' declarationbody )*
			{
			DebugLocation(92, 21);
			PushFollow(Follow._declarationbody_in_paramsdeclaration801);
			declarationbody99=declarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declarationbody.Add(declarationbody99.Tree);
			DebugLocation(92, 37);
			// MathLang.g:92:37: ( ',' declarationbody )*
			try { DebugEnterSubRule(19);
			while (true)
			{
				int alt19=2;
				try { DebugEnterDecision(19, decisionCanBacktrack[19]);
				int LA19_0 = input.LA(1);

				if ((LA19_0==45))
				{
					alt19=1;
				}


				} finally { DebugExitDecision(19); }
				switch ( alt19 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:92:38: ',' declarationbody
					{
					DebugLocation(92, 41);
					char_literal100=(IToken)Match(input,45,Follow._45_in_paramsdeclaration804); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_45.Add(char_literal100);

					DebugLocation(92, 43);
					PushFollow(Follow._declarationbody_in_paramsdeclaration807);
					declarationbody101=declarationbody();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_declarationbody.Add(declarationbody101.Tree);

					}
					break;

				default:
					goto loop19;
				}
			}

			loop19:
				;

			} finally { DebugExitSubRule(19); }


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
			// 92:64: -> ^( PARAMETERS ( declarationbody )* )
			{
				DebugLocation(92, 67);
				// MathLang.g:92:67: ^( PARAMETERS ( declarationbody )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(92, 69);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_1);

				DebugLocation(92, 80);
				// MathLang.g:92:80: ( declarationbody )*
				while ( stream_declarationbody.HasNext )
				{
					DebugLocation(92, 81);
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
			TraceOut("paramsdeclaration", 28);
			LeaveRule("paramsdeclaration", 28);
			Leave_paramsdeclaration();
			if (state.backtracking > 0) { Memoize(input, 28, paramsdeclaration_StartIndex); }
		}
		DebugLocation(92, 99);
		} finally { DebugExitRule(GrammarFileName, "paramsdeclaration"); }
		return retval;

	}
	// $ANTLR end "paramsdeclaration"

	public class block_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_block();
	partial void Leave_block();

	// $ANTLR start "block"
	// MathLang.g:95:1: block : '{' statementlist '}' ;
	[GrammarRule("block")]
	private MathLangParser.block_return block()
	{
		Enter_block();
		EnterRule("block", 29);
		TraceIn("block", 29);
		MathLangParser.block_return retval = new MathLangParser.block_return();
		retval.Start = (IToken)input.LT(1);
		int block_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal102=null;
		IToken char_literal104=null;
		MathLangParser.statementlist_return statementlist103 = default(MathLangParser.statementlist_return);

		object char_literal102_tree=null;
		object char_literal104_tree=null;

		try { DebugEnterRule(GrammarFileName, "block");
		DebugLocation(95, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 29)) { return retval; }
			// MathLang.g:95:6: ( '{' statementlist '}' )
			DebugEnterAlt(1);
			// MathLang.g:95:8: '{' statementlist '}'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(95, 11);
			char_literal102=(IToken)Match(input,46,Follow._46_in_block832); if (state.failed) return retval;
			DebugLocation(95, 13);
			PushFollow(Follow._statementlist_in_block835);
			statementlist103=statementlist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementlist103.Tree);
			DebugLocation(95, 30);
			char_literal104=(IToken)Match(input,47,Follow._47_in_block837); if (state.failed) return retval;

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
			TraceOut("block", 29);
			LeaveRule("block", 29);
			Leave_block();
			if (state.backtracking > 0) { Memoize(input, 29, block_StartIndex); }
		}
		DebugLocation(95, 30);
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
	// MathLang.g:97:1: statementlist : ( statement )* -> ^( BLOCK ( statement )* ) ;
	[GrammarRule("statementlist")]
	private MathLangParser.statementlist_return statementlist()
	{
		Enter_statementlist();
		EnterRule("statementlist", 30);
		TraceIn("statementlist", 30);
		MathLangParser.statementlist_return retval = new MathLangParser.statementlist_return();
		retval.Start = (IToken)input.LT(1);
		int statementlist_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.statement_return statement105 = default(MathLangParser.statement_return);

		RewriteRuleSubtreeStream stream_statement=new RewriteRuleSubtreeStream(adaptor,"rule statement");
		try { DebugEnterRule(GrammarFileName, "statementlist");
		DebugLocation(97, 49);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 30)) { return retval; }
			// MathLang.g:97:14: ( ( statement )* -> ^( BLOCK ( statement )* ) )
			DebugEnterAlt(1);
			// MathLang.g:97:16: ( statement )*
			{
			DebugLocation(97, 16);
			// MathLang.g:97:16: ( statement )*
			try { DebugEnterSubRule(20);
			while (true)
			{
				int alt20=2;
				try { DebugEnterDecision(20, decisionCanBacktrack[20]);
				int LA20_0 = input.LA(1);

				if ((LA20_0==IF||LA20_0==FOR||LA20_0==WHILE||LA20_0==ID||LA20_0==TYPE))
				{
					alt20=1;
				}


				} finally { DebugExitDecision(20); }
				switch ( alt20 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: statement
					{
					DebugLocation(97, 16);
					PushFollow(Follow._statement_in_statementlist845);
					statement105=statement();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_statement.Add(statement105.Tree);

					}
					break;

				default:
					goto loop20;
				}
			}

			loop20:
				;

			} finally { DebugExitSubRule(20); }



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
			// 97:27: -> ^( BLOCK ( statement )* )
			{
				DebugLocation(97, 30);
				// MathLang.g:97:30: ^( BLOCK ( statement )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(97, 32);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

				DebugLocation(97, 38);
				// MathLang.g:97:38: ( statement )*
				while ( stream_statement.HasNext )
				{
					DebugLocation(97, 38);
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
			TraceOut("statementlist", 30);
			LeaveRule("statementlist", 30);
			Leave_statementlist();
			if (state.backtracking > 0) { Memoize(input, 30, statementlist_StartIndex); }
		}
		DebugLocation(97, 49);
		} finally { DebugExitRule(GrammarFileName, "statementlist"); }
		return retval;

	}
	// $ANTLR end "statementlist"

	partial void Enter_synpred8_MathLang_fragment();
	partial void Leave_synpred8_MathLang_fragment();

	// $ANTLR start synpred8_MathLang
	public void synpred8_MathLang_fragment()
	{
		Enter_synpred8_MathLang_fragment();
		EnterRule("synpred8_MathLang_fragment", 38);
		TraceIn("synpred8_MathLang_fragment", 38);
		try
		{
			// MathLang.g:51:12: ( mathexpression )
			DebugEnterAlt(1);
			// MathLang.g:51:12: mathexpression
			{
			DebugLocation(51, 12);
			PushFollow(Follow._mathexpression_in_synpred8_MathLang337);
			mathexpression();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred8_MathLang_fragment", 38);
			LeaveRule("synpred8_MathLang_fragment", 38);
			Leave_synpred8_MathLang_fragment();
		}
	}
	// $ANTLR end synpred8_MathLang

	partial void Enter_synpred20_MathLang_fragment();
	partial void Leave_synpred20_MathLang_fragment();

	// $ANTLR start synpred20_MathLang
	public void synpred20_MathLang_fragment()
	{
		Enter_synpred20_MathLang_fragment();
		EnterRule("synpred20_MathLang_fragment", 50);
		TraceIn("synpred20_MathLang_fragment", 50);
		try
		{
			// MathLang.g:66:16: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )
			DebugEnterAlt(1);
			// MathLang.g:66:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
			{
			DebugLocation(66, 16);
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

			DebugLocation(66, 53);
			PushFollow(Follow._add_in_synpred20_MathLang528);
			add();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred20_MathLang_fragment", 50);
			LeaveRule("synpred20_MathLang_fragment", 50);
			Leave_synpred20_MathLang_fragment();
		}
	}
	// $ANTLR end synpred20_MathLang

	partial void Enter_synpred26_MathLang_fragment();
	partial void Leave_synpred26_MathLang_fragment();

	// $ANTLR start synpred26_MathLang
	public void synpred26_MathLang_fragment()
	{
		Enter_synpred26_MathLang_fragment();
		EnterRule("synpred26_MathLang_fragment", 56);
		TraceIn("synpred26_MathLang_fragment", 56);
		try
		{
			// MathLang.g:79:12: ( '(' boolterm ')' )
			DebugEnterAlt(1);
			// MathLang.g:79:12: '(' boolterm ')'
			{
			DebugLocation(79, 12);
			Match(input,43,Follow._43_in_synpred26_MathLang647); if (state.failed) return;
			DebugLocation(79, 17);
			PushFollow(Follow._boolterm_in_synpred26_MathLang650);
			boolterm();
			PopFollow();
			if (state.failed) return;
			DebugLocation(79, 26);
			Match(input,44,Follow._44_in_synpred26_MathLang652); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred26_MathLang_fragment", 56);
			LeaveRule("synpred26_MathLang_fragment", 56);
			Leave_synpred26_MathLang_fragment();
		}
	}
	// $ANTLR end synpred26_MathLang

	partial void Enter_synpred31_MathLang_fragment();
	partial void Leave_synpred31_MathLang_fragment();

	// $ANTLR start synpred31_MathLang
	public void synpred31_MathLang_fragment()
	{
		Enter_synpred31_MathLang_fragment();
		EnterRule("synpred31_MathLang_fragment", 61);
		TraceIn("synpred31_MathLang_fragment", 61);
		try
		{
			// MathLang.g:84:64: ( ELSE ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:84:64: ELSE ( block | statement )
			{
			DebugLocation(84, 64);
			Match(input,ELSE,Follow._ELSE_in_synpred31_MathLang702); if (state.failed) return;
			DebugLocation(84, 70);
			// MathLang.g:84:70: ( block | statement )
			int alt21=2;
			try { DebugEnterSubRule(21);
			try { DebugEnterDecision(21, decisionCanBacktrack[21]);
			int LA21_0 = input.LA(1);

			if ((LA21_0==46))
			{
				alt21=1;
			}
			else if ((LA21_0==IF||LA21_0==FOR||LA21_0==WHILE||LA21_0==ID||LA21_0==TYPE))
			{
				alt21=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				NoViableAltException nvae = new NoViableAltException("", 21, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(21); }
			switch (alt21)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:84:71: block
				{
				DebugLocation(84, 71);
				PushFollow(Follow._block_in_synpred31_MathLang706);
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
				PushFollow(Follow._statement_in_synpred31_MathLang710);
				statement();
				PopFollow();
				if (state.failed) return;

				}
				break;

			}
			} finally { DebugExitSubRule(21); }


			}

		}
		finally
		{
			TraceOut("synpred31_MathLang_fragment", 61);
			LeaveRule("synpred31_MathLang_fragment", 61);
			Leave_synpred31_MathLang_fragment();
		}
	}
	// $ANTLR end synpred31_MathLang
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
		public static readonly BitSet _statementlist_in_execute263 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_execute265 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declaration_in_statement276 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assignment_in_statement282 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ifstatement_in_statement287 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _whilestatement_in_statement292 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _forstatement_in_statement297 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funcdeclaration_in_statement302 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_number0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _term_in_mathexpression330 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathexpression_in_expression337 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolexpression_in_expression344 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_declaration351 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _ID_in_declaration354 = new BitSet(new ulong[]{0x40000000000UL});
		public static readonly BitSet _42_in_declaration356 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _longdeclaration_in_declaration364 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_declarationbody371 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _ID_in_declarationbody374 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_longdeclaration381 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _ID_in_longdeclaration383 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _ASSIGN_in_longdeclaration385 = new BitSet(new ulong[]{0x80C00070000UL});
		public static readonly BitSet _expression_in_longdeclaration387 = new BitSet(new ulong[]{0x40000000000UL});
		public static readonly BitSet _42_in_longdeclaration389 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_longdeclarationbody412 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _ID_in_longdeclarationbody414 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _ASSIGN_in_longdeclarationbody416 = new BitSet(new ulong[]{0x80C00070000UL});
		public static readonly BitSet _expression_in_longdeclarationbody418 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_variable440 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _ID_in_variable449 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mul_in_add455 = new BitSet(new ulong[]{0xC00002UL});
		public static readonly BitSet _set_in_add459 = new BitSet(new ulong[]{0x80000070000UL});
		public static readonly BitSet _mul_in_add468 = new BitSet(new ulong[]{0xC00002UL});
		public static readonly BitSet _group_in_mul477 = new BitSet(new ulong[]{0x3000002UL});
		public static readonly BitSet _set_in_mul481 = new BitSet(new ulong[]{0x80000070000UL});
		public static readonly BitSet _group_in_mul490 = new BitSet(new ulong[]{0x3000002UL});
		public static readonly BitSet _add_in_compare498 = new BitSet(new ulong[]{0xFC000002UL});
		public static readonly BitSet _set_in_compare502 = new BitSet(new ulong[]{0x80000070000UL});
		public static readonly BitSet _add_in_compare528 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _add_in_term540 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _43_in_group547 = new BitSet(new ulong[]{0x80000070000UL});
		public static readonly BitSet _term_in_group550 = new BitSet(new ulong[]{0x100000000000UL});
		public static readonly BitSet _44_in_group552 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _number_in_group557 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_assignment564 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _ASSIGN_in_assignment566 = new BitSet(new ulong[]{0x80C00070000UL});
		public static readonly BitSet _expression_in_assignment569 = new BitSet(new ulong[]{0x40000000000UL});
		public static readonly BitSet _42_in_assignment571 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_assignmentbody578 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _ASSIGN_in_assignmentbody580 = new BitSet(new ulong[]{0x80C00070000UL});
		public static readonly BitSet _expression_in_assignmentbody583 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolterm_in_boolexpression591 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _or_in_boolterm597 = new BitSet(new ulong[]{0x30000002UL});
		public static readonly BitSet _set_in_boolterm601 = new BitSet(new ulong[]{0x80C00070000UL});
		public static readonly BitSet _or_in_boolterm610 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _and_in_or619 = new BitSet(new ulong[]{0x100000002UL});
		public static readonly BitSet _OR_in_or622 = new BitSet(new ulong[]{0x80C00070000UL});
		public static readonly BitSet _and_in_or625 = new BitSet(new ulong[]{0x100000002UL});
		public static readonly BitSet _boolgroup_in_and633 = new BitSet(new ulong[]{0x200000002UL});
		public static readonly BitSet _AND_in_and636 = new BitSet(new ulong[]{0x80C00070000UL});
		public static readonly BitSet _boolgroup_in_and639 = new BitSet(new ulong[]{0x200000002UL});
		public static readonly BitSet _43_in_boolgroup647 = new BitSet(new ulong[]{0x80C00070000UL});
		public static readonly BitSet _boolterm_in_boolgroup650 = new BitSet(new ulong[]{0x100000000000UL});
		public static readonly BitSet _44_in_boolgroup652 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolvar_in_boolgroup657 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TRUE_in_boolvar663 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FALSE_in_boolvar669 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _compare_in_boolvar675 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_ifstatement682 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _43_in_ifstatement685 = new BitSet(new ulong[]{0x80C00070000UL});
		public static readonly BitSet _boolexpression_in_ifstatement688 = new BitSet(new ulong[]{0x100000000000UL});
		public static readonly BitSet _44_in_ifstatement690 = new BitSet(new ulong[]{0x4000000A1280UL});
		public static readonly BitSet _block_in_ifstatement694 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement698 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _ELSE_in_ifstatement702 = new BitSet(new ulong[]{0x4000000A1280UL});
		public static readonly BitSet _block_in_ifstatement706 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement710 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _WHILE_in_whilestatement721 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _43_in_whilestatement724 = new BitSet(new ulong[]{0x80C00070000UL});
		public static readonly BitSet _boolexpression_in_whilestatement727 = new BitSet(new ulong[]{0x100000000000UL});
		public static readonly BitSet _44_in_whilestatement729 = new BitSet(new ulong[]{0x4000000A1280UL});
		public static readonly BitSet _block_in_whilestatement733 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_whilestatement737 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_forstatement745 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _43_in_forstatement748 = new BitSet(new ulong[]{0x80000UL});
		public static readonly BitSet _longdeclarationbody_in_forstatement751 = new BitSet(new ulong[]{0x40000000000UL});
		public static readonly BitSet _42_in_forstatement753 = new BitSet(new ulong[]{0x80C00070000UL});
		public static readonly BitSet _boolexpression_in_forstatement756 = new BitSet(new ulong[]{0x40000000000UL});
		public static readonly BitSet _42_in_forstatement758 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _assignmentbody_in_forstatement761 = new BitSet(new ulong[]{0x100000000000UL});
		public static readonly BitSet _44_in_forstatement763 = new BitSet(new ulong[]{0x4000000A1280UL});
		public static readonly BitSet _block_in_forstatement767 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_forstatement771 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_funcdeclaration779 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _ID_in_funcdeclaration781 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _43_in_funcdeclaration784 = new BitSet(new ulong[]{0x100000080000UL});
		public static readonly BitSet _paramsdeclaration_in_funcdeclaration787 = new BitSet(new ulong[]{0x100000000000UL});
		public static readonly BitSet _44_in_funcdeclaration790 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _block_in_funcdeclaration793 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declarationbody_in_paramsdeclaration801 = new BitSet(new ulong[]{0x200000000002UL});
		public static readonly BitSet _45_in_paramsdeclaration804 = new BitSet(new ulong[]{0x80000UL});
		public static readonly BitSet _declarationbody_in_paramsdeclaration807 = new BitSet(new ulong[]{0x200000000002UL});
		public static readonly BitSet _46_in_block832 = new BitSet(new ulong[]{0xC000000A1280UL});
		public static readonly BitSet _statementlist_in_block835 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _47_in_block837 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_statementlist845 = new BitSet(new ulong[]{0x4000000A1282UL});
		public static readonly BitSet _mathexpression_in_synpred8_MathLang337 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_synpred20_MathLang502 = new BitSet(new ulong[]{0x80000070000UL});
		public static readonly BitSet _add_in_synpred20_MathLang528 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _43_in_synpred26_MathLang647 = new BitSet(new ulong[]{0x80C00070000UL});
		public static readonly BitSet _boolterm_in_synpred26_MathLang650 = new BitSet(new ulong[]{0x100000000000UL});
		public static readonly BitSet _44_in_synpred26_MathLang652 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ELSE_in_synpred31_MathLang702 = new BitSet(new ulong[]{0x4000000A1280UL});
		public static readonly BitSet _block_in_synpred31_MathLang706 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_synpred31_MathLang710 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  MathLang 

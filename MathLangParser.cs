// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-10-01 16:00:29

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
				false, true, false, false, false, false, false, false, false, true, 
				false, false, false, true, false, false
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
		this.state.ruleMemo = new System.Collections.Generic.Dictionary<int, int>[49+1];

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
	// MathLang.g:39:1: statement : ( declaration | assignment | ifstatement ) ;
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


		try { DebugEnterRule(GrammarFileName, "statement");
		DebugLocation(39, 16);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 2)) { return retval; }
			// MathLang.g:39:10: ( ( declaration | assignment | ifstatement ) )
			DebugEnterAlt(1);
			// MathLang.g:39:12: ( declaration | assignment | ifstatement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(39, 12);
			// MathLang.g:39:12: ( declaration | assignment | ifstatement )
			int alt1=3;
			try { DebugEnterSubRule(1);
			try { DebugEnterDecision(1, decisionCanBacktrack[1]);
			switch (input.LA(1))
			{
			case TYPE:
				{
				alt1=1;
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
		DebugLocation(41, 16);
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
	// MathLang.g:43:1: number : ( NUMBER | ID );
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

		IToken set6=null;

		object set6_tree=null;

		try { DebugEnterRule(GrammarFileName, "number");
		DebugLocation(43, 6);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 3)) { return retval; }
			// MathLang.g:43:8: ( NUMBER | ID )
			DebugEnterAlt(1);
			// MathLang.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(43, 8);
			set6=(IToken)input.LT(1);
			if ((input.LA(1)>=NUMBER && input.LA(1)<=ID))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set6));
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
		DebugLocation(44, 6);
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
	// MathLang.g:45:1: mathexpression : term ;
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

		MathLangParser.term_return term7 = default(MathLangParser.term_return);


		try { DebugEnterRule(GrammarFileName, "mathexpression");
		DebugLocation(45, 21);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 4)) { return retval; }
			// MathLang.g:45:15: ( term )
			DebugEnterAlt(1);
			// MathLang.g:45:17: term
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(45, 17);
			PushFollow(Follow._term_in_mathexpression309);
			term7=term();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term7.Tree);

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
		DebugLocation(45, 21);
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
	// MathLang.g:47:1: expression : ( mathexpression | boolexpression );
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

		MathLangParser.mathexpression_return mathexpression8 = default(MathLangParser.mathexpression_return);
		MathLangParser.boolexpression_return boolexpression9 = default(MathLangParser.boolexpression_return);


		try { DebugEnterRule(GrammarFileName, "expression");
		DebugLocation(47, 19);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 5)) { return retval; }
			// MathLang.g:47:11: ( mathexpression | boolexpression )
			int alt2=2;
			try { DebugEnterDecision(2, decisionCanBacktrack[2]);
			switch (input.LA(1))
			{
			case 40:
				{
				int LA2_1 = input.LA(2);

				if ((EvaluatePredicate(synpred4_MathLang_fragment)))
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
				{
				int LA2_2 = input.LA(2);

				if ((EvaluatePredicate(synpred4_MathLang_fragment)))
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
				// MathLang.g:47:12: mathexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(47, 12);
				PushFollow(Follow._mathexpression_in_expression316);
				mathexpression8=mathexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mathexpression8.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:48:6: boolexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(48, 6);
				PushFollow(Follow._boolexpression_in_expression323);
				boolexpression9=boolexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression9.Tree);

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
		DebugLocation(48, 19);
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
	// MathLang.g:50:1: declaration : ( TYPE ID ';' | longdeclaration );
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

		IToken TYPE10=null;
		IToken ID11=null;
		IToken char_literal12=null;
		MathLangParser.longdeclaration_return longdeclaration13 = default(MathLangParser.longdeclaration_return);

		object TYPE10_tree=null;
		object ID11_tree=null;
		object char_literal12_tree=null;

		try { DebugEnterRule(GrammarFileName, "declaration");
		DebugLocation(50, 20);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 6)) { return retval; }
			// MathLang.g:50:12: ( TYPE ID ';' | longdeclaration )
			int alt3=2;
			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
			int LA3_0 = input.LA(1);

			if ((LA3_0==TYPE))
			{
				int LA3_1 = input.LA(2);

				if ((LA3_1==ID))
				{
					int LA3_2 = input.LA(3);

					if ((LA3_2==39))
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
				// MathLang.g:50:14: TYPE ID ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(50, 18);
				TYPE10=(IToken)Match(input,TYPE,Follow._TYPE_in_declaration330); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				TYPE10_tree = (object)adaptor.Create(TYPE10);
				root_0 = (object)adaptor.BecomeRoot(TYPE10_tree, root_0);
				}
				DebugLocation(50, 20);
				ID11=(IToken)Match(input,ID,Follow._ID_in_declaration333); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				ID11_tree = (object)adaptor.Create(ID11);
				adaptor.AddChild(root_0, ID11_tree);
				}
				DebugLocation(50, 26);
				char_literal12=(IToken)Match(input,39,Follow._39_in_declaration335); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:51:6: longdeclaration
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(51, 6);
				PushFollow(Follow._longdeclaration_in_declaration343);
				longdeclaration13=longdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclaration13.Tree);

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
		DebugLocation(51, 20);
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
	// MathLang.g:52:1: longdeclaration : TYPE ID ASSIGN expression ';' -> ^( ASSIGN ^( TYPE ID ) expression ) ;
	[GrammarRule("longdeclaration")]
	private MathLangParser.longdeclaration_return longdeclaration()
	{
		Enter_longdeclaration();
		EnterRule("longdeclaration", 7);
		TraceIn("longdeclaration", 7);
		MathLangParser.longdeclaration_return retval = new MathLangParser.longdeclaration_return();
		retval.Start = (IToken)input.LT(1);
		int longdeclaration_StartIndex = input.Index;
		object root_0 = null;

		IToken TYPE14=null;
		IToken ID15=null;
		IToken ASSIGN16=null;
		IToken char_literal18=null;
		MathLangParser.expression_return expression17 = default(MathLangParser.expression_return);

		object TYPE14_tree=null;
		object ID15_tree=null;
		object ASSIGN16_tree=null;
		object char_literal18_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_39=new RewriteRuleITokenStream(adaptor,"token 39");
		RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "longdeclaration");
		DebugLocation(52, 82);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 7)) { return retval; }
			// MathLang.g:52:16: ( TYPE ID ASSIGN expression ';' -> ^( ASSIGN ^( TYPE ID ) expression ) )
			DebugEnterAlt(1);
			// MathLang.g:52:17: TYPE ID ASSIGN expression ';'
			{
			DebugLocation(52, 17);
			TYPE14=(IToken)Match(input,TYPE,Follow._TYPE_in_longdeclaration348); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE14);

			DebugLocation(52, 22);
			ID15=(IToken)Match(input,ID,Follow._ID_in_longdeclaration350); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID15);

			DebugLocation(52, 25);
			ASSIGN16=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclaration352); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN16);

			DebugLocation(52, 32);
			PushFollow(Follow._expression_in_longdeclaration354);
			expression17=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression17.Tree);
			DebugLocation(52, 46);
			char_literal18=(IToken)Match(input,39,Follow._39_in_longdeclaration356); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_39.Add(char_literal18);



			{
			// AST REWRITE
			// elements: ID, ASSIGN, expression, TYPE
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 52:48: -> ^( ASSIGN ^( TYPE ID ) expression )
			{
				DebugLocation(52, 51);
				// MathLang.g:52:51: ^( ASSIGN ^( TYPE ID ) expression )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(52, 53);
				root_1 = (object)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_1);

				DebugLocation(52, 60);
				// MathLang.g:52:60: ^( TYPE ID )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(52, 62);
				root_2 = (object)adaptor.BecomeRoot(stream_TYPE.NextNode(), root_2);

				DebugLocation(52, 67);
				adaptor.AddChild(root_2, stream_ID.NextNode());

				adaptor.AddChild(root_1, root_2);
				}
				DebugLocation(52, 71);
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
			TraceOut("longdeclaration", 7);
			LeaveRule("longdeclaration", 7);
			Leave_longdeclaration();
			if (state.backtracking > 0) { Memoize(input, 7, longdeclaration_StartIndex); }
		}
		DebugLocation(52, 82);
		} finally { DebugExitRule(GrammarFileName, "longdeclaration"); }
		return retval;

	}
	// $ANTLR end "longdeclaration"

	public class variable_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_variable();
	partial void Leave_variable();

	// $ANTLR start "variable"
	// MathLang.g:54:1: variable : ( TYPE | ARRAY ) ID ;
	[GrammarRule("variable")]
	private MathLangParser.variable_return variable()
	{
		Enter_variable();
		EnterRule("variable", 8);
		TraceIn("variable", 8);
		MathLangParser.variable_return retval = new MathLangParser.variable_return();
		retval.Start = (IToken)input.LT(1);
		int variable_StartIndex = input.Index;
		object root_0 = null;

		IToken set19=null;
		IToken ID20=null;

		object set19_tree=null;
		object ID20_tree=null;

		try { DebugEnterRule(GrammarFileName, "variable");
		DebugLocation(54, 28);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 8)) { return retval; }
			// MathLang.g:54:9: ( ( TYPE | ARRAY ) ID )
			DebugEnterAlt(1);
			// MathLang.g:54:11: ( TYPE | ARRAY ) ID
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(54, 11);
			set19=(IToken)input.LT(1);
			set19=(IToken)input.LT(1);
			if (input.LA(1)==TYPE||input.LA(1)==ARRAY)
			{
				input.Consume();
				if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set19), root_0);
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}

			DebugLocation(54, 27);
			ID20=(IToken)Match(input,ID,Follow._ID_in_variable388); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			ID20_tree = (object)adaptor.Create(ID20);
			adaptor.AddChild(root_0, ID20_tree);
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
			TraceOut("variable", 8);
			LeaveRule("variable", 8);
			Leave_variable();
			if (state.backtracking > 0) { Memoize(input, 8, variable_StartIndex); }
		}
		DebugLocation(54, 28);
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
	// MathLang.g:55:1: add : mul ( ( ADD | SUB ) mul )* ;
	[GrammarRule("add")]
	private MathLangParser.add_return add()
	{
		Enter_add();
		EnterRule("add", 9);
		TraceIn("add", 9);
		MathLangParser.add_return retval = new MathLangParser.add_return();
		retval.Start = (IToken)input.LT(1);
		int add_StartIndex = input.Index;
		object root_0 = null;

		IToken set22=null;
		MathLangParser.mul_return mul21 = default(MathLangParser.mul_return);
		MathLangParser.mul_return mul23 = default(MathLangParser.mul_return);

		object set22_tree=null;

		try { DebugEnterRule(GrammarFileName, "add");
		DebugLocation(55, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 9)) { return retval; }
			// MathLang.g:55:4: ( mul ( ( ADD | SUB ) mul )* )
			DebugEnterAlt(1);
			// MathLang.g:55:6: mul ( ( ADD | SUB ) mul )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(55, 6);
			PushFollow(Follow._mul_in_add394);
			mul21=mul();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul21.Tree);
			DebugLocation(55, 10);
			// MathLang.g:55:10: ( ( ADD | SUB ) mul )*
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
					// MathLang.g:55:12: ( ADD | SUB ) mul
					{
					DebugLocation(55, 12);
					set22=(IToken)input.LT(1);
					set22=(IToken)input.LT(1);
					if ((input.LA(1)>=ADD && input.LA(1)<=SUB))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set22), root_0);
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(55, 25);
					PushFollow(Follow._mul_in_add407);
					mul23=mul();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul23.Tree);

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
			TraceOut("add", 9);
			LeaveRule("add", 9);
			Leave_add();
			if (state.backtracking > 0) { Memoize(input, 9, add_StartIndex); }
		}
		DebugLocation(55, 30);
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
	// MathLang.g:56:1: mul : group ( ( MUL | DIV ) group )* ;
	[GrammarRule("mul")]
	private MathLangParser.mul_return mul()
	{
		Enter_mul();
		EnterRule("mul", 10);
		TraceIn("mul", 10);
		MathLangParser.mul_return retval = new MathLangParser.mul_return();
		retval.Start = (IToken)input.LT(1);
		int mul_StartIndex = input.Index;
		object root_0 = null;

		IToken set25=null;
		MathLangParser.group_return group24 = default(MathLangParser.group_return);
		MathLangParser.group_return group26 = default(MathLangParser.group_return);

		object set25_tree=null;

		try { DebugEnterRule(GrammarFileName, "mul");
		DebugLocation(56, 33);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 10)) { return retval; }
			// MathLang.g:56:4: ( group ( ( MUL | DIV ) group )* )
			DebugEnterAlt(1);
			// MathLang.g:56:6: group ( ( MUL | DIV ) group )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(56, 6);
			PushFollow(Follow._group_in_mul416);
			group24=group();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group24.Tree);
			DebugLocation(56, 12);
			// MathLang.g:56:12: ( ( MUL | DIV ) group )*
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
					// MathLang.g:56:14: ( MUL | DIV ) group
					{
					DebugLocation(56, 14);
					set25=(IToken)input.LT(1);
					set25=(IToken)input.LT(1);
					if ((input.LA(1)>=MUL && input.LA(1)<=DIV))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set25), root_0);
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(56, 27);
					PushFollow(Follow._group_in_mul429);
					group26=group();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group26.Tree);

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
			TraceOut("mul", 10);
			LeaveRule("mul", 10);
			Leave_mul();
			if (state.backtracking > 0) { Memoize(input, 10, mul_StartIndex); }
		}
		DebugLocation(56, 33);
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
	// MathLang.g:57:1: compare : add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )? ;
	[GrammarRule("compare")]
	private MathLangParser.compare_return compare()
	{
		Enter_compare();
		EnterRule("compare", 11);
		TraceIn("compare", 11);
		MathLangParser.compare_return retval = new MathLangParser.compare_return();
		retval.Start = (IToken)input.LT(1);
		int compare_StartIndex = input.Index;
		object root_0 = null;

		IToken set28=null;
		MathLangParser.add_return add27 = default(MathLangParser.add_return);
		MathLangParser.add_return add29 = default(MathLangParser.add_return);

		object set28_tree=null;

		try { DebugEnterRule(GrammarFileName, "compare");
		DebugLocation(57, 60);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 11)) { return retval; }
			// MathLang.g:57:8: ( add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )? )
			DebugEnterAlt(1);
			// MathLang.g:57:10: add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(57, 10);
			PushFollow(Follow._add_in_compare437);
			add27=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add27.Tree);
			DebugLocation(57, 14);
			// MathLang.g:57:14: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
			int alt6=2;
			try { DebugEnterSubRule(6);
			try { DebugEnterDecision(6, decisionCanBacktrack[6]);
			int LA6_0 = input.LA(1);

			if (((LA6_0>=GREQ && LA6_0<=LS)))
			{
				alt6=1;
			}
			} finally { DebugExitDecision(6); }
			switch (alt6)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:57:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
				{
				DebugLocation(57, 16);
				set28=(IToken)input.LT(1);
				set28=(IToken)input.LT(1);
				if ((input.LA(1)>=GREQ && input.LA(1)<=LS))
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

				DebugLocation(57, 53);
				PushFollow(Follow._add_in_compare467);
				add29=add();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add29.Tree);

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
			TraceOut("compare", 11);
			LeaveRule("compare", 11);
			Leave_compare();
			if (state.backtracking > 0) { Memoize(input, 11, compare_StartIndex); }
		}
		DebugLocation(57, 60);
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
	// MathLang.g:59:1: term : add ;
	[GrammarRule("term")]
	private MathLangParser.term_return term()
	{
		Enter_term();
		EnterRule("term", 12);
		TraceIn("term", 12);
		MathLangParser.term_return retval = new MathLangParser.term_return();
		retval.Start = (IToken)input.LT(1);
		int term_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.add_return add30 = default(MathLangParser.add_return);


		try { DebugEnterRule(GrammarFileName, "term");
		DebugLocation(59, 9);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 12)) { return retval; }
			// MathLang.g:59:5: ( add )
			DebugEnterAlt(1);
			// MathLang.g:59:7: add
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(59, 7);
			PushFollow(Follow._add_in_term479);
			add30=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add30.Tree);

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
			TraceOut("term", 12);
			LeaveRule("term", 12);
			Leave_term();
			if (state.backtracking > 0) { Memoize(input, 12, term_StartIndex); }
		}
		DebugLocation(59, 9);
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
	// MathLang.g:61:1: group : ( '(' term ')' | number );
	[GrammarRule("group")]
	private MathLangParser.group_return group()
	{
		Enter_group();
		EnterRule("group", 13);
		TraceIn("group", 13);
		MathLangParser.group_return retval = new MathLangParser.group_return();
		retval.Start = (IToken)input.LT(1);
		int group_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal31=null;
		IToken char_literal33=null;
		MathLangParser.term_return term32 = default(MathLangParser.term_return);
		MathLangParser.number_return number34 = default(MathLangParser.number_return);

		object char_literal31_tree=null;
		object char_literal33_tree=null;

		try { DebugEnterRule(GrammarFileName, "group");
		DebugLocation(61, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 13)) { return retval; }
			// MathLang.g:61:6: ( '(' term ')' | number )
			int alt7=2;
			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
			int LA7_0 = input.LA(1);

			if ((LA7_0==40))
			{
				alt7=1;
			}
			else if (((LA7_0>=NUMBER && LA7_0<=ID)))
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
				// MathLang.g:61:8: '(' term ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(61, 11);
				char_literal31=(IToken)Match(input,40,Follow._40_in_group486); if (state.failed) return retval;
				DebugLocation(61, 13);
				PushFollow(Follow._term_in_group489);
				term32=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term32.Tree);
				DebugLocation(61, 21);
				char_literal33=(IToken)Match(input,41,Follow._41_in_group491); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:61:25: number
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(61, 25);
				PushFollow(Follow._number_in_group496);
				number34=number();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, number34.Tree);

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
			TraceOut("group", 13);
			LeaveRule("group", 13);
			Leave_group();
			if (state.backtracking > 0) { Memoize(input, 13, group_StartIndex); }
		}
		DebugLocation(61, 30);
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
	// MathLang.g:63:1: assignment : ID ASSIGN expression ';' ;
	[GrammarRule("assignment")]
	private MathLangParser.assignment_return assignment()
	{
		Enter_assignment();
		EnterRule("assignment", 14);
		TraceIn("assignment", 14);
		MathLangParser.assignment_return retval = new MathLangParser.assignment_return();
		retval.Start = (IToken)input.LT(1);
		int assignment_StartIndex = input.Index;
		object root_0 = null;

		IToken ID35=null;
		IToken ASSIGN36=null;
		IToken char_literal38=null;
		MathLangParser.expression_return expression37 = default(MathLangParser.expression_return);

		object ID35_tree=null;
		object ASSIGN36_tree=null;
		object char_literal38_tree=null;

		try { DebugEnterRule(GrammarFileName, "assignment");
		DebugLocation(63, 38);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 14)) { return retval; }
			// MathLang.g:63:11: ( ID ASSIGN expression ';' )
			DebugEnterAlt(1);
			// MathLang.g:63:13: ID ASSIGN expression ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(63, 13);
			ID35=(IToken)Match(input,ID,Follow._ID_in_assignment503); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			ID35_tree = (object)adaptor.Create(ID35);
			adaptor.AddChild(root_0, ID35_tree);
			}
			DebugLocation(63, 22);
			ASSIGN36=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignment505); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			ASSIGN36_tree = (object)adaptor.Create(ASSIGN36);
			root_0 = (object)adaptor.BecomeRoot(ASSIGN36_tree, root_0);
			}
			DebugLocation(63, 24);
			PushFollow(Follow._expression_in_assignment508);
			expression37=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression37.Tree);
			DebugLocation(63, 38);
			char_literal38=(IToken)Match(input,39,Follow._39_in_assignment510); if (state.failed) return retval;

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
			TraceOut("assignment", 14);
			LeaveRule("assignment", 14);
			Leave_assignment();
			if (state.backtracking > 0) { Memoize(input, 14, assignment_StartIndex); }
		}
		DebugLocation(63, 38);
		} finally { DebugExitRule(GrammarFileName, "assignment"); }
		return retval;

	}
	// $ANTLR end "assignment"

	public class boolexpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_boolexpression();
	partial void Leave_boolexpression();

	// $ANTLR start "boolexpression"
	// MathLang.g:64:1: boolexpression : boolterm ;
	[GrammarRule("boolexpression")]
	private MathLangParser.boolexpression_return boolexpression()
	{
		Enter_boolexpression();
		EnterRule("boolexpression", 15);
		TraceIn("boolexpression", 15);
		MathLangParser.boolexpression_return retval = new MathLangParser.boolexpression_return();
		retval.Start = (IToken)input.LT(1);
		int boolexpression_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.boolterm_return boolterm39 = default(MathLangParser.boolterm_return);


		try { DebugEnterRule(GrammarFileName, "boolexpression");
		DebugLocation(64, 24);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 15)) { return retval; }
			// MathLang.g:64:15: ( boolterm )
			DebugEnterAlt(1);
			// MathLang.g:64:17: boolterm
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(64, 17);
			PushFollow(Follow._boolterm_in_boolexpression517);
			boolterm39=boolterm();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm39.Tree);

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
			TraceOut("boolexpression", 15);
			LeaveRule("boolexpression", 15);
			Leave_boolexpression();
			if (state.backtracking > 0) { Memoize(input, 15, boolexpression_StartIndex); }
		}
		DebugLocation(64, 24);
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
	// MathLang.g:65:1: boolterm : or ;
	[GrammarRule("boolterm")]
	private MathLangParser.boolterm_return boolterm()
	{
		Enter_boolterm();
		EnterRule("boolterm", 16);
		TraceIn("boolterm", 16);
		MathLangParser.boolterm_return retval = new MathLangParser.boolterm_return();
		retval.Start = (IToken)input.LT(1);
		int boolterm_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.or_return or40 = default(MathLangParser.or_return);


		try { DebugEnterRule(GrammarFileName, "boolterm");
		DebugLocation(65, 12);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 16)) { return retval; }
			// MathLang.g:65:9: ( or )
			DebugEnterAlt(1);
			// MathLang.g:65:11: or
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(65, 11);
			PushFollow(Follow._or_in_boolterm523);
			or40=or();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or40.Tree);

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
			TraceOut("boolterm", 16);
			LeaveRule("boolterm", 16);
			Leave_boolterm();
			if (state.backtracking > 0) { Memoize(input, 16, boolterm_StartIndex); }
		}
		DebugLocation(65, 12);
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
	// MathLang.g:66:1: or : and ( OR and )* ;
	[GrammarRule("or")]
	private MathLangParser.or_return or()
	{
		Enter_or();
		EnterRule("or", 17);
		TraceIn("or", 17);
		MathLangParser.or_return retval = new MathLangParser.or_return();
		retval.Start = (IToken)input.LT(1);
		int or_StartIndex = input.Index;
		object root_0 = null;

		IToken OR42=null;
		MathLangParser.and_return and41 = default(MathLangParser.and_return);
		MathLangParser.and_return and43 = default(MathLangParser.and_return);

		object OR42_tree=null;

		try { DebugEnterRule(GrammarFileName, "or");
		DebugLocation(66, 18);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 17)) { return retval; }
			// MathLang.g:66:3: ( and ( OR and )* )
			DebugEnterAlt(1);
			// MathLang.g:66:5: and ( OR and )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(66, 5);
			PushFollow(Follow._and_in_or529);
			and41=and();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and41.Tree);
			DebugLocation(66, 9);
			// MathLang.g:66:9: ( OR and )*
			try { DebugEnterSubRule(8);
			while (true)
			{
				int alt8=2;
				try { DebugEnterDecision(8, decisionCanBacktrack[8]);
				int LA8_0 = input.LA(1);

				if ((LA8_0==OR))
				{
					alt8=1;
				}


				} finally { DebugExitDecision(8); }
				switch ( alt8 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:66:10: OR and
					{
					DebugLocation(66, 12);
					OR42=(IToken)Match(input,OR,Follow._OR_in_or532); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR42_tree = (object)adaptor.Create(OR42);
					root_0 = (object)adaptor.BecomeRoot(OR42_tree, root_0);
					}
					DebugLocation(66, 14);
					PushFollow(Follow._and_in_or535);
					and43=and();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and43.Tree);

					}
					break;

				default:
					goto loop8;
				}
			}

			loop8:
				;

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
			TraceOut("or", 17);
			LeaveRule("or", 17);
			Leave_or();
			if (state.backtracking > 0) { Memoize(input, 17, or_StartIndex); }
		}
		DebugLocation(66, 18);
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
	// MathLang.g:67:1: and : boolgroup ( AND boolgroup )* ;
	[GrammarRule("and")]
	private MathLangParser.and_return and()
	{
		Enter_and();
		EnterRule("and", 18);
		TraceIn("and", 18);
		MathLangParser.and_return retval = new MathLangParser.and_return();
		retval.Start = (IToken)input.LT(1);
		int and_StartIndex = input.Index;
		object root_0 = null;

		IToken AND45=null;
		MathLangParser.boolgroup_return boolgroup44 = default(MathLangParser.boolgroup_return);
		MathLangParser.boolgroup_return boolgroup46 = default(MathLangParser.boolgroup_return);

		object AND45_tree=null;

		try { DebugEnterRule(GrammarFileName, "and");
		DebugLocation(67, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 18)) { return retval; }
			// MathLang.g:67:4: ( boolgroup ( AND boolgroup )* )
			DebugEnterAlt(1);
			// MathLang.g:67:6: boolgroup ( AND boolgroup )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(67, 6);
			PushFollow(Follow._boolgroup_in_and543);
			boolgroup44=boolgroup();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup44.Tree);
			DebugLocation(67, 16);
			// MathLang.g:67:16: ( AND boolgroup )*
			try { DebugEnterSubRule(9);
			while (true)
			{
				int alt9=2;
				try { DebugEnterDecision(9, decisionCanBacktrack[9]);
				int LA9_0 = input.LA(1);

				if ((LA9_0==AND))
				{
					alt9=1;
				}


				} finally { DebugExitDecision(9); }
				switch ( alt9 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:67:17: AND boolgroup
					{
					DebugLocation(67, 20);
					AND45=(IToken)Match(input,AND,Follow._AND_in_and546); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND45_tree = (object)adaptor.Create(AND45);
					root_0 = (object)adaptor.BecomeRoot(AND45_tree, root_0);
					}
					DebugLocation(67, 22);
					PushFollow(Follow._boolgroup_in_and549);
					boolgroup46=boolgroup();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup46.Tree);

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
			TraceOut("and", 18);
			LeaveRule("and", 18);
			Leave_and();
			if (state.backtracking > 0) { Memoize(input, 18, and_StartIndex); }
		}
		DebugLocation(67, 32);
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
	// MathLang.g:68:1: boolgroup : ( '(' boolterm ')' | boolvar );
	[GrammarRule("boolgroup")]
	private MathLangParser.boolgroup_return boolgroup()
	{
		Enter_boolgroup();
		EnterRule("boolgroup", 19);
		TraceIn("boolgroup", 19);
		MathLangParser.boolgroup_return retval = new MathLangParser.boolgroup_return();
		retval.Start = (IToken)input.LT(1);
		int boolgroup_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal47=null;
		IToken char_literal49=null;
		MathLangParser.boolterm_return boolterm48 = default(MathLangParser.boolterm_return);
		MathLangParser.boolvar_return boolvar50 = default(MathLangParser.boolvar_return);

		object char_literal47_tree=null;
		object char_literal49_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolgroup");
		DebugLocation(68, 39);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 19)) { return retval; }
			// MathLang.g:68:10: ( '(' boolterm ')' | boolvar )
			int alt10=2;
			try { DebugEnterDecision(10, decisionCanBacktrack[10]);
			int LA10_0 = input.LA(1);

			if ((LA10_0==40))
			{
				int LA10_1 = input.LA(2);

				if ((EvaluatePredicate(synpred20_MathLang_fragment)))
				{
					alt10=1;
				}
				else if ((true))
				{
					alt10=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 10, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else if (((LA10_0>=NUMBER && LA10_0<=ID)||(LA10_0>=TRUE && LA10_0<=FALSE)))
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
				// MathLang.g:68:12: '(' boolterm ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(68, 15);
				char_literal47=(IToken)Match(input,40,Follow._40_in_boolgroup557); if (state.failed) return retval;
				DebugLocation(68, 17);
				PushFollow(Follow._boolterm_in_boolgroup560);
				boolterm48=boolterm();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm48.Tree);
				DebugLocation(68, 29);
				char_literal49=(IToken)Match(input,41,Follow._41_in_boolgroup562); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:68:33: boolvar
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(68, 33);
				PushFollow(Follow._boolvar_in_boolgroup567);
				boolvar50=boolvar();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolvar50.Tree);

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
			TraceOut("boolgroup", 19);
			LeaveRule("boolgroup", 19);
			Leave_boolgroup();
			if (state.backtracking > 0) { Memoize(input, 19, boolgroup_StartIndex); }
		}
		DebugLocation(68, 39);
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
	// MathLang.g:69:1: boolvar : ( TRUE | FALSE | compare );
	[GrammarRule("boolvar")]
	private MathLangParser.boolvar_return boolvar()
	{
		Enter_boolvar();
		EnterRule("boolvar", 20);
		TraceIn("boolvar", 20);
		MathLangParser.boolvar_return retval = new MathLangParser.boolvar_return();
		retval.Start = (IToken)input.LT(1);
		int boolvar_StartIndex = input.Index;
		object root_0 = null;

		IToken TRUE51=null;
		IToken FALSE52=null;
		MathLangParser.compare_return compare53 = default(MathLangParser.compare_return);

		object TRUE51_tree=null;
		object FALSE52_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolvar");
		DebugLocation(69, 11);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 20)) { return retval; }
			// MathLang.g:69:8: ( TRUE | FALSE | compare )
			int alt11=3;
			try { DebugEnterDecision(11, decisionCanBacktrack[11]);
			switch (input.LA(1))
			{
			case TRUE:
				{
				alt11=1;
				}
				break;
			case FALSE:
				{
				alt11=2;
				}
				break;
			case NUMBER:
			case ID:
			case 40:
				{
				alt11=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 11, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(11); }
			switch (alt11)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:69:10: TRUE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(69, 10);
				TRUE51=(IToken)Match(input,TRUE,Follow._TRUE_in_boolvar573); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				TRUE51_tree = (object)adaptor.Create(TRUE51);
				adaptor.AddChild(root_0, TRUE51_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:70:5: FALSE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(70, 5);
				FALSE52=(IToken)Match(input,FALSE,Follow._FALSE_in_boolvar579); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				FALSE52_tree = (object)adaptor.Create(FALSE52);
				adaptor.AddChild(root_0, FALSE52_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:71:5: compare
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(71, 5);
				PushFollow(Follow._compare_in_boolvar585);
				compare53=compare();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare53.Tree);

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
			TraceOut("boolvar", 20);
			LeaveRule("boolvar", 20);
			Leave_boolvar();
			if (state.backtracking > 0) { Memoize(input, 20, boolvar_StartIndex); }
		}
		DebugLocation(71, 11);
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
	// MathLang.g:73:1: ifstatement : IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )* ;
	[GrammarRule("ifstatement")]
	private MathLangParser.ifstatement_return ifstatement()
	{
		Enter_ifstatement();
		EnterRule("ifstatement", 21);
		TraceIn("ifstatement", 21);
		MathLangParser.ifstatement_return retval = new MathLangParser.ifstatement_return();
		retval.Start = (IToken)input.LT(1);
		int ifstatement_StartIndex = input.Index;
		object root_0 = null;

		IToken IF54=null;
		IToken char_literal55=null;
		IToken char_literal57=null;
		IToken ELSE60=null;
		MathLangParser.boolexpression_return boolexpression56 = default(MathLangParser.boolexpression_return);
		MathLangParser.block_return block58 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement59 = default(MathLangParser.statement_return);
		MathLangParser.block_return block61 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement62 = default(MathLangParser.statement_return);

		object IF54_tree=null;
		object char_literal55_tree=null;
		object char_literal57_tree=null;
		object ELSE60_tree=null;

		try { DebugEnterRule(GrammarFileName, "ifstatement");
		DebugLocation(73, 91);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 21)) { return retval; }
			// MathLang.g:73:12: ( IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )* )
			DebugEnterAlt(1);
			// MathLang.g:73:14: IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(73, 16);
			IF54=(IToken)Match(input,IF,Follow._IF_in_ifstatement592); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			IF54_tree = (object)adaptor.Create(IF54);
			root_0 = (object)adaptor.BecomeRoot(IF54_tree, root_0);
			}
			DebugLocation(73, 21);
			char_literal55=(IToken)Match(input,40,Follow._40_in_ifstatement595); if (state.failed) return retval;
			DebugLocation(73, 23);
			PushFollow(Follow._boolexpression_in_ifstatement598);
			boolexpression56=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression56.Tree);
			DebugLocation(73, 41);
			char_literal57=(IToken)Match(input,41,Follow._41_in_ifstatement600); if (state.failed) return retval;
			DebugLocation(73, 43);
			// MathLang.g:73:43: ( block | statement )
			int alt12=2;
			try { DebugEnterSubRule(12);
			try { DebugEnterDecision(12, decisionCanBacktrack[12]);
			int LA12_0 = input.LA(1);

			if ((LA12_0==42))
			{
				alt12=1;
			}
			else if ((LA12_0==IF||(LA12_0>=ID && LA12_0<=TYPE)))
			{
				alt12=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 12, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(12); }
			switch (alt12)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:73:44: block
				{
				DebugLocation(73, 44);
				PushFollow(Follow._block_in_ifstatement604);
				block58=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block58.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:73:52: statement
				{
				DebugLocation(73, 52);
				PushFollow(Follow._statement_in_ifstatement608);
				statement59=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement59.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(12); }

			DebugLocation(73, 63);
			// MathLang.g:73:63: ( ELSE ( block | statement ) )*
			try { DebugEnterSubRule(14);
			while (true)
			{
				int alt14=2;
				try { DebugEnterDecision(14, decisionCanBacktrack[14]);
				int LA14_0 = input.LA(1);

				if ((LA14_0==ELSE))
				{
					int LA14_1 = input.LA(2);

					if ((EvaluatePredicate(synpred25_MathLang_fragment)))
					{
						alt14=1;
					}


				}


				} finally { DebugExitDecision(14); }
				switch ( alt14 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:73:64: ELSE ( block | statement )
					{
					DebugLocation(73, 68);
					ELSE60=(IToken)Match(input,ELSE,Follow._ELSE_in_ifstatement612); if (state.failed) return retval;
					DebugLocation(73, 70);
					// MathLang.g:73:70: ( block | statement )
					int alt13=2;
					try { DebugEnterSubRule(13);
					try { DebugEnterDecision(13, decisionCanBacktrack[13]);
					int LA13_0 = input.LA(1);

					if ((LA13_0==42))
					{
						alt13=1;
					}
					else if ((LA13_0==IF||(LA13_0>=ID && LA13_0<=TYPE)))
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
						// MathLang.g:73:71: block
						{
						DebugLocation(73, 71);
						PushFollow(Follow._block_in_ifstatement616);
						block61=block();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block61.Tree);

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// MathLang.g:73:79: statement
						{
						DebugLocation(73, 79);
						PushFollow(Follow._statement_in_ifstatement620);
						statement62=statement();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement62.Tree);

						}
						break;

					}
					} finally { DebugExitSubRule(13); }


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
			TraceOut("ifstatement", 21);
			LeaveRule("ifstatement", 21);
			Leave_ifstatement();
			if (state.backtracking > 0) { Memoize(input, 21, ifstatement_StartIndex); }
		}
		DebugLocation(73, 91);
		} finally { DebugExitRule(GrammarFileName, "ifstatement"); }
		return retval;

	}
	// $ANTLR end "ifstatement"

	public class block_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_block();
	partial void Leave_block();

	// $ANTLR start "block"
	// MathLang.g:75:1: block : '{' statementlist '}' ;
	[GrammarRule("block")]
	private MathLangParser.block_return block()
	{
		Enter_block();
		EnterRule("block", 22);
		TraceIn("block", 22);
		MathLangParser.block_return retval = new MathLangParser.block_return();
		retval.Start = (IToken)input.LT(1);
		int block_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal63=null;
		IToken char_literal65=null;
		MathLangParser.statementlist_return statementlist64 = default(MathLangParser.statementlist_return);

		object char_literal63_tree=null;
		object char_literal65_tree=null;

		try { DebugEnterRule(GrammarFileName, "block");
		DebugLocation(75, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 22)) { return retval; }
			// MathLang.g:75:6: ( '{' statementlist '}' )
			DebugEnterAlt(1);
			// MathLang.g:75:8: '{' statementlist '}'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(75, 11);
			char_literal63=(IToken)Match(input,42,Follow._42_in_block631); if (state.failed) return retval;
			DebugLocation(75, 13);
			PushFollow(Follow._statementlist_in_block634);
			statementlist64=statementlist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementlist64.Tree);
			DebugLocation(75, 30);
			char_literal65=(IToken)Match(input,43,Follow._43_in_block636); if (state.failed) return retval;

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
			TraceOut("block", 22);
			LeaveRule("block", 22);
			Leave_block();
			if (state.backtracking > 0) { Memoize(input, 22, block_StartIndex); }
		}
		DebugLocation(75, 30);
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
	// MathLang.g:77:1: statementlist : ( statement )* -> ^( BLOCK ( statement )* ) ;
	[GrammarRule("statementlist")]
	private MathLangParser.statementlist_return statementlist()
	{
		Enter_statementlist();
		EnterRule("statementlist", 23);
		TraceIn("statementlist", 23);
		MathLangParser.statementlist_return retval = new MathLangParser.statementlist_return();
		retval.Start = (IToken)input.LT(1);
		int statementlist_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.statement_return statement66 = default(MathLangParser.statement_return);

		RewriteRuleSubtreeStream stream_statement=new RewriteRuleSubtreeStream(adaptor,"rule statement");
		try { DebugEnterRule(GrammarFileName, "statementlist");
		DebugLocation(77, 49);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 23)) { return retval; }
			// MathLang.g:77:14: ( ( statement )* -> ^( BLOCK ( statement )* ) )
			DebugEnterAlt(1);
			// MathLang.g:77:16: ( statement )*
			{
			DebugLocation(77, 16);
			// MathLang.g:77:16: ( statement )*
			try { DebugEnterSubRule(15);
			while (true)
			{
				int alt15=2;
				try { DebugEnterDecision(15, decisionCanBacktrack[15]);
				int LA15_0 = input.LA(1);

				if ((LA15_0==IF||(LA15_0>=ID && LA15_0<=TYPE)))
				{
					alt15=1;
				}


				} finally { DebugExitDecision(15); }
				switch ( alt15 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: statement
					{
					DebugLocation(77, 16);
					PushFollow(Follow._statement_in_statementlist644);
					statement66=statement();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_statement.Add(statement66.Tree);

					}
					break;

				default:
					goto loop15;
				}
			}

			loop15:
				;

			} finally { DebugExitSubRule(15); }



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
			// 77:27: -> ^( BLOCK ( statement )* )
			{
				DebugLocation(77, 30);
				// MathLang.g:77:30: ^( BLOCK ( statement )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(77, 32);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

				DebugLocation(77, 38);
				// MathLang.g:77:38: ( statement )*
				while ( stream_statement.HasNext )
				{
					DebugLocation(77, 38);
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
			TraceOut("statementlist", 23);
			LeaveRule("statementlist", 23);
			Leave_statementlist();
			if (state.backtracking > 0) { Memoize(input, 23, statementlist_StartIndex); }
		}
		DebugLocation(77, 49);
		} finally { DebugExitRule(GrammarFileName, "statementlist"); }
		return retval;

	}
	// $ANTLR end "statementlist"

	partial void Enter_synpred4_MathLang_fragment();
	partial void Leave_synpred4_MathLang_fragment();

	// $ANTLR start synpred4_MathLang
	public void synpred4_MathLang_fragment()
	{
		Enter_synpred4_MathLang_fragment();
		EnterRule("synpred4_MathLang_fragment", 27);
		TraceIn("synpred4_MathLang_fragment", 27);
		try
		{
			// MathLang.g:47:12: ( mathexpression )
			DebugEnterAlt(1);
			// MathLang.g:47:12: mathexpression
			{
			DebugLocation(47, 12);
			PushFollow(Follow._mathexpression_in_synpred4_MathLang316);
			mathexpression();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred4_MathLang_fragment", 27);
			LeaveRule("synpred4_MathLang_fragment", 27);
			Leave_synpred4_MathLang_fragment();
		}
	}
	// $ANTLR end synpred4_MathLang

	partial void Enter_synpred20_MathLang_fragment();
	partial void Leave_synpred20_MathLang_fragment();

	// $ANTLR start synpred20_MathLang
	public void synpred20_MathLang_fragment()
	{
		Enter_synpred20_MathLang_fragment();
		EnterRule("synpred20_MathLang_fragment", 43);
		TraceIn("synpred20_MathLang_fragment", 43);
		try
		{
			// MathLang.g:68:12: ( '(' boolterm ')' )
			DebugEnterAlt(1);
			// MathLang.g:68:12: '(' boolterm ')'
			{
			DebugLocation(68, 12);
			Match(input,40,Follow._40_in_synpred20_MathLang557); if (state.failed) return;
			DebugLocation(68, 17);
			PushFollow(Follow._boolterm_in_synpred20_MathLang560);
			boolterm();
			PopFollow();
			if (state.failed) return;
			DebugLocation(68, 26);
			Match(input,41,Follow._41_in_synpred20_MathLang562); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred20_MathLang_fragment", 43);
			LeaveRule("synpred20_MathLang_fragment", 43);
			Leave_synpred20_MathLang_fragment();
		}
	}
	// $ANTLR end synpred20_MathLang

	partial void Enter_synpred25_MathLang_fragment();
	partial void Leave_synpred25_MathLang_fragment();

	// $ANTLR start synpred25_MathLang
	public void synpred25_MathLang_fragment()
	{
		Enter_synpred25_MathLang_fragment();
		EnterRule("synpred25_MathLang_fragment", 48);
		TraceIn("synpred25_MathLang_fragment", 48);
		try
		{
			// MathLang.g:73:64: ( ELSE ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:73:64: ELSE ( block | statement )
			{
			DebugLocation(73, 64);
			Match(input,ELSE,Follow._ELSE_in_synpred25_MathLang612); if (state.failed) return;
			DebugLocation(73, 70);
			// MathLang.g:73:70: ( block | statement )
			int alt16=2;
			try { DebugEnterSubRule(16);
			try { DebugEnterDecision(16, decisionCanBacktrack[16]);
			int LA16_0 = input.LA(1);

			if ((LA16_0==42))
			{
				alt16=1;
			}
			else if ((LA16_0==IF||(LA16_0>=ID && LA16_0<=TYPE)))
			{
				alt16=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				NoViableAltException nvae = new NoViableAltException("", 16, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(16); }
			switch (alt16)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:73:71: block
				{
				DebugLocation(73, 71);
				PushFollow(Follow._block_in_synpred25_MathLang616);
				block();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:73:79: statement
				{
				DebugLocation(73, 79);
				PushFollow(Follow._statement_in_synpred25_MathLang620);
				statement();
				PopFollow();
				if (state.failed) return;

				}
				break;

			}
			} finally { DebugExitSubRule(16); }


			}

		}
		finally
		{
			TraceOut("synpred25_MathLang_fragment", 48);
			LeaveRule("synpred25_MathLang_fragment", 48);
			Leave_synpred25_MathLang_fragment();
		}
	}
	// $ANTLR end synpred25_MathLang
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
		public static readonly BitSet _set_in_number0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _term_in_mathexpression309 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathexpression_in_expression316 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolexpression_in_expression323 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_declaration330 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _ID_in_declaration333 = new BitSet(new ulong[]{0x8000000000UL});
		public static readonly BitSet _39_in_declaration335 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _longdeclaration_in_declaration343 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_longdeclaration348 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _ID_in_longdeclaration350 = new BitSet(new ulong[]{0x80000UL});
		public static readonly BitSet _ASSIGN_in_longdeclaration352 = new BitSet(new ulong[]{0x10600030000UL});
		public static readonly BitSet _expression_in_longdeclaration354 = new BitSet(new ulong[]{0x8000000000UL});
		public static readonly BitSet _39_in_longdeclaration356 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_variable379 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _ID_in_variable388 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mul_in_add394 = new BitSet(new ulong[]{0x600002UL});
		public static readonly BitSet _set_in_add398 = new BitSet(new ulong[]{0x10000030000UL});
		public static readonly BitSet _mul_in_add407 = new BitSet(new ulong[]{0x600002UL});
		public static readonly BitSet _group_in_mul416 = new BitSet(new ulong[]{0x1800002UL});
		public static readonly BitSet _set_in_mul420 = new BitSet(new ulong[]{0x10000030000UL});
		public static readonly BitSet _group_in_mul429 = new BitSet(new ulong[]{0x1800002UL});
		public static readonly BitSet _add_in_compare437 = new BitSet(new ulong[]{0x7E000002UL});
		public static readonly BitSet _set_in_compare441 = new BitSet(new ulong[]{0x10000030000UL});
		public static readonly BitSet _add_in_compare467 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _add_in_term479 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _40_in_group486 = new BitSet(new ulong[]{0x10000030000UL});
		public static readonly BitSet _term_in_group489 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _41_in_group491 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _number_in_group496 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_assignment503 = new BitSet(new ulong[]{0x80000UL});
		public static readonly BitSet _ASSIGN_in_assignment505 = new BitSet(new ulong[]{0x10600030000UL});
		public static readonly BitSet _expression_in_assignment508 = new BitSet(new ulong[]{0x8000000000UL});
		public static readonly BitSet _39_in_assignment510 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolterm_in_boolexpression517 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _or_in_boolterm523 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _and_in_or529 = new BitSet(new ulong[]{0x80000002UL});
		public static readonly BitSet _OR_in_or532 = new BitSet(new ulong[]{0x10600030000UL});
		public static readonly BitSet _and_in_or535 = new BitSet(new ulong[]{0x80000002UL});
		public static readonly BitSet _boolgroup_in_and543 = new BitSet(new ulong[]{0x100000002UL});
		public static readonly BitSet _AND_in_and546 = new BitSet(new ulong[]{0x10600030000UL});
		public static readonly BitSet _boolgroup_in_and549 = new BitSet(new ulong[]{0x100000002UL});
		public static readonly BitSet _40_in_boolgroup557 = new BitSet(new ulong[]{0x10600030000UL});
		public static readonly BitSet _boolterm_in_boolgroup560 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _41_in_boolgroup562 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolvar_in_boolgroup567 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TRUE_in_boolvar573 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FALSE_in_boolvar579 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _compare_in_boolvar585 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_ifstatement592 = new BitSet(new ulong[]{0x10000000000UL});
		public static readonly BitSet _40_in_ifstatement595 = new BitSet(new ulong[]{0x10600030000UL});
		public static readonly BitSet _boolexpression_in_ifstatement598 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _41_in_ifstatement600 = new BitSet(new ulong[]{0x40000060080UL});
		public static readonly BitSet _block_in_ifstatement604 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement608 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _ELSE_in_ifstatement612 = new BitSet(new ulong[]{0x40000060080UL});
		public static readonly BitSet _block_in_ifstatement616 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement620 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _42_in_block631 = new BitSet(new ulong[]{0xC0000060080UL});
		public static readonly BitSet _statementlist_in_block634 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _43_in_block636 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_statementlist644 = new BitSet(new ulong[]{0x40000060082UL});
		public static readonly BitSet _mathexpression_in_synpred4_MathLang316 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _40_in_synpred20_MathLang557 = new BitSet(new ulong[]{0x10600030000UL});
		public static readonly BitSet _boolterm_in_synpred20_MathLang560 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _41_in_synpred20_MathLang562 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ELSE_in_synpred25_MathLang612 = new BitSet(new ulong[]{0x40000060080UL});
		public static readonly BitSet _block_in_synpred25_MathLang616 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_synpred25_MathLang620 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  MathLang 

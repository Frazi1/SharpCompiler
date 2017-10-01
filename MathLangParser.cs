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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "UNKNOWN", "PRINT", "INPUT", "IF", "FOR", "FUNCTION", "RETURN", "WHILE", "BLOCK", "PROGRAM", "PARAMS", "VAR", "NUMBER", "ID", "TYPE", "ASSIGN", "ARRAY", "ADD", "SUB", "MUL", "DIV", "GREQ", "LSEQ", "NEQ", "EQ", "GR", "LS", "OR", "AND", "TRUE", "FALSE", "ACCESS_MODIFIER", "WS", "SL_COMMENT", "ML_COMMENT", "';'", "'('", "')'"
	};
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

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, true, false, false, false, false, false, false, false, 
				true, false
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
		this.state.ruleMemo = new System.Collections.Generic.Dictionary<int, int>[43+1];

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
	// MathLang.g:35:8: public execute : ( statement )* ;
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

		MathLangParser.statement_return statement1 = default(MathLangParser.statement_return);


		try { DebugEnterRule(GrammarFileName, "execute");
		DebugLocation(35, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 1)) { return retval; }
			// MathLang.g:35:15: ( ( statement )* )
			DebugEnterAlt(1);
			// MathLang.g:36:2: ( statement )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(36, 2);
			// MathLang.g:36:2: ( statement )*
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, decisionCanBacktrack[1]);
				int LA1_0 = input.LA(1);

				if (((LA1_0>=NUMBER && LA1_0<=TYPE)||(LA1_0>=TRUE && LA1_0<=FALSE)||LA1_0==40))
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
					DebugLocation(36, 2);
					PushFollow(Follow._statement_in_execute259);
					statement1=statement();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement1.Tree);

					}
					break;

				default:
					goto loop1;
				}
			}

			loop1:
				;

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
	// MathLang.g:39:1: statement : ( expression | declaration | assignment ) ;
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

		MathLangParser.expression_return expression2 = default(MathLangParser.expression_return);
		MathLangParser.declaration_return declaration3 = default(MathLangParser.declaration_return);
		MathLangParser.assignment_return assignment4 = default(MathLangParser.assignment_return);


		try { DebugEnterRule(GrammarFileName, "statement");
		DebugLocation(39, 15);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 2)) { return retval; }
			// MathLang.g:39:10: ( ( expression | declaration | assignment ) )
			DebugEnterAlt(1);
			// MathLang.g:39:12: ( expression | declaration | assignment )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(39, 12);
			// MathLang.g:39:12: ( expression | declaration | assignment )
			int alt2=3;
			try { DebugEnterSubRule(2);
			try { DebugEnterDecision(2, decisionCanBacktrack[2]);
			switch (input.LA(1))
			{
			case NUMBER:
			case TRUE:
			case FALSE:
			case 40:
				{
				alt2=1;
				}
				break;
			case ID:
				{
				int LA2_2 = input.LA(2);

				if ((LA2_2==ASSIGN))
				{
					alt2=3;
				}
				else if ((LA2_2==EOF||(LA2_2>=NUMBER && LA2_2<=TYPE)||(LA2_2>=ADD && LA2_2<=FALSE)||LA2_2==40))
				{
					alt2=1;
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
			case TYPE:
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
				// MathLang.g:39:13: expression
				{
				DebugLocation(39, 13);
				PushFollow(Follow._expression_in_statement269);
				expression2=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression2.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:40:4: declaration
				{
				DebugLocation(40, 4);
				PushFollow(Follow._declaration_in_statement275);
				declaration3=declaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, declaration3.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:41:4: assignment
				{
				DebugLocation(41, 4);
				PushFollow(Follow._assignment_in_statement281);
				assignment4=assignment();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment4.Tree);

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
			TraceOut("statement", 2);
			LeaveRule("statement", 2);
			Leave_statement();
			if (state.backtracking > 0) { Memoize(input, 2, statement_StartIndex); }
		}
		DebugLocation(41, 15);
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

		IToken set5=null;

		object set5_tree=null;

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
			set5=(IToken)input.LT(1);
			if ((input.LA(1)>=NUMBER && input.LA(1)<=ID))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set5));
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

		MathLangParser.term_return term6 = default(MathLangParser.term_return);


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
			PushFollow(Follow._term_in_mathexpression303);
			term6=term();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term6.Tree);

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

		MathLangParser.mathexpression_return mathexpression7 = default(MathLangParser.mathexpression_return);
		MathLangParser.boolexpression_return boolexpression8 = default(MathLangParser.boolexpression_return);


		try { DebugEnterRule(GrammarFileName, "expression");
		DebugLocation(47, 19);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 5)) { return retval; }
			// MathLang.g:47:11: ( mathexpression | boolexpression )
			int alt3=2;
			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
			switch (input.LA(1))
			{
			case 40:
				{
				int LA3_1 = input.LA(2);

				if ((EvaluatePredicate(synpred5_MathLang_fragment)))
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

				if ((EvaluatePredicate(synpred5_MathLang_fragment)))
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
				// MathLang.g:47:12: mathexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(47, 12);
				PushFollow(Follow._mathexpression_in_expression310);
				mathexpression7=mathexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mathexpression7.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:48:6: boolexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(48, 6);
				PushFollow(Follow._boolexpression_in_expression317);
				boolexpression8=boolexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression8.Tree);

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

		IToken TYPE9=null;
		IToken ID10=null;
		IToken char_literal11=null;
		MathLangParser.longdeclaration_return longdeclaration12 = default(MathLangParser.longdeclaration_return);

		object TYPE9_tree=null;
		object ID10_tree=null;
		object char_literal11_tree=null;

		try { DebugEnterRule(GrammarFileName, "declaration");
		DebugLocation(50, 20);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 6)) { return retval; }
			// MathLang.g:50:12: ( TYPE ID ';' | longdeclaration )
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
				// MathLang.g:50:14: TYPE ID ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(50, 18);
				TYPE9=(IToken)Match(input,TYPE,Follow._TYPE_in_declaration324); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				TYPE9_tree = (object)adaptor.Create(TYPE9);
				root_0 = (object)adaptor.BecomeRoot(TYPE9_tree, root_0);
				}
				DebugLocation(50, 20);
				ID10=(IToken)Match(input,ID,Follow._ID_in_declaration327); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				ID10_tree = (object)adaptor.Create(ID10);
				adaptor.AddChild(root_0, ID10_tree);
				}
				DebugLocation(50, 26);
				char_literal11=(IToken)Match(input,39,Follow._39_in_declaration329); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:51:6: longdeclaration
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(51, 6);
				PushFollow(Follow._longdeclaration_in_declaration337);
				longdeclaration12=longdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclaration12.Tree);

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

		IToken TYPE13=null;
		IToken ID14=null;
		IToken ASSIGN15=null;
		IToken char_literal17=null;
		MathLangParser.expression_return expression16 = default(MathLangParser.expression_return);

		object TYPE13_tree=null;
		object ID14_tree=null;
		object ASSIGN15_tree=null;
		object char_literal17_tree=null;
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
			TYPE13=(IToken)Match(input,TYPE,Follow._TYPE_in_longdeclaration342); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE13);

			DebugLocation(52, 22);
			ID14=(IToken)Match(input,ID,Follow._ID_in_longdeclaration344); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID14);

			DebugLocation(52, 25);
			ASSIGN15=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclaration346); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN15);

			DebugLocation(52, 32);
			PushFollow(Follow._expression_in_longdeclaration348);
			expression16=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression16.Tree);
			DebugLocation(52, 46);
			char_literal17=(IToken)Match(input,39,Follow._39_in_longdeclaration350); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_39.Add(char_literal17);



			{
			// AST REWRITE
			// elements: ASSIGN, TYPE, expression, ID
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

		IToken set18=null;
		IToken ID19=null;

		object set18_tree=null;
		object ID19_tree=null;

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
			set18=(IToken)input.LT(1);
			set18=(IToken)input.LT(1);
			if (input.LA(1)==TYPE||input.LA(1)==ARRAY)
			{
				input.Consume();
				if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set18), root_0);
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
			ID19=(IToken)Match(input,ID,Follow._ID_in_variable382); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			ID19_tree = (object)adaptor.Create(ID19);
			adaptor.AddChild(root_0, ID19_tree);
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

		IToken set21=null;
		MathLangParser.mul_return mul20 = default(MathLangParser.mul_return);
		MathLangParser.mul_return mul22 = default(MathLangParser.mul_return);

		object set21_tree=null;

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
			PushFollow(Follow._mul_in_add388);
			mul20=mul();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul20.Tree);
			DebugLocation(55, 10);
			// MathLang.g:55:10: ( ( ADD | SUB ) mul )*
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
					// MathLang.g:55:12: ( ADD | SUB ) mul
					{
					DebugLocation(55, 12);
					set21=(IToken)input.LT(1);
					set21=(IToken)input.LT(1);
					if ((input.LA(1)>=ADD && input.LA(1)<=SUB))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set21), root_0);
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
					PushFollow(Follow._mul_in_add401);
					mul22=mul();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul22.Tree);

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

		IToken set24=null;
		MathLangParser.group_return group23 = default(MathLangParser.group_return);
		MathLangParser.group_return group25 = default(MathLangParser.group_return);

		object set24_tree=null;

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
			PushFollow(Follow._group_in_mul410);
			group23=group();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group23.Tree);
			DebugLocation(56, 12);
			// MathLang.g:56:12: ( ( MUL | DIV ) group )*
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
					// MathLang.g:56:14: ( MUL | DIV ) group
					{
					DebugLocation(56, 14);
					set24=(IToken)input.LT(1);
					set24=(IToken)input.LT(1);
					if ((input.LA(1)>=MUL && input.LA(1)<=DIV))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set24), root_0);
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
					PushFollow(Follow._group_in_mul423);
					group25=group();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group25.Tree);

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

		IToken set27=null;
		MathLangParser.add_return add26 = default(MathLangParser.add_return);
		MathLangParser.add_return add28 = default(MathLangParser.add_return);

		object set27_tree=null;

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
			PushFollow(Follow._add_in_compare431);
			add26=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add26.Tree);
			DebugLocation(57, 14);
			// MathLang.g:57:14: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
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
				// MathLang.g:57:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
				{
				DebugLocation(57, 16);
				set27=(IToken)input.LT(1);
				set27=(IToken)input.LT(1);
				if ((input.LA(1)>=GREQ && input.LA(1)<=LS))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set27), root_0);
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
				PushFollow(Follow._add_in_compare461);
				add28=add();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add28.Tree);

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

		MathLangParser.add_return add29 = default(MathLangParser.add_return);


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
			PushFollow(Follow._add_in_term473);
			add29=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add29.Tree);

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

		IToken char_literal30=null;
		IToken char_literal32=null;
		MathLangParser.term_return term31 = default(MathLangParser.term_return);
		MathLangParser.number_return number33 = default(MathLangParser.number_return);

		object char_literal30_tree=null;
		object char_literal32_tree=null;

		try { DebugEnterRule(GrammarFileName, "group");
		DebugLocation(61, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 13)) { return retval; }
			// MathLang.g:61:6: ( '(' term ')' | number )
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
				// MathLang.g:61:8: '(' term ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(61, 11);
				char_literal30=(IToken)Match(input,40,Follow._40_in_group480); if (state.failed) return retval;
				DebugLocation(61, 13);
				PushFollow(Follow._term_in_group483);
				term31=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term31.Tree);
				DebugLocation(61, 21);
				char_literal32=(IToken)Match(input,41,Follow._41_in_group485); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:61:25: number
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(61, 25);
				PushFollow(Follow._number_in_group490);
				number33=number();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, number33.Tree);

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

		IToken ID34=null;
		IToken ASSIGN35=null;
		IToken char_literal37=null;
		MathLangParser.expression_return expression36 = default(MathLangParser.expression_return);

		object ID34_tree=null;
		object ASSIGN35_tree=null;
		object char_literal37_tree=null;

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
			ID34=(IToken)Match(input,ID,Follow._ID_in_assignment497); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			ID34_tree = (object)adaptor.Create(ID34);
			adaptor.AddChild(root_0, ID34_tree);
			}
			DebugLocation(63, 22);
			ASSIGN35=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignment499); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			ASSIGN35_tree = (object)adaptor.Create(ASSIGN35);
			root_0 = (object)adaptor.BecomeRoot(ASSIGN35_tree, root_0);
			}
			DebugLocation(63, 24);
			PushFollow(Follow._expression_in_assignment502);
			expression36=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression36.Tree);
			DebugLocation(63, 38);
			char_literal37=(IToken)Match(input,39,Follow._39_in_assignment504); if (state.failed) return retval;

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

		MathLangParser.boolterm_return boolterm38 = default(MathLangParser.boolterm_return);


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
			PushFollow(Follow._boolterm_in_boolexpression511);
			boolterm38=boolterm();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm38.Tree);

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

		MathLangParser.or_return or39 = default(MathLangParser.or_return);


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
			PushFollow(Follow._or_in_boolterm517);
			or39=or();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or39.Tree);

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

		IToken OR41=null;
		MathLangParser.and_return and40 = default(MathLangParser.and_return);
		MathLangParser.and_return and42 = default(MathLangParser.and_return);

		object OR41_tree=null;

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
			PushFollow(Follow._and_in_or523);
			and40=and();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and40.Tree);
			DebugLocation(66, 9);
			// MathLang.g:66:9: ( OR and )*
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
					// MathLang.g:66:10: OR and
					{
					DebugLocation(66, 12);
					OR41=(IToken)Match(input,OR,Follow._OR_in_or526); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR41_tree = (object)adaptor.Create(OR41);
					root_0 = (object)adaptor.BecomeRoot(OR41_tree, root_0);
					}
					DebugLocation(66, 14);
					PushFollow(Follow._and_in_or529);
					and42=and();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and42.Tree);

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

		IToken AND44=null;
		MathLangParser.boolgroup_return boolgroup43 = default(MathLangParser.boolgroup_return);
		MathLangParser.boolgroup_return boolgroup45 = default(MathLangParser.boolgroup_return);

		object AND44_tree=null;

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
			PushFollow(Follow._boolgroup_in_and537);
			boolgroup43=boolgroup();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup43.Tree);
			DebugLocation(67, 16);
			// MathLang.g:67:16: ( AND boolgroup )*
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
					// MathLang.g:67:17: AND boolgroup
					{
					DebugLocation(67, 20);
					AND44=(IToken)Match(input,AND,Follow._AND_in_and540); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND44_tree = (object)adaptor.Create(AND44);
					root_0 = (object)adaptor.BecomeRoot(AND44_tree, root_0);
					}
					DebugLocation(67, 22);
					PushFollow(Follow._boolgroup_in_and543);
					boolgroup45=boolgroup();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup45.Tree);

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

		IToken char_literal46=null;
		IToken char_literal48=null;
		MathLangParser.boolterm_return boolterm47 = default(MathLangParser.boolterm_return);
		MathLangParser.boolvar_return boolvar49 = default(MathLangParser.boolvar_return);

		object char_literal46_tree=null;
		object char_literal48_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolgroup");
		DebugLocation(68, 39);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 19)) { return retval; }
			// MathLang.g:68:10: ( '(' boolterm ')' | boolvar )
			int alt11=2;
			try { DebugEnterDecision(11, decisionCanBacktrack[11]);
			int LA11_0 = input.LA(1);

			if ((LA11_0==40))
			{
				int LA11_1 = input.LA(2);

				if ((EvaluatePredicate(synpred21_MathLang_fragment)))
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
				// MathLang.g:68:12: '(' boolterm ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(68, 15);
				char_literal46=(IToken)Match(input,40,Follow._40_in_boolgroup551); if (state.failed) return retval;
				DebugLocation(68, 17);
				PushFollow(Follow._boolterm_in_boolgroup554);
				boolterm47=boolterm();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm47.Tree);
				DebugLocation(68, 29);
				char_literal48=(IToken)Match(input,41,Follow._41_in_boolgroup556); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:68:33: boolvar
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(68, 33);
				PushFollow(Follow._boolvar_in_boolgroup561);
				boolvar49=boolvar();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolvar49.Tree);

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

		IToken TRUE50=null;
		IToken FALSE51=null;
		MathLangParser.compare_return compare52 = default(MathLangParser.compare_return);

		object TRUE50_tree=null;
		object FALSE51_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolvar");
		DebugLocation(69, 11);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 20)) { return retval; }
			// MathLang.g:69:8: ( TRUE | FALSE | compare )
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
				// MathLang.g:69:10: TRUE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(69, 10);
				TRUE50=(IToken)Match(input,TRUE,Follow._TRUE_in_boolvar567); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				TRUE50_tree = (object)adaptor.Create(TRUE50);
				adaptor.AddChild(root_0, TRUE50_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:70:5: FALSE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(70, 5);
				FALSE51=(IToken)Match(input,FALSE,Follow._FALSE_in_boolvar573); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				FALSE51_tree = (object)adaptor.Create(FALSE51);
				adaptor.AddChild(root_0, FALSE51_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:71:5: compare
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(71, 5);
				PushFollow(Follow._compare_in_boolvar579);
				compare52=compare();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare52.Tree);

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

	partial void Enter_synpred5_MathLang_fragment();
	partial void Leave_synpred5_MathLang_fragment();

	// $ANTLR start synpred5_MathLang
	public void synpred5_MathLang_fragment()
	{
		Enter_synpred5_MathLang_fragment();
		EnterRule("synpred5_MathLang_fragment", 25);
		TraceIn("synpred5_MathLang_fragment", 25);
		try
		{
			// MathLang.g:47:12: ( mathexpression )
			DebugEnterAlt(1);
			// MathLang.g:47:12: mathexpression
			{
			DebugLocation(47, 12);
			PushFollow(Follow._mathexpression_in_synpred5_MathLang310);
			mathexpression();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred5_MathLang_fragment", 25);
			LeaveRule("synpred5_MathLang_fragment", 25);
			Leave_synpred5_MathLang_fragment();
		}
	}
	// $ANTLR end synpred5_MathLang

	partial void Enter_synpred21_MathLang_fragment();
	partial void Leave_synpred21_MathLang_fragment();

	// $ANTLR start synpred21_MathLang
	public void synpred21_MathLang_fragment()
	{
		Enter_synpred21_MathLang_fragment();
		EnterRule("synpred21_MathLang_fragment", 41);
		TraceIn("synpred21_MathLang_fragment", 41);
		try
		{
			// MathLang.g:68:12: ( '(' boolterm ')' )
			DebugEnterAlt(1);
			// MathLang.g:68:12: '(' boolterm ')'
			{
			DebugLocation(68, 12);
			Match(input,40,Follow._40_in_synpred21_MathLang551); if (state.failed) return;
			DebugLocation(68, 17);
			PushFollow(Follow._boolterm_in_synpred21_MathLang554);
			boolterm();
			PopFollow();
			if (state.failed) return;
			DebugLocation(68, 26);
			Match(input,41,Follow._41_in_synpred21_MathLang556); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred21_MathLang_fragment", 41);
			LeaveRule("synpred21_MathLang_fragment", 41);
			Leave_synpred21_MathLang_fragment();
		}
	}
	// $ANTLR end synpred21_MathLang
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
		public static readonly BitSet _statement_in_execute259 = new BitSet(new ulong[]{0x10600070002UL});
		public static readonly BitSet _expression_in_statement269 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declaration_in_statement275 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assignment_in_statement281 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_number0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _term_in_mathexpression303 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathexpression_in_expression310 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolexpression_in_expression317 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_declaration324 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _ID_in_declaration327 = new BitSet(new ulong[]{0x8000000000UL});
		public static readonly BitSet _39_in_declaration329 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _longdeclaration_in_declaration337 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_longdeclaration342 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _ID_in_longdeclaration344 = new BitSet(new ulong[]{0x80000UL});
		public static readonly BitSet _ASSIGN_in_longdeclaration346 = new BitSet(new ulong[]{0x10600030000UL});
		public static readonly BitSet _expression_in_longdeclaration348 = new BitSet(new ulong[]{0x8000000000UL});
		public static readonly BitSet _39_in_longdeclaration350 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_variable373 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _ID_in_variable382 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mul_in_add388 = new BitSet(new ulong[]{0x600002UL});
		public static readonly BitSet _set_in_add392 = new BitSet(new ulong[]{0x10000030000UL});
		public static readonly BitSet _mul_in_add401 = new BitSet(new ulong[]{0x600002UL});
		public static readonly BitSet _group_in_mul410 = new BitSet(new ulong[]{0x1800002UL});
		public static readonly BitSet _set_in_mul414 = new BitSet(new ulong[]{0x10000030000UL});
		public static readonly BitSet _group_in_mul423 = new BitSet(new ulong[]{0x1800002UL});
		public static readonly BitSet _add_in_compare431 = new BitSet(new ulong[]{0x7E000002UL});
		public static readonly BitSet _set_in_compare435 = new BitSet(new ulong[]{0x10000030000UL});
		public static readonly BitSet _add_in_compare461 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _add_in_term473 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _40_in_group480 = new BitSet(new ulong[]{0x10000030000UL});
		public static readonly BitSet _term_in_group483 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _41_in_group485 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _number_in_group490 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_assignment497 = new BitSet(new ulong[]{0x80000UL});
		public static readonly BitSet _ASSIGN_in_assignment499 = new BitSet(new ulong[]{0x10600030000UL});
		public static readonly BitSet _expression_in_assignment502 = new BitSet(new ulong[]{0x8000000000UL});
		public static readonly BitSet _39_in_assignment504 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolterm_in_boolexpression511 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _or_in_boolterm517 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _and_in_or523 = new BitSet(new ulong[]{0x80000002UL});
		public static readonly BitSet _OR_in_or526 = new BitSet(new ulong[]{0x10600030000UL});
		public static readonly BitSet _and_in_or529 = new BitSet(new ulong[]{0x80000002UL});
		public static readonly BitSet _boolgroup_in_and537 = new BitSet(new ulong[]{0x100000002UL});
		public static readonly BitSet _AND_in_and540 = new BitSet(new ulong[]{0x10600030000UL});
		public static readonly BitSet _boolgroup_in_and543 = new BitSet(new ulong[]{0x100000002UL});
		public static readonly BitSet _40_in_boolgroup551 = new BitSet(new ulong[]{0x10600030000UL});
		public static readonly BitSet _boolterm_in_boolgroup554 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _41_in_boolgroup556 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolvar_in_boolgroup561 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TRUE_in_boolvar567 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FALSE_in_boolvar573 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _compare_in_boolvar579 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathexpression_in_synpred5_MathLang310 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _40_in_synpred21_MathLang551 = new BitSet(new ulong[]{0x10600030000UL});
		public static readonly BitSet _boolterm_in_synpred21_MathLang554 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _41_in_synpred21_MathLang556 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  MathLang 

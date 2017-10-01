// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-10-01 18:44:27

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "UNKNOWN", "PRINT", "INPUT", "IF", "ELSE", "FOR", "FUNCTION", "RETURN", "WHILE", "BLOCK", "PROGRAM", "PARAMS", "NUMBER", "ID", "CHAR", "TYPE", "ASSIGN", "ARRAY", "ADD", "SUB", "MUL", "DIV", "GREQ", "LSEQ", "NEQ", "EQ", "GR", "LS", "OR", "AND", "TRUE", "FALSE", "ACCESS_MODIFIER", "PARAMETERS", "WS", "SL_COMMENT", "ML_COMMENT", "';'", "'('", "')'", "','", "'{'", "'}'"
	};
	public const int EOF=-1;
	public const int T__41=41;
	public const int T__42=42;
	public const int T__43=43;
	public const int T__44=44;
	public const int T__45=45;
	public const int T__46=46;
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
	public const int PARAMETERS=37;
	public const int WS=38;
	public const int SL_COMMENT=39;
	public const int ML_COMMENT=40;

	// delegates
	// delegators

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, true, false, false, false, true, false, false, false, false, 
				true, false, false, false, true, false, false, false, false, false, 
				false, false, false
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
		this.state.ruleMemo = new System.Collections.Generic.Dictionary<int, int>[75+1];

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
	// MathLang.g:39:1: statement : ( declaration | assignment | ifstatement | whilestatement | forstatement | funcdeclaration | returnstatement | funccall ) ;
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
		DebugLocation(39, 13);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 2)) { return retval; }
			// MathLang.g:39:10: ( ( declaration | assignment | ifstatement | whilestatement | forstatement | funcdeclaration | returnstatement | funccall ) )
			DebugEnterAlt(1);
			// MathLang.g:39:12: ( declaration | assignment | ifstatement | whilestatement | forstatement | funcdeclaration | returnstatement | funccall )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(39, 12);
			// MathLang.g:39:12: ( declaration | assignment | ifstatement | whilestatement | forstatement | funcdeclaration | returnstatement | funccall )
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
			case 7:
				DebugEnterAlt(7);
				// MathLang.g:45:4: returnstatement
				{
				DebugLocation(45, 4);
				PushFollow(Follow._returnstatement_in_statement307);
				returnstatement9=returnstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, returnstatement9.Tree);

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// MathLang.g:46:4: funccall
				{
				DebugLocation(46, 4);
				PushFollow(Follow._funccall_in_statement312);
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
		DebugLocation(46, 13);
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
	// MathLang.g:48:1: number : ( NUMBER | ID | CHAR );
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

		IToken set11=null;

		object set11_tree=null;

		try { DebugEnterRule(GrammarFileName, "number");
		DebugLocation(48, 8);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 3)) { return retval; }
			// MathLang.g:48:8: ( NUMBER | ID | CHAR )
			DebugEnterAlt(1);
			// MathLang.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(48, 8);
			set11=(IToken)input.LT(1);
			if ((input.LA(1)>=NUMBER && input.LA(1)<=CHAR))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set11));
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
		DebugLocation(50, 8);
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
	// MathLang.g:51:1: mathexpression : term ;
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

		MathLangParser.term_return term12 = default(MathLangParser.term_return);


		try { DebugEnterRule(GrammarFileName, "mathexpression");
		DebugLocation(51, 21);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 4)) { return retval; }
			// MathLang.g:51:15: ( term )
			DebugEnterAlt(1);
			// MathLang.g:51:17: term
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(51, 17);
			PushFollow(Follow._term_in_mathexpression340);
			term12=term();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term12.Tree);

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
		DebugLocation(51, 21);
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
	// MathLang.g:53:1: expression : ( funccallbody | boolexpression | mathexpression );
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

		MathLangParser.funccallbody_return funccallbody13 = default(MathLangParser.funccallbody_return);
		MathLangParser.boolexpression_return boolexpression14 = default(MathLangParser.boolexpression_return);
		MathLangParser.mathexpression_return mathexpression15 = default(MathLangParser.mathexpression_return);


		try { DebugEnterRule(GrammarFileName, "expression");
		DebugLocation(53, 19);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 5)) { return retval; }
			// MathLang.g:53:11: ( funccallbody | boolexpression | mathexpression )
			int alt2=3;
			try { DebugEnterDecision(2, decisionCanBacktrack[2]);
			switch (input.LA(1))
			{
			case ID:
				{
				int LA2_1 = input.LA(2);

				if ((EvaluatePredicate(synpred10_MathLang_fragment)))
				{
					alt2=1;
				}
				else if ((EvaluatePredicate(synpred11_MathLang_fragment)))
				{
					alt2=2;
				}
				else if ((true))
				{
					alt2=3;
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
			case 42:
				{
				int LA2_2 = input.LA(2);

				if ((EvaluatePredicate(synpred11_MathLang_fragment)))
				{
					alt2=2;
				}
				else if ((true))
				{
					alt2=3;
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
			case NUMBER:
			case CHAR:
				{
				int LA2_5 = input.LA(2);

				if ((EvaluatePredicate(synpred11_MathLang_fragment)))
				{
					alt2=2;
				}
				else if ((true))
				{
					alt2=3;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 2, 5, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
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
				// MathLang.g:53:14: funccallbody
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(53, 14);
				PushFollow(Follow._funccallbody_in_expression349);
				funccallbody13=funccallbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody13.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:54:6: boolexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(54, 6);
				PushFollow(Follow._boolexpression_in_expression356);
				boolexpression14=boolexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression14.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:55:6: mathexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(55, 6);
				PushFollow(Follow._mathexpression_in_expression363);
				mathexpression15=mathexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mathexpression15.Tree);

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
		DebugLocation(55, 19);
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
	// MathLang.g:57:1: declaration : ( TYPE ID ';' | longdeclaration );
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

		IToken TYPE16=null;
		IToken ID17=null;
		IToken char_literal18=null;
		MathLangParser.longdeclaration_return longdeclaration19 = default(MathLangParser.longdeclaration_return);

		object TYPE16_tree=null;
		object ID17_tree=null;
		object char_literal18_tree=null;

		try { DebugEnterRule(GrammarFileName, "declaration");
		DebugLocation(57, 20);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 6)) { return retval; }
			// MathLang.g:57:12: ( TYPE ID ';' | longdeclaration )
			int alt3=2;
			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
			int LA3_0 = input.LA(1);

			if ((LA3_0==TYPE))
			{
				int LA3_1 = input.LA(2);

				if ((LA3_1==ID))
				{
					int LA3_2 = input.LA(3);

					if ((LA3_2==41))
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
				// MathLang.g:57:14: TYPE ID ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(57, 18);
				TYPE16=(IToken)Match(input,TYPE,Follow._TYPE_in_declaration370); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				TYPE16_tree = (object)adaptor.Create(TYPE16);
				root_0 = (object)adaptor.BecomeRoot(TYPE16_tree, root_0);
				}
				DebugLocation(57, 20);
				ID17=(IToken)Match(input,ID,Follow._ID_in_declaration373); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				ID17_tree = (object)adaptor.Create(ID17);
				adaptor.AddChild(root_0, ID17_tree);
				}
				DebugLocation(57, 26);
				char_literal18=(IToken)Match(input,41,Follow._41_in_declaration375); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:58:6: longdeclaration
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(58, 6);
				PushFollow(Follow._longdeclaration_in_declaration383);
				longdeclaration19=longdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclaration19.Tree);

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
		DebugLocation(58, 20);
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
	// MathLang.g:60:1: declarationbody : TYPE ID ;
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

		IToken TYPE20=null;
		IToken ID21=null;

		object TYPE20_tree=null;
		object ID21_tree=null;

		try { DebugEnterRule(GrammarFileName, "declarationbody");
		DebugLocation(60, 26);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 7)) { return retval; }
			// MathLang.g:60:16: ( TYPE ID )
			DebugEnterAlt(1);
			// MathLang.g:60:18: TYPE ID
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(60, 22);
			TYPE20=(IToken)Match(input,TYPE,Follow._TYPE_in_declarationbody390); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			TYPE20_tree = (object)adaptor.Create(TYPE20);
			root_0 = (object)adaptor.BecomeRoot(TYPE20_tree, root_0);
			}
			DebugLocation(60, 24);
			ID21=(IToken)Match(input,ID,Follow._ID_in_declarationbody393); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			ID21_tree = (object)adaptor.Create(ID21);
			adaptor.AddChild(root_0, ID21_tree);
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
		DebugLocation(60, 26);
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
	// MathLang.g:62:1: longdeclaration : TYPE ID ASSIGN expression ';' -> ^( ASSIGN ^( TYPE ID ) expression ) ;
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

		IToken TYPE22=null;
		IToken ID23=null;
		IToken ASSIGN24=null;
		IToken char_literal26=null;
		MathLangParser.expression_return expression25 = default(MathLangParser.expression_return);

		object TYPE22_tree=null;
		object ID23_tree=null;
		object ASSIGN24_tree=null;
		object char_literal26_tree=null;
		RewriteRuleITokenStream stream_41=new RewriteRuleITokenStream(adaptor,"token 41");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "longdeclaration");
		DebugLocation(62, 82);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 8)) { return retval; }
			// MathLang.g:62:16: ( TYPE ID ASSIGN expression ';' -> ^( ASSIGN ^( TYPE ID ) expression ) )
			DebugEnterAlt(1);
			// MathLang.g:62:17: TYPE ID ASSIGN expression ';'
			{
			DebugLocation(62, 17);
			TYPE22=(IToken)Match(input,TYPE,Follow._TYPE_in_longdeclaration400); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE22);

			DebugLocation(62, 22);
			ID23=(IToken)Match(input,ID,Follow._ID_in_longdeclaration402); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID23);

			DebugLocation(62, 25);
			ASSIGN24=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclaration404); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN24);

			DebugLocation(62, 32);
			PushFollow(Follow._expression_in_longdeclaration406);
			expression25=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression25.Tree);
			DebugLocation(62, 46);
			char_literal26=(IToken)Match(input,41,Follow._41_in_longdeclaration408); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_41.Add(char_literal26);



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
			// 62:48: -> ^( ASSIGN ^( TYPE ID ) expression )
			{
				DebugLocation(62, 51);
				// MathLang.g:62:51: ^( ASSIGN ^( TYPE ID ) expression )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(62, 53);
				root_1 = (object)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_1);

				DebugLocation(62, 60);
				// MathLang.g:62:60: ^( TYPE ID )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(62, 62);
				root_2 = (object)adaptor.BecomeRoot(stream_TYPE.NextNode(), root_2);

				DebugLocation(62, 67);
				adaptor.AddChild(root_2, stream_ID.NextNode());

				adaptor.AddChild(root_1, root_2);
				}
				DebugLocation(62, 71);
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
		DebugLocation(62, 82);
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
	// MathLang.g:64:1: longdeclarationbody : TYPE ID ASSIGN expression -> ^( ASSIGN ^( TYPE ID ) expression ) ;
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

		IToken TYPE27=null;
		IToken ID28=null;
		IToken ASSIGN29=null;
		MathLangParser.expression_return expression30 = default(MathLangParser.expression_return);

		object TYPE27_tree=null;
		object ID28_tree=null;
		object ASSIGN29_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "longdeclarationbody");
		DebugLocation(64, 82);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 9)) { return retval; }
			// MathLang.g:64:20: ( TYPE ID ASSIGN expression -> ^( ASSIGN ^( TYPE ID ) expression ) )
			DebugEnterAlt(1);
			// MathLang.g:64:22: TYPE ID ASSIGN expression
			{
			DebugLocation(64, 22);
			TYPE27=(IToken)Match(input,TYPE,Follow._TYPE_in_longdeclarationbody431); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE27);

			DebugLocation(64, 27);
			ID28=(IToken)Match(input,ID,Follow._ID_in_longdeclarationbody433); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID28);

			DebugLocation(64, 30);
			ASSIGN29=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclarationbody435); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN29);

			DebugLocation(64, 37);
			PushFollow(Follow._expression_in_longdeclarationbody437);
			expression30=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression30.Tree);


			{
			// AST REWRITE
			// elements: ID, ASSIGN, TYPE, expression
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 64:48: -> ^( ASSIGN ^( TYPE ID ) expression )
			{
				DebugLocation(64, 51);
				// MathLang.g:64:51: ^( ASSIGN ^( TYPE ID ) expression )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(64, 53);
				root_1 = (object)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_1);

				DebugLocation(64, 60);
				// MathLang.g:64:60: ^( TYPE ID )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(64, 62);
				root_2 = (object)adaptor.BecomeRoot(stream_TYPE.NextNode(), root_2);

				DebugLocation(64, 67);
				adaptor.AddChild(root_2, stream_ID.NextNode());

				adaptor.AddChild(root_1, root_2);
				}
				DebugLocation(64, 71);
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
		DebugLocation(64, 82);
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
	// MathLang.g:66:1: variable : ( TYPE | ARRAY ) ID ;
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

		IToken set31=null;
		IToken ID32=null;

		object set31_tree=null;
		object ID32_tree=null;

		try { DebugEnterRule(GrammarFileName, "variable");
		DebugLocation(66, 28);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 10)) { return retval; }
			// MathLang.g:66:9: ( ( TYPE | ARRAY ) ID )
			DebugEnterAlt(1);
			// MathLang.g:66:11: ( TYPE | ARRAY ) ID
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(66, 11);
			set31=(IToken)input.LT(1);
			set31=(IToken)input.LT(1);
			if (input.LA(1)==TYPE||input.LA(1)==ARRAY)
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

			DebugLocation(66, 27);
			ID32=(IToken)Match(input,ID,Follow._ID_in_variable468); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			ID32_tree = (object)adaptor.Create(ID32);
			adaptor.AddChild(root_0, ID32_tree);
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
		DebugLocation(66, 28);
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
	// MathLang.g:67:1: add : mul ( ( ADD | SUB ) mul )* ;
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

		IToken set34=null;
		MathLangParser.mul_return mul33 = default(MathLangParser.mul_return);
		MathLangParser.mul_return mul35 = default(MathLangParser.mul_return);

		object set34_tree=null;

		try { DebugEnterRule(GrammarFileName, "add");
		DebugLocation(67, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 11)) { return retval; }
			// MathLang.g:67:4: ( mul ( ( ADD | SUB ) mul )* )
			DebugEnterAlt(1);
			// MathLang.g:67:6: mul ( ( ADD | SUB ) mul )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(67, 6);
			PushFollow(Follow._mul_in_add474);
			mul33=mul();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul33.Tree);
			DebugLocation(67, 10);
			// MathLang.g:67:10: ( ( ADD | SUB ) mul )*
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
					// MathLang.g:67:12: ( ADD | SUB ) mul
					{
					DebugLocation(67, 12);
					set34=(IToken)input.LT(1);
					set34=(IToken)input.LT(1);
					if ((input.LA(1)>=ADD && input.LA(1)<=SUB))
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

					DebugLocation(67, 25);
					PushFollow(Follow._mul_in_add487);
					mul35=mul();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul35.Tree);

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
		DebugLocation(67, 30);
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
	// MathLang.g:68:1: mul : group ( ( MUL | DIV ) group )* ;
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

		IToken set37=null;
		MathLangParser.group_return group36 = default(MathLangParser.group_return);
		MathLangParser.group_return group38 = default(MathLangParser.group_return);

		object set37_tree=null;

		try { DebugEnterRule(GrammarFileName, "mul");
		DebugLocation(68, 33);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 12)) { return retval; }
			// MathLang.g:68:4: ( group ( ( MUL | DIV ) group )* )
			DebugEnterAlt(1);
			// MathLang.g:68:6: group ( ( MUL | DIV ) group )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(68, 6);
			PushFollow(Follow._group_in_mul496);
			group36=group();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group36.Tree);
			DebugLocation(68, 12);
			// MathLang.g:68:12: ( ( MUL | DIV ) group )*
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
					// MathLang.g:68:14: ( MUL | DIV ) group
					{
					DebugLocation(68, 14);
					set37=(IToken)input.LT(1);
					set37=(IToken)input.LT(1);
					if ((input.LA(1)>=MUL && input.LA(1)<=DIV))
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

					DebugLocation(68, 27);
					PushFollow(Follow._group_in_mul509);
					group38=group();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group38.Tree);

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
		DebugLocation(68, 33);
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
	// MathLang.g:69:1: compare : add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )? ;
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

		IToken set40=null;
		MathLangParser.add_return add39 = default(MathLangParser.add_return);
		MathLangParser.add_return add41 = default(MathLangParser.add_return);

		object set40_tree=null;

		try { DebugEnterRule(GrammarFileName, "compare");
		DebugLocation(69, 60);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 13)) { return retval; }
			// MathLang.g:69:8: ( add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )? )
			DebugEnterAlt(1);
			// MathLang.g:69:10: add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(69, 10);
			PushFollow(Follow._add_in_compare517);
			add39=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add39.Tree);
			DebugLocation(69, 14);
			// MathLang.g:69:14: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
			int alt6=2;
			try { DebugEnterSubRule(6);
			try { DebugEnterDecision(6, decisionCanBacktrack[6]);
			int LA6_0 = input.LA(1);

			if (((LA6_0>=NEQ && LA6_0<=EQ)))
			{
				int LA6_1 = input.LA(2);

				if ((EvaluatePredicate(synpred23_MathLang_fragment)))
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
				// MathLang.g:69:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
				{
				DebugLocation(69, 16);
				set40=(IToken)input.LT(1);
				set40=(IToken)input.LT(1);
				if ((input.LA(1)>=GREQ && input.LA(1)<=LS))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set40), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(69, 53);
				PushFollow(Follow._add_in_compare547);
				add41=add();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add41.Tree);

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
		DebugLocation(69, 60);
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
	// MathLang.g:71:1: term : add ;
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

		MathLangParser.add_return add42 = default(MathLangParser.add_return);


		try { DebugEnterRule(GrammarFileName, "term");
		DebugLocation(71, 9);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 14)) { return retval; }
			// MathLang.g:71:5: ( add )
			DebugEnterAlt(1);
			// MathLang.g:71:7: add
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(71, 7);
			PushFollow(Follow._add_in_term559);
			add42=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add42.Tree);

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
		DebugLocation(71, 9);
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
	// MathLang.g:73:1: group : ( '(' term ')' | number );
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

		IToken char_literal43=null;
		IToken char_literal45=null;
		MathLangParser.term_return term44 = default(MathLangParser.term_return);
		MathLangParser.number_return number46 = default(MathLangParser.number_return);

		object char_literal43_tree=null;
		object char_literal45_tree=null;

		try { DebugEnterRule(GrammarFileName, "group");
		DebugLocation(73, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 15)) { return retval; }
			// MathLang.g:73:6: ( '(' term ')' | number )
			int alt7=2;
			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
			int LA7_0 = input.LA(1);

			if ((LA7_0==42))
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
				// MathLang.g:73:8: '(' term ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(73, 11);
				char_literal43=(IToken)Match(input,42,Follow._42_in_group566); if (state.failed) return retval;
				DebugLocation(73, 13);
				PushFollow(Follow._term_in_group569);
				term44=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term44.Tree);
				DebugLocation(73, 21);
				char_literal45=(IToken)Match(input,43,Follow._43_in_group571); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:73:25: number
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(73, 25);
				PushFollow(Follow._number_in_group576);
				number46=number();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, number46.Tree);

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
		DebugLocation(73, 30);
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
	// MathLang.g:75:1: assignment : ID ASSIGN expression ';' ;
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

		IToken ID47=null;
		IToken ASSIGN48=null;
		IToken char_literal50=null;
		MathLangParser.expression_return expression49 = default(MathLangParser.expression_return);

		object ID47_tree=null;
		object ASSIGN48_tree=null;
		object char_literal50_tree=null;

		try { DebugEnterRule(GrammarFileName, "assignment");
		DebugLocation(75, 38);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 16)) { return retval; }
			// MathLang.g:75:11: ( ID ASSIGN expression ';' )
			DebugEnterAlt(1);
			// MathLang.g:75:13: ID ASSIGN expression ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(75, 13);
			ID47=(IToken)Match(input,ID,Follow._ID_in_assignment583); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			ID47_tree = (object)adaptor.Create(ID47);
			adaptor.AddChild(root_0, ID47_tree);
			}
			DebugLocation(75, 22);
			ASSIGN48=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignment585); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			ASSIGN48_tree = (object)adaptor.Create(ASSIGN48);
			root_0 = (object)adaptor.BecomeRoot(ASSIGN48_tree, root_0);
			}
			DebugLocation(75, 24);
			PushFollow(Follow._expression_in_assignment588);
			expression49=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression49.Tree);
			DebugLocation(75, 38);
			char_literal50=(IToken)Match(input,41,Follow._41_in_assignment590); if (state.failed) return retval;

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
		DebugLocation(75, 38);
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
	// MathLang.g:76:1: assignmentbody : ID ASSIGN expression ;
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

		IToken ID51=null;
		IToken ASSIGN52=null;
		MathLangParser.expression_return expression53 = default(MathLangParser.expression_return);

		object ID51_tree=null;
		object ASSIGN52_tree=null;

		try { DebugEnterRule(GrammarFileName, "assignmentbody");
		DebugLocation(76, 38);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 17)) { return retval; }
			// MathLang.g:76:15: ( ID ASSIGN expression )
			DebugEnterAlt(1);
			// MathLang.g:76:17: ID ASSIGN expression
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(76, 17);
			ID51=(IToken)Match(input,ID,Follow._ID_in_assignmentbody597); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			ID51_tree = (object)adaptor.Create(ID51);
			adaptor.AddChild(root_0, ID51_tree);
			}
			DebugLocation(76, 26);
			ASSIGN52=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignmentbody599); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			ASSIGN52_tree = (object)adaptor.Create(ASSIGN52);
			root_0 = (object)adaptor.BecomeRoot(ASSIGN52_tree, root_0);
			}
			DebugLocation(76, 28);
			PushFollow(Follow._expression_in_assignmentbody602);
			expression53=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression53.Tree);

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
		DebugLocation(76, 38);
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
	// MathLang.g:78:1: boolexpression : boolterm ;
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

		MathLangParser.boolterm_return boolterm54 = default(MathLangParser.boolterm_return);


		try { DebugEnterRule(GrammarFileName, "boolexpression");
		DebugLocation(78, 24);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 18)) { return retval; }
			// MathLang.g:78:15: ( boolterm )
			DebugEnterAlt(1);
			// MathLang.g:78:17: boolterm
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(78, 17);
			PushFollow(Follow._boolterm_in_boolexpression610);
			boolterm54=boolterm();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm54.Tree);

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
		DebugLocation(78, 24);
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
	// MathLang.g:79:1: boolterm : or ( ( EQ | NEQ ) or )? ;
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

		IToken set56=null;
		MathLangParser.or_return or55 = default(MathLangParser.or_return);
		MathLangParser.or_return or57 = default(MathLangParser.or_return);

		object set56_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolterm");
		DebugLocation(79, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 19)) { return retval; }
			// MathLang.g:79:9: ( or ( ( EQ | NEQ ) or )? )
			DebugEnterAlt(1);
			// MathLang.g:79:11: or ( ( EQ | NEQ ) or )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(79, 11);
			PushFollow(Follow._or_in_boolterm616);
			or55=or();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or55.Tree);
			DebugLocation(79, 14);
			// MathLang.g:79:14: ( ( EQ | NEQ ) or )?
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
				// MathLang.g:79:16: ( EQ | NEQ ) or
				{
				DebugLocation(79, 16);
				set56=(IToken)input.LT(1);
				set56=(IToken)input.LT(1);
				if ((input.LA(1)>=NEQ && input.LA(1)<=EQ))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set56), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(79, 28);
				PushFollow(Follow._or_in_boolterm629);
				or57=or();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or57.Tree);

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
		DebugLocation(79, 32);
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
	// MathLang.g:80:1: or : and ( OR and )* ;
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

		IToken OR59=null;
		MathLangParser.and_return and58 = default(MathLangParser.and_return);
		MathLangParser.and_return and60 = default(MathLangParser.and_return);

		object OR59_tree=null;

		try { DebugEnterRule(GrammarFileName, "or");
		DebugLocation(80, 18);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 20)) { return retval; }
			// MathLang.g:80:3: ( and ( OR and )* )
			DebugEnterAlt(1);
			// MathLang.g:80:5: and ( OR and )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(80, 5);
			PushFollow(Follow._and_in_or638);
			and58=and();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and58.Tree);
			DebugLocation(80, 9);
			// MathLang.g:80:9: ( OR and )*
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
					// MathLang.g:80:10: OR and
					{
					DebugLocation(80, 12);
					OR59=(IToken)Match(input,OR,Follow._OR_in_or641); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR59_tree = (object)adaptor.Create(OR59);
					root_0 = (object)adaptor.BecomeRoot(OR59_tree, root_0);
					}
					DebugLocation(80, 14);
					PushFollow(Follow._and_in_or644);
					and60=and();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and60.Tree);

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
		DebugLocation(80, 18);
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
	// MathLang.g:81:1: and : boolgroup ( AND boolgroup )* ;
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

		IToken AND62=null;
		MathLangParser.boolgroup_return boolgroup61 = default(MathLangParser.boolgroup_return);
		MathLangParser.boolgroup_return boolgroup63 = default(MathLangParser.boolgroup_return);

		object AND62_tree=null;

		try { DebugEnterRule(GrammarFileName, "and");
		DebugLocation(81, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 21)) { return retval; }
			// MathLang.g:81:4: ( boolgroup ( AND boolgroup )* )
			DebugEnterAlt(1);
			// MathLang.g:81:6: boolgroup ( AND boolgroup )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(81, 6);
			PushFollow(Follow._boolgroup_in_and652);
			boolgroup61=boolgroup();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup61.Tree);
			DebugLocation(81, 16);
			// MathLang.g:81:16: ( AND boolgroup )*
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
					// MathLang.g:81:17: AND boolgroup
					{
					DebugLocation(81, 20);
					AND62=(IToken)Match(input,AND,Follow._AND_in_and655); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND62_tree = (object)adaptor.Create(AND62);
					root_0 = (object)adaptor.BecomeRoot(AND62_tree, root_0);
					}
					DebugLocation(81, 22);
					PushFollow(Follow._boolgroup_in_and658);
					boolgroup63=boolgroup();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup63.Tree);

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
		DebugLocation(81, 32);
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
	// MathLang.g:82:1: boolgroup : ( '(' boolterm ')' | boolvar );
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

		IToken char_literal64=null;
		IToken char_literal66=null;
		MathLangParser.boolterm_return boolterm65 = default(MathLangParser.boolterm_return);
		MathLangParser.boolvar_return boolvar67 = default(MathLangParser.boolvar_return);

		object char_literal64_tree=null;
		object char_literal66_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolgroup");
		DebugLocation(82, 39);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 22)) { return retval; }
			// MathLang.g:82:10: ( '(' boolterm ')' | boolvar )
			int alt11=2;
			try { DebugEnterDecision(11, decisionCanBacktrack[11]);
			int LA11_0 = input.LA(1);

			if ((LA11_0==42))
			{
				int LA11_1 = input.LA(2);

				if ((EvaluatePredicate(synpred29_MathLang_fragment)))
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
				// MathLang.g:82:12: '(' boolterm ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(82, 15);
				char_literal64=(IToken)Match(input,42,Follow._42_in_boolgroup666); if (state.failed) return retval;
				DebugLocation(82, 17);
				PushFollow(Follow._boolterm_in_boolgroup669);
				boolterm65=boolterm();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm65.Tree);
				DebugLocation(82, 29);
				char_literal66=(IToken)Match(input,43,Follow._43_in_boolgroup671); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:82:33: boolvar
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(82, 33);
				PushFollow(Follow._boolvar_in_boolgroup676);
				boolvar67=boolvar();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolvar67.Tree);

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
		DebugLocation(82, 39);
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
	// MathLang.g:83:1: boolvar : ( TRUE | FALSE | compare );
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

		IToken TRUE68=null;
		IToken FALSE69=null;
		MathLangParser.compare_return compare70 = default(MathLangParser.compare_return);

		object TRUE68_tree=null;
		object FALSE69_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolvar");
		DebugLocation(83, 11);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 23)) { return retval; }
			// MathLang.g:83:8: ( TRUE | FALSE | compare )
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
			case 42:
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
				// MathLang.g:83:10: TRUE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(83, 10);
				TRUE68=(IToken)Match(input,TRUE,Follow._TRUE_in_boolvar682); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				TRUE68_tree = (object)adaptor.Create(TRUE68);
				adaptor.AddChild(root_0, TRUE68_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:84:5: FALSE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(84, 5);
				FALSE69=(IToken)Match(input,FALSE,Follow._FALSE_in_boolvar688); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				FALSE69_tree = (object)adaptor.Create(FALSE69);
				adaptor.AddChild(root_0, FALSE69_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:85:5: compare
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(85, 5);
				PushFollow(Follow._compare_in_boolvar694);
				compare70=compare();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare70.Tree);

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
		DebugLocation(85, 11);
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
	// MathLang.g:87:1: ifstatement : IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )* ;
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

		IToken IF71=null;
		IToken char_literal72=null;
		IToken char_literal74=null;
		IToken ELSE77=null;
		MathLangParser.boolexpression_return boolexpression73 = default(MathLangParser.boolexpression_return);
		MathLangParser.block_return block75 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement76 = default(MathLangParser.statement_return);
		MathLangParser.block_return block78 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement79 = default(MathLangParser.statement_return);

		object IF71_tree=null;
		object char_literal72_tree=null;
		object char_literal74_tree=null;
		object ELSE77_tree=null;

		try { DebugEnterRule(GrammarFileName, "ifstatement");
		DebugLocation(87, 91);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 24)) { return retval; }
			// MathLang.g:87:12: ( IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )* )
			DebugEnterAlt(1);
			// MathLang.g:87:14: IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(87, 16);
			IF71=(IToken)Match(input,IF,Follow._IF_in_ifstatement701); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			IF71_tree = (object)adaptor.Create(IF71);
			root_0 = (object)adaptor.BecomeRoot(IF71_tree, root_0);
			}
			DebugLocation(87, 21);
			char_literal72=(IToken)Match(input,42,Follow._42_in_ifstatement704); if (state.failed) return retval;
			DebugLocation(87, 23);
			PushFollow(Follow._boolexpression_in_ifstatement707);
			boolexpression73=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression73.Tree);
			DebugLocation(87, 41);
			char_literal74=(IToken)Match(input,43,Follow._43_in_ifstatement709); if (state.failed) return retval;
			DebugLocation(87, 43);
			// MathLang.g:87:43: ( block | statement )
			int alt13=2;
			try { DebugEnterSubRule(13);
			try { DebugEnterDecision(13, decisionCanBacktrack[13]);
			int LA13_0 = input.LA(1);

			if ((LA13_0==45))
			{
				alt13=1;
			}
			else if ((LA13_0==IF||LA13_0==FOR||(LA13_0>=RETURN && LA13_0<=WHILE)||LA13_0==ID||LA13_0==TYPE))
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
				// MathLang.g:87:44: block
				{
				DebugLocation(87, 44);
				PushFollow(Follow._block_in_ifstatement713);
				block75=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block75.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:87:52: statement
				{
				DebugLocation(87, 52);
				PushFollow(Follow._statement_in_ifstatement717);
				statement76=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement76.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(13); }

			DebugLocation(87, 63);
			// MathLang.g:87:63: ( ELSE ( block | statement ) )*
			try { DebugEnterSubRule(15);
			while (true)
			{
				int alt15=2;
				try { DebugEnterDecision(15, decisionCanBacktrack[15]);
				int LA15_0 = input.LA(1);

				if ((LA15_0==ELSE))
				{
					int LA15_1 = input.LA(2);

					if ((EvaluatePredicate(synpred34_MathLang_fragment)))
					{
						alt15=1;
					}


				}


				} finally { DebugExitDecision(15); }
				switch ( alt15 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:87:64: ELSE ( block | statement )
					{
					DebugLocation(87, 68);
					ELSE77=(IToken)Match(input,ELSE,Follow._ELSE_in_ifstatement721); if (state.failed) return retval;
					DebugLocation(87, 70);
					// MathLang.g:87:70: ( block | statement )
					int alt14=2;
					try { DebugEnterSubRule(14);
					try { DebugEnterDecision(14, decisionCanBacktrack[14]);
					int LA14_0 = input.LA(1);

					if ((LA14_0==45))
					{
						alt14=1;
					}
					else if ((LA14_0==IF||LA14_0==FOR||(LA14_0>=RETURN && LA14_0<=WHILE)||LA14_0==ID||LA14_0==TYPE))
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
						// MathLang.g:87:71: block
						{
						DebugLocation(87, 71);
						PushFollow(Follow._block_in_ifstatement725);
						block78=block();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block78.Tree);

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// MathLang.g:87:79: statement
						{
						DebugLocation(87, 79);
						PushFollow(Follow._statement_in_ifstatement729);
						statement79=statement();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement79.Tree);

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
		DebugLocation(87, 91);
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
	// MathLang.g:89:1: whilestatement : WHILE '(' boolexpression ')' ( block | statement ) ;
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

		IToken WHILE80=null;
		IToken char_literal81=null;
		IToken char_literal83=null;
		MathLangParser.boolexpression_return boolexpression82 = default(MathLangParser.boolexpression_return);
		MathLangParser.block_return block84 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement85 = default(MathLangParser.statement_return);

		object WHILE80_tree=null;
		object char_literal81_tree=null;
		object char_literal83_tree=null;

		try { DebugEnterRule(GrammarFileName, "whilestatement");
		DebugLocation(89, 67);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 25)) { return retval; }
			// MathLang.g:89:15: ( WHILE '(' boolexpression ')' ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:89:17: WHILE '(' boolexpression ')' ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(89, 22);
			WHILE80=(IToken)Match(input,WHILE,Follow._WHILE_in_whilestatement740); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			WHILE80_tree = (object)adaptor.Create(WHILE80);
			root_0 = (object)adaptor.BecomeRoot(WHILE80_tree, root_0);
			}
			DebugLocation(89, 27);
			char_literal81=(IToken)Match(input,42,Follow._42_in_whilestatement743); if (state.failed) return retval;
			DebugLocation(89, 29);
			PushFollow(Follow._boolexpression_in_whilestatement746);
			boolexpression82=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression82.Tree);
			DebugLocation(89, 47);
			char_literal83=(IToken)Match(input,43,Follow._43_in_whilestatement748); if (state.failed) return retval;
			DebugLocation(89, 49);
			// MathLang.g:89:49: ( block | statement )
			int alt16=2;
			try { DebugEnterSubRule(16);
			try { DebugEnterDecision(16, decisionCanBacktrack[16]);
			int LA16_0 = input.LA(1);

			if ((LA16_0==45))
			{
				alt16=1;
			}
			else if ((LA16_0==IF||LA16_0==FOR||(LA16_0>=RETURN && LA16_0<=WHILE)||LA16_0==ID||LA16_0==TYPE))
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
				// MathLang.g:89:50: block
				{
				DebugLocation(89, 50);
				PushFollow(Follow._block_in_whilestatement752);
				block84=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block84.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:89:58: statement
				{
				DebugLocation(89, 58);
				PushFollow(Follow._statement_in_whilestatement756);
				statement85=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement85.Tree);

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
		DebugLocation(89, 67);
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
	// MathLang.g:91:1: forstatement : FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement ) ;
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

		IToken FOR86=null;
		IToken char_literal87=null;
		IToken char_literal89=null;
		IToken char_literal91=null;
		IToken char_literal93=null;
		MathLangParser.longdeclarationbody_return longdeclarationbody88 = default(MathLangParser.longdeclarationbody_return);
		MathLangParser.boolexpression_return boolexpression90 = default(MathLangParser.boolexpression_return);
		MathLangParser.assignmentbody_return assignmentbody92 = default(MathLangParser.assignmentbody_return);
		MathLangParser.block_return block94 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement95 = default(MathLangParser.statement_return);

		object FOR86_tree=null;
		object char_literal87_tree=null;
		object char_literal89_tree=null;
		object char_literal91_tree=null;
		object char_literal93_tree=null;

		try { DebugEnterRule(GrammarFileName, "forstatement");
		DebugLocation(91, 108);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 26)) { return retval; }
			// MathLang.g:91:13: ( FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:91:15: FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(91, 18);
			FOR86=(IToken)Match(input,FOR,Follow._FOR_in_forstatement764); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			FOR86_tree = (object)adaptor.Create(FOR86);
			root_0 = (object)adaptor.BecomeRoot(FOR86_tree, root_0);
			}
			DebugLocation(91, 23);
			char_literal87=(IToken)Match(input,42,Follow._42_in_forstatement767); if (state.failed) return retval;
			DebugLocation(91, 25);
			PushFollow(Follow._longdeclarationbody_in_forstatement770);
			longdeclarationbody88=longdeclarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclarationbody88.Tree);
			DebugLocation(91, 48);
			char_literal89=(IToken)Match(input,41,Follow._41_in_forstatement772); if (state.failed) return retval;
			DebugLocation(91, 50);
			PushFollow(Follow._boolexpression_in_forstatement775);
			boolexpression90=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression90.Tree);
			DebugLocation(91, 68);
			char_literal91=(IToken)Match(input,41,Follow._41_in_forstatement777); if (state.failed) return retval;
			DebugLocation(91, 70);
			PushFollow(Follow._assignmentbody_in_forstatement780);
			assignmentbody92=assignmentbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentbody92.Tree);
			DebugLocation(91, 88);
			char_literal93=(IToken)Match(input,43,Follow._43_in_forstatement782); if (state.failed) return retval;
			DebugLocation(91, 90);
			// MathLang.g:91:90: ( block | statement )
			int alt17=2;
			try { DebugEnterSubRule(17);
			try { DebugEnterDecision(17, decisionCanBacktrack[17]);
			int LA17_0 = input.LA(1);

			if ((LA17_0==45))
			{
				alt17=1;
			}
			else if ((LA17_0==IF||LA17_0==FOR||(LA17_0>=RETURN && LA17_0<=WHILE)||LA17_0==ID||LA17_0==TYPE))
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
				// MathLang.g:91:91: block
				{
				DebugLocation(91, 91);
				PushFollow(Follow._block_in_forstatement786);
				block94=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block94.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:91:99: statement
				{
				DebugLocation(91, 99);
				PushFollow(Follow._statement_in_forstatement790);
				statement95=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement95.Tree);

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
		DebugLocation(91, 108);
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
	// MathLang.g:93:1: funcdeclaration : TYPE ID '(' ( paramsdeclaration )? ')' block ;
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

		IToken TYPE96=null;
		IToken ID97=null;
		IToken char_literal98=null;
		IToken char_literal100=null;
		MathLangParser.paramsdeclaration_return paramsdeclaration99 = default(MathLangParser.paramsdeclaration_return);
		MathLangParser.block_return block101 = default(MathLangParser.block_return);

		object TYPE96_tree=null;
		object ID97_tree=null;
		object char_literal98_tree=null;
		object char_literal100_tree=null;

		try { DebugEnterRule(GrammarFileName, "funcdeclaration");
		DebugLocation(93, 60);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 27)) { return retval; }
			// MathLang.g:93:16: ( TYPE ID '(' ( paramsdeclaration )? ')' block )
			DebugEnterAlt(1);
			// MathLang.g:93:18: TYPE ID '(' ( paramsdeclaration )? ')' block
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(93, 18);
			TYPE96=(IToken)Match(input,TYPE,Follow._TYPE_in_funcdeclaration798); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			TYPE96_tree = (object)adaptor.Create(TYPE96);
			adaptor.AddChild(root_0, TYPE96_tree);
			}
			DebugLocation(93, 25);
			ID97=(IToken)Match(input,ID,Follow._ID_in_funcdeclaration800); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			ID97_tree = (object)adaptor.Create(ID97);
			root_0 = (object)adaptor.BecomeRoot(ID97_tree, root_0);
			}
			DebugLocation(93, 30);
			char_literal98=(IToken)Match(input,42,Follow._42_in_funcdeclaration803); if (state.failed) return retval;
			DebugLocation(93, 32);
			// MathLang.g:93:32: ( paramsdeclaration )?
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
				DebugLocation(93, 32);
				PushFollow(Follow._paramsdeclaration_in_funcdeclaration806);
				paramsdeclaration99=paramsdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, paramsdeclaration99.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(18); }

			DebugLocation(93, 54);
			char_literal100=(IToken)Match(input,43,Follow._43_in_funcdeclaration809); if (state.failed) return retval;
			DebugLocation(93, 56);
			PushFollow(Follow._block_in_funcdeclaration812);
			block101=block();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block101.Tree);

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
		DebugLocation(93, 60);
		} finally { DebugExitRule(GrammarFileName, "funcdeclaration"); }
		return retval;

	}
	// $ANTLR end "funcdeclaration"

	public class funccallbody_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_funccallbody();
	partial void Leave_funccallbody();

	// $ANTLR start "funccallbody"
	// MathLang.g:95:1: funccallbody : ID '(' ( expressioncommalist )? ')' ;
	[GrammarRule("funccallbody")]
	private MathLangParser.funccallbody_return funccallbody()
	{
		Enter_funccallbody();
		EnterRule("funccallbody", 28);
		TraceIn("funccallbody", 28);
		MathLangParser.funccallbody_return retval = new MathLangParser.funccallbody_return();
		retval.Start = (IToken)input.LT(1);
		int funccallbody_StartIndex = input.Index;
		object root_0 = null;

		IToken ID102=null;
		IToken char_literal103=null;
		IToken char_literal105=null;
		MathLangParser.expressioncommalist_return expressioncommalist104 = default(MathLangParser.expressioncommalist_return);

		object ID102_tree=null;
		object char_literal103_tree=null;
		object char_literal105_tree=null;

		try { DebugEnterRule(GrammarFileName, "funccallbody");
		DebugLocation(95, 46);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 28)) { return retval; }
			// MathLang.g:95:13: ( ID '(' ( expressioncommalist )? ')' )
			DebugEnterAlt(1);
			// MathLang.g:95:15: ID '(' ( expressioncommalist )? ')'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(95, 17);
			ID102=(IToken)Match(input,ID,Follow._ID_in_funccallbody819); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			ID102_tree = (object)adaptor.Create(ID102);
			root_0 = (object)adaptor.BecomeRoot(ID102_tree, root_0);
			}
			DebugLocation(95, 19);
			char_literal103=(IToken)Match(input,42,Follow._42_in_funccallbody822); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal103_tree = (object)adaptor.Create(char_literal103);
			adaptor.AddChild(root_0, char_literal103_tree);
			}
			DebugLocation(95, 23);
			// MathLang.g:95:23: ( expressioncommalist )?
			int alt19=2;
			try { DebugEnterSubRule(19);
			try { DebugEnterDecision(19, decisionCanBacktrack[19]);
			int LA19_0 = input.LA(1);

			if (((LA19_0>=NUMBER && LA19_0<=CHAR)||(LA19_0>=TRUE && LA19_0<=FALSE)||LA19_0==42))
			{
				alt19=1;
			}
			} finally { DebugExitDecision(19); }
			switch (alt19)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: expressioncommalist
				{
				DebugLocation(95, 23);
				PushFollow(Follow._expressioncommalist_in_funccallbody824);
				expressioncommalist104=expressioncommalist();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expressioncommalist104.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(19); }

			DebugLocation(95, 44);
			char_literal105=(IToken)Match(input,43,Follow._43_in_funccallbody827); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal105_tree = (object)adaptor.Create(char_literal105);
			adaptor.AddChild(root_0, char_literal105_tree);
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
			TraceOut("funccallbody", 28);
			LeaveRule("funccallbody", 28);
			Leave_funccallbody();
			if (state.backtracking > 0) { Memoize(input, 28, funccallbody_StartIndex); }
		}
		DebugLocation(95, 46);
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
	// MathLang.g:97:1: funccall : funccallbody ';' ;
	[GrammarRule("funccall")]
	private MathLangParser.funccall_return funccall()
	{
		Enter_funccall();
		EnterRule("funccall", 29);
		TraceIn("funccall", 29);
		MathLangParser.funccall_return retval = new MathLangParser.funccall_return();
		retval.Start = (IToken)input.LT(1);
		int funccall_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal107=null;
		MathLangParser.funccallbody_return funccallbody106 = default(MathLangParser.funccallbody_return);

		object char_literal107_tree=null;

		try { DebugEnterRule(GrammarFileName, "funccall");
		DebugLocation(97, 27);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 29)) { return retval; }
			// MathLang.g:97:9: ( funccallbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:97:11: funccallbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(97, 11);
			PushFollow(Follow._funccallbody_in_funccall834);
			funccallbody106=funccallbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody106.Tree);
			DebugLocation(97, 27);
			char_literal107=(IToken)Match(input,41,Follow._41_in_funccall836); if (state.failed) return retval;

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
			TraceOut("funccall", 29);
			LeaveRule("funccall", 29);
			Leave_funccall();
			if (state.backtracking > 0) { Memoize(input, 29, funccall_StartIndex); }
		}
		DebugLocation(97, 27);
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
	// MathLang.g:99:1: expressioncommalist : expression ( ',' expression )* -> ^( PARAMETERS ( expression )* ) ;
	[GrammarRule("expressioncommalist")]
	private MathLangParser.expressioncommalist_return expressioncommalist()
	{
		Enter_expressioncommalist();
		EnterRule("expressioncommalist", 30);
		TraceIn("expressioncommalist", 30);
		MathLangParser.expressioncommalist_return retval = new MathLangParser.expressioncommalist_return();
		retval.Start = (IToken)input.LT(1);
		int expressioncommalist_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal109=null;
		MathLangParser.expression_return expression108 = default(MathLangParser.expression_return);
		MathLangParser.expression_return expression110 = default(MathLangParser.expression_return);

		object char_literal109_tree=null;
		RewriteRuleITokenStream stream_44=new RewriteRuleITokenStream(adaptor,"token 44");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "expressioncommalist");
		DebugLocation(99, 83);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 30)) { return retval; }
			// MathLang.g:99:20: ( expression ( ',' expression )* -> ^( PARAMETERS ( expression )* ) )
			DebugEnterAlt(1);
			// MathLang.g:99:22: expression ( ',' expression )*
			{
			DebugLocation(99, 22);
			PushFollow(Follow._expression_in_expressioncommalist844);
			expression108=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression108.Tree);
			DebugLocation(99, 33);
			// MathLang.g:99:33: ( ',' expression )*
			try { DebugEnterSubRule(20);
			while (true)
			{
				int alt20=2;
				try { DebugEnterDecision(20, decisionCanBacktrack[20]);
				int LA20_0 = input.LA(1);

				if ((LA20_0==44))
				{
					alt20=1;
				}


				} finally { DebugExitDecision(20); }
				switch ( alt20 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:99:35: ',' expression
					{
					DebugLocation(99, 38);
					char_literal109=(IToken)Match(input,44,Follow._44_in_expressioncommalist848); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_44.Add(char_literal109);

					DebugLocation(99, 40);
					PushFollow(Follow._expression_in_expressioncommalist851);
					expression110=expression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_expression.Add(expression110.Tree);

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
			// 99:53: -> ^( PARAMETERS ( expression )* )
			{
				DebugLocation(99, 56);
				// MathLang.g:99:56: ^( PARAMETERS ( expression )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(99, 58);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_1);

				DebugLocation(99, 69);
				// MathLang.g:99:69: ( expression )*
				while ( stream_expression.HasNext )
				{
					DebugLocation(99, 70);
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
			TraceOut("expressioncommalist", 30);
			LeaveRule("expressioncommalist", 30);
			Leave_expressioncommalist();
			if (state.backtracking > 0) { Memoize(input, 30, expressioncommalist_StartIndex); }
		}
		DebugLocation(99, 83);
		} finally { DebugExitRule(GrammarFileName, "expressioncommalist"); }
		return retval;

	}
	// $ANTLR end "expressioncommalist"

	public class paramsdeclaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_paramsdeclaration();
	partial void Leave_paramsdeclaration();

	// $ANTLR start "paramsdeclaration"
	// MathLang.g:101:1: paramsdeclaration : ( declarationbody ( ',' declarationbody )* ) -> ^( PARAMETERS ( declarationbody )* ) ;
	[GrammarRule("paramsdeclaration")]
	private MathLangParser.paramsdeclaration_return paramsdeclaration()
	{
		Enter_paramsdeclaration();
		EnterRule("paramsdeclaration", 31);
		TraceIn("paramsdeclaration", 31);
		MathLangParser.paramsdeclaration_return retval = new MathLangParser.paramsdeclaration_return();
		retval.Start = (IToken)input.LT(1);
		int paramsdeclaration_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal112=null;
		MathLangParser.declarationbody_return declarationbody111 = default(MathLangParser.declarationbody_return);
		MathLangParser.declarationbody_return declarationbody113 = default(MathLangParser.declarationbody_return);

		object char_literal112_tree=null;
		RewriteRuleITokenStream stream_44=new RewriteRuleITokenStream(adaptor,"token 44");
		RewriteRuleSubtreeStream stream_declarationbody=new RewriteRuleSubtreeStream(adaptor,"rule declarationbody");
		try { DebugEnterRule(GrammarFileName, "paramsdeclaration");
		DebugLocation(101, 102);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 31)) { return retval; }
			// MathLang.g:101:18: ( ( declarationbody ( ',' declarationbody )* ) -> ^( PARAMETERS ( declarationbody )* ) )
			DebugEnterAlt(1);
			// MathLang.g:101:20: ( declarationbody ( ',' declarationbody )* )
			{
			DebugLocation(101, 20);
			// MathLang.g:101:20: ( declarationbody ( ',' declarationbody )* )
			DebugEnterAlt(1);
			// MathLang.g:101:22: declarationbody ( ',' declarationbody )*
			{
			DebugLocation(101, 22);
			PushFollow(Follow._declarationbody_in_paramsdeclaration874);
			declarationbody111=declarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declarationbody.Add(declarationbody111.Tree);
			DebugLocation(101, 38);
			// MathLang.g:101:38: ( ',' declarationbody )*
			try { DebugEnterSubRule(21);
			while (true)
			{
				int alt21=2;
				try { DebugEnterDecision(21, decisionCanBacktrack[21]);
				int LA21_0 = input.LA(1);

				if ((LA21_0==44))
				{
					alt21=1;
				}


				} finally { DebugExitDecision(21); }
				switch ( alt21 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:101:40: ',' declarationbody
					{
					DebugLocation(101, 43);
					char_literal112=(IToken)Match(input,44,Follow._44_in_paramsdeclaration878); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_44.Add(char_literal112);

					DebugLocation(101, 45);
					PushFollow(Follow._declarationbody_in_paramsdeclaration881);
					declarationbody113=declarationbody();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_declarationbody.Add(declarationbody113.Tree);

					}
					break;

				default:
					goto loop21;
				}
			}

			loop21:
				;

			} finally { DebugExitSubRule(21); }


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
			// 101:66: -> ^( PARAMETERS ( declarationbody )* )
			{
				DebugLocation(101, 69);
				// MathLang.g:101:69: ^( PARAMETERS ( declarationbody )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(101, 71);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_1);

				DebugLocation(101, 82);
				// MathLang.g:101:82: ( declarationbody )*
				while ( stream_declarationbody.HasNext )
				{
					DebugLocation(101, 84);
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
			TraceOut("paramsdeclaration", 31);
			LeaveRule("paramsdeclaration", 31);
			Leave_paramsdeclaration();
			if (state.backtracking > 0) { Memoize(input, 31, paramsdeclaration_StartIndex); }
		}
		DebugLocation(101, 102);
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
	// MathLang.g:103:1: block : '{' statementlist '}' ;
	[GrammarRule("block")]
	private MathLangParser.block_return block()
	{
		Enter_block();
		EnterRule("block", 32);
		TraceIn("block", 32);
		MathLangParser.block_return retval = new MathLangParser.block_return();
		retval.Start = (IToken)input.LT(1);
		int block_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal114=null;
		IToken char_literal116=null;
		MathLangParser.statementlist_return statementlist115 = default(MathLangParser.statementlist_return);

		object char_literal114_tree=null;
		object char_literal116_tree=null;

		try { DebugEnterRule(GrammarFileName, "block");
		DebugLocation(103, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 32)) { return retval; }
			// MathLang.g:103:6: ( '{' statementlist '}' )
			DebugEnterAlt(1);
			// MathLang.g:103:8: '{' statementlist '}'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(103, 11);
			char_literal114=(IToken)Match(input,45,Follow._45_in_block906); if (state.failed) return retval;
			DebugLocation(103, 13);
			PushFollow(Follow._statementlist_in_block909);
			statementlist115=statementlist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementlist115.Tree);
			DebugLocation(103, 30);
			char_literal116=(IToken)Match(input,46,Follow._46_in_block911); if (state.failed) return retval;

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
			TraceOut("block", 32);
			LeaveRule("block", 32);
			Leave_block();
			if (state.backtracking > 0) { Memoize(input, 32, block_StartIndex); }
		}
		DebugLocation(103, 30);
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
	// MathLang.g:105:1: statementlist : ( statement )* -> ^( BLOCK ( statement )* ) ;
	[GrammarRule("statementlist")]
	private MathLangParser.statementlist_return statementlist()
	{
		Enter_statementlist();
		EnterRule("statementlist", 33);
		TraceIn("statementlist", 33);
		MathLangParser.statementlist_return retval = new MathLangParser.statementlist_return();
		retval.Start = (IToken)input.LT(1);
		int statementlist_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.statement_return statement117 = default(MathLangParser.statement_return);

		RewriteRuleSubtreeStream stream_statement=new RewriteRuleSubtreeStream(adaptor,"rule statement");
		try { DebugEnterRule(GrammarFileName, "statementlist");
		DebugLocation(105, 49);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 33)) { return retval; }
			// MathLang.g:105:14: ( ( statement )* -> ^( BLOCK ( statement )* ) )
			DebugEnterAlt(1);
			// MathLang.g:105:16: ( statement )*
			{
			DebugLocation(105, 16);
			// MathLang.g:105:16: ( statement )*
			try { DebugEnterSubRule(22);
			while (true)
			{
				int alt22=2;
				try { DebugEnterDecision(22, decisionCanBacktrack[22]);
				int LA22_0 = input.LA(1);

				if ((LA22_0==IF||LA22_0==FOR||(LA22_0>=RETURN && LA22_0<=WHILE)||LA22_0==ID||LA22_0==TYPE))
				{
					alt22=1;
				}


				} finally { DebugExitDecision(22); }
				switch ( alt22 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: statement
					{
					DebugLocation(105, 16);
					PushFollow(Follow._statement_in_statementlist919);
					statement117=statement();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_statement.Add(statement117.Tree);

					}
					break;

				default:
					goto loop22;
				}
			}

			loop22:
				;

			} finally { DebugExitSubRule(22); }



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
			// 105:27: -> ^( BLOCK ( statement )* )
			{
				DebugLocation(105, 30);
				// MathLang.g:105:30: ^( BLOCK ( statement )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(105, 32);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

				DebugLocation(105, 38);
				// MathLang.g:105:38: ( statement )*
				while ( stream_statement.HasNext )
				{
					DebugLocation(105, 38);
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
			TraceOut("statementlist", 33);
			LeaveRule("statementlist", 33);
			Leave_statementlist();
			if (state.backtracking > 0) { Memoize(input, 33, statementlist_StartIndex); }
		}
		DebugLocation(105, 49);
		} finally { DebugExitRule(GrammarFileName, "statementlist"); }
		return retval;

	}
	// $ANTLR end "statementlist"

	public class returnstatement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_returnstatement();
	partial void Leave_returnstatement();

	// $ANTLR start "returnstatement"
	// MathLang.g:107:1: returnstatement : RETURN expression ';' ;
	[GrammarRule("returnstatement")]
	private MathLangParser.returnstatement_return returnstatement()
	{
		Enter_returnstatement();
		EnterRule("returnstatement", 34);
		TraceIn("returnstatement", 34);
		MathLangParser.returnstatement_return retval = new MathLangParser.returnstatement_return();
		retval.Start = (IToken)input.LT(1);
		int returnstatement_StartIndex = input.Index;
		object root_0 = null;

		IToken RETURN118=null;
		IToken char_literal120=null;
		MathLangParser.expression_return expression119 = default(MathLangParser.expression_return);

		object RETURN118_tree=null;
		object char_literal120_tree=null;

		try { DebugEnterRule(GrammarFileName, "returnstatement");
		DebugLocation(107, 41);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 34)) { return retval; }
			// MathLang.g:107:16: ( RETURN expression ';' )
			DebugEnterAlt(1);
			// MathLang.g:107:18: RETURN expression ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(107, 24);
			RETURN118=(IToken)Match(input,RETURN,Follow._RETURN_in_returnstatement937); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			RETURN118_tree = (object)adaptor.Create(RETURN118);
			root_0 = (object)adaptor.BecomeRoot(RETURN118_tree, root_0);
			}
			DebugLocation(107, 26);
			PushFollow(Follow._expression_in_returnstatement940);
			expression119=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression119.Tree);
			DebugLocation(107, 40);
			char_literal120=(IToken)Match(input,41,Follow._41_in_returnstatement942); if (state.failed) return retval;

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
			TraceOut("returnstatement", 34);
			LeaveRule("returnstatement", 34);
			Leave_returnstatement();
			if (state.backtracking > 0) { Memoize(input, 34, returnstatement_StartIndex); }
		}
		DebugLocation(107, 41);
		} finally { DebugExitRule(GrammarFileName, "returnstatement"); }
		return retval;

	}
	// $ANTLR end "returnstatement"

	partial void Enter_synpred10_MathLang_fragment();
	partial void Leave_synpred10_MathLang_fragment();

	// $ANTLR start synpred10_MathLang
	public void synpred10_MathLang_fragment()
	{
		Enter_synpred10_MathLang_fragment();
		EnterRule("synpred10_MathLang_fragment", 44);
		TraceIn("synpred10_MathLang_fragment", 44);
		try
		{
			// MathLang.g:53:14: ( funccallbody )
			DebugEnterAlt(1);
			// MathLang.g:53:14: funccallbody
			{
			DebugLocation(53, 14);
			PushFollow(Follow._funccallbody_in_synpred10_MathLang349);
			funccallbody();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred10_MathLang_fragment", 44);
			LeaveRule("synpred10_MathLang_fragment", 44);
			Leave_synpred10_MathLang_fragment();
		}
	}
	// $ANTLR end synpred10_MathLang

	partial void Enter_synpred11_MathLang_fragment();
	partial void Leave_synpred11_MathLang_fragment();

	// $ANTLR start synpred11_MathLang
	public void synpred11_MathLang_fragment()
	{
		Enter_synpred11_MathLang_fragment();
		EnterRule("synpred11_MathLang_fragment", 45);
		TraceIn("synpred11_MathLang_fragment", 45);
		try
		{
			// MathLang.g:54:6: ( boolexpression )
			DebugEnterAlt(1);
			// MathLang.g:54:6: boolexpression
			{
			DebugLocation(54, 6);
			PushFollow(Follow._boolexpression_in_synpred11_MathLang356);
			boolexpression();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred11_MathLang_fragment", 45);
			LeaveRule("synpred11_MathLang_fragment", 45);
			Leave_synpred11_MathLang_fragment();
		}
	}
	// $ANTLR end synpred11_MathLang

	partial void Enter_synpred23_MathLang_fragment();
	partial void Leave_synpred23_MathLang_fragment();

	// $ANTLR start synpred23_MathLang
	public void synpred23_MathLang_fragment()
	{
		Enter_synpred23_MathLang_fragment();
		EnterRule("synpred23_MathLang_fragment", 57);
		TraceIn("synpred23_MathLang_fragment", 57);
		try
		{
			// MathLang.g:69:16: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )
			DebugEnterAlt(1);
			// MathLang.g:69:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
			{
			DebugLocation(69, 16);
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

			DebugLocation(69, 53);
			PushFollow(Follow._add_in_synpred23_MathLang547);
			add();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred23_MathLang_fragment", 57);
			LeaveRule("synpred23_MathLang_fragment", 57);
			Leave_synpred23_MathLang_fragment();
		}
	}
	// $ANTLR end synpred23_MathLang

	partial void Enter_synpred29_MathLang_fragment();
	partial void Leave_synpred29_MathLang_fragment();

	// $ANTLR start synpred29_MathLang
	public void synpred29_MathLang_fragment()
	{
		Enter_synpred29_MathLang_fragment();
		EnterRule("synpred29_MathLang_fragment", 63);
		TraceIn("synpred29_MathLang_fragment", 63);
		try
		{
			// MathLang.g:82:12: ( '(' boolterm ')' )
			DebugEnterAlt(1);
			// MathLang.g:82:12: '(' boolterm ')'
			{
			DebugLocation(82, 12);
			Match(input,42,Follow._42_in_synpred29_MathLang666); if (state.failed) return;
			DebugLocation(82, 17);
			PushFollow(Follow._boolterm_in_synpred29_MathLang669);
			boolterm();
			PopFollow();
			if (state.failed) return;
			DebugLocation(82, 26);
			Match(input,43,Follow._43_in_synpred29_MathLang671); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred29_MathLang_fragment", 63);
			LeaveRule("synpred29_MathLang_fragment", 63);
			Leave_synpred29_MathLang_fragment();
		}
	}
	// $ANTLR end synpred29_MathLang

	partial void Enter_synpred34_MathLang_fragment();
	partial void Leave_synpred34_MathLang_fragment();

	// $ANTLR start synpred34_MathLang
	public void synpred34_MathLang_fragment()
	{
		Enter_synpred34_MathLang_fragment();
		EnterRule("synpred34_MathLang_fragment", 68);
		TraceIn("synpred34_MathLang_fragment", 68);
		try
		{
			// MathLang.g:87:64: ( ELSE ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:87:64: ELSE ( block | statement )
			{
			DebugLocation(87, 64);
			Match(input,ELSE,Follow._ELSE_in_synpred34_MathLang721); if (state.failed) return;
			DebugLocation(87, 70);
			// MathLang.g:87:70: ( block | statement )
			int alt23=2;
			try { DebugEnterSubRule(23);
			try { DebugEnterDecision(23, decisionCanBacktrack[23]);
			int LA23_0 = input.LA(1);

			if ((LA23_0==45))
			{
				alt23=1;
			}
			else if ((LA23_0==IF||LA23_0==FOR||(LA23_0>=RETURN && LA23_0<=WHILE)||LA23_0==ID||LA23_0==TYPE))
			{
				alt23=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				NoViableAltException nvae = new NoViableAltException("", 23, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(23); }
			switch (alt23)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:87:71: block
				{
				DebugLocation(87, 71);
				PushFollow(Follow._block_in_synpred34_MathLang725);
				block();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:87:79: statement
				{
				DebugLocation(87, 79);
				PushFollow(Follow._statement_in_synpred34_MathLang729);
				statement();
				PopFollow();
				if (state.failed) return;

				}
				break;

			}
			} finally { DebugExitSubRule(23); }


			}

		}
		finally
		{
			TraceOut("synpred34_MathLang_fragment", 68);
			LeaveRule("synpred34_MathLang_fragment", 68);
			Leave_synpred34_MathLang_fragment();
		}
	}
	// $ANTLR end synpred34_MathLang
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

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa1 = new DFA1( this );
	}

	private class DFA1 : DFA
	{
		private const string DFA1_eotS =
			"\xC\xFFFF";
		private const string DFA1_eofS =
			"\xC\xFFFF";
		private const string DFA1_minS =
			"\x1\x7\x1\x11\x1\x14\x4\xFFFF\x1\x14\x4\xFFFF";
		private const string DFA1_maxS =
			"\x1\x13\x1\x11\x1\x2A\x4\xFFFF\x1\x2A\x4\xFFFF";
		private const string DFA1_acceptS =
			"\x3\xFFFF\x1\x3\x1\x4\x1\x5\x1\x7\x1\xFFFF\x1\x2\x1\x8\x1\x1\x1\x6";
		private const string DFA1_specialS =
			"\xC\xFFFF}>";
		private static readonly string[] DFA1_transitionS =
			{
				"\x1\x3\x1\xFFFF\x1\x5\x1\xFFFF\x1\x6\x1\x4\x4\xFFFF\x1\x2\x1\xFFFF"+
				"\x1\x1",
				"\x1\x7",
				"\x1\x8\x15\xFFFF\x1\x9",
				"",
				"",
				"",
				"",
				"\x1\xA\x14\xFFFF\x1\xA\x1\xB",
				"",
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

		public override string Description { get { return "39:12: ( declaration | assignment | ifstatement | whilestatement | forstatement | funcdeclaration | returnstatement | funccall )"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}


	#endregion DFA

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
		public static readonly BitSet _returnstatement_in_statement307 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccall_in_statement312 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_number0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _term_in_mathexpression340 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_expression349 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolexpression_in_expression356 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathexpression_in_expression363 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_declaration370 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _ID_in_declaration373 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _41_in_declaration375 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _longdeclaration_in_declaration383 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_declarationbody390 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _ID_in_declarationbody393 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_longdeclaration400 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _ID_in_longdeclaration402 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _ASSIGN_in_longdeclaration404 = new BitSet(new ulong[]{0x40C00070000UL});
		public static readonly BitSet _expression_in_longdeclaration406 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _41_in_longdeclaration408 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_longdeclarationbody431 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _ID_in_longdeclarationbody433 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _ASSIGN_in_longdeclarationbody435 = new BitSet(new ulong[]{0x40C00070000UL});
		public static readonly BitSet _expression_in_longdeclarationbody437 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_variable459 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _ID_in_variable468 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mul_in_add474 = new BitSet(new ulong[]{0xC00002UL});
		public static readonly BitSet _set_in_add478 = new BitSet(new ulong[]{0x40C00070000UL});
		public static readonly BitSet _mul_in_add487 = new BitSet(new ulong[]{0xC00002UL});
		public static readonly BitSet _group_in_mul496 = new BitSet(new ulong[]{0x3000002UL});
		public static readonly BitSet _set_in_mul500 = new BitSet(new ulong[]{0x40C00070000UL});
		public static readonly BitSet _group_in_mul509 = new BitSet(new ulong[]{0x3000002UL});
		public static readonly BitSet _add_in_compare517 = new BitSet(new ulong[]{0xFC000002UL});
		public static readonly BitSet _set_in_compare521 = new BitSet(new ulong[]{0x40C00070000UL});
		public static readonly BitSet _add_in_compare547 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _add_in_term559 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _42_in_group566 = new BitSet(new ulong[]{0x40C00070000UL});
		public static readonly BitSet _term_in_group569 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _43_in_group571 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _number_in_group576 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_assignment583 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _ASSIGN_in_assignment585 = new BitSet(new ulong[]{0x40C00070000UL});
		public static readonly BitSet _expression_in_assignment588 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _41_in_assignment590 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_assignmentbody597 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _ASSIGN_in_assignmentbody599 = new BitSet(new ulong[]{0x40C00070000UL});
		public static readonly BitSet _expression_in_assignmentbody602 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolterm_in_boolexpression610 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _or_in_boolterm616 = new BitSet(new ulong[]{0x30000002UL});
		public static readonly BitSet _set_in_boolterm620 = new BitSet(new ulong[]{0x40C00070000UL});
		public static readonly BitSet _or_in_boolterm629 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _and_in_or638 = new BitSet(new ulong[]{0x100000002UL});
		public static readonly BitSet _OR_in_or641 = new BitSet(new ulong[]{0x40C00070000UL});
		public static readonly BitSet _and_in_or644 = new BitSet(new ulong[]{0x100000002UL});
		public static readonly BitSet _boolgroup_in_and652 = new BitSet(new ulong[]{0x200000002UL});
		public static readonly BitSet _AND_in_and655 = new BitSet(new ulong[]{0x40C00070000UL});
		public static readonly BitSet _boolgroup_in_and658 = new BitSet(new ulong[]{0x200000002UL});
		public static readonly BitSet _42_in_boolgroup666 = new BitSet(new ulong[]{0x40C00070000UL});
		public static readonly BitSet _boolterm_in_boolgroup669 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _43_in_boolgroup671 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolvar_in_boolgroup676 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TRUE_in_boolvar682 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FALSE_in_boolvar688 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _compare_in_boolvar694 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_ifstatement701 = new BitSet(new ulong[]{0x40000000000UL});
		public static readonly BitSet _42_in_ifstatement704 = new BitSet(new ulong[]{0x40C00070000UL});
		public static readonly BitSet _boolexpression_in_ifstatement707 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _43_in_ifstatement709 = new BitSet(new ulong[]{0x2000000A1A80UL});
		public static readonly BitSet _block_in_ifstatement713 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement717 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _ELSE_in_ifstatement721 = new BitSet(new ulong[]{0x2000000A1A80UL});
		public static readonly BitSet _block_in_ifstatement725 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement729 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _WHILE_in_whilestatement740 = new BitSet(new ulong[]{0x40000000000UL});
		public static readonly BitSet _42_in_whilestatement743 = new BitSet(new ulong[]{0x40C00070000UL});
		public static readonly BitSet _boolexpression_in_whilestatement746 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _43_in_whilestatement748 = new BitSet(new ulong[]{0x2000000A1A80UL});
		public static readonly BitSet _block_in_whilestatement752 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_whilestatement756 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_forstatement764 = new BitSet(new ulong[]{0x40000000000UL});
		public static readonly BitSet _42_in_forstatement767 = new BitSet(new ulong[]{0x80000UL});
		public static readonly BitSet _longdeclarationbody_in_forstatement770 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _41_in_forstatement772 = new BitSet(new ulong[]{0x40C00070000UL});
		public static readonly BitSet _boolexpression_in_forstatement775 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _41_in_forstatement777 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _assignmentbody_in_forstatement780 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _43_in_forstatement782 = new BitSet(new ulong[]{0x2000000A1A80UL});
		public static readonly BitSet _block_in_forstatement786 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_forstatement790 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_funcdeclaration798 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _ID_in_funcdeclaration800 = new BitSet(new ulong[]{0x40000000000UL});
		public static readonly BitSet _42_in_funcdeclaration803 = new BitSet(new ulong[]{0x80000080000UL});
		public static readonly BitSet _paramsdeclaration_in_funcdeclaration806 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _43_in_funcdeclaration809 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _block_in_funcdeclaration812 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_funccallbody819 = new BitSet(new ulong[]{0x40000000000UL});
		public static readonly BitSet _42_in_funccallbody822 = new BitSet(new ulong[]{0xC0C00070000UL});
		public static readonly BitSet _expressioncommalist_in_funccallbody824 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _43_in_funccallbody827 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_funccall834 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _41_in_funccall836 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_expressioncommalist844 = new BitSet(new ulong[]{0x100000000002UL});
		public static readonly BitSet _44_in_expressioncommalist848 = new BitSet(new ulong[]{0x40C00070000UL});
		public static readonly BitSet _expression_in_expressioncommalist851 = new BitSet(new ulong[]{0x100000000002UL});
		public static readonly BitSet _declarationbody_in_paramsdeclaration874 = new BitSet(new ulong[]{0x100000000002UL});
		public static readonly BitSet _44_in_paramsdeclaration878 = new BitSet(new ulong[]{0x80000UL});
		public static readonly BitSet _declarationbody_in_paramsdeclaration881 = new BitSet(new ulong[]{0x100000000002UL});
		public static readonly BitSet _45_in_block906 = new BitSet(new ulong[]{0x6000000A1A80UL});
		public static readonly BitSet _statementlist_in_block909 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _46_in_block911 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_statementlist919 = new BitSet(new ulong[]{0x2000000A1A82UL});
		public static readonly BitSet _RETURN_in_returnstatement937 = new BitSet(new ulong[]{0x40C00070000UL});
		public static readonly BitSet _expression_in_returnstatement940 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _41_in_returnstatement942 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_synpred10_MathLang349 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolexpression_in_synpred11_MathLang356 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_synpred23_MathLang521 = new BitSet(new ulong[]{0x40C00070000UL});
		public static readonly BitSet _add_in_synpred23_MathLang547 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _42_in_synpred29_MathLang666 = new BitSet(new ulong[]{0x40C00070000UL});
		public static readonly BitSet _boolterm_in_synpred29_MathLang669 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _43_in_synpred29_MathLang671 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ELSE_in_synpred34_MathLang721 = new BitSet(new ulong[]{0x2000000A1A80UL});
		public static readonly BitSet _block_in_synpred34_MathLang725 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_synpred34_MathLang729 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  MathLang 

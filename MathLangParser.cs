// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-10-02 11:37:20

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "UNKNOWN", "PRINT", "INPUT", "IF", "ELSE", "FOR", "FUNCTION", "RETURN", "WHILE", "BLOCK", "PROGRAM", "PARAMS", "NUMBER", "ID", "CHAR", "TYPE", "ASSIGN", "ARRAY", "ADD", "SUB", "MUL", "DIV", "GREQ", "LSEQ", "NEQ", "EQ", "GR", "LS", "OR", "AND", "NOT", "TRUE", "FALSE", "ACCESS_MODIFIER", "RETURNS", "PARAMETERS", "WS", "SL_COMMENT", "ML_COMMENT", "';'", "'('", "')'", "','", "'{'", "'}'"
	};
	public const int EOF=-1;
	public const int T__43=43;
	public const int T__44=44;
	public const int T__45=45;
	public const int T__46=46;
	public const int T__47=47;
	public const int T__48=48;
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
	public const int ACCESS_MODIFIER=37;
	public const int RETURNS=38;
	public const int PARAMETERS=39;
	public const int WS=40;
	public const int SL_COMMENT=41;
	public const int ML_COMMENT=42;

	// delegates
	// delegators

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, true, false, false, false, false, false, 
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
		this.state.ruleMemo = new System.Collections.Generic.Dictionary<int, int>[74+1];

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
			PushFollow(Follow._term_in_mathexpression341);
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
	// MathLang.g:53:1: expression : mathexpression ;
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

		MathLangParser.mathexpression_return mathexpression13 = default(MathLangParser.mathexpression_return);


		try { DebugEnterRule(GrammarFileName, "expression");
		DebugLocation(53, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 5)) { return retval; }
			// MathLang.g:53:11: ( mathexpression )
			DebugEnterAlt(1);
			// MathLang.g:53:15: mathexpression
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(53, 15);
			PushFollow(Follow._mathexpression_in_expression351);
			mathexpression13=mathexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mathexpression13.Tree);

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
		DebugLocation(54, 0);
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
	// MathLang.g:55:1: declaration : ( declarationbody ';' | longdeclaration );
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

		IToken char_literal15=null;
		MathLangParser.declarationbody_return declarationbody14 = default(MathLangParser.declarationbody_return);
		MathLangParser.longdeclaration_return longdeclaration16 = default(MathLangParser.longdeclaration_return);

		object char_literal15_tree=null;

		try { DebugEnterRule(GrammarFileName, "declaration");
		DebugLocation(55, 20);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 6)) { return retval; }
			// MathLang.g:55:12: ( declarationbody ';' | longdeclaration )
			int alt2=2;
			try { DebugEnterDecision(2, decisionCanBacktrack[2]);
			int LA2_0 = input.LA(1);

			if ((LA2_0==TYPE))
			{
				int LA2_1 = input.LA(2);

				if ((LA2_1==ID))
				{
					int LA2_2 = input.LA(3);

					if ((LA2_2==ASSIGN))
					{
						alt2=2;
					}
					else if ((LA2_2==43))
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
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 2, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 2, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(2); }
			switch (alt2)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:55:14: declarationbody ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(55, 14);
				PushFollow(Follow._declarationbody_in_declaration358);
				declarationbody14=declarationbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, declarationbody14.Tree);
				DebugLocation(55, 33);
				char_literal15=(IToken)Match(input,43,Follow._43_in_declaration360); if (state.failed) return retval;

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
			TraceOut("declaration", 6);
			LeaveRule("declaration", 6);
			Leave_declaration();
			if (state.backtracking > 0) { Memoize(input, 6, declaration_StartIndex); }
		}
		DebugLocation(56, 20);
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
	// MathLang.g:58:1: declarationbody : TYPE ID ;
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
		DebugLocation(58, 26);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 7)) { return retval; }
			// MathLang.g:58:16: ( TYPE ID )
			DebugEnterAlt(1);
			// MathLang.g:58:18: TYPE ID
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(58, 22);
			TYPE17=(IToken)Match(input,TYPE,Follow._TYPE_in_declarationbody375); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			TYPE17_tree = (object)adaptor.Create(TYPE17);
			root_0 = (object)adaptor.BecomeRoot(TYPE17_tree, root_0);
			}
			DebugLocation(58, 24);
			ID18=(IToken)Match(input,ID,Follow._ID_in_declarationbody378); if (state.failed) return retval;
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
		DebugLocation(58, 26);
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
	// MathLang.g:59:1: longdeclaration : longdeclarationbody ';' ;
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

		IToken char_literal20=null;
		MathLangParser.longdeclarationbody_return longdeclarationbody19 = default(MathLangParser.longdeclarationbody_return);

		object char_literal20_tree=null;

		try { DebugEnterRule(GrammarFileName, "longdeclaration");
		DebugLocation(59, 42);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 8)) { return retval; }
			// MathLang.g:59:16: ( longdeclarationbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:59:18: longdeclarationbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(59, 18);
			PushFollow(Follow._longdeclarationbody_in_longdeclaration385);
			longdeclarationbody19=longdeclarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclarationbody19.Tree);
			DebugLocation(59, 41);
			char_literal20=(IToken)Match(input,43,Follow._43_in_longdeclaration387); if (state.failed) return retval;

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
		DebugLocation(59, 42);
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
	// MathLang.g:60:1: longdeclarationbody : TYPE ID ASSIGN expression -> ^( ASSIGN ^( TYPE ID ) expression ) ;
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

		IToken TYPE21=null;
		IToken ID22=null;
		IToken ASSIGN23=null;
		MathLangParser.expression_return expression24 = default(MathLangParser.expression_return);

		object TYPE21_tree=null;
		object ID22_tree=null;
		object ASSIGN23_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "longdeclarationbody");
		DebugLocation(60, 82);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 9)) { return retval; }
			// MathLang.g:60:20: ( TYPE ID ASSIGN expression -> ^( ASSIGN ^( TYPE ID ) expression ) )
			DebugEnterAlt(1);
			// MathLang.g:60:22: TYPE ID ASSIGN expression
			{
			DebugLocation(60, 22);
			TYPE21=(IToken)Match(input,TYPE,Follow._TYPE_in_longdeclarationbody395); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE21);

			DebugLocation(60, 27);
			ID22=(IToken)Match(input,ID,Follow._ID_in_longdeclarationbody397); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID22);

			DebugLocation(60, 30);
			ASSIGN23=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclarationbody399); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN23);

			DebugLocation(60, 37);
			PushFollow(Follow._expression_in_longdeclarationbody401);
			expression24=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression24.Tree);


			{
			// AST REWRITE
			// elements: TYPE, ASSIGN, ID, expression
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 60:48: -> ^( ASSIGN ^( TYPE ID ) expression )
			{
				DebugLocation(60, 51);
				// MathLang.g:60:51: ^( ASSIGN ^( TYPE ID ) expression )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(60, 53);
				root_1 = (object)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_1);

				DebugLocation(60, 60);
				// MathLang.g:60:60: ^( TYPE ID )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(60, 62);
				root_2 = (object)adaptor.BecomeRoot(stream_TYPE.NextNode(), root_2);

				DebugLocation(60, 67);
				adaptor.AddChild(root_2, stream_ID.NextNode());

				adaptor.AddChild(root_1, root_2);
				}
				DebugLocation(60, 71);
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
		DebugLocation(60, 82);
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
		EnterRule("variable", 10);
		TraceIn("variable", 10);
		MathLangParser.variable_return retval = new MathLangParser.variable_return();
		retval.Start = (IToken)input.LT(1);
		int variable_StartIndex = input.Index;
		object root_0 = null;

		IToken set25=null;
		IToken ID26=null;

		object set25_tree=null;
		object ID26_tree=null;

		try { DebugEnterRule(GrammarFileName, "variable");
		DebugLocation(62, 28);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 10)) { return retval; }
			// MathLang.g:62:9: ( ( TYPE | ARRAY ) ID )
			DebugEnterAlt(1);
			// MathLang.g:62:11: ( TYPE | ARRAY ) ID
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(62, 11);
			set25=(IToken)input.LT(1);
			set25=(IToken)input.LT(1);
			if (input.LA(1)==TYPE||input.LA(1)==ARRAY)
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

			DebugLocation(62, 27);
			ID26=(IToken)Match(input,ID,Follow._ID_in_variable432); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			ID26_tree = (object)adaptor.Create(ID26);
			adaptor.AddChild(root_0, ID26_tree);
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

		IToken set28=null;
		MathLangParser.mul_return mul27 = default(MathLangParser.mul_return);
		MathLangParser.mul_return mul29 = default(MathLangParser.mul_return);

		object set28_tree=null;

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
			PushFollow(Follow._mul_in_add439);
			mul27=mul();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul27.Tree);
			DebugLocation(64, 10);
			// MathLang.g:64:10: ( ( ADD | SUB ) mul )*
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=2;
				try { DebugEnterDecision(3, decisionCanBacktrack[3]);
				int LA3_0 = input.LA(1);

				if (((LA3_0>=ADD && LA3_0<=SUB)))
				{
					alt3=1;
				}


				} finally { DebugExitDecision(3); }
				switch ( alt3 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:64:12: ( ADD | SUB ) mul
					{
					DebugLocation(64, 12);
					set28=(IToken)input.LT(1);
					set28=(IToken)input.LT(1);
					if ((input.LA(1)>=ADD && input.LA(1)<=SUB))
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

					DebugLocation(64, 25);
					PushFollow(Follow._mul_in_add452);
					mul29=mul();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul29.Tree);

					}
					break;

				default:
					goto loop3;
				}
			}

			loop3:
				;

			} finally { DebugExitSubRule(3); }


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

		IToken set31=null;
		MathLangParser.group_return group30 = default(MathLangParser.group_return);
		MathLangParser.group_return group32 = default(MathLangParser.group_return);

		object set31_tree=null;

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
			PushFollow(Follow._group_in_mul461);
			group30=group();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group30.Tree);
			DebugLocation(65, 12);
			// MathLang.g:65:12: ( ( MUL | DIV ) group )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_0 = input.LA(1);

				if (((LA4_0>=MUL && LA4_0<=DIV)))
				{
					alt4=1;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:65:14: ( MUL | DIV ) group
					{
					DebugLocation(65, 14);
					set31=(IToken)input.LT(1);
					set31=(IToken)input.LT(1);
					if ((input.LA(1)>=MUL && input.LA(1)<=DIV))
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

					DebugLocation(65, 27);
					PushFollow(Follow._group_in_mul474);
					group32=group();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group32.Tree);

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

		IToken set34=null;
		MathLangParser.add_return add33 = default(MathLangParser.add_return);
		MathLangParser.add_return add35 = default(MathLangParser.add_return);

		object set34_tree=null;

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
			PushFollow(Follow._add_in_compare482);
			add33=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add33.Tree);
			DebugLocation(66, 14);
			// MathLang.g:66:14: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
			int alt5=2;
			try { DebugEnterSubRule(5);
			try { DebugEnterDecision(5, decisionCanBacktrack[5]);
			int LA5_0 = input.LA(1);

			if (((LA5_0>=NEQ && LA5_0<=EQ)))
			{
				int LA5_1 = input.LA(2);

				if ((EvaluatePredicate(synpred21_MathLang_fragment)))
				{
					alt5=1;
				}
			}
			else if (((LA5_0>=GREQ && LA5_0<=LSEQ)||(LA5_0>=GR && LA5_0<=LS)))
			{
				alt5=1;
			}
			} finally { DebugExitDecision(5); }
			switch (alt5)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:66:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
				{
				DebugLocation(66, 16);
				set34=(IToken)input.LT(1);
				set34=(IToken)input.LT(1);
				if ((input.LA(1)>=GREQ && input.LA(1)<=LS))
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

				DebugLocation(66, 53);
				PushFollow(Follow._add_in_compare512);
				add35=add();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add35.Tree);

				}
				break;

			}
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
	// MathLang.g:67:1: term : add ;
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

		MathLangParser.add_return add36 = default(MathLangParser.add_return);


		try { DebugEnterRule(GrammarFileName, "term");
		DebugLocation(67, 9);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 14)) { return retval; }
			// MathLang.g:67:5: ( add )
			DebugEnterAlt(1);
			// MathLang.g:67:7: add
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(67, 7);
			PushFollow(Follow._add_in_term523);
			add36=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add36.Tree);

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
	// MathLang.g:68:1: group : ( '(' term ')' | number );
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

		IToken char_literal37=null;
		IToken char_literal39=null;
		MathLangParser.term_return term38 = default(MathLangParser.term_return);
		MathLangParser.number_return number40 = default(MathLangParser.number_return);

		object char_literal37_tree=null;
		object char_literal39_tree=null;

		try { DebugEnterRule(GrammarFileName, "group");
		DebugLocation(68, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 15)) { return retval; }
			// MathLang.g:68:6: ( '(' term ')' | number )
			int alt6=2;
			try { DebugEnterDecision(6, decisionCanBacktrack[6]);
			int LA6_0 = input.LA(1);

			if ((LA6_0==44))
			{
				alt6=1;
			}
			else if (((LA6_0>=NUMBER && LA6_0<=CHAR)))
			{
				alt6=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 6, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(6); }
			switch (alt6)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:68:8: '(' term ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(68, 11);
				char_literal37=(IToken)Match(input,44,Follow._44_in_group529); if (state.failed) return retval;
				DebugLocation(68, 13);
				PushFollow(Follow._term_in_group532);
				term38=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term38.Tree);
				DebugLocation(68, 21);
				char_literal39=(IToken)Match(input,45,Follow._45_in_group534); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:68:25: number
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(68, 25);
				PushFollow(Follow._number_in_group539);
				number40=number();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, number40.Tree);

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
		DebugLocation(68, 30);
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
	// MathLang.g:70:1: assignment : assignmentbody ';' ;
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

		IToken char_literal42=null;
		MathLangParser.assignmentbody_return assignmentbody41 = default(MathLangParser.assignmentbody_return);

		object char_literal42_tree=null;

		try { DebugEnterRule(GrammarFileName, "assignment");
		DebugLocation(70, 31);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 16)) { return retval; }
			// MathLang.g:70:11: ( assignmentbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:70:13: assignmentbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(70, 13);
			PushFollow(Follow._assignmentbody_in_assignment546);
			assignmentbody41=assignmentbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentbody41.Tree);
			DebugLocation(70, 31);
			char_literal42=(IToken)Match(input,43,Follow._43_in_assignment548); if (state.failed) return retval;

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
		DebugLocation(70, 31);
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
	// MathLang.g:71:1: assignmentbody : ID ASSIGN expression ;
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

		IToken ID43=null;
		IToken ASSIGN44=null;
		MathLangParser.expression_return expression45 = default(MathLangParser.expression_return);

		object ID43_tree=null;
		object ASSIGN44_tree=null;

		try { DebugEnterRule(GrammarFileName, "assignmentbody");
		DebugLocation(71, 38);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 17)) { return retval; }
			// MathLang.g:71:15: ( ID ASSIGN expression )
			DebugEnterAlt(1);
			// MathLang.g:71:17: ID ASSIGN expression
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(71, 17);
			ID43=(IToken)Match(input,ID,Follow._ID_in_assignmentbody555); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			ID43_tree = (object)adaptor.Create(ID43);
			adaptor.AddChild(root_0, ID43_tree);
			}
			DebugLocation(71, 26);
			ASSIGN44=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignmentbody557); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			ASSIGN44_tree = (object)adaptor.Create(ASSIGN44);
			root_0 = (object)adaptor.BecomeRoot(ASSIGN44_tree, root_0);
			}
			DebugLocation(71, 28);
			PushFollow(Follow._expression_in_assignmentbody560);
			expression45=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression45.Tree);

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
		DebugLocation(71, 38);
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
	// MathLang.g:73:1: boolexpression : boolterm ;
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

		MathLangParser.boolterm_return boolterm46 = default(MathLangParser.boolterm_return);


		try { DebugEnterRule(GrammarFileName, "boolexpression");
		DebugLocation(73, 25);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 18)) { return retval; }
			// MathLang.g:73:15: ( boolterm )
			DebugEnterAlt(1);
			// MathLang.g:73:17: boolterm
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(73, 17);
			PushFollow(Follow._boolterm_in_boolexpression568);
			boolterm46=boolterm();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm46.Tree);

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
		DebugLocation(73, 25);
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
	// MathLang.g:74:1: boolterm : or ( ( EQ | NEQ ) or )? ;
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

		IToken set48=null;
		MathLangParser.or_return or47 = default(MathLangParser.or_return);
		MathLangParser.or_return or49 = default(MathLangParser.or_return);

		object set48_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolterm");
		DebugLocation(74, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 19)) { return retval; }
			// MathLang.g:74:9: ( or ( ( EQ | NEQ ) or )? )
			DebugEnterAlt(1);
			// MathLang.g:74:11: or ( ( EQ | NEQ ) or )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(74, 11);
			PushFollow(Follow._or_in_boolterm575);
			or47=or();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or47.Tree);
			DebugLocation(74, 14);
			// MathLang.g:74:14: ( ( EQ | NEQ ) or )?
			int alt7=2;
			try { DebugEnterSubRule(7);
			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
			int LA7_0 = input.LA(1);

			if (((LA7_0>=NEQ && LA7_0<=EQ)))
			{
				alt7=1;
			}
			} finally { DebugExitDecision(7); }
			switch (alt7)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:74:16: ( EQ | NEQ ) or
				{
				DebugLocation(74, 16);
				set48=(IToken)input.LT(1);
				set48=(IToken)input.LT(1);
				if ((input.LA(1)>=NEQ && input.LA(1)<=EQ))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set48), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(74, 28);
				PushFollow(Follow._or_in_boolterm588);
				or49=or();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or49.Tree);

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
			TraceOut("boolterm", 19);
			LeaveRule("boolterm", 19);
			Leave_boolterm();
			if (state.backtracking > 0) { Memoize(input, 19, boolterm_StartIndex); }
		}
		DebugLocation(74, 32);
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
	// MathLang.g:75:1: or : and ( OR and )* ;
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

		IToken OR51=null;
		MathLangParser.and_return and50 = default(MathLangParser.and_return);
		MathLangParser.and_return and52 = default(MathLangParser.and_return);

		object OR51_tree=null;

		try { DebugEnterRule(GrammarFileName, "or");
		DebugLocation(75, 18);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 20)) { return retval; }
			// MathLang.g:75:3: ( and ( OR and )* )
			DebugEnterAlt(1);
			// MathLang.g:75:5: and ( OR and )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(75, 5);
			PushFollow(Follow._and_in_or597);
			and50=and();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and50.Tree);
			DebugLocation(75, 9);
			// MathLang.g:75:9: ( OR and )*
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
					// MathLang.g:75:10: OR and
					{
					DebugLocation(75, 12);
					OR51=(IToken)Match(input,OR,Follow._OR_in_or600); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR51_tree = (object)adaptor.Create(OR51);
					root_0 = (object)adaptor.BecomeRoot(OR51_tree, root_0);
					}
					DebugLocation(75, 14);
					PushFollow(Follow._and_in_or603);
					and52=and();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and52.Tree);

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
			TraceOut("or", 20);
			LeaveRule("or", 20);
			Leave_or();
			if (state.backtracking > 0) { Memoize(input, 20, or_StartIndex); }
		}
		DebugLocation(75, 18);
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
	// MathLang.g:76:1: and : boolgroup ( AND boolgroup )* ;
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

		IToken AND54=null;
		MathLangParser.boolgroup_return boolgroup53 = default(MathLangParser.boolgroup_return);
		MathLangParser.boolgroup_return boolgroup55 = default(MathLangParser.boolgroup_return);

		object AND54_tree=null;

		try { DebugEnterRule(GrammarFileName, "and");
		DebugLocation(76, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 21)) { return retval; }
			// MathLang.g:76:4: ( boolgroup ( AND boolgroup )* )
			DebugEnterAlt(1);
			// MathLang.g:76:6: boolgroup ( AND boolgroup )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(76, 6);
			PushFollow(Follow._boolgroup_in_and611);
			boolgroup53=boolgroup();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup53.Tree);
			DebugLocation(76, 16);
			// MathLang.g:76:16: ( AND boolgroup )*
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
					// MathLang.g:76:17: AND boolgroup
					{
					DebugLocation(76, 20);
					AND54=(IToken)Match(input,AND,Follow._AND_in_and614); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND54_tree = (object)adaptor.Create(AND54);
					root_0 = (object)adaptor.BecomeRoot(AND54_tree, root_0);
					}
					DebugLocation(76, 22);
					PushFollow(Follow._boolgroup_in_and617);
					boolgroup55=boolgroup();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup55.Tree);

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
			TraceOut("and", 21);
			LeaveRule("and", 21);
			Leave_and();
			if (state.backtracking > 0) { Memoize(input, 21, and_StartIndex); }
		}
		DebugLocation(76, 32);
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
	// MathLang.g:77:1: boolgroup : ( NOT )? ( '(' boolterm ')' | boolvar ) ;
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

		IToken NOT56=null;
		IToken char_literal57=null;
		IToken char_literal59=null;
		MathLangParser.boolterm_return boolterm58 = default(MathLangParser.boolterm_return);
		MathLangParser.boolvar_return boolvar60 = default(MathLangParser.boolvar_return);

		object NOT56_tree=null;
		object char_literal57_tree=null;
		object char_literal59_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolgroup");
		DebugLocation(77, 51);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 22)) { return retval; }
			// MathLang.g:77:10: ( ( NOT )? ( '(' boolterm ')' | boolvar ) )
			DebugEnterAlt(1);
			// MathLang.g:77:12: ( NOT )? ( '(' boolterm ')' | boolvar )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(77, 12);
			// MathLang.g:77:12: ( NOT )?
			int alt10=2;
			try { DebugEnterSubRule(10);
			try { DebugEnterDecision(10, decisionCanBacktrack[10]);
			int LA10_0 = input.LA(1);

			if ((LA10_0==NOT))
			{
				alt10=1;
			}
			} finally { DebugExitDecision(10); }
			switch (alt10)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:77:13: NOT
				{
				DebugLocation(77, 16);
				NOT56=(IToken)Match(input,NOT,Follow._NOT_in_boolgroup626); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				NOT56_tree = (object)adaptor.Create(NOT56);
				root_0 = (object)adaptor.BecomeRoot(NOT56_tree, root_0);
				}

				}
				break;

			}
			} finally { DebugExitSubRule(10); }

			DebugLocation(77, 20);
			// MathLang.g:77:20: ( '(' boolterm ')' | boolvar )
			int alt11=2;
			try { DebugEnterSubRule(11);
			try { DebugEnterDecision(11, decisionCanBacktrack[11]);
			int LA11_0 = input.LA(1);

			if ((LA11_0==44))
			{
				int LA11_1 = input.LA(2);

				if ((EvaluatePredicate(synpred28_MathLang_fragment)))
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
				// MathLang.g:77:22: '(' boolterm ')'
				{
				DebugLocation(77, 25);
				char_literal57=(IToken)Match(input,44,Follow._44_in_boolgroup633); if (state.failed) return retval;
				DebugLocation(77, 27);
				PushFollow(Follow._boolterm_in_boolgroup636);
				boolterm58=boolterm();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm58.Tree);
				DebugLocation(77, 39);
				char_literal59=(IToken)Match(input,45,Follow._45_in_boolgroup638); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:77:43: boolvar
				{
				DebugLocation(77, 43);
				PushFollow(Follow._boolvar_in_boolgroup643);
				boolvar60=boolvar();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolvar60.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(11); }


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
		DebugLocation(77, 51);
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
	// MathLang.g:78:1: boolvar : ( TRUE | FALSE | compare );
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

		IToken TRUE61=null;
		IToken FALSE62=null;
		MathLangParser.compare_return compare63 = default(MathLangParser.compare_return);

		object TRUE61_tree=null;
		object FALSE62_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolvar");
		DebugLocation(78, 11);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 23)) { return retval; }
			// MathLang.g:78:8: ( TRUE | FALSE | compare )
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
			case 44:
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
				// MathLang.g:78:10: TRUE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(78, 10);
				TRUE61=(IToken)Match(input,TRUE,Follow._TRUE_in_boolvar651); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				TRUE61_tree = (object)adaptor.Create(TRUE61);
				adaptor.AddChild(root_0, TRUE61_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:79:5: FALSE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(79, 5);
				FALSE62=(IToken)Match(input,FALSE,Follow._FALSE_in_boolvar657); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				FALSE62_tree = (object)adaptor.Create(FALSE62);
				adaptor.AddChild(root_0, FALSE62_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:80:5: compare
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(80, 5);
				PushFollow(Follow._compare_in_boolvar663);
				compare63=compare();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare63.Tree);

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
		DebugLocation(80, 11);
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
	// MathLang.g:82:1: ifstatement : IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )* ;
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

		IToken IF64=null;
		IToken char_literal65=null;
		IToken char_literal67=null;
		IToken ELSE70=null;
		MathLangParser.boolexpression_return boolexpression66 = default(MathLangParser.boolexpression_return);
		MathLangParser.block_return block68 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement69 = default(MathLangParser.statement_return);
		MathLangParser.block_return block71 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement72 = default(MathLangParser.statement_return);

		object IF64_tree=null;
		object char_literal65_tree=null;
		object char_literal67_tree=null;
		object ELSE70_tree=null;

		try { DebugEnterRule(GrammarFileName, "ifstatement");
		DebugLocation(82, 91);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 24)) { return retval; }
			// MathLang.g:82:12: ( IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )* )
			DebugEnterAlt(1);
			// MathLang.g:82:14: IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(82, 16);
			IF64=(IToken)Match(input,IF,Follow._IF_in_ifstatement670); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			IF64_tree = (object)adaptor.Create(IF64);
			root_0 = (object)adaptor.BecomeRoot(IF64_tree, root_0);
			}
			DebugLocation(82, 21);
			char_literal65=(IToken)Match(input,44,Follow._44_in_ifstatement673); if (state.failed) return retval;
			DebugLocation(82, 23);
			PushFollow(Follow._boolexpression_in_ifstatement676);
			boolexpression66=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression66.Tree);
			DebugLocation(82, 41);
			char_literal67=(IToken)Match(input,45,Follow._45_in_ifstatement678); if (state.failed) return retval;
			DebugLocation(82, 43);
			// MathLang.g:82:43: ( block | statement )
			int alt13=2;
			try { DebugEnterSubRule(13);
			try { DebugEnterDecision(13, decisionCanBacktrack[13]);
			int LA13_0 = input.LA(1);

			if ((LA13_0==47))
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
				// MathLang.g:82:44: block
				{
				DebugLocation(82, 44);
				PushFollow(Follow._block_in_ifstatement682);
				block68=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block68.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:82:52: statement
				{
				DebugLocation(82, 52);
				PushFollow(Follow._statement_in_ifstatement686);
				statement69=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement69.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(13); }

			DebugLocation(82, 63);
			// MathLang.g:82:63: ( ELSE ( block | statement ) )*
			try { DebugEnterSubRule(15);
			while (true)
			{
				int alt15=2;
				try { DebugEnterDecision(15, decisionCanBacktrack[15]);
				int LA15_0 = input.LA(1);

				if ((LA15_0==ELSE))
				{
					int LA15_1 = input.LA(2);

					if ((EvaluatePredicate(synpred33_MathLang_fragment)))
					{
						alt15=1;
					}


				}


				} finally { DebugExitDecision(15); }
				switch ( alt15 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:82:64: ELSE ( block | statement )
					{
					DebugLocation(82, 68);
					ELSE70=(IToken)Match(input,ELSE,Follow._ELSE_in_ifstatement690); if (state.failed) return retval;
					DebugLocation(82, 70);
					// MathLang.g:82:70: ( block | statement )
					int alt14=2;
					try { DebugEnterSubRule(14);
					try { DebugEnterDecision(14, decisionCanBacktrack[14]);
					int LA14_0 = input.LA(1);

					if ((LA14_0==47))
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
						// MathLang.g:82:71: block
						{
						DebugLocation(82, 71);
						PushFollow(Follow._block_in_ifstatement694);
						block71=block();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block71.Tree);

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// MathLang.g:82:79: statement
						{
						DebugLocation(82, 79);
						PushFollow(Follow._statement_in_ifstatement698);
						statement72=statement();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement72.Tree);

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
		DebugLocation(82, 91);
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
	// MathLang.g:83:1: whilestatement : WHILE '(' boolexpression ')' ( block | statement ) ;
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

		IToken WHILE73=null;
		IToken char_literal74=null;
		IToken char_literal76=null;
		MathLangParser.boolexpression_return boolexpression75 = default(MathLangParser.boolexpression_return);
		MathLangParser.block_return block77 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement78 = default(MathLangParser.statement_return);

		object WHILE73_tree=null;
		object char_literal74_tree=null;
		object char_literal76_tree=null;

		try { DebugEnterRule(GrammarFileName, "whilestatement");
		DebugLocation(83, 67);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 25)) { return retval; }
			// MathLang.g:83:15: ( WHILE '(' boolexpression ')' ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:83:17: WHILE '(' boolexpression ')' ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(83, 22);
			WHILE73=(IToken)Match(input,WHILE,Follow._WHILE_in_whilestatement708); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			WHILE73_tree = (object)adaptor.Create(WHILE73);
			root_0 = (object)adaptor.BecomeRoot(WHILE73_tree, root_0);
			}
			DebugLocation(83, 27);
			char_literal74=(IToken)Match(input,44,Follow._44_in_whilestatement711); if (state.failed) return retval;
			DebugLocation(83, 29);
			PushFollow(Follow._boolexpression_in_whilestatement714);
			boolexpression75=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression75.Tree);
			DebugLocation(83, 47);
			char_literal76=(IToken)Match(input,45,Follow._45_in_whilestatement716); if (state.failed) return retval;
			DebugLocation(83, 49);
			// MathLang.g:83:49: ( block | statement )
			int alt16=2;
			try { DebugEnterSubRule(16);
			try { DebugEnterDecision(16, decisionCanBacktrack[16]);
			int LA16_0 = input.LA(1);

			if ((LA16_0==47))
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
				// MathLang.g:83:50: block
				{
				DebugLocation(83, 50);
				PushFollow(Follow._block_in_whilestatement720);
				block77=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block77.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:83:58: statement
				{
				DebugLocation(83, 58);
				PushFollow(Follow._statement_in_whilestatement724);
				statement78=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement78.Tree);

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
		DebugLocation(83, 67);
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
	// MathLang.g:84:1: forstatement : FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement ) ;
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

		IToken FOR79=null;
		IToken char_literal80=null;
		IToken char_literal82=null;
		IToken char_literal84=null;
		IToken char_literal86=null;
		MathLangParser.longdeclarationbody_return longdeclarationbody81 = default(MathLangParser.longdeclarationbody_return);
		MathLangParser.boolexpression_return boolexpression83 = default(MathLangParser.boolexpression_return);
		MathLangParser.assignmentbody_return assignmentbody85 = default(MathLangParser.assignmentbody_return);
		MathLangParser.block_return block87 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement88 = default(MathLangParser.statement_return);

		object FOR79_tree=null;
		object char_literal80_tree=null;
		object char_literal82_tree=null;
		object char_literal84_tree=null;
		object char_literal86_tree=null;

		try { DebugEnterRule(GrammarFileName, "forstatement");
		DebugLocation(84, 108);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 26)) { return retval; }
			// MathLang.g:84:13: ( FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:84:15: FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(84, 18);
			FOR79=(IToken)Match(input,FOR,Follow._FOR_in_forstatement731); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			FOR79_tree = (object)adaptor.Create(FOR79);
			root_0 = (object)adaptor.BecomeRoot(FOR79_tree, root_0);
			}
			DebugLocation(84, 23);
			char_literal80=(IToken)Match(input,44,Follow._44_in_forstatement734); if (state.failed) return retval;
			DebugLocation(84, 25);
			PushFollow(Follow._longdeclarationbody_in_forstatement737);
			longdeclarationbody81=longdeclarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclarationbody81.Tree);
			DebugLocation(84, 48);
			char_literal82=(IToken)Match(input,43,Follow._43_in_forstatement739); if (state.failed) return retval;
			DebugLocation(84, 50);
			PushFollow(Follow._boolexpression_in_forstatement742);
			boolexpression83=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression83.Tree);
			DebugLocation(84, 68);
			char_literal84=(IToken)Match(input,43,Follow._43_in_forstatement744); if (state.failed) return retval;
			DebugLocation(84, 70);
			PushFollow(Follow._assignmentbody_in_forstatement747);
			assignmentbody85=assignmentbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentbody85.Tree);
			DebugLocation(84, 88);
			char_literal86=(IToken)Match(input,45,Follow._45_in_forstatement749); if (state.failed) return retval;
			DebugLocation(84, 90);
			// MathLang.g:84:90: ( block | statement )
			int alt17=2;
			try { DebugEnterSubRule(17);
			try { DebugEnterDecision(17, decisionCanBacktrack[17]);
			int LA17_0 = input.LA(1);

			if ((LA17_0==47))
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
				// MathLang.g:84:91: block
				{
				DebugLocation(84, 91);
				PushFollow(Follow._block_in_forstatement753);
				block87=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block87.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:84:99: statement
				{
				DebugLocation(84, 99);
				PushFollow(Follow._statement_in_forstatement757);
				statement88=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement88.Tree);

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
		DebugLocation(84, 108);
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
	// MathLang.g:85:1: returnstatement : RETURN expression ';' ;
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

		IToken RETURN89=null;
		IToken char_literal91=null;
		MathLangParser.expression_return expression90 = default(MathLangParser.expression_return);

		object RETURN89_tree=null;
		object char_literal91_tree=null;

		try { DebugEnterRule(GrammarFileName, "returnstatement");
		DebugLocation(85, 41);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 27)) { return retval; }
			// MathLang.g:85:16: ( RETURN expression ';' )
			DebugEnterAlt(1);
			// MathLang.g:85:18: RETURN expression ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(85, 24);
			RETURN89=(IToken)Match(input,RETURN,Follow._RETURN_in_returnstatement764); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			RETURN89_tree = (object)adaptor.Create(RETURN89);
			root_0 = (object)adaptor.BecomeRoot(RETURN89_tree, root_0);
			}
			DebugLocation(85, 26);
			PushFollow(Follow._expression_in_returnstatement767);
			expression90=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression90.Tree);
			DebugLocation(85, 40);
			char_literal91=(IToken)Match(input,43,Follow._43_in_returnstatement769); if (state.failed) return retval;

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
		DebugLocation(85, 41);
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
	// MathLang.g:87:1: funcdeclaration : TYPE ID '(' ( paramsdeclaration )? ')' block -> ^( ID ^( RETURNS TYPE ) ( paramsdeclaration )? block ) ;
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

		IToken TYPE92=null;
		IToken ID93=null;
		IToken char_literal94=null;
		IToken char_literal96=null;
		MathLangParser.paramsdeclaration_return paramsdeclaration95 = default(MathLangParser.paramsdeclaration_return);
		MathLangParser.block_return block97 = default(MathLangParser.block_return);

		object TYPE92_tree=null;
		object ID93_tree=null;
		object char_literal94_tree=null;
		object char_literal96_tree=null;
		RewriteRuleITokenStream stream_45=new RewriteRuleITokenStream(adaptor,"token 45");
		RewriteRuleITokenStream stream_44=new RewriteRuleITokenStream(adaptor,"token 44");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");
		RewriteRuleSubtreeStream stream_paramsdeclaration=new RewriteRuleSubtreeStream(adaptor,"rule paramsdeclaration");
		RewriteRuleSubtreeStream stream_block=new RewriteRuleSubtreeStream(adaptor,"rule block");
		try { DebugEnterRule(GrammarFileName, "funcdeclaration");
		DebugLocation(87, 120);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 28)) { return retval; }
			// MathLang.g:87:16: ( TYPE ID '(' ( paramsdeclaration )? ')' block -> ^( ID ^( RETURNS TYPE ) ( paramsdeclaration )? block ) )
			DebugEnterAlt(1);
			// MathLang.g:87:18: TYPE ID '(' ( paramsdeclaration )? ')' block
			{
			DebugLocation(87, 18);
			TYPE92=(IToken)Match(input,TYPE,Follow._TYPE_in_funcdeclaration778); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE92);

			DebugLocation(87, 25);
			ID93=(IToken)Match(input,ID,Follow._ID_in_funcdeclaration780); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID93);

			DebugLocation(87, 30);
			char_literal94=(IToken)Match(input,44,Follow._44_in_funcdeclaration783); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_44.Add(char_literal94);

			DebugLocation(87, 32);
			// MathLang.g:87:32: ( paramsdeclaration )?
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
				DebugLocation(87, 32);
				PushFollow(Follow._paramsdeclaration_in_funcdeclaration786);
				paramsdeclaration95=paramsdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_paramsdeclaration.Add(paramsdeclaration95.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(18); }

			DebugLocation(87, 54);
			char_literal96=(IToken)Match(input,45,Follow._45_in_funcdeclaration789); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_45.Add(char_literal96);

			DebugLocation(87, 56);
			PushFollow(Follow._block_in_funcdeclaration792);
			block97=block();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_block.Add(block97.Tree);


			{
			// AST REWRITE
			// elements: block, ID, TYPE, paramsdeclaration
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 87:62: -> ^( ID ^( RETURNS TYPE ) ( paramsdeclaration )? block )
			{
				DebugLocation(87, 65);
				// MathLang.g:87:65: ^( ID ^( RETURNS TYPE ) ( paramsdeclaration )? block )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(87, 67);
				root_1 = (object)adaptor.BecomeRoot(stream_ID.NextNode(), root_1);

				DebugLocation(87, 70);
				// MathLang.g:87:70: ^( RETURNS TYPE )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(87, 72);
				root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(RETURNS, "RETURNS"), root_2);

				DebugLocation(87, 80);
				adaptor.AddChild(root_2, stream_TYPE.NextNode());

				adaptor.AddChild(root_1, root_2);
				}
				DebugLocation(87, 91);
				// MathLang.g:87:91: ( paramsdeclaration )?
				if ( stream_paramsdeclaration.HasNext )
				{
					DebugLocation(87, 91);
					adaptor.AddChild(root_1, stream_paramsdeclaration.NextTree());

				}
				stream_paramsdeclaration.Reset();
				DebugLocation(87, 115);
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
		DebugLocation(87, 120);
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
	// MathLang.g:88:1: paramsdeclaration : ( declarationbody ( ',' declarationbody )* ) -> ^( PARAMETERS ( declarationbody )* ) ;
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

		IToken char_literal99=null;
		MathLangParser.declarationbody_return declarationbody98 = default(MathLangParser.declarationbody_return);
		MathLangParser.declarationbody_return declarationbody100 = default(MathLangParser.declarationbody_return);

		object char_literal99_tree=null;
		RewriteRuleITokenStream stream_46=new RewriteRuleITokenStream(adaptor,"token 46");
		RewriteRuleSubtreeStream stream_declarationbody=new RewriteRuleSubtreeStream(adaptor,"rule declarationbody");
		try { DebugEnterRule(GrammarFileName, "paramsdeclaration");
		DebugLocation(88, 102);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 29)) { return retval; }
			// MathLang.g:88:18: ( ( declarationbody ( ',' declarationbody )* ) -> ^( PARAMETERS ( declarationbody )* ) )
			DebugEnterAlt(1);
			// MathLang.g:88:20: ( declarationbody ( ',' declarationbody )* )
			{
			DebugLocation(88, 20);
			// MathLang.g:88:20: ( declarationbody ( ',' declarationbody )* )
			DebugEnterAlt(1);
			// MathLang.g:88:22: declarationbody ( ',' declarationbody )*
			{
			DebugLocation(88, 22);
			PushFollow(Follow._declarationbody_in_paramsdeclaration823);
			declarationbody98=declarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declarationbody.Add(declarationbody98.Tree);
			DebugLocation(88, 38);
			// MathLang.g:88:38: ( ',' declarationbody )*
			try { DebugEnterSubRule(19);
			while (true)
			{
				int alt19=2;
				try { DebugEnterDecision(19, decisionCanBacktrack[19]);
				int LA19_0 = input.LA(1);

				if ((LA19_0==46))
				{
					alt19=1;
				}


				} finally { DebugExitDecision(19); }
				switch ( alt19 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:88:40: ',' declarationbody
					{
					DebugLocation(88, 43);
					char_literal99=(IToken)Match(input,46,Follow._46_in_paramsdeclaration827); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_46.Add(char_literal99);

					DebugLocation(88, 45);
					PushFollow(Follow._declarationbody_in_paramsdeclaration830);
					declarationbody100=declarationbody();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_declarationbody.Add(declarationbody100.Tree);

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
			// 88:66: -> ^( PARAMETERS ( declarationbody )* )
			{
				DebugLocation(88, 69);
				// MathLang.g:88:69: ^( PARAMETERS ( declarationbody )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(88, 71);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_1);

				DebugLocation(88, 82);
				// MathLang.g:88:82: ( declarationbody )*
				while ( stream_declarationbody.HasNext )
				{
					DebugLocation(88, 84);
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
		DebugLocation(88, 102);
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
	// MathLang.g:90:1: funccallbody : ID '(' ( expressioncommalist )? ')' ;
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

		IToken ID101=null;
		IToken char_literal102=null;
		IToken char_literal104=null;
		MathLangParser.expressioncommalist_return expressioncommalist103 = default(MathLangParser.expressioncommalist_return);

		object ID101_tree=null;
		object char_literal102_tree=null;
		object char_literal104_tree=null;

		try { DebugEnterRule(GrammarFileName, "funccallbody");
		DebugLocation(90, 46);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 30)) { return retval; }
			// MathLang.g:90:13: ( ID '(' ( expressioncommalist )? ')' )
			DebugEnterAlt(1);
			// MathLang.g:90:15: ID '(' ( expressioncommalist )? ')'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(90, 17);
			ID101=(IToken)Match(input,ID,Follow._ID_in_funccallbody855); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			ID101_tree = (object)adaptor.Create(ID101);
			root_0 = (object)adaptor.BecomeRoot(ID101_tree, root_0);
			}
			DebugLocation(90, 19);
			char_literal102=(IToken)Match(input,44,Follow._44_in_funccallbody858); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal102_tree = (object)adaptor.Create(char_literal102);
			adaptor.AddChild(root_0, char_literal102_tree);
			}
			DebugLocation(90, 23);
			// MathLang.g:90:23: ( expressioncommalist )?
			int alt20=2;
			try { DebugEnterSubRule(20);
			try { DebugEnterDecision(20, decisionCanBacktrack[20]);
			int LA20_0 = input.LA(1);

			if (((LA20_0>=NUMBER && LA20_0<=CHAR)||LA20_0==44))
			{
				alt20=1;
			}
			} finally { DebugExitDecision(20); }
			switch (alt20)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: expressioncommalist
				{
				DebugLocation(90, 23);
				PushFollow(Follow._expressioncommalist_in_funccallbody860);
				expressioncommalist103=expressioncommalist();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expressioncommalist103.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(20); }

			DebugLocation(90, 44);
			char_literal104=(IToken)Match(input,45,Follow._45_in_funccallbody863); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal104_tree = (object)adaptor.Create(char_literal104);
			adaptor.AddChild(root_0, char_literal104_tree);
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
		DebugLocation(90, 46);
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
	// MathLang.g:91:1: funccall : funccallbody ';' ;
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

		IToken char_literal106=null;
		MathLangParser.funccallbody_return funccallbody105 = default(MathLangParser.funccallbody_return);

		object char_literal106_tree=null;

		try { DebugEnterRule(GrammarFileName, "funccall");
		DebugLocation(91, 27);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 31)) { return retval; }
			// MathLang.g:91:9: ( funccallbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:91:11: funccallbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(91, 11);
			PushFollow(Follow._funccallbody_in_funccall869);
			funccallbody105=funccallbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody105.Tree);
			DebugLocation(91, 27);
			char_literal106=(IToken)Match(input,43,Follow._43_in_funccall871); if (state.failed) return retval;

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
		DebugLocation(91, 27);
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
	// MathLang.g:92:1: expressioncommalist : expression ( ',' expression )* -> ^( PARAMETERS ( expression )* ) ;
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

		IToken char_literal108=null;
		MathLangParser.expression_return expression107 = default(MathLangParser.expression_return);
		MathLangParser.expression_return expression109 = default(MathLangParser.expression_return);

		object char_literal108_tree=null;
		RewriteRuleITokenStream stream_46=new RewriteRuleITokenStream(adaptor,"token 46");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "expressioncommalist");
		DebugLocation(92, 83);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 32)) { return retval; }
			// MathLang.g:92:20: ( expression ( ',' expression )* -> ^( PARAMETERS ( expression )* ) )
			DebugEnterAlt(1);
			// MathLang.g:92:22: expression ( ',' expression )*
			{
			DebugLocation(92, 22);
			PushFollow(Follow._expression_in_expressioncommalist878);
			expression107=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression107.Tree);
			DebugLocation(92, 33);
			// MathLang.g:92:33: ( ',' expression )*
			try { DebugEnterSubRule(21);
			while (true)
			{
				int alt21=2;
				try { DebugEnterDecision(21, decisionCanBacktrack[21]);
				int LA21_0 = input.LA(1);

				if ((LA21_0==46))
				{
					alt21=1;
				}


				} finally { DebugExitDecision(21); }
				switch ( alt21 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:92:35: ',' expression
					{
					DebugLocation(92, 38);
					char_literal108=(IToken)Match(input,46,Follow._46_in_expressioncommalist882); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_46.Add(char_literal108);

					DebugLocation(92, 40);
					PushFollow(Follow._expression_in_expressioncommalist885);
					expression109=expression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_expression.Add(expression109.Tree);

					}
					break;

				default:
					goto loop21;
				}
			}

			loop21:
				;

			} finally { DebugExitSubRule(21); }



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
			// 92:53: -> ^( PARAMETERS ( expression )* )
			{
				DebugLocation(92, 56);
				// MathLang.g:92:56: ^( PARAMETERS ( expression )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(92, 58);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_1);

				DebugLocation(92, 69);
				// MathLang.g:92:69: ( expression )*
				while ( stream_expression.HasNext )
				{
					DebugLocation(92, 70);
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
		DebugLocation(92, 83);
		} finally { DebugExitRule(GrammarFileName, "expressioncommalist"); }
		return retval;

	}
	// $ANTLR end "expressioncommalist"

	public class block_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_block();
	partial void Leave_block();

	// $ANTLR start "block"
	// MathLang.g:94:1: block : '{' statementlist '}' ;
	[GrammarRule("block")]
	private MathLangParser.block_return block()
	{
		Enter_block();
		EnterRule("block", 33);
		TraceIn("block", 33);
		MathLangParser.block_return retval = new MathLangParser.block_return();
		retval.Start = (IToken)input.LT(1);
		int block_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal110=null;
		IToken char_literal112=null;
		MathLangParser.statementlist_return statementlist111 = default(MathLangParser.statementlist_return);

		object char_literal110_tree=null;
		object char_literal112_tree=null;

		try { DebugEnterRule(GrammarFileName, "block");
		DebugLocation(94, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 33)) { return retval; }
			// MathLang.g:94:6: ( '{' statementlist '}' )
			DebugEnterAlt(1);
			// MathLang.g:94:8: '{' statementlist '}'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(94, 11);
			char_literal110=(IToken)Match(input,47,Follow._47_in_block906); if (state.failed) return retval;
			DebugLocation(94, 13);
			PushFollow(Follow._statementlist_in_block909);
			statementlist111=statementlist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementlist111.Tree);
			DebugLocation(94, 30);
			char_literal112=(IToken)Match(input,48,Follow._48_in_block911); if (state.failed) return retval;

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
			TraceOut("block", 33);
			LeaveRule("block", 33);
			Leave_block();
			if (state.backtracking > 0) { Memoize(input, 33, block_StartIndex); }
		}
		DebugLocation(94, 30);
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
	// MathLang.g:96:1: statementlist : ( statement )* -> ^( BLOCK ( statement )* ) ;
	[GrammarRule("statementlist")]
	private MathLangParser.statementlist_return statementlist()
	{
		Enter_statementlist();
		EnterRule("statementlist", 34);
		TraceIn("statementlist", 34);
		MathLangParser.statementlist_return retval = new MathLangParser.statementlist_return();
		retval.Start = (IToken)input.LT(1);
		int statementlist_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.statement_return statement113 = default(MathLangParser.statement_return);

		RewriteRuleSubtreeStream stream_statement=new RewriteRuleSubtreeStream(adaptor,"rule statement");
		try { DebugEnterRule(GrammarFileName, "statementlist");
		DebugLocation(96, 49);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 34)) { return retval; }
			// MathLang.g:96:14: ( ( statement )* -> ^( BLOCK ( statement )* ) )
			DebugEnterAlt(1);
			// MathLang.g:96:16: ( statement )*
			{
			DebugLocation(96, 16);
			// MathLang.g:96:16: ( statement )*
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
					DebugLocation(96, 16);
					PushFollow(Follow._statement_in_statementlist919);
					statement113=statement();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_statement.Add(statement113.Tree);

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
			// 96:27: -> ^( BLOCK ( statement )* )
			{
				DebugLocation(96, 30);
				// MathLang.g:96:30: ^( BLOCK ( statement )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(96, 32);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

				DebugLocation(96, 38);
				// MathLang.g:96:38: ( statement )*
				while ( stream_statement.HasNext )
				{
					DebugLocation(96, 38);
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
			TraceOut("statementlist", 34);
			LeaveRule("statementlist", 34);
			Leave_statementlist();
			if (state.backtracking > 0) { Memoize(input, 34, statementlist_StartIndex); }
		}
		DebugLocation(96, 49);
		} finally { DebugExitRule(GrammarFileName, "statementlist"); }
		return retval;

	}
	// $ANTLR end "statementlist"

	partial void Enter_synpred21_MathLang_fragment();
	partial void Leave_synpred21_MathLang_fragment();

	// $ANTLR start synpred21_MathLang
	public void synpred21_MathLang_fragment()
	{
		Enter_synpred21_MathLang_fragment();
		EnterRule("synpred21_MathLang_fragment", 55);
		TraceIn("synpred21_MathLang_fragment", 55);
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
			PushFollow(Follow._add_in_synpred21_MathLang512);
			add();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred21_MathLang_fragment", 55);
			LeaveRule("synpred21_MathLang_fragment", 55);
			Leave_synpred21_MathLang_fragment();
		}
	}
	// $ANTLR end synpred21_MathLang

	partial void Enter_synpred28_MathLang_fragment();
	partial void Leave_synpred28_MathLang_fragment();

	// $ANTLR start synpred28_MathLang
	public void synpred28_MathLang_fragment()
	{
		Enter_synpred28_MathLang_fragment();
		EnterRule("synpred28_MathLang_fragment", 62);
		TraceIn("synpred28_MathLang_fragment", 62);
		try
		{
			// MathLang.g:77:22: ( '(' boolterm ')' )
			DebugEnterAlt(1);
			// MathLang.g:77:22: '(' boolterm ')'
			{
			DebugLocation(77, 22);
			Match(input,44,Follow._44_in_synpred28_MathLang633); if (state.failed) return;
			DebugLocation(77, 27);
			PushFollow(Follow._boolterm_in_synpred28_MathLang636);
			boolterm();
			PopFollow();
			if (state.failed) return;
			DebugLocation(77, 36);
			Match(input,45,Follow._45_in_synpred28_MathLang638); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred28_MathLang_fragment", 62);
			LeaveRule("synpred28_MathLang_fragment", 62);
			Leave_synpred28_MathLang_fragment();
		}
	}
	// $ANTLR end synpred28_MathLang

	partial void Enter_synpred33_MathLang_fragment();
	partial void Leave_synpred33_MathLang_fragment();

	// $ANTLR start synpred33_MathLang
	public void synpred33_MathLang_fragment()
	{
		Enter_synpred33_MathLang_fragment();
		EnterRule("synpred33_MathLang_fragment", 67);
		TraceIn("synpred33_MathLang_fragment", 67);
		try
		{
			// MathLang.g:82:64: ( ELSE ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:82:64: ELSE ( block | statement )
			{
			DebugLocation(82, 64);
			Match(input,ELSE,Follow._ELSE_in_synpred33_MathLang690); if (state.failed) return;
			DebugLocation(82, 70);
			// MathLang.g:82:70: ( block | statement )
			int alt23=2;
			try { DebugEnterSubRule(23);
			try { DebugEnterDecision(23, decisionCanBacktrack[23]);
			int LA23_0 = input.LA(1);

			if ((LA23_0==47))
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
				// MathLang.g:82:71: block
				{
				DebugLocation(82, 71);
				PushFollow(Follow._block_in_synpred33_MathLang694);
				block();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:82:79: statement
				{
				DebugLocation(82, 79);
				PushFollow(Follow._statement_in_synpred33_MathLang698);
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
			TraceOut("synpred33_MathLang_fragment", 67);
			LeaveRule("synpred33_MathLang_fragment", 67);
			Leave_synpred33_MathLang_fragment();
		}
	}
	// $ANTLR end synpred33_MathLang
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
			"\x1\x13\x1\x11\x1\x2C\x4\xFFFF\x1\x2C\x4\xFFFF";
		private const string DFA1_acceptS =
			"\x3\xFFFF\x1\x3\x1\x4\x1\x5\x1\x7\x1\xFFFF\x1\x2\x1\x8\x1\x1\x1\x6";
		private const string DFA1_specialS =
			"\xC\xFFFF}>";
		private static readonly string[] DFA1_transitionS =
			{
				"\x1\x3\x1\xFFFF\x1\x5\x1\xFFFF\x1\x6\x1\x4\x4\xFFFF\x1\x2\x1\xFFFF"+
				"\x1\x1",
				"\x1\x7",
				"\x1\x8\x17\xFFFF\x1\x9",
				"",
				"",
				"",
				"",
				"\x1\xA\x16\xFFFF\x1\xA\x1\xB",
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
		public static readonly BitSet _term_in_mathexpression341 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathexpression_in_expression351 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declarationbody_in_declaration358 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _43_in_declaration360 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _longdeclaration_in_declaration368 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_declarationbody375 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _ID_in_declarationbody378 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _longdeclarationbody_in_longdeclaration385 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _43_in_longdeclaration387 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_longdeclarationbody395 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _ID_in_longdeclarationbody397 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _ASSIGN_in_longdeclarationbody399 = new BitSet(new ulong[]{0x100000070000UL});
		public static readonly BitSet _expression_in_longdeclarationbody401 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_variable423 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _ID_in_variable432 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mul_in_add439 = new BitSet(new ulong[]{0xC00002UL});
		public static readonly BitSet _set_in_add443 = new BitSet(new ulong[]{0x100000070000UL});
		public static readonly BitSet _mul_in_add452 = new BitSet(new ulong[]{0xC00002UL});
		public static readonly BitSet _group_in_mul461 = new BitSet(new ulong[]{0x3000002UL});
		public static readonly BitSet _set_in_mul465 = new BitSet(new ulong[]{0x100000070000UL});
		public static readonly BitSet _group_in_mul474 = new BitSet(new ulong[]{0x3000002UL});
		public static readonly BitSet _add_in_compare482 = new BitSet(new ulong[]{0xFC000002UL});
		public static readonly BitSet _set_in_compare486 = new BitSet(new ulong[]{0x100000070000UL});
		public static readonly BitSet _add_in_compare512 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _add_in_term523 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _44_in_group529 = new BitSet(new ulong[]{0x100000070000UL});
		public static readonly BitSet _term_in_group532 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _45_in_group534 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _number_in_group539 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assignmentbody_in_assignment546 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _43_in_assignment548 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_assignmentbody555 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _ASSIGN_in_assignmentbody557 = new BitSet(new ulong[]{0x100000070000UL});
		public static readonly BitSet _expression_in_assignmentbody560 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolterm_in_boolexpression568 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _or_in_boolterm575 = new BitSet(new ulong[]{0x30000002UL});
		public static readonly BitSet _set_in_boolterm579 = new BitSet(new ulong[]{0x101C00070000UL});
		public static readonly BitSet _or_in_boolterm588 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _and_in_or597 = new BitSet(new ulong[]{0x100000002UL});
		public static readonly BitSet _OR_in_or600 = new BitSet(new ulong[]{0x101C00070000UL});
		public static readonly BitSet _and_in_or603 = new BitSet(new ulong[]{0x100000002UL});
		public static readonly BitSet _boolgroup_in_and611 = new BitSet(new ulong[]{0x200000002UL});
		public static readonly BitSet _AND_in_and614 = new BitSet(new ulong[]{0x101C00070000UL});
		public static readonly BitSet _boolgroup_in_and617 = new BitSet(new ulong[]{0x200000002UL});
		public static readonly BitSet _NOT_in_boolgroup626 = new BitSet(new ulong[]{0x101C00070000UL});
		public static readonly BitSet _44_in_boolgroup633 = new BitSet(new ulong[]{0x101C00070000UL});
		public static readonly BitSet _boolterm_in_boolgroup636 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _45_in_boolgroup638 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolvar_in_boolgroup643 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TRUE_in_boolvar651 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FALSE_in_boolvar657 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _compare_in_boolvar663 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_ifstatement670 = new BitSet(new ulong[]{0x100000000000UL});
		public static readonly BitSet _44_in_ifstatement673 = new BitSet(new ulong[]{0x101C00070000UL});
		public static readonly BitSet _boolexpression_in_ifstatement676 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _45_in_ifstatement678 = new BitSet(new ulong[]{0x8000000A1A80UL});
		public static readonly BitSet _block_in_ifstatement682 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement686 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _ELSE_in_ifstatement690 = new BitSet(new ulong[]{0x8000000A1A80UL});
		public static readonly BitSet _block_in_ifstatement694 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement698 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _WHILE_in_whilestatement708 = new BitSet(new ulong[]{0x100000000000UL});
		public static readonly BitSet _44_in_whilestatement711 = new BitSet(new ulong[]{0x101C00070000UL});
		public static readonly BitSet _boolexpression_in_whilestatement714 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _45_in_whilestatement716 = new BitSet(new ulong[]{0x8000000A1A80UL});
		public static readonly BitSet _block_in_whilestatement720 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_whilestatement724 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_forstatement731 = new BitSet(new ulong[]{0x100000000000UL});
		public static readonly BitSet _44_in_forstatement734 = new BitSet(new ulong[]{0x80000UL});
		public static readonly BitSet _longdeclarationbody_in_forstatement737 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _43_in_forstatement739 = new BitSet(new ulong[]{0x101C00070000UL});
		public static readonly BitSet _boolexpression_in_forstatement742 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _43_in_forstatement744 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _assignmentbody_in_forstatement747 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _45_in_forstatement749 = new BitSet(new ulong[]{0x8000000A1A80UL});
		public static readonly BitSet _block_in_forstatement753 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_forstatement757 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _RETURN_in_returnstatement764 = new BitSet(new ulong[]{0x100000070000UL});
		public static readonly BitSet _expression_in_returnstatement767 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _43_in_returnstatement769 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_funcdeclaration778 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _ID_in_funcdeclaration780 = new BitSet(new ulong[]{0x100000000000UL});
		public static readonly BitSet _44_in_funcdeclaration783 = new BitSet(new ulong[]{0x200000080000UL});
		public static readonly BitSet _paramsdeclaration_in_funcdeclaration786 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _45_in_funcdeclaration789 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _block_in_funcdeclaration792 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declarationbody_in_paramsdeclaration823 = new BitSet(new ulong[]{0x400000000002UL});
		public static readonly BitSet _46_in_paramsdeclaration827 = new BitSet(new ulong[]{0x80000UL});
		public static readonly BitSet _declarationbody_in_paramsdeclaration830 = new BitSet(new ulong[]{0x400000000002UL});
		public static readonly BitSet _ID_in_funccallbody855 = new BitSet(new ulong[]{0x100000000000UL});
		public static readonly BitSet _44_in_funccallbody858 = new BitSet(new ulong[]{0x300000070000UL});
		public static readonly BitSet _expressioncommalist_in_funccallbody860 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _45_in_funccallbody863 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_funccall869 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _43_in_funccall871 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_expressioncommalist878 = new BitSet(new ulong[]{0x400000000002UL});
		public static readonly BitSet _46_in_expressioncommalist882 = new BitSet(new ulong[]{0x100000070000UL});
		public static readonly BitSet _expression_in_expressioncommalist885 = new BitSet(new ulong[]{0x400000000002UL});
		public static readonly BitSet _47_in_block906 = new BitSet(new ulong[]{0x18000000A1A80UL});
		public static readonly BitSet _statementlist_in_block909 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _48_in_block911 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_statementlist919 = new BitSet(new ulong[]{0x8000000A1A82UL});
		public static readonly BitSet _set_in_synpred21_MathLang486 = new BitSet(new ulong[]{0x100000070000UL});
		public static readonly BitSet _add_in_synpred21_MathLang512 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _44_in_synpred28_MathLang633 = new BitSet(new ulong[]{0x101C00070000UL});
		public static readonly BitSet _boolterm_in_synpred28_MathLang636 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _45_in_synpred28_MathLang638 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ELSE_in_synpred33_MathLang690 = new BitSet(new ulong[]{0x8000000A1A80UL});
		public static readonly BitSet _block_in_synpred33_MathLang694 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_synpred33_MathLang698 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  MathLang 

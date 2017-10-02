// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-10-02 21:03:12

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "UNKNOWN", "PRINT", "INPUT", "IF", "ELSE", "FOR", "FUNCTION", "RETURN", "WHILE", "BLOCK", "PROGRAM", "PARAMS", "VARDECLARATION", "FUNCDECLARATION", "VARASSIGNMENT", "NUMBER", "ID", "CHAR", "TYPE", "ASSIGN", "ADD", "SUB", "MUL", "DIV", "GREQ", "LSEQ", "NEQ", "EQ", "GR", "LS", "OR", "AND", "NOT", "TRUE", "FALSE", "KNEW", "TYPE0", "SQRBL", "SQRBR", "ACCESS_MODIFIER", "RETURNS", "PARAMETERS", "WS", "SL_COMMENT", "ML_COMMENT", "';'", "'('", "')'", "','", "'{'", "'}'"
	};
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

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, false, true, false, false, false, false, 
				false, false, true, false, false, false, true, false, false, false, 
				false, false, false, false, , false
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
	// MathLang.g:38:8: public execute : statementlist EOF ;
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
		DebugLocation(38, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 1)) { return retval; }
			// MathLang.g:38:15: ( statementlist EOF )
			DebugEnterAlt(1);
			// MathLang.g:39:2: statementlist EOF
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(39, 2);
			PushFollow(Follow._statementlist_in_execute290);
			statementlist1=statementlist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementlist1.Tree);
			DebugLocation(39, 19);
			EOF2=(IToken)Match(input,EOF,Follow._EOF_in_execute292); if (state.failed) return retval;

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
		DebugLocation(40, 0);
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
	// MathLang.g:42:1: statement : ( declaration | assignment | ifstatement | whilestatement | forstatement | funcdeclaration | returnstatement | funccall ) ;
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
		DebugLocation(42, 13);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 2)) { return retval; }
			// MathLang.g:42:10: ( ( declaration | assignment | ifstatement | whilestatement | forstatement | funcdeclaration | returnstatement | funccall ) )
			DebugEnterAlt(1);
			// MathLang.g:42:12: ( declaration | assignment | ifstatement | whilestatement | forstatement | funcdeclaration | returnstatement | funccall )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(42, 12);
			// MathLang.g:42:12: ( declaration | assignment | ifstatement | whilestatement | forstatement | funcdeclaration | returnstatement | funccall )
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
				// MathLang.g:42:14: declaration
				{
				DebugLocation(42, 14);
				PushFollow(Follow._declaration_in_statement303);
				declaration3=declaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, declaration3.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:43:4: assignment
				{
				DebugLocation(43, 4);
				PushFollow(Follow._assignment_in_statement309);
				assignment4=assignment();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment4.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:44:4: ifstatement
				{
				DebugLocation(44, 4);
				PushFollow(Follow._ifstatement_in_statement314);
				ifstatement5=ifstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ifstatement5.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:45:4: whilestatement
				{
				DebugLocation(45, 4);
				PushFollow(Follow._whilestatement_in_statement319);
				whilestatement6=whilestatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, whilestatement6.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:46:4: forstatement
				{
				DebugLocation(46, 4);
				PushFollow(Follow._forstatement_in_statement324);
				forstatement7=forstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forstatement7.Tree);

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// MathLang.g:47:4: funcdeclaration
				{
				DebugLocation(47, 4);
				PushFollow(Follow._funcdeclaration_in_statement329);
				funcdeclaration8=funcdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funcdeclaration8.Tree);

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// MathLang.g:48:4: returnstatement
				{
				DebugLocation(48, 4);
				PushFollow(Follow._returnstatement_in_statement334);
				returnstatement9=returnstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, returnstatement9.Tree);

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// MathLang.g:49:4: funccall
				{
				DebugLocation(49, 4);
				PushFollow(Follow._funccall_in_statement339);
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
		DebugLocation(49, 13);
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
	// MathLang.g:51:1: number : ( NUMBER | ID | funccallbody | CHAR );
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

		object NUMBER11_tree=null;
		object ID12_tree=null;
		object CHAR14_tree=null;

		try { DebugEnterRule(GrammarFileName, "number");
		DebugLocation(51, 8);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 3)) { return retval; }
			// MathLang.g:51:8: ( NUMBER | ID | funccallbody | CHAR )
			int alt2=4;
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
				int LA2_2 = input.LA(2);

				if ((LA2_2==50))
				{
					alt2=3;
				}
				else if ((LA2_2==EOF||(LA2_2>=ADD && LA2_2<=AND)||LA2_2==49||LA2_2==51))
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
				// MathLang.g:51:11: NUMBER
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(51, 11);
				NUMBER11=(IToken)Match(input,NUMBER,Follow._NUMBER_in_number350); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				NUMBER11_tree = (object)adaptor.Create(NUMBER11);
				adaptor.AddChild(root_0, NUMBER11_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:52:5: ID
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(52, 5);
				ID12=(IToken)Match(input,ID,Follow._ID_in_number356); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				ID12_tree = (object)adaptor.Create(ID12);
				adaptor.AddChild(root_0, ID12_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:53:5: funccallbody
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(53, 5);
				PushFollow(Follow._funccallbody_in_number362);
				funccallbody13=funccallbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody13.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:54:5: CHAR
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(54, 5);
				CHAR14=(IToken)Match(input,CHAR,Follow._CHAR_in_number368); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				CHAR14_tree = (object)adaptor.Create(CHAR14);
				adaptor.AddChild(root_0, CHAR14_tree);
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
			TraceOut("number", 3);
			LeaveRule("number", 3);
			Leave_number();
			if (state.backtracking > 0) { Memoize(input, 3, number_StartIndex); }
		}
		DebugLocation(54, 8);
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
	// MathLang.g:55:1: mathexpression : term ;
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

		MathLangParser.term_return term15 = default(MathLangParser.term_return);


		try { DebugEnterRule(GrammarFileName, "mathexpression");
		DebugLocation(55, 21);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 4)) { return retval; }
			// MathLang.g:55:15: ( term )
			DebugEnterAlt(1);
			// MathLang.g:55:17: term
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(55, 17);
			PushFollow(Follow._term_in_mathexpression374);
			term15=term();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term15.Tree);

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
		DebugLocation(55, 21);
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
	// MathLang.g:57:1: expression : newexpression ;
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

		MathLangParser.newexpression_return newexpression16 = default(MathLangParser.newexpression_return);


		try { DebugEnterRule(GrammarFileName, "expression");
		DebugLocation(57, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 5)) { return retval; }
			// MathLang.g:57:11: ( newexpression )
			DebugEnterAlt(1);
			// MathLang.g:58:5: newexpression
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(58, 5);
			PushFollow(Follow._newexpression_in_expression388);
			newexpression16=newexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, newexpression16.Tree);

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
		DebugLocation(63, 0);
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
	// MathLang.g:65:1: declaration : ( declarationbody ';' | longdeclaration );
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

		IToken char_literal18=null;
		MathLangParser.declarationbody_return declarationbody17 = default(MathLangParser.declarationbody_return);
		MathLangParser.longdeclaration_return longdeclaration19 = default(MathLangParser.longdeclaration_return);

		object char_literal18_tree=null;

		try { DebugEnterRule(GrammarFileName, "declaration");
		DebugLocation(65, 20);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 6)) { return retval; }
			// MathLang.g:65:12: ( declarationbody ';' | longdeclaration )
			int alt3=2;
			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
			int LA3_0 = input.LA(1);

			if ((LA3_0==TYPE))
			{
				int LA3_1 = input.LA(2);

				if ((LA3_1==ID))
				{
					int LA3_2 = input.LA(3);

					if ((LA3_2==ASSIGN))
					{
						alt3=2;
					}
					else if ((LA3_2==49))
					{
						alt3=1;
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
				// MathLang.g:65:14: declarationbody ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(65, 14);
				PushFollow(Follow._declarationbody_in_declaration400);
				declarationbody17=declarationbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, declarationbody17.Tree);
				DebugLocation(65, 33);
				char_literal18=(IToken)Match(input,49,Follow._49_in_declaration402); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:66:6: longdeclaration
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(66, 6);
				PushFollow(Follow._longdeclaration_in_declaration410);
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
		DebugLocation(66, 20);
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
	// MathLang.g:68:1: declarationbody : TYPE ID -> ^( VARDECLARATION TYPE ID ) ;
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
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");

		try { DebugEnterRule(GrammarFileName, "declarationbody");
		DebugLocation(68, 54);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 7)) { return retval; }
			// MathLang.g:68:16: ( TYPE ID -> ^( VARDECLARATION TYPE ID ) )
			DebugEnterAlt(1);
			// MathLang.g:68:18: TYPE ID
			{
			DebugLocation(68, 18);
			TYPE20=(IToken)Match(input,TYPE,Follow._TYPE_in_declarationbody417); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE20);

			DebugLocation(68, 23);
			ID21=(IToken)Match(input,ID,Follow._ID_in_declarationbody419); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID21);



			{
			// AST REWRITE
			// elements: TYPE, ID
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 68:26: -> ^( VARDECLARATION TYPE ID )
			{
				DebugLocation(68, 29);
				// MathLang.g:68:29: ^( VARDECLARATION TYPE ID )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(68, 31);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDECLARATION, "VARDECLARATION"), root_1);

				DebugLocation(68, 46);
				adaptor.AddChild(root_1, stream_TYPE.NextNode());
				DebugLocation(68, 51);
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
			TraceOut("declarationbody", 7);
			LeaveRule("declarationbody", 7);
			Leave_declarationbody();
			if (state.backtracking > 0) { Memoize(input, 7, declarationbody_StartIndex); }
		}
		DebugLocation(68, 54);
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
	// MathLang.g:69:1: longdeclaration : longdeclarationbody ';' ;
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

		IToken char_literal23=null;
		MathLangParser.longdeclarationbody_return longdeclarationbody22 = default(MathLangParser.longdeclarationbody_return);

		object char_literal23_tree=null;

		try { DebugEnterRule(GrammarFileName, "longdeclaration");
		DebugLocation(69, 42);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 8)) { return retval; }
			// MathLang.g:69:16: ( longdeclarationbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:69:18: longdeclarationbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(69, 18);
			PushFollow(Follow._longdeclarationbody_in_longdeclaration436);
			longdeclarationbody22=longdeclarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclarationbody22.Tree);
			DebugLocation(69, 41);
			char_literal23=(IToken)Match(input,49,Follow._49_in_longdeclaration438); if (state.failed) return retval;

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
		DebugLocation(69, 42);
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
	// MathLang.g:70:1: longdeclarationbody : TYPE ID ASSIGN expression -> ^( VARDECLARATION TYPE ID expression ) ;
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
		DebugLocation(70, 87);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 9)) { return retval; }
			// MathLang.g:70:20: ( TYPE ID ASSIGN expression -> ^( VARDECLARATION TYPE ID expression ) )
			DebugEnterAlt(1);
			// MathLang.g:70:22: TYPE ID ASSIGN expression
			{
			DebugLocation(70, 22);
			TYPE24=(IToken)Match(input,TYPE,Follow._TYPE_in_longdeclarationbody446); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE24);

			DebugLocation(70, 27);
			ID25=(IToken)Match(input,ID,Follow._ID_in_longdeclarationbody448); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID25);

			DebugLocation(70, 30);
			ASSIGN26=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclarationbody450); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN26);

			DebugLocation(70, 37);
			PushFollow(Follow._expression_in_longdeclarationbody452);
			expression27=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression27.Tree);


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
			// 70:48: -> ^( VARDECLARATION TYPE ID expression )
			{
				DebugLocation(70, 51);
				// MathLang.g:70:51: ^( VARDECLARATION TYPE ID expression )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(70, 53);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDECLARATION, "VARDECLARATION"), root_1);

				DebugLocation(70, 68);
				adaptor.AddChild(root_1, stream_TYPE.NextNode());
				DebugLocation(70, 73);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(70, 76);
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
		DebugLocation(70, 87);
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
	// MathLang.g:72:1: add : mul ( ( ADD | SUB ) mul )* ;
	[GrammarRule("add")]
	private MathLangParser.add_return add()
	{
		Enter_add();
		EnterRule("add", 10);
		TraceIn("add", 10);
		MathLangParser.add_return retval = new MathLangParser.add_return();
		retval.Start = (IToken)input.LT(1);
		int add_StartIndex = input.Index;
		object root_0 = null;

		IToken set29=null;
		MathLangParser.mul_return mul28 = default(MathLangParser.mul_return);
		MathLangParser.mul_return mul30 = default(MathLangParser.mul_return);

		object set29_tree=null;

		try { DebugEnterRule(GrammarFileName, "add");
		DebugLocation(72, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 10)) { return retval; }
			// MathLang.g:72:4: ( mul ( ( ADD | SUB ) mul )* )
			DebugEnterAlt(1);
			// MathLang.g:72:6: mul ( ( ADD | SUB ) mul )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(72, 6);
			PushFollow(Follow._mul_in_add472);
			mul28=mul();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul28.Tree);
			DebugLocation(72, 10);
			// MathLang.g:72:10: ( ( ADD | SUB ) mul )*
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
					// MathLang.g:72:12: ( ADD | SUB ) mul
					{
					DebugLocation(72, 12);
					set29=(IToken)input.LT(1);
					set29=(IToken)input.LT(1);
					if ((input.LA(1)>=ADD && input.LA(1)<=SUB))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set29), root_0);
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(72, 25);
					PushFollow(Follow._mul_in_add485);
					mul30=mul();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul30.Tree);

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
			TraceOut("add", 10);
			LeaveRule("add", 10);
			Leave_add();
			if (state.backtracking > 0) { Memoize(input, 10, add_StartIndex); }
		}
		DebugLocation(72, 30);
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
	// MathLang.g:73:1: mul : group ( ( MUL | DIV ) group )* ;
	[GrammarRule("mul")]
	private MathLangParser.mul_return mul()
	{
		Enter_mul();
		EnterRule("mul", 11);
		TraceIn("mul", 11);
		MathLangParser.mul_return retval = new MathLangParser.mul_return();
		retval.Start = (IToken)input.LT(1);
		int mul_StartIndex = input.Index;
		object root_0 = null;

		IToken set32=null;
		MathLangParser.group_return group31 = default(MathLangParser.group_return);
		MathLangParser.group_return group33 = default(MathLangParser.group_return);

		object set32_tree=null;

		try { DebugEnterRule(GrammarFileName, "mul");
		DebugLocation(73, 33);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 11)) { return retval; }
			// MathLang.g:73:4: ( group ( ( MUL | DIV ) group )* )
			DebugEnterAlt(1);
			// MathLang.g:73:6: group ( ( MUL | DIV ) group )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(73, 6);
			PushFollow(Follow._group_in_mul494);
			group31=group();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group31.Tree);
			DebugLocation(73, 12);
			// MathLang.g:73:12: ( ( MUL | DIV ) group )*
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
					// MathLang.g:73:14: ( MUL | DIV ) group
					{
					DebugLocation(73, 14);
					set32=(IToken)input.LT(1);
					set32=(IToken)input.LT(1);
					if ((input.LA(1)>=MUL && input.LA(1)<=DIV))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set32), root_0);
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(73, 27);
					PushFollow(Follow._group_in_mul507);
					group33=group();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group33.Tree);

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
			TraceOut("mul", 11);
			LeaveRule("mul", 11);
			Leave_mul();
			if (state.backtracking > 0) { Memoize(input, 11, mul_StartIndex); }
		}
		DebugLocation(73, 33);
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
	// MathLang.g:74:1: compare : add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )? ;
	[GrammarRule("compare")]
	private MathLangParser.compare_return compare()
	{
		Enter_compare();
		EnterRule("compare", 12);
		TraceIn("compare", 12);
		MathLangParser.compare_return retval = new MathLangParser.compare_return();
		retval.Start = (IToken)input.LT(1);
		int compare_StartIndex = input.Index;
		object root_0 = null;

		IToken set35=null;
		MathLangParser.add_return add34 = default(MathLangParser.add_return);
		MathLangParser.add_return add36 = default(MathLangParser.add_return);

		object set35_tree=null;

		try { DebugEnterRule(GrammarFileName, "compare");
		DebugLocation(74, 60);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 12)) { return retval; }
			// MathLang.g:74:8: ( add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )? )
			DebugEnterAlt(1);
			// MathLang.g:74:10: add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(74, 10);
			PushFollow(Follow._add_in_compare515);
			add34=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add34.Tree);
			DebugLocation(74, 14);
			// MathLang.g:74:14: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
			int alt6=2;
			try { DebugEnterSubRule(6);
			try { DebugEnterDecision(6, decisionCanBacktrack[6]);
			int LA6_0 = input.LA(1);

			if (((LA6_0>=NEQ && LA6_0<=EQ)))
			{
				int LA6_1 = input.LA(2);

				if ((EvaluatePredicate(synpred21_MathLang_fragment)))
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
				// MathLang.g:74:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
				{
				DebugLocation(74, 16);
				set35=(IToken)input.LT(1);
				set35=(IToken)input.LT(1);
				if ((input.LA(1)>=GREQ && input.LA(1)<=LS))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set35), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(74, 53);
				PushFollow(Follow._add_in_compare545);
				add36=add();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add36.Tree);

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
			TraceOut("compare", 12);
			LeaveRule("compare", 12);
			Leave_compare();
			if (state.backtracking > 0) { Memoize(input, 12, compare_StartIndex); }
		}
		DebugLocation(74, 60);
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
	// MathLang.g:75:1: term : add ;
	[GrammarRule("term")]
	private MathLangParser.term_return term()
	{
		Enter_term();
		EnterRule("term", 13);
		TraceIn("term", 13);
		MathLangParser.term_return retval = new MathLangParser.term_return();
		retval.Start = (IToken)input.LT(1);
		int term_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.add_return add37 = default(MathLangParser.add_return);


		try { DebugEnterRule(GrammarFileName, "term");
		DebugLocation(75, 9);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 13)) { return retval; }
			// MathLang.g:75:5: ( add )
			DebugEnterAlt(1);
			// MathLang.g:75:7: add
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(75, 7);
			PushFollow(Follow._add_in_term556);
			add37=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add37.Tree);

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
			TraceOut("term", 13);
			LeaveRule("term", 13);
			Leave_term();
			if (state.backtracking > 0) { Memoize(input, 13, term_StartIndex); }
		}
		DebugLocation(75, 9);
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
	// MathLang.g:76:1: group : ( ( SUB )? '(' term ')' | number );
	[GrammarRule("group")]
	private MathLangParser.group_return group()
	{
		Enter_group();
		EnterRule("group", 14);
		TraceIn("group", 14);
		MathLangParser.group_return retval = new MathLangParser.group_return();
		retval.Start = (IToken)input.LT(1);
		int group_StartIndex = input.Index;
		object root_0 = null;

		IToken SUB38=null;
		IToken char_literal39=null;
		IToken char_literal41=null;
		MathLangParser.term_return term40 = default(MathLangParser.term_return);
		MathLangParser.number_return number42 = default(MathLangParser.number_return);

		object SUB38_tree=null;
		object char_literal39_tree=null;
		object char_literal41_tree=null;

		try { DebugEnterRule(GrammarFileName, "group");
		DebugLocation(76, 38);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 14)) { return retval; }
			// MathLang.g:76:6: ( ( SUB )? '(' term ')' | number )
			int alt8=2;
			try { DebugEnterDecision(8, decisionCanBacktrack[8]);
			int LA8_0 = input.LA(1);

			if ((LA8_0==SUB||LA8_0==50))
			{
				alt8=1;
			}
			else if (((LA8_0>=NUMBER && LA8_0<=CHAR)))
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
				// MathLang.g:76:8: ( SUB )? '(' term ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(76, 8);
				// MathLang.g:76:8: ( SUB )?
				int alt7=2;
				try { DebugEnterSubRule(7);
				try { DebugEnterDecision(7, decisionCanBacktrack[7]);
				int LA7_0 = input.LA(1);

				if ((LA7_0==SUB))
				{
					alt7=1;
				}
				} finally { DebugExitDecision(7); }
				switch (alt7)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:76:9: SUB
					{
					DebugLocation(76, 12);
					SUB38=(IToken)Match(input,SUB,Follow._SUB_in_group563); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					SUB38_tree = (object)adaptor.Create(SUB38);
					root_0 = (object)adaptor.BecomeRoot(SUB38_tree, root_0);
					}

					}
					break;

				}
				} finally { DebugExitSubRule(7); }

				DebugLocation(76, 19);
				char_literal39=(IToken)Match(input,50,Follow._50_in_group568); if (state.failed) return retval;
				DebugLocation(76, 21);
				PushFollow(Follow._term_in_group571);
				term40=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term40.Tree);
				DebugLocation(76, 29);
				char_literal41=(IToken)Match(input,51,Follow._51_in_group573); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:76:33: number
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(76, 33);
				PushFollow(Follow._number_in_group578);
				number42=number();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, number42.Tree);

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
			TraceOut("group", 14);
			LeaveRule("group", 14);
			Leave_group();
			if (state.backtracking > 0) { Memoize(input, 14, group_StartIndex); }
		}
		DebugLocation(76, 38);
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
	// MathLang.g:78:1: assignment : assignmentbody ';' ;
	[GrammarRule("assignment")]
	private MathLangParser.assignment_return assignment()
	{
		Enter_assignment();
		EnterRule("assignment", 15);
		TraceIn("assignment", 15);
		MathLangParser.assignment_return retval = new MathLangParser.assignment_return();
		retval.Start = (IToken)input.LT(1);
		int assignment_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal44=null;
		MathLangParser.assignmentbody_return assignmentbody43 = default(MathLangParser.assignmentbody_return);

		object char_literal44_tree=null;

		try { DebugEnterRule(GrammarFileName, "assignment");
		DebugLocation(78, 31);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 15)) { return retval; }
			// MathLang.g:78:11: ( assignmentbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:78:13: assignmentbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(78, 13);
			PushFollow(Follow._assignmentbody_in_assignment585);
			assignmentbody43=assignmentbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentbody43.Tree);
			DebugLocation(78, 31);
			char_literal44=(IToken)Match(input,49,Follow._49_in_assignment587); if (state.failed) return retval;

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
			TraceOut("assignment", 15);
			LeaveRule("assignment", 15);
			Leave_assignment();
			if (state.backtracking > 0) { Memoize(input, 15, assignment_StartIndex); }
		}
		DebugLocation(78, 31);
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
	// MathLang.g:79:1: assignmentbody : ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) ;
	[GrammarRule("assignmentbody")]
	private MathLangParser.assignmentbody_return assignmentbody()
	{
		Enter_assignmentbody();
		EnterRule("assignmentbody", 16);
		TraceIn("assignmentbody", 16);
		MathLangParser.assignmentbody_return retval = new MathLangParser.assignmentbody_return();
		retval.Start = (IToken)input.LT(1);
		int assignmentbody_StartIndex = input.Index;
		object root_0 = null;

		IToken ID45=null;
		IToken ASSIGN46=null;
		MathLangParser.expression_return expression47 = default(MathLangParser.expression_return);

		object ID45_tree=null;
		object ASSIGN46_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "assignmentbody");
		DebugLocation(79, 70);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 16)) { return retval; }
			// MathLang.g:79:15: ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) )
			DebugEnterAlt(1);
			// MathLang.g:79:17: ID ASSIGN expression
			{
			DebugLocation(79, 17);
			ID45=(IToken)Match(input,ID,Follow._ID_in_assignmentbody594); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID45);

			DebugLocation(79, 20);
			ASSIGN46=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignmentbody596); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN46);

			DebugLocation(79, 27);
			PushFollow(Follow._expression_in_assignmentbody598);
			expression47=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression47.Tree);


			{
			// AST REWRITE
			// elements: expression, ID
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 79:38: -> ^( VARASSIGNMENT ID expression )
			{
				DebugLocation(79, 41);
				// MathLang.g:79:41: ^( VARASSIGNMENT ID expression )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(79, 43);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARASSIGNMENT, "VARASSIGNMENT"), root_1);

				DebugLocation(79, 57);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(79, 60);
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
			TraceOut("assignmentbody", 16);
			LeaveRule("assignmentbody", 16);
			Leave_assignmentbody();
			if (state.backtracking > 0) { Memoize(input, 16, assignmentbody_StartIndex); }
		}
		DebugLocation(79, 70);
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
	// MathLang.g:81:1: boolexpression : boolterm ;
	[GrammarRule("boolexpression")]
	private MathLangParser.boolexpression_return boolexpression()
	{
		Enter_boolexpression();
		EnterRule("boolexpression", 17);
		TraceIn("boolexpression", 17);
		MathLangParser.boolexpression_return retval = new MathLangParser.boolexpression_return();
		retval.Start = (IToken)input.LT(1);
		int boolexpression_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.boolterm_return boolterm48 = default(MathLangParser.boolterm_return);


		try { DebugEnterRule(GrammarFileName, "boolexpression");
		DebugLocation(81, 25);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 17)) { return retval; }
			// MathLang.g:81:15: ( boolterm )
			DebugEnterAlt(1);
			// MathLang.g:81:17: boolterm
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(81, 17);
			PushFollow(Follow._boolterm_in_boolexpression615);
			boolterm48=boolterm();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm48.Tree);

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
			TraceOut("boolexpression", 17);
			LeaveRule("boolexpression", 17);
			Leave_boolexpression();
			if (state.backtracking > 0) { Memoize(input, 17, boolexpression_StartIndex); }
		}
		DebugLocation(81, 25);
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
	// MathLang.g:82:1: boolterm : or ( ( EQ | NEQ ) or )? ;
	[GrammarRule("boolterm")]
	private MathLangParser.boolterm_return boolterm()
	{
		Enter_boolterm();
		EnterRule("boolterm", 18);
		TraceIn("boolterm", 18);
		MathLangParser.boolterm_return retval = new MathLangParser.boolterm_return();
		retval.Start = (IToken)input.LT(1);
		int boolterm_StartIndex = input.Index;
		object root_0 = null;

		IToken set50=null;
		MathLangParser.or_return or49 = default(MathLangParser.or_return);
		MathLangParser.or_return or51 = default(MathLangParser.or_return);

		object set50_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolterm");
		DebugLocation(82, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 18)) { return retval; }
			// MathLang.g:82:9: ( or ( ( EQ | NEQ ) or )? )
			DebugEnterAlt(1);
			// MathLang.g:82:11: or ( ( EQ | NEQ ) or )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(82, 11);
			PushFollow(Follow._or_in_boolterm622);
			or49=or();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or49.Tree);
			DebugLocation(82, 14);
			// MathLang.g:82:14: ( ( EQ | NEQ ) or )?
			int alt9=2;
			try { DebugEnterSubRule(9);
			try { DebugEnterDecision(9, decisionCanBacktrack[9]);
			int LA9_0 = input.LA(1);

			if (((LA9_0>=NEQ && LA9_0<=EQ)))
			{
				alt9=1;
			}
			} finally { DebugExitDecision(9); }
			switch (alt9)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:82:16: ( EQ | NEQ ) or
				{
				DebugLocation(82, 16);
				set50=(IToken)input.LT(1);
				set50=(IToken)input.LT(1);
				if ((input.LA(1)>=NEQ && input.LA(1)<=EQ))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set50), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(82, 28);
				PushFollow(Follow._or_in_boolterm635);
				or51=or();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or51.Tree);

				}
				break;

			}
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
			TraceOut("boolterm", 18);
			LeaveRule("boolterm", 18);
			Leave_boolterm();
			if (state.backtracking > 0) { Memoize(input, 18, boolterm_StartIndex); }
		}
		DebugLocation(82, 32);
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
	// MathLang.g:83:1: or : and ( OR and )* ;
	[GrammarRule("or")]
	private MathLangParser.or_return or()
	{
		Enter_or();
		EnterRule("or", 19);
		TraceIn("or", 19);
		MathLangParser.or_return retval = new MathLangParser.or_return();
		retval.Start = (IToken)input.LT(1);
		int or_StartIndex = input.Index;
		object root_0 = null;

		IToken OR53=null;
		MathLangParser.and_return and52 = default(MathLangParser.and_return);
		MathLangParser.and_return and54 = default(MathLangParser.and_return);

		object OR53_tree=null;

		try { DebugEnterRule(GrammarFileName, "or");
		DebugLocation(83, 18);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 19)) { return retval; }
			// MathLang.g:83:3: ( and ( OR and )* )
			DebugEnterAlt(1);
			// MathLang.g:83:5: and ( OR and )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(83, 5);
			PushFollow(Follow._and_in_or644);
			and52=and();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and52.Tree);
			DebugLocation(83, 9);
			// MathLang.g:83:9: ( OR and )*
			try { DebugEnterSubRule(10);
			while (true)
			{
				int alt10=2;
				try { DebugEnterDecision(10, decisionCanBacktrack[10]);
				int LA10_0 = input.LA(1);

				if ((LA10_0==OR))
				{
					alt10=1;
				}


				} finally { DebugExitDecision(10); }
				switch ( alt10 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:83:10: OR and
					{
					DebugLocation(83, 12);
					OR53=(IToken)Match(input,OR,Follow._OR_in_or647); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR53_tree = (object)adaptor.Create(OR53);
					root_0 = (object)adaptor.BecomeRoot(OR53_tree, root_0);
					}
					DebugLocation(83, 14);
					PushFollow(Follow._and_in_or650);
					and54=and();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and54.Tree);

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
			TraceOut("or", 19);
			LeaveRule("or", 19);
			Leave_or();
			if (state.backtracking > 0) { Memoize(input, 19, or_StartIndex); }
		}
		DebugLocation(83, 18);
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
	// MathLang.g:84:1: and : boolgroup ( AND boolgroup )* ;
	[GrammarRule("and")]
	private MathLangParser.and_return and()
	{
		Enter_and();
		EnterRule("and", 20);
		TraceIn("and", 20);
		MathLangParser.and_return retval = new MathLangParser.and_return();
		retval.Start = (IToken)input.LT(1);
		int and_StartIndex = input.Index;
		object root_0 = null;

		IToken AND56=null;
		MathLangParser.boolgroup_return boolgroup55 = default(MathLangParser.boolgroup_return);
		MathLangParser.boolgroup_return boolgroup57 = default(MathLangParser.boolgroup_return);

		object AND56_tree=null;

		try { DebugEnterRule(GrammarFileName, "and");
		DebugLocation(84, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 20)) { return retval; }
			// MathLang.g:84:4: ( boolgroup ( AND boolgroup )* )
			DebugEnterAlt(1);
			// MathLang.g:84:6: boolgroup ( AND boolgroup )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(84, 6);
			PushFollow(Follow._boolgroup_in_and658);
			boolgroup55=boolgroup();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup55.Tree);
			DebugLocation(84, 16);
			// MathLang.g:84:16: ( AND boolgroup )*
			try { DebugEnterSubRule(11);
			while (true)
			{
				int alt11=2;
				try { DebugEnterDecision(11, decisionCanBacktrack[11]);
				int LA11_0 = input.LA(1);

				if ((LA11_0==AND))
				{
					alt11=1;
				}


				} finally { DebugExitDecision(11); }
				switch ( alt11 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:84:17: AND boolgroup
					{
					DebugLocation(84, 20);
					AND56=(IToken)Match(input,AND,Follow._AND_in_and661); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND56_tree = (object)adaptor.Create(AND56);
					root_0 = (object)adaptor.BecomeRoot(AND56_tree, root_0);
					}
					DebugLocation(84, 22);
					PushFollow(Follow._boolgroup_in_and664);
					boolgroup57=boolgroup();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup57.Tree);

					}
					break;

				default:
					goto loop11;
				}
			}

			loop11:
				;

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
			TraceOut("and", 20);
			LeaveRule("and", 20);
			Leave_and();
			if (state.backtracking > 0) { Memoize(input, 20, and_StartIndex); }
		}
		DebugLocation(84, 32);
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
	// MathLang.g:85:1: boolgroup : ( NOT )? ( '(' boolterm ')' | boolvar ) ;
	[GrammarRule("boolgroup")]
	private MathLangParser.boolgroup_return boolgroup()
	{
		Enter_boolgroup();
		EnterRule("boolgroup", 21);
		TraceIn("boolgroup", 21);
		MathLangParser.boolgroup_return retval = new MathLangParser.boolgroup_return();
		retval.Start = (IToken)input.LT(1);
		int boolgroup_StartIndex = input.Index;
		object root_0 = null;

		IToken NOT58=null;
		IToken char_literal59=null;
		IToken char_literal61=null;
		MathLangParser.boolterm_return boolterm60 = default(MathLangParser.boolterm_return);
		MathLangParser.boolvar_return boolvar62 = default(MathLangParser.boolvar_return);

		object NOT58_tree=null;
		object char_literal59_tree=null;
		object char_literal61_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolgroup");
		DebugLocation(85, 51);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 21)) { return retval; }
			// MathLang.g:85:10: ( ( NOT )? ( '(' boolterm ')' | boolvar ) )
			DebugEnterAlt(1);
			// MathLang.g:85:12: ( NOT )? ( '(' boolterm ')' | boolvar )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(85, 12);
			// MathLang.g:85:12: ( NOT )?
			int alt12=2;
			try { DebugEnterSubRule(12);
			try { DebugEnterDecision(12, decisionCanBacktrack[12]);
			int LA12_0 = input.LA(1);

			if ((LA12_0==NOT))
			{
				alt12=1;
			}
			} finally { DebugExitDecision(12); }
			switch (alt12)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:85:13: NOT
				{
				DebugLocation(85, 16);
				NOT58=(IToken)Match(input,NOT,Follow._NOT_in_boolgroup673); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				NOT58_tree = (object)adaptor.Create(NOT58);
				root_0 = (object)adaptor.BecomeRoot(NOT58_tree, root_0);
				}

				}
				break;

			}
			} finally { DebugExitSubRule(12); }

			DebugLocation(85, 20);
			// MathLang.g:85:20: ( '(' boolterm ')' | boolvar )
			int alt13=2;
			try { DebugEnterSubRule(13);
			try { DebugEnterDecision(13, decisionCanBacktrack[13]);
			int LA13_0 = input.LA(1);

			if ((LA13_0==50))
			{
				int LA13_1 = input.LA(2);

				if ((EvaluatePredicate(synpred29_MathLang_fragment)))
				{
					alt13=1;
				}
				else if ((true))
				{
					alt13=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 13, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else if (((LA13_0>=NUMBER && LA13_0<=CHAR)||LA13_0==SUB||(LA13_0>=TRUE && LA13_0<=FALSE)))
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
				// MathLang.g:85:22: '(' boolterm ')'
				{
				DebugLocation(85, 25);
				char_literal59=(IToken)Match(input,50,Follow._50_in_boolgroup680); if (state.failed) return retval;
				DebugLocation(85, 27);
				PushFollow(Follow._boolterm_in_boolgroup683);
				boolterm60=boolterm();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm60.Tree);
				DebugLocation(85, 39);
				char_literal61=(IToken)Match(input,51,Follow._51_in_boolgroup685); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:85:43: boolvar
				{
				DebugLocation(85, 43);
				PushFollow(Follow._boolvar_in_boolgroup690);
				boolvar62=boolvar();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolvar62.Tree);

				}
				break;

			}
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
			TraceOut("boolgroup", 21);
			LeaveRule("boolgroup", 21);
			Leave_boolgroup();
			if (state.backtracking > 0) { Memoize(input, 21, boolgroup_StartIndex); }
		}
		DebugLocation(85, 51);
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
	// MathLang.g:86:1: boolvar : ( TRUE | FALSE | compare );
	[GrammarRule("boolvar")]
	private MathLangParser.boolvar_return boolvar()
	{
		Enter_boolvar();
		EnterRule("boolvar", 22);
		TraceIn("boolvar", 22);
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
		DebugLocation(86, 11);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 22)) { return retval; }
			// MathLang.g:86:8: ( TRUE | FALSE | compare )
			int alt14=3;
			try { DebugEnterDecision(14, decisionCanBacktrack[14]);
			switch (input.LA(1))
			{
			case TRUE:
				{
				alt14=1;
				}
				break;
			case FALSE:
				{
				alt14=2;
				}
				break;
			case NUMBER:
			case ID:
			case CHAR:
			case SUB:
			case 50:
				{
				alt14=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 14, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(14); }
			switch (alt14)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:86:10: TRUE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(86, 10);
				TRUE63=(IToken)Match(input,TRUE,Follow._TRUE_in_boolvar698); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				TRUE63_tree = (object)adaptor.Create(TRUE63);
				adaptor.AddChild(root_0, TRUE63_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:87:5: FALSE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(87, 5);
				FALSE64=(IToken)Match(input,FALSE,Follow._FALSE_in_boolvar704); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				FALSE64_tree = (object)adaptor.Create(FALSE64);
				adaptor.AddChild(root_0, FALSE64_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:88:5: compare
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(88, 5);
				PushFollow(Follow._compare_in_boolvar710);
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
			TraceOut("boolvar", 22);
			LeaveRule("boolvar", 22);
			Leave_boolvar();
			if (state.backtracking > 0) { Memoize(input, 22, boolvar_StartIndex); }
		}
		DebugLocation(88, 11);
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
	// MathLang.g:90:1: ifstatement : IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )* ;
	[GrammarRule("ifstatement")]
	private MathLangParser.ifstatement_return ifstatement()
	{
		Enter_ifstatement();
		EnterRule("ifstatement", 23);
		TraceIn("ifstatement", 23);
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
		DebugLocation(90, 91);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 23)) { return retval; }
			// MathLang.g:90:12: ( IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )* )
			DebugEnterAlt(1);
			// MathLang.g:90:14: IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(90, 16);
			IF66=(IToken)Match(input,IF,Follow._IF_in_ifstatement717); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			IF66_tree = (object)adaptor.Create(IF66);
			root_0 = (object)adaptor.BecomeRoot(IF66_tree, root_0);
			}
			DebugLocation(90, 21);
			char_literal67=(IToken)Match(input,50,Follow._50_in_ifstatement720); if (state.failed) return retval;
			DebugLocation(90, 23);
			PushFollow(Follow._boolexpression_in_ifstatement723);
			boolexpression68=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression68.Tree);
			DebugLocation(90, 41);
			char_literal69=(IToken)Match(input,51,Follow._51_in_ifstatement725); if (state.failed) return retval;
			DebugLocation(90, 43);
			// MathLang.g:90:43: ( block | statement )
			int alt15=2;
			try { DebugEnterSubRule(15);
			try { DebugEnterDecision(15, decisionCanBacktrack[15]);
			int LA15_0 = input.LA(1);

			if ((LA15_0==53))
			{
				alt15=1;
			}
			else if ((LA15_0==IF||LA15_0==FOR||(LA15_0>=RETURN && LA15_0<=WHILE)||LA15_0==ID||LA15_0==TYPE))
			{
				alt15=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 15, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(15); }
			switch (alt15)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:90:44: block
				{
				DebugLocation(90, 44);
				PushFollow(Follow._block_in_ifstatement729);
				block70=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block70.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:90:52: statement
				{
				DebugLocation(90, 52);
				PushFollow(Follow._statement_in_ifstatement733);
				statement71=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement71.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(15); }

			DebugLocation(90, 63);
			// MathLang.g:90:63: ( ELSE ( block | statement ) )*
			try { DebugEnterSubRule(17);
			while (true)
			{
				int alt17=2;
				try { DebugEnterDecision(17, decisionCanBacktrack[17]);
				int LA17_0 = input.LA(1);

				if ((LA17_0==ELSE))
				{
					int LA17_1 = input.LA(2);

					if ((EvaluatePredicate(synpred34_MathLang_fragment)))
					{
						alt17=1;
					}


				}


				} finally { DebugExitDecision(17); }
				switch ( alt17 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:90:64: ELSE ( block | statement )
					{
					DebugLocation(90, 68);
					ELSE72=(IToken)Match(input,ELSE,Follow._ELSE_in_ifstatement737); if (state.failed) return retval;
					DebugLocation(90, 70);
					// MathLang.g:90:70: ( block | statement )
					int alt16=2;
					try { DebugEnterSubRule(16);
					try { DebugEnterDecision(16, decisionCanBacktrack[16]);
					int LA16_0 = input.LA(1);

					if ((LA16_0==53))
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
						// MathLang.g:90:71: block
						{
						DebugLocation(90, 71);
						PushFollow(Follow._block_in_ifstatement741);
						block73=block();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block73.Tree);

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// MathLang.g:90:79: statement
						{
						DebugLocation(90, 79);
						PushFollow(Follow._statement_in_ifstatement745);
						statement74=statement();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement74.Tree);

						}
						break;

					}
					} finally { DebugExitSubRule(16); }


					}
					break;

				default:
					goto loop17;
				}
			}

			loop17:
				;

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
			TraceOut("ifstatement", 23);
			LeaveRule("ifstatement", 23);
			Leave_ifstatement();
			if (state.backtracking > 0) { Memoize(input, 23, ifstatement_StartIndex); }
		}
		DebugLocation(90, 91);
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
	// MathLang.g:91:1: whilestatement : WHILE '(' boolexpression ')' ( block | statement ) ;
	[GrammarRule("whilestatement")]
	private MathLangParser.whilestatement_return whilestatement()
	{
		Enter_whilestatement();
		EnterRule("whilestatement", 24);
		TraceIn("whilestatement", 24);
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
		DebugLocation(91, 67);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 24)) { return retval; }
			// MathLang.g:91:15: ( WHILE '(' boolexpression ')' ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:91:17: WHILE '(' boolexpression ')' ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(91, 22);
			WHILE75=(IToken)Match(input,WHILE,Follow._WHILE_in_whilestatement755); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			WHILE75_tree = (object)adaptor.Create(WHILE75);
			root_0 = (object)adaptor.BecomeRoot(WHILE75_tree, root_0);
			}
			DebugLocation(91, 27);
			char_literal76=(IToken)Match(input,50,Follow._50_in_whilestatement758); if (state.failed) return retval;
			DebugLocation(91, 29);
			PushFollow(Follow._boolexpression_in_whilestatement761);
			boolexpression77=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression77.Tree);
			DebugLocation(91, 47);
			char_literal78=(IToken)Match(input,51,Follow._51_in_whilestatement763); if (state.failed) return retval;
			DebugLocation(91, 49);
			// MathLang.g:91:49: ( block | statement )
			int alt18=2;
			try { DebugEnterSubRule(18);
			try { DebugEnterDecision(18, decisionCanBacktrack[18]);
			int LA18_0 = input.LA(1);

			if ((LA18_0==53))
			{
				alt18=1;
			}
			else if ((LA18_0==IF||LA18_0==FOR||(LA18_0>=RETURN && LA18_0<=WHILE)||LA18_0==ID||LA18_0==TYPE))
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
				// MathLang.g:91:50: block
				{
				DebugLocation(91, 50);
				PushFollow(Follow._block_in_whilestatement767);
				block79=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block79.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:91:58: statement
				{
				DebugLocation(91, 58);
				PushFollow(Follow._statement_in_whilestatement771);
				statement80=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement80.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(18); }


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
			TraceOut("whilestatement", 24);
			LeaveRule("whilestatement", 24);
			Leave_whilestatement();
			if (state.backtracking > 0) { Memoize(input, 24, whilestatement_StartIndex); }
		}
		DebugLocation(91, 67);
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
	// MathLang.g:92:1: forstatement : FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement ) ;
	[GrammarRule("forstatement")]
	private MathLangParser.forstatement_return forstatement()
	{
		Enter_forstatement();
		EnterRule("forstatement", 25);
		TraceIn("forstatement", 25);
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
		DebugLocation(92, 108);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 25)) { return retval; }
			// MathLang.g:92:13: ( FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:92:15: FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(92, 18);
			FOR81=(IToken)Match(input,FOR,Follow._FOR_in_forstatement778); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			FOR81_tree = (object)adaptor.Create(FOR81);
			root_0 = (object)adaptor.BecomeRoot(FOR81_tree, root_0);
			}
			DebugLocation(92, 23);
			char_literal82=(IToken)Match(input,50,Follow._50_in_forstatement781); if (state.failed) return retval;
			DebugLocation(92, 25);
			PushFollow(Follow._longdeclarationbody_in_forstatement784);
			longdeclarationbody83=longdeclarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclarationbody83.Tree);
			DebugLocation(92, 48);
			char_literal84=(IToken)Match(input,49,Follow._49_in_forstatement786); if (state.failed) return retval;
			DebugLocation(92, 50);
			PushFollow(Follow._boolexpression_in_forstatement789);
			boolexpression85=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression85.Tree);
			DebugLocation(92, 68);
			char_literal86=(IToken)Match(input,49,Follow._49_in_forstatement791); if (state.failed) return retval;
			DebugLocation(92, 70);
			PushFollow(Follow._assignmentbody_in_forstatement794);
			assignmentbody87=assignmentbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentbody87.Tree);
			DebugLocation(92, 88);
			char_literal88=(IToken)Match(input,51,Follow._51_in_forstatement796); if (state.failed) return retval;
			DebugLocation(92, 90);
			// MathLang.g:92:90: ( block | statement )
			int alt19=2;
			try { DebugEnterSubRule(19);
			try { DebugEnterDecision(19, decisionCanBacktrack[19]);
			int LA19_0 = input.LA(1);

			if ((LA19_0==53))
			{
				alt19=1;
			}
			else if ((LA19_0==IF||LA19_0==FOR||(LA19_0>=RETURN && LA19_0<=WHILE)||LA19_0==ID||LA19_0==TYPE))
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
				// MathLang.g:92:91: block
				{
				DebugLocation(92, 91);
				PushFollow(Follow._block_in_forstatement800);
				block89=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block89.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:92:99: statement
				{
				DebugLocation(92, 99);
				PushFollow(Follow._statement_in_forstatement804);
				statement90=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement90.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(19); }


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
			TraceOut("forstatement", 25);
			LeaveRule("forstatement", 25);
			Leave_forstatement();
			if (state.backtracking > 0) { Memoize(input, 25, forstatement_StartIndex); }
		}
		DebugLocation(92, 108);
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
	// MathLang.g:93:1: returnstatement : RETURN expression ';' ;
	[GrammarRule("returnstatement")]
	private MathLangParser.returnstatement_return returnstatement()
	{
		Enter_returnstatement();
		EnterRule("returnstatement", 26);
		TraceIn("returnstatement", 26);
		MathLangParser.returnstatement_return retval = new MathLangParser.returnstatement_return();
		retval.Start = (IToken)input.LT(1);
		int returnstatement_StartIndex = input.Index;
		object root_0 = null;

		IToken RETURN91=null;
		IToken char_literal93=null;
		MathLangParser.expression_return expression92 = default(MathLangParser.expression_return);

		object RETURN91_tree=null;
		object char_literal93_tree=null;

		try { DebugEnterRule(GrammarFileName, "returnstatement");
		DebugLocation(93, 41);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 26)) { return retval; }
			// MathLang.g:93:16: ( RETURN expression ';' )
			DebugEnterAlt(1);
			// MathLang.g:93:18: RETURN expression ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(93, 24);
			RETURN91=(IToken)Match(input,RETURN,Follow._RETURN_in_returnstatement811); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			RETURN91_tree = (object)adaptor.Create(RETURN91);
			root_0 = (object)adaptor.BecomeRoot(RETURN91_tree, root_0);
			}
			DebugLocation(93, 26);
			PushFollow(Follow._expression_in_returnstatement814);
			expression92=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression92.Tree);
			DebugLocation(93, 40);
			char_literal93=(IToken)Match(input,49,Follow._49_in_returnstatement816); if (state.failed) return retval;

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
			TraceOut("returnstatement", 26);
			LeaveRule("returnstatement", 26);
			Leave_returnstatement();
			if (state.backtracking > 0) { Memoize(input, 26, returnstatement_StartIndex); }
		}
		DebugLocation(93, 41);
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
	// MathLang.g:95:1: funcdeclaration : TYPE ID '(' ( paramsdeclaration )? ')' block -> ^( FUNCDECLARATION ID ^( RETURNS TYPE ) ( paramsdeclaration )? block ) ;
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

		IToken TYPE94=null;
		IToken ID95=null;
		IToken char_literal96=null;
		IToken char_literal98=null;
		MathLangParser.paramsdeclaration_return paramsdeclaration97 = default(MathLangParser.paramsdeclaration_return);
		MathLangParser.block_return block99 = default(MathLangParser.block_return);

		object TYPE94_tree=null;
		object ID95_tree=null;
		object char_literal96_tree=null;
		object char_literal98_tree=null;
		RewriteRuleITokenStream stream_51=new RewriteRuleITokenStream(adaptor,"token 51");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");
		RewriteRuleITokenStream stream_50=new RewriteRuleITokenStream(adaptor,"token 50");
		RewriteRuleSubtreeStream stream_paramsdeclaration=new RewriteRuleSubtreeStream(adaptor,"rule paramsdeclaration");
		RewriteRuleSubtreeStream stream_block=new RewriteRuleSubtreeStream(adaptor,"rule block");
		try { DebugEnterRule(GrammarFileName, "funcdeclaration");
		DebugLocation(95, 136);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 27)) { return retval; }
			// MathLang.g:95:16: ( TYPE ID '(' ( paramsdeclaration )? ')' block -> ^( FUNCDECLARATION ID ^( RETURNS TYPE ) ( paramsdeclaration )? block ) )
			DebugEnterAlt(1);
			// MathLang.g:95:18: TYPE ID '(' ( paramsdeclaration )? ')' block
			{
			DebugLocation(95, 18);
			TYPE94=(IToken)Match(input,TYPE,Follow._TYPE_in_funcdeclaration825); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE94);

			DebugLocation(95, 25);
			ID95=(IToken)Match(input,ID,Follow._ID_in_funcdeclaration827); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID95);

			DebugLocation(95, 30);
			char_literal96=(IToken)Match(input,50,Follow._50_in_funcdeclaration830); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_50.Add(char_literal96);

			DebugLocation(95, 32);
			// MathLang.g:95:32: ( paramsdeclaration )?
			int alt20=2;
			try { DebugEnterSubRule(20);
			try { DebugEnterDecision(20, decisionCanBacktrack[20]);
			int LA20_0 = input.LA(1);

			if ((LA20_0==TYPE))
			{
				alt20=1;
			}
			} finally { DebugExitDecision(20); }
			switch (alt20)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: paramsdeclaration
				{
				DebugLocation(95, 32);
				PushFollow(Follow._paramsdeclaration_in_funcdeclaration833);
				paramsdeclaration97=paramsdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_paramsdeclaration.Add(paramsdeclaration97.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(20); }

			DebugLocation(95, 54);
			char_literal98=(IToken)Match(input,51,Follow._51_in_funcdeclaration836); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_51.Add(char_literal98);

			DebugLocation(95, 56);
			PushFollow(Follow._block_in_funcdeclaration839);
			block99=block();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_block.Add(block99.Tree);


			{
			// AST REWRITE
			// elements: paramsdeclaration, block, ID, TYPE
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 95:62: -> ^( FUNCDECLARATION ID ^( RETURNS TYPE ) ( paramsdeclaration )? block )
			{
				DebugLocation(95, 65);
				// MathLang.g:95:65: ^( FUNCDECLARATION ID ^( RETURNS TYPE ) ( paramsdeclaration )? block )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(95, 67);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNCDECLARATION, "FUNCDECLARATION"), root_1);

				DebugLocation(95, 83);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(95, 86);
				// MathLang.g:95:86: ^( RETURNS TYPE )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(95, 88);
				root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(RETURNS, "RETURNS"), root_2);

				DebugLocation(95, 96);
				adaptor.AddChild(root_2, stream_TYPE.NextNode());

				adaptor.AddChild(root_1, root_2);
				}
				DebugLocation(95, 107);
				// MathLang.g:95:107: ( paramsdeclaration )?
				if ( stream_paramsdeclaration.HasNext )
				{
					DebugLocation(95, 107);
					adaptor.AddChild(root_1, stream_paramsdeclaration.NextTree());

				}
				stream_paramsdeclaration.Reset();
				DebugLocation(95, 131);
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
			TraceOut("funcdeclaration", 27);
			LeaveRule("funcdeclaration", 27);
			Leave_funcdeclaration();
			if (state.backtracking > 0) { Memoize(input, 27, funcdeclaration_StartIndex); }
		}
		DebugLocation(95, 136);
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
	// MathLang.g:96:1: paramsdeclaration : ( declarationbody ( ',' declarationbody )* ) -> ^( PARAMETERS ( declarationbody )* ) ;
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

		IToken char_literal101=null;
		MathLangParser.declarationbody_return declarationbody100 = default(MathLangParser.declarationbody_return);
		MathLangParser.declarationbody_return declarationbody102 = default(MathLangParser.declarationbody_return);

		object char_literal101_tree=null;
		RewriteRuleITokenStream stream_52=new RewriteRuleITokenStream(adaptor,"token 52");
		RewriteRuleSubtreeStream stream_declarationbody=new RewriteRuleSubtreeStream(adaptor,"rule declarationbody");
		try { DebugEnterRule(GrammarFileName, "paramsdeclaration");
		DebugLocation(96, 102);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 28)) { return retval; }
			// MathLang.g:96:18: ( ( declarationbody ( ',' declarationbody )* ) -> ^( PARAMETERS ( declarationbody )* ) )
			DebugEnterAlt(1);
			// MathLang.g:96:20: ( declarationbody ( ',' declarationbody )* )
			{
			DebugLocation(96, 20);
			// MathLang.g:96:20: ( declarationbody ( ',' declarationbody )* )
			DebugEnterAlt(1);
			// MathLang.g:96:22: declarationbody ( ',' declarationbody )*
			{
			DebugLocation(96, 22);
			PushFollow(Follow._declarationbody_in_paramsdeclaration872);
			declarationbody100=declarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declarationbody.Add(declarationbody100.Tree);
			DebugLocation(96, 38);
			// MathLang.g:96:38: ( ',' declarationbody )*
			try { DebugEnterSubRule(21);
			while (true)
			{
				int alt21=2;
				try { DebugEnterDecision(21, decisionCanBacktrack[21]);
				int LA21_0 = input.LA(1);

				if ((LA21_0==52))
				{
					alt21=1;
				}


				} finally { DebugExitDecision(21); }
				switch ( alt21 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:96:40: ',' declarationbody
					{
					DebugLocation(96, 43);
					char_literal101=(IToken)Match(input,52,Follow._52_in_paramsdeclaration876); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_52.Add(char_literal101);

					DebugLocation(96, 45);
					PushFollow(Follow._declarationbody_in_paramsdeclaration879);
					declarationbody102=declarationbody();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_declarationbody.Add(declarationbody102.Tree);

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
			// 96:66: -> ^( PARAMETERS ( declarationbody )* )
			{
				DebugLocation(96, 69);
				// MathLang.g:96:69: ^( PARAMETERS ( declarationbody )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(96, 71);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_1);

				DebugLocation(96, 82);
				// MathLang.g:96:82: ( declarationbody )*
				while ( stream_declarationbody.HasNext )
				{
					DebugLocation(96, 84);
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
		DebugLocation(96, 102);
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
	// MathLang.g:98:1: funccallbody : ID '(' ( expressioncommalist )? ')' ;
	[GrammarRule("funccallbody")]
	private MathLangParser.funccallbody_return funccallbody()
	{
		Enter_funccallbody();
		EnterRule("funccallbody", 29);
		TraceIn("funccallbody", 29);
		MathLangParser.funccallbody_return retval = new MathLangParser.funccallbody_return();
		retval.Start = (IToken)input.LT(1);
		int funccallbody_StartIndex = input.Index;
		object root_0 = null;

		IToken ID103=null;
		IToken char_literal104=null;
		IToken char_literal106=null;
		MathLangParser.expressioncommalist_return expressioncommalist105 = default(MathLangParser.expressioncommalist_return);

		object ID103_tree=null;
		object char_literal104_tree=null;
		object char_literal106_tree=null;

		try { DebugEnterRule(GrammarFileName, "funccallbody");
		DebugLocation(98, 46);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 29)) { return retval; }
			// MathLang.g:98:13: ( ID '(' ( expressioncommalist )? ')' )
			DebugEnterAlt(1);
			// MathLang.g:98:15: ID '(' ( expressioncommalist )? ')'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(98, 17);
			ID103=(IToken)Match(input,ID,Follow._ID_in_funccallbody904); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			ID103_tree = (object)adaptor.Create(ID103);
			root_0 = (object)adaptor.BecomeRoot(ID103_tree, root_0);
			}
			DebugLocation(98, 19);
			char_literal104=(IToken)Match(input,50,Follow._50_in_funccallbody907); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal104_tree = (object)adaptor.Create(char_literal104);
			adaptor.AddChild(root_0, char_literal104_tree);
			}
			DebugLocation(98, 23);
			// MathLang.g:98:23: ( expressioncommalist )?
			int alt22=2;
			try { DebugEnterSubRule(22);
			try { DebugEnterDecision(22, decisionCanBacktrack[22]);
			int LA22_0 = input.LA(1);

			if ((LA22_0==KNEW))
			{
				alt22=1;
			}
			} finally { DebugExitDecision(22); }
			switch (alt22)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: expressioncommalist
				{
				DebugLocation(98, 23);
				PushFollow(Follow._expressioncommalist_in_funccallbody909);
				expressioncommalist105=expressioncommalist();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expressioncommalist105.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(22); }

			DebugLocation(98, 44);
			char_literal106=(IToken)Match(input,51,Follow._51_in_funccallbody912); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal106_tree = (object)adaptor.Create(char_literal106);
			adaptor.AddChild(root_0, char_literal106_tree);
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
			TraceOut("funccallbody", 29);
			LeaveRule("funccallbody", 29);
			Leave_funccallbody();
			if (state.backtracking > 0) { Memoize(input, 29, funccallbody_StartIndex); }
		}
		DebugLocation(98, 46);
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
	// MathLang.g:99:1: funccall : funccallbody ';' ;
	[GrammarRule("funccall")]
	private MathLangParser.funccall_return funccall()
	{
		Enter_funccall();
		EnterRule("funccall", 30);
		TraceIn("funccall", 30);
		MathLangParser.funccall_return retval = new MathLangParser.funccall_return();
		retval.Start = (IToken)input.LT(1);
		int funccall_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal108=null;
		MathLangParser.funccallbody_return funccallbody107 = default(MathLangParser.funccallbody_return);

		object char_literal108_tree=null;

		try { DebugEnterRule(GrammarFileName, "funccall");
		DebugLocation(99, 27);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 30)) { return retval; }
			// MathLang.g:99:9: ( funccallbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:99:11: funccallbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(99, 11);
			PushFollow(Follow._funccallbody_in_funccall918);
			funccallbody107=funccallbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody107.Tree);
			DebugLocation(99, 27);
			char_literal108=(IToken)Match(input,49,Follow._49_in_funccall920); if (state.failed) return retval;

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
			TraceOut("funccall", 30);
			LeaveRule("funccall", 30);
			Leave_funccall();
			if (state.backtracking > 0) { Memoize(input, 30, funccall_StartIndex); }
		}
		DebugLocation(99, 27);
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
	// MathLang.g:100:1: expressioncommalist : expression ( ',' expression )* -> ^( PARAMETERS ( expression )* ) ;
	[GrammarRule("expressioncommalist")]
	private MathLangParser.expressioncommalist_return expressioncommalist()
	{
		Enter_expressioncommalist();
		EnterRule("expressioncommalist", 31);
		TraceIn("expressioncommalist", 31);
		MathLangParser.expressioncommalist_return retval = new MathLangParser.expressioncommalist_return();
		retval.Start = (IToken)input.LT(1);
		int expressioncommalist_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal110=null;
		MathLangParser.expression_return expression109 = default(MathLangParser.expression_return);
		MathLangParser.expression_return expression111 = default(MathLangParser.expression_return);

		object char_literal110_tree=null;
		RewriteRuleITokenStream stream_52=new RewriteRuleITokenStream(adaptor,"token 52");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "expressioncommalist");
		DebugLocation(100, 83);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 31)) { return retval; }
			// MathLang.g:100:20: ( expression ( ',' expression )* -> ^( PARAMETERS ( expression )* ) )
			DebugEnterAlt(1);
			// MathLang.g:100:22: expression ( ',' expression )*
			{
			DebugLocation(100, 22);
			PushFollow(Follow._expression_in_expressioncommalist927);
			expression109=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression109.Tree);
			DebugLocation(100, 33);
			// MathLang.g:100:33: ( ',' expression )*
			try { DebugEnterSubRule(23);
			while (true)
			{
				int alt23=2;
				try { DebugEnterDecision(23, decisionCanBacktrack[23]);
				int LA23_0 = input.LA(1);

				if ((LA23_0==52))
				{
					alt23=1;
				}


				} finally { DebugExitDecision(23); }
				switch ( alt23 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:100:35: ',' expression
					{
					DebugLocation(100, 38);
					char_literal110=(IToken)Match(input,52,Follow._52_in_expressioncommalist931); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_52.Add(char_literal110);

					DebugLocation(100, 40);
					PushFollow(Follow._expression_in_expressioncommalist934);
					expression111=expression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_expression.Add(expression111.Tree);

					}
					break;

				default:
					goto loop23;
				}
			}

			loop23:
				;

			} finally { DebugExitSubRule(23); }



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
			// 100:53: -> ^( PARAMETERS ( expression )* )
			{
				DebugLocation(100, 56);
				// MathLang.g:100:56: ^( PARAMETERS ( expression )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(100, 58);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_1);

				DebugLocation(100, 69);
				// MathLang.g:100:69: ( expression )*
				while ( stream_expression.HasNext )
				{
					DebugLocation(100, 70);
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
			TraceOut("expressioncommalist", 31);
			LeaveRule("expressioncommalist", 31);
			Leave_expressioncommalist();
			if (state.backtracking > 0) { Memoize(input, 31, expressioncommalist_StartIndex); }
		}
		DebugLocation(100, 83);
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
	// MathLang.g:103:1: newexpression : KNEW TYPE0 SQRBL NUMBER SQRBR ;
	[GrammarRule("newexpression")]
	private MathLangParser.newexpression_return newexpression()
	{
		Enter_newexpression();
		EnterRule("newexpression", 32);
		TraceIn("newexpression", 32);
		MathLangParser.newexpression_return retval = new MathLangParser.newexpression_return();
		retval.Start = (IToken)input.LT(1);
		int newexpression_StartIndex = input.Index;
		object root_0 = null;

		IToken KNEW112=null;
		IToken TYPE0113=null;
		IToken SQRBL114=null;
		IToken NUMBER115=null;
		IToken SQRBR116=null;

		object KNEW112_tree=null;
		object TYPE0113_tree=null;
		object SQRBL114_tree=null;
		object NUMBER115_tree=null;
		object SQRBR116_tree=null;

		try { DebugEnterRule(GrammarFileName, "newexpression");
		DebugLocation(103, 47);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 32)) { return retval; }
			// MathLang.g:103:14: ( KNEW TYPE0 SQRBL NUMBER SQRBR )
			DebugEnterAlt(1);
			// MathLang.g:103:16: KNEW TYPE0 SQRBL NUMBER SQRBR
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(103, 16);
			KNEW112=(IToken)Match(input,KNEW,Follow._KNEW_in_newexpression957); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			KNEW112_tree = (object)adaptor.Create(KNEW112);
			adaptor.AddChild(root_0, KNEW112_tree);
			}
			DebugLocation(103, 21);
			TYPE0113=(IToken)Match(input,TYPE0,Follow._TYPE0_in_newexpression959); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			TYPE0113_tree = (object)adaptor.Create(TYPE0113);
			adaptor.AddChild(root_0, TYPE0113_tree);
			}
			DebugLocation(103, 32);
			SQRBL114=(IToken)Match(input,SQRBL,Follow._SQRBL_in_newexpression961); if (state.failed) return retval;
			DebugLocation(103, 34);
			NUMBER115=(IToken)Match(input,NUMBER,Follow._NUMBER_in_newexpression964); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			NUMBER115_tree = (object)adaptor.Create(NUMBER115);
			adaptor.AddChild(root_0, NUMBER115_tree);
			}
			DebugLocation(103, 46);
			SQRBR116=(IToken)Match(input,SQRBR,Follow._SQRBR_in_newexpression966); if (state.failed) return retval;

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
			TraceOut("newexpression", 32);
			LeaveRule("newexpression", 32);
			Leave_newexpression();
			if (state.backtracking > 0) { Memoize(input, 32, newexpression_StartIndex); }
		}
		DebugLocation(103, 47);
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
	// MathLang.g:105:1: block : '{' statementlist '}' ;
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

		IToken char_literal117=null;
		IToken char_literal119=null;
		MathLangParser.statementlist_return statementlist118 = default(MathLangParser.statementlist_return);

		object char_literal117_tree=null;
		object char_literal119_tree=null;

		try { DebugEnterRule(GrammarFileName, "block");
		DebugLocation(105, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 33)) { return retval; }
			// MathLang.g:105:6: ( '{' statementlist '}' )
			DebugEnterAlt(1);
			// MathLang.g:105:8: '{' statementlist '}'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(105, 11);
			char_literal117=(IToken)Match(input,53,Follow._53_in_block976); if (state.failed) return retval;
			DebugLocation(105, 13);
			PushFollow(Follow._statementlist_in_block979);
			statementlist118=statementlist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementlist118.Tree);
			DebugLocation(105, 30);
			char_literal119=(IToken)Match(input,54,Follow._54_in_block981); if (state.failed) return retval;

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
		DebugLocation(105, 30);
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
	// MathLang.g:107:1: statementlist : ( statement )* -> ^( BLOCK ( statement )* ) ;
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

		MathLangParser.statement_return statement120 = default(MathLangParser.statement_return);

		RewriteRuleSubtreeStream stream_statement=new RewriteRuleSubtreeStream(adaptor,"rule statement");
		try { DebugEnterRule(GrammarFileName, "statementlist");
		DebugLocation(107, 49);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 34)) { return retval; }
			// MathLang.g:107:14: ( ( statement )* -> ^( BLOCK ( statement )* ) )
			DebugEnterAlt(1);
			// MathLang.g:107:16: ( statement )*
			{
			DebugLocation(107, 16);
			// MathLang.g:107:16: ( statement )*
			try { DebugEnterSubRule(24);
			while (true)
			{
				int alt24=2;
				try { DebugEnterDecision(24, decisionCanBacktrack[24]);
				int LA24_0 = input.LA(1);

				if ((LA24_0==IF||LA24_0==FOR||(LA24_0>=RETURN && LA24_0<=WHILE)||LA24_0==ID||LA24_0==TYPE))
				{
					alt24=1;
				}


				} finally { DebugExitDecision(24); }
				switch ( alt24 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: statement
					{
					DebugLocation(107, 16);
					PushFollow(Follow._statement_in_statementlist989);
					statement120=statement();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_statement.Add(statement120.Tree);

					}
					break;

				default:
					goto loop24;
				}
			}

			loop24:
				;

			} finally { DebugExitSubRule(24); }



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
			// 107:27: -> ^( BLOCK ( statement )* )
			{
				DebugLocation(107, 30);
				// MathLang.g:107:30: ^( BLOCK ( statement )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(107, 32);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

				DebugLocation(107, 38);
				// MathLang.g:107:38: ( statement )*
				while ( stream_statement.HasNext )
				{
					DebugLocation(107, 38);
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
		DebugLocation(107, 49);
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
			// MathLang.g:74:16: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )
			DebugEnterAlt(1);
			// MathLang.g:74:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
			{
			DebugLocation(74, 16);
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

			DebugLocation(74, 53);
			PushFollow(Follow._add_in_synpred21_MathLang545);
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
			// MathLang.g:85:22: ( '(' boolterm ')' )
			DebugEnterAlt(1);
			// MathLang.g:85:22: '(' boolterm ')'
			{
			DebugLocation(85, 22);
			Match(input,50,Follow._50_in_synpred29_MathLang680); if (state.failed) return;
			DebugLocation(85, 27);
			PushFollow(Follow._boolterm_in_synpred29_MathLang683);
			boolterm();
			PopFollow();
			if (state.failed) return;
			DebugLocation(85, 36);
			Match(input,51,Follow._51_in_synpred29_MathLang685); if (state.failed) return;

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
			// MathLang.g:90:64: ( ELSE ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:90:64: ELSE ( block | statement )
			{
			DebugLocation(90, 64);
			Match(input,ELSE,Follow._ELSE_in_synpred34_MathLang737); if (state.failed) return;
			DebugLocation(90, 70);
			// MathLang.g:90:70: ( block | statement )
			int alt26=2;
			try { DebugEnterSubRule(26);
			try { DebugEnterDecision(26, decisionCanBacktrack[26]);
			int LA26_0 = input.LA(1);

			if ((LA26_0==53))
			{
				alt26=1;
			}
			else if ((LA26_0==IF||LA26_0==FOR||(LA26_0>=RETURN && LA26_0<=WHILE)||LA26_0==ID||LA26_0==TYPE))
			{
				alt26=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				NoViableAltException nvae = new NoViableAltException("", 26, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(26); }
			switch (alt26)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:90:71: block
				{
				DebugLocation(90, 71);
				PushFollow(Follow._block_in_synpred34_MathLang741);
				block();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:90:79: statement
				{
				DebugLocation(90, 79);
				PushFollow(Follow._statement_in_synpred34_MathLang745);
				statement();
				PopFollow();
				if (state.failed) return;

				}
				break;

			}
			} finally { DebugExitSubRule(26); }


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
			"\x1\x7\x1\x14\x1\x17\x4\xFFFF\x1\x17\x4\xFFFF";
		private const string DFA1_maxS =
			"\x1\x16\x1\x14\x1\x32\x4\xFFFF\x1\x32\x4\xFFFF";
		private const string DFA1_acceptS =
			"\x3\xFFFF\x1\x3\x1\x4\x1\x5\x1\x7\x1\xFFFF\x1\x2\x1\x8\x1\x1\x1\x6";
		private const string DFA1_specialS =
			"\xC\xFFFF}>";
		private static readonly string[] DFA1_transitionS =
			{
				"\x1\x3\x1\xFFFF\x1\x5\x1\xFFFF\x1\x6\x1\x4\x7\xFFFF\x1\x2\x1\xFFFF"+
				"\x1\x1",
				"\x1\x7",
				"\x1\x8\x1A\xFFFF\x1\x9",
				"",
				"",
				"",
				"",
				"\x1\xA\x19\xFFFF\x1\xA\x1\xB",
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

		public override string Description { get { return "42:12: ( declaration | assignment | ifstatement | whilestatement | forstatement | funcdeclaration | returnstatement | funccall )"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}


	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _statementlist_in_execute290 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_execute292 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declaration_in_statement303 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assignment_in_statement309 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ifstatement_in_statement314 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _whilestatement_in_statement319 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _forstatement_in_statement324 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funcdeclaration_in_statement329 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _returnstatement_in_statement334 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccall_in_statement339 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NUMBER_in_number350 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_number356 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_number362 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CHAR_in_number368 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _term_in_mathexpression374 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _newexpression_in_expression388 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declarationbody_in_declaration400 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _49_in_declaration402 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _longdeclaration_in_declaration410 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_declarationbody417 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _ID_in_declarationbody419 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _longdeclarationbody_in_longdeclaration436 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _49_in_longdeclaration438 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_longdeclarationbody446 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _ID_in_longdeclarationbody448 = new BitSet(new ulong[]{0x800000UL});
		public static readonly BitSet _ASSIGN_in_longdeclarationbody450 = new BitSet(new ulong[]{0x8000000000UL});
		public static readonly BitSet _expression_in_longdeclarationbody452 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mul_in_add472 = new BitSet(new ulong[]{0x3000002UL});
		public static readonly BitSet _set_in_add476 = new BitSet(new ulong[]{0x4000002380000UL});
		public static readonly BitSet _mul_in_add485 = new BitSet(new ulong[]{0x3000002UL});
		public static readonly BitSet _group_in_mul494 = new BitSet(new ulong[]{0xC000002UL});
		public static readonly BitSet _set_in_mul498 = new BitSet(new ulong[]{0x4000002380000UL});
		public static readonly BitSet _group_in_mul507 = new BitSet(new ulong[]{0xC000002UL});
		public static readonly BitSet _add_in_compare515 = new BitSet(new ulong[]{0x3F0000002UL});
		public static readonly BitSet _set_in_compare519 = new BitSet(new ulong[]{0x4000002380000UL});
		public static readonly BitSet _add_in_compare545 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _add_in_term556 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _SUB_in_group563 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_group568 = new BitSet(new ulong[]{0x4000002380000UL});
		public static readonly BitSet _term_in_group571 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _51_in_group573 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _number_in_group578 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assignmentbody_in_assignment585 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _49_in_assignment587 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_assignmentbody594 = new BitSet(new ulong[]{0x800000UL});
		public static readonly BitSet _ASSIGN_in_assignmentbody596 = new BitSet(new ulong[]{0x8000000000UL});
		public static readonly BitSet _expression_in_assignmentbody598 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolterm_in_boolexpression615 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _or_in_boolterm622 = new BitSet(new ulong[]{0xC0000002UL});
		public static readonly BitSet _set_in_boolterm626 = new BitSet(new ulong[]{0x4007002380000UL});
		public static readonly BitSet _or_in_boolterm635 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _and_in_or644 = new BitSet(new ulong[]{0x400000002UL});
		public static readonly BitSet _OR_in_or647 = new BitSet(new ulong[]{0x4007002380000UL});
		public static readonly BitSet _and_in_or650 = new BitSet(new ulong[]{0x400000002UL});
		public static readonly BitSet _boolgroup_in_and658 = new BitSet(new ulong[]{0x800000002UL});
		public static readonly BitSet _AND_in_and661 = new BitSet(new ulong[]{0x4007002380000UL});
		public static readonly BitSet _boolgroup_in_and664 = new BitSet(new ulong[]{0x800000002UL});
		public static readonly BitSet _NOT_in_boolgroup673 = new BitSet(new ulong[]{0x4007002380000UL});
		public static readonly BitSet _50_in_boolgroup680 = new BitSet(new ulong[]{0x4007002380000UL});
		public static readonly BitSet _boolterm_in_boolgroup683 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _51_in_boolgroup685 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolvar_in_boolgroup690 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TRUE_in_boolvar698 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FALSE_in_boolvar704 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _compare_in_boolvar710 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_ifstatement717 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_ifstatement720 = new BitSet(new ulong[]{0x4007002380000UL});
		public static readonly BitSet _boolexpression_in_ifstatement723 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _51_in_ifstatement725 = new BitSet(new ulong[]{0x20000000501A80UL});
		public static readonly BitSet _block_in_ifstatement729 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement733 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _ELSE_in_ifstatement737 = new BitSet(new ulong[]{0x20000000501A80UL});
		public static readonly BitSet _block_in_ifstatement741 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement745 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _WHILE_in_whilestatement755 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_whilestatement758 = new BitSet(new ulong[]{0x4007002380000UL});
		public static readonly BitSet _boolexpression_in_whilestatement761 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _51_in_whilestatement763 = new BitSet(new ulong[]{0x20000000501A80UL});
		public static readonly BitSet _block_in_whilestatement767 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_whilestatement771 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_forstatement778 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_forstatement781 = new BitSet(new ulong[]{0x400000UL});
		public static readonly BitSet _longdeclarationbody_in_forstatement784 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _49_in_forstatement786 = new BitSet(new ulong[]{0x4007002380000UL});
		public static readonly BitSet _boolexpression_in_forstatement789 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _49_in_forstatement791 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _assignmentbody_in_forstatement794 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _51_in_forstatement796 = new BitSet(new ulong[]{0x20000000501A80UL});
		public static readonly BitSet _block_in_forstatement800 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_forstatement804 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _RETURN_in_returnstatement811 = new BitSet(new ulong[]{0x8000000000UL});
		public static readonly BitSet _expression_in_returnstatement814 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _49_in_returnstatement816 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_funcdeclaration825 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _ID_in_funcdeclaration827 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_funcdeclaration830 = new BitSet(new ulong[]{0x8000000400000UL});
		public static readonly BitSet _paramsdeclaration_in_funcdeclaration833 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _51_in_funcdeclaration836 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _block_in_funcdeclaration839 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declarationbody_in_paramsdeclaration872 = new BitSet(new ulong[]{0x10000000000002UL});
		public static readonly BitSet _52_in_paramsdeclaration876 = new BitSet(new ulong[]{0x400000UL});
		public static readonly BitSet _declarationbody_in_paramsdeclaration879 = new BitSet(new ulong[]{0x10000000000002UL});
		public static readonly BitSet _ID_in_funccallbody904 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_funccallbody907 = new BitSet(new ulong[]{0x8008000000000UL});
		public static readonly BitSet _expressioncommalist_in_funccallbody909 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _51_in_funccallbody912 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_funccall918 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _49_in_funccall920 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_expressioncommalist927 = new BitSet(new ulong[]{0x10000000000002UL});
		public static readonly BitSet _52_in_expressioncommalist931 = new BitSet(new ulong[]{0x8000000000UL});
		public static readonly BitSet _expression_in_expressioncommalist934 = new BitSet(new ulong[]{0x10000000000002UL});
		public static readonly BitSet _KNEW_in_newexpression957 = new BitSet(new ulong[]{0x10000000000UL});
		public static readonly BitSet _TYPE0_in_newexpression959 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _SQRBL_in_newexpression961 = new BitSet(new ulong[]{0x80000UL});
		public static readonly BitSet _NUMBER_in_newexpression964 = new BitSet(new ulong[]{0x40000000000UL});
		public static readonly BitSet _SQRBR_in_newexpression966 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _53_in_block976 = new BitSet(new ulong[]{0x60000000501A80UL});
		public static readonly BitSet _statementlist_in_block979 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _54_in_block981 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_statementlist989 = new BitSet(new ulong[]{0x20000000501A82UL});
		public static readonly BitSet _set_in_synpred21_MathLang519 = new BitSet(new ulong[]{0x4000002380000UL});
		public static readonly BitSet _add_in_synpred21_MathLang545 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _50_in_synpred29_MathLang680 = new BitSet(new ulong[]{0x4007002380000UL});
		public static readonly BitSet _boolterm_in_synpred29_MathLang683 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _51_in_synpred29_MathLang685 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ELSE_in_synpred34_MathLang737 = new BitSet(new ulong[]{0x20000000501A80UL});
		public static readonly BitSet _block_in_synpred34_MathLang741 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_synpred34_MathLang745 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  MathLang 

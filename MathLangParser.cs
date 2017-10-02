// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-10-02 14:07:44

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "UNKNOWN", "PRINT", "INPUT", "IF", "ELSE", "FOR", "FUNCTION", "RETURN", "WHILE", "BLOCK", "PROGRAM", "PARAMS", "NUMBER", "ID", "CHAR", "TYPE", "ASSIGN", "ARRAY", "ADD", "SUB", "MUL", "DIV", "GREQ", "LSEQ", "NEQ", "EQ", "GR", "LS", "OR", "AND", "NOT", "TRUE", "FALSE", "TYPEDEF", "ACCESS_MODIFIER", "RETURNS", "PARAMETERS", "WS", "SL_COMMENT", "ML_COMMENT", "';'", "'('", "')'", "','", "'{'", "'}'"
	};
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

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, true, false, false, false, true, false, false, false, 
				false, false, false, true, false, false, false, true, false, false, 
				false, false, false, false, false, , false
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
		this.state.ruleMemo = new System.Collections.Generic.Dictionary<int, int>[78+1];

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
	// MathLang.g:48:1: number : ( NUMBER | ID | funccallbody | CHAR );
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
		DebugLocation(48, 8);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 3)) { return retval; }
			// MathLang.g:48:8: ( NUMBER | ID | funccallbody | CHAR )
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

				if ((LA2_2==45))
				{
					alt2=3;
				}
				else if ((LA2_2==EOF||(LA2_2>=ADD && LA2_2<=AND)||LA2_2==44||(LA2_2>=46 && LA2_2<=47)))
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
				// MathLang.g:48:11: NUMBER
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(48, 11);
				NUMBER11=(IToken)Match(input,NUMBER,Follow._NUMBER_in_number323); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				NUMBER11_tree = (object)adaptor.Create(NUMBER11);
				adaptor.AddChild(root_0, NUMBER11_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:49:5: ID
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(49, 5);
				ID12=(IToken)Match(input,ID,Follow._ID_in_number329); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				ID12_tree = (object)adaptor.Create(ID12);
				adaptor.AddChild(root_0, ID12_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:50:5: funccallbody
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(50, 5);
				PushFollow(Follow._funccallbody_in_number335);
				funccallbody13=funccallbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody13.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:51:5: CHAR
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(51, 5);
				CHAR14=(IToken)Match(input,CHAR,Follow._CHAR_in_number341); if (state.failed) return retval;
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
		DebugLocation(51, 8);
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
	// MathLang.g:52:1: mathexpression : term ;
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
		DebugLocation(52, 21);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 4)) { return retval; }
			// MathLang.g:52:15: ( term )
			DebugEnterAlt(1);
			// MathLang.g:52:17: term
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(52, 17);
			PushFollow(Follow._term_in_mathexpression347);
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
		DebugLocation(52, 21);
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
	// MathLang.g:54:1: expression : ( funccallbody | boolexpression | mathexpression );
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

		MathLangParser.funccallbody_return funccallbody16 = default(MathLangParser.funccallbody_return);
		MathLangParser.boolexpression_return boolexpression17 = default(MathLangParser.boolexpression_return);
		MathLangParser.mathexpression_return mathexpression18 = default(MathLangParser.mathexpression_return);


		try { DebugEnterRule(GrammarFileName, "expression");
		DebugLocation(54, 19);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 5)) { return retval; }
			// MathLang.g:54:11: ( funccallbody | boolexpression | mathexpression )
			int alt3=3;
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
				// MathLang.g:54:14: funccallbody
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(54, 14);
				PushFollow(Follow._funccallbody_in_expression356);
				funccallbody16=funccallbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody16.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:55:6: boolexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(55, 6);
				PushFollow(Follow._boolexpression_in_expression363);
				boolexpression17=boolexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression17.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:56:6: mathexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(56, 6);
				PushFollow(Follow._mathexpression_in_expression370);
				mathexpression18=mathexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mathexpression18.Tree);

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
		DebugLocation(56, 19);
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
	// MathLang.g:58:1: declaration : ( declarationbody ';' | longdeclaration );
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

		IToken char_literal20=null;
		MathLangParser.declarationbody_return declarationbody19 = default(MathLangParser.declarationbody_return);
		MathLangParser.longdeclaration_return longdeclaration21 = default(MathLangParser.longdeclaration_return);

		object char_literal20_tree=null;

		try { DebugEnterRule(GrammarFileName, "declaration");
		DebugLocation(58, 20);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 6)) { return retval; }
			// MathLang.g:58:12: ( declarationbody ';' | longdeclaration )
			int alt4=2;
			try { DebugEnterDecision(4, decisionCanBacktrack[4]);
			int LA4_0 = input.LA(1);

			if ((LA4_0==TYPE))
			{
				int LA4_1 = input.LA(2);

				if ((LA4_1==ID))
				{
					int LA4_2 = input.LA(3);

					if ((LA4_2==ASSIGN))
					{
						alt4=2;
					}
					else if ((LA4_2==44))
					{
						alt4=1;
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
				// MathLang.g:58:14: declarationbody ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(58, 14);
				PushFollow(Follow._declarationbody_in_declaration377);
				declarationbody19=declarationbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, declarationbody19.Tree);
				DebugLocation(58, 33);
				char_literal20=(IToken)Match(input,44,Follow._44_in_declaration379); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:59:6: longdeclaration
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(59, 6);
				PushFollow(Follow._longdeclaration_in_declaration387);
				longdeclaration21=longdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclaration21.Tree);

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
		DebugLocation(59, 20);
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
	// MathLang.g:61:1: declarationbody : TYPE ID ;
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

		IToken TYPE22=null;
		IToken ID23=null;

		object TYPE22_tree=null;
		object ID23_tree=null;

		try { DebugEnterRule(GrammarFileName, "declarationbody");
		DebugLocation(61, 26);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 7)) { return retval; }
			// MathLang.g:61:16: ( TYPE ID )
			DebugEnterAlt(1);
			// MathLang.g:61:18: TYPE ID
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(61, 22);
			TYPE22=(IToken)Match(input,TYPE,Follow._TYPE_in_declarationbody394); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			TYPE22_tree = (object)adaptor.Create(TYPE22);
			root_0 = (object)adaptor.BecomeRoot(TYPE22_tree, root_0);
			}
			DebugLocation(61, 24);
			ID23=(IToken)Match(input,ID,Follow._ID_in_declarationbody397); if (state.failed) return retval;
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
			TraceOut("declarationbody", 7);
			LeaveRule("declarationbody", 7);
			Leave_declarationbody();
			if (state.backtracking > 0) { Memoize(input, 7, declarationbody_StartIndex); }
		}
		DebugLocation(61, 26);
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
	// MathLang.g:62:1: longdeclaration : longdeclarationbody ';' ;
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

		IToken char_literal25=null;
		MathLangParser.longdeclarationbody_return longdeclarationbody24 = default(MathLangParser.longdeclarationbody_return);

		object char_literal25_tree=null;

		try { DebugEnterRule(GrammarFileName, "longdeclaration");
		DebugLocation(62, 42);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 8)) { return retval; }
			// MathLang.g:62:16: ( longdeclarationbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:62:18: longdeclarationbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(62, 18);
			PushFollow(Follow._longdeclarationbody_in_longdeclaration404);
			longdeclarationbody24=longdeclarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclarationbody24.Tree);
			DebugLocation(62, 41);
			char_literal25=(IToken)Match(input,44,Follow._44_in_longdeclaration406); if (state.failed) return retval;

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
		DebugLocation(62, 42);
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
	// MathLang.g:63:1: longdeclarationbody : TYPE ID ASSIGN expression -> ^( ASSIGN ^( TYPE ID ) expression ) ;
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

		IToken TYPE26=null;
		IToken ID27=null;
		IToken ASSIGN28=null;
		MathLangParser.expression_return expression29 = default(MathLangParser.expression_return);

		object TYPE26_tree=null;
		object ID27_tree=null;
		object ASSIGN28_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "longdeclarationbody");
		DebugLocation(63, 82);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 9)) { return retval; }
			// MathLang.g:63:20: ( TYPE ID ASSIGN expression -> ^( ASSIGN ^( TYPE ID ) expression ) )
			DebugEnterAlt(1);
			// MathLang.g:63:22: TYPE ID ASSIGN expression
			{
			DebugLocation(63, 22);
			TYPE26=(IToken)Match(input,TYPE,Follow._TYPE_in_longdeclarationbody414); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE26);

			DebugLocation(63, 27);
			ID27=(IToken)Match(input,ID,Follow._ID_in_longdeclarationbody416); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID27);

			DebugLocation(63, 30);
			ASSIGN28=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclarationbody418); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN28);

			DebugLocation(63, 37);
			PushFollow(Follow._expression_in_longdeclarationbody420);
			expression29=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression29.Tree);


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
			// 63:48: -> ^( ASSIGN ^( TYPE ID ) expression )
			{
				DebugLocation(63, 51);
				// MathLang.g:63:51: ^( ASSIGN ^( TYPE ID ) expression )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(63, 53);
				root_1 = (object)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_1);

				DebugLocation(63, 60);
				// MathLang.g:63:60: ^( TYPE ID )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(63, 62);
				root_2 = (object)adaptor.BecomeRoot(stream_TYPE.NextNode(), root_2);

				DebugLocation(63, 67);
				adaptor.AddChild(root_2, stream_ID.NextNode());

				adaptor.AddChild(root_1, root_2);
				}
				DebugLocation(63, 71);
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
		DebugLocation(63, 82);
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
	// MathLang.g:65:1: variable : ( TYPE | ARRAY ) ID ;
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

		IToken set30=null;
		IToken ID31=null;

		object set30_tree=null;
		object ID31_tree=null;

		try { DebugEnterRule(GrammarFileName, "variable");
		DebugLocation(65, 28);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 10)) { return retval; }
			// MathLang.g:65:9: ( ( TYPE | ARRAY ) ID )
			DebugEnterAlt(1);
			// MathLang.g:65:11: ( TYPE | ARRAY ) ID
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(65, 11);
			set30=(IToken)input.LT(1);
			set30=(IToken)input.LT(1);
			if (input.LA(1)==TYPE||input.LA(1)==ARRAY)
			{
				input.Consume();
				if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set30), root_0);
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
			ID31=(IToken)Match(input,ID,Follow._ID_in_variable451); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			ID31_tree = (object)adaptor.Create(ID31);
			adaptor.AddChild(root_0, ID31_tree);
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
		DebugLocation(65, 28);
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

		IToken set33=null;
		MathLangParser.mul_return mul32 = default(MathLangParser.mul_return);
		MathLangParser.mul_return mul34 = default(MathLangParser.mul_return);

		object set33_tree=null;

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
			PushFollow(Follow._mul_in_add458);
			mul32=mul();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul32.Tree);
			DebugLocation(67, 10);
			// MathLang.g:67:10: ( ( ADD | SUB ) mul )*
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
					// MathLang.g:67:12: ( ADD | SUB ) mul
					{
					DebugLocation(67, 12);
					set33=(IToken)input.LT(1);
					set33=(IToken)input.LT(1);
					if ((input.LA(1)>=ADD && input.LA(1)<=SUB))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set33), root_0);
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
					PushFollow(Follow._mul_in_add471);
					mul34=mul();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul34.Tree);

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

		IToken set36=null;
		MathLangParser.group_return group35 = default(MathLangParser.group_return);
		MathLangParser.group_return group37 = default(MathLangParser.group_return);

		object set36_tree=null;

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
			PushFollow(Follow._group_in_mul480);
			group35=group();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group35.Tree);
			DebugLocation(68, 12);
			// MathLang.g:68:12: ( ( MUL | DIV ) group )*
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
					// MathLang.g:68:14: ( MUL | DIV ) group
					{
					DebugLocation(68, 14);
					set36=(IToken)input.LT(1);
					set36=(IToken)input.LT(1);
					if ((input.LA(1)>=MUL && input.LA(1)<=DIV))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set36), root_0);
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
					PushFollow(Follow._group_in_mul493);
					group37=group();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group37.Tree);

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

		IToken set39=null;
		MathLangParser.add_return add38 = default(MathLangParser.add_return);
		MathLangParser.add_return add40 = default(MathLangParser.add_return);

		object set39_tree=null;

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
			PushFollow(Follow._add_in_compare501);
			add38=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add38.Tree);
			DebugLocation(69, 14);
			// MathLang.g:69:14: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
			int alt7=2;
			try { DebugEnterSubRule(7);
			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
			int LA7_0 = input.LA(1);

			if (((LA7_0>=NEQ && LA7_0<=EQ)))
			{
				int LA7_1 = input.LA(2);

				if ((EvaluatePredicate(synpred24_MathLang_fragment)))
				{
					alt7=1;
				}
			}
			else if (((LA7_0>=GREQ && LA7_0<=LSEQ)||(LA7_0>=GR && LA7_0<=LS)))
			{
				alt7=1;
			}
			} finally { DebugExitDecision(7); }
			switch (alt7)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:69:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
				{
				DebugLocation(69, 16);
				set39=(IToken)input.LT(1);
				set39=(IToken)input.LT(1);
				if ((input.LA(1)>=GREQ && input.LA(1)<=LS))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set39), root_0);
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
				PushFollow(Follow._add_in_compare531);
				add40=add();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add40.Tree);

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
	// MathLang.g:70:1: term : add ;
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

		MathLangParser.add_return add41 = default(MathLangParser.add_return);


		try { DebugEnterRule(GrammarFileName, "term");
		DebugLocation(70, 9);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 14)) { return retval; }
			// MathLang.g:70:5: ( add )
			DebugEnterAlt(1);
			// MathLang.g:70:7: add
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(70, 7);
			PushFollow(Follow._add_in_term542);
			add41=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add41.Tree);

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
		DebugLocation(70, 9);
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
	// MathLang.g:71:1: group : ( ( SUB )? '(' term ')' | number );
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

		IToken SUB42=null;
		IToken char_literal43=null;
		IToken char_literal45=null;
		MathLangParser.term_return term44 = default(MathLangParser.term_return);
		MathLangParser.number_return number46 = default(MathLangParser.number_return);

		object SUB42_tree=null;
		object char_literal43_tree=null;
		object char_literal45_tree=null;

		try { DebugEnterRule(GrammarFileName, "group");
		DebugLocation(71, 38);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 15)) { return retval; }
			// MathLang.g:71:6: ( ( SUB )? '(' term ')' | number )
			int alt9=2;
			try { DebugEnterDecision(9, decisionCanBacktrack[9]);
			int LA9_0 = input.LA(1);

			if ((LA9_0==SUB||LA9_0==45))
			{
				alt9=1;
			}
			else if (((LA9_0>=NUMBER && LA9_0<=CHAR)))
			{
				alt9=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 9, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(9); }
			switch (alt9)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:71:8: ( SUB )? '(' term ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(71, 8);
				// MathLang.g:71:8: ( SUB )?
				int alt8=2;
				try { DebugEnterSubRule(8);
				try { DebugEnterDecision(8, decisionCanBacktrack[8]);
				int LA8_0 = input.LA(1);

				if ((LA8_0==SUB))
				{
					alt8=1;
				}
				} finally { DebugExitDecision(8); }
				switch (alt8)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:71:9: SUB
					{
					DebugLocation(71, 12);
					SUB42=(IToken)Match(input,SUB,Follow._SUB_in_group549); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					SUB42_tree = (object)adaptor.Create(SUB42);
					root_0 = (object)adaptor.BecomeRoot(SUB42_tree, root_0);
					}

					}
					break;

				}
				} finally { DebugExitSubRule(8); }

				DebugLocation(71, 19);
				char_literal43=(IToken)Match(input,45,Follow._45_in_group554); if (state.failed) return retval;
				DebugLocation(71, 21);
				PushFollow(Follow._term_in_group557);
				term44=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term44.Tree);
				DebugLocation(71, 29);
				char_literal45=(IToken)Match(input,46,Follow._46_in_group559); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:71:33: number
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(71, 33);
				PushFollow(Follow._number_in_group564);
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
		DebugLocation(71, 38);
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
	// MathLang.g:73:1: assignment : assignmentbody ';' ;
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

		IToken char_literal48=null;
		MathLangParser.assignmentbody_return assignmentbody47 = default(MathLangParser.assignmentbody_return);

		object char_literal48_tree=null;

		try { DebugEnterRule(GrammarFileName, "assignment");
		DebugLocation(73, 31);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 16)) { return retval; }
			// MathLang.g:73:11: ( assignmentbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:73:13: assignmentbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(73, 13);
			PushFollow(Follow._assignmentbody_in_assignment571);
			assignmentbody47=assignmentbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentbody47.Tree);
			DebugLocation(73, 31);
			char_literal48=(IToken)Match(input,44,Follow._44_in_assignment573); if (state.failed) return retval;

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
		DebugLocation(73, 31);
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
	// MathLang.g:74:1: assignmentbody : ID ASSIGN expression ;
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

		IToken ID49=null;
		IToken ASSIGN50=null;
		MathLangParser.expression_return expression51 = default(MathLangParser.expression_return);

		object ID49_tree=null;
		object ASSIGN50_tree=null;

		try { DebugEnterRule(GrammarFileName, "assignmentbody");
		DebugLocation(74, 38);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 17)) { return retval; }
			// MathLang.g:74:15: ( ID ASSIGN expression )
			DebugEnterAlt(1);
			// MathLang.g:74:17: ID ASSIGN expression
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(74, 17);
			ID49=(IToken)Match(input,ID,Follow._ID_in_assignmentbody580); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			ID49_tree = (object)adaptor.Create(ID49);
			adaptor.AddChild(root_0, ID49_tree);
			}
			DebugLocation(74, 26);
			ASSIGN50=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignmentbody582); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			ASSIGN50_tree = (object)adaptor.Create(ASSIGN50);
			root_0 = (object)adaptor.BecomeRoot(ASSIGN50_tree, root_0);
			}
			DebugLocation(74, 28);
			PushFollow(Follow._expression_in_assignmentbody585);
			expression51=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression51.Tree);

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
		DebugLocation(74, 38);
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
	// MathLang.g:76:1: boolexpression : boolterm ;
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

		MathLangParser.boolterm_return boolterm52 = default(MathLangParser.boolterm_return);


		try { DebugEnterRule(GrammarFileName, "boolexpression");
		DebugLocation(76, 25);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 18)) { return retval; }
			// MathLang.g:76:15: ( boolterm )
			DebugEnterAlt(1);
			// MathLang.g:76:17: boolterm
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(76, 17);
			PushFollow(Follow._boolterm_in_boolexpression593);
			boolterm52=boolterm();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm52.Tree);

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
		DebugLocation(76, 25);
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
	// MathLang.g:77:1: boolterm : or ( ( EQ | NEQ ) or )? ;
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

		IToken set54=null;
		MathLangParser.or_return or53 = default(MathLangParser.or_return);
		MathLangParser.or_return or55 = default(MathLangParser.or_return);

		object set54_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolterm");
		DebugLocation(77, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 19)) { return retval; }
			// MathLang.g:77:9: ( or ( ( EQ | NEQ ) or )? )
			DebugEnterAlt(1);
			// MathLang.g:77:11: or ( ( EQ | NEQ ) or )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(77, 11);
			PushFollow(Follow._or_in_boolterm600);
			or53=or();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or53.Tree);
			DebugLocation(77, 14);
			// MathLang.g:77:14: ( ( EQ | NEQ ) or )?
			int alt10=2;
			try { DebugEnterSubRule(10);
			try { DebugEnterDecision(10, decisionCanBacktrack[10]);
			int LA10_0 = input.LA(1);

			if (((LA10_0>=NEQ && LA10_0<=EQ)))
			{
				alt10=1;
			}
			} finally { DebugExitDecision(10); }
			switch (alt10)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:77:16: ( EQ | NEQ ) or
				{
				DebugLocation(77, 16);
				set54=(IToken)input.LT(1);
				set54=(IToken)input.LT(1);
				if ((input.LA(1)>=NEQ && input.LA(1)<=EQ))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set54), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(77, 28);
				PushFollow(Follow._or_in_boolterm613);
				or55=or();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or55.Tree);

				}
				break;

			}
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
			TraceOut("boolterm", 19);
			LeaveRule("boolterm", 19);
			Leave_boolterm();
			if (state.backtracking > 0) { Memoize(input, 19, boolterm_StartIndex); }
		}
		DebugLocation(77, 32);
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
	// MathLang.g:78:1: or : and ( OR and )* ;
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

		IToken OR57=null;
		MathLangParser.and_return and56 = default(MathLangParser.and_return);
		MathLangParser.and_return and58 = default(MathLangParser.and_return);

		object OR57_tree=null;

		try { DebugEnterRule(GrammarFileName, "or");
		DebugLocation(78, 18);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 20)) { return retval; }
			// MathLang.g:78:3: ( and ( OR and )* )
			DebugEnterAlt(1);
			// MathLang.g:78:5: and ( OR and )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(78, 5);
			PushFollow(Follow._and_in_or622);
			and56=and();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and56.Tree);
			DebugLocation(78, 9);
			// MathLang.g:78:9: ( OR and )*
			try { DebugEnterSubRule(11);
			while (true)
			{
				int alt11=2;
				try { DebugEnterDecision(11, decisionCanBacktrack[11]);
				int LA11_0 = input.LA(1);

				if ((LA11_0==OR))
				{
					alt11=1;
				}


				} finally { DebugExitDecision(11); }
				switch ( alt11 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:78:10: OR and
					{
					DebugLocation(78, 12);
					OR57=(IToken)Match(input,OR,Follow._OR_in_or625); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR57_tree = (object)adaptor.Create(OR57);
					root_0 = (object)adaptor.BecomeRoot(OR57_tree, root_0);
					}
					DebugLocation(78, 14);
					PushFollow(Follow._and_in_or628);
					and58=and();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and58.Tree);

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
			TraceOut("or", 20);
			LeaveRule("or", 20);
			Leave_or();
			if (state.backtracking > 0) { Memoize(input, 20, or_StartIndex); }
		}
		DebugLocation(78, 18);
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
	// MathLang.g:79:1: and : boolgroup ( AND boolgroup )* ;
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

		IToken AND60=null;
		MathLangParser.boolgroup_return boolgroup59 = default(MathLangParser.boolgroup_return);
		MathLangParser.boolgroup_return boolgroup61 = default(MathLangParser.boolgroup_return);

		object AND60_tree=null;

		try { DebugEnterRule(GrammarFileName, "and");
		DebugLocation(79, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 21)) { return retval; }
			// MathLang.g:79:4: ( boolgroup ( AND boolgroup )* )
			DebugEnterAlt(1);
			// MathLang.g:79:6: boolgroup ( AND boolgroup )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(79, 6);
			PushFollow(Follow._boolgroup_in_and636);
			boolgroup59=boolgroup();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup59.Tree);
			DebugLocation(79, 16);
			// MathLang.g:79:16: ( AND boolgroup )*
			try { DebugEnterSubRule(12);
			while (true)
			{
				int alt12=2;
				try { DebugEnterDecision(12, decisionCanBacktrack[12]);
				int LA12_0 = input.LA(1);

				if ((LA12_0==AND))
				{
					alt12=1;
				}


				} finally { DebugExitDecision(12); }
				switch ( alt12 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:79:17: AND boolgroup
					{
					DebugLocation(79, 20);
					AND60=(IToken)Match(input,AND,Follow._AND_in_and639); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND60_tree = (object)adaptor.Create(AND60);
					root_0 = (object)adaptor.BecomeRoot(AND60_tree, root_0);
					}
					DebugLocation(79, 22);
					PushFollow(Follow._boolgroup_in_and642);
					boolgroup61=boolgroup();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup61.Tree);

					}
					break;

				default:
					goto loop12;
				}
			}

			loop12:
				;

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
			TraceOut("and", 21);
			LeaveRule("and", 21);
			Leave_and();
			if (state.backtracking > 0) { Memoize(input, 21, and_StartIndex); }
		}
		DebugLocation(79, 32);
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
	// MathLang.g:80:1: boolgroup : ( NOT )? ( '(' boolterm ')' | boolvar ) ;
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

		IToken NOT62=null;
		IToken char_literal63=null;
		IToken char_literal65=null;
		MathLangParser.boolterm_return boolterm64 = default(MathLangParser.boolterm_return);
		MathLangParser.boolvar_return boolvar66 = default(MathLangParser.boolvar_return);

		object NOT62_tree=null;
		object char_literal63_tree=null;
		object char_literal65_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolgroup");
		DebugLocation(80, 51);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 22)) { return retval; }
			// MathLang.g:80:10: ( ( NOT )? ( '(' boolterm ')' | boolvar ) )
			DebugEnterAlt(1);
			// MathLang.g:80:12: ( NOT )? ( '(' boolterm ')' | boolvar )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(80, 12);
			// MathLang.g:80:12: ( NOT )?
			int alt13=2;
			try { DebugEnterSubRule(13);
			try { DebugEnterDecision(13, decisionCanBacktrack[13]);
			int LA13_0 = input.LA(1);

			if ((LA13_0==NOT))
			{
				alt13=1;
			}
			} finally { DebugExitDecision(13); }
			switch (alt13)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:80:13: NOT
				{
				DebugLocation(80, 16);
				NOT62=(IToken)Match(input,NOT,Follow._NOT_in_boolgroup651); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				NOT62_tree = (object)adaptor.Create(NOT62);
				root_0 = (object)adaptor.BecomeRoot(NOT62_tree, root_0);
				}

				}
				break;

			}
			} finally { DebugExitSubRule(13); }

			DebugLocation(80, 20);
			// MathLang.g:80:20: ( '(' boolterm ')' | boolvar )
			int alt14=2;
			try { DebugEnterSubRule(14);
			try { DebugEnterDecision(14, decisionCanBacktrack[14]);
			int LA14_0 = input.LA(1);

			if ((LA14_0==45))
			{
				int LA14_1 = input.LA(2);

				if ((EvaluatePredicate(synpred32_MathLang_fragment)))
				{
					alt14=1;
				}
				else if ((true))
				{
					alt14=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 14, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else if (((LA14_0>=NUMBER && LA14_0<=CHAR)||LA14_0==SUB||(LA14_0>=TRUE && LA14_0<=FALSE)))
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
				// MathLang.g:80:22: '(' boolterm ')'
				{
				DebugLocation(80, 25);
				char_literal63=(IToken)Match(input,45,Follow._45_in_boolgroup658); if (state.failed) return retval;
				DebugLocation(80, 27);
				PushFollow(Follow._boolterm_in_boolgroup661);
				boolterm64=boolterm();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm64.Tree);
				DebugLocation(80, 39);
				char_literal65=(IToken)Match(input,46,Follow._46_in_boolgroup663); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:80:43: boolvar
				{
				DebugLocation(80, 43);
				PushFollow(Follow._boolvar_in_boolgroup668);
				boolvar66=boolvar();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolvar66.Tree);

				}
				break;

			}
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
			TraceOut("boolgroup", 22);
			LeaveRule("boolgroup", 22);
			Leave_boolgroup();
			if (state.backtracking > 0) { Memoize(input, 22, boolgroup_StartIndex); }
		}
		DebugLocation(80, 51);
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
	// MathLang.g:81:1: boolvar : ( TRUE | FALSE | compare );
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

		IToken TRUE67=null;
		IToken FALSE68=null;
		MathLangParser.compare_return compare69 = default(MathLangParser.compare_return);

		object TRUE67_tree=null;
		object FALSE68_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolvar");
		DebugLocation(81, 11);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 23)) { return retval; }
			// MathLang.g:81:8: ( TRUE | FALSE | compare )
			int alt15=3;
			try { DebugEnterDecision(15, decisionCanBacktrack[15]);
			switch (input.LA(1))
			{
			case TRUE:
				{
				alt15=1;
				}
				break;
			case FALSE:
				{
				alt15=2;
				}
				break;
			case NUMBER:
			case ID:
			case CHAR:
			case SUB:
			case 45:
				{
				alt15=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 15, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(15); }
			switch (alt15)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:81:10: TRUE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(81, 10);
				TRUE67=(IToken)Match(input,TRUE,Follow._TRUE_in_boolvar676); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				TRUE67_tree = (object)adaptor.Create(TRUE67);
				adaptor.AddChild(root_0, TRUE67_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:82:5: FALSE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(82, 5);
				FALSE68=(IToken)Match(input,FALSE,Follow._FALSE_in_boolvar682); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				FALSE68_tree = (object)adaptor.Create(FALSE68);
				adaptor.AddChild(root_0, FALSE68_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:83:5: compare
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(83, 5);
				PushFollow(Follow._compare_in_boolvar688);
				compare69=compare();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare69.Tree);

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
		DebugLocation(83, 11);
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
	// MathLang.g:85:1: ifstatement : IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )* ;
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

		IToken IF70=null;
		IToken char_literal71=null;
		IToken char_literal73=null;
		IToken ELSE76=null;
		MathLangParser.boolexpression_return boolexpression72 = default(MathLangParser.boolexpression_return);
		MathLangParser.block_return block74 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement75 = default(MathLangParser.statement_return);
		MathLangParser.block_return block77 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement78 = default(MathLangParser.statement_return);

		object IF70_tree=null;
		object char_literal71_tree=null;
		object char_literal73_tree=null;
		object ELSE76_tree=null;

		try { DebugEnterRule(GrammarFileName, "ifstatement");
		DebugLocation(85, 91);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 24)) { return retval; }
			// MathLang.g:85:12: ( IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )* )
			DebugEnterAlt(1);
			// MathLang.g:85:14: IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(85, 16);
			IF70=(IToken)Match(input,IF,Follow._IF_in_ifstatement695); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			IF70_tree = (object)adaptor.Create(IF70);
			root_0 = (object)adaptor.BecomeRoot(IF70_tree, root_0);
			}
			DebugLocation(85, 21);
			char_literal71=(IToken)Match(input,45,Follow._45_in_ifstatement698); if (state.failed) return retval;
			DebugLocation(85, 23);
			PushFollow(Follow._boolexpression_in_ifstatement701);
			boolexpression72=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression72.Tree);
			DebugLocation(85, 41);
			char_literal73=(IToken)Match(input,46,Follow._46_in_ifstatement703); if (state.failed) return retval;
			DebugLocation(85, 43);
			// MathLang.g:85:43: ( block | statement )
			int alt16=2;
			try { DebugEnterSubRule(16);
			try { DebugEnterDecision(16, decisionCanBacktrack[16]);
			int LA16_0 = input.LA(1);

			if ((LA16_0==48))
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
				// MathLang.g:85:44: block
				{
				DebugLocation(85, 44);
				PushFollow(Follow._block_in_ifstatement707);
				block74=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block74.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:85:52: statement
				{
				DebugLocation(85, 52);
				PushFollow(Follow._statement_in_ifstatement711);
				statement75=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement75.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(16); }

			DebugLocation(85, 63);
			// MathLang.g:85:63: ( ELSE ( block | statement ) )*
			try { DebugEnterSubRule(18);
			while (true)
			{
				int alt18=2;
				try { DebugEnterDecision(18, decisionCanBacktrack[18]);
				int LA18_0 = input.LA(1);

				if ((LA18_0==ELSE))
				{
					int LA18_1 = input.LA(2);

					if ((EvaluatePredicate(synpred37_MathLang_fragment)))
					{
						alt18=1;
					}


				}


				} finally { DebugExitDecision(18); }
				switch ( alt18 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:85:64: ELSE ( block | statement )
					{
					DebugLocation(85, 68);
					ELSE76=(IToken)Match(input,ELSE,Follow._ELSE_in_ifstatement715); if (state.failed) return retval;
					DebugLocation(85, 70);
					// MathLang.g:85:70: ( block | statement )
					int alt17=2;
					try { DebugEnterSubRule(17);
					try { DebugEnterDecision(17, decisionCanBacktrack[17]);
					int LA17_0 = input.LA(1);

					if ((LA17_0==48))
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
						// MathLang.g:85:71: block
						{
						DebugLocation(85, 71);
						PushFollow(Follow._block_in_ifstatement719);
						block77=block();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block77.Tree);

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// MathLang.g:85:79: statement
						{
						DebugLocation(85, 79);
						PushFollow(Follow._statement_in_ifstatement723);
						statement78=statement();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement78.Tree);

						}
						break;

					}
					} finally { DebugExitSubRule(17); }


					}
					break;

				default:
					goto loop18;
				}
			}

			loop18:
				;

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
			TraceOut("ifstatement", 24);
			LeaveRule("ifstatement", 24);
			Leave_ifstatement();
			if (state.backtracking > 0) { Memoize(input, 24, ifstatement_StartIndex); }
		}
		DebugLocation(85, 91);
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

		IToken WHILE79=null;
		IToken char_literal80=null;
		IToken char_literal82=null;
		MathLangParser.boolexpression_return boolexpression81 = default(MathLangParser.boolexpression_return);
		MathLangParser.block_return block83 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement84 = default(MathLangParser.statement_return);

		object WHILE79_tree=null;
		object char_literal80_tree=null;
		object char_literal82_tree=null;

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
			WHILE79=(IToken)Match(input,WHILE,Follow._WHILE_in_whilestatement733); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			WHILE79_tree = (object)adaptor.Create(WHILE79);
			root_0 = (object)adaptor.BecomeRoot(WHILE79_tree, root_0);
			}
			DebugLocation(86, 27);
			char_literal80=(IToken)Match(input,45,Follow._45_in_whilestatement736); if (state.failed) return retval;
			DebugLocation(86, 29);
			PushFollow(Follow._boolexpression_in_whilestatement739);
			boolexpression81=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression81.Tree);
			DebugLocation(86, 47);
			char_literal82=(IToken)Match(input,46,Follow._46_in_whilestatement741); if (state.failed) return retval;
			DebugLocation(86, 49);
			// MathLang.g:86:49: ( block | statement )
			int alt19=2;
			try { DebugEnterSubRule(19);
			try { DebugEnterDecision(19, decisionCanBacktrack[19]);
			int LA19_0 = input.LA(1);

			if ((LA19_0==48))
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
				// MathLang.g:86:50: block
				{
				DebugLocation(86, 50);
				PushFollow(Follow._block_in_whilestatement745);
				block83=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block83.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:86:58: statement
				{
				DebugLocation(86, 58);
				PushFollow(Follow._statement_in_whilestatement749);
				statement84=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement84.Tree);

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
	// MathLang.g:87:1: forstatement : FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement ) ;
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

		IToken FOR85=null;
		IToken char_literal86=null;
		IToken char_literal88=null;
		IToken char_literal90=null;
		IToken char_literal92=null;
		MathLangParser.longdeclarationbody_return longdeclarationbody87 = default(MathLangParser.longdeclarationbody_return);
		MathLangParser.boolexpression_return boolexpression89 = default(MathLangParser.boolexpression_return);
		MathLangParser.assignmentbody_return assignmentbody91 = default(MathLangParser.assignmentbody_return);
		MathLangParser.block_return block93 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement94 = default(MathLangParser.statement_return);

		object FOR85_tree=null;
		object char_literal86_tree=null;
		object char_literal88_tree=null;
		object char_literal90_tree=null;
		object char_literal92_tree=null;

		try { DebugEnterRule(GrammarFileName, "forstatement");
		DebugLocation(87, 108);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 26)) { return retval; }
			// MathLang.g:87:13: ( FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:87:15: FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(87, 18);
			FOR85=(IToken)Match(input,FOR,Follow._FOR_in_forstatement756); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			FOR85_tree = (object)adaptor.Create(FOR85);
			root_0 = (object)adaptor.BecomeRoot(FOR85_tree, root_0);
			}
			DebugLocation(87, 23);
			char_literal86=(IToken)Match(input,45,Follow._45_in_forstatement759); if (state.failed) return retval;
			DebugLocation(87, 25);
			PushFollow(Follow._longdeclarationbody_in_forstatement762);
			longdeclarationbody87=longdeclarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclarationbody87.Tree);
			DebugLocation(87, 48);
			char_literal88=(IToken)Match(input,44,Follow._44_in_forstatement764); if (state.failed) return retval;
			DebugLocation(87, 50);
			PushFollow(Follow._boolexpression_in_forstatement767);
			boolexpression89=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression89.Tree);
			DebugLocation(87, 68);
			char_literal90=(IToken)Match(input,44,Follow._44_in_forstatement769); if (state.failed) return retval;
			DebugLocation(87, 70);
			PushFollow(Follow._assignmentbody_in_forstatement772);
			assignmentbody91=assignmentbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentbody91.Tree);
			DebugLocation(87, 88);
			char_literal92=(IToken)Match(input,46,Follow._46_in_forstatement774); if (state.failed) return retval;
			DebugLocation(87, 90);
			// MathLang.g:87:90: ( block | statement )
			int alt20=2;
			try { DebugEnterSubRule(20);
			try { DebugEnterDecision(20, decisionCanBacktrack[20]);
			int LA20_0 = input.LA(1);

			if ((LA20_0==48))
			{
				alt20=1;
			}
			else if ((LA20_0==IF||LA20_0==FOR||(LA20_0>=RETURN && LA20_0<=WHILE)||LA20_0==ID||LA20_0==TYPE))
			{
				alt20=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 20, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(20); }
			switch (alt20)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:87:91: block
				{
				DebugLocation(87, 91);
				PushFollow(Follow._block_in_forstatement778);
				block93=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block93.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:87:99: statement
				{
				DebugLocation(87, 99);
				PushFollow(Follow._statement_in_forstatement782);
				statement94=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement94.Tree);

				}
				break;

			}
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
			TraceOut("forstatement", 26);
			LeaveRule("forstatement", 26);
			Leave_forstatement();
			if (state.backtracking > 0) { Memoize(input, 26, forstatement_StartIndex); }
		}
		DebugLocation(87, 108);
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
	// MathLang.g:88:1: returnstatement : RETURN expression ';' ;
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

		IToken RETURN95=null;
		IToken char_literal97=null;
		MathLangParser.expression_return expression96 = default(MathLangParser.expression_return);

		object RETURN95_tree=null;
		object char_literal97_tree=null;

		try { DebugEnterRule(GrammarFileName, "returnstatement");
		DebugLocation(88, 41);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 27)) { return retval; }
			// MathLang.g:88:16: ( RETURN expression ';' )
			DebugEnterAlt(1);
			// MathLang.g:88:18: RETURN expression ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(88, 24);
			RETURN95=(IToken)Match(input,RETURN,Follow._RETURN_in_returnstatement789); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			RETURN95_tree = (object)adaptor.Create(RETURN95);
			root_0 = (object)adaptor.BecomeRoot(RETURN95_tree, root_0);
			}
			DebugLocation(88, 26);
			PushFollow(Follow._expression_in_returnstatement792);
			expression96=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression96.Tree);
			DebugLocation(88, 40);
			char_literal97=(IToken)Match(input,44,Follow._44_in_returnstatement794); if (state.failed) return retval;

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
		DebugLocation(88, 41);
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
	// MathLang.g:90:1: funcdeclaration : TYPE ID '(' ( paramsdeclaration )? ')' block -> ^( ID ^( RETURNS TYPE ) ( paramsdeclaration )? block ) ;
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

		IToken TYPE98=null;
		IToken ID99=null;
		IToken char_literal100=null;
		IToken char_literal102=null;
		MathLangParser.paramsdeclaration_return paramsdeclaration101 = default(MathLangParser.paramsdeclaration_return);
		MathLangParser.block_return block103 = default(MathLangParser.block_return);

		object TYPE98_tree=null;
		object ID99_tree=null;
		object char_literal100_tree=null;
		object char_literal102_tree=null;
		RewriteRuleITokenStream stream_45=new RewriteRuleITokenStream(adaptor,"token 45");
		RewriteRuleITokenStream stream_46=new RewriteRuleITokenStream(adaptor,"token 46");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");
		RewriteRuleSubtreeStream stream_paramsdeclaration=new RewriteRuleSubtreeStream(adaptor,"rule paramsdeclaration");
		RewriteRuleSubtreeStream stream_block=new RewriteRuleSubtreeStream(adaptor,"rule block");
		try { DebugEnterRule(GrammarFileName, "funcdeclaration");
		DebugLocation(90, 120);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 28)) { return retval; }
			// MathLang.g:90:16: ( TYPE ID '(' ( paramsdeclaration )? ')' block -> ^( ID ^( RETURNS TYPE ) ( paramsdeclaration )? block ) )
			DebugEnterAlt(1);
			// MathLang.g:90:18: TYPE ID '(' ( paramsdeclaration )? ')' block
			{
			DebugLocation(90, 18);
			TYPE98=(IToken)Match(input,TYPE,Follow._TYPE_in_funcdeclaration803); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE98);

			DebugLocation(90, 25);
			ID99=(IToken)Match(input,ID,Follow._ID_in_funcdeclaration805); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID99);

			DebugLocation(90, 30);
			char_literal100=(IToken)Match(input,45,Follow._45_in_funcdeclaration808); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_45.Add(char_literal100);

			DebugLocation(90, 32);
			// MathLang.g:90:32: ( paramsdeclaration )?
			int alt21=2;
			try { DebugEnterSubRule(21);
			try { DebugEnterDecision(21, decisionCanBacktrack[21]);
			int LA21_0 = input.LA(1);

			if ((LA21_0==TYPE))
			{
				alt21=1;
			}
			} finally { DebugExitDecision(21); }
			switch (alt21)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: paramsdeclaration
				{
				DebugLocation(90, 32);
				PushFollow(Follow._paramsdeclaration_in_funcdeclaration811);
				paramsdeclaration101=paramsdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_paramsdeclaration.Add(paramsdeclaration101.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(21); }

			DebugLocation(90, 54);
			char_literal102=(IToken)Match(input,46,Follow._46_in_funcdeclaration814); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_46.Add(char_literal102);

			DebugLocation(90, 56);
			PushFollow(Follow._block_in_funcdeclaration817);
			block103=block();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_block.Add(block103.Tree);


			{
			// AST REWRITE
			// elements: paramsdeclaration, TYPE, ID, block
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 90:62: -> ^( ID ^( RETURNS TYPE ) ( paramsdeclaration )? block )
			{
				DebugLocation(90, 65);
				// MathLang.g:90:65: ^( ID ^( RETURNS TYPE ) ( paramsdeclaration )? block )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(90, 67);
				root_1 = (object)adaptor.BecomeRoot(stream_ID.NextNode(), root_1);

				DebugLocation(90, 70);
				// MathLang.g:90:70: ^( RETURNS TYPE )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(90, 72);
				root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(RETURNS, "RETURNS"), root_2);

				DebugLocation(90, 80);
				adaptor.AddChild(root_2, stream_TYPE.NextNode());

				adaptor.AddChild(root_1, root_2);
				}
				DebugLocation(90, 91);
				// MathLang.g:90:91: ( paramsdeclaration )?
				if ( stream_paramsdeclaration.HasNext )
				{
					DebugLocation(90, 91);
					adaptor.AddChild(root_1, stream_paramsdeclaration.NextTree());

				}
				stream_paramsdeclaration.Reset();
				DebugLocation(90, 115);
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
		DebugLocation(90, 120);
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
	// MathLang.g:91:1: paramsdeclaration : ( declarationbody ( ',' declarationbody )* ) -> ^( PARAMETERS ( declarationbody )* ) ;
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

		IToken char_literal105=null;
		MathLangParser.declarationbody_return declarationbody104 = default(MathLangParser.declarationbody_return);
		MathLangParser.declarationbody_return declarationbody106 = default(MathLangParser.declarationbody_return);

		object char_literal105_tree=null;
		RewriteRuleITokenStream stream_47=new RewriteRuleITokenStream(adaptor,"token 47");
		RewriteRuleSubtreeStream stream_declarationbody=new RewriteRuleSubtreeStream(adaptor,"rule declarationbody");
		try { DebugEnterRule(GrammarFileName, "paramsdeclaration");
		DebugLocation(91, 102);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 29)) { return retval; }
			// MathLang.g:91:18: ( ( declarationbody ( ',' declarationbody )* ) -> ^( PARAMETERS ( declarationbody )* ) )
			DebugEnterAlt(1);
			// MathLang.g:91:20: ( declarationbody ( ',' declarationbody )* )
			{
			DebugLocation(91, 20);
			// MathLang.g:91:20: ( declarationbody ( ',' declarationbody )* )
			DebugEnterAlt(1);
			// MathLang.g:91:22: declarationbody ( ',' declarationbody )*
			{
			DebugLocation(91, 22);
			PushFollow(Follow._declarationbody_in_paramsdeclaration848);
			declarationbody104=declarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declarationbody.Add(declarationbody104.Tree);
			DebugLocation(91, 38);
			// MathLang.g:91:38: ( ',' declarationbody )*
			try { DebugEnterSubRule(22);
			while (true)
			{
				int alt22=2;
				try { DebugEnterDecision(22, decisionCanBacktrack[22]);
				int LA22_0 = input.LA(1);

				if ((LA22_0==47))
				{
					alt22=1;
				}


				} finally { DebugExitDecision(22); }
				switch ( alt22 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:91:40: ',' declarationbody
					{
					DebugLocation(91, 43);
					char_literal105=(IToken)Match(input,47,Follow._47_in_paramsdeclaration852); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_47.Add(char_literal105);

					DebugLocation(91, 45);
					PushFollow(Follow._declarationbody_in_paramsdeclaration855);
					declarationbody106=declarationbody();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_declarationbody.Add(declarationbody106.Tree);

					}
					break;

				default:
					goto loop22;
				}
			}

			loop22:
				;

			} finally { DebugExitSubRule(22); }


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
			// 91:66: -> ^( PARAMETERS ( declarationbody )* )
			{
				DebugLocation(91, 69);
				// MathLang.g:91:69: ^( PARAMETERS ( declarationbody )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(91, 71);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_1);

				DebugLocation(91, 82);
				// MathLang.g:91:82: ( declarationbody )*
				while ( stream_declarationbody.HasNext )
				{
					DebugLocation(91, 84);
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
		DebugLocation(91, 102);
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
	// MathLang.g:93:1: funccallbody : ID '(' ( expressioncommalist )? ')' ;
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

		IToken ID107=null;
		IToken char_literal108=null;
		IToken char_literal110=null;
		MathLangParser.expressioncommalist_return expressioncommalist109 = default(MathLangParser.expressioncommalist_return);

		object ID107_tree=null;
		object char_literal108_tree=null;
		object char_literal110_tree=null;

		try { DebugEnterRule(GrammarFileName, "funccallbody");
		DebugLocation(93, 46);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 30)) { return retval; }
			// MathLang.g:93:13: ( ID '(' ( expressioncommalist )? ')' )
			DebugEnterAlt(1);
			// MathLang.g:93:15: ID '(' ( expressioncommalist )? ')'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(93, 17);
			ID107=(IToken)Match(input,ID,Follow._ID_in_funccallbody880); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			ID107_tree = (object)adaptor.Create(ID107);
			root_0 = (object)adaptor.BecomeRoot(ID107_tree, root_0);
			}
			DebugLocation(93, 19);
			char_literal108=(IToken)Match(input,45,Follow._45_in_funccallbody883); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal108_tree = (object)adaptor.Create(char_literal108);
			adaptor.AddChild(root_0, char_literal108_tree);
			}
			DebugLocation(93, 23);
			// MathLang.g:93:23: ( expressioncommalist )?
			int alt23=2;
			try { DebugEnterSubRule(23);
			try { DebugEnterDecision(23, decisionCanBacktrack[23]);
			int LA23_0 = input.LA(1);

			if (((LA23_0>=NUMBER && LA23_0<=CHAR)||LA23_0==SUB||(LA23_0>=NOT && LA23_0<=FALSE)||LA23_0==45))
			{
				alt23=1;
			}
			} finally { DebugExitDecision(23); }
			switch (alt23)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: expressioncommalist
				{
				DebugLocation(93, 23);
				PushFollow(Follow._expressioncommalist_in_funccallbody885);
				expressioncommalist109=expressioncommalist();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expressioncommalist109.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(23); }

			DebugLocation(93, 44);
			char_literal110=(IToken)Match(input,46,Follow._46_in_funccallbody888); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal110_tree = (object)adaptor.Create(char_literal110);
			adaptor.AddChild(root_0, char_literal110_tree);
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
		DebugLocation(93, 46);
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
	// MathLang.g:94:1: funccall : funccallbody ';' ;
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

		IToken char_literal112=null;
		MathLangParser.funccallbody_return funccallbody111 = default(MathLangParser.funccallbody_return);

		object char_literal112_tree=null;

		try { DebugEnterRule(GrammarFileName, "funccall");
		DebugLocation(94, 27);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 31)) { return retval; }
			// MathLang.g:94:9: ( funccallbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:94:11: funccallbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(94, 11);
			PushFollow(Follow._funccallbody_in_funccall894);
			funccallbody111=funccallbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody111.Tree);
			DebugLocation(94, 27);
			char_literal112=(IToken)Match(input,44,Follow._44_in_funccall896); if (state.failed) return retval;

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
		DebugLocation(94, 27);
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
	// MathLang.g:95:1: expressioncommalist : expression ( ',' expression )* -> ^( PARAMETERS ( expression )* ) ;
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

		IToken char_literal114=null;
		MathLangParser.expression_return expression113 = default(MathLangParser.expression_return);
		MathLangParser.expression_return expression115 = default(MathLangParser.expression_return);

		object char_literal114_tree=null;
		RewriteRuleITokenStream stream_47=new RewriteRuleITokenStream(adaptor,"token 47");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "expressioncommalist");
		DebugLocation(95, 83);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 32)) { return retval; }
			// MathLang.g:95:20: ( expression ( ',' expression )* -> ^( PARAMETERS ( expression )* ) )
			DebugEnterAlt(1);
			// MathLang.g:95:22: expression ( ',' expression )*
			{
			DebugLocation(95, 22);
			PushFollow(Follow._expression_in_expressioncommalist903);
			expression113=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression113.Tree);
			DebugLocation(95, 33);
			// MathLang.g:95:33: ( ',' expression )*
			try { DebugEnterSubRule(24);
			while (true)
			{
				int alt24=2;
				try { DebugEnterDecision(24, decisionCanBacktrack[24]);
				int LA24_0 = input.LA(1);

				if ((LA24_0==47))
				{
					alt24=1;
				}


				} finally { DebugExitDecision(24); }
				switch ( alt24 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:95:35: ',' expression
					{
					DebugLocation(95, 38);
					char_literal114=(IToken)Match(input,47,Follow._47_in_expressioncommalist907); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_47.Add(char_literal114);

					DebugLocation(95, 40);
					PushFollow(Follow._expression_in_expressioncommalist910);
					expression115=expression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_expression.Add(expression115.Tree);

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
			// 95:53: -> ^( PARAMETERS ( expression )* )
			{
				DebugLocation(95, 56);
				// MathLang.g:95:56: ^( PARAMETERS ( expression )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(95, 58);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_1);

				DebugLocation(95, 69);
				// MathLang.g:95:69: ( expression )*
				while ( stream_expression.HasNext )
				{
					DebugLocation(95, 70);
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
		DebugLocation(95, 83);
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
	// MathLang.g:97:1: block : '{' statementlist '}' ;
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

		IToken char_literal116=null;
		IToken char_literal118=null;
		MathLangParser.statementlist_return statementlist117 = default(MathLangParser.statementlist_return);

		object char_literal116_tree=null;
		object char_literal118_tree=null;

		try { DebugEnterRule(GrammarFileName, "block");
		DebugLocation(97, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 33)) { return retval; }
			// MathLang.g:97:6: ( '{' statementlist '}' )
			DebugEnterAlt(1);
			// MathLang.g:97:8: '{' statementlist '}'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(97, 11);
			char_literal116=(IToken)Match(input,48,Follow._48_in_block931); if (state.failed) return retval;
			DebugLocation(97, 13);
			PushFollow(Follow._statementlist_in_block934);
			statementlist117=statementlist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementlist117.Tree);
			DebugLocation(97, 30);
			char_literal118=(IToken)Match(input,49,Follow._49_in_block936); if (state.failed) return retval;

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
		DebugLocation(97, 30);
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
	// MathLang.g:99:1: statementlist : ( statement )* -> ^( BLOCK ( statement )* ) ;
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

		MathLangParser.statement_return statement119 = default(MathLangParser.statement_return);

		RewriteRuleSubtreeStream stream_statement=new RewriteRuleSubtreeStream(adaptor,"rule statement");
		try { DebugEnterRule(GrammarFileName, "statementlist");
		DebugLocation(99, 49);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 34)) { return retval; }
			// MathLang.g:99:14: ( ( statement )* -> ^( BLOCK ( statement )* ) )
			DebugEnterAlt(1);
			// MathLang.g:99:16: ( statement )*
			{
			DebugLocation(99, 16);
			// MathLang.g:99:16: ( statement )*
			try { DebugEnterSubRule(25);
			while (true)
			{
				int alt25=2;
				try { DebugEnterDecision(25, decisionCanBacktrack[25]);
				int LA25_0 = input.LA(1);

				if ((LA25_0==IF||LA25_0==FOR||(LA25_0>=RETURN && LA25_0<=WHILE)||LA25_0==ID||LA25_0==TYPE))
				{
					alt25=1;
				}


				} finally { DebugExitDecision(25); }
				switch ( alt25 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: statement
					{
					DebugLocation(99, 16);
					PushFollow(Follow._statement_in_statementlist944);
					statement119=statement();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_statement.Add(statement119.Tree);

					}
					break;

				default:
					goto loop25;
				}
			}

			loop25:
				;

			} finally { DebugExitSubRule(25); }



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
			// 99:27: -> ^( BLOCK ( statement )* )
			{
				DebugLocation(99, 30);
				// MathLang.g:99:30: ^( BLOCK ( statement )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(99, 32);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

				DebugLocation(99, 38);
				// MathLang.g:99:38: ( statement )*
				while ( stream_statement.HasNext )
				{
					DebugLocation(99, 38);
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
		DebugLocation(99, 49);
		} finally { DebugExitRule(GrammarFileName, "statementlist"); }
		return retval;

	}
	// $ANTLR end "statementlist"

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
			// MathLang.g:54:14: ( funccallbody )
			DebugEnterAlt(1);
			// MathLang.g:54:14: funccallbody
			{
			DebugLocation(54, 14);
			PushFollow(Follow._funccallbody_in_synpred11_MathLang356);
			funccallbody();
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

	partial void Enter_synpred12_MathLang_fragment();
	partial void Leave_synpred12_MathLang_fragment();

	// $ANTLR start synpred12_MathLang
	public void synpred12_MathLang_fragment()
	{
		Enter_synpred12_MathLang_fragment();
		EnterRule("synpred12_MathLang_fragment", 46);
		TraceIn("synpred12_MathLang_fragment", 46);
		try
		{
			// MathLang.g:55:6: ( boolexpression )
			DebugEnterAlt(1);
			// MathLang.g:55:6: boolexpression
			{
			DebugLocation(55, 6);
			PushFollow(Follow._boolexpression_in_synpred12_MathLang363);
			boolexpression();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred12_MathLang_fragment", 46);
			LeaveRule("synpred12_MathLang_fragment", 46);
			Leave_synpred12_MathLang_fragment();
		}
	}
	// $ANTLR end synpred12_MathLang

	partial void Enter_synpred24_MathLang_fragment();
	partial void Leave_synpred24_MathLang_fragment();

	// $ANTLR start synpred24_MathLang
	public void synpred24_MathLang_fragment()
	{
		Enter_synpred24_MathLang_fragment();
		EnterRule("synpred24_MathLang_fragment", 58);
		TraceIn("synpred24_MathLang_fragment", 58);
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
			PushFollow(Follow._add_in_synpred24_MathLang531);
			add();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred24_MathLang_fragment", 58);
			LeaveRule("synpred24_MathLang_fragment", 58);
			Leave_synpred24_MathLang_fragment();
		}
	}
	// $ANTLR end synpred24_MathLang

	partial void Enter_synpred32_MathLang_fragment();
	partial void Leave_synpred32_MathLang_fragment();

	// $ANTLR start synpred32_MathLang
	public void synpred32_MathLang_fragment()
	{
		Enter_synpred32_MathLang_fragment();
		EnterRule("synpred32_MathLang_fragment", 66);
		TraceIn("synpred32_MathLang_fragment", 66);
		try
		{
			// MathLang.g:80:22: ( '(' boolterm ')' )
			DebugEnterAlt(1);
			// MathLang.g:80:22: '(' boolterm ')'
			{
			DebugLocation(80, 22);
			Match(input,45,Follow._45_in_synpred32_MathLang658); if (state.failed) return;
			DebugLocation(80, 27);
			PushFollow(Follow._boolterm_in_synpred32_MathLang661);
			boolterm();
			PopFollow();
			if (state.failed) return;
			DebugLocation(80, 36);
			Match(input,46,Follow._46_in_synpred32_MathLang663); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred32_MathLang_fragment", 66);
			LeaveRule("synpred32_MathLang_fragment", 66);
			Leave_synpred32_MathLang_fragment();
		}
	}
	// $ANTLR end synpred32_MathLang

	partial void Enter_synpred37_MathLang_fragment();
	partial void Leave_synpred37_MathLang_fragment();

	// $ANTLR start synpred37_MathLang
	public void synpred37_MathLang_fragment()
	{
		Enter_synpred37_MathLang_fragment();
		EnterRule("synpred37_MathLang_fragment", 71);
		TraceIn("synpred37_MathLang_fragment", 71);
		try
		{
			// MathLang.g:85:64: ( ELSE ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:85:64: ELSE ( block | statement )
			{
			DebugLocation(85, 64);
			Match(input,ELSE,Follow._ELSE_in_synpred37_MathLang715); if (state.failed) return;
			DebugLocation(85, 70);
			// MathLang.g:85:70: ( block | statement )
			int alt27=2;
			try { DebugEnterSubRule(27);
			try { DebugEnterDecision(27, decisionCanBacktrack[27]);
			int LA27_0 = input.LA(1);

			if ((LA27_0==48))
			{
				alt27=1;
			}
			else if ((LA27_0==IF||LA27_0==FOR||(LA27_0>=RETURN && LA27_0<=WHILE)||LA27_0==ID||LA27_0==TYPE))
			{
				alt27=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				NoViableAltException nvae = new NoViableAltException("", 27, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(27); }
			switch (alt27)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:85:71: block
				{
				DebugLocation(85, 71);
				PushFollow(Follow._block_in_synpred37_MathLang719);
				block();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:85:79: statement
				{
				DebugLocation(85, 79);
				PushFollow(Follow._statement_in_synpred37_MathLang723);
				statement();
				PopFollow();
				if (state.failed) return;

				}
				break;

			}
			} finally { DebugExitSubRule(27); }


			}

		}
		finally
		{
			TraceOut("synpred37_MathLang_fragment", 71);
			LeaveRule("synpred37_MathLang_fragment", 71);
			Leave_synpred37_MathLang_fragment();
		}
	}
	// $ANTLR end synpred37_MathLang
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
			"\x1\x7\x1\x11\x1\x14\x4\xFFFF\x1\x14\x4\xFFFF";
		private const string DFA1_maxS =
			"\x1\x13\x1\x11\x1\x2D\x4\xFFFF\x1\x2D\x4\xFFFF";
		private const string DFA1_acceptS =
			"\x3\xFFFF\x1\x3\x1\x4\x1\x5\x1\x7\x1\xFFFF\x1\x2\x1\x8\x1\x1\x1\x6";
		private const string DFA1_specialS =
			"\xC\xFFFF}>";
		private static readonly string[] DFA1_transitionS =
			{
				"\x1\x3\x1\xFFFF\x1\x5\x1\xFFFF\x1\x6\x1\x4\x4\xFFFF\x1\x2\x1\xFFFF"+
				"\x1\x1",
				"\x1\x7",
				"\x1\x8\x18\xFFFF\x1\x9",
				"",
				"",
				"",
				"",
				"\x1\xA\x17\xFFFF\x1\xA\x1\xB",
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

	private class DFA3 : DFA
	{
		private const string DFA3_eotS =
			"\xB\xFFFF";
		private const string DFA3_eofS =
			"\xB\xFFFF";
		private const string DFA3_minS =
			"\x1\x10\x1\x0\x1\xFFFF\x1\x0\x2\xFFFF\x3\x0\x2\xFFFF";
		private const string DFA3_maxS =
			"\x1\x2D\x1\x0\x1\xFFFF\x1\x0\x2\xFFFF\x3\x0\x2\xFFFF";
		private const string DFA3_acceptS =
			"\x2\xFFFF\x1\x2\x6\xFFFF\x1\x1\x1\x3";
		private const string DFA3_specialS =
			"\x1\xFFFF\x1\x0\x1\xFFFF\x1\x1\x2\xFFFF\x1\x2\x1\x3\x1\x4\x2\xFFFF}>";
		private static readonly string[] DFA3_transitionS =
			{
				"\x1\x7\x1\x1\x1\x8\x4\xFFFF\x1\x6\xA\xFFFF\x3\x2\x8\xFFFF\x1\x3",
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

		public override string Description { get { return "54:1: expression : ( funccallbody | boolexpression | mathexpression );"; } }

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
				int LA3_1 = input.LA(1);


				int index3_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred11_MathLang_fragment)) ) {s = 9;}

				else if ( (EvaluatePredicate(synpred12_MathLang_fragment)) ) {s = 2;}

				else if ( (true) ) {s = 10;}


				input.Seek(index3_1);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA3_3 = input.LA(1);


				int index3_3 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred12_MathLang_fragment)) ) {s = 2;}

				else if ( (true) ) {s = 10;}


				input.Seek(index3_3);
				if ( s>=0 ) return s;
				break;
			case 2:
				int LA3_6 = input.LA(1);


				int index3_6 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred12_MathLang_fragment)) ) {s = 2;}

				else if ( (true) ) {s = 10;}


				input.Seek(index3_6);
				if ( s>=0 ) return s;
				break;
			case 3:
				int LA3_7 = input.LA(1);


				int index3_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred12_MathLang_fragment)) ) {s = 2;}

				else if ( (true) ) {s = 10;}


				input.Seek(index3_7);
				if ( s>=0 ) return s;
				break;
			case 4:
				int LA3_8 = input.LA(1);


				int index3_8 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred12_MathLang_fragment)) ) {s = 2;}

				else if ( (true) ) {s = 10;}


				input.Seek(index3_8);
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
		public static readonly BitSet _NUMBER_in_number323 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_number329 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_number335 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CHAR_in_number341 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _term_in_mathexpression347 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_expression356 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolexpression_in_expression363 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathexpression_in_expression370 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declarationbody_in_declaration377 = new BitSet(new ulong[]{0x100000000000UL});
		public static readonly BitSet _44_in_declaration379 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _longdeclaration_in_declaration387 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_declarationbody394 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _ID_in_declarationbody397 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _longdeclarationbody_in_longdeclaration404 = new BitSet(new ulong[]{0x100000000000UL});
		public static readonly BitSet _44_in_longdeclaration406 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_longdeclarationbody414 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _ID_in_longdeclarationbody416 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _ASSIGN_in_longdeclarationbody418 = new BitSet(new ulong[]{0x201C00870000UL});
		public static readonly BitSet _expression_in_longdeclarationbody420 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_variable442 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _ID_in_variable451 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mul_in_add458 = new BitSet(new ulong[]{0xC00002UL});
		public static readonly BitSet _set_in_add462 = new BitSet(new ulong[]{0x201C00870000UL});
		public static readonly BitSet _mul_in_add471 = new BitSet(new ulong[]{0xC00002UL});
		public static readonly BitSet _group_in_mul480 = new BitSet(new ulong[]{0x3000002UL});
		public static readonly BitSet _set_in_mul484 = new BitSet(new ulong[]{0x201C00870000UL});
		public static readonly BitSet _group_in_mul493 = new BitSet(new ulong[]{0x3000002UL});
		public static readonly BitSet _add_in_compare501 = new BitSet(new ulong[]{0xFC000002UL});
		public static readonly BitSet _set_in_compare505 = new BitSet(new ulong[]{0x201C00870000UL});
		public static readonly BitSet _add_in_compare531 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _add_in_term542 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _SUB_in_group549 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _45_in_group554 = new BitSet(new ulong[]{0x201C00870000UL});
		public static readonly BitSet _term_in_group557 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _46_in_group559 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _number_in_group564 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assignmentbody_in_assignment571 = new BitSet(new ulong[]{0x100000000000UL});
		public static readonly BitSet _44_in_assignment573 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_assignmentbody580 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _ASSIGN_in_assignmentbody582 = new BitSet(new ulong[]{0x201C00870000UL});
		public static readonly BitSet _expression_in_assignmentbody585 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolterm_in_boolexpression593 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _or_in_boolterm600 = new BitSet(new ulong[]{0x30000002UL});
		public static readonly BitSet _set_in_boolterm604 = new BitSet(new ulong[]{0x201C00870000UL});
		public static readonly BitSet _or_in_boolterm613 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _and_in_or622 = new BitSet(new ulong[]{0x100000002UL});
		public static readonly BitSet _OR_in_or625 = new BitSet(new ulong[]{0x201C00870000UL});
		public static readonly BitSet _and_in_or628 = new BitSet(new ulong[]{0x100000002UL});
		public static readonly BitSet _boolgroup_in_and636 = new BitSet(new ulong[]{0x200000002UL});
		public static readonly BitSet _AND_in_and639 = new BitSet(new ulong[]{0x201C00870000UL});
		public static readonly BitSet _boolgroup_in_and642 = new BitSet(new ulong[]{0x200000002UL});
		public static readonly BitSet _NOT_in_boolgroup651 = new BitSet(new ulong[]{0x201C00870000UL});
		public static readonly BitSet _45_in_boolgroup658 = new BitSet(new ulong[]{0x201C00870000UL});
		public static readonly BitSet _boolterm_in_boolgroup661 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _46_in_boolgroup663 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolvar_in_boolgroup668 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TRUE_in_boolvar676 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FALSE_in_boolvar682 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _compare_in_boolvar688 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_ifstatement695 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _45_in_ifstatement698 = new BitSet(new ulong[]{0x201C00870000UL});
		public static readonly BitSet _boolexpression_in_ifstatement701 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _46_in_ifstatement703 = new BitSet(new ulong[]{0x10000000A1A80UL});
		public static readonly BitSet _block_in_ifstatement707 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement711 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _ELSE_in_ifstatement715 = new BitSet(new ulong[]{0x10000000A1A80UL});
		public static readonly BitSet _block_in_ifstatement719 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement723 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _WHILE_in_whilestatement733 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _45_in_whilestatement736 = new BitSet(new ulong[]{0x201C00870000UL});
		public static readonly BitSet _boolexpression_in_whilestatement739 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _46_in_whilestatement741 = new BitSet(new ulong[]{0x10000000A1A80UL});
		public static readonly BitSet _block_in_whilestatement745 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_whilestatement749 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_forstatement756 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _45_in_forstatement759 = new BitSet(new ulong[]{0x80000UL});
		public static readonly BitSet _longdeclarationbody_in_forstatement762 = new BitSet(new ulong[]{0x100000000000UL});
		public static readonly BitSet _44_in_forstatement764 = new BitSet(new ulong[]{0x201C00870000UL});
		public static readonly BitSet _boolexpression_in_forstatement767 = new BitSet(new ulong[]{0x100000000000UL});
		public static readonly BitSet _44_in_forstatement769 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _assignmentbody_in_forstatement772 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _46_in_forstatement774 = new BitSet(new ulong[]{0x10000000A1A80UL});
		public static readonly BitSet _block_in_forstatement778 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_forstatement782 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _RETURN_in_returnstatement789 = new BitSet(new ulong[]{0x201C00870000UL});
		public static readonly BitSet _expression_in_returnstatement792 = new BitSet(new ulong[]{0x100000000000UL});
		public static readonly BitSet _44_in_returnstatement794 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_funcdeclaration803 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _ID_in_funcdeclaration805 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _45_in_funcdeclaration808 = new BitSet(new ulong[]{0x400000080000UL});
		public static readonly BitSet _paramsdeclaration_in_funcdeclaration811 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _46_in_funcdeclaration814 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _block_in_funcdeclaration817 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declarationbody_in_paramsdeclaration848 = new BitSet(new ulong[]{0x800000000002UL});
		public static readonly BitSet _47_in_paramsdeclaration852 = new BitSet(new ulong[]{0x80000UL});
		public static readonly BitSet _declarationbody_in_paramsdeclaration855 = new BitSet(new ulong[]{0x800000000002UL});
		public static readonly BitSet _ID_in_funccallbody880 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _45_in_funccallbody883 = new BitSet(new ulong[]{0x601C00870000UL});
		public static readonly BitSet _expressioncommalist_in_funccallbody885 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _46_in_funccallbody888 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_funccall894 = new BitSet(new ulong[]{0x100000000000UL});
		public static readonly BitSet _44_in_funccall896 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_expressioncommalist903 = new BitSet(new ulong[]{0x800000000002UL});
		public static readonly BitSet _47_in_expressioncommalist907 = new BitSet(new ulong[]{0x201C00870000UL});
		public static readonly BitSet _expression_in_expressioncommalist910 = new BitSet(new ulong[]{0x800000000002UL});
		public static readonly BitSet _48_in_block931 = new BitSet(new ulong[]{0x30000000A1A80UL});
		public static readonly BitSet _statementlist_in_block934 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _49_in_block936 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_statementlist944 = new BitSet(new ulong[]{0x10000000A1A82UL});
		public static readonly BitSet _funccallbody_in_synpred11_MathLang356 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolexpression_in_synpred12_MathLang363 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_synpred24_MathLang505 = new BitSet(new ulong[]{0x201C00870000UL});
		public static readonly BitSet _add_in_synpred24_MathLang531 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _45_in_synpred32_MathLang658 = new BitSet(new ulong[]{0x201C00870000UL});
		public static readonly BitSet _boolterm_in_synpred32_MathLang661 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _46_in_synpred32_MathLang663 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ELSE_in_synpred37_MathLang715 = new BitSet(new ulong[]{0x10000000A1A80UL});
		public static readonly BitSet _block_in_synpred37_MathLang719 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_synpred37_MathLang723 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  MathLang 

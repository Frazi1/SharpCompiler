// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-10-02 16:08:26

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "UNKNOWN", "PRINT", "INPUT", "IF", "ELSE", "FOR", "FUNCTION", "RETURN", "WHILE", "BLOCK", "PROGRAM", "PARAMS", "VARDECLARATION", "FUNCDECLARATION", "VARASSIGNMENT", "NUMBER", "ID", "CHAR", "TYPE", "ASSIGN", "ADD", "SUB", "MUL", "DIV", "GREQ", "LSEQ", "NEQ", "EQ", "GR", "LS", "OR", "AND", "NOT", "TRUE", "FALSE", "KEYWORD_NEW", "TYPEDEF", "ARRAY", "ACCESS_MODIFIER", "RETURNS", "PARAMETERS", "WS", "SL_COMMENT", "ML_COMMENT", "';'", "'('", "')'", "','", "'['", "']'", "'{'", "'}'"
	};
	public const int EOF=-1;
	public const int T__48=48;
	public const int T__49=49;
	public const int T__50=50;
	public const int T__51=51;
	public const int T__52=52;
	public const int T__53=53;
	public const int T__54=54;
	public const int T__55=55;
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
	public const int KEYWORD_NEW=39;
	public const int TYPEDEF=40;
	public const int ARRAY=41;
	public const int ACCESS_MODIFIER=42;
	public const int RETURNS=43;
	public const int PARAMETERS=44;
	public const int WS=45;
	public const int SL_COMMENT=46;
	public const int ML_COMMENT=47;

	// delegates
	// delegators

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, true, false, false, false, true, false, false, false, 
				false, false, false, true, false, false, false, true, false, false, 
				false, false, false, false, false, false, false, , false, 
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
		this.state.ruleMemo = new System.Collections.Generic.Dictionary<int, int>[80+1];

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

				if ((LA2_2==49))
				{
					alt2=3;
				}
				else if ((LA2_2==EOF||(LA2_2>=ADD && LA2_2<=AND)||LA2_2==48||(LA2_2>=50 && LA2_2<=51)||LA2_2==53||LA2_2==55))
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
	// MathLang.g:57:1: expression : ( newexpression | funccallbody | boolexpression | mathexpression );
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
		MathLangParser.funccallbody_return funccallbody17 = default(MathLangParser.funccallbody_return);
		MathLangParser.boolexpression_return boolexpression18 = default(MathLangParser.boolexpression_return);
		MathLangParser.mathexpression_return mathexpression19 = default(MathLangParser.mathexpression_return);


		try { DebugEnterRule(GrammarFileName, "expression");
		DebugLocation(57, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 5)) { return retval; }
			// MathLang.g:57:11: ( newexpression | funccallbody | boolexpression | mathexpression )
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
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:59:6: funccallbody
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(59, 6);
				PushFollow(Follow._funccallbody_in_expression395);
				funccallbody17=funccallbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody17.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:60:6: boolexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(60, 6);
				PushFollow(Follow._boolexpression_in_expression402);
				boolexpression18=boolexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression18.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:61:6: mathexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(61, 6);
				PushFollow(Follow._mathexpression_in_expression409);
				mathexpression19=mathexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mathexpression19.Tree);

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
		DebugLocation(62, 0);
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
	// MathLang.g:64:1: declaration : ( declarationbody ';' | longdeclaration );
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

		IToken char_literal21=null;
		MathLangParser.declarationbody_return declarationbody20 = default(MathLangParser.declarationbody_return);
		MathLangParser.longdeclaration_return longdeclaration22 = default(MathLangParser.longdeclaration_return);

		object char_literal21_tree=null;

		try { DebugEnterRule(GrammarFileName, "declaration");
		DebugLocation(64, 20);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 6)) { return retval; }
			// MathLang.g:64:12: ( declarationbody ';' | longdeclaration )
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
					else if ((LA4_2==48))
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
				// MathLang.g:64:14: declarationbody ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(64, 14);
				PushFollow(Follow._declarationbody_in_declaration417);
				declarationbody20=declarationbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, declarationbody20.Tree);
				DebugLocation(64, 33);
				char_literal21=(IToken)Match(input,48,Follow._48_in_declaration419); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:65:6: longdeclaration
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(65, 6);
				PushFollow(Follow._longdeclaration_in_declaration427);
				longdeclaration22=longdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclaration22.Tree);

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
		DebugLocation(65, 20);
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
	// MathLang.g:67:1: declarationbody : TYPE ID -> ^( VARDECLARATION TYPE ID ) ;
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

		IToken TYPE23=null;
		IToken ID24=null;

		object TYPE23_tree=null;
		object ID24_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");

		try { DebugEnterRule(GrammarFileName, "declarationbody");
		DebugLocation(67, 54);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 7)) { return retval; }
			// MathLang.g:67:16: ( TYPE ID -> ^( VARDECLARATION TYPE ID ) )
			DebugEnterAlt(1);
			// MathLang.g:67:18: TYPE ID
			{
			DebugLocation(67, 18);
			TYPE23=(IToken)Match(input,TYPE,Follow._TYPE_in_declarationbody434); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE23);

			DebugLocation(67, 23);
			ID24=(IToken)Match(input,ID,Follow._ID_in_declarationbody436); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID24);



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
			// 67:26: -> ^( VARDECLARATION TYPE ID )
			{
				DebugLocation(67, 29);
				// MathLang.g:67:29: ^( VARDECLARATION TYPE ID )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(67, 31);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDECLARATION, "VARDECLARATION"), root_1);

				DebugLocation(67, 46);
				adaptor.AddChild(root_1, stream_TYPE.NextNode());
				DebugLocation(67, 51);
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
		DebugLocation(67, 54);
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
	// MathLang.g:68:1: longdeclaration : longdeclarationbody ';' ;
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

		IToken char_literal26=null;
		MathLangParser.longdeclarationbody_return longdeclarationbody25 = default(MathLangParser.longdeclarationbody_return);

		object char_literal26_tree=null;

		try { DebugEnterRule(GrammarFileName, "longdeclaration");
		DebugLocation(68, 42);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 8)) { return retval; }
			// MathLang.g:68:16: ( longdeclarationbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:68:18: longdeclarationbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(68, 18);
			PushFollow(Follow._longdeclarationbody_in_longdeclaration453);
			longdeclarationbody25=longdeclarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclarationbody25.Tree);
			DebugLocation(68, 41);
			char_literal26=(IToken)Match(input,48,Follow._48_in_longdeclaration455); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(68, 42);
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
	// MathLang.g:69:1: longdeclarationbody : TYPE ID ASSIGN expression -> ^( VARDECLARATION TYPE ID expression ) ;
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
		DebugLocation(69, 87);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 9)) { return retval; }
			// MathLang.g:69:20: ( TYPE ID ASSIGN expression -> ^( VARDECLARATION TYPE ID expression ) )
			DebugEnterAlt(1);
			// MathLang.g:69:22: TYPE ID ASSIGN expression
			{
			DebugLocation(69, 22);
			TYPE27=(IToken)Match(input,TYPE,Follow._TYPE_in_longdeclarationbody463); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE27);

			DebugLocation(69, 27);
			ID28=(IToken)Match(input,ID,Follow._ID_in_longdeclarationbody465); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID28);

			DebugLocation(69, 30);
			ASSIGN29=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclarationbody467); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN29);

			DebugLocation(69, 37);
			PushFollow(Follow._expression_in_longdeclarationbody469);
			expression30=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression30.Tree);


			{
			// AST REWRITE
			// elements: ID, TYPE, expression
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 69:48: -> ^( VARDECLARATION TYPE ID expression )
			{
				DebugLocation(69, 51);
				// MathLang.g:69:51: ^( VARDECLARATION TYPE ID expression )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(69, 53);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDECLARATION, "VARDECLARATION"), root_1);

				DebugLocation(69, 68);
				adaptor.AddChild(root_1, stream_TYPE.NextNode());
				DebugLocation(69, 73);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(69, 76);
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
		DebugLocation(69, 87);
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
	// MathLang.g:71:1: add : mul ( ( ADD | SUB ) mul )* ;
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

		IToken set32=null;
		MathLangParser.mul_return mul31 = default(MathLangParser.mul_return);
		MathLangParser.mul_return mul33 = default(MathLangParser.mul_return);

		object set32_tree=null;

		try { DebugEnterRule(GrammarFileName, "add");
		DebugLocation(71, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 10)) { return retval; }
			// MathLang.g:71:4: ( mul ( ( ADD | SUB ) mul )* )
			DebugEnterAlt(1);
			// MathLang.g:71:6: mul ( ( ADD | SUB ) mul )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(71, 6);
			PushFollow(Follow._mul_in_add489);
			mul31=mul();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul31.Tree);
			DebugLocation(71, 10);
			// MathLang.g:71:10: ( ( ADD | SUB ) mul )*
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
					// MathLang.g:71:12: ( ADD | SUB ) mul
					{
					DebugLocation(71, 12);
					set32=(IToken)input.LT(1);
					set32=(IToken)input.LT(1);
					if ((input.LA(1)>=ADD && input.LA(1)<=SUB))
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

					DebugLocation(71, 25);
					PushFollow(Follow._mul_in_add502);
					mul33=mul();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul33.Tree);

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
			TraceOut("add", 10);
			LeaveRule("add", 10);
			Leave_add();
			if (state.backtracking > 0) { Memoize(input, 10, add_StartIndex); }
		}
		DebugLocation(71, 30);
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
	// MathLang.g:72:1: mul : group ( ( MUL | DIV ) group )* ;
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

		IToken set35=null;
		MathLangParser.group_return group34 = default(MathLangParser.group_return);
		MathLangParser.group_return group36 = default(MathLangParser.group_return);

		object set35_tree=null;

		try { DebugEnterRule(GrammarFileName, "mul");
		DebugLocation(72, 33);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 11)) { return retval; }
			// MathLang.g:72:4: ( group ( ( MUL | DIV ) group )* )
			DebugEnterAlt(1);
			// MathLang.g:72:6: group ( ( MUL | DIV ) group )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(72, 6);
			PushFollow(Follow._group_in_mul511);
			group34=group();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group34.Tree);
			DebugLocation(72, 12);
			// MathLang.g:72:12: ( ( MUL | DIV ) group )*
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
					// MathLang.g:72:14: ( MUL | DIV ) group
					{
					DebugLocation(72, 14);
					set35=(IToken)input.LT(1);
					set35=(IToken)input.LT(1);
					if ((input.LA(1)>=MUL && input.LA(1)<=DIV))
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

					DebugLocation(72, 27);
					PushFollow(Follow._group_in_mul524);
					group36=group();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group36.Tree);

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
			TraceOut("mul", 11);
			LeaveRule("mul", 11);
			Leave_mul();
			if (state.backtracking > 0) { Memoize(input, 11, mul_StartIndex); }
		}
		DebugLocation(72, 33);
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
	// MathLang.g:73:1: compare : add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )? ;
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

		IToken set38=null;
		MathLangParser.add_return add37 = default(MathLangParser.add_return);
		MathLangParser.add_return add39 = default(MathLangParser.add_return);

		object set38_tree=null;

		try { DebugEnterRule(GrammarFileName, "compare");
		DebugLocation(73, 60);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 12)) { return retval; }
			// MathLang.g:73:8: ( add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )? )
			DebugEnterAlt(1);
			// MathLang.g:73:10: add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(73, 10);
			PushFollow(Follow._add_in_compare532);
			add37=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add37.Tree);
			DebugLocation(73, 14);
			// MathLang.g:73:14: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
			int alt7=2;
			try { DebugEnterSubRule(7);
			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
			try
			{
				alt7 = dfa7.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(7); }
			switch (alt7)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:73:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
				{
				DebugLocation(73, 16);
				set38=(IToken)input.LT(1);
				set38=(IToken)input.LT(1);
				if ((input.LA(1)>=GREQ && input.LA(1)<=LS))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set38), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(73, 53);
				PushFollow(Follow._add_in_compare562);
				add39=add();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add39.Tree);

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
			TraceOut("compare", 12);
			LeaveRule("compare", 12);
			Leave_compare();
			if (state.backtracking > 0) { Memoize(input, 12, compare_StartIndex); }
		}
		DebugLocation(73, 60);
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
	// MathLang.g:74:1: term : add ;
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

		MathLangParser.add_return add40 = default(MathLangParser.add_return);


		try { DebugEnterRule(GrammarFileName, "term");
		DebugLocation(74, 9);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 13)) { return retval; }
			// MathLang.g:74:5: ( add )
			DebugEnterAlt(1);
			// MathLang.g:74:7: add
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(74, 7);
			PushFollow(Follow._add_in_term573);
			add40=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add40.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(74, 9);
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
	// MathLang.g:75:1: group : ( ( SUB )? '(' term ')' | number );
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

		IToken SUB41=null;
		IToken char_literal42=null;
		IToken char_literal44=null;
		MathLangParser.term_return term43 = default(MathLangParser.term_return);
		MathLangParser.number_return number45 = default(MathLangParser.number_return);

		object SUB41_tree=null;
		object char_literal42_tree=null;
		object char_literal44_tree=null;

		try { DebugEnterRule(GrammarFileName, "group");
		DebugLocation(75, 38);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 14)) { return retval; }
			// MathLang.g:75:6: ( ( SUB )? '(' term ')' | number )
			int alt9=2;
			try { DebugEnterDecision(9, decisionCanBacktrack[9]);
			int LA9_0 = input.LA(1);

			if ((LA9_0==SUB||LA9_0==49))
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
				// MathLang.g:75:8: ( SUB )? '(' term ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(75, 8);
				// MathLang.g:75:8: ( SUB )?
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
					// MathLang.g:75:9: SUB
					{
					DebugLocation(75, 12);
					SUB41=(IToken)Match(input,SUB,Follow._SUB_in_group580); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					SUB41_tree = (object)adaptor.Create(SUB41);
					root_0 = (object)adaptor.BecomeRoot(SUB41_tree, root_0);
					}

					}
					break;

				}
				} finally { DebugExitSubRule(8); }

				DebugLocation(75, 19);
				char_literal42=(IToken)Match(input,49,Follow._49_in_group585); if (state.failed) return retval;
				DebugLocation(75, 21);
				PushFollow(Follow._term_in_group588);
				term43=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term43.Tree);
				DebugLocation(75, 29);
				char_literal44=(IToken)Match(input,50,Follow._50_in_group590); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:75:33: number
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(75, 33);
				PushFollow(Follow._number_in_group595);
				number45=number();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, number45.Tree);

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
		DebugLocation(75, 38);
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
	// MathLang.g:77:1: assignment : assignmentbody ';' ;
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

		IToken char_literal47=null;
		MathLangParser.assignmentbody_return assignmentbody46 = default(MathLangParser.assignmentbody_return);

		object char_literal47_tree=null;

		try { DebugEnterRule(GrammarFileName, "assignment");
		DebugLocation(77, 31);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 15)) { return retval; }
			// MathLang.g:77:11: ( assignmentbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:77:13: assignmentbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(77, 13);
			PushFollow(Follow._assignmentbody_in_assignment602);
			assignmentbody46=assignmentbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentbody46.Tree);
			DebugLocation(77, 31);
			char_literal47=(IToken)Match(input,48,Follow._48_in_assignment604); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(77, 31);
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
	// MathLang.g:78:1: assignmentbody : ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) ;
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

		IToken ID48=null;
		IToken ASSIGN49=null;
		MathLangParser.expression_return expression50 = default(MathLangParser.expression_return);

		object ID48_tree=null;
		object ASSIGN49_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "assignmentbody");
		DebugLocation(78, 70);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 16)) { return retval; }
			// MathLang.g:78:15: ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) )
			DebugEnterAlt(1);
			// MathLang.g:78:17: ID ASSIGN expression
			{
			DebugLocation(78, 17);
			ID48=(IToken)Match(input,ID,Follow._ID_in_assignmentbody611); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID48);

			DebugLocation(78, 20);
			ASSIGN49=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignmentbody613); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN49);

			DebugLocation(78, 27);
			PushFollow(Follow._expression_in_assignmentbody615);
			expression50=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression50.Tree);


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
			// 78:38: -> ^( VARASSIGNMENT ID expression )
			{
				DebugLocation(78, 41);
				// MathLang.g:78:41: ^( VARASSIGNMENT ID expression )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(78, 43);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARASSIGNMENT, "VARASSIGNMENT"), root_1);

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

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(78, 70);
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
	// MathLang.g:80:1: boolexpression : boolterm ;
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

		MathLangParser.boolterm_return boolterm51 = default(MathLangParser.boolterm_return);


		try { DebugEnterRule(GrammarFileName, "boolexpression");
		DebugLocation(80, 25);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 17)) { return retval; }
			// MathLang.g:80:15: ( boolterm )
			DebugEnterAlt(1);
			// MathLang.g:80:17: boolterm
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(80, 17);
			PushFollow(Follow._boolterm_in_boolexpression632);
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
			TraceOut("boolexpression", 17);
			LeaveRule("boolexpression", 17);
			Leave_boolexpression();
			if (state.backtracking > 0) { Memoize(input, 17, boolexpression_StartIndex); }
		}
		DebugLocation(80, 25);
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
	// MathLang.g:81:1: boolterm : or ( ( EQ | NEQ ) or )? ;
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

		IToken set53=null;
		MathLangParser.or_return or52 = default(MathLangParser.or_return);
		MathLangParser.or_return or54 = default(MathLangParser.or_return);

		object set53_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolterm");
		DebugLocation(81, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 18)) { return retval; }
			// MathLang.g:81:9: ( or ( ( EQ | NEQ ) or )? )
			DebugEnterAlt(1);
			// MathLang.g:81:11: or ( ( EQ | NEQ ) or )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(81, 11);
			PushFollow(Follow._or_in_boolterm639);
			or52=or();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or52.Tree);
			DebugLocation(81, 14);
			// MathLang.g:81:14: ( ( EQ | NEQ ) or )?
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
				// MathLang.g:81:16: ( EQ | NEQ ) or
				{
				DebugLocation(81, 16);
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

				DebugLocation(81, 28);
				PushFollow(Follow._or_in_boolterm652);
				or54=or();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or54.Tree);

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
			TraceOut("boolterm", 18);
			LeaveRule("boolterm", 18);
			Leave_boolterm();
			if (state.backtracking > 0) { Memoize(input, 18, boolterm_StartIndex); }
		}
		DebugLocation(81, 32);
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
	// MathLang.g:82:1: or : and ( OR and )* ;
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

		IToken OR56=null;
		MathLangParser.and_return and55 = default(MathLangParser.and_return);
		MathLangParser.and_return and57 = default(MathLangParser.and_return);

		object OR56_tree=null;

		try { DebugEnterRule(GrammarFileName, "or");
		DebugLocation(82, 18);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 19)) { return retval; }
			// MathLang.g:82:3: ( and ( OR and )* )
			DebugEnterAlt(1);
			// MathLang.g:82:5: and ( OR and )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(82, 5);
			PushFollow(Follow._and_in_or661);
			and55=and();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and55.Tree);
			DebugLocation(82, 9);
			// MathLang.g:82:9: ( OR and )*
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
					// MathLang.g:82:10: OR and
					{
					DebugLocation(82, 12);
					OR56=(IToken)Match(input,OR,Follow._OR_in_or664); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR56_tree = (object)adaptor.Create(OR56);
					root_0 = (object)adaptor.BecomeRoot(OR56_tree, root_0);
					}
					DebugLocation(82, 14);
					PushFollow(Follow._and_in_or667);
					and57=and();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and57.Tree);

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
			TraceOut("or", 19);
			LeaveRule("or", 19);
			Leave_or();
			if (state.backtracking > 0) { Memoize(input, 19, or_StartIndex); }
		}
		DebugLocation(82, 18);
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
	// MathLang.g:83:1: and : boolgroup ( AND boolgroup )* ;
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

		IToken AND59=null;
		MathLangParser.boolgroup_return boolgroup58 = default(MathLangParser.boolgroup_return);
		MathLangParser.boolgroup_return boolgroup60 = default(MathLangParser.boolgroup_return);

		object AND59_tree=null;

		try { DebugEnterRule(GrammarFileName, "and");
		DebugLocation(83, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 20)) { return retval; }
			// MathLang.g:83:4: ( boolgroup ( AND boolgroup )* )
			DebugEnterAlt(1);
			// MathLang.g:83:6: boolgroup ( AND boolgroup )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(83, 6);
			PushFollow(Follow._boolgroup_in_and675);
			boolgroup58=boolgroup();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup58.Tree);
			DebugLocation(83, 16);
			// MathLang.g:83:16: ( AND boolgroup )*
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
					// MathLang.g:83:17: AND boolgroup
					{
					DebugLocation(83, 20);
					AND59=(IToken)Match(input,AND,Follow._AND_in_and678); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND59_tree = (object)adaptor.Create(AND59);
					root_0 = (object)adaptor.BecomeRoot(AND59_tree, root_0);
					}
					DebugLocation(83, 22);
					PushFollow(Follow._boolgroup_in_and681);
					boolgroup60=boolgroup();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup60.Tree);

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
			TraceOut("and", 20);
			LeaveRule("and", 20);
			Leave_and();
			if (state.backtracking > 0) { Memoize(input, 20, and_StartIndex); }
		}
		DebugLocation(83, 32);
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
	// MathLang.g:84:1: boolgroup : ( NOT )? ( '(' boolterm ')' | boolvar ) ;
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

		IToken NOT61=null;
		IToken char_literal62=null;
		IToken char_literal64=null;
		MathLangParser.boolterm_return boolterm63 = default(MathLangParser.boolterm_return);
		MathLangParser.boolvar_return boolvar65 = default(MathLangParser.boolvar_return);

		object NOT61_tree=null;
		object char_literal62_tree=null;
		object char_literal64_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolgroup");
		DebugLocation(84, 51);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 21)) { return retval; }
			// MathLang.g:84:10: ( ( NOT )? ( '(' boolterm ')' | boolvar ) )
			DebugEnterAlt(1);
			// MathLang.g:84:12: ( NOT )? ( '(' boolterm ')' | boolvar )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(84, 12);
			// MathLang.g:84:12: ( NOT )?
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
				// MathLang.g:84:13: NOT
				{
				DebugLocation(84, 16);
				NOT61=(IToken)Match(input,NOT,Follow._NOT_in_boolgroup690); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				NOT61_tree = (object)adaptor.Create(NOT61);
				root_0 = (object)adaptor.BecomeRoot(NOT61_tree, root_0);
				}

				}
				break;

			}
			} finally { DebugExitSubRule(13); }

			DebugLocation(84, 20);
			// MathLang.g:84:20: ( '(' boolterm ')' | boolvar )
			int alt14=2;
			try { DebugEnterSubRule(14);
			try { DebugEnterDecision(14, decisionCanBacktrack[14]);
			int LA14_0 = input.LA(1);

			if ((LA14_0==49))
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
				// MathLang.g:84:22: '(' boolterm ')'
				{
				DebugLocation(84, 25);
				char_literal62=(IToken)Match(input,49,Follow._49_in_boolgroup697); if (state.failed) return retval;
				DebugLocation(84, 27);
				PushFollow(Follow._boolterm_in_boolgroup700);
				boolterm63=boolterm();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm63.Tree);
				DebugLocation(84, 39);
				char_literal64=(IToken)Match(input,50,Follow._50_in_boolgroup702); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:84:43: boolvar
				{
				DebugLocation(84, 43);
				PushFollow(Follow._boolvar_in_boolgroup707);
				boolvar65=boolvar();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolvar65.Tree);

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
			TraceOut("boolgroup", 21);
			LeaveRule("boolgroup", 21);
			Leave_boolgroup();
			if (state.backtracking > 0) { Memoize(input, 21, boolgroup_StartIndex); }
		}
		DebugLocation(84, 51);
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
	// MathLang.g:85:1: boolvar : ( TRUE | FALSE | compare );
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

		IToken TRUE66=null;
		IToken FALSE67=null;
		MathLangParser.compare_return compare68 = default(MathLangParser.compare_return);

		object TRUE66_tree=null;
		object FALSE67_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolvar");
		DebugLocation(85, 11);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 22)) { return retval; }
			// MathLang.g:85:8: ( TRUE | FALSE | compare )
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
			case 49:
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
				// MathLang.g:85:10: TRUE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(85, 10);
				TRUE66=(IToken)Match(input,TRUE,Follow._TRUE_in_boolvar715); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				TRUE66_tree = (object)adaptor.Create(TRUE66);
				adaptor.AddChild(root_0, TRUE66_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:86:5: FALSE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(86, 5);
				FALSE67=(IToken)Match(input,FALSE,Follow._FALSE_in_boolvar721); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				FALSE67_tree = (object)adaptor.Create(FALSE67);
				adaptor.AddChild(root_0, FALSE67_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:87:5: compare
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(87, 5);
				PushFollow(Follow._compare_in_boolvar727);
				compare68=compare();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare68.Tree);

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
		DebugLocation(87, 11);
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
	// MathLang.g:89:1: ifstatement : IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )* ;
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

		IToken IF69=null;
		IToken char_literal70=null;
		IToken char_literal72=null;
		IToken ELSE75=null;
		MathLangParser.boolexpression_return boolexpression71 = default(MathLangParser.boolexpression_return);
		MathLangParser.block_return block73 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement74 = default(MathLangParser.statement_return);
		MathLangParser.block_return block76 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement77 = default(MathLangParser.statement_return);

		object IF69_tree=null;
		object char_literal70_tree=null;
		object char_literal72_tree=null;
		object ELSE75_tree=null;

		try { DebugEnterRule(GrammarFileName, "ifstatement");
		DebugLocation(89, 91);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 23)) { return retval; }
			// MathLang.g:89:12: ( IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )* )
			DebugEnterAlt(1);
			// MathLang.g:89:14: IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(89, 16);
			IF69=(IToken)Match(input,IF,Follow._IF_in_ifstatement734); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			IF69_tree = (object)adaptor.Create(IF69);
			root_0 = (object)adaptor.BecomeRoot(IF69_tree, root_0);
			}
			DebugLocation(89, 21);
			char_literal70=(IToken)Match(input,49,Follow._49_in_ifstatement737); if (state.failed) return retval;
			DebugLocation(89, 23);
			PushFollow(Follow._boolexpression_in_ifstatement740);
			boolexpression71=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression71.Tree);
			DebugLocation(89, 41);
			char_literal72=(IToken)Match(input,50,Follow._50_in_ifstatement742); if (state.failed) return retval;
			DebugLocation(89, 43);
			// MathLang.g:89:43: ( block | statement )
			int alt16=2;
			try { DebugEnterSubRule(16);
			try { DebugEnterDecision(16, decisionCanBacktrack[16]);
			int LA16_0 = input.LA(1);

			if ((LA16_0==54))
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
				// MathLang.g:89:44: block
				{
				DebugLocation(89, 44);
				PushFollow(Follow._block_in_ifstatement746);
				block73=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block73.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:89:52: statement
				{
				DebugLocation(89, 52);
				PushFollow(Follow._statement_in_ifstatement750);
				statement74=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement74.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(16); }

			DebugLocation(89, 63);
			// MathLang.g:89:63: ( ELSE ( block | statement ) )*
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
					// MathLang.g:89:64: ELSE ( block | statement )
					{
					DebugLocation(89, 68);
					ELSE75=(IToken)Match(input,ELSE,Follow._ELSE_in_ifstatement754); if (state.failed) return retval;
					DebugLocation(89, 70);
					// MathLang.g:89:70: ( block | statement )
					int alt17=2;
					try { DebugEnterSubRule(17);
					try { DebugEnterDecision(17, decisionCanBacktrack[17]);
					int LA17_0 = input.LA(1);

					if ((LA17_0==54))
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
						// MathLang.g:89:71: block
						{
						DebugLocation(89, 71);
						PushFollow(Follow._block_in_ifstatement758);
						block76=block();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block76.Tree);

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// MathLang.g:89:79: statement
						{
						DebugLocation(89, 79);
						PushFollow(Follow._statement_in_ifstatement762);
						statement77=statement();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement77.Tree);

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
			TraceOut("ifstatement", 23);
			LeaveRule("ifstatement", 23);
			Leave_ifstatement();
			if (state.backtracking > 0) { Memoize(input, 23, ifstatement_StartIndex); }
		}
		DebugLocation(89, 91);
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
	// MathLang.g:90:1: whilestatement : WHILE '(' boolexpression ')' ( block | statement ) ;
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

		IToken WHILE78=null;
		IToken char_literal79=null;
		IToken char_literal81=null;
		MathLangParser.boolexpression_return boolexpression80 = default(MathLangParser.boolexpression_return);
		MathLangParser.block_return block82 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement83 = default(MathLangParser.statement_return);

		object WHILE78_tree=null;
		object char_literal79_tree=null;
		object char_literal81_tree=null;

		try { DebugEnterRule(GrammarFileName, "whilestatement");
		DebugLocation(90, 67);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 24)) { return retval; }
			// MathLang.g:90:15: ( WHILE '(' boolexpression ')' ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:90:17: WHILE '(' boolexpression ')' ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(90, 22);
			WHILE78=(IToken)Match(input,WHILE,Follow._WHILE_in_whilestatement772); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			WHILE78_tree = (object)adaptor.Create(WHILE78);
			root_0 = (object)adaptor.BecomeRoot(WHILE78_tree, root_0);
			}
			DebugLocation(90, 27);
			char_literal79=(IToken)Match(input,49,Follow._49_in_whilestatement775); if (state.failed) return retval;
			DebugLocation(90, 29);
			PushFollow(Follow._boolexpression_in_whilestatement778);
			boolexpression80=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression80.Tree);
			DebugLocation(90, 47);
			char_literal81=(IToken)Match(input,50,Follow._50_in_whilestatement780); if (state.failed) return retval;
			DebugLocation(90, 49);
			// MathLang.g:90:49: ( block | statement )
			int alt19=2;
			try { DebugEnterSubRule(19);
			try { DebugEnterDecision(19, decisionCanBacktrack[19]);
			int LA19_0 = input.LA(1);

			if ((LA19_0==54))
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
				// MathLang.g:90:50: block
				{
				DebugLocation(90, 50);
				PushFollow(Follow._block_in_whilestatement784);
				block82=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block82.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:90:58: statement
				{
				DebugLocation(90, 58);
				PushFollow(Follow._statement_in_whilestatement788);
				statement83=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement83.Tree);

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
			TraceOut("whilestatement", 24);
			LeaveRule("whilestatement", 24);
			Leave_whilestatement();
			if (state.backtracking > 0) { Memoize(input, 24, whilestatement_StartIndex); }
		}
		DebugLocation(90, 67);
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
		EnterRule("forstatement", 25);
		TraceIn("forstatement", 25);
		MathLangParser.forstatement_return retval = new MathLangParser.forstatement_return();
		retval.Start = (IToken)input.LT(1);
		int forstatement_StartIndex = input.Index;
		object root_0 = null;

		IToken FOR84=null;
		IToken char_literal85=null;
		IToken char_literal87=null;
		IToken char_literal89=null;
		IToken char_literal91=null;
		MathLangParser.longdeclarationbody_return longdeclarationbody86 = default(MathLangParser.longdeclarationbody_return);
		MathLangParser.boolexpression_return boolexpression88 = default(MathLangParser.boolexpression_return);
		MathLangParser.assignmentbody_return assignmentbody90 = default(MathLangParser.assignmentbody_return);
		MathLangParser.block_return block92 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement93 = default(MathLangParser.statement_return);

		object FOR84_tree=null;
		object char_literal85_tree=null;
		object char_literal87_tree=null;
		object char_literal89_tree=null;
		object char_literal91_tree=null;

		try { DebugEnterRule(GrammarFileName, "forstatement");
		DebugLocation(91, 108);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 25)) { return retval; }
			// MathLang.g:91:13: ( FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:91:15: FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(91, 18);
			FOR84=(IToken)Match(input,FOR,Follow._FOR_in_forstatement795); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			FOR84_tree = (object)adaptor.Create(FOR84);
			root_0 = (object)adaptor.BecomeRoot(FOR84_tree, root_0);
			}
			DebugLocation(91, 23);
			char_literal85=(IToken)Match(input,49,Follow._49_in_forstatement798); if (state.failed) return retval;
			DebugLocation(91, 25);
			PushFollow(Follow._longdeclarationbody_in_forstatement801);
			longdeclarationbody86=longdeclarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclarationbody86.Tree);
			DebugLocation(91, 48);
			char_literal87=(IToken)Match(input,48,Follow._48_in_forstatement803); if (state.failed) return retval;
			DebugLocation(91, 50);
			PushFollow(Follow._boolexpression_in_forstatement806);
			boolexpression88=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression88.Tree);
			DebugLocation(91, 68);
			char_literal89=(IToken)Match(input,48,Follow._48_in_forstatement808); if (state.failed) return retval;
			DebugLocation(91, 70);
			PushFollow(Follow._assignmentbody_in_forstatement811);
			assignmentbody90=assignmentbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentbody90.Tree);
			DebugLocation(91, 88);
			char_literal91=(IToken)Match(input,50,Follow._50_in_forstatement813); if (state.failed) return retval;
			DebugLocation(91, 90);
			// MathLang.g:91:90: ( block | statement )
			int alt20=2;
			try { DebugEnterSubRule(20);
			try { DebugEnterDecision(20, decisionCanBacktrack[20]);
			int LA20_0 = input.LA(1);

			if ((LA20_0==54))
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
				// MathLang.g:91:91: block
				{
				DebugLocation(91, 91);
				PushFollow(Follow._block_in_forstatement817);
				block92=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block92.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:91:99: statement
				{
				DebugLocation(91, 99);
				PushFollow(Follow._statement_in_forstatement821);
				statement93=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement93.Tree);

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
			TraceOut("forstatement", 25);
			LeaveRule("forstatement", 25);
			Leave_forstatement();
			if (state.backtracking > 0) { Memoize(input, 25, forstatement_StartIndex); }
		}
		DebugLocation(91, 108);
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
	// MathLang.g:92:1: returnstatement : RETURN expression ';' ;
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

		IToken RETURN94=null;
		IToken char_literal96=null;
		MathLangParser.expression_return expression95 = default(MathLangParser.expression_return);

		object RETURN94_tree=null;
		object char_literal96_tree=null;

		try { DebugEnterRule(GrammarFileName, "returnstatement");
		DebugLocation(92, 41);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 26)) { return retval; }
			// MathLang.g:92:16: ( RETURN expression ';' )
			DebugEnterAlt(1);
			// MathLang.g:92:18: RETURN expression ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(92, 24);
			RETURN94=(IToken)Match(input,RETURN,Follow._RETURN_in_returnstatement828); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			RETURN94_tree = (object)adaptor.Create(RETURN94);
			root_0 = (object)adaptor.BecomeRoot(RETURN94_tree, root_0);
			}
			DebugLocation(92, 26);
			PushFollow(Follow._expression_in_returnstatement831);
			expression95=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression95.Tree);
			DebugLocation(92, 40);
			char_literal96=(IToken)Match(input,48,Follow._48_in_returnstatement833); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(92, 41);
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
	// MathLang.g:94:1: funcdeclaration : TYPE ID '(' ( paramsdeclaration )? ')' block -> ^( FUNCDECLARATION ID ^( RETURNS TYPE ) ( paramsdeclaration )? block ) ;
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

		IToken TYPE97=null;
		IToken ID98=null;
		IToken char_literal99=null;
		IToken char_literal101=null;
		MathLangParser.paramsdeclaration_return paramsdeclaration100 = default(MathLangParser.paramsdeclaration_return);
		MathLangParser.block_return block102 = default(MathLangParser.block_return);

		object TYPE97_tree=null;
		object ID98_tree=null;
		object char_literal99_tree=null;
		object char_literal101_tree=null;
		RewriteRuleITokenStream stream_49=new RewriteRuleITokenStream(adaptor,"token 49");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");
		RewriteRuleITokenStream stream_50=new RewriteRuleITokenStream(adaptor,"token 50");
		RewriteRuleSubtreeStream stream_paramsdeclaration=new RewriteRuleSubtreeStream(adaptor,"rule paramsdeclaration");
		RewriteRuleSubtreeStream stream_block=new RewriteRuleSubtreeStream(adaptor,"rule block");
		try { DebugEnterRule(GrammarFileName, "funcdeclaration");
		DebugLocation(94, 136);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 27)) { return retval; }
			// MathLang.g:94:16: ( TYPE ID '(' ( paramsdeclaration )? ')' block -> ^( FUNCDECLARATION ID ^( RETURNS TYPE ) ( paramsdeclaration )? block ) )
			DebugEnterAlt(1);
			// MathLang.g:94:18: TYPE ID '(' ( paramsdeclaration )? ')' block
			{
			DebugLocation(94, 18);
			TYPE97=(IToken)Match(input,TYPE,Follow._TYPE_in_funcdeclaration842); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE97);

			DebugLocation(94, 25);
			ID98=(IToken)Match(input,ID,Follow._ID_in_funcdeclaration844); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID98);

			DebugLocation(94, 30);
			char_literal99=(IToken)Match(input,49,Follow._49_in_funcdeclaration847); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_49.Add(char_literal99);

			DebugLocation(94, 32);
			// MathLang.g:94:32: ( paramsdeclaration )?
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
				DebugLocation(94, 32);
				PushFollow(Follow._paramsdeclaration_in_funcdeclaration850);
				paramsdeclaration100=paramsdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_paramsdeclaration.Add(paramsdeclaration100.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(21); }

			DebugLocation(94, 54);
			char_literal101=(IToken)Match(input,50,Follow._50_in_funcdeclaration853); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_50.Add(char_literal101);

			DebugLocation(94, 56);
			PushFollow(Follow._block_in_funcdeclaration856);
			block102=block();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_block.Add(block102.Tree);


			{
			// AST REWRITE
			// elements: ID, TYPE, block, paramsdeclaration
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 94:62: -> ^( FUNCDECLARATION ID ^( RETURNS TYPE ) ( paramsdeclaration )? block )
			{
				DebugLocation(94, 65);
				// MathLang.g:94:65: ^( FUNCDECLARATION ID ^( RETURNS TYPE ) ( paramsdeclaration )? block )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(94, 67);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNCDECLARATION, "FUNCDECLARATION"), root_1);

				DebugLocation(94, 83);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(94, 86);
				// MathLang.g:94:86: ^( RETURNS TYPE )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(94, 88);
				root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(RETURNS, "RETURNS"), root_2);

				DebugLocation(94, 96);
				adaptor.AddChild(root_2, stream_TYPE.NextNode());

				adaptor.AddChild(root_1, root_2);
				}
				DebugLocation(94, 107);
				// MathLang.g:94:107: ( paramsdeclaration )?
				if ( stream_paramsdeclaration.HasNext )
				{
					DebugLocation(94, 107);
					adaptor.AddChild(root_1, stream_paramsdeclaration.NextTree());

				}
				stream_paramsdeclaration.Reset();
				DebugLocation(94, 131);
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
		DebugLocation(94, 136);
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
	// MathLang.g:95:1: paramsdeclaration : ( declarationbody ( ',' declarationbody )* ) -> ^( PARAMETERS ( declarationbody )* ) ;
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

		IToken char_literal104=null;
		MathLangParser.declarationbody_return declarationbody103 = default(MathLangParser.declarationbody_return);
		MathLangParser.declarationbody_return declarationbody105 = default(MathLangParser.declarationbody_return);

		object char_literal104_tree=null;
		RewriteRuleITokenStream stream_51=new RewriteRuleITokenStream(adaptor,"token 51");
		RewriteRuleSubtreeStream stream_declarationbody=new RewriteRuleSubtreeStream(adaptor,"rule declarationbody");
		try { DebugEnterRule(GrammarFileName, "paramsdeclaration");
		DebugLocation(95, 102);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 28)) { return retval; }
			// MathLang.g:95:18: ( ( declarationbody ( ',' declarationbody )* ) -> ^( PARAMETERS ( declarationbody )* ) )
			DebugEnterAlt(1);
			// MathLang.g:95:20: ( declarationbody ( ',' declarationbody )* )
			{
			DebugLocation(95, 20);
			// MathLang.g:95:20: ( declarationbody ( ',' declarationbody )* )
			DebugEnterAlt(1);
			// MathLang.g:95:22: declarationbody ( ',' declarationbody )*
			{
			DebugLocation(95, 22);
			PushFollow(Follow._declarationbody_in_paramsdeclaration889);
			declarationbody103=declarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declarationbody.Add(declarationbody103.Tree);
			DebugLocation(95, 38);
			// MathLang.g:95:38: ( ',' declarationbody )*
			try { DebugEnterSubRule(22);
			while (true)
			{
				int alt22=2;
				try { DebugEnterDecision(22, decisionCanBacktrack[22]);
				int LA22_0 = input.LA(1);

				if ((LA22_0==51))
				{
					alt22=1;
				}


				} finally { DebugExitDecision(22); }
				switch ( alt22 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:95:40: ',' declarationbody
					{
					DebugLocation(95, 43);
					char_literal104=(IToken)Match(input,51,Follow._51_in_paramsdeclaration893); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_51.Add(char_literal104);

					DebugLocation(95, 45);
					PushFollow(Follow._declarationbody_in_paramsdeclaration896);
					declarationbody105=declarationbody();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_declarationbody.Add(declarationbody105.Tree);

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
			// 95:66: -> ^( PARAMETERS ( declarationbody )* )
			{
				DebugLocation(95, 69);
				// MathLang.g:95:69: ^( PARAMETERS ( declarationbody )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(95, 71);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_1);

				DebugLocation(95, 82);
				// MathLang.g:95:82: ( declarationbody )*
				while ( stream_declarationbody.HasNext )
				{
					DebugLocation(95, 84);
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
		DebugLocation(95, 102);
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
	// MathLang.g:97:1: funccallbody : ID '(' ( expressioncommalist )? ')' ;
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

		IToken ID106=null;
		IToken char_literal107=null;
		IToken char_literal109=null;
		MathLangParser.expressioncommalist_return expressioncommalist108 = default(MathLangParser.expressioncommalist_return);

		object ID106_tree=null;
		object char_literal107_tree=null;
		object char_literal109_tree=null;

		try { DebugEnterRule(GrammarFileName, "funccallbody");
		DebugLocation(97, 46);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 29)) { return retval; }
			// MathLang.g:97:13: ( ID '(' ( expressioncommalist )? ')' )
			DebugEnterAlt(1);
			// MathLang.g:97:15: ID '(' ( expressioncommalist )? ')'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(97, 17);
			ID106=(IToken)Match(input,ID,Follow._ID_in_funccallbody921); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			ID106_tree = (object)adaptor.Create(ID106);
			root_0 = (object)adaptor.BecomeRoot(ID106_tree, root_0);
			}
			DebugLocation(97, 19);
			char_literal107=(IToken)Match(input,49,Follow._49_in_funccallbody924); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal107_tree = (object)adaptor.Create(char_literal107);
			adaptor.AddChild(root_0, char_literal107_tree);
			}
			DebugLocation(97, 23);
			// MathLang.g:97:23: ( expressioncommalist )?
			int alt23=2;
			try { DebugEnterSubRule(23);
			try { DebugEnterDecision(23, decisionCanBacktrack[23]);
			int LA23_0 = input.LA(1);

			if (((LA23_0>=NUMBER && LA23_0<=CHAR)||LA23_0==SUB||(LA23_0>=NOT && LA23_0<=KEYWORD_NEW)||LA23_0==49))
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
				DebugLocation(97, 23);
				PushFollow(Follow._expressioncommalist_in_funccallbody926);
				expressioncommalist108=expressioncommalist();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expressioncommalist108.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(23); }

			DebugLocation(97, 44);
			char_literal109=(IToken)Match(input,50,Follow._50_in_funccallbody929); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal109_tree = (object)adaptor.Create(char_literal109);
			adaptor.AddChild(root_0, char_literal109_tree);
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
		DebugLocation(97, 46);
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
	// MathLang.g:98:1: funccall : funccallbody ';' ;
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

		IToken char_literal111=null;
		MathLangParser.funccallbody_return funccallbody110 = default(MathLangParser.funccallbody_return);

		object char_literal111_tree=null;

		try { DebugEnterRule(GrammarFileName, "funccall");
		DebugLocation(98, 27);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 30)) { return retval; }
			// MathLang.g:98:9: ( funccallbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:98:11: funccallbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(98, 11);
			PushFollow(Follow._funccallbody_in_funccall935);
			funccallbody110=funccallbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody110.Tree);
			DebugLocation(98, 27);
			char_literal111=(IToken)Match(input,48,Follow._48_in_funccall937); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(98, 27);
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
		EnterRule("expressioncommalist", 31);
		TraceIn("expressioncommalist", 31);
		MathLangParser.expressioncommalist_return retval = new MathLangParser.expressioncommalist_return();
		retval.Start = (IToken)input.LT(1);
		int expressioncommalist_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal113=null;
		MathLangParser.expression_return expression112 = default(MathLangParser.expression_return);
		MathLangParser.expression_return expression114 = default(MathLangParser.expression_return);

		object char_literal113_tree=null;
		RewriteRuleITokenStream stream_51=new RewriteRuleITokenStream(adaptor,"token 51");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "expressioncommalist");
		DebugLocation(99, 83);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 31)) { return retval; }
			// MathLang.g:99:20: ( expression ( ',' expression )* -> ^( PARAMETERS ( expression )* ) )
			DebugEnterAlt(1);
			// MathLang.g:99:22: expression ( ',' expression )*
			{
			DebugLocation(99, 22);
			PushFollow(Follow._expression_in_expressioncommalist944);
			expression112=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression112.Tree);
			DebugLocation(99, 33);
			// MathLang.g:99:33: ( ',' expression )*
			try { DebugEnterSubRule(24);
			while (true)
			{
				int alt24=2;
				try { DebugEnterDecision(24, decisionCanBacktrack[24]);
				int LA24_0 = input.LA(1);

				if ((LA24_0==51))
				{
					alt24=1;
				}


				} finally { DebugExitDecision(24); }
				switch ( alt24 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:99:35: ',' expression
					{
					DebugLocation(99, 38);
					char_literal113=(IToken)Match(input,51,Follow._51_in_expressioncommalist948); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_51.Add(char_literal113);

					DebugLocation(99, 40);
					PushFollow(Follow._expression_in_expressioncommalist951);
					expression114=expression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_expression.Add(expression114.Tree);

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
			TraceOut("expressioncommalist", 31);
			LeaveRule("expressioncommalist", 31);
			Leave_expressioncommalist();
			if (state.backtracking > 0) { Memoize(input, 31, expressioncommalist_StartIndex); }
		}
		DebugLocation(99, 83);
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
	// MathLang.g:102:1: newexpression : KEYWORD_NEW TYPE ( ( '[' number ']' ( '{' ( expressioncommalist )? '}' )* ) ) ;
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

		IToken KEYWORD_NEW115=null;
		IToken TYPE116=null;
		IToken char_literal117=null;
		IToken char_literal119=null;
		IToken char_literal120=null;
		IToken char_literal122=null;
		MathLangParser.number_return number118 = default(MathLangParser.number_return);
		MathLangParser.expressioncommalist_return expressioncommalist121 = default(MathLangParser.expressioncommalist_return);

		object KEYWORD_NEW115_tree=null;
		object TYPE116_tree=null;
		object char_literal117_tree=null;
		object char_literal119_tree=null;
		object char_literal120_tree=null;
		object char_literal122_tree=null;

		try { DebugEnterRule(GrammarFileName, "newexpression");
		DebugLocation(102, 90);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 32)) { return retval; }
			// MathLang.g:102:14: ( KEYWORD_NEW TYPE ( ( '[' number ']' ( '{' ( expressioncommalist )? '}' )* ) ) )
			DebugEnterAlt(1);
			// MathLang.g:102:16: KEYWORD_NEW TYPE ( ( '[' number ']' ( '{' ( expressioncommalist )? '}' )* ) )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(102, 16);
			KEYWORD_NEW115=(IToken)Match(input,KEYWORD_NEW,Follow._KEYWORD_NEW_in_newexpression973); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			KEYWORD_NEW115_tree = (object)adaptor.Create(KEYWORD_NEW115);
			adaptor.AddChild(root_0, KEYWORD_NEW115_tree);
			}
			DebugLocation(102, 28);
			TYPE116=(IToken)Match(input,TYPE,Follow._TYPE_in_newexpression975); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			TYPE116_tree = (object)adaptor.Create(TYPE116);
			adaptor.AddChild(root_0, TYPE116_tree);
			}
			DebugLocation(102, 33);
			// MathLang.g:102:33: ( ( '[' number ']' ( '{' ( expressioncommalist )? '}' )* ) )
			DebugEnterAlt(1);
			// MathLang.g:102:35: ( '[' number ']' ( '{' ( expressioncommalist )? '}' )* )
			{
			DebugLocation(102, 35);
			// MathLang.g:102:35: ( '[' number ']' ( '{' ( expressioncommalist )? '}' )* )
			DebugEnterAlt(1);
			// MathLang.g:102:37: '[' number ']' ( '{' ( expressioncommalist )? '}' )*
			{
			DebugLocation(102, 40);
			char_literal117=(IToken)Match(input,52,Follow._52_in_newexpression981); if (state.failed) return retval;
			DebugLocation(102, 42);
			PushFollow(Follow._number_in_newexpression984);
			number118=number();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, number118.Tree);
			DebugLocation(102, 52);
			char_literal119=(IToken)Match(input,53,Follow._53_in_newexpression986); if (state.failed) return retval;
			DebugLocation(102, 54);
			// MathLang.g:102:54: ( '{' ( expressioncommalist )? '}' )*
			try { DebugEnterSubRule(26);
			while (true)
			{
				int alt26=2;
				try { DebugEnterDecision(26, decisionCanBacktrack[26]);
				int LA26_0 = input.LA(1);

				if ((LA26_0==54))
				{
					alt26=1;
				}


				} finally { DebugExitDecision(26); }
				switch ( alt26 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:102:55: '{' ( expressioncommalist )? '}'
					{
					DebugLocation(102, 58);
					char_literal120=(IToken)Match(input,54,Follow._54_in_newexpression990); if (state.failed) return retval;
					DebugLocation(102, 60);
					// MathLang.g:102:60: ( expressioncommalist )?
					int alt25=2;
					try { DebugEnterSubRule(25);
					try { DebugEnterDecision(25, decisionCanBacktrack[25]);
					int LA25_0 = input.LA(1);

					if (((LA25_0>=NUMBER && LA25_0<=CHAR)||LA25_0==SUB||(LA25_0>=NOT && LA25_0<=KEYWORD_NEW)||LA25_0==49))
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
						DebugLocation(102, 60);
						PushFollow(Follow._expressioncommalist_in_newexpression993);
						expressioncommalist121=expressioncommalist();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expressioncommalist121.Tree);

						}
						break;

					}
					} finally { DebugExitSubRule(25); }

					DebugLocation(102, 84);
					char_literal122=(IToken)Match(input,55,Follow._55_in_newexpression996); if (state.failed) return retval;

					}
					break;

				default:
					goto loop26;
				}
			}

			loop26:
				;

			} finally { DebugExitSubRule(26); }


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
			TraceOut("newexpression", 32);
			LeaveRule("newexpression", 32);
			Leave_newexpression();
			if (state.backtracking > 0) { Memoize(input, 32, newexpression_StartIndex); }
		}
		DebugLocation(102, 90);
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
	// MathLang.g:104:1: block : '{' statementlist '}' ;
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

		IToken char_literal123=null;
		IToken char_literal125=null;
		MathLangParser.statementlist_return statementlist124 = default(MathLangParser.statementlist_return);

		object char_literal123_tree=null;
		object char_literal125_tree=null;

		try { DebugEnterRule(GrammarFileName, "block");
		DebugLocation(104, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 33)) { return retval; }
			// MathLang.g:104:6: ( '{' statementlist '}' )
			DebugEnterAlt(1);
			// MathLang.g:104:8: '{' statementlist '}'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(104, 11);
			char_literal123=(IToken)Match(input,54,Follow._54_in_block1010); if (state.failed) return retval;
			DebugLocation(104, 13);
			PushFollow(Follow._statementlist_in_block1013);
			statementlist124=statementlist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementlist124.Tree);
			DebugLocation(104, 30);
			char_literal125=(IToken)Match(input,55,Follow._55_in_block1015); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(104, 30);
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
	// MathLang.g:106:1: statementlist : ( statement )* -> ^( BLOCK ( statement )* ) ;
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

		MathLangParser.statement_return statement126 = default(MathLangParser.statement_return);

		RewriteRuleSubtreeStream stream_statement=new RewriteRuleSubtreeStream(adaptor,"rule statement");
		try { DebugEnterRule(GrammarFileName, "statementlist");
		DebugLocation(106, 49);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 34)) { return retval; }
			// MathLang.g:106:14: ( ( statement )* -> ^( BLOCK ( statement )* ) )
			DebugEnterAlt(1);
			// MathLang.g:106:16: ( statement )*
			{
			DebugLocation(106, 16);
			// MathLang.g:106:16: ( statement )*
			try { DebugEnterSubRule(27);
			while (true)
			{
				int alt27=2;
				try { DebugEnterDecision(27, decisionCanBacktrack[27]);
				int LA27_0 = input.LA(1);

				if ((LA27_0==IF||LA27_0==FOR||(LA27_0>=RETURN && LA27_0<=WHILE)||LA27_0==ID||LA27_0==TYPE))
				{
					alt27=1;
				}


				} finally { DebugExitDecision(27); }
				switch ( alt27 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: statement
					{
					DebugLocation(106, 16);
					PushFollow(Follow._statement_in_statementlist1023);
					statement126=statement();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_statement.Add(statement126.Tree);

					}
					break;

				default:
					goto loop27;
				}
			}

			loop27:
				;

			} finally { DebugExitSubRule(27); }



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
			// 106:27: -> ^( BLOCK ( statement )* )
			{
				DebugLocation(106, 30);
				// MathLang.g:106:30: ^( BLOCK ( statement )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(106, 32);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

				DebugLocation(106, 38);
				// MathLang.g:106:38: ( statement )*
				while ( stream_statement.HasNext )
				{
					DebugLocation(106, 38);
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
		DebugLocation(106, 49);
		} finally { DebugExitRule(GrammarFileName, "statementlist"); }
		return retval;

	}
	// $ANTLR end "statementlist"

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
			// MathLang.g:59:6: ( funccallbody )
			DebugEnterAlt(1);
			// MathLang.g:59:6: funccallbody
			{
			DebugLocation(59, 6);
			PushFollow(Follow._funccallbody_in_synpred12_MathLang395);
			funccallbody();
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

	partial void Enter_synpred13_MathLang_fragment();
	partial void Leave_synpred13_MathLang_fragment();

	// $ANTLR start synpred13_MathLang
	public void synpred13_MathLang_fragment()
	{
		Enter_synpred13_MathLang_fragment();
		EnterRule("synpred13_MathLang_fragment", 47);
		TraceIn("synpred13_MathLang_fragment", 47);
		try
		{
			// MathLang.g:60:6: ( boolexpression )
			DebugEnterAlt(1);
			// MathLang.g:60:6: boolexpression
			{
			DebugLocation(60, 6);
			PushFollow(Follow._boolexpression_in_synpred13_MathLang402);
			boolexpression();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred13_MathLang_fragment", 47);
			LeaveRule("synpred13_MathLang_fragment", 47);
			Leave_synpred13_MathLang_fragment();
		}
	}
	// $ANTLR end synpred13_MathLang

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
			// MathLang.g:73:16: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )
			DebugEnterAlt(1);
			// MathLang.g:73:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
			{
			DebugLocation(73, 16);
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

			DebugLocation(73, 53);
			PushFollow(Follow._add_in_synpred24_MathLang562);
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
			// MathLang.g:84:22: ( '(' boolterm ')' )
			DebugEnterAlt(1);
			// MathLang.g:84:22: '(' boolterm ')'
			{
			DebugLocation(84, 22);
			Match(input,49,Follow._49_in_synpred32_MathLang697); if (state.failed) return;
			DebugLocation(84, 27);
			PushFollow(Follow._boolterm_in_synpred32_MathLang700);
			boolterm();
			PopFollow();
			if (state.failed) return;
			DebugLocation(84, 36);
			Match(input,50,Follow._50_in_synpred32_MathLang702); if (state.failed) return;

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
			// MathLang.g:89:64: ( ELSE ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:89:64: ELSE ( block | statement )
			{
			DebugLocation(89, 64);
			Match(input,ELSE,Follow._ELSE_in_synpred37_MathLang754); if (state.failed) return;
			DebugLocation(89, 70);
			// MathLang.g:89:70: ( block | statement )
			int alt29=2;
			try { DebugEnterSubRule(29);
			try { DebugEnterDecision(29, decisionCanBacktrack[29]);
			int LA29_0 = input.LA(1);

			if ((LA29_0==54))
			{
				alt29=1;
			}
			else if ((LA29_0==IF||LA29_0==FOR||(LA29_0>=RETURN && LA29_0<=WHILE)||LA29_0==ID||LA29_0==TYPE))
			{
				alt29=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				NoViableAltException nvae = new NoViableAltException("", 29, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(29); }
			switch (alt29)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:89:71: block
				{
				DebugLocation(89, 71);
				PushFollow(Follow._block_in_synpred37_MathLang758);
				block();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:89:79: statement
				{
				DebugLocation(89, 79);
				PushFollow(Follow._statement_in_synpred37_MathLang762);
				statement();
				PopFollow();
				if (state.failed) return;

				}
				break;

			}
			} finally { DebugExitSubRule(29); }


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
	DFA7 dfa7;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa1 = new DFA1( this );
		dfa3 = new DFA3( this, SpecialStateTransition3 );
		dfa7 = new DFA7( this, SpecialStateTransition7 );
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
			"\x1\x16\x1\x14\x1\x31\x4\xFFFF\x1\x31\x4\xFFFF";
		private const string DFA1_acceptS =
			"\x3\xFFFF\x1\x3\x1\x4\x1\x5\x1\x7\x1\xFFFF\x1\x2\x1\x8\x1\x1\x1\x6";
		private const string DFA1_specialS =
			"\xC\xFFFF}>";
		private static readonly string[] DFA1_transitionS =
			{
				"\x1\x3\x1\xFFFF\x1\x5\x1\xFFFF\x1\x6\x1\x4\x7\xFFFF\x1\x2\x1\xFFFF"+
				"\x1\x1",
				"\x1\x7",
				"\x1\x8\x19\xFFFF\x1\x9",
				"",
				"",
				"",
				"",
				"\x1\xA\x18\xFFFF\x1\xA\x1\xB",
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

	private class DFA3 : DFA
	{
		private const string DFA3_eotS =
			"\xC\xFFFF";
		private const string DFA3_eofS =
			"\xC\xFFFF";
		private const string DFA3_minS =
			"\x1\x13\x1\xFFFF\x1\x0\x1\xFFFF\x1\x0\x2\xFFFF\x3\x0\x2\xFFFF";
		private const string DFA3_maxS =
			"\x1\x31\x1\xFFFF\x1\x0\x1\xFFFF\x1\x0\x2\xFFFF\x3\x0\x2\xFFFF";
		private const string DFA3_acceptS =
			"\x1\xFFFF\x1\x1\x1\xFFFF\x1\x3\x6\xFFFF\x1\x2\x1\x4";
		private const string DFA3_specialS =
			"\x2\xFFFF\x1\x0\x1\xFFFF\x1\x1\x2\xFFFF\x1\x2\x1\x3\x1\x4\x2\xFFFF}>";
		private static readonly string[] DFA3_transitionS =
			{
				"\x1\x8\x1\x2\x1\x9\x3\xFFFF\x1\x7\xA\xFFFF\x3\x3\x1\x1\x9\xFFFF\x1"+
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

		public override string Description { get { return "57:1: expression : ( newexpression | funccallbody | boolexpression | mathexpression );"; } }

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
				if ( (EvaluatePredicate(synpred12_MathLang_fragment)) ) {s = 10;}

				else if ( (EvaluatePredicate(synpred13_MathLang_fragment)) ) {s = 3;}

				else if ( (true) ) {s = 11;}


				input.Seek(index3_2);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA3_4 = input.LA(1);


				int index3_4 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred13_MathLang_fragment)) ) {s = 3;}

				else if ( (true) ) {s = 11;}


				input.Seek(index3_4);
				if ( s>=0 ) return s;
				break;
			case 2:
				int LA3_7 = input.LA(1);


				int index3_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred13_MathLang_fragment)) ) {s = 3;}

				else if ( (true) ) {s = 11;}


				input.Seek(index3_7);
				if ( s>=0 ) return s;
				break;
			case 3:
				int LA3_8 = input.LA(1);


				int index3_8 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred13_MathLang_fragment)) ) {s = 3;}

				else if ( (true) ) {s = 11;}


				input.Seek(index3_8);
				if ( s>=0 ) return s;
				break;
			case 4:
				int LA3_9 = input.LA(1);


				int index3_9 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred13_MathLang_fragment)) ) {s = 3;}

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
	private class DFA7 : DFA
	{
		private const string DFA7_eotS =
			"\xA\xFFFF";
		private const string DFA7_eofS =
			"\x1\x2\x9\xFFFF";
		private const string DFA7_minS =
			"\x1\x1C\x1\x0\x8\xFFFF";
		private const string DFA7_maxS =
			"\x1\x37\x1\x0\x8\xFFFF";
		private const string DFA7_acceptS =
			"\x2\xFFFF\x1\x2\x1\xFFFF\x1\x1\x5\xFFFF";
		private const string DFA7_specialS =
			"\x1\xFFFF\x1\x0\x8\xFFFF}>";
		private static readonly string[] DFA7_transitionS =
			{
				"\x2\x4\x2\x1\x2\x4\x2\x2\xC\xFFFF\x1\x2\x1\xFFFF\x2\x2\x3\xFFFF\x1"+
				"\x2",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA7_eot = DFA.UnpackEncodedString(DFA7_eotS);
		private static readonly short[] DFA7_eof = DFA.UnpackEncodedString(DFA7_eofS);
		private static readonly char[] DFA7_min = DFA.UnpackEncodedStringToUnsignedChars(DFA7_minS);
		private static readonly char[] DFA7_max = DFA.UnpackEncodedStringToUnsignedChars(DFA7_maxS);
		private static readonly short[] DFA7_accept = DFA.UnpackEncodedString(DFA7_acceptS);
		private static readonly short[] DFA7_special = DFA.UnpackEncodedString(DFA7_specialS);
		private static readonly short[][] DFA7_transition;

		static DFA7()
		{
			int numStates = DFA7_transitionS.Length;
			DFA7_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA7_transition[i] = DFA.UnpackEncodedString(DFA7_transitionS[i]);
			}
		}

		public DFA7( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 7;
			this.eot = DFA7_eot;
			this.eof = DFA7_eof;
			this.min = DFA7_min;
			this.max = DFA7_max;
			this.accept = DFA7_accept;
			this.special = DFA7_special;
			this.transition = DFA7_transition;
		}

		public override string Description { get { return "73:14: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition7(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA7_1 = input.LA(1);


				int index7_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred24_MathLang_fragment)) ) {s = 4;}

				else if ( (true) ) {s = 2;}


				input.Seek(index7_1);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 7, _s, input);
		dfa.Error(nvae);
		throw nvae;
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
		public static readonly BitSet _funccallbody_in_expression395 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolexpression_in_expression402 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathexpression_in_expression409 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declarationbody_in_declaration417 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _48_in_declaration419 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _longdeclaration_in_declaration427 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_declarationbody434 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _ID_in_declarationbody436 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _longdeclarationbody_in_longdeclaration453 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _48_in_longdeclaration455 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_longdeclarationbody463 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _ID_in_longdeclarationbody465 = new BitSet(new ulong[]{0x800000UL});
		public static readonly BitSet _ASSIGN_in_longdeclarationbody467 = new BitSet(new ulong[]{0x200F002380000UL});
		public static readonly BitSet _expression_in_longdeclarationbody469 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mul_in_add489 = new BitSet(new ulong[]{0x3000002UL});
		public static readonly BitSet _set_in_add493 = new BitSet(new ulong[]{0x2007002380000UL});
		public static readonly BitSet _mul_in_add502 = new BitSet(new ulong[]{0x3000002UL});
		public static readonly BitSet _group_in_mul511 = new BitSet(new ulong[]{0xC000002UL});
		public static readonly BitSet _set_in_mul515 = new BitSet(new ulong[]{0x2007002380000UL});
		public static readonly BitSet _group_in_mul524 = new BitSet(new ulong[]{0xC000002UL});
		public static readonly BitSet _add_in_compare532 = new BitSet(new ulong[]{0x3F0000002UL});
		public static readonly BitSet _set_in_compare536 = new BitSet(new ulong[]{0x2007002380000UL});
		public static readonly BitSet _add_in_compare562 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _add_in_term573 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _SUB_in_group580 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _49_in_group585 = new BitSet(new ulong[]{0x200F002380000UL});
		public static readonly BitSet _term_in_group588 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_group590 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _number_in_group595 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assignmentbody_in_assignment602 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _48_in_assignment604 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_assignmentbody611 = new BitSet(new ulong[]{0x800000UL});
		public static readonly BitSet _ASSIGN_in_assignmentbody613 = new BitSet(new ulong[]{0x200F002380000UL});
		public static readonly BitSet _expression_in_assignmentbody615 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolterm_in_boolexpression632 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _or_in_boolterm639 = new BitSet(new ulong[]{0xC0000002UL});
		public static readonly BitSet _set_in_boolterm643 = new BitSet(new ulong[]{0x2007002380000UL});
		public static readonly BitSet _or_in_boolterm652 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _and_in_or661 = new BitSet(new ulong[]{0x400000002UL});
		public static readonly BitSet _OR_in_or664 = new BitSet(new ulong[]{0x2007002380000UL});
		public static readonly BitSet _and_in_or667 = new BitSet(new ulong[]{0x400000002UL});
		public static readonly BitSet _boolgroup_in_and675 = new BitSet(new ulong[]{0x800000002UL});
		public static readonly BitSet _AND_in_and678 = new BitSet(new ulong[]{0x2007002380000UL});
		public static readonly BitSet _boolgroup_in_and681 = new BitSet(new ulong[]{0x800000002UL});
		public static readonly BitSet _NOT_in_boolgroup690 = new BitSet(new ulong[]{0x2007002380000UL});
		public static readonly BitSet _49_in_boolgroup697 = new BitSet(new ulong[]{0x2007002380000UL});
		public static readonly BitSet _boolterm_in_boolgroup700 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_boolgroup702 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolvar_in_boolgroup707 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TRUE_in_boolvar715 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FALSE_in_boolvar721 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _compare_in_boolvar727 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_ifstatement734 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _49_in_ifstatement737 = new BitSet(new ulong[]{0x2007002380000UL});
		public static readonly BitSet _boolexpression_in_ifstatement740 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_ifstatement742 = new BitSet(new ulong[]{0x40000000501A80UL});
		public static readonly BitSet _block_in_ifstatement746 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement750 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _ELSE_in_ifstatement754 = new BitSet(new ulong[]{0x40000000501A80UL});
		public static readonly BitSet _block_in_ifstatement758 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement762 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _WHILE_in_whilestatement772 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _49_in_whilestatement775 = new BitSet(new ulong[]{0x2007002380000UL});
		public static readonly BitSet _boolexpression_in_whilestatement778 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_whilestatement780 = new BitSet(new ulong[]{0x40000000501A80UL});
		public static readonly BitSet _block_in_whilestatement784 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_whilestatement788 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_forstatement795 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _49_in_forstatement798 = new BitSet(new ulong[]{0x400000UL});
		public static readonly BitSet _longdeclarationbody_in_forstatement801 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _48_in_forstatement803 = new BitSet(new ulong[]{0x2007002380000UL});
		public static readonly BitSet _boolexpression_in_forstatement806 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _48_in_forstatement808 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _assignmentbody_in_forstatement811 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_forstatement813 = new BitSet(new ulong[]{0x40000000501A80UL});
		public static readonly BitSet _block_in_forstatement817 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_forstatement821 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _RETURN_in_returnstatement828 = new BitSet(new ulong[]{0x200F002380000UL});
		public static readonly BitSet _expression_in_returnstatement831 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _48_in_returnstatement833 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_funcdeclaration842 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _ID_in_funcdeclaration844 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _49_in_funcdeclaration847 = new BitSet(new ulong[]{0x4000000400000UL});
		public static readonly BitSet _paramsdeclaration_in_funcdeclaration850 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_funcdeclaration853 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _block_in_funcdeclaration856 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declarationbody_in_paramsdeclaration889 = new BitSet(new ulong[]{0x8000000000002UL});
		public static readonly BitSet _51_in_paramsdeclaration893 = new BitSet(new ulong[]{0x400000UL});
		public static readonly BitSet _declarationbody_in_paramsdeclaration896 = new BitSet(new ulong[]{0x8000000000002UL});
		public static readonly BitSet _ID_in_funccallbody921 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _49_in_funccallbody924 = new BitSet(new ulong[]{0x600F002380000UL});
		public static readonly BitSet _expressioncommalist_in_funccallbody926 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_funccallbody929 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_funccall935 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _48_in_funccall937 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_expressioncommalist944 = new BitSet(new ulong[]{0x8000000000002UL});
		public static readonly BitSet _51_in_expressioncommalist948 = new BitSet(new ulong[]{0x200F002380000UL});
		public static readonly BitSet _expression_in_expressioncommalist951 = new BitSet(new ulong[]{0x8000000000002UL});
		public static readonly BitSet _KEYWORD_NEW_in_newexpression973 = new BitSet(new ulong[]{0x400000UL});
		public static readonly BitSet _TYPE_in_newexpression975 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _52_in_newexpression981 = new BitSet(new ulong[]{0x2007002380000UL});
		public static readonly BitSet _number_in_newexpression984 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _53_in_newexpression986 = new BitSet(new ulong[]{0x40000000000002UL});
		public static readonly BitSet _54_in_newexpression990 = new BitSet(new ulong[]{0x8200F002380000UL});
		public static readonly BitSet _expressioncommalist_in_newexpression993 = new BitSet(new ulong[]{0x80000000000000UL});
		public static readonly BitSet _55_in_newexpression996 = new BitSet(new ulong[]{0x40000000000002UL});
		public static readonly BitSet _54_in_block1010 = new BitSet(new ulong[]{0xC0000000501A80UL});
		public static readonly BitSet _statementlist_in_block1013 = new BitSet(new ulong[]{0x80000000000000UL});
		public static readonly BitSet _55_in_block1015 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_statementlist1023 = new BitSet(new ulong[]{0x40000000501A82UL});
		public static readonly BitSet _funccallbody_in_synpred12_MathLang395 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolexpression_in_synpred13_MathLang402 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_synpred24_MathLang536 = new BitSet(new ulong[]{0x2007002380000UL});
		public static readonly BitSet _add_in_synpred24_MathLang562 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _49_in_synpred32_MathLang697 = new BitSet(new ulong[]{0x2007002380000UL});
		public static readonly BitSet _boolterm_in_synpred32_MathLang700 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_synpred32_MathLang702 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ELSE_in_synpred37_MathLang754 = new BitSet(new ulong[]{0x40000000501A80UL});
		public static readonly BitSet _block_in_synpred37_MathLang758 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_synpred37_MathLang762 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  MathLang 

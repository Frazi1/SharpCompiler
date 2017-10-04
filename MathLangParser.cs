// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-10-04 12:52:09

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "UNKNOWN", "PRINT", "INPUT", "IF", "ELSE", "FOR", "FUNCTION", "RETURN", "WHILE", "BLOCK", "PROGRAM", "PARAMS", "VARDECLARATION", "FUNCDECLARATION", "VARASSIGNMENT", "ARRAYELEMENTASSIGNMENT", "ARRAYELEMENT", "NEWWORD", "NUMBER", "ID", "CHAR", "TYPE", "ASSIGN", "ADD", "SUB", "MUL", "DIV", "GREQ", "LSEQ", "NEQ", "EQ", "GR", "LS", "OR", "AND", "NOT", "TRUE", "FALSE", "KNEW", "TYPE0", "SQRBL", "SQRBR", "ACCESS_MODIFIER", "RETURNS", "PARAMETERS", "WS", "SL_COMMENT", "ML_COMMENT", "';'", "'('", "')'", "','", "'{'", "'}'"
	};
	public const int EOF=-1;
	public const int T__52=52;
	public const int T__53=53;
	public const int T__54=54;
	public const int T__55=55;
	public const int T__56=56;
	public const int T__57=57;
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
	public const int NUMBER=22;
	public const int ID=23;
	public const int CHAR=24;
	public const int TYPE=25;
	public const int ASSIGN=26;
	public const int ADD=27;
	public const int SUB=28;
	public const int MUL=29;
	public const int DIV=30;
	public const int GREQ=31;
	public const int LSEQ=32;
	public const int NEQ=33;
	public const int EQ=34;
	public const int GR=35;
	public const int LS=36;
	public const int OR=37;
	public const int AND=38;
	public const int NOT=39;
	public const int TRUE=40;
	public const int FALSE=41;
	public const int KNEW=42;
	public const int TYPE0=43;
	public const int SQRBL=44;
	public const int SQRBR=45;
	public const int ACCESS_MODIFIER=46;
	public const int RETURNS=47;
	public const int PARAMETERS=48;
	public const int WS=49;
	public const int SL_COMMENT=50;
	public const int ML_COMMENT=51;

	// delegates
	// delegators

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, true, false, false, false, true, false, false, false, 
				false, false, false, false, true, false, false, false, true, false, 
				false, false, false, false, false, false, , false
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
		this.state.ruleMemo = new System.Collections.Generic.Dictionary<int, int>[81+1];

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
	// MathLang.g:41:8: public execute : statementlist EOF ;
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
		DebugLocation(41, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 1)) { return retval; }
			// MathLang.g:41:15: ( statementlist EOF )
			DebugEnterAlt(1);
			// MathLang.g:42:2: statementlist EOF
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(42, 2);
			PushFollow(Follow._statementlist_in_execute317);
			statementlist1=statementlist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementlist1.Tree);
			DebugLocation(42, 19);
			EOF2=(IToken)Match(input,EOF,Follow._EOF_in_execute319); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(43, 0);
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
	// MathLang.g:45:1: statement : ( declaration | assignment | ifstatement | whilestatement | forstatement | funcdeclaration | returnstatement | funccall ) ;
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
		DebugLocation(45, 13);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 2)) { return retval; }
			// MathLang.g:45:10: ( ( declaration | assignment | ifstatement | whilestatement | forstatement | funcdeclaration | returnstatement | funccall ) )
			DebugEnterAlt(1);
			// MathLang.g:45:12: ( declaration | assignment | ifstatement | whilestatement | forstatement | funcdeclaration | returnstatement | funccall )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(45, 12);
			// MathLang.g:45:12: ( declaration | assignment | ifstatement | whilestatement | forstatement | funcdeclaration | returnstatement | funccall )
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
				// MathLang.g:45:14: declaration
				{
				DebugLocation(45, 14);
				PushFollow(Follow._declaration_in_statement330);
				declaration3=declaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, declaration3.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:46:4: assignment
				{
				DebugLocation(46, 4);
				PushFollow(Follow._assignment_in_statement336);
				assignment4=assignment();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment4.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:47:4: ifstatement
				{
				DebugLocation(47, 4);
				PushFollow(Follow._ifstatement_in_statement341);
				ifstatement5=ifstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ifstatement5.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:48:4: whilestatement
				{
				DebugLocation(48, 4);
				PushFollow(Follow._whilestatement_in_statement346);
				whilestatement6=whilestatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, whilestatement6.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:49:4: forstatement
				{
				DebugLocation(49, 4);
				PushFollow(Follow._forstatement_in_statement351);
				forstatement7=forstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forstatement7.Tree);

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// MathLang.g:50:4: funcdeclaration
				{
				DebugLocation(50, 4);
				PushFollow(Follow._funcdeclaration_in_statement356);
				funcdeclaration8=funcdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funcdeclaration8.Tree);

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// MathLang.g:51:4: returnstatement
				{
				DebugLocation(51, 4);
				PushFollow(Follow._returnstatement_in_statement361);
				returnstatement9=returnstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, returnstatement9.Tree);

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// MathLang.g:52:4: funccall
				{
				DebugLocation(52, 4);
				PushFollow(Follow._funccall_in_statement366);
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
		DebugLocation(52, 13);
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
	// MathLang.g:54:1: number : ( NUMBER | ID | funccallbody | CHAR | arrayelement );
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
		DebugLocation(54, 16);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 3)) { return retval; }
			// MathLang.g:54:8: ( NUMBER | ID | funccallbody | CHAR | arrayelement )
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
				case 53:
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
				case 52:
				case 54:
				case 55:
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
				// MathLang.g:54:11: NUMBER
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(54, 11);
				NUMBER11=(IToken)Match(input,NUMBER,Follow._NUMBER_in_number377); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				NUMBER11_tree = (object)adaptor.Create(NUMBER11);
				adaptor.AddChild(root_0, NUMBER11_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:55:5: ID
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(55, 5);
				ID12=(IToken)Match(input,ID,Follow._ID_in_number383); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				ID12_tree = (object)adaptor.Create(ID12);
				adaptor.AddChild(root_0, ID12_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:56:5: funccallbody
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(56, 5);
				PushFollow(Follow._funccallbody_in_number389);
				funccallbody13=funccallbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody13.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:57:5: CHAR
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(57, 5);
				CHAR14=(IToken)Match(input,CHAR,Follow._CHAR_in_number395); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				CHAR14_tree = (object)adaptor.Create(CHAR14);
				adaptor.AddChild(root_0, CHAR14_tree);
				}

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:58:5: arrayelement
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(58, 5);
				PushFollow(Follow._arrayelement_in_number401);
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
		DebugLocation(58, 16);
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
	// MathLang.g:59:1: mathexpression : term ;
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
		DebugLocation(59, 21);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 4)) { return retval; }
			// MathLang.g:59:15: ( term )
			DebugEnterAlt(1);
			// MathLang.g:59:17: term
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(59, 17);
			PushFollow(Follow._term_in_mathexpression407);
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
		DebugLocation(59, 21);
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
	// MathLang.g:61:1: expression : ( newexpression | funccallbody | boolexpression | mathexpression );
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
		DebugLocation(61, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 5)) { return retval; }
			// MathLang.g:61:11: ( newexpression | funccallbody | boolexpression | mathexpression )
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
				// MathLang.g:62:5: newexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(62, 5);
				PushFollow(Follow._newexpression_in_expression421);
				newexpression17=newexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, newexpression17.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:63:5: funccallbody
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(63, 5);
				PushFollow(Follow._funccallbody_in_expression427);
				funccallbody18=funccallbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody18.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:64:5: boolexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(64, 5);
				PushFollow(Follow._boolexpression_in_expression433);
				boolexpression19=boolexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression19.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:65:5: mathexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(65, 5);
				PushFollow(Follow._mathexpression_in_expression439);
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
		DebugLocation(67, 0);
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
	// MathLang.g:69:1: arrayelement : ID '[' number ']' -> ^( ARRAYELEMENT ID number ) ;
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
		DebugLocation(69, 62);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 6)) { return retval; }
			// MathLang.g:69:13: ( ID '[' number ']' -> ^( ARRAYELEMENT ID number ) )
			DebugEnterAlt(1);
			// MathLang.g:69:16: ID '[' number ']'
			{
			DebugLocation(69, 16);
			ID21=(IToken)Match(input,ID,Follow._ID_in_arrayelement451); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID21);

			DebugLocation(69, 19);
			char_literal22=(IToken)Match(input,SQRBL,Follow._SQRBL_in_arrayelement453); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_SQRBL.Add(char_literal22);

			DebugLocation(69, 23);
			PushFollow(Follow._number_in_arrayelement455);
			number23=number();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_number.Add(number23.Tree);
			DebugLocation(69, 30);
			char_literal24=(IToken)Match(input,SQRBR,Follow._SQRBR_in_arrayelement457); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_SQRBR.Add(char_literal24);



			{
			// AST REWRITE
			// elements: number, ID
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 69:34: -> ^( ARRAYELEMENT ID number )
			{
				DebugLocation(69, 37);
				// MathLang.g:69:37: ^( ARRAYELEMENT ID number )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(69, 39);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYELEMENT, "ARRAYELEMENT"), root_1);

				DebugLocation(69, 52);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(69, 55);
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
		DebugLocation(69, 62);
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
	// MathLang.g:71:1: declaration : ( declarationbody ';' | longdeclaration );
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
		DebugLocation(71, 20);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 7)) { return retval; }
			// MathLang.g:71:12: ( declarationbody ';' | longdeclaration )
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
					else if ((LA4_2==52))
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
				// MathLang.g:71:14: declarationbody ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(71, 14);
				PushFollow(Follow._declarationbody_in_declaration475);
				declarationbody25=declarationbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, declarationbody25.Tree);
				DebugLocation(71, 33);
				char_literal26=(IToken)Match(input,52,Follow._52_in_declaration477); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:72:6: longdeclaration
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(72, 6);
				PushFollow(Follow._longdeclaration_in_declaration485);
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
		DebugLocation(72, 20);
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
	// MathLang.g:74:1: declarationbody : TYPE ID -> ^( VARDECLARATION TYPE ID ) ;
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
		DebugLocation(74, 54);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 8)) { return retval; }
			// MathLang.g:74:16: ( TYPE ID -> ^( VARDECLARATION TYPE ID ) )
			DebugEnterAlt(1);
			// MathLang.g:74:18: TYPE ID
			{
			DebugLocation(74, 18);
			TYPE28=(IToken)Match(input,TYPE,Follow._TYPE_in_declarationbody492); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE28);

			DebugLocation(74, 23);
			ID29=(IToken)Match(input,ID,Follow._ID_in_declarationbody494); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID29);



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
			// 74:26: -> ^( VARDECLARATION TYPE ID )
			{
				DebugLocation(74, 29);
				// MathLang.g:74:29: ^( VARDECLARATION TYPE ID )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(74, 31);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDECLARATION, "VARDECLARATION"), root_1);

				DebugLocation(74, 46);
				adaptor.AddChild(root_1, stream_TYPE.NextNode());
				DebugLocation(74, 51);
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
		DebugLocation(74, 54);
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
	// MathLang.g:75:1: longdeclaration : longdeclarationbody ';' ;
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
		DebugLocation(75, 42);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 9)) { return retval; }
			// MathLang.g:75:16: ( longdeclarationbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:75:18: longdeclarationbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(75, 18);
			PushFollow(Follow._longdeclarationbody_in_longdeclaration511);
			longdeclarationbody30=longdeclarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclarationbody30.Tree);
			DebugLocation(75, 41);
			char_literal31=(IToken)Match(input,52,Follow._52_in_longdeclaration513); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(75, 42);
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
	// MathLang.g:76:1: longdeclarationbody : TYPE ID ASSIGN expression -> ^( VARDECLARATION TYPE ID expression ) ;
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

		IToken TYPE32=null;
		IToken ID33=null;
		IToken ASSIGN34=null;
		MathLangParser.expression_return expression35 = default(MathLangParser.expression_return);

		object TYPE32_tree=null;
		object ID33_tree=null;
		object ASSIGN34_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "longdeclarationbody");
		DebugLocation(76, 87);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 10)) { return retval; }
			// MathLang.g:76:20: ( TYPE ID ASSIGN expression -> ^( VARDECLARATION TYPE ID expression ) )
			DebugEnterAlt(1);
			// MathLang.g:76:22: TYPE ID ASSIGN expression
			{
			DebugLocation(76, 22);
			TYPE32=(IToken)Match(input,TYPE,Follow._TYPE_in_longdeclarationbody521); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE32);

			DebugLocation(76, 27);
			ID33=(IToken)Match(input,ID,Follow._ID_in_longdeclarationbody523); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID33);

			DebugLocation(76, 30);
			ASSIGN34=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclarationbody525); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN34);

			DebugLocation(76, 37);
			PushFollow(Follow._expression_in_longdeclarationbody527);
			expression35=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression35.Tree);


			{
			// AST REWRITE
			// elements: expression, ID, TYPE
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 76:48: -> ^( VARDECLARATION TYPE ID expression )
			{
				DebugLocation(76, 51);
				// MathLang.g:76:51: ^( VARDECLARATION TYPE ID expression )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(76, 53);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDECLARATION, "VARDECLARATION"), root_1);

				DebugLocation(76, 68);
				adaptor.AddChild(root_1, stream_TYPE.NextNode());
				DebugLocation(76, 73);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(76, 76);
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
		DebugLocation(76, 87);
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
	// MathLang.g:78:1: add : mul ( ( ADD | SUB ) mul )* ;
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

		IToken set37=null;
		MathLangParser.mul_return mul36 = default(MathLangParser.mul_return);
		MathLangParser.mul_return mul38 = default(MathLangParser.mul_return);

		object set37_tree=null;

		try { DebugEnterRule(GrammarFileName, "add");
		DebugLocation(78, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 11)) { return retval; }
			// MathLang.g:78:4: ( mul ( ( ADD | SUB ) mul )* )
			DebugEnterAlt(1);
			// MathLang.g:78:6: mul ( ( ADD | SUB ) mul )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(78, 6);
			PushFollow(Follow._mul_in_add547);
			mul36=mul();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul36.Tree);
			DebugLocation(78, 10);
			// MathLang.g:78:10: ( ( ADD | SUB ) mul )*
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
					// MathLang.g:78:12: ( ADD | SUB ) mul
					{
					DebugLocation(78, 12);
					set37=(IToken)input.LT(1);
					set37=(IToken)input.LT(1);
					if ((input.LA(1)>=ADD && input.LA(1)<=SUB))
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

					DebugLocation(78, 25);
					PushFollow(Follow._mul_in_add560);
					mul38=mul();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul38.Tree);

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
		DebugLocation(78, 30);
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
	// MathLang.g:79:1: mul : group ( ( MUL | DIV ) group )* ;
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

		IToken set40=null;
		MathLangParser.group_return group39 = default(MathLangParser.group_return);
		MathLangParser.group_return group41 = default(MathLangParser.group_return);

		object set40_tree=null;

		try { DebugEnterRule(GrammarFileName, "mul");
		DebugLocation(79, 33);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 12)) { return retval; }
			// MathLang.g:79:4: ( group ( ( MUL | DIV ) group )* )
			DebugEnterAlt(1);
			// MathLang.g:79:6: group ( ( MUL | DIV ) group )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(79, 6);
			PushFollow(Follow._group_in_mul569);
			group39=group();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group39.Tree);
			DebugLocation(79, 12);
			// MathLang.g:79:12: ( ( MUL | DIV ) group )*
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
					// MathLang.g:79:14: ( MUL | DIV ) group
					{
					DebugLocation(79, 14);
					set40=(IToken)input.LT(1);
					set40=(IToken)input.LT(1);
					if ((input.LA(1)>=MUL && input.LA(1)<=DIV))
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

					DebugLocation(79, 27);
					PushFollow(Follow._group_in_mul582);
					group41=group();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group41.Tree);

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
		DebugLocation(79, 33);
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
	// MathLang.g:80:1: compare : add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )? ;
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

		IToken set43=null;
		MathLangParser.add_return add42 = default(MathLangParser.add_return);
		MathLangParser.add_return add44 = default(MathLangParser.add_return);

		object set43_tree=null;

		try { DebugEnterRule(GrammarFileName, "compare");
		DebugLocation(80, 60);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 13)) { return retval; }
			// MathLang.g:80:8: ( add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )? )
			DebugEnterAlt(1);
			// MathLang.g:80:10: add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(80, 10);
			PushFollow(Follow._add_in_compare590);
			add42=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add42.Tree);
			DebugLocation(80, 14);
			// MathLang.g:80:14: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
			int alt7=2;
			try { DebugEnterSubRule(7);
			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
			int LA7_0 = input.LA(1);

			if (((LA7_0>=NEQ && LA7_0<=EQ)))
			{
				int LA7_1 = input.LA(2);

				if ((EvaluatePredicate(synpred25_MathLang_fragment)))
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
				// MathLang.g:80:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
				{
				DebugLocation(80, 16);
				set43=(IToken)input.LT(1);
				set43=(IToken)input.LT(1);
				if ((input.LA(1)>=GREQ && input.LA(1)<=LS))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set43), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(80, 53);
				PushFollow(Follow._add_in_compare620);
				add44=add();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add44.Tree);

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
		DebugLocation(80, 60);
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
	// MathLang.g:81:1: term : add ;
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

		MathLangParser.add_return add45 = default(MathLangParser.add_return);


		try { DebugEnterRule(GrammarFileName, "term");
		DebugLocation(81, 9);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 14)) { return retval; }
			// MathLang.g:81:5: ( add )
			DebugEnterAlt(1);
			// MathLang.g:81:7: add
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(81, 7);
			PushFollow(Follow._add_in_term631);
			add45=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add45.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(81, 9);
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
	// MathLang.g:82:1: group : ( ( SUB )? '(' term ')' | number );
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

		IToken SUB46=null;
		IToken char_literal47=null;
		IToken char_literal49=null;
		MathLangParser.term_return term48 = default(MathLangParser.term_return);
		MathLangParser.number_return number50 = default(MathLangParser.number_return);

		object SUB46_tree=null;
		object char_literal47_tree=null;
		object char_literal49_tree=null;

		try { DebugEnterRule(GrammarFileName, "group");
		DebugLocation(82, 38);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 15)) { return retval; }
			// MathLang.g:82:6: ( ( SUB )? '(' term ')' | number )
			int alt9=2;
			try { DebugEnterDecision(9, decisionCanBacktrack[9]);
			int LA9_0 = input.LA(1);

			if ((LA9_0==SUB||LA9_0==53))
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
				// MathLang.g:82:8: ( SUB )? '(' term ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(82, 8);
				// MathLang.g:82:8: ( SUB )?
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
					// MathLang.g:82:9: SUB
					{
					DebugLocation(82, 12);
					SUB46=(IToken)Match(input,SUB,Follow._SUB_in_group638); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					SUB46_tree = (object)adaptor.Create(SUB46);
					root_0 = (object)adaptor.BecomeRoot(SUB46_tree, root_0);
					}

					}
					break;

				}
				} finally { DebugExitSubRule(8); }

				DebugLocation(82, 19);
				char_literal47=(IToken)Match(input,53,Follow._53_in_group643); if (state.failed) return retval;
				DebugLocation(82, 21);
				PushFollow(Follow._term_in_group646);
				term48=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term48.Tree);
				DebugLocation(82, 29);
				char_literal49=(IToken)Match(input,54,Follow._54_in_group648); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:82:33: number
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(82, 33);
				PushFollow(Follow._number_in_group653);
				number50=number();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, number50.Tree);

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
		DebugLocation(82, 38);
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
	// MathLang.g:84:1: assignment : assignmentbody ';' ;
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

		IToken char_literal52=null;
		MathLangParser.assignmentbody_return assignmentbody51 = default(MathLangParser.assignmentbody_return);

		object char_literal52_tree=null;

		try { DebugEnterRule(GrammarFileName, "assignment");
		DebugLocation(84, 31);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 16)) { return retval; }
			// MathLang.g:84:11: ( assignmentbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:84:13: assignmentbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(84, 13);
			PushFollow(Follow._assignmentbody_in_assignment660);
			assignmentbody51=assignmentbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentbody51.Tree);
			DebugLocation(84, 31);
			char_literal52=(IToken)Match(input,52,Follow._52_in_assignment662); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(84, 31);
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
	// MathLang.g:85:1: assignmentbody : ( ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) ) | ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) ) );
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

		IToken ID53=null;
		IToken ASSIGN54=null;
		IToken ASSIGN57=null;
		MathLangParser.expression_return expression55 = default(MathLangParser.expression_return);
		MathLangParser.arrayelement_return arrayelement56 = default(MathLangParser.arrayelement_return);
		MathLangParser.expression_return expression58 = default(MathLangParser.expression_return);

		object ID53_tree=null;
		object ASSIGN54_tree=null;
		object ASSIGN57_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_arrayelement=new RewriteRuleSubtreeStream(adaptor,"rule arrayelement");
		try { DebugEnterRule(GrammarFileName, "assignmentbody");
		DebugLocation(85, 87);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 17)) { return retval; }
			// MathLang.g:85:15: ( ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) ) | ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) ) )
			int alt10=2;
			try { DebugEnterDecision(10, decisionCanBacktrack[10]);
			int LA10_0 = input.LA(1);

			if ((LA10_0==ID))
			{
				int LA10_1 = input.LA(2);

				if ((LA10_1==ASSIGN))
				{
					alt10=1;
				}
				else if ((LA10_1==SQRBL))
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
				// MathLang.g:85:17: ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) )
				{
				DebugLocation(85, 17);
				// MathLang.g:85:17: ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) )
				DebugEnterAlt(1);
				// MathLang.g:85:18: ID ASSIGN expression
				{
				DebugLocation(85, 18);
				ID53=(IToken)Match(input,ID,Follow._ID_in_assignmentbody670); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID53);

				DebugLocation(85, 21);
				ASSIGN54=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignmentbody672); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN54);

				DebugLocation(85, 28);
				PushFollow(Follow._expression_in_assignmentbody674);
				expression55=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression55.Tree);


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
				// 85:39: -> ^( VARASSIGNMENT ID expression )
				{
					DebugLocation(85, 42);
					// MathLang.g:85:42: ^( VARASSIGNMENT ID expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(85, 44);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARASSIGNMENT, "VARASSIGNMENT"), root_1);

					DebugLocation(85, 58);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(85, 61);
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
				// MathLang.g:86:2: ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) )
				{
				DebugLocation(86, 2);
				// MathLang.g:86:2: ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) )
				DebugEnterAlt(1);
				// MathLang.g:86:4: arrayelement ASSIGN expression
				{
				DebugLocation(86, 4);
				PushFollow(Follow._arrayelement_in_assignmentbody693);
				arrayelement56=arrayelement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_arrayelement.Add(arrayelement56.Tree);
				DebugLocation(86, 17);
				ASSIGN57=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignmentbody695); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN57);

				DebugLocation(86, 24);
				PushFollow(Follow._expression_in_assignmentbody697);
				expression58=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression58.Tree);


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
				// 86:35: -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression )
				{
					DebugLocation(86, 38);
					// MathLang.g:86:38: ^( ARRAYELEMENTASSIGNMENT arrayelement expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(86, 40);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYELEMENTASSIGNMENT, "ARRAYELEMENTASSIGNMENT"), root_1);

					DebugLocation(86, 63);
					adaptor.AddChild(root_1, stream_arrayelement.NextTree());
					DebugLocation(86, 76);
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
		DebugLocation(86, 87);
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
	// MathLang.g:88:1: boolexpression : boolterm ;
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

		MathLangParser.boolterm_return boolterm59 = default(MathLangParser.boolterm_return);


		try { DebugEnterRule(GrammarFileName, "boolexpression");
		DebugLocation(88, 25);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 18)) { return retval; }
			// MathLang.g:88:15: ( boolterm )
			DebugEnterAlt(1);
			// MathLang.g:88:17: boolterm
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(88, 17);
			PushFollow(Follow._boolterm_in_boolexpression715);
			boolterm59=boolterm();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm59.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(88, 25);
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
	// MathLang.g:89:1: boolterm : or ( ( EQ | NEQ ) or )? ;
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

		IToken set61=null;
		MathLangParser.or_return or60 = default(MathLangParser.or_return);
		MathLangParser.or_return or62 = default(MathLangParser.or_return);

		object set61_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolterm");
		DebugLocation(89, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 19)) { return retval; }
			// MathLang.g:89:9: ( or ( ( EQ | NEQ ) or )? )
			DebugEnterAlt(1);
			// MathLang.g:89:11: or ( ( EQ | NEQ ) or )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(89, 11);
			PushFollow(Follow._or_in_boolterm722);
			or60=or();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or60.Tree);
			DebugLocation(89, 14);
			// MathLang.g:89:14: ( ( EQ | NEQ ) or )?
			int alt11=2;
			try { DebugEnterSubRule(11);
			try { DebugEnterDecision(11, decisionCanBacktrack[11]);
			int LA11_0 = input.LA(1);

			if (((LA11_0>=NEQ && LA11_0<=EQ)))
			{
				alt11=1;
			}
			} finally { DebugExitDecision(11); }
			switch (alt11)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:89:16: ( EQ | NEQ ) or
				{
				DebugLocation(89, 16);
				set61=(IToken)input.LT(1);
				set61=(IToken)input.LT(1);
				if ((input.LA(1)>=NEQ && input.LA(1)<=EQ))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set61), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(89, 28);
				PushFollow(Follow._or_in_boolterm735);
				or62=or();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or62.Tree);

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
			TraceOut("boolterm", 19);
			LeaveRule("boolterm", 19);
			Leave_boolterm();
			if (state.backtracking > 0) { Memoize(input, 19, boolterm_StartIndex); }
		}
		DebugLocation(89, 32);
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
	// MathLang.g:90:1: or : and ( OR and )* ;
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

		IToken OR64=null;
		MathLangParser.and_return and63 = default(MathLangParser.and_return);
		MathLangParser.and_return and65 = default(MathLangParser.and_return);

		object OR64_tree=null;

		try { DebugEnterRule(GrammarFileName, "or");
		DebugLocation(90, 18);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 20)) { return retval; }
			// MathLang.g:90:3: ( and ( OR and )* )
			DebugEnterAlt(1);
			// MathLang.g:90:5: and ( OR and )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(90, 5);
			PushFollow(Follow._and_in_or744);
			and63=and();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and63.Tree);
			DebugLocation(90, 9);
			// MathLang.g:90:9: ( OR and )*
			try { DebugEnterSubRule(12);
			while (true)
			{
				int alt12=2;
				try { DebugEnterDecision(12, decisionCanBacktrack[12]);
				int LA12_0 = input.LA(1);

				if ((LA12_0==OR))
				{
					alt12=1;
				}


				} finally { DebugExitDecision(12); }
				switch ( alt12 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:90:10: OR and
					{
					DebugLocation(90, 12);
					OR64=(IToken)Match(input,OR,Follow._OR_in_or747); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR64_tree = (object)adaptor.Create(OR64);
					root_0 = (object)adaptor.BecomeRoot(OR64_tree, root_0);
					}
					DebugLocation(90, 14);
					PushFollow(Follow._and_in_or750);
					and65=and();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and65.Tree);

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
			TraceOut("or", 20);
			LeaveRule("or", 20);
			Leave_or();
			if (state.backtracking > 0) { Memoize(input, 20, or_StartIndex); }
		}
		DebugLocation(90, 18);
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
	// MathLang.g:91:1: and : boolgroup ( AND boolgroup )* ;
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

		IToken AND67=null;
		MathLangParser.boolgroup_return boolgroup66 = default(MathLangParser.boolgroup_return);
		MathLangParser.boolgroup_return boolgroup68 = default(MathLangParser.boolgroup_return);

		object AND67_tree=null;

		try { DebugEnterRule(GrammarFileName, "and");
		DebugLocation(91, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 21)) { return retval; }
			// MathLang.g:91:4: ( boolgroup ( AND boolgroup )* )
			DebugEnterAlt(1);
			// MathLang.g:91:6: boolgroup ( AND boolgroup )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(91, 6);
			PushFollow(Follow._boolgroup_in_and758);
			boolgroup66=boolgroup();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup66.Tree);
			DebugLocation(91, 16);
			// MathLang.g:91:16: ( AND boolgroup )*
			try { DebugEnterSubRule(13);
			while (true)
			{
				int alt13=2;
				try { DebugEnterDecision(13, decisionCanBacktrack[13]);
				int LA13_0 = input.LA(1);

				if ((LA13_0==AND))
				{
					alt13=1;
				}


				} finally { DebugExitDecision(13); }
				switch ( alt13 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:91:17: AND boolgroup
					{
					DebugLocation(91, 20);
					AND67=(IToken)Match(input,AND,Follow._AND_in_and761); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND67_tree = (object)adaptor.Create(AND67);
					root_0 = (object)adaptor.BecomeRoot(AND67_tree, root_0);
					}
					DebugLocation(91, 22);
					PushFollow(Follow._boolgroup_in_and764);
					boolgroup68=boolgroup();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup68.Tree);

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
			TraceOut("and", 21);
			LeaveRule("and", 21);
			Leave_and();
			if (state.backtracking > 0) { Memoize(input, 21, and_StartIndex); }
		}
		DebugLocation(91, 32);
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
	// MathLang.g:92:1: boolgroup : ( NOT )? ( '(' boolterm ')' | boolvar ) ;
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

		IToken NOT69=null;
		IToken char_literal70=null;
		IToken char_literal72=null;
		MathLangParser.boolterm_return boolterm71 = default(MathLangParser.boolterm_return);
		MathLangParser.boolvar_return boolvar73 = default(MathLangParser.boolvar_return);

		object NOT69_tree=null;
		object char_literal70_tree=null;
		object char_literal72_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolgroup");
		DebugLocation(92, 51);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 22)) { return retval; }
			// MathLang.g:92:10: ( ( NOT )? ( '(' boolterm ')' | boolvar ) )
			DebugEnterAlt(1);
			// MathLang.g:92:12: ( NOT )? ( '(' boolterm ')' | boolvar )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(92, 12);
			// MathLang.g:92:12: ( NOT )?
			int alt14=2;
			try { DebugEnterSubRule(14);
			try { DebugEnterDecision(14, decisionCanBacktrack[14]);
			int LA14_0 = input.LA(1);

			if ((LA14_0==NOT))
			{
				alt14=1;
			}
			} finally { DebugExitDecision(14); }
			switch (alt14)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:92:13: NOT
				{
				DebugLocation(92, 16);
				NOT69=(IToken)Match(input,NOT,Follow._NOT_in_boolgroup773); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				NOT69_tree = (object)adaptor.Create(NOT69);
				root_0 = (object)adaptor.BecomeRoot(NOT69_tree, root_0);
				}

				}
				break;

			}
			} finally { DebugExitSubRule(14); }

			DebugLocation(92, 20);
			// MathLang.g:92:20: ( '(' boolterm ')' | boolvar )
			int alt15=2;
			try { DebugEnterSubRule(15);
			try { DebugEnterDecision(15, decisionCanBacktrack[15]);
			int LA15_0 = input.LA(1);

			if ((LA15_0==53))
			{
				int LA15_1 = input.LA(2);

				if ((EvaluatePredicate(synpred34_MathLang_fragment)))
				{
					alt15=1;
				}
				else if ((true))
				{
					alt15=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 15, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else if (((LA15_0>=NUMBER && LA15_0<=CHAR)||LA15_0==SUB||(LA15_0>=TRUE && LA15_0<=FALSE)))
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
				// MathLang.g:92:22: '(' boolterm ')'
				{
				DebugLocation(92, 25);
				char_literal70=(IToken)Match(input,53,Follow._53_in_boolgroup780); if (state.failed) return retval;
				DebugLocation(92, 27);
				PushFollow(Follow._boolterm_in_boolgroup783);
				boolterm71=boolterm();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm71.Tree);
				DebugLocation(92, 39);
				char_literal72=(IToken)Match(input,54,Follow._54_in_boolgroup785); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:92:43: boolvar
				{
				DebugLocation(92, 43);
				PushFollow(Follow._boolvar_in_boolgroup790);
				boolvar73=boolvar();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolvar73.Tree);

				}
				break;

			}
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
			TraceOut("boolgroup", 22);
			LeaveRule("boolgroup", 22);
			Leave_boolgroup();
			if (state.backtracking > 0) { Memoize(input, 22, boolgroup_StartIndex); }
		}
		DebugLocation(92, 51);
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
	// MathLang.g:93:1: boolvar : ( TRUE | FALSE | compare );
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

		IToken TRUE74=null;
		IToken FALSE75=null;
		MathLangParser.compare_return compare76 = default(MathLangParser.compare_return);

		object TRUE74_tree=null;
		object FALSE75_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolvar");
		DebugLocation(93, 11);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 23)) { return retval; }
			// MathLang.g:93:8: ( TRUE | FALSE | compare )
			int alt16=3;
			try { DebugEnterDecision(16, decisionCanBacktrack[16]);
			switch (input.LA(1))
			{
			case TRUE:
				{
				alt16=1;
				}
				break;
			case FALSE:
				{
				alt16=2;
				}
				break;
			case NUMBER:
			case ID:
			case CHAR:
			case SUB:
			case 53:
				{
				alt16=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 16, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(16); }
			switch (alt16)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:93:10: TRUE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(93, 10);
				TRUE74=(IToken)Match(input,TRUE,Follow._TRUE_in_boolvar798); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				TRUE74_tree = (object)adaptor.Create(TRUE74);
				adaptor.AddChild(root_0, TRUE74_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:94:5: FALSE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(94, 5);
				FALSE75=(IToken)Match(input,FALSE,Follow._FALSE_in_boolvar804); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				FALSE75_tree = (object)adaptor.Create(FALSE75);
				adaptor.AddChild(root_0, FALSE75_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:95:5: compare
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(95, 5);
				PushFollow(Follow._compare_in_boolvar810);
				compare76=compare();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare76.Tree);

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
		DebugLocation(95, 11);
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
	// MathLang.g:97:1: ifstatement : IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )* ;
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

		IToken IF77=null;
		IToken char_literal78=null;
		IToken char_literal80=null;
		IToken ELSE83=null;
		MathLangParser.boolexpression_return boolexpression79 = default(MathLangParser.boolexpression_return);
		MathLangParser.block_return block81 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement82 = default(MathLangParser.statement_return);
		MathLangParser.block_return block84 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement85 = default(MathLangParser.statement_return);

		object IF77_tree=null;
		object char_literal78_tree=null;
		object char_literal80_tree=null;
		object ELSE83_tree=null;

		try { DebugEnterRule(GrammarFileName, "ifstatement");
		DebugLocation(97, 91);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 24)) { return retval; }
			// MathLang.g:97:12: ( IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )* )
			DebugEnterAlt(1);
			// MathLang.g:97:14: IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(97, 16);
			IF77=(IToken)Match(input,IF,Follow._IF_in_ifstatement817); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			IF77_tree = (object)adaptor.Create(IF77);
			root_0 = (object)adaptor.BecomeRoot(IF77_tree, root_0);
			}
			DebugLocation(97, 21);
			char_literal78=(IToken)Match(input,53,Follow._53_in_ifstatement820); if (state.failed) return retval;
			DebugLocation(97, 23);
			PushFollow(Follow._boolexpression_in_ifstatement823);
			boolexpression79=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression79.Tree);
			DebugLocation(97, 41);
			char_literal80=(IToken)Match(input,54,Follow._54_in_ifstatement825); if (state.failed) return retval;
			DebugLocation(97, 43);
			// MathLang.g:97:43: ( block | statement )
			int alt17=2;
			try { DebugEnterSubRule(17);
			try { DebugEnterDecision(17, decisionCanBacktrack[17]);
			int LA17_0 = input.LA(1);

			if ((LA17_0==56))
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
				// MathLang.g:97:44: block
				{
				DebugLocation(97, 44);
				PushFollow(Follow._block_in_ifstatement829);
				block81=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block81.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:97:52: statement
				{
				DebugLocation(97, 52);
				PushFollow(Follow._statement_in_ifstatement833);
				statement82=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement82.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(17); }

			DebugLocation(97, 63);
			// MathLang.g:97:63: ( ELSE ( block | statement ) )*
			try { DebugEnterSubRule(19);
			while (true)
			{
				int alt19=2;
				try { DebugEnterDecision(19, decisionCanBacktrack[19]);
				int LA19_0 = input.LA(1);

				if ((LA19_0==ELSE))
				{
					int LA19_1 = input.LA(2);

					if ((EvaluatePredicate(synpred39_MathLang_fragment)))
					{
						alt19=1;
					}


				}


				} finally { DebugExitDecision(19); }
				switch ( alt19 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:97:64: ELSE ( block | statement )
					{
					DebugLocation(97, 68);
					ELSE83=(IToken)Match(input,ELSE,Follow._ELSE_in_ifstatement837); if (state.failed) return retval;
					DebugLocation(97, 70);
					// MathLang.g:97:70: ( block | statement )
					int alt18=2;
					try { DebugEnterSubRule(18);
					try { DebugEnterDecision(18, decisionCanBacktrack[18]);
					int LA18_0 = input.LA(1);

					if ((LA18_0==56))
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
						// MathLang.g:97:71: block
						{
						DebugLocation(97, 71);
						PushFollow(Follow._block_in_ifstatement841);
						block84=block();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block84.Tree);

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// MathLang.g:97:79: statement
						{
						DebugLocation(97, 79);
						PushFollow(Follow._statement_in_ifstatement845);
						statement85=statement();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement85.Tree);

						}
						break;

					}
					} finally { DebugExitSubRule(18); }


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

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(97, 91);
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
	// MathLang.g:98:1: whilestatement : WHILE '(' boolexpression ')' ( block | statement ) ;
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

		IToken WHILE86=null;
		IToken char_literal87=null;
		IToken char_literal89=null;
		MathLangParser.boolexpression_return boolexpression88 = default(MathLangParser.boolexpression_return);
		MathLangParser.block_return block90 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement91 = default(MathLangParser.statement_return);

		object WHILE86_tree=null;
		object char_literal87_tree=null;
		object char_literal89_tree=null;

		try { DebugEnterRule(GrammarFileName, "whilestatement");
		DebugLocation(98, 67);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 25)) { return retval; }
			// MathLang.g:98:15: ( WHILE '(' boolexpression ')' ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:98:17: WHILE '(' boolexpression ')' ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(98, 22);
			WHILE86=(IToken)Match(input,WHILE,Follow._WHILE_in_whilestatement855); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			WHILE86_tree = (object)adaptor.Create(WHILE86);
			root_0 = (object)adaptor.BecomeRoot(WHILE86_tree, root_0);
			}
			DebugLocation(98, 27);
			char_literal87=(IToken)Match(input,53,Follow._53_in_whilestatement858); if (state.failed) return retval;
			DebugLocation(98, 29);
			PushFollow(Follow._boolexpression_in_whilestatement861);
			boolexpression88=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression88.Tree);
			DebugLocation(98, 47);
			char_literal89=(IToken)Match(input,54,Follow._54_in_whilestatement863); if (state.failed) return retval;
			DebugLocation(98, 49);
			// MathLang.g:98:49: ( block | statement )
			int alt20=2;
			try { DebugEnterSubRule(20);
			try { DebugEnterDecision(20, decisionCanBacktrack[20]);
			int LA20_0 = input.LA(1);

			if ((LA20_0==56))
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
				// MathLang.g:98:50: block
				{
				DebugLocation(98, 50);
				PushFollow(Follow._block_in_whilestatement867);
				block90=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block90.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:98:58: statement
				{
				DebugLocation(98, 58);
				PushFollow(Follow._statement_in_whilestatement871);
				statement91=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement91.Tree);

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
			TraceOut("whilestatement", 25);
			LeaveRule("whilestatement", 25);
			Leave_whilestatement();
			if (state.backtracking > 0) { Memoize(input, 25, whilestatement_StartIndex); }
		}
		DebugLocation(98, 67);
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
	// MathLang.g:99:1: forstatement : FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement ) ;
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

		IToken FOR92=null;
		IToken char_literal93=null;
		IToken char_literal95=null;
		IToken char_literal97=null;
		IToken char_literal99=null;
		MathLangParser.longdeclarationbody_return longdeclarationbody94 = default(MathLangParser.longdeclarationbody_return);
		MathLangParser.boolexpression_return boolexpression96 = default(MathLangParser.boolexpression_return);
		MathLangParser.assignmentbody_return assignmentbody98 = default(MathLangParser.assignmentbody_return);
		MathLangParser.block_return block100 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement101 = default(MathLangParser.statement_return);

		object FOR92_tree=null;
		object char_literal93_tree=null;
		object char_literal95_tree=null;
		object char_literal97_tree=null;
		object char_literal99_tree=null;

		try { DebugEnterRule(GrammarFileName, "forstatement");
		DebugLocation(99, 108);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 26)) { return retval; }
			// MathLang.g:99:13: ( FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:99:15: FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(99, 18);
			FOR92=(IToken)Match(input,FOR,Follow._FOR_in_forstatement878); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			FOR92_tree = (object)adaptor.Create(FOR92);
			root_0 = (object)adaptor.BecomeRoot(FOR92_tree, root_0);
			}
			DebugLocation(99, 23);
			char_literal93=(IToken)Match(input,53,Follow._53_in_forstatement881); if (state.failed) return retval;
			DebugLocation(99, 25);
			PushFollow(Follow._longdeclarationbody_in_forstatement884);
			longdeclarationbody94=longdeclarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclarationbody94.Tree);
			DebugLocation(99, 48);
			char_literal95=(IToken)Match(input,52,Follow._52_in_forstatement886); if (state.failed) return retval;
			DebugLocation(99, 50);
			PushFollow(Follow._boolexpression_in_forstatement889);
			boolexpression96=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression96.Tree);
			DebugLocation(99, 68);
			char_literal97=(IToken)Match(input,52,Follow._52_in_forstatement891); if (state.failed) return retval;
			DebugLocation(99, 70);
			PushFollow(Follow._assignmentbody_in_forstatement894);
			assignmentbody98=assignmentbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentbody98.Tree);
			DebugLocation(99, 88);
			char_literal99=(IToken)Match(input,54,Follow._54_in_forstatement896); if (state.failed) return retval;
			DebugLocation(99, 90);
			// MathLang.g:99:90: ( block | statement )
			int alt21=2;
			try { DebugEnterSubRule(21);
			try { DebugEnterDecision(21, decisionCanBacktrack[21]);
			int LA21_0 = input.LA(1);

			if ((LA21_0==56))
			{
				alt21=1;
			}
			else if ((LA21_0==IF||LA21_0==FOR||(LA21_0>=RETURN && LA21_0<=WHILE)||LA21_0==ID||LA21_0==TYPE))
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
				// MathLang.g:99:91: block
				{
				DebugLocation(99, 91);
				PushFollow(Follow._block_in_forstatement900);
				block100=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block100.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:99:99: statement
				{
				DebugLocation(99, 99);
				PushFollow(Follow._statement_in_forstatement904);
				statement101=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement101.Tree);

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
			TraceOut("forstatement", 26);
			LeaveRule("forstatement", 26);
			Leave_forstatement();
			if (state.backtracking > 0) { Memoize(input, 26, forstatement_StartIndex); }
		}
		DebugLocation(99, 108);
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
	// MathLang.g:100:1: returnstatement : RETURN expression ';' ;
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

		IToken RETURN102=null;
		IToken char_literal104=null;
		MathLangParser.expression_return expression103 = default(MathLangParser.expression_return);

		object RETURN102_tree=null;
		object char_literal104_tree=null;

		try { DebugEnterRule(GrammarFileName, "returnstatement");
		DebugLocation(100, 41);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 27)) { return retval; }
			// MathLang.g:100:16: ( RETURN expression ';' )
			DebugEnterAlt(1);
			// MathLang.g:100:18: RETURN expression ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(100, 24);
			RETURN102=(IToken)Match(input,RETURN,Follow._RETURN_in_returnstatement911); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			RETURN102_tree = (object)adaptor.Create(RETURN102);
			root_0 = (object)adaptor.BecomeRoot(RETURN102_tree, root_0);
			}
			DebugLocation(100, 26);
			PushFollow(Follow._expression_in_returnstatement914);
			expression103=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression103.Tree);
			DebugLocation(100, 40);
			char_literal104=(IToken)Match(input,52,Follow._52_in_returnstatement916); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(100, 41);
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
	// MathLang.g:102:1: funcdeclaration : TYPE ID '(' ( paramsdeclaration )? ')' block -> ^( FUNCDECLARATION ID ^( RETURNS TYPE ) ( paramsdeclaration )? block ) ;
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

		IToken TYPE105=null;
		IToken ID106=null;
		IToken char_literal107=null;
		IToken char_literal109=null;
		MathLangParser.paramsdeclaration_return paramsdeclaration108 = default(MathLangParser.paramsdeclaration_return);
		MathLangParser.block_return block110 = default(MathLangParser.block_return);

		object TYPE105_tree=null;
		object ID106_tree=null;
		object char_literal107_tree=null;
		object char_literal109_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_53=new RewriteRuleITokenStream(adaptor,"token 53");
		RewriteRuleITokenStream stream_54=new RewriteRuleITokenStream(adaptor,"token 54");
		RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");
		RewriteRuleSubtreeStream stream_paramsdeclaration=new RewriteRuleSubtreeStream(adaptor,"rule paramsdeclaration");
		RewriteRuleSubtreeStream stream_block=new RewriteRuleSubtreeStream(adaptor,"rule block");
		try { DebugEnterRule(GrammarFileName, "funcdeclaration");
		DebugLocation(102, 136);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 28)) { return retval; }
			// MathLang.g:102:16: ( TYPE ID '(' ( paramsdeclaration )? ')' block -> ^( FUNCDECLARATION ID ^( RETURNS TYPE ) ( paramsdeclaration )? block ) )
			DebugEnterAlt(1);
			// MathLang.g:102:18: TYPE ID '(' ( paramsdeclaration )? ')' block
			{
			DebugLocation(102, 18);
			TYPE105=(IToken)Match(input,TYPE,Follow._TYPE_in_funcdeclaration925); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE105);

			DebugLocation(102, 25);
			ID106=(IToken)Match(input,ID,Follow._ID_in_funcdeclaration927); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID106);

			DebugLocation(102, 30);
			char_literal107=(IToken)Match(input,53,Follow._53_in_funcdeclaration930); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_53.Add(char_literal107);

			DebugLocation(102, 32);
			// MathLang.g:102:32: ( paramsdeclaration )?
			int alt22=2;
			try { DebugEnterSubRule(22);
			try { DebugEnterDecision(22, decisionCanBacktrack[22]);
			int LA22_0 = input.LA(1);

			if ((LA22_0==TYPE))
			{
				alt22=1;
			}
			} finally { DebugExitDecision(22); }
			switch (alt22)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: paramsdeclaration
				{
				DebugLocation(102, 32);
				PushFollow(Follow._paramsdeclaration_in_funcdeclaration933);
				paramsdeclaration108=paramsdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_paramsdeclaration.Add(paramsdeclaration108.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(22); }

			DebugLocation(102, 54);
			char_literal109=(IToken)Match(input,54,Follow._54_in_funcdeclaration936); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_54.Add(char_literal109);

			DebugLocation(102, 56);
			PushFollow(Follow._block_in_funcdeclaration939);
			block110=block();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_block.Add(block110.Tree);


			{
			// AST REWRITE
			// elements: TYPE, paramsdeclaration, ID, block
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 102:62: -> ^( FUNCDECLARATION ID ^( RETURNS TYPE ) ( paramsdeclaration )? block )
			{
				DebugLocation(102, 65);
				// MathLang.g:102:65: ^( FUNCDECLARATION ID ^( RETURNS TYPE ) ( paramsdeclaration )? block )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(102, 67);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNCDECLARATION, "FUNCDECLARATION"), root_1);

				DebugLocation(102, 83);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(102, 86);
				// MathLang.g:102:86: ^( RETURNS TYPE )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(102, 88);
				root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(RETURNS, "RETURNS"), root_2);

				DebugLocation(102, 96);
				adaptor.AddChild(root_2, stream_TYPE.NextNode());

				adaptor.AddChild(root_1, root_2);
				}
				DebugLocation(102, 107);
				// MathLang.g:102:107: ( paramsdeclaration )?
				if ( stream_paramsdeclaration.HasNext )
				{
					DebugLocation(102, 107);
					adaptor.AddChild(root_1, stream_paramsdeclaration.NextTree());

				}
				stream_paramsdeclaration.Reset();
				DebugLocation(102, 131);
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
		DebugLocation(102, 136);
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
	// MathLang.g:103:1: paramsdeclaration : ( declarationbody ( ',' declarationbody )* ) -> ^( PARAMETERS ( declarationbody )* ) ;
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

		IToken char_literal112=null;
		MathLangParser.declarationbody_return declarationbody111 = default(MathLangParser.declarationbody_return);
		MathLangParser.declarationbody_return declarationbody113 = default(MathLangParser.declarationbody_return);

		object char_literal112_tree=null;
		RewriteRuleITokenStream stream_55=new RewriteRuleITokenStream(adaptor,"token 55");
		RewriteRuleSubtreeStream stream_declarationbody=new RewriteRuleSubtreeStream(adaptor,"rule declarationbody");
		try { DebugEnterRule(GrammarFileName, "paramsdeclaration");
		DebugLocation(103, 102);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 29)) { return retval; }
			// MathLang.g:103:18: ( ( declarationbody ( ',' declarationbody )* ) -> ^( PARAMETERS ( declarationbody )* ) )
			DebugEnterAlt(1);
			// MathLang.g:103:20: ( declarationbody ( ',' declarationbody )* )
			{
			DebugLocation(103, 20);
			// MathLang.g:103:20: ( declarationbody ( ',' declarationbody )* )
			DebugEnterAlt(1);
			// MathLang.g:103:22: declarationbody ( ',' declarationbody )*
			{
			DebugLocation(103, 22);
			PushFollow(Follow._declarationbody_in_paramsdeclaration972);
			declarationbody111=declarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declarationbody.Add(declarationbody111.Tree);
			DebugLocation(103, 38);
			// MathLang.g:103:38: ( ',' declarationbody )*
			try { DebugEnterSubRule(23);
			while (true)
			{
				int alt23=2;
				try { DebugEnterDecision(23, decisionCanBacktrack[23]);
				int LA23_0 = input.LA(1);

				if ((LA23_0==55))
				{
					alt23=1;
				}


				} finally { DebugExitDecision(23); }
				switch ( alt23 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:103:40: ',' declarationbody
					{
					DebugLocation(103, 43);
					char_literal112=(IToken)Match(input,55,Follow._55_in_paramsdeclaration976); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_55.Add(char_literal112);

					DebugLocation(103, 45);
					PushFollow(Follow._declarationbody_in_paramsdeclaration979);
					declarationbody113=declarationbody();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_declarationbody.Add(declarationbody113.Tree);

					}
					break;

				default:
					goto loop23;
				}
			}

			loop23:
				;

			} finally { DebugExitSubRule(23); }


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
			// 103:66: -> ^( PARAMETERS ( declarationbody )* )
			{
				DebugLocation(103, 69);
				// MathLang.g:103:69: ^( PARAMETERS ( declarationbody )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(103, 71);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_1);

				DebugLocation(103, 82);
				// MathLang.g:103:82: ( declarationbody )*
				while ( stream_declarationbody.HasNext )
				{
					DebugLocation(103, 84);
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
		DebugLocation(103, 102);
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
	// MathLang.g:105:1: funccallbody : ID '(' ( expressioncommalist )? ')' ;
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

		IToken ID114=null;
		IToken char_literal115=null;
		IToken char_literal117=null;
		MathLangParser.expressioncommalist_return expressioncommalist116 = default(MathLangParser.expressioncommalist_return);

		object ID114_tree=null;
		object char_literal115_tree=null;
		object char_literal117_tree=null;

		try { DebugEnterRule(GrammarFileName, "funccallbody");
		DebugLocation(105, 46);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 30)) { return retval; }
			// MathLang.g:105:13: ( ID '(' ( expressioncommalist )? ')' )
			DebugEnterAlt(1);
			// MathLang.g:105:15: ID '(' ( expressioncommalist )? ')'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(105, 17);
			ID114=(IToken)Match(input,ID,Follow._ID_in_funccallbody1004); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			ID114_tree = (object)adaptor.Create(ID114);
			root_0 = (object)adaptor.BecomeRoot(ID114_tree, root_0);
			}
			DebugLocation(105, 19);
			char_literal115=(IToken)Match(input,53,Follow._53_in_funccallbody1007); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal115_tree = (object)adaptor.Create(char_literal115);
			adaptor.AddChild(root_0, char_literal115_tree);
			}
			DebugLocation(105, 23);
			// MathLang.g:105:23: ( expressioncommalist )?
			int alt24=2;
			try { DebugEnterSubRule(24);
			try { DebugEnterDecision(24, decisionCanBacktrack[24]);
			int LA24_0 = input.LA(1);

			if (((LA24_0>=NUMBER && LA24_0<=CHAR)||LA24_0==SUB||(LA24_0>=NOT && LA24_0<=KNEW)||LA24_0==53))
			{
				alt24=1;
			}
			} finally { DebugExitDecision(24); }
			switch (alt24)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: expressioncommalist
				{
				DebugLocation(105, 23);
				PushFollow(Follow._expressioncommalist_in_funccallbody1009);
				expressioncommalist116=expressioncommalist();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expressioncommalist116.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(24); }

			DebugLocation(105, 44);
			char_literal117=(IToken)Match(input,54,Follow._54_in_funccallbody1012); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal117_tree = (object)adaptor.Create(char_literal117);
			adaptor.AddChild(root_0, char_literal117_tree);
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
		DebugLocation(105, 46);
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
	// MathLang.g:106:1: funccall : funccallbody ';' ;
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

		IToken char_literal119=null;
		MathLangParser.funccallbody_return funccallbody118 = default(MathLangParser.funccallbody_return);

		object char_literal119_tree=null;

		try { DebugEnterRule(GrammarFileName, "funccall");
		DebugLocation(106, 27);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 31)) { return retval; }
			// MathLang.g:106:9: ( funccallbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:106:11: funccallbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(106, 11);
			PushFollow(Follow._funccallbody_in_funccall1018);
			funccallbody118=funccallbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody118.Tree);
			DebugLocation(106, 27);
			char_literal119=(IToken)Match(input,52,Follow._52_in_funccall1020); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(106, 27);
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
	// MathLang.g:107:1: expressioncommalist : expression ( ',' expression )* -> ^( PARAMETERS ( expression )* ) ;
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

		IToken char_literal121=null;
		MathLangParser.expression_return expression120 = default(MathLangParser.expression_return);
		MathLangParser.expression_return expression122 = default(MathLangParser.expression_return);

		object char_literal121_tree=null;
		RewriteRuleITokenStream stream_55=new RewriteRuleITokenStream(adaptor,"token 55");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "expressioncommalist");
		DebugLocation(107, 83);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 32)) { return retval; }
			// MathLang.g:107:20: ( expression ( ',' expression )* -> ^( PARAMETERS ( expression )* ) )
			DebugEnterAlt(1);
			// MathLang.g:107:22: expression ( ',' expression )*
			{
			DebugLocation(107, 22);
			PushFollow(Follow._expression_in_expressioncommalist1027);
			expression120=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression120.Tree);
			DebugLocation(107, 33);
			// MathLang.g:107:33: ( ',' expression )*
			try { DebugEnterSubRule(25);
			while (true)
			{
				int alt25=2;
				try { DebugEnterDecision(25, decisionCanBacktrack[25]);
				int LA25_0 = input.LA(1);

				if ((LA25_0==55))
				{
					alt25=1;
				}


				} finally { DebugExitDecision(25); }
				switch ( alt25 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:107:35: ',' expression
					{
					DebugLocation(107, 38);
					char_literal121=(IToken)Match(input,55,Follow._55_in_expressioncommalist1031); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_55.Add(char_literal121);

					DebugLocation(107, 40);
					PushFollow(Follow._expression_in_expressioncommalist1034);
					expression122=expression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_expression.Add(expression122.Tree);

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
			// 107:53: -> ^( PARAMETERS ( expression )* )
			{
				DebugLocation(107, 56);
				// MathLang.g:107:56: ^( PARAMETERS ( expression )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(107, 58);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_1);

				DebugLocation(107, 69);
				// MathLang.g:107:69: ( expression )*
				while ( stream_expression.HasNext )
				{
					DebugLocation(107, 70);
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
		DebugLocation(107, 83);
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
	// MathLang.g:110:1: newexpression : KNEW TYPE0 SQRBL NUMBER SQRBR NUMBER -> ^( NEWWORD TYPE0 NUMBER ) ;
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

		IToken KNEW123=null;
		IToken TYPE0124=null;
		IToken SQRBL125=null;
		IToken NUMBER126=null;
		IToken SQRBR127=null;
		IToken NUMBER128=null;

		object KNEW123_tree=null;
		object TYPE0124_tree=null;
		object SQRBL125_tree=null;
		object NUMBER126_tree=null;
		object SQRBR127_tree=null;
		object NUMBER128_tree=null;
		RewriteRuleITokenStream stream_SQRBR=new RewriteRuleITokenStream(adaptor,"token SQRBR");
		RewriteRuleITokenStream stream_KNEW=new RewriteRuleITokenStream(adaptor,"token KNEW");
		RewriteRuleITokenStream stream_TYPE0=new RewriteRuleITokenStream(adaptor,"token TYPE0");
		RewriteRuleITokenStream stream_SQRBL=new RewriteRuleITokenStream(adaptor,"token SQRBL");
		RewriteRuleITokenStream stream_NUMBER=new RewriteRuleITokenStream(adaptor,"token NUMBER");

		try { DebugEnterRule(GrammarFileName, "newexpression");
		DebugLocation(110, 80);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 33)) { return retval; }
			// MathLang.g:110:14: ( KNEW TYPE0 SQRBL NUMBER SQRBR NUMBER -> ^( NEWWORD TYPE0 NUMBER ) )
			DebugEnterAlt(1);
			// MathLang.g:110:16: KNEW TYPE0 SQRBL NUMBER SQRBR NUMBER
			{
			DebugLocation(110, 16);
			KNEW123=(IToken)Match(input,KNEW,Follow._KNEW_in_newexpression1057); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_KNEW.Add(KNEW123);

			DebugLocation(110, 21);
			TYPE0124=(IToken)Match(input,TYPE0,Follow._TYPE0_in_newexpression1059); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE0.Add(TYPE0124);

			DebugLocation(110, 32);
			SQRBL125=(IToken)Match(input,SQRBL,Follow._SQRBL_in_newexpression1061); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_SQRBL.Add(SQRBL125);

			DebugLocation(110, 34);
			NUMBER126=(IToken)Match(input,NUMBER,Follow._NUMBER_in_newexpression1064); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_NUMBER.Add(NUMBER126);

			DebugLocation(110, 46);
			SQRBR127=(IToken)Match(input,SQRBR,Follow._SQRBR_in_newexpression1066); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_SQRBR.Add(SQRBR127);

			DebugLocation(110, 48);
			NUMBER128=(IToken)Match(input,NUMBER,Follow._NUMBER_in_newexpression1069); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_NUMBER.Add(NUMBER128);



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
			// 110:55: -> ^( NEWWORD TYPE0 NUMBER )
			{
				DebugLocation(110, 58);
				// MathLang.g:110:58: ^( NEWWORD TYPE0 NUMBER )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(110, 60);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(NEWWORD, "NEWWORD"), root_1);

				DebugLocation(110, 68);
				adaptor.AddChild(root_1, stream_TYPE0.NextNode());
				DebugLocation(110, 74);
				adaptor.AddChild(root_1, stream_NUMBER.NextNode());

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
			TraceOut("newexpression", 33);
			LeaveRule("newexpression", 33);
			Leave_newexpression();
			if (state.backtracking > 0) { Memoize(input, 33, newexpression_StartIndex); }
		}
		DebugLocation(110, 80);
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
	// MathLang.g:112:1: block : '{' statementlist '}' ;
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

		IToken char_literal129=null;
		IToken char_literal131=null;
		MathLangParser.statementlist_return statementlist130 = default(MathLangParser.statementlist_return);

		object char_literal129_tree=null;
		object char_literal131_tree=null;

		try { DebugEnterRule(GrammarFileName, "block");
		DebugLocation(112, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 34)) { return retval; }
			// MathLang.g:112:6: ( '{' statementlist '}' )
			DebugEnterAlt(1);
			// MathLang.g:112:8: '{' statementlist '}'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(112, 11);
			char_literal129=(IToken)Match(input,56,Follow._56_in_block1086); if (state.failed) return retval;
			DebugLocation(112, 13);
			PushFollow(Follow._statementlist_in_block1089);
			statementlist130=statementlist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementlist130.Tree);
			DebugLocation(112, 30);
			char_literal131=(IToken)Match(input,57,Follow._57_in_block1091); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(112, 30);
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
	// MathLang.g:114:1: statementlist : ( statement )* -> ^( BLOCK ( statement )* ) ;
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

		MathLangParser.statement_return statement132 = default(MathLangParser.statement_return);

		RewriteRuleSubtreeStream stream_statement=new RewriteRuleSubtreeStream(adaptor,"rule statement");
		try { DebugEnterRule(GrammarFileName, "statementlist");
		DebugLocation(114, 49);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 35)) { return retval; }
			// MathLang.g:114:14: ( ( statement )* -> ^( BLOCK ( statement )* ) )
			DebugEnterAlt(1);
			// MathLang.g:114:16: ( statement )*
			{
			DebugLocation(114, 16);
			// MathLang.g:114:16: ( statement )*
			try { DebugEnterSubRule(26);
			while (true)
			{
				int alt26=2;
				try { DebugEnterDecision(26, decisionCanBacktrack[26]);
				int LA26_0 = input.LA(1);

				if ((LA26_0==IF||LA26_0==FOR||(LA26_0>=RETURN && LA26_0<=WHILE)||LA26_0==ID||LA26_0==TYPE))
				{
					alt26=1;
				}


				} finally { DebugExitDecision(26); }
				switch ( alt26 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: statement
					{
					DebugLocation(114, 16);
					PushFollow(Follow._statement_in_statementlist1099);
					statement132=statement();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_statement.Add(statement132.Tree);

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
			// 114:27: -> ^( BLOCK ( statement )* )
			{
				DebugLocation(114, 30);
				// MathLang.g:114:30: ^( BLOCK ( statement )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(114, 32);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

				DebugLocation(114, 38);
				// MathLang.g:114:38: ( statement )*
				while ( stream_statement.HasNext )
				{
					DebugLocation(114, 38);
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
		DebugLocation(114, 49);
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
			// MathLang.g:63:5: ( funccallbody )
			DebugEnterAlt(1);
			// MathLang.g:63:5: funccallbody
			{
			DebugLocation(63, 5);
			PushFollow(Follow._funccallbody_in_synpred13_MathLang427);
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
			// MathLang.g:64:5: ( boolexpression )
			DebugEnterAlt(1);
			// MathLang.g:64:5: boolexpression
			{
			DebugLocation(64, 5);
			PushFollow(Follow._boolexpression_in_synpred14_MathLang433);
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

	partial void Enter_synpred25_MathLang_fragment();
	partial void Leave_synpred25_MathLang_fragment();

	// $ANTLR start synpred25_MathLang
	public void synpred25_MathLang_fragment()
	{
		Enter_synpred25_MathLang_fragment();
		EnterRule("synpred25_MathLang_fragment", 60);
		TraceIn("synpred25_MathLang_fragment", 60);
		try
		{
			// MathLang.g:80:16: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )
			DebugEnterAlt(1);
			// MathLang.g:80:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
			{
			DebugLocation(80, 16);
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

			DebugLocation(80, 53);
			PushFollow(Follow._add_in_synpred25_MathLang620);
			add();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred25_MathLang_fragment", 60);
			LeaveRule("synpred25_MathLang_fragment", 60);
			Leave_synpred25_MathLang_fragment();
		}
	}
	// $ANTLR end synpred25_MathLang

	partial void Enter_synpred34_MathLang_fragment();
	partial void Leave_synpred34_MathLang_fragment();

	// $ANTLR start synpred34_MathLang
	public void synpred34_MathLang_fragment()
	{
		Enter_synpred34_MathLang_fragment();
		EnterRule("synpred34_MathLang_fragment", 69);
		TraceIn("synpred34_MathLang_fragment", 69);
		try
		{
			// MathLang.g:92:22: ( '(' boolterm ')' )
			DebugEnterAlt(1);
			// MathLang.g:92:22: '(' boolterm ')'
			{
			DebugLocation(92, 22);
			Match(input,53,Follow._53_in_synpred34_MathLang780); if (state.failed) return;
			DebugLocation(92, 27);
			PushFollow(Follow._boolterm_in_synpred34_MathLang783);
			boolterm();
			PopFollow();
			if (state.failed) return;
			DebugLocation(92, 36);
			Match(input,54,Follow._54_in_synpred34_MathLang785); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred34_MathLang_fragment", 69);
			LeaveRule("synpred34_MathLang_fragment", 69);
			Leave_synpred34_MathLang_fragment();
		}
	}
	// $ANTLR end synpred34_MathLang

	partial void Enter_synpred39_MathLang_fragment();
	partial void Leave_synpred39_MathLang_fragment();

	// $ANTLR start synpred39_MathLang
	public void synpred39_MathLang_fragment()
	{
		Enter_synpred39_MathLang_fragment();
		EnterRule("synpred39_MathLang_fragment", 74);
		TraceIn("synpred39_MathLang_fragment", 74);
		try
		{
			// MathLang.g:97:64: ( ELSE ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:97:64: ELSE ( block | statement )
			{
			DebugLocation(97, 64);
			Match(input,ELSE,Follow._ELSE_in_synpred39_MathLang837); if (state.failed) return;
			DebugLocation(97, 70);
			// MathLang.g:97:70: ( block | statement )
			int alt28=2;
			try { DebugEnterSubRule(28);
			try { DebugEnterDecision(28, decisionCanBacktrack[28]);
			int LA28_0 = input.LA(1);

			if ((LA28_0==56))
			{
				alt28=1;
			}
			else if ((LA28_0==IF||LA28_0==FOR||(LA28_0>=RETURN && LA28_0<=WHILE)||LA28_0==ID||LA28_0==TYPE))
			{
				alt28=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				NoViableAltException nvae = new NoViableAltException("", 28, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(28); }
			switch (alt28)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:97:71: block
				{
				DebugLocation(97, 71);
				PushFollow(Follow._block_in_synpred39_MathLang841);
				block();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:97:79: statement
				{
				DebugLocation(97, 79);
				PushFollow(Follow._statement_in_synpred39_MathLang845);
				statement();
				PopFollow();
				if (state.failed) return;

				}
				break;

			}
			} finally { DebugExitSubRule(28); }


			}

		}
		finally
		{
			TraceOut("synpred39_MathLang_fragment", 74);
			LeaveRule("synpred39_MathLang_fragment", 74);
			Leave_synpred39_MathLang_fragment();
		}
	}
	// $ANTLR end synpred39_MathLang
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
			"\x1\x7\x1\x17\x1\x1A\x4\xFFFF\x1\x1A\x4\xFFFF";
		private const string DFA1_maxS =
			"\x1\x19\x1\x17\x1\x35\x4\xFFFF\x1\x35\x4\xFFFF";
		private const string DFA1_acceptS =
			"\x3\xFFFF\x1\x3\x1\x4\x1\x5\x1\x7\x1\xFFFF\x1\x2\x1\x8\x1\x1\x1\x6";
		private const string DFA1_specialS =
			"\xC\xFFFF}>";
		private static readonly string[] DFA1_transitionS =
			{
				"\x1\x3\x1\xFFFF\x1\x5\x1\xFFFF\x1\x6\x1\x4\xA\xFFFF\x1\x2\x1\xFFFF"+
				"\x1\x1",
				"\x1\x7",
				"\x1\x8\x11\xFFFF\x1\x8\x8\xFFFF\x1\x9",
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

		public override string Description { get { return "45:12: ( declaration | assignment | ifstatement | whilestatement | forstatement | funcdeclaration | returnstatement | funccall )"; } }

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
			"\x1\x16\x1\xFFFF\x1\x0\x1\xFFFF\x1\x0\x2\xFFFF\x3\x0\x2\xFFFF";
		private const string DFA3_maxS =
			"\x1\x35\x1\xFFFF\x1\x0\x1\xFFFF\x1\x0\x2\xFFFF\x3\x0\x2\xFFFF";
		private const string DFA3_acceptS =
			"\x1\xFFFF\x1\x1\x1\xFFFF\x1\x3\x6\xFFFF\x1\x2\x1\x4";
		private const string DFA3_specialS =
			"\x2\xFFFF\x1\x0\x1\xFFFF\x1\x1\x2\xFFFF\x1\x2\x1\x3\x1\x4\x2\xFFFF}>";
		private static readonly string[] DFA3_transitionS =
			{
				"\x1\x8\x1\x2\x1\x9\x3\xFFFF\x1\x7\xA\xFFFF\x3\x3\x1\x1\xA\xFFFF\x1"+
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

		public override string Description { get { return "61:1: expression : ( newexpression | funccallbody | boolexpression | mathexpression );"; } }

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
		public static readonly BitSet _statementlist_in_execute317 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_execute319 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declaration_in_statement330 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assignment_in_statement336 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ifstatement_in_statement341 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _whilestatement_in_statement346 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _forstatement_in_statement351 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funcdeclaration_in_statement356 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _returnstatement_in_statement361 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccall_in_statement366 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NUMBER_in_number377 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_number383 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_number389 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CHAR_in_number395 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrayelement_in_number401 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _term_in_mathexpression407 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _newexpression_in_expression421 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_expression427 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolexpression_in_expression433 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathexpression_in_expression439 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_arrayelement451 = new BitSet(new ulong[]{0x100000000000UL});
		public static readonly BitSet _SQRBL_in_arrayelement453 = new BitSet(new ulong[]{0x1C00000UL});
		public static readonly BitSet _number_in_arrayelement455 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _SQRBR_in_arrayelement457 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declarationbody_in_declaration475 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _52_in_declaration477 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _longdeclaration_in_declaration485 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_declarationbody492 = new BitSet(new ulong[]{0x800000UL});
		public static readonly BitSet _ID_in_declarationbody494 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _longdeclarationbody_in_longdeclaration511 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _52_in_longdeclaration513 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_longdeclarationbody521 = new BitSet(new ulong[]{0x800000UL});
		public static readonly BitSet _ID_in_longdeclarationbody523 = new BitSet(new ulong[]{0x4000000UL});
		public static readonly BitSet _ASSIGN_in_longdeclarationbody525 = new BitSet(new ulong[]{0x20078011C00000UL});
		public static readonly BitSet _expression_in_longdeclarationbody527 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mul_in_add547 = new BitSet(new ulong[]{0x18000002UL});
		public static readonly BitSet _set_in_add551 = new BitSet(new ulong[]{0x20038011C00000UL});
		public static readonly BitSet _mul_in_add560 = new BitSet(new ulong[]{0x18000002UL});
		public static readonly BitSet _group_in_mul569 = new BitSet(new ulong[]{0x60000002UL});
		public static readonly BitSet _set_in_mul573 = new BitSet(new ulong[]{0x20038011C00000UL});
		public static readonly BitSet _group_in_mul582 = new BitSet(new ulong[]{0x60000002UL});
		public static readonly BitSet _add_in_compare590 = new BitSet(new ulong[]{0x1F80000002UL});
		public static readonly BitSet _set_in_compare594 = new BitSet(new ulong[]{0x20038011C00000UL});
		public static readonly BitSet _add_in_compare620 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _add_in_term631 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _SUB_in_group638 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _53_in_group643 = new BitSet(new ulong[]{0x20078011C00000UL});
		public static readonly BitSet _term_in_group646 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _54_in_group648 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _number_in_group653 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assignmentbody_in_assignment660 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _52_in_assignment662 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_assignmentbody670 = new BitSet(new ulong[]{0x4000000UL});
		public static readonly BitSet _ASSIGN_in_assignmentbody672 = new BitSet(new ulong[]{0x20078011C00000UL});
		public static readonly BitSet _expression_in_assignmentbody674 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrayelement_in_assignmentbody693 = new BitSet(new ulong[]{0x4000000UL});
		public static readonly BitSet _ASSIGN_in_assignmentbody695 = new BitSet(new ulong[]{0x20078011C00000UL});
		public static readonly BitSet _expression_in_assignmentbody697 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolterm_in_boolexpression715 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _or_in_boolterm722 = new BitSet(new ulong[]{0x600000002UL});
		public static readonly BitSet _set_in_boolterm726 = new BitSet(new ulong[]{0x20038011C00000UL});
		public static readonly BitSet _or_in_boolterm735 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _and_in_or744 = new BitSet(new ulong[]{0x2000000002UL});
		public static readonly BitSet _OR_in_or747 = new BitSet(new ulong[]{0x20038011C00000UL});
		public static readonly BitSet _and_in_or750 = new BitSet(new ulong[]{0x2000000002UL});
		public static readonly BitSet _boolgroup_in_and758 = new BitSet(new ulong[]{0x4000000002UL});
		public static readonly BitSet _AND_in_and761 = new BitSet(new ulong[]{0x20038011C00000UL});
		public static readonly BitSet _boolgroup_in_and764 = new BitSet(new ulong[]{0x4000000002UL});
		public static readonly BitSet _NOT_in_boolgroup773 = new BitSet(new ulong[]{0x20038011C00000UL});
		public static readonly BitSet _53_in_boolgroup780 = new BitSet(new ulong[]{0x20038011C00000UL});
		public static readonly BitSet _boolterm_in_boolgroup783 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _54_in_boolgroup785 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolvar_in_boolgroup790 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TRUE_in_boolvar798 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FALSE_in_boolvar804 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _compare_in_boolvar810 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_ifstatement817 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _53_in_ifstatement820 = new BitSet(new ulong[]{0x20038011C00000UL});
		public static readonly BitSet _boolexpression_in_ifstatement823 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _54_in_ifstatement825 = new BitSet(new ulong[]{0x100000003C01A80UL});
		public static readonly BitSet _block_in_ifstatement829 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement833 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _ELSE_in_ifstatement837 = new BitSet(new ulong[]{0x100000003C01A80UL});
		public static readonly BitSet _block_in_ifstatement841 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement845 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _WHILE_in_whilestatement855 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _53_in_whilestatement858 = new BitSet(new ulong[]{0x20038011C00000UL});
		public static readonly BitSet _boolexpression_in_whilestatement861 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _54_in_whilestatement863 = new BitSet(new ulong[]{0x100000003C01A80UL});
		public static readonly BitSet _block_in_whilestatement867 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_whilestatement871 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_forstatement878 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _53_in_forstatement881 = new BitSet(new ulong[]{0x2000000UL});
		public static readonly BitSet _longdeclarationbody_in_forstatement884 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _52_in_forstatement886 = new BitSet(new ulong[]{0x20038011C00000UL});
		public static readonly BitSet _boolexpression_in_forstatement889 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _52_in_forstatement891 = new BitSet(new ulong[]{0x1C00000UL});
		public static readonly BitSet _assignmentbody_in_forstatement894 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _54_in_forstatement896 = new BitSet(new ulong[]{0x100000003C01A80UL});
		public static readonly BitSet _block_in_forstatement900 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_forstatement904 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _RETURN_in_returnstatement911 = new BitSet(new ulong[]{0x20078011C00000UL});
		public static readonly BitSet _expression_in_returnstatement914 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _52_in_returnstatement916 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_funcdeclaration925 = new BitSet(new ulong[]{0x800000UL});
		public static readonly BitSet _ID_in_funcdeclaration927 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _53_in_funcdeclaration930 = new BitSet(new ulong[]{0x40000002000000UL});
		public static readonly BitSet _paramsdeclaration_in_funcdeclaration933 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _54_in_funcdeclaration936 = new BitSet(new ulong[]{0x100000000000000UL});
		public static readonly BitSet _block_in_funcdeclaration939 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declarationbody_in_paramsdeclaration972 = new BitSet(new ulong[]{0x80000000000002UL});
		public static readonly BitSet _55_in_paramsdeclaration976 = new BitSet(new ulong[]{0x2000000UL});
		public static readonly BitSet _declarationbody_in_paramsdeclaration979 = new BitSet(new ulong[]{0x80000000000002UL});
		public static readonly BitSet _ID_in_funccallbody1004 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _53_in_funccallbody1007 = new BitSet(new ulong[]{0x60078011C00000UL});
		public static readonly BitSet _expressioncommalist_in_funccallbody1009 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _54_in_funccallbody1012 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_funccall1018 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _52_in_funccall1020 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_expressioncommalist1027 = new BitSet(new ulong[]{0x80000000000002UL});
		public static readonly BitSet _55_in_expressioncommalist1031 = new BitSet(new ulong[]{0x20078011C00000UL});
		public static readonly BitSet _expression_in_expressioncommalist1034 = new BitSet(new ulong[]{0x80000000000002UL});
		public static readonly BitSet _KNEW_in_newexpression1057 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _TYPE0_in_newexpression1059 = new BitSet(new ulong[]{0x100000000000UL});
		public static readonly BitSet _SQRBL_in_newexpression1061 = new BitSet(new ulong[]{0x400000UL});
		public static readonly BitSet _NUMBER_in_newexpression1064 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _SQRBR_in_newexpression1066 = new BitSet(new ulong[]{0x400000UL});
		public static readonly BitSet _NUMBER_in_newexpression1069 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _56_in_block1086 = new BitSet(new ulong[]{0x300000003C01A80UL});
		public static readonly BitSet _statementlist_in_block1089 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _57_in_block1091 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_statementlist1099 = new BitSet(new ulong[]{0x100000003C01A82UL});
		public static readonly BitSet _funccallbody_in_synpred13_MathLang427 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolexpression_in_synpred14_MathLang433 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_synpred25_MathLang594 = new BitSet(new ulong[]{0x20038011C00000UL});
		public static readonly BitSet _add_in_synpred25_MathLang620 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _53_in_synpred34_MathLang780 = new BitSet(new ulong[]{0x20038011C00000UL});
		public static readonly BitSet _boolterm_in_synpred34_MathLang783 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _54_in_synpred34_MathLang785 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ELSE_in_synpred39_MathLang837 = new BitSet(new ulong[]{0x100000003C01A80UL});
		public static readonly BitSet _block_in_synpred39_MathLang841 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_synpred39_MathLang845 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  MathLang 

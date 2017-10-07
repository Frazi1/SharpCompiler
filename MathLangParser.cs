// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-10-07 22:00:04

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "UNKNOWN", "PRINT", "INPUT", "IF", "ELSE", "FOR", "FUNCTION", "RETURN", "WHILE", "DO", "BLOCK", "PROGRAM", "PARAMS", "VARDECLARATION", "FUNCDECLARATION", "ARRAYDECLARATION", "VARASSIGNMENT", "ARRAYELEMENTASSIGNMENT", "ARRAYELEMENT", "NEWVAR", "ARRAY_INITIALIZER", "OBJECT_INITIALIZER", "FUNC_CALL", "RETURN_TYPE", "PARAMETERS", "TYPE", "ARRAY_DECLARATION_MARK", "VOID", "NUMBER", "ID", "CHAR", "ASSIGN", "ADD", "SUB", "MUL", "DIV", "GREQ", "LSEQ", "NEQ", "EQ", "GR", "LS", "OR", "AND", "NOT", "TRUE", "FALSE", "KNEW", "CONSOLE_WORD", "SQRBL", "SQRBR", "WS", "SL_COMMENT", "ML_COMMENT", "';'", "'('", "')'", "','", "'{'", "'}'", "'.'", "'WriteLine'", "'Write'", "'ReadLine'", "'Read'", "'()'"
	};
	public const int EOF=-1;
	public const int T__58=58;
	public const int T__59=59;
	public const int T__60=60;
	public const int T__61=61;
	public const int T__62=62;
	public const int T__63=63;
	public const int T__64=64;
	public const int T__65=65;
	public const int T__66=66;
	public const int T__67=67;
	public const int T__68=68;
	public const int T__69=69;
	public const int UNKNOWN=4;
	public const int PRINT=5;
	public const int INPUT=6;
	public const int IF=7;
	public const int ELSE=8;
	public const int FOR=9;
	public const int FUNCTION=10;
	public const int RETURN=11;
	public const int WHILE=12;
	public const int DO=13;
	public const int BLOCK=14;
	public const int PROGRAM=15;
	public const int PARAMS=16;
	public const int VARDECLARATION=17;
	public const int FUNCDECLARATION=18;
	public const int ARRAYDECLARATION=19;
	public const int VARASSIGNMENT=20;
	public const int ARRAYELEMENTASSIGNMENT=21;
	public const int ARRAYELEMENT=22;
	public const int NEWVAR=23;
	public const int ARRAY_INITIALIZER=24;
	public const int OBJECT_INITIALIZER=25;
	public const int FUNC_CALL=26;
	public const int RETURN_TYPE=27;
	public const int PARAMETERS=28;
	public const int TYPE=29;
	public const int ARRAY_DECLARATION_MARK=30;
	public const int VOID=31;
	public const int NUMBER=32;
	public const int ID=33;
	public const int CHAR=34;
	public const int ASSIGN=35;
	public const int ADD=36;
	public const int SUB=37;
	public const int MUL=38;
	public const int DIV=39;
	public const int GREQ=40;
	public const int LSEQ=41;
	public const int NEQ=42;
	public const int EQ=43;
	public const int GR=44;
	public const int LS=45;
	public const int OR=46;
	public const int AND=47;
	public const int NOT=48;
	public const int TRUE=49;
	public const int FALSE=50;
	public const int KNEW=51;
	public const int CONSOLE_WORD=52;
	public const int SQRBL=53;
	public const int SQRBR=54;
	public const int WS=55;
	public const int SL_COMMENT=56;
	public const int ML_COMMENT=57;

	// delegates
	// delegators

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, true, false, false, false, false, false, true, 
				false, false, false, false, false, false, false, true, false, false, 
				false, true, false, false, false, false, false, false, false, false, 
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
		this.state.ruleMemo = new System.Collections.Generic.Dictionary<int, int>[107+1];

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
	// MathLang.g:48:8: public execute : statementlist EOF ;
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
		DebugLocation(48, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 1)) { return retval; }
			// MathLang.g:48:15: ( statementlist EOF )
			DebugEnterAlt(1);
			// MathLang.g:49:2: statementlist EOF
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(49, 2);
			PushFollow(Follow._statementlist_in_execute385);
			statementlist1=statementlist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementlist1.Tree);
			DebugLocation(49, 19);
			EOF2=(IToken)Match(input,EOF,Follow._EOF_in_execute387); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(50, 0);
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
	// MathLang.g:52:1: statement : ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | funcdeclaration | returnstatement | funccall | newexpression | console_write_statement | console_read_statement ) ;
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
		MathLangParser.dowhilestatement_return dowhilestatement7 = default(MathLangParser.dowhilestatement_return);
		MathLangParser.forstatement_return forstatement8 = default(MathLangParser.forstatement_return);
		MathLangParser.funcdeclaration_return funcdeclaration9 = default(MathLangParser.funcdeclaration_return);
		MathLangParser.returnstatement_return returnstatement10 = default(MathLangParser.returnstatement_return);
		MathLangParser.funccall_return funccall11 = default(MathLangParser.funccall_return);
		MathLangParser.newexpression_return newexpression12 = default(MathLangParser.newexpression_return);
		MathLangParser.console_write_statement_return console_write_statement13 = default(MathLangParser.console_write_statement_return);
		MathLangParser.console_read_statement_return console_read_statement14 = default(MathLangParser.console_read_statement_return);


		try { DebugEnterRule(GrammarFileName, "statement");
		DebugLocation(52, 28);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 2)) { return retval; }
			// MathLang.g:52:10: ( ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | funcdeclaration | returnstatement | funccall | newexpression | console_write_statement | console_read_statement ) )
			DebugEnterAlt(1);
			// MathLang.g:52:12: ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | funcdeclaration | returnstatement | funccall | newexpression | console_write_statement | console_read_statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(52, 12);
			// MathLang.g:52:12: ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | funcdeclaration | returnstatement | funccall | newexpression | console_write_statement | console_read_statement )
			int alt1=12;
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
				// MathLang.g:52:14: declaration
				{
				DebugLocation(52, 14);
				PushFollow(Follow._declaration_in_statement398);
				declaration3=declaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, declaration3.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:53:4: assignment
				{
				DebugLocation(53, 4);
				PushFollow(Follow._assignment_in_statement404);
				assignment4=assignment();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment4.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:54:4: ifstatement
				{
				DebugLocation(54, 4);
				PushFollow(Follow._ifstatement_in_statement409);
				ifstatement5=ifstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ifstatement5.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:55:4: whilestatement
				{
				DebugLocation(55, 4);
				PushFollow(Follow._whilestatement_in_statement414);
				whilestatement6=whilestatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, whilestatement6.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:56:4: dowhilestatement
				{
				DebugLocation(56, 4);
				PushFollow(Follow._dowhilestatement_in_statement419);
				dowhilestatement7=dowhilestatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dowhilestatement7.Tree);

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// MathLang.g:57:4: forstatement
				{
				DebugLocation(57, 4);
				PushFollow(Follow._forstatement_in_statement424);
				forstatement8=forstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forstatement8.Tree);

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// MathLang.g:58:4: funcdeclaration
				{
				DebugLocation(58, 4);
				PushFollow(Follow._funcdeclaration_in_statement429);
				funcdeclaration9=funcdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funcdeclaration9.Tree);

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// MathLang.g:59:4: returnstatement
				{
				DebugLocation(59, 4);
				PushFollow(Follow._returnstatement_in_statement434);
				returnstatement10=returnstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, returnstatement10.Tree);

				}
				break;
			case 9:
				DebugEnterAlt(9);
				// MathLang.g:60:4: funccall
				{
				DebugLocation(60, 4);
				PushFollow(Follow._funccall_in_statement439);
				funccall11=funccall();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccall11.Tree);

				}
				break;
			case 10:
				DebugEnterAlt(10);
				// MathLang.g:61:4: newexpression
				{
				DebugLocation(61, 4);
				PushFollow(Follow._newexpression_in_statement444);
				newexpression12=newexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, newexpression12.Tree);

				}
				break;
			case 11:
				DebugEnterAlt(11);
				// MathLang.g:62:4: console_write_statement
				{
				DebugLocation(62, 4);
				PushFollow(Follow._console_write_statement_in_statement449);
				console_write_statement13=console_write_statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, console_write_statement13.Tree);

				}
				break;
			case 12:
				DebugEnterAlt(12);
				// MathLang.g:63:4: console_read_statement
				{
				DebugLocation(63, 4);
				PushFollow(Follow._console_read_statement_in_statement454);
				console_read_statement14=console_read_statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, console_read_statement14.Tree);

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
		DebugLocation(63, 28);
		} finally { DebugExitRule(GrammarFileName, "statement"); }
		return retval;

	}
	// $ANTLR end "statement"

	public class type_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_type();
	partial void Leave_type();

	// $ANTLR start "type"
	// MathLang.g:65:1: type : TYPE ;
	[GrammarRule("type")]
	private MathLangParser.type_return type()
	{
		Enter_type();
		EnterRule("type", 3);
		TraceIn("type", 3);
		MathLangParser.type_return retval = new MathLangParser.type_return();
		retval.Start = (IToken)input.LT(1);
		int type_StartIndex = input.Index;
		object root_0 = null;

		IToken TYPE15=null;

		object TYPE15_tree=null;

		try { DebugEnterRule(GrammarFileName, "type");
		DebugLocation(65, 11);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 3)) { return retval; }
			// MathLang.g:65:5: ( TYPE )
			DebugEnterAlt(1);
			// MathLang.g:65:7: TYPE
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(65, 7);
			TYPE15=(IToken)Match(input,TYPE,Follow._TYPE_in_type464); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			TYPE15_tree = (object)adaptor.Create(TYPE15);
			adaptor.AddChild(root_0, TYPE15_tree);
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
			TraceOut("type", 3);
			LeaveRule("type", 3);
			Leave_type();
			if (state.backtracking > 0) { Memoize(input, 3, type_StartIndex); }
		}
		DebugLocation(65, 11);
		} finally { DebugExitRule(GrammarFileName, "type"); }
		return retval;

	}
	// $ANTLR end "type"

	public class array_type_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_array_type();
	partial void Leave_array_type();

	// $ANTLR start "array_type"
	// MathLang.g:66:1: array_type : TYPE ARRAY_DECLARATION_MARK ;
	[GrammarRule("array_type")]
	private MathLangParser.array_type_return array_type()
	{
		Enter_array_type();
		EnterRule("array_type", 4);
		TraceIn("array_type", 4);
		MathLangParser.array_type_return retval = new MathLangParser.array_type_return();
		retval.Start = (IToken)input.LT(1);
		int array_type_StartIndex = input.Index;
		object root_0 = null;

		IToken TYPE16=null;
		IToken ARRAY_DECLARATION_MARK17=null;

		object TYPE16_tree=null;
		object ARRAY_DECLARATION_MARK17_tree=null;

		try { DebugEnterRule(GrammarFileName, "array_type");
		DebugLocation(66, 40);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 4)) { return retval; }
			// MathLang.g:66:11: ( TYPE ARRAY_DECLARATION_MARK )
			DebugEnterAlt(1);
			// MathLang.g:66:13: TYPE ARRAY_DECLARATION_MARK
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(66, 13);
			TYPE16=(IToken)Match(input,TYPE,Follow._TYPE_in_array_type471); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			TYPE16_tree = (object)adaptor.Create(TYPE16);
			adaptor.AddChild(root_0, TYPE16_tree);
			}
			DebugLocation(66, 40);
			ARRAY_DECLARATION_MARK17=(IToken)Match(input,ARRAY_DECLARATION_MARK,Follow._ARRAY_DECLARATION_MARK_in_array_type473); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("array_type", 4);
			LeaveRule("array_type", 4);
			Leave_array_type();
			if (state.backtracking > 0) { Memoize(input, 4, array_type_StartIndex); }
		}
		DebugLocation(66, 40);
		} finally { DebugExitRule(GrammarFileName, "array_type"); }
		return retval;

	}
	// $ANTLR end "array_type"

	public class any_type_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_any_type();
	partial void Leave_any_type();

	// $ANTLR start "any_type"
	// MathLang.g:67:1: any_type : ( type | array_type | VOID );
	[GrammarRule("any_type")]
	private MathLangParser.any_type_return any_type()
	{
		Enter_any_type();
		EnterRule("any_type", 5);
		TraceIn("any_type", 5);
		MathLangParser.any_type_return retval = new MathLangParser.any_type_return();
		retval.Start = (IToken)input.LT(1);
		int any_type_StartIndex = input.Index;
		object root_0 = null;

		IToken VOID20=null;
		MathLangParser.type_return type18 = default(MathLangParser.type_return);
		MathLangParser.array_type_return array_type19 = default(MathLangParser.array_type_return);

		object VOID20_tree=null;

		try { DebugEnterRule(GrammarFileName, "any_type");
		DebugLocation(67, 34);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 5)) { return retval; }
			// MathLang.g:67:9: ( type | array_type | VOID )
			int alt2=3;
			try { DebugEnterDecision(2, decisionCanBacktrack[2]);
			int LA2_0 = input.LA(1);

			if ((LA2_0==TYPE))
			{
				int LA2_1 = input.LA(2);

				if ((LA2_1==ARRAY_DECLARATION_MARK))
				{
					alt2=2;
				}
				else if ((LA2_1==ID))
				{
					alt2=1;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 2, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else if ((LA2_0==VOID))
			{
				alt2=3;
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
				// MathLang.g:67:11: type
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(67, 11);
				PushFollow(Follow._type_in_any_type480);
				type18=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type18.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:67:18: array_type
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(67, 18);
				PushFollow(Follow._array_type_in_any_type484);
				array_type19=array_type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, array_type19.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:67:31: VOID
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(67, 31);
				VOID20=(IToken)Match(input,VOID,Follow._VOID_in_any_type488); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				VOID20_tree = (object)adaptor.Create(VOID20);
				adaptor.AddChild(root_0, VOID20_tree);
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
			TraceOut("any_type", 5);
			LeaveRule("any_type", 5);
			Leave_any_type();
			if (state.backtracking > 0) { Memoize(input, 5, any_type_StartIndex); }
		}
		DebugLocation(67, 34);
		} finally { DebugExitRule(GrammarFileName, "any_type"); }
		return retval;

	}
	// $ANTLR end "any_type"

	public class number_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_number();
	partial void Leave_number();

	// $ANTLR start "number"
	// MathLang.g:68:1: number : ( NUMBER | ID | funccallbody | CHAR | arrayelement );
	[GrammarRule("number")]
	private MathLangParser.number_return number()
	{
		Enter_number();
		EnterRule("number", 6);
		TraceIn("number", 6);
		MathLangParser.number_return retval = new MathLangParser.number_return();
		retval.Start = (IToken)input.LT(1);
		int number_StartIndex = input.Index;
		object root_0 = null;

		IToken NUMBER21=null;
		IToken ID22=null;
		IToken CHAR24=null;
		MathLangParser.funccallbody_return funccallbody23 = default(MathLangParser.funccallbody_return);
		MathLangParser.arrayelement_return arrayelement25 = default(MathLangParser.arrayelement_return);

		object NUMBER21_tree=null;
		object ID22_tree=null;
		object CHAR24_tree=null;

		try { DebugEnterRule(GrammarFileName, "number");
		DebugLocation(68, 16);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 6)) { return retval; }
			// MathLang.g:68:8: ( NUMBER | ID | funccallbody | CHAR | arrayelement )
			int alt3=5;
			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
			switch (input.LA(1))
			{
			case NUMBER:
				{
				alt3=1;
				}
				break;
			case ID:
				{
				switch (input.LA(2))
				{
				case 59:
					{
					alt3=3;
					}
					break;
				case SQRBL:
					{
					alt3=5;
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
				case 58:
				case 60:
				case 61:
				case 63:
					{
					alt3=2;
					}
					break;
				default:
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 3, 2, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}

				}
				break;
			case CHAR:
				{
				alt3=4;
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
				// MathLang.g:68:11: NUMBER
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(68, 11);
				NUMBER21=(IToken)Match(input,NUMBER,Follow._NUMBER_in_number496); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				NUMBER21_tree = (object)adaptor.Create(NUMBER21);
				adaptor.AddChild(root_0, NUMBER21_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:69:5: ID
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(69, 5);
				ID22=(IToken)Match(input,ID,Follow._ID_in_number502); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				ID22_tree = (object)adaptor.Create(ID22);
				adaptor.AddChild(root_0, ID22_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:70:5: funccallbody
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(70, 5);
				PushFollow(Follow._funccallbody_in_number508);
				funccallbody23=funccallbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody23.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:71:5: CHAR
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(71, 5);
				CHAR24=(IToken)Match(input,CHAR,Follow._CHAR_in_number514); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				CHAR24_tree = (object)adaptor.Create(CHAR24);
				adaptor.AddChild(root_0, CHAR24_tree);
				}

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:72:5: arrayelement
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(72, 5);
				PushFollow(Follow._arrayelement_in_number520);
				arrayelement25=arrayelement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayelement25.Tree);

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
			TraceOut("number", 6);
			LeaveRule("number", 6);
			Leave_number();
			if (state.backtracking > 0) { Memoize(input, 6, number_StartIndex); }
		}
		DebugLocation(72, 16);
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
	// MathLang.g:73:1: mathexpression : term ;
	[GrammarRule("mathexpression")]
	private MathLangParser.mathexpression_return mathexpression()
	{
		Enter_mathexpression();
		EnterRule("mathexpression", 7);
		TraceIn("mathexpression", 7);
		MathLangParser.mathexpression_return retval = new MathLangParser.mathexpression_return();
		retval.Start = (IToken)input.LT(1);
		int mathexpression_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.term_return term26 = default(MathLangParser.term_return);


		try { DebugEnterRule(GrammarFileName, "mathexpression");
		DebugLocation(73, 21);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 7)) { return retval; }
			// MathLang.g:73:15: ( term )
			DebugEnterAlt(1);
			// MathLang.g:73:17: term
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(73, 17);
			PushFollow(Follow._term_in_mathexpression526);
			term26=term();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term26.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("mathexpression", 7);
			LeaveRule("mathexpression", 7);
			Leave_mathexpression();
			if (state.backtracking > 0) { Memoize(input, 7, mathexpression_StartIndex); }
		}
		DebugLocation(73, 21);
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
	// MathLang.g:75:1: expression : ( newexpression | funccallbody | boolexpression | mathexpression | console_read_body );
	[GrammarRule("expression")]
	private MathLangParser.expression_return expression()
	{
		Enter_expression();
		EnterRule("expression", 8);
		TraceIn("expression", 8);
		MathLangParser.expression_return retval = new MathLangParser.expression_return();
		retval.Start = (IToken)input.LT(1);
		int expression_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.newexpression_return newexpression27 = default(MathLangParser.newexpression_return);
		MathLangParser.funccallbody_return funccallbody28 = default(MathLangParser.funccallbody_return);
		MathLangParser.boolexpression_return boolexpression29 = default(MathLangParser.boolexpression_return);
		MathLangParser.mathexpression_return mathexpression30 = default(MathLangParser.mathexpression_return);
		MathLangParser.console_read_body_return console_read_body31 = default(MathLangParser.console_read_body_return);


		try { DebugEnterRule(GrammarFileName, "expression");
		DebugLocation(75, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 8)) { return retval; }
			// MathLang.g:75:11: ( newexpression | funccallbody | boolexpression | mathexpression | console_read_body )
			int alt4=5;
			try { DebugEnterDecision(4, decisionCanBacktrack[4]);
			try
			{
				alt4 = dfa4.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(4); }
			switch (alt4)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:76:5: newexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(76, 5);
				PushFollow(Follow._newexpression_in_expression540);
				newexpression27=newexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, newexpression27.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:77:5: funccallbody
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(77, 5);
				PushFollow(Follow._funccallbody_in_expression546);
				funccallbody28=funccallbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody28.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:78:5: boolexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(78, 5);
				PushFollow(Follow._boolexpression_in_expression552);
				boolexpression29=boolexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression29.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:79:5: mathexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(79, 5);
				PushFollow(Follow._mathexpression_in_expression558);
				mathexpression30=mathexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mathexpression30.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:80:5: console_read_body
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(80, 5);
				PushFollow(Follow._console_read_body_in_expression564);
				console_read_body31=console_read_body();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, console_read_body31.Tree);

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
			TraceOut("expression", 8);
			LeaveRule("expression", 8);
			Leave_expression();
			if (state.backtracking > 0) { Memoize(input, 8, expression_StartIndex); }
		}
		DebugLocation(82, 0);
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
	// MathLang.g:84:1: arrayelement : ID '[' number ']' -> ^( ARRAYELEMENT ID number ) ;
	[GrammarRule("arrayelement")]
	private MathLangParser.arrayelement_return arrayelement()
	{
		Enter_arrayelement();
		EnterRule("arrayelement", 9);
		TraceIn("arrayelement", 9);
		MathLangParser.arrayelement_return retval = new MathLangParser.arrayelement_return();
		retval.Start = (IToken)input.LT(1);
		int arrayelement_StartIndex = input.Index;
		object root_0 = null;

		IToken ID32=null;
		IToken char_literal33=null;
		IToken char_literal35=null;
		MathLangParser.number_return number34 = default(MathLangParser.number_return);

		object ID32_tree=null;
		object char_literal33_tree=null;
		object char_literal35_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_SQRBR=new RewriteRuleITokenStream(adaptor,"token SQRBR");
		RewriteRuleITokenStream stream_SQRBL=new RewriteRuleITokenStream(adaptor,"token SQRBL");
		RewriteRuleSubtreeStream stream_number=new RewriteRuleSubtreeStream(adaptor,"rule number");
		try { DebugEnterRule(GrammarFileName, "arrayelement");
		DebugLocation(84, 62);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 9)) { return retval; }
			// MathLang.g:84:13: ( ID '[' number ']' -> ^( ARRAYELEMENT ID number ) )
			DebugEnterAlt(1);
			// MathLang.g:84:16: ID '[' number ']'
			{
			DebugLocation(84, 16);
			ID32=(IToken)Match(input,ID,Follow._ID_in_arrayelement576); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID32);

			DebugLocation(84, 19);
			char_literal33=(IToken)Match(input,SQRBL,Follow._SQRBL_in_arrayelement578); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_SQRBL.Add(char_literal33);

			DebugLocation(84, 23);
			PushFollow(Follow._number_in_arrayelement580);
			number34=number();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_number.Add(number34.Tree);
			DebugLocation(84, 30);
			char_literal35=(IToken)Match(input,SQRBR,Follow._SQRBR_in_arrayelement582); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_SQRBR.Add(char_literal35);



			{
			// AST REWRITE
			// elements: ID, number
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 84:34: -> ^( ARRAYELEMENT ID number )
			{
				DebugLocation(84, 37);
				// MathLang.g:84:37: ^( ARRAYELEMENT ID number )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(84, 39);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYELEMENT, "ARRAYELEMENT"), root_1);

				DebugLocation(84, 52);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(84, 55);
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
			TraceOut("arrayelement", 9);
			LeaveRule("arrayelement", 9);
			Leave_arrayelement();
			if (state.backtracking > 0) { Memoize(input, 9, arrayelement_StartIndex); }
		}
		DebugLocation(84, 62);
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
	// MathLang.g:86:1: declaration : ( declarationbody ';' | longdeclaration );
	[GrammarRule("declaration")]
	private MathLangParser.declaration_return declaration()
	{
		Enter_declaration();
		EnterRule("declaration", 10);
		TraceIn("declaration", 10);
		MathLangParser.declaration_return retval = new MathLangParser.declaration_return();
		retval.Start = (IToken)input.LT(1);
		int declaration_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal37=null;
		MathLangParser.declarationbody_return declarationbody36 = default(MathLangParser.declarationbody_return);
		MathLangParser.longdeclaration_return longdeclaration38 = default(MathLangParser.longdeclaration_return);

		object char_literal37_tree=null;

		try { DebugEnterRule(GrammarFileName, "declaration");
		DebugLocation(86, 20);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 10)) { return retval; }
			// MathLang.g:86:12: ( declarationbody ';' | longdeclaration )
			int alt5=2;
			try { DebugEnterDecision(5, decisionCanBacktrack[5]);
			int LA5_0 = input.LA(1);

			if ((LA5_0==TYPE))
			{
				int LA5_1 = input.LA(2);

				if ((LA5_1==ARRAY_DECLARATION_MARK))
				{
					int LA5_2 = input.LA(3);

					if ((LA5_2==ID))
					{
						int LA5_4 = input.LA(4);

						if ((LA5_4==ASSIGN))
						{
							alt5=2;
						}
						else if ((LA5_4==58))
						{
							alt5=1;
						}
						else
						{
							if (state.backtracking>0) {state.failed=true; return retval;}
							NoViableAltException nvae = new NoViableAltException("", 5, 4, input);

							DebugRecognitionException(nvae);
							throw nvae;
						}
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 5, 2, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}
				else if ((LA5_1==ID))
				{
					int LA5_3 = input.LA(3);

					if ((LA5_3==ASSIGN))
					{
						alt5=2;
					}
					else if ((LA5_3==58))
					{
						alt5=1;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 5, 3, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 5, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 5, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(5); }
			switch (alt5)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:86:14: declarationbody ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(86, 14);
				PushFollow(Follow._declarationbody_in_declaration600);
				declarationbody36=declarationbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, declarationbody36.Tree);
				DebugLocation(86, 33);
				char_literal37=(IToken)Match(input,58,Follow._58_in_declaration602); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:87:6: longdeclaration
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(87, 6);
				PushFollow(Follow._longdeclaration_in_declaration610);
				longdeclaration38=longdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclaration38.Tree);

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
			TraceOut("declaration", 10);
			LeaveRule("declaration", 10);
			Leave_declaration();
			if (state.backtracking > 0) { Memoize(input, 10, declaration_StartIndex); }
		}
		DebugLocation(87, 20);
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
	// MathLang.g:89:1: declarationbody : ( ( type ID -> ^( VARDECLARATION type ID ) ) | ( array_type ID -> ^( ARRAYDECLARATION array_type ID ) ) );
	[GrammarRule("declarationbody")]
	private MathLangParser.declarationbody_return declarationbody()
	{
		Enter_declarationbody();
		EnterRule("declarationbody", 11);
		TraceIn("declarationbody", 11);
		MathLangParser.declarationbody_return retval = new MathLangParser.declarationbody_return();
		retval.Start = (IToken)input.LT(1);
		int declarationbody_StartIndex = input.Index;
		object root_0 = null;

		IToken ID40=null;
		IToken ID42=null;
		MathLangParser.type_return type39 = default(MathLangParser.type_return);
		MathLangParser.array_type_return array_type41 = default(MathLangParser.array_type_return);

		object ID40_tree=null;
		object ID42_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleSubtreeStream stream_array_type=new RewriteRuleSubtreeStream(adaptor,"rule array_type");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "declarationbody");
		DebugLocation(89, 4);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 11)) { return retval; }
			// MathLang.g:89:16: ( ( type ID -> ^( VARDECLARATION type ID ) ) | ( array_type ID -> ^( ARRAYDECLARATION array_type ID ) ) )
			int alt6=2;
			try { DebugEnterDecision(6, decisionCanBacktrack[6]);
			int LA6_0 = input.LA(1);

			if ((LA6_0==TYPE))
			{
				int LA6_1 = input.LA(2);

				if ((LA6_1==ARRAY_DECLARATION_MARK))
				{
					alt6=2;
				}
				else if ((LA6_1==ID))
				{
					alt6=1;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 6, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
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
				// MathLang.g:89:18: ( type ID -> ^( VARDECLARATION type ID ) )
				{
				DebugLocation(89, 18);
				// MathLang.g:89:18: ( type ID -> ^( VARDECLARATION type ID ) )
				DebugEnterAlt(1);
				// MathLang.g:89:19: type ID
				{
				DebugLocation(89, 19);
				PushFollow(Follow._type_in_declarationbody618);
				type39=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type39.Tree);
				DebugLocation(89, 24);
				ID40=(IToken)Match(input,ID,Follow._ID_in_declarationbody620); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID40);



				{
				// AST REWRITE
				// elements: ID, type
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 89:27: -> ^( VARDECLARATION type ID )
				{
					DebugLocation(89, 30);
					// MathLang.g:89:30: ^( VARDECLARATION type ID )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(89, 32);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDECLARATION, "VARDECLARATION"), root_1);

					DebugLocation(89, 47);
					adaptor.AddChild(root_1, stream_type.NextTree());
					DebugLocation(89, 52);
					adaptor.AddChild(root_1, stream_ID.NextNode());

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
				// MathLang.g:90:7: ( array_type ID -> ^( ARRAYDECLARATION array_type ID ) )
				{
				DebugLocation(90, 7);
				// MathLang.g:90:7: ( array_type ID -> ^( ARRAYDECLARATION array_type ID ) )
				DebugEnterAlt(1);
				// MathLang.g:90:8: array_type ID
				{
				DebugLocation(90, 8);
				PushFollow(Follow._array_type_in_declarationbody641);
				array_type41=array_type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_array_type.Add(array_type41.Tree);
				DebugLocation(90, 19);
				ID42=(IToken)Match(input,ID,Follow._ID_in_declarationbody643); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID42);



				{
				// AST REWRITE
				// elements: array_type, ID
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 90:22: -> ^( ARRAYDECLARATION array_type ID )
				{
					DebugLocation(90, 25);
					// MathLang.g:90:25: ^( ARRAYDECLARATION array_type ID )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(90, 27);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYDECLARATION, "ARRAYDECLARATION"), root_1);

					DebugLocation(90, 44);
					adaptor.AddChild(root_1, stream_array_type.NextTree());
					DebugLocation(90, 55);
					adaptor.AddChild(root_1, stream_ID.NextNode());

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
			TraceOut("declarationbody", 11);
			LeaveRule("declarationbody", 11);
			Leave_declarationbody();
			if (state.backtracking > 0) { Memoize(input, 11, declarationbody_StartIndex); }
		}
		DebugLocation(91, 4);
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
	// MathLang.g:92:1: longdeclaration : longdeclarationbody ';' ;
	[GrammarRule("longdeclaration")]
	private MathLangParser.longdeclaration_return longdeclaration()
	{
		Enter_longdeclaration();
		EnterRule("longdeclaration", 12);
		TraceIn("longdeclaration", 12);
		MathLangParser.longdeclaration_return retval = new MathLangParser.longdeclaration_return();
		retval.Start = (IToken)input.LT(1);
		int longdeclaration_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal44=null;
		MathLangParser.longdeclarationbody_return longdeclarationbody43 = default(MathLangParser.longdeclarationbody_return);

		object char_literal44_tree=null;

		try { DebugEnterRule(GrammarFileName, "longdeclaration");
		DebugLocation(92, 42);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 12)) { return retval; }
			// MathLang.g:92:16: ( longdeclarationbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:92:18: longdeclarationbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(92, 18);
			PushFollow(Follow._longdeclarationbody_in_longdeclaration665);
			longdeclarationbody43=longdeclarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclarationbody43.Tree);
			DebugLocation(92, 41);
			char_literal44=(IToken)Match(input,58,Follow._58_in_longdeclaration667); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("longdeclaration", 12);
			LeaveRule("longdeclaration", 12);
			Leave_longdeclaration();
			if (state.backtracking > 0) { Memoize(input, 12, longdeclaration_StartIndex); }
		}
		DebugLocation(92, 42);
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
	// MathLang.g:93:1: longdeclarationbody : ( ( type ID ASSIGN expression -> ^( VARDECLARATION type ID expression ) ) | ( array_type ID ASSIGN newexpression -> ^( ARRAYDECLARATION array_type ID newexpression ) ) );
	[GrammarRule("longdeclarationbody")]
	private MathLangParser.longdeclarationbody_return longdeclarationbody()
	{
		Enter_longdeclarationbody();
		EnterRule("longdeclarationbody", 13);
		TraceIn("longdeclarationbody", 13);
		MathLangParser.longdeclarationbody_return retval = new MathLangParser.longdeclarationbody_return();
		retval.Start = (IToken)input.LT(1);
		int longdeclarationbody_StartIndex = input.Index;
		object root_0 = null;

		IToken ID46=null;
		IToken ASSIGN47=null;
		IToken ID50=null;
		IToken ASSIGN51=null;
		MathLangParser.type_return type45 = default(MathLangParser.type_return);
		MathLangParser.expression_return expression48 = default(MathLangParser.expression_return);
		MathLangParser.array_type_return array_type49 = default(MathLangParser.array_type_return);
		MathLangParser.newexpression_return newexpression52 = default(MathLangParser.newexpression_return);

		object ID46_tree=null;
		object ASSIGN47_tree=null;
		object ID50_tree=null;
		object ASSIGN51_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_newexpression=new RewriteRuleSubtreeStream(adaptor,"rule newexpression");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_array_type=new RewriteRuleSubtreeStream(adaptor,"rule array_type");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "longdeclarationbody");
		DebugLocation(93, 94);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 13)) { return retval; }
			// MathLang.g:93:20: ( ( type ID ASSIGN expression -> ^( VARDECLARATION type ID expression ) ) | ( array_type ID ASSIGN newexpression -> ^( ARRAYDECLARATION array_type ID newexpression ) ) )
			int alt7=2;
			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
			int LA7_0 = input.LA(1);

			if ((LA7_0==TYPE))
			{
				int LA7_1 = input.LA(2);

				if ((LA7_1==ARRAY_DECLARATION_MARK))
				{
					alt7=2;
				}
				else if ((LA7_1==ID))
				{
					alt7=1;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 7, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
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
				// MathLang.g:93:22: ( type ID ASSIGN expression -> ^( VARDECLARATION type ID expression ) )
				{
				DebugLocation(93, 22);
				// MathLang.g:93:22: ( type ID ASSIGN expression -> ^( VARDECLARATION type ID expression ) )
				DebugEnterAlt(1);
				// MathLang.g:93:23: type ID ASSIGN expression
				{
				DebugLocation(93, 23);
				PushFollow(Follow._type_in_longdeclarationbody676);
				type45=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type45.Tree);
				DebugLocation(93, 28);
				ID46=(IToken)Match(input,ID,Follow._ID_in_longdeclarationbody678); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID46);

				DebugLocation(93, 31);
				ASSIGN47=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclarationbody680); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN47);

				DebugLocation(93, 38);
				PushFollow(Follow._expression_in_longdeclarationbody682);
				expression48=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression48.Tree);


				{
				// AST REWRITE
				// elements: type, expression, ID
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 93:50: -> ^( VARDECLARATION type ID expression )
				{
					DebugLocation(93, 53);
					// MathLang.g:93:53: ^( VARDECLARATION type ID expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(93, 55);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDECLARATION, "VARDECLARATION"), root_1);

					DebugLocation(93, 70);
					adaptor.AddChild(root_1, stream_type.NextTree());
					DebugLocation(93, 75);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(93, 78);
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
				// MathLang.g:94:8: ( array_type ID ASSIGN newexpression -> ^( ARRAYDECLARATION array_type ID newexpression ) )
				{
				DebugLocation(94, 8);
				// MathLang.g:94:8: ( array_type ID ASSIGN newexpression -> ^( ARRAYDECLARATION array_type ID newexpression ) )
				DebugEnterAlt(1);
				// MathLang.g:94:9: array_type ID ASSIGN newexpression
				{
				DebugLocation(94, 9);
				PushFollow(Follow._array_type_in_longdeclarationbody706);
				array_type49=array_type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_array_type.Add(array_type49.Tree);
				DebugLocation(94, 20);
				ID50=(IToken)Match(input,ID,Follow._ID_in_longdeclarationbody708); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID50);

				DebugLocation(94, 23);
				ASSIGN51=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclarationbody710); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN51);

				DebugLocation(94, 30);
				PushFollow(Follow._newexpression_in_longdeclarationbody712);
				newexpression52=newexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_newexpression.Add(newexpression52.Tree);


				{
				// AST REWRITE
				// elements: ID, array_type, newexpression
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 94:44: -> ^( ARRAYDECLARATION array_type ID newexpression )
				{
					DebugLocation(94, 47);
					// MathLang.g:94:47: ^( ARRAYDECLARATION array_type ID newexpression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(94, 49);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYDECLARATION, "ARRAYDECLARATION"), root_1);

					DebugLocation(94, 66);
					adaptor.AddChild(root_1, stream_array_type.NextTree());
					DebugLocation(94, 77);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(94, 80);
					adaptor.AddChild(root_1, stream_newexpression.NextTree());

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
			TraceOut("longdeclarationbody", 13);
			LeaveRule("longdeclarationbody", 13);
			Leave_longdeclarationbody();
			if (state.backtracking > 0) { Memoize(input, 13, longdeclarationbody_StartIndex); }
		}
		DebugLocation(94, 94);
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
	// MathLang.g:96:1: add : mul ( ( ADD | SUB ) mul )* ;
	[GrammarRule("add")]
	private MathLangParser.add_return add()
	{
		Enter_add();
		EnterRule("add", 14);
		TraceIn("add", 14);
		MathLangParser.add_return retval = new MathLangParser.add_return();
		retval.Start = (IToken)input.LT(1);
		int add_StartIndex = input.Index;
		object root_0 = null;

		IToken set54=null;
		MathLangParser.mul_return mul53 = default(MathLangParser.mul_return);
		MathLangParser.mul_return mul55 = default(MathLangParser.mul_return);

		object set54_tree=null;

		try { DebugEnterRule(GrammarFileName, "add");
		DebugLocation(96, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 14)) { return retval; }
			// MathLang.g:96:4: ( mul ( ( ADD | SUB ) mul )* )
			DebugEnterAlt(1);
			// MathLang.g:96:6: mul ( ( ADD | SUB ) mul )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(96, 6);
			PushFollow(Follow._mul_in_add732);
			mul53=mul();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul53.Tree);
			DebugLocation(96, 10);
			// MathLang.g:96:10: ( ( ADD | SUB ) mul )*
			try { DebugEnterSubRule(8);
			while (true)
			{
				int alt8=2;
				try { DebugEnterDecision(8, decisionCanBacktrack[8]);
				int LA8_0 = input.LA(1);

				if (((LA8_0>=ADD && LA8_0<=SUB)))
				{
					alt8=1;
				}


				} finally { DebugExitDecision(8); }
				switch ( alt8 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:96:12: ( ADD | SUB ) mul
					{
					DebugLocation(96, 12);
					set54=(IToken)input.LT(1);
					set54=(IToken)input.LT(1);
					if ((input.LA(1)>=ADD && input.LA(1)<=SUB))
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

					DebugLocation(96, 25);
					PushFollow(Follow._mul_in_add745);
					mul55=mul();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul55.Tree);

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
			TraceOut("add", 14);
			LeaveRule("add", 14);
			Leave_add();
			if (state.backtracking > 0) { Memoize(input, 14, add_StartIndex); }
		}
		DebugLocation(96, 30);
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
	// MathLang.g:97:1: mul : group ( ( MUL | DIV ) group )* ;
	[GrammarRule("mul")]
	private MathLangParser.mul_return mul()
	{
		Enter_mul();
		EnterRule("mul", 15);
		TraceIn("mul", 15);
		MathLangParser.mul_return retval = new MathLangParser.mul_return();
		retval.Start = (IToken)input.LT(1);
		int mul_StartIndex = input.Index;
		object root_0 = null;

		IToken set57=null;
		MathLangParser.group_return group56 = default(MathLangParser.group_return);
		MathLangParser.group_return group58 = default(MathLangParser.group_return);

		object set57_tree=null;

		try { DebugEnterRule(GrammarFileName, "mul");
		DebugLocation(97, 33);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 15)) { return retval; }
			// MathLang.g:97:4: ( group ( ( MUL | DIV ) group )* )
			DebugEnterAlt(1);
			// MathLang.g:97:6: group ( ( MUL | DIV ) group )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(97, 6);
			PushFollow(Follow._group_in_mul754);
			group56=group();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group56.Tree);
			DebugLocation(97, 12);
			// MathLang.g:97:12: ( ( MUL | DIV ) group )*
			try { DebugEnterSubRule(9);
			while (true)
			{
				int alt9=2;
				try { DebugEnterDecision(9, decisionCanBacktrack[9]);
				int LA9_0 = input.LA(1);

				if (((LA9_0>=MUL && LA9_0<=DIV)))
				{
					alt9=1;
				}


				} finally { DebugExitDecision(9); }
				switch ( alt9 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:97:14: ( MUL | DIV ) group
					{
					DebugLocation(97, 14);
					set57=(IToken)input.LT(1);
					set57=(IToken)input.LT(1);
					if ((input.LA(1)>=MUL && input.LA(1)<=DIV))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set57), root_0);
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(97, 27);
					PushFollow(Follow._group_in_mul767);
					group58=group();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group58.Tree);

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
			TraceOut("mul", 15);
			LeaveRule("mul", 15);
			Leave_mul();
			if (state.backtracking > 0) { Memoize(input, 15, mul_StartIndex); }
		}
		DebugLocation(97, 33);
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
	// MathLang.g:98:1: compare : add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )? ;
	[GrammarRule("compare")]
	private MathLangParser.compare_return compare()
	{
		Enter_compare();
		EnterRule("compare", 16);
		TraceIn("compare", 16);
		MathLangParser.compare_return retval = new MathLangParser.compare_return();
		retval.Start = (IToken)input.LT(1);
		int compare_StartIndex = input.Index;
		object root_0 = null;

		IToken set60=null;
		MathLangParser.add_return add59 = default(MathLangParser.add_return);
		MathLangParser.add_return add61 = default(MathLangParser.add_return);

		object set60_tree=null;

		try { DebugEnterRule(GrammarFileName, "compare");
		DebugLocation(98, 60);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 16)) { return retval; }
			// MathLang.g:98:8: ( add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )? )
			DebugEnterAlt(1);
			// MathLang.g:98:10: add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(98, 10);
			PushFollow(Follow._add_in_compare775);
			add59=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add59.Tree);
			DebugLocation(98, 14);
			// MathLang.g:98:14: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
			int alt10=2;
			try { DebugEnterSubRule(10);
			try { DebugEnterDecision(10, decisionCanBacktrack[10]);
			try
			{
				alt10 = dfa10.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(10); }
			switch (alt10)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:98:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
				{
				DebugLocation(98, 16);
				set60=(IToken)input.LT(1);
				set60=(IToken)input.LT(1);
				if ((input.LA(1)>=GREQ && input.LA(1)<=LS))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set60), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(98, 53);
				PushFollow(Follow._add_in_compare805);
				add61=add();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add61.Tree);

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
			TraceOut("compare", 16);
			LeaveRule("compare", 16);
			Leave_compare();
			if (state.backtracking > 0) { Memoize(input, 16, compare_StartIndex); }
		}
		DebugLocation(98, 60);
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
	// MathLang.g:99:1: term : add ;
	[GrammarRule("term")]
	private MathLangParser.term_return term()
	{
		Enter_term();
		EnterRule("term", 17);
		TraceIn("term", 17);
		MathLangParser.term_return retval = new MathLangParser.term_return();
		retval.Start = (IToken)input.LT(1);
		int term_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.add_return add62 = default(MathLangParser.add_return);


		try { DebugEnterRule(GrammarFileName, "term");
		DebugLocation(99, 9);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 17)) { return retval; }
			// MathLang.g:99:5: ( add )
			DebugEnterAlt(1);
			// MathLang.g:99:7: add
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(99, 7);
			PushFollow(Follow._add_in_term816);
			add62=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add62.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("term", 17);
			LeaveRule("term", 17);
			Leave_term();
			if (state.backtracking > 0) { Memoize(input, 17, term_StartIndex); }
		}
		DebugLocation(99, 9);
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
	// MathLang.g:100:1: group : ( ( SUB )? '(' term ')' | number );
	[GrammarRule("group")]
	private MathLangParser.group_return group()
	{
		Enter_group();
		EnterRule("group", 18);
		TraceIn("group", 18);
		MathLangParser.group_return retval = new MathLangParser.group_return();
		retval.Start = (IToken)input.LT(1);
		int group_StartIndex = input.Index;
		object root_0 = null;

		IToken SUB63=null;
		IToken char_literal64=null;
		IToken char_literal66=null;
		MathLangParser.term_return term65 = default(MathLangParser.term_return);
		MathLangParser.number_return number67 = default(MathLangParser.number_return);

		object SUB63_tree=null;
		object char_literal64_tree=null;
		object char_literal66_tree=null;

		try { DebugEnterRule(GrammarFileName, "group");
		DebugLocation(100, 38);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 18)) { return retval; }
			// MathLang.g:100:6: ( ( SUB )? '(' term ')' | number )
			int alt12=2;
			try { DebugEnterDecision(12, decisionCanBacktrack[12]);
			int LA12_0 = input.LA(1);

			if ((LA12_0==SUB||LA12_0==59))
			{
				alt12=1;
			}
			else if (((LA12_0>=NUMBER && LA12_0<=CHAR)))
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
				// MathLang.g:100:8: ( SUB )? '(' term ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(100, 8);
				// MathLang.g:100:8: ( SUB )?
				int alt11=2;
				try { DebugEnterSubRule(11);
				try { DebugEnterDecision(11, decisionCanBacktrack[11]);
				int LA11_0 = input.LA(1);

				if ((LA11_0==SUB))
				{
					alt11=1;
				}
				} finally { DebugExitDecision(11); }
				switch (alt11)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:100:9: SUB
					{
					DebugLocation(100, 12);
					SUB63=(IToken)Match(input,SUB,Follow._SUB_in_group823); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					SUB63_tree = (object)adaptor.Create(SUB63);
					root_0 = (object)adaptor.BecomeRoot(SUB63_tree, root_0);
					}

					}
					break;

				}
				} finally { DebugExitSubRule(11); }

				DebugLocation(100, 19);
				char_literal64=(IToken)Match(input,59,Follow._59_in_group828); if (state.failed) return retval;
				DebugLocation(100, 21);
				PushFollow(Follow._term_in_group831);
				term65=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term65.Tree);
				DebugLocation(100, 29);
				char_literal66=(IToken)Match(input,60,Follow._60_in_group833); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:100:33: number
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(100, 33);
				PushFollow(Follow._number_in_group838);
				number67=number();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, number67.Tree);

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
			TraceOut("group", 18);
			LeaveRule("group", 18);
			Leave_group();
			if (state.backtracking > 0) { Memoize(input, 18, group_StartIndex); }
		}
		DebugLocation(100, 38);
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
	// MathLang.g:102:1: assignment : assignmentbody ';' ;
	[GrammarRule("assignment")]
	private MathLangParser.assignment_return assignment()
	{
		Enter_assignment();
		EnterRule("assignment", 19);
		TraceIn("assignment", 19);
		MathLangParser.assignment_return retval = new MathLangParser.assignment_return();
		retval.Start = (IToken)input.LT(1);
		int assignment_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal69=null;
		MathLangParser.assignmentbody_return assignmentbody68 = default(MathLangParser.assignmentbody_return);

		object char_literal69_tree=null;

		try { DebugEnterRule(GrammarFileName, "assignment");
		DebugLocation(102, 31);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 19)) { return retval; }
			// MathLang.g:102:11: ( assignmentbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:102:13: assignmentbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(102, 13);
			PushFollow(Follow._assignmentbody_in_assignment845);
			assignmentbody68=assignmentbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentbody68.Tree);
			DebugLocation(102, 31);
			char_literal69=(IToken)Match(input,58,Follow._58_in_assignment847); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("assignment", 19);
			LeaveRule("assignment", 19);
			Leave_assignment();
			if (state.backtracking > 0) { Memoize(input, 19, assignment_StartIndex); }
		}
		DebugLocation(102, 31);
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
	// MathLang.g:103:1: assignmentbody : ( ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) ) | ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) ) );
	[GrammarRule("assignmentbody")]
	private MathLangParser.assignmentbody_return assignmentbody()
	{
		Enter_assignmentbody();
		EnterRule("assignmentbody", 20);
		TraceIn("assignmentbody", 20);
		MathLangParser.assignmentbody_return retval = new MathLangParser.assignmentbody_return();
		retval.Start = (IToken)input.LT(1);
		int assignmentbody_StartIndex = input.Index;
		object root_0 = null;

		IToken ID70=null;
		IToken ASSIGN71=null;
		IToken ASSIGN74=null;
		MathLangParser.expression_return expression72 = default(MathLangParser.expression_return);
		MathLangParser.arrayelement_return arrayelement73 = default(MathLangParser.arrayelement_return);
		MathLangParser.expression_return expression75 = default(MathLangParser.expression_return);

		object ID70_tree=null;
		object ASSIGN71_tree=null;
		object ASSIGN74_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_arrayelement=new RewriteRuleSubtreeStream(adaptor,"rule arrayelement");
		try { DebugEnterRule(GrammarFileName, "assignmentbody");
		DebugLocation(103, 87);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 20)) { return retval; }
			// MathLang.g:103:15: ( ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) ) | ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) ) )
			int alt13=2;
			try { DebugEnterDecision(13, decisionCanBacktrack[13]);
			int LA13_0 = input.LA(1);

			if ((LA13_0==ID))
			{
				int LA13_1 = input.LA(2);

				if ((LA13_1==ASSIGN))
				{
					alt13=1;
				}
				else if ((LA13_1==SQRBL))
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
				// MathLang.g:103:17: ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) )
				{
				DebugLocation(103, 17);
				// MathLang.g:103:17: ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) )
				DebugEnterAlt(1);
				// MathLang.g:103:18: ID ASSIGN expression
				{
				DebugLocation(103, 18);
				ID70=(IToken)Match(input,ID,Follow._ID_in_assignmentbody855); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID70);

				DebugLocation(103, 21);
				ASSIGN71=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignmentbody857); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN71);

				DebugLocation(103, 28);
				PushFollow(Follow._expression_in_assignmentbody859);
				expression72=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression72.Tree);


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
				// 103:39: -> ^( VARASSIGNMENT ID expression )
				{
					DebugLocation(103, 42);
					// MathLang.g:103:42: ^( VARASSIGNMENT ID expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(103, 44);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARASSIGNMENT, "VARASSIGNMENT"), root_1);

					DebugLocation(103, 58);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(103, 61);
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
				// MathLang.g:104:2: ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) )
				{
				DebugLocation(104, 2);
				// MathLang.g:104:2: ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) )
				DebugEnterAlt(1);
				// MathLang.g:104:4: arrayelement ASSIGN expression
				{
				DebugLocation(104, 4);
				PushFollow(Follow._arrayelement_in_assignmentbody878);
				arrayelement73=arrayelement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_arrayelement.Add(arrayelement73.Tree);
				DebugLocation(104, 17);
				ASSIGN74=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignmentbody880); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN74);

				DebugLocation(104, 24);
				PushFollow(Follow._expression_in_assignmentbody882);
				expression75=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression75.Tree);


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
				// 104:35: -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression )
				{
					DebugLocation(104, 38);
					// MathLang.g:104:38: ^( ARRAYELEMENTASSIGNMENT arrayelement expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(104, 40);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYELEMENTASSIGNMENT, "ARRAYELEMENTASSIGNMENT"), root_1);

					DebugLocation(104, 63);
					adaptor.AddChild(root_1, stream_arrayelement.NextTree());
					DebugLocation(104, 76);
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
			TraceOut("assignmentbody", 20);
			LeaveRule("assignmentbody", 20);
			Leave_assignmentbody();
			if (state.backtracking > 0) { Memoize(input, 20, assignmentbody_StartIndex); }
		}
		DebugLocation(104, 87);
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
	// MathLang.g:106:1: boolexpression : boolterm ;
	[GrammarRule("boolexpression")]
	private MathLangParser.boolexpression_return boolexpression()
	{
		Enter_boolexpression();
		EnterRule("boolexpression", 21);
		TraceIn("boolexpression", 21);
		MathLangParser.boolexpression_return retval = new MathLangParser.boolexpression_return();
		retval.Start = (IToken)input.LT(1);
		int boolexpression_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.boolterm_return boolterm76 = default(MathLangParser.boolterm_return);


		try { DebugEnterRule(GrammarFileName, "boolexpression");
		DebugLocation(106, 25);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 21)) { return retval; }
			// MathLang.g:106:15: ( boolterm )
			DebugEnterAlt(1);
			// MathLang.g:106:17: boolterm
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(106, 17);
			PushFollow(Follow._boolterm_in_boolexpression900);
			boolterm76=boolterm();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm76.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("boolexpression", 21);
			LeaveRule("boolexpression", 21);
			Leave_boolexpression();
			if (state.backtracking > 0) { Memoize(input, 21, boolexpression_StartIndex); }
		}
		DebugLocation(106, 25);
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
	// MathLang.g:107:1: boolterm : or ( ( EQ | NEQ ) or )? ;
	[GrammarRule("boolterm")]
	private MathLangParser.boolterm_return boolterm()
	{
		Enter_boolterm();
		EnterRule("boolterm", 22);
		TraceIn("boolterm", 22);
		MathLangParser.boolterm_return retval = new MathLangParser.boolterm_return();
		retval.Start = (IToken)input.LT(1);
		int boolterm_StartIndex = input.Index;
		object root_0 = null;

		IToken set78=null;
		MathLangParser.or_return or77 = default(MathLangParser.or_return);
		MathLangParser.or_return or79 = default(MathLangParser.or_return);

		object set78_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolterm");
		DebugLocation(107, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 22)) { return retval; }
			// MathLang.g:107:9: ( or ( ( EQ | NEQ ) or )? )
			DebugEnterAlt(1);
			// MathLang.g:107:11: or ( ( EQ | NEQ ) or )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(107, 11);
			PushFollow(Follow._or_in_boolterm907);
			or77=or();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or77.Tree);
			DebugLocation(107, 14);
			// MathLang.g:107:14: ( ( EQ | NEQ ) or )?
			int alt14=2;
			try { DebugEnterSubRule(14);
			try { DebugEnterDecision(14, decisionCanBacktrack[14]);
			int LA14_0 = input.LA(1);

			if (((LA14_0>=NEQ && LA14_0<=EQ)))
			{
				alt14=1;
			}
			} finally { DebugExitDecision(14); }
			switch (alt14)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:107:16: ( EQ | NEQ ) or
				{
				DebugLocation(107, 16);
				set78=(IToken)input.LT(1);
				set78=(IToken)input.LT(1);
				if ((input.LA(1)>=NEQ && input.LA(1)<=EQ))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set78), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(107, 28);
				PushFollow(Follow._or_in_boolterm920);
				or79=or();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or79.Tree);

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
			TraceOut("boolterm", 22);
			LeaveRule("boolterm", 22);
			Leave_boolterm();
			if (state.backtracking > 0) { Memoize(input, 22, boolterm_StartIndex); }
		}
		DebugLocation(107, 32);
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
	// MathLang.g:108:1: or : and ( OR and )* ;
	[GrammarRule("or")]
	private MathLangParser.or_return or()
	{
		Enter_or();
		EnterRule("or", 23);
		TraceIn("or", 23);
		MathLangParser.or_return retval = new MathLangParser.or_return();
		retval.Start = (IToken)input.LT(1);
		int or_StartIndex = input.Index;
		object root_0 = null;

		IToken OR81=null;
		MathLangParser.and_return and80 = default(MathLangParser.and_return);
		MathLangParser.and_return and82 = default(MathLangParser.and_return);

		object OR81_tree=null;

		try { DebugEnterRule(GrammarFileName, "or");
		DebugLocation(108, 18);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 23)) { return retval; }
			// MathLang.g:108:3: ( and ( OR and )* )
			DebugEnterAlt(1);
			// MathLang.g:108:5: and ( OR and )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(108, 5);
			PushFollow(Follow._and_in_or929);
			and80=and();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and80.Tree);
			DebugLocation(108, 9);
			// MathLang.g:108:9: ( OR and )*
			try { DebugEnterSubRule(15);
			while (true)
			{
				int alt15=2;
				try { DebugEnterDecision(15, decisionCanBacktrack[15]);
				int LA15_0 = input.LA(1);

				if ((LA15_0==OR))
				{
					alt15=1;
				}


				} finally { DebugExitDecision(15); }
				switch ( alt15 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:108:10: OR and
					{
					DebugLocation(108, 12);
					OR81=(IToken)Match(input,OR,Follow._OR_in_or932); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR81_tree = (object)adaptor.Create(OR81);
					root_0 = (object)adaptor.BecomeRoot(OR81_tree, root_0);
					}
					DebugLocation(108, 14);
					PushFollow(Follow._and_in_or935);
					and82=and();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and82.Tree);

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
			TraceOut("or", 23);
			LeaveRule("or", 23);
			Leave_or();
			if (state.backtracking > 0) { Memoize(input, 23, or_StartIndex); }
		}
		DebugLocation(108, 18);
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
	// MathLang.g:109:1: and : boolgroup ( AND boolgroup )* ;
	[GrammarRule("and")]
	private MathLangParser.and_return and()
	{
		Enter_and();
		EnterRule("and", 24);
		TraceIn("and", 24);
		MathLangParser.and_return retval = new MathLangParser.and_return();
		retval.Start = (IToken)input.LT(1);
		int and_StartIndex = input.Index;
		object root_0 = null;

		IToken AND84=null;
		MathLangParser.boolgroup_return boolgroup83 = default(MathLangParser.boolgroup_return);
		MathLangParser.boolgroup_return boolgroup85 = default(MathLangParser.boolgroup_return);

		object AND84_tree=null;

		try { DebugEnterRule(GrammarFileName, "and");
		DebugLocation(109, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 24)) { return retval; }
			// MathLang.g:109:4: ( boolgroup ( AND boolgroup )* )
			DebugEnterAlt(1);
			// MathLang.g:109:6: boolgroup ( AND boolgroup )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(109, 6);
			PushFollow(Follow._boolgroup_in_and943);
			boolgroup83=boolgroup();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup83.Tree);
			DebugLocation(109, 16);
			// MathLang.g:109:16: ( AND boolgroup )*
			try { DebugEnterSubRule(16);
			while (true)
			{
				int alt16=2;
				try { DebugEnterDecision(16, decisionCanBacktrack[16]);
				int LA16_0 = input.LA(1);

				if ((LA16_0==AND))
				{
					alt16=1;
				}


				} finally { DebugExitDecision(16); }
				switch ( alt16 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:109:17: AND boolgroup
					{
					DebugLocation(109, 20);
					AND84=(IToken)Match(input,AND,Follow._AND_in_and946); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND84_tree = (object)adaptor.Create(AND84);
					root_0 = (object)adaptor.BecomeRoot(AND84_tree, root_0);
					}
					DebugLocation(109, 22);
					PushFollow(Follow._boolgroup_in_and949);
					boolgroup85=boolgroup();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup85.Tree);

					}
					break;

				default:
					goto loop16;
				}
			}

			loop16:
				;

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
			TraceOut("and", 24);
			LeaveRule("and", 24);
			Leave_and();
			if (state.backtracking > 0) { Memoize(input, 24, and_StartIndex); }
		}
		DebugLocation(109, 32);
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
	// MathLang.g:110:1: boolgroup : ( NOT )? ( '(' boolterm ')' | boolvar ) ;
	[GrammarRule("boolgroup")]
	private MathLangParser.boolgroup_return boolgroup()
	{
		Enter_boolgroup();
		EnterRule("boolgroup", 25);
		TraceIn("boolgroup", 25);
		MathLangParser.boolgroup_return retval = new MathLangParser.boolgroup_return();
		retval.Start = (IToken)input.LT(1);
		int boolgroup_StartIndex = input.Index;
		object root_0 = null;

		IToken NOT86=null;
		IToken char_literal87=null;
		IToken char_literal89=null;
		MathLangParser.boolterm_return boolterm88 = default(MathLangParser.boolterm_return);
		MathLangParser.boolvar_return boolvar90 = default(MathLangParser.boolvar_return);

		object NOT86_tree=null;
		object char_literal87_tree=null;
		object char_literal89_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolgroup");
		DebugLocation(110, 51);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 25)) { return retval; }
			// MathLang.g:110:10: ( ( NOT )? ( '(' boolterm ')' | boolvar ) )
			DebugEnterAlt(1);
			// MathLang.g:110:12: ( NOT )? ( '(' boolterm ')' | boolvar )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(110, 12);
			// MathLang.g:110:12: ( NOT )?
			int alt17=2;
			try { DebugEnterSubRule(17);
			try { DebugEnterDecision(17, decisionCanBacktrack[17]);
			int LA17_0 = input.LA(1);

			if ((LA17_0==NOT))
			{
				alt17=1;
			}
			} finally { DebugExitDecision(17); }
			switch (alt17)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:110:13: NOT
				{
				DebugLocation(110, 16);
				NOT86=(IToken)Match(input,NOT,Follow._NOT_in_boolgroup958); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				NOT86_tree = (object)adaptor.Create(NOT86);
				root_0 = (object)adaptor.BecomeRoot(NOT86_tree, root_0);
				}

				}
				break;

			}
			} finally { DebugExitSubRule(17); }

			DebugLocation(110, 20);
			// MathLang.g:110:20: ( '(' boolterm ')' | boolvar )
			int alt18=2;
			try { DebugEnterSubRule(18);
			try { DebugEnterDecision(18, decisionCanBacktrack[18]);
			int LA18_0 = input.LA(1);

			if ((LA18_0==59))
			{
				int LA18_1 = input.LA(2);

				if ((EvaluatePredicate(synpred43_MathLang_fragment)))
				{
					alt18=1;
				}
				else if ((true))
				{
					alt18=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 18, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else if (((LA18_0>=NUMBER && LA18_0<=CHAR)||LA18_0==SUB||(LA18_0>=TRUE && LA18_0<=FALSE)))
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
				// MathLang.g:110:22: '(' boolterm ')'
				{
				DebugLocation(110, 25);
				char_literal87=(IToken)Match(input,59,Follow._59_in_boolgroup965); if (state.failed) return retval;
				DebugLocation(110, 27);
				PushFollow(Follow._boolterm_in_boolgroup968);
				boolterm88=boolterm();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm88.Tree);
				DebugLocation(110, 39);
				char_literal89=(IToken)Match(input,60,Follow._60_in_boolgroup970); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:110:43: boolvar
				{
				DebugLocation(110, 43);
				PushFollow(Follow._boolvar_in_boolgroup975);
				boolvar90=boolvar();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolvar90.Tree);

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
			TraceOut("boolgroup", 25);
			LeaveRule("boolgroup", 25);
			Leave_boolgroup();
			if (state.backtracking > 0) { Memoize(input, 25, boolgroup_StartIndex); }
		}
		DebugLocation(110, 51);
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
	// MathLang.g:111:1: boolvar : ( TRUE | FALSE | compare );
	[GrammarRule("boolvar")]
	private MathLangParser.boolvar_return boolvar()
	{
		Enter_boolvar();
		EnterRule("boolvar", 26);
		TraceIn("boolvar", 26);
		MathLangParser.boolvar_return retval = new MathLangParser.boolvar_return();
		retval.Start = (IToken)input.LT(1);
		int boolvar_StartIndex = input.Index;
		object root_0 = null;

		IToken TRUE91=null;
		IToken FALSE92=null;
		MathLangParser.compare_return compare93 = default(MathLangParser.compare_return);

		object TRUE91_tree=null;
		object FALSE92_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolvar");
		DebugLocation(111, 11);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 26)) { return retval; }
			// MathLang.g:111:8: ( TRUE | FALSE | compare )
			int alt19=3;
			try { DebugEnterDecision(19, decisionCanBacktrack[19]);
			switch (input.LA(1))
			{
			case TRUE:
				{
				alt19=1;
				}
				break;
			case FALSE:
				{
				alt19=2;
				}
				break;
			case NUMBER:
			case ID:
			case CHAR:
			case SUB:
			case 59:
				{
				alt19=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 19, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(19); }
			switch (alt19)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:111:10: TRUE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(111, 10);
				TRUE91=(IToken)Match(input,TRUE,Follow._TRUE_in_boolvar983); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				TRUE91_tree = (object)adaptor.Create(TRUE91);
				adaptor.AddChild(root_0, TRUE91_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:112:5: FALSE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(112, 5);
				FALSE92=(IToken)Match(input,FALSE,Follow._FALSE_in_boolvar989); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				FALSE92_tree = (object)adaptor.Create(FALSE92);
				adaptor.AddChild(root_0, FALSE92_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:113:5: compare
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(113, 5);
				PushFollow(Follow._compare_in_boolvar995);
				compare93=compare();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare93.Tree);

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
			TraceOut("boolvar", 26);
			LeaveRule("boolvar", 26);
			Leave_boolvar();
			if (state.backtracking > 0) { Memoize(input, 26, boolvar_StartIndex); }
		}
		DebugLocation(113, 11);
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
	// MathLang.g:115:1: ifstatement : IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )* ;
	[GrammarRule("ifstatement")]
	private MathLangParser.ifstatement_return ifstatement()
	{
		Enter_ifstatement();
		EnterRule("ifstatement", 27);
		TraceIn("ifstatement", 27);
		MathLangParser.ifstatement_return retval = new MathLangParser.ifstatement_return();
		retval.Start = (IToken)input.LT(1);
		int ifstatement_StartIndex = input.Index;
		object root_0 = null;

		IToken IF94=null;
		IToken char_literal95=null;
		IToken char_literal97=null;
		IToken ELSE100=null;
		MathLangParser.boolexpression_return boolexpression96 = default(MathLangParser.boolexpression_return);
		MathLangParser.block_return block98 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement99 = default(MathLangParser.statement_return);
		MathLangParser.block_return block101 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement102 = default(MathLangParser.statement_return);

		object IF94_tree=null;
		object char_literal95_tree=null;
		object char_literal97_tree=null;
		object ELSE100_tree=null;

		try { DebugEnterRule(GrammarFileName, "ifstatement");
		DebugLocation(115, 91);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 27)) { return retval; }
			// MathLang.g:115:12: ( IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )* )
			DebugEnterAlt(1);
			// MathLang.g:115:14: IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(115, 16);
			IF94=(IToken)Match(input,IF,Follow._IF_in_ifstatement1002); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			IF94_tree = (object)adaptor.Create(IF94);
			root_0 = (object)adaptor.BecomeRoot(IF94_tree, root_0);
			}
			DebugLocation(115, 21);
			char_literal95=(IToken)Match(input,59,Follow._59_in_ifstatement1005); if (state.failed) return retval;
			DebugLocation(115, 23);
			PushFollow(Follow._boolexpression_in_ifstatement1008);
			boolexpression96=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression96.Tree);
			DebugLocation(115, 41);
			char_literal97=(IToken)Match(input,60,Follow._60_in_ifstatement1010); if (state.failed) return retval;
			DebugLocation(115, 43);
			// MathLang.g:115:43: ( block | statement )
			int alt20=2;
			try { DebugEnterSubRule(20);
			try { DebugEnterDecision(20, decisionCanBacktrack[20]);
			int LA20_0 = input.LA(1);

			if ((LA20_0==62))
			{
				alt20=1;
			}
			else if ((LA20_0==IF||LA20_0==FOR||(LA20_0>=RETURN && LA20_0<=DO)||LA20_0==TYPE||LA20_0==VOID||LA20_0==ID||(LA20_0>=KNEW && LA20_0<=CONSOLE_WORD)))
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
				// MathLang.g:115:44: block
				{
				DebugLocation(115, 44);
				PushFollow(Follow._block_in_ifstatement1014);
				block98=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block98.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:115:52: statement
				{
				DebugLocation(115, 52);
				PushFollow(Follow._statement_in_ifstatement1018);
				statement99=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement99.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(20); }

			DebugLocation(115, 63);
			// MathLang.g:115:63: ( ELSE ( block | statement ) )*
			try { DebugEnterSubRule(22);
			while (true)
			{
				int alt22=2;
				try { DebugEnterDecision(22, decisionCanBacktrack[22]);
				int LA22_0 = input.LA(1);

				if ((LA22_0==ELSE))
				{
					int LA22_1 = input.LA(2);

					if ((EvaluatePredicate(synpred48_MathLang_fragment)))
					{
						alt22=1;
					}


				}


				} finally { DebugExitDecision(22); }
				switch ( alt22 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:115:64: ELSE ( block | statement )
					{
					DebugLocation(115, 68);
					ELSE100=(IToken)Match(input,ELSE,Follow._ELSE_in_ifstatement1022); if (state.failed) return retval;
					DebugLocation(115, 70);
					// MathLang.g:115:70: ( block | statement )
					int alt21=2;
					try { DebugEnterSubRule(21);
					try { DebugEnterDecision(21, decisionCanBacktrack[21]);
					int LA21_0 = input.LA(1);

					if ((LA21_0==62))
					{
						alt21=1;
					}
					else if ((LA21_0==IF||LA21_0==FOR||(LA21_0>=RETURN && LA21_0<=DO)||LA21_0==TYPE||LA21_0==VOID||LA21_0==ID||(LA21_0>=KNEW && LA21_0<=CONSOLE_WORD)))
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
						// MathLang.g:115:71: block
						{
						DebugLocation(115, 71);
						PushFollow(Follow._block_in_ifstatement1026);
						block101=block();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block101.Tree);

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// MathLang.g:115:79: statement
						{
						DebugLocation(115, 79);
						PushFollow(Follow._statement_in_ifstatement1030);
						statement102=statement();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement102.Tree);

						}
						break;

					}
					} finally { DebugExitSubRule(21); }


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

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("ifstatement", 27);
			LeaveRule("ifstatement", 27);
			Leave_ifstatement();
			if (state.backtracking > 0) { Memoize(input, 27, ifstatement_StartIndex); }
		}
		DebugLocation(115, 91);
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
	// MathLang.g:116:1: whilestatement : WHILE '(' boolexpression ')' ( block | statement ) ;
	[GrammarRule("whilestatement")]
	private MathLangParser.whilestatement_return whilestatement()
	{
		Enter_whilestatement();
		EnterRule("whilestatement", 28);
		TraceIn("whilestatement", 28);
		MathLangParser.whilestatement_return retval = new MathLangParser.whilestatement_return();
		retval.Start = (IToken)input.LT(1);
		int whilestatement_StartIndex = input.Index;
		object root_0 = null;

		IToken WHILE103=null;
		IToken char_literal104=null;
		IToken char_literal106=null;
		MathLangParser.boolexpression_return boolexpression105 = default(MathLangParser.boolexpression_return);
		MathLangParser.block_return block107 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement108 = default(MathLangParser.statement_return);

		object WHILE103_tree=null;
		object char_literal104_tree=null;
		object char_literal106_tree=null;

		try { DebugEnterRule(GrammarFileName, "whilestatement");
		DebugLocation(116, 67);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 28)) { return retval; }
			// MathLang.g:116:15: ( WHILE '(' boolexpression ')' ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:116:17: WHILE '(' boolexpression ')' ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(116, 22);
			WHILE103=(IToken)Match(input,WHILE,Follow._WHILE_in_whilestatement1040); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			WHILE103_tree = (object)adaptor.Create(WHILE103);
			root_0 = (object)adaptor.BecomeRoot(WHILE103_tree, root_0);
			}
			DebugLocation(116, 27);
			char_literal104=(IToken)Match(input,59,Follow._59_in_whilestatement1043); if (state.failed) return retval;
			DebugLocation(116, 29);
			PushFollow(Follow._boolexpression_in_whilestatement1046);
			boolexpression105=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression105.Tree);
			DebugLocation(116, 47);
			char_literal106=(IToken)Match(input,60,Follow._60_in_whilestatement1048); if (state.failed) return retval;
			DebugLocation(116, 49);
			// MathLang.g:116:49: ( block | statement )
			int alt23=2;
			try { DebugEnterSubRule(23);
			try { DebugEnterDecision(23, decisionCanBacktrack[23]);
			int LA23_0 = input.LA(1);

			if ((LA23_0==62))
			{
				alt23=1;
			}
			else if ((LA23_0==IF||LA23_0==FOR||(LA23_0>=RETURN && LA23_0<=DO)||LA23_0==TYPE||LA23_0==VOID||LA23_0==ID||(LA23_0>=KNEW && LA23_0<=CONSOLE_WORD)))
			{
				alt23=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 23, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(23); }
			switch (alt23)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:116:50: block
				{
				DebugLocation(116, 50);
				PushFollow(Follow._block_in_whilestatement1052);
				block107=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block107.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:116:58: statement
				{
				DebugLocation(116, 58);
				PushFollow(Follow._statement_in_whilestatement1056);
				statement108=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement108.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(23); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("whilestatement", 28);
			LeaveRule("whilestatement", 28);
			Leave_whilestatement();
			if (state.backtracking > 0) { Memoize(input, 28, whilestatement_StartIndex); }
		}
		DebugLocation(116, 67);
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
	// MathLang.g:117:1: forstatement : FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement ) ;
	[GrammarRule("forstatement")]
	private MathLangParser.forstatement_return forstatement()
	{
		Enter_forstatement();
		EnterRule("forstatement", 29);
		TraceIn("forstatement", 29);
		MathLangParser.forstatement_return retval = new MathLangParser.forstatement_return();
		retval.Start = (IToken)input.LT(1);
		int forstatement_StartIndex = input.Index;
		object root_0 = null;

		IToken FOR109=null;
		IToken char_literal110=null;
		IToken char_literal112=null;
		IToken char_literal114=null;
		IToken char_literal116=null;
		MathLangParser.longdeclarationbody_return longdeclarationbody111 = default(MathLangParser.longdeclarationbody_return);
		MathLangParser.boolexpression_return boolexpression113 = default(MathLangParser.boolexpression_return);
		MathLangParser.assignmentbody_return assignmentbody115 = default(MathLangParser.assignmentbody_return);
		MathLangParser.block_return block117 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement118 = default(MathLangParser.statement_return);

		object FOR109_tree=null;
		object char_literal110_tree=null;
		object char_literal112_tree=null;
		object char_literal114_tree=null;
		object char_literal116_tree=null;

		try { DebugEnterRule(GrammarFileName, "forstatement");
		DebugLocation(117, 108);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 29)) { return retval; }
			// MathLang.g:117:13: ( FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:117:15: FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(117, 18);
			FOR109=(IToken)Match(input,FOR,Follow._FOR_in_forstatement1063); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			FOR109_tree = (object)adaptor.Create(FOR109);
			root_0 = (object)adaptor.BecomeRoot(FOR109_tree, root_0);
			}
			DebugLocation(117, 23);
			char_literal110=(IToken)Match(input,59,Follow._59_in_forstatement1066); if (state.failed) return retval;
			DebugLocation(117, 25);
			PushFollow(Follow._longdeclarationbody_in_forstatement1069);
			longdeclarationbody111=longdeclarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclarationbody111.Tree);
			DebugLocation(117, 48);
			char_literal112=(IToken)Match(input,58,Follow._58_in_forstatement1071); if (state.failed) return retval;
			DebugLocation(117, 50);
			PushFollow(Follow._boolexpression_in_forstatement1074);
			boolexpression113=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression113.Tree);
			DebugLocation(117, 68);
			char_literal114=(IToken)Match(input,58,Follow._58_in_forstatement1076); if (state.failed) return retval;
			DebugLocation(117, 70);
			PushFollow(Follow._assignmentbody_in_forstatement1079);
			assignmentbody115=assignmentbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentbody115.Tree);
			DebugLocation(117, 88);
			char_literal116=(IToken)Match(input,60,Follow._60_in_forstatement1081); if (state.failed) return retval;
			DebugLocation(117, 90);
			// MathLang.g:117:90: ( block | statement )
			int alt24=2;
			try { DebugEnterSubRule(24);
			try { DebugEnterDecision(24, decisionCanBacktrack[24]);
			int LA24_0 = input.LA(1);

			if ((LA24_0==62))
			{
				alt24=1;
			}
			else if ((LA24_0==IF||LA24_0==FOR||(LA24_0>=RETURN && LA24_0<=DO)||LA24_0==TYPE||LA24_0==VOID||LA24_0==ID||(LA24_0>=KNEW && LA24_0<=CONSOLE_WORD)))
			{
				alt24=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 24, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(24); }
			switch (alt24)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:117:91: block
				{
				DebugLocation(117, 91);
				PushFollow(Follow._block_in_forstatement1085);
				block117=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block117.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:117:99: statement
				{
				DebugLocation(117, 99);
				PushFollow(Follow._statement_in_forstatement1089);
				statement118=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement118.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(24); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("forstatement", 29);
			LeaveRule("forstatement", 29);
			Leave_forstatement();
			if (state.backtracking > 0) { Memoize(input, 29, forstatement_StartIndex); }
		}
		DebugLocation(117, 108);
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
	// MathLang.g:118:1: returnstatement : RETURN expression ';' ;
	[GrammarRule("returnstatement")]
	private MathLangParser.returnstatement_return returnstatement()
	{
		Enter_returnstatement();
		EnterRule("returnstatement", 30);
		TraceIn("returnstatement", 30);
		MathLangParser.returnstatement_return retval = new MathLangParser.returnstatement_return();
		retval.Start = (IToken)input.LT(1);
		int returnstatement_StartIndex = input.Index;
		object root_0 = null;

		IToken RETURN119=null;
		IToken char_literal121=null;
		MathLangParser.expression_return expression120 = default(MathLangParser.expression_return);

		object RETURN119_tree=null;
		object char_literal121_tree=null;

		try { DebugEnterRule(GrammarFileName, "returnstatement");
		DebugLocation(118, 41);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 30)) { return retval; }
			// MathLang.g:118:16: ( RETURN expression ';' )
			DebugEnterAlt(1);
			// MathLang.g:118:18: RETURN expression ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(118, 24);
			RETURN119=(IToken)Match(input,RETURN,Follow._RETURN_in_returnstatement1096); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			RETURN119_tree = (object)adaptor.Create(RETURN119);
			root_0 = (object)adaptor.BecomeRoot(RETURN119_tree, root_0);
			}
			DebugLocation(118, 26);
			PushFollow(Follow._expression_in_returnstatement1099);
			expression120=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression120.Tree);
			DebugLocation(118, 40);
			char_literal121=(IToken)Match(input,58,Follow._58_in_returnstatement1101); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("returnstatement", 30);
			LeaveRule("returnstatement", 30);
			Leave_returnstatement();
			if (state.backtracking > 0) { Memoize(input, 30, returnstatement_StartIndex); }
		}
		DebugLocation(118, 41);
		} finally { DebugExitRule(GrammarFileName, "returnstatement"); }
		return retval;

	}
	// $ANTLR end "returnstatement"

	public class dowhilestatement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_dowhilestatement();
	partial void Leave_dowhilestatement();

	// $ANTLR start "dowhilestatement"
	// MathLang.g:119:1: dowhilestatement : DO ( block | statement ) WHILE '(' boolexpression ')' ';' ;
	[GrammarRule("dowhilestatement")]
	private MathLangParser.dowhilestatement_return dowhilestatement()
	{
		Enter_dowhilestatement();
		EnterRule("dowhilestatement", 31);
		TraceIn("dowhilestatement", 31);
		MathLangParser.dowhilestatement_return retval = new MathLangParser.dowhilestatement_return();
		retval.Start = (IToken)input.LT(1);
		int dowhilestatement_StartIndex = input.Index;
		object root_0 = null;

		IToken DO122=null;
		IToken WHILE125=null;
		IToken char_literal126=null;
		IToken char_literal128=null;
		IToken char_literal129=null;
		MathLangParser.block_return block123 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement124 = default(MathLangParser.statement_return);
		MathLangParser.boolexpression_return boolexpression127 = default(MathLangParser.boolexpression_return);

		object DO122_tree=null;
		object WHILE125_tree=null;
		object char_literal126_tree=null;
		object char_literal128_tree=null;
		object char_literal129_tree=null;

		try { DebugEnterRule(GrammarFileName, "dowhilestatement");
		DebugLocation(119, 79);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 31)) { return retval; }
			// MathLang.g:119:17: ( DO ( block | statement ) WHILE '(' boolexpression ')' ';' )
			DebugEnterAlt(1);
			// MathLang.g:119:19: DO ( block | statement ) WHILE '(' boolexpression ')' ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(119, 21);
			DO122=(IToken)Match(input,DO,Follow._DO_in_dowhilestatement1109); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			DO122_tree = (object)adaptor.Create(DO122);
			root_0 = (object)adaptor.BecomeRoot(DO122_tree, root_0);
			}
			DebugLocation(119, 23);
			// MathLang.g:119:23: ( block | statement )
			int alt25=2;
			try { DebugEnterSubRule(25);
			try { DebugEnterDecision(25, decisionCanBacktrack[25]);
			int LA25_0 = input.LA(1);

			if ((LA25_0==62))
			{
				alt25=1;
			}
			else if ((LA25_0==IF||LA25_0==FOR||(LA25_0>=RETURN && LA25_0<=DO)||LA25_0==TYPE||LA25_0==VOID||LA25_0==ID||(LA25_0>=KNEW && LA25_0<=CONSOLE_WORD)))
			{
				alt25=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 25, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(25); }
			switch (alt25)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:119:24: block
				{
				DebugLocation(119, 24);
				PushFollow(Follow._block_in_dowhilestatement1113);
				block123=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block123.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:119:32: statement
				{
				DebugLocation(119, 32);
				PushFollow(Follow._statement_in_dowhilestatement1117);
				statement124=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement124.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(25); }

			DebugLocation(119, 48);
			WHILE125=(IToken)Match(input,WHILE,Follow._WHILE_in_dowhilestatement1120); if (state.failed) return retval;
			DebugLocation(119, 53);
			char_literal126=(IToken)Match(input,59,Follow._59_in_dowhilestatement1123); if (state.failed) return retval;
			DebugLocation(119, 55);
			PushFollow(Follow._boolexpression_in_dowhilestatement1126);
			boolexpression127=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression127.Tree);
			DebugLocation(119, 73);
			char_literal128=(IToken)Match(input,60,Follow._60_in_dowhilestatement1128); if (state.failed) return retval;
			DebugLocation(119, 78);
			char_literal129=(IToken)Match(input,58,Follow._58_in_dowhilestatement1131); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("dowhilestatement", 31);
			LeaveRule("dowhilestatement", 31);
			Leave_dowhilestatement();
			if (state.backtracking > 0) { Memoize(input, 31, dowhilestatement_StartIndex); }
		}
		DebugLocation(119, 79);
		} finally { DebugExitRule(GrammarFileName, "dowhilestatement"); }
		return retval;

	}
	// $ANTLR end "dowhilestatement"

	public class funcdeclaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_funcdeclaration();
	partial void Leave_funcdeclaration();

	// $ANTLR start "funcdeclaration"
	// MathLang.g:121:1: funcdeclaration : any_type ID '(' ( paramsdeclaration )? ')' block -> ^( FUNCDECLARATION ID ^( RETURN_TYPE any_type ) ( paramsdeclaration )? block ) ;
	[GrammarRule("funcdeclaration")]
	private MathLangParser.funcdeclaration_return funcdeclaration()
	{
		Enter_funcdeclaration();
		EnterRule("funcdeclaration", 32);
		TraceIn("funcdeclaration", 32);
		MathLangParser.funcdeclaration_return retval = new MathLangParser.funcdeclaration_return();
		retval.Start = (IToken)input.LT(1);
		int funcdeclaration_StartIndex = input.Index;
		object root_0 = null;

		IToken ID131=null;
		IToken char_literal132=null;
		IToken char_literal134=null;
		MathLangParser.any_type_return any_type130 = default(MathLangParser.any_type_return);
		MathLangParser.paramsdeclaration_return paramsdeclaration133 = default(MathLangParser.paramsdeclaration_return);
		MathLangParser.block_return block135 = default(MathLangParser.block_return);

		object ID131_tree=null;
		object char_literal132_tree=null;
		object char_literal134_tree=null;
		RewriteRuleITokenStream stream_59=new RewriteRuleITokenStream(adaptor,"token 59");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_60=new RewriteRuleITokenStream(adaptor,"token 60");
		RewriteRuleSubtreeStream stream_paramsdeclaration=new RewriteRuleSubtreeStream(adaptor,"rule paramsdeclaration");
		RewriteRuleSubtreeStream stream_block=new RewriteRuleSubtreeStream(adaptor,"rule block");
		RewriteRuleSubtreeStream stream_any_type=new RewriteRuleSubtreeStream(adaptor,"rule any_type");
		try { DebugEnterRule(GrammarFileName, "funcdeclaration");
		DebugLocation(121, 148);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 32)) { return retval; }
			// MathLang.g:121:16: ( any_type ID '(' ( paramsdeclaration )? ')' block -> ^( FUNCDECLARATION ID ^( RETURN_TYPE any_type ) ( paramsdeclaration )? block ) )
			DebugEnterAlt(1);
			// MathLang.g:121:18: any_type ID '(' ( paramsdeclaration )? ')' block
			{
			DebugLocation(121, 18);
			PushFollow(Follow._any_type_in_funcdeclaration1140);
			any_type130=any_type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_any_type.Add(any_type130.Tree);
			DebugLocation(121, 29);
			ID131=(IToken)Match(input,ID,Follow._ID_in_funcdeclaration1142); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID131);

			DebugLocation(121, 34);
			char_literal132=(IToken)Match(input,59,Follow._59_in_funcdeclaration1145); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_59.Add(char_literal132);

			DebugLocation(121, 36);
			// MathLang.g:121:36: ( paramsdeclaration )?
			int alt26=2;
			try { DebugEnterSubRule(26);
			try { DebugEnterDecision(26, decisionCanBacktrack[26]);
			int LA26_0 = input.LA(1);

			if ((LA26_0==TYPE))
			{
				alt26=1;
			}
			} finally { DebugExitDecision(26); }
			switch (alt26)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: paramsdeclaration
				{
				DebugLocation(121, 36);
				PushFollow(Follow._paramsdeclaration_in_funcdeclaration1148);
				paramsdeclaration133=paramsdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_paramsdeclaration.Add(paramsdeclaration133.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(26); }

			DebugLocation(121, 58);
			char_literal134=(IToken)Match(input,60,Follow._60_in_funcdeclaration1151); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_60.Add(char_literal134);

			DebugLocation(121, 60);
			PushFollow(Follow._block_in_funcdeclaration1154);
			block135=block();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_block.Add(block135.Tree);


			{
			// AST REWRITE
			// elements: any_type, ID, block, paramsdeclaration
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 121:66: -> ^( FUNCDECLARATION ID ^( RETURN_TYPE any_type ) ( paramsdeclaration )? block )
			{
				DebugLocation(121, 69);
				// MathLang.g:121:69: ^( FUNCDECLARATION ID ^( RETURN_TYPE any_type ) ( paramsdeclaration )? block )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(121, 71);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNCDECLARATION, "FUNCDECLARATION"), root_1);

				DebugLocation(121, 87);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(121, 90);
				// MathLang.g:121:90: ^( RETURN_TYPE any_type )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(121, 92);
				root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(RETURN_TYPE, "RETURN_TYPE"), root_2);

				DebugLocation(121, 104);
				adaptor.AddChild(root_2, stream_any_type.NextTree());

				adaptor.AddChild(root_1, root_2);
				}
				DebugLocation(121, 119);
				// MathLang.g:121:119: ( paramsdeclaration )?
				if ( stream_paramsdeclaration.HasNext )
				{
					DebugLocation(121, 119);
					adaptor.AddChild(root_1, stream_paramsdeclaration.NextTree());

				}
				stream_paramsdeclaration.Reset();
				DebugLocation(121, 143);
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
			TraceOut("funcdeclaration", 32);
			LeaveRule("funcdeclaration", 32);
			Leave_funcdeclaration();
			if (state.backtracking > 0) { Memoize(input, 32, funcdeclaration_StartIndex); }
		}
		DebugLocation(121, 148);
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
	// MathLang.g:122:1: paramsdeclaration : ( declarationbody ( ',' declarationbody )* ) -> ^( PARAMETERS ( declarationbody )* ) ;
	[GrammarRule("paramsdeclaration")]
	private MathLangParser.paramsdeclaration_return paramsdeclaration()
	{
		Enter_paramsdeclaration();
		EnterRule("paramsdeclaration", 33);
		TraceIn("paramsdeclaration", 33);
		MathLangParser.paramsdeclaration_return retval = new MathLangParser.paramsdeclaration_return();
		retval.Start = (IToken)input.LT(1);
		int paramsdeclaration_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal137=null;
		MathLangParser.declarationbody_return declarationbody136 = default(MathLangParser.declarationbody_return);
		MathLangParser.declarationbody_return declarationbody138 = default(MathLangParser.declarationbody_return);

		object char_literal137_tree=null;
		RewriteRuleITokenStream stream_61=new RewriteRuleITokenStream(adaptor,"token 61");
		RewriteRuleSubtreeStream stream_declarationbody=new RewriteRuleSubtreeStream(adaptor,"rule declarationbody");
		try { DebugEnterRule(GrammarFileName, "paramsdeclaration");
		DebugLocation(122, 102);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 33)) { return retval; }
			// MathLang.g:122:18: ( ( declarationbody ( ',' declarationbody )* ) -> ^( PARAMETERS ( declarationbody )* ) )
			DebugEnterAlt(1);
			// MathLang.g:122:20: ( declarationbody ( ',' declarationbody )* )
			{
			DebugLocation(122, 20);
			// MathLang.g:122:20: ( declarationbody ( ',' declarationbody )* )
			DebugEnterAlt(1);
			// MathLang.g:122:22: declarationbody ( ',' declarationbody )*
			{
			DebugLocation(122, 22);
			PushFollow(Follow._declarationbody_in_paramsdeclaration1187);
			declarationbody136=declarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declarationbody.Add(declarationbody136.Tree);
			DebugLocation(122, 38);
			// MathLang.g:122:38: ( ',' declarationbody )*
			try { DebugEnterSubRule(27);
			while (true)
			{
				int alt27=2;
				try { DebugEnterDecision(27, decisionCanBacktrack[27]);
				int LA27_0 = input.LA(1);

				if ((LA27_0==61))
				{
					alt27=1;
				}


				} finally { DebugExitDecision(27); }
				switch ( alt27 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:122:40: ',' declarationbody
					{
					DebugLocation(122, 43);
					char_literal137=(IToken)Match(input,61,Follow._61_in_paramsdeclaration1191); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_61.Add(char_literal137);

					DebugLocation(122, 45);
					PushFollow(Follow._declarationbody_in_paramsdeclaration1194);
					declarationbody138=declarationbody();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_declarationbody.Add(declarationbody138.Tree);

					}
					break;

				default:
					goto loop27;
				}
			}

			loop27:
				;

			} finally { DebugExitSubRule(27); }


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
			// 122:66: -> ^( PARAMETERS ( declarationbody )* )
			{
				DebugLocation(122, 69);
				// MathLang.g:122:69: ^( PARAMETERS ( declarationbody )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(122, 71);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_1);

				DebugLocation(122, 82);
				// MathLang.g:122:82: ( declarationbody )*
				while ( stream_declarationbody.HasNext )
				{
					DebugLocation(122, 84);
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
			TraceOut("paramsdeclaration", 33);
			LeaveRule("paramsdeclaration", 33);
			Leave_paramsdeclaration();
			if (state.backtracking > 0) { Memoize(input, 33, paramsdeclaration_StartIndex); }
		}
		DebugLocation(122, 102);
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
	// MathLang.g:124:1: funccallbody : ID '(' ( expressioncommalist )? ')' -> ^( FUNC_CALL ^( ID ( ^( PARAMETERS expressioncommalist ) )? ) ) ;
	[GrammarRule("funccallbody")]
	private MathLangParser.funccallbody_return funccallbody()
	{
		Enter_funccallbody();
		EnterRule("funccallbody", 34);
		TraceIn("funccallbody", 34);
		MathLangParser.funccallbody_return retval = new MathLangParser.funccallbody_return();
		retval.Start = (IToken)input.LT(1);
		int funccallbody_StartIndex = input.Index;
		object root_0 = null;

		IToken ID139=null;
		IToken char_literal140=null;
		IToken char_literal142=null;
		MathLangParser.expressioncommalist_return expressioncommalist141 = default(MathLangParser.expressioncommalist_return);

		object ID139_tree=null;
		object char_literal140_tree=null;
		object char_literal142_tree=null;
		RewriteRuleITokenStream stream_59=new RewriteRuleITokenStream(adaptor,"token 59");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_60=new RewriteRuleITokenStream(adaptor,"token 60");
		RewriteRuleSubtreeStream stream_expressioncommalist=new RewriteRuleSubtreeStream(adaptor,"rule expressioncommalist");
		try { DebugEnterRule(GrammarFileName, "funccallbody");
		DebugLocation(124, 103);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 34)) { return retval; }
			// MathLang.g:124:13: ( ID '(' ( expressioncommalist )? ')' -> ^( FUNC_CALL ^( ID ( ^( PARAMETERS expressioncommalist ) )? ) ) )
			DebugEnterAlt(1);
			// MathLang.g:124:15: ID '(' ( expressioncommalist )? ')'
			{
			DebugLocation(124, 17);
			ID139=(IToken)Match(input,ID,Follow._ID_in_funccallbody1219); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID139);

			DebugLocation(124, 19);
			char_literal140=(IToken)Match(input,59,Follow._59_in_funccallbody1222); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_59.Add(char_literal140);

			DebugLocation(124, 23);
			// MathLang.g:124:23: ( expressioncommalist )?
			int alt28=2;
			try { DebugEnterSubRule(28);
			try { DebugEnterDecision(28, decisionCanBacktrack[28]);
			int LA28_0 = input.LA(1);

			if (((LA28_0>=NUMBER && LA28_0<=CHAR)||LA28_0==SUB||(LA28_0>=NOT && LA28_0<=CONSOLE_WORD)||LA28_0==59))
			{
				alt28=1;
			}
			} finally { DebugExitDecision(28); }
			switch (alt28)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: expressioncommalist
				{
				DebugLocation(124, 23);
				PushFollow(Follow._expressioncommalist_in_funccallbody1224);
				expressioncommalist141=expressioncommalist();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expressioncommalist.Add(expressioncommalist141.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(28); }

			DebugLocation(124, 44);
			char_literal142=(IToken)Match(input,60,Follow._60_in_funccallbody1227); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_60.Add(char_literal142);



			{
			// AST REWRITE
			// elements: ID, expressioncommalist
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 124:48: -> ^( FUNC_CALL ^( ID ( ^( PARAMETERS expressioncommalist ) )? ) )
			{
				DebugLocation(124, 51);
				// MathLang.g:124:51: ^( FUNC_CALL ^( ID ( ^( PARAMETERS expressioncommalist ) )? ) )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(124, 53);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_CALL, "FUNC_CALL"), root_1);

				DebugLocation(124, 63);
				// MathLang.g:124:63: ^( ID ( ^( PARAMETERS expressioncommalist ) )? )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(124, 65);
				root_2 = (object)adaptor.BecomeRoot(stream_ID.NextNode(), root_2);

				DebugLocation(124, 68);
				// MathLang.g:124:68: ( ^( PARAMETERS expressioncommalist ) )?
				if ( stream_expressioncommalist.HasNext )
				{
					DebugLocation(124, 68);
					// MathLang.g:124:68: ^( PARAMETERS expressioncommalist )
					{
					object root_3 = (object)adaptor.Nil();
					DebugLocation(124, 70);
					root_3 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_3);

					DebugLocation(124, 81);
					adaptor.AddChild(root_3, stream_expressioncommalist.NextTree());

					adaptor.AddChild(root_2, root_3);
					}

				}
				stream_expressioncommalist.Reset();

				adaptor.AddChild(root_1, root_2);
				}

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
			TraceOut("funccallbody", 34);
			LeaveRule("funccallbody", 34);
			Leave_funccallbody();
			if (state.backtracking > 0) { Memoize(input, 34, funccallbody_StartIndex); }
		}
		DebugLocation(124, 103);
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
	// MathLang.g:125:1: funccall : funccallbody ';' ;
	[GrammarRule("funccall")]
	private MathLangParser.funccall_return funccall()
	{
		Enter_funccall();
		EnterRule("funccall", 35);
		TraceIn("funccall", 35);
		MathLangParser.funccall_return retval = new MathLangParser.funccall_return();
		retval.Start = (IToken)input.LT(1);
		int funccall_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal144=null;
		MathLangParser.funccallbody_return funccallbody143 = default(MathLangParser.funccallbody_return);

		object char_literal144_tree=null;

		try { DebugEnterRule(GrammarFileName, "funccall");
		DebugLocation(125, 27);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 35)) { return retval; }
			// MathLang.g:125:9: ( funccallbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:125:11: funccallbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(125, 11);
			PushFollow(Follow._funccallbody_in_funccall1250);
			funccallbody143=funccallbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody143.Tree);
			DebugLocation(125, 27);
			char_literal144=(IToken)Match(input,58,Follow._58_in_funccall1252); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("funccall", 35);
			LeaveRule("funccall", 35);
			Leave_funccall();
			if (state.backtracking > 0) { Memoize(input, 35, funccall_StartIndex); }
		}
		DebugLocation(125, 27);
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
	// MathLang.g:126:1: expressioncommalist : expression ( ',' expression )* ;
	[GrammarRule("expressioncommalist")]
	private MathLangParser.expressioncommalist_return expressioncommalist()
	{
		Enter_expressioncommalist();
		EnterRule("expressioncommalist", 36);
		TraceIn("expressioncommalist", 36);
		MathLangParser.expressioncommalist_return retval = new MathLangParser.expressioncommalist_return();
		retval.Start = (IToken)input.LT(1);
		int expressioncommalist_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal146=null;
		MathLangParser.expression_return expression145 = default(MathLangParser.expression_return);
		MathLangParser.expression_return expression147 = default(MathLangParser.expression_return);

		object char_literal146_tree=null;

		try { DebugEnterRule(GrammarFileName, "expressioncommalist");
		DebugLocation(126, 51);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 36)) { return retval; }
			// MathLang.g:126:20: ( expression ( ',' expression )* )
			DebugEnterAlt(1);
			// MathLang.g:126:22: expression ( ',' expression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(126, 22);
			PushFollow(Follow._expression_in_expressioncommalist1259);
			expression145=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression145.Tree);
			DebugLocation(126, 33);
			// MathLang.g:126:33: ( ',' expression )*
			try { DebugEnterSubRule(29);
			while (true)
			{
				int alt29=2;
				try { DebugEnterDecision(29, decisionCanBacktrack[29]);
				int LA29_0 = input.LA(1);

				if ((LA29_0==61))
				{
					alt29=1;
				}


				} finally { DebugExitDecision(29); }
				switch ( alt29 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:126:35: ',' expression
					{
					DebugLocation(126, 38);
					char_literal146=(IToken)Match(input,61,Follow._61_in_expressioncommalist1263); if (state.failed) return retval;
					DebugLocation(126, 40);
					PushFollow(Follow._expression_in_expressioncommalist1266);
					expression147=expression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression147.Tree);

					}
					break;

				default:
					goto loop29;
				}
			}

			loop29:
				;

			} finally { DebugExitSubRule(29); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expressioncommalist", 36);
			LeaveRule("expressioncommalist", 36);
			Leave_expressioncommalist();
			if (state.backtracking > 0) { Memoize(input, 36, expressioncommalist_StartIndex); }
		}
		DebugLocation(126, 51);
		} finally { DebugExitRule(GrammarFileName, "expressioncommalist"); }
		return retval;

	}
	// $ANTLR end "expressioncommalist"

	public class object_initializer_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_object_initializer();
	partial void Leave_object_initializer();

	// $ANTLR start "object_initializer"
	// MathLang.g:129:1: object_initializer : '{' expressioncommalist '}' -> ^( PARAMETERS expressioncommalist ) ;
	[GrammarRule("object_initializer")]
	private MathLangParser.object_initializer_return object_initializer()
	{
		Enter_object_initializer();
		EnterRule("object_initializer", 37);
		TraceIn("object_initializer", 37);
		MathLangParser.object_initializer_return retval = new MathLangParser.object_initializer_return();
		retval.Start = (IToken)input.LT(1);
		int object_initializer_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal148=null;
		IToken char_literal150=null;
		MathLangParser.expressioncommalist_return expressioncommalist149 = default(MathLangParser.expressioncommalist_return);

		object char_literal148_tree=null;
		object char_literal150_tree=null;
		RewriteRuleITokenStream stream_62=new RewriteRuleITokenStream(adaptor,"token 62");
		RewriteRuleITokenStream stream_63=new RewriteRuleITokenStream(adaptor,"token 63");
		RewriteRuleSubtreeStream stream_expressioncommalist=new RewriteRuleSubtreeStream(adaptor,"rule expressioncommalist");
		try { DebugEnterRule(GrammarFileName, "object_initializer");
		DebugLocation(129, 86);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 37)) { return retval; }
			// MathLang.g:129:19: ( '{' expressioncommalist '}' -> ^( PARAMETERS expressioncommalist ) )
			DebugEnterAlt(1);
			// MathLang.g:129:22: '{' expressioncommalist '}'
			{
			DebugLocation(129, 22);
			char_literal148=(IToken)Match(input,62,Follow._62_in_object_initializer1278); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_62.Add(char_literal148);

			DebugLocation(129, 26);
			PushFollow(Follow._expressioncommalist_in_object_initializer1280);
			expressioncommalist149=expressioncommalist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expressioncommalist.Add(expressioncommalist149.Tree);
			DebugLocation(129, 46);
			char_literal150=(IToken)Match(input,63,Follow._63_in_object_initializer1282); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_63.Add(char_literal150);



			{
			// AST REWRITE
			// elements: expressioncommalist
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 129:50: -> ^( PARAMETERS expressioncommalist )
			{
				DebugLocation(129, 53);
				// MathLang.g:129:53: ^( PARAMETERS expressioncommalist )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(129, 55);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_1);

				DebugLocation(129, 66);
				adaptor.AddChild(root_1, stream_expressioncommalist.NextTree());

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
			TraceOut("object_initializer", 37);
			LeaveRule("object_initializer", 37);
			Leave_object_initializer();
			if (state.backtracking > 0) { Memoize(input, 37, object_initializer_StartIndex); }
		}
		DebugLocation(129, 86);
		} finally { DebugExitRule(GrammarFileName, "object_initializer"); }
		return retval;

	}
	// $ANTLR end "object_initializer"

	public class newexpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_newexpression();
	partial void Leave_newexpression();

	// $ANTLR start "newexpression"
	// MathLang.g:130:1: newexpression : KNEW initializer ;
	[GrammarRule("newexpression")]
	private MathLangParser.newexpression_return newexpression()
	{
		Enter_newexpression();
		EnterRule("newexpression", 38);
		TraceIn("newexpression", 38);
		MathLangParser.newexpression_return retval = new MathLangParser.newexpression_return();
		retval.Start = (IToken)input.LT(1);
		int newexpression_StartIndex = input.Index;
		object root_0 = null;

		IToken KNEW151=null;
		MathLangParser.initializer_return initializer152 = default(MathLangParser.initializer_return);

		object KNEW151_tree=null;

		try { DebugEnterRule(GrammarFileName, "newexpression");
		DebugLocation(130, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 38)) { return retval; }
			// MathLang.g:130:14: ( KNEW initializer )
			DebugEnterAlt(1);
			// MathLang.g:130:16: KNEW initializer
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(130, 20);
			KNEW151=(IToken)Match(input,KNEW,Follow._KNEW_in_newexpression1297); if (state.failed) return retval;
			DebugLocation(130, 22);
			PushFollow(Follow._initializer_in_newexpression1300);
			initializer152=initializer();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, initializer152.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("newexpression", 38);
			LeaveRule("newexpression", 38);
			Leave_newexpression();
			if (state.backtracking > 0) { Memoize(input, 38, newexpression_StartIndex); }
		}
		DebugLocation(130, 32);
		} finally { DebugExitRule(GrammarFileName, "newexpression"); }
		return retval;

	}
	// $ANTLR end "newexpression"

	public class initializer_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_initializer();
	partial void Leave_initializer();

	// $ANTLR start "initializer"
	// MathLang.g:131:1: initializer : ( simple_var_initializer | array_initializer ) ;
	[GrammarRule("initializer")]
	private MathLangParser.initializer_return initializer()
	{
		Enter_initializer();
		EnterRule("initializer", 39);
		TraceIn("initializer", 39);
		MathLangParser.initializer_return retval = new MathLangParser.initializer_return();
		retval.Start = (IToken)input.LT(1);
		int initializer_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.simple_var_initializer_return simple_var_initializer153 = default(MathLangParser.simple_var_initializer_return);
		MathLangParser.array_initializer_return array_initializer154 = default(MathLangParser.array_initializer_return);


		try { DebugEnterRule(GrammarFileName, "initializer");
		DebugLocation(131, 57);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 39)) { return retval; }
			// MathLang.g:131:12: ( ( simple_var_initializer | array_initializer ) )
			DebugEnterAlt(1);
			// MathLang.g:131:14: ( simple_var_initializer | array_initializer )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(131, 14);
			// MathLang.g:131:14: ( simple_var_initializer | array_initializer )
			int alt30=2;
			try { DebugEnterSubRule(30);
			try { DebugEnterDecision(30, decisionCanBacktrack[30]);
			int LA30_0 = input.LA(1);

			if ((LA30_0==TYPE))
			{
				int LA30_1 = input.LA(2);

				if ((LA30_1==59))
				{
					alt30=1;
				}
				else if ((LA30_1==ARRAY_DECLARATION_MARK||LA30_1==SQRBL))
				{
					alt30=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 30, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 30, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(30); }
			switch (alt30)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:131:15: simple_var_initializer
				{
				DebugLocation(131, 15);
				PushFollow(Follow._simple_var_initializer_in_initializer1307);
				simple_var_initializer153=simple_var_initializer();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, simple_var_initializer153.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:131:40: array_initializer
				{
				DebugLocation(131, 40);
				PushFollow(Follow._array_initializer_in_initializer1311);
				array_initializer154=array_initializer();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, array_initializer154.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(30); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("initializer", 39);
			LeaveRule("initializer", 39);
			Leave_initializer();
			if (state.backtracking > 0) { Memoize(input, 39, initializer_StartIndex); }
		}
		DebugLocation(131, 57);
		} finally { DebugExitRule(GrammarFileName, "initializer"); }
		return retval;

	}
	// $ANTLR end "initializer"

	public class simple_var_initializer_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_simple_var_initializer();
	partial void Leave_simple_var_initializer();

	// $ANTLR start "simple_var_initializer"
	// MathLang.g:132:1: simple_var_initializer : type '(' ')' -> ^( NEWVAR type ) ;
	[GrammarRule("simple_var_initializer")]
	private MathLangParser.simple_var_initializer_return simple_var_initializer()
	{
		Enter_simple_var_initializer();
		EnterRule("simple_var_initializer", 40);
		TraceIn("simple_var_initializer", 40);
		MathLangParser.simple_var_initializer_return retval = new MathLangParser.simple_var_initializer_return();
		retval.Start = (IToken)input.LT(1);
		int simple_var_initializer_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal156=null;
		IToken char_literal157=null;
		MathLangParser.type_return type155 = default(MathLangParser.type_return);

		object char_literal156_tree=null;
		object char_literal157_tree=null;
		RewriteRuleITokenStream stream_59=new RewriteRuleITokenStream(adaptor,"token 59");
		RewriteRuleITokenStream stream_60=new RewriteRuleITokenStream(adaptor,"token 60");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "simple_var_initializer");
		DebugLocation(132, 54);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 40)) { return retval; }
			// MathLang.g:132:23: ( type '(' ')' -> ^( NEWVAR type ) )
			DebugEnterAlt(1);
			// MathLang.g:132:25: type '(' ')'
			{
			DebugLocation(132, 25);
			PushFollow(Follow._type_in_simple_var_initializer1318);
			type155=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type155.Tree);
			DebugLocation(132, 30);
			char_literal156=(IToken)Match(input,59,Follow._59_in_simple_var_initializer1320); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_59.Add(char_literal156);

			DebugLocation(132, 34);
			char_literal157=(IToken)Match(input,60,Follow._60_in_simple_var_initializer1322); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_60.Add(char_literal157);



			{
			// AST REWRITE
			// elements: type
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 132:38: -> ^( NEWVAR type )
			{
				DebugLocation(132, 41);
				// MathLang.g:132:41: ^( NEWVAR type )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(132, 43);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(NEWVAR, "NEWVAR"), root_1);

				DebugLocation(132, 50);
				adaptor.AddChild(root_1, stream_type.NextTree());

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
			TraceOut("simple_var_initializer", 40);
			LeaveRule("simple_var_initializer", 40);
			Leave_simple_var_initializer();
			if (state.backtracking > 0) { Memoize(input, 40, simple_var_initializer_StartIndex); }
		}
		DebugLocation(132, 54);
		} finally { DebugExitRule(GrammarFileName, "simple_var_initializer"); }
		return retval;

	}
	// $ANTLR end "simple_var_initializer"

	public class array_initializer_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_array_initializer();
	partial void Leave_array_initializer();

	// $ANTLR start "array_initializer"
	// MathLang.g:133:1: array_initializer : type ( ( '[' number ']' ) | ARRAY_DECLARATION_MARK ) ( object_initializer )? -> ^( ARRAY_INITIALIZER type ( number )? ( object_initializer )? ) ;
	[GrammarRule("array_initializer")]
	private MathLangParser.array_initializer_return array_initializer()
	{
		Enter_array_initializer();
		EnterRule("array_initializer", 41);
		TraceIn("array_initializer", 41);
		MathLangParser.array_initializer_return retval = new MathLangParser.array_initializer_return();
		retval.Start = (IToken)input.LT(1);
		int array_initializer_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal159=null;
		IToken char_literal161=null;
		IToken ARRAY_DECLARATION_MARK162=null;
		MathLangParser.type_return type158 = default(MathLangParser.type_return);
		MathLangParser.number_return number160 = default(MathLangParser.number_return);
		MathLangParser.object_initializer_return object_initializer163 = default(MathLangParser.object_initializer_return);

		object char_literal159_tree=null;
		object char_literal161_tree=null;
		object ARRAY_DECLARATION_MARK162_tree=null;
		RewriteRuleITokenStream stream_ARRAY_DECLARATION_MARK=new RewriteRuleITokenStream(adaptor,"token ARRAY_DECLARATION_MARK");
		RewriteRuleITokenStream stream_SQRBR=new RewriteRuleITokenStream(adaptor,"token SQRBR");
		RewriteRuleITokenStream stream_SQRBL=new RewriteRuleITokenStream(adaptor,"token SQRBL");
		RewriteRuleSubtreeStream stream_number=new RewriteRuleSubtreeStream(adaptor,"rule number");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		RewriteRuleSubtreeStream stream_object_initializer=new RewriteRuleSubtreeStream(adaptor,"rule object_initializer");
		try { DebugEnterRule(GrammarFileName, "array_initializer");
		DebugLocation(133, 144);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 41)) { return retval; }
			// MathLang.g:133:18: ( type ( ( '[' number ']' ) | ARRAY_DECLARATION_MARK ) ( object_initializer )? -> ^( ARRAY_INITIALIZER type ( number )? ( object_initializer )? ) )
			DebugEnterAlt(1);
			// MathLang.g:133:20: type ( ( '[' number ']' ) | ARRAY_DECLARATION_MARK ) ( object_initializer )?
			{
			DebugLocation(133, 20);
			PushFollow(Follow._type_in_array_initializer1336);
			type158=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type158.Tree);
			DebugLocation(133, 25);
			// MathLang.g:133:25: ( ( '[' number ']' ) | ARRAY_DECLARATION_MARK )
			int alt31=2;
			try { DebugEnterSubRule(31);
			try { DebugEnterDecision(31, decisionCanBacktrack[31]);
			int LA31_0 = input.LA(1);

			if ((LA31_0==SQRBL))
			{
				alt31=1;
			}
			else if ((LA31_0==ARRAY_DECLARATION_MARK))
			{
				alt31=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 31, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(31); }
			switch (alt31)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:133:26: ( '[' number ']' )
				{
				DebugLocation(133, 26);
				// MathLang.g:133:26: ( '[' number ']' )
				DebugEnterAlt(1);
				// MathLang.g:133:27: '[' number ']'
				{
				DebugLocation(133, 27);
				char_literal159=(IToken)Match(input,SQRBL,Follow._SQRBL_in_array_initializer1340); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_SQRBL.Add(char_literal159);

				DebugLocation(133, 31);
				PushFollow(Follow._number_in_array_initializer1342);
				number160=number();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_number.Add(number160.Tree);
				DebugLocation(133, 38);
				char_literal161=(IToken)Match(input,SQRBR,Follow._SQRBR_in_array_initializer1344); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_SQRBR.Add(char_literal161);


				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:133:45: ARRAY_DECLARATION_MARK
				{
				DebugLocation(133, 45);
				ARRAY_DECLARATION_MARK162=(IToken)Match(input,ARRAY_DECLARATION_MARK,Follow._ARRAY_DECLARATION_MARK_in_array_initializer1349); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ARRAY_DECLARATION_MARK.Add(ARRAY_DECLARATION_MARK162);


				}
				break;

			}
			} finally { DebugExitSubRule(31); }

			DebugLocation(133, 69);
			// MathLang.g:133:69: ( object_initializer )?
			int alt32=2;
			try { DebugEnterSubRule(32);
			try { DebugEnterDecision(32, decisionCanBacktrack[32]);
			int LA32_0 = input.LA(1);

			if ((LA32_0==62))
			{
				alt32=1;
			}
			} finally { DebugExitDecision(32); }
			switch (alt32)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: object_initializer
				{
				DebugLocation(133, 69);
				PushFollow(Follow._object_initializer_in_array_initializer1352);
				object_initializer163=object_initializer();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_object_initializer.Add(object_initializer163.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(32); }



			{
			// AST REWRITE
			// elements: number, object_initializer, type
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 133:89: -> ^( ARRAY_INITIALIZER type ( number )? ( object_initializer )? )
			{
				DebugLocation(133, 92);
				// MathLang.g:133:92: ^( ARRAY_INITIALIZER type ( number )? ( object_initializer )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(133, 94);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAY_INITIALIZER, "ARRAY_INITIALIZER"), root_1);

				DebugLocation(133, 112);
				adaptor.AddChild(root_1, stream_type.NextTree());
				DebugLocation(133, 117);
				// MathLang.g:133:117: ( number )?
				if ( stream_number.HasNext )
				{
					DebugLocation(133, 117);
					adaptor.AddChild(root_1, stream_number.NextTree());

				}
				stream_number.Reset();
				DebugLocation(133, 125);
				// MathLang.g:133:125: ( object_initializer )?
				if ( stream_object_initializer.HasNext )
				{
					DebugLocation(133, 125);
					adaptor.AddChild(root_1, stream_object_initializer.NextTree());

				}
				stream_object_initializer.Reset();

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
			TraceOut("array_initializer", 41);
			LeaveRule("array_initializer", 41);
			Leave_array_initializer();
			if (state.backtracking > 0) { Memoize(input, 41, array_initializer_StartIndex); }
		}
		DebugLocation(133, 144);
		} finally { DebugExitRule(GrammarFileName, "array_initializer"); }
		return retval;

	}
	// $ANTLR end "array_initializer"

	public class block_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_block();
	partial void Leave_block();

	// $ANTLR start "block"
	// MathLang.g:135:1: block : '{' statementlist '}' ;
	[GrammarRule("block")]
	private MathLangParser.block_return block()
	{
		Enter_block();
		EnterRule("block", 42);
		TraceIn("block", 42);
		MathLangParser.block_return retval = new MathLangParser.block_return();
		retval.Start = (IToken)input.LT(1);
		int block_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal164=null;
		IToken char_literal166=null;
		MathLangParser.statementlist_return statementlist165 = default(MathLangParser.statementlist_return);

		object char_literal164_tree=null;
		object char_literal166_tree=null;

		try { DebugEnterRule(GrammarFileName, "block");
		DebugLocation(135, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 42)) { return retval; }
			// MathLang.g:135:6: ( '{' statementlist '}' )
			DebugEnterAlt(1);
			// MathLang.g:135:8: '{' statementlist '}'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(135, 11);
			char_literal164=(IToken)Match(input,62,Follow._62_in_block1374); if (state.failed) return retval;
			DebugLocation(135, 13);
			PushFollow(Follow._statementlist_in_block1377);
			statementlist165=statementlist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementlist165.Tree);
			DebugLocation(135, 30);
			char_literal166=(IToken)Match(input,63,Follow._63_in_block1379); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("block", 42);
			LeaveRule("block", 42);
			Leave_block();
			if (state.backtracking > 0) { Memoize(input, 42, block_StartIndex); }
		}
		DebugLocation(135, 30);
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
	// MathLang.g:137:1: statementlist : ( statement )* -> ^( BLOCK ( statement )* ) ;
	[GrammarRule("statementlist")]
	private MathLangParser.statementlist_return statementlist()
	{
		Enter_statementlist();
		EnterRule("statementlist", 43);
		TraceIn("statementlist", 43);
		MathLangParser.statementlist_return retval = new MathLangParser.statementlist_return();
		retval.Start = (IToken)input.LT(1);
		int statementlist_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.statement_return statement167 = default(MathLangParser.statement_return);

		RewriteRuleSubtreeStream stream_statement=new RewriteRuleSubtreeStream(adaptor,"rule statement");
		try { DebugEnterRule(GrammarFileName, "statementlist");
		DebugLocation(137, 49);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 43)) { return retval; }
			// MathLang.g:137:14: ( ( statement )* -> ^( BLOCK ( statement )* ) )
			DebugEnterAlt(1);
			// MathLang.g:137:16: ( statement )*
			{
			DebugLocation(137, 16);
			// MathLang.g:137:16: ( statement )*
			try { DebugEnterSubRule(33);
			while (true)
			{
				int alt33=2;
				try { DebugEnterDecision(33, decisionCanBacktrack[33]);
				int LA33_0 = input.LA(1);

				if ((LA33_0==IF||LA33_0==FOR||(LA33_0>=RETURN && LA33_0<=DO)||LA33_0==TYPE||LA33_0==VOID||LA33_0==ID||(LA33_0>=KNEW && LA33_0<=CONSOLE_WORD)))
				{
					alt33=1;
				}


				} finally { DebugExitDecision(33); }
				switch ( alt33 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: statement
					{
					DebugLocation(137, 16);
					PushFollow(Follow._statement_in_statementlist1387);
					statement167=statement();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_statement.Add(statement167.Tree);

					}
					break;

				default:
					goto loop33;
				}
			}

			loop33:
				;

			} finally { DebugExitSubRule(33); }



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
			// 137:27: -> ^( BLOCK ( statement )* )
			{
				DebugLocation(137, 30);
				// MathLang.g:137:30: ^( BLOCK ( statement )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(137, 32);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

				DebugLocation(137, 38);
				// MathLang.g:137:38: ( statement )*
				while ( stream_statement.HasNext )
				{
					DebugLocation(137, 38);
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
			TraceOut("statementlist", 43);
			LeaveRule("statementlist", 43);
			Leave_statementlist();
			if (state.backtracking > 0) { Memoize(input, 43, statementlist_StartIndex); }
		}
		DebugLocation(137, 49);
		} finally { DebugExitRule(GrammarFileName, "statementlist"); }
		return retval;

	}
	// $ANTLR end "statementlist"

	public class console_write_statement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_console_write_statement();
	partial void Leave_console_write_statement();

	// $ANTLR start "console_write_statement"
	// MathLang.g:139:1: console_write_statement : CONSOLE_WORD '.' ( 'WriteLine' | 'Write' ) '(' expression ')' ';' -> ^( PRINT expression ) ;
	[GrammarRule("console_write_statement")]
	private MathLangParser.console_write_statement_return console_write_statement()
	{
		Enter_console_write_statement();
		EnterRule("console_write_statement", 44);
		TraceIn("console_write_statement", 44);
		MathLangParser.console_write_statement_return retval = new MathLangParser.console_write_statement_return();
		retval.Start = (IToken)input.LT(1);
		int console_write_statement_StartIndex = input.Index;
		object root_0 = null;

		IToken CONSOLE_WORD168=null;
		IToken char_literal169=null;
		IToken string_literal170=null;
		IToken string_literal171=null;
		IToken char_literal172=null;
		IToken char_literal174=null;
		IToken char_literal175=null;
		MathLangParser.expression_return expression173 = default(MathLangParser.expression_return);

		object CONSOLE_WORD168_tree=null;
		object char_literal169_tree=null;
		object string_literal170_tree=null;
		object string_literal171_tree=null;
		object char_literal172_tree=null;
		object char_literal174_tree=null;
		object char_literal175_tree=null;
		RewriteRuleITokenStream stream_CONSOLE_WORD=new RewriteRuleITokenStream(adaptor,"token CONSOLE_WORD");
		RewriteRuleITokenStream stream_66=new RewriteRuleITokenStream(adaptor,"token 66");
		RewriteRuleITokenStream stream_59=new RewriteRuleITokenStream(adaptor,"token 59");
		RewriteRuleITokenStream stream_58=new RewriteRuleITokenStream(adaptor,"token 58");
		RewriteRuleITokenStream stream_64=new RewriteRuleITokenStream(adaptor,"token 64");
		RewriteRuleITokenStream stream_65=new RewriteRuleITokenStream(adaptor,"token 65");
		RewriteRuleITokenStream stream_60=new RewriteRuleITokenStream(adaptor,"token 60");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "console_write_statement");
		DebugLocation(139, 117);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 44)) { return retval; }
			// MathLang.g:139:24: ( CONSOLE_WORD '.' ( 'WriteLine' | 'Write' ) '(' expression ')' ';' -> ^( PRINT expression ) )
			DebugEnterAlt(1);
			// MathLang.g:139:26: CONSOLE_WORD '.' ( 'WriteLine' | 'Write' ) '(' expression ')' ';'
			{
			DebugLocation(139, 26);
			CONSOLE_WORD168=(IToken)Match(input,CONSOLE_WORD,Follow._CONSOLE_WORD_in_console_write_statement1405); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CONSOLE_WORD.Add(CONSOLE_WORD168);

			DebugLocation(139, 42);
			char_literal169=(IToken)Match(input,64,Follow._64_in_console_write_statement1407); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_64.Add(char_literal169);

			DebugLocation(139, 44);
			// MathLang.g:139:44: ( 'WriteLine' | 'Write' )
			int alt34=2;
			try { DebugEnterSubRule(34);
			try { DebugEnterDecision(34, decisionCanBacktrack[34]);
			int LA34_0 = input.LA(1);

			if ((LA34_0==65))
			{
				alt34=1;
			}
			else if ((LA34_0==66))
			{
				alt34=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 34, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(34); }
			switch (alt34)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:139:45: 'WriteLine'
				{
				DebugLocation(139, 45);
				string_literal170=(IToken)Match(input,65,Follow._65_in_console_write_statement1411); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_65.Add(string_literal170);


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:139:59: 'Write'
				{
				DebugLocation(139, 59);
				string_literal171=(IToken)Match(input,66,Follow._66_in_console_write_statement1415); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_66.Add(string_literal171);


				}
				break;

			}
			} finally { DebugExitSubRule(34); }

			DebugLocation(139, 71);
			char_literal172=(IToken)Match(input,59,Follow._59_in_console_write_statement1418); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_59.Add(char_literal172);

			DebugLocation(139, 73);
			PushFollow(Follow._expression_in_console_write_statement1421);
			expression173=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression173.Tree);
			DebugLocation(139, 87);
			char_literal174=(IToken)Match(input,60,Follow._60_in_console_write_statement1423); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_60.Add(char_literal174);

			DebugLocation(139, 92);
			char_literal175=(IToken)Match(input,58,Follow._58_in_console_write_statement1426); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_58.Add(char_literal175);



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
			// 139:94: -> ^( PRINT expression )
			{
				DebugLocation(139, 97);
				// MathLang.g:139:97: ^( PRINT expression )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(139, 99);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PRINT, "PRINT"), root_1);

				DebugLocation(139, 105);
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
			TraceOut("console_write_statement", 44);
			LeaveRule("console_write_statement", 44);
			Leave_console_write_statement();
			if (state.backtracking > 0) { Memoize(input, 44, console_write_statement_StartIndex); }
		}
		DebugLocation(139, 117);
		} finally { DebugExitRule(GrammarFileName, "console_write_statement"); }
		return retval;

	}
	// $ANTLR end "console_write_statement"

	public class console_read_statement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_console_read_statement();
	partial void Leave_console_read_statement();

	// $ANTLR start "console_read_statement"
	// MathLang.g:140:1: console_read_statement : console_read_body ';' ;
	[GrammarRule("console_read_statement")]
	private MathLangParser.console_read_statement_return console_read_statement()
	{
		Enter_console_read_statement();
		EnterRule("console_read_statement", 45);
		TraceIn("console_read_statement", 45);
		MathLangParser.console_read_statement_return retval = new MathLangParser.console_read_statement_return();
		retval.Start = (IToken)input.LT(1);
		int console_read_statement_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal177=null;
		MathLangParser.console_read_body_return console_read_body176 = default(MathLangParser.console_read_body_return);

		object char_literal177_tree=null;

		try { DebugEnterRule(GrammarFileName, "console_read_statement");
		DebugLocation(140, 47);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 45)) { return retval; }
			// MathLang.g:140:23: ( console_read_body ';' )
			DebugEnterAlt(1);
			// MathLang.g:140:25: console_read_body ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(140, 25);
			PushFollow(Follow._console_read_body_in_console_read_statement1443);
			console_read_body176=console_read_body();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, console_read_body176.Tree);
			DebugLocation(140, 46);
			char_literal177=(IToken)Match(input,58,Follow._58_in_console_read_statement1445); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("console_read_statement", 45);
			LeaveRule("console_read_statement", 45);
			Leave_console_read_statement();
			if (state.backtracking > 0) { Memoize(input, 45, console_read_statement_StartIndex); }
		}
		DebugLocation(140, 47);
		} finally { DebugExitRule(GrammarFileName, "console_read_statement"); }
		return retval;

	}
	// $ANTLR end "console_read_statement"

	public class console_read_body_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_console_read_body();
	partial void Leave_console_read_body();

	// $ANTLR start "console_read_body"
	// MathLang.g:142:1: console_read_body : CONSOLE_WORD '.' ( 'ReadLine' | 'Read' ) '()' -> INPUT ;
	[GrammarRule("console_read_body")]
	private MathLangParser.console_read_body_return console_read_body()
	{
		Enter_console_read_body();
		EnterRule("console_read_body", 46);
		TraceIn("console_read_body", 46);
		MathLangParser.console_read_body_return retval = new MathLangParser.console_read_body_return();
		retval.Start = (IToken)input.LT(1);
		int console_read_body_StartIndex = input.Index;
		object root_0 = null;

		IToken CONSOLE_WORD178=null;
		IToken char_literal179=null;
		IToken string_literal180=null;
		IToken string_literal181=null;
		IToken string_literal182=null;

		object CONSOLE_WORD178_tree=null;
		object char_literal179_tree=null;
		object string_literal180_tree=null;
		object string_literal181_tree=null;
		object string_literal182_tree=null;
		RewriteRuleITokenStream stream_67=new RewriteRuleITokenStream(adaptor,"token 67");
		RewriteRuleITokenStream stream_CONSOLE_WORD=new RewriteRuleITokenStream(adaptor,"token CONSOLE_WORD");
		RewriteRuleITokenStream stream_69=new RewriteRuleITokenStream(adaptor,"token 69");
		RewriteRuleITokenStream stream_68=new RewriteRuleITokenStream(adaptor,"token 68");
		RewriteRuleITokenStream stream_64=new RewriteRuleITokenStream(adaptor,"token 64");

		try { DebugEnterRule(GrammarFileName, "console_read_body");
		DebugLocation(142, 74);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 46)) { return retval; }
			// MathLang.g:142:18: ( CONSOLE_WORD '.' ( 'ReadLine' | 'Read' ) '()' -> INPUT )
			DebugEnterAlt(1);
			// MathLang.g:142:20: CONSOLE_WORD '.' ( 'ReadLine' | 'Read' ) '()'
			{
			DebugLocation(142, 20);
			CONSOLE_WORD178=(IToken)Match(input,CONSOLE_WORD,Follow._CONSOLE_WORD_in_console_read_body1454); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CONSOLE_WORD.Add(CONSOLE_WORD178);

			DebugLocation(142, 36);
			char_literal179=(IToken)Match(input,64,Follow._64_in_console_read_body1456); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_64.Add(char_literal179);

			DebugLocation(142, 38);
			// MathLang.g:142:38: ( 'ReadLine' | 'Read' )
			int alt35=2;
			try { DebugEnterSubRule(35);
			try { DebugEnterDecision(35, decisionCanBacktrack[35]);
			int LA35_0 = input.LA(1);

			if ((LA35_0==67))
			{
				alt35=1;
			}
			else if ((LA35_0==68))
			{
				alt35=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 35, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(35); }
			switch (alt35)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:142:39: 'ReadLine'
				{
				DebugLocation(142, 39);
				string_literal180=(IToken)Match(input,67,Follow._67_in_console_read_body1460); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_67.Add(string_literal180);


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:142:52: 'Read'
				{
				DebugLocation(142, 52);
				string_literal181=(IToken)Match(input,68,Follow._68_in_console_read_body1464); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_68.Add(string_literal181);


				}
				break;

			}
			} finally { DebugExitSubRule(35); }

			DebugLocation(142, 60);
			string_literal182=(IToken)Match(input,69,Follow._69_in_console_read_body1467); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_69.Add(string_literal182);



			{
			// AST REWRITE
			// elements: 
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 142:65: -> INPUT
			{
				DebugLocation(142, 68);
				adaptor.AddChild(root_0, (object)adaptor.Create(INPUT, "INPUT"));

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
			TraceOut("console_read_body", 46);
			LeaveRule("console_read_body", 46);
			Leave_console_read_body();
			if (state.backtracking > 0) { Memoize(input, 46, console_read_body_StartIndex); }
		}
		DebugLocation(142, 74);
		} finally { DebugExitRule(GrammarFileName, "console_read_body"); }
		return retval;

	}
	// $ANTLR end "console_read_body"

	partial void Enter_synpred19_MathLang_fragment();
	partial void Leave_synpred19_MathLang_fragment();

	// $ANTLR start synpred19_MathLang
	public void synpred19_MathLang_fragment()
	{
		Enter_synpred19_MathLang_fragment();
		EnterRule("synpred19_MathLang_fragment", 65);
		TraceIn("synpred19_MathLang_fragment", 65);
		try
		{
			// MathLang.g:77:5: ( funccallbody )
			DebugEnterAlt(1);
			// MathLang.g:77:5: funccallbody
			{
			DebugLocation(77, 5);
			PushFollow(Follow._funccallbody_in_synpred19_MathLang546);
			funccallbody();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred19_MathLang_fragment", 65);
			LeaveRule("synpred19_MathLang_fragment", 65);
			Leave_synpred19_MathLang_fragment();
		}
	}
	// $ANTLR end synpred19_MathLang

	partial void Enter_synpred20_MathLang_fragment();
	partial void Leave_synpred20_MathLang_fragment();

	// $ANTLR start synpred20_MathLang
	public void synpred20_MathLang_fragment()
	{
		Enter_synpred20_MathLang_fragment();
		EnterRule("synpred20_MathLang_fragment", 66);
		TraceIn("synpred20_MathLang_fragment", 66);
		try
		{
			// MathLang.g:78:5: ( boolexpression )
			DebugEnterAlt(1);
			// MathLang.g:78:5: boolexpression
			{
			DebugLocation(78, 5);
			PushFollow(Follow._boolexpression_in_synpred20_MathLang552);
			boolexpression();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred20_MathLang_fragment", 66);
			LeaveRule("synpred20_MathLang_fragment", 66);
			Leave_synpred20_MathLang_fragment();
		}
	}
	// $ANTLR end synpred20_MathLang

	partial void Enter_synpred21_MathLang_fragment();
	partial void Leave_synpred21_MathLang_fragment();

	// $ANTLR start synpred21_MathLang
	public void synpred21_MathLang_fragment()
	{
		Enter_synpred21_MathLang_fragment();
		EnterRule("synpred21_MathLang_fragment", 67);
		TraceIn("synpred21_MathLang_fragment", 67);
		try
		{
			// MathLang.g:79:5: ( mathexpression )
			DebugEnterAlt(1);
			// MathLang.g:79:5: mathexpression
			{
			DebugLocation(79, 5);
			PushFollow(Follow._mathexpression_in_synpred21_MathLang558);
			mathexpression();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred21_MathLang_fragment", 67);
			LeaveRule("synpred21_MathLang_fragment", 67);
			Leave_synpred21_MathLang_fragment();
		}
	}
	// $ANTLR end synpred21_MathLang

	partial void Enter_synpred34_MathLang_fragment();
	partial void Leave_synpred34_MathLang_fragment();

	// $ANTLR start synpred34_MathLang
	public void synpred34_MathLang_fragment()
	{
		Enter_synpred34_MathLang_fragment();
		EnterRule("synpred34_MathLang_fragment", 80);
		TraceIn("synpred34_MathLang_fragment", 80);
		try
		{
			// MathLang.g:98:16: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )
			DebugEnterAlt(1);
			// MathLang.g:98:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
			{
			DebugLocation(98, 16);
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

			DebugLocation(98, 53);
			PushFollow(Follow._add_in_synpred34_MathLang805);
			add();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred34_MathLang_fragment", 80);
			LeaveRule("synpred34_MathLang_fragment", 80);
			Leave_synpred34_MathLang_fragment();
		}
	}
	// $ANTLR end synpred34_MathLang

	partial void Enter_synpred43_MathLang_fragment();
	partial void Leave_synpred43_MathLang_fragment();

	// $ANTLR start synpred43_MathLang
	public void synpred43_MathLang_fragment()
	{
		Enter_synpred43_MathLang_fragment();
		EnterRule("synpred43_MathLang_fragment", 89);
		TraceIn("synpred43_MathLang_fragment", 89);
		try
		{
			// MathLang.g:110:22: ( '(' boolterm ')' )
			DebugEnterAlt(1);
			// MathLang.g:110:22: '(' boolterm ')'
			{
			DebugLocation(110, 22);
			Match(input,59,Follow._59_in_synpred43_MathLang965); if (state.failed) return;
			DebugLocation(110, 27);
			PushFollow(Follow._boolterm_in_synpred43_MathLang968);
			boolterm();
			PopFollow();
			if (state.failed) return;
			DebugLocation(110, 36);
			Match(input,60,Follow._60_in_synpred43_MathLang970); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred43_MathLang_fragment", 89);
			LeaveRule("synpred43_MathLang_fragment", 89);
			Leave_synpred43_MathLang_fragment();
		}
	}
	// $ANTLR end synpred43_MathLang

	partial void Enter_synpred48_MathLang_fragment();
	partial void Leave_synpred48_MathLang_fragment();

	// $ANTLR start synpred48_MathLang
	public void synpred48_MathLang_fragment()
	{
		Enter_synpred48_MathLang_fragment();
		EnterRule("synpred48_MathLang_fragment", 94);
		TraceIn("synpred48_MathLang_fragment", 94);
		try
		{
			// MathLang.g:115:64: ( ELSE ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:115:64: ELSE ( block | statement )
			{
			DebugLocation(115, 64);
			Match(input,ELSE,Follow._ELSE_in_synpred48_MathLang1022); if (state.failed) return;
			DebugLocation(115, 70);
			// MathLang.g:115:70: ( block | statement )
			int alt37=2;
			try { DebugEnterSubRule(37);
			try { DebugEnterDecision(37, decisionCanBacktrack[37]);
			int LA37_0 = input.LA(1);

			if ((LA37_0==62))
			{
				alt37=1;
			}
			else if ((LA37_0==IF||LA37_0==FOR||(LA37_0>=RETURN && LA37_0<=DO)||LA37_0==TYPE||LA37_0==VOID||LA37_0==ID||(LA37_0>=KNEW && LA37_0<=CONSOLE_WORD)))
			{
				alt37=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				NoViableAltException nvae = new NoViableAltException("", 37, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(37); }
			switch (alt37)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:115:71: block
				{
				DebugLocation(115, 71);
				PushFollow(Follow._block_in_synpred48_MathLang1026);
				block();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:115:79: statement
				{
				DebugLocation(115, 79);
				PushFollow(Follow._statement_in_synpred48_MathLang1030);
				statement();
				PopFollow();
				if (state.failed) return;

				}
				break;

			}
			} finally { DebugExitSubRule(37); }


			}

		}
		finally
		{
			TraceOut("synpred48_MathLang_fragment", 94);
			LeaveRule("synpred48_MathLang_fragment", 94);
			Leave_synpred48_MathLang_fragment();
		}
	}
	// $ANTLR end synpred48_MathLang
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
	DFA4 dfa4;
	DFA10 dfa10;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa1 = new DFA1( this );
		dfa4 = new DFA4( this, SpecialStateTransition4 );
		dfa10 = new DFA10( this, SpecialStateTransition10 );
	}

	private class DFA1 : DFA
	{
		private const string DFA1_eotS =
			"\x14\xFFFF";
		private const string DFA1_eofS =
			"\x14\xFFFF";
		private const string DFA1_minS =
			"\x1\x7\x1\x1E\x1\x23\x7\xFFFF\x1\x40\x1\x21\x1\x23\x2\xFFFF\x1\x41\x1"+
			"\x23\x3\xFFFF";
		private const string DFA1_maxS =
			"\x1\x34\x1\x21\x1\x3B\x7\xFFFF\x1\x40\x1\x21\x1\x3B\x2\xFFFF\x1\x44"+
			"\x1\x3B\x3\xFFFF";
		private const string DFA1_acceptS =
			"\x3\xFFFF\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x1\x8\x1\xA\x3\xFFFF\x1\x2\x1"+
			"\x9\x2\xFFFF\x1\x1\x1\xB\x1\xC";
		private const string DFA1_specialS =
			"\x14\xFFFF}>";
		private static readonly string[] DFA1_transitionS =
			{
				"\x1\x3\x1\xFFFF\x1\x6\x1\xFFFF\x1\x8\x1\x4\x1\x5\xF\xFFFF\x1\x1\x1"+
				"\xFFFF\x1\x7\x1\xFFFF\x1\x2\x11\xFFFF\x1\x9\x1\xA",
				"\x1\xB\x2\xFFFF\x1\xC",
				"\x1\xD\x11\xFFFF\x1\xD\x5\xFFFF\x1\xE",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\xF",
				"\x1\x10",
				"\x1\x11\x16\xFFFF\x1\x11\x1\x7",
				"",
				"",
				"\x2\x12\x2\x13",
				"\x1\x11\x16\xFFFF\x1\x11\x1\x7",
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

		public override string Description { get { return "52:12: ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | funcdeclaration | returnstatement | funccall | newexpression | console_write_statement | console_read_statement )"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA4 : DFA
	{
		private const string DFA4_eotS =
			"\xD\xFFFF";
		private const string DFA4_eofS =
			"\xD\xFFFF";
		private const string DFA4_minS =
			"\x1\x20\x1\xFFFF\x1\x0\x1\xFFFF\x1\x0\x2\xFFFF\x3\x0\x3\xFFFF";
		private const string DFA4_maxS =
			"\x1\x3B\x1\xFFFF\x1\x0\x1\xFFFF\x1\x0\x2\xFFFF\x3\x0\x3\xFFFF";
		private const string DFA4_acceptS =
			"\x1\xFFFF\x1\x1\x1\xFFFF\x1\x3\x6\xFFFF\x1\x5\x1\x2\x1\x4";
		private const string DFA4_specialS =
			"\x2\xFFFF\x1\x0\x1\xFFFF\x1\x1\x2\xFFFF\x1\x2\x1\x3\x1\x4\x3\xFFFF}>";
		private static readonly string[] DFA4_transitionS =
			{
				"\x1\x8\x1\x2\x1\x9\x2\xFFFF\x1\x7\xA\xFFFF\x3\x3\x1\x1\x1\xA\x6\xFFFF"+
				"\x1\x4",
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
				"",
				""
			};

		private static readonly short[] DFA4_eot = DFA.UnpackEncodedString(DFA4_eotS);
		private static readonly short[] DFA4_eof = DFA.UnpackEncodedString(DFA4_eofS);
		private static readonly char[] DFA4_min = DFA.UnpackEncodedStringToUnsignedChars(DFA4_minS);
		private static readonly char[] DFA4_max = DFA.UnpackEncodedStringToUnsignedChars(DFA4_maxS);
		private static readonly short[] DFA4_accept = DFA.UnpackEncodedString(DFA4_acceptS);
		private static readonly short[] DFA4_special = DFA.UnpackEncodedString(DFA4_specialS);
		private static readonly short[][] DFA4_transition;

		static DFA4()
		{
			int numStates = DFA4_transitionS.Length;
			DFA4_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA4_transition[i] = DFA.UnpackEncodedString(DFA4_transitionS[i]);
			}
		}

		public DFA4( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 4;
			this.eot = DFA4_eot;
			this.eof = DFA4_eof;
			this.min = DFA4_min;
			this.max = DFA4_max;
			this.accept = DFA4_accept;
			this.special = DFA4_special;
			this.transition = DFA4_transition;
		}

		public override string Description { get { return "75:1: expression : ( newexpression | funccallbody | boolexpression | mathexpression | console_read_body );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition4(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA4_2 = input.LA(1);


				int index4_2 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred19_MathLang_fragment)) ) {s = 11;}

				else if ( (EvaluatePredicate(synpred20_MathLang_fragment)) ) {s = 3;}

				else if ( (EvaluatePredicate(synpred21_MathLang_fragment)) ) {s = 12;}


				input.Seek(index4_2);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA4_4 = input.LA(1);


				int index4_4 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred20_MathLang_fragment)) ) {s = 3;}

				else if ( (EvaluatePredicate(synpred21_MathLang_fragment)) ) {s = 12;}


				input.Seek(index4_4);
				if ( s>=0 ) return s;
				break;
			case 2:
				int LA4_7 = input.LA(1);


				int index4_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred20_MathLang_fragment)) ) {s = 3;}

				else if ( (EvaluatePredicate(synpred21_MathLang_fragment)) ) {s = 12;}


				input.Seek(index4_7);
				if ( s>=0 ) return s;
				break;
			case 3:
				int LA4_8 = input.LA(1);


				int index4_8 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred20_MathLang_fragment)) ) {s = 3;}

				else if ( (EvaluatePredicate(synpred21_MathLang_fragment)) ) {s = 12;}


				input.Seek(index4_8);
				if ( s>=0 ) return s;
				break;
			case 4:
				int LA4_9 = input.LA(1);


				int index4_9 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred20_MathLang_fragment)) ) {s = 3;}

				else if ( (EvaluatePredicate(synpred21_MathLang_fragment)) ) {s = 12;}


				input.Seek(index4_9);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 4, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA10 : DFA
	{
		private const string DFA10_eotS =
			"\xA\xFFFF";
		private const string DFA10_eofS =
			"\x1\x2\x9\xFFFF";
		private const string DFA10_minS =
			"\x1\x28\x1\x0\x8\xFFFF";
		private const string DFA10_maxS =
			"\x1\x3F\x1\x0\x8\xFFFF";
		private const string DFA10_acceptS =
			"\x2\xFFFF\x1\x2\x1\xFFFF\x1\x1\x5\xFFFF";
		private const string DFA10_specialS =
			"\x1\xFFFF\x1\x0\x8\xFFFF}>";
		private static readonly string[] DFA10_transitionS =
			{
				"\x2\x4\x2\x1\x2\x4\x2\x2\xA\xFFFF\x1\x2\x1\xFFFF\x2\x2\x1\xFFFF\x1"+
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

		private static readonly short[] DFA10_eot = DFA.UnpackEncodedString(DFA10_eotS);
		private static readonly short[] DFA10_eof = DFA.UnpackEncodedString(DFA10_eofS);
		private static readonly char[] DFA10_min = DFA.UnpackEncodedStringToUnsignedChars(DFA10_minS);
		private static readonly char[] DFA10_max = DFA.UnpackEncodedStringToUnsignedChars(DFA10_maxS);
		private static readonly short[] DFA10_accept = DFA.UnpackEncodedString(DFA10_acceptS);
		private static readonly short[] DFA10_special = DFA.UnpackEncodedString(DFA10_specialS);
		private static readonly short[][] DFA10_transition;

		static DFA10()
		{
			int numStates = DFA10_transitionS.Length;
			DFA10_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA10_transition[i] = DFA.UnpackEncodedString(DFA10_transitionS[i]);
			}
		}

		public DFA10( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 10;
			this.eot = DFA10_eot;
			this.eof = DFA10_eof;
			this.min = DFA10_min;
			this.max = DFA10_max;
			this.accept = DFA10_accept;
			this.special = DFA10_special;
			this.transition = DFA10_transition;
		}

		public override string Description { get { return "98:14: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition10(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA10_1 = input.LA(1);


				int index10_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred34_MathLang_fragment)) ) {s = 4;}

				else if ( (true) ) {s = 2;}


				input.Seek(index10_1);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 10, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}

	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _statementlist_in_execute385 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_execute387 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declaration_in_statement398 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assignment_in_statement404 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ifstatement_in_statement409 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _whilestatement_in_statement414 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _dowhilestatement_in_statement419 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _forstatement_in_statement424 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funcdeclaration_in_statement429 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _returnstatement_in_statement434 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccall_in_statement439 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _newexpression_in_statement444 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _console_write_statement_in_statement449 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _console_read_statement_in_statement454 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_type464 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_array_type471 = new BitSet(new ulong[]{0x40000000UL});
		public static readonly BitSet _ARRAY_DECLARATION_MARK_in_array_type473 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_any_type480 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_type_in_any_type484 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _VOID_in_any_type488 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NUMBER_in_number496 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_number502 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_number508 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CHAR_in_number514 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrayelement_in_number520 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _term_in_mathexpression526 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _newexpression_in_expression540 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_expression546 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolexpression_in_expression552 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathexpression_in_expression558 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _console_read_body_in_expression564 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_arrayelement576 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _SQRBL_in_arrayelement578 = new BitSet(new ulong[]{0x700000000UL});
		public static readonly BitSet _number_in_arrayelement580 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _SQRBR_in_arrayelement582 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declarationbody_in_declaration600 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_declaration602 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _longdeclaration_in_declaration610 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_declarationbody618 = new BitSet(new ulong[]{0x200000000UL});
		public static readonly BitSet _ID_in_declarationbody620 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_type_in_declarationbody641 = new BitSet(new ulong[]{0x200000000UL});
		public static readonly BitSet _ID_in_declarationbody643 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _longdeclarationbody_in_longdeclaration665 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_longdeclaration667 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_longdeclarationbody676 = new BitSet(new ulong[]{0x200000000UL});
		public static readonly BitSet _ID_in_longdeclarationbody678 = new BitSet(new ulong[]{0x800000000UL});
		public static readonly BitSet _ASSIGN_in_longdeclarationbody680 = new BitSet(new ulong[]{0x81F002700000000UL});
		public static readonly BitSet _expression_in_longdeclarationbody682 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_type_in_longdeclarationbody706 = new BitSet(new ulong[]{0x200000000UL});
		public static readonly BitSet _ID_in_longdeclarationbody708 = new BitSet(new ulong[]{0x800000000UL});
		public static readonly BitSet _ASSIGN_in_longdeclarationbody710 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _newexpression_in_longdeclarationbody712 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mul_in_add732 = new BitSet(new ulong[]{0x3000000002UL});
		public static readonly BitSet _set_in_add736 = new BitSet(new ulong[]{0x807002700000000UL});
		public static readonly BitSet _mul_in_add745 = new BitSet(new ulong[]{0x3000000002UL});
		public static readonly BitSet _group_in_mul754 = new BitSet(new ulong[]{0xC000000002UL});
		public static readonly BitSet _set_in_mul758 = new BitSet(new ulong[]{0x807002700000000UL});
		public static readonly BitSet _group_in_mul767 = new BitSet(new ulong[]{0xC000000002UL});
		public static readonly BitSet _add_in_compare775 = new BitSet(new ulong[]{0x3F0000000002UL});
		public static readonly BitSet _set_in_compare779 = new BitSet(new ulong[]{0x807002700000000UL});
		public static readonly BitSet _add_in_compare805 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _add_in_term816 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _SUB_in_group823 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_group828 = new BitSet(new ulong[]{0x807002700000000UL});
		public static readonly BitSet _term_in_group831 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_group833 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _number_in_group838 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assignmentbody_in_assignment845 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_assignment847 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_assignmentbody855 = new BitSet(new ulong[]{0x800000000UL});
		public static readonly BitSet _ASSIGN_in_assignmentbody857 = new BitSet(new ulong[]{0x81F002700000000UL});
		public static readonly BitSet _expression_in_assignmentbody859 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrayelement_in_assignmentbody878 = new BitSet(new ulong[]{0x800000000UL});
		public static readonly BitSet _ASSIGN_in_assignmentbody880 = new BitSet(new ulong[]{0x81F002700000000UL});
		public static readonly BitSet _expression_in_assignmentbody882 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolterm_in_boolexpression900 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _or_in_boolterm907 = new BitSet(new ulong[]{0xC0000000002UL});
		public static readonly BitSet _set_in_boolterm911 = new BitSet(new ulong[]{0x807002700000000UL});
		public static readonly BitSet _or_in_boolterm920 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _and_in_or929 = new BitSet(new ulong[]{0x400000000002UL});
		public static readonly BitSet _OR_in_or932 = new BitSet(new ulong[]{0x807002700000000UL});
		public static readonly BitSet _and_in_or935 = new BitSet(new ulong[]{0x400000000002UL});
		public static readonly BitSet _boolgroup_in_and943 = new BitSet(new ulong[]{0x800000000002UL});
		public static readonly BitSet _AND_in_and946 = new BitSet(new ulong[]{0x807002700000000UL});
		public static readonly BitSet _boolgroup_in_and949 = new BitSet(new ulong[]{0x800000000002UL});
		public static readonly BitSet _NOT_in_boolgroup958 = new BitSet(new ulong[]{0x807002700000000UL});
		public static readonly BitSet _59_in_boolgroup965 = new BitSet(new ulong[]{0x807002700000000UL});
		public static readonly BitSet _boolterm_in_boolgroup968 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_boolgroup970 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolvar_in_boolgroup975 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TRUE_in_boolvar983 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FALSE_in_boolvar989 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _compare_in_boolvar995 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_ifstatement1002 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_ifstatement1005 = new BitSet(new ulong[]{0x807002700000000UL});
		public static readonly BitSet _boolexpression_in_ifstatement1008 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_ifstatement1010 = new BitSet(new ulong[]{0x481F0027A0003A80UL});
		public static readonly BitSet _block_in_ifstatement1014 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement1018 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _ELSE_in_ifstatement1022 = new BitSet(new ulong[]{0x481F0027A0003A80UL});
		public static readonly BitSet _block_in_ifstatement1026 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement1030 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _WHILE_in_whilestatement1040 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_whilestatement1043 = new BitSet(new ulong[]{0x807002700000000UL});
		public static readonly BitSet _boolexpression_in_whilestatement1046 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_whilestatement1048 = new BitSet(new ulong[]{0x481F0027A0003A80UL});
		public static readonly BitSet _block_in_whilestatement1052 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_whilestatement1056 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_forstatement1063 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_forstatement1066 = new BitSet(new ulong[]{0x20000000UL});
		public static readonly BitSet _longdeclarationbody_in_forstatement1069 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_forstatement1071 = new BitSet(new ulong[]{0x807002700000000UL});
		public static readonly BitSet _boolexpression_in_forstatement1074 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_forstatement1076 = new BitSet(new ulong[]{0x700000000UL});
		public static readonly BitSet _assignmentbody_in_forstatement1079 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_forstatement1081 = new BitSet(new ulong[]{0x481F0027A0003A80UL});
		public static readonly BitSet _block_in_forstatement1085 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_forstatement1089 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _RETURN_in_returnstatement1096 = new BitSet(new ulong[]{0x81F002700000000UL});
		public static readonly BitSet _expression_in_returnstatement1099 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_returnstatement1101 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DO_in_dowhilestatement1109 = new BitSet(new ulong[]{0x481F0027A0003A80UL});
		public static readonly BitSet _block_in_dowhilestatement1113 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _statement_in_dowhilestatement1117 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _WHILE_in_dowhilestatement1120 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_dowhilestatement1123 = new BitSet(new ulong[]{0x807002700000000UL});
		public static readonly BitSet _boolexpression_in_dowhilestatement1126 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_dowhilestatement1128 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_dowhilestatement1131 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _any_type_in_funcdeclaration1140 = new BitSet(new ulong[]{0x200000000UL});
		public static readonly BitSet _ID_in_funcdeclaration1142 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_funcdeclaration1145 = new BitSet(new ulong[]{0x1000000020000000UL});
		public static readonly BitSet _paramsdeclaration_in_funcdeclaration1148 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_funcdeclaration1151 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _block_in_funcdeclaration1154 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declarationbody_in_paramsdeclaration1187 = new BitSet(new ulong[]{0x2000000000000002UL});
		public static readonly BitSet _61_in_paramsdeclaration1191 = new BitSet(new ulong[]{0x20000000UL});
		public static readonly BitSet _declarationbody_in_paramsdeclaration1194 = new BitSet(new ulong[]{0x2000000000000002UL});
		public static readonly BitSet _ID_in_funccallbody1219 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_funccallbody1222 = new BitSet(new ulong[]{0x181F002700000000UL});
		public static readonly BitSet _expressioncommalist_in_funccallbody1224 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_funccallbody1227 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_funccall1250 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_funccall1252 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_expressioncommalist1259 = new BitSet(new ulong[]{0x2000000000000002UL});
		public static readonly BitSet _61_in_expressioncommalist1263 = new BitSet(new ulong[]{0x81F002700000000UL});
		public static readonly BitSet _expression_in_expressioncommalist1266 = new BitSet(new ulong[]{0x2000000000000002UL});
		public static readonly BitSet _62_in_object_initializer1278 = new BitSet(new ulong[]{0x81F002700000000UL});
		public static readonly BitSet _expressioncommalist_in_object_initializer1280 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _63_in_object_initializer1282 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _KNEW_in_newexpression1297 = new BitSet(new ulong[]{0x20000000UL});
		public static readonly BitSet _initializer_in_newexpression1300 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _simple_var_initializer_in_initializer1307 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_initializer_in_initializer1311 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_simple_var_initializer1318 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_simple_var_initializer1320 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_simple_var_initializer1322 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_array_initializer1336 = new BitSet(new ulong[]{0x20000040000000UL});
		public static readonly BitSet _SQRBL_in_array_initializer1340 = new BitSet(new ulong[]{0x700000000UL});
		public static readonly BitSet _number_in_array_initializer1342 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _SQRBR_in_array_initializer1344 = new BitSet(new ulong[]{0x4000000000000002UL});
		public static readonly BitSet _ARRAY_DECLARATION_MARK_in_array_initializer1349 = new BitSet(new ulong[]{0x4000000000000002UL});
		public static readonly BitSet _object_initializer_in_array_initializer1352 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _62_in_block1374 = new BitSet(new ulong[]{0xC81F0027A0003A80UL});
		public static readonly BitSet _statementlist_in_block1377 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _63_in_block1379 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_statementlist1387 = new BitSet(new ulong[]{0x481F0027A0003A82UL});
		public static readonly BitSet _CONSOLE_WORD_in_console_write_statement1405 = new BitSet(new ulong[]{0x0UL,0x1UL});
		public static readonly BitSet _64_in_console_write_statement1407 = new BitSet(new ulong[]{0x0UL,0x6UL});
		public static readonly BitSet _65_in_console_write_statement1411 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _66_in_console_write_statement1415 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_console_write_statement1418 = new BitSet(new ulong[]{0x81F002700000000UL});
		public static readonly BitSet _expression_in_console_write_statement1421 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_console_write_statement1423 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_console_write_statement1426 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _console_read_body_in_console_read_statement1443 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_console_read_statement1445 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CONSOLE_WORD_in_console_read_body1454 = new BitSet(new ulong[]{0x0UL,0x1UL});
		public static readonly BitSet _64_in_console_read_body1456 = new BitSet(new ulong[]{0x0UL,0x18UL});
		public static readonly BitSet _67_in_console_read_body1460 = new BitSet(new ulong[]{0x0UL,0x20UL});
		public static readonly BitSet _68_in_console_read_body1464 = new BitSet(new ulong[]{0x0UL,0x20UL});
		public static readonly BitSet _69_in_console_read_body1467 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_synpred19_MathLang546 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolexpression_in_synpred20_MathLang552 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathexpression_in_synpred21_MathLang558 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_synpred34_MathLang779 = new BitSet(new ulong[]{0x807002700000000UL});
		public static readonly BitSet _add_in_synpred34_MathLang805 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _59_in_synpred43_MathLang965 = new BitSet(new ulong[]{0x807002700000000UL});
		public static readonly BitSet _boolterm_in_synpred43_MathLang968 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_synpred43_MathLang970 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ELSE_in_synpred48_MathLang1022 = new BitSet(new ulong[]{0x481F0027A0003A80UL});
		public static readonly BitSet _block_in_synpred48_MathLang1026 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_synpred48_MathLang1030 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  MathLang 

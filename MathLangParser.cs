// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-10-07 21:09:15

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "UNKNOWN", "PRINT", "INPUT", "IF", "ELSE", "FOR", "FUNCTION", "RETURN", "WHILE", "DO", "BLOCK", "PROGRAM", "PARAMS", "VARDECLARATION", "FUNCDECLARATION", "ARRAYDECLARATION", "VARASSIGNMENT", "ARRAYELEMENTASSIGNMENT", "ARRAYELEMENT", "NEWVAR", "ARRAY_INITIALIZER", "OBJECT_INITIALIZER", "FUNC_CALL", "RETURN_TYPE", "PARAMETERS", "TYPE", "ARRAY_DECLARATION_MARK", "VOID", "NUMBER", "ID", "CHAR", "ASSIGN", "ADD", "SUB", "MUL", "DIV", "GREQ", "LSEQ", "NEQ", "EQ", "GR", "LS", "OR", "AND", "NOT", "TRUE", "FALSE", "KNEW", "SQRBL", "SQRBR", "WS", "SL_COMMENT", "ML_COMMENT", "';'", "'('", "')'", "','", "'{'", "'}'"
	};
	public const int EOF=-1;
	public const int T__57=57;
	public const int T__58=58;
	public const int T__59=59;
	public const int T__60=60;
	public const int T__61=61;
	public const int T__62=62;
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
	public const int SQRBL=52;
	public const int SQRBR=53;
	public const int WS=54;
	public const int SL_COMMENT=55;
	public const int ML_COMMENT=56;

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
				false, false, false, , false
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
		this.state.ruleMemo = new System.Collections.Generic.Dictionary<int, int>[99+1];

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
	// MathLang.g:52:1: statement : ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | funcdeclaration | returnstatement | funccall | newexpression ) ;
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


		try { DebugEnterRule(GrammarFileName, "statement");
		DebugLocation(52, 18);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 2)) { return retval; }
			// MathLang.g:52:10: ( ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | funcdeclaration | returnstatement | funccall | newexpression ) )
			DebugEnterAlt(1);
			// MathLang.g:52:12: ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | funcdeclaration | returnstatement | funccall | newexpression )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(52, 12);
			// MathLang.g:52:12: ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | funcdeclaration | returnstatement | funccall | newexpression )
			int alt1=10;
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
		DebugLocation(61, 18);
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
	// MathLang.g:63:1: type : TYPE ;
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

		IToken TYPE13=null;

		object TYPE13_tree=null;

		try { DebugEnterRule(GrammarFileName, "type");
		DebugLocation(63, 11);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 3)) { return retval; }
			// MathLang.g:63:5: ( TYPE )
			DebugEnterAlt(1);
			// MathLang.g:63:7: TYPE
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(63, 7);
			TYPE13=(IToken)Match(input,TYPE,Follow._TYPE_in_type453); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			TYPE13_tree = (object)adaptor.Create(TYPE13);
			adaptor.AddChild(root_0, TYPE13_tree);
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
		DebugLocation(63, 11);
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
	// MathLang.g:64:1: array_type : TYPE ARRAY_DECLARATION_MARK ;
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

		IToken TYPE14=null;
		IToken ARRAY_DECLARATION_MARK15=null;

		object TYPE14_tree=null;
		object ARRAY_DECLARATION_MARK15_tree=null;

		try { DebugEnterRule(GrammarFileName, "array_type");
		DebugLocation(64, 40);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 4)) { return retval; }
			// MathLang.g:64:11: ( TYPE ARRAY_DECLARATION_MARK )
			DebugEnterAlt(1);
			// MathLang.g:64:13: TYPE ARRAY_DECLARATION_MARK
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(64, 13);
			TYPE14=(IToken)Match(input,TYPE,Follow._TYPE_in_array_type460); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			TYPE14_tree = (object)adaptor.Create(TYPE14);
			adaptor.AddChild(root_0, TYPE14_tree);
			}
			DebugLocation(64, 40);
			ARRAY_DECLARATION_MARK15=(IToken)Match(input,ARRAY_DECLARATION_MARK,Follow._ARRAY_DECLARATION_MARK_in_array_type462); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(64, 40);
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
	// MathLang.g:65:1: any_type : ( type | array_type | VOID );
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

		IToken VOID18=null;
		MathLangParser.type_return type16 = default(MathLangParser.type_return);
		MathLangParser.array_type_return array_type17 = default(MathLangParser.array_type_return);

		object VOID18_tree=null;

		try { DebugEnterRule(GrammarFileName, "any_type");
		DebugLocation(65, 34);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 5)) { return retval; }
			// MathLang.g:65:9: ( type | array_type | VOID )
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
				// MathLang.g:65:11: type
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(65, 11);
				PushFollow(Follow._type_in_any_type469);
				type16=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type16.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:65:18: array_type
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(65, 18);
				PushFollow(Follow._array_type_in_any_type473);
				array_type17=array_type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, array_type17.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:65:31: VOID
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(65, 31);
				VOID18=(IToken)Match(input,VOID,Follow._VOID_in_any_type477); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				VOID18_tree = (object)adaptor.Create(VOID18);
				adaptor.AddChild(root_0, VOID18_tree);
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
		DebugLocation(65, 34);
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
	// MathLang.g:66:1: number : ( NUMBER | ID | funccallbody | CHAR | arrayelement );
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

		IToken NUMBER19=null;
		IToken ID20=null;
		IToken CHAR22=null;
		MathLangParser.funccallbody_return funccallbody21 = default(MathLangParser.funccallbody_return);
		MathLangParser.arrayelement_return arrayelement23 = default(MathLangParser.arrayelement_return);

		object NUMBER19_tree=null;
		object ID20_tree=null;
		object CHAR22_tree=null;

		try { DebugEnterRule(GrammarFileName, "number");
		DebugLocation(66, 16);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 6)) { return retval; }
			// MathLang.g:66:8: ( NUMBER | ID | funccallbody | CHAR | arrayelement )
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
				case 58:
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
				case 57:
				case 59:
				case 60:
				case 62:
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
				// MathLang.g:66:11: NUMBER
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(66, 11);
				NUMBER19=(IToken)Match(input,NUMBER,Follow._NUMBER_in_number485); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				NUMBER19_tree = (object)adaptor.Create(NUMBER19);
				adaptor.AddChild(root_0, NUMBER19_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:67:5: ID
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(67, 5);
				ID20=(IToken)Match(input,ID,Follow._ID_in_number491); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				ID20_tree = (object)adaptor.Create(ID20);
				adaptor.AddChild(root_0, ID20_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:68:5: funccallbody
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(68, 5);
				PushFollow(Follow._funccallbody_in_number497);
				funccallbody21=funccallbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody21.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:69:5: CHAR
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(69, 5);
				CHAR22=(IToken)Match(input,CHAR,Follow._CHAR_in_number503); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				CHAR22_tree = (object)adaptor.Create(CHAR22);
				adaptor.AddChild(root_0, CHAR22_tree);
				}

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:70:5: arrayelement
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(70, 5);
				PushFollow(Follow._arrayelement_in_number509);
				arrayelement23=arrayelement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayelement23.Tree);

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
		DebugLocation(70, 16);
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
	// MathLang.g:71:1: mathexpression : term ;
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

		MathLangParser.term_return term24 = default(MathLangParser.term_return);


		try { DebugEnterRule(GrammarFileName, "mathexpression");
		DebugLocation(71, 21);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 7)) { return retval; }
			// MathLang.g:71:15: ( term )
			DebugEnterAlt(1);
			// MathLang.g:71:17: term
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(71, 17);
			PushFollow(Follow._term_in_mathexpression515);
			term24=term();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term24.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(71, 21);
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
	// MathLang.g:73:1: expression : ( newexpression | funccallbody | boolexpression | mathexpression );
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

		MathLangParser.newexpression_return newexpression25 = default(MathLangParser.newexpression_return);
		MathLangParser.funccallbody_return funccallbody26 = default(MathLangParser.funccallbody_return);
		MathLangParser.boolexpression_return boolexpression27 = default(MathLangParser.boolexpression_return);
		MathLangParser.mathexpression_return mathexpression28 = default(MathLangParser.mathexpression_return);


		try { DebugEnterRule(GrammarFileName, "expression");
		DebugLocation(73, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 8)) { return retval; }
			// MathLang.g:73:11: ( newexpression | funccallbody | boolexpression | mathexpression )
			int alt4=4;
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
				// MathLang.g:74:5: newexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(74, 5);
				PushFollow(Follow._newexpression_in_expression529);
				newexpression25=newexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, newexpression25.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:75:5: funccallbody
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(75, 5);
				PushFollow(Follow._funccallbody_in_expression535);
				funccallbody26=funccallbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody26.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:76:5: boolexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(76, 5);
				PushFollow(Follow._boolexpression_in_expression541);
				boolexpression27=boolexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression27.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:77:5: mathexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(77, 5);
				PushFollow(Follow._mathexpression_in_expression547);
				mathexpression28=mathexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mathexpression28.Tree);

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
		DebugLocation(79, 0);
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
	// MathLang.g:81:1: arrayelement : ID '[' number ']' -> ^( ARRAYELEMENT ID number ) ;
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

		IToken ID29=null;
		IToken char_literal30=null;
		IToken char_literal32=null;
		MathLangParser.number_return number31 = default(MathLangParser.number_return);

		object ID29_tree=null;
		object char_literal30_tree=null;
		object char_literal32_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_SQRBR=new RewriteRuleITokenStream(adaptor,"token SQRBR");
		RewriteRuleITokenStream stream_SQRBL=new RewriteRuleITokenStream(adaptor,"token SQRBL");
		RewriteRuleSubtreeStream stream_number=new RewriteRuleSubtreeStream(adaptor,"rule number");
		try { DebugEnterRule(GrammarFileName, "arrayelement");
		DebugLocation(81, 62);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 9)) { return retval; }
			// MathLang.g:81:13: ( ID '[' number ']' -> ^( ARRAYELEMENT ID number ) )
			DebugEnterAlt(1);
			// MathLang.g:81:16: ID '[' number ']'
			{
			DebugLocation(81, 16);
			ID29=(IToken)Match(input,ID,Follow._ID_in_arrayelement559); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID29);

			DebugLocation(81, 19);
			char_literal30=(IToken)Match(input,SQRBL,Follow._SQRBL_in_arrayelement561); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_SQRBL.Add(char_literal30);

			DebugLocation(81, 23);
			PushFollow(Follow._number_in_arrayelement563);
			number31=number();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_number.Add(number31.Tree);
			DebugLocation(81, 30);
			char_literal32=(IToken)Match(input,SQRBR,Follow._SQRBR_in_arrayelement565); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_SQRBR.Add(char_literal32);



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
			// 81:34: -> ^( ARRAYELEMENT ID number )
			{
				DebugLocation(81, 37);
				// MathLang.g:81:37: ^( ARRAYELEMENT ID number )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(81, 39);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYELEMENT, "ARRAYELEMENT"), root_1);

				DebugLocation(81, 52);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(81, 55);
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
		DebugLocation(81, 62);
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
	// MathLang.g:83:1: declaration : ( declarationbody ';' | longdeclaration );
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

		IToken char_literal34=null;
		MathLangParser.declarationbody_return declarationbody33 = default(MathLangParser.declarationbody_return);
		MathLangParser.longdeclaration_return longdeclaration35 = default(MathLangParser.longdeclaration_return);

		object char_literal34_tree=null;

		try { DebugEnterRule(GrammarFileName, "declaration");
		DebugLocation(83, 20);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 10)) { return retval; }
			// MathLang.g:83:12: ( declarationbody ';' | longdeclaration )
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
						else if ((LA5_4==57))
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
					else if ((LA5_3==57))
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
				// MathLang.g:83:14: declarationbody ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(83, 14);
				PushFollow(Follow._declarationbody_in_declaration583);
				declarationbody33=declarationbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, declarationbody33.Tree);
				DebugLocation(83, 33);
				char_literal34=(IToken)Match(input,57,Follow._57_in_declaration585); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:84:6: longdeclaration
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(84, 6);
				PushFollow(Follow._longdeclaration_in_declaration593);
				longdeclaration35=longdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclaration35.Tree);

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
		DebugLocation(84, 20);
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
	// MathLang.g:86:1: declarationbody : ( ( type ID -> ^( VARDECLARATION type ID ) ) | ( array_type ID -> ^( ARRAYDECLARATION array_type ID ) ) );
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

		IToken ID37=null;
		IToken ID39=null;
		MathLangParser.type_return type36 = default(MathLangParser.type_return);
		MathLangParser.array_type_return array_type38 = default(MathLangParser.array_type_return);

		object ID37_tree=null;
		object ID39_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleSubtreeStream stream_array_type=new RewriteRuleSubtreeStream(adaptor,"rule array_type");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "declarationbody");
		DebugLocation(86, 4);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 11)) { return retval; }
			// MathLang.g:86:16: ( ( type ID -> ^( VARDECLARATION type ID ) ) | ( array_type ID -> ^( ARRAYDECLARATION array_type ID ) ) )
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
				// MathLang.g:86:18: ( type ID -> ^( VARDECLARATION type ID ) )
				{
				DebugLocation(86, 18);
				// MathLang.g:86:18: ( type ID -> ^( VARDECLARATION type ID ) )
				DebugEnterAlt(1);
				// MathLang.g:86:19: type ID
				{
				DebugLocation(86, 19);
				PushFollow(Follow._type_in_declarationbody601);
				type36=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type36.Tree);
				DebugLocation(86, 24);
				ID37=(IToken)Match(input,ID,Follow._ID_in_declarationbody603); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID37);



				{
				// AST REWRITE
				// elements: type, ID
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 86:27: -> ^( VARDECLARATION type ID )
				{
					DebugLocation(86, 30);
					// MathLang.g:86:30: ^( VARDECLARATION type ID )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(86, 32);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDECLARATION, "VARDECLARATION"), root_1);

					DebugLocation(86, 47);
					adaptor.AddChild(root_1, stream_type.NextTree());
					DebugLocation(86, 52);
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
				// MathLang.g:87:7: ( array_type ID -> ^( ARRAYDECLARATION array_type ID ) )
				{
				DebugLocation(87, 7);
				// MathLang.g:87:7: ( array_type ID -> ^( ARRAYDECLARATION array_type ID ) )
				DebugEnterAlt(1);
				// MathLang.g:87:8: array_type ID
				{
				DebugLocation(87, 8);
				PushFollow(Follow._array_type_in_declarationbody624);
				array_type38=array_type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_array_type.Add(array_type38.Tree);
				DebugLocation(87, 19);
				ID39=(IToken)Match(input,ID,Follow._ID_in_declarationbody626); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID39);



				{
				// AST REWRITE
				// elements: ID, array_type
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 87:22: -> ^( ARRAYDECLARATION array_type ID )
				{
					DebugLocation(87, 25);
					// MathLang.g:87:25: ^( ARRAYDECLARATION array_type ID )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(87, 27);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYDECLARATION, "ARRAYDECLARATION"), root_1);

					DebugLocation(87, 44);
					adaptor.AddChild(root_1, stream_array_type.NextTree());
					DebugLocation(87, 55);
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
		DebugLocation(88, 4);
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
	// MathLang.g:89:1: longdeclaration : longdeclarationbody ';' ;
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

		IToken char_literal41=null;
		MathLangParser.longdeclarationbody_return longdeclarationbody40 = default(MathLangParser.longdeclarationbody_return);

		object char_literal41_tree=null;

		try { DebugEnterRule(GrammarFileName, "longdeclaration");
		DebugLocation(89, 42);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 12)) { return retval; }
			// MathLang.g:89:16: ( longdeclarationbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:89:18: longdeclarationbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(89, 18);
			PushFollow(Follow._longdeclarationbody_in_longdeclaration648);
			longdeclarationbody40=longdeclarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclarationbody40.Tree);
			DebugLocation(89, 41);
			char_literal41=(IToken)Match(input,57,Follow._57_in_longdeclaration650); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(89, 42);
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
	// MathLang.g:90:1: longdeclarationbody : ( ( type ID ASSIGN expression -> ^( VARDECLARATION type ID expression ) ) | ( array_type ID ASSIGN newexpression -> ^( ARRAYDECLARATION array_type ID newexpression ) ) );
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

		IToken ID43=null;
		IToken ASSIGN44=null;
		IToken ID47=null;
		IToken ASSIGN48=null;
		MathLangParser.type_return type42 = default(MathLangParser.type_return);
		MathLangParser.expression_return expression45 = default(MathLangParser.expression_return);
		MathLangParser.array_type_return array_type46 = default(MathLangParser.array_type_return);
		MathLangParser.newexpression_return newexpression49 = default(MathLangParser.newexpression_return);

		object ID43_tree=null;
		object ASSIGN44_tree=null;
		object ID47_tree=null;
		object ASSIGN48_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_newexpression=new RewriteRuleSubtreeStream(adaptor,"rule newexpression");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_array_type=new RewriteRuleSubtreeStream(adaptor,"rule array_type");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "longdeclarationbody");
		DebugLocation(90, 94);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 13)) { return retval; }
			// MathLang.g:90:20: ( ( type ID ASSIGN expression -> ^( VARDECLARATION type ID expression ) ) | ( array_type ID ASSIGN newexpression -> ^( ARRAYDECLARATION array_type ID newexpression ) ) )
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
				// MathLang.g:90:22: ( type ID ASSIGN expression -> ^( VARDECLARATION type ID expression ) )
				{
				DebugLocation(90, 22);
				// MathLang.g:90:22: ( type ID ASSIGN expression -> ^( VARDECLARATION type ID expression ) )
				DebugEnterAlt(1);
				// MathLang.g:90:23: type ID ASSIGN expression
				{
				DebugLocation(90, 23);
				PushFollow(Follow._type_in_longdeclarationbody659);
				type42=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type42.Tree);
				DebugLocation(90, 28);
				ID43=(IToken)Match(input,ID,Follow._ID_in_longdeclarationbody661); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID43);

				DebugLocation(90, 31);
				ASSIGN44=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclarationbody663); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN44);

				DebugLocation(90, 38);
				PushFollow(Follow._expression_in_longdeclarationbody665);
				expression45=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression45.Tree);


				{
				// AST REWRITE
				// elements: expression, ID, type
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 90:50: -> ^( VARDECLARATION type ID expression )
				{
					DebugLocation(90, 53);
					// MathLang.g:90:53: ^( VARDECLARATION type ID expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(90, 55);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDECLARATION, "VARDECLARATION"), root_1);

					DebugLocation(90, 70);
					adaptor.AddChild(root_1, stream_type.NextTree());
					DebugLocation(90, 75);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(90, 78);
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
				// MathLang.g:91:8: ( array_type ID ASSIGN newexpression -> ^( ARRAYDECLARATION array_type ID newexpression ) )
				{
				DebugLocation(91, 8);
				// MathLang.g:91:8: ( array_type ID ASSIGN newexpression -> ^( ARRAYDECLARATION array_type ID newexpression ) )
				DebugEnterAlt(1);
				// MathLang.g:91:9: array_type ID ASSIGN newexpression
				{
				DebugLocation(91, 9);
				PushFollow(Follow._array_type_in_longdeclarationbody689);
				array_type46=array_type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_array_type.Add(array_type46.Tree);
				DebugLocation(91, 20);
				ID47=(IToken)Match(input,ID,Follow._ID_in_longdeclarationbody691); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID47);

				DebugLocation(91, 23);
				ASSIGN48=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclarationbody693); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN48);

				DebugLocation(91, 30);
				PushFollow(Follow._newexpression_in_longdeclarationbody695);
				newexpression49=newexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_newexpression.Add(newexpression49.Tree);


				{
				// AST REWRITE
				// elements: array_type, newexpression, ID
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 91:44: -> ^( ARRAYDECLARATION array_type ID newexpression )
				{
					DebugLocation(91, 47);
					// MathLang.g:91:47: ^( ARRAYDECLARATION array_type ID newexpression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(91, 49);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYDECLARATION, "ARRAYDECLARATION"), root_1);

					DebugLocation(91, 66);
					adaptor.AddChild(root_1, stream_array_type.NextTree());
					DebugLocation(91, 77);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(91, 80);
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
		DebugLocation(91, 94);
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
	// MathLang.g:93:1: add : mul ( ( ADD | SUB ) mul )* ;
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

		IToken set51=null;
		MathLangParser.mul_return mul50 = default(MathLangParser.mul_return);
		MathLangParser.mul_return mul52 = default(MathLangParser.mul_return);

		object set51_tree=null;

		try { DebugEnterRule(GrammarFileName, "add");
		DebugLocation(93, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 14)) { return retval; }
			// MathLang.g:93:4: ( mul ( ( ADD | SUB ) mul )* )
			DebugEnterAlt(1);
			// MathLang.g:93:6: mul ( ( ADD | SUB ) mul )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(93, 6);
			PushFollow(Follow._mul_in_add715);
			mul50=mul();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul50.Tree);
			DebugLocation(93, 10);
			// MathLang.g:93:10: ( ( ADD | SUB ) mul )*
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
					// MathLang.g:93:12: ( ADD | SUB ) mul
					{
					DebugLocation(93, 12);
					set51=(IToken)input.LT(1);
					set51=(IToken)input.LT(1);
					if ((input.LA(1)>=ADD && input.LA(1)<=SUB))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set51), root_0);
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(93, 25);
					PushFollow(Follow._mul_in_add728);
					mul52=mul();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul52.Tree);

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
		DebugLocation(93, 30);
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
	// MathLang.g:94:1: mul : group ( ( MUL | DIV ) group )* ;
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

		IToken set54=null;
		MathLangParser.group_return group53 = default(MathLangParser.group_return);
		MathLangParser.group_return group55 = default(MathLangParser.group_return);

		object set54_tree=null;

		try { DebugEnterRule(GrammarFileName, "mul");
		DebugLocation(94, 33);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 15)) { return retval; }
			// MathLang.g:94:4: ( group ( ( MUL | DIV ) group )* )
			DebugEnterAlt(1);
			// MathLang.g:94:6: group ( ( MUL | DIV ) group )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(94, 6);
			PushFollow(Follow._group_in_mul737);
			group53=group();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group53.Tree);
			DebugLocation(94, 12);
			// MathLang.g:94:12: ( ( MUL | DIV ) group )*
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
					// MathLang.g:94:14: ( MUL | DIV ) group
					{
					DebugLocation(94, 14);
					set54=(IToken)input.LT(1);
					set54=(IToken)input.LT(1);
					if ((input.LA(1)>=MUL && input.LA(1)<=DIV))
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

					DebugLocation(94, 27);
					PushFollow(Follow._group_in_mul750);
					group55=group();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group55.Tree);

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
		DebugLocation(94, 33);
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
	// MathLang.g:95:1: compare : add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )? ;
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

		IToken set57=null;
		MathLangParser.add_return add56 = default(MathLangParser.add_return);
		MathLangParser.add_return add58 = default(MathLangParser.add_return);

		object set57_tree=null;

		try { DebugEnterRule(GrammarFileName, "compare");
		DebugLocation(95, 60);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 16)) { return retval; }
			// MathLang.g:95:8: ( add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )? )
			DebugEnterAlt(1);
			// MathLang.g:95:10: add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(95, 10);
			PushFollow(Follow._add_in_compare758);
			add56=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add56.Tree);
			DebugLocation(95, 14);
			// MathLang.g:95:14: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
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
				// MathLang.g:95:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
				{
				DebugLocation(95, 16);
				set57=(IToken)input.LT(1);
				set57=(IToken)input.LT(1);
				if ((input.LA(1)>=GREQ && input.LA(1)<=LS))
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

				DebugLocation(95, 53);
				PushFollow(Follow._add_in_compare788);
				add58=add();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add58.Tree);

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
		DebugLocation(95, 60);
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
	// MathLang.g:96:1: term : add ;
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

		MathLangParser.add_return add59 = default(MathLangParser.add_return);


		try { DebugEnterRule(GrammarFileName, "term");
		DebugLocation(96, 9);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 17)) { return retval; }
			// MathLang.g:96:5: ( add )
			DebugEnterAlt(1);
			// MathLang.g:96:7: add
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(96, 7);
			PushFollow(Follow._add_in_term799);
			add59=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add59.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(96, 9);
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
	// MathLang.g:97:1: group : ( ( SUB )? '(' term ')' | number );
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

		IToken SUB60=null;
		IToken char_literal61=null;
		IToken char_literal63=null;
		MathLangParser.term_return term62 = default(MathLangParser.term_return);
		MathLangParser.number_return number64 = default(MathLangParser.number_return);

		object SUB60_tree=null;
		object char_literal61_tree=null;
		object char_literal63_tree=null;

		try { DebugEnterRule(GrammarFileName, "group");
		DebugLocation(97, 38);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 18)) { return retval; }
			// MathLang.g:97:6: ( ( SUB )? '(' term ')' | number )
			int alt12=2;
			try { DebugEnterDecision(12, decisionCanBacktrack[12]);
			int LA12_0 = input.LA(1);

			if ((LA12_0==SUB||LA12_0==58))
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
				// MathLang.g:97:8: ( SUB )? '(' term ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(97, 8);
				// MathLang.g:97:8: ( SUB )?
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
					// MathLang.g:97:9: SUB
					{
					DebugLocation(97, 12);
					SUB60=(IToken)Match(input,SUB,Follow._SUB_in_group806); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					SUB60_tree = (object)adaptor.Create(SUB60);
					root_0 = (object)adaptor.BecomeRoot(SUB60_tree, root_0);
					}

					}
					break;

				}
				} finally { DebugExitSubRule(11); }

				DebugLocation(97, 19);
				char_literal61=(IToken)Match(input,58,Follow._58_in_group811); if (state.failed) return retval;
				DebugLocation(97, 21);
				PushFollow(Follow._term_in_group814);
				term62=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term62.Tree);
				DebugLocation(97, 29);
				char_literal63=(IToken)Match(input,59,Follow._59_in_group816); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:97:33: number
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(97, 33);
				PushFollow(Follow._number_in_group821);
				number64=number();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, number64.Tree);

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
		DebugLocation(97, 38);
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
	// MathLang.g:99:1: assignment : assignmentbody ';' ;
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

		IToken char_literal66=null;
		MathLangParser.assignmentbody_return assignmentbody65 = default(MathLangParser.assignmentbody_return);

		object char_literal66_tree=null;

		try { DebugEnterRule(GrammarFileName, "assignment");
		DebugLocation(99, 31);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 19)) { return retval; }
			// MathLang.g:99:11: ( assignmentbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:99:13: assignmentbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(99, 13);
			PushFollow(Follow._assignmentbody_in_assignment828);
			assignmentbody65=assignmentbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentbody65.Tree);
			DebugLocation(99, 31);
			char_literal66=(IToken)Match(input,57,Follow._57_in_assignment830); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(99, 31);
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
	// MathLang.g:100:1: assignmentbody : ( ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) ) | ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) ) );
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

		IToken ID67=null;
		IToken ASSIGN68=null;
		IToken ASSIGN71=null;
		MathLangParser.expression_return expression69 = default(MathLangParser.expression_return);
		MathLangParser.arrayelement_return arrayelement70 = default(MathLangParser.arrayelement_return);
		MathLangParser.expression_return expression72 = default(MathLangParser.expression_return);

		object ID67_tree=null;
		object ASSIGN68_tree=null;
		object ASSIGN71_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_arrayelement=new RewriteRuleSubtreeStream(adaptor,"rule arrayelement");
		try { DebugEnterRule(GrammarFileName, "assignmentbody");
		DebugLocation(100, 87);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 20)) { return retval; }
			// MathLang.g:100:15: ( ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) ) | ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) ) )
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
				// MathLang.g:100:17: ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) )
				{
				DebugLocation(100, 17);
				// MathLang.g:100:17: ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) )
				DebugEnterAlt(1);
				// MathLang.g:100:18: ID ASSIGN expression
				{
				DebugLocation(100, 18);
				ID67=(IToken)Match(input,ID,Follow._ID_in_assignmentbody838); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID67);

				DebugLocation(100, 21);
				ASSIGN68=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignmentbody840); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN68);

				DebugLocation(100, 28);
				PushFollow(Follow._expression_in_assignmentbody842);
				expression69=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression69.Tree);


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
				// 100:39: -> ^( VARASSIGNMENT ID expression )
				{
					DebugLocation(100, 42);
					// MathLang.g:100:42: ^( VARASSIGNMENT ID expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(100, 44);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARASSIGNMENT, "VARASSIGNMENT"), root_1);

					DebugLocation(100, 58);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(100, 61);
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
				// MathLang.g:101:2: ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) )
				{
				DebugLocation(101, 2);
				// MathLang.g:101:2: ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) )
				DebugEnterAlt(1);
				// MathLang.g:101:4: arrayelement ASSIGN expression
				{
				DebugLocation(101, 4);
				PushFollow(Follow._arrayelement_in_assignmentbody861);
				arrayelement70=arrayelement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_arrayelement.Add(arrayelement70.Tree);
				DebugLocation(101, 17);
				ASSIGN71=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignmentbody863); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN71);

				DebugLocation(101, 24);
				PushFollow(Follow._expression_in_assignmentbody865);
				expression72=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression72.Tree);


				{
				// AST REWRITE
				// elements: arrayelement, expression
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 101:35: -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression )
				{
					DebugLocation(101, 38);
					// MathLang.g:101:38: ^( ARRAYELEMENTASSIGNMENT arrayelement expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(101, 40);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYELEMENTASSIGNMENT, "ARRAYELEMENTASSIGNMENT"), root_1);

					DebugLocation(101, 63);
					adaptor.AddChild(root_1, stream_arrayelement.NextTree());
					DebugLocation(101, 76);
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
		DebugLocation(101, 87);
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
	// MathLang.g:103:1: boolexpression : boolterm ;
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

		MathLangParser.boolterm_return boolterm73 = default(MathLangParser.boolterm_return);


		try { DebugEnterRule(GrammarFileName, "boolexpression");
		DebugLocation(103, 25);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 21)) { return retval; }
			// MathLang.g:103:15: ( boolterm )
			DebugEnterAlt(1);
			// MathLang.g:103:17: boolterm
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(103, 17);
			PushFollow(Follow._boolterm_in_boolexpression883);
			boolterm73=boolterm();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm73.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(103, 25);
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
	// MathLang.g:104:1: boolterm : or ( ( EQ | NEQ ) or )? ;
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

		IToken set75=null;
		MathLangParser.or_return or74 = default(MathLangParser.or_return);
		MathLangParser.or_return or76 = default(MathLangParser.or_return);

		object set75_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolterm");
		DebugLocation(104, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 22)) { return retval; }
			// MathLang.g:104:9: ( or ( ( EQ | NEQ ) or )? )
			DebugEnterAlt(1);
			// MathLang.g:104:11: or ( ( EQ | NEQ ) or )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(104, 11);
			PushFollow(Follow._or_in_boolterm890);
			or74=or();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or74.Tree);
			DebugLocation(104, 14);
			// MathLang.g:104:14: ( ( EQ | NEQ ) or )?
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
				// MathLang.g:104:16: ( EQ | NEQ ) or
				{
				DebugLocation(104, 16);
				set75=(IToken)input.LT(1);
				set75=(IToken)input.LT(1);
				if ((input.LA(1)>=NEQ && input.LA(1)<=EQ))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set75), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(104, 28);
				PushFollow(Follow._or_in_boolterm903);
				or76=or();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or76.Tree);

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
		DebugLocation(104, 32);
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
	// MathLang.g:105:1: or : and ( OR and )* ;
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

		IToken OR78=null;
		MathLangParser.and_return and77 = default(MathLangParser.and_return);
		MathLangParser.and_return and79 = default(MathLangParser.and_return);

		object OR78_tree=null;

		try { DebugEnterRule(GrammarFileName, "or");
		DebugLocation(105, 18);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 23)) { return retval; }
			// MathLang.g:105:3: ( and ( OR and )* )
			DebugEnterAlt(1);
			// MathLang.g:105:5: and ( OR and )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(105, 5);
			PushFollow(Follow._and_in_or912);
			and77=and();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and77.Tree);
			DebugLocation(105, 9);
			// MathLang.g:105:9: ( OR and )*
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
					// MathLang.g:105:10: OR and
					{
					DebugLocation(105, 12);
					OR78=(IToken)Match(input,OR,Follow._OR_in_or915); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR78_tree = (object)adaptor.Create(OR78);
					root_0 = (object)adaptor.BecomeRoot(OR78_tree, root_0);
					}
					DebugLocation(105, 14);
					PushFollow(Follow._and_in_or918);
					and79=and();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and79.Tree);

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
		DebugLocation(105, 18);
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
	// MathLang.g:106:1: and : boolgroup ( AND boolgroup )* ;
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

		IToken AND81=null;
		MathLangParser.boolgroup_return boolgroup80 = default(MathLangParser.boolgroup_return);
		MathLangParser.boolgroup_return boolgroup82 = default(MathLangParser.boolgroup_return);

		object AND81_tree=null;

		try { DebugEnterRule(GrammarFileName, "and");
		DebugLocation(106, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 24)) { return retval; }
			// MathLang.g:106:4: ( boolgroup ( AND boolgroup )* )
			DebugEnterAlt(1);
			// MathLang.g:106:6: boolgroup ( AND boolgroup )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(106, 6);
			PushFollow(Follow._boolgroup_in_and926);
			boolgroup80=boolgroup();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup80.Tree);
			DebugLocation(106, 16);
			// MathLang.g:106:16: ( AND boolgroup )*
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
					// MathLang.g:106:17: AND boolgroup
					{
					DebugLocation(106, 20);
					AND81=(IToken)Match(input,AND,Follow._AND_in_and929); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND81_tree = (object)adaptor.Create(AND81);
					root_0 = (object)adaptor.BecomeRoot(AND81_tree, root_0);
					}
					DebugLocation(106, 22);
					PushFollow(Follow._boolgroup_in_and932);
					boolgroup82=boolgroup();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup82.Tree);

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
		DebugLocation(106, 32);
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
	// MathLang.g:107:1: boolgroup : ( NOT )? ( '(' boolterm ')' | boolvar ) ;
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

		IToken NOT83=null;
		IToken char_literal84=null;
		IToken char_literal86=null;
		MathLangParser.boolterm_return boolterm85 = default(MathLangParser.boolterm_return);
		MathLangParser.boolvar_return boolvar87 = default(MathLangParser.boolvar_return);

		object NOT83_tree=null;
		object char_literal84_tree=null;
		object char_literal86_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolgroup");
		DebugLocation(107, 51);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 25)) { return retval; }
			// MathLang.g:107:10: ( ( NOT )? ( '(' boolterm ')' | boolvar ) )
			DebugEnterAlt(1);
			// MathLang.g:107:12: ( NOT )? ( '(' boolterm ')' | boolvar )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(107, 12);
			// MathLang.g:107:12: ( NOT )?
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
				// MathLang.g:107:13: NOT
				{
				DebugLocation(107, 16);
				NOT83=(IToken)Match(input,NOT,Follow._NOT_in_boolgroup941); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				NOT83_tree = (object)adaptor.Create(NOT83);
				root_0 = (object)adaptor.BecomeRoot(NOT83_tree, root_0);
				}

				}
				break;

			}
			} finally { DebugExitSubRule(17); }

			DebugLocation(107, 20);
			// MathLang.g:107:20: ( '(' boolterm ')' | boolvar )
			int alt18=2;
			try { DebugEnterSubRule(18);
			try { DebugEnterDecision(18, decisionCanBacktrack[18]);
			int LA18_0 = input.LA(1);

			if ((LA18_0==58))
			{
				int LA18_1 = input.LA(2);

				if ((EvaluatePredicate(synpred40_MathLang_fragment)))
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
				// MathLang.g:107:22: '(' boolterm ')'
				{
				DebugLocation(107, 25);
				char_literal84=(IToken)Match(input,58,Follow._58_in_boolgroup948); if (state.failed) return retval;
				DebugLocation(107, 27);
				PushFollow(Follow._boolterm_in_boolgroup951);
				boolterm85=boolterm();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm85.Tree);
				DebugLocation(107, 39);
				char_literal86=(IToken)Match(input,59,Follow._59_in_boolgroup953); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:107:43: boolvar
				{
				DebugLocation(107, 43);
				PushFollow(Follow._boolvar_in_boolgroup958);
				boolvar87=boolvar();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolvar87.Tree);

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
		DebugLocation(107, 51);
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
	// MathLang.g:108:1: boolvar : ( TRUE | FALSE | compare );
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

		IToken TRUE88=null;
		IToken FALSE89=null;
		MathLangParser.compare_return compare90 = default(MathLangParser.compare_return);

		object TRUE88_tree=null;
		object FALSE89_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolvar");
		DebugLocation(108, 11);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 26)) { return retval; }
			// MathLang.g:108:8: ( TRUE | FALSE | compare )
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
			case 58:
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
				// MathLang.g:108:10: TRUE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(108, 10);
				TRUE88=(IToken)Match(input,TRUE,Follow._TRUE_in_boolvar966); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				TRUE88_tree = (object)adaptor.Create(TRUE88);
				adaptor.AddChild(root_0, TRUE88_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:109:5: FALSE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(109, 5);
				FALSE89=(IToken)Match(input,FALSE,Follow._FALSE_in_boolvar972); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				FALSE89_tree = (object)adaptor.Create(FALSE89);
				adaptor.AddChild(root_0, FALSE89_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:110:5: compare
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(110, 5);
				PushFollow(Follow._compare_in_boolvar978);
				compare90=compare();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare90.Tree);

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
		DebugLocation(110, 11);
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
	// MathLang.g:112:1: ifstatement : IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )* ;
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

		IToken IF91=null;
		IToken char_literal92=null;
		IToken char_literal94=null;
		IToken ELSE97=null;
		MathLangParser.boolexpression_return boolexpression93 = default(MathLangParser.boolexpression_return);
		MathLangParser.block_return block95 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement96 = default(MathLangParser.statement_return);
		MathLangParser.block_return block98 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement99 = default(MathLangParser.statement_return);

		object IF91_tree=null;
		object char_literal92_tree=null;
		object char_literal94_tree=null;
		object ELSE97_tree=null;

		try { DebugEnterRule(GrammarFileName, "ifstatement");
		DebugLocation(112, 91);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 27)) { return retval; }
			// MathLang.g:112:12: ( IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )* )
			DebugEnterAlt(1);
			// MathLang.g:112:14: IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(112, 16);
			IF91=(IToken)Match(input,IF,Follow._IF_in_ifstatement985); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			IF91_tree = (object)adaptor.Create(IF91);
			root_0 = (object)adaptor.BecomeRoot(IF91_tree, root_0);
			}
			DebugLocation(112, 21);
			char_literal92=(IToken)Match(input,58,Follow._58_in_ifstatement988); if (state.failed) return retval;
			DebugLocation(112, 23);
			PushFollow(Follow._boolexpression_in_ifstatement991);
			boolexpression93=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression93.Tree);
			DebugLocation(112, 41);
			char_literal94=(IToken)Match(input,59,Follow._59_in_ifstatement993); if (state.failed) return retval;
			DebugLocation(112, 43);
			// MathLang.g:112:43: ( block | statement )
			int alt20=2;
			try { DebugEnterSubRule(20);
			try { DebugEnterDecision(20, decisionCanBacktrack[20]);
			int LA20_0 = input.LA(1);

			if ((LA20_0==61))
			{
				alt20=1;
			}
			else if ((LA20_0==IF||LA20_0==FOR||(LA20_0>=RETURN && LA20_0<=DO)||LA20_0==TYPE||LA20_0==VOID||LA20_0==ID||LA20_0==KNEW))
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
				// MathLang.g:112:44: block
				{
				DebugLocation(112, 44);
				PushFollow(Follow._block_in_ifstatement997);
				block95=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block95.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:112:52: statement
				{
				DebugLocation(112, 52);
				PushFollow(Follow._statement_in_ifstatement1001);
				statement96=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement96.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(20); }

			DebugLocation(112, 63);
			// MathLang.g:112:63: ( ELSE ( block | statement ) )*
			try { DebugEnterSubRule(22);
			while (true)
			{
				int alt22=2;
				try { DebugEnterDecision(22, decisionCanBacktrack[22]);
				int LA22_0 = input.LA(1);

				if ((LA22_0==ELSE))
				{
					int LA22_1 = input.LA(2);

					if ((EvaluatePredicate(synpred45_MathLang_fragment)))
					{
						alt22=1;
					}


				}


				} finally { DebugExitDecision(22); }
				switch ( alt22 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:112:64: ELSE ( block | statement )
					{
					DebugLocation(112, 68);
					ELSE97=(IToken)Match(input,ELSE,Follow._ELSE_in_ifstatement1005); if (state.failed) return retval;
					DebugLocation(112, 70);
					// MathLang.g:112:70: ( block | statement )
					int alt21=2;
					try { DebugEnterSubRule(21);
					try { DebugEnterDecision(21, decisionCanBacktrack[21]);
					int LA21_0 = input.LA(1);

					if ((LA21_0==61))
					{
						alt21=1;
					}
					else if ((LA21_0==IF||LA21_0==FOR||(LA21_0>=RETURN && LA21_0<=DO)||LA21_0==TYPE||LA21_0==VOID||LA21_0==ID||LA21_0==KNEW))
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
						// MathLang.g:112:71: block
						{
						DebugLocation(112, 71);
						PushFollow(Follow._block_in_ifstatement1009);
						block98=block();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block98.Tree);

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// MathLang.g:112:79: statement
						{
						DebugLocation(112, 79);
						PushFollow(Follow._statement_in_ifstatement1013);
						statement99=statement();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement99.Tree);

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
		DebugLocation(112, 91);
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
	// MathLang.g:113:1: whilestatement : WHILE '(' boolexpression ')' ( block | statement ) ;
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

		IToken WHILE100=null;
		IToken char_literal101=null;
		IToken char_literal103=null;
		MathLangParser.boolexpression_return boolexpression102 = default(MathLangParser.boolexpression_return);
		MathLangParser.block_return block104 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement105 = default(MathLangParser.statement_return);

		object WHILE100_tree=null;
		object char_literal101_tree=null;
		object char_literal103_tree=null;

		try { DebugEnterRule(GrammarFileName, "whilestatement");
		DebugLocation(113, 67);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 28)) { return retval; }
			// MathLang.g:113:15: ( WHILE '(' boolexpression ')' ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:113:17: WHILE '(' boolexpression ')' ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(113, 22);
			WHILE100=(IToken)Match(input,WHILE,Follow._WHILE_in_whilestatement1023); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			WHILE100_tree = (object)adaptor.Create(WHILE100);
			root_0 = (object)adaptor.BecomeRoot(WHILE100_tree, root_0);
			}
			DebugLocation(113, 27);
			char_literal101=(IToken)Match(input,58,Follow._58_in_whilestatement1026); if (state.failed) return retval;
			DebugLocation(113, 29);
			PushFollow(Follow._boolexpression_in_whilestatement1029);
			boolexpression102=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression102.Tree);
			DebugLocation(113, 47);
			char_literal103=(IToken)Match(input,59,Follow._59_in_whilestatement1031); if (state.failed) return retval;
			DebugLocation(113, 49);
			// MathLang.g:113:49: ( block | statement )
			int alt23=2;
			try { DebugEnterSubRule(23);
			try { DebugEnterDecision(23, decisionCanBacktrack[23]);
			int LA23_0 = input.LA(1);

			if ((LA23_0==61))
			{
				alt23=1;
			}
			else if ((LA23_0==IF||LA23_0==FOR||(LA23_0>=RETURN && LA23_0<=DO)||LA23_0==TYPE||LA23_0==VOID||LA23_0==ID||LA23_0==KNEW))
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
				// MathLang.g:113:50: block
				{
				DebugLocation(113, 50);
				PushFollow(Follow._block_in_whilestatement1035);
				block104=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block104.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:113:58: statement
				{
				DebugLocation(113, 58);
				PushFollow(Follow._statement_in_whilestatement1039);
				statement105=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement105.Tree);

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
		DebugLocation(113, 67);
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
	// MathLang.g:114:1: forstatement : FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement ) ;
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

		IToken FOR106=null;
		IToken char_literal107=null;
		IToken char_literal109=null;
		IToken char_literal111=null;
		IToken char_literal113=null;
		MathLangParser.longdeclarationbody_return longdeclarationbody108 = default(MathLangParser.longdeclarationbody_return);
		MathLangParser.boolexpression_return boolexpression110 = default(MathLangParser.boolexpression_return);
		MathLangParser.assignmentbody_return assignmentbody112 = default(MathLangParser.assignmentbody_return);
		MathLangParser.block_return block114 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement115 = default(MathLangParser.statement_return);

		object FOR106_tree=null;
		object char_literal107_tree=null;
		object char_literal109_tree=null;
		object char_literal111_tree=null;
		object char_literal113_tree=null;

		try { DebugEnterRule(GrammarFileName, "forstatement");
		DebugLocation(114, 108);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 29)) { return retval; }
			// MathLang.g:114:13: ( FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:114:15: FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(114, 18);
			FOR106=(IToken)Match(input,FOR,Follow._FOR_in_forstatement1046); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			FOR106_tree = (object)adaptor.Create(FOR106);
			root_0 = (object)adaptor.BecomeRoot(FOR106_tree, root_0);
			}
			DebugLocation(114, 23);
			char_literal107=(IToken)Match(input,58,Follow._58_in_forstatement1049); if (state.failed) return retval;
			DebugLocation(114, 25);
			PushFollow(Follow._longdeclarationbody_in_forstatement1052);
			longdeclarationbody108=longdeclarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclarationbody108.Tree);
			DebugLocation(114, 48);
			char_literal109=(IToken)Match(input,57,Follow._57_in_forstatement1054); if (state.failed) return retval;
			DebugLocation(114, 50);
			PushFollow(Follow._boolexpression_in_forstatement1057);
			boolexpression110=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression110.Tree);
			DebugLocation(114, 68);
			char_literal111=(IToken)Match(input,57,Follow._57_in_forstatement1059); if (state.failed) return retval;
			DebugLocation(114, 70);
			PushFollow(Follow._assignmentbody_in_forstatement1062);
			assignmentbody112=assignmentbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentbody112.Tree);
			DebugLocation(114, 88);
			char_literal113=(IToken)Match(input,59,Follow._59_in_forstatement1064); if (state.failed) return retval;
			DebugLocation(114, 90);
			// MathLang.g:114:90: ( block | statement )
			int alt24=2;
			try { DebugEnterSubRule(24);
			try { DebugEnterDecision(24, decisionCanBacktrack[24]);
			int LA24_0 = input.LA(1);

			if ((LA24_0==61))
			{
				alt24=1;
			}
			else if ((LA24_0==IF||LA24_0==FOR||(LA24_0>=RETURN && LA24_0<=DO)||LA24_0==TYPE||LA24_0==VOID||LA24_0==ID||LA24_0==KNEW))
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
				// MathLang.g:114:91: block
				{
				DebugLocation(114, 91);
				PushFollow(Follow._block_in_forstatement1068);
				block114=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block114.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:114:99: statement
				{
				DebugLocation(114, 99);
				PushFollow(Follow._statement_in_forstatement1072);
				statement115=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement115.Tree);

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
		DebugLocation(114, 108);
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
	// MathLang.g:115:1: returnstatement : RETURN expression ';' ;
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

		IToken RETURN116=null;
		IToken char_literal118=null;
		MathLangParser.expression_return expression117 = default(MathLangParser.expression_return);

		object RETURN116_tree=null;
		object char_literal118_tree=null;

		try { DebugEnterRule(GrammarFileName, "returnstatement");
		DebugLocation(115, 41);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 30)) { return retval; }
			// MathLang.g:115:16: ( RETURN expression ';' )
			DebugEnterAlt(1);
			// MathLang.g:115:18: RETURN expression ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(115, 24);
			RETURN116=(IToken)Match(input,RETURN,Follow._RETURN_in_returnstatement1079); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			RETURN116_tree = (object)adaptor.Create(RETURN116);
			root_0 = (object)adaptor.BecomeRoot(RETURN116_tree, root_0);
			}
			DebugLocation(115, 26);
			PushFollow(Follow._expression_in_returnstatement1082);
			expression117=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression117.Tree);
			DebugLocation(115, 40);
			char_literal118=(IToken)Match(input,57,Follow._57_in_returnstatement1084); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(115, 41);
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
	// MathLang.g:116:1: dowhilestatement : DO ( block | statement ) WHILE '(' boolexpression ')' ';' ;
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

		IToken DO119=null;
		IToken WHILE122=null;
		IToken char_literal123=null;
		IToken char_literal125=null;
		IToken char_literal126=null;
		MathLangParser.block_return block120 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement121 = default(MathLangParser.statement_return);
		MathLangParser.boolexpression_return boolexpression124 = default(MathLangParser.boolexpression_return);

		object DO119_tree=null;
		object WHILE122_tree=null;
		object char_literal123_tree=null;
		object char_literal125_tree=null;
		object char_literal126_tree=null;

		try { DebugEnterRule(GrammarFileName, "dowhilestatement");
		DebugLocation(116, 79);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 31)) { return retval; }
			// MathLang.g:116:17: ( DO ( block | statement ) WHILE '(' boolexpression ')' ';' )
			DebugEnterAlt(1);
			// MathLang.g:116:19: DO ( block | statement ) WHILE '(' boolexpression ')' ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(116, 21);
			DO119=(IToken)Match(input,DO,Follow._DO_in_dowhilestatement1092); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			DO119_tree = (object)adaptor.Create(DO119);
			root_0 = (object)adaptor.BecomeRoot(DO119_tree, root_0);
			}
			DebugLocation(116, 23);
			// MathLang.g:116:23: ( block | statement )
			int alt25=2;
			try { DebugEnterSubRule(25);
			try { DebugEnterDecision(25, decisionCanBacktrack[25]);
			int LA25_0 = input.LA(1);

			if ((LA25_0==61))
			{
				alt25=1;
			}
			else if ((LA25_0==IF||LA25_0==FOR||(LA25_0>=RETURN && LA25_0<=DO)||LA25_0==TYPE||LA25_0==VOID||LA25_0==ID||LA25_0==KNEW))
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
				// MathLang.g:116:24: block
				{
				DebugLocation(116, 24);
				PushFollow(Follow._block_in_dowhilestatement1096);
				block120=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block120.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:116:32: statement
				{
				DebugLocation(116, 32);
				PushFollow(Follow._statement_in_dowhilestatement1100);
				statement121=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement121.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(25); }

			DebugLocation(116, 48);
			WHILE122=(IToken)Match(input,WHILE,Follow._WHILE_in_dowhilestatement1103); if (state.failed) return retval;
			DebugLocation(116, 53);
			char_literal123=(IToken)Match(input,58,Follow._58_in_dowhilestatement1106); if (state.failed) return retval;
			DebugLocation(116, 55);
			PushFollow(Follow._boolexpression_in_dowhilestatement1109);
			boolexpression124=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression124.Tree);
			DebugLocation(116, 73);
			char_literal125=(IToken)Match(input,59,Follow._59_in_dowhilestatement1111); if (state.failed) return retval;
			DebugLocation(116, 78);
			char_literal126=(IToken)Match(input,57,Follow._57_in_dowhilestatement1114); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(116, 79);
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
	// MathLang.g:118:1: funcdeclaration : any_type ID '(' ( paramsdeclaration )? ')' block -> ^( FUNCDECLARATION ID ^( RETURN_TYPE any_type ) ( paramsdeclaration )? block ) ;
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

		IToken ID128=null;
		IToken char_literal129=null;
		IToken char_literal131=null;
		MathLangParser.any_type_return any_type127 = default(MathLangParser.any_type_return);
		MathLangParser.paramsdeclaration_return paramsdeclaration130 = default(MathLangParser.paramsdeclaration_return);
		MathLangParser.block_return block132 = default(MathLangParser.block_return);

		object ID128_tree=null;
		object char_literal129_tree=null;
		object char_literal131_tree=null;
		RewriteRuleITokenStream stream_59=new RewriteRuleITokenStream(adaptor,"token 59");
		RewriteRuleITokenStream stream_58=new RewriteRuleITokenStream(adaptor,"token 58");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleSubtreeStream stream_paramsdeclaration=new RewriteRuleSubtreeStream(adaptor,"rule paramsdeclaration");
		RewriteRuleSubtreeStream stream_block=new RewriteRuleSubtreeStream(adaptor,"rule block");
		RewriteRuleSubtreeStream stream_any_type=new RewriteRuleSubtreeStream(adaptor,"rule any_type");
		try { DebugEnterRule(GrammarFileName, "funcdeclaration");
		DebugLocation(118, 148);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 32)) { return retval; }
			// MathLang.g:118:16: ( any_type ID '(' ( paramsdeclaration )? ')' block -> ^( FUNCDECLARATION ID ^( RETURN_TYPE any_type ) ( paramsdeclaration )? block ) )
			DebugEnterAlt(1);
			// MathLang.g:118:18: any_type ID '(' ( paramsdeclaration )? ')' block
			{
			DebugLocation(118, 18);
			PushFollow(Follow._any_type_in_funcdeclaration1123);
			any_type127=any_type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_any_type.Add(any_type127.Tree);
			DebugLocation(118, 29);
			ID128=(IToken)Match(input,ID,Follow._ID_in_funcdeclaration1125); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID128);

			DebugLocation(118, 34);
			char_literal129=(IToken)Match(input,58,Follow._58_in_funcdeclaration1128); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_58.Add(char_literal129);

			DebugLocation(118, 36);
			// MathLang.g:118:36: ( paramsdeclaration )?
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
				DebugLocation(118, 36);
				PushFollow(Follow._paramsdeclaration_in_funcdeclaration1131);
				paramsdeclaration130=paramsdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_paramsdeclaration.Add(paramsdeclaration130.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(26); }

			DebugLocation(118, 58);
			char_literal131=(IToken)Match(input,59,Follow._59_in_funcdeclaration1134); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_59.Add(char_literal131);

			DebugLocation(118, 60);
			PushFollow(Follow._block_in_funcdeclaration1137);
			block132=block();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_block.Add(block132.Tree);


			{
			// AST REWRITE
			// elements: block, any_type, ID, paramsdeclaration
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 118:66: -> ^( FUNCDECLARATION ID ^( RETURN_TYPE any_type ) ( paramsdeclaration )? block )
			{
				DebugLocation(118, 69);
				// MathLang.g:118:69: ^( FUNCDECLARATION ID ^( RETURN_TYPE any_type ) ( paramsdeclaration )? block )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(118, 71);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNCDECLARATION, "FUNCDECLARATION"), root_1);

				DebugLocation(118, 87);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(118, 90);
				// MathLang.g:118:90: ^( RETURN_TYPE any_type )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(118, 92);
				root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(RETURN_TYPE, "RETURN_TYPE"), root_2);

				DebugLocation(118, 104);
				adaptor.AddChild(root_2, stream_any_type.NextTree());

				adaptor.AddChild(root_1, root_2);
				}
				DebugLocation(118, 119);
				// MathLang.g:118:119: ( paramsdeclaration )?
				if ( stream_paramsdeclaration.HasNext )
				{
					DebugLocation(118, 119);
					adaptor.AddChild(root_1, stream_paramsdeclaration.NextTree());

				}
				stream_paramsdeclaration.Reset();
				DebugLocation(118, 143);
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
		DebugLocation(118, 148);
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
	// MathLang.g:119:1: paramsdeclaration : ( declarationbody ( ',' declarationbody )* ) -> ^( PARAMETERS ( declarationbody )* ) ;
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

		IToken char_literal134=null;
		MathLangParser.declarationbody_return declarationbody133 = default(MathLangParser.declarationbody_return);
		MathLangParser.declarationbody_return declarationbody135 = default(MathLangParser.declarationbody_return);

		object char_literal134_tree=null;
		RewriteRuleITokenStream stream_60=new RewriteRuleITokenStream(adaptor,"token 60");
		RewriteRuleSubtreeStream stream_declarationbody=new RewriteRuleSubtreeStream(adaptor,"rule declarationbody");
		try { DebugEnterRule(GrammarFileName, "paramsdeclaration");
		DebugLocation(119, 102);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 33)) { return retval; }
			// MathLang.g:119:18: ( ( declarationbody ( ',' declarationbody )* ) -> ^( PARAMETERS ( declarationbody )* ) )
			DebugEnterAlt(1);
			// MathLang.g:119:20: ( declarationbody ( ',' declarationbody )* )
			{
			DebugLocation(119, 20);
			// MathLang.g:119:20: ( declarationbody ( ',' declarationbody )* )
			DebugEnterAlt(1);
			// MathLang.g:119:22: declarationbody ( ',' declarationbody )*
			{
			DebugLocation(119, 22);
			PushFollow(Follow._declarationbody_in_paramsdeclaration1170);
			declarationbody133=declarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declarationbody.Add(declarationbody133.Tree);
			DebugLocation(119, 38);
			// MathLang.g:119:38: ( ',' declarationbody )*
			try { DebugEnterSubRule(27);
			while (true)
			{
				int alt27=2;
				try { DebugEnterDecision(27, decisionCanBacktrack[27]);
				int LA27_0 = input.LA(1);

				if ((LA27_0==60))
				{
					alt27=1;
				}


				} finally { DebugExitDecision(27); }
				switch ( alt27 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:119:40: ',' declarationbody
					{
					DebugLocation(119, 43);
					char_literal134=(IToken)Match(input,60,Follow._60_in_paramsdeclaration1174); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_60.Add(char_literal134);

					DebugLocation(119, 45);
					PushFollow(Follow._declarationbody_in_paramsdeclaration1177);
					declarationbody135=declarationbody();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_declarationbody.Add(declarationbody135.Tree);

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
			// 119:66: -> ^( PARAMETERS ( declarationbody )* )
			{
				DebugLocation(119, 69);
				// MathLang.g:119:69: ^( PARAMETERS ( declarationbody )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(119, 71);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_1);

				DebugLocation(119, 82);
				// MathLang.g:119:82: ( declarationbody )*
				while ( stream_declarationbody.HasNext )
				{
					DebugLocation(119, 84);
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
		DebugLocation(119, 102);
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
	// MathLang.g:121:1: funccallbody : ID '(' ( expressioncommalist )? ')' -> ^( FUNC_CALL ^( ID ( ^( PARAMETERS expressioncommalist ) )? ) ) ;
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

		IToken ID136=null;
		IToken char_literal137=null;
		IToken char_literal139=null;
		MathLangParser.expressioncommalist_return expressioncommalist138 = default(MathLangParser.expressioncommalist_return);

		object ID136_tree=null;
		object char_literal137_tree=null;
		object char_literal139_tree=null;
		RewriteRuleITokenStream stream_59=new RewriteRuleITokenStream(adaptor,"token 59");
		RewriteRuleITokenStream stream_58=new RewriteRuleITokenStream(adaptor,"token 58");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleSubtreeStream stream_expressioncommalist=new RewriteRuleSubtreeStream(adaptor,"rule expressioncommalist");
		try { DebugEnterRule(GrammarFileName, "funccallbody");
		DebugLocation(121, 103);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 34)) { return retval; }
			// MathLang.g:121:13: ( ID '(' ( expressioncommalist )? ')' -> ^( FUNC_CALL ^( ID ( ^( PARAMETERS expressioncommalist ) )? ) ) )
			DebugEnterAlt(1);
			// MathLang.g:121:15: ID '(' ( expressioncommalist )? ')'
			{
			DebugLocation(121, 17);
			ID136=(IToken)Match(input,ID,Follow._ID_in_funccallbody1202); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID136);

			DebugLocation(121, 19);
			char_literal137=(IToken)Match(input,58,Follow._58_in_funccallbody1205); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_58.Add(char_literal137);

			DebugLocation(121, 23);
			// MathLang.g:121:23: ( expressioncommalist )?
			int alt28=2;
			try { DebugEnterSubRule(28);
			try { DebugEnterDecision(28, decisionCanBacktrack[28]);
			int LA28_0 = input.LA(1);

			if (((LA28_0>=NUMBER && LA28_0<=CHAR)||LA28_0==SUB||(LA28_0>=NOT && LA28_0<=KNEW)||LA28_0==58))
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
				DebugLocation(121, 23);
				PushFollow(Follow._expressioncommalist_in_funccallbody1207);
				expressioncommalist138=expressioncommalist();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expressioncommalist.Add(expressioncommalist138.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(28); }

			DebugLocation(121, 44);
			char_literal139=(IToken)Match(input,59,Follow._59_in_funccallbody1210); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_59.Add(char_literal139);



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
			// 121:48: -> ^( FUNC_CALL ^( ID ( ^( PARAMETERS expressioncommalist ) )? ) )
			{
				DebugLocation(121, 51);
				// MathLang.g:121:51: ^( FUNC_CALL ^( ID ( ^( PARAMETERS expressioncommalist ) )? ) )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(121, 53);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_CALL, "FUNC_CALL"), root_1);

				DebugLocation(121, 63);
				// MathLang.g:121:63: ^( ID ( ^( PARAMETERS expressioncommalist ) )? )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(121, 65);
				root_2 = (object)adaptor.BecomeRoot(stream_ID.NextNode(), root_2);

				DebugLocation(121, 68);
				// MathLang.g:121:68: ( ^( PARAMETERS expressioncommalist ) )?
				if ( stream_expressioncommalist.HasNext )
				{
					DebugLocation(121, 68);
					// MathLang.g:121:68: ^( PARAMETERS expressioncommalist )
					{
					object root_3 = (object)adaptor.Nil();
					DebugLocation(121, 70);
					root_3 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_3);

					DebugLocation(121, 81);
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
		DebugLocation(121, 103);
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
	// MathLang.g:122:1: funccall : funccallbody ';' ;
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

		IToken char_literal141=null;
		MathLangParser.funccallbody_return funccallbody140 = default(MathLangParser.funccallbody_return);

		object char_literal141_tree=null;

		try { DebugEnterRule(GrammarFileName, "funccall");
		DebugLocation(122, 27);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 35)) { return retval; }
			// MathLang.g:122:9: ( funccallbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:122:11: funccallbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(122, 11);
			PushFollow(Follow._funccallbody_in_funccall1233);
			funccallbody140=funccallbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody140.Tree);
			DebugLocation(122, 27);
			char_literal141=(IToken)Match(input,57,Follow._57_in_funccall1235); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(122, 27);
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
	// MathLang.g:123:1: expressioncommalist : expression ( ',' expression )* ;
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

		IToken char_literal143=null;
		MathLangParser.expression_return expression142 = default(MathLangParser.expression_return);
		MathLangParser.expression_return expression144 = default(MathLangParser.expression_return);

		object char_literal143_tree=null;

		try { DebugEnterRule(GrammarFileName, "expressioncommalist");
		DebugLocation(123, 51);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 36)) { return retval; }
			// MathLang.g:123:20: ( expression ( ',' expression )* )
			DebugEnterAlt(1);
			// MathLang.g:123:22: expression ( ',' expression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(123, 22);
			PushFollow(Follow._expression_in_expressioncommalist1242);
			expression142=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression142.Tree);
			DebugLocation(123, 33);
			// MathLang.g:123:33: ( ',' expression )*
			try { DebugEnterSubRule(29);
			while (true)
			{
				int alt29=2;
				try { DebugEnterDecision(29, decisionCanBacktrack[29]);
				int LA29_0 = input.LA(1);

				if ((LA29_0==60))
				{
					alt29=1;
				}


				} finally { DebugExitDecision(29); }
				switch ( alt29 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:123:35: ',' expression
					{
					DebugLocation(123, 38);
					char_literal143=(IToken)Match(input,60,Follow._60_in_expressioncommalist1246); if (state.failed) return retval;
					DebugLocation(123, 40);
					PushFollow(Follow._expression_in_expressioncommalist1249);
					expression144=expression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression144.Tree);

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
		DebugLocation(123, 51);
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
	// MathLang.g:126:1: object_initializer : '{' expressioncommalist '}' -> ^( PARAMETERS expressioncommalist ) ;
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

		IToken char_literal145=null;
		IToken char_literal147=null;
		MathLangParser.expressioncommalist_return expressioncommalist146 = default(MathLangParser.expressioncommalist_return);

		object char_literal145_tree=null;
		object char_literal147_tree=null;
		RewriteRuleITokenStream stream_62=new RewriteRuleITokenStream(adaptor,"token 62");
		RewriteRuleITokenStream stream_61=new RewriteRuleITokenStream(adaptor,"token 61");
		RewriteRuleSubtreeStream stream_expressioncommalist=new RewriteRuleSubtreeStream(adaptor,"rule expressioncommalist");
		try { DebugEnterRule(GrammarFileName, "object_initializer");
		DebugLocation(126, 86);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 37)) { return retval; }
			// MathLang.g:126:19: ( '{' expressioncommalist '}' -> ^( PARAMETERS expressioncommalist ) )
			DebugEnterAlt(1);
			// MathLang.g:126:22: '{' expressioncommalist '}'
			{
			DebugLocation(126, 22);
			char_literal145=(IToken)Match(input,61,Follow._61_in_object_initializer1261); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_61.Add(char_literal145);

			DebugLocation(126, 26);
			PushFollow(Follow._expressioncommalist_in_object_initializer1263);
			expressioncommalist146=expressioncommalist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expressioncommalist.Add(expressioncommalist146.Tree);
			DebugLocation(126, 46);
			char_literal147=(IToken)Match(input,62,Follow._62_in_object_initializer1265); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_62.Add(char_literal147);



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
			// 126:50: -> ^( PARAMETERS expressioncommalist )
			{
				DebugLocation(126, 53);
				// MathLang.g:126:53: ^( PARAMETERS expressioncommalist )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(126, 55);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_1);

				DebugLocation(126, 66);
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
		DebugLocation(126, 86);
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
	// MathLang.g:127:1: newexpression : KNEW initializer ;
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

		IToken KNEW148=null;
		MathLangParser.initializer_return initializer149 = default(MathLangParser.initializer_return);

		object KNEW148_tree=null;

		try { DebugEnterRule(GrammarFileName, "newexpression");
		DebugLocation(127, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 38)) { return retval; }
			// MathLang.g:127:14: ( KNEW initializer )
			DebugEnterAlt(1);
			// MathLang.g:127:16: KNEW initializer
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(127, 20);
			KNEW148=(IToken)Match(input,KNEW,Follow._KNEW_in_newexpression1280); if (state.failed) return retval;
			DebugLocation(127, 22);
			PushFollow(Follow._initializer_in_newexpression1283);
			initializer149=initializer();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, initializer149.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(127, 32);
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
	// MathLang.g:128:1: initializer : ( simple_var_initializer | array_initializer ) ;
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

		MathLangParser.simple_var_initializer_return simple_var_initializer150 = default(MathLangParser.simple_var_initializer_return);
		MathLangParser.array_initializer_return array_initializer151 = default(MathLangParser.array_initializer_return);


		try { DebugEnterRule(GrammarFileName, "initializer");
		DebugLocation(128, 57);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 39)) { return retval; }
			// MathLang.g:128:12: ( ( simple_var_initializer | array_initializer ) )
			DebugEnterAlt(1);
			// MathLang.g:128:14: ( simple_var_initializer | array_initializer )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(128, 14);
			// MathLang.g:128:14: ( simple_var_initializer | array_initializer )
			int alt30=2;
			try { DebugEnterSubRule(30);
			try { DebugEnterDecision(30, decisionCanBacktrack[30]);
			int LA30_0 = input.LA(1);

			if ((LA30_0==TYPE))
			{
				int LA30_1 = input.LA(2);

				if ((LA30_1==58))
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
				// MathLang.g:128:15: simple_var_initializer
				{
				DebugLocation(128, 15);
				PushFollow(Follow._simple_var_initializer_in_initializer1290);
				simple_var_initializer150=simple_var_initializer();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, simple_var_initializer150.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:128:40: array_initializer
				{
				DebugLocation(128, 40);
				PushFollow(Follow._array_initializer_in_initializer1294);
				array_initializer151=array_initializer();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, array_initializer151.Tree);

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
		DebugLocation(128, 57);
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
	// MathLang.g:129:1: simple_var_initializer : type '(' ')' -> ^( NEWVAR type ) ;
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

		IToken char_literal153=null;
		IToken char_literal154=null;
		MathLangParser.type_return type152 = default(MathLangParser.type_return);

		object char_literal153_tree=null;
		object char_literal154_tree=null;
		RewriteRuleITokenStream stream_59=new RewriteRuleITokenStream(adaptor,"token 59");
		RewriteRuleITokenStream stream_58=new RewriteRuleITokenStream(adaptor,"token 58");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "simple_var_initializer");
		DebugLocation(129, 54);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 40)) { return retval; }
			// MathLang.g:129:23: ( type '(' ')' -> ^( NEWVAR type ) )
			DebugEnterAlt(1);
			// MathLang.g:129:25: type '(' ')'
			{
			DebugLocation(129, 25);
			PushFollow(Follow._type_in_simple_var_initializer1301);
			type152=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type152.Tree);
			DebugLocation(129, 30);
			char_literal153=(IToken)Match(input,58,Follow._58_in_simple_var_initializer1303); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_58.Add(char_literal153);

			DebugLocation(129, 34);
			char_literal154=(IToken)Match(input,59,Follow._59_in_simple_var_initializer1305); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_59.Add(char_literal154);



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
			// 129:38: -> ^( NEWVAR type )
			{
				DebugLocation(129, 41);
				// MathLang.g:129:41: ^( NEWVAR type )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(129, 43);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(NEWVAR, "NEWVAR"), root_1);

				DebugLocation(129, 50);
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
		DebugLocation(129, 54);
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
	// MathLang.g:130:1: array_initializer : type ( ( '[' number ']' ) | ARRAY_DECLARATION_MARK ) ( object_initializer )? -> ^( ARRAY_INITIALIZER type ( number )? ( object_initializer )? ) ;
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

		IToken char_literal156=null;
		IToken char_literal158=null;
		IToken ARRAY_DECLARATION_MARK159=null;
		MathLangParser.type_return type155 = default(MathLangParser.type_return);
		MathLangParser.number_return number157 = default(MathLangParser.number_return);
		MathLangParser.object_initializer_return object_initializer160 = default(MathLangParser.object_initializer_return);

		object char_literal156_tree=null;
		object char_literal158_tree=null;
		object ARRAY_DECLARATION_MARK159_tree=null;
		RewriteRuleITokenStream stream_ARRAY_DECLARATION_MARK=new RewriteRuleITokenStream(adaptor,"token ARRAY_DECLARATION_MARK");
		RewriteRuleITokenStream stream_SQRBR=new RewriteRuleITokenStream(adaptor,"token SQRBR");
		RewriteRuleITokenStream stream_SQRBL=new RewriteRuleITokenStream(adaptor,"token SQRBL");
		RewriteRuleSubtreeStream stream_number=new RewriteRuleSubtreeStream(adaptor,"rule number");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		RewriteRuleSubtreeStream stream_object_initializer=new RewriteRuleSubtreeStream(adaptor,"rule object_initializer");
		try { DebugEnterRule(GrammarFileName, "array_initializer");
		DebugLocation(130, 144);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 41)) { return retval; }
			// MathLang.g:130:18: ( type ( ( '[' number ']' ) | ARRAY_DECLARATION_MARK ) ( object_initializer )? -> ^( ARRAY_INITIALIZER type ( number )? ( object_initializer )? ) )
			DebugEnterAlt(1);
			// MathLang.g:130:20: type ( ( '[' number ']' ) | ARRAY_DECLARATION_MARK ) ( object_initializer )?
			{
			DebugLocation(130, 20);
			PushFollow(Follow._type_in_array_initializer1319);
			type155=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type155.Tree);
			DebugLocation(130, 25);
			// MathLang.g:130:25: ( ( '[' number ']' ) | ARRAY_DECLARATION_MARK )
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
				// MathLang.g:130:26: ( '[' number ']' )
				{
				DebugLocation(130, 26);
				// MathLang.g:130:26: ( '[' number ']' )
				DebugEnterAlt(1);
				// MathLang.g:130:27: '[' number ']'
				{
				DebugLocation(130, 27);
				char_literal156=(IToken)Match(input,SQRBL,Follow._SQRBL_in_array_initializer1323); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_SQRBL.Add(char_literal156);

				DebugLocation(130, 31);
				PushFollow(Follow._number_in_array_initializer1325);
				number157=number();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_number.Add(number157.Tree);
				DebugLocation(130, 38);
				char_literal158=(IToken)Match(input,SQRBR,Follow._SQRBR_in_array_initializer1327); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_SQRBR.Add(char_literal158);


				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:130:45: ARRAY_DECLARATION_MARK
				{
				DebugLocation(130, 45);
				ARRAY_DECLARATION_MARK159=(IToken)Match(input,ARRAY_DECLARATION_MARK,Follow._ARRAY_DECLARATION_MARK_in_array_initializer1332); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ARRAY_DECLARATION_MARK.Add(ARRAY_DECLARATION_MARK159);


				}
				break;

			}
			} finally { DebugExitSubRule(31); }

			DebugLocation(130, 69);
			// MathLang.g:130:69: ( object_initializer )?
			int alt32=2;
			try { DebugEnterSubRule(32);
			try { DebugEnterDecision(32, decisionCanBacktrack[32]);
			int LA32_0 = input.LA(1);

			if ((LA32_0==61))
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
				DebugLocation(130, 69);
				PushFollow(Follow._object_initializer_in_array_initializer1335);
				object_initializer160=object_initializer();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_object_initializer.Add(object_initializer160.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(32); }



			{
			// AST REWRITE
			// elements: type, object_initializer, number
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 130:89: -> ^( ARRAY_INITIALIZER type ( number )? ( object_initializer )? )
			{
				DebugLocation(130, 92);
				// MathLang.g:130:92: ^( ARRAY_INITIALIZER type ( number )? ( object_initializer )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(130, 94);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAY_INITIALIZER, "ARRAY_INITIALIZER"), root_1);

				DebugLocation(130, 112);
				adaptor.AddChild(root_1, stream_type.NextTree());
				DebugLocation(130, 117);
				// MathLang.g:130:117: ( number )?
				if ( stream_number.HasNext )
				{
					DebugLocation(130, 117);
					adaptor.AddChild(root_1, stream_number.NextTree());

				}
				stream_number.Reset();
				DebugLocation(130, 125);
				// MathLang.g:130:125: ( object_initializer )?
				if ( stream_object_initializer.HasNext )
				{
					DebugLocation(130, 125);
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
		DebugLocation(130, 144);
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
	// MathLang.g:132:1: block : '{' statementlist '}' ;
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

		IToken char_literal161=null;
		IToken char_literal163=null;
		MathLangParser.statementlist_return statementlist162 = default(MathLangParser.statementlist_return);

		object char_literal161_tree=null;
		object char_literal163_tree=null;

		try { DebugEnterRule(GrammarFileName, "block");
		DebugLocation(132, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 42)) { return retval; }
			// MathLang.g:132:6: ( '{' statementlist '}' )
			DebugEnterAlt(1);
			// MathLang.g:132:8: '{' statementlist '}'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(132, 11);
			char_literal161=(IToken)Match(input,61,Follow._61_in_block1357); if (state.failed) return retval;
			DebugLocation(132, 13);
			PushFollow(Follow._statementlist_in_block1360);
			statementlist162=statementlist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementlist162.Tree);
			DebugLocation(132, 30);
			char_literal163=(IToken)Match(input,62,Follow._62_in_block1362); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(132, 30);
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
	// MathLang.g:134:1: statementlist : ( statement )* -> ^( BLOCK ( statement )* ) ;
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

		MathLangParser.statement_return statement164 = default(MathLangParser.statement_return);

		RewriteRuleSubtreeStream stream_statement=new RewriteRuleSubtreeStream(adaptor,"rule statement");
		try { DebugEnterRule(GrammarFileName, "statementlist");
		DebugLocation(134, 49);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 43)) { return retval; }
			// MathLang.g:134:14: ( ( statement )* -> ^( BLOCK ( statement )* ) )
			DebugEnterAlt(1);
			// MathLang.g:134:16: ( statement )*
			{
			DebugLocation(134, 16);
			// MathLang.g:134:16: ( statement )*
			try { DebugEnterSubRule(33);
			while (true)
			{
				int alt33=2;
				try { DebugEnterDecision(33, decisionCanBacktrack[33]);
				int LA33_0 = input.LA(1);

				if ((LA33_0==IF||LA33_0==FOR||(LA33_0>=RETURN && LA33_0<=DO)||LA33_0==TYPE||LA33_0==VOID||LA33_0==ID||LA33_0==KNEW))
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
					DebugLocation(134, 16);
					PushFollow(Follow._statement_in_statementlist1370);
					statement164=statement();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_statement.Add(statement164.Tree);

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
			// 134:27: -> ^( BLOCK ( statement )* )
			{
				DebugLocation(134, 30);
				// MathLang.g:134:30: ^( BLOCK ( statement )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(134, 32);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

				DebugLocation(134, 38);
				// MathLang.g:134:38: ( statement )*
				while ( stream_statement.HasNext )
				{
					DebugLocation(134, 38);
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
		DebugLocation(134, 49);
		} finally { DebugExitRule(GrammarFileName, "statementlist"); }
		return retval;

	}
	// $ANTLR end "statementlist"

	partial void Enter_synpred17_MathLang_fragment();
	partial void Leave_synpred17_MathLang_fragment();

	// $ANTLR start synpred17_MathLang
	public void synpred17_MathLang_fragment()
	{
		Enter_synpred17_MathLang_fragment();
		EnterRule("synpred17_MathLang_fragment", 60);
		TraceIn("synpred17_MathLang_fragment", 60);
		try
		{
			// MathLang.g:75:5: ( funccallbody )
			DebugEnterAlt(1);
			// MathLang.g:75:5: funccallbody
			{
			DebugLocation(75, 5);
			PushFollow(Follow._funccallbody_in_synpred17_MathLang535);
			funccallbody();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred17_MathLang_fragment", 60);
			LeaveRule("synpred17_MathLang_fragment", 60);
			Leave_synpred17_MathLang_fragment();
		}
	}
	// $ANTLR end synpred17_MathLang

	partial void Enter_synpred18_MathLang_fragment();
	partial void Leave_synpred18_MathLang_fragment();

	// $ANTLR start synpred18_MathLang
	public void synpred18_MathLang_fragment()
	{
		Enter_synpred18_MathLang_fragment();
		EnterRule("synpred18_MathLang_fragment", 61);
		TraceIn("synpred18_MathLang_fragment", 61);
		try
		{
			// MathLang.g:76:5: ( boolexpression )
			DebugEnterAlt(1);
			// MathLang.g:76:5: boolexpression
			{
			DebugLocation(76, 5);
			PushFollow(Follow._boolexpression_in_synpred18_MathLang541);
			boolexpression();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred18_MathLang_fragment", 61);
			LeaveRule("synpred18_MathLang_fragment", 61);
			Leave_synpred18_MathLang_fragment();
		}
	}
	// $ANTLR end synpred18_MathLang

	partial void Enter_synpred31_MathLang_fragment();
	partial void Leave_synpred31_MathLang_fragment();

	// $ANTLR start synpred31_MathLang
	public void synpred31_MathLang_fragment()
	{
		Enter_synpred31_MathLang_fragment();
		EnterRule("synpred31_MathLang_fragment", 74);
		TraceIn("synpred31_MathLang_fragment", 74);
		try
		{
			// MathLang.g:95:16: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )
			DebugEnterAlt(1);
			// MathLang.g:95:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
			{
			DebugLocation(95, 16);
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

			DebugLocation(95, 53);
			PushFollow(Follow._add_in_synpred31_MathLang788);
			add();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred31_MathLang_fragment", 74);
			LeaveRule("synpred31_MathLang_fragment", 74);
			Leave_synpred31_MathLang_fragment();
		}
	}
	// $ANTLR end synpred31_MathLang

	partial void Enter_synpred40_MathLang_fragment();
	partial void Leave_synpred40_MathLang_fragment();

	// $ANTLR start synpred40_MathLang
	public void synpred40_MathLang_fragment()
	{
		Enter_synpred40_MathLang_fragment();
		EnterRule("synpred40_MathLang_fragment", 83);
		TraceIn("synpred40_MathLang_fragment", 83);
		try
		{
			// MathLang.g:107:22: ( '(' boolterm ')' )
			DebugEnterAlt(1);
			// MathLang.g:107:22: '(' boolterm ')'
			{
			DebugLocation(107, 22);
			Match(input,58,Follow._58_in_synpred40_MathLang948); if (state.failed) return;
			DebugLocation(107, 27);
			PushFollow(Follow._boolterm_in_synpred40_MathLang951);
			boolterm();
			PopFollow();
			if (state.failed) return;
			DebugLocation(107, 36);
			Match(input,59,Follow._59_in_synpred40_MathLang953); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred40_MathLang_fragment", 83);
			LeaveRule("synpred40_MathLang_fragment", 83);
			Leave_synpred40_MathLang_fragment();
		}
	}
	// $ANTLR end synpred40_MathLang

	partial void Enter_synpred45_MathLang_fragment();
	partial void Leave_synpred45_MathLang_fragment();

	// $ANTLR start synpred45_MathLang
	public void synpred45_MathLang_fragment()
	{
		Enter_synpred45_MathLang_fragment();
		EnterRule("synpred45_MathLang_fragment", 88);
		TraceIn("synpred45_MathLang_fragment", 88);
		try
		{
			// MathLang.g:112:64: ( ELSE ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:112:64: ELSE ( block | statement )
			{
			DebugLocation(112, 64);
			Match(input,ELSE,Follow._ELSE_in_synpred45_MathLang1005); if (state.failed) return;
			DebugLocation(112, 70);
			// MathLang.g:112:70: ( block | statement )
			int alt35=2;
			try { DebugEnterSubRule(35);
			try { DebugEnterDecision(35, decisionCanBacktrack[35]);
			int LA35_0 = input.LA(1);

			if ((LA35_0==61))
			{
				alt35=1;
			}
			else if ((LA35_0==IF||LA35_0==FOR||(LA35_0>=RETURN && LA35_0<=DO)||LA35_0==TYPE||LA35_0==VOID||LA35_0==ID||LA35_0==KNEW))
			{
				alt35=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				NoViableAltException nvae = new NoViableAltException("", 35, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(35); }
			switch (alt35)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:112:71: block
				{
				DebugLocation(112, 71);
				PushFollow(Follow._block_in_synpred45_MathLang1009);
				block();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:112:79: statement
				{
				DebugLocation(112, 79);
				PushFollow(Follow._statement_in_synpred45_MathLang1013);
				statement();
				PopFollow();
				if (state.failed) return;

				}
				break;

			}
			} finally { DebugExitSubRule(35); }


			}

		}
		finally
		{
			TraceOut("synpred45_MathLang_fragment", 88);
			LeaveRule("synpred45_MathLang_fragment", 88);
			Leave_synpred45_MathLang_fragment();
		}
	}
	// $ANTLR end synpred45_MathLang
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
			"\x10\xFFFF";
		private const string DFA1_eofS =
			"\x10\xFFFF";
		private const string DFA1_minS =
			"\x1\x7\x1\x1E\x1\x23\x7\xFFFF\x1\x21\x1\x23\x2\xFFFF\x1\x23\x1\xFFFF";
		private const string DFA1_maxS =
			"\x1\x33\x1\x21\x1\x3A\x7\xFFFF\x1\x21\x1\x3A\x2\xFFFF\x1\x3A\x1\xFFFF";
		private const string DFA1_acceptS =
			"\x3\xFFFF\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x1\x8\x1\xA\x2\xFFFF\x1\x2\x1"+
			"\x9\x1\xFFFF\x1\x1";
		private const string DFA1_specialS =
			"\x10\xFFFF}>";
		private static readonly string[] DFA1_transitionS =
			{
				"\x1\x3\x1\xFFFF\x1\x6\x1\xFFFF\x1\x8\x1\x4\x1\x5\xF\xFFFF\x1\x1\x1"+
				"\xFFFF\x1\x7\x1\xFFFF\x1\x2\x11\xFFFF\x1\x9",
				"\x1\xA\x2\xFFFF\x1\xB",
				"\x1\xC\x10\xFFFF\x1\xC\x5\xFFFF\x1\xD",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\xE",
				"\x1\xF\x15\xFFFF\x1\xF\x1\x7",
				"",
				"",
				"\x1\xF\x15\xFFFF\x1\xF\x1\x7",
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

		public override string Description { get { return "52:12: ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | funcdeclaration | returnstatement | funccall | newexpression )"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA4 : DFA
	{
		private const string DFA4_eotS =
			"\xC\xFFFF";
		private const string DFA4_eofS =
			"\xC\xFFFF";
		private const string DFA4_minS =
			"\x1\x20\x1\xFFFF\x1\x0\x1\xFFFF\x1\x0\x2\xFFFF\x3\x0\x2\xFFFF";
		private const string DFA4_maxS =
			"\x1\x3A\x1\xFFFF\x1\x0\x1\xFFFF\x1\x0\x2\xFFFF\x3\x0\x2\xFFFF";
		private const string DFA4_acceptS =
			"\x1\xFFFF\x1\x1\x1\xFFFF\x1\x3\x6\xFFFF\x1\x2\x1\x4";
		private const string DFA4_specialS =
			"\x2\xFFFF\x1\x0\x1\xFFFF\x1\x1\x2\xFFFF\x1\x2\x1\x3\x1\x4\x2\xFFFF}>";
		private static readonly string[] DFA4_transitionS =
			{
				"\x1\x8\x1\x2\x1\x9\x2\xFFFF\x1\x7\xA\xFFFF\x3\x3\x1\x1\x6\xFFFF\x1"+
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

		public override string Description { get { return "73:1: expression : ( newexpression | funccallbody | boolexpression | mathexpression );"; } }

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
				if ( (EvaluatePredicate(synpred17_MathLang_fragment)) ) {s = 10;}

				else if ( (EvaluatePredicate(synpred18_MathLang_fragment)) ) {s = 3;}

				else if ( (true) ) {s = 11;}


				input.Seek(index4_2);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA4_4 = input.LA(1);


				int index4_4 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred18_MathLang_fragment)) ) {s = 3;}

				else if ( (true) ) {s = 11;}


				input.Seek(index4_4);
				if ( s>=0 ) return s;
				break;
			case 2:
				int LA4_7 = input.LA(1);


				int index4_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred18_MathLang_fragment)) ) {s = 3;}

				else if ( (true) ) {s = 11;}


				input.Seek(index4_7);
				if ( s>=0 ) return s;
				break;
			case 3:
				int LA4_8 = input.LA(1);


				int index4_8 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred18_MathLang_fragment)) ) {s = 3;}

				else if ( (true) ) {s = 11;}


				input.Seek(index4_8);
				if ( s>=0 ) return s;
				break;
			case 4:
				int LA4_9 = input.LA(1);


				int index4_9 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred18_MathLang_fragment)) ) {s = 3;}

				else if ( (true) ) {s = 11;}


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
			"\x1\x3E\x1\x0\x8\xFFFF";
		private const string DFA10_acceptS =
			"\x2\xFFFF\x1\x2\x1\xFFFF\x1\x1\x5\xFFFF";
		private const string DFA10_specialS =
			"\x1\xFFFF\x1\x0\x8\xFFFF}>";
		private static readonly string[] DFA10_transitionS =
			{
				"\x2\x4\x2\x1\x2\x4\x2\x2\x9\xFFFF\x1\x2\x1\xFFFF\x2\x2\x1\xFFFF\x1"+
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

		public override string Description { get { return "95:14: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?"; } }

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
				if ( (EvaluatePredicate(synpred31_MathLang_fragment)) ) {s = 4;}

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
		public static readonly BitSet _TYPE_in_type453 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_array_type460 = new BitSet(new ulong[]{0x40000000UL});
		public static readonly BitSet _ARRAY_DECLARATION_MARK_in_array_type462 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_any_type469 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_type_in_any_type473 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _VOID_in_any_type477 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NUMBER_in_number485 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_number491 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_number497 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CHAR_in_number503 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrayelement_in_number509 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _term_in_mathexpression515 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _newexpression_in_expression529 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_expression535 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolexpression_in_expression541 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathexpression_in_expression547 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_arrayelement559 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _SQRBL_in_arrayelement561 = new BitSet(new ulong[]{0x700000000UL});
		public static readonly BitSet _number_in_arrayelement563 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _SQRBR_in_arrayelement565 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declarationbody_in_declaration583 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _57_in_declaration585 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _longdeclaration_in_declaration593 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_declarationbody601 = new BitSet(new ulong[]{0x200000000UL});
		public static readonly BitSet _ID_in_declarationbody603 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_type_in_declarationbody624 = new BitSet(new ulong[]{0x200000000UL});
		public static readonly BitSet _ID_in_declarationbody626 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _longdeclarationbody_in_longdeclaration648 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _57_in_longdeclaration650 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_longdeclarationbody659 = new BitSet(new ulong[]{0x200000000UL});
		public static readonly BitSet _ID_in_longdeclarationbody661 = new BitSet(new ulong[]{0x800000000UL});
		public static readonly BitSet _ASSIGN_in_longdeclarationbody663 = new BitSet(new ulong[]{0x40F002700000000UL});
		public static readonly BitSet _expression_in_longdeclarationbody665 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_type_in_longdeclarationbody689 = new BitSet(new ulong[]{0x200000000UL});
		public static readonly BitSet _ID_in_longdeclarationbody691 = new BitSet(new ulong[]{0x800000000UL});
		public static readonly BitSet _ASSIGN_in_longdeclarationbody693 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _newexpression_in_longdeclarationbody695 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mul_in_add715 = new BitSet(new ulong[]{0x3000000002UL});
		public static readonly BitSet _set_in_add719 = new BitSet(new ulong[]{0x407002700000000UL});
		public static readonly BitSet _mul_in_add728 = new BitSet(new ulong[]{0x3000000002UL});
		public static readonly BitSet _group_in_mul737 = new BitSet(new ulong[]{0xC000000002UL});
		public static readonly BitSet _set_in_mul741 = new BitSet(new ulong[]{0x407002700000000UL});
		public static readonly BitSet _group_in_mul750 = new BitSet(new ulong[]{0xC000000002UL});
		public static readonly BitSet _add_in_compare758 = new BitSet(new ulong[]{0x3F0000000002UL});
		public static readonly BitSet _set_in_compare762 = new BitSet(new ulong[]{0x407002700000000UL});
		public static readonly BitSet _add_in_compare788 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _add_in_term799 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _SUB_in_group806 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_group811 = new BitSet(new ulong[]{0x40F002700000000UL});
		public static readonly BitSet _term_in_group814 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_group816 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _number_in_group821 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assignmentbody_in_assignment828 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _57_in_assignment830 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_assignmentbody838 = new BitSet(new ulong[]{0x800000000UL});
		public static readonly BitSet _ASSIGN_in_assignmentbody840 = new BitSet(new ulong[]{0x40F002700000000UL});
		public static readonly BitSet _expression_in_assignmentbody842 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrayelement_in_assignmentbody861 = new BitSet(new ulong[]{0x800000000UL});
		public static readonly BitSet _ASSIGN_in_assignmentbody863 = new BitSet(new ulong[]{0x40F002700000000UL});
		public static readonly BitSet _expression_in_assignmentbody865 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolterm_in_boolexpression883 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _or_in_boolterm890 = new BitSet(new ulong[]{0xC0000000002UL});
		public static readonly BitSet _set_in_boolterm894 = new BitSet(new ulong[]{0x407002700000000UL});
		public static readonly BitSet _or_in_boolterm903 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _and_in_or912 = new BitSet(new ulong[]{0x400000000002UL});
		public static readonly BitSet _OR_in_or915 = new BitSet(new ulong[]{0x407002700000000UL});
		public static readonly BitSet _and_in_or918 = new BitSet(new ulong[]{0x400000000002UL});
		public static readonly BitSet _boolgroup_in_and926 = new BitSet(new ulong[]{0x800000000002UL});
		public static readonly BitSet _AND_in_and929 = new BitSet(new ulong[]{0x407002700000000UL});
		public static readonly BitSet _boolgroup_in_and932 = new BitSet(new ulong[]{0x800000000002UL});
		public static readonly BitSet _NOT_in_boolgroup941 = new BitSet(new ulong[]{0x407002700000000UL});
		public static readonly BitSet _58_in_boolgroup948 = new BitSet(new ulong[]{0x407002700000000UL});
		public static readonly BitSet _boolterm_in_boolgroup951 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_boolgroup953 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolvar_in_boolgroup958 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TRUE_in_boolvar966 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FALSE_in_boolvar972 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _compare_in_boolvar978 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_ifstatement985 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_ifstatement988 = new BitSet(new ulong[]{0x407002700000000UL});
		public static readonly BitSet _boolexpression_in_ifstatement991 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_ifstatement993 = new BitSet(new ulong[]{0x20080007A0003A80UL});
		public static readonly BitSet _block_in_ifstatement997 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement1001 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _ELSE_in_ifstatement1005 = new BitSet(new ulong[]{0x20080007A0003A80UL});
		public static readonly BitSet _block_in_ifstatement1009 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement1013 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _WHILE_in_whilestatement1023 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_whilestatement1026 = new BitSet(new ulong[]{0x407002700000000UL});
		public static readonly BitSet _boolexpression_in_whilestatement1029 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_whilestatement1031 = new BitSet(new ulong[]{0x20080007A0003A80UL});
		public static readonly BitSet _block_in_whilestatement1035 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_whilestatement1039 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_forstatement1046 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_forstatement1049 = new BitSet(new ulong[]{0x20000000UL});
		public static readonly BitSet _longdeclarationbody_in_forstatement1052 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _57_in_forstatement1054 = new BitSet(new ulong[]{0x407002700000000UL});
		public static readonly BitSet _boolexpression_in_forstatement1057 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _57_in_forstatement1059 = new BitSet(new ulong[]{0x700000000UL});
		public static readonly BitSet _assignmentbody_in_forstatement1062 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_forstatement1064 = new BitSet(new ulong[]{0x20080007A0003A80UL});
		public static readonly BitSet _block_in_forstatement1068 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_forstatement1072 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _RETURN_in_returnstatement1079 = new BitSet(new ulong[]{0x40F002700000000UL});
		public static readonly BitSet _expression_in_returnstatement1082 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _57_in_returnstatement1084 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DO_in_dowhilestatement1092 = new BitSet(new ulong[]{0x20080007A0003A80UL});
		public static readonly BitSet _block_in_dowhilestatement1096 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _statement_in_dowhilestatement1100 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _WHILE_in_dowhilestatement1103 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_dowhilestatement1106 = new BitSet(new ulong[]{0x407002700000000UL});
		public static readonly BitSet _boolexpression_in_dowhilestatement1109 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_dowhilestatement1111 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _57_in_dowhilestatement1114 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _any_type_in_funcdeclaration1123 = new BitSet(new ulong[]{0x200000000UL});
		public static readonly BitSet _ID_in_funcdeclaration1125 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_funcdeclaration1128 = new BitSet(new ulong[]{0x800000020000000UL});
		public static readonly BitSet _paramsdeclaration_in_funcdeclaration1131 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_funcdeclaration1134 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _block_in_funcdeclaration1137 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declarationbody_in_paramsdeclaration1170 = new BitSet(new ulong[]{0x1000000000000002UL});
		public static readonly BitSet _60_in_paramsdeclaration1174 = new BitSet(new ulong[]{0x20000000UL});
		public static readonly BitSet _declarationbody_in_paramsdeclaration1177 = new BitSet(new ulong[]{0x1000000000000002UL});
		public static readonly BitSet _ID_in_funccallbody1202 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_funccallbody1205 = new BitSet(new ulong[]{0xC0F002700000000UL});
		public static readonly BitSet _expressioncommalist_in_funccallbody1207 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_funccallbody1210 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_funccall1233 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _57_in_funccall1235 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_expressioncommalist1242 = new BitSet(new ulong[]{0x1000000000000002UL});
		public static readonly BitSet _60_in_expressioncommalist1246 = new BitSet(new ulong[]{0x40F002700000000UL});
		public static readonly BitSet _expression_in_expressioncommalist1249 = new BitSet(new ulong[]{0x1000000000000002UL});
		public static readonly BitSet _61_in_object_initializer1261 = new BitSet(new ulong[]{0x40F002700000000UL});
		public static readonly BitSet _expressioncommalist_in_object_initializer1263 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _62_in_object_initializer1265 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _KNEW_in_newexpression1280 = new BitSet(new ulong[]{0x20000000UL});
		public static readonly BitSet _initializer_in_newexpression1283 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _simple_var_initializer_in_initializer1290 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_initializer_in_initializer1294 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_simple_var_initializer1301 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_simple_var_initializer1303 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_simple_var_initializer1305 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_array_initializer1319 = new BitSet(new ulong[]{0x10000040000000UL});
		public static readonly BitSet _SQRBL_in_array_initializer1323 = new BitSet(new ulong[]{0x700000000UL});
		public static readonly BitSet _number_in_array_initializer1325 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _SQRBR_in_array_initializer1327 = new BitSet(new ulong[]{0x2000000000000002UL});
		public static readonly BitSet _ARRAY_DECLARATION_MARK_in_array_initializer1332 = new BitSet(new ulong[]{0x2000000000000002UL});
		public static readonly BitSet _object_initializer_in_array_initializer1335 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _61_in_block1357 = new BitSet(new ulong[]{0x60080007A0003A80UL});
		public static readonly BitSet _statementlist_in_block1360 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _62_in_block1362 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_statementlist1370 = new BitSet(new ulong[]{0x20080007A0003A82UL});
		public static readonly BitSet _funccallbody_in_synpred17_MathLang535 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolexpression_in_synpred18_MathLang541 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_synpred31_MathLang762 = new BitSet(new ulong[]{0x407002700000000UL});
		public static readonly BitSet _add_in_synpred31_MathLang788 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _58_in_synpred40_MathLang948 = new BitSet(new ulong[]{0x407002700000000UL});
		public static readonly BitSet _boolterm_in_synpred40_MathLang951 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_synpred40_MathLang953 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ELSE_in_synpred45_MathLang1005 = new BitSet(new ulong[]{0x20080007A0003A80UL});
		public static readonly BitSet _block_in_synpred45_MathLang1009 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_synpred45_MathLang1013 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  MathLang 

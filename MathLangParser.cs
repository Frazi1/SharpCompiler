// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-10-07 20:48:00

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "UNKNOWN", "PRINT", "INPUT", "IF", "ELSE", "FOR", "FUNCTION", "RETURN", "WHILE", "BLOCK", "PROGRAM", "PARAMS", "VARDECLARATION", "FUNCDECLARATION", "ARRAYDECLARATION", "VARASSIGNMENT", "ARRAYELEMENTASSIGNMENT", "ARRAYELEMENT", "NEWVAR", "ARRAY_INITIALIZER", "OBJECT_INITIALIZER", "FUNC_CALL", "RETURN_TYPE", "PARAMETERS", "TYPE", "ARRAY_DECLARATION_MARK", "VOID", "NUMBER", "ID", "CHAR", "ASSIGN", "ADD", "SUB", "MUL", "DIV", "GREQ", "LSEQ", "NEQ", "EQ", "GR", "LS", "OR", "AND", "NOT", "TRUE", "FALSE", "KNEW", "SQRBL", "SQRBR", "WS", "SL_COMMENT", "ML_COMMENT", "';'", "'('", "')'", "','", "'{'", "'}'"
	};
	public const int EOF=-1;
	public const int T__56=56;
	public const int T__57=57;
	public const int T__58=58;
	public const int T__59=59;
	public const int T__60=60;
	public const int T__61=61;
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
	public const int ARRAYDECLARATION=18;
	public const int VARASSIGNMENT=19;
	public const int ARRAYELEMENTASSIGNMENT=20;
	public const int ARRAYELEMENT=21;
	public const int NEWVAR=22;
	public const int ARRAY_INITIALIZER=23;
	public const int OBJECT_INITIALIZER=24;
	public const int FUNC_CALL=25;
	public const int RETURN_TYPE=26;
	public const int PARAMETERS=27;
	public const int TYPE=28;
	public const int ARRAY_DECLARATION_MARK=29;
	public const int VOID=30;
	public const int NUMBER=31;
	public const int ID=32;
	public const int CHAR=33;
	public const int ASSIGN=34;
	public const int ADD=35;
	public const int SUB=36;
	public const int MUL=37;
	public const int DIV=38;
	public const int GREQ=39;
	public const int LSEQ=40;
	public const int NEQ=41;
	public const int EQ=42;
	public const int GR=43;
	public const int LS=44;
	public const int OR=45;
	public const int AND=46;
	public const int NOT=47;
	public const int TRUE=48;
	public const int FALSE=49;
	public const int KNEW=50;
	public const int SQRBL=51;
	public const int SQRBR=52;
	public const int WS=53;
	public const int SL_COMMENT=54;
	public const int ML_COMMENT=55;

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
				false, false, , false
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
		this.state.ruleMemo = new System.Collections.Generic.Dictionary<int, int>[96+1];

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
			PushFollow(Follow._statementlist_in_execute372);
			statementlist1=statementlist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementlist1.Tree);
			DebugLocation(49, 19);
			EOF2=(IToken)Match(input,EOF,Follow._EOF_in_execute374); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
	// MathLang.g:52:1: statement : ( declaration | assignment | ifstatement | whilestatement | forstatement | funcdeclaration | returnstatement | funccall | newexpression ) ;
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
		MathLangParser.newexpression_return newexpression11 = default(MathLangParser.newexpression_return);


		try { DebugEnterRule(GrammarFileName, "statement");
		DebugLocation(52, 18);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 2)) { return retval; }
			// MathLang.g:52:10: ( ( declaration | assignment | ifstatement | whilestatement | forstatement | funcdeclaration | returnstatement | funccall | newexpression ) )
			DebugEnterAlt(1);
			// MathLang.g:52:12: ( declaration | assignment | ifstatement | whilestatement | forstatement | funcdeclaration | returnstatement | funccall | newexpression )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(52, 12);
			// MathLang.g:52:12: ( declaration | assignment | ifstatement | whilestatement | forstatement | funcdeclaration | returnstatement | funccall | newexpression )
			int alt1=9;
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
				PushFollow(Follow._declaration_in_statement385);
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
				PushFollow(Follow._assignment_in_statement391);
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
				PushFollow(Follow._ifstatement_in_statement396);
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
				PushFollow(Follow._whilestatement_in_statement401);
				whilestatement6=whilestatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, whilestatement6.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:56:4: forstatement
				{
				DebugLocation(56, 4);
				PushFollow(Follow._forstatement_in_statement406);
				forstatement7=forstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forstatement7.Tree);

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// MathLang.g:57:4: funcdeclaration
				{
				DebugLocation(57, 4);
				PushFollow(Follow._funcdeclaration_in_statement411);
				funcdeclaration8=funcdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funcdeclaration8.Tree);

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// MathLang.g:58:4: returnstatement
				{
				DebugLocation(58, 4);
				PushFollow(Follow._returnstatement_in_statement416);
				returnstatement9=returnstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, returnstatement9.Tree);

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// MathLang.g:59:4: funccall
				{
				DebugLocation(59, 4);
				PushFollow(Follow._funccall_in_statement421);
				funccall10=funccall();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccall10.Tree);

				}
				break;
			case 9:
				DebugEnterAlt(9);
				// MathLang.g:60:4: newexpression
				{
				DebugLocation(60, 4);
				PushFollow(Follow._newexpression_in_statement426);
				newexpression11=newexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, newexpression11.Tree);

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
		DebugLocation(60, 18);
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
	// MathLang.g:62:1: type : TYPE ;
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

		IToken TYPE12=null;

		object TYPE12_tree=null;

		try { DebugEnterRule(GrammarFileName, "type");
		DebugLocation(62, 11);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 3)) { return retval; }
			// MathLang.g:62:5: ( TYPE )
			DebugEnterAlt(1);
			// MathLang.g:62:7: TYPE
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(62, 7);
			TYPE12=(IToken)Match(input,TYPE,Follow._TYPE_in_type435); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			TYPE12_tree = (object)adaptor.Create(TYPE12);
			adaptor.AddChild(root_0, TYPE12_tree);
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
		DebugLocation(62, 11);
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
	// MathLang.g:63:1: array_type : TYPE ARRAY_DECLARATION_MARK ;
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

		IToken TYPE13=null;
		IToken ARRAY_DECLARATION_MARK14=null;

		object TYPE13_tree=null;
		object ARRAY_DECLARATION_MARK14_tree=null;

		try { DebugEnterRule(GrammarFileName, "array_type");
		DebugLocation(63, 40);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 4)) { return retval; }
			// MathLang.g:63:11: ( TYPE ARRAY_DECLARATION_MARK )
			DebugEnterAlt(1);
			// MathLang.g:63:13: TYPE ARRAY_DECLARATION_MARK
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(63, 13);
			TYPE13=(IToken)Match(input,TYPE,Follow._TYPE_in_array_type442); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			TYPE13_tree = (object)adaptor.Create(TYPE13);
			adaptor.AddChild(root_0, TYPE13_tree);
			}
			DebugLocation(63, 40);
			ARRAY_DECLARATION_MARK14=(IToken)Match(input,ARRAY_DECLARATION_MARK,Follow._ARRAY_DECLARATION_MARK_in_array_type444); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(63, 40);
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
	// MathLang.g:64:1: any_type : ( type | array_type | VOID );
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

		IToken VOID17=null;
		MathLangParser.type_return type15 = default(MathLangParser.type_return);
		MathLangParser.array_type_return array_type16 = default(MathLangParser.array_type_return);

		object VOID17_tree=null;

		try { DebugEnterRule(GrammarFileName, "any_type");
		DebugLocation(64, 34);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 5)) { return retval; }
			// MathLang.g:64:9: ( type | array_type | VOID )
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
				// MathLang.g:64:11: type
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(64, 11);
				PushFollow(Follow._type_in_any_type451);
				type15=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type15.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:64:18: array_type
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(64, 18);
				PushFollow(Follow._array_type_in_any_type455);
				array_type16=array_type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, array_type16.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:64:31: VOID
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(64, 31);
				VOID17=(IToken)Match(input,VOID,Follow._VOID_in_any_type459); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				VOID17_tree = (object)adaptor.Create(VOID17);
				adaptor.AddChild(root_0, VOID17_tree);
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
		DebugLocation(64, 34);
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
	// MathLang.g:65:1: number : ( NUMBER | ID | funccallbody | CHAR | arrayelement );
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

		IToken NUMBER18=null;
		IToken ID19=null;
		IToken CHAR21=null;
		MathLangParser.funccallbody_return funccallbody20 = default(MathLangParser.funccallbody_return);
		MathLangParser.arrayelement_return arrayelement22 = default(MathLangParser.arrayelement_return);

		object NUMBER18_tree=null;
		object ID19_tree=null;
		object CHAR21_tree=null;

		try { DebugEnterRule(GrammarFileName, "number");
		DebugLocation(65, 16);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 6)) { return retval; }
			// MathLang.g:65:8: ( NUMBER | ID | funccallbody | CHAR | arrayelement )
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
				case 57:
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
				case 56:
				case 58:
				case 59:
				case 61:
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
				// MathLang.g:65:11: NUMBER
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(65, 11);
				NUMBER18=(IToken)Match(input,NUMBER,Follow._NUMBER_in_number467); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				NUMBER18_tree = (object)adaptor.Create(NUMBER18);
				adaptor.AddChild(root_0, NUMBER18_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:66:5: ID
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(66, 5);
				ID19=(IToken)Match(input,ID,Follow._ID_in_number473); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				ID19_tree = (object)adaptor.Create(ID19);
				adaptor.AddChild(root_0, ID19_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:67:5: funccallbody
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(67, 5);
				PushFollow(Follow._funccallbody_in_number479);
				funccallbody20=funccallbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody20.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:68:5: CHAR
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(68, 5);
				CHAR21=(IToken)Match(input,CHAR,Follow._CHAR_in_number485); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				CHAR21_tree = (object)adaptor.Create(CHAR21);
				adaptor.AddChild(root_0, CHAR21_tree);
				}

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:69:5: arrayelement
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(69, 5);
				PushFollow(Follow._arrayelement_in_number491);
				arrayelement22=arrayelement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayelement22.Tree);

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
		DebugLocation(69, 16);
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
	// MathLang.g:70:1: mathexpression : term ;
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

		MathLangParser.term_return term23 = default(MathLangParser.term_return);


		try { DebugEnterRule(GrammarFileName, "mathexpression");
		DebugLocation(70, 21);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 7)) { return retval; }
			// MathLang.g:70:15: ( term )
			DebugEnterAlt(1);
			// MathLang.g:70:17: term
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(70, 17);
			PushFollow(Follow._term_in_mathexpression497);
			term23=term();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term23.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(70, 21);
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
	// MathLang.g:72:1: expression : ( newexpression | funccallbody | boolexpression | mathexpression );
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

		MathLangParser.newexpression_return newexpression24 = default(MathLangParser.newexpression_return);
		MathLangParser.funccallbody_return funccallbody25 = default(MathLangParser.funccallbody_return);
		MathLangParser.boolexpression_return boolexpression26 = default(MathLangParser.boolexpression_return);
		MathLangParser.mathexpression_return mathexpression27 = default(MathLangParser.mathexpression_return);


		try { DebugEnterRule(GrammarFileName, "expression");
		DebugLocation(72, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 8)) { return retval; }
			// MathLang.g:72:11: ( newexpression | funccallbody | boolexpression | mathexpression )
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
				// MathLang.g:73:5: newexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(73, 5);
				PushFollow(Follow._newexpression_in_expression511);
				newexpression24=newexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, newexpression24.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:74:5: funccallbody
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(74, 5);
				PushFollow(Follow._funccallbody_in_expression517);
				funccallbody25=funccallbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody25.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:75:5: boolexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(75, 5);
				PushFollow(Follow._boolexpression_in_expression523);
				boolexpression26=boolexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression26.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:76:5: mathexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(76, 5);
				PushFollow(Follow._mathexpression_in_expression529);
				mathexpression27=mathexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mathexpression27.Tree);

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
		DebugLocation(78, 0);
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
	// MathLang.g:80:1: arrayelement : ID '[' number ']' -> ^( ARRAYELEMENT ID number ) ;
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

		IToken ID28=null;
		IToken char_literal29=null;
		IToken char_literal31=null;
		MathLangParser.number_return number30 = default(MathLangParser.number_return);

		object ID28_tree=null;
		object char_literal29_tree=null;
		object char_literal31_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_SQRBR=new RewriteRuleITokenStream(adaptor,"token SQRBR");
		RewriteRuleITokenStream stream_SQRBL=new RewriteRuleITokenStream(adaptor,"token SQRBL");
		RewriteRuleSubtreeStream stream_number=new RewriteRuleSubtreeStream(adaptor,"rule number");
		try { DebugEnterRule(GrammarFileName, "arrayelement");
		DebugLocation(80, 62);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 9)) { return retval; }
			// MathLang.g:80:13: ( ID '[' number ']' -> ^( ARRAYELEMENT ID number ) )
			DebugEnterAlt(1);
			// MathLang.g:80:16: ID '[' number ']'
			{
			DebugLocation(80, 16);
			ID28=(IToken)Match(input,ID,Follow._ID_in_arrayelement541); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID28);

			DebugLocation(80, 19);
			char_literal29=(IToken)Match(input,SQRBL,Follow._SQRBL_in_arrayelement543); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_SQRBL.Add(char_literal29);

			DebugLocation(80, 23);
			PushFollow(Follow._number_in_arrayelement545);
			number30=number();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_number.Add(number30.Tree);
			DebugLocation(80, 30);
			char_literal31=(IToken)Match(input,SQRBR,Follow._SQRBR_in_arrayelement547); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_SQRBR.Add(char_literal31);



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
			// 80:34: -> ^( ARRAYELEMENT ID number )
			{
				DebugLocation(80, 37);
				// MathLang.g:80:37: ^( ARRAYELEMENT ID number )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(80, 39);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYELEMENT, "ARRAYELEMENT"), root_1);

				DebugLocation(80, 52);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(80, 55);
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
		DebugLocation(80, 62);
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
	// MathLang.g:82:1: declaration : ( declarationbody ';' | longdeclaration );
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

		IToken char_literal33=null;
		MathLangParser.declarationbody_return declarationbody32 = default(MathLangParser.declarationbody_return);
		MathLangParser.longdeclaration_return longdeclaration34 = default(MathLangParser.longdeclaration_return);

		object char_literal33_tree=null;

		try { DebugEnterRule(GrammarFileName, "declaration");
		DebugLocation(82, 20);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 10)) { return retval; }
			// MathLang.g:82:12: ( declarationbody ';' | longdeclaration )
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
						else if ((LA5_4==56))
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
					else if ((LA5_3==56))
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
				// MathLang.g:82:14: declarationbody ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(82, 14);
				PushFollow(Follow._declarationbody_in_declaration565);
				declarationbody32=declarationbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, declarationbody32.Tree);
				DebugLocation(82, 33);
				char_literal33=(IToken)Match(input,56,Follow._56_in_declaration567); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:83:6: longdeclaration
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(83, 6);
				PushFollow(Follow._longdeclaration_in_declaration575);
				longdeclaration34=longdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclaration34.Tree);

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
		DebugLocation(83, 20);
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
	// MathLang.g:85:1: declarationbody : ( ( type ID -> ^( VARDECLARATION type ID ) ) | ( array_type ID -> ^( ARRAYDECLARATION array_type ID ) ) );
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

		IToken ID36=null;
		IToken ID38=null;
		MathLangParser.type_return type35 = default(MathLangParser.type_return);
		MathLangParser.array_type_return array_type37 = default(MathLangParser.array_type_return);

		object ID36_tree=null;
		object ID38_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleSubtreeStream stream_array_type=new RewriteRuleSubtreeStream(adaptor,"rule array_type");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "declarationbody");
		DebugLocation(85, 4);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 11)) { return retval; }
			// MathLang.g:85:16: ( ( type ID -> ^( VARDECLARATION type ID ) ) | ( array_type ID -> ^( ARRAYDECLARATION array_type ID ) ) )
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
				// MathLang.g:85:18: ( type ID -> ^( VARDECLARATION type ID ) )
				{
				DebugLocation(85, 18);
				// MathLang.g:85:18: ( type ID -> ^( VARDECLARATION type ID ) )
				DebugEnterAlt(1);
				// MathLang.g:85:19: type ID
				{
				DebugLocation(85, 19);
				PushFollow(Follow._type_in_declarationbody583);
				type35=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type35.Tree);
				DebugLocation(85, 24);
				ID36=(IToken)Match(input,ID,Follow._ID_in_declarationbody585); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID36);



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
				// 85:27: -> ^( VARDECLARATION type ID )
				{
					DebugLocation(85, 30);
					// MathLang.g:85:30: ^( VARDECLARATION type ID )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(85, 32);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDECLARATION, "VARDECLARATION"), root_1);

					DebugLocation(85, 47);
					adaptor.AddChild(root_1, stream_type.NextTree());
					DebugLocation(85, 52);
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
				// MathLang.g:86:7: ( array_type ID -> ^( ARRAYDECLARATION array_type ID ) )
				{
				DebugLocation(86, 7);
				// MathLang.g:86:7: ( array_type ID -> ^( ARRAYDECLARATION array_type ID ) )
				DebugEnterAlt(1);
				// MathLang.g:86:8: array_type ID
				{
				DebugLocation(86, 8);
				PushFollow(Follow._array_type_in_declarationbody606);
				array_type37=array_type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_array_type.Add(array_type37.Tree);
				DebugLocation(86, 19);
				ID38=(IToken)Match(input,ID,Follow._ID_in_declarationbody608); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID38);



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
				// 86:22: -> ^( ARRAYDECLARATION array_type ID )
				{
					DebugLocation(86, 25);
					// MathLang.g:86:25: ^( ARRAYDECLARATION array_type ID )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(86, 27);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYDECLARATION, "ARRAYDECLARATION"), root_1);

					DebugLocation(86, 44);
					adaptor.AddChild(root_1, stream_array_type.NextTree());
					DebugLocation(86, 55);
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
		DebugLocation(87, 4);
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
	// MathLang.g:88:1: longdeclaration : longdeclarationbody ';' ;
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

		IToken char_literal40=null;
		MathLangParser.longdeclarationbody_return longdeclarationbody39 = default(MathLangParser.longdeclarationbody_return);

		object char_literal40_tree=null;

		try { DebugEnterRule(GrammarFileName, "longdeclaration");
		DebugLocation(88, 42);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 12)) { return retval; }
			// MathLang.g:88:16: ( longdeclarationbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:88:18: longdeclarationbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(88, 18);
			PushFollow(Follow._longdeclarationbody_in_longdeclaration630);
			longdeclarationbody39=longdeclarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclarationbody39.Tree);
			DebugLocation(88, 41);
			char_literal40=(IToken)Match(input,56,Follow._56_in_longdeclaration632); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(88, 42);
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
	// MathLang.g:89:1: longdeclarationbody : ( ( type ID ASSIGN expression -> ^( VARDECLARATION type ID expression ) ) | ( array_type ID ASSIGN newexpression -> ^( ARRAYDECLARATION array_type ID newexpression ) ) );
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

		IToken ID42=null;
		IToken ASSIGN43=null;
		IToken ID46=null;
		IToken ASSIGN47=null;
		MathLangParser.type_return type41 = default(MathLangParser.type_return);
		MathLangParser.expression_return expression44 = default(MathLangParser.expression_return);
		MathLangParser.array_type_return array_type45 = default(MathLangParser.array_type_return);
		MathLangParser.newexpression_return newexpression48 = default(MathLangParser.newexpression_return);

		object ID42_tree=null;
		object ASSIGN43_tree=null;
		object ID46_tree=null;
		object ASSIGN47_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_newexpression=new RewriteRuleSubtreeStream(adaptor,"rule newexpression");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_array_type=new RewriteRuleSubtreeStream(adaptor,"rule array_type");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "longdeclarationbody");
		DebugLocation(89, 94);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 13)) { return retval; }
			// MathLang.g:89:20: ( ( type ID ASSIGN expression -> ^( VARDECLARATION type ID expression ) ) | ( array_type ID ASSIGN newexpression -> ^( ARRAYDECLARATION array_type ID newexpression ) ) )
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
				// MathLang.g:89:22: ( type ID ASSIGN expression -> ^( VARDECLARATION type ID expression ) )
				{
				DebugLocation(89, 22);
				// MathLang.g:89:22: ( type ID ASSIGN expression -> ^( VARDECLARATION type ID expression ) )
				DebugEnterAlt(1);
				// MathLang.g:89:23: type ID ASSIGN expression
				{
				DebugLocation(89, 23);
				PushFollow(Follow._type_in_longdeclarationbody641);
				type41=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type41.Tree);
				DebugLocation(89, 28);
				ID42=(IToken)Match(input,ID,Follow._ID_in_longdeclarationbody643); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID42);

				DebugLocation(89, 31);
				ASSIGN43=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclarationbody645); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN43);

				DebugLocation(89, 38);
				PushFollow(Follow._expression_in_longdeclarationbody647);
				expression44=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression44.Tree);


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
				// 89:50: -> ^( VARDECLARATION type ID expression )
				{
					DebugLocation(89, 53);
					// MathLang.g:89:53: ^( VARDECLARATION type ID expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(89, 55);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDECLARATION, "VARDECLARATION"), root_1);

					DebugLocation(89, 70);
					adaptor.AddChild(root_1, stream_type.NextTree());
					DebugLocation(89, 75);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(89, 78);
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
				// MathLang.g:90:8: ( array_type ID ASSIGN newexpression -> ^( ARRAYDECLARATION array_type ID newexpression ) )
				{
				DebugLocation(90, 8);
				// MathLang.g:90:8: ( array_type ID ASSIGN newexpression -> ^( ARRAYDECLARATION array_type ID newexpression ) )
				DebugEnterAlt(1);
				// MathLang.g:90:9: array_type ID ASSIGN newexpression
				{
				DebugLocation(90, 9);
				PushFollow(Follow._array_type_in_longdeclarationbody671);
				array_type45=array_type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_array_type.Add(array_type45.Tree);
				DebugLocation(90, 20);
				ID46=(IToken)Match(input,ID,Follow._ID_in_longdeclarationbody673); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID46);

				DebugLocation(90, 23);
				ASSIGN47=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclarationbody675); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN47);

				DebugLocation(90, 30);
				PushFollow(Follow._newexpression_in_longdeclarationbody677);
				newexpression48=newexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_newexpression.Add(newexpression48.Tree);


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
				// 90:44: -> ^( ARRAYDECLARATION array_type ID newexpression )
				{
					DebugLocation(90, 47);
					// MathLang.g:90:47: ^( ARRAYDECLARATION array_type ID newexpression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(90, 49);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYDECLARATION, "ARRAYDECLARATION"), root_1);

					DebugLocation(90, 66);
					adaptor.AddChild(root_1, stream_array_type.NextTree());
					DebugLocation(90, 77);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(90, 80);
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
		DebugLocation(90, 94);
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
	// MathLang.g:92:1: add : mul ( ( ADD | SUB ) mul )* ;
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

		IToken set50=null;
		MathLangParser.mul_return mul49 = default(MathLangParser.mul_return);
		MathLangParser.mul_return mul51 = default(MathLangParser.mul_return);

		object set50_tree=null;

		try { DebugEnterRule(GrammarFileName, "add");
		DebugLocation(92, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 14)) { return retval; }
			// MathLang.g:92:4: ( mul ( ( ADD | SUB ) mul )* )
			DebugEnterAlt(1);
			// MathLang.g:92:6: mul ( ( ADD | SUB ) mul )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(92, 6);
			PushFollow(Follow._mul_in_add697);
			mul49=mul();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul49.Tree);
			DebugLocation(92, 10);
			// MathLang.g:92:10: ( ( ADD | SUB ) mul )*
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
					// MathLang.g:92:12: ( ADD | SUB ) mul
					{
					DebugLocation(92, 12);
					set50=(IToken)input.LT(1);
					set50=(IToken)input.LT(1);
					if ((input.LA(1)>=ADD && input.LA(1)<=SUB))
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

					DebugLocation(92, 25);
					PushFollow(Follow._mul_in_add710);
					mul51=mul();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul51.Tree);

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
		DebugLocation(92, 30);
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
	// MathLang.g:93:1: mul : group ( ( MUL | DIV ) group )* ;
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

		IToken set53=null;
		MathLangParser.group_return group52 = default(MathLangParser.group_return);
		MathLangParser.group_return group54 = default(MathLangParser.group_return);

		object set53_tree=null;

		try { DebugEnterRule(GrammarFileName, "mul");
		DebugLocation(93, 33);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 15)) { return retval; }
			// MathLang.g:93:4: ( group ( ( MUL | DIV ) group )* )
			DebugEnterAlt(1);
			// MathLang.g:93:6: group ( ( MUL | DIV ) group )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(93, 6);
			PushFollow(Follow._group_in_mul719);
			group52=group();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group52.Tree);
			DebugLocation(93, 12);
			// MathLang.g:93:12: ( ( MUL | DIV ) group )*
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
					// MathLang.g:93:14: ( MUL | DIV ) group
					{
					DebugLocation(93, 14);
					set53=(IToken)input.LT(1);
					set53=(IToken)input.LT(1);
					if ((input.LA(1)>=MUL && input.LA(1)<=DIV))
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

					DebugLocation(93, 27);
					PushFollow(Follow._group_in_mul732);
					group54=group();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group54.Tree);

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
		DebugLocation(93, 33);
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
	// MathLang.g:94:1: compare : add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )? ;
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

		IToken set56=null;
		MathLangParser.add_return add55 = default(MathLangParser.add_return);
		MathLangParser.add_return add57 = default(MathLangParser.add_return);

		object set56_tree=null;

		try { DebugEnterRule(GrammarFileName, "compare");
		DebugLocation(94, 60);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 16)) { return retval; }
			// MathLang.g:94:8: ( add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )? )
			DebugEnterAlt(1);
			// MathLang.g:94:10: add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(94, 10);
			PushFollow(Follow._add_in_compare740);
			add55=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add55.Tree);
			DebugLocation(94, 14);
			// MathLang.g:94:14: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
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
				// MathLang.g:94:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
				{
				DebugLocation(94, 16);
				set56=(IToken)input.LT(1);
				set56=(IToken)input.LT(1);
				if ((input.LA(1)>=GREQ && input.LA(1)<=LS))
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

				DebugLocation(94, 53);
				PushFollow(Follow._add_in_compare770);
				add57=add();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add57.Tree);

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
		DebugLocation(94, 60);
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
	// MathLang.g:95:1: term : add ;
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

		MathLangParser.add_return add58 = default(MathLangParser.add_return);


		try { DebugEnterRule(GrammarFileName, "term");
		DebugLocation(95, 9);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 17)) { return retval; }
			// MathLang.g:95:5: ( add )
			DebugEnterAlt(1);
			// MathLang.g:95:7: add
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(95, 7);
			PushFollow(Follow._add_in_term781);
			add58=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add58.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(95, 9);
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
	// MathLang.g:96:1: group : ( ( SUB )? '(' term ')' | number );
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

		IToken SUB59=null;
		IToken char_literal60=null;
		IToken char_literal62=null;
		MathLangParser.term_return term61 = default(MathLangParser.term_return);
		MathLangParser.number_return number63 = default(MathLangParser.number_return);

		object SUB59_tree=null;
		object char_literal60_tree=null;
		object char_literal62_tree=null;

		try { DebugEnterRule(GrammarFileName, "group");
		DebugLocation(96, 38);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 18)) { return retval; }
			// MathLang.g:96:6: ( ( SUB )? '(' term ')' | number )
			int alt12=2;
			try { DebugEnterDecision(12, decisionCanBacktrack[12]);
			int LA12_0 = input.LA(1);

			if ((LA12_0==SUB||LA12_0==57))
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
				// MathLang.g:96:8: ( SUB )? '(' term ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(96, 8);
				// MathLang.g:96:8: ( SUB )?
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
					// MathLang.g:96:9: SUB
					{
					DebugLocation(96, 12);
					SUB59=(IToken)Match(input,SUB,Follow._SUB_in_group788); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					SUB59_tree = (object)adaptor.Create(SUB59);
					root_0 = (object)adaptor.BecomeRoot(SUB59_tree, root_0);
					}

					}
					break;

				}
				} finally { DebugExitSubRule(11); }

				DebugLocation(96, 19);
				char_literal60=(IToken)Match(input,57,Follow._57_in_group793); if (state.failed) return retval;
				DebugLocation(96, 21);
				PushFollow(Follow._term_in_group796);
				term61=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term61.Tree);
				DebugLocation(96, 29);
				char_literal62=(IToken)Match(input,58,Follow._58_in_group798); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:96:33: number
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(96, 33);
				PushFollow(Follow._number_in_group803);
				number63=number();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, number63.Tree);

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
		DebugLocation(96, 38);
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
	// MathLang.g:98:1: assignment : assignmentbody ';' ;
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

		IToken char_literal65=null;
		MathLangParser.assignmentbody_return assignmentbody64 = default(MathLangParser.assignmentbody_return);

		object char_literal65_tree=null;

		try { DebugEnterRule(GrammarFileName, "assignment");
		DebugLocation(98, 31);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 19)) { return retval; }
			// MathLang.g:98:11: ( assignmentbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:98:13: assignmentbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(98, 13);
			PushFollow(Follow._assignmentbody_in_assignment810);
			assignmentbody64=assignmentbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentbody64.Tree);
			DebugLocation(98, 31);
			char_literal65=(IToken)Match(input,56,Follow._56_in_assignment812); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(98, 31);
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
	// MathLang.g:99:1: assignmentbody : ( ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) ) | ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) ) );
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

		IToken ID66=null;
		IToken ASSIGN67=null;
		IToken ASSIGN70=null;
		MathLangParser.expression_return expression68 = default(MathLangParser.expression_return);
		MathLangParser.arrayelement_return arrayelement69 = default(MathLangParser.arrayelement_return);
		MathLangParser.expression_return expression71 = default(MathLangParser.expression_return);

		object ID66_tree=null;
		object ASSIGN67_tree=null;
		object ASSIGN70_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_arrayelement=new RewriteRuleSubtreeStream(adaptor,"rule arrayelement");
		try { DebugEnterRule(GrammarFileName, "assignmentbody");
		DebugLocation(99, 87);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 20)) { return retval; }
			// MathLang.g:99:15: ( ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) ) | ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) ) )
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
				// MathLang.g:99:17: ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) )
				{
				DebugLocation(99, 17);
				// MathLang.g:99:17: ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) )
				DebugEnterAlt(1);
				// MathLang.g:99:18: ID ASSIGN expression
				{
				DebugLocation(99, 18);
				ID66=(IToken)Match(input,ID,Follow._ID_in_assignmentbody820); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID66);

				DebugLocation(99, 21);
				ASSIGN67=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignmentbody822); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN67);

				DebugLocation(99, 28);
				PushFollow(Follow._expression_in_assignmentbody824);
				expression68=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression68.Tree);


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
				// 99:39: -> ^( VARASSIGNMENT ID expression )
				{
					DebugLocation(99, 42);
					// MathLang.g:99:42: ^( VARASSIGNMENT ID expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(99, 44);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARASSIGNMENT, "VARASSIGNMENT"), root_1);

					DebugLocation(99, 58);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(99, 61);
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
				// MathLang.g:100:2: ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) )
				{
				DebugLocation(100, 2);
				// MathLang.g:100:2: ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) )
				DebugEnterAlt(1);
				// MathLang.g:100:4: arrayelement ASSIGN expression
				{
				DebugLocation(100, 4);
				PushFollow(Follow._arrayelement_in_assignmentbody843);
				arrayelement69=arrayelement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_arrayelement.Add(arrayelement69.Tree);
				DebugLocation(100, 17);
				ASSIGN70=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignmentbody845); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN70);

				DebugLocation(100, 24);
				PushFollow(Follow._expression_in_assignmentbody847);
				expression71=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression71.Tree);


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
				// 100:35: -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression )
				{
					DebugLocation(100, 38);
					// MathLang.g:100:38: ^( ARRAYELEMENTASSIGNMENT arrayelement expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(100, 40);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYELEMENTASSIGNMENT, "ARRAYELEMENTASSIGNMENT"), root_1);

					DebugLocation(100, 63);
					adaptor.AddChild(root_1, stream_arrayelement.NextTree());
					DebugLocation(100, 76);
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
		DebugLocation(100, 87);
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
	// MathLang.g:102:1: boolexpression : boolterm ;
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

		MathLangParser.boolterm_return boolterm72 = default(MathLangParser.boolterm_return);


		try { DebugEnterRule(GrammarFileName, "boolexpression");
		DebugLocation(102, 25);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 21)) { return retval; }
			// MathLang.g:102:15: ( boolterm )
			DebugEnterAlt(1);
			// MathLang.g:102:17: boolterm
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(102, 17);
			PushFollow(Follow._boolterm_in_boolexpression865);
			boolterm72=boolterm();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm72.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(102, 25);
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
	// MathLang.g:103:1: boolterm : or ( ( EQ | NEQ ) or )? ;
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

		IToken set74=null;
		MathLangParser.or_return or73 = default(MathLangParser.or_return);
		MathLangParser.or_return or75 = default(MathLangParser.or_return);

		object set74_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolterm");
		DebugLocation(103, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 22)) { return retval; }
			// MathLang.g:103:9: ( or ( ( EQ | NEQ ) or )? )
			DebugEnterAlt(1);
			// MathLang.g:103:11: or ( ( EQ | NEQ ) or )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(103, 11);
			PushFollow(Follow._or_in_boolterm872);
			or73=or();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or73.Tree);
			DebugLocation(103, 14);
			// MathLang.g:103:14: ( ( EQ | NEQ ) or )?
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
				// MathLang.g:103:16: ( EQ | NEQ ) or
				{
				DebugLocation(103, 16);
				set74=(IToken)input.LT(1);
				set74=(IToken)input.LT(1);
				if ((input.LA(1)>=NEQ && input.LA(1)<=EQ))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set74), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(103, 28);
				PushFollow(Follow._or_in_boolterm885);
				or75=or();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or75.Tree);

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
		DebugLocation(103, 32);
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
	// MathLang.g:104:1: or : and ( OR and )* ;
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

		IToken OR77=null;
		MathLangParser.and_return and76 = default(MathLangParser.and_return);
		MathLangParser.and_return and78 = default(MathLangParser.and_return);

		object OR77_tree=null;

		try { DebugEnterRule(GrammarFileName, "or");
		DebugLocation(104, 18);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 23)) { return retval; }
			// MathLang.g:104:3: ( and ( OR and )* )
			DebugEnterAlt(1);
			// MathLang.g:104:5: and ( OR and )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(104, 5);
			PushFollow(Follow._and_in_or894);
			and76=and();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and76.Tree);
			DebugLocation(104, 9);
			// MathLang.g:104:9: ( OR and )*
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
					// MathLang.g:104:10: OR and
					{
					DebugLocation(104, 12);
					OR77=(IToken)Match(input,OR,Follow._OR_in_or897); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR77_tree = (object)adaptor.Create(OR77);
					root_0 = (object)adaptor.BecomeRoot(OR77_tree, root_0);
					}
					DebugLocation(104, 14);
					PushFollow(Follow._and_in_or900);
					and78=and();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and78.Tree);

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
		DebugLocation(104, 18);
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
	// MathLang.g:105:1: and : boolgroup ( AND boolgroup )* ;
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

		IToken AND80=null;
		MathLangParser.boolgroup_return boolgroup79 = default(MathLangParser.boolgroup_return);
		MathLangParser.boolgroup_return boolgroup81 = default(MathLangParser.boolgroup_return);

		object AND80_tree=null;

		try { DebugEnterRule(GrammarFileName, "and");
		DebugLocation(105, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 24)) { return retval; }
			// MathLang.g:105:4: ( boolgroup ( AND boolgroup )* )
			DebugEnterAlt(1);
			// MathLang.g:105:6: boolgroup ( AND boolgroup )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(105, 6);
			PushFollow(Follow._boolgroup_in_and908);
			boolgroup79=boolgroup();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup79.Tree);
			DebugLocation(105, 16);
			// MathLang.g:105:16: ( AND boolgroup )*
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
					// MathLang.g:105:17: AND boolgroup
					{
					DebugLocation(105, 20);
					AND80=(IToken)Match(input,AND,Follow._AND_in_and911); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND80_tree = (object)adaptor.Create(AND80);
					root_0 = (object)adaptor.BecomeRoot(AND80_tree, root_0);
					}
					DebugLocation(105, 22);
					PushFollow(Follow._boolgroup_in_and914);
					boolgroup81=boolgroup();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup81.Tree);

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
		DebugLocation(105, 32);
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
	// MathLang.g:106:1: boolgroup : ( NOT )? ( '(' boolterm ')' | boolvar ) ;
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

		IToken NOT82=null;
		IToken char_literal83=null;
		IToken char_literal85=null;
		MathLangParser.boolterm_return boolterm84 = default(MathLangParser.boolterm_return);
		MathLangParser.boolvar_return boolvar86 = default(MathLangParser.boolvar_return);

		object NOT82_tree=null;
		object char_literal83_tree=null;
		object char_literal85_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolgroup");
		DebugLocation(106, 51);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 25)) { return retval; }
			// MathLang.g:106:10: ( ( NOT )? ( '(' boolterm ')' | boolvar ) )
			DebugEnterAlt(1);
			// MathLang.g:106:12: ( NOT )? ( '(' boolterm ')' | boolvar )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(106, 12);
			// MathLang.g:106:12: ( NOT )?
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
				// MathLang.g:106:13: NOT
				{
				DebugLocation(106, 16);
				NOT82=(IToken)Match(input,NOT,Follow._NOT_in_boolgroup923); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				NOT82_tree = (object)adaptor.Create(NOT82);
				root_0 = (object)adaptor.BecomeRoot(NOT82_tree, root_0);
				}

				}
				break;

			}
			} finally { DebugExitSubRule(17); }

			DebugLocation(106, 20);
			// MathLang.g:106:20: ( '(' boolterm ')' | boolvar )
			int alt18=2;
			try { DebugEnterSubRule(18);
			try { DebugEnterDecision(18, decisionCanBacktrack[18]);
			int LA18_0 = input.LA(1);

			if ((LA18_0==57))
			{
				int LA18_1 = input.LA(2);

				if ((EvaluatePredicate(synpred39_MathLang_fragment)))
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
				// MathLang.g:106:22: '(' boolterm ')'
				{
				DebugLocation(106, 25);
				char_literal83=(IToken)Match(input,57,Follow._57_in_boolgroup930); if (state.failed) return retval;
				DebugLocation(106, 27);
				PushFollow(Follow._boolterm_in_boolgroup933);
				boolterm84=boolterm();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm84.Tree);
				DebugLocation(106, 39);
				char_literal85=(IToken)Match(input,58,Follow._58_in_boolgroup935); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:106:43: boolvar
				{
				DebugLocation(106, 43);
				PushFollow(Follow._boolvar_in_boolgroup940);
				boolvar86=boolvar();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolvar86.Tree);

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
		DebugLocation(106, 51);
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
	// MathLang.g:107:1: boolvar : ( TRUE | FALSE | compare );
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

		IToken TRUE87=null;
		IToken FALSE88=null;
		MathLangParser.compare_return compare89 = default(MathLangParser.compare_return);

		object TRUE87_tree=null;
		object FALSE88_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolvar");
		DebugLocation(107, 11);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 26)) { return retval; }
			// MathLang.g:107:8: ( TRUE | FALSE | compare )
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
			case 57:
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
				// MathLang.g:107:10: TRUE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(107, 10);
				TRUE87=(IToken)Match(input,TRUE,Follow._TRUE_in_boolvar948); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				TRUE87_tree = (object)adaptor.Create(TRUE87);
				adaptor.AddChild(root_0, TRUE87_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:108:5: FALSE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(108, 5);
				FALSE88=(IToken)Match(input,FALSE,Follow._FALSE_in_boolvar954); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				FALSE88_tree = (object)adaptor.Create(FALSE88);
				adaptor.AddChild(root_0, FALSE88_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:109:5: compare
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(109, 5);
				PushFollow(Follow._compare_in_boolvar960);
				compare89=compare();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare89.Tree);

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
		DebugLocation(109, 11);
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
	// MathLang.g:111:1: ifstatement : IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )* ;
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

		IToken IF90=null;
		IToken char_literal91=null;
		IToken char_literal93=null;
		IToken ELSE96=null;
		MathLangParser.boolexpression_return boolexpression92 = default(MathLangParser.boolexpression_return);
		MathLangParser.block_return block94 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement95 = default(MathLangParser.statement_return);
		MathLangParser.block_return block97 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement98 = default(MathLangParser.statement_return);

		object IF90_tree=null;
		object char_literal91_tree=null;
		object char_literal93_tree=null;
		object ELSE96_tree=null;

		try { DebugEnterRule(GrammarFileName, "ifstatement");
		DebugLocation(111, 91);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 27)) { return retval; }
			// MathLang.g:111:12: ( IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )* )
			DebugEnterAlt(1);
			// MathLang.g:111:14: IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(111, 16);
			IF90=(IToken)Match(input,IF,Follow._IF_in_ifstatement967); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			IF90_tree = (object)adaptor.Create(IF90);
			root_0 = (object)adaptor.BecomeRoot(IF90_tree, root_0);
			}
			DebugLocation(111, 21);
			char_literal91=(IToken)Match(input,57,Follow._57_in_ifstatement970); if (state.failed) return retval;
			DebugLocation(111, 23);
			PushFollow(Follow._boolexpression_in_ifstatement973);
			boolexpression92=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression92.Tree);
			DebugLocation(111, 41);
			char_literal93=(IToken)Match(input,58,Follow._58_in_ifstatement975); if (state.failed) return retval;
			DebugLocation(111, 43);
			// MathLang.g:111:43: ( block | statement )
			int alt20=2;
			try { DebugEnterSubRule(20);
			try { DebugEnterDecision(20, decisionCanBacktrack[20]);
			int LA20_0 = input.LA(1);

			if ((LA20_0==60))
			{
				alt20=1;
			}
			else if ((LA20_0==IF||LA20_0==FOR||(LA20_0>=RETURN && LA20_0<=WHILE)||LA20_0==TYPE||LA20_0==VOID||LA20_0==ID||LA20_0==KNEW))
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
				// MathLang.g:111:44: block
				{
				DebugLocation(111, 44);
				PushFollow(Follow._block_in_ifstatement979);
				block94=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block94.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:111:52: statement
				{
				DebugLocation(111, 52);
				PushFollow(Follow._statement_in_ifstatement983);
				statement95=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement95.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(20); }

			DebugLocation(111, 63);
			// MathLang.g:111:63: ( ELSE ( block | statement ) )*
			try { DebugEnterSubRule(22);
			while (true)
			{
				int alt22=2;
				try { DebugEnterDecision(22, decisionCanBacktrack[22]);
				int LA22_0 = input.LA(1);

				if ((LA22_0==ELSE))
				{
					int LA22_1 = input.LA(2);

					if ((EvaluatePredicate(synpred44_MathLang_fragment)))
					{
						alt22=1;
					}


				}


				} finally { DebugExitDecision(22); }
				switch ( alt22 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:111:64: ELSE ( block | statement )
					{
					DebugLocation(111, 68);
					ELSE96=(IToken)Match(input,ELSE,Follow._ELSE_in_ifstatement987); if (state.failed) return retval;
					DebugLocation(111, 70);
					// MathLang.g:111:70: ( block | statement )
					int alt21=2;
					try { DebugEnterSubRule(21);
					try { DebugEnterDecision(21, decisionCanBacktrack[21]);
					int LA21_0 = input.LA(1);

					if ((LA21_0==60))
					{
						alt21=1;
					}
					else if ((LA21_0==IF||LA21_0==FOR||(LA21_0>=RETURN && LA21_0<=WHILE)||LA21_0==TYPE||LA21_0==VOID||LA21_0==ID||LA21_0==KNEW))
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
						// MathLang.g:111:71: block
						{
						DebugLocation(111, 71);
						PushFollow(Follow._block_in_ifstatement991);
						block97=block();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block97.Tree);

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// MathLang.g:111:79: statement
						{
						DebugLocation(111, 79);
						PushFollow(Follow._statement_in_ifstatement995);
						statement98=statement();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement98.Tree);

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
		DebugLocation(111, 91);
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
	// MathLang.g:112:1: whilestatement : WHILE '(' boolexpression ')' ( block | statement ) ;
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

		IToken WHILE99=null;
		IToken char_literal100=null;
		IToken char_literal102=null;
		MathLangParser.boolexpression_return boolexpression101 = default(MathLangParser.boolexpression_return);
		MathLangParser.block_return block103 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement104 = default(MathLangParser.statement_return);

		object WHILE99_tree=null;
		object char_literal100_tree=null;
		object char_literal102_tree=null;

		try { DebugEnterRule(GrammarFileName, "whilestatement");
		DebugLocation(112, 67);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 28)) { return retval; }
			// MathLang.g:112:15: ( WHILE '(' boolexpression ')' ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:112:17: WHILE '(' boolexpression ')' ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(112, 22);
			WHILE99=(IToken)Match(input,WHILE,Follow._WHILE_in_whilestatement1005); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			WHILE99_tree = (object)adaptor.Create(WHILE99);
			root_0 = (object)adaptor.BecomeRoot(WHILE99_tree, root_0);
			}
			DebugLocation(112, 27);
			char_literal100=(IToken)Match(input,57,Follow._57_in_whilestatement1008); if (state.failed) return retval;
			DebugLocation(112, 29);
			PushFollow(Follow._boolexpression_in_whilestatement1011);
			boolexpression101=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression101.Tree);
			DebugLocation(112, 47);
			char_literal102=(IToken)Match(input,58,Follow._58_in_whilestatement1013); if (state.failed) return retval;
			DebugLocation(112, 49);
			// MathLang.g:112:49: ( block | statement )
			int alt23=2;
			try { DebugEnterSubRule(23);
			try { DebugEnterDecision(23, decisionCanBacktrack[23]);
			int LA23_0 = input.LA(1);

			if ((LA23_0==60))
			{
				alt23=1;
			}
			else if ((LA23_0==IF||LA23_0==FOR||(LA23_0>=RETURN && LA23_0<=WHILE)||LA23_0==TYPE||LA23_0==VOID||LA23_0==ID||LA23_0==KNEW))
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
				// MathLang.g:112:50: block
				{
				DebugLocation(112, 50);
				PushFollow(Follow._block_in_whilestatement1017);
				block103=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block103.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:112:58: statement
				{
				DebugLocation(112, 58);
				PushFollow(Follow._statement_in_whilestatement1021);
				statement104=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement104.Tree);

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
		DebugLocation(112, 67);
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
	// MathLang.g:113:1: forstatement : FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement ) ;
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

		IToken FOR105=null;
		IToken char_literal106=null;
		IToken char_literal108=null;
		IToken char_literal110=null;
		IToken char_literal112=null;
		MathLangParser.longdeclarationbody_return longdeclarationbody107 = default(MathLangParser.longdeclarationbody_return);
		MathLangParser.boolexpression_return boolexpression109 = default(MathLangParser.boolexpression_return);
		MathLangParser.assignmentbody_return assignmentbody111 = default(MathLangParser.assignmentbody_return);
		MathLangParser.block_return block113 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement114 = default(MathLangParser.statement_return);

		object FOR105_tree=null;
		object char_literal106_tree=null;
		object char_literal108_tree=null;
		object char_literal110_tree=null;
		object char_literal112_tree=null;

		try { DebugEnterRule(GrammarFileName, "forstatement");
		DebugLocation(113, 108);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 29)) { return retval; }
			// MathLang.g:113:13: ( FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:113:15: FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(113, 18);
			FOR105=(IToken)Match(input,FOR,Follow._FOR_in_forstatement1028); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			FOR105_tree = (object)adaptor.Create(FOR105);
			root_0 = (object)adaptor.BecomeRoot(FOR105_tree, root_0);
			}
			DebugLocation(113, 23);
			char_literal106=(IToken)Match(input,57,Follow._57_in_forstatement1031); if (state.failed) return retval;
			DebugLocation(113, 25);
			PushFollow(Follow._longdeclarationbody_in_forstatement1034);
			longdeclarationbody107=longdeclarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclarationbody107.Tree);
			DebugLocation(113, 48);
			char_literal108=(IToken)Match(input,56,Follow._56_in_forstatement1036); if (state.failed) return retval;
			DebugLocation(113, 50);
			PushFollow(Follow._boolexpression_in_forstatement1039);
			boolexpression109=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression109.Tree);
			DebugLocation(113, 68);
			char_literal110=(IToken)Match(input,56,Follow._56_in_forstatement1041); if (state.failed) return retval;
			DebugLocation(113, 70);
			PushFollow(Follow._assignmentbody_in_forstatement1044);
			assignmentbody111=assignmentbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentbody111.Tree);
			DebugLocation(113, 88);
			char_literal112=(IToken)Match(input,58,Follow._58_in_forstatement1046); if (state.failed) return retval;
			DebugLocation(113, 90);
			// MathLang.g:113:90: ( block | statement )
			int alt24=2;
			try { DebugEnterSubRule(24);
			try { DebugEnterDecision(24, decisionCanBacktrack[24]);
			int LA24_0 = input.LA(1);

			if ((LA24_0==60))
			{
				alt24=1;
			}
			else if ((LA24_0==IF||LA24_0==FOR||(LA24_0>=RETURN && LA24_0<=WHILE)||LA24_0==TYPE||LA24_0==VOID||LA24_0==ID||LA24_0==KNEW))
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
				// MathLang.g:113:91: block
				{
				DebugLocation(113, 91);
				PushFollow(Follow._block_in_forstatement1050);
				block113=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block113.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:113:99: statement
				{
				DebugLocation(113, 99);
				PushFollow(Follow._statement_in_forstatement1054);
				statement114=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement114.Tree);

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
		DebugLocation(113, 108);
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
	// MathLang.g:114:1: returnstatement : RETURN expression ';' ;
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

		IToken RETURN115=null;
		IToken char_literal117=null;
		MathLangParser.expression_return expression116 = default(MathLangParser.expression_return);

		object RETURN115_tree=null;
		object char_literal117_tree=null;

		try { DebugEnterRule(GrammarFileName, "returnstatement");
		DebugLocation(114, 41);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 30)) { return retval; }
			// MathLang.g:114:16: ( RETURN expression ';' )
			DebugEnterAlt(1);
			// MathLang.g:114:18: RETURN expression ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(114, 24);
			RETURN115=(IToken)Match(input,RETURN,Follow._RETURN_in_returnstatement1061); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			RETURN115_tree = (object)adaptor.Create(RETURN115);
			root_0 = (object)adaptor.BecomeRoot(RETURN115_tree, root_0);
			}
			DebugLocation(114, 26);
			PushFollow(Follow._expression_in_returnstatement1064);
			expression116=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression116.Tree);
			DebugLocation(114, 40);
			char_literal117=(IToken)Match(input,56,Follow._56_in_returnstatement1066); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(114, 41);
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
	// MathLang.g:116:1: funcdeclaration : any_type ID '(' ( paramsdeclaration )? ')' block -> ^( FUNCDECLARATION ID ^( RETURN_TYPE any_type ) ( paramsdeclaration )? block ) ;
	[GrammarRule("funcdeclaration")]
	private MathLangParser.funcdeclaration_return funcdeclaration()
	{
		Enter_funcdeclaration();
		EnterRule("funcdeclaration", 31);
		TraceIn("funcdeclaration", 31);
		MathLangParser.funcdeclaration_return retval = new MathLangParser.funcdeclaration_return();
		retval.Start = (IToken)input.LT(1);
		int funcdeclaration_StartIndex = input.Index;
		object root_0 = null;

		IToken ID119=null;
		IToken char_literal120=null;
		IToken char_literal122=null;
		MathLangParser.any_type_return any_type118 = default(MathLangParser.any_type_return);
		MathLangParser.paramsdeclaration_return paramsdeclaration121 = default(MathLangParser.paramsdeclaration_return);
		MathLangParser.block_return block123 = default(MathLangParser.block_return);

		object ID119_tree=null;
		object char_literal120_tree=null;
		object char_literal122_tree=null;
		RewriteRuleITokenStream stream_58=new RewriteRuleITokenStream(adaptor,"token 58");
		RewriteRuleITokenStream stream_57=new RewriteRuleITokenStream(adaptor,"token 57");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleSubtreeStream stream_paramsdeclaration=new RewriteRuleSubtreeStream(adaptor,"rule paramsdeclaration");
		RewriteRuleSubtreeStream stream_block=new RewriteRuleSubtreeStream(adaptor,"rule block");
		RewriteRuleSubtreeStream stream_any_type=new RewriteRuleSubtreeStream(adaptor,"rule any_type");
		try { DebugEnterRule(GrammarFileName, "funcdeclaration");
		DebugLocation(116, 148);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 31)) { return retval; }
			// MathLang.g:116:16: ( any_type ID '(' ( paramsdeclaration )? ')' block -> ^( FUNCDECLARATION ID ^( RETURN_TYPE any_type ) ( paramsdeclaration )? block ) )
			DebugEnterAlt(1);
			// MathLang.g:116:18: any_type ID '(' ( paramsdeclaration )? ')' block
			{
			DebugLocation(116, 18);
			PushFollow(Follow._any_type_in_funcdeclaration1075);
			any_type118=any_type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_any_type.Add(any_type118.Tree);
			DebugLocation(116, 29);
			ID119=(IToken)Match(input,ID,Follow._ID_in_funcdeclaration1077); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID119);

			DebugLocation(116, 34);
			char_literal120=(IToken)Match(input,57,Follow._57_in_funcdeclaration1080); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_57.Add(char_literal120);

			DebugLocation(116, 36);
			// MathLang.g:116:36: ( paramsdeclaration )?
			int alt25=2;
			try { DebugEnterSubRule(25);
			try { DebugEnterDecision(25, decisionCanBacktrack[25]);
			int LA25_0 = input.LA(1);

			if ((LA25_0==TYPE))
			{
				alt25=1;
			}
			} finally { DebugExitDecision(25); }
			switch (alt25)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: paramsdeclaration
				{
				DebugLocation(116, 36);
				PushFollow(Follow._paramsdeclaration_in_funcdeclaration1083);
				paramsdeclaration121=paramsdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_paramsdeclaration.Add(paramsdeclaration121.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(25); }

			DebugLocation(116, 58);
			char_literal122=(IToken)Match(input,58,Follow._58_in_funcdeclaration1086); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_58.Add(char_literal122);

			DebugLocation(116, 60);
			PushFollow(Follow._block_in_funcdeclaration1089);
			block123=block();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_block.Add(block123.Tree);


			{
			// AST REWRITE
			// elements: ID, block, paramsdeclaration, any_type
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 116:66: -> ^( FUNCDECLARATION ID ^( RETURN_TYPE any_type ) ( paramsdeclaration )? block )
			{
				DebugLocation(116, 69);
				// MathLang.g:116:69: ^( FUNCDECLARATION ID ^( RETURN_TYPE any_type ) ( paramsdeclaration )? block )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(116, 71);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNCDECLARATION, "FUNCDECLARATION"), root_1);

				DebugLocation(116, 87);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(116, 90);
				// MathLang.g:116:90: ^( RETURN_TYPE any_type )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(116, 92);
				root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(RETURN_TYPE, "RETURN_TYPE"), root_2);

				DebugLocation(116, 104);
				adaptor.AddChild(root_2, stream_any_type.NextTree());

				adaptor.AddChild(root_1, root_2);
				}
				DebugLocation(116, 119);
				// MathLang.g:116:119: ( paramsdeclaration )?
				if ( stream_paramsdeclaration.HasNext )
				{
					DebugLocation(116, 119);
					adaptor.AddChild(root_1, stream_paramsdeclaration.NextTree());

				}
				stream_paramsdeclaration.Reset();
				DebugLocation(116, 143);
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
			TraceOut("funcdeclaration", 31);
			LeaveRule("funcdeclaration", 31);
			Leave_funcdeclaration();
			if (state.backtracking > 0) { Memoize(input, 31, funcdeclaration_StartIndex); }
		}
		DebugLocation(116, 148);
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
	// MathLang.g:117:1: paramsdeclaration : ( declarationbody ( ',' declarationbody )* ) -> ^( PARAMETERS ( declarationbody )* ) ;
	[GrammarRule("paramsdeclaration")]
	private MathLangParser.paramsdeclaration_return paramsdeclaration()
	{
		Enter_paramsdeclaration();
		EnterRule("paramsdeclaration", 32);
		TraceIn("paramsdeclaration", 32);
		MathLangParser.paramsdeclaration_return retval = new MathLangParser.paramsdeclaration_return();
		retval.Start = (IToken)input.LT(1);
		int paramsdeclaration_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal125=null;
		MathLangParser.declarationbody_return declarationbody124 = default(MathLangParser.declarationbody_return);
		MathLangParser.declarationbody_return declarationbody126 = default(MathLangParser.declarationbody_return);

		object char_literal125_tree=null;
		RewriteRuleITokenStream stream_59=new RewriteRuleITokenStream(adaptor,"token 59");
		RewriteRuleSubtreeStream stream_declarationbody=new RewriteRuleSubtreeStream(adaptor,"rule declarationbody");
		try { DebugEnterRule(GrammarFileName, "paramsdeclaration");
		DebugLocation(117, 102);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 32)) { return retval; }
			// MathLang.g:117:18: ( ( declarationbody ( ',' declarationbody )* ) -> ^( PARAMETERS ( declarationbody )* ) )
			DebugEnterAlt(1);
			// MathLang.g:117:20: ( declarationbody ( ',' declarationbody )* )
			{
			DebugLocation(117, 20);
			// MathLang.g:117:20: ( declarationbody ( ',' declarationbody )* )
			DebugEnterAlt(1);
			// MathLang.g:117:22: declarationbody ( ',' declarationbody )*
			{
			DebugLocation(117, 22);
			PushFollow(Follow._declarationbody_in_paramsdeclaration1122);
			declarationbody124=declarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declarationbody.Add(declarationbody124.Tree);
			DebugLocation(117, 38);
			// MathLang.g:117:38: ( ',' declarationbody )*
			try { DebugEnterSubRule(26);
			while (true)
			{
				int alt26=2;
				try { DebugEnterDecision(26, decisionCanBacktrack[26]);
				int LA26_0 = input.LA(1);

				if ((LA26_0==59))
				{
					alt26=1;
				}


				} finally { DebugExitDecision(26); }
				switch ( alt26 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:117:40: ',' declarationbody
					{
					DebugLocation(117, 43);
					char_literal125=(IToken)Match(input,59,Follow._59_in_paramsdeclaration1126); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_59.Add(char_literal125);

					DebugLocation(117, 45);
					PushFollow(Follow._declarationbody_in_paramsdeclaration1129);
					declarationbody126=declarationbody();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_declarationbody.Add(declarationbody126.Tree);

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
			// 117:66: -> ^( PARAMETERS ( declarationbody )* )
			{
				DebugLocation(117, 69);
				// MathLang.g:117:69: ^( PARAMETERS ( declarationbody )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(117, 71);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_1);

				DebugLocation(117, 82);
				// MathLang.g:117:82: ( declarationbody )*
				while ( stream_declarationbody.HasNext )
				{
					DebugLocation(117, 84);
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
			TraceOut("paramsdeclaration", 32);
			LeaveRule("paramsdeclaration", 32);
			Leave_paramsdeclaration();
			if (state.backtracking > 0) { Memoize(input, 32, paramsdeclaration_StartIndex); }
		}
		DebugLocation(117, 102);
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
	// MathLang.g:119:1: funccallbody : ID '(' ( expressioncommalist )? ')' -> ^( FUNC_CALL ^( ID ( ^( PARAMETERS expressioncommalist ) )? ) ) ;
	[GrammarRule("funccallbody")]
	private MathLangParser.funccallbody_return funccallbody()
	{
		Enter_funccallbody();
		EnterRule("funccallbody", 33);
		TraceIn("funccallbody", 33);
		MathLangParser.funccallbody_return retval = new MathLangParser.funccallbody_return();
		retval.Start = (IToken)input.LT(1);
		int funccallbody_StartIndex = input.Index;
		object root_0 = null;

		IToken ID127=null;
		IToken char_literal128=null;
		IToken char_literal130=null;
		MathLangParser.expressioncommalist_return expressioncommalist129 = default(MathLangParser.expressioncommalist_return);

		object ID127_tree=null;
		object char_literal128_tree=null;
		object char_literal130_tree=null;
		RewriteRuleITokenStream stream_58=new RewriteRuleITokenStream(adaptor,"token 58");
		RewriteRuleITokenStream stream_57=new RewriteRuleITokenStream(adaptor,"token 57");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleSubtreeStream stream_expressioncommalist=new RewriteRuleSubtreeStream(adaptor,"rule expressioncommalist");
		try { DebugEnterRule(GrammarFileName, "funccallbody");
		DebugLocation(119, 103);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 33)) { return retval; }
			// MathLang.g:119:13: ( ID '(' ( expressioncommalist )? ')' -> ^( FUNC_CALL ^( ID ( ^( PARAMETERS expressioncommalist ) )? ) ) )
			DebugEnterAlt(1);
			// MathLang.g:119:15: ID '(' ( expressioncommalist )? ')'
			{
			DebugLocation(119, 17);
			ID127=(IToken)Match(input,ID,Follow._ID_in_funccallbody1154); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID127);

			DebugLocation(119, 19);
			char_literal128=(IToken)Match(input,57,Follow._57_in_funccallbody1157); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_57.Add(char_literal128);

			DebugLocation(119, 23);
			// MathLang.g:119:23: ( expressioncommalist )?
			int alt27=2;
			try { DebugEnterSubRule(27);
			try { DebugEnterDecision(27, decisionCanBacktrack[27]);
			int LA27_0 = input.LA(1);

			if (((LA27_0>=NUMBER && LA27_0<=CHAR)||LA27_0==SUB||(LA27_0>=NOT && LA27_0<=KNEW)||LA27_0==57))
			{
				alt27=1;
			}
			} finally { DebugExitDecision(27); }
			switch (alt27)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: expressioncommalist
				{
				DebugLocation(119, 23);
				PushFollow(Follow._expressioncommalist_in_funccallbody1159);
				expressioncommalist129=expressioncommalist();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expressioncommalist.Add(expressioncommalist129.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(27); }

			DebugLocation(119, 44);
			char_literal130=(IToken)Match(input,58,Follow._58_in_funccallbody1162); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_58.Add(char_literal130);



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
			// 119:48: -> ^( FUNC_CALL ^( ID ( ^( PARAMETERS expressioncommalist ) )? ) )
			{
				DebugLocation(119, 51);
				// MathLang.g:119:51: ^( FUNC_CALL ^( ID ( ^( PARAMETERS expressioncommalist ) )? ) )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(119, 53);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_CALL, "FUNC_CALL"), root_1);

				DebugLocation(119, 63);
				// MathLang.g:119:63: ^( ID ( ^( PARAMETERS expressioncommalist ) )? )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(119, 65);
				root_2 = (object)adaptor.BecomeRoot(stream_ID.NextNode(), root_2);

				DebugLocation(119, 68);
				// MathLang.g:119:68: ( ^( PARAMETERS expressioncommalist ) )?
				if ( stream_expressioncommalist.HasNext )
				{
					DebugLocation(119, 68);
					// MathLang.g:119:68: ^( PARAMETERS expressioncommalist )
					{
					object root_3 = (object)adaptor.Nil();
					DebugLocation(119, 70);
					root_3 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_3);

					DebugLocation(119, 81);
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
			TraceOut("funccallbody", 33);
			LeaveRule("funccallbody", 33);
			Leave_funccallbody();
			if (state.backtracking > 0) { Memoize(input, 33, funccallbody_StartIndex); }
		}
		DebugLocation(119, 103);
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
	// MathLang.g:120:1: funccall : funccallbody ';' ;
	[GrammarRule("funccall")]
	private MathLangParser.funccall_return funccall()
	{
		Enter_funccall();
		EnterRule("funccall", 34);
		TraceIn("funccall", 34);
		MathLangParser.funccall_return retval = new MathLangParser.funccall_return();
		retval.Start = (IToken)input.LT(1);
		int funccall_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal132=null;
		MathLangParser.funccallbody_return funccallbody131 = default(MathLangParser.funccallbody_return);

		object char_literal132_tree=null;

		try { DebugEnterRule(GrammarFileName, "funccall");
		DebugLocation(120, 27);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 34)) { return retval; }
			// MathLang.g:120:9: ( funccallbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:120:11: funccallbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(120, 11);
			PushFollow(Follow._funccallbody_in_funccall1185);
			funccallbody131=funccallbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody131.Tree);
			DebugLocation(120, 27);
			char_literal132=(IToken)Match(input,56,Follow._56_in_funccall1187); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("funccall", 34);
			LeaveRule("funccall", 34);
			Leave_funccall();
			if (state.backtracking > 0) { Memoize(input, 34, funccall_StartIndex); }
		}
		DebugLocation(120, 27);
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
	// MathLang.g:121:1: expressioncommalist : expression ( ',' expression )* ;
	[GrammarRule("expressioncommalist")]
	private MathLangParser.expressioncommalist_return expressioncommalist()
	{
		Enter_expressioncommalist();
		EnterRule("expressioncommalist", 35);
		TraceIn("expressioncommalist", 35);
		MathLangParser.expressioncommalist_return retval = new MathLangParser.expressioncommalist_return();
		retval.Start = (IToken)input.LT(1);
		int expressioncommalist_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal134=null;
		MathLangParser.expression_return expression133 = default(MathLangParser.expression_return);
		MathLangParser.expression_return expression135 = default(MathLangParser.expression_return);

		object char_literal134_tree=null;

		try { DebugEnterRule(GrammarFileName, "expressioncommalist");
		DebugLocation(121, 51);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 35)) { return retval; }
			// MathLang.g:121:20: ( expression ( ',' expression )* )
			DebugEnterAlt(1);
			// MathLang.g:121:22: expression ( ',' expression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(121, 22);
			PushFollow(Follow._expression_in_expressioncommalist1194);
			expression133=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression133.Tree);
			DebugLocation(121, 33);
			// MathLang.g:121:33: ( ',' expression )*
			try { DebugEnterSubRule(28);
			while (true)
			{
				int alt28=2;
				try { DebugEnterDecision(28, decisionCanBacktrack[28]);
				int LA28_0 = input.LA(1);

				if ((LA28_0==59))
				{
					alt28=1;
				}


				} finally { DebugExitDecision(28); }
				switch ( alt28 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:121:35: ',' expression
					{
					DebugLocation(121, 38);
					char_literal134=(IToken)Match(input,59,Follow._59_in_expressioncommalist1198); if (state.failed) return retval;
					DebugLocation(121, 40);
					PushFollow(Follow._expression_in_expressioncommalist1201);
					expression135=expression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression135.Tree);

					}
					break;

				default:
					goto loop28;
				}
			}

			loop28:
				;

			} finally { DebugExitSubRule(28); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expressioncommalist", 35);
			LeaveRule("expressioncommalist", 35);
			Leave_expressioncommalist();
			if (state.backtracking > 0) { Memoize(input, 35, expressioncommalist_StartIndex); }
		}
		DebugLocation(121, 51);
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
	// MathLang.g:124:1: object_initializer : '{' expressioncommalist '}' -> ^( PARAMETERS expressioncommalist ) ;
	[GrammarRule("object_initializer")]
	private MathLangParser.object_initializer_return object_initializer()
	{
		Enter_object_initializer();
		EnterRule("object_initializer", 36);
		TraceIn("object_initializer", 36);
		MathLangParser.object_initializer_return retval = new MathLangParser.object_initializer_return();
		retval.Start = (IToken)input.LT(1);
		int object_initializer_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal136=null;
		IToken char_literal138=null;
		MathLangParser.expressioncommalist_return expressioncommalist137 = default(MathLangParser.expressioncommalist_return);

		object char_literal136_tree=null;
		object char_literal138_tree=null;
		RewriteRuleITokenStream stream_60=new RewriteRuleITokenStream(adaptor,"token 60");
		RewriteRuleITokenStream stream_61=new RewriteRuleITokenStream(adaptor,"token 61");
		RewriteRuleSubtreeStream stream_expressioncommalist=new RewriteRuleSubtreeStream(adaptor,"rule expressioncommalist");
		try { DebugEnterRule(GrammarFileName, "object_initializer");
		DebugLocation(124, 86);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 36)) { return retval; }
			// MathLang.g:124:19: ( '{' expressioncommalist '}' -> ^( PARAMETERS expressioncommalist ) )
			DebugEnterAlt(1);
			// MathLang.g:124:22: '{' expressioncommalist '}'
			{
			DebugLocation(124, 22);
			char_literal136=(IToken)Match(input,60,Follow._60_in_object_initializer1213); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_60.Add(char_literal136);

			DebugLocation(124, 26);
			PushFollow(Follow._expressioncommalist_in_object_initializer1215);
			expressioncommalist137=expressioncommalist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expressioncommalist.Add(expressioncommalist137.Tree);
			DebugLocation(124, 46);
			char_literal138=(IToken)Match(input,61,Follow._61_in_object_initializer1217); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_61.Add(char_literal138);



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
			// 124:50: -> ^( PARAMETERS expressioncommalist )
			{
				DebugLocation(124, 53);
				// MathLang.g:124:53: ^( PARAMETERS expressioncommalist )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(124, 55);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_1);

				DebugLocation(124, 66);
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
			TraceOut("object_initializer", 36);
			LeaveRule("object_initializer", 36);
			Leave_object_initializer();
			if (state.backtracking > 0) { Memoize(input, 36, object_initializer_StartIndex); }
		}
		DebugLocation(124, 86);
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
	// MathLang.g:125:1: newexpression : KNEW initializer ;
	[GrammarRule("newexpression")]
	private MathLangParser.newexpression_return newexpression()
	{
		Enter_newexpression();
		EnterRule("newexpression", 37);
		TraceIn("newexpression", 37);
		MathLangParser.newexpression_return retval = new MathLangParser.newexpression_return();
		retval.Start = (IToken)input.LT(1);
		int newexpression_StartIndex = input.Index;
		object root_0 = null;

		IToken KNEW139=null;
		MathLangParser.initializer_return initializer140 = default(MathLangParser.initializer_return);

		object KNEW139_tree=null;

		try { DebugEnterRule(GrammarFileName, "newexpression");
		DebugLocation(125, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 37)) { return retval; }
			// MathLang.g:125:14: ( KNEW initializer )
			DebugEnterAlt(1);
			// MathLang.g:125:16: KNEW initializer
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(125, 20);
			KNEW139=(IToken)Match(input,KNEW,Follow._KNEW_in_newexpression1232); if (state.failed) return retval;
			DebugLocation(125, 22);
			PushFollow(Follow._initializer_in_newexpression1235);
			initializer140=initializer();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, initializer140.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("newexpression", 37);
			LeaveRule("newexpression", 37);
			Leave_newexpression();
			if (state.backtracking > 0) { Memoize(input, 37, newexpression_StartIndex); }
		}
		DebugLocation(125, 32);
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
	// MathLang.g:126:1: initializer : ( simple_var_initializer | array_initializer ) ;
	[GrammarRule("initializer")]
	private MathLangParser.initializer_return initializer()
	{
		Enter_initializer();
		EnterRule("initializer", 38);
		TraceIn("initializer", 38);
		MathLangParser.initializer_return retval = new MathLangParser.initializer_return();
		retval.Start = (IToken)input.LT(1);
		int initializer_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.simple_var_initializer_return simple_var_initializer141 = default(MathLangParser.simple_var_initializer_return);
		MathLangParser.array_initializer_return array_initializer142 = default(MathLangParser.array_initializer_return);


		try { DebugEnterRule(GrammarFileName, "initializer");
		DebugLocation(126, 57);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 38)) { return retval; }
			// MathLang.g:126:12: ( ( simple_var_initializer | array_initializer ) )
			DebugEnterAlt(1);
			// MathLang.g:126:14: ( simple_var_initializer | array_initializer )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(126, 14);
			// MathLang.g:126:14: ( simple_var_initializer | array_initializer )
			int alt29=2;
			try { DebugEnterSubRule(29);
			try { DebugEnterDecision(29, decisionCanBacktrack[29]);
			int LA29_0 = input.LA(1);

			if ((LA29_0==TYPE))
			{
				int LA29_1 = input.LA(2);

				if ((LA29_1==57))
				{
					alt29=1;
				}
				else if ((LA29_1==ARRAY_DECLARATION_MARK||LA29_1==SQRBL))
				{
					alt29=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 29, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 29, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(29); }
			switch (alt29)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:126:15: simple_var_initializer
				{
				DebugLocation(126, 15);
				PushFollow(Follow._simple_var_initializer_in_initializer1242);
				simple_var_initializer141=simple_var_initializer();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, simple_var_initializer141.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:126:40: array_initializer
				{
				DebugLocation(126, 40);
				PushFollow(Follow._array_initializer_in_initializer1246);
				array_initializer142=array_initializer();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, array_initializer142.Tree);

				}
				break;

			}
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
			TraceOut("initializer", 38);
			LeaveRule("initializer", 38);
			Leave_initializer();
			if (state.backtracking > 0) { Memoize(input, 38, initializer_StartIndex); }
		}
		DebugLocation(126, 57);
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
	// MathLang.g:127:1: simple_var_initializer : type '(' ')' -> ^( NEWVAR type ) ;
	[GrammarRule("simple_var_initializer")]
	private MathLangParser.simple_var_initializer_return simple_var_initializer()
	{
		Enter_simple_var_initializer();
		EnterRule("simple_var_initializer", 39);
		TraceIn("simple_var_initializer", 39);
		MathLangParser.simple_var_initializer_return retval = new MathLangParser.simple_var_initializer_return();
		retval.Start = (IToken)input.LT(1);
		int simple_var_initializer_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal144=null;
		IToken char_literal145=null;
		MathLangParser.type_return type143 = default(MathLangParser.type_return);

		object char_literal144_tree=null;
		object char_literal145_tree=null;
		RewriteRuleITokenStream stream_58=new RewriteRuleITokenStream(adaptor,"token 58");
		RewriteRuleITokenStream stream_57=new RewriteRuleITokenStream(adaptor,"token 57");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "simple_var_initializer");
		DebugLocation(127, 54);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 39)) { return retval; }
			// MathLang.g:127:23: ( type '(' ')' -> ^( NEWVAR type ) )
			DebugEnterAlt(1);
			// MathLang.g:127:25: type '(' ')'
			{
			DebugLocation(127, 25);
			PushFollow(Follow._type_in_simple_var_initializer1253);
			type143=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type143.Tree);
			DebugLocation(127, 30);
			char_literal144=(IToken)Match(input,57,Follow._57_in_simple_var_initializer1255); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_57.Add(char_literal144);

			DebugLocation(127, 34);
			char_literal145=(IToken)Match(input,58,Follow._58_in_simple_var_initializer1257); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_58.Add(char_literal145);



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
			// 127:38: -> ^( NEWVAR type )
			{
				DebugLocation(127, 41);
				// MathLang.g:127:41: ^( NEWVAR type )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(127, 43);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(NEWVAR, "NEWVAR"), root_1);

				DebugLocation(127, 50);
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
			TraceOut("simple_var_initializer", 39);
			LeaveRule("simple_var_initializer", 39);
			Leave_simple_var_initializer();
			if (state.backtracking > 0) { Memoize(input, 39, simple_var_initializer_StartIndex); }
		}
		DebugLocation(127, 54);
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
	// MathLang.g:128:1: array_initializer : type ( ( '[' number ']' ) | ARRAY_DECLARATION_MARK ) ( object_initializer )? -> ^( ARRAY_INITIALIZER type ( number )? ( object_initializer )? ) ;
	[GrammarRule("array_initializer")]
	private MathLangParser.array_initializer_return array_initializer()
	{
		Enter_array_initializer();
		EnterRule("array_initializer", 40);
		TraceIn("array_initializer", 40);
		MathLangParser.array_initializer_return retval = new MathLangParser.array_initializer_return();
		retval.Start = (IToken)input.LT(1);
		int array_initializer_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal147=null;
		IToken char_literal149=null;
		IToken ARRAY_DECLARATION_MARK150=null;
		MathLangParser.type_return type146 = default(MathLangParser.type_return);
		MathLangParser.number_return number148 = default(MathLangParser.number_return);
		MathLangParser.object_initializer_return object_initializer151 = default(MathLangParser.object_initializer_return);

		object char_literal147_tree=null;
		object char_literal149_tree=null;
		object ARRAY_DECLARATION_MARK150_tree=null;
		RewriteRuleITokenStream stream_ARRAY_DECLARATION_MARK=new RewriteRuleITokenStream(adaptor,"token ARRAY_DECLARATION_MARK");
		RewriteRuleITokenStream stream_SQRBR=new RewriteRuleITokenStream(adaptor,"token SQRBR");
		RewriteRuleITokenStream stream_SQRBL=new RewriteRuleITokenStream(adaptor,"token SQRBL");
		RewriteRuleSubtreeStream stream_number=new RewriteRuleSubtreeStream(adaptor,"rule number");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		RewriteRuleSubtreeStream stream_object_initializer=new RewriteRuleSubtreeStream(adaptor,"rule object_initializer");
		try { DebugEnterRule(GrammarFileName, "array_initializer");
		DebugLocation(128, 144);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 40)) { return retval; }
			// MathLang.g:128:18: ( type ( ( '[' number ']' ) | ARRAY_DECLARATION_MARK ) ( object_initializer )? -> ^( ARRAY_INITIALIZER type ( number )? ( object_initializer )? ) )
			DebugEnterAlt(1);
			// MathLang.g:128:20: type ( ( '[' number ']' ) | ARRAY_DECLARATION_MARK ) ( object_initializer )?
			{
			DebugLocation(128, 20);
			PushFollow(Follow._type_in_array_initializer1271);
			type146=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type146.Tree);
			DebugLocation(128, 25);
			// MathLang.g:128:25: ( ( '[' number ']' ) | ARRAY_DECLARATION_MARK )
			int alt30=2;
			try { DebugEnterSubRule(30);
			try { DebugEnterDecision(30, decisionCanBacktrack[30]);
			int LA30_0 = input.LA(1);

			if ((LA30_0==SQRBL))
			{
				alt30=1;
			}
			else if ((LA30_0==ARRAY_DECLARATION_MARK))
			{
				alt30=2;
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
				// MathLang.g:128:26: ( '[' number ']' )
				{
				DebugLocation(128, 26);
				// MathLang.g:128:26: ( '[' number ']' )
				DebugEnterAlt(1);
				// MathLang.g:128:27: '[' number ']'
				{
				DebugLocation(128, 27);
				char_literal147=(IToken)Match(input,SQRBL,Follow._SQRBL_in_array_initializer1275); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_SQRBL.Add(char_literal147);

				DebugLocation(128, 31);
				PushFollow(Follow._number_in_array_initializer1277);
				number148=number();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_number.Add(number148.Tree);
				DebugLocation(128, 38);
				char_literal149=(IToken)Match(input,SQRBR,Follow._SQRBR_in_array_initializer1279); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_SQRBR.Add(char_literal149);


				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:128:45: ARRAY_DECLARATION_MARK
				{
				DebugLocation(128, 45);
				ARRAY_DECLARATION_MARK150=(IToken)Match(input,ARRAY_DECLARATION_MARK,Follow._ARRAY_DECLARATION_MARK_in_array_initializer1284); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ARRAY_DECLARATION_MARK.Add(ARRAY_DECLARATION_MARK150);


				}
				break;

			}
			} finally { DebugExitSubRule(30); }

			DebugLocation(128, 69);
			// MathLang.g:128:69: ( object_initializer )?
			int alt31=2;
			try { DebugEnterSubRule(31);
			try { DebugEnterDecision(31, decisionCanBacktrack[31]);
			int LA31_0 = input.LA(1);

			if ((LA31_0==60))
			{
				alt31=1;
			}
			} finally { DebugExitDecision(31); }
			switch (alt31)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: object_initializer
				{
				DebugLocation(128, 69);
				PushFollow(Follow._object_initializer_in_array_initializer1287);
				object_initializer151=object_initializer();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_object_initializer.Add(object_initializer151.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(31); }



			{
			// AST REWRITE
			// elements: number, type, object_initializer
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 128:89: -> ^( ARRAY_INITIALIZER type ( number )? ( object_initializer )? )
			{
				DebugLocation(128, 92);
				// MathLang.g:128:92: ^( ARRAY_INITIALIZER type ( number )? ( object_initializer )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(128, 94);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAY_INITIALIZER, "ARRAY_INITIALIZER"), root_1);

				DebugLocation(128, 112);
				adaptor.AddChild(root_1, stream_type.NextTree());
				DebugLocation(128, 117);
				// MathLang.g:128:117: ( number )?
				if ( stream_number.HasNext )
				{
					DebugLocation(128, 117);
					adaptor.AddChild(root_1, stream_number.NextTree());

				}
				stream_number.Reset();
				DebugLocation(128, 125);
				// MathLang.g:128:125: ( object_initializer )?
				if ( stream_object_initializer.HasNext )
				{
					DebugLocation(128, 125);
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
			TraceOut("array_initializer", 40);
			LeaveRule("array_initializer", 40);
			Leave_array_initializer();
			if (state.backtracking > 0) { Memoize(input, 40, array_initializer_StartIndex); }
		}
		DebugLocation(128, 144);
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
	// MathLang.g:130:1: block : '{' statementlist '}' ;
	[GrammarRule("block")]
	private MathLangParser.block_return block()
	{
		Enter_block();
		EnterRule("block", 41);
		TraceIn("block", 41);
		MathLangParser.block_return retval = new MathLangParser.block_return();
		retval.Start = (IToken)input.LT(1);
		int block_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal152=null;
		IToken char_literal154=null;
		MathLangParser.statementlist_return statementlist153 = default(MathLangParser.statementlist_return);

		object char_literal152_tree=null;
		object char_literal154_tree=null;

		try { DebugEnterRule(GrammarFileName, "block");
		DebugLocation(130, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 41)) { return retval; }
			// MathLang.g:130:6: ( '{' statementlist '}' )
			DebugEnterAlt(1);
			// MathLang.g:130:8: '{' statementlist '}'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(130, 11);
			char_literal152=(IToken)Match(input,60,Follow._60_in_block1309); if (state.failed) return retval;
			DebugLocation(130, 13);
			PushFollow(Follow._statementlist_in_block1312);
			statementlist153=statementlist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementlist153.Tree);
			DebugLocation(130, 30);
			char_literal154=(IToken)Match(input,61,Follow._61_in_block1314); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("block", 41);
			LeaveRule("block", 41);
			Leave_block();
			if (state.backtracking > 0) { Memoize(input, 41, block_StartIndex); }
		}
		DebugLocation(130, 30);
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
	// MathLang.g:132:1: statementlist : ( statement )* -> ^( BLOCK ( statement )* ) ;
	[GrammarRule("statementlist")]
	private MathLangParser.statementlist_return statementlist()
	{
		Enter_statementlist();
		EnterRule("statementlist", 42);
		TraceIn("statementlist", 42);
		MathLangParser.statementlist_return retval = new MathLangParser.statementlist_return();
		retval.Start = (IToken)input.LT(1);
		int statementlist_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.statement_return statement155 = default(MathLangParser.statement_return);

		RewriteRuleSubtreeStream stream_statement=new RewriteRuleSubtreeStream(adaptor,"rule statement");
		try { DebugEnterRule(GrammarFileName, "statementlist");
		DebugLocation(132, 49);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 42)) { return retval; }
			// MathLang.g:132:14: ( ( statement )* -> ^( BLOCK ( statement )* ) )
			DebugEnterAlt(1);
			// MathLang.g:132:16: ( statement )*
			{
			DebugLocation(132, 16);
			// MathLang.g:132:16: ( statement )*
			try { DebugEnterSubRule(32);
			while (true)
			{
				int alt32=2;
				try { DebugEnterDecision(32, decisionCanBacktrack[32]);
				int LA32_0 = input.LA(1);

				if ((LA32_0==IF||LA32_0==FOR||(LA32_0>=RETURN && LA32_0<=WHILE)||LA32_0==TYPE||LA32_0==VOID||LA32_0==ID||LA32_0==KNEW))
				{
					alt32=1;
				}


				} finally { DebugExitDecision(32); }
				switch ( alt32 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: statement
					{
					DebugLocation(132, 16);
					PushFollow(Follow._statement_in_statementlist1322);
					statement155=statement();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_statement.Add(statement155.Tree);

					}
					break;

				default:
					goto loop32;
				}
			}

			loop32:
				;

			} finally { DebugExitSubRule(32); }



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
			// 132:27: -> ^( BLOCK ( statement )* )
			{
				DebugLocation(132, 30);
				// MathLang.g:132:30: ^( BLOCK ( statement )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(132, 32);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

				DebugLocation(132, 38);
				// MathLang.g:132:38: ( statement )*
				while ( stream_statement.HasNext )
				{
					DebugLocation(132, 38);
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
			TraceOut("statementlist", 42);
			LeaveRule("statementlist", 42);
			Leave_statementlist();
			if (state.backtracking > 0) { Memoize(input, 42, statementlist_StartIndex); }
		}
		DebugLocation(132, 49);
		} finally { DebugExitRule(GrammarFileName, "statementlist"); }
		return retval;

	}
	// $ANTLR end "statementlist"

	partial void Enter_synpred16_MathLang_fragment();
	partial void Leave_synpred16_MathLang_fragment();

	// $ANTLR start synpred16_MathLang
	public void synpred16_MathLang_fragment()
	{
		Enter_synpred16_MathLang_fragment();
		EnterRule("synpred16_MathLang_fragment", 58);
		TraceIn("synpred16_MathLang_fragment", 58);
		try
		{
			// MathLang.g:74:5: ( funccallbody )
			DebugEnterAlt(1);
			// MathLang.g:74:5: funccallbody
			{
			DebugLocation(74, 5);
			PushFollow(Follow._funccallbody_in_synpred16_MathLang517);
			funccallbody();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred16_MathLang_fragment", 58);
			LeaveRule("synpred16_MathLang_fragment", 58);
			Leave_synpred16_MathLang_fragment();
		}
	}
	// $ANTLR end synpred16_MathLang

	partial void Enter_synpred17_MathLang_fragment();
	partial void Leave_synpred17_MathLang_fragment();

	// $ANTLR start synpred17_MathLang
	public void synpred17_MathLang_fragment()
	{
		Enter_synpred17_MathLang_fragment();
		EnterRule("synpred17_MathLang_fragment", 59);
		TraceIn("synpred17_MathLang_fragment", 59);
		try
		{
			// MathLang.g:75:5: ( boolexpression )
			DebugEnterAlt(1);
			// MathLang.g:75:5: boolexpression
			{
			DebugLocation(75, 5);
			PushFollow(Follow._boolexpression_in_synpred17_MathLang523);
			boolexpression();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred17_MathLang_fragment", 59);
			LeaveRule("synpred17_MathLang_fragment", 59);
			Leave_synpred17_MathLang_fragment();
		}
	}
	// $ANTLR end synpred17_MathLang

	partial void Enter_synpred30_MathLang_fragment();
	partial void Leave_synpred30_MathLang_fragment();

	// $ANTLR start synpred30_MathLang
	public void synpred30_MathLang_fragment()
	{
		Enter_synpred30_MathLang_fragment();
		EnterRule("synpred30_MathLang_fragment", 72);
		TraceIn("synpred30_MathLang_fragment", 72);
		try
		{
			// MathLang.g:94:16: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )
			DebugEnterAlt(1);
			// MathLang.g:94:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
			{
			DebugLocation(94, 16);
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

			DebugLocation(94, 53);
			PushFollow(Follow._add_in_synpred30_MathLang770);
			add();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred30_MathLang_fragment", 72);
			LeaveRule("synpred30_MathLang_fragment", 72);
			Leave_synpred30_MathLang_fragment();
		}
	}
	// $ANTLR end synpred30_MathLang

	partial void Enter_synpred39_MathLang_fragment();
	partial void Leave_synpred39_MathLang_fragment();

	// $ANTLR start synpred39_MathLang
	public void synpred39_MathLang_fragment()
	{
		Enter_synpred39_MathLang_fragment();
		EnterRule("synpred39_MathLang_fragment", 81);
		TraceIn("synpred39_MathLang_fragment", 81);
		try
		{
			// MathLang.g:106:22: ( '(' boolterm ')' )
			DebugEnterAlt(1);
			// MathLang.g:106:22: '(' boolterm ')'
			{
			DebugLocation(106, 22);
			Match(input,57,Follow._57_in_synpred39_MathLang930); if (state.failed) return;
			DebugLocation(106, 27);
			PushFollow(Follow._boolterm_in_synpred39_MathLang933);
			boolterm();
			PopFollow();
			if (state.failed) return;
			DebugLocation(106, 36);
			Match(input,58,Follow._58_in_synpred39_MathLang935); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred39_MathLang_fragment", 81);
			LeaveRule("synpred39_MathLang_fragment", 81);
			Leave_synpred39_MathLang_fragment();
		}
	}
	// $ANTLR end synpred39_MathLang

	partial void Enter_synpred44_MathLang_fragment();
	partial void Leave_synpred44_MathLang_fragment();

	// $ANTLR start synpred44_MathLang
	public void synpred44_MathLang_fragment()
	{
		Enter_synpred44_MathLang_fragment();
		EnterRule("synpred44_MathLang_fragment", 86);
		TraceIn("synpred44_MathLang_fragment", 86);
		try
		{
			// MathLang.g:111:64: ( ELSE ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:111:64: ELSE ( block | statement )
			{
			DebugLocation(111, 64);
			Match(input,ELSE,Follow._ELSE_in_synpred44_MathLang987); if (state.failed) return;
			DebugLocation(111, 70);
			// MathLang.g:111:70: ( block | statement )
			int alt34=2;
			try { DebugEnterSubRule(34);
			try { DebugEnterDecision(34, decisionCanBacktrack[34]);
			int LA34_0 = input.LA(1);

			if ((LA34_0==60))
			{
				alt34=1;
			}
			else if ((LA34_0==IF||LA34_0==FOR||(LA34_0>=RETURN && LA34_0<=WHILE)||LA34_0==TYPE||LA34_0==VOID||LA34_0==ID||LA34_0==KNEW))
			{
				alt34=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				NoViableAltException nvae = new NoViableAltException("", 34, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(34); }
			switch (alt34)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:111:71: block
				{
				DebugLocation(111, 71);
				PushFollow(Follow._block_in_synpred44_MathLang991);
				block();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:111:79: statement
				{
				DebugLocation(111, 79);
				PushFollow(Follow._statement_in_synpred44_MathLang995);
				statement();
				PopFollow();
				if (state.failed) return;

				}
				break;

			}
			} finally { DebugExitSubRule(34); }


			}

		}
		finally
		{
			TraceOut("synpred44_MathLang_fragment", 86);
			LeaveRule("synpred44_MathLang_fragment", 86);
			Leave_synpred44_MathLang_fragment();
		}
	}
	// $ANTLR end synpred44_MathLang
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
			"\xF\xFFFF";
		private const string DFA1_eofS =
			"\xF\xFFFF";
		private const string DFA1_minS =
			"\x1\x7\x1\x1D\x1\x22\x6\xFFFF\x1\x20\x1\x22\x2\xFFFF\x1\x22\x1\xFFFF";
		private const string DFA1_maxS =
			"\x1\x32\x1\x20\x1\x39\x6\xFFFF\x1\x20\x1\x39\x2\xFFFF\x1\x39\x1\xFFFF";
		private const string DFA1_acceptS =
			"\x3\xFFFF\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x1\x9\x2\xFFFF\x1\x2\x1\x8\x1"+
			"\xFFFF\x1\x1";
		private const string DFA1_specialS =
			"\xF\xFFFF}>";
		private static readonly string[] DFA1_transitionS =
			{
				"\x1\x3\x1\xFFFF\x1\x5\x1\xFFFF\x1\x7\x1\x4\xF\xFFFF\x1\x1\x1\xFFFF"+
				"\x1\x6\x1\xFFFF\x1\x2\x11\xFFFF\x1\x8",
				"\x1\x9\x2\xFFFF\x1\xA",
				"\x1\xB\x10\xFFFF\x1\xB\x5\xFFFF\x1\xC",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\xD",
				"\x1\xE\x15\xFFFF\x1\xE\x1\x6",
				"",
				"",
				"\x1\xE\x15\xFFFF\x1\xE\x1\x6",
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

		public override string Description { get { return "52:12: ( declaration | assignment | ifstatement | whilestatement | forstatement | funcdeclaration | returnstatement | funccall | newexpression )"; } }

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
			"\x1\x1F\x1\xFFFF\x1\x0\x1\xFFFF\x1\x0\x2\xFFFF\x3\x0\x2\xFFFF";
		private const string DFA4_maxS =
			"\x1\x39\x1\xFFFF\x1\x0\x1\xFFFF\x1\x0\x2\xFFFF\x3\x0\x2\xFFFF";
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

		public override string Description { get { return "72:1: expression : ( newexpression | funccallbody | boolexpression | mathexpression );"; } }

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
				if ( (EvaluatePredicate(synpred16_MathLang_fragment)) ) {s = 10;}

				else if ( (EvaluatePredicate(synpred17_MathLang_fragment)) ) {s = 3;}

				else if ( (true) ) {s = 11;}


				input.Seek(index4_2);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA4_4 = input.LA(1);


				int index4_4 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred17_MathLang_fragment)) ) {s = 3;}

				else if ( (true) ) {s = 11;}


				input.Seek(index4_4);
				if ( s>=0 ) return s;
				break;
			case 2:
				int LA4_7 = input.LA(1);


				int index4_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred17_MathLang_fragment)) ) {s = 3;}

				else if ( (true) ) {s = 11;}


				input.Seek(index4_7);
				if ( s>=0 ) return s;
				break;
			case 3:
				int LA4_8 = input.LA(1);


				int index4_8 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred17_MathLang_fragment)) ) {s = 3;}

				else if ( (true) ) {s = 11;}


				input.Seek(index4_8);
				if ( s>=0 ) return s;
				break;
			case 4:
				int LA4_9 = input.LA(1);


				int index4_9 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred17_MathLang_fragment)) ) {s = 3;}

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
			"\x1\x27\x1\x0\x8\xFFFF";
		private const string DFA10_maxS =
			"\x1\x3D\x1\x0\x8\xFFFF";
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

		public override string Description { get { return "94:14: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?"; } }

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
				if ( (EvaluatePredicate(synpred30_MathLang_fragment)) ) {s = 4;}

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
		public static readonly BitSet _statementlist_in_execute372 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_execute374 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declaration_in_statement385 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assignment_in_statement391 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ifstatement_in_statement396 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _whilestatement_in_statement401 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _forstatement_in_statement406 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funcdeclaration_in_statement411 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _returnstatement_in_statement416 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccall_in_statement421 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _newexpression_in_statement426 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_type435 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_array_type442 = new BitSet(new ulong[]{0x20000000UL});
		public static readonly BitSet _ARRAY_DECLARATION_MARK_in_array_type444 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_any_type451 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_type_in_any_type455 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _VOID_in_any_type459 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NUMBER_in_number467 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_number473 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_number479 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CHAR_in_number485 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrayelement_in_number491 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _term_in_mathexpression497 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _newexpression_in_expression511 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_expression517 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolexpression_in_expression523 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathexpression_in_expression529 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_arrayelement541 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _SQRBL_in_arrayelement543 = new BitSet(new ulong[]{0x380000000UL});
		public static readonly BitSet _number_in_arrayelement545 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _SQRBR_in_arrayelement547 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declarationbody_in_declaration565 = new BitSet(new ulong[]{0x100000000000000UL});
		public static readonly BitSet _56_in_declaration567 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _longdeclaration_in_declaration575 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_declarationbody583 = new BitSet(new ulong[]{0x100000000UL});
		public static readonly BitSet _ID_in_declarationbody585 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_type_in_declarationbody606 = new BitSet(new ulong[]{0x100000000UL});
		public static readonly BitSet _ID_in_declarationbody608 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _longdeclarationbody_in_longdeclaration630 = new BitSet(new ulong[]{0x100000000000000UL});
		public static readonly BitSet _56_in_longdeclaration632 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_longdeclarationbody641 = new BitSet(new ulong[]{0x100000000UL});
		public static readonly BitSet _ID_in_longdeclarationbody643 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _ASSIGN_in_longdeclarationbody645 = new BitSet(new ulong[]{0x207801380000000UL});
		public static readonly BitSet _expression_in_longdeclarationbody647 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_type_in_longdeclarationbody671 = new BitSet(new ulong[]{0x100000000UL});
		public static readonly BitSet _ID_in_longdeclarationbody673 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _ASSIGN_in_longdeclarationbody675 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _newexpression_in_longdeclarationbody677 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mul_in_add697 = new BitSet(new ulong[]{0x1800000002UL});
		public static readonly BitSet _set_in_add701 = new BitSet(new ulong[]{0x203801380000000UL});
		public static readonly BitSet _mul_in_add710 = new BitSet(new ulong[]{0x1800000002UL});
		public static readonly BitSet _group_in_mul719 = new BitSet(new ulong[]{0x6000000002UL});
		public static readonly BitSet _set_in_mul723 = new BitSet(new ulong[]{0x203801380000000UL});
		public static readonly BitSet _group_in_mul732 = new BitSet(new ulong[]{0x6000000002UL});
		public static readonly BitSet _add_in_compare740 = new BitSet(new ulong[]{0x1F8000000002UL});
		public static readonly BitSet _set_in_compare744 = new BitSet(new ulong[]{0x203801380000000UL});
		public static readonly BitSet _add_in_compare770 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _add_in_term781 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _SUB_in_group788 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _57_in_group793 = new BitSet(new ulong[]{0x207801380000000UL});
		public static readonly BitSet _term_in_group796 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_group798 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _number_in_group803 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assignmentbody_in_assignment810 = new BitSet(new ulong[]{0x100000000000000UL});
		public static readonly BitSet _56_in_assignment812 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_assignmentbody820 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _ASSIGN_in_assignmentbody822 = new BitSet(new ulong[]{0x207801380000000UL});
		public static readonly BitSet _expression_in_assignmentbody824 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrayelement_in_assignmentbody843 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _ASSIGN_in_assignmentbody845 = new BitSet(new ulong[]{0x207801380000000UL});
		public static readonly BitSet _expression_in_assignmentbody847 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolterm_in_boolexpression865 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _or_in_boolterm872 = new BitSet(new ulong[]{0x60000000002UL});
		public static readonly BitSet _set_in_boolterm876 = new BitSet(new ulong[]{0x203801380000000UL});
		public static readonly BitSet _or_in_boolterm885 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _and_in_or894 = new BitSet(new ulong[]{0x200000000002UL});
		public static readonly BitSet _OR_in_or897 = new BitSet(new ulong[]{0x203801380000000UL});
		public static readonly BitSet _and_in_or900 = new BitSet(new ulong[]{0x200000000002UL});
		public static readonly BitSet _boolgroup_in_and908 = new BitSet(new ulong[]{0x400000000002UL});
		public static readonly BitSet _AND_in_and911 = new BitSet(new ulong[]{0x203801380000000UL});
		public static readonly BitSet _boolgroup_in_and914 = new BitSet(new ulong[]{0x400000000002UL});
		public static readonly BitSet _NOT_in_boolgroup923 = new BitSet(new ulong[]{0x203801380000000UL});
		public static readonly BitSet _57_in_boolgroup930 = new BitSet(new ulong[]{0x203801380000000UL});
		public static readonly BitSet _boolterm_in_boolgroup933 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_boolgroup935 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolvar_in_boolgroup940 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TRUE_in_boolvar948 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FALSE_in_boolvar954 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _compare_in_boolvar960 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_ifstatement967 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _57_in_ifstatement970 = new BitSet(new ulong[]{0x203801380000000UL});
		public static readonly BitSet _boolexpression_in_ifstatement973 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_ifstatement975 = new BitSet(new ulong[]{0x10040003D0001A80UL});
		public static readonly BitSet _block_in_ifstatement979 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement983 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _ELSE_in_ifstatement987 = new BitSet(new ulong[]{0x10040003D0001A80UL});
		public static readonly BitSet _block_in_ifstatement991 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement995 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _WHILE_in_whilestatement1005 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _57_in_whilestatement1008 = new BitSet(new ulong[]{0x203801380000000UL});
		public static readonly BitSet _boolexpression_in_whilestatement1011 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_whilestatement1013 = new BitSet(new ulong[]{0x10040003D0001A80UL});
		public static readonly BitSet _block_in_whilestatement1017 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_whilestatement1021 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_forstatement1028 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _57_in_forstatement1031 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _longdeclarationbody_in_forstatement1034 = new BitSet(new ulong[]{0x100000000000000UL});
		public static readonly BitSet _56_in_forstatement1036 = new BitSet(new ulong[]{0x203801380000000UL});
		public static readonly BitSet _boolexpression_in_forstatement1039 = new BitSet(new ulong[]{0x100000000000000UL});
		public static readonly BitSet _56_in_forstatement1041 = new BitSet(new ulong[]{0x380000000UL});
		public static readonly BitSet _assignmentbody_in_forstatement1044 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_forstatement1046 = new BitSet(new ulong[]{0x10040003D0001A80UL});
		public static readonly BitSet _block_in_forstatement1050 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_forstatement1054 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _RETURN_in_returnstatement1061 = new BitSet(new ulong[]{0x207801380000000UL});
		public static readonly BitSet _expression_in_returnstatement1064 = new BitSet(new ulong[]{0x100000000000000UL});
		public static readonly BitSet _56_in_returnstatement1066 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _any_type_in_funcdeclaration1075 = new BitSet(new ulong[]{0x100000000UL});
		public static readonly BitSet _ID_in_funcdeclaration1077 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _57_in_funcdeclaration1080 = new BitSet(new ulong[]{0x400000010000000UL});
		public static readonly BitSet _paramsdeclaration_in_funcdeclaration1083 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_funcdeclaration1086 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _block_in_funcdeclaration1089 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declarationbody_in_paramsdeclaration1122 = new BitSet(new ulong[]{0x800000000000002UL});
		public static readonly BitSet _59_in_paramsdeclaration1126 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _declarationbody_in_paramsdeclaration1129 = new BitSet(new ulong[]{0x800000000000002UL});
		public static readonly BitSet _ID_in_funccallbody1154 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _57_in_funccallbody1157 = new BitSet(new ulong[]{0x607801380000000UL});
		public static readonly BitSet _expressioncommalist_in_funccallbody1159 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_funccallbody1162 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_funccall1185 = new BitSet(new ulong[]{0x100000000000000UL});
		public static readonly BitSet _56_in_funccall1187 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_expressioncommalist1194 = new BitSet(new ulong[]{0x800000000000002UL});
		public static readonly BitSet _59_in_expressioncommalist1198 = new BitSet(new ulong[]{0x207801380000000UL});
		public static readonly BitSet _expression_in_expressioncommalist1201 = new BitSet(new ulong[]{0x800000000000002UL});
		public static readonly BitSet _60_in_object_initializer1213 = new BitSet(new ulong[]{0x207801380000000UL});
		public static readonly BitSet _expressioncommalist_in_object_initializer1215 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _61_in_object_initializer1217 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _KNEW_in_newexpression1232 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _initializer_in_newexpression1235 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _simple_var_initializer_in_initializer1242 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_initializer_in_initializer1246 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_simple_var_initializer1253 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _57_in_simple_var_initializer1255 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_simple_var_initializer1257 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_array_initializer1271 = new BitSet(new ulong[]{0x8000020000000UL});
		public static readonly BitSet _SQRBL_in_array_initializer1275 = new BitSet(new ulong[]{0x380000000UL});
		public static readonly BitSet _number_in_array_initializer1277 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _SQRBR_in_array_initializer1279 = new BitSet(new ulong[]{0x1000000000000002UL});
		public static readonly BitSet _ARRAY_DECLARATION_MARK_in_array_initializer1284 = new BitSet(new ulong[]{0x1000000000000002UL});
		public static readonly BitSet _object_initializer_in_array_initializer1287 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _60_in_block1309 = new BitSet(new ulong[]{0x30040003D0001A80UL});
		public static readonly BitSet _statementlist_in_block1312 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _61_in_block1314 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_statementlist1322 = new BitSet(new ulong[]{0x10040003D0001A82UL});
		public static readonly BitSet _funccallbody_in_synpred16_MathLang517 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolexpression_in_synpred17_MathLang523 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_synpred30_MathLang744 = new BitSet(new ulong[]{0x203801380000000UL});
		public static readonly BitSet _add_in_synpred30_MathLang770 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _57_in_synpred39_MathLang930 = new BitSet(new ulong[]{0x203801380000000UL});
		public static readonly BitSet _boolterm_in_synpred39_MathLang933 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_synpred39_MathLang935 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ELSE_in_synpred44_MathLang987 = new BitSet(new ulong[]{0x10040003D0001A80UL});
		public static readonly BitSet _block_in_synpred44_MathLang991 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_synpred44_MathLang995 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  MathLang 

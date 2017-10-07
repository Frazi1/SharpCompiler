// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-10-07 22:54:56

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "UNKNOWN", "PRINT", "INPUT", "IF", "ELSE", "FOR", "FUNCTION", "RETURN", "WHILE", "DO", "BLOCK", "PROGRAM", "PARAMS", "VARDECLARATION", "FUNCDECLARATION", "ARRAYDECLARATION", "VARASSIGNMENT", "ARRAYELEMENTASSIGNMENT", "ARRAYELEMENT", "NEWVAR", "ARRAY_INITIALIZER", "OBJECT_INITIALIZER", "FUNC_CALL", "RETURN_TYPE", "PARAMETERS", "TYPE", "ARRAY_DECLARATION_MARK", "VOID", "NUMBER", "ID", "CHAR", "ASSIGN", "ADD", "SUB", "MUL", "DIV", "GREQ", "LSEQ", "NEQ", "EQ", "GR", "LS", "OR", "AND", "NOT", "TRUE", "FALSE", "KNEW", "CONSOLE_WORD", "SQRBL", "SQRBR", "WS", "SL_COMMENT", "ML_COMMENT", "';'", "'('", "')'", "'()'", "','", "'{'", "'}'", "'.'", "'WriteLine'", "'Write'", "'ReadLine'", "'Read'"
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
				false, false, false, false, true, false, false, false, false, false, 
				true, false, false, false, false, false, false, false, true, false, 
				false, false, true, false, false, false, false, false, false, false, 
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
		this.state.ruleMemo = new System.Collections.Generic.Dictionary<int, int>[109+1];

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
	// MathLang.g:48:8: public execute : func_list EOF ;
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
		MathLangParser.func_list_return func_list1 = default(MathLangParser.func_list_return);

		object EOF2_tree=null;

		try { DebugEnterRule(GrammarFileName, "execute");
		DebugLocation(48, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 1)) { return retval; }
			// MathLang.g:48:15: ( func_list EOF )
			DebugEnterAlt(1);
			// MathLang.g:49:2: func_list EOF
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(49, 2);
			PushFollow(Follow._func_list_in_execute385);
			func_list1=func_list();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, func_list1.Tree);
			DebugLocation(49, 15);
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

	public class func_list_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_func_list();
	partial void Leave_func_list();

	// $ANTLR start "func_list"
	// MathLang.g:52:1: func_list : ( funcdeclaration )* -> ^( PROGRAM ( funcdeclaration )* ) ;
	[GrammarRule("func_list")]
	private MathLangParser.func_list_return func_list()
	{
		Enter_func_list();
		EnterRule("func_list", 2);
		TraceIn("func_list", 2);
		MathLangParser.func_list_return retval = new MathLangParser.func_list_return();
		retval.Start = (IToken)input.LT(1);
		int func_list_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.funcdeclaration_return funcdeclaration3 = default(MathLangParser.funcdeclaration_return);

		RewriteRuleSubtreeStream stream_funcdeclaration=new RewriteRuleSubtreeStream(adaptor,"rule funcdeclaration");
		try { DebugEnterRule(GrammarFileName, "func_list");
		DebugLocation(52, 61);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 2)) { return retval; }
			// MathLang.g:52:11: ( ( funcdeclaration )* -> ^( PROGRAM ( funcdeclaration )* ) )
			DebugEnterAlt(1);
			// MathLang.g:52:13: ( funcdeclaration )*
			{
			DebugLocation(52, 13);
			// MathLang.g:52:13: ( funcdeclaration )*
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, decisionCanBacktrack[1]);
				int LA1_0 = input.LA(1);

				if ((LA1_0==TYPE||LA1_0==VOID))
				{
					alt1=1;
				}


				} finally { DebugExitDecision(1); }
				switch ( alt1 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: funcdeclaration
					{
					DebugLocation(52, 13);
					PushFollow(Follow._funcdeclaration_in_func_list397);
					funcdeclaration3=funcdeclaration();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_funcdeclaration.Add(funcdeclaration3.Tree);

					}
					break;

				default:
					goto loop1;
				}
			}

			loop1:
				;

			} finally { DebugExitSubRule(1); }



			{
			// AST REWRITE
			// elements: funcdeclaration
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 52:30: -> ^( PROGRAM ( funcdeclaration )* )
			{
				DebugLocation(52, 33);
				// MathLang.g:52:33: ^( PROGRAM ( funcdeclaration )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(52, 35);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROGRAM, "PROGRAM"), root_1);

				DebugLocation(52, 43);
				// MathLang.g:52:43: ( funcdeclaration )*
				while ( stream_funcdeclaration.HasNext )
				{
					DebugLocation(52, 43);
					adaptor.AddChild(root_1, stream_funcdeclaration.NextTree());

				}
				stream_funcdeclaration.Reset();

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
			TraceOut("func_list", 2);
			LeaveRule("func_list", 2);
			Leave_func_list();
			if (state.backtracking > 0) { Memoize(input, 2, func_list_StartIndex); }
		}
		DebugLocation(52, 61);
		} finally { DebugExitRule(GrammarFileName, "func_list"); }
		return retval;

	}
	// $ANTLR end "func_list"

	public class statement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_statement();
	partial void Leave_statement();

	// $ANTLR start "statement"
	// MathLang.g:54:1: statement : ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | returnstatement | funccall | newexpression | console_write_statement | console_read_statement ) ;
	[GrammarRule("statement")]
	private MathLangParser.statement_return statement()
	{
		Enter_statement();
		EnterRule("statement", 3);
		TraceIn("statement", 3);
		MathLangParser.statement_return retval = new MathLangParser.statement_return();
		retval.Start = (IToken)input.LT(1);
		int statement_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.declaration_return declaration4 = default(MathLangParser.declaration_return);
		MathLangParser.assignment_return assignment5 = default(MathLangParser.assignment_return);
		MathLangParser.ifstatement_return ifstatement6 = default(MathLangParser.ifstatement_return);
		MathLangParser.whilestatement_return whilestatement7 = default(MathLangParser.whilestatement_return);
		MathLangParser.dowhilestatement_return dowhilestatement8 = default(MathLangParser.dowhilestatement_return);
		MathLangParser.forstatement_return forstatement9 = default(MathLangParser.forstatement_return);
		MathLangParser.returnstatement_return returnstatement10 = default(MathLangParser.returnstatement_return);
		MathLangParser.funccall_return funccall11 = default(MathLangParser.funccall_return);
		MathLangParser.newexpression_return newexpression12 = default(MathLangParser.newexpression_return);
		MathLangParser.console_write_statement_return console_write_statement13 = default(MathLangParser.console_write_statement_return);
		MathLangParser.console_read_statement_return console_read_statement14 = default(MathLangParser.console_read_statement_return);


		try { DebugEnterRule(GrammarFileName, "statement");
		DebugLocation(54, 28);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 3)) { return retval; }
			// MathLang.g:54:10: ( ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | returnstatement | funccall | newexpression | console_write_statement | console_read_statement ) )
			DebugEnterAlt(1);
			// MathLang.g:54:12: ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | returnstatement | funccall | newexpression | console_write_statement | console_read_statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(54, 12);
			// MathLang.g:54:12: ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | returnstatement | funccall | newexpression | console_write_statement | console_read_statement )
			int alt2=11;
			try { DebugEnterSubRule(2);
			try { DebugEnterDecision(2, decisionCanBacktrack[2]);
			try
			{
				alt2 = dfa2.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(2); }
			switch (alt2)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:54:14: declaration
				{
				DebugLocation(54, 14);
				PushFollow(Follow._declaration_in_statement418);
				declaration4=declaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, declaration4.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:55:4: assignment
				{
				DebugLocation(55, 4);
				PushFollow(Follow._assignment_in_statement424);
				assignment5=assignment();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment5.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:56:4: ifstatement
				{
				DebugLocation(56, 4);
				PushFollow(Follow._ifstatement_in_statement429);
				ifstatement6=ifstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ifstatement6.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:57:4: whilestatement
				{
				DebugLocation(57, 4);
				PushFollow(Follow._whilestatement_in_statement434);
				whilestatement7=whilestatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, whilestatement7.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:58:4: dowhilestatement
				{
				DebugLocation(58, 4);
				PushFollow(Follow._dowhilestatement_in_statement439);
				dowhilestatement8=dowhilestatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dowhilestatement8.Tree);

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// MathLang.g:59:4: forstatement
				{
				DebugLocation(59, 4);
				PushFollow(Follow._forstatement_in_statement444);
				forstatement9=forstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forstatement9.Tree);

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// MathLang.g:60:4: returnstatement
				{
				DebugLocation(60, 4);
				PushFollow(Follow._returnstatement_in_statement449);
				returnstatement10=returnstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, returnstatement10.Tree);

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// MathLang.g:61:4: funccall
				{
				DebugLocation(61, 4);
				PushFollow(Follow._funccall_in_statement454);
				funccall11=funccall();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccall11.Tree);

				}
				break;
			case 9:
				DebugEnterAlt(9);
				// MathLang.g:62:4: newexpression
				{
				DebugLocation(62, 4);
				PushFollow(Follow._newexpression_in_statement459);
				newexpression12=newexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, newexpression12.Tree);

				}
				break;
			case 10:
				DebugEnterAlt(10);
				// MathLang.g:63:4: console_write_statement
				{
				DebugLocation(63, 4);
				PushFollow(Follow._console_write_statement_in_statement464);
				console_write_statement13=console_write_statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, console_write_statement13.Tree);

				}
				break;
			case 11:
				DebugEnterAlt(11);
				// MathLang.g:64:4: console_read_statement
				{
				DebugLocation(64, 4);
				PushFollow(Follow._console_read_statement_in_statement469);
				console_read_statement14=console_read_statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, console_read_statement14.Tree);

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
			TraceOut("statement", 3);
			LeaveRule("statement", 3);
			Leave_statement();
			if (state.backtracking > 0) { Memoize(input, 3, statement_StartIndex); }
		}
		DebugLocation(64, 28);
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
	// MathLang.g:66:1: type : TYPE ;
	[GrammarRule("type")]
	private MathLangParser.type_return type()
	{
		Enter_type();
		EnterRule("type", 4);
		TraceIn("type", 4);
		MathLangParser.type_return retval = new MathLangParser.type_return();
		retval.Start = (IToken)input.LT(1);
		int type_StartIndex = input.Index;
		object root_0 = null;

		IToken TYPE15=null;

		object TYPE15_tree=null;

		try { DebugEnterRule(GrammarFileName, "type");
		DebugLocation(66, 11);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 4)) { return retval; }
			// MathLang.g:66:5: ( TYPE )
			DebugEnterAlt(1);
			// MathLang.g:66:7: TYPE
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(66, 7);
			TYPE15=(IToken)Match(input,TYPE,Follow._TYPE_in_type479); if (state.failed) return retval;
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
			TraceOut("type", 4);
			LeaveRule("type", 4);
			Leave_type();
			if (state.backtracking > 0) { Memoize(input, 4, type_StartIndex); }
		}
		DebugLocation(66, 11);
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
	// MathLang.g:67:1: array_type : TYPE ARRAY_DECLARATION_MARK ;
	[GrammarRule("array_type")]
	private MathLangParser.array_type_return array_type()
	{
		Enter_array_type();
		EnterRule("array_type", 5);
		TraceIn("array_type", 5);
		MathLangParser.array_type_return retval = new MathLangParser.array_type_return();
		retval.Start = (IToken)input.LT(1);
		int array_type_StartIndex = input.Index;
		object root_0 = null;

		IToken TYPE16=null;
		IToken ARRAY_DECLARATION_MARK17=null;

		object TYPE16_tree=null;
		object ARRAY_DECLARATION_MARK17_tree=null;

		try { DebugEnterRule(GrammarFileName, "array_type");
		DebugLocation(67, 40);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 5)) { return retval; }
			// MathLang.g:67:11: ( TYPE ARRAY_DECLARATION_MARK )
			DebugEnterAlt(1);
			// MathLang.g:67:13: TYPE ARRAY_DECLARATION_MARK
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(67, 13);
			TYPE16=(IToken)Match(input,TYPE,Follow._TYPE_in_array_type486); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			TYPE16_tree = (object)adaptor.Create(TYPE16);
			adaptor.AddChild(root_0, TYPE16_tree);
			}
			DebugLocation(67, 40);
			ARRAY_DECLARATION_MARK17=(IToken)Match(input,ARRAY_DECLARATION_MARK,Follow._ARRAY_DECLARATION_MARK_in_array_type488); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("array_type", 5);
			LeaveRule("array_type", 5);
			Leave_array_type();
			if (state.backtracking > 0) { Memoize(input, 5, array_type_StartIndex); }
		}
		DebugLocation(67, 40);
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
	// MathLang.g:68:1: any_type : ( type | array_type | VOID );
	[GrammarRule("any_type")]
	private MathLangParser.any_type_return any_type()
	{
		Enter_any_type();
		EnterRule("any_type", 6);
		TraceIn("any_type", 6);
		MathLangParser.any_type_return retval = new MathLangParser.any_type_return();
		retval.Start = (IToken)input.LT(1);
		int any_type_StartIndex = input.Index;
		object root_0 = null;

		IToken VOID20=null;
		MathLangParser.type_return type18 = default(MathLangParser.type_return);
		MathLangParser.array_type_return array_type19 = default(MathLangParser.array_type_return);

		object VOID20_tree=null;

		try { DebugEnterRule(GrammarFileName, "any_type");
		DebugLocation(68, 34);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 6)) { return retval; }
			// MathLang.g:68:9: ( type | array_type | VOID )
			int alt3=3;
			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
			int LA3_0 = input.LA(1);

			if ((LA3_0==TYPE))
			{
				int LA3_1 = input.LA(2);

				if ((LA3_1==ARRAY_DECLARATION_MARK))
				{
					alt3=2;
				}
				else if ((LA3_1==ID))
				{
					alt3=1;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 3, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else if ((LA3_0==VOID))
			{
				alt3=3;
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
				// MathLang.g:68:11: type
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(68, 11);
				PushFollow(Follow._type_in_any_type495);
				type18=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type18.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:68:18: array_type
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(68, 18);
				PushFollow(Follow._array_type_in_any_type499);
				array_type19=array_type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, array_type19.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:68:31: VOID
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(68, 31);
				VOID20=(IToken)Match(input,VOID,Follow._VOID_in_any_type503); if (state.failed) return retval;
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
			TraceOut("any_type", 6);
			LeaveRule("any_type", 6);
			Leave_any_type();
			if (state.backtracking > 0) { Memoize(input, 6, any_type_StartIndex); }
		}
		DebugLocation(68, 34);
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
	// MathLang.g:69:1: number : ( NUMBER | ID | funccallbody | CHAR | arrayelement );
	[GrammarRule("number")]
	private MathLangParser.number_return number()
	{
		Enter_number();
		EnterRule("number", 7);
		TraceIn("number", 7);
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
		DebugLocation(69, 16);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 7)) { return retval; }
			// MathLang.g:69:8: ( NUMBER | ID | funccallbody | CHAR | arrayelement )
			int alt4=5;
			try { DebugEnterDecision(4, decisionCanBacktrack[4]);
			switch (input.LA(1))
			{
			case NUMBER:
				{
				alt4=1;
				}
				break;
			case ID:
				{
				switch (input.LA(2))
				{
				case 59:
					{
					alt4=3;
					}
					break;
				case SQRBL:
					{
					alt4=5;
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
				case 62:
				case 64:
					{
					alt4=2;
					}
					break;
				default:
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 4, 2, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}

				}
				break;
			case CHAR:
				{
				alt4=4;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 4, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(4); }
			switch (alt4)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:69:11: NUMBER
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(69, 11);
				NUMBER21=(IToken)Match(input,NUMBER,Follow._NUMBER_in_number511); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				NUMBER21_tree = (object)adaptor.Create(NUMBER21);
				adaptor.AddChild(root_0, NUMBER21_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:70:5: ID
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(70, 5);
				ID22=(IToken)Match(input,ID,Follow._ID_in_number517); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				ID22_tree = (object)adaptor.Create(ID22);
				adaptor.AddChild(root_0, ID22_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:71:5: funccallbody
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(71, 5);
				PushFollow(Follow._funccallbody_in_number523);
				funccallbody23=funccallbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody23.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:72:5: CHAR
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(72, 5);
				CHAR24=(IToken)Match(input,CHAR,Follow._CHAR_in_number529); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				CHAR24_tree = (object)adaptor.Create(CHAR24);
				adaptor.AddChild(root_0, CHAR24_tree);
				}

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:73:5: arrayelement
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(73, 5);
				PushFollow(Follow._arrayelement_in_number535);
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
			TraceOut("number", 7);
			LeaveRule("number", 7);
			Leave_number();
			if (state.backtracking > 0) { Memoize(input, 7, number_StartIndex); }
		}
		DebugLocation(73, 16);
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
	// MathLang.g:74:1: mathexpression : term ;
	[GrammarRule("mathexpression")]
	private MathLangParser.mathexpression_return mathexpression()
	{
		Enter_mathexpression();
		EnterRule("mathexpression", 8);
		TraceIn("mathexpression", 8);
		MathLangParser.mathexpression_return retval = new MathLangParser.mathexpression_return();
		retval.Start = (IToken)input.LT(1);
		int mathexpression_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.term_return term26 = default(MathLangParser.term_return);


		try { DebugEnterRule(GrammarFileName, "mathexpression");
		DebugLocation(74, 21);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 8)) { return retval; }
			// MathLang.g:74:15: ( term )
			DebugEnterAlt(1);
			// MathLang.g:74:17: term
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(74, 17);
			PushFollow(Follow._term_in_mathexpression541);
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
			TraceOut("mathexpression", 8);
			LeaveRule("mathexpression", 8);
			Leave_mathexpression();
			if (state.backtracking > 0) { Memoize(input, 8, mathexpression_StartIndex); }
		}
		DebugLocation(74, 21);
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
	// MathLang.g:76:1: expression : ( newexpression | funccallbody | boolexpression | mathexpression | console_read_body );
	[GrammarRule("expression")]
	private MathLangParser.expression_return expression()
	{
		Enter_expression();
		EnterRule("expression", 9);
		TraceIn("expression", 9);
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
		DebugLocation(76, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 9)) { return retval; }
			// MathLang.g:76:11: ( newexpression | funccallbody | boolexpression | mathexpression | console_read_body )
			int alt5=5;
			try { DebugEnterDecision(5, decisionCanBacktrack[5]);
			try
			{
				alt5 = dfa5.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(5); }
			switch (alt5)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:77:5: newexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(77, 5);
				PushFollow(Follow._newexpression_in_expression555);
				newexpression27=newexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, newexpression27.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:78:5: funccallbody
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(78, 5);
				PushFollow(Follow._funccallbody_in_expression561);
				funccallbody28=funccallbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody28.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:79:5: boolexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(79, 5);
				PushFollow(Follow._boolexpression_in_expression567);
				boolexpression29=boolexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression29.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:80:5: mathexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(80, 5);
				PushFollow(Follow._mathexpression_in_expression573);
				mathexpression30=mathexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mathexpression30.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:81:5: console_read_body
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(81, 5);
				PushFollow(Follow._console_read_body_in_expression579);
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
			TraceOut("expression", 9);
			LeaveRule("expression", 9);
			Leave_expression();
			if (state.backtracking > 0) { Memoize(input, 9, expression_StartIndex); }
		}
		DebugLocation(83, 0);
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
	// MathLang.g:85:1: arrayelement : ID '[' number ']' -> ^( ARRAYELEMENT ID number ) ;
	[GrammarRule("arrayelement")]
	private MathLangParser.arrayelement_return arrayelement()
	{
		Enter_arrayelement();
		EnterRule("arrayelement", 10);
		TraceIn("arrayelement", 10);
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
		DebugLocation(85, 62);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 10)) { return retval; }
			// MathLang.g:85:13: ( ID '[' number ']' -> ^( ARRAYELEMENT ID number ) )
			DebugEnterAlt(1);
			// MathLang.g:85:16: ID '[' number ']'
			{
			DebugLocation(85, 16);
			ID32=(IToken)Match(input,ID,Follow._ID_in_arrayelement591); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID32);

			DebugLocation(85, 19);
			char_literal33=(IToken)Match(input,SQRBL,Follow._SQRBL_in_arrayelement593); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_SQRBL.Add(char_literal33);

			DebugLocation(85, 23);
			PushFollow(Follow._number_in_arrayelement595);
			number34=number();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_number.Add(number34.Tree);
			DebugLocation(85, 30);
			char_literal35=(IToken)Match(input,SQRBR,Follow._SQRBR_in_arrayelement597); if (state.failed) return retval; 
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
			// 85:34: -> ^( ARRAYELEMENT ID number )
			{
				DebugLocation(85, 37);
				// MathLang.g:85:37: ^( ARRAYELEMENT ID number )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(85, 39);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYELEMENT, "ARRAYELEMENT"), root_1);

				DebugLocation(85, 52);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(85, 55);
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
			TraceOut("arrayelement", 10);
			LeaveRule("arrayelement", 10);
			Leave_arrayelement();
			if (state.backtracking > 0) { Memoize(input, 10, arrayelement_StartIndex); }
		}
		DebugLocation(85, 62);
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
	// MathLang.g:87:1: declaration : ( declarationbody ';' | longdeclaration );
	[GrammarRule("declaration")]
	private MathLangParser.declaration_return declaration()
	{
		Enter_declaration();
		EnterRule("declaration", 11);
		TraceIn("declaration", 11);
		MathLangParser.declaration_return retval = new MathLangParser.declaration_return();
		retval.Start = (IToken)input.LT(1);
		int declaration_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal37=null;
		MathLangParser.declarationbody_return declarationbody36 = default(MathLangParser.declarationbody_return);
		MathLangParser.longdeclaration_return longdeclaration38 = default(MathLangParser.longdeclaration_return);

		object char_literal37_tree=null;

		try { DebugEnterRule(GrammarFileName, "declaration");
		DebugLocation(87, 20);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 11)) { return retval; }
			// MathLang.g:87:12: ( declarationbody ';' | longdeclaration )
			int alt6=2;
			try { DebugEnterDecision(6, decisionCanBacktrack[6]);
			int LA6_0 = input.LA(1);

			if ((LA6_0==TYPE))
			{
				int LA6_1 = input.LA(2);

				if ((LA6_1==ARRAY_DECLARATION_MARK))
				{
					int LA6_2 = input.LA(3);

					if ((LA6_2==ID))
					{
						int LA6_4 = input.LA(4);

						if ((LA6_4==ASSIGN))
						{
							alt6=2;
						}
						else if ((LA6_4==58))
						{
							alt6=1;
						}
						else
						{
							if (state.backtracking>0) {state.failed=true; return retval;}
							NoViableAltException nvae = new NoViableAltException("", 6, 4, input);

							DebugRecognitionException(nvae);
							throw nvae;
						}
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 6, 2, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}
				else if ((LA6_1==ID))
				{
					int LA6_3 = input.LA(3);

					if ((LA6_3==ASSIGN))
					{
						alt6=2;
					}
					else if ((LA6_3==58))
					{
						alt6=1;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 6, 3, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
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
				// MathLang.g:87:14: declarationbody ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(87, 14);
				PushFollow(Follow._declarationbody_in_declaration615);
				declarationbody36=declarationbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, declarationbody36.Tree);
				DebugLocation(87, 33);
				char_literal37=(IToken)Match(input,58,Follow._58_in_declaration617); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:88:6: longdeclaration
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(88, 6);
				PushFollow(Follow._longdeclaration_in_declaration625);
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
			TraceOut("declaration", 11);
			LeaveRule("declaration", 11);
			Leave_declaration();
			if (state.backtracking > 0) { Memoize(input, 11, declaration_StartIndex); }
		}
		DebugLocation(88, 20);
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
	// MathLang.g:90:1: declarationbody : ( ( type ID -> ^( VARDECLARATION type ID ) ) | ( array_type ID -> ^( ARRAYDECLARATION array_type ID ) ) );
	[GrammarRule("declarationbody")]
	private MathLangParser.declarationbody_return declarationbody()
	{
		Enter_declarationbody();
		EnterRule("declarationbody", 12);
		TraceIn("declarationbody", 12);
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
		DebugLocation(90, 4);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 12)) { return retval; }
			// MathLang.g:90:16: ( ( type ID -> ^( VARDECLARATION type ID ) ) | ( array_type ID -> ^( ARRAYDECLARATION array_type ID ) ) )
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
				// MathLang.g:90:18: ( type ID -> ^( VARDECLARATION type ID ) )
				{
				DebugLocation(90, 18);
				// MathLang.g:90:18: ( type ID -> ^( VARDECLARATION type ID ) )
				DebugEnterAlt(1);
				// MathLang.g:90:19: type ID
				{
				DebugLocation(90, 19);
				PushFollow(Follow._type_in_declarationbody633);
				type39=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type39.Tree);
				DebugLocation(90, 24);
				ID40=(IToken)Match(input,ID,Follow._ID_in_declarationbody635); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID40);



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
				// 90:27: -> ^( VARDECLARATION type ID )
				{
					DebugLocation(90, 30);
					// MathLang.g:90:30: ^( VARDECLARATION type ID )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(90, 32);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDECLARATION, "VARDECLARATION"), root_1);

					DebugLocation(90, 47);
					adaptor.AddChild(root_1, stream_type.NextTree());
					DebugLocation(90, 52);
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
				// MathLang.g:91:7: ( array_type ID -> ^( ARRAYDECLARATION array_type ID ) )
				{
				DebugLocation(91, 7);
				// MathLang.g:91:7: ( array_type ID -> ^( ARRAYDECLARATION array_type ID ) )
				DebugEnterAlt(1);
				// MathLang.g:91:8: array_type ID
				{
				DebugLocation(91, 8);
				PushFollow(Follow._array_type_in_declarationbody656);
				array_type41=array_type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_array_type.Add(array_type41.Tree);
				DebugLocation(91, 19);
				ID42=(IToken)Match(input,ID,Follow._ID_in_declarationbody658); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID42);



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
				// 91:22: -> ^( ARRAYDECLARATION array_type ID )
				{
					DebugLocation(91, 25);
					// MathLang.g:91:25: ^( ARRAYDECLARATION array_type ID )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(91, 27);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYDECLARATION, "ARRAYDECLARATION"), root_1);

					DebugLocation(91, 44);
					adaptor.AddChild(root_1, stream_array_type.NextTree());
					DebugLocation(91, 55);
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
			TraceOut("declarationbody", 12);
			LeaveRule("declarationbody", 12);
			Leave_declarationbody();
			if (state.backtracking > 0) { Memoize(input, 12, declarationbody_StartIndex); }
		}
		DebugLocation(92, 4);
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
	// MathLang.g:93:1: longdeclaration : longdeclarationbody ';' ;
	[GrammarRule("longdeclaration")]
	private MathLangParser.longdeclaration_return longdeclaration()
	{
		Enter_longdeclaration();
		EnterRule("longdeclaration", 13);
		TraceIn("longdeclaration", 13);
		MathLangParser.longdeclaration_return retval = new MathLangParser.longdeclaration_return();
		retval.Start = (IToken)input.LT(1);
		int longdeclaration_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal44=null;
		MathLangParser.longdeclarationbody_return longdeclarationbody43 = default(MathLangParser.longdeclarationbody_return);

		object char_literal44_tree=null;

		try { DebugEnterRule(GrammarFileName, "longdeclaration");
		DebugLocation(93, 42);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 13)) { return retval; }
			// MathLang.g:93:16: ( longdeclarationbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:93:18: longdeclarationbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(93, 18);
			PushFollow(Follow._longdeclarationbody_in_longdeclaration680);
			longdeclarationbody43=longdeclarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclarationbody43.Tree);
			DebugLocation(93, 41);
			char_literal44=(IToken)Match(input,58,Follow._58_in_longdeclaration682); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("longdeclaration", 13);
			LeaveRule("longdeclaration", 13);
			Leave_longdeclaration();
			if (state.backtracking > 0) { Memoize(input, 13, longdeclaration_StartIndex); }
		}
		DebugLocation(93, 42);
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
	// MathLang.g:94:1: longdeclarationbody : ( ( type ID ASSIGN expression -> ^( VARDECLARATION type ID expression ) ) | ( array_type ID ASSIGN newexpression -> ^( ARRAYDECLARATION array_type ID newexpression ) ) );
	[GrammarRule("longdeclarationbody")]
	private MathLangParser.longdeclarationbody_return longdeclarationbody()
	{
		Enter_longdeclarationbody();
		EnterRule("longdeclarationbody", 14);
		TraceIn("longdeclarationbody", 14);
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
		DebugLocation(94, 94);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 14)) { return retval; }
			// MathLang.g:94:20: ( ( type ID ASSIGN expression -> ^( VARDECLARATION type ID expression ) ) | ( array_type ID ASSIGN newexpression -> ^( ARRAYDECLARATION array_type ID newexpression ) ) )
			int alt8=2;
			try { DebugEnterDecision(8, decisionCanBacktrack[8]);
			int LA8_0 = input.LA(1);

			if ((LA8_0==TYPE))
			{
				int LA8_1 = input.LA(2);

				if ((LA8_1==ARRAY_DECLARATION_MARK))
				{
					alt8=2;
				}
				else if ((LA8_1==ID))
				{
					alt8=1;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 8, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
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
				// MathLang.g:94:22: ( type ID ASSIGN expression -> ^( VARDECLARATION type ID expression ) )
				{
				DebugLocation(94, 22);
				// MathLang.g:94:22: ( type ID ASSIGN expression -> ^( VARDECLARATION type ID expression ) )
				DebugEnterAlt(1);
				// MathLang.g:94:23: type ID ASSIGN expression
				{
				DebugLocation(94, 23);
				PushFollow(Follow._type_in_longdeclarationbody691);
				type45=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type45.Tree);
				DebugLocation(94, 28);
				ID46=(IToken)Match(input,ID,Follow._ID_in_longdeclarationbody693); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID46);

				DebugLocation(94, 31);
				ASSIGN47=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclarationbody695); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN47);

				DebugLocation(94, 38);
				PushFollow(Follow._expression_in_longdeclarationbody697);
				expression48=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression48.Tree);


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
				// 94:50: -> ^( VARDECLARATION type ID expression )
				{
					DebugLocation(94, 53);
					// MathLang.g:94:53: ^( VARDECLARATION type ID expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(94, 55);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDECLARATION, "VARDECLARATION"), root_1);

					DebugLocation(94, 70);
					adaptor.AddChild(root_1, stream_type.NextTree());
					DebugLocation(94, 75);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(94, 78);
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
				// MathLang.g:95:8: ( array_type ID ASSIGN newexpression -> ^( ARRAYDECLARATION array_type ID newexpression ) )
				{
				DebugLocation(95, 8);
				// MathLang.g:95:8: ( array_type ID ASSIGN newexpression -> ^( ARRAYDECLARATION array_type ID newexpression ) )
				DebugEnterAlt(1);
				// MathLang.g:95:9: array_type ID ASSIGN newexpression
				{
				DebugLocation(95, 9);
				PushFollow(Follow._array_type_in_longdeclarationbody721);
				array_type49=array_type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_array_type.Add(array_type49.Tree);
				DebugLocation(95, 20);
				ID50=(IToken)Match(input,ID,Follow._ID_in_longdeclarationbody723); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID50);

				DebugLocation(95, 23);
				ASSIGN51=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclarationbody725); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN51);

				DebugLocation(95, 30);
				PushFollow(Follow._newexpression_in_longdeclarationbody727);
				newexpression52=newexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_newexpression.Add(newexpression52.Tree);


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
				// 95:44: -> ^( ARRAYDECLARATION array_type ID newexpression )
				{
					DebugLocation(95, 47);
					// MathLang.g:95:47: ^( ARRAYDECLARATION array_type ID newexpression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(95, 49);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYDECLARATION, "ARRAYDECLARATION"), root_1);

					DebugLocation(95, 66);
					adaptor.AddChild(root_1, stream_array_type.NextTree());
					DebugLocation(95, 77);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(95, 80);
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
			TraceOut("longdeclarationbody", 14);
			LeaveRule("longdeclarationbody", 14);
			Leave_longdeclarationbody();
			if (state.backtracking > 0) { Memoize(input, 14, longdeclarationbody_StartIndex); }
		}
		DebugLocation(95, 94);
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
	// MathLang.g:97:1: add : mul ( ( ADD | SUB ) mul )* ;
	[GrammarRule("add")]
	private MathLangParser.add_return add()
	{
		Enter_add();
		EnterRule("add", 15);
		TraceIn("add", 15);
		MathLangParser.add_return retval = new MathLangParser.add_return();
		retval.Start = (IToken)input.LT(1);
		int add_StartIndex = input.Index;
		object root_0 = null;

		IToken set54=null;
		MathLangParser.mul_return mul53 = default(MathLangParser.mul_return);
		MathLangParser.mul_return mul55 = default(MathLangParser.mul_return);

		object set54_tree=null;

		try { DebugEnterRule(GrammarFileName, "add");
		DebugLocation(97, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 15)) { return retval; }
			// MathLang.g:97:4: ( mul ( ( ADD | SUB ) mul )* )
			DebugEnterAlt(1);
			// MathLang.g:97:6: mul ( ( ADD | SUB ) mul )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(97, 6);
			PushFollow(Follow._mul_in_add747);
			mul53=mul();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul53.Tree);
			DebugLocation(97, 10);
			// MathLang.g:97:10: ( ( ADD | SUB ) mul )*
			try { DebugEnterSubRule(9);
			while (true)
			{
				int alt9=2;
				try { DebugEnterDecision(9, decisionCanBacktrack[9]);
				int LA9_0 = input.LA(1);

				if (((LA9_0>=ADD && LA9_0<=SUB)))
				{
					alt9=1;
				}


				} finally { DebugExitDecision(9); }
				switch ( alt9 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:97:12: ( ADD | SUB ) mul
					{
					DebugLocation(97, 12);
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

					DebugLocation(97, 25);
					PushFollow(Follow._mul_in_add760);
					mul55=mul();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul55.Tree);

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
			TraceOut("add", 15);
			LeaveRule("add", 15);
			Leave_add();
			if (state.backtracking > 0) { Memoize(input, 15, add_StartIndex); }
		}
		DebugLocation(97, 30);
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
	// MathLang.g:98:1: mul : group ( ( MUL | DIV ) group )* ;
	[GrammarRule("mul")]
	private MathLangParser.mul_return mul()
	{
		Enter_mul();
		EnterRule("mul", 16);
		TraceIn("mul", 16);
		MathLangParser.mul_return retval = new MathLangParser.mul_return();
		retval.Start = (IToken)input.LT(1);
		int mul_StartIndex = input.Index;
		object root_0 = null;

		IToken set57=null;
		MathLangParser.group_return group56 = default(MathLangParser.group_return);
		MathLangParser.group_return group58 = default(MathLangParser.group_return);

		object set57_tree=null;

		try { DebugEnterRule(GrammarFileName, "mul");
		DebugLocation(98, 33);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 16)) { return retval; }
			// MathLang.g:98:4: ( group ( ( MUL | DIV ) group )* )
			DebugEnterAlt(1);
			// MathLang.g:98:6: group ( ( MUL | DIV ) group )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(98, 6);
			PushFollow(Follow._group_in_mul769);
			group56=group();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group56.Tree);
			DebugLocation(98, 12);
			// MathLang.g:98:12: ( ( MUL | DIV ) group )*
			try { DebugEnterSubRule(10);
			while (true)
			{
				int alt10=2;
				try { DebugEnterDecision(10, decisionCanBacktrack[10]);
				int LA10_0 = input.LA(1);

				if (((LA10_0>=MUL && LA10_0<=DIV)))
				{
					alt10=1;
				}


				} finally { DebugExitDecision(10); }
				switch ( alt10 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:98:14: ( MUL | DIV ) group
					{
					DebugLocation(98, 14);
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

					DebugLocation(98, 27);
					PushFollow(Follow._group_in_mul782);
					group58=group();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group58.Tree);

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
			TraceOut("mul", 16);
			LeaveRule("mul", 16);
			Leave_mul();
			if (state.backtracking > 0) { Memoize(input, 16, mul_StartIndex); }
		}
		DebugLocation(98, 33);
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
	// MathLang.g:99:1: compare : add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )? ;
	[GrammarRule("compare")]
	private MathLangParser.compare_return compare()
	{
		Enter_compare();
		EnterRule("compare", 17);
		TraceIn("compare", 17);
		MathLangParser.compare_return retval = new MathLangParser.compare_return();
		retval.Start = (IToken)input.LT(1);
		int compare_StartIndex = input.Index;
		object root_0 = null;

		IToken set60=null;
		MathLangParser.add_return add59 = default(MathLangParser.add_return);
		MathLangParser.add_return add61 = default(MathLangParser.add_return);

		object set60_tree=null;

		try { DebugEnterRule(GrammarFileName, "compare");
		DebugLocation(99, 60);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 17)) { return retval; }
			// MathLang.g:99:8: ( add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )? )
			DebugEnterAlt(1);
			// MathLang.g:99:10: add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(99, 10);
			PushFollow(Follow._add_in_compare790);
			add59=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add59.Tree);
			DebugLocation(99, 14);
			// MathLang.g:99:14: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
			int alt11=2;
			try { DebugEnterSubRule(11);
			try { DebugEnterDecision(11, decisionCanBacktrack[11]);
			try
			{
				alt11 = dfa11.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(11); }
			switch (alt11)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:99:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
				{
				DebugLocation(99, 16);
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

				DebugLocation(99, 53);
				PushFollow(Follow._add_in_compare820);
				add61=add();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add61.Tree);

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
			TraceOut("compare", 17);
			LeaveRule("compare", 17);
			Leave_compare();
			if (state.backtracking > 0) { Memoize(input, 17, compare_StartIndex); }
		}
		DebugLocation(99, 60);
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
	// MathLang.g:100:1: term : add ;
	[GrammarRule("term")]
	private MathLangParser.term_return term()
	{
		Enter_term();
		EnterRule("term", 18);
		TraceIn("term", 18);
		MathLangParser.term_return retval = new MathLangParser.term_return();
		retval.Start = (IToken)input.LT(1);
		int term_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.add_return add62 = default(MathLangParser.add_return);


		try { DebugEnterRule(GrammarFileName, "term");
		DebugLocation(100, 9);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 18)) { return retval; }
			// MathLang.g:100:5: ( add )
			DebugEnterAlt(1);
			// MathLang.g:100:7: add
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(100, 7);
			PushFollow(Follow._add_in_term831);
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
			TraceOut("term", 18);
			LeaveRule("term", 18);
			Leave_term();
			if (state.backtracking > 0) { Memoize(input, 18, term_StartIndex); }
		}
		DebugLocation(100, 9);
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
	// MathLang.g:101:1: group : ( ( SUB )? '(' term ')' | number );
	[GrammarRule("group")]
	private MathLangParser.group_return group()
	{
		Enter_group();
		EnterRule("group", 19);
		TraceIn("group", 19);
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
		DebugLocation(101, 38);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 19)) { return retval; }
			// MathLang.g:101:6: ( ( SUB )? '(' term ')' | number )
			int alt13=2;
			try { DebugEnterDecision(13, decisionCanBacktrack[13]);
			int LA13_0 = input.LA(1);

			if ((LA13_0==SUB||LA13_0==59))
			{
				alt13=1;
			}
			else if (((LA13_0>=NUMBER && LA13_0<=CHAR)))
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
				// MathLang.g:101:8: ( SUB )? '(' term ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(101, 8);
				// MathLang.g:101:8: ( SUB )?
				int alt12=2;
				try { DebugEnterSubRule(12);
				try { DebugEnterDecision(12, decisionCanBacktrack[12]);
				int LA12_0 = input.LA(1);

				if ((LA12_0==SUB))
				{
					alt12=1;
				}
				} finally { DebugExitDecision(12); }
				switch (alt12)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:101:9: SUB
					{
					DebugLocation(101, 12);
					SUB63=(IToken)Match(input,SUB,Follow._SUB_in_group838); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					SUB63_tree = (object)adaptor.Create(SUB63);
					root_0 = (object)adaptor.BecomeRoot(SUB63_tree, root_0);
					}

					}
					break;

				}
				} finally { DebugExitSubRule(12); }

				DebugLocation(101, 19);
				char_literal64=(IToken)Match(input,59,Follow._59_in_group843); if (state.failed) return retval;
				DebugLocation(101, 21);
				PushFollow(Follow._term_in_group846);
				term65=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term65.Tree);
				DebugLocation(101, 29);
				char_literal66=(IToken)Match(input,60,Follow._60_in_group848); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:101:33: number
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(101, 33);
				PushFollow(Follow._number_in_group853);
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
			TraceOut("group", 19);
			LeaveRule("group", 19);
			Leave_group();
			if (state.backtracking > 0) { Memoize(input, 19, group_StartIndex); }
		}
		DebugLocation(101, 38);
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
	// MathLang.g:103:1: assignment : assignmentbody ';' ;
	[GrammarRule("assignment")]
	private MathLangParser.assignment_return assignment()
	{
		Enter_assignment();
		EnterRule("assignment", 20);
		TraceIn("assignment", 20);
		MathLangParser.assignment_return retval = new MathLangParser.assignment_return();
		retval.Start = (IToken)input.LT(1);
		int assignment_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal69=null;
		MathLangParser.assignmentbody_return assignmentbody68 = default(MathLangParser.assignmentbody_return);

		object char_literal69_tree=null;

		try { DebugEnterRule(GrammarFileName, "assignment");
		DebugLocation(103, 31);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 20)) { return retval; }
			// MathLang.g:103:11: ( assignmentbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:103:13: assignmentbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(103, 13);
			PushFollow(Follow._assignmentbody_in_assignment860);
			assignmentbody68=assignmentbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentbody68.Tree);
			DebugLocation(103, 31);
			char_literal69=(IToken)Match(input,58,Follow._58_in_assignment862); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("assignment", 20);
			LeaveRule("assignment", 20);
			Leave_assignment();
			if (state.backtracking > 0) { Memoize(input, 20, assignment_StartIndex); }
		}
		DebugLocation(103, 31);
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
	// MathLang.g:104:1: assignmentbody : ( ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) ) | ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) ) );
	[GrammarRule("assignmentbody")]
	private MathLangParser.assignmentbody_return assignmentbody()
	{
		Enter_assignmentbody();
		EnterRule("assignmentbody", 21);
		TraceIn("assignmentbody", 21);
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
		DebugLocation(104, 87);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 21)) { return retval; }
			// MathLang.g:104:15: ( ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) ) | ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) ) )
			int alt14=2;
			try { DebugEnterDecision(14, decisionCanBacktrack[14]);
			int LA14_0 = input.LA(1);

			if ((LA14_0==ID))
			{
				int LA14_1 = input.LA(2);

				if ((LA14_1==ASSIGN))
				{
					alt14=1;
				}
				else if ((LA14_1==SQRBL))
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
				// MathLang.g:104:17: ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) )
				{
				DebugLocation(104, 17);
				// MathLang.g:104:17: ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) )
				DebugEnterAlt(1);
				// MathLang.g:104:18: ID ASSIGN expression
				{
				DebugLocation(104, 18);
				ID70=(IToken)Match(input,ID,Follow._ID_in_assignmentbody870); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID70);

				DebugLocation(104, 21);
				ASSIGN71=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignmentbody872); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN71);

				DebugLocation(104, 28);
				PushFollow(Follow._expression_in_assignmentbody874);
				expression72=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression72.Tree);


				{
				// AST REWRITE
				// elements: ID, expression
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 104:39: -> ^( VARASSIGNMENT ID expression )
				{
					DebugLocation(104, 42);
					// MathLang.g:104:42: ^( VARASSIGNMENT ID expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(104, 44);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARASSIGNMENT, "VARASSIGNMENT"), root_1);

					DebugLocation(104, 58);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(104, 61);
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
				// MathLang.g:105:2: ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) )
				{
				DebugLocation(105, 2);
				// MathLang.g:105:2: ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) )
				DebugEnterAlt(1);
				// MathLang.g:105:4: arrayelement ASSIGN expression
				{
				DebugLocation(105, 4);
				PushFollow(Follow._arrayelement_in_assignmentbody893);
				arrayelement73=arrayelement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_arrayelement.Add(arrayelement73.Tree);
				DebugLocation(105, 17);
				ASSIGN74=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignmentbody895); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN74);

				DebugLocation(105, 24);
				PushFollow(Follow._expression_in_assignmentbody897);
				expression75=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression75.Tree);


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
				// 105:35: -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression )
				{
					DebugLocation(105, 38);
					// MathLang.g:105:38: ^( ARRAYELEMENTASSIGNMENT arrayelement expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(105, 40);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYELEMENTASSIGNMENT, "ARRAYELEMENTASSIGNMENT"), root_1);

					DebugLocation(105, 63);
					adaptor.AddChild(root_1, stream_arrayelement.NextTree());
					DebugLocation(105, 76);
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
			TraceOut("assignmentbody", 21);
			LeaveRule("assignmentbody", 21);
			Leave_assignmentbody();
			if (state.backtracking > 0) { Memoize(input, 21, assignmentbody_StartIndex); }
		}
		DebugLocation(105, 87);
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
	// MathLang.g:107:1: boolexpression : boolterm ;
	[GrammarRule("boolexpression")]
	private MathLangParser.boolexpression_return boolexpression()
	{
		Enter_boolexpression();
		EnterRule("boolexpression", 22);
		TraceIn("boolexpression", 22);
		MathLangParser.boolexpression_return retval = new MathLangParser.boolexpression_return();
		retval.Start = (IToken)input.LT(1);
		int boolexpression_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.boolterm_return boolterm76 = default(MathLangParser.boolterm_return);


		try { DebugEnterRule(GrammarFileName, "boolexpression");
		DebugLocation(107, 25);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 22)) { return retval; }
			// MathLang.g:107:15: ( boolterm )
			DebugEnterAlt(1);
			// MathLang.g:107:17: boolterm
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(107, 17);
			PushFollow(Follow._boolterm_in_boolexpression915);
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
			TraceOut("boolexpression", 22);
			LeaveRule("boolexpression", 22);
			Leave_boolexpression();
			if (state.backtracking > 0) { Memoize(input, 22, boolexpression_StartIndex); }
		}
		DebugLocation(107, 25);
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
	// MathLang.g:108:1: boolterm : or ( ( EQ | NEQ ) or )? ;
	[GrammarRule("boolterm")]
	private MathLangParser.boolterm_return boolterm()
	{
		Enter_boolterm();
		EnterRule("boolterm", 23);
		TraceIn("boolterm", 23);
		MathLangParser.boolterm_return retval = new MathLangParser.boolterm_return();
		retval.Start = (IToken)input.LT(1);
		int boolterm_StartIndex = input.Index;
		object root_0 = null;

		IToken set78=null;
		MathLangParser.or_return or77 = default(MathLangParser.or_return);
		MathLangParser.or_return or79 = default(MathLangParser.or_return);

		object set78_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolterm");
		DebugLocation(108, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 23)) { return retval; }
			// MathLang.g:108:9: ( or ( ( EQ | NEQ ) or )? )
			DebugEnterAlt(1);
			// MathLang.g:108:11: or ( ( EQ | NEQ ) or )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(108, 11);
			PushFollow(Follow._or_in_boolterm922);
			or77=or();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or77.Tree);
			DebugLocation(108, 14);
			// MathLang.g:108:14: ( ( EQ | NEQ ) or )?
			int alt15=2;
			try { DebugEnterSubRule(15);
			try { DebugEnterDecision(15, decisionCanBacktrack[15]);
			int LA15_0 = input.LA(1);

			if (((LA15_0>=NEQ && LA15_0<=EQ)))
			{
				alt15=1;
			}
			} finally { DebugExitDecision(15); }
			switch (alt15)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:108:16: ( EQ | NEQ ) or
				{
				DebugLocation(108, 16);
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

				DebugLocation(108, 28);
				PushFollow(Follow._or_in_boolterm935);
				or79=or();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or79.Tree);

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
			TraceOut("boolterm", 23);
			LeaveRule("boolterm", 23);
			Leave_boolterm();
			if (state.backtracking > 0) { Memoize(input, 23, boolterm_StartIndex); }
		}
		DebugLocation(108, 32);
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
	// MathLang.g:109:1: or : and ( OR and )* ;
	[GrammarRule("or")]
	private MathLangParser.or_return or()
	{
		Enter_or();
		EnterRule("or", 24);
		TraceIn("or", 24);
		MathLangParser.or_return retval = new MathLangParser.or_return();
		retval.Start = (IToken)input.LT(1);
		int or_StartIndex = input.Index;
		object root_0 = null;

		IToken OR81=null;
		MathLangParser.and_return and80 = default(MathLangParser.and_return);
		MathLangParser.and_return and82 = default(MathLangParser.and_return);

		object OR81_tree=null;

		try { DebugEnterRule(GrammarFileName, "or");
		DebugLocation(109, 18);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 24)) { return retval; }
			// MathLang.g:109:3: ( and ( OR and )* )
			DebugEnterAlt(1);
			// MathLang.g:109:5: and ( OR and )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(109, 5);
			PushFollow(Follow._and_in_or944);
			and80=and();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and80.Tree);
			DebugLocation(109, 9);
			// MathLang.g:109:9: ( OR and )*
			try { DebugEnterSubRule(16);
			while (true)
			{
				int alt16=2;
				try { DebugEnterDecision(16, decisionCanBacktrack[16]);
				int LA16_0 = input.LA(1);

				if ((LA16_0==OR))
				{
					alt16=1;
				}


				} finally { DebugExitDecision(16); }
				switch ( alt16 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:109:10: OR and
					{
					DebugLocation(109, 12);
					OR81=(IToken)Match(input,OR,Follow._OR_in_or947); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR81_tree = (object)adaptor.Create(OR81);
					root_0 = (object)adaptor.BecomeRoot(OR81_tree, root_0);
					}
					DebugLocation(109, 14);
					PushFollow(Follow._and_in_or950);
					and82=and();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and82.Tree);

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
			TraceOut("or", 24);
			LeaveRule("or", 24);
			Leave_or();
			if (state.backtracking > 0) { Memoize(input, 24, or_StartIndex); }
		}
		DebugLocation(109, 18);
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
	// MathLang.g:110:1: and : boolgroup ( AND boolgroup )* ;
	[GrammarRule("and")]
	private MathLangParser.and_return and()
	{
		Enter_and();
		EnterRule("and", 25);
		TraceIn("and", 25);
		MathLangParser.and_return retval = new MathLangParser.and_return();
		retval.Start = (IToken)input.LT(1);
		int and_StartIndex = input.Index;
		object root_0 = null;

		IToken AND84=null;
		MathLangParser.boolgroup_return boolgroup83 = default(MathLangParser.boolgroup_return);
		MathLangParser.boolgroup_return boolgroup85 = default(MathLangParser.boolgroup_return);

		object AND84_tree=null;

		try { DebugEnterRule(GrammarFileName, "and");
		DebugLocation(110, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 25)) { return retval; }
			// MathLang.g:110:4: ( boolgroup ( AND boolgroup )* )
			DebugEnterAlt(1);
			// MathLang.g:110:6: boolgroup ( AND boolgroup )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(110, 6);
			PushFollow(Follow._boolgroup_in_and958);
			boolgroup83=boolgroup();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup83.Tree);
			DebugLocation(110, 16);
			// MathLang.g:110:16: ( AND boolgroup )*
			try { DebugEnterSubRule(17);
			while (true)
			{
				int alt17=2;
				try { DebugEnterDecision(17, decisionCanBacktrack[17]);
				int LA17_0 = input.LA(1);

				if ((LA17_0==AND))
				{
					alt17=1;
				}


				} finally { DebugExitDecision(17); }
				switch ( alt17 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:110:17: AND boolgroup
					{
					DebugLocation(110, 20);
					AND84=(IToken)Match(input,AND,Follow._AND_in_and961); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND84_tree = (object)adaptor.Create(AND84);
					root_0 = (object)adaptor.BecomeRoot(AND84_tree, root_0);
					}
					DebugLocation(110, 22);
					PushFollow(Follow._boolgroup_in_and964);
					boolgroup85=boolgroup();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup85.Tree);

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
			TraceOut("and", 25);
			LeaveRule("and", 25);
			Leave_and();
			if (state.backtracking > 0) { Memoize(input, 25, and_StartIndex); }
		}
		DebugLocation(110, 32);
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
	// MathLang.g:111:1: boolgroup : ( NOT )? ( '(' boolterm ')' | boolvar ) ;
	[GrammarRule("boolgroup")]
	private MathLangParser.boolgroup_return boolgroup()
	{
		Enter_boolgroup();
		EnterRule("boolgroup", 26);
		TraceIn("boolgroup", 26);
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
		DebugLocation(111, 51);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 26)) { return retval; }
			// MathLang.g:111:10: ( ( NOT )? ( '(' boolterm ')' | boolvar ) )
			DebugEnterAlt(1);
			// MathLang.g:111:12: ( NOT )? ( '(' boolterm ')' | boolvar )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(111, 12);
			// MathLang.g:111:12: ( NOT )?
			int alt18=2;
			try { DebugEnterSubRule(18);
			try { DebugEnterDecision(18, decisionCanBacktrack[18]);
			int LA18_0 = input.LA(1);

			if ((LA18_0==NOT))
			{
				alt18=1;
			}
			} finally { DebugExitDecision(18); }
			switch (alt18)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:111:13: NOT
				{
				DebugLocation(111, 16);
				NOT86=(IToken)Match(input,NOT,Follow._NOT_in_boolgroup973); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				NOT86_tree = (object)adaptor.Create(NOT86);
				root_0 = (object)adaptor.BecomeRoot(NOT86_tree, root_0);
				}

				}
				break;

			}
			} finally { DebugExitSubRule(18); }

			DebugLocation(111, 20);
			// MathLang.g:111:20: ( '(' boolterm ')' | boolvar )
			int alt19=2;
			try { DebugEnterSubRule(19);
			try { DebugEnterDecision(19, decisionCanBacktrack[19]);
			int LA19_0 = input.LA(1);

			if ((LA19_0==59))
			{
				int LA19_1 = input.LA(2);

				if ((EvaluatePredicate(synpred43_MathLang_fragment)))
				{
					alt19=1;
				}
				else if ((true))
				{
					alt19=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 19, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else if (((LA19_0>=NUMBER && LA19_0<=CHAR)||LA19_0==SUB||(LA19_0>=TRUE && LA19_0<=FALSE)))
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
				// MathLang.g:111:22: '(' boolterm ')'
				{
				DebugLocation(111, 25);
				char_literal87=(IToken)Match(input,59,Follow._59_in_boolgroup980); if (state.failed) return retval;
				DebugLocation(111, 27);
				PushFollow(Follow._boolterm_in_boolgroup983);
				boolterm88=boolterm();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm88.Tree);
				DebugLocation(111, 39);
				char_literal89=(IToken)Match(input,60,Follow._60_in_boolgroup985); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:111:43: boolvar
				{
				DebugLocation(111, 43);
				PushFollow(Follow._boolvar_in_boolgroup990);
				boolvar90=boolvar();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolvar90.Tree);

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
			TraceOut("boolgroup", 26);
			LeaveRule("boolgroup", 26);
			Leave_boolgroup();
			if (state.backtracking > 0) { Memoize(input, 26, boolgroup_StartIndex); }
		}
		DebugLocation(111, 51);
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
	// MathLang.g:112:1: boolvar : ( TRUE | FALSE | compare );
	[GrammarRule("boolvar")]
	private MathLangParser.boolvar_return boolvar()
	{
		Enter_boolvar();
		EnterRule("boolvar", 27);
		TraceIn("boolvar", 27);
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
		DebugLocation(112, 11);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 27)) { return retval; }
			// MathLang.g:112:8: ( TRUE | FALSE | compare )
			int alt20=3;
			try { DebugEnterDecision(20, decisionCanBacktrack[20]);
			switch (input.LA(1))
			{
			case TRUE:
				{
				alt20=1;
				}
				break;
			case FALSE:
				{
				alt20=2;
				}
				break;
			case NUMBER:
			case ID:
			case CHAR:
			case SUB:
			case 59:
				{
				alt20=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 20, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(20); }
			switch (alt20)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:112:10: TRUE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(112, 10);
				TRUE91=(IToken)Match(input,TRUE,Follow._TRUE_in_boolvar998); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				TRUE91_tree = (object)adaptor.Create(TRUE91);
				adaptor.AddChild(root_0, TRUE91_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:113:5: FALSE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(113, 5);
				FALSE92=(IToken)Match(input,FALSE,Follow._FALSE_in_boolvar1004); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				FALSE92_tree = (object)adaptor.Create(FALSE92);
				adaptor.AddChild(root_0, FALSE92_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:114:5: compare
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(114, 5);
				PushFollow(Follow._compare_in_boolvar1010);
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
			TraceOut("boolvar", 27);
			LeaveRule("boolvar", 27);
			Leave_boolvar();
			if (state.backtracking > 0) { Memoize(input, 27, boolvar_StartIndex); }
		}
		DebugLocation(114, 11);
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
	// MathLang.g:116:1: ifstatement : IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )* ;
	[GrammarRule("ifstatement")]
	private MathLangParser.ifstatement_return ifstatement()
	{
		Enter_ifstatement();
		EnterRule("ifstatement", 28);
		TraceIn("ifstatement", 28);
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
		DebugLocation(116, 91);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 28)) { return retval; }
			// MathLang.g:116:12: ( IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )* )
			DebugEnterAlt(1);
			// MathLang.g:116:14: IF '(' boolexpression ')' ( block | statement ) ( ELSE ( block | statement ) )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(116, 16);
			IF94=(IToken)Match(input,IF,Follow._IF_in_ifstatement1017); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			IF94_tree = (object)adaptor.Create(IF94);
			root_0 = (object)adaptor.BecomeRoot(IF94_tree, root_0);
			}
			DebugLocation(116, 21);
			char_literal95=(IToken)Match(input,59,Follow._59_in_ifstatement1020); if (state.failed) return retval;
			DebugLocation(116, 23);
			PushFollow(Follow._boolexpression_in_ifstatement1023);
			boolexpression96=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression96.Tree);
			DebugLocation(116, 41);
			char_literal97=(IToken)Match(input,60,Follow._60_in_ifstatement1025); if (state.failed) return retval;
			DebugLocation(116, 43);
			// MathLang.g:116:43: ( block | statement )
			int alt21=2;
			try { DebugEnterSubRule(21);
			try { DebugEnterDecision(21, decisionCanBacktrack[21]);
			int LA21_0 = input.LA(1);

			if ((LA21_0==63))
			{
				alt21=1;
			}
			else if ((LA21_0==IF||LA21_0==FOR||(LA21_0>=RETURN && LA21_0<=DO)||LA21_0==TYPE||LA21_0==ID||(LA21_0>=KNEW && LA21_0<=CONSOLE_WORD)))
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
				// MathLang.g:116:44: block
				{
				DebugLocation(116, 44);
				PushFollow(Follow._block_in_ifstatement1029);
				block98=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block98.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:116:52: statement
				{
				DebugLocation(116, 52);
				PushFollow(Follow._statement_in_ifstatement1033);
				statement99=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement99.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(21); }

			DebugLocation(116, 63);
			// MathLang.g:116:63: ( ELSE ( block | statement ) )*
			try { DebugEnterSubRule(23);
			while (true)
			{
				int alt23=2;
				try { DebugEnterDecision(23, decisionCanBacktrack[23]);
				int LA23_0 = input.LA(1);

				if ((LA23_0==ELSE))
				{
					int LA23_1 = input.LA(2);

					if ((EvaluatePredicate(synpred48_MathLang_fragment)))
					{
						alt23=1;
					}


				}


				} finally { DebugExitDecision(23); }
				switch ( alt23 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:116:64: ELSE ( block | statement )
					{
					DebugLocation(116, 68);
					ELSE100=(IToken)Match(input,ELSE,Follow._ELSE_in_ifstatement1037); if (state.failed) return retval;
					DebugLocation(116, 70);
					// MathLang.g:116:70: ( block | statement )
					int alt22=2;
					try { DebugEnterSubRule(22);
					try { DebugEnterDecision(22, decisionCanBacktrack[22]);
					int LA22_0 = input.LA(1);

					if ((LA22_0==63))
					{
						alt22=1;
					}
					else if ((LA22_0==IF||LA22_0==FOR||(LA22_0>=RETURN && LA22_0<=DO)||LA22_0==TYPE||LA22_0==ID||(LA22_0>=KNEW && LA22_0<=CONSOLE_WORD)))
					{
						alt22=2;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 22, 0, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
					} finally { DebugExitDecision(22); }
					switch (alt22)
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:116:71: block
						{
						DebugLocation(116, 71);
						PushFollow(Follow._block_in_ifstatement1041);
						block101=block();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block101.Tree);

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// MathLang.g:116:79: statement
						{
						DebugLocation(116, 79);
						PushFollow(Follow._statement_in_ifstatement1045);
						statement102=statement();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement102.Tree);

						}
						break;

					}
					} finally { DebugExitSubRule(22); }


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

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("ifstatement", 28);
			LeaveRule("ifstatement", 28);
			Leave_ifstatement();
			if (state.backtracking > 0) { Memoize(input, 28, ifstatement_StartIndex); }
		}
		DebugLocation(116, 91);
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
	// MathLang.g:117:1: whilestatement : WHILE '(' boolexpression ')' ( block | statement ) ;
	[GrammarRule("whilestatement")]
	private MathLangParser.whilestatement_return whilestatement()
	{
		Enter_whilestatement();
		EnterRule("whilestatement", 29);
		TraceIn("whilestatement", 29);
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
		DebugLocation(117, 67);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 29)) { return retval; }
			// MathLang.g:117:15: ( WHILE '(' boolexpression ')' ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:117:17: WHILE '(' boolexpression ')' ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(117, 22);
			WHILE103=(IToken)Match(input,WHILE,Follow._WHILE_in_whilestatement1055); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			WHILE103_tree = (object)adaptor.Create(WHILE103);
			root_0 = (object)adaptor.BecomeRoot(WHILE103_tree, root_0);
			}
			DebugLocation(117, 27);
			char_literal104=(IToken)Match(input,59,Follow._59_in_whilestatement1058); if (state.failed) return retval;
			DebugLocation(117, 29);
			PushFollow(Follow._boolexpression_in_whilestatement1061);
			boolexpression105=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression105.Tree);
			DebugLocation(117, 47);
			char_literal106=(IToken)Match(input,60,Follow._60_in_whilestatement1063); if (state.failed) return retval;
			DebugLocation(117, 49);
			// MathLang.g:117:49: ( block | statement )
			int alt24=2;
			try { DebugEnterSubRule(24);
			try { DebugEnterDecision(24, decisionCanBacktrack[24]);
			int LA24_0 = input.LA(1);

			if ((LA24_0==63))
			{
				alt24=1;
			}
			else if ((LA24_0==IF||LA24_0==FOR||(LA24_0>=RETURN && LA24_0<=DO)||LA24_0==TYPE||LA24_0==ID||(LA24_0>=KNEW && LA24_0<=CONSOLE_WORD)))
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
				// MathLang.g:117:50: block
				{
				DebugLocation(117, 50);
				PushFollow(Follow._block_in_whilestatement1067);
				block107=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block107.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:117:58: statement
				{
				DebugLocation(117, 58);
				PushFollow(Follow._statement_in_whilestatement1071);
				statement108=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement108.Tree);

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
			TraceOut("whilestatement", 29);
			LeaveRule("whilestatement", 29);
			Leave_whilestatement();
			if (state.backtracking > 0) { Memoize(input, 29, whilestatement_StartIndex); }
		}
		DebugLocation(117, 67);
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
	// MathLang.g:118:1: forstatement : FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement ) ;
	[GrammarRule("forstatement")]
	private MathLangParser.forstatement_return forstatement()
	{
		Enter_forstatement();
		EnterRule("forstatement", 30);
		TraceIn("forstatement", 30);
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
		DebugLocation(118, 108);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 30)) { return retval; }
			// MathLang.g:118:13: ( FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:118:15: FOR '(' longdeclarationbody ';' boolexpression ';' assignmentbody ')' ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(118, 18);
			FOR109=(IToken)Match(input,FOR,Follow._FOR_in_forstatement1078); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			FOR109_tree = (object)adaptor.Create(FOR109);
			root_0 = (object)adaptor.BecomeRoot(FOR109_tree, root_0);
			}
			DebugLocation(118, 23);
			char_literal110=(IToken)Match(input,59,Follow._59_in_forstatement1081); if (state.failed) return retval;
			DebugLocation(118, 25);
			PushFollow(Follow._longdeclarationbody_in_forstatement1084);
			longdeclarationbody111=longdeclarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclarationbody111.Tree);
			DebugLocation(118, 48);
			char_literal112=(IToken)Match(input,58,Follow._58_in_forstatement1086); if (state.failed) return retval;
			DebugLocation(118, 50);
			PushFollow(Follow._boolexpression_in_forstatement1089);
			boolexpression113=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression113.Tree);
			DebugLocation(118, 68);
			char_literal114=(IToken)Match(input,58,Follow._58_in_forstatement1091); if (state.failed) return retval;
			DebugLocation(118, 70);
			PushFollow(Follow._assignmentbody_in_forstatement1094);
			assignmentbody115=assignmentbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentbody115.Tree);
			DebugLocation(118, 88);
			char_literal116=(IToken)Match(input,60,Follow._60_in_forstatement1096); if (state.failed) return retval;
			DebugLocation(118, 90);
			// MathLang.g:118:90: ( block | statement )
			int alt25=2;
			try { DebugEnterSubRule(25);
			try { DebugEnterDecision(25, decisionCanBacktrack[25]);
			int LA25_0 = input.LA(1);

			if ((LA25_0==63))
			{
				alt25=1;
			}
			else if ((LA25_0==IF||LA25_0==FOR||(LA25_0>=RETURN && LA25_0<=DO)||LA25_0==TYPE||LA25_0==ID||(LA25_0>=KNEW && LA25_0<=CONSOLE_WORD)))
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
				// MathLang.g:118:91: block
				{
				DebugLocation(118, 91);
				PushFollow(Follow._block_in_forstatement1100);
				block117=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block117.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:118:99: statement
				{
				DebugLocation(118, 99);
				PushFollow(Follow._statement_in_forstatement1104);
				statement118=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement118.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(25); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("forstatement", 30);
			LeaveRule("forstatement", 30);
			Leave_forstatement();
			if (state.backtracking > 0) { Memoize(input, 30, forstatement_StartIndex); }
		}
		DebugLocation(118, 108);
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
	// MathLang.g:119:1: returnstatement : RETURN expression ';' ;
	[GrammarRule("returnstatement")]
	private MathLangParser.returnstatement_return returnstatement()
	{
		Enter_returnstatement();
		EnterRule("returnstatement", 31);
		TraceIn("returnstatement", 31);
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
		DebugLocation(119, 41);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 31)) { return retval; }
			// MathLang.g:119:16: ( RETURN expression ';' )
			DebugEnterAlt(1);
			// MathLang.g:119:18: RETURN expression ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(119, 24);
			RETURN119=(IToken)Match(input,RETURN,Follow._RETURN_in_returnstatement1111); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			RETURN119_tree = (object)adaptor.Create(RETURN119);
			root_0 = (object)adaptor.BecomeRoot(RETURN119_tree, root_0);
			}
			DebugLocation(119, 26);
			PushFollow(Follow._expression_in_returnstatement1114);
			expression120=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression120.Tree);
			DebugLocation(119, 40);
			char_literal121=(IToken)Match(input,58,Follow._58_in_returnstatement1116); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("returnstatement", 31);
			LeaveRule("returnstatement", 31);
			Leave_returnstatement();
			if (state.backtracking > 0) { Memoize(input, 31, returnstatement_StartIndex); }
		}
		DebugLocation(119, 41);
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
	// MathLang.g:120:1: dowhilestatement : DO ( block | statement ) WHILE '(' boolexpression ')' ';' ;
	[GrammarRule("dowhilestatement")]
	private MathLangParser.dowhilestatement_return dowhilestatement()
	{
		Enter_dowhilestatement();
		EnterRule("dowhilestatement", 32);
		TraceIn("dowhilestatement", 32);
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
		DebugLocation(120, 79);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 32)) { return retval; }
			// MathLang.g:120:17: ( DO ( block | statement ) WHILE '(' boolexpression ')' ';' )
			DebugEnterAlt(1);
			// MathLang.g:120:19: DO ( block | statement ) WHILE '(' boolexpression ')' ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(120, 21);
			DO122=(IToken)Match(input,DO,Follow._DO_in_dowhilestatement1124); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			DO122_tree = (object)adaptor.Create(DO122);
			root_0 = (object)adaptor.BecomeRoot(DO122_tree, root_0);
			}
			DebugLocation(120, 23);
			// MathLang.g:120:23: ( block | statement )
			int alt26=2;
			try { DebugEnterSubRule(26);
			try { DebugEnterDecision(26, decisionCanBacktrack[26]);
			int LA26_0 = input.LA(1);

			if ((LA26_0==63))
			{
				alt26=1;
			}
			else if ((LA26_0==IF||LA26_0==FOR||(LA26_0>=RETURN && LA26_0<=DO)||LA26_0==TYPE||LA26_0==ID||(LA26_0>=KNEW && LA26_0<=CONSOLE_WORD)))
			{
				alt26=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 26, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(26); }
			switch (alt26)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:120:24: block
				{
				DebugLocation(120, 24);
				PushFollow(Follow._block_in_dowhilestatement1128);
				block123=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block123.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:120:32: statement
				{
				DebugLocation(120, 32);
				PushFollow(Follow._statement_in_dowhilestatement1132);
				statement124=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement124.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(26); }

			DebugLocation(120, 48);
			WHILE125=(IToken)Match(input,WHILE,Follow._WHILE_in_dowhilestatement1135); if (state.failed) return retval;
			DebugLocation(120, 53);
			char_literal126=(IToken)Match(input,59,Follow._59_in_dowhilestatement1138); if (state.failed) return retval;
			DebugLocation(120, 55);
			PushFollow(Follow._boolexpression_in_dowhilestatement1141);
			boolexpression127=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression127.Tree);
			DebugLocation(120, 73);
			char_literal128=(IToken)Match(input,60,Follow._60_in_dowhilestatement1143); if (state.failed) return retval;
			DebugLocation(120, 78);
			char_literal129=(IToken)Match(input,58,Follow._58_in_dowhilestatement1146); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("dowhilestatement", 32);
			LeaveRule("dowhilestatement", 32);
			Leave_dowhilestatement();
			if (state.backtracking > 0) { Memoize(input, 32, dowhilestatement_StartIndex); }
		}
		DebugLocation(120, 79);
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
	// MathLang.g:122:1: funcdeclaration : any_type ID ( '(' ( paramsdeclaration )? ')' | '()' ) block -> ^( FUNCDECLARATION ID ^( RETURN_TYPE any_type ) ( paramsdeclaration )? block ) ;
	[GrammarRule("funcdeclaration")]
	private MathLangParser.funcdeclaration_return funcdeclaration()
	{
		Enter_funcdeclaration();
		EnterRule("funcdeclaration", 33);
		TraceIn("funcdeclaration", 33);
		MathLangParser.funcdeclaration_return retval = new MathLangParser.funcdeclaration_return();
		retval.Start = (IToken)input.LT(1);
		int funcdeclaration_StartIndex = input.Index;
		object root_0 = null;

		IToken ID131=null;
		IToken char_literal132=null;
		IToken char_literal134=null;
		IToken string_literal135=null;
		MathLangParser.any_type_return any_type130 = default(MathLangParser.any_type_return);
		MathLangParser.paramsdeclaration_return paramsdeclaration133 = default(MathLangParser.paramsdeclaration_return);
		MathLangParser.block_return block136 = default(MathLangParser.block_return);

		object ID131_tree=null;
		object char_literal132_tree=null;
		object char_literal134_tree=null;
		object string_literal135_tree=null;
		RewriteRuleITokenStream stream_59=new RewriteRuleITokenStream(adaptor,"token 59");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_60=new RewriteRuleITokenStream(adaptor,"token 60");
		RewriteRuleITokenStream stream_61=new RewriteRuleITokenStream(adaptor,"token 61");
		RewriteRuleSubtreeStream stream_paramsdeclaration=new RewriteRuleSubtreeStream(adaptor,"rule paramsdeclaration");
		RewriteRuleSubtreeStream stream_block=new RewriteRuleSubtreeStream(adaptor,"rule block");
		RewriteRuleSubtreeStream stream_any_type=new RewriteRuleSubtreeStream(adaptor,"rule any_type");
		try { DebugEnterRule(GrammarFileName, "funcdeclaration");
		DebugLocation(122, 159);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 33)) { return retval; }
			// MathLang.g:122:16: ( any_type ID ( '(' ( paramsdeclaration )? ')' | '()' ) block -> ^( FUNCDECLARATION ID ^( RETURN_TYPE any_type ) ( paramsdeclaration )? block ) )
			DebugEnterAlt(1);
			// MathLang.g:122:18: any_type ID ( '(' ( paramsdeclaration )? ')' | '()' ) block
			{
			DebugLocation(122, 18);
			PushFollow(Follow._any_type_in_funcdeclaration1155);
			any_type130=any_type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_any_type.Add(any_type130.Tree);
			DebugLocation(122, 29);
			ID131=(IToken)Match(input,ID,Follow._ID_in_funcdeclaration1157); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID131);

			DebugLocation(122, 31);
			// MathLang.g:122:31: ( '(' ( paramsdeclaration )? ')' | '()' )
			int alt28=2;
			try { DebugEnterSubRule(28);
			try { DebugEnterDecision(28, decisionCanBacktrack[28]);
			int LA28_0 = input.LA(1);

			if ((LA28_0==59))
			{
				alt28=1;
			}
			else if ((LA28_0==61))
			{
				alt28=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 28, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(28); }
			switch (alt28)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:122:33: '(' ( paramsdeclaration )? ')'
				{
				DebugLocation(122, 36);
				char_literal132=(IToken)Match(input,59,Follow._59_in_funcdeclaration1162); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_59.Add(char_literal132);

				DebugLocation(122, 38);
				// MathLang.g:122:38: ( paramsdeclaration )?
				int alt27=2;
				try { DebugEnterSubRule(27);
				try { DebugEnterDecision(27, decisionCanBacktrack[27]);
				int LA27_0 = input.LA(1);

				if ((LA27_0==TYPE))
				{
					alt27=1;
				}
				} finally { DebugExitDecision(27); }
				switch (alt27)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: paramsdeclaration
					{
					DebugLocation(122, 38);
					PushFollow(Follow._paramsdeclaration_in_funcdeclaration1165);
					paramsdeclaration133=paramsdeclaration();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_paramsdeclaration.Add(paramsdeclaration133.Tree);

					}
					break;

				}
				} finally { DebugExitSubRule(27); }

				DebugLocation(122, 60);
				char_literal134=(IToken)Match(input,60,Follow._60_in_funcdeclaration1168); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_60.Add(char_literal134);


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:122:64: '()'
				{
				DebugLocation(122, 68);
				string_literal135=(IToken)Match(input,61,Follow._61_in_funcdeclaration1173); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_61.Add(string_literal135);


				}
				break;

			}
			} finally { DebugExitSubRule(28); }

			DebugLocation(122, 71);
			PushFollow(Follow._block_in_funcdeclaration1177);
			block136=block();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_block.Add(block136.Tree);


			{
			// AST REWRITE
			// elements: any_type, paramsdeclaration, block, ID
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 122:77: -> ^( FUNCDECLARATION ID ^( RETURN_TYPE any_type ) ( paramsdeclaration )? block )
			{
				DebugLocation(122, 80);
				// MathLang.g:122:80: ^( FUNCDECLARATION ID ^( RETURN_TYPE any_type ) ( paramsdeclaration )? block )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(122, 82);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNCDECLARATION, "FUNCDECLARATION"), root_1);

				DebugLocation(122, 98);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(122, 101);
				// MathLang.g:122:101: ^( RETURN_TYPE any_type )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(122, 103);
				root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(RETURN_TYPE, "RETURN_TYPE"), root_2);

				DebugLocation(122, 115);
				adaptor.AddChild(root_2, stream_any_type.NextTree());

				adaptor.AddChild(root_1, root_2);
				}
				DebugLocation(122, 130);
				// MathLang.g:122:130: ( paramsdeclaration )?
				if ( stream_paramsdeclaration.HasNext )
				{
					DebugLocation(122, 130);
					adaptor.AddChild(root_1, stream_paramsdeclaration.NextTree());

				}
				stream_paramsdeclaration.Reset();
				DebugLocation(122, 154);
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
			TraceOut("funcdeclaration", 33);
			LeaveRule("funcdeclaration", 33);
			Leave_funcdeclaration();
			if (state.backtracking > 0) { Memoize(input, 33, funcdeclaration_StartIndex); }
		}
		DebugLocation(122, 159);
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
	// MathLang.g:123:1: paramsdeclaration : ( declarationbody ( ',' declarationbody )* ) -> ^( PARAMETERS ( declarationbody )* ) ;
	[GrammarRule("paramsdeclaration")]
	private MathLangParser.paramsdeclaration_return paramsdeclaration()
	{
		Enter_paramsdeclaration();
		EnterRule("paramsdeclaration", 34);
		TraceIn("paramsdeclaration", 34);
		MathLangParser.paramsdeclaration_return retval = new MathLangParser.paramsdeclaration_return();
		retval.Start = (IToken)input.LT(1);
		int paramsdeclaration_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal138=null;
		MathLangParser.declarationbody_return declarationbody137 = default(MathLangParser.declarationbody_return);
		MathLangParser.declarationbody_return declarationbody139 = default(MathLangParser.declarationbody_return);

		object char_literal138_tree=null;
		RewriteRuleITokenStream stream_62=new RewriteRuleITokenStream(adaptor,"token 62");
		RewriteRuleSubtreeStream stream_declarationbody=new RewriteRuleSubtreeStream(adaptor,"rule declarationbody");
		try { DebugEnterRule(GrammarFileName, "paramsdeclaration");
		DebugLocation(123, 102);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 34)) { return retval; }
			// MathLang.g:123:18: ( ( declarationbody ( ',' declarationbody )* ) -> ^( PARAMETERS ( declarationbody )* ) )
			DebugEnterAlt(1);
			// MathLang.g:123:20: ( declarationbody ( ',' declarationbody )* )
			{
			DebugLocation(123, 20);
			// MathLang.g:123:20: ( declarationbody ( ',' declarationbody )* )
			DebugEnterAlt(1);
			// MathLang.g:123:22: declarationbody ( ',' declarationbody )*
			{
			DebugLocation(123, 22);
			PushFollow(Follow._declarationbody_in_paramsdeclaration1210);
			declarationbody137=declarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declarationbody.Add(declarationbody137.Tree);
			DebugLocation(123, 38);
			// MathLang.g:123:38: ( ',' declarationbody )*
			try { DebugEnterSubRule(29);
			while (true)
			{
				int alt29=2;
				try { DebugEnterDecision(29, decisionCanBacktrack[29]);
				int LA29_0 = input.LA(1);

				if ((LA29_0==62))
				{
					alt29=1;
				}


				} finally { DebugExitDecision(29); }
				switch ( alt29 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:123:40: ',' declarationbody
					{
					DebugLocation(123, 43);
					char_literal138=(IToken)Match(input,62,Follow._62_in_paramsdeclaration1214); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_62.Add(char_literal138);

					DebugLocation(123, 45);
					PushFollow(Follow._declarationbody_in_paramsdeclaration1217);
					declarationbody139=declarationbody();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_declarationbody.Add(declarationbody139.Tree);

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
			// 123:66: -> ^( PARAMETERS ( declarationbody )* )
			{
				DebugLocation(123, 69);
				// MathLang.g:123:69: ^( PARAMETERS ( declarationbody )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(123, 71);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_1);

				DebugLocation(123, 82);
				// MathLang.g:123:82: ( declarationbody )*
				while ( stream_declarationbody.HasNext )
				{
					DebugLocation(123, 84);
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
			TraceOut("paramsdeclaration", 34);
			LeaveRule("paramsdeclaration", 34);
			Leave_paramsdeclaration();
			if (state.backtracking > 0) { Memoize(input, 34, paramsdeclaration_StartIndex); }
		}
		DebugLocation(123, 102);
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
	// MathLang.g:125:1: funccallbody : ID '(' ( expressioncommalist )? ')' -> ^( FUNC_CALL ^( ID ( ^( PARAMETERS expressioncommalist ) )? ) ) ;
	[GrammarRule("funccallbody")]
	private MathLangParser.funccallbody_return funccallbody()
	{
		Enter_funccallbody();
		EnterRule("funccallbody", 35);
		TraceIn("funccallbody", 35);
		MathLangParser.funccallbody_return retval = new MathLangParser.funccallbody_return();
		retval.Start = (IToken)input.LT(1);
		int funccallbody_StartIndex = input.Index;
		object root_0 = null;

		IToken ID140=null;
		IToken char_literal141=null;
		IToken char_literal143=null;
		MathLangParser.expressioncommalist_return expressioncommalist142 = default(MathLangParser.expressioncommalist_return);

		object ID140_tree=null;
		object char_literal141_tree=null;
		object char_literal143_tree=null;
		RewriteRuleITokenStream stream_59=new RewriteRuleITokenStream(adaptor,"token 59");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_60=new RewriteRuleITokenStream(adaptor,"token 60");
		RewriteRuleSubtreeStream stream_expressioncommalist=new RewriteRuleSubtreeStream(adaptor,"rule expressioncommalist");
		try { DebugEnterRule(GrammarFileName, "funccallbody");
		DebugLocation(125, 103);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 35)) { return retval; }
			// MathLang.g:125:13: ( ID '(' ( expressioncommalist )? ')' -> ^( FUNC_CALL ^( ID ( ^( PARAMETERS expressioncommalist ) )? ) ) )
			DebugEnterAlt(1);
			// MathLang.g:125:15: ID '(' ( expressioncommalist )? ')'
			{
			DebugLocation(125, 17);
			ID140=(IToken)Match(input,ID,Follow._ID_in_funccallbody1242); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID140);

			DebugLocation(125, 19);
			char_literal141=(IToken)Match(input,59,Follow._59_in_funccallbody1245); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_59.Add(char_literal141);

			DebugLocation(125, 23);
			// MathLang.g:125:23: ( expressioncommalist )?
			int alt30=2;
			try { DebugEnterSubRule(30);
			try { DebugEnterDecision(30, decisionCanBacktrack[30]);
			int LA30_0 = input.LA(1);

			if (((LA30_0>=NUMBER && LA30_0<=CHAR)||LA30_0==SUB||(LA30_0>=NOT && LA30_0<=CONSOLE_WORD)||LA30_0==59))
			{
				alt30=1;
			}
			} finally { DebugExitDecision(30); }
			switch (alt30)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: expressioncommalist
				{
				DebugLocation(125, 23);
				PushFollow(Follow._expressioncommalist_in_funccallbody1247);
				expressioncommalist142=expressioncommalist();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expressioncommalist.Add(expressioncommalist142.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(30); }

			DebugLocation(125, 44);
			char_literal143=(IToken)Match(input,60,Follow._60_in_funccallbody1250); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_60.Add(char_literal143);



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
			// 125:48: -> ^( FUNC_CALL ^( ID ( ^( PARAMETERS expressioncommalist ) )? ) )
			{
				DebugLocation(125, 51);
				// MathLang.g:125:51: ^( FUNC_CALL ^( ID ( ^( PARAMETERS expressioncommalist ) )? ) )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(125, 53);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_CALL, "FUNC_CALL"), root_1);

				DebugLocation(125, 63);
				// MathLang.g:125:63: ^( ID ( ^( PARAMETERS expressioncommalist ) )? )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(125, 65);
				root_2 = (object)adaptor.BecomeRoot(stream_ID.NextNode(), root_2);

				DebugLocation(125, 68);
				// MathLang.g:125:68: ( ^( PARAMETERS expressioncommalist ) )?
				if ( stream_expressioncommalist.HasNext )
				{
					DebugLocation(125, 68);
					// MathLang.g:125:68: ^( PARAMETERS expressioncommalist )
					{
					object root_3 = (object)adaptor.Nil();
					DebugLocation(125, 70);
					root_3 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_3);

					DebugLocation(125, 81);
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
			TraceOut("funccallbody", 35);
			LeaveRule("funccallbody", 35);
			Leave_funccallbody();
			if (state.backtracking > 0) { Memoize(input, 35, funccallbody_StartIndex); }
		}
		DebugLocation(125, 103);
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
	// MathLang.g:126:1: funccall : funccallbody ';' ;
	[GrammarRule("funccall")]
	private MathLangParser.funccall_return funccall()
	{
		Enter_funccall();
		EnterRule("funccall", 36);
		TraceIn("funccall", 36);
		MathLangParser.funccall_return retval = new MathLangParser.funccall_return();
		retval.Start = (IToken)input.LT(1);
		int funccall_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal145=null;
		MathLangParser.funccallbody_return funccallbody144 = default(MathLangParser.funccallbody_return);

		object char_literal145_tree=null;

		try { DebugEnterRule(GrammarFileName, "funccall");
		DebugLocation(126, 27);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 36)) { return retval; }
			// MathLang.g:126:9: ( funccallbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:126:11: funccallbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(126, 11);
			PushFollow(Follow._funccallbody_in_funccall1273);
			funccallbody144=funccallbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody144.Tree);
			DebugLocation(126, 27);
			char_literal145=(IToken)Match(input,58,Follow._58_in_funccall1275); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("funccall", 36);
			LeaveRule("funccall", 36);
			Leave_funccall();
			if (state.backtracking > 0) { Memoize(input, 36, funccall_StartIndex); }
		}
		DebugLocation(126, 27);
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
	// MathLang.g:127:1: expressioncommalist : expression ( ',' expression )* ;
	[GrammarRule("expressioncommalist")]
	private MathLangParser.expressioncommalist_return expressioncommalist()
	{
		Enter_expressioncommalist();
		EnterRule("expressioncommalist", 37);
		TraceIn("expressioncommalist", 37);
		MathLangParser.expressioncommalist_return retval = new MathLangParser.expressioncommalist_return();
		retval.Start = (IToken)input.LT(1);
		int expressioncommalist_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal147=null;
		MathLangParser.expression_return expression146 = default(MathLangParser.expression_return);
		MathLangParser.expression_return expression148 = default(MathLangParser.expression_return);

		object char_literal147_tree=null;

		try { DebugEnterRule(GrammarFileName, "expressioncommalist");
		DebugLocation(127, 51);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 37)) { return retval; }
			// MathLang.g:127:20: ( expression ( ',' expression )* )
			DebugEnterAlt(1);
			// MathLang.g:127:22: expression ( ',' expression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(127, 22);
			PushFollow(Follow._expression_in_expressioncommalist1282);
			expression146=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression146.Tree);
			DebugLocation(127, 33);
			// MathLang.g:127:33: ( ',' expression )*
			try { DebugEnterSubRule(31);
			while (true)
			{
				int alt31=2;
				try { DebugEnterDecision(31, decisionCanBacktrack[31]);
				int LA31_0 = input.LA(1);

				if ((LA31_0==62))
				{
					alt31=1;
				}


				} finally { DebugExitDecision(31); }
				switch ( alt31 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:127:35: ',' expression
					{
					DebugLocation(127, 38);
					char_literal147=(IToken)Match(input,62,Follow._62_in_expressioncommalist1286); if (state.failed) return retval;
					DebugLocation(127, 40);
					PushFollow(Follow._expression_in_expressioncommalist1289);
					expression148=expression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression148.Tree);

					}
					break;

				default:
					goto loop31;
				}
			}

			loop31:
				;

			} finally { DebugExitSubRule(31); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expressioncommalist", 37);
			LeaveRule("expressioncommalist", 37);
			Leave_expressioncommalist();
			if (state.backtracking > 0) { Memoize(input, 37, expressioncommalist_StartIndex); }
		}
		DebugLocation(127, 51);
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
	// MathLang.g:130:1: object_initializer : '{' expressioncommalist '}' -> ^( PARAMETERS expressioncommalist ) ;
	[GrammarRule("object_initializer")]
	private MathLangParser.object_initializer_return object_initializer()
	{
		Enter_object_initializer();
		EnterRule("object_initializer", 38);
		TraceIn("object_initializer", 38);
		MathLangParser.object_initializer_return retval = new MathLangParser.object_initializer_return();
		retval.Start = (IToken)input.LT(1);
		int object_initializer_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal149=null;
		IToken char_literal151=null;
		MathLangParser.expressioncommalist_return expressioncommalist150 = default(MathLangParser.expressioncommalist_return);

		object char_literal149_tree=null;
		object char_literal151_tree=null;
		RewriteRuleITokenStream stream_64=new RewriteRuleITokenStream(adaptor,"token 64");
		RewriteRuleITokenStream stream_63=new RewriteRuleITokenStream(adaptor,"token 63");
		RewriteRuleSubtreeStream stream_expressioncommalist=new RewriteRuleSubtreeStream(adaptor,"rule expressioncommalist");
		try { DebugEnterRule(GrammarFileName, "object_initializer");
		DebugLocation(130, 86);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 38)) { return retval; }
			// MathLang.g:130:19: ( '{' expressioncommalist '}' -> ^( PARAMETERS expressioncommalist ) )
			DebugEnterAlt(1);
			// MathLang.g:130:22: '{' expressioncommalist '}'
			{
			DebugLocation(130, 22);
			char_literal149=(IToken)Match(input,63,Follow._63_in_object_initializer1301); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_63.Add(char_literal149);

			DebugLocation(130, 26);
			PushFollow(Follow._expressioncommalist_in_object_initializer1303);
			expressioncommalist150=expressioncommalist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expressioncommalist.Add(expressioncommalist150.Tree);
			DebugLocation(130, 46);
			char_literal151=(IToken)Match(input,64,Follow._64_in_object_initializer1305); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_64.Add(char_literal151);



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
			// 130:50: -> ^( PARAMETERS expressioncommalist )
			{
				DebugLocation(130, 53);
				// MathLang.g:130:53: ^( PARAMETERS expressioncommalist )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(130, 55);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_1);

				DebugLocation(130, 66);
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
			TraceOut("object_initializer", 38);
			LeaveRule("object_initializer", 38);
			Leave_object_initializer();
			if (state.backtracking > 0) { Memoize(input, 38, object_initializer_StartIndex); }
		}
		DebugLocation(130, 86);
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
	// MathLang.g:131:1: newexpression : KNEW initializer ;
	[GrammarRule("newexpression")]
	private MathLangParser.newexpression_return newexpression()
	{
		Enter_newexpression();
		EnterRule("newexpression", 39);
		TraceIn("newexpression", 39);
		MathLangParser.newexpression_return retval = new MathLangParser.newexpression_return();
		retval.Start = (IToken)input.LT(1);
		int newexpression_StartIndex = input.Index;
		object root_0 = null;

		IToken KNEW152=null;
		MathLangParser.initializer_return initializer153 = default(MathLangParser.initializer_return);

		object KNEW152_tree=null;

		try { DebugEnterRule(GrammarFileName, "newexpression");
		DebugLocation(131, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 39)) { return retval; }
			// MathLang.g:131:14: ( KNEW initializer )
			DebugEnterAlt(1);
			// MathLang.g:131:16: KNEW initializer
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(131, 20);
			KNEW152=(IToken)Match(input,KNEW,Follow._KNEW_in_newexpression1320); if (state.failed) return retval;
			DebugLocation(131, 22);
			PushFollow(Follow._initializer_in_newexpression1323);
			initializer153=initializer();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, initializer153.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("newexpression", 39);
			LeaveRule("newexpression", 39);
			Leave_newexpression();
			if (state.backtracking > 0) { Memoize(input, 39, newexpression_StartIndex); }
		}
		DebugLocation(131, 32);
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
	// MathLang.g:132:1: initializer : ( simple_var_initializer | array_initializer ) ;
	[GrammarRule("initializer")]
	private MathLangParser.initializer_return initializer()
	{
		Enter_initializer();
		EnterRule("initializer", 40);
		TraceIn("initializer", 40);
		MathLangParser.initializer_return retval = new MathLangParser.initializer_return();
		retval.Start = (IToken)input.LT(1);
		int initializer_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.simple_var_initializer_return simple_var_initializer154 = default(MathLangParser.simple_var_initializer_return);
		MathLangParser.array_initializer_return array_initializer155 = default(MathLangParser.array_initializer_return);


		try { DebugEnterRule(GrammarFileName, "initializer");
		DebugLocation(132, 57);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 40)) { return retval; }
			// MathLang.g:132:12: ( ( simple_var_initializer | array_initializer ) )
			DebugEnterAlt(1);
			// MathLang.g:132:14: ( simple_var_initializer | array_initializer )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(132, 14);
			// MathLang.g:132:14: ( simple_var_initializer | array_initializer )
			int alt32=2;
			try { DebugEnterSubRule(32);
			try { DebugEnterDecision(32, decisionCanBacktrack[32]);
			int LA32_0 = input.LA(1);

			if ((LA32_0==TYPE))
			{
				int LA32_1 = input.LA(2);

				if ((LA32_1==59))
				{
					alt32=1;
				}
				else if ((LA32_1==ARRAY_DECLARATION_MARK||LA32_1==SQRBL))
				{
					alt32=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 32, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 32, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(32); }
			switch (alt32)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:132:15: simple_var_initializer
				{
				DebugLocation(132, 15);
				PushFollow(Follow._simple_var_initializer_in_initializer1330);
				simple_var_initializer154=simple_var_initializer();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, simple_var_initializer154.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:132:40: array_initializer
				{
				DebugLocation(132, 40);
				PushFollow(Follow._array_initializer_in_initializer1334);
				array_initializer155=array_initializer();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, array_initializer155.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(32); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("initializer", 40);
			LeaveRule("initializer", 40);
			Leave_initializer();
			if (state.backtracking > 0) { Memoize(input, 40, initializer_StartIndex); }
		}
		DebugLocation(132, 57);
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
	// MathLang.g:133:1: simple_var_initializer : type '(' ')' -> ^( NEWVAR type ) ;
	[GrammarRule("simple_var_initializer")]
	private MathLangParser.simple_var_initializer_return simple_var_initializer()
	{
		Enter_simple_var_initializer();
		EnterRule("simple_var_initializer", 41);
		TraceIn("simple_var_initializer", 41);
		MathLangParser.simple_var_initializer_return retval = new MathLangParser.simple_var_initializer_return();
		retval.Start = (IToken)input.LT(1);
		int simple_var_initializer_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal157=null;
		IToken char_literal158=null;
		MathLangParser.type_return type156 = default(MathLangParser.type_return);

		object char_literal157_tree=null;
		object char_literal158_tree=null;
		RewriteRuleITokenStream stream_59=new RewriteRuleITokenStream(adaptor,"token 59");
		RewriteRuleITokenStream stream_60=new RewriteRuleITokenStream(adaptor,"token 60");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "simple_var_initializer");
		DebugLocation(133, 54);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 41)) { return retval; }
			// MathLang.g:133:23: ( type '(' ')' -> ^( NEWVAR type ) )
			DebugEnterAlt(1);
			// MathLang.g:133:25: type '(' ')'
			{
			DebugLocation(133, 25);
			PushFollow(Follow._type_in_simple_var_initializer1341);
			type156=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type156.Tree);
			DebugLocation(133, 30);
			char_literal157=(IToken)Match(input,59,Follow._59_in_simple_var_initializer1343); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_59.Add(char_literal157);

			DebugLocation(133, 34);
			char_literal158=(IToken)Match(input,60,Follow._60_in_simple_var_initializer1345); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_60.Add(char_literal158);



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
			// 133:38: -> ^( NEWVAR type )
			{
				DebugLocation(133, 41);
				// MathLang.g:133:41: ^( NEWVAR type )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(133, 43);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(NEWVAR, "NEWVAR"), root_1);

				DebugLocation(133, 50);
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
			TraceOut("simple_var_initializer", 41);
			LeaveRule("simple_var_initializer", 41);
			Leave_simple_var_initializer();
			if (state.backtracking > 0) { Memoize(input, 41, simple_var_initializer_StartIndex); }
		}
		DebugLocation(133, 54);
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
	// MathLang.g:134:1: array_initializer : type ( ( '[' number ']' ) | ARRAY_DECLARATION_MARK ) ( object_initializer )? -> ^( ARRAY_INITIALIZER type ( number )? ( object_initializer )? ) ;
	[GrammarRule("array_initializer")]
	private MathLangParser.array_initializer_return array_initializer()
	{
		Enter_array_initializer();
		EnterRule("array_initializer", 42);
		TraceIn("array_initializer", 42);
		MathLangParser.array_initializer_return retval = new MathLangParser.array_initializer_return();
		retval.Start = (IToken)input.LT(1);
		int array_initializer_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal160=null;
		IToken char_literal162=null;
		IToken ARRAY_DECLARATION_MARK163=null;
		MathLangParser.type_return type159 = default(MathLangParser.type_return);
		MathLangParser.number_return number161 = default(MathLangParser.number_return);
		MathLangParser.object_initializer_return object_initializer164 = default(MathLangParser.object_initializer_return);

		object char_literal160_tree=null;
		object char_literal162_tree=null;
		object ARRAY_DECLARATION_MARK163_tree=null;
		RewriteRuleITokenStream stream_ARRAY_DECLARATION_MARK=new RewriteRuleITokenStream(adaptor,"token ARRAY_DECLARATION_MARK");
		RewriteRuleITokenStream stream_SQRBR=new RewriteRuleITokenStream(adaptor,"token SQRBR");
		RewriteRuleITokenStream stream_SQRBL=new RewriteRuleITokenStream(adaptor,"token SQRBL");
		RewriteRuleSubtreeStream stream_number=new RewriteRuleSubtreeStream(adaptor,"rule number");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		RewriteRuleSubtreeStream stream_object_initializer=new RewriteRuleSubtreeStream(adaptor,"rule object_initializer");
		try { DebugEnterRule(GrammarFileName, "array_initializer");
		DebugLocation(134, 144);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 42)) { return retval; }
			// MathLang.g:134:18: ( type ( ( '[' number ']' ) | ARRAY_DECLARATION_MARK ) ( object_initializer )? -> ^( ARRAY_INITIALIZER type ( number )? ( object_initializer )? ) )
			DebugEnterAlt(1);
			// MathLang.g:134:20: type ( ( '[' number ']' ) | ARRAY_DECLARATION_MARK ) ( object_initializer )?
			{
			DebugLocation(134, 20);
			PushFollow(Follow._type_in_array_initializer1359);
			type159=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type159.Tree);
			DebugLocation(134, 25);
			// MathLang.g:134:25: ( ( '[' number ']' ) | ARRAY_DECLARATION_MARK )
			int alt33=2;
			try { DebugEnterSubRule(33);
			try { DebugEnterDecision(33, decisionCanBacktrack[33]);
			int LA33_0 = input.LA(1);

			if ((LA33_0==SQRBL))
			{
				alt33=1;
			}
			else if ((LA33_0==ARRAY_DECLARATION_MARK))
			{
				alt33=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 33, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(33); }
			switch (alt33)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:134:26: ( '[' number ']' )
				{
				DebugLocation(134, 26);
				// MathLang.g:134:26: ( '[' number ']' )
				DebugEnterAlt(1);
				// MathLang.g:134:27: '[' number ']'
				{
				DebugLocation(134, 27);
				char_literal160=(IToken)Match(input,SQRBL,Follow._SQRBL_in_array_initializer1363); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_SQRBL.Add(char_literal160);

				DebugLocation(134, 31);
				PushFollow(Follow._number_in_array_initializer1365);
				number161=number();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_number.Add(number161.Tree);
				DebugLocation(134, 38);
				char_literal162=(IToken)Match(input,SQRBR,Follow._SQRBR_in_array_initializer1367); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_SQRBR.Add(char_literal162);


				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:134:45: ARRAY_DECLARATION_MARK
				{
				DebugLocation(134, 45);
				ARRAY_DECLARATION_MARK163=(IToken)Match(input,ARRAY_DECLARATION_MARK,Follow._ARRAY_DECLARATION_MARK_in_array_initializer1372); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ARRAY_DECLARATION_MARK.Add(ARRAY_DECLARATION_MARK163);


				}
				break;

			}
			} finally { DebugExitSubRule(33); }

			DebugLocation(134, 69);
			// MathLang.g:134:69: ( object_initializer )?
			int alt34=2;
			try { DebugEnterSubRule(34);
			try { DebugEnterDecision(34, decisionCanBacktrack[34]);
			int LA34_0 = input.LA(1);

			if ((LA34_0==63))
			{
				alt34=1;
			}
			} finally { DebugExitDecision(34); }
			switch (alt34)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: object_initializer
				{
				DebugLocation(134, 69);
				PushFollow(Follow._object_initializer_in_array_initializer1375);
				object_initializer164=object_initializer();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_object_initializer.Add(object_initializer164.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(34); }



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
			// 134:89: -> ^( ARRAY_INITIALIZER type ( number )? ( object_initializer )? )
			{
				DebugLocation(134, 92);
				// MathLang.g:134:92: ^( ARRAY_INITIALIZER type ( number )? ( object_initializer )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(134, 94);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAY_INITIALIZER, "ARRAY_INITIALIZER"), root_1);

				DebugLocation(134, 112);
				adaptor.AddChild(root_1, stream_type.NextTree());
				DebugLocation(134, 117);
				// MathLang.g:134:117: ( number )?
				if ( stream_number.HasNext )
				{
					DebugLocation(134, 117);
					adaptor.AddChild(root_1, stream_number.NextTree());

				}
				stream_number.Reset();
				DebugLocation(134, 125);
				// MathLang.g:134:125: ( object_initializer )?
				if ( stream_object_initializer.HasNext )
				{
					DebugLocation(134, 125);
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
			TraceOut("array_initializer", 42);
			LeaveRule("array_initializer", 42);
			Leave_array_initializer();
			if (state.backtracking > 0) { Memoize(input, 42, array_initializer_StartIndex); }
		}
		DebugLocation(134, 144);
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
	// MathLang.g:136:1: block : '{' statementlist '}' ;
	[GrammarRule("block")]
	private MathLangParser.block_return block()
	{
		Enter_block();
		EnterRule("block", 43);
		TraceIn("block", 43);
		MathLangParser.block_return retval = new MathLangParser.block_return();
		retval.Start = (IToken)input.LT(1);
		int block_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal165=null;
		IToken char_literal167=null;
		MathLangParser.statementlist_return statementlist166 = default(MathLangParser.statementlist_return);

		object char_literal165_tree=null;
		object char_literal167_tree=null;

		try { DebugEnterRule(GrammarFileName, "block");
		DebugLocation(136, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 43)) { return retval; }
			// MathLang.g:136:6: ( '{' statementlist '}' )
			DebugEnterAlt(1);
			// MathLang.g:136:8: '{' statementlist '}'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(136, 11);
			char_literal165=(IToken)Match(input,63,Follow._63_in_block1397); if (state.failed) return retval;
			DebugLocation(136, 13);
			PushFollow(Follow._statementlist_in_block1400);
			statementlist166=statementlist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementlist166.Tree);
			DebugLocation(136, 30);
			char_literal167=(IToken)Match(input,64,Follow._64_in_block1402); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("block", 43);
			LeaveRule("block", 43);
			Leave_block();
			if (state.backtracking > 0) { Memoize(input, 43, block_StartIndex); }
		}
		DebugLocation(136, 30);
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
	// MathLang.g:138:1: statementlist : ( statement )* -> ^( BLOCK ( statement )* ) ;
	[GrammarRule("statementlist")]
	private MathLangParser.statementlist_return statementlist()
	{
		Enter_statementlist();
		EnterRule("statementlist", 44);
		TraceIn("statementlist", 44);
		MathLangParser.statementlist_return retval = new MathLangParser.statementlist_return();
		retval.Start = (IToken)input.LT(1);
		int statementlist_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.statement_return statement168 = default(MathLangParser.statement_return);

		RewriteRuleSubtreeStream stream_statement=new RewriteRuleSubtreeStream(adaptor,"rule statement");
		try { DebugEnterRule(GrammarFileName, "statementlist");
		DebugLocation(138, 49);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 44)) { return retval; }
			// MathLang.g:138:14: ( ( statement )* -> ^( BLOCK ( statement )* ) )
			DebugEnterAlt(1);
			// MathLang.g:138:16: ( statement )*
			{
			DebugLocation(138, 16);
			// MathLang.g:138:16: ( statement )*
			try { DebugEnterSubRule(35);
			while (true)
			{
				int alt35=2;
				try { DebugEnterDecision(35, decisionCanBacktrack[35]);
				int LA35_0 = input.LA(1);

				if ((LA35_0==IF||LA35_0==FOR||(LA35_0>=RETURN && LA35_0<=DO)||LA35_0==TYPE||LA35_0==ID||(LA35_0>=KNEW && LA35_0<=CONSOLE_WORD)))
				{
					alt35=1;
				}


				} finally { DebugExitDecision(35); }
				switch ( alt35 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: statement
					{
					DebugLocation(138, 16);
					PushFollow(Follow._statement_in_statementlist1410);
					statement168=statement();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_statement.Add(statement168.Tree);

					}
					break;

				default:
					goto loop35;
				}
			}

			loop35:
				;

			} finally { DebugExitSubRule(35); }



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
			// 138:27: -> ^( BLOCK ( statement )* )
			{
				DebugLocation(138, 30);
				// MathLang.g:138:30: ^( BLOCK ( statement )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(138, 32);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

				DebugLocation(138, 38);
				// MathLang.g:138:38: ( statement )*
				while ( stream_statement.HasNext )
				{
					DebugLocation(138, 38);
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
			TraceOut("statementlist", 44);
			LeaveRule("statementlist", 44);
			Leave_statementlist();
			if (state.backtracking > 0) { Memoize(input, 44, statementlist_StartIndex); }
		}
		DebugLocation(138, 49);
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
	// MathLang.g:140:1: console_write_statement : CONSOLE_WORD '.' ( 'WriteLine' | 'Write' ) '(' expression ')' ';' -> ^( PRINT expression ) ;
	[GrammarRule("console_write_statement")]
	private MathLangParser.console_write_statement_return console_write_statement()
	{
		Enter_console_write_statement();
		EnterRule("console_write_statement", 45);
		TraceIn("console_write_statement", 45);
		MathLangParser.console_write_statement_return retval = new MathLangParser.console_write_statement_return();
		retval.Start = (IToken)input.LT(1);
		int console_write_statement_StartIndex = input.Index;
		object root_0 = null;

		IToken CONSOLE_WORD169=null;
		IToken char_literal170=null;
		IToken string_literal171=null;
		IToken string_literal172=null;
		IToken char_literal173=null;
		IToken char_literal175=null;
		IToken char_literal176=null;
		MathLangParser.expression_return expression174 = default(MathLangParser.expression_return);

		object CONSOLE_WORD169_tree=null;
		object char_literal170_tree=null;
		object string_literal171_tree=null;
		object string_literal172_tree=null;
		object char_literal173_tree=null;
		object char_literal175_tree=null;
		object char_literal176_tree=null;
		RewriteRuleITokenStream stream_67=new RewriteRuleITokenStream(adaptor,"token 67");
		RewriteRuleITokenStream stream_CONSOLE_WORD=new RewriteRuleITokenStream(adaptor,"token CONSOLE_WORD");
		RewriteRuleITokenStream stream_66=new RewriteRuleITokenStream(adaptor,"token 66");
		RewriteRuleITokenStream stream_59=new RewriteRuleITokenStream(adaptor,"token 59");
		RewriteRuleITokenStream stream_58=new RewriteRuleITokenStream(adaptor,"token 58");
		RewriteRuleITokenStream stream_65=new RewriteRuleITokenStream(adaptor,"token 65");
		RewriteRuleITokenStream stream_60=new RewriteRuleITokenStream(adaptor,"token 60");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "console_write_statement");
		DebugLocation(140, 117);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 45)) { return retval; }
			// MathLang.g:140:24: ( CONSOLE_WORD '.' ( 'WriteLine' | 'Write' ) '(' expression ')' ';' -> ^( PRINT expression ) )
			DebugEnterAlt(1);
			// MathLang.g:140:26: CONSOLE_WORD '.' ( 'WriteLine' | 'Write' ) '(' expression ')' ';'
			{
			DebugLocation(140, 26);
			CONSOLE_WORD169=(IToken)Match(input,CONSOLE_WORD,Follow._CONSOLE_WORD_in_console_write_statement1428); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CONSOLE_WORD.Add(CONSOLE_WORD169);

			DebugLocation(140, 42);
			char_literal170=(IToken)Match(input,65,Follow._65_in_console_write_statement1430); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_65.Add(char_literal170);

			DebugLocation(140, 44);
			// MathLang.g:140:44: ( 'WriteLine' | 'Write' )
			int alt36=2;
			try { DebugEnterSubRule(36);
			try { DebugEnterDecision(36, decisionCanBacktrack[36]);
			int LA36_0 = input.LA(1);

			if ((LA36_0==66))
			{
				alt36=1;
			}
			else if ((LA36_0==67))
			{
				alt36=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 36, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(36); }
			switch (alt36)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:140:45: 'WriteLine'
				{
				DebugLocation(140, 45);
				string_literal171=(IToken)Match(input,66,Follow._66_in_console_write_statement1434); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_66.Add(string_literal171);


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:140:59: 'Write'
				{
				DebugLocation(140, 59);
				string_literal172=(IToken)Match(input,67,Follow._67_in_console_write_statement1438); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_67.Add(string_literal172);


				}
				break;

			}
			} finally { DebugExitSubRule(36); }

			DebugLocation(140, 71);
			char_literal173=(IToken)Match(input,59,Follow._59_in_console_write_statement1441); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_59.Add(char_literal173);

			DebugLocation(140, 73);
			PushFollow(Follow._expression_in_console_write_statement1444);
			expression174=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression174.Tree);
			DebugLocation(140, 87);
			char_literal175=(IToken)Match(input,60,Follow._60_in_console_write_statement1446); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_60.Add(char_literal175);

			DebugLocation(140, 92);
			char_literal176=(IToken)Match(input,58,Follow._58_in_console_write_statement1449); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_58.Add(char_literal176);



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
			// 140:94: -> ^( PRINT expression )
			{
				DebugLocation(140, 97);
				// MathLang.g:140:97: ^( PRINT expression )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(140, 99);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PRINT, "PRINT"), root_1);

				DebugLocation(140, 105);
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
			TraceOut("console_write_statement", 45);
			LeaveRule("console_write_statement", 45);
			Leave_console_write_statement();
			if (state.backtracking > 0) { Memoize(input, 45, console_write_statement_StartIndex); }
		}
		DebugLocation(140, 117);
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
	// MathLang.g:141:1: console_read_statement : console_read_body ';' ;
	[GrammarRule("console_read_statement")]
	private MathLangParser.console_read_statement_return console_read_statement()
	{
		Enter_console_read_statement();
		EnterRule("console_read_statement", 46);
		TraceIn("console_read_statement", 46);
		MathLangParser.console_read_statement_return retval = new MathLangParser.console_read_statement_return();
		retval.Start = (IToken)input.LT(1);
		int console_read_statement_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal178=null;
		MathLangParser.console_read_body_return console_read_body177 = default(MathLangParser.console_read_body_return);

		object char_literal178_tree=null;

		try { DebugEnterRule(GrammarFileName, "console_read_statement");
		DebugLocation(141, 47);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 46)) { return retval; }
			// MathLang.g:141:23: ( console_read_body ';' )
			DebugEnterAlt(1);
			// MathLang.g:141:25: console_read_body ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(141, 25);
			PushFollow(Follow._console_read_body_in_console_read_statement1466);
			console_read_body177=console_read_body();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, console_read_body177.Tree);
			DebugLocation(141, 46);
			char_literal178=(IToken)Match(input,58,Follow._58_in_console_read_statement1468); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("console_read_statement", 46);
			LeaveRule("console_read_statement", 46);
			Leave_console_read_statement();
			if (state.backtracking > 0) { Memoize(input, 46, console_read_statement_StartIndex); }
		}
		DebugLocation(141, 47);
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
	// MathLang.g:143:1: console_read_body : CONSOLE_WORD '.' ( 'ReadLine' | 'Read' ) '()' -> INPUT ;
	[GrammarRule("console_read_body")]
	private MathLangParser.console_read_body_return console_read_body()
	{
		Enter_console_read_body();
		EnterRule("console_read_body", 47);
		TraceIn("console_read_body", 47);
		MathLangParser.console_read_body_return retval = new MathLangParser.console_read_body_return();
		retval.Start = (IToken)input.LT(1);
		int console_read_body_StartIndex = input.Index;
		object root_0 = null;

		IToken CONSOLE_WORD179=null;
		IToken char_literal180=null;
		IToken string_literal181=null;
		IToken string_literal182=null;
		IToken string_literal183=null;

		object CONSOLE_WORD179_tree=null;
		object char_literal180_tree=null;
		object string_literal181_tree=null;
		object string_literal182_tree=null;
		object string_literal183_tree=null;
		RewriteRuleITokenStream stream_CONSOLE_WORD=new RewriteRuleITokenStream(adaptor,"token CONSOLE_WORD");
		RewriteRuleITokenStream stream_69=new RewriteRuleITokenStream(adaptor,"token 69");
		RewriteRuleITokenStream stream_68=new RewriteRuleITokenStream(adaptor,"token 68");
		RewriteRuleITokenStream stream_65=new RewriteRuleITokenStream(adaptor,"token 65");
		RewriteRuleITokenStream stream_61=new RewriteRuleITokenStream(adaptor,"token 61");

		try { DebugEnterRule(GrammarFileName, "console_read_body");
		DebugLocation(143, 74);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 47)) { return retval; }
			// MathLang.g:143:18: ( CONSOLE_WORD '.' ( 'ReadLine' | 'Read' ) '()' -> INPUT )
			DebugEnterAlt(1);
			// MathLang.g:143:20: CONSOLE_WORD '.' ( 'ReadLine' | 'Read' ) '()'
			{
			DebugLocation(143, 20);
			CONSOLE_WORD179=(IToken)Match(input,CONSOLE_WORD,Follow._CONSOLE_WORD_in_console_read_body1477); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CONSOLE_WORD.Add(CONSOLE_WORD179);

			DebugLocation(143, 36);
			char_literal180=(IToken)Match(input,65,Follow._65_in_console_read_body1479); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_65.Add(char_literal180);

			DebugLocation(143, 38);
			// MathLang.g:143:38: ( 'ReadLine' | 'Read' )
			int alt37=2;
			try { DebugEnterSubRule(37);
			try { DebugEnterDecision(37, decisionCanBacktrack[37]);
			int LA37_0 = input.LA(1);

			if ((LA37_0==68))
			{
				alt37=1;
			}
			else if ((LA37_0==69))
			{
				alt37=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 37, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(37); }
			switch (alt37)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:143:39: 'ReadLine'
				{
				DebugLocation(143, 39);
				string_literal181=(IToken)Match(input,68,Follow._68_in_console_read_body1483); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_68.Add(string_literal181);


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:143:52: 'Read'
				{
				DebugLocation(143, 52);
				string_literal182=(IToken)Match(input,69,Follow._69_in_console_read_body1487); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_69.Add(string_literal182);


				}
				break;

			}
			} finally { DebugExitSubRule(37); }

			DebugLocation(143, 60);
			string_literal183=(IToken)Match(input,61,Follow._61_in_console_read_body1490); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_61.Add(string_literal183);



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
			// 143:65: -> INPUT
			{
				DebugLocation(143, 68);
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
			TraceOut("console_read_body", 47);
			LeaveRule("console_read_body", 47);
			Leave_console_read_body();
			if (state.backtracking > 0) { Memoize(input, 47, console_read_body_StartIndex); }
		}
		DebugLocation(143, 74);
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
		EnterRule("synpred19_MathLang_fragment", 66);
		TraceIn("synpred19_MathLang_fragment", 66);
		try
		{
			// MathLang.g:78:5: ( funccallbody )
			DebugEnterAlt(1);
			// MathLang.g:78:5: funccallbody
			{
			DebugLocation(78, 5);
			PushFollow(Follow._funccallbody_in_synpred19_MathLang561);
			funccallbody();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred19_MathLang_fragment", 66);
			LeaveRule("synpred19_MathLang_fragment", 66);
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
		EnterRule("synpred20_MathLang_fragment", 67);
		TraceIn("synpred20_MathLang_fragment", 67);
		try
		{
			// MathLang.g:79:5: ( boolexpression )
			DebugEnterAlt(1);
			// MathLang.g:79:5: boolexpression
			{
			DebugLocation(79, 5);
			PushFollow(Follow._boolexpression_in_synpred20_MathLang567);
			boolexpression();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred20_MathLang_fragment", 67);
			LeaveRule("synpred20_MathLang_fragment", 67);
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
		EnterRule("synpred21_MathLang_fragment", 68);
		TraceIn("synpred21_MathLang_fragment", 68);
		try
		{
			// MathLang.g:80:5: ( mathexpression )
			DebugEnterAlt(1);
			// MathLang.g:80:5: mathexpression
			{
			DebugLocation(80, 5);
			PushFollow(Follow._mathexpression_in_synpred21_MathLang573);
			mathexpression();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred21_MathLang_fragment", 68);
			LeaveRule("synpred21_MathLang_fragment", 68);
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
		EnterRule("synpred34_MathLang_fragment", 81);
		TraceIn("synpred34_MathLang_fragment", 81);
		try
		{
			// MathLang.g:99:16: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )
			DebugEnterAlt(1);
			// MathLang.g:99:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
			{
			DebugLocation(99, 16);
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

			DebugLocation(99, 53);
			PushFollow(Follow._add_in_synpred34_MathLang820);
			add();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred34_MathLang_fragment", 81);
			LeaveRule("synpred34_MathLang_fragment", 81);
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
		EnterRule("synpred43_MathLang_fragment", 90);
		TraceIn("synpred43_MathLang_fragment", 90);
		try
		{
			// MathLang.g:111:22: ( '(' boolterm ')' )
			DebugEnterAlt(1);
			// MathLang.g:111:22: '(' boolterm ')'
			{
			DebugLocation(111, 22);
			Match(input,59,Follow._59_in_synpred43_MathLang980); if (state.failed) return;
			DebugLocation(111, 27);
			PushFollow(Follow._boolterm_in_synpred43_MathLang983);
			boolterm();
			PopFollow();
			if (state.failed) return;
			DebugLocation(111, 36);
			Match(input,60,Follow._60_in_synpred43_MathLang985); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred43_MathLang_fragment", 90);
			LeaveRule("synpred43_MathLang_fragment", 90);
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
		EnterRule("synpred48_MathLang_fragment", 95);
		TraceIn("synpred48_MathLang_fragment", 95);
		try
		{
			// MathLang.g:116:64: ( ELSE ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:116:64: ELSE ( block | statement )
			{
			DebugLocation(116, 64);
			Match(input,ELSE,Follow._ELSE_in_synpred48_MathLang1037); if (state.failed) return;
			DebugLocation(116, 70);
			// MathLang.g:116:70: ( block | statement )
			int alt39=2;
			try { DebugEnterSubRule(39);
			try { DebugEnterDecision(39, decisionCanBacktrack[39]);
			int LA39_0 = input.LA(1);

			if ((LA39_0==63))
			{
				alt39=1;
			}
			else if ((LA39_0==IF||LA39_0==FOR||(LA39_0>=RETURN && LA39_0<=DO)||LA39_0==TYPE||LA39_0==ID||(LA39_0>=KNEW && LA39_0<=CONSOLE_WORD)))
			{
				alt39=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				NoViableAltException nvae = new NoViableAltException("", 39, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(39); }
			switch (alt39)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:116:71: block
				{
				DebugLocation(116, 71);
				PushFollow(Follow._block_in_synpred48_MathLang1041);
				block();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:116:79: statement
				{
				DebugLocation(116, 79);
				PushFollow(Follow._statement_in_synpred48_MathLang1045);
				statement();
				PopFollow();
				if (state.failed) return;

				}
				break;

			}
			} finally { DebugExitSubRule(39); }


			}

		}
		finally
		{
			TraceOut("synpred48_MathLang_fragment", 95);
			LeaveRule("synpred48_MathLang_fragment", 95);
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
	DFA2 dfa2;
	DFA5 dfa5;
	DFA11 dfa11;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa2 = new DFA2( this );
		dfa5 = new DFA5( this, SpecialStateTransition5 );
		dfa11 = new DFA11( this, SpecialStateTransition11 );
	}

	private class DFA2 : DFA
	{
		private const string DFA2_eotS =
			"\xF\xFFFF";
		private const string DFA2_eofS =
			"\xF\xFFFF";
		private const string DFA2_minS =
			"\x1\x7\x1\xFFFF\x1\x23\x6\xFFFF\x1\x41\x2\xFFFF\x1\x42\x2\xFFFF";
		private const string DFA2_maxS =
			"\x1\x34\x1\xFFFF\x1\x3B\x6\xFFFF\x1\x41\x2\xFFFF\x1\x45\x2\xFFFF";
		private const string DFA2_acceptS =
			"\x1\xFFFF\x1\x1\x1\xFFFF\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x1\x9\x1\xFFFF"+
			"\x1\x2\x1\x8\x1\xFFFF\x1\xA\x1\xB";
		private const string DFA2_specialS =
			"\xF\xFFFF}>";
		private static readonly string[] DFA2_transitionS =
			{
				"\x1\x3\x1\xFFFF\x1\x6\x1\xFFFF\x1\x7\x1\x4\x1\x5\xF\xFFFF\x1\x1\x3"+
				"\xFFFF\x1\x2\x11\xFFFF\x1\x8\x1\x9",
				"",
				"\x1\xA\x11\xFFFF\x1\xA\x5\xFFFF\x1\xB",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\xC",
				"",
				"",
				"\x2\xD\x2\xE",
				"",
				""
			};

		private static readonly short[] DFA2_eot = DFA.UnpackEncodedString(DFA2_eotS);
		private static readonly short[] DFA2_eof = DFA.UnpackEncodedString(DFA2_eofS);
		private static readonly char[] DFA2_min = DFA.UnpackEncodedStringToUnsignedChars(DFA2_minS);
		private static readonly char[] DFA2_max = DFA.UnpackEncodedStringToUnsignedChars(DFA2_maxS);
		private static readonly short[] DFA2_accept = DFA.UnpackEncodedString(DFA2_acceptS);
		private static readonly short[] DFA2_special = DFA.UnpackEncodedString(DFA2_specialS);
		private static readonly short[][] DFA2_transition;

		static DFA2()
		{
			int numStates = DFA2_transitionS.Length;
			DFA2_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA2_transition[i] = DFA.UnpackEncodedString(DFA2_transitionS[i]);
			}
		}

		public DFA2( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 2;
			this.eot = DFA2_eot;
			this.eof = DFA2_eof;
			this.min = DFA2_min;
			this.max = DFA2_max;
			this.accept = DFA2_accept;
			this.special = DFA2_special;
			this.transition = DFA2_transition;
		}

		public override string Description { get { return "54:12: ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | returnstatement | funccall | newexpression | console_write_statement | console_read_statement )"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA5 : DFA
	{
		private const string DFA5_eotS =
			"\xD\xFFFF";
		private const string DFA5_eofS =
			"\xD\xFFFF";
		private const string DFA5_minS =
			"\x1\x20\x1\xFFFF\x1\x0\x1\xFFFF\x1\x0\x2\xFFFF\x3\x0\x3\xFFFF";
		private const string DFA5_maxS =
			"\x1\x3B\x1\xFFFF\x1\x0\x1\xFFFF\x1\x0\x2\xFFFF\x3\x0\x3\xFFFF";
		private const string DFA5_acceptS =
			"\x1\xFFFF\x1\x1\x1\xFFFF\x1\x3\x6\xFFFF\x1\x5\x1\x2\x1\x4";
		private const string DFA5_specialS =
			"\x2\xFFFF\x1\x0\x1\xFFFF\x1\x1\x2\xFFFF\x1\x2\x1\x3\x1\x4\x3\xFFFF}>";
		private static readonly string[] DFA5_transitionS =
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

		private static readonly short[] DFA5_eot = DFA.UnpackEncodedString(DFA5_eotS);
		private static readonly short[] DFA5_eof = DFA.UnpackEncodedString(DFA5_eofS);
		private static readonly char[] DFA5_min = DFA.UnpackEncodedStringToUnsignedChars(DFA5_minS);
		private static readonly char[] DFA5_max = DFA.UnpackEncodedStringToUnsignedChars(DFA5_maxS);
		private static readonly short[] DFA5_accept = DFA.UnpackEncodedString(DFA5_acceptS);
		private static readonly short[] DFA5_special = DFA.UnpackEncodedString(DFA5_specialS);
		private static readonly short[][] DFA5_transition;

		static DFA5()
		{
			int numStates = DFA5_transitionS.Length;
			DFA5_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA5_transition[i] = DFA.UnpackEncodedString(DFA5_transitionS[i]);
			}
		}

		public DFA5( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 5;
			this.eot = DFA5_eot;
			this.eof = DFA5_eof;
			this.min = DFA5_min;
			this.max = DFA5_max;
			this.accept = DFA5_accept;
			this.special = DFA5_special;
			this.transition = DFA5_transition;
		}

		public override string Description { get { return "76:1: expression : ( newexpression | funccallbody | boolexpression | mathexpression | console_read_body );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition5(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA5_2 = input.LA(1);


				int index5_2 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred19_MathLang_fragment)) ) {s = 11;}

				else if ( (EvaluatePredicate(synpred20_MathLang_fragment)) ) {s = 3;}

				else if ( (EvaluatePredicate(synpred21_MathLang_fragment)) ) {s = 12;}


				input.Seek(index5_2);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA5_4 = input.LA(1);


				int index5_4 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred20_MathLang_fragment)) ) {s = 3;}

				else if ( (EvaluatePredicate(synpred21_MathLang_fragment)) ) {s = 12;}


				input.Seek(index5_4);
				if ( s>=0 ) return s;
				break;
			case 2:
				int LA5_7 = input.LA(1);


				int index5_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred20_MathLang_fragment)) ) {s = 3;}

				else if ( (EvaluatePredicate(synpred21_MathLang_fragment)) ) {s = 12;}


				input.Seek(index5_7);
				if ( s>=0 ) return s;
				break;
			case 3:
				int LA5_8 = input.LA(1);


				int index5_8 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred20_MathLang_fragment)) ) {s = 3;}

				else if ( (EvaluatePredicate(synpred21_MathLang_fragment)) ) {s = 12;}


				input.Seek(index5_8);
				if ( s>=0 ) return s;
				break;
			case 4:
				int LA5_9 = input.LA(1);


				int index5_9 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred20_MathLang_fragment)) ) {s = 3;}

				else if ( (EvaluatePredicate(synpred21_MathLang_fragment)) ) {s = 12;}


				input.Seek(index5_9);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 5, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA11 : DFA
	{
		private const string DFA11_eotS =
			"\xA\xFFFF";
		private const string DFA11_eofS =
			"\x1\x2\x9\xFFFF";
		private const string DFA11_minS =
			"\x1\x28\x1\x0\x8\xFFFF";
		private const string DFA11_maxS =
			"\x1\x40\x1\x0\x8\xFFFF";
		private const string DFA11_acceptS =
			"\x2\xFFFF\x1\x2\x1\xFFFF\x1\x1\x5\xFFFF";
		private const string DFA11_specialS =
			"\x1\xFFFF\x1\x0\x8\xFFFF}>";
		private static readonly string[] DFA11_transitionS =
			{
				"\x2\x4\x2\x1\x2\x4\x2\x2\xA\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1"+
				"\x2\x1\xFFFF\x1\x2",
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

		private static readonly short[] DFA11_eot = DFA.UnpackEncodedString(DFA11_eotS);
		private static readonly short[] DFA11_eof = DFA.UnpackEncodedString(DFA11_eofS);
		private static readonly char[] DFA11_min = DFA.UnpackEncodedStringToUnsignedChars(DFA11_minS);
		private static readonly char[] DFA11_max = DFA.UnpackEncodedStringToUnsignedChars(DFA11_maxS);
		private static readonly short[] DFA11_accept = DFA.UnpackEncodedString(DFA11_acceptS);
		private static readonly short[] DFA11_special = DFA.UnpackEncodedString(DFA11_specialS);
		private static readonly short[][] DFA11_transition;

		static DFA11()
		{
			int numStates = DFA11_transitionS.Length;
			DFA11_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA11_transition[i] = DFA.UnpackEncodedString(DFA11_transitionS[i]);
			}
		}

		public DFA11( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 11;
			this.eot = DFA11_eot;
			this.eof = DFA11_eof;
			this.min = DFA11_min;
			this.max = DFA11_max;
			this.accept = DFA11_accept;
			this.special = DFA11_special;
			this.transition = DFA11_transition;
		}

		public override string Description { get { return "99:14: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition11(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA11_1 = input.LA(1);


				int index11_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred34_MathLang_fragment)) ) {s = 4;}

				else if ( (true) ) {s = 2;}


				input.Seek(index11_1);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 11, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}

	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _func_list_in_execute385 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_execute387 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funcdeclaration_in_func_list397 = new BitSet(new ulong[]{0xA0000002UL});
		public static readonly BitSet _declaration_in_statement418 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assignment_in_statement424 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ifstatement_in_statement429 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _whilestatement_in_statement434 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _dowhilestatement_in_statement439 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _forstatement_in_statement444 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _returnstatement_in_statement449 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccall_in_statement454 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _newexpression_in_statement459 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _console_write_statement_in_statement464 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _console_read_statement_in_statement469 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_type479 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_array_type486 = new BitSet(new ulong[]{0x40000000UL});
		public static readonly BitSet _ARRAY_DECLARATION_MARK_in_array_type488 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_any_type495 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_type_in_any_type499 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _VOID_in_any_type503 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NUMBER_in_number511 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_number517 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_number523 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CHAR_in_number529 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrayelement_in_number535 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _term_in_mathexpression541 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _newexpression_in_expression555 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_expression561 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolexpression_in_expression567 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathexpression_in_expression573 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _console_read_body_in_expression579 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_arrayelement591 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _SQRBL_in_arrayelement593 = new BitSet(new ulong[]{0x700000000UL});
		public static readonly BitSet _number_in_arrayelement595 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _SQRBR_in_arrayelement597 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declarationbody_in_declaration615 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_declaration617 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _longdeclaration_in_declaration625 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_declarationbody633 = new BitSet(new ulong[]{0x200000000UL});
		public static readonly BitSet _ID_in_declarationbody635 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_type_in_declarationbody656 = new BitSet(new ulong[]{0x200000000UL});
		public static readonly BitSet _ID_in_declarationbody658 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _longdeclarationbody_in_longdeclaration680 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_longdeclaration682 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_longdeclarationbody691 = new BitSet(new ulong[]{0x200000000UL});
		public static readonly BitSet _ID_in_longdeclarationbody693 = new BitSet(new ulong[]{0x800000000UL});
		public static readonly BitSet _ASSIGN_in_longdeclarationbody695 = new BitSet(new ulong[]{0x81F002700000000UL});
		public static readonly BitSet _expression_in_longdeclarationbody697 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_type_in_longdeclarationbody721 = new BitSet(new ulong[]{0x200000000UL});
		public static readonly BitSet _ID_in_longdeclarationbody723 = new BitSet(new ulong[]{0x800000000UL});
		public static readonly BitSet _ASSIGN_in_longdeclarationbody725 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _newexpression_in_longdeclarationbody727 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mul_in_add747 = new BitSet(new ulong[]{0x3000000002UL});
		public static readonly BitSet _set_in_add751 = new BitSet(new ulong[]{0x807002700000000UL});
		public static readonly BitSet _mul_in_add760 = new BitSet(new ulong[]{0x3000000002UL});
		public static readonly BitSet _group_in_mul769 = new BitSet(new ulong[]{0xC000000002UL});
		public static readonly BitSet _set_in_mul773 = new BitSet(new ulong[]{0x807002700000000UL});
		public static readonly BitSet _group_in_mul782 = new BitSet(new ulong[]{0xC000000002UL});
		public static readonly BitSet _add_in_compare790 = new BitSet(new ulong[]{0x3F0000000002UL});
		public static readonly BitSet _set_in_compare794 = new BitSet(new ulong[]{0x807002700000000UL});
		public static readonly BitSet _add_in_compare820 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _add_in_term831 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _SUB_in_group838 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_group843 = new BitSet(new ulong[]{0x807002700000000UL});
		public static readonly BitSet _term_in_group846 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_group848 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _number_in_group853 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assignmentbody_in_assignment860 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_assignment862 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_assignmentbody870 = new BitSet(new ulong[]{0x800000000UL});
		public static readonly BitSet _ASSIGN_in_assignmentbody872 = new BitSet(new ulong[]{0x81F002700000000UL});
		public static readonly BitSet _expression_in_assignmentbody874 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrayelement_in_assignmentbody893 = new BitSet(new ulong[]{0x800000000UL});
		public static readonly BitSet _ASSIGN_in_assignmentbody895 = new BitSet(new ulong[]{0x81F002700000000UL});
		public static readonly BitSet _expression_in_assignmentbody897 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolterm_in_boolexpression915 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _or_in_boolterm922 = new BitSet(new ulong[]{0xC0000000002UL});
		public static readonly BitSet _set_in_boolterm926 = new BitSet(new ulong[]{0x807002700000000UL});
		public static readonly BitSet _or_in_boolterm935 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _and_in_or944 = new BitSet(new ulong[]{0x400000000002UL});
		public static readonly BitSet _OR_in_or947 = new BitSet(new ulong[]{0x807002700000000UL});
		public static readonly BitSet _and_in_or950 = new BitSet(new ulong[]{0x400000000002UL});
		public static readonly BitSet _boolgroup_in_and958 = new BitSet(new ulong[]{0x800000000002UL});
		public static readonly BitSet _AND_in_and961 = new BitSet(new ulong[]{0x807002700000000UL});
		public static readonly BitSet _boolgroup_in_and964 = new BitSet(new ulong[]{0x800000000002UL});
		public static readonly BitSet _NOT_in_boolgroup973 = new BitSet(new ulong[]{0x807002700000000UL});
		public static readonly BitSet _59_in_boolgroup980 = new BitSet(new ulong[]{0x807002700000000UL});
		public static readonly BitSet _boolterm_in_boolgroup983 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_boolgroup985 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolvar_in_boolgroup990 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TRUE_in_boolvar998 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FALSE_in_boolvar1004 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _compare_in_boolvar1010 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_ifstatement1017 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_ifstatement1020 = new BitSet(new ulong[]{0x807002700000000UL});
		public static readonly BitSet _boolexpression_in_ifstatement1023 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_ifstatement1025 = new BitSet(new ulong[]{0x881F002720003A80UL});
		public static readonly BitSet _block_in_ifstatement1029 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement1033 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _ELSE_in_ifstatement1037 = new BitSet(new ulong[]{0x881F002720003A80UL});
		public static readonly BitSet _block_in_ifstatement1041 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement1045 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _WHILE_in_whilestatement1055 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_whilestatement1058 = new BitSet(new ulong[]{0x807002700000000UL});
		public static readonly BitSet _boolexpression_in_whilestatement1061 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_whilestatement1063 = new BitSet(new ulong[]{0x881F002720003A80UL});
		public static readonly BitSet _block_in_whilestatement1067 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_whilestatement1071 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_forstatement1078 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_forstatement1081 = new BitSet(new ulong[]{0x20000000UL});
		public static readonly BitSet _longdeclarationbody_in_forstatement1084 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_forstatement1086 = new BitSet(new ulong[]{0x807002700000000UL});
		public static readonly BitSet _boolexpression_in_forstatement1089 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_forstatement1091 = new BitSet(new ulong[]{0x700000000UL});
		public static readonly BitSet _assignmentbody_in_forstatement1094 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_forstatement1096 = new BitSet(new ulong[]{0x881F002720003A80UL});
		public static readonly BitSet _block_in_forstatement1100 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_forstatement1104 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _RETURN_in_returnstatement1111 = new BitSet(new ulong[]{0x81F002700000000UL});
		public static readonly BitSet _expression_in_returnstatement1114 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_returnstatement1116 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DO_in_dowhilestatement1124 = new BitSet(new ulong[]{0x881F002720003A80UL});
		public static readonly BitSet _block_in_dowhilestatement1128 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _statement_in_dowhilestatement1132 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _WHILE_in_dowhilestatement1135 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_dowhilestatement1138 = new BitSet(new ulong[]{0x807002700000000UL});
		public static readonly BitSet _boolexpression_in_dowhilestatement1141 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_dowhilestatement1143 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_dowhilestatement1146 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _any_type_in_funcdeclaration1155 = new BitSet(new ulong[]{0x200000000UL});
		public static readonly BitSet _ID_in_funcdeclaration1157 = new BitSet(new ulong[]{0x2800000000000000UL});
		public static readonly BitSet _59_in_funcdeclaration1162 = new BitSet(new ulong[]{0x1000000020000000UL});
		public static readonly BitSet _paramsdeclaration_in_funcdeclaration1165 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_funcdeclaration1168 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _61_in_funcdeclaration1173 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _block_in_funcdeclaration1177 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declarationbody_in_paramsdeclaration1210 = new BitSet(new ulong[]{0x4000000000000002UL});
		public static readonly BitSet _62_in_paramsdeclaration1214 = new BitSet(new ulong[]{0x20000000UL});
		public static readonly BitSet _declarationbody_in_paramsdeclaration1217 = new BitSet(new ulong[]{0x4000000000000002UL});
		public static readonly BitSet _ID_in_funccallbody1242 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_funccallbody1245 = new BitSet(new ulong[]{0x181F002700000000UL});
		public static readonly BitSet _expressioncommalist_in_funccallbody1247 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_funccallbody1250 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_funccall1273 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_funccall1275 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_expressioncommalist1282 = new BitSet(new ulong[]{0x4000000000000002UL});
		public static readonly BitSet _62_in_expressioncommalist1286 = new BitSet(new ulong[]{0x81F002700000000UL});
		public static readonly BitSet _expression_in_expressioncommalist1289 = new BitSet(new ulong[]{0x4000000000000002UL});
		public static readonly BitSet _63_in_object_initializer1301 = new BitSet(new ulong[]{0x81F002700000000UL});
		public static readonly BitSet _expressioncommalist_in_object_initializer1303 = new BitSet(new ulong[]{0x0UL,0x1UL});
		public static readonly BitSet _64_in_object_initializer1305 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _KNEW_in_newexpression1320 = new BitSet(new ulong[]{0x20000000UL});
		public static readonly BitSet _initializer_in_newexpression1323 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _simple_var_initializer_in_initializer1330 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_initializer_in_initializer1334 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_simple_var_initializer1341 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_simple_var_initializer1343 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_simple_var_initializer1345 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_array_initializer1359 = new BitSet(new ulong[]{0x20000040000000UL});
		public static readonly BitSet _SQRBL_in_array_initializer1363 = new BitSet(new ulong[]{0x700000000UL});
		public static readonly BitSet _number_in_array_initializer1365 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _SQRBR_in_array_initializer1367 = new BitSet(new ulong[]{0x8000000000000002UL});
		public static readonly BitSet _ARRAY_DECLARATION_MARK_in_array_initializer1372 = new BitSet(new ulong[]{0x8000000000000002UL});
		public static readonly BitSet _object_initializer_in_array_initializer1375 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _63_in_block1397 = new BitSet(new ulong[]{0x881F002720003A80UL,0x1UL});
		public static readonly BitSet _statementlist_in_block1400 = new BitSet(new ulong[]{0x0UL,0x1UL});
		public static readonly BitSet _64_in_block1402 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_statementlist1410 = new BitSet(new ulong[]{0x881F002720003A82UL});
		public static readonly BitSet _CONSOLE_WORD_in_console_write_statement1428 = new BitSet(new ulong[]{0x0UL,0x2UL});
		public static readonly BitSet _65_in_console_write_statement1430 = new BitSet(new ulong[]{0x0UL,0xCUL});
		public static readonly BitSet _66_in_console_write_statement1434 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _67_in_console_write_statement1438 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_console_write_statement1441 = new BitSet(new ulong[]{0x81F002700000000UL});
		public static readonly BitSet _expression_in_console_write_statement1444 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_console_write_statement1446 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_console_write_statement1449 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _console_read_body_in_console_read_statement1466 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_console_read_statement1468 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CONSOLE_WORD_in_console_read_body1477 = new BitSet(new ulong[]{0x0UL,0x2UL});
		public static readonly BitSet _65_in_console_read_body1479 = new BitSet(new ulong[]{0x0UL,0x30UL});
		public static readonly BitSet _68_in_console_read_body1483 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _69_in_console_read_body1487 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _61_in_console_read_body1490 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_synpred19_MathLang561 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolexpression_in_synpred20_MathLang567 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathexpression_in_synpred21_MathLang573 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_synpred34_MathLang794 = new BitSet(new ulong[]{0x807002700000000UL});
		public static readonly BitSet _add_in_synpred34_MathLang820 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _59_in_synpred43_MathLang980 = new BitSet(new ulong[]{0x807002700000000UL});
		public static readonly BitSet _boolterm_in_synpred43_MathLang983 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_synpred43_MathLang985 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ELSE_in_synpred48_MathLang1037 = new BitSet(new ulong[]{0x881F002720003A80UL});
		public static readonly BitSet _block_in_synpred48_MathLang1041 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_synpred48_MathLang1045 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  MathLang 

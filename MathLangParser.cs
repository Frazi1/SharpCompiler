// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-09-30 23:41:06

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "UNKNOWN", "PRINT", "INPUT", "IF", "FOR", "FUNCTION", "RETURN", "WHILE", "BLOCK", "PROGRAM", "PARAMS", "VAR", "NUMBER", "ASSIGN", "TYPE", "ARRAY", "ID", "ADD", "SUB", "MUL", "DIV", "WS", "SL_COMMENT", "ML_COMMENT", "';'", "'('", "')'"
	};
	public const int EOF=-1;
	public const int T__28=28;
	public const int T__29=29;
	public const int T__30=30;
	public const int UNKNOWN=4;
	public const int PRINT=5;
	public const int INPUT=6;
	public const int IF=7;
	public const int FOR=8;
	public const int FUNCTION=9;
	public const int RETURN=10;
	public const int WHILE=11;
	public const int BLOCK=12;
	public const int PROGRAM=13;
	public const int PARAMS=14;
	public const int VAR=15;
	public const int NUMBER=16;
	public const int ASSIGN=17;
	public const int TYPE=18;
	public const int ARRAY=19;
	public const int ID=20;
	public const int ADD=21;
	public const int SUB=22;
	public const int MUL=23;
	public const int DIV=24;
	public const int WS=25;
	public const int SL_COMMENT=26;
	public const int ML_COMMENT=27;

	// delegates
	// delegators

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, false, false
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
		this.state.ruleMemo = new System.Collections.Generic.Dictionary<int, int>[19+1];

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
	// MathLang.g:35:8: public execute : ( statement )* ;
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

		MathLangParser.statement_return statement1 = default(MathLangParser.statement_return);


		try { DebugEnterRule(GrammarFileName, "execute");
		DebugLocation(35, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 1)) { return retval; }
			// MathLang.g:35:15: ( ( statement )* )
			DebugEnterAlt(1);
			// MathLang.g:36:2: ( statement )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(36, 2);
			// MathLang.g:36:2: ( statement )*
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, decisionCanBacktrack[1]);
				int LA1_0 = input.LA(1);

				if ((LA1_0==NUMBER||(LA1_0>=TYPE && LA1_0<=ARRAY)||LA1_0==29))
				{
					alt1=1;
				}


				} finally { DebugExitDecision(1); }
				switch ( alt1 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: statement
					{
					DebugLocation(36, 2);
					PushFollow(Follow._statement_in_execute259);
					statement1=statement();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement1.Tree);

					}
					break;

				default:
					goto loop1;
				}
			}

			loop1:
				;

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
	// MathLang.g:39:1: statement : ( expression | declaration ) ';' ;
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

		IToken char_literal4=null;
		MathLangParser.expression_return expression2 = default(MathLangParser.expression_return);
		MathLangParser.declaration_return declaration3 = default(MathLangParser.declaration_return);

		object char_literal4_tree=null;

		try { DebugEnterRule(GrammarFileName, "statement");
		DebugLocation(39, 43);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 2)) { return retval; }
			// MathLang.g:39:10: ( ( expression | declaration ) ';' )
			DebugEnterAlt(1);
			// MathLang.g:39:12: ( expression | declaration ) ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(39, 12);
			// MathLang.g:39:12: ( expression | declaration )
			int alt2=2;
			try { DebugEnterSubRule(2);
			try { DebugEnterDecision(2, decisionCanBacktrack[2]);
			int LA2_0 = input.LA(1);

			if ((LA2_0==NUMBER||LA2_0==29))
			{
				alt2=1;
			}
			else if (((LA2_0>=TYPE && LA2_0<=ARRAY)))
			{
				alt2=2;
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
				// MathLang.g:39:13: expression
				{
				DebugLocation(39, 13);
				PushFollow(Follow._expression_in_statement269);
				expression2=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression2.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:39:26: declaration
				{
				DebugLocation(39, 26);
				PushFollow(Follow._declaration_in_statement273);
				declaration3=declaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, declaration3.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(2); }

			DebugLocation(39, 42);
			char_literal4=(IToken)Match(input,28,Follow._28_in_statement276); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(39, 43);
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
	// MathLang.g:40:1: number : NUMBER ;
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

		IToken NUMBER5=null;

		object NUMBER5_tree=null;

		try { DebugEnterRule(GrammarFileName, "number");
		DebugLocation(40, 16);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 3)) { return retval; }
			// MathLang.g:40:8: ( NUMBER )
			DebugEnterAlt(1);
			// MathLang.g:40:10: NUMBER
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(40, 10);
			NUMBER5=(IToken)Match(input,NUMBER,Follow._NUMBER_in_number285); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			NUMBER5_tree = (object)adaptor.Create(NUMBER5);
			adaptor.AddChild(root_0, NUMBER5_tree);
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
		DebugLocation(40, 16);
		} finally { DebugExitRule(GrammarFileName, "number"); }
		return retval;

	}
	// $ANTLR end "number"

	public class expression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expression();
	partial void Leave_expression();

	// $ANTLR start "expression"
	// MathLang.g:41:1: expression : term ;
	[GrammarRule("expression")]
	private MathLangParser.expression_return expression()
	{
		Enter_expression();
		EnterRule("expression", 4);
		TraceIn("expression", 4);
		MathLangParser.expression_return retval = new MathLangParser.expression_return();
		retval.Start = (IToken)input.LT(1);
		int expression_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.term_return term6 = default(MathLangParser.term_return);


		try { DebugEnterRule(GrammarFileName, "expression");
		DebugLocation(41, 17);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 4)) { return retval; }
			// MathLang.g:41:11: ( term )
			DebugEnterAlt(1);
			// MathLang.g:41:13: term
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(41, 13);
			PushFollow(Follow._term_in_expression292);
			term6=term();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term6.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expression", 4);
			LeaveRule("expression", 4);
			Leave_expression();
			if (state.backtracking > 0) { Memoize(input, 4, expression_StartIndex); }
		}
		DebugLocation(41, 17);
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
	// MathLang.g:42:1: declaration : variable ( ASSIGN expression )? -> ^( ASSIGN ( variable expression )? ) ;
	[GrammarRule("declaration")]
	private MathLangParser.declaration_return declaration()
	{
		Enter_declaration();
		EnterRule("declaration", 5);
		TraceIn("declaration", 5);
		MathLangParser.declaration_return retval = new MathLangParser.declaration_return();
		retval.Start = (IToken)input.LT(1);
		int declaration_StartIndex = input.Index;
		object root_0 = null;

		IToken ASSIGN8=null;
		MathLangParser.variable_return variable7 = default(MathLangParser.variable_return);
		MathLangParser.expression_return expression9 = default(MathLangParser.expression_return);

		object ASSIGN8_tree=null;
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_variable=new RewriteRuleSubtreeStream(adaptor,"rule variable");
		try { DebugEnterRule(GrammarFileName, "declaration");
		DebugLocation(42, 78);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 5)) { return retval; }
			// MathLang.g:42:12: ( variable ( ASSIGN expression )? -> ^( ASSIGN ( variable expression )? ) )
			DebugEnterAlt(1);
			// MathLang.g:42:14: variable ( ASSIGN expression )?
			{
			DebugLocation(42, 14);
			PushFollow(Follow._variable_in_declaration299);
			variable7=variable();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_variable.Add(variable7.Tree);
			DebugLocation(42, 23);
			// MathLang.g:42:23: ( ASSIGN expression )?
			int alt3=2;
			try { DebugEnterSubRule(3);
			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
			int LA3_0 = input.LA(1);

			if ((LA3_0==ASSIGN))
			{
				alt3=1;
			}
			} finally { DebugExitDecision(3); }
			switch (alt3)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:42:24: ASSIGN expression
				{
				DebugLocation(42, 24);
				ASSIGN8=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_declaration302); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN8);

				DebugLocation(42, 31);
				PushFollow(Follow._expression_in_declaration304);
				expression9=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression9.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(3); }



			{
			// AST REWRITE
			// elements: ASSIGN, expression, variable
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 42:44: -> ^( ASSIGN ( variable expression )? )
			{
				DebugLocation(42, 47);
				// MathLang.g:42:47: ^( ASSIGN ( variable expression )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(42, 49);
				root_1 = (object)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_1);

				DebugLocation(42, 56);
				// MathLang.g:42:56: ( variable expression )?
				if ( stream_expression.HasNext||stream_variable.HasNext )
				{
					DebugLocation(42, 57);
					adaptor.AddChild(root_1, stream_variable.NextTree());
					DebugLocation(42, 66);
					adaptor.AddChild(root_1, stream_expression.NextTree());

				}
				stream_expression.Reset();
				stream_variable.Reset();

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
			TraceOut("declaration", 5);
			LeaveRule("declaration", 5);
			Leave_declaration();
			if (state.backtracking > 0) { Memoize(input, 5, declaration_StartIndex); }
		}
		DebugLocation(42, 78);
		} finally { DebugExitRule(GrammarFileName, "declaration"); }
		return retval;

	}
	// $ANTLR end "declaration"

	public class variable_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_variable();
	partial void Leave_variable();

	// $ANTLR start "variable"
	// MathLang.g:43:1: variable : ( TYPE | ARRAY ) ID ;
	[GrammarRule("variable")]
	private MathLangParser.variable_return variable()
	{
		Enter_variable();
		EnterRule("variable", 6);
		TraceIn("variable", 6);
		MathLangParser.variable_return retval = new MathLangParser.variable_return();
		retval.Start = (IToken)input.LT(1);
		int variable_StartIndex = input.Index;
		object root_0 = null;

		IToken set10=null;
		IToken ID11=null;

		object set10_tree=null;
		object ID11_tree=null;

		try { DebugEnterRule(GrammarFileName, "variable");
		DebugLocation(43, 27);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 6)) { return retval; }
			// MathLang.g:43:9: ( ( TYPE | ARRAY ) ID )
			DebugEnterAlt(1);
			// MathLang.g:43:11: ( TYPE | ARRAY ) ID
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(43, 11);
			set10=(IToken)input.LT(1);
			if ((input.LA(1)>=TYPE && input.LA(1)<=ARRAY))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set10));
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}

			DebugLocation(43, 26);
			ID11=(IToken)Match(input,ID,Follow._ID_in_variable333); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			ID11_tree = (object)adaptor.Create(ID11);
			adaptor.AddChild(root_0, ID11_tree);
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
			TraceOut("variable", 6);
			LeaveRule("variable", 6);
			Leave_variable();
			if (state.backtracking > 0) { Memoize(input, 6, variable_StartIndex); }
		}
		DebugLocation(43, 27);
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
	// MathLang.g:44:1: add : mul ( ( ADD | SUB ) mul )* ;
	[GrammarRule("add")]
	private MathLangParser.add_return add()
	{
		Enter_add();
		EnterRule("add", 7);
		TraceIn("add", 7);
		MathLangParser.add_return retval = new MathLangParser.add_return();
		retval.Start = (IToken)input.LT(1);
		int add_StartIndex = input.Index;
		object root_0 = null;

		IToken set13=null;
		MathLangParser.mul_return mul12 = default(MathLangParser.mul_return);
		MathLangParser.mul_return mul14 = default(MathLangParser.mul_return);

		object set13_tree=null;

		try { DebugEnterRule(GrammarFileName, "add");
		DebugLocation(44, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 7)) { return retval; }
			// MathLang.g:44:4: ( mul ( ( ADD | SUB ) mul )* )
			DebugEnterAlt(1);
			// MathLang.g:44:6: mul ( ( ADD | SUB ) mul )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(44, 6);
			PushFollow(Follow._mul_in_add339);
			mul12=mul();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul12.Tree);
			DebugLocation(44, 10);
			// MathLang.g:44:10: ( ( ADD | SUB ) mul )*
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
					// MathLang.g:44:12: ( ADD | SUB ) mul
					{
					DebugLocation(44, 12);
					set13=(IToken)input.LT(1);
					set13=(IToken)input.LT(1);
					if ((input.LA(1)>=ADD && input.LA(1)<=SUB))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set13), root_0);
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(44, 25);
					PushFollow(Follow._mul_in_add352);
					mul14=mul();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul14.Tree);

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
			TraceOut("add", 7);
			LeaveRule("add", 7);
			Leave_add();
			if (state.backtracking > 0) { Memoize(input, 7, add_StartIndex); }
		}
		DebugLocation(44, 30);
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
	// MathLang.g:45:1: mul : group ( ( MUL | DIV ) group )* ;
	[GrammarRule("mul")]
	private MathLangParser.mul_return mul()
	{
		Enter_mul();
		EnterRule("mul", 8);
		TraceIn("mul", 8);
		MathLangParser.mul_return retval = new MathLangParser.mul_return();
		retval.Start = (IToken)input.LT(1);
		int mul_StartIndex = input.Index;
		object root_0 = null;

		IToken set16=null;
		MathLangParser.group_return group15 = default(MathLangParser.group_return);
		MathLangParser.group_return group17 = default(MathLangParser.group_return);

		object set16_tree=null;

		try { DebugEnterRule(GrammarFileName, "mul");
		DebugLocation(45, 33);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 8)) { return retval; }
			// MathLang.g:45:4: ( group ( ( MUL | DIV ) group )* )
			DebugEnterAlt(1);
			// MathLang.g:45:6: group ( ( MUL | DIV ) group )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(45, 6);
			PushFollow(Follow._group_in_mul361);
			group15=group();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group15.Tree);
			DebugLocation(45, 12);
			// MathLang.g:45:12: ( ( MUL | DIV ) group )*
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
					// MathLang.g:45:14: ( MUL | DIV ) group
					{
					DebugLocation(45, 14);
					set16=(IToken)input.LT(1);
					set16=(IToken)input.LT(1);
					if ((input.LA(1)>=MUL && input.LA(1)<=DIV))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set16), root_0);
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(45, 27);
					PushFollow(Follow._group_in_mul374);
					group17=group();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group17.Tree);

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
			TraceOut("mul", 8);
			LeaveRule("mul", 8);
			Leave_mul();
			if (state.backtracking > 0) { Memoize(input, 8, mul_StartIndex); }
		}
		DebugLocation(45, 33);
		} finally { DebugExitRule(GrammarFileName, "mul"); }
		return retval;

	}
	// $ANTLR end "mul"

	public class term_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_term();
	partial void Leave_term();

	// $ANTLR start "term"
	// MathLang.g:47:1: term : add ;
	[GrammarRule("term")]
	private MathLangParser.term_return term()
	{
		Enter_term();
		EnterRule("term", 9);
		TraceIn("term", 9);
		MathLangParser.term_return retval = new MathLangParser.term_return();
		retval.Start = (IToken)input.LT(1);
		int term_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.add_return add18 = default(MathLangParser.add_return);


		try { DebugEnterRule(GrammarFileName, "term");
		DebugLocation(47, 9);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 9)) { return retval; }
			// MathLang.g:47:5: ( add )
			DebugEnterAlt(1);
			// MathLang.g:47:7: add
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(47, 7);
			PushFollow(Follow._add_in_term383);
			add18=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add18.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("term", 9);
			LeaveRule("term", 9);
			Leave_term();
			if (state.backtracking > 0) { Memoize(input, 9, term_StartIndex); }
		}
		DebugLocation(47, 9);
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
	// MathLang.g:49:1: group : ( '(' term ')' | number );
	[GrammarRule("group")]
	private MathLangParser.group_return group()
	{
		Enter_group();
		EnterRule("group", 10);
		TraceIn("group", 10);
		MathLangParser.group_return retval = new MathLangParser.group_return();
		retval.Start = (IToken)input.LT(1);
		int group_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal19=null;
		IToken char_literal21=null;
		MathLangParser.term_return term20 = default(MathLangParser.term_return);
		MathLangParser.number_return number22 = default(MathLangParser.number_return);

		object char_literal19_tree=null;
		object char_literal21_tree=null;

		try { DebugEnterRule(GrammarFileName, "group");
		DebugLocation(49, 28);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 10)) { return retval; }
			// MathLang.g:49:6: ( '(' term ')' | number )
			int alt6=2;
			try { DebugEnterDecision(6, decisionCanBacktrack[6]);
			int LA6_0 = input.LA(1);

			if ((LA6_0==29))
			{
				alt6=1;
			}
			else if ((LA6_0==NUMBER))
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
				// MathLang.g:49:8: '(' term ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(49, 8);
				char_literal19=(IToken)Match(input,29,Follow._29_in_group390); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal19_tree = (object)adaptor.Create(char_literal19);
				adaptor.AddChild(root_0, char_literal19_tree);
				}
				DebugLocation(49, 12);
				PushFollow(Follow._term_in_group392);
				term20=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term20.Tree);
				DebugLocation(49, 17);
				char_literal21=(IToken)Match(input,30,Follow._30_in_group394); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal21_tree = (object)adaptor.Create(char_literal21);
				adaptor.AddChild(root_0, char_literal21_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:49:23: number
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(49, 23);
				PushFollow(Follow._number_in_group398);
				number22=number();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, number22.Tree);

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
			TraceOut("group", 10);
			LeaveRule("group", 10);
			Leave_group();
			if (state.backtracking > 0) { Memoize(input, 10, group_StartIndex); }
		}
		DebugLocation(49, 28);
		} finally { DebugExitRule(GrammarFileName, "group"); }
		return retval;

	}
	// $ANTLR end "group"
	#endregion Rules


	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _statement_in_execute259 = new BitSet(new ulong[]{0x200D0002UL});
		public static readonly BitSet _expression_in_statement269 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _declaration_in_statement273 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _28_in_statement276 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NUMBER_in_number285 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _term_in_expression292 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _variable_in_declaration299 = new BitSet(new ulong[]{0x20002UL});
		public static readonly BitSet _ASSIGN_in_declaration302 = new BitSet(new ulong[]{0x20010000UL});
		public static readonly BitSet _expression_in_declaration304 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_variable325 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _ID_in_variable333 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mul_in_add339 = new BitSet(new ulong[]{0x600002UL});
		public static readonly BitSet _set_in_add343 = new BitSet(new ulong[]{0x20010000UL});
		public static readonly BitSet _mul_in_add352 = new BitSet(new ulong[]{0x600002UL});
		public static readonly BitSet _group_in_mul361 = new BitSet(new ulong[]{0x1800002UL});
		public static readonly BitSet _set_in_mul365 = new BitSet(new ulong[]{0x20010000UL});
		public static readonly BitSet _group_in_mul374 = new BitSet(new ulong[]{0x1800002UL});
		public static readonly BitSet _add_in_term383 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _29_in_group390 = new BitSet(new ulong[]{0x20010000UL});
		public static readonly BitSet _term_in_group392 = new BitSet(new ulong[]{0x40000000UL});
		public static readonly BitSet _30_in_group394 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _number_in_group398 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  MathLang 

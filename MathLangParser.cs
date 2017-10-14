// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-10-14 14:03:54

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "UNKNOWN", "PRINT", "INPUT", "IF", "ELSE", "FOR", "FUNCTION", "RETURN", "WHILE", "DO", "BLOCK", "PROGRAM", "PARAMS", "VARDECLARATION", "FUNCDECLARATION", "ARRAYDECLARATION", "VARASSIGNMENT", "ARRAYELEMENTASSIGNMENT", "ARRAYELEMENT", "NEWVAR", "ARRAY_INITIALIZER", "OBJECT_INITIALIZER", "FUNC_CALL", "RETURN_TYPE", "PARAMETERS", "STATIC_DECLARATION", "CLASSBLOCK", "CLASS_WORD", "CALL", "VARS", "MULT_DECL", "MODIFIER", "ID", "TYPE", "ARRAY_DECLARATION_MARK", "VOID", "NUMBER", "CHAR", "DOT", "OPEN_SQUARE_BRACE", "CLOSE_SQUARE_BRACE", "ASSIGN", "ADD", "SUB", "MUL", "DIV", "GREQ", "LSEQ", "NEQ", "EQ", "GR", "LS", "OPEN_BRACE", "CLOSE_BRACE", "OR", "AND", "NOT", "TRUE", "FALSE", "KNEW", "CONSOLE_WORD", "WS", "SL_COMMENT", "ML_COMMENT", "'{'", "'}'", "';'", "','"
	};
	public const int EOF=-1;
	public const int T__68=68;
	public const int T__69=69;
	public const int T__70=70;
	public const int T__71=71;
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
	public const int STATIC_DECLARATION=29;
	public const int CLASSBLOCK=30;
	public const int CLASS_WORD=31;
	public const int CALL=32;
	public const int VARS=33;
	public const int MULT_DECL=34;
	public const int MODIFIER=35;
	public const int ID=36;
	public const int TYPE=37;
	public const int ARRAY_DECLARATION_MARK=38;
	public const int VOID=39;
	public const int NUMBER=40;
	public const int CHAR=41;
	public const int DOT=42;
	public const int OPEN_SQUARE_BRACE=43;
	public const int CLOSE_SQUARE_BRACE=44;
	public const int ASSIGN=45;
	public const int ADD=46;
	public const int SUB=47;
	public const int MUL=48;
	public const int DIV=49;
	public const int GREQ=50;
	public const int LSEQ=51;
	public const int NEQ=52;
	public const int EQ=53;
	public const int GR=54;
	public const int LS=55;
	public const int OPEN_BRACE=56;
	public const int CLOSE_BRACE=57;
	public const int OR=58;
	public const int AND=59;
	public const int NOT=60;
	public const int TRUE=61;
	public const int FALSE=62;
	public const int KNEW=63;
	public const int CONSOLE_WORD=64;
	public const int WS=65;
	public const int SL_COMMENT=66;
	public const int ML_COMMENT=67;

	// delegates
	// delegators

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, false, false, false, true, false, false, 
				false, false, false, false, false, true, false, false, false, false, 
				false, false, false, true, false, false, false, true, false, false, 
				false, false, false, false, false, false, false, false, false, , false
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
		this.state.ruleMemo = new System.Collections.Generic.Dictionary<int, int>[114+1];

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
	// MathLang.g:54:8: public execute : class_list EOF -> ^( PROGRAM class_list ) ;
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
		MathLangParser.class_list_return class_list1 = default(MathLangParser.class_list_return);

		object EOF2_tree=null;
		RewriteRuleITokenStream stream_EOF=new RewriteRuleITokenStream(adaptor,"token EOF");
		RewriteRuleSubtreeStream stream_class_list=new RewriteRuleSubtreeStream(adaptor,"rule class_list");
		try { DebugEnterRule(GrammarFileName, "execute");
		DebugLocation(54, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 1)) { return retval; }
			// MathLang.g:54:15: ( class_list EOF -> ^( PROGRAM class_list ) )
			DebugEnterAlt(1);
			// MathLang.g:55:2: class_list EOF
			{
			DebugLocation(55, 2);
			PushFollow(Follow._class_list_in_execute379);
			class_list1=class_list();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_class_list.Add(class_list1.Tree);
			DebugLocation(55, 16);
			EOF2=(IToken)Match(input,EOF,Follow._EOF_in_execute381); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_EOF.Add(EOF2);



			{
			// AST REWRITE
			// elements: class_list
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 55:19: -> ^( PROGRAM class_list )
			{
				DebugLocation(55, 22);
				// MathLang.g:55:22: ^( PROGRAM class_list )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(55, 24);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROGRAM, "PROGRAM"), root_1);

				DebugLocation(55, 32);
				adaptor.AddChild(root_1, stream_class_list.NextTree());

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
			TraceOut("execute", 1);
			LeaveRule("execute", 1);
			Leave_execute();
			if (state.backtracking > 0) { Memoize(input, 1, execute_StartIndex); }
		}
		DebugLocation(56, 0);
		} finally { DebugExitRule(GrammarFileName, "execute"); }
		return retval;

	}
	// $ANTLR end "execute"

	public class class_declaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_class_declaration();
	partial void Leave_class_declaration();

	// $ANTLR start "class_declaration"
	// MathLang.g:58:1: class_declaration : MODIFIER CLASS_WORD ID class_block -> ^( CLASS_WORD ID class_block ) ;
	[GrammarRule("class_declaration")]
	private MathLangParser.class_declaration_return class_declaration()
	{
		Enter_class_declaration();
		EnterRule("class_declaration", 2);
		TraceIn("class_declaration", 2);
		MathLangParser.class_declaration_return retval = new MathLangParser.class_declaration_return();
		retval.Start = (IToken)input.LT(1);
		int class_declaration_StartIndex = input.Index;
		object root_0 = null;

		IToken MODIFIER3=null;
		IToken CLASS_WORD4=null;
		IToken ID5=null;
		MathLangParser.class_block_return class_block6 = default(MathLangParser.class_block_return);

		object MODIFIER3_tree=null;
		object CLASS_WORD4_tree=null;
		object ID5_tree=null;
		RewriteRuleITokenStream stream_CLASS_WORD=new RewriteRuleITokenStream(adaptor,"token CLASS_WORD");
		RewriteRuleITokenStream stream_MODIFIER=new RewriteRuleITokenStream(adaptor,"token MODIFIER");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleSubtreeStream stream_class_block=new RewriteRuleSubtreeStream(adaptor,"rule class_block");
		try { DebugEnterRule(GrammarFileName, "class_declaration");
		DebugLocation(58, 86);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 2)) { return retval; }
			// MathLang.g:58:18: ( MODIFIER CLASS_WORD ID class_block -> ^( CLASS_WORD ID class_block ) )
			DebugEnterAlt(1);
			// MathLang.g:58:20: MODIFIER CLASS_WORD ID class_block
			{
			DebugLocation(58, 20);
			MODIFIER3=(IToken)Match(input,MODIFIER,Follow._MODIFIER_in_class_declaration400); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_MODIFIER.Add(MODIFIER3);

			DebugLocation(58, 29);
			CLASS_WORD4=(IToken)Match(input,CLASS_WORD,Follow._CLASS_WORD_in_class_declaration402); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CLASS_WORD.Add(CLASS_WORD4);

			DebugLocation(58, 40);
			ID5=(IToken)Match(input,ID,Follow._ID_in_class_declaration404); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID5);

			DebugLocation(58, 43);
			PushFollow(Follow._class_block_in_class_declaration406);
			class_block6=class_block();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_class_block.Add(class_block6.Tree);


			{
			// AST REWRITE
			// elements: class_block, CLASS_WORD, ID
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 58:55: -> ^( CLASS_WORD ID class_block )
			{
				DebugLocation(58, 58);
				// MathLang.g:58:58: ^( CLASS_WORD ID class_block )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(58, 60);
				root_1 = (object)adaptor.BecomeRoot(stream_CLASS_WORD.NextNode(), root_1);

				DebugLocation(58, 71);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(58, 74);
				adaptor.AddChild(root_1, stream_class_block.NextTree());

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
			TraceOut("class_declaration", 2);
			LeaveRule("class_declaration", 2);
			Leave_class_declaration();
			if (state.backtracking > 0) { Memoize(input, 2, class_declaration_StartIndex); }
		}
		DebugLocation(58, 86);
		} finally { DebugExitRule(GrammarFileName, "class_declaration"); }
		return retval;

	}
	// $ANTLR end "class_declaration"

	public class class_block_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_class_block();
	partial void Leave_class_block();

	// $ANTLR start "class_block"
	// MathLang.g:60:1: class_block : '{' ( static_func_or_var_declaration )* '}' -> ^( CLASSBLOCK ( static_func_or_var_declaration )* ) ;
	[GrammarRule("class_block")]
	private MathLangParser.class_block_return class_block()
	{
		Enter_class_block();
		EnterRule("class_block", 3);
		TraceIn("class_block", 3);
		MathLangParser.class_block_return retval = new MathLangParser.class_block_return();
		retval.Start = (IToken)input.LT(1);
		int class_block_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal7=null;
		IToken char_literal9=null;
		MathLangParser.static_func_or_var_declaration_return static_func_or_var_declaration8 = default(MathLangParser.static_func_or_var_declaration_return);

		object char_literal7_tree=null;
		object char_literal9_tree=null;
		RewriteRuleITokenStream stream_68=new RewriteRuleITokenStream(adaptor,"token 68");
		RewriteRuleITokenStream stream_69=new RewriteRuleITokenStream(adaptor,"token 69");
		RewriteRuleSubtreeStream stream_static_func_or_var_declaration=new RewriteRuleSubtreeStream(adaptor,"rule static_func_or_var_declaration");
		try { DebugEnterRule(GrammarFileName, "class_block");
		DebugLocation(60, 105);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 3)) { return retval; }
			// MathLang.g:60:12: ( '{' ( static_func_or_var_declaration )* '}' -> ^( CLASSBLOCK ( static_func_or_var_declaration )* ) )
			DebugEnterAlt(1);
			// MathLang.g:60:14: '{' ( static_func_or_var_declaration )* '}'
			{
			DebugLocation(60, 17);
			char_literal7=(IToken)Match(input,68,Follow._68_in_class_block424); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_68.Add(char_literal7);

			DebugLocation(60, 19);
			// MathLang.g:60:19: ( static_func_or_var_declaration )*
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, decisionCanBacktrack[1]);
				int LA1_0 = input.LA(1);

				if ((LA1_0==MODIFIER))
				{
					alt1=1;
				}


				} finally { DebugExitDecision(1); }
				switch ( alt1 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: static_func_or_var_declaration
					{
					DebugLocation(60, 19);
					PushFollow(Follow._static_func_or_var_declaration_in_class_block427);
					static_func_or_var_declaration8=static_func_or_var_declaration();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_static_func_or_var_declaration.Add(static_func_or_var_declaration8.Tree);

					}
					break;

				default:
					goto loop1;
				}
			}

			loop1:
				;

			} finally { DebugExitSubRule(1); }

			DebugLocation(60, 54);
			char_literal9=(IToken)Match(input,69,Follow._69_in_class_block430); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_69.Add(char_literal9);



			{
			// AST REWRITE
			// elements: static_func_or_var_declaration
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 60:56: -> ^( CLASSBLOCK ( static_func_or_var_declaration )* )
			{
				DebugLocation(60, 59);
				// MathLang.g:60:59: ^( CLASSBLOCK ( static_func_or_var_declaration )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(60, 61);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(CLASSBLOCK, "CLASSBLOCK"), root_1);

				DebugLocation(60, 72);
				// MathLang.g:60:72: ( static_func_or_var_declaration )*
				while ( stream_static_func_or_var_declaration.HasNext )
				{
					DebugLocation(60, 72);
					adaptor.AddChild(root_1, stream_static_func_or_var_declaration.NextTree());

				}
				stream_static_func_or_var_declaration.Reset();

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
			TraceOut("class_block", 3);
			LeaveRule("class_block", 3);
			Leave_class_block();
			if (state.backtracking > 0) { Memoize(input, 3, class_block_StartIndex); }
		}
		DebugLocation(60, 105);
		} finally { DebugExitRule(GrammarFileName, "class_block"); }
		return retval;

	}
	// $ANTLR end "class_block"

	public class static_func_or_var_declaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_static_func_or_var_declaration();
	partial void Leave_static_func_or_var_declaration();

	// $ANTLR start "static_func_or_var_declaration"
	// MathLang.g:62:1: static_func_or_var_declaration : ( static_declaration | funcdeclaration );
	[GrammarRule("static_func_or_var_declaration")]
	private MathLangParser.static_func_or_var_declaration_return static_func_or_var_declaration()
	{
		Enter_static_func_or_var_declaration();
		EnterRule("static_func_or_var_declaration", 4);
		TraceIn("static_func_or_var_declaration", 4);
		MathLangParser.static_func_or_var_declaration_return retval = new MathLangParser.static_func_or_var_declaration_return();
		retval.Start = (IToken)input.LT(1);
		int static_func_or_var_declaration_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.static_declaration_return static_declaration10 = default(MathLangParser.static_declaration_return);
		MathLangParser.funcdeclaration_return funcdeclaration11 = default(MathLangParser.funcdeclaration_return);


		try { DebugEnterRule(GrammarFileName, "static_func_or_var_declaration");
		DebugLocation(62, 69);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 4)) { return retval; }
			// MathLang.g:62:31: ( static_declaration | funcdeclaration )
			int alt2=2;
			try { DebugEnterDecision(2, decisionCanBacktrack[2]);
			int LA2_0 = input.LA(1);

			if ((LA2_0==MODIFIER))
			{
				int LA2_1 = input.LA(2);

				if ((LA2_1==TYPE))
				{
					int LA2_2 = input.LA(3);

					if ((LA2_2==ARRAY_DECLARATION_MARK))
					{
						alt2=2;
					}
					else if ((LA2_2==ID))
					{
						int LA2_4 = input.LA(4);

						if ((LA2_4==ASSIGN||(LA2_4>=70 && LA2_4<=71)))
						{
							alt2=1;
						}
						else if ((LA2_4==OPEN_BRACE))
						{
							alt2=2;
						}
						else
						{
							if (state.backtracking>0) {state.failed=true; return retval;}
							NoViableAltException nvae = new NoViableAltException("", 2, 4, input);

							DebugRecognitionException(nvae);
							throw nvae;
						}
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 2, 2, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}
				else if ((LA2_1==VOID))
				{
					alt2=2;
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
				// MathLang.g:62:33: static_declaration
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(62, 33);
				PushFollow(Follow._static_declaration_in_static_func_or_var_declaration449);
				static_declaration10=static_declaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, static_declaration10.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:62:54: funcdeclaration
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(62, 54);
				PushFollow(Follow._funcdeclaration_in_static_func_or_var_declaration453);
				funcdeclaration11=funcdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funcdeclaration11.Tree);

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
			TraceOut("static_func_or_var_declaration", 4);
			LeaveRule("static_func_or_var_declaration", 4);
			Leave_static_func_or_var_declaration();
			if (state.backtracking > 0) { Memoize(input, 4, static_func_or_var_declaration_StartIndex); }
		}
		DebugLocation(62, 69);
		} finally { DebugExitRule(GrammarFileName, "static_func_or_var_declaration"); }
		return retval;

	}
	// $ANTLR end "static_func_or_var_declaration"

	public class class_list_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_class_list();
	partial void Leave_class_list();

	// $ANTLR start "class_list"
	// MathLang.g:64:1: class_list : ( class_declaration )* ;
	[GrammarRule("class_list")]
	private MathLangParser.class_list_return class_list()
	{
		Enter_class_list();
		EnterRule("class_list", 5);
		TraceIn("class_list", 5);
		MathLangParser.class_list_return retval = new MathLangParser.class_list_return();
		retval.Start = (IToken)input.LT(1);
		int class_list_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.class_declaration_return class_declaration12 = default(MathLangParser.class_declaration_return);


		try { DebugEnterRule(GrammarFileName, "class_list");
		DebugLocation(64, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 5)) { return retval; }
			// MathLang.g:64:11: ( ( class_declaration )* )
			DebugEnterAlt(1);
			// MathLang.g:64:14: ( class_declaration )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(64, 14);
			// MathLang.g:64:14: ( class_declaration )*
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=2;
				try { DebugEnterDecision(3, decisionCanBacktrack[3]);
				int LA3_0 = input.LA(1);

				if ((LA3_0==MODIFIER))
				{
					alt3=1;
				}


				} finally { DebugExitDecision(3); }
				switch ( alt3 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: class_declaration
					{
					DebugLocation(64, 14);
					PushFollow(Follow._class_declaration_in_class_list462);
					class_declaration12=class_declaration();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, class_declaration12.Tree);

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
			TraceOut("class_list", 5);
			LeaveRule("class_list", 5);
			Leave_class_list();
			if (state.backtracking > 0) { Memoize(input, 5, class_list_StartIndex); }
		}
		DebugLocation(64, 32);
		} finally { DebugExitRule(GrammarFileName, "class_list"); }
		return retval;

	}
	// $ANTLR end "class_list"

	public class func_list_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_func_list();
	partial void Leave_func_list();

	// $ANTLR start "func_list"
	// MathLang.g:66:1: func_list : ( funcdeclaration )* -> ^( PROGRAM ( funcdeclaration )* ) ;
	[GrammarRule("func_list")]
	private MathLangParser.func_list_return func_list()
	{
		Enter_func_list();
		EnterRule("func_list", 6);
		TraceIn("func_list", 6);
		MathLangParser.func_list_return retval = new MathLangParser.func_list_return();
		retval.Start = (IToken)input.LT(1);
		int func_list_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.funcdeclaration_return funcdeclaration13 = default(MathLangParser.funcdeclaration_return);

		RewriteRuleSubtreeStream stream_funcdeclaration=new RewriteRuleSubtreeStream(adaptor,"rule funcdeclaration");
		try { DebugEnterRule(GrammarFileName, "func_list");
		DebugLocation(66, 61);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 6)) { return retval; }
			// MathLang.g:66:11: ( ( funcdeclaration )* -> ^( PROGRAM ( funcdeclaration )* ) )
			DebugEnterAlt(1);
			// MathLang.g:66:13: ( funcdeclaration )*
			{
			DebugLocation(66, 13);
			// MathLang.g:66:13: ( funcdeclaration )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_0 = input.LA(1);

				if ((LA4_0==MODIFIER))
				{
					alt4=1;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: funcdeclaration
					{
					DebugLocation(66, 13);
					PushFollow(Follow._funcdeclaration_in_func_list472);
					funcdeclaration13=funcdeclaration();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_funcdeclaration.Add(funcdeclaration13.Tree);

					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }



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
			// 66:30: -> ^( PROGRAM ( funcdeclaration )* )
			{
				DebugLocation(66, 33);
				// MathLang.g:66:33: ^( PROGRAM ( funcdeclaration )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(66, 35);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROGRAM, "PROGRAM"), root_1);

				DebugLocation(66, 43);
				// MathLang.g:66:43: ( funcdeclaration )*
				while ( stream_funcdeclaration.HasNext )
				{
					DebugLocation(66, 43);
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
			TraceOut("func_list", 6);
			LeaveRule("func_list", 6);
			Leave_func_list();
			if (state.backtracking > 0) { Memoize(input, 6, func_list_StartIndex); }
		}
		DebugLocation(66, 61);
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
	// MathLang.g:68:1: statement : ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | returnstatement | funccall | newexpression ) ;
	[GrammarRule("statement")]
	private MathLangParser.statement_return statement()
	{
		Enter_statement();
		EnterRule("statement", 7);
		TraceIn("statement", 7);
		MathLangParser.statement_return retval = new MathLangParser.statement_return();
		retval.Start = (IToken)input.LT(1);
		int statement_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.declaration_return declaration14 = default(MathLangParser.declaration_return);
		MathLangParser.assignment_return assignment15 = default(MathLangParser.assignment_return);
		MathLangParser.ifstatement_return ifstatement16 = default(MathLangParser.ifstatement_return);
		MathLangParser.whilestatement_return whilestatement17 = default(MathLangParser.whilestatement_return);
		MathLangParser.dowhilestatement_return dowhilestatement18 = default(MathLangParser.dowhilestatement_return);
		MathLangParser.forstatement_return forstatement19 = default(MathLangParser.forstatement_return);
		MathLangParser.returnstatement_return returnstatement20 = default(MathLangParser.returnstatement_return);
		MathLangParser.funccall_return funccall21 = default(MathLangParser.funccall_return);
		MathLangParser.newexpression_return newexpression22 = default(MathLangParser.newexpression_return);


		try { DebugEnterRule(GrammarFileName, "statement");
		DebugLocation(68, 4);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 7)) { return retval; }
			// MathLang.g:68:10: ( ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | returnstatement | funccall | newexpression ) )
			DebugEnterAlt(1);
			// MathLang.g:68:12: ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | returnstatement | funccall | newexpression )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(68, 12);
			// MathLang.g:68:12: ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | returnstatement | funccall | newexpression )
			int alt5=9;
			try { DebugEnterSubRule(5);
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
				// MathLang.g:68:14: declaration
				{
				DebugLocation(68, 14);
				PushFollow(Follow._declaration_in_statement493);
				declaration14=declaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, declaration14.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:69:4: assignment
				{
				DebugLocation(69, 4);
				PushFollow(Follow._assignment_in_statement499);
				assignment15=assignment();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment15.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:70:4: ifstatement
				{
				DebugLocation(70, 4);
				PushFollow(Follow._ifstatement_in_statement504);
				ifstatement16=ifstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ifstatement16.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:71:4: whilestatement
				{
				DebugLocation(71, 4);
				PushFollow(Follow._whilestatement_in_statement509);
				whilestatement17=whilestatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, whilestatement17.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:72:4: dowhilestatement
				{
				DebugLocation(72, 4);
				PushFollow(Follow._dowhilestatement_in_statement514);
				dowhilestatement18=dowhilestatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dowhilestatement18.Tree);

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// MathLang.g:73:4: forstatement
				{
				DebugLocation(73, 4);
				PushFollow(Follow._forstatement_in_statement519);
				forstatement19=forstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forstatement19.Tree);

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// MathLang.g:74:4: returnstatement
				{
				DebugLocation(74, 4);
				PushFollow(Follow._returnstatement_in_statement524);
				returnstatement20=returnstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, returnstatement20.Tree);

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// MathLang.g:75:4: funccall
				{
				DebugLocation(75, 4);
				PushFollow(Follow._funccall_in_statement529);
				funccall21=funccall();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccall21.Tree);

				}
				break;
			case 9:
				DebugEnterAlt(9);
				// MathLang.g:76:4: newexpression
				{
				DebugLocation(76, 4);
				PushFollow(Follow._newexpression_in_statement534);
				newexpression22=newexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, newexpression22.Tree);

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
			TraceOut("statement", 7);
			LeaveRule("statement", 7);
			Leave_statement();
			if (state.backtracking > 0) { Memoize(input, 7, statement_StartIndex); }
		}
		DebugLocation(78, 4);
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
	// MathLang.g:80:1: type : TYPE ;
	[GrammarRule("type")]
	private MathLangParser.type_return type()
	{
		Enter_type();
		EnterRule("type", 8);
		TraceIn("type", 8);
		MathLangParser.type_return retval = new MathLangParser.type_return();
		retval.Start = (IToken)input.LT(1);
		int type_StartIndex = input.Index;
		object root_0 = null;

		IToken TYPE23=null;

		object TYPE23_tree=null;

		try { DebugEnterRule(GrammarFileName, "type");
		DebugLocation(80, 11);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 8)) { return retval; }
			// MathLang.g:80:5: ( TYPE )
			DebugEnterAlt(1);
			// MathLang.g:80:7: TYPE
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(80, 7);
			TYPE23=(IToken)Match(input,TYPE,Follow._TYPE_in_type548); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			TYPE23_tree = (object)adaptor.Create(TYPE23);
			adaptor.AddChild(root_0, TYPE23_tree);
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
			TraceOut("type", 8);
			LeaveRule("type", 8);
			Leave_type();
			if (state.backtracking > 0) { Memoize(input, 8, type_StartIndex); }
		}
		DebugLocation(80, 11);
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
	// MathLang.g:81:1: array_type : TYPE ARRAY_DECLARATION_MARK ;
	[GrammarRule("array_type")]
	private MathLangParser.array_type_return array_type()
	{
		Enter_array_type();
		EnterRule("array_type", 9);
		TraceIn("array_type", 9);
		MathLangParser.array_type_return retval = new MathLangParser.array_type_return();
		retval.Start = (IToken)input.LT(1);
		int array_type_StartIndex = input.Index;
		object root_0 = null;

		IToken TYPE24=null;
		IToken ARRAY_DECLARATION_MARK25=null;

		object TYPE24_tree=null;
		object ARRAY_DECLARATION_MARK25_tree=null;

		try { DebugEnterRule(GrammarFileName, "array_type");
		DebugLocation(81, 40);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 9)) { return retval; }
			// MathLang.g:81:11: ( TYPE ARRAY_DECLARATION_MARK )
			DebugEnterAlt(1);
			// MathLang.g:81:13: TYPE ARRAY_DECLARATION_MARK
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(81, 13);
			TYPE24=(IToken)Match(input,TYPE,Follow._TYPE_in_array_type555); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			TYPE24_tree = (object)adaptor.Create(TYPE24);
			adaptor.AddChild(root_0, TYPE24_tree);
			}
			DebugLocation(81, 40);
			ARRAY_DECLARATION_MARK25=(IToken)Match(input,ARRAY_DECLARATION_MARK,Follow._ARRAY_DECLARATION_MARK_in_array_type557); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("array_type", 9);
			LeaveRule("array_type", 9);
			Leave_array_type();
			if (state.backtracking > 0) { Memoize(input, 9, array_type_StartIndex); }
		}
		DebugLocation(81, 40);
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
	// MathLang.g:82:1: any_type : ( type | array_type | VOID );
	[GrammarRule("any_type")]
	private MathLangParser.any_type_return any_type()
	{
		Enter_any_type();
		EnterRule("any_type", 10);
		TraceIn("any_type", 10);
		MathLangParser.any_type_return retval = new MathLangParser.any_type_return();
		retval.Start = (IToken)input.LT(1);
		int any_type_StartIndex = input.Index;
		object root_0 = null;

		IToken VOID28=null;
		MathLangParser.type_return type26 = default(MathLangParser.type_return);
		MathLangParser.array_type_return array_type27 = default(MathLangParser.array_type_return);

		object VOID28_tree=null;

		try { DebugEnterRule(GrammarFileName, "any_type");
		DebugLocation(82, 34);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 10)) { return retval; }
			// MathLang.g:82:9: ( type | array_type | VOID )
			int alt6=3;
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
			else if ((LA6_0==VOID))
			{
				alt6=3;
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
				// MathLang.g:82:11: type
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(82, 11);
				PushFollow(Follow._type_in_any_type564);
				type26=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type26.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:82:18: array_type
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(82, 18);
				PushFollow(Follow._array_type_in_any_type568);
				array_type27=array_type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, array_type27.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:82:31: VOID
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(82, 31);
				VOID28=(IToken)Match(input,VOID,Follow._VOID_in_any_type572); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				VOID28_tree = (object)adaptor.Create(VOID28);
				adaptor.AddChild(root_0, VOID28_tree);
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
			TraceOut("any_type", 10);
			LeaveRule("any_type", 10);
			Leave_any_type();
			if (state.backtracking > 0) { Memoize(input, 10, any_type_StartIndex); }
		}
		DebugLocation(82, 34);
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
	// MathLang.g:83:1: number : ( NUMBER | extended_id | funccallbody | CHAR | arrayelement );
	[GrammarRule("number")]
	private MathLangParser.number_return number()
	{
		Enter_number();
		EnterRule("number", 11);
		TraceIn("number", 11);
		MathLangParser.number_return retval = new MathLangParser.number_return();
		retval.Start = (IToken)input.LT(1);
		int number_StartIndex = input.Index;
		object root_0 = null;

		IToken NUMBER29=null;
		IToken CHAR32=null;
		MathLangParser.extended_id_return extended_id30 = default(MathLangParser.extended_id_return);
		MathLangParser.funccallbody_return funccallbody31 = default(MathLangParser.funccallbody_return);
		MathLangParser.arrayelement_return arrayelement33 = default(MathLangParser.arrayelement_return);

		object NUMBER29_tree=null;
		object CHAR32_tree=null;

		try { DebugEnterRule(GrammarFileName, "number");
		DebugLocation(83, 16);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 11)) { return retval; }
			// MathLang.g:83:8: ( NUMBER | extended_id | funccallbody | CHAR | arrayelement )
			int alt7=5;
			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
			switch (input.LA(1))
			{
			case NUMBER:
				{
				alt7=1;
				}
				break;
			case ID:
				{
				switch (input.LA(2))
				{
				case DOT:
					{
					int LA7_4 = input.LA(3);

					if ((LA7_4==ID))
					{
						switch (input.LA(4))
						{
						case EOF:
						case CLOSE_SQUARE_BRACE:
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
						case CLOSE_BRACE:
						case OR:
						case AND:
						case 69:
						case 70:
						case 71:
							{
							alt7=2;
							}
							break;
						case OPEN_BRACE:
							{
							alt7=3;
							}
							break;
						case OPEN_SQUARE_BRACE:
							{
							alt7=5;
							}
							break;
						default:
							{
								if (state.backtracking>0) {state.failed=true; return retval;}
								NoViableAltException nvae = new NoViableAltException("", 7, 8, input);

								DebugRecognitionException(nvae);
								throw nvae;
							}
						}

					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 7, 4, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
					}
					break;
				case EOF:
				case CLOSE_SQUARE_BRACE:
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
				case CLOSE_BRACE:
				case OR:
				case AND:
				case 69:
				case 70:
				case 71:
					{
					alt7=2;
					}
					break;
				case OPEN_BRACE:
					{
					alt7=3;
					}
					break;
				case OPEN_SQUARE_BRACE:
					{
					alt7=5;
					}
					break;
				default:
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 7, 2, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}

				}
				break;
			case CHAR:
				{
				alt7=4;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 7, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(7); }
			switch (alt7)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:83:11: NUMBER
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(83, 11);
				NUMBER29=(IToken)Match(input,NUMBER,Follow._NUMBER_in_number580); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				NUMBER29_tree = (object)adaptor.Create(NUMBER29);
				adaptor.AddChild(root_0, NUMBER29_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:84:5: extended_id
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(84, 5);
				PushFollow(Follow._extended_id_in_number586);
				extended_id30=extended_id();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, extended_id30.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:85:5: funccallbody
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(85, 5);
				PushFollow(Follow._funccallbody_in_number592);
				funccallbody31=funccallbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody31.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:86:5: CHAR
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(86, 5);
				CHAR32=(IToken)Match(input,CHAR,Follow._CHAR_in_number598); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				CHAR32_tree = (object)adaptor.Create(CHAR32);
				adaptor.AddChild(root_0, CHAR32_tree);
				}

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:87:5: arrayelement
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(87, 5);
				PushFollow(Follow._arrayelement_in_number604);
				arrayelement33=arrayelement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayelement33.Tree);

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
			TraceOut("number", 11);
			LeaveRule("number", 11);
			Leave_number();
			if (state.backtracking > 0) { Memoize(input, 11, number_StartIndex); }
		}
		DebugLocation(87, 16);
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
	// MathLang.g:88:1: mathexpression : term ;
	[GrammarRule("mathexpression")]
	private MathLangParser.mathexpression_return mathexpression()
	{
		Enter_mathexpression();
		EnterRule("mathexpression", 12);
		TraceIn("mathexpression", 12);
		MathLangParser.mathexpression_return retval = new MathLangParser.mathexpression_return();
		retval.Start = (IToken)input.LT(1);
		int mathexpression_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.term_return term34 = default(MathLangParser.term_return);


		try { DebugEnterRule(GrammarFileName, "mathexpression");
		DebugLocation(88, 21);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 12)) { return retval; }
			// MathLang.g:88:15: ( term )
			DebugEnterAlt(1);
			// MathLang.g:88:17: term
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(88, 17);
			PushFollow(Follow._term_in_mathexpression610);
			term34=term();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term34.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("mathexpression", 12);
			LeaveRule("mathexpression", 12);
			Leave_mathexpression();
			if (state.backtracking > 0) { Memoize(input, 12, mathexpression_StartIndex); }
		}
		DebugLocation(88, 21);
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
	// MathLang.g:90:1: expression : ( newexpression | funccallbody | boolexpression | mathexpression );
	[GrammarRule("expression")]
	private MathLangParser.expression_return expression()
	{
		Enter_expression();
		EnterRule("expression", 13);
		TraceIn("expression", 13);
		MathLangParser.expression_return retval = new MathLangParser.expression_return();
		retval.Start = (IToken)input.LT(1);
		int expression_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.newexpression_return newexpression35 = default(MathLangParser.newexpression_return);
		MathLangParser.funccallbody_return funccallbody36 = default(MathLangParser.funccallbody_return);
		MathLangParser.boolexpression_return boolexpression37 = default(MathLangParser.boolexpression_return);
		MathLangParser.mathexpression_return mathexpression38 = default(MathLangParser.mathexpression_return);


		try { DebugEnterRule(GrammarFileName, "expression");
		DebugLocation(90, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 13)) { return retval; }
			// MathLang.g:90:11: ( newexpression | funccallbody | boolexpression | mathexpression )
			int alt8=4;
			try { DebugEnterDecision(8, decisionCanBacktrack[8]);
			try
			{
				alt8 = dfa8.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(8); }
			switch (alt8)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:91:5: newexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(91, 5);
				PushFollow(Follow._newexpression_in_expression624);
				newexpression35=newexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, newexpression35.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:92:5: funccallbody
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(92, 5);
				PushFollow(Follow._funccallbody_in_expression630);
				funccallbody36=funccallbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody36.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:93:5: boolexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(93, 5);
				PushFollow(Follow._boolexpression_in_expression636);
				boolexpression37=boolexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression37.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:94:5: mathexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(94, 5);
				PushFollow(Follow._mathexpression_in_expression642);
				mathexpression38=mathexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mathexpression38.Tree);

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
			TraceOut("expression", 13);
			LeaveRule("expression", 13);
			Leave_expression();
			if (state.backtracking > 0) { Memoize(input, 13, expression_StartIndex); }
		}
		DebugLocation(97, 0);
		} finally { DebugExitRule(GrammarFileName, "expression"); }
		return retval;

	}
	// $ANTLR end "expression"

	public class extended_id_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_extended_id();
	partial void Leave_extended_id();

	// $ANTLR start "extended_id"
	// MathLang.g:98:1: extended_id : ID ( DOT ID )? -> ^( ID ( ID )? ) ;
	[GrammarRule("extended_id")]
	private MathLangParser.extended_id_return extended_id()
	{
		Enter_extended_id();
		EnterRule("extended_id", 14);
		TraceIn("extended_id", 14);
		MathLangParser.extended_id_return retval = new MathLangParser.extended_id_return();
		retval.Start = (IToken)input.LT(1);
		int extended_id_StartIndex = input.Index;
		object root_0 = null;

		IToken ID39=null;
		IToken DOT40=null;
		IToken ID41=null;

		object ID39_tree=null;
		object DOT40_tree=null;
		object ID41_tree=null;
		RewriteRuleITokenStream stream_DOT=new RewriteRuleITokenStream(adaptor,"token DOT");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");

		try { DebugEnterRule(GrammarFileName, "extended_id");
		DebugLocation(98, 39);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 14)) { return retval; }
			// MathLang.g:98:12: ( ID ( DOT ID )? -> ^( ID ( ID )? ) )
			DebugEnterAlt(1);
			// MathLang.g:98:14: ID ( DOT ID )?
			{
			DebugLocation(98, 14);
			ID39=(IToken)Match(input,ID,Follow._ID_in_extended_id655); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID39);

			DebugLocation(98, 17);
			// MathLang.g:98:17: ( DOT ID )?
			int alt9=2;
			try { DebugEnterSubRule(9);
			try { DebugEnterDecision(9, decisionCanBacktrack[9]);
			int LA9_0 = input.LA(1);

			if ((LA9_0==DOT))
			{
				alt9=1;
			}
			} finally { DebugExitDecision(9); }
			switch (alt9)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:98:18: DOT ID
				{
				DebugLocation(98, 21);
				DOT40=(IToken)Match(input,DOT,Follow._DOT_in_extended_id658); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_DOT.Add(DOT40);

				DebugLocation(98, 23);
				ID41=(IToken)Match(input,ID,Follow._ID_in_extended_id661); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID41);


				}
				break;

			}
			} finally { DebugExitSubRule(9); }



			{
			// AST REWRITE
			// elements: ID, ID
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 98:28: -> ^( ID ( ID )? )
			{
				DebugLocation(98, 31);
				// MathLang.g:98:31: ^( ID ( ID )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(98, 33);
				root_1 = (object)adaptor.BecomeRoot(stream_ID.NextNode(), root_1);

				DebugLocation(98, 36);
				// MathLang.g:98:36: ( ID )?
				if ( stream_ID.HasNext )
				{
					DebugLocation(98, 36);
					adaptor.AddChild(root_1, stream_ID.NextNode());

				}
				stream_ID.Reset();

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
			TraceOut("extended_id", 14);
			LeaveRule("extended_id", 14);
			Leave_extended_id();
			if (state.backtracking > 0) { Memoize(input, 14, extended_id_StartIndex); }
		}
		DebugLocation(98, 39);
		} finally { DebugExitRule(GrammarFileName, "extended_id"); }
		return retval;

	}
	// $ANTLR end "extended_id"

	public class arrayelement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_arrayelement();
	partial void Leave_arrayelement();

	// $ANTLR start "arrayelement"
	// MathLang.g:100:1: arrayelement : extended_id OPEN_SQUARE_BRACE number CLOSE_SQUARE_BRACE -> ^( ARRAYELEMENT extended_id number ) ;
	[GrammarRule("arrayelement")]
	private MathLangParser.arrayelement_return arrayelement()
	{
		Enter_arrayelement();
		EnterRule("arrayelement", 15);
		TraceIn("arrayelement", 15);
		MathLangParser.arrayelement_return retval = new MathLangParser.arrayelement_return();
		retval.Start = (IToken)input.LT(1);
		int arrayelement_StartIndex = input.Index;
		object root_0 = null;

		IToken OPEN_SQUARE_BRACE43=null;
		IToken CLOSE_SQUARE_BRACE45=null;
		MathLangParser.extended_id_return extended_id42 = default(MathLangParser.extended_id_return);
		MathLangParser.number_return number44 = default(MathLangParser.number_return);

		object OPEN_SQUARE_BRACE43_tree=null;
		object CLOSE_SQUARE_BRACE45_tree=null;
		RewriteRuleITokenStream stream_OPEN_SQUARE_BRACE=new RewriteRuleITokenStream(adaptor,"token OPEN_SQUARE_BRACE");
		RewriteRuleITokenStream stream_CLOSE_SQUARE_BRACE=new RewriteRuleITokenStream(adaptor,"token CLOSE_SQUARE_BRACE");
		RewriteRuleSubtreeStream stream_extended_id=new RewriteRuleSubtreeStream(adaptor,"rule extended_id");
		RewriteRuleSubtreeStream stream_number=new RewriteRuleSubtreeStream(adaptor,"rule number");
		try { DebugEnterRule(GrammarFileName, "arrayelement");
		DebugLocation(100, 109);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 15)) { return retval; }
			// MathLang.g:100:13: ( extended_id OPEN_SQUARE_BRACE number CLOSE_SQUARE_BRACE -> ^( ARRAYELEMENT extended_id number ) )
			DebugEnterAlt(1);
			// MathLang.g:100:16: extended_id OPEN_SQUARE_BRACE number CLOSE_SQUARE_BRACE
			{
			DebugLocation(100, 16);
			PushFollow(Follow._extended_id_in_arrayelement680);
			extended_id42=extended_id();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_extended_id.Add(extended_id42.Tree);
			DebugLocation(100, 28);
			OPEN_SQUARE_BRACE43=(IToken)Match(input,OPEN_SQUARE_BRACE,Follow._OPEN_SQUARE_BRACE_in_arrayelement682); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OPEN_SQUARE_BRACE.Add(OPEN_SQUARE_BRACE43);

			DebugLocation(100, 46);
			PushFollow(Follow._number_in_arrayelement684);
			number44=number();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_number.Add(number44.Tree);
			DebugLocation(100, 53);
			CLOSE_SQUARE_BRACE45=(IToken)Match(input,CLOSE_SQUARE_BRACE,Follow._CLOSE_SQUARE_BRACE_in_arrayelement686); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CLOSE_SQUARE_BRACE.Add(CLOSE_SQUARE_BRACE45);



			{
			// AST REWRITE
			// elements: extended_id, number
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 100:72: -> ^( ARRAYELEMENT extended_id number )
			{
				DebugLocation(100, 75);
				// MathLang.g:100:75: ^( ARRAYELEMENT extended_id number )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(100, 77);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYELEMENT, "ARRAYELEMENT"), root_1);

				DebugLocation(100, 90);
				adaptor.AddChild(root_1, stream_extended_id.NextTree());
				DebugLocation(100, 102);
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
			TraceOut("arrayelement", 15);
			LeaveRule("arrayelement", 15);
			Leave_arrayelement();
			if (state.backtracking > 0) { Memoize(input, 15, arrayelement_StartIndex); }
		}
		DebugLocation(100, 109);
		} finally { DebugExitRule(GrammarFileName, "arrayelement"); }
		return retval;

	}
	// $ANTLR end "arrayelement"

	public class static_declaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_static_declaration();
	partial void Leave_static_declaration();

	// $ANTLR start "static_declaration"
	// MathLang.g:101:1: static_declaration : MODIFIER declaration -> ^( STATIC_DECLARATION declaration ) ;
	[GrammarRule("static_declaration")]
	private MathLangParser.static_declaration_return static_declaration()
	{
		Enter_static_declaration();
		EnterRule("static_declaration", 16);
		TraceIn("static_declaration", 16);
		MathLangParser.static_declaration_return retval = new MathLangParser.static_declaration_return();
		retval.Start = (IToken)input.LT(1);
		int static_declaration_StartIndex = input.Index;
		object root_0 = null;

		IToken MODIFIER46=null;
		MathLangParser.declaration_return declaration47 = default(MathLangParser.declaration_return);

		object MODIFIER46_tree=null;
		RewriteRuleITokenStream stream_MODIFIER=new RewriteRuleITokenStream(adaptor,"token MODIFIER");
		RewriteRuleSubtreeStream stream_declaration=new RewriteRuleSubtreeStream(adaptor,"rule declaration");
		try { DebugEnterRule(GrammarFileName, "static_declaration");
		DebugLocation(101, 78);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 16)) { return retval; }
			// MathLang.g:101:19: ( MODIFIER declaration -> ^( STATIC_DECLARATION declaration ) )
			DebugEnterAlt(1);
			// MathLang.g:101:22: MODIFIER declaration
			{
			DebugLocation(101, 22);
			MODIFIER46=(IToken)Match(input,MODIFIER,Follow._MODIFIER_in_static_declaration704); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_MODIFIER.Add(MODIFIER46);

			DebugLocation(101, 31);
			PushFollow(Follow._declaration_in_static_declaration706);
			declaration47=declaration();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declaration.Add(declaration47.Tree);


			{
			// AST REWRITE
			// elements: declaration
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 101:43: -> ^( STATIC_DECLARATION declaration )
			{
				DebugLocation(101, 46);
				// MathLang.g:101:46: ^( STATIC_DECLARATION declaration )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(101, 48);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(STATIC_DECLARATION, "STATIC_DECLARATION"), root_1);

				DebugLocation(101, 67);
				adaptor.AddChild(root_1, stream_declaration.NextTree());

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
			TraceOut("static_declaration", 16);
			LeaveRule("static_declaration", 16);
			Leave_static_declaration();
			if (state.backtracking > 0) { Memoize(input, 16, static_declaration_StartIndex); }
		}
		DebugLocation(101, 78);
		} finally { DebugExitRule(GrammarFileName, "static_declaration"); }
		return retval;

	}
	// $ANTLR end "static_declaration"

	public class declaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_declaration();
	partial void Leave_declaration();

	// $ANTLR start "declaration"
	// MathLang.g:103:1: declaration : type d_list ';' -> ^( MULT_DECL type d_list ) ;
	[GrammarRule("declaration")]
	private MathLangParser.declaration_return declaration()
	{
		Enter_declaration();
		EnterRule("declaration", 17);
		TraceIn("declaration", 17);
		MathLangParser.declaration_return retval = new MathLangParser.declaration_return();
		retval.Start = (IToken)input.LT(1);
		int declaration_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal50=null;
		MathLangParser.type_return type48 = default(MathLangParser.type_return);
		MathLangParser.d_list_return d_list49 = default(MathLangParser.d_list_return);

		object char_literal50_tree=null;
		RewriteRuleITokenStream stream_70=new RewriteRuleITokenStream(adaptor,"token 70");
		RewriteRuleSubtreeStream stream_d_list=new RewriteRuleSubtreeStream(adaptor,"rule d_list");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "declaration");
		DebugLocation(103, 57);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 17)) { return retval; }
			// MathLang.g:103:12: ( type d_list ';' -> ^( MULT_DECL type d_list ) )
			DebugEnterAlt(1);
			// MathLang.g:103:14: type d_list ';'
			{
			DebugLocation(103, 14);
			PushFollow(Follow._type_in_declaration721);
			type48=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type48.Tree);
			DebugLocation(103, 19);
			PushFollow(Follow._d_list_in_declaration723);
			d_list49=d_list();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_d_list.Add(d_list49.Tree);
			DebugLocation(103, 26);
			char_literal50=(IToken)Match(input,70,Follow._70_in_declaration725); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_70.Add(char_literal50);



			{
			// AST REWRITE
			// elements: type, d_list
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 103:30: -> ^( MULT_DECL type d_list )
			{
				DebugLocation(103, 33);
				// MathLang.g:103:33: ^( MULT_DECL type d_list )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(103, 35);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(MULT_DECL, "MULT_DECL"), root_1);

				DebugLocation(103, 45);
				adaptor.AddChild(root_1, stream_type.NextTree());
				DebugLocation(103, 50);
				adaptor.AddChild(root_1, stream_d_list.NextTree());

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
			TraceOut("declaration", 17);
			LeaveRule("declaration", 17);
			Leave_declaration();
			if (state.backtracking > 0) { Memoize(input, 17, declaration_StartIndex); }
		}
		DebugLocation(103, 57);
		} finally { DebugExitRule(GrammarFileName, "declaration"); }
		return retval;

	}
	// $ANTLR end "declaration"

	public class d_list_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_d_list();
	partial void Leave_d_list();

	// $ANTLR start "d_list"
	// MathLang.g:105:1: d_list : d ( ',' d )* -> ^( VARS d ( d )* ) ;
	[GrammarRule("d_list")]
	private MathLangParser.d_list_return d_list()
	{
		Enter_d_list();
		EnterRule("d_list", 18);
		TraceIn("d_list", 18);
		MathLangParser.d_list_return retval = new MathLangParser.d_list_return();
		retval.Start = (IToken)input.LT(1);
		int d_list_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal52=null;
		MathLangParser.d_return d51 = default(MathLangParser.d_return);
		MathLangParser.d_return d53 = default(MathLangParser.d_return);

		object char_literal52_tree=null;
		RewriteRuleITokenStream stream_71=new RewriteRuleITokenStream(adaptor,"token 71");
		RewriteRuleSubtreeStream stream_d=new RewriteRuleSubtreeStream(adaptor,"rule d");
		try { DebugEnterRule(GrammarFileName, "d_list");
		DebugLocation(105, 39);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 18)) { return retval; }
			// MathLang.g:105:7: ( d ( ',' d )* -> ^( VARS d ( d )* ) )
			DebugEnterAlt(1);
			// MathLang.g:105:9: d ( ',' d )*
			{
			DebugLocation(105, 9);
			PushFollow(Follow._d_in_d_list743);
			d51=d();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_d.Add(d51.Tree);
			DebugLocation(105, 11);
			// MathLang.g:105:11: ( ',' d )*
			try { DebugEnterSubRule(10);
			while (true)
			{
				int alt10=2;
				try { DebugEnterDecision(10, decisionCanBacktrack[10]);
				int LA10_0 = input.LA(1);

				if ((LA10_0==71))
				{
					alt10=1;
				}


				} finally { DebugExitDecision(10); }
				switch ( alt10 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:105:12: ',' d
					{
					DebugLocation(105, 15);
					char_literal52=(IToken)Match(input,71,Follow._71_in_d_list746); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_71.Add(char_literal52);

					DebugLocation(105, 17);
					PushFollow(Follow._d_in_d_list749);
					d53=d();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_d.Add(d53.Tree);

					}
					break;

				default:
					goto loop10;
				}
			}

			loop10:
				;

			} finally { DebugExitSubRule(10); }



			{
			// AST REWRITE
			// elements: d, d
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 105:21: -> ^( VARS d ( d )* )
			{
				DebugLocation(105, 24);
				// MathLang.g:105:24: ^( VARS d ( d )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(105, 27);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARS, "VARS"), root_1);

				DebugLocation(105, 32);
				adaptor.AddChild(root_1, stream_d.NextTree());
				DebugLocation(105, 34);
				// MathLang.g:105:34: ( d )*
				while ( stream_d.HasNext )
				{
					DebugLocation(105, 34);
					adaptor.AddChild(root_1, stream_d.NextTree());

				}
				stream_d.Reset();

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
			TraceOut("d_list", 18);
			LeaveRule("d_list", 18);
			Leave_d_list();
			if (state.backtracking > 0) { Memoize(input, 18, d_list_StartIndex); }
		}
		DebugLocation(105, 39);
		} finally { DebugExitRule(GrammarFileName, "d_list"); }
		return retval;

	}
	// $ANTLR end "d_list"

	public class d_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_d();
	partial void Leave_d();

	// $ANTLR start "d"
	// MathLang.g:107:1: d : ( declarationbody_d | longdeclarationbody_d );
	[GrammarRule("d")]
	private MathLangParser.d_return d()
	{
		Enter_d();
		EnterRule("d", 19);
		TraceIn("d", 19);
		MathLangParser.d_return retval = new MathLangParser.d_return();
		retval.Start = (IToken)input.LT(1);
		int d_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.declarationbody_d_return declarationbody_d54 = default(MathLangParser.declarationbody_d_return);
		MathLangParser.longdeclarationbody_d_return longdeclarationbody_d55 = default(MathLangParser.longdeclarationbody_d_return);


		try { DebugEnterRule(GrammarFileName, "d");
		DebugLocation(107, 45);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 19)) { return retval; }
			// MathLang.g:107:2: ( declarationbody_d | longdeclarationbody_d )
			int alt11=2;
			try { DebugEnterDecision(11, decisionCanBacktrack[11]);
			int LA11_0 = input.LA(1);

			if ((LA11_0==ID))
			{
				int LA11_1 = input.LA(2);

				if ((LA11_1==ASSIGN))
				{
					alt11=2;
				}
				else if ((LA11_1==EOF||(LA11_1>=70 && LA11_1<=71)))
				{
					alt11=1;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 11, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
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
				// MathLang.g:107:4: declarationbody_d
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(107, 4);
				PushFollow(Follow._declarationbody_d_in_d773);
				declarationbody_d54=declarationbody_d();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, declarationbody_d54.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:107:24: longdeclarationbody_d
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(107, 24);
				PushFollow(Follow._longdeclarationbody_d_in_d777);
				longdeclarationbody_d55=longdeclarationbody_d();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclarationbody_d55.Tree);

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
			TraceOut("d", 19);
			LeaveRule("d", 19);
			Leave_d();
			if (state.backtracking > 0) { Memoize(input, 19, d_StartIndex); }
		}
		DebugLocation(107, 45);
		} finally { DebugExitRule(GrammarFileName, "d"); }
		return retval;

	}
	// $ANTLR end "d"

	public class declarationbody_d_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_declarationbody_d();
	partial void Leave_declarationbody_d();

	// $ANTLR start "declarationbody_d"
	// MathLang.g:117:1: declarationbody_d : ( ID -> ^( VARDECLARATION ID ) ) ;
	[GrammarRule("declarationbody_d")]
	private MathLangParser.declarationbody_d_return declarationbody_d()
	{
		Enter_declarationbody_d();
		EnterRule("declarationbody_d", 20);
		TraceIn("declarationbody_d", 20);
		MathLangParser.declarationbody_d_return retval = new MathLangParser.declarationbody_d_return();
		retval.Start = (IToken)input.LT(1);
		int declarationbody_d_StartIndex = input.Index;
		object root_0 = null;

		IToken ID56=null;

		object ID56_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");

		try { DebugEnterRule(GrammarFileName, "declarationbody_d");
		DebugLocation(117, 4);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 20)) { return retval; }
			// MathLang.g:117:18: ( ( ID -> ^( VARDECLARATION ID ) ) )
			DebugEnterAlt(1);
			// MathLang.g:117:20: ( ID -> ^( VARDECLARATION ID ) )
			{
			DebugLocation(117, 20);
			// MathLang.g:117:20: ( ID -> ^( VARDECLARATION ID ) )
			DebugEnterAlt(1);
			// MathLang.g:117:21: ID
			{
			DebugLocation(117, 21);
			ID56=(IToken)Match(input,ID,Follow._ID_in_declarationbody_d791); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID56);



			{
			// AST REWRITE
			// elements: ID
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 117:24: -> ^( VARDECLARATION ID )
			{
				DebugLocation(117, 27);
				// MathLang.g:117:27: ^( VARDECLARATION ID )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(117, 29);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDECLARATION, "VARDECLARATION"), root_1);

				DebugLocation(117, 44);
				adaptor.AddChild(root_1, stream_ID.NextNode());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
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
			TraceOut("declarationbody_d", 20);
			LeaveRule("declarationbody_d", 20);
			Leave_declarationbody_d();
			if (state.backtracking > 0) { Memoize(input, 20, declarationbody_d_StartIndex); }
		}
		DebugLocation(119, 4);
		} finally { DebugExitRule(GrammarFileName, "declarationbody_d"); }
		return retval;

	}
	// $ANTLR end "declarationbody_d"

	public class longdeclarationbody_d_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_longdeclarationbody_d();
	partial void Leave_longdeclarationbody_d();

	// $ANTLR start "longdeclarationbody_d"
	// MathLang.g:120:1: longdeclarationbody_d : ( ID ASSIGN expression -> ^( VARDECLARATION ID expression ) ) ;
	[GrammarRule("longdeclarationbody_d")]
	private MathLangParser.longdeclarationbody_d_return longdeclarationbody_d()
	{
		Enter_longdeclarationbody_d();
		EnterRule("longdeclarationbody_d", 21);
		TraceIn("longdeclarationbody_d", 21);
		MathLangParser.longdeclarationbody_d_return retval = new MathLangParser.longdeclarationbody_d_return();
		retval.Start = (IToken)input.LT(1);
		int longdeclarationbody_d_StartIndex = input.Index;
		object root_0 = null;

		IToken ID57=null;
		IToken ASSIGN58=null;
		MathLangParser.expression_return expression59 = default(MathLangParser.expression_return);

		object ID57_tree=null;
		object ASSIGN58_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "longdeclarationbody_d");
		DebugLocation(120, 5);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 21)) { return retval; }
			// MathLang.g:120:22: ( ( ID ASSIGN expression -> ^( VARDECLARATION ID expression ) ) )
			DebugEnterAlt(1);
			// MathLang.g:120:24: ( ID ASSIGN expression -> ^( VARDECLARATION ID expression ) )
			{
			DebugLocation(120, 24);
			// MathLang.g:120:24: ( ID ASSIGN expression -> ^( VARDECLARATION ID expression ) )
			DebugEnterAlt(1);
			// MathLang.g:120:25: ID ASSIGN expression
			{
			DebugLocation(120, 25);
			ID57=(IToken)Match(input,ID,Follow._ID_in_longdeclarationbody_d818); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID57);

			DebugLocation(120, 28);
			ASSIGN58=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclarationbody_d820); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN58);

			DebugLocation(120, 35);
			PushFollow(Follow._expression_in_longdeclarationbody_d822);
			expression59=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression59.Tree);


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
			// 120:47: -> ^( VARDECLARATION ID expression )
			{
				DebugLocation(120, 50);
				// MathLang.g:120:50: ^( VARDECLARATION ID expression )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(120, 52);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDECLARATION, "VARDECLARATION"), root_1);

				DebugLocation(120, 67);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(120, 70);
				adaptor.AddChild(root_1, stream_expression.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
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
			TraceOut("longdeclarationbody_d", 21);
			LeaveRule("longdeclarationbody_d", 21);
			Leave_longdeclarationbody_d();
			if (state.backtracking > 0) { Memoize(input, 21, longdeclarationbody_d_StartIndex); }
		}
		DebugLocation(122, 5);
		} finally { DebugExitRule(GrammarFileName, "longdeclarationbody_d"); }
		return retval;

	}
	// $ANTLR end "longdeclarationbody_d"

	public class declarationbody_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_declarationbody();
	partial void Leave_declarationbody();

	// $ANTLR start "declarationbody"
	// MathLang.g:125:1: declarationbody : ( ( type ID -> ^( VARDECLARATION type ID ) ) | ( array_type ID -> ^( ARRAYDECLARATION array_type ID ) ) );
	[GrammarRule("declarationbody")]
	private MathLangParser.declarationbody_return declarationbody()
	{
		Enter_declarationbody();
		EnterRule("declarationbody", 22);
		TraceIn("declarationbody", 22);
		MathLangParser.declarationbody_return retval = new MathLangParser.declarationbody_return();
		retval.Start = (IToken)input.LT(1);
		int declarationbody_StartIndex = input.Index;
		object root_0 = null;

		IToken ID61=null;
		IToken ID63=null;
		MathLangParser.type_return type60 = default(MathLangParser.type_return);
		MathLangParser.array_type_return array_type62 = default(MathLangParser.array_type_return);

		object ID61_tree=null;
		object ID63_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleSubtreeStream stream_array_type=new RewriteRuleSubtreeStream(adaptor,"rule array_type");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "declarationbody");
		DebugLocation(125, 4);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 22)) { return retval; }
			// MathLang.g:125:16: ( ( type ID -> ^( VARDECLARATION type ID ) ) | ( array_type ID -> ^( ARRAYDECLARATION array_type ID ) ) )
			int alt12=2;
			try { DebugEnterDecision(12, decisionCanBacktrack[12]);
			int LA12_0 = input.LA(1);

			if ((LA12_0==TYPE))
			{
				int LA12_1 = input.LA(2);

				if ((LA12_1==ARRAY_DECLARATION_MARK))
				{
					alt12=2;
				}
				else if ((LA12_1==ID))
				{
					alt12=1;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 12, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
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
				// MathLang.g:125:18: ( type ID -> ^( VARDECLARATION type ID ) )
				{
				DebugLocation(125, 18);
				// MathLang.g:125:18: ( type ID -> ^( VARDECLARATION type ID ) )
				DebugEnterAlt(1);
				// MathLang.g:125:19: type ID
				{
				DebugLocation(125, 19);
				PushFollow(Follow._type_in_declarationbody855);
				type60=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type60.Tree);
				DebugLocation(125, 24);
				ID61=(IToken)Match(input,ID,Follow._ID_in_declarationbody857); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID61);



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
				// 125:27: -> ^( VARDECLARATION type ID )
				{
					DebugLocation(125, 30);
					// MathLang.g:125:30: ^( VARDECLARATION type ID )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(125, 32);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDECLARATION, "VARDECLARATION"), root_1);

					DebugLocation(125, 47);
					adaptor.AddChild(root_1, stream_type.NextTree());
					DebugLocation(125, 52);
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
				// MathLang.g:126:7: ( array_type ID -> ^( ARRAYDECLARATION array_type ID ) )
				{
				DebugLocation(126, 7);
				// MathLang.g:126:7: ( array_type ID -> ^( ARRAYDECLARATION array_type ID ) )
				DebugEnterAlt(1);
				// MathLang.g:126:8: array_type ID
				{
				DebugLocation(126, 8);
				PushFollow(Follow._array_type_in_declarationbody878);
				array_type62=array_type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_array_type.Add(array_type62.Tree);
				DebugLocation(126, 19);
				ID63=(IToken)Match(input,ID,Follow._ID_in_declarationbody880); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID63);



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
				// 126:22: -> ^( ARRAYDECLARATION array_type ID )
				{
					DebugLocation(126, 25);
					// MathLang.g:126:25: ^( ARRAYDECLARATION array_type ID )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(126, 27);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYDECLARATION, "ARRAYDECLARATION"), root_1);

					DebugLocation(126, 44);
					adaptor.AddChild(root_1, stream_array_type.NextTree());
					DebugLocation(126, 55);
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
			TraceOut("declarationbody", 22);
			LeaveRule("declarationbody", 22);
			Leave_declarationbody();
			if (state.backtracking > 0) { Memoize(input, 22, declarationbody_StartIndex); }
		}
		DebugLocation(127, 4);
		} finally { DebugExitRule(GrammarFileName, "declarationbody"); }
		return retval;

	}
	// $ANTLR end "declarationbody"

	public class longdeclarationbody_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_longdeclarationbody();
	partial void Leave_longdeclarationbody();

	// $ANTLR start "longdeclarationbody"
	// MathLang.g:128:1: longdeclarationbody : ( ( type ID ASSIGN expression -> ^( VARDECLARATION type ID expression ) ) | ( array_type ID ASSIGN newexpression -> ^( ARRAYDECLARATION array_type ID newexpression ) ) );
	[GrammarRule("longdeclarationbody")]
	private MathLangParser.longdeclarationbody_return longdeclarationbody()
	{
		Enter_longdeclarationbody();
		EnterRule("longdeclarationbody", 23);
		TraceIn("longdeclarationbody", 23);
		MathLangParser.longdeclarationbody_return retval = new MathLangParser.longdeclarationbody_return();
		retval.Start = (IToken)input.LT(1);
		int longdeclarationbody_StartIndex = input.Index;
		object root_0 = null;

		IToken ID65=null;
		IToken ASSIGN66=null;
		IToken ID69=null;
		IToken ASSIGN70=null;
		MathLangParser.type_return type64 = default(MathLangParser.type_return);
		MathLangParser.expression_return expression67 = default(MathLangParser.expression_return);
		MathLangParser.array_type_return array_type68 = default(MathLangParser.array_type_return);
		MathLangParser.newexpression_return newexpression71 = default(MathLangParser.newexpression_return);

		object ID65_tree=null;
		object ASSIGN66_tree=null;
		object ID69_tree=null;
		object ASSIGN70_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_newexpression=new RewriteRuleSubtreeStream(adaptor,"rule newexpression");
		RewriteRuleSubtreeStream stream_array_type=new RewriteRuleSubtreeStream(adaptor,"rule array_type");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "longdeclarationbody");
		DebugLocation(128, 5);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 23)) { return retval; }
			// MathLang.g:128:20: ( ( type ID ASSIGN expression -> ^( VARDECLARATION type ID expression ) ) | ( array_type ID ASSIGN newexpression -> ^( ARRAYDECLARATION array_type ID newexpression ) ) )
			int alt13=2;
			try { DebugEnterDecision(13, decisionCanBacktrack[13]);
			int LA13_0 = input.LA(1);

			if ((LA13_0==TYPE))
			{
				int LA13_1 = input.LA(2);

				if ((LA13_1==ARRAY_DECLARATION_MARK))
				{
					alt13=2;
				}
				else if ((LA13_1==ID))
				{
					alt13=1;
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
				// MathLang.g:128:22: ( type ID ASSIGN expression -> ^( VARDECLARATION type ID expression ) )
				{
				DebugLocation(128, 22);
				// MathLang.g:128:22: ( type ID ASSIGN expression -> ^( VARDECLARATION type ID expression ) )
				DebugEnterAlt(1);
				// MathLang.g:128:24: type ID ASSIGN expression
				{
				DebugLocation(128, 24);
				PushFollow(Follow._type_in_longdeclarationbody904);
				type64=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type64.Tree);
				DebugLocation(128, 29);
				ID65=(IToken)Match(input,ID,Follow._ID_in_longdeclarationbody906); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID65);

				DebugLocation(128, 32);
				ASSIGN66=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclarationbody908); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN66);

				DebugLocation(128, 39);
				PushFollow(Follow._expression_in_longdeclarationbody910);
				expression67=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression67.Tree);


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
				// 128:51: -> ^( VARDECLARATION type ID expression )
				{
					DebugLocation(128, 54);
					// MathLang.g:128:54: ^( VARDECLARATION type ID expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(128, 56);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDECLARATION, "VARDECLARATION"), root_1);

					DebugLocation(128, 71);
					adaptor.AddChild(root_1, stream_type.NextTree());
					DebugLocation(128, 76);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(128, 79);
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
				// MathLang.g:129:8: ( array_type ID ASSIGN newexpression -> ^( ARRAYDECLARATION array_type ID newexpression ) )
				{
				DebugLocation(129, 8);
				// MathLang.g:129:8: ( array_type ID ASSIGN newexpression -> ^( ARRAYDECLARATION array_type ID newexpression ) )
				DebugEnterAlt(1);
				// MathLang.g:129:9: array_type ID ASSIGN newexpression
				{
				DebugLocation(129, 9);
				PushFollow(Follow._array_type_in_longdeclarationbody934);
				array_type68=array_type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_array_type.Add(array_type68.Tree);
				DebugLocation(129, 20);
				ID69=(IToken)Match(input,ID,Follow._ID_in_longdeclarationbody936); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID69);

				DebugLocation(129, 23);
				ASSIGN70=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclarationbody938); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN70);

				DebugLocation(129, 30);
				PushFollow(Follow._newexpression_in_longdeclarationbody940);
				newexpression71=newexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_newexpression.Add(newexpression71.Tree);


				{
				// AST REWRITE
				// elements: newexpression, ID, array_type
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 129:44: -> ^( ARRAYDECLARATION array_type ID newexpression )
				{
					DebugLocation(129, 47);
					// MathLang.g:129:47: ^( ARRAYDECLARATION array_type ID newexpression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(129, 49);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYDECLARATION, "ARRAYDECLARATION"), root_1);

					DebugLocation(129, 66);
					adaptor.AddChild(root_1, stream_array_type.NextTree());
					DebugLocation(129, 77);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(129, 80);
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
			TraceOut("longdeclarationbody", 23);
			LeaveRule("longdeclarationbody", 23);
			Leave_longdeclarationbody();
			if (state.backtracking > 0) { Memoize(input, 23, longdeclarationbody_StartIndex); }
		}
		DebugLocation(130, 5);
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
	// MathLang.g:132:1: add : mul ( ( ADD | SUB ) mul )* ;
	[GrammarRule("add")]
	private MathLangParser.add_return add()
	{
		Enter_add();
		EnterRule("add", 24);
		TraceIn("add", 24);
		MathLangParser.add_return retval = new MathLangParser.add_return();
		retval.Start = (IToken)input.LT(1);
		int add_StartIndex = input.Index;
		object root_0 = null;

		IToken set73=null;
		MathLangParser.mul_return mul72 = default(MathLangParser.mul_return);
		MathLangParser.mul_return mul74 = default(MathLangParser.mul_return);

		object set73_tree=null;

		try { DebugEnterRule(GrammarFileName, "add");
		DebugLocation(132, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 24)) { return retval; }
			// MathLang.g:132:4: ( mul ( ( ADD | SUB ) mul )* )
			DebugEnterAlt(1);
			// MathLang.g:132:6: mul ( ( ADD | SUB ) mul )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(132, 6);
			PushFollow(Follow._mul_in_add966);
			mul72=mul();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul72.Tree);
			DebugLocation(132, 10);
			// MathLang.g:132:10: ( ( ADD | SUB ) mul )*
			try { DebugEnterSubRule(14);
			while (true)
			{
				int alt14=2;
				try { DebugEnterDecision(14, decisionCanBacktrack[14]);
				int LA14_0 = input.LA(1);

				if (((LA14_0>=ADD && LA14_0<=SUB)))
				{
					alt14=1;
				}


				} finally { DebugExitDecision(14); }
				switch ( alt14 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:132:12: ( ADD | SUB ) mul
					{
					DebugLocation(132, 12);
					set73=(IToken)input.LT(1);
					set73=(IToken)input.LT(1);
					if ((input.LA(1)>=ADD && input.LA(1)<=SUB))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set73), root_0);
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(132, 25);
					PushFollow(Follow._mul_in_add979);
					mul74=mul();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul74.Tree);

					}
					break;

				default:
					goto loop14;
				}
			}

			loop14:
				;

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
			TraceOut("add", 24);
			LeaveRule("add", 24);
			Leave_add();
			if (state.backtracking > 0) { Memoize(input, 24, add_StartIndex); }
		}
		DebugLocation(132, 30);
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
	// MathLang.g:133:1: mul : group ( ( MUL | DIV ) group )* ;
	[GrammarRule("mul")]
	private MathLangParser.mul_return mul()
	{
		Enter_mul();
		EnterRule("mul", 25);
		TraceIn("mul", 25);
		MathLangParser.mul_return retval = new MathLangParser.mul_return();
		retval.Start = (IToken)input.LT(1);
		int mul_StartIndex = input.Index;
		object root_0 = null;

		IToken set76=null;
		MathLangParser.group_return group75 = default(MathLangParser.group_return);
		MathLangParser.group_return group77 = default(MathLangParser.group_return);

		object set76_tree=null;

		try { DebugEnterRule(GrammarFileName, "mul");
		DebugLocation(133, 33);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 25)) { return retval; }
			// MathLang.g:133:4: ( group ( ( MUL | DIV ) group )* )
			DebugEnterAlt(1);
			// MathLang.g:133:6: group ( ( MUL | DIV ) group )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(133, 6);
			PushFollow(Follow._group_in_mul988);
			group75=group();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group75.Tree);
			DebugLocation(133, 12);
			// MathLang.g:133:12: ( ( MUL | DIV ) group )*
			try { DebugEnterSubRule(15);
			while (true)
			{
				int alt15=2;
				try { DebugEnterDecision(15, decisionCanBacktrack[15]);
				int LA15_0 = input.LA(1);

				if (((LA15_0>=MUL && LA15_0<=DIV)))
				{
					alt15=1;
				}


				} finally { DebugExitDecision(15); }
				switch ( alt15 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:133:14: ( MUL | DIV ) group
					{
					DebugLocation(133, 14);
					set76=(IToken)input.LT(1);
					set76=(IToken)input.LT(1);
					if ((input.LA(1)>=MUL && input.LA(1)<=DIV))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set76), root_0);
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(133, 27);
					PushFollow(Follow._group_in_mul1001);
					group77=group();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group77.Tree);

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
			TraceOut("mul", 25);
			LeaveRule("mul", 25);
			Leave_mul();
			if (state.backtracking > 0) { Memoize(input, 25, mul_StartIndex); }
		}
		DebugLocation(133, 33);
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
	// MathLang.g:134:1: compare : add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )? ;
	[GrammarRule("compare")]
	private MathLangParser.compare_return compare()
	{
		Enter_compare();
		EnterRule("compare", 26);
		TraceIn("compare", 26);
		MathLangParser.compare_return retval = new MathLangParser.compare_return();
		retval.Start = (IToken)input.LT(1);
		int compare_StartIndex = input.Index;
		object root_0 = null;

		IToken set79=null;
		MathLangParser.add_return add78 = default(MathLangParser.add_return);
		MathLangParser.add_return add80 = default(MathLangParser.add_return);

		object set79_tree=null;

		try { DebugEnterRule(GrammarFileName, "compare");
		DebugLocation(134, 60);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 26)) { return retval; }
			// MathLang.g:134:8: ( add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )? )
			DebugEnterAlt(1);
			// MathLang.g:134:10: add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(134, 10);
			PushFollow(Follow._add_in_compare1009);
			add78=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add78.Tree);
			DebugLocation(134, 14);
			// MathLang.g:134:14: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
			int alt16=2;
			try { DebugEnterSubRule(16);
			try { DebugEnterDecision(16, decisionCanBacktrack[16]);
			try
			{
				alt16 = dfa16.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(16); }
			switch (alt16)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:134:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
				{
				DebugLocation(134, 16);
				set79=(IToken)input.LT(1);
				set79=(IToken)input.LT(1);
				if ((input.LA(1)>=GREQ && input.LA(1)<=LS))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set79), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(134, 53);
				PushFollow(Follow._add_in_compare1039);
				add80=add();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add80.Tree);

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
			TraceOut("compare", 26);
			LeaveRule("compare", 26);
			Leave_compare();
			if (state.backtracking > 0) { Memoize(input, 26, compare_StartIndex); }
		}
		DebugLocation(134, 60);
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
	// MathLang.g:135:1: term : add ;
	[GrammarRule("term")]
	private MathLangParser.term_return term()
	{
		Enter_term();
		EnterRule("term", 27);
		TraceIn("term", 27);
		MathLangParser.term_return retval = new MathLangParser.term_return();
		retval.Start = (IToken)input.LT(1);
		int term_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.add_return add81 = default(MathLangParser.add_return);


		try { DebugEnterRule(GrammarFileName, "term");
		DebugLocation(135, 9);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 27)) { return retval; }
			// MathLang.g:135:5: ( add )
			DebugEnterAlt(1);
			// MathLang.g:135:7: add
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(135, 7);
			PushFollow(Follow._add_in_term1050);
			add81=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add81.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("term", 27);
			LeaveRule("term", 27);
			Leave_term();
			if (state.backtracking > 0) { Memoize(input, 27, term_StartIndex); }
		}
		DebugLocation(135, 9);
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
	// MathLang.g:136:1: group : ( ( SUB )? OPEN_BRACE term CLOSE_BRACE | number );
	[GrammarRule("group")]
	private MathLangParser.group_return group()
	{
		Enter_group();
		EnterRule("group", 28);
		TraceIn("group", 28);
		MathLangParser.group_return retval = new MathLangParser.group_return();
		retval.Start = (IToken)input.LT(1);
		int group_StartIndex = input.Index;
		object root_0 = null;

		IToken SUB82=null;
		IToken OPEN_BRACE83=null;
		IToken CLOSE_BRACE85=null;
		MathLangParser.term_return term84 = default(MathLangParser.term_return);
		MathLangParser.number_return number86 = default(MathLangParser.number_return);

		object SUB82_tree=null;
		object OPEN_BRACE83_tree=null;
		object CLOSE_BRACE85_tree=null;

		try { DebugEnterRule(GrammarFileName, "group");
		DebugLocation(136, 53);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 28)) { return retval; }
			// MathLang.g:136:6: ( ( SUB )? OPEN_BRACE term CLOSE_BRACE | number )
			int alt18=2;
			try { DebugEnterDecision(18, decisionCanBacktrack[18]);
			int LA18_0 = input.LA(1);

			if ((LA18_0==SUB||LA18_0==OPEN_BRACE))
			{
				alt18=1;
			}
			else if ((LA18_0==ID||(LA18_0>=NUMBER && LA18_0<=CHAR)))
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
				// MathLang.g:136:8: ( SUB )? OPEN_BRACE term CLOSE_BRACE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(136, 8);
				// MathLang.g:136:8: ( SUB )?
				int alt17=2;
				try { DebugEnterSubRule(17);
				try { DebugEnterDecision(17, decisionCanBacktrack[17]);
				int LA17_0 = input.LA(1);

				if ((LA17_0==SUB))
				{
					alt17=1;
				}
				} finally { DebugExitDecision(17); }
				switch (alt17)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:136:9: SUB
					{
					DebugLocation(136, 12);
					SUB82=(IToken)Match(input,SUB,Follow._SUB_in_group1057); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					SUB82_tree = (object)adaptor.Create(SUB82);
					root_0 = (object)adaptor.BecomeRoot(SUB82_tree, root_0);
					}

					}
					break;

				}
				} finally { DebugExitSubRule(17); }

				DebugLocation(136, 26);
				OPEN_BRACE83=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_group1062); if (state.failed) return retval;
				DebugLocation(136, 28);
				PushFollow(Follow._term_in_group1065);
				term84=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term84.Tree);
				DebugLocation(136, 44);
				CLOSE_BRACE85=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_group1067); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:136:48: number
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(136, 48);
				PushFollow(Follow._number_in_group1072);
				number86=number();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, number86.Tree);

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
			TraceOut("group", 28);
			LeaveRule("group", 28);
			Leave_group();
			if (state.backtracking > 0) { Memoize(input, 28, group_StartIndex); }
		}
		DebugLocation(136, 53);
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
	// MathLang.g:138:1: assignment : assignmentbody ';' ;
	[GrammarRule("assignment")]
	private MathLangParser.assignment_return assignment()
	{
		Enter_assignment();
		EnterRule("assignment", 29);
		TraceIn("assignment", 29);
		MathLangParser.assignment_return retval = new MathLangParser.assignment_return();
		retval.Start = (IToken)input.LT(1);
		int assignment_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal88=null;
		MathLangParser.assignmentbody_return assignmentbody87 = default(MathLangParser.assignmentbody_return);

		object char_literal88_tree=null;

		try { DebugEnterRule(GrammarFileName, "assignment");
		DebugLocation(138, 31);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 29)) { return retval; }
			// MathLang.g:138:11: ( assignmentbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:138:13: assignmentbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(138, 13);
			PushFollow(Follow._assignmentbody_in_assignment1079);
			assignmentbody87=assignmentbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentbody87.Tree);
			DebugLocation(138, 31);
			char_literal88=(IToken)Match(input,70,Follow._70_in_assignment1081); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("assignment", 29);
			LeaveRule("assignment", 29);
			Leave_assignment();
			if (state.backtracking > 0) { Memoize(input, 29, assignment_StartIndex); }
		}
		DebugLocation(138, 31);
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
	// MathLang.g:139:1: assignmentbody : ( ( extended_id ASSIGN expression -> ^( VARASSIGNMENT extended_id expression ) ) | ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) ) );
	[GrammarRule("assignmentbody")]
	private MathLangParser.assignmentbody_return assignmentbody()
	{
		Enter_assignmentbody();
		EnterRule("assignmentbody", 30);
		TraceIn("assignmentbody", 30);
		MathLangParser.assignmentbody_return retval = new MathLangParser.assignmentbody_return();
		retval.Start = (IToken)input.LT(1);
		int assignmentbody_StartIndex = input.Index;
		object root_0 = null;

		IToken ASSIGN90=null;
		IToken ASSIGN93=null;
		MathLangParser.extended_id_return extended_id89 = default(MathLangParser.extended_id_return);
		MathLangParser.expression_return expression91 = default(MathLangParser.expression_return);
		MathLangParser.arrayelement_return arrayelement92 = default(MathLangParser.arrayelement_return);
		MathLangParser.expression_return expression94 = default(MathLangParser.expression_return);

		object ASSIGN90_tree=null;
		object ASSIGN93_tree=null;
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_extended_id=new RewriteRuleSubtreeStream(adaptor,"rule extended_id");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_arrayelement=new RewriteRuleSubtreeStream(adaptor,"rule arrayelement");
		try { DebugEnterRule(GrammarFileName, "assignmentbody");
		DebugLocation(139, 87);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 30)) { return retval; }
			// MathLang.g:139:15: ( ( extended_id ASSIGN expression -> ^( VARASSIGNMENT extended_id expression ) ) | ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) ) )
			int alt19=2;
			try { DebugEnterDecision(19, decisionCanBacktrack[19]);
			int LA19_0 = input.LA(1);

			if ((LA19_0==ID))
			{
				switch (input.LA(2))
				{
				case DOT:
					{
					int LA19_2 = input.LA(3);

					if ((LA19_2==ID))
					{
						int LA19_5 = input.LA(4);

						if ((LA19_5==ASSIGN))
						{
							alt19=1;
						}
						else if ((LA19_5==OPEN_SQUARE_BRACE))
						{
							alt19=2;
						}
						else
						{
							if (state.backtracking>0) {state.failed=true; return retval;}
							NoViableAltException nvae = new NoViableAltException("", 19, 5, input);

							DebugRecognitionException(nvae);
							throw nvae;
						}
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 19, 2, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
					}
					break;
				case ASSIGN:
					{
					alt19=1;
					}
					break;
				case OPEN_SQUARE_BRACE:
					{
					alt19=2;
					}
					break;
				default:
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 19, 1, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}

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
				// MathLang.g:139:17: ( extended_id ASSIGN expression -> ^( VARASSIGNMENT extended_id expression ) )
				{
				DebugLocation(139, 17);
				// MathLang.g:139:17: ( extended_id ASSIGN expression -> ^( VARASSIGNMENT extended_id expression ) )
				DebugEnterAlt(1);
				// MathLang.g:139:18: extended_id ASSIGN expression
				{
				DebugLocation(139, 18);
				PushFollow(Follow._extended_id_in_assignmentbody1089);
				extended_id89=extended_id();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_extended_id.Add(extended_id89.Tree);
				DebugLocation(139, 30);
				ASSIGN90=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignmentbody1091); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN90);

				DebugLocation(139, 37);
				PushFollow(Follow._expression_in_assignmentbody1093);
				expression91=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression91.Tree);


				{
				// AST REWRITE
				// elements: extended_id, expression
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 139:48: -> ^( VARASSIGNMENT extended_id expression )
				{
					DebugLocation(139, 51);
					// MathLang.g:139:51: ^( VARASSIGNMENT extended_id expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(139, 53);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARASSIGNMENT, "VARASSIGNMENT"), root_1);

					DebugLocation(139, 67);
					adaptor.AddChild(root_1, stream_extended_id.NextTree());
					DebugLocation(139, 79);
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
				// MathLang.g:140:2: ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) )
				{
				DebugLocation(140, 2);
				// MathLang.g:140:2: ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) )
				DebugEnterAlt(1);
				// MathLang.g:140:4: arrayelement ASSIGN expression
				{
				DebugLocation(140, 4);
				PushFollow(Follow._arrayelement_in_assignmentbody1112);
				arrayelement92=arrayelement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_arrayelement.Add(arrayelement92.Tree);
				DebugLocation(140, 17);
				ASSIGN93=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignmentbody1114); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN93);

				DebugLocation(140, 24);
				PushFollow(Follow._expression_in_assignmentbody1116);
				expression94=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression94.Tree);


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
				// 140:35: -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression )
				{
					DebugLocation(140, 38);
					// MathLang.g:140:38: ^( ARRAYELEMENTASSIGNMENT arrayelement expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(140, 40);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYELEMENTASSIGNMENT, "ARRAYELEMENTASSIGNMENT"), root_1);

					DebugLocation(140, 63);
					adaptor.AddChild(root_1, stream_arrayelement.NextTree());
					DebugLocation(140, 76);
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
			TraceOut("assignmentbody", 30);
			LeaveRule("assignmentbody", 30);
			Leave_assignmentbody();
			if (state.backtracking > 0) { Memoize(input, 30, assignmentbody_StartIndex); }
		}
		DebugLocation(140, 87);
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
	// MathLang.g:142:1: boolexpression : boolterm ;
	[GrammarRule("boolexpression")]
	private MathLangParser.boolexpression_return boolexpression()
	{
		Enter_boolexpression();
		EnterRule("boolexpression", 31);
		TraceIn("boolexpression", 31);
		MathLangParser.boolexpression_return retval = new MathLangParser.boolexpression_return();
		retval.Start = (IToken)input.LT(1);
		int boolexpression_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.boolterm_return boolterm95 = default(MathLangParser.boolterm_return);


		try { DebugEnterRule(GrammarFileName, "boolexpression");
		DebugLocation(142, 25);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 31)) { return retval; }
			// MathLang.g:142:15: ( boolterm )
			DebugEnterAlt(1);
			// MathLang.g:142:17: boolterm
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(142, 17);
			PushFollow(Follow._boolterm_in_boolexpression1134);
			boolterm95=boolterm();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm95.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("boolexpression", 31);
			LeaveRule("boolexpression", 31);
			Leave_boolexpression();
			if (state.backtracking > 0) { Memoize(input, 31, boolexpression_StartIndex); }
		}
		DebugLocation(142, 25);
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
	// MathLang.g:143:1: boolterm : or ( ( EQ | NEQ ) or )? ;
	[GrammarRule("boolterm")]
	private MathLangParser.boolterm_return boolterm()
	{
		Enter_boolterm();
		EnterRule("boolterm", 32);
		TraceIn("boolterm", 32);
		MathLangParser.boolterm_return retval = new MathLangParser.boolterm_return();
		retval.Start = (IToken)input.LT(1);
		int boolterm_StartIndex = input.Index;
		object root_0 = null;

		IToken set97=null;
		MathLangParser.or_return or96 = default(MathLangParser.or_return);
		MathLangParser.or_return or98 = default(MathLangParser.or_return);

		object set97_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolterm");
		DebugLocation(143, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 32)) { return retval; }
			// MathLang.g:143:9: ( or ( ( EQ | NEQ ) or )? )
			DebugEnterAlt(1);
			// MathLang.g:143:11: or ( ( EQ | NEQ ) or )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(143, 11);
			PushFollow(Follow._or_in_boolterm1141);
			or96=or();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or96.Tree);
			DebugLocation(143, 14);
			// MathLang.g:143:14: ( ( EQ | NEQ ) or )?
			int alt20=2;
			try { DebugEnterSubRule(20);
			try { DebugEnterDecision(20, decisionCanBacktrack[20]);
			int LA20_0 = input.LA(1);

			if (((LA20_0>=NEQ && LA20_0<=EQ)))
			{
				alt20=1;
			}
			} finally { DebugExitDecision(20); }
			switch (alt20)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:143:16: ( EQ | NEQ ) or
				{
				DebugLocation(143, 16);
				set97=(IToken)input.LT(1);
				set97=(IToken)input.LT(1);
				if ((input.LA(1)>=NEQ && input.LA(1)<=EQ))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set97), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(143, 28);
				PushFollow(Follow._or_in_boolterm1154);
				or98=or();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or98.Tree);

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
			TraceOut("boolterm", 32);
			LeaveRule("boolterm", 32);
			Leave_boolterm();
			if (state.backtracking > 0) { Memoize(input, 32, boolterm_StartIndex); }
		}
		DebugLocation(143, 32);
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
	// MathLang.g:144:1: or : and ( OR and )* ;
	[GrammarRule("or")]
	private MathLangParser.or_return or()
	{
		Enter_or();
		EnterRule("or", 33);
		TraceIn("or", 33);
		MathLangParser.or_return retval = new MathLangParser.or_return();
		retval.Start = (IToken)input.LT(1);
		int or_StartIndex = input.Index;
		object root_0 = null;

		IToken OR100=null;
		MathLangParser.and_return and99 = default(MathLangParser.and_return);
		MathLangParser.and_return and101 = default(MathLangParser.and_return);

		object OR100_tree=null;

		try { DebugEnterRule(GrammarFileName, "or");
		DebugLocation(144, 18);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 33)) { return retval; }
			// MathLang.g:144:3: ( and ( OR and )* )
			DebugEnterAlt(1);
			// MathLang.g:144:5: and ( OR and )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(144, 5);
			PushFollow(Follow._and_in_or1163);
			and99=and();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and99.Tree);
			DebugLocation(144, 9);
			// MathLang.g:144:9: ( OR and )*
			try { DebugEnterSubRule(21);
			while (true)
			{
				int alt21=2;
				try { DebugEnterDecision(21, decisionCanBacktrack[21]);
				int LA21_0 = input.LA(1);

				if ((LA21_0==OR))
				{
					alt21=1;
				}


				} finally { DebugExitDecision(21); }
				switch ( alt21 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:144:10: OR and
					{
					DebugLocation(144, 12);
					OR100=(IToken)Match(input,OR,Follow._OR_in_or1166); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR100_tree = (object)adaptor.Create(OR100);
					root_0 = (object)adaptor.BecomeRoot(OR100_tree, root_0);
					}
					DebugLocation(144, 14);
					PushFollow(Follow._and_in_or1169);
					and101=and();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and101.Tree);

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

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("or", 33);
			LeaveRule("or", 33);
			Leave_or();
			if (state.backtracking > 0) { Memoize(input, 33, or_StartIndex); }
		}
		DebugLocation(144, 18);
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
	// MathLang.g:145:1: and : boolgroup ( AND boolgroup )* ;
	[GrammarRule("and")]
	private MathLangParser.and_return and()
	{
		Enter_and();
		EnterRule("and", 34);
		TraceIn("and", 34);
		MathLangParser.and_return retval = new MathLangParser.and_return();
		retval.Start = (IToken)input.LT(1);
		int and_StartIndex = input.Index;
		object root_0 = null;

		IToken AND103=null;
		MathLangParser.boolgroup_return boolgroup102 = default(MathLangParser.boolgroup_return);
		MathLangParser.boolgroup_return boolgroup104 = default(MathLangParser.boolgroup_return);

		object AND103_tree=null;

		try { DebugEnterRule(GrammarFileName, "and");
		DebugLocation(145, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 34)) { return retval; }
			// MathLang.g:145:4: ( boolgroup ( AND boolgroup )* )
			DebugEnterAlt(1);
			// MathLang.g:145:6: boolgroup ( AND boolgroup )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(145, 6);
			PushFollow(Follow._boolgroup_in_and1177);
			boolgroup102=boolgroup();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup102.Tree);
			DebugLocation(145, 16);
			// MathLang.g:145:16: ( AND boolgroup )*
			try { DebugEnterSubRule(22);
			while (true)
			{
				int alt22=2;
				try { DebugEnterDecision(22, decisionCanBacktrack[22]);
				int LA22_0 = input.LA(1);

				if ((LA22_0==AND))
				{
					alt22=1;
				}


				} finally { DebugExitDecision(22); }
				switch ( alt22 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:145:17: AND boolgroup
					{
					DebugLocation(145, 20);
					AND103=(IToken)Match(input,AND,Follow._AND_in_and1180); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND103_tree = (object)adaptor.Create(AND103);
					root_0 = (object)adaptor.BecomeRoot(AND103_tree, root_0);
					}
					DebugLocation(145, 22);
					PushFollow(Follow._boolgroup_in_and1183);
					boolgroup104=boolgroup();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup104.Tree);

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
			TraceOut("and", 34);
			LeaveRule("and", 34);
			Leave_and();
			if (state.backtracking > 0) { Memoize(input, 34, and_StartIndex); }
		}
		DebugLocation(145, 32);
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
	// MathLang.g:146:1: boolgroup : ( NOT )? ( OPEN_BRACE boolterm CLOSE_BRACE | boolvar ) ;
	[GrammarRule("boolgroup")]
	private MathLangParser.boolgroup_return boolgroup()
	{
		Enter_boolgroup();
		EnterRule("boolgroup", 35);
		TraceIn("boolgroup", 35);
		MathLangParser.boolgroup_return retval = new MathLangParser.boolgroup_return();
		retval.Start = (IToken)input.LT(1);
		int boolgroup_StartIndex = input.Index;
		object root_0 = null;

		IToken NOT105=null;
		IToken OPEN_BRACE106=null;
		IToken CLOSE_BRACE108=null;
		MathLangParser.boolterm_return boolterm107 = default(MathLangParser.boolterm_return);
		MathLangParser.boolvar_return boolvar109 = default(MathLangParser.boolvar_return);

		object NOT105_tree=null;
		object OPEN_BRACE106_tree=null;
		object CLOSE_BRACE108_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolgroup");
		DebugLocation(146, 66);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 35)) { return retval; }
			// MathLang.g:146:10: ( ( NOT )? ( OPEN_BRACE boolterm CLOSE_BRACE | boolvar ) )
			DebugEnterAlt(1);
			// MathLang.g:146:12: ( NOT )? ( OPEN_BRACE boolterm CLOSE_BRACE | boolvar )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(146, 12);
			// MathLang.g:146:12: ( NOT )?
			int alt23=2;
			try { DebugEnterSubRule(23);
			try { DebugEnterDecision(23, decisionCanBacktrack[23]);
			int LA23_0 = input.LA(1);

			if ((LA23_0==NOT))
			{
				alt23=1;
			}
			} finally { DebugExitDecision(23); }
			switch (alt23)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:146:13: NOT
				{
				DebugLocation(146, 16);
				NOT105=(IToken)Match(input,NOT,Follow._NOT_in_boolgroup1192); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				NOT105_tree = (object)adaptor.Create(NOT105);
				root_0 = (object)adaptor.BecomeRoot(NOT105_tree, root_0);
				}

				}
				break;

			}
			} finally { DebugExitSubRule(23); }

			DebugLocation(146, 20);
			// MathLang.g:146:20: ( OPEN_BRACE boolterm CLOSE_BRACE | boolvar )
			int alt24=2;
			try { DebugEnterSubRule(24);
			try { DebugEnterDecision(24, decisionCanBacktrack[24]);
			int LA24_0 = input.LA(1);

			if ((LA24_0==OPEN_BRACE))
			{
				int LA24_1 = input.LA(2);

				if ((EvaluatePredicate(synpred45_MathLang_fragment)))
				{
					alt24=1;
				}
				else if ((true))
				{
					alt24=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 24, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else if ((LA24_0==ID||(LA24_0>=NUMBER && LA24_0<=CHAR)||LA24_0==SUB||(LA24_0>=TRUE && LA24_0<=FALSE)))
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
				// MathLang.g:146:22: OPEN_BRACE boolterm CLOSE_BRACE
				{
				DebugLocation(146, 32);
				OPEN_BRACE106=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_boolgroup1199); if (state.failed) return retval;
				DebugLocation(146, 34);
				PushFollow(Follow._boolterm_in_boolgroup1202);
				boolterm107=boolterm();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm107.Tree);
				DebugLocation(146, 54);
				CLOSE_BRACE108=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_boolgroup1204); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:146:58: boolvar
				{
				DebugLocation(146, 58);
				PushFollow(Follow._boolvar_in_boolgroup1209);
				boolvar109=boolvar();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolvar109.Tree);

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
			TraceOut("boolgroup", 35);
			LeaveRule("boolgroup", 35);
			Leave_boolgroup();
			if (state.backtracking > 0) { Memoize(input, 35, boolgroup_StartIndex); }
		}
		DebugLocation(146, 66);
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
	// MathLang.g:147:1: boolvar : ( TRUE | FALSE | compare );
	[GrammarRule("boolvar")]
	private MathLangParser.boolvar_return boolvar()
	{
		Enter_boolvar();
		EnterRule("boolvar", 36);
		TraceIn("boolvar", 36);
		MathLangParser.boolvar_return retval = new MathLangParser.boolvar_return();
		retval.Start = (IToken)input.LT(1);
		int boolvar_StartIndex = input.Index;
		object root_0 = null;

		IToken TRUE110=null;
		IToken FALSE111=null;
		MathLangParser.compare_return compare112 = default(MathLangParser.compare_return);

		object TRUE110_tree=null;
		object FALSE111_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolvar");
		DebugLocation(147, 11);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 36)) { return retval; }
			// MathLang.g:147:8: ( TRUE | FALSE | compare )
			int alt25=3;
			try { DebugEnterDecision(25, decisionCanBacktrack[25]);
			switch (input.LA(1))
			{
			case TRUE:
				{
				alt25=1;
				}
				break;
			case FALSE:
				{
				alt25=2;
				}
				break;
			case ID:
			case NUMBER:
			case CHAR:
			case SUB:
			case OPEN_BRACE:
				{
				alt25=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 25, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(25); }
			switch (alt25)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:147:10: TRUE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(147, 10);
				TRUE110=(IToken)Match(input,TRUE,Follow._TRUE_in_boolvar1217); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				TRUE110_tree = (object)adaptor.Create(TRUE110);
				adaptor.AddChild(root_0, TRUE110_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:148:5: FALSE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(148, 5);
				FALSE111=(IToken)Match(input,FALSE,Follow._FALSE_in_boolvar1223); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				FALSE111_tree = (object)adaptor.Create(FALSE111);
				adaptor.AddChild(root_0, FALSE111_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:149:5: compare
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(149, 5);
				PushFollow(Follow._compare_in_boolvar1229);
				compare112=compare();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare112.Tree);

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
			TraceOut("boolvar", 36);
			LeaveRule("boolvar", 36);
			Leave_boolvar();
			if (state.backtracking > 0) { Memoize(input, 36, boolvar_StartIndex); }
		}
		DebugLocation(149, 11);
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
	// MathLang.g:151:1: ifstatement : IF OPEN_BRACE boolexpression CLOSE_BRACE ( block | statement ) ( ELSE ( block | statement ) )* ;
	[GrammarRule("ifstatement")]
	private MathLangParser.ifstatement_return ifstatement()
	{
		Enter_ifstatement();
		EnterRule("ifstatement", 37);
		TraceIn("ifstatement", 37);
		MathLangParser.ifstatement_return retval = new MathLangParser.ifstatement_return();
		retval.Start = (IToken)input.LT(1);
		int ifstatement_StartIndex = input.Index;
		object root_0 = null;

		IToken IF113=null;
		IToken OPEN_BRACE114=null;
		IToken CLOSE_BRACE116=null;
		IToken ELSE119=null;
		MathLangParser.boolexpression_return boolexpression115 = default(MathLangParser.boolexpression_return);
		MathLangParser.block_return block117 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement118 = default(MathLangParser.statement_return);
		MathLangParser.block_return block120 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement121 = default(MathLangParser.statement_return);

		object IF113_tree=null;
		object OPEN_BRACE114_tree=null;
		object CLOSE_BRACE116_tree=null;
		object ELSE119_tree=null;

		try { DebugEnterRule(GrammarFileName, "ifstatement");
		DebugLocation(151, 106);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 37)) { return retval; }
			// MathLang.g:151:12: ( IF OPEN_BRACE boolexpression CLOSE_BRACE ( block | statement ) ( ELSE ( block | statement ) )* )
			DebugEnterAlt(1);
			// MathLang.g:151:14: IF OPEN_BRACE boolexpression CLOSE_BRACE ( block | statement ) ( ELSE ( block | statement ) )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(151, 16);
			IF113=(IToken)Match(input,IF,Follow._IF_in_ifstatement1238); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			IF113_tree = (object)adaptor.Create(IF113);
			root_0 = (object)adaptor.BecomeRoot(IF113_tree, root_0);
			}
			DebugLocation(151, 28);
			OPEN_BRACE114=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_ifstatement1241); if (state.failed) return retval;
			DebugLocation(151, 30);
			PushFollow(Follow._boolexpression_in_ifstatement1244);
			boolexpression115=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression115.Tree);
			DebugLocation(151, 56);
			CLOSE_BRACE116=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_ifstatement1246); if (state.failed) return retval;
			DebugLocation(151, 58);
			// MathLang.g:151:58: ( block | statement )
			int alt26=2;
			try { DebugEnterSubRule(26);
			try { DebugEnterDecision(26, decisionCanBacktrack[26]);
			int LA26_0 = input.LA(1);

			if ((LA26_0==68))
			{
				alt26=1;
			}
			else if ((LA26_0==IF||LA26_0==FOR||(LA26_0>=RETURN && LA26_0<=DO)||(LA26_0>=ID && LA26_0<=TYPE)||LA26_0==KNEW))
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
				// MathLang.g:151:59: block
				{
				DebugLocation(151, 59);
				PushFollow(Follow._block_in_ifstatement1250);
				block117=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block117.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:151:67: statement
				{
				DebugLocation(151, 67);
				PushFollow(Follow._statement_in_ifstatement1254);
				statement118=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement118.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(26); }

			DebugLocation(151, 78);
			// MathLang.g:151:78: ( ELSE ( block | statement ) )*
			try { DebugEnterSubRule(28);
			while (true)
			{
				int alt28=2;
				try { DebugEnterDecision(28, decisionCanBacktrack[28]);
				int LA28_0 = input.LA(1);

				if ((LA28_0==ELSE))
				{
					int LA28_1 = input.LA(2);

					if ((EvaluatePredicate(synpred50_MathLang_fragment)))
					{
						alt28=1;
					}


				}


				} finally { DebugExitDecision(28); }
				switch ( alt28 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:151:79: ELSE ( block | statement )
					{
					DebugLocation(151, 83);
					ELSE119=(IToken)Match(input,ELSE,Follow._ELSE_in_ifstatement1258); if (state.failed) return retval;
					DebugLocation(151, 85);
					// MathLang.g:151:85: ( block | statement )
					int alt27=2;
					try { DebugEnterSubRule(27);
					try { DebugEnterDecision(27, decisionCanBacktrack[27]);
					int LA27_0 = input.LA(1);

					if ((LA27_0==68))
					{
						alt27=1;
					}
					else if ((LA27_0==IF||LA27_0==FOR||(LA27_0>=RETURN && LA27_0<=DO)||(LA27_0>=ID && LA27_0<=TYPE)||LA27_0==KNEW))
					{
						alt27=2;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 27, 0, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
					} finally { DebugExitDecision(27); }
					switch (alt27)
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:151:86: block
						{
						DebugLocation(151, 86);
						PushFollow(Follow._block_in_ifstatement1262);
						block120=block();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block120.Tree);

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// MathLang.g:151:94: statement
						{
						DebugLocation(151, 94);
						PushFollow(Follow._statement_in_ifstatement1266);
						statement121=statement();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement121.Tree);

						}
						break;

					}
					} finally { DebugExitSubRule(27); }


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
			TraceOut("ifstatement", 37);
			LeaveRule("ifstatement", 37);
			Leave_ifstatement();
			if (state.backtracking > 0) { Memoize(input, 37, ifstatement_StartIndex); }
		}
		DebugLocation(151, 106);
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
	// MathLang.g:152:1: whilestatement : WHILE OPEN_BRACE boolexpression CLOSE_BRACE ( block | statement ) ;
	[GrammarRule("whilestatement")]
	private MathLangParser.whilestatement_return whilestatement()
	{
		Enter_whilestatement();
		EnterRule("whilestatement", 38);
		TraceIn("whilestatement", 38);
		MathLangParser.whilestatement_return retval = new MathLangParser.whilestatement_return();
		retval.Start = (IToken)input.LT(1);
		int whilestatement_StartIndex = input.Index;
		object root_0 = null;

		IToken WHILE122=null;
		IToken OPEN_BRACE123=null;
		IToken CLOSE_BRACE125=null;
		MathLangParser.boolexpression_return boolexpression124 = default(MathLangParser.boolexpression_return);
		MathLangParser.block_return block126 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement127 = default(MathLangParser.statement_return);

		object WHILE122_tree=null;
		object OPEN_BRACE123_tree=null;
		object CLOSE_BRACE125_tree=null;

		try { DebugEnterRule(GrammarFileName, "whilestatement");
		DebugLocation(152, 82);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 38)) { return retval; }
			// MathLang.g:152:15: ( WHILE OPEN_BRACE boolexpression CLOSE_BRACE ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:152:17: WHILE OPEN_BRACE boolexpression CLOSE_BRACE ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(152, 22);
			WHILE122=(IToken)Match(input,WHILE,Follow._WHILE_in_whilestatement1276); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			WHILE122_tree = (object)adaptor.Create(WHILE122);
			root_0 = (object)adaptor.BecomeRoot(WHILE122_tree, root_0);
			}
			DebugLocation(152, 34);
			OPEN_BRACE123=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_whilestatement1279); if (state.failed) return retval;
			DebugLocation(152, 36);
			PushFollow(Follow._boolexpression_in_whilestatement1282);
			boolexpression124=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression124.Tree);
			DebugLocation(152, 62);
			CLOSE_BRACE125=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_whilestatement1284); if (state.failed) return retval;
			DebugLocation(152, 64);
			// MathLang.g:152:64: ( block | statement )
			int alt29=2;
			try { DebugEnterSubRule(29);
			try { DebugEnterDecision(29, decisionCanBacktrack[29]);
			int LA29_0 = input.LA(1);

			if ((LA29_0==68))
			{
				alt29=1;
			}
			else if ((LA29_0==IF||LA29_0==FOR||(LA29_0>=RETURN && LA29_0<=DO)||(LA29_0>=ID && LA29_0<=TYPE)||LA29_0==KNEW))
			{
				alt29=2;
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
				// MathLang.g:152:65: block
				{
				DebugLocation(152, 65);
				PushFollow(Follow._block_in_whilestatement1288);
				block126=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block126.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:152:73: statement
				{
				DebugLocation(152, 73);
				PushFollow(Follow._statement_in_whilestatement1292);
				statement127=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement127.Tree);

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
			TraceOut("whilestatement", 38);
			LeaveRule("whilestatement", 38);
			Leave_whilestatement();
			if (state.backtracking > 0) { Memoize(input, 38, whilestatement_StartIndex); }
		}
		DebugLocation(152, 82);
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
	// MathLang.g:153:1: forstatement : FOR OPEN_BRACE longdeclarationbody ';' boolexpression ';' assignmentbody CLOSE_BRACE ( block | statement ) ;
	[GrammarRule("forstatement")]
	private MathLangParser.forstatement_return forstatement()
	{
		Enter_forstatement();
		EnterRule("forstatement", 39);
		TraceIn("forstatement", 39);
		MathLangParser.forstatement_return retval = new MathLangParser.forstatement_return();
		retval.Start = (IToken)input.LT(1);
		int forstatement_StartIndex = input.Index;
		object root_0 = null;

		IToken FOR128=null;
		IToken OPEN_BRACE129=null;
		IToken char_literal131=null;
		IToken char_literal133=null;
		IToken CLOSE_BRACE135=null;
		MathLangParser.longdeclarationbody_return longdeclarationbody130 = default(MathLangParser.longdeclarationbody_return);
		MathLangParser.boolexpression_return boolexpression132 = default(MathLangParser.boolexpression_return);
		MathLangParser.assignmentbody_return assignmentbody134 = default(MathLangParser.assignmentbody_return);
		MathLangParser.block_return block136 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement137 = default(MathLangParser.statement_return);

		object FOR128_tree=null;
		object OPEN_BRACE129_tree=null;
		object char_literal131_tree=null;
		object char_literal133_tree=null;
		object CLOSE_BRACE135_tree=null;

		try { DebugEnterRule(GrammarFileName, "forstatement");
		DebugLocation(153, 123);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 39)) { return retval; }
			// MathLang.g:153:13: ( FOR OPEN_BRACE longdeclarationbody ';' boolexpression ';' assignmentbody CLOSE_BRACE ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:153:15: FOR OPEN_BRACE longdeclarationbody ';' boolexpression ';' assignmentbody CLOSE_BRACE ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(153, 18);
			FOR128=(IToken)Match(input,FOR,Follow._FOR_in_forstatement1299); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			FOR128_tree = (object)adaptor.Create(FOR128);
			root_0 = (object)adaptor.BecomeRoot(FOR128_tree, root_0);
			}
			DebugLocation(153, 30);
			OPEN_BRACE129=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_forstatement1302); if (state.failed) return retval;
			DebugLocation(153, 32);
			PushFollow(Follow._longdeclarationbody_in_forstatement1305);
			longdeclarationbody130=longdeclarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclarationbody130.Tree);
			DebugLocation(153, 55);
			char_literal131=(IToken)Match(input,70,Follow._70_in_forstatement1307); if (state.failed) return retval;
			DebugLocation(153, 57);
			PushFollow(Follow._boolexpression_in_forstatement1310);
			boolexpression132=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression132.Tree);
			DebugLocation(153, 75);
			char_literal133=(IToken)Match(input,70,Follow._70_in_forstatement1312); if (state.failed) return retval;
			DebugLocation(153, 77);
			PushFollow(Follow._assignmentbody_in_forstatement1315);
			assignmentbody134=assignmentbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentbody134.Tree);
			DebugLocation(153, 103);
			CLOSE_BRACE135=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_forstatement1317); if (state.failed) return retval;
			DebugLocation(153, 105);
			// MathLang.g:153:105: ( block | statement )
			int alt30=2;
			try { DebugEnterSubRule(30);
			try { DebugEnterDecision(30, decisionCanBacktrack[30]);
			int LA30_0 = input.LA(1);

			if ((LA30_0==68))
			{
				alt30=1;
			}
			else if ((LA30_0==IF||LA30_0==FOR||(LA30_0>=RETURN && LA30_0<=DO)||(LA30_0>=ID && LA30_0<=TYPE)||LA30_0==KNEW))
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
				// MathLang.g:153:106: block
				{
				DebugLocation(153, 106);
				PushFollow(Follow._block_in_forstatement1321);
				block136=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block136.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:153:114: statement
				{
				DebugLocation(153, 114);
				PushFollow(Follow._statement_in_forstatement1325);
				statement137=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement137.Tree);

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
			TraceOut("forstatement", 39);
			LeaveRule("forstatement", 39);
			Leave_forstatement();
			if (state.backtracking > 0) { Memoize(input, 39, forstatement_StartIndex); }
		}
		DebugLocation(153, 123);
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
	// MathLang.g:154:1: returnstatement : RETURN expression ';' ;
	[GrammarRule("returnstatement")]
	private MathLangParser.returnstatement_return returnstatement()
	{
		Enter_returnstatement();
		EnterRule("returnstatement", 40);
		TraceIn("returnstatement", 40);
		MathLangParser.returnstatement_return retval = new MathLangParser.returnstatement_return();
		retval.Start = (IToken)input.LT(1);
		int returnstatement_StartIndex = input.Index;
		object root_0 = null;

		IToken RETURN138=null;
		IToken char_literal140=null;
		MathLangParser.expression_return expression139 = default(MathLangParser.expression_return);

		object RETURN138_tree=null;
		object char_literal140_tree=null;

		try { DebugEnterRule(GrammarFileName, "returnstatement");
		DebugLocation(154, 41);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 40)) { return retval; }
			// MathLang.g:154:16: ( RETURN expression ';' )
			DebugEnterAlt(1);
			// MathLang.g:154:18: RETURN expression ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(154, 24);
			RETURN138=(IToken)Match(input,RETURN,Follow._RETURN_in_returnstatement1332); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			RETURN138_tree = (object)adaptor.Create(RETURN138);
			root_0 = (object)adaptor.BecomeRoot(RETURN138_tree, root_0);
			}
			DebugLocation(154, 26);
			PushFollow(Follow._expression_in_returnstatement1335);
			expression139=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression139.Tree);
			DebugLocation(154, 40);
			char_literal140=(IToken)Match(input,70,Follow._70_in_returnstatement1337); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("returnstatement", 40);
			LeaveRule("returnstatement", 40);
			Leave_returnstatement();
			if (state.backtracking > 0) { Memoize(input, 40, returnstatement_StartIndex); }
		}
		DebugLocation(154, 41);
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
	// MathLang.g:155:1: dowhilestatement : DO ( block | statement ) WHILE OPEN_BRACE boolexpression CLOSE_BRACE ';' ;
	[GrammarRule("dowhilestatement")]
	private MathLangParser.dowhilestatement_return dowhilestatement()
	{
		Enter_dowhilestatement();
		EnterRule("dowhilestatement", 41);
		TraceIn("dowhilestatement", 41);
		MathLangParser.dowhilestatement_return retval = new MathLangParser.dowhilestatement_return();
		retval.Start = (IToken)input.LT(1);
		int dowhilestatement_StartIndex = input.Index;
		object root_0 = null;

		IToken DO141=null;
		IToken WHILE144=null;
		IToken OPEN_BRACE145=null;
		IToken CLOSE_BRACE147=null;
		IToken char_literal148=null;
		MathLangParser.block_return block142 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement143 = default(MathLangParser.statement_return);
		MathLangParser.boolexpression_return boolexpression146 = default(MathLangParser.boolexpression_return);

		object DO141_tree=null;
		object WHILE144_tree=null;
		object OPEN_BRACE145_tree=null;
		object CLOSE_BRACE147_tree=null;
		object char_literal148_tree=null;

		try { DebugEnterRule(GrammarFileName, "dowhilestatement");
		DebugLocation(155, 94);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 41)) { return retval; }
			// MathLang.g:155:17: ( DO ( block | statement ) WHILE OPEN_BRACE boolexpression CLOSE_BRACE ';' )
			DebugEnterAlt(1);
			// MathLang.g:155:19: DO ( block | statement ) WHILE OPEN_BRACE boolexpression CLOSE_BRACE ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(155, 21);
			DO141=(IToken)Match(input,DO,Follow._DO_in_dowhilestatement1345); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			DO141_tree = (object)adaptor.Create(DO141);
			root_0 = (object)adaptor.BecomeRoot(DO141_tree, root_0);
			}
			DebugLocation(155, 23);
			// MathLang.g:155:23: ( block | statement )
			int alt31=2;
			try { DebugEnterSubRule(31);
			try { DebugEnterDecision(31, decisionCanBacktrack[31]);
			int LA31_0 = input.LA(1);

			if ((LA31_0==68))
			{
				alt31=1;
			}
			else if ((LA31_0==IF||LA31_0==FOR||(LA31_0>=RETURN && LA31_0<=DO)||(LA31_0>=ID && LA31_0<=TYPE)||LA31_0==KNEW))
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
				// MathLang.g:155:24: block
				{
				DebugLocation(155, 24);
				PushFollow(Follow._block_in_dowhilestatement1349);
				block142=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block142.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:155:32: statement
				{
				DebugLocation(155, 32);
				PushFollow(Follow._statement_in_dowhilestatement1353);
				statement143=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement143.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(31); }

			DebugLocation(155, 48);
			WHILE144=(IToken)Match(input,WHILE,Follow._WHILE_in_dowhilestatement1356); if (state.failed) return retval;
			DebugLocation(155, 60);
			OPEN_BRACE145=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_dowhilestatement1359); if (state.failed) return retval;
			DebugLocation(155, 62);
			PushFollow(Follow._boolexpression_in_dowhilestatement1362);
			boolexpression146=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression146.Tree);
			DebugLocation(155, 88);
			CLOSE_BRACE147=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_dowhilestatement1364); if (state.failed) return retval;
			DebugLocation(155, 93);
			char_literal148=(IToken)Match(input,70,Follow._70_in_dowhilestatement1367); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("dowhilestatement", 41);
			LeaveRule("dowhilestatement", 41);
			Leave_dowhilestatement();
			if (state.backtracking > 0) { Memoize(input, 41, dowhilestatement_StartIndex); }
		}
		DebugLocation(155, 94);
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
	// MathLang.g:157:1: funcdeclaration : MODIFIER any_type ID ( OPEN_BRACE ( paramsdeclaration )? CLOSE_BRACE ) block -> ^( FUNCDECLARATION ID ^( RETURN_TYPE any_type ) ( paramsdeclaration )? block ) ;
	[GrammarRule("funcdeclaration")]
	private MathLangParser.funcdeclaration_return funcdeclaration()
	{
		Enter_funcdeclaration();
		EnterRule("funcdeclaration", 42);
		TraceIn("funcdeclaration", 42);
		MathLangParser.funcdeclaration_return retval = new MathLangParser.funcdeclaration_return();
		retval.Start = (IToken)input.LT(1);
		int funcdeclaration_StartIndex = input.Index;
		object root_0 = null;

		IToken MODIFIER149=null;
		IToken ID151=null;
		IToken OPEN_BRACE152=null;
		IToken CLOSE_BRACE154=null;
		MathLangParser.any_type_return any_type150 = default(MathLangParser.any_type_return);
		MathLangParser.paramsdeclaration_return paramsdeclaration153 = default(MathLangParser.paramsdeclaration_return);
		MathLangParser.block_return block155 = default(MathLangParser.block_return);

		object MODIFIER149_tree=null;
		object ID151_tree=null;
		object OPEN_BRACE152_tree=null;
		object CLOSE_BRACE154_tree=null;
		RewriteRuleITokenStream stream_MODIFIER=new RewriteRuleITokenStream(adaptor,"token MODIFIER");
		RewriteRuleITokenStream stream_OPEN_BRACE=new RewriteRuleITokenStream(adaptor,"token OPEN_BRACE");
		RewriteRuleITokenStream stream_CLOSE_BRACE=new RewriteRuleITokenStream(adaptor,"token CLOSE_BRACE");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleSubtreeStream stream_any_type=new RewriteRuleSubtreeStream(adaptor,"rule any_type");
		RewriteRuleSubtreeStream stream_paramsdeclaration=new RewriteRuleSubtreeStream(adaptor,"rule paramsdeclaration");
		RewriteRuleSubtreeStream stream_block=new RewriteRuleSubtreeStream(adaptor,"rule block");
		try { DebugEnterRule(GrammarFileName, "funcdeclaration");
		DebugLocation(157, 191);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 42)) { return retval; }
			// MathLang.g:157:16: ( MODIFIER any_type ID ( OPEN_BRACE ( paramsdeclaration )? CLOSE_BRACE ) block -> ^( FUNCDECLARATION ID ^( RETURN_TYPE any_type ) ( paramsdeclaration )? block ) )
			DebugEnterAlt(1);
			// MathLang.g:157:18: MODIFIER any_type ID ( OPEN_BRACE ( paramsdeclaration )? CLOSE_BRACE ) block
			{
			DebugLocation(157, 18);
			MODIFIER149=(IToken)Match(input,MODIFIER,Follow._MODIFIER_in_funcdeclaration1376); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_MODIFIER.Add(MODIFIER149);

			DebugLocation(157, 27);
			PushFollow(Follow._any_type_in_funcdeclaration1378);
			any_type150=any_type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_any_type.Add(any_type150.Tree);
			DebugLocation(157, 38);
			ID151=(IToken)Match(input,ID,Follow._ID_in_funcdeclaration1380); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID151);

			DebugLocation(157, 40);
			// MathLang.g:157:40: ( OPEN_BRACE ( paramsdeclaration )? CLOSE_BRACE )
			DebugEnterAlt(1);
			// MathLang.g:157:42: OPEN_BRACE ( paramsdeclaration )? CLOSE_BRACE
			{
			DebugLocation(157, 52);
			OPEN_BRACE152=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_funcdeclaration1385); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OPEN_BRACE.Add(OPEN_BRACE152);

			DebugLocation(157, 54);
			// MathLang.g:157:54: ( paramsdeclaration )?
			int alt32=2;
			try { DebugEnterSubRule(32);
			try { DebugEnterDecision(32, decisionCanBacktrack[32]);
			int LA32_0 = input.LA(1);

			if ((LA32_0==TYPE))
			{
				alt32=1;
			}
			} finally { DebugExitDecision(32); }
			switch (alt32)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: paramsdeclaration
				{
				DebugLocation(157, 54);
				PushFollow(Follow._paramsdeclaration_in_funcdeclaration1388);
				paramsdeclaration153=paramsdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_paramsdeclaration.Add(paramsdeclaration153.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(32); }

			DebugLocation(157, 84);
			CLOSE_BRACE154=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_funcdeclaration1391); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CLOSE_BRACE.Add(CLOSE_BRACE154);


			}

			DebugLocation(157, 88);
			PushFollow(Follow._block_in_funcdeclaration1396);
			block155=block();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_block.Add(block155.Tree);


			{
			// AST REWRITE
			// elements: paramsdeclaration, ID, block, any_type
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 157:94: -> ^( FUNCDECLARATION ID ^( RETURN_TYPE any_type ) ( paramsdeclaration )? block )
			{
				DebugLocation(157, 97);
				// MathLang.g:157:97: ^( FUNCDECLARATION ID ^( RETURN_TYPE any_type ) ( paramsdeclaration )? block )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(157, 99);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNCDECLARATION, "FUNCDECLARATION"), root_1);

				DebugLocation(157, 115);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(157, 118);
				// MathLang.g:157:118: ^( RETURN_TYPE any_type )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(157, 120);
				root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(RETURN_TYPE, "RETURN_TYPE"), root_2);

				DebugLocation(157, 132);
				adaptor.AddChild(root_2, stream_any_type.NextTree());

				adaptor.AddChild(root_1, root_2);
				}
				DebugLocation(157, 154);
				// MathLang.g:157:154: ( paramsdeclaration )?
				if ( stream_paramsdeclaration.HasNext )
				{
					DebugLocation(157, 154);
					adaptor.AddChild(root_1, stream_paramsdeclaration.NextTree());

				}
				stream_paramsdeclaration.Reset();
				DebugLocation(157, 186);
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
			TraceOut("funcdeclaration", 42);
			LeaveRule("funcdeclaration", 42);
			Leave_funcdeclaration();
			if (state.backtracking > 0) { Memoize(input, 42, funcdeclaration_StartIndex); }
		}
		DebugLocation(157, 191);
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
	// MathLang.g:158:1: paramsdeclaration : ( declarationbody ( ',' declarationbody )* ) -> ^( PARAMETERS ( declarationbody )* ) ;
	[GrammarRule("paramsdeclaration")]
	private MathLangParser.paramsdeclaration_return paramsdeclaration()
	{
		Enter_paramsdeclaration();
		EnterRule("paramsdeclaration", 43);
		TraceIn("paramsdeclaration", 43);
		MathLangParser.paramsdeclaration_return retval = new MathLangParser.paramsdeclaration_return();
		retval.Start = (IToken)input.LT(1);
		int paramsdeclaration_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal157=null;
		MathLangParser.declarationbody_return declarationbody156 = default(MathLangParser.declarationbody_return);
		MathLangParser.declarationbody_return declarationbody158 = default(MathLangParser.declarationbody_return);

		object char_literal157_tree=null;
		RewriteRuleITokenStream stream_71=new RewriteRuleITokenStream(adaptor,"token 71");
		RewriteRuleSubtreeStream stream_declarationbody=new RewriteRuleSubtreeStream(adaptor,"rule declarationbody");
		try { DebugEnterRule(GrammarFileName, "paramsdeclaration");
		DebugLocation(158, 102);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 43)) { return retval; }
			// MathLang.g:158:18: ( ( declarationbody ( ',' declarationbody )* ) -> ^( PARAMETERS ( declarationbody )* ) )
			DebugEnterAlt(1);
			// MathLang.g:158:20: ( declarationbody ( ',' declarationbody )* )
			{
			DebugLocation(158, 20);
			// MathLang.g:158:20: ( declarationbody ( ',' declarationbody )* )
			DebugEnterAlt(1);
			// MathLang.g:158:22: declarationbody ( ',' declarationbody )*
			{
			DebugLocation(158, 22);
			PushFollow(Follow._declarationbody_in_paramsdeclaration1429);
			declarationbody156=declarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declarationbody.Add(declarationbody156.Tree);
			DebugLocation(158, 38);
			// MathLang.g:158:38: ( ',' declarationbody )*
			try { DebugEnterSubRule(33);
			while (true)
			{
				int alt33=2;
				try { DebugEnterDecision(33, decisionCanBacktrack[33]);
				int LA33_0 = input.LA(1);

				if ((LA33_0==71))
				{
					alt33=1;
				}


				} finally { DebugExitDecision(33); }
				switch ( alt33 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:158:40: ',' declarationbody
					{
					DebugLocation(158, 43);
					char_literal157=(IToken)Match(input,71,Follow._71_in_paramsdeclaration1433); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_71.Add(char_literal157);

					DebugLocation(158, 45);
					PushFollow(Follow._declarationbody_in_paramsdeclaration1436);
					declarationbody158=declarationbody();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_declarationbody.Add(declarationbody158.Tree);

					}
					break;

				default:
					goto loop33;
				}
			}

			loop33:
				;

			} finally { DebugExitSubRule(33); }


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
			// 158:66: -> ^( PARAMETERS ( declarationbody )* )
			{
				DebugLocation(158, 69);
				// MathLang.g:158:69: ^( PARAMETERS ( declarationbody )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(158, 71);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_1);

				DebugLocation(158, 82);
				// MathLang.g:158:82: ( declarationbody )*
				while ( stream_declarationbody.HasNext )
				{
					DebugLocation(158, 84);
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
			TraceOut("paramsdeclaration", 43);
			LeaveRule("paramsdeclaration", 43);
			Leave_paramsdeclaration();
			if (state.backtracking > 0) { Memoize(input, 43, paramsdeclaration_StartIndex); }
		}
		DebugLocation(158, 102);
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
	// MathLang.g:160:1: funccallbody : extended_id OPEN_BRACE ( expressioncommalist )? CLOSE_BRACE -> ^( FUNC_CALL extended_id ( ^( PARAMETERS expressioncommalist ) )? ) ;
	[GrammarRule("funccallbody")]
	private MathLangParser.funccallbody_return funccallbody()
	{
		Enter_funccallbody();
		EnterRule("funccallbody", 44);
		TraceIn("funccallbody", 44);
		MathLangParser.funccallbody_return retval = new MathLangParser.funccallbody_return();
		retval.Start = (IToken)input.LT(1);
		int funccallbody_StartIndex = input.Index;
		object root_0 = null;

		IToken OPEN_BRACE160=null;
		IToken CLOSE_BRACE162=null;
		MathLangParser.extended_id_return extended_id159 = default(MathLangParser.extended_id_return);
		MathLangParser.expressioncommalist_return expressioncommalist161 = default(MathLangParser.expressioncommalist_return);

		object OPEN_BRACE160_tree=null;
		object CLOSE_BRACE162_tree=null;
		RewriteRuleITokenStream stream_OPEN_BRACE=new RewriteRuleITokenStream(adaptor,"token OPEN_BRACE");
		RewriteRuleITokenStream stream_CLOSE_BRACE=new RewriteRuleITokenStream(adaptor,"token CLOSE_BRACE");
		RewriteRuleSubtreeStream stream_extended_id=new RewriteRuleSubtreeStream(adaptor,"rule extended_id");
		RewriteRuleSubtreeStream stream_expressioncommalist=new RewriteRuleSubtreeStream(adaptor,"rule expressioncommalist");
		try { DebugEnterRule(GrammarFileName, "funccallbody");
		DebugLocation(160, 133);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 44)) { return retval; }
			// MathLang.g:160:13: ( extended_id OPEN_BRACE ( expressioncommalist )? CLOSE_BRACE -> ^( FUNC_CALL extended_id ( ^( PARAMETERS expressioncommalist ) )? ) )
			DebugEnterAlt(1);
			// MathLang.g:160:15: extended_id OPEN_BRACE ( expressioncommalist )? CLOSE_BRACE
			{
			DebugLocation(160, 26);
			PushFollow(Follow._extended_id_in_funccallbody1461);
			extended_id159=extended_id();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_extended_id.Add(extended_id159.Tree);
			DebugLocation(160, 28);
			OPEN_BRACE160=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_funccallbody1464); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OPEN_BRACE.Add(OPEN_BRACE160);

			DebugLocation(160, 39);
			// MathLang.g:160:39: ( expressioncommalist )?
			int alt34=2;
			try { DebugEnterSubRule(34);
			try { DebugEnterDecision(34, decisionCanBacktrack[34]);
			int LA34_0 = input.LA(1);

			if ((LA34_0==ID||(LA34_0>=NUMBER && LA34_0<=CHAR)||LA34_0==SUB||LA34_0==OPEN_BRACE||(LA34_0>=NOT && LA34_0<=KNEW)))
			{
				alt34=1;
			}
			} finally { DebugExitDecision(34); }
			switch (alt34)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: expressioncommalist
				{
				DebugLocation(160, 39);
				PushFollow(Follow._expressioncommalist_in_funccallbody1466);
				expressioncommalist161=expressioncommalist();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expressioncommalist.Add(expressioncommalist161.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(34); }

			DebugLocation(160, 60);
			CLOSE_BRACE162=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_funccallbody1469); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CLOSE_BRACE.Add(CLOSE_BRACE162);



			{
			// AST REWRITE
			// elements: extended_id, expressioncommalist
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 160:72: -> ^( FUNC_CALL extended_id ( ^( PARAMETERS expressioncommalist ) )? )
			{
				DebugLocation(160, 75);
				// MathLang.g:160:75: ^( FUNC_CALL extended_id ( ^( PARAMETERS expressioncommalist ) )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(160, 77);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_CALL, "FUNC_CALL"), root_1);

				DebugLocation(160, 87);
				adaptor.AddChild(root_1, stream_extended_id.NextTree());
				DebugLocation(160, 99);
				// MathLang.g:160:99: ( ^( PARAMETERS expressioncommalist ) )?
				if ( stream_expressioncommalist.HasNext )
				{
					DebugLocation(160, 99);
					// MathLang.g:160:99: ^( PARAMETERS expressioncommalist )
					{
					object root_2 = (object)adaptor.Nil();
					DebugLocation(160, 101);
					root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_2);

					DebugLocation(160, 112);
					adaptor.AddChild(root_2, stream_expressioncommalist.NextTree());

					adaptor.AddChild(root_1, root_2);
					}

				}
				stream_expressioncommalist.Reset();

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
			TraceOut("funccallbody", 44);
			LeaveRule("funccallbody", 44);
			Leave_funccallbody();
			if (state.backtracking > 0) { Memoize(input, 44, funccallbody_StartIndex); }
		}
		DebugLocation(160, 133);
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
	// MathLang.g:161:1: funccall : funccallbody ';' ;
	[GrammarRule("funccall")]
	private MathLangParser.funccall_return funccall()
	{
		Enter_funccall();
		EnterRule("funccall", 45);
		TraceIn("funccall", 45);
		MathLangParser.funccall_return retval = new MathLangParser.funccall_return();
		retval.Start = (IToken)input.LT(1);
		int funccall_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal164=null;
		MathLangParser.funccallbody_return funccallbody163 = default(MathLangParser.funccallbody_return);

		object char_literal164_tree=null;

		try { DebugEnterRule(GrammarFileName, "funccall");
		DebugLocation(161, 27);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 45)) { return retval; }
			// MathLang.g:161:9: ( funccallbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:161:11: funccallbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(161, 11);
			PushFollow(Follow._funccallbody_in_funccall1490);
			funccallbody163=funccallbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody163.Tree);
			DebugLocation(161, 27);
			char_literal164=(IToken)Match(input,70,Follow._70_in_funccall1492); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("funccall", 45);
			LeaveRule("funccall", 45);
			Leave_funccall();
			if (state.backtracking > 0) { Memoize(input, 45, funccall_StartIndex); }
		}
		DebugLocation(161, 27);
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
	// MathLang.g:162:1: expressioncommalist : expression ( ',' expression )* ;
	[GrammarRule("expressioncommalist")]
	private MathLangParser.expressioncommalist_return expressioncommalist()
	{
		Enter_expressioncommalist();
		EnterRule("expressioncommalist", 46);
		TraceIn("expressioncommalist", 46);
		MathLangParser.expressioncommalist_return retval = new MathLangParser.expressioncommalist_return();
		retval.Start = (IToken)input.LT(1);
		int expressioncommalist_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal166=null;
		MathLangParser.expression_return expression165 = default(MathLangParser.expression_return);
		MathLangParser.expression_return expression167 = default(MathLangParser.expression_return);

		object char_literal166_tree=null;

		try { DebugEnterRule(GrammarFileName, "expressioncommalist");
		DebugLocation(162, 51);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 46)) { return retval; }
			// MathLang.g:162:20: ( expression ( ',' expression )* )
			DebugEnterAlt(1);
			// MathLang.g:162:22: expression ( ',' expression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(162, 22);
			PushFollow(Follow._expression_in_expressioncommalist1499);
			expression165=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression165.Tree);
			DebugLocation(162, 33);
			// MathLang.g:162:33: ( ',' expression )*
			try { DebugEnterSubRule(35);
			while (true)
			{
				int alt35=2;
				try { DebugEnterDecision(35, decisionCanBacktrack[35]);
				int LA35_0 = input.LA(1);

				if ((LA35_0==71))
				{
					alt35=1;
				}


				} finally { DebugExitDecision(35); }
				switch ( alt35 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:162:35: ',' expression
					{
					DebugLocation(162, 38);
					char_literal166=(IToken)Match(input,71,Follow._71_in_expressioncommalist1503); if (state.failed) return retval;
					DebugLocation(162, 40);
					PushFollow(Follow._expression_in_expressioncommalist1506);
					expression167=expression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression167.Tree);

					}
					break;

				default:
					goto loop35;
				}
			}

			loop35:
				;

			} finally { DebugExitSubRule(35); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expressioncommalist", 46);
			LeaveRule("expressioncommalist", 46);
			Leave_expressioncommalist();
			if (state.backtracking > 0) { Memoize(input, 46, expressioncommalist_StartIndex); }
		}
		DebugLocation(162, 51);
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
	// MathLang.g:165:1: object_initializer : '{' expressioncommalist '}' -> ^( PARAMETERS expressioncommalist ) ;
	[GrammarRule("object_initializer")]
	private MathLangParser.object_initializer_return object_initializer()
	{
		Enter_object_initializer();
		EnterRule("object_initializer", 47);
		TraceIn("object_initializer", 47);
		MathLangParser.object_initializer_return retval = new MathLangParser.object_initializer_return();
		retval.Start = (IToken)input.LT(1);
		int object_initializer_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal168=null;
		IToken char_literal170=null;
		MathLangParser.expressioncommalist_return expressioncommalist169 = default(MathLangParser.expressioncommalist_return);

		object char_literal168_tree=null;
		object char_literal170_tree=null;
		RewriteRuleITokenStream stream_68=new RewriteRuleITokenStream(adaptor,"token 68");
		RewriteRuleITokenStream stream_69=new RewriteRuleITokenStream(adaptor,"token 69");
		RewriteRuleSubtreeStream stream_expressioncommalist=new RewriteRuleSubtreeStream(adaptor,"rule expressioncommalist");
		try { DebugEnterRule(GrammarFileName, "object_initializer");
		DebugLocation(165, 86);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 47)) { return retval; }
			// MathLang.g:165:19: ( '{' expressioncommalist '}' -> ^( PARAMETERS expressioncommalist ) )
			DebugEnterAlt(1);
			// MathLang.g:165:22: '{' expressioncommalist '}'
			{
			DebugLocation(165, 22);
			char_literal168=(IToken)Match(input,68,Follow._68_in_object_initializer1518); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_68.Add(char_literal168);

			DebugLocation(165, 26);
			PushFollow(Follow._expressioncommalist_in_object_initializer1520);
			expressioncommalist169=expressioncommalist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expressioncommalist.Add(expressioncommalist169.Tree);
			DebugLocation(165, 46);
			char_literal170=(IToken)Match(input,69,Follow._69_in_object_initializer1522); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_69.Add(char_literal170);



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
			// 165:50: -> ^( PARAMETERS expressioncommalist )
			{
				DebugLocation(165, 53);
				// MathLang.g:165:53: ^( PARAMETERS expressioncommalist )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(165, 55);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_1);

				DebugLocation(165, 66);
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
			TraceOut("object_initializer", 47);
			LeaveRule("object_initializer", 47);
			Leave_object_initializer();
			if (state.backtracking > 0) { Memoize(input, 47, object_initializer_StartIndex); }
		}
		DebugLocation(165, 86);
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
	// MathLang.g:166:1: newexpression : KNEW initializer ;
	[GrammarRule("newexpression")]
	private MathLangParser.newexpression_return newexpression()
	{
		Enter_newexpression();
		EnterRule("newexpression", 48);
		TraceIn("newexpression", 48);
		MathLangParser.newexpression_return retval = new MathLangParser.newexpression_return();
		retval.Start = (IToken)input.LT(1);
		int newexpression_StartIndex = input.Index;
		object root_0 = null;

		IToken KNEW171=null;
		MathLangParser.initializer_return initializer172 = default(MathLangParser.initializer_return);

		object KNEW171_tree=null;

		try { DebugEnterRule(GrammarFileName, "newexpression");
		DebugLocation(166, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 48)) { return retval; }
			// MathLang.g:166:14: ( KNEW initializer )
			DebugEnterAlt(1);
			// MathLang.g:166:16: KNEW initializer
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(166, 20);
			KNEW171=(IToken)Match(input,KNEW,Follow._KNEW_in_newexpression1537); if (state.failed) return retval;
			DebugLocation(166, 22);
			PushFollow(Follow._initializer_in_newexpression1540);
			initializer172=initializer();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, initializer172.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("newexpression", 48);
			LeaveRule("newexpression", 48);
			Leave_newexpression();
			if (state.backtracking > 0) { Memoize(input, 48, newexpression_StartIndex); }
		}
		DebugLocation(166, 32);
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
	// MathLang.g:167:1: initializer : ( simple_var_initializer | array_initializer ) ;
	[GrammarRule("initializer")]
	private MathLangParser.initializer_return initializer()
	{
		Enter_initializer();
		EnterRule("initializer", 49);
		TraceIn("initializer", 49);
		MathLangParser.initializer_return retval = new MathLangParser.initializer_return();
		retval.Start = (IToken)input.LT(1);
		int initializer_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.simple_var_initializer_return simple_var_initializer173 = default(MathLangParser.simple_var_initializer_return);
		MathLangParser.array_initializer_return array_initializer174 = default(MathLangParser.array_initializer_return);


		try { DebugEnterRule(GrammarFileName, "initializer");
		DebugLocation(167, 57);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 49)) { return retval; }
			// MathLang.g:167:12: ( ( simple_var_initializer | array_initializer ) )
			DebugEnterAlt(1);
			// MathLang.g:167:14: ( simple_var_initializer | array_initializer )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(167, 14);
			// MathLang.g:167:14: ( simple_var_initializer | array_initializer )
			int alt36=2;
			try { DebugEnterSubRule(36);
			try { DebugEnterDecision(36, decisionCanBacktrack[36]);
			int LA36_0 = input.LA(1);

			if ((LA36_0==TYPE))
			{
				int LA36_1 = input.LA(2);

				if ((LA36_1==OPEN_BRACE))
				{
					alt36=1;
				}
				else if ((LA36_1==ARRAY_DECLARATION_MARK||LA36_1==OPEN_SQUARE_BRACE))
				{
					alt36=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 36, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
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
				// MathLang.g:167:15: simple_var_initializer
				{
				DebugLocation(167, 15);
				PushFollow(Follow._simple_var_initializer_in_initializer1547);
				simple_var_initializer173=simple_var_initializer();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, simple_var_initializer173.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:167:40: array_initializer
				{
				DebugLocation(167, 40);
				PushFollow(Follow._array_initializer_in_initializer1551);
				array_initializer174=array_initializer();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, array_initializer174.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(36); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("initializer", 49);
			LeaveRule("initializer", 49);
			Leave_initializer();
			if (state.backtracking > 0) { Memoize(input, 49, initializer_StartIndex); }
		}
		DebugLocation(167, 57);
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
	// MathLang.g:168:1: simple_var_initializer : type OPEN_BRACE CLOSE_BRACE -> ^( NEWVAR type ) ;
	[GrammarRule("simple_var_initializer")]
	private MathLangParser.simple_var_initializer_return simple_var_initializer()
	{
		Enter_simple_var_initializer();
		EnterRule("simple_var_initializer", 50);
		TraceIn("simple_var_initializer", 50);
		MathLangParser.simple_var_initializer_return retval = new MathLangParser.simple_var_initializer_return();
		retval.Start = (IToken)input.LT(1);
		int simple_var_initializer_StartIndex = input.Index;
		object root_0 = null;

		IToken OPEN_BRACE176=null;
		IToken CLOSE_BRACE177=null;
		MathLangParser.type_return type175 = default(MathLangParser.type_return);

		object OPEN_BRACE176_tree=null;
		object CLOSE_BRACE177_tree=null;
		RewriteRuleITokenStream stream_OPEN_BRACE=new RewriteRuleITokenStream(adaptor,"token OPEN_BRACE");
		RewriteRuleITokenStream stream_CLOSE_BRACE=new RewriteRuleITokenStream(adaptor,"token CLOSE_BRACE");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "simple_var_initializer");
		DebugLocation(168, 69);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 50)) { return retval; }
			// MathLang.g:168:23: ( type OPEN_BRACE CLOSE_BRACE -> ^( NEWVAR type ) )
			DebugEnterAlt(1);
			// MathLang.g:168:25: type OPEN_BRACE CLOSE_BRACE
			{
			DebugLocation(168, 25);
			PushFollow(Follow._type_in_simple_var_initializer1558);
			type175=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type175.Tree);
			DebugLocation(168, 30);
			OPEN_BRACE176=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_simple_var_initializer1560); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OPEN_BRACE.Add(OPEN_BRACE176);

			DebugLocation(168, 41);
			CLOSE_BRACE177=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_simple_var_initializer1562); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CLOSE_BRACE.Add(CLOSE_BRACE177);



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
			// 168:53: -> ^( NEWVAR type )
			{
				DebugLocation(168, 56);
				// MathLang.g:168:56: ^( NEWVAR type )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(168, 58);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(NEWVAR, "NEWVAR"), root_1);

				DebugLocation(168, 65);
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
			TraceOut("simple_var_initializer", 50);
			LeaveRule("simple_var_initializer", 50);
			Leave_simple_var_initializer();
			if (state.backtracking > 0) { Memoize(input, 50, simple_var_initializer_StartIndex); }
		}
		DebugLocation(168, 69);
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
	// MathLang.g:169:1: array_initializer : type ( ( OPEN_SQUARE_BRACE number CLOSE_SQUARE_BRACE ) | ARRAY_DECLARATION_MARK ) ( object_initializer )? -> ^( ARRAY_INITIALIZER type ( number )? ( object_initializer )? ) ;
	[GrammarRule("array_initializer")]
	private MathLangParser.array_initializer_return array_initializer()
	{
		Enter_array_initializer();
		EnterRule("array_initializer", 51);
		TraceIn("array_initializer", 51);
		MathLangParser.array_initializer_return retval = new MathLangParser.array_initializer_return();
		retval.Start = (IToken)input.LT(1);
		int array_initializer_StartIndex = input.Index;
		object root_0 = null;

		IToken OPEN_SQUARE_BRACE179=null;
		IToken CLOSE_SQUARE_BRACE181=null;
		IToken ARRAY_DECLARATION_MARK182=null;
		MathLangParser.type_return type178 = default(MathLangParser.type_return);
		MathLangParser.number_return number180 = default(MathLangParser.number_return);
		MathLangParser.object_initializer_return object_initializer183 = default(MathLangParser.object_initializer_return);

		object OPEN_SQUARE_BRACE179_tree=null;
		object CLOSE_SQUARE_BRACE181_tree=null;
		object ARRAY_DECLARATION_MARK182_tree=null;
		RewriteRuleITokenStream stream_OPEN_SQUARE_BRACE=new RewriteRuleITokenStream(adaptor,"token OPEN_SQUARE_BRACE");
		RewriteRuleITokenStream stream_ARRAY_DECLARATION_MARK=new RewriteRuleITokenStream(adaptor,"token ARRAY_DECLARATION_MARK");
		RewriteRuleITokenStream stream_CLOSE_SQUARE_BRACE=new RewriteRuleITokenStream(adaptor,"token CLOSE_SQUARE_BRACE");
		RewriteRuleSubtreeStream stream_number=new RewriteRuleSubtreeStream(adaptor,"rule number");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		RewriteRuleSubtreeStream stream_object_initializer=new RewriteRuleSubtreeStream(adaptor,"rule object_initializer");
		try { DebugEnterRule(GrammarFileName, "array_initializer");
		DebugLocation(169, 173);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 51)) { return retval; }
			// MathLang.g:169:18: ( type ( ( OPEN_SQUARE_BRACE number CLOSE_SQUARE_BRACE ) | ARRAY_DECLARATION_MARK ) ( object_initializer )? -> ^( ARRAY_INITIALIZER type ( number )? ( object_initializer )? ) )
			DebugEnterAlt(1);
			// MathLang.g:169:20: type ( ( OPEN_SQUARE_BRACE number CLOSE_SQUARE_BRACE ) | ARRAY_DECLARATION_MARK ) ( object_initializer )?
			{
			DebugLocation(169, 20);
			PushFollow(Follow._type_in_array_initializer1576);
			type178=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type178.Tree);
			DebugLocation(169, 25);
			// MathLang.g:169:25: ( ( OPEN_SQUARE_BRACE number CLOSE_SQUARE_BRACE ) | ARRAY_DECLARATION_MARK )
			int alt37=2;
			try { DebugEnterSubRule(37);
			try { DebugEnterDecision(37, decisionCanBacktrack[37]);
			int LA37_0 = input.LA(1);

			if ((LA37_0==OPEN_SQUARE_BRACE))
			{
				alt37=1;
			}
			else if ((LA37_0==ARRAY_DECLARATION_MARK))
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
				// MathLang.g:169:26: ( OPEN_SQUARE_BRACE number CLOSE_SQUARE_BRACE )
				{
				DebugLocation(169, 26);
				// MathLang.g:169:26: ( OPEN_SQUARE_BRACE number CLOSE_SQUARE_BRACE )
				DebugEnterAlt(1);
				// MathLang.g:169:27: OPEN_SQUARE_BRACE number CLOSE_SQUARE_BRACE
				{
				DebugLocation(169, 27);
				OPEN_SQUARE_BRACE179=(IToken)Match(input,OPEN_SQUARE_BRACE,Follow._OPEN_SQUARE_BRACE_in_array_initializer1580); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_OPEN_SQUARE_BRACE.Add(OPEN_SQUARE_BRACE179);

				DebugLocation(169, 45);
				PushFollow(Follow._number_in_array_initializer1582);
				number180=number();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_number.Add(number180.Tree);
				DebugLocation(169, 52);
				CLOSE_SQUARE_BRACE181=(IToken)Match(input,CLOSE_SQUARE_BRACE,Follow._CLOSE_SQUARE_BRACE_in_array_initializer1584); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_CLOSE_SQUARE_BRACE.Add(CLOSE_SQUARE_BRACE181);


				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:169:74: ARRAY_DECLARATION_MARK
				{
				DebugLocation(169, 74);
				ARRAY_DECLARATION_MARK182=(IToken)Match(input,ARRAY_DECLARATION_MARK,Follow._ARRAY_DECLARATION_MARK_in_array_initializer1589); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ARRAY_DECLARATION_MARK.Add(ARRAY_DECLARATION_MARK182);


				}
				break;

			}
			} finally { DebugExitSubRule(37); }

			DebugLocation(169, 98);
			// MathLang.g:169:98: ( object_initializer )?
			int alt38=2;
			try { DebugEnterSubRule(38);
			try { DebugEnterDecision(38, decisionCanBacktrack[38]);
			int LA38_0 = input.LA(1);

			if ((LA38_0==68))
			{
				alt38=1;
			}
			} finally { DebugExitDecision(38); }
			switch (alt38)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: object_initializer
				{
				DebugLocation(169, 98);
				PushFollow(Follow._object_initializer_in_array_initializer1592);
				object_initializer183=object_initializer();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_object_initializer.Add(object_initializer183.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(38); }



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
			// 169:118: -> ^( ARRAY_INITIALIZER type ( number )? ( object_initializer )? )
			{
				DebugLocation(169, 121);
				// MathLang.g:169:121: ^( ARRAY_INITIALIZER type ( number )? ( object_initializer )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(169, 123);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAY_INITIALIZER, "ARRAY_INITIALIZER"), root_1);

				DebugLocation(169, 141);
				adaptor.AddChild(root_1, stream_type.NextTree());
				DebugLocation(169, 146);
				// MathLang.g:169:146: ( number )?
				if ( stream_number.HasNext )
				{
					DebugLocation(169, 146);
					adaptor.AddChild(root_1, stream_number.NextTree());

				}
				stream_number.Reset();
				DebugLocation(169, 154);
				// MathLang.g:169:154: ( object_initializer )?
				if ( stream_object_initializer.HasNext )
				{
					DebugLocation(169, 154);
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
			TraceOut("array_initializer", 51);
			LeaveRule("array_initializer", 51);
			Leave_array_initializer();
			if (state.backtracking > 0) { Memoize(input, 51, array_initializer_StartIndex); }
		}
		DebugLocation(169, 173);
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
	// MathLang.g:171:1: block : '{' statementlist '}' ;
	[GrammarRule("block")]
	private MathLangParser.block_return block()
	{
		Enter_block();
		EnterRule("block", 52);
		TraceIn("block", 52);
		MathLangParser.block_return retval = new MathLangParser.block_return();
		retval.Start = (IToken)input.LT(1);
		int block_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal184=null;
		IToken char_literal186=null;
		MathLangParser.statementlist_return statementlist185 = default(MathLangParser.statementlist_return);

		object char_literal184_tree=null;
		object char_literal186_tree=null;

		try { DebugEnterRule(GrammarFileName, "block");
		DebugLocation(171, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 52)) { return retval; }
			// MathLang.g:171:6: ( '{' statementlist '}' )
			DebugEnterAlt(1);
			// MathLang.g:171:8: '{' statementlist '}'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(171, 11);
			char_literal184=(IToken)Match(input,68,Follow._68_in_block1614); if (state.failed) return retval;
			DebugLocation(171, 13);
			PushFollow(Follow._statementlist_in_block1617);
			statementlist185=statementlist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementlist185.Tree);
			DebugLocation(171, 30);
			char_literal186=(IToken)Match(input,69,Follow._69_in_block1619); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("block", 52);
			LeaveRule("block", 52);
			Leave_block();
			if (state.backtracking > 0) { Memoize(input, 52, block_StartIndex); }
		}
		DebugLocation(171, 30);
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
	// MathLang.g:173:1: statementlist : ( statement )* -> ^( BLOCK ( statement )* ) ;
	[GrammarRule("statementlist")]
	private MathLangParser.statementlist_return statementlist()
	{
		Enter_statementlist();
		EnterRule("statementlist", 53);
		TraceIn("statementlist", 53);
		MathLangParser.statementlist_return retval = new MathLangParser.statementlist_return();
		retval.Start = (IToken)input.LT(1);
		int statementlist_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.statement_return statement187 = default(MathLangParser.statement_return);

		RewriteRuleSubtreeStream stream_statement=new RewriteRuleSubtreeStream(adaptor,"rule statement");
		try { DebugEnterRule(GrammarFileName, "statementlist");
		DebugLocation(173, 49);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 53)) { return retval; }
			// MathLang.g:173:14: ( ( statement )* -> ^( BLOCK ( statement )* ) )
			DebugEnterAlt(1);
			// MathLang.g:173:16: ( statement )*
			{
			DebugLocation(173, 16);
			// MathLang.g:173:16: ( statement )*
			try { DebugEnterSubRule(39);
			while (true)
			{
				int alt39=2;
				try { DebugEnterDecision(39, decisionCanBacktrack[39]);
				int LA39_0 = input.LA(1);

				if ((LA39_0==IF||LA39_0==FOR||(LA39_0>=RETURN && LA39_0<=DO)||(LA39_0>=ID && LA39_0<=TYPE)||LA39_0==KNEW))
				{
					alt39=1;
				}


				} finally { DebugExitDecision(39); }
				switch ( alt39 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: statement
					{
					DebugLocation(173, 16);
					PushFollow(Follow._statement_in_statementlist1627);
					statement187=statement();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_statement.Add(statement187.Tree);

					}
					break;

				default:
					goto loop39;
				}
			}

			loop39:
				;

			} finally { DebugExitSubRule(39); }



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
			// 173:27: -> ^( BLOCK ( statement )* )
			{
				DebugLocation(173, 30);
				// MathLang.g:173:30: ^( BLOCK ( statement )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(173, 32);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

				DebugLocation(173, 38);
				// MathLang.g:173:38: ( statement )*
				while ( stream_statement.HasNext )
				{
					DebugLocation(173, 38);
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
			TraceOut("statementlist", 53);
			LeaveRule("statementlist", 53);
			Leave_statementlist();
			if (state.backtracking > 0) { Memoize(input, 53, statementlist_StartIndex); }
		}
		DebugLocation(173, 49);
		} finally { DebugExitRule(GrammarFileName, "statementlist"); }
		return retval;

	}
	// $ANTLR end "statementlist"

	partial void Enter_synpred20_MathLang_fragment();
	partial void Leave_synpred20_MathLang_fragment();

	// $ANTLR start synpred20_MathLang
	public void synpred20_MathLang_fragment()
	{
		Enter_synpred20_MathLang_fragment();
		EnterRule("synpred20_MathLang_fragment", 73);
		TraceIn("synpred20_MathLang_fragment", 73);
		try
		{
			// MathLang.g:92:5: ( funccallbody )
			DebugEnterAlt(1);
			// MathLang.g:92:5: funccallbody
			{
			DebugLocation(92, 5);
			PushFollow(Follow._funccallbody_in_synpred20_MathLang630);
			funccallbody();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred20_MathLang_fragment", 73);
			LeaveRule("synpred20_MathLang_fragment", 73);
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
		EnterRule("synpred21_MathLang_fragment", 74);
		TraceIn("synpred21_MathLang_fragment", 74);
		try
		{
			// MathLang.g:93:5: ( boolexpression )
			DebugEnterAlt(1);
			// MathLang.g:93:5: boolexpression
			{
			DebugLocation(93, 5);
			PushFollow(Follow._boolexpression_in_synpred21_MathLang636);
			boolexpression();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred21_MathLang_fragment", 74);
			LeaveRule("synpred21_MathLang_fragment", 74);
			Leave_synpred21_MathLang_fragment();
		}
	}
	// $ANTLR end synpred21_MathLang

	partial void Enter_synpred36_MathLang_fragment();
	partial void Leave_synpred36_MathLang_fragment();

	// $ANTLR start synpred36_MathLang
	public void synpred36_MathLang_fragment()
	{
		Enter_synpred36_MathLang_fragment();
		EnterRule("synpred36_MathLang_fragment", 89);
		TraceIn("synpred36_MathLang_fragment", 89);
		try
		{
			// MathLang.g:134:16: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )
			DebugEnterAlt(1);
			// MathLang.g:134:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
			{
			DebugLocation(134, 16);
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

			DebugLocation(134, 53);
			PushFollow(Follow._add_in_synpred36_MathLang1039);
			add();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred36_MathLang_fragment", 89);
			LeaveRule("synpred36_MathLang_fragment", 89);
			Leave_synpred36_MathLang_fragment();
		}
	}
	// $ANTLR end synpred36_MathLang

	partial void Enter_synpred45_MathLang_fragment();
	partial void Leave_synpred45_MathLang_fragment();

	// $ANTLR start synpred45_MathLang
	public void synpred45_MathLang_fragment()
	{
		Enter_synpred45_MathLang_fragment();
		EnterRule("synpred45_MathLang_fragment", 98);
		TraceIn("synpred45_MathLang_fragment", 98);
		try
		{
			// MathLang.g:146:22: ( OPEN_BRACE boolterm CLOSE_BRACE )
			DebugEnterAlt(1);
			// MathLang.g:146:22: OPEN_BRACE boolterm CLOSE_BRACE
			{
			DebugLocation(146, 22);
			Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_synpred45_MathLang1199); if (state.failed) return;
			DebugLocation(146, 34);
			PushFollow(Follow._boolterm_in_synpred45_MathLang1202);
			boolterm();
			PopFollow();
			if (state.failed) return;
			DebugLocation(146, 43);
			Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_synpred45_MathLang1204); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred45_MathLang_fragment", 98);
			LeaveRule("synpred45_MathLang_fragment", 98);
			Leave_synpred45_MathLang_fragment();
		}
	}
	// $ANTLR end synpred45_MathLang

	partial void Enter_synpred50_MathLang_fragment();
	partial void Leave_synpred50_MathLang_fragment();

	// $ANTLR start synpred50_MathLang
	public void synpred50_MathLang_fragment()
	{
		Enter_synpred50_MathLang_fragment();
		EnterRule("synpred50_MathLang_fragment", 103);
		TraceIn("synpred50_MathLang_fragment", 103);
		try
		{
			// MathLang.g:151:79: ( ELSE ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:151:79: ELSE ( block | statement )
			{
			DebugLocation(151, 79);
			Match(input,ELSE,Follow._ELSE_in_synpred50_MathLang1258); if (state.failed) return;
			DebugLocation(151, 85);
			// MathLang.g:151:85: ( block | statement )
			int alt41=2;
			try { DebugEnterSubRule(41);
			try { DebugEnterDecision(41, decisionCanBacktrack[41]);
			int LA41_0 = input.LA(1);

			if ((LA41_0==68))
			{
				alt41=1;
			}
			else if ((LA41_0==IF||LA41_0==FOR||(LA41_0>=RETURN && LA41_0<=DO)||(LA41_0>=ID && LA41_0<=TYPE)||LA41_0==KNEW))
			{
				alt41=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				NoViableAltException nvae = new NoViableAltException("", 41, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(41); }
			switch (alt41)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:151:86: block
				{
				DebugLocation(151, 86);
				PushFollow(Follow._block_in_synpred50_MathLang1262);
				block();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:151:94: statement
				{
				DebugLocation(151, 94);
				PushFollow(Follow._statement_in_synpred50_MathLang1266);
				statement();
				PopFollow();
				if (state.failed) return;

				}
				break;

			}
			} finally { DebugExitSubRule(41); }


			}

		}
		finally
		{
			TraceOut("synpred50_MathLang_fragment", 103);
			LeaveRule("synpred50_MathLang_fragment", 103);
			Leave_synpred50_MathLang_fragment();
		}
	}
	// $ANTLR end synpred50_MathLang
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
	DFA5 dfa5;
	DFA8 dfa8;
	DFA16 dfa16;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa5 = new DFA5( this );
		dfa8 = new DFA8( this, SpecialStateTransition8 );
		dfa16 = new DFA16( this, SpecialStateTransition16 );
	}

	private class DFA5 : DFA
	{
		private const string DFA5_eotS =
			"\xD\xFFFF";
		private const string DFA5_eofS =
			"\xD\xFFFF";
		private const string DFA5_minS =
			"\x1\x7\x1\xFFFF\x1\x2A\x6\xFFFF\x1\x24\x2\xFFFF\x1\x2B";
		private const string DFA5_maxS =
			"\x1\x3F\x1\xFFFF\x1\x38\x6\xFFFF\x1\x24\x2\xFFFF\x1\x38";
		private const string DFA5_acceptS =
			"\x1\xFFFF\x1\x1\x1\xFFFF\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x1\x9\x1\xFFFF"+
			"\x1\x2\x1\x8\x1\xFFFF";
		private const string DFA5_specialS =
			"\xD\xFFFF}>";
		private static readonly string[] DFA5_transitionS =
			{
				"\x1\x3\x1\xFFFF\x1\x6\x1\xFFFF\x1\x7\x1\x4\x1\x5\x16\xFFFF\x1\x2\x1"+
				"\x1\x19\xFFFF\x1\x8",
				"",
				"\x1\x9\x1\xA\x1\xFFFF\x1\xA\xA\xFFFF\x1\xB",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\xC",
				"",
				"",
				"\x1\xA\x1\xFFFF\x1\xA\xA\xFFFF\x1\xB"
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

		public DFA5( BaseRecognizer recognizer )
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

		public override string Description { get { return "68:12: ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | returnstatement | funccall | newexpression )"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA8 : DFA
	{
		private const string DFA8_eotS =
			"\xC\xFFFF";
		private const string DFA8_eofS =
			"\xC\xFFFF";
		private const string DFA8_minS =
			"\x1\x24\x1\xFFFF\x1\x0\x1\xFFFF\x1\x0\x2\xFFFF\x3\x0\x2\xFFFF";
		private const string DFA8_maxS =
			"\x1\x3F\x1\xFFFF\x1\x0\x1\xFFFF\x1\x0\x2\xFFFF\x3\x0\x2\xFFFF";
		private const string DFA8_acceptS =
			"\x1\xFFFF\x1\x1\x1\xFFFF\x1\x3\x6\xFFFF\x1\x2\x1\x4";
		private const string DFA8_specialS =
			"\x2\xFFFF\x1\x0\x1\xFFFF\x1\x1\x2\xFFFF\x1\x2\x1\x3\x1\x4\x2\xFFFF}>";
		private static readonly string[] DFA8_transitionS =
			{
				"\x1\x2\x3\xFFFF\x1\x8\x1\x9\x5\xFFFF\x1\x7\x8\xFFFF\x1\x4\x3\xFFFF"+
				"\x3\x3\x1\x1",
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

		private static readonly short[] DFA8_eot = DFA.UnpackEncodedString(DFA8_eotS);
		private static readonly short[] DFA8_eof = DFA.UnpackEncodedString(DFA8_eofS);
		private static readonly char[] DFA8_min = DFA.UnpackEncodedStringToUnsignedChars(DFA8_minS);
		private static readonly char[] DFA8_max = DFA.UnpackEncodedStringToUnsignedChars(DFA8_maxS);
		private static readonly short[] DFA8_accept = DFA.UnpackEncodedString(DFA8_acceptS);
		private static readonly short[] DFA8_special = DFA.UnpackEncodedString(DFA8_specialS);
		private static readonly short[][] DFA8_transition;

		static DFA8()
		{
			int numStates = DFA8_transitionS.Length;
			DFA8_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA8_transition[i] = DFA.UnpackEncodedString(DFA8_transitionS[i]);
			}
		}

		public DFA8( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 8;
			this.eot = DFA8_eot;
			this.eof = DFA8_eof;
			this.min = DFA8_min;
			this.max = DFA8_max;
			this.accept = DFA8_accept;
			this.special = DFA8_special;
			this.transition = DFA8_transition;
		}

		public override string Description { get { return "90:1: expression : ( newexpression | funccallbody | boolexpression | mathexpression );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition8(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA8_2 = input.LA(1);


				int index8_2 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred20_MathLang_fragment)) ) {s = 10;}

				else if ( (EvaluatePredicate(synpred21_MathLang_fragment)) ) {s = 3;}

				else if ( (true) ) {s = 11;}


				input.Seek(index8_2);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA8_4 = input.LA(1);


				int index8_4 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred21_MathLang_fragment)) ) {s = 3;}

				else if ( (true) ) {s = 11;}


				input.Seek(index8_4);
				if ( s>=0 ) return s;
				break;
			case 2:
				int LA8_7 = input.LA(1);


				int index8_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred21_MathLang_fragment)) ) {s = 3;}

				else if ( (true) ) {s = 11;}


				input.Seek(index8_7);
				if ( s>=0 ) return s;
				break;
			case 3:
				int LA8_8 = input.LA(1);


				int index8_8 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred21_MathLang_fragment)) ) {s = 3;}

				else if ( (true) ) {s = 11;}


				input.Seek(index8_8);
				if ( s>=0 ) return s;
				break;
			case 4:
				int LA8_9 = input.LA(1);


				int index8_9 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred21_MathLang_fragment)) ) {s = 3;}

				else if ( (true) ) {s = 11;}


				input.Seek(index8_9);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 8, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA16 : DFA
	{
		private const string DFA16_eotS =
			"\xA\xFFFF";
		private const string DFA16_eofS =
			"\x1\x2\x9\xFFFF";
		private const string DFA16_minS =
			"\x1\x32\x1\x0\x8\xFFFF";
		private const string DFA16_maxS =
			"\x1\x47\x1\x0\x8\xFFFF";
		private const string DFA16_acceptS =
			"\x2\xFFFF\x1\x2\x1\xFFFF\x1\x1\x5\xFFFF";
		private const string DFA16_specialS =
			"\x1\xFFFF\x1\x0\x8\xFFFF}>";
		private static readonly string[] DFA16_transitionS =
			{
				"\x2\x4\x2\x1\x2\x4\x1\xFFFF\x3\x2\x9\xFFFF\x3\x2",
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

		private static readonly short[] DFA16_eot = DFA.UnpackEncodedString(DFA16_eotS);
		private static readonly short[] DFA16_eof = DFA.UnpackEncodedString(DFA16_eofS);
		private static readonly char[] DFA16_min = DFA.UnpackEncodedStringToUnsignedChars(DFA16_minS);
		private static readonly char[] DFA16_max = DFA.UnpackEncodedStringToUnsignedChars(DFA16_maxS);
		private static readonly short[] DFA16_accept = DFA.UnpackEncodedString(DFA16_acceptS);
		private static readonly short[] DFA16_special = DFA.UnpackEncodedString(DFA16_specialS);
		private static readonly short[][] DFA16_transition;

		static DFA16()
		{
			int numStates = DFA16_transitionS.Length;
			DFA16_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA16_transition[i] = DFA.UnpackEncodedString(DFA16_transitionS[i]);
			}
		}

		public DFA16( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 16;
			this.eot = DFA16_eot;
			this.eof = DFA16_eof;
			this.min = DFA16_min;
			this.max = DFA16_max;
			this.accept = DFA16_accept;
			this.special = DFA16_special;
			this.transition = DFA16_transition;
		}

		public override string Description { get { return "134:14: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition16(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA16_1 = input.LA(1);


				int index16_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred36_MathLang_fragment)) ) {s = 4;}

				else if ( (true) ) {s = 2;}


				input.Seek(index16_1);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 16, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}

	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _class_list_in_execute379 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_execute381 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MODIFIER_in_class_declaration400 = new BitSet(new ulong[]{0x80000000UL});
		public static readonly BitSet _CLASS_WORD_in_class_declaration402 = new BitSet(new ulong[]{0x1000000000UL});
		public static readonly BitSet _ID_in_class_declaration404 = new BitSet(new ulong[]{0x0UL,0x10UL});
		public static readonly BitSet _class_block_in_class_declaration406 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _68_in_class_block424 = new BitSet(new ulong[]{0x800000000UL,0x20UL});
		public static readonly BitSet _static_func_or_var_declaration_in_class_block427 = new BitSet(new ulong[]{0x800000000UL,0x20UL});
		public static readonly BitSet _69_in_class_block430 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _static_declaration_in_static_func_or_var_declaration449 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funcdeclaration_in_static_func_or_var_declaration453 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _class_declaration_in_class_list462 = new BitSet(new ulong[]{0x800000002UL});
		public static readonly BitSet _funcdeclaration_in_func_list472 = new BitSet(new ulong[]{0x800000002UL});
		public static readonly BitSet _declaration_in_statement493 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assignment_in_statement499 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ifstatement_in_statement504 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _whilestatement_in_statement509 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _dowhilestatement_in_statement514 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _forstatement_in_statement519 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _returnstatement_in_statement524 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccall_in_statement529 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _newexpression_in_statement534 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_type548 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_array_type555 = new BitSet(new ulong[]{0x4000000000UL});
		public static readonly BitSet _ARRAY_DECLARATION_MARK_in_array_type557 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_any_type564 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_type_in_any_type568 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _VOID_in_any_type572 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NUMBER_in_number580 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _extended_id_in_number586 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_number592 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CHAR_in_number598 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrayelement_in_number604 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _term_in_mathexpression610 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _newexpression_in_expression624 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_expression630 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolexpression_in_expression636 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathexpression_in_expression642 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_extended_id655 = new BitSet(new ulong[]{0x40000000002UL});
		public static readonly BitSet _DOT_in_extended_id658 = new BitSet(new ulong[]{0x1000000000UL});
		public static readonly BitSet _ID_in_extended_id661 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _extended_id_in_arrayelement680 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _OPEN_SQUARE_BRACE_in_arrayelement682 = new BitSet(new ulong[]{0x31000000000UL});
		public static readonly BitSet _number_in_arrayelement684 = new BitSet(new ulong[]{0x100000000000UL});
		public static readonly BitSet _CLOSE_SQUARE_BRACE_in_arrayelement686 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MODIFIER_in_static_declaration704 = new BitSet(new ulong[]{0x2000000000UL});
		public static readonly BitSet _declaration_in_static_declaration706 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_declaration721 = new BitSet(new ulong[]{0x1000000000UL});
		public static readonly BitSet _d_list_in_declaration723 = new BitSet(new ulong[]{0x0UL,0x40UL});
		public static readonly BitSet _70_in_declaration725 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _d_in_d_list743 = new BitSet(new ulong[]{0x2UL,0x80UL});
		public static readonly BitSet _71_in_d_list746 = new BitSet(new ulong[]{0x1000000000UL});
		public static readonly BitSet _d_in_d_list749 = new BitSet(new ulong[]{0x2UL,0x80UL});
		public static readonly BitSet _declarationbody_d_in_d773 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _longdeclarationbody_d_in_d777 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_declarationbody_d791 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_longdeclarationbody_d818 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _ASSIGN_in_longdeclarationbody_d820 = new BitSet(new ulong[]{0xF100831000000000UL});
		public static readonly BitSet _expression_in_longdeclarationbody_d822 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_declarationbody855 = new BitSet(new ulong[]{0x1000000000UL});
		public static readonly BitSet _ID_in_declarationbody857 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_type_in_declarationbody878 = new BitSet(new ulong[]{0x1000000000UL});
		public static readonly BitSet _ID_in_declarationbody880 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_longdeclarationbody904 = new BitSet(new ulong[]{0x1000000000UL});
		public static readonly BitSet _ID_in_longdeclarationbody906 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _ASSIGN_in_longdeclarationbody908 = new BitSet(new ulong[]{0xF100831000000000UL});
		public static readonly BitSet _expression_in_longdeclarationbody910 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_type_in_longdeclarationbody934 = new BitSet(new ulong[]{0x1000000000UL});
		public static readonly BitSet _ID_in_longdeclarationbody936 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _ASSIGN_in_longdeclarationbody938 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _newexpression_in_longdeclarationbody940 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mul_in_add966 = new BitSet(new ulong[]{0xC00000000002UL});
		public static readonly BitSet _set_in_add970 = new BitSet(new ulong[]{0x7100831000000000UL});
		public static readonly BitSet _mul_in_add979 = new BitSet(new ulong[]{0xC00000000002UL});
		public static readonly BitSet _group_in_mul988 = new BitSet(new ulong[]{0x3000000000002UL});
		public static readonly BitSet _set_in_mul992 = new BitSet(new ulong[]{0x7100831000000000UL});
		public static readonly BitSet _group_in_mul1001 = new BitSet(new ulong[]{0x3000000000002UL});
		public static readonly BitSet _add_in_compare1009 = new BitSet(new ulong[]{0xFC000000000002UL});
		public static readonly BitSet _set_in_compare1013 = new BitSet(new ulong[]{0x7100831000000000UL});
		public static readonly BitSet _add_in_compare1039 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _add_in_term1050 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _SUB_in_group1057 = new BitSet(new ulong[]{0x100000000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_group1062 = new BitSet(new ulong[]{0xF100831000000000UL});
		public static readonly BitSet _term_in_group1065 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_group1067 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _number_in_group1072 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assignmentbody_in_assignment1079 = new BitSet(new ulong[]{0x0UL,0x40UL});
		public static readonly BitSet _70_in_assignment1081 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _extended_id_in_assignmentbody1089 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _ASSIGN_in_assignmentbody1091 = new BitSet(new ulong[]{0xF100831000000000UL});
		public static readonly BitSet _expression_in_assignmentbody1093 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrayelement_in_assignmentbody1112 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _ASSIGN_in_assignmentbody1114 = new BitSet(new ulong[]{0xF100831000000000UL});
		public static readonly BitSet _expression_in_assignmentbody1116 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolterm_in_boolexpression1134 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _or_in_boolterm1141 = new BitSet(new ulong[]{0x30000000000002UL});
		public static readonly BitSet _set_in_boolterm1145 = new BitSet(new ulong[]{0x7100831000000000UL});
		public static readonly BitSet _or_in_boolterm1154 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _and_in_or1163 = new BitSet(new ulong[]{0x400000000000002UL});
		public static readonly BitSet _OR_in_or1166 = new BitSet(new ulong[]{0x7100831000000000UL});
		public static readonly BitSet _and_in_or1169 = new BitSet(new ulong[]{0x400000000000002UL});
		public static readonly BitSet _boolgroup_in_and1177 = new BitSet(new ulong[]{0x800000000000002UL});
		public static readonly BitSet _AND_in_and1180 = new BitSet(new ulong[]{0x7100831000000000UL});
		public static readonly BitSet _boolgroup_in_and1183 = new BitSet(new ulong[]{0x800000000000002UL});
		public static readonly BitSet _NOT_in_boolgroup1192 = new BitSet(new ulong[]{0x7100831000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_boolgroup1199 = new BitSet(new ulong[]{0x7100831000000000UL});
		public static readonly BitSet _boolterm_in_boolgroup1202 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_boolgroup1204 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolvar_in_boolgroup1209 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TRUE_in_boolvar1217 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FALSE_in_boolvar1223 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _compare_in_boolvar1229 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_ifstatement1238 = new BitSet(new ulong[]{0x100000000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_ifstatement1241 = new BitSet(new ulong[]{0x7100831000000000UL});
		public static readonly BitSet _boolexpression_in_ifstatement1244 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_ifstatement1246 = new BitSet(new ulong[]{0x8000033000003A80UL,0x10UL});
		public static readonly BitSet _block_in_ifstatement1250 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement1254 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _ELSE_in_ifstatement1258 = new BitSet(new ulong[]{0x8000033000003A80UL,0x10UL});
		public static readonly BitSet _block_in_ifstatement1262 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement1266 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _WHILE_in_whilestatement1276 = new BitSet(new ulong[]{0x100000000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_whilestatement1279 = new BitSet(new ulong[]{0x7100831000000000UL});
		public static readonly BitSet _boolexpression_in_whilestatement1282 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_whilestatement1284 = new BitSet(new ulong[]{0x8000033000003A80UL,0x10UL});
		public static readonly BitSet _block_in_whilestatement1288 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_whilestatement1292 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_forstatement1299 = new BitSet(new ulong[]{0x100000000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_forstatement1302 = new BitSet(new ulong[]{0x2000000000UL});
		public static readonly BitSet _longdeclarationbody_in_forstatement1305 = new BitSet(new ulong[]{0x0UL,0x40UL});
		public static readonly BitSet _70_in_forstatement1307 = new BitSet(new ulong[]{0x7100831000000000UL});
		public static readonly BitSet _boolexpression_in_forstatement1310 = new BitSet(new ulong[]{0x0UL,0x40UL});
		public static readonly BitSet _70_in_forstatement1312 = new BitSet(new ulong[]{0x31000000000UL});
		public static readonly BitSet _assignmentbody_in_forstatement1315 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_forstatement1317 = new BitSet(new ulong[]{0x8000033000003A80UL,0x10UL});
		public static readonly BitSet _block_in_forstatement1321 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_forstatement1325 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _RETURN_in_returnstatement1332 = new BitSet(new ulong[]{0xF100831000000000UL});
		public static readonly BitSet _expression_in_returnstatement1335 = new BitSet(new ulong[]{0x0UL,0x40UL});
		public static readonly BitSet _70_in_returnstatement1337 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DO_in_dowhilestatement1345 = new BitSet(new ulong[]{0x8000033000003A80UL,0x10UL});
		public static readonly BitSet _block_in_dowhilestatement1349 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _statement_in_dowhilestatement1353 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _WHILE_in_dowhilestatement1356 = new BitSet(new ulong[]{0x100000000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_dowhilestatement1359 = new BitSet(new ulong[]{0x7100831000000000UL});
		public static readonly BitSet _boolexpression_in_dowhilestatement1362 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_dowhilestatement1364 = new BitSet(new ulong[]{0x0UL,0x40UL});
		public static readonly BitSet _70_in_dowhilestatement1367 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MODIFIER_in_funcdeclaration1376 = new BitSet(new ulong[]{0xA000000000UL});
		public static readonly BitSet _any_type_in_funcdeclaration1378 = new BitSet(new ulong[]{0x1000000000UL});
		public static readonly BitSet _ID_in_funcdeclaration1380 = new BitSet(new ulong[]{0x100000000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_funcdeclaration1385 = new BitSet(new ulong[]{0x200002000000000UL});
		public static readonly BitSet _paramsdeclaration_in_funcdeclaration1388 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_funcdeclaration1391 = new BitSet(new ulong[]{0x0UL,0x10UL});
		public static readonly BitSet _block_in_funcdeclaration1396 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declarationbody_in_paramsdeclaration1429 = new BitSet(new ulong[]{0x2UL,0x80UL});
		public static readonly BitSet _71_in_paramsdeclaration1433 = new BitSet(new ulong[]{0x2000000000UL});
		public static readonly BitSet _declarationbody_in_paramsdeclaration1436 = new BitSet(new ulong[]{0x2UL,0x80UL});
		public static readonly BitSet _extended_id_in_funccallbody1461 = new BitSet(new ulong[]{0x100000000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_funccallbody1464 = new BitSet(new ulong[]{0xF300831000000000UL});
		public static readonly BitSet _expressioncommalist_in_funccallbody1466 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_funccallbody1469 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_funccall1490 = new BitSet(new ulong[]{0x0UL,0x40UL});
		public static readonly BitSet _70_in_funccall1492 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_expressioncommalist1499 = new BitSet(new ulong[]{0x2UL,0x80UL});
		public static readonly BitSet _71_in_expressioncommalist1503 = new BitSet(new ulong[]{0xF100831000000000UL});
		public static readonly BitSet _expression_in_expressioncommalist1506 = new BitSet(new ulong[]{0x2UL,0x80UL});
		public static readonly BitSet _68_in_object_initializer1518 = new BitSet(new ulong[]{0xF100831000000000UL});
		public static readonly BitSet _expressioncommalist_in_object_initializer1520 = new BitSet(new ulong[]{0x0UL,0x20UL});
		public static readonly BitSet _69_in_object_initializer1522 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _KNEW_in_newexpression1537 = new BitSet(new ulong[]{0x2000000000UL});
		public static readonly BitSet _initializer_in_newexpression1540 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _simple_var_initializer_in_initializer1547 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_initializer_in_initializer1551 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_simple_var_initializer1558 = new BitSet(new ulong[]{0x100000000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_simple_var_initializer1560 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_simple_var_initializer1562 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_array_initializer1576 = new BitSet(new ulong[]{0x84000000000UL});
		public static readonly BitSet _OPEN_SQUARE_BRACE_in_array_initializer1580 = new BitSet(new ulong[]{0x31000000000UL});
		public static readonly BitSet _number_in_array_initializer1582 = new BitSet(new ulong[]{0x100000000000UL});
		public static readonly BitSet _CLOSE_SQUARE_BRACE_in_array_initializer1584 = new BitSet(new ulong[]{0x2UL,0x10UL});
		public static readonly BitSet _ARRAY_DECLARATION_MARK_in_array_initializer1589 = new BitSet(new ulong[]{0x2UL,0x10UL});
		public static readonly BitSet _object_initializer_in_array_initializer1592 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _68_in_block1614 = new BitSet(new ulong[]{0x8000033000003A80UL,0x30UL});
		public static readonly BitSet _statementlist_in_block1617 = new BitSet(new ulong[]{0x0UL,0x20UL});
		public static readonly BitSet _69_in_block1619 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_statementlist1627 = new BitSet(new ulong[]{0x8000033000003A82UL,0x10UL});
		public static readonly BitSet _funccallbody_in_synpred20_MathLang630 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolexpression_in_synpred21_MathLang636 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_synpred36_MathLang1013 = new BitSet(new ulong[]{0x7100831000000000UL});
		public static readonly BitSet _add_in_synpred36_MathLang1039 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _OPEN_BRACE_in_synpred45_MathLang1199 = new BitSet(new ulong[]{0x7100831000000000UL});
		public static readonly BitSet _boolterm_in_synpred45_MathLang1202 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_synpred45_MathLang1204 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ELSE_in_synpred50_MathLang1258 = new BitSet(new ulong[]{0x8000033000003A80UL,0x10UL});
		public static readonly BitSet _block_in_synpred50_MathLang1262 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_synpred50_MathLang1266 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  MathLang 

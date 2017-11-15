// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-11-14 21:28:16

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "UNKNOWN", "PRINT", "INPUT", "IF", "ELSE", "FOR", "FUNCTION", "RETURN", "WHILE", "DO", "BLOCK", "PROGRAM", "PARAMS", "VARDECLARATION", "FUNCDECLARATION", "ARRAYDECLARATION", "VARASSIGNMENT", "ARRAYELEMENTASSIGNMENT", "ARRAYELEMENT", "NEWVAR", "ARRAY_INITIALIZER", "OBJECT_INITIALIZER", "FUNC_CALL", "RETURN_TYPE", "PARAMETERS", "STATIC_DECLARATION", "CLASSBLOCK", "CLASS_WORD", "CALL", "VARS", "MULT_DECL", "MULT_ARRAY_DECL", "MODIFIER", "ID", "TYPE", "ARRAY_DECLARATION_MARK", "VOID", "NUMBER", "CHAR", "DOT", "OPEN_SQUARE_BRACE", "CLOSE_SQUARE_BRACE", "ASSIGN", "ADD", "SUB", "MUL", "DIV", "GREQ", "LSEQ", "NEQ", "EQ", "GR", "LS", "OPEN_BRACE", "CLOSE_BRACE", "OR", "AND", "NOT", "TRUE", "FALSE", "KNEW", "CONSOLE_WORD", "WS", "SL_COMMENT", "ML_COMMENT", "'{'", "'}'", "';'", "','"
	};
	public const int EOF=-1;
	public const int T__69=69;
	public const int T__70=70;
	public const int T__71=71;
	public const int T__72=72;
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
	public const int MULT_ARRAY_DECL=35;
	public const int MODIFIER=36;
	public const int ID=37;
	public const int TYPE=38;
	public const int ARRAY_DECLARATION_MARK=39;
	public const int VOID=40;
	public const int NUMBER=41;
	public const int CHAR=42;
	public const int DOT=43;
	public const int OPEN_SQUARE_BRACE=44;
	public const int CLOSE_SQUARE_BRACE=45;
	public const int ASSIGN=46;
	public const int ADD=47;
	public const int SUB=48;
	public const int MUL=49;
	public const int DIV=50;
	public const int GREQ=51;
	public const int LSEQ=52;
	public const int NEQ=53;
	public const int EQ=54;
	public const int GR=55;
	public const int LS=56;
	public const int OPEN_BRACE=57;
	public const int CLOSE_BRACE=58;
	public const int OR=59;
	public const int AND=60;
	public const int NOT=61;
	public const int TRUE=62;
	public const int FALSE=63;
	public const int KNEW=64;
	public const int CONSOLE_WORD=65;
	public const int WS=66;
	public const int SL_COMMENT=67;
	public const int ML_COMMENT=68;

	// delegates
	// delegators

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, false, false, false, true, false, false, 
				false, false, false, false, false, false, false, false, true, false, 
				false, false, false, false, false, false, true, false, false, false, 
				true, false, false, false, false, false, false, false, false, false, 
				false, false, , false, 
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
		this.state.ruleMemo = new System.Collections.Generic.Dictionary<int, int>[123+1];

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
	// MathLang.g:55:8: public execute : class_list EOF -> ^( PROGRAM class_list ) ;
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
		DebugLocation(55, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 1)) { return retval; }
			// MathLang.g:55:15: ( class_list EOF -> ^( PROGRAM class_list ) )
			DebugEnterAlt(1);
			// MathLang.g:56:2: class_list EOF
			{
			DebugLocation(56, 2);
			PushFollow(Follow._class_list_in_execute384);
			class_list1=class_list();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_class_list.Add(class_list1.Tree);
			DebugLocation(56, 16);
			EOF2=(IToken)Match(input,EOF,Follow._EOF_in_execute386); if (state.failed) return retval; 
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
			// 56:19: -> ^( PROGRAM class_list )
			{
				DebugLocation(56, 22);
				// MathLang.g:56:22: ^( PROGRAM class_list )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(56, 24);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROGRAM, "PROGRAM"), root_1);

				DebugLocation(56, 32);
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
		DebugLocation(57, 0);
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
	// MathLang.g:59:1: class_declaration : MODIFIER CLASS_WORD ID class_block -> ^( CLASS_WORD ID class_block ) ;
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
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_MODIFIER=new RewriteRuleITokenStream(adaptor,"token MODIFIER");
		RewriteRuleSubtreeStream stream_class_block=new RewriteRuleSubtreeStream(adaptor,"rule class_block");
		try { DebugEnterRule(GrammarFileName, "class_declaration");
		DebugLocation(59, 86);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 2)) { return retval; }
			// MathLang.g:59:18: ( MODIFIER CLASS_WORD ID class_block -> ^( CLASS_WORD ID class_block ) )
			DebugEnterAlt(1);
			// MathLang.g:59:20: MODIFIER CLASS_WORD ID class_block
			{
			DebugLocation(59, 20);
			MODIFIER3=(IToken)Match(input,MODIFIER,Follow._MODIFIER_in_class_declaration405); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_MODIFIER.Add(MODIFIER3);

			DebugLocation(59, 29);
			CLASS_WORD4=(IToken)Match(input,CLASS_WORD,Follow._CLASS_WORD_in_class_declaration407); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CLASS_WORD.Add(CLASS_WORD4);

			DebugLocation(59, 40);
			ID5=(IToken)Match(input,ID,Follow._ID_in_class_declaration409); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID5);

			DebugLocation(59, 43);
			PushFollow(Follow._class_block_in_class_declaration411);
			class_block6=class_block();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_class_block.Add(class_block6.Tree);


			{
			// AST REWRITE
			// elements: class_block, ID, CLASS_WORD
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 59:55: -> ^( CLASS_WORD ID class_block )
			{
				DebugLocation(59, 58);
				// MathLang.g:59:58: ^( CLASS_WORD ID class_block )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(59, 60);
				root_1 = (object)adaptor.BecomeRoot(stream_CLASS_WORD.NextNode(), root_1);

				DebugLocation(59, 71);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(59, 74);
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
		DebugLocation(59, 86);
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
	// MathLang.g:61:1: class_block : '{' ( static_func_or_var_declaration )* '}' -> ^( CLASSBLOCK ( static_func_or_var_declaration )* ) ;
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
		RewriteRuleITokenStream stream_69=new RewriteRuleITokenStream(adaptor,"token 69");
		RewriteRuleITokenStream stream_70=new RewriteRuleITokenStream(adaptor,"token 70");
		RewriteRuleSubtreeStream stream_static_func_or_var_declaration=new RewriteRuleSubtreeStream(adaptor,"rule static_func_or_var_declaration");
		try { DebugEnterRule(GrammarFileName, "class_block");
		DebugLocation(61, 105);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 3)) { return retval; }
			// MathLang.g:61:12: ( '{' ( static_func_or_var_declaration )* '}' -> ^( CLASSBLOCK ( static_func_or_var_declaration )* ) )
			DebugEnterAlt(1);
			// MathLang.g:61:14: '{' ( static_func_or_var_declaration )* '}'
			{
			DebugLocation(61, 17);
			char_literal7=(IToken)Match(input,69,Follow._69_in_class_block429); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_69.Add(char_literal7);

			DebugLocation(61, 19);
			// MathLang.g:61:19: ( static_func_or_var_declaration )*
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
					DebugLocation(61, 19);
					PushFollow(Follow._static_func_or_var_declaration_in_class_block432);
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

			DebugLocation(61, 54);
			char_literal9=(IToken)Match(input,70,Follow._70_in_class_block435); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_70.Add(char_literal9);



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
			// 61:56: -> ^( CLASSBLOCK ( static_func_or_var_declaration )* )
			{
				DebugLocation(61, 59);
				// MathLang.g:61:59: ^( CLASSBLOCK ( static_func_or_var_declaration )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(61, 61);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(CLASSBLOCK, "CLASSBLOCK"), root_1);

				DebugLocation(61, 72);
				// MathLang.g:61:72: ( static_func_or_var_declaration )*
				while ( stream_static_func_or_var_declaration.HasNext )
				{
					DebugLocation(61, 72);
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
		DebugLocation(61, 105);
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
	// MathLang.g:63:1: static_func_or_var_declaration : ( static_declaration | funcdeclaration );
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
		DebugLocation(63, 69);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 4)) { return retval; }
			// MathLang.g:63:31: ( static_declaration | funcdeclaration )
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
						int LA2_4 = input.LA(4);

						if ((LA2_4==ID))
						{
							int LA2_6 = input.LA(5);

							if ((LA2_6==ASSIGN||(LA2_6>=71 && LA2_6<=72)))
							{
								alt2=1;
							}
							else if ((LA2_6==OPEN_BRACE))
							{
								alt2=2;
							}
							else
							{
								if (state.backtracking>0) {state.failed=true; return retval;}
								NoViableAltException nvae = new NoViableAltException("", 2, 6, input);

								DebugRecognitionException(nvae);
								throw nvae;
							}
						}
						else
						{
							if (state.backtracking>0) {state.failed=true; return retval;}
							NoViableAltException nvae = new NoViableAltException("", 2, 4, input);

							DebugRecognitionException(nvae);
							throw nvae;
						}
					}
					else if ((LA2_2==ID))
					{
						int LA2_5 = input.LA(4);

						if ((LA2_5==ASSIGN||(LA2_5>=71 && LA2_5<=72)))
						{
							alt2=1;
						}
						else if ((LA2_5==OPEN_BRACE))
						{
							alt2=2;
						}
						else
						{
							if (state.backtracking>0) {state.failed=true; return retval;}
							NoViableAltException nvae = new NoViableAltException("", 2, 5, input);

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
				// MathLang.g:63:33: static_declaration
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(63, 33);
				PushFollow(Follow._static_declaration_in_static_func_or_var_declaration454);
				static_declaration10=static_declaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, static_declaration10.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:63:54: funcdeclaration
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(63, 54);
				PushFollow(Follow._funcdeclaration_in_static_func_or_var_declaration458);
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
		DebugLocation(63, 69);
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
	// MathLang.g:65:1: class_list : ( class_declaration )* ;
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
		DebugLocation(65, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 5)) { return retval; }
			// MathLang.g:65:11: ( ( class_declaration )* )
			DebugEnterAlt(1);
			// MathLang.g:65:14: ( class_declaration )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(65, 14);
			// MathLang.g:65:14: ( class_declaration )*
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
					DebugLocation(65, 14);
					PushFollow(Follow._class_declaration_in_class_list467);
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
		DebugLocation(65, 32);
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
	// MathLang.g:67:1: func_list : ( funcdeclaration )* -> ^( PROGRAM ( funcdeclaration )* ) ;
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
		DebugLocation(67, 61);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 6)) { return retval; }
			// MathLang.g:67:11: ( ( funcdeclaration )* -> ^( PROGRAM ( funcdeclaration )* ) )
			DebugEnterAlt(1);
			// MathLang.g:67:13: ( funcdeclaration )*
			{
			DebugLocation(67, 13);
			// MathLang.g:67:13: ( funcdeclaration )*
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
					DebugLocation(67, 13);
					PushFollow(Follow._funcdeclaration_in_func_list477);
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
			// 67:30: -> ^( PROGRAM ( funcdeclaration )* )
			{
				DebugLocation(67, 33);
				// MathLang.g:67:33: ^( PROGRAM ( funcdeclaration )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(67, 35);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROGRAM, "PROGRAM"), root_1);

				DebugLocation(67, 43);
				// MathLang.g:67:43: ( funcdeclaration )*
				while ( stream_funcdeclaration.HasNext )
				{
					DebugLocation(67, 43);
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
		DebugLocation(67, 61);
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
	// MathLang.g:69:1: statement : ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | returnstatement | funccall | newexpression ) ;
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
		DebugLocation(69, 4);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 7)) { return retval; }
			// MathLang.g:69:10: ( ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | returnstatement | funccall | newexpression ) )
			DebugEnterAlt(1);
			// MathLang.g:69:12: ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | returnstatement | funccall | newexpression )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(69, 12);
			// MathLang.g:69:12: ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | returnstatement | funccall | newexpression )
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
				// MathLang.g:69:14: declaration
				{
				DebugLocation(69, 14);
				PushFollow(Follow._declaration_in_statement498);
				declaration14=declaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, declaration14.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:70:4: assignment
				{
				DebugLocation(70, 4);
				PushFollow(Follow._assignment_in_statement504);
				assignment15=assignment();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment15.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:71:4: ifstatement
				{
				DebugLocation(71, 4);
				PushFollow(Follow._ifstatement_in_statement509);
				ifstatement16=ifstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ifstatement16.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:72:4: whilestatement
				{
				DebugLocation(72, 4);
				PushFollow(Follow._whilestatement_in_statement514);
				whilestatement17=whilestatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, whilestatement17.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:73:4: dowhilestatement
				{
				DebugLocation(73, 4);
				PushFollow(Follow._dowhilestatement_in_statement519);
				dowhilestatement18=dowhilestatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dowhilestatement18.Tree);

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// MathLang.g:74:4: forstatement
				{
				DebugLocation(74, 4);
				PushFollow(Follow._forstatement_in_statement524);
				forstatement19=forstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forstatement19.Tree);

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// MathLang.g:75:4: returnstatement
				{
				DebugLocation(75, 4);
				PushFollow(Follow._returnstatement_in_statement529);
				returnstatement20=returnstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, returnstatement20.Tree);

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// MathLang.g:76:4: funccall
				{
				DebugLocation(76, 4);
				PushFollow(Follow._funccall_in_statement534);
				funccall21=funccall();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccall21.Tree);

				}
				break;
			case 9:
				DebugEnterAlt(9);
				// MathLang.g:77:4: newexpression
				{
				DebugLocation(77, 4);
				PushFollow(Follow._newexpression_in_statement539);
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
		DebugLocation(79, 4);
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
	// MathLang.g:81:1: type : TYPE ;
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
		DebugLocation(81, 11);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 8)) { return retval; }
			// MathLang.g:81:5: ( TYPE )
			DebugEnterAlt(1);
			// MathLang.g:81:7: TYPE
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(81, 7);
			TYPE23=(IToken)Match(input,TYPE,Follow._TYPE_in_type553); if (state.failed) return retval;
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
		DebugLocation(81, 11);
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
	// MathLang.g:82:1: array_type : TYPE ARRAY_DECLARATION_MARK ;
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
		DebugLocation(82, 40);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 9)) { return retval; }
			// MathLang.g:82:11: ( TYPE ARRAY_DECLARATION_MARK )
			DebugEnterAlt(1);
			// MathLang.g:82:13: TYPE ARRAY_DECLARATION_MARK
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(82, 13);
			TYPE24=(IToken)Match(input,TYPE,Follow._TYPE_in_array_type560); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			TYPE24_tree = (object)adaptor.Create(TYPE24);
			adaptor.AddChild(root_0, TYPE24_tree);
			}
			DebugLocation(82, 40);
			ARRAY_DECLARATION_MARK25=(IToken)Match(input,ARRAY_DECLARATION_MARK,Follow._ARRAY_DECLARATION_MARK_in_array_type562); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(82, 40);
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
	// MathLang.g:83:1: any_type : ( type | array_type | VOID );
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
		DebugLocation(83, 34);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 10)) { return retval; }
			// MathLang.g:83:9: ( type | array_type | VOID )
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
				// MathLang.g:83:11: type
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(83, 11);
				PushFollow(Follow._type_in_any_type569);
				type26=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type26.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:83:18: array_type
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(83, 18);
				PushFollow(Follow._array_type_in_any_type573);
				array_type27=array_type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, array_type27.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:83:31: VOID
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(83, 31);
				VOID28=(IToken)Match(input,VOID,Follow._VOID_in_any_type577); if (state.failed) return retval;
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
		DebugLocation(83, 34);
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
	// MathLang.g:84:1: number : ( NUMBER | extended_id | funccallbody | CHAR | arrayelement );
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
		DebugLocation(84, 2);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 11)) { return retval; }
			// MathLang.g:84:8: ( NUMBER | extended_id | funccallbody | CHAR | arrayelement )
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
						case 70:
						case 71:
						case 72:
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
				case 70:
				case 71:
				case 72:
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
				// MathLang.g:84:11: NUMBER
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(84, 11);
				NUMBER29=(IToken)Match(input,NUMBER,Follow._NUMBER_in_number585); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				NUMBER29_tree = (object)adaptor.Create(NUMBER29);
				adaptor.AddChild(root_0, NUMBER29_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:85:5: extended_id
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(85, 5);
				PushFollow(Follow._extended_id_in_number591);
				extended_id30=extended_id();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, extended_id30.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:86:5: funccallbody
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(86, 5);
				PushFollow(Follow._funccallbody_in_number597);
				funccallbody31=funccallbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody31.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:87:5: CHAR
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(87, 5);
				CHAR32=(IToken)Match(input,CHAR,Follow._CHAR_in_number603); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				CHAR32_tree = (object)adaptor.Create(CHAR32);
				adaptor.AddChild(root_0, CHAR32_tree);
				}

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:88:5: arrayelement
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(88, 5);
				PushFollow(Follow._arrayelement_in_number609);
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
		DebugLocation(90, 2);
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
	// MathLang.g:91:1: mathexpression : term ;
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
		DebugLocation(91, 21);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 12)) { return retval; }
			// MathLang.g:91:15: ( term )
			DebugEnterAlt(1);
			// MathLang.g:91:17: term
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(91, 17);
			PushFollow(Follow._term_in_mathexpression621);
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
		DebugLocation(91, 21);
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
	// MathLang.g:93:1: expression : ( newexpression | funccallbody | boolexpression | mathexpression );
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
		DebugLocation(93, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 13)) { return retval; }
			// MathLang.g:93:11: ( newexpression | funccallbody | boolexpression | mathexpression )
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
				// MathLang.g:94:5: newexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(94, 5);
				PushFollow(Follow._newexpression_in_expression635);
				newexpression35=newexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, newexpression35.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:95:5: funccallbody
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(95, 5);
				PushFollow(Follow._funccallbody_in_expression641);
				funccallbody36=funccallbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody36.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:96:5: boolexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(96, 5);
				PushFollow(Follow._boolexpression_in_expression647);
				boolexpression37=boolexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression37.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:97:5: mathexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(97, 5);
				PushFollow(Follow._mathexpression_in_expression653);
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
		DebugLocation(100, 0);
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
	// MathLang.g:101:1: extended_id : ID ( DOT ID )? -> ^( ID ( ID )? ) ;
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
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_DOT=new RewriteRuleITokenStream(adaptor,"token DOT");

		try { DebugEnterRule(GrammarFileName, "extended_id");
		DebugLocation(101, 39);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 14)) { return retval; }
			// MathLang.g:101:12: ( ID ( DOT ID )? -> ^( ID ( ID )? ) )
			DebugEnterAlt(1);
			// MathLang.g:101:14: ID ( DOT ID )?
			{
			DebugLocation(101, 14);
			ID39=(IToken)Match(input,ID,Follow._ID_in_extended_id666); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID39);

			DebugLocation(101, 17);
			// MathLang.g:101:17: ( DOT ID )?
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
				// MathLang.g:101:18: DOT ID
				{
				DebugLocation(101, 21);
				DOT40=(IToken)Match(input,DOT,Follow._DOT_in_extended_id669); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_DOT.Add(DOT40);

				DebugLocation(101, 23);
				ID41=(IToken)Match(input,ID,Follow._ID_in_extended_id672); if (state.failed) return retval; 
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
			// 101:28: -> ^( ID ( ID )? )
			{
				DebugLocation(101, 31);
				// MathLang.g:101:31: ^( ID ( ID )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(101, 33);
				root_1 = (object)adaptor.BecomeRoot(stream_ID.NextNode(), root_1);

				DebugLocation(101, 36);
				// MathLang.g:101:36: ( ID )?
				if ( stream_ID.HasNext )
				{
					DebugLocation(101, 36);
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
		DebugLocation(101, 39);
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
	// MathLang.g:103:1: arrayelement : extended_id OPEN_SQUARE_BRACE mathexpression CLOSE_SQUARE_BRACE -> ^( ARRAYELEMENT extended_id mathexpression ) ;
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
		MathLangParser.mathexpression_return mathexpression44 = default(MathLangParser.mathexpression_return);

		object OPEN_SQUARE_BRACE43_tree=null;
		object CLOSE_SQUARE_BRACE45_tree=null;
		RewriteRuleITokenStream stream_CLOSE_SQUARE_BRACE=new RewriteRuleITokenStream(adaptor,"token CLOSE_SQUARE_BRACE");
		RewriteRuleITokenStream stream_OPEN_SQUARE_BRACE=new RewriteRuleITokenStream(adaptor,"token OPEN_SQUARE_BRACE");
		RewriteRuleSubtreeStream stream_extended_id=new RewriteRuleSubtreeStream(adaptor,"rule extended_id");
		RewriteRuleSubtreeStream stream_mathexpression=new RewriteRuleSubtreeStream(adaptor,"rule mathexpression");
		try { DebugEnterRule(GrammarFileName, "arrayelement");
		DebugLocation(103, 125);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 15)) { return retval; }
			// MathLang.g:103:13: ( extended_id OPEN_SQUARE_BRACE mathexpression CLOSE_SQUARE_BRACE -> ^( ARRAYELEMENT extended_id mathexpression ) )
			DebugEnterAlt(1);
			// MathLang.g:103:16: extended_id OPEN_SQUARE_BRACE mathexpression CLOSE_SQUARE_BRACE
			{
			DebugLocation(103, 16);
			PushFollow(Follow._extended_id_in_arrayelement691);
			extended_id42=extended_id();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_extended_id.Add(extended_id42.Tree);
			DebugLocation(103, 28);
			OPEN_SQUARE_BRACE43=(IToken)Match(input,OPEN_SQUARE_BRACE,Follow._OPEN_SQUARE_BRACE_in_arrayelement693); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OPEN_SQUARE_BRACE.Add(OPEN_SQUARE_BRACE43);

			DebugLocation(103, 46);
			PushFollow(Follow._mathexpression_in_arrayelement695);
			mathexpression44=mathexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_mathexpression.Add(mathexpression44.Tree);
			DebugLocation(103, 61);
			CLOSE_SQUARE_BRACE45=(IToken)Match(input,CLOSE_SQUARE_BRACE,Follow._CLOSE_SQUARE_BRACE_in_arrayelement697); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CLOSE_SQUARE_BRACE.Add(CLOSE_SQUARE_BRACE45);



			{
			// AST REWRITE
			// elements: extended_id, mathexpression
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 103:80: -> ^( ARRAYELEMENT extended_id mathexpression )
			{
				DebugLocation(103, 83);
				// MathLang.g:103:83: ^( ARRAYELEMENT extended_id mathexpression )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(103, 85);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYELEMENT, "ARRAYELEMENT"), root_1);

				DebugLocation(103, 98);
				adaptor.AddChild(root_1, stream_extended_id.NextTree());
				DebugLocation(103, 110);
				adaptor.AddChild(root_1, stream_mathexpression.NextTree());

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
		DebugLocation(103, 125);
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
	// MathLang.g:104:1: static_declaration : MODIFIER declaration -> ^( STATIC_DECLARATION declaration ) ;
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
		DebugLocation(104, 78);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 16)) { return retval; }
			// MathLang.g:104:19: ( MODIFIER declaration -> ^( STATIC_DECLARATION declaration ) )
			DebugEnterAlt(1);
			// MathLang.g:104:22: MODIFIER declaration
			{
			DebugLocation(104, 22);
			MODIFIER46=(IToken)Match(input,MODIFIER,Follow._MODIFIER_in_static_declaration715); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_MODIFIER.Add(MODIFIER46);

			DebugLocation(104, 31);
			PushFollow(Follow._declaration_in_static_declaration717);
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
			// 104:43: -> ^( STATIC_DECLARATION declaration )
			{
				DebugLocation(104, 46);
				// MathLang.g:104:46: ^( STATIC_DECLARATION declaration )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(104, 48);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(STATIC_DECLARATION, "STATIC_DECLARATION"), root_1);

				DebugLocation(104, 67);
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
		DebugLocation(104, 78);
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
	// MathLang.g:106:1: declaration : ( var_declaration | array_declaration );
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

		MathLangParser.var_declaration_return var_declaration48 = default(MathLangParser.var_declaration_return);
		MathLangParser.array_declaration_return array_declaration49 = default(MathLangParser.array_declaration_return);


		try { DebugEnterRule(GrammarFileName, "declaration");
		DebugLocation(106, 48);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 17)) { return retval; }
			// MathLang.g:106:12: ( var_declaration | array_declaration )
			int alt10=2;
			try { DebugEnterDecision(10, decisionCanBacktrack[10]);
			int LA10_0 = input.LA(1);

			if ((LA10_0==TYPE))
			{
				int LA10_1 = input.LA(2);

				if ((LA10_1==ARRAY_DECLARATION_MARK))
				{
					alt10=2;
				}
				else if ((LA10_1==ID))
				{
					alt10=1;
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
				// MathLang.g:106:14: var_declaration
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(106, 14);
				PushFollow(Follow._var_declaration_in_declaration732);
				var_declaration48=var_declaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, var_declaration48.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:106:32: array_declaration
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(106, 32);
				PushFollow(Follow._array_declaration_in_declaration736);
				array_declaration49=array_declaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, array_declaration49.Tree);

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
			TraceOut("declaration", 17);
			LeaveRule("declaration", 17);
			Leave_declaration();
			if (state.backtracking > 0) { Memoize(input, 17, declaration_StartIndex); }
		}
		DebugLocation(106, 48);
		} finally { DebugExitRule(GrammarFileName, "declaration"); }
		return retval;

	}
	// $ANTLR end "declaration"

	public class var_declaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_var_declaration();
	partial void Leave_var_declaration();

	// $ANTLR start "var_declaration"
	// MathLang.g:107:1: var_declaration : type d_list ';' -> ^( MULT_DECL type d_list ) ;
	[GrammarRule("var_declaration")]
	private MathLangParser.var_declaration_return var_declaration()
	{
		Enter_var_declaration();
		EnterRule("var_declaration", 18);
		TraceIn("var_declaration", 18);
		MathLangParser.var_declaration_return retval = new MathLangParser.var_declaration_return();
		retval.Start = (IToken)input.LT(1);
		int var_declaration_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal52=null;
		MathLangParser.type_return type50 = default(MathLangParser.type_return);
		MathLangParser.d_list_return d_list51 = default(MathLangParser.d_list_return);

		object char_literal52_tree=null;
		RewriteRuleITokenStream stream_71=new RewriteRuleITokenStream(adaptor,"token 71");
		RewriteRuleSubtreeStream stream_d_list=new RewriteRuleSubtreeStream(adaptor,"rule d_list");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "var_declaration");
		DebugLocation(107, 61);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 18)) { return retval; }
			// MathLang.g:107:16: ( type d_list ';' -> ^( MULT_DECL type d_list ) )
			DebugEnterAlt(1);
			// MathLang.g:107:18: type d_list ';'
			{
			DebugLocation(107, 18);
			PushFollow(Follow._type_in_var_declaration742);
			type50=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type50.Tree);
			DebugLocation(107, 23);
			PushFollow(Follow._d_list_in_var_declaration744);
			d_list51=d_list();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_d_list.Add(d_list51.Tree);
			DebugLocation(107, 30);
			char_literal52=(IToken)Match(input,71,Follow._71_in_var_declaration746); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_71.Add(char_literal52);



			{
			// AST REWRITE
			// elements: d_list, type
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 107:34: -> ^( MULT_DECL type d_list )
			{
				DebugLocation(107, 37);
				// MathLang.g:107:37: ^( MULT_DECL type d_list )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(107, 39);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(MULT_DECL, "MULT_DECL"), root_1);

				DebugLocation(107, 49);
				adaptor.AddChild(root_1, stream_type.NextTree());
				DebugLocation(107, 54);
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
			TraceOut("var_declaration", 18);
			LeaveRule("var_declaration", 18);
			Leave_var_declaration();
			if (state.backtracking > 0) { Memoize(input, 18, var_declaration_StartIndex); }
		}
		DebugLocation(107, 61);
		} finally { DebugExitRule(GrammarFileName, "var_declaration"); }
		return retval;

	}
	// $ANTLR end "var_declaration"

	public class array_declaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_array_declaration();
	partial void Leave_array_declaration();

	// $ANTLR start "array_declaration"
	// MathLang.g:108:1: array_declaration : array_type d_array_list ';' -> ^( MULT_ARRAY_DECL array_type d_array_list ) ;
	[GrammarRule("array_declaration")]
	private MathLangParser.array_declaration_return array_declaration()
	{
		Enter_array_declaration();
		EnterRule("array_declaration", 19);
		TraceIn("array_declaration", 19);
		MathLangParser.array_declaration_return retval = new MathLangParser.array_declaration_return();
		retval.Start = (IToken)input.LT(1);
		int array_declaration_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal55=null;
		MathLangParser.array_type_return array_type53 = default(MathLangParser.array_type_return);
		MathLangParser.d_array_list_return d_array_list54 = default(MathLangParser.d_array_list_return);

		object char_literal55_tree=null;
		RewriteRuleITokenStream stream_71=new RewriteRuleITokenStream(adaptor,"token 71");
		RewriteRuleSubtreeStream stream_d_array_list=new RewriteRuleSubtreeStream(adaptor,"rule d_array_list");
		RewriteRuleSubtreeStream stream_array_type=new RewriteRuleSubtreeStream(adaptor,"rule array_type");
		try { DebugEnterRule(GrammarFileName, "array_declaration");
		DebugLocation(108, 93);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 19)) { return retval; }
			// MathLang.g:108:18: ( array_type d_array_list ';' -> ^( MULT_ARRAY_DECL array_type d_array_list ) )
			DebugEnterAlt(1);
			// MathLang.g:108:20: array_type d_array_list ';'
			{
			DebugLocation(108, 20);
			PushFollow(Follow._array_type_in_array_declaration763);
			array_type53=array_type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_array_type.Add(array_type53.Tree);
			DebugLocation(108, 31);
			PushFollow(Follow._d_array_list_in_array_declaration765);
			d_array_list54=d_array_list();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_d_array_list.Add(d_array_list54.Tree);
			DebugLocation(108, 44);
			char_literal55=(IToken)Match(input,71,Follow._71_in_array_declaration767); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_71.Add(char_literal55);



			{
			// AST REWRITE
			// elements: array_type, d_array_list
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 108:48: -> ^( MULT_ARRAY_DECL array_type d_array_list )
			{
				DebugLocation(108, 51);
				// MathLang.g:108:51: ^( MULT_ARRAY_DECL array_type d_array_list )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(108, 53);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(MULT_ARRAY_DECL, "MULT_ARRAY_DECL"), root_1);

				DebugLocation(108, 69);
				adaptor.AddChild(root_1, stream_array_type.NextTree());
				DebugLocation(108, 80);
				adaptor.AddChild(root_1, stream_d_array_list.NextTree());

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
			TraceOut("array_declaration", 19);
			LeaveRule("array_declaration", 19);
			Leave_array_declaration();
			if (state.backtracking > 0) { Memoize(input, 19, array_declaration_StartIndex); }
		}
		DebugLocation(108, 93);
		} finally { DebugExitRule(GrammarFileName, "array_declaration"); }
		return retval;

	}
	// $ANTLR end "array_declaration"

	public class d_list_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_d_list();
	partial void Leave_d_list();

	// $ANTLR start "d_list"
	// MathLang.g:110:1: d_list : d ( ',' d )* -> ^( VARS d ( d )* ) ;
	[GrammarRule("d_list")]
	private MathLangParser.d_list_return d_list()
	{
		Enter_d_list();
		EnterRule("d_list", 20);
		TraceIn("d_list", 20);
		MathLangParser.d_list_return retval = new MathLangParser.d_list_return();
		retval.Start = (IToken)input.LT(1);
		int d_list_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal57=null;
		MathLangParser.d_return d56 = default(MathLangParser.d_return);
		MathLangParser.d_return d58 = default(MathLangParser.d_return);

		object char_literal57_tree=null;
		RewriteRuleITokenStream stream_72=new RewriteRuleITokenStream(adaptor,"token 72");
		RewriteRuleSubtreeStream stream_d=new RewriteRuleSubtreeStream(adaptor,"rule d");
		try { DebugEnterRule(GrammarFileName, "d_list");
		DebugLocation(110, 39);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 20)) { return retval; }
			// MathLang.g:110:7: ( d ( ',' d )* -> ^( VARS d ( d )* ) )
			DebugEnterAlt(1);
			// MathLang.g:110:9: d ( ',' d )*
			{
			DebugLocation(110, 9);
			PushFollow(Follow._d_in_d_list785);
			d56=d();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_d.Add(d56.Tree);
			DebugLocation(110, 11);
			// MathLang.g:110:11: ( ',' d )*
			try { DebugEnterSubRule(11);
			while (true)
			{
				int alt11=2;
				try { DebugEnterDecision(11, decisionCanBacktrack[11]);
				int LA11_0 = input.LA(1);

				if ((LA11_0==72))
				{
					alt11=1;
				}


				} finally { DebugExitDecision(11); }
				switch ( alt11 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:110:12: ',' d
					{
					DebugLocation(110, 15);
					char_literal57=(IToken)Match(input,72,Follow._72_in_d_list788); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_72.Add(char_literal57);

					DebugLocation(110, 17);
					PushFollow(Follow._d_in_d_list791);
					d58=d();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_d.Add(d58.Tree);

					}
					break;

				default:
					goto loop11;
				}
			}

			loop11:
				;

			} finally { DebugExitSubRule(11); }



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
			// 110:21: -> ^( VARS d ( d )* )
			{
				DebugLocation(110, 24);
				// MathLang.g:110:24: ^( VARS d ( d )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(110, 27);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARS, "VARS"), root_1);

				DebugLocation(110, 32);
				adaptor.AddChild(root_1, stream_d.NextTree());
				DebugLocation(110, 34);
				// MathLang.g:110:34: ( d )*
				while ( stream_d.HasNext )
				{
					DebugLocation(110, 34);
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
			TraceOut("d_list", 20);
			LeaveRule("d_list", 20);
			Leave_d_list();
			if (state.backtracking > 0) { Memoize(input, 20, d_list_StartIndex); }
		}
		DebugLocation(110, 39);
		} finally { DebugExitRule(GrammarFileName, "d_list"); }
		return retval;

	}
	// $ANTLR end "d_list"

	public class d_array_list_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_d_array_list();
	partial void Leave_d_array_list();

	// $ANTLR start "d_array_list"
	// MathLang.g:111:1: d_array_list : d_array ( ',' d_array )* -> ^( VARS d_array ( d_array )* ) ;
	[GrammarRule("d_array_list")]
	private MathLangParser.d_array_list_return d_array_list()
	{
		Enter_d_array_list();
		EnterRule("d_array_list", 21);
		TraceIn("d_array_list", 21);
		MathLangParser.d_array_list_return retval = new MathLangParser.d_array_list_return();
		retval.Start = (IToken)input.LT(1);
		int d_array_list_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal60=null;
		MathLangParser.d_array_return d_array59 = default(MathLangParser.d_array_return);
		MathLangParser.d_array_return d_array61 = default(MathLangParser.d_array_return);

		object char_literal60_tree=null;
		RewriteRuleITokenStream stream_72=new RewriteRuleITokenStream(adaptor,"token 72");
		RewriteRuleSubtreeStream stream_d_array=new RewriteRuleSubtreeStream(adaptor,"rule d_array");
		try { DebugEnterRule(GrammarFileName, "d_array_list");
		DebugLocation(111, 69);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 21)) { return retval; }
			// MathLang.g:111:13: ( d_array ( ',' d_array )* -> ^( VARS d_array ( d_array )* ) )
			DebugEnterAlt(1);
			// MathLang.g:111:15: d_array ( ',' d_array )*
			{
			DebugLocation(111, 15);
			PushFollow(Follow._d_array_in_d_array_list814);
			d_array59=d_array();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_d_array.Add(d_array59.Tree);
			DebugLocation(111, 23);
			// MathLang.g:111:23: ( ',' d_array )*
			try { DebugEnterSubRule(12);
			while (true)
			{
				int alt12=2;
				try { DebugEnterDecision(12, decisionCanBacktrack[12]);
				int LA12_0 = input.LA(1);

				if ((LA12_0==72))
				{
					alt12=1;
				}


				} finally { DebugExitDecision(12); }
				switch ( alt12 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:111:24: ',' d_array
					{
					DebugLocation(111, 27);
					char_literal60=(IToken)Match(input,72,Follow._72_in_d_array_list817); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_72.Add(char_literal60);

					DebugLocation(111, 29);
					PushFollow(Follow._d_array_in_d_array_list820);
					d_array61=d_array();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_d_array.Add(d_array61.Tree);

					}
					break;

				default:
					goto loop12;
				}
			}

			loop12:
				;

			} finally { DebugExitSubRule(12); }



			{
			// AST REWRITE
			// elements: d_array, d_array
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 111:39: -> ^( VARS d_array ( d_array )* )
			{
				DebugLocation(111, 42);
				// MathLang.g:111:42: ^( VARS d_array ( d_array )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(111, 45);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARS, "VARS"), root_1);

				DebugLocation(111, 50);
				adaptor.AddChild(root_1, stream_d_array.NextTree());
				DebugLocation(111, 58);
				// MathLang.g:111:58: ( d_array )*
				while ( stream_d_array.HasNext )
				{
					DebugLocation(111, 58);
					adaptor.AddChild(root_1, stream_d_array.NextTree());

				}
				stream_d_array.Reset();

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
			TraceOut("d_array_list", 21);
			LeaveRule("d_array_list", 21);
			Leave_d_array_list();
			if (state.backtracking > 0) { Memoize(input, 21, d_array_list_StartIndex); }
		}
		DebugLocation(111, 69);
		} finally { DebugExitRule(GrammarFileName, "d_array_list"); }
		return retval;

	}
	// $ANTLR end "d_array_list"

	public class d_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_d();
	partial void Leave_d();

	// $ANTLR start "d"
	// MathLang.g:113:1: d : ( declarationbody_d | longdeclarationbody_d );
	[GrammarRule("d")]
	private MathLangParser.d_return d()
	{
		Enter_d();
		EnterRule("d", 22);
		TraceIn("d", 22);
		MathLangParser.d_return retval = new MathLangParser.d_return();
		retval.Start = (IToken)input.LT(1);
		int d_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.declarationbody_d_return declarationbody_d62 = default(MathLangParser.declarationbody_d_return);
		MathLangParser.longdeclarationbody_d_return longdeclarationbody_d63 = default(MathLangParser.longdeclarationbody_d_return);


		try { DebugEnterRule(GrammarFileName, "d");
		DebugLocation(113, 45);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 22)) { return retval; }
			// MathLang.g:113:2: ( declarationbody_d | longdeclarationbody_d )
			int alt13=2;
			try { DebugEnterDecision(13, decisionCanBacktrack[13]);
			int LA13_0 = input.LA(1);

			if ((LA13_0==ID))
			{
				int LA13_1 = input.LA(2);

				if ((LA13_1==ASSIGN))
				{
					alt13=2;
				}
				else if ((LA13_1==EOF||(LA13_1>=71 && LA13_1<=72)))
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
				// MathLang.g:113:4: declarationbody_d
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(113, 4);
				PushFollow(Follow._declarationbody_d_in_d844);
				declarationbody_d62=declarationbody_d();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, declarationbody_d62.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:113:24: longdeclarationbody_d
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(113, 24);
				PushFollow(Follow._longdeclarationbody_d_in_d848);
				longdeclarationbody_d63=longdeclarationbody_d();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclarationbody_d63.Tree);

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
			TraceOut("d", 22);
			LeaveRule("d", 22);
			Leave_d();
			if (state.backtracking > 0) { Memoize(input, 22, d_StartIndex); }
		}
		DebugLocation(113, 45);
		} finally { DebugExitRule(GrammarFileName, "d"); }
		return retval;

	}
	// $ANTLR end "d"

	public class d_array_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_d_array();
	partial void Leave_d_array();

	// $ANTLR start "d_array"
	// MathLang.g:114:1: d_array : ( declarationbody_array_d | longdeclarationbody_array_d );
	[GrammarRule("d_array")]
	private MathLangParser.d_array_return d_array()
	{
		Enter_d_array();
		EnterRule("d_array", 23);
		TraceIn("d_array", 23);
		MathLangParser.d_array_return retval = new MathLangParser.d_array_return();
		retval.Start = (IToken)input.LT(1);
		int d_array_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.declarationbody_array_d_return declarationbody_array_d64 = default(MathLangParser.declarationbody_array_d_return);
		MathLangParser.longdeclarationbody_array_d_return longdeclarationbody_array_d65 = default(MathLangParser.longdeclarationbody_array_d_return);


		try { DebugEnterRule(GrammarFileName, "d_array");
		DebugLocation(114, 62);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 23)) { return retval; }
			// MathLang.g:114:8: ( declarationbody_array_d | longdeclarationbody_array_d )
			int alt14=2;
			try { DebugEnterDecision(14, decisionCanBacktrack[14]);
			int LA14_0 = input.LA(1);

			if ((LA14_0==ID))
			{
				int LA14_1 = input.LA(2);

				if ((LA14_1==ASSIGN))
				{
					alt14=2;
				}
				else if ((LA14_1==EOF||(LA14_1>=71 && LA14_1<=72)))
				{
					alt14=1;
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
				// MathLang.g:114:10: declarationbody_array_d
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(114, 10);
				PushFollow(Follow._declarationbody_array_d_in_d_array855);
				declarationbody_array_d64=declarationbody_array_d();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, declarationbody_array_d64.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:114:36: longdeclarationbody_array_d
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(114, 36);
				PushFollow(Follow._longdeclarationbody_array_d_in_d_array859);
				longdeclarationbody_array_d65=longdeclarationbody_array_d();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclarationbody_array_d65.Tree);

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
			TraceOut("d_array", 23);
			LeaveRule("d_array", 23);
			Leave_d_array();
			if (state.backtracking > 0) { Memoize(input, 23, d_array_StartIndex); }
		}
		DebugLocation(114, 62);
		} finally { DebugExitRule(GrammarFileName, "d_array"); }
		return retval;

	}
	// $ANTLR end "d_array"

	public class declarationbody_d_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_declarationbody_d();
	partial void Leave_declarationbody_d();

	// $ANTLR start "declarationbody_d"
	// MathLang.g:116:1: declarationbody_d : ( ID -> ^( VARDECLARATION ID ) ) ;
	[GrammarRule("declarationbody_d")]
	private MathLangParser.declarationbody_d_return declarationbody_d()
	{
		Enter_declarationbody_d();
		EnterRule("declarationbody_d", 24);
		TraceIn("declarationbody_d", 24);
		MathLangParser.declarationbody_d_return retval = new MathLangParser.declarationbody_d_return();
		retval.Start = (IToken)input.LT(1);
		int declarationbody_d_StartIndex = input.Index;
		object root_0 = null;

		IToken ID66=null;

		object ID66_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");

		try { DebugEnterRule(GrammarFileName, "declarationbody_d");
		DebugLocation(116, 48);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 24)) { return retval; }
			// MathLang.g:116:18: ( ( ID -> ^( VARDECLARATION ID ) ) )
			DebugEnterAlt(1);
			// MathLang.g:116:20: ( ID -> ^( VARDECLARATION ID ) )
			{
			DebugLocation(116, 20);
			// MathLang.g:116:20: ( ID -> ^( VARDECLARATION ID ) )
			DebugEnterAlt(1);
			// MathLang.g:116:21: ID
			{
			DebugLocation(116, 21);
			ID66=(IToken)Match(input,ID,Follow._ID_in_declarationbody_d867); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID66);



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
			// 116:24: -> ^( VARDECLARATION ID )
			{
				DebugLocation(116, 27);
				// MathLang.g:116:27: ^( VARDECLARATION ID )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(116, 29);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDECLARATION, "VARDECLARATION"), root_1);

				DebugLocation(116, 44);
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
			TraceOut("declarationbody_d", 24);
			LeaveRule("declarationbody_d", 24);
			Leave_declarationbody_d();
			if (state.backtracking > 0) { Memoize(input, 24, declarationbody_d_StartIndex); }
		}
		DebugLocation(116, 48);
		} finally { DebugExitRule(GrammarFileName, "declarationbody_d"); }
		return retval;

	}
	// $ANTLR end "declarationbody_d"

	public class declarationbody_array_d_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_declarationbody_array_d();
	partial void Leave_declarationbody_array_d();

	// $ANTLR start "declarationbody_array_d"
	// MathLang.g:117:1: declarationbody_array_d : ( ID -> ^( ARRAYDECLARATION ID ) ) ;
	[GrammarRule("declarationbody_array_d")]
	private MathLangParser.declarationbody_array_d_return declarationbody_array_d()
	{
		Enter_declarationbody_array_d();
		EnterRule("declarationbody_array_d", 25);
		TraceIn("declarationbody_array_d", 25);
		MathLangParser.declarationbody_array_d_return retval = new MathLangParser.declarationbody_array_d_return();
		retval.Start = (IToken)input.LT(1);
		int declarationbody_array_d_StartIndex = input.Index;
		object root_0 = null;

		IToken ID67=null;

		object ID67_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");

		try { DebugEnterRule(GrammarFileName, "declarationbody_array_d");
		DebugLocation(117, 56);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 25)) { return retval; }
			// MathLang.g:117:24: ( ( ID -> ^( ARRAYDECLARATION ID ) ) )
			DebugEnterAlt(1);
			// MathLang.g:117:26: ( ID -> ^( ARRAYDECLARATION ID ) )
			{
			DebugLocation(117, 26);
			// MathLang.g:117:26: ( ID -> ^( ARRAYDECLARATION ID ) )
			DebugEnterAlt(1);
			// MathLang.g:117:28: ID
			{
			DebugLocation(117, 28);
			ID67=(IToken)Match(input,ID,Follow._ID_in_declarationbody_array_d889); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID67);



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
			// 117:31: -> ^( ARRAYDECLARATION ID )
			{
				DebugLocation(117, 34);
				// MathLang.g:117:34: ^( ARRAYDECLARATION ID )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(117, 36);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYDECLARATION, "ARRAYDECLARATION"), root_1);

				DebugLocation(117, 53);
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
			TraceOut("declarationbody_array_d", 25);
			LeaveRule("declarationbody_array_d", 25);
			Leave_declarationbody_array_d();
			if (state.backtracking > 0) { Memoize(input, 25, declarationbody_array_d_StartIndex); }
		}
		DebugLocation(117, 56);
		} finally { DebugExitRule(GrammarFileName, "declarationbody_array_d"); }
		return retval;

	}
	// $ANTLR end "declarationbody_array_d"

	public class longdeclarationbody_d_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_longdeclarationbody_d();
	partial void Leave_longdeclarationbody_d();

	// $ANTLR start "longdeclarationbody_d"
	// MathLang.g:119:1: longdeclarationbody_d : ( ID ASSIGN expression -> ^( VARDECLARATION ID expression ) ) ;
	[GrammarRule("longdeclarationbody_d")]
	private MathLangParser.longdeclarationbody_d_return longdeclarationbody_d()
	{
		Enter_longdeclarationbody_d();
		EnterRule("longdeclarationbody_d", 26);
		TraceIn("longdeclarationbody_d", 26);
		MathLangParser.longdeclarationbody_d_return retval = new MathLangParser.longdeclarationbody_d_return();
		retval.Start = (IToken)input.LT(1);
		int longdeclarationbody_d_StartIndex = input.Index;
		object root_0 = null;

		IToken ID68=null;
		IToken ASSIGN69=null;
		MathLangParser.expression_return expression70 = default(MathLangParser.expression_return);

		object ID68_tree=null;
		object ASSIGN69_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "longdeclarationbody_d");
		DebugLocation(119, 81);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 26)) { return retval; }
			// MathLang.g:119:22: ( ( ID ASSIGN expression -> ^( VARDECLARATION ID expression ) ) )
			DebugEnterAlt(1);
			// MathLang.g:119:24: ( ID ASSIGN expression -> ^( VARDECLARATION ID expression ) )
			{
			DebugLocation(119, 24);
			// MathLang.g:119:24: ( ID ASSIGN expression -> ^( VARDECLARATION ID expression ) )
			DebugEnterAlt(1);
			// MathLang.g:119:25: ID ASSIGN expression
			{
			DebugLocation(119, 25);
			ID68=(IToken)Match(input,ID,Follow._ID_in_longdeclarationbody_d906); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID68);

			DebugLocation(119, 28);
			ASSIGN69=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclarationbody_d908); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN69);

			DebugLocation(119, 35);
			PushFollow(Follow._expression_in_longdeclarationbody_d910);
			expression70=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression70.Tree);


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
			// 119:47: -> ^( VARDECLARATION ID expression )
			{
				DebugLocation(119, 50);
				// MathLang.g:119:50: ^( VARDECLARATION ID expression )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(119, 52);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDECLARATION, "VARDECLARATION"), root_1);

				DebugLocation(119, 67);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(119, 70);
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
			TraceOut("longdeclarationbody_d", 26);
			LeaveRule("longdeclarationbody_d", 26);
			Leave_longdeclarationbody_d();
			if (state.backtracking > 0) { Memoize(input, 26, longdeclarationbody_d_StartIndex); }
		}
		DebugLocation(119, 81);
		} finally { DebugExitRule(GrammarFileName, "longdeclarationbody_d"); }
		return retval;

	}
	// $ANTLR end "longdeclarationbody_d"

	public class longdeclarationbody_array_d_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_longdeclarationbody_array_d();
	partial void Leave_longdeclarationbody_array_d();

	// $ANTLR start "longdeclarationbody_array_d"
	// MathLang.g:120:1: longdeclarationbody_array_d : ( ID ASSIGN newexpression -> ^( ARRAYDECLARATION ID newexpression ) ) ;
	[GrammarRule("longdeclarationbody_array_d")]
	private MathLangParser.longdeclarationbody_array_d_return longdeclarationbody_array_d()
	{
		Enter_longdeclarationbody_array_d();
		EnterRule("longdeclarationbody_array_d", 27);
		TraceIn("longdeclarationbody_array_d", 27);
		MathLangParser.longdeclarationbody_array_d_return retval = new MathLangParser.longdeclarationbody_array_d_return();
		retval.Start = (IToken)input.LT(1);
		int longdeclarationbody_array_d_StartIndex = input.Index;
		object root_0 = null;

		IToken ID71=null;
		IToken ASSIGN72=null;
		MathLangParser.newexpression_return newexpression73 = default(MathLangParser.newexpression_return);

		object ID71_tree=null;
		object ASSIGN72_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_newexpression=new RewriteRuleSubtreeStream(adaptor,"rule newexpression");
		try { DebugEnterRule(GrammarFileName, "longdeclarationbody_array_d");
		DebugLocation(120, 94);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 27)) { return retval; }
			// MathLang.g:120:28: ( ( ID ASSIGN newexpression -> ^( ARRAYDECLARATION ID newexpression ) ) )
			DebugEnterAlt(1);
			// MathLang.g:120:30: ( ID ASSIGN newexpression -> ^( ARRAYDECLARATION ID newexpression ) )
			{
			DebugLocation(120, 30);
			// MathLang.g:120:30: ( ID ASSIGN newexpression -> ^( ARRAYDECLARATION ID newexpression ) )
			DebugEnterAlt(1);
			// MathLang.g:120:31: ID ASSIGN newexpression
			{
			DebugLocation(120, 31);
			ID71=(IToken)Match(input,ID,Follow._ID_in_longdeclarationbody_array_d929); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID71);

			DebugLocation(120, 34);
			ASSIGN72=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclarationbody_array_d931); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN72);

			DebugLocation(120, 41);
			PushFollow(Follow._newexpression_in_longdeclarationbody_array_d933);
			newexpression73=newexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_newexpression.Add(newexpression73.Tree);


			{
			// AST REWRITE
			// elements: newexpression, ID
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 120:55: -> ^( ARRAYDECLARATION ID newexpression )
			{
				DebugLocation(120, 58);
				// MathLang.g:120:58: ^( ARRAYDECLARATION ID newexpression )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(120, 60);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYDECLARATION, "ARRAYDECLARATION"), root_1);

				DebugLocation(120, 77);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(120, 80);
				adaptor.AddChild(root_1, stream_newexpression.NextTree());

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
			TraceOut("longdeclarationbody_array_d", 27);
			LeaveRule("longdeclarationbody_array_d", 27);
			Leave_longdeclarationbody_array_d();
			if (state.backtracking > 0) { Memoize(input, 27, longdeclarationbody_array_d_StartIndex); }
		}
		DebugLocation(120, 94);
		} finally { DebugExitRule(GrammarFileName, "longdeclarationbody_array_d"); }
		return retval;

	}
	// $ANTLR end "longdeclarationbody_array_d"

	public class declarationbody_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_declarationbody();
	partial void Leave_declarationbody();

	// $ANTLR start "declarationbody"
	// MathLang.g:123:1: declarationbody : ( ( type ID -> ^( VARDECLARATION type ID ) ) | ( array_type ID -> ^( ARRAYDECLARATION array_type ID ) ) );
	[GrammarRule("declarationbody")]
	private MathLangParser.declarationbody_return declarationbody()
	{
		Enter_declarationbody();
		EnterRule("declarationbody", 28);
		TraceIn("declarationbody", 28);
		MathLangParser.declarationbody_return retval = new MathLangParser.declarationbody_return();
		retval.Start = (IToken)input.LT(1);
		int declarationbody_StartIndex = input.Index;
		object root_0 = null;

		IToken ID75=null;
		IToken ID77=null;
		MathLangParser.type_return type74 = default(MathLangParser.type_return);
		MathLangParser.array_type_return array_type76 = default(MathLangParser.array_type_return);

		object ID75_tree=null;
		object ID77_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleSubtreeStream stream_array_type=new RewriteRuleSubtreeStream(adaptor,"rule array_type");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "declarationbody");
		DebugLocation(123, 4);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 28)) { return retval; }
			// MathLang.g:123:16: ( ( type ID -> ^( VARDECLARATION type ID ) ) | ( array_type ID -> ^( ARRAYDECLARATION array_type ID ) ) )
			int alt15=2;
			try { DebugEnterDecision(15, decisionCanBacktrack[15]);
			int LA15_0 = input.LA(1);

			if ((LA15_0==TYPE))
			{
				int LA15_1 = input.LA(2);

				if ((LA15_1==ARRAY_DECLARATION_MARK))
				{
					alt15=2;
				}
				else if ((LA15_1==ID))
				{
					alt15=1;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 15, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
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
				// MathLang.g:123:18: ( type ID -> ^( VARDECLARATION type ID ) )
				{
				DebugLocation(123, 18);
				// MathLang.g:123:18: ( type ID -> ^( VARDECLARATION type ID ) )
				DebugEnterAlt(1);
				// MathLang.g:123:19: type ID
				{
				DebugLocation(123, 19);
				PushFollow(Follow._type_in_declarationbody953);
				type74=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type74.Tree);
				DebugLocation(123, 24);
				ID75=(IToken)Match(input,ID,Follow._ID_in_declarationbody955); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID75);



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
				// 123:27: -> ^( VARDECLARATION type ID )
				{
					DebugLocation(123, 30);
					// MathLang.g:123:30: ^( VARDECLARATION type ID )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(123, 32);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDECLARATION, "VARDECLARATION"), root_1);

					DebugLocation(123, 47);
					adaptor.AddChild(root_1, stream_type.NextTree());
					DebugLocation(123, 52);
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
				// MathLang.g:124:7: ( array_type ID -> ^( ARRAYDECLARATION array_type ID ) )
				{
				DebugLocation(124, 7);
				// MathLang.g:124:7: ( array_type ID -> ^( ARRAYDECLARATION array_type ID ) )
				DebugEnterAlt(1);
				// MathLang.g:124:8: array_type ID
				{
				DebugLocation(124, 8);
				PushFollow(Follow._array_type_in_declarationbody976);
				array_type76=array_type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_array_type.Add(array_type76.Tree);
				DebugLocation(124, 19);
				ID77=(IToken)Match(input,ID,Follow._ID_in_declarationbody978); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID77);



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
				// 124:22: -> ^( ARRAYDECLARATION array_type ID )
				{
					DebugLocation(124, 25);
					// MathLang.g:124:25: ^( ARRAYDECLARATION array_type ID )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(124, 27);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYDECLARATION, "ARRAYDECLARATION"), root_1);

					DebugLocation(124, 44);
					adaptor.AddChild(root_1, stream_array_type.NextTree());
					DebugLocation(124, 55);
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
			TraceOut("declarationbody", 28);
			LeaveRule("declarationbody", 28);
			Leave_declarationbody();
			if (state.backtracking > 0) { Memoize(input, 28, declarationbody_StartIndex); }
		}
		DebugLocation(125, 4);
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
	// MathLang.g:126:1: longdeclarationbody : ( ( type ID ASSIGN expression -> ^( VARDECLARATION type ID expression ) ) | ( array_type ID ASSIGN newexpression -> ^( ARRAYDECLARATION array_type ID newexpression ) ) );
	[GrammarRule("longdeclarationbody")]
	private MathLangParser.longdeclarationbody_return longdeclarationbody()
	{
		Enter_longdeclarationbody();
		EnterRule("longdeclarationbody", 29);
		TraceIn("longdeclarationbody", 29);
		MathLangParser.longdeclarationbody_return retval = new MathLangParser.longdeclarationbody_return();
		retval.Start = (IToken)input.LT(1);
		int longdeclarationbody_StartIndex = input.Index;
		object root_0 = null;

		IToken ID79=null;
		IToken ASSIGN80=null;
		IToken ID83=null;
		IToken ASSIGN84=null;
		MathLangParser.type_return type78 = default(MathLangParser.type_return);
		MathLangParser.expression_return expression81 = default(MathLangParser.expression_return);
		MathLangParser.array_type_return array_type82 = default(MathLangParser.array_type_return);
		MathLangParser.newexpression_return newexpression85 = default(MathLangParser.newexpression_return);

		object ID79_tree=null;
		object ASSIGN80_tree=null;
		object ID83_tree=null;
		object ASSIGN84_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_newexpression=new RewriteRuleSubtreeStream(adaptor,"rule newexpression");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_array_type=new RewriteRuleSubtreeStream(adaptor,"rule array_type");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "longdeclarationbody");
		DebugLocation(126, 5);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 29)) { return retval; }
			// MathLang.g:126:20: ( ( type ID ASSIGN expression -> ^( VARDECLARATION type ID expression ) ) | ( array_type ID ASSIGN newexpression -> ^( ARRAYDECLARATION array_type ID newexpression ) ) )
			int alt16=2;
			try { DebugEnterDecision(16, decisionCanBacktrack[16]);
			int LA16_0 = input.LA(1);

			if ((LA16_0==TYPE))
			{
				int LA16_1 = input.LA(2);

				if ((LA16_1==ARRAY_DECLARATION_MARK))
				{
					alt16=2;
				}
				else if ((LA16_1==ID))
				{
					alt16=1;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 16, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
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
				// MathLang.g:126:22: ( type ID ASSIGN expression -> ^( VARDECLARATION type ID expression ) )
				{
				DebugLocation(126, 22);
				// MathLang.g:126:22: ( type ID ASSIGN expression -> ^( VARDECLARATION type ID expression ) )
				DebugEnterAlt(1);
				// MathLang.g:126:24: type ID ASSIGN expression
				{
				DebugLocation(126, 24);
				PushFollow(Follow._type_in_longdeclarationbody1002);
				type78=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type78.Tree);
				DebugLocation(126, 29);
				ID79=(IToken)Match(input,ID,Follow._ID_in_longdeclarationbody1004); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID79);

				DebugLocation(126, 32);
				ASSIGN80=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclarationbody1006); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN80);

				DebugLocation(126, 39);
				PushFollow(Follow._expression_in_longdeclarationbody1008);
				expression81=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression81.Tree);


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
				// 126:51: -> ^( VARDECLARATION type ID expression )
				{
					DebugLocation(126, 54);
					// MathLang.g:126:54: ^( VARDECLARATION type ID expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(126, 56);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDECLARATION, "VARDECLARATION"), root_1);

					DebugLocation(126, 71);
					adaptor.AddChild(root_1, stream_type.NextTree());
					DebugLocation(126, 76);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(126, 79);
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
				// MathLang.g:127:8: ( array_type ID ASSIGN newexpression -> ^( ARRAYDECLARATION array_type ID newexpression ) )
				{
				DebugLocation(127, 8);
				// MathLang.g:127:8: ( array_type ID ASSIGN newexpression -> ^( ARRAYDECLARATION array_type ID newexpression ) )
				DebugEnterAlt(1);
				// MathLang.g:127:9: array_type ID ASSIGN newexpression
				{
				DebugLocation(127, 9);
				PushFollow(Follow._array_type_in_longdeclarationbody1032);
				array_type82=array_type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_array_type.Add(array_type82.Tree);
				DebugLocation(127, 20);
				ID83=(IToken)Match(input,ID,Follow._ID_in_longdeclarationbody1034); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID83);

				DebugLocation(127, 23);
				ASSIGN84=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclarationbody1036); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN84);

				DebugLocation(127, 30);
				PushFollow(Follow._newexpression_in_longdeclarationbody1038);
				newexpression85=newexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_newexpression.Add(newexpression85.Tree);


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
				// 127:44: -> ^( ARRAYDECLARATION array_type ID newexpression )
				{
					DebugLocation(127, 47);
					// MathLang.g:127:47: ^( ARRAYDECLARATION array_type ID newexpression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(127, 49);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYDECLARATION, "ARRAYDECLARATION"), root_1);

					DebugLocation(127, 66);
					adaptor.AddChild(root_1, stream_array_type.NextTree());
					DebugLocation(127, 77);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(127, 80);
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
			TraceOut("longdeclarationbody", 29);
			LeaveRule("longdeclarationbody", 29);
			Leave_longdeclarationbody();
			if (state.backtracking > 0) { Memoize(input, 29, longdeclarationbody_StartIndex); }
		}
		DebugLocation(128, 5);
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
	// MathLang.g:130:1: add : mul ( ( ADD | SUB ) mul )* ;
	[GrammarRule("add")]
	private MathLangParser.add_return add()
	{
		Enter_add();
		EnterRule("add", 30);
		TraceIn("add", 30);
		MathLangParser.add_return retval = new MathLangParser.add_return();
		retval.Start = (IToken)input.LT(1);
		int add_StartIndex = input.Index;
		object root_0 = null;

		IToken set87=null;
		MathLangParser.mul_return mul86 = default(MathLangParser.mul_return);
		MathLangParser.mul_return mul88 = default(MathLangParser.mul_return);

		object set87_tree=null;

		try { DebugEnterRule(GrammarFileName, "add");
		DebugLocation(130, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 30)) { return retval; }
			// MathLang.g:130:4: ( mul ( ( ADD | SUB ) mul )* )
			DebugEnterAlt(1);
			// MathLang.g:130:6: mul ( ( ADD | SUB ) mul )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(130, 6);
			PushFollow(Follow._mul_in_add1064);
			mul86=mul();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul86.Tree);
			DebugLocation(130, 10);
			// MathLang.g:130:10: ( ( ADD | SUB ) mul )*
			try { DebugEnterSubRule(17);
			while (true)
			{
				int alt17=2;
				try { DebugEnterDecision(17, decisionCanBacktrack[17]);
				int LA17_0 = input.LA(1);

				if (((LA17_0>=ADD && LA17_0<=SUB)))
				{
					alt17=1;
				}


				} finally { DebugExitDecision(17); }
				switch ( alt17 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:130:12: ( ADD | SUB ) mul
					{
					DebugLocation(130, 12);
					set87=(IToken)input.LT(1);
					set87=(IToken)input.LT(1);
					if ((input.LA(1)>=ADD && input.LA(1)<=SUB))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set87), root_0);
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(130, 25);
					PushFollow(Follow._mul_in_add1077);
					mul88=mul();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul88.Tree);

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
			TraceOut("add", 30);
			LeaveRule("add", 30);
			Leave_add();
			if (state.backtracking > 0) { Memoize(input, 30, add_StartIndex); }
		}
		DebugLocation(130, 30);
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
	// MathLang.g:131:1: mul : group ( ( MUL | DIV ) group )* ;
	[GrammarRule("mul")]
	private MathLangParser.mul_return mul()
	{
		Enter_mul();
		EnterRule("mul", 31);
		TraceIn("mul", 31);
		MathLangParser.mul_return retval = new MathLangParser.mul_return();
		retval.Start = (IToken)input.LT(1);
		int mul_StartIndex = input.Index;
		object root_0 = null;

		IToken set90=null;
		MathLangParser.group_return group89 = default(MathLangParser.group_return);
		MathLangParser.group_return group91 = default(MathLangParser.group_return);

		object set90_tree=null;

		try { DebugEnterRule(GrammarFileName, "mul");
		DebugLocation(131, 33);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 31)) { return retval; }
			// MathLang.g:131:4: ( group ( ( MUL | DIV ) group )* )
			DebugEnterAlt(1);
			// MathLang.g:131:6: group ( ( MUL | DIV ) group )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(131, 6);
			PushFollow(Follow._group_in_mul1086);
			group89=group();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group89.Tree);
			DebugLocation(131, 12);
			// MathLang.g:131:12: ( ( MUL | DIV ) group )*
			try { DebugEnterSubRule(18);
			while (true)
			{
				int alt18=2;
				try { DebugEnterDecision(18, decisionCanBacktrack[18]);
				int LA18_0 = input.LA(1);

				if (((LA18_0>=MUL && LA18_0<=DIV)))
				{
					alt18=1;
				}


				} finally { DebugExitDecision(18); }
				switch ( alt18 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:131:14: ( MUL | DIV ) group
					{
					DebugLocation(131, 14);
					set90=(IToken)input.LT(1);
					set90=(IToken)input.LT(1);
					if ((input.LA(1)>=MUL && input.LA(1)<=DIV))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set90), root_0);
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(131, 27);
					PushFollow(Follow._group_in_mul1099);
					group91=group();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group91.Tree);

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
			TraceOut("mul", 31);
			LeaveRule("mul", 31);
			Leave_mul();
			if (state.backtracking > 0) { Memoize(input, 31, mul_StartIndex); }
		}
		DebugLocation(131, 33);
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
	// MathLang.g:132:1: compare : add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )? ;
	[GrammarRule("compare")]
	private MathLangParser.compare_return compare()
	{
		Enter_compare();
		EnterRule("compare", 32);
		TraceIn("compare", 32);
		MathLangParser.compare_return retval = new MathLangParser.compare_return();
		retval.Start = (IToken)input.LT(1);
		int compare_StartIndex = input.Index;
		object root_0 = null;

		IToken set93=null;
		MathLangParser.add_return add92 = default(MathLangParser.add_return);
		MathLangParser.add_return add94 = default(MathLangParser.add_return);

		object set93_tree=null;

		try { DebugEnterRule(GrammarFileName, "compare");
		DebugLocation(132, 60);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 32)) { return retval; }
			// MathLang.g:132:8: ( add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )? )
			DebugEnterAlt(1);
			// MathLang.g:132:10: add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(132, 10);
			PushFollow(Follow._add_in_compare1107);
			add92=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add92.Tree);
			DebugLocation(132, 14);
			// MathLang.g:132:14: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
			int alt19=2;
			try { DebugEnterSubRule(19);
			try { DebugEnterDecision(19, decisionCanBacktrack[19]);
			try
			{
				alt19 = dfa19.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(19); }
			switch (alt19)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:132:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
				{
				DebugLocation(132, 16);
				set93=(IToken)input.LT(1);
				set93=(IToken)input.LT(1);
				if ((input.LA(1)>=GREQ && input.LA(1)<=LS))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set93), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(132, 53);
				PushFollow(Follow._add_in_compare1137);
				add94=add();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add94.Tree);

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
			TraceOut("compare", 32);
			LeaveRule("compare", 32);
			Leave_compare();
			if (state.backtracking > 0) { Memoize(input, 32, compare_StartIndex); }
		}
		DebugLocation(132, 60);
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
	// MathLang.g:133:1: term : add ;
	[GrammarRule("term")]
	private MathLangParser.term_return term()
	{
		Enter_term();
		EnterRule("term", 33);
		TraceIn("term", 33);
		MathLangParser.term_return retval = new MathLangParser.term_return();
		retval.Start = (IToken)input.LT(1);
		int term_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.add_return add95 = default(MathLangParser.add_return);


		try { DebugEnterRule(GrammarFileName, "term");
		DebugLocation(133, 9);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 33)) { return retval; }
			// MathLang.g:133:5: ( add )
			DebugEnterAlt(1);
			// MathLang.g:133:7: add
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(133, 7);
			PushFollow(Follow._add_in_term1148);
			add95=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add95.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("term", 33);
			LeaveRule("term", 33);
			Leave_term();
			if (state.backtracking > 0) { Memoize(input, 33, term_StartIndex); }
		}
		DebugLocation(133, 9);
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
	// MathLang.g:134:1: group : ( ( SUB )? OPEN_BRACE term CLOSE_BRACE | number );
	[GrammarRule("group")]
	private MathLangParser.group_return group()
	{
		Enter_group();
		EnterRule("group", 34);
		TraceIn("group", 34);
		MathLangParser.group_return retval = new MathLangParser.group_return();
		retval.Start = (IToken)input.LT(1);
		int group_StartIndex = input.Index;
		object root_0 = null;

		IToken SUB96=null;
		IToken OPEN_BRACE97=null;
		IToken CLOSE_BRACE99=null;
		MathLangParser.term_return term98 = default(MathLangParser.term_return);
		MathLangParser.number_return number100 = default(MathLangParser.number_return);

		object SUB96_tree=null;
		object OPEN_BRACE97_tree=null;
		object CLOSE_BRACE99_tree=null;

		try { DebugEnterRule(GrammarFileName, "group");
		DebugLocation(134, 53);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 34)) { return retval; }
			// MathLang.g:134:6: ( ( SUB )? OPEN_BRACE term CLOSE_BRACE | number )
			int alt21=2;
			try { DebugEnterDecision(21, decisionCanBacktrack[21]);
			int LA21_0 = input.LA(1);

			if ((LA21_0==SUB||LA21_0==OPEN_BRACE))
			{
				alt21=1;
			}
			else if ((LA21_0==ID||(LA21_0>=NUMBER && LA21_0<=CHAR)))
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
				// MathLang.g:134:8: ( SUB )? OPEN_BRACE term CLOSE_BRACE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(134, 8);
				// MathLang.g:134:8: ( SUB )?
				int alt20=2;
				try { DebugEnterSubRule(20);
				try { DebugEnterDecision(20, decisionCanBacktrack[20]);
				int LA20_0 = input.LA(1);

				if ((LA20_0==SUB))
				{
					alt20=1;
				}
				} finally { DebugExitDecision(20); }
				switch (alt20)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:134:9: SUB
					{
					DebugLocation(134, 12);
					SUB96=(IToken)Match(input,SUB,Follow._SUB_in_group1155); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					SUB96_tree = (object)adaptor.Create(SUB96);
					root_0 = (object)adaptor.BecomeRoot(SUB96_tree, root_0);
					}

					}
					break;

				}
				} finally { DebugExitSubRule(20); }

				DebugLocation(134, 26);
				OPEN_BRACE97=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_group1160); if (state.failed) return retval;
				DebugLocation(134, 28);
				PushFollow(Follow._term_in_group1163);
				term98=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term98.Tree);
				DebugLocation(134, 44);
				CLOSE_BRACE99=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_group1165); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:134:48: number
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(134, 48);
				PushFollow(Follow._number_in_group1170);
				number100=number();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, number100.Tree);

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
			TraceOut("group", 34);
			LeaveRule("group", 34);
			Leave_group();
			if (state.backtracking > 0) { Memoize(input, 34, group_StartIndex); }
		}
		DebugLocation(134, 53);
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
	// MathLang.g:136:1: assignment : assignmentbody ';' ;
	[GrammarRule("assignment")]
	private MathLangParser.assignment_return assignment()
	{
		Enter_assignment();
		EnterRule("assignment", 35);
		TraceIn("assignment", 35);
		MathLangParser.assignment_return retval = new MathLangParser.assignment_return();
		retval.Start = (IToken)input.LT(1);
		int assignment_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal102=null;
		MathLangParser.assignmentbody_return assignmentbody101 = default(MathLangParser.assignmentbody_return);

		object char_literal102_tree=null;

		try { DebugEnterRule(GrammarFileName, "assignment");
		DebugLocation(136, 31);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 35)) { return retval; }
			// MathLang.g:136:11: ( assignmentbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:136:13: assignmentbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(136, 13);
			PushFollow(Follow._assignmentbody_in_assignment1177);
			assignmentbody101=assignmentbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentbody101.Tree);
			DebugLocation(136, 31);
			char_literal102=(IToken)Match(input,71,Follow._71_in_assignment1179); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("assignment", 35);
			LeaveRule("assignment", 35);
			Leave_assignment();
			if (state.backtracking > 0) { Memoize(input, 35, assignment_StartIndex); }
		}
		DebugLocation(136, 31);
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
	// MathLang.g:137:1: assignmentbody : ( ( extended_id ASSIGN expression -> ^( VARASSIGNMENT extended_id expression ) ) | ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) ) );
	[GrammarRule("assignmentbody")]
	private MathLangParser.assignmentbody_return assignmentbody()
	{
		Enter_assignmentbody();
		EnterRule("assignmentbody", 36);
		TraceIn("assignmentbody", 36);
		MathLangParser.assignmentbody_return retval = new MathLangParser.assignmentbody_return();
		retval.Start = (IToken)input.LT(1);
		int assignmentbody_StartIndex = input.Index;
		object root_0 = null;

		IToken ASSIGN104=null;
		IToken ASSIGN107=null;
		MathLangParser.extended_id_return extended_id103 = default(MathLangParser.extended_id_return);
		MathLangParser.expression_return expression105 = default(MathLangParser.expression_return);
		MathLangParser.arrayelement_return arrayelement106 = default(MathLangParser.arrayelement_return);
		MathLangParser.expression_return expression108 = default(MathLangParser.expression_return);

		object ASSIGN104_tree=null;
		object ASSIGN107_tree=null;
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_extended_id=new RewriteRuleSubtreeStream(adaptor,"rule extended_id");
		RewriteRuleSubtreeStream stream_arrayelement=new RewriteRuleSubtreeStream(adaptor,"rule arrayelement");
		try { DebugEnterRule(GrammarFileName, "assignmentbody");
		DebugLocation(137, 87);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 36)) { return retval; }
			// MathLang.g:137:15: ( ( extended_id ASSIGN expression -> ^( VARASSIGNMENT extended_id expression ) ) | ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) ) )
			int alt22=2;
			try { DebugEnterDecision(22, decisionCanBacktrack[22]);
			int LA22_0 = input.LA(1);

			if ((LA22_0==ID))
			{
				switch (input.LA(2))
				{
				case DOT:
					{
					int LA22_2 = input.LA(3);

					if ((LA22_2==ID))
					{
						int LA22_5 = input.LA(4);

						if ((LA22_5==ASSIGN))
						{
							alt22=1;
						}
						else if ((LA22_5==OPEN_SQUARE_BRACE))
						{
							alt22=2;
						}
						else
						{
							if (state.backtracking>0) {state.failed=true; return retval;}
							NoViableAltException nvae = new NoViableAltException("", 22, 5, input);

							DebugRecognitionException(nvae);
							throw nvae;
						}
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 22, 2, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
					}
					break;
				case ASSIGN:
					{
					alt22=1;
					}
					break;
				case OPEN_SQUARE_BRACE:
					{
					alt22=2;
					}
					break;
				default:
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 22, 1, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}

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
				// MathLang.g:137:17: ( extended_id ASSIGN expression -> ^( VARASSIGNMENT extended_id expression ) )
				{
				DebugLocation(137, 17);
				// MathLang.g:137:17: ( extended_id ASSIGN expression -> ^( VARASSIGNMENT extended_id expression ) )
				DebugEnterAlt(1);
				// MathLang.g:137:18: extended_id ASSIGN expression
				{
				DebugLocation(137, 18);
				PushFollow(Follow._extended_id_in_assignmentbody1187);
				extended_id103=extended_id();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_extended_id.Add(extended_id103.Tree);
				DebugLocation(137, 30);
				ASSIGN104=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignmentbody1189); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN104);

				DebugLocation(137, 37);
				PushFollow(Follow._expression_in_assignmentbody1191);
				expression105=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression105.Tree);


				{
				// AST REWRITE
				// elements: expression, extended_id
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 137:48: -> ^( VARASSIGNMENT extended_id expression )
				{
					DebugLocation(137, 51);
					// MathLang.g:137:51: ^( VARASSIGNMENT extended_id expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(137, 53);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARASSIGNMENT, "VARASSIGNMENT"), root_1);

					DebugLocation(137, 67);
					adaptor.AddChild(root_1, stream_extended_id.NextTree());
					DebugLocation(137, 79);
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
				// MathLang.g:138:2: ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) )
				{
				DebugLocation(138, 2);
				// MathLang.g:138:2: ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) )
				DebugEnterAlt(1);
				// MathLang.g:138:4: arrayelement ASSIGN expression
				{
				DebugLocation(138, 4);
				PushFollow(Follow._arrayelement_in_assignmentbody1210);
				arrayelement106=arrayelement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_arrayelement.Add(arrayelement106.Tree);
				DebugLocation(138, 17);
				ASSIGN107=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignmentbody1212); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN107);

				DebugLocation(138, 24);
				PushFollow(Follow._expression_in_assignmentbody1214);
				expression108=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression108.Tree);


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
				// 138:35: -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression )
				{
					DebugLocation(138, 38);
					// MathLang.g:138:38: ^( ARRAYELEMENTASSIGNMENT arrayelement expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(138, 40);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYELEMENTASSIGNMENT, "ARRAYELEMENTASSIGNMENT"), root_1);

					DebugLocation(138, 63);
					adaptor.AddChild(root_1, stream_arrayelement.NextTree());
					DebugLocation(138, 76);
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
			TraceOut("assignmentbody", 36);
			LeaveRule("assignmentbody", 36);
			Leave_assignmentbody();
			if (state.backtracking > 0) { Memoize(input, 36, assignmentbody_StartIndex); }
		}
		DebugLocation(138, 87);
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
	// MathLang.g:140:1: boolexpression : boolterm ;
	[GrammarRule("boolexpression")]
	private MathLangParser.boolexpression_return boolexpression()
	{
		Enter_boolexpression();
		EnterRule("boolexpression", 37);
		TraceIn("boolexpression", 37);
		MathLangParser.boolexpression_return retval = new MathLangParser.boolexpression_return();
		retval.Start = (IToken)input.LT(1);
		int boolexpression_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.boolterm_return boolterm109 = default(MathLangParser.boolterm_return);


		try { DebugEnterRule(GrammarFileName, "boolexpression");
		DebugLocation(140, 25);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 37)) { return retval; }
			// MathLang.g:140:15: ( boolterm )
			DebugEnterAlt(1);
			// MathLang.g:140:17: boolterm
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(140, 17);
			PushFollow(Follow._boolterm_in_boolexpression1232);
			boolterm109=boolterm();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm109.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("boolexpression", 37);
			LeaveRule("boolexpression", 37);
			Leave_boolexpression();
			if (state.backtracking > 0) { Memoize(input, 37, boolexpression_StartIndex); }
		}
		DebugLocation(140, 25);
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
	// MathLang.g:141:1: boolterm : or ( ( EQ | NEQ ) or )? ;
	[GrammarRule("boolterm")]
	private MathLangParser.boolterm_return boolterm()
	{
		Enter_boolterm();
		EnterRule("boolterm", 38);
		TraceIn("boolterm", 38);
		MathLangParser.boolterm_return retval = new MathLangParser.boolterm_return();
		retval.Start = (IToken)input.LT(1);
		int boolterm_StartIndex = input.Index;
		object root_0 = null;

		IToken set111=null;
		MathLangParser.or_return or110 = default(MathLangParser.or_return);
		MathLangParser.or_return or112 = default(MathLangParser.or_return);

		object set111_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolterm");
		DebugLocation(141, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 38)) { return retval; }
			// MathLang.g:141:9: ( or ( ( EQ | NEQ ) or )? )
			DebugEnterAlt(1);
			// MathLang.g:141:11: or ( ( EQ | NEQ ) or )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(141, 11);
			PushFollow(Follow._or_in_boolterm1239);
			or110=or();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or110.Tree);
			DebugLocation(141, 14);
			// MathLang.g:141:14: ( ( EQ | NEQ ) or )?
			int alt23=2;
			try { DebugEnterSubRule(23);
			try { DebugEnterDecision(23, decisionCanBacktrack[23]);
			int LA23_0 = input.LA(1);

			if (((LA23_0>=NEQ && LA23_0<=EQ)))
			{
				alt23=1;
			}
			} finally { DebugExitDecision(23); }
			switch (alt23)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:141:16: ( EQ | NEQ ) or
				{
				DebugLocation(141, 16);
				set111=(IToken)input.LT(1);
				set111=(IToken)input.LT(1);
				if ((input.LA(1)>=NEQ && input.LA(1)<=EQ))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set111), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(141, 28);
				PushFollow(Follow._or_in_boolterm1252);
				or112=or();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or112.Tree);

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
			TraceOut("boolterm", 38);
			LeaveRule("boolterm", 38);
			Leave_boolterm();
			if (state.backtracking > 0) { Memoize(input, 38, boolterm_StartIndex); }
		}
		DebugLocation(141, 32);
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
	// MathLang.g:142:1: or : and ( OR and )* ;
	[GrammarRule("or")]
	private MathLangParser.or_return or()
	{
		Enter_or();
		EnterRule("or", 39);
		TraceIn("or", 39);
		MathLangParser.or_return retval = new MathLangParser.or_return();
		retval.Start = (IToken)input.LT(1);
		int or_StartIndex = input.Index;
		object root_0 = null;

		IToken OR114=null;
		MathLangParser.and_return and113 = default(MathLangParser.and_return);
		MathLangParser.and_return and115 = default(MathLangParser.and_return);

		object OR114_tree=null;

		try { DebugEnterRule(GrammarFileName, "or");
		DebugLocation(142, 18);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 39)) { return retval; }
			// MathLang.g:142:3: ( and ( OR and )* )
			DebugEnterAlt(1);
			// MathLang.g:142:5: and ( OR and )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(142, 5);
			PushFollow(Follow._and_in_or1261);
			and113=and();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and113.Tree);
			DebugLocation(142, 9);
			// MathLang.g:142:9: ( OR and )*
			try { DebugEnterSubRule(24);
			while (true)
			{
				int alt24=2;
				try { DebugEnterDecision(24, decisionCanBacktrack[24]);
				int LA24_0 = input.LA(1);

				if ((LA24_0==OR))
				{
					alt24=1;
				}


				} finally { DebugExitDecision(24); }
				switch ( alt24 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:142:10: OR and
					{
					DebugLocation(142, 12);
					OR114=(IToken)Match(input,OR,Follow._OR_in_or1264); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR114_tree = (object)adaptor.Create(OR114);
					root_0 = (object)adaptor.BecomeRoot(OR114_tree, root_0);
					}
					DebugLocation(142, 14);
					PushFollow(Follow._and_in_or1267);
					and115=and();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and115.Tree);

					}
					break;

				default:
					goto loop24;
				}
			}

			loop24:
				;

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
			TraceOut("or", 39);
			LeaveRule("or", 39);
			Leave_or();
			if (state.backtracking > 0) { Memoize(input, 39, or_StartIndex); }
		}
		DebugLocation(142, 18);
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
	// MathLang.g:143:1: and : boolgroup ( AND boolgroup )* ;
	[GrammarRule("and")]
	private MathLangParser.and_return and()
	{
		Enter_and();
		EnterRule("and", 40);
		TraceIn("and", 40);
		MathLangParser.and_return retval = new MathLangParser.and_return();
		retval.Start = (IToken)input.LT(1);
		int and_StartIndex = input.Index;
		object root_0 = null;

		IToken AND117=null;
		MathLangParser.boolgroup_return boolgroup116 = default(MathLangParser.boolgroup_return);
		MathLangParser.boolgroup_return boolgroup118 = default(MathLangParser.boolgroup_return);

		object AND117_tree=null;

		try { DebugEnterRule(GrammarFileName, "and");
		DebugLocation(143, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 40)) { return retval; }
			// MathLang.g:143:4: ( boolgroup ( AND boolgroup )* )
			DebugEnterAlt(1);
			// MathLang.g:143:6: boolgroup ( AND boolgroup )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(143, 6);
			PushFollow(Follow._boolgroup_in_and1275);
			boolgroup116=boolgroup();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup116.Tree);
			DebugLocation(143, 16);
			// MathLang.g:143:16: ( AND boolgroup )*
			try { DebugEnterSubRule(25);
			while (true)
			{
				int alt25=2;
				try { DebugEnterDecision(25, decisionCanBacktrack[25]);
				int LA25_0 = input.LA(1);

				if ((LA25_0==AND))
				{
					alt25=1;
				}


				} finally { DebugExitDecision(25); }
				switch ( alt25 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:143:17: AND boolgroup
					{
					DebugLocation(143, 20);
					AND117=(IToken)Match(input,AND,Follow._AND_in_and1278); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND117_tree = (object)adaptor.Create(AND117);
					root_0 = (object)adaptor.BecomeRoot(AND117_tree, root_0);
					}
					DebugLocation(143, 22);
					PushFollow(Follow._boolgroup_in_and1281);
					boolgroup118=boolgroup();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup118.Tree);

					}
					break;

				default:
					goto loop25;
				}
			}

			loop25:
				;

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
			TraceOut("and", 40);
			LeaveRule("and", 40);
			Leave_and();
			if (state.backtracking > 0) { Memoize(input, 40, and_StartIndex); }
		}
		DebugLocation(143, 32);
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
	// MathLang.g:144:1: boolgroup : ( NOT )? ( OPEN_BRACE boolterm CLOSE_BRACE | boolvar ) ;
	[GrammarRule("boolgroup")]
	private MathLangParser.boolgroup_return boolgroup()
	{
		Enter_boolgroup();
		EnterRule("boolgroup", 41);
		TraceIn("boolgroup", 41);
		MathLangParser.boolgroup_return retval = new MathLangParser.boolgroup_return();
		retval.Start = (IToken)input.LT(1);
		int boolgroup_StartIndex = input.Index;
		object root_0 = null;

		IToken NOT119=null;
		IToken OPEN_BRACE120=null;
		IToken CLOSE_BRACE122=null;
		MathLangParser.boolterm_return boolterm121 = default(MathLangParser.boolterm_return);
		MathLangParser.boolvar_return boolvar123 = default(MathLangParser.boolvar_return);

		object NOT119_tree=null;
		object OPEN_BRACE120_tree=null;
		object CLOSE_BRACE122_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolgroup");
		DebugLocation(144, 66);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 41)) { return retval; }
			// MathLang.g:144:10: ( ( NOT )? ( OPEN_BRACE boolterm CLOSE_BRACE | boolvar ) )
			DebugEnterAlt(1);
			// MathLang.g:144:12: ( NOT )? ( OPEN_BRACE boolterm CLOSE_BRACE | boolvar )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(144, 12);
			// MathLang.g:144:12: ( NOT )?
			int alt26=2;
			try { DebugEnterSubRule(26);
			try { DebugEnterDecision(26, decisionCanBacktrack[26]);
			int LA26_0 = input.LA(1);

			if ((LA26_0==NOT))
			{
				alt26=1;
			}
			} finally { DebugExitDecision(26); }
			switch (alt26)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:144:13: NOT
				{
				DebugLocation(144, 16);
				NOT119=(IToken)Match(input,NOT,Follow._NOT_in_boolgroup1290); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				NOT119_tree = (object)adaptor.Create(NOT119);
				root_0 = (object)adaptor.BecomeRoot(NOT119_tree, root_0);
				}

				}
				break;

			}
			} finally { DebugExitSubRule(26); }

			DebugLocation(144, 20);
			// MathLang.g:144:20: ( OPEN_BRACE boolterm CLOSE_BRACE | boolvar )
			int alt27=2;
			try { DebugEnterSubRule(27);
			try { DebugEnterDecision(27, decisionCanBacktrack[27]);
			int LA27_0 = input.LA(1);

			if ((LA27_0==OPEN_BRACE))
			{
				int LA27_1 = input.LA(2);

				if ((EvaluatePredicate(synpred48_MathLang_fragment)))
				{
					alt27=1;
				}
				else if ((true))
				{
					alt27=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 27, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else if ((LA27_0==ID||(LA27_0>=NUMBER && LA27_0<=CHAR)||LA27_0==SUB||(LA27_0>=TRUE && LA27_0<=FALSE)))
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
				// MathLang.g:144:22: OPEN_BRACE boolterm CLOSE_BRACE
				{
				DebugLocation(144, 32);
				OPEN_BRACE120=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_boolgroup1297); if (state.failed) return retval;
				DebugLocation(144, 34);
				PushFollow(Follow._boolterm_in_boolgroup1300);
				boolterm121=boolterm();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm121.Tree);
				DebugLocation(144, 54);
				CLOSE_BRACE122=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_boolgroup1302); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:144:58: boolvar
				{
				DebugLocation(144, 58);
				PushFollow(Follow._boolvar_in_boolgroup1307);
				boolvar123=boolvar();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolvar123.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(27); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("boolgroup", 41);
			LeaveRule("boolgroup", 41);
			Leave_boolgroup();
			if (state.backtracking > 0) { Memoize(input, 41, boolgroup_StartIndex); }
		}
		DebugLocation(144, 66);
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
	// MathLang.g:145:1: boolvar : ( TRUE | FALSE | compare );
	[GrammarRule("boolvar")]
	private MathLangParser.boolvar_return boolvar()
	{
		Enter_boolvar();
		EnterRule("boolvar", 42);
		TraceIn("boolvar", 42);
		MathLangParser.boolvar_return retval = new MathLangParser.boolvar_return();
		retval.Start = (IToken)input.LT(1);
		int boolvar_StartIndex = input.Index;
		object root_0 = null;

		IToken TRUE124=null;
		IToken FALSE125=null;
		MathLangParser.compare_return compare126 = default(MathLangParser.compare_return);

		object TRUE124_tree=null;
		object FALSE125_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolvar");
		DebugLocation(145, 11);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 42)) { return retval; }
			// MathLang.g:145:8: ( TRUE | FALSE | compare )
			int alt28=3;
			try { DebugEnterDecision(28, decisionCanBacktrack[28]);
			switch (input.LA(1))
			{
			case TRUE:
				{
				alt28=1;
				}
				break;
			case FALSE:
				{
				alt28=2;
				}
				break;
			case ID:
			case NUMBER:
			case CHAR:
			case SUB:
			case OPEN_BRACE:
				{
				alt28=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 28, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(28); }
			switch (alt28)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:145:10: TRUE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(145, 10);
				TRUE124=(IToken)Match(input,TRUE,Follow._TRUE_in_boolvar1315); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				TRUE124_tree = (object)adaptor.Create(TRUE124);
				adaptor.AddChild(root_0, TRUE124_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:146:5: FALSE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(146, 5);
				FALSE125=(IToken)Match(input,FALSE,Follow._FALSE_in_boolvar1321); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				FALSE125_tree = (object)adaptor.Create(FALSE125);
				adaptor.AddChild(root_0, FALSE125_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:147:5: compare
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(147, 5);
				PushFollow(Follow._compare_in_boolvar1327);
				compare126=compare();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare126.Tree);

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
			TraceOut("boolvar", 42);
			LeaveRule("boolvar", 42);
			Leave_boolvar();
			if (state.backtracking > 0) { Memoize(input, 42, boolvar_StartIndex); }
		}
		DebugLocation(147, 11);
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
	// MathLang.g:149:1: ifstatement : IF OPEN_BRACE boolexpression CLOSE_BRACE ( block | statement ) ( ELSE ( block | statement ) )* ;
	[GrammarRule("ifstatement")]
	private MathLangParser.ifstatement_return ifstatement()
	{
		Enter_ifstatement();
		EnterRule("ifstatement", 43);
		TraceIn("ifstatement", 43);
		MathLangParser.ifstatement_return retval = new MathLangParser.ifstatement_return();
		retval.Start = (IToken)input.LT(1);
		int ifstatement_StartIndex = input.Index;
		object root_0 = null;

		IToken IF127=null;
		IToken OPEN_BRACE128=null;
		IToken CLOSE_BRACE130=null;
		IToken ELSE133=null;
		MathLangParser.boolexpression_return boolexpression129 = default(MathLangParser.boolexpression_return);
		MathLangParser.block_return block131 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement132 = default(MathLangParser.statement_return);
		MathLangParser.block_return block134 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement135 = default(MathLangParser.statement_return);

		object IF127_tree=null;
		object OPEN_BRACE128_tree=null;
		object CLOSE_BRACE130_tree=null;
		object ELSE133_tree=null;

		try { DebugEnterRule(GrammarFileName, "ifstatement");
		DebugLocation(149, 106);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 43)) { return retval; }
			// MathLang.g:149:12: ( IF OPEN_BRACE boolexpression CLOSE_BRACE ( block | statement ) ( ELSE ( block | statement ) )* )
			DebugEnterAlt(1);
			// MathLang.g:149:14: IF OPEN_BRACE boolexpression CLOSE_BRACE ( block | statement ) ( ELSE ( block | statement ) )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(149, 16);
			IF127=(IToken)Match(input,IF,Follow._IF_in_ifstatement1336); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			IF127_tree = (object)adaptor.Create(IF127);
			root_0 = (object)adaptor.BecomeRoot(IF127_tree, root_0);
			}
			DebugLocation(149, 28);
			OPEN_BRACE128=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_ifstatement1339); if (state.failed) return retval;
			DebugLocation(149, 30);
			PushFollow(Follow._boolexpression_in_ifstatement1342);
			boolexpression129=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression129.Tree);
			DebugLocation(149, 56);
			CLOSE_BRACE130=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_ifstatement1344); if (state.failed) return retval;
			DebugLocation(149, 58);
			// MathLang.g:149:58: ( block | statement )
			int alt29=2;
			try { DebugEnterSubRule(29);
			try { DebugEnterDecision(29, decisionCanBacktrack[29]);
			int LA29_0 = input.LA(1);

			if ((LA29_0==69))
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
				// MathLang.g:149:59: block
				{
				DebugLocation(149, 59);
				PushFollow(Follow._block_in_ifstatement1348);
				block131=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block131.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:149:67: statement
				{
				DebugLocation(149, 67);
				PushFollow(Follow._statement_in_ifstatement1352);
				statement132=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement132.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(29); }

			DebugLocation(149, 78);
			// MathLang.g:149:78: ( ELSE ( block | statement ) )*
			try { DebugEnterSubRule(31);
			while (true)
			{
				int alt31=2;
				try { DebugEnterDecision(31, decisionCanBacktrack[31]);
				int LA31_0 = input.LA(1);

				if ((LA31_0==ELSE))
				{
					int LA31_1 = input.LA(2);

					if ((EvaluatePredicate(synpred53_MathLang_fragment)))
					{
						alt31=1;
					}


				}


				} finally { DebugExitDecision(31); }
				switch ( alt31 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:149:79: ELSE ( block | statement )
					{
					DebugLocation(149, 83);
					ELSE133=(IToken)Match(input,ELSE,Follow._ELSE_in_ifstatement1356); if (state.failed) return retval;
					DebugLocation(149, 85);
					// MathLang.g:149:85: ( block | statement )
					int alt30=2;
					try { DebugEnterSubRule(30);
					try { DebugEnterDecision(30, decisionCanBacktrack[30]);
					int LA30_0 = input.LA(1);

					if ((LA30_0==69))
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
						// MathLang.g:149:86: block
						{
						DebugLocation(149, 86);
						PushFollow(Follow._block_in_ifstatement1360);
						block134=block();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block134.Tree);

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// MathLang.g:149:94: statement
						{
						DebugLocation(149, 94);
						PushFollow(Follow._statement_in_ifstatement1364);
						statement135=statement();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement135.Tree);

						}
						break;

					}
					} finally { DebugExitSubRule(30); }


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
			TraceOut("ifstatement", 43);
			LeaveRule("ifstatement", 43);
			Leave_ifstatement();
			if (state.backtracking > 0) { Memoize(input, 43, ifstatement_StartIndex); }
		}
		DebugLocation(149, 106);
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
	// MathLang.g:150:1: whilestatement : WHILE OPEN_BRACE boolexpression CLOSE_BRACE ( block | statement ) ;
	[GrammarRule("whilestatement")]
	private MathLangParser.whilestatement_return whilestatement()
	{
		Enter_whilestatement();
		EnterRule("whilestatement", 44);
		TraceIn("whilestatement", 44);
		MathLangParser.whilestatement_return retval = new MathLangParser.whilestatement_return();
		retval.Start = (IToken)input.LT(1);
		int whilestatement_StartIndex = input.Index;
		object root_0 = null;

		IToken WHILE136=null;
		IToken OPEN_BRACE137=null;
		IToken CLOSE_BRACE139=null;
		MathLangParser.boolexpression_return boolexpression138 = default(MathLangParser.boolexpression_return);
		MathLangParser.block_return block140 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement141 = default(MathLangParser.statement_return);

		object WHILE136_tree=null;
		object OPEN_BRACE137_tree=null;
		object CLOSE_BRACE139_tree=null;

		try { DebugEnterRule(GrammarFileName, "whilestatement");
		DebugLocation(150, 82);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 44)) { return retval; }
			// MathLang.g:150:15: ( WHILE OPEN_BRACE boolexpression CLOSE_BRACE ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:150:17: WHILE OPEN_BRACE boolexpression CLOSE_BRACE ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(150, 22);
			WHILE136=(IToken)Match(input,WHILE,Follow._WHILE_in_whilestatement1374); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			WHILE136_tree = (object)adaptor.Create(WHILE136);
			root_0 = (object)adaptor.BecomeRoot(WHILE136_tree, root_0);
			}
			DebugLocation(150, 34);
			OPEN_BRACE137=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_whilestatement1377); if (state.failed) return retval;
			DebugLocation(150, 36);
			PushFollow(Follow._boolexpression_in_whilestatement1380);
			boolexpression138=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression138.Tree);
			DebugLocation(150, 62);
			CLOSE_BRACE139=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_whilestatement1382); if (state.failed) return retval;
			DebugLocation(150, 64);
			// MathLang.g:150:64: ( block | statement )
			int alt32=2;
			try { DebugEnterSubRule(32);
			try { DebugEnterDecision(32, decisionCanBacktrack[32]);
			int LA32_0 = input.LA(1);

			if ((LA32_0==69))
			{
				alt32=1;
			}
			else if ((LA32_0==IF||LA32_0==FOR||(LA32_0>=RETURN && LA32_0<=DO)||(LA32_0>=ID && LA32_0<=TYPE)||LA32_0==KNEW))
			{
				alt32=2;
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
				// MathLang.g:150:65: block
				{
				DebugLocation(150, 65);
				PushFollow(Follow._block_in_whilestatement1386);
				block140=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block140.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:150:73: statement
				{
				DebugLocation(150, 73);
				PushFollow(Follow._statement_in_whilestatement1390);
				statement141=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement141.Tree);

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
			TraceOut("whilestatement", 44);
			LeaveRule("whilestatement", 44);
			Leave_whilestatement();
			if (state.backtracking > 0) { Memoize(input, 44, whilestatement_StartIndex); }
		}
		DebugLocation(150, 82);
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
	// MathLang.g:151:1: forstatement : FOR OPEN_BRACE longdeclarationbody ';' boolexpression ';' assignmentbody CLOSE_BRACE ( block | statement ) ;
	[GrammarRule("forstatement")]
	private MathLangParser.forstatement_return forstatement()
	{
		Enter_forstatement();
		EnterRule("forstatement", 45);
		TraceIn("forstatement", 45);
		MathLangParser.forstatement_return retval = new MathLangParser.forstatement_return();
		retval.Start = (IToken)input.LT(1);
		int forstatement_StartIndex = input.Index;
		object root_0 = null;

		IToken FOR142=null;
		IToken OPEN_BRACE143=null;
		IToken char_literal145=null;
		IToken char_literal147=null;
		IToken CLOSE_BRACE149=null;
		MathLangParser.longdeclarationbody_return longdeclarationbody144 = default(MathLangParser.longdeclarationbody_return);
		MathLangParser.boolexpression_return boolexpression146 = default(MathLangParser.boolexpression_return);
		MathLangParser.assignmentbody_return assignmentbody148 = default(MathLangParser.assignmentbody_return);
		MathLangParser.block_return block150 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement151 = default(MathLangParser.statement_return);

		object FOR142_tree=null;
		object OPEN_BRACE143_tree=null;
		object char_literal145_tree=null;
		object char_literal147_tree=null;
		object CLOSE_BRACE149_tree=null;

		try { DebugEnterRule(GrammarFileName, "forstatement");
		DebugLocation(151, 123);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 45)) { return retval; }
			// MathLang.g:151:13: ( FOR OPEN_BRACE longdeclarationbody ';' boolexpression ';' assignmentbody CLOSE_BRACE ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:151:15: FOR OPEN_BRACE longdeclarationbody ';' boolexpression ';' assignmentbody CLOSE_BRACE ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(151, 18);
			FOR142=(IToken)Match(input,FOR,Follow._FOR_in_forstatement1397); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			FOR142_tree = (object)adaptor.Create(FOR142);
			root_0 = (object)adaptor.BecomeRoot(FOR142_tree, root_0);
			}
			DebugLocation(151, 30);
			OPEN_BRACE143=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_forstatement1400); if (state.failed) return retval;
			DebugLocation(151, 32);
			PushFollow(Follow._longdeclarationbody_in_forstatement1403);
			longdeclarationbody144=longdeclarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclarationbody144.Tree);
			DebugLocation(151, 55);
			char_literal145=(IToken)Match(input,71,Follow._71_in_forstatement1405); if (state.failed) return retval;
			DebugLocation(151, 57);
			PushFollow(Follow._boolexpression_in_forstatement1408);
			boolexpression146=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression146.Tree);
			DebugLocation(151, 75);
			char_literal147=(IToken)Match(input,71,Follow._71_in_forstatement1410); if (state.failed) return retval;
			DebugLocation(151, 77);
			PushFollow(Follow._assignmentbody_in_forstatement1413);
			assignmentbody148=assignmentbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentbody148.Tree);
			DebugLocation(151, 103);
			CLOSE_BRACE149=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_forstatement1415); if (state.failed) return retval;
			DebugLocation(151, 105);
			// MathLang.g:151:105: ( block | statement )
			int alt33=2;
			try { DebugEnterSubRule(33);
			try { DebugEnterDecision(33, decisionCanBacktrack[33]);
			int LA33_0 = input.LA(1);

			if ((LA33_0==69))
			{
				alt33=1;
			}
			else if ((LA33_0==IF||LA33_0==FOR||(LA33_0>=RETURN && LA33_0<=DO)||(LA33_0>=ID && LA33_0<=TYPE)||LA33_0==KNEW))
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
				// MathLang.g:151:106: block
				{
				DebugLocation(151, 106);
				PushFollow(Follow._block_in_forstatement1419);
				block150=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block150.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:151:114: statement
				{
				DebugLocation(151, 114);
				PushFollow(Follow._statement_in_forstatement1423);
				statement151=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement151.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(33); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("forstatement", 45);
			LeaveRule("forstatement", 45);
			Leave_forstatement();
			if (state.backtracking > 0) { Memoize(input, 45, forstatement_StartIndex); }
		}
		DebugLocation(151, 123);
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
	// MathLang.g:152:1: returnstatement : RETURN expression ';' ;
	[GrammarRule("returnstatement")]
	private MathLangParser.returnstatement_return returnstatement()
	{
		Enter_returnstatement();
		EnterRule("returnstatement", 46);
		TraceIn("returnstatement", 46);
		MathLangParser.returnstatement_return retval = new MathLangParser.returnstatement_return();
		retval.Start = (IToken)input.LT(1);
		int returnstatement_StartIndex = input.Index;
		object root_0 = null;

		IToken RETURN152=null;
		IToken char_literal154=null;
		MathLangParser.expression_return expression153 = default(MathLangParser.expression_return);

		object RETURN152_tree=null;
		object char_literal154_tree=null;

		try { DebugEnterRule(GrammarFileName, "returnstatement");
		DebugLocation(152, 41);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 46)) { return retval; }
			// MathLang.g:152:16: ( RETURN expression ';' )
			DebugEnterAlt(1);
			// MathLang.g:152:18: RETURN expression ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(152, 24);
			RETURN152=(IToken)Match(input,RETURN,Follow._RETURN_in_returnstatement1430); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			RETURN152_tree = (object)adaptor.Create(RETURN152);
			root_0 = (object)adaptor.BecomeRoot(RETURN152_tree, root_0);
			}
			DebugLocation(152, 26);
			PushFollow(Follow._expression_in_returnstatement1433);
			expression153=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression153.Tree);
			DebugLocation(152, 40);
			char_literal154=(IToken)Match(input,71,Follow._71_in_returnstatement1435); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("returnstatement", 46);
			LeaveRule("returnstatement", 46);
			Leave_returnstatement();
			if (state.backtracking > 0) { Memoize(input, 46, returnstatement_StartIndex); }
		}
		DebugLocation(152, 41);
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
	// MathLang.g:153:1: dowhilestatement : DO ( block | statement ) WHILE OPEN_BRACE boolexpression CLOSE_BRACE ';' ;
	[GrammarRule("dowhilestatement")]
	private MathLangParser.dowhilestatement_return dowhilestatement()
	{
		Enter_dowhilestatement();
		EnterRule("dowhilestatement", 47);
		TraceIn("dowhilestatement", 47);
		MathLangParser.dowhilestatement_return retval = new MathLangParser.dowhilestatement_return();
		retval.Start = (IToken)input.LT(1);
		int dowhilestatement_StartIndex = input.Index;
		object root_0 = null;

		IToken DO155=null;
		IToken WHILE158=null;
		IToken OPEN_BRACE159=null;
		IToken CLOSE_BRACE161=null;
		IToken char_literal162=null;
		MathLangParser.block_return block156 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement157 = default(MathLangParser.statement_return);
		MathLangParser.boolexpression_return boolexpression160 = default(MathLangParser.boolexpression_return);

		object DO155_tree=null;
		object WHILE158_tree=null;
		object OPEN_BRACE159_tree=null;
		object CLOSE_BRACE161_tree=null;
		object char_literal162_tree=null;

		try { DebugEnterRule(GrammarFileName, "dowhilestatement");
		DebugLocation(153, 94);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 47)) { return retval; }
			// MathLang.g:153:17: ( DO ( block | statement ) WHILE OPEN_BRACE boolexpression CLOSE_BRACE ';' )
			DebugEnterAlt(1);
			// MathLang.g:153:19: DO ( block | statement ) WHILE OPEN_BRACE boolexpression CLOSE_BRACE ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(153, 21);
			DO155=(IToken)Match(input,DO,Follow._DO_in_dowhilestatement1443); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			DO155_tree = (object)adaptor.Create(DO155);
			root_0 = (object)adaptor.BecomeRoot(DO155_tree, root_0);
			}
			DebugLocation(153, 23);
			// MathLang.g:153:23: ( block | statement )
			int alt34=2;
			try { DebugEnterSubRule(34);
			try { DebugEnterDecision(34, decisionCanBacktrack[34]);
			int LA34_0 = input.LA(1);

			if ((LA34_0==69))
			{
				alt34=1;
			}
			else if ((LA34_0==IF||LA34_0==FOR||(LA34_0>=RETURN && LA34_0<=DO)||(LA34_0>=ID && LA34_0<=TYPE)||LA34_0==KNEW))
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
				// MathLang.g:153:24: block
				{
				DebugLocation(153, 24);
				PushFollow(Follow._block_in_dowhilestatement1447);
				block156=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block156.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:153:32: statement
				{
				DebugLocation(153, 32);
				PushFollow(Follow._statement_in_dowhilestatement1451);
				statement157=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement157.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(34); }

			DebugLocation(153, 48);
			WHILE158=(IToken)Match(input,WHILE,Follow._WHILE_in_dowhilestatement1454); if (state.failed) return retval;
			DebugLocation(153, 60);
			OPEN_BRACE159=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_dowhilestatement1457); if (state.failed) return retval;
			DebugLocation(153, 62);
			PushFollow(Follow._boolexpression_in_dowhilestatement1460);
			boolexpression160=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression160.Tree);
			DebugLocation(153, 88);
			CLOSE_BRACE161=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_dowhilestatement1462); if (state.failed) return retval;
			DebugLocation(153, 93);
			char_literal162=(IToken)Match(input,71,Follow._71_in_dowhilestatement1465); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("dowhilestatement", 47);
			LeaveRule("dowhilestatement", 47);
			Leave_dowhilestatement();
			if (state.backtracking > 0) { Memoize(input, 47, dowhilestatement_StartIndex); }
		}
		DebugLocation(153, 94);
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
	// MathLang.g:155:1: funcdeclaration : MODIFIER any_type ID ( OPEN_BRACE paramsdeclaration CLOSE_BRACE ) block -> ^( FUNCDECLARATION ID ^( RETURN_TYPE any_type ) paramsdeclaration block ) ;
	[GrammarRule("funcdeclaration")]
	private MathLangParser.funcdeclaration_return funcdeclaration()
	{
		Enter_funcdeclaration();
		EnterRule("funcdeclaration", 48);
		TraceIn("funcdeclaration", 48);
		MathLangParser.funcdeclaration_return retval = new MathLangParser.funcdeclaration_return();
		retval.Start = (IToken)input.LT(1);
		int funcdeclaration_StartIndex = input.Index;
		object root_0 = null;

		IToken MODIFIER163=null;
		IToken ID165=null;
		IToken OPEN_BRACE166=null;
		IToken CLOSE_BRACE168=null;
		MathLangParser.any_type_return any_type164 = default(MathLangParser.any_type_return);
		MathLangParser.paramsdeclaration_return paramsdeclaration167 = default(MathLangParser.paramsdeclaration_return);
		MathLangParser.block_return block169 = default(MathLangParser.block_return);

		object MODIFIER163_tree=null;
		object ID165_tree=null;
		object OPEN_BRACE166_tree=null;
		object CLOSE_BRACE168_tree=null;
		RewriteRuleITokenStream stream_CLOSE_BRACE=new RewriteRuleITokenStream(adaptor,"token CLOSE_BRACE");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_OPEN_BRACE=new RewriteRuleITokenStream(adaptor,"token OPEN_BRACE");
		RewriteRuleITokenStream stream_MODIFIER=new RewriteRuleITokenStream(adaptor,"token MODIFIER");
		RewriteRuleSubtreeStream stream_paramsdeclaration=new RewriteRuleSubtreeStream(adaptor,"rule paramsdeclaration");
		RewriteRuleSubtreeStream stream_block=new RewriteRuleSubtreeStream(adaptor,"rule block");
		RewriteRuleSubtreeStream stream_any_type=new RewriteRuleSubtreeStream(adaptor,"rule any_type");
		try { DebugEnterRule(GrammarFileName, "funcdeclaration");
		DebugLocation(155, 189);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 48)) { return retval; }
			// MathLang.g:155:16: ( MODIFIER any_type ID ( OPEN_BRACE paramsdeclaration CLOSE_BRACE ) block -> ^( FUNCDECLARATION ID ^( RETURN_TYPE any_type ) paramsdeclaration block ) )
			DebugEnterAlt(1);
			// MathLang.g:155:18: MODIFIER any_type ID ( OPEN_BRACE paramsdeclaration CLOSE_BRACE ) block
			{
			DebugLocation(155, 18);
			MODIFIER163=(IToken)Match(input,MODIFIER,Follow._MODIFIER_in_funcdeclaration1474); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_MODIFIER.Add(MODIFIER163);

			DebugLocation(155, 27);
			PushFollow(Follow._any_type_in_funcdeclaration1476);
			any_type164=any_type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_any_type.Add(any_type164.Tree);
			DebugLocation(155, 38);
			ID165=(IToken)Match(input,ID,Follow._ID_in_funcdeclaration1478); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID165);

			DebugLocation(155, 40);
			// MathLang.g:155:40: ( OPEN_BRACE paramsdeclaration CLOSE_BRACE )
			DebugEnterAlt(1);
			// MathLang.g:155:42: OPEN_BRACE paramsdeclaration CLOSE_BRACE
			{
			DebugLocation(155, 52);
			OPEN_BRACE166=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_funcdeclaration1483); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OPEN_BRACE.Add(OPEN_BRACE166);

			DebugLocation(155, 54);
			PushFollow(Follow._paramsdeclaration_in_funcdeclaration1486);
			paramsdeclaration167=paramsdeclaration();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_paramsdeclaration.Add(paramsdeclaration167.Tree);
			DebugLocation(155, 83);
			CLOSE_BRACE168=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_funcdeclaration1488); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CLOSE_BRACE.Add(CLOSE_BRACE168);


			}

			DebugLocation(155, 87);
			PushFollow(Follow._block_in_funcdeclaration1493);
			block169=block();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_block.Add(block169.Tree);


			{
			// AST REWRITE
			// elements: ID, paramsdeclaration, any_type, block
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 155:93: -> ^( FUNCDECLARATION ID ^( RETURN_TYPE any_type ) paramsdeclaration block )
			{
				DebugLocation(155, 96);
				// MathLang.g:155:96: ^( FUNCDECLARATION ID ^( RETURN_TYPE any_type ) paramsdeclaration block )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(155, 98);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNCDECLARATION, "FUNCDECLARATION"), root_1);

				DebugLocation(155, 114);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(155, 117);
				// MathLang.g:155:117: ^( RETURN_TYPE any_type )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(155, 119);
				root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(RETURN_TYPE, "RETURN_TYPE"), root_2);

				DebugLocation(155, 131);
				adaptor.AddChild(root_2, stream_any_type.NextTree());

				adaptor.AddChild(root_1, root_2);
				}
				DebugLocation(155, 153);
				adaptor.AddChild(root_1, stream_paramsdeclaration.NextTree());
				DebugLocation(155, 184);
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
			TraceOut("funcdeclaration", 48);
			LeaveRule("funcdeclaration", 48);
			Leave_funcdeclaration();
			if (state.backtracking > 0) { Memoize(input, 48, funcdeclaration_StartIndex); }
		}
		DebugLocation(155, 189);
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
	// MathLang.g:156:1: paramsdeclaration : ( declarationbody ( ',' declarationbody )* )? -> ^( PARAMETERS ( declarationbody )* ) ;
	[GrammarRule("paramsdeclaration")]
	private MathLangParser.paramsdeclaration_return paramsdeclaration()
	{
		Enter_paramsdeclaration();
		EnterRule("paramsdeclaration", 49);
		TraceIn("paramsdeclaration", 49);
		MathLangParser.paramsdeclaration_return retval = new MathLangParser.paramsdeclaration_return();
		retval.Start = (IToken)input.LT(1);
		int paramsdeclaration_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal171=null;
		MathLangParser.declarationbody_return declarationbody170 = default(MathLangParser.declarationbody_return);
		MathLangParser.declarationbody_return declarationbody172 = default(MathLangParser.declarationbody_return);

		object char_literal171_tree=null;
		RewriteRuleITokenStream stream_72=new RewriteRuleITokenStream(adaptor,"token 72");
		RewriteRuleSubtreeStream stream_declarationbody=new RewriteRuleSubtreeStream(adaptor,"rule declarationbody");
		try { DebugEnterRule(GrammarFileName, "paramsdeclaration");
		DebugLocation(156, 103);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 49)) { return retval; }
			// MathLang.g:156:18: ( ( declarationbody ( ',' declarationbody )* )? -> ^( PARAMETERS ( declarationbody )* ) )
			DebugEnterAlt(1);
			// MathLang.g:156:20: ( declarationbody ( ',' declarationbody )* )?
			{
			DebugLocation(156, 20);
			// MathLang.g:156:20: ( declarationbody ( ',' declarationbody )* )?
			int alt36=2;
			try { DebugEnterSubRule(36);
			try { DebugEnterDecision(36, decisionCanBacktrack[36]);
			int LA36_0 = input.LA(1);

			if ((LA36_0==TYPE))
			{
				alt36=1;
			}
			} finally { DebugExitDecision(36); }
			switch (alt36)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:156:22: declarationbody ( ',' declarationbody )*
				{
				DebugLocation(156, 22);
				PushFollow(Follow._declarationbody_in_paramsdeclaration1525);
				declarationbody170=declarationbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_declarationbody.Add(declarationbody170.Tree);
				DebugLocation(156, 38);
				// MathLang.g:156:38: ( ',' declarationbody )*
				try { DebugEnterSubRule(35);
				while (true)
				{
					int alt35=2;
					try { DebugEnterDecision(35, decisionCanBacktrack[35]);
					int LA35_0 = input.LA(1);

					if ((LA35_0==72))
					{
						alt35=1;
					}


					} finally { DebugExitDecision(35); }
					switch ( alt35 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:156:40: ',' declarationbody
						{
						DebugLocation(156, 43);
						char_literal171=(IToken)Match(input,72,Follow._72_in_paramsdeclaration1529); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_72.Add(char_literal171);

						DebugLocation(156, 45);
						PushFollow(Follow._declarationbody_in_paramsdeclaration1532);
						declarationbody172=declarationbody();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) stream_declarationbody.Add(declarationbody172.Tree);

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
				break;

			}
			} finally { DebugExitSubRule(36); }



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
			// 156:67: -> ^( PARAMETERS ( declarationbody )* )
			{
				DebugLocation(156, 70);
				// MathLang.g:156:70: ^( PARAMETERS ( declarationbody )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(156, 72);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_1);

				DebugLocation(156, 83);
				// MathLang.g:156:83: ( declarationbody )*
				while ( stream_declarationbody.HasNext )
				{
					DebugLocation(156, 85);
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
			TraceOut("paramsdeclaration", 49);
			LeaveRule("paramsdeclaration", 49);
			Leave_paramsdeclaration();
			if (state.backtracking > 0) { Memoize(input, 49, paramsdeclaration_StartIndex); }
		}
		DebugLocation(156, 103);
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
	// MathLang.g:158:1: funccallbody : extended_id OPEN_BRACE ( expressioncommalist )? CLOSE_BRACE -> ^( FUNC_CALL extended_id ( ^( PARAMETERS expressioncommalist ) )? ) ;
	[GrammarRule("funccallbody")]
	private MathLangParser.funccallbody_return funccallbody()
	{
		Enter_funccallbody();
		EnterRule("funccallbody", 50);
		TraceIn("funccallbody", 50);
		MathLangParser.funccallbody_return retval = new MathLangParser.funccallbody_return();
		retval.Start = (IToken)input.LT(1);
		int funccallbody_StartIndex = input.Index;
		object root_0 = null;

		IToken OPEN_BRACE174=null;
		IToken CLOSE_BRACE176=null;
		MathLangParser.extended_id_return extended_id173 = default(MathLangParser.extended_id_return);
		MathLangParser.expressioncommalist_return expressioncommalist175 = default(MathLangParser.expressioncommalist_return);

		object OPEN_BRACE174_tree=null;
		object CLOSE_BRACE176_tree=null;
		RewriteRuleITokenStream stream_CLOSE_BRACE=new RewriteRuleITokenStream(adaptor,"token CLOSE_BRACE");
		RewriteRuleITokenStream stream_OPEN_BRACE=new RewriteRuleITokenStream(adaptor,"token OPEN_BRACE");
		RewriteRuleSubtreeStream stream_extended_id=new RewriteRuleSubtreeStream(adaptor,"rule extended_id");
		RewriteRuleSubtreeStream stream_expressioncommalist=new RewriteRuleSubtreeStream(adaptor,"rule expressioncommalist");
		try { DebugEnterRule(GrammarFileName, "funccallbody");
		DebugLocation(158, 133);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 50)) { return retval; }
			// MathLang.g:158:13: ( extended_id OPEN_BRACE ( expressioncommalist )? CLOSE_BRACE -> ^( FUNC_CALL extended_id ( ^( PARAMETERS expressioncommalist ) )? ) )
			DebugEnterAlt(1);
			// MathLang.g:158:15: extended_id OPEN_BRACE ( expressioncommalist )? CLOSE_BRACE
			{
			DebugLocation(158, 26);
			PushFollow(Follow._extended_id_in_funccallbody1558);
			extended_id173=extended_id();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_extended_id.Add(extended_id173.Tree);
			DebugLocation(158, 28);
			OPEN_BRACE174=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_funccallbody1561); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OPEN_BRACE.Add(OPEN_BRACE174);

			DebugLocation(158, 39);
			// MathLang.g:158:39: ( expressioncommalist )?
			int alt37=2;
			try { DebugEnterSubRule(37);
			try { DebugEnterDecision(37, decisionCanBacktrack[37]);
			int LA37_0 = input.LA(1);

			if ((LA37_0==ID||(LA37_0>=NUMBER && LA37_0<=CHAR)||LA37_0==SUB||LA37_0==OPEN_BRACE||(LA37_0>=NOT && LA37_0<=KNEW)))
			{
				alt37=1;
			}
			} finally { DebugExitDecision(37); }
			switch (alt37)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: expressioncommalist
				{
				DebugLocation(158, 39);
				PushFollow(Follow._expressioncommalist_in_funccallbody1563);
				expressioncommalist175=expressioncommalist();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expressioncommalist.Add(expressioncommalist175.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(37); }

			DebugLocation(158, 60);
			CLOSE_BRACE176=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_funccallbody1566); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CLOSE_BRACE.Add(CLOSE_BRACE176);



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
			// 158:72: -> ^( FUNC_CALL extended_id ( ^( PARAMETERS expressioncommalist ) )? )
			{
				DebugLocation(158, 75);
				// MathLang.g:158:75: ^( FUNC_CALL extended_id ( ^( PARAMETERS expressioncommalist ) )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(158, 77);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_CALL, "FUNC_CALL"), root_1);

				DebugLocation(158, 87);
				adaptor.AddChild(root_1, stream_extended_id.NextTree());
				DebugLocation(158, 99);
				// MathLang.g:158:99: ( ^( PARAMETERS expressioncommalist ) )?
				if ( stream_expressioncommalist.HasNext )
				{
					DebugLocation(158, 99);
					// MathLang.g:158:99: ^( PARAMETERS expressioncommalist )
					{
					object root_2 = (object)adaptor.Nil();
					DebugLocation(158, 101);
					root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_2);

					DebugLocation(158, 112);
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
			TraceOut("funccallbody", 50);
			LeaveRule("funccallbody", 50);
			Leave_funccallbody();
			if (state.backtracking > 0) { Memoize(input, 50, funccallbody_StartIndex); }
		}
		DebugLocation(158, 133);
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
	// MathLang.g:159:1: funccall : funccallbody ';' ;
	[GrammarRule("funccall")]
	private MathLangParser.funccall_return funccall()
	{
		Enter_funccall();
		EnterRule("funccall", 51);
		TraceIn("funccall", 51);
		MathLangParser.funccall_return retval = new MathLangParser.funccall_return();
		retval.Start = (IToken)input.LT(1);
		int funccall_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal178=null;
		MathLangParser.funccallbody_return funccallbody177 = default(MathLangParser.funccallbody_return);

		object char_literal178_tree=null;

		try { DebugEnterRule(GrammarFileName, "funccall");
		DebugLocation(159, 27);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 51)) { return retval; }
			// MathLang.g:159:9: ( funccallbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:159:11: funccallbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(159, 11);
			PushFollow(Follow._funccallbody_in_funccall1587);
			funccallbody177=funccallbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody177.Tree);
			DebugLocation(159, 27);
			char_literal178=(IToken)Match(input,71,Follow._71_in_funccall1589); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("funccall", 51);
			LeaveRule("funccall", 51);
			Leave_funccall();
			if (state.backtracking > 0) { Memoize(input, 51, funccall_StartIndex); }
		}
		DebugLocation(159, 27);
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
	// MathLang.g:160:1: expressioncommalist : expression ( ',' expression )* ;
	[GrammarRule("expressioncommalist")]
	private MathLangParser.expressioncommalist_return expressioncommalist()
	{
		Enter_expressioncommalist();
		EnterRule("expressioncommalist", 52);
		TraceIn("expressioncommalist", 52);
		MathLangParser.expressioncommalist_return retval = new MathLangParser.expressioncommalist_return();
		retval.Start = (IToken)input.LT(1);
		int expressioncommalist_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal180=null;
		MathLangParser.expression_return expression179 = default(MathLangParser.expression_return);
		MathLangParser.expression_return expression181 = default(MathLangParser.expression_return);

		object char_literal180_tree=null;

		try { DebugEnterRule(GrammarFileName, "expressioncommalist");
		DebugLocation(160, 51);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 52)) { return retval; }
			// MathLang.g:160:20: ( expression ( ',' expression )* )
			DebugEnterAlt(1);
			// MathLang.g:160:22: expression ( ',' expression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(160, 22);
			PushFollow(Follow._expression_in_expressioncommalist1596);
			expression179=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression179.Tree);
			DebugLocation(160, 33);
			// MathLang.g:160:33: ( ',' expression )*
			try { DebugEnterSubRule(38);
			while (true)
			{
				int alt38=2;
				try { DebugEnterDecision(38, decisionCanBacktrack[38]);
				int LA38_0 = input.LA(1);

				if ((LA38_0==72))
				{
					alt38=1;
				}


				} finally { DebugExitDecision(38); }
				switch ( alt38 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:160:35: ',' expression
					{
					DebugLocation(160, 38);
					char_literal180=(IToken)Match(input,72,Follow._72_in_expressioncommalist1600); if (state.failed) return retval;
					DebugLocation(160, 40);
					PushFollow(Follow._expression_in_expressioncommalist1603);
					expression181=expression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression181.Tree);

					}
					break;

				default:
					goto loop38;
				}
			}

			loop38:
				;

			} finally { DebugExitSubRule(38); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expressioncommalist", 52);
			LeaveRule("expressioncommalist", 52);
			Leave_expressioncommalist();
			if (state.backtracking > 0) { Memoize(input, 52, expressioncommalist_StartIndex); }
		}
		DebugLocation(160, 51);
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
	// MathLang.g:163:1: object_initializer : '{' expressioncommalist '}' -> ^( PARAMETERS expressioncommalist ) ;
	[GrammarRule("object_initializer")]
	private MathLangParser.object_initializer_return object_initializer()
	{
		Enter_object_initializer();
		EnterRule("object_initializer", 53);
		TraceIn("object_initializer", 53);
		MathLangParser.object_initializer_return retval = new MathLangParser.object_initializer_return();
		retval.Start = (IToken)input.LT(1);
		int object_initializer_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal182=null;
		IToken char_literal184=null;
		MathLangParser.expressioncommalist_return expressioncommalist183 = default(MathLangParser.expressioncommalist_return);

		object char_literal182_tree=null;
		object char_literal184_tree=null;
		RewriteRuleITokenStream stream_69=new RewriteRuleITokenStream(adaptor,"token 69");
		RewriteRuleITokenStream stream_70=new RewriteRuleITokenStream(adaptor,"token 70");
		RewriteRuleSubtreeStream stream_expressioncommalist=new RewriteRuleSubtreeStream(adaptor,"rule expressioncommalist");
		try { DebugEnterRule(GrammarFileName, "object_initializer");
		DebugLocation(163, 86);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 53)) { return retval; }
			// MathLang.g:163:19: ( '{' expressioncommalist '}' -> ^( PARAMETERS expressioncommalist ) )
			DebugEnterAlt(1);
			// MathLang.g:163:22: '{' expressioncommalist '}'
			{
			DebugLocation(163, 22);
			char_literal182=(IToken)Match(input,69,Follow._69_in_object_initializer1615); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_69.Add(char_literal182);

			DebugLocation(163, 26);
			PushFollow(Follow._expressioncommalist_in_object_initializer1617);
			expressioncommalist183=expressioncommalist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expressioncommalist.Add(expressioncommalist183.Tree);
			DebugLocation(163, 46);
			char_literal184=(IToken)Match(input,70,Follow._70_in_object_initializer1619); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_70.Add(char_literal184);



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
			// 163:50: -> ^( PARAMETERS expressioncommalist )
			{
				DebugLocation(163, 53);
				// MathLang.g:163:53: ^( PARAMETERS expressioncommalist )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(163, 55);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_1);

				DebugLocation(163, 66);
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
			TraceOut("object_initializer", 53);
			LeaveRule("object_initializer", 53);
			Leave_object_initializer();
			if (state.backtracking > 0) { Memoize(input, 53, object_initializer_StartIndex); }
		}
		DebugLocation(163, 86);
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
	// MathLang.g:164:1: newexpression : KNEW initializer ;
	[GrammarRule("newexpression")]
	private MathLangParser.newexpression_return newexpression()
	{
		Enter_newexpression();
		EnterRule("newexpression", 54);
		TraceIn("newexpression", 54);
		MathLangParser.newexpression_return retval = new MathLangParser.newexpression_return();
		retval.Start = (IToken)input.LT(1);
		int newexpression_StartIndex = input.Index;
		object root_0 = null;

		IToken KNEW185=null;
		MathLangParser.initializer_return initializer186 = default(MathLangParser.initializer_return);

		object KNEW185_tree=null;

		try { DebugEnterRule(GrammarFileName, "newexpression");
		DebugLocation(164, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 54)) { return retval; }
			// MathLang.g:164:14: ( KNEW initializer )
			DebugEnterAlt(1);
			// MathLang.g:164:16: KNEW initializer
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(164, 20);
			KNEW185=(IToken)Match(input,KNEW,Follow._KNEW_in_newexpression1634); if (state.failed) return retval;
			DebugLocation(164, 22);
			PushFollow(Follow._initializer_in_newexpression1637);
			initializer186=initializer();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, initializer186.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("newexpression", 54);
			LeaveRule("newexpression", 54);
			Leave_newexpression();
			if (state.backtracking > 0) { Memoize(input, 54, newexpression_StartIndex); }
		}
		DebugLocation(164, 32);
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
	// MathLang.g:165:1: initializer : ( simple_var_initializer | array_initializer ) ;
	[GrammarRule("initializer")]
	private MathLangParser.initializer_return initializer()
	{
		Enter_initializer();
		EnterRule("initializer", 55);
		TraceIn("initializer", 55);
		MathLangParser.initializer_return retval = new MathLangParser.initializer_return();
		retval.Start = (IToken)input.LT(1);
		int initializer_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.simple_var_initializer_return simple_var_initializer187 = default(MathLangParser.simple_var_initializer_return);
		MathLangParser.array_initializer_return array_initializer188 = default(MathLangParser.array_initializer_return);


		try { DebugEnterRule(GrammarFileName, "initializer");
		DebugLocation(165, 57);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 55)) { return retval; }
			// MathLang.g:165:12: ( ( simple_var_initializer | array_initializer ) )
			DebugEnterAlt(1);
			// MathLang.g:165:14: ( simple_var_initializer | array_initializer )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(165, 14);
			// MathLang.g:165:14: ( simple_var_initializer | array_initializer )
			int alt39=2;
			try { DebugEnterSubRule(39);
			try { DebugEnterDecision(39, decisionCanBacktrack[39]);
			int LA39_0 = input.LA(1);

			if ((LA39_0==TYPE))
			{
				int LA39_1 = input.LA(2);

				if ((LA39_1==OPEN_BRACE))
				{
					alt39=1;
				}
				else if ((LA39_1==ARRAY_DECLARATION_MARK||LA39_1==OPEN_SQUARE_BRACE))
				{
					alt39=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 39, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 39, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(39); }
			switch (alt39)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:165:15: simple_var_initializer
				{
				DebugLocation(165, 15);
				PushFollow(Follow._simple_var_initializer_in_initializer1644);
				simple_var_initializer187=simple_var_initializer();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, simple_var_initializer187.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:165:40: array_initializer
				{
				DebugLocation(165, 40);
				PushFollow(Follow._array_initializer_in_initializer1648);
				array_initializer188=array_initializer();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, array_initializer188.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(39); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("initializer", 55);
			LeaveRule("initializer", 55);
			Leave_initializer();
			if (state.backtracking > 0) { Memoize(input, 55, initializer_StartIndex); }
		}
		DebugLocation(165, 57);
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
	// MathLang.g:166:1: simple_var_initializer : type OPEN_BRACE CLOSE_BRACE -> ^( NEWVAR type ) ;
	[GrammarRule("simple_var_initializer")]
	private MathLangParser.simple_var_initializer_return simple_var_initializer()
	{
		Enter_simple_var_initializer();
		EnterRule("simple_var_initializer", 56);
		TraceIn("simple_var_initializer", 56);
		MathLangParser.simple_var_initializer_return retval = new MathLangParser.simple_var_initializer_return();
		retval.Start = (IToken)input.LT(1);
		int simple_var_initializer_StartIndex = input.Index;
		object root_0 = null;

		IToken OPEN_BRACE190=null;
		IToken CLOSE_BRACE191=null;
		MathLangParser.type_return type189 = default(MathLangParser.type_return);

		object OPEN_BRACE190_tree=null;
		object CLOSE_BRACE191_tree=null;
		RewriteRuleITokenStream stream_CLOSE_BRACE=new RewriteRuleITokenStream(adaptor,"token CLOSE_BRACE");
		RewriteRuleITokenStream stream_OPEN_BRACE=new RewriteRuleITokenStream(adaptor,"token OPEN_BRACE");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "simple_var_initializer");
		DebugLocation(166, 69);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 56)) { return retval; }
			// MathLang.g:166:23: ( type OPEN_BRACE CLOSE_BRACE -> ^( NEWVAR type ) )
			DebugEnterAlt(1);
			// MathLang.g:166:25: type OPEN_BRACE CLOSE_BRACE
			{
			DebugLocation(166, 25);
			PushFollow(Follow._type_in_simple_var_initializer1655);
			type189=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type189.Tree);
			DebugLocation(166, 30);
			OPEN_BRACE190=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_simple_var_initializer1657); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OPEN_BRACE.Add(OPEN_BRACE190);

			DebugLocation(166, 41);
			CLOSE_BRACE191=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_simple_var_initializer1659); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CLOSE_BRACE.Add(CLOSE_BRACE191);



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
			// 166:53: -> ^( NEWVAR type )
			{
				DebugLocation(166, 56);
				// MathLang.g:166:56: ^( NEWVAR type )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(166, 58);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(NEWVAR, "NEWVAR"), root_1);

				DebugLocation(166, 65);
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
			TraceOut("simple_var_initializer", 56);
			LeaveRule("simple_var_initializer", 56);
			Leave_simple_var_initializer();
			if (state.backtracking > 0) { Memoize(input, 56, simple_var_initializer_StartIndex); }
		}
		DebugLocation(166, 69);
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
	// MathLang.g:167:1: array_initializer : type ( ( OPEN_SQUARE_BRACE mathexpression CLOSE_SQUARE_BRACE ) | ARRAY_DECLARATION_MARK ) ( object_initializer )? -> ^( ARRAY_INITIALIZER type ( mathexpression )? ( object_initializer )? ) ;
	[GrammarRule("array_initializer")]
	private MathLangParser.array_initializer_return array_initializer()
	{
		Enter_array_initializer();
		EnterRule("array_initializer", 57);
		TraceIn("array_initializer", 57);
		MathLangParser.array_initializer_return retval = new MathLangParser.array_initializer_return();
		retval.Start = (IToken)input.LT(1);
		int array_initializer_StartIndex = input.Index;
		object root_0 = null;

		IToken OPEN_SQUARE_BRACE193=null;
		IToken CLOSE_SQUARE_BRACE195=null;
		IToken ARRAY_DECLARATION_MARK196=null;
		MathLangParser.type_return type192 = default(MathLangParser.type_return);
		MathLangParser.mathexpression_return mathexpression194 = default(MathLangParser.mathexpression_return);
		MathLangParser.object_initializer_return object_initializer197 = default(MathLangParser.object_initializer_return);

		object OPEN_SQUARE_BRACE193_tree=null;
		object CLOSE_SQUARE_BRACE195_tree=null;
		object ARRAY_DECLARATION_MARK196_tree=null;
		RewriteRuleITokenStream stream_CLOSE_SQUARE_BRACE=new RewriteRuleITokenStream(adaptor,"token CLOSE_SQUARE_BRACE");
		RewriteRuleITokenStream stream_ARRAY_DECLARATION_MARK=new RewriteRuleITokenStream(adaptor,"token ARRAY_DECLARATION_MARK");
		RewriteRuleITokenStream stream_OPEN_SQUARE_BRACE=new RewriteRuleITokenStream(adaptor,"token OPEN_SQUARE_BRACE");
		RewriteRuleSubtreeStream stream_mathexpression=new RewriteRuleSubtreeStream(adaptor,"rule mathexpression");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		RewriteRuleSubtreeStream stream_object_initializer=new RewriteRuleSubtreeStream(adaptor,"rule object_initializer");
		try { DebugEnterRule(GrammarFileName, "array_initializer");
		DebugLocation(167, 189);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 57)) { return retval; }
			// MathLang.g:167:18: ( type ( ( OPEN_SQUARE_BRACE mathexpression CLOSE_SQUARE_BRACE ) | ARRAY_DECLARATION_MARK ) ( object_initializer )? -> ^( ARRAY_INITIALIZER type ( mathexpression )? ( object_initializer )? ) )
			DebugEnterAlt(1);
			// MathLang.g:167:20: type ( ( OPEN_SQUARE_BRACE mathexpression CLOSE_SQUARE_BRACE ) | ARRAY_DECLARATION_MARK ) ( object_initializer )?
			{
			DebugLocation(167, 20);
			PushFollow(Follow._type_in_array_initializer1673);
			type192=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type192.Tree);
			DebugLocation(167, 25);
			// MathLang.g:167:25: ( ( OPEN_SQUARE_BRACE mathexpression CLOSE_SQUARE_BRACE ) | ARRAY_DECLARATION_MARK )
			int alt40=2;
			try { DebugEnterSubRule(40);
			try { DebugEnterDecision(40, decisionCanBacktrack[40]);
			int LA40_0 = input.LA(1);

			if ((LA40_0==OPEN_SQUARE_BRACE))
			{
				alt40=1;
			}
			else if ((LA40_0==ARRAY_DECLARATION_MARK))
			{
				alt40=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 40, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(40); }
			switch (alt40)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:167:26: ( OPEN_SQUARE_BRACE mathexpression CLOSE_SQUARE_BRACE )
				{
				DebugLocation(167, 26);
				// MathLang.g:167:26: ( OPEN_SQUARE_BRACE mathexpression CLOSE_SQUARE_BRACE )
				DebugEnterAlt(1);
				// MathLang.g:167:27: OPEN_SQUARE_BRACE mathexpression CLOSE_SQUARE_BRACE
				{
				DebugLocation(167, 27);
				OPEN_SQUARE_BRACE193=(IToken)Match(input,OPEN_SQUARE_BRACE,Follow._OPEN_SQUARE_BRACE_in_array_initializer1677); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_OPEN_SQUARE_BRACE.Add(OPEN_SQUARE_BRACE193);

				DebugLocation(167, 45);
				PushFollow(Follow._mathexpression_in_array_initializer1679);
				mathexpression194=mathexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_mathexpression.Add(mathexpression194.Tree);
				DebugLocation(167, 60);
				CLOSE_SQUARE_BRACE195=(IToken)Match(input,CLOSE_SQUARE_BRACE,Follow._CLOSE_SQUARE_BRACE_in_array_initializer1681); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_CLOSE_SQUARE_BRACE.Add(CLOSE_SQUARE_BRACE195);


				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:167:82: ARRAY_DECLARATION_MARK
				{
				DebugLocation(167, 82);
				ARRAY_DECLARATION_MARK196=(IToken)Match(input,ARRAY_DECLARATION_MARK,Follow._ARRAY_DECLARATION_MARK_in_array_initializer1686); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ARRAY_DECLARATION_MARK.Add(ARRAY_DECLARATION_MARK196);


				}
				break;

			}
			} finally { DebugExitSubRule(40); }

			DebugLocation(167, 106);
			// MathLang.g:167:106: ( object_initializer )?
			int alt41=2;
			try { DebugEnterSubRule(41);
			try { DebugEnterDecision(41, decisionCanBacktrack[41]);
			int LA41_0 = input.LA(1);

			if ((LA41_0==69))
			{
				alt41=1;
			}
			} finally { DebugExitDecision(41); }
			switch (alt41)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: object_initializer
				{
				DebugLocation(167, 106);
				PushFollow(Follow._object_initializer_in_array_initializer1689);
				object_initializer197=object_initializer();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_object_initializer.Add(object_initializer197.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(41); }



			{
			// AST REWRITE
			// elements: type, object_initializer, mathexpression
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 167:126: -> ^( ARRAY_INITIALIZER type ( mathexpression )? ( object_initializer )? )
			{
				DebugLocation(167, 129);
				// MathLang.g:167:129: ^( ARRAY_INITIALIZER type ( mathexpression )? ( object_initializer )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(167, 131);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAY_INITIALIZER, "ARRAY_INITIALIZER"), root_1);

				DebugLocation(167, 149);
				adaptor.AddChild(root_1, stream_type.NextTree());
				DebugLocation(167, 154);
				// MathLang.g:167:154: ( mathexpression )?
				if ( stream_mathexpression.HasNext )
				{
					DebugLocation(167, 154);
					adaptor.AddChild(root_1, stream_mathexpression.NextTree());

				}
				stream_mathexpression.Reset();
				DebugLocation(167, 170);
				// MathLang.g:167:170: ( object_initializer )?
				if ( stream_object_initializer.HasNext )
				{
					DebugLocation(167, 170);
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
			TraceOut("array_initializer", 57);
			LeaveRule("array_initializer", 57);
			Leave_array_initializer();
			if (state.backtracking > 0) { Memoize(input, 57, array_initializer_StartIndex); }
		}
		DebugLocation(167, 189);
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
	// MathLang.g:169:1: block : '{' statementlist '}' ;
	[GrammarRule("block")]
	private MathLangParser.block_return block()
	{
		Enter_block();
		EnterRule("block", 58);
		TraceIn("block", 58);
		MathLangParser.block_return retval = new MathLangParser.block_return();
		retval.Start = (IToken)input.LT(1);
		int block_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal198=null;
		IToken char_literal200=null;
		MathLangParser.statementlist_return statementlist199 = default(MathLangParser.statementlist_return);

		object char_literal198_tree=null;
		object char_literal200_tree=null;

		try { DebugEnterRule(GrammarFileName, "block");
		DebugLocation(169, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 58)) { return retval; }
			// MathLang.g:169:6: ( '{' statementlist '}' )
			DebugEnterAlt(1);
			// MathLang.g:169:8: '{' statementlist '}'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(169, 11);
			char_literal198=(IToken)Match(input,69,Follow._69_in_block1711); if (state.failed) return retval;
			DebugLocation(169, 13);
			PushFollow(Follow._statementlist_in_block1714);
			statementlist199=statementlist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementlist199.Tree);
			DebugLocation(169, 30);
			char_literal200=(IToken)Match(input,70,Follow._70_in_block1716); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("block", 58);
			LeaveRule("block", 58);
			Leave_block();
			if (state.backtracking > 0) { Memoize(input, 58, block_StartIndex); }
		}
		DebugLocation(169, 30);
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
	// MathLang.g:171:1: statementlist : ( statement )* -> ^( BLOCK ( statement )* ) ;
	[GrammarRule("statementlist")]
	private MathLangParser.statementlist_return statementlist()
	{
		Enter_statementlist();
		EnterRule("statementlist", 59);
		TraceIn("statementlist", 59);
		MathLangParser.statementlist_return retval = new MathLangParser.statementlist_return();
		retval.Start = (IToken)input.LT(1);
		int statementlist_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.statement_return statement201 = default(MathLangParser.statement_return);

		RewriteRuleSubtreeStream stream_statement=new RewriteRuleSubtreeStream(adaptor,"rule statement");
		try { DebugEnterRule(GrammarFileName, "statementlist");
		DebugLocation(171, 49);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 59)) { return retval; }
			// MathLang.g:171:14: ( ( statement )* -> ^( BLOCK ( statement )* ) )
			DebugEnterAlt(1);
			// MathLang.g:171:16: ( statement )*
			{
			DebugLocation(171, 16);
			// MathLang.g:171:16: ( statement )*
			try { DebugEnterSubRule(42);
			while (true)
			{
				int alt42=2;
				try { DebugEnterDecision(42, decisionCanBacktrack[42]);
				int LA42_0 = input.LA(1);

				if ((LA42_0==IF||LA42_0==FOR||(LA42_0>=RETURN && LA42_0<=DO)||(LA42_0>=ID && LA42_0<=TYPE)||LA42_0==KNEW))
				{
					alt42=1;
				}


				} finally { DebugExitDecision(42); }
				switch ( alt42 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: statement
					{
					DebugLocation(171, 16);
					PushFollow(Follow._statement_in_statementlist1724);
					statement201=statement();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_statement.Add(statement201.Tree);

					}
					break;

				default:
					goto loop42;
				}
			}

			loop42:
				;

			} finally { DebugExitSubRule(42); }



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
			// 171:27: -> ^( BLOCK ( statement )* )
			{
				DebugLocation(171, 30);
				// MathLang.g:171:30: ^( BLOCK ( statement )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(171, 32);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

				DebugLocation(171, 38);
				// MathLang.g:171:38: ( statement )*
				while ( stream_statement.HasNext )
				{
					DebugLocation(171, 38);
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
			TraceOut("statementlist", 59);
			LeaveRule("statementlist", 59);
			Leave_statementlist();
			if (state.backtracking > 0) { Memoize(input, 59, statementlist_StartIndex); }
		}
		DebugLocation(171, 49);
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
		EnterRule("synpred20_MathLang_fragment", 79);
		TraceIn("synpred20_MathLang_fragment", 79);
		try
		{
			// MathLang.g:95:5: ( funccallbody )
			DebugEnterAlt(1);
			// MathLang.g:95:5: funccallbody
			{
			DebugLocation(95, 5);
			PushFollow(Follow._funccallbody_in_synpred20_MathLang641);
			funccallbody();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred20_MathLang_fragment", 79);
			LeaveRule("synpred20_MathLang_fragment", 79);
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
		EnterRule("synpred21_MathLang_fragment", 80);
		TraceIn("synpred21_MathLang_fragment", 80);
		try
		{
			// MathLang.g:96:5: ( boolexpression )
			DebugEnterAlt(1);
			// MathLang.g:96:5: boolexpression
			{
			DebugLocation(96, 5);
			PushFollow(Follow._boolexpression_in_synpred21_MathLang647);
			boolexpression();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred21_MathLang_fragment", 80);
			LeaveRule("synpred21_MathLang_fragment", 80);
			Leave_synpred21_MathLang_fragment();
		}
	}
	// $ANTLR end synpred21_MathLang

	partial void Enter_synpred39_MathLang_fragment();
	partial void Leave_synpred39_MathLang_fragment();

	// $ANTLR start synpred39_MathLang
	public void synpred39_MathLang_fragment()
	{
		Enter_synpred39_MathLang_fragment();
		EnterRule("synpred39_MathLang_fragment", 98);
		TraceIn("synpred39_MathLang_fragment", 98);
		try
		{
			// MathLang.g:132:16: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )
			DebugEnterAlt(1);
			// MathLang.g:132:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
			{
			DebugLocation(132, 16);
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

			DebugLocation(132, 53);
			PushFollow(Follow._add_in_synpred39_MathLang1137);
			add();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred39_MathLang_fragment", 98);
			LeaveRule("synpred39_MathLang_fragment", 98);
			Leave_synpred39_MathLang_fragment();
		}
	}
	// $ANTLR end synpred39_MathLang

	partial void Enter_synpred48_MathLang_fragment();
	partial void Leave_synpred48_MathLang_fragment();

	// $ANTLR start synpred48_MathLang
	public void synpred48_MathLang_fragment()
	{
		Enter_synpred48_MathLang_fragment();
		EnterRule("synpred48_MathLang_fragment", 107);
		TraceIn("synpred48_MathLang_fragment", 107);
		try
		{
			// MathLang.g:144:22: ( OPEN_BRACE boolterm CLOSE_BRACE )
			DebugEnterAlt(1);
			// MathLang.g:144:22: OPEN_BRACE boolterm CLOSE_BRACE
			{
			DebugLocation(144, 22);
			Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_synpred48_MathLang1297); if (state.failed) return;
			DebugLocation(144, 34);
			PushFollow(Follow._boolterm_in_synpred48_MathLang1300);
			boolterm();
			PopFollow();
			if (state.failed) return;
			DebugLocation(144, 43);
			Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_synpred48_MathLang1302); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred48_MathLang_fragment", 107);
			LeaveRule("synpred48_MathLang_fragment", 107);
			Leave_synpred48_MathLang_fragment();
		}
	}
	// $ANTLR end synpred48_MathLang

	partial void Enter_synpred53_MathLang_fragment();
	partial void Leave_synpred53_MathLang_fragment();

	// $ANTLR start synpred53_MathLang
	public void synpred53_MathLang_fragment()
	{
		Enter_synpred53_MathLang_fragment();
		EnterRule("synpred53_MathLang_fragment", 112);
		TraceIn("synpred53_MathLang_fragment", 112);
		try
		{
			// MathLang.g:149:79: ( ELSE ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:149:79: ELSE ( block | statement )
			{
			DebugLocation(149, 79);
			Match(input,ELSE,Follow._ELSE_in_synpred53_MathLang1356); if (state.failed) return;
			DebugLocation(149, 85);
			// MathLang.g:149:85: ( block | statement )
			int alt44=2;
			try { DebugEnterSubRule(44);
			try { DebugEnterDecision(44, decisionCanBacktrack[44]);
			int LA44_0 = input.LA(1);

			if ((LA44_0==69))
			{
				alt44=1;
			}
			else if ((LA44_0==IF||LA44_0==FOR||(LA44_0>=RETURN && LA44_0<=DO)||(LA44_0>=ID && LA44_0<=TYPE)||LA44_0==KNEW))
			{
				alt44=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				NoViableAltException nvae = new NoViableAltException("", 44, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(44); }
			switch (alt44)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:149:86: block
				{
				DebugLocation(149, 86);
				PushFollow(Follow._block_in_synpred53_MathLang1360);
				block();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:149:94: statement
				{
				DebugLocation(149, 94);
				PushFollow(Follow._statement_in_synpred53_MathLang1364);
				statement();
				PopFollow();
				if (state.failed) return;

				}
				break;

			}
			} finally { DebugExitSubRule(44); }


			}

		}
		finally
		{
			TraceOut("synpred53_MathLang_fragment", 112);
			LeaveRule("synpred53_MathLang_fragment", 112);
			Leave_synpred53_MathLang_fragment();
		}
	}
	// $ANTLR end synpred53_MathLang
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
	DFA19 dfa19;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa5 = new DFA5( this );
		dfa8 = new DFA8( this, SpecialStateTransition8 );
		dfa19 = new DFA19( this, SpecialStateTransition19 );
	}

	private class DFA5 : DFA
	{
		private const string DFA5_eotS =
			"\xD\xFFFF";
		private const string DFA5_eofS =
			"\xD\xFFFF";
		private const string DFA5_minS =
			"\x1\x7\x1\xFFFF\x1\x2B\x6\xFFFF\x1\x25\x2\xFFFF\x1\x2C";
		private const string DFA5_maxS =
			"\x1\x40\x1\xFFFF\x1\x39\x6\xFFFF\x1\x25\x2\xFFFF\x1\x39";
		private const string DFA5_acceptS =
			"\x1\xFFFF\x1\x1\x1\xFFFF\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x1\x9\x1\xFFFF"+
			"\x1\x2\x1\x8\x1\xFFFF";
		private const string DFA5_specialS =
			"\xD\xFFFF}>";
		private static readonly string[] DFA5_transitionS =
			{
				"\x1\x3\x1\xFFFF\x1\x6\x1\xFFFF\x1\x7\x1\x4\x1\x5\x17\xFFFF\x1\x2\x1"+
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

		public override string Description { get { return "69:12: ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | returnstatement | funccall | newexpression )"; } }

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
			"\x1\x25\x1\xFFFF\x1\x0\x1\xFFFF\x1\x0\x2\xFFFF\x3\x0\x2\xFFFF";
		private const string DFA8_maxS =
			"\x1\x40\x1\xFFFF\x1\x0\x1\xFFFF\x1\x0\x2\xFFFF\x3\x0\x2\xFFFF";
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

		public override string Description { get { return "93:1: expression : ( newexpression | funccallbody | boolexpression | mathexpression );"; } }

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
	private class DFA19 : DFA
	{
		private const string DFA19_eotS =
			"\xA\xFFFF";
		private const string DFA19_eofS =
			"\x1\x2\x9\xFFFF";
		private const string DFA19_minS =
			"\x1\x33\x1\x0\x8\xFFFF";
		private const string DFA19_maxS =
			"\x1\x48\x1\x0\x8\xFFFF";
		private const string DFA19_acceptS =
			"\x2\xFFFF\x1\x2\x1\xFFFF\x1\x1\x5\xFFFF";
		private const string DFA19_specialS =
			"\x1\xFFFF\x1\x0\x8\xFFFF}>";
		private static readonly string[] DFA19_transitionS =
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

		private static readonly short[] DFA19_eot = DFA.UnpackEncodedString(DFA19_eotS);
		private static readonly short[] DFA19_eof = DFA.UnpackEncodedString(DFA19_eofS);
		private static readonly char[] DFA19_min = DFA.UnpackEncodedStringToUnsignedChars(DFA19_minS);
		private static readonly char[] DFA19_max = DFA.UnpackEncodedStringToUnsignedChars(DFA19_maxS);
		private static readonly short[] DFA19_accept = DFA.UnpackEncodedString(DFA19_acceptS);
		private static readonly short[] DFA19_special = DFA.UnpackEncodedString(DFA19_specialS);
		private static readonly short[][] DFA19_transition;

		static DFA19()
		{
			int numStates = DFA19_transitionS.Length;
			DFA19_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA19_transition[i] = DFA.UnpackEncodedString(DFA19_transitionS[i]);
			}
		}

		public DFA19( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 19;
			this.eot = DFA19_eot;
			this.eof = DFA19_eof;
			this.min = DFA19_min;
			this.max = DFA19_max;
			this.accept = DFA19_accept;
			this.special = DFA19_special;
			this.transition = DFA19_transition;
		}

		public override string Description { get { return "132:14: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition19(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA19_1 = input.LA(1);


				int index19_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred39_MathLang_fragment)) ) {s = 4;}

				else if ( (true) ) {s = 2;}


				input.Seek(index19_1);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 19, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}

	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _class_list_in_execute384 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_execute386 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MODIFIER_in_class_declaration405 = new BitSet(new ulong[]{0x80000000UL});
		public static readonly BitSet _CLASS_WORD_in_class_declaration407 = new BitSet(new ulong[]{0x2000000000UL});
		public static readonly BitSet _ID_in_class_declaration409 = new BitSet(new ulong[]{0x0UL,0x20UL});
		public static readonly BitSet _class_block_in_class_declaration411 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _69_in_class_block429 = new BitSet(new ulong[]{0x1000000000UL,0x40UL});
		public static readonly BitSet _static_func_or_var_declaration_in_class_block432 = new BitSet(new ulong[]{0x1000000000UL,0x40UL});
		public static readonly BitSet _70_in_class_block435 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _static_declaration_in_static_func_or_var_declaration454 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funcdeclaration_in_static_func_or_var_declaration458 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _class_declaration_in_class_list467 = new BitSet(new ulong[]{0x1000000002UL});
		public static readonly BitSet _funcdeclaration_in_func_list477 = new BitSet(new ulong[]{0x1000000002UL});
		public static readonly BitSet _declaration_in_statement498 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assignment_in_statement504 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ifstatement_in_statement509 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _whilestatement_in_statement514 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _dowhilestatement_in_statement519 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _forstatement_in_statement524 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _returnstatement_in_statement529 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccall_in_statement534 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _newexpression_in_statement539 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_type553 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_array_type560 = new BitSet(new ulong[]{0x8000000000UL});
		public static readonly BitSet _ARRAY_DECLARATION_MARK_in_array_type562 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_any_type569 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_type_in_any_type573 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _VOID_in_any_type577 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NUMBER_in_number585 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _extended_id_in_number591 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_number597 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CHAR_in_number603 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrayelement_in_number609 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _term_in_mathexpression621 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _newexpression_in_expression635 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_expression641 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolexpression_in_expression647 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathexpression_in_expression653 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_extended_id666 = new BitSet(new ulong[]{0x80000000002UL});
		public static readonly BitSet _DOT_in_extended_id669 = new BitSet(new ulong[]{0x2000000000UL});
		public static readonly BitSet _ID_in_extended_id672 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _extended_id_in_arrayelement691 = new BitSet(new ulong[]{0x100000000000UL});
		public static readonly BitSet _OPEN_SQUARE_BRACE_in_arrayelement693 = new BitSet(new ulong[]{0x201062000000000UL});
		public static readonly BitSet _mathexpression_in_arrayelement695 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _CLOSE_SQUARE_BRACE_in_arrayelement697 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MODIFIER_in_static_declaration715 = new BitSet(new ulong[]{0x4000000000UL});
		public static readonly BitSet _declaration_in_static_declaration717 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _var_declaration_in_declaration732 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_declaration_in_declaration736 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_var_declaration742 = new BitSet(new ulong[]{0x2000000000UL});
		public static readonly BitSet _d_list_in_var_declaration744 = new BitSet(new ulong[]{0x0UL,0x80UL});
		public static readonly BitSet _71_in_var_declaration746 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_type_in_array_declaration763 = new BitSet(new ulong[]{0x2000000000UL});
		public static readonly BitSet _d_array_list_in_array_declaration765 = new BitSet(new ulong[]{0x0UL,0x80UL});
		public static readonly BitSet _71_in_array_declaration767 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _d_in_d_list785 = new BitSet(new ulong[]{0x2UL,0x100UL});
		public static readonly BitSet _72_in_d_list788 = new BitSet(new ulong[]{0x2000000000UL});
		public static readonly BitSet _d_in_d_list791 = new BitSet(new ulong[]{0x2UL,0x100UL});
		public static readonly BitSet _d_array_in_d_array_list814 = new BitSet(new ulong[]{0x2UL,0x100UL});
		public static readonly BitSet _72_in_d_array_list817 = new BitSet(new ulong[]{0x2000000000UL});
		public static readonly BitSet _d_array_in_d_array_list820 = new BitSet(new ulong[]{0x2UL,0x100UL});
		public static readonly BitSet _declarationbody_d_in_d844 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _longdeclarationbody_d_in_d848 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declarationbody_array_d_in_d_array855 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _longdeclarationbody_array_d_in_d_array859 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_declarationbody_d867 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_declarationbody_array_d889 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_longdeclarationbody_d906 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _ASSIGN_in_longdeclarationbody_d908 = new BitSet(new ulong[]{0xE201062000000000UL,0x1UL});
		public static readonly BitSet _expression_in_longdeclarationbody_d910 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_longdeclarationbody_array_d929 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _ASSIGN_in_longdeclarationbody_array_d931 = new BitSet(new ulong[]{0x0UL,0x1UL});
		public static readonly BitSet _newexpression_in_longdeclarationbody_array_d933 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_declarationbody953 = new BitSet(new ulong[]{0x2000000000UL});
		public static readonly BitSet _ID_in_declarationbody955 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_type_in_declarationbody976 = new BitSet(new ulong[]{0x2000000000UL});
		public static readonly BitSet _ID_in_declarationbody978 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_longdeclarationbody1002 = new BitSet(new ulong[]{0x2000000000UL});
		public static readonly BitSet _ID_in_longdeclarationbody1004 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _ASSIGN_in_longdeclarationbody1006 = new BitSet(new ulong[]{0xE201062000000000UL,0x1UL});
		public static readonly BitSet _expression_in_longdeclarationbody1008 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_type_in_longdeclarationbody1032 = new BitSet(new ulong[]{0x2000000000UL});
		public static readonly BitSet _ID_in_longdeclarationbody1034 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _ASSIGN_in_longdeclarationbody1036 = new BitSet(new ulong[]{0x0UL,0x1UL});
		public static readonly BitSet _newexpression_in_longdeclarationbody1038 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mul_in_add1064 = new BitSet(new ulong[]{0x1800000000002UL});
		public static readonly BitSet _set_in_add1068 = new BitSet(new ulong[]{0x201062000000000UL});
		public static readonly BitSet _mul_in_add1077 = new BitSet(new ulong[]{0x1800000000002UL});
		public static readonly BitSet _group_in_mul1086 = new BitSet(new ulong[]{0x6000000000002UL});
		public static readonly BitSet _set_in_mul1090 = new BitSet(new ulong[]{0x201062000000000UL});
		public static readonly BitSet _group_in_mul1099 = new BitSet(new ulong[]{0x6000000000002UL});
		public static readonly BitSet _add_in_compare1107 = new BitSet(new ulong[]{0x1F8000000000002UL});
		public static readonly BitSet _set_in_compare1111 = new BitSet(new ulong[]{0x201062000000000UL});
		public static readonly BitSet _add_in_compare1137 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _add_in_term1148 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _SUB_in_group1155 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_group1160 = new BitSet(new ulong[]{0x201062000000000UL});
		public static readonly BitSet _term_in_group1163 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_group1165 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _number_in_group1170 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assignmentbody_in_assignment1177 = new BitSet(new ulong[]{0x0UL,0x80UL});
		public static readonly BitSet _71_in_assignment1179 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _extended_id_in_assignmentbody1187 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _ASSIGN_in_assignmentbody1189 = new BitSet(new ulong[]{0xE201062000000000UL,0x1UL});
		public static readonly BitSet _expression_in_assignmentbody1191 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrayelement_in_assignmentbody1210 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _ASSIGN_in_assignmentbody1212 = new BitSet(new ulong[]{0xE201062000000000UL,0x1UL});
		public static readonly BitSet _expression_in_assignmentbody1214 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolterm_in_boolexpression1232 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _or_in_boolterm1239 = new BitSet(new ulong[]{0x60000000000002UL});
		public static readonly BitSet _set_in_boolterm1243 = new BitSet(new ulong[]{0xE201062000000000UL});
		public static readonly BitSet _or_in_boolterm1252 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _and_in_or1261 = new BitSet(new ulong[]{0x800000000000002UL});
		public static readonly BitSet _OR_in_or1264 = new BitSet(new ulong[]{0xE201062000000000UL});
		public static readonly BitSet _and_in_or1267 = new BitSet(new ulong[]{0x800000000000002UL});
		public static readonly BitSet _boolgroup_in_and1275 = new BitSet(new ulong[]{0x1000000000000002UL});
		public static readonly BitSet _AND_in_and1278 = new BitSet(new ulong[]{0xE201062000000000UL});
		public static readonly BitSet _boolgroup_in_and1281 = new BitSet(new ulong[]{0x1000000000000002UL});
		public static readonly BitSet _NOT_in_boolgroup1290 = new BitSet(new ulong[]{0xE201062000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_boolgroup1297 = new BitSet(new ulong[]{0xE201062000000000UL});
		public static readonly BitSet _boolterm_in_boolgroup1300 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_boolgroup1302 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolvar_in_boolgroup1307 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TRUE_in_boolvar1315 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FALSE_in_boolvar1321 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _compare_in_boolvar1327 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_ifstatement1336 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_ifstatement1339 = new BitSet(new ulong[]{0xE201062000000000UL});
		public static readonly BitSet _boolexpression_in_ifstatement1342 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_ifstatement1344 = new BitSet(new ulong[]{0x201066000003A80UL,0x21UL});
		public static readonly BitSet _block_in_ifstatement1348 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement1352 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _ELSE_in_ifstatement1356 = new BitSet(new ulong[]{0x201066000003A80UL,0x21UL});
		public static readonly BitSet _block_in_ifstatement1360 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement1364 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _WHILE_in_whilestatement1374 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_whilestatement1377 = new BitSet(new ulong[]{0xE201062000000000UL});
		public static readonly BitSet _boolexpression_in_whilestatement1380 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_whilestatement1382 = new BitSet(new ulong[]{0x201066000003A80UL,0x21UL});
		public static readonly BitSet _block_in_whilestatement1386 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_whilestatement1390 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_forstatement1397 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_forstatement1400 = new BitSet(new ulong[]{0x4000000000UL});
		public static readonly BitSet _longdeclarationbody_in_forstatement1403 = new BitSet(new ulong[]{0x0UL,0x80UL});
		public static readonly BitSet _71_in_forstatement1405 = new BitSet(new ulong[]{0xE201062000000000UL});
		public static readonly BitSet _boolexpression_in_forstatement1408 = new BitSet(new ulong[]{0x0UL,0x80UL});
		public static readonly BitSet _71_in_forstatement1410 = new BitSet(new ulong[]{0x201062000000000UL});
		public static readonly BitSet _assignmentbody_in_forstatement1413 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_forstatement1415 = new BitSet(new ulong[]{0x201066000003A80UL,0x21UL});
		public static readonly BitSet _block_in_forstatement1419 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_forstatement1423 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _RETURN_in_returnstatement1430 = new BitSet(new ulong[]{0xE201062000000000UL,0x1UL});
		public static readonly BitSet _expression_in_returnstatement1433 = new BitSet(new ulong[]{0x0UL,0x80UL});
		public static readonly BitSet _71_in_returnstatement1435 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DO_in_dowhilestatement1443 = new BitSet(new ulong[]{0x201066000003A80UL,0x21UL});
		public static readonly BitSet _block_in_dowhilestatement1447 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _statement_in_dowhilestatement1451 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _WHILE_in_dowhilestatement1454 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_dowhilestatement1457 = new BitSet(new ulong[]{0xE201062000000000UL});
		public static readonly BitSet _boolexpression_in_dowhilestatement1460 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_dowhilestatement1462 = new BitSet(new ulong[]{0x0UL,0x80UL});
		public static readonly BitSet _71_in_dowhilestatement1465 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MODIFIER_in_funcdeclaration1474 = new BitSet(new ulong[]{0x14000000000UL});
		public static readonly BitSet _any_type_in_funcdeclaration1476 = new BitSet(new ulong[]{0x2000000000UL});
		public static readonly BitSet _ID_in_funcdeclaration1478 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_funcdeclaration1483 = new BitSet(new ulong[]{0x400004000000000UL});
		public static readonly BitSet _paramsdeclaration_in_funcdeclaration1486 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_funcdeclaration1488 = new BitSet(new ulong[]{0x0UL,0x20UL});
		public static readonly BitSet _block_in_funcdeclaration1493 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declarationbody_in_paramsdeclaration1525 = new BitSet(new ulong[]{0x2UL,0x100UL});
		public static readonly BitSet _72_in_paramsdeclaration1529 = new BitSet(new ulong[]{0x4000000000UL});
		public static readonly BitSet _declarationbody_in_paramsdeclaration1532 = new BitSet(new ulong[]{0x2UL,0x100UL});
		public static readonly BitSet _extended_id_in_funccallbody1558 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_funccallbody1561 = new BitSet(new ulong[]{0xE601062000000000UL,0x1UL});
		public static readonly BitSet _expressioncommalist_in_funccallbody1563 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_funccallbody1566 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_funccall1587 = new BitSet(new ulong[]{0x0UL,0x80UL});
		public static readonly BitSet _71_in_funccall1589 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_expressioncommalist1596 = new BitSet(new ulong[]{0x2UL,0x100UL});
		public static readonly BitSet _72_in_expressioncommalist1600 = new BitSet(new ulong[]{0xE201062000000000UL,0x1UL});
		public static readonly BitSet _expression_in_expressioncommalist1603 = new BitSet(new ulong[]{0x2UL,0x100UL});
		public static readonly BitSet _69_in_object_initializer1615 = new BitSet(new ulong[]{0xE201062000000000UL,0x1UL});
		public static readonly BitSet _expressioncommalist_in_object_initializer1617 = new BitSet(new ulong[]{0x0UL,0x40UL});
		public static readonly BitSet _70_in_object_initializer1619 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _KNEW_in_newexpression1634 = new BitSet(new ulong[]{0x4000000000UL});
		public static readonly BitSet _initializer_in_newexpression1637 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _simple_var_initializer_in_initializer1644 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_initializer_in_initializer1648 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_simple_var_initializer1655 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_simple_var_initializer1657 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_simple_var_initializer1659 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_array_initializer1673 = new BitSet(new ulong[]{0x108000000000UL});
		public static readonly BitSet _OPEN_SQUARE_BRACE_in_array_initializer1677 = new BitSet(new ulong[]{0x201062000000000UL});
		public static readonly BitSet _mathexpression_in_array_initializer1679 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _CLOSE_SQUARE_BRACE_in_array_initializer1681 = new BitSet(new ulong[]{0x2UL,0x20UL});
		public static readonly BitSet _ARRAY_DECLARATION_MARK_in_array_initializer1686 = new BitSet(new ulong[]{0x2UL,0x20UL});
		public static readonly BitSet _object_initializer_in_array_initializer1689 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _69_in_block1711 = new BitSet(new ulong[]{0x201066000003A80UL,0x61UL});
		public static readonly BitSet _statementlist_in_block1714 = new BitSet(new ulong[]{0x0UL,0x40UL});
		public static readonly BitSet _70_in_block1716 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_statementlist1724 = new BitSet(new ulong[]{0x201066000003A82UL,0x21UL});
		public static readonly BitSet _funccallbody_in_synpred20_MathLang641 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolexpression_in_synpred21_MathLang647 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_synpred39_MathLang1111 = new BitSet(new ulong[]{0x201062000000000UL});
		public static readonly BitSet _add_in_synpred39_MathLang1137 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _OPEN_BRACE_in_synpred48_MathLang1297 = new BitSet(new ulong[]{0xE201062000000000UL});
		public static readonly BitSet _boolterm_in_synpred48_MathLang1300 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_synpred48_MathLang1302 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ELSE_in_synpred53_MathLang1356 = new BitSet(new ulong[]{0x201066000003A80UL,0x21UL});
		public static readonly BitSet _block_in_synpred53_MathLang1360 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_synpred53_MathLang1364 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  MathLang 

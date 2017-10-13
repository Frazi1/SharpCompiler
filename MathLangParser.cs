// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-10-13 22:31:53

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "UNKNOWN", "PRINT", "INPUT", "IF", "ELSE", "FOR", "FUNCTION", "RETURN", "WHILE", "DO", "BLOCK", "PROGRAM", "PARAMS", "VARDECLARATION", "FUNCDECLARATION", "ARRAYDECLARATION", "VARASSIGNMENT", "ARRAYELEMENTASSIGNMENT", "ARRAYELEMENT", "NEWVAR", "ARRAY_INITIALIZER", "OBJECT_INITIALIZER", "FUNC_CALL", "RETURN_TYPE", "PARAMETERS", "STATIC_DECLARATION", "CLASSBLOCK", "CLASS_WORD", "MODIFIER", "ID", "TYPE", "ARRAY_DECLARATION_MARK", "VOID", "NUMBER", "CHAR", "ASSIGN", "ADD", "SUB", "MUL", "DIV", "GREQ", "LSEQ", "NEQ", "EQ", "GR", "LS", "OPEN_BRACE", "CLOSE_BRACE", "OR", "AND", "NOT", "TRUE", "FALSE", "KNEW", "OPEN_SQUARE_BRACE", "CLOSE_SQUARE_BRACE", "CONSOLE_WORD", "WS", "SL_COMMENT", "ML_COMMENT", "'{'", "'}'", "';'", "','"
	};
	public const int EOF=-1;
	public const int T__64=64;
	public const int T__65=65;
	public const int T__66=66;
	public const int T__67=67;
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
	public const int MODIFIER=32;
	public const int ID=33;
	public const int TYPE=34;
	public const int ARRAY_DECLARATION_MARK=35;
	public const int VOID=36;
	public const int NUMBER=37;
	public const int CHAR=38;
	public const int ASSIGN=39;
	public const int ADD=40;
	public const int SUB=41;
	public const int MUL=42;
	public const int DIV=43;
	public const int GREQ=44;
	public const int LSEQ=45;
	public const int NEQ=46;
	public const int EQ=47;
	public const int GR=48;
	public const int LS=49;
	public const int OPEN_BRACE=50;
	public const int CLOSE_BRACE=51;
	public const int OR=52;
	public const int AND=53;
	public const int NOT=54;
	public const int TRUE=55;
	public const int FALSE=56;
	public const int KNEW=57;
	public const int OPEN_SQUARE_BRACE=58;
	public const int CLOSE_SQUARE_BRACE=59;
	public const int CONSOLE_WORD=60;
	public const int WS=61;
	public const int SL_COMMENT=62;
	public const int ML_COMMENT=63;

	// delegates
	// delegators

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, false, false, false, true, false, false, 
				false, false, false, true, false, false, false, false, false, false, 
				false, true, false, false, false, true, false, false, false, false, 
				false, false, false, false, false, false, false, , false
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
		this.state.ruleMemo = new System.Collections.Generic.Dictionary<int, int>[108+1];

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
	// MathLang.g:51:8: public execute : class_list EOF -> ^( PROGRAM class_list ) ;
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
		DebugLocation(51, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 1)) { return retval; }
			// MathLang.g:51:15: ( class_list EOF -> ^( PROGRAM class_list ) )
			DebugEnterAlt(1);
			// MathLang.g:52:2: class_list EOF
			{
			DebugLocation(52, 2);
			PushFollow(Follow._class_list_in_execute364);
			class_list1=class_list();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_class_list.Add(class_list1.Tree);
			DebugLocation(52, 16);
			EOF2=(IToken)Match(input,EOF,Follow._EOF_in_execute366); if (state.failed) return retval; 
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
			// 52:19: -> ^( PROGRAM class_list )
			{
				DebugLocation(52, 22);
				// MathLang.g:52:22: ^( PROGRAM class_list )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(52, 24);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROGRAM, "PROGRAM"), root_1);

				DebugLocation(52, 32);
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
		DebugLocation(53, 0);
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
	// MathLang.g:55:1: class_declaration : MODIFIER CLASS_WORD ID class_block -> ^( CLASS_WORD ID class_block ) ;
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
		DebugLocation(55, 86);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 2)) { return retval; }
			// MathLang.g:55:18: ( MODIFIER CLASS_WORD ID class_block -> ^( CLASS_WORD ID class_block ) )
			DebugEnterAlt(1);
			// MathLang.g:55:20: MODIFIER CLASS_WORD ID class_block
			{
			DebugLocation(55, 20);
			MODIFIER3=(IToken)Match(input,MODIFIER,Follow._MODIFIER_in_class_declaration385); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_MODIFIER.Add(MODIFIER3);

			DebugLocation(55, 29);
			CLASS_WORD4=(IToken)Match(input,CLASS_WORD,Follow._CLASS_WORD_in_class_declaration387); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CLASS_WORD.Add(CLASS_WORD4);

			DebugLocation(55, 40);
			ID5=(IToken)Match(input,ID,Follow._ID_in_class_declaration389); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID5);

			DebugLocation(55, 43);
			PushFollow(Follow._class_block_in_class_declaration391);
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
			// 55:55: -> ^( CLASS_WORD ID class_block )
			{
				DebugLocation(55, 58);
				// MathLang.g:55:58: ^( CLASS_WORD ID class_block )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(55, 60);
				root_1 = (object)adaptor.BecomeRoot(stream_CLASS_WORD.NextNode(), root_1);

				DebugLocation(55, 71);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(55, 74);
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
		DebugLocation(55, 86);
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
	// MathLang.g:57:1: class_block : '{' ( static_func_or_var_declaration )* '}' -> ^( CLASSBLOCK ( static_func_or_var_declaration )* ) ;
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
		RewriteRuleITokenStream stream_64=new RewriteRuleITokenStream(adaptor,"token 64");
		RewriteRuleITokenStream stream_65=new RewriteRuleITokenStream(adaptor,"token 65");
		RewriteRuleSubtreeStream stream_static_func_or_var_declaration=new RewriteRuleSubtreeStream(adaptor,"rule static_func_or_var_declaration");
		try { DebugEnterRule(GrammarFileName, "class_block");
		DebugLocation(57, 105);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 3)) { return retval; }
			// MathLang.g:57:12: ( '{' ( static_func_or_var_declaration )* '}' -> ^( CLASSBLOCK ( static_func_or_var_declaration )* ) )
			DebugEnterAlt(1);
			// MathLang.g:57:14: '{' ( static_func_or_var_declaration )* '}'
			{
			DebugLocation(57, 17);
			char_literal7=(IToken)Match(input,64,Follow._64_in_class_block409); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_64.Add(char_literal7);

			DebugLocation(57, 19);
			// MathLang.g:57:19: ( static_func_or_var_declaration )*
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
					DebugLocation(57, 19);
					PushFollow(Follow._static_func_or_var_declaration_in_class_block412);
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

			DebugLocation(57, 54);
			char_literal9=(IToken)Match(input,65,Follow._65_in_class_block415); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_65.Add(char_literal9);



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
			// 57:56: -> ^( CLASSBLOCK ( static_func_or_var_declaration )* )
			{
				DebugLocation(57, 59);
				// MathLang.g:57:59: ^( CLASSBLOCK ( static_func_or_var_declaration )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(57, 61);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(CLASSBLOCK, "CLASSBLOCK"), root_1);

				DebugLocation(57, 72);
				// MathLang.g:57:72: ( static_func_or_var_declaration )*
				while ( stream_static_func_or_var_declaration.HasNext )
				{
					DebugLocation(57, 72);
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
		DebugLocation(57, 105);
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
	// MathLang.g:59:1: static_func_or_var_declaration : ( static_declaration | funcdeclaration );
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
		DebugLocation(59, 69);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 4)) { return retval; }
			// MathLang.g:59:31: ( static_declaration | funcdeclaration )
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

							if ((LA2_6==ASSIGN||LA2_6==66))
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

						if ((LA2_5==ASSIGN||LA2_5==66))
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
				// MathLang.g:59:33: static_declaration
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(59, 33);
				PushFollow(Follow._static_declaration_in_static_func_or_var_declaration434);
				static_declaration10=static_declaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, static_declaration10.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:59:54: funcdeclaration
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(59, 54);
				PushFollow(Follow._funcdeclaration_in_static_func_or_var_declaration438);
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
		DebugLocation(59, 69);
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
	// MathLang.g:61:1: class_list : ( class_declaration )* ;
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
		DebugLocation(61, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 5)) { return retval; }
			// MathLang.g:61:11: ( ( class_declaration )* )
			DebugEnterAlt(1);
			// MathLang.g:61:14: ( class_declaration )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(61, 14);
			// MathLang.g:61:14: ( class_declaration )*
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
					DebugLocation(61, 14);
					PushFollow(Follow._class_declaration_in_class_list447);
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
		DebugLocation(61, 32);
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
	// MathLang.g:63:1: func_list : ( funcdeclaration )* -> ^( PROGRAM ( funcdeclaration )* ) ;
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
		DebugLocation(63, 61);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 6)) { return retval; }
			// MathLang.g:63:11: ( ( funcdeclaration )* -> ^( PROGRAM ( funcdeclaration )* ) )
			DebugEnterAlt(1);
			// MathLang.g:63:13: ( funcdeclaration )*
			{
			DebugLocation(63, 13);
			// MathLang.g:63:13: ( funcdeclaration )*
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
					DebugLocation(63, 13);
					PushFollow(Follow._funcdeclaration_in_func_list457);
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
			// 63:30: -> ^( PROGRAM ( funcdeclaration )* )
			{
				DebugLocation(63, 33);
				// MathLang.g:63:33: ^( PROGRAM ( funcdeclaration )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(63, 35);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROGRAM, "PROGRAM"), root_1);

				DebugLocation(63, 43);
				// MathLang.g:63:43: ( funcdeclaration )*
				while ( stream_funcdeclaration.HasNext )
				{
					DebugLocation(63, 43);
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
		DebugLocation(63, 61);
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
	// MathLang.g:65:1: statement : ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | returnstatement | funccall | newexpression ) ;
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
		DebugLocation(65, 4);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 7)) { return retval; }
			// MathLang.g:65:10: ( ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | returnstatement | funccall | newexpression ) )
			DebugEnterAlt(1);
			// MathLang.g:65:12: ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | returnstatement | funccall | newexpression )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(65, 12);
			// MathLang.g:65:12: ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | returnstatement | funccall | newexpression )
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
				// MathLang.g:65:14: declaration
				{
				DebugLocation(65, 14);
				PushFollow(Follow._declaration_in_statement478);
				declaration14=declaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, declaration14.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:66:4: assignment
				{
				DebugLocation(66, 4);
				PushFollow(Follow._assignment_in_statement484);
				assignment15=assignment();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment15.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:67:4: ifstatement
				{
				DebugLocation(67, 4);
				PushFollow(Follow._ifstatement_in_statement489);
				ifstatement16=ifstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ifstatement16.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:68:4: whilestatement
				{
				DebugLocation(68, 4);
				PushFollow(Follow._whilestatement_in_statement494);
				whilestatement17=whilestatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, whilestatement17.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:69:4: dowhilestatement
				{
				DebugLocation(69, 4);
				PushFollow(Follow._dowhilestatement_in_statement499);
				dowhilestatement18=dowhilestatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dowhilestatement18.Tree);

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// MathLang.g:70:4: forstatement
				{
				DebugLocation(70, 4);
				PushFollow(Follow._forstatement_in_statement504);
				forstatement19=forstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forstatement19.Tree);

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// MathLang.g:71:4: returnstatement
				{
				DebugLocation(71, 4);
				PushFollow(Follow._returnstatement_in_statement509);
				returnstatement20=returnstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, returnstatement20.Tree);

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// MathLang.g:72:4: funccall
				{
				DebugLocation(72, 4);
				PushFollow(Follow._funccall_in_statement514);
				funccall21=funccall();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccall21.Tree);

				}
				break;
			case 9:
				DebugEnterAlt(9);
				// MathLang.g:73:4: newexpression
				{
				DebugLocation(73, 4);
				PushFollow(Follow._newexpression_in_statement519);
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
		DebugLocation(75, 4);
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
	// MathLang.g:77:1: type : TYPE ;
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
		DebugLocation(77, 11);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 8)) { return retval; }
			// MathLang.g:77:5: ( TYPE )
			DebugEnterAlt(1);
			// MathLang.g:77:7: TYPE
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(77, 7);
			TYPE23=(IToken)Match(input,TYPE,Follow._TYPE_in_type533); if (state.failed) return retval;
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
		DebugLocation(77, 11);
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
	// MathLang.g:78:1: array_type : TYPE ARRAY_DECLARATION_MARK ;
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
		DebugLocation(78, 40);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 9)) { return retval; }
			// MathLang.g:78:11: ( TYPE ARRAY_DECLARATION_MARK )
			DebugEnterAlt(1);
			// MathLang.g:78:13: TYPE ARRAY_DECLARATION_MARK
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(78, 13);
			TYPE24=(IToken)Match(input,TYPE,Follow._TYPE_in_array_type540); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			TYPE24_tree = (object)adaptor.Create(TYPE24);
			adaptor.AddChild(root_0, TYPE24_tree);
			}
			DebugLocation(78, 40);
			ARRAY_DECLARATION_MARK25=(IToken)Match(input,ARRAY_DECLARATION_MARK,Follow._ARRAY_DECLARATION_MARK_in_array_type542); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(78, 40);
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
	// MathLang.g:79:1: any_type : ( type | array_type | VOID );
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
		DebugLocation(79, 34);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 10)) { return retval; }
			// MathLang.g:79:9: ( type | array_type | VOID )
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
				// MathLang.g:79:11: type
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(79, 11);
				PushFollow(Follow._type_in_any_type549);
				type26=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type26.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:79:18: array_type
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(79, 18);
				PushFollow(Follow._array_type_in_any_type553);
				array_type27=array_type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, array_type27.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:79:31: VOID
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(79, 31);
				VOID28=(IToken)Match(input,VOID,Follow._VOID_in_any_type557); if (state.failed) return retval;
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
		DebugLocation(79, 34);
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
	// MathLang.g:80:1: number : ( NUMBER | ID | funccallbody | CHAR | arrayelement );
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
		IToken ID30=null;
		IToken CHAR32=null;
		MathLangParser.funccallbody_return funccallbody31 = default(MathLangParser.funccallbody_return);
		MathLangParser.arrayelement_return arrayelement33 = default(MathLangParser.arrayelement_return);

		object NUMBER29_tree=null;
		object ID30_tree=null;
		object CHAR32_tree=null;

		try { DebugEnterRule(GrammarFileName, "number");
		DebugLocation(80, 16);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 11)) { return retval; }
			// MathLang.g:80:8: ( NUMBER | ID | funccallbody | CHAR | arrayelement )
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
				case CLOSE_BRACE:
				case OR:
				case AND:
				case CLOSE_SQUARE_BRACE:
				case 65:
				case 66:
				case 67:
					{
					alt7=2;
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
				// MathLang.g:80:11: NUMBER
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(80, 11);
				NUMBER29=(IToken)Match(input,NUMBER,Follow._NUMBER_in_number565); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				NUMBER29_tree = (object)adaptor.Create(NUMBER29);
				adaptor.AddChild(root_0, NUMBER29_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:81:5: ID
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(81, 5);
				ID30=(IToken)Match(input,ID,Follow._ID_in_number571); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				ID30_tree = (object)adaptor.Create(ID30);
				adaptor.AddChild(root_0, ID30_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:82:5: funccallbody
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(82, 5);
				PushFollow(Follow._funccallbody_in_number577);
				funccallbody31=funccallbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody31.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:83:5: CHAR
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(83, 5);
				CHAR32=(IToken)Match(input,CHAR,Follow._CHAR_in_number583); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				CHAR32_tree = (object)adaptor.Create(CHAR32);
				adaptor.AddChild(root_0, CHAR32_tree);
				}

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:84:5: arrayelement
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(84, 5);
				PushFollow(Follow._arrayelement_in_number589);
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
		DebugLocation(84, 16);
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
	// MathLang.g:85:1: mathexpression : term ;
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
		DebugLocation(85, 21);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 12)) { return retval; }
			// MathLang.g:85:15: ( term )
			DebugEnterAlt(1);
			// MathLang.g:85:17: term
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(85, 17);
			PushFollow(Follow._term_in_mathexpression595);
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
		DebugLocation(85, 21);
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
	// MathLang.g:87:1: expression : ( newexpression | funccallbody | boolexpression | mathexpression );
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
		DebugLocation(87, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 13)) { return retval; }
			// MathLang.g:87:11: ( newexpression | funccallbody | boolexpression | mathexpression )
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
				// MathLang.g:88:5: newexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(88, 5);
				PushFollow(Follow._newexpression_in_expression609);
				newexpression35=newexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, newexpression35.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:89:5: funccallbody
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(89, 5);
				PushFollow(Follow._funccallbody_in_expression615);
				funccallbody36=funccallbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody36.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:90:5: boolexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(90, 5);
				PushFollow(Follow._boolexpression_in_expression621);
				boolexpression37=boolexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression37.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:91:5: mathexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(91, 5);
				PushFollow(Follow._mathexpression_in_expression627);
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
		DebugLocation(94, 0);
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
	// MathLang.g:96:1: arrayelement : ID '[' number ']' -> ^( ARRAYELEMENT ID number ) ;
	[GrammarRule("arrayelement")]
	private MathLangParser.arrayelement_return arrayelement()
	{
		Enter_arrayelement();
		EnterRule("arrayelement", 14);
		TraceIn("arrayelement", 14);
		MathLangParser.arrayelement_return retval = new MathLangParser.arrayelement_return();
		retval.Start = (IToken)input.LT(1);
		int arrayelement_StartIndex = input.Index;
		object root_0 = null;

		IToken ID39=null;
		IToken char_literal40=null;
		IToken char_literal42=null;
		MathLangParser.number_return number41 = default(MathLangParser.number_return);

		object ID39_tree=null;
		object char_literal40_tree=null;
		object char_literal42_tree=null;
		RewriteRuleITokenStream stream_OPEN_SQUARE_BRACE=new RewriteRuleITokenStream(adaptor,"token OPEN_SQUARE_BRACE");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_CLOSE_SQUARE_BRACE=new RewriteRuleITokenStream(adaptor,"token CLOSE_SQUARE_BRACE");
		RewriteRuleSubtreeStream stream_number=new RewriteRuleSubtreeStream(adaptor,"rule number");
		try { DebugEnterRule(GrammarFileName, "arrayelement");
		DebugLocation(96, 62);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 14)) { return retval; }
			// MathLang.g:96:13: ( ID '[' number ']' -> ^( ARRAYELEMENT ID number ) )
			DebugEnterAlt(1);
			// MathLang.g:96:16: ID '[' number ']'
			{
			DebugLocation(96, 16);
			ID39=(IToken)Match(input,ID,Follow._ID_in_arrayelement642); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID39);

			DebugLocation(96, 19);
			char_literal40=(IToken)Match(input,OPEN_SQUARE_BRACE,Follow._OPEN_SQUARE_BRACE_in_arrayelement644); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OPEN_SQUARE_BRACE.Add(char_literal40);

			DebugLocation(96, 23);
			PushFollow(Follow._number_in_arrayelement646);
			number41=number();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_number.Add(number41.Tree);
			DebugLocation(96, 30);
			char_literal42=(IToken)Match(input,CLOSE_SQUARE_BRACE,Follow._CLOSE_SQUARE_BRACE_in_arrayelement648); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CLOSE_SQUARE_BRACE.Add(char_literal42);



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
			// 96:34: -> ^( ARRAYELEMENT ID number )
			{
				DebugLocation(96, 37);
				// MathLang.g:96:37: ^( ARRAYELEMENT ID number )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(96, 39);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYELEMENT, "ARRAYELEMENT"), root_1);

				DebugLocation(96, 52);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(96, 55);
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
			TraceOut("arrayelement", 14);
			LeaveRule("arrayelement", 14);
			Leave_arrayelement();
			if (state.backtracking > 0) { Memoize(input, 14, arrayelement_StartIndex); }
		}
		DebugLocation(96, 62);
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
	// MathLang.g:97:1: static_declaration : MODIFIER declaration -> ^( STATIC_DECLARATION declaration ) ;
	[GrammarRule("static_declaration")]
	private MathLangParser.static_declaration_return static_declaration()
	{
		Enter_static_declaration();
		EnterRule("static_declaration", 15);
		TraceIn("static_declaration", 15);
		MathLangParser.static_declaration_return retval = new MathLangParser.static_declaration_return();
		retval.Start = (IToken)input.LT(1);
		int static_declaration_StartIndex = input.Index;
		object root_0 = null;

		IToken MODIFIER43=null;
		MathLangParser.declaration_return declaration44 = default(MathLangParser.declaration_return);

		object MODIFIER43_tree=null;
		RewriteRuleITokenStream stream_MODIFIER=new RewriteRuleITokenStream(adaptor,"token MODIFIER");
		RewriteRuleSubtreeStream stream_declaration=new RewriteRuleSubtreeStream(adaptor,"rule declaration");
		try { DebugEnterRule(GrammarFileName, "static_declaration");
		DebugLocation(97, 78);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 15)) { return retval; }
			// MathLang.g:97:19: ( MODIFIER declaration -> ^( STATIC_DECLARATION declaration ) )
			DebugEnterAlt(1);
			// MathLang.g:97:22: MODIFIER declaration
			{
			DebugLocation(97, 22);
			MODIFIER43=(IToken)Match(input,MODIFIER,Follow._MODIFIER_in_static_declaration666); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_MODIFIER.Add(MODIFIER43);

			DebugLocation(97, 31);
			PushFollow(Follow._declaration_in_static_declaration668);
			declaration44=declaration();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declaration.Add(declaration44.Tree);


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
			// 97:43: -> ^( STATIC_DECLARATION declaration )
			{
				DebugLocation(97, 46);
				// MathLang.g:97:46: ^( STATIC_DECLARATION declaration )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(97, 48);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(STATIC_DECLARATION, "STATIC_DECLARATION"), root_1);

				DebugLocation(97, 67);
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
			TraceOut("static_declaration", 15);
			LeaveRule("static_declaration", 15);
			Leave_static_declaration();
			if (state.backtracking > 0) { Memoize(input, 15, static_declaration_StartIndex); }
		}
		DebugLocation(97, 78);
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
	// MathLang.g:98:1: declaration : ( declarationbody ';' | longdeclaration );
	[GrammarRule("declaration")]
	private MathLangParser.declaration_return declaration()
	{
		Enter_declaration();
		EnterRule("declaration", 16);
		TraceIn("declaration", 16);
		MathLangParser.declaration_return retval = new MathLangParser.declaration_return();
		retval.Start = (IToken)input.LT(1);
		int declaration_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal46=null;
		MathLangParser.declarationbody_return declarationbody45 = default(MathLangParser.declarationbody_return);
		MathLangParser.longdeclaration_return longdeclaration47 = default(MathLangParser.longdeclaration_return);

		object char_literal46_tree=null;

		try { DebugEnterRule(GrammarFileName, "declaration");
		DebugLocation(98, 20);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 16)) { return retval; }
			// MathLang.g:98:12: ( declarationbody ';' | longdeclaration )
			int alt9=2;
			try { DebugEnterDecision(9, decisionCanBacktrack[9]);
			int LA9_0 = input.LA(1);

			if ((LA9_0==TYPE))
			{
				int LA9_1 = input.LA(2);

				if ((LA9_1==ARRAY_DECLARATION_MARK))
				{
					int LA9_2 = input.LA(3);

					if ((LA9_2==ID))
					{
						int LA9_4 = input.LA(4);

						if ((LA9_4==ASSIGN))
						{
							alt9=2;
						}
						else if ((LA9_4==66))
						{
							alt9=1;
						}
						else
						{
							if (state.backtracking>0) {state.failed=true; return retval;}
							NoViableAltException nvae = new NoViableAltException("", 9, 4, input);

							DebugRecognitionException(nvae);
							throw nvae;
						}
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 9, 2, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}
				else if ((LA9_1==ID))
				{
					int LA9_3 = input.LA(3);

					if ((LA9_3==ASSIGN))
					{
						alt9=2;
					}
					else if ((LA9_3==66))
					{
						alt9=1;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 9, 3, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 9, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
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
				// MathLang.g:98:14: declarationbody ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(98, 14);
				PushFollow(Follow._declarationbody_in_declaration682);
				declarationbody45=declarationbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, declarationbody45.Tree);
				DebugLocation(98, 33);
				char_literal46=(IToken)Match(input,66,Follow._66_in_declaration684); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:99:6: longdeclaration
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(99, 6);
				PushFollow(Follow._longdeclaration_in_declaration692);
				longdeclaration47=longdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclaration47.Tree);

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
			TraceOut("declaration", 16);
			LeaveRule("declaration", 16);
			Leave_declaration();
			if (state.backtracking > 0) { Memoize(input, 16, declaration_StartIndex); }
		}
		DebugLocation(99, 20);
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
	// MathLang.g:101:1: declarationbody : ( ( type ID -> ^( VARDECLARATION type ID ) ) | ( array_type ID -> ^( ARRAYDECLARATION array_type ID ) ) );
	[GrammarRule("declarationbody")]
	private MathLangParser.declarationbody_return declarationbody()
	{
		Enter_declarationbody();
		EnterRule("declarationbody", 17);
		TraceIn("declarationbody", 17);
		MathLangParser.declarationbody_return retval = new MathLangParser.declarationbody_return();
		retval.Start = (IToken)input.LT(1);
		int declarationbody_StartIndex = input.Index;
		object root_0 = null;

		IToken ID49=null;
		IToken ID51=null;
		MathLangParser.type_return type48 = default(MathLangParser.type_return);
		MathLangParser.array_type_return array_type50 = default(MathLangParser.array_type_return);

		object ID49_tree=null;
		object ID51_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleSubtreeStream stream_array_type=new RewriteRuleSubtreeStream(adaptor,"rule array_type");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "declarationbody");
		DebugLocation(101, 4);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 17)) { return retval; }
			// MathLang.g:101:16: ( ( type ID -> ^( VARDECLARATION type ID ) ) | ( array_type ID -> ^( ARRAYDECLARATION array_type ID ) ) )
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
				// MathLang.g:101:18: ( type ID -> ^( VARDECLARATION type ID ) )
				{
				DebugLocation(101, 18);
				// MathLang.g:101:18: ( type ID -> ^( VARDECLARATION type ID ) )
				DebugEnterAlt(1);
				// MathLang.g:101:19: type ID
				{
				DebugLocation(101, 19);
				PushFollow(Follow._type_in_declarationbody700);
				type48=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type48.Tree);
				DebugLocation(101, 24);
				ID49=(IToken)Match(input,ID,Follow._ID_in_declarationbody702); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID49);



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
				// 101:27: -> ^( VARDECLARATION type ID )
				{
					DebugLocation(101, 30);
					// MathLang.g:101:30: ^( VARDECLARATION type ID )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(101, 32);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDECLARATION, "VARDECLARATION"), root_1);

					DebugLocation(101, 47);
					adaptor.AddChild(root_1, stream_type.NextTree());
					DebugLocation(101, 52);
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
				// MathLang.g:102:7: ( array_type ID -> ^( ARRAYDECLARATION array_type ID ) )
				{
				DebugLocation(102, 7);
				// MathLang.g:102:7: ( array_type ID -> ^( ARRAYDECLARATION array_type ID ) )
				DebugEnterAlt(1);
				// MathLang.g:102:8: array_type ID
				{
				DebugLocation(102, 8);
				PushFollow(Follow._array_type_in_declarationbody723);
				array_type50=array_type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_array_type.Add(array_type50.Tree);
				DebugLocation(102, 19);
				ID51=(IToken)Match(input,ID,Follow._ID_in_declarationbody725); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID51);



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
				// 102:22: -> ^( ARRAYDECLARATION array_type ID )
				{
					DebugLocation(102, 25);
					// MathLang.g:102:25: ^( ARRAYDECLARATION array_type ID )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(102, 27);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYDECLARATION, "ARRAYDECLARATION"), root_1);

					DebugLocation(102, 44);
					adaptor.AddChild(root_1, stream_array_type.NextTree());
					DebugLocation(102, 55);
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
			TraceOut("declarationbody", 17);
			LeaveRule("declarationbody", 17);
			Leave_declarationbody();
			if (state.backtracking > 0) { Memoize(input, 17, declarationbody_StartIndex); }
		}
		DebugLocation(103, 4);
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
	// MathLang.g:104:1: longdeclaration : longdeclarationbody ';' ;
	[GrammarRule("longdeclaration")]
	private MathLangParser.longdeclaration_return longdeclaration()
	{
		Enter_longdeclaration();
		EnterRule("longdeclaration", 18);
		TraceIn("longdeclaration", 18);
		MathLangParser.longdeclaration_return retval = new MathLangParser.longdeclaration_return();
		retval.Start = (IToken)input.LT(1);
		int longdeclaration_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal53=null;
		MathLangParser.longdeclarationbody_return longdeclarationbody52 = default(MathLangParser.longdeclarationbody_return);

		object char_literal53_tree=null;

		try { DebugEnterRule(GrammarFileName, "longdeclaration");
		DebugLocation(104, 42);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 18)) { return retval; }
			// MathLang.g:104:16: ( longdeclarationbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:104:18: longdeclarationbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(104, 18);
			PushFollow(Follow._longdeclarationbody_in_longdeclaration747);
			longdeclarationbody52=longdeclarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclarationbody52.Tree);
			DebugLocation(104, 41);
			char_literal53=(IToken)Match(input,66,Follow._66_in_longdeclaration749); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("longdeclaration", 18);
			LeaveRule("longdeclaration", 18);
			Leave_longdeclaration();
			if (state.backtracking > 0) { Memoize(input, 18, longdeclaration_StartIndex); }
		}
		DebugLocation(104, 42);
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
	// MathLang.g:105:1: longdeclarationbody : ( ( type ID ASSIGN expression -> ^( VARDECLARATION type ID expression ) ) | ( array_type ID ASSIGN newexpression -> ^( ARRAYDECLARATION array_type ID newexpression ) ) );
	[GrammarRule("longdeclarationbody")]
	private MathLangParser.longdeclarationbody_return longdeclarationbody()
	{
		Enter_longdeclarationbody();
		EnterRule("longdeclarationbody", 19);
		TraceIn("longdeclarationbody", 19);
		MathLangParser.longdeclarationbody_return retval = new MathLangParser.longdeclarationbody_return();
		retval.Start = (IToken)input.LT(1);
		int longdeclarationbody_StartIndex = input.Index;
		object root_0 = null;

		IToken ID55=null;
		IToken ASSIGN56=null;
		IToken ID59=null;
		IToken ASSIGN60=null;
		MathLangParser.type_return type54 = default(MathLangParser.type_return);
		MathLangParser.expression_return expression57 = default(MathLangParser.expression_return);
		MathLangParser.array_type_return array_type58 = default(MathLangParser.array_type_return);
		MathLangParser.newexpression_return newexpression61 = default(MathLangParser.newexpression_return);

		object ID55_tree=null;
		object ASSIGN56_tree=null;
		object ID59_tree=null;
		object ASSIGN60_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_newexpression=new RewriteRuleSubtreeStream(adaptor,"rule newexpression");
		RewriteRuleSubtreeStream stream_array_type=new RewriteRuleSubtreeStream(adaptor,"rule array_type");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "longdeclarationbody");
		DebugLocation(105, 94);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 19)) { return retval; }
			// MathLang.g:105:20: ( ( type ID ASSIGN expression -> ^( VARDECLARATION type ID expression ) ) | ( array_type ID ASSIGN newexpression -> ^( ARRAYDECLARATION array_type ID newexpression ) ) )
			int alt11=2;
			try { DebugEnterDecision(11, decisionCanBacktrack[11]);
			int LA11_0 = input.LA(1);

			if ((LA11_0==TYPE))
			{
				int LA11_1 = input.LA(2);

				if ((LA11_1==ARRAY_DECLARATION_MARK))
				{
					alt11=2;
				}
				else if ((LA11_1==ID))
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
				// MathLang.g:105:22: ( type ID ASSIGN expression -> ^( VARDECLARATION type ID expression ) )
				{
				DebugLocation(105, 22);
				// MathLang.g:105:22: ( type ID ASSIGN expression -> ^( VARDECLARATION type ID expression ) )
				DebugEnterAlt(1);
				// MathLang.g:105:23: type ID ASSIGN expression
				{
				DebugLocation(105, 23);
				PushFollow(Follow._type_in_longdeclarationbody758);
				type54=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type54.Tree);
				DebugLocation(105, 28);
				ID55=(IToken)Match(input,ID,Follow._ID_in_longdeclarationbody760); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID55);

				DebugLocation(105, 31);
				ASSIGN56=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclarationbody762); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN56);

				DebugLocation(105, 38);
				PushFollow(Follow._expression_in_longdeclarationbody764);
				expression57=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression57.Tree);


				{
				// AST REWRITE
				// elements: ID, type, expression
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 105:50: -> ^( VARDECLARATION type ID expression )
				{
					DebugLocation(105, 53);
					// MathLang.g:105:53: ^( VARDECLARATION type ID expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(105, 55);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDECLARATION, "VARDECLARATION"), root_1);

					DebugLocation(105, 70);
					adaptor.AddChild(root_1, stream_type.NextTree());
					DebugLocation(105, 75);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(105, 78);
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
				// MathLang.g:106:8: ( array_type ID ASSIGN newexpression -> ^( ARRAYDECLARATION array_type ID newexpression ) )
				{
				DebugLocation(106, 8);
				// MathLang.g:106:8: ( array_type ID ASSIGN newexpression -> ^( ARRAYDECLARATION array_type ID newexpression ) )
				DebugEnterAlt(1);
				// MathLang.g:106:9: array_type ID ASSIGN newexpression
				{
				DebugLocation(106, 9);
				PushFollow(Follow._array_type_in_longdeclarationbody788);
				array_type58=array_type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_array_type.Add(array_type58.Tree);
				DebugLocation(106, 20);
				ID59=(IToken)Match(input,ID,Follow._ID_in_longdeclarationbody790); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID59);

				DebugLocation(106, 23);
				ASSIGN60=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclarationbody792); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN60);

				DebugLocation(106, 30);
				PushFollow(Follow._newexpression_in_longdeclarationbody794);
				newexpression61=newexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_newexpression.Add(newexpression61.Tree);


				{
				// AST REWRITE
				// elements: ID, newexpression, array_type
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 106:44: -> ^( ARRAYDECLARATION array_type ID newexpression )
				{
					DebugLocation(106, 47);
					// MathLang.g:106:47: ^( ARRAYDECLARATION array_type ID newexpression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(106, 49);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYDECLARATION, "ARRAYDECLARATION"), root_1);

					DebugLocation(106, 66);
					adaptor.AddChild(root_1, stream_array_type.NextTree());
					DebugLocation(106, 77);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(106, 80);
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
			TraceOut("longdeclarationbody", 19);
			LeaveRule("longdeclarationbody", 19);
			Leave_longdeclarationbody();
			if (state.backtracking > 0) { Memoize(input, 19, longdeclarationbody_StartIndex); }
		}
		DebugLocation(106, 94);
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
	// MathLang.g:108:1: add : mul ( ( ADD | SUB ) mul )* ;
	[GrammarRule("add")]
	private MathLangParser.add_return add()
	{
		Enter_add();
		EnterRule("add", 20);
		TraceIn("add", 20);
		MathLangParser.add_return retval = new MathLangParser.add_return();
		retval.Start = (IToken)input.LT(1);
		int add_StartIndex = input.Index;
		object root_0 = null;

		IToken set63=null;
		MathLangParser.mul_return mul62 = default(MathLangParser.mul_return);
		MathLangParser.mul_return mul64 = default(MathLangParser.mul_return);

		object set63_tree=null;

		try { DebugEnterRule(GrammarFileName, "add");
		DebugLocation(108, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 20)) { return retval; }
			// MathLang.g:108:4: ( mul ( ( ADD | SUB ) mul )* )
			DebugEnterAlt(1);
			// MathLang.g:108:6: mul ( ( ADD | SUB ) mul )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(108, 6);
			PushFollow(Follow._mul_in_add814);
			mul62=mul();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul62.Tree);
			DebugLocation(108, 10);
			// MathLang.g:108:10: ( ( ADD | SUB ) mul )*
			try { DebugEnterSubRule(12);
			while (true)
			{
				int alt12=2;
				try { DebugEnterDecision(12, decisionCanBacktrack[12]);
				int LA12_0 = input.LA(1);

				if (((LA12_0>=ADD && LA12_0<=SUB)))
				{
					alt12=1;
				}


				} finally { DebugExitDecision(12); }
				switch ( alt12 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:108:12: ( ADD | SUB ) mul
					{
					DebugLocation(108, 12);
					set63=(IToken)input.LT(1);
					set63=(IToken)input.LT(1);
					if ((input.LA(1)>=ADD && input.LA(1)<=SUB))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set63), root_0);
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(108, 25);
					PushFollow(Follow._mul_in_add827);
					mul64=mul();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul64.Tree);

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
			TraceOut("add", 20);
			LeaveRule("add", 20);
			Leave_add();
			if (state.backtracking > 0) { Memoize(input, 20, add_StartIndex); }
		}
		DebugLocation(108, 30);
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
	// MathLang.g:109:1: mul : group ( ( MUL | DIV ) group )* ;
	[GrammarRule("mul")]
	private MathLangParser.mul_return mul()
	{
		Enter_mul();
		EnterRule("mul", 21);
		TraceIn("mul", 21);
		MathLangParser.mul_return retval = new MathLangParser.mul_return();
		retval.Start = (IToken)input.LT(1);
		int mul_StartIndex = input.Index;
		object root_0 = null;

		IToken set66=null;
		MathLangParser.group_return group65 = default(MathLangParser.group_return);
		MathLangParser.group_return group67 = default(MathLangParser.group_return);

		object set66_tree=null;

		try { DebugEnterRule(GrammarFileName, "mul");
		DebugLocation(109, 33);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 21)) { return retval; }
			// MathLang.g:109:4: ( group ( ( MUL | DIV ) group )* )
			DebugEnterAlt(1);
			// MathLang.g:109:6: group ( ( MUL | DIV ) group )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(109, 6);
			PushFollow(Follow._group_in_mul836);
			group65=group();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group65.Tree);
			DebugLocation(109, 12);
			// MathLang.g:109:12: ( ( MUL | DIV ) group )*
			try { DebugEnterSubRule(13);
			while (true)
			{
				int alt13=2;
				try { DebugEnterDecision(13, decisionCanBacktrack[13]);
				int LA13_0 = input.LA(1);

				if (((LA13_0>=MUL && LA13_0<=DIV)))
				{
					alt13=1;
				}


				} finally { DebugExitDecision(13); }
				switch ( alt13 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:109:14: ( MUL | DIV ) group
					{
					DebugLocation(109, 14);
					set66=(IToken)input.LT(1);
					set66=(IToken)input.LT(1);
					if ((input.LA(1)>=MUL && input.LA(1)<=DIV))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set66), root_0);
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(109, 27);
					PushFollow(Follow._group_in_mul849);
					group67=group();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group67.Tree);

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
			TraceOut("mul", 21);
			LeaveRule("mul", 21);
			Leave_mul();
			if (state.backtracking > 0) { Memoize(input, 21, mul_StartIndex); }
		}
		DebugLocation(109, 33);
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
	// MathLang.g:110:1: compare : add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )? ;
	[GrammarRule("compare")]
	private MathLangParser.compare_return compare()
	{
		Enter_compare();
		EnterRule("compare", 22);
		TraceIn("compare", 22);
		MathLangParser.compare_return retval = new MathLangParser.compare_return();
		retval.Start = (IToken)input.LT(1);
		int compare_StartIndex = input.Index;
		object root_0 = null;

		IToken set69=null;
		MathLangParser.add_return add68 = default(MathLangParser.add_return);
		MathLangParser.add_return add70 = default(MathLangParser.add_return);

		object set69_tree=null;

		try { DebugEnterRule(GrammarFileName, "compare");
		DebugLocation(110, 60);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 22)) { return retval; }
			// MathLang.g:110:8: ( add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )? )
			DebugEnterAlt(1);
			// MathLang.g:110:10: add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(110, 10);
			PushFollow(Follow._add_in_compare857);
			add68=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add68.Tree);
			DebugLocation(110, 14);
			// MathLang.g:110:14: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
			int alt14=2;
			try { DebugEnterSubRule(14);
			try { DebugEnterDecision(14, decisionCanBacktrack[14]);
			try
			{
				alt14 = dfa14.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(14); }
			switch (alt14)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:110:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
				{
				DebugLocation(110, 16);
				set69=(IToken)input.LT(1);
				set69=(IToken)input.LT(1);
				if ((input.LA(1)>=GREQ && input.LA(1)<=LS))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set69), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(110, 53);
				PushFollow(Follow._add_in_compare887);
				add70=add();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add70.Tree);

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
			TraceOut("compare", 22);
			LeaveRule("compare", 22);
			Leave_compare();
			if (state.backtracking > 0) { Memoize(input, 22, compare_StartIndex); }
		}
		DebugLocation(110, 60);
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
	// MathLang.g:111:1: term : add ;
	[GrammarRule("term")]
	private MathLangParser.term_return term()
	{
		Enter_term();
		EnterRule("term", 23);
		TraceIn("term", 23);
		MathLangParser.term_return retval = new MathLangParser.term_return();
		retval.Start = (IToken)input.LT(1);
		int term_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.add_return add71 = default(MathLangParser.add_return);


		try { DebugEnterRule(GrammarFileName, "term");
		DebugLocation(111, 9);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 23)) { return retval; }
			// MathLang.g:111:5: ( add )
			DebugEnterAlt(1);
			// MathLang.g:111:7: add
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(111, 7);
			PushFollow(Follow._add_in_term898);
			add71=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add71.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("term", 23);
			LeaveRule("term", 23);
			Leave_term();
			if (state.backtracking > 0) { Memoize(input, 23, term_StartIndex); }
		}
		DebugLocation(111, 9);
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
	// MathLang.g:112:1: group : ( ( SUB )? OPEN_BRACE term CLOSE_BRACE | number );
	[GrammarRule("group")]
	private MathLangParser.group_return group()
	{
		Enter_group();
		EnterRule("group", 24);
		TraceIn("group", 24);
		MathLangParser.group_return retval = new MathLangParser.group_return();
		retval.Start = (IToken)input.LT(1);
		int group_StartIndex = input.Index;
		object root_0 = null;

		IToken SUB72=null;
		IToken OPEN_BRACE73=null;
		IToken CLOSE_BRACE75=null;
		MathLangParser.term_return term74 = default(MathLangParser.term_return);
		MathLangParser.number_return number76 = default(MathLangParser.number_return);

		object SUB72_tree=null;
		object OPEN_BRACE73_tree=null;
		object CLOSE_BRACE75_tree=null;

		try { DebugEnterRule(GrammarFileName, "group");
		DebugLocation(112, 53);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 24)) { return retval; }
			// MathLang.g:112:6: ( ( SUB )? OPEN_BRACE term CLOSE_BRACE | number )
			int alt16=2;
			try { DebugEnterDecision(16, decisionCanBacktrack[16]);
			int LA16_0 = input.LA(1);

			if ((LA16_0==SUB||LA16_0==OPEN_BRACE))
			{
				alt16=1;
			}
			else if ((LA16_0==ID||(LA16_0>=NUMBER && LA16_0<=CHAR)))
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
				// MathLang.g:112:8: ( SUB )? OPEN_BRACE term CLOSE_BRACE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(112, 8);
				// MathLang.g:112:8: ( SUB )?
				int alt15=2;
				try { DebugEnterSubRule(15);
				try { DebugEnterDecision(15, decisionCanBacktrack[15]);
				int LA15_0 = input.LA(1);

				if ((LA15_0==SUB))
				{
					alt15=1;
				}
				} finally { DebugExitDecision(15); }
				switch (alt15)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:112:9: SUB
					{
					DebugLocation(112, 12);
					SUB72=(IToken)Match(input,SUB,Follow._SUB_in_group905); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					SUB72_tree = (object)adaptor.Create(SUB72);
					root_0 = (object)adaptor.BecomeRoot(SUB72_tree, root_0);
					}

					}
					break;

				}
				} finally { DebugExitSubRule(15); }

				DebugLocation(112, 26);
				OPEN_BRACE73=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_group910); if (state.failed) return retval;
				DebugLocation(112, 28);
				PushFollow(Follow._term_in_group913);
				term74=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term74.Tree);
				DebugLocation(112, 44);
				CLOSE_BRACE75=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_group915); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:112:48: number
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(112, 48);
				PushFollow(Follow._number_in_group920);
				number76=number();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, number76.Tree);

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
			TraceOut("group", 24);
			LeaveRule("group", 24);
			Leave_group();
			if (state.backtracking > 0) { Memoize(input, 24, group_StartIndex); }
		}
		DebugLocation(112, 53);
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
	// MathLang.g:114:1: assignment : assignmentbody ';' ;
	[GrammarRule("assignment")]
	private MathLangParser.assignment_return assignment()
	{
		Enter_assignment();
		EnterRule("assignment", 25);
		TraceIn("assignment", 25);
		MathLangParser.assignment_return retval = new MathLangParser.assignment_return();
		retval.Start = (IToken)input.LT(1);
		int assignment_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal78=null;
		MathLangParser.assignmentbody_return assignmentbody77 = default(MathLangParser.assignmentbody_return);

		object char_literal78_tree=null;

		try { DebugEnterRule(GrammarFileName, "assignment");
		DebugLocation(114, 31);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 25)) { return retval; }
			// MathLang.g:114:11: ( assignmentbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:114:13: assignmentbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(114, 13);
			PushFollow(Follow._assignmentbody_in_assignment927);
			assignmentbody77=assignmentbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentbody77.Tree);
			DebugLocation(114, 31);
			char_literal78=(IToken)Match(input,66,Follow._66_in_assignment929); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("assignment", 25);
			LeaveRule("assignment", 25);
			Leave_assignment();
			if (state.backtracking > 0) { Memoize(input, 25, assignment_StartIndex); }
		}
		DebugLocation(114, 31);
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
	// MathLang.g:115:1: assignmentbody : ( ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) ) | ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) ) );
	[GrammarRule("assignmentbody")]
	private MathLangParser.assignmentbody_return assignmentbody()
	{
		Enter_assignmentbody();
		EnterRule("assignmentbody", 26);
		TraceIn("assignmentbody", 26);
		MathLangParser.assignmentbody_return retval = new MathLangParser.assignmentbody_return();
		retval.Start = (IToken)input.LT(1);
		int assignmentbody_StartIndex = input.Index;
		object root_0 = null;

		IToken ID79=null;
		IToken ASSIGN80=null;
		IToken ASSIGN83=null;
		MathLangParser.expression_return expression81 = default(MathLangParser.expression_return);
		MathLangParser.arrayelement_return arrayelement82 = default(MathLangParser.arrayelement_return);
		MathLangParser.expression_return expression84 = default(MathLangParser.expression_return);

		object ID79_tree=null;
		object ASSIGN80_tree=null;
		object ASSIGN83_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_arrayelement=new RewriteRuleSubtreeStream(adaptor,"rule arrayelement");
		try { DebugEnterRule(GrammarFileName, "assignmentbody");
		DebugLocation(115, 87);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 26)) { return retval; }
			// MathLang.g:115:15: ( ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) ) | ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) ) )
			int alt17=2;
			try { DebugEnterDecision(17, decisionCanBacktrack[17]);
			int LA17_0 = input.LA(1);

			if ((LA17_0==ID))
			{
				int LA17_1 = input.LA(2);

				if ((LA17_1==ASSIGN))
				{
					alt17=1;
				}
				else if ((LA17_1==OPEN_SQUARE_BRACE))
				{
					alt17=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 17, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
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
				// MathLang.g:115:17: ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) )
				{
				DebugLocation(115, 17);
				// MathLang.g:115:17: ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) )
				DebugEnterAlt(1);
				// MathLang.g:115:18: ID ASSIGN expression
				{
				DebugLocation(115, 18);
				ID79=(IToken)Match(input,ID,Follow._ID_in_assignmentbody937); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID79);

				DebugLocation(115, 21);
				ASSIGN80=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignmentbody939); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN80);

				DebugLocation(115, 28);
				PushFollow(Follow._expression_in_assignmentbody941);
				expression81=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression81.Tree);


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
				// 115:39: -> ^( VARASSIGNMENT ID expression )
				{
					DebugLocation(115, 42);
					// MathLang.g:115:42: ^( VARASSIGNMENT ID expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(115, 44);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARASSIGNMENT, "VARASSIGNMENT"), root_1);

					DebugLocation(115, 58);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(115, 61);
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
				// MathLang.g:116:2: ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) )
				{
				DebugLocation(116, 2);
				// MathLang.g:116:2: ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) )
				DebugEnterAlt(1);
				// MathLang.g:116:4: arrayelement ASSIGN expression
				{
				DebugLocation(116, 4);
				PushFollow(Follow._arrayelement_in_assignmentbody960);
				arrayelement82=arrayelement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_arrayelement.Add(arrayelement82.Tree);
				DebugLocation(116, 17);
				ASSIGN83=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignmentbody962); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN83);

				DebugLocation(116, 24);
				PushFollow(Follow._expression_in_assignmentbody964);
				expression84=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression84.Tree);


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
				// 116:35: -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression )
				{
					DebugLocation(116, 38);
					// MathLang.g:116:38: ^( ARRAYELEMENTASSIGNMENT arrayelement expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(116, 40);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYELEMENTASSIGNMENT, "ARRAYELEMENTASSIGNMENT"), root_1);

					DebugLocation(116, 63);
					adaptor.AddChild(root_1, stream_arrayelement.NextTree());
					DebugLocation(116, 76);
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
			TraceOut("assignmentbody", 26);
			LeaveRule("assignmentbody", 26);
			Leave_assignmentbody();
			if (state.backtracking > 0) { Memoize(input, 26, assignmentbody_StartIndex); }
		}
		DebugLocation(116, 87);
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
	// MathLang.g:118:1: boolexpression : boolterm ;
	[GrammarRule("boolexpression")]
	private MathLangParser.boolexpression_return boolexpression()
	{
		Enter_boolexpression();
		EnterRule("boolexpression", 27);
		TraceIn("boolexpression", 27);
		MathLangParser.boolexpression_return retval = new MathLangParser.boolexpression_return();
		retval.Start = (IToken)input.LT(1);
		int boolexpression_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.boolterm_return boolterm85 = default(MathLangParser.boolterm_return);


		try { DebugEnterRule(GrammarFileName, "boolexpression");
		DebugLocation(118, 25);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 27)) { return retval; }
			// MathLang.g:118:15: ( boolterm )
			DebugEnterAlt(1);
			// MathLang.g:118:17: boolterm
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(118, 17);
			PushFollow(Follow._boolterm_in_boolexpression982);
			boolterm85=boolterm();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm85.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("boolexpression", 27);
			LeaveRule("boolexpression", 27);
			Leave_boolexpression();
			if (state.backtracking > 0) { Memoize(input, 27, boolexpression_StartIndex); }
		}
		DebugLocation(118, 25);
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
	// MathLang.g:119:1: boolterm : or ( ( EQ | NEQ ) or )? ;
	[GrammarRule("boolterm")]
	private MathLangParser.boolterm_return boolterm()
	{
		Enter_boolterm();
		EnterRule("boolterm", 28);
		TraceIn("boolterm", 28);
		MathLangParser.boolterm_return retval = new MathLangParser.boolterm_return();
		retval.Start = (IToken)input.LT(1);
		int boolterm_StartIndex = input.Index;
		object root_0 = null;

		IToken set87=null;
		MathLangParser.or_return or86 = default(MathLangParser.or_return);
		MathLangParser.or_return or88 = default(MathLangParser.or_return);

		object set87_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolterm");
		DebugLocation(119, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 28)) { return retval; }
			// MathLang.g:119:9: ( or ( ( EQ | NEQ ) or )? )
			DebugEnterAlt(1);
			// MathLang.g:119:11: or ( ( EQ | NEQ ) or )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(119, 11);
			PushFollow(Follow._or_in_boolterm989);
			or86=or();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or86.Tree);
			DebugLocation(119, 14);
			// MathLang.g:119:14: ( ( EQ | NEQ ) or )?
			int alt18=2;
			try { DebugEnterSubRule(18);
			try { DebugEnterDecision(18, decisionCanBacktrack[18]);
			int LA18_0 = input.LA(1);

			if (((LA18_0>=NEQ && LA18_0<=EQ)))
			{
				alt18=1;
			}
			} finally { DebugExitDecision(18); }
			switch (alt18)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:119:16: ( EQ | NEQ ) or
				{
				DebugLocation(119, 16);
				set87=(IToken)input.LT(1);
				set87=(IToken)input.LT(1);
				if ((input.LA(1)>=NEQ && input.LA(1)<=EQ))
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

				DebugLocation(119, 28);
				PushFollow(Follow._or_in_boolterm1002);
				or88=or();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or88.Tree);

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
			TraceOut("boolterm", 28);
			LeaveRule("boolterm", 28);
			Leave_boolterm();
			if (state.backtracking > 0) { Memoize(input, 28, boolterm_StartIndex); }
		}
		DebugLocation(119, 32);
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
	// MathLang.g:120:1: or : and ( OR and )* ;
	[GrammarRule("or")]
	private MathLangParser.or_return or()
	{
		Enter_or();
		EnterRule("or", 29);
		TraceIn("or", 29);
		MathLangParser.or_return retval = new MathLangParser.or_return();
		retval.Start = (IToken)input.LT(1);
		int or_StartIndex = input.Index;
		object root_0 = null;

		IToken OR90=null;
		MathLangParser.and_return and89 = default(MathLangParser.and_return);
		MathLangParser.and_return and91 = default(MathLangParser.and_return);

		object OR90_tree=null;

		try { DebugEnterRule(GrammarFileName, "or");
		DebugLocation(120, 18);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 29)) { return retval; }
			// MathLang.g:120:3: ( and ( OR and )* )
			DebugEnterAlt(1);
			// MathLang.g:120:5: and ( OR and )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(120, 5);
			PushFollow(Follow._and_in_or1011);
			and89=and();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and89.Tree);
			DebugLocation(120, 9);
			// MathLang.g:120:9: ( OR and )*
			try { DebugEnterSubRule(19);
			while (true)
			{
				int alt19=2;
				try { DebugEnterDecision(19, decisionCanBacktrack[19]);
				int LA19_0 = input.LA(1);

				if ((LA19_0==OR))
				{
					alt19=1;
				}


				} finally { DebugExitDecision(19); }
				switch ( alt19 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:120:10: OR and
					{
					DebugLocation(120, 12);
					OR90=(IToken)Match(input,OR,Follow._OR_in_or1014); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR90_tree = (object)adaptor.Create(OR90);
					root_0 = (object)adaptor.BecomeRoot(OR90_tree, root_0);
					}
					DebugLocation(120, 14);
					PushFollow(Follow._and_in_or1017);
					and91=and();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and91.Tree);

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
			TraceOut("or", 29);
			LeaveRule("or", 29);
			Leave_or();
			if (state.backtracking > 0) { Memoize(input, 29, or_StartIndex); }
		}
		DebugLocation(120, 18);
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
	// MathLang.g:121:1: and : boolgroup ( AND boolgroup )* ;
	[GrammarRule("and")]
	private MathLangParser.and_return and()
	{
		Enter_and();
		EnterRule("and", 30);
		TraceIn("and", 30);
		MathLangParser.and_return retval = new MathLangParser.and_return();
		retval.Start = (IToken)input.LT(1);
		int and_StartIndex = input.Index;
		object root_0 = null;

		IToken AND93=null;
		MathLangParser.boolgroup_return boolgroup92 = default(MathLangParser.boolgroup_return);
		MathLangParser.boolgroup_return boolgroup94 = default(MathLangParser.boolgroup_return);

		object AND93_tree=null;

		try { DebugEnterRule(GrammarFileName, "and");
		DebugLocation(121, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 30)) { return retval; }
			// MathLang.g:121:4: ( boolgroup ( AND boolgroup )* )
			DebugEnterAlt(1);
			// MathLang.g:121:6: boolgroup ( AND boolgroup )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(121, 6);
			PushFollow(Follow._boolgroup_in_and1025);
			boolgroup92=boolgroup();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup92.Tree);
			DebugLocation(121, 16);
			// MathLang.g:121:16: ( AND boolgroup )*
			try { DebugEnterSubRule(20);
			while (true)
			{
				int alt20=2;
				try { DebugEnterDecision(20, decisionCanBacktrack[20]);
				int LA20_0 = input.LA(1);

				if ((LA20_0==AND))
				{
					alt20=1;
				}


				} finally { DebugExitDecision(20); }
				switch ( alt20 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:121:17: AND boolgroup
					{
					DebugLocation(121, 20);
					AND93=(IToken)Match(input,AND,Follow._AND_in_and1028); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND93_tree = (object)adaptor.Create(AND93);
					root_0 = (object)adaptor.BecomeRoot(AND93_tree, root_0);
					}
					DebugLocation(121, 22);
					PushFollow(Follow._boolgroup_in_and1031);
					boolgroup94=boolgroup();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup94.Tree);

					}
					break;

				default:
					goto loop20;
				}
			}

			loop20:
				;

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
			TraceOut("and", 30);
			LeaveRule("and", 30);
			Leave_and();
			if (state.backtracking > 0) { Memoize(input, 30, and_StartIndex); }
		}
		DebugLocation(121, 32);
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
	// MathLang.g:122:1: boolgroup : ( NOT )? ( OPEN_BRACE boolterm CLOSE_BRACE | boolvar ) ;
	[GrammarRule("boolgroup")]
	private MathLangParser.boolgroup_return boolgroup()
	{
		Enter_boolgroup();
		EnterRule("boolgroup", 31);
		TraceIn("boolgroup", 31);
		MathLangParser.boolgroup_return retval = new MathLangParser.boolgroup_return();
		retval.Start = (IToken)input.LT(1);
		int boolgroup_StartIndex = input.Index;
		object root_0 = null;

		IToken NOT95=null;
		IToken OPEN_BRACE96=null;
		IToken CLOSE_BRACE98=null;
		MathLangParser.boolterm_return boolterm97 = default(MathLangParser.boolterm_return);
		MathLangParser.boolvar_return boolvar99 = default(MathLangParser.boolvar_return);

		object NOT95_tree=null;
		object OPEN_BRACE96_tree=null;
		object CLOSE_BRACE98_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolgroup");
		DebugLocation(122, 66);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 31)) { return retval; }
			// MathLang.g:122:10: ( ( NOT )? ( OPEN_BRACE boolterm CLOSE_BRACE | boolvar ) )
			DebugEnterAlt(1);
			// MathLang.g:122:12: ( NOT )? ( OPEN_BRACE boolterm CLOSE_BRACE | boolvar )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(122, 12);
			// MathLang.g:122:12: ( NOT )?
			int alt21=2;
			try { DebugEnterSubRule(21);
			try { DebugEnterDecision(21, decisionCanBacktrack[21]);
			int LA21_0 = input.LA(1);

			if ((LA21_0==NOT))
			{
				alt21=1;
			}
			} finally { DebugExitDecision(21); }
			switch (alt21)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:122:13: NOT
				{
				DebugLocation(122, 16);
				NOT95=(IToken)Match(input,NOT,Follow._NOT_in_boolgroup1040); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				NOT95_tree = (object)adaptor.Create(NOT95);
				root_0 = (object)adaptor.BecomeRoot(NOT95_tree, root_0);
				}

				}
				break;

			}
			} finally { DebugExitSubRule(21); }

			DebugLocation(122, 20);
			// MathLang.g:122:20: ( OPEN_BRACE boolterm CLOSE_BRACE | boolvar )
			int alt22=2;
			try { DebugEnterSubRule(22);
			try { DebugEnterDecision(22, decisionCanBacktrack[22]);
			int LA22_0 = input.LA(1);

			if ((LA22_0==OPEN_BRACE))
			{
				int LA22_1 = input.LA(2);

				if ((EvaluatePredicate(synpred43_MathLang_fragment)))
				{
					alt22=1;
				}
				else if ((true))
				{
					alt22=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 22, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else if ((LA22_0==ID||(LA22_0>=NUMBER && LA22_0<=CHAR)||LA22_0==SUB||(LA22_0>=TRUE && LA22_0<=FALSE)))
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
				// MathLang.g:122:22: OPEN_BRACE boolterm CLOSE_BRACE
				{
				DebugLocation(122, 32);
				OPEN_BRACE96=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_boolgroup1047); if (state.failed) return retval;
				DebugLocation(122, 34);
				PushFollow(Follow._boolterm_in_boolgroup1050);
				boolterm97=boolterm();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm97.Tree);
				DebugLocation(122, 54);
				CLOSE_BRACE98=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_boolgroup1052); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:122:58: boolvar
				{
				DebugLocation(122, 58);
				PushFollow(Follow._boolvar_in_boolgroup1057);
				boolvar99=boolvar();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolvar99.Tree);

				}
				break;

			}
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
			TraceOut("boolgroup", 31);
			LeaveRule("boolgroup", 31);
			Leave_boolgroup();
			if (state.backtracking > 0) { Memoize(input, 31, boolgroup_StartIndex); }
		}
		DebugLocation(122, 66);
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
	// MathLang.g:123:1: boolvar : ( TRUE | FALSE | compare );
	[GrammarRule("boolvar")]
	private MathLangParser.boolvar_return boolvar()
	{
		Enter_boolvar();
		EnterRule("boolvar", 32);
		TraceIn("boolvar", 32);
		MathLangParser.boolvar_return retval = new MathLangParser.boolvar_return();
		retval.Start = (IToken)input.LT(1);
		int boolvar_StartIndex = input.Index;
		object root_0 = null;

		IToken TRUE100=null;
		IToken FALSE101=null;
		MathLangParser.compare_return compare102 = default(MathLangParser.compare_return);

		object TRUE100_tree=null;
		object FALSE101_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolvar");
		DebugLocation(123, 11);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 32)) { return retval; }
			// MathLang.g:123:8: ( TRUE | FALSE | compare )
			int alt23=3;
			try { DebugEnterDecision(23, decisionCanBacktrack[23]);
			switch (input.LA(1))
			{
			case TRUE:
				{
				alt23=1;
				}
				break;
			case FALSE:
				{
				alt23=2;
				}
				break;
			case ID:
			case NUMBER:
			case CHAR:
			case SUB:
			case OPEN_BRACE:
				{
				alt23=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 23, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(23); }
			switch (alt23)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:123:10: TRUE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(123, 10);
				TRUE100=(IToken)Match(input,TRUE,Follow._TRUE_in_boolvar1065); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				TRUE100_tree = (object)adaptor.Create(TRUE100);
				adaptor.AddChild(root_0, TRUE100_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:124:5: FALSE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(124, 5);
				FALSE101=(IToken)Match(input,FALSE,Follow._FALSE_in_boolvar1071); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				FALSE101_tree = (object)adaptor.Create(FALSE101);
				adaptor.AddChild(root_0, FALSE101_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:125:5: compare
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(125, 5);
				PushFollow(Follow._compare_in_boolvar1077);
				compare102=compare();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare102.Tree);

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
			TraceOut("boolvar", 32);
			LeaveRule("boolvar", 32);
			Leave_boolvar();
			if (state.backtracking > 0) { Memoize(input, 32, boolvar_StartIndex); }
		}
		DebugLocation(125, 11);
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
	// MathLang.g:127:1: ifstatement : IF OPEN_BRACE boolexpression CLOSE_BRACE ( block | statement ) ( ELSE ( block | statement ) )* ;
	[GrammarRule("ifstatement")]
	private MathLangParser.ifstatement_return ifstatement()
	{
		Enter_ifstatement();
		EnterRule("ifstatement", 33);
		TraceIn("ifstatement", 33);
		MathLangParser.ifstatement_return retval = new MathLangParser.ifstatement_return();
		retval.Start = (IToken)input.LT(1);
		int ifstatement_StartIndex = input.Index;
		object root_0 = null;

		IToken IF103=null;
		IToken OPEN_BRACE104=null;
		IToken CLOSE_BRACE106=null;
		IToken ELSE109=null;
		MathLangParser.boolexpression_return boolexpression105 = default(MathLangParser.boolexpression_return);
		MathLangParser.block_return block107 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement108 = default(MathLangParser.statement_return);
		MathLangParser.block_return block110 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement111 = default(MathLangParser.statement_return);

		object IF103_tree=null;
		object OPEN_BRACE104_tree=null;
		object CLOSE_BRACE106_tree=null;
		object ELSE109_tree=null;

		try { DebugEnterRule(GrammarFileName, "ifstatement");
		DebugLocation(127, 106);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 33)) { return retval; }
			// MathLang.g:127:12: ( IF OPEN_BRACE boolexpression CLOSE_BRACE ( block | statement ) ( ELSE ( block | statement ) )* )
			DebugEnterAlt(1);
			// MathLang.g:127:14: IF OPEN_BRACE boolexpression CLOSE_BRACE ( block | statement ) ( ELSE ( block | statement ) )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(127, 16);
			IF103=(IToken)Match(input,IF,Follow._IF_in_ifstatement1086); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			IF103_tree = (object)adaptor.Create(IF103);
			root_0 = (object)adaptor.BecomeRoot(IF103_tree, root_0);
			}
			DebugLocation(127, 28);
			OPEN_BRACE104=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_ifstatement1089); if (state.failed) return retval;
			DebugLocation(127, 30);
			PushFollow(Follow._boolexpression_in_ifstatement1092);
			boolexpression105=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression105.Tree);
			DebugLocation(127, 56);
			CLOSE_BRACE106=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_ifstatement1094); if (state.failed) return retval;
			DebugLocation(127, 58);
			// MathLang.g:127:58: ( block | statement )
			int alt24=2;
			try { DebugEnterSubRule(24);
			try { DebugEnterDecision(24, decisionCanBacktrack[24]);
			int LA24_0 = input.LA(1);

			if ((LA24_0==64))
			{
				alt24=1;
			}
			else if ((LA24_0==IF||LA24_0==FOR||(LA24_0>=RETURN && LA24_0<=DO)||(LA24_0>=ID && LA24_0<=TYPE)||LA24_0==KNEW))
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
				// MathLang.g:127:59: block
				{
				DebugLocation(127, 59);
				PushFollow(Follow._block_in_ifstatement1098);
				block107=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block107.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:127:67: statement
				{
				DebugLocation(127, 67);
				PushFollow(Follow._statement_in_ifstatement1102);
				statement108=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement108.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(24); }

			DebugLocation(127, 78);
			// MathLang.g:127:78: ( ELSE ( block | statement ) )*
			try { DebugEnterSubRule(26);
			while (true)
			{
				int alt26=2;
				try { DebugEnterDecision(26, decisionCanBacktrack[26]);
				int LA26_0 = input.LA(1);

				if ((LA26_0==ELSE))
				{
					int LA26_1 = input.LA(2);

					if ((EvaluatePredicate(synpred48_MathLang_fragment)))
					{
						alt26=1;
					}


				}


				} finally { DebugExitDecision(26); }
				switch ( alt26 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:127:79: ELSE ( block | statement )
					{
					DebugLocation(127, 83);
					ELSE109=(IToken)Match(input,ELSE,Follow._ELSE_in_ifstatement1106); if (state.failed) return retval;
					DebugLocation(127, 85);
					// MathLang.g:127:85: ( block | statement )
					int alt25=2;
					try { DebugEnterSubRule(25);
					try { DebugEnterDecision(25, decisionCanBacktrack[25]);
					int LA25_0 = input.LA(1);

					if ((LA25_0==64))
					{
						alt25=1;
					}
					else if ((LA25_0==IF||LA25_0==FOR||(LA25_0>=RETURN && LA25_0<=DO)||(LA25_0>=ID && LA25_0<=TYPE)||LA25_0==KNEW))
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
						// MathLang.g:127:86: block
						{
						DebugLocation(127, 86);
						PushFollow(Follow._block_in_ifstatement1110);
						block110=block();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block110.Tree);

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// MathLang.g:127:94: statement
						{
						DebugLocation(127, 94);
						PushFollow(Follow._statement_in_ifstatement1114);
						statement111=statement();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement111.Tree);

						}
						break;

					}
					} finally { DebugExitSubRule(25); }


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

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("ifstatement", 33);
			LeaveRule("ifstatement", 33);
			Leave_ifstatement();
			if (state.backtracking > 0) { Memoize(input, 33, ifstatement_StartIndex); }
		}
		DebugLocation(127, 106);
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
	// MathLang.g:128:1: whilestatement : WHILE OPEN_BRACE boolexpression CLOSE_BRACE ( block | statement ) ;
	[GrammarRule("whilestatement")]
	private MathLangParser.whilestatement_return whilestatement()
	{
		Enter_whilestatement();
		EnterRule("whilestatement", 34);
		TraceIn("whilestatement", 34);
		MathLangParser.whilestatement_return retval = new MathLangParser.whilestatement_return();
		retval.Start = (IToken)input.LT(1);
		int whilestatement_StartIndex = input.Index;
		object root_0 = null;

		IToken WHILE112=null;
		IToken OPEN_BRACE113=null;
		IToken CLOSE_BRACE115=null;
		MathLangParser.boolexpression_return boolexpression114 = default(MathLangParser.boolexpression_return);
		MathLangParser.block_return block116 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement117 = default(MathLangParser.statement_return);

		object WHILE112_tree=null;
		object OPEN_BRACE113_tree=null;
		object CLOSE_BRACE115_tree=null;

		try { DebugEnterRule(GrammarFileName, "whilestatement");
		DebugLocation(128, 82);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 34)) { return retval; }
			// MathLang.g:128:15: ( WHILE OPEN_BRACE boolexpression CLOSE_BRACE ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:128:17: WHILE OPEN_BRACE boolexpression CLOSE_BRACE ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(128, 22);
			WHILE112=(IToken)Match(input,WHILE,Follow._WHILE_in_whilestatement1124); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			WHILE112_tree = (object)adaptor.Create(WHILE112);
			root_0 = (object)adaptor.BecomeRoot(WHILE112_tree, root_0);
			}
			DebugLocation(128, 34);
			OPEN_BRACE113=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_whilestatement1127); if (state.failed) return retval;
			DebugLocation(128, 36);
			PushFollow(Follow._boolexpression_in_whilestatement1130);
			boolexpression114=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression114.Tree);
			DebugLocation(128, 62);
			CLOSE_BRACE115=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_whilestatement1132); if (state.failed) return retval;
			DebugLocation(128, 64);
			// MathLang.g:128:64: ( block | statement )
			int alt27=2;
			try { DebugEnterSubRule(27);
			try { DebugEnterDecision(27, decisionCanBacktrack[27]);
			int LA27_0 = input.LA(1);

			if ((LA27_0==64))
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
				// MathLang.g:128:65: block
				{
				DebugLocation(128, 65);
				PushFollow(Follow._block_in_whilestatement1136);
				block116=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block116.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:128:73: statement
				{
				DebugLocation(128, 73);
				PushFollow(Follow._statement_in_whilestatement1140);
				statement117=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement117.Tree);

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
			TraceOut("whilestatement", 34);
			LeaveRule("whilestatement", 34);
			Leave_whilestatement();
			if (state.backtracking > 0) { Memoize(input, 34, whilestatement_StartIndex); }
		}
		DebugLocation(128, 82);
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
	// MathLang.g:129:1: forstatement : FOR OPEN_BRACE longdeclarationbody ';' boolexpression ';' assignmentbody CLOSE_BRACE ( block | statement ) ;
	[GrammarRule("forstatement")]
	private MathLangParser.forstatement_return forstatement()
	{
		Enter_forstatement();
		EnterRule("forstatement", 35);
		TraceIn("forstatement", 35);
		MathLangParser.forstatement_return retval = new MathLangParser.forstatement_return();
		retval.Start = (IToken)input.LT(1);
		int forstatement_StartIndex = input.Index;
		object root_0 = null;

		IToken FOR118=null;
		IToken OPEN_BRACE119=null;
		IToken char_literal121=null;
		IToken char_literal123=null;
		IToken CLOSE_BRACE125=null;
		MathLangParser.longdeclarationbody_return longdeclarationbody120 = default(MathLangParser.longdeclarationbody_return);
		MathLangParser.boolexpression_return boolexpression122 = default(MathLangParser.boolexpression_return);
		MathLangParser.assignmentbody_return assignmentbody124 = default(MathLangParser.assignmentbody_return);
		MathLangParser.block_return block126 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement127 = default(MathLangParser.statement_return);

		object FOR118_tree=null;
		object OPEN_BRACE119_tree=null;
		object char_literal121_tree=null;
		object char_literal123_tree=null;
		object CLOSE_BRACE125_tree=null;

		try { DebugEnterRule(GrammarFileName, "forstatement");
		DebugLocation(129, 123);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 35)) { return retval; }
			// MathLang.g:129:13: ( FOR OPEN_BRACE longdeclarationbody ';' boolexpression ';' assignmentbody CLOSE_BRACE ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:129:15: FOR OPEN_BRACE longdeclarationbody ';' boolexpression ';' assignmentbody CLOSE_BRACE ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(129, 18);
			FOR118=(IToken)Match(input,FOR,Follow._FOR_in_forstatement1147); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			FOR118_tree = (object)adaptor.Create(FOR118);
			root_0 = (object)adaptor.BecomeRoot(FOR118_tree, root_0);
			}
			DebugLocation(129, 30);
			OPEN_BRACE119=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_forstatement1150); if (state.failed) return retval;
			DebugLocation(129, 32);
			PushFollow(Follow._longdeclarationbody_in_forstatement1153);
			longdeclarationbody120=longdeclarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclarationbody120.Tree);
			DebugLocation(129, 55);
			char_literal121=(IToken)Match(input,66,Follow._66_in_forstatement1155); if (state.failed) return retval;
			DebugLocation(129, 57);
			PushFollow(Follow._boolexpression_in_forstatement1158);
			boolexpression122=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression122.Tree);
			DebugLocation(129, 75);
			char_literal123=(IToken)Match(input,66,Follow._66_in_forstatement1160); if (state.failed) return retval;
			DebugLocation(129, 77);
			PushFollow(Follow._assignmentbody_in_forstatement1163);
			assignmentbody124=assignmentbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentbody124.Tree);
			DebugLocation(129, 103);
			CLOSE_BRACE125=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_forstatement1165); if (state.failed) return retval;
			DebugLocation(129, 105);
			// MathLang.g:129:105: ( block | statement )
			int alt28=2;
			try { DebugEnterSubRule(28);
			try { DebugEnterDecision(28, decisionCanBacktrack[28]);
			int LA28_0 = input.LA(1);

			if ((LA28_0==64))
			{
				alt28=1;
			}
			else if ((LA28_0==IF||LA28_0==FOR||(LA28_0>=RETURN && LA28_0<=DO)||(LA28_0>=ID && LA28_0<=TYPE)||LA28_0==KNEW))
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
				// MathLang.g:129:106: block
				{
				DebugLocation(129, 106);
				PushFollow(Follow._block_in_forstatement1169);
				block126=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block126.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:129:114: statement
				{
				DebugLocation(129, 114);
				PushFollow(Follow._statement_in_forstatement1173);
				statement127=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement127.Tree);

				}
				break;

			}
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
			TraceOut("forstatement", 35);
			LeaveRule("forstatement", 35);
			Leave_forstatement();
			if (state.backtracking > 0) { Memoize(input, 35, forstatement_StartIndex); }
		}
		DebugLocation(129, 123);
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
	// MathLang.g:130:1: returnstatement : RETURN expression ';' ;
	[GrammarRule("returnstatement")]
	private MathLangParser.returnstatement_return returnstatement()
	{
		Enter_returnstatement();
		EnterRule("returnstatement", 36);
		TraceIn("returnstatement", 36);
		MathLangParser.returnstatement_return retval = new MathLangParser.returnstatement_return();
		retval.Start = (IToken)input.LT(1);
		int returnstatement_StartIndex = input.Index;
		object root_0 = null;

		IToken RETURN128=null;
		IToken char_literal130=null;
		MathLangParser.expression_return expression129 = default(MathLangParser.expression_return);

		object RETURN128_tree=null;
		object char_literal130_tree=null;

		try { DebugEnterRule(GrammarFileName, "returnstatement");
		DebugLocation(130, 41);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 36)) { return retval; }
			// MathLang.g:130:16: ( RETURN expression ';' )
			DebugEnterAlt(1);
			// MathLang.g:130:18: RETURN expression ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(130, 24);
			RETURN128=(IToken)Match(input,RETURN,Follow._RETURN_in_returnstatement1180); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			RETURN128_tree = (object)adaptor.Create(RETURN128);
			root_0 = (object)adaptor.BecomeRoot(RETURN128_tree, root_0);
			}
			DebugLocation(130, 26);
			PushFollow(Follow._expression_in_returnstatement1183);
			expression129=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression129.Tree);
			DebugLocation(130, 40);
			char_literal130=(IToken)Match(input,66,Follow._66_in_returnstatement1185); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("returnstatement", 36);
			LeaveRule("returnstatement", 36);
			Leave_returnstatement();
			if (state.backtracking > 0) { Memoize(input, 36, returnstatement_StartIndex); }
		}
		DebugLocation(130, 41);
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
	// MathLang.g:131:1: dowhilestatement : DO ( block | statement ) WHILE OPEN_BRACE boolexpression CLOSE_BRACE ';' ;
	[GrammarRule("dowhilestatement")]
	private MathLangParser.dowhilestatement_return dowhilestatement()
	{
		Enter_dowhilestatement();
		EnterRule("dowhilestatement", 37);
		TraceIn("dowhilestatement", 37);
		MathLangParser.dowhilestatement_return retval = new MathLangParser.dowhilestatement_return();
		retval.Start = (IToken)input.LT(1);
		int dowhilestatement_StartIndex = input.Index;
		object root_0 = null;

		IToken DO131=null;
		IToken WHILE134=null;
		IToken OPEN_BRACE135=null;
		IToken CLOSE_BRACE137=null;
		IToken char_literal138=null;
		MathLangParser.block_return block132 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement133 = default(MathLangParser.statement_return);
		MathLangParser.boolexpression_return boolexpression136 = default(MathLangParser.boolexpression_return);

		object DO131_tree=null;
		object WHILE134_tree=null;
		object OPEN_BRACE135_tree=null;
		object CLOSE_BRACE137_tree=null;
		object char_literal138_tree=null;

		try { DebugEnterRule(GrammarFileName, "dowhilestatement");
		DebugLocation(131, 94);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 37)) { return retval; }
			// MathLang.g:131:17: ( DO ( block | statement ) WHILE OPEN_BRACE boolexpression CLOSE_BRACE ';' )
			DebugEnterAlt(1);
			// MathLang.g:131:19: DO ( block | statement ) WHILE OPEN_BRACE boolexpression CLOSE_BRACE ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(131, 21);
			DO131=(IToken)Match(input,DO,Follow._DO_in_dowhilestatement1193); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			DO131_tree = (object)adaptor.Create(DO131);
			root_0 = (object)adaptor.BecomeRoot(DO131_tree, root_0);
			}
			DebugLocation(131, 23);
			// MathLang.g:131:23: ( block | statement )
			int alt29=2;
			try { DebugEnterSubRule(29);
			try { DebugEnterDecision(29, decisionCanBacktrack[29]);
			int LA29_0 = input.LA(1);

			if ((LA29_0==64))
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
				// MathLang.g:131:24: block
				{
				DebugLocation(131, 24);
				PushFollow(Follow._block_in_dowhilestatement1197);
				block132=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block132.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:131:32: statement
				{
				DebugLocation(131, 32);
				PushFollow(Follow._statement_in_dowhilestatement1201);
				statement133=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement133.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(29); }

			DebugLocation(131, 48);
			WHILE134=(IToken)Match(input,WHILE,Follow._WHILE_in_dowhilestatement1204); if (state.failed) return retval;
			DebugLocation(131, 60);
			OPEN_BRACE135=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_dowhilestatement1207); if (state.failed) return retval;
			DebugLocation(131, 62);
			PushFollow(Follow._boolexpression_in_dowhilestatement1210);
			boolexpression136=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression136.Tree);
			DebugLocation(131, 88);
			CLOSE_BRACE137=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_dowhilestatement1212); if (state.failed) return retval;
			DebugLocation(131, 93);
			char_literal138=(IToken)Match(input,66,Follow._66_in_dowhilestatement1215); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("dowhilestatement", 37);
			LeaveRule("dowhilestatement", 37);
			Leave_dowhilestatement();
			if (state.backtracking > 0) { Memoize(input, 37, dowhilestatement_StartIndex); }
		}
		DebugLocation(131, 94);
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
	// MathLang.g:133:1: funcdeclaration : MODIFIER any_type ID ( OPEN_BRACE ( paramsdeclaration )? CLOSE_BRACE ) block -> ^( FUNCDECLARATION ID ^( RETURN_TYPE any_type ) ( paramsdeclaration )? block ) ;
	[GrammarRule("funcdeclaration")]
	private MathLangParser.funcdeclaration_return funcdeclaration()
	{
		Enter_funcdeclaration();
		EnterRule("funcdeclaration", 38);
		TraceIn("funcdeclaration", 38);
		MathLangParser.funcdeclaration_return retval = new MathLangParser.funcdeclaration_return();
		retval.Start = (IToken)input.LT(1);
		int funcdeclaration_StartIndex = input.Index;
		object root_0 = null;

		IToken MODIFIER139=null;
		IToken ID141=null;
		IToken OPEN_BRACE142=null;
		IToken CLOSE_BRACE144=null;
		MathLangParser.any_type_return any_type140 = default(MathLangParser.any_type_return);
		MathLangParser.paramsdeclaration_return paramsdeclaration143 = default(MathLangParser.paramsdeclaration_return);
		MathLangParser.block_return block145 = default(MathLangParser.block_return);

		object MODIFIER139_tree=null;
		object ID141_tree=null;
		object OPEN_BRACE142_tree=null;
		object CLOSE_BRACE144_tree=null;
		RewriteRuleITokenStream stream_MODIFIER=new RewriteRuleITokenStream(adaptor,"token MODIFIER");
		RewriteRuleITokenStream stream_OPEN_BRACE=new RewriteRuleITokenStream(adaptor,"token OPEN_BRACE");
		RewriteRuleITokenStream stream_CLOSE_BRACE=new RewriteRuleITokenStream(adaptor,"token CLOSE_BRACE");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleSubtreeStream stream_any_type=new RewriteRuleSubtreeStream(adaptor,"rule any_type");
		RewriteRuleSubtreeStream stream_paramsdeclaration=new RewriteRuleSubtreeStream(adaptor,"rule paramsdeclaration");
		RewriteRuleSubtreeStream stream_block=new RewriteRuleSubtreeStream(adaptor,"rule block");
		try { DebugEnterRule(GrammarFileName, "funcdeclaration");
		DebugLocation(133, 191);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 38)) { return retval; }
			// MathLang.g:133:16: ( MODIFIER any_type ID ( OPEN_BRACE ( paramsdeclaration )? CLOSE_BRACE ) block -> ^( FUNCDECLARATION ID ^( RETURN_TYPE any_type ) ( paramsdeclaration )? block ) )
			DebugEnterAlt(1);
			// MathLang.g:133:18: MODIFIER any_type ID ( OPEN_BRACE ( paramsdeclaration )? CLOSE_BRACE ) block
			{
			DebugLocation(133, 18);
			MODIFIER139=(IToken)Match(input,MODIFIER,Follow._MODIFIER_in_funcdeclaration1224); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_MODIFIER.Add(MODIFIER139);

			DebugLocation(133, 27);
			PushFollow(Follow._any_type_in_funcdeclaration1226);
			any_type140=any_type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_any_type.Add(any_type140.Tree);
			DebugLocation(133, 38);
			ID141=(IToken)Match(input,ID,Follow._ID_in_funcdeclaration1228); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID141);

			DebugLocation(133, 40);
			// MathLang.g:133:40: ( OPEN_BRACE ( paramsdeclaration )? CLOSE_BRACE )
			DebugEnterAlt(1);
			// MathLang.g:133:42: OPEN_BRACE ( paramsdeclaration )? CLOSE_BRACE
			{
			DebugLocation(133, 52);
			OPEN_BRACE142=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_funcdeclaration1233); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OPEN_BRACE.Add(OPEN_BRACE142);

			DebugLocation(133, 54);
			// MathLang.g:133:54: ( paramsdeclaration )?
			int alt30=2;
			try { DebugEnterSubRule(30);
			try { DebugEnterDecision(30, decisionCanBacktrack[30]);
			int LA30_0 = input.LA(1);

			if ((LA30_0==TYPE))
			{
				alt30=1;
			}
			} finally { DebugExitDecision(30); }
			switch (alt30)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: paramsdeclaration
				{
				DebugLocation(133, 54);
				PushFollow(Follow._paramsdeclaration_in_funcdeclaration1236);
				paramsdeclaration143=paramsdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_paramsdeclaration.Add(paramsdeclaration143.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(30); }

			DebugLocation(133, 84);
			CLOSE_BRACE144=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_funcdeclaration1239); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CLOSE_BRACE.Add(CLOSE_BRACE144);


			}

			DebugLocation(133, 88);
			PushFollow(Follow._block_in_funcdeclaration1244);
			block145=block();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_block.Add(block145.Tree);


			{
			// AST REWRITE
			// elements: block, paramsdeclaration, ID, any_type
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 133:94: -> ^( FUNCDECLARATION ID ^( RETURN_TYPE any_type ) ( paramsdeclaration )? block )
			{
				DebugLocation(133, 97);
				// MathLang.g:133:97: ^( FUNCDECLARATION ID ^( RETURN_TYPE any_type ) ( paramsdeclaration )? block )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(133, 99);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNCDECLARATION, "FUNCDECLARATION"), root_1);

				DebugLocation(133, 115);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(133, 118);
				// MathLang.g:133:118: ^( RETURN_TYPE any_type )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(133, 120);
				root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(RETURN_TYPE, "RETURN_TYPE"), root_2);

				DebugLocation(133, 132);
				adaptor.AddChild(root_2, stream_any_type.NextTree());

				adaptor.AddChild(root_1, root_2);
				}
				DebugLocation(133, 154);
				// MathLang.g:133:154: ( paramsdeclaration )?
				if ( stream_paramsdeclaration.HasNext )
				{
					DebugLocation(133, 154);
					adaptor.AddChild(root_1, stream_paramsdeclaration.NextTree());

				}
				stream_paramsdeclaration.Reset();
				DebugLocation(133, 186);
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
			TraceOut("funcdeclaration", 38);
			LeaveRule("funcdeclaration", 38);
			Leave_funcdeclaration();
			if (state.backtracking > 0) { Memoize(input, 38, funcdeclaration_StartIndex); }
		}
		DebugLocation(133, 191);
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
	// MathLang.g:134:1: paramsdeclaration : ( declarationbody ( ',' declarationbody )* ) -> ^( PARAMETERS ( declarationbody )* ) ;
	[GrammarRule("paramsdeclaration")]
	private MathLangParser.paramsdeclaration_return paramsdeclaration()
	{
		Enter_paramsdeclaration();
		EnterRule("paramsdeclaration", 39);
		TraceIn("paramsdeclaration", 39);
		MathLangParser.paramsdeclaration_return retval = new MathLangParser.paramsdeclaration_return();
		retval.Start = (IToken)input.LT(1);
		int paramsdeclaration_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal147=null;
		MathLangParser.declarationbody_return declarationbody146 = default(MathLangParser.declarationbody_return);
		MathLangParser.declarationbody_return declarationbody148 = default(MathLangParser.declarationbody_return);

		object char_literal147_tree=null;
		RewriteRuleITokenStream stream_67=new RewriteRuleITokenStream(adaptor,"token 67");
		RewriteRuleSubtreeStream stream_declarationbody=new RewriteRuleSubtreeStream(adaptor,"rule declarationbody");
		try { DebugEnterRule(GrammarFileName, "paramsdeclaration");
		DebugLocation(134, 102);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 39)) { return retval; }
			// MathLang.g:134:18: ( ( declarationbody ( ',' declarationbody )* ) -> ^( PARAMETERS ( declarationbody )* ) )
			DebugEnterAlt(1);
			// MathLang.g:134:20: ( declarationbody ( ',' declarationbody )* )
			{
			DebugLocation(134, 20);
			// MathLang.g:134:20: ( declarationbody ( ',' declarationbody )* )
			DebugEnterAlt(1);
			// MathLang.g:134:22: declarationbody ( ',' declarationbody )*
			{
			DebugLocation(134, 22);
			PushFollow(Follow._declarationbody_in_paramsdeclaration1277);
			declarationbody146=declarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declarationbody.Add(declarationbody146.Tree);
			DebugLocation(134, 38);
			// MathLang.g:134:38: ( ',' declarationbody )*
			try { DebugEnterSubRule(31);
			while (true)
			{
				int alt31=2;
				try { DebugEnterDecision(31, decisionCanBacktrack[31]);
				int LA31_0 = input.LA(1);

				if ((LA31_0==67))
				{
					alt31=1;
				}


				} finally { DebugExitDecision(31); }
				switch ( alt31 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:134:40: ',' declarationbody
					{
					DebugLocation(134, 43);
					char_literal147=(IToken)Match(input,67,Follow._67_in_paramsdeclaration1281); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_67.Add(char_literal147);

					DebugLocation(134, 45);
					PushFollow(Follow._declarationbody_in_paramsdeclaration1284);
					declarationbody148=declarationbody();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_declarationbody.Add(declarationbody148.Tree);

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
			// 134:66: -> ^( PARAMETERS ( declarationbody )* )
			{
				DebugLocation(134, 69);
				// MathLang.g:134:69: ^( PARAMETERS ( declarationbody )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(134, 71);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_1);

				DebugLocation(134, 82);
				// MathLang.g:134:82: ( declarationbody )*
				while ( stream_declarationbody.HasNext )
				{
					DebugLocation(134, 84);
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
			TraceOut("paramsdeclaration", 39);
			LeaveRule("paramsdeclaration", 39);
			Leave_paramsdeclaration();
			if (state.backtracking > 0) { Memoize(input, 39, paramsdeclaration_StartIndex); }
		}
		DebugLocation(134, 102);
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
	// MathLang.g:136:1: funccallbody : ID OPEN_BRACE ( expressioncommalist )? CLOSE_BRACE -> ^( FUNC_CALL ^( ID ( ^( PARAMETERS expressioncommalist ) )? ) ) ;
	[GrammarRule("funccallbody")]
	private MathLangParser.funccallbody_return funccallbody()
	{
		Enter_funccallbody();
		EnterRule("funccallbody", 40);
		TraceIn("funccallbody", 40);
		MathLangParser.funccallbody_return retval = new MathLangParser.funccallbody_return();
		retval.Start = (IToken)input.LT(1);
		int funccallbody_StartIndex = input.Index;
		object root_0 = null;

		IToken ID149=null;
		IToken OPEN_BRACE150=null;
		IToken CLOSE_BRACE152=null;
		MathLangParser.expressioncommalist_return expressioncommalist151 = default(MathLangParser.expressioncommalist_return);

		object ID149_tree=null;
		object OPEN_BRACE150_tree=null;
		object CLOSE_BRACE152_tree=null;
		RewriteRuleITokenStream stream_OPEN_BRACE=new RewriteRuleITokenStream(adaptor,"token OPEN_BRACE");
		RewriteRuleITokenStream stream_CLOSE_BRACE=new RewriteRuleITokenStream(adaptor,"token CLOSE_BRACE");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleSubtreeStream stream_expressioncommalist=new RewriteRuleSubtreeStream(adaptor,"rule expressioncommalist");
		try { DebugEnterRule(GrammarFileName, "funccallbody");
		DebugLocation(136, 118);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 40)) { return retval; }
			// MathLang.g:136:13: ( ID OPEN_BRACE ( expressioncommalist )? CLOSE_BRACE -> ^( FUNC_CALL ^( ID ( ^( PARAMETERS expressioncommalist ) )? ) ) )
			DebugEnterAlt(1);
			// MathLang.g:136:15: ID OPEN_BRACE ( expressioncommalist )? CLOSE_BRACE
			{
			DebugLocation(136, 17);
			ID149=(IToken)Match(input,ID,Follow._ID_in_funccallbody1309); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID149);

			DebugLocation(136, 19);
			OPEN_BRACE150=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_funccallbody1312); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OPEN_BRACE.Add(OPEN_BRACE150);

			DebugLocation(136, 30);
			// MathLang.g:136:30: ( expressioncommalist )?
			int alt32=2;
			try { DebugEnterSubRule(32);
			try { DebugEnterDecision(32, decisionCanBacktrack[32]);
			int LA32_0 = input.LA(1);

			if ((LA32_0==ID||(LA32_0>=NUMBER && LA32_0<=CHAR)||LA32_0==SUB||LA32_0==OPEN_BRACE||(LA32_0>=NOT && LA32_0<=KNEW)))
			{
				alt32=1;
			}
			} finally { DebugExitDecision(32); }
			switch (alt32)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: expressioncommalist
				{
				DebugLocation(136, 30);
				PushFollow(Follow._expressioncommalist_in_funccallbody1314);
				expressioncommalist151=expressioncommalist();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expressioncommalist.Add(expressioncommalist151.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(32); }

			DebugLocation(136, 51);
			CLOSE_BRACE152=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_funccallbody1317); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CLOSE_BRACE.Add(CLOSE_BRACE152);



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
			// 136:63: -> ^( FUNC_CALL ^( ID ( ^( PARAMETERS expressioncommalist ) )? ) )
			{
				DebugLocation(136, 66);
				// MathLang.g:136:66: ^( FUNC_CALL ^( ID ( ^( PARAMETERS expressioncommalist ) )? ) )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(136, 68);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_CALL, "FUNC_CALL"), root_1);

				DebugLocation(136, 78);
				// MathLang.g:136:78: ^( ID ( ^( PARAMETERS expressioncommalist ) )? )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(136, 80);
				root_2 = (object)adaptor.BecomeRoot(stream_ID.NextNode(), root_2);

				DebugLocation(136, 83);
				// MathLang.g:136:83: ( ^( PARAMETERS expressioncommalist ) )?
				if ( stream_expressioncommalist.HasNext )
				{
					DebugLocation(136, 83);
					// MathLang.g:136:83: ^( PARAMETERS expressioncommalist )
					{
					object root_3 = (object)adaptor.Nil();
					DebugLocation(136, 85);
					root_3 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_3);

					DebugLocation(136, 96);
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
			TraceOut("funccallbody", 40);
			LeaveRule("funccallbody", 40);
			Leave_funccallbody();
			if (state.backtracking > 0) { Memoize(input, 40, funccallbody_StartIndex); }
		}
		DebugLocation(136, 118);
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
	// MathLang.g:137:1: funccall : funccallbody ';' ;
	[GrammarRule("funccall")]
	private MathLangParser.funccall_return funccall()
	{
		Enter_funccall();
		EnterRule("funccall", 41);
		TraceIn("funccall", 41);
		MathLangParser.funccall_return retval = new MathLangParser.funccall_return();
		retval.Start = (IToken)input.LT(1);
		int funccall_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal154=null;
		MathLangParser.funccallbody_return funccallbody153 = default(MathLangParser.funccallbody_return);

		object char_literal154_tree=null;

		try { DebugEnterRule(GrammarFileName, "funccall");
		DebugLocation(137, 27);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 41)) { return retval; }
			// MathLang.g:137:9: ( funccallbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:137:11: funccallbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(137, 11);
			PushFollow(Follow._funccallbody_in_funccall1340);
			funccallbody153=funccallbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody153.Tree);
			DebugLocation(137, 27);
			char_literal154=(IToken)Match(input,66,Follow._66_in_funccall1342); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("funccall", 41);
			LeaveRule("funccall", 41);
			Leave_funccall();
			if (state.backtracking > 0) { Memoize(input, 41, funccall_StartIndex); }
		}
		DebugLocation(137, 27);
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
	// MathLang.g:138:1: expressioncommalist : expression ( ',' expression )* ;
	[GrammarRule("expressioncommalist")]
	private MathLangParser.expressioncommalist_return expressioncommalist()
	{
		Enter_expressioncommalist();
		EnterRule("expressioncommalist", 42);
		TraceIn("expressioncommalist", 42);
		MathLangParser.expressioncommalist_return retval = new MathLangParser.expressioncommalist_return();
		retval.Start = (IToken)input.LT(1);
		int expressioncommalist_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal156=null;
		MathLangParser.expression_return expression155 = default(MathLangParser.expression_return);
		MathLangParser.expression_return expression157 = default(MathLangParser.expression_return);

		object char_literal156_tree=null;

		try { DebugEnterRule(GrammarFileName, "expressioncommalist");
		DebugLocation(138, 51);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 42)) { return retval; }
			// MathLang.g:138:20: ( expression ( ',' expression )* )
			DebugEnterAlt(1);
			// MathLang.g:138:22: expression ( ',' expression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(138, 22);
			PushFollow(Follow._expression_in_expressioncommalist1349);
			expression155=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression155.Tree);
			DebugLocation(138, 33);
			// MathLang.g:138:33: ( ',' expression )*
			try { DebugEnterSubRule(33);
			while (true)
			{
				int alt33=2;
				try { DebugEnterDecision(33, decisionCanBacktrack[33]);
				int LA33_0 = input.LA(1);

				if ((LA33_0==67))
				{
					alt33=1;
				}


				} finally { DebugExitDecision(33); }
				switch ( alt33 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:138:35: ',' expression
					{
					DebugLocation(138, 38);
					char_literal156=(IToken)Match(input,67,Follow._67_in_expressioncommalist1353); if (state.failed) return retval;
					DebugLocation(138, 40);
					PushFollow(Follow._expression_in_expressioncommalist1356);
					expression157=expression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression157.Tree);

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

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expressioncommalist", 42);
			LeaveRule("expressioncommalist", 42);
			Leave_expressioncommalist();
			if (state.backtracking > 0) { Memoize(input, 42, expressioncommalist_StartIndex); }
		}
		DebugLocation(138, 51);
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
	// MathLang.g:141:1: object_initializer : '{' expressioncommalist '}' -> ^( PARAMETERS expressioncommalist ) ;
	[GrammarRule("object_initializer")]
	private MathLangParser.object_initializer_return object_initializer()
	{
		Enter_object_initializer();
		EnterRule("object_initializer", 43);
		TraceIn("object_initializer", 43);
		MathLangParser.object_initializer_return retval = new MathLangParser.object_initializer_return();
		retval.Start = (IToken)input.LT(1);
		int object_initializer_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal158=null;
		IToken char_literal160=null;
		MathLangParser.expressioncommalist_return expressioncommalist159 = default(MathLangParser.expressioncommalist_return);

		object char_literal158_tree=null;
		object char_literal160_tree=null;
		RewriteRuleITokenStream stream_64=new RewriteRuleITokenStream(adaptor,"token 64");
		RewriteRuleITokenStream stream_65=new RewriteRuleITokenStream(adaptor,"token 65");
		RewriteRuleSubtreeStream stream_expressioncommalist=new RewriteRuleSubtreeStream(adaptor,"rule expressioncommalist");
		try { DebugEnterRule(GrammarFileName, "object_initializer");
		DebugLocation(141, 86);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 43)) { return retval; }
			// MathLang.g:141:19: ( '{' expressioncommalist '}' -> ^( PARAMETERS expressioncommalist ) )
			DebugEnterAlt(1);
			// MathLang.g:141:22: '{' expressioncommalist '}'
			{
			DebugLocation(141, 22);
			char_literal158=(IToken)Match(input,64,Follow._64_in_object_initializer1368); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_64.Add(char_literal158);

			DebugLocation(141, 26);
			PushFollow(Follow._expressioncommalist_in_object_initializer1370);
			expressioncommalist159=expressioncommalist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expressioncommalist.Add(expressioncommalist159.Tree);
			DebugLocation(141, 46);
			char_literal160=(IToken)Match(input,65,Follow._65_in_object_initializer1372); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_65.Add(char_literal160);



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
			// 141:50: -> ^( PARAMETERS expressioncommalist )
			{
				DebugLocation(141, 53);
				// MathLang.g:141:53: ^( PARAMETERS expressioncommalist )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(141, 55);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_1);

				DebugLocation(141, 66);
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
			TraceOut("object_initializer", 43);
			LeaveRule("object_initializer", 43);
			Leave_object_initializer();
			if (state.backtracking > 0) { Memoize(input, 43, object_initializer_StartIndex); }
		}
		DebugLocation(141, 86);
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
	// MathLang.g:142:1: newexpression : KNEW initializer ;
	[GrammarRule("newexpression")]
	private MathLangParser.newexpression_return newexpression()
	{
		Enter_newexpression();
		EnterRule("newexpression", 44);
		TraceIn("newexpression", 44);
		MathLangParser.newexpression_return retval = new MathLangParser.newexpression_return();
		retval.Start = (IToken)input.LT(1);
		int newexpression_StartIndex = input.Index;
		object root_0 = null;

		IToken KNEW161=null;
		MathLangParser.initializer_return initializer162 = default(MathLangParser.initializer_return);

		object KNEW161_tree=null;

		try { DebugEnterRule(GrammarFileName, "newexpression");
		DebugLocation(142, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 44)) { return retval; }
			// MathLang.g:142:14: ( KNEW initializer )
			DebugEnterAlt(1);
			// MathLang.g:142:16: KNEW initializer
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(142, 20);
			KNEW161=(IToken)Match(input,KNEW,Follow._KNEW_in_newexpression1387); if (state.failed) return retval;
			DebugLocation(142, 22);
			PushFollow(Follow._initializer_in_newexpression1390);
			initializer162=initializer();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, initializer162.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("newexpression", 44);
			LeaveRule("newexpression", 44);
			Leave_newexpression();
			if (state.backtracking > 0) { Memoize(input, 44, newexpression_StartIndex); }
		}
		DebugLocation(142, 32);
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
	// MathLang.g:143:1: initializer : ( simple_var_initializer | array_initializer ) ;
	[GrammarRule("initializer")]
	private MathLangParser.initializer_return initializer()
	{
		Enter_initializer();
		EnterRule("initializer", 45);
		TraceIn("initializer", 45);
		MathLangParser.initializer_return retval = new MathLangParser.initializer_return();
		retval.Start = (IToken)input.LT(1);
		int initializer_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.simple_var_initializer_return simple_var_initializer163 = default(MathLangParser.simple_var_initializer_return);
		MathLangParser.array_initializer_return array_initializer164 = default(MathLangParser.array_initializer_return);


		try { DebugEnterRule(GrammarFileName, "initializer");
		DebugLocation(143, 57);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 45)) { return retval; }
			// MathLang.g:143:12: ( ( simple_var_initializer | array_initializer ) )
			DebugEnterAlt(1);
			// MathLang.g:143:14: ( simple_var_initializer | array_initializer )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(143, 14);
			// MathLang.g:143:14: ( simple_var_initializer | array_initializer )
			int alt34=2;
			try { DebugEnterSubRule(34);
			try { DebugEnterDecision(34, decisionCanBacktrack[34]);
			int LA34_0 = input.LA(1);

			if ((LA34_0==TYPE))
			{
				int LA34_1 = input.LA(2);

				if ((LA34_1==OPEN_BRACE))
				{
					alt34=1;
				}
				else if ((LA34_1==ARRAY_DECLARATION_MARK||LA34_1==OPEN_SQUARE_BRACE))
				{
					alt34=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 34, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
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
				// MathLang.g:143:15: simple_var_initializer
				{
				DebugLocation(143, 15);
				PushFollow(Follow._simple_var_initializer_in_initializer1397);
				simple_var_initializer163=simple_var_initializer();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, simple_var_initializer163.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:143:40: array_initializer
				{
				DebugLocation(143, 40);
				PushFollow(Follow._array_initializer_in_initializer1401);
				array_initializer164=array_initializer();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, array_initializer164.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(34); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("initializer", 45);
			LeaveRule("initializer", 45);
			Leave_initializer();
			if (state.backtracking > 0) { Memoize(input, 45, initializer_StartIndex); }
		}
		DebugLocation(143, 57);
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
	// MathLang.g:144:1: simple_var_initializer : type OPEN_BRACE CLOSE_BRACE -> ^( NEWVAR type ) ;
	[GrammarRule("simple_var_initializer")]
	private MathLangParser.simple_var_initializer_return simple_var_initializer()
	{
		Enter_simple_var_initializer();
		EnterRule("simple_var_initializer", 46);
		TraceIn("simple_var_initializer", 46);
		MathLangParser.simple_var_initializer_return retval = new MathLangParser.simple_var_initializer_return();
		retval.Start = (IToken)input.LT(1);
		int simple_var_initializer_StartIndex = input.Index;
		object root_0 = null;

		IToken OPEN_BRACE166=null;
		IToken CLOSE_BRACE167=null;
		MathLangParser.type_return type165 = default(MathLangParser.type_return);

		object OPEN_BRACE166_tree=null;
		object CLOSE_BRACE167_tree=null;
		RewriteRuleITokenStream stream_OPEN_BRACE=new RewriteRuleITokenStream(adaptor,"token OPEN_BRACE");
		RewriteRuleITokenStream stream_CLOSE_BRACE=new RewriteRuleITokenStream(adaptor,"token CLOSE_BRACE");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "simple_var_initializer");
		DebugLocation(144, 69);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 46)) { return retval; }
			// MathLang.g:144:23: ( type OPEN_BRACE CLOSE_BRACE -> ^( NEWVAR type ) )
			DebugEnterAlt(1);
			// MathLang.g:144:25: type OPEN_BRACE CLOSE_BRACE
			{
			DebugLocation(144, 25);
			PushFollow(Follow._type_in_simple_var_initializer1408);
			type165=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type165.Tree);
			DebugLocation(144, 30);
			OPEN_BRACE166=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_simple_var_initializer1410); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OPEN_BRACE.Add(OPEN_BRACE166);

			DebugLocation(144, 41);
			CLOSE_BRACE167=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_simple_var_initializer1412); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CLOSE_BRACE.Add(CLOSE_BRACE167);



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
			// 144:53: -> ^( NEWVAR type )
			{
				DebugLocation(144, 56);
				// MathLang.g:144:56: ^( NEWVAR type )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(144, 58);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(NEWVAR, "NEWVAR"), root_1);

				DebugLocation(144, 65);
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
			TraceOut("simple_var_initializer", 46);
			LeaveRule("simple_var_initializer", 46);
			Leave_simple_var_initializer();
			if (state.backtracking > 0) { Memoize(input, 46, simple_var_initializer_StartIndex); }
		}
		DebugLocation(144, 69);
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
	// MathLang.g:145:1: array_initializer : type ( ( OPEN_SQUARE_BRACE number CLOSE_SQUARE_BRACE ) | ARRAY_DECLARATION_MARK ) ( object_initializer )? -> ^( ARRAY_INITIALIZER type ( number )? ( object_initializer )? ) ;
	[GrammarRule("array_initializer")]
	private MathLangParser.array_initializer_return array_initializer()
	{
		Enter_array_initializer();
		EnterRule("array_initializer", 47);
		TraceIn("array_initializer", 47);
		MathLangParser.array_initializer_return retval = new MathLangParser.array_initializer_return();
		retval.Start = (IToken)input.LT(1);
		int array_initializer_StartIndex = input.Index;
		object root_0 = null;

		IToken OPEN_SQUARE_BRACE169=null;
		IToken CLOSE_SQUARE_BRACE171=null;
		IToken ARRAY_DECLARATION_MARK172=null;
		MathLangParser.type_return type168 = default(MathLangParser.type_return);
		MathLangParser.number_return number170 = default(MathLangParser.number_return);
		MathLangParser.object_initializer_return object_initializer173 = default(MathLangParser.object_initializer_return);

		object OPEN_SQUARE_BRACE169_tree=null;
		object CLOSE_SQUARE_BRACE171_tree=null;
		object ARRAY_DECLARATION_MARK172_tree=null;
		RewriteRuleITokenStream stream_OPEN_SQUARE_BRACE=new RewriteRuleITokenStream(adaptor,"token OPEN_SQUARE_BRACE");
		RewriteRuleITokenStream stream_ARRAY_DECLARATION_MARK=new RewriteRuleITokenStream(adaptor,"token ARRAY_DECLARATION_MARK");
		RewriteRuleITokenStream stream_CLOSE_SQUARE_BRACE=new RewriteRuleITokenStream(adaptor,"token CLOSE_SQUARE_BRACE");
		RewriteRuleSubtreeStream stream_number=new RewriteRuleSubtreeStream(adaptor,"rule number");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		RewriteRuleSubtreeStream stream_object_initializer=new RewriteRuleSubtreeStream(adaptor,"rule object_initializer");
		try { DebugEnterRule(GrammarFileName, "array_initializer");
		DebugLocation(145, 173);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 47)) { return retval; }
			// MathLang.g:145:18: ( type ( ( OPEN_SQUARE_BRACE number CLOSE_SQUARE_BRACE ) | ARRAY_DECLARATION_MARK ) ( object_initializer )? -> ^( ARRAY_INITIALIZER type ( number )? ( object_initializer )? ) )
			DebugEnterAlt(1);
			// MathLang.g:145:20: type ( ( OPEN_SQUARE_BRACE number CLOSE_SQUARE_BRACE ) | ARRAY_DECLARATION_MARK ) ( object_initializer )?
			{
			DebugLocation(145, 20);
			PushFollow(Follow._type_in_array_initializer1426);
			type168=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type168.Tree);
			DebugLocation(145, 25);
			// MathLang.g:145:25: ( ( OPEN_SQUARE_BRACE number CLOSE_SQUARE_BRACE ) | ARRAY_DECLARATION_MARK )
			int alt35=2;
			try { DebugEnterSubRule(35);
			try { DebugEnterDecision(35, decisionCanBacktrack[35]);
			int LA35_0 = input.LA(1);

			if ((LA35_0==OPEN_SQUARE_BRACE))
			{
				alt35=1;
			}
			else if ((LA35_0==ARRAY_DECLARATION_MARK))
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
				// MathLang.g:145:26: ( OPEN_SQUARE_BRACE number CLOSE_SQUARE_BRACE )
				{
				DebugLocation(145, 26);
				// MathLang.g:145:26: ( OPEN_SQUARE_BRACE number CLOSE_SQUARE_BRACE )
				DebugEnterAlt(1);
				// MathLang.g:145:27: OPEN_SQUARE_BRACE number CLOSE_SQUARE_BRACE
				{
				DebugLocation(145, 27);
				OPEN_SQUARE_BRACE169=(IToken)Match(input,OPEN_SQUARE_BRACE,Follow._OPEN_SQUARE_BRACE_in_array_initializer1430); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_OPEN_SQUARE_BRACE.Add(OPEN_SQUARE_BRACE169);

				DebugLocation(145, 45);
				PushFollow(Follow._number_in_array_initializer1432);
				number170=number();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_number.Add(number170.Tree);
				DebugLocation(145, 52);
				CLOSE_SQUARE_BRACE171=(IToken)Match(input,CLOSE_SQUARE_BRACE,Follow._CLOSE_SQUARE_BRACE_in_array_initializer1434); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_CLOSE_SQUARE_BRACE.Add(CLOSE_SQUARE_BRACE171);


				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:145:74: ARRAY_DECLARATION_MARK
				{
				DebugLocation(145, 74);
				ARRAY_DECLARATION_MARK172=(IToken)Match(input,ARRAY_DECLARATION_MARK,Follow._ARRAY_DECLARATION_MARK_in_array_initializer1439); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ARRAY_DECLARATION_MARK.Add(ARRAY_DECLARATION_MARK172);


				}
				break;

			}
			} finally { DebugExitSubRule(35); }

			DebugLocation(145, 98);
			// MathLang.g:145:98: ( object_initializer )?
			int alt36=2;
			try { DebugEnterSubRule(36);
			try { DebugEnterDecision(36, decisionCanBacktrack[36]);
			int LA36_0 = input.LA(1);

			if ((LA36_0==64))
			{
				alt36=1;
			}
			} finally { DebugExitDecision(36); }
			switch (alt36)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: object_initializer
				{
				DebugLocation(145, 98);
				PushFollow(Follow._object_initializer_in_array_initializer1442);
				object_initializer173=object_initializer();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_object_initializer.Add(object_initializer173.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(36); }



			{
			// AST REWRITE
			// elements: object_initializer, type, number
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 145:118: -> ^( ARRAY_INITIALIZER type ( number )? ( object_initializer )? )
			{
				DebugLocation(145, 121);
				// MathLang.g:145:121: ^( ARRAY_INITIALIZER type ( number )? ( object_initializer )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(145, 123);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAY_INITIALIZER, "ARRAY_INITIALIZER"), root_1);

				DebugLocation(145, 141);
				adaptor.AddChild(root_1, stream_type.NextTree());
				DebugLocation(145, 146);
				// MathLang.g:145:146: ( number )?
				if ( stream_number.HasNext )
				{
					DebugLocation(145, 146);
					adaptor.AddChild(root_1, stream_number.NextTree());

				}
				stream_number.Reset();
				DebugLocation(145, 154);
				// MathLang.g:145:154: ( object_initializer )?
				if ( stream_object_initializer.HasNext )
				{
					DebugLocation(145, 154);
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
			TraceOut("array_initializer", 47);
			LeaveRule("array_initializer", 47);
			Leave_array_initializer();
			if (state.backtracking > 0) { Memoize(input, 47, array_initializer_StartIndex); }
		}
		DebugLocation(145, 173);
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
	// MathLang.g:147:1: block : '{' statementlist '}' ;
	[GrammarRule("block")]
	private MathLangParser.block_return block()
	{
		Enter_block();
		EnterRule("block", 48);
		TraceIn("block", 48);
		MathLangParser.block_return retval = new MathLangParser.block_return();
		retval.Start = (IToken)input.LT(1);
		int block_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal174=null;
		IToken char_literal176=null;
		MathLangParser.statementlist_return statementlist175 = default(MathLangParser.statementlist_return);

		object char_literal174_tree=null;
		object char_literal176_tree=null;

		try { DebugEnterRule(GrammarFileName, "block");
		DebugLocation(147, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 48)) { return retval; }
			// MathLang.g:147:6: ( '{' statementlist '}' )
			DebugEnterAlt(1);
			// MathLang.g:147:8: '{' statementlist '}'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(147, 11);
			char_literal174=(IToken)Match(input,64,Follow._64_in_block1464); if (state.failed) return retval;
			DebugLocation(147, 13);
			PushFollow(Follow._statementlist_in_block1467);
			statementlist175=statementlist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementlist175.Tree);
			DebugLocation(147, 30);
			char_literal176=(IToken)Match(input,65,Follow._65_in_block1469); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("block", 48);
			LeaveRule("block", 48);
			Leave_block();
			if (state.backtracking > 0) { Memoize(input, 48, block_StartIndex); }
		}
		DebugLocation(147, 30);
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
	// MathLang.g:149:1: statementlist : ( statement )* -> ^( BLOCK ( statement )* ) ;
	[GrammarRule("statementlist")]
	private MathLangParser.statementlist_return statementlist()
	{
		Enter_statementlist();
		EnterRule("statementlist", 49);
		TraceIn("statementlist", 49);
		MathLangParser.statementlist_return retval = new MathLangParser.statementlist_return();
		retval.Start = (IToken)input.LT(1);
		int statementlist_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.statement_return statement177 = default(MathLangParser.statement_return);

		RewriteRuleSubtreeStream stream_statement=new RewriteRuleSubtreeStream(adaptor,"rule statement");
		try { DebugEnterRule(GrammarFileName, "statementlist");
		DebugLocation(149, 49);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 49)) { return retval; }
			// MathLang.g:149:14: ( ( statement )* -> ^( BLOCK ( statement )* ) )
			DebugEnterAlt(1);
			// MathLang.g:149:16: ( statement )*
			{
			DebugLocation(149, 16);
			// MathLang.g:149:16: ( statement )*
			try { DebugEnterSubRule(37);
			while (true)
			{
				int alt37=2;
				try { DebugEnterDecision(37, decisionCanBacktrack[37]);
				int LA37_0 = input.LA(1);

				if ((LA37_0==IF||LA37_0==FOR||(LA37_0>=RETURN && LA37_0<=DO)||(LA37_0>=ID && LA37_0<=TYPE)||LA37_0==KNEW))
				{
					alt37=1;
				}


				} finally { DebugExitDecision(37); }
				switch ( alt37 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: statement
					{
					DebugLocation(149, 16);
					PushFollow(Follow._statement_in_statementlist1477);
					statement177=statement();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_statement.Add(statement177.Tree);

					}
					break;

				default:
					goto loop37;
				}
			}

			loop37:
				;

			} finally { DebugExitSubRule(37); }



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
			// 149:27: -> ^( BLOCK ( statement )* )
			{
				DebugLocation(149, 30);
				// MathLang.g:149:30: ^( BLOCK ( statement )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(149, 32);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

				DebugLocation(149, 38);
				// MathLang.g:149:38: ( statement )*
				while ( stream_statement.HasNext )
				{
					DebugLocation(149, 38);
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
			TraceOut("statementlist", 49);
			LeaveRule("statementlist", 49);
			Leave_statementlist();
			if (state.backtracking > 0) { Memoize(input, 49, statementlist_StartIndex); }
		}
		DebugLocation(149, 49);
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
		EnterRule("synpred20_MathLang_fragment", 69);
		TraceIn("synpred20_MathLang_fragment", 69);
		try
		{
			// MathLang.g:89:5: ( funccallbody )
			DebugEnterAlt(1);
			// MathLang.g:89:5: funccallbody
			{
			DebugLocation(89, 5);
			PushFollow(Follow._funccallbody_in_synpred20_MathLang615);
			funccallbody();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred20_MathLang_fragment", 69);
			LeaveRule("synpred20_MathLang_fragment", 69);
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
		EnterRule("synpred21_MathLang_fragment", 70);
		TraceIn("synpred21_MathLang_fragment", 70);
		try
		{
			// MathLang.g:90:5: ( boolexpression )
			DebugEnterAlt(1);
			// MathLang.g:90:5: boolexpression
			{
			DebugLocation(90, 5);
			PushFollow(Follow._boolexpression_in_synpred21_MathLang621);
			boolexpression();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred21_MathLang_fragment", 70);
			LeaveRule("synpred21_MathLang_fragment", 70);
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
		EnterRule("synpred34_MathLang_fragment", 83);
		TraceIn("synpred34_MathLang_fragment", 83);
		try
		{
			// MathLang.g:110:16: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )
			DebugEnterAlt(1);
			// MathLang.g:110:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
			{
			DebugLocation(110, 16);
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

			DebugLocation(110, 53);
			PushFollow(Follow._add_in_synpred34_MathLang887);
			add();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred34_MathLang_fragment", 83);
			LeaveRule("synpred34_MathLang_fragment", 83);
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
		EnterRule("synpred43_MathLang_fragment", 92);
		TraceIn("synpred43_MathLang_fragment", 92);
		try
		{
			// MathLang.g:122:22: ( OPEN_BRACE boolterm CLOSE_BRACE )
			DebugEnterAlt(1);
			// MathLang.g:122:22: OPEN_BRACE boolterm CLOSE_BRACE
			{
			DebugLocation(122, 22);
			Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_synpred43_MathLang1047); if (state.failed) return;
			DebugLocation(122, 34);
			PushFollow(Follow._boolterm_in_synpred43_MathLang1050);
			boolterm();
			PopFollow();
			if (state.failed) return;
			DebugLocation(122, 43);
			Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_synpred43_MathLang1052); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred43_MathLang_fragment", 92);
			LeaveRule("synpred43_MathLang_fragment", 92);
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
		EnterRule("synpred48_MathLang_fragment", 97);
		TraceIn("synpred48_MathLang_fragment", 97);
		try
		{
			// MathLang.g:127:79: ( ELSE ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:127:79: ELSE ( block | statement )
			{
			DebugLocation(127, 79);
			Match(input,ELSE,Follow._ELSE_in_synpred48_MathLang1106); if (state.failed) return;
			DebugLocation(127, 85);
			// MathLang.g:127:85: ( block | statement )
			int alt39=2;
			try { DebugEnterSubRule(39);
			try { DebugEnterDecision(39, decisionCanBacktrack[39]);
			int LA39_0 = input.LA(1);

			if ((LA39_0==64))
			{
				alt39=1;
			}
			else if ((LA39_0==IF||LA39_0==FOR||(LA39_0>=RETURN && LA39_0<=DO)||(LA39_0>=ID && LA39_0<=TYPE)||LA39_0==KNEW))
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
				// MathLang.g:127:86: block
				{
				DebugLocation(127, 86);
				PushFollow(Follow._block_in_synpred48_MathLang1110);
				block();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:127:94: statement
				{
				DebugLocation(127, 94);
				PushFollow(Follow._statement_in_synpred48_MathLang1114);
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
			TraceOut("synpred48_MathLang_fragment", 97);
			LeaveRule("synpred48_MathLang_fragment", 97);
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
	DFA5 dfa5;
	DFA8 dfa8;
	DFA14 dfa14;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa5 = new DFA5( this );
		dfa8 = new DFA8( this, SpecialStateTransition8 );
		dfa14 = new DFA14( this, SpecialStateTransition14 );
	}

	private class DFA5 : DFA
	{
		private const string DFA5_eotS =
			"\xB\xFFFF";
		private const string DFA5_eofS =
			"\xB\xFFFF";
		private const string DFA5_minS =
			"\x1\x7\x1\xFFFF\x1\x27\x8\xFFFF";
		private const string DFA5_maxS =
			"\x1\x39\x1\xFFFF\x1\x3A\x8\xFFFF";
		private const string DFA5_acceptS =
			"\x1\xFFFF\x1\x1\x1\xFFFF\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x1\x9\x1\x2\x1"+
			"\x8";
		private const string DFA5_specialS =
			"\xB\xFFFF}>";
		private static readonly string[] DFA5_transitionS =
			{
				"\x1\x3\x1\xFFFF\x1\x6\x1\xFFFF\x1\x7\x1\x4\x1\x5\x13\xFFFF\x1\x2\x1"+
				"\x1\x16\xFFFF\x1\x8",
				"",
				"\x1\x9\xA\xFFFF\x1\xA\x7\xFFFF\x1\x9",
				"",
				"",
				"",
				"",
				"",
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

		public override string Description { get { return "65:12: ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | returnstatement | funccall | newexpression )"; } }

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
			"\x1\x21\x1\xFFFF\x1\x0\x1\xFFFF\x1\x0\x2\xFFFF\x3\x0\x2\xFFFF";
		private const string DFA8_maxS =
			"\x1\x39\x1\xFFFF\x1\x0\x1\xFFFF\x1\x0\x2\xFFFF\x3\x0\x2\xFFFF";
		private const string DFA8_acceptS =
			"\x1\xFFFF\x1\x1\x1\xFFFF\x1\x3\x6\xFFFF\x1\x2\x1\x4";
		private const string DFA8_specialS =
			"\x2\xFFFF\x1\x0\x1\xFFFF\x1\x1\x2\xFFFF\x1\x2\x1\x3\x1\x4\x2\xFFFF}>";
		private static readonly string[] DFA8_transitionS =
			{
				"\x1\x2\x3\xFFFF\x1\x8\x1\x9\x2\xFFFF\x1\x7\x8\xFFFF\x1\x4\x3\xFFFF"+
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

		public override string Description { get { return "87:1: expression : ( newexpression | funccallbody | boolexpression | mathexpression );"; } }

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
	private class DFA14 : DFA
	{
		private const string DFA14_eotS =
			"\xA\xFFFF";
		private const string DFA14_eofS =
			"\x1\x2\x9\xFFFF";
		private const string DFA14_minS =
			"\x1\x2C\x1\x0\x8\xFFFF";
		private const string DFA14_maxS =
			"\x1\x43\x1\x0\x8\xFFFF";
		private const string DFA14_acceptS =
			"\x2\xFFFF\x1\x2\x1\xFFFF\x1\x1\x5\xFFFF";
		private const string DFA14_specialS =
			"\x1\xFFFF\x1\x0\x8\xFFFF}>";
		private static readonly string[] DFA14_transitionS =
			{
				"\x2\x4\x2\x1\x2\x4\x1\xFFFF\x3\x2\xB\xFFFF\x3\x2",
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

		private static readonly short[] DFA14_eot = DFA.UnpackEncodedString(DFA14_eotS);
		private static readonly short[] DFA14_eof = DFA.UnpackEncodedString(DFA14_eofS);
		private static readonly char[] DFA14_min = DFA.UnpackEncodedStringToUnsignedChars(DFA14_minS);
		private static readonly char[] DFA14_max = DFA.UnpackEncodedStringToUnsignedChars(DFA14_maxS);
		private static readonly short[] DFA14_accept = DFA.UnpackEncodedString(DFA14_acceptS);
		private static readonly short[] DFA14_special = DFA.UnpackEncodedString(DFA14_specialS);
		private static readonly short[][] DFA14_transition;

		static DFA14()
		{
			int numStates = DFA14_transitionS.Length;
			DFA14_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA14_transition[i] = DFA.UnpackEncodedString(DFA14_transitionS[i]);
			}
		}

		public DFA14( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 14;
			this.eot = DFA14_eot;
			this.eof = DFA14_eof;
			this.min = DFA14_min;
			this.max = DFA14_max;
			this.accept = DFA14_accept;
			this.special = DFA14_special;
			this.transition = DFA14_transition;
		}

		public override string Description { get { return "110:14: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition14(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA14_1 = input.LA(1);


				int index14_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred34_MathLang_fragment)) ) {s = 4;}

				else if ( (true) ) {s = 2;}


				input.Seek(index14_1);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 14, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}

	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _class_list_in_execute364 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_execute366 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MODIFIER_in_class_declaration385 = new BitSet(new ulong[]{0x80000000UL});
		public static readonly BitSet _CLASS_WORD_in_class_declaration387 = new BitSet(new ulong[]{0x200000000UL});
		public static readonly BitSet _ID_in_class_declaration389 = new BitSet(new ulong[]{0x0UL,0x1UL});
		public static readonly BitSet _class_block_in_class_declaration391 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _64_in_class_block409 = new BitSet(new ulong[]{0x100000000UL,0x2UL});
		public static readonly BitSet _static_func_or_var_declaration_in_class_block412 = new BitSet(new ulong[]{0x100000000UL,0x2UL});
		public static readonly BitSet _65_in_class_block415 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _static_declaration_in_static_func_or_var_declaration434 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funcdeclaration_in_static_func_or_var_declaration438 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _class_declaration_in_class_list447 = new BitSet(new ulong[]{0x100000002UL});
		public static readonly BitSet _funcdeclaration_in_func_list457 = new BitSet(new ulong[]{0x100000002UL});
		public static readonly BitSet _declaration_in_statement478 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assignment_in_statement484 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ifstatement_in_statement489 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _whilestatement_in_statement494 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _dowhilestatement_in_statement499 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _forstatement_in_statement504 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _returnstatement_in_statement509 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccall_in_statement514 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _newexpression_in_statement519 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_type533 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_array_type540 = new BitSet(new ulong[]{0x800000000UL});
		public static readonly BitSet _ARRAY_DECLARATION_MARK_in_array_type542 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_any_type549 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_type_in_any_type553 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _VOID_in_any_type557 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NUMBER_in_number565 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_number571 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_number577 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CHAR_in_number583 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrayelement_in_number589 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _term_in_mathexpression595 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _newexpression_in_expression609 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_expression615 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolexpression_in_expression621 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathexpression_in_expression627 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_arrayelement642 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _OPEN_SQUARE_BRACE_in_arrayelement644 = new BitSet(new ulong[]{0x6200000000UL});
		public static readonly BitSet _number_in_arrayelement646 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _CLOSE_SQUARE_BRACE_in_arrayelement648 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MODIFIER_in_static_declaration666 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _declaration_in_static_declaration668 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declarationbody_in_declaration682 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _66_in_declaration684 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _longdeclaration_in_declaration692 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_declarationbody700 = new BitSet(new ulong[]{0x200000000UL});
		public static readonly BitSet _ID_in_declarationbody702 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_type_in_declarationbody723 = new BitSet(new ulong[]{0x200000000UL});
		public static readonly BitSet _ID_in_declarationbody725 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _longdeclarationbody_in_longdeclaration747 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _66_in_longdeclaration749 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_longdeclarationbody758 = new BitSet(new ulong[]{0x200000000UL});
		public static readonly BitSet _ID_in_longdeclarationbody760 = new BitSet(new ulong[]{0x8000000000UL});
		public static readonly BitSet _ASSIGN_in_longdeclarationbody762 = new BitSet(new ulong[]{0x3C4026200000000UL});
		public static readonly BitSet _expression_in_longdeclarationbody764 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_type_in_longdeclarationbody788 = new BitSet(new ulong[]{0x200000000UL});
		public static readonly BitSet _ID_in_longdeclarationbody790 = new BitSet(new ulong[]{0x8000000000UL});
		public static readonly BitSet _ASSIGN_in_longdeclarationbody792 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _newexpression_in_longdeclarationbody794 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mul_in_add814 = new BitSet(new ulong[]{0x30000000002UL});
		public static readonly BitSet _set_in_add818 = new BitSet(new ulong[]{0x1C4026200000000UL});
		public static readonly BitSet _mul_in_add827 = new BitSet(new ulong[]{0x30000000002UL});
		public static readonly BitSet _group_in_mul836 = new BitSet(new ulong[]{0xC0000000002UL});
		public static readonly BitSet _set_in_mul840 = new BitSet(new ulong[]{0x1C4026200000000UL});
		public static readonly BitSet _group_in_mul849 = new BitSet(new ulong[]{0xC0000000002UL});
		public static readonly BitSet _add_in_compare857 = new BitSet(new ulong[]{0x3F00000000002UL});
		public static readonly BitSet _set_in_compare861 = new BitSet(new ulong[]{0x1C4026200000000UL});
		public static readonly BitSet _add_in_compare887 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _add_in_term898 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _SUB_in_group905 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_group910 = new BitSet(new ulong[]{0x3C4026200000000UL});
		public static readonly BitSet _term_in_group913 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_group915 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _number_in_group920 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assignmentbody_in_assignment927 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _66_in_assignment929 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_assignmentbody937 = new BitSet(new ulong[]{0x8000000000UL});
		public static readonly BitSet _ASSIGN_in_assignmentbody939 = new BitSet(new ulong[]{0x3C4026200000000UL});
		public static readonly BitSet _expression_in_assignmentbody941 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrayelement_in_assignmentbody960 = new BitSet(new ulong[]{0x8000000000UL});
		public static readonly BitSet _ASSIGN_in_assignmentbody962 = new BitSet(new ulong[]{0x3C4026200000000UL});
		public static readonly BitSet _expression_in_assignmentbody964 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolterm_in_boolexpression982 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _or_in_boolterm989 = new BitSet(new ulong[]{0xC00000000002UL});
		public static readonly BitSet _set_in_boolterm993 = new BitSet(new ulong[]{0x1C4026200000000UL});
		public static readonly BitSet _or_in_boolterm1002 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _and_in_or1011 = new BitSet(new ulong[]{0x10000000000002UL});
		public static readonly BitSet _OR_in_or1014 = new BitSet(new ulong[]{0x1C4026200000000UL});
		public static readonly BitSet _and_in_or1017 = new BitSet(new ulong[]{0x10000000000002UL});
		public static readonly BitSet _boolgroup_in_and1025 = new BitSet(new ulong[]{0x20000000000002UL});
		public static readonly BitSet _AND_in_and1028 = new BitSet(new ulong[]{0x1C4026200000000UL});
		public static readonly BitSet _boolgroup_in_and1031 = new BitSet(new ulong[]{0x20000000000002UL});
		public static readonly BitSet _NOT_in_boolgroup1040 = new BitSet(new ulong[]{0x1C4026200000000UL});
		public static readonly BitSet _OPEN_BRACE_in_boolgroup1047 = new BitSet(new ulong[]{0x1C4026200000000UL});
		public static readonly BitSet _boolterm_in_boolgroup1050 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_boolgroup1052 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolvar_in_boolgroup1057 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TRUE_in_boolvar1065 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FALSE_in_boolvar1071 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _compare_in_boolvar1077 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_ifstatement1086 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_ifstatement1089 = new BitSet(new ulong[]{0x1C4026200000000UL});
		public static readonly BitSet _boolexpression_in_ifstatement1092 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_ifstatement1094 = new BitSet(new ulong[]{0x200006600003A80UL,0x1UL});
		public static readonly BitSet _block_in_ifstatement1098 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement1102 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _ELSE_in_ifstatement1106 = new BitSet(new ulong[]{0x200006600003A80UL,0x1UL});
		public static readonly BitSet _block_in_ifstatement1110 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement1114 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _WHILE_in_whilestatement1124 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_whilestatement1127 = new BitSet(new ulong[]{0x1C4026200000000UL});
		public static readonly BitSet _boolexpression_in_whilestatement1130 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_whilestatement1132 = new BitSet(new ulong[]{0x200006600003A80UL,0x1UL});
		public static readonly BitSet _block_in_whilestatement1136 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_whilestatement1140 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_forstatement1147 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_forstatement1150 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _longdeclarationbody_in_forstatement1153 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _66_in_forstatement1155 = new BitSet(new ulong[]{0x1C4026200000000UL});
		public static readonly BitSet _boolexpression_in_forstatement1158 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _66_in_forstatement1160 = new BitSet(new ulong[]{0x6200000000UL});
		public static readonly BitSet _assignmentbody_in_forstatement1163 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_forstatement1165 = new BitSet(new ulong[]{0x200006600003A80UL,0x1UL});
		public static readonly BitSet _block_in_forstatement1169 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_forstatement1173 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _RETURN_in_returnstatement1180 = new BitSet(new ulong[]{0x3C4026200000000UL});
		public static readonly BitSet _expression_in_returnstatement1183 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _66_in_returnstatement1185 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DO_in_dowhilestatement1193 = new BitSet(new ulong[]{0x200006600003A80UL,0x1UL});
		public static readonly BitSet _block_in_dowhilestatement1197 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _statement_in_dowhilestatement1201 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _WHILE_in_dowhilestatement1204 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_dowhilestatement1207 = new BitSet(new ulong[]{0x1C4026200000000UL});
		public static readonly BitSet _boolexpression_in_dowhilestatement1210 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_dowhilestatement1212 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _66_in_dowhilestatement1215 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MODIFIER_in_funcdeclaration1224 = new BitSet(new ulong[]{0x1400000000UL});
		public static readonly BitSet _any_type_in_funcdeclaration1226 = new BitSet(new ulong[]{0x200000000UL});
		public static readonly BitSet _ID_in_funcdeclaration1228 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_funcdeclaration1233 = new BitSet(new ulong[]{0x8000400000000UL});
		public static readonly BitSet _paramsdeclaration_in_funcdeclaration1236 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_funcdeclaration1239 = new BitSet(new ulong[]{0x0UL,0x1UL});
		public static readonly BitSet _block_in_funcdeclaration1244 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declarationbody_in_paramsdeclaration1277 = new BitSet(new ulong[]{0x2UL,0x8UL});
		public static readonly BitSet _67_in_paramsdeclaration1281 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _declarationbody_in_paramsdeclaration1284 = new BitSet(new ulong[]{0x2UL,0x8UL});
		public static readonly BitSet _ID_in_funccallbody1309 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_funccallbody1312 = new BitSet(new ulong[]{0x3CC026200000000UL});
		public static readonly BitSet _expressioncommalist_in_funccallbody1314 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_funccallbody1317 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_funccall1340 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _66_in_funccall1342 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_expressioncommalist1349 = new BitSet(new ulong[]{0x2UL,0x8UL});
		public static readonly BitSet _67_in_expressioncommalist1353 = new BitSet(new ulong[]{0x3C4026200000000UL});
		public static readonly BitSet _expression_in_expressioncommalist1356 = new BitSet(new ulong[]{0x2UL,0x8UL});
		public static readonly BitSet _64_in_object_initializer1368 = new BitSet(new ulong[]{0x3C4026200000000UL});
		public static readonly BitSet _expressioncommalist_in_object_initializer1370 = new BitSet(new ulong[]{0x0UL,0x2UL});
		public static readonly BitSet _65_in_object_initializer1372 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _KNEW_in_newexpression1387 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _initializer_in_newexpression1390 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _simple_var_initializer_in_initializer1397 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_initializer_in_initializer1401 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_simple_var_initializer1408 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_simple_var_initializer1410 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_simple_var_initializer1412 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_array_initializer1426 = new BitSet(new ulong[]{0x400000800000000UL});
		public static readonly BitSet _OPEN_SQUARE_BRACE_in_array_initializer1430 = new BitSet(new ulong[]{0x6200000000UL});
		public static readonly BitSet _number_in_array_initializer1432 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _CLOSE_SQUARE_BRACE_in_array_initializer1434 = new BitSet(new ulong[]{0x2UL,0x1UL});
		public static readonly BitSet _ARRAY_DECLARATION_MARK_in_array_initializer1439 = new BitSet(new ulong[]{0x2UL,0x1UL});
		public static readonly BitSet _object_initializer_in_array_initializer1442 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _64_in_block1464 = new BitSet(new ulong[]{0x200006600003A80UL,0x3UL});
		public static readonly BitSet _statementlist_in_block1467 = new BitSet(new ulong[]{0x0UL,0x2UL});
		public static readonly BitSet _65_in_block1469 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_statementlist1477 = new BitSet(new ulong[]{0x200006600003A82UL,0x1UL});
		public static readonly BitSet _funccallbody_in_synpred20_MathLang615 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolexpression_in_synpred21_MathLang621 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_synpred34_MathLang861 = new BitSet(new ulong[]{0x1C4026200000000UL});
		public static readonly BitSet _add_in_synpred34_MathLang887 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _OPEN_BRACE_in_synpred43_MathLang1047 = new BitSet(new ulong[]{0x1C4026200000000UL});
		public static readonly BitSet _boolterm_in_synpred43_MathLang1050 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_synpred43_MathLang1052 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ELSE_in_synpred48_MathLang1106 = new BitSet(new ulong[]{0x200006600003A80UL,0x1UL});
		public static readonly BitSet _block_in_synpred48_MathLang1110 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_synpred48_MathLang1114 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  MathLang 

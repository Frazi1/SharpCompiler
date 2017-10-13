// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-10-13 23:35:04

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "UNKNOWN", "PRINT", "INPUT", "IF", "ELSE", "FOR", "FUNCTION", "RETURN", "WHILE", "DO", "BLOCK", "PROGRAM", "PARAMS", "VARDECLARATION", "FUNCDECLARATION", "ARRAYDECLARATION", "VARASSIGNMENT", "ARRAYELEMENTASSIGNMENT", "ARRAYELEMENT", "NEWVAR", "ARRAY_INITIALIZER", "OBJECT_INITIALIZER", "FUNC_CALL", "RETURN_TYPE", "PARAMETERS", "STATIC_DECLARATION", "CLASSBLOCK", "CLASS_WORD", "CALL", "MODIFIER", "ID", "TYPE", "ARRAY_DECLARATION_MARK", "VOID", "NUMBER", "CHAR", "DOT", "ASSIGN", "ADD", "SUB", "MUL", "DIV", "GREQ", "LSEQ", "NEQ", "EQ", "GR", "LS", "OPEN_BRACE", "CLOSE_BRACE", "OR", "AND", "NOT", "TRUE", "FALSE", "KNEW", "OPEN_SQUARE_BRACE", "CLOSE_SQUARE_BRACE", "CONSOLE_WORD", "WS", "SL_COMMENT", "ML_COMMENT", "'{'", "'}'", "';'", "','"
	};
	public const int EOF=-1;
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
	public const int STATIC_DECLARATION=29;
	public const int CLASSBLOCK=30;
	public const int CLASS_WORD=31;
	public const int CALL=32;
	public const int MODIFIER=33;
	public const int ID=34;
	public const int TYPE=35;
	public const int ARRAY_DECLARATION_MARK=36;
	public const int VOID=37;
	public const int NUMBER=38;
	public const int CHAR=39;
	public const int DOT=40;
	public const int ASSIGN=41;
	public const int ADD=42;
	public const int SUB=43;
	public const int MUL=44;
	public const int DIV=45;
	public const int GREQ=46;
	public const int LSEQ=47;
	public const int NEQ=48;
	public const int EQ=49;
	public const int GR=50;
	public const int LS=51;
	public const int OPEN_BRACE=52;
	public const int CLOSE_BRACE=53;
	public const int OR=54;
	public const int AND=55;
	public const int NOT=56;
	public const int TRUE=57;
	public const int FALSE=58;
	public const int KNEW=59;
	public const int OPEN_SQUARE_BRACE=60;
	public const int CLOSE_SQUARE_BRACE=61;
	public const int CONSOLE_WORD=62;
	public const int WS=63;
	public const int SL_COMMENT=64;
	public const int ML_COMMENT=65;

	// delegates
	// delegators

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, false, false, false, true, true, false, 
				false, false, false, false, true, false, false, false, false, false, 
				false, false, true, false, false, false, true, false, false, false, 
				false, false, false, false, false, false, false, false, , false
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
		this.state.ruleMemo = new System.Collections.Generic.Dictionary<int, int>[111+1];

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
	// MathLang.g:52:8: public execute : class_list EOF -> ^( PROGRAM class_list ) ;
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
		DebugLocation(52, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 1)) { return retval; }
			// MathLang.g:52:15: ( class_list EOF -> ^( PROGRAM class_list ) )
			DebugEnterAlt(1);
			// MathLang.g:53:2: class_list EOF
			{
			DebugLocation(53, 2);
			PushFollow(Follow._class_list_in_execute369);
			class_list1=class_list();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_class_list.Add(class_list1.Tree);
			DebugLocation(53, 16);
			EOF2=(IToken)Match(input,EOF,Follow._EOF_in_execute371); if (state.failed) return retval; 
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
			// 53:19: -> ^( PROGRAM class_list )
			{
				DebugLocation(53, 22);
				// MathLang.g:53:22: ^( PROGRAM class_list )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(53, 24);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROGRAM, "PROGRAM"), root_1);

				DebugLocation(53, 32);
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
		DebugLocation(54, 0);
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
	// MathLang.g:56:1: class_declaration : MODIFIER CLASS_WORD ID class_block -> ^( CLASS_WORD ID class_block ) ;
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
		DebugLocation(56, 86);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 2)) { return retval; }
			// MathLang.g:56:18: ( MODIFIER CLASS_WORD ID class_block -> ^( CLASS_WORD ID class_block ) )
			DebugEnterAlt(1);
			// MathLang.g:56:20: MODIFIER CLASS_WORD ID class_block
			{
			DebugLocation(56, 20);
			MODIFIER3=(IToken)Match(input,MODIFIER,Follow._MODIFIER_in_class_declaration390); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_MODIFIER.Add(MODIFIER3);

			DebugLocation(56, 29);
			CLASS_WORD4=(IToken)Match(input,CLASS_WORD,Follow._CLASS_WORD_in_class_declaration392); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CLASS_WORD.Add(CLASS_WORD4);

			DebugLocation(56, 40);
			ID5=(IToken)Match(input,ID,Follow._ID_in_class_declaration394); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID5);

			DebugLocation(56, 43);
			PushFollow(Follow._class_block_in_class_declaration396);
			class_block6=class_block();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_class_block.Add(class_block6.Tree);


			{
			// AST REWRITE
			// elements: ID, CLASS_WORD, class_block
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 56:55: -> ^( CLASS_WORD ID class_block )
			{
				DebugLocation(56, 58);
				// MathLang.g:56:58: ^( CLASS_WORD ID class_block )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(56, 60);
				root_1 = (object)adaptor.BecomeRoot(stream_CLASS_WORD.NextNode(), root_1);

				DebugLocation(56, 71);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(56, 74);
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
		DebugLocation(56, 86);
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
	// MathLang.g:58:1: class_block : '{' ( static_func_or_var_declaration )* '}' -> ^( CLASSBLOCK ( static_func_or_var_declaration )* ) ;
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
		RewriteRuleITokenStream stream_66=new RewriteRuleITokenStream(adaptor,"token 66");
		RewriteRuleITokenStream stream_67=new RewriteRuleITokenStream(adaptor,"token 67");
		RewriteRuleSubtreeStream stream_static_func_or_var_declaration=new RewriteRuleSubtreeStream(adaptor,"rule static_func_or_var_declaration");
		try { DebugEnterRule(GrammarFileName, "class_block");
		DebugLocation(58, 105);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 3)) { return retval; }
			// MathLang.g:58:12: ( '{' ( static_func_or_var_declaration )* '}' -> ^( CLASSBLOCK ( static_func_or_var_declaration )* ) )
			DebugEnterAlt(1);
			// MathLang.g:58:14: '{' ( static_func_or_var_declaration )* '}'
			{
			DebugLocation(58, 17);
			char_literal7=(IToken)Match(input,66,Follow._66_in_class_block414); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_66.Add(char_literal7);

			DebugLocation(58, 19);
			// MathLang.g:58:19: ( static_func_or_var_declaration )*
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
					DebugLocation(58, 19);
					PushFollow(Follow._static_func_or_var_declaration_in_class_block417);
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

			DebugLocation(58, 54);
			char_literal9=(IToken)Match(input,67,Follow._67_in_class_block420); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_67.Add(char_literal9);



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
			// 58:56: -> ^( CLASSBLOCK ( static_func_or_var_declaration )* )
			{
				DebugLocation(58, 59);
				// MathLang.g:58:59: ^( CLASSBLOCK ( static_func_or_var_declaration )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(58, 61);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(CLASSBLOCK, "CLASSBLOCK"), root_1);

				DebugLocation(58, 72);
				// MathLang.g:58:72: ( static_func_or_var_declaration )*
				while ( stream_static_func_or_var_declaration.HasNext )
				{
					DebugLocation(58, 72);
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
		DebugLocation(58, 105);
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
	// MathLang.g:60:1: static_func_or_var_declaration : ( static_declaration | funcdeclaration );
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
		DebugLocation(60, 69);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 4)) { return retval; }
			// MathLang.g:60:31: ( static_declaration | funcdeclaration )
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

							if ((LA2_6==ASSIGN||LA2_6==68))
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

						if ((LA2_5==ASSIGN||LA2_5==68))
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
				// MathLang.g:60:33: static_declaration
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(60, 33);
				PushFollow(Follow._static_declaration_in_static_func_or_var_declaration439);
				static_declaration10=static_declaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, static_declaration10.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:60:54: funcdeclaration
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(60, 54);
				PushFollow(Follow._funcdeclaration_in_static_func_or_var_declaration443);
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
		DebugLocation(60, 69);
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
	// MathLang.g:62:1: class_list : ( class_declaration )* ;
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
		DebugLocation(62, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 5)) { return retval; }
			// MathLang.g:62:11: ( ( class_declaration )* )
			DebugEnterAlt(1);
			// MathLang.g:62:14: ( class_declaration )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(62, 14);
			// MathLang.g:62:14: ( class_declaration )*
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
					DebugLocation(62, 14);
					PushFollow(Follow._class_declaration_in_class_list452);
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
		DebugLocation(62, 32);
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
	// MathLang.g:64:1: func_list : ( funcdeclaration )* -> ^( PROGRAM ( funcdeclaration )* ) ;
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
		DebugLocation(64, 61);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 6)) { return retval; }
			// MathLang.g:64:11: ( ( funcdeclaration )* -> ^( PROGRAM ( funcdeclaration )* ) )
			DebugEnterAlt(1);
			// MathLang.g:64:13: ( funcdeclaration )*
			{
			DebugLocation(64, 13);
			// MathLang.g:64:13: ( funcdeclaration )*
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
					DebugLocation(64, 13);
					PushFollow(Follow._funcdeclaration_in_func_list462);
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
			// 64:30: -> ^( PROGRAM ( funcdeclaration )* )
			{
				DebugLocation(64, 33);
				// MathLang.g:64:33: ^( PROGRAM ( funcdeclaration )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(64, 35);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROGRAM, "PROGRAM"), root_1);

				DebugLocation(64, 43);
				// MathLang.g:64:43: ( funcdeclaration )*
				while ( stream_funcdeclaration.HasNext )
				{
					DebugLocation(64, 43);
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
		DebugLocation(64, 61);
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
	// MathLang.g:66:1: statement : ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | returnstatement | funccall | newexpression ) ;
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
		DebugLocation(66, 4);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 7)) { return retval; }
			// MathLang.g:66:10: ( ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | returnstatement | funccall | newexpression ) )
			DebugEnterAlt(1);
			// MathLang.g:66:12: ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | returnstatement | funccall | newexpression )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(66, 12);
			// MathLang.g:66:12: ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | returnstatement | funccall | newexpression )
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
				// MathLang.g:66:14: declaration
				{
				DebugLocation(66, 14);
				PushFollow(Follow._declaration_in_statement483);
				declaration14=declaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, declaration14.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:67:4: assignment
				{
				DebugLocation(67, 4);
				PushFollow(Follow._assignment_in_statement489);
				assignment15=assignment();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment15.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:68:4: ifstatement
				{
				DebugLocation(68, 4);
				PushFollow(Follow._ifstatement_in_statement494);
				ifstatement16=ifstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ifstatement16.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:69:4: whilestatement
				{
				DebugLocation(69, 4);
				PushFollow(Follow._whilestatement_in_statement499);
				whilestatement17=whilestatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, whilestatement17.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:70:4: dowhilestatement
				{
				DebugLocation(70, 4);
				PushFollow(Follow._dowhilestatement_in_statement504);
				dowhilestatement18=dowhilestatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dowhilestatement18.Tree);

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// MathLang.g:71:4: forstatement
				{
				DebugLocation(71, 4);
				PushFollow(Follow._forstatement_in_statement509);
				forstatement19=forstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forstatement19.Tree);

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// MathLang.g:72:4: returnstatement
				{
				DebugLocation(72, 4);
				PushFollow(Follow._returnstatement_in_statement514);
				returnstatement20=returnstatement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, returnstatement20.Tree);

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// MathLang.g:73:4: funccall
				{
				DebugLocation(73, 4);
				PushFollow(Follow._funccall_in_statement519);
				funccall21=funccall();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccall21.Tree);

				}
				break;
			case 9:
				DebugEnterAlt(9);
				// MathLang.g:74:4: newexpression
				{
				DebugLocation(74, 4);
				PushFollow(Follow._newexpression_in_statement524);
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
		DebugLocation(76, 4);
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
	// MathLang.g:78:1: type : TYPE ;
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
		DebugLocation(78, 11);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 8)) { return retval; }
			// MathLang.g:78:5: ( TYPE )
			DebugEnterAlt(1);
			// MathLang.g:78:7: TYPE
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(78, 7);
			TYPE23=(IToken)Match(input,TYPE,Follow._TYPE_in_type538); if (state.failed) return retval;
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
		DebugLocation(78, 11);
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
	// MathLang.g:79:1: array_type : TYPE ARRAY_DECLARATION_MARK ;
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
		DebugLocation(79, 40);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 9)) { return retval; }
			// MathLang.g:79:11: ( TYPE ARRAY_DECLARATION_MARK )
			DebugEnterAlt(1);
			// MathLang.g:79:13: TYPE ARRAY_DECLARATION_MARK
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(79, 13);
			TYPE24=(IToken)Match(input,TYPE,Follow._TYPE_in_array_type545); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			TYPE24_tree = (object)adaptor.Create(TYPE24);
			adaptor.AddChild(root_0, TYPE24_tree);
			}
			DebugLocation(79, 40);
			ARRAY_DECLARATION_MARK25=(IToken)Match(input,ARRAY_DECLARATION_MARK,Follow._ARRAY_DECLARATION_MARK_in_array_type547); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(79, 40);
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
	// MathLang.g:80:1: any_type : ( type | array_type | VOID );
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
		DebugLocation(80, 34);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 10)) { return retval; }
			// MathLang.g:80:9: ( type | array_type | VOID )
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
				// MathLang.g:80:11: type
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(80, 11);
				PushFollow(Follow._type_in_any_type554);
				type26=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type26.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:80:18: array_type
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(80, 18);
				PushFollow(Follow._array_type_in_any_type558);
				array_type27=array_type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, array_type27.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:80:31: VOID
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(80, 31);
				VOID28=(IToken)Match(input,VOID,Follow._VOID_in_any_type562); if (state.failed) return retval;
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
		DebugLocation(80, 34);
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
	// MathLang.g:81:1: number : ( NUMBER | ID | funccallbody | CHAR | arrayelement );
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
		DebugLocation(81, 16);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 11)) { return retval; }
			// MathLang.g:81:8: ( NUMBER | ID | funccallbody | CHAR | arrayelement )
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
				case 67:
				case 68:
				case 69:
					{
					alt7=2;
					}
					break;
				case DOT:
				case OPEN_BRACE:
					{
					alt7=3;
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
				// MathLang.g:81:11: NUMBER
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(81, 11);
				NUMBER29=(IToken)Match(input,NUMBER,Follow._NUMBER_in_number570); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				NUMBER29_tree = (object)adaptor.Create(NUMBER29);
				adaptor.AddChild(root_0, NUMBER29_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:82:5: ID
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(82, 5);
				ID30=(IToken)Match(input,ID,Follow._ID_in_number576); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				ID30_tree = (object)adaptor.Create(ID30);
				adaptor.AddChild(root_0, ID30_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:83:5: funccallbody
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(83, 5);
				PushFollow(Follow._funccallbody_in_number582);
				funccallbody31=funccallbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody31.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:84:5: CHAR
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(84, 5);
				CHAR32=(IToken)Match(input,CHAR,Follow._CHAR_in_number588); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				CHAR32_tree = (object)adaptor.Create(CHAR32);
				adaptor.AddChild(root_0, CHAR32_tree);
				}

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:85:5: arrayelement
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(85, 5);
				PushFollow(Follow._arrayelement_in_number594);
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
		DebugLocation(85, 16);
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
	// MathLang.g:86:1: mathexpression : term ;
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
		DebugLocation(86, 21);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 12)) { return retval; }
			// MathLang.g:86:15: ( term )
			DebugEnterAlt(1);
			// MathLang.g:86:17: term
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(86, 17);
			PushFollow(Follow._term_in_mathexpression600);
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
		DebugLocation(86, 21);
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
	// MathLang.g:88:1: expression : ( newexpression | funccallbody | boolexpression | mathexpression );
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
		DebugLocation(88, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 13)) { return retval; }
			// MathLang.g:88:11: ( newexpression | funccallbody | boolexpression | mathexpression )
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
				// MathLang.g:89:5: newexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(89, 5);
				PushFollow(Follow._newexpression_in_expression614);
				newexpression35=newexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, newexpression35.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:90:5: funccallbody
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(90, 5);
				PushFollow(Follow._funccallbody_in_expression620);
				funccallbody36=funccallbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody36.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:91:5: boolexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(91, 5);
				PushFollow(Follow._boolexpression_in_expression626);
				boolexpression37=boolexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression37.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:92:5: mathexpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(92, 5);
				PushFollow(Follow._mathexpression_in_expression632);
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
		DebugLocation(95, 0);
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
	// MathLang.g:96:1: extended_id : id ( DOT extended_id )* -> ^( id ( extended_id )* ) ;
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

		IToken DOT40=null;
		MathLangParser.id_return id39 = default(MathLangParser.id_return);
		MathLangParser.extended_id_return extended_id41 = default(MathLangParser.extended_id_return);

		object DOT40_tree=null;
		RewriteRuleITokenStream stream_DOT=new RewriteRuleITokenStream(adaptor,"token DOT");
		RewriteRuleSubtreeStream stream_extended_id=new RewriteRuleSubtreeStream(adaptor,"rule extended_id");
		RewriteRuleSubtreeStream stream_id=new RewriteRuleSubtreeStream(adaptor,"rule id");
		try { DebugEnterRule(GrammarFileName, "extended_id");
		DebugLocation(96, 57);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 14)) { return retval; }
			// MathLang.g:96:12: ( id ( DOT extended_id )* -> ^( id ( extended_id )* ) )
			DebugEnterAlt(1);
			// MathLang.g:96:14: id ( DOT extended_id )*
			{
			DebugLocation(96, 14);
			PushFollow(Follow._id_in_extended_id645);
			id39=id();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_id.Add(id39.Tree);
			DebugLocation(96, 17);
			// MathLang.g:96:17: ( DOT extended_id )*
			try { DebugEnterSubRule(9);
			while (true)
			{
				int alt9=2;
				try { DebugEnterDecision(9, decisionCanBacktrack[9]);
				int LA9_0 = input.LA(1);

				if ((LA9_0==DOT))
				{
					int LA9_1 = input.LA(2);

					if ((EvaluatePredicate(synpred22_MathLang_fragment)))
					{
						alt9=1;
					}


				}


				} finally { DebugExitDecision(9); }
				switch ( alt9 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:96:18: DOT extended_id
					{
					DebugLocation(96, 21);
					DOT40=(IToken)Match(input,DOT,Follow._DOT_in_extended_id648); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_DOT.Add(DOT40);

					DebugLocation(96, 23);
					PushFollow(Follow._extended_id_in_extended_id651);
					extended_id41=extended_id();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_extended_id.Add(extended_id41.Tree);

					}
					break;

				default:
					goto loop9;
				}
			}

			loop9:
				;

			} finally { DebugExitSubRule(9); }



			{
			// AST REWRITE
			// elements: extended_id, id
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 96:37: -> ^( id ( extended_id )* )
			{
				DebugLocation(96, 40);
				// MathLang.g:96:40: ^( id ( extended_id )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(96, 42);
				root_1 = (object)adaptor.BecomeRoot(stream_id.NextNode(), root_1);

				DebugLocation(96, 45);
				// MathLang.g:96:45: ( extended_id )*
				while ( stream_extended_id.HasNext )
				{
					DebugLocation(96, 45);
					adaptor.AddChild(root_1, stream_extended_id.NextTree());

				}
				stream_extended_id.Reset();

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
		DebugLocation(96, 57);
		} finally { DebugExitRule(GrammarFileName, "extended_id"); }
		return retval;

	}
	// $ANTLR end "extended_id"

	public class id_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_id();
	partial void Leave_id();

	// $ANTLR start "id"
	// MathLang.g:98:1: id : ID ;
	[GrammarRule("id")]
	private MathLangParser.id_return id()
	{
		Enter_id();
		EnterRule("id", 15);
		TraceIn("id", 15);
		MathLangParser.id_return retval = new MathLangParser.id_return();
		retval.Start = (IToken)input.LT(1);
		int id_StartIndex = input.Index;
		object root_0 = null;

		IToken ID42=null;

		object ID42_tree=null;

		try { DebugEnterRule(GrammarFileName, "id");
		DebugLocation(98, 6);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 15)) { return retval; }
			// MathLang.g:98:3: ( ID )
			DebugEnterAlt(1);
			// MathLang.g:98:5: ID
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(98, 5);
			ID42=(IToken)Match(input,ID,Follow._ID_in_id669); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			ID42_tree = (object)adaptor.Create(ID42);
			adaptor.AddChild(root_0, ID42_tree);
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
			TraceOut("id", 15);
			LeaveRule("id", 15);
			Leave_id();
			if (state.backtracking > 0) { Memoize(input, 15, id_StartIndex); }
		}
		DebugLocation(98, 6);
		} finally { DebugExitRule(GrammarFileName, "id"); }
		return retval;

	}
	// $ANTLR end "id"

	public class arrayelement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_arrayelement();
	partial void Leave_arrayelement();

	// $ANTLR start "arrayelement"
	// MathLang.g:100:1: arrayelement : ID '[' number ']' -> ^( ARRAYELEMENT ID number ) ;
	[GrammarRule("arrayelement")]
	private MathLangParser.arrayelement_return arrayelement()
	{
		Enter_arrayelement();
		EnterRule("arrayelement", 16);
		TraceIn("arrayelement", 16);
		MathLangParser.arrayelement_return retval = new MathLangParser.arrayelement_return();
		retval.Start = (IToken)input.LT(1);
		int arrayelement_StartIndex = input.Index;
		object root_0 = null;

		IToken ID43=null;
		IToken char_literal44=null;
		IToken char_literal46=null;
		MathLangParser.number_return number45 = default(MathLangParser.number_return);

		object ID43_tree=null;
		object char_literal44_tree=null;
		object char_literal46_tree=null;
		RewriteRuleITokenStream stream_OPEN_SQUARE_BRACE=new RewriteRuleITokenStream(adaptor,"token OPEN_SQUARE_BRACE");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_CLOSE_SQUARE_BRACE=new RewriteRuleITokenStream(adaptor,"token CLOSE_SQUARE_BRACE");
		RewriteRuleSubtreeStream stream_number=new RewriteRuleSubtreeStream(adaptor,"rule number");
		try { DebugEnterRule(GrammarFileName, "arrayelement");
		DebugLocation(100, 62);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 16)) { return retval; }
			// MathLang.g:100:13: ( ID '[' number ']' -> ^( ARRAYELEMENT ID number ) )
			DebugEnterAlt(1);
			// MathLang.g:100:16: ID '[' number ']'
			{
			DebugLocation(100, 16);
			ID43=(IToken)Match(input,ID,Follow._ID_in_arrayelement677); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID43);

			DebugLocation(100, 19);
			char_literal44=(IToken)Match(input,OPEN_SQUARE_BRACE,Follow._OPEN_SQUARE_BRACE_in_arrayelement679); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OPEN_SQUARE_BRACE.Add(char_literal44);

			DebugLocation(100, 23);
			PushFollow(Follow._number_in_arrayelement681);
			number45=number();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_number.Add(number45.Tree);
			DebugLocation(100, 30);
			char_literal46=(IToken)Match(input,CLOSE_SQUARE_BRACE,Follow._CLOSE_SQUARE_BRACE_in_arrayelement683); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CLOSE_SQUARE_BRACE.Add(char_literal46);



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
			// 100:34: -> ^( ARRAYELEMENT ID number )
			{
				DebugLocation(100, 37);
				// MathLang.g:100:37: ^( ARRAYELEMENT ID number )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(100, 39);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYELEMENT, "ARRAYELEMENT"), root_1);

				DebugLocation(100, 52);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(100, 55);
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
			TraceOut("arrayelement", 16);
			LeaveRule("arrayelement", 16);
			Leave_arrayelement();
			if (state.backtracking > 0) { Memoize(input, 16, arrayelement_StartIndex); }
		}
		DebugLocation(100, 62);
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
		EnterRule("static_declaration", 17);
		TraceIn("static_declaration", 17);
		MathLangParser.static_declaration_return retval = new MathLangParser.static_declaration_return();
		retval.Start = (IToken)input.LT(1);
		int static_declaration_StartIndex = input.Index;
		object root_0 = null;

		IToken MODIFIER47=null;
		MathLangParser.declaration_return declaration48 = default(MathLangParser.declaration_return);

		object MODIFIER47_tree=null;
		RewriteRuleITokenStream stream_MODIFIER=new RewriteRuleITokenStream(adaptor,"token MODIFIER");
		RewriteRuleSubtreeStream stream_declaration=new RewriteRuleSubtreeStream(adaptor,"rule declaration");
		try { DebugEnterRule(GrammarFileName, "static_declaration");
		DebugLocation(101, 78);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 17)) { return retval; }
			// MathLang.g:101:19: ( MODIFIER declaration -> ^( STATIC_DECLARATION declaration ) )
			DebugEnterAlt(1);
			// MathLang.g:101:22: MODIFIER declaration
			{
			DebugLocation(101, 22);
			MODIFIER47=(IToken)Match(input,MODIFIER,Follow._MODIFIER_in_static_declaration701); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_MODIFIER.Add(MODIFIER47);

			DebugLocation(101, 31);
			PushFollow(Follow._declaration_in_static_declaration703);
			declaration48=declaration();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declaration.Add(declaration48.Tree);


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
			TraceOut("static_declaration", 17);
			LeaveRule("static_declaration", 17);
			Leave_static_declaration();
			if (state.backtracking > 0) { Memoize(input, 17, static_declaration_StartIndex); }
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
	// MathLang.g:102:1: declaration : ( declarationbody ';' | longdeclaration );
	[GrammarRule("declaration")]
	private MathLangParser.declaration_return declaration()
	{
		Enter_declaration();
		EnterRule("declaration", 18);
		TraceIn("declaration", 18);
		MathLangParser.declaration_return retval = new MathLangParser.declaration_return();
		retval.Start = (IToken)input.LT(1);
		int declaration_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal50=null;
		MathLangParser.declarationbody_return declarationbody49 = default(MathLangParser.declarationbody_return);
		MathLangParser.longdeclaration_return longdeclaration51 = default(MathLangParser.longdeclaration_return);

		object char_literal50_tree=null;

		try { DebugEnterRule(GrammarFileName, "declaration");
		DebugLocation(102, 20);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 18)) { return retval; }
			// MathLang.g:102:12: ( declarationbody ';' | longdeclaration )
			int alt10=2;
			try { DebugEnterDecision(10, decisionCanBacktrack[10]);
			int LA10_0 = input.LA(1);

			if ((LA10_0==TYPE))
			{
				int LA10_1 = input.LA(2);

				if ((LA10_1==ARRAY_DECLARATION_MARK))
				{
					int LA10_2 = input.LA(3);

					if ((LA10_2==ID))
					{
						int LA10_4 = input.LA(4);

						if ((LA10_4==ASSIGN))
						{
							alt10=2;
						}
						else if ((LA10_4==68))
						{
							alt10=1;
						}
						else
						{
							if (state.backtracking>0) {state.failed=true; return retval;}
							NoViableAltException nvae = new NoViableAltException("", 10, 4, input);

							DebugRecognitionException(nvae);
							throw nvae;
						}
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 10, 2, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}
				else if ((LA10_1==ID))
				{
					int LA10_3 = input.LA(3);

					if ((LA10_3==ASSIGN))
					{
						alt10=2;
					}
					else if ((LA10_3==68))
					{
						alt10=1;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 10, 3, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
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
				// MathLang.g:102:14: declarationbody ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(102, 14);
				PushFollow(Follow._declarationbody_in_declaration717);
				declarationbody49=declarationbody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, declarationbody49.Tree);
				DebugLocation(102, 33);
				char_literal50=(IToken)Match(input,68,Follow._68_in_declaration719); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:103:6: longdeclaration
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(103, 6);
				PushFollow(Follow._longdeclaration_in_declaration727);
				longdeclaration51=longdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclaration51.Tree);

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
			TraceOut("declaration", 18);
			LeaveRule("declaration", 18);
			Leave_declaration();
			if (state.backtracking > 0) { Memoize(input, 18, declaration_StartIndex); }
		}
		DebugLocation(103, 20);
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
	// MathLang.g:105:1: declarationbody : ( ( type ID -> ^( VARDECLARATION type ID ) ) | ( array_type ID -> ^( ARRAYDECLARATION array_type ID ) ) );
	[GrammarRule("declarationbody")]
	private MathLangParser.declarationbody_return declarationbody()
	{
		Enter_declarationbody();
		EnterRule("declarationbody", 19);
		TraceIn("declarationbody", 19);
		MathLangParser.declarationbody_return retval = new MathLangParser.declarationbody_return();
		retval.Start = (IToken)input.LT(1);
		int declarationbody_StartIndex = input.Index;
		object root_0 = null;

		IToken ID53=null;
		IToken ID55=null;
		MathLangParser.type_return type52 = default(MathLangParser.type_return);
		MathLangParser.array_type_return array_type54 = default(MathLangParser.array_type_return);

		object ID53_tree=null;
		object ID55_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleSubtreeStream stream_array_type=new RewriteRuleSubtreeStream(adaptor,"rule array_type");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "declarationbody");
		DebugLocation(105, 4);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 19)) { return retval; }
			// MathLang.g:105:16: ( ( type ID -> ^( VARDECLARATION type ID ) ) | ( array_type ID -> ^( ARRAYDECLARATION array_type ID ) ) )
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
				// MathLang.g:105:18: ( type ID -> ^( VARDECLARATION type ID ) )
				{
				DebugLocation(105, 18);
				// MathLang.g:105:18: ( type ID -> ^( VARDECLARATION type ID ) )
				DebugEnterAlt(1);
				// MathLang.g:105:19: type ID
				{
				DebugLocation(105, 19);
				PushFollow(Follow._type_in_declarationbody735);
				type52=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type52.Tree);
				DebugLocation(105, 24);
				ID53=(IToken)Match(input,ID,Follow._ID_in_declarationbody737); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID53);



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
				// 105:27: -> ^( VARDECLARATION type ID )
				{
					DebugLocation(105, 30);
					// MathLang.g:105:30: ^( VARDECLARATION type ID )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(105, 32);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDECLARATION, "VARDECLARATION"), root_1);

					DebugLocation(105, 47);
					adaptor.AddChild(root_1, stream_type.NextTree());
					DebugLocation(105, 52);
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
				// MathLang.g:106:7: ( array_type ID -> ^( ARRAYDECLARATION array_type ID ) )
				{
				DebugLocation(106, 7);
				// MathLang.g:106:7: ( array_type ID -> ^( ARRAYDECLARATION array_type ID ) )
				DebugEnterAlt(1);
				// MathLang.g:106:8: array_type ID
				{
				DebugLocation(106, 8);
				PushFollow(Follow._array_type_in_declarationbody758);
				array_type54=array_type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_array_type.Add(array_type54.Tree);
				DebugLocation(106, 19);
				ID55=(IToken)Match(input,ID,Follow._ID_in_declarationbody760); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID55);



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
				// 106:22: -> ^( ARRAYDECLARATION array_type ID )
				{
					DebugLocation(106, 25);
					// MathLang.g:106:25: ^( ARRAYDECLARATION array_type ID )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(106, 27);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYDECLARATION, "ARRAYDECLARATION"), root_1);

					DebugLocation(106, 44);
					adaptor.AddChild(root_1, stream_array_type.NextTree());
					DebugLocation(106, 55);
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
			TraceOut("declarationbody", 19);
			LeaveRule("declarationbody", 19);
			Leave_declarationbody();
			if (state.backtracking > 0) { Memoize(input, 19, declarationbody_StartIndex); }
		}
		DebugLocation(107, 4);
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
	// MathLang.g:108:1: longdeclaration : longdeclarationbody ';' ;
	[GrammarRule("longdeclaration")]
	private MathLangParser.longdeclaration_return longdeclaration()
	{
		Enter_longdeclaration();
		EnterRule("longdeclaration", 20);
		TraceIn("longdeclaration", 20);
		MathLangParser.longdeclaration_return retval = new MathLangParser.longdeclaration_return();
		retval.Start = (IToken)input.LT(1);
		int longdeclaration_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal57=null;
		MathLangParser.longdeclarationbody_return longdeclarationbody56 = default(MathLangParser.longdeclarationbody_return);

		object char_literal57_tree=null;

		try { DebugEnterRule(GrammarFileName, "longdeclaration");
		DebugLocation(108, 42);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 20)) { return retval; }
			// MathLang.g:108:16: ( longdeclarationbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:108:18: longdeclarationbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(108, 18);
			PushFollow(Follow._longdeclarationbody_in_longdeclaration782);
			longdeclarationbody56=longdeclarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclarationbody56.Tree);
			DebugLocation(108, 41);
			char_literal57=(IToken)Match(input,68,Follow._68_in_longdeclaration784); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("longdeclaration", 20);
			LeaveRule("longdeclaration", 20);
			Leave_longdeclaration();
			if (state.backtracking > 0) { Memoize(input, 20, longdeclaration_StartIndex); }
		}
		DebugLocation(108, 42);
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
	// MathLang.g:109:1: longdeclarationbody : ( ( type ID ASSIGN expression -> ^( VARDECLARATION type ID expression ) ) | ( array_type ID ASSIGN newexpression -> ^( ARRAYDECLARATION array_type ID newexpression ) ) );
	[GrammarRule("longdeclarationbody")]
	private MathLangParser.longdeclarationbody_return longdeclarationbody()
	{
		Enter_longdeclarationbody();
		EnterRule("longdeclarationbody", 21);
		TraceIn("longdeclarationbody", 21);
		MathLangParser.longdeclarationbody_return retval = new MathLangParser.longdeclarationbody_return();
		retval.Start = (IToken)input.LT(1);
		int longdeclarationbody_StartIndex = input.Index;
		object root_0 = null;

		IToken ID59=null;
		IToken ASSIGN60=null;
		IToken ID63=null;
		IToken ASSIGN64=null;
		MathLangParser.type_return type58 = default(MathLangParser.type_return);
		MathLangParser.expression_return expression61 = default(MathLangParser.expression_return);
		MathLangParser.array_type_return array_type62 = default(MathLangParser.array_type_return);
		MathLangParser.newexpression_return newexpression65 = default(MathLangParser.newexpression_return);

		object ID59_tree=null;
		object ASSIGN60_tree=null;
		object ID63_tree=null;
		object ASSIGN64_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_newexpression=new RewriteRuleSubtreeStream(adaptor,"rule newexpression");
		RewriteRuleSubtreeStream stream_array_type=new RewriteRuleSubtreeStream(adaptor,"rule array_type");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "longdeclarationbody");
		DebugLocation(109, 94);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 21)) { return retval; }
			// MathLang.g:109:20: ( ( type ID ASSIGN expression -> ^( VARDECLARATION type ID expression ) ) | ( array_type ID ASSIGN newexpression -> ^( ARRAYDECLARATION array_type ID newexpression ) ) )
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
				// MathLang.g:109:22: ( type ID ASSIGN expression -> ^( VARDECLARATION type ID expression ) )
				{
				DebugLocation(109, 22);
				// MathLang.g:109:22: ( type ID ASSIGN expression -> ^( VARDECLARATION type ID expression ) )
				DebugEnterAlt(1);
				// MathLang.g:109:23: type ID ASSIGN expression
				{
				DebugLocation(109, 23);
				PushFollow(Follow._type_in_longdeclarationbody793);
				type58=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type58.Tree);
				DebugLocation(109, 28);
				ID59=(IToken)Match(input,ID,Follow._ID_in_longdeclarationbody795); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID59);

				DebugLocation(109, 31);
				ASSIGN60=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclarationbody797); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN60);

				DebugLocation(109, 38);
				PushFollow(Follow._expression_in_longdeclarationbody799);
				expression61=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression61.Tree);


				{
				// AST REWRITE
				// elements: ID, expression, type
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 109:50: -> ^( VARDECLARATION type ID expression )
				{
					DebugLocation(109, 53);
					// MathLang.g:109:53: ^( VARDECLARATION type ID expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(109, 55);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDECLARATION, "VARDECLARATION"), root_1);

					DebugLocation(109, 70);
					adaptor.AddChild(root_1, stream_type.NextTree());
					DebugLocation(109, 75);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(109, 78);
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
				// MathLang.g:110:8: ( array_type ID ASSIGN newexpression -> ^( ARRAYDECLARATION array_type ID newexpression ) )
				{
				DebugLocation(110, 8);
				// MathLang.g:110:8: ( array_type ID ASSIGN newexpression -> ^( ARRAYDECLARATION array_type ID newexpression ) )
				DebugEnterAlt(1);
				// MathLang.g:110:9: array_type ID ASSIGN newexpression
				{
				DebugLocation(110, 9);
				PushFollow(Follow._array_type_in_longdeclarationbody823);
				array_type62=array_type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_array_type.Add(array_type62.Tree);
				DebugLocation(110, 20);
				ID63=(IToken)Match(input,ID,Follow._ID_in_longdeclarationbody825); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID63);

				DebugLocation(110, 23);
				ASSIGN64=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_longdeclarationbody827); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN64);

				DebugLocation(110, 30);
				PushFollow(Follow._newexpression_in_longdeclarationbody829);
				newexpression65=newexpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_newexpression.Add(newexpression65.Tree);


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
				// 110:44: -> ^( ARRAYDECLARATION array_type ID newexpression )
				{
					DebugLocation(110, 47);
					// MathLang.g:110:47: ^( ARRAYDECLARATION array_type ID newexpression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(110, 49);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYDECLARATION, "ARRAYDECLARATION"), root_1);

					DebugLocation(110, 66);
					adaptor.AddChild(root_1, stream_array_type.NextTree());
					DebugLocation(110, 77);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(110, 80);
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
			TraceOut("longdeclarationbody", 21);
			LeaveRule("longdeclarationbody", 21);
			Leave_longdeclarationbody();
			if (state.backtracking > 0) { Memoize(input, 21, longdeclarationbody_StartIndex); }
		}
		DebugLocation(110, 94);
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
	// MathLang.g:112:1: add : mul ( ( ADD | SUB ) mul )* ;
	[GrammarRule("add")]
	private MathLangParser.add_return add()
	{
		Enter_add();
		EnterRule("add", 22);
		TraceIn("add", 22);
		MathLangParser.add_return retval = new MathLangParser.add_return();
		retval.Start = (IToken)input.LT(1);
		int add_StartIndex = input.Index;
		object root_0 = null;

		IToken set67=null;
		MathLangParser.mul_return mul66 = default(MathLangParser.mul_return);
		MathLangParser.mul_return mul68 = default(MathLangParser.mul_return);

		object set67_tree=null;

		try { DebugEnterRule(GrammarFileName, "add");
		DebugLocation(112, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 22)) { return retval; }
			// MathLang.g:112:4: ( mul ( ( ADD | SUB ) mul )* )
			DebugEnterAlt(1);
			// MathLang.g:112:6: mul ( ( ADD | SUB ) mul )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(112, 6);
			PushFollow(Follow._mul_in_add849);
			mul66=mul();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul66.Tree);
			DebugLocation(112, 10);
			// MathLang.g:112:10: ( ( ADD | SUB ) mul )*
			try { DebugEnterSubRule(13);
			while (true)
			{
				int alt13=2;
				try { DebugEnterDecision(13, decisionCanBacktrack[13]);
				int LA13_0 = input.LA(1);

				if (((LA13_0>=ADD && LA13_0<=SUB)))
				{
					alt13=1;
				}


				} finally { DebugExitDecision(13); }
				switch ( alt13 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:112:12: ( ADD | SUB ) mul
					{
					DebugLocation(112, 12);
					set67=(IToken)input.LT(1);
					set67=(IToken)input.LT(1);
					if ((input.LA(1)>=ADD && input.LA(1)<=SUB))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set67), root_0);
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(112, 25);
					PushFollow(Follow._mul_in_add862);
					mul68=mul();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mul68.Tree);

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
			TraceOut("add", 22);
			LeaveRule("add", 22);
			Leave_add();
			if (state.backtracking > 0) { Memoize(input, 22, add_StartIndex); }
		}
		DebugLocation(112, 30);
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
	// MathLang.g:113:1: mul : group ( ( MUL | DIV ) group )* ;
	[GrammarRule("mul")]
	private MathLangParser.mul_return mul()
	{
		Enter_mul();
		EnterRule("mul", 23);
		TraceIn("mul", 23);
		MathLangParser.mul_return retval = new MathLangParser.mul_return();
		retval.Start = (IToken)input.LT(1);
		int mul_StartIndex = input.Index;
		object root_0 = null;

		IToken set70=null;
		MathLangParser.group_return group69 = default(MathLangParser.group_return);
		MathLangParser.group_return group71 = default(MathLangParser.group_return);

		object set70_tree=null;

		try { DebugEnterRule(GrammarFileName, "mul");
		DebugLocation(113, 33);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 23)) { return retval; }
			// MathLang.g:113:4: ( group ( ( MUL | DIV ) group )* )
			DebugEnterAlt(1);
			// MathLang.g:113:6: group ( ( MUL | DIV ) group )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(113, 6);
			PushFollow(Follow._group_in_mul871);
			group69=group();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group69.Tree);
			DebugLocation(113, 12);
			// MathLang.g:113:12: ( ( MUL | DIV ) group )*
			try { DebugEnterSubRule(14);
			while (true)
			{
				int alt14=2;
				try { DebugEnterDecision(14, decisionCanBacktrack[14]);
				int LA14_0 = input.LA(1);

				if (((LA14_0>=MUL && LA14_0<=DIV)))
				{
					alt14=1;
				}


				} finally { DebugExitDecision(14); }
				switch ( alt14 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:113:14: ( MUL | DIV ) group
					{
					DebugLocation(113, 14);
					set70=(IToken)input.LT(1);
					set70=(IToken)input.LT(1);
					if ((input.LA(1)>=MUL && input.LA(1)<=DIV))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set70), root_0);
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(113, 27);
					PushFollow(Follow._group_in_mul884);
					group71=group();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group71.Tree);

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
			TraceOut("mul", 23);
			LeaveRule("mul", 23);
			Leave_mul();
			if (state.backtracking > 0) { Memoize(input, 23, mul_StartIndex); }
		}
		DebugLocation(113, 33);
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
	// MathLang.g:114:1: compare : add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )? ;
	[GrammarRule("compare")]
	private MathLangParser.compare_return compare()
	{
		Enter_compare();
		EnterRule("compare", 24);
		TraceIn("compare", 24);
		MathLangParser.compare_return retval = new MathLangParser.compare_return();
		retval.Start = (IToken)input.LT(1);
		int compare_StartIndex = input.Index;
		object root_0 = null;

		IToken set73=null;
		MathLangParser.add_return add72 = default(MathLangParser.add_return);
		MathLangParser.add_return add74 = default(MathLangParser.add_return);

		object set73_tree=null;

		try { DebugEnterRule(GrammarFileName, "compare");
		DebugLocation(114, 60);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 24)) { return retval; }
			// MathLang.g:114:8: ( add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )? )
			DebugEnterAlt(1);
			// MathLang.g:114:10: add ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(114, 10);
			PushFollow(Follow._add_in_compare892);
			add72=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add72.Tree);
			DebugLocation(114, 14);
			// MathLang.g:114:14: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?
			int alt15=2;
			try { DebugEnterSubRule(15);
			try { DebugEnterDecision(15, decisionCanBacktrack[15]);
			try
			{
				alt15 = dfa15.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(15); }
			switch (alt15)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:114:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
				{
				DebugLocation(114, 16);
				set73=(IToken)input.LT(1);
				set73=(IToken)input.LT(1);
				if ((input.LA(1)>=GREQ && input.LA(1)<=LS))
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

				DebugLocation(114, 53);
				PushFollow(Follow._add_in_compare922);
				add74=add();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add74.Tree);

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
			TraceOut("compare", 24);
			LeaveRule("compare", 24);
			Leave_compare();
			if (state.backtracking > 0) { Memoize(input, 24, compare_StartIndex); }
		}
		DebugLocation(114, 60);
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
	// MathLang.g:115:1: term : add ;
	[GrammarRule("term")]
	private MathLangParser.term_return term()
	{
		Enter_term();
		EnterRule("term", 25);
		TraceIn("term", 25);
		MathLangParser.term_return retval = new MathLangParser.term_return();
		retval.Start = (IToken)input.LT(1);
		int term_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.add_return add75 = default(MathLangParser.add_return);


		try { DebugEnterRule(GrammarFileName, "term");
		DebugLocation(115, 9);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 25)) { return retval; }
			// MathLang.g:115:5: ( add )
			DebugEnterAlt(1);
			// MathLang.g:115:7: add
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(115, 7);
			PushFollow(Follow._add_in_term933);
			add75=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add75.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("term", 25);
			LeaveRule("term", 25);
			Leave_term();
			if (state.backtracking > 0) { Memoize(input, 25, term_StartIndex); }
		}
		DebugLocation(115, 9);
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
	// MathLang.g:116:1: group : ( ( SUB )? OPEN_BRACE term CLOSE_BRACE | number );
	[GrammarRule("group")]
	private MathLangParser.group_return group()
	{
		Enter_group();
		EnterRule("group", 26);
		TraceIn("group", 26);
		MathLangParser.group_return retval = new MathLangParser.group_return();
		retval.Start = (IToken)input.LT(1);
		int group_StartIndex = input.Index;
		object root_0 = null;

		IToken SUB76=null;
		IToken OPEN_BRACE77=null;
		IToken CLOSE_BRACE79=null;
		MathLangParser.term_return term78 = default(MathLangParser.term_return);
		MathLangParser.number_return number80 = default(MathLangParser.number_return);

		object SUB76_tree=null;
		object OPEN_BRACE77_tree=null;
		object CLOSE_BRACE79_tree=null;

		try { DebugEnterRule(GrammarFileName, "group");
		DebugLocation(116, 53);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 26)) { return retval; }
			// MathLang.g:116:6: ( ( SUB )? OPEN_BRACE term CLOSE_BRACE | number )
			int alt17=2;
			try { DebugEnterDecision(17, decisionCanBacktrack[17]);
			int LA17_0 = input.LA(1);

			if ((LA17_0==SUB||LA17_0==OPEN_BRACE))
			{
				alt17=1;
			}
			else if ((LA17_0==ID||(LA17_0>=NUMBER && LA17_0<=CHAR)))
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
				// MathLang.g:116:8: ( SUB )? OPEN_BRACE term CLOSE_BRACE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(116, 8);
				// MathLang.g:116:8: ( SUB )?
				int alt16=2;
				try { DebugEnterSubRule(16);
				try { DebugEnterDecision(16, decisionCanBacktrack[16]);
				int LA16_0 = input.LA(1);

				if ((LA16_0==SUB))
				{
					alt16=1;
				}
				} finally { DebugExitDecision(16); }
				switch (alt16)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:116:9: SUB
					{
					DebugLocation(116, 12);
					SUB76=(IToken)Match(input,SUB,Follow._SUB_in_group940); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					SUB76_tree = (object)adaptor.Create(SUB76);
					root_0 = (object)adaptor.BecomeRoot(SUB76_tree, root_0);
					}

					}
					break;

				}
				} finally { DebugExitSubRule(16); }

				DebugLocation(116, 26);
				OPEN_BRACE77=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_group945); if (state.failed) return retval;
				DebugLocation(116, 28);
				PushFollow(Follow._term_in_group948);
				term78=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term78.Tree);
				DebugLocation(116, 44);
				CLOSE_BRACE79=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_group950); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:116:48: number
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(116, 48);
				PushFollow(Follow._number_in_group955);
				number80=number();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, number80.Tree);

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
			TraceOut("group", 26);
			LeaveRule("group", 26);
			Leave_group();
			if (state.backtracking > 0) { Memoize(input, 26, group_StartIndex); }
		}
		DebugLocation(116, 53);
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
	// MathLang.g:118:1: assignment : assignmentbody ';' ;
	[GrammarRule("assignment")]
	private MathLangParser.assignment_return assignment()
	{
		Enter_assignment();
		EnterRule("assignment", 27);
		TraceIn("assignment", 27);
		MathLangParser.assignment_return retval = new MathLangParser.assignment_return();
		retval.Start = (IToken)input.LT(1);
		int assignment_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal82=null;
		MathLangParser.assignmentbody_return assignmentbody81 = default(MathLangParser.assignmentbody_return);

		object char_literal82_tree=null;

		try { DebugEnterRule(GrammarFileName, "assignment");
		DebugLocation(118, 31);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 27)) { return retval; }
			// MathLang.g:118:11: ( assignmentbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:118:13: assignmentbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(118, 13);
			PushFollow(Follow._assignmentbody_in_assignment962);
			assignmentbody81=assignmentbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentbody81.Tree);
			DebugLocation(118, 31);
			char_literal82=(IToken)Match(input,68,Follow._68_in_assignment964); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("assignment", 27);
			LeaveRule("assignment", 27);
			Leave_assignment();
			if (state.backtracking > 0) { Memoize(input, 27, assignment_StartIndex); }
		}
		DebugLocation(118, 31);
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
	// MathLang.g:119:1: assignmentbody : ( ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) ) | ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) ) );
	[GrammarRule("assignmentbody")]
	private MathLangParser.assignmentbody_return assignmentbody()
	{
		Enter_assignmentbody();
		EnterRule("assignmentbody", 28);
		TraceIn("assignmentbody", 28);
		MathLangParser.assignmentbody_return retval = new MathLangParser.assignmentbody_return();
		retval.Start = (IToken)input.LT(1);
		int assignmentbody_StartIndex = input.Index;
		object root_0 = null;

		IToken ID83=null;
		IToken ASSIGN84=null;
		IToken ASSIGN87=null;
		MathLangParser.expression_return expression85 = default(MathLangParser.expression_return);
		MathLangParser.arrayelement_return arrayelement86 = default(MathLangParser.arrayelement_return);
		MathLangParser.expression_return expression88 = default(MathLangParser.expression_return);

		object ID83_tree=null;
		object ASSIGN84_tree=null;
		object ASSIGN87_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_arrayelement=new RewriteRuleSubtreeStream(adaptor,"rule arrayelement");
		try { DebugEnterRule(GrammarFileName, "assignmentbody");
		DebugLocation(119, 87);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 28)) { return retval; }
			// MathLang.g:119:15: ( ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) ) | ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) ) )
			int alt18=2;
			try { DebugEnterDecision(18, decisionCanBacktrack[18]);
			int LA18_0 = input.LA(1);

			if ((LA18_0==ID))
			{
				int LA18_1 = input.LA(2);

				if ((LA18_1==ASSIGN))
				{
					alt18=1;
				}
				else if ((LA18_1==OPEN_SQUARE_BRACE))
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
				// MathLang.g:119:17: ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) )
				{
				DebugLocation(119, 17);
				// MathLang.g:119:17: ( ID ASSIGN expression -> ^( VARASSIGNMENT ID expression ) )
				DebugEnterAlt(1);
				// MathLang.g:119:18: ID ASSIGN expression
				{
				DebugLocation(119, 18);
				ID83=(IToken)Match(input,ID,Follow._ID_in_assignmentbody972); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID83);

				DebugLocation(119, 21);
				ASSIGN84=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignmentbody974); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN84);

				DebugLocation(119, 28);
				PushFollow(Follow._expression_in_assignmentbody976);
				expression85=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression85.Tree);


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
				// 119:39: -> ^( VARASSIGNMENT ID expression )
				{
					DebugLocation(119, 42);
					// MathLang.g:119:42: ^( VARASSIGNMENT ID expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(119, 44);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARASSIGNMENT, "VARASSIGNMENT"), root_1);

					DebugLocation(119, 58);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(119, 61);
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
				// MathLang.g:120:2: ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) )
				{
				DebugLocation(120, 2);
				// MathLang.g:120:2: ( arrayelement ASSIGN expression -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression ) )
				DebugEnterAlt(1);
				// MathLang.g:120:4: arrayelement ASSIGN expression
				{
				DebugLocation(120, 4);
				PushFollow(Follow._arrayelement_in_assignmentbody995);
				arrayelement86=arrayelement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_arrayelement.Add(arrayelement86.Tree);
				DebugLocation(120, 17);
				ASSIGN87=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignmentbody997); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN87);

				DebugLocation(120, 24);
				PushFollow(Follow._expression_in_assignmentbody999);
				expression88=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression88.Tree);


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
				// 120:35: -> ^( ARRAYELEMENTASSIGNMENT arrayelement expression )
				{
					DebugLocation(120, 38);
					// MathLang.g:120:38: ^( ARRAYELEMENTASSIGNMENT arrayelement expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(120, 40);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAYELEMENTASSIGNMENT, "ARRAYELEMENTASSIGNMENT"), root_1);

					DebugLocation(120, 63);
					adaptor.AddChild(root_1, stream_arrayelement.NextTree());
					DebugLocation(120, 76);
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
			TraceOut("assignmentbody", 28);
			LeaveRule("assignmentbody", 28);
			Leave_assignmentbody();
			if (state.backtracking > 0) { Memoize(input, 28, assignmentbody_StartIndex); }
		}
		DebugLocation(120, 87);
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
	// MathLang.g:122:1: boolexpression : boolterm ;
	[GrammarRule("boolexpression")]
	private MathLangParser.boolexpression_return boolexpression()
	{
		Enter_boolexpression();
		EnterRule("boolexpression", 29);
		TraceIn("boolexpression", 29);
		MathLangParser.boolexpression_return retval = new MathLangParser.boolexpression_return();
		retval.Start = (IToken)input.LT(1);
		int boolexpression_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.boolterm_return boolterm89 = default(MathLangParser.boolterm_return);


		try { DebugEnterRule(GrammarFileName, "boolexpression");
		DebugLocation(122, 25);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 29)) { return retval; }
			// MathLang.g:122:15: ( boolterm )
			DebugEnterAlt(1);
			// MathLang.g:122:17: boolterm
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(122, 17);
			PushFollow(Follow._boolterm_in_boolexpression1017);
			boolterm89=boolterm();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm89.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("boolexpression", 29);
			LeaveRule("boolexpression", 29);
			Leave_boolexpression();
			if (state.backtracking > 0) { Memoize(input, 29, boolexpression_StartIndex); }
		}
		DebugLocation(122, 25);
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
	// MathLang.g:123:1: boolterm : or ( ( EQ | NEQ ) or )? ;
	[GrammarRule("boolterm")]
	private MathLangParser.boolterm_return boolterm()
	{
		Enter_boolterm();
		EnterRule("boolterm", 30);
		TraceIn("boolterm", 30);
		MathLangParser.boolterm_return retval = new MathLangParser.boolterm_return();
		retval.Start = (IToken)input.LT(1);
		int boolterm_StartIndex = input.Index;
		object root_0 = null;

		IToken set91=null;
		MathLangParser.or_return or90 = default(MathLangParser.or_return);
		MathLangParser.or_return or92 = default(MathLangParser.or_return);

		object set91_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolterm");
		DebugLocation(123, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 30)) { return retval; }
			// MathLang.g:123:9: ( or ( ( EQ | NEQ ) or )? )
			DebugEnterAlt(1);
			// MathLang.g:123:11: or ( ( EQ | NEQ ) or )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(123, 11);
			PushFollow(Follow._or_in_boolterm1024);
			or90=or();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or90.Tree);
			DebugLocation(123, 14);
			// MathLang.g:123:14: ( ( EQ | NEQ ) or )?
			int alt19=2;
			try { DebugEnterSubRule(19);
			try { DebugEnterDecision(19, decisionCanBacktrack[19]);
			int LA19_0 = input.LA(1);

			if (((LA19_0>=NEQ && LA19_0<=EQ)))
			{
				alt19=1;
			}
			} finally { DebugExitDecision(19); }
			switch (alt19)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:123:16: ( EQ | NEQ ) or
				{
				DebugLocation(123, 16);
				set91=(IToken)input.LT(1);
				set91=(IToken)input.LT(1);
				if ((input.LA(1)>=NEQ && input.LA(1)<=EQ))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set91), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(123, 28);
				PushFollow(Follow._or_in_boolterm1037);
				or92=or();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or92.Tree);

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
			TraceOut("boolterm", 30);
			LeaveRule("boolterm", 30);
			Leave_boolterm();
			if (state.backtracking > 0) { Memoize(input, 30, boolterm_StartIndex); }
		}
		DebugLocation(123, 32);
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
	// MathLang.g:124:1: or : and ( OR and )* ;
	[GrammarRule("or")]
	private MathLangParser.or_return or()
	{
		Enter_or();
		EnterRule("or", 31);
		TraceIn("or", 31);
		MathLangParser.or_return retval = new MathLangParser.or_return();
		retval.Start = (IToken)input.LT(1);
		int or_StartIndex = input.Index;
		object root_0 = null;

		IToken OR94=null;
		MathLangParser.and_return and93 = default(MathLangParser.and_return);
		MathLangParser.and_return and95 = default(MathLangParser.and_return);

		object OR94_tree=null;

		try { DebugEnterRule(GrammarFileName, "or");
		DebugLocation(124, 18);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 31)) { return retval; }
			// MathLang.g:124:3: ( and ( OR and )* )
			DebugEnterAlt(1);
			// MathLang.g:124:5: and ( OR and )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(124, 5);
			PushFollow(Follow._and_in_or1046);
			and93=and();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and93.Tree);
			DebugLocation(124, 9);
			// MathLang.g:124:9: ( OR and )*
			try { DebugEnterSubRule(20);
			while (true)
			{
				int alt20=2;
				try { DebugEnterDecision(20, decisionCanBacktrack[20]);
				int LA20_0 = input.LA(1);

				if ((LA20_0==OR))
				{
					alt20=1;
				}


				} finally { DebugExitDecision(20); }
				switch ( alt20 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:124:10: OR and
					{
					DebugLocation(124, 12);
					OR94=(IToken)Match(input,OR,Follow._OR_in_or1049); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR94_tree = (object)adaptor.Create(OR94);
					root_0 = (object)adaptor.BecomeRoot(OR94_tree, root_0);
					}
					DebugLocation(124, 14);
					PushFollow(Follow._and_in_or1052);
					and95=and();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and95.Tree);

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
			TraceOut("or", 31);
			LeaveRule("or", 31);
			Leave_or();
			if (state.backtracking > 0) { Memoize(input, 31, or_StartIndex); }
		}
		DebugLocation(124, 18);
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
	// MathLang.g:125:1: and : boolgroup ( AND boolgroup )* ;
	[GrammarRule("and")]
	private MathLangParser.and_return and()
	{
		Enter_and();
		EnterRule("and", 32);
		TraceIn("and", 32);
		MathLangParser.and_return retval = new MathLangParser.and_return();
		retval.Start = (IToken)input.LT(1);
		int and_StartIndex = input.Index;
		object root_0 = null;

		IToken AND97=null;
		MathLangParser.boolgroup_return boolgroup96 = default(MathLangParser.boolgroup_return);
		MathLangParser.boolgroup_return boolgroup98 = default(MathLangParser.boolgroup_return);

		object AND97_tree=null;

		try { DebugEnterRule(GrammarFileName, "and");
		DebugLocation(125, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 32)) { return retval; }
			// MathLang.g:125:4: ( boolgroup ( AND boolgroup )* )
			DebugEnterAlt(1);
			// MathLang.g:125:6: boolgroup ( AND boolgroup )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(125, 6);
			PushFollow(Follow._boolgroup_in_and1060);
			boolgroup96=boolgroup();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup96.Tree);
			DebugLocation(125, 16);
			// MathLang.g:125:16: ( AND boolgroup )*
			try { DebugEnterSubRule(21);
			while (true)
			{
				int alt21=2;
				try { DebugEnterDecision(21, decisionCanBacktrack[21]);
				int LA21_0 = input.LA(1);

				if ((LA21_0==AND))
				{
					alt21=1;
				}


				} finally { DebugExitDecision(21); }
				switch ( alt21 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:125:17: AND boolgroup
					{
					DebugLocation(125, 20);
					AND97=(IToken)Match(input,AND,Follow._AND_in_and1063); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND97_tree = (object)adaptor.Create(AND97);
					root_0 = (object)adaptor.BecomeRoot(AND97_tree, root_0);
					}
					DebugLocation(125, 22);
					PushFollow(Follow._boolgroup_in_and1066);
					boolgroup98=boolgroup();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolgroup98.Tree);

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
			TraceOut("and", 32);
			LeaveRule("and", 32);
			Leave_and();
			if (state.backtracking > 0) { Memoize(input, 32, and_StartIndex); }
		}
		DebugLocation(125, 32);
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
	// MathLang.g:126:1: boolgroup : ( NOT )? ( OPEN_BRACE boolterm CLOSE_BRACE | boolvar ) ;
	[GrammarRule("boolgroup")]
	private MathLangParser.boolgroup_return boolgroup()
	{
		Enter_boolgroup();
		EnterRule("boolgroup", 33);
		TraceIn("boolgroup", 33);
		MathLangParser.boolgroup_return retval = new MathLangParser.boolgroup_return();
		retval.Start = (IToken)input.LT(1);
		int boolgroup_StartIndex = input.Index;
		object root_0 = null;

		IToken NOT99=null;
		IToken OPEN_BRACE100=null;
		IToken CLOSE_BRACE102=null;
		MathLangParser.boolterm_return boolterm101 = default(MathLangParser.boolterm_return);
		MathLangParser.boolvar_return boolvar103 = default(MathLangParser.boolvar_return);

		object NOT99_tree=null;
		object OPEN_BRACE100_tree=null;
		object CLOSE_BRACE102_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolgroup");
		DebugLocation(126, 66);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 33)) { return retval; }
			// MathLang.g:126:10: ( ( NOT )? ( OPEN_BRACE boolterm CLOSE_BRACE | boolvar ) )
			DebugEnterAlt(1);
			// MathLang.g:126:12: ( NOT )? ( OPEN_BRACE boolterm CLOSE_BRACE | boolvar )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(126, 12);
			// MathLang.g:126:12: ( NOT )?
			int alt22=2;
			try { DebugEnterSubRule(22);
			try { DebugEnterDecision(22, decisionCanBacktrack[22]);
			int LA22_0 = input.LA(1);

			if ((LA22_0==NOT))
			{
				alt22=1;
			}
			} finally { DebugExitDecision(22); }
			switch (alt22)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:126:13: NOT
				{
				DebugLocation(126, 16);
				NOT99=(IToken)Match(input,NOT,Follow._NOT_in_boolgroup1075); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				NOT99_tree = (object)adaptor.Create(NOT99);
				root_0 = (object)adaptor.BecomeRoot(NOT99_tree, root_0);
				}

				}
				break;

			}
			} finally { DebugExitSubRule(22); }

			DebugLocation(126, 20);
			// MathLang.g:126:20: ( OPEN_BRACE boolterm CLOSE_BRACE | boolvar )
			int alt23=2;
			try { DebugEnterSubRule(23);
			try { DebugEnterDecision(23, decisionCanBacktrack[23]);
			int LA23_0 = input.LA(1);

			if ((LA23_0==OPEN_BRACE))
			{
				int LA23_1 = input.LA(2);

				if ((EvaluatePredicate(synpred44_MathLang_fragment)))
				{
					alt23=1;
				}
				else if ((true))
				{
					alt23=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 23, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else if ((LA23_0==ID||(LA23_0>=NUMBER && LA23_0<=CHAR)||LA23_0==SUB||(LA23_0>=TRUE && LA23_0<=FALSE)))
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
				// MathLang.g:126:22: OPEN_BRACE boolterm CLOSE_BRACE
				{
				DebugLocation(126, 32);
				OPEN_BRACE100=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_boolgroup1082); if (state.failed) return retval;
				DebugLocation(126, 34);
				PushFollow(Follow._boolterm_in_boolgroup1085);
				boolterm101=boolterm();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolterm101.Tree);
				DebugLocation(126, 54);
				CLOSE_BRACE102=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_boolgroup1087); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:126:58: boolvar
				{
				DebugLocation(126, 58);
				PushFollow(Follow._boolvar_in_boolgroup1092);
				boolvar103=boolvar();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolvar103.Tree);

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
			TraceOut("boolgroup", 33);
			LeaveRule("boolgroup", 33);
			Leave_boolgroup();
			if (state.backtracking > 0) { Memoize(input, 33, boolgroup_StartIndex); }
		}
		DebugLocation(126, 66);
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
	// MathLang.g:127:1: boolvar : ( TRUE | FALSE | compare );
	[GrammarRule("boolvar")]
	private MathLangParser.boolvar_return boolvar()
	{
		Enter_boolvar();
		EnterRule("boolvar", 34);
		TraceIn("boolvar", 34);
		MathLangParser.boolvar_return retval = new MathLangParser.boolvar_return();
		retval.Start = (IToken)input.LT(1);
		int boolvar_StartIndex = input.Index;
		object root_0 = null;

		IToken TRUE104=null;
		IToken FALSE105=null;
		MathLangParser.compare_return compare106 = default(MathLangParser.compare_return);

		object TRUE104_tree=null;
		object FALSE105_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolvar");
		DebugLocation(127, 11);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 34)) { return retval; }
			// MathLang.g:127:8: ( TRUE | FALSE | compare )
			int alt24=3;
			try { DebugEnterDecision(24, decisionCanBacktrack[24]);
			switch (input.LA(1))
			{
			case TRUE:
				{
				alt24=1;
				}
				break;
			case FALSE:
				{
				alt24=2;
				}
				break;
			case ID:
			case NUMBER:
			case CHAR:
			case SUB:
			case OPEN_BRACE:
				{
				alt24=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 24, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(24); }
			switch (alt24)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:127:10: TRUE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(127, 10);
				TRUE104=(IToken)Match(input,TRUE,Follow._TRUE_in_boolvar1100); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				TRUE104_tree = (object)adaptor.Create(TRUE104);
				adaptor.AddChild(root_0, TRUE104_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:128:5: FALSE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(128, 5);
				FALSE105=(IToken)Match(input,FALSE,Follow._FALSE_in_boolvar1106); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				FALSE105_tree = (object)adaptor.Create(FALSE105);
				adaptor.AddChild(root_0, FALSE105_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:129:5: compare
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(129, 5);
				PushFollow(Follow._compare_in_boolvar1112);
				compare106=compare();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare106.Tree);

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
			TraceOut("boolvar", 34);
			LeaveRule("boolvar", 34);
			Leave_boolvar();
			if (state.backtracking > 0) { Memoize(input, 34, boolvar_StartIndex); }
		}
		DebugLocation(129, 11);
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
	// MathLang.g:131:1: ifstatement : IF OPEN_BRACE boolexpression CLOSE_BRACE ( block | statement ) ( ELSE ( block | statement ) )* ;
	[GrammarRule("ifstatement")]
	private MathLangParser.ifstatement_return ifstatement()
	{
		Enter_ifstatement();
		EnterRule("ifstatement", 35);
		TraceIn("ifstatement", 35);
		MathLangParser.ifstatement_return retval = new MathLangParser.ifstatement_return();
		retval.Start = (IToken)input.LT(1);
		int ifstatement_StartIndex = input.Index;
		object root_0 = null;

		IToken IF107=null;
		IToken OPEN_BRACE108=null;
		IToken CLOSE_BRACE110=null;
		IToken ELSE113=null;
		MathLangParser.boolexpression_return boolexpression109 = default(MathLangParser.boolexpression_return);
		MathLangParser.block_return block111 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement112 = default(MathLangParser.statement_return);
		MathLangParser.block_return block114 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement115 = default(MathLangParser.statement_return);

		object IF107_tree=null;
		object OPEN_BRACE108_tree=null;
		object CLOSE_BRACE110_tree=null;
		object ELSE113_tree=null;

		try { DebugEnterRule(GrammarFileName, "ifstatement");
		DebugLocation(131, 106);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 35)) { return retval; }
			// MathLang.g:131:12: ( IF OPEN_BRACE boolexpression CLOSE_BRACE ( block | statement ) ( ELSE ( block | statement ) )* )
			DebugEnterAlt(1);
			// MathLang.g:131:14: IF OPEN_BRACE boolexpression CLOSE_BRACE ( block | statement ) ( ELSE ( block | statement ) )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(131, 16);
			IF107=(IToken)Match(input,IF,Follow._IF_in_ifstatement1121); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			IF107_tree = (object)adaptor.Create(IF107);
			root_0 = (object)adaptor.BecomeRoot(IF107_tree, root_0);
			}
			DebugLocation(131, 28);
			OPEN_BRACE108=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_ifstatement1124); if (state.failed) return retval;
			DebugLocation(131, 30);
			PushFollow(Follow._boolexpression_in_ifstatement1127);
			boolexpression109=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression109.Tree);
			DebugLocation(131, 56);
			CLOSE_BRACE110=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_ifstatement1129); if (state.failed) return retval;
			DebugLocation(131, 58);
			// MathLang.g:131:58: ( block | statement )
			int alt25=2;
			try { DebugEnterSubRule(25);
			try { DebugEnterDecision(25, decisionCanBacktrack[25]);
			int LA25_0 = input.LA(1);

			if ((LA25_0==66))
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
				// MathLang.g:131:59: block
				{
				DebugLocation(131, 59);
				PushFollow(Follow._block_in_ifstatement1133);
				block111=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block111.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:131:67: statement
				{
				DebugLocation(131, 67);
				PushFollow(Follow._statement_in_ifstatement1137);
				statement112=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement112.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(25); }

			DebugLocation(131, 78);
			// MathLang.g:131:78: ( ELSE ( block | statement ) )*
			try { DebugEnterSubRule(27);
			while (true)
			{
				int alt27=2;
				try { DebugEnterDecision(27, decisionCanBacktrack[27]);
				int LA27_0 = input.LA(1);

				if ((LA27_0==ELSE))
				{
					int LA27_1 = input.LA(2);

					if ((EvaluatePredicate(synpred49_MathLang_fragment)))
					{
						alt27=1;
					}


				}


				} finally { DebugExitDecision(27); }
				switch ( alt27 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:131:79: ELSE ( block | statement )
					{
					DebugLocation(131, 83);
					ELSE113=(IToken)Match(input,ELSE,Follow._ELSE_in_ifstatement1141); if (state.failed) return retval;
					DebugLocation(131, 85);
					// MathLang.g:131:85: ( block | statement )
					int alt26=2;
					try { DebugEnterSubRule(26);
					try { DebugEnterDecision(26, decisionCanBacktrack[26]);
					int LA26_0 = input.LA(1);

					if ((LA26_0==66))
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
						// MathLang.g:131:86: block
						{
						DebugLocation(131, 86);
						PushFollow(Follow._block_in_ifstatement1145);
						block114=block();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block114.Tree);

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// MathLang.g:131:94: statement
						{
						DebugLocation(131, 94);
						PushFollow(Follow._statement_in_ifstatement1149);
						statement115=statement();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement115.Tree);

						}
						break;

					}
					} finally { DebugExitSubRule(26); }


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

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("ifstatement", 35);
			LeaveRule("ifstatement", 35);
			Leave_ifstatement();
			if (state.backtracking > 0) { Memoize(input, 35, ifstatement_StartIndex); }
		}
		DebugLocation(131, 106);
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
	// MathLang.g:132:1: whilestatement : WHILE OPEN_BRACE boolexpression CLOSE_BRACE ( block | statement ) ;
	[GrammarRule("whilestatement")]
	private MathLangParser.whilestatement_return whilestatement()
	{
		Enter_whilestatement();
		EnterRule("whilestatement", 36);
		TraceIn("whilestatement", 36);
		MathLangParser.whilestatement_return retval = new MathLangParser.whilestatement_return();
		retval.Start = (IToken)input.LT(1);
		int whilestatement_StartIndex = input.Index;
		object root_0 = null;

		IToken WHILE116=null;
		IToken OPEN_BRACE117=null;
		IToken CLOSE_BRACE119=null;
		MathLangParser.boolexpression_return boolexpression118 = default(MathLangParser.boolexpression_return);
		MathLangParser.block_return block120 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement121 = default(MathLangParser.statement_return);

		object WHILE116_tree=null;
		object OPEN_BRACE117_tree=null;
		object CLOSE_BRACE119_tree=null;

		try { DebugEnterRule(GrammarFileName, "whilestatement");
		DebugLocation(132, 82);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 36)) { return retval; }
			// MathLang.g:132:15: ( WHILE OPEN_BRACE boolexpression CLOSE_BRACE ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:132:17: WHILE OPEN_BRACE boolexpression CLOSE_BRACE ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(132, 22);
			WHILE116=(IToken)Match(input,WHILE,Follow._WHILE_in_whilestatement1159); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			WHILE116_tree = (object)adaptor.Create(WHILE116);
			root_0 = (object)adaptor.BecomeRoot(WHILE116_tree, root_0);
			}
			DebugLocation(132, 34);
			OPEN_BRACE117=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_whilestatement1162); if (state.failed) return retval;
			DebugLocation(132, 36);
			PushFollow(Follow._boolexpression_in_whilestatement1165);
			boolexpression118=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression118.Tree);
			DebugLocation(132, 62);
			CLOSE_BRACE119=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_whilestatement1167); if (state.failed) return retval;
			DebugLocation(132, 64);
			// MathLang.g:132:64: ( block | statement )
			int alt28=2;
			try { DebugEnterSubRule(28);
			try { DebugEnterDecision(28, decisionCanBacktrack[28]);
			int LA28_0 = input.LA(1);

			if ((LA28_0==66))
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
				// MathLang.g:132:65: block
				{
				DebugLocation(132, 65);
				PushFollow(Follow._block_in_whilestatement1171);
				block120=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block120.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:132:73: statement
				{
				DebugLocation(132, 73);
				PushFollow(Follow._statement_in_whilestatement1175);
				statement121=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement121.Tree);

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
			TraceOut("whilestatement", 36);
			LeaveRule("whilestatement", 36);
			Leave_whilestatement();
			if (state.backtracking > 0) { Memoize(input, 36, whilestatement_StartIndex); }
		}
		DebugLocation(132, 82);
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
	// MathLang.g:133:1: forstatement : FOR OPEN_BRACE longdeclarationbody ';' boolexpression ';' assignmentbody CLOSE_BRACE ( block | statement ) ;
	[GrammarRule("forstatement")]
	private MathLangParser.forstatement_return forstatement()
	{
		Enter_forstatement();
		EnterRule("forstatement", 37);
		TraceIn("forstatement", 37);
		MathLangParser.forstatement_return retval = new MathLangParser.forstatement_return();
		retval.Start = (IToken)input.LT(1);
		int forstatement_StartIndex = input.Index;
		object root_0 = null;

		IToken FOR122=null;
		IToken OPEN_BRACE123=null;
		IToken char_literal125=null;
		IToken char_literal127=null;
		IToken CLOSE_BRACE129=null;
		MathLangParser.longdeclarationbody_return longdeclarationbody124 = default(MathLangParser.longdeclarationbody_return);
		MathLangParser.boolexpression_return boolexpression126 = default(MathLangParser.boolexpression_return);
		MathLangParser.assignmentbody_return assignmentbody128 = default(MathLangParser.assignmentbody_return);
		MathLangParser.block_return block130 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement131 = default(MathLangParser.statement_return);

		object FOR122_tree=null;
		object OPEN_BRACE123_tree=null;
		object char_literal125_tree=null;
		object char_literal127_tree=null;
		object CLOSE_BRACE129_tree=null;

		try { DebugEnterRule(GrammarFileName, "forstatement");
		DebugLocation(133, 123);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 37)) { return retval; }
			// MathLang.g:133:13: ( FOR OPEN_BRACE longdeclarationbody ';' boolexpression ';' assignmentbody CLOSE_BRACE ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:133:15: FOR OPEN_BRACE longdeclarationbody ';' boolexpression ';' assignmentbody CLOSE_BRACE ( block | statement )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(133, 18);
			FOR122=(IToken)Match(input,FOR,Follow._FOR_in_forstatement1182); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			FOR122_tree = (object)adaptor.Create(FOR122);
			root_0 = (object)adaptor.BecomeRoot(FOR122_tree, root_0);
			}
			DebugLocation(133, 30);
			OPEN_BRACE123=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_forstatement1185); if (state.failed) return retval;
			DebugLocation(133, 32);
			PushFollow(Follow._longdeclarationbody_in_forstatement1188);
			longdeclarationbody124=longdeclarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, longdeclarationbody124.Tree);
			DebugLocation(133, 55);
			char_literal125=(IToken)Match(input,68,Follow._68_in_forstatement1190); if (state.failed) return retval;
			DebugLocation(133, 57);
			PushFollow(Follow._boolexpression_in_forstatement1193);
			boolexpression126=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression126.Tree);
			DebugLocation(133, 75);
			char_literal127=(IToken)Match(input,68,Follow._68_in_forstatement1195); if (state.failed) return retval;
			DebugLocation(133, 77);
			PushFollow(Follow._assignmentbody_in_forstatement1198);
			assignmentbody128=assignmentbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentbody128.Tree);
			DebugLocation(133, 103);
			CLOSE_BRACE129=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_forstatement1200); if (state.failed) return retval;
			DebugLocation(133, 105);
			// MathLang.g:133:105: ( block | statement )
			int alt29=2;
			try { DebugEnterSubRule(29);
			try { DebugEnterDecision(29, decisionCanBacktrack[29]);
			int LA29_0 = input.LA(1);

			if ((LA29_0==66))
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
				// MathLang.g:133:106: block
				{
				DebugLocation(133, 106);
				PushFollow(Follow._block_in_forstatement1204);
				block130=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block130.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:133:114: statement
				{
				DebugLocation(133, 114);
				PushFollow(Follow._statement_in_forstatement1208);
				statement131=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement131.Tree);

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
			TraceOut("forstatement", 37);
			LeaveRule("forstatement", 37);
			Leave_forstatement();
			if (state.backtracking > 0) { Memoize(input, 37, forstatement_StartIndex); }
		}
		DebugLocation(133, 123);
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
	// MathLang.g:134:1: returnstatement : RETURN expression ';' ;
	[GrammarRule("returnstatement")]
	private MathLangParser.returnstatement_return returnstatement()
	{
		Enter_returnstatement();
		EnterRule("returnstatement", 38);
		TraceIn("returnstatement", 38);
		MathLangParser.returnstatement_return retval = new MathLangParser.returnstatement_return();
		retval.Start = (IToken)input.LT(1);
		int returnstatement_StartIndex = input.Index;
		object root_0 = null;

		IToken RETURN132=null;
		IToken char_literal134=null;
		MathLangParser.expression_return expression133 = default(MathLangParser.expression_return);

		object RETURN132_tree=null;
		object char_literal134_tree=null;

		try { DebugEnterRule(GrammarFileName, "returnstatement");
		DebugLocation(134, 41);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 38)) { return retval; }
			// MathLang.g:134:16: ( RETURN expression ';' )
			DebugEnterAlt(1);
			// MathLang.g:134:18: RETURN expression ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(134, 24);
			RETURN132=(IToken)Match(input,RETURN,Follow._RETURN_in_returnstatement1215); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			RETURN132_tree = (object)adaptor.Create(RETURN132);
			root_0 = (object)adaptor.BecomeRoot(RETURN132_tree, root_0);
			}
			DebugLocation(134, 26);
			PushFollow(Follow._expression_in_returnstatement1218);
			expression133=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression133.Tree);
			DebugLocation(134, 40);
			char_literal134=(IToken)Match(input,68,Follow._68_in_returnstatement1220); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("returnstatement", 38);
			LeaveRule("returnstatement", 38);
			Leave_returnstatement();
			if (state.backtracking > 0) { Memoize(input, 38, returnstatement_StartIndex); }
		}
		DebugLocation(134, 41);
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
	// MathLang.g:135:1: dowhilestatement : DO ( block | statement ) WHILE OPEN_BRACE boolexpression CLOSE_BRACE ';' ;
	[GrammarRule("dowhilestatement")]
	private MathLangParser.dowhilestatement_return dowhilestatement()
	{
		Enter_dowhilestatement();
		EnterRule("dowhilestatement", 39);
		TraceIn("dowhilestatement", 39);
		MathLangParser.dowhilestatement_return retval = new MathLangParser.dowhilestatement_return();
		retval.Start = (IToken)input.LT(1);
		int dowhilestatement_StartIndex = input.Index;
		object root_0 = null;

		IToken DO135=null;
		IToken WHILE138=null;
		IToken OPEN_BRACE139=null;
		IToken CLOSE_BRACE141=null;
		IToken char_literal142=null;
		MathLangParser.block_return block136 = default(MathLangParser.block_return);
		MathLangParser.statement_return statement137 = default(MathLangParser.statement_return);
		MathLangParser.boolexpression_return boolexpression140 = default(MathLangParser.boolexpression_return);

		object DO135_tree=null;
		object WHILE138_tree=null;
		object OPEN_BRACE139_tree=null;
		object CLOSE_BRACE141_tree=null;
		object char_literal142_tree=null;

		try { DebugEnterRule(GrammarFileName, "dowhilestatement");
		DebugLocation(135, 94);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 39)) { return retval; }
			// MathLang.g:135:17: ( DO ( block | statement ) WHILE OPEN_BRACE boolexpression CLOSE_BRACE ';' )
			DebugEnterAlt(1);
			// MathLang.g:135:19: DO ( block | statement ) WHILE OPEN_BRACE boolexpression CLOSE_BRACE ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(135, 21);
			DO135=(IToken)Match(input,DO,Follow._DO_in_dowhilestatement1228); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			DO135_tree = (object)adaptor.Create(DO135);
			root_0 = (object)adaptor.BecomeRoot(DO135_tree, root_0);
			}
			DebugLocation(135, 23);
			// MathLang.g:135:23: ( block | statement )
			int alt30=2;
			try { DebugEnterSubRule(30);
			try { DebugEnterDecision(30, decisionCanBacktrack[30]);
			int LA30_0 = input.LA(1);

			if ((LA30_0==66))
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
				// MathLang.g:135:24: block
				{
				DebugLocation(135, 24);
				PushFollow(Follow._block_in_dowhilestatement1232);
				block136=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block136.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:135:32: statement
				{
				DebugLocation(135, 32);
				PushFollow(Follow._statement_in_dowhilestatement1236);
				statement137=statement();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement137.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(30); }

			DebugLocation(135, 48);
			WHILE138=(IToken)Match(input,WHILE,Follow._WHILE_in_dowhilestatement1239); if (state.failed) return retval;
			DebugLocation(135, 60);
			OPEN_BRACE139=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_dowhilestatement1242); if (state.failed) return retval;
			DebugLocation(135, 62);
			PushFollow(Follow._boolexpression_in_dowhilestatement1245);
			boolexpression140=boolexpression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolexpression140.Tree);
			DebugLocation(135, 88);
			CLOSE_BRACE141=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_dowhilestatement1247); if (state.failed) return retval;
			DebugLocation(135, 93);
			char_literal142=(IToken)Match(input,68,Follow._68_in_dowhilestatement1250); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("dowhilestatement", 39);
			LeaveRule("dowhilestatement", 39);
			Leave_dowhilestatement();
			if (state.backtracking > 0) { Memoize(input, 39, dowhilestatement_StartIndex); }
		}
		DebugLocation(135, 94);
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
	// MathLang.g:137:1: funcdeclaration : MODIFIER any_type ID ( OPEN_BRACE ( paramsdeclaration )? CLOSE_BRACE ) block -> ^( FUNCDECLARATION ID ^( RETURN_TYPE any_type ) ( paramsdeclaration )? block ) ;
	[GrammarRule("funcdeclaration")]
	private MathLangParser.funcdeclaration_return funcdeclaration()
	{
		Enter_funcdeclaration();
		EnterRule("funcdeclaration", 40);
		TraceIn("funcdeclaration", 40);
		MathLangParser.funcdeclaration_return retval = new MathLangParser.funcdeclaration_return();
		retval.Start = (IToken)input.LT(1);
		int funcdeclaration_StartIndex = input.Index;
		object root_0 = null;

		IToken MODIFIER143=null;
		IToken ID145=null;
		IToken OPEN_BRACE146=null;
		IToken CLOSE_BRACE148=null;
		MathLangParser.any_type_return any_type144 = default(MathLangParser.any_type_return);
		MathLangParser.paramsdeclaration_return paramsdeclaration147 = default(MathLangParser.paramsdeclaration_return);
		MathLangParser.block_return block149 = default(MathLangParser.block_return);

		object MODIFIER143_tree=null;
		object ID145_tree=null;
		object OPEN_BRACE146_tree=null;
		object CLOSE_BRACE148_tree=null;
		RewriteRuleITokenStream stream_MODIFIER=new RewriteRuleITokenStream(adaptor,"token MODIFIER");
		RewriteRuleITokenStream stream_OPEN_BRACE=new RewriteRuleITokenStream(adaptor,"token OPEN_BRACE");
		RewriteRuleITokenStream stream_CLOSE_BRACE=new RewriteRuleITokenStream(adaptor,"token CLOSE_BRACE");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleSubtreeStream stream_any_type=new RewriteRuleSubtreeStream(adaptor,"rule any_type");
		RewriteRuleSubtreeStream stream_paramsdeclaration=new RewriteRuleSubtreeStream(adaptor,"rule paramsdeclaration");
		RewriteRuleSubtreeStream stream_block=new RewriteRuleSubtreeStream(adaptor,"rule block");
		try { DebugEnterRule(GrammarFileName, "funcdeclaration");
		DebugLocation(137, 191);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 40)) { return retval; }
			// MathLang.g:137:16: ( MODIFIER any_type ID ( OPEN_BRACE ( paramsdeclaration )? CLOSE_BRACE ) block -> ^( FUNCDECLARATION ID ^( RETURN_TYPE any_type ) ( paramsdeclaration )? block ) )
			DebugEnterAlt(1);
			// MathLang.g:137:18: MODIFIER any_type ID ( OPEN_BRACE ( paramsdeclaration )? CLOSE_BRACE ) block
			{
			DebugLocation(137, 18);
			MODIFIER143=(IToken)Match(input,MODIFIER,Follow._MODIFIER_in_funcdeclaration1259); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_MODIFIER.Add(MODIFIER143);

			DebugLocation(137, 27);
			PushFollow(Follow._any_type_in_funcdeclaration1261);
			any_type144=any_type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_any_type.Add(any_type144.Tree);
			DebugLocation(137, 38);
			ID145=(IToken)Match(input,ID,Follow._ID_in_funcdeclaration1263); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID145);

			DebugLocation(137, 40);
			// MathLang.g:137:40: ( OPEN_BRACE ( paramsdeclaration )? CLOSE_BRACE )
			DebugEnterAlt(1);
			// MathLang.g:137:42: OPEN_BRACE ( paramsdeclaration )? CLOSE_BRACE
			{
			DebugLocation(137, 52);
			OPEN_BRACE146=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_funcdeclaration1268); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OPEN_BRACE.Add(OPEN_BRACE146);

			DebugLocation(137, 54);
			// MathLang.g:137:54: ( paramsdeclaration )?
			int alt31=2;
			try { DebugEnterSubRule(31);
			try { DebugEnterDecision(31, decisionCanBacktrack[31]);
			int LA31_0 = input.LA(1);

			if ((LA31_0==TYPE))
			{
				alt31=1;
			}
			} finally { DebugExitDecision(31); }
			switch (alt31)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: paramsdeclaration
				{
				DebugLocation(137, 54);
				PushFollow(Follow._paramsdeclaration_in_funcdeclaration1271);
				paramsdeclaration147=paramsdeclaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_paramsdeclaration.Add(paramsdeclaration147.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(31); }

			DebugLocation(137, 84);
			CLOSE_BRACE148=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_funcdeclaration1274); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CLOSE_BRACE.Add(CLOSE_BRACE148);


			}

			DebugLocation(137, 88);
			PushFollow(Follow._block_in_funcdeclaration1279);
			block149=block();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_block.Add(block149.Tree);


			{
			// AST REWRITE
			// elements: ID, any_type, paramsdeclaration, block
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 137:94: -> ^( FUNCDECLARATION ID ^( RETURN_TYPE any_type ) ( paramsdeclaration )? block )
			{
				DebugLocation(137, 97);
				// MathLang.g:137:97: ^( FUNCDECLARATION ID ^( RETURN_TYPE any_type ) ( paramsdeclaration )? block )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(137, 99);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNCDECLARATION, "FUNCDECLARATION"), root_1);

				DebugLocation(137, 115);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(137, 118);
				// MathLang.g:137:118: ^( RETURN_TYPE any_type )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(137, 120);
				root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(RETURN_TYPE, "RETURN_TYPE"), root_2);

				DebugLocation(137, 132);
				adaptor.AddChild(root_2, stream_any_type.NextTree());

				adaptor.AddChild(root_1, root_2);
				}
				DebugLocation(137, 154);
				// MathLang.g:137:154: ( paramsdeclaration )?
				if ( stream_paramsdeclaration.HasNext )
				{
					DebugLocation(137, 154);
					adaptor.AddChild(root_1, stream_paramsdeclaration.NextTree());

				}
				stream_paramsdeclaration.Reset();
				DebugLocation(137, 186);
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
			TraceOut("funcdeclaration", 40);
			LeaveRule("funcdeclaration", 40);
			Leave_funcdeclaration();
			if (state.backtracking > 0) { Memoize(input, 40, funcdeclaration_StartIndex); }
		}
		DebugLocation(137, 191);
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
	// MathLang.g:138:1: paramsdeclaration : ( declarationbody ( ',' declarationbody )* ) -> ^( PARAMETERS ( declarationbody )* ) ;
	[GrammarRule("paramsdeclaration")]
	private MathLangParser.paramsdeclaration_return paramsdeclaration()
	{
		Enter_paramsdeclaration();
		EnterRule("paramsdeclaration", 41);
		TraceIn("paramsdeclaration", 41);
		MathLangParser.paramsdeclaration_return retval = new MathLangParser.paramsdeclaration_return();
		retval.Start = (IToken)input.LT(1);
		int paramsdeclaration_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal151=null;
		MathLangParser.declarationbody_return declarationbody150 = default(MathLangParser.declarationbody_return);
		MathLangParser.declarationbody_return declarationbody152 = default(MathLangParser.declarationbody_return);

		object char_literal151_tree=null;
		RewriteRuleITokenStream stream_69=new RewriteRuleITokenStream(adaptor,"token 69");
		RewriteRuleSubtreeStream stream_declarationbody=new RewriteRuleSubtreeStream(adaptor,"rule declarationbody");
		try { DebugEnterRule(GrammarFileName, "paramsdeclaration");
		DebugLocation(138, 102);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 41)) { return retval; }
			// MathLang.g:138:18: ( ( declarationbody ( ',' declarationbody )* ) -> ^( PARAMETERS ( declarationbody )* ) )
			DebugEnterAlt(1);
			// MathLang.g:138:20: ( declarationbody ( ',' declarationbody )* )
			{
			DebugLocation(138, 20);
			// MathLang.g:138:20: ( declarationbody ( ',' declarationbody )* )
			DebugEnterAlt(1);
			// MathLang.g:138:22: declarationbody ( ',' declarationbody )*
			{
			DebugLocation(138, 22);
			PushFollow(Follow._declarationbody_in_paramsdeclaration1312);
			declarationbody150=declarationbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declarationbody.Add(declarationbody150.Tree);
			DebugLocation(138, 38);
			// MathLang.g:138:38: ( ',' declarationbody )*
			try { DebugEnterSubRule(32);
			while (true)
			{
				int alt32=2;
				try { DebugEnterDecision(32, decisionCanBacktrack[32]);
				int LA32_0 = input.LA(1);

				if ((LA32_0==69))
				{
					alt32=1;
				}


				} finally { DebugExitDecision(32); }
				switch ( alt32 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:138:40: ',' declarationbody
					{
					DebugLocation(138, 43);
					char_literal151=(IToken)Match(input,69,Follow._69_in_paramsdeclaration1316); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_69.Add(char_literal151);

					DebugLocation(138, 45);
					PushFollow(Follow._declarationbody_in_paramsdeclaration1319);
					declarationbody152=declarationbody();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_declarationbody.Add(declarationbody152.Tree);

					}
					break;

				default:
					goto loop32;
				}
			}

			loop32:
				;

			} finally { DebugExitSubRule(32); }


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
			// 138:66: -> ^( PARAMETERS ( declarationbody )* )
			{
				DebugLocation(138, 69);
				// MathLang.g:138:69: ^( PARAMETERS ( declarationbody )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(138, 71);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_1);

				DebugLocation(138, 82);
				// MathLang.g:138:82: ( declarationbody )*
				while ( stream_declarationbody.HasNext )
				{
					DebugLocation(138, 84);
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
			TraceOut("paramsdeclaration", 41);
			LeaveRule("paramsdeclaration", 41);
			Leave_paramsdeclaration();
			if (state.backtracking > 0) { Memoize(input, 41, paramsdeclaration_StartIndex); }
		}
		DebugLocation(138, 102);
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
	// MathLang.g:140:1: funccallbody : extended_id OPEN_BRACE ( expressioncommalist )? CLOSE_BRACE -> ^( FUNC_CALL extended_id ( ^( PARAMETERS expressioncommalist ) )? ) ;
	[GrammarRule("funccallbody")]
	private MathLangParser.funccallbody_return funccallbody()
	{
		Enter_funccallbody();
		EnterRule("funccallbody", 42);
		TraceIn("funccallbody", 42);
		MathLangParser.funccallbody_return retval = new MathLangParser.funccallbody_return();
		retval.Start = (IToken)input.LT(1);
		int funccallbody_StartIndex = input.Index;
		object root_0 = null;

		IToken OPEN_BRACE154=null;
		IToken CLOSE_BRACE156=null;
		MathLangParser.extended_id_return extended_id153 = default(MathLangParser.extended_id_return);
		MathLangParser.expressioncommalist_return expressioncommalist155 = default(MathLangParser.expressioncommalist_return);

		object OPEN_BRACE154_tree=null;
		object CLOSE_BRACE156_tree=null;
		RewriteRuleITokenStream stream_OPEN_BRACE=new RewriteRuleITokenStream(adaptor,"token OPEN_BRACE");
		RewriteRuleITokenStream stream_CLOSE_BRACE=new RewriteRuleITokenStream(adaptor,"token CLOSE_BRACE");
		RewriteRuleSubtreeStream stream_extended_id=new RewriteRuleSubtreeStream(adaptor,"rule extended_id");
		RewriteRuleSubtreeStream stream_expressioncommalist=new RewriteRuleSubtreeStream(adaptor,"rule expressioncommalist");
		try { DebugEnterRule(GrammarFileName, "funccallbody");
		DebugLocation(140, 133);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 42)) { return retval; }
			// MathLang.g:140:13: ( extended_id OPEN_BRACE ( expressioncommalist )? CLOSE_BRACE -> ^( FUNC_CALL extended_id ( ^( PARAMETERS expressioncommalist ) )? ) )
			DebugEnterAlt(1);
			// MathLang.g:140:15: extended_id OPEN_BRACE ( expressioncommalist )? CLOSE_BRACE
			{
			DebugLocation(140, 26);
			PushFollow(Follow._extended_id_in_funccallbody1344);
			extended_id153=extended_id();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_extended_id.Add(extended_id153.Tree);
			DebugLocation(140, 28);
			OPEN_BRACE154=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_funccallbody1347); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OPEN_BRACE.Add(OPEN_BRACE154);

			DebugLocation(140, 39);
			// MathLang.g:140:39: ( expressioncommalist )?
			int alt33=2;
			try { DebugEnterSubRule(33);
			try { DebugEnterDecision(33, decisionCanBacktrack[33]);
			int LA33_0 = input.LA(1);

			if ((LA33_0==ID||(LA33_0>=NUMBER && LA33_0<=CHAR)||LA33_0==SUB||LA33_0==OPEN_BRACE||(LA33_0>=NOT && LA33_0<=KNEW)))
			{
				alt33=1;
			}
			} finally { DebugExitDecision(33); }
			switch (alt33)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: expressioncommalist
				{
				DebugLocation(140, 39);
				PushFollow(Follow._expressioncommalist_in_funccallbody1349);
				expressioncommalist155=expressioncommalist();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expressioncommalist.Add(expressioncommalist155.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(33); }

			DebugLocation(140, 60);
			CLOSE_BRACE156=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_funccallbody1352); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CLOSE_BRACE.Add(CLOSE_BRACE156);



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
			// 140:72: -> ^( FUNC_CALL extended_id ( ^( PARAMETERS expressioncommalist ) )? )
			{
				DebugLocation(140, 75);
				// MathLang.g:140:75: ^( FUNC_CALL extended_id ( ^( PARAMETERS expressioncommalist ) )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(140, 77);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_CALL, "FUNC_CALL"), root_1);

				DebugLocation(140, 87);
				adaptor.AddChild(root_1, stream_extended_id.NextTree());
				DebugLocation(140, 99);
				// MathLang.g:140:99: ( ^( PARAMETERS expressioncommalist ) )?
				if ( stream_expressioncommalist.HasNext )
				{
					DebugLocation(140, 99);
					// MathLang.g:140:99: ^( PARAMETERS expressioncommalist )
					{
					object root_2 = (object)adaptor.Nil();
					DebugLocation(140, 101);
					root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_2);

					DebugLocation(140, 112);
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
			TraceOut("funccallbody", 42);
			LeaveRule("funccallbody", 42);
			Leave_funccallbody();
			if (state.backtracking > 0) { Memoize(input, 42, funccallbody_StartIndex); }
		}
		DebugLocation(140, 133);
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
	// MathLang.g:141:1: funccall : funccallbody ';' ;
	[GrammarRule("funccall")]
	private MathLangParser.funccall_return funccall()
	{
		Enter_funccall();
		EnterRule("funccall", 43);
		TraceIn("funccall", 43);
		MathLangParser.funccall_return retval = new MathLangParser.funccall_return();
		retval.Start = (IToken)input.LT(1);
		int funccall_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal158=null;
		MathLangParser.funccallbody_return funccallbody157 = default(MathLangParser.funccallbody_return);

		object char_literal158_tree=null;

		try { DebugEnterRule(GrammarFileName, "funccall");
		DebugLocation(141, 27);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 43)) { return retval; }
			// MathLang.g:141:9: ( funccallbody ';' )
			DebugEnterAlt(1);
			// MathLang.g:141:11: funccallbody ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(141, 11);
			PushFollow(Follow._funccallbody_in_funccall1373);
			funccallbody157=funccallbody();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funccallbody157.Tree);
			DebugLocation(141, 27);
			char_literal158=(IToken)Match(input,68,Follow._68_in_funccall1375); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("funccall", 43);
			LeaveRule("funccall", 43);
			Leave_funccall();
			if (state.backtracking > 0) { Memoize(input, 43, funccall_StartIndex); }
		}
		DebugLocation(141, 27);
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
	// MathLang.g:142:1: expressioncommalist : expression ( ',' expression )* ;
	[GrammarRule("expressioncommalist")]
	private MathLangParser.expressioncommalist_return expressioncommalist()
	{
		Enter_expressioncommalist();
		EnterRule("expressioncommalist", 44);
		TraceIn("expressioncommalist", 44);
		MathLangParser.expressioncommalist_return retval = new MathLangParser.expressioncommalist_return();
		retval.Start = (IToken)input.LT(1);
		int expressioncommalist_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal160=null;
		MathLangParser.expression_return expression159 = default(MathLangParser.expression_return);
		MathLangParser.expression_return expression161 = default(MathLangParser.expression_return);

		object char_literal160_tree=null;

		try { DebugEnterRule(GrammarFileName, "expressioncommalist");
		DebugLocation(142, 51);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 44)) { return retval; }
			// MathLang.g:142:20: ( expression ( ',' expression )* )
			DebugEnterAlt(1);
			// MathLang.g:142:22: expression ( ',' expression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(142, 22);
			PushFollow(Follow._expression_in_expressioncommalist1382);
			expression159=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression159.Tree);
			DebugLocation(142, 33);
			// MathLang.g:142:33: ( ',' expression )*
			try { DebugEnterSubRule(34);
			while (true)
			{
				int alt34=2;
				try { DebugEnterDecision(34, decisionCanBacktrack[34]);
				int LA34_0 = input.LA(1);

				if ((LA34_0==69))
				{
					alt34=1;
				}


				} finally { DebugExitDecision(34); }
				switch ( alt34 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:142:35: ',' expression
					{
					DebugLocation(142, 38);
					char_literal160=(IToken)Match(input,69,Follow._69_in_expressioncommalist1386); if (state.failed) return retval;
					DebugLocation(142, 40);
					PushFollow(Follow._expression_in_expressioncommalist1389);
					expression161=expression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression161.Tree);

					}
					break;

				default:
					goto loop34;
				}
			}

			loop34:
				;

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
			TraceOut("expressioncommalist", 44);
			LeaveRule("expressioncommalist", 44);
			Leave_expressioncommalist();
			if (state.backtracking > 0) { Memoize(input, 44, expressioncommalist_StartIndex); }
		}
		DebugLocation(142, 51);
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
	// MathLang.g:145:1: object_initializer : '{' expressioncommalist '}' -> ^( PARAMETERS expressioncommalist ) ;
	[GrammarRule("object_initializer")]
	private MathLangParser.object_initializer_return object_initializer()
	{
		Enter_object_initializer();
		EnterRule("object_initializer", 45);
		TraceIn("object_initializer", 45);
		MathLangParser.object_initializer_return retval = new MathLangParser.object_initializer_return();
		retval.Start = (IToken)input.LT(1);
		int object_initializer_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal162=null;
		IToken char_literal164=null;
		MathLangParser.expressioncommalist_return expressioncommalist163 = default(MathLangParser.expressioncommalist_return);

		object char_literal162_tree=null;
		object char_literal164_tree=null;
		RewriteRuleITokenStream stream_66=new RewriteRuleITokenStream(adaptor,"token 66");
		RewriteRuleITokenStream stream_67=new RewriteRuleITokenStream(adaptor,"token 67");
		RewriteRuleSubtreeStream stream_expressioncommalist=new RewriteRuleSubtreeStream(adaptor,"rule expressioncommalist");
		try { DebugEnterRule(GrammarFileName, "object_initializer");
		DebugLocation(145, 86);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 45)) { return retval; }
			// MathLang.g:145:19: ( '{' expressioncommalist '}' -> ^( PARAMETERS expressioncommalist ) )
			DebugEnterAlt(1);
			// MathLang.g:145:22: '{' expressioncommalist '}'
			{
			DebugLocation(145, 22);
			char_literal162=(IToken)Match(input,66,Follow._66_in_object_initializer1401); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_66.Add(char_literal162);

			DebugLocation(145, 26);
			PushFollow(Follow._expressioncommalist_in_object_initializer1403);
			expressioncommalist163=expressioncommalist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expressioncommalist.Add(expressioncommalist163.Tree);
			DebugLocation(145, 46);
			char_literal164=(IToken)Match(input,67,Follow._67_in_object_initializer1405); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_67.Add(char_literal164);



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
			// 145:50: -> ^( PARAMETERS expressioncommalist )
			{
				DebugLocation(145, 53);
				// MathLang.g:145:53: ^( PARAMETERS expressioncommalist )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(145, 55);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS, "PARAMETERS"), root_1);

				DebugLocation(145, 66);
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
			TraceOut("object_initializer", 45);
			LeaveRule("object_initializer", 45);
			Leave_object_initializer();
			if (state.backtracking > 0) { Memoize(input, 45, object_initializer_StartIndex); }
		}
		DebugLocation(145, 86);
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
	// MathLang.g:146:1: newexpression : KNEW initializer ;
	[GrammarRule("newexpression")]
	private MathLangParser.newexpression_return newexpression()
	{
		Enter_newexpression();
		EnterRule("newexpression", 46);
		TraceIn("newexpression", 46);
		MathLangParser.newexpression_return retval = new MathLangParser.newexpression_return();
		retval.Start = (IToken)input.LT(1);
		int newexpression_StartIndex = input.Index;
		object root_0 = null;

		IToken KNEW165=null;
		MathLangParser.initializer_return initializer166 = default(MathLangParser.initializer_return);

		object KNEW165_tree=null;

		try { DebugEnterRule(GrammarFileName, "newexpression");
		DebugLocation(146, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 46)) { return retval; }
			// MathLang.g:146:14: ( KNEW initializer )
			DebugEnterAlt(1);
			// MathLang.g:146:16: KNEW initializer
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(146, 20);
			KNEW165=(IToken)Match(input,KNEW,Follow._KNEW_in_newexpression1420); if (state.failed) return retval;
			DebugLocation(146, 22);
			PushFollow(Follow._initializer_in_newexpression1423);
			initializer166=initializer();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, initializer166.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("newexpression", 46);
			LeaveRule("newexpression", 46);
			Leave_newexpression();
			if (state.backtracking > 0) { Memoize(input, 46, newexpression_StartIndex); }
		}
		DebugLocation(146, 32);
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
	// MathLang.g:147:1: initializer : ( simple_var_initializer | array_initializer ) ;
	[GrammarRule("initializer")]
	private MathLangParser.initializer_return initializer()
	{
		Enter_initializer();
		EnterRule("initializer", 47);
		TraceIn("initializer", 47);
		MathLangParser.initializer_return retval = new MathLangParser.initializer_return();
		retval.Start = (IToken)input.LT(1);
		int initializer_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.simple_var_initializer_return simple_var_initializer167 = default(MathLangParser.simple_var_initializer_return);
		MathLangParser.array_initializer_return array_initializer168 = default(MathLangParser.array_initializer_return);


		try { DebugEnterRule(GrammarFileName, "initializer");
		DebugLocation(147, 57);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 47)) { return retval; }
			// MathLang.g:147:12: ( ( simple_var_initializer | array_initializer ) )
			DebugEnterAlt(1);
			// MathLang.g:147:14: ( simple_var_initializer | array_initializer )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(147, 14);
			// MathLang.g:147:14: ( simple_var_initializer | array_initializer )
			int alt35=2;
			try { DebugEnterSubRule(35);
			try { DebugEnterDecision(35, decisionCanBacktrack[35]);
			int LA35_0 = input.LA(1);

			if ((LA35_0==TYPE))
			{
				int LA35_1 = input.LA(2);

				if ((LA35_1==OPEN_BRACE))
				{
					alt35=1;
				}
				else if ((LA35_1==ARRAY_DECLARATION_MARK||LA35_1==OPEN_SQUARE_BRACE))
				{
					alt35=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 35, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
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
				// MathLang.g:147:15: simple_var_initializer
				{
				DebugLocation(147, 15);
				PushFollow(Follow._simple_var_initializer_in_initializer1430);
				simple_var_initializer167=simple_var_initializer();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, simple_var_initializer167.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:147:40: array_initializer
				{
				DebugLocation(147, 40);
				PushFollow(Follow._array_initializer_in_initializer1434);
				array_initializer168=array_initializer();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, array_initializer168.Tree);

				}
				break;

			}
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
			TraceOut("initializer", 47);
			LeaveRule("initializer", 47);
			Leave_initializer();
			if (state.backtracking > 0) { Memoize(input, 47, initializer_StartIndex); }
		}
		DebugLocation(147, 57);
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
	// MathLang.g:148:1: simple_var_initializer : type OPEN_BRACE CLOSE_BRACE -> ^( NEWVAR type ) ;
	[GrammarRule("simple_var_initializer")]
	private MathLangParser.simple_var_initializer_return simple_var_initializer()
	{
		Enter_simple_var_initializer();
		EnterRule("simple_var_initializer", 48);
		TraceIn("simple_var_initializer", 48);
		MathLangParser.simple_var_initializer_return retval = new MathLangParser.simple_var_initializer_return();
		retval.Start = (IToken)input.LT(1);
		int simple_var_initializer_StartIndex = input.Index;
		object root_0 = null;

		IToken OPEN_BRACE170=null;
		IToken CLOSE_BRACE171=null;
		MathLangParser.type_return type169 = default(MathLangParser.type_return);

		object OPEN_BRACE170_tree=null;
		object CLOSE_BRACE171_tree=null;
		RewriteRuleITokenStream stream_OPEN_BRACE=new RewriteRuleITokenStream(adaptor,"token OPEN_BRACE");
		RewriteRuleITokenStream stream_CLOSE_BRACE=new RewriteRuleITokenStream(adaptor,"token CLOSE_BRACE");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "simple_var_initializer");
		DebugLocation(148, 69);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 48)) { return retval; }
			// MathLang.g:148:23: ( type OPEN_BRACE CLOSE_BRACE -> ^( NEWVAR type ) )
			DebugEnterAlt(1);
			// MathLang.g:148:25: type OPEN_BRACE CLOSE_BRACE
			{
			DebugLocation(148, 25);
			PushFollow(Follow._type_in_simple_var_initializer1441);
			type169=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type169.Tree);
			DebugLocation(148, 30);
			OPEN_BRACE170=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_simple_var_initializer1443); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OPEN_BRACE.Add(OPEN_BRACE170);

			DebugLocation(148, 41);
			CLOSE_BRACE171=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_simple_var_initializer1445); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CLOSE_BRACE.Add(CLOSE_BRACE171);



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
			// 148:53: -> ^( NEWVAR type )
			{
				DebugLocation(148, 56);
				// MathLang.g:148:56: ^( NEWVAR type )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(148, 58);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(NEWVAR, "NEWVAR"), root_1);

				DebugLocation(148, 65);
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
			TraceOut("simple_var_initializer", 48);
			LeaveRule("simple_var_initializer", 48);
			Leave_simple_var_initializer();
			if (state.backtracking > 0) { Memoize(input, 48, simple_var_initializer_StartIndex); }
		}
		DebugLocation(148, 69);
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
	// MathLang.g:149:1: array_initializer : type ( ( OPEN_SQUARE_BRACE number CLOSE_SQUARE_BRACE ) | ARRAY_DECLARATION_MARK ) ( object_initializer )? -> ^( ARRAY_INITIALIZER type ( number )? ( object_initializer )? ) ;
	[GrammarRule("array_initializer")]
	private MathLangParser.array_initializer_return array_initializer()
	{
		Enter_array_initializer();
		EnterRule("array_initializer", 49);
		TraceIn("array_initializer", 49);
		MathLangParser.array_initializer_return retval = new MathLangParser.array_initializer_return();
		retval.Start = (IToken)input.LT(1);
		int array_initializer_StartIndex = input.Index;
		object root_0 = null;

		IToken OPEN_SQUARE_BRACE173=null;
		IToken CLOSE_SQUARE_BRACE175=null;
		IToken ARRAY_DECLARATION_MARK176=null;
		MathLangParser.type_return type172 = default(MathLangParser.type_return);
		MathLangParser.number_return number174 = default(MathLangParser.number_return);
		MathLangParser.object_initializer_return object_initializer177 = default(MathLangParser.object_initializer_return);

		object OPEN_SQUARE_BRACE173_tree=null;
		object CLOSE_SQUARE_BRACE175_tree=null;
		object ARRAY_DECLARATION_MARK176_tree=null;
		RewriteRuleITokenStream stream_OPEN_SQUARE_BRACE=new RewriteRuleITokenStream(adaptor,"token OPEN_SQUARE_BRACE");
		RewriteRuleITokenStream stream_ARRAY_DECLARATION_MARK=new RewriteRuleITokenStream(adaptor,"token ARRAY_DECLARATION_MARK");
		RewriteRuleITokenStream stream_CLOSE_SQUARE_BRACE=new RewriteRuleITokenStream(adaptor,"token CLOSE_SQUARE_BRACE");
		RewriteRuleSubtreeStream stream_number=new RewriteRuleSubtreeStream(adaptor,"rule number");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		RewriteRuleSubtreeStream stream_object_initializer=new RewriteRuleSubtreeStream(adaptor,"rule object_initializer");
		try { DebugEnterRule(GrammarFileName, "array_initializer");
		DebugLocation(149, 173);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 49)) { return retval; }
			// MathLang.g:149:18: ( type ( ( OPEN_SQUARE_BRACE number CLOSE_SQUARE_BRACE ) | ARRAY_DECLARATION_MARK ) ( object_initializer )? -> ^( ARRAY_INITIALIZER type ( number )? ( object_initializer )? ) )
			DebugEnterAlt(1);
			// MathLang.g:149:20: type ( ( OPEN_SQUARE_BRACE number CLOSE_SQUARE_BRACE ) | ARRAY_DECLARATION_MARK ) ( object_initializer )?
			{
			DebugLocation(149, 20);
			PushFollow(Follow._type_in_array_initializer1459);
			type172=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type172.Tree);
			DebugLocation(149, 25);
			// MathLang.g:149:25: ( ( OPEN_SQUARE_BRACE number CLOSE_SQUARE_BRACE ) | ARRAY_DECLARATION_MARK )
			int alt36=2;
			try { DebugEnterSubRule(36);
			try { DebugEnterDecision(36, decisionCanBacktrack[36]);
			int LA36_0 = input.LA(1);

			if ((LA36_0==OPEN_SQUARE_BRACE))
			{
				alt36=1;
			}
			else if ((LA36_0==ARRAY_DECLARATION_MARK))
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
				// MathLang.g:149:26: ( OPEN_SQUARE_BRACE number CLOSE_SQUARE_BRACE )
				{
				DebugLocation(149, 26);
				// MathLang.g:149:26: ( OPEN_SQUARE_BRACE number CLOSE_SQUARE_BRACE )
				DebugEnterAlt(1);
				// MathLang.g:149:27: OPEN_SQUARE_BRACE number CLOSE_SQUARE_BRACE
				{
				DebugLocation(149, 27);
				OPEN_SQUARE_BRACE173=(IToken)Match(input,OPEN_SQUARE_BRACE,Follow._OPEN_SQUARE_BRACE_in_array_initializer1463); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_OPEN_SQUARE_BRACE.Add(OPEN_SQUARE_BRACE173);

				DebugLocation(149, 45);
				PushFollow(Follow._number_in_array_initializer1465);
				number174=number();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_number.Add(number174.Tree);
				DebugLocation(149, 52);
				CLOSE_SQUARE_BRACE175=(IToken)Match(input,CLOSE_SQUARE_BRACE,Follow._CLOSE_SQUARE_BRACE_in_array_initializer1467); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_CLOSE_SQUARE_BRACE.Add(CLOSE_SQUARE_BRACE175);


				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:149:74: ARRAY_DECLARATION_MARK
				{
				DebugLocation(149, 74);
				ARRAY_DECLARATION_MARK176=(IToken)Match(input,ARRAY_DECLARATION_MARK,Follow._ARRAY_DECLARATION_MARK_in_array_initializer1472); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ARRAY_DECLARATION_MARK.Add(ARRAY_DECLARATION_MARK176);


				}
				break;

			}
			} finally { DebugExitSubRule(36); }

			DebugLocation(149, 98);
			// MathLang.g:149:98: ( object_initializer )?
			int alt37=2;
			try { DebugEnterSubRule(37);
			try { DebugEnterDecision(37, decisionCanBacktrack[37]);
			int LA37_0 = input.LA(1);

			if ((LA37_0==66))
			{
				alt37=1;
			}
			} finally { DebugExitDecision(37); }
			switch (alt37)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: object_initializer
				{
				DebugLocation(149, 98);
				PushFollow(Follow._object_initializer_in_array_initializer1475);
				object_initializer177=object_initializer();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_object_initializer.Add(object_initializer177.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(37); }



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
			// 149:118: -> ^( ARRAY_INITIALIZER type ( number )? ( object_initializer )? )
			{
				DebugLocation(149, 121);
				// MathLang.g:149:121: ^( ARRAY_INITIALIZER type ( number )? ( object_initializer )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(149, 123);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAY_INITIALIZER, "ARRAY_INITIALIZER"), root_1);

				DebugLocation(149, 141);
				adaptor.AddChild(root_1, stream_type.NextTree());
				DebugLocation(149, 146);
				// MathLang.g:149:146: ( number )?
				if ( stream_number.HasNext )
				{
					DebugLocation(149, 146);
					adaptor.AddChild(root_1, stream_number.NextTree());

				}
				stream_number.Reset();
				DebugLocation(149, 154);
				// MathLang.g:149:154: ( object_initializer )?
				if ( stream_object_initializer.HasNext )
				{
					DebugLocation(149, 154);
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
			TraceOut("array_initializer", 49);
			LeaveRule("array_initializer", 49);
			Leave_array_initializer();
			if (state.backtracking > 0) { Memoize(input, 49, array_initializer_StartIndex); }
		}
		DebugLocation(149, 173);
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
	// MathLang.g:151:1: block : '{' statementlist '}' ;
	[GrammarRule("block")]
	private MathLangParser.block_return block()
	{
		Enter_block();
		EnterRule("block", 50);
		TraceIn("block", 50);
		MathLangParser.block_return retval = new MathLangParser.block_return();
		retval.Start = (IToken)input.LT(1);
		int block_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal178=null;
		IToken char_literal180=null;
		MathLangParser.statementlist_return statementlist179 = default(MathLangParser.statementlist_return);

		object char_literal178_tree=null;
		object char_literal180_tree=null;

		try { DebugEnterRule(GrammarFileName, "block");
		DebugLocation(151, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 50)) { return retval; }
			// MathLang.g:151:6: ( '{' statementlist '}' )
			DebugEnterAlt(1);
			// MathLang.g:151:8: '{' statementlist '}'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(151, 11);
			char_literal178=(IToken)Match(input,66,Follow._66_in_block1497); if (state.failed) return retval;
			DebugLocation(151, 13);
			PushFollow(Follow._statementlist_in_block1500);
			statementlist179=statementlist();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementlist179.Tree);
			DebugLocation(151, 30);
			char_literal180=(IToken)Match(input,67,Follow._67_in_block1502); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("block", 50);
			LeaveRule("block", 50);
			Leave_block();
			if (state.backtracking > 0) { Memoize(input, 50, block_StartIndex); }
		}
		DebugLocation(151, 30);
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
	// MathLang.g:153:1: statementlist : ( statement )* -> ^( BLOCK ( statement )* ) ;
	[GrammarRule("statementlist")]
	private MathLangParser.statementlist_return statementlist()
	{
		Enter_statementlist();
		EnterRule("statementlist", 51);
		TraceIn("statementlist", 51);
		MathLangParser.statementlist_return retval = new MathLangParser.statementlist_return();
		retval.Start = (IToken)input.LT(1);
		int statementlist_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.statement_return statement181 = default(MathLangParser.statement_return);

		RewriteRuleSubtreeStream stream_statement=new RewriteRuleSubtreeStream(adaptor,"rule statement");
		try { DebugEnterRule(GrammarFileName, "statementlist");
		DebugLocation(153, 49);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 51)) { return retval; }
			// MathLang.g:153:14: ( ( statement )* -> ^( BLOCK ( statement )* ) )
			DebugEnterAlt(1);
			// MathLang.g:153:16: ( statement )*
			{
			DebugLocation(153, 16);
			// MathLang.g:153:16: ( statement )*
			try { DebugEnterSubRule(38);
			while (true)
			{
				int alt38=2;
				try { DebugEnterDecision(38, decisionCanBacktrack[38]);
				int LA38_0 = input.LA(1);

				if ((LA38_0==IF||LA38_0==FOR||(LA38_0>=RETURN && LA38_0<=DO)||(LA38_0>=ID && LA38_0<=TYPE)||LA38_0==KNEW))
				{
					alt38=1;
				}


				} finally { DebugExitDecision(38); }
				switch ( alt38 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: statement
					{
					DebugLocation(153, 16);
					PushFollow(Follow._statement_in_statementlist1510);
					statement181=statement();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_statement.Add(statement181.Tree);

					}
					break;

				default:
					goto loop38;
				}
			}

			loop38:
				;

			} finally { DebugExitSubRule(38); }



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
			// 153:27: -> ^( BLOCK ( statement )* )
			{
				DebugLocation(153, 30);
				// MathLang.g:153:30: ^( BLOCK ( statement )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(153, 32);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

				DebugLocation(153, 38);
				// MathLang.g:153:38: ( statement )*
				while ( stream_statement.HasNext )
				{
					DebugLocation(153, 38);
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
			TraceOut("statementlist", 51);
			LeaveRule("statementlist", 51);
			Leave_statementlist();
			if (state.backtracking > 0) { Memoize(input, 51, statementlist_StartIndex); }
		}
		DebugLocation(153, 49);
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
		EnterRule("synpred20_MathLang_fragment", 71);
		TraceIn("synpred20_MathLang_fragment", 71);
		try
		{
			// MathLang.g:90:5: ( funccallbody )
			DebugEnterAlt(1);
			// MathLang.g:90:5: funccallbody
			{
			DebugLocation(90, 5);
			PushFollow(Follow._funccallbody_in_synpred20_MathLang620);
			funccallbody();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred20_MathLang_fragment", 71);
			LeaveRule("synpred20_MathLang_fragment", 71);
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
		EnterRule("synpred21_MathLang_fragment", 72);
		TraceIn("synpred21_MathLang_fragment", 72);
		try
		{
			// MathLang.g:91:5: ( boolexpression )
			DebugEnterAlt(1);
			// MathLang.g:91:5: boolexpression
			{
			DebugLocation(91, 5);
			PushFollow(Follow._boolexpression_in_synpred21_MathLang626);
			boolexpression();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred21_MathLang_fragment", 72);
			LeaveRule("synpred21_MathLang_fragment", 72);
			Leave_synpred21_MathLang_fragment();
		}
	}
	// $ANTLR end synpred21_MathLang

	partial void Enter_synpred22_MathLang_fragment();
	partial void Leave_synpred22_MathLang_fragment();

	// $ANTLR start synpred22_MathLang
	public void synpred22_MathLang_fragment()
	{
		Enter_synpred22_MathLang_fragment();
		EnterRule("synpred22_MathLang_fragment", 73);
		TraceIn("synpred22_MathLang_fragment", 73);
		try
		{
			// MathLang.g:96:18: ( DOT extended_id )
			DebugEnterAlt(1);
			// MathLang.g:96:18: DOT extended_id
			{
			DebugLocation(96, 18);
			Match(input,DOT,Follow._DOT_in_synpred22_MathLang648); if (state.failed) return;
			DebugLocation(96, 23);
			PushFollow(Follow._extended_id_in_synpred22_MathLang651);
			extended_id();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred22_MathLang_fragment", 73);
			LeaveRule("synpred22_MathLang_fragment", 73);
			Leave_synpred22_MathLang_fragment();
		}
	}
	// $ANTLR end synpred22_MathLang

	partial void Enter_synpred35_MathLang_fragment();
	partial void Leave_synpred35_MathLang_fragment();

	// $ANTLR start synpred35_MathLang
	public void synpred35_MathLang_fragment()
	{
		Enter_synpred35_MathLang_fragment();
		EnterRule("synpred35_MathLang_fragment", 86);
		TraceIn("synpred35_MathLang_fragment", 86);
		try
		{
			// MathLang.g:114:16: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )
			DebugEnterAlt(1);
			// MathLang.g:114:16: ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add
			{
			DebugLocation(114, 16);
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

			DebugLocation(114, 53);
			PushFollow(Follow._add_in_synpred35_MathLang922);
			add();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred35_MathLang_fragment", 86);
			LeaveRule("synpred35_MathLang_fragment", 86);
			Leave_synpred35_MathLang_fragment();
		}
	}
	// $ANTLR end synpred35_MathLang

	partial void Enter_synpred44_MathLang_fragment();
	partial void Leave_synpred44_MathLang_fragment();

	// $ANTLR start synpred44_MathLang
	public void synpred44_MathLang_fragment()
	{
		Enter_synpred44_MathLang_fragment();
		EnterRule("synpred44_MathLang_fragment", 95);
		TraceIn("synpred44_MathLang_fragment", 95);
		try
		{
			// MathLang.g:126:22: ( OPEN_BRACE boolterm CLOSE_BRACE )
			DebugEnterAlt(1);
			// MathLang.g:126:22: OPEN_BRACE boolterm CLOSE_BRACE
			{
			DebugLocation(126, 22);
			Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_synpred44_MathLang1082); if (state.failed) return;
			DebugLocation(126, 34);
			PushFollow(Follow._boolterm_in_synpred44_MathLang1085);
			boolterm();
			PopFollow();
			if (state.failed) return;
			DebugLocation(126, 43);
			Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_synpred44_MathLang1087); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred44_MathLang_fragment", 95);
			LeaveRule("synpred44_MathLang_fragment", 95);
			Leave_synpred44_MathLang_fragment();
		}
	}
	// $ANTLR end synpred44_MathLang

	partial void Enter_synpred49_MathLang_fragment();
	partial void Leave_synpred49_MathLang_fragment();

	// $ANTLR start synpred49_MathLang
	public void synpred49_MathLang_fragment()
	{
		Enter_synpred49_MathLang_fragment();
		EnterRule("synpred49_MathLang_fragment", 100);
		TraceIn("synpred49_MathLang_fragment", 100);
		try
		{
			// MathLang.g:131:79: ( ELSE ( block | statement ) )
			DebugEnterAlt(1);
			// MathLang.g:131:79: ELSE ( block | statement )
			{
			DebugLocation(131, 79);
			Match(input,ELSE,Follow._ELSE_in_synpred49_MathLang1141); if (state.failed) return;
			DebugLocation(131, 85);
			// MathLang.g:131:85: ( block | statement )
			int alt40=2;
			try { DebugEnterSubRule(40);
			try { DebugEnterDecision(40, decisionCanBacktrack[40]);
			int LA40_0 = input.LA(1);

			if ((LA40_0==66))
			{
				alt40=1;
			}
			else if ((LA40_0==IF||LA40_0==FOR||(LA40_0>=RETURN && LA40_0<=DO)||(LA40_0>=ID && LA40_0<=TYPE)||LA40_0==KNEW))
			{
				alt40=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				NoViableAltException nvae = new NoViableAltException("", 40, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(40); }
			switch (alt40)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:131:86: block
				{
				DebugLocation(131, 86);
				PushFollow(Follow._block_in_synpred49_MathLang1145);
				block();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:131:94: statement
				{
				DebugLocation(131, 94);
				PushFollow(Follow._statement_in_synpred49_MathLang1149);
				statement();
				PopFollow();
				if (state.failed) return;

				}
				break;

			}
			} finally { DebugExitSubRule(40); }


			}

		}
		finally
		{
			TraceOut("synpred49_MathLang_fragment", 100);
			LeaveRule("synpred49_MathLang_fragment", 100);
			Leave_synpred49_MathLang_fragment();
		}
	}
	// $ANTLR end synpred49_MathLang
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
	DFA15 dfa15;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa5 = new DFA5( this );
		dfa8 = new DFA8( this, SpecialStateTransition8 );
		dfa15 = new DFA15( this, SpecialStateTransition15 );
	}

	private class DFA5 : DFA
	{
		private const string DFA5_eotS =
			"\xB\xFFFF";
		private const string DFA5_eofS =
			"\xB\xFFFF";
		private const string DFA5_minS =
			"\x1\x7\x1\xFFFF\x1\x28\x8\xFFFF";
		private const string DFA5_maxS =
			"\x1\x3B\x1\xFFFF\x1\x3C\x8\xFFFF";
		private const string DFA5_acceptS =
			"\x1\xFFFF\x1\x1\x1\xFFFF\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x1\x9\x1\x2\x1"+
			"\x8";
		private const string DFA5_specialS =
			"\xB\xFFFF}>";
		private static readonly string[] DFA5_transitionS =
			{
				"\x1\x3\x1\xFFFF\x1\x6\x1\xFFFF\x1\x7\x1\x4\x1\x5\x14\xFFFF\x1\x2\x1"+
				"\x1\x17\xFFFF\x1\x8",
				"",
				"\x1\xA\x1\x9\xA\xFFFF\x1\xA\x7\xFFFF\x1\x9",
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

		public override string Description { get { return "66:12: ( declaration | assignment | ifstatement | whilestatement | dowhilestatement | forstatement | returnstatement | funccall | newexpression )"; } }

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
			"\x1\x22\x1\xFFFF\x1\x0\x1\xFFFF\x1\x0\x2\xFFFF\x3\x0\x2\xFFFF";
		private const string DFA8_maxS =
			"\x1\x3B\x1\xFFFF\x1\x0\x1\xFFFF\x1\x0\x2\xFFFF\x3\x0\x2\xFFFF";
		private const string DFA8_acceptS =
			"\x1\xFFFF\x1\x1\x1\xFFFF\x1\x3\x6\xFFFF\x1\x2\x1\x4";
		private const string DFA8_specialS =
			"\x2\xFFFF\x1\x0\x1\xFFFF\x1\x1\x2\xFFFF\x1\x2\x1\x3\x1\x4\x2\xFFFF}>";
		private static readonly string[] DFA8_transitionS =
			{
				"\x1\x2\x3\xFFFF\x1\x8\x1\x9\x3\xFFFF\x1\x7\x8\xFFFF\x1\x4\x3\xFFFF"+
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

		public override string Description { get { return "88:1: expression : ( newexpression | funccallbody | boolexpression | mathexpression );"; } }

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
	private class DFA15 : DFA
	{
		private const string DFA15_eotS =
			"\xA\xFFFF";
		private const string DFA15_eofS =
			"\x1\x2\x9\xFFFF";
		private const string DFA15_minS =
			"\x1\x2E\x1\x0\x8\xFFFF";
		private const string DFA15_maxS =
			"\x1\x45\x1\x0\x8\xFFFF";
		private const string DFA15_acceptS =
			"\x2\xFFFF\x1\x2\x1\xFFFF\x1\x1\x5\xFFFF";
		private const string DFA15_specialS =
			"\x1\xFFFF\x1\x0\x8\xFFFF}>";
		private static readonly string[] DFA15_transitionS =
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

		private static readonly short[] DFA15_eot = DFA.UnpackEncodedString(DFA15_eotS);
		private static readonly short[] DFA15_eof = DFA.UnpackEncodedString(DFA15_eofS);
		private static readonly char[] DFA15_min = DFA.UnpackEncodedStringToUnsignedChars(DFA15_minS);
		private static readonly char[] DFA15_max = DFA.UnpackEncodedStringToUnsignedChars(DFA15_maxS);
		private static readonly short[] DFA15_accept = DFA.UnpackEncodedString(DFA15_acceptS);
		private static readonly short[] DFA15_special = DFA.UnpackEncodedString(DFA15_specialS);
		private static readonly short[][] DFA15_transition;

		static DFA15()
		{
			int numStates = DFA15_transitionS.Length;
			DFA15_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA15_transition[i] = DFA.UnpackEncodedString(DFA15_transitionS[i]);
			}
		}

		public DFA15( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 15;
			this.eot = DFA15_eot;
			this.eof = DFA15_eof;
			this.min = DFA15_min;
			this.max = DFA15_max;
			this.accept = DFA15_accept;
			this.special = DFA15_special;
			this.transition = DFA15_transition;
		}

		public override string Description { get { return "114:14: ( ( GREQ | LSEQ | NEQ | EQ | GR | LS ) add )?"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition15(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA15_1 = input.LA(1);


				int index15_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred35_MathLang_fragment)) ) {s = 4;}

				else if ( (true) ) {s = 2;}


				input.Seek(index15_1);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 15, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}

	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _class_list_in_execute369 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_execute371 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MODIFIER_in_class_declaration390 = new BitSet(new ulong[]{0x80000000UL});
		public static readonly BitSet _CLASS_WORD_in_class_declaration392 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _ID_in_class_declaration394 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _class_block_in_class_declaration396 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _66_in_class_block414 = new BitSet(new ulong[]{0x200000000UL,0x8UL});
		public static readonly BitSet _static_func_or_var_declaration_in_class_block417 = new BitSet(new ulong[]{0x200000000UL,0x8UL});
		public static readonly BitSet _67_in_class_block420 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _static_declaration_in_static_func_or_var_declaration439 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funcdeclaration_in_static_func_or_var_declaration443 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _class_declaration_in_class_list452 = new BitSet(new ulong[]{0x200000002UL});
		public static readonly BitSet _funcdeclaration_in_func_list462 = new BitSet(new ulong[]{0x200000002UL});
		public static readonly BitSet _declaration_in_statement483 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assignment_in_statement489 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ifstatement_in_statement494 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _whilestatement_in_statement499 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _dowhilestatement_in_statement504 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _forstatement_in_statement509 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _returnstatement_in_statement514 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccall_in_statement519 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _newexpression_in_statement524 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_type538 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_array_type545 = new BitSet(new ulong[]{0x1000000000UL});
		public static readonly BitSet _ARRAY_DECLARATION_MARK_in_array_type547 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_any_type554 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_type_in_any_type558 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _VOID_in_any_type562 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NUMBER_in_number570 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_number576 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_number582 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CHAR_in_number588 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrayelement_in_number594 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _term_in_mathexpression600 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _newexpression_in_expression614 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_expression620 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolexpression_in_expression626 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathexpression_in_expression632 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _id_in_extended_id645 = new BitSet(new ulong[]{0x10000000002UL});
		public static readonly BitSet _DOT_in_extended_id648 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _extended_id_in_extended_id651 = new BitSet(new ulong[]{0x10000000002UL});
		public static readonly BitSet _ID_in_id669 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_arrayelement677 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _OPEN_SQUARE_BRACE_in_arrayelement679 = new BitSet(new ulong[]{0xC400000000UL});
		public static readonly BitSet _number_in_arrayelement681 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _CLOSE_SQUARE_BRACE_in_arrayelement683 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MODIFIER_in_static_declaration701 = new BitSet(new ulong[]{0x800000000UL});
		public static readonly BitSet _declaration_in_static_declaration703 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declarationbody_in_declaration717 = new BitSet(new ulong[]{0x0UL,0x10UL});
		public static readonly BitSet _68_in_declaration719 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _longdeclaration_in_declaration727 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_declarationbody735 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _ID_in_declarationbody737 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_type_in_declarationbody758 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _ID_in_declarationbody760 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _longdeclarationbody_in_longdeclaration782 = new BitSet(new ulong[]{0x0UL,0x10UL});
		public static readonly BitSet _68_in_longdeclaration784 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_longdeclarationbody793 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _ID_in_longdeclarationbody795 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _ASSIGN_in_longdeclarationbody797 = new BitSet(new ulong[]{0xF1008C400000000UL});
		public static readonly BitSet _expression_in_longdeclarationbody799 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_type_in_longdeclarationbody823 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _ID_in_longdeclarationbody825 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _ASSIGN_in_longdeclarationbody827 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _newexpression_in_longdeclarationbody829 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mul_in_add849 = new BitSet(new ulong[]{0xC0000000002UL});
		public static readonly BitSet _set_in_add853 = new BitSet(new ulong[]{0x71008C400000000UL});
		public static readonly BitSet _mul_in_add862 = new BitSet(new ulong[]{0xC0000000002UL});
		public static readonly BitSet _group_in_mul871 = new BitSet(new ulong[]{0x300000000002UL});
		public static readonly BitSet _set_in_mul875 = new BitSet(new ulong[]{0x71008C400000000UL});
		public static readonly BitSet _group_in_mul884 = new BitSet(new ulong[]{0x300000000002UL});
		public static readonly BitSet _add_in_compare892 = new BitSet(new ulong[]{0xFC00000000002UL});
		public static readonly BitSet _set_in_compare896 = new BitSet(new ulong[]{0x71008C400000000UL});
		public static readonly BitSet _add_in_compare922 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _add_in_term933 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _SUB_in_group940 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_group945 = new BitSet(new ulong[]{0xF1008C400000000UL});
		public static readonly BitSet _term_in_group948 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_group950 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _number_in_group955 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assignmentbody_in_assignment962 = new BitSet(new ulong[]{0x0UL,0x10UL});
		public static readonly BitSet _68_in_assignment964 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_assignmentbody972 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _ASSIGN_in_assignmentbody974 = new BitSet(new ulong[]{0xF1008C400000000UL});
		public static readonly BitSet _expression_in_assignmentbody976 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrayelement_in_assignmentbody995 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _ASSIGN_in_assignmentbody997 = new BitSet(new ulong[]{0xF1008C400000000UL});
		public static readonly BitSet _expression_in_assignmentbody999 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolterm_in_boolexpression1017 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _or_in_boolterm1024 = new BitSet(new ulong[]{0x3000000000002UL});
		public static readonly BitSet _set_in_boolterm1028 = new BitSet(new ulong[]{0x71008C400000000UL});
		public static readonly BitSet _or_in_boolterm1037 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _and_in_or1046 = new BitSet(new ulong[]{0x40000000000002UL});
		public static readonly BitSet _OR_in_or1049 = new BitSet(new ulong[]{0x71008C400000000UL});
		public static readonly BitSet _and_in_or1052 = new BitSet(new ulong[]{0x40000000000002UL});
		public static readonly BitSet _boolgroup_in_and1060 = new BitSet(new ulong[]{0x80000000000002UL});
		public static readonly BitSet _AND_in_and1063 = new BitSet(new ulong[]{0x71008C400000000UL});
		public static readonly BitSet _boolgroup_in_and1066 = new BitSet(new ulong[]{0x80000000000002UL});
		public static readonly BitSet _NOT_in_boolgroup1075 = new BitSet(new ulong[]{0x71008C400000000UL});
		public static readonly BitSet _OPEN_BRACE_in_boolgroup1082 = new BitSet(new ulong[]{0x71008C400000000UL});
		public static readonly BitSet _boolterm_in_boolgroup1085 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_boolgroup1087 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolvar_in_boolgroup1092 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TRUE_in_boolvar1100 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FALSE_in_boolvar1106 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _compare_in_boolvar1112 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_ifstatement1121 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_ifstatement1124 = new BitSet(new ulong[]{0x71008C400000000UL});
		public static readonly BitSet _boolexpression_in_ifstatement1127 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_ifstatement1129 = new BitSet(new ulong[]{0x80000CC00003A80UL,0x4UL});
		public static readonly BitSet _block_in_ifstatement1133 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement1137 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _ELSE_in_ifstatement1141 = new BitSet(new ulong[]{0x80000CC00003A80UL,0x4UL});
		public static readonly BitSet _block_in_ifstatement1145 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _statement_in_ifstatement1149 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _WHILE_in_whilestatement1159 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_whilestatement1162 = new BitSet(new ulong[]{0x71008C400000000UL});
		public static readonly BitSet _boolexpression_in_whilestatement1165 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_whilestatement1167 = new BitSet(new ulong[]{0x80000CC00003A80UL,0x4UL});
		public static readonly BitSet _block_in_whilestatement1171 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_whilestatement1175 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_forstatement1182 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_forstatement1185 = new BitSet(new ulong[]{0x800000000UL});
		public static readonly BitSet _longdeclarationbody_in_forstatement1188 = new BitSet(new ulong[]{0x0UL,0x10UL});
		public static readonly BitSet _68_in_forstatement1190 = new BitSet(new ulong[]{0x71008C400000000UL});
		public static readonly BitSet _boolexpression_in_forstatement1193 = new BitSet(new ulong[]{0x0UL,0x10UL});
		public static readonly BitSet _68_in_forstatement1195 = new BitSet(new ulong[]{0xC400000000UL});
		public static readonly BitSet _assignmentbody_in_forstatement1198 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_forstatement1200 = new BitSet(new ulong[]{0x80000CC00003A80UL,0x4UL});
		public static readonly BitSet _block_in_forstatement1204 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_forstatement1208 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _RETURN_in_returnstatement1215 = new BitSet(new ulong[]{0xF1008C400000000UL});
		public static readonly BitSet _expression_in_returnstatement1218 = new BitSet(new ulong[]{0x0UL,0x10UL});
		public static readonly BitSet _68_in_returnstatement1220 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DO_in_dowhilestatement1228 = new BitSet(new ulong[]{0x80000CC00003A80UL,0x4UL});
		public static readonly BitSet _block_in_dowhilestatement1232 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _statement_in_dowhilestatement1236 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _WHILE_in_dowhilestatement1239 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_dowhilestatement1242 = new BitSet(new ulong[]{0x71008C400000000UL});
		public static readonly BitSet _boolexpression_in_dowhilestatement1245 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_dowhilestatement1247 = new BitSet(new ulong[]{0x0UL,0x10UL});
		public static readonly BitSet _68_in_dowhilestatement1250 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MODIFIER_in_funcdeclaration1259 = new BitSet(new ulong[]{0x2800000000UL});
		public static readonly BitSet _any_type_in_funcdeclaration1261 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _ID_in_funcdeclaration1263 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_funcdeclaration1268 = new BitSet(new ulong[]{0x20000800000000UL});
		public static readonly BitSet _paramsdeclaration_in_funcdeclaration1271 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_funcdeclaration1274 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _block_in_funcdeclaration1279 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declarationbody_in_paramsdeclaration1312 = new BitSet(new ulong[]{0x2UL,0x20UL});
		public static readonly BitSet _69_in_paramsdeclaration1316 = new BitSet(new ulong[]{0x800000000UL});
		public static readonly BitSet _declarationbody_in_paramsdeclaration1319 = new BitSet(new ulong[]{0x2UL,0x20UL});
		public static readonly BitSet _extended_id_in_funccallbody1344 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_funccallbody1347 = new BitSet(new ulong[]{0xF3008C400000000UL});
		public static readonly BitSet _expressioncommalist_in_funccallbody1349 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_funccallbody1352 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funccallbody_in_funccall1373 = new BitSet(new ulong[]{0x0UL,0x10UL});
		public static readonly BitSet _68_in_funccall1375 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_expressioncommalist1382 = new BitSet(new ulong[]{0x2UL,0x20UL});
		public static readonly BitSet _69_in_expressioncommalist1386 = new BitSet(new ulong[]{0xF1008C400000000UL});
		public static readonly BitSet _expression_in_expressioncommalist1389 = new BitSet(new ulong[]{0x2UL,0x20UL});
		public static readonly BitSet _66_in_object_initializer1401 = new BitSet(new ulong[]{0xF1008C400000000UL});
		public static readonly BitSet _expressioncommalist_in_object_initializer1403 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _67_in_object_initializer1405 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _KNEW_in_newexpression1420 = new BitSet(new ulong[]{0x800000000UL});
		public static readonly BitSet _initializer_in_newexpression1423 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _simple_var_initializer_in_initializer1430 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_initializer_in_initializer1434 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_simple_var_initializer1441 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _OPEN_BRACE_in_simple_var_initializer1443 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_simple_var_initializer1445 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_in_array_initializer1459 = new BitSet(new ulong[]{0x1000001000000000UL});
		public static readonly BitSet _OPEN_SQUARE_BRACE_in_array_initializer1463 = new BitSet(new ulong[]{0xC400000000UL});
		public static readonly BitSet _number_in_array_initializer1465 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _CLOSE_SQUARE_BRACE_in_array_initializer1467 = new BitSet(new ulong[]{0x2UL,0x4UL});
		public static readonly BitSet _ARRAY_DECLARATION_MARK_in_array_initializer1472 = new BitSet(new ulong[]{0x2UL,0x4UL});
		public static readonly BitSet _object_initializer_in_array_initializer1475 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _66_in_block1497 = new BitSet(new ulong[]{0x80000CC00003A80UL,0xCUL});
		public static readonly BitSet _statementlist_in_block1500 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _67_in_block1502 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_statementlist1510 = new BitSet(new ulong[]{0x80000CC00003A82UL,0x4UL});
		public static readonly BitSet _funccallbody_in_synpred20_MathLang620 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolexpression_in_synpred21_MathLang626 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DOT_in_synpred22_MathLang648 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _extended_id_in_synpred22_MathLang651 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_synpred35_MathLang896 = new BitSet(new ulong[]{0x71008C400000000UL});
		public static readonly BitSet _add_in_synpred35_MathLang922 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _OPEN_BRACE_in_synpred44_MathLang1082 = new BitSet(new ulong[]{0x71008C400000000UL});
		public static readonly BitSet _boolterm_in_synpred44_MathLang1085 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_synpred44_MathLang1087 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ELSE_in_synpred49_MathLang1141 = new BitSet(new ulong[]{0x80000CC00003A80UL,0x4UL});
		public static readonly BitSet _block_in_synpred49_MathLang1145 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _statement_in_synpred49_MathLang1149 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  MathLang 

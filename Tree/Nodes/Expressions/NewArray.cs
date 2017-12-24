using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Expressions
{
    public class NewArray : IExpression, IStatement
    {
        public INode Parent { get; set; }
        public Scope Scope { get; }

        public ReturnType ReturnType { get; set; }
        public ReturnType CastToType { get; set; }
        public IExpression ArraySize { get; private set; }
        public List<IExpression> InitializationParameters { get; } = new List<IExpression>();
        public ReturnType InnerElementsReturnType => ReturnType.CastTo<ArrayReturnType>().InnerType;
        
        public NewArray(INode parent, Scope parentScope)
        {
            Parent = parent;
            Scope = parentScope;
        }

        public void Construct(CommonTree syntaxArrayInitializer)
        {
            var simpleReturnType = TreeHelper.GetReturnType(syntaxArrayInitializer.GetChild(0).Text);
            ReturnType = ReturnType.ArrayOf(simpleReturnType);
            
            
            //ArraySize
            var syntaxArraySize = syntaxArrayInitializer.GetChild(1).CastTo<CommonTree>();
            if (syntaxArraySize.ChildCount > 0)
            {
                var syntaxArraySizeExpression = syntaxArraySize.GetChild(0).CastTo<CommonTree>();
                ArraySize = TreeHelper.GetExpression(this, Scope, syntaxArraySizeExpression);
                ArraySize.Construct(syntaxArraySizeExpression);
            }

            //ArrayInitializationParameters
            var syntaxArrayInitializationParameters = syntaxArrayInitializer.GetChild(2).CastTo<CommonTree>();
            if (syntaxArrayInitializationParameters.ChildCount > 0)
            {
                syntaxArrayInitializationParameters.Children.Cast<CommonTree>()
                    .ForEach(syntaxArrayInitializationParameter =>
                    {
                        var parameterExpression =
                            TreeHelper.GetExpression(this, Scope, syntaxArrayInitializationParameter);
                        InitializationParameters.Add(parameterExpression);
                        parameterExpression.Construct(syntaxArrayInitializationParameter);
                    });
            }


        }
    }
}
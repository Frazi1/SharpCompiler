using MathLang.Tree.Nodes.Declarations;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Statements;

namespace MathLang.Tree.Semantics
{
    public static class LibraryClasses
    {
        public static FunctionDeclaration BuildFunctionDeclaration(ClassDeclaration parentClass,string name, ReturnType returnType,
            params (string name, ReturnType returnType)[] paramTuples)
        {
            var funcDeclaration = new FunctionDeclaration(parentClass, parentClass.Scope)
            {
                Name = name,
                ReturnType = returnType
            };
            foreach (var paramTuple in paramTuples)
            {
                var paramDeclaration =
                    new FunctionDeclarationParameter(funcDeclaration, funcDeclaration.Scope)
                    {
                        Name = paramTuple.name,
                        ReturnType = paramTuple.returnType
                    };
                funcDeclaration.ParameterNodes.Add(paramDeclaration);
            }
            funcDeclaration.StatemenBlock = new BlockStatement(funcDeclaration, funcDeclaration.Scope);
            return funcDeclaration;
        }

        public static ClassDeclaration BuildClassDeclaration(Nodes.Program program, string name)
        {
            var classDeclaration = new ClassDeclaration(program, program.Scope) {Name = name};
            return classDeclaration;
        }
    }
}
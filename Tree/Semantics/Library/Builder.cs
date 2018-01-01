using MathLang.Tree.Nodes.Declarations;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Expressions;
using MathLang.Tree.Nodes.Statements;

namespace MathLang.Tree.Semantics
{
    public static class LibraryClasses
    {
        public static FunctionDeclaration BuildFunctionDeclaration(ClassDeclaration parentClass,string name, TypeDefinition typeDefinition,
            params (string name, TypeDefinition returnType)[] paramTuples)
        {
            var funcDeclaration = new FunctionDeclaration(parentClass, parentClass.Scope)
            {
                Name = name,
                TypeDefinition = typeDefinition
            };
            foreach (var paramTuple in paramTuples)
            {
                var paramDeclaration =
                    new FunctionVariableDeclarationParameter(funcDeclaration, funcDeclaration.Scope)
                    {
                        Name = paramTuple.name,
                        TypeDefinition = paramTuple.returnType
                    };
                funcDeclaration.ParameterNodes.Add(paramDeclaration);
            }
            funcDeclaration.StatementBlock = new BlockStatement(funcDeclaration, funcDeclaration.Scope);
            if (funcDeclaration.TypeDefinition != TypeDefinition.Void)
            {
                var returnStatement = new ReturnStatement(funcDeclaration, funcDeclaration.Scope);
                returnStatement.ReturnExpression = new CharExpression(returnStatement, returnStatement.Scope);
                returnStatement.ReturnExpression.TypeDefinition = typeDefinition;
                funcDeclaration.StatementBlock.Statements.Add(returnStatement);
            }
            return funcDeclaration;
        }

        public static ClassDeclaration BuildClassDeclaration(Nodes.Program program, string name)
        {
            var classDeclaration = new ClassDeclaration(program, program.Scope, false) {Name = name};
            return classDeclaration;
        }
    }
}
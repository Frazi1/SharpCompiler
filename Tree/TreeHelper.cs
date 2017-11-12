using System.Collections.Generic;
using System.Linq;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes;

namespace MathLang.Tree
{
    public static class TreeHelper
    {
        public static Nodes.Program GetAstTree(CommonTree program)
        {
            List<ClassNode> classNodes = program.Children
                .Cast<CommonTree>()
                .Select(GetClass)
                .ToList();
            Nodes.Program astProgram = new Nodes.Program(classNodes);
            return astProgram;
        }

        private static ClassNode GetClass(CommonTree classCommonTree)
        {
            List<CommonTree> syntaxClassChildrenNodes = classCommonTree.Children
                //0 children is class name
                .Skip(1)
                .Cast<CommonTree>()
                .ToList();

            List<VariableDeclaration> variableDeclarations =
                GetVariableDeclarationsFromStaticDeclaration(syntaxClassChildrenNodes);

            List<FunctionDeclaration> functionDeclarations =
                GetFunctionDeclarationsFromClassNodeChildren(syntaxClassChildrenNodes);
            var classNode = new ClassNode(
                name: classCommonTree.GetChild(0).Text,
                varDeclarationNodes: variableDeclarations,
                functionDeclarationNodes: functionDeclarations
            );
            return classNode;
        }

        private static List<FunctionDeclaration> GetFunctionDeclarationsFromClassNodeChildren(IEnumerable<CommonTree> syntaxClassChildrenNodes)
        {
            throw new System.NotImplementedException();
        }

        private static List<VariableDeclaration> GetVariableDeclarationsFromStaticDeclaration(IEnumerable<CommonTree> syntaxClassChildrenNodes)
        {
            throw new System.NotImplementedException();
        }
    }
}
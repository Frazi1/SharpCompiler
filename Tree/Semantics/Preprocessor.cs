using System;
using System.Collections.Generic;
using System.Linq;
using MathLang.Tree.Nodes.Declarations;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Expressions;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Nodes.Statements;
using MathLang.Tree.Scopes.Exceptions;
using MathLang.Extensions;
using MathLang.Tree.Nodes;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Semantics
{
    public static class Preprocessor
    {
        private const string MainClassName = "Main";
        private const string MainFuncName = "Main";

        #region PreProcss

        public static void PreProcess(this Nodes.Program program)
        {
            var scope = program.Scope;
            FunctionDeclaration mainFunction = null;
            program.ClassNodes.ForEach(classDeclaration =>
            {
                classDeclaration.CheckName(scope);
                scope.AddClass(classDeclaration);
                classDeclaration.PreProcess();

                //FunctionDeclaration func = classDeclaration.Scope.LocalFunctionSearch(MainClassName);
                //if(func != null && classDeclaration.IsStatic)
                //    throw new ScopeException("Main function must be declared inside of a non static class");
                //if(func != null && mainFunction != null)
                //    throw new ScopeException("Only 1 Main function can be present");
                //mainFunction = func ?? mainFunction;
            });
            CheckMainClass(program);
            //if(mainFunction == null)
            //    throw new ScopeException("Program must contain a Main function which is an entry point");
        }

        private static void PreProcess(this ClassDeclaration classDeclaration)
        {
            var scope = classDeclaration.Scope;

            var duplicatedModifiers = classDeclaration.ModifiersList
                .GetDuplicatedItems().ToList();
            if (duplicatedModifiers.Any())
                throw new ScopeException($"Modifier {duplicatedModifiers.First()} was specified more than once");

            classDeclaration.ModifiersList.ForEach(modifier =>
            {
                if (modifier == Modifier.Static) classDeclaration.IsStatic = true;
                if (modifier == Modifier.Extern) classDeclaration.IsExtern = true;
            });

            if (classDeclaration.Name != MainClassName)
            {
                if (!classDeclaration.IsStatic && !classDeclaration.IsAttribute)
                    throw new ScopeException(
                        $"Only static classes are supported at the moment ({classDeclaration.Name})");
            }
            classDeclaration.FunctionDeclarationNodes
                .ForEach(functionDeclaration =>
                {
                    functionDeclaration.CheckName(scope);
                    scope.AddFunction(functionDeclaration);
                    functionDeclaration.PreProcess();
                });

            classDeclaration.VarDeclarationNodes
                .ForEach(declaration =>
                {
                    declaration.CheckName(scope);
                    scope.AddVariable(declaration);
                });
        }

        private static void PreProcess(this FunctionDeclaration functionDeclaration)
        {
            
            functionDeclaration.ParameterNodes
                .ForEach(parameter =>
                {
                    parameter.CheckName(functionDeclaration.Scope);
                    functionDeclaration.Scope.AddVariable(parameter);
                });
        }

        private static void CheckMainClass(this Nodes.Program program)
        {
            var mainClass = program.Scope.LocalClassSearch(MainClassName);
            if (mainClass == null)
                throw new ScopeException("Program must contain a non-static class\"Main\"");
            var mainFunc = mainClass.Scope.LocalFunctionSearch(MainFuncName);
            if (mainFunc == null)
                throw new ScopeException("Program must contain a \"Main\" function inside of Main class");
        }

        #endregion

        #region Process

        public static void Process(this Nodes.Program program)
        {
            program.ClassNodes.ForEach(Process);
        }

        #region Declarations

        private static void Process(this ClassDeclaration classDeclaration)
        {
            classDeclaration.FunctionDeclarationNodes.ForEach(Process);
            classDeclaration.VarDeclarationNodes.ForEach(declaration => declaration.Process(false));
        }

        //private static void Process(this Declaration declaration, bool checkName)
        //{
        //    switch (declaration)
        //    {
        //        case VariableDeclaration variableDeclaration:
        //            variableDeclaration.Process(checkName);
        //            break;
        //        case ArrayDeclaration arrayDeclaration:
        //            arrayDeclaration.Process();
        //            break;
        //    }
        //}

        private static void Process(this ArrayDeclaration arrayDeclaration)
        {
            //            throw  new NotImplementedException();
        }

        private static void Process(this Declaration variableDeclaration, bool checkName = true, int? upTpLevel = null)
        {
            //Process assignment value
            if (checkName)
            {
                //variableDeclaration.CheckName(variableDeclaration.Scope);
                if (variableDeclaration.Scope.GlobalVariableSearch(
                        variableDeclaration.Name, Scope.FunctionLevel)
                    != null)
                    throw new ScopeException($"Variable with name: \"{variableDeclaration.Name}\" already exists");
            }
            IExpression variableDeclarationValueExpression = variableDeclaration.Value;
            if (variableDeclarationValueExpression == null) return;
            variableDeclarationValueExpression.Process();
            if (variableDeclaration.ReturnType == variableDeclarationValueExpression.ReturnType) return;
            if (variableDeclarationValueExpression.ReturnType.IsCastableTo(variableDeclaration.ReturnType))
            {
                variableDeclarationValueExpression.CastToType = variableDeclaration.ReturnType;
            }
            else
            {
                throw new ScopeException(
                    $"Variable \"{variableDeclaration.Name}\" return type {variableDeclaration.ReturnType} is different from {variableDeclarationValueExpression.ReturnType} ");
            }
            if (checkName)
            {
                variableDeclaration.Scope.AddVariable(variableDeclaration);
            }
        }

        private static void Process(this FunctionDeclaration functionDeclaration)
        {
            functionDeclaration.ModifiersList.ForEach(modifier =>
            {
                switch (modifier)
                {
                    case Modifier.Static:
                        if (functionDeclaration.IsStatic)
                            throw new ScopeException($"Modifier {modifier} is used more than one time");
                        functionDeclaration.IsStatic = true;
                        break;
                    case Modifier.Extern:
                        if (functionDeclaration.IsExternal)
                            throw new ScopeException($"Modifier {modifier} is used more than one time");
                        functionDeclaration.IsExternal = true;
                        break;
                }
            });

            if (functionDeclaration.IsExternal)
            {
                if (functionDeclaration.StatementBlock != null)
                {
                    throw new ScopeException(
                        $"Extern function {functionDeclaration.Name} can not have a declaration body");
                }
            }
            else
            {
                var scope = functionDeclaration.Scope;
                functionDeclaration.StatementBlock.Statements
                    .ForEach(statement => statement.Process());

                if (functionDeclaration.ReturnType != ReturnType.Void)
                {
                    var returnStatements =
                        functionDeclaration.StatementBlock.Statements
                            .FindAll(statement => statement is ReturnStatement)
                            .Cast<ReturnStatement>()
                            .ToList();
                    if (returnStatements.Count == 0)
                        throw new ExpressionException(
                            $"Function {functionDeclaration.Name} missing a return statement");
                    returnStatements.ForEach(statement =>
                    {
                        //statement.Process();
                        if (statement.ReturnExpression.GetResultReturnType() != functionDeclaration.ReturnType)
                        {
                            throw new ExpressionException(
                                $"Function {functionDeclaration.Name} must return {functionDeclaration.ReturnType} but returns {statement.ReturnExpression.GetResultReturnType()}");
                        }
                    });
                }
            }
            functionDeclaration.AttributeUsages.ForEach(ProcessAttributeUsage);
        }

        #endregion


        #region Expressions

        private static void Process(this IExpression iexpression)
        {
            switch (iexpression)
            {
                case ExtendedId extendedId:
                    extendedId.Process();
                    break;
                case VariableReference variableReference:
                    variableReference.Process();
                    break;
                case Expression expression:
                    expression.Process();
                    break;
                case Atom atom:
                    atom.Process();
                    break;
                case FunctionCall functionCall:
                    functionCall.Process();
                    break;
                case NewArray newArray:
                    newArray.Process();
                    break;
                case ArrayElementReference arrayElementReference:
                    arrayElementReference.Process();
                    break;
                default: throw new ArgumentOutOfRangeException(nameof(iexpression));
            }
        }

        private static void Process(this ExtendedId extendedId, bool isVariable = true)
        {
            var scope = extendedId.Scope;
            if (isVariable)
            {
                var declaration = scope.GlobalVariableSearch(extendedId.Name);
                extendedId.Declaration = declaration;
                extendedId.ReturnType = declaration != null
                    ? declaration.ReturnType
                    : throw new ScopeException($"Variable with name \"{extendedId.Name}\" does not exist.");
            }
            else
            {
                FunctionDeclaration declaration = scope.GlobalFunctionSearch(extendedId.Name);
                extendedId.ReturnType = declaration != null
                    ? declaration.ReturnType
                    : throw new ScopeException($"Variable with name \"{extendedId.Name}\" does not exist.");
            }
        }

        private static void Process(this VariableReference variableReference)
        {
            throw new NotImplementedException("var ref");
            var scope = variableReference.Scope;
            var name = variableReference.Name.Name;
            var globalVariableSearchResult = scope.GlobalVariableSearch(name);
            if (globalVariableSearchResult == null)
                throw new ScopeException($"Variable with name \"{name}\" does not exist.");
            variableReference.ReturnType = globalVariableSearchResult.ReturnType;
        }

        private static void Process(this Expression expression)
        {
            expression.Left.Process();
            expression.Right?.Process();

            var expressionType = expression.ExpressionType;


            if (TreeHelper.IsComparisonExpression(expressionType))
                expression.ReturnType = ReturnType.Bool;

            //HERE


            if (expression.Right == null)
            {
                expression.ReturnType = expression.Left.ReturnType;
                //if (expression.ReturnType == expression.Left.ReturnType) return;
                //if (expression.Left.ReturnType.IsCastableTo(expression.ReturnType))
                //    expression.Left.CastToType = expression.ReturnType;
                //else
                //    throw new ExpressionException(
                //        $"Return type {expression.Left.ReturnType} does not match {expression.ReturnType}");
            }

            else if (TreeHelper.IsComparisonExpression(expressionType))
            {
                expression.ReturnType = ReturnType.Bool;

                if (TreeHelper.IsMathematicalComparison(expressionType))
                {
                    if (expression.Left.GetResultReturnType() != expression.Right.GetResultReturnType())
                    {
                        if (expression.Right.GetResultReturnType()
                            .IsCastableTo(expression.Left.GetResultReturnType()))
                        {
                            expression.Right.CastToType = expression.Left.GetResultReturnType();
                        }
                        else
                            throw new ExpressionException(
                                $"Can not compare {expression.Left.GetResultReturnType()} to {expression.Right.GetResultReturnType()} ");
                        if (!expression.Left
                            .GetResultReturnType()
                            .IsMathematicallyComparisonable())
                            throw new ExpressionException(
                                $"Can not apply operation {expression.ExpressionType} to types {expression.Left.GetResultReturnType()}");
                    }
                }
                if (TreeHelper.IsBooleanComparison(expressionType))
                {
                    if (expression.Left.GetResultReturnType() != ReturnType.Bool)
                        throw new ExpressionException($"Left operand must be of type {ReturnType.Bool}");
                    if (expression.Right.GetResultReturnType() != ReturnType.Bool)
                        throw new ExpressionException($"Right operand must be of type {ReturnType.Bool}");
                }
            }

            else if (expression.Left.ReturnType != expression.Right.ReturnType)
                if (expression.Right.ReturnType.IsCastableTo(expression.Left.ReturnType))
                {
                    expression.ReturnType = expression.Left.ReturnType;
                    expression.Right.CastToType = expression.Left.ReturnType;
                }
                else
                    throw new ExpressionException(
                        $"Can not cast {expression.Left.ReturnType} to type {expression.Right.ReturnType}");
            else
                expression.ReturnType = expression.Left.ReturnType;
        }

        private static void Process(this Atom atom)
        {
            //Nothing to do now
            //throw new InvalidOperationException("atom");
        }

        private static void Process(this FunctionCall functionCall)
        {
            //functionCall.Name.Process();
            var functionDeclaration = functionCall.Scope.GlobalFunctionSearch(functionCall.ExtendedId.Name);
            if (functionDeclaration == null)
                throw new ScopeException($"Function with name \"{functionCall.ExtendedId.Name}\" does not exist");
            
            CheckCallParameters(functionCall,functionCall.FunctionCallParameters, functionDeclaration.ParameterNodes);
            functionCall.ReturnType = functionDeclaration.ReturnType;
        }

        private static void CheckCallParameters(INode invoker, IList<IExpression> callParameters,
            IList<FunctionDeclarationParameter> declarationParameters)
        {
            if (declarationParameters.Count != callParameters.Count)
                throw new ScopeException(
                    $"Function \"{invoker}\" call signature is different from defined function with that name");
            for (int i = 0; i < declarationParameters.Count; i++)
            {
                var parameter = declarationParameters[i];
                var callParameter = callParameters[i];
                callParameter.Process();

                if (parameter.ReturnType == callParameter.ReturnType) continue;
                if (callParameter.ReturnType.IsCastableTo(parameter.ReturnType))
                    callParameter.CastToType = parameter.ReturnType;
                else
                    throw new ScopeException(
                        $"Type {callParameter.ReturnType} can not be matched to type {parameter.ReturnType} in {invoker}");
            }
        }

        private static void Process(this NewArray newArray)
        {
            if (newArray.ArraySize != null && newArray.InitializationParameters.Count > 0)
                throw new ScopeException("You can't specify array size and include initialization parameters");
            if (newArray.ArraySize == null && newArray.InitializationParameters.Count == 0)
                throw new ScopeException("You must specify array size");
            if (newArray.ArraySize != null)
            {
                newArray.ArraySize.Process();
                if (newArray.ArraySize.ReturnType != ReturnType.Int)
                    throw new ScopeException(
                        $"Array size must be of {ReturnType.Int} type, but {newArray.ArraySize.ReturnType} is specified");
            }
            var arrayInnerType = newArray.ReturnType.CastTo<ArrayReturnType>()
                .InnerType;
            newArray.InitializationParameters.ForEach(expression =>
            {
                expression.Process();
                if (expression.ReturnType != arrayInnerType)
                {
                    if (expression.ReturnType.IsCastableTo(arrayInnerType))
                        expression.CastToType = arrayInnerType;
                    else
                        throw new ScopeException(
                            $"Initialization parameter must be of type {arrayInnerType}, but received {expression.ReturnType}");
                }
            });
        }

        private static void Process(this ArrayElementReference arrayElementReference)
        {
            arrayElementReference.Name.Process();
            if (arrayElementReference.Name.ReturnType is ArrayReturnType arrayReturnType)
                arrayElementReference.ReturnType = arrayReturnType.InnerType;
            else
                throw new ExpressionException(
                    $"Variable \"{arrayElementReference.Name}\" is of type {arrayElementReference.Name.ReturnType} but expected array");

            arrayElementReference.ArrayIndex.Process();
            if (arrayElementReference.ArrayIndex.GetResultReturnType() != ReturnType.Int)
                throw new ExpressionException(
                    $"Index of array element reference \"{arrayElementReference.Name}\" must be of type {ReturnType.Int}, but received {arrayElementReference.ArrayIndex.ReturnType}");
            arrayElementReference.ArrayDeclaration = arrayElementReference.Scope
                .GlobalVariableSearch(arrayElementReference.Name.Name)
                .CastTo<ArrayDeclaration>();
        }

        #endregion

        #region Statements

        private static void Process(this IStatement statement)
        {
            switch (statement)
            {
                case VariableAssignment variableAssignment:
                    variableAssignment.Process();
                    break;
                case ArrayElementAssignment arrayElementAssignment:
                    arrayElementAssignment.Process();
                    break;
                case Declaration declaration:
                    declaration.Process();
                    break;
                case FunctionCall functionCall:
                    functionCall.Process();
                    break;
                case ReturnStatement returnStatement:
                    returnStatement.Process();
                    break;
                case WhileStatement whileStatement:
                    whileStatement.Process();
                    break;
                case IfStatement ifStatement:
                    ifStatement.Process();
                    break;
                case ForStatement forStatement:
                    forStatement.Process();
                    break;
                case BlockStatement blockStatement:
                    blockStatement.Process();
                    break;
                default:
                    throw new NotImplementedException($"Statements process: {statement.GetType()}");
            }
        }

        private static void Process(this VariableAssignment variableAssignment)
        {
            var scope = variableAssignment;

            variableAssignment.VariableName.Process();
            var variableReturnType = variableAssignment.VariableName.ReturnType;
            var assignmentValue = variableAssignment.AssignmentValue;

            assignmentValue.Process();

            if (assignmentValue.ReturnType != variableReturnType)
            {
                if (assignmentValue.ReturnType.IsCastableTo(variableReturnType))
                {
                    assignmentValue.CastToType = variableReturnType;
                }
                else
                    throw new ScopeException(
                        $"Return type {assignmentValue.ReturnType} does not match {variableReturnType}");
            }
        }

        private static void Process(this ArrayElementAssignment arrayElementAssignment)
        {
            arrayElementAssignment.ArrayElementReference.Process();
            arrayElementAssignment.AssignmentExpression.Process();

            var arrItemType = arrayElementAssignment.ArrayElementReference.ReturnType
                //.CastTo<ArrayReturnType>()
                //.InnerType
                ;

            if (arrItemType != arrayElementAssignment.AssignmentExpression.ReturnType)
            {
                if (arrayElementAssignment.AssignmentExpression.ReturnType.IsCastableTo(arrItemType))
                {
                    arrayElementAssignment.AssignmentExpression.CastToType = arrItemType;
                }

                else
                {
                    throw new ExpressionException($"Cannot assign to the element of array " +
                                                  $"{arrayElementAssignment.ArrayElementReference.Name} " +
                                                  $"({arrayElementAssignment.ArrayElementReference.ReturnType}) " +
                                                  $"expression of type {arrayElementAssignment.AssignmentExpression.ReturnType}");
                }
            }

            //blockStatement.Statements.ForEach(st => st.Process());
        }

        private static void Process(this ReturnStatement returnStatement)
        {
            returnStatement.ReturnExpression.Process();
            var retType = returnStatement.ReturnExpression.ReturnType;

            INode node = returnStatement.Parent;

            while (!(node is FunctionDeclaration))
            {
                node = node.Parent;
            }

            var funcDecl = node as FunctionDeclaration;

            if (funcDecl.ReturnType != retType)
            {
                if (retType.IsCastableTo(funcDecl.ReturnType))
                {
                    returnStatement.ReturnExpression.CastToType = funcDecl.ReturnType;
                }
                else
                {
                    throw new ExpressionException($"Return type of func {(node as FunctionDeclaration).Name} " +
                                                  $"({(node as FunctionDeclaration).ReturnType}) does not match {retType}");
                }
            }
        }

        private static void Process(this WhileStatement whileStatement)
        {
            whileStatement.ConditionExpression.Process();

            if (whileStatement.ConditionExpression.ReturnType != ReturnType.Bool)
            {
                throw new ExpressionException($"conditional expression in while must be of type bool, not " +
                                              $"{whileStatement.ConditionExpression.ReturnType}");
            }

            whileStatement.BlockOrSingleStatement.Process();
        }

        private static void Process(this IfStatement ifStatement)
        {
            ifStatement.ConditionExpression.Process();
            if (ifStatement.ConditionExpression.ReturnType != ReturnType.Bool)
            {
                throw new ExpressionException($"conditional expression in if must be of type bool, not " +
                                              $"{ifStatement.ConditionExpression.ReturnType}");
            }
            ifStatement.TrueCaseBlockStatement.Process();

            if (ifStatement.FasleCaseBlockStatement != null)
            {
                ifStatement.FasleCaseBlockStatement.Process();
            }
        }

        private static void Process(this ForStatement forStatement)
        {
            forStatement.InitializationStatement.Process();
            forStatement.ConditionExpression.Process();

            if (forStatement.ConditionExpression.ReturnType != ReturnType.Bool)
            {
                throw new ExpressionException($"conditional expression in if must be of type bool, not " +
                                              $"{forStatement.ConditionExpression.ReturnType}");
            }

            forStatement.IterationStatement.Process();

            forStatement.BlockOrSingleStatement.Process();
        }

        private static void Process(this BlockStatement blockStatement)
        {
            blockStatement.Statements.ForEach(st => st.Process());
        }

        #endregion

        private static void ProcessAttributeUsage(this AttributeUsage attributeUsage)
        {
            ClassDeclaration classDeclaration = attributeUsage.Scope.GlobalClassSearch(attributeUsage.Name.Name);
            if (classDeclaration == null)
                throw new ScopeException($"Attribute {attributeUsage.Name.Name} was not found");
            if (!classDeclaration.IsAttribute)
                throw new ScopeException($"Class {attributeUsage.Name.Name} is not an attribute");
            AttributeDeclaration attributeDeclarationClass = classDeclaration.CastTo<AttributeDeclaration>();
            CheckCallParameters(attributeUsage,attributeUsage.FunctionCallParameters, attributeDeclarationClass.ParameterNodes);
        }

        #endregion

        #region After Process

        public static void SetVariableIndexes(this Nodes.Program program)
        {
            program.ClassNodes.ForEach(classDeclaration =>
            {
                classDeclaration.FunctionDeclarationNodes.ForEach(functionDeclaration =>
                {
                    SetFunctionArgsIndexes(functionDeclaration);
                    int varIndex = 0;
                    if (functionDeclaration.StatementBlock != null)
                        SetBlockVarsIndexes(functionDeclaration.StatementBlock, ref varIndex);
                });
            });

            void SetFunctionArgsIndexes(FunctionDeclaration functionDeclaration)
            {
                int index = 0;
                foreach (var parameter in functionDeclaration.ParameterNodes)
                    parameter.Index = index++;
                //SetBlockVarsIndexes(functionDeclaration.StatementBlock, ref index);
            }

            void SetBlockVarsIndexes(BlockStatement blockStatement, ref int varIndex)
            {
                foreach (var statement in blockStatement.Statements)
                    switch (statement)
                    {
                        case Declaration declaration:
                        {
                            declaration.Index = varIndex++;
                            break;
                        }
                        case IfStatement ifStatement:
                        {
                            if (ifStatement.TrueCaseBlockStatement is BlockStatement trueBlock)
                                SetBlockVarsIndexes(trueBlock, ref varIndex);
                            if (ifStatement.FasleCaseBlockStatement is BlockStatement falseBlock)
                                SetBlockVarsIndexes(falseBlock, ref varIndex);
                            break;
                        }
                        case WhileStatement whileStatement:
                        {
                            if (whileStatement.BlockOrSingleStatement is BlockStatement block)
                                SetBlockVarsIndexes(block, ref varIndex);
                            break;
                        }
                        case ForStatement forStatement:
                        {
                            if (forStatement.InitializationStatement is BlockStatement initializationBlock)
                                SetBlockVarsIndexes(initializationBlock, ref varIndex);
                            if (forStatement.IterationStatement is BlockStatement iterationBlock)
                                SetBlockVarsIndexes(iterationBlock, ref varIndex);
                            if (forStatement.BlockOrSingleStatement is BlockStatement statementsBlock)
                                SetBlockVarsIndexes(statementsBlock, ref varIndex);
                            break;
                        }
                    }
            }
        }

        #endregion
    }
}
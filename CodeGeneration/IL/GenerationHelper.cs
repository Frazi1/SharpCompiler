using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using MathLang.Tree.Nodes.Declarations;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Expressions;

namespace MathLang.CodeGeneration
{
    public static class GenerationHelper
    {
        public static Type ConvertToType(this TypeDefinition returnType, bool array = true)
        {
            switch (returnType)
            {
                case BoolTypeDefinition boolReturnType:
                    return typeof(bool);
                case CharTypeDefinition charReturnType:
                    return typeof(char);
                case IntTypeDefinition intReturnType:
                    return typeof(int);
                case VoidTypeDefinition voidReturnType:
                    return typeof(void);
                case ArrayTypeDefinition arrayReturnType:
                {
                    switch (arrayReturnType.InnerTypeDefinition)
                    {
                        case BoolTypeDefinition boolReturnType:
                            return array ? typeof(bool[]) : typeof(bool);
                        case CharTypeDefinition charReturnType:
                            return array ? typeof(char[]) : typeof(char);
                        case IntTypeDefinition intReturnType:
                            return array ? typeof(int[]) : typeof(int);
                        default:
                            throw new InvalidOperationException(
                                $"Bad inner type {(returnType as ArrayTypeDefinition)?.InnerTypeDefinition}" +
                                $" of type {returnType} (cannot convert)");
                    }
                }
                default:
                    throw new InvalidOperationException($"Bad type {returnType} (cannot convert)");
            }
        }

        public static Tuple<Type[], string[]> GetTypesAndNamesOfFuncParams(
            List<FunctionVariableDeclarationParameter> funcParams)
        {
            List<string> names = new List<string>();
            List<Type> types = new List<Type>();

            foreach (var functionDeclarationParameter in funcParams)
            {
                types.Add(functionDeclarationParameter.TypeDefinition.ConvertToType());

                names.Add(functionDeclarationParameter.Name);
            }

            //if (types.Count == 0)
            //{
            //    types.Add(typeof(void));
            //}

            return new Tuple<Type[], string[]>(types.ToArray(), names.ToArray());
        }
    }
}
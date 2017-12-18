using System.Collections.Generic;
using System.Linq;
using JasminSharp;
using JasminSharp.Helpers;

namespace MathLang.CodeGeneration.JasminJava
{
    public class JasminFunctionModule : IJasminModule
    {
        private readonly List<string> _codeListing = new List<string>();
        private readonly List<JasminFunctionParameter> _functionParameters = new List<JasminFunctionParameter>();
        private readonly List<JasminModifier> _modifiers = new List<JasminModifier>();
        private readonly List<IInstruction> _instructions = new List<IInstruction>();

        public string Name { get; private set; }
        public string ReturnType { get; private set; }

        public JasminFunctionModule WithName(string name)
        {
            Name = name;
            return this;
        }

        public JasminFunctionModule WithParameter(JasminFunctionParameter jasminFunctionParameter)
        {
            _functionParameters.Add(jasminFunctionParameter);
            return this;
        }

        public JasminFunctionModule WithReturnType(string returnType)
        {
            ReturnType = returnType;
            return this;
        }

        public JasminFunctionModule WithModifiers(params JasminModifier[] modifiers)
        {
            modifiers.ForEach(modifier =>
            {
                if (_modifiers.Contains(modifier))
                    throw new JasminException($"Modifier {modifier} already assigned to module {ToString()} ");
                _modifiers.Add(modifier);
            });
            return this;
        }

        public JasminFunctionModule WithInstructions(params IInstruction[] instructions)
        {
            _instructions.AddRange(instructions);
            return this;
        }

        public JasminFunctionModule WithInstructions(IEnumerable<IInstruction> instructions)
        {
            _instructions.AddRange(instructions);
            return this;
        }


        public IEnumerable<string> GenerateListing()
        {
            string functionDeclaration =
                $" {JasminDirectives.Method} {ModifiersListing} {FunctionSignature} ";
            _codeListing.Add(functionDeclaration);
            _codeListing.Add(JasminDirectives.LimitLocalsTo(128));
            _codeListing.Add(JasminDirectives.LimitStackTo(128));
            _instructions.ForEach(instruction => _codeListing.AddRange(instruction.GenerateListing()));
            _codeListing.Add(JasminDirectives.EndMethod);
            return _codeListing;
        }

        private string ModifiersListing => string.Join(" ", _modifiers.Select(modifier => modifier.GetTextValue()));

        private string FunctionSignature
        {
            get
            {
                string parameters = "";
                _functionParameters.ForEach(functionParameter =>
                {
                    functionParameter.GenerateListing().ForEach(s => parameters += s);
                });
                return $"{Name}({parameters}){ReturnType}";
            }
        }
        
    }
}
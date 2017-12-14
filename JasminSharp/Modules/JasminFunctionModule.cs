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

        public string Name { get; set; }

        
        public JasminFunctionModule(string name)
        {
            Name = name;
        }

        public JasminFunctionModule WithParameter(JasminFunctionParameter jasminFunctionParameter)
        {
            _functionParameters.Add(jasminFunctionParameter);
            return this;
        }

        //public JasminFunctionModule WithParameter(JasminType jasminType, string name)
        //{
        //    return WithParameter(new JasminFunctionParameter(jasminType, name));
        //}

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

        public IEnumerable<string> GenerateListing()
        {
            string functionDeclaration = $" {JasminDirective.Method.GetTextValue()} {ModifiersListing} {FunctionSignature} ";
            _codeListing.Add(functionDeclaration);
            _codeListing.Add(JasminDirective.EndMethod.GetTextValue());
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
                return $"{Name}({parameters})V";
            }
        }
    }
}
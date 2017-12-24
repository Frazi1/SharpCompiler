using System.Collections;
using System.Collections.Generic;
using System.Linq;
using JasminSharp;
using JasminSharp.Helpers;

namespace MathLang.CodeGeneration.JasminJava
{
    public sealed class JasminClassModule : IJasminModule
    {
        private readonly List<string> _codeListing = new List<string>();
        private readonly List<JasminModifier> _modifiers = new List<JasminModifier>();
        private readonly List<JasminFunctionModule> _functions = new List<JasminFunctionModule>();
        
        public string Name { get; private set; }
        public string InheritsFrom { get; private set; }

        public JasminClassModule(string name, string inheritsFrom = JasminReferenceConstants.JavaObjectClassFull)
        {
            Name = name;
            InheritsFrom = inheritsFrom;
        }

        #region public methods

        public JasminClassModule WithModifiers(params JasminModifier[] modifiers)
        {
            modifiers.ForEach(modifier =>
            {
                if (_modifiers.Contains(modifier))
                    throw new JasminException($"Modifier {modifier} already assigned to module {ToString()} ");
                _modifiers.Add(modifier);
            });
            return this;
        }

        public JasminClassModule WithInheritanceFrom(string jasminType)
        {
            InheritsFrom = jasminType;
            return this;
        }

        public JasminClassModule WithFunction(JasminFunctionModule jasminFunction)
        {
            _functions.Add(jasminFunction);
            return this;
        }

        public IEnumerable<JasminModifier> Modifiers => _modifiers.ToList();

        public IEnumerable<string> GenerateListing()
        {
            string classSignature = $"{JasminDirectives.Class} {ModifiersString} {Name}";
            _codeListing.Add(classSignature);

            string inheritanceDeclaration = $"{JasminDirectives.Super} {InheritsFrom}";
            _codeListing.Add(inheritanceDeclaration);

            _functions.ForEach(function =>
            {
                _codeListing.AddRange(function.GenerateListing());
            });
            
            return _codeListing;
        }

        #endregion

        private string ModifiersString => string.Join(" ", _modifiers.Select(modifier => modifier.GetTextValue()));
    }
}
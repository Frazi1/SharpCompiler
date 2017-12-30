using System.Collections.Generic;
using System.Linq;
using JasminSharp.Helpers;
using MathLang.CodeGeneration;

namespace JasminSharp
{
    public sealed class JasminClassModule : IJasminModule
    {
        private readonly List<string> _codeListing = new List<string>();
        private readonly List<JasminFunctionModule> _functions = new List<JasminFunctionModule>();
        private readonly List<JasminField> _fields = new List<JasminField>();

        private IEnumerable<JasminField> StaticFields => _fields.Where(field => field.IsStatic);

        public string Name { get; private set; }
        public string InheritsFrom { get; private set; }
        public JasminModifier Modifier { get; private set; }

        public JasminClassModule(string name, string inheritsFrom = JasminReferenceConstants.JavaObjectClassShort)
        {
            Name = name;
            InheritsFrom = inheritsFrom;
        }

        #region public methods

        #region Builder

        public JasminClassModule WithFunction(JasminFunctionModule jasminFunction)
        {
            _functions.Add(jasminFunction);
            return this;
        }

        public JasminClassModule WithField(JasminField jasminField)
        {
            _fields.Add(jasminField);
            return this;
        }

        public JasminClassModule WithModifier(JasminModifier modifier)
        {
            Modifier = modifier;
            return this;
        }

        public JasminClassModule WithInheritanceFrom(string jasminType)
        {
            InheritsFrom = jasminType;
            return this;
        }

        #endregion

        public IEnumerable<string> GenerateListing()
        {
            AddStaticInitializer();
            //TODO: fix
            //string classSignature = $"{JasminDirectives.Class} {ModifiersString} {Name}";
            string classSignature = $"{JasminDirectives.Class} {ModifiersString} {Name}";
            _codeListing.Add(classSignature);

            string inheritanceDeclaration = $"{JasminDirectives.Super} {InheritsFrom}";
            _codeListing.Add(inheritanceDeclaration);

            _fields.ForEach(variable => { _codeListing.AddRange(variable.GenerateListing()); });

            _functions.ForEach(function => { _codeListing.AddRange(function.GenerateListing()); });


            return _codeListing;
        }

        #endregion

        private void AddStaticInitializer()
        {
            JasminFunctionModule staticInitializer = new JasminFunctionModule()
                .WithModifiers(JasminModifier.Static)
                .WithName(JasminReferenceConstants.MethodClInit)
                .WithReturnType(JasminReferenceConstants.JavaVoidPrimitive);
            StaticFields.Where(field => field.IsInitialized)
                .ForEach(field => { staticInitializer.WithInstructions(field.ValueInstructions); });
            staticInitializer.WithInstructions(Instructions.ReturnInstruction);
            _functions.Add(staticInitializer);
        }

        //private string ModifiersString => string.Join(" ", _modifiers.Select(modifier => modifier.GetTextValue()));
        private string ModifiersString =>
            string.Join(" ", Modifier.GetFlags<JasminModifier>().Select(m => m.GetTextValue()));
    }
}
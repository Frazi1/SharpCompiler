using System.Collections.Generic;
using System.Text;
using JasminSharp.Helpers;

namespace MathLang.CodeGeneration.JasminJava
{
    public class JasminFunctionParameter : IJasminModule
    {
        //private const char functionParameterSymbol = 'L';
        
        private readonly List<string> _codeListing = new List<string>();
        
        public string Name { get; private set; }
        public string JasminType { get; private set; }


        public JasminFunctionParameter WithName(string name)
        {
            Name = name;
            return this;
        }
       

        public JasminFunctionParameter WithType(string jasminType)
        {
            JasminType = jasminType;
            return this;
        }

        public IEnumerable<string> GenerateListing()
        {
            var parameter = $"{/*AddLSymbolForParameter*/(JasminType)}";
            _codeListing.Add(parameter);
            return _codeListing;
        }

        //private static string AddLSymbolForParameter(string jasminType)
        //{
        //    if (!jasminType.StartsWith(JasminReferenceConstants.ArrayMark.ToString()))
        //        return functionParameterSymbol + jasminType;
        //    string leftOver = "";
        //    var sb = new StringBuilder();
        //    for (int i = 0; i < jasminType.Length; i++)
        //    {
        //        if (jasminType[i] != JasminReferenceConstants.ArrayMark)
        //        {
        //            leftOver = jasminType.Substring(i);
        //            break;
        //        }
        //        sb.Append(jasminType[i]);
        //    }
        //    sb.Append(functionParameterSymbol);
        //    sb.Append(leftOver);
        //    return sb.ToString();
        //}
    }
}
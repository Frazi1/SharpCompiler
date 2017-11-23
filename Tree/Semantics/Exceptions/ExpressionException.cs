using System;
using System.Runtime.Serialization;

namespace MathLang.Tree.Scopes.Exceptions
{
    [Serializable]
    public class ExpressionException : Exception
    {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public ExpressionException()
        {
        }

        public ExpressionException(string message) : base(message)
        {
        }

        public ExpressionException(string message, Exception inner) : base(message, inner)
        {
        }

        protected ExpressionException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
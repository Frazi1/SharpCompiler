using System;
using System.Runtime.Serialization;

namespace JasminSharp
{
    [Serializable]
    public class JasminException : Exception
    {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public JasminException()
        {
        }

        public JasminException(string message) : base(message)
        {
        }

        public JasminException(string message, Exception inner) : base(message, inner)
        {
        }

        protected JasminException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
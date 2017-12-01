using System;
using System.Collections.Generic;
using System.Linq;

namespace MathLang
{
    public class ErrorService
    {
        private static ErrorService _instance;
        public static ErrorService Instance => _instance ?? (_instance = new ErrorService());
        public List<Exception> Exceptions = new List<Exception>();
        public bool HasErrors => Exceptions.Any();

        public void Handle(Exception e)
        {
            Exceptions.Add(e);
        }

        public void PrintErrorsToConsole()
        {
            Exceptions.ForEach(Console.WriteLine);
        }


    }
}
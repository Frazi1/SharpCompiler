using System.Collections.Generic;
using MathLang.Tree.Scopes.Exceptions;

namespace MathLang.Tree.Scopes
{
    public class ScopeTable<T>
    {
        private Dictionary<string, T> Dictionary { get; } = new Dictionary<string, T>();

        public void Add(string key, T value)
        {
            if (Dictionary.ContainsKey(key))
            {
                throw new ScopeException($"Scope of {nameof(T)} already contains key {key}") ;                
            }
            Dictionary.Add(key, value);
        }

        public bool Contains(string key) => Dictionary.ContainsKey(key);
        public T FindByKey(string key) => Dictionary.ContainsKey(key) ? Dictionary[key] : default(T);

        public override string ToString()
        {
            return $"{typeof(T).Name}: {string.Join(", ", Dictionary)}";
        }
    }
}
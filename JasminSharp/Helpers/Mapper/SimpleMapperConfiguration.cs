using System;

namespace JasminSharp.Helpers.Mapper
{
    public class SimpleMapperConfiguration: IMapperConfiguration
    {
        public Type SourceType { get; }
        public Type DestinationType { get; }
        public string Value { get; }
        
        public SimpleMapperConfiguration(Type sourceType, string value)
        {
            SourceType = sourceType;
            DestinationType = typeof(string);
            Value = value;
        }
    }
}
using System;

namespace JasminSharp.Helpers.Mapper
{
    public class SimpleObjectMapperConfiguration : IMapperConfiguration
    {
        public Type SourceType { get; }
        public Type DestinationType { get; }

        public SimpleObjectMapperConfiguration(Type sourceType, Type destinationType )
        {
            SourceType = sourceType;
            DestinationType = destinationType;
        }
    }
}
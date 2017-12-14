using System;
using System.Collections.Generic;
using System.Linq;

namespace JasminSharp.Helpers.Mapper
{
    public sealed class SimpleMapper : IMapper
    {
        private static SimpleMapper _instance;
        private readonly List<SimpleMapperConfiguration> _configurations = new List<SimpleMapperConfiguration>();

        private SimpleMapper()
        { }

        internal static SimpleMapper Instance => _instance ?? (_instance = new SimpleMapper());

        public void CreateMap<TSource, TDestination>(TSource source, TDestination destination)
        {
            if(typeof(TDestination) != typeof(string))
                throw new InvalidOperationException();
            _configurations.Add(new SimpleMapperConfiguration(source.GetType(), destination as string ));
        }

        public TDestination Map<TSource, TDestination>() 
            where TSource : class
            where TDestination : class
        {
            var simpleMapperConfiguration = _configurations.FirstOrDefault(configuration
                => configuration.SourceType == typeof(TSource)
                   && configuration.DestinationType == typeof(TDestination));
            if (simpleMapperConfiguration != null)
            {
                return simpleMapperConfiguration.Value as TDestination;
            }
            throw new InvalidOperationException("Mapping is not registered");
        }

        public TDestination Map<TDestination>(object source) 
            where TDestination : class
        {
            var simpleMapperConfiguration = _configurations.FirstOrDefault(configuration
                => configuration.SourceType == source.GetType()
                   && configuration.DestinationType == typeof(TDestination));
            if (simpleMapperConfiguration != null)
            {
                return simpleMapperConfiguration.Value as TDestination;
            }
            throw new InvalidOperationException("Mapping is not registered");
        }
    }
}
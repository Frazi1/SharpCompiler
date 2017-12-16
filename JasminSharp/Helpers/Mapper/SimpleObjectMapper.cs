using System;
using System.Collections.Generic;
using System.Linq;

namespace JasminSharp.Helpers.Mapper
{
    public class SimpleObjectMapper : IMapper
    {
        private static SimpleObjectMapper _instance;
        private readonly List<SimpleObjectMapperConfiguration> _configurations = new List<SimpleObjectMapperConfiguration>();

        private SimpleObjectMapper()
        { }

        internal static SimpleObjectMapper Instance => _instance ?? (_instance = new SimpleObjectMapper());

        public void CreateMap<TSource, TDestination>(TSource source, TDestination destination)
        {
            _configurations.Add(new SimpleObjectMapperConfiguration(source.GetType(), destination.GetType()));
        }

        public TDestination Map<TSource, TDestination>() where TSource : class where TDestination : class
        {
            var simpleObjectMapperConfiguration = _configurations.FirstOrDefault(configuration
                => configuration.SourceType == typeof(TSource)
                   && configuration.DestinationType == typeof(TDestination));
            if (simpleObjectMapperConfiguration != null)
                return Activator.CreateInstance<TDestination>();
            throw new InvalidOperationException("Mapping is not registered");
        }

        public TDestination Map<TDestination>(object source) where TDestination : class
        {
            throw new System.NotImplementedException();
        }
    }
}
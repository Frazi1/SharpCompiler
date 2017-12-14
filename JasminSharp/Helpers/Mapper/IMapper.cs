namespace JasminSharp.Helpers.Mapper
{
    public interface IMapper
    {
        void CreateMap<TSource, TDestination>(TSource source, TDestination destination);

        TDestination Map<TSource, TDestination>()
            where TDestination : class
            where TSource : class;

        TDestination Map<TDestination>(object source)
            where TDestination : class;
    }
}
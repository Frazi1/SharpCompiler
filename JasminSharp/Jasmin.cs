using JasminSharp.Helpers.Mapper;

namespace JasminSharp
{
    public class Jasmin
    {
        public static IMapper Mapper => SimpleMapper.Instance;
    }
}
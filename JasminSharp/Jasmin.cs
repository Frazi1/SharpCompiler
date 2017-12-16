using JasminSharp.Helpers.Mapper;

namespace JasminSharp
{
    public class Jasmin
    {
        public static IMapper TypeMapper => SimpleMapper.Instance;
        public static IMapper InstructionMapper => SimpleObjectMapper.Instance;
    }
}
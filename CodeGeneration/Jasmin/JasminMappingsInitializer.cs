using JasminSharp;
using JasminSharp.Helpers.Mapper;
using MathLang.Tree.Nodes.Enums;

namespace MathLang.CodeGeneration.JasminJava
{
    public class JasminMappingsInitializer
    {
        public static void Initilalize()
        {
            IMapper mapper = Jasmin.Mapper;
            mapper.CreateMap(ReturnType.Int, JasminReferenceConstants.JavaInteger);
            mapper.CreateMap(ReturnType.ArrayOf(ReturnType.Int),  $"{JasminReferenceConstants.ArrayMark}{mapper.Map<IntReturnType,string>()}");
            mapper.CreateMap(ReturnType.Void, JasminReferenceConstants.JavaVoid);
            mapper.CreateMap(ReturnType.Bool, JasminReferenceConstants.JavaBoolean);
            mapper.CreateMap(ReturnType.Char, JasminReferenceConstants.JavaChar);
        }
    }
}
using JasminSharp;
using JasminSharp.Helpers.Mapper;
using MathLang.Tree.Nodes.Enums;

namespace MathLang.CodeGeneration.JasminJava
{
    public class JasminMappingsInitializer
    {
        public static void Initilalize()
        {
            InitTypeMappings();
            InitInstructionsMapping();
        }

        private static void InitInstructionsMapping()
        {
            IMapper m = Jasmin.InstructionMapper;
        }

        private static void InitTypeMappings()
        {
            IMapper typeMapper = Jasmin.TypeMapper;
            typeMapper.CreateMap(ReturnType.Int, JasminReferenceConstants.JavaIntegerPrimitive);
            //typeMapper.CreateMap(ReturnType.ArrayOf(ReturnType.Int),
            //    $"{JasminReferenceConstants.ArrayMark}{typeMapper.Map<IntReturnType, string>()}");
            typeMapper.CreateMap(ReturnType.Void, JasminReferenceConstants.JavaVoidPrimitive);
            typeMapper.CreateMap(ReturnType.Bool, JasminReferenceConstants.JavaBooleanClassFull);
            typeMapper.CreateMap(ReturnType.Char, JasminReferenceConstants.JavaCharPrimitive);
            typeMapper.CreateMap(ReturnType.String, JasminReferenceConstants.JavaStringClassFull);
            //typeMapper.CreateMap(ReturnType.ArrayOf(ReturnType.String),
            //    $"{JasminReferenceConstants.ArrayMark}{typeMapper.Map<StringReturnType, string>()}");
            //typeMapper.CreateMap(new ArrayReturnType(null), $"{JasminReferenceConstants.ArrayMark}{typeMapper.Map<>()}" );
        }
    }
}
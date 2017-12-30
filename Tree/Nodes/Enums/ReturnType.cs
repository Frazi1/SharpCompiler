namespace MathLang.Tree.Nodes.Enums
{
    public enum ReturnTypeEnum
    {
        Unset,
        Bool,
        Int,
        Double,
        Void,
        Char,
        String
    }

    public abstract class ReturnType
    {
        public string Name { get; }

        protected ReturnType(string name)
        {
            Name = name;
        }

        public static UnsetReturnType Unset => new UnsetReturnType();
        public static BoolReturnType Bool => new BoolReturnType();
        public static IntReturnType Int => new IntReturnType();
        public static CharReturnType Char => new CharReturnType();
        public static VoidReturnType Void => new VoidReturnType();
        public static ArrayReturnType ArrayOf(ReturnType returnType) => new ArrayReturnType(returnType);
        public static StringReturnType String => new StringReturnType();
        public static CustomReturnType CustomType(string name) => new CustomReturnType(name);
        
        protected bool Equals(ReturnType other)
        {
            return string.Equals(Name, other.Name);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ReturnType) obj);
        }


        public override int GetHashCode()
        {
            return Name != null ? Name.GetHashCode() : 0;
        }

        public override string ToString()
        {
            return Name;
        }

        public static bool operator ==(ReturnType a, ReturnType b)
        {
            return Equals(a, b);
        }

        public static bool operator !=(ReturnType a, ReturnType b)
        {
            return !(a == b);
        }

    }

    public abstract class SimpleReturnType : ReturnType
    {
        protected SimpleReturnType(string name)
            : base(name)
        {
        }
    }

    public abstract class ComplexReturnType : ReturnType
    {
        public ReturnType InnerType { get; protected set; }

        protected ComplexReturnType(string name)
            : base(name)
        {
        }
    }

    public class ArrayReturnType : ComplexReturnType
    {
        public ArrayReturnType(ReturnType returnType)
            : base("ArrayOf." + returnType)
        {
            InnerType = returnType;
        }
    }

    public class UnsetReturnType : SimpleReturnType
    {
        public UnsetReturnType()
            : base(ReturnTypeEnum.Unset.ToString())
        {
        }
    }

    public class BoolReturnType : SimpleReturnType
    {
        public BoolReturnType()
            : base(ReturnTypeEnum.Bool.ToString())
        {
        }
    }

    public class IntReturnType : SimpleReturnType
    {
        public IntReturnType()
            : base(ReturnTypeEnum.Int.ToString())
        {
        }
    }

    public class CharReturnType : SimpleReturnType
    {
        public CharReturnType()
            : base(ReturnTypeEnum.Char.ToString())
        {
        }
    }

    public class VoidReturnType : SimpleReturnType
    {
        public VoidReturnType()
            : base(ReturnTypeEnum.Void.ToString())
        {
        }
    }

    public sealed class StringReturnType : SimpleReturnType
    {
        public StringReturnType() 
            : base("String")
        {
        }
    }
    
    public sealed class CustomReturnType : SimpleReturnType
    {
        public CustomReturnType(string name) : base(name)
        {
        }
    }
}
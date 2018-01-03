using System.Collections.Generic;
using MathLang.Tree.Nodes.Declarations;

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

    public abstract class TypeDefinition
    {
        public string Name { get; protected internal set; }
        public List<ConstructorDefinition> Constructors { get; } = new List<ConstructorDefinition>();

        protected TypeDefinition()
        {
        }

        protected TypeDefinition(string name)
        {
            Name = name;
        }

        public static UnsetTypeDefinition Unset => new UnsetTypeDefinition();
        public static BoolTypeDefinition Bool => new BoolTypeDefinition();
        public static IntTypeDefinition Int => new IntTypeDefinition();
        public static CharTypeDefinition Char => new CharTypeDefinition();
        public static VoidTypeDefinition Void => new VoidTypeDefinition();

        public static ArrayTypeDefinition ArrayOf(TypeDefinition typeDefinition) =>
            new ArrayTypeDefinition(typeDefinition);

        public static StringTypeDefinition String => new StringTypeDefinition();
        public static CustomTypeDefinition CustomType(string name) => new CustomTypeDefinition(name);

        protected bool Equals(TypeDefinition other)
        {
            return string.Equals(Name, other.Name);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((TypeDefinition) obj);
        }


        public override int GetHashCode()
        {
            return Name != null ? Name.GetHashCode() : 0;
        }

        public override string ToString()
        {
            return Name;
        }

        public static bool operator ==(TypeDefinition a, TypeDefinition b)
        {
            return Equals(a, b);
        }

        public static bool operator !=(TypeDefinition a, TypeDefinition b)
        {
            return !(a == b);
        }
    }

    public abstract class SimpleTypeDefinition : TypeDefinition
    {
        protected SimpleTypeDefinition(string name)
            : base(name)
        {
        }
    }

    public abstract class ComplexTypeDefinition : TypeDefinition
    {
        public TypeDefinition InnerTypeDefinition { get; protected set; }

        protected ComplexTypeDefinition(string name)
            : base(name)
        {
        }
    }

    public class ArrayTypeDefinition : ComplexTypeDefinition
    {
        public ArrayTypeDefinition(TypeDefinition typeDefinition)
            : base("ArrayOf." + typeDefinition)
        {
            InnerTypeDefinition = typeDefinition;
        }
    }

    public class UnsetTypeDefinition : SimpleTypeDefinition
    {
        public UnsetTypeDefinition()
            : base(ReturnTypeEnum.Unset.ToString())
        {
        }
    }

    public class BoolTypeDefinition : SimpleTypeDefinition
    {
        public BoolTypeDefinition()
            : base(ReturnTypeEnum.Bool.ToString())
        {
        }
    }

    public class IntTypeDefinition : SimpleTypeDefinition
    {
        public IntTypeDefinition()
            : base(ReturnTypeEnum.Int.ToString())
        {
        }
    }

    public class CharTypeDefinition : SimpleTypeDefinition
    {
        public CharTypeDefinition()
            : base(ReturnTypeEnum.Char.ToString())
        {
        }
    }

    public class VoidTypeDefinition : SimpleTypeDefinition
    {
        public VoidTypeDefinition()
            : base(ReturnTypeEnum.Void.ToString())
        {
        }
    }

    public sealed class StringTypeDefinition : SimpleTypeDefinition
    {
        public StringTypeDefinition()
            : base("String")
        {
        }
    }

    public sealed class CustomTypeDefinition : SimpleTypeDefinition
    {
        public CustomTypeDefinition(string name) : base(name)
        {
        }
    }
}
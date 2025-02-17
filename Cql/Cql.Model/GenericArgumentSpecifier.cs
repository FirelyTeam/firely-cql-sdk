namespace Hl7.Cql.Model
{
    internal class GenericArgumentSpecifier : TypeSpecifier
    {
        public static readonly GenericArgumentSpecifier T = new("T");

        public GenericArgumentSpecifier(string argument)
        {
            Argument = argument;
        }
        public string Argument { get; }

        public override bool Equals(TypeSpecifier? other)
        {
            if (other is GenericArgumentSpecifier otherGas)
                return Argument == otherGas.Argument;
            else
                return false;
        }

        public override bool IsSubtypeOf(TypeSpecifier other) => false;

        protected internal override TypeDefinition? GetTypeDefinition() => null;
        public override string ToString() => Argument;

        public override int GetHashCode() =>
            typeof(GenericArgumentSpecifier).GetHashCode() ^ Argument.GetHashCode();
    }
}

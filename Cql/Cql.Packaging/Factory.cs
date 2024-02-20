namespace Hl7.Cql.Packaging;

#pragma warning disable CS1591
internal abstract class Factory<T>
{
    public abstract T Create();

    public static implicit operator Factory<T>(T value) => new ConcreteFactory<T>(value);

    private sealed class ConcreteFactory<TConcrete> : Factory<TConcrete>
    {
        private readonly TConcrete _value;

        public ConcreteFactory(TConcrete value) => _value = value;

        public override TConcrete Create() => _value;
    }
}
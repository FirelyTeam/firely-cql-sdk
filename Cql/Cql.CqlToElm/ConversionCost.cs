namespace Hl7.Cql.CqlToElm
{
    /// <summary>
    /// Defines implicit conversion precdence per the CQL spec.
    /// </summary>
    /// <remarks>
    /// The reference implementation does not seem to obey that subtype is cheaper than
    /// compatible in all cases.
    /// </remarks>
    /// <seealso href="https://cql.hl7.org/03-developersguide.html#conversion-precedence"/>
    internal enum ConversionCost: int
    {
        ExactMatch,
        Subtype,
        Compatible,
        Cast,
        ImplicitToSimpleType,
        ImplicitToClassType,
        IntervalPromotion,    
        ListDemotion,
        IntervalDemotion,
        ListPromotion,

        Incompatible = 1000,
    }
}


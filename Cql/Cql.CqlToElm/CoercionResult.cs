namespace Hl7.Cql.CqlToElm
{
    internal record CoercionResult<T>(T Result, CoercionCost Cost)
    {
        public bool Success => Cost != CoercionCost.Incompatible;
    }
}


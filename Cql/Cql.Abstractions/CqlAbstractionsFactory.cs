using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Abstractions;

internal class CqlAbstractionsFactory : CqlFactoryBase
{
    protected CqlAbstractionsFactory(ILoggerFactory loggerFactory) : base(loggerFactory)
    {
    }
}
using Microsoft.Extensions.Logging;
using Ncqa.Cql.MeasureCompiler;
using Ncqa.Cql.MeasureCompiler.CodeGeneration;
using System.Collections.Generic;

namespace Ncqa.Cql.Runtime.FhirR4
{
    public static class FhirCompiler
    {
        public static Compiler Create(TypeManager? typeManager = null,
            bool useCache = true,
            ILogger<Compiler>? compilerLogger = null,
            ILogger<SourceCodeWriter>? writerLogger = null,
            IList<IExpressionMutator>? mutators = null) =>
            new Compiler(new FhirOperatorsBinding(FhirTypeConverter.Default, FhirTypeResolver.Default),
                typeManager ?? new TypeManager(FhirTypeResolver.Default),
                useCache,
                compilerLogger,
                writerLogger,
                mutators);


    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.CqlToElm
{
    internal record ConversionResult<T>
    {
        public ConversionResult(T result, ConversionCost cost, string? error = null) :
            this(result,  new[] { cost },  error is null ? Array.Empty<string>() : new[] { error }) 
        {
        }

        public ConversionResult(T result, IEnumerable<ConversionCost> costs, IEnumerable<string> errors)
        {
            Expression = result;
            Cost = costs;
            Errors = errors;

        }

        public bool Success => !Errors.Any();
        public T Expression { get; }
        public IEnumerable<ConversionCost> Cost { get; }
        public int TotalCost => Cost.Sum(c => (int)c);
        public string? Error => $"The following errors occured during conversion: {string.Join("\n", Errors)}";
        public IEnumerable<string> Errors { get; }

        public static ConversionResult<T>[] SelectBestCandidate(IEnumerable<ConversionResult<T>> candidates) =>
            candidates
              .OrderBy(r => r.Cost)
              .GroupBy(r => r.Cost)
              .First()
              .AsEnumerable().ToArray() ?? Array.Empty<ConversionResult<T>>();
    }
}


using Ncqa.Cql.Runtime.Conversion;
using Ncqa.Cql.Runtime.Primitives;
using Ncqa.Fhir.R4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Ncqa.Cql.Runtime.FhirR4
{
    public class FhirCqlOperators : CqlOperatorsBase
    {

        public FhirCqlOperators(FhirRuntimeContext context, FhirTypeResolver resolver, TypeConverter? converter = null)
            : base(context, resolver, converter ?? FhirTypeConverter.Default)
        {
            Context = context;
        }

        public new FhirRuntimeContext Context { get; private set; }

        public override int? CalculateAge(CqlDate? birthDate, string precision) =>
            CalculateAgeAt(birthDate, Today(), precision);

        public override int? CalculateAge(CqlDateTime? birthDate, string precision) =>
            CalculateAgeAt(birthDate, Now(), precision);

        public override int? CalculateAgeAt(CqlDate? birthDate, CqlDate? asOf, string precision)
        {
            if (asOf == null)
                return null;
            if (birthDate == null)
                return null;
            var durr = DurationBetween(birthDate, asOf, precision);
            return durr;
        }

        public override int? CalculateAgeAt(CqlDateTime? birthDate, CqlDateTime? asOf, string precision)
        {
            if (asOf == null)
                return null;
            if (birthDate == null)
                return null;
            var durr = DurationBetween(birthDate, asOf, precision);
            return durr;
        }

        public override int? Age(string precision)
        {
            var patients = Context.DataRetriever.RetrieveByValueSet<Patient>(null, null).ToList();
            if (patients.Count == 1)
                return CalculateAge(new CqlDate(patients[0].birthDate.value), precision);
            else return null;
        }

        public override int? AgeAt(CqlDate? asOf, string precision)
        {
            var patients = Context.DataRetriever.RetrieveByValueSet<Patient>(null, null).ToList();
            if (patients.Count == 1)
                return CalculateAgeAt(new CqlDate(patients[0].birthDate.value), asOf, precision);
            else return null;
        }

        #region Conversion

        public string? ConvertCodeElementToString(CodeElement? element) => element?.value;

        #endregion
    }
}

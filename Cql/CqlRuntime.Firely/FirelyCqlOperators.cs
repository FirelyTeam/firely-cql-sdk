using Hl7.Fhir.Model;
using Ncqa.Cql.Runtime;
using Ncqa.Cql.Runtime.Conversion;
using Ncqa.Cql.Runtime.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using static Hl7.Fhir.Model.Bundle;

namespace Ncqa.Cql.Runtime.Firely
{
    public class FirelyCqlOperators : CqlOperatorsBase
    {

        public FirelyCqlOperators(FirelyRuntimeContext context, FirelyTypeResolver resolver, TypeConverter? converter = null)
            : base(context, resolver, converter ?? FirelyTypeConverter.Default)
        {
            Context = context;
        }

        public new FirelyRuntimeContext Context { get; private set; }

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
                return CalculateAge(new CqlDate(patients[0].BirthDate), precision);
            else return null;
        }

        public override int? AgeAt(CqlDate? asOf, string precision)
        {
            var patients = Context.DataRetriever.RetrieveByValueSet<Patient>(null, null).ToList();
            if (patients.Count == 1)
                return CalculateAgeAt(new CqlDate(patients[0].BirthDate), asOf, precision);
            else return null;
        }

        #region Conversion

        public string? ConvertCodeElementToString(Code? element) => element?.Value;


        #endregion

    }
}

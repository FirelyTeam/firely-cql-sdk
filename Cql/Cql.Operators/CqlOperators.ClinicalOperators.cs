using Hl7.Cql.Primitives;
using Hl7.Cql.ValueSets;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.Runtime
{
    public partial class CqlOperators
    {

        #region Age

        public int? Age(string precision)
        {
            var patientType = TypeResolver.PatientType
                ?? throw new InvalidOperationException($"This type resolver provided a null value for {nameof(TypeResolver.PatientType)}");
            var birthDateProperty = TypeResolver.PatientBirthDateProperty
                ?? throw new InvalidOperationException($"This type resolver provided a null value for {nameof(TypeResolver.PatientBirthDateProperty)}");
            var method = DataRetriever.GetType()
                .GetMethod(nameof(DataRetriever.RetrieveByValueSet))!
                .MakeGenericMethod(patientType);
            var patients = method.Invoke(DataRetriever, new object?[] { null }) as IEnumerable<object>;
            var patientsArray = patients?.ToArray() ?? Array.Empty<object>();
            if (patientsArray.Length == 1)
            {
                var birthDate = birthDateProperty.GetValue(patientsArray[0]);
                var asDate = TypeConverter.Convert<CqlDate>(birthDate);
                return CalculateAge(asDate, precision);
            }
            else return null;
        }

        #endregion

        #region AgeAt

        public int? AgeAt(CqlDate? asOf, string precision)
        {
            var patientType = TypeResolver.PatientType
                ?? throw new InvalidOperationException($"This type resolver provided a null value for {nameof(TypeResolver.PatientType)}");
            var birthDateProperty = TypeResolver.PatientBirthDateProperty
                ?? throw new InvalidOperationException($"This type resolver provided a null value for {nameof(TypeResolver.PatientBirthDateProperty)}");
            var method = DataRetriever.GetType()
                .GetMethod(nameof(DataRetriever.RetrieveByValueSet))!
                .MakeGenericMethod(patientType);
            var patients = method.Invoke(DataRetriever, new object?[] { null }) as IEnumerable<object>;
            var patientsArray = patients?.ToArray() ?? Array.Empty<object>();
            if (patientsArray.Length == 1)
            {
                var birthDate = birthDateProperty.GetValue(patientsArray[0]);
                var asDate = TypeConverter.Convert<CqlDate>(birthDate);
                return CalculateAgeAt(asDate, asOf, precision);
            }
            else return null;
        }

        #endregion

        #region CalculateAge

        public int? CalculateAge(CqlDate? birthDate, string precision) =>
            CalculateAgeAt(birthDate, Today(), precision);
        public int? CalculateAge(CqlDateTime? birthDate, string precision) =>
            CalculateAgeAt(birthDate, Now(), precision);

        #endregion

        #region CalculateAgeAt

        public int? CalculateAgeAt(CqlDate? birthDate, CqlDate? asOf, string precision)
        {
            if (asOf == null)
                return null;
            if (birthDate == null)
                return null;
            var durr = DurationBetween(birthDate, asOf, precision);
            return durr;
        }
        public int? CalculateAgeAt(CqlDateTime? birthDate, CqlDateTime? asOf, string precision)
        {
            if (asOf == null)
                return null;
            if (birthDate == null)
                return null;
            var durr = DurationBetween(birthDate, asOf, precision);
            return durr;
        }
        #endregion

        #region In (CodeSystem)

        public bool? CodeInCodeSystem(string? code, CqlCodeSystem? codesystem)
        {
            throw new NotImplementedException();
        }
        public bool? CodeInCodeSystem(CqlCode? code, CqlCodeSystem? codesystem)
        {
            throw new NotImplementedException();
        }
        public bool? CodeInCodeSystem(CqlConcept? code, CqlCodeSystem? codesystem)
        {
            throw new NotImplementedException();
        }
        public bool? CodeInCodeSystem(IEnumerable<CqlCode?>? code, CqlCodeSystem? codesystem)
        {
            throw new NotImplementedException();
        }
        public bool? CodeInCodeSystem(IEnumerable<string?>? code, CqlCodeSystem? codesystem)
        {
            throw new NotImplementedException();
        }
        public bool? CodeInCodeSystem(IEnumerable<CqlConcept?>? code, CqlCodeSystem? codesystem)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region In (ValueSet)

        public bool? StringInValueSet(string? code, CqlValueSet? valueSet)
        {
            if (code == null || valueSet == null || valueSet.id == null)
                return null;
            var result = ValueSets.IsCodeInValueSet(valueSet.id, code);
            return result;
        }
        public bool? CodeInValueSet(CqlCode? code, CqlValueSet? valueSet)
        {
            if (code == null || valueSet == null || code.code == null || valueSet.id == null)
                return null;
            if (!string.IsNullOrWhiteSpace(code.system))
            {
                var result = ValueSets.IsCodeInValueSet(valueSet.id, code.code, code.system);
                return result;
            }
            else
            {
                var result = ValueSets.IsCodeInValueSet(valueSet.id, code.code);
                return result;
            }
        }
        public bool? ConceptInValueSet(CqlConcept? concept, CqlValueSet? valueSet)
        {
            if (concept == null || concept.codes == null)
                return null;
            return CodesInValueSet(concept.codes, valueSet);
        }
        public bool? CodesInValueSet(IEnumerable<CqlCode?>? codes, CqlValueSet? valueSet)
        {
            if (codes == null)
                return null;
            foreach (var code in codes)
            {
                var result = CodeInValueSet(code, valueSet);
                if (result != false)
                    return result;
            }
            return false;
        }
        public bool? StringsInValueSet(IEnumerable<string?>? strings, CqlValueSet? valueSet)
        {
            if (strings == null || valueSet == null || valueSet.id == null)
                return null;
            foreach (var @string in strings)
            {
                if (@string == null)
                    return null;
                var result = ValueSets.IsCodeInValueSet(valueSet.id, @string);
                if (result != false)
                    return result;
            }
            return false;
        }
        public bool? ConceptsInValueSet(IEnumerable<CqlConcept?>? concept, CqlValueSet? valueSet)
        {
            if (concept == null)
                return null;
            var codes = concept
                .Where(c => c?.codes != null)
                .SelectMany(c => c?.codes!);
            var result = CodesInValueSet(codes, valueSet);
            return result;
        }
        #endregion

        public IEnumerable<CqlCode> ResolveValueSet(CqlValueSet valueSet) => new ValueSetFacade(valueSet, ValueSets);

    }
}

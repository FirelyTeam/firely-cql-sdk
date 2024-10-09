#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.Runtime
{
    internal partial class CqlOperators
    {

        #region Age

        public int? Age(string precision)
        {
            var patientType = TypeResolver.PatientType
                ?? throw new InvalidOperationException($"This type resolver provided a null value for {nameof(TypeResolver.PatientType)}");
            var birthDateProperty = TypeResolver.PatientBirthDateProperty
                ?? throw new InvalidOperationException($"This type resolver provided a null value for {nameof(TypeResolver.PatientBirthDateProperty)}");
            var method = typeof(IDataSource)
                .GetMethod(nameof(IDataSource.Retrieve))!
                .MakeGenericMethod(patientType);
            var patients = method.Invoke(DataSource, [null]) as IEnumerable<object>;
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
            var method = typeof(IDataSource)
                .GetMethod(nameof(IDataSource.Retrieve))!
                .MakeGenericMethod(patientType);
            var patients = method.Invoke(DataSource, [null]) as IEnumerable<object>;
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

        public IEnumerable<CqlCode> ResolveValueSet(CqlValueSet valueSet) => CreateValueSetFacade(valueSet);

    }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
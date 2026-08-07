#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler.Infrastructure;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Operators
{
    internal partial class CqlOperators
    {

        #region Age

        public int? Age(string precision) =>
            PatientBirthDate() is { } birthDate ? CalculateAge(birthDate, precision) : null;

        #endregion

        #region AgeAt

        public int? AgeAt(CqlDate? asOf, string precision) =>
            PatientBirthDate() is { } birthDate ? CalculateAgeAt(birthDate, asOf, precision) : null;

        #endregion

        #region Patient birth date

        /// <summary>
        /// The patient in context, and therefore their birth date, is fixed for the lifetime of this instance:
        /// <see cref="DataSource"/> is assigned once at construction and cannot be reassigned. Resolving it per call
        /// re-ran the retrieve and the <see cref="CqlDate"/> conversion on every element of a query, which measured
        /// 174 ns and 512 B per call against 22.7 ns and 32 B once memoized.
        /// </summary>
        /// <remarks>
        /// If <see cref="ResolvePatientBirthDate"/> throws, the assignment inside <c>??=</c> never completes, so
        /// <c>_patientBirthDate</c> stays <see langword="null"/> and the next call retries. This is intentional:
        /// a misconfigured type resolver should report its error on every call, not only the first.
        /// </remarks>
        private StrongBox<CqlDate?>? _patientBirthDate;

        private CqlDate? PatientBirthDate() =>
            (_patientBirthDate ??= new StrongBox<CqlDate?>(ResolvePatientBirthDate())).Value;

        /// <summary>
        /// Retrieves the patient in context and reads their birth date, or returns <see langword="null"/> when the
        /// data source does not hold exactly one patient.
        /// </summary>
        /// <remarks>
        /// The age operators run per element of a query, not once per patient, so the retrieve they need is bound
        /// once through <see cref="PatientRetrievers"/> rather than resolved and closed over the patient type by
        /// reflection on every call.
        /// </remarks>
        private CqlDate? ResolvePatientBirthDate()
        {
            var patientTypeInfo = TypeResolver.PatientTypeInfo;
            var patientType = patientTypeInfo.Type
                ?? throw new InvalidOperationException($"This type resolver provided a null value for {nameof(TypeResolver.PatientType)}");
            var birthDateGetter = patientTypeInfo.BirthDateGetter
                ?? throw new InvalidOperationException($"This type resolver provided a null value for {nameof(TypeResolver.PatientBirthDateGetter)}");

            var patients = PatientRetrievers.GetOrAdd(patientType, static type => BuildPatientRetriever(type))(DataSource);
            if (patients is null)
                return null;

            // The context is a single patient; anything else has no age to speak of. Counting as we go avoids
            // buffering the retrieve into an array only to look at its length.
            object? patient = null;
            var count = 0;
            foreach (var candidate in patients)
            {
                if (++count > 1)
                    return null;
                patient = candidate;
            }

            if (count != 1)
                return null;

            return TypeConverter.Convert<CqlDate>(birthDateGetter(patient!));
        }

        // The model's patient type is expected to be stable and low-cardinality for the process lifetime.
        private static readonly ConcurrentDictionary<Type, Func<IDataSource, IEnumerable<object>?>> PatientRetrievers = new();
        private static readonly MethodInfo RetrieveDefinition =
            ReflectionUtility.GenericMethodDefinitionOf(() => default(IDataSource)!.Retrieve<object>(default));

        private static Func<IDataSource, IEnumerable<object>?> BuildPatientRetriever(Type patientType)
        {
            var retrieve = RetrieveDefinition.MakeGenericMethod(patientType);

            var dataSource = Expression.Parameter(typeof(IDataSource), "dataSource");
            var call = Expression.Call(dataSource, retrieve, Expression.Constant(null, typeof(RetrieveParameters)));

            // IEnumerable<T> is covariant, so the retrieve's result is already an IEnumerable<object> for any
            // reference patient type - which IDataSource.Retrieve's constraint guarantees.
            return Expression
                .Lambda<Func<IDataSource, IEnumerable<object>?>>(
                    Expression.Convert(call, typeof(IEnumerable<object>)),
                    dataSource)
                .Compile();
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
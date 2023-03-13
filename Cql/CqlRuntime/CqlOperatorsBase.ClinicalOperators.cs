using Ncqa.Cql.Runtime.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ncqa.Cql.Runtime
{
    public partial class CqlOperatorsBase
    {

        #region Age

        public abstract int? Age(string precision);
        
        #endregion

        #region AgeAt

        public abstract int? AgeAt(CqlDate? asOf, string precision);

        #endregion

        #region CalculateAge

        public abstract int? CalculateAge(CqlDate? birthDate, string precision);
        public abstract int? CalculateAge(CqlDateTime? birthDate, string precision);


        #endregion

        #region CalculateAgeAt

        public abstract int? CalculateAgeAt(CqlDate? birthDate, CqlDate? asOf, string precision);
        public abstract int? CalculateAgeAt(CqlDateTime? birthDate, CqlDateTime? asOf, string precision);

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
            var result = Context.ValueSets.IsCodeInValueSet(valueSet.id, code);
            return result;
        }
        public bool? CodeInValueSet(CqlCode? code, CqlValueSet? valueSet)
        {
            if (code == null || valueSet == null || code.code == null || valueSet.id == null)
                return null;
            var result = Context.ValueSets.IsCodeInValueSet(valueSet.id, code.code, code.system);
            return result;
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
            foreach(var code in codes)
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
                var result = Context.ValueSets.IsCodeInValueSet(valueSet.id, @string);
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

        public IEnumerable<CqlCode> ResolveValueSet(CqlValueSet valueSet) => new ValueSetFacade(valueSet, Context);

    }
}

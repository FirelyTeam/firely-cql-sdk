using Hl7.Cql.Comparers;
using Hl7.Cql.Compiler;
using Hl7.Cql.Conversion;
using Hl7.Cql.Runtime.FhirR4.Comparers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Runtime.FhirR4
{
    public class FhirModelBindingContext : ModelBindingContext
    {
        public override TypeResolver TypeResolver => FhirTypeResolver.Default;

        public override TypeConverter TypeConverter => FhirTypeConverter.Default;

        private CqlComparers comparers = new CqlComparers().AddFhirComparers();
        public override CqlComparers Comparers => comparers;

        private UnitConverter unitConverter = new UnitConverter();
        public override IUnitConverter UnitConverter => unitConverter;

        private CqlOperatorsBinding operatorBinding = new CqlOperatorsBinding(FhirTypeResolver.Default,
            FhirTypeConverter.Default);
        public override OperatorBinding OperatorBinding => operatorBinding;
    }
}

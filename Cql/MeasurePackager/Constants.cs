using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasurePackager
{
    internal static class Constants
    {
        public const string MeasureGroupCodeSystem = "https://ncqa.org/fhir/CodeSystem/measure-group";
        public const string ParameterElementTypeExtensionUri = "https://ncqa.org/fhir/StructureDefinition/ext-parameter.list-element-type";
        public const string ParameterCanonicalUri = "https://ncqa.org/fhir/StructureDefinition/ext-parameter.canonical-uri";
        public const string ParameterAccessLevel = "https://ncqa.org/fhir/StructureDefinition/ext-parameter.access-level";
        public const string ParameterCqlType = "https://ncqa.org/fhir/StructureDefinition/ext-parameter.cql-type";
        public const string ParameterCqlElementType = "https://ncqa.org/fhir/StructureDefinition/ext-parameter.cql-element-type";
        public const string ParameterCqlDefaultValue = "https://ncqa.org/fhir/StructureDefinition/ext-parameter.cql-default-value";
        public const string ParameterCqlDefaultValueType = "https://ncqa.org/fhir/StructureDefinition/ext-parameter.cql-default-type";
    }
}

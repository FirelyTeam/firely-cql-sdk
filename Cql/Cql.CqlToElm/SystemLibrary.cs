using Hl7.Cql.Elm;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Hl7.Cql.CqlToElm
{
    internal class SystemLibrary : Library
    {
        public SystemLibrary(IConfiguration configuration, IModelProvider modelProvider)
        {
            Configuration = configuration;
            ModelProvider = modelProvider;

            SystemUri = Configuration[nameof(CqlToElmOptions.SystemElmModelUri)] ?? "urn:hl7-org:elm-types:r1";
            SystemVersion = Configuration[nameof(CqlToElmOptions.SystemElmModelVersion)] ?? "1.0.0";

            SystemModel = ModelProvider.ModelFromUri(SystemUri, SystemVersion) ??
                throw new InvalidOperationException($"Cannot find the System model ({SystemUri}, version {SystemVersion}).");

            AnyTypeQName = SystemModel.ToQualifiedTypeName("Any");
            IntegerTypeQName = SystemModel.ToQualifiedTypeName("Integer");
            LongTypeQName = SystemModel.ToQualifiedTypeName("Long");
            DecimalTypeQName = SystemModel.ToQualifiedTypeName("Decimal");
            QuantityTypeQName = SystemModel.ToQualifiedTypeName("Quantity");
            StringTypeQName = SystemModel.ToQualifiedTypeName("String");
            DateTypeQName = SystemModel.ToQualifiedTypeName("Date");
            TimeTypeQName = SystemModel.ToQualifiedTypeName("Time");
            DateTimeTypeQName = SystemModel.ToQualifiedTypeName("DateTime");
            BooleanTypeQName = SystemModel.ToQualifiedTypeName("Boolean");
            RatioTypeQName = SystemModel.ToQualifiedTypeName("Ratio");
            CodeTypeQName = SystemModel.ToQualifiedTypeName("Code");
            ConceptTypeQName = SystemModel.ToQualifiedTypeName("Concept");
            VocabularyTypeQName = SystemModel.ToQualifiedTypeName("Vocabulary");
            ValueSetTypeQName = SystemModel.ToQualifiedTypeName("Valueset");
            CodeSystemTypeQName = SystemModel.ToQualifiedTypeName("CodeSystem");

            AnyType = AnyTypeQName.ToNamedType();
            IntegerType = IntegerTypeQName.ToNamedType();
            LongType = LongTypeQName.ToNamedType();
            DecimalType = DecimalTypeQName.ToNamedType();
            QuantityType = QuantityTypeQName.ToNamedType();
            StringType = StringTypeQName.ToNamedType();
            DateType = DateTypeQName.ToNamedType();
            TimeType = TimeTypeQName.ToNamedType();
            DateTimeType = DateTimeTypeQName.ToNamedType();
            BooleanType = BooleanTypeQName.ToNamedType();
            RatioType = RatioTypeQName.ToNamedType();
            CodeType = CodeTypeQName.ToNamedType();
            ConceptType = ConceptTypeQName.ToNamedType();
            VocabularyType = VocabularyTypeQName.ToNamedType();
            ValueSetType = ValueSetTypeQName.ToNamedType();
            CodeSystemType = CodeSystemTypeQName.ToNamedType();

            ValidIntervalPointTypes = new[]
            {
                IntegerType,
                LongType,
                DecimalType,
                QuantityType,
                DateType,
                TimeType,
                DateTimeType,
            };

            identifier = new VersionedIdentifier() { id = "System", version = SystemVersion };
            statements = buildSystemFunctions().ToArray();
        }

        public readonly Model.ModelInfo SystemModel;

        public readonly XmlQualifiedName AnyTypeQName;
        public readonly XmlQualifiedName IntegerTypeQName;
        public readonly XmlQualifiedName LongTypeQName;
        public readonly XmlQualifiedName DecimalTypeQName;
        public readonly XmlQualifiedName QuantityTypeQName;
        public readonly XmlQualifiedName StringTypeQName;
        public readonly XmlQualifiedName DateTypeQName;
        public readonly XmlQualifiedName TimeTypeQName;
        public readonly XmlQualifiedName DateTimeTypeQName;
        public readonly XmlQualifiedName BooleanTypeQName;
        public readonly XmlQualifiedName RatioTypeQName;
        private readonly XmlQualifiedName CodeTypeQName;
        private readonly XmlQualifiedName ConceptTypeQName;
        private readonly XmlQualifiedName VocabularyTypeQName;
        private readonly XmlQualifiedName ValueSetTypeQName;
        private readonly XmlQualifiedName CodeSystemTypeQName;
        private readonly NamedTypeSpecifier AnyType;
        private readonly NamedTypeSpecifier IntegerType;
        private readonly NamedTypeSpecifier LongType;
        private readonly NamedTypeSpecifier DecimalType;
        private readonly NamedTypeSpecifier QuantityType;
        private readonly NamedTypeSpecifier StringType;
        private readonly NamedTypeSpecifier DateType;
        private readonly NamedTypeSpecifier TimeType;
        private readonly NamedTypeSpecifier DateTimeType;
        private readonly NamedTypeSpecifier BooleanType;
        private readonly NamedTypeSpecifier RatioType;
        private readonly NamedTypeSpecifier CodeType;
        private readonly NamedTypeSpecifier ConceptType;
        private readonly NamedTypeSpecifier VocabularyType;
        private readonly NamedTypeSpecifier ValueSetType;
        private readonly NamedTypeSpecifier CodeSystemType;
        private readonly string SystemUri;
        private readonly string SystemVersion;

        public readonly IReadOnlyCollection<NamedTypeSpecifier> ValidIntervalPointTypes;

        // dependencies
        private readonly IConfiguration Configuration;
        private readonly IModelProvider ModelProvider;

        private IEnumerable<ExpressionDef> buildSystemFunctions()
        {
            yield return IsNull;
            yield return IsTrue;
            yield return IsFalse;
        }

        public BuiltInFunctionDef<IsNull> IsNull => new("IsNull", BooleanType, AnyType);
        public BuiltInFunctionDef<IsTrue> IsTrue => new("IsTrue", BooleanType, BooleanType);
        public BuiltInFunctionDef<IsFalse> IsFalse => new("IsFalse", BooleanType, BooleanType);
    }

    internal class BuiltInFunctionDef<T> : FunctionDef where T : Expression, new()
    {
        public BuiltInFunctionDef(string name, TypeSpecifier resultType, params TypeSpecifier[] parameters)
        {
            this.name = name;
            expression = null;
            external = true;
            fluent = false;   // not too sure, maybe should be true for fhirpath functions?
            operand = parameters
                .Select((ts, ix) => new OperandDef { name = $"param{ix}", operandTypeSpecifier = ts, resultTypeSpecifier = ts })
                .ToArray();
            context = null;    // any context?
            accessLevel = AccessModifier.Public;    // All built-in functions are public                
            resultTypeSpecifier = resultType;
        }

        public T Build()
        {
            return new T()
            {
                resultTypeSpecifier = resultTypeSpecifier
            };
        }
    }
}

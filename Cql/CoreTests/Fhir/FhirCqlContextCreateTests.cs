/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable
using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;
using Hl7.Cql.Runtime;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Specification;

namespace CoreTests.Fhir;


[TestClass]
public class FhirCqlContextCreateTests
{
    [TestMethod]
    public void CreateContext_WithDefaultOptions_ShouldHaveDefaultFhirTypeConverter()
    {
        var context = CreateCqlContext();
        var typeConverter = context.GetCqlOperators().TypeConverter;
        typeConverter.Should().BeSameAs(FhirTypeConverter.Default);
    }

    [TestMethod]
    public void CreateContextTwice_WithDefaultOptions_ShouldBeSameFhirTypeConverter()
    {
        var typeConverter1 = FhirCqlContext.CreateContext().GetCqlOperators().TypeConverter;
        var typeConverter2 = FhirCqlContext.CreateContext().GetCqlOperators().TypeConverter;
        typeConverter1.Should().BeSameAs(typeConverter2);
    }

    [TestMethod]
    public void CreateContextTwice_WithTheSameTimezoneOffset_ShouldBeSameFhirTypeConverter()
    {
        // Converters are memoized by (model, default timezone offset); building one reflects over every
        // FHIR enum, so two contexts that ask for the same pair must share one.
        var options = new FhirCqlContextOptions { OverrideConverterTimezoneOffset = TimeSpan.FromHours(2) };
        var typeConverter1 = CreateCqlContext(options).GetCqlOperators().TypeConverter;
        var typeConverter2 = CreateCqlContext(options).GetCqlOperators().TypeConverter;
        typeConverter1.Should().BeSameAs(typeConverter2);
        typeConverter1.Should().NotBeSameAs(FhirTypeConverter.Default);
    }

    [TestMethod]
    public void CreateContext_WithACustomModelInspector_ShouldBeMemoizedPerModel()
    {
        var model = new ModelInspector(FhirRelease.R4);
        var typeConverter1 = CreateCqlContext(new FhirCqlContextOptions { OverrideModelInspector = model })
            .GetCqlOperators().TypeConverter;
        var typeConverter2 = CreateCqlContext(new FhirCqlContextOptions { OverrideModelInspector = model })
            .GetCqlOperators().TypeConverter;
        typeConverter1.Should().BeSameAs(typeConverter2);
        typeConverter1.Should().NotBeSameAs(FhirTypeConverter.Default);
    }

    protected static CqlContext CreateCqlContext(
        FhirCqlContextOptions? options = null)
    {
        var context = FhirCqlContext.CreateContext(options: options);
        context.Should().NotBeNull();
        return context;
    }
}

file static class Extensions
{
    public static CqlOperators GetCqlOperators(this CqlContext context) => context.Operators.Should().BeOfType<CqlOperators>().Subject;
}

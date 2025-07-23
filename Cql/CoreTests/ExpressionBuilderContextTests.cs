/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Internal;
using Hl7.Cql.Compiler;
using Hl7.Cql.Runtime.Hosting;
using Hl7.Fhir.Model;

namespace CoreTests;

[TestClass]
public class ExpressionBuilderContextTests
{

    [TestMethod]
    public void Get_Property_Uses_TypeResolver()
    {
        using var serviceProvider = ElmToolkitServices.AddCqlCompilerServices(new ServiceCollection().AddDebugLogging()).BuildServiceProvider(validateScopes: true);
        var property = ExpressionBuilderContext.GetProperty(typeof(MeasureReport.PopulationComponent), "id", serviceProvider.GetRequiredService<TypeResolver>())!;
        Assert.AreEqual(typeof(Element), property.DeclaringType);
        Assert.AreEqual(nameof(Element.ElementId), property.Name);
    }
}
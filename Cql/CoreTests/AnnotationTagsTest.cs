/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using static System.Reflection.BindingFlags;

namespace CoreTests;

[TestClass]
public class AnnotationTagsTest
{
    [TestMethod]
    public void TestAttributesWithQuotes()
    {
        // Temporary replacement test for TagsTest.Tags_Containing_Quotes_Must_Be_Escaped_In_CSharp
        // This test will be removed once the original test is implemented.
        // Also remove RR23.cql from Input\ELM\Hl7, then regenerate the ELM, then C# code.

        var methodInfo = typeof(RR23_1_0_0).GetMethod(nameof(RR23_1_0_0.Injury_due_to_falling_rock_within_measurement_period), Public|Instance)!;
        methodInfo.Should().NotBeNull("Method not found.");

        CqlTagAttribute[] attribute = (CqlTagAttribute[])methodInfo.GetCustomAttributes<CqlTagAttribute>();

        (from a in attribute
         let name = a.Name
         orderby name
         let value = a.Value
         select value)
            .Should()
            .BeEquivalentTo(new[]
            {
                "akin to Condition?code:in=http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock&onset-date=sa[Period-start]&onset-date=eb[Period-end]",
                "\"code\",\"onset.ofType(DateTime)\",\"subject.ofType(Patient)\"]",
                "Condition.code http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock",
                "Conditions of type 'Injury due to falling rock' within the measurement period",
            });
    }
}
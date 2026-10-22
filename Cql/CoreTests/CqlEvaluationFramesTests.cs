/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.Compiler.Infrastructure;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Exceptions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Fhir.Errors;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Operators;
using Hl7.Cql.Operators.Errors;
using Hl7.Cql.Primitives.Errors;
using Hl7.Cql.Runtime;

namespace CoreTests;

[TestClass]
public class CqlEvaluationFramesTests
{
    private static readonly CqlVersionedLibraryIdentifier Inner = CqlVersionedLibraryIdentifier.ParseFromIdentifierAndVersion("Inner", "1.0.0");
    private static readonly CqlVersionedLibraryIdentifier Outer = CqlVersionedLibraryIdentifier.ParseFromIdentifierAndVersion("Outer", "2.0.0");
    private static readonly CqlVersionedLibraryIdentifier Retrieves = CqlVersionedLibraryIdentifier.ParseFromIdentifierAndVersion("Retrieves", "1.0.0");

    private static readonly Lazy<LibrarySetInvoker> Invoker = new(() =>
    {
        var cqlToolkit = new CqlToolkit()
                         .AddCqlLibraries(
                             new[]
                             {
                                 """
                                 library Inner version '1.0.0'
                                 parameter "PointParameter" default point from Interval[1, 5]
                                 define "Point": point from Interval[1, 5]
                                 define "Middle": "Point"
                                 define function PointOf(low Integer): point from Interval[low, low + 4]
                                 define function PointNow(): "Point"
                                 define function PointAfter(offset Integer): "Point"
                                 define "ViaParameter": "PointParameter"
                                 """,
                                 """
                                 library Outer version '2.0.0'
                                 include Inner version '1.0.0'
                                 define "Outer": Inner."Point"
                                 define "Deep": Inner."Middle"
                                 define "ViaFunction": Inner.PointAfter(1)
                                 define "ViaParameterlessFunction": Inner.PointNow()
                                 define "Fine": 1
                                 """,
                                 """
                                 library Retrieves version '1.0.0'
                                 using FHIR version '4.0.1'
                                 define "Patients": [Patient]
                                 define "Counted": Count("Patients")
                                 """,
                             }.Select(CqlLibraryString.Parse))
                         .TranslateToElm();
        return new ElmToolkit().AddElmFromCqlToolkit(cqlToolkit).CreateLibrarySetInvoker();
    });

    [TestMethod]
    public void InvokeLibraryDefinition_OfADefinitionThatEvaluatesAFailingDefinition_RecordsBothInnermostFirst()
    {
        var invoke = () => Invoker.Value.InvokeLibraryDefinition(FhirCqlContext.ForBundle(), Outer, "Outer");

        var exception = invoke.Should().Throw<CqlException<CqlPointFromNonUnitIntervalError>>().Which;

        exception.EvaluationFrames.Should().Equal(
            new CqlEvaluationFrame("Inner", "1.0.0", "Point"),
            new CqlEvaluationFrame("Outer", "2.0.0", "Outer"));
        exception.Message.Should().Be(
            "The point from operator requires a unit interval, but was given [1, 5]. "
            + "Thrown while evaluating definition 'Point' of library 'Inner' version '1.0.0'.");
    }

    [TestMethod]
    public void InvokeLibraryDefinition_OfAChainOfDefinitions_RecordsEveryDefinitionInnermostFirst()
    {
        // Outer."Deep" reads Inner."Middle", which reads Inner."Point" in its own library, which throws.
        var invoke = () => Invoker.Value.InvokeLibraryDefinition(FhirCqlContext.ForBundle(), Outer, "Deep");

        var exception = invoke.Should().Throw<CqlException<CqlPointFromNonUnitIntervalError>>().Which;

        exception.EvaluationFrames.Should().Equal(
            new CqlEvaluationFrame("Inner", "1.0.0", "Point"),
            new CqlEvaluationFrame("Inner", "1.0.0", "Middle"),
            new CqlEvaluationFrame("Outer", "2.0.0", "Deep"));
        exception.EvaluationFrames.Select(frame => frame.ToString()).Should().Equal(
            "definition 'Point' of library 'Inner' version '1.0.0'",
            "definition 'Middle' of library 'Inner' version '1.0.0'",
            "definition 'Deep' of library 'Outer' version '2.0.0'");
    }

    [TestMethod]
    public void InvokeLibraryDefinition_OfADefinitionCallingAFunctionWithOperands_ReportsTheFunctionAsItsCaller()
    {
        // Outer."ViaFunction" calls Inner.PointAfter(1), which reads Inner."Point", which throws. A function with
        // operands is not cached, so it has no frame of its own and is reported as the definition that called it.
        var invoke = () => Invoker.Value.InvokeLibraryDefinition(FhirCqlContext.ForBundle(), Outer, "ViaFunction");

        invoke.Should().Throw<CqlException<CqlPointFromNonUnitIntervalError>>()
              .Which.EvaluationFrames.Should().Equal(
                  new CqlEvaluationFrame("Inner", "1.0.0", "Point"),
                  new CqlEvaluationFrame("Outer", "2.0.0", "ViaFunction"));
    }

    [TestMethod]
    public void InvokeLibraryDefinition_OfADefinitionCallingAParameterlessFunction_RecordsTheFunctionToo()
    {
        // Outer."ViaParameterlessFunction" calls Inner.PointNow(), which reads Inner."Point", which throws. A function
        // without operands is cached like a definition, so it has a frame of its own.
        var invoke = () => Invoker.Value.InvokeLibraryDefinition(FhirCqlContext.ForBundle(), Outer, "ViaParameterlessFunction");

        invoke.Should().Throw<CqlException<CqlPointFromNonUnitIntervalError>>()
              .Which.EvaluationFrames.Should().Equal(
                  new CqlEvaluationFrame("Inner", "1.0.0", "Point"),
                  new CqlEvaluationFrame("Inner", "1.0.0", "PointNow"),
                  new CqlEvaluationFrame("Outer", "2.0.0", "ViaParameterlessFunction"));
    }

    [TestMethod]
    public void InvokeLibraryDefinition_OfADefinitionReadingAFailingParameterDefault_RecordsTheParameterToo()
    {
        var invoke = () => Invoker.Value.InvokeLibraryDefinition(FhirCqlContext.ForBundle(), Inner, "ViaParameter");

        invoke.Should().Throw<CqlException<CqlPointFromNonUnitIntervalError>>()
              .Which.EvaluationFrames.Should().Equal(
                  new CqlEvaluationFrame("Inner", "1.0.0", "PointParameter"),
                  new CqlEvaluationFrame("Inner", "1.0.0", "ViaParameter"));
    }

    [TestMethod]
    public void InvokeLibraryDefinition_OfAFailingDefinition_RecordsItOnce()
    {
        var invoke = () => Invoker.Value.InvokeLibraryDefinition(FhirCqlContext.ForBundle(), Inner, "Point");

        invoke.Should().Throw<CqlException<CqlPointFromNonUnitIntervalError>>()
              .Which.EvaluationFrames.Should().Equal(new CqlEvaluationFrame("Inner", "1.0.0", "Point"));
    }

    [TestMethod]
    public void InvokeLibraryDefinition_OfAFailingFunction_RecordsTheFunction()
    {
        var invoke = () => Invoker.Value.InvokeLibraryDefinition(
            FhirCqlContext.ForBundle(), Inner, new DefinitionSignature("PointOf", typeof(int?)), 1);

        invoke.Should().Throw<CqlException<CqlPointFromNonUnitIntervalError>>()
              .Which.EvaluationFrames.Should().Equal(new CqlEvaluationFrame("Inner", "1.0.0", "PointOf"));
    }

    [TestMethod]
    public void InvokeLibraryDefinition_OfAFailingDefinition_ThrowsTheOriginalExceptionFromWhereItWasThrown()
    {
        var invoke = () => Invoker.Value.InvokeLibraryDefinition(FhirCqlContext.ForBundle(), Inner, "Point");

        invoke.Should().Throw<CqlException<CqlPointFromNonUnitIntervalError>>()
              .Which.StackTrace.Should().Contain(nameof(CqlOperators.PointFrom),
                                                 "recording a frame never catches and rethrows the exception");
    }

    [TestMethod]
    public void InvokeLibraryDefinition_OfARetrieveFromAFailingDataSource_RecordsTheDefinitionOnTheDataSourcesException()
    {
        var invoke = () => Invoker.Value.InvokeLibraryDefinition(
            FhirCqlContext.WithDataSource(new FailingDataSource(failsWhenRead: false)), Retrieves, "Patients");

        var exception = invoke.Should().Throw<InvalidOperationException>().WithMessage(FailingDataSource.Failure).Which;

        exception.GetCqlEvaluationFrames().Should().Equal(new CqlEvaluationFrame("Retrieves", "1.0.0", "Patients"));
    }

    [TestMethod]
    public void InvokeLibraryDefinition_OfADefinitionReadingADeferredRetrieve_ReportsTheDefinitionReadingIt()
    {
        // Retrieves."Patients" returns the retrieve without reading it, so it has finished before the data source
        // throws. The failure happens while Retrieves."Counted" reads it, and that is the definition reported.
        var invoke = () => Invoker.Value.InvokeLibraryDefinition(
            FhirCqlContext.WithDataSource(new FailingDataSource(failsWhenRead: true)), Retrieves, "Counted");

        var exception = invoke.Should().Throw<InvalidOperationException>().WithMessage(FailingDataSource.Failure).Which;

        exception.GetCqlEvaluationFrames().Should().Equal(new CqlEvaluationFrame("Retrieves", "1.0.0", "Counted"));
    }

    [TestMethod]
    public void InvokeLibraryDefinition_OfADeferredRetrieve_HasNoFramesWhenTheHostReadsIt()
    {
        // No definition is being evaluated while the host reads the result, so the exception has no frames.
        var patients = (IEnumerable<object>)Invoker.Value.InvokeLibraryDefinition(
            FhirCqlContext.WithDataSource(new FailingDataSource(failsWhenRead: true)), Retrieves, "Patients")!;

        var read = () => patients.ToList();

        var exception = read.Should().Throw<InvalidOperationException>().WithMessage(FailingDataSource.Failure).Which;

        exception.GetCqlEvaluationFrames().Should().BeEmpty();
    }

    [TestMethod]
    public void InvokeLibraryDefinition_OfADefinitionThatSucceeds_ReturnsItsValue() =>
        Invoker.Value.InvokeLibraryDefinition(FhirCqlContext.ForBundle(), Outer, "Fine").Should().Be(1);

    [TestMethod]
    public void EvaluationError_IsCaughtByTheHostPatternForEvaluationErrors()
    {
        ICqlError? caught = null;
        try
        {
            Invoker.Value.InvokeLibraryDefinition(FhirCqlContext.ForBundle(), Outer, "Outer");
        }
        catch (CqlException e) when (e.Error is ICqlEvaluationError)
        {
            caught = e.Error;
        }

        caught.Should().BeOfType<CqlPointFromNonUnitIntervalError>();
    }

    [TestMethod]
    [DataRow(typeof(CqlPointFromNonUnitIntervalError))]
    [DataRow(typeof(CqlUcumYearArithmeticError))]
    [DataRow(typeof(CqlUcumMonthArithmeticError))]
    [DataRow(typeof(ICqlArithmeticError))]
    [DataRow(typeof(CqlInvalidDateTimeComponentsError))]
    [DataRow(typeof(CqlExpandFractionalPerError))]
    [DataRow(typeof(CqlSingletonFromMultipleElementsError))]
    [DataRow(typeof(CqlUnresolvedValueSetError))]
    public void EvaluationErrors_ImplementICqlEvaluationError(Type errorType) =>
        errorType.Should().BeAssignableTo<ICqlEvaluationError>();

    [TestMethod]
    public void CqlException_ThrownOutsideAnyDefinition_HasNoFramesAndItsPlainMessage()
    {
        var exception = new CqlException<CqlPointFromNonUnitIntervalError>(new(1, 5, true, true));

        exception.EvaluationFrames.Should().BeEmpty();
        exception.Message.Should().Be("The point from operator requires a unit interval, but was given [1, 5].");
    }

    [TestMethod]
    public void CqlException_WhoseErrorMessageLacksAFullStop_EndsThatSentenceBeforeNamingTheFrame()
    {
        var exception = new KeyNotFoundError("x").ToException();

        CqlEvaluationFrames.Record(exception, "Lib", "1.0.0", "Def");

        exception.Message.Should().Be(
            "Object not found by key. Key: 'x'. Thrown while evaluating definition 'Def' of library 'Lib' version '1.0.0'.");
    }

    [TestMethod]
    public void Record_OnAnyException_KeepsTheFrameInItsData()
    {
        var exception = new InvalidOperationException("not a CQL error");

        CqlEvaluationFrames.Record(exception, SomeDefinitionCompute)
                           .Should().BeFalse("the exception filter must never catch the exception");

        exception.GetCqlEvaluationFrames().Should().Equal(new CqlEvaluationFrame("Generated", "3.0.0", "Some Definition"));
    }

    [TestMethod]
    public void Record_OfTheSameComputeMethodAgain_ReusesItsFrame()
    {
        var first = new InvalidOperationException();
        var second = new InvalidOperationException();

        CqlEvaluationFrames.Record(first, SomeDefinitionCompute);
        CqlEvaluationFrames.Record(second, SomeDefinitionCompute);

        second.GetCqlEvaluationFrames().Single().Should().BeSameAs(first.GetCqlEvaluationFrames().Single(),
                                                                 "the frame of a compute method is read from its attributes once");
    }

    [TestMethod]
    public void Record_OfAComputeMethodWithoutItsDefinitionMethod_FallsBackToTheMethodName()
    {
        var exception = new InvalidOperationException();

        CqlEvaluationFrames.Record(exception, ReflectionUtility.MethodOf(() => new GeneratedLibrary().Orphan_Compute(null!)));

        CqlEvaluationFrames.Get(exception).Should().Equal(new CqlEvaluationFrame("Generated", "3.0.0", "Orphan"));
    }

    [TestMethod]
    public void Record_OfAMethodOutsideACqlLibrary_RecordsNothing()
    {
        var exception = new InvalidOperationException();

        CqlEvaluationFrames.Record(exception, ReflectionUtility.MethodOf(() => NotInALibrary_Compute(null!)));

        CqlEvaluationFrames.Get(exception).Should().BeEmpty();
    }

    [TestMethod]
    public void Record_OfTheSameFrameTwiceInARow_KeepsOne()
    {
        var exception = new InvalidOperationException();

        CqlEvaluationFrames.Record(exception, "Lib", "1.0.0", "Def");
        CqlEvaluationFrames.Record(exception, "Lib", "1.0.0", "Def");
        CqlEvaluationFrames.Record(exception, "Lib", null, "Other");

        CqlEvaluationFrames.Get(exception).Should().Equal(
            new CqlEvaluationFrame("Lib", "1.0.0", "Def"),
            new CqlEvaluationFrame("Lib", null, "Other"));
    }

    [TestMethod]
    public void Record_OnAnExceptionThrownAgainFromAnotherDefinition_AddsTheSecondPassAfterTheFirst()
    {
        var exception = new InvalidOperationException();

        CqlEvaluationFrames.Record(exception, "Lib", "1.0.0", "Failing");
        CqlEvaluationFrames.Record(exception, "Lib", "1.0.0", "Invoked");
        CqlEvaluationFrames.Record(exception, "Lib", "1.0.0", "Failing");

        exception.GetCqlEvaluationFrames().Should().Equal(
            new CqlEvaluationFrame("Lib", "1.0.0", "Failing"),
            new CqlEvaluationFrame("Lib", "1.0.0", "Invoked"),
            new CqlEvaluationFrame("Lib", "1.0.0", "Failing"));
    }

    [TestMethod]
    public void CqlEvaluationFrame_WithoutAVersion_LeavesTheVersionOutOfItsDescription() =>
        new CqlEvaluationFrame("Lib", null, "Def").ToString().Should().Be("definition 'Def' of library 'Lib'");

    private static readonly MethodInfo SomeDefinitionCompute =
        ReflectionUtility.MethodOf(() => new GeneratedLibrary().Some_Definition_Compute(null!));

    // Shaped like a compute method, but declared outside a CQL library.
    private static int NotInALibrary_Compute(object context) => 0;

    /// <summary>
    /// The shape the code generator gives a library: a public method per definition, attributed with its CQL name, that
    /// computes its value with a private method of the same name and the suffix <c>_Compute</c>.
    /// </summary>
    [CqlLibrary("Generated", "3.0.0")]
    private sealed class GeneratedLibrary
    {
        [CqlExpressionDefinition("Some Definition")]
        public int Some_Definition(object context) => Some_Definition_Compute(context);

        public int Some_Definition_Compute(object context) => 0;

        public int Orphan_Compute(object context) => 0;
    }

    /// <summary>
    /// A data source whose retrieve fails: at once, or, when <paramref name="failsWhenRead"/>, only once the sequence
    /// it returned is read.
    /// </summary>
    private sealed class FailingDataSource(bool failsWhenRead) : IDataSource
    {
        public const string Failure = "The data source failed.";

        public IEnumerable<T> Retrieve<T>(RetrieveParameters? parameters) where T : class =>
            failsWhenRead
                ? Enumerable.Range(0, 1).Select<int, T>(_ => throw new InvalidOperationException(Failure))
                : throw new InvalidOperationException(Failure);
    }
}

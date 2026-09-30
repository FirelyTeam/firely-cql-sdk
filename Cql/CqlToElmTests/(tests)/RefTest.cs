/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using M = Hl7.Fhir.Model;

namespace Hl7.Cql.CqlToElm.Test
{
    using Expression = Hl7.Cql.Elm.Expression;

    [TestClass]
    public class RefTest : Base
    {
        [TestMethod]
        public void ValueSet_Local()
        {
            var library = CreateCqlToolkit().MakeLibrary($"""
                library {nameof(RefTest)} version '1.0.0'

                valueset "vs": 'http://xyz.com'

                define private {nameof(ValueSet_Local)}: "vs"
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(ValueSetRef));
            AssertType(library.statements[0].expression, SystemTypes.ValueSetType);
            var result = Run<CqlValueSet>(library, nameof(ValueSet_Local));
            Assert.IsNotNull(result);
        }

        [TestMethod]
        [Ignore("Will fix in https://github.com/FirelyTeam/firely-cql-sdk/issues/519")]
        public void CodeSystem_Local()
        {
            var library = CreateCqlToolkit().MakeLibrary($"""
                library {nameof(RefTest)} version '1.0.0'

                private codesystem CS: 'id' version 'version string'

                define private {nameof(CodeSystem_Local)}: "CS"
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(CodeSystemRef));
            AssertType(library.statements[0].expression, SystemTypes.CodeSystemType);
            var result = Run<CqlCode[]>(library, nameof(CodeSystem_Local));
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Code_Local()
        {
            var library = CreateCqlToolkit().MakeLibrary($"""
                library {nameof(RefTest)} version '1.0.0'

                private codesystem CS: 'id' version 'version string'
                private code C: 'id' from CS display 'Code display text'

                define private {nameof(Code_Local)}: "C"
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(CodeRef));
            AssertType(library.statements[0].expression, SystemTypes.CodeType);
            var result = Run<CqlCode>(library, nameof(Code_Local));
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Concept_Local()
        {
            var library = CreateCqlToolkit().MakeLibrary($$"""
                library {{nameof(RefTest)}} version '1.0.0'

                private codesystem CS: 'id' version 'version string'
                private code C: 'id' from CS display 'Code display text'
                private concept TheConcept: { C } display 'My concept'

                define private {{nameof(Concept_Local)}}: "TheConcept"
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(ConceptRef));
            AssertType(library.statements[0].expression, SystemTypes.ConceptType);
            var result = Run<CqlConcept>(library, nameof(Concept_Local));
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Parameter()
        {
            var library = CreateCqlToolkit().MakeLibrary($"""
                library {nameof(RefTest)} version '1.0.0'

                private parameter "Measurement Year" System.Integer default 2023

                define private {nameof(Parameter)}: "Measurement Year"
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(ParameterRef));
            AssertType(library.statements[0].expression, SystemTypes.IntegerType);
            var result = Run<int?>(library, nameof(Parameter));
            Assert.IsNotNull(result);
            Assert.AreEqual(2023, result);
        }

        private static T? Run<T>(Library library, string member, Hl7.Fhir.Model.Bundle? bundle = null)
        {
            T? result = default;
            CreateElmToolkit()
                .AddElmLibraries(library)
                .UseLibrarySetInvoker(librarySetInvoker =>
                {
                    var ctx = FhirCqlContext.ForBundle(bundle);
                    var resultObj = (T?)librarySetInvoker.InvokeLibraryDefinition(
                        ctx,
                        library.VersionedLibraryIdentifier!,
                        member);
                    Assert.IsInstanceOfType(resultObj, typeof(T));
                    result = (T?)resultObj;
                });
            return result;
        }


        private static void AssertType(Expression expression, NamedTypeSpecifier spec)
        {
            expression.resultTypeName.Should().Be(spec.name);
            expression.resultTypeSpecifier.Should().Be(spec);
        }

        private ExpressionDef shouldDefineExpression(Library l, string name) =>
            l.ShouldDefine<ExpressionDef>(name);

        private static NamedTypeSpecifier FhirType(string name) =>
            new System.Xml.XmlQualifiedName($"{{http://hl7.org/fhir}}{name}").ToNamedType();

        [TestMethod]
        public void Expression()
        {
            var library = CreateCqlToolkit().MakeLibrary($"""
                library {nameof(RefTest)} version '1.0.0'

                define private four: 4

                define private {nameof(Expression)}: four
                """);

            var f = shouldDefineExpression(library, nameof(Expression));
            var fref = f.expression.Should().BeOfType<ExpressionRef>().Subject;
            AssertType(fref, SystemTypes.IntegerType);
            fref.name.Should().Be("four");

            var result = Run<int>(library, nameof(Expression));
            result.Should().Be(4);
        }

        [TestMethod]
        public void Function()
        {
            var library = CreateCqlToolkit().MakeLibrary($"""
                library {nameof(RefTest)} version '1.0.0'

                define private function double(a Decimal): a*2

                define private {nameof(Function)}: double(4)
                """);

            var f = shouldDefineExpression(library, nameof(Function));
            var fref = f.expression.Should().BeOfType<FunctionRef>().Subject;
            fref.name.Should().Be("double");
            fref.operand.Should().ContainSingleOfType<ToDecimal>().operand.Should().BeLiteralInteger(4);

            var result = Run<decimal>(library, nameof(Function));
            result.Should().Be(8.0m);
        }

        [TestMethod]
        public void FunctionIncorrectNumParam()
        {
            var library = CreateCqlToolkit().MakeLibrary($"""
                library {nameof(RefTest)} version '1.0.0'

                define private function double(a Decimal): a*2

                define private {nameof(Function)}: double(4,5)
                """, "Could not resolve*");
        }

        [TestMethod]
        public void FunctionIncorrectParam()
        {
            var library = CreateCqlToolkit().MakeLibrary($"""
                library {nameof(RefTest)} version '1.0.0'

                define private function double(a Decimal): a*2

                define private {nameof(Function)}: double('hi')
                """, "Could not resolve*");
        }

        [TestMethod]
        public void FunctionVariableParamCount()
        {
            var library1 = CreateCqlToolkit().MakeLibrary($"""
                library {nameof(RefTest)}1 version '1.0.0'
                define private {nameof(Function)}: Date(1)
                """);
            var library2 = CreateCqlToolkit().MakeLibrary($"""
                library {nameof(RefTest)}2 version '1.0.0'
                define private {nameof(Function)}: Date(1,2)
                """);
            var library3 = CreateCqlToolkit().MakeLibrary($"""
                library {nameof(RefTest)}3 version '1.0.0'
                define private {nameof(Function)}: Date(1,2,3)
                """);
            var library4 = CreateCqlToolkit().MakeLibrary($"""
                library {nameof(RefTest)}4 version '1.0.0'
                define private {nameof(Function)}: Date(1,2,3,4)
                """, "Could not resolve *");
            var library5 = CreateCqlToolkit().MakeLibrary($"""
                library {nameof(RefTest)}5 version '1.0.0'
                define private {nameof(Function)}: Date()
                """, "Could not resolve *");
        }

        [TestMethod]
        public void InvokeParameter()
        {
            var library = CreateCqlToolkit().MakeLibrary($"""
                library BareMinimum version '0.0.1'

                 parameter x default 'bla'

                 define {nameof(InvokeParameter)}: x(4)
                """, "Could not resolve call to operator x with signature (Integer).");
        }

        [TestMethod]
        public void InvokeExpression()
        {
            var library = CreateCqlToolkit().MakeLibrary($"""
                library BareMinimum version '0.0.1'

                 define pi: 3.14

                 define {nameof(InvokeExpression)}: pi()
                """, "Could not resolve call to operator pi with signature ().");
        }

        [TestMethod]
        public void InvokeNonLocalFunction()
        {
            var library = CreateCqlToolkit().MakeLibrary($"""
                library BareMinimum version '0.0.1'

                include Math

                define {nameof(InvokeExpression)}: Math.Floor(4)
                """, "Unable to resolve library: Math version 'latest'*", "Could not resolve call to operator*");
        }

        [TestMethod]
        public void InvokeLibrary()
        {
            var library = CreateCqlToolkit().MakeLibrary($"""
                library BareMinimum version '0.0.1'

                include Math

                define {nameof(InvokeExpression)}: Math
                """,
                                                     "Unable to resolve library: Math version 'latest'. Are you sure this library version exists and that you have access?", "Identifier Math is a library and cannot be used as an expression.");
        }

        [TestMethod]
        public void InvokeNonLocalExpression()
        {
            var library = CreateCqlToolkit().MakeLibrary($"""
                library BareMinimum version '0.0.1'

                include Math

                define {nameof(InvokeExpression)}: Math.MaxInt
                """, "Unable to resolve library: Math version 'latest'*", "Could not resolve identifier MaxInt in library Math.");
        }


        [TestMethod]
        public void InvokeNonexistentFluentFunction()
        {
            _ = CreateCqlToolkit().MakeLibrary($"""
                library BareMinimum version '0.0.1'

                using FHIR
                context Patient

                define firstName: Patient.name.bad()
                """, "Could not resolve call to operator*");
        }

        [TestMethod]
        public void InvokeFluentFunction()
        {
            var library = CreateCqlToolkit().MakeLibrary($"""
                library BareMinimum version '0.0.1'

                define fluent function double(a Integer): a*2
                define total: 4.double()
                """);

            var f = shouldDefineExpression(library, "total");
            var fref = f.expression.Should().BeOfType<FunctionRef>().Subject;
            fref.name.Should().Be("double");
            fref.operand.Should().ContainSingle().Which.Should().BeLiteralInteger(4);

            var result = Run<int>(library, "total");
            result.Should().Be(8);
        }

        [TestMethod]
        public void InvokeIntervalMember()
        {
            var library = CreateCqlToolkit().MakeLibrary($"""
                library BareMinimum version '0.0.1'

                define lowI: Interval[1,3].low
                """);

            var low = shouldDefineExpression(library, "lowI");
            low.expression.Should().BeOfType<Property>().Which.path.Should().Be("low");
            low.expression.resultTypeSpecifier.Should().Be(SystemTypes.IntegerType);

            var result = Run<int>(library, "lowI");
            result.Should().Be(1);
        }

        [TestMethod]
        public void InvokeIntervalClosedMember()
        {
            var library = CreateCqlToolkit().MakeLibrary($"""
                library BareMinimum version '0.0.1'

                define closed: Interval[1,3].highClosed
                """);

            var low = shouldDefineExpression(library, "closed");
            low.expression.Should().BeOfType<Property>().Which.path.Should().Be("highClosed");
            low.expression.resultTypeSpecifier.Should().Be(SystemTypes.BooleanType);

            var result = Run<bool>(library, "closed");
            result.Should().Be(true);
        }

        [TestMethod]
        public void InvokeTupleMember()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library BareMinimum version '0.0.1'

                define tupleMember: Tuple { name: 'Ewout' }.name
                """);

            var low = shouldDefineExpression(library, "tupleMember");
            low.expression.Should().BeOfType<Property>().Which.path.Should().Be("name");
            low.expression.resultTypeSpecifier.Should().Be(SystemTypes.StringType);

            var result = Run<string>(library, "tupleMember");
            result.Should().Be("Ewout");
        }

        [TestMethod]
        public void InvokeNonFluentFunctionFluently()
        {
            _ = CreateCqlToolkit().MakeLibrary($"""
                library BareMinimum version '0.0.1'

                define function double(a Integer): a*2
                define total: 4.double()
                """, "Function 'double' is called fluently, but its definition is not marked as fluent.");
        }

        [TestMethod]
        public void InvokeModel()
        {
            _ = CreateCqlToolkit().MakeLibrary($"""
                library BareMinimum version '0.0.1'
                using FHIR

                define error: FHIR
                """, "A reference to a model library is unexpected at this point.");
        }

        [TestMethod]
        public void InvokeQualifiedType()
        {
            _ = CreateCqlToolkit().MakeLibrary($"""
                library BareMinimum version '0.0.1'
                using FHIR

                define error: FHIR.Patient
                """, "A reference to a type is unexpected at this point.");
        }

        [TestMethod]
        public void InvokeNoMembers()
        {
            _ = CreateCqlToolkit().MakeLibrary($"""
                library BareMinimum version '0.0.1'
                using FHIR

                define error: 4.max
                """, "Member 'max' not found for type Integer.");
        }

        [TestMethod]
        public void InvokeChoiceMembers()
        {
            _ = CreateCqlToolkit().MakeLibrary($"""
                library BareMinimum version '0.0.1'
                using FHIR

                define function choice() returns Choice<String,Integer> : external
                define error: choice().left
                """, "Type Choice<String, Integer> has no members.");
        }

        [TestMethod]
        public void InvokeChoiceMemberOnSeveralAlternatives()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library ChoiceMember version '1.0.0'
                using FHIR version '4.0.1'

                define "Onset values": [Condition] C return C.onset.value
                """);

            var query = shouldDefineExpression(library, "Onset values").expression.Should().BeOfType<Query>().Subject;
            var value = query.@return.expression.Should().BeOfType<Property>().Subject;
            value.path.Should().Be("value");
            value.source.Should().BeOfType<Property>().Which.path.Should().Be("onset");

            // Age.value, dateTime.value and string.value; Period and Range have no value element.
            value.resultTypeSpecifier.Should().BeOfType<ChoiceTypeSpecifier>().Which.choice.Should().BeEquivalentTo(
                new TypeSpecifier[]
                {
                    FhirType("decimal"),
                    SystemTypes.DateTimeType,
                    SystemTypes.StringType,
                });
        }

        [TestMethod]
        public void InvokeChoiceMemberOnSingleAlternative()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library ChoiceMember version '1.0.0'
                using FHIR version '4.0.1'

                define "Onset lows": [Condition] C return C.onset.low
                """);

            // Only Range has a low element, so the result is its type rather than a one-member choice.
            var query = shouldDefineExpression(library, "Onset lows").expression.Should().BeOfType<Query>().Subject;
            var low = query.@return.expression.Should().BeOfType<Property>().Subject;
            low.path.Should().Be("low");
            low.resultTypeSpecifier.Should().Be(FhirType("SimpleQuantity"));
        }

        [TestMethod]
        public void InvokeChoiceMemberOnNoAlternative()
        {
            _ = CreateCqlToolkit().MakeLibrary("""
                library ChoiceMember version '1.0.0'
                using FHIR version '4.0.1'

                define "Onset colours": [Condition] C return C.onset.colour
                """, "Type Choice<* has no members.");
        }

        [TestMethod]
        public void InvokeChoiceMemberOnListAlternative()
        {
            _ = CreateCqlToolkit().MakeLibrary("""
                library BareMinimum version '0.0.1'

                define function choice() returns Choice<List<Tuple { a Integer }>, Integer> : external
                define error: choice().a
                """, "Member 'a' of type Choice<* is on its list alternative List<*, which member access on a choice cannot navigate into. Cast the value to List<* with 'as' first.");
        }

        [TestMethod]
        public void InvokeChoiceMemberOnListOfChoiceWithListAlternative()
        {
            // The list's elements are a choice whose own list alternative has the member: the
            // outer list alternative still has it, and must be reported rather than dropped in
            // favour of the outer Tuple alternative.
            _ = CreateCqlToolkit().MakeLibrary("""
                library BareMinimum version '0.0.1'

                define function choice() returns Choice<List<Choice<List<Tuple { a Integer }>, Tuple { a Integer }>>, Tuple { a Integer }> : external
                define error: choice().a
                """, "Member 'a' of type Choice<* is on its list alternative List<*, which member access on a choice cannot navigate into. Cast the value to List<* with 'as' first.");
        }

        [TestMethod]
        public void InvokeChoiceMemberBesideListAlternativeWithoutIt()
        {
            // A list alternative that does not have the member is dropped like any other.
            var library = CreateCqlToolkit().MakeLibrary("""
                library BareMinimum version '0.0.1'

                define function choice() returns Choice<List<Integer>, Tuple { a Integer }> : external
                define member: choice().a
                """);

            shouldDefineExpression(library, "member").expression.resultTypeSpecifier.Should().Be(SystemTypes.IntegerType);
        }

        [TestMethod]
        public void InvokeChoiceMemberOnListAlternativeOfNestedChoice()
        {
            // The outer Tuple alternative has the member too, so dropping the nested choice would
            // let the list alternative inside it go unreported.
            _ = CreateCqlToolkit().MakeLibrary("""
                library BareMinimum version '0.0.1'

                define function choice() returns Choice<Choice<List<Tuple { a Integer }>, String>, Tuple { a Integer }> : external
                define error: choice().a
                """, "Member 'a' of type Choice<* is on its list alternative List<*, which member access on a choice cannot navigate into. Cast the value to List<* with 'as' first.");
        }

        [TestMethod]
        public void InvokeChoiceMemberInSortBy()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library ChoiceMember version '1.0.0'
                using FHIR version '4.0.1'

                define "Sorted by onset": [Condition] C sort by (onset.value as DateTime)
                """);

            // The bare onset resolves on $this, the element being sorted.
            var query = shouldDefineExpression(library, "Sorted by onset").expression.Should().BeOfType<Query>().Subject;
            var by = query.sort.by.Should().ContainSingle().Which.Should().BeOfType<ByExpression>().Subject;
            var value = by.expression.Should().BeOfType<As>().Which.operand.Should().BeOfType<Property>().Subject;
            value.path.Should().Be("value");
            value.resultTypeSpecifier.Should().BeOfType<ChoiceTypeSpecifier>().Which.choice.Should().HaveCount(3);
        }

        [TestMethod]
        public void InvokeChoiceMemberThroughListNavigation()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library ChoiceMember version '1.0.0'
                using FHIR version '4.0.1'

                define "Onset values": ([Condition]).onset.value
                """);

            // Navigating into the list builds a query over its elements, whose return is the
            // member access on the choice-typed onset.
            var query = shouldDefineExpression(library, "Onset values").expression.Should().BeOfType<Query>().Subject;
            var value = query.@return.expression.Should().BeOfType<Property>().Subject;
            value.path.Should().Be("value");
            var choice = value.resultTypeSpecifier.Should().BeOfType<ChoiceTypeSpecifier>().Subject;
            query.resultTypeSpecifier.Should().Be(choice.ToListType());
        }

        [TestMethod]
        public void InvokeType()
        {
            _ = CreateCqlToolkit().MakeLibrary("""
                library BareMinimum version '0.0.1'

                using FHIR
                include Math

                define error: Patient
                """, "Unable to resolve library: Math version 'latest'*", "Could not resolve identifier Patient in the current library.");
        }

        [TestMethod]
        public void InvokeProperty()
        {
            var library = CreateCqlToolkit().MakeLibrary($"""
                library BareMinimum version '0.0.1'
                using FHIR

                context Patient

                define getActive: Patient.active
                """);

            var getName = shouldDefineExpression(library, "getActive");
            var prop = getName.expression.Should().BeOfType<Property>().Subject;
            prop.path.Should().Be("active");
            prop.source.Should().BeOfType<ExpressionRef>().Which.name.Should().Be("Patient");
            prop.resultTypeSpecifier.Should().Be(TestExtensions.ForFhir("boolean"));

            var result = runWithData<M.FhirBoolean>(library, "getActive");
            result!.Value.Should().BeTrue();
        }

        [TestMethod]
        public void InvokeListProperty()
        {
            var library = CreateCqlToolkit().MakeLibrary($"""
                library BareMinimum version '0.0.1'
                using FHIR

                context Patient

                define getName: Patient.name
                """);

            var getName = shouldDefineExpression(library, "getName");
            var prop = getName.expression.Should().BeOfType<Property>().Subject;
            prop.path.Should().Be("name");
            prop.source.Should().BeOfType<ExpressionRef>().Which.name.Should().Be("Patient");
            prop.resultTypeSpecifier.Should().Be(TestExtensions.ForFhir("HumanName").ToListType());

            var result = runWithData<List<M.HumanName>>(library, "getName");
            result.Should().BeEquivalentTo(new[] { new { Given = new[] { "John", "Maria" }, Family = "Doe" } });
        }

        [TestMethod]
        public void InvokeThroughListProperty()
        {
            var library = CreateCqlToolkit().MakeLibrary($"""
                library BareMinimum version '0.0.1'
                using FHIR

                context Patient

                define getName: Patient.name.family
                """);

            var getName = shouldDefineExpression(library, "getName");
            var prop = getName.expression.Should().BeOfType<Query>().Subject;
            prop.resultTypeSpecifier.Should().Be(TestExtensions.ForFhir("string").ToListType());

            var result = runWithData<List<M.FhirString>>(library, "getName");
            result.Should().ContainSingle().Which.Should().BeEquivalentTo(new { Value = "Doe" });
        }

        [TestMethod]
        public void InvokeListPropertyThroughListProperty()
        {
            var library = CreateCqlToolkit().MakeLibrary($"""
                library BareMinimum version '0.0.1'
                using FHIR

                context Patient

                define getName: Patient.name.given
                """);

            var getName = shouldDefineExpression(library, "getName");
            var prop = getName.expression.Should().BeOfType<Flatten>().Subject;
            prop.resultTypeSpecifier.Should().Be(TestExtensions.ForFhir("string").ToListType());

            var result = runWithData<List<M.FhirString>>(library, "getName");
            result.Should().BeEquivalentTo(new[] { new { Value = "John" }, new { Value = "Maria" } });
        }

        [TestMethod]
        public void InvokeListPropertyViaFunction()
        {
            var library = CreateCqlToolkit().MakeLibrary($"""
                library BareMinimum version '0.0.1'

                using FHIR

                context Patient

                // Just here to check that we parse the datatype well.
                define fluent function getContactName(contact List<FHIR.Patient.Contact>): contact.name

                define getName: Patient.contact.getContactName().given
                """);

            var getContactName = library.ShouldDefine<FunctionDef>("getContactName");
            getContactName.operand.Should().ContainSingle().Which
                .Should().BeOfType<OperandDef>().Which
                .resultTypeSpecifier.Should().Be(TestExtensions.ForFhir("Patient.Contact").ToListType());
            getContactName.resultTypeSpecifier.Should().Be(TestExtensions.ForFhir("HumanName").ToListType());

            var getName = shouldDefineExpression(library, "getName");
            var prop = getName.expression.Should().BeOfType<Flatten>().Subject;
            prop.resultTypeSpecifier.Should().Be(TestExtensions.ForFhir("string").ToListType());

            var result = runWithData<List<M.FhirString>>(library, "getName");
            result.Should().BeEquivalentTo(new[] { new { Value = "Wouter" }, new { Value = "Gert" }, new { Value = "Marleen" }, new { Value = "Antonia" } });
        }

        private T? runWithData<T>(Library library, string expressionName)
        {
            var bundle = new M.Bundle();
            var contact1 = new M.Patient.ContactComponent()
            {
                Name = new M.HumanName() { Given = new[] { "Wouter", "Gert" } }
            };
            var contact2 = new M.Patient.ContactComponent()
            {
                Name = new M.HumanName() { Given = new[] { "Marleen", "Antonia" } }
            };


            var patient = new M.Patient
            {
                Active = true,
                Name = new() { new() { Given = new[] { "John", "Maria" }, Family = "Doe" } },
            };

            patient.Contact.Add(contact1);
            patient.Contact.Add(contact2);

            bundle.Entry.Add(new() { Resource = patient });

            return Run<T>(library, expressionName, bundle);
        }
    }
}

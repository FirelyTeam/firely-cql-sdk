using FluentAssertions;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.Scopes;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class SymbolTableTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        private static VersionedIdentifier TestId => new VersionedIdentifier { id = "Test", version = "1.0.0" };
        private static SystemLibrary SystemLibrary => CqlToElmServices.SystemLibrary;

        [TestMethod]
        public void Add_Local_Expression()
        {
            const string name = "simple expression";
            var st = new SymbolTable(TestId.ToString()!, SystemLibrary);
            st.TryAdd(new ExpressionDef { name = name }).Should().BeTrue();
            st.TryResolveSymbol(name, out var resolved).Should().BeTrue();
            resolved.Should().NotBe(null);
            var ed = resolved.Should().BeOfType<ExpressionDef>().Subject;
            ed.name.Should().Be(name);
        }
        [TestMethod]
        public void Add_Local_Function()
        {
            const string name = "simple function";
            var st = new SymbolTable(TestId.ToString()!, SystemLibrary);
            var f1 = new SystemFunction<Expression>(new TypeSpecifier[] { SystemTypes.IntegerType }, SystemTypes.BooleanType, name);
            st.TryAdd(f1).Should().BeTrue();
            st.TryResolveSymbol(name, out var resolved).Should().BeTrue();
            resolved.Should().NotBe(null);
            var fd = resolved.Should().BeOfType<OverloadedFunctionDef>().Subject;
        }
        [TestMethod]
        public void Add_Fluent_Function()
        {
            const string name = "fluent function";
            var st = new SymbolTable(TestId.ToString()!, SystemLibrary);
            var f1 = new SystemFunction<Expression>(new TypeSpecifier[] { SystemTypes.IntegerType }, SystemTypes.BooleanType, name);
            f1.fluent = true;
            f1.fluentSpecified = true;
            st.TryAdd(f1).Should().BeTrue();
            st.TryResolveSymbol(name, out var resolved).Should().BeTrue();
            resolved.Should().NotBe(null);
            var fd = resolved.Should().BeOfType<OverloadedFunctionDef>().Subject;
            fd.Name.Should().Be(name);
            fd.Functions.Should().HaveCount(1);
            fd.Functions.First()!.Fluent.Should().BeTrue();

        }
        [TestMethod]
        public void Add_Overload()
        {
            const string name = "f";
            var st = new SymbolTable(TestId.ToString()!, SystemLibrary);
            var f1 = new SystemFunction<Expression>(new TypeSpecifier[] { SystemTypes.IntegerType }, SystemTypes.BooleanType, name);
            var f2 = new SystemFunction<Expression>(new TypeSpecifier[] { SystemTypes.DecimalType }, SystemTypes.BooleanType, name);
            st.TryAdd(f1).Should().BeTrue();
            st.TryResolveSymbol(name, out var resolved).Should().BeTrue();
            resolved.Should().NotBe(null);
            var fd = resolved.Should().BeOfType<OverloadedFunctionDef>().Subject;
            fd.Name.Should().Be(name);
            resolved.Should().NotBe(null);

            st.TryAdd(f2)
                .Should()
                .BeTrue();
            st.TryResolveSymbol(name, out resolved).Should().BeTrue();
            resolved.Should().NotBe(null);
            fd = resolved.Should().BeOfType<OverloadedFunctionDef>().Subject;
            fd.Name.Should().Be(name);
            resolved.Should().NotBe(null);
        }

        [TestMethod]
        public void Add_Function_To_Expression()
        {
            const string name = "simple expression";
            var st = new SymbolTable(TestId.ToString()!, SystemLibrary);
            st.TryAdd(new ExpressionDef { name = name }).Should().BeTrue();
            st.TryResolveSymbol(name, out var resolved).Should().BeTrue();
            resolved.Should().NotBe(null);
            var ed = resolved.Should().BeOfType<ExpressionDef>().Subject;
            ed.name.Should().Be(name);

            var f1 = new SystemFunction<Expression>(new TypeSpecifier[] { SystemTypes.IntegerType }, SystemTypes.BooleanType, name);
            st.TryAdd(f1).Should().BeFalse();
        }

        [TestMethod]
        public void Add_Expression_To_Expression()
        {
            const string name = "simple expression";
            var st = new SymbolTable(TestId.ToString()!, SystemLibrary);
            st.TryAdd(new ExpressionDef { name = name }).Should().BeTrue();
            st.TryResolveSymbol(name, out var resolved).Should().BeTrue();
            resolved.Should().NotBe(null);
            var ed = resolved.Should().BeOfType<ExpressionDef>().Subject;
            ed.name.Should().Be(name);

            st.TryAdd(new ExpressionDef { name = name }).Should().BeFalse();
        }

        [TestMethod]
        public void Resolve_Operand_Over_Parent_Scope()
        {
            // define a: true
            // define function b(a integer): a
            var st = new SymbolTable(TestId.ToString()!, SystemLibrary);
            st.TryAdd(new ExpressionDef { name = "a" });
            var function = new FunctionDef
            {
                name = "b",
                operand = new[] { new OperandDef { name = "a", operandTypeSpecifier = SystemTypes.IntegerType } }
            }.WithResultType(SystemTypes.IntegerType);
            st.TryAdd(function).Should().Be(true);
            var bodyScope = st.EnterScope("body");
            bodyScope.TryAdd(function.operand[0]);
            bodyScope.TryResolveSymbol("a", out var resolved).Should().BeTrue();
            resolved.Should().BeOfType<OperandDef>();
        }

        [TestMethod]
        public void Resolve_Operand_With_Same_Name_As_Function()
        {
            //define function g(g Integer):  g
            var st = new SymbolTable(TestId.ToString()!, SystemLibrary);
            var function = new FunctionDef
            {
                name = "g",
                operand = new[] { new OperandDef { name = "g", operandTypeSpecifier = SystemTypes.IntegerType } }
            }.WithResultType(SystemTypes.IntegerType);
            st.TryAdd(function).Should().Be(true);
            var bodyScope = st.EnterScope("body");
            bodyScope.TryAdd(function.operand[0]);
            bodyScope.TryResolveSymbol("g", out var resolved).Should().BeTrue();
            resolved.Should().BeOfType<OperandDef>();
        }

        [TestMethod]
        public void Resolve_System_Operator()
        {
            // call add from parent lib (System)
            var st = new SymbolTable(TestId.ToString()!, SystemLibrary);
            st.TryResolveSymbol("Add", out var resolved).Should().BeTrue();
            resolved.Should().BeOfType<OverloadedFunctionDef>();
        }

        [TestMethod]
        public void Resolve_Local_System_Operator()
        {
            //define function Add(a Code, b Code): true
            var st = new SymbolTable(TestId.ToString()!, SystemLibrary);
            var function = new FunctionDef
            {
                name = "Add",
                operand = new[]
                {
                    new OperandDef { name = "a", operandTypeSpecifier = SystemTypes.CodeType },
                    new OperandDef { name = "b", operandTypeSpecifier = SystemTypes.CodeType },
                }
            }.WithResultType(SystemTypes.CodeType);
            st.TryAdd(function);
            st.TryResolveSymbol("Add", out var resolved).Should().BeTrue();
            var overload = resolved.Should().BeOfType<OverloadedFunctionDef>().Subject;
            overload.Functions.Should().HaveCount(1);
            overload.Functions[0].Should().HaveType(SystemTypes.CodeType);
        }

        [TestMethod]
        public void Resolve_Local_System_Operator_Overload()
        {
            //define function Add(a Integer, b Integer):  a* b
            //define callAdd: Add(2, 3)
            // callAdd should be 6
            var st = new SymbolTable(TestId.ToString()!, SystemLibrary);
            var function = new FunctionDef
            {
                name = "Add",
                operand = new[]
                {
                    new OperandDef { name = "a", operandTypeSpecifier = SystemTypes.IntegerType },
                    new OperandDef { name = "b", operandTypeSpecifier = SystemTypes.IntegerType },
                }
            }.WithResultType(SystemTypes.IntegerType);
            st.TryAdd(function);
            st.TryResolveSymbol("Add", out var resolved).Should().BeTrue();
            var overload = resolved.Should().BeOfType<OverloadedFunctionDef>().Subject;
            overload.Functions.Should().HaveCount(1);
            overload.Functions[0].Should().HaveType(SystemTypes.IntegerType);
        }

        [TestMethod]
        public void OverloadedFunctionDef_Can_Combine()
        {
            var f1 = new FunctionDef
            {
                name = "Add",
                operand = new[]
            {
                    new OperandDef { name = "a", operandTypeSpecifier = SystemTypes.CodeType },
                    new OperandDef { name = "b", operandTypeSpecifier = SystemTypes.CodeType },
                }
            }.WithResultType(SystemTypes.CodeType);
            var f2 = new FunctionDef
            {
                name = "Add",
                operand = new[]
            {
                    new OperandDef { name = "a", operandTypeSpecifier = SystemTypes.IntegerType },
                    new OperandDef { name = "b", operandTypeSpecifier = SystemTypes.IntegerType },
                }
            }.WithResultType(SystemTypes.IntegerType);

            OverloadedFunctionDef.CanCombine(f1, f2).Should().BeTrue();
            OverloadedFunctionDef.CanCombine(f1, f1).Should().BeFalse();
        }



        [TestMethod]
        public void ResolveFunction_Local_System_Operator_New_Overload()
        {

            // define function Add(a Code, b Code): true
            // when resolving a function this overload should be combined since it does not conflict
            // with any existing overloads.
            SystemLibrary.TryResolveFunction("Add", out var sysAdd).Should().BeTrue();
            var sysAddOverload = sysAdd.Should().BeOfType<OverloadedFunctionDef>().Subject;
            var st = new SymbolTable(TestId.ToString()!, SystemLibrary);
            var function = new FunctionDef
            {
                name = "Add",
                operand = new[]
                {
                    new OperandDef { name = "a", operandTypeSpecifier = SystemTypes.CodeType },
                    new OperandDef { name = "b", operandTypeSpecifier = SystemTypes.CodeType },
                }
            }.WithResultType(SystemTypes.CodeType);
            st.TryAdd(function);
            st.TryResolveFunction("Add", out var resolved).Should().BeTrue();
            var overload = resolved.Should().BeOfType<OverloadedFunctionDef>().Subject;
            overload.Functions.Should().HaveCount(sysAddOverload.Functions.Count + 1);
            var codeOverload = overload.Functions
                .Any(f => f.ResultTypeSpecifier == SystemTypes.CodeType)
                .Should().BeTrue();
        }

        [TestMethod]
        public void ResolveFunction_Local_System_Operator_Take_Local()
        {

            // define function Add(a Integer, b Integer):  a* b
            // define callAdd: Add(2, 3)
            // when resolving this function, all overloads should be returned, but the integer overload
            // should be the local one.
            SystemLibrary.TryResolveFunction("Add", out var sysAdd).Should().BeTrue();
            var sysAddOverload = sysAdd.Should().BeOfType<OverloadedFunctionDef>().Subject;
            var st = new SymbolTable(TestId.ToString()!, SystemLibrary);
            var function = new FunctionDef
            {
                name = "Add",
                operand = new[]
                {
                    new OperandDef { name = "a", operandTypeSpecifier = SystemTypes.IntegerType },
                    new OperandDef { name = "b", operandTypeSpecifier = SystemTypes.IntegerType },
                },
                localId = "fixed"
            }.WithResultType(SystemTypes.IntegerType);
            st.TryAdd(function);
            st.TryResolveFunction("Add", out var resolved).Should().BeTrue();
            var overload = resolved.Should().BeOfType<OverloadedFunctionDef>().Subject;
            // count should be unchanged.
            overload.Functions.Should().HaveCount(sysAddOverload.Functions.Count);
            var intOverload = overload.Functions.Where(f => f.ResultTypeSpecifier == SystemTypes.IntegerType).Single();
            intOverload
                .Should().BeOfType<FunctionDef>()
                .Subject.localId.Should().Be("fixed");
        }

        [TestMethod]
        public void ResolveFluent_Local()
        {
            var st = new SymbolTable(TestId.ToString()!, SystemLibrary);
            var function = new FunctionDef
            {
                name = "Add",
                operand = new[]
                     {
                    new OperandDef { name = "a", operandTypeSpecifier = SystemTypes.CodeType },
                    new OperandDef { name = "b", operandTypeSpecifier = SystemTypes.CodeType },
                },
                fluent = true,
                fluentSpecified = true,
            }.WithResultType(SystemTypes.CodeType);
            st.TryAdd(function);
            st.TryResolveFunction("Add", out var resolved).Should().BeTrue();
        }
    }
}

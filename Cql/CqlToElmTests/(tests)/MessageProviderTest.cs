/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test
{
    using Expression = Hl7.Cql.Elm.Expression;

    [TestClass]
    public class MessageProviderTest : Base
    {
        // Restated rather than read off the production code, so a change to the rendering is deliberate.
        private const string MissingTypeName = "(missing)";

        // The state a rejected expression is left in: no result type was ever assigned.
        private static Expression UntypedExpression() => new Literal { value = "2147483648" };

        private static Expression TypedExpression(TypeSpecifier type) =>
            new Literal { value = "1" }.WithResultType(type);

        // An overload whose operand is untyped, to reach the candidate rendering in CallIsAmbiguous.
        private static SignatureMatchResult Candidate(Expression operand) =>
            new(SystemLibrary.Floor,
                [new CoercionResult<Expression>(operand, CoercionCost.ExactMatch)],
                new Dictionary<string, TypeSpecifier>(),
                SignatureMatchFlags.Ambiguous,
                () => null);

        [TestMethod]
        public void CouldNotResolveFunction_UntypedArgument_RendersMissingType()
        {
            var messageProvider = CreateCqlToolkit().GetMessageProvider();

            var message = messageProvider.CouldNotResolveFunction("Floor", UntypedExpression());

            message.Should().Contain("Floor").And.Contain(MissingTypeName);
        }

        [TestMethod]
        public void CouldNotResolveFunction_MixOfResolvedAndUntypedArguments_RendersBoth()
        {
            var messageProvider = CreateCqlToolkit().GetMessageProvider();

            var message = messageProvider.CouldNotResolveFunction(
                "Add", TypedExpression(SystemTypes.IntegerType), UntypedExpression());

            message.Should()
                   .Contain($"{SystemTypes.IntegerType}, {MissingTypeName}");
        }

        // Callers pass an expression's resultTypeSpecifier straight into this overload.
        [TestMethod]
        public void CouldNotResolveFunction_NullTypeSpecifier_RendersMissingType()
        {
            var messageProvider = CreateCqlToolkit().GetMessageProvider();

            var message = messageProvider.CouldNotResolveFunction("Start", (TypeSpecifier?)null);

            message.Should().Contain("Start").And.Contain(MissingTypeName);
        }

        [TestMethod]
        public void CallIsAmbiguous_UntypedArgumentAndCandidate_RendersMissingType()
        {
            var messageProvider = CreateCqlToolkit().GetMessageProvider();

            var message = messageProvider.CallIsAmbiguous("Floor", [UntypedExpression()], [Candidate(UntypedExpression())]);

            message.Should().Contain("Floor").And.Contain($"Floor({MissingTypeName})")
                   .And.Contain(MissingTypeName);
        }

        // A library alias used as an expression: the node carries the error and no result type,
        // and operator resolution then fails on it, which is the message that used to throw.
        [TestMethod]
        public void LibraryAliasAsArgument_ReportsBothErrorsInsteadOfThrowing()
        {
            var cqlToolkit = CreateCqlToolkit().AddFHIRHelpers();
            var messageProvider = cqlToolkit.GetMessageProvider();

            cqlToolkit.MakeLibrary("""
                library LibraryAliasAsArgument version '1.0.0'

                include FHIRHelpers version '4.0.1' called FH

                define private "actual": Floor(FH)
                """,
                messageProvider.CouldNotResolveFunction("Floor", (TypeSpecifier?)null),
                messageProvider.ExpressionCannotBeLibraryRef("FH"));
        }
    }
}

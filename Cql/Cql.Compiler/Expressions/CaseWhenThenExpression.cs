/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Hl7.Cql.Compiler
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

    /// <summary>
    /// This is a custom expression representing the Case/When/Then statement in CQL.
    /// </summary>
    /// <remarks>The expression reduces to nested ConditionalExpressions.</remarks>
    internal class CaseWhenThenExpression : Expression
    {
        public record WhenThenCase(Expression When, Expression Then)
        {
            public WhenThenCase Update(Expression when, Expression then)
            {
                if (When == when && Then == then)
                    return this;
                else
                    return new WhenThenCase(when, then);
            }
        }

        public IReadOnlyCollection<WhenThenCase> WhenThenCases { get; }
        public Expression ElseCase { get; }

        public CaseWhenThenExpression(IReadOnlyCollection<WhenThenCase> whenThenCases, Expression elseCase)
        {
            WhenThenCases = whenThenCases;
            ElseCase = elseCase;

            if (!whenThenCases.Any())
                throw new ArgumentException("Should have at least one when/then case.");

            if (whenThenCases.FirstOrDefault(c => !elseCase.Type.IsAssignableFrom(c.Then.Type)) is { } thenTypeErrorCase)
                throw new ArgumentException($"Found a 'then' part in a case of type {thenTypeErrorCase.Then.Type}, which should be the same type as the Else case ({elseCase.Type}).");

            if (whenThenCases.FirstOrDefault(c => c.When.Type != typeof(bool)) is { } whenTypeErrorCase)
                throw new ArgumentException($"All When parts of the cases should be of type boolean, not {whenTypeErrorCase.When.Type}.");
        }

        public override bool CanReduce => true;

        public override ExpressionType NodeType => ExpressionType.Extension;

        public override Expression Reduce()
        {
            return WhenThenCases.Reverse().Aggregate(ElseCase, (acc, wtc) => makeCondition(wtc.When, wtc.Then, acc));

            Expression makeCondition(Expression when, Expression then, Expression els)
            {
                if (then.Type != els.Type)
                {
                    if (then.Type.IsAssignableFrom(els.Type))
                        els = Convert(els, then.Type);
                    else if (els.Type.IsAssignableFrom(then.Type))
                        then = Convert(then, els.Type);
                    // Else: expect Condition factory below to fail.
                }

                return Condition(when, then, els);
            }
        }

        protected override Expression VisitChildren(ExpressionVisitor visitor)
        {
            var visitedCases = WhenThenCases.Select(wtc => wtc.Update(visitor.Visit(wtc.When), visitor.Visit(wtc.Then)));

            return Update(visitedCases.ToList().AsReadOnly(), visitor.Visit(ElseCase));
        }

        public Expression Update(IReadOnlyCollection<WhenThenCase> whenThenCases, Expression elseCase)
        {
            if (Enumerable.SequenceEqual(WhenThenCases, whenThenCases) && ElseCase == elseCase)
                return this;
            else
                return new CaseWhenThenExpression(whenThenCases, elseCase);
        }

        public override Type Type => ElseCase.Type;
    }
}

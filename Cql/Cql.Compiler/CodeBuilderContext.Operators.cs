/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Elm;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Compiler;

using Convert = System.Convert;
using TypeSpecifier = Hl7.Cql.Elm.TypeSpecifier;

/// <summary>
/// The ELM operators (arithmetic, comparison, messaging, interval, nullological and type
/// operators, plus the ChangeType helpers).
/// </summary>
partial class CodeBuilderContext
{
    #region ArithmeticOperators

    private const string Int32MaxPlusOneAsString = "2147483648";

    private CodeExpression NegateLiteral(Negate e, Literal literal)
    {
        // handle things like -2147483648 which gets translated to Negate(2147483648)
        // since int.MaxValue is 2147483647, we have to handle this specially
        var literalType = TypeFor(literal);
        if (literalType == typeof(int?) && literal.value == Int32MaxPlusOneAsString)
            return new CodeConstant(int.MinValue, typeof(int));

        if (literalType == typeof(long?)
            && literal.value == long.MinValue.ToString(CultureInfo.InvariantCulture))
            return new CodeConstant(long.MinValue, typeof(long));

        return BindCqlOperator(nameof(ICqlOperators.Negate), e.operand);
    }

    private CodeExpression Negate(Negate e)
    {
        if (e.operand is Literal literal)
            return NegateLiteral(e, literal);

        return BindCqlOperator(nameof(ICqlOperators.Negate), e.operand);
    }

    #endregion

    #region ComparisonOperators

    protected CodeExpression Equivalent(Equivalent eqv)
    {
        if (TranslateArgs(eqv.operand) is [{ } left, { } right]
            && _typeResolver.GetListElementType(left.Type, throwError: false) is { } leftType
            && _typeResolver.GetListElementType(right.Type, throwError: false) is { } rightType
            && leftType != rightType)
        {
            // This appears in the CQL tests:
            //  { 'a', 'b', 'c' } ~ { 1, 2, 3 } = false
            return new CodeConstant(false, typeof(bool?));
        }

        return BindCqlOperator(nameof(ICqlOperators.Equivalent), GetBindArgs(eqv));
    }

    #endregion

    #region ErrorsAndMessaging

    private CodeExpression Message(Message e)
    {
        var condition = TranslateArg(e.condition!);

        var source = TranslateArg(e.source!);
        var code = TranslateArg(e.code!);
        var severity = TranslateArg(e.severity!);
        var message = TranslateArg(e.message!);

        if (source is CodeConstant { Value: null } constant)
        {
            // create an explicit "null as object" so the generic type can be inferred in source code.
            // NOTE(phase4): ported as-is — constant.Type == constant.Type trivially, so
            // NewAssignToTypeExpression short-circuits on the exact-type check and this is a
            // no-op (source is reassigned to the same instance). Kept faithful to the old code.
            source = constant.NewAssignToTypeExpression(constant.Type);
        }

        var call = BindCqlOperator(nameof(ICqlOperators.Message), source, code, severity, message);
        if (condition.Type.IsNullableValueType(out _))
        {
            condition = condition.Coalesce();
        }

        return new CodeConditional(condition, call, source, call.Type);
    }

    #endregion

    #region IntervalOperators

    protected CodeExpression? Includes(Includes e)
    {
        var left = TranslateArg(e.operand![0]);
        var right = TranslateArg(e.operand![1]);
        if (_typeResolver.IsListType(left.Type))
        {
            var leftElementType = _typeResolver.GetListElementType(left.Type);
            if (_typeResolver.IsListType(right.Type))
            {
                // Reading left.Type here was a long-standing copy-paste bug (#1342) that made
                // this mismatch check compare the left element type against itself, so it
                // could never fire.
                var rightElementType = _typeResolver.GetListElementType(right.Type);
                if (leftElementType != rightElementType)
                    throw this.NewExpressionBuildingException(
                        $"Includes: the list operands' element types differ ({leftElementType} vs {rightElementType}).");
                return BindCqlOperator(nameof(ICqlOperators.ListIncludesList), left, right);
            }

            if (leftElementType != right.Type)
                throw this.NewExpressionBuildingException();
            return BindCqlOperator(nameof(ICqlOperators.ListIncludesElement), left, right);
        }

        if (left.Type.IsCqlInterval(out var leftPointType))
        {
            if (right.Type.IsCqlInterval(out var pointType))
            {
                var precision = ((IGetPrecision)e).GetPrecision();
                return BindCqlOperator(nameof(ICqlOperators.IntervalIncludesInterval), left, right, precision);
            }
            else
            {
                var precision = ((IGetPrecision)e).GetPrecision();
                return BindCqlOperator(nameof(ICqlOperators.IntervalIncludesElement), left, right, precision);
            }
        }

        throw new NotImplementedException().WithContext(this);
    }

    protected CodeExpression IncludedIn(IncludedIn e)
    {
        var left = TranslateArg(e.operand![0]);
        var right = TranslateArg(e.operand![1]);
        if (_typeResolver.IsListType(left.Type))
        {
            var leftElementType = _typeResolver.GetListElementType(left.Type);
            if (_typeResolver.IsListType(right.Type))
            {
                // Reading left.Type here was the same copy-paste bug (#1342) as in Includes()
                // above — the mismatch check could never fire.
                var rightElementType = _typeResolver.GetListElementType(right.Type);
                if (leftElementType != rightElementType)
                    throw this.NewExpressionBuildingException(
                        $"IncludedIn: the list operands' element types differ ({leftElementType} vs {rightElementType}).");
                return BindCqlOperator(nameof(ICqlOperators.ListIncludesList), right, left);
            }

            if (leftElementType != right.Type)
                throw this.NewExpressionBuildingException();
            return BindCqlOperator(nameof(ICqlOperators.ListIncludesElement), right, left);
        }

        if (left.Type.IsCqlInterval(out var leftPointType) && right.Type.IsCqlInterval(out var rightPointType))
        {
            var precision = ((IGetPrecision)e).GetPrecision();
            return BindCqlOperator(nameof(ICqlOperators.IntervalIncludesInterval), right, left, precision);
        }

        if (right.Type.IsCqlInterval(out var pointType))
        {
            var precision = ((IGetPrecision)e).GetPrecision();
            if (left.Type != pointType)
                throw this.NewExpressionBuildingException();
            return BindCqlOperator(nameof(ICqlOperators.IntervalIncludesElement), right, left, precision);
        }

        throw new NotImplementedException().WithContext(this);
    }

    protected CodeExpression? ProperIncludes(ProperIncludes e)
    {
        var left = TranslateArg(e.operand![0]);
        var right = TranslateArg(e.operand![1]);
        if (left.Type.IsCqlInterval(out var leftPointType))
        {
            var precision = ((IGetPrecision)e).GetPrecision();
            if (right.Type.IsCqlInterval(out var rightPointType))
            {
                return BindCqlOperator(nameof(ICqlOperators.IntervalProperlyIncludesInterval), left, right, precision);
            }

            return BindCqlOperator(nameof(ICqlOperators.IntervalProperlyIncludesElement), left, right, precision);
        }

        if (_typeResolver.IsListType(left.Type))
        {
            // var leftElementType = _typeResolver.GetListElementType(left.Type);
            if (_typeResolver.IsListType(right.Type))
            {
                // var rightElementType = _typeResolver.GetListElementType(right.Type);
                return BindCqlOperator(nameof(ICqlOperators.ListProperlyIncludesList), left, right);
            }

            return BindCqlOperator(nameof(ICqlOperators.ListProperlyIncludesElement), left, right);
        }

        throw new NotImplementedException().WithContext(this);
    }


    protected CodeExpression? ProperIncludedIn(ProperIncludedIn e)
    {
        var left = TranslateArg(e.operand![0]);
        var right = TranslateArg(e.operand![1]);
        if (left.Type.IsCqlInterval(out var leftPointType))
        {
            if (right.Type.IsCqlInterval(out var rightPointType))
            {
                var precision = ((IGetPrecision)e).GetPrecision();
                return BindCqlOperator(nameof(ICqlOperators.IntervalProperlyIncludesInterval), right, left, precision);
            }
        }
        else if (_typeResolver.IsListType(left.Type))
        {
            var leftElementType = _typeResolver.GetListElementType(left.Type);
            if (_typeResolver.IsListType(right.Type))
            {
                var rightElementType = _typeResolver.GetListElementType(right.Type);
                if (leftElementType != rightElementType)
                    throw this.NewExpressionBuildingException();
                return BindCqlOperator(nameof(ICqlOperators.ListProperlyIncludesList), right, left);
            }
        }
        else if (right.Type.IsCqlInterval(out var rightPointType))
        {
            var precision = ((IGetPrecision)e).GetPrecision();
            return BindCqlOperator(nameof(ICqlOperators.IntervalProperlyIncludesElement), right, left, precision);
        }

        throw new NotImplementedException().WithContext(this);
    }

    private CodeExpression? ProperIn(ProperIn e)
    {
        var element = TranslateArg(e.operand![0]);
        var intervalOrList = TranslateArg(e.operand![1]);
        if (intervalOrList.Type.IsCqlInterval(out var pointType))
        {
            var precision = ((IGetPrecision)e).GetPrecision();
            return BindCqlOperator(nameof(ICqlOperators.IntervalProperlyIncludesElement), intervalOrList, element, precision);
        }

        if (_typeResolver.IsListType(intervalOrList.Type))
        {
            return BindCqlOperator(nameof(ICqlOperators.ListProperlyIncludesElement), intervalOrList, element);
        }

        throw new NotImplementedException().WithContext(this);
    }

    protected CodeExpression? ProperContains(ProperContains e)
    {
        var left = TranslateArg(e.operand![0]);
        var right = TranslateArg(e.operand![1]);
        if (_typeResolver.IsListType(left.Type))
        {
            var leftElementType = _typeResolver.GetListElementType(left.Type);
            if (_typeResolver.IsListType(right.Type))
            {
                var rightElementType = _typeResolver.GetListElementType(right.Type);
                if (leftElementType != rightElementType)
                    throw this.NewExpressionBuildingException();
                return BindCqlOperator(nameof(ICqlOperators.ListProperlyIncludesList), left, right);
            }

            if (leftElementType != right.Type)
                throw this.NewExpressionBuildingException();
            return BindCqlOperator(nameof(ICqlOperators.ListProperlyIncludesElement), left, right);
        }

        if (left.Type.IsCqlInterval(out var leftPointType))
        {
            if (leftPointType != right.Type)
                throw this.NewExpressionBuildingException();
            var precision = ((IGetPrecision)e).GetPrecision();
            return BindCqlOperator(nameof(ICqlOperators.IntervalProperlyIncludesElement), left, right, precision);
        }

        throw new NotImplementedException().WithContext(this);
    }

    #endregion

    #region NullologicalOperators

    protected CodeExpression Coalesce(Coalesce ce)
    {
        var operands = TranslateArgs(ce.operand);

        if (operands.Length == 1 && _typeResolver.IsListType(operands[0].Type))
            return BindCqlOperator(nameof(ICqlOperators.Coalesce), operands[0]);

        var distinctOperandTypes = operands
                                   .Select(op => op.Type)
                                   .Distinct()
                                   .ToArray();
        if (distinctOperandTypes.Length != 1)
            throw this.NewExpressionBuildingException("All operand types should match when using Coalesce");

        var type = operands[0].Type;
        if (type.IsValueType && !type.IsNullableValueType(out _))
            throw new NotSupportedException("Coalesce on value types is not defined.");

        if (operands.Length == 1)
            return operands[0];

        CodeExpression coalesce = new CodeBinary(CodeBinaryOp.Coalesce, operands[0], operands[1]);
        for (int i = 2; i < operands.Length; i++)
        {
            coalesce = new CodeBinary(CodeBinaryOp.Coalesce, coalesce, operands[i]);
        }

        return coalesce;
    }

    protected CodeExpression IsNull(IsNull isn)
    {
        var operand = TranslateArg(isn.operand!);
        while (true)
        {
            // NOTE(phase4): the old code unwrapped two distinct node shapes that both represent
            // a cast to object — the custom ElmAsExpression node and a raw
            // UnaryExpression(Convert/ConvertChecked/TypeAs). The IR collapses both into CodeCast
            // (see its doc comment), so a single check here covers what used to be two separate
            // loop iterations in the Expression-based pipeline.
            if (operand is CodeCast { Type: var asType } cast && asType == typeof(object))
            {
                operand = cast.Operand;
                continue;
            }

            break;
        }

        if (operand.Type.IsValueType && operand.Type.IsNullableValueType(out _) == false)
            return new CodeConstant(false, typeof(bool?));


        var compare = new CodeBinary(CodeBinaryOp.Equal, operand, new CodeConstant(null, operand.Type));
        return compare;
        //var asNullableBool = compare.NewAssignToTypeExpression<bool?>();
        //return asNullableBool;
    }

    #endregion

    #region LogicalOperators

    // CQL's and/or/not use Kleene three-valued logic (spec §9.B Logical Operators carries the
    // truth tables; §9.B Nullological Operators is a DIFFERENT section, covering
    // Null/IsNull/IsTrue/IsFalse/Coalesce), which is exactly the semantics C# gives the lifted &, | and
    // ! operators on bool? — so these lower to native operators instead of ICqlOperators
    // calls. and/or additionally short-circuit: the right operand's evaluation stays inside
    // a conditional branch entered only when the left operand hasn't already decided the
    // result (left == false for and, left == true for or). A null left decides NOTHING —
    // null and false is false — so null must not short-circuit; an implementation shortcut
    // like `left != true` would be a correctness bug (#1514).
    //
    // Xor stays on the name-based ICqlOperators path because it genuinely cannot skip: every
    // xor row varies with the right operand, and C# has no lifted ^ over bool? matching Kleene.
    //
    // Implies short-circuits too — the spec calls that skip out EXPLICITLY, unlike and/or where
    // it merely declines to prescribe evaluation ("Note that implies may use short-circuit
    // evaluation in the case that the first operand evaluates to false", §9.B Logical Operators
    // and §4 Logical Specification). See Implies below for the two ways it differs from and/or.

    protected CodeExpression And(And and) =>
        ShortCircuitBinary(and, CodeBinaryOp.BoolAnd, decidingValue: false);

    protected CodeExpression Or(Or or) =>
        ShortCircuitBinary(or, CodeBinaryOp.BoolOr, decidingValue: true);

    protected CodeExpression Not(Not not)
    {
        var operand = TranslateBoolArg(not.operand
            ?? throw this.NewExpressionBuildingException("Not has no operand."));

        // not <constant> folds — and MUST fold, see HonestBoolOperand: `!true` would print
        // as a non-nullable bool while the IR type says bool?.
        if (TryGetBoolConstant(operand, out var constant))
            return NullableBoolConstant(constant is null ? null : !constant);

        return new CodeUnary(CodeUnaryOp.Not, operand);
    }

    /// <summary>
    /// Lowers <c>implies</c> to the same guarded shape as and/or, with two differences that keep
    /// it out of <see cref="ShortCircuitBinary"/>:
    /// <list type="number">
    /// <item>its deciding LEFT value and its deciding RESULT differ — <c>false implies X</c> is
    /// <see langword="true"/> for every X, where and/or both yield the value they tested for;</item>
    /// <item>C# has no implies operator, so the merge is <c>!left | right</c>, which IS Kleene
    /// implication: <c>true implies X</c> = X, <c>false implies X</c> = true,
    /// <c>null implies true</c> = true, and null otherwise.</item>
    /// </list>
    /// The right-operand folds differ for the same reason: <c>X implies true</c> is true for
    /// every X (so it absorbs), but <c>X implies false</c> is <c>not X</c> rather than X, so it
    /// is not a pass-through and falls to the merge.
    /// </summary>
    protected CodeExpression Implies(Implies implies)
    {
        if (implies.operand is not [{ } leftElement, { } rightElement])
            throw this.NewExpressionBuildingException("Implies expects exactly two operands.");

        var left = TranslateBoolArg(leftElement);
        var right = TranslateBoolArg(rightElement);

        if (TryGetBoolConstant(left, out var leftConstant))
        {
            if (leftConstant is false)
                return NullableBoolConstant(true);  // false implies X => true (X never evaluated)
            if (leftConstant is true)
                return right;                       // true implies X => X
            return ImpliesMerge(left, right);       // a null left decides nothing: null implies true is true
        }

        if (TryGetBoolConstant(right, out var rightConstant) && rightConstant is true)
            return NullableBoolConstant(true);      // X implies true => true, erasing the left operand

        // A false or null right constant is NOT deciding (true implies false is false, but
        // false implies false is true), and is free to re-read, so both merge without a guard.
        if (IsEvaluatedValue(right))
            return ImpliesMerge(left, right);

        var originTag = implies.locator is { Length: > 0 } locator
            ? $"CQL 'implies' ({locator})"
            : "CQL 'implies'";
        const string originDetail = "right operand skipped when left is false";

        // Same non-nullable-left shortcut as and/or: a left operand that cannot be null decides
        // by itself, so no local and no merge — where control falls through, left is true, and
        // true implies X is X.
        if (left is CodeCast { Operand: { } nonNullableLeft }
            && nonNullableLeft.Type == typeof(bool)
            && IsFreeToRepeat(nonNullableLeft))
        {
            return new CodeConditional(
                new CodeUnary(CodeUnaryOp.Not, nonNullableLeft),
                NullableBoolConstant(true),
                right,
                typeof(bool?),
                originTag,
                originDetail);
        }

        var local = new CodeLocal(typeof(bool?));
        var guard = new CodeBinary(CodeBinaryOp.Equal, local, new CodeConstant(false, typeof(bool?)));
        var conditional = new CodeConditional(
            guard,
            NullableBoolConstant(true),
            ImpliesMerge(local, right),
            typeof(bool?),
            originTag,
            originDetail);
        return new CodeLet(local, left, conditional);
    }

    /// <summary><c>!left | right</c> — Kleene implication over C#'s lifted operators.</summary>
    private static CodeExpression ImpliesMerge(CodeExpression left, CodeExpression right) =>
        new CodeBinary(
            CodeBinaryOp.BoolOr,
            new CodeUnary(CodeUnaryOp.Not, HonestBoolOperand(left)),
            HonestBoolOperand(right));

    private CodeExpression ShortCircuitBinary(Elm.BinaryExpression binary, CodeBinaryOp op, bool decidingValue)
    {
        if (binary.operand is not [{ } leftElement, { } rightElement])
            throw this.NewExpressionBuildingException($"{binary.GetType().Name} expects exactly two operands.");

        var left = TranslateBoolArg(leftElement);
        var right = TranslateBoolArg(rightElement);

        // Constant operands fold over the Kleene table where a single operand already fixes
        // the outcome (the deciding constant absorbs; its dual passes the other operand
        // through unchanged). Real CQL rarely writes `true and X`, but the CqlToElmTests XML
        // harness wraps every case in constant-operand and/or shapes, and folding also keeps
        // this lowering out of PrintConstant's blind spot (see HonestBoolOperand below).
        if (TryGetBoolConstant(left, out var leftConstant))
        {
            if (leftConstant == decidingValue)
                return NullableBoolConstant(decidingValue); // false and X => false (skipping X is what this whole lowering is for)
            if (leftConstant == !decidingValue)
                return right;                               // true and X => X
            // A null left decides nothing (null and false = false): merge without a guard —
            // a guard could never skip anyway, since null must not short-circuit.
            return new CodeBinary(op, HonestBoolOperand(left), HonestBoolOperand(right));
        }

        if (TryGetBoolConstant(right, out var rightConstant))
        {
            if (rightConstant == decidingValue)
                return NullableBoolConstant(decidingValue); // X and false => false; X or true => true.
                                                            // Erases the LEFT operand too - value-exact
                                                            // for all of Kleene (even null or true = true),
                                                            // spec-permitted (evaluation of logical operands
                                                            // is not prescribed), and consistent with the
                                                            // left-deciding fold above; folds cascade, so
                                                            // e1 or (e2 or true) collapses to true outright.
            if (rightConstant == !decidingValue)
                return left;                                // X and true => X (left still evaluated)
            // null-valued right constant: not foldable (false or null = null but true or null = true);
            // falls through to the guard-free merge below.
        }

        // A right operand that is already an evaluated value costs nothing to re-read, so
        // the combine emits without a guard: x_ & y_.
        if (IsEvaluatedValue(right))
            return new CodeBinary(op, left, HonestBoolOperand(right));

        var operatorName = op == CodeBinaryOp.BoolAnd ? "and" : "or";
        var originTag = binary.locator is { Length: > 0 } locator
            ? $"CQL '{operatorName}' ({locator})"
            : $"CQL '{operatorName}'";
        var originDetail = $"right operand skipped when left is {(decidingValue ? "true" : "false")}";

        // A left operand whose UNDERLYING type is non-nullable bool cannot evaluate to null, so
        // it decides on its own and needs neither a local nor a merge: test it directly, and let
        // the non-deciding branch BE the right operand. Where control reaches that branch the
        // left operand is known to be !deciding, and !deciding is the identity for the operator
        // (false or X = X, true and X = X), so `left op right` there would only re-read a value
        // whose contribution is nothing. Soundness rests on the TYPE, not on a list of node
        // shapes: a bool? left operand may be null, and null decides nothing, which is exactly
        // why the guarded form below must keep the merge.
        // ...and only when repeating it is free. The test prints fully inline, so anything the
        // right operand derives from the same receiver re-derives it instead of reading a shared
        // local — measured at +14 accessor calls (Start/End/SingletonFrom/LateBoundProperty)
        // across the corpora when calls were allowed here. Property chains stay eligible: they
        // are side-effect free and cost nothing worth a local.
        if (left is CodeCast { Operand: { } nonNullableLeft }
            && nonNullableLeft.Type == typeof(bool)
            && IsFreeToRepeat(nonNullableLeft))
        {
            return new CodeConditional(
                decidingValue ? nonNullableLeft : new CodeUnary(CodeUnaryOp.Not, nonNullableLeft),
                NullableBoolConstant(decidingValue),
                right,
                typeof(bool?),
                originTag,
                originDetail);
        }

        // let a = left; a == deciding ? deciding : a <op> right
        // The left operand binds to a local once (both the guard and the combine read it),
        // and the conditional keeps the right operand inside the non-deciding branch. The
        // emitter prints this as a lazy ternary or an if/else block — either form
        // short-circuits without allocating (contrast the Lazy<bool?> overloads, which cost
        // a Lazy plus a closure per operand).
        var local = new CodeLocal(typeof(bool?));
        var guard = new CodeBinary(CodeBinaryOp.Equal, local, new CodeConstant(decidingValue, typeof(bool?)));
        var conditional = new CodeConditional(
            guard,
            new CodeConstant(decidingValue, typeof(bool?)),
            new CodeBinary(op, local, right),
            typeof(bool?),
            originTag,
            originDetail);
        return new CodeLet(local, left, conditional);
    }

    private CodeExpression TranslateBoolArg(object element)
    {
        var expression = TranslateArg(element);
        return expression.Type == typeof(bool?)
            ? expression
            : expression.NewAssignToTypeExpression(typeof(bool?));
    }

    private static bool IsEvaluatedValue(CodeExpression node) =>
        node switch
        {
            // CodeDefault belongs here for the same reason TryGetBoolConstant accepts it:
            // default(bool?) is a null constant in all but name. Without it, a default-shaped
            // right operand reached the guard path and got a let, a conditional and a hoisted
            // local built around a compile-time constant — and was the one merge operand never
            // passed through HonestBoolOperand.
            CodeConstant or CodeDefault or CodeLocal or CodeContextParameter => true,
            CodeCast cast => IsEvaluatedValue(cast.Operand),
            _ => false,
        };

    /// <summary>
    /// Whether evaluating this subtree twice costs nothing observable — reads of locals,
    /// parameters, constants and property chains, plus the operators over them. Deliberately
    /// whitelist-shaped with a <see langword="false"/> default: an unrecognized node (a call, an
    /// aggregate, a retrieve, or a node type added later) must be assumed to do real work, which
    /// keeps the guarded form that binds it to a local exactly once.
    /// </summary>
    private static bool IsFreeToRepeat(CodeExpression node) =>
        node switch
        {
            CodeConstant or CodeDefault or CodeLocal or CodeContextParameter => true,
            CodeProperty p => p.Receiver is null || IsFreeToRepeat(p.Receiver),
            CodeCast c => IsFreeToRepeat(c.Operand),
            CodeTypeIs t => IsFreeToRepeat(t.Operand),
            CodeUnary u => IsFreeToRepeat(u.Operand),
            CodeBinary b => IsFreeToRepeat(b.Left) && IsFreeToRepeat(b.Right),
            _ => false,
        };

    /// <summary>The operand's boolean value when it is a (possibly cast-wrapped) bool/bool?
    /// constant; <paramref name="value"/> is null for a null-valued constant.</summary>
    private static bool TryGetBoolConstant(CodeExpression node, out bool? value)
    {
        switch (node)
        {
            case CodeConstant { Value: bool b }:
                value = b;
                return true;
            case CodeConstant { Value: null } constant
                when constant.Type == typeof(bool?) || constant.Type == typeof(bool) || constant.Type == typeof(object):
                value = null;
                return true;
            case CodeDefault @default
                when @default.Type == typeof(bool?) || @default.Type == typeof(bool) || @default.Type == typeof(object):
                // default(bool?) is a null constant in all but name; without this case a
                // CodeDefault operand escapes the mandatory fold and prints as a bare
                // 'null'/'default' literal in an operator position (CS8310).
                value = null;
                return true;
            case CodeCast cast:
                return TryGetBoolConstant(cast.Operand, out value);
            default:
                value = null;
                return false;
        }
    }

    private static CodeExpression NullableBoolConstant(bool? value) =>
        new CodeConstant(value, typeof(bool?));

    /// <summary>
    /// Makes a merge operand print with the type the IR says it has. A bool? CONSTANT prints
    /// as a bare bool literal (<c>true</c>, or <c>default</c> for null), so a merge over two
    /// such operands would print as non-nullable bool — and downstream prints that trust the
    /// IR type (an <c>is null</c> pattern needs a nullable operand; a bare <c>default</c> has
    /// no type at all in an operator position) produce illegal C#. An explicit cast keeps the
    /// printed type honest. Non-constant operands already print as bool? — either genuinely
    /// so, or via the cast <see cref="TranslateBoolArg"/> wrapped them in.
    /// </summary>
    private static CodeExpression HonestBoolOperand(CodeExpression node)
    {
        if (!TryGetBoolConstant(node, out var value))
            return node;

        // A null-valued constant cannot keep a (bool?) cast: PrintCast collapses any cast
        // over a null CodeConstant back to the bare literal ('default'), which is illegal in
        // an operator position (CS8310). `null as bool?` over a CodeDefault survives printing
        // with its type intact. true/false constants keep the explicit cast.
        if (value is null)
            return new CodeCast(new CodeDefault(typeof(bool?)), typeof(bool?), CodeCastKind.As);

        return node is CodeCast ? node : new CodeCast(node, typeof(bool?), CodeCastKind.Cast);
    }

    #endregion

    #region Type Operators

    protected CodeExpression As(As @as) //@ TODO: Cast - As
    {
        var castKind = @as.strict ? CodeCastKind.Cast : CodeCastKind.As;

        if (@as.operand is List list)
        {
            using (PushElement(list))
            {
                // create new ListType[0]; instead of new object[0] as IEnumerable<object> as IEnumerable<ListType>;
                if ((list.element?.Length ?? 0) == 0)
                {
                    var type = TypeFor(@as.asTypeSpecifier!)!;
                    if (_typeResolver.IsListType(type))
                    {
                        var listElementType = _typeResolver.GetListElementType(type) ??
                                              throw this.NewExpressionBuildingException(
                                                  $"{type} was expected to be a list type.");
                        var newArray = new CodeNewArrayBounds(listElementType, new CodeConstant(0, typeof(int)));
                        return new CodeCast(newArray, type, castKind);
                    }
                    else if (type == _typeResolver.AnyType) // handles untyped empty lists whose type is Any
                    {
                        var newArray = new CodeNewArrayBounds(_typeResolver.AnyType, new CodeConstant(0, typeof(int)));
                        return new CodeCast(newArray, type, castKind);
                    }

                    throw this.NewExpressionBuildingException(
                        "Cannot use as operator on a list if the as type is not also a list type.");
                }
            }
        }

        // asTypeSpecifier is an expression with its own resulttypespecifier that actually contains the real type
        if (@as.asTypeSpecifier != null)
        {
            using (PushElement(@as.asTypeSpecifier))
            {
                if (@as.operand is Null)
                {
                    var type = TypeFor(@as.asTypeSpecifier!)!;
                    var defaultExpression = new CodeDefault(type);
                    return new CodeCast(defaultExpression, type, castKind);
                }
                else
                {
                    var type = TypeFor(@as.asTypeSpecifier!)!;
                    var operand = TranslateArg(@as.operand!);
                    var converted = ChangeType(operand, type, out var typeConversion, considerSafeUpcast: true);
                    switch (typeConversion)
                    {
                        case TypeConversion.NoMatch:
                            // log an unsafe cast
                            _logger.LogWarning(
                                FormatMessage(
                                    $"{operand.Type.ToCSharpString(Defaults.TypeCSharpFormat)} as {type.ToCSharpString(Defaults.TypeCSharpFormat)} will always result in null.",
                                    @as.operand));
                            return new CodeDefault(type);

                        case TypeConversion.OperatorConvert:
                            return converted;

                        case TypeConversion.ExpressionTypeAs:
                        default:
                            // NOTE(phase4): ported as-is — even when typeConversion came back as
                            // ExactType (equal types; there is no case label for it above), this
                            // falls into the default arm and still wraps in a cast/as node built
                            // from the original operand, rather than returning operand or
                            // converted directly.
                            return new CodeCast(operand, type, castKind);
                    }
                }
            }
        }

        {
            if (string.IsNullOrWhiteSpace(@as.asType.Name))
                throw this.NewExpressionBuildingException("The 'as' operator has no type name.");

            if (@as.operand is null)
                throw this.NewExpressionBuildingException("Operand cannot be null");

            var type = _typeResolver.ResolveType(@as.asType.Name!)
                       ?? throw this.NewExpressionBuildingException($"Cannot resolve type {@as.asType.Name}");

            var operand = TranslateArg(@as.operand);
            if (!type.IsAssignableTo(operand.Type))
            {
                _logger.LogWarning(FormatMessage(
                                       $"Potentially unsafe cast from {operand.Type.ToCSharpString(Defaults.TypeCSharpFormat)} to type {type.ToCSharpString(Defaults.TypeCSharpFormat)}",
                                       @as.operand));
            }

            return new CodeCast(operand, type, castKind);
        }
    }

    protected CodeExpression Is(Is @is) // @TODO: Cast - Is
    {
        var op = TranslateArg(@is.operand!);
        Type? type = null;
        if (@is.isTypeSpecifier != null)
        {
            if (@is.isTypeSpecifier is ChoiceTypeSpecifier choice)
            {
                var firstChoiceType = TypeFor(choice.choice[0], false) ??
                                      throw this.NewExpressionBuildingException("Could not resolve type for Is expression");

                CodeExpression result = op.NewTypeIsExpression(firstChoiceType);
                for (int i = 1; i < choice.choice.Length; i++)
                {
                    var cti = TypeFor(choice.choice[i], false) ??
                              throw this.NewExpressionBuildingException("Could not resolve type for Is expression");

                    var ie = op.NewTypeIsExpression(cti);
                    // NOTE(phase4): the old code used Expression.Or (a non-short-circuiting
                    // logical OR). The IR only models the short-circuiting form (OrElse); since
                    // both operands are pure CodeTypeIs checks with no side effects, OrElse is
                    // observably identical here.
                    result = new CodeBinary(CodeBinaryOp.OrElse, result, ie);
                }

                var ta = result.NewTypeAsExpression<bool?>();
                return ta;
            }

            type = TypeFor(@is.isTypeSpecifier, false) ??
                   throw this.NewExpressionBuildingException($"Could not resolve type for Is expression");
        }
        else if (!string.IsNullOrWhiteSpace(@is.isType?.Name))
        {
            type = _typeResolver.ResolveType(@is.isType.Name) ??
                   throw this.NewExpressionBuildingException($"Could not resolve type {@is.isType.Name}");
        }

        if (type == null)
            throw this.NewExpressionBuildingException(
                $"Could not identify Is type specifer via {nameof(@is.isTypeSpecifier)} or {nameof(@is.isType)}.");

        var isExpression = op.NewTypeIsExpression(type);
        var nullable = isExpression.NewTypeAsExpression<bool?>();
        return nullable;
    }

    #endregion

    #region Conditionals and literals

    protected CodeExpression Case(Case ce)
    {
        //[{ when1, then1 }, { when2, then2}, { when3, then3 }]
        // when1 ? then 1 : (when2 ? then 2 : (when3 ? then 3 : else }
        if (ce.caseItem?.Length > 0 && ce.@else != null)
        {
            var elseThen = TranslateArg(ce.@else!);
            var cases = new List<(CodeExpression When, CodeExpression Then)>();

            if (ce.comparand != null)
            {
                var comparand = TranslateArg(ce.comparand);

                foreach (var caseItem in ce.caseItem)
                {
                    var caseWhen = TranslateArg(caseItem.when!);
                    var caseWhenEquality = BindCqlOperator(nameof(ICqlOperators.Equal), [comparand, caseWhen]).Coalesce();
                    var caseThen = TranslateArg(caseItem.then!);

                    if (caseThen.Type != elseThen.Type)
                        caseThen = caseThen.NewAssignToTypeExpression(elseThen.Type);

                    cases.Add((caseWhenEquality, caseThen));
                }
            }
            else
            {
                foreach (var caseItem in ce.caseItem)
                {
                    var caseWhen = TranslateArg(caseItem.when!);
                    var caseThen = TranslateArg(caseItem.then!);

                    if (caseThen.Type != elseThen.Type)
                        caseThen = caseThen.NewAssignToTypeExpression(elseThen.Type);

                    if (caseWhen.Type.IsNullableValueType(out _))
                    {
                        caseWhen = caseWhen.Coalesce();
                    }

                    cases.Add((caseWhen, caseThen));
                }
            }

            return new CodeIfChain(cases, elseThen, elseThen.Type);
        }

        throw this.NewExpressionBuildingException("Invalid case expression.  At least 1 case and an else must be present.");
    }

    protected CodeExpression If(If @if)
    {
        var rc = TranslateArg(@if.condition!);
        var condition = rc.Coalesce();
        var then = TranslateArg(@if.then!);
        if (@if.@else != null)
        {
            var @else = TranslateArg(@if.@else!);
            if (then.Type.IsValueType)
            {
                @else = HandleNullable(@else, then.Type);
            }

            if (then.Type != @else.Type)
            {
                // In fact, this is allowed, but since this would be handled using type "object" at runtime
                // (since the CLR does not support discriminated unions), we will throw an exception here.
                // We could also optimize by first trying whether the arguments are convertible to each other,
                // since that would catch quite a few cases (mostly the if .... then X else List<X> cases),
                // which are common.
                throw this.NewExpressionBuildingException(
                    $"The If expression at {@if.locator} produces two branches with different types.");
                // then = Expression.Convert(then, typeof(object));
                // @else = Expression.Convert(@else, typeof(object));
            }

            var ifThenElse = new CodeConditional(condition, then, @else, then.Type);

            return ifThenElse;
        }

        var @false = new CodeConstant(null, typeof(object)).NewAssignToTypeExpression(then.Type);
        var ifThen = new CodeConditional(condition, then, @false, then.Type);
        return ifThen;
    }

    protected CodeExpression List(List list)
    {
        if (list.resultTypeSpecifier == null)
            throw this.NewExpressionBuildingException($"List is missing a result type specifier.");
        if (list.resultTypeSpecifier is ListTypeSpecifier listTypeSpecifier)
        {
            var elementType = TypeFor(listTypeSpecifier.elementType)!;
            var elements = TranslateArgs(list.element);
            if (!elementType.IsNullableValueType(out _) && elements.Any(exp => exp.Type.IsNullableValueType(out _)))
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    elements[i] = HandleNullable(elements[i], elementType);
                }
            }

            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i].Type != elementType)
                {
                    elements[i] = elements[i].NewTypeAsExpression(elementType);
                }
            }

            // NOTE(phase4): ported as-is — TranslateArgs never returns null, so the null-check
            // below (and the NewArrayBounds fallback it guards) is dead code in both the old and
            // new pipelines.
            CodeExpression array;
            if (elements != null)
            {
                array = new CodeNewArray(elementType, elements);
            }
            else
            {
                array = new CodeNewArrayBounds(elementType, new CodeConstant(0, typeof(int)));
            }

            return array;
        }

        throw this.NewExpressionBuildingException($"List is the wrong type");
    }

    protected CodeExpression Literal(Literal lit)
    {
        var type = _typeResolver.ResolveType(lit.valueType.Name) ?? throw this.NewExpressionBuildingException($"Cannot resolve type for {lit.valueType}");


        var (value, convertedType) = ConvertLiteral(lit, type);

        // var result = _operatorBinding.ConvertToType(Expression.Constant(value), convertedType);
        // return result;

        if (type.IsNullableValueType(out _))
        {
            var changed = new CodeConstant(value!, convertedType);
            var asNullable = changed.NewAssignToTypeExpression(type);
            return asNullable;
        }

        return new CodeConstant(value, convertedType);
    }

    protected (object?, Type) ConvertLiteral(Literal lit, Type? type) //@ TODO: Cast - ConvertLiteral
    {
        if (type == null)
            throw new NotImplementedException().WithContext(this);

        if (type.IsNullableValueType(out var underlyingType))
        {
            if (string.IsNullOrWhiteSpace(lit.value))
                return (null, type);

            if (!typeof(IConvertible).IsAssignableFrom(underlyingType))
                throw new NotSupportedException("Only convertible types can be used for literals.");

            try
            {
                var converted = Convert.ChangeType(lit.value, underlyingType, CultureInfo.InvariantCulture); //@ TODO: Cast - ConvertLiteral
                return (converted, underlyingType);
            }
            catch (OverflowException)
            {
                return (null, type);
            }
        }

        if (type == typeof(string))
            return (lit.value, type);

        if (typeof(IConvertible).IsAssignableFrom(type))
        {
            var converted = Convert.ChangeType(lit.value, type, CultureInfo.InvariantCulture); //@ TODO: Cast - ConvertLiteral
            return (converted, type);
        }

        throw new NotSupportedException("Only convertible types can be used for literals.");
    }

    #endregion

    #region ChangeType

    private CodeExpression ChangeType(
        CodeExpression expr,
        TypeSpecifier? typeSpecifier,
        bool throwOnError = false,
        bool considerSafeUpcast = false) // @TODO: Cast - ChangeType
    {
        if (typeSpecifier is not null)
        {
            if (TypeFor(typeSpecifier, throwOnError) is { } resultType)
            {
                if (resultType != expr.Type)
                {
                    var typeAs = ChangeType(expr, resultType, out _, throwOnError, considerSafeUpcast);
                    return typeAs;
                }
            }
        }

        return expr;
    }


    private CodeExpression ChangeType(
        Element element,
        Type outputType,
        bool throwOnError = false,
        bool considerSafeUpcast = false)
        => ChangeType(
            TranslateArg(element),
            outputType,
            throwOnError,
            considerSafeUpcast); // @TODO: Cast - ChangeType

    private CodeExpression ChangeType(
        CodeExpression input,
        Type outputType,
        bool throwOnError = false,
        bool considerSafeUpcast = false) =>
        ChangeType(input, outputType, out _, throwOnError, considerSafeUpcast); // @TODO: Cast - ChangeType


    private CodeExpression ChangeType(
        CodeExpression input,
        Type outputType,
        out TypeConversion typeConversion,
        bool throwOnError = false,
        bool considerSafeUpcast = false) // @TODO: Cast - ChangeType
    {
        // A covariant list conversion (e.g. IEnumerable<Derived> as IEnumerable<Base>) is not
        // an option when compiler-generated tuple types are involved: the C# code generator
        // lowers those element types to value tuples, and IEnumerable<T> covariance does not
        // apply to value types, so the emitted 'as' cast would silently yield null at runtime
        // (see #1354). Convert such lists element-wise below instead.
        bool isTupleListConversion =
            _typeResolver.GetListElementType(input.Type, throwError: false) is { } inputListElemType
            && _typeResolver.GetListElementType(outputType, throwError: false) is { } outputListElemType
            && inputListElemType != outputListElemType
            && (inputListElemType.IsTupleBaseType() || outputListElemType.IsTupleBaseType());

        if (!isTupleListConversion)
        {
            var (expression, tc) = input.TryNewAssignToTypeExpression(outputType, false, considerSafeUpcast);
            if (tc != TypeConversion.NoMatch)
            {
                typeConversion = tc;
                return expression!;
            }
        }

        // tuples are not convertible.
        if (input.Type.IsAssignableTo(typeof(TupleBaseType)) || outputType.IsAssignableTo(typeof(TupleBaseType)))
        {
            // unless they're the same type.
            if (input.Type == outputType)
            {
                typeConversion = TypeConversion.ExactType;
                return input;
            }

            // Handle conversion between compatible TupleBaseType types that differ only in element types
            // (e.g. when an As expression converts {Id:Integer, Name:String} to {Id:Integer, Name:Any}).
            if (input.Type.IsAssignableTo(typeof(TupleBaseType)) && outputType.IsAssignableTo(typeof(TupleBaseType)))
            {
                var inputProps = input.Type.GetProperties();
                var outputProps = outputType.GetProperties();
                if (inputProps.Length == outputProps.Length)
                {
                    var bindings = new List<(MemberInfo Member, CodeExpression Value)>();
                    bool allMatched = true;
                    foreach (var outputProp in outputProps)
                    {
                        var inputProp = Array.Find(inputProps, p => p.Name == outputProp.Name);
                        if (inputProp is null)
                        {
                            allMatched = false;
                            break;
                        }

                        var inputAccess = new CodeProperty(input, inputProp);
                        var convertedValue = inputProp.PropertyType != outputProp.PropertyType
                            ? ChangeType(inputAccess, outputProp.PropertyType, considerSafeUpcast: true)
                            : (CodeExpression)inputAccess;
                        bindings.Add((outputProp, convertedValue));
                    }

                    if (allMatched)
                    {
                        typeConversion = TypeConversion.OperatorConvert;
                        var ctor = outputType.GetConstructor(Type.EmptyTypes)
                                   ?? throw this.NewExpressionBuildingException($"Tuple type {outputType} has no accessible parameterless constructor.");
                        var memberInit = new CodeMemberInit(new CodeNew(ctor), bindings);

                        // A freshly constructed tuple is never null; skip the null guard.
                        if (input is CodeMemberInit or CodeNew)
                            return memberInit;

                        // A null tuple converts to null rather than to a tuple whose elements
                        // are all null; without this check property accesses in the bindings
                        // would throw when evaluated against a null input (see #1354).
                        var isNull = new CodeBinary(CodeBinaryOp.Equal, input, new CodeConstant(null, input.Type));
                        var nullResult = new CodeConstant(null, outputType);
                        return new CodeConditional(isNull, nullResult, memberInit, outputType);
                    }
                }
            }

            typeConversion = TypeConversion.NoMatch;
            throwCannotCastIfNoMatch(typeConversion);
            return input;
        }

        if (_typeResolver.IsListType(input.Type)
            && _typeResolver.IsListType(outputType))
        {
            var inputElementType = _typeResolver.GetListElementType(input.Type, true)!;
            var outputElementType = _typeResolver.GetListElementType(outputType, true)!;
            var lambdaParameter = new CodeLocal(inputElementType, TypeNameToIdentifier(inputElementType, this));
            var lambdaBody = ChangeType(lambdaParameter, outputElementType, out typeConversion, throwOnError: true);
            var lambda = new CodeLambda([lambdaParameter], lambdaBody);
            var select = BindCqlOperator(nameof(ICqlOperators.Select), input, lambda);

            // The element-wise Select is the conversion: callers such as the As handler must
            // use it rather than fall back to a type-as cast on the whole list, which for
            // tuple-typed elements would yield null at runtime after the C# code generator
            // lowers them to value tuples (see #1354).
            if (isTupleListConversion)
                typeConversion = TypeConversion.OperatorConvert;

            return select;
        }

        Type toType = TryCorrectQiCoreBindingError(input.Type, outputType, out var correctedTo)
                          ? correctedTo!
                          : outputType;
        _cqlOperatorsBinder.TryConvert(input, toType, out (CodeExpression arg, TypeConversion conversion) tryConvert);
        typeConversion = tryConvert.conversion;
        throwCannotCastIfNoMatch(tryConvert.conversion);
        return tryConvert.arg;

        void throwCannotCastIfNoMatch(TypeConversion result)
        {
            if (result == TypeConversion.NoMatch && throwOnError)
                throw this.NewExpressionBuildingException($"Cannot convert {input.Type} to {outputType}.");
        }
    }

    #endregion
}

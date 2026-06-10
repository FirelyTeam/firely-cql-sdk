# 09. Nullological Operators Design Pattern

## 9.1 Interface vs Implementation Return Types

9.1.1 Nullological operators (IsNull, IsTrue, IsFalse) have different return types in interface vs implementation.

9.1.2 Interface (ICqlOperators): always declare return type as bool? (nullable).

9.1.2.1 Example: bool? IsNull<T>(T value) where T : class;

9.1.2.2 Reason: consistency with other CQL operators and proper binding logic.

9.1.2.3 Ensures operator binding system works correctly across all operators.

9.1.3 Implementation (CqlOperators): return type is bool (non-nullable).

9.1.3.1 Example: public bool IsNull<T>(T value) where T : class => value == null;

9.1.3.2 Reason: CQL specification section 9.B states these operators always return true or false, never null.

9.1.3.3 C# automatically boxes bool to bool? when returning through interface.

9.1.4 Key point: implementation can return a more specific type (bool) that is implicitly converted to the interface return type (bool?).

9.1.5 Specification reference: CQL 1.5.3 section 9.B (Nullological Operators)

9.1.5.1 is null(argument Any) Boolean - returns Boolean, not Boolean?

9.1.5.2 is true(argument Boolean) Boolean - returns Boolean, not Boolean?

9.1.5.3 is false(argument Boolean) Boolean - returns Boolean, not Boolean?

9.1.6 Do not change interface return types to bool even though spec says these never return null.

9.1.7 Do keep implementation return types as bool to match specification semantics.

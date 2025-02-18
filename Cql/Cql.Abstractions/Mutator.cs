namespace Hl7.Cql.Abstractions;

/// <summary>
/// A delegate which mutates a value of type <typeparamref name="T"/> into another value of the same type.
/// </summary>
/// <typeparam name="T">The type of the value and the mutated value.</typeparam>
/// <param name="value">The value to be mutated.</param>
/// <returns>The mutated value.</returns>
public delegate T Mutator<T>(T value);
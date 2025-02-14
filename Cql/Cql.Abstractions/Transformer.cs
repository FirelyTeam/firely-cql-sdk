namespace Hl7.Cql.Abstractions;

/// <summary>
/// Represents a transformer that can be applied to a value.
/// </summary>
/// <typeparam name="T">The type of the value and the transformed value.</typeparam>
/// <param name="value">The value to be transformed.</param>
/// <returns>The transformed value.</returns>
public delegate T Transformer<T>(T value);
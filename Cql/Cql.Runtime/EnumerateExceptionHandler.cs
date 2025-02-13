namespace Hl7.Cql.Runtime;

/// <summary>
/// Represents a method that handles exceptions that occur during enumeration.
/// </summary>
/// <typeparam name="T">The type of the source object that caused the exception.</typeparam>
/// <param name="value">The item in the enumerations which caused the exception.</param>
/// <param name="exception">The exception that occurred.</param>
/// <returns>An <see cref="EnumerationExceptionHandling"/> value that indicates how the enumeration should proceed.</returns>
public delegate EnumerationExceptionHandling EnumerateExceptionHandler<in T>(T value, Exception exception);

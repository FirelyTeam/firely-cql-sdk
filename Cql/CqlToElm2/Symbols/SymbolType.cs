namespace Hl7.Cql.CqlToElm2.Symbols;

internal enum SymbolType
{
    /// <summary>
    /// Represents a model in scope via the using statement.
    /// </summary>
    Model,
    /// <summary>
    /// Represents a library in scope via the include statement.
    /// </summary>
    Library,
    /// <summary>
    /// Represents a type.
    /// </summary>
    Type,
    /// <summary>
    /// Represents a library parameter defined via the parameter keyword.
    /// </summary>
    Parameter,
    /// <summary>
    /// Represents a code system defined via the codesystem keyword.
    /// </summary>
    CodeSystem,
    /// <summary>
    /// Represents a direct reference code via the code keyword.
    /// </summary>
    Code,
    /// <summary>
    /// Represents a concept defined via the concept keyword. 
    /// </summary>
    Concept,
    /// <summary>
    /// Represents a value set defined via the valueset keyword.
    /// </summary>
    ValueSet,
    /// <summary>
    /// Represents a named expression via the define keyword.
    /// </summary>
    Definition,
    /// <summary>
    /// Represents a named function via the define function keywords.
    /// </summary>
    Function,
    /// <summary>
    /// Represents a named fluent function via the define fluent function keywords.
    /// </summary>
    FluentFunction,
    /// <summary>
    /// Represents an operand to a function.
    /// </summary>
    Operand,
    /// <summary>
    /// Represents a query alias or let alias defined in a query.
    /// </summary>
    Alias,
    /// <summary>
    /// Represents a reference to another symbol.
    /// </summary>
    Reference,
    Expression,
    Argument,
}

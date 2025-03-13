using Hl7.Cql.CqlToElm2.Expressions;
using Hl7.Cql.CqlToElm2.Symbols;
using Hl7.Cql.Model;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CqlToElm2Tests;
internal class PostgresEvaluator: IDisposable
{
    public PostgresEvaluator()
    {
        Connection = Connect();
    }


    public IDictionary<FunctionSymbol, Delegate> Implementations { get; } = new Dictionary<FunctionSymbol, Delegate>();

    /// <summary>
    /// Evaluate a library's defined expressions.
    /// </summary>
    public Dictionary<ExpressionSymbol, object?> Evaluate(LibrarySymbol library) => library.Symbols
        .OfType<ExpressionSymbol>()
        .ToDictionary(s => s, s => Evaluate(s.Expression, library.Symbols));

    /// <summary>
    /// Evaluate a single symbol.
    /// </summary>
    public object? Evaluate(Symbol symbol, SymbolTable scope) => symbol switch
    {
        ExpressionSymbol expression => Evaluate(expression.Expression, scope),
        FunctionSymbol function => InvokeFunction(function, scope),
        _ => throw new NotSupportedException($"Unsupported symbol type {symbol.GetType()}")
    };

    public object? Evaluate(Expression expression, SymbolTable symbols) => expression switch
    {
        FunctionInvocationExpression function => InvokeFunction(function, symbols),
        LiteralExpression literal => literal.Value,
        RetrieveExpression retrieve => Retrieve(retrieve, symbols),
        _ => throw new NotSupportedException($"Unsupported expression type {expression.GetType()}")
    };

    private object? InvokeFunction(FunctionSymbol function, SymbolTable symbols)
    {
        if (Implementations.TryGetValue(function, out var implementation))
        {
            var argumentSymbols = function
                .Operands.Select(op => symbols.GetLocalUnique<ArgumentSymbol>(op.Name));
            if (argumentSymbols.Any(a => a is null))
                throw new InvalidOperationException($"Function {function.Name} is missing arguments or they are not unique.");
            var arguments = argumentSymbols
                .Select(symbol => Evaluate(symbol!.Expression, symbols))
                .ToArray();
            var result = implementation.DynamicInvoke(arguments);
            return result;
        }
        else if (!function.IsExternal)
        {
            var result = Evaluate(function.Body!, symbols);
            return result;
        }
        else throw new InvalidOperationException($"External function doesn't have an implementation set.");
    }

    private object? InvokeFunction(FunctionInvocationExpression function, SymbolTable symbols)
    {
        var functionScope = symbols.Enter(function.Function.Name);
        foreach (var arg in function.Arguments)
            functionScope.AddSymbol(arg);
        return Evaluate(function.Function, functionScope);
    }

    private object? Retrieve(RetrieveExpression retrieve, SymbolTable symbols)
    {
        throw new NotImplementedException();
    }

    internal static NpgsqlConnection Connect()
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        string connectionString = config.GetConnectionString("PostgresDb") ??
            throw new InvalidOperationException("Connection string not found");
        var connection = new NpgsqlConnection(connectionString);
        connection.Open();
        return connection;
    }

    internal NpgsqlConnection Connection { get; }

    #region IDisposable
    private bool IsDisposed;

    protected virtual void Dispose(bool disposing)
    {
        if (!IsDisposed)
        {
            if (disposing)
            {
                if (Connection.State == System.Data.ConnectionState.Open)
                {
                    Connection.Close();
                }
                // TODO: dispose managed state (managed objects)
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            IsDisposed = true;
        }
    }

    // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
    // ~PostgresEvaluator()
    // {
    //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    //     Dispose(disposing: false);
    // }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
    #endregion
}

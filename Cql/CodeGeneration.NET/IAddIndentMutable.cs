namespace Hl7.Cql.CodeGeneration.NET;

internal interface IAddIndentMutable<out TSelf>
{
    TSelf AddIndent(int addIndent = 1);
}
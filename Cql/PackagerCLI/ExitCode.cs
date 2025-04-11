namespace Hl7.Cql.Packager;

internal static class ExitCode
{
    public const int Normal = 0;
    public const int NoCqlLibsInDir = 1;
    public const int NoElmLibsInDir = 2;
    public const int NoElmLibsCompiled = 3;
    public const int CantPackageNoCqlElmMatches = 4;
}
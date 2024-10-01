namespace CqlSdkUseCases;

public record ProgramInputArgs(string Name, string ElmDir, string CSharpDir, string DllDir, Func<FileInfo, bool>? FileFilter = null);
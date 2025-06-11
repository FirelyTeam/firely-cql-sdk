new Program().PickExample(args.ElementAtOrDefault(0));

internal partial class Program
{
    void PickExample(string? code)
    {
        // <codegen-switch>
        switch (code)
        {
            case "210": LoadCqlFromDirSaveElmToDir(); return;
            case "220": LoadElmFromDirSaveCSharpAndDllToDir(); return;
            case "230": PackageCqlElmCSharpAndDllFromDirsSaveFhirResourcesToDir(); return;
            case "240": PackageViaCqlAndElmToolkitsSaveFhirResourcesToDir(); return;
            case "250": PackageViaCqlToolkitsSaveFhirResourcesToDir(); return;
            case "310": InvokingCqlHelloWorld(); return;
            case "320": InvokingCqlHelloWorldWithParameter(); return;
            case "330": InvokingCqlHelloWorldWithFunctionArgument(); return;
            case "400": InvokingFromFhirResources(); return;
            case "500": ExtendingFunctionalityLogLibraryStatements(); return;
        }
        // </codegen-switch>
    }

    private static readonly string InitialCurrentDirectory = Environment.CurrentDirectory;
}
$solutionFile = "Cql-sdk.slnf"
$configuration = "Debug"

dotnet build $solutionFile `
    -c $configuration `
    -p:ElmToCSharpEnabled=true
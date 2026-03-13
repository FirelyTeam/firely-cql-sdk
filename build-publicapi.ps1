$solutionFile = "Cql-sdk.slnf"
$configuration = "Release"
$outputDir = "artifacts"

msbuild $solutionFile `
��� /t:Clean,Build `
��� /p:Configuration=$configuration `
��� /p:TreatWarningsAsErrors=false `
��� /p:GenerateDocumentationFile=true `
��� /p:EmitCompilerGeneratedFiles=true `
    /p:CqlToolingEnabled=false `
    /p:ElmToolingEnabled=false `
��� /p:CompilerGeneratedFilesOutputPath="$outputDir" `
��� /v:m


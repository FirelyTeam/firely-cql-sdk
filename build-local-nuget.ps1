$solutionFile = "Cql-sdk.slnf"
$solutionPath = Resolve-Path $solutionFile
$solutionDir = Split-Path -Parent $solutionPath
$outputDir = Join-Path $solutionDir ".nupkgs"
$configuration = "Release"

Write-Host "Solution Path: $solutionPath"
Write-Host "Configuration: $configuration"
Write-Host "Output Directory: $outputDir"

msbuild $solutionPath `
    /t:Restore,Build,Pack `
    /p:Configuration=$configuration `
    /p:ElmToCSharpEnabled=false `
    /p:PackageOutputPath=$outputDir
$solutionFile = "Cql-sdk.slnf"
$solutionPath = Resolve-Path $solutionFile
$solutionDir = Split-Path -Parent $solutionPath
$outputDir = Join-Path $solutionDir ".nupkgs"
$configuration = "Release"

# Generate an incrementing build number based on current date and time (yyyyMMddHHmm)
$buildNumber = Get-Date -Format "yyyyMMddHHmm"
$versionSuffix = "build.$buildNumber"

Write-Host "Solution Path: $solutionPath"
Write-Host "Configuration: $configuration"
Write-Host "Output Directory: $outputDir"
Write-Host "Version Suffix: $versionSuffix"

msbuild $solutionPath `
    /t:Restore,Build,Pack `
    /p:Configuration=$configuration `
    /p:ElmToCSharpEnabled=false `
    /p:PackageOutputPath=$outputDir `
    /p:VersionSuffix=$versionSuffix
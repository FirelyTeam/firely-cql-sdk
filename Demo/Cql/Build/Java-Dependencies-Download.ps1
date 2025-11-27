# Source required variables
. (Join-Path $PSScriptRoot "Java-Dependencies-Vars.ps1")

# Ensure target/dependency folder exists
if (-not (Test-Path $TargetDependencies)) {
    New-Item -ItemType Directory -Path $TargetDependencies | Out-Null

    # Download CQL to ELM CLI via Maven
    Write-Host "Downloading CQL to ELM CLI via Maven..."
    $mvnOutput = & mvn -f $PomXmlPath dependency:copy-dependencies
    $mvnOutput | Out-File -FilePath $MvnBuildLog -Encoding Unicode
}
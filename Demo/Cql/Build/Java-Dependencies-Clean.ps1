# Source required variables
. (Join-Path $PSScriptRoot "Java-Dependencies-Vars.ps1")

if ([string]::IsNullOrWhiteSpace($TargetDependencies)) {
    Write-Error "TargetDependencies not specified"
    exit 1
}

# Clean JAR dependencies (delete)
if (Test-Path -LiteralPath $TargetDependencies) {
    Write-Host "Deleting JAR Dependencies..."

    if ([string]::IsNullOrWhiteSpace($PomXmlPath)) {
        Write-Error "PomXmlPath not specified. Should refer to a pom.xml file."
        exit 1
    }

    if (-not (Test-Path -LiteralPath $PomXmlPath)) {
        Write-Error "PomXmlPath does not exist. Value='$PomXmlPath'"
        exit 1
    }

    & mvn clean -f $PomXmlPath
    if ($LASTEXITCODE -ne 0) {
        Write-Error "Maven clean failed"
        exit 1
    }
}
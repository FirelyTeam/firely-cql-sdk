param(
    [switch]$Force
)

# Source required variables
. (Join-Path $PSScriptRoot "Java-Dependencies-Vars.ps1")

# Check if target/dependency folder exists and contains JARs, or if -Force is specified
$needDownload = $false
if (-not (Test-Path $TargetDependencies)) {
    $needDownload = $true
} else {
    $jarFiles = Get-ChildItem -Path $TargetDependencies -Filter *.jar -File -ErrorAction SilentlyContinue
    if (@($jarFiles).Count -eq 0) {
        $needDownload = $true
    }
}
if ($Force) {
    $needDownload = $true
}

if ($needDownload) {
    if (-not (Test-Path $TargetDependencies)) {
        New-Item -ItemType Directory -Path $TargetDependencies | Out-Null
    }
    # Download CQL to ELM CLI via Maven
    Write-Host "Downloading CQL to ELM CLI via Maven..."
    $mvnOutput = & mvn -f $PomXmlPath dependency:copy-dependencies 2>&1
    $mvnExitCode = $LASTEXITCODE
    $mvnOutput | Out-File -FilePath $MvnBuildLog -Encoding Unicode
    
    # Check if dependencies were actually downloaded successfully by verifying JARs exist
    $jarFiles = Get-ChildItem -Path $TargetDependencies -Filter *.jar -File -ErrorAction SilentlyContinue
    if (@($jarFiles).Count -eq 0) {
        Write-Error "Maven dependency download failed - no JAR files found in $TargetDependencies"
        Write-Error "Maven exit code: $mvnExitCode"
        exit 1
    }
    Write-Host "Successfully downloaded $(@($jarFiles).Count) dependency JAR file(s)"
} else {
    Write-Host "Dependencies already present in $TargetDependencies. Use -Force to re-download."
}
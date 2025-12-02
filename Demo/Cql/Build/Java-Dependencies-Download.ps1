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
    $mvnOutput = & mvn -f $PomXmlPath dependency:copy-dependencies
    if ($LASTEXITCODE -ne 0) {
        Write-Error "Maven dependency download failed"
        exit 1
    }
    $mvnOutput | Out-File -FilePath $MvnBuildLog -Encoding Unicode
} else {
    Write-Host "Dependencies already present in $TargetDependencies. Use -Force to re-download."
}
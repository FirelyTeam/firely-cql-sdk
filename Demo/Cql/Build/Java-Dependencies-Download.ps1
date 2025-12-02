param(
    [switch]$Force
)

# Source required variables
. (Join-Path $PSScriptRoot "Java-Dependencies-Vars.ps1")

# Helper function to count JAR files in target directory
function Get-JarFileCount {
    $jarFiles = Get-ChildItem -Path $TargetDependencies -Filter *.jar -File -ErrorAction SilentlyContinue
    return @($jarFiles).Count
}

# Use a mutex to prevent parallel execution across multiple MSBuild processes
$mutexName = "Global\CqlJavaDependenciesDownload"
$mutex = New-Object System.Threading.Mutex($false, $mutexName)

try {
    # Wait up to 5 minutes for the mutex
    $acquired = $mutex.WaitOne([TimeSpan]::FromMinutes(5))
    if (-not $acquired) {
        Write-Error "Timeout waiting for Java dependencies download lock"
        exit 1
    }

    try {
        # Check if target/dependency folder exists and contains JARs, or if -Force is specified
        $needDownload = $false
        if (-not (Test-Path $TargetDependencies)) {
            $needDownload = $true
        } else {
            if ((Get-JarFileCount) -eq 0) {
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
            
            # Check if dependencies were actually downloaded successfully by verifying JARs exist
            $jarCount = Get-JarFileCount
            if ($jarCount -eq 0) {
                Write-Error "Maven dependency download failed - no JAR files found in $TargetDependencies"
                Write-Error "Maven exit code: $mvnExitCode"
                # Still write log on failure for debugging
                $mvnOutput | Out-File -FilePath $MvnBuildLog -Encoding Unicode
                exit 1
            }
            # Write log only after successful validation
            $mvnOutput | Out-File -FilePath $MvnBuildLog -Encoding Unicode
            Write-Host "Successfully downloaded $jarCount dependency JAR file(s)"
        } else {
            Write-Host "Dependencies already present in $TargetDependencies. Use -Force to re-download."
        }
    }
    finally {
        # Always release the mutex
        $mutex.ReleaseMutex()
    }
}
finally {
    $mutex.Dispose()
}
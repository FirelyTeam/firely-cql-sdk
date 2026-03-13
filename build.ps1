#!/usr/bin/env pwsh
#
# Build script for Firely CQL SDK
# Provides interactive options for runtime selection and CQL tooling features
#

param(
    [Parameter(HelpMessage="Target framework: net8.0 or net10.0")]
    [ValidateSet("net8.0", "net10.0")]
    [string]$Framework,
    
    [Parameter(HelpMessage="Enable CQL tooling which converts CQL to ELM")]
    [switch]$EnableCqlTooling,
    
    [Parameter(HelpMessage="Enable ELM tooling which converts ELM -> C# -> DLL -> FHIR Resources")]
    [switch]$EnableElmTooling,
    
    [Parameter(HelpMessage="Build configuration: Debug or Release")]
    [ValidateSet("Debug", "Release")]
    [string]$Configuration = "Debug"
)

Write-Host "===========================================================================" -ForegroundColor Blue
Write-Host "Firely CQL SDK Build Script" -ForegroundColor Blue
Write-Host "===========================================================================" -ForegroundColor Blue
Write-Host ""

# Interactive prompts if parameters not provided
if (-not $Framework -or -not $PSBoundParameters.ContainsKey('Configuration')) {
    Write-Host "Select target framework and configuration:" -ForegroundColor Yellow
    Write-Host "  1. .NET 8 / Debug"
    Write-Host "  2. .NET 8 / Release"
    Write-Host "  3. .NET 10 / Debug"
    Write-Host "  4. .NET 10 / Release"
    Write-Host ""
    Write-Host "  Press Ctrl+C to exit" -ForegroundColor DarkGray
    Write-Host ""
    $choice = Read-Host "Enter choice (1-4)"

    switch ($choice) {
        "1" {
            $Framework = "net8.0"
            $Configuration = "Debug"
        }
        "2" {
            $Framework = "net8.0"
            $Configuration = "Release"
        }
        "3" {
            $Framework = "net10.0"
            $Configuration = "Debug"
        }
        "4" {
            $Framework = "net10.0"
            $Configuration = "Release"
        }
        default {
            Write-Host "Invalid choice. Defaulting to .NET 8 / Debug" -ForegroundColor Red
            $Framework = "net8.0"
            $Configuration = "Debug"
        }
    }
}

if (-not $EnableCqlTooling.IsPresent -and -not $EnableElmTooling.IsPresent) {
    Write-Host ""
    Write-Host "Select code generation options:" -ForegroundColor Yellow
    Write-Host "  1. None (both disabled)"
    Write-Host "  2. CqlToElm only (converts CQL files to ELM JSON)"
    Write-Host "  3. ElmToCSharp only (generates C# code from ELM)"
    Write-Host "  4. Both enabled (CqlToElm + ElmToCSharp)"
    Write-Host ""
    Write-Host "  Press Ctrl+C to exit" -ForegroundColor DarkGray
    Write-Host ""
    $codeGenChoice = Read-Host "Enter choice (1-4, default: 1)"

    switch ($codeGenChoice) {
        "1" {
            $EnableCqlTooling = $false
            $EnableElmTooling = $false
        }
        "2" {
            $EnableCqlTooling = $true
            $EnableElmTooling = $false
        }
        "3" {
            $EnableCqlTooling = $false
            $EnableElmTooling = $true
        }
        "4" {
            $EnableCqlTooling = $true
            $EnableElmTooling = $true
        }
        default {
            $EnableCqlTooling = $false
            $EnableElmTooling = $false
        }
    }
}

Write-Host ""
Write-Host "===========================================================================" -ForegroundColor Green
Write-Host "Build Configuration:" -ForegroundColor Green
Write-Host "===========================================================================" -ForegroundColor Green
Write-Host "  Framework:        $Framework"
Write-Host "  Configuration:    $Configuration"
Write-Host "  CqlTooling:         $(if ($EnableCqlTooling) { 'Enabled' } else { 'Disabled' })"
Write-Host "  ElmTooling:      $(if ($EnableElmTooling) { 'Enabled' } else { 'Disabled' })"
Write-Host ""

# Build MSBuild properties
$baseProperties = @(
    "/p:Configuration=$Configuration"
    "/p:TargetFramework=$Framework"
)

$codeGenProperties = @()
if ($EnableCqlTooling) {
    $codeGenProperties += "/p:CqlToolingEnabled=true"
}
if ($EnableElmTooling) {
    $codeGenProperties += "/p:ElmToolingEnabled=true"
}

# Execute build
$slnf = "Cql-Sdk.slnf"
$sln  = "Cql-Sdk-All.sln"

if ($EnableElmTooling) {
    # Phase 1: build the core SDK solution (Cql-Sdk.slnf) without ElmToCSharp.
    # This ensures PackagerCLI and all its dependencies are fully compiled and
    # at rest before any Demo/Measures project launches the packager.
    Write-Host "Phase 1: Building core SDK solution (Cql-Sdk.slnf)..." -ForegroundColor Blue
    Write-Host ""
    $phase1Properties = $baseProperties + ($codeGenProperties | Where-Object { $_ -notmatch "ElmToolingEnabled" })
    $phase1Command = "dotnet build `"$slnf`" $($phase1Properties -join ' ')"
    Write-Host "Command: $phase1Command" -ForegroundColor DarkGray
    Write-Host ""

    & dotnet build $slnf $phase1Properties

    if ($LASTEXITCODE -ne 0) {
        Write-Host ""
        Write-Host "===========================================================================" -ForegroundColor Red
        Write-Host "Phase 1 failed with exit code $LASTEXITCODE" -ForegroundColor Red
        Write-Host "===========================================================================" -ForegroundColor Red
        exit $LASTEXITCODE
    }

    Write-Host ""
    Write-Host "Phase 1 completed successfully." -ForegroundColor Green
    Write-Host ""

    # Phase 2: build the full solution (Cql-Sdk-All.sln) with ElmToCSharp enabled,
    # serialised with -maxcpucount:1. PackagerCLI is already up-to-date so MSBuild
    # skips it — no DLL copies race with the running packager.
    # Only one GenerateCSharp fires at a time.
    $phase2Properties = $baseProperties + $codeGenProperties
    Write-Host "Phase 2: Building full solution with ElmToCSharp (serialised)..." -ForegroundColor Blue
    Write-Host ""
    $phase2Command = "dotnet build `"$sln`" $($phase2Properties -join ' ') -maxcpucount:1"
    Write-Host "Command: $phase2Command" -ForegroundColor DarkGray
    Write-Host ""

    & dotnet build $sln $phase2Properties -maxcpucount:1
} else {
    $allProperties = $baseProperties + $codeGenProperties
    Write-Host "Building solution..." -ForegroundColor Blue
    Write-Host ""
    $buildCommand = "dotnet build `"$sln`" $($allProperties -join ' ')"
    Write-Host "Command: $buildCommand" -ForegroundColor DarkGray
    Write-Host ""

    & dotnet build $sln $allProperties
}

if ($LASTEXITCODE -eq 0) {
    Write-Host ""
    Write-Host "===========================================================================" -ForegroundColor Green
    Write-Host "Build completed successfully!" -ForegroundColor Green
    Write-Host "===========================================================================" -ForegroundColor Green
} else {
    Write-Host ""
    Write-Host "===========================================================================" -ForegroundColor Red
    Write-Host "Build failed with exit code $LASTEXITCODE" -ForegroundColor Red
    Write-Host "===========================================================================" -ForegroundColor Red
    exit $LASTEXITCODE
}

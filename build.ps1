#!/usr/bin/env pwsh
#
# Build script for Firely CQL SDK
# Provides interactive options for runtime selection and CQL tooling features
#

param(
    [Parameter(HelpMessage="Target framework: net8.0 or net10.0")]
    [ValidateSet("net8.0", "net10.0")]
    [string]$Framework,
    
    [Parameter(HelpMessage="Enable CqlToElm conversion")]
    [switch]$EnableCqlToElm,
    
    [Parameter(HelpMessage="Enable ElmToCSharp conversion")]
    [switch]$EnableElmToCSharp,
    
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

if (-not $EnableCqlToElm.IsPresent -and -not $EnableElmToCSharp.IsPresent) {
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
            $EnableCqlToElm = $false
            $EnableElmToCSharp = $false
        }
        "2" {
            $EnableCqlToElm = $true
            $EnableElmToCSharp = $false
        }
        "3" {
            $EnableCqlToElm = $false
            $EnableElmToCSharp = $true
        }
        "4" {
            $EnableCqlToElm = $true
            $EnableElmToCSharp = $true
        }
        default {
            $EnableCqlToElm = $false
            $EnableElmToCSharp = $false
        }
    }
}

Write-Host ""
Write-Host "===========================================================================" -ForegroundColor Green
Write-Host "Build Configuration:" -ForegroundColor Green
Write-Host "===========================================================================" -ForegroundColor Green
Write-Host "  Framework:        $Framework"
Write-Host "  Configuration:    $Configuration"
Write-Host "  CqlToElm:         $(if ($EnableCqlToElm) { 'Enabled' } else { 'Disabled' })"
Write-Host "  ElmToCSharp:      $(if ($EnableElmToCSharp) { 'Enabled' } else { 'Disabled' })"
Write-Host ""

# Build MSBuild properties
$properties = @(
    "/p:Configuration=$Configuration"
    "/p:TargetFramework=$Framework"
)

if ($EnableCqlToElm) {
    $properties += "/p:CqlToElmEnabled=true"
}

if ($EnableElmToCSharp) {
    $properties += "/p:ElmToCSharpEnabled=true"
}

# Execute build
Write-Host "Building solution..." -ForegroundColor Blue
Write-Host ""

$solutionFile = "Cql-Sdk-All.sln"
$buildCommand = "dotnet build `"$solutionFile`" $($properties -join ' ')"

Write-Host "Command: $buildCommand" -ForegroundColor DarkGray
Write-Host ""

& dotnet build $solutionFile $properties

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

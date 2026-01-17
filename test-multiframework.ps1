#!/usr/bin/env pwsh
# Script: test-multiframework.ps1
# Description: Run tests against both .NET 8 and .NET 10 to verify identical behavior
# Usage: ./test-multiframework.ps1 [-Configuration Debug|Release] [-Verbose]

[CmdletBinding()]
param(
    [Parameter(Mandatory=$false)]
    [ValidateSet('Debug', 'Release')]
    [string]$Configuration = 'Debug',
    
    [Parameter(Mandatory=$false)]
    [switch]$Verbose
)

$ErrorActionPreference = 'Stop'

Write-Host "==================================================================" -ForegroundColor Cyan
Write-Host "Multi-Framework Test Runner for Firely CQL SDK" -ForegroundColor Cyan
Write-Host "Testing .NET 8 and .NET 10 to verify identical behavior" -ForegroundColor Cyan
Write-Host "==================================================================" -ForegroundColor Cyan
Write-Host ""

# Check for multi-targeting in cql-base.props
$propsFile = Join-Path $PSScriptRoot "cql-base.props"
$propsContent = Get-Content $propsFile -Raw

if ($propsContent -match '<TargetFrameworks>([^<]+)</TargetFrameworks>') {
    $targetFrameworks = $Matches[1]
    Write-Host "Target Frameworks: $targetFrameworks" -ForegroundColor Green
    
    if ($targetFrameworks -notmatch 'net8\.0' -or $targetFrameworks -notmatch 'net10\.0') {
        Write-Warning "Multi-targeting not fully enabled in cql-base.props"
        Write-Warning "Expected: <TargetFrameworks>net8.0;net10.0</TargetFrameworks>"
        Write-Warning "Found: <TargetFrameworks>$targetFrameworks</TargetFrameworks>"
        Write-Host ""
    }
} else {
    Write-Warning "Could not detect TargetFrameworks in cql-base.props"
    Write-Host ""
}

# Check .NET SDKs
Write-Host "Checking installed .NET SDKs..." -ForegroundColor Yellow
$sdks = dotnet --list-sdks
$hasNet8 = $sdks | Where-Object { $_ -match '^8\.' }
$hasNet10 = $sdks | Where-Object { $_ -match '^10\.' }

if (-not $hasNet8) {
    Write-Error ".NET 8 SDK not found. Please install: https://dotnet.microsoft.com/download/dotnet/8.0"
    exit 1
}
if (-not $hasNet10) {
    Write-Error ".NET 10 SDK not found. Please install: https://dotnet.microsoft.com/download/dotnet/10.0"
    exit 1
}

Write-Host "✓ .NET 8 SDK: $($hasNet8[0])" -ForegroundColor Green
Write-Host "✓ .NET 10 SDK: $($hasNet10[0])" -ForegroundColor Green
Write-Host ""

# Test projects
$testProjects = @(
    "Cql/CoreTests/CoreTests.csproj",
    "Cql/CqlToElmTests/CqlToElmTests.csproj"
)

# Build and test each project for both frameworks
$results = @{
    'net8.0' = @{ Passed = 0; Failed = 0; Projects = @() }
    'net10.0' = @{ Passed = 0; Failed = 0; Projects = @() }
}

foreach ($project in $testProjects) {
    $projectPath = Join-Path $PSScriptRoot $project
    if (-not (Test-Path $projectPath)) {
        Write-Warning "Project not found: $project"
        continue
    }
    
    $projectName = Split-Path $project -Leaf
    Write-Host "================================================================" -ForegroundColor Cyan
    Write-Host "Testing: $projectName" -ForegroundColor Cyan
    Write-Host "================================================================" -ForegroundColor Cyan
    Write-Host ""
    
    # Build project
    Write-Host "Building $projectName..." -ForegroundColor Yellow
    dotnet build $projectPath --configuration $Configuration --nologo
    if ($LASTEXITCODE -ne 0) {
        Write-Error "Build failed for $projectName"
        continue
    }
    Write-Host "✓ Build succeeded" -ForegroundColor Green
    Write-Host ""
    
    # Test on .NET 8
    Write-Host "Running tests on .NET 8..." -ForegroundColor Yellow
    $net8Output = dotnet test $projectPath --configuration $Configuration --no-build --framework net8.0 --nologo --verbosity minimal 2>&1
    $net8Success = $LASTEXITCODE -eq 0
    
    if ($net8Success) {
        Write-Host "✓ .NET 8 tests PASSED" -ForegroundColor Green
        $results['net8.0'].Passed++
        $results['net8.0'].Projects += [PSCustomObject]@{ Name = $projectName; Status = 'Passed' }
    } else {
        Write-Host "✗ .NET 8 tests FAILED" -ForegroundColor Red
        $results['net8.0'].Failed++
        $results['net8.0'].Projects += [PSCustomObject]@{ Name = $projectName; Status = 'Failed' }
        if ($Verbose) {
            Write-Host $net8Output
        }
    }
    Write-Host ""
    
    # Test on .NET 10
    Write-Host "Running tests on .NET 10..." -ForegroundColor Yellow
    $net10Output = dotnet test $projectPath --configuration $Configuration --no-build --framework net10.0 --nologo --verbosity minimal 2>&1
    $net10Success = $LASTEXITCODE -eq 0
    
    if ($net10Success) {
        Write-Host "✓ .NET 10 tests PASSED" -ForegroundColor Green
        $results['net10.0'].Passed++
        $results['net10.0'].Projects += [PSCustomObject]@{ Name = $projectName; Status = 'Passed' }
    } else {
        Write-Host "✗ .NET 10 tests FAILED" -ForegroundColor Red
        $results['net10.0'].Failed++
        $results['net10.0'].Projects += [PSCustomObject]@{ Name = $projectName; Status = 'Failed' }
        if ($Verbose) {
            Write-Host $net10Output
        }
    }
    Write-Host ""
    
    # Compare results
    if ($net8Success -and $net10Success) {
        Write-Host "✓ Identical behavior: Tests pass on both frameworks" -ForegroundColor Green
    } elseif ($net8Success -ne $net10Success) {
        Write-Warning "⚠ Framework-specific failure detected!"
        Write-Warning "Tests pass on one framework but fail on the other."
    } else {
        Write-Host "✗ Tests fail on both frameworks" -ForegroundColor Red
    }
    Write-Host ""
}

# Summary
Write-Host "==================================================================" -ForegroundColor Cyan
Write-Host "SUMMARY" -ForegroundColor Cyan
Write-Host "==================================================================" -ForegroundColor Cyan
Write-Host ""

Write-Host ".NET 8 Results:" -ForegroundColor Yellow
Write-Host "  Passed: $($results['net8.0'].Passed)" -ForegroundColor Green
Write-Host "  Failed: $($results['net8.0'].Failed)" -ForegroundColor $(if ($results['net8.0'].Failed -gt 0) { 'Red' } else { 'Green' })
Write-Host ""

Write-Host ".NET 10 Results:" -ForegroundColor Yellow
Write-Host "  Passed: $($results['net10.0'].Passed)" -ForegroundColor Green
Write-Host "  Failed: $($results['net10.0'].Failed)" -ForegroundColor $(if ($results['net10.0'].Failed -gt 0) { 'Red' } else { 'Green' })
Write-Host ""

# Overall assessment
$allPassed = ($results['net8.0'].Failed -eq 0) -and ($results['net10.0'].Failed -eq 0)
$identicalBehavior = ($results['net8.0'].Passed -eq $results['net10.0'].Passed) -and 
                     ($results['net8.0'].Failed -eq $results['net10.0'].Failed)

if ($allPassed) {
    Write-Host "✓ SUCCESS: All tests pass on both .NET 8 and .NET 10" -ForegroundColor Green
    if ($identicalBehavior) {
        Write-Host "✓ VERIFIED: Identical behavior across frameworks" -ForegroundColor Green
    }
    exit 0
} elseif ($identicalBehavior) {
    Write-Host "✗ FAILURE: Tests fail identically on both frameworks" -ForegroundColor Red
    exit 1
} else {
    Write-Host "⚠ WARNING: Framework-specific test failures detected!" -ForegroundColor Yellow
    Write-Host "This may indicate behavioral differences between .NET 8 and .NET 10" -ForegroundColor Yellow
    exit 1
}

# -----------------------------
# CONFIGURATION
# -----------------------------
$scriptPath   = Split-Path -Parent $MyInvocation.MyCommand.Path
$scriptName   = Split-Path -Leaf $MyInvocation.MyCommand.Path
$finalRoot    = Join-Path $scriptPath "dqm-content-qicore-2025"
$finalCql     = Join-Path $finalRoot "Cql"
$repoUrl      = "https://github.com/cqframework/dqm-content-qicore-2025.git"
$tempPath     = Join-Path $scriptPath "dqm-content-qicore-2025-temp"
$repoCommitId = "c89ea1a7a6ac80e42609b55eafc05a86448bdea4"  # Set to specific commit hash, or leave as $null for latest

# -----------------------------
# TOOL INFORMATION
# -----------------------------
Write-Host "========================================" -ForegroundColor Cyan
Write-Host "DQM Content QICore 2025 Sync Tool" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""
Write-Host "Configuration Variables:" -ForegroundColor Yellow
Write-Host "  Repository URL: $repoUrl"
Write-Host "  Commit ID:      $(if ($repoCommitId) { $repoCommitId } else { 'latest' })"
Write-Host "  Final Root:     $finalRoot"
Write-Host "  Final CQL:      $finalCql"
Write-Host "  Temp Path:      $tempPath"
Write-Host ""

# -----------------------------
# CLEANUP PREVIOUS RUN
# -----------------------------
if (Test-Path $tempPath) {
    Write-Host "Removing old temp folder..."
    Remove-Item -Recurse -Force $tempPath
}
if (Test-Path $finalRoot) {
    Write-Host "Removing old folder... $finalRoot"
    Remove-Item -Recurse -Force $finalRoot
}

# -----------------------------
# CLONE REPO WITH SPARSE-CHECKOUT
# -----------------------------
Write-Host "Cloning into temp folder: $tempPath"
git clone --no-checkout $repoUrl $tempPath
Set-Location $tempPath

git sparse-checkout init --cone
git sparse-checkout set input/cql

if ($repoCommitId) {
    Write-Host "Checking out commit: $repoCommitId"
    git checkout $repoCommitId
} else {
    Write-Host "Checking out latest from master branch"
    git checkout master
}

# Get and display the actual commit ID
$actualCommitId = git rev-parse HEAD
Write-Host "Using commit: $actualCommitId" -ForegroundColor Green

# -----------------------------
# COPY .CQL FILES TO FINAL DESTINATION
# -----------------------------
Write-Host "`nCopying .cql files to $finalCql ..."
New-Item -ItemType Directory -Force -Path $finalCql | Out-Null

Get-ChildItem -Recurse -Filter *.cql | ForEach-Object {
    Copy-Item $_.FullName -Destination $finalCql -Force
}

# -----------------------------
# CLEANUP TEMP FOLDER
# -----------------------------
Set-Location $scriptPath
Write-Host "Cleaning up temp folder..."
Remove-Item -Recurse -Force $tempPath

# -----------------------------
# UPDATE QICoreCommon.cql
# -----------------------------
$qicoreFile = Join-Path $finalCql "QICoreCommon.cql"
$qicoreBackup = Join-Path $finalCql "QICoreCommon.cql.original"

if (Test-Path $qicoreFile) {
    Write-Host "Backing up QICoreCommon.cql to QICoreCommon.cql.original"
    Copy-Item -Path $qicoreFile -Destination $qicoreBackup -Force

    $fileContents = Get-Content -Raw -Path $qicoreFile
    $newFileContents = $fileContents -replace 'Interval\[condition\.abatement\.low, condition\.abatement\.high\)', "Interval[condition.abatement.low as DateTime, condition.abatement.high as DateTime) // Modified by $scriptName`: Added explicit DateTime casts"
    Set-Content -Path $qicoreFile -Value $newFileContents -Force
    Write-Host "Updated QICoreCommon.cql successfully."
} else {
    Write-Host "QICoreCommon.cql not found in $finalCql"
}

# -----------------------------
# RUN JAVA CQL COMPILER
# -----------------------------

# Paths
$javaExe      = "java"
$classpath    = "../Demo/Cql/Build/target/dependency/*"
$inputFolder  = Join-Path $finalRoot "cql"  # using the folder we just populated
$outputFolder = "$finalRoot/Elm"

# Ensure output folder exists
New-Item -ItemType Directory -Force -Path $outputFolder | Out-Null

# Build argument array
$args = @(
    "-classpath", $classpath,
    "org.cqframework.cql.cql2elm.cli.Main",
    "-input", $inputFolder,
    "-f", "JSON",
    "-output", $outputFolder,
    "-locators", "true",
    "-result-types", "true",
    "-signatures", "All"
)

# Run the command
Write-Host "`nRunning Java CQL compiler..."
& $javaExe @args
Write-Host "Java CQL compilation complete."
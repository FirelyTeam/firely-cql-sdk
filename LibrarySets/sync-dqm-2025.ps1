# -----------------------------
# CONFIGURATION
# -----------------------------
$scriptPath  = Split-Path -Parent $MyInvocation.MyCommand.Path
$finalRoot   = Join-Path $scriptPath "dqm-content-qicore-2025"
$finalCql    = Join-Path $finalRoot "Cql"
$repoUrl     = "https://github.com/cqframework/dqm-content-qicore-2025.git"
$tempPath    = Join-Path $scriptPath "dqm-content-qicore-2025-temp"

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
git checkout master

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

if (Test-Path $qicoreFile) {
    $fileContents = Get-Content -Raw -Path $qicoreFile
    $newFileContents = $fileContents -replace 'Interval\[condition\.abatement\.low, condition\.abatement\.high\)', 'Interval[condition.abatement.low as DateTime, condition.abatement.high as DateTime)'
    Set-Content -Path $qicoreFile -Value $newFileContents -Force
    Write-Host "Updated QICoreCommon.cql successfully."
} else {
    Write-Host "QICoreCommon.cql not found in $finalCql"
}

# -----------------------------
# UPDATE QICoreCommon.cql
# -----------------------------
$fhirHelpersFile = Join-Path $finalCql "FHIRHelpers.cql"

if (Test-Path $fhirHelpersFile) {
    $fileContents = Get-Content -Raw -Path $fhirHelpersFile
    $newFileContents = $fileContents + "`ndefine function ToString(value FHIR.id): value.value"
    Set-Content -Path $fhirHelpersFile -Value $newFileContents -Force
    Write-Host "Updated FHIRHelpers.cql successfully."
} else {
    Write-Host "FHIRHelpers.cql not found in $finalCql"
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
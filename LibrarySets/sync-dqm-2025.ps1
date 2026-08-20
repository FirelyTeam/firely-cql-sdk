<#
.SYNOPSIS
Syncs the dqm-content-qicore-2025 library set (CQL + ELM) and repairs the
integration runner's value set corpus from the VSAC FHIR terminology service.

.DESCRIPTION
Without switches this script:
  1. clones cqframework/dqm-content-qicore-2025, copies its CQL files into
     LibrarySets/dqm-content-qicore-2025 and applies the documented patches
  2. compiles the CQL to ELM with the Java reference compiler
  3. repairs the integration runner's value set corpus (see -ValueSetsOnly)

.PARAMETER ValueSetsOnly
Skip the CQL/ELM sync and only run the value set sync.

.PARAMETER SkipValueSets
Only run the CQL/ELM sync (this script's pre-existing behavior).

.PARAMETER VsacApiKey
UMLS API key used to authenticate against https://cts.nlm.nih.gov/fhir/.
Defaults to the UMLS_API_KEY environment variable. Create a key by signing in
at https://uts.nlm.nih.gov and choosing "Generate new API Key" under
My Profile > Edit Profile; a (free) UMLS Metathesaurus license is required.
The key is personal - never commit it.

.PARAMETER ValueSetOids
Explicit value set OIDs to fetch. When omitted, the script scans the corpus
and fetches every value set that is either truncated (upstream vendored a
partial VSAC page: expansion.total exceeds the concepts on disk) or referenced
by a measure's ValueSetsSelfAndDescendants.txt but absent from the corpus.
#>
param(
    [switch]$ValueSetsOnly,
    [switch]$SkipValueSets,
    [string]$VsacApiKey = $env:UMLS_API_KEY,
    [string[]]$ValueSetOids
)

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

$repoRoot        = Split-Path -Parent $scriptPath
$testDataFolder  = Join-Path $repoRoot (Join-Path "submodules" (Join-Path "Firely.Cql.Sdk.Integration.Runner" (Join-Path "IntegrationRunner" "Test Data")))
$valueSetsFolder = Join-Path $testDataFolder "Value Sets"
$measuresFolder  = Join-Path $testDataFolder "Measures"
$vsacFhirBase    = "https://cts.nlm.nih.gov/fhir"
$vsacReleaseManifest = "ecqm-update-2025-05-08"

# -----------------------------
# VALUE SET SYNC (VSAC FHIR TERMINOLOGY SERVICE)
# -----------------------------
# The integration runner's corpus (Test Data/Value Sets in the submodule)
# vendors VSAC value set expansions. VSAC pages $expand responses at 1000
# concepts, and the upstream dqm-content repo vendored first pages only for
# some large value sets. A partial expansion cannot answer membership, so the
# SDK rejects it since #1510 - which disabled 22 measure classes (#1562).
# This section fetches complete expansions, following offset/count paging
# until expansion.total concepts are present, and merges them into one file
# per value set. Docs: https://www.nlm.nih.gov/vsac/support/usingvsac/vsacfhirapi.html

function Get-ConceptCount($contains) {
    $count = 0
    foreach ($c in @($contains)) {
        if ($null -eq $c) { continue }
        $count++
        if ($c.PSObject.Properties['contains']) { $count += Get-ConceptCount $c.contains }
    }
    return $count
}

# Scans the corpus and returns the value sets needing a fetch: files whose
# expansion is partial, and OIDs referenced by measures but absent on disk.
function Get-CorpusRepairList {
    $present = @{}
    foreach ($file in Get-ChildItem -Path $valueSetsFolder -Filter 'ValueSet-*.json' -File) {
        $present[$file.BaseName.Substring('ValueSet-'.Length)] = $file
    }

    $truncated = @()
    foreach ($entry in $present.GetEnumerator() | Sort-Object Key) {
        $vs  = Get-Content -Raw -Path $entry.Value.FullName | ConvertFrom-Json
        $exp = $vs.expansion
        if ($null -eq $exp) { continue }
        $valueSetVersion = $null
        if ($vs.PSObject.Properties['version'] -and $vs.version) {
            $valueSetVersion = [string]$vs.version
        }
        $concepts = Get-ConceptCount $exp.contains
        $offset   = 0
        if ($exp.PSObject.Properties['offset'] -and $null -ne $exp.offset) { $offset = [int]$exp.offset }
        $total = $null
        if ($exp.PSObject.Properties['total'] -and $null -ne $exp.total) { $total = [int]$exp.total }
        if ($offset -gt 0 -or ($null -ne $total -and $total -gt $concepts)) {
            $truncated += [pscustomobject]@{ Oid = $entry.Key; Present = $concepts; Total = $total; ValueSetVersion = $valueSetVersion }
        }
    }

    $referencedBy = @{}
    foreach ($measureDir in Get-ChildItem -Path $measuresFolder -Directory) {
        $txt = Join-Path $measureDir.FullName 'ValueSetsSelfAndDescendants.txt'
        if (-not (Test-Path $txt)) { continue }
        foreach ($line in Get-Content -Path $txt) {
            $oid = $line.Trim()
            if (-not $oid) { continue }
            if (-not $referencedBy.ContainsKey($oid)) { $referencedBy[$oid] = @() }
            $referencedBy[$oid] += $measureDir.Name
        }
    }
    $missing = @()
    foreach ($oid in $referencedBy.Keys | Sort-Object) {
        if (-not $present.ContainsKey($oid)) {
            $missing += [pscustomobject]@{ Oid = $oid; ReferencedBy = $referencedBy[$oid] }
        }
    }

    return [pscustomobject]@{ PresentCount = $present.Count; Truncated = $truncated; Missing = $missing }
}

# Fetches one value set's complete expansion, following VSAC's offset/count
# paging, and merges the pages into a single ValueSet resource.
function Get-VsacValueSet([string]$Oid, [string]$ValueSetVersion) {
    $headers = @{
        Authorization = 'Basic ' + [Convert]::ToBase64String([System.Text.Encoding]::ASCII.GetBytes("apikey:$VsacApiKey"))
        Accept        = 'application/fhir+json'
    }
    $pageSize    = 1000
    $offset      = 0
    $result      = $null
    $serverTotal = $null
    $allContains = [System.Collections.Generic.List[object]]::new()

    while ($true) {
        $query = "offset=$offset&count=$pageSize&release=$vsacReleaseManifest"
        if ($ValueSetVersion) {
            $query += "&valueSetVersion=$ValueSetVersion"
        }
        $uri  = "$vsacFhirBase/ValueSet/$Oid/" + '$expand' + "?$query"
        $page = $null
        for ($attempt = 1; ; $attempt++) {
            try {
                $page = Invoke-RestMethod -Uri $uri -Headers $headers -TimeoutSec 180
                break
            } catch {
                if ($attempt -ge 3) { throw }
                Write-Warning "    attempt $attempt failed ($($_.Exception.Message)); retrying..."
                Start-Sleep -Seconds (3 * $attempt)
            }
        }

        if ($null -eq $result) { $result = $page }
        $pageContains = @()
        if ($page.expansion -and $page.expansion.PSObject.Properties['contains']) {
            $pageContains = @($page.expansion.contains)
        }
        foreach ($c in $pageContains) { $allContains.Add($c) }
        if ($page.expansion -and $page.expansion.PSObject.Properties['total'] -and $null -ne $page.expansion.total) {
            $serverTotal = [int]$page.expansion.total
        }

        if ($null -eq $serverTotal -or $allContains.Count -ge $serverTotal -or $pageContains.Count -eq 0) { break }
        $offset = $allContains.Count
        Start-Sleep -Milliseconds 100
    }

    if ($null -ne $serverTotal -and $allContains.Count -ne $serverTotal) {
        throw "VSAC reported $serverTotal concepts for $Oid but returned $($allContains.Count)."
    }

    # Merge into one complete expansion: all concepts, an accurate total, and
    # no paging leftovers (offset / paging parameters), so the SDK's
    # EnsureCompleteExpansion accepts the file.
    $exp = $result.expansion
    if ($exp.PSObject.Properties['contains']) { $exp.contains = $allContains.ToArray() }
    else { $exp | Add-Member -NotePropertyName contains -NotePropertyValue $allContains.ToArray() }
    $conceptCount = Get-ConceptCount $exp.contains
    if ($exp.PSObject.Properties['total']) { $exp.total = $conceptCount }
    else { $exp | Add-Member -NotePropertyName total -NotePropertyValue $conceptCount }
    if ($exp.PSObject.Properties['offset']) { $exp.PSObject.Properties.Remove('offset') }
    if ($exp.PSObject.Properties['parameter']) {
        $exp.parameter = @($exp.parameter | Where-Object { $_.name -notin @('offset', 'count') })
        if ($exp.parameter.Count -eq 0) { $exp.PSObject.Properties.Remove('parameter') }
    }
    # The runner indexes value sets by canonical; make sure the resource carries it.
    if (-not ($result.PSObject.Properties['url'] -and $result.url)) {
        $result | Add-Member -NotePropertyName url -NotePropertyValue "$vsacFhirBase/ValueSet/$Oid" -Force
    }
    return $result
}

function Invoke-ValueSetSync {
    Write-Host ""
    Write-Host "========================================" -ForegroundColor Cyan
    Write-Host "Value Set Sync (VSAC FHIR)" -ForegroundColor Cyan
    Write-Host "========================================" -ForegroundColor Cyan
    Write-Host "  FHIR base: $vsacFhirBase"
    Write-Host "  Release:   $vsacReleaseManifest"
    Write-Host "  Corpus:    $valueSetsFolder"
    Write-Host "  API key:   $(if ($VsacApiKey) { 'provided' } else { 'NOT SET (-VsacApiKey / UMLS_API_KEY)' })"

    if (-not (Test-Path $valueSetsFolder)) {
        throw "Value set corpus not found at '$valueSetsFolder'. Initialize the Firely.Cql.Sdk.Integration.Runner submodule first (git submodule update --init)."
    }

    $requests = @()
    if ($ValueSetOids) {
        foreach ($oid in $ValueSetOids) {
            $version = $null
            $existingPath = Join-Path $valueSetsFolder "ValueSet-$oid.json"
            if (Test-Path $existingPath) {
                $existingValueSet = Get-Content -Raw -Path $existingPath | ConvertFrom-Json
                if ($existingValueSet.PSObject.Properties['version'] -and $existingValueSet.version) {
                    $version = [string]$existingValueSet.version
                }
            }
            $requests += [pscustomobject]@{ Oid = $oid; ValueSetVersion = $version }
        }
        Write-Host "`nFetching $($requests.Count) explicitly requested value set(s)."
    } else {
        Write-Host "`nScanning corpus for truncated and missing value sets (parses every file; takes a moment)..."
        $repair = Get-CorpusRepairList
        Write-Host ("  Files present: {0}   Truncated: {1}   Missing: {2}" -f $repair.PresentCount, $repair.Truncated.Count, $repair.Missing.Count)
        foreach ($t in $repair.Truncated) {
            Write-Host ("  truncated: {0} ({1} of {2} concepts)" -f $t.Oid, $t.Present, $t.Total)
        }
        foreach ($m in $repair.Missing) {
            Write-Host ("  missing:   {0} (referenced by {1})" -f $m.Oid, ($m.ReferencedBy -join ', '))
        }
        $requests += @($repair.Truncated | ForEach-Object { [pscustomobject]@{ Oid = $_.Oid; ValueSetVersion = $_.ValueSetVersion } })
        $requests += @($repair.Missing | ForEach-Object { [pscustomobject]@{ Oid = $_.Oid; ValueSetVersion = $null } })
    }

    if ($requests.Count -eq 0) {
        Write-Host "Corpus is complete - nothing to fetch." -ForegroundColor Green
        return
    }

    if (-not $VsacApiKey) {
        Write-Warning "$($requests.Count) value set(s) need fetching, but no VSAC API key is available."
        Write-Warning "Pass -VsacApiKey or set UMLS_API_KEY (create a key at https://uts.nlm.nih.gov > My Profile)."
        if ($ValueSetsOnly) { exit 1 }
        return
    }

    $fetched = @()
    $failed  = @()
    foreach ($request in $requests) {
        $oid = $request.Oid
        $valueSetVersion = $request.ValueSetVersion
        Write-Host "`nFetching ValueSet $oid (release=$vsacReleaseManifest$(if ($valueSetVersion) { ", valueSetVersion=$valueSetVersion" })) ..."
        try {
            $vs      = Get-VsacValueSet -Oid $oid -ValueSetVersion $valueSetVersion
            $outFile = Join-Path $valueSetsFolder "ValueSet-$oid.json"
            [System.IO.File]::WriteAllText($outFile, ($vs | ConvertTo-Json -Depth 60))

            # Validate what was written: parses, is complete, carries no paging leftovers.
            $check      = Get-Content -Raw -Path $outFile | ConvertFrom-Json
            $checkCount = Get-ConceptCount $check.expansion.contains
            if ($check.expansion.PSObject.Properties['offset'] -and [int]$check.expansion.offset -gt 0) {
                throw "written file still carries expansion.offset"
            }
            if ([int]$check.expansion.total -ne $checkCount) {
                throw "written file total ($($check.expansion.total)) does not match concept count ($checkCount)"
            }
            Write-Host ("  OK: {0} - {1} concepts -> {2}" -f $check.name, $checkCount, $outFile) -ForegroundColor Green
            $fetched += $oid
        } catch {
            Write-Warning "  FAILED: $oid - $($_.Exception.Message)"
            $failed += $oid
        }
        Start-Sleep -Milliseconds 200
    }

    Write-Host ""
    Write-Host "Value set sync complete: $($fetched.Count) fetched, $($failed.Count) failed." -ForegroundColor $(if ($failed.Count -eq 0) { 'Green' } else { 'Yellow' })
    if ($failed.Count -gt 0) {
        Write-Warning "Failed OIDs: $($failed -join ', ')"
        exit 1
    }
}

if ($ValueSetsOnly -and $SkipValueSets) {
    throw "-ValueSetsOnly and -SkipValueSets are mutually exclusive."
}
if ($ValueSetsOnly) {
    Invoke-ValueSetSync
    return
}

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
# UPDATE CMS69FHIRPCSBMIScreenAndFollowUp.cql
# -----------------------------
$cms69File = Join-Path $finalCql "CMS69FHIRPCSBMIScreenAndFollowUp.cql"
$cms69Backup = Join-Path $finalCql "CMS69FHIRPCSBMIScreenAndFollowUp.cql.original"

if (Test-Path $cms69File) {
    Write-Host "Backing up CMS69FHIRPCSBMIScreenAndFollowUp.cql to CMS69FHIRPCSBMIScreenAndFollowUp.cql.original"
    Copy-Item -Path $cms69File -Destination $cms69Backup -Force

    $fileContents = Get-Content -Raw -Path $cms69File
    $newFileContents = $fileContents -replace '\[ObservationCancelled: "Body mass index \(BMI\) \[Ratio\]"\] NoBMI', "[ObservationCancelled: code = `"Body mass index (BMI) [Ratio]`"] NoBMI // Modified by $scriptName`: Fixed ObservationCancelled syntax"
    Set-Content -Path $cms69File -Value $newFileContents -Force
    Write-Host "Updated CMS69FHIRPCSBMIScreenAndFollowUp.cql successfully."
} else {
    Write-Host "CMS69FHIRPCSBMIScreenAndFollowUp.cql not found in $finalCql"
}
# -----------------------------
# UPDATE CMS832FHIRHHAKI.cql
# -----------------------------
$cms832File = Join-Path $finalCql "CMS832FHIRHHAKI.cql"
$cms832Backup = Join-Path $finalCql "CMS832FHIRHHAKI.cql.original"

if (Test-Path $cms832File) {
    Write-Host "Backing up CMS832FHIRHHAKI.cql to CMS832FHIRHHAKI.cql.original"
    Copy-Item -Path $cms832File -Destination $cms832Backup -Force

    $fileContents = Get-Content -Raw -Path $cms832File
    $newFileContents = $fileContents -replace 'CrLabObsCategory:\s*CreatinineTestByTime\.category,', "CrLabObsCategory2: CreatinineTestByTime.category, // Modified by $scriptName`: Renamed duplicate CrLabObsCategory"
    Set-Content -Path $cms832File -Value $newFileContents -Force
    Write-Host "Updated CMS832FHIRHHAKI.cql successfully."
} else {
    Write-Host "CMS832FHIRHHAKI.cql not found in $finalCql"
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
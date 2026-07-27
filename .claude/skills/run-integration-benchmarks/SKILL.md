---
name: run-integration-benchmarks
description: Run the Firely.Cql.Sdk.Integration.Runner benchmark project against the HEDIS/CMS corpus (INTERNAL ACCESS ONLY), append a new dated baseline file, and report the percentage change vs. the most recent prior baseline. Use when asked to run, re-run, or refresh the integration runner benchmarks, or to compare current performance against baseline.
---

# Run Integration Runner Benchmarks

The benchmark harness lives in the `Firely.Cql.Sdk.Integration.Runner` submodule at
`submodules/Firely.Cql.Sdk.Integration.Runner`, not in this repo directly — everything
below runs from inside that submodule. It uses BenchmarkDotNet to time
`RunGeneratedIntegrationTestCase` (one CMS/HEDIS test case per invocation) and exports
results that get compared against files checked into
`IntegrationRunner.Benchmarks/baselines/`.

## 1. Build the test-case DLL

The benchmark host loads a compiled `Measures.dqm-content-qicore-2025.dll` and reads
`passed.jsonl` to know which cases already pass. Build it first if missing:

```bash
dotnet build submodules/Firely.Cql.Sdk.Integration.Runner/IntegrationRunner -c Release
```

## 2. Set the runner environment variables

Paths must be absolute and point at *this checkout's* submodule path — adjust the drive/
root if your working copy isn't at the same location:

```powershell
$root = "<repo-root>\submodules\Firely.Cql.Sdk.Integration.Runner"
$env:CQL_CMS_TEST_RUNNER_DataRootDirectory = "$root\IntegrationRunner"
$env:CQL_CMS_TEST_RUNNER_CmsMeasuresDllFile = "$root\IntegrationRunner\bin\Release\net10.0\Measures.dqm-content-qicore-2025.dll"
$env:CQL_CMS_TEST_RUNNER_PassesFile = "$root\IntegrationRunner\passed.jsonl"
$env:CQL_CMS_TEST_RUNNER_PassesFileBehavior = "ReadAndOnlyRunPreviousPasses"
```

## 3. Decide scope before running

Running every passed case (there are 1000+) at the default warm job (1 warmup + 5
iterations, separate process per case) takes hours. Match the scope to what you're
comparing against:

- **Same scope as an existing baseline file** (recommended default): reuse that baseline's
  `CQL_BENCH_FILTER`/case set so the comparison is apples-to-apples. Check
  `IntegrationRunner.Benchmarks/baselines/README.md` and the target baseline file's
  `DisplayInfo`/`Case` values for what was filtered.
- **A quick spot-check**: set `CQL_BENCH_MAX_CASES` to a small number.
- **A full refresh**: omit both filters, but warn the user of the expected multi-hour
  runtime first and prefer running it as a background task.

Job selection (`CQL_BENCH_JOB`, default `warm`):
- `warm` — realistic per-call latency after JIT/fixture warmup. Use this for baseline
  comparisons; it's what the existing `*-warm-*` baseline files use.
- `cold` — process-start-inclusive. The existing `*-coldstart.csv` baseline predates the
  `CqlValueSetLoader` cache and instance-reuse changes, so don't compare fresh `cold` runs
  against it for absolute numbers — only for relative case-to-case ranking above the fixed
  ~2.1s floor, and note that caveat if you use it.

## 4. Run it

```bash
dotnet run --project submodules/Firely.Cql.Sdk.Integration.Runner/IntegrationRunner.Benchmarks/IntegrationRunner.Benchmarks.csproj -c Release
```

BenchmarkDotNet writes results under
`submodules/Firely.Cql.Sdk.Integration.Runner/IntegrationRunner.Benchmarks/BenchmarkDotNet.Artifacts/results/`
(`*-report.csv`, `*-report-brief.json`, `*-report-github.md`, `*-report.html`).

## 5. Compare against the most recent prior baseline

1. Find the most recent applicable file in `IntegrationRunner.Benchmarks/baselines/`
   matching the same TFM and job (`<yyyy-MM-dd>-<tfm>-<job>.{csv,json}`).
2. Match cases by their `CaseId`/`Case` key (not by row position) between the prior
   baseline and the new `*-report-brief.json`/`*-report.csv`.
3. Compare **medians**, not means — these benchmarks run cold-start-per-case with only 5
   iterations, so a single slow outlier (GC pause, disk I/O) can swing the mean by 10x
   without reflecting a real regression. Report:
   - `% change = (new_median - old_median) / old_median * 100` per matched case
   - an aggregate (e.g. mean-of-medians) only if comparing many cases
4. Call out any case whose `%change` exceeds roughly ±20% by name — that's the actionable
   signal, not the aggregate.
5. If the prior baseline's conditions note a caveat (like the `cold` baseline's
   pre-cache-introduction note), repeat that caveat rather than presenting a clean
   number.

## 6. Add the new baseline file

- Name it `<yyyy-MM-dd>-<tfm>-<job>.csv` (or `.json` for full BenchmarkDotNet exports),
  following the existing files' convention, and put it in
  `IntegrationRunner.Benchmarks/baselines/`.
- Update `IntegrationRunner.Benchmarks/baselines/README.md`'s file list and "Conditions"
  section (machine, OS, .NET version, job parameters, any caveats) — mirror the existing
  entries' format.
- This submodule is a separate (private) repository: committing and pushing the new
  baseline there, and then bumping the submodule pointer in this repo, are two separate
  steps. Confirm with the user before pushing to either repo — follow this repo's normal
  git safety rules (never push without being asked).

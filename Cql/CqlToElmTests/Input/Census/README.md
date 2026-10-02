# 1. Translator census

[`TranslatorCensusTest`](../../%28tests%29/TranslatorCensusTest.cs) translates every CQL corpus in the repository with the .NET CQL-to-ELM translator and compares the outcome per library with the baseline files in this directory.

## 1.1. What the test measures

Each library in a corpus is resolved through the toolkit's library provider and built on its own, so an exception in one library cannot hide the result of another. Every library ends up in one of three outcomes:

- **clean**: the ELM carries no annotation with error severity (warnings and infos are ignored);
- **errors**: the ELM carries one or more error-severity annotations;
- **crash**: translation threw an exception.

The test has one row per corpus run:

| Run | Directory | Model infos |
|---|---|---|
| `demo` | `LibrarySets/Demo/Cql` | none |
| `rr23` | `LibrarySets/RR23/Cql` | none |
| `coretests-hl7` | `Cql/CoreTests/Input/ELM/HL7` | none |
| `authoring` | `Demo/Measures.Authoring/Input/cql` | none |
| `authoring-qicore-4.1.1` | `Demo/Measures.Authoring/Input/cql` | QICore 4.1.1, US Core 3.1.1 |
| `dqm-qicore-2025` | `LibrarySets/dqm-content-qicore-2025/Cql` | none |
| `dqm-qicore-2025-qicore-6.0.0` | `LibrarySets/dqm-content-qicore-2025/Cql` | QICore 6.0.0, US Core 6.1.0 |
| `hedis-2025` | `submodules/Firely.Cql.Sdk.Integration.Runner/Hedis2025/Cql` | none |

The QICore corpora run both without and with the model infos, so the effect of the model infos stays visible. The model info files are described in [`../ModelInfo/README.md`](../ModelInfo/README.md).

## 1.2. Baseline files

### 1.2.1. Known-pass files

`<run>.known-pass.txt` lists the libraries of that run that translate cleanly, one identifier per line in the form `Name-Version`, sorted. Blank lines and lines starting with `#` are ignored.

- A listed library that no longer translates cleanly, or is no longer in the corpus, **fails** the test.
- A library that translates cleanly but is not listed is reported as a `WARNING` in the test output. It does not fail the test; promote it by refreshing the file (see [1.4.](#14-refreshing-the-baselines)) so that it is protected from then on.

### 1.2.2. The HEDIS counts file

`hedis-2025.counts.txt` holds only the number of libraries per outcome (`total`, `clean`, `errors`, `crash` as `key=value` lines). The test fails when fewer libraries translate cleanly than `clean`; other differences are reported as warnings.

The HEDIS corpus lives in a private submodule and is licensed content, so nothing that identifies its libraries is committed to this repository: no names in the baseline, and only counts in the test output and failure messages. The per-library detail is written to the report file only, which stays with the test results of the run (see [1.3.](#13-the-report)). When the submodule is not checked out, this row is inconclusive rather than failing.

## 1.3. The report

Every run writes two files into a `TranslatorCensus` folder in the test results directory (the `--results-directory` of `dotnet test`, by default `Cql/CqlToElmTests/TestResults`) and attaches them to the test result, so a TRX logger, and with it CI, keeps them with the test results. The one exception is the report of the HEDIS run, which names libraries of licensed content: it is written but not attached, and stays on the machine that ran the test.

- `<run>.report.txt`: the summary counts, a histogram of error messages and a line per library with its outcome and messages. The histogram groups messages after replacing quoted strings by `'…'` or `"…"` and digit runs by `N`, and is sorted by the number of libraries affected, so the dominant root cause is at the top. Crashes appear as `Crash: <exception type>: <message>` followed by the first stack frame inside the translator.
- the candidate baseline, named exactly like the committed file it would replace.

The path of both files is printed in the test output.

## 1.4. Refreshing the baselines

After a translator change, run only the census:

```shell
dotnet test Cql/CqlToElmTests/CqlToElmTests.csproj --filter FullyQualifiedName~TranslatorCensus
```

Then copy each candidate baseline from the `TranslatorCensus` folder over the committed file in this directory, and review the diff: removed lines are regressions that need a reason, added lines are libraries that now translate cleanly. Never edit the files by hand.

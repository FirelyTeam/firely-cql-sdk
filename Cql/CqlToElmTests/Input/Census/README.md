# 1. Translator census

[`TranslatorCensusTest`](../../%28tests%29/TranslatorCensusTest.cs) translates every CQL corpus in the repository with the .NET CQL-to-ELM translator and compares the outcome per library with the baseline files in this directory.

## 1.1. What the test measures

Each library in a corpus is resolved through the toolkit's library provider and built on its own, so an exception in one library cannot hide the result of another. Every CQL file ends up in exactly one of three outcomes:

- **clean**: the ELM carries no annotation with error severity (warnings and infos are ignored);
- **errors**: the ELM carries one or more error-severity annotations;
- **crash**: translation threw an exception, or the file could not be loaded at all: its library declaration cannot be parsed, or it declares the same library identifier as another file. A file that cannot be loaded is reported under its path relative to the corpus directory instead of a library identifier.

The test fails when the number of outcomes differs from the number of CQL files, so no file can drop out of the census unnoticed.

The test has one row per corpus run:

| Run | Directory | Additional models | Reference ELM (see [1.5.](#15-elm-checks)) |
|---|---|---|---|
| `demo` | `LibrarySets/Demo/Cql` | none | `LibrarySets/Demo/Elm` |
| `rr23` | `LibrarySets/RR23/Cql` | none | `LibrarySets/RR23/Elm` |
| `coretests-hl7` | `Cql/CoreTests/Input/ELM/HL7` | none | the same directory |
| `authoring` | `Demo/Measures.Authoring/Input/cql` | none | none |
| `authoring-qicore-4.1.1` | `Demo/Measures.Authoring/Input/cql` | QICore 4.1.1, US Core 3.1.1 | none |
| `dqm-qicore-2025` | `LibrarySets/dqm-content-qicore-2025/Cql` | none | none: the reference was produced with QICore |
| `dqm-qicore-2025-qicore-6.0.0` | `LibrarySets/dqm-content-qicore-2025/Cql` | QICore 6.0.0, US Core 6.1.0 | `LibrarySets/dqm-content-qicore-2025/Elm` |
| `hedis-2025` | `submodules/Firely.Cql.Sdk.Integration.Runner/Hedis2025/Cql` | none | `submodules/Firely.Cql.Sdk.Integration.Runner/Hedis2025/Elm` |

Every run uses the toolkit's default models (System and FHIR 4.0.1). The QICore runs add the QICore and US Core model infos bundled in `Hl7.Cql.Model`, selected through `CqlToolkitConfig.Models` (see [`Cql/Cql.Model/README.md`](../../../Cql.Model/README.md)). The QICore corpora run both without and with them, so the effect of the model infos stays visible.

## 1.2. Baseline files

### 1.2.1. Known-pass files

`<run>.known-pass.txt` lists the libraries of that run that translate cleanly, one identifier per line in the form `Name-Version`, sorted. Blank lines and lines starting with `#` are ignored.

- A listed library that no longer translates cleanly, or is no longer in the corpus, **fails** the test.
- A library that translates cleanly but is not listed is reported as a `WARNING` in the test output. It does not fail the test; promote it by refreshing the file (see [1.4.](#14-refreshing-the-baselines)) so that it is protected from then on.

### 1.2.2. The HEDIS counts file

`hedis-2025.counts.txt` holds only the number of libraries per outcome (`total`, `clean`, `errors`, `crash` as `key=value` lines). The test fails when fewer libraries translate cleanly than `clean`; other differences are reported as warnings.

The HEDIS corpus lives in a private submodule and is licensed content, so nothing that identifies its libraries is committed to this repository: no names in the baseline, and only counts in the test output and failure messages. The per-library detail is written to the report file only, which stays with the test results of the run (see [1.3.](#13-the-report)). When the submodule is not checked out, this row is inconclusive rather than failing.

In CI, the HEDIS row runs in the HEDIS job (`TestHedisNet10` in [`build/build-test-sign.yml`](../../../../build/build-test-sign.yml)), which checks out the submodules and runs the census on .NET 10. The multi-target test jobs check out no submodules, so the row is inconclusive there.

### 1.2.3. Compile baseline files

The compile stage (see [1.6.](#16-compiling)) has a baseline of its own, with the same rules. `<run>.known-compile.txt` lists the clean libraries whose ELM compiles to an assembly: a listed library that no longer compiles, or no longer translates cleanly, fails the test, and a compiling library that is not listed is a `WARNING`. For HEDIS, `hedis-2025.compile-counts.txt` holds only the number of clean libraries per compile outcome (`compiled`, `blocked`, `failed`, `cascade`), and the test fails when fewer than `compiled` compile. Being counts only, it cannot tell one library regressing while another is promoted from no change.

## 1.3. The report

Every run writes its files into a `TranslatorCensus` folder in the test results directory (the `--results-directory` of `dotnet test`, by default `Cql/CqlToElmTests/TestResults`) and attaches them to the test result, so a TRX logger, and with it CI, keeps them with the test results. The exceptions are the reports of the HEDIS run, which name libraries of licensed content: they are written but not attached, and stay on the machine that ran the test.

- `<run>.report.txt`: the summary counts, a histogram of error messages and a line per library with its outcome and messages. The histogram groups messages after replacing quoted strings by `'…'` or `"…"` and digit runs by `N`, and is sorted by the number of libraries affected, so the dominant root cause is at the top. Crashes appear as `Crash: <exception type>: <message>` followed by the first stack frame inside the translator.
- the candidate baseline, named exactly like the committed file it would replace.
- `<run>.elm-report.txt`: the results of the ELM checks (see [1.5.](#15-elm-checks)). For the HEDIS run, `hedis-2025.elm-counts.txt` with only the counts is attached instead.
- `<run>.compile-report.txt`: the compile outcome counts, a histogram of the compile failures, normalized like the message histogram, and a line per clean library with its compile outcome (see [1.6.](#16-compiling)). The candidate compile baseline is written next to it. For the HEDIS run only the candidate, which holds counts, is attached.

The path of each file is printed in the test output.

## 1.4. Refreshing the baselines

After a translator change, run only the census:

```shell
dotnet test Cql/CqlToElmTests/CqlToElmTests.csproj --filter FullyQualifiedName~TranslatorCensus
```

Then copy each candidate baseline from the `TranslatorCensus` folder over the committed file in this directory, and review the diff: removed lines are regressions that need a reason, added lines are libraries that now translate cleanly or compile. Never edit the files by hand.

## 1.5. ELM checks

Every run also checks the ELM the translator emits, in two ways.

### 1.5.1. Independent checkers (a gate)

The ELM of every library that does not crash is written as JSON and checked by two checkers that do not depend on how it was produced:

- **Read-back.** The `Hl7.Cql.Elm` reader reads the JSON, and writing what it read gives the same JSON. An absent collection and an empty one count as the same, since the reader materializes the empty definition lists the writer leaves out.
- **Schema.** The library as read is written as ELM XML and validated against the ELM schema in [`Cql/Elm/Schema`](../../../Elm/Schema). The library as read is checked, not the translator's own object graph, because what matters is what a consumer of the JSON gets.

A clean library that fails either check **fails** the test. A library with translation errors carries placeholders where translation failed, so its findings are listed in the report but do not fail the test.

### 1.5.2. Structural comparison with the reference ELM (a report)

When the run has reference ELM (see the table in [1.1.](#11-what-the-test-measures)), the ELM of every clean library is compared with the reference ELM of the same library, found by the identifier the reference declares. The comparison never fails the test: legitimate differences between the two translators are expected, and what it is for is showing where they disagree and how that changes from one change to the next.

Both sides are first normalized ([`ElmNormalizer`](../../ElmComparison/ElmNormalizer.cs)), which removes differences in spelling only: source locators, local identifiers, annotations and signatures are dropped; a type named by a qualified name becomes the equivalent type specifier; absent and empty collections, and absent attributes and their schema defaults (including the ones that differ per node, such as `distinct` on a return clause and on an aggregate clause), count as the same; the members of a choice type and of a tuple type, and the definitions of the library, are sorted. Operands keep their order.

The comparison ([`ElmStructuralDiff`](../../ElmComparison/ElmStructuralDiff.cs)) matches definitions by name (functions by name and operand types) and everything else by position, and classifies every difference:

| Kind | Meaning |
|---|---|
| `ConversionPlacement` | one side converts an expression (`As`, `ToDecimal`, a `FHIRHelpers` conversion, …) where the other does not, or converts it differently; the comparison continues with what is converted |
| `MissingNode` | the reference has a node, list or definition this translator does not emit |
| `ExtraNode` | this translator emits a node, list or definition the reference does not have |
| `ReplacedNode` | a different kind of node in the same place; what is below it is not compared, so one difference does not cascade |
| `TypeDifference` | the same node, typed differently: its result type, the type it converts to, tests or declares, or the type of a literal, instance or retrieve; a result type present on one side only is not a difference |
| `ValueDifference` | the same node, with a different attribute value, or an attribute present on one side only |

The report gives the totals per kind, a histogram of the differences (grouped by kind, property and detail, the detail normalized like the message histogram in [1.3.](#13-the-report), most widespread first), and per library its differences with their paths. A library whose comparison throws is listed as such and does not stop the run.

## 1.6. Compiling

Every run also compiles the clean libraries to C# and an assembly, the next level after translation: the ELM-to-C#-to-assembly pipeline that runs over the reference ELM in the shipped build runs over the .NET translator's ELM here. The ELM compiled is the JSON as read back by the `Hl7.Cql.Elm` reader, which the ELM checks validated, and it is compiled with the default `ElmToolkitConfig`, which does not allow invalid C#.

A library is compiled together with the libraries it includes, so every clean library ends up in one of four outcomes:

| Outcome | Meaning |
|---|---|
| `compiled` | it compiled to an assembly |
| `blocked` | a library it includes, directly or indirectly, did not translate cleanly, so it was not compiled at all |
| `failed` | it failed to compile itself: in the ELM preprocessor, the code builder, C# generation or the C# compiler; the report gives the innermost exception, and for the C# compiler its first error |
| `cascade` | a library it includes, directly or indirectly, was compiled with it and failed |

`blocked` and `cascade` name the library at the root of the chain of includes: for `blocked` the one that did not translate cleanly, or whose ELM could not be written or read back; for `cascade` the one that failed itself. The baselines are described in [1.2.3.](#123-compile-baseline-files) and the report in [1.3.](#13-the-report).

# 4. Development Guidelines

Parent document: [../copilot-instructions.md](../copilot-instructions.md)

## 4.0. Table of Contents

- [4. Development Guidelines](#4-development-guidelines)
- [4.0. Table of Contents](#40-table-of-contents)
- [4.1. File Headers](#41-file-headers)
- [4.2. Making Changes](#42-making-changes)
- [4.3. Project References](#43-project-references)
- [4.4. Documentation](#44-documentation)
- [4.5. Release Notes](#45-release-notes)

## 4.1. File Headers

### 4.1.1. Overview

4.1.1.1 Copyright header requirements for C# source files (`*.cs`, excluding `*.g.cs` generated files)

### 4.1.2. For NEW Files (files being created)

```csharp
/*
 * Copyright (c) <CURRENT_YEAR>, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
```

### 4.1.3. For EXISTING Files

4.1.3.1 **DO NOT modify existing copyright headers** in files that already have them
4.1.3.2 Leave existing headers exactly as they are (e.g., "NCQA and contributors" should remain unchanged)
4.1.3.3 **When making changes to a file and Firely is not listed as contributor, add it as "Firely, NCQA and contributors"**

### 4.1.4. Header Guidelines

4.1.4.1 Use the current year in the copyright notice for new files only (replace `<CURRENT_YEAR>` with the actual current year, e.g., 2026 for files created in 2026)

4.1.4.2 For new files, include "Firely, NCQA and contributors" in the copyright line

4.1.4.3 Place header at the very top of the file, after any `#pragma` directives if present

4.1.4.4 Generated files (\*.g.cs) do not require headers

4.1.4.5 **Never update or modify existing copyright headers in existing files**

## 4.2. Making Changes

4.2.1 Use minimal, surgical changes - modify as few lines as possible

4.2.2 Maintain existing code structure and patterns

4.2.3 Run builds and tests to validate changes

4.2.4 Use existing project conventions and naming patterns

4.2.5 **Always ensure blank lines contain no spaces** - blank lines must be completely empty

4.2.6 **When adding new utility files or functionality that are only used internally, keep those types as `internal`, not `public`** - Only expose public APIs when they are intended for external consumption

4.2.7 **When creating new files or modifying existing ones, always remove unused usings at the top of the file** - Keep using statements clean and only include what is actually used

4.2.8 **Do not add duplicate usings in files where the using is already included globally in `GlobalUsings.cs`** - Check GlobalUsings.cs first to avoid redundant using statements

4.2.9 **Always use the latest C# language features** when appropriate:
4.2.9.1 Use collection expressions `[]` instead of `new[] { ... }` for arrays and collections

4.2.9.2 Use target-typed `new()` expressions when the type is clear from context

4.2.9.3 Use pattern matching and switch expressions where applicable

4.2.9.4 Use record types for immutable data structures

4.2.9.5 Use nullable reference types and null-conditional operators

4.2.9.6 Use string interpolation instead of `string.Format` or concatenation

4.2.10 **Local functions must use camelCase naming** - Local functions (functions defined inside methods) should start with a lowercase letter (e.g., `processItem()`, not `ProcessItem()`)

4.2.11 **Always enable nullable on all new code** — Every new `.cs` file must have `#nullable enable` at the top (after any copyright header). If the project already enables nullable globally (via `<Nullable>enable</Nullable>` in props), the directive is still required in each new file for explicitness.

## 4.3. Project References

4.3.1 When adding internal access, ensure the requesting project is appropriate for internal API usage

4.3.2 Preview/test projects can access internals, production projects should use public APIs

4.3.3 Always validate that internal access is truly needed

## 4.4. Documentation

4.4.1 Update README files when adding new projects or significant features

4.4.2 **When adding dependencies, also update the README's Dependencies section**

4.4.3 Document experimental features clearly in preview projects

4.4.4 Maintain clear separation between stable and experimental examples

4.4.5 **IMPORTANT: Do not add C# code samples in Usage sections for internal-only projects**
4.4.5.1 If a project is primarily used internally or through higher-level APIs, avoid providing code examples

4.4.5.2 Only include code samples for packages that have clear public usage patterns designed for direct consumer use

4.4.5.3 Remove any placeholder or comment-only code blocks from documentation

4.4.5.4 Internal packages should describe what they do but not show how to use them directly

4.4.6 **ALWAYS use Markdown hyperlinks when referencing other documents** — never use plain text file names or paths for cross-document references
4.4.6.1 Every reference to another document (README, guide, spec, etc.) must be a clickable Markdown link: `[Display Text](relative/path/to/file.md)`

4.4.6.2 Use relative paths from the referencing file's location (e.g., `[build/README.md](../build/README.md)` from `docs/`, or `[README.md](README.md)` for a sibling file)

4.4.6.3 When updating a document, scan all references to other files and ensure they are hyperlinked

4.4.6.4 When renaming or moving a document, update all hyperlinks that point to it across the repository

4.4.6.5 Never leave plain-text file path references where document links are intended

4.4.7 **Core documentation rules**

4.4.7.1 Use file paths that exist in the repository

4.4.7.2 Include working command examples

4.4.7.3 Keep version numbers and dates current

4.4.7.4 Mark completed items with ✅ where applicable

4.4.7.5 Add `Recent Updates` sections using `YYYY-MM-DD` dates when relevant

4.4.7.6 Use relative links between docs

4.4.8 **Heading numbering standards**

4.4.8.1 All documentation headings must use hierarchical numbering (`# 1.`, `## 1.1.`, `### 1.1.1.`)

4.4.8.2 Renumber sequentially whenever adding, removing, or reordering sections

4.4.8.3 Avoid unnumbered headings

4.4.8.4 In `.github/copilot-instructions.md` and its sub-documents, preserve strict numbering integrity

4.4.8.5 Never introduce duplicated heading numbers or stale TOC/rule references after edits

4.4.8.6 In `.github/copilot-instructions.md` and its sub-documents, cap heading numbering at three segments maximum (for example `# 1.`, `## 1.1.`, `### 1.1.1.`)

4.4.8.7 Do not create headings deeper than `###` in copilot instruction docs

4.4.8.8 If more detail is needed, keep deeper numbering in body text or lists (for example `1.1.1.1`) instead of adding deeper headings

4.4.9 **TOC consistency**

4.4.9.1 Keep TOC format consistent in top-level docs with TOCs (for example `README.md`, `docs/getting-started.md`)

4.4.9.2 Use TOC heading style `## 1.0. Table of Contents`

4.4.9.3 Prefer a single flat bullet list of links (avoid nested TOC subsection bullets unless required)

4.4.9.4 Update TOC entries in the same edit whenever sections move or change

4.4.10 **Parent-document link for nested docs**

4.4.10.1 Nested documents should include a `Parent document:` link near the top

4.4.10.2 Use the nearest meaningful parent, not only the immediate folder container

4.4.10.3 Keep the parent link above main content

## 4.5. Release Notes

4.5.1 When asked to create release notes, use [docs/releases/release-notes-template.md](../docs/releases/release-notes-template.md) as the default structure and guidance.

4.5.2 Base release notes on the full set of commits since the previous release tag and incorporate any relevant content from [docs/releases/vnext-release-notes.md](../docs/releases/vnext-release-notes.md).

4.5.3 For public API changes, always call out the exact type/member/property/method names so developers can identify what changed.

4.5.4 For dependency version bumps, explicitly mention the version property name and old/new version when known (for example, `FirelyNetVersion`).

4.5.5 **When bumping `VersionPrefix` (the SDK version), also update the version number in the `## Release Notes` section of `README.md`** — it contains a line like `This is release version X.Y.Z of the engine.` that must be kept in sync.

4.5.6 **After creating release notes, move all content from [docs/releases/vnext-release-notes.md](../docs/releases/vnext-release-notes.md) into the release notes document** — the content in that file is pre-drafted material that belongs in the final release notes and must not be left behind.

4.5.7 **After moving the vnext content, reset [docs/releases/vnext-release-notes.md](../docs/releases/vnext-release-notes.md) to the empty template** — the file must be left with only the section headings and no content, ready for the next release cycle. The empty template is:

```md
# vNext Release Notes

## Breaking Changes

## Features

## Fixes
```

4.5.8 **Save all release notes files under `docs/releases/`** — both versioned release notes (e.g. `docs/releases/release-notes-2.7.0.md`) and `docs/releases/vnext-release-notes.md` live in this subdirectory.

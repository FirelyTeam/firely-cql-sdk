# 04. Development Guidelines

## 4.1 File Headers

### 4.1.1 Overview

4.1.1.1 Copyright header requirements for C# source files (*.cs, excluding *.g.cs generated files).

### 4.1.2 For New Files

```csharp
/*
 * Copyright (c) <CURRENT_YEAR>, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
```

### 4.1.3 For Existing Files

4.1.3.1 Do not modify existing copyright headers in files that already have them.

4.1.3.2 Leave existing headers exactly as they are (for example, NCQA and contributors should remain unchanged).

4.1.3.3 When making changes to a file and Firely is not listed as contributor, add it as Firely, NCQA and contributors.

### 4.1.4 Header Guidelines

4.1.4.1 Use the current year in copyright notice for new files only.

4.1.4.2 For new files, include Firely, NCQA and contributors in the copyright line.

4.1.4.3 Place header at the top of file, after any pragma directives if present.

4.1.4.4 Generated files (*.g.cs) do not require headers.

4.1.4.5 Never update or modify existing headers in existing files.

## 4.2 Making Changes

4.2.1 Use minimal, surgical changes and modify as few lines as possible.

4.2.2 Maintain existing code structure and patterns.

4.2.3 Run builds and tests to validate changes.

4.2.4 Use existing project conventions and naming patterns.

4.2.5 Ensure blank lines contain no spaces.

4.2.6 When adding new utility files or functionality only used internally, keep those types internal, not public.

4.2.7 When creating new files or modifying existing ones, remove unused usings.

4.2.8 Do not add duplicate usings where already included globally in GlobalUsings.cs.

4.2.9 Always use latest C# language features when appropriate:

4.2.9.1 Use collection expressions [] instead of new[] { ... } where applicable.

4.2.9.2 Use target-typed new() where the type is clear.

4.2.9.3 Use pattern matching and switch expressions where applicable.

4.2.9.4 Use record types for immutable data structures.

4.2.9.5 Use nullable reference types and null-conditional operators.

4.2.9.6 Use string interpolation instead of string.Format or concatenation.

4.2.10 Local functions must use camelCase naming.

4.2.11 Always enable nullable on all new code. Every new .cs file must include #nullable enable at top (after header).

## 4.3 Project References

4.3.1 When adding internal access, ensure requesting project is appropriate for internal API usage.

4.3.2 Preview and test projects can access internals. Production projects should use public APIs.

4.3.3 Always validate that internal access is truly needed.

## 4.4 Documentation

4.4.1 Update README files when adding new projects or significant features.

4.4.2 When adding dependencies, also update README Dependencies section.

4.4.3 Document experimental features clearly in preview projects.

4.4.4 Maintain clear separation between stable and experimental examples.

4.4.5 Do not add C# code samples in Usage sections for internal-only projects.

4.4.5.1 If a project is primarily used internally or through higher-level APIs, avoid direct code examples.

4.4.5.2 Include code samples only for packages with clear public usage patterns.

4.4.5.3 Remove placeholder or comment-only code blocks from documentation.

4.4.5.4 Internal packages should describe what they do but not show direct usage.

4.4.6 Always use Markdown hyperlinks when referencing other documents.

4.4.6.1 Every reference to another document must be clickable Markdown link syntax.

4.4.6.2 Use relative paths from referencing file location.

4.4.6.3 When updating a document, scan references and ensure they are hyperlinked.

4.4.6.4 When renaming or moving a document, update all hyperlinks that point to it.

## 4.5 Release Notes

4.5.1 When asked to create release notes, use [docs/releases/release-notes-template.md](../../docs/releases/release-notes-template.md) as default structure and guidance.

4.5.2 Base release notes on full set of commits since previous release tag and include relevant content from [docs/releases/vnext-release-notes.md](../../docs/releases/vnext-release-notes.md).

4.5.3 For public API changes, call out exact type, member, property, and method names.

4.5.4 For dependency version bumps, mention version property name and old/new versions when known.

4.5.5 When bumping VersionPrefix, also update version number in Release Notes section of [README.md](../../README.md).

4.5.6 After creating release notes, move all content from [docs/releases/vnext-release-notes.md](../../docs/releases/vnext-release-notes.md) into release notes document.

4.5.7 After moving vnext content, reset [docs/releases/vnext-release-notes.md](../../docs/releases/vnext-release-notes.md) to this empty template:

```md
# vNext Release Notes

## Breaking Changes

## Features

## Fixes
```

4.5.8 Save all release notes files under docs/releases.

# 1. Copilot Instructions for Firely CQL SDK

**Version:** 3.2.0

This file is the decision-tree entry point. Route tasks here first, then open the focused sub-document before choosing tools.

## 1.0. Table of Contents

- [1. Copilot Instructions for Firely CQL SDK](#1-copilot-instructions-for-firely-cql-sdk)
- [1.0. Table of Contents](#10-table-of-contents)
- [2.0. Decision Tree / Task Taxonomy](#20-decision-tree--task-taxonomy)
- [3.0. Quick Navigation Index](#30-quick-navigation-index)
- [4.0. Project Context (Brief)](#40-project-context-brief)
- [5.0. Critical Files to Keep Updated (High-Level)](#50-critical-files-to-keep-updated-high-level)
- [6.0. Appendix: Version History](#60-appendix-version-history)

## 2.0. Decision Tree / Task Taxonomy

- Start here for every task: classify request first, open matching sub-document, then execute.
- If multiple categories apply: read all relevant sub-docs before implementation.

- Task-style preferences or GitHub workflow task?
  - Discuss-before-implementing, PR description expectations, GitHub CLI usage, issue formatting, ticket pickup, instruction maintenance, terminal behavior
  - Read [01-user-workflow-preferences.md](copilot-instructions/01-user-workflow-preferences.md)

- InternalsVisibleTo task?
  - InternalsVisibleTo placement, csproj format, signing key usage
  - Read [02-internalsvisibleto-configuration.md](copilot-instructions/02-internalsvisibleto-configuration.md)

- Project discovery task?
  - SDK project placement and examples layout
  - Read [03-project-structure.md](copilot-instructions/03-project-structure.md)

- Code-change or documentation standards task?
  - File headers, coding conventions, internal/public API boundaries, documentation numbering, TOC consistency, parent-document links, README and release-note policies
  - Read [04-development-guidelines.md](copilot-instructions/04-development-guidelines.md)

- Build or cross-platform script task?
  - Build entry points, Windows/Unix compatibility, generator versioning, ELM generation workflow
  - Read [05-build-and-test.md](copilot-instructions/05-build-and-test.md)

- Naming conventions task?
  - Naming prefixes and namespace rules
  - Read [06-naming-conventions.md](copilot-instructions/06-naming-conventions.md)

- FHIR Library handling task?
  - Library.Name vs Library.Id, identifier construction
  - Read [07-fhir-library-resource-handling.md](copilot-instructions/07-fhir-library-resource-handling.md)

- CQL specification conformance task?
  - Specification source of truth, when to consult spec, exact spec file locations
  - Read [08-cql-specification-conformance.md](copilot-instructions/08-cql-specification-conformance.md)

- Nullological operator behavior task?
  - Interface vs implementation return type contract
  - Read [09-nullological-operators-design-pattern.md](copilot-instructions/09-nullological-operators-design-pattern.md)

- CQL evaluation exception design task?
  - ICqlError and CqlException<TError> pattern, error placement, usage boundaries
  - Read [10-cql-evaluation-exceptions.md](copilot-instructions/10-cql-evaluation-exceptions.md)

## 3.0. Quick Navigation Index

- [01-user-workflow-preferences.md](copilot-instructions/01-user-workflow-preferences.md)
- [02-internalsvisibleto-configuration.md](copilot-instructions/02-internalsvisibleto-configuration.md)
- [03-project-structure.md](copilot-instructions/03-project-structure.md)
- [04-development-guidelines.md](copilot-instructions/04-development-guidelines.md)
- [05-build-and-test.md](copilot-instructions/05-build-and-test.md)
- [06-naming-conventions.md](copilot-instructions/06-naming-conventions.md)
- [07-fhir-library-resource-handling.md](copilot-instructions/07-fhir-library-resource-handling.md)
- [08-cql-specification-conformance.md](copilot-instructions/08-cql-specification-conformance.md)
- [09-nullological-operators-design-pattern.md](copilot-instructions/09-nullological-operators-design-pattern.md)
- [10-cql-evaluation-exceptions.md](copilot-instructions/10-cql-evaluation-exceptions.md)

## 4.0. Project Context (Brief)

- Firely CQL SDK provides CQL parsing, compilation, runtime evaluation, invocation, and packaging support.
- Primary technologies:
  - C# and .NET
  - SDK generation from ELM
  - Cross-platform PowerShell and Bash build workflows
- Core folders:
  - Cql for core SDK projects and tests
  - Examples for public and preview samples
  - docs for product and development documentation
  - spec for authoritative condensed CQL specification and conformance materials

## 5.0. Critical Files to Keep Updated (High-Level)

- Always keep these areas synchronized with behavior changes:
  - Root and project README files
  - docs release-note files and related documentation
  - Build and test scripts in both PowerShell and Bash variants
  - Any generator version constants and compatibility checks
  - Public API metadata files when adding public surfaces
- Use [04-development-guidelines.md](copilot-instructions/04-development-guidelines.md) and [05-build-and-test.md](copilot-instructions/05-build-and-test.md) for detailed enforcement rules.

## 6.0. Appendix: Version History

- 3.2.0
  - Added a durable documentation rule for copilot instruction docs: cap heading numbering at three segments and keep deeper numbering in body text instead of deeper headings.
- 3.1.0
  - Incorporated GitHub workflow guidance for GitHub CLI usage, issue formatting, ticket pickup, PR body synchronization, and instruction-maintenance safeguards.
  - Incorporated documentation standards for heading numbering, TOC consistency, parent-document links, and cross-document linking rules.
- 3.0.0
  - Major reorganization: split monolithic instructions into decision tree plus focused sub-documents.
  - Added task-taxonomy-first routing and quick index.
- 2.10.0 and earlier
  - Legacy monolithic structure retained in git history.

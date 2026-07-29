# Mermaid Diagram Export

Renders Mermaid diagrams to `.svg` via [@mermaid-js/mermaid-cli](https://github.com/mermaid-js/mermaid-cli),
so markdown docs can embed a pre-rendered image instead of relying on the host's inline Mermaid
renderer. GitHub's renderer does not reliably support every Mermaid feature used in this repo's
diagrams (`subgraph` grouping, HTML node labels, multi-target `style` directives), so those diagrams
are authored as standalone `.mmd` source files and shipped as `.svg` artifacts instead.

For the full authoring workflow (file layout, naming, embedding, migrating an old inline diagram),
see the [generate-svg-from-mermaid](../../.claude/skills/generate-svg-from-mermaid/SKILL.md) skill.

**Location:** `tools/mermaid/`

**Scripts:** `export-mermaid-svg.ps1` (PowerShell) and `export-mermaid-svg.sh` (Bash) — functionally
equivalent; use whichever matches your shell.

## Usage

Render a single standalone `.mmd` source file to `.svg`:

```powershell
pwsh tools/mermaid/export-mermaid-svg.ps1 -MarkdownPath docs/dependency-diagrams.md -SourcePath docs/diagrams/dependency-diagrams.elm-toolkit-services.mmd -OutputDir docs/diagrams
```

```bash
tools/mermaid/export-mermaid-svg.sh --markdown-path docs/dependency-diagrams.md --source-path docs/diagrams/dependency-diagrams.elm-toolkit-services.mmd --output-dir docs/diagrams
```

`-MarkdownPath`/`--markdown-path` just needs to point at a markdown file in the repo (used to
locate the repo root); when `-SourcePath`/`--source-path` is given, the output `.svg` is named
after the *source* file, so the same `-MarkdownPath` can be reused across several diagrams that
share one doc without their outputs colliding.

Bulk-extract every inline `` ```mermaid `` fenced block from a markdown file and rewrite it to
reference the rendered images:

```powershell
pwsh tools/mermaid/export-mermaid-svg.ps1 -MarkdownPath docs/some-doc.md -OutputDir docs/diagrams -RewriteMarkdown
```

```bash
tools/mermaid/export-mermaid-svg.sh --markdown-path docs/some-doc.md --output-dir docs/diagrams --rewrite-markdown
```

For a doc with more than one diagram this names the extracted files generically
(`some-doc.diagram-01.mmd`, `-02`, ...) — rename them to something meaningful afterward and update
the two links (source + image) each time you rename.

## Layout engine

Diagrams in this repo use Mermaid's ELK layout engine (bundled with `@mermaid-js/mermaid-cli`,
no extra install needed) instead of the default (dagre) — set `'layout': 'elk'` in the
`%%{init: {...}}%%` directive at the top of the `.mmd` file. This matches
[firely-dqm-libraries](https://github.com/FirelyTeam/firely-dqm-libraries)'s diagrams and generally
produces a less cramped auto-layout for diagrams with many nodes/edges (applies to `classDiagram`
as well as `flowchart`/`stateDiagram`).

## Intrinsic sizing

`mmdc` emits the root `<svg>` with `width="100%"` (plus a `max-width` style, which some renderers —
e.g. GitHub's SVG sanitizer — strip). Without an absolute width, a small diagram gets stretched to
fill its container's full width instead of displaying at its natural size, making everything inside
it look oversized (this is most noticeable on a narrow/short diagram like
`dependency-diagrams.packaging-toolkit-services.svg`, embedded on a wide page). Both scripts
post-process every rendered `.svg` to replace `width="100%"` with explicit `width`/`height`
attributes taken from its own `viewBox`, so this is automatic — you don't need to do anything, and
should never hand-edit an `.svg`'s dimensions to work around this.

## Requirements

Node.js (the scripts invoke `npx -y @mermaid-js/mermaid-cli` directly — no local install or
lockfile needed). The Bash script additionally requires `git` (to locate the repo root) and `perl`
(for portable multiline extraction and relative-path computation). A `temp/puppeteer-config.json`
(gitignored, `--no-sandbox`) is created automatically on first run so rendering works headlessly in
sandboxed/CI environments.

**Created in:** [#1399](https://github.com/FirelyTeam/firely-cql-sdk/issues/1399), alongside the
`docs/dependency-diagrams.md` accuracy fixes — adapted from
[firely-dqm-libraries](https://github.com/FirelyTeam/firely-dqm-libraries/blob/main/devops/export-mermaid-svg.ps1).

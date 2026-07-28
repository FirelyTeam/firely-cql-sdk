---
name: generate-svg-from-mermaid
description: Add, edit, or regenerate a Mermaid diagram embedded in a markdown doc, rendering it to a pre-generated .svg instead of a raw fenced code block. Use when a markdown file needs a Mermaid diagram, or when editing an existing .mmd diagram source under docs/diagrams/ or similar.
---

# Generate SVG from Mermaid

GitHub's inline Mermaid renderer does not reliably support every feature used in this repo's
diagrams — `classDiagram` `namespace` blocks, multi-target `style` directives, custom
`<<stereotype>>` annotations, and (for `flowchart`) HTML node labels (`<b>`/`<br/>`/`<div>`, used
for the title+description card style below) can silently fail to render, since GitHub's renderer
runs with a stricter security policy than a local `mermaid-cli` render does. Diagrams are therefore
authored as standalone `.mmd` source files and rendered ahead of time to `.svg` via
[tools/mermaid/export-mermaid-svg.ps1](../../../tools/mermaid/export-mermaid-svg.ps1) /
[.sh](../../../tools/mermaid/export-mermaid-svg.sh), then embedded in the markdown as a normal
image link. Never leave a raw `` ```mermaid `` fenced block as the only way to view a diagram meant
for GitHub.

Use the same layout engine as [firely-dqm-libraries](https://github.com/FirelyTeam/firely-dqm-libraries)'s
diagrams: set `'layout': 'elk'` in the `%%{init: {...}}%%` directive at the top of the `.mmd` file.
`@mermaid-js/mermaid-cli` bundles the ELK layout engine, so no extra install is needed — it applies
to `classDiagram` as well as `flowchart`/`stateDiagram` and generally produces a less cramped
auto-layout than Mermaid's default (dagre) for diagrams with many nodes/edges.

## Diagram type and node style

Dependency-style diagrams (a set of types + their relationships) in this repo use `flowchart TB`
with `subgraph` blocks for grouping — **not** `classDiagram` — so each node can show a title plus
a short description instead of UML's mostly-empty attribute/method compartments. Each node's label
is bold-centered title + left-aligned description paragraph:

```
NodeId["<b>NodeId</b><br/><div style='text-align:left; max-width:280px; overflow-wrap:anywhere;'>One-sentence description of what this type does.</div>"]
```

- `max-width` keeps boxes a readable width instead of growing to fit the whole sentence on one line.
- `overflow-wrap:anywhere` is required — without it, a long unbroken run with no spaces (e.g.
  `using/include/parameter/code/valueset/concept`) overflows the box edge instead of wrapping.
- Escape literal `<`/`>` in the description text itself (e.g. generic syntax like `Interval<T>` →
  `Interval&lt;T&gt;`) — the label is parsed as HTML, so unescaped angle brackets are read as
  (invalid) tags, not text.
- Group nodes with `subgraph Name ... end` (optionally `direction TB` inside), not
  `namespace X { class Y {} }` — that was the `classDiagram` grouping syntax and no longer applies.
- Edges: `A -->|inherits| B` for solid/structural relationships (inherits, implements), `A -.->|injected| B`
  for dashed/dependency relationships (injected, created, configured) — `classDiagram`'s `-->`/`..>`
  arrow syntax doesn't apply to `flowchart`.
- A `style NodeId fill:#AABBCC` override (e.g. marking scoped/highlighted nodes) must stay a
  **light** fill, since node text color is untouched (Mermaid's default dark purple/near-black) —
  this repo uses `fill:#AFEEEE` (light cyan/PaleTurquoise) for that.

## Color scheme

Nodes and `subgraph` boxes are left at Mermaid's default styling — only the connector lines are
darkened, and edge labels ("injected", "created", etc.) have a transparent background instead of
inheriting a fill. Use this exact `%%{init: {...}}%%` block:

```
%%{init: {
    'layout': 'elk',
    'themeVariables':{
      'lineColor': '#333',
      'lineWidth': 4
    },
    'themeCSS': '.edgeLabel, .edgeLabel p, .edgeLabel rect, .labelBkg { background: transparent !important; background-color: transparent !important; fill: transparent !important; }'
}}%%
```

Notes if you need to tweak this further:
- `lineColor` controls the connector lines/arrows only, not node fill/border — don't add
  `mainBkg`/`classText`/`nodeBorder` unless you actually intend to recolor the nodes themselves
  (a past iteration of this recipe did that by mistake; it was reverted — the ask was specifically
  for the lines to be dark, not the nodes).
- Mermaid's `edgeLabelBackground` theme variable does *not* control edge-label backgrounds in the
  ELK-rendered "neo" look Mermaid currently uses, and the actual selector differs by diagram type —
  `classDiagram` renders labels via a plain `<div class="labelBkg">`, while `flowchart` renders them
  via `.edgeLabel`/`.edgeLabel p`/`.edgeLabel rect` with an inline `background-color`. Either way it
  must be overridden via `themeCSS` (with `!important`), not `themeVariables` — and you may need to
  inspect the rendered SVG's `<style>` block (or grep it) to find the real selector rather than
  guessing, since a plausible-looking selector can silently fail to match.
- Always render and visually check (convert to PNG and view it) after any color change.

## File layout

- One `.mmd` per diagram, next to the markdown doc that embeds it, in a sibling `diagrams/`
  subfolder (e.g. `docs/diagrams/` for `docs/*.md`).
- Name it `<markdown-basename>.mmd` when the doc has exactly one diagram, or
  `<markdown-basename>.<diagram-name>.mmd` when the doc embeds several (e.g.
  `dependency-diagrams.elm-toolkit-services.mmd`) — don't rely on the export script's
  auto-numbered `diagram-01`/`diagram-02` fallback names for multi-diagram docs; they're
  meaningless out of context.
- The matching `.svg` lives alongside it with the same base name.
- Both the `.mmd` source and the `.svg` artifact are committed together — never regenerate one
  without the other, and never hand-edit the `.svg`.

## Embedding in markdown

```markdown
Mermaid source: [<name>.mmd](diagrams/<name>.mmd)

![<Alt text>](diagrams/<name>.svg)
```

## Editing an existing diagram

1. Edit the `.mmd` source file directly.
2. Regenerate its `.svg`:
   - PowerShell: `pwsh tools/mermaid/export-mermaid-svg.ps1 -MarkdownPath <doc.md> -SourcePath <diagrams/name.mmd> -OutputDir <diagrams-dir>`
   - Bash: `tools/mermaid/export-mermaid-svg.sh --markdown-path <doc.md> --source-path <diagrams/name.mmd> --output-dir <diagrams-dir>`
   - `-MarkdownPath`/`--markdown-path` only needs to point at *a* markdown file in the repo (used
     to resolve the repo root) — when `-SourcePath`/`--source-path` is given explicitly, the
     output `.svg` is named after the *source* file, not the markdown file, so this is safe to
     reuse across multiple diagrams sharing one doc.
3. Confirm the script reports success and the `.svg` file's mtime/size changed.
4. Diff the rendered `.svg` mentions the classes/edges you expect (open it, or `grep` the SVG
   text for a class/edge name you added) before committing — a syntax mistake in the `.mmd` can
   still render successfully as a near-empty or malformed diagram.

## Adding a brand-new diagram to a doc that has none yet

Write the `.mmd` source directly (don't draft it as an inline fenced block first) at
`docs/diagrams/<markdown-basename>.<diagram-name>.mmd`, run the render command above, then add
the "Mermaid source: [...]" + image link pair to the markdown by hand.

## Migrating an old doc that still has inline `` ```mermaid `` fences

The export scripts also support bulk-extracting every fenced block in one pass and rewriting the
markdown automatically:

```
pwsh tools/mermaid/export-mermaid-svg.ps1 -MarkdownPath <doc.md> -OutputDir <diagrams-dir> -RewriteMarkdown
```

This names the extracted files `<markdown-basename>.diagram-01.mmd`, `-02`, etc. (or just
`<markdown-basename>.mmd` if there was only one block) and rewrites each fenced block in place to
the "Mermaid source: [...] + image" pair. For a doc with more than one diagram, rename the
extracted files to something meaningful afterward (and update the two links each time you rename)
rather than leaving the generic numbered names.

## Prerequisites

Rendering requires Node.js (`npx -y @mermaid-js/mermaid-cli` is invoked directly — no local
install/lockfile needed). The script auto-creates a gitignored `temp/puppeteer-config.json`
(`--no-sandbox`) the first time it runs, so headless rendering works in sandboxed/CI environments
without extra setup.

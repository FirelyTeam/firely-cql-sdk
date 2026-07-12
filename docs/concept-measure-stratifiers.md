# Concept: Stratifier Support in Packager-Generated FHIR Measures

Status: **Proposal / concept** — no implementation yet.

> All CQL, ELM, and FHIR snippets in this document are invented examples. No measure content from
> any external source is reproduced here.

## Goal

The packager (`Hl7.Cql.Packaging`) generates a FHIR R4 `Measure` resource from ELM annotations
(`@measure`, `@year`, `@group`, `@population`, `@productline`). CQL authors have started tagging
stratifier definitions as well, and the Java CQL-to-ELM translator faithfully carries these tags
into the ELM `annotation` element:

```json
{
  "name": "Region Stratifier",
  "annotation": [ {
    "type": "Annotation",
    "t": [
      { "name": "group",      "value": "RateA" },
      { "name": "group",      "value": "RateB" },
      { "name": "stratifier", "value": "Region" }
    ]
  } ],
  "expression": { ... }
}
```

Today these `stratifier` tags are silently ignored. This concept describes how the packager should
map them onto `Measure.group.stratifier`, following the shape expected by the measure content
owners: **all stratifier-tagged definitions of a group collapse into a single stratifier whose
dimensions are `stratifier.component` entries.**

## Current state

Measure generation lives in `Cql/Cql.Packaging/FhirMeasureExtensions.cs`:

- `FhirLibrary.TryCreateMeasure(...)` scans all statement annotations; when a `@measure` and a
  `@year` tag are present, it calls `Measure.CreateMeasureResource(...)`.
- `AnnotateMeasurePopulations(...)` iterates every `ExpressionDef`, takes the cross product of its
  `group` × `population` tags, and for each pair:
  - looks up or creates a `Measure.GroupComponent` with `ElementId = <group>`;
  - adds a `Measure.PopulationComponent` with
    `ElementId = <group>-<population>[-<productline>]`, a coding from
    `http://terminology.hl7.org/CodeSystem/measure-population` (validated against a fixed
    whitelist), and a criteria expression
    `{ language: "text/cql-identifier", expression: <definition name> }`.

There is no handling of `stratifier` tags anywhere in the SDK. MeasureReport evaluation is out of
scope for the SDK, so this concept is packager-only.

## Authoring contract

A stratifier dimension is a public CQL definition tagged with one or more `@group` tags plus a
`@stratifier` tag:

```cql
/*
* @group: RateA
* @group: RateB
* @stratifier: Region
*/
define "Region Stratifier":
    Common."Reported region"(Patient)
```

Semantics:

- The `@stratifier` value is the *component code* of one stratification dimension (e.g. `Region`,
  `AgeBand`). It is free-form: unlike `@population` there is no fixed value set to validate
  against.
- The definition's return value is the *stratum value* for the subject (per the FHIR spec for
  `stratifier.component.criteria`). Typically a `String` — e.g. a case expression returning
  age-band labels like `'18-49'` / `'50-74'` — but Boolean, Code, or any other stratifiable type
  is legal; the packager does not constrain the result type.
- Like populations, the same definition may be attached to multiple groups (cross product of
  `group` × `stratifier` tags).
- An optional `@description` tag on the same definition supplies the component's `description`
  (defaults to the `@stratifier` value).
- No further tag vocabulary is needed: the translator output shown above is sufficient input for
  the full target mapping.

## Target FHIR mapping

Every group that has at least one stratifier-tagged definition gets **exactly one**
`Measure.group.stratifier` entry, acting as the container for all of the group's dimensions. Each
`(group, stratifier)` tag pair contributes one `component`. For a group `RateA` with two tagged
definitions (`Region Stratifier`, `Age Band Stratifier`):

```json
"stratifier": [ {
  "id": "RateA-Stratifier",
  "code": { "text": "RateA-Stratifier" },
  "description": "RateA-Stratifier",
  "component": [
    {
      "id": "RateA-StratifierComponent-Region",
      "code": { "text": "Region" },
      "description": "Region",
      "criteria": { "language": "text/cql-identifier", "expression": "Region Stratifier" }
    },
    {
      "id": "RateA-StratifierComponent-AgeBand",
      "code": { "text": "AgeBand" },
      "description": "AgeBand",
      "criteria": { "language": "text/cql-identifier", "expression": "Age Band Stratifier" }
    }
  ]
} ]
```

Mapping rules:

| Measure element | Source |
|---|---|
| `stratifier.id` | `<group>-Stratifier` — one per group, created lazily on the first stratifier tag |
| `stratifier.code.text` | `<group>-Stratifier` (same as the id) |
| `stratifier.description` | `<group>-Stratifier` (same as the id) |
| `stratifier.criteria` | **never set** — the container stratifier only holds components |
| `component.id` | `<group>-StratifierComponent-<stratifier>` |
| `component.code.text` | the `@stratifier` tag value. No coding is emitted — there is no standard code system for stratifier dimensions. |
| `component.description` | `@description` tag if present, else the `@stratifier` value |
| `component.criteria.language` | `text/cql-identifier` (same as populations) |
| `component.criteria.expression` | the ELM definition name (e.g. `Region Stratifier`) |

Notes:

- This is the FHIR "multi-dimensional stratifier" form: strata in a MeasureReport are the
  *combinations* of component values. The CQF Measures IG constrains a stratifier to either a
  single `criteria` or a set of `component`s, never both; the container stratifier therefore never
  carries its own criteria.
- The component form is used **even when a group has only one stratifier-tagged definition** — a
  one-component stratifier — so output shape does not flip between forms as content evolves.
  (Decided 2026-07: always emit the container-with-components form.)
- Single-criteria stratifiers (`stratifier.criteria` without components) are deliberately not
  emitted. If a real consumer ever needs them, a tag such as `@stratifierForm: criteria` could opt
  out of the container, but nothing in the current content requires this.
- Component order follows ELM statement order. Ordering is not significant and no deterministic
  ordering is imposed. (Decided 2026-07.)

## Implementation sketch

All changes are contained in `FhirMeasureExtensions.cs`:

1. **Extract a group helper.** The lookup-or-create logic for `GroupComponent` (currently inlined
   in `AnnotateMeasurePopulations`, lines 132–151) becomes
   `GetOrCreateGroup(FhirMeasure measure, string groupId)`. This matters because group membership
   can now be established by a stratifier-only definition: ELM statement order is topological, not
   source order, so a stratifier tag may be the first mention of a group. Sharing the helper makes
   population/stratifier processing order-independent.

2. **Add a stratifier container helper.** `GetOrCreateStratifier(GroupComponent group)` returns the
   group's single container stratifier, creating it with the `<group>-Stratifier` id/code/
   description on first use. Because the container is lookup-or-create and components accumulate
   into it, the result is independent of the order in which definitions appear in the ELM.

3. **Add component emission (fold into a single `AnnotateMeasureGroups` pass or keep a separate
   `AnnotateMeasureStratifiers`).** For each `ExpressionDef`, collect `group`, `stratifier`, and
   `description` tags; for each `(group, stratifier)` pair:

   ```csharp
   var stratifiers = annotations.Where(t => t.name == "stratifier").ToArray();
   var description = annotations.FirstOrDefault(t => t.name == "description");

   foreach (var (g, s) in groups.SelectMany(g => stratifiers.Select(s => (g.value, s.value))))
   {
       var group = GetOrCreateGroup(fhirMeasure, g);
       var container = GetOrCreateStratifier(group);
       var id = $"{g}-StratifierComponent-{s}";
       if (container.Component.Any(c => c.ElementId == id))
           throw new InvalidOperationException($"Stratifier component {id} is defined twice for this measure.");
       container.Component.Add(new FhirMeasure.ComponentComponent
       {
           ElementId = id,
           Code = new CodeableConcept { Text = s },
           Description = description?.value ?? s,
           Criteria = new Hl7.Fhir.Model.Expression
           {
               Language = "text/cql-identifier",
               ExpressionElement = new FhirString(def.name)
           }
       });
   }
   ```

4. **Validation.**
   - `@stratifier` with an empty value → throw (matches the spirit of the population whitelist
     check).
   - Duplicate component code within a group → throw (mirrors duplicate-population handling).
   - `@stratifier` present but no `@group` tag → today a `@population` in that situation is
     silently dropped (empty cross product). For stratifiers we should at least log a warning;
     silently dropping an annotated stratifier is the bug this feature is meant to fix. (Optionally
     tighten the population path the same way in a follow-up.)
   - No result-type validation: any CQL type is an acceptable stratum value.

5. **`@productline` interaction.** Populations suffix their id and coding with the product line.
   Stratifier components deliberately do *not*: content that varies by product line models the
   variants as separate *groups*, each carrying its own (identical) component set. If a definition
   carries both `@productline` and `@stratifier`, the product line is ignored for the stratifier
   entries.

## Testing

All test content is synthetic — no external measure content may be added to the repository.

1. **Unit test** (`CoreTests`, alongside `TestLibraryWithDuplicateTagNames`): build a small library,
   inject `Annotation`/`Tag` objects on the defs (the in-repo CQL-to-ELM toolkit does not emit tags
   yet — same workaround already used in `ToolkitTests.cs:97`), run `TryCreateMeasure`, and assert:
   - every group named by a definition's `@group` tags gets exactly one container stratifier with
     the `<group>-Stratifier` id, no `criteria`, and one component per stratifier-tagged
     definition;
   - component `id`, `code.text`, `criteria.expression` follow the patterns above;
   - a group with a single stratifier-tagged definition still produces the container-with-one-
     component form;
   - definitions with multiple `@stratifier` tags produce one component each;
   - duplicate component codes within a group throw;
   - a group first mentioned by a stratifier-only definition is still created and later populated.
2. **Golden-file test**: run the packager over a synthetic test library and compare the generated
   `Measure.group[*].stratifier` subtree against a hand-authored expected JSON.
3. **Demo content**: extend `LibrarySets/Demo/Cql/MeasureExample.cql` with two stratifier
   definitions (e.g. `Age Band Stratifier`, `Region Stratifier`) so the demo pipeline exercises the
   container/component shape end to end.

## Documentation & release

- Extend the measure-annotation section of `docs/cql-packager.md` with the `@stratifier` tag.
- Add an entry to `docs/releases/vnext-release-notes.md`.
- `PublicAPI.Unshipped.txt` is unaffected (all touched members are `internal`/`private`).

## Open questions

1. Should the "annotation without `@group` is silently dropped" behavior become an error for both
   populations and stratifiers? (Behavioral change for existing content — needs a decision from
   content owners.)

## Resolved decisions (2026-07)

- A group with a single stratifier dimension still gets the container-with-one-component form.
- Component ordering is not significant; ELM statement order is used as-is, no deterministic
  ordering is imposed.
- Aligning other Measure elements (group codes/extensions, population code systems, name/title)
  with externally produced reference output is out of scope for this feature.
- No externally supplied measure content (CQL, ELM, or FHIR resources) may be used as example or
  test content; all examples are synthetic.

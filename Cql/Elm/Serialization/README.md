# 1. ELM JSON Serialization Architecture

This document describes how `Library` objects are converted to and from ELM JSON in the Firely CQL SDK.

## 1.1. Table of contents

- [1.2. Overview](#12-overview)
- [1.3. Components](#13-components)
- [1.4. The "type" discriminator](#14-the-type-discriminator)
- [1.5. Reading](#15-reading)
- [1.6. Writing](#16-writing)
- [1.7. Modifiers](#17-modifiers)
- [1.8. Configuration](#18-configuration)
- [1.9. Legacy format support](#19-legacy-format-support)
- [1.10. Debug assertions](#110-debug-assertions)
- [1.11. File structure](#111-file-structure)

## 1.2. Overview

ELM JSON serialization is built on System.Text.Json's native polymorphism (`JsonPolymorphismOptions`) with `"type"`
as the discriminator. The polymorphic hierarchy is declared once, per type, by
[PolymorphicTypeResolver](PolymorphicTypeResolver.cs), from the `[XmlInclude]` attributes of the ELM model.

What makes ELM different from plain polymorphic JSON:

1. **Deep type hierarchies.** `Element` leads to `Expression`, `OperatorExpression` and the specific operators.
2. **Two option sets.** The read options accept the discriminators that older CQL-to-ELM translators wrote on
   concrete types; the write options do not emit them.
3. **Definition wrappers.** The top-level definition arrays are wrapped in `{ "def": [...] }`.
4. **Legacy constructs.** JSON from older translators is corrected before it is deserialized.

## 1.3. Components

```
Library.ParseFromJson / LoadFromJson / SerializeToJson / WriteJson
                          |
                          v
                LibraryJsonSerializer
                          |
        builds two JsonSerializerOptions, once
          |                                  |
   read options                       write options
   (old-style discriminators)         (no old-style discriminators)
          |                                  |
          +--------------+-------------------+
                         |
        +----------------+-----------------+----------------------+
        |                |                 |                      |
 PolymorphicType   TopLevelDefinition  XmlQualifiedName    JsonStringEnum
 Resolver          ConverterFactory    Converter           Converter
 (+ modifiers)     -> PolymorphicArray
                      JsonConverter<T>
```

### 1.3.1. LibraryJsonSerializer

[LibraryJsonSerializer](LibraryJsonSerializer.cs) is the internal coordinator.

- It builds the two option sets once, in static fields, with `BuildSerializerOptions`. A call to serialize copies
  the write options to set `WriteIndented`; nothing is rebuilt per node.
- `DeserializeFromJsonNode` runs `CorrectLegacyConstructs` on the parsed `JsonNode`, deserializes a `LibraryContainer`
  (the `{ "library": ... }` wrapper) with the read options, and validates the library when asked to.
- `SerializeToJson` and `SerializeToStream` serialize a `LibraryContainer` with the write options.
- `ReformatUtf8Json` re-indents already serialized JSON without going through the object model.

### 1.3.2. PolymorphicTypeResolver

[PolymorphicTypeResolver](PolymorphicTypeResolver.cs) is a `DefaultJsonTypeInfoResolver`. For every type whose
`JsonTypeInfo` is an object (types with a custom converter, collections and primitives are left alone) it collects
the derived types and, when there are any, sets `PolymorphismOptions` with:

- `TypeDiscriminatorPropertyName = "type"`;
- `IgnoreUnrecognizedTypeDiscriminators = false`, so an unknown discriminator is an error;
- `UnknownDerivedTypeHandling = FailSerialization`, so writing an instance of a type that is not a registered
  derived type throws (see [1.6. Writing](#16-writing)).

The derived types are the non-abstract types reachable, recursively, through the `[XmlInclude]` attributes of the
type, each with its type name as discriminator value.

An abstract type gets a `CreateObject` that throws a `JsonException`, so that an abstract type without a
discriminator is reported as that and not as a `NotSupportedException`.

### 1.3.3. PolymorphicArrayJsonConverter and TopLevelDefinitionConverterFactory

[PolymorphicArrayJsonConverter](PolymorphicArrayJsonConverter.cs)`<T>` reads and writes the definition wrapper
around an array:

```json
{
  "def": [
    { "type": "ExpressionDef", "...": "..." },
    { "type": "FunctionDef", "...": "..." }
  ]
}
```

- Reading expects an object whose only property is `def`, an array. When constructed with
  `allowOldStyleDefinitionTypeDiscriminators`, it first skips a `"type"` property whose value starts with
  `Library$` (the old `Library$Statements` style). Each element is deserialized through the serializer, so the
  element type's polymorphism applies.
- Writing emits `{ "def": [ ... ] }` and serializes each element through the serializer.

[TopLevelDefinitionConverterFactory](TopLevelDefinitionConverterFactory.cs) creates that converter for `UsingDef[]`,
`IncludeDef[]`, `ParameterDef[]`, `CodeSystemDef[]`, `ValueSetDef[]`, `CodeDef[]`, `ConceptDef[]`, `ContextDef[]` and
`ExpressionDef[]`, passing on its `allowOldStyleTypeDiscriminators` flag.

### 1.3.4. XmlQualifiedNameConverter

[XmlQualifiedNameConverter](XmlQualifiedNameConverter.cs) reads an `XmlQualifiedName` from a string and writes its
`Name` as a string.

## 1.4. The "type" discriminator

ELM JSON names the concrete type of an element in a `"type"` property:

```json
{
  "type": "Add",
  "operand": [
    { "type": "Literal", "valueType": "{urn:hl7-org:elm-types:r1}Integer", "value": "1" },
    { "type": "Literal", "valueType": "{urn:hl7-org:elm-types:r1}Integer", "value": "2" }
  ]
}
```

.NET 10 rejects a polymorphic type that has a JSON property named like the discriminator. The ELM model has none:
the generated model properties named `type` (`ChoiceTypeSpecifier.type` and `TupleElementDefinition.type`) carry
`[JsonIgnore]`, added by the XSD-to-C# generator for every property named `type` with a complex type, so they stay
available to XML serialization only. Consequently `"type"` always means the discriminator when it is a string.

### 1.4.1. Abstract and concrete declared types

- A property whose declared type is abstract, such as `Expression`, needs a discriminator. On reading, a missing
  discriminator gives a `JsonException` ("Cannot deserialize abstract type ... without a 'type' discriminator
  property"), as does a `"type"` that names an abstract class.
- A property whose declared type is concrete, such as `IncludeDef`, needs none when the runtime type is the declared
  type. Newer ELM leaves it out; older ELM writes it.

### 1.4.2. Read and write options differ

Whether a concrete type is registered as its own derived type is the one difference, set by the
`emitConcreteBaseTypeDiscriminator` argument of `PolymorphicTypeResolver`:

| | Read options | Write options |
|---|---|---|
| `allowOldStyleTypeDiscriminators` / `emitConcreteBaseTypeDiscriminator` | `true` | `false` |
| Concrete ELM type registered as its own derived type | Yes | No |
| `"type"` on a concrete type | Accepted, and must name that type | Not written |
| `CorrectLegacyConstructs` | Yes | No |

With the read options, every concrete ELM type (a non-abstract type that has an `[XmlInclude]` or an `[XmlType]`
attribute) is also registered as a derived type of itself, under its own name. An old-style `"type": "IncludeDef"`
on an `IncludeDef` is therefore accepted, and any other value there is a `JsonException` that includes the JSON
path. The write options leave this out, so concrete types are not polymorphic and no discriminator is emitted for
them.

### 1.4.3. Writing an instance outside the ELM model

Writing a subclass that is not part of the ELM model throws `NotSupportedException`
(`JsonUnknownDerivedTypeHandling.FailSerialization`), because the `"type"` it would need cannot be read back. The
CQL-to-ELM translator has internal subclasses, `ReferencedLibrary` (an `IncludeDef`) and `IncludeRef` (an
`Expression`); an included library used as a value is reported as an error reference instead of an `IncludeRef`, so
the ELM it returns can be serialized.

## 1.5. Reading

```
Library.LoadFromJson(file) / ParseFromJson(json)
         |
         v
JsonNode.Parse(...)                           (MaxDepth 4096)
         |
         v
LibraryJsonSerializer.DeserializeFromJsonNode(node, validate, filePath)
         |
         +-> CorrectLegacyConstructs(node)
         |
         +-> node.Deserialize<LibraryContainer>(read options)
         |     |
         |     +-> for each polymorphic object: System.Text.Json reads the "type" discriminator
         |     |   and creates the registered derived type
         |     +-> for each definition array: PolymorphicArrayJsonConverter<T>
         |
         +-> library.Validate()  (if validate)
         v
Library
```

- **Discriminator first.** System.Text.Json's native polymorphism finds the discriminator when it is the first
  property of the object. `CorrectLegacyConstructs` therefore moves `"type"` to the first position of every object.
- **Unknown discriminator, unknown property.** Both are errors (`IgnoreUnrecognizedTypeDiscriminators = false`,
  `UnmappedMemberHandling = Disallow`).
- **Error messages** for malformed ELM are System.Text.Json's, and include the JSON path.
- **Depth.** `MaxDepth` is 4096 for the options and for the `JsonDocument`. Reading recurses once per nesting level,
  so what a thread can read depends on its stack: roughly 800 levels of nested expressions on a 1 MB stack, and the
  full 4,000 or so on 8 MB. Nesting beyond what the stack allows throws a `JsonException` (see
  `GuardNestingDepth` in [1.7. Modifiers](#17-modifiers)); it does not crash the process.
- **Root options.** The `JsonNode` root is parsed with explicit `JsonNodeOptions`, which stops a lookup on a deeply
  nested node from walking the whole parent chain.
- **Tuple elements.** The `"type"` of a `TupleElementDefinition` in a `TupleTypeSpecifier` is validated like any
  other discriminator, so a wrong name now fails where it used to be ignored.

## 1.6. Writing

```
Library.SerializeToJson(writeIndented) / WriteJson(...)
         |
         v
LibraryJsonSerializer.SerializeToJson / SerializeToStream
         |
         +-> new LibraryContainer(library)             ({ "library": ... })
         +-> JsonSerializer.Serialize(container, write options + WriteIndented)
               |
               +-> a property whose runtime type differs from its declared type, or whose declared type is
               |   abstract, gets its "type" discriminator from System.Text.Json
               +-> properties are filtered by the modifiers (see 1.7)
               +-> definition arrays: PolymorphicArrayJsonConverter<T> writes { "def": [ ... ] }
```

A runtime type that is not a registered derived type throws, as described in
[1.4.3. Writing an instance outside the ELM model](#143-writing-an-instance-outside-the-elm-model).

## 1.7. Modifiers

`LibraryJsonSerializer.BuildSerializerOptions` adds these modifiers to `PolymorphicTypeResolver`, in this order:

1. `ModifyNarrative`: `Narrative.Text` is named `value` in JSON.
2. `DoNotSerializeDefaultValues`: a property is skipped when it is null or equals its default, taken from
   `[DefaultValue]` or the type's default. Enums are always written, and so is every property of `Interval`.
3. `HandleSpecifiedProperties`: for a property `x` with a companion `xSpecified`, `x` is written only when
   `xSpecified` is true, reading sets `xSpecified` to true, and `xSpecified` is never written itself.
4. `RespectXmlIgnoreAttribute`: a property with `[XmlIgnore]` is not written.
5. `GuardNestingDepth`: an `OnDeserializing` and `OnSerializing` hook on every object type checks
   `RuntimeHelpers.TryEnsureSufficientExecutionStack` and throws a `JsonException` when the stack is nearly used up.
   `CorrectLegacyConstructs` makes the same check on each node.

## 1.8. Configuration

```csharp
var options = new JsonSerializerOptions
{
    MaxDepth = 4096,
    UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow,
};

options.Converters.Add(new TopLevelDefinitionConverterFactory(allowOldStyle));
options.Converters.Add(new XmlQualifiedNameConverter());
options.Converters.Add(new JsonStringEnumConverter());

options.TypeInfoResolver = new PolymorphicTypeResolver(allowOldStyle)
    .WithAddedModifier(ModifyNarrative)
    .WithAddedModifier(DoNotSerializeDefaultValues)
    .WithAddedModifier(HandleSpecifiedProperties)
    .WithAddedModifier(RespectXmlIgnoreAttribute)
    .WithAddedModifier(GuardNestingDepth);
```

`allowOldStyle` is `false` for the write options and `true` for the read options (see the table in
[1.4.2. Read and write options differ](#142-read-and-write-options-differ)).

## 1.9. Legacy format support

`CorrectLegacyConstructs` runs on the parsed `JsonNode` before it is deserialized, on every object and array
recursively. It:

- moves `"type"` to the first position of an object;
- throws a `JsonException` naming the path when `"type"` is null;
- removes a `"type"` whose value is an object, as that information is also available in `resultTypeSpecifier` or
  `resultTypeName`;
- renames a `"type"` whose value is an array (the old `ChoiceTypeSpecifier` form) to `"choice"`, or removes it when a
  `"choice"` exists already;
- removes empty objects and arrays.

Old-style type annotations on definition wrappers (`"type": "Library$Statements"`) are skipped by
[PolymorphicArrayJsonConverter](PolymorphicArrayJsonConverter.cs) when reading. Old-style discriminators on concrete
types are accepted through the read options (see [1.4.2](#142-read-and-write-options-differ)).

## 1.10. Debug assertions

`LibraryJsonSerializer.EnableDebugAssertions` (default `true`) makes `HandleSpecifiedProperties` call `Debug.Fail`
when a property has a non-default value but its `xxxSpecified` flag is false. The CQL toolkit turns it off to avoid
interrupting bulk processing.

## 1.11. File structure

```
Cql/Elm/Serialization/
├─ README.md                              # This document
├─ LibraryJsonSerializer.cs               # Option sets, legacy corrections, modifiers
├─ PolymorphicTypeResolver.cs             # Native polymorphism from [XmlInclude]
├─ PolymorphicArrayJsonConverter.cs       # { "def": [...] } wrapper
├─ TopLevelDefinitionConverterFactory.cs  # Creates the array converter
└─ XmlQualifiedNameConverter.cs           # XmlQualifiedName

Cql/Elm/
├─ Library.Serialization.cs               # Public API on Library
└─ ...
```

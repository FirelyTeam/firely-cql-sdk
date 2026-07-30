This page is part of the Using CQL with FHIR Implementation Guide (v2.0.0: STU 2) based on FHIR (HL7® FHIR® Standard) R4 . This is the current published version. For a full list of available versions, see the Directory of published versions

## Conformance
*Page standards status: *Trial-use


- Library Resources
 - Library Name and URL
 - FHIR Type Mapping
 - Parameters and Data Requirements
 - RelatedArtifacts
 - CQL Version
- Using Expressions
 - In-line CQL Expressions
- Must Support

This topic specifies conformance requirements for systems that support authoring, publishing, distribution, and implementation of FHIR Knowledge Artifacts that make use of Clinical Quality Language (CQL).

### Library Resources


In addition to the use of CQL directly in expression-valued elements , CQL content used within knowledge artifacts can be included through the use of a Library resource. These libraries can then be referenced from FHIR resources such as PlanDefinition and Measure using the `library`element (as well as the `cqf-library`extension for resources that do not declare a `library`element). The content of the CQL library is included using the `content`element of the Library.

**Conformance Requirement 4.1 (Library Resources): **
- Content conforming to this implementation guide **SHALL **use FHIR Library resources to represent CQL libraries in FHIR.
- For distribution to environments that support CQL compilation directly, FHIR Library resources **SHOULD **include CQL content.
- FHIR Library resources that include CQL content **SHALL **conform to the CQLLibrary profile.
>

For distribution to environments that support ELM execution directly, FHIR Library resources **MAY **include ELM content in XML or JSON format. See the Using ELM topic for conformance requirements related to the use of ELM for distribution and implementation of CQL logic.

#### Library Name and URL


**Conformance Requirement 4.2 (Library Name and URL): **
- The identifying elements of a library **SHALL **conform to the following requirements:
 - Library.url **SHALL **be `<CQL namespace url>/Library/<CQL library name>`
 - Library.name **SHALL **be `<CQL library name>`, **SHALL **be 64 characters or less, and **SHOULD **be 30 characters or less
 - Library.version **SHALL **be `<CQL library version>`
- For libraries included in FHIR implementation guides, the CQL namespace is defined by the implementation guide as follows:
 - CQL namespace name **SHALL **be IG.packageId
 - CQL namespace url **SHALL **be IG.canonicalBase
- CQL library source files **SHOULD **be named `<CQLLibraryName>-<version>.cql`.
- To avoid issues with characters between web ids and names, library names **SHALL NOT **have underscores.

The prohibition against underscores in CQL library names is required to ensure compliance with the canonical URL pattern (because URLs by convention should not use underscores). In addition, many publishing environments will use the canonical tail (i.e. the name of the library) as the logical id of the Library resource, which does not allow underscores per the FHIR specification.

#### FHIR Type Mapping


**Conformance Requirement 4.3 (FHIR Type Mapping): **
- CQL defined types **SHALL **map to types in FHIR according to the following mapping: CQL System Type FHIR Type `System.Boolean``FHIR.boolean``System.Integer``FHIR.integer``System.Decimal``FHIR.decimal`, with the use of the `quantity-precision`extension to communicate precision of the value `System.Date``FHIR.date``System.DateTime``FHIR.dateTime`, with the exception that if hours are provided, minutes and seconds must be provided; use the `time-precision`extension to indicate precision of partial time values `System.Long``FHIR.string`in R4, `FHIR.integer64`in R5 and above `System.Time``FHIR.time`, with the exception that minutes and seconds must be provided; use the `time-precision`extension to indicate precision of partial time values `System.String``FHIR.string``System.Quantity``FHIR.Quantity``System.Ratio``FHIR.Ratio``System.Any``FHIR.Any``System.Code``FHIR.Coding``System.Concept``FHIR.CodeableConcept``Interval<System.Date>``FHIR.Period``Interval<System.DateTime>``FHIR.Period``Interval<System.Quantity>``FHIR.Range`
-

List types **SHALL **have elements of types that can be mapped to FHIR according to this mapping.
-

Tuple types **SHALL **have elements of types that can be mapped to FHIR according to this mapping.

For example, the following CQL expression results in a `List<FHIR.Observation>`:
```
define "FHIRObservationListExample":
 [Observation]

```


In the Library resource, this is represented as a `parameter`:
```
{
 "extension": [{
 "url": "http://hl7.org/fhir/StructureDefinition/cqf-cqlType",
 "valueString": "List<FHIR.Observation>"
 }],
 "name": "FHIRObservationListExample",
 "use": "out",
 "min": 0,
 "max": "*",
 "type": "Observation"
 }

```


Note the parameter is multi-cardinality to indicate this is a list-valued expression. Also note the use of the `cqf-cqlType`extension to relay the CQL type.

When invoked through an operation (such as `$cql`or `Library/$evaluate`), this would be represented as multiple entries in the resulting Parameters resource:
```
{
 "name": "FHIRObservationListExample",
 "resource": {
 "resourceType": "Observation",
 "id": "blood-glucose",
 "status": "final",
 ...
 }
}, {
 "name": "FHIRObservationListExample",
 "resource": {
 "resourceType": "Observation",
 "id": "blood-pressure",
 "status": "final",
 ...
 }
}, {
 "name": "FHIRObservationListExample",
 "resource": {
 "resourceType": "Observation",
 "id": "bmi",
 "status": "final",
 ...
 }
}

```


Note that for an empty list, the `cqf-isEmptyList`extension is used:
```
{
 "extension": [{
 "url": "http://hl7.org/fhir/StructureDefinition/cqf-cqlType",
 "valueString": "List<FHIR.Observation>"
 }],
 "name": "FHIRObservationEmptyListExample",
 "_valueBoolean": {
 "extension": [{
 "url": "http://hl7.org/fhir/StructureDefinition/cqf-isEmptyList",
 "valueBoolean": true
 }]
 }
}

```


Note that the extension is provided on the `value`element, and an arbitrary choice of `boolean`is selected; there is no value to provide, the result is an empty list, so this is just a way to provide the cqf-isEmptyList extension (because parameters in a FHIR Parameters resource must have a value element).

For the special case of nested lists, where a parameter name is not available, the name `element`**SHALL **be used. For example:
```
define CQLListListExample:
 { { 1, 2, 3 }, { 4, 5, 6 } }

```


The result of this expression is represented in the resulting Parameters resource as:
```
 {
 "extension": [{
 "url": "http://hl7.org/fhir/StructureDefinition/cqf-cqlType",
 "valueString": "List<List<System.Integer>>"
 }],
 "name": "CQLListListExample",
 "part": [{
 "name": "element",
 "valueInteger": 1
 }, {
 "name": "element",
 "valueInteger": 2
 }, {
 "name": "element",
 "valueInteger": 3
 }]
 }, {
 "extension": [{
 "url": "http://hl7.org/fhir/StructureDefinition/cqf-cqlType",
 "valueString": "List<List<System.Integer>>"
 }],
 "name": "CQLListListExample",
 "part": [{
 "name": "element",
 "valueInteger": 4
 }, {
 "name": "element",
 "valueInteger": 5
 }, {
 "name": "element",
 "valueInteger": 6
 }]
 }

```


For an empty tuple, the `cqf-isEmptyTuple`extension is used:
```
{
 "extension": [{
 "url": "http://hl7.org/fhir/StructureDefinition/cqf-cqlType",
 "valueString": "Tuple{}"
 }],
 "name": "CQLEmptyTupleExample",
 "_valueBoolean": {
 "extension": [{
 "url": "http://hl7.org/fhir/StructureDefinition/cqf-isEmptyTuple",
 "valueBoolean": true
 }]
 }
}

```


As with empty lists, the extension is provided on the `value`element, and an arbitrary choice of `boolean`is selected; there is no value to provide, the result is an empty tuple, so this is just a way to provide the cqf-isEmptyTuple extension (because parameters in a FHIR Parameters resource must have a value element).

For expressions that result in a BackboneElement, the value is represented in the same way that a Tuple is represented:
```
{
 "name": "FHIRBackboneElementExample",
 "part": [{
 "name": "relationship",
 "valueCodeableConcept": {
 "coding": [{
 "system": "http://terminology.hl7.org/CodeSystem/v2-0131",
 "code": "N"
 }]
 }
 }, {
 "name": "name",
 "valueHumanName": {
 "family": "du Marché",
 "_family": {
 "extension": [
 {
 "url": "http://hl7.org/fhir/StructureDefinition/humanname-own-prefix",
 "valueString": "VV"
 }
 ]
 },
 "given": [
 "Bénédicte"
 ]
 }
 },
 ...
 ]
 }

```


For expressions that result in Extension values, the elements of the extension are mapped using parts, `url`and `value`for simple extensions:
```
{
 "name": "FHIRSimpleExtensionExample",
 "part": [{
 "name": "url",
 "valueUri": "http://hl7.org/fhir/StructureDefinition/patient-birthTime"
 }, {
 "name": "value",
 "valueDateTime": "1974-12-25T14:35:45-05:00"
 }]
}

```


Parts `url`and `extension`for complex extensions:
```
{
 "name": "FHIRComplexExtensionExample",
 "part": [{
 "name": "url",
 "valueUri": "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity"
 }, {
 "name": "extension",
 "part": [{
 "name": "url",
 "valueUri": "ombCategory"
 }, {
 "name": "value",
 "valueCoding": {
 "system" : "urn:oid:2.16.840.1.113883.6.238",
 "code" : "2135-2",
 "display" : "Hispanic or Latino"
 }
 }]
 },
 ...
 {
 "name": "extension",
 "part": [{
 "name": "url",
 "valueUri": "text"
 }, {
 "name": "value",
 "valueString": "Hispanic or Latino"
 }]
 }]
}

```


For a complete example illustrating all possible type mappings, refer to the Type Mapping Example and Type Mapping Evaluation Result Example

#### Parameters and Data Requirements


**Conformance Requirement 4.4 (Parameters and Data Requirements): **
- Parameters to CQL libraries **SHALL **be either
 - CQL-defined types that map to FHIR types (as defined in 4.3 ), or
 - FHIR resource types, optionally with profile designations, or
 - One of the types specified in Open Types (*) , or
 - A BackboneElement, in which case the elements of the BackboneElement are represented as parts, or
 - An Extension, in which case the elements of the Extension are represented as parts.
- Top level expressions in CQL libraries, regardless of access level, **SHALL **return either
 - CQL-defined types that map to FHIR types (as defined in 4.3 ), or
 - FHIR resource types, optionally with profile designations, or
 - One of the types specified in Open Types (*) , or
 - A BackboneElement, in which case the elements of the value are represented as parts, or
 - An Extension, in which case the elements of the Extension are represented as parts.
- Tuple types are represented in FHIR as a `parameter`that has parts corresponding to the elements of the tuple type. List types are represented in FHIR as a `parameter`that has a cardinality of `0..*`.
- Libraries used in computable artifacts **SHALL **use the `parameter`element to identify input parameters as well as the type of all top-level expressions as output parameters.
- Libraries used in computable artifacts **SHALL **use the `dataRequirement`element to identify any retrieves present in the CQL, according to the following mapping: Retrieve Element DataRequirement Element dataType type templateId profile context subject codeProperty codeFilter.path or codeFilter.searchParam codes (Concept) codeFilter.code (for each Code present in the Concept) codes (Code) codeFilter.code codes (ValueSetRef) codeFilter.valueSet (as specified by the `id`of the ValueSetDef referenced by the ValueSetRef) dateProperty dateFilter.path dateLowProperty,dateHighProperty dateFilter.path (resolved to an interval-valued property) dateRange dateFilter.path or dateFilter.searchParam

For example, given the following CQL:
```
define Conditions: [Condition]

```


The corresponding data requirement is:
```
{
 "type": "Condition",
 "profile": [ "http://hl7.org/fhir/StructureDefinition/Condition" ]
}

```


When the retrieve includes a terminology filter, the `codeFilter`element is used to communicate the filter:
```
valueset "Inpatient Encounters": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292'
...
define Encounters: [Encounter: "Inpatient Encounters"]

```

```
{
 "type": "Encounter",
 "codeFilter": [ {
 "path": "type",
 "valueSet": "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292"
 } ]
}

```


The `cqf-isSelective`extension **MAY **be used to identify *selective *data requirements (i.e. data requirements that are likely to be the most selective of the data of interest for the artifact:
```
{
 "extension": [ {
 "url": "http://hl7.org/fhir/StructureDefinition/cqf-isSelective",
 "valueBoolean": true
 } ],
 "type": "Encounter",
 "codeFilter": [ {
 "path": "type",
 "valueSet": "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292"
 } ]
}

```


Although this extension may be used by artifact authors as a way to indicate expected selectivity of a data requirement, it will more typically be used by implementers and downstream packaging repositories to indicate selectivity of a data requirement given known data heuristics in particular datasets.

The `cqf-fhirQueryPattern`extension **MAY **be used to recommend a FHIR RESTful query that can be used to satisfy the data requirement:
```
{
 "extension": [ {
 "url": "http://hl7.org/fhir/StructureDefinition/cqf-fhirQueryPattern",
 "valueString": "Encounter?subject=Patient/&type:in=http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292"
 } ],
 "type": "Encounter",
 "profile": [ "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter" ],
 "codeFilter": [ {
 "path": "type",
 "valueSet": "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292"
 } ]
}

```


Systems that can infer more selective requirements from additional restrictions applied in the CQL after the retrieve **MAY **include those requirements to provide more selective data requirements. For example:
```
define "Completed Inpatient Encounters":
 [Encounter: "Inpatient Encounters"] E
 where E.status = 'finished'

```


The `status`restriction is represented using the `cqf-valueFilter`extension:
```
{
 "extension": [ {
 "extension" : [
 {
 "url" : "path",
 "valueString" : "status"
 },
 {
 "url" : "comparator",
 "valueCode" : "eq"
 },
 {
 "url" : "value",
 "valueString" : "finished"
 }
 ],
 "url" : "http://hl7.org/fhir/StructureDefinition/cqf-valueFilter"
 } ],
 "type": "Encounter",
 "codeFilter": [ {
 "path": "type",
 "valueSet": "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292"
 } ]
}

```


Elements that are referred to in the CQL **MAY **be communicated using the `mustSupport`element:
```
define "Inpatient Encounters During Measurement Period":
 [Encounter: "Inpatient Encounters"] E
 where E.period during "Measurement Period"

```

```
{
 "type": "Encounter",
 "mustSupport": [ "period" ],
 "codeFilter": [ {
 "path": "type",
 "valueSet": "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292"
 } ]
}

```


When using profile-informed authoring, the retrieve will have a `templateId`corresponding to the profile:
```
{
 "type": "Encounter",
 "profile": [ "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter" ],
 "codeFilter": [ {
 "path": "type",
 "valueSet": "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292"
 } ]
}

```


When referencing extensions that are surfaced as elements in profile-informed authoring, the `mustSupport`uses the `.extension()`function in FHIRPath, and the `rendered-value`extension is used to provide a human-readable rendering, corresponding to the `sliceName`of the extension:
```
using QICore
...
define SDEEthnicity: Patient.ethnicity

```

```
{
 "type": "Patient",
 "profile": [ "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient" ],
 "mustSupport": [ "extension('http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity')" ],
 "_mustSupport": [
 {
 "extension": [{
 "url": "http://hl7.org/fhir/StructureDefinition/rendered-value",
 "valueString": "ethnicity"
 }]
 }
 ]
}

```

>

In the case that dynamic CQL construction is required, implementers should take care to sanitize inputs from any parameters used in the construction of dynamic CQL to avoid injection attacks .

##### Parameter Constraints


In some cases, it is useful to describe constraints on the allowed values for parameters in CQL libraries. CQL currently does not support stating these requirements beyond the type and optional default for the parameter. Parameter constraints are being considered in a future version of CQL, but in anticipation of that feature being available, this guide provides a mechanism for declaring a parameter constraint in the CQLLibrary profile by allowing the targetConstraint extension to be used. For example, given a CQL library with the following parameter declaration:
```
// NOTE: The measurement period provided must describe a full calendar year to meet measure intent
parameter "Measurement Period" Interval<DateTime>

```


In this case, to indicate to consuming systems the requirement that the measurement period must be a full calendar year, the following extension can be used on the parameter definition in the Library:
```
 "parameter": [
 {
 "extension" : [
 {
 "url": "http://hl7.org/fhir/StructureDefinition/targetConstraint",
 "extension": [
 {
 "url" : "key",
 "valueString": "mp-valid"
 },
 {
 "url" : "severity",
 "code" : "error"
 },
 {
 "url" : "expression",
 "valueExpression" : {
 "language" : "text/cql-expression",
 "expression" : "duration in years of \"Measurement Period\" = 1"
 }
 },
 {
 "url" : "human",
 "valueString" : "The measurement period must be a full calendar year in order to meet measure intent"
 }
 ]
 }
 ],
 "name" : "Measurement Period",
 "use" : "in",
 "min" : 0,
 "max" : "1",
 "type" : "Period"
 }
 ]

```


As another example, consider a co-occurrence constraint on parameters:
```
// A value for X must be supplied if NeedsX is true
parameter NeedsX Boolean
parameter X Integer

```


And the associated targetConstraint:
```
 "parameter": [
 {
 "name" : "NeedsX",
 "use" : "in",
 "min" : 0,
 "max" : "1",
 "type" : "boolean"
 },
 {
 "extension" : [
 {
 "url": "http://hl7.org/fhir/StructureDefinition/targetConstraint",
 "extension": [
 {
 "url" : "key",
 "valueString": "x-valid"
 },
 {
 "url" : "severity",
 "code" : "error"
 },
 {
 "url" : "expression",
 "valueExpression" : {
 "language" : "text/cql-expression",
 "expression" : "NeedsX implies X is not null"
 }
 },
 {
 "url" : "human",
 "valueString" : "A value for X must be supplied if NeedsX is true"
 }
 ]
 }
 ],
 "name" : "X",
 "use" : "in",
 "min" : 0,
 "max" : "1",
 "type" : "Integer"
 }
 ]

```

>

NOTE: This capability can be provided in the declaring CQL library using the Error function to provide run-time enforcement as illustrated in the snippet below. The use of the `targetConstraint`extension as described here allows this information to be communicated structurally, allowing consumers of the library to understand the constraints. For example to provide a user-interface that guides user to providing correct values for the parameters, rather than waiting for the run-time error to occur.
```
library ParameterConstraintsExample

using FHIR version '4.0.1'

parameter "Measurement Period" Interval<DateTime>
parameter NeedsX Boolean
parameter X Integer

context Patient

define private function ValidateMeasurementPeriod()
 Message(true, duration in years of "Measurement Period" = 1, 'mp-valid', 'Error', 'Measurement Period must describe a full calendar year to meet measure intent')

define private function ValidateX()
 Message(true, NeedsX implies X is not null, 'x-valid', 'Error', 'A value for X must be supplied if NeedsX is true')

define "Initial Population":
 ValidateMeasurementPeriod()
 and ValidateX()
 and ...

```


#### RelatedArtifacts


**Conformance Requirement 4.5 (Related Artifacts): **
- Libraries used in computable artifacts **SHALL **use the `relatedArtifact`element to identify includes, code systems, value sets, and data models used by the CQL library: Dependency RelatedArtifact representation Data Model (using declaration) `depends-on`with `url`of the ModelInfo Library (e.g. `http://hl7.org/fhir/Library/FHIR-ModelInfo|4.0.1`) Library (include declaration) `depends-on`with `url`of the Library (e.g. `http://hl7.org/fhir/Library/FHIRHelpers|4.0.1`) Code System `depends-on`with `url`of the CodeSystem (e.g. `http://loing.org`) Value Set `depends-on`with `url`of the ValueSet (e.g. `http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.89`)

#### CQL Version


**Conformance Requirement 4.6 (Specifying CQL Version): **
- The version of CQL/ELM used for content in a library **SHOULD **be specified using the version parameter of the text/cql and application/elm+xml, application/elm+json media types.
 - Note that this is **SHOULD **, rather than a **SHALL **to support existing systems that do not communicate version in this way, as well as to allow for forward-compatible representation with future versions of the CQL specification.
- If specified, the value of the version parameter **SHALL **correspond to the *major *and *minor *version of a published release of the CQL specification (https://cql.hl7.org/history.html).
- Resource narratives for Libraries and knowledge artifacts that use CQL **SHALL **include the CQL/ELM version if it is specified in the media type.

For example, the following media types indicate version 1.5 of the CQL specification.
- `text/cql; version=1.5`
- `application/elm+xml; version=1.5`
- `application/elm+json; version=1.5`

### Using Expressions


CQL can be used in expression-valued elements in the following ways:
- To specify an unqualified expression name in the "primary" library for an artifact
- To specify a qualified expression name in a library referenced by an artifact
- To directly specify an inline expression

To distinguish these use cases, the `language`element of the expression value is used as specified in the Using Expressions topic of the FHIR specification.

The "primary library" for an artifact is determined as follows:
- If the resource type has a `library`element (e.g. PlanDefinition.library), and there is one and only one library specified, that is the primary library
- If the resource has one and only one `cqf-library`extension, that is the primary library

If there is more than one library specified in the resource, then expression identifiers must be qualified with the name of the library (see Conformance Requirement 2.3 (Nested Libraries) ), or with the library alias as specified by the `cqf-libraryAlias`extension.

When CQL expressions are identified (i.e. using an Expression element with a language type of `text/cql-identifier`), if the expression element has a `reference`, the identifier **SHALL **be to an expression in the referenced library.

#### In-line CQL Expressions


When CQL expressions are included in-line (i.e. with a language specifier of `text/cql-expression`), then that expression **SHALL **have access to any libraries referenced by the resource (with either a `library`element or the `cqf-library`extension). This means that in-line expressions may reference declarations in those libraries by using the name of the library as a qualifier (or the `alias`as defined by the `cqf-libraryAlias`extension).

For example, given a PlanDefinition with a library element referencing the Example library in this implementation guide, the following CQL in-line expression is valid:
```
exists (Example."Flexible Sigmoidoscopy Performed")

```


### Must Support


Certain elements in the profiles defined in this implementation guide are marked as Must Support. This flag is used to indicate that the element plays a critical role in defining, sharing, and implementing artifacts, and implementations **SHALL **understand and process the element.

In addition, because artifact specifications typically make use of data implementation guides (e.g. International Patient Summary (IPS), US Core, QI-Core), the implications of the Must Support flag for profiles used from those implementation guides must be considered.

For more information, see the definition of Must Support in the base FHIR specification.

**Conformance Requirement 4.7 (Must Support Elements): **

For resource instances claiming to conform to profiles from this IG, Must Support on any profile data element **SHALL **be interpreted as follows:
- Authoring systems and knowledge repositories **SHALL **be capable of populating all Must Support data elements.
- Evaluating systems **SHALL **be capable of processing resource instances containing Must Support data elements without generating an error or causing the evaluation to fail.
- In situations where information on a particular data element is not present and the reason for absence is unknown, authoring and repository systems **SHALL NOT **include the data elements in the resource instance. For example, for systems using ‘9999’ to indicate unknown data values, do not include ‘9999’ in the resource instance.
- When consuming resource instances, evaluating systems **SHALL **interpret missing data elements within resource instances as data not present for the artifact.
- Submitting and receiving systems using knowledge artifacts to perform data exchange or artifact evaluation operations **SHALL **respect the must support requirements of the profiles used by the artifact to describe the data involved in the operation.
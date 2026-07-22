Quality Measure Implementation Guide, published by HL7 International / Clinical Quality Information. This guide is not an authorized publication; it is the continuous build for version 5.0.0 built by the FHIR (HL7® FHIR® Standard) CI Build. This version is based on the current content of https://github.com/HL7/cqf-measures/ and changes regularly. See the Directory of published versions

## QMs

- Metadata
- Terminology
- Data Criteria
- Population Criteria
- Manifest
- HQMF Mapping
- Attribution
- Must Support

In FHIR, a Quality Measure (QM) is represented as a Measure resource containing metadata ( Section 3.1 ) and terminology ( Section 3.2 ), a population criteria section ( Section 3.4 ), a data criteria section ( Section 3.3 ) and a FHIR Library resource containing the logic used to define the criteria used in the measure. The population criteria section typically contains initial population criteria, denominator criteria, and numerator criteria sub-components, among others. Snippet 3-1 shows the structure of a FHIR Measure.
```
<Measure>
 <!-- metadata for the measure - snipped for brevity -->
 <effectivePeriod>
 <start value="2018-01-01"/>
 <end value="2018-12-31"/>
 </effectivePeriod>
 <library value="http://hl7.org/fhir/us/cqfmeasures/Library/EXMLogic-FHIR"/>
 <group>
 <population>
 <code>
 <coding>
 <system value="http://terminology.hl7.org/CodeSystem/measure-population"/>
 <code value="initial-population"/>
 </coding>
 </code>
 <criteria>
 <language value="text/cql-identifier"/>
 <expression value="Initial Population"/>
 </criteria>
 </population>
 <population>
 <code>
 <coding>
 <system value="http://terminology.hl7.org/CodeSystem/measure-population"/>
 <code value="denominator"/>
 </coding>
 </code>
 <criteria>
 <language value="text/cql-identifier"/>
 <expression value="Denominator"/>
 </criteria>
 </population>
 <population>
 <code>
 <coding>
 <system value="http://terminology.hl7.org/CodeSystem/measure-population"/>
 <code value="numerator"/>
 </coding>
 </code>
 <criteria>
 <language value="text/cql-identifier"/>
 <expression value="Numerator"/>
 </criteria>
 </population>
 </group>
</Measure>

```


Snippet 3-1: FHIR Measure structure - abridged for clarity (from sample Measure-EXMLogic.xml )

**Conformance Requirement 3.1 (Measure Specifications): **
- FHIR-based Quality Measures SHALL consist of a FHIR Measure resource conforming to at least the CRMIShareableMeasure profile .
- In addition, measures with a status of active SHALL conform to the CRMIPublishableMeasure profile in particular.
- FHIR-based measures SHALL contain a narrative containing a human-readable representation of the measure content. a. Narrative should be consistent with the narratives in this IG. Liquid templates are provided as informative resources to facilitate consistency across measures. Measure.liquid

### Metadata


The header of a QM identifies and classifies the measure and provides important metadata about the measure.

The rest of this section describes some of the more important components to the header, such as “Related Documents” ( Section 3.1.1 ), “Measurement Period” ( Section 3.1.2 ), and “Data Criteria” ( Section 3.3 ).

#### Related Documents


Clinical Quality Language R1 can be used in conjunction with the FHIR Measure resource to construct CQL-based quality measures. CQL is a domain specific language used in the Clinical Quality Measurement and Clinical Decision Support domains. Measures written in CQL leverage the expressivity and computability of CQL to define the population criteria used in the QM. This implementation guide supports the use of CQL version 1.5 (currently published as Errata 1, version 1.5.2), however any future backward-compatible version of the specification may be used.

For measures that make use of CQL, any included CQL library must contain a library declaration line as its first line as in Snippet 3-2.
```
library EXM146 version '4.0.0'

```


Snippet 3-2: Library declaration line from EXM146.cql

When using multiple CQL libraries to define a measure, refer to the Nested Libraries section of the Using CQL topic of this guide.

Inclusion of CQL in a FHIR QM is accomplished through the use of a FHIR Library resource as shown in Snippet 3-4. These libraries are then incorporated into the FHIR QM using the `library`element of the Measure (Snippet 3). CQL library content is encoded as `base64`and included as the `content`element of the Library resource.
```
<library value="http://hl7.org/fhir/us/cqfmeasures/Library/EXMLogic-FHIR"/>

```


Snippet 3-3: `library`element from Snippet 3-1

**Conformance Requirement 3.2 (Referencing CQL Documents): **
- FHIR-based measures that make use of CQL SHALL use the CQLLibrary profile.
- FHIR-based measures that use CQL MAY reference other CQL libraries, but only the primary measure library is specified in the library element of the measure.

Snippet 3-4 illustrates a FHIR Library resource containing a CQL library with a stable, globally unique, version-independent identifier for the library, the `url`. If the library has a version specified, the `version`element is used as well.
```
{
 "resourceType": "Library",
 "id": "exm-146",
 "meta": {
 "profile": [
 "http://hl7.org/fhir/uv/cql/StructureDefinition/cql-library"
 ]
 },
 "url": "http://hl7.org/fhir/us/cqfmeasures/Library/exm-146",
 "identifier": [
 {
 "use": "official",
 "system": "http://example.org/fhir/cqi/ecqm/Library/Identifier",
 "value": "EXM146"
 }
 ],
 "version": "4.0.0",
 "name": "EXM146",
 "title": "EXM146 - Example Proportion Measure Library",
 "status": "active",
 "experimental": true,
 "type": {
 "coding": [
 {
 "system": "http://terminology.hl7.org/CodeSystem/library-type",
 "code": "logic-library"
 }
 ]
 },
 "date": "2019-09-03",
 "publisher": "Health Level 7 International - Clinical Quality Information Work Group",
 "contact": [
 {
 "telecom": [
 {
 "system": "url",
 "value": "http://www.hl7.org/Special/committees/cqi/index.cfm"
 }
 ]
 }
 ],
 "description": "This library is used as an example in the FHIR Quality Measure Implementation Guide",
 "useContext": [
 {
 "code": {
 "system": "http://terminology.hl7.org/CodeSystem/usage-context-type",
 "code": "program"
 },
 "valueCodeableConcept": {
 "coding": [
 {
 "system": "http://hl7.org/fhir/us/cqfmeasures/CodeSystem/quality-programs",
 "code": "ep-ec",
 "display": "EP/EC"
 }
 ]
 }
 }
 ],
 "jurisdiction": [
 {
 "coding": [
 {
 "system": "urn:iso:std:iso:3166",
 "code": "US"
 }
 ]
 }
 ],
 "approvalDate": "2019-08-03",
 "lastReviewDate": "2019-08-03",
 "relatedArtifact": [
 {
 "type": "depends-on",
 "resource": "http://hl7.org/fhir/Library/FHIR-ModelInfo|4.0.1"
 },
 {
 "type": "depends-on",
 "resource": "http://hl7.org/fhir/Library/FHIRHelpers|4.0.1"
 },
 {
 "type": "depends-on",
 "resource": "http://hl7.org/fhir/Library/Common|2.0.0"
 },
 {
 "type": "depends-on",
 "resource": "http://somewhere.org/fhir/uv/mycontentig/Library/MATGlobalCommonFunctions|5.0.000"
 },
 {
 "type": "depends-on",
 "resource": "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1011"
 },
 {
 "type": "depends-on",
 "resource": "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1012"
 },
 {
 "type": "depends-on",
 "resource": "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1061"
 },
 {
 "type": "depends-on",
 "resource": "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001"
 },
 {
 "type": "depends-on",
 "resource": "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1012"
 }
 ],
 "parameter": [
 {
 "name": "Measurement Period",
 "use": "in",
 "min": 0,
 "max": "1",
 "type": "Period"
 },
 {
 "name": "Patient",
 "use": "out",
 "min": 0,
 "max": "1",
 "type": "Patient"
 },
 {
 "name": "Is Between 2 and 17 Years of Age at Start of Measurement Period",
 "use": "out",
 "min": 0,
 "max": "1",
 "type": "boolean"
 },
 {
 "name": "Antibiotics",
 "use": "out",
 "min": 0,
 "max": "*",
 "type": "MedicationRequest"
 },
 {
 "name": "Pharyngitis",
 "use": "out",
 "min": 0,
 "max": "*",
 "type": "Condition"
 },
 {
 "name": "Measurement Period Encounters",
 "use": "out",
 "min": 0,
 "max": "*",
 "type": "Encounter"
 },
 {
 "name": "Pharyngitis Encounters With Antibiotics",
 "use": "out",
 "min": 0,
 "max": "*",
 "type": "Encounter"
 },
 {
 "name": "Initial Population",
 "use": "out",
 "min": 0,
 "max": "*",
 "type": "Encounter"
 },
 {
 "name": "Pharyngitis With Prior Antibiotics",
 "use": "out",
 "min": 0,
 "max": "*",
 "type": "Condition"
 },
 {
 "name": "Excluded Encounters",
 "use": "out",
 "min": 0,
 "max": "*",
 "type": "Encounter"
 },
 {
 "name": "Denominator Exclusions",
 "use": "out",
 "min": 0,
 "max": "*",
 "type": "Encounter"
 },
 {
 "name": "Strep Test Encounters",
 "use": "out",
 "min": 0,
 "max": "*",
 "type": "Encounter"
 },
 {
 "name": "Numerator",
 "use": "out",
 "min": 0,
 "max": "*",
 "type": "Encounter"
 }
 ],
 "dataRequirement": [
 {
 "type": "MedicationRequest",
 "profile": [
 "http://hl7.org/fhir/StructureDefinition/MedicationRequest"
 ],
 "codeFilter": [
 {
 "path": "medication",
 "valueSet": "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001"
 }
 ]
 },
 {
 "type": "Condition",
 "profile": [
 "http://hl7.org/fhir/StructureDefinition/Condition"
 ],
 "codeFilter": [
 {
 "path": "code",
 "valueSet": "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1011"
 }
 ]
 },
 {
 "type": "Condition",
 "profile": [
 "http://hl7.org/fhir/StructureDefinition/Condition"
 ],
 "codeFilter": [
 {
 "path": "code",
 "valueSet": "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1012"
 }
 ]
 },
 {
 "type": "Encounter",
 "profile": [
 "http://hl7.org/fhir/StructureDefinition/Encounter"
 ],
 "codeFilter": [
 {
 "path": "type",
 "valueSet": "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1061"
 }
 ]
 },
 {
 "type": "Observation",
 "profile": [
 "http://hl7.org/fhir/StructureDefinition/Observation"
 ],
 "codeFilter": [
 {
 "path": "code",
 "valueSet": "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1012"
 }
 ]
 }
 ],
 "content": [
 {
 "contentType": "text/cql",
 "data": "bGli...Cg=="
 },
 {
 "contentType": "application/elm+xml",
 "data": "PD94...Cg=="
 },
 {
 "contentType": "application/elm+json",
 "data": "ew0K...DQp9"
 }
 ]
}

```


Snippet 3-4: Example CQL Library (from library-EXM146.json )

Inclusion of CQL libraries within the FHIR-based QM framework must conform to Conformance Requirement 3.2 .

##### Including ELM


CQL defines both a human-readable text representation and a machine-oriented representation called the Expression Logical Model (ELM), which can be represented using XML or JSON. The human-readable text representation is optimized for authoring while the ELM representation offers a canonical, simplified representation that is easier to implement in software. Any CQL expression can be directly translated to its ELM equivalent. Measure authors do not work with ELM directly; rather authoring tools convert CQL to the ELM representation for distribution.

Both CQL and ELM representations may be included in the Library resource depending on the expected capabilities of the consuming environment. See the Packaging topic for more information on how measures can be packaged for different use cases, including supporting human readability (in this case, the high-level CQL syntax) and a canonical representation for machine processing (in this case, CQL’s Expression Logical Model (ELM)). This approach facilitates human review of measure logic via CQL and implementation of that logic in tools via ELM. For implementations unable to compile CQL, ELM representations should be included.

**Conformance Requirement 3.3 (Referencing ELM Documents): **
- To support implementations that cannot compile CQL, an ELM translation SHOULD be provided, in either XML or JSON format.
- FHIR-based measures that make use of ELM SHALL use the ELMLibrary or ELMJSONLibrary profile.
- When ELM translations are provided, they SHALL be semantically equivalent to the corresponding CQL library

The content elements in Snippet 3-4 provide an example of how a Library resource would contain both the CQL and the ELM as base-64-encoded strings (conforming to the CQLLibrary, ELMXMLLibrary, and ELMJSONLibrary profiles). More information on using ELM can be found in the Using ELM topic in the Using CQL With FHIR implementation guide.

For examples of ELM using the XML and JSON representations please see the included examples, EXM146.xml and EXM146.json .

#### Measurement Period


The Measure resource uses the `effectivePeriod`element to define the "Measurement Period", a control variable as metadata that influences the computation of measures. Snippet 3-5 demonstrates how to provide the "Measurement Period" in the Measure (line: 3 of Snippet 3-1).

'Measurement Period' is anchored by the `effectivePeriod`element but not necessarily directly represented.
```
<effectivePeriod>
 <start value="2018-01-01"/>
 <end value="2018-12-31"/>
</effectivePeriod>

```


Snippet 3-5: Measure representation of the "Measurement Period" control variable from (measure-exmlogic.xml)

For measures that use CQL, the value of the "Measurement Period" control variable is accessible to CQL libraries as a parameter called "Measurement Period". Snippet 3-6 shows an example of a CQL library declaring this parameter.
```
parameter "Measurement Period" Interval<DateTime>

```


Snippet 3-6: CQL declaration of the measurement period parameter (from EXM146.cql )

Rather than specifying a static effective period, implementations may specify the effective period using a start date and a reporting period duration.

This implementation guide defines two extensions, `cqfm-effectivePeriodAnchor`and `cqfm-effectivePeriodDuration`to support this alternative.

As shown below in Snippet 3-7, a measure anchored to January 1, 2019 with a calendar duration of 1 year, would have valid Measurement Periods of 1/1/2019-12/31/2019, 1/1/2020-12/31/2020, etc. Note that although UCUM definite-duration units are required within FHIR, the semantics in this case use calendar duration semantics.
```
<effectivePeriod>
	<extension url="http://hl7.org/fhir/us/cqfmeasures/cqfm-effectivePeriodAnchor">
		<valueDateTime value="2019-01-01"/>
	</extension>
	<extension url="http://hl7.org/fhir/us/cqfmeasures/cqfm-effectivePeriodDuration">
		<valueDuration>
			<value value="1"/>
			<code value="a"/>
		</valueDuration>
	</extension>
</effectivePeriod>

```


Snippet 3-7: Example of effectivePeriodAnchor extension (used to define the starting date and range) and effectivePeriodDuration extension (used to specify the reporting period).

**Conformance Requirement 3.4 (Measurement Period): **
- FHIR-based QMs SHALL provide either an `effectivePeriod`element, or an `cqfm-effectivePeriodAnchor`and `cqfm-effectivePeriodDuration`extension
- Measurement Period SHALL be either the `effectivePeriod`as specified, or an appropriate interval of length duration, starting at the specified anchor

### Terminology


This section describes how to use codes and valuesets from codesystems like LOINC, SNOMED-CT, and others within FHIR-based QMs.

When terminology artifacts are defined and distributed as part of quality measure content, guidance provided as part of the Canonical Resource Management Infrastructure IG should be followed.

When using CQL to represent measure criteria, valuesets and direct-reference codes used by the expressions are declared in the header section of the CQL using the CQL valueset and code constructs. Examples of code system, valueset, and code declarations can be seen in the accompanying CommonTerminologies.cql and Terminology.cql .
```
codesystem 'SNOMEDCT:2017-09': 'http://snomed.info/sct'
 version 'http://snomed.info/sct/731000124108/version/201709'

```


Snippet 3-8: CQL declaration of a codesystem (from CommonTerminologies.cql )
```
valueset "Encounter Inpatient SNOMEDCT Value Set":
 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.7.307|20160929'

code "Venous foot pump, device (physical object)": '442023007' from "SNOMED-CT:2017-09"

```


Further discussion of codesystem, valueset, and code can be found in the Using CQL Chapter of this IG, sections 4.3 , 4.4 , and 4.5 .

For measures that use CQL, valuesets and direct-reference codes that are associated with data access expressions can be found in the `dataRequirement`elements in the Library resource referenced by the Measure resource.
```
"dataRequirement": [
 {
 "type": "CodeableConcept",
 "codeFilter": [
 {
 "valueCoding": {
 "system": "http://snomed.info/sct",
 "version": "http://snomed.info/sct/731000124108/version/201709",
 "code": "442023007",
 "display": "Venous foot pump, device (physical object)"
 }
 }
 ]
 },
 {
 "type": "Encounter",
 "codeFilter": [
 {
 "path": "type",
 "valueSet": "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.7.307|20160929"
 }
 ]
 }
]

```


Snippet 3-9: Example Library terminology definitions (from library-Terminology.json )

Regardless of whether a measure uses CQL, all valuesets and direct-reference codes referenced by the measure are surfaced in the *effective data requirements *library for a computable measure.

**Conformance Requirement 3.5 (Terminology Inclusion): **

Measures using valueset and/or direct-reference codes SHALL conform to the requirements of Conformance Requirement 3.5.
- All valuesets referenced by the measure SHALL be included in the *effective data requirements *Library using relatedArtifact elements: a. The code element of the relatedArtifact SHALL be depends-on b. The resource element of the relatedArtifact SHALL be the canonical URL of the referenced value set. c. If the library valueset declaration includes a version, the canonical URL SHALL include the version specified in the declaration using canonical URL version syntax (i.e. `|version`) d. The display element of the relatedArtifact SHALL include either
 - The identifier of the valueset declaration in the CQL, if the measure is using CQL
 - The `name`of the valueset
- All direct-reference codes referenced by the measure SHALL be included in the *effective data requirements *Library using the cqf-directReferenceCode extension: a. The code and system elements of the Coding SHALL be set to the code and system of the declaration, if the measure is using CQL b. If the code declaration includes a display, it SHALL be used as the display of the Coding, otherwise, the identifier of the code declaration SHALL be used as the display

For example, in the following CQL, the reference to the code `"Venous foot pump, device (physical object)"`occurs in the `"DeviceUseStatement"`retrieve, while the reference to the code `"Right foot"`occurs outside the context of the retrieve:
```
define "Venous Foot Pumps Applied":
 ["DeviceUseStatement": code in "Venous foot pump, device (physical object)"] D
 where D.status = 'completed'
 and D.bodySite ~ ToConcept("Right foot")

```


Snippet 3-10: Example expression using direct-reference codes in both a retrieve expression and a where clause

This expression results in the following in the *effective data requirements *Library for the measure:
- A cqf-directReferenceCode element for the "Venous foot pump, device (physical object)" code
- A cqf-directReferenceCode element for the "Right foot" code
- A dataRequirement element for the `DeviceUseStatement`with a reference to the "Venous foot pump, device (physical object)" code

### Data Criteria


The data criteria section defines the patient data of interest for the measure as a set of `dataRequirement`entries. Each entry identifies specific types of data along with constraints that the data must meet. Snippet 3-11 shows an example of a data criteria entry indicating an "Encounter".
```
"dataRequirement": [
 {
 "type": "Encounter",
 "codeFilter": [
 {
 "path": "type",
 "valueSet": "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.7.307|20160929"
 }
 ]
 }
]

```


Snippet 3-11: Example data criteria (from library-Terminology.json )

**Conformance Requirement 3.6 (Data Criteria Inclusion): **
- `dataRequirement`entries SHALL be included in the *effective data requirements *Library for each data element referenced by the measure

For measures that use CQL, these data requirements may be inferred by analysis of the retrieve expressions used by the measure criteria. As discussed in the Using CQL With FHIR implementation guide, Library resources used to contain CQL libraries should surface the dependencies, terminologies, and data requirements of the CQL. Whether using CQL or some other expression representation, the dependencies, terminologies, and data requirements used by expressions referenced by the measure are surfaced in the *effective data requirements *Library for the measure to promote structured review of the data criteria for a Library (and by examining Libraries referenced by a Measure, for a Measure or set of Measures) for the following use cases:
- Determining the set of data used by a particular QM.
- Limited “scoop-and-filter” for creation of quality reports. Implementations desiring or required to comply with privacy policies that mandate or recommend fine-grained filtering should examine the expression logic (CQL, ELM, or otherwise) to determine additional data constraints necessary for adherence to those policies.

Section 3.3.1 describes a means for deriving data requirements from CQL data references as found in the Retrieve elements of the compiled ELM.

#### Use of ELM


For measures that use CQL, the canonical representation of ELM makes it straightforward to derive data requirements for CQL data references to comply with Conformance Requirement 3.6:

**Conformance Requirement 3.7 **
- Systems SHOULD populate dataRequirements for each ELM Retrieve element. Each dataRequirement:
 - SHALL have a `type`element representing the type of the retrieve
 - SHALL have a profile element with the value of the templateId attribute of the retrieve, if present
 - If the Retrieve element has a `codes`element referencing a ValueSet, the dataRequirement SHALL have a codeFilter.valueSet element
 - If the Retrieve element has a `codes`element with a direct reference code, the dataRequirement SHALL have a codeFilter.code element

Systems that can optimize terminology restrictions may include filters that can be inferred from the CQL in the data requirements to provide more selective data requirements.

Note that if the data model does not specify profile identifiers, the ELM retrieves will not have a `templateId`specified. In this case, the name of the type in the data model is used.

To illustrate the mapping, Snippet 3-12 shows an ELM data reference and corresponding dataRequirement in both XML and JSON

XML:
```
<def name="Acute Pharyngitis" id="http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1011" accessLevel="Public" />

```

```
<operand dataType="fhir:Condition" xsi:type="Retrieve">
 <codes name="Acute Pharyngitis" xsi:type="ValueSetRef" />
</operand>

```


JSON:
```
"def": [
 {
 "name": "Acute Pharyngitis",
 "id": "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1011",
 "accessLevel": "Public"
 }
]

```

```
"operand": [
 {
 "dataType": "{http://hl7.org/fhir}Condition",
 "codeProperty": "code",
 "type": "Retrieve",
 "codes": {
 "name": "Acute Pharyngitis",
 "type": "ValueSetRef"
 }
 }
]

```


Snippet 3-12: ELM data reference for Condition: Acute Pharyngitis (from EXM146_FHIR-4.0.0.xml and EXM146_FHIR-4.0.0.json )
```
{
 "type": "Condition",
 "codeFilter": [
 {
 "path": "code",
 "valueSet": "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1011"
 }
 ]
}

```


Snippet 3-13: dataRequirement for Condition: Acute Pharyngitis (from library-EXM146.json )

### Population Criteria


The Population Criteria (Snippet 3-14) includes definitions of criteria used to specify populations. For computable measures, these criteria SHALL be represented using a formal expression language. Measures SHOULD use CQL for this purpose, and this implementation guide describes conformance expectations for measures that use CQL. Other expression languages MAY be used, but the conformance expectations for other expression languages would need to be defined in a related implementation guide.
```
<group>
 <population>
 <code><coding><code value="initial-population"/></coding></code>
 <criteria>
 <language value="text/cql-identifier"/>
 <expression value="Initial Population"/>
 </criteria>
 </population>
 <population>
 <code><coding><code value="denominator"/></coding></code>
 <criteria>
 <language value="text/cql-identifier"/>
 <expression value="Denominator"/>
 </criteria>
 </population>
 <population>
 <code><coding><code value="numerator"/></coding></code>
 <criteria>
 <language value="text/cql-identifier"/>
 <expression value="Numerator"/>
 </criteria>
 </population>
</group>

```


Snippet 3-14: Population Criteria from Snippet 3-1 (FHIR Measure structure - abridged for clarity (from sample Measure-EXMLogic.xml ))

CQL provides the logical expression language that is used to define population criteria. CQL-based constraints are then referenced from the group elements of the FHIR Measure resource. Once included in the FHIR Measure, expressions defined in the CQL can be used to further refine the data criteria and to define population criteria. Figure 2-1 illustrates the general concept. Figure 3-1 illustrates the relationship between the FHIR Measure resource and CQL documents: The FHIR Measure resource references a CQL expression script (#1), the FHIR library resource references a particular expression from the referenced CQL file (#2), the referenced expression in-turn may include or call another expression (#3) in the same (or a different) CQL expression script. Snippet 3-14 and Snippet 3-15 demonstrate the use of the FHIR Measure resource and CQL in the definition of the "initial-population".

**Figure 3-1: Relationship between FHIR Measure and CQL Expression Script **
```
"population": [
 {
 "identifier": {
 "value": "initial-population-identifier"
 },
 "code": {
 "coding": [
 {
 "code": "initial-population"
 }
 ]
 },
 "criteria": {
 "language": "text/cql-identifier",
 "expression": "\"Initial Population\""
 }
 }
]

```


Snippet 3-15: Defining a population via reference to a CQL expression (from measure-exm146-FHIR.json )

Snippet 3-16 shows several examples of a CQL expression calling another, e.g. the "Initial Population" expression references another CQL expression: "Pharyngitis Encounters With Antibiotics". In this example the referenced expressions are all contained within the same CQL file (EXM146.cql) and some are included above. The "Is Between 2 and 17 Years of Age at Start of Measurement Period" expression uses the built-in CQL function AgeInYearsAt(). The definition of "Pharyngitis Encounters With Antibiotics" uses the function "Includes Or Starts During", defined in another CQL library (Common as described in Common.cql), further explanation of nested libraries is given in the “Nested Libraries” section of the Using CQL topic of this IG.
```
library EXM146_FHIR version '4.0.0'

using FHIR version '3.0.0'

include FHIRHelpers version '3.0.0' called FHIRHelpers
include Common_FHIR version '2.0.0' called Common

define "Is Between 2 and 17 Years of Age at Start of Measurement Period":
 AgeInYearsAt(start of "Measurement Period") >= 2
 and AgeInYearsAt(start of "Measurement Period") <= 17

define "Measurement Period Encounters":
 [Encounter: "Ambulatory/ED Visit"] Encounter
 where Encounter.period during "Measurement Period"
 and Encounter.status = 'finished'
 and "Is Between 2 and 17 Years of Age at Start of Measurement Period"

define "Pharyngitis Encounters With Antibiotics":
 "Measurement Period Encounters" Encounters
 with "Pharyngitis" Pharyngitis such that
 Common."Includes Or Starts During"(Pharyngitis, Encounters)
 with "Antibiotics" Antibiotics such that Antibiotics.authoredOn
 3 days or less after FHIRHelpers.ToInterval(Encounters.period)

define "Initial Population":
 "Pharyngitis Encounters With Antibiotics"

```


Snippet 3-16: CQL definition of the "Initial Population" criteria (from EXM146.cql )

**Conformance Requirement 3.8 (Referential Integrity): **
- All Measure population criteria components a. SHALL reference exactly one expression. b. SHALL reference the same library.
- For measures that use CQL, references to expressions SHALL use the `text/cql-identifier`media type defined in the CQL specification .

#### Criteria Names


To encourage consistency among measures, the following guidelines for specifying population criteria within a measure are proposed. The measure population criteria names used here are defined by the MeasurePopulationType code system in the base FHIR specification.

The codes within the MeasurePopulationType code system in the base FHIR specification are explicitly spelled out, whereas the measure population code based on HQMF are abbreviated. In order to make the development of QMs straightforward and clear, this concept map provides mapping from HQMF codes to FHIR codes for each of the measure component code.

**Conformance Requirement 3.9 (Criteria Names): **

The name of an expression specifying a population criteria within a measure SHOULD always be the name of the criteria type††:
- "Initial Population"
- "Denominator"
- "Denominator Exclusion"
- "Denominator Exception"
- "Numerator"
- "Numerator Exclusion"
- "Measure Population"
- "Measure Population Exclusion"
- "Measure Observation"
- "Stratification"

†† When using multiple populations and/or multiple population groups, see Section 3.4.7

Note that the Measure Observation criteria is the name of a function used in the Continuous Variable Measure. See the Continuous Variable Measure section for more.

For each scoring type, the set of applicable criteria are specified in the Quality Reporting topic of the FHIR Clinical Reasoning module. The table is reproduced here for reference:

**Table 3-1: Measure populations based on types of measure scoring. **Scoring Initial Population Denominator Denominator Exclusion Denominator Exception Numerator Numerator Exclusion Measure Population Measure Population Exclusion Proportion R R O O R O NP NP Ratio R‡‡ R O NP R O NP NP Continuous Variable R NP NP NP NP NP R O Cohort R NP NP NP NP NP NP NP

NOTE: Composite measures are not represented in this table as they are made up of component measures. The component measures in the composite will be expected to conform to the information in this table.

R=Required. O=Optional. NP=Not Permitted.

‡‡ Some ratio measures will require multiple Initial Populations, one for the numerator and one for the denominator.

In addition, the formula for calculating the measure score is implied by the scoring of the measure. The following sections describe the expected result type for population criteria for each type of measure, as well as explicitly defining the measure score calculation formula.

The context of a measure is indicated using the subject element of the FHIR resource. The subject element will be a reference to a FHIR resource type, specifically including Patient, Location, Organization, Practitioner, and Device as currently specified in the extensible SubjectType binding. It is important to note that other resource types may be used, but it must be a FHIR resource type. We should also note that although the discussion is focused on Patient as the subject, the discussion applies to other subject types as well.

In addition to the measure scoring, measures generally fall into two categories, patient-based, and non-patient-based. In general, patient-based measures count the number of patients in each population, while non-patient-based measures count the number of items (such as encounters) in each population. Although the calculation formulas are conceptually the same for both categories, for ease of expression, population criteria for patient-based measures indicates whether a patient matches the population criteria (true) or not (false). Non-patient-based measures return the item to be counted such as an encounter or procedure.

**Conformance Requirement 3.10 (Population Basis): **
- The `cqfm-populationBasis`extension SHALL be used to identify the result type of population criteria used in the measure
- Expressions used in population criteria SHALL return a value of the type specified by the populationBasis for the measure.

Snippet 3-16 illustrates the use of the populationBasis extension for a patient-based measure:
```
 "extension": [
 {
 "url": "http://hl7.org/fhir/us/cqfmeasures/StructureDefinition/cqfm-populationBasis",
 "valueCode": "boolean"
 }
 ]

```


Snippet 3-16: Population basis for a patient-based measure

Snippet 3-17 illustrates the use of the populationBasis extension for an non-patient-based measure:
```
 "extension": [
 {
 "url": "http://hl7.org/fhir/us/cqfmeasures/StructureDefinition/cqfm-populationBasis",
 "valueCode": "Encounter"
 }
 ]

```


Snippet 3-17: Population basis for an non-patient-based measure

Note that this extension is specifically bound to the FHIRAllTypes ValueSet (i.e. the set of all types in FHIR, including data types and resource types, both abstract and concrete). The FHIRAllTypes value set is appropriate for the specification since it's possible to have population criteria that result in "abstract" types. Authoring environments may wish to limit the selection of population basis based on the content implementation guides used in authoring the measure, but that would be a content-driven validation, not a restriction enforced by the specification.

#### Measure Population Semantics


The base FHIR Measure resource defines a set of measure population components that are used to construct measures. Measure populations have implicit relationships to each other depending on the measure scoring type. For example, for proportion measures, denominator criteria have an implicit dependency on initial population criteria, i.e. the criteria for inclusion in the denominator of a measure implicitly include the criteria for inclusion in the initial population. Similarly, numerator criteria have an implicit dependency on denominator criteria, i.e. the criteria for inclusion in the numerator of a measure implicitly include the criteria for inclusion in the denominator. Expressions referenced by Measure population criteria are evaluated within the context of these implicit dependencies.

**Conformance Requirement 3.11 (Measure Population Semantics): **
- Expressions used as measure population criteria SHALL be evaluated taking relevant dependencies into account, as specified by the membership determination formulas defined for each scoring type.
- Expressions MAY include explicit dependencies that duplicate the implicit FHIR-based QM population dependencies.
- Expressions SHALL use a FHIR resource type (e.g. Patient) as the context, and SHALL be expressed within the context of a single subject record of that type.

For example, Snippet 3-18 defines the "Initial Population" and "Denominator" for a measure.
```
define "Initial Population":
 "In Demographic" and "Has Target Encounter"

define "Denominator": "Initial Population"

```


Snippet 3-18: Explicit definition of the initial population and denominator.

In this snippet, the relationship between the "Denominator" and the "Initial Population" is made explicit even though the FHIR Measure specification defines the "Denominator" to be a subset of the "Initial Population". With respect to the measure population definitions, the following CQL code has identical meaning:
```
define "Denominator": true

```


In this variant, the "Denominator" is utilizing the measure dependencies but this dependency is not explicitly expressed in the CQL; this is referred to as an implicit dependency.

If population criteria evaluate to null for a patient-based measure it is interpreted as false. If population criteria evaluate to null for a non-patient-based measure it is interpreted as an empty list.

#### Proportion Measures


A FHIR Measure resource representing a proportion measure will include one or more population criteria sections as described in Table 3-2.

The semantics of these components are unchanged from the base Measure specification; the only difference is that each component references a single criterion encoded as a formal expression.

The referenced expressions return either an indication that a patient meets the population criteria (patient-based measures) or the events that a particular patient contributes to the population (non-patient-based measures). For example, consider two measures:

**Table 3-2: Patient-based and non-patient-based Measure Examples **Measure Denominator Numerator Patient-based All patients with condition A that had one or more encounters during the measurement period. All patients with condition A that underwent procedure B during the measurement period. Non-patient-based All diagnostic studies (CT scans) during the measurement period. Diagnostic studies (CT scans) exceeding radiation dosage thresholds during the measurement period. Non-patient-based All encounters where patients have condition A during the measurement period. All encounters where patients have condition A during the measurement period and procedure B was performed during the encounter.

In Table 3-2, the first measure is an example of a patient-based measure. Each patient may contribute at most one count to the denominator and numerator, regardless of how many encounters they had. The second measure is a non-patient-based measure where each patient may contribute zero or more CT scans to the denominator and numerator counts. The third measure is another non-patient-based measure where each patient may contribute zero or more encounters to the denominator and numerator counts.

For complete examples of patient based proportion measures, see the Screening Measure Examples . For a complete example of an non-patient-based proportion measure, see the EXM108 measure included in this implementation guide.

**Conformance Requirement 3.12 (Proportion Measures): **
- Proportion measures SHALL conform to the CQFM Proportion Measure profile.
- Population criteria SHALL each reference a single expression as defined by Conformance Requirement 3.8 .
- Expressions for patient-based measures SHALL return a Boolean to indicate whether a patient matches the population criteria (true) or not (false).
- Expressions for non-patient-based measures SHALL return a List of events of the same type, such as an Encounter or Procedure.

##### Proportion measure scoring


The population types for a Proportion measure are "Initial Population", "Denominator", "Denominator Exclusion", "Numerator", "Numerator Exclusion" and "Denominator Exception". The following diagram shows the relationships between the populations for proportion measures and the table below provides their definitions.

**Figure 3-2: Population criteria relationships for Proportion measures illustration **

**Table 3-3: Population Criteria Definitions for Proportion Measures **Population Definition Initial Population The initial population criteria refers to all patients, subjects, or events to be evaluated by a quality measure involving patients or subjects who share a common set of specified characteristics. All patients, subjects, or events counted (for example, as numerator, as denominator) are drawn from the initial population. Denominator Denominator criteria define the patients, subjects, or events that should be included in the lower portion of a fraction used to calculate a rate, proportion, or ratio. The denominator can be the same as the initial population, or a subset of the initial population to further constrain the population for the purpose of the measure. Denominator Exclusion Denominator exclusion criteria define patients, subjects, or events that should be excluded from the denominator. Denominator exclusions are used in proportion and ratio measures to help narrow the denominator. For example, patients with bilateral lower extremity amputations would be listed as a denominator exclusion for a measure requiring foot exams. Numerator Numerator criteria define the patients, subjects, or events that should be included in the upper portion of a fraction used to calculate a proportion measure. Also called the measure focus, it is the target process, condition, event, or outcome. Numerator criteria are the processes or outcomes expected for each patient, subject, or event defined in the denominator (for proportion measures) or initial population (for ratio measures). A numerator statement describes the clinical action that satisfies the conditions of the measure. Numerator Exclusion Numerator exclusion criteria define patients, subjects, or events to be excluded from the numerator. Numerator exclusions are used in proportion and ratio measures to help narrow the numerator (for inverted measures). Denominator Exception Denominator exceptions are conditions that should remove a patient, subject, or event from the denominator of a measure only if the numerator criteria are not met. Denominator exception allows for adjustment of the calculated score for those providers with higher risk populations. Denominator exception criteria are only used in proportion measures.
- Initial population: Identify those cases that meets the Initial Population criteria.
- Denominator: Identify that subset of the Initial Population that meets the Denominator criteria.
- Denominator Exclusion: Identify that subset of the Denominator that meets the Denominator Exclusion criteria. There are cases that should be removed from the Denominator as exclusion. Once these cases are removed, the subset remaining would reflect the Denominator per criteria.
- Numerator: Identify those cases in the Denominator and NOT in the Denominator Exclusion that meets the Numerator criteria. In proportion measures, the Numerator criteria are the processes or outcomes expected for each patient, procedure, or other unit of measurement defined in the Denominator.
- Numerator Exclusion: Identify that subset of the Numerator that meets the Numerator Exclusion criteria. Numerator Exclusion is used only in ratio measures to define instances that should not be included in the Numerator data.
- Denominator Exception: Identify those meeting Denominator and Denominator Exception criteria and fail to meet both the Denominator Exclusion and the Numerator criteria.

The "performance rate" is a ratio of patients meeting Numerator criteria, divided by patients in the Denominator (accounting for exclusion and exception). Performance rate can be calculated using this formula:
```
Performance rate = (Numerator - Numerator Exclusion) / (Denominator – Denominator Exclusion – Denominator Exception)

```


Here is an example of using population types to select data on diabetes patients for a Proportion measure:
- Initial Population: Patient is between the age of 16 and 74
- Denominator: Patient has Diabetes Type II
- Denominator Exclusion: Patient is in Hospice Care
- Numerator: Patient is between the age of 16 and 74, has Diabetes Type II, and the most recent laboratory result has hbA1C value > 9%
- Denominator Exception: Patient meets the Denominator criteria and does NOT meet the Numerator criteria, and is designated as having "Steroid Induced Diabetes" or "Gestational Diabetes"

##### Patient-based Calculation


Snippet 3-18 provides precise semantics for the measure score calculation for a patient-based proportion measure:
```
context Patient

define "Denominator Membership":
 "Initial Population"
 and "Denominator"
 and not "Denominator Exclusion"
 and not ("Denominator Exception" and not "Numerator")

define "Numerator Membership":
 "Initial Population"
 and "Denominator"
 and not "Denominator Exclusion"
 and "Numerator"
 and not "Numerator Exclusion"

context Unfiltered

define "Measure Score":
 Count("Numerator Membership" IsMember where IsMember is true)
 / Count("Denominator Membership" IsMember where IsMember is true)

```


Snippet 3-18: Patient-based proportion measure calculation semantics

##### Non-patient-based Calculation


Snippet 3-19 provides precise semantics for the measure score calculation for a non-patient-based proportion measure:
```
define "Numerator Membership":
 "Initial Population"
 intersect "Denominator"
 except "Denominator Exclusion"
 intersect "Numerator"
 except "Numerator Exclusion"

define "Denominator Membership":
 "Initial Population"
 intersect "Denominator"
 except "Denominator Exclusion"
 except ("Denominator Exception" except "Numerator")

define "Measure Score":
 Count("Numerator Membership") /
 Count("Denominator Membership")

```


Snippet 3-19: Non-patient-based proportion measure calculation semantics

#### Ratio Measures


A Measure document representing a ratio measure will include one or more population criteria sections as described in Table 3-1.

In addition, it may also include one or more measure-observation elements. The semantics of these components are unchanged from the base Measure specification; the only difference is that each measure population component and each measure observation definition references a single criterion encoded as a CQL expression.

**Conformance Requirement 3.13 (Ratio Measures): **
- Ratio measures SHALL conform to the CQFM Ratio Measure profile.
- Population criteria SHALL each reference a single expression as defined by Conformance Requirement 3.8 .
- measure-observation criteria SHALL reference expressions as defined by Conformance Requirement 3.14 , with the exception that instead of a measure-population, the criteriaReference element SHALL reference a numerator or denominator criteria.
- Expressions for patient-based measures SHALL return a Boolean to indicate whether a patient matches the population criteria (true) or not (false).
- Expressions for non-patient-based measures SHALL return a List of events of the same type, such as an Encounter or Procedure.

For ratio measures that include a Measure Observation, the measure observation is defined as a function that takes a single parameter of the type of elements returned by the population criteria. This is also how it is specified for continuous variable measures. In particular, for non-patient based ratio measures the Measure Observation is defined as a function that takes a single argument of the same type as the elements returned by all the population criteria, and the aggregation method is specified in the Measure resource. For patient based ratio measures the Measure Observation is defined as a function that takes no parameters.

##### Ratio measure scoring


The population types for a Ratio measure are "Initial Population", "Denominator", "Denominator Exclusion", "Numerator" and "Numerator Exclusion". The following diagrams✧ show the relationships between the populations for Ratio measures and the table below provides their definitions

**Figure 3-3: Population criteria for Ratio measures illustration - Numerator **

**Figure 3-4: Population criteria for Ratio measures illustration - Denominator **

✧ The ratio diagrams depict a ratio measure. Ratio measures may also include continuous variable calculations for the numerator and denominator (continuous variable ratio measures) but the diagrams do not depict the continuous variable ratio measures.

**Table 3-4: Population Criteria Definitions for Ratio Measures **Population Definition Initial Population All entities to be evaluated by a measure which may but are not required to share a common set of specified characteristics within a named measurement set to which the measure belongs. Ratio measures are allowed to have two Initial Populations, one for Numerator and one for Denominator. In most cases, there is only 1 Initial Population Denominator The same as the Initial Population or a subset of the Initial Population to further constrain the population for the purpose of the measure. Denominator Exclusion Entities that should be removed from the Denominator before determining if Numerator criteria are met. Denominator exclusions are used in Proportion and Ratio measures to help narrow the Denominator. Numerator The outcomes expected for each entity defined in the respective Initial Population of a Ratio measure. Numerator Exclusion Entities that should be removed from the QM's Numerator before determining if Numerator criteria are met. Numerator Exclusions are used in Proportion and Ratio measures to help narrow the Numerator.
- Initial population: Identify those cases that meet the Initial Population criteria. (Some ratio measures will require multiple initial populations, one for the numerator, and one for the denominator.)
- Denominator: Identify that subset of the Initial Population that meets the Denominator criteria.
- Denominator Exclusion: Identify that subset of the Denominator that meets the Denominator Exclusion criteria.
- Numerator: Identify that subset of the Initial Population that meets the Numerator criteria.
- Numerator Exclusion: Identify that subset of the Numerator that meets the Numerator Exclusion criteria.

Here is an example of using the population types to select data on patients with central line catheters for a ratio measure:
- Initial Population: Patient is aged 65 years or older and admitted to hospital
- Denominator: Patient has a central line
- Denominator Exclusion: Patient is immunosuppressed
- Numerator: Patient has a central line blood stream infection
- Numerator Exclusion: Patient's central line blood stream infection is deemed to be a contaminant

##### Individual Observations


For each case in the Denominator and not in the Denominator Exclusion, determine the individual Denominator observations.

For each case in the Numerator and not in the Numerator Exclusion, determine the individual Numerator observations.

##### Measure Aggregates


Using individual observations for all cases in the Denominator and not in the Denominator Exclusion, calculate the aggregate Denominator.

Using individual observations for all cases in the Numerator and not in the Numerator Exclusion, calculate the aggregate Numerator.
```
Ratio = aggregate Numerator / aggregate Denominator

```


##### Patient-based Calculation


Snippet 20 provides precise semantics for the measure score calculation for a patient-based ratio measure:
```
context Patient

define "Denominator Membership":
 "Initial Population"
 and "Denominator"
 and not "Denominator Exclusion"

define "Numerator Membership":
 "Initial Population"
 and "Numerator"
 and not "Numerator Exclusion"

context Population

define "Measure Ratio Numerator":
 Count("Numerator Membership" IsMember where IsMember is true)

define "Measure Ratio Denominator":
 Count("Denominator Membership" IsMember where IsMember is true)

```


Snippet 20: Patient-based ratio measure calculation semantics

##### Non-patient-based Calculation


Snippet 21 provides precise semantics for the measure score calculation for a non-patient-based ratio measure:
```
define "Numerator Membership":
 "Initial Population"
 intersect "Numerator"
 except "Numerator Exclusion"

define "Denominator Membership":
 "Initial Population"
 intersect "Denominator"
 except "Denominator Exclusion"

context Population

define "Measure Score Numerator":
 Count("Numerator Membership")

define "Measure Score Denominator":
 Count("Denominator Membership")

```


Snippet 21: Non-patient-based ratio measure calculation semantics

#### Continuous Variable Measure


A Measure document representing a continuous variable measure will include one or more population criteria sections as described in Table 3-1.

In addition, it will also include at least one measure-observation criterion. The semantics of these components are unchanged from the base Measure specification. For measure-observation criteria, two extensions are used to ensure implementability:
- aggregateMethod: This extension defines the method used to aggregate the measure observations defined by the criteria
- criteriaReference: This extension is used to indicate which population should be used as the source for the measure observations. This extension is used in cases where there may be multiple initial populations in a single group (such as a Ratio measure).

Note that the implicit population semantics described in Section 3.4.2 apply equally to continuous variable measures: measure observations are only computed for patients matching the appropriate set of population criteria (i.e. accounting for exclusions).

An example measure-observation criteria is shown in Snippet 3-22.

The criteria referenced from the measure-observation component refers to an expression that returns a list of events for each patient that contributes to the measure population as shown in Snippet 3-18.
```
{
 "extension": [
 {
 "url": "http://hl7.org/fhir/us/cqfmeasures/StructureDefinition/cqfm-criteriaReference",
 "valueString": "measure-population-identifier"
 },
 {
 "url": "http://hl7.org/fhir/us/cqfmeasures/StructureDefinition/cqfm-aggregateMethod",
 "valueCode": "median"
 }
 ],
 "identifier": {
 "value": "measure-observation-identifier"
 },
 "code": {
 "coding": [
 {
 "code": "measure-observation"
 }
 ]
 },
 "criteria": "\"Measure Observation\""
}

```


Snippet 3-22: Sample measure observation section from measure-exm55-FHIR.json
```
define "Measure Population":
 "Initial Population"

define "Inpatient Encounter":
 ["Encounter"] Encounter
 where LengthInDays(Encounter.period) <= 120
 and Encounter.period ends during "Measurement Period"

//Measure Observation
define function "Related ED Visit" (encounter Encounter):
 Last(["Encounter": "Emergency Department Visit"] ED
 where ED.status = 'finished'
 and ED.period ends 1 hour or less before start of encounter.period
 sort by start of period )

define function "Measure Observation" (encounter Encounter):
 duration in minutes of "Related ED Visit"(encounter).period

```


Snippet 3-23: Sample CQL (from EXM55.cql ) for a continuous-variable measure

In the example shown in Snippet 3-22 and Snippet 3-23: the measure reports the aggregate type (Snippet 3-24) of the result of executing the "Measure Observation" function (Snippet 3-25, Snippet 3-26) on each of the events in the measure population, as determined by the “Measure Population” expression (Snippet 3-27, and Snippet 3-28).
```
{
 "url": "http://hl7.org/fhir/us/cqfmeasures/StructureDefinition/cqfm-aggregateMethod",
 "valueCode": "median"
}

```


Snippet 3-24: Aggregate type from Snippet 3-22 (Sample measure observation section from measure-exm55-FHIR.json )
```
"criteria": "\"Measure Observation\""

```


Snippet 3-25: "Measure Observation" function in Snippet 3-22 (Sample measure observation section from measure-exm55-FHIR.json )
```
define function "Measure Observation" (encounter Encounter):

```


Snippet 3-26: "Measure Observation" function in Snippet 3-23 (Sample CQL (from EXM55.cql ) for a continuous-variable measure)
```
{
 "url": "http://hl7.org/fhir/us/cqfmeasures/StructureDefinition/cqfm-criteriaReference",
 "valueString": "measure-population-identifier"
}

```


Snippet 3-27: Identifier referenced in Snippet 3-22 (Sample measure observation section from measure-exm55-FHIR.json )
```
define "Measure Population":

```


Snippet 3-28: Definition from Snippet 3-23 (Sample CQL (from EXM55.cql ) for a continuous-variable measure)

**Conformance Requirement 3.14 (Continuous Variable Measures): **
- Continuous variable measures SHALL conform to the CQFM Continuous Variable Measure profile.
- Population criteria SHALL each reference a single expression as defined by Conformance Requirement 3.8 .
- The aggregateMethod extension SHALL be used on the measureObservation criteria to indicate the aggregate method for the observations. Expressions referenced from measure-observation criteria elements SHALL be consistent with the context used for the population criteria of the measure.
- The population element of a measure-observation criteria SHALL contain a criteriaReference extension that refers to the population criteria within the same population group that is the target population criteria for the measure-observation
- Functions referenced from a measure-observation criteria SHALL: a. be in the same library as the expression in the measure-population criteria referenced from the criteriaReference extension of the measure-observation criteria b. accept a single argument whose type matches the elements of the list returned by the expression referenced from the criteriaReference extension of the measure-observation criteria c. return either an Integer, a Decimal, or a Quantity

For non-patient-based continuous variable measures, the measure observation is defined as a function that takes a single parameter of the type of elements returned by the population criteria. The Initial Population, Measure Population, and Measure Population Exclusion criteria expressions must all return a list of elements of the same type.

For patient-based continuous variable measures, the measure observation is defined as a function that takes no parameters.

Note that the criteria reference in the measure observation definition is present to resolve which measure population should be used in the case of multiple populations, but the actual input to the measure observation definition needs to account for population membership (i.e. account for exclusions). In the case of a continuous variable measure with multiple populations, the identifier of the population criteria in the Measure resource is used to ensure that the measure observation definition refers to a unique population criteria.

##### Continuous Variable Measure Scoring


The population types for a Continuous Variable measure are "Initial Population", "Measure Population", and "Measure Population Exclusion". In addition to these populations, a Measure Observation is defined which contains one or more Continuous Variable statements that are used to score one or more particular aspects of performance. The following diagram shows the relationships between the populations for Continuous Variable measures and the table below provides their definitions.

**Figure 3-5: Population criteria for Continuous Variable measures illustration **

**Table 3-5: Population Criteria Definitions for Continuous Variable Measures **Population Definition Initial Population All entities to be evaluated by a QM which may but are not required to share a common set of specified characteristics within a named measurement set to which the QM belongs. Measure Population Continuous Variable measures do not have a Denominator, but instead define a Measure Population, as shown in the figure above. Rather than reporting a Numerator and Denominator, a Continuous Variable measure defines variables that are computed across the Measure Population (e.g., average wait time in the emergency department). A Measure Population may be the same as the Initial Population or a subset of the Initial Population to further constrain the population for the purpose of the QM. Measure Population Exclusion Patients who should be removed from the QM's Initial Population and Measure Population before determining the outcome of one or more continuous variables defined within a Measure Observation. Measure Population Exclusions are used in Continuous Variable measures to help narrow the Measure Population.
- Initial Population: Identify those cases that meet the Initial Population criteria.
- Measure Population: Identify that subset of the Initial Population that meets the Measure Population criteria.
- Measure Population Exclusion: Identify that subset of the Measure Population that meets the Measure Population Exclusion criteria.

Here is an example of using the population types to select data on emergency department patients for a Continuous Variable measure:
- Initial Population: Patient had an emergency department (ED) encounter
- Measure Population: Same as Initial Population
- Measure Population Exclusion: Patient had an inpatient encounter that was within 6 hours of the ED encounter or expired in the ED

##### Individual Observations


Individual Observations are calculated for each case in the Measure Population and not in the Measure Population Exclusion.

##### Measure Aggregates


Using individual observations for all cases in the Measure Population and not in the Measure Population Exclusion, calculate the aggregate Measure Population.
```
Score = aggregate Measure Population

```


##### Calculation


Snippet 3-28 provides precise semantics for the measure score calculation for a continuous variable measure:
```
define "Measure Population Membership":
 "Initial Population"
 intersect "Measure Population"
 except "Measure Population Exclusion"

define "Measure Score":
 Avg("Measure Population Membership" PopulationMember
 return "Median ED Time"(PopulationMember)
 )

```


Snippet 3-28: Continuous variable measure scoring semantics

#### Cohort Definitions


For cohort definitions, only the Initial Population criteria type is used. For patient-based cohort definitions, the criteria should return a true or false (or null). For other types of cohort definitions, the criteria may return any type.

In a cohort measure, a population is identified from the population of all items being counted. For example, one might identify all the patients who have had H1N1 symptoms. The identified population is very similar to the Initial Population but is called a Cohort Population for public health purposes. In the Constrained Information Model (CIM), the population will be expressed using the InitialPopulationCriteria act. The Cohort Population result is used by public health agencies to trigger specific public health activities. The following diagram depicts the population for a Cohort measure and the table below provides its definition.

**Conformance Requirement 3.15 (Cohort Definitions): **
- Cohort Measures SHALL conform to the CQFMCohortMeasure profile

**Figure 3-6: Population criteria for Cohort measures illustration **

**Table 3-6: Population Criteria Definitions for Cohort Measures **Population Definition Initial Population All entities to be evaluated by a QM which may but are not required to share a common set of specified characteristics within a named measurement set to which the QM belongs. (Also known as a Cohort Population)
- Initial population: Identify those cases that meet the Initial Population criteria.

Here is an example of using the population types to select data on patients who have received immunizations for a Cohort measure:
- Initial Population: All patients who had an immunization

#### Attestation Measures


The measure is an attestation, derived from the base Measure , meaning that the reporter of the measure is attesting the measure score. This is typically used for true/false attestations, but can be used for other types of measure scores as well. The key distinction is that the measure is not computably represented (i.e. as a calculation or aggregation performed on some data in the reporting system), but rather is a simple assertion made by the measure reporter.

CQFMAttestationMeasure

#### Measures with Multiple Populations


The section discusses how to represent multiple rate measures where each rate is represented as a different `group`in the measure. Given a set of rates related to a particular topic, multiple rate measures can be used in cases where the rates are tightly related such that they all change (and therefore version) together. Examples include CMS 136 Follow-Up Care for Children Prescribed ADHD Medication (ADD) which looks for two rates depending on how long the patient remains on medication and the number of follow up visits performed.

For those cases where the rate specifications change independently, using an individual measure for each rate is the recommended approach.

When a measure has multiple population groups (multiple group elements), the criteria names will follow the convention above, adding the number of the population group to each criterion, e.g. "Initial Population 1", "Denominator 1", etc. Note that when multiple population groups are present, the number of the group is added to all population groups, not just the groups other than the first.

For multiple population ratio measures that specify 2 initial populations, the populations would be named with an additional "_X" to distinguish the initial populations, e.g. "Initial Population 1_1", "Initial Population 1_2", "Initial Population 2_1", "Initial Population 2_2".

**Conformance Requirement 3.16 (Multiple Population Indexing): **
- When specifying multiple populations and/or multiple population groups the following naming scheme SHALL be used
```
(Criteria Name) (population group number)( population number)

```


Note when a measure has a single population group but multiple populations (such as a ratio measure), the underscore ("_") is dropped. For example, "Initial Population 1", "Initial Population 2" refers to the populations NOT population groups.

Note also that when a measure has multiple population groups, the expectation is that the measure would have multiple scores, one for each population group. The formulas for calculation of the groups do not change; they are the same as for single group measures, just calculated using the criteria for each group.

#### Stratification


**Conformance Requirement 3.17 (Stratification Criteria): **
- Stratifier criteria expression SHALL result in either
 - the same type as other population criteria expressions in the measure (i.e. the population basis), or
 - the stratum value
- If component stratifiers are used, all the component expressions SHALL return the same type within a stratifier (i.e. within a stratifier, all the component expression must use the same stratification approach)

Stratification is represented using the `stratifier`element. The semantics of this element are unchanged from the base Measure specification.

Snippet 3-29 shows an example stratifier that stratifies results for two sub-populations. Snippet 3-30 shows the CQL representation of the stratifier.
```
"stratifier": [
 {
 "identifier": {
 "value": "stratifier-1-identifier"
 },
 "criteria": {
 "language": "text/cql-identifier",
 "expression": "Stratification 1"
 }
 }
]

```


Snippet 3-29: Example Stratifier from measure-exm55-FHIR.json
```
define "Stratification 1":
 "Inpatient Encounter" Encounter
 where not (PrincipalDiagnosis(Encounter).code in "Psychiatric/Mental Health Patient")

```


Snippet 3-30: Example Stratifier from EXM55.cql

Alternatively, the stratifier expression may return the actual stratum value:
```
define "Gender Stratification":
 Patient.gender

```


Snippet 3-31: Example of stratification by gender

If component stratifiers are used and the component expressions return the same type as other population criteria expressions in the measure, population semantics are applied to determine the stratifier population (i.e. true/false for patient-based measures, intersection of events for non-patient-based measures). If component stratifiers are used and the component expressions return the stratum value, the combination of the component values are considered the stratum value.

For example, given the following two component stratifier expressions in a patient-based measure:
```
define "Gender Stratification":
 Patient.gender

define "Payer Stratification":
 Coverage.type

```


Snippet 3-32: Stratification by gender and payer type

The stratum value for a given Patient would be the combination of gender and payer type.

#### Supplemental Data Elements


**Conformance Requirement 3.18 (Supplemental Data Elements): **
- Supplemental Data Elements SHALL be included within the supplementalData element using a usage element of supplemental-data.
- Supplemental Data Elements SHOULD reference a single expression definition, with a name beginning with SDE.
- Supplemental data element criteria expressions MAY be of any type, including lists

Part of the definition of a quality measure involves the ability to specify additional information to be returned for each member of a population. Within a FHIR-based QM, these supplemental data elements are specified using expressions, typically involving patient characteristics (such as Race, Ethnicity, Payer, and Administrative Sex) and then marking them with an SDE code within the FHIR Measure resource. Snippet 3-33 demonstrates an example supplemental data definition using the `supplementalData`element.
```
"supplementalData": [
 {
 "identifier": {
 "value": "supplemental-data-id-1"
 },
 "usage": {
 "coding": [
 {
 "code": "supplemental-data"
 }
 ],
 "text": "Supplemental Data"
 },
 "criteria": {
 "language": "text/cql-identifier",
 "expression": "SDE Ethnicity"
 }
 }
]

```


Snippet 3-33: Sample Supplemental Data Elements from measure-EXM146-FHIR.json
```
define "SDE Ethnicity":
 (flatten (
 Patient.extension Extension
 where Extension.url = 'http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity'
 return Extension.extension
 )) E
 where E.url = 'ombCategory'
 or E.url = 'detailed'
 return E.value as Coding

```


Snippet 3-34: Example Supplemental Data Element from Library-SupplementalDataElements

With CQL, supplemental data elements are specified using the same mechanism as any other population criteria, by defining an expression that returns the appropriate data element, and then identifying that expression within the Measure resource. Examples of the Measure resource and CQL are given in Snippet 3-33 and Snippet 3-34, respectively.

By convention, the name of each supplemental data element expression should start with "SDE". The supplemental data element expressions are normally expected to return a single value when evaluated in the context of a member of the population. For example, patient-based measures would return the value of a supplemental data element for a given patient. However, there are cases where returning multiple elements for supplemental data is useful. For example, collecting observations related to a particular condition. The intent of this conformance requirement is to simplify implementation of supplemental data collection, so care should be taken when using supplemental data elements that return multiple elements.

#### Risk Adjustment


**Conformance Requirement 3.19 (Risk Adjustment Criteria): **
- Risk Adjustment Data SHALL be included within the supplementalData element using a usage element of risk-adjustment-factor
- Risk Adjustment Data SHOULD reference a single CQL expression definition, with a name beginning with RAF

Measures may define variables used to adjust scores based on a measure of “risk” observed in the population. Such variables are referred to as risk adjustment data. Risk adjustment data are included in the supplementalData section and may be defined using CQL; such inclusions must adhere to Conformance Requirement 3.19.
```
"supplementalData": [
 {
 "identifier": {
 "value": "supplemental-data-id-1"
 },
 "usage": {
 "coding": [
 {
 "code": "risk-adjustment-factor"
 }
 ],
 "text": "Risk Adjustment Data"
 },
 "criteria": {
 "language": "text/cql-identifier",
 "expression": "Hepatic Failure"
 }
 }
]

```


Snippet 3-35: Sample Risk Adjustment Data from EXMRiskAdjustment_FHIR.xml
```
define "Hepatic Failure":
 exists ("Cirrhosis Dx")
 and exists ("Bilirubin Test")
 and exists ("Serum Albumin Test")

```


Snippet 3-36: Sample Risk Adjustment data from EXMRiskAdjustment_FHIR2.cql

An example of risk adjustment can be found in the included examples ; the relevant sections of the FHIR Measure (Snippet 3-35) and CQL (Snippet 3-36) have been included.

### Manifest


Measure specifications are often developed, tested, published, and consumed as a set of measures, rather than as single measure specifications. This implementation guide makes use of the *artifact manifest *capabilities provided by the Canonical Resource Management Infrastructure implementation guide to support the use case of developing and publishing a set of measures. For background, see the Artifact Manifest topic.

At a high level, the contents of the Library resource used to describe the set of measures consists of:
- Identity - Elements that identify the measure collection (e.g. `url`, `version`, `name`, `title`, `identifier`)
- Component Measures - The identified measures (specified using `relatedArtifact`elements with `type`= `composed-of`)
- Expansion Parameters - Input information about what versions of code systems and value sets should be used and how expansions should be performed (using the cqf-expansionParameters extension)
- Dependencies - Output information about all the dependencies that are used by the set of measures (specified using `relatedArtifact`elements with `type`= `depends-on`)

This information about the set of measures is supported by the CRMIManifestLibrary profile and can be generally thought of as a *content release *.

#### Content Release


Ultimately, the content release use case is supported by a manifest in *active *status, with all dependency information present. However, this final state is typically reached through an authoring process that allows for consistent resolution of dependencies by a team of measure developers. For example, a typical process might include the following steps:
- Setup
- Development
- Testing
- Release
- Implementation
>

NOTE: The examples referenced in this section have URLs based on their IDs. This is due to a publisher requirement; the examples are intended to illustrate the same Library at different points in the lifecycle, so the URLs should all be the same.

##### Setup


The setup phase establishes the initial code system versions for use with the measures being developed. At this stage, manifest is in *draft *status, and typically only a handful of code system versions have been selected. In addition, authoring-specific behavior such as *includeDraft *and *activeOnly *would be expected to be set. See the Manifest - Initial Draft for an example of an initial draft of a manifest. Note also that at this stage, the specific measures being developed are not necessarily known, so the example in this case does not refer to any measures.

##### Development


Throughout the development phase, as additional code system versions are identified, these may be added to the expansion parameters in the manifest. The manifest remains in *draft *status through the development, and may change as often as is necessary. The key benefit is allowing code system versions to be established among a team (or teams) of measure developers, and only updated when agreed by the participants.

##### Testing


The testing phase allows for a "final draft" of the manifest. At this point, all code system versions have been identified, all component measures are known, and authoring features such as *includeDraft *and *activeOnly *are typically disabled, allowing testing to be performed with the final expected value set expansions. The manifest is still in *draft *status, but the content at this point is expected to be stable and only subject to minor updates based on feedback from testing. See the Manifest - Final Draft for an example of a final draft of a manifest.

##### Release


The release process supports transitioning a manifest from *draft *to *active *status, and establishes the versions of all dependencies referenced by the measures in the manifest, according to the following process:
- For each component measure of the manifest, identify all dependencies:
 - If the dependency reference is versioned, record that version of the dependency in the manifest
 - Otherwise, if the version of the dependency is specified via an expansion parameter, use that version and record it as a dependency in the manifest
 - Otherwise, identify the most recent available version of the dependency in the authoring environment and record that version in the manifest
- For each reported dependency, identify all dependencies:
 - If the dependency is a measure, use the effective data requirements
 - If the dependency is a value set, report any value sets or code systems referenced by the value set as dependencies
 - Record each dependency in the manifest using the same process for determining a version and recording the dependency in the manifest

See the Manifest - Release for an example of a final content release. Note that the dependencies in this example are incomplete for brevity. A complete content release will include all dependencies for all measures, recursively, with versions identified for each dependency.

##### Implementation


During implementation, the Manifest is used to understand what versions of dependencies should be used when unversioned references are encountered. For example, when evaluating a Measure, the ValueSet expansions used are obtained by referring to the Manifest to determine the correct version of the ValueSet to be used, as well as the expansion parameters to be used.

#### Content Release Manifest Use Cases


A content release can be used to meet many different use cases for packaging a collection of related artifacts. Example use cases include:
- The eCQM Annual Update, specifying a set of measure specifications together with the code system and value set version information that is to be used to calculate the measures.
- Identifying sets of measures for a particular use, such as the Quality Payment Program (QPP) measures.
- Publishing a release of a set of value sets such as the C-CDA value sets, or the electronic Case Reporting (eCR) Public Health Trigger Codes.

In all these cases, a Library conforming to the CRMIManifestLibrary profile can be used to communicate the details of the content release.

### HQMF Mapping


HQMF is a normative HL7 V3 based standard that defines a header for classification and management of the quality measure, a document body that carries the content of the quality measure as well as important metadata. It standardizes a measure’s structure, metadata, definitions, and logic, the HQMF ensures measure consistency and unambiguous interpretation. The approach of representing Quality Measures (QMs) using FHIR and specifically the FHIR Clinical Reasoning Module have generated code systems and value sets based on the FHIR R4 specification.

Refer to the ConceptMap Resources section under "Terminology" for the concept mapping of code systems and value sets between HL7 V3 to FHIR R4.

### Attribution


Member Attribution (ATR) lists are often used between Payers and Providers for implementing risk-based contracts, value-based contracts, care gap closures and quality reporting. Creation of a Member Attribution List typically starts with a need to identify the patients for a specific purpose such as Quality Reporting. Refer to the Member Attribution Lists Workflows and Definitions within the Da Vinci - Member Attribution (ATR) List IG for more information on representing groups of patients for attribution within quality reporting.

### Must Support


Certain elements in the profiles defined in this implementation guide are marked as *Must Support *. This flag is used to indicate that the element plays a critical role in defining and sharing quality measures, and implementations SHALL understand and process the element.

In addition, because measure specifications typically make use of data implementation guides (e.g. US Core, QI-Core), the implications of the Must Support flag for profiles used from those implementation guides must be considered.

For more information, see the definition of Must Support in the base FHIR specification.

**Conformance Requirement 3.20 (Must Support Elements): **

For resource instances claiming to conform to Quality Measure IG profiles, Must Support on any profile data element SHALL be interpreted as follows:
- Authoring systems and knowledge repositories SHALL be capable of populating all Must Support data elements.
- Evaluating systems SHALL be capable of processing resource instances containing Must Support data elements without generating an error or causing the evaluation to fail.
- In situations where information on a particular data element is not present and the reason for absence is unknown, authoring and repository systems SHALL NOT include the data elements in the resource instance.
 - For example, for systems using '9999' to indicate unknown data values, do not include '9999' in the resource instance.
- When consuming resource instances, evaluating systems SHALL interpret missing data elements within resource instances as data not present for the artifact.
- Submitting and receiving systems using Quality Measure artifacts to perform data exchange or artifact evaluation operations SHALL respect the must support requirements of the profiles used by the artifact to describe the data involved in the operation.
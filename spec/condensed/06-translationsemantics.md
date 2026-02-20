Publication Build: This will be filled in by the publication tooling

## Translation Semantics
*Page standards status: *Normative Maturity Level : N


- CQL-to-ELM
- ELM-to-CQL

As discussed in the introductory section, this specification covers three levels of definition, the Conceptual or Author level, the Logical level, and the Physical level. The Conceptual level is concerned with the representation of logic in a format suitable for authoring and consumption by clinical experts; the Physical level is concerned with the representation of logic in a format suitable for processing and transferring by machines; and the Logical level is concerned with providing a mapping between the Conceptual and Physical levels in a way that preserves the semantics of the logic represented while also enabling integration and execution functionality.

To achieve these goals, the Logical level establishes a semantically complete bi-directional mapping between the Conceptual and Physical levels. This chapter describes this mapping in more detail, and sketches a process for translation from the Conceptual to the Logical, and from the Logical to the Conceptual. The Physical level is an isomorphic concrete realization of the Logical level; translation between the Logical and Physical levels is therefore a matter of serialization and realization of the data model, and is covered in detail in the Physical Representation chapter.

### CQL-to-ELM


Every statement of CQL has a semantically equivalent representation in ELM. As such, it is possible to programmatically translate any statement of CQL into its equivalent ELM representation. The following sections define the mappings between the language elements of CQL and their equivalent ELM representations, as well as providing a sketch for how these mappings could be used to translate from CQL to ELM.

#### Declarations


In both CQL and ELM, the basic container for all declarations is the *Library *. In CQL, a library corresponds to a single source document, usually represented as a text file. In ELM, a library is represented as a single instance of the *Library *class which contains all the declarations for the library.

The identifier and version of the library are set as part of the library metadata.

The following table specifies the ELM equivalent for each CQL declaration:

CQL Declaration ELM Equivalent library Library using UsingDef include IncludeDef codesystem CodeSystemDef valueset ValueSetDef parameter ParameterDef define ExpressionDef function FunctionDef

Table 6‑A - The ELM equivalent for each CQL declaration

#### Types


To represent types, CQL uses the *type-specifier *construct. In ELM, an equivalent TypeSpecifier abstract class is defined, with appropriate subclasses to represent the various types of specifiers, as detailed in the following table:

CQL Specifier ELM Equivalent ***named-type-specifier ***NamedTypeSpecifier ***interval-type-specifier ***IntervalTypeSpecifier ***list-type-specifier ***ListTypeSpecifier ***tuple-type-specifier ***TupleTypeSpecifier ***choice-type-specifier ***ChoiceTypeSpecifier

Table 6‑B - The ELM equivalent for each CQL type-specifier

Note that for named type specifiers, the name of the type is a qualified identifier, with the qualifier representing the name of the data model that defines the type. For example, the system-defined integer type in CQL is named System.Integer, with System as the name of the data model, and Integer as the name of the type.

#### Literals and Selectors


The following table defines the mapping between the various CQL literals and their equivalent representation in ELM:

CQL Literal ELM Equivalent null Null ***boolean-literal ***Boolean ***integer-literal ***Literal (valueType="Integer") ***long-literal ***Literal (valueType="Long") ***decimal-literal ***Literal (valueType="Decimal") ***quantity-literal ***Quantity ***ratio-literal ***Ratio ***string-literal ***Literal (valueType="String") ***date-literal ***Date ***date-time-literal ***DateTime ***time-literal ***Time ***interval-selector ***Interval ***list-selector ***List ***tuple-selector ***Tuple ***instance-selector ***Instance

Table 6‑C - The ELM equivalent for each CQL Literal

#### Functions


Most of the functions and operations available in CQL have a direct counterpart in ELM. For ease of reference, the operations and functions are grouped the same way they are in the CQL Reference.

##### Logical Operators


CQL Operator ELM Equivalent and And not Not or Or xor Xor implies Implies

Table 6‑D - The ELM equivalent for each CQL logical operator

##### Type Operators


CQL Operator ELM Equivalent as As convert Convert is Is Children Children Descendants Descendants

Table 6‑E - The ELM equivalent for each CQL type operator

Note that for supported conversions, a more efficient implementation would be to emit a specific operator to perform the conversion, rather than a generic Convert as specified here. For example, consider the following CQL conversion expression:

convert B to String

Rather than emitting a *Convert *, an implementation could emit a *ToString *which took an integer parameter. This would prevent the run-time type check required for implementation of a general purpose *Convert *operator.

Note also that when translating to ELM, an implementation could emit all implicit conversions directly, avoiding the need for an ELM translator or execution engine to deal with implicit conversion.

##### Nullological Operators


CQL Operator ELM Equivalent Coalesce Coalesce is null IsNull is false IsFalse is true IsTrue

Table 6‑F - The ELM equivalent for each CQL nullological operator

##### Comparison Operators


CQL Operator ELM Equivalent between And of comparisons (for point types) or IncludedIn (for Interval types) = Equal > Greater >= GreaterOrEqual < Less <= LessOrEqual ~ Equivalent != NotEqual !~ Not of Equivalent

Table 6‑G - The ELM equivalent for each CQL comparison operator

##### Arithmetic Operators


CQL Operator ELM Equivalent Abs Abs + Add Ceiling Ceiling / Divide Floor Floor Exp Exp Log Log Ln Ln maximum MaxValue minimum MinValue mod Modulo * Multiply - **(unary minus) **Negate predecessor Predecessor ^ Power Round Round - Subtract successor Successor Truncate Truncate div TruncatedDivide

Table 6‑H - The ELM equivalent for each CQL arithmetic operator

##### String Operators


CQL Operator ELM Equivalent Combine Combine + , & Concatenate (when & is used, a Coalesce(X, ‘’) is applied to each operand EndsWith EndsWith [] Indexer LastPositionOf LastPositionOf Length Length Lower Lower Matches Matches PositionOf PositionOf ReplaceMatches ReplaceMatches Split Split StartsWith StartsWith Substring Substring Upper Upper

Table 6‑I - The ELM equivalent for each CQL String operator

##### Date and Time Operators


CQL Operator ELM Equivalent + Add after After before Before Date Date DateTime DateTime ***component ***from DateTimeComponentFrom difference .. between DifferenceBetween duration .. between DurationBetween Now Now same as SameAs same or after SameOrAfter same or before SameOrBefore - Subtract Time Time TimeOfDay TimeOfDay Today Today

Table 6‑J - The ELM equivalent for each CQL Date and Time operator

##### Interval Operators


CQL Operator ELM Equivalent after After before Before collapse Collapse contains Contains end of End ends Ends = Equal except Except in In includes Includes during IncludedIn included in IncludedIn intersect Intersect ~ Equivalent meets Meets meets after MeetsAfter meets before MeetsBefore != NotEqual !~ Not of Equivalent overlaps Overlaps on or after SameOrAfter on or before SameOrBefore overlaps after OverlapsAfter overlaps before OverlapsBefore point from PointFrom properly includes ProperlyIncludes properly included in ProperlyIncludedIn properly during ProperlyIncludedIn start of Start starts Starts union Union width of Width

Table 6‑K - The ELM equivalent for each CQL Interval operator

##### List Operators


CQL Operator ELM Equivalent contains Contains distinct Distinct = Equal except Except exists Exists flatten Flatten First First in In includes Includes included in IncludedIn [] Indexer IndexOf IndexOf intersect Intersect Last Last Length Length ~ Equivalent != NotEqual !~ Not of Equivalent properly includes ProperlyIncludes properly included in ProperlyIncludedIn singleton from SingletonFrom Skip(n) Slice(n, null) Tail Slice(1, null) Take(n) Slice(0, n) union Union

Table 6‑L - The ELM equivalent for each CQL List operator

##### Aggregate Operators


CQL Operator ELM Equivalent AllTrue AllTrue AnyTrue AnyTrue Avg Avg Count Count GeometricMean GeometricMean Max Max Min Min Median Median Mode Mode PopulationStdDev PopulationStdDev PopulationVariance PopulationVariance Product Product StdDev StdDev Sum Sum Variance Variance

Table 6‑M - The ELM equivalent for each CQL aggegrate operator

##### Clinical Operators


CQL Operator ELM Equivalent AgeIn **-precision **CalculateAge (with patient birthdate reference supplied) AgeIn **-precision- **At CalculateAgeAt (with patient birthdate reference supplied) CalculateAgeIn **-precision **CalculateAge CalculateAgeIn **-precision- **At CalculateAgeAt = Equal ~ Equivalent in **(Codesystem) **InCodeSystem in **(Valueset) **InValueSet

Table 6‑N - The ELM equivalent for each CQL clinical operator

#### Phrases


In general, the various phrases of CQL do not have a direct representation in ELM, but rather result in operator and function invocations which then do have representations. For more information, see the Timing Phrases section.

#### Queries


The CQL query construct has a direct representation in ELM, as shown by the following table:

CQL Construct ELM Equivalent ***query ***Query ***aliased-query-source ***AliasedQuerySource ***let-clause ***LetClause ***with-clause ***With ***without-clause ***Without ***where-clause ***Query (where element) ***return-clause ***ReturnClause ***aggregtate-clause ***AggregateClause ***sort-clause ***SortClause

Table 6‑O - The ELM equivalent for each CQL construct

Although these elements can be used to directly represent the *query *construct of CQL, it is also possible to represent queries using a series of equivalent operations that simplify implementation. ELM defines simplified operations specifically for this purpose. See the Implementing Query Evaluation section for more information on how to transform any given CQL query into an equivalent representation using these operators.

#### Translation Options


There are several points throughout the specification that introduce optionality to support different use cases and implementation goals. This section provides a summary of those options with an explanation of their impact on translation and language features.
>

Note that implementations may define other options as appropriate for their translation use cases, but these options all potentially impact whether a given library of CQL can be correctly compiled, and should therefore be used with care. Implementations that make use of these options should provide facilities for ensuring that these options are communicated as part of the resulting ELM output, as well as that the appropriate options are used if the CQL library is re-translated by consuming environments.

##### Disable List Promotion and Demotion


List promotion and demotion are a special case of implicit conversions and enable list-valued expressions to be passed to singleton parameters (by invoking the singleton from operator) and vice-versa (by invoking the ToList function). These conversions are useful for writing expressions against models with deeply nested hierarchies and variable cardinality elements, but can sometimes result in surprising overload selections and conversion choices. As a result, implementations may choose to enable or disable this language feature using the *disable-list-promotion *and *disable-list-demotion *options. For a more detailed discussion, see List Promotion and Demotion .

##### Disable List Traversal


In addition to list promotion and demotion, CQL allows for paths to be traversed through list-valued elements. Again, this is useful when writing expressions against models with variable cardinality elements, and can be disabled with the *disable-list-traversal *option. For a more detailed discussion, see Path Traversal .

##### Disable Method Invocation


To support FHIRPath as the base expression language for CQL, beginning with 1.3, the option to allow functions to be invoked using method-style invocation was introduced. This feature can be disabled using the *disable-method-invocation *option. For a more complete discussion, see Method Invocation .
>

Note that with the introduction of Fluent Functions in 1.5, using this option effectively disables fluent functions as well.

##### Require From Keyword


To encourage consistent use of the from keyword to being queries, implementations may provide support for the *require-from-keyword *option. See Query Syntax Options for more discussion.

### ELM-to-CQL


In addition to being able to translate CQL to ELM, any given expression of ELM can be represented in CQL. Support for this direction of translation would be useful for applications that produce ELM from another source, and need to display a human-readable representation of the logic.

This bi-directionality means that a given expression of CQL could be translated to ELM, and then back again. However, because ELM is typically a more primitive representation, this process is not necessarily a “round-trip”. For example, consider the following CQL:
```
A starts within 3 days of start B

```


This will actually result in the following ELM output:
```
<expression xsi:type="In">
 <operand xsi:type="DurationBetween" precision="Day">
 <operand xsi:type="Start">
 <operand xsi:type="ExpressionRef" name="A"/>
 </operand>
 <operand xsi:type="Start">
 <operand xsi:type="ExpressionRef" name="B"/>
 </operand>
 </operand>
 <operand xsi:type="Interval">
 <low xsi:type="Literal" valueType="xs:int" value="-3"/>
 <high xsi:type="Literal" valueType="xs:int" value="3"/>
 </operand>
</expression>

```


The above expression, rendered directly back to CQL would be:
```
days between start of A and start of B in [-3, 3]

```


These expressions are semantically equivalent, but not syntactically the same, as the first is targeted at understandability, while the second is targeted at implementation. To preserve “round-trip” capability, an implementation could emit annotations with the ELM using the extension mechanism of the base *Element *class to provide the original source CQL.

In general, the mapping from ELM to CQL is simply the opposite of the mapping described in the previous section. However, there are several special-purpose operators that are only defined in ELM which are used to simplify query implementation. For completeness, the mappings from those operators to CQL are described here to ensure that any given ELM document could be translated to CQL.

The examples in the following section will make use of the following expression definitions:
```
<def name="List1">
 <expression xsi:type="List">
 <element xsi:type="Tuple">
 <element name="X">
 <value xsi:type="Literal" valueType="xs:int" value="1"/>
 </element>
 </element>
 <element xsi:type="Tuple">
 <element name="X">
 <value xsi:type="Literal" valueType="xs:int" value="2"/>
 </element>
 </element>
 <element xsi:type="Tuple">
 <element name="X">
 <value xsi:type="Literal" valueType="xs:int" value="3"/>
 </element>
 </element>
 </expression>
</def>
<def name="List2">
 <expression xsi:type="List">
 <element xsi:type="Tuple">
 <element name="Y">
 <value xsi:type="Literal" valueType="xs:int" value="1"/>
 </element>
 </element>
 <element xsi:type="Tuple">
 <element name="Y">
 <value xsi:type="Literal" valueType="xs:int" value="2"/>
 </element>
 </element>
 <element xsi:type="Tuple">
 <element name="Y">
 <value xsi:type="Literal" valueType="xs:int" value="3"/>
 </element>
 </element>
 </expression>
</def>

```


#### ForEach


The *ForEach *operator in ELM takes an argument of type list and returns a list with an element for each source element that is the result of evaluating the *element *expression. For example:
```
<expression xsi:type="ForEach">
 <source xsi:type="ExpressionRef" name="List1"/>
 <element xsi:type="Property" path="X"/>
</expression>

```


This expression returns the list of integers from the List1 expression. Although there is no direct counterpart in CQL, this expression can be represented using the *query *construct. The source for the *ForEach *is used as the primary query source, and the *element *expression is represented using the *return-clause *:
```
List1 A return A.X

```


#### Times


The *Times *operator in ELM computes the Cartesian-product of two lists. Again, although there is no direct counterpart in CQL, the *query *construct can be used to produce an equivalent result:
```
<expression xsi:type="Times">
 <source xsi:type="ExpressionRef" name="List1"/>
 <source xsi:type="ExpressionRef" name="List2"/>
</expression>

```


Assuming List1 and List2 are defined as specified above, the equivalent CQL is a multi-source query with a source for each operand in the *Times *, and a return clause that builds the resulting tuples:
```
from List1 A, List2 B
 return { X: A.X, Y: B.Y }

```


#### Filter


The *Filter *operator in ELM filters the contents of a list, returning only those elements that satisfy the expression defined in the *condition *element. For example:
```
<expression xsi:type="Filter">
 <source xsi:type="ExpressionRef" name="List1"/>
 <condition xsi:type="Equal">
 <operand xsi:type="Property" path="X">
 <operand xsi:type="Literal" valueType="xs:int" value="1"/>
 </condition>
</expression>

```


Again, although no direct counterpart in CQL exists, the *where *clause of the *query *construct provides the equivalent functionality:
```
List1 A where A.X = 1

```


#### Sort


The *Sort *operator in ELM sorts the contents of a list. For example:
```
<expression xsi:type="Sort">
 <source xsi:type="ExpressionRef" name="List1"/>
 <by xsi:type="ByColumn" path="X" direction="desc"/>
</expression>

```


Again, the CQL query construct provides the equivalent functionality:
```
List1 A sort by X desc

```
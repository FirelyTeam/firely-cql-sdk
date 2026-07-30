Publication Build: This will be filled in by the publication tooling

## Appendix F - Glossary
*Page standards status: *Informative Maturity Level : N/A

**canonical representation **– As used within the CQL specification, this term means a representation of information in terms of primitives. For example, CQL contains high-level constructs such as timing phrases that are intended to allow natural language expression of timing relationships. The canonical representation of these constructs involves equivalent expression in terms of more primitive constructs targeted at implementation and integration applications.

**clinical statement **– Within the CQL specification, the term clinical statement is used to refer to the representation of clinical information in terms of a specific data model. For example, an instance of a FHIR Condition resource is a clinical statement asserting a condition for a subject in some status. Clinical statements are the content that CQL reasons about.

**ELM **– Expression Logical Model is a UML specification for representing artifact logic independent of syntax and special-purpose constructs introduced at the syntactic level. It is intended to enable distribution and sharing of computable quality logic.

**FHIR® **– Fast Healthcare Interoperability Resources (hl7.org/fhir) – is a next generation standards framework created by HL7. FHIR combines the best features of HL7’s Version 2, Version 3 and CDA® product lines while leveraging the latest web standards and applying a tight focus on implementability.

**FHIR Profile **– A FHIR Profile is a statement of use of one or more FHIR Resources. It may include constraints on Resources and Data Types, Terminology Binding Statements and Extension Definitions. See the FHIR documentation for more information.

**nullological **– A category of operations for dealing with missing information. The term is actually due to Hugh Darwen, who introduced it in a paper to describe the behavior of operations in edge cases (e.g. empty sets or strings of length zero) and given his long history of opposing the use of “nulls” in relational systems, would probably not be pleased with the way the term has been co-opted in this context.

**quality vendor **– A company or organization that provides commercially available health quality services, such as distribution of quality-related knowledge artifacts, integration of quality measurement and improvement functionality, or provision of health quality evaluation services.

**query **– Within CQL, the term query refers to a specific language construct that forms the basis for expressing logic involving lists of clinical statements within an artifact. A query may use any or all of various clauses to describe the types of operations to be performed, and returns a list of values that can be used directly, or serve as the input to other queries.

**retrieve **– Within CQL, the term retrieve refers to a specific language construct used to access clinical statements within an artifact.

**shaping **– Within CQL, the term shaping refers to the operation performed by the return clause of a query, which allows the shape of the resulting values of the query to be described.

**three-valued logic (3VL) **– A logic system prevalent within SQL-based Database Management Systems (DBMSs) that is defined using three values, TRUE, FALSE, and UNKNOWN, as opposed to traditional boolean-valued logic systems that involve only two values, TRUE and FALSE. The system is used as a mechanism for reasoning in the presence of missing information. Within CQL, the three values are represented by the language keywords true, false, and null.

**tuple **– Within CQL, a tuple is the basic construct for representing structured values, with each tuple value consisting of a set of tuple elements, each of which has a name and a value. Tuples in CQL are analogous to records, or structs, in traditional programming languages, and rows in database programming languages. They are used within CQL to represent class instances from object-oriented data models, as well as XML or JSON instances.

**type **– Within CQL, the term type refers to a conceptual component of the language that defines a set of values that are all of that same type. For example, Integer is a type and is defined as the set of all integer values within a specific range, specifically the signed integers that can be represented using two’s complement binary notation with a 32-bit word.

**uncertainty **– Conceptually, the notion that a value is present, but not precisely known. Formally within CQL implementation contexts, uncertainty is represented using closed intervals to describe the range of possible values.

**value **– Within CQL, the term value refers to a piece of data of some type. For example, the value 5 is of type Integer. Values are immutable, meaning they do not change over time.

**valueset **– Within CQL, a valueset allows logic to reference externally defined value sets.
Publication Build: This will be filled in by the publication tooling

## Appendix G - Formatting Conventions
*Page standards status: *Informative Maturity Level : N/A


- Case-Related Conventions
- Spacing Conventions
- Operators and Functions
- Literals
- Queries
- Syntax Highlighting
- Best Practices

This guidance describes syntactic conventions and best practices for authoring statements and expressions of Clinical Quality Language (CQL) that encourage consistency, readability, maintainability, and reusability of the resulting CQL. Throughout the discussion, the following simplified syntax element definitions are used. Formal definitions of these elements can be found in the CQL Specification.
- *Whitespace *- Whitespace defines the separation between all tokens in the language (e.g. spaces, tabs, returns, etc.)
- *Comment *- Comments are ignored by the language, allowing for descriptive text to be included
- *Literal *- Literals allow basic values to be represented within the language
- *Symbol *- Symbols such as + , - , * , and /
- *Keyword *- Grammar-recognized keywords such as define and where
- *Identifier *- User-defined identifiers

### Case-Related Conventions


CQL is a case-sensitive language, meaning that the grammar uses the case of letters when comparing identifiers and keywords. For example, the keyword define must be expressed with all lower case letters, Define is not recognized. This aspect of CQL encourages consistency and reduces the potential for naming clashes with keywords in the language.

This discussion defines the following terms to describe different approaches to casing:
- lowercase - All letters are lowercase
- camelCase - First letters of words are capitalized, except the first word, with no whitespace characters allowed
- PascalCase - First letters of words are capitalized, including words not capitalized in Title Case like "and" and "of", with no whitespace characters allowed
- Title Case - Standard title casing including spaces and tabs, but no other whitespace characters allowed

#### CQL-Defined Casing


These casings are defined by the specification, so they are not conventions per se, but are highlighted here for completeness.

Keywords within CQL are always lowercase.

System library functions are always PascalCase.

System type names are always PascalCase.

### Spacing Conventions


CQL treats all whitespace as a single token, meaning that it doesn't matter whether you use spaces or tabs to separate keywords and other tokens, so long as you have some whitespace as defined by the rules of the language. This allows authors to format their expressions using whatever conventions are appropriate for their environment. While this flexibility is beneficial in that it allows CQL to be used in a wide variety of settings, it can also lead to inconsistent formatting, reducing readability. As such, these simple conventions are recommended to ensure consistent formatting:

It is possible to use either tabs or multiple spaces to indent, each having advantages and disadvantages. However, authors must remain consistent within a library, avoiding using both tabs and spaces to indent simultaneously.

Indent using a single tab or a consistent number of spaces for related content. This makes it visually clear where the dependencies are in any given expression and helps to organize statements and clauses.

Always use a space after a comma. This helps to visually separate items in a list.

Never use a space before or after a period. The period in CQL is a qualifier, and adding whitespace disconnects the content visually, implying a separation that is not present.

To help maintain readability of CQL, lines should fit reasonably within standard view screens. Around 100 characters per line is a good rule of thumb.

### Operators and Functions


CQL distinguishes between *operators *, which use symbols such as + , * , and and, and *functions *, which use identifiers followed by parentheses to provide the arguments to the function.

#### Operators


Operators are always keywords, and always lowercase.

Binary operators (operators with two arguments) are always infix.

Unary operators (operators with one argument) are always prefix.

Always use a space before and after operators.

#### Functions


When defining a function, always use a PascalCase identifier.

Functions always use parentheses, even if the function has no arguments.

If the function has no arguments, do not put a space between the parentheses.

Never put a space between the function name and the argument list, or between the opening and closing parentheses and the arguments.

Always use spaces after commas to separate arguments.

If necessary, an argument list can be continued across multiple lines, but keep the opening parenthesis on the same line as the function identifier, and indent subsequent lines one level.

When continuing an argument list, do not attempt to right-align indented content, as this leads to unnecessary maintenance to preserve the alignment.

### Literals


Literals in CQL allow for the expression of values of each of the system-defined types.

#### Quantities


For Quantities, always put a space between the numerical value and the unit:
```
45 'mg'
28 'mm[Hg]'

```


#### Intervals


Intervals can be expressed based on any type that supports ordered comparison (Integer, Decimal, DateTime, Time, Quantity).

Intervals use standard mathematical notation to indicate whether the boundaries are open or closed:
```
Interval[1, 5]
Interval(1, 9)
Interval[@2015-01-01T00:00:00.0Z, @2016-01-01T00:00:00.0Z)

```


Never put a space before or after the opening or closing boundary.

Always put a space after the comma.

#### Lists and Tuples


Lists in CQL can contain elements of any type.

Always separate the contents of the list with a space to help visually distinguish the braces from parentheses:
```
{ 1, 2, 3 }
Sum({ 1, 2, 3 })

```


Tuples in CQL contain named elements of any type.

Always separate the contents of the tuple with a space:
```
{ name: 'Patrick', birthDate: @2014-01-01 }

```


Do not put a space between the tuple element name and the value specifier ( : ), but always put a space between the value specifier and the value.

The Tuple keyword is optional, but this means that the empty tuple has a special construct:
```
{ } // empty list
{ : } // empty Tuple

```


### Queries


The central expression construct of CQL is the query. The query construct in CQL is clause-based:
```
<primary source> <alias>
 <with or without clauses>
 <where clause>
 <return clause>
 <sort clause>

```


In general, simple queries can fit on a single line:
```
["Encounter, Performed": "Inpatient"] Encounter where duration in days of Encounter.period >= 120

```


If a query, or a clause of a query, needs more than one line, continue the clauses indented beneath the query or clause:
```
"Pharyngitis Encounters with Antibiotics" Pharyngitis
 with ["Laboratory Test, Performed": "Group A Streptococcus Test"] Test
 such that Test.result is not null
 and Test.startDateTime in Interval[Pharyngitis.startTime - 3 days, Pharyngitis.stopDateTime + 3 days]

```


When a query needs multiple lines, each clause should start on a new line indented one level.

### Syntax Highlighting


Syntax highlighting is an important aspect of readability. In order to enable different environments to provide consistent highlighting, the following syntactic categories are defined for CQL:
- Symbols
- Keywords
- Operators
- Literals
 - Numbers
 - Strings
 - Dates and Times
- Comments
- Identifiers
 - Type Identifiers
 - Variable Identifiers
 - Function Identifiers

### Best Practices


The following sections discuss best practices for authoring readable, maintainable, and reusable CQL.

#### Direct Reference Codes


Using "direct reference codes", involves declaring an identifier for a specific code in a code system, and using that directly within the logic. That's appropriate for cases where you know exactly what you want, and there's very little possibility for variation on that (i.e. systems are likely to use those codes directly, rather than have local codes that they are mapping to).

When using direct reference codes, authors should use the name of the code as defined externally to avoid introducing any potential confusion of meaning:
```
code "Venous foot pump, device (physical object)": '442023007' from "SNOMED-CT"

```


Note that for direct reference code usage, the local identifier (in the example above, the local identifier is "Venous foot pump, device (physical object)") should be the same as the description of the code within the terminology in order to avoid conflicting with any usage or license agreements with the referenced terminologies, but can be different to allow for potential naming conflicts, as well as simplification of longer names when appropriate.

Although CQL supports both version-specific and version-independent specification of and comparison to direct reference codes, artifact authors should use version-independent direct reference codes and comparisons unless there is a specific reason not to (such as the code is retired in the current code system version). Even when using version-specific direct reference codes, authors should use equivalence (~) for the comparison (again, unless there is a specific reason to use version-specific comparison with equality (=)).

Note: Using direct reference codes can be more difficult for implementations to map to local settings, because modification of the codes for local usage may require modification of the CQL, as opposed to the use of a value set which many systems already use to provide support for mapping to local codes.
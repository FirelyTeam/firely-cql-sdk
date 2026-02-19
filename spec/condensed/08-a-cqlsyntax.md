Publication Build: This will be filled in by the publication tooling

## Appendix A - CQL Syntax
*Page standards status: *Normative Maturity Level : N


- Declarations
- Type Specifiers
- Statements
- Queries
- Expressions
- Terms
- Lexer Rules

The formal specification for the CQL syntax is defined using the ANTLR4 grammar framework. This framework is a general purpose cross-platform technology for describing computer languages. For more information on this framework, refer to the ANTLR website .

The material in this section is necessarily technical and assumes familiarity with language definition in general, and ANTLR4 grammars in particular. In addition, the g4 presented here is somewhat simplified for ease of reference and is provided for informative use only. For the complete, normative g4 definition, refer to the CQL.g4 and fhirpath.g4 files included with the specification package.

For a visual representation of the syntax of CQL, refer to Appendix L - CQL Syntax Diagrams .

### Declarations


The CQL grammar is defined in an ANTLR4 grammar file, CQL.g4. The root production rule is *library *, which specifies the overall structure for a library file:
```
library
 :
 libraryDefinition?
 definition*
 statement*
 EOF
 ;

```


Other than *statement *, these production rules define the declarations available for a library.
```
libraryDefinition
 : 'library' qualifiedIdentifier ('version' versionSpecifier)?
 ;

definition
 : usingDefinition
 | includeDefinition
 | codesystemDefinition
 | valuesetDefinition
 | codeDefinition
 | conceptDefinition
 | parameterDefinition
 ;

usingDefinition
 : 'using' modelIdentifier ('version' versionSpecifier)?
 ;

includeDefinition
 : 'include' qualifiedIdentifier ('version' versionSpecifier)? ('called' localIdentifier)?
 ;

localIdentifier
 : identifier
 ;

accessModifier
 : 'public'
 | 'private'
 ;

parameterDefinition
 : accessModifier? 'parameter' identifier (typeSpecifier)? ('default' expression)?
 ;

codesystemDefinition
 : accessModifier? 'codesystem' identifier ':' codesystemId ('version' versionSpecifier)?
 ;

valuesetDefinition
 : accessModifier? 'valueset' identifier ':' valuesetId ('version' versionSpecifier)? codesystems?
 ;

codesystems
 : 'codesystems' '{' codesystemIdentifier (',' codesystemIdentifier)* '}'
 ;

codesystemIdentifier
 : (libraryIdentifier '.')? identifier
 ;

libraryIdentifier
 : identifier
 ;

codeDefinition
 : accessModifier? 'code' identifier ':' codeId 'from' codesystemIdentifier displayClause?
 ;

conceptDefinition
 : accessModifier? 'concept' identifier ':' '{' codeIdentifier (',' codeIdentifier)* '}' displayClause?
 ;

codeIdentifier
 : (libraryIdentifier '.')? identifier
 ;

codesystemId
 : STRING
 ;

valuesetId
 : STRING
 ;

versionSpecifier
 : STRING
 ;

codeId
 : STRING
 ;

```


### Type Specifiers


The *typeSpecifier *production rule defines all type specifiers available in the language.
```
typeSpecifier
 : namedTypeSpecifier
 | listTypeSpecifier
 | intervalTypeSpecifier
 | tupleTypeSpecifier
 | choiceTypeSpecifier
 ;

namedTypeSpecifier
 : (qualifier '.')* referentialOrTypeNameIdentifier
 ;

modelIdentifier
 : identifier
 ;

listTypeSpecifier
 : 'List' '<' typeSpecifier '>'
 ;

intervalTypeSpecifier
 : 'Interval' '<' typeSpecifier '>'
 ;

tupleTypeSpecifier
 : 'Tuple' '{' tupleElementDefinition (',' tupleElementDefinition)* '}'
 ;

tupleElementDefinition
 : referentialIdentifier typeSpecifier
 ;

choiceTypeSpecifier
 : 'Choice' '<' typeSpecifier (',' typeSpecifier)* '>'
 ;

```


### Statements


The main body of the library then consists of any number of statements, defined by the *statement *production rule:
```
statement
 : expressionDefinition
 | contextDefinition
 | functionDefinition
 ;

expressionDefinition
 : 'define' accessModifier? identifier ':' expression
 ;

contextDefinition
 : 'context' (modelIdentifier '.')? identifier
 ;

functionDefinition
 : 'define' accessModifier? 'fluent'? 'function' identifierOrFunctionIdentifier '(' (operandDefinition (',' operandDefinition)*)? ')'
 ('returns' typeSpecifier)?
 ':' (functionBody | 'external')
 ;

operandDefinition
 : referentialIdentifier typeSpecifier
 ;

functionBody
 : expression
 ;

```


### Queries


The *query *production rule defines the syntax for queries within CQL:
```
querySource
 : retrieve
 | qualifiedIdentifierExpression
 | '(' expression ')'
 ;

aliasedQuerySource
 : querySource alias
 ;

alias
 : identifier
 ;

queryInclusionClause
 : withClause
 | withoutClause
 ;

withClause
 : 'with' aliasedQuerySource 'such that' expression
 ;

withoutClause
 : 'without' aliasedQuerySource 'such that' expression
 ;

retrieve
 : '[' (contextIdentifier '->')? namedTypeSpecifier (':' (codePath codeComparator)? terminology)? ']'
 ;

contextIdentifier
 : qualifiedIdentifierExpression
 ;

codePath
 : simplePath
 ;

codeComparator
 : 'in'
 | '='
 | '~'
 ;

terminology
 : qualifiedIdentifierExpression
 | expression
 ;

qualifier
 : identifier
 ;

query
 : sourceClause letClause? queryInclusionClause* whereClause? (returnClause | aggregateClause)? sortClause?
 ;

sourceClause
 : 'from'? aliasedQuerySource (',' aliasedQuerySource)*
 ;

letClause
 : 'let' letClauseItem (',' letClauseItem)*
 ;

letClauseItem
 : identifier ':' expression
 ;

whereClause
 : 'where' expression
 ;

returnClause
 : 'return' ('all' | 'distinct')? expression
 ;

aggregateClause
 : 'aggregate' ('all' | 'distinct')? identifier startingClause? ':' expression
 ;

startingClause
 : 'starting' (simpleLiteral | quantity | ('(' expression ')'))
 ;

sortClause
 : 'sort' ( sortDirection | ('by' sortByItem (',' sortByItem)*) )
 ;

sortDirection
 : 'asc' | 'ascending'
 | 'desc' | 'descending'
 ;

sortByItem
 : expressionTerm sortDirection?
 ;

qualifiedIdentifier
 : (qualifier '.')* identifier
 ;

qualifiedIdentifierExpression
 : (qualifierExpression '.')* referentialIdentifier
 ;

qualifierExpression
 : referentialIdentifier
 ;

simplePath
 : referentialIdentifier #simplePathReferentialIdentifier
 | simplePath '.' referentialIdentifier #simplePathQualifiedIdentifier
 | simplePath '[' simpleLiteral ']' #simplePathIndexer
 ;

simpleLiteral
 : STRING #simpleStringLiteral
 | NUMBER #simpleNumberLiteral
 ;


```


### Expressions


The *expression *production rule defines the syntax for all expressions within CQL:
```
expression
 : expressionTerm #termExpression
 | retrieve #retrieveExpression
 | query #queryExpression
 | expression 'is' 'not'? ('null' | 'true' | 'false') #booleanExpression
 | expression ('is' | 'as') typeSpecifier #typeExpression
 | 'cast' expression 'as' typeSpecifier #castExpression
 | 'not' expression #notExpression
 | 'exists' expression #existenceExpression
 | expression 'properly'? 'between' expressionTerm 'and' expressionTerm #betweenExpression
 | ('duration' 'in')? pluralDateTimePrecision 'between' expressionTerm 'and' expressionTerm #durationBetweenExpression
 | 'difference' 'in' pluralDateTimePrecision 'between' expressionTerm 'and' expressionTerm #differenceBetweenExpression
 | expression ('|' | 'union' | 'intersect' | 'except') expression #inFixSetExpression
 | expression ('<=' | '<' | '>' | '>=') expression #inequalityExpression
 | expression intervalOperatorPhrase expression #timingExpression
 | expression ('=' | '!=' | '~' | '!~') expression #equalityExpression
 | expression ('in' | 'contains') dateTimePrecisionSpecifier? expression #membershipExpression
 | expression 'and' expression #andExpression
 | expression ('or' | 'xor') expression #orExpression
 | expression 'implies' expression #impliesExpression
 ;

dateTimePrecision
 : 'year' | 'month' | 'week' | 'day' | 'hour' | 'minute' | 'second' | 'millisecond'
 ;

dateTimeComponent
 : dateTimePrecision
 | 'date'
 | 'time'
 | 'timezoneoffset'
 ;

pluralDateTimePrecision
 : 'years' | 'months' | 'weeks' | 'days' | 'hours' | 'minutes' | 'seconds' | 'milliseconds'
 ;

expressionTerm
 : term #termExpressionTerm
 | expressionTerm '.' qualifiedInvocation #invocationExpressionTerm
 | expressionTerm '[' expression ']' #indexedExpressionTerm
 | 'convert' expression 'to' (typeSpecifier | unit) #conversionExpressionTerm
 | ('+' | '-') expressionTerm #polarityExpressionTerm
 | ('start' | 'end') 'of' expressionTerm #timeBoundaryExpressionTerm
 | dateTimeComponent 'from' expressionTerm #timeUnitExpressionTerm
 | 'duration' 'in' pluralDateTimePrecision 'of' expressionTerm #durationExpressionTerm
 | 'difference' 'in' pluralDateTimePrecision 'of' expressionTerm #differenceExpressionTerm
 | 'width' 'of' expressionTerm #widthExpressionTerm
 | 'successor' 'of' expressionTerm #successorExpressionTerm
 | 'predecessor' 'of' expressionTerm #predecessorExpressionTerm
 | 'singleton' 'from' expressionTerm #elementExtractorExpressionTerm
 | 'point' 'from' expressionTerm #pointExtractorExpressionTerm
 | ('minimum' | 'maximum') namedTypeSpecifier #typeExtentExpressionTerm
 | expressionTerm '^' expressionTerm #powerExpressionTerm
 | expressionTerm ('*' | '/' | 'div' | 'mod') expressionTerm #multiplicationExpressionTerm
 | expressionTerm ('+' | '-' | '&') expressionTerm #additionExpressionTerm
 | 'if' expression 'then' expression 'else' expression #ifThenElseExpressionTerm
 | 'case' expression? caseExpressionItem+ 'else' expression 'end' #caseExpressionTerm
 | ('distinct' | 'collapse' | 'flatten') expression #aggregateExpressionTerm
 | 'expand' expression ('per' (dateTimePrecision | expression))? #expandExpressionTerm
 ;

caseExpressionItem
 : 'when' expression 'then' expression
 ;

dateTimePrecisionSpecifier
 : dateTimePrecision 'of'
 ;

relativeQualifier
 : 'or before'
 | 'or after'
 ;

offsetRelativeQualifier
 : 'or more'
 | 'or less'
 ;

exclusiveRelativeQualifier
 : 'less than'
 | 'more than'
 ;

quantityOffset
 : (quantity offsetRelativeQualifier?)
 | (exclusiveRelativeQualifier quantity)
 ;

temporalRelationship
 : ('on or'? ('before' | 'after'))
 | (('before' | 'after') 'or on'?)
 ;

intervalOperatorPhrase
 : ('starts' | 'ends' | 'occurs')? 'same' dateTimePrecision? (relativeQualifier | 'as') ('start' | 'end')? #concurrentWithIntervalOperatorPhrase
 | 'properly'? 'includes' dateTimePrecisionSpecifier? ('start' | 'end')? #includesIntervalOperatorPhrase
 | ('starts' | 'ends' | 'occurs')? 'properly'? ('during' | 'included in') dateTimePrecisionSpecifier? #includedInIntervalOperatorPhrase
 | ('starts' | 'ends' | 'occurs')? quantityOffset? temporalRelationship dateTimePrecisionSpecifier? ('start' | 'end')? #beforeOrAfterIntervalOperatorPhrase
 | ('starts' | 'ends' | 'occurs')? 'properly'? 'within' quantity 'of' ('start' | 'end')? #withinIntervalOperatorPhrase
 | 'meets' ('before' | 'after')? dateTimePrecisionSpecifier? #meetsIntervalOperatorPhrase
 | 'overlaps' ('before' | 'after')? dateTimePrecisionSpecifier? #overlapsIntervalOperatorPhrase
 | 'starts' dateTimePrecisionSpecifier? #startsIntervalOperatorPhrase
 | 'ends' dateTimePrecisionSpecifier? #endsIntervalOperatorPhrase
 ;

```


### Terms


The *term *production rule defines the syntax for core expression terms within CQL:
```
term
 : invocation #invocationTerm
 | literal #literalTerm
 | externalConstant #externalConstantTerm
 | intervalSelector #intervalSelectorTerm
 | tupleSelector #tupleSelectorTerm
 | instanceSelector #instanceSelectorTerm
 | listSelector #listSelectorTerm
 | codeSelector #codeSelectorTerm
 | conceptSelector #conceptSelectorTerm
 | '(' expression ')' #parenthesizedTerm
 ;

externalConstant
 : '%' identifier
 ;

qualifiedInvocation // Terms that can be used after the function/member invocation '.'
 : referentialIdentifier #qualifiedMemberInvocation
 | qualifiedFunction #qualifiedFunctionInvocation
 ;

qualifiedFunction
 : identifierOrFunctionIdentifier '(' paramList? ')'
 ;

invocation
 : referentialIdentifier #memberInvocation
 | function #functionInvocation
 | '$this' #thisInvocation
 | '$index' #indexInvocation
 | '$total' #totalInvocation
 ;

function
 : referentialIdentifier '(' paramList? ')'
 ;

paramList
 : expression (',' expression)*
 ;

quantity
 : NUMBER unit?
 ;

unit
 : dateTimePrecision
 | pluralDateTimePrecision
 | STRING // UCUM syntax for units of measure
 ;

ratio
 : quantity ':' quantity
 ;

literal
 : ('true' | 'false') #booleanLiteral
 | 'null' #nullLiteral
 | STRING #stringLiteral
 | NUMBER #numberLiteral
 | LONGNUMBER #longNumberLiteral
 | DATETIME #dateTimeLiteral
 | DATE #dateLiteral
 | TIME #timeLiteral
 | quantity #quantityLiteral
 | ratio #ratioLiteral
 ;

intervalSelector
 'Interval' ('['|'(') expression ',' expression (']'|')')
 ;

tupleSelector
 : 'Tuple'? '{' (':' | (tupleElementSelector (',' tupleElementSelector)*)) '}'
 ;

tupleElementSelector
 : referentialIdentifier ':' expression
 ;

instanceSelector
 : namedTypeSpecifier '{' (':' | (instanceElementSelector (',' instanceElementSelector)*)) '}'
 ;

instanceElementSelector
 : referentialIdentifier ':' expression
 ;

listSelector
 : ('List' ('<' typeSpecifier '>')?)? '{' (expression (',' expression)*)? '}'
 ;

displayClause
 : 'display' STRING
 ;

codeSelector
 : 'Code' STRING 'from' codesystemIdentifier displayClause?
 ;

conceptSelector
 : 'Concept' '{' codeSelector (',' codeSelector)* '}' displayClause?
 ;

keyword
 : 'after'
 | 'aggregate'
 | 'all'
 | 'and'
 | 'as'
 | 'asc'
 | 'ascending'
 | 'before'
 | 'between'
 | 'by'
 | 'called'
 | 'case'
 | 'cast'
 | 'code'
 | 'Code'
 | 'codesystem'
 | 'codesystems'
 | 'collapse'
 | 'concept'
 | 'Concept'
 | 'contains'
 | 'context'
 | 'convert'
 | 'date'
 | 'day'
 | 'days'
 | 'default'
 | 'define'
 | 'desc'
 | 'descending'
 | 'difference'
 | 'display'
 | 'distinct'
 | 'div'
 | 'duration'
 | 'during'
 | 'else'
 | 'end'
 | 'ends'
 | 'except'
 | 'exists'
 | 'expand'
 | 'false'
 | 'flatten'
 | 'fluent'
 | 'from'
 | 'function'
 | 'hour'
 | 'hours'
 | 'if'
 | 'implies'
 | 'in'
 | 'include'
 | 'includes'
 | 'included in'
 | 'intersect'
 | 'Interval'
 | 'is'
 | 'let'
 | 'library'
 | 'List'
 | 'maximum'
 | 'meets'
 | 'millisecond'
 | 'milliseconds'
 | 'minimum'
 | 'minute'
 | 'minutes'
 | 'mod'
 | 'month'
 | 'months'
 | 'not'
 | 'null'
 | 'occurs'
 | 'of'
		| 'on or'
 | 'or'
 | 'or after'
 | 'or before'
 | 'or less'
 | 'or more'
		| 'or on'
 | 'overlaps'
 | 'parameter'
 | 'per'
 | 'point'
 | 'predecessor'
 | 'private'
 | 'properly'
 | 'public'
 | 'return'
 | 'same'
 | 'second'
 | 'seconds'
 | 'singleton'
 | 'start'
 | 'starts'
 | 'starting'
 | 'sort'
 | 'successor'
 | 'such that'
 | 'then'
 | 'time'
 | 'timezoneoffset'
 | 'to'
 | 'true'
 | 'Tuple'
 | 'union'
 | 'using'
 | 'valueset'
 | 'version'
 | 'week'
 | 'weeks'
 | 'where'
 | 'when'
 | 'width'
 | 'with'
 | 'within'
 | 'without'
 | 'xor'
 | 'year'
 | 'years'
 ;

reservedWord
 : 'aggregate'
 | 'all'
 | 'and'
 | 'as'
 | 'after'
 | 'before'
 | 'between'
 | 'case'
 | 'cast'
 | 'Code'
 | 'collapse'
 | 'Concept'
 | 'convert'
 | 'day'
 | 'days'
 | 'difference'
 | 'distinct'
 | 'duration'
 | 'during'
 | 'else'
 | 'exists'
 | 'expand'
 | 'false'
 | 'flatten'
 | 'from'
 | 'if'
 | 'in'
 | 'included in'
 | 'is'
 | 'hour'
 | 'hours'
 | 'Interval'
 | 'let'
 | 'List'
 | 'maximum'
 | 'millisecond'
 | 'milliseconds'
 | 'minimum'
 | 'minute'
 | 'minutes'
 | 'month'
 | 'months'
 | 'not'
 | 'null'
 | 'occurs'
 | 'of'
 | 'on or'
 | 'or'
 | 'or on'
 | 'per'
 | 'point'
 | 'properly'
 | 'return'
 | 'same'
 | 'second'
 | 'seconds'
 | 'singleton'
 | 'sort'
 | 'such that'
 | 'then'
 | 'to'
 | 'true'
 | 'Tuple'
 | 'week'
 | 'weeks'
 | 'when'
 | 'with'
 | 'within'
 | 'without'
 | 'year'
 | 'years'
 ;

// Keyword identifiers are keywords that may be used as identifiers in a referential context
// Effectively, keyword except reservedWord
keywordIdentifier
 : 'asc'
 | 'ascending'
 | 'by'
 | 'called'
 | 'code'
 | 'codesystem'
 | 'codesystems'
 | 'concept'
 | 'contains'
 | 'context'
 | 'date'
 | 'default'
 | 'define'
 | 'desc'
 | 'descending'
 | 'display'
 | 'div'
 | 'end'
 | 'ends'
 | 'except'
 | 'fluent'
 | 'function'
 | 'implies'
 | 'include'
 | 'includes'
 | 'intersect'
 | 'library'
 | 'meets'
 | 'mod'
 | 'or after'
 | 'or before'
 | 'or less'
 | 'or more'
 | 'overlaps'
 | 'parameter'
 | 'predecessor'
 | 'private'
 | 'public'
 | 'start'
 | 'starting'
 | 'starts'
 | 'successor'
 | 'time'
 | 'timezoneoffset'
 | 'union'
 | 'using'
 | 'valueset'
 | 'version'
 | 'where'
 | 'width'
 | 'xor'
 ;

// Obsolete identifiers are keywords that could be used as identifiers in CQL 1.3
// NOTE: Not currently used, this is the set of keywords that were defined as allowed identifiers as part of 1.3
obsoleteIdentifier
 : 'all'
 | 'Code'
 | 'code'
 | 'Concept'
 | 'concept'
 | 'contains'
 | 'date'
 | 'display'
 | 'distinct'
 | 'end'
 | 'exists'
 | 'not'
 | 'start'
 | 'time'
 | 'timezoneoffset'
 | 'version'
 | 'where'
 ;

// Function identifiers are keywords that may be used as identifiers for functions
functionIdentifier
 : 'after'
 | 'aggregate'
 | 'all'
 | 'and'
 | 'as'
 | 'asc'
 | 'ascending'
 | 'before'
 | 'between'
 | 'by'
 | 'called'
 | 'case'
 | 'cast'
 | 'code'
 | 'Code'
 | 'codesystem'
 | 'codesystems'
 | 'collapse'
 | 'concept'
 | 'Concept'
 | 'contains'
 | 'context'
 | 'convert'
 | 'date'
 | 'day'
 | 'days'
 | 'default'
 | 'define'
 | 'desc'
 | 'descending'
 | 'difference'
 | 'display'
 | 'distinct'
 | 'div'
 | 'duration'
 | 'during'
 | 'else'
 | 'end'
 | 'ends'
 | 'except'
 | 'exists'
 | 'expand'
 | 'false'
 | 'flatten'
 | 'fluent'
 | 'from'
 | 'function'
 | 'hour'
 | 'hours'
 | 'if'
 | 'implies'
 | 'in'
 | 'include'
 | 'includes'
 | 'included in'
 | 'intersect'
 | 'Interval'
 | 'is'
 | 'let'
 | 'library'
 | 'List'
 | 'maximum'
 | 'meets'
 | 'millisecond'
 | 'milliseconds'
 | 'minimum'
 | 'minute'
 | 'minutes'
 | 'mod'
 | 'month'
 | 'months'
 | 'not'
 | 'null'
 | 'occurs'
 | 'of'
 | 'or'
 | 'or after'
 | 'or before'
 | 'or less'
 | 'or more'
 | 'overlaps'
 | 'parameter'
 | 'per'
 | 'point'
 | 'predecessor'
 | 'private'
 | 'properly'
 | 'public'
 | 'return'
 | 'same'
 | 'singleton'
 | 'second'
 | 'seconds'
 | 'start'
 | 'starting'
 | 'starts'
 | 'sort'
 | 'successor'
 | 'such that'
 | 'then'
 | 'time'
 | 'timezoneoffset'
 | 'to'
 | 'true'
 | 'Tuple'
 | 'union'
 | 'using'
 | 'valueset'
 | 'version'
 | 'week'
 | 'weeks'
 | 'where'
 | 'when'
 | 'width'
 | 'with'
 | 'within'
 | 'without'
 | 'xor'
 | 'year'
 | 'years'
 ;

// Reserved words that are also type names
typeNameIdentifier
 : 'Code'
 | 'Concept'
 | 'date'
 | 'time'
 ;

referentialIdentifier
 : identifier
 | keywordIdentifier
 ;

referentialOrTypeNameIdentifier
 : referentialIdentifier
 | typeNameIdentifier
 ;

identifierOrFunctionIdentifier
 : identifier
 | functionIdentifier
 ;

identifier
 : IDENTIFIER
 | DELIMITEDIDENTIFIER
 | QUOTEDIDENTIFIER
 ;

```


### Lexer Rules


The lexer rules define the terminal production rules in the language:
```
DATE
 : '@' DATEFORMAT
 ;

DATETIME
 : '@' DATEFORMAT 'T' TIMEFORMAT? TIMEZONEOFFSETFORMAT?
 ;

TIME
 : '@' 'T' TIMEFORMAT
 ;

fragment DATEFORMAT
 : [0-9][0-9][0-9][0-9] ('-'[0-9][0-9] ('-'[0-9][0-9])?)?
 ;

fragment TIMEFORMAT
 : [0-9][0-9] (':'[0-9][0-9] (':'[0-9][0-9] ('.'[0-9]+)?)?)?
 ;

fragment TIMEZONEOFFSETFORMAT
 : ('Z' | ('+' | '-') [0-9][0-9]':'[0-9][0-9])
 ;

IDENTIFIER
 : ([A-Za-z] | '_')([A-Za-z0-9] | '_')* // Added _ to support CQL (FHIR could constrain it out)
 ;

DELIMITEDIDENTIFIER
 : '`' (ESC | .)*? '`'
 ;

QUOTEDIDENTIFIER
 : '"' (ESC | .)*? '"'
 ;

STRING
 : '\'' (ESC | .)*? '\''
 ;

// Also allows leading zeroes now (just like CQL and XSD)
NUMBER
 : [0-9]+('.' [0-9]+)?
 ;

LONGNUMBER
 : [0-9]+'L'
 ;

// Pipe whitespace to the HIDDEN channel to support retrieving source text through the parser.
WS
 : [ \r\n\t]+ -> channel(HIDDEN)
 ;

COMMENT
 : '/*' .*? '*/' -> channel(HIDDEN)
 ;

LINE_COMMENT
 : '//' ~[\r\n]* -> channel(HIDDEN)
 ;

fragment ESC
 : '\\' ([`'"\\/fnrt] | UNICODE) // allow \`, \', \", \\, \/, \f, etc. and \uXXX
 ;

fragment UNICODE
 : 'u' HEX HEX HEX HEX
 ;

fragment HEX
 : [0-9a-fA-F]
 ;

```
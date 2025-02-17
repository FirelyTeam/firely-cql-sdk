grammar cql;

/*
 Clinical Quality Language Grammar Specification
 Version 2.0 - Trial Use
 */

modelDefinitions: usingDefinition | typeDefinition;

model: modelDefinition modelDefinitions* EOF;

modelDefinition:
	'model' qualifiedIdentifier 'version' versionSpecifier ':' modelUri;

modelUri: STRING;

typeDefinition:
	literalTypeDefinition
	| classTypeDefinition
	| genericTypeDefinition;

literalTypeDefinition:
	'define' accessModifier? 'literal' 'type' identifier baseType?;

classTypeDefinition:
	'define' accessModifier? 'type' identifier baseType? '{' classElements? '}';

classElements: classElement (',' classElement)*;

classElement: identifier typeSpecifier;

baseType: 'extends' baseTypeSpecifier;

baseTypeSpecifier: namedTypeSpecifier | genericTypeSpecifier;

genericTypeDefinition:
	'define' accessModifier? 'generic' 'type' identifier '<' genericArguments '>' baseType?
		genericTypeConstraint* '{' classElements? '}';

genericArguments: identifier (',' identifier)*;

genericTypeConstraint: 'where' identifier 'is' typeSpecifier;

/*
 * Library
 */
libraryDefinitions:
	usingDefinition
	| includeDefinition
	| codesystemDefinition
	| valuesetDefinition
	| codeDefinition
	| conceptDefinition
	| parameterDefinition;

library: libraryDefinition libraryDefinitions* EOF;

libraryDefinition:
	'library' qualifiedIdentifier ('version' versionSpecifier)?;

usingDefinition:
	'using' qualifiedIdentifier ('version' versionSpecifier)? (
		'called' localIdentifier
	)?;

includeDefinition:
	'include' qualifiedIdentifier ('version' versionSpecifier)? (
		'called' localIdentifier
	)?;

localIdentifier: identifier;

accessModifier: 'public' | 'private';

parameterDefinition:
	accessModifier? 'parameter' identifier (typeSpecifier)? (
		'default' expression
	)?;

codesystemDefinition:
	accessModifier? 'codesystem' identifier ':' codesystemId (
		'version' versionSpecifier
	)?;

valuesetDefinition:
	accessModifier? 'valueset' identifier ':' valuesetId (
		'version' versionSpecifier
	)? codesystems?;

codesystems:
	'codesystems' '{' codesystemIdentifier (
		',' codesystemIdentifier
	)* '}';

codesystemIdentifier: (libraryIdentifier '.')? identifier;

libraryIdentifier: identifier;

codeDefinition:
	accessModifier? 'code' identifier ':' codeId 'from' codesystemIdentifier displayClause?;

conceptDefinition:
	accessModifier? 'concept' identifier ':' '{' codeIdentifier (
		',' codeIdentifier
	)* '}' displayClause?;

qualifiedIdentifier: identifier ('.' identifier)*;

identifier:
	IDENTIFIER
	| DELIMITEDIDENTIFIER
	| QUOTEDIDENTIFIER
	| keywordIdentifier;

keywordIdentifier: 'code' | 'version' | 'display';

codeIdentifier: (libraryIdentifier '.')? identifier;

codesystemId: STRING;

valuesetId: STRING;

versionSpecifier: STRING;

codeId: STRING;

displayClause: 'display' STRING;

typeSpecifier:
	choiceTypeSpecifier
	| tupleTypeSpecifier
	| genericTypeSpecifier
	| namedTypeSpecifier;

choiceTypeSpecifier:
	'Choice' '<' typeSpecifier (',' typeSpecifier)* '>';

tupleTypeSpecifier:
	'Tuple' '{' tupleElementDefinition (
		',' tupleElementDefinition
	)* '}';

tupleElementDefinition: identifier typeSpecifier;

namedTypeSpecifier: qualifiedIdentifier;

genericTypeSpecifier:
	qualifiedIdentifier '<' typeSpecifier (',' typeSpecifier)* '>';

// expressions

expression:
	functionInvocation						# functionInvocationExpression
	| qualifiedIdentifier					# identifierExpression
	| '(' expression ')'					# parentheticalExpression
	| expression binaryOperator expression	# binaryExpression
	| literal								# literalExpression;

functionInvocation:
	qualifiedIdentifier '(' expression (',' expression)* ')' returnClause?;

returnClause: 'returns' typeSpecifier;

binaryOperator:
	'+'
	| '-'
	| '*'
	| '/'
	| '%'
	| '='
	| '!='
	| '<'
	| '<='
	| '>'
	| '>='
	| 'and'
	| 'or';

literal:
	'null'
	| 'true'
	| 'false'
	| STRING
	| NUMBER
	| DATE
	| DATETIME
	| TIME
	| quantity;

quantity: quantityValue unit;

quantityValue: NUMBER;

unit: STRING;

// lexicals

DATE: '@' DATEFORMAT;

DATETIME:
	'@' DATEFORMAT 'T' (TIMEFORMAT TIMEZONEOFFSETFORMAT?)?;

TIME: '@' 'T' TIMEFORMAT;

fragment DATEFORMAT:
	[0-9][0-9][0-9][0-9] ('-' [0-9][0-9] ('-' [0-9][0-9])?)?;

fragment TIMEFORMAT:
	[0-9][0-9] (':' [0-9][0-9] (':' [0-9][0-9] ('.' [0-9]+)?)?)?;

fragment TIMEZONEOFFSETFORMAT: (
		'Z'
		| ('+' | '-') [0-9][0-9]':' [0-9][0-9]
	);

IDENTIFIER: ([A-Za-z] | '_') ([A-Za-z0-9] | '_')*;
// Added _ to support CQL (FHIR could constrain it out)

QUOTEDIDENTIFIER: '"' (ESC | .)*? '"';

DELIMITEDIDENTIFIER: '`' (ESC | .)*? '`';

STRING: '\'' (ESC | .)*? '\'';

// Also allows leading zeroes now (just like CQL and XSD)
NUMBER: [0-9]+ ('.' [0-9]+)?;

// Pipe whitespace to the HIDDEN channel to support retrieving source text through the parser.
WS: [ \r\n\t]+ -> channel(HIDDEN);

COMMENT: '/*' .*? '*/' -> channel(HIDDEN);

LINE_COMMENT: '//' ~[\r\n]* -> channel(HIDDEN);

fragment ESC:
	'\\' ([`'\\/fnrt] | UNICODE); // allow \`, \', \\, \/, \f, etc. and \uXXX

fragment UNICODE: 'u' HEX HEX HEX HEX;

fragment HEX: [0-9a-fA-F];
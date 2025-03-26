grammar cql;

/*
 Clinical Quality Language Grammar Specification
 Version 2.0 - Trial Use
 */

modelDefinition: usingDefinition | typeDefinition;

modelStatement:
	functionDefinition
	| genericFunctionDefinition
	| operatorDefinition
	| genericOperatorDefinition
	| conversionDefinition;

model: modelIdentifier modelDefinition* modelStatement* EOF;

modelIdentifier:
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

operatorDefinition:
	'define' accessModifier? 'operator' overloadableOperator '(' operandDefinition (
		',' operandDefinition
	)* ')' returnClause? ':' functionBody;

genericOperatorDefinition:
	'define' accessModifier? fluent? 'generic' 'operator' overloadableOperator '<' genericArguments
		'>' '(' operandDefinition (',' operandDefinition)* ')' returnClause? ':' functionBody;

fluent: 'fluent';

functionDefinition:
	'define' accessModifier? fluent? 'function' identifier '(' operandDefinition (
		',' operandDefinition
	)* ')' returnClause? ':' functionBody;

genericFunctionDefinition:
	'define' accessModifier? 'generic' 'function' identifier '<' genericArguments '>' '('
		operandDefinition (',' operandDefinition)* ')' returnClause? ':' functionBody;

functionBody: expression | 'external';

overloadableOperator: binaryOperator;

operandDefinition: identifier typeSpecifier;

conversionDefinition:
	'define' accessModifier? conversionType 'conversion' 'from' fromType identifier 'to' toType ':'
		functionBody;

fromType: typeSpecifier;
toType: typeSpecifier;

conversionType: 'implicit' | 'explicit';

/*
 * Library
 */

libraryDefinition:
	usingDefinition
	| includeDefinition
	| codesystemDefinition
	| valuesetDefinition
	| codeDefinition
	| conceptDefinition
	| parameterDefinition;

libraryStatement:
	expressionDefinition
	| functionDefinition
	| genericFunctionDefinition
	| operatorDefinition
	| genericOperatorDefinition
	| conversionDefinition;

library:
	libraryIdentifier libraryDefinition* libraryStatement* EOF;

libraryIdentifier:
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
	'codesystems' '{' qualifiedIdentifier (
		',' qualifiedIdentifier
	)* '}';

codeDefinition:
	accessModifier? 'code' identifier ':' codeId 'from' codeSystemIdentifier displayClause?;

codeSystemIdentifier: qualifiedIdentifier;

conceptDefinition:
	accessModifier? 'concept' identifier ':' '{' codeSystemIdentifier (
		',' codeSystemIdentifier
	)* '}' displayClause?;

qualifiedIdentifier: identifier ('.' identifier)*;

identifier:
	IDENTIFIER
	| DELIMITEDIDENTIFIER
	| QUOTEDIDENTIFIER
	| keywordIdentifier;

keywordIdentifier: 'code' | 'version' | 'display';

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

expressionDefinition:
	'define' accessModifier? identifier asClause? ':' expression;

asClause: 'as' typeSpecifier;

// expressions

expression:
	functionInvocation										# functionInvocationExpression
	| qualifiedIdentifier									# identifierExpression
	| '(' expression ')'									# parentheticalExpression
	| 'if' expression 'then' expression 'else' expression	# ifThenElseExpression
	| expression binaryOperator expression					# binaryExpression
	| retrieve												# retrieveExpression
	| literal												# literalExpression;

functionInvocation:
	qualifiedIdentifier '(' expression (',' expression)* ')' returnClause?;

returnClause: 'returns' typeSpecifier;

binaryOperator:
	'+'		# addOperator
	| '-'	# subtractOperator
	| '*'	# multiplyOperator
	| '/'	# divideOperator
	| '%'	# modOperator
	| '='	# equalOperator
	| '!='	# notEqualOperator
	| '<'	# lessOperator
	| '<='	# lessEqualOperator
	| '>'	# greaterOperator
	| '>='	# greaterEqualOperator
	| 'and'	# andOperator
	| 'or'	# orOperator;

literal: ('true' | 'false')	# booleanLiteral
	| 'null'				# nullLiteral
	| STRING				# stringLiteral
	| NUMBER				# numberLiteral
	| LONGNUMBER			# longNumberLiteral
	| DATETIME				# dateTimeLiteral
	| DATE					# dateLiteral
	| TIME					# timeLiteral
	| quantity				# quantityLiteral
	| ratio					# ratioLiteral;

quantity: quantityValue unit;

quantityValue: NUMBER;

unit: STRING;

ratio: quantity ':' quantity;

retrieve:
	'[' (contextIdentifier '->')? namedTypeSpecifier (
		':' (codePath codeComparator)? terminology
	)? ']';

contextIdentifier: qualifiedIdentifier;
codePath: simplePath;
codeComparator: 'in' | '=' | '~';
terminology: expression;

simplePath:
	identifier
	| simplePath '.' identifier
	| simplePath '[' index ']';

index: STRING | NUMBER;

query:
	sourceClause letClause? queryInclusionClause* whereClause? (
		aggregateClause
		| returnClause
	)? sortClause?;

querySource:
	retrieve
	| qualifiedIdentifier
	| '(' expression ')';

aliasedQuerySource: querySource alias;

alias: identifier;

sourceClause:
	'from'? aliasedQuerySource (',' aliasedQuerySource)*;

letClause: 'let' letClauseItem (',' letClauseItem)*;

letClauseItem: identifier ':' expression;

queryInclusionClause: withClause | withoutClause;

withClause: 'with' aliasedQuerySource 'such' 'that' expression;

withoutClause:
	'without' aliasedQuerySource 'such' 'that' expression;

whereClause: 'where' expression;

aggregateClause:
	'aggregate' ('all' | 'distinct')? identifier startingClause? ':' expression;

startingValue: STRING | NUMBER;

startingClause:
	'starting' (startingValue | quantity | ('(' expression ')'));

sortClause:
	'sort' (sortDirection | ('by' sortByItem (',' sortByItem)*));

sortDirection: 'asc' | 'ascending' | 'desc' | 'descending';

sortByItem: expression sortDirection?;

// lexicals

DATE: '@' DATEFORMAT;

DATETIME:
	'@' DATEFORMAT 'T' (TIMEFORMAT TIMEZONEOFFSETFORMAT?)?;

LONGNUMBER: [0-9]+ 'L';

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
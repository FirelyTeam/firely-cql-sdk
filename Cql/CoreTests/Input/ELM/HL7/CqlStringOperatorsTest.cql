library CqlStringOperatorsTest

context Unfiltered


define "CombineNull Input":
	Combine(null)
define "CombineNull Output":
	null

define "CombineEmptyList Input":
	Combine({})
define "CombineEmptyList Output":
	''

define "CombineABC Input":
	Combine({'a', 'b', 'c'})
define "CombineABC Output":
	'abc'

define "CombineABCSepDash Input":
	Combine({'a', 'b', 'c'}, '-')
define "CombineABCSepDash Output":
	'a-b-c'

define "ConcatenateNullNull Input":
	Concatenate(null, null)
define "ConcatenateNullNull Output":
	null

define "ConcatenateANull Input":
	Concatenate('a', null)
define "ConcatenateANull Output":
	null

define "ConcatenateNullB Input":
	Concatenate(null, 'b')
define "ConcatenateNullB Output":
	null

define "ConcatenateAB Input":
	Concatenate('a', 'b')
define "ConcatenateAB Output":
	'ab'

define "ConcatenateABWithAdd Input":
	'a' + 'b'
define "ConcatenateABWithAdd Output":
	'ab'

define "EndsWithNull Input":
	EndsWith(null, null)
define "EndsWithNull Output":
	null

define "EndsWithTrue Input":
	EndsWith('Chris Schuler is the man!!', 'n!!')
define "EndsWithTrue Output":
	true

define "EndsWithFalse Input":
	EndsWith('Chris Schuler is the man!!', 'n!')
define "EndsWithFalse Output":
	false

define "IndexerNullNull Input":
	Indexer(null as String, null)
define "IndexerNullNull Output":
	null

define "IndexerANull Input":
	Indexer('a', null)
define "IndexerANull Output":
	null

define "IndexerNull1String Input":
	Indexer(null as String, 1)
define "IndexerNull1String Output":
	null

define "IndexerAB0 Input":
	Indexer('ab', 0)
define "IndexerAB0 Output":
	'a'

define "IndexerAB1 Input":
	Indexer('ab', 1)
define "IndexerAB1 Output":
	'b'

define "IndexerAB2 Input":
	Indexer('ab', 2)
define "IndexerAB2 Output":
	null

define "IndexerABNeg1 Input":
	Indexer('ab', -1)
define "IndexerABNeg1 Output":
	null

define "LastPositionOfNull Input":
	LastPositionOf(null, null)
define "LastPositionOfNull Output":
	null

define "LastPositionOfNull1 Input":
	LastPositionOf(null, 'hi')
define "LastPositionOfNull1 Output":
	null

define "LastPositionOfNull2 Input":
	LastPositionOf('hi', null)
define "LastPositionOfNull2 Output":
	null

define "LastPositionOf1 Input":
	LastPositionOf('hi', 'Ohio is the place to be!')
define "LastPositionOf1 Output":
	1

define "LastPositionOf2 Input":
	LastPositionOf('hi', 'Say hi to Ohio!')
define "LastPositionOf2 Output":
	11

define "LengthNullString Input":
	Length(null as String)
define "LengthNullString Output":
	null

define "LengthEmptyString Input":
	Length('')
define "LengthEmptyString Output":
	0

define "LengthA Input":
	Length('a')
define "LengthA Output":
	1

define "LengthAB Input":
	Length('ab')
define "LengthAB Output":
	2

define "LowerNull Input":
	Lower(null)
define "LowerNull Output":
	null

define "LowerEmpty Input":
	Lower('')
define "LowerEmpty Output":
	''

define "LowerA Input":
	Lower('A')
define "LowerA Output":
	'a'

define "LowerB Input":
	Lower('b')
define "LowerB Output":
	'b'

define "LowerAB Input":
	Lower('Ab')
define "LowerAB Output":
	'ab'

define "MatchesNull Input":
	Matches('Not all who wander are lost', null)
define "MatchesNull Output":
	null

define "MatchesNumberFalse Input":
	Matches('Not all who wander are lost', '.*\\d+')
define "MatchesNumberFalse Output":
	false

define "MatchesNumberTrue Input":
	Matches('Not all who wander are lost - circa 2017', '.*\\d+')
define "MatchesNumberTrue Output":
	true

define "MatchesAllTrue Input":
	Matches('Not all who wander are lost', '.*')
define "MatchesAllTrue Output":
	true

define "MatchesWordsAndSpacesTrue Input":
	Matches('Not all who wander are lost', '[\\w|\\s]+')
define "MatchesWordsAndSpacesTrue Output":
	true

define "MatchesWordsAndSpacesFalse Input":
	Matches('Not all who wander are lost - circa 2017', '[\\w]+')
define "MatchesWordsAndSpacesFalse Output":
	false

define "MatchesNotWords Input":
	Matches('   ', '\\W+')
define "MatchesNotWords Output":
	true

define "MatchesWhiteSpace Input":
	Matches(' \n\t', '\\s+')
define "MatchesWhiteSpace Output":
	true

define "PositionOfNullNull Input":
	PositionOf(null, null)
define "PositionOfNullNull Output":
	null

define "PositionOfANull Input":
	PositionOf('a', null)
define "PositionOfANull Output":
	null

define "PositionOfNullA Input":
	PositionOf(null, 'a')
define "PositionOfNullA Output":
	null

define "PositionOfAInAB Input":
	PositionOf('a', 'ab')
define "PositionOfAInAB Output":
	0

define "PositionOfBInAB Input":
	PositionOf('b', 'ab')
define "PositionOfBInAB Output":
	1

define "PositionOfCInAB Input":
	PositionOf('c', 'ab')
define "PositionOfCInAB Output":
	-1

define "ReplaceMatchesNull Input":
	ReplaceMatches('Not all who wander are lost', null, 'But I am...')
define "ReplaceMatchesNull Output":
	null

define "ReplaceMatchesAll Input":
	ReplaceMatches('Not all who wander are lost', 'Not all who wander are lost', 'But still waters run deep')
define "ReplaceMatchesAll Output":
	'But still waters run deep'

define "ReplaceMatchesMany Input":
	ReplaceMatches('Who put the bop in the bop she bop she bop?', 'bop', 'bang')
define "ReplaceMatchesMany Output":
	'Who put the bang in the bang she bang she bang?'

define "ReplaceMatchesSpaces Input":
	ReplaceMatches('All that glitters is not gold', '\\s', '\\$')
define "ReplaceMatchesSpaces Output":
	'All$that$glitters$is$not$gold'

define "SplitNullNull Input":
	Split(null, null)
define "SplitNullNull Output":
	null

define "SplitNullComma Input":
	Split(null, ',')
define "SplitNullComma Output":
	null

define "SplitABNull Input":
	Split('a,b', null)
define "SplitABNull Output":
	{'a,b'}

define "SplitABDash Input":
	Split('a,b', '-')
define "SplitABDash Output":
	{'a,b'}

define "SplitABComma Input":
	Split('a,b', ',')
define "SplitABComma Output":
	{'a','b'}

define "StartsWithNull Input":
	StartsWith(null, null)
define "StartsWithNull Output":
	null

define "StartsWithNull1 Input":
	StartsWith('hi', null)
define "StartsWithNull1 Output":
	null

define "StartsWithNull2 Input":
	StartsWith(null, 'hi')
define "StartsWithNull2 Output":
	null

define "StartsWithTrue1 Input":
	StartsWith('Breathe deep the gathering gloom', 'Bre')
define "StartsWithTrue1 Output":
	true

define "StartsWithFalse1 Input":
	StartsWith('Breathe deep the gathering gloom', 'bre')
define "StartsWithFalse1 Output":
	false

define "SubstringNullNull Input":
	Substring(null, null)
define "SubstringNullNull Output":
	null

define "SubstringANull Input":
	Substring('a', null)
define "SubstringANull Output":
	null

define "SubstringNull1 Input":
	Substring(null, 1)
define "SubstringNull1 Output":
	null

define "SubstringAB0 Input":
	Substring('ab', 0)
define "SubstringAB0 Output":
	'ab'

define "SubstringAB1 Input":
	Substring('ab', 1)
define "SubstringAB1 Output":
	'b'

define "SubstringAB2 Input":
	Substring('ab', 2)
define "SubstringAB2 Output":
	null

define "SubstringABNeg1 Input":
	Substring('ab', -1)
define "SubstringABNeg1 Output":
	null

define "SubstringAB0To1 Input":
	Substring('ab', 0, 1)
define "SubstringAB0To1 Output":
	'a'

define "SubstringABC1To1 Input":
	Substring('abc', 1, 1)
define "SubstringABC1To1 Output":
	'b'

define "SubstringAB0To3 Input":
	Substring('ab', 0, 3)
define "SubstringAB0To3 Output":
	'ab'

define "UpperNull Input":
	Upper(null)
define "UpperNull Output":
	null

define "UpperEmpty Input":
	Upper('')
define "UpperEmpty Output":
	''

define "UpperA Input":
	Upper('a')
define "UpperA Output":
	'A'

define "UpperB Input":
	Upper('B')
define "UpperB Output":
	'B'

define "UpperAB Input":
	Upper('aB')
define "UpperAB Output":
	'AB'

define "QuantityToString Input":
	ToString(125 'cm')
define "QuantityToString Output":
	'125 \'cm\''

define "DateTimeToString1 Input":
	ToString(DateTime(2000, 1, 1))
define "DateTimeToString1 Output":
	'2000-01-01'

define "DateTimeToString2 Input":
	ToString(DateTime(2000, 1, 1, 15, 25, 25, 300))
define "DateTimeToString2 Output":
	'2000-01-01T15:25:25.300'

define "DateTimeToString3 Input":
	ToString(DateTime(2000, 1, 1, 8, 25, 25, 300, -7))
define "DateTimeToString3 Output":
	'2000-01-01T08:25:25.300-07:00'

define "TimeToString1 Input":
	ToString(@T09:30:01.003)
define "TimeToString1 Output":
	'09:30:01.003'

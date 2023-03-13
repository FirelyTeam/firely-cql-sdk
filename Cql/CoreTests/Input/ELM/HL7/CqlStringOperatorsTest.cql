library CqlStringOperatorsTest version '1.0.0'

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.1' called FHIRHelpers

context Patient

define "CombineNull":
  Combine(null)= null

define "CombineEmptyList":
  Combine({ })= ''

define "CombineABC":
  Combine({ 'a', 'b', 'c' })= 'abc'

define "CombineABCSepDash":
  Combine({ 'a', 'b', 'c' }, '-')= 'a-b-c'

define "ConcatenateNullNull":
  Concatenate(null, null)= null

define "ConcatenateANull":
  Concatenate('a', null)= null

define "ConcatenateNullB":
  Concatenate(null, 'b')= null

define "ConcatenateAB":
  Concatenate('a', 'b')= 'ab'

define "ConcatenateABWithAdd":
  'a' + 'b' = 'ab'

define "EndsWithNull":
  EndsWith(null, null)= null

define "EndsWithTrue":
  EndsWith('Chris Schuler is the man!!', 'n!!')= true

define "EndsWithFalse":
  EndsWith('Chris Schuler is the man!!', 'n!')= false

define "IndexerNullNull":
  Indexer(null as String, null)= null

define "IndexerANull":
  Indexer('a', null)= null

define "IndexerNull1String":
  Indexer(null as String, 1)= null

define "IndexerAB0":
  Indexer('ab', 0)= 'a'

define "IndexerAB1":
  Indexer('ab', 1)= 'b'

define "IndexerAB2":
  Indexer('ab', 2)= null

define "IndexerABNeg1":
  Indexer('ab', - 1)= null

define "LastPositionOfNull":
  LastPositionOf(null, null)= null

define "LastPositionOfNull1":
  LastPositionOf(null, 'hi')= null

define "LastPositionOfNull2":
  LastPositionOf('hi', null)= null

define "LastPositionOf1":
  LastPositionOf('hi', 'Ohio is the place to be!')= 1

define "LastPositionOf2":
  LastPositionOf('hi', 'Say hi to Ohio!')= 11

define "LengthNullString":
  Length(null as String)= 0

define "LengthEmptyString":
  Length('')= 0

define "LengthA":
  Length('a')= 1

define "LengthAB":
  Length('ab')= 2

define "LowerNull":
  Lower(null)= null

define "LowerEmpty":
  Lower('')= ''

define "LowerA":
  Lower('A')= 'a'

define "LowerB":
  Lower('b')= 'b'

define "LowerAB":
  Lower('Ab')= 'ab'

define "MatchesNull":
  Matches('Not all who wander are lost', null)= null

define "MatchesNumberFalse":
  Matches('Not all who wander are lost', '.*\\d+')= false

define "MatchesNumberTrue":
  Matches('Not all who wander are lost - circa 2017', '.*\\d+')= true

define "MatchesAllTrue":
  Matches('Not all who wander are lost', '.*')= true

define "MatchesWordsAndSpacesTrue":
  Matches('Not all who wander are lost', '[\\w|\\s]+')= true

define "MatchesWordsAndSpacesFalse":
  Matches('Not all who wander are lost - circa 2017', '[\\w]+')= false

define "MatchesNotWords":
  Matches('   ', '\\W+')= true

define "MatchesWhiteSpace":
  Matches(' \n\t', '\\s+')= true

define "PositionOfNullNull":
  PositionOf(null, null)= null

define "PositionOfANull":
  PositionOf('a', null)= null

define "PositionOfNullA":
  PositionOf(null, 'a')= null

define "PositionOfAInAB":
  PositionOf('a', 'ab')= 0

define "PositionOfBInAB":
  PositionOf('b', 'ab')= 1

define "PositionOfCInAB":
  PositionOf('c', 'ab')= - 1

define "ReplaceMatchesNull":
  ReplaceMatches('Not all who wander are lost', null, 'But I am...')= null

define "ReplaceMatchesAll":
  ReplaceMatches('Not all who wander are lost', 'Not all who wander are lost', 'But still waters run deep')= 'But still waters run deep'

define "ReplaceMatchesMany":
  ReplaceMatches('Who put the bop in the bop she bop she bop?', 'bop', 'bang')= 'Who put the bang in the bang she bang she bang?'

define "ReplaceMatchesSpaces":
  ReplaceMatches('All that glitters is not gold', '\\s', '$')= 'All$that$glitters$is$not$gold'

define "SplitNullNull":
  Split(null as String, null as String)= null as List<String>

define "SplitNullComma":
  Split(null, ',')= null

define "SplitABNull":
  Split('a,b', null)= { 'a,b' }

define "SplitABDash":
  Split('a,b', '-')= { 'a,b' }

define "SplitABComma":
  Split('a,b', ',')= { 'a', 'b' }

define "StartsWithNull":
  StartsWith(null, null)= null

define "StartsWithNull1":
  StartsWith('hi', null)= null

define "StartsWithNull2":
  StartsWith(null, 'hi')= null

define "StartsWithTrue1":
  StartsWith('Breathe deep the gathering gloom', 'Bre')= true

define "StartsWithFalse1":
  StartsWith('Breathe deep the gathering gloom', 'bre')= false

define "SubstringNullNull":
  Substring(null, null)= null

define "SubstringANull":
  Substring('a', null)= null

define "SubstringNull1":
  Substring(null, 1)= null

define "SubstringAB0":
  Substring('ab', 0)= 'ab'

define "SubstringAB1":
  Substring('ab', 1)= 'b'

define "SubstringAB2":
  Substring('ab', 2)= null

define "SubstringABNeg1":
  Substring('ab', - 1)= null

define "SubstringAB0To1":
  Substring('ab', 0, 1)= 'a'

define "SubstringABC1To1":
  Substring('abc', 1, 1)= 'b'

define "SubstringAB0To3":
  Substring('ab', 0, 3)= 'ab'

define "UpperNull":
  Upper(null)= null

define "UpperEmpty":
  Upper('')= ''

define "UpperA":
  Upper('a')= 'A'

define "UpperB":
  Upper('B')= 'B'

define "UpperAB":
  Upper('aB')= 'AB'

define "QuantityToString":
  ToString(125 'cm')= '125cm'

define "DateTimeToString1":
  ToString(DateTime(2000, 1, 1))= '2000-01-01'

define "DateTimeToString2":
  ToString(DateTime(2000, 1, 1, 15, 25, 25, 300))= '2000-01-01T15:25:25.300'

define "DateTimeToString3":
  ToString(DateTime(2000, 1, 1, 8, 25, 25, 300, - 7))= '2000-01-01T08:25:25.300'

define "TimeToString1":
  ToString(@T09:30:01.003)= '09:30:01.003'
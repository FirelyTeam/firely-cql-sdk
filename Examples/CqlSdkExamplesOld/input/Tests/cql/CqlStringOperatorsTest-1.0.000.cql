library CqlStringOperatorsTest version '1.0.000'

define "Combine.CombineNull": Combine(null)

define "Combine.CombineEmptyList": Combine({})

define "Combine.CombineABC": Combine({'a', 'b', 'c'})

define "Combine.CombineABCSepDash": Combine({'a', 'b', 'c'}, '-')

define "Concatenate.ConcatenateNullNull": Concatenate(null, null)

define "Concatenate.ConcatenateANull": Concatenate('a', null)

define "Concatenate.ConcatenateNullB": Concatenate(null, 'b')

define "Concatenate.ConcatenateAB": Concatenate('a', 'b')

define "Concatenate.ConcatenateABWithAdd": 'a' + 'b'

define "EndsWith.EndsWithNull": EndsWith(null, null)

define "EndsWith.EndsWithTrue": EndsWith('Chris Schuler is the man!!', 'n!!')

define "EndsWith.EndsWithFalse": EndsWith('Chris Schuler is the man!!', 'n!')

define "Indexer.IndexerNullNull": Indexer(null as String, null)

define "Indexer.IndexerANull": Indexer('a', null)

define "Indexer.IndexerNull1String": Indexer(null as String, 1)

define "Indexer.IndexerAB0": Indexer('ab', 0)

define "Indexer.IndexerAB1": Indexer('ab', 1)

define "Indexer.IndexerAB2": Indexer('ab', 2)

define "Indexer.IndexerABNeg1": Indexer('ab', -1)

define "LastPositionOf.LastPositionOfNull": LastPositionOf(null, null)

define "LastPositionOf.LastPositionOfNull1": LastPositionOf(null, 'hi')

define "LastPositionOf.LastPositionOfNull2": LastPositionOf('hi', null)

define "LastPositionOf.LastPositionOf1": LastPositionOf('hi', 'Ohio is the place to be!')

define "LastPositionOf.LastPositionOf2": LastPositionOf('hi', 'Say hi to Ohio!')

define "Length.LengthNullString": Length(null as String)

define "Length.LengthEmptyString": Length('')

define "Length.LengthA": Length('a')

define "Length.LengthAB": Length('ab')

define "Lower.LowerNull": Lower(null)

define "Lower.LowerEmpty": Lower('')

define "Lower.LowerA": Lower('A')

define "Lower.LowerB": Lower('b')

define "Lower.LowerAB": Lower('Ab')

define "Matches.MatchesNull": Matches('Not all who wander are lost', null)

define "Matches.MatchesNumberFalse": Matches('Not all who wander are lost', '.*\\d+')

define "Matches.MatchesNumberTrue": Matches('Not all who wander are lost - circa 2017', '.*\\d+')

define "Matches.MatchesAllTrue": Matches('Not all who wander are lost', '.*')

define "Matches.MatchesWordsAndSpacesTrue": Matches('Not all who wander are lost', '[\\w|\\s]+')

define "Matches.MatchesWordsAndSpacesFalse": Matches('Not all who wander are lost - circa 2017', '[\\w]+')

define "Matches.MatchesNotWords": Matches('   ', '\\W+')

define "Matches.MatchesWhiteSpace": Matches(' \n\t', '\\s+')

define "PositionOf.PositionOfNullNull": PositionOf(null, null)

define "PositionOf.PositionOfANull": PositionOf('a', null)

define "PositionOf.PositionOfNullA": PositionOf(null, 'a')

define "PositionOf.PositionOfAInAB": PositionOf('a', 'ab')

define "PositionOf.PositionOfBInAB": PositionOf('b', 'ab')

define "PositionOf.PositionOfCInAB": PositionOf('c', 'ab')

define "ReplaceMatches.ReplaceMatchesNull": ReplaceMatches('Not all who wander are lost', null, 'But I am...')

define "ReplaceMatches.ReplaceMatchesAll": ReplaceMatches('Not all who wander are lost', 'Not all who wander are lost', 'But still waters run deep')

define "ReplaceMatches.ReplaceMatchesMany": ReplaceMatches('Who put the bop in the bop she bop she bop?', 'bop', 'bang')

define "ReplaceMatches.ReplaceMatchesSpaces": ReplaceMatches('All that glitters is not gold', '\\s', '\\$')

define "Split.SplitNullNull": Split(null, null)

define "Split.SplitNullComma": Split(null, ',')

define "Split.SplitABNull": Split('a,b', null)

define "Split.SplitABDash": Split('a,b', '-')

define "Split.SplitABComma": Split('a,b', ',')

define "StartsWith.StartsWithNull": StartsWith(null, null)

define "StartsWith.StartsWithNull1": StartsWith('hi', null)

define "StartsWith.StartsWithNull2": StartsWith(null, 'hi')

define "StartsWith.StartsWithTrue1": StartsWith('Breathe deep the gathering gloom', 'Bre')

define "StartsWith.StartsWithFalse1": StartsWith('Breathe deep the gathering gloom', 'bre')

define "Substring.SubstringNullNull": Substring(null, null)

define "Substring.SubstringANull": Substring('a', null)

define "Substring.SubstringNull1": Substring(null, 1)

define "Substring.SubstringAB0": Substring('ab', 0)

define "Substring.SubstringAB1": Substring('ab', 1)

define "Substring.SubstringAB2": Substring('ab', 2)

define "Substring.SubstringABNeg1": Substring('ab', -1)

define "Substring.SubstringAB0To1": Substring('ab', 0, 1)

define "Substring.SubstringABC1To1": Substring('abc', 1, 1)

define "Substring.SubstringAB0To3": Substring('ab', 0, 3)

define "Upper.UpperNull": Upper(null)

define "Upper.UpperEmpty": Upper('')

define "Upper.UpperA": Upper('a')

define "Upper.UpperB": Upper('B')

define "Upper.UpperAB": Upper('aB')

define "toString tests.QuantityToString": ToString(125 'cm')

define "toString tests.DateTimeToString1": ToString(DateTime(2000, 1, 1))

define "toString tests.DateTimeToString2": ToString(DateTime(2000, 1, 1, 15, 25, 25, 300))

define "toString tests.DateTimeToString3": ToString(DateTime(2000, 1, 1, 8, 25, 25, 300, -7))

define "toString tests.TimeToString1": ToString(@T09:30:01.003)


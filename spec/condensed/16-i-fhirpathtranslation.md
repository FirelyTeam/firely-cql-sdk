Publication Build: This will be filled in by the publication tooling

## Appendix I - FHIRPath Translation
*Page standards status: *Normative Maturity Level : N


- .aggregate()
- .abs()
- .all()
- .allFalse()
- .allTrue()
- .anyFalse()
- .anyTrue()
- .as()
- .ceiling()
- .children()
- .combine()
- .conformsTo()
- .contains()
- .convertsToBoolean()
- .convertsToDate()
- .convertsToDateTime()
- .convertsToDecimal()
- .convertsToInteger()
- .convertsToQuantity()
- .convertsToTime()
- .count()
- .descendants()
- .distinct()
- .empty()
- .endsWith()
- .exclude()
- .exists()
- .exp()
- .first()
- .floor()
- .hasValue()
- .iif()
- .indexOf()
- .intersect()
- .is()
- .isDistinct()
- .last()
- .lastIndexOf()
- .length()
- .ln()
- .log()
- .lower()
- .matches()
- .memberOf()
- .ofType()
- .not()
- .now()
- .power()
- .repeat()
- .replace()
- .replaceMatches()
- .round()
- .select()
- .single()
- .skip()
- .sqrt()
- .startsWith()
- .subsetOf()
- .substring()
- .subsumes()
- .subsumedBy()
- .supersetOf()
- .tail()
- .take()
- .timeOfDay()
- .toBoolean()
- .toChars()
- .toDate()
- .toDateTime()
- .today()
- .toDecimal()
- .toInteger()
- .toQuantity()
- .toString()
- .toTime()
- .trace()
- .truncate()
- .union() and |
- .upper()
- .where()

This appendix provides detailed mappings for each FHIRPath function in terms of the ELM output produced.

In addition to the function mappings below, the $index accessor can be used within the FHIRPath iteration functions (i.e. FHIRPath functions that take an *expression *as an argument) to access the 0-based index of the current iteration.

### .aggregate()

```
X.aggregate(<iteration>, <init>) === Aggregate(<iteration>, <init>)

```


In addition, the $total accumulator can be used within the iteration and init expressions to access the current value of the accumulator.

### .abs()

```
X.abs() === Abs(X)

```


### .all()

```
X.all(<condition>) === AllTrue(X $this let a: <condition> where a return a)

```


### .allFalse()

```
X.allFalse() === AllTrue(X A return not A)

```


### .allTrue()

```
X.allTrue() === AllTrue(X)

```


### .anyFalse()

```
X.anyFalse() === AnyTrue(X A return not A)

```


### .anyTrue()

```
X.anyTrue() === AnyTrue(X)

```


### .as()

```
X.as(T) === X as T

```


Note that the type argument T is expected to be a literal string and must resolve to the name of a type.

### .ceiling()

```
X.ceiling() === Ceiling(X)

```


### .children()

```
.children(X) === Children(X)

```


### .combine()

```
X.combine(Y) === Flatten(\{ X, Y })

```


### .conformsTo()

```
X.conformsTo(Y) === FHIRSupport.ConformsTo(Y)

```


Note that this mapping relies on an external library, FHIRSupport to provide conformance validation checking.

### .contains()

```
X.contains(Y) === PositionOf(Y, X) >= 0

```


### .convertsToBoolean()

```
X.convertsToBoolean() === ConvertsToBoolean(X)

```


### .convertsToDate()

```
X.convertsToDate() === ConvertsToDate(X)

```


### .convertsToDateTime()

```
X.convertsToDateTime() === ConvertsToDateTime(X)

```


### .convertsToDecimal()

```
X.convertsToDecimal() === ConvertsToDecimal(X)

```


### .convertsToInteger()

```
X.convertsToInteger() === ConvertsToInteger(X)

```


### .convertsToQuantity()

```
X.convertsToQuantity() === ConvertsToQuantity(X)

```


### .convertsToTime()

```
X.convertsToTime() === ConvertsToTime(X)

```


### .count()

```
X.count() === Count(X)

```


### .descendants()

```
.descendants(X) === Descendants(X)

```


### .distinct()

```
X.distinct() === distinct X

```


### .empty()

```
X.empty() === not exists X

```


### .endsWith()

```
X.endsWith(Y) === EndsWith(X, Y)

```


### .exclude()

```
X.exclude(Y) === X except Y

```


### .exists()

```
X.exists() === exists X

X.exists(<condition>) === exists (X $this where <condition>)

```


### .exp()

```
X.exp() === Exp(X)

```


### .first()

```
X.first() === First(X)

```


### .floor()

```
X.floor() === Floor(X)

```


### .hasValue()

```
X.hasValue() === X is not null

```


### .iif()

```
iif(X, Y) === if X then Y else null

iif(X, Y, Z) === if X then Y else Z

```


### .indexOf()

```
X.indexOf(Y) === PositionOf(Y, X) // Note carefully the order of arguments here, it’s the opposite of IndexOf

```


### .intersect()

```
X.intersect(Y) === X intersect Y

```


### .is()

```
X.is(T) === X is T

```


Note that the argument T is expected to be a literal string and must resolve to the name of a type.

### .isDistinct()

```
X.isDistinct() === Count(X) = Count(distinct X)

```


### .last()

```
X.last() === Last(X)

```


### .lastIndexOf()

```
X.lastIndexOf(Y) === LastPositionOf(Y, X) // Note carefully the order of arguments here, it’s the opposite of lastIndexOf.

```


### .length()

```
X.length() === Length(X)

```


### .ln()

```
X.ln() === Ln(X)

```


### .log()

```
X.log(B) === Log(X, B)

```


### .lower()

```
X.lower() === Lower(X)

```


### .matches()

```
X.matches(Y) === Matches(X, Y)

```


### .memberOf()

```
X.memberOf(Y) === InValueSet(X, Y) // where Y is required to be a ValueSetRef

```


### .ofType()

```
X.ofType(T) === X $this where $this is T return $this as T

```


Note that the argument T is required to be a literal string, and is interpreted as the name of a type. For non-named-types, type specifier syntax applies.

### .not()

```
X.not() === not X

```


### .now()

```
now() === Now()

```


### .power()

```
X.power(Y) === Power(X, Y)

```


### .repeat()

```
X.repeat(<element>) === Repeat(X, <element>)

```


The type of X.repeat( ) is inferred as the type of:
```
X.select(<element>).select(<element>)

```


### .replace()

```
X.replace(Y, Z) === Replace(X, Y, Z)

```


### .replaceMatches()

```
X.replaceMatches(Y, Z) === ReplaceMatches(X, Y, Z)

```


### .round()

```
X.round() === Round(X)
X.round(Y) === Round(X, Y)

```


### .select()


If the result type of is not list-valued:
```
X.select(<element>) === X $this let a: <element> where a is not null return a

```


If the result type of is list-valued:
```
X.select(<element>) === Flatten(X $this let a: <element> where a is not null return a)

```


### .single()

```
X.single() === singleton from X

```


### .skip()

```
X.skip(Y) === Slice(X, Y, null)

```


### .sqrt()

```
X.sqrt() === Power(X, 0.5)

```


### .startsWith()

```
X.startsWith(Y) === StartsWith(X, Y)

```


### .subsetOf()

```
X.subsetOf(Y) === X included in Y

```


### .substring()

```
X.substring(Y) === SubString(X, Y)

X.substring(Y, Z) === SubString(X, Y, Z)

```


### .subsumes()

```
X.subsumes(Y) === Subsumes(X, Y)

```


### .subsumedBy()

```
X.subsumedBy(Y) === SubsumedBy(X, Y)

```


### .supersetOf()

```
X.supersetOf(Y) === X includes Y

```


### .tail()

```
X.tail() === Slice(X, 1, null)

```


### .take()

```
X.take(Y) === Slice(X, 0, Coalesce(Y, 0))

```


### .timeOfDay()

```
timeOfDay() === TimeOfDay()

```


### .toBoolean()

```
X.toBoolean() === ToBoolean(X)

```


### .toChars()

```
X.toChars() === ToChars(X)

```


### .toDate()

```
X.toDate() === ToDate(X)

```


### .toDateTime()

```
X.toDateTime() === ToDateTime(X)

```


### .today()

```
today() === Today()

```


### .toDecimal()

```
X.toDecimal() === ToDecimal(X)

```


### .toInteger()

```
X.toInteger() === ToInteger(X)

```


### .toQuantity()

```
X.toQuantity() === ToQuantity(X)

```


### .toString()

```
X.toString() === ToString(X)

```


### .toTime()

```
X.toTime() === ToTime(X)

```


### .trace()

```
X.trace(Y) === Message(X, true, Y, 'Trace', ToString(X)))

```


### .truncate()

```
X.truncate() === Truncate(X)

```


### .union() and |

```
X.union(Y) === X union Y
X | Y === X union Y

```


### .upper()

```
X.upper() === Upper(X)

```


### .where()

```
X.where(<condition>) === X $this where <condition>

```
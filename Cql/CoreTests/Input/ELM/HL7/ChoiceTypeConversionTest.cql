library ChoiceTypeConversionTest version '1.0.0'

/*
@publisher: Firely
@description: Library used to test conversions on choice types
*/

define ReturnDateAsChoice:
    @2019-01-01 as Choice<Date, String>

define ReturnStringAsChoice:
    '2019-01-01' as Choice<Date, String>

define ReturnDateAsChoiceInRangeMustBeTrue:
    ReturnDateAsChoice during Interval[@2019-01-01T, @2019-12-31T]

define ReturnDateAsChoiceOutOfRangeMustBeFalse:
    ReturnDateAsChoice during Interval[@2018-01-01T, @2018-12-31T]

define ReturnStringAsChoiceInRangeMustBeNull:
    ReturnStringAsChoice during Interval[@2019-01-01T, @2019-12-31T]
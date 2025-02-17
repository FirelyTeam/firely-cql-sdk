library System version '1.0.0'

define external function Abs(value System.Integer) returns System.Integer
define external function Abs(value System.Long) returns System.Long
define external function Abs(value System.Decimal) returns System.Decimal
define external function Abs(value System.Quantity) returns System.Quantity

define external function Add(left System.Integer, right System.Integer) returns System.Integer
define external function Add(left System.Long, right System.Long) returns System.Long
define external function Add(left System.Decimal, right System.Decimal) returns System.Decimal
define external function Add(left System.Quantity, right System.Quantity) returns System.Quantity
define external function Add(left System.Date, right System.Quantity) returns System.Date
define external function Add(left System.DateTime, right System.Quantity) returns System.DateTime
define external function Add(left System.Time, right System.Quantity) returns System.Time
define external function Add(left System.String, right System.String) returns System.String

define external function AgeInYears() returns System.Integer

define external function AgeInMonths() returns System.Integer

define external function AgeInWeeks() returns System.Integer

define external function AgeInHours() returns System.Integer

define external function AgeInMinutes() returns System.Integer

define external function AgeInSeconds() returns System.Integer

define external function AgeInYearsAt(date System.Date) returns System.Integer
define external function AgeInYearsAt(datTimee System.DateTime) returns System.Integer

define external function AgeInMonthsAt(date System.Date) returns System.Integer
define external function AgeInMonthsAt(datTimee System.DateTime) returns System.Integer

define external function AgeInWeeksAt(date System.Date) returns System.Integer
define external function AgeInWeeksAt(datTimee System.DateTime) returns System.Integer

define external function AgeInDaysAt(date System.Date) returns System.Integer
define external function AgeInDaysAt(datTimee System.DateTime) returns System.Integer

define external function AgeInHourssAt(datTimee System.DateTime) returns System.Integer

define external function AgeInMinutesAt(datTimee System.DateTime) returns System.Integer

define external function AgeInSecondsAt(datTimee System.DateTime) returns System.Integer

define external function AllTrue(values List<System.Boolean>) returns System.Boolean

define external function And(left System.Boolean, right System.Boolean) returns System.Boolean

define external function AnyTrue(values List<System.Boolean>) returns System.Boolean

define external function AnyInValueSet(values List<System.String>) returns System.Boolean
define external function AnyInValueSet(values List<System.Code>) returns System.Boolean
define external function AnyInValueSet(values List<System.Concept>) returns System.Boolean

define external function Avg(values List<System.Decimal>) returns System.Decimal
define external function Avg(values List<System.Quantity>) returns System.Quantity

define external function Between(value System.Integer, low System.Integer, high System.Integer) returns System.Boolean
define external function Between(value System.Long, low System.Long, high System.Long) returns System.Boolean
define external function Between(value System.Decimal, low System.Decimal, high System.Decimal) returns System.Boolean
define external function Between(value System.Quantity, low System.Quantity, high System.Quantity) returns System.Boolean
define external function Between(value System.Date, low System.Date, high System.Date) returns System.Boolean
define external function Between(value System.DateTime, low System.DateTime, high System.DateTime) returns System.Boolean
define external function Between(value System.Time, low System.Time, high System.Time) returns System.Boolean
define external function Between(value System.String, low System.String, high System.String) returns System.String

define external function CalculateAgeInYears(dateOfBirth System.Date) returns System.Integer
define external function CalculateAgeInYears(dateOfBirth System.DateTime) returns System.Integer

define external function CalculateAgeInMonths(dateOfBirth System.Date) returns System.Integer
define external function CalculateAgeInMonths(dateOfBirth System.DateTime) returns System.Integer

define external function CalculateAgeInWeeks(dateOfBirth System.Date) returns System.Integer
define external function CalculateAgeInWeeks(dateOfBirth System.DateTime) returns System.Integer

define external function CalculateAgeInDays(dateOfBirth System.Date) returns System.Integer
define external function CalculateAgeInDays(dateOfBirth System.DateTime) returns System.Integer

define external function CalculateAgeInHours(dateOfBirth System.DateTime) returns System.Integer

define external function CalculateAgeInMinutes(dateOfBirth System.DateTime) returns System.Integer

define external function CalculateAgeInSeconds(dateOfBirth System.DateTime) returns System.Integer

define external function CalculateAgeInYearsAt(dateOfBirth System.Date, asOf System.Date) returns System.Integer
define external function CalculateAgeInYearsAt(dateOfBirth System.DateTime, asOf System.DateTime) returns System.Integer

define external function CalculateAgeInMonthsAt(dateOfBirth System.Date, asOf System.Date) returns System.Integer
define external function CalculateAgeInMonthsAt(dateOfBirth System.DateTime, asOf System.DateTime) returns System.Integer

define external function CalculateAgeInWeeksAt(dateOfBirth System.Date, asOf System.Date) returns System.Integer
define external function CalculateAgeInWeeksAt(dateOfBirth System.DateTime, asOf System.DateTime) returns System.Integer

define external function CalculateAgeInDaysAt(dateOfBirth System.Date, asOf System.Date) returns System.Integer
define external function CalculateAgeInDaysAt(dateOfBirth System.DateTime, asOf System.DateTime) returns System.Integer

define external function CalculateAgeInHoursAt(dateOfBirth System.DateTime, asOf System.DateTime) returns System.Integer

define external function CalculateAgeInMinutesAt(dateOfBirth System.DateTime, asOf System.DateTime) returns System.Integer

define external function CalculateAgeInSecondsAt(dateOfBirth System.DateTime, asOf System.DateTime) returns System.Integer

define external function Ceiling(value System.Decimal) returns System.Integer

define external function Coalesce(value1 System.Any, value2 System.Any) returns System.Any
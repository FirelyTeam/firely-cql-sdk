model HEDIS version '2024.0.0': 'https://ncqa.org/hedis/2024'

using System version '2.0.0'

define type Patient {
	gender String,
	birthDate Date,
	deceased DateTime,
	race List<System.Code>,
	ethnicity List<System.Code>
}


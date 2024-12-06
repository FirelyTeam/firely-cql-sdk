library MeasureExample version'0.0.1'

using FHIR version '4.0.1'

context Patient

/**
 * @measure: Measure Resource Example
 * @year: 2024
 * @domain: Testing Measures
*/

/*
* @group: 1
* @group: 2
* @population: initial-population
* @description: Patients in the IP
*/
define "Initial population":
    true

/*
* @group: 1
* @group: 2
* @population: denominator
*/
define "Denominator":
	"Initial population"
	and not "Exclusion"

/*
* @group: 1
* @group: 2
* @population: denominator-exclusion
*/
define "Exclusion":
	false

/*
* @group: 1
* @population: numerator
*/
define "Numerator 1":
	true

/*
* @group: 2
* @population: numerator
*/
define "Numerator 2":
	false
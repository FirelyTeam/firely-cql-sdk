library ValueSetExprExample version '1.0.0'

using FHIR version '4.0.1'

valueset "ValueSet-A-1": 'http://fire.ly/ValueSet/ValueSet-A-1'
valueset "ValueSet-A-2": 'http://fire.ly/ValueSet/ValueSet-A-2'
valueset "ValueSet-B-1": 'http://fire.ly/ValueSet/ValueSet-B-1'
valueset "ValueSet-B-2": 'http://fire.ly/ValueSet/ValueSet-B-2'

parameter "ChosenSubCategory" String default '1'

parameter "ChosenCode" Code default Code {
    code: 'A-1-A',
    system: 'http://fire.ly/CodeSystem/Test'
}

define "ValueSetA":
    case "ChosenSubCategory"
      when '1' then "ValueSet-A-1"
      when '2' then "ValueSet-A-2"
    else null
end

define "ValueSetB":
    case "ChosenSubCategory"
        when '1' then "ValueSet-B-1"
        when '2' then "ValueSet-B-2"
    else null
end

define "Result":
    case
        when "ChosenCode" in "ValueSetA" then 'a'
        when "ChosenCode" in "ValueSetB" then 'b'
    else null
end
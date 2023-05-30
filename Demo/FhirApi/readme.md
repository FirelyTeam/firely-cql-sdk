
Based on the CPG $library-evaluate operation
http://build.fhir.org/ig/HL7/cqf-recommendations/OperationDefinition-cpg-library-evaluate.html

Run this project, then send an HTTP GET to:
http://localhost:5036/Library/$evaluate
With this body:
```
{
    "resourceType": "Parameters",
    "parameter": [
        {
            "name": "library",
            "valueId": "BCSEHEDISMY2022-1.0.0"
        },
        { 
            "name": "subject",
            "valueId": "95085"
        }
    ]
}
```

You can put breakpoints on 
Measures\BCSEHEDISMY2022-1.0.0.cs 
in the Numerator_Value 
method to step through the execution of the measure.
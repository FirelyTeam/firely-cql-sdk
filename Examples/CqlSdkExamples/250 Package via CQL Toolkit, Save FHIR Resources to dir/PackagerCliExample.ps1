$cqlInDir = "input/cql"
$fhirOutDir = "output/fhir"

cql-package cql `
    --cql "$cqlInDir" `
    --fhir "$fhirOutDir"

Write-Host "Press any key to delete the output folder..."
[void][System.Console]::ReadKey($true)

if (Test-Path $elmOutDir) {
    Remove-Item -Recurse -Force "output"
}
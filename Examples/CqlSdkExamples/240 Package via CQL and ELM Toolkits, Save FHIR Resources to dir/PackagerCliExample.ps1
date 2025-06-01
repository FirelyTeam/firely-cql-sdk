$cqlInDir = "input/cql"
$elmInDir = "input/elm"
$fhirOutDir = "output/fhir"

cql-package elm `
    --cql "$cqlInDir" `
    --elm "$elmInDir" `
    --fhir "$fhirOutDir"

Write-Host "Press any key to delete the output folder..."
[void][System.Console]::ReadKey($true)

if (Test-Path "output") {
    Remove-Item -Recurse -Force "output"
}
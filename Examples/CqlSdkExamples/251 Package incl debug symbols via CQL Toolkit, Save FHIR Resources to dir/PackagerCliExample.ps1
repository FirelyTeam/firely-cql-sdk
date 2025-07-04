$cqlInDir = "input/cql"
$fhirOutDir = "output/fhir"

cql-package cql `
    --cql "$cqlInDir" `
    --fhir "$fhirOutDir"
# REVIEW- TODO: We need an attribute here allowing us to specify that debug symbols be generated. Perhaps with a pdb folder (or sharing the dll folder)

Write-Host "Press any key to delete the output folder..."
[void][System.Console]::ReadKey($true)

if (Test-Path $elmOutDir) {
    Remove-Item -Recurse -Force "output"
}
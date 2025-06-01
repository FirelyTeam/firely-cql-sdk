$cqlInDir = "input/cql"
$csOutDir = "output/cs"
$dllOutDir = "output/dll"

cql-package cql `
    --cql "$cqlInDir" `
    --cs "$csOutDir" `
    --dll "$dllOutDir"

Write-Host "Press any key to delete the output folder..."
[void][System.Console]::ReadKey($true)

if (Test-Path "output") {
    Remove-Item -Recurse -Force "output"
}
$cqlInDir = "input/cql"
$csOutDir = "output/cs"
$dllOutDir = "output/dll"

cql-package cql `
    --cql "$cqlInDir" `
    --cs "$csOutDir" `
    --dll "$dllOutDir"
# REVIEW- TODO: We need an attribute here allowing us to specify that debug symbols be generated. Perhaps with a pdb folder (or sharing the dll folder)

Write-Host "Press any key to delete the output folder..."
[void][System.Console]::ReadKey($true)

if (Test-Path "output") {
    Remove-Item -Recurse -Force "output"
}
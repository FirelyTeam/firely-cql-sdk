$cqlInDir = "input/cql"
$elmOutDir = "output/elm"

cql-package cql `
    --cql "$cqlInDir" `
    --elm "$elmOutDir"

Write-Host "Press any key to delete the output folder..."
[void][System.Console]::ReadKey($true)

if (Test-Path "output") {
    Remove-Item -Recurse -Force "output"
}
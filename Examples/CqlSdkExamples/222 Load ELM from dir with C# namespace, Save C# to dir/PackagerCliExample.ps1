$elmInDir = "input/elm"
$csOutDir = "output/cs"

cql-package elm `
    --elm "$elmInDir" `
    --cs "$csOutDir" `
    --csharp-namespace "MyCompany.MyCqlLibraries"

Write-Host "Press any key to delete the output folder..."
[void][System.Console]::ReadKey($true)

if (Test-Path "output") {
    Remove-Item -Recurse -Force "output"
}

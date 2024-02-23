@echo off
xcopy  .\Demo\Test\Resources\* .\..\OUTPUT\Demo\Test\Resources\ /I /S /V
xcopy  .\Demo\Demo\Measures\*.cs .\..\OUTPUT\Demo\Measures\ /I /S /V
rmdir .\Demo\Test\Resources /s /q
del .\Demo\Measures\*.cs /s /q
mkdir .\Demo\Test\Resources
::mkdir .\Demo\Measures
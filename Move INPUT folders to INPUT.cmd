@echo off
xcopy  .\Demo\Cql\Input\* .\..\INPUT\Demo\Cql\Input\ /I /S /V
xcopy  .\Demo\Elm\Json\* .\..\INPUT\Demo\Elm\Json\ /I /S /V
rmdir .\Demo\Cql\Input /s /q
rmdir .\Demo\Elm\Json /s /q
mkdir .\Demo\Cql\Input
mkdir .\Demo\Elm\Json

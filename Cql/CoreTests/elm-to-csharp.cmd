::@echo off
setlocal ENABLEEXTENSIONS ENABLEDELAYEDEXPANSION

set FILEPATH_PACKAGER=..\PackagerCLI\bin\Debug\net8.0\Hl7.Cql.Packager.exe
set IN_DIR_CQL=.\Input\ELM\HL7
set OUT_DIR_ELM=.\Input\ELM\HL7
set OUT_DIR_CS=.\CSharp
::set OUT_DIR_FHIR=./Resources

del "%OUT_DIR_CS%" /F /Q /S
::del "%OUT_DIR_FHIR%" /F /Q /S

"%FILEPATH_PACKAGER%" ^
  --cql %IN_DIR_CQL% ^
  --elm %OUT_DIR_ELM% ^
  --cs %OUT_DIR_CS% ^
  --cs-typeformat "Explicit" ^
  --override-utc-date-time "1970-01-01T00:00:00.000Z" ^
  --canonical-root-url "https://fire.ly/fhir/"
::  --fhir %OUT_DIR_FHIR% ^

endlocal
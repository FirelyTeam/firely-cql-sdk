::@echo off
setlocal ENABLEEXTENSIONS ENABLEDELAYEDEXPANSION

set FILEPATH_PACKAGER=../../Cql/PackagerCLI/bin/Debug/net8.0/Hl7.Cql.Packager.exe
set IN_DIR_CQL=./input/cql
set OUT_DIR_ELM=./Elm
set OUT_DIR_CS=./CSharp
set OUT_DIR_FHIR=./Resources

del "%OUT_DIR_CS%" /F /Q /S
del "%OUT_DIR_FHIR%" /F /Q /S

"%FILEPATH_PACKAGER%" ^
  --cql %IN_DIR_CQL% ^
  --elm %OUT_DIR_ELM% ^
  --cs %OUT_DIR_CS% ^
  --fhir %OUT_DIR_FHIR% ^
  --override-utc-date-time "1970-01-01T00:00:00.000Z" ^
  --canonical-root-url "https://fire.ly/fhir/"

endlocal
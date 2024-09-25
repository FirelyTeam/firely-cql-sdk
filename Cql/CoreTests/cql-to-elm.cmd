::@echo off
setlocal ENABLEEXTENSIONS ENABLEDELAYEDEXPANSION

set IN_DIR_CQL=.\Input\ELM/HL7
set OUT_DIR_ELM=.\Input\ELM/HL7
set DIR_TARGET_DEPENDENCIES=..\..\Demo\Cql\Build\target\dependency

:: Backup the TestRetrieve.json file, we cannot use the generated file to continue processing it to C#
ren "%OUT_DIR_ELM%\TestRetrieve.json" "TestRetrieve.json.bak"
del "%OUT_DIR_ELM%\*.json" /F /Q /S

java ^
   -Djakarta.xml.bind.JAXBContextFactory=org.eclipse.persistence.jaxb.XMLBindingContextFactory ^
   -classpath %DIR_TARGET_DEPENDENCIES%/* org.cqframework.cql.cql2elm.cli.Main ^
   -input %IN_DIR_CQL% ^
   -f JSON ^
   -output %OUT_DIR_ELM% ^
   -locators true ^
   -result-types true ^
   -signatures All

:: Restore the TestRetrieve.json file
del "%OUT_DIR_ELM%\TestRetrieve.json" /F /Q
ren "%OUT_DIR_ELM%\TestRetrieve.json.bak" "TestRetrieve.json"

endlocal
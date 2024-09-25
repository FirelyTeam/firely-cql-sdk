::@echo off
setlocal ENABLEEXTENSIONS ENABLEDELAYEDEXPANSION

set IN_DIR_CQL=..\..\LibrarySets\Demo\Cql
set OUT_DIR_ELM=..\..\LibrarySets\Demo\Elm
set DIR_TARGET_DEPENDENCIES=..\Cql\Build\target\dependency

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

endlocal
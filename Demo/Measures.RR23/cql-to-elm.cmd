::@echo off
setlocal ENABLEEXTENSIONS ENABLEDELAYEDEXPANSION

set IN_DIR_CQL=./input/cql
set OUT_DIR_ELM=./Elm
set DIR_TARGET_DEPENDENCIES=../Cql/Build/target/dependency

del "%OUT_DIR_ELM%" /F /Q /S

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
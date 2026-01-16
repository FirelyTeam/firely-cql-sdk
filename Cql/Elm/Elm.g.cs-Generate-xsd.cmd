@echo off
SETLOCAL EnableDelayedExpansion

REM ============================================================================
REM Elm.g.cs Generator (Version 2 - Using xsd2cs tool)
REM ============================================================================
REM This script uses the new xsd2cs tool to generate C# classes from XSD files.
REM It replaces the direct xsd.exe call with a wrapped version that provides
REM better tooling support and prepares for future enhancements.
REM ============================================================================

SET in_file=expression.cs
SET out_file=Elm.g.cs
SET tool_path=xsd.exe

PUSHD Schema

ECHO Generating C# from XSD files using xsd tool...
"%tool_path%" /c .\library.xsd .\clinicalexpression.xsd .\cqlannotations.xsd .\expression.xsd /n:Hl7.Cql.Elm

IF ERRORLEVEL 1 (
    POPD
    ECHO Error: Failed to generate C# code from XSD files
    EXIT /B 1
)

MOVE /Y %in_file% ..\%out_file%

POPD

ECHO.
ECHO Successfully generated %out_file%

ENDLOCAL

@echo off
SETLOCAL EnableDelayedExpansion

REM ============================================================================
REM Elm.g.cs Generator (Version 2 - Using xsd2cs tool)
REM ============================================================================
REM This script uses the new xsd2cs tool to generate C# classes from XSD files.
REM It replaces the direct xsd.exe call with a wrapped version that provides
REM better tooling support and prepares for future enhancements.
REM
REM NOTE: This is a testing/validation version. After verification that the
REM output matches the original, this can replace Elm.g.cs-Generate.cmd.
REM ============================================================================

REM Note: Generated C# files must have file extension of .g.cs
REM For more info regarding nullability on generated files, see: https://learn.microsoft.com/en-us/dotnet/csharp/nullable-references

SET out_file=Elm.g.cs
SET tool_path=..\..\tools\XsdToCSharpConverter\bin\Debug\net8.0\xsd2cs.dll

ECHO Checking for XSD to C# converter tool...
IF NOT EXIST "%tool_path%" (
    ECHO Tool not found. Building XSD to C# converter...
    PUSHD ..\..\tools\XsdToCSharpConverter
    dotnet build
    IF ERRORLEVEL 1 (
        POPD
        ECHO Error: Failed to build xsd2cs tool
        EXIT /B 1
    )
    POPD
)

PUSHD Schema

ECHO Generating C# from XSD files using xsd2cs tool...
dotnet "..\%tool_path%" /c .\library.xsd .\clinicalexpression.xsd .\cqlannotations.xsd .\expression.xsd /o:.. /n:Hl7.Cql.Elm /out:Elm.g.cs /q

IF ERRORLEVEL 1 (
    POPD
    ECHO Error: Failed to generate C# code from XSD files
    EXIT /B 1
)

POPD

ECHO.
ECHO Successfully generated %out_file%

ENDLOCAL

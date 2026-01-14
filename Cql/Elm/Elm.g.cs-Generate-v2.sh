#!/bin/bash

# ============================================================================
# Elm.g.cs Generator (Version 2 - Using xsd2cs tool)
# ============================================================================
# This script uses the new xsd2cs tool to generate C# classes from XSD files.
# Note: Currently requires Windows and xsd.exe to produce identical output.
# This is a shell version for reference; use the .cmd file on Windows.
# ============================================================================

set -e

IN_FILE="expression.cs"
TEMP_FILE="Elm.g.cs.tmp"
OUT_FILE="Elm.g.cs"
TOOL_PATH="../../tools/XsdToCSharpConverter/bin/Debug/net8.0/xsd2cs.dll"

echo "Checking for XSD to C# converter tool..."
if [ ! -f "$TOOL_PATH" ]; then
    echo "Tool not found. Building XSD to C# converter..."
    pushd ../../tools/XsdToCSharpConverter > /dev/null
    dotnet build
    popd > /dev/null
fi

pushd Schema > /dev/null

echo "Generating C# from XSD files using xsd2cs tool..."
dotnet "$TOOL_PATH" /c ./library.xsd ./clinicalexpression.xsd ./cqlannotations.xsd ./expression.xsd /o:.. /n:Hl7.Cql.Elm /out:elm.g.cs /q

if [ $? -ne 0 ]; then
    popd > /dev/null
    echo "Error: Failed to generate C# code from XSD files"
    exit 1
fi

popd > /dev/null

echo "Note: Post-processing currently needs to be done manually or via the .cmd script"
echo "This shell script is provided for reference only."

echo ""
echo "To complete the generation on Windows, use Elm.g.cs-Generate-v2.cmd"

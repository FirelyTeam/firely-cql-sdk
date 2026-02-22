#!/usr/bin/env bash
#
# Build script for Firely CQL SDK
# Provides interactive options for runtime selection and CQL tooling features
#

set -e

# ANSI color codes
GREEN='\033[0;32m'
YELLOW='\033[0;33m'
BLUE='\033[0;34m'
RED='\033[0;31m'
RESET='\033[0m'

# Default values
FRAMEWORK=""
CONFIGURATION="Debug"
ENABLE_CQL_TO_ELM=""
ENABLE_ELM_TO_CSHARP=""

# Parse command line arguments
while [[ $# -gt 0 ]]; do
    case $1 in
        --framework)
            FRAMEWORK="$2"
            shift 2
            ;;
        --configuration)
            CONFIGURATION="$2"
            shift 2
            ;;
        --enable-cql-to-elm)
            ENABLE_CQL_TO_ELM="true"
            shift
            ;;
        --enable-elm-to-csharp)
            ENABLE_ELM_TO_CSHARP="true"
            shift
            ;;
        --help)
            echo "Usage: $0 [options]"
            echo ""
            echo "Options:"
            echo "  --framework <net8.0|net10.0>    Target framework"
            echo "  --configuration <Debug|Release>  Build configuration (default: Debug)"
            echo "  --enable-cql-to-elm              Enable CqlToElm conversion"
            echo "  --enable-elm-to-csharp           Enable ElmToCSharp conversion"
            echo "  --help                           Show this help message"
            exit 0
            ;;
        *)
            echo "Unknown option: $1"
            echo "Use --help for usage information"
            exit 1
            ;;
    esac
done

echo -e "${BLUE}==========================================================================="
echo "Firely CQL SDK Build Script"
echo -e "===========================================================================${RESET}"
echo ""

# Interactive prompts if parameters not provided
if [ -z "$FRAMEWORK" ]; then
    echo -e "${YELLOW}Select target framework and configuration:${RESET}"
    echo "  1. .NET 8 / Debug"
    echo "  2. .NET 8 / Release"
    echo "  3. .NET 10 / Debug"
    echo "  4. .NET 10 / Release"
    echo ""
    read -p "Enter choice (1-4): " choice

    case $choice in
        1)
            FRAMEWORK="net8.0"
            CONFIGURATION="Debug"
            ;;
        2)
            FRAMEWORK="net8.0"
            CONFIGURATION="Release"
            ;;
        3)
            FRAMEWORK="net10.0"
            CONFIGURATION="Debug"
            ;;
        4)
            FRAMEWORK="net10.0"
            CONFIGURATION="Release"
            ;;
        *)
            echo -e "${RED}Invalid choice. Defaulting to .NET 8 / Debug${RESET}"
            FRAMEWORK="net8.0"
            CONFIGURATION="Debug"
            ;;
    esac
fi

if [ -z "$ENABLE_CQL_TO_ELM" ] && [ -z "$ENABLE_ELM_TO_CSHARP" ]; then
    echo ""
    echo -e "${YELLOW}Select code generation options:${RESET}"
    echo "  1. None (both disabled)"
    echo "  2. CqlToElm only (converts CQL files to ELM JSON)"
    echo "  3. ElmToCSharp only (generates C# code from ELM)"
    echo "  4. Both enabled (CqlToElm + ElmToCSharp)"
    echo ""
    read -p "Enter choice (1-4, default: 1): " codegen_choice

    case $codegen_choice in
        1)
            ENABLE_CQL_TO_ELM="false"
            ENABLE_ELM_TO_CSHARP="false"
            ;;
        2)
            ENABLE_CQL_TO_ELM="true"
            ENABLE_ELM_TO_CSHARP="false"
            ;;
        3)
            ENABLE_CQL_TO_ELM="false"
            ENABLE_ELM_TO_CSHARP="true"
            ;;
        4)
            ENABLE_CQL_TO_ELM="true"
            ENABLE_ELM_TO_CSHARP="true"
            ;;
        *)
            ENABLE_CQL_TO_ELM="false"
            ENABLE_ELM_TO_CSHARP="false"
            ;;
    esac
fi

echo ""
echo -e "${GREEN}==========================================================================="
echo "Build Configuration:"
echo -e "===========================================================================${RESET}"
echo "  Framework:        ${FRAMEWORK}"
echo "  Configuration:    ${CONFIGURATION}"
echo "  CqlToElm:         $([ "$ENABLE_CQL_TO_ELM" = "true" ] && echo "Enabled" || echo "Disabled")"
echo "  ElmToCSharp:      $([ "$ENABLE_ELM_TO_CSHARP" = "true" ] && echo "Enabled" || echo "Disabled")"
echo ""

# Build MSBuild properties
PROPERTIES=(
    "/p:Configuration=$CONFIGURATION"
    "/p:TargetFramework=$FRAMEWORK"
)

if [ "$ENABLE_CQL_TO_ELM" = "true" ]; then
    PROPERTIES+=("/p:CqlToElmEnabled=true")
fi

if [ "$ENABLE_ELM_TO_CSHARP" = "true" ]; then
    PROPERTIES+=("/p:ElmToCSharpEnabled=true")
fi

# Execute build
echo -e "${BLUE}Building solution...${RESET}"
echo ""

SOLUTION_FILE="Cql-Sdk-All.sln"

echo -e "\033[90mCommand: dotnet build \"$SOLUTION_FILE\" ${PROPERTIES[*]}${RESET}"
echo ""

dotnet build "$SOLUTION_FILE" "${PROPERTIES[@]}"

if [ $? -eq 0 ]; then
    echo ""
    echo -e "${GREEN}==========================================================================="
    echo "Build completed successfully!"
    echo -e "===========================================================================${RESET}"
else
    echo ""
    echo -e "${RED}==========================================================================="
    echo "Build failed!"
    echo -e "===========================================================================${RESET}"
    exit 1
fi

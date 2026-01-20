#!/usr/bin/env bash
# Script: test-multiframework.sh
# Description: Run tests against both .NET 8 and .NET 10 to verify identical behavior
# Usage: ./test-multiframework.sh [debug|release] [--verbose]

set -e

CONFIGURATION="${1:-Debug}"
VERBOSE=0

if [[ "$2" == "--verbose" ]] || [[ "$1" == "--verbose" ]]; then
    VERBOSE=1
fi

# Colors
RED='\033[0;31m'
GREEN='\033[0;32m'
YELLOW='\033[1;33m'
CYAN='\033[0;36m'
NC='\033[0m' # No Color

echo -e "${CYAN}=================================================================="
echo -e "Multi-Framework Test Runner for Firely CQL SDK"
echo -e "Testing .NET 8 and .NET 10 to verify identical behavior"
echo -e "==================================================================${NC}"
echo ""

# Check for multi-targeting in cql-base.props
PROPS_FILE="$(dirname "$0")/cql-base.props"
if [ -f "$PROPS_FILE" ]; then
    if grep -q '<TargetFrameworks>net8.0;net10.0</TargetFrameworks>' "$PROPS_FILE"; then
        echo -e "${GREEN}Target Frameworks: net8.0;net10.0${NC}"
    elif grep -q '<TargetFrameworks>' "$PROPS_FILE"; then
        FRAMEWORKS=$(grep -oP '<TargetFrameworks>\K[^<]+' "$PROPS_FILE" || echo "unknown")
        echo -e "${YELLOW}Warning: Multi-targeting not fully enabled in cql-base.props${NC}"
        echo -e "${YELLOW}Expected: <TargetFrameworks>net8.0;net10.0</TargetFrameworks>${NC}"
        echo -e "${YELLOW}Found: <TargetFrameworks>$FRAMEWORKS</TargetFrameworks>${NC}"
    fi
else
    echo -e "${YELLOW}Warning: Could not find cql-base.props${NC}"
fi
echo ""

# Check .NET SDKs
echo -e "${YELLOW}Checking installed .NET SDKs...${NC}"
SDKS=$(dotnet --list-sdks)

if ! echo "$SDKS" | grep -q "^8\."; then
    echo -e "${RED}Error: .NET 8 SDK not found${NC}"
    echo "Please install: https://dotnet.microsoft.com/download/dotnet/8.0"
    exit 1
fi

if ! echo "$SDKS" | grep -q "^10\."; then
    echo -e "${RED}Error: .NET 10 SDK not found${NC}"
    echo "Please install: https://dotnet.microsoft.com/download/dotnet/10.0"
    exit 1
fi

NET8_SDK=$(echo "$SDKS" | grep "^8\." | head -n1)
NET10_SDK=$(echo "$SDKS" | grep "^10\." | head -n1)

echo -e "${GREEN}✓ .NET 8 SDK: $NET8_SDK${NC}"
echo -e "${GREEN}✓ .NET 10 SDK: $NET10_SDK${NC}"
echo ""

# Test projects
TEST_PROJECTS=(
    "Cql/CoreTests/CoreTests.csproj"
    "Cql/CqlToElmTests/CqlToElmTests.csproj"
)

# Results tracking
NET8_PASSED=0
NET8_FAILED=0
NET10_PASSED=0
NET10_FAILED=0

for project in "${TEST_PROJECTS[@]}"; do
    PROJECT_PATH="$(dirname "$0")/$project"
    
    if [ ! -f "$PROJECT_PATH" ]; then
        echo -e "${YELLOW}Warning: Project not found: $project${NC}"
        continue
    fi
    
    PROJECT_NAME=$(basename "$project")
    
    echo -e "${CYAN}================================================================"
    echo -e "Testing: $PROJECT_NAME"
    echo -e "================================================================${NC}"
    echo ""
    
    # Build project
    echo -e "${YELLOW}Building $PROJECT_NAME...${NC}"
    if dotnet build "$PROJECT_PATH" --configuration "$CONFIGURATION" --nologo > /dev/null 2>&1; then
        echo -e "${GREEN}✓ Build succeeded${NC}"
    else
        echo -e "${RED}✗ Build failed${NC}"
        continue
    fi
    echo ""
    
    # Test on .NET 8
    echo -e "${YELLOW}Running tests on .NET 8...${NC}"
    if [ $VERBOSE -eq 1 ]; then
        dotnet test "$PROJECT_PATH" --configuration "$CONFIGURATION" --no-build --framework net8.0 --nologo --verbosity minimal
        NET8_RESULT=$?
    else
        dotnet test "$PROJECT_PATH" --configuration "$CONFIGURATION" --no-build --framework net8.0 --nologo --verbosity minimal > /dev/null 2>&1
        NET8_RESULT=$?
    fi
    
    if [ $NET8_RESULT -eq 0 ]; then
        echo -e "${GREEN}✓ .NET 8 tests PASSED${NC}"
        ((NET8_PASSED++))
    else
        echo -e "${RED}✗ .NET 8 tests FAILED${NC}"
        ((NET8_FAILED++))
    fi
    echo ""
    
    # Test on .NET 10
    echo -e "${YELLOW}Running tests on .NET 10...${NC}"
    if [ $VERBOSE -eq 1 ]; then
        dotnet test "$PROJECT_PATH" --configuration "$CONFIGURATION" --no-build --framework net10.0 --nologo --verbosity minimal
        NET10_RESULT=$?
    else
        dotnet test "$PROJECT_PATH" --configuration "$CONFIGURATION" --no-build --framework net10.0 --nologo --verbosity minimal > /dev/null 2>&1
        NET10_RESULT=$?
    fi
    
    if [ $NET10_RESULT -eq 0 ]; then
        echo -e "${GREEN}✓ .NET 10 tests PASSED${NC}"
        ((NET10_PASSED++))
    else
        echo -e "${RED}✗ .NET 10 tests FAILED${NC}"
        ((NET10_FAILED++))
    fi
    echo ""
    
    # Compare results
    if [ $NET8_RESULT -eq 0 ] && [ $NET10_RESULT -eq 0 ]; then
        echo -e "${GREEN}✓ Identical behavior: Tests pass on both frameworks${NC}"
    elif [ $NET8_RESULT -ne $NET10_RESULT ]; then
        echo -e "${YELLOW}⚠ Framework-specific failure detected!${NC}"
        echo -e "${YELLOW}Tests pass on one framework but fail on the other.${NC}"
    else
        echo -e "${RED}✗ Tests fail on both frameworks${NC}"
    fi
    echo ""
done

# Summary
echo -e "${CYAN}=================================================================="
echo -e "SUMMARY"
echo -e "==================================================================${NC}"
echo ""

echo -e "${YELLOW}.NET 8 Results:${NC}"
echo -e "  ${GREEN}Passed: $NET8_PASSED${NC}"
if [ $NET8_FAILED -gt 0 ]; then
    echo -e "  ${RED}Failed: $NET8_FAILED${NC}"
else
    echo -e "  ${GREEN}Failed: $NET8_FAILED${NC}"
fi
echo ""

echo -e "${YELLOW}.NET 10 Results:${NC}"
echo -e "  ${GREEN}Passed: $NET10_PASSED${NC}"
if [ $NET10_FAILED -gt 0 ]; then
    echo -e "  ${RED}Failed: $NET10_FAILED${NC}"
else
    echo -e "  ${GREEN}Failed: $NET10_FAILED${NC}"
fi
echo ""

# Overall assessment
if [ $NET8_FAILED -eq 0 ] && [ $NET10_FAILED -eq 0 ]; then
    echo -e "${GREEN}✓ SUCCESS: All tests pass on both .NET 8 and .NET 10${NC}"
    if [ $NET8_PASSED -eq $NET10_PASSED ]; then
        echo -e "${GREEN}✓ VERIFIED: Identical behavior across frameworks${NC}"
    fi
    exit 0
elif [ $NET8_PASSED -eq $NET10_PASSED ] && [ $NET8_FAILED -eq $NET10_FAILED ]; then
    echo -e "${RED}✗ FAILURE: Tests fail identically on both frameworks${NC}"
    exit 1
else
    echo -e "${YELLOW}⚠ WARNING: Framework-specific test failures detected!${NC}"
    echo -e "${YELLOW}This may indicate behavioral differences between .NET 8 and .NET 10${NC}"
    exit 1
fi

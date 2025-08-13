#!/bin/bash

# Generate Release Report Script for Firely CQL SDK
# This script generates a comprehensive release report for the specified tag

set -e

# Default values
TAG="v2.1.0-rc.1"
OUTPUT_FILE="release-report-${TAG}.html"
REPO_PATH="$(pwd)"

# Parse command line arguments
while [[ $# -gt 0 ]]; do
    case $1 in
        --tag)
            TAG="$2"
            OUTPUT_FILE="release-report-${TAG}.html"
            shift 2
            ;;
        --output)
            OUTPUT_FILE="$2"
            shift 2
            ;;
        --repo-path)
            REPO_PATH="$2"
            shift 2
            ;;
        --help)
            echo "Usage: $0 [OPTIONS]"
            echo ""
            echo "Generate a comprehensive release report for Firely CQL SDK"
            echo ""
            echo "Options:"
            echo "  --tag TAG            Git tag to generate report for (default: v2.1.0-rc.1)"
            echo "  --output FILE        Output HTML file path (default: release-report-{TAG}.html)"
            echo "  --repo-path PATH     Repository path (default: current directory)"
            echo "  --help               Show this help message"
            echo ""
            echo "Examples:"
            echo "  $0                           # Generate report for v2.1.0-rc.1"
            echo "  $0 --tag v2.0.0             # Generate report for v2.0.0"
            echo "  $0 --output my-report.html   # Custom output filename"
            exit 0
            ;;
        *)
            echo "Unknown option: $1"
            echo "Use --help for usage information"
            exit 1
            ;;
    esac
done

echo "🚀 Firely CQL SDK Release Report Generator"
echo "==========================================="
echo ""
echo "Tag:         $TAG"
echo "Output:      $OUTPUT_FILE"
echo "Repository:  $REPO_PATH"
echo ""

# Build the report generator if needed
echo "🔨 Building report generator..."
dotnet build "$REPO_PATH/tools/ReleaseReportGenerator/ReleaseReportGenerator/ReleaseReportGenerator.csproj" --verbosity quiet

# Generate the report
echo "📊 Generating release report..."
dotnet run --project "$REPO_PATH/tools/ReleaseReportGenerator/ReleaseReportGenerator/ReleaseReportGenerator.csproj" \
    --verbosity quiet \
    -- \
    --repository-path "$REPO_PATH" \
    --output "$OUTPUT_FILE" \
    --tag "$TAG"

echo ""
echo "✅ Release report generated successfully!"
echo "📄 Report saved to: $OUTPUT_FILE"
echo ""

# Try to open the report if we're in a desktop environment
if command -v xdg-open >/dev/null 2>&1; then
    echo "🌐 Opening report in browser..."
    xdg-open "$OUTPUT_FILE" 2>/dev/null || true
elif command -v open >/dev/null 2>&1; then
    echo "🌐 Opening report in browser..."
    open "$OUTPUT_FILE" 2>/dev/null || true
else
    echo "💡 To view the report, open $OUTPUT_FILE in your web browser"
fi

echo ""
echo "🎉 Done!"
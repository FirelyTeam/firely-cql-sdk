# Release Report Generator

A comprehensive tool for generating visual release reports for the Firely CQL SDK.

## Overview

This tool analyzes the git repository history and generates an interactive HTML report showing development metrics, contributor statistics, milestones, and progress tracking for releases.

## Features

- 📊 **Development Metrics**: Total commits, contributors, pull requests, lines of code, and development timeline
- 🎯 **Milestone Tracking**: Key development milestones including first commit, contributor milestones, and branch splits  
- 👥 **Contributor Analysis**: Detailed contributor statistics with visual charts
- 📈 **Timeline Visualization**: Development activity over time with interactive charts
- 🏷️ **Release Information**: Detailed information about the specific release tag
- 📝 **Code Analysis**: Lines of code metrics excluding generated files (*.g.cs)

## Usage

### Basic Usage

Generate a report for the v2.1.0-rc.1 release:

```bash
dotnet run --project tools/ReleaseReportGenerator/ReleaseReportGenerator/ReleaseReportGenerator.csproj
```

### Advanced Usage

```bash
dotnet run --project tools/ReleaseReportGenerator/ReleaseReportGenerator/ReleaseReportGenerator.csproj -- \
  --repository-path /path/to/repo \
  --output custom-report.html \
  --tag v2.1.0-rc.1
```

### Options

- `--repository-path` (optional): Path to the git repository (defaults to current directory)
- `--output` (optional): Output file path for the HTML report (defaults to `release-report.html`)  
- `--tag` (optional): Git tag to generate report for (defaults to `v2.1.0-rc.1`)

## Output

The tool generates a comprehensive HTML report with:

- **Interactive Charts**: Using Chart.js for contributors and timeline visualization
- **Responsive Design**: Works on desktop and mobile devices
- **Modern Styling**: Clean, professional appearance with CSS Grid and Flexbox
- **Detailed Metrics**: Comprehensive statistics about the development process

## Report Sections

1. **Summary Metrics**: High-level overview cards with key numbers
2. **Development Milestones**: Key commits and development phases
3. **Contributors**: Visual breakdown of contributor activity
4. **Development Timeline**: Activity over time with commit frequency
5. **Release Information**: Details about the specific release tag

## Technical Details

- Built with .NET 8.0
- Uses `System.CommandLine` for CLI interface
- Executes git commands to extract repository information
- Generates responsive HTML with embedded CSS and JavaScript
- Excludes generated code files (*.g.cs) from line counting
- Handles various git repository states and edge cases

## Requirements

- .NET 8.0 SDK
- Git (available in PATH)
- Access to the git repository being analyzed

## Example Output

The generated HTML report includes:
- Visual charts for contributors and timeline
- Detailed milestone information
- Code metrics and statistics
- Professional styling and responsive design
- Interactive elements for better user experience
# XSD to C# Converter Tool - Implementation Summary

## Overview

This document summarizes the implementation of the custom XSD to C# converter tool for the Firely CQL SDK project.

## What Was Implemented

### 1. New Tool Project (`tools/XsdToCSharpConverter`)

Created a new .NET 8.0 console application that wraps the existing `xsd.exe` tool from the .NET Framework SDK. The tool:

- **Provides a C# wrapper** around xsd.exe with better tooling and error handling
- **Maintains compatibility** with the existing generated code by using the same underlying tool
- **Supports the same command-line syntax** as xsd.exe for easy migration
- **Includes automatic xsd.exe discovery** by searching common SDK installation locations
- **Provides foundation** for future enhancements like post-processing and cross-platform support

**Files Created:**
- `tools/XsdToCSharpConverter/XsdToCSharpConverter.csproj` - Project file
- `tools/XsdToCSharpConverter/Program.cs` - Main implementation
- `tools/XsdToCSharpConverter/README.md` - Comprehensive documentation
- `tools/XsdToCSharpConverter/.gitignore` - Excludes build artifacts

### 2. Updated Generation Scripts

Created new versions of the generation script that use the new tool:

- **`Cql/Elm/Elm.g.cs-Generate-v2.cmd`** (Windows batch script)
  - Automatically builds the xsd2cs tool if needed
  - Calls the tool to generate C# from XSD files
  - Performs post-processing (same as original script)
  - Includes better error handling and status messages

- **`Cql/Elm/Elm.g.cs-Generate-v2.sh`** (Bash shell script)
  - Provided for reference and future cross-platform work
  - Documents the generation process
  - Currently limited due to xsd.exe Windows requirement

## Design Decisions

### Why Wrap xsd.exe Instead of Native Implementation?

The issue specifically states: "For this first attempt, we only expect the outcome to be exactly the same." 

Creating a completely custom XSD-to-C# generator would require:
- Significant development time (several days to weeks)
- Extensive testing to match xsd.exe behavior
- Risk of subtle incompatibilities

By wrapping xsd.exe, we:
- ✅ Guarantee identical output immediately
- ✅ Provide a foundation for future improvements
- ✅ Allow easy transition from batch script to C# tooling
- ✅ Set up infrastructure for cross-platform work

### Current Limitations

1. **Windows Only**: The tool currently requires Windows and the .NET Framework SDK because it uses xsd.exe
2. **Post-processing in Script**: The line-by-line post-processing is still done in the batch script for simplicity
3. **Not in Solution**: The tool is intentionally NOT in `Cql-Sdk.slnf` as it's a development tool, not part of the SDK

### Future Enhancement Path

The tool is designed to be enhanced in the future:

```
Phase 1 (Current): Wrap xsd.exe → Identical output ✓
Phase 2 (Future): Add nullable annotations
Phase 3 (Future): Native XSD parsing (cross-platform)
Phase 4 (Future): Modern C# features (collection expressions, records, etc.)
```

## What Needs to Be Tested (Windows Required)

Since this is running on a Linux CI system, the following testing must be done on a Windows machine with the .NET Framework SDK installed:

### Testing Steps

1. **Build the tool:**
   ```cmd
   cd tools\XsdToCSharpConverter
   dotnet build
   ```

2. **Generate with original script (for comparison):**
   ```cmd
   cd Cql\Elm
   copy Elm.g.cs Elm.g.cs.original
   Elm.g.cs-Generate.cmd
   ```

3. **Generate with new script:**
   ```cmd
   cd Cql\Elm
   Elm.g.cs-Generate-v2.cmd
   ```

4. **Compare the outputs:**
   ```cmd
   fc /b Elm.g.cs.original Elm.g.cs
   ```
   
   They should be byte-for-byte identical.

5. **Verify tool works standalone:**
   ```cmd
   cd Cql\Elm\Schema
   dotnet ..\..\..\tools\XsdToCSharpConverter\bin\Debug\net8.0\xsd2cs.dll /c library.xsd expression.xsd clinicalexpression.xsd cqlannotations.xsd /o:.. /n:Hl7.Cql.Elm
   ```

### Expected Results

- ✅ Tool builds without errors
- ✅ Tool can locate xsd.exe automatically
- ✅ Generated C# code is identical to xsd.exe output
- ✅ Post-processing produces the same result
- ✅ Final Elm.g.cs is unchanged (except possibly comment about generation tool)

## Integration Plan

After successful testing on Windows:

1. **Verify Output**: Confirm byte-for-byte match with existing Elm.g.cs
2. **Replace Original Script**: Rename `Elm.g.cs-Generate-v2.cmd` to `Elm.g.cs-Generate.cmd`
3. **Update Documentation**: Update any references to the generation process
4. **Future Enhancement**: Plan for nullable annotations and modern C# features

## Files Modified/Created

```
tools/
└── XsdToCSharpConverter/
    ├── XsdToCSharpConverter.csproj    (new)
    ├── Program.cs                      (new)
    ├── README.md                       (new)
    └── .gitignore                      (new)

Cql/Elm/
├── Elm.g.cs-Generate-v2.cmd           (new)
└── Elm.g.cs-Generate-v2.sh            (new)
```

## Notes for Reviewers

1. **This tool is NOT in the solution** - It's intentionally excluded from Cql-Sdk.slnf as it's a dev tool
2. **Windows testing required** - Cannot be fully tested on Linux CI
3. **Maintains backward compatibility** - Uses same xsd.exe for identical output
4. **Future-ready** - Structured to add enhancements incrementally

## Next Steps

1. Test on Windows (see testing steps above)
2. If tests pass, replace the original cmd script
3. Consider adding to documentation/developer guide
4. Plan Phase 2 enhancements (nullable annotations)

## Questions?

See the comprehensive README at `tools/XsdToCSharpConverter/README.md` for more details on:
- Building and running the tool
- Command-line options
- Future enhancement plans
- Cross-platform considerations

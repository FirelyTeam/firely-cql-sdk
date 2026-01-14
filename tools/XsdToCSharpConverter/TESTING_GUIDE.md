# Testing Guide for XSD to C# Converter Tool

This guide provides step-by-step instructions for testing the new XSD to C# converter tool on a Windows system.

## Prerequisites

- Windows operating system
- .NET 8.0 SDK or later
- .NET Framework SDK with xsd.exe tool (typically installed with Visual Studio)
- Git (to clone the repository)

## Testing Steps

### 1. Verify Tool Builds Successfully

```cmd
cd tools\XsdToCSharpConverter
dotnet build
```

**Expected output:**
- Build succeeds with no errors
- Output: `XsdToCSharpConverter -> ...\bin\Debug\net8.0\xsd2cs.dll`

### 2. Test Tool Directly

Test that the tool can find xsd.exe and parse arguments:

```cmd
cd Cql\Elm\Schema
dotnet ..\..\..\tools\XsdToCSharpConverter\bin\Debug\net8.0\xsd2cs.dll
```

**Expected output:**
- Usage information displayed
- No crashes or exceptions

### 3. Backup Current Generated File

Before testing generation, backup the current Elm.g.cs:

```cmd
cd Cql\Elm
copy Elm.g.cs Elm.g.cs.backup
```

### 4. Test Original Script (Baseline)

Generate with the original script to establish a baseline:

```cmd
cd Cql\Elm
Elm.g.cs-Generate.cmd
copy Elm.g.cs Elm.g.cs.original
```

### 5. Test New Script

Generate with the new script that uses the xsd2cs tool:

```cmd
cd Cql\Elm
Elm.g.cs-Generate-v2.cmd
```

**Expected output:**
- "Checking for XSD to C# converter tool..."
- "Using xsd.exe from: [path]"
- "Generating C# from XSD files using xsd2cs tool..."
- "Post-processing generated file..."
- "Successfully generated Elm.g.cs"
- No errors

### 6. Compare Outputs

Compare the two generated files byte-for-byte:

```cmd
fc /b Elm.g.cs.original Elm.g.cs
```

**Expected output:**
- "FC: no differences encountered" (or equivalent)
- If there are differences, they should only be in:
  - Comments about which tool generated the file
  - Whitespace (which should be identical anyway)

### 7. Visual Inspection

Open both files in a diff tool (e.g., WinMerge, Beyond Compare, or VS Code) and verify:

```cmd
code --diff Elm.g.cs.original Elm.g.cs
```

**What to check:**
- Class structures are identical
- Field names and types are identical
- Attributes are identical
- Only differences should be in generation comments (if any)

### 8. Verify Build Still Works

Build the solution to ensure the generated code is valid:

```cmd
cd ..\..\..
dotnet build Cql-Sdk.slnf
```

**Expected output:**
- Build succeeds with no errors
- All projects build successfully

### 9. Run Tests

If there are tests that depend on the generated code:

```cmd
dotnet test Cql-Sdk.slnf
```

**Expected output:**
- All tests pass
- No new failures compared to before regeneration

## Troubleshooting

### Issue: "xsd.exe not found"

**Solution:** Install the .NET Framework SDK or Visual Studio with the Windows SDK components.

Common locations for xsd.exe:
- `C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools\`
- `C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.7.2 Tools\`

### Issue: "Tool not found. Building XSD to C# converter..."

**Solution:** This is normal. The script will build the tool automatically. Wait for the build to complete.

### Issue: Files differ unexpectedly

**Possible causes:**
1. Different xsd.exe versions (check version with `xsd /?`)
2. Line ending differences (CRLF vs LF)
3. Timestamp in generated comments

**Investigation:**
- Check the xsd.exe version: `xsd /?`
- Look at specific differences in a text editor
- Verify file encodings are identical (UTF-8)

## Success Criteria

✅ Tool builds without errors
✅ Tool can locate xsd.exe automatically  
✅ xsd2cs can parse command-line arguments correctly
✅ Generation script completes without errors
✅ Generated Elm.g.cs is byte-for-byte identical (or only differs in generation comments)
✅ Solution still builds successfully
✅ All existing tests still pass

## After Successful Testing

Once all tests pass:

1. **Restore the backup if needed:**
   ```cmd
   copy Elm.g.cs.backup Elm.g.cs
   ```

2. **Consider replacing the original script:**
   - Rename `Elm.g.cs-Generate.cmd` to `Elm.g.cs-Generate-old.cmd`
   - Rename `Elm.g.cs-Generate-v2.cmd` to `Elm.g.cs-Generate.cmd`

3. **Update documentation** if needed to reference the new tool

4. **Commit the changes** (the generated file should not change, so no commit needed unless intentional)

## Reporting Results

When reporting test results, please include:

- Windows version
- .NET Framework SDK version
- xsd.exe version (`xsd /?`)
- Whether files matched exactly
- Any differences observed
- Build and test results

## Questions or Issues?

If you encounter any issues during testing:

1. Check the IMPLEMENTATION_SUMMARY.md for design decisions
2. Review the README.md for detailed tool documentation
3. Open a GitHub issue with:
   - Steps to reproduce
   - Expected vs actual behavior
   - Error messages (if any)
   - Environment details (OS, SDK versions, etc.)

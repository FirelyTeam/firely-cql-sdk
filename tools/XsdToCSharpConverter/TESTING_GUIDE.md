# Testing Guide for XSD to C# Converter Tool (xsd2cs)

This guide provides comprehensive testing procedures for the xsd2cs tool, covering development testing, unit tests, and validation against xsd.exe output.

## Prerequisites

- .NET 8.0 SDK or later
- Git (to clone the repository)
- Optional: Microsoft xsd.exe tool for comparison testing (Windows only)

## Quick Start - Running All Tests

### 1. Build the Tool

```bash
cd tools/XsdToCSharpConverter
dotnet build
```

**Expected output:**
- Build succeeds with no errors
- Output: `XsdToCSharpConverter -> .../bin/Debug/net8.0/xsd2cs.dll`

### 2. Run Unit Tests

**XsdToCSharpConverterTests** (Round-trip serialization):
```bash
cd tools/XsdToCSharpConverterTests
dotnet test
```

**ElmSerializerTests** (Comprehensive feature validation):
```bash
cd Cql/CoreTests
dotnet test --filter "FullyQualifiedName~ElmSerializer"
```

**Expected output:**
- All 13+ tests pass
- 0 failures

### 3. Generate Elm.g.cs and Validate

**Windows:**
```cmd
cd Cql\Elm
Elm.g.cs-Generate-xsd2cs.cmd
```

**Expected output:**
- Tool builds automatically if needed
- Generation completes successfully
- Elm.g.cs created with ~7076 lines

## Comprehensive Testing Procedures

### Test 1: Tool Compilation

**Purpose**: Verify the tool builds successfully

**Steps:**
```bash
cd tools/XsdToCSharpConverter
dotnet clean
dotnet build
```

**Success criteria:**
- ✅ Build completes with 0 errors
- ✅ Assembly version is 1.0.0
- ✅ Output file xsd2cs.dll created

### Test 2: Command-Line Interface

**Purpose**: Validate command-line argument parsing

**Test basic help:**
```bash
dotnet tools/XsdToCSharpConverter/bin/Debug/net8.0/xsd2cs.dll
```

**Expected**: Usage information displayed

**Test with schema files:**
```bash
cd Cql/Elm/Schema
dotnet ../../../tools/XsdToCSharpConverter/bin/Debug/net8.0/xsd2cs.dll /c /o:.. /n:Hl7.Cql.Elm /out:TestElm.g.cs library.xsd expression.xsd clinicalexpression.xsd cqlannotations.xsd
```

**Success criteria:**
- ✅ No errors or exceptions
- ✅ TestElm.g.cs created in Cql/Elm directory
- ✅ File size ~7076 lines

### Test 3: Generated Code Validation

**Purpose**: Ensure generated code compiles and has correct structure

**Steps:**
1. Generate Elm.g.cs using the tool
2. Build the solution

```cmd
cd Cql\Elm
Elm.g.cs-Generate-xsd2cs.cmd
cd ..\..
dotnet build Cql-Sdk.slnf
```

**Success criteria:**
- ✅ Generation succeeds
- ✅ Build completes with 0 errors
- ✅ 184 pre-existing warnings (unrelated to generation)

### Test 4: Unit Test Suite

**Purpose**: Validate all features with comprehensive tests

**ElmSerializerTests (13 tests):**

1. **Basic deserialization:**
   - Test: `Elm_Deserialize_TupleTypeSpecifier`
   - Validates: Basic XML/JSON deserialization

2. **Full library round-trip:**
   - Test: `Elm_Deserialize_FhirHelpers`
   - Validates: Complete library serialization/deserialization

3. ***Specified pattern:**
   - Test: `DeserializeFieldSpecifiedElement`
   - Validates: Optional value type boolean flags

4. **Mixed content:**
   - Test: `Elm_Deserialize_MixedXmlAnnotations`
   - Validates: XML mixed content with annotations

5. **DefaultValueAttribute (bool):**
   - Test: `DefaultValueAttribute_ReturnClauseDistinct_InitializesToTrue`
   - Validates: Bool default value and constructor initialization

6. **DefaultValueAttribute (string):**
   - Test: `DefaultValueAttribute_IncludeDefMediaType_InitializesToApplicationElmXml`
   - Validates: String default with DataType attribute

7. **DefaultValueAttribute (enum):**
   - Test: `DefaultValueAttribute_EnumAccessLevel_InitializesToPublic`
   - Validates: Enum default value with proper type casting

8. **XmlElementAttribute:**
   - Test: `XmlElementAttribute_AnnotationArray_GeneratesCorrectly`
   - Validates: Direct array element attributes

9. ***Specified serialization:**
   - Test: `SpecifiedPattern_FluentAttribute_OnlySerializedWhenSpecified`
   - Validates: Conditional serialization based on Specified flag

10. **XmlIncludeAttribute:**
    - Test: `XmlIncludeAttribute_ExpressionBaseClass_DeclaresAllDerivedTypes`
    - Validates: Polymorphic type hierarchy declaration

11. **Abstract types:**
    - Test: `AbstractTypes_Element_IsAbstractClass`
    - Validates: Abstract modifier on classes

12. **Type ordering:**
    - Test: `TypeOrdering_LibraryClass_IsFirstType`
    - Validates: Root element types first, XmlRootAttribute present

13. **Tool identification:**
    - Test: `GeneratedCodeAttribute_HasCorrectToolNameAndVersion`
    - Validates: GeneratedCodeAttribute with "xsd2cs" and version

**Run all tests:**
```bash
cd Cql/CoreTests
dotnet test --filter "FullyQualifiedName~ElmSerializer"
```

**Success criteria:**
- ✅ All 13 tests pass
- ✅ 0 failures
- ✅ All validations successful

### Test 5: XsdToCSharpConverterTests

**Purpose**: Validate round-trip serialization with real ELM libraries

**Tests included:**
1. LoadAndSave_DemoLibrarySet_ProducesIdenticalJson
2. LoadAndRoundTrip_SingleLibrary_PreservesStructure
3. LoadElmLibrary_WithDefaultValues_InitializesCorrectly

**Run tests:**
```bash
cd tools/XsdToCSharpConverterTests
dotnet test
```

**Success criteria:**
- ✅ All tests pass
- ✅ 37+ libraries load successfully
- ✅ JSON serialization produces identical output
- ✅ Round-trip preserves structure

### Test 6: Comparison with xsd.exe (Optional, Windows Only)

**Purpose**: Validate functional equivalence with Microsoft's xsd.exe

**Prerequisites:**
- Windows system
- .NET Framework SDK with xsd.exe

**Steps:**

1. Generate with xsd.exe:
```cmd
cd Cql\Elm
Elm.g.cs-Generate-xsd.cmd
copy Elm.g.cs Elm.g.cs.old
```

2. Generate with xsd2cs:
```cmd
Elm.g.cs-Generate-xsd2cs.cmd
```

3. Compare outputs:
```cmd
fc Elm.g.cs.old Elm.g.cs
```

**Expected differences:**
- GeneratedCodeAttribute tool name: "xsd" vs "xsd2cs"
- GeneratedCodeAttribute version: xsd.exe version vs "1.0.0.0"
- XmlIncludeAttribute count: 756 (xsd.exe transitive) vs 246 (xsd2cs direct)
- Line count: 7898 vs 7076 (due to XmlInclude difference)

**Functional equivalence:**
- ✅ Same class structures
- ✅ Same property names and types
- ✅ Same XmlElement, XmlArray, XmlAttribute attributes
- ✅ Same DefaultValueAttribute instances (12)
- ✅ Same *Specified patterns (148)
- ✅ Both compile successfully
- ✅ Both serialize/deserialize identically

### Test 7: Runtime Usage Validation

**Purpose**: Ensure generated code works in real-world scenarios

**Steps:**

1. Run CqlSdkExamples:
```bash
cd Examples/CqlSdkExamples
dotnet run
```

2. Verify ELM loading:
```bash
# Look for successful library loading messages
# No deserialization errors should occur
```

**Success criteria:**
- ✅ CqlSdkExamples runs without errors
- ✅ ELM JSON files load successfully
- ✅ No JSON deserialization exceptions
- ✅ PolymorphicTypeResolver discovers type hierarchies

### Test 8: Cross-Platform Validation

**Purpose**: Verify tool works on all platforms

**Windows:**
```cmd
cd Cql\Elm
Elm.g.cs-Generate-xsd2cs.cmd
```
```cmd
cd Cql\Elm
Elm.g.cs-Generate-xsd2cs.cmd
```

**Success criteria:**
- ✅ Tool builds and runs on all platforms
- ✅ Generated output identical across platforms
- ✅ No platform-specific issues

## Troubleshooting

### Issue: Build Fails

**Symptom:** `dotnet build` fails with errors

**Solutions:**
1. Verify .NET 8.0 SDK installed: `dotnet --version`
2. Clean and rebuild: `dotnet clean && dotnet build`
3. Check for corrupted packages: `rm -rf bin obj && dotnet restore`

### Issue: Unit Tests Fail

**Symptom:** Test failures in ElmSerializerTests or XsdToCSharpConverterTests

**Solutions:**
1. Regenerate Elm.g.cs: `cd Cql\Elm && Elm.g.cs-Generate-xsd2cs.cmd`
2. Rebuild solution: `dotnet build Cql-Sdk.slnf`
3. Check test output for specific failure details
4. Verify LibrarySets/Demo/Elm directory exists and contains files

### Issue: Generated Code Doesn't Compile

**Symptom:** Build errors after generating Elm.g.cs

**Solutions:**
1. Compare with known-good version (Elm.g.cs.old from xsd.exe)
2. Check for schema file changes
3. Verify all 4 schema files passed to tool (library.xsd, expression.xsd, clinicalexpression.xsd, cqlannotations.xsd)
4. Review error messages for missing types or attributes

### Issue: JSON Deserialization Fails

**Symptom:** Runtime errors when loading ELM JSON files

**Solutions:**
1. Verify XmlIncludeAttribute present on base classes (Expression, Element, etc.)
2. Check XmlElementAttribute on array properties
3. Verify type ordering (Library class should be first)
4. Run ElmSerializerTests to isolate issue

## Validation Checklist

Use this checklist to ensure complete validation:

- [ ] Tool builds successfully (0 errors)
- [ ] Command-line interface works correctly
- [ ] Generated Elm.g.cs compiles (0 errors)
- [ ] All 13 ElmSerializerTests pass
- [ ] All XsdToCSharpConverterTests pass
- [ ] CqlSdkExamples runs successfully
- [ ] Cross-platform: Works on Linux
- [ ] Cross-platform: Works on macOS
- [ ] Cross-platform: Works on Windows
- [ ] Optional: Compared with xsd.exe output
- [ ] Optional: Verified functional equivalence

## Success Criteria Summary

✅ **Tool builds** with 0 errors on all platforms
✅ **Generated code compiles** with 0 errors
✅ **All unit tests pass** (13+ tests)
✅ **Runtime usage works** (CqlSdkExamples)
✅ **JSON serialization/deserialization** functions correctly
✅ **XML serialization/deserialization** functions correctly
✅ **Functional equivalence** with xsd.exe validated
✅ **Cross-platform** compatibility confirmed

## Reporting Test Results

When reporting test results, please include:

1. **Platform**: Windows/Linux/macOS, version
2. **.NET SDK version**: `dotnet --version`
3. **Build result**: Success/Failure, error count
4. **Unit test results**: Pass/Fail count
5. **Generated file size**: Line count of Elm.g.cs
6. **Any differences** from expected results
7. **Error messages** if any failures occurred

## Continuous Testing

For ongoing development:

1. **Before commits**: Run unit tests
2. **After schema changes**: Regenerate and validate
3. **Before releases**: Full test suite including comparison with xsd.exe
4. **Platform testing**: Validate on all target platforms

## Questions or Issues?

If you encounter issues not covered in this guide:

1. Review IMPLEMENTATION_SUMMARY.md for design details
2. Check REFERENCE_SOURCE_COMPARISON.md for xsd.exe comparison
3. Review README.md for usage documentation
4. Open a GitHub issue with:
   - Steps to reproduce
   - Expected vs actual behavior
   - Test output and error messages
   - Environment details (OS, .NET version)

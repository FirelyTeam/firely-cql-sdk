# CQL Specification Content Guide

This guide explains how to provide CQL specification content for enhanced conformance analysis.

## Why We Need Spec Content

The comprehensive deviations report (`cql-spec-deviations-report.md`) identifies potential spec violations, but direct access to the official CQL specification at https://cql.hl7.org/ is currently blocked. Having the spec content allows for:

1. **Verification** of reported deviations against exact spec language
2. **Discovery** of additional conformance issues
3. **Clarification** of ambiguous behaviors (e.g., ProperContains null handling)
4. **Documentation** with authoritative quotes

## How to Provide Spec Content

### Method 1: Local Files (Recommended)

Save the CQL specification pages as local files in the repository:

```bash
# Create spec directory
mkdir -p docs/spec

# Save each page:
# Download from https://cql.hl7.org/
curl https://cql.hl7.org/02-authorsguide.html > docs/spec/02-authorsguide.html
curl https://cql.hl7.org/03-developersguide.html > docs/spec/03-developersguide.html
curl https://cql.hl7.org/09-b-cqlreference.html > docs/spec/09-b-cqlreference.html
curl https://cql.hl7.org/elm.html > docs/spec/elm.html
curl https://cql.hl7.org/examples.html > docs/spec/examples.html
curl https://cql.hl7.org/tests.html > docs/spec/tests.html

# Or as markdown/text if you convert them
```

Once files are in the repository, the analysis agent can read them with the `view` tool.

### Method 2: Direct Copy-Paste

For specific sections, copy the relevant spec text and paste it in the conversation. Example:

```
Here's the spec for Power operator from section 9.2:

"The Power operator raises the first argument to the power given by the 
second argument. If either argument is null, the result is null. For 
integer and decimal types, the result type is decimal..."
```

### Method 3: Create Excerpts File

Create a file with key excerpts for the identified deviations:

```bash
# Create excerpts file
cat > docs/spec/DEVIATION_EXCERPTS.md << 'EOF'
# CQL Spec Excerpts for Known Deviations

## Power Operator (Section 9.2)
[Paste exact spec text here]

## ProperContains (Section 9.11)  
[Paste exact spec text here]

## Round (Section 9.2)
[Paste exact spec text here]

## Expand (Section 9.11)
[Paste exact spec text here]

## List Equality (Section 9.4)
[Paste exact spec text here]
EOF
```

## Priority Sections Needed

Based on the deviations report, these sections are most critical:

### High Priority

1. **Power Operator** (affects 10 tests)
   - Section: https://cql.hl7.org/09-b-cqlreference.html#power
   - Need: Exact return type specification for fractional results

2. **List Equality with Null** (affects 1 test)
   - Section: https://cql.hl7.org/09-b-cqlreference.html#equal
   - Need: Null element handling in list equality

3. **Substring Operator** (potential bug)
   - Section: https://cql.hl7.org/09-b-cqlreference.html#substring
   - Need: Length parameter semantics

### Medium Priority

4. **ProperContains/ProperIn** (affects 2 tests)
   - Section: https://cql.hl7.org/09-b-cqlreference.html#propercontains
   - Need: Precision mismatch behavior

5. **Round** (affects 2 tests)
   - Section: https://cql.hl7.org/09-b-cqlreference.html#round
   - Need: Midpoint rounding mode specification

6. **Expand** (affects 2 tests)
   - Section: https://cql.hl7.org/09-b-cqlreference.html#expand-1
   - Need: Type preservation rules

7. **EndsWith** (potential bug)
   - Section: https://cql.hl7.org/09-b-cqlreference.html#endswith
   - Need: Behavior when suffix longer than argument

8. **Matches** (potential bug)
   - Section: https://cql.hl7.org/09-b-cqlreference.html#matches
   - Need: Anchoring and pattern matching rules

## Format Preferences

- **HTML**: Original format, can be processed
- **Markdown**: Easier to read and quote
- **Plain Text**: Also acceptable
- **PDF**: Can work if converted to text

## What Happens Next

Once spec content is provided:

1. ✅ Agent reads the content from local files or conversation
2. ✅ Verifies each reported deviation against exact spec language
3. ✅ Discovers additional conformance issues
4. ✅ Updates deviations report with authoritative quotes
5. ✅ Clarifies ambiguous cases (e.g., ProperContains)
6. ✅ Provides definitive fix recommendations
7. ✅ Creates ready-to-implement GitHub issues

## Example Workflow

```bash
# 1. You save spec files locally
mkdir -p docs/spec
# ... download spec pages ...

# 2. Commit to repository
git add docs/spec/
git commit -m "Add CQL specification for conformance analysis"

# 3. Agent reads files
# Agent: view docs/spec/09-b-cqlreference.html

# 4. Enhanced analysis produced
# - Verified deviations with exact quotes
# - Additional issues discovered
# - Clear fix guidance with spec support
```

## Alternative: Progressive Enhancement

If providing all specs at once is too much, we can work iteratively:

1. **Start with Power operator** (highest impact - 10 tests)
2. **Then Substring bug** (potential data corruption)
3. **Then List equality** (clear spec requirement)
4. **Continue with medium priority items**

Just provide the relevant spec sections as needed!

---

**Note:** The `.gitignore` should exclude large spec files from commits if desired:

```gitignore
# Optionally ignore large spec files
docs/spec/*.html
docs/spec/*.pdf
```

But markdown excerpts are lightweight and valuable to commit.

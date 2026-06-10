# 02. InternalsVisibleTo Configuration

## 2.1 Overview

2.1.1 Always add InternalsVisibleTo attributes in .csproj files, never in AssemblyInfo.cs files.

## 2.2 Format

2.2.1 Use the following format in csproj files:

```xml
<ItemGroup>
    <InternalsVisibleTo Include="ProjectName" Key="$(LibraryPKHash)" />
</ItemGroup>
```

## 2.3 Example

2.3.1 Example configuration:

```xml
<ItemGroup>
    <InternalsVisibleTo Include="Hl7.Cql.Runtime" Key="$(LibraryPKHash)" />
    <InternalsVisibleTo Include="CoreTests" Key="$(LibraryPKHash)" />
    <InternalsVisibleTo Include="CqlSdkExamplesPreview" Key="$(LibraryPKHash)" />
</ItemGroup>
```

## 2.4 Key Points

2.4.1 Always use the Key="$(LibraryPKHash)" attribute for signed assemblies.

2.4.2 Add to existing ItemGroup containing other InternalsVisibleTo entries if available.

2.4.3 Never modify or create AssemblyInfo.cs files for this purpose.

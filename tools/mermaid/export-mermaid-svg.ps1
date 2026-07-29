#!/usr/bin/env pwsh
# Script: export-mermaid-svg.ps1
# Description: Render Mermaid diagrams (inline ```mermaid fences in a markdown file, or a
#              standalone .mmd source file) to .svg via @mermaid-js/mermaid-cli, so docs can
#              embed a pre-rendered image instead of relying on the host's inline Mermaid
#              renderer (GitHub's renderer does not reliably support every Mermaid feature,
#              e.g. classDiagram `namespace` blocks and multi-target `style` directives).
# Usage: ./export-mermaid-svg.ps1 -MarkdownPath <path> [-SourcePath <path>] [-OutputDir <dir>]
#                                  [-RewriteMarkdown] [-ImageAltPrefix <text>]
#
# Adapted from https://github.com/FirelyTeam/firely-dqm-libraries/blob/main/devops/export-mermaid-svg.ps1
param(
    [Parameter(Mandatory = $true)]
    [string]$MarkdownPath,
    [string]$SourcePath,
    [string]$OutputDir,
    [switch]$RewriteMarkdown,
    [string]$ImageAltPrefix = 'Mermaid Diagram'
)

Set-StrictMode -Version Latest
$ErrorActionPreference = 'Stop'

function Get-RelativePathUnix {
    param(
        [Parameter(Mandatory = $true)][string]$FromDirectory,
        [Parameter(Mandatory = $true)][string]$ToPath
    )

    $relative = [System.IO.Path]::GetRelativePath($FromDirectory, $ToPath)
    return $relative.Replace('\\', '/').Replace('\', '/')
}

function Set-SvgIntrinsicSize {
    # mmdc emits width="100%" on the root <svg> (plus a max-width style, which some renderers --
    # e.g. GitHub's SVG sanitizer -- strip). Without an absolute width, a narrow/short diagram
    # gets stretched to fill its container's full width instead of displaying at its natural
    # size, making everything inside it look oversized. Pin width/height to the viewBox so the
    # diagram always displays at its actual rendered size (still free to shrink on narrow
    # viewports via the host's responsive-image CSS, just never stretched larger).
    param([Parameter(Mandatory = $true)][string]$SvgPath)

    $svgContent = Get-Content -Path $SvgPath -Raw -Encoding utf8
    if ($svgContent -match 'viewBox="[\d.]+\s+[\d.]+\s+([\d.]+)\s+([\d.]+)"') {
        $width = $Matches[1]
        $height = $Matches[2]
        $updated = $svgContent -replace 'width="100%"', "width=`"$width`" height=`"$height`""
        Set-Content -Path $SvgPath -Value $updated -Encoding utf8 -NoNewline
    }
}

$repoRoot = (git rev-parse --show-toplevel).Trim()
if ([string]::IsNullOrWhiteSpace($repoRoot)) {
    throw 'Unable to determine repository root. Run this script inside a git repository.'
}

$resolvedMarkdownPath = (Resolve-Path $MarkdownPath).Path
if (-not (Test-Path $resolvedMarkdownPath -PathType Leaf)) {
    throw "Markdown file not found: $MarkdownPath"
}

$markdownDirectory = Split-Path -Parent $resolvedMarkdownPath
$markdownBaseName = [System.IO.Path]::GetFileNameWithoutExtension($resolvedMarkdownPath)

if ([string]::IsNullOrWhiteSpace($OutputDir)) {
    $resolvedOutputDirectory = $markdownDirectory
}
else {
    $resolvedOutputDirectory = Join-Path $repoRoot $OutputDir
}

New-Item -ItemType Directory -Force -Path $resolvedOutputDirectory | Out-Null

$puppeteerConfigPath = Join-Path $repoRoot 'temp/puppeteer-config.json'
if (-not (Test-Path $puppeteerConfigPath -PathType Leaf)) {
    New-Item -ItemType Directory -Force -Path (Split-Path -Parent $puppeteerConfigPath) | Out-Null
    '{"args":["--no-sandbox"]}' | Set-Content -Path $puppeteerConfigPath -Encoding utf8
}

$markdownContent = Get-Content -Path $resolvedMarkdownPath -Raw -Encoding utf8
$mermaidRegex = [regex]'```mermaid\s*\r?\n(?<body>[\s\S]*?)\r?\n```'
$matches = $mermaidRegex.Matches($markdownContent)

if ($matches.Count -eq 0) {
    $resolvedSourcePath = if (-not [string]::IsNullOrWhiteSpace($SourcePath)) {
        (Resolve-Path $SourcePath).Path
    }
    else {
        $candidate = Join-Path $markdownDirectory ($markdownBaseName + '.mmd')
        if (Test-Path $candidate -PathType Leaf) {
            (Resolve-Path $candidate).Path
        }
        else {
            ''
        }
    }

    if ([string]::IsNullOrWhiteSpace($resolvedSourcePath)) {
        throw "No Mermaid blocks found in markdown and no Mermaid source file available. Expected: $markdownBaseName.mmd"
    }

    # Name the output after the .mmd source, not the markdown file -- one markdown doc can
    # embed several diagrams (each with its own -SourcePath), and they must not collide on
    # the same output filename.
    $sourceBaseName = [System.IO.Path]::GetFileNameWithoutExtension($resolvedSourcePath)
    $svgOutPath = Join-Path $resolvedOutputDirectory ($sourceBaseName + '.svg')

    & npx -y @mermaid-js/mermaid-cli -i $resolvedSourcePath -o $svgOutPath --puppeteerConfigFile $puppeteerConfigPath
    if ($LASTEXITCODE -ne 0) {
        throw "Mermaid render failed for: $resolvedSourcePath"
    }
    Set-SvgIntrinsicSize -SvgPath $svgOutPath

    Write-Host ''
    Write-Host 'Mermaid export completed.' -ForegroundColor Green
    Write-Host "  Markdown file : $(Get-RelativePathUnix -FromDirectory $repoRoot -ToPath $resolvedMarkdownPath)" -ForegroundColor Gray
    Write-Host '  Blocks found  : 0 (using separate Mermaid source file)' -ForegroundColor Gray
    Write-Host "  Source file   : $(Get-RelativePathUnix -FromDirectory $repoRoot -ToPath $resolvedSourcePath)" -ForegroundColor Gray
    Write-Host "  SVG output    : $(Get-RelativePathUnix -FromDirectory $repoRoot -ToPath $svgOutPath)" -ForegroundColor Gray
    Write-Host "  Rewritten MD  : $RewriteMarkdown" -ForegroundColor Gray
    return
}

$replacementMap = @{}
$generatedArtifacts = New-Object System.Collections.Generic.List[string]

for ($i = 0; $i -lt $matches.Count; $i++) {
    $ordinal = $i + 1
    $baseName = if ($matches.Count -eq 1) {
        $markdownBaseName
    }
    else {
        '{0}.diagram-{1:d2}' -f $markdownBaseName, $ordinal
    }

    $mmdPath = Join-Path $resolvedOutputDirectory ($baseName + '.mmd')
    $svgPath = Join-Path $resolvedOutputDirectory ($baseName + '.svg')

    $body = $matches[$i].Groups['body'].Value
    Set-Content -Path $mmdPath -Value $body -Encoding utf8

    & npx -y @mermaid-js/mermaid-cli -i $mmdPath -o $svgPath --puppeteerConfigFile $puppeteerConfigPath
    if ($LASTEXITCODE -ne 0) {
        throw "Mermaid render failed for: $mmdPath"
    }
    Set-SvgIntrinsicSize -SvgPath $svgPath

    $generatedArtifacts.Add((Get-RelativePathUnix -FromDirectory $repoRoot -ToPath $mmdPath))
    $generatedArtifacts.Add((Get-RelativePathUnix -FromDirectory $repoRoot -ToPath $svgPath))

    if ($RewriteMarkdown) {
        $relativeMmd = Get-RelativePathUnix -FromDirectory $markdownDirectory -ToPath $mmdPath
        $relativeSvg = Get-RelativePathUnix -FromDirectory $markdownDirectory -ToPath $svgPath
        $altText = if ($matches.Count -eq 1) { $ImageAltPrefix } else { "$ImageAltPrefix $ordinal" }

        $replacement = @(
            "Mermaid source: [$([System.IO.Path]::GetFileName($mmdPath))]($relativeMmd)",
            '',
            "![$altText]($relativeSvg)"
        ) -join "`n"

        $replacementMap[$matches[$i].Index] = [pscustomobject]@{
            Length = $matches[$i].Length
            Text = $replacement
        }
    }
}

if ($RewriteMarkdown) {
    $builder = New-Object System.Text.StringBuilder
    $cursor = 0

    $sortedKeys = $replacementMap.Keys | Sort-Object
    foreach ($key in $sortedKeys) {
        $segmentLength = $key - $cursor
        if ($segmentLength -gt 0) {
            [void]$builder.Append($markdownContent.Substring($cursor, $segmentLength))
        }

        [void]$builder.Append($replacementMap[$key].Text)
        $cursor = $key + $replacementMap[$key].Length
    }

    if ($cursor -lt $markdownContent.Length) {
        [void]$builder.Append($markdownContent.Substring($cursor))
    }

    Set-Content -Path $resolvedMarkdownPath -Value $builder.ToString() -Encoding utf8
}

Write-Host ''
Write-Host 'Mermaid export completed.' -ForegroundColor Green
Write-Host "  Markdown file : $(Get-RelativePathUnix -FromDirectory $repoRoot -ToPath $resolvedMarkdownPath)" -ForegroundColor Gray
Write-Host "  Blocks found  : $($matches.Count)" -ForegroundColor Gray
Write-Host "  Rewritten MD  : $RewriteMarkdown" -ForegroundColor Gray
Write-Host '  Artifacts:' -ForegroundColor Gray
foreach ($artifact in $generatedArtifacts) {
    Write-Host "    - $artifact" -ForegroundColor Gray
}

#!/usr/bin/env bash
# Script: export-mermaid-svg.sh
# Description: Render Mermaid diagrams (inline ```mermaid fences in a markdown file, or a
#              standalone .mmd source file) to .svg via @mermaid-js/mermaid-cli, so docs can
#              embed a pre-rendered image instead of relying on the host's inline Mermaid
#              renderer (GitHub's renderer does not reliably support every Mermaid feature,
#              e.g. classDiagram `namespace` blocks and multi-target `style` directives).
# Usage: ./export-mermaid-svg.sh --markdown-path <path> [--source-path <path>] [--output-dir <dir>]
#                                 [--rewrite-markdown] [--image-alt-prefix <text>]
#
# Adapted from https://github.com/FirelyTeam/firely-dqm-libraries/blob/main/devops/export-mermaid-svg.ps1

set -e

MARKDOWN_PATH=""
SOURCE_PATH=""
OUTPUT_DIR=""
REWRITE_MARKDOWN=0
IMAGE_ALT_PREFIX="Mermaid Diagram"

while [[ $# -gt 0 ]]; do
    case $1 in
        --markdown-path) MARKDOWN_PATH="$2"; shift 2 ;;
        --source-path) SOURCE_PATH="$2"; shift 2 ;;
        --output-dir) OUTPUT_DIR="$2"; shift 2 ;;
        --rewrite-markdown) REWRITE_MARKDOWN=1; shift ;;
        --image-alt-prefix) IMAGE_ALT_PREFIX="$2"; shift 2 ;;
        --help)
            echo "Usage: $0 --markdown-path <path> [--source-path <path>] [--output-dir <dir>] [--rewrite-markdown] [--image-alt-prefix <text>]"
            exit 0
            ;;
        *)
            echo "Unknown option: $1" >&2
            exit 1
            ;;
    esac
done

if [[ -z "$MARKDOWN_PATH" ]]; then
    echo "Error: --markdown-path is required" >&2
    exit 1
fi

if [[ ! -f "$MARKDOWN_PATH" ]]; then
    echo "Error: markdown file not found: $MARKDOWN_PATH" >&2
    exit 1
fi

GIT_TOPLEVEL="$(git rev-parse --show-toplevel)"
if [[ -z "$GIT_TOPLEVEL" ]]; then
    echo "Error: unable to determine repository root. Run this script inside a git repository." >&2
    exit 1
fi
# Re-resolve through cd/pwd (not git's raw output) so REPO_ROOT is in the same path
# style/case as every other path this script resolves -- on some Git-for-Windows/MSYS
# setups `git rev-parse` and `pwd` disagree on drive-path representation, and mixing the
# two styles produces garbage when Perl's File::Spec computes a relative path between them.
REPO_ROOT="$(cd "$GIT_TOPLEVEL" && pwd)"

resolve_abs() {
    # Portable absolute-path resolution (macOS ships a BSD `realpath` without
    # GNU extensions, so this avoids depending on `realpath -f`/`--relative-to`).
    local target="$1"
    local dir base
    dir="$(cd "$(dirname "$target")" && pwd)"
    base="$(basename "$target")"
    echo "$dir/$base"
}

RESOLVED_MARKDOWN_PATH="$(resolve_abs "$MARKDOWN_PATH")"
MARKDOWN_DIRECTORY="$(dirname "$RESOLVED_MARKDOWN_PATH")"
MARKDOWN_BASE_NAME="$(basename "$RESOLVED_MARKDOWN_PATH")"
MARKDOWN_BASE_NAME="${MARKDOWN_BASE_NAME%.*}"

if [[ -z "$OUTPUT_DIR" ]]; then
    RESOLVED_OUTPUT_DIRECTORY="$MARKDOWN_DIRECTORY"
else
    RESOLVED_OUTPUT_DIRECTORY="$REPO_ROOT/$OUTPUT_DIR"
fi

mkdir -p "$RESOLVED_OUTPUT_DIRECTORY"

PUPPETEER_CONFIG_PATH="$REPO_ROOT/temp/puppeteer-config.json"
if [[ ! -f "$PUPPETEER_CONFIG_PATH" ]]; then
    mkdir -p "$(dirname "$PUPPETEER_CONFIG_PATH")"
    printf '{"args":["--no-sandbox"]}' > "$PUPPETEER_CONFIG_PATH"
fi

relpath() {
    # Pure-Perl relative-path helper: portable across Linux/macOS/Git-Bash without
    # depending on GNU coreutils' `realpath --relative-to` (unavailable on stock macOS).
    perl -MFile::Spec -e 'print File::Spec->abs2rel($ARGV[1], $ARGV[0])' "$1" "$2"
}

set_svg_intrinsic_size() {
    # mmdc emits width="100%" on the root <svg> (plus a max-width style, which some renderers --
    # e.g. GitHub's SVG sanitizer -- strip). Without an absolute width, a narrow/short diagram
    # gets stretched to fill its container's full width instead of displaying at its natural
    # size, making everything inside it look oversized. Pin width/height to the viewBox so the
    # diagram always displays at its actual rendered size (still free to shrink on narrow
    # viewports via the host's responsive-image CSS, just never stretched larger).
    local svg_path="$1"
    perl -0777 -e '
        local $/;
        open(my $fh, "<:utf8", $ARGV[0]) or die "Cannot read $ARGV[0]: $!";
        my $content = <$fh>;
        close $fh;
        if ($content =~ /viewBox="[\d.]+\s+[\d.]+\s+([\d.]+)\s+([\d.]+)"/) {
            my ($w, $h) = ($1, $2);
            $content =~ s/width="100%"/width="$w" height="$h"/;
        }
        open(my $out, ">:utf8", $ARGV[0]) or die "Cannot write $ARGV[0]: $!";
        print $out $content;
        close $out;
    ' "$svg_path"
}

render_svg() {
    local src="$1" out="$2"
    if ! npx -y @mermaid-js/mermaid-cli -i "$src" -o "$out" --puppeteerConfigFile "$PUPPETEER_CONFIG_PATH"; then
        echo "Error: Mermaid render failed for: $src" >&2
        exit 1
    fi
    set_svg_intrinsic_size "$out"
}

BLOCK_COUNT="$(perl -0777 -ne 'my @m = /```mermaid\s*\r?\n(.*?)\r?\n```/gs; print scalar(@m)' "$RESOLVED_MARKDOWN_PATH")"

if [[ "$BLOCK_COUNT" -eq 0 ]]; then
    if [[ -n "$SOURCE_PATH" ]]; then
        RESOLVED_SOURCE_PATH="$(resolve_abs "$SOURCE_PATH")"
    else
        CANDIDATE="$MARKDOWN_DIRECTORY/$MARKDOWN_BASE_NAME.mmd"
        RESOLVED_SOURCE_PATH=""
        [[ -f "$CANDIDATE" ]] && RESOLVED_SOURCE_PATH="$CANDIDATE"
    fi

    if [[ -z "$RESOLVED_SOURCE_PATH" ]]; then
        echo "Error: no Mermaid blocks found in markdown and no Mermaid source file available. Expected: $MARKDOWN_BASE_NAME.mmd" >&2
        exit 1
    fi

    # Name the output after the .mmd source, not the markdown file -- one markdown doc can
    # embed several diagrams (each with its own --source-path), and they must not collide on
    # the same output filename.
    SOURCE_BASE_NAME="$(basename "$RESOLVED_SOURCE_PATH")"
    SOURCE_BASE_NAME="${SOURCE_BASE_NAME%.*}"
    SVG_OUT_PATH="$RESOLVED_OUTPUT_DIRECTORY/$SOURCE_BASE_NAME.svg"

    render_svg "$RESOLVED_SOURCE_PATH" "$SVG_OUT_PATH"

    echo ""
    echo "Mermaid export completed."
    echo "  Markdown file : $(relpath "$REPO_ROOT" "$RESOLVED_MARKDOWN_PATH")"
    echo "  Blocks found  : 0 (using separate Mermaid source file)"
    echo "  Source file   : $(relpath "$REPO_ROOT" "$RESOLVED_SOURCE_PATH")"
    echo "  SVG output    : $(relpath "$REPO_ROOT" "$SVG_OUT_PATH")"
    echo "  Rewritten MD  : $([[ $REWRITE_MARKDOWN -eq 1 ]] && echo true || echo false)"
    exit 0
fi

# N mermaid blocks found: extract each to its own .mmd, render to .svg, and optionally
# rewrite the markdown in place to reference the rendered images. The heavy lifting (regex
# extraction + in-place substitution) is done in Perl for the same reason the .ps1 twin uses
# .NET regex: reliable multiline, non-greedy matching that POSIX sed/awk don't offer.
export MD_BASE_NAME="$MARKDOWN_BASE_NAME"
export OUT_DIR="$RESOLVED_OUTPUT_DIRECTORY"
export MD_DIR="$MARKDOWN_DIRECTORY"
export MD_PATH="$RESOLVED_MARKDOWN_PATH"
export IMAGE_ALT_PREFIX
export REWRITE_MARKDOWN
export PUPPETEER_CONFIG_PATH
export REPO_ROOT

ARTIFACTS="$(perl -0777 -e '
    use File::Spec;

    local $/;
    open(my $fh, "<:utf8", $ENV{MD_PATH}) or die "Cannot read $ENV{MD_PATH}: $!";
    my $content = <$fh>;
    close $fh;

    my $out_dir   = $ENV{OUT_DIR};
    my $md_base   = $ENV{MD_BASE_NAME};
    my $md_dir    = $ENV{MD_DIR};
    my $alt_prefix = $ENV{IMAGE_ALT_PREFIX};
    my $rewrite   = $ENV{REWRITE_MARKDOWN};
    my $puppeteer = $ENV{PUPPETEER_CONFIG_PATH};
    my $repo_root = $ENV{REPO_ROOT};

    my $total = () = $content =~ /```mermaid\s*\r?\n(.*?)\r?\n```/gs;
    my $ordinal = 0;
    my @artifacts;

    # Use # as the s/// delimiter (not /): the replacement code below shells out to
    # "@mermaid-js/mermaid-cli", and a literal / there would terminate a /-delimited s/// early.
    # (For the same reason, the replacement code itself must not contain a literal # either --
    # no Perl comments inside it -- since # is now the delimiter.)
    $content =~ s#```mermaid\s*\r?\n(.*?)\r?\n```#
        do {
            $ordinal++;
            my $body = $1;
            my $base = $total == 1 ? $md_base : sprintf("%s.diagram-%02d", $md_base, $ordinal);
            my $mmd_path = File::Spec->catfile($out_dir, "$base.mmd");
            my $svg_path = File::Spec->catfile($out_dir, "$base.svg");

            open(my $ofh, ">:utf8", $mmd_path) or die "Cannot write $mmd_path: $!";
            print $ofh $body;
            close $ofh;

            open(my $saved_stdout, ">&", \*STDOUT) or die "Cannot save STDOUT: $!";
            open(STDOUT, ">", File::Spec->devnull) or die "Cannot redirect STDOUT: $!";
            my $renderResult = system("npx", "-y", "\@mermaid-js/mermaid-cli", "-i", $mmd_path, "-o", $svg_path,
                    "--puppeteerConfigFile", $puppeteer);
            open(STDOUT, ">&", $saved_stdout) or die "Cannot restore STDOUT: $!";

            ($renderResult == 0) or die "Mermaid render failed for: $mmd_path";

            # Pin the rendered SVG intrinsic width/height to its viewBox (see
            # set_svg_intrinsic_size in the 0-blocks branch above for why).
            open(my $svg_in, "<:utf8", $svg_path) or die "Cannot read $svg_path: $!";
            my $svg_content = do { local $/; <$svg_in> };
            close $svg_in;
            if ($svg_content =~ /viewBox="[\d.]+\s+[\d.]+\s+([\d.]+)\s+([\d.]+)"/) {
                my ($svg_w, $svg_h) = ($1, $2);
                $svg_content =~ s/width="100%"/width="$svg_w" height="$svg_h"/;
            }
            open(my $svg_out, ">:utf8", $svg_path) or die "Cannot write $svg_path: $!";
            print $svg_out $svg_content;
            close $svg_out;

            push @artifacts, File::Spec->abs2rel($mmd_path, $repo_root);
            push @artifacts, File::Spec->abs2rel($svg_path, $repo_root);

            if ($rewrite) {
                my $rel_mmd = File::Spec->abs2rel($mmd_path, $md_dir);
                my $rel_svg = File::Spec->abs2rel($svg_path, $md_dir);
                my $alt = $total == 1 ? $alt_prefix : "$alt_prefix $ordinal";
                "Mermaid source: [$base.mmd]($rel_mmd)\n\n![$alt]($rel_svg)";
            } else {
                $&;
            }
        }
    #gse;

    if ($rewrite) {
        open(my $out, ">:utf8", $ENV{MD_PATH}) or die "Cannot write $ENV{MD_PATH}: $!";
        print $out $content;
        close $out;
    }

    print join("\n", @artifacts);
')"

echo ""
echo "Mermaid export completed."
echo "  Markdown file : $(relpath "$REPO_ROOT" "$RESOLVED_MARKDOWN_PATH")"
echo "  Blocks found  : $BLOCK_COUNT"
echo "  Rewritten MD  : $([[ $REWRITE_MARKDOWN -eq 1 ]] && echo true || echo false)"
echo "  Artifacts:"
while IFS= read -r artifact; do
    [[ -n "$artifact" ]] && echo "    - $artifact"
done <<< "$ARTIFACTS"

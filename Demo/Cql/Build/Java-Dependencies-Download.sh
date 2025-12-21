#!/bin/bash

# Parse command line arguments
FORCE=false
while [[ $# -gt 0 ]]; do
    case $1 in
        -Force|--force)
            FORCE=true
            shift
            ;;
        *)
            echo "Unknown option: $1" >&2
            exit 1
            ;;
    esac
done

# Source required variables
source "$(dirname "${BASH_SOURCE[0]}")/Java-Dependencies-Vars.sh"

# Helper function to count JAR files in target directory
get_jar_file_count() {
    if [ -d "$TargetDependencies" ]; then
        find "$TargetDependencies" -maxdepth 1 -name "*.jar" -type f 2>/dev/null | wc -l
    else
        echo 0
    fi
}

# Use a lock directory to prevent parallel execution across multiple MSBuild processes
# Using directory-based locking for cross-platform compatibility (works on Linux, macOS, etc.)
# Place lock in the build directory to avoid /tmp issues
SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
LOCK_DIR="$SCRIPT_DIR/.java-dependencies-download.lock.d"

# Function to acquire lock with timeout (2 minutes = 120 seconds)
acquire_lock() {
    local timeout=120
    local elapsed=0
    
    while ! mkdir "$LOCK_DIR" 2>/dev/null; do
        if [ $elapsed -ge $timeout ]; then
            echo "Error: Timeout waiting for Java dependencies download lock" >&2
            return 1
        fi
        sleep 1
        elapsed=$((elapsed + 1))
    done
    return 0
}

# Function to release lock and clean up
cleanup() {
    rmdir "$LOCK_DIR" 2>/dev/null || true
}

# Set trap to cleanup on exit
trap cleanup EXIT

# Acquire the lock
if ! acquire_lock; then
    exit 1
fi

# Check if target/dependency folder exists and contains JARs, or if -Force is specified
NEED_DOWNLOAD=false
if [ ! -d "$TargetDependencies" ]; then
    NEED_DOWNLOAD=true
elif [ "$(get_jar_file_count)" -eq 0 ]; then
    NEED_DOWNLOAD=true
fi

if [ "$FORCE" = true ]; then
    NEED_DOWNLOAD=true
fi

if [ "$NEED_DOWNLOAD" = true ]; then
    if [ ! -d "$TargetDependencies" ]; then
        mkdir -p "$TargetDependencies"
    fi
    # Download CQL to ELM CLI via Maven
    echo "Downloading CQL to ELM CLI via Maven..."
    
    # Run Maven and capture output and exit code
    # Explicitly specify output directory to ensure correct location
    MVN_OUTPUT=$(mvn -f "$PomXmlPath" dependency:copy-dependencies -DoutputDirectory="$TargetDependencies" 2>&1)
    MVN_EXIT_CODE=$?
    
    # Check if dependencies were actually downloaded successfully by verifying JARs exist
    JAR_COUNT=$(get_jar_file_count)
    if [ "$JAR_COUNT" -eq 0 ]; then
        echo "Error: Maven dependency download failed - no JAR files found in $TargetDependencies" >&2
        echo "Maven exit code: $MVN_EXIT_CODE" >&2
        # Still write log on failure for debugging
        echo "$MVN_OUTPUT" > "$MvnBuildLog"
        exit 1
    fi
    # Write log only after successful validation
    echo "$MVN_OUTPUT" > "$MvnBuildLog"
    echo "Successfully downloaded $JAR_COUNT dependency JAR file(s)"
else
    echo "Dependencies already present in $TargetDependencies. Use -Force to re-download."
fi

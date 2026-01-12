#!/bin/bash

# Source required variables
source "$(dirname "${BASH_SOURCE[0]}")/Java-Dependencies-Vars.sh"

if [ -z "$TargetDependencies" ]; then
    echo "Error: TargetDependencies not specified" >&2
    exit 1
fi

# Clean JAR dependencies (delete)
if [ -d "$TargetDependencies" ]; then
    echo "Deleting JAR Dependencies..."

    if [ -z "$PomXmlPath" ]; then
        echo "Error: PomXmlPath not specified. Should refer to a pom.xml file." >&2
        exit 1
    fi

    if [ ! -f "$PomXmlPath" ]; then
        echo "Error: PomXmlPath does not exist. Value='$PomXmlPath'" >&2
        exit 1
    fi

    mvn clean -f "$PomXmlPath"
    if [ $? -ne 0 ]; then
        echo "Error: Maven clean failed" >&2
        exit 1
    fi
fi

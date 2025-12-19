#!/bin/bash

# REQUIRED VARIABLES
# ------------------
# $CqlToElmCliVersion  : Version of the CQL-to-ELM CLI tool (for reference)
# $TargetDependencies  : Path to the directory where JAR dependencies are stored
# $PomXmlPath          : Path to the pom.xml file for Maven
# $MvnBuildLog         : Path to the log file for Maven output

# Get the directory of this script
SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"

# The latest version number can be found under the releases tab of the CQL to ELM CLI repository
# see: https://github.com/cqframework/clinical_quality_language/releases
#
# If you change the version here, you also need to update it in these places too:
# * pom.xml
# * Java-Dependencies-Vars.ps1 / Java-Dependencies-Vars.sh
# * The Hl7.Cql.Packager.Program.JavaToolVersion for the Packager CLI
: "${CqlToElmCliVersion:=3.28.0}"

: "${TargetDependencies:=$SCRIPT_DIR/target/dependency}"

: "${PomXmlPath:=$SCRIPT_DIR/pom.xml}"

: "${MvnBuildLog:=$SCRIPT_DIR/mvn-build.log}"

echo "CqlToElmCliVersion: $CqlToElmCliVersion"
echo "TargetDependencies: $TargetDependencies"
echo "PomXmlPath: $PomXmlPath"
echo "MvnBuildLog: $MvnBuildLog"

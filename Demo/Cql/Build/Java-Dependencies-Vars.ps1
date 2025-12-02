# REQUIRED VARIABLES
# ------------------
# $CqlToElmCliVersion  : Version of the CQL-to-ELM CLI tool (for reference)
# $TargetDependencies  : Path to the directory where JAR dependencies are stored
# $PomXmlPath          : Path to the pom.xml file for Maven
# $MvnBuildLog         : Path to the log file for Maven output

if (-not (Test-Path variable:CqlToElmCliVersion)) {
    # The latest version number can be found under the releases tab of the CQL to ELM CLI repository
	# see: https://github.com/cqframework/clinical_quality_language/releases
	#
	# If you change the version here, you also need to update it in these places too:
	# * pom.xml
	# * Java-Dependencies-Vars.ps1
	# * The Hl7.Cql.Packager.Program.JavaToolVersion for the Packager CLI
    $script:CqlToElmCliVersion = "3.28.0"
}

if (-not (Test-Path variable:TargetDependencies)) {
    $script:TargetDependencies = Join-Path $PSScriptRoot "target/dependency"
}

if (-not (Test-Path variable:PomXmlPath)) {
    $script:PomXmlPath = Join-Path $PSScriptRoot "pom.xml"
}

if (-not (Test-Path variable:MvnBuildLog)) {
    $script:MvnBuildLog = Join-Path $PSScriptRoot "mvn-build.log"
}

Write-Host "CqlToElmCliVersion: $CqlToElmCliVersion"
Write-Host "TargetDependencies: $TargetDependencies"
Write-Host "PomXmlPath: $PomXmlPath"
Write-Host "MvnBuildLog: $MvnBuildLog"
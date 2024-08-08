# Getting started with the Firely SDK CQL repository

The repository consists of two parts:
* `Cql/` - the main body of code that produces the CQL engine itself, plus the PackagerCLI
* `docs/` - documentation and other files that are useful to understand the codebase
  * A [diagram](docs/packager-cli-dependency-graph.md) showing how all the classes and their dependencies involved.
  * A [graphic](docs/CQL%20Engine%20v2.png) showing the main (internal) parts of the engine. May be somewhat outdated.
  * The folder also contains a `CQL Engine v2.png` and `CQL Engine Architecture.docx` file that sketch the internal structure of the CQL engine. As should
be expected, those files will always be somewhat outdated, but still serve as good overview of the codebase.
* `Demo/` - a solution that demoes how to get from a CQL measure to an executable rule.

It also links to submodule repositories that may be of interest to you:
* `submodules/Firely.Cql.Sdk.Integration.Runner/` - an integration test runner used to run CMS measures.

## The Cql-Sdl-All solution
The `Cql-Sdk-All.sln` solution includes all the projects in the repository, _and_ the submodules.
In most cases you will not need to build the submodules, 
since the purpose of it is to run the integration tests in the build pipeline (still to be done).

If you do you want to open this solution in Visual Studio, 
you can do so by following the following steps:
* Clone the repository
* Clone the submodules by running `git submodule update`
* Then open the `Cql-Sdk-All.sln` solution in Visual Studio and build it.

Note that you will see multiple repositories in the `Git Changes` tool window in Visual Studio.
Each repository must be branched and committed separately.


## The Cql-Sdk solution
Building the Cql solution should be as simple as doing a build in Visual Studio or running a `dotnet build 'Cql-Sdk.slnf'`.
It builds the CQL engine into a whole bunch of assemblies, 
plus builds the only executable in the solution, the PackagerCLI. 
The PackagerCLI takes CQL measures (in the form of ELM), 
turns them into equivalent C#, 
compiles the C# and then packages the original ELM, 
the C# code and the binary assembly data into a FHIR Library resources.
It is used in the Demo project, 
so if you'd like to see example use for it (until we write the documentation),
take a look at the provided `"ELM to C#"` build target in the Elm project within the Demo solution.

## The Demo folder

* Read how to [get started with the Demo solution](docs/getting-started.md) included in the repository.
* There is a great presentation on the engine from [DevDays 2023](https://youtu.be/CkTbgfbttJc).
* [The CQL section](https://docs.fire.ly/projects/Firely-NET-SDK/en/latest/cql.html) in the .NET SDK documentation
* A [word document](cql/CQL%20Engine%20Architecture.docx) with background documentation on the design. May be somewhat outdated.

The presentation is a good place to start, but note that we have made some minor changes to the public surface, 
so the names of the classes in the presentation will differ from the examples in the Demo project itself.

It is important that you either build the Cql engine yourself before you try to build the Demo solution, 
since that uses parts of the Cql solution. 
Alternatively, you can tweak the Demo project to use the shipped NuGet packages for the Cql engine, 
instead of referring to the projects directly.

### (2.x update) Thanks to feedback, the Demo projects have been updated!
After reviewing the following high level understanding of the Demo projects, be sure to see the detailed breakdown of the Demo projects below.

### Demo Introduction
The demo project showcases the process of turning a measure written in CQL into an executable function that can be called from your code. It also contains a few tests that demo the main ways to run a measure.

Just like with the CQL, building the solution should be a simple matter of hitting build, or `dotnet build`, but in this case, it is more instructive to break the build process into pieces to get a sense of what is going on. Basically, there are three steps:

### 1. Turning CQL into ELM

Surprisingly, this is the hardest step. It takes the human-readable CQL source code and turns it into ELM, basically a serialized abstract syntax tree (just like CQL defined by HL7) that represents the source code in a more processable way. Unfortunately, there is no .NET tool for doing this yet, so this step involves running the existing CQL-to-ELM [command line tool](https://github.com/cqframework/clinical_quality_language/tree/master/Src/java).  The first time you run the build, it will also download all the necessary Java CQL/ELM tools.

Prerequisites:
1. Install JDK
2. Install [Maven](https://maven.apache.org/install.html). Be sure to set the PATH variable mentioned in the link.
3. As of this documentation JDK 21 and Maven 3.9.5 are working - Oct 13 2023.

Take a look at the `Cql` project in the Demo solution folder. Its `Build` directory contains the build target (including the Maven configuration files). This project is used for common build targets.

 There are multiple `Measures.*` projects where the and the `input` folder contains a set of demo CQL files. Running the build (manually) for these project turns these CQL files into ELM, and puts the files into the source directory of the next step (which is the `Elm` folder each respective project).

### 2. Turning ELM into C# and DLLs
The next step does quite a bit at one:
* Take the ELM we just produced and generate [Linq.Expressions](https://learn.microsoft.com/en-us/dotnet/api/system.linq.expressions.expression?view=net-7.0) for it.
* Take the `Expressions` and turn them into C# code. Each ELM file is converted into one class and each function within that file into a public function in that class.
* Compile all the C# into a single assembly, and into single assemblies per CQL file.
* For each CQL file: package the CQL, the ELM, the assembly and the C# source code into a FHIR `Library` resource.

All these steps are done by the `PackagerCLI` that is included in the target files of the `Cql` solution, which is invoked by the build steps for the `Cql` project, taking both the original CQL (from the `input` folder in step 1) and the ELM (from `Elm` folder from this project) as input. The generated C# is exported to the `CSharp` directory of the `Measures.*` projects, and built into a `Measures.[name].dll`. The generated `Library` resources are stored in the `Resources` folder in each respective project. The `Measures.Authoring` project has some minimal examples and can be used for your own CQL development initiatives.

Note that although it is possible to directly execute the `Linq.Expressions` generated during the intermediate steps, this is not recommended, since they are very hard to debug and cannot be shipped efficiently as reuseable assemblies.

### 3. Build the other projects
With the measures generated, we can now build the other projects. There is one sample project `CLI` and a Test project with four unit tests.

## Evaluating measures
The `Test.Measures.Demo` project showcases multiple ways to use the CQL SDK to execute measures in `MeasuresTest.cs`. No matter how the CQL expressions in each CQL file are invoked, you need to create an instance of a `CqlContext` first,
which holds the basic external inputs to the function call: 
* The data to run the function on, either as a `Bundle` FHIR resource, or an implementation of `IDataSource`. (default: empty data)
* The parameters passed to the measure (default: none).
* A set of external valuesets (default: no valuesets).
* The date to server as "today" (default: today)

This is most easily done by calling one of the overloads of the factory method `FhirCqlContext.Create()`. When the `CqlContext` is created,
we can now invoke the defined functions in the measure:

1. Directly call the generated measure. This is shown in `BCSEHEDIS2022_Numerator`. Calling a CQL expression directly requires the measures to be known in advance as a pre-compiled assembly.

1. Dynamically load the packaged `Library` resources and invoke the CQL expressions dynamically. This is shown in `BCSEHEDIS2022_Numerator_FromResource`.
2. Dynamically load ELM files, compile them and then run the expressions within the measure. This is shown in `BCSEHEDIS2022_Numerator_FromElm`.

> When using the "direct" approach, we are constructing an instance of the whole measure, and then invoking the individual expressions. The results of these expressions are cached, to speed up processing when they are called repeatedly. This means that manipulating the parameters or the Bundle contents will not change the outcome of the expressions anymore, and you will have to create a new instance of the generated measure to force re-calculation. 

## Demo Projects Detailed
With the 2.x SDK update, the Demo projects have been refactored and improved thanks to feedback from the community. Through the improvements, more examples were added, common questions answered,

### Cql Project
The functionality in the 1.x `ELM` project has been merged to the `CQL` project. The goal of the `CQL` project is to:

1. Pull down the JAVA cql-to-elm tooling using Maven
2. Invoke the cql-to-elm tooling to convert `CQL` to `ELM` (this will be retired soon when the CQL SDK cql-to-elm C# implementation is complete.)

Because there are now multiple `Measures.[name]` projects the build targets are located in this project to be shared amongst the others.

### CLI Project
The `CLI` project is now standalone and is referenced by all of the `Measures.[name]` projects to reuse the functionality within. Some highlights of functionality:

1. Examples for running measures both using the compiled CSharp and using Library Resource files.
2. Multiple examples of loading dependencies: resources, value sets, etc.
3. Example for finding missing value sets when developing CQL files.
4. Improved file structure to allow for the use of https://github.com/cqframework/vscode-cql tooling, along with multiple patient tests, loading of input parameters, and saving output to file locations in multiple formats.
5. Removed dependency on a single Measures project so it can be edited and use in a standalone fashion. See the launchsettings.json file for samples.
6. Improved command line parameter examples.
7. Comments added in various areas to help with understanding.


### Measures.[name] Projects

All the `Measures.[name]` projects are now both a library with an executable. This facilitates calling the `CLI` project tool with little effort and configuration and pre-packages and runs the `CLI` executable within the Measures project for testing.

The projects have been refactored to support using vscode-cql tooling for authoring measures.

### Measures.Authoring Project

This project is now the defacto `demonstration` and authoring project. The idea is that you can author your own measures in this project for testing. It includes just a few samples that can easily be removed or ignored.

This project can also be copied to a new project for your development. For example, you would copy the `Measures.Authoring` project to `Measures.MyMeasureProject` and then remove the examples and test data. Because of the sharing of code and build targets with the `Cql` project, a few properties edits will need to be made to the new project's `csproj` file:

	<PropertyGroup>
		<LibrarySet>Measures.Authoring</LibrarySet>
		<CqlDirectory>$(MSBuildProjectDirectory)/input/cql</CqlDirectory>
		<ElmDirectory>$(MSBuildProjectDirectory)/Elm</ElmDirectory>
		<ResourcesDirectory>$(MSBuildProjectDirectory)/Resources</ResourcesDirectory>
		<CSharpDirectory>$(MSBuildProjectDirectory)/CSharp</CSharpDirectory>
	</PropertyGroup>

In most scenarios, simply changing the LibrarySet is all that is needed. See the `Measures.Demo` project for a sample on loading data from directories that are not local to your authoring project.

### Measures.Demo (formerly Measures)

This project contains a set of sample measures akin to older CMS and HEDIS measures. It is largely unchanged from its former version with the exception of build target configuration to load files from other directories.


### Measures.CMS 

This project contains a set of sample measures from the ongoing CMS CQL to FHIR initiatives. To maintain the size of the CQL SDK, there are no samples or tests. It is more of a testing tool for the SDK team, to see and test how other advanced measures look when compiled to CSharp. 
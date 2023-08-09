# Getting started with the Firely SDK CQL repository

The repository consists of two parts:
* `Cql/` - the main body of code that produces the CQL engine itself, plus the PackagerCLI
* `Demo/` - a solution that demoes how to get from a CQL measure to an executable rule.

It is important that you either build the Cql engine yourself before you try to build the Demo solution, since that uses parts of the Cql solution. Alternatively, you can tweak the Demo project to use the shipped NuGet packages for the Cql engine, instead of referring to the projects directly.

## The Cql solution
Building the Cql solution should be as simple as doing a build in Visual Studio or running a `dotnet build`. It builds the CQL engine into a
whole bunch of assemblies, plus builds the only executable in the solution, the PackagerCLI. The PackagerCLI takes CQL measures (in the form
of ELM), turns them into equivalent C#, compiles the C# and then packages the original ELM, the C# code and the binary assembly data into a FHIR Library resources. It is used in the Demo project, so if you'd like to see example use for it (until we write the documentation), take a look at the provided
`"ELM to C#"` build target in the Elm project within the Demo solution.

The folder also contains a `CQL Engine v2.png` and `CQL Engine Architecture.docx` file that sketch the internal structure of the CQL engine. As should
be expected, those files will always be somewhat outdated, but still serve as good overview of the codebase.


## The Demo solution

The demo project showcases the process of turning a measure written in CQL into an executable function that can be called from your code. It also contains a few tests that demo the main ways to run a measure.

Just like with the CQL, building the solution should be a simple matter of hitting build, or `dotnet build`, but in this case, it is more instructive to break the build process into pieces to get a sense of what is going on. Basically, there are three steps:

### 1. Turning CQL into ELM
Surprisingly, this is the hardest step. It takes the human-readable CQL source code and turns it into ELM, basically a serialized abstract syntax tree (just like CQL defined by HL7) that represents the source code in a more processable way. Unfortunately, there is no .NET tool for doing this yet, so this step involves running the existing CQL-to-ELM [command line tool](https://github.com/cqframework/clinical_quality_language/tree/master/Src/java). To make this easier, the solution contains a full install of Maven, plus the necessary build targets to run them. The first time you run the build, it will also download all the necessary Java CQL/ELM tools.

Take a look at the `Cql` project in the Demo solution folder. Its `Build` directory contains the build target (including the Maven configuration files) and the `input` folder contains a set of demo CQL files. Running the build (manually) for this project turns these CQL files into ELM, and puts the files into the source directory of the next step (which is the `Json` folder under the `Elm` project).

### 2. Turning ELM into C# and DLLs
The next step does quite a bit at one:
* Take the ELM we just produced and generate [Linq.Expressions](https://learn.microsoft.com/en-us/dotnet/api/system.linq.expressions.expression?view=net-7.0) for it.
* Take the `Expressions` and turn them into C# code. Each ELM file is converted into one class and each function within that file into a public function in that class.
* Compile all the C# into a single assembly, and into single assemblies per CQL file.
* For each CQL file: package the CQL, the ELM, the assembly and the C# source code into a FHIR `Library` resource.

All these steps are done by the `PackagerCLI` that is included in the `Cql` solution, which is invoked by the build steps for the `Elm` project, taking both the original CQL (from the `input` folder in step 1) and the ELM (from `Json` folder from this project) as input. The generated C# is exported to the root directory of the `Measures` project, and built into a `Measures.dll`. The generated `Library` resources are stored in the `Resources` folder in the `Test` project.

Note that although it is possible to directly execute the `Linq.Expressions` generated during the intermediate steps, this is not recommended, since they are very hard to debug and cannot be shipped efficiently as reuseable assemblies.

### 3. Build the other projects
With the measures generated, we can now build the other projects: two sample projects (one CLI and one Web application to evaluate the measures) and a Test project with four unit tests.

## Evaluating measures
The demo project showcases four ways to use the CQL SDK to execute measures in `MeasuresTest.cs`. No matter how the CQL expressions in each CQL file are invoked, you need to create an instance of a `CqlContext` first,
which holds the basic external inputs to the function call: 
* The data to run the function on, either as a `Bundle` FHIR resource, or an implementation of `IDataRetriever`. (default: empty data)
* The parameters passed to the measure (default: none).
* A set of external valuesets (default: no valuesets).
* The date to server as "today" (default: today)

This is most easily done by calling one of the overloads of the factory method `FirelyCqlContext.Create()`. When the `CqlContext` is created,
we can now invoke the defined functions in the measure:

1. Directly call the generated measure. This is shown in `BCSEHEDIS2022_Numerator`. Calling a CQL expression directly requires the measures to be known in advance as a pre-compiled assembly.

1. Dynamically load the packaged `Library` resources and invoke the CQL expressions dynamically. This is shown in `BCSEHEDIS2022_Numerator_FromResource`.
1. Dynamically load ELM files, compile them and then run the expressions within the measure. This is shown in `BCSEHEDIS2022_Numerator_FromElm`.

> When using the "direct" approach, we are constructing an instance of the whole measure, and then invoking the individual expressions. The results of these expressions are cached, to speed up processing when they are called repeatedly. This means that manipulating the parameters or the Bundle contents will not change the outcome of the expressions anymore, and you will have to create a new instance of the generated measure to force re-calculation. 

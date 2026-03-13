# CQL Engine Architecture

## Overview

This engine operates by consuming ELM representation of a CQL measure and takes the following steps:

1. Transpile CQL (via ELM) to .NET expressions via the `System.Linq.Expressions` namespace
2. Either:
   - Perform runtime compilation into invokable delegates
   - Translate these expressions into C# source code, which can then be compiled at leisure

This approach has a number of key advantages over engines which take the approach of simultaneously interpreting the ELM and producing the results.

### Key Advantages

- **Performance**: Once the transpiled .NET code has been compiled either into delegates or via source code first, the original ELM is no longer necessary, because it has now been transformed into executable code. This eliminates the need to continually examine the ELM for each execution.

- **Optimization**: We are able to take advantage of the enormous body of work that has gone into optimizing .NET applications generally over the last twenty years. Although .NET code is not native and like Java runs on a virtual machine, this virtual machine is highly performant and pays only a very small penalty compared to pure native compilation.

- **Integration**: Once CQL libraries are compiled into measures, they can be referenced by regular .NET projects covering a wide range of use cases, e.g. a web service, console application, Azure Function, etc.

### Use Cases

The two compilation options are ideally suited for corresponding use cases:

- **Runtime compilation**: When rapid iteration of the CQL is required – the authoring use case
- **Source code generation & compilation**: When the CQL is finished – the execution use case. Source code generation is also preferable when debugging of the CQL is required. The resulting source code is transformed into a set of procedural steps with local variables defined, which allows line-by-line step-through.

## Key Projects & Classes

### ELM Project

This project contains the domain objects to represent ELM as deserialized from JSON, and companion serialization helpers.

> **Important**: Do not try to deserialize using default mechanisms, e.g. `JsonConvert.Deserialize`. Use the helper methods provided in the `ElmPackage` class.

#### ElmPackage Class
- Root class for an ELM JSON document
- Has static methods used to deserialize ELM from a variety of sources (disk, JSON string, Stream)
- Use the appropriate overload to acquire the correct object model

#### Expression Class
- Root expression class in ELM that contains common properties (`localId`, `locator`, etc.)
- During deserialization, the proper derivation will be picked based on the `type` property of the Expression

### MeasureCompiler Project

#### ExpressionBuilder Class
- Responsible for interpreting the ELM expression tree creating `LambdaExpression` instances for all definitions and functions in the provided ELM package
- Relies on the `OperatorBinding` class defined in the CqlRuntime project to determine methods to call to handle CQL's operators
- These operators are defined in an enumeration called `CqlOperators`

#### TypeManager Class
- Assists in determining which C# types to use for the CQL types named in the ELM
- For standard well-known system types, it does this through the `TypeResolver` class in the CqlRuntime project
- For CQL tuples, the TypeManager is required to dynamically define new types with the members stipulated in the ELM

#### SourceCodeWriter Class
- Takes the output from the ExpressionBuilder's Build method and translates them into C# source code
- The writer relies on a number of `ExpressionVisitor` implementations to create source code that is both readable and high performing
- Has room for improvement - several optimizations remain unimplemented (e.g., short-circuiting is only experimental; both sides of conditionals are usually computed)

### CqlRuntime Project

#### RuntimeContext Class
- An instance of this class is the only parameter to the `LambdaExpressions` built for CQL definitions
- It is the first parameter for the `LambdaExpressions` built for CQL functions, preceding all other function parameters
- Through this class, the `LambdaExpressions` can access the `ICqlOperators` instance that contains all the CQL operators

**Important Notes:**
- When operating without source code, the `Definitions` property must be populated
- The `LambdaExpressions` that are built by the `ExpressionBuilder` call each other through the `Definitions` property
- You can translate a `DefinitionDictionary` of `LambdaExpression` to the required `DefinitionDictionary` of `Delegate` using the `CompileAll()` extension method
- When operating with source code generated, this dictionary can be left empty as long as you are using the default `ExpressionVisitors`

**Other Key Properties:**
- Contains an implementation of `CqlComparers`, which implements the `ICqlComparer` interface
- Contains the patient bundle, typed as `object`
- Contains all other input required to execute a measure: value sets, parameters dictionary, and the date specified to be "Now"
- Expected that one `RuntimeContext` be created per bundle

> **Warning**: You should re-use the implementations mentioned above. Do not attempt to alter the Bundle property, even after all work is done. This may have unintended consequences and produce incorrect results.

#### CqlOperatorsBase Class
- Abstract class that is the main functionality of the CQL engine
- Implements `ICqlOperators`, which contains all of the methods that implement all of the CQL operators
- Operator methods are not virtual by design (virtual methods are slower to execute than non-virtual methods)
- If you need to modify the behavior of these operators, create a new implementation of `ICqlOperators` which composes an instance of `CqlOperatorsBase`

#### ICqlOperatorsBinding Class
- Abstract class that acts as the bridge between the `ExpressionBuilder` and the `ICqlOperators` interface
- When the `ExpressionBuilder` interprets an ELM node that represents a system function, it delegates the generation of the LINQ expression to a derivation of the `OperatorBinding` class
- The `OperatorBinding`'s job is to return an `Expression` instance that performs the operation requested by ELM
- This class is abstract because it does not implement `Retrieve`, the operator which is responsible for providing FHIR resources

**Implementing Retrieve Methods:**
- This is how an implementation of the execution engine interfaces with FHIR data
- Most extant CQL, including CMS eCQMs and NCQA's measures, are "context Patient" libraries
- From a performance perspective, it is best to pre-fetch as much as possible all data and stage it as patient-everything bundles
- Retrieve methods are currently synchronous

#### CqlComparers Class
- Acts as a dispatcher for other implementers of the `ICqlComparer` and `IEquivalenceComparer` interface
- Maintains a dictionary keyed by the type of the left hand of the CQL operation
- Generally, it is expected that attempting to compare unlike types is considered an error
- The default comparers implemented in this project should suffice to cover CQL

#### IUnitConverter Interface & UnitConverter Class
- Unit conversion is a complex feature set that is easily an entire product on its own
- The implementation provided here only handles the most common CQL unit use cases, specifically converting time quantities (month to days, days to weeks, etc.)
- If your measure domain will require unit conversion, it is recommended to provide your own implementation of this interface
- All units should be expressed as UCUM units; other unit code systems are not supported

#### IValueSetDictionary Interface & CqlValueSetDictionary Class
- Exposes two methods used by CQL to handle value set filtering in Retrieve statements
- The provided implementation uses a hashing mechanism
- Value set URIs, code system URIs, and codes themselves are case-insensitive
- The hashing mechanism ensures that determining whether a key is contained in a value set is an O(1) operation and is very fast

#### TypeConverter Class
- Translates domain objects to and from CQL primitives used in the methods defined by `ICqlOperators`
- By default, `TypeConverter` provides very few conversions
- We implemented versions of Date, Time, and DateTime per the ISO8601 standard in the Iso8601 project (`DateIso8601`, `TimeIso8601`, and `DateTimeIso8601`, respectively)

#### TypeResolver Class
- Helps the `ExpressionBuilder`, `TypeManager`, and `OperatorBinding` classes resolve types when crafting `System.Linq.Expression` instances
- This class is abstract, and must be implemented when adopting a model to use with the engine
- We provide a `BaseTypeResolver` class which provides mapping of the CQL system types to either C# primitives
- Remember that everything in CQL is nullable, so do not use non-nullable value types anywhere in this mapping

### CQL Primitives

The `Ncqa.Cql.Runtime.Primitives` namespace implements the CQL system types where default C# types cannot be used, e.g. intervals, quantities, etc.

> **Note**: `DateTimeOffset` and `TimeSpan` cannot be used to capture dates and times in CQL because a great deal of focus in CQL is dealing with uncertainty related to precision. We use custom ISO 8601 implementations for this located in the Iso8601 project.

### DefinitionDictionary&lt;T&gt; Class
- Utility class that helps resolve function overloads (name + types of parameters) within libraries
- The `LambdaExpression` instances created by `ExpressionBuilder` are stored in this structure, and when converted to `Delegate` instances for use by the `RuntimeContext`

## FHIR Integration

### Fhir Project

#### Generator Class
- Located in the `Ncqa.Fhir.Schemas` namespace
- Loads structure definitions and interprets them to create C# source code which can then be compiled into a model
- This is generally done only once, when a new set of structure definitions has been released by HL7, or to create a model for a specific IG
- Produces absolutely minimal DTOs by design
- Uses literal property names following the HL7 names (e.g., "item" instead of the .NET standard Pascal-cased "Item")

#### Serialization Namespace
- Contains several utility classes that are required when serializing/deserializing these models
- FHIR JSON has the peculiar quirk of suffixing the element type to the property name (e.g., `effectivePeriod` vs. `effectiveDateTime`)
- These classes are built on Microsoft's `System.Text.Json` package

### Fhir.R4 Project

#### FhirJson Class
- Static class that provides `Deserialize` methods that use `System.Text.Json`'s `JsonSerializer` class primed with the required converters to handle FHIR's JSON rules
- `FhirJson.Deserialize` must always be used to deserialize these classes unless you want to provide your own custom converters

### CqlRuntime.FhirR4 Project

Contains several classes that derive from the abstract types defined in the CqlRuntime project:

#### FhirCqlOperators
- Derivation of `CqlOperatorsBase` that implements `Retrieve` for known FHIR types
- The default property paths were taken from the model info used in MITRE's reference engine
- Not all FHIR resources have default code paths, so not all can be used in Retrieve statements qualified with value set filters
- Retrieves are implemented by accessing the `FhirRuntimeContext.Bundle` property

#### FhirOperatorsBinding
- Derivation of `ICqlOperatorsBinding` that implements `Retrieve` and binds method calls to `FhirCqlOperators`

#### FhirTypeConverter
- Derivation of `TypeConverter` that adds type conversion for the Fhir.R4 model to the CQL primitive types and vice versa
- This class is not fully implemented, so it is possible that some FHIR types are not mapped correctly

#### FhirTypeResolver
- Derivation of `BaseTypeResolver` that probes attributes added to the generated types
- Maps the FHIR prefix used in CQL to the types in that namespace

#### FhirCqlComparers
- Derivation of `CqlComparers` that adds comparers for model types from the `Ncqa.Fhir.R4.Model` namespace
- Resources are compared only by the value of its `Id` property, contrary to the letter of the specification
- This is an optimization strategy that assumes all resources in a valid FHIR bundle have populated and distinct Ids

#### FhirRuntimeContext
- Derivation of `RuntimeContext` that implements the abstract properties through strongly typed members
- This class must be used when providing a bundle modeled by the `Ncqa.Fhir.R4` namespace

## Extension Scenarios

### How do I change the way two things are compared?

1. Implement the `ICqlComparer` interface for the type with the desired behavior
2. After creating a `RuntimeContext`, access the context's `Comparers` property to get a `CqlComparers` instance
3. Access that instance's `Comparers` dictionary and replace the key with an instance of your implementation

> **Remember**: `RuntimeContext` is a per-bundle object. This means you must create a new `RuntimeContext` each time you run a new patient bundle through a measure, and assigning your custom comparer must be done on each new `RuntimeContext` you instantiate.

### How do I change the way a CQL operator behaves?

1. Implement `ICqlOperators` and set the `Operators` property of the `RuntimeContext` you are using with your implementation
2. Since `RuntimeContext` is abstract you will need to subclass `RuntimeContext` and initialize the `Operators` property in the constructor
3. If you want to change only one operator, you can implement `ICqlOperators` through a provided instance of `CqlOperatorsBase`

### How do I call into a terminology service to check value sets?

1. Implement the `IValueSetDictionary` interface to contact your terminology service
2. Pass this instance to the constructor of your `RuntimeContext`

> **Performance Note**: The `IsCodeInValueSet` method is called millions of times in a typical CQL execution cycle, so this method must perform extremely well. The default implementation requires that all codes be provided ahead of execution.

### How do I load FHIR data from a different data source?

1. The `OperatorBinding` class is abstract because it does not implement any `Retrieve` by default
2. Derivations of this class must implement this method by returning a `MethodCallExpression`
3. This controls how Retrieve constructs in the CQL, e.g. `[Condition]`, are handled

### How do I use a different FHIR model implementation with this engine?

You would start by subclassing `RuntimeContext` and providing specific implementations of the following classes:

- `CqlOperatorsBase` (to implement Retrieve and Age calculations)
- `ICqlOperatorsBinding` (to bind the Retrieve operator to the new methods you implement in `CqlOperatorsBase`)
- `TypeConverter` (to translate your types into CQL system types)
- `BaseTypeResolver` (to map FHIR types known to CQL to your corresponding types)
- `CqlComparers` (to register new comparers for your types)
- `RuntimeContext` (to tie all these implementations together)

### How do I use an entirely different model (e.g. OMOP, QDM) with this engine?

It is possible, but it is out of scope for this document; it is a significant amount of work that may require cooperation with the CQL-to-ELM tool.

### How do I call this engine from a different runtime (e.g. Java, NodeJS)?

We solved this problem internally by creating a small .NET daemon service that exposes a set of functions via gRPC that interact with the engine. We then use a gRPC client on the NodeJS side to call methods in the .NET code. There is very little overhead when using gRPC locally, especially using named pipes as a transport layer.

There are other techniques for in-process .NET interop, which will all work here. As long as you can call any .NET code from your process, you can use this engine.
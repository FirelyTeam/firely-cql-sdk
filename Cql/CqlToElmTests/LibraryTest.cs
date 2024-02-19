using FluentAssertions;
using Hl7.Cql.Elm;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Hl7.Cql.CqlToElm.Test
{

    [TestClass]
    public class LibraryTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        [TestMethod]
        public void Empty()
        {
            Assert.ThrowsException<ArgumentException>(() => MakeLibrary(string.Empty));
            using var cql = new FileStream(@"Input\LibraryTest\Empty.cql",
                FileMode.Open, FileAccess.Read, FileShare.Read);

            Assert.ThrowsException<ArgumentException>(() => DefaultConverter.ConvertLibrary(cql));
        }

        #region Identifier

        [TestMethod]
        public void Identifier_AllTerms_String()
        {
            var library = MakeLibrary("library String version '4.0.1'");
            Assert.IsNotNull(library);
            Assert.IsNotNull(library.identifier);
            Assert.AreEqual("String", library.identifier.id);
            Assert.IsTrue(string.IsNullOrWhiteSpace(library.identifier.system));
            Assert.AreEqual("4.0.1", library.identifier.version);
        }


        [TestMethod]
        public void Identifier_AllTerms_Namespace()
        {
            var library = MakeLibrary("library Namespace.Lib version '4.0.1'");
            Assert.IsNotNull(library);
            Assert.IsNotNull(library.identifier);
            Assert.AreEqual("Lib", library.identifier.id);
            Assert.AreEqual("Namespace", library.identifier.system);
            Assert.AreEqual("4.0.1", library.identifier.version);
        }


        [TestMethod]
        public void Identifier_Id_Only()
        {
            var library = MakeLibrary("library Lib");
            Assert.IsNotNull(library);
            Assert.IsNotNull(library.identifier);
            Assert.AreEqual("Lib", library.identifier.id);
            Assert.IsTrue(string.IsNullOrWhiteSpace(library.identifier.system));
            Assert.IsTrue(string.IsNullOrWhiteSpace(library.identifier.version));
        }


        [TestMethod]
        public void Identifier_Id_Namespace()
        {
            var library = MakeLibrary("library Namespace.Lib");
            Assert.IsNotNull(library);
            Assert.IsNotNull(library.identifier);
            Assert.AreEqual("Lib", library.identifier.id);
            Assert.AreEqual("Namespace", library.identifier.system);
            Assert.IsTrue(string.IsNullOrWhiteSpace(library.identifier.version));
        }

        #endregion

        #region Using

        public static IServiceCollection MakeMinimalServiceCollection() =>
             new ServiceCollection()
                .AddLogging(b => b.AddDebug().ThrowOn(LogLevel.Error))
                .AddVisitors()
                .AddContext()
                .AddLocalIdProvider()
                .AddTransient<CqlToElmConverter>()
                .AddTransient<InvocationBuilder>()
                .AddSingleton<TypeConverter>()
                .AddSingleton<ElmFactory>()
                .AddConfiguration(cb => { });

        [TestMethod]
        public void Using_AllTerms()
        {
            var services = MakeMinimalServiceCollection()
                .AddModels(mp =>
                {
                    mp.Add(new Model.ModelInfo
                    {
                        name = "Namespace.Using_AllTerms_WithNamespace",
                        url = "http://test.org",
                        version = "1.0.0"
                    });
                });

            var x = services.BuildServiceProvider();
            var converter = x.GetRequiredService<CqlToElmConverter>();
            var library = converter.ConvertLibrary(@"
                library UsingTest version '1.0.0'

                using Namespace.Using_AllTerms_WithNamespace version '1.0.0' called Derp
            ");
            Assert.IsNotNull(library.usings);
            Assert.AreEqual(1, library.usings.Length);
            Assert.AreEqual("Derp", library.usings[0].localIdentifier);
            Assert.AreEqual("http://test.org", library.usings[0].uri);
            Assert.AreEqual("1.0.0", library.usings[0].version);
            Assert.IsNotNull(library.usings[0].localId);
        }

        [TestMethod]
        public void Using_AllTerms_WithNamespace()
        {
            var services = MakeMinimalServiceCollection()
                .AddModels(mp =>
                {
                    mp.Add(new Model.ModelInfo
                    {
                        name = "Namespace.Using_AllTerms_WithNamespace",
                        url = "http://test.org",
                        version = "1.0.0"
                    });
                });

            var serviceProvider = services.BuildServiceProvider();
            var converter = serviceProvider.GetRequiredService<CqlToElmConverter>();
            var library = converter.ConvertLibrary(@"
                library UsingTest version '1.0.0'

                using Namespace.Using_AllTerms_WithNamespace version '1.0.0' called Derp
            ");
            Assert.IsNotNull(library.usings);
            Assert.AreEqual(1, library.usings.Length);
            Assert.AreEqual("http://test.org", library.usings[0].uri);
            Assert.AreEqual("Derp", library.usings[0].localIdentifier);
            Assert.AreEqual("1.0.0", library.usings[0].version);
            Assert.IsNotNull(library.usings[0].localId);

        }

        [TestMethod]
        public void Using_NoVersion_LocalIdentifier()
        {
            var services = MakeMinimalServiceCollection()
                .AddModels(mp =>
                {
                    mp.Add(new Model.ModelInfo
                    {
                        name = "Namespace.Using_NoVersion_LocalIdentifier",
                        url = "http://test.org",
                        version = "1.0.0"
                    });
                });
            var provider = services.BuildServiceProvider();
            var converter = provider.GetRequiredService<CqlToElmConverter>();
            var library = converter.ConvertLibrary(@"
                library UsingTest version '1.0.0'

                using Namespace.Using_NoVersion_LocalIdentifier called Derp
            ");
            Assert.IsNotNull(library.usings);
            Assert.AreEqual(1, library.usings.Length);
            Assert.AreEqual("Derp", library.usings[0].localIdentifier);
            Assert.AreEqual("http://test.org", library.usings[0].uri);
            Assert.IsTrue(string.IsNullOrWhiteSpace(library.usings[0].version));
            Assert.IsNotNull(library.usings[0].localId);

        }

        [TestMethod]
        public void Using_Version_NoIdentifier()
        {
            var services = MakeMinimalServiceCollection()
                .AddModels(mp =>
                {
                    mp.Add(new Model.ModelInfo
                    {
                        name = "Namespace.Using_Version_NoIdentifier",
                        url = "http://test.org",
                        version = "1.0.0"
                    });
                });
            var provider = services.BuildServiceProvider();
            var converter = provider.GetRequiredService<CqlToElmConverter>();
            var library = converter.ConvertLibrary(@"
                library UsingTest version '1.0.0'

                using Namespace.Using_Version_NoIdentifier version '1.0.0'
            ");
            Assert.IsNotNull(library.usings);
            Assert.AreEqual(1, library.usings.Length);
            Assert.AreEqual("Namespace.Using_Version_NoIdentifier", library.usings[0].localIdentifier);
            Assert.AreEqual("http://test.org", library.usings[0].uri);
            Assert.AreEqual("1.0.0", library.usings[0].version);
            Assert.IsNotNull(library.usings[0].localId);
        }

        [TestMethod]
        public void Using_NoVersion_NoIdentifier()
        {
            var services = MakeMinimalServiceCollection()
                .AddModels(mp =>
                {
                    mp.Add(new Model.ModelInfo
                    {
                        name = "Namespace.Using_NoVersion_NoIdentifier",
                        url = "http://test.org",
                        version = "1.0.0"
                    });
                });

            var provider = services.BuildServiceProvider();
            var converter = provider.GetRequiredService<CqlToElmConverter>();
            var library = converter.ConvertLibrary(@"
                library UsingTest version '1.0.0'

                using Namespace.Using_NoVersion_NoIdentifier
            ");
            Assert.IsNotNull(library.usings);
            Assert.AreEqual(1, library.usings.Length);
            Assert.AreEqual("Namespace.Using_NoVersion_NoIdentifier", library.usings[0].localIdentifier);
            Assert.AreEqual("http://test.org", library.usings[0].uri);
            Assert.IsTrue(string.IsNullOrWhiteSpace(library.usings[0].version));
            Assert.IsNotNull(library.usings[0].localId);
        }

        [TestMethod]
        public void Using_Duplicate_System_NoLocalAlias()
        {
            var services = MakeMinimalServiceCollection()
                .AddModels(mp =>
                {
                    mp.Add(new Model.ModelInfo
                    {
                        name = "System",
                        url = "urn:hl7-org:elm-types:r1",
                        version = "1.0.0"
                    });
                });

            var provider = services.BuildServiceProvider();
            var converter = provider.GetRequiredService<CqlToElmConverter>();
            var library = converter.ConvertLibrary(@"
                library UsingTest version '1.0.0'

                using System version '1.0.0'
            ");
            Assert.IsNotNull(library.usings);
            Assert.AreEqual(1, library.usings.Length);
            Assert.AreEqual("System", library.usings[0].localIdentifier);
            Assert.AreEqual("urn:hl7-org:elm-types:r1", library.usings[0].uri);
            Assert.AreEqual("1.0.0", library.usings[0].version);
            Assert.IsNotNull(library.usings[0].localId);
        }

        #endregion

        #region Include

        [TestMethod]
        public void Include_AllTerms()
        {
            var library = MakeLibrary(@"
                library IncludeTest version '1.0.0'

                include MyLibrary version '1.0.0' called Derp
            ", "Could not find library: MyLibrary*");
            Assert.IsNotNull(library.includes);
            Assert.AreEqual(1, library.includes.Length);
            Assert.AreEqual("MyLibrary", library.includes[0].path);
            Assert.AreEqual("1.0.0", library.includes[0].version);
            Assert.AreEqual("Derp", library.includes[0].localIdentifier);
            Assert.IsNotNull(library.includes[0].localId);
        }

        [TestMethod]
        public void Include_AllTerms_WithNamespace()
        {
            var library = MakeLibrary(@"
                library IncludeTest version '1.0.0'

                include Namespace.MyLibrary version '1.0.0' called Derp
            ", "Could not find library: Namespace.MyLibrary*");
            Assert.IsNotNull(library.includes);
            Assert.AreEqual(1, library.includes.Length);
            Assert.AreEqual("Namespace.MyLibrary", library.includes[0].path);
            Assert.AreEqual("1.0.0", library.includes[0].version);
            Assert.AreEqual("Derp", library.includes[0].localIdentifier);
            Assert.IsNotNull(library.includes[0].localId);
        }

        [TestMethod]
        public void Include_NoVersion_LocalIdentifier()
        {
            var library = MakeLibrary(@"
                library IncludeTest version '1.0.0'

                include Namespace.MyLibrary called Derp
            ", "Could not find library: Namespace.MyLibrary*");
            Assert.IsNotNull(library.includes);
            Assert.AreEqual(1, library.includes.Length);
            Assert.AreEqual("Namespace.MyLibrary", library.includes[0].path);
            Assert.IsTrue(string.IsNullOrWhiteSpace(library.includes[0].version));
            Assert.AreEqual("Derp", library.includes[0].localIdentifier);
            Assert.IsNotNull(library.includes[0].localId);

        }

        [TestMethod]
        public void Include_Version_NoIdentifier()
        {
            var library = MakeLibrary(@"
                library IncludeTest version '1.0.0'

                include Namespace.MyLibrary version '1.0.0'
            ", "Could not find library: Namespace.MyLibrary*");
            Assert.IsNotNull(library.includes);
            Assert.AreEqual(1, library.includes.Length);
            Assert.AreEqual("Namespace.MyLibrary", library.includes[0].path);
            Assert.AreEqual("1.0.0", library.includes[0].version);

            // EK: the localIdentifier is the same as the (last part of the) path, at least
            // that's what I see Bryn's tool doing.
            //Assert.IsTrue(string.IsNullOrWhiteSpace(library.includes[0].localIdentifier));
            library.includes[0].localIdentifier.Should().Be("MyLibrary");

            Assert.IsNotNull(library.includes[0].localId);

        }

        [TestMethod]
        public void Include_NoVersion_NoIdentifier()
        {
            var library = MakeLibrary(@"
                library IncludeTest version '1.0.0'

                include Namespace.MyLibrary
            ", "Could not find library: Namespace.MyLibrary*");
            Assert.IsNotNull(library.includes);
            Assert.AreEqual(1, library.includes.Length);
            Assert.AreEqual("Namespace.MyLibrary", library.includes[0].path);
            Assert.IsTrue(string.IsNullOrWhiteSpace(library.includes[0].version));

            // EK: the localIdentifier is the same as the (last part of the) path, at least
            // that's what I see Bryn's tool doing.
            // Assert.IsTrue(string.IsNullOrWhiteSpace(library.includes[0].localIdentifier));
            library.includes[0].localIdentifier.Should().Be("MyLibrary");

            Assert.IsNotNull(library.includes[0].localId);

        }

        #endregion

        #region CodeSystem

        [TestMethod]
        public void CodeSystem_AllTerms()
        {
            var library = MakeLibrary(@"
                library IncludeTest version '1.0.0'

                private codesystem Name: 'id' version 'version string'
            ");
            Assert.IsNotNull(library.codeSystems);
            Assert.AreEqual(1, library.codeSystems.Length);
            Assert.AreEqual(AccessModifier.Private, library.codeSystems[0].accessLevel);
            Assert.AreEqual("Name", library.codeSystems[0].name);
            Assert.AreEqual("id", library.codeSystems[0].id);
            Assert.AreEqual("version string", library.codeSystems[0].version);
        }

        [TestMethod]
        public void CodeSystem_Without_Access_Modifier()
        {
            var library = MakeLibrary(@"
                library IncludeTest version '1.0.0'

                codesystem Name: 'id' version 'version string'
            ");
            Assert.IsNotNull(library.codeSystems);
            Assert.AreEqual(1, library.codeSystems.Length);
            Assert.AreEqual(AccessModifier.Public, library.codeSystems[0].accessLevel);
            Assert.AreEqual("Name", library.codeSystems[0].name);
            Assert.AreEqual("id", library.codeSystems[0].id);
            Assert.AreEqual("version string", library.codeSystems[0].version);
        }

        [TestMethod]
        public void CodeSystem_Without_Version()
        {
            var library = MakeLibrary(@"
                library IncludeTest version '1.0.0'

                private codesystem Name: 'id'
            ");
            Assert.IsNotNull(library.codeSystems);
            Assert.AreEqual(1, library.codeSystems.Length);
            Assert.AreEqual(AccessModifier.Private, library.codeSystems[0].accessLevel);
            Assert.AreEqual("Name", library.codeSystems[0].name);
            Assert.AreEqual("id", library.codeSystems[0].id);
            Assert.IsTrue(string.IsNullOrWhiteSpace(library.codeSystems[0].version));
        }

        [TestMethod]
        public void CodeSystem_Minimal()
        {
            var library = MakeLibrary(@"
                library IncludeTest version '1.0.0'

                codesystem Name: 'id'
            ");
            Assert.IsNotNull(library.codeSystems);
            Assert.AreEqual(1, library.codeSystems.Length);
            Assert.AreEqual(AccessModifier.Public, library.codeSystems[0].accessLevel);
            Assert.AreEqual("Name", library.codeSystems[0].name);
            Assert.AreEqual("id", library.codeSystems[0].id);
            Assert.IsTrue(string.IsNullOrWhiteSpace(library.codeSystems[0].version));
        }

        [TestMethod]
        public void CodeSystems_Two()
        {
            var library = MakeLibrary(@"
                library IncludeTest version '1.0.0'

                private codesystem Name: 'id' version 'version string'
                private codesystem Name2: 'id2' version 'version2'

            ");
            Assert.IsNotNull(library.codeSystems);
            Assert.AreEqual(2, library.codeSystems.Length);

            Assert.AreEqual(AccessModifier.Private, library.codeSystems[0].accessLevel);
            Assert.AreEqual("Name", library.codeSystems[0].name);
            Assert.AreEqual("id", library.codeSystems[0].id);
            Assert.AreEqual("version string", library.codeSystems[0].version);

            Assert.AreEqual(AccessModifier.Private, library.codeSystems[1].accessLevel);
            Assert.AreEqual("Name2", library.codeSystems[1].name);
            Assert.AreEqual("id2", library.codeSystems[1].id);
            Assert.AreEqual("version2", library.codeSystems[1].version);
        }

        #endregion

        #region ValueSet

        [TestMethod]
        public void ValueSet_AllTerms_OneCodeSystems()
        {
            var library = MakeLibrary(@"
                library IncludeTest version '1.0.0'

                private valueset Name: 'id' version 'version string' codesystems { lib.cs1 }
            ");
            Assert.IsNotNull(library.valueSets);
            Assert.AreEqual(1, library.valueSets.Length);
            Assert.AreEqual(AccessModifier.Private, library.valueSets[0].accessLevel);
            Assert.AreEqual("Name", library.valueSets[0].name);
            Assert.AreEqual("id", library.valueSets[0].id);
            Assert.AreEqual("version string", library.valueSets[0].version);
            Assert.IsNotNull(library.valueSets[0].codeSystem);
            Assert.AreEqual(1, library.valueSets[0].codeSystem.Length);
            Assert.AreEqual("lib", library.valueSets[0].codeSystem[0].libraryName);
            Assert.AreEqual("cs1", library.valueSets[0].codeSystem[0].name);
        }

        [TestMethod]
        public void ValueSet_AllTerms_EvenCodeSystems()
        {
            var library = MakeLibrary(@"
                library IncludeTest version '1.0.0'

                private valueset Name: 'id' version 'version string' codesystems { lib.cs1, cs2 }
            ");
            Assert.IsNotNull(library.valueSets);
            Assert.AreEqual(1, library.valueSets.Length);
            Assert.AreEqual(AccessModifier.Private, library.valueSets[0].accessLevel);
            Assert.AreEqual("Name", library.valueSets[0].name);
            Assert.AreEqual("id", library.valueSets[0].id);
            Assert.AreEqual("version string", library.valueSets[0].version);
            Assert.IsNotNull(library.valueSets[0].codeSystem);
            Assert.AreEqual(2, library.valueSets[0].codeSystem.Length);
            Assert.AreEqual("lib", library.valueSets[0].codeSystem[0].libraryName);
            Assert.AreEqual("cs1", library.valueSets[0].codeSystem[0].name);
            Assert.IsTrue(string.IsNullOrWhiteSpace(library.valueSets[0].codeSystem[1].libraryName));
            Assert.AreEqual("cs2", library.valueSets[0].codeSystem[1].name);
        }


        [TestMethod]
        public void ValueSet_AllTerms_OddCodeSystems()
        {
            var library = MakeLibrary(@"
                library IncludeTest version '1.0.0'

                private valueset Name: 'id' version 'version string' codesystems { lib.cs1, cs2, lib2.cs3 }
            ");
            Assert.IsNotNull(library.valueSets);
            Assert.AreEqual(1, library.valueSets.Length);
            Assert.AreEqual(AccessModifier.Private, library.valueSets[0].accessLevel);
            Assert.AreEqual("Name", library.valueSets[0].name);
            Assert.AreEqual("id", library.valueSets[0].id);
            Assert.AreEqual("version string", library.valueSets[0].version);
            Assert.IsNotNull(library.valueSets[0].codeSystem);
            Assert.AreEqual(3, library.valueSets[0].codeSystem.Length);
            Assert.AreEqual("lib", library.valueSets[0].codeSystem[0].libraryName);
            Assert.AreEqual("cs1", library.valueSets[0].codeSystem[0].name);
            Assert.IsTrue(string.IsNullOrWhiteSpace(library.valueSets[0].codeSystem[1].libraryName));
            Assert.AreEqual("cs2", library.valueSets[0].codeSystem[1].name);
            Assert.AreEqual("lib2", library.valueSets[0].codeSystem[2].libraryName);
            Assert.AreEqual("cs3", library.valueSets[0].codeSystem[2].name);
        }

        [TestMethod]
        public void ValueSet_Without_Access_Modifier()
        {
            var library = MakeLibrary(@"
                library IncludeTest version '1.0.0'

                valueset Name: 'id' version 'version string'
            ");
            Assert.IsNotNull(library.valueSets);
            Assert.AreEqual(1, library.valueSets.Length);
            Assert.AreEqual(AccessModifier.Public, library.valueSets[0].accessLevel);
            Assert.AreEqual("Name", library.valueSets[0].name);
            Assert.AreEqual("id", library.valueSets[0].id);
            Assert.AreEqual("version string", library.valueSets[0].version);
        }

        [TestMethod]
        public void ValueSet_Without_Version()
        {
            var library = MakeLibrary(@"
                library IncludeTest version '1.0.0'

                private valueset Name: 'id'
            ");
            Assert.IsNotNull(library.valueSets);
            Assert.AreEqual(1, library.valueSets.Length);
            Assert.AreEqual(AccessModifier.Private, library.valueSets[0].accessLevel);
            Assert.AreEqual("Name", library.valueSets[0].name);
            Assert.AreEqual("id", library.valueSets[0].id);
            Assert.IsTrue(string.IsNullOrWhiteSpace(library.valueSets[0].version));
        }

        [TestMethod]
        public void ValueSet_Minimal()
        {
            var library = MakeLibrary(@"
                library IncludeTest version '1.0.0'

                valueset Name: 'id'
            ");
            Assert.IsNotNull(library.valueSets);
            Assert.AreEqual(1, library.valueSets.Length);
            Assert.AreEqual(AccessModifier.Public, library.valueSets[0].accessLevel);
            Assert.AreEqual("Name", library.valueSets[0].name);
            Assert.AreEqual("id", library.valueSets[0].id);
            Assert.IsTrue(string.IsNullOrWhiteSpace(library.valueSets[0].version));
        }

        [TestMethod]
        public void ValueSets_Two()
        {
            var library = MakeLibrary(@"
                library IncludeTest version '1.0.0'

                private valueset Name: 'id' version 'version string'
                private valueset Name2: 'id2' version 'version2'

            ");
            Assert.IsNotNull(library.valueSets);
            Assert.AreEqual(2, library.valueSets.Length);

            Assert.AreEqual(AccessModifier.Private, library.valueSets[0].accessLevel);
            Assert.AreEqual("Name", library.valueSets[0].name);
            Assert.AreEqual("id", library.valueSets[0].id);
            Assert.AreEqual("version string", library.valueSets[0].version);

            Assert.AreEqual(AccessModifier.Private, library.valueSets[1].accessLevel);
            Assert.AreEqual("Name2", library.valueSets[1].name);
            Assert.AreEqual("id2", library.valueSets[1].id);
            Assert.AreEqual("version2", library.valueSets[1].version);
        }
        [TestMethod]
        public void ValueSet_CodeSystems_NoVersion()
        {
            var library = MakeLibrary(@"
                library IncludeTest version '1.0.0'

                valueset Name: 'id' codesystems { lib.cs1, cs2, lib2.cs3 }
            ");
            Assert.IsNotNull(library.valueSets);
            Assert.AreEqual(1, library.valueSets.Length);
            Assert.AreEqual(AccessModifier.Public, library.valueSets[0].accessLevel);
            Assert.AreEqual("Name", library.valueSets[0].name);
            Assert.AreEqual("id", library.valueSets[0].id);
            Assert.IsTrue(string.IsNullOrWhiteSpace(library.valueSets[0].version));
            Assert.IsNotNull(library.valueSets[0].codeSystem);
            Assert.AreEqual(3, library.valueSets[0].codeSystem.Length);
            Assert.AreEqual("lib", library.valueSets[0].codeSystem[0].libraryName);
            Assert.AreEqual("cs1", library.valueSets[0].codeSystem[0].name);
            Assert.IsTrue(string.IsNullOrWhiteSpace(library.valueSets[0].codeSystem[1].libraryName));
            Assert.AreEqual("cs2", library.valueSets[0].codeSystem[1].name);
            Assert.AreEqual("lib2", library.valueSets[0].codeSystem[2].libraryName);
            Assert.AreEqual("cs3", library.valueSets[0].codeSystem[2].name);
        }

        #endregion

        #region Code

        [TestMethod]
        public void Code_WithoutDisplay()
        {
            var library = MakeLibrary(@"
                library IncludeTest version '1.0.0'

                code Name: 'id' from lib.cs1
            ");
            Assert.IsNotNull(library.codes);
            Assert.AreEqual(1, library.codes.Length);
            Assert.AreEqual(AccessModifier.Public, library.codes[0].accessLevel);
            Assert.AreEqual("Name", library.codes[0].name);
            Assert.AreEqual("id", library.codes[0].id);
            Assert.IsNotNull(library.codes[0].codeSystem);
            Assert.AreEqual("lib", library.codes[0].codeSystem.libraryName);
            Assert.AreEqual("cs1", library.codes[0].codeSystem.name);
        }

        [TestMethod]
        public void Code_AccessModifier_WithoutDisplay()
        {
            var library = MakeLibrary(@"
                library IncludeTest version '1.0.0'

                private code Name: 'id' from lib.cs1
            ");
            Assert.IsNotNull(library.codes);
            Assert.AreEqual(1, library.codes.Length);
            Assert.AreEqual(AccessModifier.Private, library.codes[0].accessLevel);
            Assert.AreEqual("Name", library.codes[0].name);
            Assert.AreEqual("id", library.codes[0].id);
            Assert.IsNotNull(library.codes[0].codeSystem);
            Assert.AreEqual("lib", library.codes[0].codeSystem.libraryName);
            Assert.AreEqual("cs1", library.codes[0].codeSystem.name);
        }


        [TestMethod]
        public void Code_WithDisplay()
        {
            var library = MakeLibrary(@"
                library IncludeTest version '1.0.0'

                code Name: 'id' from lib.cs1 display 'Code display text'
            ");
            Assert.IsNotNull(library.codes);
            Assert.AreEqual(1, library.codes.Length);
            Assert.AreEqual(AccessModifier.Public, library.codes[0].accessLevel);
            Assert.AreEqual("Name", library.codes[0].name);
            Assert.AreEqual("id", library.codes[0].id);
            Assert.IsNotNull(library.codes[0].codeSystem);
            Assert.AreEqual("lib", library.codes[0].codeSystem.libraryName);
            Assert.AreEqual("cs1", library.codes[0].codeSystem.name);
            Assert.AreEqual("Code display text", library.codes[0].display);
        }

        [TestMethod]
        public void Code_AllTerms()
        {
            var library = MakeLibrary(@"
                library IncludeTest version '1.0.0'

                private code Name: 'id' from lib.cs1 display 'Code display text'
            ");
            Assert.IsNotNull(library.codes);
            Assert.AreEqual(1, library.codes.Length);
            Assert.AreEqual(AccessModifier.Private, library.codes[0].accessLevel);
            Assert.AreEqual("Name", library.codes[0].name);
            Assert.AreEqual("id", library.codes[0].id);
            Assert.IsNotNull(library.codes[0].codeSystem);
            Assert.AreEqual("lib", library.codes[0].codeSystem.libraryName);
            Assert.AreEqual("cs1", library.codes[0].codeSystem.name);
            Assert.AreEqual("Code display text", library.codes[0].display);
        }

        #endregion

        #region Concept

        [TestMethod]
        public void Concept_AllTerms()
        {
            var library = MakeLibrary(@"
                library IncludeTest version '1.0.0'

                private concept Name: { lib.code1, code2, lib2.code3 } display 'My concept'
            ");
            Assert.IsNotNull(library.concepts);
            Assert.AreEqual(1, library.concepts.Length);
            Assert.AreEqual(AccessModifier.Private, library.concepts[0].accessLevel);
            Assert.AreEqual("Name", library.concepts[0].name);
            Assert.IsNotNull(library.concepts[0].code);
            Assert.AreEqual(3, library.concepts[0].code.Length);
            Assert.AreEqual("lib", library.concepts[0].code[0].libraryName);
            Assert.AreEqual("code1", library.concepts[0].code[0].name);

            Assert.IsTrue(string.IsNullOrWhiteSpace(library.concepts[0].code[1].libraryName));
            Assert.AreEqual("code2", library.concepts[0].code[1].name);

            Assert.AreEqual("lib2", library.concepts[0].code[2].libraryName);
            Assert.AreEqual("code3", library.concepts[0].code[2].name);

            Assert.AreEqual("My concept", library.concepts[0].display);


        }

        [TestMethod]
        public void Concept_NoDisplay()
        {
            var library = MakeLibrary(@"
                library IncludeTest version '1.0.0'

                concept Name: { lib.code1 }
            ");
            Assert.IsNotNull(library.concepts);
            Assert.AreEqual(1, library.concepts.Length);
            Assert.AreEqual(AccessModifier.Public, library.concepts[0].accessLevel);
            Assert.AreEqual("Name", library.concepts[0].name);
            Assert.IsNotNull(library.concepts[0].code);
            Assert.AreEqual(1, library.concepts[0].code.Length);
            Assert.AreEqual("lib", library.concepts[0].code[0].libraryName);
            Assert.AreEqual("code1", library.concepts[0].code[0].name);

            Assert.IsTrue(string.IsNullOrWhiteSpace(library.concepts[0].display));
        }

        [TestMethod]
        public void Concept_Build()
        {
            var library = MakeLibrary(@"
                library IncludeTest version '1.0.0'

                codesystem ""SystemA"": 'http://hl7.org'
                code ""code1"": 'code1' from ""SystemA""
                code ""code2"": 'code2' from ""SystemA""
                code ""code3"": 'code3' from ""SystemA""

                private concept Name: { ""code1"", ""code2"", ""code3"" } display 'My concept'
            ");
            var lib = ExpressionBuilderFor(library);
            _ = lib.Build();
        }


        #endregion

        #region Parameters

        [TestMethod]
        public void Paramter_AllTerms()
        {
            var library = MakeLibrary(@"
                library IncludeTest version '1.0.0'

                private parameter Name System.String default 'default value'
            ");

            var par0 = library.parameters.Should().ContainSingle().Subject;
            par0.accessLevel.Should().Be(AccessModifier.Private);
            par0.name.Should().Be("Name");
            par0.parameterTypeSpecifier.Should().Be(SystemTypes.StringType);
            par0.@default.Should().BeLiteralString("default value");
        }

        [TestMethod]
        public void Parameter_AllTermsWithCast()
        {
            var library = MakeLibrary(@"
                library IncludeTest version '1.0.0'

                private parameter Name System.Decimal default 1
            ");

            var par0 = library.parameters.Should().ContainSingle().Subject;
            par0.parameterTypeSpecifier.Should().Be(SystemTypes.DecimalType);
            var todecimal = par0.@default.Should().BeOfType<ToDecimal>().Subject;
            todecimal.operand.Should().BeLiteralInteger(1);
        }

        [TestMethod]
        public void Parameter_Default()
        {
            var library = MakeLibrary(@"
                library IncludeTest version '1.0.0'

                private parameter Name default 'default value'
            ");

            var par0 = library.parameters.Should().ContainSingle().Subject;
            par0.parameterTypeSpecifier.Should().Be(SystemTypes.StringType);
            par0.@default.Should().BeLiteralString("default value");
        }

        [TestMethod]
        public void Parameter_Type()
        {
            var library = MakeLibrary(@"
                library IncludeTest version '1.0.0'

                private parameter Name System.String
            ");

            var par0 = library.parameters.Should().ContainSingle().Subject;
            par0.parameterTypeSpecifier.Should().Be(SystemTypes.StringType);
            par0.@default.Should().BeNull();
        }

        [TestMethod]
        public void Parameter_None()
        {
            var library = MakeLibrary(@"
                library IncludeTest version '1.0.0'

                private parameter Name
            ", "Parameter must have either a type or a default value.");
        }
        #endregion
    }
}
/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test
{
    /// <summary>
    /// Translates libraries against the QICore and US Core model infos that ship with the SDK.
    /// </summary>
    [TestClass]
    public class BundledModelTest : Base
    {
        // These tests assert that the bundled model resolves and that a retrieve against it translates
        // without errors. The retrieve's dataType and templateId are asserted once #1741 emits the
        // profile's target type and the profile id.

        [DataTestMethod]
        [DataRow("4.1.1", CqlModel.USCore311, CqlModel.QICore411)]
        [DataRow("6.0.0", CqlModel.USCore610, CqlModel.QICore600)]
        public void QICore_Model_Resolves_And_Retrieve_Translates(string version, CqlModel usCore, CqlModel qiCore)
        {
            var cqlToolkit = CreateCqlToolkit(Models: [CqlModel.ElmR1, CqlModel.Fhir401, usCore, qiCore]);
            var library = cqlToolkit.MakeLibrary($"""
                                                 library QICoreTest version '1.0.0'

                                                 using QICore version '{version}'

                                                 context Patient

                                                 define Encounters: [Encounter]
                                                 """);

            library.statements.Single(s => s.name == "Encounters").expression.Should().BeOfType<Retrieve>();
        }

        [DataTestMethod]
        [DataRow("3.1.1", CqlModel.USCore311)]
        [DataRow("6.1.0", CqlModel.USCore610)]
        public void USCore_Model_Resolves_And_Retrieve_Translates(string version, CqlModel usCore)
        {
            var cqlToolkit = CreateCqlToolkit(Models: [CqlModel.ElmR1, usCore]);
            var library = cqlToolkit.MakeLibrary($"""
                                                 library USCoreTest version '1.0.0'

                                                 using USCore version '{version}'

                                                 define Encounters: [EncounterProfile]
                                                 """);

            // `context Patient` is left out: US Core names its patient class PatientProfile, and the
            // translator resolves a context by class name rather than through the model's contextInfo (#1741).
            library.statements.Single(s => s.name == "Encounters").expression.Should().BeOfType<Retrieve>();
        }

        [TestMethod]
        public void Selecting_Two_Versions_Of_One_Model_Is_Refused()
        {
            var create = () => CreateCqlToolkit(Models: [CqlModel.ElmR1, CqlModel.Fhir401, CqlModel.USCore311, CqlModel.QICore411, CqlModel.USCore610, CqlModel.QICore600]);

            create.Should().Throw<ArgumentException>()
                  .WithMessage("*http://hl7.org/fhir/us/core*more than one version ('3.1.1', '6.1.0')*Select one version of each model per toolkit*");
        }
    }
}

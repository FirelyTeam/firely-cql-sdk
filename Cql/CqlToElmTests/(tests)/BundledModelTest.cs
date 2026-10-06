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
        [DataTestMethod]
        [DataRow("4.1.1", CqlModel.USCore311, CqlModel.QICore411)]
        [DataRow("6.0.0", CqlModel.USCore610, CqlModel.QICore600)]
        public void QICore_Retrieve_Is_Typed_As_QICore_Class(string version, CqlModel usCore, CqlModel qiCore)
        {
            var cqlToolkit = CreateCqlToolkit(Models: [CqlModel.ElmR1, CqlModel.Fhir401, usCore, qiCore]);
            var library = cqlToolkit.MakeLibrary($"""
                                                 library QICoreTest version '1.0.0'

                                                 using QICore version '{version}'

                                                 context Patient

                                                 define Encounters: [Encounter]
                                                 """);

            var retrieve = library.statements.Single(s => s.name == "Encounters").expression.Should().BeOfType<Retrieve>().Subject;
            retrieve.dataType.Name.Should().Be("{http://hl7.org/fhir/us/qicore}Encounter");
            // The translator does not take the retrieve's templateId from the class's identifier (#1741).
        }

        [DataTestMethod]
        [DataRow("3.1.1", CqlModel.USCore311)]
        [DataRow("6.1.0", CqlModel.USCore610)]
        public void USCore_Retrieve_Is_Typed_As_USCore_Profile(string version, CqlModel usCore)
        {
            var cqlToolkit = CreateCqlToolkit(Models: [CqlModel.ElmR1, usCore]);
            var library = cqlToolkit.MakeLibrary($"""
                                                 library USCoreTest version '1.0.0'

                                                 using USCore version '{version}'

                                                 define Encounters: [EncounterProfile]
                                                 """);

            // `context Patient` is left out: US Core names its patient class PatientProfile, and the
            // translator resolves a context by class name rather than through the model's contextInfo (#1741).
            var retrieve = library.statements.Single(s => s.name == "Encounters").expression.Should().BeOfType<Retrieve>().Subject;
            retrieve.dataType.Name.Should().Be("{http://hl7.org/fhir/us/core}EncounterProfile");
            // The translator does not take the retrieve's templateId from the class's identifier (#1741).
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hl7.Cql.Runtime;
using System.Linq;
using Hl7.Fhir.Model;

namespace CoreTests
{
    [TestClass]
    public class CqlRuntimeTests
    {

        [TestMethod]
        public void DefinitionDictionary_BestMatch()
        {
            var dd = new DefinitionDictionary<string>();
            var score1 = dd.Score([typeof(Claim)], [typeof(Claim)]);
            Assert.AreEqual(0, score1); // exact match
            var score2 = dd.Score([typeof(Claim)], [typeof(DomainResource)]);
            Assert.AreEqual(1, score2); // signature is 1 level removed from paramter type
            var score3 = dd.Score([typeof(DomainResource)], [typeof(Claim)]);
            Assert.IsNull(score3); // DomainResource is not assignable to Claim

            var bestMatch = dd.BestMatch([typeof(Claim)], new[]
            {
                ([typeof(DomainResource)], "DomainResource"),
                (new[] { typeof(Claim) }, "Claim"),
            });
            Assert.AreEqual("Claim", bestMatch);
        }

        [TestMethod]
        public void DefinitionDictionary_BestMatch_Ambiguous()
        {
            var dd = new DefinitionDictionary<string>();
            var score1 = dd.Score([typeof(Claim), typeof(Claim)], [typeof(Claim), typeof(DomainResource)]);
            Assert.AreEqual(1, score1); // exact match
            var score2 = dd.Score([typeof(Claim), typeof(Claim)], [typeof(DomainResource), typeof(Claim)]);
            Assert.AreEqual(1, score2); // signature is 1 level removed from paramter type

            var bestMatch = dd.BestMatch([typeof(Claim), typeof(Claim)], new[]
            {
                ([typeof(DomainResource), typeof(Claim)], "DomainResource, Claim"),
                (new[] { typeof(Claim), typeof(DomainResource) }, "Claim, DomainResource"),
            });
            Assert.IsNull(bestMatch);
        }

        [TestMethod]
        public void DefinitionDictionary_Add_Overloads()
        {
            var dd = new DefinitionDictionary<string>();
            const string lib = nameof(lib);
            const string def = nameof(def);

            Type[] drSig = [typeof(DomainResource)];
            Type[] claimSig = [typeof(Claim)];

            dd.Add(lib, def, drSig, nameof(DomainResource));
            Assert.IsFalse(dd.ContainsKey(lib, def, claimSig));
            dd.Add(lib, def, claimSig, nameof(Claim));

            dd.TryGetDefinitionsForLibrary(lib, out var defs);
            var dict = defs.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            Assert.IsTrue(dict.TryGetValue(def, out var overloads));

            var bestMatch = dd.BestMatch(claimSig, overloads);
            Assert.AreEqual(nameof(Claim), bestMatch);
        }


        [TestMethod]
        public void DefinitionDictionary_TryGetValue_BestMatch()
        {
            var dd = new DefinitionDictionary<string>();
            const string lib = nameof(lib);
            const string def = nameof(def);

            Type[] drSig = [typeof(DomainResource)];
            Type[] claimSig = [typeof(Claim)];

            dd.Add(lib, def, drSig, nameof(DomainResource));
            Assert.IsFalse(dd.ContainsKey(lib, def, claimSig));
            Assert.IsTrue(dd.TryGetValue(lib, def, claimSig, out var match));
            Assert.AreEqual(nameof(DomainResource), match);
        }

    }
}

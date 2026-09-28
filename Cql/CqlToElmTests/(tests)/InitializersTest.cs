/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using System.Threading.Tasks;
using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class InitializersTest
    {
        [TestMethod]
        public void NextId_ForTheSameObject_ReturnsTheSameId()
        {
            var element = new object();

            Initializers.NextId(element).Should().Be(Initializers.NextId(element));
        }

        [TestMethod]
        public void NextId_ForDifferentObjects_ReturnsDifferentIds()
        {
            Initializers.NextId(new object()).Should().NotBe(Initializers.NextId(new object()));
        }

        [TestMethod]
        public void NextId_WithoutAnObject_ReturnsADifferentIdEachTime()
        {
            Initializers.NextId().Should().NotBe(Initializers.NextId());
        }

        [TestMethod]
        public void NextId_FromManyThreadsAtOnce_GivesEachObjectOneIdOfItsOwn()
        {
            // Translations and compilations running in parallel in one process all number their ELM elements here.
            var objects = Enumerable.Range(0, 200_000).Select(_ => new object()).ToArray();
            var ids = new string[objects.Length];
            var idsAskedAgain = new string[objects.Length];

            Parallel.For(0, objects.Length, index => ids[index] = Initializers.NextId(objects[index]));
            Parallel.For(0, objects.Length, index => idsAskedAgain[index] = Initializers.NextId(objects[index]));

            ids.Distinct().Should().HaveCount(objects.Length);
            idsAskedAgain.Should().Equal(ids);
        }

        [TestMethod]
        public void NextId_ForTheSameNewObjectsFromManyThreadsAtOnce_TakesOneNumberPerObject()
        {
            // Every pass walks the same new objects in the same order, and the passes run at once, so several threads
            // meet an object for the first time together. The object still takes one number from the counter, so the
            // numbers the objects get follow on from each other without a gap.
            const int passes = 8;
            var objects = Enumerable.Range(0, 50_000).Select(_ => new object()).ToArray();
            var ids = new string[passes][];

            Parallel.For(0, passes, pass => ids[pass] = objects.Select(Initializers.NextId).ToArray());

            var numbers = ids[0].Select(long.Parse).ToArray();
            (numbers.Max() - numbers.Min() + 1).Should().Be(objects.Length);
            ids.Should().AllSatisfy(passIds => passIds.Should().Equal(ids[0]));
        }
    }
}

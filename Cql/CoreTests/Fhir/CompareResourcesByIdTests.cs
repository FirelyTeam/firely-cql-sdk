/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Comparers;
using Hl7.Cql.Fhir.Extensions;
using Hl7.Fhir.Model;

namespace CoreTests.Fhir;

/// <summary>
/// Behavior locks for <c>CqlComparersExtensions.CompareResourcesById</c>, added alongside the
/// change (#1479) that hoists its <c>typeof(Patient).Assembly.GetTypes()</c> sweep into a
/// process-wide <c>static readonly Lazy&lt;Type[]&gt;</c>.
/// </summary>
/// <remarks>
/// That change has no observable behavior difference -- the same resource types end up registered
/// with the same <c>ResourceIdCqlComparer</c> built from the caller's <see cref="StringComparer"/>,
/// only the enumeration of the model assembly moves from per-call to once-per-process. So there is
/// no fail-first proof for any test here: every one of them passes on <c>develop</c> too, and that
/// is exactly the point. They exist to pin the registration semantics the hoist must preserve.
/// <para>
/// Two ways of breaking those semantics do fail here: a type list that loses types a runtime
/// instance can have, and a comparer that stops being built per call from the caller's
/// <see cref="StringComparer"/> -- by hoisting the comparer into the static alongside the type list,
/// for instance. A change that only drops types no runtime instance can ever have (restricting the
/// sweep to concrete types, say) is invisible to these tests, and so is moving the type list from a
/// process-wide cache to a per-instance one: both leave every observable registration identical,
/// which is why neither is claimed as covered.
/// </para>
/// </remarks>
[TestClass]
[TestCategory("UnitTest")]
public class CompareResourcesByIdTests
{
    private static CqlComparers ComparersById(StringComparer idComparer) =>
        new CqlComparers().CompareResourcesById(idComparer);

    /// <summary>
    /// The headline semantics: after opting in, two resources of the same type are equal exactly
    /// when their ids are, regardless of any other differing property.
    /// </summary>
    [TestMethod]
    public void Patients_CompareByIdAlone()
    {
        var comparers = ComparersById(StringComparer.Ordinal);

        var a = new Patient { Id = "p1", Active = true };
        var b = new Patient { Id = "p1", Active = false, BirthDate = "1980-01-01" };
        var c = new Patient { Id = "p2", Active = true };

        // Same id, different content -- equal, because only the id is compared.
        Assert.AreEqual(true, comparers.Equals(a, b, null));
        Assert.AreEqual(0, comparers.Compare(a, b, null));

        Assert.AreEqual(false, comparers.Equals(a, c, null));
        Assert.AreNotEqual(0, comparers.Compare(a, c, null));
    }

    /// <summary>
    /// The registration is not Patient-specific: the sweep covers every <see cref="Resource"/>
    /// descendant in the model assembly, so a second resource type behaves identically.
    /// </summary>
    [TestMethod]
    public void Observations_CompareByIdAlone()
    {
        var comparers = ComparersById(StringComparer.Ordinal);

        var a = new Observation { Id = "o1", Status = ObservationStatus.Final };
        var b = new Observation { Id = "o1", Status = ObservationStatus.Amended };
        var c = new Observation { Id = "o2", Status = ObservationStatus.Final };

        Assert.AreEqual(true, comparers.Equals(a, b, null));
        Assert.AreEqual(false, comparers.Equals(a, c, null));
    }

    /// <summary>
    /// A resource type that is not itself in the model assembly -- and therefore never directly
    /// registered by the sweep -- must still compare by id, resolved by walking up to its
    /// registered base type. This is the part of the behavior that depends on <em>which</em> types
    /// the sweep returns rather than merely on the loop running.
    /// </summary>
    [TestMethod]
    public void ResourceSubtypeOutsideModelAssembly_ComparesByIdViaBaseTypeRegistration()
    {
        var comparers = ComparersById(StringComparer.Ordinal);

        var a = new DerivedPatient { Id = "p1" };
        var b = new DerivedPatient { Id = "p1" };
        var c = new DerivedPatient { Id = "p2" };

        Assert.AreNotSame(a, b);
        Assert.AreEqual(true, comparers.Equals(a, b, null));
        Assert.AreEqual(false, comparers.Equals(a, c, null));
    }

    /// <summary>
    /// The caller's <see cref="StringComparer"/> is what decides id equality -- it is wrapped once
    /// into the single <c>ResourceIdCqlComparer</c> shared by every registered type.
    /// </summary>
    [TestMethod]
    public void SuppliedStringComparer_DecidesIdEquality()
    {
        var lower = new Patient { Id = "abc" };
        var upper = new Patient { Id = "ABC" };

        var ordinal = ComparersById(StringComparer.Ordinal);
        Assert.AreEqual(false, ordinal.Equals(lower, upper, null));

        var ignoreCase = ComparersById(StringComparer.OrdinalIgnoreCase);
        Assert.AreEqual(true, ignoreCase.Equals(lower, upper, null));

        // The chosen comparer applies to every registered resource type, not just Patient.
        Assert.AreEqual(false, ordinal.Equals(new Observation { Id = "abc" }, new Observation { Id = "ABC" }, null));
        Assert.AreEqual(true, ignoreCase.Equals(new Observation { Id = "abc" }, new Observation { Id = "ABC" }, null));
    }

    /// <summary>
    /// Two fresh <c>CqlComparers</c> each opting in -- which is what happens per <c>CqlContext</c>,
    /// i.e. per patient in a batch evaluation. Both must register a complete, independent set:
    /// the type list is shared process-wide, but the comparers built from it are per instance, so
    /// a different <see cref="StringComparer"/> on the second call must not leak into the first.
    /// </summary>
    [TestMethod]
    public void CalledOnSeparateInstances_EachRegistrationIsCompleteAndIndependent()
    {
        var first = ComparersById(StringComparer.Ordinal);
        var second = ComparersById(StringComparer.OrdinalIgnoreCase);
        var third = ComparersById(StringComparer.Ordinal);

        var lower = new Patient { Id = "abc" };
        var upper = new Patient { Id = "ABC" };

        Assert.AreEqual(false, first.Equals(lower, upper, null));
        Assert.AreEqual(true, second.Equals(lower, upper, null));
        Assert.AreEqual(false, third.Equals(lower, upper, null));

        // Same answers for a second resource type, from every instance.
        var o1 = new Observation { Id = "o1" };
        var o2 = new Observation { Id = "o1" };
        Assert.AreEqual(true, first.Equals(o1, o2, null));
        Assert.AreEqual(true, second.Equals(o1, o2, null));
        Assert.AreEqual(true, third.Equals(o1, o2, null));
    }

    /// <summary>
    /// Opting in twice on the same instance replaces the comparers of the types the sweep registers
    /// with ones built from the newly supplied <see cref="StringComparer"/>. This holds for the
    /// registered types themselves; a type that was resolved through its base type instead keeps the
    /// comparer it first resolved to, which
    /// <see cref="CalledTwiceOnSameInstance_KeepsTheComparerATypeAlreadyResolvedThroughItsBaseType"/>
    /// pins.
    /// </summary>
    [TestMethod]
    public void CalledTwiceOnSameInstance_LastRegistrationWinsForTheRegisteredTypes()
    {
        var comparers = new CqlComparers();

        comparers.CompareResourcesById(StringComparer.Ordinal);
        var lower = new Patient { Id = "abc" };
        var upper = new Patient { Id = "ABC" };
        Assert.AreEqual(false, comparers.Equals(lower, upper, null));

        comparers.CompareResourcesById(StringComparer.OrdinalIgnoreCase);
        Assert.AreEqual(true, comparers.Equals(lower, upper, null));

        // Ids that differ by more than case stay unequal under either comparer.
        Assert.AreEqual(false, comparers.Equals(lower, new Patient { Id = "abd" }, null));
    }

    /// <summary>
    /// The counterpart of <see cref="CalledTwiceOnSameInstance_LastRegistrationWinsForTheRegisteredTypes"/>:
    /// a type the sweep never registers resolves through its base type, and that resolution is memoized
    /// onto the type itself. The memoized entry is not replaced, so a later opt-in with a different
    /// <see cref="StringComparer"/> reaches the base type but not the type that already resolved.
    /// Recorded because it makes "last registration wins" true of the registered types only.
    /// </summary>
    [TestMethod]
    public void CalledTwiceOnSameInstance_KeepsTheComparerATypeAlreadyResolvedThroughItsBaseType()
    {
        var comparers = new CqlComparers();
        var lower = new DerivedPatient { Id = "abc" };
        var upper = new DerivedPatient { Id = "ABC" };

        comparers.CompareResourcesById(StringComparer.Ordinal);
        // Resolves DerivedPatient through Patient and memoizes the case-sensitive comparer onto it.
        Assert.AreEqual(false, comparers.Equals(lower, upper, null));

        comparers.CompareResourcesById(StringComparer.OrdinalIgnoreCase);

        Assert.AreEqual(false, comparers.Equals(lower, upper, null));
        // Patient itself is registered by the sweep, so it does pick up the new comparer.
        Assert.AreEqual(true, comparers.Equals(new Patient { Id = "abc" }, new Patient { Id = "ABC" }, null));
    }

    /// <summary>
    /// Defined in the test assembly, so the model-assembly sweep can never see it directly.
    /// </summary>
    private sealed class DerivedPatient : Patient;
}

using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Cql.Operators;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.9.0")]
[CqlLibrary("AdvancedIllnessandFrailty", "1.16.000")]
public partial class AdvancedIllnessandFrailty_1_16_000 : ILibrary, ISingleton<AdvancedIllnessandFrailty_1_16_000>
{
    private AdvancedIllnessandFrailty_1_16_000() {}

    public static AdvancedIllnessandFrailty_1_16_000 Instance { get; } = new();

    #region Library Members
    string ILibrary.Name => "AdvancedIllnessandFrailty";
    string ILibrary.Version => "1.16.000";
    IReadOnlyList<ILibrary> ILibrary.Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, CumulativeMedicationDuration_4_1_000.Instance, Status_1_8_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Advanced Illness")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082")]
    public CqlValueSet Advanced_Illness(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082", default);



    [CqlDeclaration("Dementia Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510")]
    public CqlValueSet Dementia_Medications(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510", default);



    [CqlDeclaration("Frailty Device")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300")]
    public CqlValueSet Frailty_Device(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300", default);



    [CqlDeclaration("Frailty Diagnosis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074")]
    public CqlValueSet Frailty_Diagnosis(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074", default);



    [CqlDeclaration("Frailty Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088")]
    public CqlValueSet Frailty_Encounter(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088", default);



    [CqlDeclaration("Frailty Symptom")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075")]
    public CqlValueSet Frailty_Symptom(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075", default);



    [CqlDeclaration("Housing status")]
    public CqlCode Housing_status(CqlContext context) =>
        new CqlCode("71802-3", "http://loinc.org", default, default);



    [CqlDeclaration("Lives in a nursing home (finding)")]
    public CqlCode Lives_in_a_nursing_home__finding_(CqlContext context) =>
        new CqlCode("160734000", "http://snomed.info/sct", default, default);



    [CqlDeclaration("Medical equipment used")]
    public CqlCode Medical_equipment_used(CqlContext context) =>
        new CqlCode("98181-1", "http://loinc.org", default, default);



    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("71802-3", "http://loinc.org", default, default),
            new CqlCode("98181-1", "http://loinc.org", default, default),
        ];

        return a_;
    }



    [CqlDeclaration("SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("160734000", "http://snomed.info/sct", default, default),
        ];

        return a_;
    }



    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object a_ = context.ResolveParameter("AdvancedIllnessandFrailty-1.16.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)a_;
    }



    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }



    [CqlDeclaration("Has Criteria Indicating Frailty")]
    public bool? Has_Criteria_Indicating_Frailty(CqlContext context)
    {
        CqlValueSet a_ = this.Frailty_Device(context);
        IEnumerable<DeviceRequest> b_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-devicerequest"));
        IEnumerable<DeviceRequest> d_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-devicerequest"));
        IEnumerable<DeviceRequest> e_ = context.Operators.Union<DeviceRequest>(b_, d_);
        IEnumerable<DeviceRequest> f_ = Status_1_8_000.Instance.isDeviceOrder(context, e_);
        bool? g_(DeviceRequest FrailtyDeviceOrder)
        {
            bool? al_ = QICoreCommon_2_1_000.Instance.doNotPerform(context, FrailtyDeviceOrder);
            bool? am_ = context.Operators.IsTrue(al_);
            bool? an_ = context.Operators.Not(am_);
            CqlInterval<CqlDateTime> ao_ = this.Measurement_Period(context);
            FhirDateTime ap_ = FrailtyDeviceOrder?.AuthoredOnElement;
            CqlDateTime aq_ = context.Operators.Convert<CqlDateTime>(ap_);
            CqlInterval<CqlDateTime> ar_ = QICoreCommon_2_1_000.Instance.toInterval(context, aq_ as object);
            bool? as_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ao_, ar_, "day");
            bool? at_ = context.Operators.And(an_, as_);

            return at_;
        };
        IEnumerable<DeviceRequest> h_ = context.Operators.Where<DeviceRequest>(f_, g_);
        bool? i_ = context.Operators.Exists<DeviceRequest>(h_);
        CqlCode j_ = this.Medical_equipment_used(context);
        IEnumerable<CqlCode> k_ = context.Operators.ToList<CqlCode>(j_);
        IEnumerable<Observation> l_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, k_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> m_ = Status_1_8_000.Instance.isAssessmentPerformed(context, l_);
        bool? n_(Observation EquipmentUsed)
        {
            DataType au_ = EquipmentUsed?.Value;
            object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
            CqlValueSet aw_ = this.Frailty_Device(context);
            bool? ax_ = context.Operators.ConceptInValueSet(av_ as CqlConcept, aw_);
            DataType ay_ = EquipmentUsed?.Effective;
            object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
            CqlInterval<CqlDateTime> ba_ = QICoreCommon_2_1_000.Instance.toInterval(context, az_);
            CqlDateTime bb_ = context.Operators.End(ba_);
            CqlInterval<CqlDateTime> bc_ = this.Measurement_Period(context);
            bool? bd_ = context.Operators.In<CqlDateTime>(bb_, bc_, "day");
            bool? be_ = context.Operators.And(ax_, bd_);

            return be_;
        };
        IEnumerable<Observation> o_ = context.Operators.Where<Observation>(m_, n_);
        bool? p_ = context.Operators.Exists<Observation>(o_);
        bool? q_ = context.Operators.Or(i_, p_);
        CqlValueSet r_ = this.Frailty_Diagnosis(context);
        IEnumerable<Condition> s_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? t_(Condition FrailtyDiagnosis)
        {
            CqlInterval<CqlDateTime> bf_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, FrailtyDiagnosis);
            CqlInterval<CqlDateTime> bg_ = this.Measurement_Period(context);
            bool? bh_ = context.Operators.Overlaps(bf_, bg_, "day");

            return bh_;
        };
        IEnumerable<Condition> u_ = context.Operators.Where<Condition>(s_, t_);
        bool? v_ = context.Operators.Exists<Condition>(u_);
        bool? w_ = context.Operators.Or(q_, v_);
        CqlValueSet x_ = this.Frailty_Encounter(context);
        IEnumerable<Encounter> y_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> z_ = Status_1_8_000.Instance.isEncounterPerformed(context, y_);
        bool? aa_(Encounter FrailtyEncounter)
        {
            Period bi_ = FrailtyEncounter?.Period;
            CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bi_);
            CqlInterval<CqlDateTime> bk_ = QICoreCommon_2_1_000.Instance.toInterval(context, bj_ as object);
            CqlInterval<CqlDateTime> bl_ = this.Measurement_Period(context);
            bool? bm_ = context.Operators.Overlaps(bk_, bl_, "day");

            return bm_;
        };
        IEnumerable<Encounter> ab_ = context.Operators.Where<Encounter>(z_, aa_);
        bool? ac_ = context.Operators.Exists<Encounter>(ab_);
        bool? ad_ = context.Operators.Or(w_, ac_);
        CqlValueSet ae_ = this.Frailty_Symptom(context);
        IEnumerable<Observation> af_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ae_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> ag_ = Status_1_8_000.Instance.isSymptom(context, af_);
        bool? ah_(Observation FrailtySymptom)
        {
            DataType bn_ = FrailtySymptom?.Effective;
            object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
            CqlInterval<CqlDateTime> bp_ = QICoreCommon_2_1_000.Instance.toInterval(context, bo_);
            CqlInterval<CqlDateTime> bq_ = this.Measurement_Period(context);
            bool? br_ = context.Operators.Overlaps(bp_, bq_, "day");

            return br_;
        };
        IEnumerable<Observation> ai_ = context.Operators.Where<Observation>(ag_, ah_);
        bool? aj_ = context.Operators.Exists<Observation>(ai_);
        bool? ak_ = context.Operators.Or(ad_, aj_);

        return ak_;
    }



    [CqlDeclaration("Has Advanced Illness in Year Before or During Measurement Period")]
    public bool? Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet a_ = this.Advanced_Illness(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? c_(Condition AdvancedIllnessDiagnosis)
        {
            CqlInterval<CqlDateTime> f_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, AdvancedIllnessDiagnosis);
            CqlDateTime g_ = context.Operators.Start(f_);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            CqlDateTime i_ = context.Operators.Start(h_);
            CqlQuantity j_ = context.Operators.Quantity(1m, "year");
            CqlDateTime k_ = context.Operators.Subtract(i_, j_);
            CqlDateTime m_ = context.Operators.End(h_);
            CqlInterval<CqlDateTime> n_ = context.Operators.Interval(k_, m_, true, true);
            bool? o_ = context.Operators.In<CqlDateTime>(g_, n_, "day");

            return o_;
        };
        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        bool? e_ = context.Operators.Exists<Condition>(d_);

        return e_;
    }



    [CqlDeclaration("Has Dementia Medications in Year Before or During Measurement Period")]
    public bool? Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet a_ = this.Dementia_Medications(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = Status_1_8_000.Instance.isMedicationActive(context, b_);
        bool? d_(MedicationRequest DementiaMedication)
        {
            CqlInterval<CqlDate> g_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, DementiaMedication);
            CqlDate h_ = g_?.low;
            CqlDateTime i_ = context.Operators.ConvertDateToDateTime(h_);
            CqlDate k_ = g_?.high;
            CqlDateTime l_ = context.Operators.ConvertDateToDateTime(k_);
            bool? n_ = g_?.lowClosed;
            bool? p_ = g_?.highClosed;
            CqlInterval<CqlDateTime> q_ = context.Operators.Interval(i_, l_, n_, p_);
            CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
            CqlDateTime s_ = context.Operators.Start(r_);
            CqlQuantity t_ = context.Operators.Quantity(1m, "year");
            CqlDateTime u_ = context.Operators.Subtract(s_, t_);
            CqlDateTime w_ = context.Operators.End(r_);
            CqlInterval<CqlDateTime> x_ = context.Operators.Interval(u_, w_, true, true);
            bool? y_ = context.Operators.Overlaps(q_, x_, "day");

            return y_;
        };
        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        bool? f_ = context.Operators.Exists<MedicationRequest>(e_);

        return f_;
    }



    [CqlDeclaration("Is Age 66 or Older with Advanced Illness and Frailty")]
    public bool? Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.End(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        bool? i_ = context.Operators.GreaterOrEqual(h_, 66);
        bool? j_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? k_ = context.Operators.And(i_, j_);
        bool? l_ = this.Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period(context);
        bool? m_ = this.Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(context);
        bool? n_ = context.Operators.Or(l_, m_);
        bool? o_ = context.Operators.And(k_, n_);

        return o_;
    }



    [CqlDeclaration("Is Age 66 to 80 with Advanced Illness and Frailty or Is Age 81 or Older with Frailty")]
    public bool? Is_Age_66_to_80_with_Advanced_Illness_and_Frailty_or_Is_Age_81_or_Older_with_Frailty(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.End(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?> i_ = context.Operators.Interval(66, 80, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, default);
        bool? k_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? l_ = context.Operators.And(j_, k_);
        bool? m_ = this.Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period(context);
        bool? n_ = this.Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(context);
        bool? o_ = context.Operators.Or(m_, n_);
        bool? p_ = context.Operators.And(l_, o_);
        Date r_ = a_?.BirthDateElement;
        string s_ = r_?.Value;
        CqlDate t_ = context.Operators.ConvertStringToDate(s_);
        CqlDateTime v_ = context.Operators.End(e_);
        CqlDate w_ = context.Operators.DateFrom(v_);
        int? x_ = context.Operators.CalculateAgeAt(t_, w_, "year");
        bool? y_ = context.Operators.GreaterOrEqual(x_, 81);
        bool? aa_ = context.Operators.And(y_, k_);
        bool? ab_ = context.Operators.Or(p_, aa_);

        return ab_;
    }



    [CqlDeclaration("Is Age 66 or Older Living Long Term in a Nursing Home")]
    public bool? Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.End(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        bool? i_ = context.Operators.GreaterOrEqual(h_, 66);
        CqlCode j_ = this.Housing_status(context);
        IEnumerable<CqlCode> k_ = context.Operators.ToList<CqlCode>(j_);
        IEnumerable<Observation> l_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, k_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> m_ = Status_1_8_000.Instance.isAssessmentPerformed(context, l_);
        bool? n_(Observation HousingStatus)
        {
            DataType y_ = HousingStatus?.Effective;
            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
            CqlInterval<CqlDateTime> aa_ = QICoreCommon_2_1_000.Instance.toInterval(context, z_);
            CqlDateTime ab_ = context.Operators.End(aa_);
            CqlInterval<CqlDateTime> ac_ = this.Measurement_Period(context);
            CqlDateTime ad_ = context.Operators.End(ac_);
            bool? ae_ = context.Operators.SameOrBefore(ab_, ad_, "day");

            return ae_;
        };
        IEnumerable<Observation> o_ = context.Operators.Where<Observation>(m_, n_);
        object p_(Observation @this)
        {
            DataType af_ = @this?.Effective;
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
            CqlInterval<CqlDateTime> ah_ = QICoreCommon_2_1_000.Instance.toInterval(context, ag_);
            CqlDateTime ai_ = context.Operators.End(ah_);

            return ai_;
        };
        IEnumerable<Observation> q_ = context.Operators.SortBy<Observation>(o_, p_, System.ComponentModel.ListSortDirection.Ascending);
        Observation r_ = context.Operators.Last<Observation>(q_);
        Observation[] s_ = [
            r_,
        ];
        bool? t_(Observation LastHousingStatus)
        {
            DataType aj_ = LastHousingStatus?.Value;
            object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
            CqlCode al_ = this.Lives_in_a_nursing_home__finding_(context);
            CqlConcept am_ = context.Operators.ConvertCodeToConcept(al_);
            bool? an_ = context.Operators.Equivalent(ak_ as CqlConcept, am_);

            return an_;
        };
        IEnumerable<Observation> u_ = context.Operators.Where<Observation>((IEnumerable<Observation>)s_, t_);
        Observation v_ = context.Operators.SingletonFrom<Observation>(u_);
        bool? w_ = context.Operators.Not((bool?)(v_ is null));
        bool? x_ = context.Operators.And(i_, w_);

        return x_;
    }


}

﻿using System;
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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.6.0")]
[CqlLibrary("AdvancedIllnessandFrailty", "1.8.000")]
public partial class AdvancedIllnessandFrailty_1_8_000 : ILibrary, ISingleton<AdvancedIllnessandFrailty_1_8_000>
{
    private AdvancedIllnessandFrailty_1_8_000() {}

    public static AdvancedIllnessandFrailty_1_8_000 Instance { get; } = new();

    #region Library Members
    public string Name => "AdvancedIllnessandFrailty";
    public string Version => "1.8.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_3_000.Instance, QICoreCommon_2_0_000.Instance, CQMCommon_2_0_000.Instance, CumulativeMedicationDuration_4_0_000.Instance, Status_1_6_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Acute Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083")]
    public CqlValueSet Acute_Inpatient(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083", default);


    [CqlDeclaration("Advanced Illness")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082")]
    public CqlValueSet Advanced_Illness(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082", default);


    [CqlDeclaration("Dementia Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510")]
    public CqlValueSet Dementia_Medications(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510", default);


    [CqlDeclaration("Emergency Department Evaluation and Management Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010")]
    public CqlValueSet Emergency_Department_Evaluation_and_Management_Visit(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", default);


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


    [CqlDeclaration("Nonacute Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084")]
    public CqlValueSet Nonacute_Inpatient(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084", default);


    [CqlDeclaration("Observation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086")]
    public CqlValueSet Observation(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086", default);


    [CqlDeclaration("Outpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087")]
    public CqlValueSet Outpatient(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087", default);


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
        object a_ = context.ResolveParameter("AdvancedIllnessandFrailty-1.8.000", "Measurement Period", null);

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
        IEnumerable<DeviceRequest> f_ = Status_1_6_000.Instance.isDeviceOrder(context, e_);
        bool? g_(DeviceRequest FrailtyDeviceOrder)
        {
            bool? al_ = QICoreCommon_2_0_000.Instance.doNotPerform(context, FrailtyDeviceOrder);
            bool? am_ = context.Operators.IsTrue(al_);
            bool? an_ = context.Operators.Not(am_);
            CqlInterval<CqlDateTime> ao_ = this.Measurement_Period(context);
            FhirDateTime ap_ = FrailtyDeviceOrder?.AuthoredOnElement;
            CqlDateTime aq_ = context.Operators.Convert<CqlDateTime>(ap_);
            CqlInterval<CqlDateTime> ar_ = QICoreCommon_2_0_000.Instance.toInterval(context, aq_ as object);
            bool? as_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ao_, ar_, "day");
            bool? at_ = context.Operators.And(an_, as_);

            return at_;
        };
        IEnumerable<DeviceRequest> h_ = context.Operators.Where<DeviceRequest>(f_, g_);
        bool? i_ = context.Operators.Exists<DeviceRequest>(h_);
        CqlCode j_ = this.Medical_equipment_used(context);
        IEnumerable<CqlCode> k_ = context.Operators.ToList<CqlCode>(j_);
        IEnumerable<Observation> l_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, k_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> m_ = Status_1_6_000.Instance.isAssessmentPerformed(context, l_);
        bool? n_(Observation EquipmentUsed)
        {
            DataType au_ = EquipmentUsed?.Value;
            object av_ = FHIRHelpers_4_3_000.Instance.ToValue(context, au_);
            CqlValueSet aw_ = this.Frailty_Device(context);
            bool? ax_ = context.Operators.ConceptInValueSet(av_ as CqlConcept, aw_);
            DataType ay_ = EquipmentUsed?.Effective;
            object az_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ay_);
            CqlInterval<CqlDateTime> ba_ = QICoreCommon_2_0_000.Instance.toInterval(context, az_);
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
            CqlInterval<CqlDateTime> bf_ = QICoreCommon_2_0_000.Instance.prevalenceInterval(context, FrailtyDiagnosis);
            CqlInterval<CqlDateTime> bg_ = this.Measurement_Period(context);
            bool? bh_ = context.Operators.Overlaps(bf_, bg_, "day");

            return bh_;
        };
        IEnumerable<Condition> u_ = context.Operators.Where<Condition>(s_, t_);
        bool? v_ = context.Operators.Exists<Condition>(u_);
        bool? w_ = context.Operators.Or(q_, v_);
        CqlValueSet x_ = this.Frailty_Encounter(context);
        IEnumerable<Encounter> y_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> z_ = Status_1_6_000.Instance.isEncounterPerformed(context, y_);
        bool? aa_(Encounter FrailtyEncounter)
        {
            Period bi_ = FrailtyEncounter?.Period;
            CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, bi_);
            CqlInterval<CqlDateTime> bk_ = QICoreCommon_2_0_000.Instance.toInterval(context, bj_ as object);
            CqlInterval<CqlDateTime> bl_ = this.Measurement_Period(context);
            bool? bm_ = context.Operators.Overlaps(bk_, bl_, "day");

            return bm_;
        };
        IEnumerable<Encounter> ab_ = context.Operators.Where<Encounter>(z_, aa_);
        bool? ac_ = context.Operators.Exists<Encounter>(ab_);
        bool? ad_ = context.Operators.Or(w_, ac_);
        CqlValueSet ae_ = this.Frailty_Symptom(context);
        IEnumerable<Observation> af_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ae_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> ag_ = Status_1_6_000.Instance.isSymptom(context, af_);
        bool? ah_(Observation FrailtySymptom)
        {
            DataType bn_ = FrailtySymptom?.Effective;
            object bo_ = FHIRHelpers_4_3_000.Instance.ToValue(context, bn_);
            CqlInterval<CqlDateTime> bp_ = QICoreCommon_2_0_000.Instance.toInterval(context, bo_);
            CqlInterval<CqlDateTime> bq_ = this.Measurement_Period(context);
            bool? br_ = context.Operators.Overlaps(bp_, bq_, "day");

            return br_;
        };
        IEnumerable<Observation> ai_ = context.Operators.Where<Observation>(ag_, ah_);
        bool? aj_ = context.Operators.Exists<Observation>(ai_);
        bool? ak_ = context.Operators.Or(ad_, aj_);

        return ak_;
    }


    [CqlDeclaration("Outpatient Encounters with Advanced Illness")]
    public IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness(CqlContext context)
    {
        CqlValueSet a_ = this.Outpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Observation(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Emergency_Department_Evaluation_and_Management_Visit(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet h_ = this.Nonacute_Inpatient(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
        IEnumerable<Encounter> l_ = Status_1_6_000.Instance.isEncounterPerformed(context, k_);
        bool? m_(Encounter OutpatientEncounter)
        {
            IEnumerable<Condition> o_ = CQMCommon_2_0_000.Instance.encounterDiagnosis(context, OutpatientEncounter);
            bool? p_(Condition Diagnosis)
            {
                CodeableConcept af_ = Diagnosis?.Code;
                CqlConcept ag_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, af_);
                CqlValueSet ah_ = this.Advanced_Illness(context);
                bool? ai_ = context.Operators.ConceptInValueSet(ag_, ah_);

                return ai_;
            };
            IEnumerable<Condition> q_ = context.Operators.Where<Condition>(o_, p_);
            bool? r_ = context.Operators.Exists<Condition>(q_);
            Period s_ = OutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, s_);
            CqlInterval<CqlDateTime> u_ = QICoreCommon_2_0_000.Instance.toInterval(context, t_ as object);
            CqlDateTime v_ = context.Operators.Start(u_);
            CqlInterval<CqlDateTime> w_ = this.Measurement_Period(context);
            CqlDateTime x_ = context.Operators.Start(w_);
            CqlQuantity y_ = context.Operators.Quantity(1m, "year");
            CqlDateTime z_ = context.Operators.Subtract(x_, y_);
            CqlDateTime ab_ = context.Operators.End(w_);
            CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(z_, ab_, true, true);
            bool? ad_ = context.Operators.In<CqlDateTime>(v_, ac_, "day");
            bool? ae_ = context.Operators.And(r_, ad_);

            return ae_;
        };
        IEnumerable<Encounter> n_ = context.Operators.Where<Encounter>(l_, m_);

        return n_;
    }


    [CqlDeclaration("Has Two Outpatient Encounters with Advanced Illness on Different Dates of Service")]
    public bool? Has_Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Outpatient_Encounters_with_Advanced_Illness(context);
        IEnumerable<ValueTuple<Encounter, Encounter>> c_ = context.Operators.CrossJoin<Encounter, Encounter>(a_, a_);
        (CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? d_(ValueTuple<Encounter, Encounter> _valueTuple)
        {
            (CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? k_ = (CqlTupleMetadata_EaLaedgLDgRRYaLbKIIcBTOiA, _valueTuple.Item1, _valueTuple.Item2);

            return k_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?> e_ = context.Operators.Select<ValueTuple<Encounter, Encounter>, (CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?>(c_, d_);
        bool? f_((CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? tuple_ealaedgldgrryalbkiicbtoia)
        {
            Period l_ = tuple_ealaedgldgrryalbkiicbtoia?.OutpatientEncounter2?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, l_);
            CqlDateTime n_ = context.Operators.End(m_);
            Period o_ = tuple_ealaedgldgrryalbkiicbtoia?.OutpatientEncounter1?.Period;
            CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, o_);
            CqlDateTime q_ = context.Operators.End(p_);
            CqlQuantity r_ = context.Operators.Quantity(1m, "day");
            CqlDateTime s_ = context.Operators.Add(q_, r_);
            bool? t_ = context.Operators.SameOrAfter(n_, s_, "day");

            return t_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?> g_ = context.Operators.Where<(CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?>(e_, f_);
        Encounter h_((CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? tuple_ealaedgldgrryalbkiicbtoia) => 
            tuple_ealaedgldgrryalbkiicbtoia?.OutpatientEncounter1;
        IEnumerable<Encounter> i_ = context.Operators.Select<(CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?, Encounter>(g_, h_);
        bool? j_ = context.Operators.Exists<Encounter>(i_);

        return j_;
    }


    [CqlDeclaration("Has Inpatient Encounter with Advanced Illness")]
    public bool? Has_Inpatient_Encounter_with_Advanced_Illness(CqlContext context)
    {
        CqlValueSet a_ = this.Acute_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> c_ = Status_1_6_000.Instance.isEncounterPerformed(context, b_);
        bool? d_(Encounter InpatientEncounter)
        {
            IEnumerable<Condition> g_ = CQMCommon_2_0_000.Instance.encounterDiagnosis(context, InpatientEncounter);
            bool? h_(Condition Diagnosis)
            {
                CodeableConcept x_ = Diagnosis?.Code;
                CqlConcept y_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, x_);
                CqlValueSet z_ = this.Advanced_Illness(context);
                bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);

                return aa_;
            };
            IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);
            bool? j_ = context.Operators.Exists<Condition>(i_);
            Period k_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, k_);
            CqlInterval<CqlDateTime> m_ = QICoreCommon_2_0_000.Instance.toInterval(context, l_ as object);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlInterval<CqlDateTime> o_ = this.Measurement_Period(context);
            CqlDateTime p_ = context.Operators.Start(o_);
            CqlQuantity q_ = context.Operators.Quantity(1m, "year");
            CqlDateTime r_ = context.Operators.Subtract(p_, q_);
            CqlDateTime t_ = context.Operators.End(o_);
            CqlInterval<CqlDateTime> u_ = context.Operators.Interval(r_, t_, true, true);
            bool? v_ = context.Operators.In<CqlDateTime>(n_, u_, "day");
            bool? w_ = context.Operators.And(j_, v_);

            return w_;
        };
        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);
        bool? f_ = context.Operators.Exists<Encounter>(e_);

        return f_;
    }


    [CqlDeclaration("Has Dementia Medications in Year Before or During Measurement Period")]
    public bool? Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet a_ = this.Dementia_Medications(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
        IEnumerable<MedicationRequest> f_ = Status_1_6_000.Instance.isMedicationActive(context, e_);
        bool? g_(MedicationRequest DementiaMedication)
        {
            FhirBoolean j_ = DementiaMedication?.DoNotPerformElement;
            bool? k_ = j_?.Value;
            bool? l_ = context.Operators.IsTrue(k_);
            bool? m_ = context.Operators.Not(l_);
            CqlInterval<CqlDate> n_ = CumulativeMedicationDuration_4_0_000.Instance.MedicationRequestPeriod(context, DementiaMedication);
            CqlDate o_ = n_?.low;
            CqlDateTime p_ = context.Operators.ConvertDateToDateTime(o_);
            CqlDate r_ = n_?.high;
            CqlDateTime s_ = context.Operators.ConvertDateToDateTime(r_);
            bool? u_ = n_?.lowClosed;
            bool? w_ = n_?.highClosed;
            CqlInterval<CqlDateTime> x_ = context.Operators.Interval(p_, s_, u_, w_);
            CqlInterval<CqlDateTime> y_ = this.Measurement_Period(context);
            CqlDateTime z_ = context.Operators.Start(y_);
            CqlQuantity aa_ = context.Operators.Quantity(1m, "year");
            CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
            CqlDateTime ad_ = context.Operators.End(y_);
            CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(ab_, ad_, true, true);
            bool? af_ = context.Operators.Overlaps(x_, ae_, "day");
            bool? ag_ = context.Operators.And(m_, af_);

            return ag_;
        };
        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
        bool? i_ = context.Operators.Exists<MedicationRequest>(h_);

        return i_;
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
        bool? l_ = this.Has_Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service(context);
        bool? m_ = this.Has_Inpatient_Encounter_with_Advanced_Illness(context);
        bool? n_ = context.Operators.Or(l_, m_);
        bool? o_ = this.Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(context);
        bool? p_ = context.Operators.Or(n_, o_);
        bool? q_ = context.Operators.And(k_, p_);

        return q_;
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
        bool? m_ = this.Has_Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service(context);
        bool? n_ = this.Has_Inpatient_Encounter_with_Advanced_Illness(context);
        bool? o_ = context.Operators.Or(m_, n_);
        bool? p_ = this.Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(context);
        bool? q_ = context.Operators.Or(o_, p_);
        bool? r_ = context.Operators.And(l_, q_);
        Date t_ = a_?.BirthDateElement;
        string u_ = t_?.Value;
        CqlDate v_ = context.Operators.ConvertStringToDate(u_);
        CqlDateTime x_ = context.Operators.End(e_);
        CqlDate y_ = context.Operators.DateFrom(x_);
        int? z_ = context.Operators.CalculateAgeAt(v_, y_, "year");
        bool? aa_ = context.Operators.GreaterOrEqual(z_, 81);
        bool? ac_ = context.Operators.And(aa_, k_);
        bool? ad_ = context.Operators.Or(r_, ac_);

        return ad_;
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
        IEnumerable<Observation> m_ = Status_1_6_000.Instance.isAssessmentPerformed(context, l_);
        bool? n_(Observation HousingStatus)
        {
            DataType y_ = HousingStatus?.Effective;
            object z_ = FHIRHelpers_4_3_000.Instance.ToValue(context, y_);
            CqlInterval<CqlDateTime> aa_ = QICoreCommon_2_0_000.Instance.toInterval(context, z_);
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
            object ag_ = FHIRHelpers_4_3_000.Instance.ToValue(context, af_);
            CqlInterval<CqlDateTime> ah_ = QICoreCommon_2_0_000.Instance.toInterval(context, ag_);
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
            object ak_ = FHIRHelpers_4_3_000.Instance.ToValue(context, aj_);
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

    private static CqlTupleMetadata CqlTupleMetadata_EaLaedgLDgRRYaLbKIIcBTOiA = new(
        [typeof(Encounter), typeof(Encounter)],
        ["OutpatientEncounter1", "OutpatientEncounter2"]);

}

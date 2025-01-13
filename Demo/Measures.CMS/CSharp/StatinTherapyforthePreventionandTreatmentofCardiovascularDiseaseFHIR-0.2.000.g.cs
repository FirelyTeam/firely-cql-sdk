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
[CqlLibrary("StatinTherapyforthePreventionandTreatmentofCardiovascularDiseaseFHIR", "0.2.000")]
public partial class StatinTherapyforthePreventionandTreatmentofCardiovascularDiseaseFHIR_0_2_000 : ILibrary, ISingleton<StatinTherapyforthePreventionandTreatmentofCardiovascularDiseaseFHIR_0_2_000>
{
    private StatinTherapyforthePreventionandTreatmentofCardiovascularDiseaseFHIR_0_2_000() {}

    public static StatinTherapyforthePreventionandTreatmentofCardiovascularDiseaseFHIR_0_2_000 Instance { get; } = new();

    #region ILibrary Implementation

    string ILibrary.Name => "StatinTherapyforthePreventionandTreatmentofCardiovascularDiseaseFHIR";
    string ILibrary.Version => "0.2.000";
    IReadOnlyList<ILibrary> ILibrary.Dependencies => [FHIRHelpers_4_4_000.Instance, Hospice_6_12_000.Instance, PalliativeCare_1_11_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance];

    #endregion ILibrary Implementation

    #region Definition Methods

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
    public CqlValueSet Annual_Wellness_Visit(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", default);


    [CqlDeclaration("Atherosclerosis and Peripheral Arterial Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.21")]
    public CqlValueSet Atherosclerosis_and_Peripheral_Arterial_Disease(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.21", default);


    [CqlDeclaration("Breastfeeding")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.73")]
    public CqlValueSet Breastfeeding(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.73", default);


    [CqlDeclaration("CABG Surgeries")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.694")]
    public CqlValueSet CABG_Surgeries(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.694", default);


    [CqlDeclaration("CABG or PCI Procedure")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1138.566")]
    public CqlValueSet CABG_or_PCI_Procedure(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1138.566", default);


    [CqlDeclaration("Carotid Intervention")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.204")]
    public CqlValueSet Carotid_Intervention(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.204", default);


    [CqlDeclaration("Cerebrovascular Disease Stroke or TIA")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.44")]
    public CqlValueSet Cerebrovascular_Disease_Stroke_or_TIA(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.44", default);


    [CqlDeclaration("Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001")]
    public CqlValueSet Diabetes(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", default);


    [CqlDeclaration("End Stage Renal Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353")]
    public CqlValueSet End_Stage_Renal_Disease(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353", default);


    [CqlDeclaration("Familial Hypercholesterolemia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.100")]
    public CqlValueSet Familial_Hypercholesterolemia(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.100", default);


    [CqlDeclaration("Hepatitis A")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024")]
    public CqlValueSet Hepatitis_A(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024", default);


    [CqlDeclaration("Hepatitis B")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.269")]
    public CqlValueSet Hepatitis_B(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.269", default);


    [CqlDeclaration("High Intensity Statin Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1572")]
    public CqlValueSet High_Intensity_Statin_Therapy(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1572", default);


    [CqlDeclaration("Ischemic Heart Disease or Other Related Diagnoses")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.46")]
    public CqlValueSet Ischemic_Heart_Disease_or_Other_Related_Diagnoses(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.46", default);


    [CqlDeclaration("LDL Cholesterol")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1573")]
    public CqlValueSet LDL_Cholesterol(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1573", default);


    [CqlDeclaration("Liver Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.42")]
    public CqlValueSet Liver_Disease(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.42", default);


    [CqlDeclaration("Low Intensity Statin Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1574")]
    public CqlValueSet Low_Intensity_Statin_Therapy(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1574", default);


    [CqlDeclaration("Medical Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007")]
    public CqlValueSet Medical_Reason(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", default);


    [CqlDeclaration("Moderate Intensity Statin Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1575")]
    public CqlValueSet Moderate_Intensity_Statin_Therapy(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1575", default);


    [CqlDeclaration("Myocardial Infarction")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.403")]
    public CqlValueSet Myocardial_Infarction(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.403", default);


    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
    public CqlValueSet Office_Visit(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);


    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
    public CqlValueSet Outpatient_Consultation(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", default);


    [CqlDeclaration("Outpatient Encounters for Preventive Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1576")]
    public CqlValueSet Outpatient_Encounters_for_Preventive_Care(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1576", default);


    [CqlDeclaration("PCI")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.67")]
    public CqlValueSet PCI(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.67", default);


    [CqlDeclaration("Preventive Care Services Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", default);


    [CqlDeclaration("Preventive Care Services Individual Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026")]
    public CqlValueSet Preventive_Care_Services_Individual_Counseling(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", default);


    [CqlDeclaration("Preventive Care Services Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", default);


    [CqlDeclaration("Preventive Care Services Other")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1150")]
    public CqlValueSet Preventive_Care_Services_Other(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1150", default);


    [CqlDeclaration("Rhabdomyolysis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.102")]
    public CqlValueSet Rhabdomyolysis(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.102", default);


    [CqlDeclaration("Stable and Unstable Angina")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.47")]
    public CqlValueSet Stable_and_Unstable_Angina(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.47", default);


    [CqlDeclaration("Statin Allergen")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.42")]
    public CqlValueSet Statin_Allergen(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.42", default);


    [CqlDeclaration("Statin Associated Muscle Symptoms")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.85")]
    public CqlValueSet Statin_Associated_Muscle_Symptoms(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.85", default);


    [CqlDeclaration("Cardiovascular disease 10Y risk [Likelihood]")]
    public CqlCode Cardiovascular_disease_10Y_risk__Likelihood_(CqlContext context) =>
        new CqlCode("99055-6", "http://loinc.org", default, default);


    [CqlDeclaration("Cardiovascular disease 10Y risk [Likelihood] ACC-AHA Pooled Cohort by Goff 2013")]
    public CqlCode Cardiovascular_disease_10Y_risk__Likelihood__ACC_AHA_Pooled_Cohort_by_Goff_2013(CqlContext context) =>
        new CqlCode("79423-0", "http://loinc.org", default, default);


    [CqlDeclaration("Subsequent non-ST elevation (NSTEMI) myocardial infarction")]
    public CqlCode Subsequent_non_ST_elevation__NSTEMI__myocardial_infarction(CqlContext context) =>
        new CqlCode("I22.2", "http://hl7.org/fhir/sid/icd-10-cm", default, default);


    [CqlDeclaration("CPT")]
    public CqlCode[] CPT(CqlContext context)
    {
        CqlCode[] a_ = []
;

        return a_;
    }


    [CqlDeclaration("ICD10CM")]
    public CqlCode[] ICD10CM(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("I22.2", "http://hl7.org/fhir/sid/icd-10-cm", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("99055-6", "http://loinc.org", default, default),
            new CqlCode("79423-0", "http://loinc.org", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("ObservationCategoryCodes")]
    public CqlCode[] ObservationCategoryCodes(CqlContext context)
    {
        CqlCode[] a_ = []
;

        return a_;
    }


    [CqlDeclaration("RxNorm")]
    public CqlCode[] RxNorm(CqlContext context)
    {
        CqlCode[] a_ = []
;

        return a_;
    }


    [CqlDeclaration("SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] a_ = []
;

        return a_;
    }


    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("StatinTherapyforthePreventionandTreatmentofCardiovascularDiseaseFHIR-0.2.000", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlDeclaration("ASVCD Diagnosis or Procedure before End of Measurement Period")]
    public IEnumerable<object> ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet a_ = this.Myocardial_Infarction(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet c_ = this.Cerebrovascular_Disease_Stroke_or_TIA(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
        CqlValueSet f_ = this.Atherosclerosis_and_Peripheral_Arterial_Disease(context);
        IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet h_ = this.Ischemic_Heart_Disease_or_Other_Related_Diagnoses(context);
        IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> j_ = context.Operators.Union<Condition>(g_, i_);
        IEnumerable<Condition> k_ = context.Operators.Union<Condition>(e_, j_);
        CqlValueSet l_ = this.Stable_and_Unstable_Angina(context);
        IEnumerable<Condition> m_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> n_ = context.Operators.Union<Condition>(k_, m_);
        bool? o_(Condition ASCVDDiagnosis)
        {
            bool? ae_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, ASCVDDiagnosis);
            bool? af_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, ASCVDDiagnosis);
            bool? ag_ = context.Operators.Or(ae_, af_);
            CqlInterval<CqlDateTime> ah_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ASCVDDiagnosis);
            CqlDateTime ai_ = context.Operators.Start(ah_);
            CqlInterval<CqlDateTime> aj_ = this.Measurement_Period(context);
            CqlDateTime ak_ = context.Operators.End(aj_);
            bool? al_ = context.Operators.SameOrBefore(ai_, ak_, "day");
            bool? am_ = context.Operators.And(ag_, al_);

            return am_;
        };
        IEnumerable<Condition> p_ = context.Operators.Where<Condition>(n_, o_);
        CqlValueSet q_ = this.PCI(context);
        IEnumerable<Procedure> r_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, q_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet s_ = this.CABG_Surgeries(context);
        IEnumerable<Procedure> t_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> u_ = context.Operators.Union<Procedure>(r_, t_);
        CqlValueSet v_ = this.Carotid_Intervention(context);
        IEnumerable<Procedure> w_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet x_ = this.CABG_or_PCI_Procedure(context);
        IEnumerable<Procedure> y_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> z_ = context.Operators.Union<Procedure>(w_, y_);
        IEnumerable<Procedure> aa_ = context.Operators.Union<Procedure>(u_, z_);
        bool? ab_(Procedure ASCVDProcedure)
        {
            DataType an_ = ASCVDProcedure?.Performed;
            object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
            CqlInterval<CqlDateTime> ap_ = QICoreCommon_2_1_000.Instance.toInterval(context, ao_);
            CqlDateTime aq_ = context.Operators.Start(ap_);
            CqlInterval<CqlDateTime> ar_ = this.Measurement_Period(context);
            CqlDateTime as_ = context.Operators.End(ar_);
            bool? at_ = context.Operators.SameOrBefore(aq_, as_, "day");
            Code<EventStatus> au_ = ASCVDProcedure?.StatusElement;
            EventStatus? av_ = au_?.Value;
            string aw_ = context.Operators.Convert<string>(av_);
            bool? ax_ = context.Operators.Equal(aw_, "completed");
            bool? ay_ = context.Operators.And(at_, ax_);

            return ay_;
        };
        IEnumerable<Procedure> ac_ = context.Operators.Where<Procedure>(aa_, ab_);
        IEnumerable<object> ad_ = context.Operators.Union<object>(p_ as IEnumerable<object>, ac_ as IEnumerable<object>);

        return ad_;
    }


    [CqlDeclaration("Myocardial Infarction before End of Measurement Period")]
    public IEnumerable<Condition> Myocardial_Infarction_before_End_of_Measurement_Period(CqlContext context)
    {
        CqlCode a_ = this.Subsequent_non_ST_elevation__NSTEMI__myocardial_infarction(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? d_(Condition SubsequentMI)
        {
            bool? f_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, SubsequentMI);
            bool? g_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, SubsequentMI);
            bool? h_ = context.Operators.Or(f_, g_);
            CqlInterval<CqlDateTime> i_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SubsequentMI);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
            CqlDateTime l_ = context.Operators.End(k_);
            bool? m_ = context.Operators.SameOrBefore(j_, l_, "day");
            bool? n_ = context.Operators.And(h_, m_);

            return n_;
        };
        IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);

        return e_;
    }


    [CqlDeclaration("Qualifying Encounter during day of Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_day_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet a_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Office_Visit(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet h_ = this.Outpatient_Encounters_for_Preventive_Care(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
        CqlValueSet l_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet n_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
        IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
        CqlValueSet r_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet t_ = this.Preventive_Care_Services_Other(context);
        IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
        IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);
        bool? x_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> z_ = this.Measurement_Period(context);
            Period aa_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aa_);
            bool? ac_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(z_, ab_, "day");
            Code<Encounter.EncounterStatus> ad_ = QualifyingEncounter?.StatusElement;
            Encounter.EncounterStatus? ae_ = ad_?.Value;
            Code<Encounter.EncounterStatus> af_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ae_);
            bool? ag_ = context.Operators.Equal(af_, "finished");
            bool? ah_ = context.Operators.And(ac_, ag_);

            return ah_;
        };
        IEnumerable<Encounter> y_ = context.Operators.Where<Encounter>(w_, x_);

        return y_;
    }


    [CqlDeclaration("Initial Population 1")]
    public bool? Initial_Population_1(CqlContext context)
    {
        IEnumerable<object> a_ = this.ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        IEnumerable<Condition> b_ = this.Myocardial_Infarction_before_End_of_Measurement_Period(context);
        IEnumerable<object> c_ = context.Operators.Union<object>(a_ as IEnumerable<object>, b_ as IEnumerable<object>);
        bool? d_ = context.Operators.Exists<object>(c_);
        IEnumerable<Encounter> e_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        bool? f_ = context.Operators.Exists<Encounter>(e_);
        bool? g_ = context.Operators.And(d_, f_);

        return g_;
    }


    [CqlDeclaration("Patients Aged 20 to 75 at Start of Measurement Period")]
    public bool? Patients_Aged_20_to_75_at_Start_of_Measurement_Period(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?> i_ = context.Operators.Interval(20, 75, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, default);

        return j_;
    }


    [CqlDeclaration("LDL Result Greater Than or Equal To 190")]
    public IEnumerable<Observation> LDL_Result_Greater_Than_or_Equal_To_190(CqlContext context)
    {
        CqlValueSet a_ = this.LDL_Cholesterol(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? c_(Observation LDL190)
        {
            DataType e_ = LDL190?.Value;
            object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            CqlQuantity g_ = context.Operators.Quantity(190m, "mg/dL");
            bool? h_ = context.Operators.GreaterOrEqual(f_ as CqlQuantity, g_);
            DataType i_ = LDL190?.Effective;
            object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
            CqlInterval<CqlDateTime> k_ = QICoreCommon_2_1_000.Instance.toInterval(context, j_);
            CqlDateTime l_ = context.Operators.Start(k_);
            CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
            CqlDateTime n_ = context.Operators.End(m_);
            bool? o_ = context.Operators.SameOrBefore(l_, n_, "day");
            bool? p_ = context.Operators.And(h_, o_);
            Code<ObservationStatus> q_ = LDL190?.StatusElement;
            ObservationStatus? r_ = q_?.Value;
            Code<ObservationStatus> s_ = context.Operators.Convert<Code<ObservationStatus>>(r_);
            string t_ = context.Operators.Convert<string>(s_);
            string[] u_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? v_ = context.Operators.In<string>(t_, u_ as IEnumerable<string>);
            bool? w_ = context.Operators.And(p_, v_);

            return w_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        return d_;
    }


    [CqlDeclaration("Hypercholesterolemia Diagnosis")]
    public IEnumerable<Condition> Hypercholesterolemia_Diagnosis(CqlContext context)
    {
        CqlValueSet a_ = this.Familial_Hypercholesterolemia(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? c_(Condition Hypercholesterolemia)
        {
            bool? e_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, Hypercholesterolemia);
            bool? f_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, Hypercholesterolemia);
            bool? g_ = context.Operators.Or(e_, f_);
            CqlInterval<CqlDateTime> h_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Hypercholesterolemia);
            CqlDateTime i_ = context.Operators.Start(h_);
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            CqlDateTime k_ = context.Operators.End(j_);
            bool? l_ = context.Operators.SameOrBefore(i_, k_, "day");
            bool? m_ = context.Operators.And(g_, l_);

            return m_;
        };
        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);

        return d_;
    }


    [CqlDeclaration("Patients Aged 20 to 75 with LDL Cholesterol Result Greater than or Equal to 190 or Hypercholesterolemia without ASCVD")]
    public bool? Patients_Aged_20_to_75_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(CqlContext context)
    {
        bool? a_ = this.Patients_Aged_20_to_75_at_Start_of_Measurement_Period(context);
        IEnumerable<Observation> b_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
        IEnumerable<Condition> c_ = this.Hypercholesterolemia_Diagnosis(context);
        IEnumerable<object> d_ = context.Operators.Union<object>(b_ as IEnumerable<object>, c_ as IEnumerable<object>);
        bool? e_ = context.Operators.Exists<object>(d_);
        bool? f_ = context.Operators.And(a_, e_);
        IEnumerable<object> g_ = this.ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? h_ = context.Operators.Exists<object>(g_);
        bool? i_ = context.Operators.Not(h_);
        bool? j_ = context.Operators.And(f_, i_);

        return j_;
    }


    [CqlDeclaration("Initial Population 2")]
    public bool? Initial_Population_2(CqlContext context)
    {
        bool? a_ = this.Patients_Aged_20_to_75_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(context);
        IEnumerable<Encounter> b_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        bool? c_ = context.Operators.Exists<Encounter>(b_);
        bool? d_ = context.Operators.And(a_, c_);

        return d_;
    }


    [CqlDeclaration("Has Diabetes Diagnosis")]
    public bool? Has_Diabetes_Diagnosis(CqlContext context)
    {
        CqlValueSet a_ = this.Diabetes(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? c_(Condition Diabetes)
        {
            bool? f_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, Diabetes);
            bool? g_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, Diabetes);
            bool? h_ = context.Operators.Or(f_, g_);
            CqlInterval<CqlDateTime> i_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Diabetes);
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            bool? k_ = context.Operators.Overlaps(i_, j_, "day");
            bool? l_ = context.Operators.And(h_, k_);

            return l_;
        };
        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        bool? e_ = context.Operators.Exists<Condition>(d_);

        return e_;
    }


    [CqlDeclaration("Patients Aged 40 to 75 Years with Diabetes without ASCVD or LDL Greater than 190 or Hypercholesterolemia")]
    public bool? Patients_Aged_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        bool? i_ = context.Operators.GreaterOrEqual(h_, 40);
        Date k_ = a_?.BirthDateElement;
        string l_ = k_?.Value;
        CqlDate m_ = context.Operators.ConvertStringToDate(l_);
        CqlDateTime o_ = context.Operators.Start(e_);
        CqlDate p_ = context.Operators.DateFrom(o_);
        int? q_ = context.Operators.CalculateAgeAt(m_, p_, "year");
        bool? r_ = context.Operators.LessOrEqual(q_, 75);
        bool? s_ = context.Operators.And(i_, r_);
        bool? t_ = this.Has_Diabetes_Diagnosis(context);
        bool? u_ = context.Operators.And(s_, t_);
        IEnumerable<object> v_ = this.ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? w_ = context.Operators.Exists<object>(v_);
        bool? x_ = context.Operators.Not(w_);
        IEnumerable<Observation> y_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
        bool? z_ = context.Operators.Exists<Observation>(y_);
        bool? aa_ = context.Operators.Not(z_);
        bool? ab_ = context.Operators.And(x_, aa_);
        IEnumerable<Condition> ac_ = this.Hypercholesterolemia_Diagnosis(context);
        bool? ad_ = context.Operators.Exists<Condition>(ac_);
        bool? ae_ = context.Operators.Not(ad_);
        bool? af_ = context.Operators.And(ab_, ae_);
        bool? ag_ = context.Operators.And(u_, af_);

        return ag_;
    }


    [CqlDeclaration("Initial Population 3")]
    public bool? Initial_Population_3(CqlContext context)
    {
        bool? a_ = this.Patients_Aged_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(context);
        IEnumerable<Encounter> b_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        bool? c_ = context.Operators.Exists<Encounter>(b_);
        bool? d_ = context.Operators.And(a_, c_);

        return d_;
    }


    [CqlDeclaration("Ten Year CVD Risk is High")]
    public bool? Ten_Year_CVD_Risk_is_High(CqlContext context)
    {
        CqlCode a_ = this.Cardiovascular_disease_10Y_risk__Likelihood_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        CqlCode d_ = this.Cardiovascular_disease_10Y_risk__Likelihood__ACC_AHA_Pooled_Cohort_by_Goff_2013(context);
        IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
        IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> g_ = context.Operators.Union<Observation>(c_, f_);
        bool? h_(Observation AtRiskCVD)
        {
            DataType k_ = AtRiskCVD?.Value;
            object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
            CqlQuantity m_ = context.Operators.Quantity(20m, "%");
            bool? n_ = context.Operators.GreaterOrEqual(l_ as CqlQuantity, m_);
            CqlInterval<CqlDateTime> o_ = this.Measurement_Period(context);
            DataType p_ = AtRiskCVD?.Effective;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlInterval<CqlDateTime> r_ = QICoreCommon_2_1_000.Instance.toInterval(context, q_);
            bool? s_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, r_, "day");
            bool? t_ = context.Operators.And(n_, s_);

            return t_;
        };
        IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
        bool? j_ = context.Operators.Exists<Observation>(i_);

        return j_;
    }


    [CqlDeclaration("Patients Age 40 to 75 Years and have a 10 Year CVD Risk of High without ASCVD and High LDL and Diabetes")]
    public bool? Patients_Age_40_to_75_Years_and_have_a_10_Year_CVD_Risk_of_High_without_ASCVD_and_High_LDL_and_Diabetes(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?> i_ = context.Operators.Interval(40, 75, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, default);
        bool? k_ = this.Ten_Year_CVD_Risk_is_High(context);
        bool? l_ = context.Operators.And(j_, k_);
        IEnumerable<object> m_ = this.ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? n_ = context.Operators.Exists<object>(m_);
        IEnumerable<Condition> o_ = this.Hypercholesterolemia_Diagnosis(context);
        bool? p_ = context.Operators.Exists<Condition>(o_);
        bool? q_ = context.Operators.Or(n_, p_);
        IEnumerable<Observation> r_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
        bool? s_ = context.Operators.Exists<Observation>(r_);
        bool? t_ = context.Operators.Or(q_, s_);
        bool? u_ = this.Has_Diabetes_Diagnosis(context);
        bool? v_ = context.Operators.Or(t_, u_);
        bool? w_ = context.Operators.Not(v_);
        bool? x_ = context.Operators.And(l_, w_);

        return x_;
    }


    [CqlDeclaration("Initial Population 4")]
    public bool? Initial_Population_4(CqlContext context)
    {
        bool? a_ = this.Patients_Age_40_to_75_Years_and_have_a_10_Year_CVD_Risk_of_High_without_ASCVD_and_High_LDL_and_Diabetes(context);
        IEnumerable<Encounter> b_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        bool? c_ = context.Operators.Exists<Encounter>(b_);
        bool? d_ = context.Operators.And(a_, c_);

        return d_;
    }


    [CqlDeclaration("Denominator 1")]
    public bool? Denominator_1(CqlContext context)
    {
        bool? a_ = this.Initial_Population_1(context);

        return a_;
    }


    [CqlDeclaration("Denominator 2")]
    public bool? Denominator_2(CqlContext context)
    {
        bool? a_ = this.Initial_Population_2(context);

        return a_;
    }


    [CqlDeclaration("Denominator 3")]
    public bool? Denominator_3(CqlContext context)
    {
        bool? a_ = this.Initial_Population_3(context);

        return a_;
    }


    [CqlDeclaration("Denominator 4")]
    public bool? Denominator_4(CqlContext context)
    {
        bool? a_ = this.Initial_Population_4(context);

        return a_;
    }


    [CqlDeclaration("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        CqlValueSet a_ = this.Breastfeeding(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet c_ = this.Rhabdomyolysis(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
        bool? f_(Condition ExclusionDiagnosis)
        {
            bool? i_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, ExclusionDiagnosis);
            bool? j_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, ExclusionDiagnosis);
            bool? k_ = context.Operators.Or(i_, j_);
            CqlInterval<CqlDateTime> l_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ExclusionDiagnosis);
            CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
            bool? n_ = context.Operators.Overlaps(l_, m_, "day");
            bool? o_ = context.Operators.And(k_, n_);

            return o_;
        };
        IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
        bool? h_ = context.Operators.Exists<Condition>(g_);

        return h_;
    }


    [CqlDeclaration("Has Allergy to Statin")]
    public bool? Has_Allergy_to_Statin(CqlContext context)
    {
        CqlValueSet a_ = this.Statin_Allergen(context);
        IEnumerable<AllergyIntolerance> b_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        bool? c_(AllergyIntolerance StatinAllergy)
        {
            DataType f_ = StatinAllergy?.Onset;
            object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
            CqlInterval<CqlDateTime> h_ = QICoreCommon_2_1_000.Instance.toInterval(context, g_);
            CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
            bool? j_ = context.Operators.Overlaps(h_, i_, "day");
            CodeableConcept k_ = StatinAllergy?.ClinicalStatus;
            CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, k_);
            CqlCode m_ = QICoreCommon_2_1_000.Instance.allergy_active(context);
            CqlConcept n_ = context.Operators.ConvertCodeToConcept(m_);
            bool? o_ = context.Operators.Equivalent(l_, n_);
            bool? p_ = context.Operators.And(j_, o_);

            return p_;
        };
        IEnumerable<AllergyIntolerance> d_ = context.Operators.Where<AllergyIntolerance>(b_, c_);
        bool? e_ = context.Operators.Exists<AllergyIntolerance>(d_);

        return e_;
    }


    [CqlDeclaration("Has Hepatitis or Liver Disease Diagnosis")]
    public bool? Has_Hepatitis_or_Liver_Disease_Diagnosis(CqlContext context)
    {
        CqlValueSet a_ = this.Hepatitis_A(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet c_ = this.Hepatitis_B(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
        CqlValueSet f_ = this.Liver_Disease(context);
        IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_, g_);
        bool? i_(Condition HepatitisLiverDisease)
        {
            bool? l_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, HepatitisLiverDisease);
            bool? m_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, HepatitisLiverDisease);
            bool? n_ = context.Operators.Or(l_, m_);
            CqlInterval<CqlDateTime> o_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HepatitisLiverDisease);
            CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
            bool? q_ = context.Operators.Overlaps(o_, p_, "day");
            bool? r_ = context.Operators.And(n_, q_);

            return r_;
        };
        IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
        bool? k_ = context.Operators.Exists<Condition>(j_);

        return k_;
    }


    [CqlDeclaration("Has Statin Associated Muscle Symptoms")]
    public bool? Has_Statin_Associated_Muscle_Symptoms(CqlContext context)
    {
        CqlValueSet a_ = this.Statin_Associated_Muscle_Symptoms(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? c_(Condition StatinMuscleSymptom)
        {
            bool? f_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, StatinMuscleSymptom);
            bool? g_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, StatinMuscleSymptom);
            bool? h_ = context.Operators.Or(f_, g_);
            CqlInterval<CqlDateTime> i_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, StatinMuscleSymptom);
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            bool? k_ = context.Operators.Overlaps(i_, j_, "day");
            bool? l_ = context.Operators.And(h_, k_);

            return l_;
        };
        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        bool? e_ = context.Operators.Exists<Condition>(d_);

        return e_;
    }


    [CqlDeclaration("Has ESRD Diagnosis")]
    public bool? Has_ESRD_Diagnosis(CqlContext context)
    {
        CqlValueSet a_ = this.End_Stage_Renal_Disease(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? c_(Condition ESRD)
        {
            bool? f_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, ESRD);
            bool? g_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, ESRD);
            bool? h_ = context.Operators.Or(f_, g_);
            CqlInterval<CqlDateTime> i_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ESRD);
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            bool? k_ = context.Operators.Overlaps(i_, j_, "day");
            bool? l_ = context.Operators.And(h_, k_);

            return l_;
        };
        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        bool? e_ = context.Operators.Exists<Condition>(d_);

        return e_;
    }


    [CqlDeclaration("Has Adverse Reaction to Statin")]
    public bool? Has_Adverse_Reaction_to_Statin(CqlContext context)
    {
        CqlValueSet a_ = this.Statin_Allergen(context);
        IEnumerable<AdverseEvent> b_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-adverseevent"));
        bool? c_(AdverseEvent StatinReaction)
        {
            FhirDateTime f_ = StatinReaction?.RecordedDateElement;
            CqlDateTime g_ = context.Operators.Convert<CqlDateTime>(f_);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            bool? i_ = context.Operators.In<CqlDateTime>(g_, h_, "day");

            return i_;
        };
        IEnumerable<AdverseEvent> d_ = context.Operators.Where<AdverseEvent>(b_, c_);
        bool? e_ = context.Operators.Exists<AdverseEvent>(d_);

        return e_;
    }


    [CqlDeclaration("Has Medical Reason for Not Ordering Statin Therapy")]
    public bool? Has_Medical_Reason_for_Not_Ordering_Statin_Therapy(CqlContext context)
    {
        CqlValueSet a_ = this.Low_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
        CqlValueSet f_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> g_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> i_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> j_ = context.Operators.Union<MedicationRequest>(g_, i_);
        IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(e_, j_);
        CqlValueSet l_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> m_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> o_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> p_ = context.Operators.Union<MedicationRequest>(m_, o_);
        IEnumerable<MedicationRequest> q_ = context.Operators.Union<MedicationRequest>(k_, p_);
        IEnumerable<MedicationRequest> r_(MedicationRequest NoStatinTherapyOrdered)
        {
            IEnumerable<Encounter> u_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
            bool? v_(Encounter QualifyingEncounter)
            {
                FhirDateTime z_ = NoStatinTherapyOrdered?.AuthoredOnElement;
                CqlDateTime aa_ = context.Operators.Convert<CqlDateTime>(z_);
                Period ab_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ab_);
                bool? ad_ = context.Operators.In<CqlDateTime>(aa_, ac_, default);
                Code<MedicationRequest.MedicationrequestStatus> ae_ = NoStatinTherapyOrdered?.StatusElement;
                MedicationRequest.MedicationrequestStatus? af_ = ae_?.Value;
                string ag_ = context.Operators.Convert<string>(af_);
                bool? ah_ = context.Operators.Equal(ag_, "completed");
                bool? ai_ = context.Operators.And(ad_, ah_);
                List<CodeableConcept> aj_ = NoStatinTherapyOrdered?.ReasonCode;
                CqlConcept ak_(CodeableConcept @this)
                {
                    CqlConcept ap_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                    return ap_;
                };
                IEnumerable<CqlConcept> al_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)aj_, ak_);
                CqlValueSet am_ = this.Medical_Reason(context);
                bool? an_ = context.Operators.ConceptsInValueSet(al_, am_);
                bool? ao_ = context.Operators.And(ai_, an_);

                return ao_;
            };
            IEnumerable<Encounter> w_ = context.Operators.Where<Encounter>(u_, v_);
            MedicationRequest x_(Encounter QualifyingEncounter) =>
                NoStatinTherapyOrdered;
            IEnumerable<MedicationRequest> y_ = context.Operators.Select<Encounter, MedicationRequest>(w_, x_);

            return y_;
        };
        IEnumerable<MedicationRequest> s_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(q_, r_);
        bool? t_ = context.Operators.Exists<MedicationRequest>(s_);

        return t_;
    }


    [CqlDeclaration("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        bool? a_ = this.Has_Allergy_to_Statin(context);
        bool? b_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? c_ = context.Operators.Or(a_, b_);
        bool? d_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? e_ = context.Operators.Or(c_, d_);
        bool? f_ = this.Has_Hepatitis_or_Liver_Disease_Diagnosis(context);
        bool? g_ = context.Operators.Or(e_, f_);
        bool? h_ = this.Has_Statin_Associated_Muscle_Symptoms(context);
        bool? i_ = context.Operators.Or(g_, h_);
        bool? j_ = this.Has_ESRD_Diagnosis(context);
        bool? k_ = context.Operators.Or(i_, j_);
        bool? l_ = this.Has_Adverse_Reaction_to_Statin(context);
        bool? m_ = context.Operators.Or(k_, l_);
        bool? n_ = this.Has_Medical_Reason_for_Not_Ordering_Statin_Therapy(context);
        bool? o_ = context.Operators.Or(m_, n_);

        return o_;
    }


    [CqlDeclaration("Statin Therapy Prescribed Anytime during day of Measurement Period")]
    public IEnumerable<MedicationRequest> Statin_Therapy_Prescribed_Anytime_during_day_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet a_ = this.Low_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
        CqlValueSet f_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> g_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> i_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> j_ = context.Operators.Union<MedicationRequest>(g_, i_);
        IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(e_, j_);
        CqlValueSet l_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> m_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> o_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> p_ = context.Operators.Union<MedicationRequest>(m_, o_);
        IEnumerable<MedicationRequest> q_ = context.Operators.Union<MedicationRequest>(k_, p_);
        bool? r_(MedicationRequest StatinPrescribed)
        {
            Code<MedicationRequest.MedicationrequestStatus> t_ = StatinPrescribed?.StatusElement;
            MedicationRequest.MedicationrequestStatus? u_ = t_?.Value;
            string v_ = context.Operators.Convert<string>(u_);
            string[] w_ = [
                "active",
                "completed",
            ];
            bool? x_ = context.Operators.In<string>(v_, w_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> y_ = StatinPrescribed?.IntentElement;
            MedicationRequest.MedicationRequestIntent? z_ = y_?.Value;
            string aa_ = context.Operators.Convert<string>(z_);
            bool? ab_ = context.Operators.Equivalent(aa_, "order");
            bool? ac_ = context.Operators.And(x_, ab_);
            FhirDateTime ad_ = StatinPrescribed?.AuthoredOnElement;
            CqlDateTime ae_ = context.Operators.Convert<CqlDateTime>(ad_);
            CqlInterval<CqlDateTime> af_ = this.Measurement_Period(context);
            bool? ag_ = context.Operators.In<CqlDateTime>(ae_, af_, "day");
            List<Dosage> ah_ = StatinPrescribed?.DosageInstruction;
            bool? ai_(Dosage @this)
            {
                Timing ar_ = @this?.Timing;
                bool? as_ = context.Operators.Not((bool?)(ar_ is null));

                return as_;
            };
            IEnumerable<Dosage> aj_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)ah_, ai_);
            Timing ak_(Dosage @this)
            {
                Timing at_ = @this?.Timing;

                return at_;
            };
            IEnumerable<Timing> al_ = context.Operators.Select<Dosage, Timing>(aj_, ak_);
            bool? am_(Timing T)
            {
                Timing.RepeatComponent au_ = T?.Repeat;
                DataType av_ = au_?.Bounds;
                object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                CqlInterval<CqlDateTime> ax_ = QICoreCommon_2_1_000.Instance.toInterval(context, aw_);
                CqlInterval<CqlDateTime> ay_ = this.Measurement_Period(context);
                bool? az_ = context.Operators.Overlaps(ax_, ay_, "day");

                return az_;
            };
            IEnumerable<Timing> an_ = context.Operators.Where<Timing>(al_, am_);
            bool? ao_ = context.Operators.Exists<Timing>(an_);
            bool? ap_ = context.Operators.Or(ag_, ao_);
            bool? aq_ = context.Operators.And(ac_, ap_);

            return aq_;
        };
        IEnumerable<MedicationRequest> s_ = context.Operators.Where<MedicationRequest>(q_, r_);

        return s_;
    }


    [CqlDeclaration("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<MedicationRequest> a_ = this.Statin_Therapy_Prescribed_Anytime_during_day_of_Measurement_Period(context);
        bool? b_ = context.Operators.Exists<MedicationRequest>(a_);

        return b_;
    }


    [CqlDeclaration("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlDeclaration("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlDeclaration("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return a_;
    }


    #endregion Definition Methods

}

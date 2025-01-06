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
[CqlLibrary("NCQAPalliativeCare", "1.0.0")]
public partial class NCQAPalliativeCare_1_0_0 : ILibrary, ISingleton<NCQAPalliativeCare_1_0_0>
{
    private NCQAPalliativeCare_1_0_0() {}

    public static NCQAPalliativeCare_1_0_0 Instance { get; } = new();

    #region Library Members
    string ILibrary.Name => "NCQAPalliativeCare";
    string ILibrary.Version => "1.0.0";
    IReadOnlyList<ILibrary> ILibrary.Dependencies => [FHIRHelpers_4_0_001.Instance, NCQAFHIRBase_1_0_0.Instance, NCQAStatus_1_0_0.Instance];
    #endregion Library Members

    [CqlDeclaration("Palliative Care Assessment")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2225")]
    public CqlValueSet Palliative_Care_Assessment(CqlContext context) =>
        new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2225", default);



    [CqlDeclaration("Palliative Care Encounter")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1450")]
    public CqlValueSet Palliative_Care_Encounter(CqlContext context) =>
        new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1450", default);



    [CqlDeclaration("Palliative Care Intervention")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2224")]
    public CqlValueSet Palliative_Care_Intervention(CqlContext context) =>
        new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2224", default);



    [CqlDeclaration("Encounter for palliative care")]
    public CqlCode Encounter_for_palliative_care(CqlContext context) =>
        new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm", default, default);



    [CqlDeclaration("ICD-10")]
    public CqlCode[] ICD_10(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm", default, default),
        ];

        return a_;
    }


    public bool? Palliative_Care_Overlapping_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlValueSet a_ = this.Palliative_Care_Assessment(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? c_(Observation PalliativeAssessment)
        {
            DataType ab_ = PalliativeAssessment?.Effective;
            CqlInterval<CqlDateTime> ac_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ab_);
            CqlDateTime ad_ = context.Operators.Start(ac_);
            CqlDate ae_ = context.Operators.DateFrom(ad_);
            CqlInterval<CqlDateTime> ag_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ab_);
            CqlDateTime ah_ = context.Operators.End(ag_);
            CqlDate ai_ = context.Operators.DateFrom(ah_);
            CqlInterval<CqlDate> aj_ = context.Operators.Interval(ae_, ai_, true, true);
            CqlDateTime ak_ = context.Operators.Start(Period);
            CqlDate al_ = context.Operators.DateFrom(ak_);
            CqlDateTime am_ = context.Operators.End(Period);
            CqlDate an_ = context.Operators.DateFrom(am_);
            CqlInterval<CqlDate> ao_ = context.Operators.Interval(al_, an_, true, true);
            bool? ap_ = context.Operators.Overlaps(aj_, ao_, default);

            return ap_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        bool? e_ = context.Operators.Exists<Observation>(d_);
        CqlValueSet f_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> h_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, g_);
        bool? i_(Encounter PalliativeEncounter)
        {
            Period aq_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> ar_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, aq_ as object);
            CqlDateTime as_ = context.Operators.Start(ar_);
            CqlDate at_ = context.Operators.DateFrom(as_);
            CqlInterval<CqlDateTime> av_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, aq_ as object);
            CqlDateTime aw_ = context.Operators.End(av_);
            CqlDate ax_ = context.Operators.DateFrom(aw_);
            CqlInterval<CqlDate> ay_ = context.Operators.Interval(at_, ax_, true, true);
            CqlDateTime az_ = context.Operators.Start(Period);
            CqlDate ba_ = context.Operators.DateFrom(az_);
            CqlDateTime bb_ = context.Operators.End(Period);
            CqlDate bc_ = context.Operators.DateFrom(bb_);
            CqlInterval<CqlDate> bd_ = context.Operators.Interval(ba_, bc_, true, true);
            bool? be_ = context.Operators.Overlaps(ay_, bd_, default);

            return be_;
        };
        IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
        bool? k_ = context.Operators.Exists<Encounter>(j_);
        bool? l_ = context.Operators.Or(e_, k_);
        CqlValueSet m_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> n_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> o_ = NCQAStatus_1_0_0.Instance.Completed_or_Ongoing_Procedure(context, n_);
        bool? p_(Procedure PalliativeIntervention)
        {
            DataType bf_ = PalliativeIntervention?.Performed;
            CqlInterval<CqlDateTime> bg_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, bf_);
            CqlDateTime bh_ = context.Operators.Start(bg_);
            CqlDate bi_ = context.Operators.DateFrom(bh_);
            CqlInterval<CqlDateTime> bk_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, bf_);
            CqlDateTime bl_ = context.Operators.End(bk_);
            CqlDate bm_ = context.Operators.DateFrom(bl_);
            CqlInterval<CqlDate> bn_ = context.Operators.Interval(bi_, bm_, true, true);
            CqlDateTime bo_ = context.Operators.Start(Period);
            CqlDate bp_ = context.Operators.DateFrom(bo_);
            CqlDateTime bq_ = context.Operators.End(Period);
            CqlDate br_ = context.Operators.DateFrom(bq_);
            CqlInterval<CqlDate> bs_ = context.Operators.Interval(bp_, br_, true, true);
            bool? bt_ = context.Operators.Overlaps(bn_, bs_, default);

            return bt_;
        };
        IEnumerable<Procedure> q_ = context.Operators.Where<Procedure>(o_, p_);
        bool? r_ = context.Operators.Exists<Procedure>(q_);
        bool? s_ = context.Operators.Or(l_, r_);
        CqlCode t_ = this.Encounter_for_palliative_care(context);
        IEnumerable<CqlCode> u_ = context.Operators.ToList<CqlCode>(t_);
        IEnumerable<Condition> v_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, u_, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> w_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, v_);
        bool? x_(Condition PalliativeDiagnosis)
        {
            CqlInterval<CqlDateTime> bu_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, PalliativeDiagnosis);
            CqlDateTime bv_ = context.Operators.Start(bu_);
            CqlDate bw_ = context.Operators.DateFrom(bv_);
            CqlDateTime by_ = context.Operators.End(bu_);
            CqlDate bz_ = context.Operators.DateFrom(by_);
            CqlInterval<CqlDate> ca_ = context.Operators.Interval(bw_, bz_, true, true);
            CqlDateTime cb_ = context.Operators.Start(Period);
            CqlDate cc_ = context.Operators.DateFrom(cb_);
            CqlDateTime cd_ = context.Operators.End(Period);
            CqlDate ce_ = context.Operators.DateFrom(cd_);
            CqlInterval<CqlDate> cf_ = context.Operators.Interval(cc_, ce_, true, true);
            bool? cg_ = context.Operators.Overlaps(ca_, cf_, default);

            return cg_;
        };
        IEnumerable<Condition> y_ = context.Operators.Where<Condition>(w_, x_);
        bool? z_ = context.Operators.Exists<Condition>(y_);
        bool? aa_ = context.Operators.Or(s_, z_);

        return aa_;
    }


    private static CqlTupleMetadata CqlTupleMetadata_EaLaedgLDgRRYaLbKIIcBTOiA = new(
        [typeof(Encounter), typeof(Encounter)],
        ["OutpatientEncounter1", "OutpatientEncounter2"]);

    private static CqlTupleMetadata CqlTupleMetadata_CgaDVOXeQBMgMPCPZOThIIdDb = new(
        [typeof(CqlInterval<CqlDateTime>), typeof(CqlInterval<CqlDateTime>)],
        ["LTCPeriod1", "LTCPeriod2"]);

    private static CqlTupleMetadata CqlTupleMetadata_GIMHfXDcFiAjSJBDGYeUeZLhW = new(
        [typeof(CqlInterval<CqlDate>), typeof(CqlDate)],
        ["interval", "startOfInterval"]);

    private static CqlTupleMetadata CqlTupleMetadata_EQHOUSiiWahbJPOUjJGEhIAOV = new(
        [typeof(CqlInterval<CqlDateTime>), typeof(CqlDateTime)],
        ["interval", "startOfInterval"]);

    private static CqlTupleMetadata CqlTupleMetadata_EVRLVXPcBiDTIWfCCfKEWDfKI = new(
        [typeof(IEnumerable<CqlInterval<CqlDate>>)],
        ["sortedCoverings"]);

    private static CqlTupleMetadata CqlTupleMetadata_FKcLSALRMRfDigEFaJgDOPFRK = new(
        [typeof(IEnumerable<CqlInterval<CqlDate>>), typeof(IEnumerable<CqlInterval<CqlDate>>)],
        ["frontgaps", "endgap"]);

    private static CqlTupleMetadata CqlTupleMetadata_EdgSWaTaCbLYLJceGdIcWOLHd = new(
        [typeof(IEnumerable<CqlInterval<CqlDateTime>>)],
        ["sortedCoverings"]);

    private static CqlTupleMetadata CqlTupleMetadata_BBLSSiNBQBGUDJaVjMDZMSAXg = new(
        [typeof(IEnumerable<CqlInterval<CqlDateTime>>), typeof(IEnumerable<CqlInterval<CqlDateTime>>)],
        ["frontgaps", "endgap"]);

    private static CqlTupleMetadata CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC = new(
        [typeof(CqlInterval<CqlDate>), typeof(int?)],
        ["interval", "days"]);

    private static CqlTupleMetadata CqlTupleMetadata_HRbPDRZiOGGBceePOZWjVbXdP = new(
        [typeof(IEnumerable<CqlInterval<CqlDate>>), typeof(int?), typeof(int?), typeof(CqlInterval<CqlDate>), typeof(int?)],
        ["Intervals", "Interval_Count", "Total_Days_In_Intervals", "Longest_Interval", "Total_Days_In_Longest_Interval"]);

    private static CqlTupleMetadata CqlTupleMetadata_DUiZjXRKgCPYVZQJbFVDKNMOi = new(
        [typeof(IEnumerable<CqlInterval<CqlDate>>)],
        ["Covering_Intervals"]);

    private static CqlTupleMetadata CqlTupleMetadata_GQPbYTYABjXFVLRKjXgcDJFSj = new(
        [typeof(IEnumerable<CqlInterval<CqlDate>>)],
        ["Gap_Intervals"]);

    private static CqlTupleMetadata CqlTupleMetadata_FcQREFSfPJSKYAhSEWVJcZVED = new(
        [typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?)],
        ["StartYear", "StartMonth", "StartDay", "StartHour", "StartMinute", "StartSecond", "StartMillisecond", "EndYear", "EndMonth", "EndDay", "EndHour", "EndMinute", "EndSecond", "EndMillisecond"]);

    private static CqlTupleMetadata CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL = new(
        [typeof(CqlInterval<CqlDateTime>), typeof(int?)],
        ["interval", "days"]);

    private static CqlTupleMetadata CqlTupleMetadata_HDihbLieYfQbgeSbOWZBAMUIQ = new(
        [typeof(IEnumerable<CqlInterval<CqlDateTime>>), typeof(int?), typeof(int?), typeof(CqlInterval<CqlDateTime>), typeof(int?)],
        ["Intervals", "Interval_Count", "Total_Days_In_Intervals", "Longest_Interval", "Total_Days_In_Longest_Interval"]);

    private static CqlTupleMetadata CqlTupleMetadata_GZMPWdGOJiTNjfWAcbZMePdXV = new(
        [typeof(IEnumerable<CqlInterval<CqlDateTime>>)],
        ["Covering_Intervals"]);

    private static CqlTupleMetadata CqlTupleMetadata_CKbERRbOPGNBBERUOghhaOYSE = new(
        [typeof(IEnumerable<CqlInterval<CqlDateTime>>)],
        ["Gap_Intervals"]);

    private static CqlTupleMetadata CqlTupleMetadata_CfANiScMYDdVZFgRERKJQEVca = new(
        [typeof(IEnumerable<CqlDate>)],
        ["SortedDates"]);

    private static CqlTupleMetadata CqlTupleMetadata_BDeBMdFeZaVSehBSFYjTFdYYD = new(
        [typeof(IEnumerable<CqlDate>), typeof(int?)],
        ["SortedList", "AnchorIndex"]);

    private static CqlTupleMetadata CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc = new(
        [typeof(CqlDate), typeof(IEnumerable<CqlDate>), typeof(int?)],
        ["NextDate", "NewList", "IndexofNewDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_BaNHUZXcQBUKLNgEDWdDHjYV = new(
        [typeof(CqlInterval<CqlDate>), typeof(CqlInterval<CqlDate>)],
        ["Coverage1", "Coverage2"]);

    private static CqlTupleMetadata CqlTupleMetadata_DPLIOBaSciHAAETJOMSIjWgbP = new(
        [typeof(IEnumerable<CqlInterval<CqlDate>>), typeof(IEnumerable<CqlInterval<CqlDate>>), typeof(IEnumerable<CqlInterval<CqlDate>>), typeof(IEnumerable<CqlInterval<CqlDate>>)],
        ["IntervalInfo", "Collapsed", "Adjacent", "CollapsedFinal"]);

    private static CqlTupleMetadata CqlTupleMetadata_GIgcTXSQJbIXPiNgNbAIdOBXi = new(
        [typeof(IEnumerable<Claim>), typeof(IEnumerable<string>), typeof(IEnumerable<string>)],
        ["MedicalClaim", "ProceduresAsStrings", "POSAsString"]);

    private static CqlTupleMetadata CqlTupleMetadata_HSdidNdfHCNCFSUTgBiYLcgXP = new(
        [typeof(Claim), typeof(IEnumerable<Claim.ItemComponent>)],
        ["Claim", "LineItems"]);

    private static CqlTupleMetadata CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd = new(
        [typeof(Claim), typeof(IEnumerable<CqlInterval<CqlDateTime>>)],
        ["Claim", "ServicePeriod"]);

    private static CqlTupleMetadata CqlTupleMetadata_GKQGAFOMQbCPRXAANKASUIHMf = new(
        [typeof(IEnumerable<Claim>), typeof(IEnumerable<string>)],
        ["MedicalClaim", "DiagnosesAsStrings"]);

    private static CqlTupleMetadata CqlTupleMetadata_GDVcejYEWXWNHUIODacaMaBhV = new(
        [typeof(IEnumerable<Claim>)],
        ["DiagnosisItems"]);

    private static CqlTupleMetadata CqlTupleMetadata_CWDDWHRXGADEbdaKXCdKbgEfg = new(
        [typeof(IEnumerable<Claim>), typeof(IEnumerable<CqlInterval<CqlDateTime>>)],
        ["Claim", "ServicePeriod"]);

    private static CqlTupleMetadata CqlTupleMetadata_CZJDcULSYFOUeGSUcDccghjMK = new(
        [typeof(IEnumerable<Claim>), typeof(IEnumerable<string>)],
        ["PharmacyClaim", "MedicationsAsStrings"]);

    private static CqlTupleMetadata CqlTupleMetadata_HDUYFgZGRCJCdTeEcMSVCMQNN = new(
        [typeof(CqlInterval<CqlDateTime>)],
        ["DaysSupplyInterval"]);

    private static CqlTupleMetadata CqlTupleMetadata_fQfNOLePNSNdOZROKRAfMQPE = new(
        [typeof(IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?>)],
        ["CoveredDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_FCdHTREUGBEaiYVQNNGRPZFjf = new(
        [typeof(Claim), typeof(IEnumerable<Claim.ItemComponent>), typeof(IEnumerable<CqlInterval<CqlDateTime>>), typeof(IEnumerable<CqlInterval<CqlDateTime>>)],
        ["Claim", "LineItem", "ServicePeriod", "CoveredDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_GQFgMiKhOZgECFTScigSABdXb = new(
        [typeof(IEnumerable<Claim>), typeof(IEnumerable<string>), typeof(IEnumerable<string>)],
        ["MedicalClaim", "DiagnosesAsStrings", "ProceduresAsStrings"]);

    private static CqlTupleMetadata CqlTupleMetadata_CXESjjTOQIGKICAEMDgcfPdJG = new(
        [typeof(Claim)],
        ["ProcedureItems"]);

    private static CqlTupleMetadata CqlTupleMetadata_FYaKYiIDIQCIRBfhZCGRDYQLX = new(
        [typeof(Claim), typeof(Claim)],
        ["Claim", "ProcedureItems"]);

    private static CqlTupleMetadata CqlTupleMetadata_iYTJVNYRMBhJCKDIUSKFMUHe = new(
        [typeof(IEnumerable<Claim.ItemComponent>), typeof(Claim)],
        ["Procedure", "LineItems"]);

    private static CqlTupleMetadata CqlTupleMetadata_DBEDLLOihLKGPWLHVWXRKfGdL = new(
        [typeof(IEnumerable<Claim>)],
        ["LineItems"]);

    private static CqlTupleMetadata CqlTupleMetadata_ESGibVhJBKTGTjRhHBeNDHASE = new(
        [typeof(IEnumerable<ClaimResponse>), typeof(IEnumerable<Claim>)],
        ["MedicalClaimResponse", "MedicalClaim"]);

    private static CqlTupleMetadata CqlTupleMetadata_DbDPVOODdCjASWRZfBTBPUJKR = new(
        [typeof(IEnumerable<ClaimResponse>)],
        ["PaidResponse"]);

    private static CqlTupleMetadata CqlTupleMetadata_FfbRdLZNBbFHejZXDegUDAhjO = new(
        [typeof(ClaimResponse), typeof(string), typeof(IEnumerable<ClaimResponse.ItemComponent>)],
        ["Response", "ResponseID", "LineItems"]);

    private static CqlTupleMetadata CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi = new(
        [typeof(Claim), typeof(Id), typeof(IEnumerable<Claim.ItemComponent>)],
        ["ClaimofInterest", "ClaimID", "LineItems"]);

    private static CqlTupleMetadata CqlTupleMetadata_DiTbeIhUdTbFXAOeUfBeANOcV = new(
        [typeof(IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>), typeof(IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>)],
        ["PaidMedicalClaimResponse", "MedicalClaim"]);

    private static CqlTupleMetadata CqlTupleMetadata_HANAFPgdEHHITIiaCbHRMCNfZ = new(
        [typeof((CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?), typeof(IEnumerable<Claim.ItemComponent>)],
        ["PaidClaim", "ClaimItem"]);

    private static CqlTupleMetadata CqlTupleMetadata_GUibhjYMgjAQISFDJORUOccJC = new(
        [typeof(IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>)],
        ["AggregateClaim"]);

    private static CqlTupleMetadata CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR = new(
        [typeof(IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>), typeof(IEnumerable<CqlInterval<CqlDateTime>>)],
        ["originalClaim", "ServicePeriod"]);

    private static CqlTupleMetadata CqlTupleMetadata_EgMIjgYNSTYejjeaeeSfTCGLV = new(
        [typeof(IEnumerable<ClaimResponse>), typeof(IEnumerable<Claim>)],
        ["PharmacyClaimResponse", "PharmacyClaim"]);

    private static CqlTupleMetadata CqlTupleMetadata_EhcebFbUeFgabTLNPALjRJQCF = new(
        [typeof(IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>), typeof(IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>)],
        ["PaidPharmacyClaimResponse", "MedicalClaim"]);

    private static CqlTupleMetadata CqlTupleMetadata_BiVTcKEZOfgFCDEReGAXJRAUK = new(
        [typeof((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?), typeof(IEnumerable<Claim.ItemComponent>)],
        ["PaidClaim", "ClaimItem"]);

    private static CqlTupleMetadata CqlTupleMetadata_EMbbXAAHNDcXYSgLIhAhQCWON = new(
        [typeof(IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>)],
        ["AggregateClaim"]);

    private static CqlTupleMetadata CqlTupleMetadata_DXGMEVDRBZgHMANCfXfEUYMNW = new(
        [typeof(IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>), typeof(IEnumerable<CqlInterval<CqlDateTime>>), typeof(IEnumerable<CqlInterval<CqlDate>>)],
        ["originalClaim", "ServicePeriod", "CoveredDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_CZThYJbgajVLdhIZdgZiXBFQK = new(
        [typeof(IEnumerable<ClaimResponse>), typeof(IEnumerable<Claim>)],
        ["ClaimResponse", "OriginalClaim"]);

    private static CqlTupleMetadata CqlTupleMetadata_GFUjSKcYaHagAZIhSUhffHjHP = new(
        [typeof(IEnumerable<Claim>), typeof(IEnumerable<Claim>)],
        ["InpatientStayLineItems", "NonacuteInpatientLineItems"]);

    private static CqlTupleMetadata CqlTupleMetadata_DBGUUNgWTQDYFIeOfMhQJAYTB = new(
        [typeof(IEnumerable<Claim>), typeof(IEnumerable<Claim>), typeof(IEnumerable<Claim>)],
        ["InpatientDischarge", "NonacuteInpatientDischarge", "AcuteInpatientDischarge"]);

    private static CqlTupleMetadata CqlTupleMetadata_BWiFKXdFieUciRMVTUCdIFCVO = new(
        [typeof(Claim), typeof(IEnumerable<ResourceReference>), typeof(IEnumerable<string>)],
        ["SingleCareTeam", "CareTeamsProvider", "CareTeamsProviderID"]);

    private static CqlTupleMetadata CqlTupleMetadata_HFNJUcNhcbGBLBgHAJMMSPfQH = new(
        [typeof(IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>)],
        ["CareTeams"]);

    private static CqlTupleMetadata CqlTupleMetadata_FPVdJEEOUKFVhQPTfKhShUNO = new(
        [typeof(IEnumerable<Practitioner>)],
        ["Practitioners"]);

    private static CqlTupleMetadata CqlTupleMetadata_EheHUARRFfQdCcHKeSEhfYZMj = new(
        [typeof(IEnumerable<FhirString>), typeof(IEnumerable<Identifier>)],
        ["AllIdentifiers", "NullIdentifiers"]);

    private static CqlTupleMetadata CqlTupleMetadata_EZUSISLPSZWTXahaQjXaSAJBE = new(
        [typeof(IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?>)],
        ["IdentifierTuple"]);

    private static CqlTupleMetadata CqlTupleMetadata_FBUdWLSDMgYFFiVXYhKEiUNQS = new(
        [typeof(int?)],
        ["IdentifierCount"]);

    private static CqlTupleMetadata CqlTupleMetadata_gFQSaDQdhfIVgTfEbUhWdbBB = new(
        [typeof(IEnumerable<Claim.ItemComponent>), typeof(IEnumerable<ResourceReference>), typeof(IEnumerable<string>)],
        ["SingleItem", "ItemLocation", "ItemLocationID"]);

    private static CqlTupleMetadata CqlTupleMetadata_ESTVjUCCVhLEXJGPZBeEcQDHX = new(
        [typeof(IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>)],
        ["ItemsLocationReferences"]);

    private static CqlTupleMetadata CqlTupleMetadata_GWYcfjEGjPEdPbTNdfROfTUAf = new(
        [typeof(IEnumerable<Location>)],
        ["CorrespondingLocations"]);

    private static CqlTupleMetadata CqlTupleMetadata_CMSeRgTJgKISKSQUcNZWKegGV = new(
        [typeof(CqlDate), typeof(CqlDate)],
        ["OutpatientVisit1", "OutpatientVisit2"]);

}

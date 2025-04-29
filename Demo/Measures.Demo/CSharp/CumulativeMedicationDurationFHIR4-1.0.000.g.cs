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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.0.0.0")]
[CqlLibrary("CumulativeMedicationDurationFHIR4", "1.0.000")]
public partial class CumulativeMedicationDurationFHIR4_1_0_000 : ILibrary, ISingleton<CumulativeMedicationDurationFHIR4_1_0_000>
{
    private CumulativeMedicationDurationFHIR4_1_0_000() {}

    public static CumulativeMedicationDurationFHIR4_1_0_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CumulativeMedicationDurationFHIR4";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance];

    #endregion ILibrary Implementation

    #region Codes

    #region Code: AC
    [CqlCodeDefinition(
        definitionName: "AC",
        codeId: "AC",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode AC(CqlContext context) => _AC;

    private static readonly CqlCode _AC = new CqlCode("AC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);
    #endregion

    #region Code: ACD
    [CqlCodeDefinition(
        definitionName: "ACD",
        codeId: "ACD",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode ACD(CqlContext context) => _ACD;

    private static readonly CqlCode _ACD = new CqlCode("ACD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);
    #endregion

    #region Code: ACM
    [CqlCodeDefinition(
        definitionName: "ACM",
        codeId: "ACM",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode ACM(CqlContext context) => _ACM;

    private static readonly CqlCode _ACM = new CqlCode("ACM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);
    #endregion

    #region Code: ACV
    [CqlCodeDefinition(
        definitionName: "ACV",
        codeId: "ACV",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode ACV(CqlContext context) => _ACV;

    private static readonly CqlCode _ACV = new CqlCode("ACV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);
    #endregion

    #region Code: AFT
    [CqlCodeDefinition(
        definitionName: "AFT",
        codeId: "AFT",
        codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode AFT(CqlContext context) => _AFT;

    private static readonly CqlCode _AFT = new CqlCode("AFT", "http://hl7.org/fhir/event-timing", default, default);
    #endregion

    #region Code: AFT.early
    [CqlCodeDefinition(
        definitionName: "AFT.early",
        codeId: "AFT.early",
        codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode AFT_early(CqlContext context) => _AFT_early;

    private static readonly CqlCode _AFT_early = new CqlCode("AFT.early", "http://hl7.org/fhir/event-timing", default, default);
    #endregion

    #region Code: AFT.late
    [CqlCodeDefinition(
        definitionName: "AFT.late",
        codeId: "AFT.late",
        codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode AFT_late(CqlContext context) => _AFT_late;

    private static readonly CqlCode _AFT_late = new CqlCode("AFT.late", "http://hl7.org/fhir/event-timing", default, default);
    #endregion

    #region Code: C
    [CqlCodeDefinition(
        definitionName: "C",
        codeId: "C",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode C(CqlContext context) => _C;

    private static readonly CqlCode _C = new CqlCode("C", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);
    #endregion

    #region Code: CD
    [CqlCodeDefinition(
        definitionName: "CD",
        codeId: "CD",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode CD(CqlContext context) => _CD;

    private static readonly CqlCode _CD = new CqlCode("CD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);
    #endregion

    #region Code: CM
    [CqlCodeDefinition(
        definitionName: "CM",
        codeId: "CM",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode CM(CqlContext context) => _CM;

    private static readonly CqlCode _CM = new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);
    #endregion

    #region Code: CV
    [CqlCodeDefinition(
        definitionName: "CV",
        codeId: "CV",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode CV(CqlContext context) => _CV;

    private static readonly CqlCode _CV = new CqlCode("CV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);
    #endregion

    #region Code: EVE
    [CqlCodeDefinition(
        definitionName: "EVE",
        codeId: "EVE",
        codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode EVE(CqlContext context) => _EVE;

    private static readonly CqlCode _EVE = new CqlCode("EVE", "http://hl7.org/fhir/event-timing", default, default);
    #endregion

    #region Code: EVE.early
    [CqlCodeDefinition(
        definitionName: "EVE.early",
        codeId: "EVE.early",
        codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode EVE_early(CqlContext context) => _EVE_early;

    private static readonly CqlCode _EVE_early = new CqlCode("EVE.early", "http://hl7.org/fhir/event-timing", default, default);
    #endregion

    #region Code: EVE.late
    [CqlCodeDefinition(
        definitionName: "EVE.late",
        codeId: "EVE.late",
        codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode EVE_late(CqlContext context) => _EVE_late;

    private static readonly CqlCode _EVE_late = new CqlCode("EVE.late", "http://hl7.org/fhir/event-timing", default, default);
    #endregion

    #region Code: HS
    [CqlCodeDefinition(
        definitionName: "HS",
        codeId: "HS",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode HS(CqlContext context) => _HS;

    private static readonly CqlCode _HS = new CqlCode("HS", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);
    #endregion

    #region Code: MORN
    [CqlCodeDefinition(
        definitionName: "MORN",
        codeId: "MORN",
        codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode MORN(CqlContext context) => _MORN;

    private static readonly CqlCode _MORN = new CqlCode("MORN", "http://hl7.org/fhir/event-timing", default, default);
    #endregion

    #region Code: MORN.early
    [CqlCodeDefinition(
        definitionName: "MORN.early",
        codeId: "MORN.early",
        codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode MORN_early(CqlContext context) => _MORN_early;

    private static readonly CqlCode _MORN_early = new CqlCode("MORN.early", "http://hl7.org/fhir/event-timing", default, default);
    #endregion

    #region Code: MORN.late
    [CqlCodeDefinition(
        definitionName: "MORN.late",
        codeId: "MORN.late",
        codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode MORN_late(CqlContext context) => _MORN_late;

    private static readonly CqlCode _MORN_late = new CqlCode("MORN.late", "http://hl7.org/fhir/event-timing", default, default);
    #endregion

    #region Code: NIGHT
    [CqlCodeDefinition(
        definitionName: "NIGHT",
        codeId: "NIGHT",
        codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode NIGHT(CqlContext context) => _NIGHT;

    private static readonly CqlCode _NIGHT = new CqlCode("NIGHT", "http://hl7.org/fhir/event-timing", default, default);
    #endregion

    #region Code: NOON
    [CqlCodeDefinition(
        definitionName: "NOON",
        codeId: "NOON",
        codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode NOON(CqlContext context) => _NOON;

    private static readonly CqlCode _NOON = new CqlCode("NOON", "http://hl7.org/fhir/event-timing", default, default);
    #endregion

    #region Code: PC
    [CqlCodeDefinition(
        definitionName: "PC",
        codeId: "PC",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode PC(CqlContext context) => _PC;

    private static readonly CqlCode _PC = new CqlCode("PC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);
    #endregion

    #region Code: PCD
    [CqlCodeDefinition(
        definitionName: "PCD",
        codeId: "PCD",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode PCD(CqlContext context) => _PCD;

    private static readonly CqlCode _PCD = new CqlCode("PCD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);
    #endregion

    #region Code: PCM
    [CqlCodeDefinition(
        definitionName: "PCM",
        codeId: "PCM",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode PCM(CqlContext context) => _PCM;

    private static readonly CqlCode _PCM = new CqlCode("PCM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);
    #endregion

    #region Code: PCV
    [CqlCodeDefinition(
        definitionName: "PCV",
        codeId: "PCV",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode PCV(CqlContext context) => _PCV;

    private static readonly CqlCode _PCV = new CqlCode("PCV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);
    #endregion

    #region Code: PHS
    [CqlCodeDefinition(
        definitionName: "PHS",
        codeId: "PHS",
        codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode PHS(CqlContext context) => _PHS;

    private static readonly CqlCode _PHS = new CqlCode("PHS", "http://hl7.org/fhir/event-timing", default, default);
    #endregion

    #region Code: WAKE
    [CqlCodeDefinition(
        definitionName: "WAKE",
        codeId: "WAKE",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode WAKE(CqlContext context) => _WAKE;

    private static readonly CqlCode _WAKE = new CqlCode("WAKE", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "V3TimingEvent")]
    public CqlCode[] V3TimingEvent(CqlContext context)
    {
        CqlCode[] nzzd_ = [
            new CqlCode("AC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("ACD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("ACM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("ACV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("C", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("CD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("CV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("HS", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("PC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("PCD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("PCM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("PCV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("WAKE", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
        ];

        return nzzd_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "EventTiming")]
    public CqlCode[] EventTiming(CqlContext context)
    {
        CqlCode[] nzze_ = [
            new CqlCode("AFT", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("AFT.early", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("AFT.late", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("EVE", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("EVE.early", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("EVE.late", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("MORN", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("MORN.early", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("MORN.late", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("NIGHT", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("NOON", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("PHS", "http://hl7.org/fhir/event-timing", default, default),
        ];

        return nzze_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "ErrorLevel")]
    public string ErrorLevel(CqlContext context)
    {
        object nzzf_ = context.ResolveParameter("CumulativeMedicationDurationFHIR4-1.0.000", "ErrorLevel", "Warning");

        return (string)nzzf_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> nzzg_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient nzzh_ = context.Operators.SingletonFrom<Patient>(nzzg_);

        return nzzh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public decimal? ToDaily(CqlContext context, int? frequency, CqlQuantity period)
    {
        decimal? nzzi_()
        {
            bool nzzj_()
            {
                string ozze_ = period?.unit;
                bool? ozzf_ = context.Operators.Equal(ozze_, "h");

                return ozzf_ ?? false;
            };
            bool nzzk_()
            {
                string ozzg_ = period?.unit;
                bool? ozzh_ = context.Operators.Equal(ozzg_, "min");

                return ozzh_ ?? false;
            };
            bool nzzl_()
            {
                string ozzi_ = period?.unit;
                bool? ozzj_ = context.Operators.Equal(ozzi_, "s");

                return ozzj_ ?? false;
            };
            bool nzzm_()
            {
                string ozzk_ = period?.unit;
                bool? ozzl_ = context.Operators.Equal(ozzk_, "d");

                return ozzl_ ?? false;
            };
            bool nzzn_()
            {
                string ozzm_ = period?.unit;
                bool? ozzn_ = context.Operators.Equal(ozzm_, "wk");

                return ozzn_ ?? false;
            };
            bool nzzo_()
            {
                string ozzo_ = period?.unit;
                bool? ozzp_ = context.Operators.Equal(ozzo_, "mo");

                return ozzp_ ?? false;
            };
            bool nzzp_()
            {
                string ozzq_ = period?.unit;
                bool? ozzr_ = context.Operators.Equal(ozzq_, "a");

                return ozzr_ ?? false;
            };
            bool nzzq_()
            {
                string ozzs_ = period?.unit;
                bool? ozzt_ = context.Operators.Equal(ozzs_, "hour");

                return ozzt_ ?? false;
            };
            bool nzzr_()
            {
                string ozzu_ = period?.unit;
                bool? ozzv_ = context.Operators.Equal(ozzu_, "minute");

                return ozzv_ ?? false;
            };
            bool nzzs_()
            {
                string ozzw_ = period?.unit;
                bool? ozzx_ = context.Operators.Equal(ozzw_, "second");

                return ozzx_ ?? false;
            };
            bool nzzt_()
            {
                string ozzy_ = period?.unit;
                bool? ozzz_ = context.Operators.Equal(ozzy_, "day");

                return ozzz_ ?? false;
            };
            bool nzzu_()
            {
                string pzza_ = period?.unit;
                bool? pzzb_ = context.Operators.Equal(pzza_, "week");

                return pzzb_ ?? false;
            };
            bool nzzv_()
            {
                string pzzc_ = period?.unit;
                bool? pzzd_ = context.Operators.Equal(pzzc_, "month");

                return pzzd_ ?? false;
            };
            bool nzzw_()
            {
                string pzze_ = period?.unit;
                bool? pzzf_ = context.Operators.Equal(pzze_, "year");

                return pzzf_ ?? false;
            };
            bool nzzx_()
            {
                string pzzg_ = period?.unit;
                bool? pzzh_ = context.Operators.Equal(pzzg_, "hours");

                return pzzh_ ?? false;
            };
            bool nzzy_()
            {
                string pzzi_ = period?.unit;
                bool? pzzj_ = context.Operators.Equal(pzzi_, "minutes");

                return pzzj_ ?? false;
            };
            bool nzzz_()
            {
                string pzzk_ = period?.unit;
                bool? pzzl_ = context.Operators.Equal(pzzk_, "seconds");

                return pzzl_ ?? false;
            };
            bool ozza_()
            {
                string pzzm_ = period?.unit;
                bool? pzzn_ = context.Operators.Equal(pzzm_, "days");

                return pzzn_ ?? false;
            };
            bool ozzb_()
            {
                string pzzo_ = period?.unit;
                bool? pzzp_ = context.Operators.Equal(pzzo_, "weeks");

                return pzzp_ ?? false;
            };
            bool ozzc_()
            {
                string pzzq_ = period?.unit;
                bool? pzzr_ = context.Operators.Equal(pzzq_, "months");

                return pzzr_ ?? false;
            };
            bool ozzd_()
            {
                string pzzs_ = period?.unit;
                bool? pzzt_ = context.Operators.Equal(pzzs_, "years");

                return pzzt_ ?? false;
            };
            if (nzzj_())
            {
                decimal? pzzu_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? pzzv_ = period?.value;
                decimal? pzzw_ = context.Operators.Divide(24.0m, pzzv_);
                decimal? pzzx_ = context.Operators.Multiply(pzzu_, pzzw_);

                return pzzx_;
            }
            else if (nzzk_())
            {
                decimal? pzzy_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? pzzz_ = period?.value;
                decimal? qzza_ = context.Operators.Divide(24.0m, pzzz_);
                decimal? qzzb_ = context.Operators.Multiply(pzzy_, qzza_);
                decimal? qzzc_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? qzzd_ = context.Operators.Multiply(qzzb_, qzzc_);

                return qzzd_;
            }
            else if (nzzl_())
            {
                decimal? qzze_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? qzzf_ = period?.value;
                decimal? qzzg_ = context.Operators.Divide(24.0m, qzzf_);
                decimal? qzzh_ = context.Operators.Multiply(qzze_, qzzg_);
                decimal? qzzi_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? qzzj_ = context.Operators.Multiply(qzzh_, qzzi_);
                decimal? qzzl_ = context.Operators.Multiply(qzzj_, qzzi_);

                return qzzl_;
            }
            else if (nzzm_())
            {
                decimal? qzzm_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? qzzn_ = period?.value;
                decimal? qzzo_ = context.Operators.Divide(24.0m, qzzn_);
                decimal? qzzp_ = context.Operators.Multiply(qzzm_, qzzo_);
                decimal? qzzq_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? qzzr_ = context.Operators.Divide(qzzp_, qzzq_);

                return qzzr_;
            }
            else if (nzzn_())
            {
                decimal? qzzs_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? qzzt_ = period?.value;
                decimal? qzzu_ = context.Operators.Divide(24.0m, qzzt_);
                decimal? qzzv_ = context.Operators.Multiply(qzzs_, qzzu_);
                int? qzzw_ = context.Operators.Multiply(24, 7);
                decimal? qzzx_ = context.Operators.ConvertIntegerToDecimal(qzzw_);
                decimal? qzzy_ = context.Operators.Divide(qzzv_, qzzx_);

                return qzzy_;
            }
            else if (nzzo_())
            {
                decimal? qzzz_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? rzza_ = period?.value;
                decimal? rzzb_ = context.Operators.Divide(24.0m, rzza_);
                decimal? rzzc_ = context.Operators.Multiply(qzzz_, rzzb_);
                int? rzzd_ = context.Operators.Multiply(24, 30);
                decimal? rzze_ = context.Operators.ConvertIntegerToDecimal(rzzd_);
                decimal? rzzf_ = context.Operators.Divide(rzzc_, rzze_);

                return rzzf_;
            }
            else if (nzzp_())
            {
                decimal? rzzg_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? rzzh_ = period?.value;
                decimal? rzzi_ = context.Operators.Divide(24.0m, rzzh_);
                decimal? rzzj_ = context.Operators.Multiply(rzzg_, rzzi_);
                int? rzzk_ = context.Operators.Multiply(24, 365);
                decimal? rzzl_ = context.Operators.ConvertIntegerToDecimal(rzzk_);
                decimal? rzzm_ = context.Operators.Divide(rzzj_, rzzl_);

                return rzzm_;
            }
            else if (nzzq_())
            {
                decimal? rzzn_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? rzzo_ = period?.value;
                decimal? rzzp_ = context.Operators.Divide(24.0m, rzzo_);
                decimal? rzzq_ = context.Operators.Multiply(rzzn_, rzzp_);

                return rzzq_;
            }
            else if (nzzr_())
            {
                decimal? rzzr_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? rzzs_ = period?.value;
                decimal? rzzt_ = context.Operators.Divide(24.0m, rzzs_);
                decimal? rzzu_ = context.Operators.Multiply(rzzr_, rzzt_);
                decimal? rzzv_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? rzzw_ = context.Operators.Multiply(rzzu_, rzzv_);

                return rzzw_;
            }
            else if (nzzs_())
            {
                decimal? rzzx_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? rzzy_ = period?.value;
                decimal? rzzz_ = context.Operators.Divide(24.0m, rzzy_);
                decimal? szza_ = context.Operators.Multiply(rzzx_, rzzz_);
                decimal? szzb_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? szzc_ = context.Operators.Multiply(szza_, szzb_);
                decimal? szze_ = context.Operators.Multiply(szzc_, szzb_);

                return szze_;
            }
            else if (nzzt_())
            {
                decimal? szzf_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? szzg_ = period?.value;
                decimal? szzh_ = context.Operators.Divide(24.0m, szzg_);
                decimal? szzi_ = context.Operators.Multiply(szzf_, szzh_);
                decimal? szzj_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? szzk_ = context.Operators.Divide(szzi_, szzj_);

                return szzk_;
            }
            else if (nzzu_())
            {
                decimal? szzl_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? szzm_ = period?.value;
                decimal? szzn_ = context.Operators.Divide(24.0m, szzm_);
                decimal? szzo_ = context.Operators.Multiply(szzl_, szzn_);
                int? szzp_ = context.Operators.Multiply(24, 7);
                decimal? szzq_ = context.Operators.ConvertIntegerToDecimal(szzp_);
                decimal? szzr_ = context.Operators.Divide(szzo_, szzq_);

                return szzr_;
            }
            else if (nzzv_())
            {
                decimal? szzs_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? szzt_ = period?.value;
                decimal? szzu_ = context.Operators.Divide(24.0m, szzt_);
                decimal? szzv_ = context.Operators.Multiply(szzs_, szzu_);
                int? szzw_ = context.Operators.Multiply(24, 30);
                decimal? szzx_ = context.Operators.ConvertIntegerToDecimal(szzw_);
                decimal? szzy_ = context.Operators.Divide(szzv_, szzx_);

                return szzy_;
            }
            else if (nzzw_())
            {
                decimal? szzz_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? tzza_ = period?.value;
                decimal? tzzb_ = context.Operators.Divide(24.0m, tzza_);
                decimal? tzzc_ = context.Operators.Multiply(szzz_, tzzb_);
                int? tzzd_ = context.Operators.Multiply(24, 365);
                decimal? tzze_ = context.Operators.ConvertIntegerToDecimal(tzzd_);
                decimal? tzzf_ = context.Operators.Divide(tzzc_, tzze_);

                return tzzf_;
            }
            else if (nzzx_())
            {
                decimal? tzzg_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? tzzh_ = period?.value;
                decimal? tzzi_ = context.Operators.Divide(24.0m, tzzh_);
                decimal? tzzj_ = context.Operators.Multiply(tzzg_, tzzi_);

                return tzzj_;
            }
            else if (nzzy_())
            {
                decimal? tzzk_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? tzzl_ = period?.value;
                decimal? tzzm_ = context.Operators.Divide(24.0m, tzzl_);
                decimal? tzzn_ = context.Operators.Multiply(tzzk_, tzzm_);
                decimal? tzzo_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? tzzp_ = context.Operators.Multiply(tzzn_, tzzo_);

                return tzzp_;
            }
            else if (nzzz_())
            {
                decimal? tzzq_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? tzzr_ = period?.value;
                decimal? tzzs_ = context.Operators.Divide(24.0m, tzzr_);
                decimal? tzzt_ = context.Operators.Multiply(tzzq_, tzzs_);
                decimal? tzzu_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? tzzv_ = context.Operators.Multiply(tzzt_, tzzu_);
                decimal? tzzx_ = context.Operators.Multiply(tzzv_, tzzu_);

                return tzzx_;
            }
            else if (ozza_())
            {
                decimal? tzzy_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? tzzz_ = period?.value;
                decimal? uzza_ = context.Operators.Divide(24.0m, tzzz_);
                decimal? uzzb_ = context.Operators.Multiply(tzzy_, uzza_);
                decimal? uzzc_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? uzzd_ = context.Operators.Divide(uzzb_, uzzc_);

                return uzzd_;
            }
            else if (ozzb_())
            {
                decimal? uzze_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? uzzf_ = period?.value;
                decimal? uzzg_ = context.Operators.Divide(24.0m, uzzf_);
                decimal? uzzh_ = context.Operators.Multiply(uzze_, uzzg_);
                int? uzzi_ = context.Operators.Multiply(24, 7);
                decimal? uzzj_ = context.Operators.ConvertIntegerToDecimal(uzzi_);
                decimal? uzzk_ = context.Operators.Divide(uzzh_, uzzj_);

                return uzzk_;
            }
            else if (ozzc_())
            {
                decimal? uzzl_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? uzzm_ = period?.value;
                decimal? uzzn_ = context.Operators.Divide(24.0m, uzzm_);
                decimal? uzzo_ = context.Operators.Multiply(uzzl_, uzzn_);
                int? uzzp_ = context.Operators.Multiply(24, 30);
                decimal? uzzq_ = context.Operators.ConvertIntegerToDecimal(uzzp_);
                decimal? uzzr_ = context.Operators.Divide(uzzo_, uzzq_);

                return uzzr_;
            }
            else if (ozzd_())
            {
                decimal? uzzs_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? uzzt_ = period?.value;
                decimal? uzzu_ = context.Operators.Divide(24.0m, uzzt_);
                decimal? uzzv_ = context.Operators.Multiply(uzzs_, uzzu_);
                int? uzzw_ = context.Operators.Multiply(24, 365);
                decimal? uzzx_ = context.Operators.ConvertIntegerToDecimal(uzzw_);
                decimal? uzzy_ = context.Operators.Divide(uzzv_, uzzx_);

                return uzzy_;
            }
            else
            {
                string uzzz_ = this.ErrorLevel(context);
                string vzza_ = period?.unit;
                string vzzb_ = context.Operators.Concatenate("Unknown unit ", vzza_ ?? "");
                object vzzc_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownUnit", uzzz_, vzzb_);

                return vzzc_ as decimal?;
            }
        };

        return nzzi_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public decimal? ToDaily(CqlContext context, CqlCode frequency)
    {
        decimal? vzzd_()
        {
            bool vzze_()
            {
                CqlCode vzzf_ = this.C(context);
                bool? vzzg_ = context.Operators.Equal(frequency, vzzf_);

                return vzzg_ ?? false;
            };
            if (vzze_())
            {
                return 3.0m;
            }
            else
            {
                string vzzh_ = this.ErrorLevel(context);
                string vzzi_ = frequency?.code;
                string vzzj_ = context.Operators.Concatenate("Unknown frequency code ", vzzi_ ?? "");
                object vzzk_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownFrequencyCode", vzzh_, vzzj_);

                return vzzk_ as decimal?;
            }
        };

        return vzzd_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDateTime> MedicationRequestPeriod(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] vzzl_ = [
            Request,
        ];
        CqlInterval<CqlDateTime> vzzm_(MedicationRequest R)
        {
            CqlInterval<CqlDateTime> vzzq_()
            {
                bool vzzr_()
                {
                    List<Dosage> vzzs_ = R?.DosageInstruction;
                    Dosage vzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzs_);
                    Timing vzzu_ = vzzt_?.Timing;
                    Timing.RepeatComponent vzzv_ = vzzu_?.Repeat;
                    DataType vzzw_ = vzzv_?.Bounds;
                    CqlInterval<CqlDateTime> vzzx_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, vzzw_ as Period);
                    CqlDateTime vzzy_ = context.Operators.End(vzzx_);
                    Dosage wzza_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzs_);
                    Timing wzzb_ = wzza_?.Timing;
                    Timing.RepeatComponent wzzc_ = wzzb_?.Repeat;
                    DataType wzzd_ = wzzc_?.Bounds;
                    CqlInterval<CqlDateTime> wzze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, wzzd_ as Period);
                    CqlDateTime wzzf_ = context.Operators.End(wzze_);
                    CqlDateTime wzzg_ = context.Operators.MaxValue<CqlDateTime>();
                    bool? wzzh_ = context.Operators.Equal(wzzf_, wzzg_);
                    bool? wzzi_ = context.Operators.Or((bool?)(vzzy_ is null), wzzh_);
                    bool? wzzj_ = context.Operators.Not(wzzi_);

                    return wzzj_ ?? false;
                };
                if (vzzr_())
                {
                    List<Dosage> wzzk_ = R?.DosageInstruction;
                    Dosage wzzl_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)wzzk_);
                    Timing wzzm_ = wzzl_?.Timing;
                    Timing.RepeatComponent wzzn_ = wzzm_?.Repeat;
                    DataType wzzo_ = wzzn_?.Bounds;
                    CqlInterval<CqlDateTime> wzzp_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, wzzo_ as Period);
                    CqlDateTime wzzq_ = context.Operators.Start(wzzp_);
                    MedicationRequest.DispenseRequestComponent wzzr_ = R?.DispenseRequest;
                    Period wzzs_ = wzzr_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> wzzt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, wzzs_);
                    CqlDateTime wzzu_ = context.Operators.Start(wzzt_);
                    FhirDateTime wzzv_ = R?.AuthoredOnElement;
                    CqlDateTime wzzw_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, wzzv_);
                    Dosage wzzy_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)wzzk_);
                    Timing wzzz_ = wzzy_?.Timing;
                    Timing.RepeatComponent xzza_ = wzzz_?.Repeat;
                    DataType xzzb_ = xzza_?.Bounds;
                    CqlInterval<CqlDateTime> xzzc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xzzb_ as Period);
                    CqlDateTime xzzd_ = context.Operators.End(xzzc_);
                    CqlInterval<CqlDateTime> xzze_ = context.Operators.Interval((wzzq_ ?? wzzu_) ?? wzzw_, xzzd_, true, true);

                    return xzze_;
                }
                else
                {
                    List<Dosage> xzzf_ = R?.DosageInstruction;
                    Dosage xzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzf_);
                    Timing xzzh_ = xzzg_?.Timing;
                    Timing.RepeatComponent xzzi_ = xzzh_?.Repeat;
                    DataType xzzj_ = xzzi_?.Bounds;
                    CqlInterval<CqlDateTime> xzzk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xzzj_ as Period);
                    CqlDateTime xzzl_ = context.Operators.Start(xzzk_);
                    MedicationRequest.DispenseRequestComponent xzzm_ = R?.DispenseRequest;
                    Period xzzn_ = xzzm_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> xzzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xzzn_);
                    CqlDateTime xzzp_ = context.Operators.Start(xzzo_);
                    FhirDateTime xzzq_ = R?.AuthoredOnElement;
                    CqlDateTime xzzr_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, xzzq_);
                    Dosage xzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzf_);
                    Timing xzzu_ = xzzt_?.Timing;
                    Timing.RepeatComponent xzzv_ = xzzu_?.Repeat;
                    DataType xzzw_ = xzzv_?.Bounds;
                    CqlInterval<CqlDateTime> xzzx_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xzzw_ as Period);
                    CqlDateTime xzzy_ = context.Operators.Start(xzzx_);
                    Period yzza_ = xzzm_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> yzzb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yzza_);
                    CqlDateTime yzzc_ = context.Operators.Start(yzzb_);
                    CqlDateTime yzze_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, xzzq_);
                    Duration yzzg_ = xzzm_?.ExpectedSupplyDuration;
                    CqlQuantity yzzh_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, yzzg_);
                    Quantity yzzj_ = xzzm_?.Quantity;
                    CqlQuantity yzzk_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, yzzj_);
                    Dosage yzzm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzf_);
                    List<Dosage.DoseAndRateComponent> yzzn_ = yzzm_?.DoseAndRate;
                    Dosage.DoseAndRateComponent yzzo_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)yzzn_);
                    DataType yzzp_ = yzzo_?.Dose;
                    CqlInterval<CqlQuantity> yzzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yzzp_ as Range);
                    CqlQuantity yzzr_ = context.Operators.End(yzzq_);
                    Dosage yzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzf_);
                    List<Dosage.DoseAndRateComponent> yzzu_ = yzzt_?.DoseAndRate;
                    Dosage.DoseAndRateComponent yzzv_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)yzzu_);
                    DataType yzzw_ = yzzv_?.Dose;
                    CqlQuantity yzzx_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, yzzw_ as Quantity);
                    Dosage yzzz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzf_);
                    Timing zzza_ = yzzz_?.Timing;
                    Timing.RepeatComponent zzzb_ = zzza_?.Repeat;
                    PositiveInt zzzc_ = zzzb_?.FrequencyMaxElement;
                    Integer zzzd_ = context.Operators.Convert<Integer>(zzzc_);
                    Dosage zzzf_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzf_);
                    Timing zzzg_ = zzzf_?.Timing;
                    Timing.RepeatComponent zzzh_ = zzzg_?.Repeat;
                    PositiveInt zzzi_ = zzzh_?.FrequencyElement;
                    Integer zzzj_ = context.Operators.Convert<Integer>(zzzi_);
                    int? zzzk_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, zzzd_ ?? zzzj_);
                    Dosage zzzm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzf_);
                    Timing zzzn_ = zzzm_?.Timing;
                    Timing.RepeatComponent zzzo_ = zzzn_?.Repeat;
                    FhirDecimal zzzp_ = zzzo_?.PeriodElement;
                    decimal? zzzq_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, zzzp_);
                    Dosage zzzs_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzf_);
                    Timing zzzt_ = zzzs_?.Timing;
                    Timing.RepeatComponent zzzu_ = zzzt_?.Repeat;
                    Code<Timing.UnitsOfTime> zzzv_ = zzzu_?.PeriodUnitElement;
                    Timing.UnitsOfTime? zzzw_ = zzzv_?.Value;
                    string zzzx_ = context.Operators.Convert<string>(zzzw_);
                    decimal? zzzy_ = this.ToDaily(context, zzzk_, new CqlQuantity(zzzq_, zzzx_));
                    Dosage azzza_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzf_);
                    Timing azzzb_ = azzza_?.Timing;
                    Timing.RepeatComponent azzzc_ = azzzb_?.Repeat;
                    List<Time> azzzd_ = azzzc_?.TimeOfDayElement;
                    int? azzze_ = context.Operators.Count<Time>((IEnumerable<Time>)azzzd_);
                    decimal? azzzf_ = context.Operators.ConvertIntegerToDecimal(azzze_);
                    CqlQuantity azzzg_ = context.Operators.ConvertDecimalToQuantity((zzzy_ ?? azzzf_) ?? 1.0m);
                    CqlQuantity azzzh_ = context.Operators.Multiply(yzzr_ ?? yzzx_, azzzg_);
                    CqlQuantity azzzi_ = context.Operators.Divide(yzzk_, azzzh_);
                    UnsignedInt azzzk_ = xzzm_?.NumberOfRepeatsAllowedElement;
                    Integer azzzl_ = context.Operators.Convert<Integer>(azzzk_);
                    int? azzzm_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, azzzl_);
                    int? azzzn_ = context.Operators.Add(1, azzzm_ ?? 0);
                    CqlQuantity azzzo_ = context.Operators.ConvertIntegerToQuantity(azzzn_);
                    CqlQuantity azzzp_ = context.Operators.Multiply(yzzh_ ?? azzzi_, azzzo_);
                    CqlDateTime azzzq_ = context.Operators.Add((xzzy_ ?? yzzc_) ?? yzze_, azzzp_);
                    CqlInterval<CqlDateTime> azzzr_ = context.Operators.Interval((xzzl_ ?? xzzp_) ?? xzzr_, azzzq_, true, true);

                    return azzzr_;
                }
            };

            return vzzq_();
        };
        IEnumerable<CqlInterval<CqlDateTime>> vzzn_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDateTime>>((IEnumerable<MedicationRequest>)vzzl_, vzzm_);
        IEnumerable<CqlInterval<CqlDateTime>> vzzo_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(vzzn_);
        CqlInterval<CqlDateTime> vzzp_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(vzzo_);

        return vzzp_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDateTime> MedicationDispensePeriod(CqlContext context, MedicationDispense Dispense)
    {
        MedicationDispense[] azzzs_ = [
            Dispense,
        ];
        CqlInterval<CqlDateTime> azzzt_(MedicationDispense D)
        {
            FhirDateTime azzzx_ = D?.WhenHandedOverElement;
            FhirDateTime azzzy_ = D?.WhenPreparedElement;
            CqlDateTime azzzz_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, azzzx_ ?? azzzy_);
            CqlDateTime bzzzc_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, azzzx_ ?? azzzy_);
            Quantity bzzzd_ = D?.DaysSupply;
            CqlQuantity bzzze_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bzzzd_);
            Quantity bzzzf_ = D?.Quantity;
            CqlQuantity bzzzg_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bzzzf_);
            List<Dosage> bzzzh_ = D?.DosageInstruction;
            Dosage bzzzi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzh_);
            List<Dosage.DoseAndRateComponent> bzzzj_ = bzzzi_?.DoseAndRate;
            Dosage.DoseAndRateComponent bzzzk_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)bzzzj_);
            DataType bzzzl_ = bzzzk_?.Dose;
            CqlInterval<CqlQuantity> bzzzm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzl_ as Range);
            CqlQuantity bzzzn_ = context.Operators.End(bzzzm_);
            Dosage bzzzp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzh_);
            List<Dosage.DoseAndRateComponent> bzzzq_ = bzzzp_?.DoseAndRate;
            Dosage.DoseAndRateComponent bzzzr_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)bzzzq_);
            DataType bzzzs_ = bzzzr_?.Dose;
            CqlQuantity bzzzt_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bzzzs_ as Quantity);
            Dosage bzzzv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzh_);
            Timing bzzzw_ = bzzzv_?.Timing;
            Timing.RepeatComponent bzzzx_ = bzzzw_?.Repeat;
            PositiveInt bzzzy_ = bzzzx_?.FrequencyMaxElement;
            Integer bzzzz_ = context.Operators.Convert<Integer>(bzzzy_);
            Dosage czzzb_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzh_);
            Timing czzzc_ = czzzb_?.Timing;
            Timing.RepeatComponent czzzd_ = czzzc_?.Repeat;
            PositiveInt czzze_ = czzzd_?.FrequencyElement;
            Integer czzzf_ = context.Operators.Convert<Integer>(czzze_);
            int? czzzg_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, bzzzz_ ?? czzzf_);
            Dosage czzzi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzh_);
            Timing czzzj_ = czzzi_?.Timing;
            Timing.RepeatComponent czzzk_ = czzzj_?.Repeat;
            FhirDecimal czzzl_ = czzzk_?.PeriodElement;
            decimal? czzzm_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, czzzl_);
            Dosage czzzo_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzh_);
            Timing czzzp_ = czzzo_?.Timing;
            Timing.RepeatComponent czzzq_ = czzzp_?.Repeat;
            Code<Timing.UnitsOfTime> czzzr_ = czzzq_?.PeriodUnitElement;
            Timing.UnitsOfTime? czzzs_ = czzzr_?.Value;
            string czzzt_ = context.Operators.Convert<string>(czzzs_);
            decimal? czzzu_ = this.ToDaily(context, czzzg_, new CqlQuantity(czzzm_, czzzt_));
            Dosage czzzw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzh_);
            Timing czzzx_ = czzzw_?.Timing;
            Timing.RepeatComponent czzzy_ = czzzx_?.Repeat;
            List<Time> czzzz_ = czzzy_?.TimeOfDayElement;
            int? dzzza_ = context.Operators.Count<Time>((IEnumerable<Time>)czzzz_);
            decimal? dzzzb_ = context.Operators.ConvertIntegerToDecimal(dzzza_);
            CqlQuantity dzzzc_ = context.Operators.ConvertDecimalToQuantity((czzzu_ ?? dzzzb_) ?? 1.0m);
            CqlQuantity dzzzd_ = context.Operators.Multiply(bzzzn_ ?? bzzzt_, dzzzc_);
            CqlQuantity dzzze_ = context.Operators.Divide(bzzzg_, dzzzd_);
            CqlDateTime dzzzf_ = context.Operators.Add(bzzzc_, bzzze_ ?? dzzze_);
            CqlInterval<CqlDateTime> dzzzg_ = context.Operators.Interval(azzzz_, dzzzf_, true, true);

            return dzzzg_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> azzzu_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDateTime>>((IEnumerable<MedicationDispense>)azzzs_, azzzt_);
        IEnumerable<CqlInterval<CqlDateTime>> azzzv_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(azzzu_);
        CqlInterval<CqlDateTime> azzzw_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(azzzv_);

        return azzzw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlQuantity TherapeuticDuration(CqlContext context, CqlConcept medication)
    {
        CqlQuantity dzzzh_ = context.Operators.Quantity(14m, "days");

        return dzzzh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDateTime> MedicationAdministrationPeriod(CqlContext context, MedicationAdministration Administration)
    {
        MedicationAdministration[] dzzzi_ = [
            Administration,
        ];
        CqlInterval<CqlDateTime> dzzzj_(MedicationAdministration M)
        {
            CqlInterval<CqlDateTime> dzzzn_()
            {
                bool dzzzo_()
                {
                    DataType dzzzp_ = Administration?.Effective;
                    CqlInterval<CqlDateTime> dzzzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzp_ as Period);
                    CqlDateTime dzzzr_ = context.Operators.Start(dzzzq_);
                    bool? dzzzs_ = context.Operators.Not((bool?)(dzzzr_ is null));
                    DataType dzzzt_ = Administration?.Medication;
                    CqlConcept dzzzu_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, dzzzt_ as CodeableConcept);
                    CqlQuantity dzzzv_ = this.TherapeuticDuration(context, dzzzu_);
                    bool? dzzzw_ = context.Operators.Not((bool?)(dzzzv_ is null));
                    bool? dzzzx_ = context.Operators.And(dzzzs_, dzzzw_);

                    return dzzzx_ ?? false;
                };
                if (dzzzo_())
                {
                    DataType dzzzy_ = Administration?.Effective;
                    CqlInterval<CqlDateTime> dzzzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzy_ as Period);
                    CqlDateTime ezzza_ = context.Operators.Start(dzzzz_);
                    CqlInterval<CqlDateTime> ezzzc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzy_ as Period);
                    CqlDateTime ezzzd_ = context.Operators.Start(ezzzc_);
                    DataType ezzze_ = Administration?.Medication;
                    CqlConcept ezzzf_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ezzze_ as CodeableConcept);
                    CqlQuantity ezzzg_ = this.TherapeuticDuration(context, ezzzf_);
                    CqlDateTime ezzzh_ = context.Operators.Add(ezzzd_, ezzzg_);
                    CqlInterval<CqlDateTime> ezzzi_ = context.Operators.Interval(ezzza_, ezzzh_, true, true);

                    return ezzzi_;
                }
                else
                {
                    return null as CqlInterval<CqlDateTime>;
                }
            };

            return dzzzn_();
        };
        IEnumerable<CqlInterval<CqlDateTime>> dzzzk_ = context.Operators.Select<MedicationAdministration, CqlInterval<CqlDateTime>>((IEnumerable<MedicationAdministration>)dzzzi_, dzzzj_);
        IEnumerable<CqlInterval<CqlDateTime>> dzzzl_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(dzzzk_);
        CqlInterval<CqlDateTime> dzzzm_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(dzzzl_);

        return dzzzm_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? CumulativeDuration(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> Intervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> ezzzj_ = context.Operators.Collapse(Intervals, "day");
        int? ezzzk_(CqlInterval<CqlDateTime> X)
        {
            CqlDateTime ezzzn_ = context.Operators.Start(X);
            CqlDateTime ezzzo_ = context.Operators.End(X);
            int? ezzzp_ = context.Operators.DifferenceBetween(ezzzn_, ezzzo_, "day");

            return ezzzp_;
        };
        IEnumerable<int?> ezzzl_ = context.Operators.Select<CqlInterval<CqlDateTime>, int?>(ezzzj_, ezzzk_);
        int? ezzzm_ = context.Operators.Sum(ezzzl_);

        return ezzzm_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<CqlInterval<CqlDateTime>> RolloutIntervals(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> ezzzq_(IEnumerable<CqlInterval<CqlDateTime>> R, CqlInterval<CqlDateTime> I)
        {
            CqlInterval<CqlDateTime>[] ezzzs_ = [
                I,
            ];
            CqlInterval<CqlDateTime> ezzzt_(CqlInterval<CqlDateTime> X)
            {
                CqlInterval<CqlDateTime> ezzzz_ = context.Operators.Last<CqlInterval<CqlDateTime>>(R);
                CqlDateTime fzzza_ = context.Operators.End(ezzzz_);
                CqlQuantity fzzzb_ = context.Operators.Quantity(1m, "day");
                CqlDateTime fzzzc_ = context.Operators.Add(fzzza_, fzzzb_);
                CqlDateTime fzzzd_ = context.Operators.Start(X);
                CqlDateTime[] fzzze_ = [
                    fzzzc_,
                    fzzzd_,
                ];
                CqlDateTime fzzzf_ = context.Operators.Max<CqlDateTime>(fzzze_ as IEnumerable<CqlDateTime>);
                CqlDateTime fzzzh_ = context.Operators.End(ezzzz_);
                CqlDateTime fzzzj_ = context.Operators.Add(fzzzh_, fzzzb_);
                CqlDateTime[] fzzzl_ = [
                    fzzzj_,
                    fzzzd_,
                ];
                CqlDateTime fzzzm_ = context.Operators.Max<CqlDateTime>(fzzzl_ as IEnumerable<CqlDateTime>);
                CqlDateTime fzzzo_ = context.Operators.End(X);
                int? fzzzp_ = context.Operators.DurationBetween(fzzzd_, fzzzo_, "day");
                decimal? fzzzq_ = context.Operators.ConvertIntegerToDecimal(fzzzp_ ?? 0);
                CqlDateTime fzzzr_ = context.Operators.Add(fzzzm_, new CqlQuantity(fzzzq_, "day"));
                CqlInterval<CqlDateTime> fzzzs_ = context.Operators.Interval(fzzzf_, fzzzr_, true, true);

                return fzzzs_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> ezzzu_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>((IEnumerable<CqlInterval<CqlDateTime>>)ezzzs_, ezzzt_);
            IEnumerable<CqlInterval<CqlDateTime>> ezzzv_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(ezzzu_);
            CqlInterval<CqlDateTime> ezzzw_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(ezzzv_);
            CqlInterval<CqlDateTime>[] ezzzx_ = [
                ezzzw_,
            ];
            IEnumerable<CqlInterval<CqlDateTime>> ezzzy_ = context.Operators.Union<CqlInterval<CqlDateTime>>(R, ezzzx_ as IEnumerable<CqlInterval<CqlDateTime>>);

            return ezzzy_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> ezzzr_ = context.Operators.Aggregate<CqlInterval<CqlDateTime>, IEnumerable<CqlInterval<CqlDateTime>>>(intervals, ezzzq_, null as IEnumerable<CqlInterval<CqlDateTime>>);

        return ezzzr_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDateTime> MedicationPeriod(CqlContext context, object medication)
    {
        CqlInterval<CqlDateTime> fzzzt_()
        {
            if (medication is MedicationRequest)
            {
                CqlInterval<CqlDateTime> fzzzu_ = this.MedicationRequestPeriod(context, medication as MedicationRequest);

                return fzzzu_;
            }
            else if (medication is MedicationDispense)
            {
                CqlInterval<CqlDateTime> fzzzv_ = this.MedicationDispensePeriod(context, medication as MedicationDispense);

                return fzzzv_;
            }
            else if (medication is MedicationAdministration)
            {
                CqlInterval<CqlDateTime> fzzzw_ = this.MedicationAdministrationPeriod(context, medication as MedicationAdministration);

                return fzzzw_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return fzzzt_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? CumulativeMedicationDuration(CqlContext context, IEnumerable<object> Medications)
    {
        bool? fzzzx_(object M)
        {
            bool gzzzk_ = M is MedicationRequest;

            return gzzzk_ as bool?;
        };
        IEnumerable<object> fzzzy_ = context.Operators.Where<object>(Medications, fzzzx_);
        CqlInterval<CqlDateTime> fzzzz_(object M)
        {
            CqlInterval<CqlDateTime> gzzzl_ = this.MedicationPeriod(context, M);

            return gzzzl_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> gzzza_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(fzzzy_, fzzzz_);
        IEnumerable<CqlInterval<CqlDateTime>> gzzzb_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(gzzza_);
        bool? gzzzc_(object M)
        {
            bool gzzzm_ = M is MedicationDispense;
            bool gzzzn_ = M is MedicationAdministration;
            bool? gzzzo_ = context.Operators.Or(gzzzm_ as bool?, gzzzn_ as bool?);

            return gzzzo_;
        };
        IEnumerable<object> gzzzd_ = context.Operators.Where<object>(Medications, gzzzc_);
        CqlInterval<CqlDateTime> gzzze_(object M)
        {
            CqlInterval<CqlDateTime> gzzzp_ = this.MedicationPeriod(context, M);

            return gzzzp_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> gzzzf_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(gzzzd_, gzzze_);
        IEnumerable<CqlInterval<CqlDateTime>> gzzzg_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(gzzzf_);
        IEnumerable<CqlInterval<CqlDateTime>> gzzzh_ = this.RolloutIntervals(context, gzzzg_);
        IEnumerable<CqlInterval<CqlDateTime>> gzzzi_ = context.Operators.Union<CqlInterval<CqlDateTime>>(gzzzb_, gzzzh_);
        int? gzzzj_ = this.CumulativeDuration(context, gzzzi_);

        return gzzzj_;
    }


    #endregion Expressions

}

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

    [CqlCodeDefinition("AC", codeId: "AC", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode AC(CqlContext _) => _AC;
    private static readonly CqlCode _AC = new CqlCode("AC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("ACD", codeId: "ACD", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode ACD(CqlContext _) => _ACD;
    private static readonly CqlCode _ACD = new CqlCode("ACD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("ACM", codeId: "ACM", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode ACM(CqlContext _) => _ACM;
    private static readonly CqlCode _ACM = new CqlCode("ACM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("ACV", codeId: "ACV", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode ACV(CqlContext _) => _ACV;
    private static readonly CqlCode _ACV = new CqlCode("ACV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("AFT", codeId: "AFT", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode AFT(CqlContext _) => _AFT;
    private static readonly CqlCode _AFT = new CqlCode("AFT", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("AFT.early", codeId: "AFT.early", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode AFT_early(CqlContext _) => _AFT_early;
    private static readonly CqlCode _AFT_early = new CqlCode("AFT.early", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("AFT.late", codeId: "AFT.late", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode AFT_late(CqlContext _) => _AFT_late;
    private static readonly CqlCode _AFT_late = new CqlCode("AFT.late", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("C", codeId: "C", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode C(CqlContext _) => _C;
    private static readonly CqlCode _C = new CqlCode("C", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("CD", codeId: "CD", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode CD(CqlContext _) => _CD;
    private static readonly CqlCode _CD = new CqlCode("CD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("CM", codeId: "CM", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode CM(CqlContext _) => _CM;
    private static readonly CqlCode _CM = new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("CV", codeId: "CV", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode CV(CqlContext _) => _CV;
    private static readonly CqlCode _CV = new CqlCode("CV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("EVE", codeId: "EVE", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode EVE(CqlContext _) => _EVE;
    private static readonly CqlCode _EVE = new CqlCode("EVE", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("EVE.early", codeId: "EVE.early", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode EVE_early(CqlContext _) => _EVE_early;
    private static readonly CqlCode _EVE_early = new CqlCode("EVE.early", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("EVE.late", codeId: "EVE.late", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode EVE_late(CqlContext _) => _EVE_late;
    private static readonly CqlCode _EVE_late = new CqlCode("EVE.late", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("HS", codeId: "HS", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode HS(CqlContext _) => _HS;
    private static readonly CqlCode _HS = new CqlCode("HS", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("MORN", codeId: "MORN", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode MORN(CqlContext _) => _MORN;
    private static readonly CqlCode _MORN = new CqlCode("MORN", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("MORN.early", codeId: "MORN.early", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode MORN_early(CqlContext _) => _MORN_early;
    private static readonly CqlCode _MORN_early = new CqlCode("MORN.early", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("MORN.late", codeId: "MORN.late", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode MORN_late(CqlContext _) => _MORN_late;
    private static readonly CqlCode _MORN_late = new CqlCode("MORN.late", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("NIGHT", codeId: "NIGHT", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode NIGHT(CqlContext _) => _NIGHT;
    private static readonly CqlCode _NIGHT = new CqlCode("NIGHT", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("NOON", codeId: "NOON", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode NOON(CqlContext _) => _NOON;
    private static readonly CqlCode _NOON = new CqlCode("NOON", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("PC", codeId: "PC", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode PC(CqlContext _) => _PC;
    private static readonly CqlCode _PC = new CqlCode("PC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("PCD", codeId: "PCD", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode PCD(CqlContext _) => _PCD;
    private static readonly CqlCode _PCD = new CqlCode("PCD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("PCM", codeId: "PCM", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode PCM(CqlContext _) => _PCM;
    private static readonly CqlCode _PCM = new CqlCode("PCM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("PCV", codeId: "PCV", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode PCV(CqlContext _) => _PCV;
    private static readonly CqlCode _PCV = new CqlCode("PCV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("PHS", codeId: "PHS", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode PHS(CqlContext _) => _PHS;
    private static readonly CqlCode _PHS = new CqlCode("PHS", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("WAKE", codeId: "WAKE", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode WAKE(CqlContext _) => _WAKE;
    private static readonly CqlCode _WAKE = new CqlCode("WAKE", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("V3TimingEvent")]
    public CqlCodeSystem V3TimingEvent(CqlContext _) => _V3TimingEvent;
    private static readonly CqlCodeSystem _V3TimingEvent =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, [
          _AC,
          _ACD,
          _ACM,
          _ACV,
          _C,
          _CD,
          _CM,
          _CV,
          _HS,
          _PC,
          _PCD,
          _PCM,
          _PCV,
          _WAKE]);

    [CqlCodeSystemDefinition("EventTiming")]
    public CqlCodeSystem EventTiming(CqlContext _) => _EventTiming;
    private static readonly CqlCodeSystem _EventTiming =
      new CqlCodeSystem("http://hl7.org/fhir/event-timing", null, [
          _AFT,
          _AFT_early,
          _AFT_late,
          _EVE,
          _EVE_early,
          _EVE_late,
          _MORN,
          _MORN_early,
          _MORN_late,
          _NIGHT,
          _NOON,
          _PHS]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("ErrorLevel")]
    public string ErrorLevel(CqlContext context)
    {
        object jzzzr_ = context.ResolveParameter("CumulativeMedicationDurationFHIR4-1.0.000", "ErrorLevel", "Warning");

        return (string)jzzzr_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> jzzzs_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient jzzzt_ = context.Operators.SingletonFrom<Patient>(jzzzs_);

        return jzzzt_;
    }


    [CqlExpressionDefinition("ToDaily")]
    public decimal? ToDaily(CqlContext context, int? frequency, CqlQuantity period)
    {
        decimal? jzzzu_()
        {
            bool jzzzv_()
            {
                string kzzzq_ = period?.unit;
                bool? kzzzr_ = context.Operators.Equal(kzzzq_, "h");

                return kzzzr_ ?? false;
            };
            bool jzzzw_()
            {
                string kzzzs_ = period?.unit;
                bool? kzzzt_ = context.Operators.Equal(kzzzs_, "min");

                return kzzzt_ ?? false;
            };
            bool jzzzx_()
            {
                string kzzzu_ = period?.unit;
                bool? kzzzv_ = context.Operators.Equal(kzzzu_, "s");

                return kzzzv_ ?? false;
            };
            bool jzzzy_()
            {
                string kzzzw_ = period?.unit;
                bool? kzzzx_ = context.Operators.Equal(kzzzw_, "d");

                return kzzzx_ ?? false;
            };
            bool jzzzz_()
            {
                string kzzzy_ = period?.unit;
                bool? kzzzz_ = context.Operators.Equal(kzzzy_, "wk");

                return kzzzz_ ?? false;
            };
            bool kzzza_()
            {
                string lzzza_ = period?.unit;
                bool? lzzzb_ = context.Operators.Equal(lzzza_, "mo");

                return lzzzb_ ?? false;
            };
            bool kzzzb_()
            {
                string lzzzc_ = period?.unit;
                bool? lzzzd_ = context.Operators.Equal(lzzzc_, "a");

                return lzzzd_ ?? false;
            };
            bool kzzzc_()
            {
                string lzzze_ = period?.unit;
                bool? lzzzf_ = context.Operators.Equal(lzzze_, "hour");

                return lzzzf_ ?? false;
            };
            bool kzzzd_()
            {
                string lzzzg_ = period?.unit;
                bool? lzzzh_ = context.Operators.Equal(lzzzg_, "minute");

                return lzzzh_ ?? false;
            };
            bool kzzze_()
            {
                string lzzzi_ = period?.unit;
                bool? lzzzj_ = context.Operators.Equal(lzzzi_, "second");

                return lzzzj_ ?? false;
            };
            bool kzzzf_()
            {
                string lzzzk_ = period?.unit;
                bool? lzzzl_ = context.Operators.Equal(lzzzk_, "day");

                return lzzzl_ ?? false;
            };
            bool kzzzg_()
            {
                string lzzzm_ = period?.unit;
                bool? lzzzn_ = context.Operators.Equal(lzzzm_, "week");

                return lzzzn_ ?? false;
            };
            bool kzzzh_()
            {
                string lzzzo_ = period?.unit;
                bool? lzzzp_ = context.Operators.Equal(lzzzo_, "month");

                return lzzzp_ ?? false;
            };
            bool kzzzi_()
            {
                string lzzzq_ = period?.unit;
                bool? lzzzr_ = context.Operators.Equal(lzzzq_, "year");

                return lzzzr_ ?? false;
            };
            bool kzzzj_()
            {
                string lzzzs_ = period?.unit;
                bool? lzzzt_ = context.Operators.Equal(lzzzs_, "hours");

                return lzzzt_ ?? false;
            };
            bool kzzzk_()
            {
                string lzzzu_ = period?.unit;
                bool? lzzzv_ = context.Operators.Equal(lzzzu_, "minutes");

                return lzzzv_ ?? false;
            };
            bool kzzzl_()
            {
                string lzzzw_ = period?.unit;
                bool? lzzzx_ = context.Operators.Equal(lzzzw_, "seconds");

                return lzzzx_ ?? false;
            };
            bool kzzzm_()
            {
                string lzzzy_ = period?.unit;
                bool? lzzzz_ = context.Operators.Equal(lzzzy_, "days");

                return lzzzz_ ?? false;
            };
            bool kzzzn_()
            {
                string mzzza_ = period?.unit;
                bool? mzzzb_ = context.Operators.Equal(mzzza_, "weeks");

                return mzzzb_ ?? false;
            };
            bool kzzzo_()
            {
                string mzzzc_ = period?.unit;
                bool? mzzzd_ = context.Operators.Equal(mzzzc_, "months");

                return mzzzd_ ?? false;
            };
            bool kzzzp_()
            {
                string mzzze_ = period?.unit;
                bool? mzzzf_ = context.Operators.Equal(mzzze_, "years");

                return mzzzf_ ?? false;
            };
            if (jzzzv_())
            {
                decimal? mzzzg_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? mzzzh_ = period?.value;
                decimal? mzzzi_ = context.Operators.Divide(24.0m, mzzzh_);
                decimal? mzzzj_ = context.Operators.Multiply(mzzzg_, mzzzi_);

                return mzzzj_;
            }
            else if (jzzzw_())
            {
                decimal? mzzzk_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? mzzzl_ = period?.value;
                decimal? mzzzm_ = context.Operators.Divide(24.0m, mzzzl_);
                decimal? mzzzn_ = context.Operators.Multiply(mzzzk_, mzzzm_);
                decimal? mzzzo_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? mzzzp_ = context.Operators.Multiply(mzzzn_, mzzzo_);

                return mzzzp_;
            }
            else if (jzzzx_())
            {
                decimal? mzzzq_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? mzzzr_ = period?.value;
                decimal? mzzzs_ = context.Operators.Divide(24.0m, mzzzr_);
                decimal? mzzzt_ = context.Operators.Multiply(mzzzq_, mzzzs_);
                decimal? mzzzu_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? mzzzv_ = context.Operators.Multiply(mzzzt_, mzzzu_);
                decimal? mzzzx_ = context.Operators.Multiply(mzzzv_, mzzzu_);

                return mzzzx_;
            }
            else if (jzzzy_())
            {
                decimal? mzzzy_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? mzzzz_ = period?.value;
                decimal? nzzza_ = context.Operators.Divide(24.0m, mzzzz_);
                decimal? nzzzb_ = context.Operators.Multiply(mzzzy_, nzzza_);
                decimal? nzzzc_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? nzzzd_ = context.Operators.Divide(nzzzb_, nzzzc_);

                return nzzzd_;
            }
            else if (jzzzz_())
            {
                decimal? nzzze_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? nzzzf_ = period?.value;
                decimal? nzzzg_ = context.Operators.Divide(24.0m, nzzzf_);
                decimal? nzzzh_ = context.Operators.Multiply(nzzze_, nzzzg_);
                int? nzzzi_ = context.Operators.Multiply(24, 7);
                decimal? nzzzj_ = context.Operators.ConvertIntegerToDecimal(nzzzi_);
                decimal? nzzzk_ = context.Operators.Divide(nzzzh_, nzzzj_);

                return nzzzk_;
            }
            else if (kzzza_())
            {
                decimal? nzzzl_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? nzzzm_ = period?.value;
                decimal? nzzzn_ = context.Operators.Divide(24.0m, nzzzm_);
                decimal? nzzzo_ = context.Operators.Multiply(nzzzl_, nzzzn_);
                int? nzzzp_ = context.Operators.Multiply(24, 30);
                decimal? nzzzq_ = context.Operators.ConvertIntegerToDecimal(nzzzp_);
                decimal? nzzzr_ = context.Operators.Divide(nzzzo_, nzzzq_);

                return nzzzr_;
            }
            else if (kzzzb_())
            {
                decimal? nzzzs_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? nzzzt_ = period?.value;
                decimal? nzzzu_ = context.Operators.Divide(24.0m, nzzzt_);
                decimal? nzzzv_ = context.Operators.Multiply(nzzzs_, nzzzu_);
                int? nzzzw_ = context.Operators.Multiply(24, 365);
                decimal? nzzzx_ = context.Operators.ConvertIntegerToDecimal(nzzzw_);
                decimal? nzzzy_ = context.Operators.Divide(nzzzv_, nzzzx_);

                return nzzzy_;
            }
            else if (kzzzc_())
            {
                decimal? nzzzz_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ozzza_ = period?.value;
                decimal? ozzzb_ = context.Operators.Divide(24.0m, ozzza_);
                decimal? ozzzc_ = context.Operators.Multiply(nzzzz_, ozzzb_);

                return ozzzc_;
            }
            else if (kzzzd_())
            {
                decimal? ozzzd_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ozzze_ = period?.value;
                decimal? ozzzf_ = context.Operators.Divide(24.0m, ozzze_);
                decimal? ozzzg_ = context.Operators.Multiply(ozzzd_, ozzzf_);
                decimal? ozzzh_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? ozzzi_ = context.Operators.Multiply(ozzzg_, ozzzh_);

                return ozzzi_;
            }
            else if (kzzze_())
            {
                decimal? ozzzj_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ozzzk_ = period?.value;
                decimal? ozzzl_ = context.Operators.Divide(24.0m, ozzzk_);
                decimal? ozzzm_ = context.Operators.Multiply(ozzzj_, ozzzl_);
                decimal? ozzzn_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? ozzzo_ = context.Operators.Multiply(ozzzm_, ozzzn_);
                decimal? ozzzq_ = context.Operators.Multiply(ozzzo_, ozzzn_);

                return ozzzq_;
            }
            else if (kzzzf_())
            {
                decimal? ozzzr_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ozzzs_ = period?.value;
                decimal? ozzzt_ = context.Operators.Divide(24.0m, ozzzs_);
                decimal? ozzzu_ = context.Operators.Multiply(ozzzr_, ozzzt_);
                decimal? ozzzv_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? ozzzw_ = context.Operators.Divide(ozzzu_, ozzzv_);

                return ozzzw_;
            }
            else if (kzzzg_())
            {
                decimal? ozzzx_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ozzzy_ = period?.value;
                decimal? ozzzz_ = context.Operators.Divide(24.0m, ozzzy_);
                decimal? pzzza_ = context.Operators.Multiply(ozzzx_, ozzzz_);
                int? pzzzb_ = context.Operators.Multiply(24, 7);
                decimal? pzzzc_ = context.Operators.ConvertIntegerToDecimal(pzzzb_);
                decimal? pzzzd_ = context.Operators.Divide(pzzza_, pzzzc_);

                return pzzzd_;
            }
            else if (kzzzh_())
            {
                decimal? pzzze_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? pzzzf_ = period?.value;
                decimal? pzzzg_ = context.Operators.Divide(24.0m, pzzzf_);
                decimal? pzzzh_ = context.Operators.Multiply(pzzze_, pzzzg_);
                int? pzzzi_ = context.Operators.Multiply(24, 30);
                decimal? pzzzj_ = context.Operators.ConvertIntegerToDecimal(pzzzi_);
                decimal? pzzzk_ = context.Operators.Divide(pzzzh_, pzzzj_);

                return pzzzk_;
            }
            else if (kzzzi_())
            {
                decimal? pzzzl_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? pzzzm_ = period?.value;
                decimal? pzzzn_ = context.Operators.Divide(24.0m, pzzzm_);
                decimal? pzzzo_ = context.Operators.Multiply(pzzzl_, pzzzn_);
                int? pzzzp_ = context.Operators.Multiply(24, 365);
                decimal? pzzzq_ = context.Operators.ConvertIntegerToDecimal(pzzzp_);
                decimal? pzzzr_ = context.Operators.Divide(pzzzo_, pzzzq_);

                return pzzzr_;
            }
            else if (kzzzj_())
            {
                decimal? pzzzs_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? pzzzt_ = period?.value;
                decimal? pzzzu_ = context.Operators.Divide(24.0m, pzzzt_);
                decimal? pzzzv_ = context.Operators.Multiply(pzzzs_, pzzzu_);

                return pzzzv_;
            }
            else if (kzzzk_())
            {
                decimal? pzzzw_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? pzzzx_ = period?.value;
                decimal? pzzzy_ = context.Operators.Divide(24.0m, pzzzx_);
                decimal? pzzzz_ = context.Operators.Multiply(pzzzw_, pzzzy_);
                decimal? qzzza_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? qzzzb_ = context.Operators.Multiply(pzzzz_, qzzza_);

                return qzzzb_;
            }
            else if (kzzzl_())
            {
                decimal? qzzzc_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? qzzzd_ = period?.value;
                decimal? qzzze_ = context.Operators.Divide(24.0m, qzzzd_);
                decimal? qzzzf_ = context.Operators.Multiply(qzzzc_, qzzze_);
                decimal? qzzzg_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? qzzzh_ = context.Operators.Multiply(qzzzf_, qzzzg_);
                decimal? qzzzj_ = context.Operators.Multiply(qzzzh_, qzzzg_);

                return qzzzj_;
            }
            else if (kzzzm_())
            {
                decimal? qzzzk_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? qzzzl_ = period?.value;
                decimal? qzzzm_ = context.Operators.Divide(24.0m, qzzzl_);
                decimal? qzzzn_ = context.Operators.Multiply(qzzzk_, qzzzm_);
                decimal? qzzzo_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? qzzzp_ = context.Operators.Divide(qzzzn_, qzzzo_);

                return qzzzp_;
            }
            else if (kzzzn_())
            {
                decimal? qzzzq_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? qzzzr_ = period?.value;
                decimal? qzzzs_ = context.Operators.Divide(24.0m, qzzzr_);
                decimal? qzzzt_ = context.Operators.Multiply(qzzzq_, qzzzs_);
                int? qzzzu_ = context.Operators.Multiply(24, 7);
                decimal? qzzzv_ = context.Operators.ConvertIntegerToDecimal(qzzzu_);
                decimal? qzzzw_ = context.Operators.Divide(qzzzt_, qzzzv_);

                return qzzzw_;
            }
            else if (kzzzo_())
            {
                decimal? qzzzx_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? qzzzy_ = period?.value;
                decimal? qzzzz_ = context.Operators.Divide(24.0m, qzzzy_);
                decimal? rzzza_ = context.Operators.Multiply(qzzzx_, qzzzz_);
                int? rzzzb_ = context.Operators.Multiply(24, 30);
                decimal? rzzzc_ = context.Operators.ConvertIntegerToDecimal(rzzzb_);
                decimal? rzzzd_ = context.Operators.Divide(rzzza_, rzzzc_);

                return rzzzd_;
            }
            else if (kzzzp_())
            {
                decimal? rzzze_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? rzzzf_ = period?.value;
                decimal? rzzzg_ = context.Operators.Divide(24.0m, rzzzf_);
                decimal? rzzzh_ = context.Operators.Multiply(rzzze_, rzzzg_);
                int? rzzzi_ = context.Operators.Multiply(24, 365);
                decimal? rzzzj_ = context.Operators.ConvertIntegerToDecimal(rzzzi_);
                decimal? rzzzk_ = context.Operators.Divide(rzzzh_, rzzzj_);

                return rzzzk_;
            }
            else
            {
                string rzzzl_ = this.ErrorLevel(context);
                string rzzzm_ = period?.unit;
                string rzzzn_ = context.Operators.Concatenate("Unknown unit ", rzzzm_ ?? "");
                object rzzzo_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownUnit", rzzzl_, rzzzn_);

                return rzzzo_ as decimal?;
            }
        };

        return jzzzu_();
    }


    [CqlExpressionDefinition("ToDaily")]
    public decimal? ToDaily(CqlContext context, CqlCode frequency)
    {
        decimal? rzzzp_()
        {
            bool rzzzq_()
            {
                CqlCode rzzzr_ = this.C(context);
                bool? rzzzs_ = context.Operators.Equal(frequency, rzzzr_);

                return rzzzs_ ?? false;
            };
            if (rzzzq_())
            {
                return 3.0m;
            }
            else
            {
                string rzzzt_ = this.ErrorLevel(context);
                string rzzzu_ = frequency?.code;
                string rzzzv_ = context.Operators.Concatenate("Unknown frequency code ", rzzzu_ ?? "");
                object rzzzw_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownFrequencyCode", rzzzt_, rzzzv_);

                return rzzzw_ as decimal?;
            }
        };

        return rzzzp_();
    }


    [CqlExpressionDefinition("MedicationRequestPeriod")]
    public CqlInterval<CqlDateTime> MedicationRequestPeriod(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] rzzzx_ = [
            Request,
        ];
        CqlInterval<CqlDateTime> rzzzy_(MedicationRequest R)
        {
            CqlInterval<CqlDateTime> szzzc_()
            {
                bool szzzd_()
                {
                    List<Dosage> szzze_ = R?.DosageInstruction;
                    Dosage szzzf_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)szzze_);
                    Timing szzzg_ = szzzf_?.Timing;
                    Timing.RepeatComponent szzzh_ = szzzg_?.Repeat;
                    DataType szzzi_ = szzzh_?.Bounds;
                    CqlInterval<CqlDateTime> szzzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, szzzi_ as Period);
                    CqlDateTime szzzk_ = context.Operators.End(szzzj_);
                    Dosage szzzm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)szzze_);
                    Timing szzzn_ = szzzm_?.Timing;
                    Timing.RepeatComponent szzzo_ = szzzn_?.Repeat;
                    DataType szzzp_ = szzzo_?.Bounds;
                    CqlInterval<CqlDateTime> szzzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, szzzp_ as Period);
                    CqlDateTime szzzr_ = context.Operators.End(szzzq_);
                    CqlDateTime szzzs_ = context.Operators.MaxValue<CqlDateTime>();
                    bool? szzzt_ = context.Operators.Equal(szzzr_, szzzs_);
                    bool? szzzu_ = context.Operators.Or((bool?)(szzzk_ is null), szzzt_);
                    bool? szzzv_ = context.Operators.Not(szzzu_);

                    return szzzv_ ?? false;
                };
                if (szzzd_())
                {
                    List<Dosage> szzzw_ = R?.DosageInstruction;
                    Dosage szzzx_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)szzzw_);
                    Timing szzzy_ = szzzx_?.Timing;
                    Timing.RepeatComponent szzzz_ = szzzy_?.Repeat;
                    DataType tzzza_ = szzzz_?.Bounds;
                    CqlInterval<CqlDateTime> tzzzb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, tzzza_ as Period);
                    CqlDateTime tzzzc_ = context.Operators.Start(tzzzb_);
                    MedicationRequest.DispenseRequestComponent tzzzd_ = R?.DispenseRequest;
                    Period tzzze_ = tzzzd_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> tzzzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, tzzze_);
                    CqlDateTime tzzzg_ = context.Operators.Start(tzzzf_);
                    FhirDateTime tzzzh_ = R?.AuthoredOnElement;
                    CqlDateTime tzzzi_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, tzzzh_);
                    Dosage tzzzk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)szzzw_);
                    Timing tzzzl_ = tzzzk_?.Timing;
                    Timing.RepeatComponent tzzzm_ = tzzzl_?.Repeat;
                    DataType tzzzn_ = tzzzm_?.Bounds;
                    CqlInterval<CqlDateTime> tzzzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, tzzzn_ as Period);
                    CqlDateTime tzzzp_ = context.Operators.End(tzzzo_);
                    CqlInterval<CqlDateTime> tzzzq_ = context.Operators.Interval((tzzzc_ ?? tzzzg_) ?? tzzzi_, tzzzp_, true, true);

                    return tzzzq_;
                }
                else
                {
                    List<Dosage> tzzzr_ = R?.DosageInstruction;
                    Dosage tzzzs_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)tzzzr_);
                    Timing tzzzt_ = tzzzs_?.Timing;
                    Timing.RepeatComponent tzzzu_ = tzzzt_?.Repeat;
                    DataType tzzzv_ = tzzzu_?.Bounds;
                    CqlInterval<CqlDateTime> tzzzw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, tzzzv_ as Period);
                    CqlDateTime tzzzx_ = context.Operators.Start(tzzzw_);
                    MedicationRequest.DispenseRequestComponent tzzzy_ = R?.DispenseRequest;
                    Period tzzzz_ = tzzzy_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> uzzza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, tzzzz_);
                    CqlDateTime uzzzb_ = context.Operators.Start(uzzza_);
                    FhirDateTime uzzzc_ = R?.AuthoredOnElement;
                    CqlDateTime uzzzd_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, uzzzc_);
                    Dosage uzzzf_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)tzzzr_);
                    Timing uzzzg_ = uzzzf_?.Timing;
                    Timing.RepeatComponent uzzzh_ = uzzzg_?.Repeat;
                    DataType uzzzi_ = uzzzh_?.Bounds;
                    CqlInterval<CqlDateTime> uzzzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, uzzzi_ as Period);
                    CqlDateTime uzzzk_ = context.Operators.Start(uzzzj_);
                    Period uzzzm_ = tzzzy_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> uzzzn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, uzzzm_);
                    CqlDateTime uzzzo_ = context.Operators.Start(uzzzn_);
                    CqlDateTime uzzzq_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, uzzzc_);
                    Duration uzzzs_ = tzzzy_?.ExpectedSupplyDuration;
                    CqlQuantity uzzzt_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, uzzzs_);
                    Quantity uzzzv_ = tzzzy_?.Quantity;
                    CqlQuantity uzzzw_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, uzzzv_);
                    Dosage uzzzy_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)tzzzr_);
                    List<Dosage.DoseAndRateComponent> uzzzz_ = uzzzy_?.DoseAndRate;
                    Dosage.DoseAndRateComponent vzzza_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)uzzzz_);
                    DataType vzzzb_ = vzzza_?.Dose;
                    CqlInterval<CqlQuantity> vzzzc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, vzzzb_ as Range);
                    CqlQuantity vzzzd_ = context.Operators.End(vzzzc_);
                    Dosage vzzzf_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)tzzzr_);
                    List<Dosage.DoseAndRateComponent> vzzzg_ = vzzzf_?.DoseAndRate;
                    Dosage.DoseAndRateComponent vzzzh_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)vzzzg_);
                    DataType vzzzi_ = vzzzh_?.Dose;
                    CqlQuantity vzzzj_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, vzzzi_ as Quantity);
                    Dosage vzzzl_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)tzzzr_);
                    Timing vzzzm_ = vzzzl_?.Timing;
                    Timing.RepeatComponent vzzzn_ = vzzzm_?.Repeat;
                    PositiveInt vzzzo_ = vzzzn_?.FrequencyMaxElement;
                    Integer vzzzp_ = context.Operators.Convert<Integer>(vzzzo_);
                    Dosage vzzzr_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)tzzzr_);
                    Timing vzzzs_ = vzzzr_?.Timing;
                    Timing.RepeatComponent vzzzt_ = vzzzs_?.Repeat;
                    PositiveInt vzzzu_ = vzzzt_?.FrequencyElement;
                    Integer vzzzv_ = context.Operators.Convert<Integer>(vzzzu_);
                    int? vzzzw_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, vzzzp_ ?? vzzzv_);
                    Dosage vzzzy_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)tzzzr_);
                    Timing vzzzz_ = vzzzy_?.Timing;
                    Timing.RepeatComponent wzzza_ = vzzzz_?.Repeat;
                    FhirDecimal wzzzb_ = wzzza_?.PeriodElement;
                    decimal? wzzzc_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, wzzzb_);
                    Dosage wzzze_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)tzzzr_);
                    Timing wzzzf_ = wzzze_?.Timing;
                    Timing.RepeatComponent wzzzg_ = wzzzf_?.Repeat;
                    Code<Timing.UnitsOfTime> wzzzh_ = wzzzg_?.PeriodUnitElement;
                    Timing.UnitsOfTime? wzzzi_ = wzzzh_?.Value;
                    string wzzzj_ = context.Operators.Convert<string>(wzzzi_);
                    decimal? wzzzk_ = this.ToDaily(context, vzzzw_, new CqlQuantity(wzzzc_, wzzzj_));
                    Dosage wzzzm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)tzzzr_);
                    Timing wzzzn_ = wzzzm_?.Timing;
                    Timing.RepeatComponent wzzzo_ = wzzzn_?.Repeat;
                    List<Time> wzzzp_ = wzzzo_?.TimeOfDayElement;
                    int? wzzzq_ = context.Operators.Count<Time>((IEnumerable<Time>)wzzzp_);
                    decimal? wzzzr_ = context.Operators.ConvertIntegerToDecimal(wzzzq_);
                    CqlQuantity wzzzs_ = context.Operators.ConvertDecimalToQuantity((wzzzk_ ?? wzzzr_) ?? 1.0m);
                    CqlQuantity wzzzt_ = context.Operators.Multiply(vzzzd_ ?? vzzzj_, wzzzs_);
                    CqlQuantity wzzzu_ = context.Operators.Divide(uzzzw_, wzzzt_);
                    UnsignedInt wzzzw_ = tzzzy_?.NumberOfRepeatsAllowedElement;
                    Integer wzzzx_ = context.Operators.Convert<Integer>(wzzzw_);
                    int? wzzzy_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, wzzzx_);
                    int? wzzzz_ = context.Operators.Add(1, wzzzy_ ?? 0);
                    CqlQuantity xzzza_ = context.Operators.ConvertIntegerToQuantity(wzzzz_);
                    CqlQuantity xzzzb_ = context.Operators.Multiply(uzzzt_ ?? wzzzu_, xzzza_);
                    CqlDateTime xzzzc_ = context.Operators.Add((uzzzk_ ?? uzzzo_) ?? uzzzq_, xzzzb_);
                    CqlInterval<CqlDateTime> xzzzd_ = context.Operators.Interval((tzzzx_ ?? uzzzb_) ?? uzzzd_, xzzzc_, true, true);

                    return xzzzd_;
                }
            };

            return szzzc_();
        };
        IEnumerable<CqlInterval<CqlDateTime>> rzzzz_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDateTime>>((IEnumerable<MedicationRequest>)rzzzx_, rzzzy_);
        IEnumerable<CqlInterval<CqlDateTime>> szzza_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(rzzzz_);
        CqlInterval<CqlDateTime> szzzb_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(szzza_);

        return szzzb_;
    }


    [CqlExpressionDefinition("MedicationDispensePeriod")]
    public CqlInterval<CqlDateTime> MedicationDispensePeriod(CqlContext context, MedicationDispense Dispense)
    {
        MedicationDispense[] xzzze_ = [
            Dispense,
        ];
        CqlInterval<CqlDateTime> xzzzf_(MedicationDispense D)
        {
            FhirDateTime xzzzj_ = D?.WhenHandedOverElement;
            FhirDateTime xzzzk_ = D?.WhenPreparedElement;
            CqlDateTime xzzzl_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, xzzzj_ ?? xzzzk_);
            CqlDateTime xzzzo_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, xzzzj_ ?? xzzzk_);
            Quantity xzzzp_ = D?.DaysSupply;
            CqlQuantity xzzzq_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, xzzzp_);
            Quantity xzzzr_ = D?.Quantity;
            CqlQuantity xzzzs_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, xzzzr_);
            List<Dosage> xzzzt_ = D?.DosageInstruction;
            Dosage xzzzu_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzt_);
            List<Dosage.DoseAndRateComponent> xzzzv_ = xzzzu_?.DoseAndRate;
            Dosage.DoseAndRateComponent xzzzw_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)xzzzv_);
            DataType xzzzx_ = xzzzw_?.Dose;
            CqlInterval<CqlQuantity> xzzzy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xzzzx_ as Range);
            CqlQuantity xzzzz_ = context.Operators.End(xzzzy_);
            Dosage yzzzb_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzt_);
            List<Dosage.DoseAndRateComponent> yzzzc_ = yzzzb_?.DoseAndRate;
            Dosage.DoseAndRateComponent yzzzd_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)yzzzc_);
            DataType yzzze_ = yzzzd_?.Dose;
            CqlQuantity yzzzf_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, yzzze_ as Quantity);
            Dosage yzzzh_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzt_);
            Timing yzzzi_ = yzzzh_?.Timing;
            Timing.RepeatComponent yzzzj_ = yzzzi_?.Repeat;
            PositiveInt yzzzk_ = yzzzj_?.FrequencyMaxElement;
            Integer yzzzl_ = context.Operators.Convert<Integer>(yzzzk_);
            Dosage yzzzn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzt_);
            Timing yzzzo_ = yzzzn_?.Timing;
            Timing.RepeatComponent yzzzp_ = yzzzo_?.Repeat;
            PositiveInt yzzzq_ = yzzzp_?.FrequencyElement;
            Integer yzzzr_ = context.Operators.Convert<Integer>(yzzzq_);
            int? yzzzs_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, yzzzl_ ?? yzzzr_);
            Dosage yzzzu_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzt_);
            Timing yzzzv_ = yzzzu_?.Timing;
            Timing.RepeatComponent yzzzw_ = yzzzv_?.Repeat;
            FhirDecimal yzzzx_ = yzzzw_?.PeriodElement;
            decimal? yzzzy_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, yzzzx_);
            Dosage zzzza_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzt_);
            Timing zzzzb_ = zzzza_?.Timing;
            Timing.RepeatComponent zzzzc_ = zzzzb_?.Repeat;
            Code<Timing.UnitsOfTime> zzzzd_ = zzzzc_?.PeriodUnitElement;
            Timing.UnitsOfTime? zzzze_ = zzzzd_?.Value;
            string zzzzf_ = context.Operators.Convert<string>(zzzze_);
            decimal? zzzzg_ = this.ToDaily(context, yzzzs_, new CqlQuantity(yzzzy_, zzzzf_));
            Dosage zzzzi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzt_);
            Timing zzzzj_ = zzzzi_?.Timing;
            Timing.RepeatComponent zzzzk_ = zzzzj_?.Repeat;
            List<Time> zzzzl_ = zzzzk_?.TimeOfDayElement;
            int? zzzzm_ = context.Operators.Count<Time>((IEnumerable<Time>)zzzzl_);
            decimal? zzzzn_ = context.Operators.ConvertIntegerToDecimal(zzzzm_);
            CqlQuantity zzzzo_ = context.Operators.ConvertDecimalToQuantity((zzzzg_ ?? zzzzn_) ?? 1.0m);
            CqlQuantity zzzzp_ = context.Operators.Multiply(xzzzz_ ?? yzzzf_, zzzzo_);
            CqlQuantity zzzzq_ = context.Operators.Divide(xzzzs_, zzzzp_);
            CqlDateTime zzzzr_ = context.Operators.Add(xzzzo_, xzzzq_ ?? zzzzq_);
            CqlInterval<CqlDateTime> zzzzs_ = context.Operators.Interval(xzzzl_, zzzzr_, true, true);

            return zzzzs_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> xzzzg_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDateTime>>((IEnumerable<MedicationDispense>)xzzze_, xzzzf_);
        IEnumerable<CqlInterval<CqlDateTime>> xzzzh_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(xzzzg_);
        CqlInterval<CqlDateTime> xzzzi_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(xzzzh_);

        return xzzzi_;
    }


    [CqlExpressionDefinition("TherapeuticDuration")]
    public CqlQuantity TherapeuticDuration(CqlContext context, CqlConcept medication)
    {
        CqlQuantity zzzzt_ = context.Operators.Quantity(14m, "days");

        return zzzzt_;
    }


    [CqlExpressionDefinition("MedicationAdministrationPeriod")]
    public CqlInterval<CqlDateTime> MedicationAdministrationPeriod(CqlContext context, MedicationAdministration Administration)
    {
        MedicationAdministration[] zzzzu_ = [
            Administration,
        ];
        CqlInterval<CqlDateTime> zzzzv_(MedicationAdministration M)
        {
            CqlInterval<CqlDateTime> zzzzz_()
            {
                bool azzzza_()
                {
                    DataType azzzzb_ = Administration?.Effective;
                    CqlInterval<CqlDateTime> azzzzc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azzzzb_ as Period);
                    CqlDateTime azzzzd_ = context.Operators.Start(azzzzc_);
                    bool? azzzze_ = context.Operators.Not((bool?)(azzzzd_ is null));
                    DataType azzzzf_ = Administration?.Medication;
                    CqlConcept azzzzg_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, azzzzf_ as CodeableConcept);
                    CqlQuantity azzzzh_ = this.TherapeuticDuration(context, azzzzg_);
                    bool? azzzzi_ = context.Operators.Not((bool?)(azzzzh_ is null));
                    bool? azzzzj_ = context.Operators.And(azzzze_, azzzzi_);

                    return azzzzj_ ?? false;
                };
                if (azzzza_())
                {
                    DataType azzzzk_ = Administration?.Effective;
                    CqlInterval<CqlDateTime> azzzzl_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azzzzk_ as Period);
                    CqlDateTime azzzzm_ = context.Operators.Start(azzzzl_);
                    CqlInterval<CqlDateTime> azzzzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azzzzk_ as Period);
                    CqlDateTime azzzzp_ = context.Operators.Start(azzzzo_);
                    DataType azzzzq_ = Administration?.Medication;
                    CqlConcept azzzzr_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, azzzzq_ as CodeableConcept);
                    CqlQuantity azzzzs_ = this.TherapeuticDuration(context, azzzzr_);
                    CqlDateTime azzzzt_ = context.Operators.Add(azzzzp_, azzzzs_);
                    CqlInterval<CqlDateTime> azzzzu_ = context.Operators.Interval(azzzzm_, azzzzt_, true, true);

                    return azzzzu_;
                }
                else
                {
                    return null as CqlInterval<CqlDateTime>;
                }
            };

            return zzzzz_();
        };
        IEnumerable<CqlInterval<CqlDateTime>> zzzzw_ = context.Operators.Select<MedicationAdministration, CqlInterval<CqlDateTime>>((IEnumerable<MedicationAdministration>)zzzzu_, zzzzv_);
        IEnumerable<CqlInterval<CqlDateTime>> zzzzx_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(zzzzw_);
        CqlInterval<CqlDateTime> zzzzy_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(zzzzx_);

        return zzzzy_;
    }


    [CqlExpressionDefinition("CumulativeDuration")]
    public int? CumulativeDuration(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> Intervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> azzzzv_ = context.Operators.Collapse(Intervals, "day");
        int? azzzzw_(CqlInterval<CqlDateTime> X)
        {
            CqlDateTime azzzzz_ = context.Operators.Start(X);
            CqlDateTime bzzzza_ = context.Operators.End(X);
            int? bzzzzb_ = context.Operators.DifferenceBetween(azzzzz_, bzzzza_, "day");

            return bzzzzb_;
        };
        IEnumerable<int?> azzzzx_ = context.Operators.Select<CqlInterval<CqlDateTime>, int?>(azzzzv_, azzzzw_);
        int? azzzzy_ = context.Operators.Sum(azzzzx_);

        return azzzzy_;
    }


    [CqlExpressionDefinition("RolloutIntervals")]
    public IEnumerable<CqlInterval<CqlDateTime>> RolloutIntervals(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> bzzzzc_(IEnumerable<CqlInterval<CqlDateTime>> R, CqlInterval<CqlDateTime> I)
        {
            CqlInterval<CqlDateTime>[] bzzzze_ = [
                I,
            ];
            CqlInterval<CqlDateTime> bzzzzf_(CqlInterval<CqlDateTime> X)
            {
                CqlInterval<CqlDateTime> bzzzzl_ = context.Operators.Last<CqlInterval<CqlDateTime>>(R);
                CqlDateTime bzzzzm_ = context.Operators.End(bzzzzl_);
                CqlQuantity bzzzzn_ = context.Operators.Quantity(1m, "day");
                CqlDateTime bzzzzo_ = context.Operators.Add(bzzzzm_, bzzzzn_);
                CqlDateTime bzzzzp_ = context.Operators.Start(X);
                CqlDateTime[] bzzzzq_ = [
                    bzzzzo_,
                    bzzzzp_,
                ];
                CqlDateTime bzzzzr_ = context.Operators.Max<CqlDateTime>(bzzzzq_ as IEnumerable<CqlDateTime>);
                CqlDateTime bzzzzt_ = context.Operators.End(bzzzzl_);
                CqlDateTime bzzzzv_ = context.Operators.Add(bzzzzt_, bzzzzn_);
                CqlDateTime[] bzzzzx_ = [
                    bzzzzv_,
                    bzzzzp_,
                ];
                CqlDateTime bzzzzy_ = context.Operators.Max<CqlDateTime>(bzzzzx_ as IEnumerable<CqlDateTime>);
                CqlDateTime czzzza_ = context.Operators.End(X);
                int? czzzzb_ = context.Operators.DurationBetween(bzzzzp_, czzzza_, "day");
                decimal? czzzzc_ = context.Operators.ConvertIntegerToDecimal(czzzzb_ ?? 0);
                CqlDateTime czzzzd_ = context.Operators.Add(bzzzzy_, new CqlQuantity(czzzzc_, "day"));
                CqlInterval<CqlDateTime> czzzze_ = context.Operators.Interval(bzzzzr_, czzzzd_, true, true);

                return czzzze_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> bzzzzg_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>((IEnumerable<CqlInterval<CqlDateTime>>)bzzzze_, bzzzzf_);
            IEnumerable<CqlInterval<CqlDateTime>> bzzzzh_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(bzzzzg_);
            CqlInterval<CqlDateTime> bzzzzi_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(bzzzzh_);
            CqlInterval<CqlDateTime>[] bzzzzj_ = [
                bzzzzi_,
            ];
            IEnumerable<CqlInterval<CqlDateTime>> bzzzzk_ = context.Operators.Union<CqlInterval<CqlDateTime>>(R, bzzzzj_ as IEnumerable<CqlInterval<CqlDateTime>>);

            return bzzzzk_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> bzzzzd_ = context.Operators.Aggregate<CqlInterval<CqlDateTime>, IEnumerable<CqlInterval<CqlDateTime>>>(intervals, bzzzzc_, null as IEnumerable<CqlInterval<CqlDateTime>>);

        return bzzzzd_;
    }


    [CqlExpressionDefinition("MedicationPeriod")]
    public CqlInterval<CqlDateTime> MedicationPeriod(CqlContext context, object medication)
    {
        CqlInterval<CqlDateTime> czzzzf_()
        {
            if (medication is MedicationRequest)
            {
                CqlInterval<CqlDateTime> czzzzg_ = this.MedicationRequestPeriod(context, medication as MedicationRequest);

                return czzzzg_;
            }
            else if (medication is MedicationDispense)
            {
                CqlInterval<CqlDateTime> czzzzh_ = this.MedicationDispensePeriod(context, medication as MedicationDispense);

                return czzzzh_;
            }
            else if (medication is MedicationAdministration)
            {
                CqlInterval<CqlDateTime> czzzzi_ = this.MedicationAdministrationPeriod(context, medication as MedicationAdministration);

                return czzzzi_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return czzzzf_();
    }


    [CqlExpressionDefinition("CumulativeMedicationDuration")]
    public int? CumulativeMedicationDuration(CqlContext context, IEnumerable<object> Medications)
    {
        bool? czzzzj_(object M)
        {
            bool czzzzw_ = M is MedicationRequest;

            return czzzzw_ as bool?;
        };
        IEnumerable<object> czzzzk_ = context.Operators.Where<object>(Medications, czzzzj_);
        CqlInterval<CqlDateTime> czzzzl_(object M)
        {
            CqlInterval<CqlDateTime> czzzzx_ = this.MedicationPeriod(context, M);

            return czzzzx_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> czzzzm_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(czzzzk_, czzzzl_);
        IEnumerable<CqlInterval<CqlDateTime>> czzzzn_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(czzzzm_);
        bool? czzzzo_(object M)
        {
            bool czzzzy_ = M is MedicationDispense;
            bool czzzzz_ = M is MedicationAdministration;
            bool? dzzzza_ = context.Operators.Or(czzzzy_ as bool?, czzzzz_ as bool?);

            return dzzzza_;
        };
        IEnumerable<object> czzzzp_ = context.Operators.Where<object>(Medications, czzzzo_);
        CqlInterval<CqlDateTime> czzzzq_(object M)
        {
            CqlInterval<CqlDateTime> dzzzzb_ = this.MedicationPeriod(context, M);

            return dzzzzb_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> czzzzr_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(czzzzp_, czzzzq_);
        IEnumerable<CqlInterval<CqlDateTime>> czzzzs_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(czzzzr_);
        IEnumerable<CqlInterval<CqlDateTime>> czzzzt_ = this.RolloutIntervals(context, czzzzs_);
        IEnumerable<CqlInterval<CqlDateTime>> czzzzu_ = context.Operators.Union<CqlInterval<CqlDateTime>>(czzzzn_, czzzzt_);
        int? czzzzv_ = this.CumulativeDuration(context, czzzzu_);

        return czzzzv_;
    }


    #endregion Expressions

}

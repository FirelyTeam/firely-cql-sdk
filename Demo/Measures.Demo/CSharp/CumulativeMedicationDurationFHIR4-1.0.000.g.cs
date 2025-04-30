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
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null,
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
          _WAKE);

    [CqlCodeSystemDefinition("EventTiming")]
    public CqlCodeSystem EventTiming(CqlContext _) => _EventTiming;
    private static readonly CqlCodeSystem _EventTiming =
      new CqlCodeSystem("http://hl7.org/fhir/event-timing", null,
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
          _PHS);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("ErrorLevel")]
    public string ErrorLevel(CqlContext context)
    {
        object yzzzz_ = context.ResolveParameter("CumulativeMedicationDurationFHIR4-1.0.000", "ErrorLevel", "Warning");

        return (string)yzzzz_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> zzzza_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient zzzzb_ = context.Operators.SingletonFrom<Patient>(zzzza_);

        return zzzzb_;
    }


    [CqlExpressionDefinition("ToDaily")]
    public decimal? ToDaily(CqlContext context, int? frequency, CqlQuantity period)
    {
        decimal? zzzzc_()
        {
            bool zzzzd_()
            {
                string zzzzy_ = period?.unit;
                bool? zzzzz_ = context.Operators.Equal(zzzzy_, "h");

                return zzzzz_ ?? false;
            };
            bool zzzze_()
            {
                string azzzza_ = period?.unit;
                bool? azzzzb_ = context.Operators.Equal(azzzza_, "min");

                return azzzzb_ ?? false;
            };
            bool zzzzf_()
            {
                string azzzzc_ = period?.unit;
                bool? azzzzd_ = context.Operators.Equal(azzzzc_, "s");

                return azzzzd_ ?? false;
            };
            bool zzzzg_()
            {
                string azzzze_ = period?.unit;
                bool? azzzzf_ = context.Operators.Equal(azzzze_, "d");

                return azzzzf_ ?? false;
            };
            bool zzzzh_()
            {
                string azzzzg_ = period?.unit;
                bool? azzzzh_ = context.Operators.Equal(azzzzg_, "wk");

                return azzzzh_ ?? false;
            };
            bool zzzzi_()
            {
                string azzzzi_ = period?.unit;
                bool? azzzzj_ = context.Operators.Equal(azzzzi_, "mo");

                return azzzzj_ ?? false;
            };
            bool zzzzj_()
            {
                string azzzzk_ = period?.unit;
                bool? azzzzl_ = context.Operators.Equal(azzzzk_, "a");

                return azzzzl_ ?? false;
            };
            bool zzzzk_()
            {
                string azzzzm_ = period?.unit;
                bool? azzzzn_ = context.Operators.Equal(azzzzm_, "hour");

                return azzzzn_ ?? false;
            };
            bool zzzzl_()
            {
                string azzzzo_ = period?.unit;
                bool? azzzzp_ = context.Operators.Equal(azzzzo_, "minute");

                return azzzzp_ ?? false;
            };
            bool zzzzm_()
            {
                string azzzzq_ = period?.unit;
                bool? azzzzr_ = context.Operators.Equal(azzzzq_, "second");

                return azzzzr_ ?? false;
            };
            bool zzzzn_()
            {
                string azzzzs_ = period?.unit;
                bool? azzzzt_ = context.Operators.Equal(azzzzs_, "day");

                return azzzzt_ ?? false;
            };
            bool zzzzo_()
            {
                string azzzzu_ = period?.unit;
                bool? azzzzv_ = context.Operators.Equal(azzzzu_, "week");

                return azzzzv_ ?? false;
            };
            bool zzzzp_()
            {
                string azzzzw_ = period?.unit;
                bool? azzzzx_ = context.Operators.Equal(azzzzw_, "month");

                return azzzzx_ ?? false;
            };
            bool zzzzq_()
            {
                string azzzzy_ = period?.unit;
                bool? azzzzz_ = context.Operators.Equal(azzzzy_, "year");

                return azzzzz_ ?? false;
            };
            bool zzzzr_()
            {
                string bzzzza_ = period?.unit;
                bool? bzzzzb_ = context.Operators.Equal(bzzzza_, "hours");

                return bzzzzb_ ?? false;
            };
            bool zzzzs_()
            {
                string bzzzzc_ = period?.unit;
                bool? bzzzzd_ = context.Operators.Equal(bzzzzc_, "minutes");

                return bzzzzd_ ?? false;
            };
            bool zzzzt_()
            {
                string bzzzze_ = period?.unit;
                bool? bzzzzf_ = context.Operators.Equal(bzzzze_, "seconds");

                return bzzzzf_ ?? false;
            };
            bool zzzzu_()
            {
                string bzzzzg_ = period?.unit;
                bool? bzzzzh_ = context.Operators.Equal(bzzzzg_, "days");

                return bzzzzh_ ?? false;
            };
            bool zzzzv_()
            {
                string bzzzzi_ = period?.unit;
                bool? bzzzzj_ = context.Operators.Equal(bzzzzi_, "weeks");

                return bzzzzj_ ?? false;
            };
            bool zzzzw_()
            {
                string bzzzzk_ = period?.unit;
                bool? bzzzzl_ = context.Operators.Equal(bzzzzk_, "months");

                return bzzzzl_ ?? false;
            };
            bool zzzzx_()
            {
                string bzzzzm_ = period?.unit;
                bool? bzzzzn_ = context.Operators.Equal(bzzzzm_, "years");

                return bzzzzn_ ?? false;
            };
            if (zzzzd_())
            {
                decimal? bzzzzo_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? bzzzzp_ = period?.value;
                decimal? bzzzzq_ = context.Operators.Divide(24.0m, bzzzzp_);
                decimal? bzzzzr_ = context.Operators.Multiply(bzzzzo_, bzzzzq_);

                return bzzzzr_;
            }
            else if (zzzze_())
            {
                decimal? bzzzzs_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? bzzzzt_ = period?.value;
                decimal? bzzzzu_ = context.Operators.Divide(24.0m, bzzzzt_);
                decimal? bzzzzv_ = context.Operators.Multiply(bzzzzs_, bzzzzu_);
                decimal? bzzzzw_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? bzzzzx_ = context.Operators.Multiply(bzzzzv_, bzzzzw_);

                return bzzzzx_;
            }
            else if (zzzzf_())
            {
                decimal? bzzzzy_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? bzzzzz_ = period?.value;
                decimal? czzzza_ = context.Operators.Divide(24.0m, bzzzzz_);
                decimal? czzzzb_ = context.Operators.Multiply(bzzzzy_, czzzza_);
                decimal? czzzzc_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? czzzzd_ = context.Operators.Multiply(czzzzb_, czzzzc_);
                decimal? czzzzf_ = context.Operators.Multiply(czzzzd_, czzzzc_);

                return czzzzf_;
            }
            else if (zzzzg_())
            {
                decimal? czzzzg_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? czzzzh_ = period?.value;
                decimal? czzzzi_ = context.Operators.Divide(24.0m, czzzzh_);
                decimal? czzzzj_ = context.Operators.Multiply(czzzzg_, czzzzi_);
                decimal? czzzzk_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? czzzzl_ = context.Operators.Divide(czzzzj_, czzzzk_);

                return czzzzl_;
            }
            else if (zzzzh_())
            {
                decimal? czzzzm_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? czzzzn_ = period?.value;
                decimal? czzzzo_ = context.Operators.Divide(24.0m, czzzzn_);
                decimal? czzzzp_ = context.Operators.Multiply(czzzzm_, czzzzo_);
                int? czzzzq_ = context.Operators.Multiply(24, 7);
                decimal? czzzzr_ = context.Operators.ConvertIntegerToDecimal(czzzzq_);
                decimal? czzzzs_ = context.Operators.Divide(czzzzp_, czzzzr_);

                return czzzzs_;
            }
            else if (zzzzi_())
            {
                decimal? czzzzt_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? czzzzu_ = period?.value;
                decimal? czzzzv_ = context.Operators.Divide(24.0m, czzzzu_);
                decimal? czzzzw_ = context.Operators.Multiply(czzzzt_, czzzzv_);
                int? czzzzx_ = context.Operators.Multiply(24, 30);
                decimal? czzzzy_ = context.Operators.ConvertIntegerToDecimal(czzzzx_);
                decimal? czzzzz_ = context.Operators.Divide(czzzzw_, czzzzy_);

                return czzzzz_;
            }
            else if (zzzzj_())
            {
                decimal? dzzzza_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? dzzzzb_ = period?.value;
                decimal? dzzzzc_ = context.Operators.Divide(24.0m, dzzzzb_);
                decimal? dzzzzd_ = context.Operators.Multiply(dzzzza_, dzzzzc_);
                int? dzzzze_ = context.Operators.Multiply(24, 365);
                decimal? dzzzzf_ = context.Operators.ConvertIntegerToDecimal(dzzzze_);
                decimal? dzzzzg_ = context.Operators.Divide(dzzzzd_, dzzzzf_);

                return dzzzzg_;
            }
            else if (zzzzk_())
            {
                decimal? dzzzzh_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? dzzzzi_ = period?.value;
                decimal? dzzzzj_ = context.Operators.Divide(24.0m, dzzzzi_);
                decimal? dzzzzk_ = context.Operators.Multiply(dzzzzh_, dzzzzj_);

                return dzzzzk_;
            }
            else if (zzzzl_())
            {
                decimal? dzzzzl_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? dzzzzm_ = period?.value;
                decimal? dzzzzn_ = context.Operators.Divide(24.0m, dzzzzm_);
                decimal? dzzzzo_ = context.Operators.Multiply(dzzzzl_, dzzzzn_);
                decimal? dzzzzp_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? dzzzzq_ = context.Operators.Multiply(dzzzzo_, dzzzzp_);

                return dzzzzq_;
            }
            else if (zzzzm_())
            {
                decimal? dzzzzr_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? dzzzzs_ = period?.value;
                decimal? dzzzzt_ = context.Operators.Divide(24.0m, dzzzzs_);
                decimal? dzzzzu_ = context.Operators.Multiply(dzzzzr_, dzzzzt_);
                decimal? dzzzzv_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? dzzzzw_ = context.Operators.Multiply(dzzzzu_, dzzzzv_);
                decimal? dzzzzy_ = context.Operators.Multiply(dzzzzw_, dzzzzv_);

                return dzzzzy_;
            }
            else if (zzzzn_())
            {
                decimal? dzzzzz_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ezzzza_ = period?.value;
                decimal? ezzzzb_ = context.Operators.Divide(24.0m, ezzzza_);
                decimal? ezzzzc_ = context.Operators.Multiply(dzzzzz_, ezzzzb_);
                decimal? ezzzzd_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? ezzzze_ = context.Operators.Divide(ezzzzc_, ezzzzd_);

                return ezzzze_;
            }
            else if (zzzzo_())
            {
                decimal? ezzzzf_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ezzzzg_ = period?.value;
                decimal? ezzzzh_ = context.Operators.Divide(24.0m, ezzzzg_);
                decimal? ezzzzi_ = context.Operators.Multiply(ezzzzf_, ezzzzh_);
                int? ezzzzj_ = context.Operators.Multiply(24, 7);
                decimal? ezzzzk_ = context.Operators.ConvertIntegerToDecimal(ezzzzj_);
                decimal? ezzzzl_ = context.Operators.Divide(ezzzzi_, ezzzzk_);

                return ezzzzl_;
            }
            else if (zzzzp_())
            {
                decimal? ezzzzm_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ezzzzn_ = period?.value;
                decimal? ezzzzo_ = context.Operators.Divide(24.0m, ezzzzn_);
                decimal? ezzzzp_ = context.Operators.Multiply(ezzzzm_, ezzzzo_);
                int? ezzzzq_ = context.Operators.Multiply(24, 30);
                decimal? ezzzzr_ = context.Operators.ConvertIntegerToDecimal(ezzzzq_);
                decimal? ezzzzs_ = context.Operators.Divide(ezzzzp_, ezzzzr_);

                return ezzzzs_;
            }
            else if (zzzzq_())
            {
                decimal? ezzzzt_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ezzzzu_ = period?.value;
                decimal? ezzzzv_ = context.Operators.Divide(24.0m, ezzzzu_);
                decimal? ezzzzw_ = context.Operators.Multiply(ezzzzt_, ezzzzv_);
                int? ezzzzx_ = context.Operators.Multiply(24, 365);
                decimal? ezzzzy_ = context.Operators.ConvertIntegerToDecimal(ezzzzx_);
                decimal? ezzzzz_ = context.Operators.Divide(ezzzzw_, ezzzzy_);

                return ezzzzz_;
            }
            else if (zzzzr_())
            {
                decimal? fzzzza_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fzzzzb_ = period?.value;
                decimal? fzzzzc_ = context.Operators.Divide(24.0m, fzzzzb_);
                decimal? fzzzzd_ = context.Operators.Multiply(fzzzza_, fzzzzc_);

                return fzzzzd_;
            }
            else if (zzzzs_())
            {
                decimal? fzzzze_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fzzzzf_ = period?.value;
                decimal? fzzzzg_ = context.Operators.Divide(24.0m, fzzzzf_);
                decimal? fzzzzh_ = context.Operators.Multiply(fzzzze_, fzzzzg_);
                decimal? fzzzzi_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? fzzzzj_ = context.Operators.Multiply(fzzzzh_, fzzzzi_);

                return fzzzzj_;
            }
            else if (zzzzt_())
            {
                decimal? fzzzzk_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fzzzzl_ = period?.value;
                decimal? fzzzzm_ = context.Operators.Divide(24.0m, fzzzzl_);
                decimal? fzzzzn_ = context.Operators.Multiply(fzzzzk_, fzzzzm_);
                decimal? fzzzzo_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? fzzzzp_ = context.Operators.Multiply(fzzzzn_, fzzzzo_);
                decimal? fzzzzr_ = context.Operators.Multiply(fzzzzp_, fzzzzo_);

                return fzzzzr_;
            }
            else if (zzzzu_())
            {
                decimal? fzzzzs_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fzzzzt_ = period?.value;
                decimal? fzzzzu_ = context.Operators.Divide(24.0m, fzzzzt_);
                decimal? fzzzzv_ = context.Operators.Multiply(fzzzzs_, fzzzzu_);
                decimal? fzzzzw_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? fzzzzx_ = context.Operators.Divide(fzzzzv_, fzzzzw_);

                return fzzzzx_;
            }
            else if (zzzzv_())
            {
                decimal? fzzzzy_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fzzzzz_ = period?.value;
                decimal? gzzzza_ = context.Operators.Divide(24.0m, fzzzzz_);
                decimal? gzzzzb_ = context.Operators.Multiply(fzzzzy_, gzzzza_);
                int? gzzzzc_ = context.Operators.Multiply(24, 7);
                decimal? gzzzzd_ = context.Operators.ConvertIntegerToDecimal(gzzzzc_);
                decimal? gzzzze_ = context.Operators.Divide(gzzzzb_, gzzzzd_);

                return gzzzze_;
            }
            else if (zzzzw_())
            {
                decimal? gzzzzf_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? gzzzzg_ = period?.value;
                decimal? gzzzzh_ = context.Operators.Divide(24.0m, gzzzzg_);
                decimal? gzzzzi_ = context.Operators.Multiply(gzzzzf_, gzzzzh_);
                int? gzzzzj_ = context.Operators.Multiply(24, 30);
                decimal? gzzzzk_ = context.Operators.ConvertIntegerToDecimal(gzzzzj_);
                decimal? gzzzzl_ = context.Operators.Divide(gzzzzi_, gzzzzk_);

                return gzzzzl_;
            }
            else if (zzzzx_())
            {
                decimal? gzzzzm_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? gzzzzn_ = period?.value;
                decimal? gzzzzo_ = context.Operators.Divide(24.0m, gzzzzn_);
                decimal? gzzzzp_ = context.Operators.Multiply(gzzzzm_, gzzzzo_);
                int? gzzzzq_ = context.Operators.Multiply(24, 365);
                decimal? gzzzzr_ = context.Operators.ConvertIntegerToDecimal(gzzzzq_);
                decimal? gzzzzs_ = context.Operators.Divide(gzzzzp_, gzzzzr_);

                return gzzzzs_;
            }
            else
            {
                string gzzzzt_ = this.ErrorLevel(context);
                string gzzzzu_ = period?.unit;
                string gzzzzv_ = context.Operators.Concatenate("Unknown unit ", gzzzzu_ ?? "");
                object gzzzzw_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownUnit", gzzzzt_, gzzzzv_);

                return gzzzzw_ as decimal?;
            }
        };

        return zzzzc_();
    }


    [CqlExpressionDefinition("ToDaily")]
    public decimal? ToDaily(CqlContext context, CqlCode frequency)
    {
        decimal? gzzzzx_()
        {
            bool gzzzzy_()
            {
                CqlCode gzzzzz_ = this.C(context);
                bool? hzzzza_ = context.Operators.Equal(frequency, gzzzzz_);

                return hzzzza_ ?? false;
            };
            if (gzzzzy_())
            {
                return 3.0m;
            }
            else
            {
                string hzzzzb_ = this.ErrorLevel(context);
                string hzzzzc_ = frequency?.code;
                string hzzzzd_ = context.Operators.Concatenate("Unknown frequency code ", hzzzzc_ ?? "");
                object hzzzze_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownFrequencyCode", hzzzzb_, hzzzzd_);

                return hzzzze_ as decimal?;
            }
        };

        return gzzzzx_();
    }


    [CqlExpressionDefinition("MedicationRequestPeriod")]
    public CqlInterval<CqlDateTime> MedicationRequestPeriod(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] hzzzzf_ = [
            Request,
        ];
        CqlInterval<CqlDateTime> hzzzzg_(MedicationRequest R)
        {
            CqlInterval<CqlDateTime> hzzzzk_()
            {
                bool hzzzzl_()
                {
                    List<Dosage> hzzzzm_ = R?.DosageInstruction;
                    Dosage hzzzzn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hzzzzm_);
                    Timing hzzzzo_ = hzzzzn_?.Timing;
                    Timing.RepeatComponent hzzzzp_ = hzzzzo_?.Repeat;
                    DataType hzzzzq_ = hzzzzp_?.Bounds;
                    CqlInterval<CqlDateTime> hzzzzr_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzzq_ as Period);
                    CqlDateTime hzzzzs_ = context.Operators.End(hzzzzr_);
                    Dosage hzzzzu_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hzzzzm_);
                    Timing hzzzzv_ = hzzzzu_?.Timing;
                    Timing.RepeatComponent hzzzzw_ = hzzzzv_?.Repeat;
                    DataType hzzzzx_ = hzzzzw_?.Bounds;
                    CqlInterval<CqlDateTime> hzzzzy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzzx_ as Period);
                    CqlDateTime hzzzzz_ = context.Operators.End(hzzzzy_);
                    CqlDateTime izzzza_ = context.Operators.MaxValue<CqlDateTime>();
                    bool? izzzzb_ = context.Operators.Equal(hzzzzz_, izzzza_);
                    bool? izzzzc_ = context.Operators.Or((bool?)(hzzzzs_ is null), izzzzb_);
                    bool? izzzzd_ = context.Operators.Not(izzzzc_);

                    return izzzzd_ ?? false;
                };
                if (hzzzzl_())
                {
                    List<Dosage> izzzze_ = R?.DosageInstruction;
                    Dosage izzzzf_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)izzzze_);
                    Timing izzzzg_ = izzzzf_?.Timing;
                    Timing.RepeatComponent izzzzh_ = izzzzg_?.Repeat;
                    DataType izzzzi_ = izzzzh_?.Bounds;
                    CqlInterval<CqlDateTime> izzzzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, izzzzi_ as Period);
                    CqlDateTime izzzzk_ = context.Operators.Start(izzzzj_);
                    MedicationRequest.DispenseRequestComponent izzzzl_ = R?.DispenseRequest;
                    Period izzzzm_ = izzzzl_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> izzzzn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, izzzzm_);
                    CqlDateTime izzzzo_ = context.Operators.Start(izzzzn_);
                    FhirDateTime izzzzp_ = R?.AuthoredOnElement;
                    CqlDateTime izzzzq_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, izzzzp_);
                    Dosage izzzzs_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)izzzze_);
                    Timing izzzzt_ = izzzzs_?.Timing;
                    Timing.RepeatComponent izzzzu_ = izzzzt_?.Repeat;
                    DataType izzzzv_ = izzzzu_?.Bounds;
                    CqlInterval<CqlDateTime> izzzzw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, izzzzv_ as Period);
                    CqlDateTime izzzzx_ = context.Operators.End(izzzzw_);
                    CqlInterval<CqlDateTime> izzzzy_ = context.Operators.Interval((izzzzk_ ?? izzzzo_) ?? izzzzq_, izzzzx_, true, true);

                    return izzzzy_;
                }
                else
                {
                    List<Dosage> izzzzz_ = R?.DosageInstruction;
                    Dosage jzzzza_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)izzzzz_);
                    Timing jzzzzb_ = jzzzza_?.Timing;
                    Timing.RepeatComponent jzzzzc_ = jzzzzb_?.Repeat;
                    DataType jzzzzd_ = jzzzzc_?.Bounds;
                    CqlInterval<CqlDateTime> jzzzze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzd_ as Period);
                    CqlDateTime jzzzzf_ = context.Operators.Start(jzzzze_);
                    MedicationRequest.DispenseRequestComponent jzzzzg_ = R?.DispenseRequest;
                    Period jzzzzh_ = jzzzzg_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> jzzzzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzh_);
                    CqlDateTime jzzzzj_ = context.Operators.Start(jzzzzi_);
                    FhirDateTime jzzzzk_ = R?.AuthoredOnElement;
                    CqlDateTime jzzzzl_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, jzzzzk_);
                    Dosage jzzzzn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)izzzzz_);
                    Timing jzzzzo_ = jzzzzn_?.Timing;
                    Timing.RepeatComponent jzzzzp_ = jzzzzo_?.Repeat;
                    DataType jzzzzq_ = jzzzzp_?.Bounds;
                    CqlInterval<CqlDateTime> jzzzzr_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzq_ as Period);
                    CqlDateTime jzzzzs_ = context.Operators.Start(jzzzzr_);
                    Period jzzzzu_ = jzzzzg_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> jzzzzv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzu_);
                    CqlDateTime jzzzzw_ = context.Operators.Start(jzzzzv_);
                    CqlDateTime jzzzzy_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, jzzzzk_);
                    Duration kzzzza_ = jzzzzg_?.ExpectedSupplyDuration;
                    CqlQuantity kzzzzb_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, kzzzza_);
                    Quantity kzzzzd_ = jzzzzg_?.Quantity;
                    CqlQuantity kzzzze_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, kzzzzd_);
                    Dosage kzzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)izzzzz_);
                    List<Dosage.DoseAndRateComponent> kzzzzh_ = kzzzzg_?.DoseAndRate;
                    Dosage.DoseAndRateComponent kzzzzi_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)kzzzzh_);
                    DataType kzzzzj_ = kzzzzi_?.Dose;
                    CqlInterval<CqlQuantity> kzzzzk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, kzzzzj_ as Range);
                    CqlQuantity kzzzzl_ = context.Operators.End(kzzzzk_);
                    Dosage kzzzzn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)izzzzz_);
                    List<Dosage.DoseAndRateComponent> kzzzzo_ = kzzzzn_?.DoseAndRate;
                    Dosage.DoseAndRateComponent kzzzzp_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)kzzzzo_);
                    DataType kzzzzq_ = kzzzzp_?.Dose;
                    CqlQuantity kzzzzr_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, kzzzzq_ as Quantity);
                    Dosage kzzzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)izzzzz_);
                    Timing kzzzzu_ = kzzzzt_?.Timing;
                    Timing.RepeatComponent kzzzzv_ = kzzzzu_?.Repeat;
                    PositiveInt kzzzzw_ = kzzzzv_?.FrequencyMaxElement;
                    Integer kzzzzx_ = context.Operators.Convert<Integer>(kzzzzw_);
                    Dosage kzzzzz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)izzzzz_);
                    Timing lzzzza_ = kzzzzz_?.Timing;
                    Timing.RepeatComponent lzzzzb_ = lzzzza_?.Repeat;
                    PositiveInt lzzzzc_ = lzzzzb_?.FrequencyElement;
                    Integer lzzzzd_ = context.Operators.Convert<Integer>(lzzzzc_);
                    int? lzzzze_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, kzzzzx_ ?? lzzzzd_);
                    Dosage lzzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)izzzzz_);
                    Timing lzzzzh_ = lzzzzg_?.Timing;
                    Timing.RepeatComponent lzzzzi_ = lzzzzh_?.Repeat;
                    FhirDecimal lzzzzj_ = lzzzzi_?.PeriodElement;
                    decimal? lzzzzk_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, lzzzzj_);
                    Dosage lzzzzm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)izzzzz_);
                    Timing lzzzzn_ = lzzzzm_?.Timing;
                    Timing.RepeatComponent lzzzzo_ = lzzzzn_?.Repeat;
                    Code<Timing.UnitsOfTime> lzzzzp_ = lzzzzo_?.PeriodUnitElement;
                    Timing.UnitsOfTime? lzzzzq_ = lzzzzp_?.Value;
                    string lzzzzr_ = context.Operators.Convert<string>(lzzzzq_);
                    decimal? lzzzzs_ = this.ToDaily(context, lzzzze_, new CqlQuantity(lzzzzk_, lzzzzr_));
                    Dosage lzzzzu_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)izzzzz_);
                    Timing lzzzzv_ = lzzzzu_?.Timing;
                    Timing.RepeatComponent lzzzzw_ = lzzzzv_?.Repeat;
                    List<Time> lzzzzx_ = lzzzzw_?.TimeOfDayElement;
                    int? lzzzzy_ = context.Operators.Count<Time>((IEnumerable<Time>)lzzzzx_);
                    decimal? lzzzzz_ = context.Operators.ConvertIntegerToDecimal(lzzzzy_);
                    CqlQuantity mzzzza_ = context.Operators.ConvertDecimalToQuantity((lzzzzs_ ?? lzzzzz_) ?? 1.0m);
                    CqlQuantity mzzzzb_ = context.Operators.Multiply(kzzzzl_ ?? kzzzzr_, mzzzza_);
                    CqlQuantity mzzzzc_ = context.Operators.Divide(kzzzze_, mzzzzb_);
                    UnsignedInt mzzzze_ = jzzzzg_?.NumberOfRepeatsAllowedElement;
                    Integer mzzzzf_ = context.Operators.Convert<Integer>(mzzzze_);
                    int? mzzzzg_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, mzzzzf_);
                    int? mzzzzh_ = context.Operators.Add(1, mzzzzg_ ?? 0);
                    CqlQuantity mzzzzi_ = context.Operators.ConvertIntegerToQuantity(mzzzzh_);
                    CqlQuantity mzzzzj_ = context.Operators.Multiply(kzzzzb_ ?? mzzzzc_, mzzzzi_);
                    CqlDateTime mzzzzk_ = context.Operators.Add((jzzzzs_ ?? jzzzzw_) ?? jzzzzy_, mzzzzj_);
                    CqlInterval<CqlDateTime> mzzzzl_ = context.Operators.Interval((jzzzzf_ ?? jzzzzj_) ?? jzzzzl_, mzzzzk_, true, true);

                    return mzzzzl_;
                }
            };

            return hzzzzk_();
        };
        IEnumerable<CqlInterval<CqlDateTime>> hzzzzh_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDateTime>>((IEnumerable<MedicationRequest>)hzzzzf_, hzzzzg_);
        IEnumerable<CqlInterval<CqlDateTime>> hzzzzi_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(hzzzzh_);
        CqlInterval<CqlDateTime> hzzzzj_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(hzzzzi_);

        return hzzzzj_;
    }


    [CqlExpressionDefinition("MedicationDispensePeriod")]
    public CqlInterval<CqlDateTime> MedicationDispensePeriod(CqlContext context, MedicationDispense Dispense)
    {
        MedicationDispense[] mzzzzm_ = [
            Dispense,
        ];
        CqlInterval<CqlDateTime> mzzzzn_(MedicationDispense D)
        {
            FhirDateTime mzzzzr_ = D?.WhenHandedOverElement;
            FhirDateTime mzzzzs_ = D?.WhenPreparedElement;
            CqlDateTime mzzzzt_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, mzzzzr_ ?? mzzzzs_);
            CqlDateTime mzzzzw_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, mzzzzr_ ?? mzzzzs_);
            Quantity mzzzzx_ = D?.DaysSupply;
            CqlQuantity mzzzzy_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, mzzzzx_);
            Quantity mzzzzz_ = D?.Quantity;
            CqlQuantity nzzzza_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, mzzzzz_);
            List<Dosage> nzzzzb_ = D?.DosageInstruction;
            Dosage nzzzzc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)nzzzzb_);
            List<Dosage.DoseAndRateComponent> nzzzzd_ = nzzzzc_?.DoseAndRate;
            Dosage.DoseAndRateComponent nzzzze_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)nzzzzd_);
            DataType nzzzzf_ = nzzzze_?.Dose;
            CqlInterval<CqlQuantity> nzzzzg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nzzzzf_ as Range);
            CqlQuantity nzzzzh_ = context.Operators.End(nzzzzg_);
            Dosage nzzzzj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)nzzzzb_);
            List<Dosage.DoseAndRateComponent> nzzzzk_ = nzzzzj_?.DoseAndRate;
            Dosage.DoseAndRateComponent nzzzzl_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)nzzzzk_);
            DataType nzzzzm_ = nzzzzl_?.Dose;
            CqlQuantity nzzzzn_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, nzzzzm_ as Quantity);
            Dosage nzzzzp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)nzzzzb_);
            Timing nzzzzq_ = nzzzzp_?.Timing;
            Timing.RepeatComponent nzzzzr_ = nzzzzq_?.Repeat;
            PositiveInt nzzzzs_ = nzzzzr_?.FrequencyMaxElement;
            Integer nzzzzt_ = context.Operators.Convert<Integer>(nzzzzs_);
            Dosage nzzzzv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)nzzzzb_);
            Timing nzzzzw_ = nzzzzv_?.Timing;
            Timing.RepeatComponent nzzzzx_ = nzzzzw_?.Repeat;
            PositiveInt nzzzzy_ = nzzzzx_?.FrequencyElement;
            Integer nzzzzz_ = context.Operators.Convert<Integer>(nzzzzy_);
            int? ozzzza_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, nzzzzt_ ?? nzzzzz_);
            Dosage ozzzzc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)nzzzzb_);
            Timing ozzzzd_ = ozzzzc_?.Timing;
            Timing.RepeatComponent ozzzze_ = ozzzzd_?.Repeat;
            FhirDecimal ozzzzf_ = ozzzze_?.PeriodElement;
            decimal? ozzzzg_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, ozzzzf_);
            Dosage ozzzzi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)nzzzzb_);
            Timing ozzzzj_ = ozzzzi_?.Timing;
            Timing.RepeatComponent ozzzzk_ = ozzzzj_?.Repeat;
            Code<Timing.UnitsOfTime> ozzzzl_ = ozzzzk_?.PeriodUnitElement;
            Timing.UnitsOfTime? ozzzzm_ = ozzzzl_?.Value;
            string ozzzzn_ = context.Operators.Convert<string>(ozzzzm_);
            decimal? ozzzzo_ = this.ToDaily(context, ozzzza_, new CqlQuantity(ozzzzg_, ozzzzn_));
            Dosage ozzzzq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)nzzzzb_);
            Timing ozzzzr_ = ozzzzq_?.Timing;
            Timing.RepeatComponent ozzzzs_ = ozzzzr_?.Repeat;
            List<Time> ozzzzt_ = ozzzzs_?.TimeOfDayElement;
            int? ozzzzu_ = context.Operators.Count<Time>((IEnumerable<Time>)ozzzzt_);
            decimal? ozzzzv_ = context.Operators.ConvertIntegerToDecimal(ozzzzu_);
            CqlQuantity ozzzzw_ = context.Operators.ConvertDecimalToQuantity((ozzzzo_ ?? ozzzzv_) ?? 1.0m);
            CqlQuantity ozzzzx_ = context.Operators.Multiply(nzzzzh_ ?? nzzzzn_, ozzzzw_);
            CqlQuantity ozzzzy_ = context.Operators.Divide(nzzzza_, ozzzzx_);
            CqlDateTime ozzzzz_ = context.Operators.Add(mzzzzw_, mzzzzy_ ?? ozzzzy_);
            CqlInterval<CqlDateTime> pzzzza_ = context.Operators.Interval(mzzzzt_, ozzzzz_, true, true);

            return pzzzza_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> mzzzzo_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDateTime>>((IEnumerable<MedicationDispense>)mzzzzm_, mzzzzn_);
        IEnumerable<CqlInterval<CqlDateTime>> mzzzzp_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(mzzzzo_);
        CqlInterval<CqlDateTime> mzzzzq_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(mzzzzp_);

        return mzzzzq_;
    }


    [CqlExpressionDefinition("TherapeuticDuration")]
    public CqlQuantity TherapeuticDuration(CqlContext context, CqlConcept medication)
    {
        CqlQuantity pzzzzb_ = context.Operators.Quantity(14m, "days");

        return pzzzzb_;
    }


    [CqlExpressionDefinition("MedicationAdministrationPeriod")]
    public CqlInterval<CqlDateTime> MedicationAdministrationPeriod(CqlContext context, MedicationAdministration Administration)
    {
        MedicationAdministration[] pzzzzc_ = [
            Administration,
        ];
        CqlInterval<CqlDateTime> pzzzzd_(MedicationAdministration M)
        {
            CqlInterval<CqlDateTime> pzzzzh_()
            {
                bool pzzzzi_()
                {
                    DataType pzzzzj_ = Administration?.Effective;
                    CqlInterval<CqlDateTime> pzzzzk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, pzzzzj_ as Period);
                    CqlDateTime pzzzzl_ = context.Operators.Start(pzzzzk_);
                    bool? pzzzzm_ = context.Operators.Not((bool?)(pzzzzl_ is null));
                    DataType pzzzzn_ = Administration?.Medication;
                    CqlConcept pzzzzo_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, pzzzzn_ as CodeableConcept);
                    CqlQuantity pzzzzp_ = this.TherapeuticDuration(context, pzzzzo_);
                    bool? pzzzzq_ = context.Operators.Not((bool?)(pzzzzp_ is null));
                    bool? pzzzzr_ = context.Operators.And(pzzzzm_, pzzzzq_);

                    return pzzzzr_ ?? false;
                };
                if (pzzzzi_())
                {
                    DataType pzzzzs_ = Administration?.Effective;
                    CqlInterval<CqlDateTime> pzzzzt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, pzzzzs_ as Period);
                    CqlDateTime pzzzzu_ = context.Operators.Start(pzzzzt_);
                    CqlInterval<CqlDateTime> pzzzzw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, pzzzzs_ as Period);
                    CqlDateTime pzzzzx_ = context.Operators.Start(pzzzzw_);
                    DataType pzzzzy_ = Administration?.Medication;
                    CqlConcept pzzzzz_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, pzzzzy_ as CodeableConcept);
                    CqlQuantity qzzzza_ = this.TherapeuticDuration(context, pzzzzz_);
                    CqlDateTime qzzzzb_ = context.Operators.Add(pzzzzx_, qzzzza_);
                    CqlInterval<CqlDateTime> qzzzzc_ = context.Operators.Interval(pzzzzu_, qzzzzb_, true, true);

                    return qzzzzc_;
                }
                else
                {
                    return null as CqlInterval<CqlDateTime>;
                }
            };

            return pzzzzh_();
        };
        IEnumerable<CqlInterval<CqlDateTime>> pzzzze_ = context.Operators.Select<MedicationAdministration, CqlInterval<CqlDateTime>>((IEnumerable<MedicationAdministration>)pzzzzc_, pzzzzd_);
        IEnumerable<CqlInterval<CqlDateTime>> pzzzzf_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(pzzzze_);
        CqlInterval<CqlDateTime> pzzzzg_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(pzzzzf_);

        return pzzzzg_;
    }


    [CqlExpressionDefinition("CumulativeDuration")]
    public int? CumulativeDuration(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> Intervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> qzzzzd_ = context.Operators.Collapse(Intervals, "day");
        int? qzzzze_(CqlInterval<CqlDateTime> X)
        {
            CqlDateTime qzzzzh_ = context.Operators.Start(X);
            CqlDateTime qzzzzi_ = context.Operators.End(X);
            int? qzzzzj_ = context.Operators.DifferenceBetween(qzzzzh_, qzzzzi_, "day");

            return qzzzzj_;
        };
        IEnumerable<int?> qzzzzf_ = context.Operators.Select<CqlInterval<CqlDateTime>, int?>(qzzzzd_, qzzzze_);
        int? qzzzzg_ = context.Operators.Sum(qzzzzf_);

        return qzzzzg_;
    }


    [CqlExpressionDefinition("RolloutIntervals")]
    public IEnumerable<CqlInterval<CqlDateTime>> RolloutIntervals(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> qzzzzk_(IEnumerable<CqlInterval<CqlDateTime>> R, CqlInterval<CqlDateTime> I)
        {
            CqlInterval<CqlDateTime>[] qzzzzm_ = [
                I,
            ];
            CqlInterval<CqlDateTime> qzzzzn_(CqlInterval<CqlDateTime> X)
            {
                CqlInterval<CqlDateTime> qzzzzt_ = context.Operators.Last<CqlInterval<CqlDateTime>>(R);
                CqlDateTime qzzzzu_ = context.Operators.End(qzzzzt_);
                CqlQuantity qzzzzv_ = context.Operators.Quantity(1m, "day");
                CqlDateTime qzzzzw_ = context.Operators.Add(qzzzzu_, qzzzzv_);
                CqlDateTime qzzzzx_ = context.Operators.Start(X);
                CqlDateTime[] qzzzzy_ = [
                    qzzzzw_,
                    qzzzzx_,
                ];
                CqlDateTime qzzzzz_ = context.Operators.Max<CqlDateTime>(qzzzzy_ as IEnumerable<CqlDateTime>);
                CqlDateTime rzzzzb_ = context.Operators.End(qzzzzt_);
                CqlDateTime rzzzzd_ = context.Operators.Add(rzzzzb_, qzzzzv_);
                CqlDateTime[] rzzzzf_ = [
                    rzzzzd_,
                    qzzzzx_,
                ];
                CqlDateTime rzzzzg_ = context.Operators.Max<CqlDateTime>(rzzzzf_ as IEnumerable<CqlDateTime>);
                CqlDateTime rzzzzi_ = context.Operators.End(X);
                int? rzzzzj_ = context.Operators.DurationBetween(qzzzzx_, rzzzzi_, "day");
                decimal? rzzzzk_ = context.Operators.ConvertIntegerToDecimal(rzzzzj_ ?? 0);
                CqlDateTime rzzzzl_ = context.Operators.Add(rzzzzg_, new CqlQuantity(rzzzzk_, "day"));
                CqlInterval<CqlDateTime> rzzzzm_ = context.Operators.Interval(qzzzzz_, rzzzzl_, true, true);

                return rzzzzm_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> qzzzzo_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>((IEnumerable<CqlInterval<CqlDateTime>>)qzzzzm_, qzzzzn_);
            IEnumerable<CqlInterval<CqlDateTime>> qzzzzp_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(qzzzzo_);
            CqlInterval<CqlDateTime> qzzzzq_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(qzzzzp_);
            CqlInterval<CqlDateTime>[] qzzzzr_ = [
                qzzzzq_,
            ];
            IEnumerable<CqlInterval<CqlDateTime>> qzzzzs_ = context.Operators.Union<CqlInterval<CqlDateTime>>(R, qzzzzr_ as IEnumerable<CqlInterval<CqlDateTime>>);

            return qzzzzs_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> qzzzzl_ = context.Operators.Aggregate<CqlInterval<CqlDateTime>, IEnumerable<CqlInterval<CqlDateTime>>>(intervals, qzzzzk_, null as IEnumerable<CqlInterval<CqlDateTime>>);

        return qzzzzl_;
    }


    [CqlExpressionDefinition("MedicationPeriod")]
    public CqlInterval<CqlDateTime> MedicationPeriod(CqlContext context, object medication)
    {
        CqlInterval<CqlDateTime> rzzzzn_()
        {
            if (medication is MedicationRequest)
            {
                CqlInterval<CqlDateTime> rzzzzo_ = this.MedicationRequestPeriod(context, medication as MedicationRequest);

                return rzzzzo_;
            }
            else if (medication is MedicationDispense)
            {
                CqlInterval<CqlDateTime> rzzzzp_ = this.MedicationDispensePeriod(context, medication as MedicationDispense);

                return rzzzzp_;
            }
            else if (medication is MedicationAdministration)
            {
                CqlInterval<CqlDateTime> rzzzzq_ = this.MedicationAdministrationPeriod(context, medication as MedicationAdministration);

                return rzzzzq_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return rzzzzn_();
    }


    [CqlExpressionDefinition("CumulativeMedicationDuration")]
    public int? CumulativeMedicationDuration(CqlContext context, IEnumerable<object> Medications)
    {
        bool? rzzzzr_(object M)
        {
            bool szzzze_ = M is MedicationRequest;

            return szzzze_ as bool?;
        };
        IEnumerable<object> rzzzzs_ = context.Operators.Where<object>(Medications, rzzzzr_);
        CqlInterval<CqlDateTime> rzzzzt_(object M)
        {
            CqlInterval<CqlDateTime> szzzzf_ = this.MedicationPeriod(context, M);

            return szzzzf_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> rzzzzu_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(rzzzzs_, rzzzzt_);
        IEnumerable<CqlInterval<CqlDateTime>> rzzzzv_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(rzzzzu_);
        bool? rzzzzw_(object M)
        {
            bool szzzzg_ = M is MedicationDispense;
            bool szzzzh_ = M is MedicationAdministration;
            bool? szzzzi_ = context.Operators.Or(szzzzg_ as bool?, szzzzh_ as bool?);

            return szzzzi_;
        };
        IEnumerable<object> rzzzzx_ = context.Operators.Where<object>(Medications, rzzzzw_);
        CqlInterval<CqlDateTime> rzzzzy_(object M)
        {
            CqlInterval<CqlDateTime> szzzzj_ = this.MedicationPeriod(context, M);

            return szzzzj_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> rzzzzz_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(rzzzzx_, rzzzzy_);
        IEnumerable<CqlInterval<CqlDateTime>> szzzza_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(rzzzzz_);
        IEnumerable<CqlInterval<CqlDateTime>> szzzzb_ = this.RolloutIntervals(context, szzzza_);
        IEnumerable<CqlInterval<CqlDateTime>> szzzzc_ = context.Operators.Union<CqlInterval<CqlDateTime>>(rzzzzv_, szzzzb_);
        int? szzzzd_ = this.CumulativeDuration(context, szzzzc_);

        return szzzzd_;
    }


    #endregion Expressions

}

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
    private static readonly CqlCode _AC = new CqlCode("AC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlCodeDefinition("ACD", codeId: "ACD", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode ACD(CqlContext _) => _ACD;
    private static readonly CqlCode _ACD = new CqlCode("ACD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlCodeDefinition("ACM", codeId: "ACM", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode ACM(CqlContext _) => _ACM;
    private static readonly CqlCode _ACM = new CqlCode("ACM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlCodeDefinition("ACV", codeId: "ACV", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode ACV(CqlContext _) => _ACV;
    private static readonly CqlCode _ACV = new CqlCode("ACV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlCodeDefinition("AFT", codeId: "AFT", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode AFT(CqlContext _) => _AFT;
    private static readonly CqlCode _AFT = new CqlCode("AFT", "http://hl7.org/fhir/event-timing", default, default);

    [CqlCodeDefinition("AFT.early", codeId: "AFT.early", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode AFT_early(CqlContext _) => _AFT_early;
    private static readonly CqlCode _AFT_early = new CqlCode("AFT.early", "http://hl7.org/fhir/event-timing", default, default);

    [CqlCodeDefinition("AFT.late", codeId: "AFT.late", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode AFT_late(CqlContext _) => _AFT_late;
    private static readonly CqlCode _AFT_late = new CqlCode("AFT.late", "http://hl7.org/fhir/event-timing", default, default);

    [CqlCodeDefinition("C", codeId: "C", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode C(CqlContext _) => _C;
    private static readonly CqlCode _C = new CqlCode("C", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlCodeDefinition("CD", codeId: "CD", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode CD(CqlContext _) => _CD;
    private static readonly CqlCode _CD = new CqlCode("CD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlCodeDefinition("CM", codeId: "CM", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode CM(CqlContext _) => _CM;
    private static readonly CqlCode _CM = new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlCodeDefinition("CV", codeId: "CV", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode CV(CqlContext _) => _CV;
    private static readonly CqlCode _CV = new CqlCode("CV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlCodeDefinition("EVE", codeId: "EVE", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode EVE(CqlContext _) => _EVE;
    private static readonly CqlCode _EVE = new CqlCode("EVE", "http://hl7.org/fhir/event-timing", default, default);

    [CqlCodeDefinition("EVE.early", codeId: "EVE.early", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode EVE_early(CqlContext _) => _EVE_early;
    private static readonly CqlCode _EVE_early = new CqlCode("EVE.early", "http://hl7.org/fhir/event-timing", default, default);

    [CqlCodeDefinition("EVE.late", codeId: "EVE.late", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode EVE_late(CqlContext _) => _EVE_late;
    private static readonly CqlCode _EVE_late = new CqlCode("EVE.late", "http://hl7.org/fhir/event-timing", default, default);

    [CqlCodeDefinition("HS", codeId: "HS", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode HS(CqlContext _) => _HS;
    private static readonly CqlCode _HS = new CqlCode("HS", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlCodeDefinition("MORN", codeId: "MORN", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode MORN(CqlContext _) => _MORN;
    private static readonly CqlCode _MORN = new CqlCode("MORN", "http://hl7.org/fhir/event-timing", default, default);

    [CqlCodeDefinition("MORN.early", codeId: "MORN.early", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode MORN_early(CqlContext _) => _MORN_early;
    private static readonly CqlCode _MORN_early = new CqlCode("MORN.early", "http://hl7.org/fhir/event-timing", default, default);

    [CqlCodeDefinition("MORN.late", codeId: "MORN.late", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode MORN_late(CqlContext _) => _MORN_late;
    private static readonly CqlCode _MORN_late = new CqlCode("MORN.late", "http://hl7.org/fhir/event-timing", default, default);

    [CqlCodeDefinition("NIGHT", codeId: "NIGHT", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode NIGHT(CqlContext _) => _NIGHT;
    private static readonly CqlCode _NIGHT = new CqlCode("NIGHT", "http://hl7.org/fhir/event-timing", default, default);

    [CqlCodeDefinition("NOON", codeId: "NOON", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode NOON(CqlContext _) => _NOON;
    private static readonly CqlCode _NOON = new CqlCode("NOON", "http://hl7.org/fhir/event-timing", default, default);

    [CqlCodeDefinition("PC", codeId: "PC", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode PC(CqlContext _) => _PC;
    private static readonly CqlCode _PC = new CqlCode("PC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlCodeDefinition("PCD", codeId: "PCD", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode PCD(CqlContext _) => _PCD;
    private static readonly CqlCode _PCD = new CqlCode("PCD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlCodeDefinition("PCM", codeId: "PCM", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode PCM(CqlContext _) => _PCM;
    private static readonly CqlCode _PCM = new CqlCode("PCM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlCodeDefinition("PCV", codeId: "PCV", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode PCV(CqlContext _) => _PCV;
    private static readonly CqlCode _PCV = new CqlCode("PCV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlCodeDefinition("PHS", codeId: "PHS", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode PHS(CqlContext _) => _PHS;
    private static readonly CqlCode _PHS = new CqlCode("PHS", "http://hl7.org/fhir/event-timing", default, default);

    [CqlCodeDefinition("WAKE", codeId: "WAKE", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode WAKE(CqlContext _) => _WAKE;
    private static readonly CqlCode _WAKE = new CqlCode("WAKE", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("V3TimingEvent")]
    public CqlCodeSystem V3TimingEvent(CqlContext _) => _V3TimingEvent;
    private static readonly CqlCodeSystem _V3TimingEvent = new CqlCodeSystem();

    [CqlCodeSystemDefinition("EventTiming")]
    public CqlCodeSystem EventTiming(CqlContext _) => _EventTiming;
    private static readonly CqlCodeSystem _EventTiming = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("ErrorLevel")]
    public string ErrorLevel(CqlContext context)
    {
        object czza_ = context.ResolveParameter("CumulativeMedicationDurationFHIR4-1.0.000", "ErrorLevel", "Warning");

        return (string)czza_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> czzb_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient czzc_ = context.Operators.SingletonFrom<Patient>(czzb_);

        return czzc_;
    }


    [CqlExpressionDefinition("ToDaily")]
    public decimal? ToDaily(CqlContext context, int? frequency, CqlQuantity period)
    {
        decimal? czzd_()
        {
            bool czze_()
            {
                string czzz_ = period?.unit;
                bool? dzza_ = context.Operators.Equal(czzz_, "h");

                return dzza_ ?? false;
            };
            bool czzf_()
            {
                string dzzb_ = period?.unit;
                bool? dzzc_ = context.Operators.Equal(dzzb_, "min");

                return dzzc_ ?? false;
            };
            bool czzg_()
            {
                string dzzd_ = period?.unit;
                bool? dzze_ = context.Operators.Equal(dzzd_, "s");

                return dzze_ ?? false;
            };
            bool czzh_()
            {
                string dzzf_ = period?.unit;
                bool? dzzg_ = context.Operators.Equal(dzzf_, "d");

                return dzzg_ ?? false;
            };
            bool czzi_()
            {
                string dzzh_ = period?.unit;
                bool? dzzi_ = context.Operators.Equal(dzzh_, "wk");

                return dzzi_ ?? false;
            };
            bool czzj_()
            {
                string dzzj_ = period?.unit;
                bool? dzzk_ = context.Operators.Equal(dzzj_, "mo");

                return dzzk_ ?? false;
            };
            bool czzk_()
            {
                string dzzl_ = period?.unit;
                bool? dzzm_ = context.Operators.Equal(dzzl_, "a");

                return dzzm_ ?? false;
            };
            bool czzl_()
            {
                string dzzn_ = period?.unit;
                bool? dzzo_ = context.Operators.Equal(dzzn_, "hour");

                return dzzo_ ?? false;
            };
            bool czzm_()
            {
                string dzzp_ = period?.unit;
                bool? dzzq_ = context.Operators.Equal(dzzp_, "minute");

                return dzzq_ ?? false;
            };
            bool czzn_()
            {
                string dzzr_ = period?.unit;
                bool? dzzs_ = context.Operators.Equal(dzzr_, "second");

                return dzzs_ ?? false;
            };
            bool czzo_()
            {
                string dzzt_ = period?.unit;
                bool? dzzu_ = context.Operators.Equal(dzzt_, "day");

                return dzzu_ ?? false;
            };
            bool czzp_()
            {
                string dzzv_ = period?.unit;
                bool? dzzw_ = context.Operators.Equal(dzzv_, "week");

                return dzzw_ ?? false;
            };
            bool czzq_()
            {
                string dzzx_ = period?.unit;
                bool? dzzy_ = context.Operators.Equal(dzzx_, "month");

                return dzzy_ ?? false;
            };
            bool czzr_()
            {
                string dzzz_ = period?.unit;
                bool? ezza_ = context.Operators.Equal(dzzz_, "year");

                return ezza_ ?? false;
            };
            bool czzs_()
            {
                string ezzb_ = period?.unit;
                bool? ezzc_ = context.Operators.Equal(ezzb_, "hours");

                return ezzc_ ?? false;
            };
            bool czzt_()
            {
                string ezzd_ = period?.unit;
                bool? ezze_ = context.Operators.Equal(ezzd_, "minutes");

                return ezze_ ?? false;
            };
            bool czzu_()
            {
                string ezzf_ = period?.unit;
                bool? ezzg_ = context.Operators.Equal(ezzf_, "seconds");

                return ezzg_ ?? false;
            };
            bool czzv_()
            {
                string ezzh_ = period?.unit;
                bool? ezzi_ = context.Operators.Equal(ezzh_, "days");

                return ezzi_ ?? false;
            };
            bool czzw_()
            {
                string ezzj_ = period?.unit;
                bool? ezzk_ = context.Operators.Equal(ezzj_, "weeks");

                return ezzk_ ?? false;
            };
            bool czzx_()
            {
                string ezzl_ = period?.unit;
                bool? ezzm_ = context.Operators.Equal(ezzl_, "months");

                return ezzm_ ?? false;
            };
            bool czzy_()
            {
                string ezzn_ = period?.unit;
                bool? ezzo_ = context.Operators.Equal(ezzn_, "years");

                return ezzo_ ?? false;
            };
            if (czze_())
            {
                decimal? ezzp_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ezzq_ = period?.value;
                decimal? ezzr_ = context.Operators.Divide(24.0m, ezzq_);
                decimal? ezzs_ = context.Operators.Multiply(ezzp_, ezzr_);

                return ezzs_;
            }
            else if (czzf_())
            {
                decimal? ezzt_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ezzu_ = period?.value;
                decimal? ezzv_ = context.Operators.Divide(24.0m, ezzu_);
                decimal? ezzw_ = context.Operators.Multiply(ezzt_, ezzv_);
                decimal? ezzx_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? ezzy_ = context.Operators.Multiply(ezzw_, ezzx_);

                return ezzy_;
            }
            else if (czzg_())
            {
                decimal? ezzz_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fzza_ = period?.value;
                decimal? fzzb_ = context.Operators.Divide(24.0m, fzza_);
                decimal? fzzc_ = context.Operators.Multiply(ezzz_, fzzb_);
                decimal? fzzd_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? fzze_ = context.Operators.Multiply(fzzc_, fzzd_);
                decimal? fzzg_ = context.Operators.Multiply(fzze_, fzzd_);

                return fzzg_;
            }
            else if (czzh_())
            {
                decimal? fzzh_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fzzi_ = period?.value;
                decimal? fzzj_ = context.Operators.Divide(24.0m, fzzi_);
                decimal? fzzk_ = context.Operators.Multiply(fzzh_, fzzj_);
                decimal? fzzl_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? fzzm_ = context.Operators.Divide(fzzk_, fzzl_);

                return fzzm_;
            }
            else if (czzi_())
            {
                decimal? fzzn_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fzzo_ = period?.value;
                decimal? fzzp_ = context.Operators.Divide(24.0m, fzzo_);
                decimal? fzzq_ = context.Operators.Multiply(fzzn_, fzzp_);
                int? fzzr_ = context.Operators.Multiply(24, 7);
                decimal? fzzs_ = context.Operators.ConvertIntegerToDecimal(fzzr_);
                decimal? fzzt_ = context.Operators.Divide(fzzq_, fzzs_);

                return fzzt_;
            }
            else if (czzj_())
            {
                decimal? fzzu_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fzzv_ = period?.value;
                decimal? fzzw_ = context.Operators.Divide(24.0m, fzzv_);
                decimal? fzzx_ = context.Operators.Multiply(fzzu_, fzzw_);
                int? fzzy_ = context.Operators.Multiply(24, 30);
                decimal? fzzz_ = context.Operators.ConvertIntegerToDecimal(fzzy_);
                decimal? gzza_ = context.Operators.Divide(fzzx_, fzzz_);

                return gzza_;
            }
            else if (czzk_())
            {
                decimal? gzzb_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? gzzc_ = period?.value;
                decimal? gzzd_ = context.Operators.Divide(24.0m, gzzc_);
                decimal? gzze_ = context.Operators.Multiply(gzzb_, gzzd_);
                int? gzzf_ = context.Operators.Multiply(24, 365);
                decimal? gzzg_ = context.Operators.ConvertIntegerToDecimal(gzzf_);
                decimal? gzzh_ = context.Operators.Divide(gzze_, gzzg_);

                return gzzh_;
            }
            else if (czzl_())
            {
                decimal? gzzi_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? gzzj_ = period?.value;
                decimal? gzzk_ = context.Operators.Divide(24.0m, gzzj_);
                decimal? gzzl_ = context.Operators.Multiply(gzzi_, gzzk_);

                return gzzl_;
            }
            else if (czzm_())
            {
                decimal? gzzm_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? gzzn_ = period?.value;
                decimal? gzzo_ = context.Operators.Divide(24.0m, gzzn_);
                decimal? gzzp_ = context.Operators.Multiply(gzzm_, gzzo_);
                decimal? gzzq_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? gzzr_ = context.Operators.Multiply(gzzp_, gzzq_);

                return gzzr_;
            }
            else if (czzn_())
            {
                decimal? gzzs_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? gzzt_ = period?.value;
                decimal? gzzu_ = context.Operators.Divide(24.0m, gzzt_);
                decimal? gzzv_ = context.Operators.Multiply(gzzs_, gzzu_);
                decimal? gzzw_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? gzzx_ = context.Operators.Multiply(gzzv_, gzzw_);
                decimal? gzzz_ = context.Operators.Multiply(gzzx_, gzzw_);

                return gzzz_;
            }
            else if (czzo_())
            {
                decimal? hzza_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? hzzb_ = period?.value;
                decimal? hzzc_ = context.Operators.Divide(24.0m, hzzb_);
                decimal? hzzd_ = context.Operators.Multiply(hzza_, hzzc_);
                decimal? hzze_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? hzzf_ = context.Operators.Divide(hzzd_, hzze_);

                return hzzf_;
            }
            else if (czzp_())
            {
                decimal? hzzg_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? hzzh_ = period?.value;
                decimal? hzzi_ = context.Operators.Divide(24.0m, hzzh_);
                decimal? hzzj_ = context.Operators.Multiply(hzzg_, hzzi_);
                int? hzzk_ = context.Operators.Multiply(24, 7);
                decimal? hzzl_ = context.Operators.ConvertIntegerToDecimal(hzzk_);
                decimal? hzzm_ = context.Operators.Divide(hzzj_, hzzl_);

                return hzzm_;
            }
            else if (czzq_())
            {
                decimal? hzzn_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? hzzo_ = period?.value;
                decimal? hzzp_ = context.Operators.Divide(24.0m, hzzo_);
                decimal? hzzq_ = context.Operators.Multiply(hzzn_, hzzp_);
                int? hzzr_ = context.Operators.Multiply(24, 30);
                decimal? hzzs_ = context.Operators.ConvertIntegerToDecimal(hzzr_);
                decimal? hzzt_ = context.Operators.Divide(hzzq_, hzzs_);

                return hzzt_;
            }
            else if (czzr_())
            {
                decimal? hzzu_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? hzzv_ = period?.value;
                decimal? hzzw_ = context.Operators.Divide(24.0m, hzzv_);
                decimal? hzzx_ = context.Operators.Multiply(hzzu_, hzzw_);
                int? hzzy_ = context.Operators.Multiply(24, 365);
                decimal? hzzz_ = context.Operators.ConvertIntegerToDecimal(hzzy_);
                decimal? izza_ = context.Operators.Divide(hzzx_, hzzz_);

                return izza_;
            }
            else if (czzs_())
            {
                decimal? izzb_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? izzc_ = period?.value;
                decimal? izzd_ = context.Operators.Divide(24.0m, izzc_);
                decimal? izze_ = context.Operators.Multiply(izzb_, izzd_);

                return izze_;
            }
            else if (czzt_())
            {
                decimal? izzf_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? izzg_ = period?.value;
                decimal? izzh_ = context.Operators.Divide(24.0m, izzg_);
                decimal? izzi_ = context.Operators.Multiply(izzf_, izzh_);
                decimal? izzj_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? izzk_ = context.Operators.Multiply(izzi_, izzj_);

                return izzk_;
            }
            else if (czzu_())
            {
                decimal? izzl_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? izzm_ = period?.value;
                decimal? izzn_ = context.Operators.Divide(24.0m, izzm_);
                decimal? izzo_ = context.Operators.Multiply(izzl_, izzn_);
                decimal? izzp_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? izzq_ = context.Operators.Multiply(izzo_, izzp_);
                decimal? izzs_ = context.Operators.Multiply(izzq_, izzp_);

                return izzs_;
            }
            else if (czzv_())
            {
                decimal? izzt_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? izzu_ = period?.value;
                decimal? izzv_ = context.Operators.Divide(24.0m, izzu_);
                decimal? izzw_ = context.Operators.Multiply(izzt_, izzv_);
                decimal? izzx_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? izzy_ = context.Operators.Divide(izzw_, izzx_);

                return izzy_;
            }
            else if (czzw_())
            {
                decimal? izzz_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? jzza_ = period?.value;
                decimal? jzzb_ = context.Operators.Divide(24.0m, jzza_);
                decimal? jzzc_ = context.Operators.Multiply(izzz_, jzzb_);
                int? jzzd_ = context.Operators.Multiply(24, 7);
                decimal? jzze_ = context.Operators.ConvertIntegerToDecimal(jzzd_);
                decimal? jzzf_ = context.Operators.Divide(jzzc_, jzze_);

                return jzzf_;
            }
            else if (czzx_())
            {
                decimal? jzzg_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? jzzh_ = period?.value;
                decimal? jzzi_ = context.Operators.Divide(24.0m, jzzh_);
                decimal? jzzj_ = context.Operators.Multiply(jzzg_, jzzi_);
                int? jzzk_ = context.Operators.Multiply(24, 30);
                decimal? jzzl_ = context.Operators.ConvertIntegerToDecimal(jzzk_);
                decimal? jzzm_ = context.Operators.Divide(jzzj_, jzzl_);

                return jzzm_;
            }
            else if (czzy_())
            {
                decimal? jzzn_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? jzzo_ = period?.value;
                decimal? jzzp_ = context.Operators.Divide(24.0m, jzzo_);
                decimal? jzzq_ = context.Operators.Multiply(jzzn_, jzzp_);
                int? jzzr_ = context.Operators.Multiply(24, 365);
                decimal? jzzs_ = context.Operators.ConvertIntegerToDecimal(jzzr_);
                decimal? jzzt_ = context.Operators.Divide(jzzq_, jzzs_);

                return jzzt_;
            }
            else
            {
                string jzzu_ = this.ErrorLevel(context);
                string jzzv_ = period?.unit;
                string jzzw_ = context.Operators.Concatenate("Unknown unit ", jzzv_ ?? "");
                object jzzx_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownUnit", jzzu_, jzzw_);

                return jzzx_ as decimal?;
            }
        };

        return czzd_();
    }


    [CqlExpressionDefinition("ToDaily")]
    public decimal? ToDaily(CqlContext context, CqlCode frequency)
    {
        decimal? jzzy_()
        {
            bool jzzz_()
            {
                CqlCode kzza_ = this.C(context);
                bool? kzzb_ = context.Operators.Equal(frequency, kzza_);

                return kzzb_ ?? false;
            };
            if (jzzz_())
            {
                return 3.0m;
            }
            else
            {
                string kzzc_ = this.ErrorLevel(context);
                string kzzd_ = frequency?.code;
                string kzze_ = context.Operators.Concatenate("Unknown frequency code ", kzzd_ ?? "");
                object kzzf_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownFrequencyCode", kzzc_, kzze_);

                return kzzf_ as decimal?;
            }
        };

        return jzzy_();
    }


    [CqlExpressionDefinition("MedicationRequestPeriod")]
    public CqlInterval<CqlDateTime> MedicationRequestPeriod(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] kzzg_ = [
            Request,
        ];
        CqlInterval<CqlDateTime> kzzh_(MedicationRequest R)
        {
            CqlInterval<CqlDateTime> kzzl_()
            {
                bool kzzm_()
                {
                    List<Dosage> kzzn_ = R?.DosageInstruction;
                    Dosage kzzo_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzn_);
                    Timing kzzp_ = kzzo_?.Timing;
                    Timing.RepeatComponent kzzq_ = kzzp_?.Repeat;
                    DataType kzzr_ = kzzq_?.Bounds;
                    CqlInterval<CqlDateTime> kzzs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, kzzr_ as Period);
                    CqlDateTime kzzt_ = context.Operators.End(kzzs_);
                    Dosage kzzv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzn_);
                    Timing kzzw_ = kzzv_?.Timing;
                    Timing.RepeatComponent kzzx_ = kzzw_?.Repeat;
                    DataType kzzy_ = kzzx_?.Bounds;
                    CqlInterval<CqlDateTime> kzzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, kzzy_ as Period);
                    CqlDateTime lzza_ = context.Operators.End(kzzz_);
                    CqlDateTime lzzb_ = context.Operators.MaxValue<CqlDateTime>();
                    bool? lzzc_ = context.Operators.Equal(lzza_, lzzb_);
                    bool? lzzd_ = context.Operators.Or((bool?)(kzzt_ is null), lzzc_);
                    bool? lzze_ = context.Operators.Not(lzzd_);

                    return lzze_ ?? false;
                };
                if (kzzm_())
                {
                    List<Dosage> lzzf_ = R?.DosageInstruction;
                    Dosage lzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzf_);
                    Timing lzzh_ = lzzg_?.Timing;
                    Timing.RepeatComponent lzzi_ = lzzh_?.Repeat;
                    DataType lzzj_ = lzzi_?.Bounds;
                    CqlInterval<CqlDateTime> lzzk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzj_ as Period);
                    CqlDateTime lzzl_ = context.Operators.Start(lzzk_);
                    MedicationRequest.DispenseRequestComponent lzzm_ = R?.DispenseRequest;
                    Period lzzn_ = lzzm_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> lzzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzn_);
                    CqlDateTime lzzp_ = context.Operators.Start(lzzo_);
                    FhirDateTime lzzq_ = R?.AuthoredOnElement;
                    CqlDateTime lzzr_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, lzzq_);
                    Dosage lzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzf_);
                    Timing lzzu_ = lzzt_?.Timing;
                    Timing.RepeatComponent lzzv_ = lzzu_?.Repeat;
                    DataType lzzw_ = lzzv_?.Bounds;
                    CqlInterval<CqlDateTime> lzzx_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzw_ as Period);
                    CqlDateTime lzzy_ = context.Operators.End(lzzx_);
                    CqlInterval<CqlDateTime> lzzz_ = context.Operators.Interval((lzzl_ ?? lzzp_) ?? lzzr_, lzzy_, true, true);

                    return lzzz_;
                }
                else
                {
                    List<Dosage> mzza_ = R?.DosageInstruction;
                    Dosage mzzb_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)mzza_);
                    Timing mzzc_ = mzzb_?.Timing;
                    Timing.RepeatComponent mzzd_ = mzzc_?.Repeat;
                    DataType mzze_ = mzzd_?.Bounds;
                    CqlInterval<CqlDateTime> mzzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, mzze_ as Period);
                    CqlDateTime mzzg_ = context.Operators.Start(mzzf_);
                    MedicationRequest.DispenseRequestComponent mzzh_ = R?.DispenseRequest;
                    Period mzzi_ = mzzh_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> mzzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, mzzi_);
                    CqlDateTime mzzk_ = context.Operators.Start(mzzj_);
                    FhirDateTime mzzl_ = R?.AuthoredOnElement;
                    CqlDateTime mzzm_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, mzzl_);
                    Dosage mzzo_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)mzza_);
                    Timing mzzp_ = mzzo_?.Timing;
                    Timing.RepeatComponent mzzq_ = mzzp_?.Repeat;
                    DataType mzzr_ = mzzq_?.Bounds;
                    CqlInterval<CqlDateTime> mzzs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, mzzr_ as Period);
                    CqlDateTime mzzt_ = context.Operators.Start(mzzs_);
                    Period mzzv_ = mzzh_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> mzzw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, mzzv_);
                    CqlDateTime mzzx_ = context.Operators.Start(mzzw_);
                    CqlDateTime mzzz_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, mzzl_);
                    Duration nzzb_ = mzzh_?.ExpectedSupplyDuration;
                    CqlQuantity nzzc_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, nzzb_);
                    Quantity nzze_ = mzzh_?.Quantity;
                    CqlQuantity nzzf_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, nzze_);
                    Dosage nzzh_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)mzza_);
                    List<Dosage.DoseAndRateComponent> nzzi_ = nzzh_?.DoseAndRate;
                    Dosage.DoseAndRateComponent nzzj_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)nzzi_);
                    DataType nzzk_ = nzzj_?.Dose;
                    CqlInterval<CqlQuantity> nzzl_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nzzk_ as Range);
                    CqlQuantity nzzm_ = context.Operators.End(nzzl_);
                    Dosage nzzo_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)mzza_);
                    List<Dosage.DoseAndRateComponent> nzzp_ = nzzo_?.DoseAndRate;
                    Dosage.DoseAndRateComponent nzzq_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)nzzp_);
                    DataType nzzr_ = nzzq_?.Dose;
                    CqlQuantity nzzs_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, nzzr_ as Quantity);
                    Dosage nzzu_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)mzza_);
                    Timing nzzv_ = nzzu_?.Timing;
                    Timing.RepeatComponent nzzw_ = nzzv_?.Repeat;
                    PositiveInt nzzx_ = nzzw_?.FrequencyMaxElement;
                    Integer nzzy_ = context.Operators.Convert<Integer>(nzzx_);
                    Dosage ozza_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)mzza_);
                    Timing ozzb_ = ozza_?.Timing;
                    Timing.RepeatComponent ozzc_ = ozzb_?.Repeat;
                    PositiveInt ozzd_ = ozzc_?.FrequencyElement;
                    Integer ozze_ = context.Operators.Convert<Integer>(ozzd_);
                    int? ozzf_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, nzzy_ ?? ozze_);
                    Dosage ozzh_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)mzza_);
                    Timing ozzi_ = ozzh_?.Timing;
                    Timing.RepeatComponent ozzj_ = ozzi_?.Repeat;
                    FhirDecimal ozzk_ = ozzj_?.PeriodElement;
                    decimal? ozzl_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, ozzk_);
                    Dosage ozzn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)mzza_);
                    Timing ozzo_ = ozzn_?.Timing;
                    Timing.RepeatComponent ozzp_ = ozzo_?.Repeat;
                    Code<Timing.UnitsOfTime> ozzq_ = ozzp_?.PeriodUnitElement;
                    Timing.UnitsOfTime? ozzr_ = ozzq_?.Value;
                    string ozzs_ = context.Operators.Convert<string>(ozzr_);
                    decimal? ozzt_ = this.ToDaily(context, ozzf_, new CqlQuantity(ozzl_, ozzs_));
                    Dosage ozzv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)mzza_);
                    Timing ozzw_ = ozzv_?.Timing;
                    Timing.RepeatComponent ozzx_ = ozzw_?.Repeat;
                    List<Time> ozzy_ = ozzx_?.TimeOfDayElement;
                    int? ozzz_ = context.Operators.Count<Time>((IEnumerable<Time>)ozzy_);
                    decimal? pzza_ = context.Operators.ConvertIntegerToDecimal(ozzz_);
                    CqlQuantity pzzb_ = context.Operators.ConvertDecimalToQuantity((ozzt_ ?? pzza_) ?? 1.0m);
                    CqlQuantity pzzc_ = context.Operators.Multiply(nzzm_ ?? nzzs_, pzzb_);
                    CqlQuantity pzzd_ = context.Operators.Divide(nzzf_, pzzc_);
                    UnsignedInt pzzf_ = mzzh_?.NumberOfRepeatsAllowedElement;
                    Integer pzzg_ = context.Operators.Convert<Integer>(pzzf_);
                    int? pzzh_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, pzzg_);
                    int? pzzi_ = context.Operators.Add(1, pzzh_ ?? 0);
                    CqlQuantity pzzj_ = context.Operators.ConvertIntegerToQuantity(pzzi_);
                    CqlQuantity pzzk_ = context.Operators.Multiply(nzzc_ ?? pzzd_, pzzj_);
                    CqlDateTime pzzl_ = context.Operators.Add((mzzt_ ?? mzzx_) ?? mzzz_, pzzk_);
                    CqlInterval<CqlDateTime> pzzm_ = context.Operators.Interval((mzzg_ ?? mzzk_) ?? mzzm_, pzzl_, true, true);

                    return pzzm_;
                }
            };

            return kzzl_();
        };
        IEnumerable<CqlInterval<CqlDateTime>> kzzi_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDateTime>>((IEnumerable<MedicationRequest>)kzzg_, kzzh_);
        IEnumerable<CqlInterval<CqlDateTime>> kzzj_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(kzzi_);
        CqlInterval<CqlDateTime> kzzk_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(kzzj_);

        return kzzk_;
    }


    [CqlExpressionDefinition("MedicationDispensePeriod")]
    public CqlInterval<CqlDateTime> MedicationDispensePeriod(CqlContext context, MedicationDispense Dispense)
    {
        MedicationDispense[] pzzn_ = [
            Dispense,
        ];
        CqlInterval<CqlDateTime> pzzo_(MedicationDispense D)
        {
            FhirDateTime pzzs_ = D?.WhenHandedOverElement;
            FhirDateTime pzzt_ = D?.WhenPreparedElement;
            CqlDateTime pzzu_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, pzzs_ ?? pzzt_);
            CqlDateTime pzzx_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, pzzs_ ?? pzzt_);
            Quantity pzzy_ = D?.DaysSupply;
            CqlQuantity pzzz_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, pzzy_);
            Quantity qzza_ = D?.Quantity;
            CqlQuantity qzzb_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, qzza_);
            List<Dosage> qzzc_ = D?.DosageInstruction;
            Dosage qzzd_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)qzzc_);
            List<Dosage.DoseAndRateComponent> qzze_ = qzzd_?.DoseAndRate;
            Dosage.DoseAndRateComponent qzzf_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)qzze_);
            DataType qzzg_ = qzzf_?.Dose;
            CqlInterval<CqlQuantity> qzzh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, qzzg_ as Range);
            CqlQuantity qzzi_ = context.Operators.End(qzzh_);
            Dosage qzzk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)qzzc_);
            List<Dosage.DoseAndRateComponent> qzzl_ = qzzk_?.DoseAndRate;
            Dosage.DoseAndRateComponent qzzm_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)qzzl_);
            DataType qzzn_ = qzzm_?.Dose;
            CqlQuantity qzzo_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, qzzn_ as Quantity);
            Dosage qzzq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)qzzc_);
            Timing qzzr_ = qzzq_?.Timing;
            Timing.RepeatComponent qzzs_ = qzzr_?.Repeat;
            PositiveInt qzzt_ = qzzs_?.FrequencyMaxElement;
            Integer qzzu_ = context.Operators.Convert<Integer>(qzzt_);
            Dosage qzzw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)qzzc_);
            Timing qzzx_ = qzzw_?.Timing;
            Timing.RepeatComponent qzzy_ = qzzx_?.Repeat;
            PositiveInt qzzz_ = qzzy_?.FrequencyElement;
            Integer rzza_ = context.Operators.Convert<Integer>(qzzz_);
            int? rzzb_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, qzzu_ ?? rzza_);
            Dosage rzzd_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)qzzc_);
            Timing rzze_ = rzzd_?.Timing;
            Timing.RepeatComponent rzzf_ = rzze_?.Repeat;
            FhirDecimal rzzg_ = rzzf_?.PeriodElement;
            decimal? rzzh_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, rzzg_);
            Dosage rzzj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)qzzc_);
            Timing rzzk_ = rzzj_?.Timing;
            Timing.RepeatComponent rzzl_ = rzzk_?.Repeat;
            Code<Timing.UnitsOfTime> rzzm_ = rzzl_?.PeriodUnitElement;
            Timing.UnitsOfTime? rzzn_ = rzzm_?.Value;
            string rzzo_ = context.Operators.Convert<string>(rzzn_);
            decimal? rzzp_ = this.ToDaily(context, rzzb_, new CqlQuantity(rzzh_, rzzo_));
            Dosage rzzr_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)qzzc_);
            Timing rzzs_ = rzzr_?.Timing;
            Timing.RepeatComponent rzzt_ = rzzs_?.Repeat;
            List<Time> rzzu_ = rzzt_?.TimeOfDayElement;
            int? rzzv_ = context.Operators.Count<Time>((IEnumerable<Time>)rzzu_);
            decimal? rzzw_ = context.Operators.ConvertIntegerToDecimal(rzzv_);
            CqlQuantity rzzx_ = context.Operators.ConvertDecimalToQuantity((rzzp_ ?? rzzw_) ?? 1.0m);
            CqlQuantity rzzy_ = context.Operators.Multiply(qzzi_ ?? qzzo_, rzzx_);
            CqlQuantity rzzz_ = context.Operators.Divide(qzzb_, rzzy_);
            CqlDateTime szza_ = context.Operators.Add(pzzx_, pzzz_ ?? rzzz_);
            CqlInterval<CqlDateTime> szzb_ = context.Operators.Interval(pzzu_, szza_, true, true);

            return szzb_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> pzzp_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDateTime>>((IEnumerable<MedicationDispense>)pzzn_, pzzo_);
        IEnumerable<CqlInterval<CqlDateTime>> pzzq_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(pzzp_);
        CqlInterval<CqlDateTime> pzzr_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(pzzq_);

        return pzzr_;
    }


    [CqlExpressionDefinition("TherapeuticDuration")]
    public CqlQuantity TherapeuticDuration(CqlContext context, CqlConcept medication)
    {
        CqlQuantity szzc_ = context.Operators.Quantity(14m, "days");

        return szzc_;
    }


    [CqlExpressionDefinition("MedicationAdministrationPeriod")]
    public CqlInterval<CqlDateTime> MedicationAdministrationPeriod(CqlContext context, MedicationAdministration Administration)
    {
        MedicationAdministration[] szzd_ = [
            Administration,
        ];
        CqlInterval<CqlDateTime> szze_(MedicationAdministration M)
        {
            CqlInterval<CqlDateTime> szzi_()
            {
                bool szzj_()
                {
                    DataType szzk_ = Administration?.Effective;
                    CqlInterval<CqlDateTime> szzl_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, szzk_ as Period);
                    CqlDateTime szzm_ = context.Operators.Start(szzl_);
                    bool? szzn_ = context.Operators.Not((bool?)(szzm_ is null));
                    DataType szzo_ = Administration?.Medication;
                    CqlConcept szzp_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, szzo_ as CodeableConcept);
                    CqlQuantity szzq_ = this.TherapeuticDuration(context, szzp_);
                    bool? szzr_ = context.Operators.Not((bool?)(szzq_ is null));
                    bool? szzs_ = context.Operators.And(szzn_, szzr_);

                    return szzs_ ?? false;
                };
                if (szzj_())
                {
                    DataType szzt_ = Administration?.Effective;
                    CqlInterval<CqlDateTime> szzu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, szzt_ as Period);
                    CqlDateTime szzv_ = context.Operators.Start(szzu_);
                    CqlInterval<CqlDateTime> szzx_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, szzt_ as Period);
                    CqlDateTime szzy_ = context.Operators.Start(szzx_);
                    DataType szzz_ = Administration?.Medication;
                    CqlConcept tzza_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, szzz_ as CodeableConcept);
                    CqlQuantity tzzb_ = this.TherapeuticDuration(context, tzza_);
                    CqlDateTime tzzc_ = context.Operators.Add(szzy_, tzzb_);
                    CqlInterval<CqlDateTime> tzzd_ = context.Operators.Interval(szzv_, tzzc_, true, true);

                    return tzzd_;
                }
                else
                {
                    return null as CqlInterval<CqlDateTime>;
                }
            };

            return szzi_();
        };
        IEnumerable<CqlInterval<CqlDateTime>> szzf_ = context.Operators.Select<MedicationAdministration, CqlInterval<CqlDateTime>>((IEnumerable<MedicationAdministration>)szzd_, szze_);
        IEnumerable<CqlInterval<CqlDateTime>> szzg_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(szzf_);
        CqlInterval<CqlDateTime> szzh_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(szzg_);

        return szzh_;
    }


    [CqlExpressionDefinition("CumulativeDuration")]
    public int? CumulativeDuration(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> Intervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> tzze_ = context.Operators.Collapse(Intervals, "day");
        int? tzzf_(CqlInterval<CqlDateTime> X)
        {
            CqlDateTime tzzi_ = context.Operators.Start(X);
            CqlDateTime tzzj_ = context.Operators.End(X);
            int? tzzk_ = context.Operators.DifferenceBetween(tzzi_, tzzj_, "day");

            return tzzk_;
        };
        IEnumerable<int?> tzzg_ = context.Operators.Select<CqlInterval<CqlDateTime>, int?>(tzze_, tzzf_);
        int? tzzh_ = context.Operators.Sum(tzzg_);

        return tzzh_;
    }


    [CqlExpressionDefinition("RolloutIntervals")]
    public IEnumerable<CqlInterval<CqlDateTime>> RolloutIntervals(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> tzzl_(IEnumerable<CqlInterval<CqlDateTime>> R, CqlInterval<CqlDateTime> I)
        {
            CqlInterval<CqlDateTime>[] tzzn_ = [
                I,
            ];
            CqlInterval<CqlDateTime> tzzo_(CqlInterval<CqlDateTime> X)
            {
                CqlInterval<CqlDateTime> tzzu_ = context.Operators.Last<CqlInterval<CqlDateTime>>(R);
                CqlDateTime tzzv_ = context.Operators.End(tzzu_);
                CqlQuantity tzzw_ = context.Operators.Quantity(1m, "day");
                CqlDateTime tzzx_ = context.Operators.Add(tzzv_, tzzw_);
                CqlDateTime tzzy_ = context.Operators.Start(X);
                CqlDateTime[] tzzz_ = [
                    tzzx_,
                    tzzy_,
                ];
                CqlDateTime uzza_ = context.Operators.Max<CqlDateTime>(tzzz_ as IEnumerable<CqlDateTime>);
                CqlDateTime uzzc_ = context.Operators.End(tzzu_);
                CqlDateTime uzze_ = context.Operators.Add(uzzc_, tzzw_);
                CqlDateTime[] uzzg_ = [
                    uzze_,
                    tzzy_,
                ];
                CqlDateTime uzzh_ = context.Operators.Max<CqlDateTime>(uzzg_ as IEnumerable<CqlDateTime>);
                CqlDateTime uzzj_ = context.Operators.End(X);
                int? uzzk_ = context.Operators.DurationBetween(tzzy_, uzzj_, "day");
                decimal? uzzl_ = context.Operators.ConvertIntegerToDecimal(uzzk_ ?? 0);
                CqlDateTime uzzm_ = context.Operators.Add(uzzh_, new CqlQuantity(uzzl_, "day"));
                CqlInterval<CqlDateTime> uzzn_ = context.Operators.Interval(uzza_, uzzm_, true, true);

                return uzzn_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> tzzp_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>((IEnumerable<CqlInterval<CqlDateTime>>)tzzn_, tzzo_);
            IEnumerable<CqlInterval<CqlDateTime>> tzzq_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(tzzp_);
            CqlInterval<CqlDateTime> tzzr_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(tzzq_);
            CqlInterval<CqlDateTime>[] tzzs_ = [
                tzzr_,
            ];
            IEnumerable<CqlInterval<CqlDateTime>> tzzt_ = context.Operators.Union<CqlInterval<CqlDateTime>>(R, tzzs_ as IEnumerable<CqlInterval<CqlDateTime>>);

            return tzzt_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> tzzm_ = context.Operators.Aggregate<CqlInterval<CqlDateTime>, IEnumerable<CqlInterval<CqlDateTime>>>(intervals, tzzl_, null as IEnumerable<CqlInterval<CqlDateTime>>);

        return tzzm_;
    }


    [CqlExpressionDefinition("MedicationPeriod")]
    public CqlInterval<CqlDateTime> MedicationPeriod(CqlContext context, object medication)
    {
        CqlInterval<CqlDateTime> uzzo_()
        {
            if (medication is MedicationRequest)
            {
                CqlInterval<CqlDateTime> uzzp_ = this.MedicationRequestPeriod(context, medication as MedicationRequest);

                return uzzp_;
            }
            else if (medication is MedicationDispense)
            {
                CqlInterval<CqlDateTime> uzzq_ = this.MedicationDispensePeriod(context, medication as MedicationDispense);

                return uzzq_;
            }
            else if (medication is MedicationAdministration)
            {
                CqlInterval<CqlDateTime> uzzr_ = this.MedicationAdministrationPeriod(context, medication as MedicationAdministration);

                return uzzr_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return uzzo_();
    }


    [CqlExpressionDefinition("CumulativeMedicationDuration")]
    public int? CumulativeMedicationDuration(CqlContext context, IEnumerable<object> Medications)
    {
        bool? uzzs_(object M)
        {
            bool vzzf_ = M is MedicationRequest;

            return vzzf_ as bool?;
        };
        IEnumerable<object> uzzt_ = context.Operators.Where<object>(Medications, uzzs_);
        CqlInterval<CqlDateTime> uzzu_(object M)
        {
            CqlInterval<CqlDateTime> vzzg_ = this.MedicationPeriod(context, M);

            return vzzg_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> uzzv_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(uzzt_, uzzu_);
        IEnumerable<CqlInterval<CqlDateTime>> uzzw_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(uzzv_);
        bool? uzzx_(object M)
        {
            bool vzzh_ = M is MedicationDispense;
            bool vzzi_ = M is MedicationAdministration;
            bool? vzzj_ = context.Operators.Or(vzzh_ as bool?, vzzi_ as bool?);

            return vzzj_;
        };
        IEnumerable<object> uzzy_ = context.Operators.Where<object>(Medications, uzzx_);
        CqlInterval<CqlDateTime> uzzz_(object M)
        {
            CqlInterval<CqlDateTime> vzzk_ = this.MedicationPeriod(context, M);

            return vzzk_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> vzza_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(uzzy_, uzzz_);
        IEnumerable<CqlInterval<CqlDateTime>> vzzb_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(vzza_);
        IEnumerable<CqlInterval<CqlDateTime>> vzzc_ = this.RolloutIntervals(context, vzzb_);
        IEnumerable<CqlInterval<CqlDateTime>> vzzd_ = context.Operators.Union<CqlInterval<CqlDateTime>>(uzzw_, vzzc_);
        int? vzze_ = this.CumulativeDuration(context, vzzd_);

        return vzze_;
    }


    #endregion Expressions

}

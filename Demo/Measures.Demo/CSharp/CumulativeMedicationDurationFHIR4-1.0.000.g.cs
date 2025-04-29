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
        object xzzp_ = context.ResolveParameter("CumulativeMedicationDurationFHIR4-1.0.000", "ErrorLevel", "Warning");

        return (string)xzzp_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> xzzq_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient xzzr_ = context.Operators.SingletonFrom<Patient>(xzzq_);

        return xzzr_;
    }


    [CqlExpressionDefinition("ToDaily")]
    public decimal? ToDaily(CqlContext context, int? frequency, CqlQuantity period)
    {
        decimal? xzzs_()
        {
            bool xzzt_()
            {
                string yzzo_ = period?.unit;
                bool? yzzp_ = context.Operators.Equal(yzzo_, "h");

                return yzzp_ ?? false;
            };
            bool xzzu_()
            {
                string yzzq_ = period?.unit;
                bool? yzzr_ = context.Operators.Equal(yzzq_, "min");

                return yzzr_ ?? false;
            };
            bool xzzv_()
            {
                string yzzs_ = period?.unit;
                bool? yzzt_ = context.Operators.Equal(yzzs_, "s");

                return yzzt_ ?? false;
            };
            bool xzzw_()
            {
                string yzzu_ = period?.unit;
                bool? yzzv_ = context.Operators.Equal(yzzu_, "d");

                return yzzv_ ?? false;
            };
            bool xzzx_()
            {
                string yzzw_ = period?.unit;
                bool? yzzx_ = context.Operators.Equal(yzzw_, "wk");

                return yzzx_ ?? false;
            };
            bool xzzy_()
            {
                string yzzy_ = period?.unit;
                bool? yzzz_ = context.Operators.Equal(yzzy_, "mo");

                return yzzz_ ?? false;
            };
            bool xzzz_()
            {
                string zzza_ = period?.unit;
                bool? zzzb_ = context.Operators.Equal(zzza_, "a");

                return zzzb_ ?? false;
            };
            bool yzza_()
            {
                string zzzc_ = period?.unit;
                bool? zzzd_ = context.Operators.Equal(zzzc_, "hour");

                return zzzd_ ?? false;
            };
            bool yzzb_()
            {
                string zzze_ = period?.unit;
                bool? zzzf_ = context.Operators.Equal(zzze_, "minute");

                return zzzf_ ?? false;
            };
            bool yzzc_()
            {
                string zzzg_ = period?.unit;
                bool? zzzh_ = context.Operators.Equal(zzzg_, "second");

                return zzzh_ ?? false;
            };
            bool yzzd_()
            {
                string zzzi_ = period?.unit;
                bool? zzzj_ = context.Operators.Equal(zzzi_, "day");

                return zzzj_ ?? false;
            };
            bool yzze_()
            {
                string zzzk_ = period?.unit;
                bool? zzzl_ = context.Operators.Equal(zzzk_, "week");

                return zzzl_ ?? false;
            };
            bool yzzf_()
            {
                string zzzm_ = period?.unit;
                bool? zzzn_ = context.Operators.Equal(zzzm_, "month");

                return zzzn_ ?? false;
            };
            bool yzzg_()
            {
                string zzzo_ = period?.unit;
                bool? zzzp_ = context.Operators.Equal(zzzo_, "year");

                return zzzp_ ?? false;
            };
            bool yzzh_()
            {
                string zzzq_ = period?.unit;
                bool? zzzr_ = context.Operators.Equal(zzzq_, "hours");

                return zzzr_ ?? false;
            };
            bool yzzi_()
            {
                string zzzs_ = period?.unit;
                bool? zzzt_ = context.Operators.Equal(zzzs_, "minutes");

                return zzzt_ ?? false;
            };
            bool yzzj_()
            {
                string zzzu_ = period?.unit;
                bool? zzzv_ = context.Operators.Equal(zzzu_, "seconds");

                return zzzv_ ?? false;
            };
            bool yzzk_()
            {
                string zzzw_ = period?.unit;
                bool? zzzx_ = context.Operators.Equal(zzzw_, "days");

                return zzzx_ ?? false;
            };
            bool yzzl_()
            {
                string zzzy_ = period?.unit;
                bool? zzzz_ = context.Operators.Equal(zzzy_, "weeks");

                return zzzz_ ?? false;
            };
            bool yzzm_()
            {
                string azzza_ = period?.unit;
                bool? azzzb_ = context.Operators.Equal(azzza_, "months");

                return azzzb_ ?? false;
            };
            bool yzzn_()
            {
                string azzzc_ = period?.unit;
                bool? azzzd_ = context.Operators.Equal(azzzc_, "years");

                return azzzd_ ?? false;
            };
            if (xzzt_())
            {
                decimal? azzze_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? azzzf_ = period?.value;
                decimal? azzzg_ = context.Operators.Divide(24.0m, azzzf_);
                decimal? azzzh_ = context.Operators.Multiply(azzze_, azzzg_);

                return azzzh_;
            }
            else if (xzzu_())
            {
                decimal? azzzi_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? azzzj_ = period?.value;
                decimal? azzzk_ = context.Operators.Divide(24.0m, azzzj_);
                decimal? azzzl_ = context.Operators.Multiply(azzzi_, azzzk_);
                decimal? azzzm_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? azzzn_ = context.Operators.Multiply(azzzl_, azzzm_);

                return azzzn_;
            }
            else if (xzzv_())
            {
                decimal? azzzo_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? azzzp_ = period?.value;
                decimal? azzzq_ = context.Operators.Divide(24.0m, azzzp_);
                decimal? azzzr_ = context.Operators.Multiply(azzzo_, azzzq_);
                decimal? azzzs_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? azzzt_ = context.Operators.Multiply(azzzr_, azzzs_);
                decimal? azzzv_ = context.Operators.Multiply(azzzt_, azzzs_);

                return azzzv_;
            }
            else if (xzzw_())
            {
                decimal? azzzw_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? azzzx_ = period?.value;
                decimal? azzzy_ = context.Operators.Divide(24.0m, azzzx_);
                decimal? azzzz_ = context.Operators.Multiply(azzzw_, azzzy_);
                decimal? bzzza_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? bzzzb_ = context.Operators.Divide(azzzz_, bzzza_);

                return bzzzb_;
            }
            else if (xzzx_())
            {
                decimal? bzzzc_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? bzzzd_ = period?.value;
                decimal? bzzze_ = context.Operators.Divide(24.0m, bzzzd_);
                decimal? bzzzf_ = context.Operators.Multiply(bzzzc_, bzzze_);
                int? bzzzg_ = context.Operators.Multiply(24, 7);
                decimal? bzzzh_ = context.Operators.ConvertIntegerToDecimal(bzzzg_);
                decimal? bzzzi_ = context.Operators.Divide(bzzzf_, bzzzh_);

                return bzzzi_;
            }
            else if (xzzy_())
            {
                decimal? bzzzj_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? bzzzk_ = period?.value;
                decimal? bzzzl_ = context.Operators.Divide(24.0m, bzzzk_);
                decimal? bzzzm_ = context.Operators.Multiply(bzzzj_, bzzzl_);
                int? bzzzn_ = context.Operators.Multiply(24, 30);
                decimal? bzzzo_ = context.Operators.ConvertIntegerToDecimal(bzzzn_);
                decimal? bzzzp_ = context.Operators.Divide(bzzzm_, bzzzo_);

                return bzzzp_;
            }
            else if (xzzz_())
            {
                decimal? bzzzq_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? bzzzr_ = period?.value;
                decimal? bzzzs_ = context.Operators.Divide(24.0m, bzzzr_);
                decimal? bzzzt_ = context.Operators.Multiply(bzzzq_, bzzzs_);
                int? bzzzu_ = context.Operators.Multiply(24, 365);
                decimal? bzzzv_ = context.Operators.ConvertIntegerToDecimal(bzzzu_);
                decimal? bzzzw_ = context.Operators.Divide(bzzzt_, bzzzv_);

                return bzzzw_;
            }
            else if (yzza_())
            {
                decimal? bzzzx_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? bzzzy_ = period?.value;
                decimal? bzzzz_ = context.Operators.Divide(24.0m, bzzzy_);
                decimal? czzza_ = context.Operators.Multiply(bzzzx_, bzzzz_);

                return czzza_;
            }
            else if (yzzb_())
            {
                decimal? czzzb_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? czzzc_ = period?.value;
                decimal? czzzd_ = context.Operators.Divide(24.0m, czzzc_);
                decimal? czzze_ = context.Operators.Multiply(czzzb_, czzzd_);
                decimal? czzzf_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? czzzg_ = context.Operators.Multiply(czzze_, czzzf_);

                return czzzg_;
            }
            else if (yzzc_())
            {
                decimal? czzzh_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? czzzi_ = period?.value;
                decimal? czzzj_ = context.Operators.Divide(24.0m, czzzi_);
                decimal? czzzk_ = context.Operators.Multiply(czzzh_, czzzj_);
                decimal? czzzl_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? czzzm_ = context.Operators.Multiply(czzzk_, czzzl_);
                decimal? czzzo_ = context.Operators.Multiply(czzzm_, czzzl_);

                return czzzo_;
            }
            else if (yzzd_())
            {
                decimal? czzzp_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? czzzq_ = period?.value;
                decimal? czzzr_ = context.Operators.Divide(24.0m, czzzq_);
                decimal? czzzs_ = context.Operators.Multiply(czzzp_, czzzr_);
                decimal? czzzt_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? czzzu_ = context.Operators.Divide(czzzs_, czzzt_);

                return czzzu_;
            }
            else if (yzze_())
            {
                decimal? czzzv_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? czzzw_ = period?.value;
                decimal? czzzx_ = context.Operators.Divide(24.0m, czzzw_);
                decimal? czzzy_ = context.Operators.Multiply(czzzv_, czzzx_);
                int? czzzz_ = context.Operators.Multiply(24, 7);
                decimal? dzzza_ = context.Operators.ConvertIntegerToDecimal(czzzz_);
                decimal? dzzzb_ = context.Operators.Divide(czzzy_, dzzza_);

                return dzzzb_;
            }
            else if (yzzf_())
            {
                decimal? dzzzc_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? dzzzd_ = period?.value;
                decimal? dzzze_ = context.Operators.Divide(24.0m, dzzzd_);
                decimal? dzzzf_ = context.Operators.Multiply(dzzzc_, dzzze_);
                int? dzzzg_ = context.Operators.Multiply(24, 30);
                decimal? dzzzh_ = context.Operators.ConvertIntegerToDecimal(dzzzg_);
                decimal? dzzzi_ = context.Operators.Divide(dzzzf_, dzzzh_);

                return dzzzi_;
            }
            else if (yzzg_())
            {
                decimal? dzzzj_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? dzzzk_ = period?.value;
                decimal? dzzzl_ = context.Operators.Divide(24.0m, dzzzk_);
                decimal? dzzzm_ = context.Operators.Multiply(dzzzj_, dzzzl_);
                int? dzzzn_ = context.Operators.Multiply(24, 365);
                decimal? dzzzo_ = context.Operators.ConvertIntegerToDecimal(dzzzn_);
                decimal? dzzzp_ = context.Operators.Divide(dzzzm_, dzzzo_);

                return dzzzp_;
            }
            else if (yzzh_())
            {
                decimal? dzzzq_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? dzzzr_ = period?.value;
                decimal? dzzzs_ = context.Operators.Divide(24.0m, dzzzr_);
                decimal? dzzzt_ = context.Operators.Multiply(dzzzq_, dzzzs_);

                return dzzzt_;
            }
            else if (yzzi_())
            {
                decimal? dzzzu_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? dzzzv_ = period?.value;
                decimal? dzzzw_ = context.Operators.Divide(24.0m, dzzzv_);
                decimal? dzzzx_ = context.Operators.Multiply(dzzzu_, dzzzw_);
                decimal? dzzzy_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? dzzzz_ = context.Operators.Multiply(dzzzx_, dzzzy_);

                return dzzzz_;
            }
            else if (yzzj_())
            {
                decimal? ezzza_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ezzzb_ = period?.value;
                decimal? ezzzc_ = context.Operators.Divide(24.0m, ezzzb_);
                decimal? ezzzd_ = context.Operators.Multiply(ezzza_, ezzzc_);
                decimal? ezzze_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? ezzzf_ = context.Operators.Multiply(ezzzd_, ezzze_);
                decimal? ezzzh_ = context.Operators.Multiply(ezzzf_, ezzze_);

                return ezzzh_;
            }
            else if (yzzk_())
            {
                decimal? ezzzi_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ezzzj_ = period?.value;
                decimal? ezzzk_ = context.Operators.Divide(24.0m, ezzzj_);
                decimal? ezzzl_ = context.Operators.Multiply(ezzzi_, ezzzk_);
                decimal? ezzzm_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? ezzzn_ = context.Operators.Divide(ezzzl_, ezzzm_);

                return ezzzn_;
            }
            else if (yzzl_())
            {
                decimal? ezzzo_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ezzzp_ = period?.value;
                decimal? ezzzq_ = context.Operators.Divide(24.0m, ezzzp_);
                decimal? ezzzr_ = context.Operators.Multiply(ezzzo_, ezzzq_);
                int? ezzzs_ = context.Operators.Multiply(24, 7);
                decimal? ezzzt_ = context.Operators.ConvertIntegerToDecimal(ezzzs_);
                decimal? ezzzu_ = context.Operators.Divide(ezzzr_, ezzzt_);

                return ezzzu_;
            }
            else if (yzzm_())
            {
                decimal? ezzzv_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ezzzw_ = period?.value;
                decimal? ezzzx_ = context.Operators.Divide(24.0m, ezzzw_);
                decimal? ezzzy_ = context.Operators.Multiply(ezzzv_, ezzzx_);
                int? ezzzz_ = context.Operators.Multiply(24, 30);
                decimal? fzzza_ = context.Operators.ConvertIntegerToDecimal(ezzzz_);
                decimal? fzzzb_ = context.Operators.Divide(ezzzy_, fzzza_);

                return fzzzb_;
            }
            else if (yzzn_())
            {
                decimal? fzzzc_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fzzzd_ = period?.value;
                decimal? fzzze_ = context.Operators.Divide(24.0m, fzzzd_);
                decimal? fzzzf_ = context.Operators.Multiply(fzzzc_, fzzze_);
                int? fzzzg_ = context.Operators.Multiply(24, 365);
                decimal? fzzzh_ = context.Operators.ConvertIntegerToDecimal(fzzzg_);
                decimal? fzzzi_ = context.Operators.Divide(fzzzf_, fzzzh_);

                return fzzzi_;
            }
            else
            {
                string fzzzj_ = this.ErrorLevel(context);
                string fzzzk_ = period?.unit;
                string fzzzl_ = context.Operators.Concatenate("Unknown unit ", fzzzk_ ?? "");
                object fzzzm_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownUnit", fzzzj_, fzzzl_);

                return fzzzm_ as decimal?;
            }
        };

        return xzzs_();
    }


    [CqlExpressionDefinition("ToDaily")]
    public decimal? ToDaily(CqlContext context, CqlCode frequency)
    {
        decimal? fzzzn_()
        {
            bool fzzzo_()
            {
                CqlCode fzzzp_ = this.C(context);
                bool? fzzzq_ = context.Operators.Equal(frequency, fzzzp_);

                return fzzzq_ ?? false;
            };
            if (fzzzo_())
            {
                return 3.0m;
            }
            else
            {
                string fzzzr_ = this.ErrorLevel(context);
                string fzzzs_ = frequency?.code;
                string fzzzt_ = context.Operators.Concatenate("Unknown frequency code ", fzzzs_ ?? "");
                object fzzzu_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownFrequencyCode", fzzzr_, fzzzt_);

                return fzzzu_ as decimal?;
            }
        };

        return fzzzn_();
    }


    [CqlExpressionDefinition("MedicationRequestPeriod")]
    public CqlInterval<CqlDateTime> MedicationRequestPeriod(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] fzzzv_ = [
            Request,
        ];
        CqlInterval<CqlDateTime> fzzzw_(MedicationRequest R)
        {
            CqlInterval<CqlDateTime> gzzza_()
            {
                bool gzzzb_()
                {
                    List<Dosage> gzzzc_ = R?.DosageInstruction;
                    Dosage gzzzd_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)gzzzc_);
                    Timing gzzze_ = gzzzd_?.Timing;
                    Timing.RepeatComponent gzzzf_ = gzzze_?.Repeat;
                    DataType gzzzg_ = gzzzf_?.Bounds;
                    CqlInterval<CqlDateTime> gzzzh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzzzg_ as Period);
                    CqlDateTime gzzzi_ = context.Operators.End(gzzzh_);
                    Dosage gzzzk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)gzzzc_);
                    Timing gzzzl_ = gzzzk_?.Timing;
                    Timing.RepeatComponent gzzzm_ = gzzzl_?.Repeat;
                    DataType gzzzn_ = gzzzm_?.Bounds;
                    CqlInterval<CqlDateTime> gzzzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzzzn_ as Period);
                    CqlDateTime gzzzp_ = context.Operators.End(gzzzo_);
                    CqlDateTime gzzzq_ = context.Operators.MaxValue<CqlDateTime>();
                    bool? gzzzr_ = context.Operators.Equal(gzzzp_, gzzzq_);
                    bool? gzzzs_ = context.Operators.Or((bool?)(gzzzi_ is null), gzzzr_);
                    bool? gzzzt_ = context.Operators.Not(gzzzs_);

                    return gzzzt_ ?? false;
                };
                if (gzzzb_())
                {
                    List<Dosage> gzzzu_ = R?.DosageInstruction;
                    Dosage gzzzv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)gzzzu_);
                    Timing gzzzw_ = gzzzv_?.Timing;
                    Timing.RepeatComponent gzzzx_ = gzzzw_?.Repeat;
                    DataType gzzzy_ = gzzzx_?.Bounds;
                    CqlInterval<CqlDateTime> gzzzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzzzy_ as Period);
                    CqlDateTime hzzza_ = context.Operators.Start(gzzzz_);
                    MedicationRequest.DispenseRequestComponent hzzzb_ = R?.DispenseRequest;
                    Period hzzzc_ = hzzzb_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> hzzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzc_);
                    CqlDateTime hzzze_ = context.Operators.Start(hzzzd_);
                    FhirDateTime hzzzf_ = R?.AuthoredOnElement;
                    CqlDateTime hzzzg_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, hzzzf_);
                    Dosage hzzzi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)gzzzu_);
                    Timing hzzzj_ = hzzzi_?.Timing;
                    Timing.RepeatComponent hzzzk_ = hzzzj_?.Repeat;
                    DataType hzzzl_ = hzzzk_?.Bounds;
                    CqlInterval<CqlDateTime> hzzzm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzl_ as Period);
                    CqlDateTime hzzzn_ = context.Operators.End(hzzzm_);
                    CqlInterval<CqlDateTime> hzzzo_ = context.Operators.Interval((hzzza_ ?? hzzze_) ?? hzzzg_, hzzzn_, true, true);

                    return hzzzo_;
                }
                else
                {
                    List<Dosage> hzzzp_ = R?.DosageInstruction;
                    Dosage hzzzq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hzzzp_);
                    Timing hzzzr_ = hzzzq_?.Timing;
                    Timing.RepeatComponent hzzzs_ = hzzzr_?.Repeat;
                    DataType hzzzt_ = hzzzs_?.Bounds;
                    CqlInterval<CqlDateTime> hzzzu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzt_ as Period);
                    CqlDateTime hzzzv_ = context.Operators.Start(hzzzu_);
                    MedicationRequest.DispenseRequestComponent hzzzw_ = R?.DispenseRequest;
                    Period hzzzx_ = hzzzw_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> hzzzy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzx_);
                    CqlDateTime hzzzz_ = context.Operators.Start(hzzzy_);
                    FhirDateTime izzza_ = R?.AuthoredOnElement;
                    CqlDateTime izzzb_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, izzza_);
                    Dosage izzzd_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hzzzp_);
                    Timing izzze_ = izzzd_?.Timing;
                    Timing.RepeatComponent izzzf_ = izzze_?.Repeat;
                    DataType izzzg_ = izzzf_?.Bounds;
                    CqlInterval<CqlDateTime> izzzh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, izzzg_ as Period);
                    CqlDateTime izzzi_ = context.Operators.Start(izzzh_);
                    Period izzzk_ = hzzzw_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> izzzl_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, izzzk_);
                    CqlDateTime izzzm_ = context.Operators.Start(izzzl_);
                    CqlDateTime izzzo_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, izzza_);
                    Duration izzzq_ = hzzzw_?.ExpectedSupplyDuration;
                    CqlQuantity izzzr_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, izzzq_);
                    Quantity izzzt_ = hzzzw_?.Quantity;
                    CqlQuantity izzzu_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, izzzt_);
                    Dosage izzzw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hzzzp_);
                    List<Dosage.DoseAndRateComponent> izzzx_ = izzzw_?.DoseAndRate;
                    Dosage.DoseAndRateComponent izzzy_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)izzzx_);
                    DataType izzzz_ = izzzy_?.Dose;
                    CqlInterval<CqlQuantity> jzzza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, izzzz_ as Range);
                    CqlQuantity jzzzb_ = context.Operators.End(jzzza_);
                    Dosage jzzzd_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hzzzp_);
                    List<Dosage.DoseAndRateComponent> jzzze_ = jzzzd_?.DoseAndRate;
                    Dosage.DoseAndRateComponent jzzzf_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)jzzze_);
                    DataType jzzzg_ = jzzzf_?.Dose;
                    CqlQuantity jzzzh_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, jzzzg_ as Quantity);
                    Dosage jzzzj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hzzzp_);
                    Timing jzzzk_ = jzzzj_?.Timing;
                    Timing.RepeatComponent jzzzl_ = jzzzk_?.Repeat;
                    PositiveInt jzzzm_ = jzzzl_?.FrequencyMaxElement;
                    Integer jzzzn_ = context.Operators.Convert<Integer>(jzzzm_);
                    Dosage jzzzp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hzzzp_);
                    Timing jzzzq_ = jzzzp_?.Timing;
                    Timing.RepeatComponent jzzzr_ = jzzzq_?.Repeat;
                    PositiveInt jzzzs_ = jzzzr_?.FrequencyElement;
                    Integer jzzzt_ = context.Operators.Convert<Integer>(jzzzs_);
                    int? jzzzu_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, jzzzn_ ?? jzzzt_);
                    Dosage jzzzw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hzzzp_);
                    Timing jzzzx_ = jzzzw_?.Timing;
                    Timing.RepeatComponent jzzzy_ = jzzzx_?.Repeat;
                    FhirDecimal jzzzz_ = jzzzy_?.PeriodElement;
                    decimal? kzzza_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, jzzzz_);
                    Dosage kzzzc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hzzzp_);
                    Timing kzzzd_ = kzzzc_?.Timing;
                    Timing.RepeatComponent kzzze_ = kzzzd_?.Repeat;
                    Code<Timing.UnitsOfTime> kzzzf_ = kzzze_?.PeriodUnitElement;
                    Timing.UnitsOfTime? kzzzg_ = kzzzf_?.Value;
                    string kzzzh_ = context.Operators.Convert<string>(kzzzg_);
                    decimal? kzzzi_ = this.ToDaily(context, jzzzu_, new CqlQuantity(kzzza_, kzzzh_));
                    Dosage kzzzk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hzzzp_);
                    Timing kzzzl_ = kzzzk_?.Timing;
                    Timing.RepeatComponent kzzzm_ = kzzzl_?.Repeat;
                    List<Time> kzzzn_ = kzzzm_?.TimeOfDayElement;
                    int? kzzzo_ = context.Operators.Count<Time>((IEnumerable<Time>)kzzzn_);
                    decimal? kzzzp_ = context.Operators.ConvertIntegerToDecimal(kzzzo_);
                    CqlQuantity kzzzq_ = context.Operators.ConvertDecimalToQuantity((kzzzi_ ?? kzzzp_) ?? 1.0m);
                    CqlQuantity kzzzr_ = context.Operators.Multiply(jzzzb_ ?? jzzzh_, kzzzq_);
                    CqlQuantity kzzzs_ = context.Operators.Divide(izzzu_, kzzzr_);
                    UnsignedInt kzzzu_ = hzzzw_?.NumberOfRepeatsAllowedElement;
                    Integer kzzzv_ = context.Operators.Convert<Integer>(kzzzu_);
                    int? kzzzw_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, kzzzv_);
                    int? kzzzx_ = context.Operators.Add(1, kzzzw_ ?? 0);
                    CqlQuantity kzzzy_ = context.Operators.ConvertIntegerToQuantity(kzzzx_);
                    CqlQuantity kzzzz_ = context.Operators.Multiply(izzzr_ ?? kzzzs_, kzzzy_);
                    CqlDateTime lzzza_ = context.Operators.Add((izzzi_ ?? izzzm_) ?? izzzo_, kzzzz_);
                    CqlInterval<CqlDateTime> lzzzb_ = context.Operators.Interval((hzzzv_ ?? hzzzz_) ?? izzzb_, lzzza_, true, true);

                    return lzzzb_;
                }
            };

            return gzzza_();
        };
        IEnumerable<CqlInterval<CqlDateTime>> fzzzx_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDateTime>>((IEnumerable<MedicationRequest>)fzzzv_, fzzzw_);
        IEnumerable<CqlInterval<CqlDateTime>> fzzzy_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(fzzzx_);
        CqlInterval<CqlDateTime> fzzzz_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(fzzzy_);

        return fzzzz_;
    }


    [CqlExpressionDefinition("MedicationDispensePeriod")]
    public CqlInterval<CqlDateTime> MedicationDispensePeriod(CqlContext context, MedicationDispense Dispense)
    {
        MedicationDispense[] lzzzc_ = [
            Dispense,
        ];
        CqlInterval<CqlDateTime> lzzzd_(MedicationDispense D)
        {
            FhirDateTime lzzzh_ = D?.WhenHandedOverElement;
            FhirDateTime lzzzi_ = D?.WhenPreparedElement;
            CqlDateTime lzzzj_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, lzzzh_ ?? lzzzi_);
            CqlDateTime lzzzm_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, lzzzh_ ?? lzzzi_);
            Quantity lzzzn_ = D?.DaysSupply;
            CqlQuantity lzzzo_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, lzzzn_);
            Quantity lzzzp_ = D?.Quantity;
            CqlQuantity lzzzq_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, lzzzp_);
            List<Dosage> lzzzr_ = D?.DosageInstruction;
            Dosage lzzzs_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzr_);
            List<Dosage.DoseAndRateComponent> lzzzt_ = lzzzs_?.DoseAndRate;
            Dosage.DoseAndRateComponent lzzzu_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)lzzzt_);
            DataType lzzzv_ = lzzzu_?.Dose;
            CqlInterval<CqlQuantity> lzzzw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzv_ as Range);
            CqlQuantity lzzzx_ = context.Operators.End(lzzzw_);
            Dosage lzzzz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzr_);
            List<Dosage.DoseAndRateComponent> mzzza_ = lzzzz_?.DoseAndRate;
            Dosage.DoseAndRateComponent mzzzb_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)mzzza_);
            DataType mzzzc_ = mzzzb_?.Dose;
            CqlQuantity mzzzd_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, mzzzc_ as Quantity);
            Dosage mzzzf_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzr_);
            Timing mzzzg_ = mzzzf_?.Timing;
            Timing.RepeatComponent mzzzh_ = mzzzg_?.Repeat;
            PositiveInt mzzzi_ = mzzzh_?.FrequencyMaxElement;
            Integer mzzzj_ = context.Operators.Convert<Integer>(mzzzi_);
            Dosage mzzzl_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzr_);
            Timing mzzzm_ = mzzzl_?.Timing;
            Timing.RepeatComponent mzzzn_ = mzzzm_?.Repeat;
            PositiveInt mzzzo_ = mzzzn_?.FrequencyElement;
            Integer mzzzp_ = context.Operators.Convert<Integer>(mzzzo_);
            int? mzzzq_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, mzzzj_ ?? mzzzp_);
            Dosage mzzzs_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzr_);
            Timing mzzzt_ = mzzzs_?.Timing;
            Timing.RepeatComponent mzzzu_ = mzzzt_?.Repeat;
            FhirDecimal mzzzv_ = mzzzu_?.PeriodElement;
            decimal? mzzzw_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, mzzzv_);
            Dosage mzzzy_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzr_);
            Timing mzzzz_ = mzzzy_?.Timing;
            Timing.RepeatComponent nzzza_ = mzzzz_?.Repeat;
            Code<Timing.UnitsOfTime> nzzzb_ = nzzza_?.PeriodUnitElement;
            Timing.UnitsOfTime? nzzzc_ = nzzzb_?.Value;
            string nzzzd_ = context.Operators.Convert<string>(nzzzc_);
            decimal? nzzze_ = this.ToDaily(context, mzzzq_, new CqlQuantity(mzzzw_, nzzzd_));
            Dosage nzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzr_);
            Timing nzzzh_ = nzzzg_?.Timing;
            Timing.RepeatComponent nzzzi_ = nzzzh_?.Repeat;
            List<Time> nzzzj_ = nzzzi_?.TimeOfDayElement;
            int? nzzzk_ = context.Operators.Count<Time>((IEnumerable<Time>)nzzzj_);
            decimal? nzzzl_ = context.Operators.ConvertIntegerToDecimal(nzzzk_);
            CqlQuantity nzzzm_ = context.Operators.ConvertDecimalToQuantity((nzzze_ ?? nzzzl_) ?? 1.0m);
            CqlQuantity nzzzn_ = context.Operators.Multiply(lzzzx_ ?? mzzzd_, nzzzm_);
            CqlQuantity nzzzo_ = context.Operators.Divide(lzzzq_, nzzzn_);
            CqlDateTime nzzzp_ = context.Operators.Add(lzzzm_, lzzzo_ ?? nzzzo_);
            CqlInterval<CqlDateTime> nzzzq_ = context.Operators.Interval(lzzzj_, nzzzp_, true, true);

            return nzzzq_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> lzzze_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDateTime>>((IEnumerable<MedicationDispense>)lzzzc_, lzzzd_);
        IEnumerable<CqlInterval<CqlDateTime>> lzzzf_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(lzzze_);
        CqlInterval<CqlDateTime> lzzzg_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(lzzzf_);

        return lzzzg_;
    }


    [CqlExpressionDefinition("TherapeuticDuration")]
    public CqlQuantity TherapeuticDuration(CqlContext context, CqlConcept medication)
    {
        CqlQuantity nzzzr_ = context.Operators.Quantity(14m, "days");

        return nzzzr_;
    }


    [CqlExpressionDefinition("MedicationAdministrationPeriod")]
    public CqlInterval<CqlDateTime> MedicationAdministrationPeriod(CqlContext context, MedicationAdministration Administration)
    {
        MedicationAdministration[] nzzzs_ = [
            Administration,
        ];
        CqlInterval<CqlDateTime> nzzzt_(MedicationAdministration M)
        {
            CqlInterval<CqlDateTime> nzzzx_()
            {
                bool nzzzy_()
                {
                    DataType nzzzz_ = Administration?.Effective;
                    CqlInterval<CqlDateTime> ozzza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nzzzz_ as Period);
                    CqlDateTime ozzzb_ = context.Operators.Start(ozzza_);
                    bool? ozzzc_ = context.Operators.Not((bool?)(ozzzb_ is null));
                    DataType ozzzd_ = Administration?.Medication;
                    CqlConcept ozzze_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ozzzd_ as CodeableConcept);
                    CqlQuantity ozzzf_ = this.TherapeuticDuration(context, ozzze_);
                    bool? ozzzg_ = context.Operators.Not((bool?)(ozzzf_ is null));
                    bool? ozzzh_ = context.Operators.And(ozzzc_, ozzzg_);

                    return ozzzh_ ?? false;
                };
                if (nzzzy_())
                {
                    DataType ozzzi_ = Administration?.Effective;
                    CqlInterval<CqlDateTime> ozzzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ozzzi_ as Period);
                    CqlDateTime ozzzk_ = context.Operators.Start(ozzzj_);
                    CqlInterval<CqlDateTime> ozzzm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ozzzi_ as Period);
                    CqlDateTime ozzzn_ = context.Operators.Start(ozzzm_);
                    DataType ozzzo_ = Administration?.Medication;
                    CqlConcept ozzzp_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ozzzo_ as CodeableConcept);
                    CqlQuantity ozzzq_ = this.TherapeuticDuration(context, ozzzp_);
                    CqlDateTime ozzzr_ = context.Operators.Add(ozzzn_, ozzzq_);
                    CqlInterval<CqlDateTime> ozzzs_ = context.Operators.Interval(ozzzk_, ozzzr_, true, true);

                    return ozzzs_;
                }
                else
                {
                    return null as CqlInterval<CqlDateTime>;
                }
            };

            return nzzzx_();
        };
        IEnumerable<CqlInterval<CqlDateTime>> nzzzu_ = context.Operators.Select<MedicationAdministration, CqlInterval<CqlDateTime>>((IEnumerable<MedicationAdministration>)nzzzs_, nzzzt_);
        IEnumerable<CqlInterval<CqlDateTime>> nzzzv_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(nzzzu_);
        CqlInterval<CqlDateTime> nzzzw_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(nzzzv_);

        return nzzzw_;
    }


    [CqlExpressionDefinition("CumulativeDuration")]
    public int? CumulativeDuration(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> Intervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> ozzzt_ = context.Operators.Collapse(Intervals, "day");
        int? ozzzu_(CqlInterval<CqlDateTime> X)
        {
            CqlDateTime ozzzx_ = context.Operators.Start(X);
            CqlDateTime ozzzy_ = context.Operators.End(X);
            int? ozzzz_ = context.Operators.DifferenceBetween(ozzzx_, ozzzy_, "day");

            return ozzzz_;
        };
        IEnumerable<int?> ozzzv_ = context.Operators.Select<CqlInterval<CqlDateTime>, int?>(ozzzt_, ozzzu_);
        int? ozzzw_ = context.Operators.Sum(ozzzv_);

        return ozzzw_;
    }


    [CqlExpressionDefinition("RolloutIntervals")]
    public IEnumerable<CqlInterval<CqlDateTime>> RolloutIntervals(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> pzzza_(IEnumerable<CqlInterval<CqlDateTime>> R, CqlInterval<CqlDateTime> I)
        {
            CqlInterval<CqlDateTime>[] pzzzc_ = [
                I,
            ];
            CqlInterval<CqlDateTime> pzzzd_(CqlInterval<CqlDateTime> X)
            {
                CqlInterval<CqlDateTime> pzzzj_ = context.Operators.Last<CqlInterval<CqlDateTime>>(R);
                CqlDateTime pzzzk_ = context.Operators.End(pzzzj_);
                CqlQuantity pzzzl_ = context.Operators.Quantity(1m, "day");
                CqlDateTime pzzzm_ = context.Operators.Add(pzzzk_, pzzzl_);
                CqlDateTime pzzzn_ = context.Operators.Start(X);
                CqlDateTime[] pzzzo_ = [
                    pzzzm_,
                    pzzzn_,
                ];
                CqlDateTime pzzzp_ = context.Operators.Max<CqlDateTime>(pzzzo_ as IEnumerable<CqlDateTime>);
                CqlDateTime pzzzr_ = context.Operators.End(pzzzj_);
                CqlDateTime pzzzt_ = context.Operators.Add(pzzzr_, pzzzl_);
                CqlDateTime[] pzzzv_ = [
                    pzzzt_,
                    pzzzn_,
                ];
                CqlDateTime pzzzw_ = context.Operators.Max<CqlDateTime>(pzzzv_ as IEnumerable<CqlDateTime>);
                CqlDateTime pzzzy_ = context.Operators.End(X);
                int? pzzzz_ = context.Operators.DurationBetween(pzzzn_, pzzzy_, "day");
                decimal? qzzza_ = context.Operators.ConvertIntegerToDecimal(pzzzz_ ?? 0);
                CqlDateTime qzzzb_ = context.Operators.Add(pzzzw_, new CqlQuantity(qzzza_, "day"));
                CqlInterval<CqlDateTime> qzzzc_ = context.Operators.Interval(pzzzp_, qzzzb_, true, true);

                return qzzzc_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> pzzze_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>((IEnumerable<CqlInterval<CqlDateTime>>)pzzzc_, pzzzd_);
            IEnumerable<CqlInterval<CqlDateTime>> pzzzf_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(pzzze_);
            CqlInterval<CqlDateTime> pzzzg_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(pzzzf_);
            CqlInterval<CqlDateTime>[] pzzzh_ = [
                pzzzg_,
            ];
            IEnumerable<CqlInterval<CqlDateTime>> pzzzi_ = context.Operators.Union<CqlInterval<CqlDateTime>>(R, pzzzh_ as IEnumerable<CqlInterval<CqlDateTime>>);

            return pzzzi_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> pzzzb_ = context.Operators.Aggregate<CqlInterval<CqlDateTime>, IEnumerable<CqlInterval<CqlDateTime>>>(intervals, pzzza_, null as IEnumerable<CqlInterval<CqlDateTime>>);

        return pzzzb_;
    }


    [CqlExpressionDefinition("MedicationPeriod")]
    public CqlInterval<CqlDateTime> MedicationPeriod(CqlContext context, object medication)
    {
        CqlInterval<CqlDateTime> qzzzd_()
        {
            if (medication is MedicationRequest)
            {
                CqlInterval<CqlDateTime> qzzze_ = this.MedicationRequestPeriod(context, medication as MedicationRequest);

                return qzzze_;
            }
            else if (medication is MedicationDispense)
            {
                CqlInterval<CqlDateTime> qzzzf_ = this.MedicationDispensePeriod(context, medication as MedicationDispense);

                return qzzzf_;
            }
            else if (medication is MedicationAdministration)
            {
                CqlInterval<CqlDateTime> qzzzg_ = this.MedicationAdministrationPeriod(context, medication as MedicationAdministration);

                return qzzzg_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return qzzzd_();
    }


    [CqlExpressionDefinition("CumulativeMedicationDuration")]
    public int? CumulativeMedicationDuration(CqlContext context, IEnumerable<object> Medications)
    {
        bool? qzzzh_(object M)
        {
            bool qzzzu_ = M is MedicationRequest;

            return qzzzu_ as bool?;
        };
        IEnumerable<object> qzzzi_ = context.Operators.Where<object>(Medications, qzzzh_);
        CqlInterval<CqlDateTime> qzzzj_(object M)
        {
            CqlInterval<CqlDateTime> qzzzv_ = this.MedicationPeriod(context, M);

            return qzzzv_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> qzzzk_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(qzzzi_, qzzzj_);
        IEnumerable<CqlInterval<CqlDateTime>> qzzzl_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(qzzzk_);
        bool? qzzzm_(object M)
        {
            bool qzzzw_ = M is MedicationDispense;
            bool qzzzx_ = M is MedicationAdministration;
            bool? qzzzy_ = context.Operators.Or(qzzzw_ as bool?, qzzzx_ as bool?);

            return qzzzy_;
        };
        IEnumerable<object> qzzzn_ = context.Operators.Where<object>(Medications, qzzzm_);
        CqlInterval<CqlDateTime> qzzzo_(object M)
        {
            CqlInterval<CqlDateTime> qzzzz_ = this.MedicationPeriod(context, M);

            return qzzzz_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> qzzzp_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(qzzzn_, qzzzo_);
        IEnumerable<CqlInterval<CqlDateTime>> qzzzq_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(qzzzp_);
        IEnumerable<CqlInterval<CqlDateTime>> qzzzr_ = this.RolloutIntervals(context, qzzzq_);
        IEnumerable<CqlInterval<CqlDateTime>> qzzzs_ = context.Operators.Union<CqlInterval<CqlDateTime>>(qzzzl_, qzzzr_);
        int? qzzzt_ = this.CumulativeDuration(context, qzzzs_);

        return qzzzt_;
    }


    #endregion Expressions

}

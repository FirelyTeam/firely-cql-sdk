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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.4.0")]
[CqlLibrary("LogicTest", "1.0.0")]
public partial class LogicTest_1_0_0 : ILibrary, ISingleton<LogicTest_1_0_0>
{
    #region Functions and Expressions (75)

    [CqlExpressionDefinition("TrueDef")]
    public bool? TrueDef(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_TrueDef, TrueDef_Compute);

    private const long _cacheIndex_TrueDef = 8695258810056459513L;

    private bool? TrueDef_Compute(CqlContext context) =>
    true;


    [CqlExpressionDefinition("FalseDef")]
    public bool? FalseDef(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_FalseDef, FalseDef_Compute);

    private const long _cacheIndex_FalseDef = -1153506289229004377L;

    private bool? FalseDef_Compute(CqlContext context) =>
    false;


    [CqlExpressionDefinition("NullDef")]
    public bool? NullDef(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NullDef, NullDef_Compute);

    private const long _cacheIndex_NullDef = -1960364525887554068L;

    private bool? NullDef_Compute(CqlContext context) =>
    null as bool?;


    [CqlExpressionDefinition("TrueAndTrue")]
    public bool? TrueAndTrue(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_TrueAndTrue, TrueAndTrue_Compute);

    private const long _cacheIndex_TrueAndTrue = 3175886595860423209L;

    private bool? TrueAndTrue_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.TrueDef(context);
        return /* CQL 'and' (14:23-14:45) */ (a_
            && this.TrueDef(context));
    }


    [CqlExpressionDefinition("TrueAndFalse")]
    public bool? TrueAndFalse(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_TrueAndFalse, TrueAndFalse_Compute);

    private const long _cacheIndex_TrueAndFalse = 2402434322278207291L;

    private bool? TrueAndFalse_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.TrueDef(context);
        return /* CQL 'and' (15:24-15:47) */ (a_
            && this.FalseDef(context));
    }


    [CqlExpressionDefinition("TrueAndNull")]
    public bool? TrueAndNull(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_TrueAndNull, TrueAndNull_Compute);

    private const long _cacheIndex_TrueAndNull = -6548773168773365305L;

    private bool? TrueAndNull_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.TrueDef(context);
        return /* CQL 'and' (16:23-16:45) */ (a_
            && this.NullDef(context));
    }


    [CqlExpressionDefinition("FalseAndTrue")]
    public bool? FalseAndTrue(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_FalseAndTrue, FalseAndTrue_Compute);

    private const long _cacheIndex_FalseAndTrue = -1049221129794965886L;

    private bool? FalseAndTrue_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.FalseDef(context);
        return /* CQL 'and' (17:24-17:47) */ (a_
            && this.TrueDef(context));
    }


    [CqlExpressionDefinition("FalseAndFalse")]
    public bool? FalseAndFalse(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_FalseAndFalse, FalseAndFalse_Compute);

    private const long _cacheIndex_FalseAndFalse = 8438047267469276059L;

    private bool? FalseAndFalse_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.FalseDef(context);
        return /* CQL 'and' (18:25-18:49) */ (a_
            && this.FalseDef(context));
    }


    [CqlExpressionDefinition("FalseAndNull")]
    public bool? FalseAndNull(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_FalseAndNull, FalseAndNull_Compute);

    private const long _cacheIndex_FalseAndNull = 1770801144687097009L;

    private bool? FalseAndNull_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.FalseDef(context);
        return /* CQL 'and' (19:24-19:47) */ (a_
            && this.NullDef(context));
    }


    [CqlExpressionDefinition("NullAndTrue")]
    public bool? NullAndTrue(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NullAndTrue, NullAndTrue_Compute);

    private const long _cacheIndex_NullAndTrue = -2846714698405996596L;

    private bool? NullAndTrue_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.NullDef(context);
        return /* CQL 'and' (20:23-20:45) */ (a_
            && this.TrueDef(context));
    }


    [CqlExpressionDefinition("NullAndFalse")]
    public bool? NullAndFalse(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NullAndFalse, NullAndFalse_Compute);

    private const long _cacheIndex_NullAndFalse = 461712863949105489L;

    private bool? NullAndFalse_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.NullDef(context);
        return /* CQL 'and' (21:24-21:47) */ (a_
            && this.FalseDef(context));
    }


    [CqlExpressionDefinition("NullAndNull")]
    public bool? NullAndNull(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NullAndNull, NullAndNull_Compute);

    private const long _cacheIndex_NullAndNull = 7007813899238833339L;

    private bool? NullAndNull_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.NullDef(context);
        return /* CQL 'and' (22:23-22:45) */ (a_
            && this.NullDef(context));
    }


    [CqlExpressionDefinition("TrueOrTrue")]
    public bool? TrueOrTrue(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_TrueOrTrue, TrueOrTrue_Compute);

    private const long _cacheIndex_TrueOrTrue = 7770390960775030238L;

    private bool? TrueOrTrue_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.TrueDef(context);
        return /* CQL 'or' (26:22-26:43) */ (a_
            || this.TrueDef(context));
    }


    [CqlExpressionDefinition("TrueOrFalse")]
    public bool? TrueOrFalse(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_TrueOrFalse, TrueOrFalse_Compute);

    private const long _cacheIndex_TrueOrFalse = 868424899985272186L;

    private bool? TrueOrFalse_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.TrueDef(context);
        return /* CQL 'or' (27:23-27:45) */ (a_
            || this.FalseDef(context));
    }


    [CqlExpressionDefinition("TrueOrNull")]
    public bool? TrueOrNull(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_TrueOrNull, TrueOrNull_Compute);

    private const long _cacheIndex_TrueOrNull = 2772132171640374233L;

    private bool? TrueOrNull_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.TrueDef(context);
        return /* CQL 'or' (28:22-28:43) */ (a_
            || this.NullDef(context));
    }


    [CqlExpressionDefinition("FalseOrTrue")]
    public bool? FalseOrTrue(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_FalseOrTrue, FalseOrTrue_Compute);

    private const long _cacheIndex_FalseOrTrue = -1538065522608164292L;

    private bool? FalseOrTrue_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.FalseDef(context);
        return /* CQL 'or' (29:23-29:45) */ (a_
            || this.TrueDef(context));
    }


    [CqlExpressionDefinition("FalseOrFalse")]
    public bool? FalseOrFalse(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_FalseOrFalse, FalseOrFalse_Compute);

    private const long _cacheIndex_FalseOrFalse = 5508490935053832377L;

    private bool? FalseOrFalse_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.FalseDef(context);
        return /* CQL 'or' (30:24-30:47) */ (a_
            || this.FalseDef(context));
    }


    [CqlExpressionDefinition("FalseOrNull")]
    public bool? FalseOrNull(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_FalseOrNull, FalseOrNull_Compute);

    private const long _cacheIndex_FalseOrNull = -7300284525742632252L;

    private bool? FalseOrNull_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.FalseDef(context);
        return /* CQL 'or' (31:23-31:45) */ (a_
            || this.NullDef(context));
    }


    [CqlExpressionDefinition("NullOrTrue")]
    public bool? NullOrTrue(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NullOrTrue, NullOrTrue_Compute);

    private const long _cacheIndex_NullOrTrue = -7734944794822741454L;

    private bool? NullOrTrue_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.NullDef(context);
        return /* CQL 'or' (32:22-32:43) */ (a_
            || this.TrueDef(context));
    }


    [CqlExpressionDefinition("NullOrFalse")]
    public bool? NullOrFalse(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NullOrFalse, NullOrFalse_Compute);

    private const long _cacheIndex_NullOrFalse = -3884023131928972549L;

    private bool? NullOrFalse_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.NullDef(context);
        return /* CQL 'or' (33:23-33:45) */ (a_
            || this.FalseDef(context));
    }


    [CqlExpressionDefinition("NullOrNull")]
    public bool? NullOrNull(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NullOrNull, NullOrNull_Compute);

    private const long _cacheIndex_NullOrNull = 8141806920369182324L;

    private bool? NullOrNull_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.NullDef(context);
        return /* CQL 'or' (34:22-34:43) */ (a_
            || this.NullDef(context));
    }


    [CqlExpressionDefinition("NotTrue")]
    public bool? NotTrue(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NotTrue, NotTrue_Compute);

    private const long _cacheIndex_NotTrue = -720132485395097622L;

    private bool? NotTrue_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.TrueDef(context);
        return !a_;
    }


    [CqlExpressionDefinition("NotFalse")]
    public bool? NotFalse(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NotFalse, NotFalse_Compute);

    private const long _cacheIndex_NotFalse = 5797409228687898054L;

    private bool? NotFalse_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.FalseDef(context);
        return !a_;
    }


    [CqlExpressionDefinition("NotNull")]
    public bool? NotNull(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NotNull, NotNull_Compute);

    private const long _cacheIndex_NotNull = -2746923336515982801L;

    private bool? NotNull_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.NullDef(context);
        return !a_;
    }


    [CqlExpressionDefinition("TrueImpliesTrue")]
    public bool? TrueImpliesTrue(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_TrueImpliesTrue, TrueImpliesTrue_Compute);

    private const long _cacheIndex_TrueImpliesTrue = -3855992125403761954L;

    private bool? TrueImpliesTrue_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.TrueDef(context);
        return /* CQL 'implies' (47:27-47:53) */ (!a_
            || this.TrueDef(context));
    }


    [CqlExpressionDefinition("TrueImpliesFalse")]
    public bool? TrueImpliesFalse(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_TrueImpliesFalse, TrueImpliesFalse_Compute);

    private const long _cacheIndex_TrueImpliesFalse = -6448797414521626502L;

    private bool? TrueImpliesFalse_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.TrueDef(context);
        return /* CQL 'implies' (48:28-48:55) */ (!a_
            || this.FalseDef(context));
    }


    [CqlExpressionDefinition("TrueImpliesNull")]
    public bool? TrueImpliesNull(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_TrueImpliesNull, TrueImpliesNull_Compute);

    private const long _cacheIndex_TrueImpliesNull = 7286837735510949964L;

    private bool? TrueImpliesNull_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.TrueDef(context);
        return /* CQL 'implies' (49:27-49:53) */ (!a_
            || this.NullDef(context));
    }


    [CqlExpressionDefinition("FalseImpliesTrue")]
    public bool? FalseImpliesTrue(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_FalseImpliesTrue, FalseImpliesTrue_Compute);

    private const long _cacheIndex_FalseImpliesTrue = 5144507781050604012L;

    private bool? FalseImpliesTrue_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.FalseDef(context);
        return /* CQL 'implies' (50:28-50:55) */ (!a_
            || this.TrueDef(context));
    }


    [CqlExpressionDefinition("FalseImpliesFalse")]
    public bool? FalseImpliesFalse(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_FalseImpliesFalse, FalseImpliesFalse_Compute);

    private const long _cacheIndex_FalseImpliesFalse = 8477709469594901258L;

    private bool? FalseImpliesFalse_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.FalseDef(context);
        return /* CQL 'implies' (51:29-51:57) */ (!a_
            || this.FalseDef(context));
    }


    [CqlExpressionDefinition("FalseImpliesNull")]
    public bool? FalseImpliesNull(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_FalseImpliesNull, FalseImpliesNull_Compute);

    private const long _cacheIndex_FalseImpliesNull = -8818756293318756661L;

    private bool? FalseImpliesNull_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.FalseDef(context);
        return /* CQL 'implies' (52:28-52:55) */ (!a_
            || this.NullDef(context));
    }


    [CqlExpressionDefinition("NullImpliesTrue")]
    public bool? NullImpliesTrue(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NullImpliesTrue, NullImpliesTrue_Compute);

    private const long _cacheIndex_NullImpliesTrue = 7588203257769067285L;

    private bool? NullImpliesTrue_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.NullDef(context);
        return /* CQL 'implies' (53:27-53:53) */ (!a_
            || this.TrueDef(context));
    }


    [CqlExpressionDefinition("NullImpliesFalse")]
    public bool? NullImpliesFalse(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NullImpliesFalse, NullImpliesFalse_Compute);

    private const long _cacheIndex_NullImpliesFalse = 2403964895244208421L;

    private bool? NullImpliesFalse_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.NullDef(context);
        return /* CQL 'implies' (54:28-54:55) */ (!a_
            || this.FalseDef(context));
    }


    [CqlExpressionDefinition("NullImpliesNull")]
    public bool? NullImpliesNull(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NullImpliesNull, NullImpliesNull_Compute);

    private const long _cacheIndex_NullImpliesNull = 5394125129579437454L;

    private bool? NullImpliesNull_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.NullDef(context);
        return /* CQL 'implies' (55:27-55:53) */ (!a_
            || this.NullDef(context));
    }


    [CqlExpressionDefinition("TrueXorTrue")]
    public bool? TrueXorTrue(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_TrueXorTrue, TrueXorTrue_Compute);

    private const long _cacheIndex_TrueXorTrue = -72584741565750664L;

    private bool? TrueXorTrue_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.TrueDef(context);
        // CQL 'xor' (61:23-61:45): right operand skipped when left is null
        if (!a_.HasValue)
        {
            return null as bool?;
        }
        else
        {
            return a_ ^ a_;
        }
    }


    [CqlExpressionDefinition("TrueXorFalse")]
    public bool? TrueXorFalse(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_TrueXorFalse, TrueXorFalse_Compute);

    private const long _cacheIndex_TrueXorFalse = 3942128939045360167L;

    private bool? TrueXorFalse_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.TrueDef(context);
        // CQL 'xor' (62:24-62:47): right operand skipped when left is null
        if (!a_.HasValue)
        {
            return null as bool?;
        }
        else
        {
            CqlBoolean b_ = this.FalseDef(context);
            return a_ ^ b_;
        }
    }


    [CqlExpressionDefinition("TrueXorNull")]
    public bool? TrueXorNull(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_TrueXorNull, TrueXorNull_Compute);

    private const long _cacheIndex_TrueXorNull = 2713838874476583718L;

    private bool? TrueXorNull_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.TrueDef(context);
        // CQL 'xor' (63:23-63:45): right operand skipped when left is null
        if (!a_.HasValue)
        {
            return null as bool?;
        }
        else
        {
            CqlBoolean b_ = this.NullDef(context);
            return a_ ^ b_;
        }
    }


    [CqlExpressionDefinition("FalseXorTrue")]
    public bool? FalseXorTrue(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_FalseXorTrue, FalseXorTrue_Compute);

    private const long _cacheIndex_FalseXorTrue = -323949464551542579L;

    private bool? FalseXorTrue_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.FalseDef(context);
        // CQL 'xor' (64:24-64:47): right operand skipped when left is null
        if (!a_.HasValue)
        {
            return null as bool?;
        }
        else
        {
            CqlBoolean b_ = this.TrueDef(context);
            return a_ ^ b_;
        }
    }


    [CqlExpressionDefinition("FalseXorFalse")]
    public bool? FalseXorFalse(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_FalseXorFalse, FalseXorFalse_Compute);

    private const long _cacheIndex_FalseXorFalse = 935599281683206897L;

    private bool? FalseXorFalse_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.FalseDef(context);
        // CQL 'xor' (65:25-65:49): right operand skipped when left is null
        if (!a_.HasValue)
        {
            return null as bool?;
        }
        else
        {
            return a_ ^ a_;
        }
    }


    [CqlExpressionDefinition("FalseXorNull")]
    public bool? FalseXorNull(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_FalseXorNull, FalseXorNull_Compute);

    private const long _cacheIndex_FalseXorNull = -9130889666758141463L;

    private bool? FalseXorNull_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.FalseDef(context);
        // CQL 'xor' (66:24-66:47): right operand skipped when left is null
        if (!a_.HasValue)
        {
            return null as bool?;
        }
        else
        {
            CqlBoolean b_ = this.NullDef(context);
            return a_ ^ b_;
        }
    }


    [CqlExpressionDefinition("NullXorTrue")]
    public bool? NullXorTrue(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NullXorTrue, NullXorTrue_Compute);

    private const long _cacheIndex_NullXorTrue = -5266320330534426569L;

    private bool? NullXorTrue_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.NullDef(context);
        // CQL 'xor' (67:23-67:45): right operand skipped when left is null
        if (!a_.HasValue)
        {
            return null as bool?;
        }
        else
        {
            CqlBoolean b_ = this.TrueDef(context);
            return a_ ^ b_;
        }
    }


    [CqlExpressionDefinition("NullXorFalse")]
    public bool? NullXorFalse(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NullXorFalse, NullXorFalse_Compute);

    private const long _cacheIndex_NullXorFalse = 777952543571425582L;

    private bool? NullXorFalse_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.NullDef(context);
        // CQL 'xor' (68:24-68:47): right operand skipped when left is null
        if (!a_.HasValue)
        {
            return null as bool?;
        }
        else
        {
            CqlBoolean b_ = this.FalseDef(context);
            return a_ ^ b_;
        }
    }


    [CqlExpressionDefinition("NullXorNull")]
    public bool? NullXorNull(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NullXorNull, NullXorNull_Compute);

    private const long _cacheIndex_NullXorNull = 8665309572024493719L;

    private bool? NullXorNull_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.NullDef(context);
        // CQL 'xor' (69:23-69:45): right operand skipped when left is null
        if (!a_.HasValue)
        {
            return null as bool?;
        }
        else
        {
            return a_ ^ a_;
        }
    }


    [CqlExpressionDefinition("IsTrueOfTrue")]
    public bool? IsTrueOfTrue(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_IsTrueOfTrue, IsTrueOfTrue_Compute);

    private const long _cacheIndex_IsTrueOfTrue = -9082299094269066274L;

    private bool? IsTrueOfTrue_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.TrueDef(context);
        return /* CQL 'is true' (74:24-74:40) */ a_.IsTrue;
    }


    [CqlExpressionDefinition("IsTrueOfFalse")]
    public bool? IsTrueOfFalse(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_IsTrueOfFalse, IsTrueOfFalse_Compute);

    private const long _cacheIndex_IsTrueOfFalse = 2188487973343878129L;

    private bool? IsTrueOfFalse_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.FalseDef(context);
        return /* CQL 'is true' (75:25-75:42) */ a_.IsTrue;
    }


    [CqlExpressionDefinition("IsTrueOfNull")]
    public bool? IsTrueOfNull(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_IsTrueOfNull, IsTrueOfNull_Compute);

    private const long _cacheIndex_IsTrueOfNull = 2807570337149838357L;

    private bool? IsTrueOfNull_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.NullDef(context);
        return /* CQL 'is true' (76:24-76:40) */ a_.IsTrue;
    }


    [CqlExpressionDefinition("IsFalseOfTrue")]
    public bool? IsFalseOfTrue(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_IsFalseOfTrue, IsFalseOfTrue_Compute);

    private const long _cacheIndex_IsFalseOfTrue = -2075390844107612382L;

    private bool? IsFalseOfTrue_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.TrueDef(context);
        return /* CQL 'is false' (77:25-77:42) */ a_.IsFalse;
    }


    [CqlExpressionDefinition("IsFalseOfFalse")]
    public bool? IsFalseOfFalse(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_IsFalseOfFalse, IsFalseOfFalse_Compute);

    private const long _cacheIndex_IsFalseOfFalse = 2370722370862217716L;

    private bool? IsFalseOfFalse_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.FalseDef(context);
        return /* CQL 'is false' (78:26-78:44) */ a_.IsFalse;
    }


    [CqlExpressionDefinition("IsFalseOfNull")]
    public bool? IsFalseOfNull(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_IsFalseOfNull, IsFalseOfNull_Compute);

    private const long _cacheIndex_IsFalseOfNull = 4836709858901969675L;

    private bool? IsFalseOfNull_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.NullDef(context);
        return /* CQL 'is false' (79:25-79:42) */ a_.IsFalse;
    }


    [CqlExpressionDefinition("MessageTrue")]
    public bool? MessageTrue(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_MessageTrue, MessageTrue_Compute);

    private const long _cacheIndex_MessageTrue = -1183929036212382666L;

    private bool? MessageTrue_Compute(CqlContext context)
    {
        CqlBoolean a_ = context.Operators.Message<bool?>(true, "LogicTest.RightEvaluated", "Trace", "right operand was evaluated");
        return a_;
    }


    [CqlExpressionDefinition("FalseAndMessage")]
    public bool? FalseAndMessage(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_FalseAndMessage, FalseAndMessage_Compute);

    private const long _cacheIndex_FalseAndMessage = 7790241003974374341L;

    private bool? FalseAndMessage_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.FalseDef(context);
        return /* CQL 'and' (87:27-87:54) */ (a_
            && this.MessageTrue(context));
    }


    [CqlExpressionDefinition("NullAndMessage")]
    public bool? NullAndMessage(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NullAndMessage, NullAndMessage_Compute);

    private const long _cacheIndex_NullAndMessage = 3631261854072518504L;

    private bool? NullAndMessage_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.NullDef(context);
        return /* CQL 'and' (88:26-88:52) */ (a_
            && this.MessageTrue(context));
    }


    [CqlExpressionDefinition("TrueOrMessage")]
    public bool? TrueOrMessage(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_TrueOrMessage, TrueOrMessage_Compute);

    private const long _cacheIndex_TrueOrMessage = -3217363591803775302L;

    private bool? TrueOrMessage_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.TrueDef(context);
        return /* CQL 'or' (89:25-89:50) */ (a_
            || this.MessageTrue(context));
    }


    [CqlExpressionDefinition("NullOrMessage")]
    public bool? NullOrMessage(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NullOrMessage, NullOrMessage_Compute);

    private const long _cacheIndex_NullOrMessage = -3825503697359147518L;

    private bool? NullOrMessage_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.NullDef(context);
        return /* CQL 'or' (90:25-90:50) */ (a_
            || this.MessageTrue(context));
    }


    [CqlExpressionDefinition("FalseImpliesMessage")]
    public bool? FalseImpliesMessage(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_FalseImpliesMessage, FalseImpliesMessage_Compute);

    private const long _cacheIndex_FalseImpliesMessage = 224422728064813357L;

    private bool? FalseImpliesMessage_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.FalseDef(context);
        return /* CQL 'implies' (96:31-96:62) */ (!a_
            || this.MessageTrue(context));
    }


    [CqlExpressionDefinition("TrueImpliesMessage")]
    public bool? TrueImpliesMessage(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_TrueImpliesMessage, TrueImpliesMessage_Compute);

    private const long _cacheIndex_TrueImpliesMessage = 1152474649622660502L;

    private bool? TrueImpliesMessage_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.TrueDef(context);
        return /* CQL 'implies' (97:30-97:60) */ (!a_
            || this.MessageTrue(context));
    }


    [CqlExpressionDefinition("NullImpliesMessage")]
    public bool? NullImpliesMessage(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NullImpliesMessage, NullImpliesMessage_Compute);

    private const long _cacheIndex_NullImpliesMessage = 1781180213769303682L;

    private bool? NullImpliesMessage_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.NullDef(context);
        return /* CQL 'implies' (98:30-98:60) */ (!a_
            || this.MessageTrue(context));
    }


    [CqlExpressionDefinition("NullXorMessage")]
    public bool? NullXorMessage(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NullXorMessage, NullXorMessage_Compute);

    private const long _cacheIndex_NullXorMessage = 8592517570249659593L;

    private bool? NullXorMessage_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.NullDef(context);
        // CQL 'xor' (102:26-102:52): right operand skipped when left is null
        if (!a_.HasValue)
        {
            return null as bool?;
        }
        else
        {
            CqlBoolean b_ = this.MessageTrue(context);
            return a_ ^ b_;
        }
    }


    [CqlExpressionDefinition("TrueXorMessage")]
    public bool? TrueXorMessage(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_TrueXorMessage, TrueXorMessage_Compute);

    private const long _cacheIndex_TrueXorMessage = 2754556398843653824L;

    private bool? TrueXorMessage_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.TrueDef(context);
        // CQL 'xor' (103:26-103:52): right operand skipped when left is null
        if (!a_.HasValue)
        {
            return null as bool?;
        }
        else
        {
            CqlBoolean b_ = this.MessageTrue(context);
            return a_ ^ b_;
        }
    }


    [CqlExpressionDefinition("FalseXorMessage")]
    public bool? FalseXorMessage(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_FalseXorMessage, FalseXorMessage_Compute);

    private const long _cacheIndex_FalseXorMessage = -255875278441176938L;

    private bool? FalseXorMessage_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.FalseDef(context);
        // CQL 'xor' (104:27-104:54): right operand skipped when left is null
        if (!a_.HasValue)
        {
            return null as bool?;
        }
        else
        {
            CqlBoolean b_ = this.MessageTrue(context);
            return a_ ^ b_;
        }
    }


    [CqlExpressionDefinition("XorNullConstCollapses")]
    public bool? XorNullConstCollapses(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_XorNullConstCollapses, XorNullConstCollapses_Compute);

    private const long _cacheIndex_XorNullConstCollapses = -8064644459664983679L;

    private bool? XorNullConstCollapses_Compute(CqlContext context) =>
    default;


    [CqlFunctionDefinition("GuardedAnd")]
    public bool? GuardedAnd(CqlContext context, bool? leftOperand) =>
    /* CQL 'and' (114:52-114:80) */ ((CqlBoolean)leftOperand
        && this.MessageTrue(context));


    [CqlExpressionDefinition("GuardInConditionalTest")]
    public int? GuardInConditionalTest(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_GuardInConditionalTest, GuardInConditionalTest_Compute);

    private const long _cacheIndex_GuardInConditionalTest = -4665996238304954048L;

    private int? GuardInConditionalTest_Compute(CqlContext context) =>
    (((bool?)(/* CQL 'and' (121:37-121:63) */ ((CqlBoolean)(this.TrueDef(context))
        && this.MessageTrue(context)))) ?? false
        ? 1
        : 2);


    [CqlExpressionDefinition("OrTrueCollapses")]
    public bool? OrTrueCollapses(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_OrTrueCollapses, OrTrueCollapses_Compute);

    private const long _cacheIndex_OrTrueCollapses = -398136422757845998L;

    private bool? OrTrueCollapses_Compute(CqlContext context) =>
    true;


    [CqlExpressionDefinition("AndFalseCollapses")]
    public bool? AndFalseCollapses(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_AndFalseCollapses, AndFalseCollapses_Compute);

    private const long _cacheIndex_AndFalseCollapses = 358067145510925159L;

    private bool? AndFalseCollapses_Compute(CqlContext context) =>
    false;


    [CqlExpressionDefinition("NestedOrTrueCollapses")]
    public bool? NestedOrTrueCollapses(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NestedOrTrueCollapses, NestedOrTrueCollapses_Compute);

    private const long _cacheIndex_NestedOrTrueCollapses = 6749509943476213257L;

    private bool? NestedOrTrueCollapses_Compute(CqlContext context) =>
    true;


    [CqlFunctionDefinition("MergeAnd")]
    public bool? MergeAnd(CqlContext context, bool? x, bool? y) =>
    /* CQL 'and' (137:51-137:57) */ x & y;


    [CqlFunctionDefinition("MergeOr")]
    public bool? MergeOr(CqlContext context, bool? x, bool? y) =>
    /* CQL 'or' (138:50-138:55) */ x | y;


    [CqlFunctionDefinition("AndNotY")]
    public bool? AndNotY(CqlContext context, bool? x, bool? y) =>
    /* CQL 'and' (139:50-139:62) */ ((CqlBoolean)x
        && !y);


    [CqlExpressionDefinition("FalseConstAndMessage")]
    public bool? FalseConstAndMessage(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_FalseConstAndMessage, FalseConstAndMessage_Compute);

    private const long _cacheIndex_FalseConstAndMessage = -4647495172560512321L;

    private bool? FalseConstAndMessage_Compute(CqlContext context) =>
    false;


    [CqlExpressionDefinition("TrueConstOrMessage")]
    public bool? TrueConstOrMessage(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_TrueConstOrMessage, TrueConstOrMessage_Compute);

    private const long _cacheIndex_TrueConstOrMessage = -7567486519881887743L;

    private bool? TrueConstOrMessage_Compute(CqlContext context) =>
    true;


    [CqlExpressionDefinition("AndTrueKeepsLeft")]
    public bool? AndTrueKeepsLeft(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_AndTrueKeepsLeft, AndTrueKeepsLeft_Compute);

    private const long _cacheIndex_AndTrueKeepsLeft = -4441759063147544212L;

    private bool? AndTrueKeepsLeft_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.MessageTrue(context);
        return a_;
    }


    [CqlExpressionDefinition("OrFalseKeepsLeft")]
    public bool? OrFalseKeepsLeft(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_OrFalseKeepsLeft, OrFalseKeepsLeft_Compute);

    private const long _cacheIndex_OrFalseKeepsLeft = -3602507866754804772L;

    private bool? OrFalseKeepsLeft_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.MessageTrue(context);
        return a_;
    }


    [CqlExpressionDefinition("NullConstAndMessage")]
    public bool? NullConstAndMessage(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NullConstAndMessage, NullConstAndMessage_Compute);

    private const long _cacheIndex_NullConstAndMessage = -5619580611191908217L;

    private bool? NullConstAndMessage_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.MessageTrue(context);
        return /* CQL 'and' (151:31-151:65) */ (null as bool?) & a_;
    }


    [CqlExpressionDefinition("NotNullConst")]
    public bool? NotNullConst(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NotNullConst, NotNullConst_Compute);

    private const long _cacheIndex_NotNullConst = -125356187018132898L;

    private bool? NotNullConst_Compute(CqlContext context) =>
    default;


    [CqlExpressionDefinition("WithoutClause")]
    public bool? WithoutClause(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_WithoutClause, WithoutClause_Compute);

    private const long _cacheIndex_WithoutClause = -6981368337809022043L;

    private bool? WithoutClause_Compute(CqlContext context)
    {
        int?[] a_ = [
            1,
            2,
        ];

        bool? b_(int? A) {
            int?[] d_ = [
                2,
            ];

            bool? e_(int? B) {
                CqlBoolean g_ = context.Operators.Equal(A, B);
                return g_;
            }

            CqlBoolean f_ = context.Operators.WhereAny<int?>((IEnumerable<int?>)d_, e_);
            return !f_;
        }

        CqlBoolean c_ = context.Operators.WhereAny<int?>((IEnumerable<int?>)a_, b_);
        return c_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private LogicTest_1_0_0() {}

    public static LogicTest_1_0_0 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "LogicTest";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [];

    #endregion ILibrary Implementation

}

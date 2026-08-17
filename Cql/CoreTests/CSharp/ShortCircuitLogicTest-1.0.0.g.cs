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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.0.0")]
[CqlLibrary("ShortCircuitLogicTest", "1.0.0")]
public partial class ShortCircuitLogicTest_1_0_0 : ILibrary, ISingleton<ShortCircuitLogicTest_1_0_0>
{
    #region Functions and Expressions (56)

    [CqlExpressionDefinition("TrueDef")]
    public bool? TrueDef(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_TrueDef, TrueDef_Compute);

    private const long _cacheIndex_TrueDef = 6906747209256692075L;

    private bool? TrueDef_Compute(CqlContext context) =>
    true;


    [CqlExpressionDefinition("FalseDef")]
    public bool? FalseDef(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_FalseDef, FalseDef_Compute);

    private const long _cacheIndex_FalseDef = 1967309166682081223L;

    private bool? FalseDef_Compute(CqlContext context) =>
    false;


    [CqlExpressionDefinition("NullDef")]
    public bool? NullDef(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NullDef, NullDef_Compute);

    private const long _cacheIndex_NullDef = 6917249230637831674L;

    private bool? NullDef_Compute(CqlContext context) =>
    null as bool?;


    [CqlExpressionDefinition("TrueAndTrue")]
    public bool? TrueAndTrue(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_TrueAndTrue, TrueAndTrue_Compute);

    private const long _cacheIndex_TrueAndTrue = 738658864263402353L;

    private bool? TrueAndTrue_Compute(CqlContext context)
    {
        bool? a_ = this.TrueDef(context);
        // CQL 'and' (14:23-14:45): right operand skipped when left is false
        if (a_ is false)
        {
            return false;
        }
        else
        {
            return a_ & a_;
        }
    }


    [CqlExpressionDefinition("TrueAndFalse")]
    public bool? TrueAndFalse(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_TrueAndFalse, TrueAndFalse_Compute);

    private const long _cacheIndex_TrueAndFalse = -7149804423627678278L;

    private bool? TrueAndFalse_Compute(CqlContext context)
    {
        bool? a_ = this.TrueDef(context);
        // CQL 'and' (15:24-15:47): right operand skipped when left is false
        if (a_ is false)
        {
            return false;
        }
        else
        {
            bool? b_ = this.FalseDef(context);
            return a_ & b_;
        }
    }


    [CqlExpressionDefinition("TrueAndNull")]
    public bool? TrueAndNull(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_TrueAndNull, TrueAndNull_Compute);

    private const long _cacheIndex_TrueAndNull = 3546052863821557253L;

    private bool? TrueAndNull_Compute(CqlContext context)
    {
        bool? a_ = this.TrueDef(context);
        // CQL 'and' (16:23-16:45): right operand skipped when left is false
        if (a_ is false)
        {
            return false;
        }
        else
        {
            bool? b_ = this.NullDef(context);
            return a_ & b_;
        }
    }


    [CqlExpressionDefinition("FalseAndTrue")]
    public bool? FalseAndTrue(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_FalseAndTrue, FalseAndTrue_Compute);

    private const long _cacheIndex_FalseAndTrue = -2855958281227428672L;

    private bool? FalseAndTrue_Compute(CqlContext context)
    {
        bool? a_ = this.FalseDef(context);
        // CQL 'and' (17:24-17:47): right operand skipped when left is false
        if (a_ is false)
        {
            return false;
        }
        else
        {
            bool? b_ = this.TrueDef(context);
            return a_ & b_;
        }
    }


    [CqlExpressionDefinition("FalseAndFalse")]
    public bool? FalseAndFalse(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_FalseAndFalse, FalseAndFalse_Compute);

    private const long _cacheIndex_FalseAndFalse = -7855344066033225260L;

    private bool? FalseAndFalse_Compute(CqlContext context)
    {
        bool? a_ = this.FalseDef(context);
        // CQL 'and' (18:25-18:49): right operand skipped when left is false
        if (a_ is false)
        {
            return false;
        }
        else
        {
            return a_ & a_;
        }
    }


    [CqlExpressionDefinition("FalseAndNull")]
    public bool? FalseAndNull(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_FalseAndNull, FalseAndNull_Compute);

    private const long _cacheIndex_FalseAndNull = 5197080635225272572L;

    private bool? FalseAndNull_Compute(CqlContext context)
    {
        bool? a_ = this.FalseDef(context);
        // CQL 'and' (19:24-19:47): right operand skipped when left is false
        if (a_ is false)
        {
            return false;
        }
        else
        {
            bool? b_ = this.NullDef(context);
            return a_ & b_;
        }
    }


    [CqlExpressionDefinition("NullAndTrue")]
    public bool? NullAndTrue(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NullAndTrue, NullAndTrue_Compute);

    private const long _cacheIndex_NullAndTrue = -6323749620942422183L;

    private bool? NullAndTrue_Compute(CqlContext context)
    {
        bool? a_ = this.NullDef(context);
        // CQL 'and' (20:23-20:45): right operand skipped when left is false
        if (a_ is false)
        {
            return false;
        }
        else
        {
            bool? b_ = this.TrueDef(context);
            return a_ & b_;
        }
    }


    [CqlExpressionDefinition("NullAndFalse")]
    public bool? NullAndFalse(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NullAndFalse, NullAndFalse_Compute);

    private const long _cacheIndex_NullAndFalse = -1345105208846195223L;

    private bool? NullAndFalse_Compute(CqlContext context)
    {
        bool? a_ = this.NullDef(context);
        // CQL 'and' (21:24-21:47): right operand skipped when left is false
        if (a_ is false)
        {
            return false;
        }
        else
        {
            bool? b_ = this.FalseDef(context);
            return a_ & b_;
        }
    }


    [CqlExpressionDefinition("NullAndNull")]
    public bool? NullAndNull(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NullAndNull, NullAndNull_Compute);

    private const long _cacheIndex_NullAndNull = -4940114077198460355L;

    private bool? NullAndNull_Compute(CqlContext context)
    {
        bool? a_ = this.NullDef(context);
        // CQL 'and' (22:23-22:45): right operand skipped when left is false
        if (a_ is false)
        {
            return false;
        }
        else
        {
            return a_ & a_;
        }
    }


    [CqlExpressionDefinition("TrueOrTrue")]
    public bool? TrueOrTrue(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_TrueOrTrue, TrueOrTrue_Compute);

    private const long _cacheIndex_TrueOrTrue = -8089555219407954293L;

    private bool? TrueOrTrue_Compute(CqlContext context)
    {
        bool? a_ = this.TrueDef(context);
        // CQL 'or' (26:22-26:43): right operand skipped when left is true
        if (a_ is true)
        {
            return true;
        }
        else
        {
            return a_ | a_;
        }
    }


    [CqlExpressionDefinition("TrueOrFalse")]
    public bool? TrueOrFalse(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_TrueOrFalse, TrueOrFalse_Compute);

    private const long _cacheIndex_TrueOrFalse = 6957195124807221388L;

    private bool? TrueOrFalse_Compute(CqlContext context)
    {
        bool? a_ = this.TrueDef(context);
        // CQL 'or' (27:23-27:45): right operand skipped when left is true
        if (a_ is true)
        {
            return true;
        }
        else
        {
            bool? b_ = this.FalseDef(context);
            return a_ | b_;
        }
    }


    [CqlExpressionDefinition("TrueOrNull")]
    public bool? TrueOrNull(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_TrueOrNull, TrueOrNull_Compute);

    private const long _cacheIndex_TrueOrNull = 3201880937630684167L;

    private bool? TrueOrNull_Compute(CqlContext context)
    {
        bool? a_ = this.TrueDef(context);
        // CQL 'or' (28:22-28:43): right operand skipped when left is true
        if (a_ is true)
        {
            return true;
        }
        else
        {
            bool? b_ = this.NullDef(context);
            return a_ | b_;
        }
    }


    [CqlExpressionDefinition("FalseOrTrue")]
    public bool? FalseOrTrue(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_FalseOrTrue, FalseOrTrue_Compute);

    private const long _cacheIndex_FalseOrTrue = -5870215714388728059L;

    private bool? FalseOrTrue_Compute(CqlContext context)
    {
        bool? a_ = this.FalseDef(context);
        // CQL 'or' (29:23-29:45): right operand skipped when left is true
        if (a_ is true)
        {
            return true;
        }
        else
        {
            bool? b_ = this.TrueDef(context);
            return a_ | b_;
        }
    }


    [CqlExpressionDefinition("FalseOrFalse")]
    public bool? FalseOrFalse(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_FalseOrFalse, FalseOrFalse_Compute);

    private const long _cacheIndex_FalseOrFalse = -7787575255546426855L;

    private bool? FalseOrFalse_Compute(CqlContext context)
    {
        bool? a_ = this.FalseDef(context);
        // CQL 'or' (30:24-30:47): right operand skipped when left is true
        if (a_ is true)
        {
            return true;
        }
        else
        {
            return a_ | a_;
        }
    }


    [CqlExpressionDefinition("FalseOrNull")]
    public bool? FalseOrNull(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_FalseOrNull, FalseOrNull_Compute);

    private const long _cacheIndex_FalseOrNull = 7637181035466838469L;

    private bool? FalseOrNull_Compute(CqlContext context)
    {
        bool? a_ = this.FalseDef(context);
        // CQL 'or' (31:23-31:45): right operand skipped when left is true
        if (a_ is true)
        {
            return true;
        }
        else
        {
            bool? b_ = this.NullDef(context);
            return a_ | b_;
        }
    }


    [CqlExpressionDefinition("NullOrTrue")]
    public bool? NullOrTrue(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NullOrTrue, NullOrTrue_Compute);

    private const long _cacheIndex_NullOrTrue = 4805218554674191959L;

    private bool? NullOrTrue_Compute(CqlContext context)
    {
        bool? a_ = this.NullDef(context);
        // CQL 'or' (32:22-32:43): right operand skipped when left is true
        if (a_ is true)
        {
            return true;
        }
        else
        {
            bool? b_ = this.TrueDef(context);
            return a_ | b_;
        }
    }


    [CqlExpressionDefinition("NullOrFalse")]
    public bool? NullOrFalse(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NullOrFalse, NullOrFalse_Compute);

    private const long _cacheIndex_NullOrFalse = -8880999633536456444L;

    private bool? NullOrFalse_Compute(CqlContext context)
    {
        bool? a_ = this.NullDef(context);
        // CQL 'or' (33:23-33:45): right operand skipped when left is true
        if (a_ is true)
        {
            return true;
        }
        else
        {
            bool? b_ = this.FalseDef(context);
            return a_ | b_;
        }
    }


    [CqlExpressionDefinition("NullOrNull")]
    public bool? NullOrNull(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NullOrNull, NullOrNull_Compute);

    private const long _cacheIndex_NullOrNull = -4100945226465823568L;

    private bool? NullOrNull_Compute(CqlContext context)
    {
        bool? a_ = this.NullDef(context);
        // CQL 'or' (34:22-34:43): right operand skipped when left is true
        if (a_ is true)
        {
            return true;
        }
        else
        {
            return a_ | a_;
        }
    }


    [CqlExpressionDefinition("NotTrue")]
    public bool? NotTrue(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NotTrue, NotTrue_Compute);

    private const long _cacheIndex_NotTrue = 5543294130862381358L;

    private bool? NotTrue_Compute(CqlContext context)
    {
        bool? a_ = this.TrueDef(context);
        return !a_;
    }


    [CqlExpressionDefinition("NotFalse")]
    public bool? NotFalse(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NotFalse, NotFalse_Compute);

    private const long _cacheIndex_NotFalse = 7822158842362316476L;

    private bool? NotFalse_Compute(CqlContext context)
    {
        bool? a_ = this.FalseDef(context);
        return !a_;
    }


    [CqlExpressionDefinition("NotNull")]
    public bool? NotNull(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NotNull, NotNull_Compute);

    private const long _cacheIndex_NotNull = 1596748696812135233L;

    private bool? NotNull_Compute(CqlContext context)
    {
        bool? a_ = this.NullDef(context);
        return !a_;
    }


    [CqlExpressionDefinition("TrueImpliesTrue")]
    public bool? TrueImpliesTrue(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_TrueImpliesTrue, TrueImpliesTrue_Compute);

    private const long _cacheIndex_TrueImpliesTrue = 467546881030773344L;

    private bool? TrueImpliesTrue_Compute(CqlContext context)
    {
        bool? a_ = this.TrueDef(context);
        // CQL 'implies' (47:27-47:53): right operand skipped when left is false
        if (a_ is false)
        {
            return true;
        }
        else
        {
            return !a_ | a_;
        }
    }


    [CqlExpressionDefinition("TrueImpliesFalse")]
    public bool? TrueImpliesFalse(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_TrueImpliesFalse, TrueImpliesFalse_Compute);

    private const long _cacheIndex_TrueImpliesFalse = -1097953122463145083L;

    private bool? TrueImpliesFalse_Compute(CqlContext context)
    {
        bool? a_ = this.TrueDef(context);
        // CQL 'implies' (48:28-48:55): right operand skipped when left is false
        if (a_ is false)
        {
            return true;
        }
        else
        {
            bool? b_ = this.FalseDef(context);
            return !a_ | b_;
        }
    }


    [CqlExpressionDefinition("TrueImpliesNull")]
    public bool? TrueImpliesNull(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_TrueImpliesNull, TrueImpliesNull_Compute);

    private const long _cacheIndex_TrueImpliesNull = 3350382714373498219L;

    private bool? TrueImpliesNull_Compute(CqlContext context)
    {
        bool? a_ = this.TrueDef(context);
        // CQL 'implies' (49:27-49:53): right operand skipped when left is false
        if (a_ is false)
        {
            return true;
        }
        else
        {
            bool? b_ = this.NullDef(context);
            return !a_ | b_;
        }
    }


    [CqlExpressionDefinition("FalseImpliesTrue")]
    public bool? FalseImpliesTrue(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_FalseImpliesTrue, FalseImpliesTrue_Compute);

    private const long _cacheIndex_FalseImpliesTrue = -4974360173652851006L;

    private bool? FalseImpliesTrue_Compute(CqlContext context)
    {
        bool? a_ = this.FalseDef(context);
        // CQL 'implies' (50:28-50:55): right operand skipped when left is false
        if (a_ is false)
        {
            return true;
        }
        else
        {
            bool? b_ = this.TrueDef(context);
            return !a_ | b_;
        }
    }


    [CqlExpressionDefinition("FalseImpliesFalse")]
    public bool? FalseImpliesFalse(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_FalseImpliesFalse, FalseImpliesFalse_Compute);

    private const long _cacheIndex_FalseImpliesFalse = -930170386479517076L;

    private bool? FalseImpliesFalse_Compute(CqlContext context)
    {
        bool? a_ = this.FalseDef(context);
        // CQL 'implies' (51:29-51:57): right operand skipped when left is false
        if (a_ is false)
        {
            return true;
        }
        else
        {
            return !a_ | a_;
        }
    }


    [CqlExpressionDefinition("FalseImpliesNull")]
    public bool? FalseImpliesNull(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_FalseImpliesNull, FalseImpliesNull_Compute);

    private const long _cacheIndex_FalseImpliesNull = 4959945025528471588L;

    private bool? FalseImpliesNull_Compute(CqlContext context)
    {
        bool? a_ = this.FalseDef(context);
        // CQL 'implies' (52:28-52:55): right operand skipped when left is false
        if (a_ is false)
        {
            return true;
        }
        else
        {
            bool? b_ = this.NullDef(context);
            return !a_ | b_;
        }
    }


    [CqlExpressionDefinition("NullImpliesTrue")]
    public bool? NullImpliesTrue(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NullImpliesTrue, NullImpliesTrue_Compute);

    private const long _cacheIndex_NullImpliesTrue = 3520360141529197013L;

    private bool? NullImpliesTrue_Compute(CqlContext context)
    {
        bool? a_ = this.NullDef(context);
        // CQL 'implies' (53:27-53:53): right operand skipped when left is false
        if (a_ is false)
        {
            return true;
        }
        else
        {
            bool? b_ = this.TrueDef(context);
            return !a_ | b_;
        }
    }


    [CqlExpressionDefinition("NullImpliesFalse")]
    public bool? NullImpliesFalse(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NullImpliesFalse, NullImpliesFalse_Compute);

    private const long _cacheIndex_NullImpliesFalse = -607803731650961575L;

    private bool? NullImpliesFalse_Compute(CqlContext context)
    {
        bool? a_ = this.NullDef(context);
        // CQL 'implies' (54:28-54:55): right operand skipped when left is false
        if (a_ is false)
        {
            return true;
        }
        else
        {
            bool? b_ = this.FalseDef(context);
            return !a_ | b_;
        }
    }


    [CqlExpressionDefinition("NullImpliesNull")]
    public bool? NullImpliesNull(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NullImpliesNull, NullImpliesNull_Compute);

    private const long _cacheIndex_NullImpliesNull = -5479413561624497055L;

    private bool? NullImpliesNull_Compute(CqlContext context)
    {
        bool? a_ = this.NullDef(context);
        // CQL 'implies' (55:27-55:53): right operand skipped when left is false
        if (a_ is false)
        {
            return true;
        }
        else
        {
            return !a_ | a_;
        }
    }


    [CqlExpressionDefinition("MessageTrue")]
    public bool? MessageTrue(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_MessageTrue, MessageTrue_Compute);

    private const long _cacheIndex_MessageTrue = 4760942440377966208L;

    private bool? MessageTrue_Compute(CqlContext context)
    {
        bool? a_ = context.Operators.Message<bool?>(true, "ShortCircuitLogicTest.RightEvaluated", "Trace", "right operand was evaluated");
        return a_;
    }


    [CqlExpressionDefinition("FalseAndMessage")]
    public bool? FalseAndMessage(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_FalseAndMessage, FalseAndMessage_Compute);

    private const long _cacheIndex_FalseAndMessage = 2056573296090536428L;

    private bool? FalseAndMessage_Compute(CqlContext context)
    {
        bool? a_ = this.FalseDef(context);
        // CQL 'and' (63:27-63:54): right operand skipped when left is false
        if (a_ is false)
        {
            return false;
        }
        else
        {
            bool? b_ = this.MessageTrue(context);
            return a_ & b_;
        }
    }


    [CqlExpressionDefinition("NullAndMessage")]
    public bool? NullAndMessage(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NullAndMessage, NullAndMessage_Compute);

    private const long _cacheIndex_NullAndMessage = -2763777828018205598L;

    private bool? NullAndMessage_Compute(CqlContext context)
    {
        bool? a_ = this.NullDef(context);
        // CQL 'and' (64:26-64:52): right operand skipped when left is false
        if (a_ is false)
        {
            return false;
        }
        else
        {
            bool? b_ = this.MessageTrue(context);
            return a_ & b_;
        }
    }


    [CqlExpressionDefinition("TrueOrMessage")]
    public bool? TrueOrMessage(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_TrueOrMessage, TrueOrMessage_Compute);

    private const long _cacheIndex_TrueOrMessage = -8510222848461882741L;

    private bool? TrueOrMessage_Compute(CqlContext context)
    {
        bool? a_ = this.TrueDef(context);
        // CQL 'or' (65:25-65:50): right operand skipped when left is true
        if (a_ is true)
        {
            return true;
        }
        else
        {
            bool? b_ = this.MessageTrue(context);
            return a_ | b_;
        }
    }


    [CqlExpressionDefinition("NullOrMessage")]
    public bool? NullOrMessage(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NullOrMessage, NullOrMessage_Compute);

    private const long _cacheIndex_NullOrMessage = -7344475394165238436L;

    private bool? NullOrMessage_Compute(CqlContext context)
    {
        bool? a_ = this.NullDef(context);
        // CQL 'or' (66:25-66:50): right operand skipped when left is true
        if (a_ is true)
        {
            return true;
        }
        else
        {
            bool? b_ = this.MessageTrue(context);
            return a_ | b_;
        }
    }


    [CqlExpressionDefinition("FalseImpliesMessage")]
    public bool? FalseImpliesMessage(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_FalseImpliesMessage, FalseImpliesMessage_Compute);

    private const long _cacheIndex_FalseImpliesMessage = 6341856730686540862L;

    private bool? FalseImpliesMessage_Compute(CqlContext context)
    {
        bool? a_ = this.FalseDef(context);
        // CQL 'implies' (72:31-72:62): right operand skipped when left is false
        if (a_ is false)
        {
            return true;
        }
        else
        {
            bool? b_ = this.MessageTrue(context);
            return !a_ | b_;
        }
    }


    [CqlExpressionDefinition("TrueImpliesMessage")]
    public bool? TrueImpliesMessage(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_TrueImpliesMessage, TrueImpliesMessage_Compute);

    private const long _cacheIndex_TrueImpliesMessage = 2912160462594916813L;

    private bool? TrueImpliesMessage_Compute(CqlContext context)
    {
        bool? a_ = this.TrueDef(context);
        // CQL 'implies' (73:30-73:60): right operand skipped when left is false
        if (a_ is false)
        {
            return true;
        }
        else
        {
            bool? b_ = this.MessageTrue(context);
            return !a_ | b_;
        }
    }


    [CqlExpressionDefinition("NullImpliesMessage")]
    public bool? NullImpliesMessage(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NullImpliesMessage, NullImpliesMessage_Compute);

    private const long _cacheIndex_NullImpliesMessage = 1207869899109621914L;

    private bool? NullImpliesMessage_Compute(CqlContext context)
    {
        bool? a_ = this.NullDef(context);
        // CQL 'implies' (74:30-74:60): right operand skipped when left is false
        if (a_ is false)
        {
            return true;
        }
        else
        {
            bool? b_ = this.MessageTrue(context);
            return !a_ | b_;
        }
    }


    [CqlFunctionDefinition("GuardedAnd")]
    public bool? GuardedAnd(CqlContext context, bool? leftOperand)
    {
        // CQL 'and' (80:52-80:80): right operand skipped when left is false
        if (leftOperand is false)
        {
            return false;
        }
        else
        {
            bool? a_ = this.MessageTrue(context);
            return leftOperand & a_;
        }
    }


    [CqlExpressionDefinition("GuardInConditionalTest")]
    public int? GuardInConditionalTest(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_GuardInConditionalTest, GuardInConditionalTest_Compute);

    private const long _cacheIndex_GuardInConditionalTest = -1700372608085352039L;

    private int? GuardInConditionalTest_Compute(CqlContext context)
    {
        bool? a_ = this.TrueDef(context);
        bool? b_;
        // CQL 'and' (87:37-87:63): right operand skipped when left is false
        if (a_ is false)
        {
            b_ = false;
        }
        else
        {
            bool? c_ = this.MessageTrue(context);
            b_ = a_ & c_;
        }
        if (b_ ?? false)
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }


    [CqlExpressionDefinition("OrTrueCollapses")]
    public bool? OrTrueCollapses(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_OrTrueCollapses, OrTrueCollapses_Compute);

    private const long _cacheIndex_OrTrueCollapses = -45510771611941422L;

    private bool? OrTrueCollapses_Compute(CqlContext context) =>
    true;


    [CqlExpressionDefinition("AndFalseCollapses")]
    public bool? AndFalseCollapses(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_AndFalseCollapses, AndFalseCollapses_Compute);

    private const long _cacheIndex_AndFalseCollapses = 6354837902464382135L;

    private bool? AndFalseCollapses_Compute(CqlContext context) =>
    false;


    [CqlExpressionDefinition("NestedOrTrueCollapses")]
    public bool? NestedOrTrueCollapses(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NestedOrTrueCollapses, NestedOrTrueCollapses_Compute);

    private const long _cacheIndex_NestedOrTrueCollapses = 4518757540788178114L;

    private bool? NestedOrTrueCollapses_Compute(CqlContext context) =>
    true;


    [CqlFunctionDefinition("MergeAnd")]
    public bool? MergeAnd(CqlContext context, bool? x, bool? y) =>
    x & y;


    [CqlFunctionDefinition("MergeOr")]
    public bool? MergeOr(CqlContext context, bool? x, bool? y) =>
    x | y;


    [CqlFunctionDefinition("AndNotY")]
    public bool? AndNotY(CqlContext context, bool? x, bool? y) =>
    /* CQL 'and' (105:50-105:62) */ (x is false
        ? false
        : x & !y);


    [CqlExpressionDefinition("FalseConstAndMessage")]
    public bool? FalseConstAndMessage(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_FalseConstAndMessage, FalseConstAndMessage_Compute);

    private const long _cacheIndex_FalseConstAndMessage = 2613768124339659917L;

    private bool? FalseConstAndMessage_Compute(CqlContext context) =>
    false;


    [CqlExpressionDefinition("TrueConstOrMessage")]
    public bool? TrueConstOrMessage(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_TrueConstOrMessage, TrueConstOrMessage_Compute);

    private const long _cacheIndex_TrueConstOrMessage = 3019385558053115511L;

    private bool? TrueConstOrMessage_Compute(CqlContext context) =>
    true;


    [CqlExpressionDefinition("AndTrueKeepsLeft")]
    public bool? AndTrueKeepsLeft(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_AndTrueKeepsLeft, AndTrueKeepsLeft_Compute);

    private const long _cacheIndex_AndTrueKeepsLeft = 9093478079636794288L;

    private bool? AndTrueKeepsLeft_Compute(CqlContext context)
    {
        bool? a_ = this.MessageTrue(context);
        return a_;
    }


    [CqlExpressionDefinition("OrFalseKeepsLeft")]
    public bool? OrFalseKeepsLeft(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_OrFalseKeepsLeft, OrFalseKeepsLeft_Compute);

    private const long _cacheIndex_OrFalseKeepsLeft = 7554220517132620559L;

    private bool? OrFalseKeepsLeft_Compute(CqlContext context)
    {
        bool? a_ = this.MessageTrue(context);
        return a_;
    }


    [CqlExpressionDefinition("NullConstAndMessage")]
    public bool? NullConstAndMessage(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NullConstAndMessage, NullConstAndMessage_Compute);

    private const long _cacheIndex_NullConstAndMessage = -9212526098572984584L;

    private bool? NullConstAndMessage_Compute(CqlContext context)
    {
        bool? a_ = this.MessageTrue(context);
        return (null as bool?) & a_;
    }


    [CqlExpressionDefinition("NotNullConst")]
    public bool? NotNullConst(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NotNullConst, NotNullConst_Compute);

    private const long _cacheIndex_NotNullConst = -6326138193603489337L;

    private bool? NotNullConst_Compute(CqlContext context) =>
    default;


    [CqlExpressionDefinition("WithoutClause")]
    public bool? WithoutClause(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_WithoutClause, WithoutClause_Compute);

    private const long _cacheIndex_WithoutClause = -1923006382463484928L;

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
                bool? g_ = context.Operators.Equal(A, B);
                return g_;
            }

            bool? f_ = context.Operators.WhereAny<int?>((IEnumerable<int?>)d_, e_);
            return !f_;
        }

        bool? c_ = context.Operators.WhereAny<int?>((IEnumerable<int?>)a_, b_);
        return c_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private ShortCircuitLogicTest_1_0_0() {}

    public static ShortCircuitLogicTest_1_0_0 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "ShortCircuitLogicTest";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [];

    #endregion ILibrary Implementation

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Model;
internal class ChoiceTypeDefinition : TypeDefinition
{
    private static string FormatName(TypeDefinition[] choices) =>
        $"Choice<{string.Join(" ,", choices.Select(choice => choice.Name))}>";
    public ChoiceTypeDefinition(params TypeDefinition[] choices)
        : base(FormatName(choices), null, AccessModifier.Public)
    {
        Choices = choices;
    }

    public TypeDefinition[] Choices { get; }

    public override TypeSpecifier ToTypeSpecifier() =>
        new ChoiceTypeSpecifier(Choices.Select(choice => choice.ToTypeSpecifier()).ToArray());
}

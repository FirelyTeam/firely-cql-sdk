using System.Xml.Serialization;

namespace Hl7.Cql.Elm;

#pragma warning disable CS1591
public partial class Narrative
{
    [XmlAttribute]
    // ReSharper disable once InconsistentNaming
    public string? r { get; set; }

    // ReSharper disable once InconsistentNaming
    [XmlElement]
    public Narrative[]? s { get; set; }
}
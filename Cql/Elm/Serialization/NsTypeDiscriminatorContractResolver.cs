using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Hl7.Cql.Elm.Serialization;


internal class NsTypeDiscriminatorContractResolver : DefaultContractResolver {

    protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
    {
        var baseList = base.CreateProperties(type, memberSerialization);

        Debug.WriteLine(type.Name);

        var xmlattrs = type.GetCustomAttributes<XmlIncludeAttribute>(false);

        if (xmlattrs.Any())
        {
            var feeClassProperty = CreateTypeDiscriminatorProperty(type);
            baseList.Add(feeClassProperty);
        }

        return baseList;
    }

    private JsonProperty CreateTypeDiscriminatorProperty(Type t) {
        return new JsonProperty {
            PropertyName = "type",
            PropertyType = typeof(string),
            DeclaringType = t,
            ValueProvider = new DiscriminatorValueProvider(),
            AttributeProvider = null,
            Readable = true,
            Writable = true,
            ShouldSerialize = _ => true
        };
    }

    private class DiscriminatorValueProvider : IValueProvider {
        public object GetValue(object target) => target.GetType().Name;
        public void SetValue(object target, object? value)
        {
            throw new NotSupportedException("Setting the discriminator value is not supported.");
        }
    }

}
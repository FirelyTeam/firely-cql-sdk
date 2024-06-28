using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Hl7.Cql.Elm.Serialization;


internal class NsTypeDiscriminatorContractResolver : DefaultContractResolver {

    protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
    {
        var baseList = base.CreateProperties(type, memberSerialization);

        Debug.WriteLine(type.Name);

        //if (NsSubclassConverter.IsPartOfAnnotatedSubclassHierarchy(type))
        if (type.IsAssignableTo(typeof(Elm.Element)))
        {
            if (baseList.SingleOrDefault(p => p.PropertyName == "type") is { } existing)
                baseList.Remove(existing);

            var typeDiscriminatorProperty = CreateTypeDiscriminatorProperty(type);
            baseList.Add(typeDiscriminatorProperty);
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
            Writable = false,
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
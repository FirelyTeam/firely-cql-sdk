using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Model;
internal class ModelWriter
{
    public void Write(ModelDefinition model, StreamWriter writer)
    {
        writer.Write("model ");
        writer.Write(model.Name);
        writer.Write(" version '");
        writer.Write(model.Version);
        writer.Write("': '");
        writer.Write(model.Uri);
        writer.WriteLine("'");
        writer.WriteLine();

        foreach(var kvp in model.TypeDefinitions.OrderBy(kvp=>kvp.Key))
        {
            var type = kvp.Value;
            writer.Write("define ");
            switch (type) {
                case SimpleTypeDefinition std:
                    {
                        writer.Write("simple type ");
                        writer.WriteLine(type.Name);
                        break;
                    }
                case GenericTypeDefinition gtd:
                    {
                        writer.Write("generic type ");
                        writer.Write(gtd.Name);
                        writer.Write("<");
                        writer.Write(gtd.Constraints.First().Key);
                        foreach(var arg in gtd.Constraints.Skip(1))
                        {
                            writer.Write(", ");
                            writer.Write(arg.Key);
                        }
                        writer.WriteLine(">");
                        writer.Write("\twhere ");
                        var f = gtd.Constraints.First();
                        writer.Write(f.Key);
                        writer.Write(": ");
                        writer.Write(f.Value);
                        foreach (var arg in gtd.Constraints.Skip(1))
                        {
                            writer.WriteLine(",");
                            writer.Write("\t");
                            writer.Write(arg.Key);
                            writer.Write(": ");
                            writer.Write(arg.Value);
                        }
                        writer.WriteLine();
                        if (gtd.Elements.Any())
                        {
                            writer.WriteLine("{");
                            writeElements(gtd);
                            writer.WriteLine();
                            writer.WriteLine("}");
                        }
                        else
                            writer.WriteLine();
                        break;
                    }
                case ClassTypeDefinition ctd:
                    {
                        writer.Write("type ");
                        writer.Write(type.Name);
                        if (ctd.Elements.Any())
                        {
                            writer.WriteLine(" {");
                            writeElements(ctd);
                            writer.WriteLine();
                            writer.WriteLine("}");
                        }
                        else
                            writer.WriteLine();
                        break;
                    }
                default: throw new InvalidOperationException($"Don't know how to write {type.GetType().Name}");
            }


            
            writer.WriteLine();
            void writeElement(ClassTypeElementDefinition cted)
            {
                writer.Write("\t");
                writer.Write(cted.Name);
                writer.Write(" ");
                if (string.IsNullOrWhiteSpace(cted.TargetCql))
                {
                    writer.Write(cted.Type);
                }
            }

            void writeElements(ClassTypeDefinition ctd)
            {
                var f = ctd.Elements.FirstOrDefault();
                if (f is not null)
                {
                    writeElement(f);
                    foreach (var element in ctd.Elements.Skip(1))
                    {
                        writer.WriteLine(",");
                        writeElement(element);
                    }
                }
            }
        }
    }

}

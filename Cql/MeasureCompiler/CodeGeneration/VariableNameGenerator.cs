using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ncqa.Cql.MeasureCompiler.CodeGeneration
{
    public class VariableNameGenerator
    {
        private object SyncRoot = new object();
        public string Postfix { get; }

        private List<string> Reserved { get; }

        public VariableNameGenerator(IEnumerable<string>? reserved = null, string postfix = "")
        {
            Reserved = reserved?.ToList() ?? new List<string>();
            Postfix = postfix;
        }

        private List<char> Letters = new List<char>() { (char)('a' - 1) };
        private string Prefix = string.Empty;
        private List<string> Generated = new List<string>();


        public virtual string Next()
        {
            lock (SyncRoot)
            {
                string vn = "";
                do
                {
                    var lastIndex = Letters.Count - 1;
                    var next = (char)(Letters[lastIndex] + 1);
                    if (next > 'z')
                    {
                        next = 'a';
                        Letters[lastIndex] = next;
                        if (Letters.Count > 1)
                        {
                            if (Letters[0] == 'z')
                            {
                                Letters.Insert(0, 'a');
                            }
                            else
                            {
                                Letters[0] = (char)(Letters[0] + 1);
                            }
                        }
                        else Letters.Insert(0, 'a');
                    }
                    else
                    {
                        Letters[lastIndex] = next;
                    }
                    vn = $"{Prefix}{new string(Letters.ToArray())}{Postfix}";
                }
                while (Reserved.Contains(vn) && SyntaxFacts.GetKeywordKind(vn) != SyntaxKind.None);
                Generated.Add(vn);
                return vn;
            }
        }

    }
}

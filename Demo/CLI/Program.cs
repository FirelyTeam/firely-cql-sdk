using Hl7.Cql.Firely;
using Hl7.Fhir.Model;
using Microsoft.Extensions.Configuration;

namespace CLI
{
    internal class Program
    {
        public static int Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                            .AddCommandLine(args)
                            .Build();
            if (config["?"] is not null || config["help"] is not null)
                return ShowHelp();

            var lArg = config["l"] ?? config["lib"] ?? config["library"];
            if (string.IsNullOrEmpty(lArg))
            {
                Console.Error.WriteLine("Missing required parameter: --l");
                return ShowHelp();
            }

            var dArg = config["d"] ?? config["data"];
            if (string.IsNullOrEmpty(lArg))
            {
                Console.Error.WriteLine("Missing required parameter: --d");
                return ShowHelp();
            }
            var dataFile = new FileInfo(dArg);
            using var dataStream = dataFile.OpenRead();
            var bundle = dataStream.ParseFhir<Bundle>();

            var oArg = config["o"] ?? config["out"];
            TextWriter? output = null;
            bool disposeOutput = false;
            if (!string.IsNullOrEmpty(oArg))
            {
                var outFile = new FileInfo(oArg);
                var fs = new FileStream(outFile.FullName, FileMode.Create, FileAccess.Write, FileShare.Read);
                output = new StreamWriter(fs);
            }
            else
            {
                output = Console.Out;
                disposeOutput = true;
            }

            LibraryRunner.Run(lArg, bundle, output);

            if (disposeOutput && output != null)
            {
                output.Dispose();
            }

            return 0;
        }

        private static int ShowHelp()
        {
            Console.WriteLine();
            Console.WriteLine("Measures CLI example");
            Console.WriteLine();
            Console.WriteLine($"\t--d\t\tData bundle");
            Console.WriteLine($"\t--l\t\tLibrary name");
            Console.WriteLine($"\t[--o]\t\tOutput file name; if not specified, use console");
            Console.WriteLine();
            return -1;
        }
    }
}
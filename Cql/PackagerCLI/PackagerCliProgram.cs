/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler;
using Hl7.Cql.Packaging;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.Packager;

internal class PackagerCliProgram(
    ILogger<PackagerCliProgram> logger,
    IOptions<CqlToResourcePackagingOptions> options,
    OptionsConsoleDumper optionsConsoleDumper,
    CqlToResourcePackagingPipeline cqlToResourcePackagingPipeline)
{
    public int Run()
    {
        try
        {
            optionsConsoleDumper.DumpToConsole();

            LibrarySet librarySet = new LibrarySet("Example Library");
            DirectoryInfo elmDirectory = options.Value.ElmDirectory;
            Func<FileInfo, bool>? includeFilesForCms = null;
            if (elmDirectory.FullName.Contains("\\cms\\", StringComparison.InvariantCultureIgnoreCase))
                includeFilesForCms = IncludeFilesForCms();
            librarySet.LoadLibrariesFromDirectory(elmDirectory, includeFile: includeFilesForCms);

            cqlToResourcePackagingPipeline.ProcessLibrarySet(librarySet);
            return 0;
        }
        catch (Exception e)
        {
            logger.LogError(e, "An error occurred while running the packager");
            Console.Error.WriteLine("An error occurred while running PackagerCLI. Consult the build.log file for more detail.");
            return -1;
        }
    }

    private Func<FileInfo, bool> IncludeFilesForCms()
    {
        HashSet<string> hardcodedSkipCmsFiles =
        [

            // These contain a union between incompatible tuples,
            // see https://chat.fhir.org/#narrow/stream/179220-cql/topic/Union.20of.20tuples.20with.20convertible.20types
            "AntithromboticTherapyByEndofHospitalDay2FHIR.json",
            "IntensiveCareUnitVenousThromboembolismProphylaxisFHIR.json",
            "VenousThromboembolismProphylaxisFHIR.json",

            // These uses choice types, move into a property on such a choice, and then calls an
            // overloaded function, so we cannot find out which overload to call.
            // A solution is to either a) Introduce choice types in our system instead of object,
            // b) introduce runtime resolution, based on the runtime types of the arguments when one of
            // the arguments is a choice (=object).
            "InitiationandEngagementofSubstanceUseDisorderTreatmentFHIR.json",
            "PCSBMIScreenAndFollowUpFHIR.json",
        ];

        return file => !hardcodedSkipCmsFiles.Contains(file.Name);
    }

}
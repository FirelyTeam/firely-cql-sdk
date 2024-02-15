using System.Diagnostics;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.Packaging;

partial class PackagerOptions
{
    internal class Validator : IValidateOptions<PackagerOptions>
    {
        public ValidateOptionsResult Validate(string? name, PackagerOptions options)
        {
            ValidateOptionsResultBuilder? builder = null;
            SemaphoreSlim slimLock = new(initialCount: 1, maxCount: 1);

            var elm = (ArgNameElmDirectory, options.ElmDirectory);
            var cql = (ArgNameCqlDirectory, options.CqlDirectory);
            var cs = (ArgNameCSharpDirectory, options.CSharpDirectory);
            var fhir = (ArgNameFhirDirectory, options.FhirDirectory);

            _ = ValidateRequired(elm) && ValidateDirectoryExists(elm);

            _ = ValidateRequired(cql) && ValidateDirectoryExists(cql);

            Task.WhenAll(
                    CreateDirectoryIfNotExistsAsync(cs),
                    CreateDirectoryIfNotExistsAsync(fhir))
                .GetAwaiter().GetResult();


            var result = builder?.Build() ?? ValidateOptionsResult.Success;
            return result;

            bool ValidateRequired<T>( (string name, T? value) arg)
            {
                if (arg.value is null)
                {
                    AddError($"{arg.name}: must be specified.");
                    return false;
                }

                return true;
            }

            bool ValidateDirectoryExists( (string name, DirectoryInfo? value) arg)
            {
                if (arg.value is { Exists: false } dir)
                {
                    AddError($"{arg.name}: directory '{dir}' does not exist.");
                    return false;
                }

                return true;
            }

            async Task<bool> CreateDirectoryIfNotExistsAsync((string name, DirectoryInfo? value) arg)
            {
                if (arg.value is { Exists: false } dir)
                {
                    Stopwatch sw = Stopwatch.StartNew();
                    try
                    {
                        while (sw.ElapsedMilliseconds < 5000)
                        {
                            dir.Create();
                            dir.Refresh();
                            if (dir.Exists)
                                return true;

                            await Task.Delay(250);
                        }
                    }
                    catch (Exception e)
                    {
                        AddError($"{arg.name}: directory '{dir}' could not be created: {e.Message}");
                        return false;
                    }

                    AddError($"{arg.name}: directory '{dir}' could not be created.");
                    return false;
                }

                return true;
            }

            void AddError(string message)
            {
                if (!slimLock.Wait(Timeout.Infinite))
                    throw new InvalidOperationException("Failed to acquire lock.");

                try
                {
                    (builder ??= new()).AddError(message);
                }
                finally
                {
                    slimLock.Release();
                }
            }
        }
    }
}
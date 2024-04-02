using Microsoft.Extensions.Options;

namespace Hl7.Cql.Packaging;

partial class CqlToResourcePackagingOptions
{
    internal class Validator : IValidateOptions<CqlToResourcePackagingOptions>
    {
        public ValidateOptionsResult Validate(string? name, CqlToResourcePackagingOptions options)
        {
            ValidateOptionsResultBuilder? builder = null;

            var elm = (ArgNameElmDirectory, options.ElmDirectory);
            var cql = (ArgNameCqlDirectory, options.CqlDirectory);

            _ = ValidateRequired(elm) && ValidateDirectoryExists(elm);

            _ = ValidateRequired(cql) && ValidateDirectoryExists(cql);

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

            void AddError(string message) => 
                (builder ??= new()).AddError(message);
        }
    }
}
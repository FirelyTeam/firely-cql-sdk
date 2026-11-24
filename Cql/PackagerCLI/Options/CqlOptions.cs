/*
 * Copyright(c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.Model;

namespace Hl7.Cql.Packager.Options;

public record CqlOptions : CqlToolkitConfig, IBindOptions
{
    public const string ConfigSection = "Cql";
    static string IBindOptions.ConfigSection => ConfigSection;

    /// <remarks>Called by convention from <see cref="OptionsBinder"/></remarks>>
    [UsedImplicitly]
    public static bool TryBindModels(IConfiguration config, out ImmutableHashSet<CqlModel>? value)
    {
        value = config.Get<CqlModel[]>()?.ToImmutableHashSet();
        return value is not null;
    }

    /// <summary>
    /// Reads the model info XML files named by the <c>ModelInfos</c> setting, a list of file paths relative to the
    /// current directory, into <see cref="CqlToolkitConfig.ModelInfos"/>.
    /// </summary>
    /// <remarks>Called by convention from <see cref="OptionsBinder"/></remarks>
    /// <exception cref="InvalidOperationException">A file cannot be read or does not hold a model info.</exception>
    [UsedImplicitly]
    public static bool TryBindModelInfos(IConfiguration config, out ImmutableHashSet<ModelInfo>? value)
    {
        value = config.Get<string[]>()?.Select(LoadModelInfo).ToImmutableHashSet();
        return value is not null;
    }

    private static ModelInfo LoadModelInfo(string path)
    {
        var fullPath = Path.GetFullPath(path);
        try
        {
            return ModelInfo.LoadFromFile(fullPath);
        }
        catch (Exception e) when (e is IOException or UnauthorizedAccessException or InvalidOperationException or ArgumentException)
        {
            throw new InvalidOperationException($"Cannot read the model info file '{fullPath}' named in {ConfigSection}:{nameof(ModelInfos)}: {e.Message}", e);
        }
    }
}
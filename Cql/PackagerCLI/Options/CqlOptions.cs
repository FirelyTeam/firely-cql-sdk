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
    /// Paths of model info XML files, relative to the current directory, whose models are translated against in
    /// addition to <see cref="CqlToolkitConfig.Models"/>. The files are read only by the commands that translate CQL,
    /// through <see cref="WithModelInfoFiles"/>.
    /// </summary>
    public string?[]? ModelInfoFiles { get; init; }

    /// <summary>
    /// Returns this configuration with the models read from <see cref="ModelInfoFiles"/> added to
    /// <see cref="CqlToolkitConfig.ModelInfos"/>.
    /// </summary>
    /// <exception cref="InvalidOperationException">A path is empty, or its file cannot be read or does not hold a usable model info.</exception>
    public CqlToolkitConfig WithModelInfoFiles() =>
        ModelInfoFiles is null or []
            ? this
            : this with { ModelInfos = ModelInfos.Union(ModelInfoFiles.Select(LoadModelInfo)) };

    private static ModelInfo LoadModelInfo(string? path)
    {
        if (string.IsNullOrWhiteSpace(path))
            throw new InvalidOperationException($"{ConfigSection}:{nameof(ModelInfoFiles)} contains an empty file path.");

        try
        {
            return ModelInfo.LoadFromFile(Path.GetFullPath(path));
        }
        catch (Exception e) when (e is IOException or UnauthorizedAccessException or InvalidOperationException or ArgumentException or NotSupportedException)
        {
            throw new InvalidOperationException($"Cannot read the model info file '{path}' named in {ConfigSection}:{nameof(ModelInfoFiles)}: {e.Message}", e);
        }
    }
}
/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.CommandLine;
using System.Diagnostics;
using System.Text;
using System.Text.Json;

namespace ReleaseReportGenerator;

internal class Program
{
    private static async Task<int> Main(string[] args)
    {
        var rootCommand = new RootCommand("Generate a visual release report for Firely CQL SDK");
        
        var repositoryPathOption = new Option<DirectoryInfo>(
            "--repository-path",
            () => new DirectoryInfo(Directory.GetCurrentDirectory()),
            "Path to the git repository");
        
        var outputPathOption = new Option<FileInfo>(
            "--output",
            () => new FileInfo("release-report.html"),
            "Output file path for the HTML report");
        
        var tagOption = new Option<string>(
            "--tag",
            () => "v2.1.0-rc.1",
            "Git tag to generate report for");

        rootCommand.AddOption(repositoryPathOption);
        rootCommand.AddOption(outputPathOption);
        rootCommand.AddOption(tagOption);

        rootCommand.SetHandler(async (repository, output, tag) =>
        {
            var generator = new ReleaseReportGenerator(repository.FullName);
            await generator.GenerateReportAsync(tag, output.FullName);
        }, repositoryPathOption, outputPathOption, tagOption);

        return await rootCommand.InvokeAsync(args);
    }
}

public class ReleaseReportGenerator
{
    private readonly string _repositoryPath;

    public ReleaseReportGenerator(string repositoryPath)
    {
        _repositoryPath = repositoryPath;
    }

    public async Task GenerateReportAsync(string tag, string outputPath)
    {
        Console.WriteLine($"Generating release report for tag '{tag}' in repository '{_repositoryPath}'");
        Console.WriteLine($"Output will be saved to: {outputPath}");

        try 
        {
            var metrics = await GatherMetricsAsync(tag);
            var html = GenerateHtmlReport(metrics, tag);
            await File.WriteAllTextAsync(outputPath, html);
            
            Console.WriteLine($"✅ Release report generated successfully: {outputPath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Error generating release report: {ex.Message}");
            throw;
        }
    }

    private async Task<ReleaseMetrics> GatherMetricsAsync(string tag)
    {
        Console.WriteLine("📊 Gathering repository metrics...");
        
        var metrics = new ReleaseMetrics();
        
        // Get tag commit info
        var tagCommit = await RunGitCommandAsync($"show {tag} --no-patch --pretty=format:\"%H|%an|%ae|%ad|%s\" --date=iso");
        if (!string.IsNullOrEmpty(tagCommit))
        {
            var parts = tagCommit.Split('|');
            if (parts.Length >= 5)
            {
                metrics.TagCommit = new CommitInfo
                {
                    Hash = parts[0],
                    Author = parts[1],
                    Email = parts[2],
                    Date = DateTime.Parse(parts[3]),
                    Message = parts[4]
                };
            }
        }

        // Get all commits up to the tag
        var commitOutput = await RunGitCommandAsync($"log {tag} --pretty=format:\"%H|%an|%ae|%ad|%s\" --date=iso");
        var commitLines = commitOutput.Split('\n', StringSplitOptions.RemoveEmptyEntries);
        
        foreach (var line in commitLines)
        {
            var parts = line.Split('|');
            if (parts.Length >= 5)
            {
                var commit = new CommitInfo
                {
                    Hash = parts[0],
                    Author = parts[1],
                    Email = parts[2],
                    Date = DateTime.Parse(parts[3]),
                    Message = parts[4]
                };
                metrics.Commits.Add(commit);
            }
        }

        // Find milestone commits
        await FindMilestoneCommitsAsync(metrics);

        // Get lines of code
        await CalculateLinesOfCodeAsync(metrics, tag);

        // Get contributors
        metrics.CalculateContributorStats();

        // Get PR information from commit messages
        ExtractPullRequestInfo(metrics);

        Console.WriteLine($"✅ Found {metrics.Commits.Count} commits, {metrics.Contributors.Count} contributors");
        
        return metrics;
    }

    private async Task FindMilestoneCommitsAsync(ReleaseMetrics metrics)
    {
        // Find first commit in repo
        var firstCommitOutput = await RunGitCommandAsync("log --reverse --pretty=format:\"%H|%an|%ae|%ad|%s\" --date=iso");
        var firstCommitLine = firstCommitOutput.Split('\n', StringSplitOptions.RemoveEmptyEntries).FirstOrDefault();
        if (!string.IsNullOrEmpty(firstCommitLine))
        {
            var parts = firstCommitLine.Split('|');
            if (parts.Length >= 5)
            {
                metrics.FirstCommit = new CommitInfo
                {
                    Hash = parts[0],
                    Author = parts[1],
                    Email = parts[2],
                    Date = DateTime.Parse(parts[3]),
                    Message = parts[4]
                };
            }
        }

        // Find first commit by Paul den Boer (baseTwo)
        var paulCommitOutput = await RunGitCommandAsync("log --author=\"Paul den Boer\" --reverse --pretty=format:\"%H|%an|%ae|%ad|%s\" --date=iso");
        var paulCommitLine = paulCommitOutput.Split('\n', StringSplitOptions.RemoveEmptyEntries).FirstOrDefault();
        if (!string.IsNullOrEmpty(paulCommitLine))
        {
            var parts = paulCommitLine.Split('|');
            if (parts.Length >= 5)
            {
                metrics.PaulFirstCommit = new CommitInfo
                {
                    Hash = parts[0],
                    Author = parts[1],
                    Email = parts[2],
                    Date = DateTime.Parse(parts[3]),
                    Message = parts[4]
                };
            }
        }

        // Look for develop branch split - search for relevant branch-related commits
        var branchCommitOutput = await RunGitCommandAsync("log --grep=\"develop\" --grep=\"branch\" --grep=\"split\" --pretty=format:\"%H|%an|%ae|%ad|%s\" --date=iso");
        var branchCommitLine = branchCommitOutput.Split('\n', StringSplitOptions.RemoveEmptyEntries).FirstOrDefault();
        if (!string.IsNullOrEmpty(branchCommitLine))
        {
            var parts = branchCommitLine.Split('|');
            if (parts.Length >= 5)
            {
                metrics.DevelopSplitCommit = new CommitInfo
                {
                    Hash = parts[0],
                    Author = parts[1],
                    Email = parts[2],
                    Date = DateTime.Parse(parts[3]),
                    Message = parts[4]
                };
            }
        }
    }

    private async Task CalculateLinesOfCodeAsync(ReleaseMetrics metrics, string tag)
    {
        Console.WriteLine("📝 Calculating lines of code...");
        
        // Get all non-generated C# files at the tag
        var filesOutput = await RunGitCommandAsync($"ls-tree -r --name-only {tag}");
        var files = filesOutput.Split('\n', StringSplitOptions.RemoveEmptyEntries)
            .Where(f => f.EndsWith(".cs") && !f.EndsWith(".g.cs"))
            .ToList();

        metrics.TotalFiles = files.Count;
        
        foreach (var file in files)
        {
            try
            {
                var contentOutput = await RunGitCommandAsync($"show {tag}:{file}");
                var lines = contentOutput.Split('\n');
                metrics.TotalLines += lines.Length;
                metrics.CodeLines += lines.Count(line => !string.IsNullOrWhiteSpace(line) && !line.Trim().StartsWith("//"));
            }
            catch
            {
                // Skip files that can't be read
            }
        }

        Console.WriteLine($"✅ Analyzed {metrics.TotalFiles} files, {metrics.TotalLines} total lines, {metrics.CodeLines} code lines");
    }

    private static void ExtractPullRequestInfo(ReleaseMetrics metrics)
    {
        var prPattern = new System.Text.RegularExpressions.Regex(@"#(\d+)");
        var mergePattern = new System.Text.RegularExpressions.Regex(@"Merge pull request #(\d+)");
        
        foreach (var commit in metrics.Commits)
        {
            var mergeMatch = mergePattern.Match(commit.Message);
            if (mergeMatch.Success)
            {
                if (int.TryParse(mergeMatch.Groups[1].Value, out var prNumber))
                {
                    metrics.PullRequests.Add(prNumber);
                }
            }
            else
            {
                var prMatch = prPattern.Match(commit.Message);
                if (prMatch.Success)
                {
                    if (int.TryParse(prMatch.Groups[1].Value, out var prNumber))
                    {
                        metrics.ReferencedPRs.Add(prNumber);
                    }
                }
            }
        }
    }

    private async Task<string> RunGitCommandAsync(string arguments)
    {
        var processStartInfo = new ProcessStartInfo
        {
            FileName = "git",
            Arguments = $"--no-pager {arguments}",
            WorkingDirectory = _repositoryPath,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using var process = new Process { StartInfo = processStartInfo };
        process.Start();
        
        var output = await process.StandardOutput.ReadToEndAsync();
        var error = await process.StandardError.ReadToEndAsync();
        
        await process.WaitForExitAsync();
        
        if (process.ExitCode != 0 && !string.IsNullOrEmpty(error))
        {
            // For some git commands, we expect them to potentially fail (e.g., when searching for commits that don't exist)
            // So we'll just return empty string instead of throwing
            return string.Empty;
        }
        
        return output.Trim();
    }

    private static string GenerateHtmlReport(ReleaseMetrics metrics, string tag)
    {
        var html = new StringBuilder();
        
        html.AppendLine("<!DOCTYPE html>");
        html.AppendLine("<html lang=\"en\">");
        html.AppendLine("<head>");
        html.AppendLine("    <meta charset=\"UTF-8\">");
        html.AppendLine("    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">");
        html.AppendLine($"    <title>Firely CQL SDK {tag} Release Report</title>");
        html.AppendLine("    <script src=\"https://cdn.jsdelivr.net/npm/chart.js\"></script>");
        html.AppendLine("    <style>");
        html.AppendLine(GetCssStyles());
        html.AppendLine("    </style>");
        html.AppendLine("</head>");
        html.AppendLine("<body>");
        
        // Header
        html.AppendLine($"    <div class=\"header\">");
        html.AppendLine($"        <h1>🚀 Firely CQL SDK {tag} Release Report</h1>");
        html.AppendLine($"        <p class=\"subtitle\">A comprehensive overview of development progress and metrics</p>");
        html.AppendLine($"        <p class=\"generated\">Generated on {DateTime.Now:yyyy-MM-dd HH:mm:ss UTC}</p>");
        html.AppendLine($"    </div>");

        // Summary Cards
        html.AppendLine("    <div class=\"container\">");
        html.AppendLine("        <div class=\"metrics-grid\">");
        html.AppendLine($"            <div class=\"metric-card\">");
        html.AppendLine($"                <div class=\"metric-number\">{metrics.Commits.Count:N0}</div>");
        html.AppendLine($"                <div class=\"metric-label\">Total Commits</div>");
        html.AppendLine($"            </div>");
        html.AppendLine($"            <div class=\"metric-card\">");
        html.AppendLine($"                <div class=\"metric-number\">{metrics.Contributors.Count:N0}</div>");
        html.AppendLine($"                <div class=\"metric-label\">Contributors</div>");
        html.AppendLine($"            </div>");
        html.AppendLine($"            <div class=\"metric-card\">");
        html.AppendLine($"                <div class=\"metric-number\">{metrics.PullRequests.Count:N0}</div>");
        html.AppendLine($"                <div class=\"metric-label\">Pull Requests</div>");
        html.AppendLine($"            </div>");
        html.AppendLine($"            <div class=\"metric-card\">");
        html.AppendLine($"                <div class=\"metric-number\">{metrics.CodeLines:N0}</div>");
        html.AppendLine($"                <div class=\"metric-label\">Lines of Code</div>");
        html.AppendLine($"            </div>");
        html.AppendLine($"            <div class=\"metric-card\">");
        html.AppendLine($"                <div class=\"metric-number\">{metrics.TotalFiles:N0}</div>");
        html.AppendLine($"                <div class=\"metric-label\">Code Files</div>");
        html.AppendLine($"            </div>");
        html.AppendLine($"            <div class=\"metric-card\">");
        html.AppendLine($"                <div class=\"metric-number\">{metrics.GetDevelopmentDays():N0}</div>");
        html.AppendLine($"                <div class=\"metric-label\">Development Days</div>");
        html.AppendLine($"            </div>");
        html.AppendLine("        </div>");

        // Milestone section
        AddMilestonesSection(html, metrics);

        // Contributors section
        AddContributorsSection(html, metrics);

        // Timeline section
        AddTimelineSection(html, metrics);

        // Tag info section
        AddTagInfoSection(html, metrics, tag);

        html.AppendLine("    </div>");
        html.AppendLine("</body>");
        html.AppendLine("</html>");

        return html.ToString();
    }

    private static void AddMilestonesSection(StringBuilder html, ReleaseMetrics metrics)
    {
        html.AppendLine("        <div class=\"section\">");
        html.AppendLine("            <h2>🎯 Development Milestones</h2>");
        html.AppendLine("            <div class=\"milestones\">");

        if (metrics.FirstCommit != null)
        {
            html.AppendLine("                <div class=\"milestone\">");
            html.AppendLine("                    <div class=\"milestone-icon\">🌱</div>");
            html.AppendLine("                    <div class=\"milestone-content\">");
            html.AppendLine("                        <h3>Repository Creation</h3>");
            html.AppendLine($"                        <p><strong>First commit by {metrics.FirstCommit.Author}</strong></p>");
            html.AppendLine($"                        <p>Date: {metrics.FirstCommit.Date:yyyy-MM-dd}</p>");
            html.AppendLine($"                        <p>Message: {metrics.FirstCommit.Message}</p>");
            html.AppendLine($"                        <p>Hash: <code>{metrics.FirstCommit.Hash[..8]}</code></p>");
            html.AppendLine("                    </div>");
            html.AppendLine("                </div>");
        }

        if (metrics.PaulFirstCommit != null)
        {
            html.AppendLine("                <div class=\"milestone\">");
            html.AppendLine("                    <div class=\"milestone-icon\">👨‍💻</div>");
            html.AppendLine("                    <div class=\"milestone-content\">");
            html.AppendLine("                        <h3>baseTwo (Paul den Boer) Contribution</h3>");
            html.AppendLine($"                        <p><strong>First commit by Paul den Boer</strong></p>");
            html.AppendLine($"                        <p>Date: {metrics.PaulFirstCommit.Date:yyyy-MM-dd}</p>");
            html.AppendLine($"                        <p>Message: {metrics.PaulFirstCommit.Message}</p>");
            html.AppendLine($"                        <p>Hash: <code>{metrics.PaulFirstCommit.Hash[..8]}</code></p>");
            html.AppendLine("                    </div>");
            html.AppendLine("                </div>");
        }

        if (metrics.DevelopSplitCommit != null)
        {
            html.AppendLine("                <div class=\"milestone\">");
            html.AppendLine("                    <div class=\"milestone-icon\">🌿</div>");
            html.AppendLine("                    <div class=\"milestone-content\">");
            html.AppendLine("                        <h3>Development Branch Split</h3>");
            html.AppendLine($"                        <p><strong>develop-2.0 / develop separation</strong></p>");
            html.AppendLine($"                        <p>Date: {metrics.DevelopSplitCommit.Date:yyyy-MM-dd}</p>");
            html.AppendLine($"                        <p>Message: {metrics.DevelopSplitCommit.Message}</p>");
            html.AppendLine($"                        <p>Hash: <code>{metrics.DevelopSplitCommit.Hash[..8]}</code></p>");
            html.AppendLine("                    </div>");
            html.AppendLine("                </div>");
        }

        html.AppendLine("            </div>");
        html.AppendLine("        </div>");
    }

    private static void AddContributorsSection(StringBuilder html, ReleaseMetrics metrics)
    {
        html.AppendLine("        <div class=\"section\">");
        html.AppendLine("            <h2>👥 Contributors</h2>");
        html.AppendLine("            <div class=\"contributors-chart\">");
        html.AppendLine("                <canvas id=\"contributorsChart\" width=\"400\" height=\"200\"></canvas>");
        html.AppendLine("            </div>");
        html.AppendLine("            <div class=\"contributors-list\">");
        
        foreach (var contributor in metrics.Contributors.OrderByDescending(c => c.Value))
        {
            var percentage = (double)contributor.Value / metrics.Commits.Count * 100;
            html.AppendLine($"                <div class=\"contributor\">");
            html.AppendLine($"                    <span class=\"contributor-name\">{contributor.Key}</span>");
            html.AppendLine($"                    <span class=\"contributor-commits\">{contributor.Value} commits ({percentage:F1}%)</span>");
            html.AppendLine($"                </div>");
        }
        
        html.AppendLine("            </div>");
        html.AppendLine("        </div>");

        // Add JavaScript for contributors chart
        html.AppendLine("        <script>");
        html.AppendLine("            const contributorsData = {");
        html.AppendLine($"                labels: {JsonSerializer.Serialize(metrics.Contributors.Keys)},");
        html.AppendLine($"                datasets: [{{");
        html.AppendLine($"                    data: {JsonSerializer.Serialize(metrics.Contributors.Values)},");
        html.AppendLine($"                    backgroundColor: ['#FF6384', '#36A2EB', '#FFCE56', '#4BC0C0', '#9966FF', '#FF9F40', '#FF6384', '#C9CBCF']");
        html.AppendLine($"                }}]");
        html.AppendLine("            };");
        html.AppendLine("            new Chart(document.getElementById('contributorsChart'), {");
        html.AppendLine("                type: 'doughnut',");
        html.AppendLine("                data: contributorsData,");
        html.AppendLine("                options: { responsive: true, plugins: { legend: { display: false } } }");
        html.AppendLine("            });");
        html.AppendLine("        </script>");
    }

    private static void AddTimelineSection(StringBuilder html, ReleaseMetrics metrics)
    {
        html.AppendLine("        <div class=\"section\">");
        html.AppendLine("            <h2>📈 Development Timeline</h2>");
        html.AppendLine("            <div class=\"timeline-chart\">");
        html.AppendLine("                <canvas id=\"timelineChart\" width=\"400\" height=\"200\"></canvas>");
        html.AppendLine("            </div>");
        html.AppendLine("        </div>");

        // Generate timeline data (commits per week)
        var weeklyCommits = metrics.Commits
            .GroupBy(c => GetWeekStart(c.Date))
            .OrderBy(g => g.Key)
            .ToDictionary(g => g.Key, g => g.Count());

        // Add JavaScript for timeline chart
        html.AppendLine("        <script>");
        html.AppendLine("            const timelineData = {");
        html.AppendLine($"                labels: {JsonSerializer.Serialize(weeklyCommits.Keys.Select(d => d.ToString("yyyy-MM-dd")))},");
        html.AppendLine($"                datasets: [{{");
        html.AppendLine($"                    label: 'Commits per Week',");
        html.AppendLine($"                    data: {JsonSerializer.Serialize(weeklyCommits.Values)},");
        html.AppendLine($"                    borderColor: '#36A2EB',");
        html.AppendLine($"                    backgroundColor: 'rgba(54, 162, 235, 0.2)',");
        html.AppendLine($"                    fill: true");
        html.AppendLine($"                }}]");
        html.AppendLine("            };");
        html.AppendLine("            new Chart(document.getElementById('timelineChart'), {");
        html.AppendLine("                type: 'line',");
        html.AppendLine("                data: timelineData,");
        html.AppendLine("                options: { responsive: true, scales: { y: { beginAtZero: true } } }");
        html.AppendLine("            });");
        html.AppendLine("        </script>");
    }

    private static void AddTagInfoSection(StringBuilder html, ReleaseMetrics metrics, string tag)
    {
        html.AppendLine("        <div class=\"section\">");
        html.AppendLine($"            <h2>🏷️ {tag} Release Information</h2>");
        
        if (metrics.TagCommit != null)
        {
            html.AppendLine("            <div class=\"tag-info\">");
            html.AppendLine($"                <p><strong>Commit:</strong> <code>{metrics.TagCommit.Hash}</code></p>");
            html.AppendLine($"                <p><strong>Author:</strong> {metrics.TagCommit.Author} ({metrics.TagCommit.Email})</p>");
            html.AppendLine($"                <p><strong>Date:</strong> {metrics.TagCommit.Date:yyyy-MM-dd HH:mm:ss}</p>");
            html.AppendLine($"                <p><strong>Message:</strong> {metrics.TagCommit.Message}</p>");
            html.AppendLine("            </div>");
        }

        if (metrics.PullRequests.Any())
        {
            html.AppendLine("            <div class=\"pull-requests\">");
            html.AppendLine("                <h3>Pull Requests Included</h3>");
            html.AppendLine("                <ul>");
            foreach (var pr in metrics.PullRequests.OrderBy(pr => pr))
            {
                html.AppendLine($"                    <li>#{pr}</li>");
            }
            html.AppendLine("                </ul>");
            html.AppendLine("            </div>");
        }

        html.AppendLine("        </div>");
    }

    private static DateTime GetWeekStart(DateTime date)
    {
        var diff = (7 + (date.DayOfWeek - DayOfWeek.Monday)) % 7;
        return date.AddDays(-1 * diff).Date;
    }

    private static string GetCssStyles()
    {
        return @"
        * { margin: 0; padding: 0; box-sizing: border-box; }
        
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            line-height: 1.6;
            color: #333;
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            min-height: 100vh;
        }
        
        .header {
            background: rgba(255, 255, 255, 0.95);
            padding: 2rem;
            text-align: center;
            box-shadow: 0 2px 10px rgba(0,0,0,0.1);
        }
        
        .header h1 {
            color: #2c3e50;
            margin-bottom: 0.5rem;
            font-size: 2.5rem;
        }
        
        .subtitle {
            color: #7f8c8d;
            font-size: 1.2rem;
            margin-bottom: 0.5rem;
        }
        
        .generated {
            color: #95a5a6;
            font-size: 0.9rem;
        }
        
        .container {
            max-width: 1200px;
            margin: 0 auto;
            padding: 2rem;
        }
        
        .metrics-grid {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(200px, 1fr));
            gap: 1.5rem;
            margin-bottom: 3rem;
        }
        
        .metric-card {
            background: white;
            padding: 2rem;
            border-radius: 10px;
            text-align: center;
            box-shadow: 0 4px 15px rgba(0,0,0,0.1);
            transition: transform 0.3s ease;
        }
        
        .metric-card:hover {
            transform: translateY(-5px);
        }
        
        .metric-number {
            font-size: 2.5rem;
            font-weight: bold;
            color: #3498db;
            margin-bottom: 0.5rem;
        }
        
        .metric-label {
            color: #7f8c8d;
            font-size: 1rem;
            text-transform: uppercase;
            letter-spacing: 1px;
        }
        
        .section {
            background: white;
            margin-bottom: 2rem;
            padding: 2rem;
            border-radius: 10px;
            box-shadow: 0 4px 15px rgba(0,0,0,0.1);
        }
        
        .section h2 {
            color: #2c3e50;
            margin-bottom: 1.5rem;
            font-size: 1.8rem;
            border-bottom: 3px solid #3498db;
            padding-bottom: 0.5rem;
        }
        
        .milestones {
            display: flex;
            flex-direction: column;
            gap: 1.5rem;
        }
        
        .milestone {
            display: flex;
            align-items: flex-start;
            gap: 1rem;
            padding: 1.5rem;
            background: #f8f9fa;
            border-radius: 8px;
            border-left: 4px solid #3498db;
        }
        
        .milestone-icon {
            font-size: 2rem;
            min-width: 3rem;
        }
        
        .milestone-content h3 {
            color: #2c3e50;
            margin-bottom: 0.5rem;
        }
        
        .milestone-content p {
            margin-bottom: 0.25rem;
            color: #5a6c7d;
        }
        
        .milestone-content code {
            background: #e9ecef;
            padding: 0.25rem 0.5rem;
            border-radius: 4px;
            font-family: 'Courier New', monospace;
        }
        
        .contributors-chart {
            max-width: 400px;
            margin: 0 auto 2rem;
        }
        
        .contributors-list {
            display: grid;
            gap: 1rem;
        }
        
        .contributor {
            display: flex;
            justify-content: space-between;
            align-items: center;
            padding: 1rem;
            background: #f8f9fa;
            border-radius: 6px;
        }
        
        .contributor-name {
            font-weight: 600;
            color: #2c3e50;
        }
        
        .contributor-commits {
            color: #7f8c8d;
        }
        
        .timeline-chart {
            margin: 2rem 0;
        }
        
        .tag-info {
            background: #f8f9fa;
            padding: 1.5rem;
            border-radius: 8px;
            margin-bottom: 1.5rem;
        }
        
        .tag-info p {
            margin-bottom: 0.5rem;
        }
        
        .pull-requests {
            background: #f8f9fa;
            padding: 1.5rem;
            border-radius: 8px;
        }
        
        .pull-requests h3 {
            color: #2c3e50;
            margin-bottom: 1rem;
        }
        
        .pull-requests ul {
            list-style: none;
            display: flex;
            flex-wrap: wrap;
            gap: 0.5rem;
        }
        
        .pull-requests li {
            background: #3498db;
            color: white;
            padding: 0.25rem 0.75rem;
            border-radius: 15px;
            font-size: 0.9rem;
        }
        
        @media (max-width: 768px) {
            .header h1 { font-size: 2rem; }
            .container { padding: 1rem; }
            .metrics-grid { grid-template-columns: repeat(auto-fit, minmax(150px, 1fr)); }
            .milestone { flex-direction: column; text-align: center; }
        }";
    }
}

public class ReleaseMetrics
{
    public List<CommitInfo> Commits { get; set; } = [];
    public Dictionary<string, int> Contributors { get; set; } = new();
    public HashSet<int> PullRequests { get; set; } = [];
    public HashSet<int> ReferencedPRs { get; set; } = [];
    public int TotalLines { get; set; }
    public int CodeLines { get; set; }
    public int TotalFiles { get; set; }
    
    public CommitInfo? TagCommit { get; set; }
    public CommitInfo? FirstCommit { get; set; }
    public CommitInfo? PaulFirstCommit { get; set; }
    public CommitInfo? DevelopSplitCommit { get; set; }

    public void CalculateContributorStats()
    {
        Contributors.Clear();
        foreach (var commit in Commits)
        {
            if (Contributors.ContainsKey(commit.Author))
                Contributors[commit.Author]++;
            else
                Contributors[commit.Author] = 1;
        }
    }

    public int GetDevelopmentDays()
    {
        if (!Commits.Any()) return 0;
        var firstDate = Commits.Min(c => c.Date);
        var lastDate = Commits.Max(c => c.Date);
        return (int)(lastDate - firstDate).TotalDays;
    }
}

public class CommitInfo
{
    public string Hash { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public string Message { get; set; } = string.Empty;
}

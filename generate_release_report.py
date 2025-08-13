#!/usr/bin/env python3
"""
Generate a visual report for the Firely CQL SDK 2.1.0-rc.1 release.

This script analyzes the git history and creates a comprehensive visual report
showing the development progress, metrics, and statistics from the first commit
to the 2.1.0-rc.1 release.
"""

import subprocess
import json
import pandas as pd
import matplotlib.pyplot as plt
import matplotlib.dates as mdates
import seaborn as sns
from datetime import datetime, timedelta
import re
from collections import defaultdict, Counter
import numpy as np
from pathlib import Path
import base64
from io import BytesIO

# Set up matplotlib for better charts
plt.style.use('seaborn-v0_8')
sns.set_palette("husl")
plt.rcParams['figure.figsize'] = (12, 8)
plt.rcParams['font.size'] = 10


class GitAnalyzer:
    """Analyze git repository history and generate metrics."""
    
    def __init__(self, repo_path="."):
        self.repo_path = repo_path
        self.target_tag = "v2.1.0-rc.1"
        
    def run_git_command(self, command):
        """Run a git command and return the output."""
        try:
            result = subprocess.run(
                f"git {command}",
                shell=True,
                cwd=self.repo_path,
                capture_output=True,
                text=True,
                check=True
            )
            return result.stdout.strip()
        except subprocess.CalledProcessError as e:
            print(f"Git command failed: {command}")
            print(f"Error: {e.stderr}")
            return ""
    
    def get_commit_history(self):
        """Get detailed commit history up to target tag."""
        # Get commits with detailed info
        log_format = "--format='%H|%ad|%an|%ae|%s|%P'"
        date_format = "--date=iso"
        command = f"log {self.target_tag} {log_format} {date_format}"
        
        commits_raw = self.run_git_command(command)
        commits = []
        
        for line in commits_raw.split('\n'):
            if line.strip():
                parts = line.strip().strip("'").split('|')
                if len(parts) >= 5:
                    try:
                        commit_date = datetime.strptime(parts[1][:19], '%Y-%m-%d %H:%M:%S')
                        commits.append({
                            'hash': parts[0],
                            'date': commit_date,
                            'author': parts[2],
                            'email': parts[3],
                            'message': parts[4],
                            'parents': parts[5] if len(parts) > 5 else '',
                            'is_merge': len(parts[5].split()) > 1 if len(parts) > 5 else False
                        })
                    except (ValueError, IndexError):
                        continue
        
        return sorted(commits, key=lambda x: x['date'])
    
    def get_line_stats(self):
        """Get lines of code statistics."""
        # Total changes up to target tag
        command = f"log {self.target_tag} --pretty=tformat: --numstat"
        stats_raw = self.run_git_command(command)
        
        total_added = 0
        total_removed = 0
        
        for line in stats_raw.split('\n'):
            if line.strip():
                parts = line.split('\t')
                if len(parts) >= 2:
                    try:
                        if parts[0].isdigit() and parts[1].isdigit():
                            total_added += int(parts[0])
                            total_removed += int(parts[1])
                    except (ValueError, IndexError):
                        continue
        
        return {
            'total_added': total_added,
            'total_removed': total_removed,
            'net_change': total_added - total_removed
        }
    
    def get_file_stats(self):
        """Get current file statistics."""
        # Count files and lines
        try:
            cs_files = subprocess.run(
                "find . -name '*.cs' | wc -l",
                shell=True,
                cwd=self.repo_path,
                capture_output=True,
                text=True
            ).stdout.strip()
            
            cs_lines = subprocess.run(
                "find . -name '*.cs' -exec wc -l {} + | tail -1",
                shell=True,
                cwd=self.repo_path,
                capture_output=True,
                text=True
            ).stdout.strip().split()[0]
            
            return {
                'cs_files': int(cs_files),
                'cs_lines': int(cs_lines)
            }
        except:
            return {'cs_files': 0, 'cs_lines': 0}
    
    def get_tag_info(self):
        """Get information about relevant tags."""
        command = "tag --sort=version:refname"
        tags_raw = self.run_git_command(command)
        
        relevant_tags = []
        for tag in tags_raw.split('\n'):
            if re.match(r'v\d+\.\d+', tag):
                # Get tag date
                tag_date_cmd = f"log -1 --format=%ad --date=short {tag}"
                tag_date = self.run_git_command(tag_date_cmd)
                if tag_date:
                    relevant_tags.append({
                        'tag': tag,
                        'date': datetime.strptime(tag_date, '%Y-%m-%d')
                    })
        
        return sorted(relevant_tags, key=lambda x: x['date'])


class ReportGenerator:
    """Generate visualizations and HTML report."""
    
    def __init__(self, analyzer):
        self.analyzer = analyzer
        self.charts = {}
        
    def save_chart_as_base64(self, fig, name):
        """Save a matplotlib figure as base64 string."""
        try:
            buffer = BytesIO()
            fig.savefig(buffer, format='png', dpi=150, bbox_inches='tight')
            buffer.seek(0)
            image_base64 = base64.b64encode(buffer.getvalue()).decode()
            buffer.close()
            plt.close(fig)
            self.charts[f"{name}_chart"] = image_base64
            print(f"✅ Generated chart: {name}")
        except Exception as e:
            print(f"❌ Error generating chart {name}: {e}")
            self.charts[f"{name}_chart"] = ""
        
    def create_commit_timeline(self, commits):
        """Create commit activity timeline."""
        df = pd.DataFrame(commits)
        df['date'] = pd.to_datetime(df['date'])
        
        # Group by month
        monthly_commits = df.groupby(df['date'].dt.to_period('M')).size()
        
        fig, (ax1, ax2) = plt.subplots(2, 1, figsize=(14, 10))
        
        # Monthly commit activity
        monthly_commits.plot(kind='bar', ax=ax1, color='steelblue', alpha=0.7)
        ax1.set_title('Monthly Commit Activity', fontsize=16, fontweight='bold')
        ax1.set_xlabel('Month')
        ax1.set_ylabel('Number of Commits')
        ax1.tick_params(axis='x', rotation=45)
        
        # Cumulative commits over time
        df_sorted = df.sort_values('date')
        df_sorted['cumulative'] = range(1, len(df_sorted) + 1)
        
        ax2.plot(df_sorted['date'], df_sorted['cumulative'], 
                color='darkgreen', linewidth=2, marker='o', markersize=2)
        ax2.set_title('Cumulative Commits Over Time', fontsize=16, fontweight='bold')
        ax2.set_xlabel('Date')
        ax2.set_ylabel('Total Commits')
        ax2.grid(True, alpha=0.3)
        
        # Format x-axis
        ax2.xaxis.set_major_formatter(mdates.DateFormatter('%Y-%m'))
        ax2.xaxis.set_major_locator(mdates.MonthLocator(interval=3))
        plt.setp(ax2.xaxis.get_majorticklabels(), rotation=45)
        
        plt.tight_layout()
        self.save_chart_as_base64(fig, 'commit_timeline')
        
    def create_author_contributions(self, commits):
        """Create author contribution charts."""
        authors = [c['author'] for c in commits]
        author_counts = Counter(authors)
        
        # Top 10 contributors
        top_authors = dict(author_counts.most_common(10))
        
        fig, (ax1, ax2) = plt.subplots(1, 2, figsize=(16, 8))
        
        # Bar chart
        authors_list = list(top_authors.keys())
        counts_list = list(top_authors.values())
        
        bars = ax1.bar(range(len(authors_list)), counts_list, color='coral', alpha=0.7)
        ax1.set_title('Top 10 Contributors', fontsize=16, fontweight='bold')
        ax1.set_xlabel('Contributors')
        ax1.set_ylabel('Number of Commits')
        ax1.set_xticks(range(len(authors_list)))
        ax1.set_xticklabels(authors_list, rotation=45, ha='right')
        
        # Add value labels on bars
        for bar, count in zip(bars, counts_list):
            ax1.text(bar.get_x() + bar.get_width()/2, bar.get_height() + 5,
                    str(count), ha='center', va='bottom')
        
        # Pie chart for top 5
        top_5 = dict(list(top_authors.items())[:5])
        others_count = sum(author_counts.values()) - sum(top_5.values())
        
        if others_count > 0:
            top_5['Others'] = others_count
            
        ax2.pie(top_5.values(), labels=top_5.keys(), autopct='%1.1f%%', startangle=90)
        ax2.set_title('Commit Distribution (Top 5 + Others)', fontsize=16, fontweight='bold')
        
        plt.tight_layout()
        self.save_chart_as_base64(fig, 'author_contributions')
        
    def create_pr_analysis(self, commits):
        """Analyze pull request activity."""
        merge_commits = [c for c in commits if c['is_merge']]
        
        df = pd.DataFrame(merge_commits)
        if len(df) > 0:
            df['date'] = pd.to_datetime(df['date'])
            monthly_prs = df.groupby(df['date'].dt.to_period('M')).size()
            
            fig, ax = plt.subplots(figsize=(14, 6))
            
            monthly_prs.plot(kind='bar', ax=ax, color='orange', alpha=0.7)
            ax.set_title('Monthly Pull Request Activity', fontsize=16, fontweight='bold')
            ax.set_xlabel('Month')
            ax.set_ylabel('Number of PRs Merged')
            ax.tick_params(axis='x', rotation=45)
            
            plt.tight_layout()
            self.save_chart_as_base64(fig, 'pr_analysis')
        
    def create_development_phases(self, commits, tags):
        """Create development phases visualization."""
        fig, ax = plt.subplots(figsize=(14, 8))
        
        # Plot commit activity
        df = pd.DataFrame(commits)
        df['date'] = pd.to_datetime(df['date'])
        
        # Weekly commit counts for smoother visualization
        weekly_commits = df.groupby(df['date'].dt.to_period('W')).size()
        weekly_dates = [period.start_time for period in weekly_commits.index]
        
        ax.plot(weekly_dates, weekly_commits.values, 
               color='blue', alpha=0.6, linewidth=1.5, label='Weekly Commits')
        
        # Mark major releases
        release_tags = [t for t in tags if 'rc' in t['tag'] or 'alpha' in t['tag'] or 'beta' in t['tag']]
        for tag_info in release_tags[-10:]:  # Last 10 releases
            ax.axvline(x=tag_info['date'], color='red', linestyle='--', alpha=0.7)
            ax.text(tag_info['date'], ax.get_ylim()[1] * 0.9, 
                   tag_info['tag'], rotation=90, fontsize=8, ha='right')
        
        ax.set_title('Development Timeline with Major Releases', fontsize=16, fontweight='bold')
        ax.set_xlabel('Date')
        ax.set_ylabel('Weekly Commits')
        ax.legend()
        ax.grid(True, alpha=0.3)
        
        plt.tight_layout()
        self.save_chart_as_base64(fig, 'development_phases')
        
    def generate_html_report(self, metrics):
        """Generate comprehensive HTML report."""
        # Ensure all charts exist with fallback
        chart_keys = ['commit_timeline_chart', 'author_contributions_chart', 'pr_analysis_chart', 'development_phases_chart']
        for key in chart_keys:
            if key not in self.charts:
                self.charts[key] = ""  # Empty string for missing charts
        
        html_template = """
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Firely CQL SDK 2.1.0-rc.1 Release Report</title>
    <style>
        body {{
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            margin: 0;
            padding: 20px;
            background-color: #f5f5f5;
            color: #333;
        }}
        .container {{
            max-width: 1200px;
            margin: 0 auto;
            background: white;
            border-radius: 10px;
            box-shadow: 0 4px 6px rgba(0,0,0,0.1);
            overflow: hidden;
        }}
        .header {{
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            color: white;
            padding: 40px;
            text-align: center;
        }}
        .header h1 {{
            margin: 0;
            font-size: 2.5em;
            font-weight: 300;
        }}
        .header p {{
            margin: 10px 0 0 0;
            font-size: 1.2em;
            opacity: 0.9;
        }}
        .content {{
            padding: 40px;
        }}
        .metrics-grid {{
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
            gap: 20px;
            margin-bottom: 40px;
        }}
        .metric-card {{
            background: #f8f9fa;
            border-radius: 8px;
            padding: 20px;
            text-align: center;
            border-left: 4px solid #667eea;
        }}
        .metric-value {{
            font-size: 2.5em;
            font-weight: bold;
            color: #667eea;
            display: block;
        }}
        .metric-label {{
            color: #666;
            font-size: 0.9em;
            text-transform: uppercase;
            letter-spacing: 1px;
        }}
        .chart-section {{
            margin: 40px 0;
        }}
        .chart-section h2 {{
            color: #333;
            border-bottom: 2px solid #667eea;
            padding-bottom: 10px;
            margin-bottom: 20px;
        }}
        .chart-container {{
            text-align: center;
            margin: 20px 0;
            background: white;
            border-radius: 8px;
            padding: 20px;
            box-shadow: 0 2px 4px rgba(0,0,0,0.1);
        }}
        .chart-container img {{
            max-width: 100%;
            height: auto;
            border-radius: 4px;
        }}
        .summary {{
            background: #e8f4f8;
            border-radius: 8px;
            padding: 30px;
            margin: 40px 0;
        }}
        .summary h3 {{
            color: #2c3e50;
            margin-top: 0;
        }}
        .footer {{
            background: #2c3e50;
            color: white;
            text-align: center;
            padding: 20px;
        }}
        .timeline-item {{
            background: white;
            margin: 10px 0;
            padding: 15px;
            border-radius: 5px;
            border-left: 4px solid #667eea;
        }}
    </style>
</head>
<body>
    <div class="container">
        <div class="header">
            <h1>Firely CQL SDK</h1>
            <p>Release Report for v2.1.0-rc.1</p>
        </div>
        
        <div class="content">
            <div class="metrics-grid">
                <div class="metric-card">
                    <span class="metric-value">{total_commits:,}</span>
                    <div class="metric-label">Total Commits</div>
                </div>
                <div class="metric-card">
                    <span class="metric-value">{total_prs:,}</span>
                    <div class="metric-label">Pull Requests</div>
                </div>
                <div class="metric-card">
                    <span class="metric-value">{development_days:,}</span>
                    <div class="metric-label">Development Days</div>
                </div>
                <div class="metric-card">
                    <span class="metric-value">{contributors:,}</span>
                    <div class="metric-label">Contributors</div>
                </div>
                <div class="metric-card">
                    <span class="metric-value">{lines_added:,}</span>
                    <div class="metric-label">Lines Added</div>
                </div>
                <div class="metric-card">
                    <span class="metric-value">{current_files:,}</span>
                    <div class="metric-label">C# Files</div>
                </div>
            </div>
            
            <div class="summary">
                <h3>🎯 Release Summary</h3>
                <p>The journey to <strong>Firely CQL SDK v2.1.0-rc.1</strong> represents a significant milestone in the development of this clinical quality language implementation. Over <strong>{development_days} days</strong> of development, the team has:</p>
                <ul>
                    <li>Committed <strong>{total_commits:,} changes</strong> to the codebase</li>
                    <li>Merged <strong>{total_prs:,} pull requests</strong> through collaborative review</li>
                    <li>Added <strong>{lines_added:,} lines of code</strong> while removing {lines_removed:,} lines</li>
                    <li>Engaged <strong>{contributors} contributors</strong> in the development process</li>
                    <li>Built a robust codebase with <strong>{current_files} C# files</strong> totaling {current_lines:,} lines</li>
                </ul>
                <p>The development started on <strong>{first_commit_date}</strong> and reached the 2.1.0-rc.1 milestone on <strong>{release_date}</strong>.</p>
            </div>
            
            <div class="chart-section">
                <h2>📈 Development Activity</h2>
                <div class="chart-container">
                    <img src="data:image/png;base64,{commit_timeline_chart}" alt="Commit Timeline">
                </div>
            </div>
            
            <div class="chart-section">
                <h2>👥 Contributor Analysis</h2>
                <div class="chart-container">
                    <img src="data:image/png;base64,{author_contributions_chart}" alt="Author Contributions">
                </div>
            </div>
            
            <div class="chart-section">
                <h2>🔄 Pull Request Activity</h2>
                <div class="chart-container">
                    <img src="data:image/png;base64,{pr_analysis_chart}" alt="PR Analysis">
                </div>
            </div>
            
            <div class="chart-section">
                <h2>🚀 Development Timeline</h2>
                <div class="chart-container">
                    <img src="data:image/png;base64,{development_phases_chart}" alt="Development Phases">
                </div>
            </div>
            
            <div class="summary">
                <h3>🔍 Technical Highlights</h3>
                <div class="timeline-item">
                    <strong>Repository Evolution:</strong> From initial commit to a comprehensive CQL SDK with extensive functionality
                </div>
                <div class="timeline-item">
                    <strong>Code Quality:</strong> Net addition of {net_change:,} lines demonstrates substantial feature development
                </div>
                <div class="timeline-item">
                    <strong>Collaborative Development:</strong> {total_prs:,} pull requests show strong code review practices
                </div>
                <div class="timeline-item">
                    <strong>Active Community:</strong> {contributors} contributors from the Firely team and community
                </div>
            </div>
        </div>
        
        <div class="footer">
            <p>Generated on {report_date} | Firely CQL SDK Project</p>
        </div>
    </div>
</body>
</html>
        """
        
        return html_template.format(**metrics, **self.charts)


def main():
    """Main function to generate the release report."""
    print("🔍 Analyzing Firely CQL SDK repository...")
    
    analyzer = GitAnalyzer()
    
    # Get repository data
    print("📊 Gathering commit history...")
    commits = analyzer.get_commit_history()
    
    print("📈 Calculating statistics...")
    line_stats = analyzer.get_line_stats()
    file_stats = analyzer.get_file_stats()
    tags = analyzer.get_tag_info()
    
    # Calculate metrics
    first_commit = min(commits, key=lambda x: x['date'])
    last_commit = max(commits, key=lambda x: x['date'])
    development_days = (last_commit['date'] - first_commit['date']).days
    
    unique_authors = set(c['author'] for c in commits)
    merge_commits = [c for c in commits if c['is_merge']]
    
    metrics = {
        'total_commits': len(commits),
        'total_prs': len(merge_commits),
        'development_days': development_days,
        'contributors': len(unique_authors),
        'lines_added': line_stats['total_added'],
        'lines_removed': line_stats['total_removed'],
        'net_change': line_stats['net_change'],
        'current_files': file_stats['cs_files'],
        'current_lines': file_stats['cs_lines'],
        'first_commit_date': first_commit['date'].strftime('%B %d, %Y'),
        'release_date': last_commit['date'].strftime('%B %d, %Y'),
        'report_date': datetime.now().strftime('%B %d, %Y')
    }
    
    # Generate visualizations
    print("📊 Creating visualizations...")
    report_gen = ReportGenerator(analyzer)
    
    report_gen.create_commit_timeline(commits)
    report_gen.create_author_contributions(commits)
    report_gen.create_pr_analysis(commits)
    report_gen.create_development_phases(commits, tags)
    
    # Generate HTML report
    print("📄 Generating HTML report...")
    html_content = report_gen.generate_html_report(metrics)
    
    # Save report
    report_path = Path("firely_cql_sdk_2.1.0_rc1_report.html")
    with open(report_path, 'w', encoding='utf-8') as f:
        f.write(html_content)
    
    print(f"✅ Report generated successfully: {report_path.absolute()}")
    print(f"\n📊 Quick Stats:")
    print(f"   Total Commits: {metrics['total_commits']:,}")
    print(f"   Pull Requests: {metrics['total_prs']:,}")
    print(f"   Development Days: {metrics['development_days']:,}")
    print(f"   Contributors: {metrics['contributors']:,}")
    print(f"   Lines Added: {metrics['lines_added']:,}")
    print(f"   Current C# Files: {metrics['current_files']:,}")


if __name__ == "__main__":
    main()
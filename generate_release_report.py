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

# Set up matplotlib with Firely colors
plt.style.use('seaborn-v0_8')

# Firely color palette (professional blues and oranges)
FIRELY_COLORS = {
    'primary_blue': '#1f4e79',
    'secondary_blue': '#2e75b6',
    'accent_orange': '#ff7f00', 
    'light_blue': '#5ba0d0',
    'dark_blue': '#0f2e54',
    'grey': '#666666',
    'light_grey': '#f5f5f5'
}

# Set color palette
firely_palette = [FIRELY_COLORS['primary_blue'], FIRELY_COLORS['secondary_blue'], 
                  FIRELY_COLORS['accent_orange'], FIRELY_COLORS['light_blue'],
                  FIRELY_COLORS['dark_blue'], FIRELY_COLORS['grey']]
sns.set_palette(firely_palette)

plt.rcParams['figure.figsize'] = (12, 8)
plt.rcParams['font.size'] = 10


class GitAnalyzer:
    """Analyze git repository history and generate metrics."""
    
    def __init__(self, repo_path="."):
        self.repo_path = repo_path
        # Use HEAD to get current branch history
        self.target_ref = "HEAD"  
        self.target_tag = "v2.1.0-rc.1"
        self.baseTwo_first_commit = None
        
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
        """Get detailed commit history tracking develop and develop-2.0 branches."""
        log_format = '--format="%H|%ad|%an|%ae|%s|%P"'
        date_format = "--date=iso"
        
        # Start with the current branch history
        command = f"log {self.target_ref} {log_format} {date_format}"
        commits_raw = self.run_git_command(command)
        
        # If empty, try all commits
        if not commits_raw.strip():
            print(f"⚠️  {self.target_ref} not found, trying all commits")
            command = f"log --all {log_format} {date_format}"
            commits_raw = self.run_git_command(command)
        
        commits = []
        baseTwo_first_commit = None
        
        for line in commits_raw.split('\n'):
            if line.strip():
                parts = line.strip().split('|')
                if len(parts) >= 5:
                    try:
                        commit_date = datetime.strptime(parts[1][:19], '%Y-%m-%d %H:%M:%S')
                        commit_info = {
                            'hash': parts[0],
                            'date': commit_date,
                            'author': parts[2],
                            'email': parts[3],
                            'message': parts[4],
                            'parents': parts[5] if len(parts) > 5 else '',
                            'is_merge': len(parts[5].split()) > 1 if len(parts) > 5 else False
                        }
                        commits.append(commit_info)
                        
                        # Track Paul den Boer's (baseTwo) first commit
                        if parts[2] in ['baseTwo', 'Paul den Boer'] and baseTwo_first_commit is None:
                            baseTwo_first_commit = commit_info
                            
                    except (ValueError, IndexError):
                        continue
        
        commits_sorted = sorted(commits, key=lambda x: x['date'])
        
        # Store baseTwo's first commit for timeline marking
        self.baseTwo_first_commit = baseTwo_first_commit
        
        return commits_sorted
    
    def get_line_stats(self):
        """Get lines of code statistics for *.cs files only (excluding *.g.cs)."""
        # Use HEAD for current branch, fallback to tag, then all commits
        command = f"log {self.target_ref} --pretty=tformat: --numstat"
        stats_raw = self.run_git_command(command)
        
        # If no output with HEAD, try the tag
        if not stats_raw.strip():
            command = f"log {self.target_tag} --pretty=tformat: --numstat"
            stats_raw = self.run_git_command(command)
            
        # If still no output, try all commits
        if not stats_raw.strip():
            command = f"log --all --pretty=tformat: --numstat"
            stats_raw = self.run_git_command(command)
        
        total_added = 0
        total_removed = 0
        
        for line in stats_raw.split('\n'):
            if line.strip():
                parts = line.split('\t')
                if len(parts) >= 3:  # added, removed, filename
                    try:
                        filename = parts[2]
                        # Only count .cs files, but exclude .g.cs generated files
                        if filename.endswith('.cs') and not filename.endswith('.g.cs'):
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
        """Get current file statistics for *.cs files only (excluding *.g.cs)."""
        # Count files and lines for .cs files excluding .g.cs
        try:
            cs_files = subprocess.run(
                "find . -name '*.cs' ! -name '*.g.cs' | wc -l",
                shell=True,
                cwd=self.repo_path,
                capture_output=True,
                text=True
            ).stdout.strip()
            
            cs_lines = subprocess.run(
                "find . -name '*.cs' ! -name '*.g.cs' -exec wc -l {} + 2>/dev/null | tail -1 | awk '{print $1}'",
                shell=True,
                cwd=self.repo_path,
                capture_output=True,
                text=True
            ).stdout.strip()
            
            return {
                'cs_files': int(cs_files) if cs_files else 0,
                'cs_lines': int(cs_lines) if cs_lines else 0
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
        monthly_commits.plot(kind='bar', ax=ax1, color=FIRELY_COLORS['secondary_blue'], alpha=0.8)
        ax1.set_title('Monthly Commit Activity', fontsize=16, fontweight='bold', color=FIRELY_COLORS['dark_blue'])
        ax1.set_xlabel('Month')
        ax1.set_ylabel('Number of Commits')
        ax1.tick_params(axis='x', rotation=45)
        ax1.grid(True, alpha=0.3)
        
        # Cumulative commits over time
        df_sorted = df.sort_values('date')
        df_sorted['cumulative'] = range(1, len(df_sorted) + 1)
        
        ax2.plot(df_sorted['date'], df_sorted['cumulative'], 
                color=FIRELY_COLORS['primary_blue'], linewidth=3, marker='o', markersize=3)
        ax2.set_title('Cumulative Commits Over Time', fontsize=16, fontweight='bold', color=FIRELY_COLORS['dark_blue'])
        ax2.set_xlabel('Date')
        ax2.set_ylabel('Total Commits')
        ax2.grid(True, alpha=0.3)
        
        # Mark baseTwo's first commit if found
        if self.analyzer.baseTwo_first_commit:
            baseTwo_date = self.analyzer.baseTwo_first_commit['date']
            ax2.axvline(x=baseTwo_date, color=FIRELY_COLORS['accent_orange'], linestyle='--', linewidth=2, alpha=0.8)
            ax2.text(baseTwo_date, ax2.get_ylim()[1] * 0.8, 
                   'Paul den Boer\nFirst Commit', rotation=0, fontsize=9, ha='center',
                   bbox=dict(boxstyle="round,pad=0.3", facecolor=FIRELY_COLORS['accent_orange'], alpha=0.7))
        
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
        
        # Bar chart with Firely colors
        authors_list = list(top_authors.keys())
        counts_list = list(top_authors.values())
        
        bars = ax1.bar(range(len(authors_list)), counts_list, color=FIRELY_COLORS['secondary_blue'], alpha=0.8)
        ax1.set_title('Top 10 Contributors', fontsize=16, fontweight='bold', color=FIRELY_COLORS['dark_blue'])
        ax1.set_xlabel('Contributors')
        ax1.set_ylabel('Number of Commits')
        ax1.set_xticks(range(len(authors_list)))
        ax1.set_xticklabels(authors_list, rotation=45, ha='right')
        ax1.grid(True, alpha=0.3)
        
        # Add value labels on bars
        for bar, count in zip(bars, counts_list):
            ax1.text(bar.get_x() + bar.get_width()/2, bar.get_height() + 5,
                    str(count), ha='center', va='bottom', fontweight='bold')
        
        # Pie chart for top 5 with Firely colors
        top_5 = dict(list(top_authors.items())[:5])
        others_count = sum(author_counts.values()) - sum(top_5.values())
        
        if others_count > 0:
            top_5['Others'] = others_count
            
        colors = [FIRELY_COLORS['primary_blue'], FIRELY_COLORS['secondary_blue'], 
                 FIRELY_COLORS['accent_orange'], FIRELY_COLORS['light_blue'],
                 FIRELY_COLORS['dark_blue'], FIRELY_COLORS['grey']][:len(top_5)]
        
        ax2.pie(top_5.values(), labels=top_5.keys(), autopct='%1.1f%%', startangle=90, colors=colors)
        ax2.set_title('Commit Distribution (Top 5 + Others)', fontsize=16, fontweight='bold', color=FIRELY_COLORS['dark_blue'])
        
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
            
            monthly_prs.plot(kind='bar', ax=ax, color=FIRELY_COLORS['accent_orange'], alpha=0.8)
            ax.set_title('Monthly Pull Request Activity', fontsize=16, fontweight='bold', color=FIRELY_COLORS['dark_blue'])
            ax.set_xlabel('Month')
            ax.set_ylabel('Number of PRs Merged')
            ax.tick_params(axis='x', rotation=45)
            ax.grid(True, alpha=0.3)
            
            plt.tight_layout()
            self.save_chart_as_base64(fig, 'pr_analysis')
        
    def create_development_phases(self, commits, tags):
        """Create development phases visualization with enhanced timeline."""
        fig, ax = plt.subplots(figsize=(16, 10))
        
        # Plot commit activity
        df = pd.DataFrame(commits)
        df['date'] = pd.to_datetime(df['date'])
        
        # Weekly commit counts for smoother visualization
        weekly_commits = df.groupby(df['date'].dt.to_period('W')).size()
        weekly_dates = [period.start_time for period in weekly_commits.index]
        
        ax.plot(weekly_dates, weekly_commits.values, 
               color=FIRELY_COLORS['primary_blue'], alpha=0.8, linewidth=2, label='Weekly Commits')
        
        # Mark major releases with enhanced visibility
        major_releases = []
        for tag_info in tags:
            tag_name = tag_info['tag']
            if any(keyword in tag_name.lower() for keyword in ['rc', 'beta', 'alpha', 'v1.0', 'v2.0']):
                major_releases.append(tag_info)
        
        # Show all major releases chronologically
        major_releases = sorted(major_releases, key=lambda x: x['date'])
        
        for i, tag_info in enumerate(major_releases):
            color = FIRELY_COLORS['accent_orange'] if 'rc' in tag_info['tag'] else FIRELY_COLORS['secondary_blue']
            ax.axvline(x=tag_info['date'], color=color, linestyle='--', alpha=0.8, linewidth=2)
            
            # Alternate text positions to avoid overlap
            y_pos = ax.get_ylim()[1] * (0.9 if i % 2 == 0 else 0.7)
            ax.text(tag_info['date'], y_pos, 
                   tag_info['tag'], rotation=90, fontsize=8, ha='right',
                   bbox=dict(boxstyle="round,pad=0.2", facecolor=color, alpha=0.6))
        
        # Mark baseTwo's first commit
        if self.analyzer.baseTwo_first_commit:
            baseTwo_date = self.analyzer.baseTwo_first_commit['date']
            ax.axvline(x=baseTwo_date, color=FIRELY_COLORS['accent_orange'], 
                      linestyle=':', linewidth=3, alpha=0.9, label='Paul den Boer First Commit')
            ax.text(baseTwo_date, ax.get_ylim()[1] * 0.5, 
                   'Paul den Boer\nFirst Commit', rotation=90, fontsize=9, ha='center',
                   bbox=dict(boxstyle="round,pad=0.3", facecolor=FIRELY_COLORS['accent_orange'], alpha=0.8))
        
        # Mark develop-2.0 branch creation (estimate based on version 2.0.0-alpha)
        v2_alpha_tag = next((t for t in tags if t['tag'] == 'v2.0.0-alpha'), None)
        if v2_alpha_tag:
            ax.axvline(x=v2_alpha_tag['date'], color=FIRELY_COLORS['dark_blue'], 
                      linestyle='-', linewidth=3, alpha=0.7, label='develop-2.0 Branch')
            ax.text(v2_alpha_tag['date'], ax.get_ylim()[1] * 0.3, 
                   'develop-2.0\nBranch Created', rotation=90, fontsize=9, ha='center',
                   bbox=dict(boxstyle="round,pad=0.3", facecolor=FIRELY_COLORS['dark_blue'], alpha=0.7))
        
        ax.set_title('Development Timeline with Major Milestones', fontsize=18, fontweight='bold', color=FIRELY_COLORS['dark_blue'])
        ax.set_xlabel('Date', fontsize=12)
        ax.set_ylabel('Weekly Commits', fontsize=12)
        ax.legend(loc='upper left')
        ax.grid(True, alpha=0.3)
        
        # Enhance x-axis formatting
        ax.xaxis.set_major_formatter(mdates.DateFormatter('%Y-%m'))
        ax.xaxis.set_major_locator(mdates.MonthLocator(interval=2))
        plt.setp(ax.xaxis.get_majorticklabels(), rotation=45)
        
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
            background: linear-gradient(135deg, {primary_blue} 0%, {secondary_blue} 100%);
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
            border-left: 4px solid {secondary_blue};
        }}
        .metric-value {{
            font-size: 2.5em;
            font-weight: bold;
            color: {primary_blue};
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
            border-bottom: 2px solid {secondary_blue};
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
            border-left: 4px solid {secondary_blue};
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
                    <div class="metric-label">C# Lines Added</div>
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
                    <li>Added <strong>{lines_added:,} lines of C# code</strong> while removing {lines_removed:,} lines (excluding generated files)</li>
                    <li>Engaged <strong>{contributors} contributors</strong> in the development process, with <strong>Paul den Boer (baseTwo)</strong> joining as a key contributor</li>
                    <li>Built a robust codebase with <strong>{current_files} C# files</strong> totaling {current_lines:,} lines</li>
                    <li>Evolved from <strong>develop</strong> to <strong>develop-2.0</strong> branch structure for the 2.x series</li>
                </ul>
                <p>The development started on <strong>{first_commit_date}</strong> and reached the 2.1.0-rc.1 milestone on <strong>{release_date}</strong>.</p>
            </div>
            
            <div class="chart-section">
                <h2>📈 Development Activity Timeline</h2>
                <div class="chart-container">
                    <img src="data:image/png;base64,{commit_timeline_chart}" alt="Commit Timeline showing monthly activity and cumulative progress with key contributor milestones">
                </div>
            </div>
            
            <div class="chart-section">
                <h2>👥 Contributor Analysis</h2>
                <div class="chart-container">
                    <img src="data:image/png;base64,{author_contributions_chart}" alt="Top contributors and commit distribution across the team">
                </div>
            </div>
            
            <div class="chart-section">
                <h2>🔄 Pull Request Activity</h2>
                <div class="chart-container">
                    <img src="data:image/png;base64,{pr_analysis_chart}" alt="Monthly pull request merge activity">
                </div>
            </div>
            
            <div class="chart-section">
                <h2>🚀 Development Timeline & Major Milestones</h2>
                <div class="chart-container">
                    <img src="data:image/png;base64,{development_phases_chart}" alt="Complete development timeline with release milestones, branch evolution, and key contributor events">
                </div>
            </div>
            
            <div class="summary">
                <h3>🔍 Technical Highlights</h3>
                <div class="timeline-item">
                    <strong>Repository Evolution:</strong> From initial commit to a comprehensive CQL SDK with extensive functionality spanning {development_days} days
                </div>
                <div class="timeline-item">
                    <strong>Branch Evolution:</strong> Strategic transition from develop to develop-2.0 branch structure for 2.x series
                </div>
                <div class="timeline-item">
                    <strong>Code Quality:</strong> Net addition of {net_change:,} C# lines demonstrates substantial feature development (excluding generated .g.cs files)
                </div>
                <div class="timeline-item">
                    <strong>Collaborative Development:</strong> {total_prs:,} pull requests show strong code review practices across {contributors} contributors
                </div>
                <div class="timeline-item">
                    <strong>Key Contributors:</strong> Paul den Boer (baseTwo) made significant contributions to the project's success
                </div>
            </div>
        </div>
        
        <div class="footer">
            <p>Generated on {report_date} | Firely CQL SDK Project | Report covers development journey to v2.1.0-rc.1</p>
        </div>
    </div>
</body>
</html>
        """
        
        return html_template.format(
            primary_blue=FIRELY_COLORS['primary_blue'],
            secondary_blue=FIRELY_COLORS['secondary_blue'],
            **metrics, 
            **self.charts
        )


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
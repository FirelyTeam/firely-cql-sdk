# Branch Renaming Implementation Guide

This document provides detailed step-by-step implementation commands and procedures for the approved branch renaming solution.

## Implementation Overview

**Objective:** Rename branches to align with Git Flow conventions
- `develop` → `develop-1.0` (1.x maintenance)
- `develop-2.0` → `develop` (current development)

**Timeline:** 1-2 weeks with coordination, ~1 hour active implementation
**Risk Level:** High - requires careful coordination and risk mitigation

## Prerequisites Checklist

Before starting implementation, ensure all items are completed:

### Administrative Requirements
- [ ] GitHub admin access for protected branch management
- [ ] Repository administrator permissions confirmed
- [ ] Azure DevOps access for pipeline verification
- [ ] Emergency contact list prepared

### Team Coordination
- [ ] Team notification sent (minimum 48 hours in advance)
- [ ] Scheduled maintenance window confirmed with all stakeholders
- [ ] Support coverage arranged for developer assistance
- [ ] Emergency rollback contact available

### Technical Preparation
- [ ] Current branch state documented and backed up
- [ ] All open PRs identified and cataloged
- [ ] External dependency audit completed
- [ ] Rollback procedure tested in development environment

## Phase 1: Pre-Implementation (1-2 days before)

### 1. Document Current State
```bash
# Create comprehensive backup of current branches
git ls-remote --heads origin > /tmp/current_branches_backup_$(date +%Y%m%d).txt
cat /tmp/current_branches_backup_$(date +%Y%m%d).txt

# Document current protection rules (manual step via GitHub web interface)
# Navigate to: Settings → Branches → Branch protection rules
# Screenshot or document each rule for develop and develop-2.0
```

### 2. Audit Open Pull Requests
```bash
# Check PRs targeting develop
gh pr list --state open --base develop --json number,title,author

# Check PRs targeting develop-2.0  
gh pr list --state open --base develop-2.0 --json number,title,author

# Export for tracking
gh pr list --state open --base develop --json number,title,author,url > /tmp/prs_develop_$(date +%Y%m%d).json
gh pr list --state open --base develop-2.0 --json number,title,author,url > /tmp/prs_develop-2.0_$(date +%Y%m%d).json
```

### 3. Verify CI/CD Configuration
```bash
# Confirm Azure DevOps pipeline configuration supports both patterns
# Check build/azure-pipelines.yml contains both trigger patterns
grep -n "develop" .github/workflows/* build/azure-pipelines.yml || echo "No workflows found"
```

### 4. Send Team Notification
```bash
# Use this template for team communication
cat << 'EOF' > /tmp/team_notification.md
🚨 SCHEDULED MAINTENANCE: Branch Renaming

Date: [INSERT DATE]
Time: [INSERT TIME] 
Duration: ~1 hour

Changes:
- develop → develop-1.0 (1.x maintenance)
- develop-2.0 → develop (current development)

Action Required After Maintenance:
All team members must update local repositories using provided commands.

Impact:
- Short CI/CD disruption during transition
- Local repository updates required
- Open PR targets will be updated automatically

Contact: [INSERT CONTACT] for questions
EOF

# Send this content via your team communication channels
```

## Phase 2: Implementation Day

⚠️ **IMPORTANT: These steps must be executed in exact order during the maintenance window**

### Step 1: Prepare GitHub Branch Settings
```bash
# Document current default branch
curl -s -H "Authorization: token $GITHUB_TOKEN" \
  "https://api.github.com/repos/FirelyTeam/firely-cql-sdk" | \
  jq '.default_branch'

# Note: Default branch changes must be done via GitHub web interface
```

### Step 2: Remove Branch Protection (Temporarily)
**Manual Step via GitHub Web Interface:**
1. Go to Settings → Branches
2. For each protected branch (develop, develop-2.0):
   - Click "Edit" on the protection rule
   - Screenshot the current settings
   - Click "Delete" to remove protection temporarily

### Step 3: Execute Branch Renaming
```bash
# Set up environment
cd /home/runner/work/firely-cql-sdk/firely-cql-sdk
git fetch origin
git remote prune origin

# Step 3a: Rename develop to develop-1.0
echo "Renaming develop to develop-1.0..."
git checkout develop
git pull origin develop  # Ensure latest
git branch -m develop develop-1.0
git push origin develop-1.0
git push origin :develop  # Delete remote develop

# Step 3b: Rename develop-2.0 to develop  
echo "Renaming develop-2.0 to develop..."
git checkout develop-2.0
git pull origin develop-2.0  # Ensure latest
git branch -m develop-2.0 develop
git push origin develop
git push origin :develop-2.0  # Delete remote develop-2.0

# Verify renaming completed
git ls-remote --heads origin | grep -E "(develop|main)"
```

### Step 4: Update Default Branch (if needed)
**Manual Step via GitHub Web Interface:**
1. Go to Settings → General → Default branch
2. If not already set to `develop`, change it to `develop`
3. Confirm the change

### Step 5: Restore Branch Protection
**Manual Step via GitHub Web Interface:**
1. Go to Settings → Branches
2. Create protection rule for `develop`:
   - Use same settings as old `develop-2.0` had
   - Apply all previous restrictions and requirements
3. Create protection rule for `develop-1.0`:
   - Use same settings as old `develop` had
   - Apply appropriate maintenance branch restrictions

## Phase 3: Post-Implementation Tasks

### Step 1: Update Pull Request Targets
```bash
# Get list of PRs that need retargeting
gh pr list --state open --json number,baseRefName | \
  jq '.[] | select(.baseRefName == "develop-2.0") | .number'

# For each PR targeting the old develop-2.0 (now targeting non-existent branch)
# Update to target new develop branch
for pr_number in $(gh pr list --state open --json number,baseRefName | \
  jq -r '.[] | select(.baseRefName == "develop-2.0") | .number'); do
  echo "Updating PR #$pr_number to target develop"
  gh pr edit $pr_number --base develop
done

# For any PRs that were targeting old develop (now develop-1.0)
# These likely need manual review to determine correct target
gh pr list --state open --base develop-1.0 --json number,title
```

### Step 2: Verification Testing
```bash
# Test 1: Verify branch structure
echo "=== Current Branch Structure ==="
git ls-remote --heads origin | grep -E "(develop|main)" | sort

# Test 2: Verify CI/CD triggers
echo "=== Testing CI/CD Integration ==="
# Create a test commit to verify pipelines trigger correctly
git checkout develop
echo "# Test commit for branch renaming verification" > /tmp/test_rename.md
git add /tmp/test_rename.md
git commit -m "Test: Verify CI/CD after branch renaming"
git push origin develop
rm /tmp/test_rename.md

# Test 3: Verify protection rules
echo "=== Verify Branch Protection ==="
# This should fail if protection is working
git push origin develop --force-with-lease 2>&1 | grep -q "protected" && echo "✅ Protection active" || echo "❌ Protection missing"

# Test 4: Verify default branch
curl -s -H "Authorization: token $GITHUB_TOKEN" \
  "https://api.github.com/repos/FirelyTeam/firely-cql-sdk" | \
  jq '.default_branch'
```

### Step 3: Team Migration Support
```bash
# Create migration script for team members
cat << 'EOF' > /tmp/developer_migration.sh
#!/bin/bash
# Developer Migration Script for Branch Renaming
# Run this in your local firely-cql-sdk repository

set -e

echo "🔄 Migrating local repository after branch renaming..."

# Fetch latest state
git fetch origin
git remote prune origin

# Remove old local branches
echo "Removing old local branches..."
git branch -D develop develop-2.0 2>/dev/null || echo "Some branches didn't exist locally"

# Create new tracking branches
echo "Setting up new branch tracking..."
git checkout -b develop origin/develop
git checkout -b develop-1.0 origin/develop-1.0

# Show current branch status
echo "✅ Migration complete! Current branches:"
git branch -vv

echo ""
echo "📋 Quick Reference:"
echo "- develop: Current 2.x development (was develop-2.0)"
echo "- develop-1.0: 1.x maintenance (was develop)"
echo "- main: Stable releases"
EOF

chmod +x /tmp/developer_migration.sh
echo "Migration script created at /tmp/developer_migration.sh"
echo "Share this script with team members for easy local migration"
```

### Step 4: Documentation Updates
```bash
# README.md should now correctly reference 'develop' branch
# Verify the build badge and contributing sections are accurate
grep -n "develop" README.md

# Update any other documentation that might reference old branch names
find . -name "*.md" -not -path "./.git/*" -exec grep -l "develop-2.0" {} \; || echo "No references found"
```

## Emergency Rollback Procedure

If critical issues arise during implementation, use this rollback:

```bash
# EMERGENCY ROLLBACK - Only use if implementation fails

echo "🚨 EMERGENCY ROLLBACK INITIATED"

# Step 1: Remove protection from renamed branches (via GitHub web interface)

# Step 2: Restore original branch names
git fetch origin

# Rollback develop (currently new) back to develop-2.0
git checkout develop
git branch -m develop develop-2.0
git push origin develop-2.0
git push origin :develop

# Rollback develop-1.0 back to develop
git checkout develop-1.0  
git branch -m develop-1.0 develop
git push origin develop
git push origin :develop-1.0

# Step 3: Restore original branch protection rules (via GitHub web interface)

# Step 4: Notify team of rollback
echo "Rollback complete. Notify team immediately!"
```

## Testing and Verification Checklist

After implementation, verify each item:

### Critical System Verification
- [ ] CI/CD pipelines trigger correctly on new branch names
- [ ] Protected branch rules are active and properly configured
- [ ] Default branch is set correctly in GitHub
- [ ] No broken references in repository settings
- [ ] Build status badges function correctly

### Pull Request Verification  
- [ ] All open PRs have valid target branches
- [ ] No PRs targeting non-existent branches
- [ ] PR authors notified of any target changes
- [ ] New PRs default to correct branch

### Team Migration Verification
- [ ] Developer migration script tested
- [ ] Team members successfully updated local environments
- [ ] No reported issues with local development workflows
- [ ] Team documentation updated

### External Integration Verification
- [ ] Azure DevOps pipelines functioning
- [ ] No external systems reporting branch reference errors
- [ ] Documentation sites reflect new structure
- [ ] Third-party integrations still functioning

## Post-Implementation Communication

### Success Notification Template
```
✅ BRANCH RENAMING COMPLETE

The branch renaming has been successfully completed:
- develop → develop-1.0 (1.x maintenance)
- develop-2.0 → develop (current development)

Action Required:
1. Update your local repository using the migration script
2. Verify your development workflow
3. Report any issues immediately

Migration script: [LINK TO SCRIPT]
Support: [SUPPORT CONTACT]
```

### Issue Reporting Template
```
If you encounter issues after the branch renaming:

1. 📝 Describe the problem
2. 💻 Include your local git status: `git status && git branch -vv`
3. 🔗 Mention any affected PRs or workflows
4. 📞 Contact: [EMERGENCY CONTACT]

Common fixes available at: [TROUBLESHOOTING LINK]
```

---

**Total Implementation Time:** 1-2 weeks coordination + ~1 hour active work  
**Risk Level:** High (mitigated through careful planning and rollback procedures)  
**Success Dependencies:** Team coordination, admin access, comprehensive testing
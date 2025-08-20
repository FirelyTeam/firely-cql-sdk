# Quick Reference: Branch Renaming Implementation

This document provides step-by-step implementation guides for both proposed solutions.

## Option A: Update Documentation Only (RECOMMENDED)

### Step 1: Update README.md

```bash
# Update the build status badge
sed -i 's/branchName=develop/branchName=develop-2.0/' README.md

# Update the contributing section  
sed -i 's/against the `develop` branch/against the `develop-2.0` branch/' README.md
```

### Step 2: Verify Changes
```bash
# Check the changes
git diff README.md

# Test build badge URL (should return valid response)
curl -I "https://dev.azure.com/firely/firely-net-sdk/_apis/build/status%2FFirelyTeam.firely-cql-sdk?repoName=FirelyTeam%2Ffirely-cql-sdk&branchName=develop-2.0"
```

### Step 3: Commit and Deploy
```bash
git add README.md
git commit -m "Update contributing guidelines to reference develop-2.0 branch

- Fix inconsistency where README referenced develop branch
- Update build status badge to point to develop-2.0
- Aligns documentation with current development branch structure

Fixes #956"
```

**Total Implementation Time:** ~30 minutes

---

## Option B: Complete Branch Renaming

⚠️ **WARNING: HIGH IMPACT OPERATION - REQUIRES ADMIN ACCESS AND TEAM COORDINATION**

### Prerequisites
- [ ] GitHub admin access for protected branch management
- [ ] Team notification at least 48 hours in advance
- [ ] Scheduled maintenance window
- [ ] Backup of current branch state

### Phase 1: Preparation (1-2 days before)

```bash
# 1. Document current state
git ls-remote --heads origin > current_branches_backup.txt

# 2. Check open PRs
gh pr list --state open --base develop
gh pr list --state open --base develop-2.0

# 3. Notify team with migration instructions
```

### Phase 2: Implementation (During maintenance window)

```bash
# CRITICAL: These steps require GitHub admin privileges

# Step 1: Remove branch protection temporarily
# (Must be done via GitHub web interface or API)

# Step 2: Rename develop to develop-1.0
git checkout develop
git branch -m develop develop-1.0
git push origin :develop
git push origin develop-1.0

# Step 3: Rename develop-2.0 to develop
git checkout develop-2.0
git branch -m develop-2.0 develop
git push origin :develop-2.0
git push origin develop

# Step 4: Re-enable branch protection on new branches
# (Via GitHub web interface)

# Step 5: Update default branch if needed
# (Via GitHub repository settings)
```

### Phase 3: Update Open PRs

```bash
# For each open PR targeting old branches:
gh pr edit <PR_NUMBER> --base develop  # For PRs that were targeting develop-2.0
gh pr edit <PR_NUMBER> --base develop-1.0  # For PRs that were targeting develop (if any)
```

### Phase 4: Developer Migration Guide

**Email/Slack message to team:**

```
🚨 BRANCH RENAMING COMPLETE - ACTION REQUIRED

We have renamed our development branches:
- develop → develop-1.0 (1.x maintenance)  
- develop-2.0 → develop (current development)

REQUIRED: Update your local repositories:

git fetch origin
git remote prune origin
git branch -d develop develop-2.0  # Delete old local branches
git checkout -b develop origin/develop  # Track new develop
git checkout -b develop-1.0 origin/develop-1.0  # Track renamed 1.x branch

If you have open PRs, please verify their target branch is correct.
```

### Phase 5: Verification

```bash
# Verify branch structure
git ls-remote --heads origin | grep -E "(develop|main)"

# Verify CI/CD pipelines are working
# Check Azure DevOps for successful builds

# Verify protected branch settings
# Check GitHub repository settings
```

**Total Implementation Time:** 1-2 weeks with coordination

---

## Rollback Plan (Option B Only)

If issues arise during Option B implementation:

```bash
# Emergency rollback commands
git checkout develop-1.0
git branch -m develop-1.0 develop
git push origin :develop-1.0
git push origin develop

git checkout develop  
git branch -m develop develop-2.0
git push origin :develop
git push origin develop-2.0

# Re-enable original branch protection rules
```

---

## Testing Checklist

### Option A Testing
- [ ] Build status badge displays correctly
- [ ] README.md renders properly on GitHub
- [ ] No broken links in documentation
- [ ] Team can follow new contributing guidelines

### Option B Testing  
- [ ] All CI/CD pipelines trigger correctly
- [ ] Protected branch rules are active
- [ ] Default branch is set correctly
- [ ] No broken references in repository settings
- [ ] Developer workflows function normally

---

## Emergency Contacts

**If issues arise during implementation:**
- Repository Admin: [Contact Info]
- DevOps Team: [Contact Info]  
- Team Lead: [Contact Info]

**Escalation Timeline:**
- 0-15 minutes: Attempt immediate fix
- 15-30 minutes: Contact repository admin
- 30+ minutes: Consider rollback procedure
# Branch Renaming Investigation and Implementation Plan

**Issue:** #956 - Fix README OR Rename Branches  
**Date:** 2025-01-27  
**Status:** Investigation Complete - Awaiting Team Decision  

## Executive Summary

The repository currently has an inconsistency where the README.md instructs contributors to submit PRs against the `develop` branch, but the active development appears to be happening on `develop-2.0`. This document provides a comprehensive analysis and implementation plan for resolving this issue.

## Current State Analysis

### Branch Structure
- **`main`** (protected) - Stable release branch
- **`develop`** (protected) - Legacy development branch (SHA: fa542d68ba477ef3d6049dcaca3f1d6013d81ccb)
- **`develop-2.0`** (protected) - Current 2.x development branch (SHA: 355e848a67262b8e858a8c5f94c9c2525d854e71)

### Files Currently Referencing "develop" Branch

1. **README.md**
   - Line 6: Build status badge: `branchName=develop`
   - Line 94: Contributing section: "submit PRs with changes against the `develop` branch"

2. **build/azure-pipelines.yml**
   - Lines 23-24: Trigger patterns include both `develop*` and `develop-2.0*`
   - ✅ **Already supports both patterns**

3. **Documentation Files**
   - Various README files in subdirectories contain general development references
   - No hardcoded branch references found in critical configuration files

## Proposed Solutions

### Option A: Update Documentation Only (RECOMMENDED - Minimal Risk)

**Scope:** Low impact, immediate resolution  
**Timeline:** 1-2 hours  
**Risk Level:** Minimal  

#### Changes Required:
1. **README.md Updates**
   ```diff
   - [![Build Status](https://dev.azure.com/firely/firely-net-sdk/_apis/build/status%2FFirelyTeam.firely-cql-sdk?repoName=FirelyTeam%2Ffirely-cql-sdk&branchName=develop)]
   + [![Build Status](https://dev.azure.com/firely/firely-net-sdk/_apis/build/status%2FFirelyTeam.firely-cql-sdk?repoName=FirelyTeam%2Ffirely-cql-sdk&branchName=develop-2.0)]
   
   - Please submit PRs with changes against the `develop` branch.
   + Please submit PRs with changes against the `develop-2.0` branch.
   ```

2. **Verification Steps**
   - Confirm build badge functionality with new branch
   - Review all documentation for consistency
   - Test contributor workflow

#### Pros:
- ✅ Immediate resolution with minimal risk
- ✅ No impact on existing workflows or PRs
- ✅ No coordination required with external systems
- ✅ No disruption to developer environments

#### Cons:
- ❌ Branch naming remains potentially confusing (develop-2.0 vs develop)
- ❌ Doesn't follow traditional Git Flow naming conventions

### Option B: Branch Renaming (Complex Implementation)

**Scope:** High impact, comprehensive change  
**Timeline:** 1-2 weeks with team coordination  
**Risk Level:** High  

#### Phase 1: Preparation and Analysis

1. **Pre-Implementation Audit**
   - [ ] Identify all open PRs targeting `develop` and `develop-2.0`
   - [ ] Catalog external systems referencing these branches
   - [ ] Survey development team for local environment impacts
   - [ ] Document all dependent repositories/submodules

2. **External Dependencies Assessment**
   - [ ] Azure DevOps build definitions
   - [ ] External CI/CD systems
   - [ ] Documentation sites and wikis
   - [ ] Developer tools and IDE configurations

#### Phase 2: Implementation Steps

1. **Branch Renaming Process**
   ```bash
   # Step 1: Rename develop to develop-1.0
   git branch -m develop develop-1.0
   git push origin :develop
   git push origin develop-1.0
   
   # Step 2: Rename develop-2.0 to develop  
   git branch -m develop-2.0 develop
   git push origin :develop-2.0
   git push origin develop
   
   # Step 3: Update default branch settings
   # (Requires GitHub admin access)
   ```

2. **Protected Branch Rules Transfer**
   - [ ] Remove protection from old branch names
   - [ ] Apply protection rules to new branch names
   - [ ] Update merge policies and restrictions

3. **Configuration Updates**
   ```diff
   # README.md - Build badge
   - branchName=develop
   + branchName=develop
   # (No change needed after rename)
   
   # README.md - Contributing
   - submit PRs with changes against the `develop` branch
   + submit PRs with changes against the `develop` branch  
   # (No change needed after rename)
   ```

#### Phase 3: Impact Management

1. **Existing Pull Request Handling**
   - [ ] Identify all open PRs targeting `develop`
   - [ ] Identify all open PRs targeting `develop-2.0`
   - [ ] Plan retargeting strategy (likely to new `develop`)
   - [ ] Communicate with PR authors

2. **Developer Environment Updates**
   - [ ] Provide migration guide for local repositories
   - [ ] Update team documentation and onboarding materials
   - [ ] Schedule team communication about changes

3. **External System Updates**
   - [ ] Update any hardcoded branch references in CI/CD
   - [ ] Update documentation sites
   - [ ] Notify dependent project maintainers

#### Git Commands for Developer Migration
```bash
# For developers with local clones
git fetch origin
git branch -d develop develop-2.0  # Delete old local branches
git checkout -b develop origin/develop  # Track new develop
git checkout -b develop-1.0 origin/develop-1.0  # Track renamed branch
```

## Risk Assessment

### Option A Risks (Low)
- **Documentation Inconsistency**: Minimal risk of continued confusion
- **External References**: Low risk - most external references are already generic

### Option B Risks (High)
- **Service Disruption**: Potential CI/CD pipeline failures during transition
- **Developer Disruption**: Team members need to update local environments
- **PR Management**: Risk of losing work or causing confusion with open PRs
- **External Dependencies**: Risk of breaking dependent systems or documentation

## Implementation Recommendations

### Recommended Approach: Option A + Future Planning

1. **Immediate Action (Option A)**
   - Update README.md to reference `develop-2.0`
   - Update build status badge
   - Communicate change to development team

2. **Future Consideration (Option B - If Desired)**
   - Plan branch renaming for next major release cycle
   - Include in release planning discussions
   - Coordinate with broader team for minimal disruption

### Timeline Recommendations

**Option A Implementation:**
- Day 1: Update documentation
- Day 1: Test and verify changes
- Day 2: Communicate to team

**Option B Implementation (if chosen):**
- Week 1: Team planning and external dependency analysis
- Week 2: Implementation during low-activity period
- Week 3: Developer migration support and issue resolution

## Decision Matrix

| Criteria | Option A (Update Docs) | Option B (Rename Branches) |
|----------|------------------------|----------------------------|
| **Implementation Time** | ⭐⭐⭐⭐⭐ | ⭐⭐ |
| **Risk Level** | ⭐⭐⭐⭐⭐ | ⭐⭐ |
| **Team Disruption** | ⭐⭐⭐⭐⭐ | ⭐ |
| **Long-term Clarity** | ⭐⭐⭐ | ⭐⭐⭐⭐⭐ |
| **Git Flow Compliance** | ⭐⭐ | ⭐⭐⭐⭐⭐ |

## Conclusion

**Recommendation: Implement Option A immediately** to resolve the contributor confusion with minimal risk and disruption. Option B can be considered for future implementation during a planned maintenance window or major release cycle.

The current CI/CD infrastructure already supports both branch patterns, making either approach technically feasible. The choice should be based on team priorities regarding immediate resolution versus long-term branch naming consistency.

## Next Steps

1. **Team Decision Required**: Choose between Option A (immediate fix) or Option B (comprehensive renaming)
2. **Resource Allocation**: Assign team member(s) to implement chosen solution
3. **Communication Plan**: Prepare developer communication for chosen approach
4. **Implementation Scheduling**: Schedule implementation during appropriate time window

---

**Prepared by:** GitHub Copilot  
**Review Required by:** FirelyTeam Development Team  
**Implementation:** Pending team decision
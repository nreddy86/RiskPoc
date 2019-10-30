using ARUP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ARUP.Context
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            base.Seed(context);
            var guid = new Guid();
            DateTime dt = DateTime.Now;

            #region Uesrs
            Users users = new Users
            {
                UserId = guid,
                Username = "Admin",
                Password = "Value*12",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt
            };
            context.Users.Add(users);
            context.SaveChanges();
            #endregion

            #region ProjectStageList
            List<ProjectStageList> projectStages = new List<ProjectStageList>();
            ProjectStageList projectStageList = new ProjectStageList
            {
                Name = "Approval In Principle",
                Description = "Approval In Principle",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            projectStages.Add(projectStageList);

            projectStageList = new ProjectStageList
            {
                Name = "As - Built",
                Description = "As - Built",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            projectStages.Add(projectStageList);

            projectStageList = new ProjectStageList
            {
                Name = "Construction",
                Description = "Construction",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            projectStages.Add(projectStageList);

            projectStageList = new ProjectStageList
            {
                Name = "Demolition",
                Description = "Demolition",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            projectStages.Add(projectStageList);

            projectStageList = new ProjectStageList
            {
                Name = "Detailed Design",
                Description = "Detailed Design",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            projectStages.Add(projectStageList);

            projectStageList = new ProjectStageList
            {
                Name = "Feasibility / Masterplanning",
                Description = "Feasibility / Masterplanning",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            projectStages.Add(projectStageList);

            projectStageList = new ProjectStageList
            {
                Name = "Operation / Maintenance",
                Description = "Operation / Maintenance",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            projectStages.Add(projectStageList);

            projectStageList = new ProjectStageList
            {
                Name = "Outline Design",
                Description = "Outline Design",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            projectStages.Add(projectStageList);

            projectStageList = new ProjectStageList
            {
                Name = "Rail - Grip 3 - Option Selection",
                Description = "Rail - Grip 3 - Option Selection",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            projectStages.Add(projectStageList);

            projectStageList = new ProjectStageList
            {
                Name = "Rail - Grip 4 - Approval in Principle",
                Description = "Rail - Grip 4 - Approval in Principle",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            projectStages.Add(projectStageList);

            projectStageList = new ProjectStageList
            {
                Name = "Rail - Grip 5 - Detail Design / AFC",
                Description = "Rail - Grip 5 - Detail Design / AFC",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            projectStages.Add(projectStageList);

            projectStageList = new ProjectStageList
            {
                Name = "Rail - Grip 6 - Construction on Site",
                Description = "Rail - Grip 6 - Construction on Site",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            projectStages.Add(projectStageList);

            projectStageList = new ProjectStageList
            {
                Name = "Rail - Grip 7 - As - Built Records",
                Description = "Rail - Grip 7 - As - Built Records",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            projectStages.Add(projectStageList);
            context.ProjectStageList.AddRange(projectStages);
            #endregion

            #region Lifecycles
            List<Lifecycles> lifecyclesList = new List<Lifecycles>();
            Lifecycles lifecycles = new Lifecycles
            {
                Name = "Construction",
                Code = "C",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            lifecyclesList.Add(lifecycles);

            lifecycles = new Lifecycles
            {
                Name = "Maintenance",
                Code = "M",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            lifecyclesList.Add(lifecycles);

            lifecycles = new Lifecycles
            {
                Name = "Operation",
                Code = "O",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            lifecyclesList.Add(lifecycles);

            lifecycles = new Lifecycles
            {
                Name = "Demolition",
                Code = "D",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            lifecyclesList.Add(lifecycles);
            context.Lifecycles.AddRange(lifecyclesList);
            #endregion

            #region RiskScores
            List<RiskScores> riskScoreList = new List<RiskScores>();
            RiskScores riskScores = new RiskScores
            {
                Name="Low",
                Code ="L",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            riskScoreList.Add(riskScores);

            riskScores = new RiskScores
            {
                Name = "Medium",
                Code = "M",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            riskScoreList.Add(riskScores);

            riskScores = new RiskScores
            {
                Name = "High",
                Code = "H",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            riskScoreList.Add(riskScores);
            context.RiskScores.AddRange(riskScoreList);
            #endregion

            #region IssuePurposes
            List<IssuePurposes> issuePuroseList = new List<IssuePurposes>();
            IssuePurposes issuePurposes = new IssuePurposes
            {
                Name = "DRAFT",
                Description = "DRAFT",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            issuePuroseList.Add(issuePurposes);

            issuePurposes = new IssuePurposes
            {
                Name = "INFORMATION",
                Description = "INFORMATION",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            issuePuroseList.Add(issuePurposes);

            issuePurposes = new IssuePurposes
            {
                Name = "ACCEPTANCE",
                Description = "ACCEPTANCE",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            issuePuroseList.Add(issuePurposes);

            issuePurposes = new IssuePurposes
            {
                Name = "APPROVAL",
                Description = "APPROVAL",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            issuePuroseList.Add(issuePurposes);

            issuePurposes = new IssuePurposes
            {
                Name = "H&S FILE",
                Description = "H&S FILE",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            issuePuroseList.Add(issuePurposes);

            issuePurposes = new IssuePurposes
            {
                Name = "RESIDUAL RISKS",
                Description = "RESIDUAL RISKS",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            issuePuroseList.Add(issuePurposes);
            context.IssuePurposes.AddRange(issuePuroseList);
            #endregion

            #region Severities
            List<Severities> severitiesList = new List<Severities>();
            Severities severities = new Severities
            {
                Name = "Fatality",
                Code = "5",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            severitiesList.Add(severities);

            severities = new Severities
            {
                Name = "Major Injury",
                Code = "4",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            severitiesList.Add(severities);

            severities = new Severities
            {
                Name = "Significant Injury",
                Code = "3",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            severitiesList.Add(severities);

            severities = new Severities
            {
                Name = "Lost-Time Injury",
                Code = "2",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            severitiesList.Add(severities);

            severities = new Severities
            {
                Name = "First Aid Case",
                Code = "1",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            severitiesList.Add(severities);
            context.Severities.AddRange(severitiesList);
            #endregion

            #region Likelihoods
            List<Likelihoods> likelihoodsList = new List<Likelihoods>();
            Likelihoods likelihoods = new Likelihoods
            {
                Name = "Absolute Certainty",
                Code = "5",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            likelihoodsList.Add(likelihoods);

            likelihoods = new Likelihoods
            {
                Name = "Very Likely",
                Code = "4",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            likelihoodsList.Add(likelihoods);

            likelihoods = new Likelihoods
            {
                Name = "Likely",
                Code = "3",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            likelihoodsList.Add(likelihoods);

            likelihoods = new Likelihoods
            {
                Name = "Unlikely",
                Code = "2",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            likelihoodsList.Add(likelihoods);

            likelihoods = new Likelihoods
            {
                Name = "Remote",
                Code = "1",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            likelihoodsList.Add(likelihoods);
            context.Likelihoods.AddRange(likelihoodsList);
            #endregion

            #region DisciplineList
            List<DisciplineList> disciplineLists = new List<DisciplineList>();
            DisciplineList discipline = new DisciplineList
            {
                Name = "General",
                Code = "GEN",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            disciplineLists.Add(discipline);

            discipline = new DisciplineList
            {
                Name = "Multi-Disciplinary",
                Code = "MULTI",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            disciplineLists.Add(discipline);

            discipline = new DisciplineList
            {
                Name = "Other (Specify)",
                Code = "OTHER",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            disciplineLists.Add(discipline);

            discipline = new DisciplineList
            {
                Name = "Acoustics",
                Code = "ACOU",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            disciplineLists.Add(discipline);

            discipline = new DisciplineList
            {
                Name = "Architectural",
                Code = "ARCH",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            disciplineLists.Add(discipline);

            discipline = new DisciplineList
            {
                Name = "Civil",
                Code = "CIV",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            disciplineLists.Add(discipline);

            discipline = new DisciplineList
            {
                Name = "Electrical",
                Code = "ELEC",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            disciplineLists.Add(discipline);

            discipline = new DisciplineList
            {
                Name = "Facilities Management",
                Code = "FACM",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            disciplineLists.Add(discipline);

            discipline = new DisciplineList
            {
                Name = "Façades",
                Code = "FCDE",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            disciplineLists.Add(discipline);

            discipline = new DisciplineList
            {
                Name = "Finance",
                Code = "FIN",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            disciplineLists.Add(discipline);

            discipline = new DisciplineList
            {
                Name = "Fire",
                Code = "FIRE",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            disciplineLists.Add(discipline);

            discipline = new DisciplineList
            {
                Name = "Mechanical & Electrical",
                Code = "M&E",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            disciplineLists.Add(discipline);

            discipline = new DisciplineList
            {
                Name = "Mechanical",
                Code = "MECH",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            disciplineLists.Add(discipline);

            discipline = new DisciplineList
            {
                Name = "Project Management",
                Code = "PM",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            disciplineLists.Add(discipline);

            discipline = new DisciplineList
            {
                Name = "Rail - E&P (3rd Rail)",
                Code = "R-3R",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            disciplineLists.Add(discipline);

            discipline = new DisciplineList
            {
                Name = "Rail - E&P (OHLE)",
                Code = "R-OLE",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            disciplineLists.Add(discipline);

            discipline = new DisciplineList
            {
                Name = "Rail - E&P (Point Heating)",
                Code = "R-PH",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            disciplineLists.Add(discipline);

            discipline = new DisciplineList
            {
                Name = "Rail - E&P (Power Supply)",
                Code = "R-PS",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            disciplineLists.Add(discipline);

            discipline = new DisciplineList
            {
                Name = "Rail - P-Way",
                Code = "R-PW",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            disciplineLists.Add(discipline);

            discipline = new DisciplineList
            {
                Name = "Structural",
                Code = "STR",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            disciplineLists.Add(discipline);
            context.DisciplineList.AddRange(disciplineLists);
            #endregion DisciplineList

            #region RiskStatus
            List<RiskStatus> riskStatusList = new List<RiskStatus>();
            RiskStatus riskStatus = new RiskStatus
            {
                Name = "ACTIVE",
                Description = "If the risk is not closed out.",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            riskStatusList.Add(riskStatus);

            riskStatus = new RiskStatus
            {
                Name = "RESOLVED",
                Description = "If the risk has been delt with and is closed out fully.",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            riskStatusList.Add(riskStatus);

            riskStatus = new RiskStatus
            {
                Name = "CONTINUED",
                Description = "If the risk is resolved per se, but is carried over into another entry for action.",
                CreateDate = dt,
                CreatedBy = guid,
                UpdateDate = dt,
                UpdatedBy = guid
            };
            riskStatusList.Add(riskStatus);
            context.RiskStatus.AddRange(riskStatusList);
            #endregion

            context.SaveChanges();
        }
    }
}
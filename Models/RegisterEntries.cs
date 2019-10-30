using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARUP.Models
{
    public class RegisterEntries
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid RegisterEntryId { get; set; }

        public Guid ProjectId { get; set; }

        public string DiscriptionOfHazard { get; set; }

        public Guid RiskStatusId { get; set; }

        public Guid DisciplineId { get; set; }

        public string RiskNumber { get; set; }

        public string Revision { get; set; }

        public Guid LifecycleId { get; set; }

        public string HAndSRisk { get; set; }

        public string EnvironmentalRisk { get; set; }

        public string ProgrammeRisk { get; set; }

        public string OtherRisk { get; set; }

        public Guid LikelihoodIdUm { get; set; }

        public Guid SeverityIdUm { get; set; }

        public Guid RiskScoreIdUm { get; set; }

        public string RelevantDocumentation { get; set; }

        public string OwnerOfRisk { get; set; }

        public string MitigationOrAction { get; set; }

        public Guid LikelihoodIdM { get; set; }

        public Guid SeverityIdM { get; set; }

        public Guid RiskScoreIdM { get; set; }

        public string FurtherActionRequired { get; set; }

        public string ContinuationRiskReference { get; set; }

        public string IdentifiedBy { get; set; }

        public DateTime CreateDate { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime UpdateDate { get; set; }

        public Guid UpdatedBy { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ARUP.Models
{
    public class Projects
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ProjectId { get; set; }

        [Required]
        public string ProjectNumber { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string LeadOffice { get; set; }

        [Required]
        public string Client { get; set; }

        [Required]
        [Column("Stage")]
        public Guid ProjectStageId { get; set; }

        public DateTime CreateDate { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime UpdateDate { get; set; }

        public Guid UpdatedBy { get; set; }
    }
}
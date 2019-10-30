﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARUP.Models
{
    public class RiskScores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid RiskScoreId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Code { get; set; }

        public DateTime CreateDate { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime UpdateDate { get; set; }

        public Guid UpdatedBy { get; set; }
    }
}
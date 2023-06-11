﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SVCW.Models
{
    public partial class ActivityResult
    {
        [Key]
        [Column("resultId")]
        [StringLength(10)]
        public string ResultId { get; set; }
        [Required]
        [Column("title")]
        public string Title { get; set; }
        [Required]
        [Column("desciption")]
        public string Desciption { get; set; }
        [Column("datetime", TypeName = "datetime")]
        public DateTime Datetime { get; set; }
        [Required]
        [Column("activityId")]
        [StringLength(10)]
        public string ActivityId { get; set; }

        [ForeignKey("ActivityId")]
        [InverseProperty("ActivityResult")]
        public virtual Activity Activity { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SVCW.Models
{
    public partial class Fanpage
    {
        public Fanpage()
        {
            Activity = new HashSet<Activity>();
        }

        [Key]
        [Column("fanpageId")]
        [StringLength(10)]
        public string FanpageId { get; set; }
        [Required]
        [Column("fanpageName")]
        public string FanpageName { get; set; }
        [Required]
        [Column("avatar")]
        public string Avatar { get; set; }
        [Required]
        [Column("coverImage")]
        public string CoverImage { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("createAt", TypeName = "datetime")]
        public DateTime CreateAt { get; set; }
        [Column("MST")]
        [StringLength(10)]
        public string Mst { get; set; }
        [Required]
        [Column("email")]
        public string Email { get; set; }
        [Required]
        [Column("phone")]
        [StringLength(15)]
        public string Phone { get; set; }
        [Required]
        [Column("status")]
        [StringLength(50)]
        public string Status { get; set; }

        [ForeignKey("FanpageId")]
        [InverseProperty("Fanpage")]
        public virtual User FanpageNavigation { get; set; }
        [InverseProperty("Fanpage")]
        public virtual ICollection<Activity> Activity { get; set; }
    }
}
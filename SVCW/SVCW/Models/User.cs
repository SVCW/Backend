﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SVCW.Models
{
    [Index("Email", Name = "IX_User_email", IsUnique = true)]
    [Index("Phone", Name = "IX_User_phone", IsUnique = true)]
    [Index("Username", Name = "IX_User_username", IsUnique = true)]
    public partial class User
    {
        public User()
        {
            AchivementUser = new HashSet<AchivementUser>();
            Activity = new HashSet<Activity>();
            BankAccount = new HashSet<BankAccount>();
            Comment = new HashSet<Comment>();
            Like = new HashSet<Like>();
            Notification = new HashSet<Notification>();
            Report = new HashSet<Report>();
            VoteUser = new HashSet<Vote>();
            VoteUserVote = new HashSet<Vote>();
        }

        [Key]
        [Column("userId")]
        [StringLength(10)]
        public string UserId { get; set; }
        [Required]
        [Column("email")]
        [StringLength(100)]
        public string Email { get; set; }
        [Column("username")]
        [StringLength(100)]
        public string Username { get; set; }
        [Column("password")]
        [StringLength(100)]
        public string Password { get; set; }
        [Required]
        [Column("fullName")]
        public string FullName { get; set; }
        [Required]
        [Column("phone")]
        [StringLength(15)]
        public string Phone { get; set; }
        [Column("gender")]
        public bool Gender { get; set; }
        [Required]
        [Column("image")]
        public string Image { get; set; }
        [Column("dateOfBirth", TypeName = "date")]
        public DateTime DateOfBirth { get; set; }
        [Column("createAt", TypeName = "datetime")]
        public DateTime CreateAt { get; set; }
        [Column("numberLike")]
        public int? NumberLike { get; set; }
        [Column("numberDislike")]
        public int? NumberDislike { get; set; }
        [Column("numberActivityJoin")]
        public int? NumberActivityJoin { get; set; }
        [Column("numberActivitySuccess")]
        public int? NumberActivitySuccess { get; set; }
        [Required]
        [Column("status")]
        [StringLength(50)]
        public string Status { get; set; }
        [Required]
        [Column("roleId")]
        [StringLength(10)]
        public string RoleId { get; set; }

        [ForeignKey("RoleId")]
        [InverseProperty("User")]
        public virtual Role Role { get; set; }
        [InverseProperty("FanpageNavigation")]
        public virtual Fanpage Fanpage { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<AchivementUser> AchivementUser { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Activity> Activity { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<BankAccount> BankAccount { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Comment> Comment { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Like> Like { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Notification> Notification { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Report> Report { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Vote> VoteUser { get; set; }
        [InverseProperty("UserVote")]
        public virtual ICollection<Vote> VoteUserVote { get; set; }
    }
}
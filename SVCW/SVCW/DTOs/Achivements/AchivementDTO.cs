using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SVCW.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
<<<<<<< Updated upstream
=======

using SVCW.Services;
using SVCW.Interfaces;
>>>>>>> Stashed changes

namespace SVCW.DTOs.Achivements
{
    public class AchivementDTO
    {
        [Key]
        [Column("achivementId")]
        [StringLength(10)]
        public string AchivementId { get; set; }
        [Column("achivementLogo")]
        public string AchivementLogo { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("createAt", TypeName = "datetime")]
        public DateTime CreateAt { get; set; }
        [Column("status")]
        public bool Status { get; set; }

        /*[InverseProperty("Achivement")]
        public virtual ICollection<AchivementUser> AchivementUser { get; set; }*/
    }
}

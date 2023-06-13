using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SVCW.DTOs.ProcessTypes
{
    public class ProcessTypeDTO
    {
        [Key]
        [Column("processTypeId")]
        [StringLength(10)]
        public string ProcessTypeId { get; set; }
        [Required]
        [Column("processTypeName")]
        public string ProcessTypeName { get; set; }
        [Required]
        [Column("description")]
        public string Description { get; set; }
    }
}

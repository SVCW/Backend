using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SVCW.DTOs.ActivityResults
{
    public class ActivityResultCreateDTO
    {
        public string Title { get; set; }
        public string Desciption { get; set; }
        public string ActivityId { get; set; }
    }
}

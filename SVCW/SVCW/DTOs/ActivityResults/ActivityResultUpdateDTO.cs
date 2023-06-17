using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SVCW.DTOs.ActivityResults
{
    public class ActivityResultUpdateDTO
    {
        public string ResultId { get; set; }
        public string Title { get; set; }
        public string Desciption { get; set; }
    }
}

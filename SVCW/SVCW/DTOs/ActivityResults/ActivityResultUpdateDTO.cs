using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SVCW.DTOs.ActivityResults
{
    public class ActivityResultUpdateDTO
    {
        public string ResultId { get; set; }
        [RegularExpression("@\"\\b(|địt|đụ|lồn|cặc|chém|loz|Đm|Duma|Nứng|Ngáo...)\\b")]
        public string Title { get; set; }
        [RegularExpression("@\"\\b(|địt|đụ|lồn|cặc|chém|loz|Đm|Duma|Nứng|Ngáo...)\\b")]
        public string Desciption { get; set; }
    }
}

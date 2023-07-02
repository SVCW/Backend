using System.ComponentModel.DataAnnotations;

namespace SVCW.DTOs.Fanpage
{
    public class FanpageUpdateDTO
    {
        public string FanpageId { get; set; }
        [RegularExpression("@\"\\b(|địt|đụ|lồn|cặc|chém|loz|Đm|Duma|Nứng|Ngáo...)\\b")]
        public string FanpageName { get; set; }
        public string Avatar { get; set; }
        public string CoverImage { get; set; }
        [RegularExpression("@\"\\b(|địt|đụ|lồn|cặc|chém|loz|Đm|Duma|Nứng|Ngáo...)\\b")]
        public string Description { get; set; }
        public string Mst { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }
    }
}

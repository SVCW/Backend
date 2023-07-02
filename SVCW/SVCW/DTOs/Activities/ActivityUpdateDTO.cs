using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SVCW.DTOs.Activities
{
    public class ActivityUpdateDTO
    {
        public string ActivityId { get; set; }
        [RegularExpression("@\"\\b(|địt|đụ|lồn|cặc|chém|loz|Đm|Duma|Nứng|Ngáo...)\\b")]
        public string Title { get; set; }
        [RegularExpression("@\"\\b(|địt|đụ|lồn|cặc|chém|loz|Đm|Duma|Nứng|Ngáo...)\\b")]
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Location { get; set; }        
        public decimal? TargetDonation { get; set; }
    }
}

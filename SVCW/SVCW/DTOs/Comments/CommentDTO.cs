using System.ComponentModel.DataAnnotations;

namespace SVCW.DTOs.Comments
{
	public class CommentDTO
	{
        public string UserID { get; set; }
        public string ActivityId { get; set; }
        [RegularExpression("@\"\\b(|địt|đụ|lồn|cặc|chém|loz|Đm|Duma|Nứng|Ngáo...)\\b")]
        public string CommentContent { get; set; }
    }
}


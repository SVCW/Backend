using System;
using System.ComponentModel.DataAnnotations;

namespace SVCW.DTOs.Comments
{
    public class ReplyCommentDTO
    {
        public string UserId { get; set; }
        public string ActivityiId { get; set; }
        [RegularExpression("@\"\\b(|địt|đụ|lồn|cặc|chém|loz|Đm|Duma|Nứng|Ngáo...)\\b")]
        public string? CommentContent { get; set; }
        public bool? status { get; set; }
        public string? CommentIdReply { get; set; }
    }
}


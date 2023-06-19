using System;
namespace SVCW.DTOs.Comments
{
    public class ReplyCommentDTO
    {
        public string UserId { get; set; }
        public string ActivityiId { get; set; }
        public string? CommentContent { get; set; }
        public bool? status { get; set; }
        public string? CommentIdReply { get; set; }
    }
}


using System;
using System.ComponentModel.DataAnnotations;

namespace SVCW.DTOs.Reports
{
	public class ReportDTO
	{
		public string? ReportId { get; set; }
        [RegularExpression("@\"\\b(|địt|đụ|lồn|cặc|chém|loz|Đm|Duma|Nứng|Ngáo...)\\b")]
        public string Title { get; set; }
        [RegularExpression("@\"\\b(|địt|đụ|lồn|cặc|chém|loz|Đm|Duma|Nứng|Ngáo...)\\b")]
        public string Reason { get; set; }
		public string ReportTypeId { get; set; }
        [RegularExpression("@\"\\b(|địt|đụ|lồn|cặc|chém|loz|Đm|Duma|Nứng|Ngáo...)\\b")]
        public string Description { get; set; }
		public bool Status { get; set; }
		public string UserId { get; set; }
	}
}


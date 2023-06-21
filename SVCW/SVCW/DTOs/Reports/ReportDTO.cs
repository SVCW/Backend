using System;
namespace SVCW.DTOs.Reports
{
	public class ReportDTO
	{
		public string? ReportId { get; set; }
		public string Title { get; set; }
		public string Reason { get; set; }
		public string ReportTypeId { get; set; }
		public string Description { get; set; }
		public bool Status { get; set; }
		public string UserId { get; set; }
	}
}


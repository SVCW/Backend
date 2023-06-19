using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SVCW.DTOs.Activities
{
    public class ActivityCreateDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Location { get; set; }
        public decimal? TargetDonation { get; set; }
        public string UserId { get; set; }
        public bool isFanpageAvtivity { get; set; }
    }
}

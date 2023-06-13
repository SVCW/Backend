using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SVCW.DTOs.Donations
{
    public class DonationDTO
    {
        public string DonationId { get; set; }
        public string Title { get; set; }
        public decimal Amount { get; set; }
        public DateTime Datetime { get; set; }        
        public string Email { get; set; }        
        public string Phone { get; set; }       
        public string Name { get; set; }
        public bool? IsAnonymous { get; set; }        
        public string Status { get; set; }
        public string ActivityId { get; set; }
    }
}

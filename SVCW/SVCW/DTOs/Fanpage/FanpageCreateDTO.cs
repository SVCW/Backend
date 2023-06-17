using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SVCW.DTOs.Fanpage
{
    public class FanpageCreateDTO
    {
        public string FanpageName { get; set; }
        public string Avatar { get; set; }
        public string CoverImage { get; set; }
        public string Description { get; set; }
        public string Mst { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string userId { get; set; }
    }
}

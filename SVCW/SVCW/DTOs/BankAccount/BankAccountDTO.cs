using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SVCW.DTOs.BankAccount
{
    public class BankAccountDTO
    {
        public string BankAccountName { get; set; }
        public string BankNumber { get; set; }
        public string BankName { get; set; }
        [RegularExpression("@\"\\b(|địt|đụ|lồn|cặc|chém|loz|Đm|Duma|Nứng|Ngáo...)\\b")]
        public string Description { get; set; }
        public bool Status { get; set; }
        public string UserId { get; set; }
    }
}

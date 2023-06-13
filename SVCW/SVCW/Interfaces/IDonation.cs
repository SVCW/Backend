using SVCW.Models;

namespace SVCW.Interfaces
{
    public interface IDonation
    {
        Task<List<Donation>> GetDonation();
        Task<List<Donation>> GetDonationsActivity(string id);
    }
}

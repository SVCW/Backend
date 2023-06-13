using Microsoft.EntityFrameworkCore;
using SVCW.Interfaces;
using SVCW.Models;

namespace SVCW.Services
{
    public class DonationService : IDonation
    {
        protected readonly SVCWContext context;
        public DonationService(SVCWContext context)
        {
            this.context = context;
        }

        public async Task<List<Donation>> GetDonation()
        {
            try
            {
                var check = await this.context.Donation.ToListAsync();
                if(check !=null)
                {
                    return check;
                }return null;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Donation>> GetDonationsActivity(string id)
        {
            try
            {
                var check = await this.context.Donation.Where(x=>x.ActivityId.Equals(id)).ToListAsync();
                if (check != null)
                {
                    return check;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

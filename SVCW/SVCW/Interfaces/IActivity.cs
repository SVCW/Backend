using SVCW.DTOs.Activities;
using SVCW.Models;

namespace SVCW.Interfaces
{
    public interface IActivity
    {
        Task<Activity> createActivity(ActivityCreateDTO dto);
        Task<Activity> updateActivity(ActivityUpdateDTO dto);
        Task<Activity> getById(string id);
        Task<List<Activity>> getAll();
        Task<List<Activity>> getByTitle(string title);
        Task<List<Activity>> getForUser();
        Task<Activity> delete(string id);
    }
}

using SVCW.DTOs.Likes;

namespace SVCW.Interfaces
{
	public interface ILike
	{
		Task<List<LikeDTO>> GetActivitysLikes();
		Task<bool> UpdateLike(LikeDTO upLike);
		Task<bool> DeleteLikeByIds(string userId, string activityId);
		Task<bool> InsertLike(List<LikeDTO> listLikes);
	}
}


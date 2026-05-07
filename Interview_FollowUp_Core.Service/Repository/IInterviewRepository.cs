using Interview_FollowUp_Core.Service.DataAccess;

namespace Interview_FollowUp_Core.Service.Repository
{
    public interface IInterviewRepository
    {
        Task<IEnumerable<Interview>> GetAllAsync();
    }
}

using Interview_FollowUp_Core.Service.DataAccess;
using Interview_FollowUp_Core.Service.DBContext;
using Microsoft.EntityFrameworkCore;

namespace Interview_FollowUp_Core.Service.Repository
{
    public class InterviewRepository : IInterviewRepository
    {
        private readonly ApplicationDbContext _context;

        public InterviewRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Interview>> GetAllAsync()
        {
            return await _context.Interviews.ToListAsync();
        }
    }
}

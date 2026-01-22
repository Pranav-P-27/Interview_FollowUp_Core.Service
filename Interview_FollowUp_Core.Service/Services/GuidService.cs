using Interview_FollowUp_Core.Service.Interface;

namespace Interview_FollowUp_Core.Service.Services
{
    public class GuidService:IGuidService 
    {
        private readonly Guid _guid;

        public GuidService()
        {
            _guid = Guid.NewGuid();
        }
        public Guid GetGuid()
        {
            return _guid;
        }
    }
}

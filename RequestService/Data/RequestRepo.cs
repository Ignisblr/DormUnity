using RequestService.Models;

namespace RequestService.Data
{
    public class RequestRepo : IRequestRepo
    {
        private readonly AppDbContext _dbContext;

        public RequestRepo(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public UserRequest GetRequest(int id)
        {
            return _dbContext.Requests.FirstOrDefault(request => request.Id == id);
        }

        public ICollection<UserRequest> GetRequests()
        {
            return _dbContext.Requests.ToList<UserRequest>();
        }

        public void MakeRequest(UserRequest request)
        {
            _dbContext.Requests.Add(request);
        }

        public void RemoveRequest(UserRequest request)
        {
            _dbContext.Requests.Remove(request);
        }

        public bool SaveChanges()
        {
            return (_dbContext.SaveChanges() >= 0);
        }
    }
}
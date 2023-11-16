using RequestService.Models;

namespace RequestService.Data
{
    public interface IRequestRepo
    {
        ICollection<UserRequest> GetRequests();

        UserRequest GetRequest(int id);

        void RemoveRequest(UserRequest userRequest);

        void MakeRequest(UserRequest userRequest);

        bool SaveChanges();
    }
}
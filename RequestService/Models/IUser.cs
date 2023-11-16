namespace RequestService.Models
{
    public interface IUser
    {
        ICollection<object> GetData();
    }
}
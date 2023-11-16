using RequestService.Models;

namespace RequestService.DTO
{
    public class UserRequestReadDTO
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public string Description { get; set; }

        public IUser Autor { get; set; }

        public IUser Executor { get; set; }

        public Dictionary<DateTime, DateTime> Deadline { get; set; }

        public bool IsActive { get; set; }
    }
}
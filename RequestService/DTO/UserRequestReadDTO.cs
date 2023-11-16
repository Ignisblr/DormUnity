namespace RequestService.DTO
{
    public class UserRequestReadDTO
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public string Description { get; set; }

        // public string Autor { get; set; }

        // public string Executor { get; set; }

        // public Dictionary<DateTime, DateTime> Deadline { get; set; }

        public bool IsActive { get; set; }
    }
}
namespace RequestService.DTO
{
    public class UserRequestMakeDTO
    {
        public string Number { get; set; }

        public string Description { get; set; }

        // public string Autor { get; set; }

        // public string Executor { get; set; }

        // public Dictionary<DateTime, DateTime> Deadline { get; set; }

        public bool IsActive { get; set; }
    }
}
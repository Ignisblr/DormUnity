namespace DormitoryService.DTO
{
    public class DormitoryReadDTO
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string MainManager { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public int TotalRooms { get; set; }

        // public ICollection<Employee> Employees { get; set; }

        // public ICollection<Student> AccommodatedStudents { get; set; }
    }
}
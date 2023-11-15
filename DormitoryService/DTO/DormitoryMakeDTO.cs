using System.ComponentModel.DataAnnotations;

namespace DormitoryService.DTO
{
    public class DormitoryMakeDTO
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string MainManager { get; set; } = string.Empty;

        [Required]
        public string Address { get; set; } = string.Empty;

        [Required]
        public int TotalRooms { get; set; }

        // public ICollection<Employee> Employees { get; set; }

        // public ICollection<Student> AccommodatedStudents { get; set; }
    }
}
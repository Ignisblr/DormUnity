using System.ComponentModel.DataAnnotations;

namespace RequestService.Models
{
    public class UserRequest
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]        
        public string Number { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public IUser Autor { get; set; }

        [Required]
        public IUser Executor { get; set; }

        [Required]
        public Dictionary<DateTime, DateTime> Deadline { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
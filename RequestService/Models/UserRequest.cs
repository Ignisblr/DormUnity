using System.ComponentModel.DataAnnotations;
using AutoMapper.Configuration.Annotations;

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

        // [Ignore]
        // public string Autor { get; set; }

        // [Ignore]
        // public string Executor { get; set; }

        // [Ignore]
        // public Dictionary<DateTime, DateTime> Deadline { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
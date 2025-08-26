using System.ComponentModel;
using System.ComponentModel.DataAnnotations;                                                // needed for Data Annotations

namespace WebAppTrainees.Models
{
    public class Trainee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        //[Required]
        public string? Address { get; set; }

        public Trainee() { }
        public Trainee(int id, string name, string email, string? address = null)
        {
            Id = id;
            Name = name;
            Email = email;
            Address = address;
        }

        public override string ToString()
        {
            return $"Trainee Id: {Id}, Name: {Name}, Email: {Email}, Address: {Address}";
        }
    }
}
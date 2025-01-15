using IT_Institution_Course_Management_System.Entities.IT_Institution_Course_Management_System.Entities;
using System.ComponentModel.DataAnnotations;

namespace IT_Institution_Course_Management_System.DTO.RequestDTOs
{
    public class StudentRequestDTO
    {

        public string Nic { get; set; } = string.Empty; // National ID with validation

        public string FirstName { get; set; } = string.Empty; // First Name (mandatory)

        public string? LastName { get; set; } = string.Empty; // Last Name (optional)

        public string? Gender { get; set; } // Restricted values for Gender

        public string Email { get; set; } = string.Empty; // Email (mandatory)

        public string Phone { get; set; } = string.Empty; // Phone (mandatory)

        public string PasswordHash { get; set; } = string.Empty; // Password stored as a hash

        public AddressRequestDTO? Addresses { get; set; } // Optional one-to-one relationship
    }
}

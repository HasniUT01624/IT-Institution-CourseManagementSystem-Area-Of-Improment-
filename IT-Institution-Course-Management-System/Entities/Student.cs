using System.ComponentModel.DataAnnotations;

namespace IT_Institution_Course_Management_System.Entities
{
   

    using System.ComponentModel.DataAnnotations;

    namespace IT_Institution_Course_Management_System.Entities
    {
        public class Student
        {
            [Key]
            public Guid Id { get; set; } // Primary key using Guid for global uniqueness

            [Required]
            [StringLength(20, MinimumLength = 5, ErrorMessage = "NIC must be between 5 and 20 characters.")]
            public string Nic { get; set; } = string.Empty; // National ID with validation

            [Required]
            [StringLength(50, ErrorMessage = "First Name cannot exceed 50 characters.")]
            public string FirstName { get; set; } = string.Empty; // First Name (mandatory)

            [StringLength(50, ErrorMessage = "Last Name cannot exceed 50 characters.")]
            public string? LastName { get; set; } = string.Empty; // Last Name (optional)

            [Required]
            [RegularExpression("Male|Female|Other", ErrorMessage = "Gender must be 'Male', 'Female', or 'Other'.")]
            public string? Gender { get; set; } // Restricted values for Gender

            [Required]
            [EmailAddress(ErrorMessage = "Invalid Email Address.")]
            public string Email { get; set; } = string.Empty; // Email (mandatory)

            [Required]
            [Phone(ErrorMessage = "Invalid Phone Number.")]
            public string Phone { get; set; } = string.Empty; // Phone (mandatory)

            [Required]
            public string PasswordHash { get; set; } = string.Empty; // Password stored as a hash

            // Reference to the Address class
            public Address? Address { get; set; } // Optional one-to-one relationship
        }
    }

}

using System.ComponentModel.DataAnnotations;

namespace IT_Institution_Course_Management_System.Entities
{


    using System.ComponentModel.DataAnnotations;

    namespace IT_Institution_Course_Management_System.Entities
    {
        public class Address
        {
            [Key]
            public Guid Id { get; set; } // Primary key using Guid for global uniqueness

            [Required]
            [StringLength(100, ErrorMessage = "Address Line 1 cannot exceed 100 characters.")]
            public string AddressLine1 { get; set; } = string.Empty; // First line of the address

            [StringLength(100, ErrorMessage = "Address Line 2 cannot exceed 100 characters.")]
            public string? AddressLine2 { get; set; } = string.Empty; // Second line of the address (optional)

            [Required]
            [StringLength(50, ErrorMessage = "City cannot exceed 50 characters.")]
            public string City { get; set; } = string.Empty; // City (mandatory)

            [Required]
            [StringLength(50, ErrorMessage = "Country cannot exceed 50 characters.")]
            public string Country { get; set; } = string.Empty; // Country (mandatory)

            public Guid? StudentId { get; set; } // Foreign key to Student (nullable)

            // Reference to the Student class
            public Student? Student { get; set; } // Navigation property for one-to-one relationship
        }
    }

}



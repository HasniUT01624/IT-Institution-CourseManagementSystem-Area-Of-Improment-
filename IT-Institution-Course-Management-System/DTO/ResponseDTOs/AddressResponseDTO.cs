using System.ComponentModel.DataAnnotations;

namespace IT_Institution_Course_Management_System.DTO.ResponseDTOs
{
    public class AddressResponseDTO
    {
        public Guid Id { get; set; } // Primary key using Guid for global uniqueness

        public Guid StudentId { get; set; } // Foreign key to Student 

        public string AddressLine1 { get; set; } = string.Empty; // First line of the address

        public string? AddressLine2 { get; set; } = string.Empty; // Second line of the address (optional)

        public string City { get; set; } = string.Empty; // City (mandatory)

        public string Country { get; set; } = string.Empty; // Country (mandatory)

    }
}

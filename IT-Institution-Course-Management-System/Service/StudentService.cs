using IT_Institution_Course_Management_System.DTO.ResponseDTOs;
using IT_Institution_Course_Management_System.IRepository;
using IT_Institution_Course_Management_System.IService;
using IT_Institution_Course_Management_System.Repository;

namespace IT_Institution_Course_Management_System.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ILogger<StudentService> _logger;

      public   StudentService(IStudentRepository studentRepository, ILogger<StudentService> logger)
        {
            _studentRepository = studentRepository;
            _logger = logger;
        }

        public async Task<ICollection<StudentResponseDTO>> GetAllStudent()
        {
            try
            {
                var students = await _studentRepository.GetAllStudent();

                // Use LINQ for projection
                var studentsList = students.Select(student => new StudentResponseDTO
                {
                    Id = student.Id,
                    Nic = student.Nic,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    Email = student.Email,
                    Phone = student.Phone
                    // Exclude sensitive data like Password
                }).ToList();

                return studentsList;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error fetching students: {ex.Message}", ex);
                throw new ApplicationException("An error occurred while fetching students. Please try again later.", ex);
            }
        }


    }
}

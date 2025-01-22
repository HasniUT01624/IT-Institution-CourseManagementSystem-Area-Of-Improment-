using IT_Institution_Course_Management_System.DTO.ResponseDTOs;

namespace IT_Institution_Course_Management_System.IService
{
    public interface IStudentService
    {
        Task<ICollection<StudentResponseDTO>> GetAllStudent();
    }
}

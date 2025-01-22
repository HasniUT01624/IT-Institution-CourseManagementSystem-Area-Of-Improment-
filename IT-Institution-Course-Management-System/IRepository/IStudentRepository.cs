using IT_Institution_Course_Management_System.Entities.IT_Institution_Course_Management_System.Entities;

namespace IT_Institution_Course_Management_System.IRepository
{
    public interface IStudentRepository
    {
        Task<ICollection<Student>> GetAllStudent();
    }
}

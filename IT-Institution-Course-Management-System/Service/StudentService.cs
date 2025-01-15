using IT_Institution_Course_Management_System.IRepository;

namespace IT_Institution_Course_Management_System.Service
{
    public class StudentService
    {
        private readonly  IStudentRepository _studentRepository;

        StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
    }
}

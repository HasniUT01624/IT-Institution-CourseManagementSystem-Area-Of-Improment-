using IT_Institution_Course_Management_System.DBContext;
using IT_Institution_Course_Management_System.Entities.IT_Institution_Course_Management_System.Entities;
using IT_Institution_Course_Management_System.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace IT_Institution_Course_Management_System.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDBContext _dbContext;

        public StudentRepository(AppDBContext dBContext)
        {
            _dbContext = dBContext;
           
        }


        public async Task<ICollection<Student>> GetAllStudent()
        {
            try
            {
                var students = await _dbContext.Students.Include(a => a.Address).ToListAsync();
                return students;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while fetching students.", ex);
            }

        }



    }
}

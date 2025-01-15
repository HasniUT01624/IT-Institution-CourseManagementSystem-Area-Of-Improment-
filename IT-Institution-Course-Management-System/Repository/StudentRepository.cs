﻿using IT_Institution_Course_Management_System.DBContext;
using IT_Institution_Course_Management_System.IRepository;

namespace IT_Institution_Course_Management_System.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDBContext _dbContext;

        public StudentRepository(AppDBContext dBContext)
        {
            _dbContext = dBContext;
        }
    }
}

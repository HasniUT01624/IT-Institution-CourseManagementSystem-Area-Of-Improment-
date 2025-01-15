﻿using IT_Institution_Course_Management_System.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IT_Institution_Course_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PAC.BusinessLogic;
using PAC.Domain;
using PAC.IBusinessLogic;
using PAC.IDataAccess;
using PAC.WebAPI.Filters;

namespace PAC.WebAPI
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {

        private readonly IStudentLogic service;

        public StudentController(IStudentLogic service)
        {
            this.service = service;
        }

        [HttpPost]
        public ActionResult CreateStudent([FromBody] Student student)
        {
            service.InsertStudents(student);
            return new ObjectResult(student) { StatusCode = 201 };
        }

        [HttpGet]
        public ActionResult GetAllStudent()
        {
            IEnumerable<Student> students = service.GetStudents();
            if(students.Count() == 0)
                return NoContent();
            return  Ok(students);
        }

        [HttpGet("{id}")]
        public ActionResult GetStudentById([FromRoute] int id)
        {
            Student? student = service.GetStudentById(id);
            if(student == null)
                return NotFound();
            return  Ok(student);
        }
    }
}

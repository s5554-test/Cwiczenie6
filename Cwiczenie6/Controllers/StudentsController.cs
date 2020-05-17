using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenie6.DTOs.Requests;
using Cwiczenie6.Models;
using Cwiczenie6.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenie6.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        private IStudentsDbService _dbService;

        public StudentsController(IStudentsDbService service)
        {
            _dbService = service;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            /* var dane = _dbService.GetStudents();
              var list = new List<Student>();
              var st = new Student();
              list.Add(st.IndexNumber);
              list.Add(st.FirstName);
              list.Add(st.LastName);
              list.Add(st.BirthDate);
              list.Add(st.StudiesName);
              st.FirstName = dane.FirstName;
              st.LastName = dane.LastName;
              st.BirthDate = Convert.ToDateTime(request.BirthDate);
              st.StudiesName = request.StudiesName;

              _dbService.GetStudents();
              var response = new EnrollStudentResponse();
              response.IndexNumber = st.IndexNumber;
              response.FirstName = st.FirstName;
              response.LastName = st.LastName;
              response.BirthDate = Convert.ToDateTime(st.BirthDate);
              response.StudiesName = st.StudiesName;
              list.Add(response);
              //return Ok(_dbService.EnrollStudent(request));
              return Ok(list);*/
              return Ok(_dbService.GetStudents());


        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(string id)
        {

            return Ok(_dbService.GetStudent(id));
        }

    }
}

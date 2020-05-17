using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Cwiczenie6.Services;
using Cwiczenie6.DTOs.Requests;
using Cwiczenie6.Models;
using Cwiczenie6.DTOs.Responses;

namespace Cwiczenie6.Controllers
{
    [Route("api/enrollments")]
    [ApiController]
    public class EnrollmentsController : ControllerBase
    {

        private IStudentsDbService _dbService;

        public EnrollmentsController(IStudentsDbService service)
        {
            _dbService = service;
        }
        [HttpPost]
        public IActionResult EnrollStudent(EnrollStudentRequest request)
        {

            var list = new List<EnrollStudentResponse>();
            var st = new Student();
            st.IndexNumber = request.IndexNumber;
            st.FirstName = request.FirstName;
            st.LastName = request.LastName;
            st.BirthDate = Convert.ToDateTime(request.BirthDate);
            //st.StudiesName = request.StudiesName;

            _dbService.EnrollStudent(request);
            var response = new EnrollStudentResponse();
            response.IndexNumber = st.IndexNumber;
            response.FirstName = st.FirstName;
            response.LastName = st.LastName;
            response.BirthDate = Convert.ToDateTime(st.BirthDate);
            //response.StudiesName = st.StudiesName;
            list.Add(response);
            //return Ok(_dbService.EnrollStudent(request));
            return Ok(list);

        }

        /* [HttpPost]
         public IActionResult PromoteStudents(int semester, string studiesname)
         {

             return Ok();
         }*/
    }
}
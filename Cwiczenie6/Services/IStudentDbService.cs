using Cwiczenie6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenie6.Controllers;
using Cwiczenie6.DTOs.Requests;
using Cwiczenie6.DTOs.Responses;


namespace Cwiczenie6.Services
{
    public interface IStudentsDbService
    {
        IEnumerable<Student> GetStudents();
        IEnumerable<Student> GetStudent(string id);
        IEnumerable<EnrollStudentResponse> EnrollStudent(EnrollStudentRequest r);
        IEnumerable<EnrollStudentResponse> PromoteStudents(int semester, string studiesname);



    }
}

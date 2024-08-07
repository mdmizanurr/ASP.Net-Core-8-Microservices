using Microsoft.AspNetCore.Mvc;
using StudentAdmissionManagement.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAdmissionManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdmissionController : ControllerBase
    {
        // GET: api/<StudentAdmissionController>
        [HttpGet]
        public IEnumerable<StudentAdmissionDetailsModel> Get()
        {
            StudentAdmissionDetailsModel addmissionObj1 = new StudentAdmissionDetailsModel();
            StudentAdmissionDetailsModel addmissionObj2 = new StudentAdmissionDetailsModel();

            addmissionObj1.StudentId = 1;
            addmissionObj1.StudentName = "Mizan";
            addmissionObj1.StudentClass = "X";
            addmissionObj1.DateOfJoining = DateTime.Now;

            addmissionObj2.StudentId = 2;
            addmissionObj2.StudentName = "Rahman";
            addmissionObj2.StudentClass = "IX";
            addmissionObj2.DateOfJoining = DateTime.Now;

            List<StudentAdmissionDetailsModel> objList = new List<StudentAdmissionDetailsModel>
            {
                addmissionObj1, addmissionObj2
            };

            return objList;


        }

        // GET api/<StudentAdmissionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentAdmissionController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentAdmissionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentAdmissionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

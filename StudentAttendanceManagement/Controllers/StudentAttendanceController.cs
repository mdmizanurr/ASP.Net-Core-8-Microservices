using Microsoft.AspNetCore.Mvc;
using StudentAttendanceManagement.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAttendanceManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAttendanceController : ControllerBase
    {
        // GET: api/<StudentAttendanceController>
        [HttpGet]
        public IEnumerable<StudentAttendanceDetailsModel> Get()
        {
            StudentAttendanceDetailsModel attendaceObj1 = new StudentAttendanceDetailsModel();
            StudentAttendanceDetailsModel attendaceObj2 = new StudentAttendanceDetailsModel();

            attendaceObj1.StudentId = 1;
            attendaceObj1.StudentName = "Mizan";
            attendaceObj1.AttendancePercentage = 83.03;

            attendaceObj2.StudentId = 2;
            attendaceObj1.StudentName = "Rahman";
            attendaceObj1.AttendancePercentage = 71.02;

            List<StudentAttendanceDetailsModel> listObj = new List<StudentAttendanceDetailsModel>()
            {
                attendaceObj1, attendaceObj2
            };

            return listObj;

        }

        // GET api/<StudentAttendanceController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentAttendanceController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentAttendanceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentAttendanceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

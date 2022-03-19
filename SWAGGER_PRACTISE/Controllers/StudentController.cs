using Microsoft.AspNetCore.Mvc;
using SWAGGER_PRACTISE.Data;
using SWAGGER_PRACTISE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SWAGGER_PRACTISE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public StudentController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _db.Students;
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return _db.Students.SingleOrDefault(x=>x.RollNo == id);
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] Student student)
        {
            _db.Students.Add(student);
            _db.SaveChanges();
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student student)
        {
            student.RollNo = id;
            _db.Students.Update(student);
            _db.SaveChanges();
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _db.Students.FirstOrDefault(x => x.RollNo == id);
            if(item !=null)
            {
                _db.Students.Remove(item);
                _db.SaveChanges();
            }
        }
    }
}

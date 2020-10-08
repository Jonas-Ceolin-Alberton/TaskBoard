using System.Collections.Generic;
using Backend.Models;
using Backend.MongoDb;
using Microsoft.AspNetCore.Mvc;


namespace Backend.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase

    {
        private MongoDbContext mongoDb;

        public UserController()
        {
            mongoDb = new MongoDbContext();
        }

        // GET: api/<User>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<User>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<User>
        [HttpPost]
        public void Post([FromBody] UserEntity user)
        {
            mongoDb.Database.GetCollection<UserEntity>("User").InsertOne(user);
        }

        // PUT api/<User>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<User>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

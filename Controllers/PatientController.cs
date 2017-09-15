using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using Newtonsoft.Json;
using Medic.Models.PATIENT;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Medic.Controllers
{
    [Route("api/[controller]")]
    public class PatientController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{name}")]
        public string Get(string name)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            string db_name = "test";
            var database = client.GetDatabase(db_name);
            var collection = database.GetCollection<BsonDocument>("patients");
            var filter = Builders<BsonDocument>.Filter.Eq("Name", name);
            var document = collection.Find(filter).First();
            var m = BsonSerializer.Deserialize<Patient>(document);
            string json = JsonConvert.SerializeObject(m);
            return json;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

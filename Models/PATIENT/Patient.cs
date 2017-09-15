using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using Newtonsoft.Json;
using Medic.Models;
using MongoDB.Bson.Serialization;

namespace Medic.Models.PATIENT
{
    //For export FROM mongodb
    public class Patient
    {
        public ObjectId _id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Encounter> Encounters { get; set; }
        public Info Info { get; set; }
       

        public Patient() {
            Name = "";
            Age = 0;
            Encounters = new List<Encounter>();
            Info = new Info();
        }

        public Patient(ObjectId id, string name, int age, List<Encounter> encounters, Info info) {
            _id = id;
            Name = name;
            Age = age;
            Encounters = encounters;
            Info = info;
        }
    }
}

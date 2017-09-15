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
    //For entry INTO mongodb
    public class NewPatient
    {    
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Encounter> Encounters { get; set; }
        public Info Info { get; set; }

        public NewPatient() {
            Name = "";
            Age = 0;
            Encounters = new List<Encounter>();
            Info = new Info();
        }

        public NewPatient(string name, int age, List<Encounter> encounters, Info info)
        {  
            Name = name;
            Age = age;
            Encounters = encounters;
            Info = info;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _3_repositories.Entities
{
   
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }  
        public string HMO { get; set; }
        public List<Child> Children { get; set; }
        
    }
}

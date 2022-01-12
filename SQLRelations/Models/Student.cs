using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SQLRelations.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int Grade { get; set; }
        public int GroupsId { get; set; }
        public Group Groups { get; set; }

    }
}

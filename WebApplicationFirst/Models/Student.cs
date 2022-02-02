using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationFirst.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public int Age { get; set; }

        public Student(string fullname,int age,int id)
        {
            Fullname = fullname;
            Age = age;
            Id = id;
            
        }
        public override string ToString()
        {
            return $"{Id} {Fullname} {Age}";
        }
    }
    
}

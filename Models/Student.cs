using System;
using System.Collections.Generic;
//tinfo200:[2020-03-13-seguya-dykstra2]:Here we created the student class under models and initialized objects specific to the class

namespace ContosoUniversity.Models
{
    public class Student
    {
        //tinfo200:[2020-03-13-seguya-dykstra2]:we automaticaly creat get and set methods for variables in the student class
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //tinfo200:[2020-03-13-seguya-dykstra2]: Here we establish the only connection that the student class has.
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
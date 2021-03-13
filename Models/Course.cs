//tinfo200:[2020-03-13-seguya-dykstra2]: Here we created the course class and implemented elements needed to run 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course

    {
        //tinfo200:[2020-03-13-seguya-dykstra2]: We want to use our real world course ID's not any generated database numbers
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
//tinfo200:[2020-03-13-seguya-dykstra2]: Here we created the enrollment class and 
namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        //tinfo200:[2020-03-13-seguya-dykstra2]:We then implement the two connections that the enrollment 
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}


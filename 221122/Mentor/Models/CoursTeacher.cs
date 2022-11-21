namespace Mentor.Models
{
    public class CoursTeacher
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int CoursId { get; set; }

        public Teacher Teacher { get; set; }
        public Course Course { get; set; }
    }
}

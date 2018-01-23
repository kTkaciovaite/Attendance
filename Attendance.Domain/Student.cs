
namespace Attendance.Domain
{
    public class Student
    {
        public int Id { get; set; }

        public Group Group { get; set; }

        public int UserId { get; set; }

        public string CardNumber { get; set; }
    }
}

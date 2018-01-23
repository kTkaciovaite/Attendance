
namespace Attendance.Domain
{
   public class Schedule
    {
        public int Id { get; set; }

        public LectureTime LectureTime { get; set; }

        public Group Group { get; set; }

        public int Week { get; set; }

        public Subject Subject { get; set; }

        public Auditorium Auditorium { get; set; }

        public Lecturer Lecturer { get; set; }

        public LectureType LectureType { get; set; }
    }
}

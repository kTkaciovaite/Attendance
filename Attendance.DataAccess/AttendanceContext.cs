using Attendance.Domain;
using System.Data.Entity;

namespace Attendance.DataAccess
{
    public class AttendanceContext : DbContext
    {
        public DbSet<AttendanceEntry> AttendanceEntry { get; set; }

        public DbSet<Auditorium> Auditorium { get; set; }

        public DbSet<Group> Group { get; set; }

        public DbSet<Lecturer> Lecture { get; set; }

        public DbSet<LectureTime> LectureTime { get; set; }

        public DbSet<LectureType> LectureType { get; set; }

        public DbSet<Schedule> Schedule { get; set; }

        public DbSet<Student> Student { get; set; }

        public DbSet<Subject> Subject { get; set; }
    }
}

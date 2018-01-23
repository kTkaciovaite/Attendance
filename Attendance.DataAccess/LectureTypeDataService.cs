using Attendance.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Attendance.DataAccess
{
    public class LectureTypeDataService
    {
        public List<LectureType> GetAll()
        {
            using (var context = new AttendanceContext())
            {
                return context.LectureType.ToList();
            }
        }
    }
}

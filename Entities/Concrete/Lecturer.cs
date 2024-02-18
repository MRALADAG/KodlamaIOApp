using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Lecturer : IEntity, IUser
    {
        public int UserId { get; set; }
        public string UserName
        {
            get
            {
                return LecturerFirstName + " " + LecturerLastName;
            }
        }
        public int LecturerId { get; set; }
        public string LecturerFirstName { get; set; }
        public string LecturerLastName { get; set; }
        public string LecturerEmail { get; set; }
        public string Password { get; set; }

        public bool LecturerAuth { get; set; }

        public List<Course> CoursesToLecturer { get; set; } = new List<Course>();
    }
}

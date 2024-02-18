using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Student : IEntity, IUser
    {
        public int UserId { get; set; }
        public string UserName
        {
            get
            {
                return StudentFirstName + " " + StudentLastName;
            }
        }
        public int StudentId { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public string StudentEmail { get; set; }
        public string Password { get; set; }

        public bool StudentAuth { get; set; }

        public List<int> RegisteredForCourseId { get; set; } = new List<int>();

        public string ToString()
        {
            string courses = "";
            if (this.RegisteredForCourseId != null)
            {
                courses += "[ ";
                this.RegisteredForCourseId.ForEach(x => courses += x + " ");
                courses += "]";
            }

            return
                "{ İsim: " + this.StudentFirstName +
                ", Soyisim: " + this.StudentLastName +
                ", eposta: " + this.StudentEmail +
                ", Password: " + this.Password +
                ", UserId: " + this.UserId +
                ", UserName: " + this.UserName +
                ", Doğrulama:  " + this.StudentAuth.ToString() +
                ", Kayıtlı olduğu kursların id bilgileri: " + courses + " }";
        }
    }
}

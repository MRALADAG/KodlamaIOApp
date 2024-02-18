using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Course : IEntity
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public string CourseDescription { get; set; }

        public string ToString()
        {
            return
                "{ CourseId:" + this.CourseId + ", " +
                " Kurs Adı:" + this.CourseName + ", " +
                " Kurs İçeriği:" + this.CourseDescription + ", " +
                " InstructorId:" + this.InstructorId + ", " +
                " CategoryId:" + this.CategoryId + " }";
        }
    }
}

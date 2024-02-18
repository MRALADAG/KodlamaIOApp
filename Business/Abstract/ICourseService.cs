using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseService
    {
        void AddCourse(Course course, Lecturer lecturer);
        void UpdateCourse(Course course);
        void RemoveCourse(Course course);
        List<Course> GetAllCourses();
    }
}

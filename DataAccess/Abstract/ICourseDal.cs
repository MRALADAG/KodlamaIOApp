using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICourseDal
    {
        void AddCourse(Course course);
        void UpdateCourse(Course course);
        void RemoveCourse(Course course);
        Course GetCourseById(int courseId);
        List<Course> GetAllCourses();
        List<Course> GetAllEnrolledCourse(Student student);
    }
}

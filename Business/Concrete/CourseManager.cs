using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseManager : ICourseService
    {
        private ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void AddCourse(Course course)
        {
            _courseDal.AddCourse(course);
        }

        public List<Course> GetAllCourses()
        {
            return _courseDal.GetAllCourses();
        }

        public List<Course> GetAllEnrolledCourse(Student student)
        {
            return _courseDal.GetAllEnrolledCourse(student);
        }
    }
}

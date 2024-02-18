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
        private ILecturerDal _lecturerDal;

        public CourseManager(ICourseDal courseDal, ILecturerDal lecturerDal)
        {
            _courseDal = courseDal;
            _lecturerDal = lecturerDal;
        }

        public void AddCourse(Course course)
        {
            _courseDal.AddCourse(course);
        }

        public void UpdateCourse(Course course)
        {
            _courseDal.GetAllCourses().Where(c => c.CourseId == course.CourseId).ToList().ForEach(c => c = course);
        }

        public void RemoveCourse(Course course)
        {
            Lecturer updatedLecturer = _lecturerDal.GetById(course.InstructorId);
            updatedLecturer.CoursesIdToLecturer.Remove(course.CourseId);
            _lecturerDal.Update(updatedLecturer);
            _courseDal.RemoveCourse(course);
        }

        public List<Course> GetAllCourses()
        {
            return _courseDal.GetAllCourses();
        }

        public List<Course> GetAllEnrolledCourse(Student student)
        {
            return _courseDal.GetAllEnrolledCourse(student);
        }

        public Course GetCourseById(int courseId)
        {
            return _courseDal.GetCourseById(courseId);
        }
    }
}

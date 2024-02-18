using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryStudentDal : IStudentDal
    {
        List<Student> _students;
        List<Course> _courses;

        public InMemoryStudentDal(ICourseDal courseDal)
        {
            _students = new List<Student>();
            _courses = courseDal.GetAllCourses();
        }

        public void Add(Student student)
        {
            _students.Add(student);
        }

        public List<Student> GetAll()
        {
            return _students;
        }

        public void Update(Student student)
        {
            //Student updatedStudent = _students.Find(s => s.StudentId == student.StudentId);
            //updatedStudent = student;

            // II. Way;
            _students.Where(w => w.StudentId == student.StudentId).ToList().ForEach(i => i = student);

            // III. Way
            //_students.Where(w => w.StudentId == student.StudentId)
            //    .Select(w =>
            //{
            //    w = student;
            //    return w;
            //}
            //)
            //     .ToList();
        }

        public Student GetById(int studentId)
        {
            return _students.Find(s => s.StudentId == studentId);
        }

        public void EnrollCourse(Student student, Course course)
        {
            Student student1 = _students.FirstOrDefault(s => s.StudentId == student.StudentId);
            student1.RegisteredForCourseId.Add(course.CourseId);
        }

        public List<int> GetAllEnrolledCourse(int studentId)
        {
            return _students.FirstOrDefault(s => s.StudentId == studentId).RegisteredForCourseId;
        }
    }
}

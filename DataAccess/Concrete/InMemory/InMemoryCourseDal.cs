using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCourseDal : ICourseDal
    {
        List<Course> _courses;

        public InMemoryCourseDal()
        {
            _courses = new List<Course> {
                new Course
                          {
                              CategoryId=1,
                              CourseName="Modern C# Kursu : .NET Dünyası İçin Sıfırdan Profesyonelliğe",
                              InstructorId=1,
                              CourseId=1,
                              CourseDescription="PROGRAMLAMA BİLMEDİĞİNİZİ DÜŞÜNEREK SIFIRDAN BAŞLADIK. KURSUN TAMAMINI KASIM 2020'de ÇEKİLMİŞ, SIFIRDAN EN GÜNCEL İÇERİKLE DONATTIK."
                          },
                        new Course
                          {
                              CategoryId=2,
                              CourseName="Kurumsal Mimariler İçin Sql Server Veri Tabanı Tasarımı",
                              InstructorId=1,
                              CourseId=2,
                              CourseDescription="Nesnel veritabanı tasarımına farklı bir açıdan bakmanızı sağlayacak hap eğitim."
                          },
                        new Course
                          {
                              CategoryId=2,
                              CourseName="SQL Kursu : Sıfırdan Sektörün Yükseklerine 2020",
                              InstructorId=1,
                              CourseId=3,
                              CourseDescription="İster bir bankada finans uzmanı veya risk yöneticisi olun, isterse bir şirketin kıdemli yazılım geliştiricisi olun, tam size göre bir kurs hazırladık."
                          }
            };
        }

        public void AddCourse(Course course)
        {
            _courses.Add(course);
        }

        public void UpdateCourse(Course course)
        {
            _courses.Where(c => c.CourseId == course.CourseId).ToList().ForEach(c => c = course);
        }

        public void EnrollCourse(Course course)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAllEnrolledCourse(Student student)
        {
            List<Course> allCourses = new List<Course>();

            student.RegisteredForCourseId.ForEach(c =>
            {
                allCourses.Add(_courses.Find(item => item.CourseId == c));
            });
            return allCourses;
        }

        public void RemoveCourse(Course course)
        {
            _courses.Remove(_courses.Find(c => c.CourseId == course.CourseId));
        }

        public Course GetCourseById(int courseId)
        {
            return _courses.Find(c => c.CourseId == courseId);
        }

        public List<Course> GetAllCourses()
        {
            return _courses;
        }
    }
}

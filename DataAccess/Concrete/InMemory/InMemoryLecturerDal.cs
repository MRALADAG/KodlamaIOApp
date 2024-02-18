using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryLecturerDal : ILecturerDal
    {
        List<Lecturer> _lecturers;

        public InMemoryLecturerDal()
        {
            _lecturers = new List<Lecturer> {
                new Lecturer(){
                    UserId=1,
                    LecturerId=1,
                    LecturerAuth=true,
                    LecturerFirstName="Engin",
                    LecturerLastName="DEMİROĞ",
                    Password="1234567898",
                    LecturerEmail="engin.demirog@gmail.com",
                    CoursesToLecturer=new List<Course> {
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
                          },
                    }
                }
            };
        }

        public void Add(Lecturer lecturer)
        {
            _lecturers.Add(lecturer);
        }

        public List<Lecturer> GetAll()
        {
            return _lecturers;
        }

        public Lecturer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Lecturer entity)
        {
            throw new NotImplementedException();
        }
    }
}

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
                    CoursesIdToLecturer=new List<int> {1,2,3}
                }
            };
        }

        public void Add(Lecturer lecturer)
        {
            _lecturers.Add(lecturer);
        }

        public void Update(Lecturer lecturer)
        {
            _lecturers.Where(l => l.LecturerId == lecturer.LecturerId).ToList().ForEach(l => l = lecturer);
        }

        public Lecturer GetById(int id)
        {
            return _lecturers.Find(l => l.LecturerId == id);
        }

        public List<Lecturer> GetAll()
        {
            return _lecturers;
        }
    }
}

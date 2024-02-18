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
    public class StudentManager : IStudentService
    {
        private IAuthService _authService;

        private IStudentDal _studentDal;

        public StudentManager(IAuthService authService, IStudentDal studentDal)
        {
            _authService = authService;
            _studentDal = studentDal;
        }

        public void AddStudent(Student student)
        {
            if (_authService.checkIfRealUser(student))
            {
                student.StudentAuth = _authService.checkIfRealUser(student);
                _studentDal.Add(student);
                Console.WriteLine(student.UserName + " isimli öğrenci sisteme başarıyla eklenmiştir.");
            }
            else
                throw new Exception("Kayıt esnasında girilen bilgiler doğrulanamaıştır. Lütfen bilgileri eksiksiz ve doğru olarak doldurunuz!");
        }

        public void UpdateStudent(Student Student)
        {
            _studentDal.Update(Student);
        }

        public Student GetStudentById(int id)
        {
            return _studentDal.GetById(id);
        }

        public List<Student> GetAll()
        {
            return _studentDal.GetAll();
        }

        public void EnrollCourse(Student student, Course course)
        {
            _studentDal.EnrollCourse(student, course);
        }
    }
}

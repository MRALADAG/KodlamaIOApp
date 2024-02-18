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
    public class InstructorManager : IInstructorService
    {
        private IAuthService _authService;

        private ILecturerDal _lecturerDal;

        public InstructorManager(IAuthService authService, ILecturerDal lecturerDal)
        {
            _authService = authService;
            _lecturerDal = lecturerDal;
        }

        public void AddLecturer(Lecturer lecturer)
        {
            if (_authService.checkIfRealUser(lecturer))
            {
                _lecturerDal.Add(lecturer);
                Console.WriteLine(lecturer.UserName + " isimli eğitmen sisteme başarıyla eklenmiştir.");
            }
            else
                throw new Exception("Kayıt esnasında girilen bilgiler doğrulanamaıştır. Lütfen bilgileri eksiksiz ve doğru olarak doldurunuz!");
        }

        public void UpdateLecturer(Lecturer lecturer)
        {
            _lecturerDal.Update(lecturer);
        }

        public Lecturer GetLecturerById(int id)
        {
            return _lecturerDal.GetById(id);
        }

        public List<Lecturer> GetAll()
        {
            return _lecturerDal.GetAll();
        }
    }
}

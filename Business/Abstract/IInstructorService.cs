using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IInstructorService
    {
        void AddLecturer(Lecturer lecturer);
        void UpdateLecturer(Lecturer lecturer);
        Lecturer GetLecturerById(int lecturerId);
        List<Lecturer> GetAll();
    }
}

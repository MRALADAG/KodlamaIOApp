﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IStudentService
    {
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        Student GetStudentById(int studentId);
        List<Student> GetAll();
        void EnrollCourse(Student student, Course course);
    }
}

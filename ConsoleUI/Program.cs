using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

class Program
{
    public static void Main(string[] args)
    {

        Student student = new Student();
        student.UserId = 2;
        student.StudentId = 1;
        student.StudentFirstName = "Seçkin";
        student.StudentLastName = "DANIŞ";
        student.StudentEmail = "seckin.danis@gmail.com";
        student.Password = "12154854154";
        student.RegisteredForCourseId.Add(1);
        student.RegisteredForCourseId.Add(2);
        student.RegisteredForCourseId.Add(3);

        //Console.WriteLine(student.ToString());
        Console.WriteLine("**************************************\n");

        StudentManager studentManager = new StudentManager(new AuthManager(), new InMemoryStudentDal(new InMemoryCourseDal()));
        studentManager.AddStudent(student);

        Console.WriteLine("\nİlk öğrenci listesi:\n");
        studentManager.GetAll().ForEach(student =>
        {
            Console.WriteLine(student.StudentFirstName + " " + student.StudentLastName);
        });

        student.StudentLastName = "ERCİYES";
        studentManager.UpdateStudent(student);

        Console.WriteLine("\n**************************************\n");

        Console.WriteLine("Güncellenen öğrenci listesi:\n");
        studentManager.GetAll().ForEach(student =>
        {
            Console.WriteLine(student.StudentFirstName + " " + student.StudentLastName);
        });

        Console.WriteLine("\nBütün kursların listesi:\n");
        CourseManager courseManager = new CourseManager(new InMemoryCourseDal());
        courseManager.GetAllCourses().ForEach(course => Console.WriteLine(course.ToString()));

        Console.WriteLine("\nBütün {0} isimli öğrencinin kayıtlı olduğu kursların listesi:\n", student.UserName);
        courseManager.GetAllEnrolledCourse(student).ForEach(course => Console.WriteLine(course.ToString()));
    }
}
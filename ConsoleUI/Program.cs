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

        Student student2 = new Student(3, 2, "Adem", "COŞKUN", "adem.coskun@gmail.com", "174478544");

        //Console.WriteLine(student.ToString());
        Console.WriteLine("**************************************\n");

        StudentManager studentManager = new StudentManager(new AuthManager(), new InMemoryStudentDal(new InMemoryCourseDal()));
        studentManager.AddStudent(student);

        studentManager.AddStudent(student2);

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
        CourseManager courseManager = new CourseManager(new InMemoryCourseDal(), new InMemoryLecturerDal());
        courseManager.GetAllCourses().ForEach(course => Console.WriteLine(course.ToString()));

        Console.WriteLine("\nBütün {0} isimli öğrencinin kayıtlı olduğu kursların listesi:\n", student.UserName);
        courseManager.GetAllEnrolledCourse(student).ForEach(course => Console.WriteLine(course.ToString()));

        studentManager.EnrollCourse(student2, courseManager.GetCourseById(2));
        Console.WriteLine(student2.ToString());
        Console.WriteLine("\n{0} isimli öğrencinin kayıt olduğu kurslar: \n", student2.UserName);
        courseManager.GetAllEnrolledCourse(student2).ForEach(course => Console.WriteLine(course.ToString()));

        Console.WriteLine("\n");
        //Course courses = from c in courseManager.GetAllCourses() where c.CourseId is in student2.RegisteredForCourseId select c;
        List<Course> courses = courseManager.GetAllCourses().Where(c => student2.RegisteredForCourseId.All(r => r == c.CourseId)).ToList();
        courses.ForEach(c => Console.WriteLine(c.ToString()));

        Console.WriteLine("\n********************Get student all enrolled courses************************");
        courseManager.GetAllEnrolledCourse(student).ForEach(c => Console.WriteLine(c.ToString()));
    }
}
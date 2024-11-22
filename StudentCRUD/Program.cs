using StudentCRUD.Services;
using StudentCRUD.Models;

namespace StudentCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunFrontEnd();
        }
        public static void RunFrontEnd()
        {
            var studentService = new StudentService();
            while (true)
            {
                Console.WriteLine(" 1. Add");
                Console.WriteLine(" 2. Delete");
                Console.WriteLine(" 3. Update");
                Console.WriteLine(" 4. GetAll");
                Console.WriteLine(" 5. GetById");
                Console.Write(" Enter option: ");
                var option  = Console.ReadLine();

                if (option == "1")
                {
                    var student = new Student();
                    Console.Write(" Enter name :");
                    student.FirstName = Console.ReadLine();
                    Console.Write(" Enter Last name: ");
                    student.LastName = Console.ReadLine();
                    Console.Write("Enter Age : ");
                    student.Age = int.Parse(Console.ReadLine());
                    Console.Write(" Enter Adress: ");
                    student.Adress = Console.ReadLine();
                    Console.Write(" Enter Faculti: ");
                    student.Faculty = Console.ReadLine();

                    studentService.AddStudent(student);
                }
                else if(option == "2")
                {
                    Console.Write(" Enter Id to Delete: ");
                    var id = Guid.Parse(Console.ReadLine());
                    var studentdelete = studentService.DeleteStudent(id);
                    Console.WriteLine(studentdelete);
                }
                else if (option == "3")
                {

                    var student = new Student();
                    Console.Write(" Enter Id to update: ");
                    student.Id = Guid.Parse(Console.ReadLine());
                    Console.Write(" Enter name :");
                    student.FirstName = Console.ReadLine();
                    Console.Write(" Enter Last name: ");
                    student.LastName = Console.ReadLine();
                    Console.Write("Enter Age : ");
                    student.Age = int.Parse(Console.ReadLine());
                    Console.Write(" Enter Adress: ");
                    student.Adress = Console.ReadLine();
                    Console.Write(" Enter Faculti: ");
                    student.Faculty = Console.ReadLine();

                    studentService.UpdateStudent(student);
                }
                else if (option == "4")
                {
                    var students = studentService.GetAllStudents();
                    foreach (var student in students)
                    {
                        string studentInfo = $" Id : {student.Id}, FirstName: {student.FirstName}, " +
                            $" LastName: {student.LastName} , Age: {student.Age}, Adress: {student.Adress}," +
                            $" Faculty: {student.Faculty}";
                        Console.WriteLine($" {studentInfo} ");
                    }
                }
                else if (option == "5")
                {
                    Console.Write(" Enter Id to get : ");
                    var id = Guid.Parse (Console.ReadLine());
                    var student = studentService.GetById(id);
                    string studentInfo = $" Id : {student.Id}, FirstName: {student.FirstName}, " +
                           $" LastName: {student.LastName} , Age: {student.Age}, Adress: {student.Adress}," +
                           $" Faculty: {student.Faculty}";
                    Console.WriteLine($" {studentInfo} ");

                }
                Console.ReadKey();
                Console.Clear();

                        
            }
        }

    }
}

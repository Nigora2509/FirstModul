using StudentCRUD.Models;

namespace StudentCRUD.Services
{
    public class StudentService
    {
        private List<Student> students;
        public StudentService()
        {
            students = new List<Student>();
            DataSeed();
        }

        public Student AddStudent(Student student)
        {
            student.Id = Guid.NewGuid();
            students.Add(student);
            return student;
        }

        public bool DeleteStudent(Guid studentId)
        {
            var exists = false;
            foreach (var student in students)
            {
                if (student.Id == studentId)
                {
                    exists = true;
                    break;
                }
            }
            return exists;
        }

        public bool UpdateStudent(Student updateStudent)
        {
            for (var i = 0; i < students.Count; i++)
            {
                if (students[i].Id == updateStudent.Id)
                {
                    students[i] = updateStudent;
                    return true;
                }
            }
            return false;
        }

        public Student GetById(Guid studentId)
        {
            foreach (var student in students)
            {
                if (student.Id == studentId)
                {
                    return student;

                }
            }
            return null;
        }

        public List<Student> GetAllStudents()
        {
            return students;

        }

        private void DataSeed()
        {
            var firstStudent = new Student();
            {
                firstStudent.Id = Guid.NewGuid();
                firstStudent.FirstName = "Alisher";
                firstStudent.LastName = "Umarov";
                firstStudent.Age = 21;
                firstStudent.Adress = "Olmazor street 34";
                firstStudent.Faculty = "IT";

            }
            var secondStudent = new Student();
            {
                secondStudent.Id = Guid.NewGuid();
                secondStudent.FirstName = "Umida";
                secondStudent.LastName = "Odilova";
                secondStudent.Age = 20;
                secondStudent.Adress = "Beruniy 12";
                secondStudent.Faculty = " Languages";

            }
            var thirdStudent = new Student();
            {
                thirdStudent.Id = Guid.NewGuid();
                thirdStudent.FirstName = "Sevara";
                thirdStudent.LastName = "Saidova";
                thirdStudent.Age = 20;
                thirdStudent.Adress = "beruniy 24";
                thirdStudent.Faculty = "IT";
            }
            students.Add(firstStudent);
            students.Add(secondStudent);
            students.Add(thirdStudent);
        }
    }
}

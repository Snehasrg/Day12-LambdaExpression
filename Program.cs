namespace LambdaExpression
{
    public class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Day 12 Practice Problem on Lambda Expression");
            Console.WriteLine("Select any one option \n 1. add data to add Student\n" +
                " 2. Retrieve all record from the list for age between 12 to 18 using linq.\n" +
                " 3. Sort students data in descending order based on TotalMarks.\n" +
                 " 4. Display all the student records in each address.\n" +
                " 5. Fetch first three students records.");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    List<Student> students = StudentDataManagement.AddStudent();
                    StudentDataManagement.DisplayStudent(students);
                    break;

                case 2:
                    List<Student> students1 = StudentDataManagement.AddStudent();
                    List<Student> selectedStudent = students1.Where(s => s.Age >= 12 && s.Age <= 18).ToList();
                    StudentDataManagement.DisplayStudent(selectedStudent);
                    break;
                case 3:
                    List<Student> students2 = StudentDataManagement.AddStudent();
                    List<Student> OrderbyStudent = students2.OrderByDescending(s => s.Mark).ToList(); ;
                    StudentDataManagement.DisplayStudent(OrderbyStudent);
                    break;
                case 4:
                    List<Student> students3 = StudentDataManagement.AddStudent();
                    var GroupByAddress = students3.GroupBy(s => s.Address).ToList();
                    foreach (var group in GroupByAddress)
                    {
                        Console.WriteLine("Students with Address: " + group.Key);
                        Console.WriteLine("-----------------------");
                        StudentDataManagement.DisplayStudent(group.ToList());
                    }
                    break;

                case 5:
                    List<Student> students4 = StudentDataManagement.AddStudent();
                    List<Student> TopThreeStudent = students4.Take(3).ToList();
                    StudentDataManagement.DisplayStudent(TopThreeStudent);
                    break;

                default:
                    Console.WriteLine("Please select correct number");
                    break;
            }
        }
    }
}
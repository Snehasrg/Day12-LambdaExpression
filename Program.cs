namespace LambdaExpression
{
    public class program
    {
        public static void Main(string[] args)
        { 
            //Collection Initializer
            List<Student> list = new List<Student>()
            {
                //Object Initializer
                new Student() { Id=1,Name="Sidhu",Address="Pune",Age=18,TotalMarks=69},
                new Student() { Id = 3, Name = "Sidhu", Address = "Pune", Age = 18, TotalMarks = 69 },              
                new Student() { Id = 4, Name = "Nidhi", Address = "Mumbai", Age = 18, TotalMarks = 69 },
                new Student() { Id = 2, Name = "Ketki", Address = "Hyderabad", Age = 18, TotalMarks = 69 },
                new Student() { Id = 5, Name = "Praju", Address = "Pune", Age = 18, TotalMarks = 69 }

            };
            DisplayStudentDetails(list);
            StudentDataManagement.DisplayFrequencyofEachAddress(list);
            Console.ReadLine();
        }
        public static void DisplayStudentDetails(List<Student> list)
        {
            Console.WriteLine("Displaying All students");
            foreach(Student student in list)
            {
                Console.WriteLine(student);
            }
        }
    }
}
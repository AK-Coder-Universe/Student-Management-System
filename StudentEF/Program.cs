using StudentEF.Services;
class Program
{
    static void Main(string[] args)
    {
        StudentService service = new StudentService();

        int choice;
        do
        {
            Console.WriteLine("\n===Student Management System===");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Student");
            Console.WriteLine("3. Exit");

            Console.WriteLine("Enter Your Choice :");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    service.AddStudent();
                    break;

                case 2:
                    service.ViewStudent();
                    break;

                case 3:
                    Console.WriteLine("Exiting..");
                    break;

                default:
                    Console.WriteLine("Invalid Choices  ");
                    break;
            }
        } while (choice != 3);
    }
}
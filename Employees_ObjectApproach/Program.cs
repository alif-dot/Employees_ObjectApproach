using Employees_ObjectApproach;

namespace Employees_ObjectApproach
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("INPUTS\n======");
                Console.Write("\nID: ");
                string id = Console.ReadLine();
                Console.Write("First Name: ");
                string firstName = Console.ReadLine();
                Console.Write("Last Name: ");
                string lasttName = Console.ReadLine();
                Console.Write("Date of Birth (mm/dd/yyyy): ");
                DateTime birthDate = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Joining Date (mm/dd/yyyy): ");
                DateTime joiningDate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("\nDESIGNATIONS:\n============\n1. GM\n2. DGM\n3. AGM\n4. SM\n5. Manager\n6. Executive\n7. Assistant");
                Console.Write("\nInput any one serial number of the designations given above: ");
                int desigCode = Int32.Parse(Console.ReadLine());

                Employee anEmployee = new Employee(id, firstName, lasttName, birthDate, joiningDate, desigCode);
                Console.Write("\nGive roles of the employee (Seperate by comma[,]): ");
                string[] roles = anEmployee.GetRole(Console.ReadLine());

                Console.WriteLine("\n\nOUTPUTS\n=======");
                Console.WriteLine("\nEmployee ID: " + anEmployee.ID + "\nName: " + anEmployee.GetFullName() + "\nDate of Birth: " + anEmployee.BirthDate.ToShortDateString() + "\nJoining Date: " + anEmployee.JoiningDate.ToShortDateString() + "\nDesignation: " + anEmployee.Designation + "\nAge: " + anEmployee.GetAge() + "\n\nRole plays:\n==========");
                for (int i = 0; i < roles.Length; i++)
                {
                    Console.WriteLine((i + 1).ToString() + ". " + roles[i].Trim());
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

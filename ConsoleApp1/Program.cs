namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1=new Employee("Chamil","Jeewantha",25000.00);

            Employee employee2 = new Employee("pramindu", "vishwa", 28000.00);

            employee1.print(employee1.FirstName,employee1.LastName,employee1.BasicSalary);
         

        }
    }
}


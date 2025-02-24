// Written by Chloe Jensrud
// 2/24/2025

namespace EmployeeSpecializations
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee aEmployee1 = new Employee("Chloe", 128000);
            Employee aEmployee2 = new Employee("Emilynn", 115000);
            Employee aEmployee3 = new Employee("Marlee", 345000);


            Manager aManager1 = new Manager("Chloe", 100, 13);
            Manager aManager2 = new Manager("Emilynn", 115, 15);

            Engineer aEngineer = new Engineer("Marlee", 300, "Airplanes");

            Console.WriteLine(aEmployee1.ToString());
            Console.WriteLine(aEmployee2.ToString());
            Console.WriteLine(aEmployee3.ToString());

            Console.WriteLine(aManager1.ToString());
            Console.WriteLine(aManager2.ToString());
            Console.WriteLine(aEngineer.ToString());
        }
    }
}

namespace Assessment_Inheritance_
{
    public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
    }
    public class Manager:Employee
    {
        public int Bonus { get; set; }
        public Manager(string name,int salary, int bonus) : base(name, salary)
        {
            Bonus = bonus;
        }
    }

    //public class Program3
    //{
    //    public static void Main()
    //    {
    //        Employee e = new Employee("Vamshi", 500000);
    //        Console.WriteLine($"Name: {e.Name}, Salary: {e.Salary}");
    //        Manager m = new Manager("Sai", 500000, 10000);
    //        Console.WriteLine($"Name: {m.Name}, Salary: {m.Salary}, Bonus: {m.Bonus}");
    //    }
    //}
}

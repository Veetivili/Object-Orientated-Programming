namespace T15_Employee
{
    class Employee
    {
        public string EmployeeType { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }
        public string ShowData()
        {
            return $"{EmployeeType}: \n-Name: {Name} Profession: {Profession} Salary: {Salary}$";
        }
    }
    // Create new child class 'Manager' which inherits properties from parent class 'Employee'
    class Boss : Employee
    {
        public string Car { get; set; }
        public int SalaryBonus { get; set; }
        public string ShowData()
        {
            return $"{EmployeeType}: \n-Name: {Name} Profession: {Profession} Salary: {Salary}$ Car: {Car} Salary Bonus: {SalaryBonus}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize first employer object
            Employee employee = new Employee();
            employee.EmployeeType = "Employee";
            employee.Name = "John Doe";
            employee.Profession = "Frontend Developer";
            employee.Salary = 2400;
            Console.WriteLine(employee.ShowData());

            // Initialize manager object in manager class
            Boss manager = new Boss();
            manager.EmployeeType = "Manager";
            manager.Name = "Roger Moore";
            manager.Profession = "Project Manager";
            manager.Salary = 2800;
            manager.Car = "BMW";
            manager.SalaryBonus = 3200;
            Console.WriteLine(manager.ShowData());

            // Initialize second employer object
            Employee employee2 = new Employee();
            employee2.EmployeeType = "Employee";
            employee2.Name = "Sean Connery";
            employee2.Profession = "Senior FullStack Developer";
            employee2.Salary = 3200;
            Console.WriteLine(employee2.ShowData());
        }
    }
}
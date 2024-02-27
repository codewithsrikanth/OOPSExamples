namespace CAConstructors
{
    class Employee
    {
        int empId;string empName;double empSalary;
        //User-Defined Default Constructor
        public Employee()
        {
            empId = 101;
            empName = "Srikanth";
            empSalary = 12345;
        }
        //Paramterized Constructor
        public Employee(int id,string name,double salary)
        {
            empId = id;
            empName = name;
            empSalary = salary;
        }
        //Function/Method
        public void Display()
        {
            Console.WriteLine($"EmpID is: {empId}, EmpName is: {empName} and Salary: {empSalary}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Display();
            Employee emp2 = new Employee(102, "Diyansh", 98765);
            emp2.Display();
            Employee emp3 = new Employee(103, "Raju", 96858);
            emp3.Display();
        }
    }
}

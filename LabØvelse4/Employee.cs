namespace LabØvelse4
{
    public class Employee
    {
        public int EmployeeNumber { get; }
        public string Name { get; }
        public int MonthlySalary { get; private set; }

        public Employee()
        {
            EmployeeNumber = 1;
        }

        public void EditSalary(int NewSalary)
        {
            MonthlySalary = NewSalary;
        }
    }
}

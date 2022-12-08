namespace MVCEmployees.Models
{
    public class EmployeesService
    {
        static List<Employee> employees = new List<Employee> //statisk så att den inte förnyas och användarens svar sparas i listan
        {
            new Employee { ID = 1, Name = "Gibson", Email = "gibson.larsson@gmail.com"},
            new Employee { ID = 2, Name = "Taylor", Email = "taylor.gustavsson@gmail.com"},
            new Employee { ID = 3, Name = "Leif", Email = "leif.andersson@gmail.com"}
        };

        public void Add(Employee employee)
        {
            employee.ID = employees.Max(p => p.ID) + 1;
            employees.Add(employee);
        }
        public Employee[] GetAllEmployees()
        {
            return employees
                .OrderBy(p => p.ID)
                .ToArray();
        }
    }
}

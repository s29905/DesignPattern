// In case you need some guidance: https://refactoring.guru/design-patterns/adapter
namespace DesignPattern.Adapter
{
    public class EmployeeAdapter : ITarget
    {
        private readonly BillingSystem thirdPartyBillingSystem = new();

        public void ProcessCompanySalary(string[,] employeesArray)
        {
            List<Employee> employees = new();
            
            for (var i = 0; i < employeesArray.GetLength(0); i++)
            {
                var id = int.Parse(employeesArray[i, 0]);
                var name = employeesArray[i, 1];
                var designation = employeesArray[i, 2];
                var salary = decimal.Parse(employeesArray[i, 3]);
                
                employees.Add(new Employee(id, name, designation, salary));
            }
            
            thirdPartyBillingSystem.ProcessSalary(employees);
        }
    }
}
namespace SimpleInjectorSample
{
    public class EmployeeProcessor : IEmployeeProcessor
    {
        private readonly IEmployee _employee;
        public EmployeeProcessor(IEmployee employee)
        {
            _employee = employee;
        }

        public IEmployee Process()
        {
            return _employee;
        }
        public IEmployee UpdateEmployee(int Id, string Name)
        {
            _employee.Id = Id;
            _employee.Name = Name;
            return _employee;
        }
    }
}

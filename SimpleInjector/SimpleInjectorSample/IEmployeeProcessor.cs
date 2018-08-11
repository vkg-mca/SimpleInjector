namespace SimpleInjectorSample
{
    public interface IEmployeeProcessor
    {
        IEmployee Process();
        IEmployee UpdateEmployee(int Id, string Name);
    }
}

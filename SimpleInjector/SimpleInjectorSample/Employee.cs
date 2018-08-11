namespace SimpleInjectorSample
{
    public class Employee : IEmployee
    {
        public Employee(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }

}

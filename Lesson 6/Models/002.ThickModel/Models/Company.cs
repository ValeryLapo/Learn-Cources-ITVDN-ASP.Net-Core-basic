namespace _002.ThickModel.Models
{
    public class Company
    {
        public string Name { get; set; }
        public int Employees { get; set; }

        public Company(string name, int employees)
        {
            Name = name;
            Employees = employees;  
        }

        public string GetInfo()
        {
            return $"Name: {Name}, Employees: {Employees}";
        }
    }
}

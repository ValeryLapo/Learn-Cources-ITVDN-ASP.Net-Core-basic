using _001.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace _001.Models.Controllers
{
    public class HomeController: Controller
    {
        public string Index()
        {
            PlainModel model = new PlainModel()
            {
                Company="Microsoft",
                Employees = 100000,
                Salary = 10000
            };

            int totalSalary = model.Employees * model.Salary;
            string company = $"Company: {model.Company}\n";
            string employees = $"Employees: {model.Employees}\n";
            string salary = $"Total Salary: {totalSalary}\n";
            return company + employees + salary;
        }
    }
}

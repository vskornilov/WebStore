using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebStore.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebStore.CustomerController
{
    public class CustomerController : Controller
    {
        private readonly List<EmployeeView> _employeeViews = new List<EmployeeView>
        {
            new EmployeeView
            {
                Id=1,
                FirstName = "Иван",
                SurName = "Иванов",
                Patronymic = "Иванович",
                Age = 22
            },
                        new EmployeeView
            {
                Id=2,
                FirstName = "Владислав",
                SurName = "Петров",
                Patronymic = "Иванович",
                Age = 35
            }
        };

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(_employeeViews);
        }

        public IActionResult Details(int Id)
        {
            return View(_employeeViews.FirstOrDefault(x => x.Id == Id));
        }
    }
}
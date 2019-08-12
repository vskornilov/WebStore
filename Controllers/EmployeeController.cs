using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;
using System.Linq;
using WebStore.Infrastructure.Interfaces;

using WebStore.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebStore.EmployeeController
{
    [Route("Users")]
    public class EmployeeController : Controller
    {
        public IEmployeesData _employees { get; }

        public EmployeeController(IEmployeesData employees)
        {
            _employees = employees;
        }

        // GET: /<controller>/
        [Route("All")]
        public IActionResult Index()
        {
            return View(_employees.GetAll());
        }
        [Route("{id}")]
        public IActionResult Details(int id)
        {
            var employee = _employees.GetById(id);

            if (employee == null)
                return NotFound();

            return View(employee);
        }
        //GET
        [HttpGet]
        [Route("edit/{id?}")]
        public IActionResult Edit (int? id)
        {
            if (!id.HasValue)
            {
                return View(new EmployeeView());
            }

            EmployeeView model = _employees.GetById(id.Value);
            if(model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpPost]
        [Route("edit/{id?}")]
        public IActionResult Edit(EmployeeView model)
        {
            if (model.Id > 0)
            {
                var dbItem = _employees.GetById(model.Id);
                if (dbItem == null) return NotFound();
                dbItem.FirstName = model.FirstName;
                dbItem.SurName = model.SurName;
                dbItem.Age = model.Age;
                dbItem.Patronymic = model.Patronymic;
             }
            else
            {
                _employees.AddNew(model);
            }
            _employees.Commit();
            return RedirectToAction(nameof(Index));
            
        }

    }
}
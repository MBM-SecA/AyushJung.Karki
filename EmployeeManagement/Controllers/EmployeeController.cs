
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public ActionResult<string> Index()
    {
        
      var emp = Person.GetEmployees();
        return View(emp);
    }
    public ActionResult Detail([FromQuery] int Id)
    {
        var employees=Person.GetEmployees();
        Person employee=employees.FirstOrDefault(x=>x.Id==Id);
        return View(employee);
        
    }
  
    public ActionResult Add()
    {
        return View();
    }
    [HttpPost]
    public ActionResult<string> Add(Person person)
    {
return "Record saved";
    }
}


using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public ActionResult Index()
    {
       var employees = Employee.GetEmployees();
        return View(employees);
    }

    public ActionResult Detail(string firstName)
    {
        var employees = Employee.GetEmployees();
        var employee = employees.Where(x => x.Firstname == firstName).First();
        return View();
    }
}



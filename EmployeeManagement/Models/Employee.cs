using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Employee
{
    [Required(ErrorMessage = "Firstname required")]
    [Display(Name = "First Name")]

    public string FirstName { get; set; }

    [Required(ErrorMessage = "Lastname required")]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Address required")]
    [Display(Name = "Address")]
    public string Address { get; set; }

    [Required(ErrorMessage = "Gender required")]
    [Display(Name = "Gender")]
    public char Gender { get; set; }

    [Required(ErrorMessage = "Salary required")]
    [Display(Name = "Salary")]
    public double Salary { get; set; }

    public static List<Employee> GetEmployees()
    {
        var employee1 = new Employee()
        {
            FirstName = "Random",
            LastName = "Guy",
            Address = "NoLand",
            Salary = 00000

        };
        var employee2 = new Employee { FirstName = "Mark", LastName = "Pa", Address = "Ktm", Salary = 50000 };
        var employee3 = new Employee { FirstName = "Azyt", LastName = "Pan", Address = "lalitpur", Salary = 30000 };
        var employee4 = new Employee { FirstName = "Ajit", LastName = "Pand", Address = "bhaktapur", Salary = 15000 };
        var employee5 = new Employee { FirstName = "Azit", LastName = "Pande", Address = "hetauda", Salary = 4500 };
        var employee6 = new Employee { FirstName = "Ajeet", LastName = "Pandey", Address = "bhalubang", Salary = 21000 };

        var employees = new List<Employee> { employee1, employee2, employee3, employee4, employee5, employee6 };
        return employees;
    }
}
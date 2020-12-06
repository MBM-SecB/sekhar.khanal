using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Employee
{
     public int Id { get; set; }


    [Required(ErrorMessage = "First name is required.")]
    public string FirstName { get; set; }


    [Required(ErrorMessage = "Last name is required.")]
    public string Surname { get; set; }



    [Required(ErrorMessage = "Address is required.")]
    public string Address { get; set; }


    [Required(ErrorMessage = "Gender is required.")]
    public string Gender { get; set; }



    [Required(ErrorMessage = "Salary is required.")]
    public double Salary { get; set; }

}
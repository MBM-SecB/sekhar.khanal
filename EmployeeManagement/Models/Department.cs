using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Department
{

    public int Id { get; set; }

    [Required(ErrorMessage = "Start date is required.")]
    public DateTime StartDate { get; set; }


    [Required(ErrorMessage = "Department name is required.")]
    public string Name { get; set; }


    [Required(ErrorMessage = "Manager's name is required.")]
    public string ManagerName { get; set; }



    [Required(ErrorMessage = "Code is required.")]
    public string Code { get; set; }
}
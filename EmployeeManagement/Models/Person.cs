using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Person
{
    public int Id { get; set; }
    [Required]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }
    [Required]
    [Display(Name = "Last Name")]
    public string SurName { get; set; }
    public string Address { get; set; }
    public char Gender { get; set; } = 'M';
    public double Salary { get; set; }

    public static List<Person> GetEmployees()
    {

        //object initializer syntax
        Person p1 = new Person()
        {

            Id = 1,
            FirstName = "Ayush",
            SurName = "Karki",
            Address = "Kathmandu",
            Salary = 1000.0
        };

        Person p2 = new Person()
        {
            Id = 2,
            FirstName = "Anil",
            SurName = "Shrestha",
            Address = "Janakpur",
            Salary = 2050.0
        };
        Person p3 = new Person()
        {
            Id = 3,
            FirstName = "Zombi",
            SurName = "Karki",
            Address = "Hetauda",
            Salary = 2009.0
        };
        Person p4 = new Person()
        {
            Id = 4,
            FirstName = "Pranil",
            SurName = "Karki",
            Address = "Banepa",
            Salary = 250.0
        };
        Person p5 = new Person()
        {
            Id = 5,
            FirstName = "Sagar",
            SurName = "Karki",
            Address = "Dhading",
            Salary = 300.0
        };

        List<Person> employees = new List<Person>() { p1, p2, p3, p4, p5 };
        return employees;
    }

}

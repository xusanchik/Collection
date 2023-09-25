


using Collection.Enums;
using Collection.IRepositories;
using Collection.Models;
using Collection.Repositories;

List<Employee> people = new List<Employee>
{
    new Employee()
    {
        Id = 1,
        FirstName = "Husan",
        LastName = "Samadov",
        Email = "samadovhusan@gmail.com",
        Salary = 3450000,
        Gender = Gender.Male,
        Department = Department.Marketing,
        Address = new Address()
        {
            Id = 1,
            Country = "Uzbekistan",
            Street = "Old Town",
            HomeNumber = 3
        }
    },
    new Employee()
    {
        Id = 2,
        FirstName = "Aziz",
        LastName = "Lazizov",
        Email = "aziz@gmail.com",
        Salary = 3550000,
        Gender = Gender.Male,
        Department = Department.Education,
        Address = new Address()
        {
            Id = 2,
            Country = "China",
            Street = "Shoh street",
            HomeNumber = 3
        }
    },
    new Employee()
    {
        Id = 3,
        FirstName = "Ahmad",
        LastName = "Azizov",
        Email = "ahmad@gmail.com",
        Salary = 2350000,
        Gender = Gender.Male,
        Department = Department.Security,
        Address = new Address()
        {
            Id = 3,
            Country = "Uzbekistan",
            Street = "New Town",
            HomeNumber = 3
        }
    },
    new Employee()
    {
        Id = 4,
        FirstName = "Laziza",
        LastName = "Ahmadova",
        Email = "laziza@gmail.com",
        Salary = 1950000,
        Gender = Gender.Female,
        Department = Department.Adminstration,
        Address = new Address()
        {
            Id = 4,
            Country = "Uzbekistan",
            Street = "Town",
            HomeNumber = 4
        }
    },
    new Employee()
    {
        Id = 5,
        FirstName = "Laziz",
        LastName = "Azamatov",
        Email = "azamatov@gmail.com",
        Salary = 4450000,
        Gender = Gender.Male,
        Department = Department.Economy,
        Address = new Address()
        {
            Id = 5,
            Country = "Uzbekistan",
            Street = "Old Town",
            HomeNumber = 5
        }
    },
    new Employee()
    {
        Id = 6,
        FirstName = "Alisher",
        LastName = "Sadullayev",
        Email = "alisher@gmail.com",
        Salary = 1970000,
        Gender = Gender.Male,
        Department = Department.Adminstration,
        Address = new Address()
        {
            Id = 6,
            Country = "Russia",
            Street = "Cho'ntak",
            HomeNumber = 6
        }
    }
};

IEmployeeRepository employeeRepository = new EmployeeRepository();

var result = employeeRepository.GetInfoByEmail(people, "samadovhusan@gmail.com");

if (result is not null)
    Console.WriteLine($"{result.FirstName} {result.LastName} {result.Salary} {result.Department} {result.Address.Country}");

var ema = employeeRepository.Delete(people, people.Find(a => a.Id == 1));
Console.WriteLine(ema);
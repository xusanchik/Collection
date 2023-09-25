using Collection.IRepositories;
using Collection.Models;
using System.Collections.Generic;

namespace Collection.Repositories;

public class EmployeeRepository : IEmployeeRepository
{
    public bool Create(List<Employee> employees, Employee employee)
    {
        
        if (employee is null)
        {
            return false;
        }
        else
        {
            employees.Add(employee);
            return true;
        }
        
    }

    public bool Delete(List<Employee> employees, Employee employee)
    {
        if (employee is null)
        {
            return false;
        }
        else
        {
            employees.Remove(employee);
            return true;
        }
       
    }

    public IEnumerable<Employee> GetAll(List<Employee> employees)
    {
        
        return employees;
    }

    public Employee? GetInfoByEmail(List<Employee> employees, string email)
    {
        var employee = 
            employees.Find(p => p.Email.Equals(email));

        return employee;
    }

    public bool Update(List<Employee> employees, Employee employee)
    {
        if (employee is null)
        {
            return false;
        }
        else
        {
            var employ = employees.Find(p => p.Id.Equals(employee.Id));
            employ.Email = employee.Email;
            employ.Salary = employee.Salary;
            employ.Address = employee.Address;
            employ.LastName = employee.LastName;
            employ.FirstName = employee.FirstName;
            employ.Department = employee.Department;
            return true;
        }
    }
}

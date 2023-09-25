using Collection.Models;
using System;
namespace Collection.IRepositories;

public interface IEmployeeRepository
{
    Employee? GetInfoByEmail(List<Employee> employees, string email);

    IEnumerable<Employee> GetAll(List<Employee> employees);

    bool Create(List<Employee> employees, Employee employee);

    bool Update(List<Employee> employees, Employee employee);
    bool Delete(List<Employee> employees, Employee employee);





}

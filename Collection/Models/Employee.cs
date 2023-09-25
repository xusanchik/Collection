using Collection.Enums;

namespace Collection.Models;

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int Salary { get; set; }
    public Gender Gender { get; set; }
    public Department Department { get; set; }
    public Address Address { get; set; } = null!;
}

namespace Collection.Models;

public class Address
{
    public int Id { get; set; }
    public string Country { get; set; } = string.Empty;
    public string Street { get; set; } = null!;
    public int HomeNumber { get; set; }
}

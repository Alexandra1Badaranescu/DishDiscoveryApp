using Microsoft.AspNetCore.Mvc.ViewEngines;

public class Employee
{
    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Position { get; set; }
    public string ContactDetails { get; set; }
    public string WorkSchedule { get; set; }
    public ICollection<Recipe>? Recipes { get; set; }
}

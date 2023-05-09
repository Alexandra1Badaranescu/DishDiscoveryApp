public class Review
{
    public int ReviewId { get; set; }
    public DateTime Date { get; set; }
    public int Rating { get; set; }
    public string Comments { get; set; }

    public int MenuItemId { get; set; }
    public MenuItem ?MenuItem { get; set; }

    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
}

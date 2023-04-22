public class MenuItem
{
    public int MenuItemId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }
    public virtual ICollection<Ingredient>? Ingredients { get; set; }
    public virtual ICollection<Review>? Reviews { get; set; }

}


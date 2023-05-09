public class Ingredient
{
    public int IngredientId { get; set; }
    public string ?Name { get; set; }
    public string ?Description { get; set; }
    public int QuantityInStock { get; set; }
    public ICollection<MenuItem>? MenuItems { get; set; }
}

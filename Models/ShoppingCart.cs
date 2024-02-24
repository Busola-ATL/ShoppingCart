namespace ShoppingCart.Model;
public class ShoppingCart
{
    public int Id { get; set; } // Unique identifier for the shopping cart
    public User User { get; set; } // Reference to the user associated with the cart
    public List<Product> Products { get; set; } // List of products in the cart
}
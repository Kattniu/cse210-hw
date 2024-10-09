public class Product
{
    private string name;       // Nombre del producto
    private string productId;  // ID del producto
    private decimal price;      // Precio del producto
    private int quantity;       // Cantidad de productos

    public Product(string name, string productId, decimal price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity; // Inicializa el producto
    }

    public decimal GetTotalCost() // Método que calcula el costo total del producto
    {
        return price * quantity; // Multiplica el precio por la cantidad
    }

    public string GetProductId() // Método que devuelve el ID del producto
    {
        return productId; // Retorna el ID
    }

    public string GetName() // Método que devuelve el nombre del producto
    {
        return name; // Retorna el nombre
    }
}

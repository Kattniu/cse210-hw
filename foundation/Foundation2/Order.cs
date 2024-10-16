using System.Collections.Generic; // Necesario para usar List

public class Order
{
    private List<Product> products; // Lista de productos en el pedido
    private Customer customer;       // Cliente que realiza el pedido
    private const decimal USAShippingCost = 15.00m;   // Costo de envío para EE. UU.
    private const decimal InternationalShippingCost = 35.00m; // Costo de envío internacional

//constructor recibe un objeto de tipo Customer y lo asigna al atributo customer*
    public Order(Customer customer)
    {
        this.customer = customer; //Asigna el cliente al pedido
        products = new List<Product>(); // Inicializa la lista de productos
    }

    public void AddProduct(Product product) // Método para añadir un producto al pedido

    { //Aqui AddProduct esta declarando con void, que lo significa que no devuelve nada. 
      // su unico proposito es agregar un producto a la lista products
        products.Add(product); // recibe un objeto de tipo Product y los agrega a la lista productos (products) del pedido mediante products.Add(product)
    }

    public decimal CalculateTotalCost() // Método que calcula el costo total del pedido
    {
        decimal totalCost = 0;

        foreach (var product in products)
        {
            totalCost += product.GetTotalCost(); // Suma el costo de cada producto
        }

        // Añade el costo de envío
        if (customer.IsInUSA())
        {
            totalCost += USAShippingCost; // Costo de envío si está en EE. UU.
        }
        else
        {
            totalCost += InternationalShippingCost; // Costo de envío si está fuera de EE. UU.
        }

        return totalCost; // Retorna el costo total
    }

    public string GetPackingLabel() // Método que genera la etiqueta de empaque
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n"; // Agrega el producto a la etiqueta
        }
        return label; // Retorna la etiqueta
    }

    public string GetShippingLabel() // Método que genera la etiqueta de envío
    {
        string label = "Shipping Label:\n";
        label += $"{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}"; // Agrega la dirección del cliente
        return label; // Retorna la etiqueta
    }
}

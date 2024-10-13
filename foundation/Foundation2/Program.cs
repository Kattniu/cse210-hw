using System;

class Program
{
    static void Main(string[] args)
    {
        // Crea una dirección para el cliente
        Address address = new Address("Capecelatro 23", "Paderno", "MI", "USA");
        
        // Crea un cliente
        Customer customer = new Customer("Katherine Gonzales", address);
        
        // Crea un pedido
        Order order = new Order(customer);
        
        // Crea algunos productos
        Product product1 = new Product("Laptop", "P001", 999.99m, 1);
        Product product2 = new Product("Tablet", "P002", 25.50m, 2);
        
        // Añade productos al pedido
        order.AddProduct(product1);
        order.AddProduct(product2);
        
        // Calcula el costo total
        decimal totalCost = order.CalculateTotalCost();
        
        // Muestra resultados
        Console.WriteLine(order.GetPackingLabel()); // Muestra la etiqueta de empaque
        Console.WriteLine(order.GetShippingLabel()); // Muestra la etiqueta de envío
        Console.WriteLine($"Total Cost: {totalCost:C}"); // Muestra el costo total
    }
}

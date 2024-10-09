public class Customer
{
    private string name;       // Nombre del cliente
    private Address address;    // Dirección del cliente

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address; // Inicializa el objeto Address
    }

    public bool IsInUSA() // Método que verifica si el cliente vive en los EE. UU.
    {
        return address.IsInUSA(); // Llama al método de Address
    }

    public string GetName() // Método que devuelve el nombre del cliente
    {
        return name; // Retorna el nombre
    }

    public Address GetAddress() // Método que devuelve la dirección del cliente
    {
        return address; // Retorna la dirección
    }
}

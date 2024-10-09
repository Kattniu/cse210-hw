public class Address
{
    private string street;  // Calle
    private string city;    // Ciudad
    private string state;   // Estado/Provincia
    private string country;  // País

    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public bool IsInUSA() // Método que verifica si la dirección está en los EE. UU.
    {
        return country.ToLower() == "usa"; // Compara el país
    }

    public string GetFullAddress() // Método que devuelve la dirección completa
    {
        return $"{street}\n{city}, {state}\n{country}"; // Formatea la dirección
    }
}

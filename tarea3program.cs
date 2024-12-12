public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Unidad { get; set; }
    public Precio[] Precios { get; set; }

    public Producto(int id, string nombre, string unidad, Precio[] precios)
    {
        Id = id;
        Nombre = nombre;
        Unidad = unidad;
        Precios = precios;
    }
}

public class Precio
{
    public string Tipo { get; set; }
    public decimal Valor { get; set; }

    public Precio(string tipo, decimal valor)
    {
        Tipo = tipo;
        Valor = valor;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear un arreglo de precios
        Precio[] precios = new Precio[]
        {
            new Precio("Precio de venta", 100.00m),
            new Precio("Precio de costo", 80.00m),
            new Precio("Precio de oferta", 90.00m)
        };

        // Crear un producto
        Producto producto = new Producto(1, "Producto 1", "Unidad", precios);

        // Mostrar los datos del producto
        Console.WriteLine("Id: " + producto.Id);
        Console.WriteLine("Nombre: " + producto.Nombre);
        Console.WriteLine("Unidad: " + producto.Unidad);

        // Mostrar los precios del producto
        foreach (Precio precio in producto.Precios)
        {
            Console.WriteLine("Tipo: " + precio.Tipo + ", Valor: " + precio.Valor);
        }
    }
}

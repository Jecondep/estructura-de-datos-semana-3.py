public class Producto
public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Unidad { get; set; }
    public decimal[] Precios { get; set; }

    public Producto(int id, string nombre, string unidad, decimal[] precios)
    {
        Id = id;
        Nombre = nombre;
        Unidad = unidad;
        Precios = precios;
    }

    public void AgregarPrecio(decimal precio)
    {
        if (Precios.Length < 3)
        {
            Array.Resize(ref Precios, Precios.Length + 1);
            Precios[Precios.Length - 1] = precio;
        }
        else
        {
            throw new InvalidOperationException("No se pueden agregar más de tres precios");
        }
    }

    public void EliminarPrecio(int indice)
    {
        if (indice >= 0 && indice < Precios.Length)
        {
            Array.Copy(Precios, indice + 1, Precios, indice, Precios.Length - indice - 1);
            Array.Resize(ref Precios, Precios.Length - 1);
        }
        else
        {
            throw new IndexOutOfRangeException("Índice fuera de rango");
        }
    }

    public override string ToString()
    {
        return $"Id: {Id}, Nombre: {Nombre}, Unidad: {Unidad}, Precios: {string.Join(", ", Precios)}";
    }
}
	}
}
namespace Proyecto_1_PC;

public class Cliente
{
    public string nombre;
    public int nit;
    public Cliente() // constructor
    {
        nombre = "";
        nit = 0;
    }

    /**
    * @summary Solicita la informacion del cliente
    */
    public void brindarDatoscliente()
    {
        Console.WriteLine("Escriba su Nombre:");
        nombre = Console.ReadLine();    //Guardamos el nombre del cliente

        Console.WriteLine("Escriba su Nit:");
        nit = int.Parse(Console.ReadLine());    //Guardamos el nit del cliente
    }

    /**
    * @summary Muestra la informacion del cliente
    */
    public void mostrarDatoscliente()
    {
        Console.WriteLine("Información cliente: ");
        Console.WriteLine(nombre);
        Console.WriteLine("Nit: " + nit);
    }
}

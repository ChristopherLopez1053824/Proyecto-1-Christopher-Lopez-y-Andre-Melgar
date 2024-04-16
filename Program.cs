using Proyecto_1_PC;
// Participantes Christopher Lopez 1053824, Andre Melgar 1238524
//Proyecto Numero 01
// 14 de abril del 2024
Console.WriteLine("---------------Bienvenidos a la cafeteria!!!-----------------");
Console.WriteLine("El menu del dia es un batido de fresa cuyo valor es de Q20.00 ☜(ﾟヮﾟ☜)");
Console.WriteLine("-------------------------------------------------------------");
Console.WriteLine("             Por favor ingrese sus datos  👀👀");
Cliente objcliente = new Cliente(); //Llamamos a la clase cliente y lo convertimos en objetox
Batido objbatido = new Batido();    //Llamamis a la clase batido y creamos un objeto
DateTime fecha = @DateTime.Now.AddYears(1); //Guardamos en un variable la fecha de inicio
objcliente.brindarDatoscliente();   //Llamamos a la funcion de brindar datos cliente
objbatido.muestraInformacionBatido(); //Llamamos a la funcion que muestra los datos del batido
Console.ReadKey();
int opcionSeleccionada; //Creamos la variable que guardara la opcion del menu de edicion de batido
do //mostrar el menu todas las veces a menos que confirmemos
{
    Console.WriteLine("-------------------------------------------------------------");
    Console.WriteLine("Escoja la opcion que desee 🥤");
    Console.WriteLine("1.Ver infromacion del pedido");
    Console.WriteLine("2.Agregar azucar");
    Console.WriteLine("3.Modificar Leche");
    Console.WriteLine("4.Agrandar");
    Console.WriteLine("5.Confirmar");
    opcionSeleccionada = int.Parse(Console.ReadLine()); //Preguntamos La opcion y que la almacene en esta vriable
    switch (opcionSeleccionada)
    {
        case 1: //Ver la informacion del pedido
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("-----------------Informacion del pedido 👀🥤--------------------");
            Console.WriteLine("Fecha " + fecha);    //Mostramos la fecha de inicio
            objbatido.calcularPrecioBatido();   //LLamamos a la funcion de calculo del precio del batido
            objbatido.muestraInformacionBatido(); //Llamamos a la funcion mostrar informacion del batido
            break;
        case 2: //Agregamos el azucar
            objbatido.cambiarTipoAzucar(); //Llamamos a la funcion que cambiara el azucar
            break;
        case 3: //Cambiamos el tipo de leche
            objbatido.cambiarTipoLeche();   //Llamamos a la opcion que cambiara el tipo de leche
            break;
        case 4: //Agrandamos el batido
            objbatido.agrandar();    // Llamamos a la funcion que preguntara si agrandamos o no el batido
            break;
        case 5: //Creamos factura
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("------------------------Factura------------------------------");
            Console.WriteLine("Fecha " + fecha);    //Mostramos la fecha de inicio
            objbatido.calcularPrecioBatido(); //Calculamos el precio del batido
            objbatido.muestraInformacionBatido(); //Mostramos la informacion del batido
            Console.WriteLine("Fecha de finalizacion " + @DateTime.Now.AddYears(1));    //Mostramos la fecha de finalizacion
            Console.WriteLine("Pedido confirmado"); //Mostramos que el pedido fue confirmado
            Console.WriteLine("Recoja su producto en la casilla");
            break;
        default:
            Console.WriteLine("uy!!! opcion invalida");
            break;
    }
}
while (opcionSeleccionada != 5);


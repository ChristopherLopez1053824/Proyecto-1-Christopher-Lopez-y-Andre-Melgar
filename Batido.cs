namespace Proyecto_1_PC;

public class Batido
{
        public double precioBatido; //Creamos una variable que sumara cada precio del batido
        const double precioBaseBatido = 20; //Creamos una variable con el precio del batido original
        // Variables azucar
        public int cucharadasAzucarMorena;  //Creamos variable que contara las cucharadas
        public int cucharadasAzucarBlanca;  //Creamos variable que contara la cucharadas blanca
        public int cucharadasAzucarSuplemento; //Creamos variable que contara las cucharadas del suplemento

        const double precioAzucarMorena = 0.40; //Guardamos el precio del azucar
        const double precioAzucarBlanca = 0.50; //Guaardamos el precio de azucar morena
        const double precioAzucarSuplemento = 0.60; //Guardamos el precio del azucar espelenda

        const int limiteAzucarMorena = 3;   //Creamos una variable con el limite de cucharadas
        const int limiteAzucarBlanca = 3;   //Creamos una variable con el limite de cucharadas
        const int limiteAzucarSuplemento = 3;   //Creamos una variable con el limite de cucharadas

        //variables leche
        const double precioLecheSoya = 3;   //Creamos precio para la leche de soya
        const double precioSinLeche = -2;   //Creamos variable para un batido sin leche
        public string tipoLeche;    //Creamos variable para el tipo de leche

        //Variables para garandar 
        public bool agrandado;
        const double porcentajeAgrandado = 0.07;
        public double precioAgrandado;
        public Batido() //constructor
        {
            precioAgrandado = 0;
            precioBatido = precioBaseBatido;
            cucharadasAzucarMorena = 0;
            cucharadasAzucarBlanca = 0;
            cucharadasAzucarSuplemento = 0;
            tipoLeche = "Leche entera";
            agrandado = false;
        }
        public void cambiarTipoAzucar() //Cambiamos el tipo de azucar para el batido
        {
            int azucarSeleccionada;
            do
            {
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("------------Escoja el tipo de azucar que desee 🍬------------");
                Console.WriteLine("1.Agregar 1 cucharada de azucar blanca Q5.00");
                Console.WriteLine("2.Agregar 1 cucharada de azacuar Morena Q0.40");
                Console.WriteLine("3.Agregar 1 cucharada de azucar sintetica Q0.60");
                Console.WriteLine("4.Salir");
                azucarSeleccionada = int.Parse(Console.ReadLine()); //Preguntamos opcion para el tipo de azucar deseada
                switch (azucarSeleccionada)
                {
                    case 1: //Azucar blanca
                        if (cucharadasAzucarBlanca <= limiteAzucarBlanca)
                        {
                            Console.WriteLine("------------------Se le agragara 1 cucharada de azucar blanca---------------");
                            cucharadasAzucarBlanca++;
                        }
                        else
                        {
                            Console.WriteLine("!!!!!!!!!!!Ya no hay mas cucharadas restantes!!!!!!!!!!!!!!!");
                        }
                        break;
                    case 2: //Azucar Morena
                        if (cucharadasAzucarMorena <= limiteAzucarMorena)
                        {
                            Console.WriteLine("------------------Se le agragara 1 cucharada de azucar morena---------------");
                            cucharadasAzucarMorena++;
                        }
                        else
                        {
                            Console.WriteLine("!!!!!!!!!!!Ya no hay mas cucharadas restantes!!!!!!!!!!!!!!!");
                        }
                        break;
                    case 3: //Azucar esplenda
                        if (cucharadasAzucarSuplemento <= limiteAzucarSuplemento)
                        {
                            Console.WriteLine("------------------Se le agragara 1 cucharada de azucar blanca---------------");
                            cucharadasAzucarSuplemento++;
                        }
                        else
                        {
                            Console.WriteLine("!!!!!!!!!!!Ya no hay mas cucharadas restantes!!!!!!!!!!!!!!!");
                        }
                        break;
                    case 4: //Salir de las opciones
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("uy!!! opcion invalida");
                        break;
                }

            } while (azucarSeleccionada != 4);

        }
        public void cambiarTipoLeche()  //Cambiamos la leche deseada
        {
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("------------Escoja el tipo de leche que desee 🍼--------------");
            Console.WriteLine("1.Sin leche uncamente con agua");
            Console.WriteLine("2.Leche deslactosada");
            Console.WriteLine("3.Leche entera");
            Console.WriteLine("4.Leche de soya");
            int lecheSeleccionada = int.Parse(Console.ReadLine());  //Guardamos la opcion de tipo de leche
            switch (lecheSeleccionada)
            {
                case (1):
                    Console.WriteLine("------------Se le agregar unicamente agua----------------");
                    tipoLeche = "Solamente Agua";   //Guardamos en la variable de tipo de leche la leche deseada
                    break;
                case (2):
                    Console.WriteLine("------------Se le agregara leche deslactosada----------------");
                    tipoLeche = "Leche deslactosada";   //Guardamos en la variable de tipo de leche la leche deseada
                    break;
                case (3):
                    Console.WriteLine("-----------------Se le agregar leche entera------------------");
                    tipoLeche = "Leche entera"; //Guardamos en la variable de tipo de leche la leche deseada
                    break;
                case (4):
                    Console.WriteLine("-----------------Se le agregar leche de soya----------------");
                    tipoLeche = "Leche de soya";    //Guardamos en la variable de tipo de leche la leche deseada
                    break;
                default:
                    Console.WriteLine("-----------------Opcion inexistente----------------");
                break;
            }
        }
        public void agrandar()  //Agrandamos el batido
        {
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("-----------------Desea agrandar su pedido--------------------");
            Console.WriteLine("1.Si");
            Console.WriteLine("2.No");
            int seleccionAgrandado = int.Parse(Console.ReadLine()); //Guardamos en una variable si desea agrandar o no
            switch (seleccionAgrandado)
            {
                case (1):   //Si quiere agrandar su pedido
                    Console.WriteLine("Se le agrgara un monto de 7% extra de su precio total");
                    agrandado = true;   //Cambiamos el agrandado a verdadero
                    break;
                case (2):   //Si no quiere agrandar su producto
                    Console.WriteLine("El batido quedara en su tamaño original");
                    agrandado = false;  //Cambiamos el agrandado a falso
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }
        }
        public void calcularPrecioBatido()  //Calculamos precio del batido
        {
            //Sumamos dependiendo que cuharadas quiere y del tipo de azucar
            precioBatido = precioBaseBatido + (cucharadasAzucarMorena * precioAzucarMorena);
            precioBatido = precioBatido + (cucharadasAzucarBlanca * precioAzucarBlanca);
            precioBatido = precioBatido + (cucharadasAzucarSuplemento * precioAzucarSuplemento);
            //Observamos el tipo de leche que desea para cambair el precio por la leche
            if (tipoLeche == "Leche de soya")
            {
                precioBatido = precioBatido + precioLecheSoya;
            }
            if (tipoLeche == "Solamente Agua")
            {
                precioBatido = precioBatido + precioSinLeche;
            }
            //Verificamos si quiere agrandar para aumentr el precio
            if (agrandado == true)
            {
                precioAgrandado = precioBatido * porcentajeAgrandado;
            }
            //Calculamos el precio total del batido

            precioBatido = precioBatido + precioAgrandado;

        }
        public void muestraInformacionBatido()  //Imprimimos todos los datos de nuestro batido
        {
            //Mostramos los precios del batido
            Console.WriteLine("Informacion del batido: ");
            Console.WriteLine(String.Format("{0:#,##0.00}", precioBaseBatido) + " Precio base ");
            Console.WriteLine(String.Format("{0:#,##0.00}", precioAzucarBlanca * cucharadasAzucarBlanca) + " Azucar blanca " + cucharadasAzucarBlanca + " cucharadas ");
            Console.WriteLine(String.Format("{0:#,##0.00}", precioAzucarMorena * cucharadasAzucarMorena) + " Azucar morena " + cucharadasAzucarMorena + " cucharadas ");
            Console.WriteLine(String.Format("{0:#,##0.00}", precioAzucarSuplemento * cucharadasAzucarSuplemento) + " Azucar suplemento " + cucharadasAzucarSuplemento + " cucharadas ");
            //Dependiendo el tipo de leche es la varibale que mostrara           
            if (tipoLeche == "Leche de soya")
            {
                Console.WriteLine(String.Format("{0:#,##0.00}", precioLecheSoya) + " Leche soya ");
            }
            if (tipoLeche == "Leche deslactosada")
            {
                Console.WriteLine("0.00" + " Leche deslactosada ");
            }
            if (tipoLeche == "Leche entera")
            {
                Console.WriteLine("0.00" + " Leche entera ");
            }
            if (tipoLeche == "Solamente Agua")
            {
                Console.WriteLine(String.Format("{0:#,##0.00}", precioSinLeche) + " Batido sin leche ");
            }
            //Si lo agrando aparecera el precio del agrandado
            if (agrandado == true)
            {
                Console.WriteLine(String.Format("{0:#,##0.00}", precioAgrandado) + " Batido grande ");
            }
            else
            {
                Console.WriteLine("0.00" + " Batido pequeño ");

            }
            Console.WriteLine(String.Format("{0:#,##0.00}", precioBatido) + " Total ");

        }
    }

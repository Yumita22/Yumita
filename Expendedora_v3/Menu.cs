using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Expendedora2;


namespace Expendedora_v1
{

    
    public class Menu
    {
        public void Mostrar()
        {
            Maqexp exp = new Maqexp(50, "Yumi");

            Inicio();
            while (true)
            {
                //(Cada caso de uso es un menú en la consola)
                Console.WriteLine();
                Console.WriteLine("Menu");
                Console.WriteLine("1] Mostrar latas disponibles");
                Console.WriteLine("2] Insertar lata");
                Console.WriteLine("3] Extraer lata");
                Console.WriteLine("4] Balance");
                Console.WriteLine("5] Stock");
                Console.WriteLine("6] Salir");

                Console.Write("Seleccione una opcion");
                string opcion = Console.ReadLine();

                //switch (opcion)
                //{
                //    case "1":
                //        Console.WriteLine("Latas disponibles:\n 1] CO1 - Coca Cola Regular\n2] CO2 - Coca Cola Zero\n3] SP1 - Sprite Regular\n4] SP2 - Sprite Zero\n5] FA1 - Fanta Regular \n6]+ FA2 - Fanta Zero");
                //        break;
                //    case "2":
                //        Program.AgregarLata(exp);
                //        break;
                //    case "3":
                //        Program.ExtraerLata(exp);
                //        break;
                //    case "4":
                //        Program.ObtenerBalance(exp);
                //        break;
                //    case "5":
                //        Program.MostrarStock(exp);
                //        break;
                //    //case "6":
                //      //  Console.WriteLine("Gracias por usar la expendedora de Yumi, vuelva prontos");
                //        //break;
                //}

                if (opcion == "1")
                {
                    Console.WriteLine("Latas disponibles:\n1] CO1 - Coca Cola Regular\n2] CO2 - Coca Cola Zero\n3] SP1 - Sprite Regular\n4] SP2 - Sprite Zero\n5] FA1 - Fanta Regular \n6] FA2 - Fanta Zero");
                }
                else if (opcion == "2")
                {
                    Program.AgregarLata(exp);
                }
                else if (opcion == "3")
                {
                    Program.ExtraerLata(exp);
                }
                else if (opcion == "4")
                {
                    Program.ObtenerBalance(exp);
                }
                else if (opcion == "5")
                {
                    Program.MostrarStock(exp);
                }
                else if (opcion == "6")
                {
                    Console.WriteLine("Gracias por usar la expendedora de Yumi, vuelva prontos");
                    break;
                }
                else { Console.WriteLine("La opción ingresada no es correcta"); }
            }
        }

        private static void Inicio()
        {
            Console.WriteLine("Máquina expendedora de Yumi");
        }
    }
}

    


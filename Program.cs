using System.Threading.Tasks.Dataflow;
using New_Products;
using Delete_products;
using inventary;
using Edit_products;
using Total_prices;

namespace Cnet.consola
{

    class Program
    {
        static void Main(string[] args)
        {

            bool exit = false;
            while (exit == false)
            {   
                Console.WriteLine("\nBienvenido a su sistema de gestion comercial");
                Console.WriteLine("Selecione la accion que desea ejecutar: ");
                Console.WriteLine("1)Ver Productos");
                Console.WriteLine("2)Calcular valor total de Productos");
                Console.WriteLine("3)Añadir productos");
                Console.WriteLine("4)Eliminar Productos");
                Console.WriteLine("5)Editar inventario");
                Console.WriteLine("6) Salir");
                Console.WriteLine("Selecione la accion que desea ejecutar: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Product_list.list();
                        break;
                    case "2":
                        Total_price_quantity.total();
                    break;
                    case "3":
                        Create_Products.Create();
                        break;
                    case "4":
                        Delete_product.Delete();
                        break;
                    case "5":
                        Edit_inventory.Edit();
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }

        }

    } 

}
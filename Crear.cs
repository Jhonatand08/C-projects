using Types_of_products;
using System.IO;

namespace New_Products
{
    class Create_Products
    {
        public static void Create()
        {

            decimal Product_price;
            Int32 Product_quantity;

            Console.WriteLine("Nombre del producto");
            String Product_name = Console.ReadLine();  
                 Console.WriteLine("Cantidad de unidades");
            while (!Int32.TryParse(Console.ReadLine(), out Product_quantity))
            {
                Console.WriteLine("Error: Ingrese una cantidad valida");
                Console.Write("Valor del producto: ");
            }
            Console.WriteLine("valor del producto");
            while (!decimal.TryParse(Console.ReadLine(), out Product_price))
            {
                Console.WriteLine("Error: Ingrese un valor numérico válido para el precio.");
                Console.Write("Valor del producto: ");
            }

            Product Product_to_add = new Product(Product_name, Product_quantity, Product_price);
            Console.WriteLine("\n--- Producto Registrado Correctamente ---\n");
            Console.WriteLine("Nombre: " + Product_name + "\n" +"Precio: " + Product_price + "\n" + "Cantidad: " + Product_quantity);

            StreamWriter write = new StreamWriter("/workspaces/dotnet-codespaces/CNetConsole/products.txt" , true);
            write.WriteLine(Product_to_add);
            write.Close();
            
        }
    }

}
using System.IO;
using System.Threading.Tasks.Dataflow;

namespace Delete_products
{

    public class Delete_product
    {

        public static void Delete()
        {
            Console.WriteLine("Que producto desea eliminar");
            String To_Delete = Console.ReadLine();
            StreamReader reader = new StreamReader("/workspaces/dotnet-codespaces/CNetConsole/products.txt");

            string line = reader.ReadLine();
            string word = line.ToLower();
            bool In_products = false;
            List<string> temporal_list = new List<string>();

            while (line != null)
            {
                word = line.ToLower();
                if (word.Contains(To_Delete.ToLower()) == true)
                {
                    Console.WriteLine("Producto que desea eliminar: " + word);
                    Console.WriteLine("Seleccione si desea continuar");
                    Console.WriteLine("1) Si");
                    Console.WriteLine("2) No");
                    string confirm = Console.ReadLine();

                    switch (confirm) {
                        case "1":
                            Console.WriteLine("Producto eliminado: " + word);
                            In_products = true;
                            break;
                        case "2":
                        temporal_list.Add(line);
                            break;
                        default:
                            Console.WriteLine("Opcion no valida");
                            temporal_list.Add(line);
                        break;
                    }
                    
                }
                else
                {
                    temporal_list.Add(line);
                }
                line = reader.ReadLine();
            }
            
            reader.Close();
            if (In_products == true)
            {
                StreamWriter write = new StreamWriter("/workspaces/dotnet-codespaces/CNetConsole/products.txt");
                foreach (string item in temporal_list)
                {
                    write.WriteLine(item);
                }
                write.Close();
            }

            else
            {
                Console.WriteLine("El producto no esta en la lista");
            }

        }
    }

}
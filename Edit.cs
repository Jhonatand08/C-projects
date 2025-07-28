using Types_of_products;

namespace Edit_products
{
    public class Edit_inventory
    {

        public static void Edit()
        {
            Console.WriteLine("Que producto desea editar");
            String To_edit = Console.ReadLine();
            StreamReader reader = new StreamReader("/workspaces/dotnet-codespaces/CNetConsole/products.txt");

            string line = reader.ReadLine();
            string word = line.ToLower();
            bool In_products = false;
            List<string> temporal_list = new List<string>();

            while (line != null)
            {
                word = line.ToLower();
                if (word.Contains(To_edit.ToLower()) == true)
                {
                    string[] product_to_edit = line.Split(',');
                    Console.WriteLine("Producto que desea editar: " + word);
                    Console.WriteLine("\nSeleccione opcion a editar");
                    Console.WriteLine("1) Nombre");
                    Console.WriteLine("2) Cantidad");
                    Console.WriteLine("3) Precio");
                    string edit_option = Console.ReadLine();
                    bool valid_option = false;

                    switch (edit_option)
                    {

                        case "1":
                            Console.WriteLine("Introduca el nuevo Nombre: ");
                            string new_name = (product_to_edit[0] = Console.ReadLine());
                            valid_option = true;
                            break;
                        case "2":
                            Console.WriteLine("Introduca la nueva Cantidad: ");
                            Int32 new_quantity;
                            while (!Int32.TryParse(Console.ReadLine(), out new_quantity)) ;
                            product_to_edit[1] = new_quantity.ToString();
                            valid_option = true;
                            break;
                        case "3":
                            Console.WriteLine("Introduca el nuevo Precio: ");
                            decimal new_price;
                            while (!decimal.TryParse(Console.ReadLine(), out new_price)) ;
                            product_to_edit[2] = new_price.ToString();
                            valid_option = true;
                            break;
                        default:
                            Console.WriteLine("Opcion no valida");
                            valid_option = false;
                            break;
                    }
                    if (valid_option == true)
                    {
                        Console.WriteLine("Producto a editar: " + line);
                        Console.WriteLine("Seleccione si desea continuar");
                        Console.WriteLine("1) Si");
                        Console.WriteLine("2) No");
                        string confirm = Console.ReadLine();

                        switch (confirm)
                        {
                            case "1":
                                string product_edited = String.Join(",", product_to_edit);
                                temporal_list.Add(product_edited);
                                Console.WriteLine("Producto a editado correctamente: " + product_edited);
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
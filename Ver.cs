namespace inventary{

    public class Product_list
    {

        public static void list()
        {

            Console.WriteLine("1) Ver todos los productos");
            Console.WriteLine("2) Buscar producto");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    {
                        StreamReader reader = new StreamReader("/workspaces/dotnet-codespaces/CNetConsole/products.txt");
                        string product_in_line = reader.ReadLine();

                        while (product_in_line != null)
                        {
                            Console.WriteLine(product_in_line);
                            product_in_line = reader.ReadLine();
                        }
                        reader.Close();
                        break;
                    }
                case "2":
                    {
                        StreamReader reader = new StreamReader("/workspaces/dotnet-codespaces/CNetConsole/products.txt");
                        string product_in_line = reader.ReadLine();

                        Console.WriteLine("Que producto desea buscar: ");
                        string search_product = Console.ReadLine();
                        bool product_exist = false;

                        while (product_in_line != null)
                        {
                            string product_to_compare = product_in_line.ToLower();

                            if (product_to_compare.Contains(search_product.ToLower()) == true)
                            {
                                Console.WriteLine("Producto encontrado: " + product_in_line);
                                product_exist = true;
                                break;
                            }
                            else
                            {
                                product_in_line = reader.ReadLine();
                            }
                            reader.Close();
                        }
                        if (product_exist == false)
                        {
                            Console.WriteLine("El producto no existe, si deseas puedes crearlo :D");
                        }

                        break;
                    }
                default:
                    Console.WriteLine("Producto no valido: ");
                    break;
            }
          
        }   
    }

}
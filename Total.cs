namespace Total_prices
{

    public class Total_price_quantity
    {
        public static void total()
        {
        
      

            Console.WriteLine("Selecione la accion que desea ejecutar: ");
            Console.WriteLine("1) Ver valor total de un producto: ");
            Console.WriteLine("2) Ver el valor total de todos los productos: ");

            bool product_exist = false;
            string option_selected = Console.ReadLine();
            
            switch (option_selected)
            {
                case "1":
                    {
                    using (StreamReader reader = new StreamReader("/workspaces/dotnet-codespaces/CNetConsole/products.txt")){
                    string product_in_line = reader.ReadLine();
                    string search_product = Console.ReadLine();

                            while (product_in_line != null)
                            {
                                string product_to_compare = product_in_line.ToLower();

                                if (product_to_compare.Contains(search_product.ToLower()) == true)
                                {
                                    string[] product_to_evaluate = product_in_line.Split(',');
                                    decimal product_quantity;
                                    decimal product_price;

                                    if ((decimal.TryParse(product_to_evaluate[1], out product_quantity))
                                    && (decimal.TryParse(product_to_evaluate[2], out product_price)))
                                    {
                                        Console.WriteLine("Producto encontrado: " + product_in_line);
                                        decimal product_total_price = product_quantity * product_price;
                                        Console.WriteLine("El Valor total del producto es: " + product_total_price);
                                        product_exist = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ha habido un error, la operacion no se puede completar");
                                    }

                                    break;
                                }
                                else
                                {
                                    product_in_line = reader.ReadLine();
                                }
                            }
                        }
                        if (product_exist == false){
                        Console.WriteLine("El producto no existe, si deseas puedes crearlo :D");
                     }
                        }
                break;

                case "2":
                    {

                        using (StreamReader reader = new StreamReader("/workspaces/dotnet-codespaces/CNetConsole/products.txt"))
                        {
                            string product_in_line = reader.ReadLine();
                            decimal Total_sum_prices = 0;

                            while (product_in_line != null)
                            {
                                string[] product_to_evaluate = product_in_line.Split(',');
                                decimal product_quantity;
                                decimal product_price;

                                if ((decimal.TryParse(product_to_evaluate[1], out product_quantity))
                                && (decimal.TryParse(product_to_evaluate[2], out product_price)))
                                {
                                    decimal product_total_price = product_quantity * product_price;
                                    Total_sum_prices = Total_sum_prices + product_total_price;
                                    product_exist = true;
                                }
                                else
                                {
                                    Console.WriteLine("Ha habido un error, la operacion no se puede completar");
                                }
                                product_in_line = reader.ReadLine();
                            }
                        Console.WriteLine("El Valor total del inventario es: " + Total_sum_prices);
                        }
                    }
                break;

                default:
                    Console.WriteLine("El producto no es valido");
                break;

            }
        }
    }

}
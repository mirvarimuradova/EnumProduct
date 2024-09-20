


using EnumProduct;



Categories mobile = Categories.mobile;
Categories pc = Categories.pc;

Product product2 = new Product("Iphone", " 14 plus", 2000, 5, mobile);

ProductsController controller = new ProductsController();

controller.AddProduct(product2);


restart:
Console.Clear();
Console.WriteLine("Choose the section:\n" +
    "1.Add product\n" +
    "2.Show all product\n" +
    "3.Total price \n" +
    "4.Total price by category\n" +
    "5.Show products by category\n" +
    "6.Update product\n" +
    "7.Total quantity \n" +
    "8.Sell product");



string temp = Console.ReadLine()??"";

if (temp == "1")
{
    Console.Write("Brand:");
    string brand = Console.ReadLine()??"";

    Console.Write("Model:");
    string model = Console.ReadLine()??"";

    Console.Write("Price:");
    decimal price = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Quantity:");
    int quantity = Convert.ToInt32(Console.ReadLine());

    Console.Write("Category(pc/mobile):");
    string category = Console.ReadLine()??"";

    Categories currentcategory = Categories.pc;
    category.ToLower();
    if (category == "pc")
    {
        currentcategory = Categories.pc;
    }
    else if (category == "mobile")
    {
        currentcategory = Categories.mobile;
    }

    Product product = new Product(brand, model, price, quantity, currentcategory);

    controller.AddProduct(product);



    Console.WriteLine("Do you want to continue?y/n");

    string restart = Console.ReadLine()??"";

    if (restart == "y")
    {
        goto restart;
    }
    else if (restart == "n")
    {
        Console.WriteLine("The process is finished!");
    }
}


else if (temp == "2")
{

    controller.ShowAllProduct();


    Console.WriteLine("Do you want to continue?y/n");

    string restart = Console.ReadLine()??"";

    if (restart == "y")
    {
        goto restart;
    }
    else if (restart == "n")
    {
        Console.WriteLine("The process is finished!");
    }
}




else
    if (temp == "3")
{
    Console.WriteLine(controller.TotalAmount());

    Console.WriteLine("Do you want to continue?y/n");

    string restart = Console.ReadLine()??"";

    if (restart == "y")
    {
        goto restart;
    }
    else if (restart == "n")
    {
        Console.WriteLine("The process is finished!");
    }
}

else if(temp == "4"){


    Console.WriteLine("Please choose the category:\n" +
        "1.pc\n" +
        "2.mobile");

    string number = Console.ReadLine() ??"Unknown";
    if (number == "1")
    {
        controller.TotalAmountByCategory(Categories.pc);
        Console.WriteLine(controller.TotalAmountByCategory(Categories.pc));
    }
    else if (number == "2") { 
    
    controller.TotalAmountByCategory(Categories.mobile);
        Console.WriteLine(controller.TotalAmountByCategory(Categories.mobile));
    }
    
   
}

else if (temp == "5")
{
    Console.WriteLine("Please choose the category:\n" +
        "1.pc\n" +
        "2.mobile");

    string number = Console.ReadLine() ?? "Unknown";
    if (number == "1")
    {
        controller.ShowProductByCategory(Categories.pc);
        Console.ReadLine();
        goto restart;
    }
    else if (number == "2")
    {

        controller.ShowProductByCategory(Categories.mobile);
        Console.ReadLine();
        goto restart;
    }
}
else if (temp == "6")
{

    string brand = Console.ReadLine() ?? "Unknown";
    string model = Console.ReadLine() ?? "Unknown";
    decimal price = Convert.ToDecimal(Console.ReadLine());
    int quantity = Convert.ToInt32(Console.ReadLine());

    again:
    Console.WriteLine("Please choose th category: \n" +
        "1.pc \n" +
        "2.mobile");

    string num = Console.ReadLine() ?? "Unknown";
    if (num == "1")
    {

        Categories category = Categories.pc;
        Product newproduct = new Product(brand, model, price, quantity, category);

    }
    else if (num == "2") { 
     Categories category = Categories.mobile;

     Product newproduct = new Product(brand, model, price, quantity, category);
    }
    else
    {
        Console.Clear();
        Console.WriteLine("wrong value:");
        goto again;
        
    }

    Console.WriteLine("Do you want to continue?y/n");

    string restart = Console.ReadLine()??"";

    if (restart == "y")
    {
        goto restart;
    }
    else if (restart == "n")
    {
        Console.WriteLine("The process is finished!");
    }
}
else if (temp == "7")
{
    Console.Write(" Total quantity is ");
    Console.WriteLine(controller.TotalQuantity());
    Console.WriteLine("Do you want to continue?y/n");

    string restart = Console.ReadLine()??"";

    if (restart == "y")
    {
        goto restart;
    }
    else if (restart == "n")
    {
        Console.WriteLine("The process is finished!");
    }
}
else if(temp == "8")
{
   
    controller.ShowAllProduct();

    Console.WriteLine(" Which product do you want ro sell?\n");

    int id = Convert.ToInt32( Console.ReadLine());

    Console.WriteLine("how many product do you want to sell?");
    int sellamount = Convert.ToInt32( Console.ReadLine());

    controller.SellProduct( id, sellamount);


    Console.WriteLine("Do you want to continue?y/n");

    string restart = Console.ReadLine()??"";

    if (restart == "y")
    {
        goto restart;
    }
    else if (restart == "n")
    {
        Console.WriteLine("The process is finished!");
    }
}






using DAY21.Task2;

Market market = new Market();


string opt;

do
{
    Console.WriteLine("\n =========== MENU ===========");
    Console.WriteLine("1. Product elave et");
    Console.WriteLine("2. Product sat");
    Console.WriteLine("3. Productlara bax");
    Console.WriteLine("4. Menyudan çıx");
    opt = Console.ReadLine();

    switch (opt)
    {
        case "1":
            string name;
            string priceStr;
            double price;
            string countStr;
            int count;
            
            do
            {
                Console.Write("Mehsulun adini daxil edin - ");
                name = Console.ReadLine();  

            } while (string.IsNullOrEmpty(name));

            do
            {
                Console.Write("  Qiymetini daxil edin - ");
                priceStr = Console.ReadLine();

            } while (!double.TryParse(priceStr, out price) || price < 0);

            do
            {
                Console.Write("    Sayini daxil edin - ");
                countStr = Console.ReadLine();

            } while (!int.TryParse(countStr, out count) || count < 0);

            Product product = new Product(name,price,count);

            market.AddProduct(product);
            break;
        case "2":
            string nameToSell;
            market.Sellable();
            do
            {
                Console.Write("Satmaq istediyiniz mehsulun adini daxil edin - ");
                nameToSell = Console.ReadLine();
            } while (string.IsNullOrEmpty(nameToSell));
            
            market.SellProduct(nameToSell);
            break; 
        case "3":
            Console.WriteLine("\n === MEHSULLAR ===");
            market.ShowProducts();
            break;
        
        default:
            if(opt != "4")
                Console.WriteLine("Duzgun operator daxil edin !");
            break;
    }

} while (opt != "4");



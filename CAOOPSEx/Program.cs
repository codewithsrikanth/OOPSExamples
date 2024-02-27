namespace CAOOPSEx
{
    class Product
    {
        //variables
        int productId; string productName; double price; int qty;

        //Method
        public void GetProductInfo()
        {
            Console.WriteLine("Enter Product Details: ");
            productId = Convert.ToInt32(Console.ReadLine());
            productName = Console.ReadLine();
            price = Convert.ToDouble(Console.ReadLine());
            qty = Convert.ToInt32(Console.ReadLine());
        }
        //Function
        public double GetPrice()
        {
            return price * qty;
        }
        //Method
        public void Display()
        {
            double total = GetPrice();
            Console.WriteLine("Product Name is: "+productName);
            Console.WriteLine("Product Cost is: "+total);
        }
        //Function
        public string Greet(string name)
        {
            double x = Math.Sqrt(10);
            Console.WriteLine(x);
            return "Welcome " + name;
        }
    }
    class Example1
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            //p1.GetProductInfo();
            //p1.Display();
            string msg = p1.Greet("Srikanth");
            Console.WriteLine(msg);
        }
    }
}

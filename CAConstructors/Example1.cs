namespace CAConstructors
{
    class Category
    {
        public int categoryId;public string categoryName;
        //Parameterized Constructor
        public Category(int id, string categoryName)
        {
            categoryId = id;
            this.categoryName = categoryName;
        }
    }
    class Product
    {
        string productName;double price;
        //Default Constructor
        public Product()
        {
            Product p1 = new Product("XBox 360");
            p1.Display();
            productName = "Mobile";
            price = 25000;
        }
        //Parameterized Constructor
        public Product(string productName, double price)
        {
            this.productName = productName;
            this.price = price;
        }
        //Copy Contructor
        public Product(string productName,double price,Category category)
        {
            this.productName = productName;
            this.price = price;
            Console.WriteLine("Category Name: "+category.categoryName);
        }
        public Product(Product product)
        {
            this.productName = product.productName;
            this.price = product.price;
        }
        //Private Constructor
        private Product(string name)
        {
            productName = name;
        }
        public void Display()
        {
            Console.WriteLine($"Product Name is: {productName} and Price is: {price}");
        }        
    }

    class Example1
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.Display();
            Product p2 = new Product("Laptop", 53000);
            p2.Display();
            Category obj = new Category(10, "Electronics");
            Product p3 = new Product("Desktop", 23000,obj); 
            p3.Display();
            Product p4 = new Product(p1);
            p4.Display();

            //Product p5 = new Product("XBox 360");
        }
    }
}

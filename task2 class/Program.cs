namespace task2_class
{class Product
    {
        public string Name;
        public string Description;
        public int Count;
        public bool IsStock;
        public double Price;

    }class Notebook : Product
    {
        public byte Ram;
        public int Storage;
        public void ShowFullData()
        {
            Console.WriteLine(Name + " " + Description + " " + Count + " " + Price + " " + Ram);
        }

        public void sale()
        {
         if (IsStock&&Count>0)
            {
                Console.WriteLine(Name+" "+Description+" "+Count+" "+Price+" "+Ram);
            }
            else
            {
                Console.WriteLine("stoctda yoxdur");
            }
           
            
            
        }
       
    }
    
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "name";
            product1.Description = "description";
            product1.Price = 1;
            product1.IsStock =true;
            product1.IsStock=false;
            product1.Count = 1;


            Notebook notebook1 = new Notebook();
            notebook1.Storage = 16;
            notebook1.Ram = 32;
            notebook1.Name = "computer";
            notebook1.Description = "dizustu";
            notebook1.Price = 1500;
            notebook1.IsStock = true;
            notebook1.Count = 0;

            notebook1.ShowFullData();
            notebook1.sale();
        }
    }
}

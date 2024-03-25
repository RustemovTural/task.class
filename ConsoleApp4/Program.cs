namespace ConsoleApp4
{ class Vehicle
    {
        public string Brand;
       public string Model;
        public double  Mile;
    };
   
    class Car : Vehicle
    {
       public int DoorsNum;
        public void ShowFullInfo()
        {
            Console.WriteLine(Brand+" "+Model+" "+Mile+" "+DoorsNum);
        }
        
    };
    class MotorCycle : Vehicle
    {
       public int WhelNum;
        public void ShowFullInfo()
        {
            Console.WriteLine(Brand+" "+Model+" "+Mile+" "+WhelNum);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Vehicle();
            vehicle1.Brand = "brand";
            vehicle1.Model = "model";
            vehicle1.Mile= 0;

            Car car1 = new Car();
            car1.DoorsNum = 4;
            car1.Brand = "hyundai";
            car1.Model = "sonata";
            car1.Mile = 90000;

            MotorCycle cycle1 = new MotorCycle();
            cycle1.WhelNum = 17;
            cycle1.Brand = "bmw";
            cycle1.Mile = 0;
            cycle1.Model = "fasting";

               
           
            car1.ShowFullInfo();
            cycle1.ShowFullInfo();
        }
    }
}

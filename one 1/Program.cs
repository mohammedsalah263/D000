namespace one_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double smallRoom = 25.00d;
            double largeRoom = 35.00d;
            double salesTax = 0.06d;
            // 
            Console.Write("Enter the number of small rooms : ");
            double smallRooms1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the number of large rooms : ");
            double largeRooms1 = double.Parse(Console.ReadLine());
            //  
            double cost1 = (smallRoom * smallRooms1) + (largeRoom * largeRooms1);
            //  
            double tax = salesTax * cost1;
            //  
            double total = tax + cost1;
            //
            Console.WriteLine("Estimate for carpet cleaning service");
            Console.WriteLine("Number of small carpets:" + smallRooms1);
            Console.WriteLine("Number of large carpets:" + largeRooms1);
            Console.WriteLine("Price per small room: $" + smallRoom);
            Console.WriteLine("Price per small room: $" + largeRoom);
            Console.WriteLine("Price per small room: $" + largeRoom);
            Console.WriteLine("Cost: $" + cost1);
            Console.WriteLine("Tax: $" + tax);
            Console.WriteLine("Total estimate: $" + total);
            Console.WriteLine("This estimate is valid for 30 days");
        }
    }
}

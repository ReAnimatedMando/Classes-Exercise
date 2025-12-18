namespace Classes

{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car(); // an instance of the Car class
            myCar.Make = "Subaru"; // assigning values to the properties for myCar instance using Car blueprint
            myCar.Model = "CrossTrek";
            myCar.Year = 2015;

            Console.WriteLine(myCar.Make);
            Console.WriteLine(myCar.Model);
            Console.WriteLine(myCar.Year);
        }
    }
}

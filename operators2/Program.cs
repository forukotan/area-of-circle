namespace operators2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("What's the radius");
            var radius = double.Parse(Console.ReadLine());
            var areaOfCircle = Area(radius);
            Console.WriteLine($"The are of a circle with radius {radius} is {areaOfCircle}");
        }
        public static double Area(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
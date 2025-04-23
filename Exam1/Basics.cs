
    public static class Q1_Add
    {
        public static int Add(int a, int b) => a + b;}

    public static class Basics
    {
        public static void Q2MultiplyAndReset(ref int value, ref int factor)
        {
            value *= factor;
            factor = 1; }}

        // public static void Q5TryCatchFinally(bool shouldThrow, List<string> log, bool throwInCatch = false)
        // {
        //     try
        //     {
        //         log.Add("Try");
        //         if (shouldThrow)
        //             throw new InvalidOperationException();
        //     }
        //     catch (Exception) when (!throwInCatch)
        //     {
        //         log.Add("Catch");
        //         if (throwInCatch)
        //             throw;
        //     }
        //     finally
        //     {
        //         log.Add("Finally");
        //     }

        //     if (!shouldThrow)
        //         log.Add("AfterTry");
        // }
    

    public struct Type1
    {
        public int Count { get; set; }}

    public class Type2
    {
        public int Count { get; set; }}

    public class Q4Person
    {
        public string Name { get; }
        public int Age { get; }

        public Q4Person(string name, int age)
        {
            Name = name;
            Age = age;}

        public string Introduce() => $"Hello, my name is {Name} and I am {Age} years old.";}

    public class Q6Temperature
    {
        private double celsius;

        public double Celsius
        {
            get => celsius;
            set => celsius = value;}

        public double Fahrenheit
        {
            get => (celsius * 9 / 5) + 32;
            set => celsius = (value - 32) * 5 / 9;}}

    public interface IShape
    {
        double GetArea();
        double GetPerimeter();}

    public class Q7Circle : IShape
    {
        private readonly double radius;

        public Q7Circle(double radius)
        {
            this.radius = radius;}

        public double GetArea() => Math.PI * radius * radius;
        public double GetPerimeter() => 2 * Math.PI * radius;}

    public class Q7Rectangle : IShape
    {
        private readonly double width;
        private readonly double height;

        public Q7Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;}

        public double GetArea() => width * height;
        public double GetPerimeter() => 2 * (width + height);}

    public static class ShapeUtils
    {
        public static double Q7TotalArea(IShape[] shapes)
        {
            double total = 0;
            foreach (var shape in shapes)
            {
                total += shape.GetArea();}
            return total;}}


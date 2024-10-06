namespace ShapeAreaCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle recArea = new Rectangle(5.24, 6.35);
            Triangle triArea = new Triangle(5.22, 6.63);
            Circle criArea = new Circle(6.33);

            Console.WriteLine(recArea.CalcArea());
            Console.WriteLine(triArea.CalcArea());
            Console.WriteLine(criArea.CalcArea());
        }
    }
}

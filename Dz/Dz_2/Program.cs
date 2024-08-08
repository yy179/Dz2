namespace Dz_2
{
    class Program
    {
        static void Main(string[] args) 
        {
            Circle circle = new Circle();
            circle.Move(5, 10);
            Rectangle rectangle = new Rectangle { Height = 20, Width = 10};
            rectangle.Move(3, 4);
            Vector vector = new Vector(2,3);
            Console.WriteLine($"Lenght: {vector.Length()}");
            rectangle.Resize(vector);
            Console.WriteLine($"new width: {rectangle.Width}\nnew height: {rectangle.Height}");
        }
    }
}
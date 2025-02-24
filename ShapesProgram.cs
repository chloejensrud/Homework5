// Written By Chloe Jensrud
// 2/24/2025


namespace ShapesAndAreas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Circle aCircle1 = new Circle("Red", 2.5);
            Circle aCircle2 = new Circle("Blue", 5.0);

            Rectangle aRectangle1 = new Rectangle("Orange", 2.0, 3.0);
            Rectangle aRectangle2 = new Rectangle("Green", 6.0, 2.0);

            Console.WriteLine(aCircle1.ToString());
            Console.WriteLine(aCircle2.ToString());
            Console.WriteLine(aRectangle1.ToString());
            Console.WriteLine(aRectangle2.ToString());
        }
    }
}

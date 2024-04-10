//----------------------------Task 1-------------------------------
public class Square
{
    public int Length;
    public int Sqr;
    public string Color;

    public Square(int length,string color)
    {
        Length = length;
        Color = color;
        Sqr = length * length;
    }

    public void PrintSquare()
    {
        Console.WriteLine($"Length: {Length}, Square: {Sqr}, Color: {Color}");
    }
}
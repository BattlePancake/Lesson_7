﻿//----------------------------Task 1-------------------------------
public class Square
{
    public int Length {get;set;}
    public int Sqr {get;set;}
    public string Color {get;set;}

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
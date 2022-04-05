// Created by: Kaitlyn Ip
// Created on: Mar 2022
//
// This program finds the perimeter of a right triangle.

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        float length;
        float width;
        float height;
        float volume;
        //input
        Console.WriteLine("This program finds the volume of a pyramid.");
        Console.WriteLine("");
        Console.WriteLine("Formula = (length x width x height) / 3.");
        Console.WriteLine("");
        Console.Write("Enter the length of the pyramid (mm): ");
        length = float.Parse(Console.ReadLine());
        Console.Write("Enter the width of the pyramid (mm): ");
        width = float.Parse(Console.ReadLine());
        Console.Write("Enter the height of the pyramid (mm): ");
        height = float.Parse(Console.ReadLine());
        //process
        volume = (length * width * height) / 3;
        //output
        Console.WriteLine("");
        Console.Write("Volume of the pyramid = " + volume.ToString("0.00") + " mm³");
        Console.ReadKey();
        Console.WriteLine("\nDone.");
    }
}
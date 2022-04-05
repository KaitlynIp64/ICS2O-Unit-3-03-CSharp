// Created by: Kaitlyn Ip
// Created on: Mar 2022
//
// This program finds the volume of a sphere.

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        double radius;
        double volume;
        //input
        Console.WriteLine("This program finds the volume of a sphere.");
        Console.WriteLine("");
        Console.WriteLine("Formula = (4/3 𝝅 r³");
        Console.WriteLine("");
        Console.Write("Enter the radius of the pyramid (mm): ");
        radius = double.Parse(Console.ReadLine());
        Console.WriteLine("");
        //process
        volume = (double)4 / 3 * Math.PI * Math.Pow(radius, 3);
        Console.Write("Volume of the sphere = " + volume.ToString("0.00") + " mm³");
        Console.ReadKey();
        Console.WriteLine("\nDone.");
    }
}
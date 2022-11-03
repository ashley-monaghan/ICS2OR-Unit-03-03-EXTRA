// Created by: Ashley Monaghan
// Created on: Oct 2022
//
//This program calculates the volume of a sphere

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user imput
        double radius;
        double volume;

        Console.WriteLine("This program calculates the volume of a sphere.");
        Console.WriteLine("");

        Console.Write("Enter the radius (cm): ");
        radius = Convert.ToDouble(Console.ReadLine());

        volume = (4.0/3.0)* Math.PI * Math.Pow(radius, 3);

        Console.WriteLine("");
        Console.WriteLine("The volume is: " + volume.ToString("0.00") + " units³. ");

        Console.WriteLine("\nDone.");
    }
}
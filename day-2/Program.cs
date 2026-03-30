// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace Day_2;

/// <summary>Entry point for the Day 2 program.</summary>
internal static class Program
{
    /// <summary>Application entry point.</summary>
    /// <param name="args">Command-line arguments.</param>
    private static void Main(string[] args)
    {
        string? input = Console.ReadLine();
        if (input == null || input.Equals(string.Empty))
        {
            Console.WriteLine("Nothing found");
        }
        else
        {
            string[] inputArray = input.Split(",");
        }
    }
}
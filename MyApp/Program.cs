// See https://aka.ms/new-console-template for more information
using System;


var currentDirectory = Directory.GetCurrentDirectory();
// Read a file and convert it to a string
var salesFile = File.ReadAllText(currentDirectory + "\\stores.txt");
// Convert the string to a list of strings
var sales = salesFile.Split(',');
// Convert the list of strings to a list of integers
var salesInt = sales.Select(int.Parse).ToList();
// Get the sum of the integers
var totalSales = salesInt.Sum();
// Print the total sales
Console.WriteLine($"Total sales: {totalSales}");

/*
using Humanizer;
Console.WriteLine("Quantities:");
HumanizeQuantities();

Console.WriteLine("\nDate/Time Manipulation:");
HumanizeDates();

using System;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Hello world!");
  }
}


static void HumanizeQuantities() {
    Console.WriteLine("case".ToQuantity(0));
    Console.WriteLine("case".ToQuantity(1));
    Console.WriteLine("case".ToQuantity(5));
}

static void HumanizeDates() {
    Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
    Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
    Console.WriteLine(TimeSpan.FromDays(1).Humanize());
    Console.WriteLine(TimeSpan.FromDays(16).Humanize());
}
*/
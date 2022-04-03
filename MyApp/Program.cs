// See https://aka.ms/new-console-template for more information
using System;


var currentDirectory = Directory.GetCurrentDirectory();
var storesDirectory = Path.Combine(currentDirectory, "stores");

var salesFiles = FindFiles(storesDirectory);
    
foreach (var file in salesFiles)
{
    Console.WriteLine(file);
}

IEnumerable<string> FindFiles(string folderName)
{
    List<string> salesFiles = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach (var file in foundFiles)
    {
        var extension = Path.GetExtension(file);
        if (extension == ".json")
        {
            salesFiles.Add(file);
        }
    }

    return salesFiles;
}

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
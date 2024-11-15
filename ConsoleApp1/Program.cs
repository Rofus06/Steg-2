using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Skapar en string-array med namnen på dom fem olika leksakerna
        string[] toys = { "Barbie", "Lego", "Play-Doh", "Hot Wheels", "Transformers" };

        // For-loop som skriver ut namnet på varje leksak på en egen rad
        Console.WriteLine("Leksaker:");
        foreach (var toy in toys)
        {
            Console.WriteLine(toy);
        }

        // Skapar en string-array med namnen på fem personer
        string[] classmates = { "Pelle", "Anna", "Erik", "Lisa", "Jonas" };

        // Skapar en integer-array med fem värden mellan 0 och 10
        int[] ratings = { 8, 6, 9, 7, 5 };

        // Komplettera for-loopen så att den skriver ut t.ex "Pelle ger Barbie betyget 5"
        Console.WriteLine("Betyg:");
        for (int i = 0; i < classmates.Length; i++)
        {
            Console.WriteLine($"{classmates[i]} ger {toys[i]} betyget {ratings[i]}.");
        }

        // Skapa en tom string-lista som heter "cities"
        List<string> cities = new List<string>();

        // Skapar en loop där användaren matar in städer
        Console.WriteLine("Mata in städer (skriv 'exit' för att avsluta):");
        while (true)
        {
            string city = Console.ReadLine();
            if (city.ToLower() == "exit")
                break;
            cities.Add(city);
        }

        // Skapar en loop som skriver ut alla strings som finns sparade i cities-listan ezzz:)
        Console.WriteLine("Städer du angav:");
        foreach (var city in cities)
        {
            Console.WriteLine(city);
        }
    }
}

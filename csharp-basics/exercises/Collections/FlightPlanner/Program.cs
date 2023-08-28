using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Flightmode
{
    class Program
    {
        private const string Path = "../../../flights.txt";

        static void Main(string[] args)
        {
            List<string[]> flights = ReadFlightsFromFile(Path);
            List<string> uniqueCities = flights.Select(flight => flight[0]).Distinct().ToList();

            Console.WriteLine("What would you like to do:");
            Console.WriteLine("To display list of the cities press 1");
            Console.WriteLine("To exit program press #");

            string inputStr = Console.ReadLine();

            if (int.TryParse(inputStr, out int inputNumber))
            {
                if (inputNumber == 1)
                {
                    Console.WriteLine("Available cities:");

                    for (int i = 0; i < uniqueCities.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {uniqueCities[i]}");
                    }

                    string nextCity = string.Empty;
                    string startingCity = string.Empty;
                    List<string> selectedCities = new List<string>();

                    Console.Write("Enter the number of the starting city: ");

                    if (int.TryParse(Console.ReadLine(), out int cityNumber) && cityNumber >= 1 &&
                        cityNumber <= uniqueCities.Count)
                    {
                        startingCity = uniqueCities[cityNumber - 1];
                        Console.WriteLine($"Starting city will be: {startingCity}");
                        selectedCities.Add(startingCity);
                    }

                    do
                    {
                        var list = GetDestinations(selectedCities.Last(), ReadFlightsFromFile(Path));

                        for (int i = 0; i < list.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {list[i]}");
                        }

                        string inputStr2 = Console.ReadLine();
                        int userChoiceInput = int.Parse(inputStr2);
                        nextCity = list[userChoiceInput - 1];
                        selectedCities.Add(nextCity);

                        Console.WriteLine("Next City " + nextCity);

                    } while (selectedCities[0] != nextCity);

                    Console.WriteLine("Round-trip route selected:");
                    Console.WriteLine(string.Join(" -> ", selectedCities));
                }
            }
        }

        public static void UseMenu(string origin, List<string[]> flights)
        {
            var destinations = GetDestinations(origin, flights);
            Console.WriteLine($"Next city will be: {origin}");
            for (int i = 0; i < destinations.Count; i++)
            {
                Console.WriteLine($"\n{i + 1}.  {destinations[i]}");
            }
        }

        static List<string[]> ReadFlightsFromFile(string filePath)
        {
            List<string[]> flights = new List<string[]>();
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split("->", StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 2)
                {
                    string[] flight = new string[] { parts[0].Trim(), parts[1].Trim() };
                    flights.Add(flight);
                }
            }

            return flights;
        }

        static List<string> GetDestinations(string city, List<string[]> flights)
        {
            List<string> destinations = new List<string>();

            for (int i = 0; i < flights.Count; i++)
            {
                if (flights[i][0] == city)
                {
                    destinations.Add(flights[i][1]);
                }
            }

            return destinations;
        }
    }
}

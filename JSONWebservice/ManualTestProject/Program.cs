using Entities;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManualTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ConsoleKeyInfo input = new ConsoleKeyInfo();

                Console.WriteLine("Press 1 for latest rates, press 2 for choosing a date");

                while (input.Key != ConsoleKey.D1 && input.Key != ConsoleKey.D2)
                {
                    input = Console.ReadKey();
                }

                if (input.Key == ConsoleKey.D2)
                {
                    DateTime? date = null;
                    int years = 0;
                    int months = 0;
                    int days = 0;

                    while (date == null)
                    {
                        bool validInput = true;

                        if (validInput == true)
                        {
                            try
                            {
                                years = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                validInput = false;
                            }
                        }

                        if (validInput == true)
                        {
                            try
                            {
                                months = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                validInput = false;
                            }
                        }

                        if (validInput == true)
                        {
                            try
                            {
                                days = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                validInput = false;
                            }
                        }

                        if (validInput == true)
                        {
                            try
                            {
                                date = new DateTime(years, months, days);
                            }
                            catch (Exception e)
                            {
                                validInput = false;
                            }
                        }
                        string yearString = $"{years}";
                        if (years < 10)
                        {
                            yearString = $"000{years}";
                        }
                        else if (years < 100)
                        {
                            yearString = $"00{years}";
                        }
                        else if (years < 1000)
                        {
                            yearString = $"0{years}";
                        }
                        string monthString = months < 10 ? $"0{months}" : $"{months}";
                        string dayString = days < 10 ? $"0{days}" : $"{days}";
                        Console.WriteLine(Client.GetCurrency($"historical/{yearString}-{monthString}-{dayString}.json"));
                    }
                }
                if (input.Key == ConsoleKey.D1)
                {
                    CurrencyData.Root data = Client.GetCurrency("latest.json");
                    Console.WriteLine(data.Timestamp);
                    Console.WriteLine(data.Rates.AED);
                    Console.WriteLine(data.Rates.AFN);
                    Console.WriteLine(data.Rates.ALL);
                    Console.WriteLine(data.Rates.AMD);
                    Console.WriteLine(data.Rates.ANG);
                    Console.WriteLine(data.Rates.AOA);
                    Console.WriteLine(data.Rates.ARS);
                    Console.WriteLine(data.Rates.AUD);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {
        public Weather weather;
        public List<Customer> customers;
        public int day;

        public Day()
        {
            day = 1;
            weather = new Weather();
            customers = new List<Customer>();

        }

        public void spawnCustomers()
        {
            int NumberOfCustomers = 0;
            Random chanceBuy = new Random();

            if (weather.condition == weather.weatherConditions[0])
            { NumberOfCustomers = 120;
                for (int i = 0; i < NumberOfCustomers; i++)
                {
                    customers.Add(new Customer("Anon", chanceBuy.Next(1, 100)));
                }
            }
            else if (weather.condition == weather.weatherConditions[1])
            { NumberOfCustomers = 90;
                for (int i = 0; i < NumberOfCustomers; i++)
                {
                    customers.Add(new Customer("Anon", chanceBuy.Next(1, 100)));
                }
            }
            else if (weather.condition == weather.weatherConditions[2])
            { NumberOfCustomers = 70;
                for (int i = 0; i < NumberOfCustomers; i++)
                {
                    customers.Add(new Customer("Anon", chanceBuy.Next(1, 100)));
                }
            }
            else if (weather.condition == weather.weatherConditions[3])
            { NumberOfCustomers = 60;
                for (int i = 0; i < NumberOfCustomers; i++)
                {
                    customers.Add(new Customer("Anon", chanceBuy.Next(1, 100)));
                }
            }
            else if (weather.condition == weather.weatherConditions[4])
            { NumberOfCustomers = 50;
                for (int i = 0; i < NumberOfCustomers; i++)
                {
                    customers.Add(new Customer("Anon", chanceBuy.Next(1, 100)));
                }
            }
            else
            { 
                Console.WriteLine("no customers"); 
            }                        
        }
    }
}
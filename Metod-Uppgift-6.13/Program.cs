using System;

namespace Uppgfit_6_13
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Skriv in dina kort på en rad separerade med mellansteg");
            Console.WriteLine(RäknaPoäng(Console.ReadLine()));
        }
        static double RäknaPoäng(string sträng)
        {
            string[] str = sträng.Split(" ");
            int[] kort = new int[str.Length];
            Dictionary<int, int> map = [];
            double resultat = 0;
            
            for (int i = 0; i < str.Length; i++)
            {
                kort[i] = int.Parse(str[i]);
            } 

            for (int i = 0; i < kort.Length; i++)
            {
                if (map.TryAdd(kort[i], 1))
                {
                    continue;
                }
                else
                {
                    map[kort[i]]++;
                }
            }

            foreach (KeyValuePair<int, int> pair in map)
            {
                resultat += Math.Pow(pair.Key, pair.Value);
            }

            return resultat;
        }
    }
}
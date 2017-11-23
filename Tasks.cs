using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace codewarsApp
{
    public static class Excerises
    {
        public static bool IsIsogram(string str)
        {
            return str.ToLower().ToCharArray().Distinct().Count() == str.Length;
        }
        public static string WubWub(string str)
        {
            return Regex.Replace(str, "(WUB)+", " ").Trim();
        }
        public static int[] SortArray(int[] array)
        {
            var odds = new Queue<int>(array.Where(e => e % 2 == 1).OrderBy(e => e));
            return array.Select(e => e % 2 == 1 ? odds.Dequeue() : e).ToArray();
        }
        public static string GoodVsEvil(string good, string evil)
        {
            int[] goodForcesValues = { 1, 2, 3, 3, 4, 10 };
            int[] evilForcesValues = { 1, 2, 2, 2, 3, 5, 10 };
            var goodForces = good.Split(' ').Zip(goodForcesValues, ((e, f) => int.Parse(e) * f)).Sum();
            System.Console.WriteLine(goodForces);
            var evilForces = evil.Split(' ').Zip(evilForcesValues, ((e, f) => int.Parse(e) * f)).Sum();
            System.Console.WriteLine(evilForces);
            return goodForces > evilForces ?
            "Battle Result: Good triumphs over Evil" :
            goodForces < evilForces ?
            "Battle Result: Evil eradicates all trace of Good" :
            "Battle Result: No victor on this battle field";
        }
        public static string[] TowerBuilder(int nFloors)
        {
            return Enumerable.Range(0, nFloors).Select(i => $"{new String(' ', nFloors - i - 1)}{new String('*', 2 * i + 1)}{new String(' ', nFloors - i - 1)}").ToArray();
        }
        public static int[] MoveZeroes(int[] arr)
        {
            // return arr.Where(e => e != 0).Concat(arr.Where(e => e == 0)).ToArray();
            return arr.OrderBy(e => e == 0).ToArray(); //false bedzie przed true!!
        }
        public static long QueueTime(int[] customers, int n)
        {
            var tills = new long[n];
            for (int i = 0; i < n; i++)
            {
                tills[i] = 0;
            }
            for (int i = 0; i < customers.Length; i++)
            {
                tills[Array.IndexOf(tills, tills.Min())] += customers[i];
            }
            return tills.Max();
        }
        public static string GenerateBC(string url, string separator)
        {
            var urlPattern = @"(?:https*://)*(?<host>[\w-\.]+){1}(?<paths>/[\w-]+)*";
            var urlParts = Regex.Match(url, urlPattern);
            System.Console.Write(urlParts.Groups["host"].Value);
            foreach (var capture in urlParts.Groups["paths"].Captures)
            {
                System.Console.Write($" > {(capture)}");
            }
            System.Console.Write("\r\n");
            var returnString = new StringBuilder();
            // returnString.Append($"<a href=\"/\">HOME</a> {separator} ");
            // returnString.AppendJoin($" {separator} ",parts.Take(parts.Count()-1).Select(e => $"<a href=\"/{e}/\">{e.ToUpper().Replace('-',' ')}</a>"));
            // returnString.Append($" {separator} <span class=\"active\">{Regex.Match(parts.Last(),lastPartPattern).ToString().ToUpper().Replace('-',' ')}</span>");
            // foreach (var part in parts)
            // {
            //     System.Console.WriteLine(part);
            // }
            return returnString.ToString();
        }
    }
}
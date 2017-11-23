using System;

namespace codewarsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Excerises.GenerateBC("mysite.com/pictures/holidays.html", ">"));
            Console.WriteLine(Excerises.GenerateBC("www.codewars.com/users/GiacomoSorbi?ref=CodeWars", ">"));
            Console.WriteLine(Excerises.GenerateBC("www.microsoft.com/docs/index.htm#top", ">"));
            Console.WriteLine(Excerises.GenerateBC("mysite.com/very-long-url-to-make-a-silly-yet-meaningful-example/example.asp", ">"));
            Console.WriteLine(Excerises.GenerateBC("https://www.linkedin.com/in/giacomosorbi", ">"));
            Console.WriteLine(Excerises.GenerateBC("www.agcpartners.co.uk/", ">"));
            Console.WriteLine(Excerises.GenerateBC("www.agcpartners.co.uk", ">"));
            Console.WriteLine(Excerises.GenerateBC("http://www.agcpartners.co.uk/index.html", ">"));
        }
    }
}

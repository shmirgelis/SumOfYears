using System;
using System.Collections.Generic;
using System.Linq;


namespace SumOfDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = new List<DateTime>()
            {
                new DateTime(2020, 7, 3),
                new DateTime(2021, 12, 3),
                new DateTime(2019, 5, 3),
                new DateTime(2015, 1, 3),
                new DateTime(2010, 1, 3),
                new DateTime(2001, 10, 3),
                new DateTime(2019, 2, 3),
                new DateTime(2019, 3, 3),
                new DateTime(2021, 4, 3),
                new DateTime(2021, 2, 3),
                new DateTime(1998, 12, 3),
                new DateTime(2020, 1, 3),
                new DateTime(2021, 2, 3),
            };

            var result = source;   // kodel priskiriam variable source result'ui ? Gal del to kad nenorim keist source listo? 

            var newResult = result.Where(x => x.Month > 9).Sum(x => x.Year); // kaip padaryt statementa, lygu arba daugiau 10, pvz result.Where(x => x.Month => 10
            Console.WriteLine($"Total years: {newResult}");

            //foreach (var item in newResult)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
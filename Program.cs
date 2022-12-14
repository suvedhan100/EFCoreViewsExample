using EFCoreViewsExample.Models;
using System;
using System.Linq;

namespace EFCoreViewsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new testdbContext();
            var result = context.Personsviews.Where(s => s.Id == 1)
                                              .FirstOrDefault();
            // var list = context.Personsviews.ToList();
            Console.WriteLine(result.Firstname + " " + result.Lastname);

            if (result != null)
            {
                result.Firstname = "Sri";
                result.Lastname = "Balaji";
                context.Personsviews.Update(result);

                Personsview personsview = new Personsview()
                {
                    Id = 4,
                    Firstname = "hari",
                    Lastname = "hari"
                };
                context.Add(personsview);

                context.SaveChanges();
            }



        }
    }
}

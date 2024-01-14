using OOP.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P024.Excercise.Generics_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstList = new List<Movie<double, DateTime>>();
            var secondList = new List<Movie<float, int>>();

            var darkKnight1 = new Movie<float, int>();
            darkKnight1.MovieName = "Batman Begins";
            darkKnight1.Director = "Christopher Nolan";
            darkKnight1.Rate = 8.3f;
            darkKnight1.ReleaseDate = 2005;

            var darkKnight2 = new Movie<float, int>();
            darkKnight2.MovieName = "The Dark Knight";
            darkKnight2.Director = "Christopher Nolan";
            darkKnight2.Rate = 9.0f;
            darkKnight2.ReleaseDate = 2008;

            var darkKnight3 = new Movie<float, int>();
            darkKnight3.MovieName = "The Dark Knight Rises";
            darkKnight3.Director = "Christopher Nolan";
            darkKnight3.Rate = 8.4f;
            darkKnight3.ReleaseDate = 2012;

            var lordofTheRings1 = new Movie<double, DateTime>();
            lordofTheRings1.MovieName = "The Lord of the Rings: The Fellowship of the Ring";
            lordofTheRings1.Director = "Peter Jackson";
            lordofTheRings1.Rate = 8.8;
            lordofTheRings1.ReleaseDate = new DateTime(2001, 12, 19);

            var lordofTheRings2 = new Movie<double, DateTime>();
            lordofTheRings2.MovieName = "The Lord of the Rings: The Two Towers";
            lordofTheRings2.Director = "Peter Jackson";
            lordofTheRings2.Rate = 8.7;
            lordofTheRings2.ReleaseDate = new DateTime(2002, 12, 18);

            var lordofTheRings3 = new Movie<double, DateTime>();
            lordofTheRings3.MovieName = "The Lord of the Rings: The Return of the King";
            lordofTheRings3.Director = "Peter Jackson";
            lordofTheRings3.Rate = 8.9;
            lordofTheRings3.ReleaseDate = new DateTime(2003, 12, 17);

            firstList.Add(lordofTheRings1);
            firstList.Add(lordofTheRings2);
            firstList.Add(lordofTheRings3);

            secondList.Add(darkKnight1);
            secondList.Add(darkKnight2);
            secondList.Add(darkKnight3);

            ConsoleHelper.WriteLine("Printing First List");
            PrintList(firstList);

            ConsoleHelper.WriteLine("Printing Seconds List");
            PrintList(secondList);  
        }

        static void PrintList<TRate, UDate>(List<Movie<TRate, UDate>> list)
        {
            if(list == null)
            {
                ConsoleHelper.WriteLine("List is empty", ConsoleColor.Red);
                return;
            }

            foreach(var item in list)
            {
                var msg = $"MovieName: {item.MovieName}, Director: {item.Director} Rate: {item.Rate}, ReleaseDate: {item.ReleaseDate}";
                ConsoleHelper.WriteLine(msg, ConsoleColor.Yellow);
            }
        }
    }
}

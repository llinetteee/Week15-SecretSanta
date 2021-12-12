using System;
using System.Collections.Generic;
using System.IO;

namespace OOPandFiles
{
    class Program
    {
        class Movie
        {
            string title;
            string rating;
            string year;

            public Movie(string _title, string _rating, string _year)
            {
                title = _title;
                rating = _rating;
                year = _year;
            }

            //getters for Movie

            public string Title
            {
                get { return title; } 

            }

            public string Rating
            {
                get { return rating;  }
            }

            public string Year
            {
                get { return year;  }
            }



        }

        static void Main(string[] args)
        {
            List<Movie> myMovies = new List<Movie>();
            string[]moviesFromFile = GetDataFromFile();

        }

        public static void DisplayElementsFromArray (string[]someArray)

        {
            foreach (string element in someArray)
            {

                Console.WriteLine($"String from array: {element}");

            }
    
        }

        public static string[] GetDataFromFile()
        {
            string filePath = @"/Volumes/KÕVAKETAS/movies-2.txt";

            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;

        }

}

}

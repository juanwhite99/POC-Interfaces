using System;

namespace POC_Interfaces
{
    class Film : IDisplay
    {
        private string title;
        private string director;
        private int year;
        private int runtime;

        public Film(string title, string director, int year, int runtime)
        {
            this.title = title;
            this.director = director;
            this.year = year;
            this.runtime = runtime;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Director: {director}");
            Console.WriteLine($"Release Year: {year}");
            Console.WriteLine($"Runtime (in minutes): {runtime}");
        }
    }
}
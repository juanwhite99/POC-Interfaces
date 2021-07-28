using System;

namespace POC_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("War and Peace", "Leo Tolstoy", 1392);
            Film film = new Film("Pulp Fiction", "Quentin Tarantino", 1994, 178);

            PrintObject(book);
            PrintObject(film);

            Console.ReadKey();
        }

        static void PrintObject(IDisplay displayObject)
        {
            Console.WriteLine("======= Here is the object's data: ======");
            displayObject.DisplayInfo();
            Console.WriteLine();
        }
    }
}
using System;

namespace CinemaAdvisor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуй, дорогой друг! Эта программа поможет тебе подобрать фильм для вечернего просмотра.");
            Console.WriteLine("Как вас зовут?");
            String name = Console.ReadLine();
            Console.WriteLine("Здравствуйте, " + name + "!");
            Console.WriteLine("Фильм какого жанра вы хотели бы посмотреть: комедия, драма, фантастика, триллер, боевик.");
            String genre = Console.ReadLine();
            Console.WriteLine("В таком случае рекомендую посмотреть вам следующие фильмы:");
            if (genre == "комедия")
            {
                Console.WriteLine("Комедия 1");
                Console.WriteLine("Комедия 2");
                Console.WriteLine("Комедия 3");
                Console.WriteLine("Комедия 4");
            }
            else if (genre == "драма")
            {
                Console.WriteLine("Драма 1");
                Console.WriteLine("Драма 2");
                Console.WriteLine("Драма 3");
                Console.WriteLine("Драма 4");
            }
            else if (genre == "фантастика")
            {
                Console.WriteLine("фантастика 1");
                Console.WriteLine("фантастика 2");
                Console.WriteLine("фантастика 3");
                Console.WriteLine("фантастика 4");
            }
            else if ( genre.ToLower() == "триллер" )
            {
                Console.WriteLine("триллер 1");
                Console.WriteLine("триллер 2");
                Console.WriteLine("триллер 3");
                Console.WriteLine("триллер 4");
            }
            else if (genre == "боевик")
            {
                Console.WriteLine("боевик 1");
                Console.WriteLine("боевик 2");
                Console.WriteLine("боевик 3");
                Console.WriteLine("боевик 4");
            }
            else
            {
                Console.WriteLine("Другой жанр 1");
                Console.WriteLine("Другой жанр 2");
                Console.WriteLine("Другой жанр 3");
                Console.WriteLine("Другой жанр 4");
            }

            Console.ReadLine();
        }
    }
}

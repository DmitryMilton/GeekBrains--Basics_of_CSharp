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
            Console.WriteLine("Фильм какого жанра вы хотели бы посмотреть?");
            String genre = Console.ReadLine();
            Console.WriteLine("В таком случае рекомендую посмотреть вам следующие фильмы:");
            if (genre == "комедия")
            {
                Console.WriteLine("Комедия 1");
                Console.WriteLine("Комедия 2");
                Console.WriteLine("Комедия 3");
                Console.WriteLine("Комедия 4");
            }
            else
            {
                Console.WriteLine("Фильм 1");
                Console.WriteLine("Фильм 2");
                Console.WriteLine("Фильм 3");
                Console.WriteLine("Фильм 4");
            }

            Console.ReadLine();
        }
    }
}

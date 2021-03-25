using System;

namespace TextQuestKapkaev
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
            Road();
        }

        static void Start()
        {
            Console.WriteLine("Привет путник! Что ты хочешь?");

            Console.WriteLine("");

            Console.WriteLine(" 1. Поговорить с бродягой");

            Console.WriteLine(" 2. Осмотреть окресности");
        }

        static void Road()
        {
            Game quest = new Game();

            quest.ConsoleReader();
        }


    }

    class Game
    {
        private static bool isGetResourse = false;

        private static ConsoleKeyInfo cki;

        public void ConsoleReader()
        {
            do
            {
                int outParse;

                string one = Console.ReadLine();

                var isParse = int.TryParse(one, out outParse);

                if (isParse)
                {
                    Quest(outParse);
                }
                else
                {
                    Console.WriteLine("Что ты хочешь?");

                    Console.WriteLine("");

                    Console.WriteLine(" 1. Поговорить с бродягой");

                    Console.WriteLine(" 2. Осмотреть окресности");
                }

            } while (cki.Key != ConsoleKey.Escape);
        }

        private void Quest(int userInput)
        {
            if (userInput == 1)
            {
                if (!isGetResourse)
                {
                    isGetResourse = true;
                    Console.WriteLine("Сегодня я щедрый, держи медальон и 50 монет");
                }
                else
                {
                    Console.WriteLine("...");
                }
            }
            else if (userInput == 2)
                Console.WriteLine("Вы стоите на дороге, перед вами бродяга, погода отличная и ветер попутный!");

            else
                Console.WriteLine("...");
        }


    }
}

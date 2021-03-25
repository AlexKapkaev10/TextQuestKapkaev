using System;

namespace TextQuestKapkaev
{
    class Program
    {
        static void Main(string[] args)
        {
            StartGame();
        }

        static void StartGame()
        {
            Game quest = new Game();

            quest.InitGame();

            quest.ConsoleReader();
        }


    }

    class Game
    {
        //получены ли ресурсы от бродяги
        private bool isGetResourse = false;

        //приветсвенная фраза
        private string hello = "Привет путник! ";

        //вопрос пользователю
        private string ask = "Что ты хочешь?";

        //первое действие
        private string firstAction = " 1. Поговорить с бродягой";

        //второе действие
        private string secondAction = " 2. Осмотреть окресности";

        //если ничего не происходит
        private string nothing = "...";

        //фраза бродяги
        private string trampPhrase = "Сегодня я щедрый! Держи ";

        //вариант артефакта от бродяги
        private string trampGiftOption = "медальон";

        //монеты 
        private static int coins = 0;

        //описание окружения
        private string aboutEnvironment = "Вы стоите на дороге, перед вами бродяга, погода отличная и ветер попутный!";

        //сообщвет какую клавишу нажать для выхода
        private string endGame = "Для выхода из игры нажмите клафишу ";

        //клавиша выхода
        private string exit = "q";

        public void InitGame()
        {
            Console.WriteLine(hello + ask);

            Console.WriteLine(firstAction);

            Console.WriteLine(secondAction);

            Console.WriteLine(endGame + exit);

        }

        string read;

        public void ConsoleReader()
        {
            while(read != exit)
            {
                read = Console.ReadLine();

                if (read == exit) return;

                int outParse;

                var isParse = int.TryParse(read, out outParse);

                if (isParse)
                {
                    Quest(outParse, 50);
                }
                else
                {
                    Console.WriteLine(ask);

                    Console.WriteLine(firstAction);

                    Console.WriteLine(secondAction);

                    Console.WriteLine(endGame + exit);
                }
            }
        }

        private void Quest(int userInput, int getCoins)
        {
            if (userInput == 1)
            {
                if (!isGetResourse)
                {
                    isGetResourse = true;

                    coins += getCoins;

                    Console.WriteLine(trampPhrase + trampGiftOption + " и " + coins.ToString() + " монет!");
                }
                else
                {
                    Console.WriteLine(nothing);
                }
            }
            else if (userInput == 2)
                Console.WriteLine(aboutEnvironment);

            else
                Console.WriteLine(nothing);
        }
    }
}

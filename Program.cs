using System;
using System.Collections;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {

            static void ShowAds()
            {
                Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
                // Остановка на 1 с
                Thread.Sleep(1000);

                Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
                // Остановка на 2 с
                Thread.Sleep(2000);

                Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
                // Остановка на 3 с
                Thread.Sleep(3000);
            }
            var user = new List<User>();

            Console.Write("Введите Login: ");
            string login = Console.ReadLine();
            Console.Write("Ведите Имя:");
            string name = Console.ReadLine();
            Console.Write("ВВедите уровень Вашей подписки:");
            string psubscription = Console.ReadLine();
            bool isPremium = true;
            if (psubscription == "Premium")
            {
                isPremium = true;
                Console.WriteLine("Приветствую Вас {0}", name);
            }
            else
            {
                isPremium = false;
                Console.WriteLine("Приветствую Вас {0}", name);
                ShowAds();
            }

            // добавляем контакт
            
            user.Add(new User(name, login, isPremium));

            Console.ReadKey();

        }
    }

    public class User // модель класса
    {
        public User(string login, string name, bool isPremium) // метод-конструктор
        {
            Login = login;
            Name = name;
            IsPremium = isPremium;
        }

        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
    }

    public class SwowAds
    {

    }

}
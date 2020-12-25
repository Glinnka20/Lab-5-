using System;

namespace OOP5
{
    class Program
    {
        interface IKorabl
        {
            void Tip();
        }
        class Korabl
        {
            IKorabl korabl;
            public Korabl(IKorabl kor)
            {
                korabl = kor;
            }
            public void Start()
            {
                korabl.Tip();
            }
        }
        class Gruz : IKorabl
        {
            public void Tip()
            {
                Console.WriteLine("Этот корабль грузовой");
            }
        }
        class Voen : IKorabl 
        {
            public void Tip()
            {
                Console.WriteLine("Этот корабль военный");
            }
        }

        interface ITank
        {
            void Type();
        }
        class Tank
        {
            ITank tank;
            public Tank(ITank tan)
            {
                tank = tan;
            }
            public void Start()
            {
                tank.Type();
            }
        }
        class Light : ITank
        {
            public void Type()
            {
                Console.WriteLine("Этот танк легкий");
            }
        }
        class Heavy : ITank
        {
            public void Type()
            {
                Console.WriteLine("Этот танк тяжелый ");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Интерфейс IKorabl:");
            Korabl gruz = new Korabl(new Gruz());
            Korabl voen  = new Korabl(new Voen());
            gruz.Start();
            voen .Start();
            Console.WriteLine();
            Console.WriteLine("Демонстрация интерфейса ITank:");
            Tank ch = new Tank(new Light());
            Tank ex = new Tank(new Heavy());
            ch.Start();
            ex.Start();
            Console.ReadKey();
        }
    }
}

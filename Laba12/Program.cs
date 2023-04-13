using System;

namespace Laba12
{
    public delegate void Delegat(string text);
    class One
    {
        public event Delegat Event;

        public void Generate(string eventName)
        {
            Event.Invoke(eventName);
        }
    }

    class Two
    {
        public void HandleEvent(string eventName)
        {
            Console.WriteLine($"Событие сгенерировано объектом: {eventName}");
        }
    }
    class Program
    {
        static void Main()
        {
            One one1 = new One();
            One one2 = new One();
            Two two1 = new Two();

            one1.Event += two1.HandleEvent;
            one2.Event += two1.HandleEvent;

            one1.Generate("Первый объект");
            one2.Generate("Второй объект");

        }
    }
}

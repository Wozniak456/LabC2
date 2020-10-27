using System;

namespace LabC2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1, b1, c1, a2, b2, c2; string str;   //описуємо змінні
            Console.WriteLine("Возняк Софiя IC-01");
            Console.WriteLine("Умова: Скiльки розв'язкiв має система рiвнянь, задана коефiцiєнтами a1, b1, a2, b2 i правими частинами с1, с2");
            
            Console.Write("Введiть a1: "); // вводимо значення змінних 
            str = Console.ReadLine(); // зчитування рядка
            a1 = Convert.ToDouble(str); // конвертація з рядкового типу в числовий

            Console.Write("Введiть b1: ");
            str = Console.ReadLine();
            b1 = Convert.ToDouble(str);

            Console.Write("Введiть c1: ");
            str = Console.ReadLine();
            c1 = Convert.ToDouble(str);

            Console.WriteLine();

            Console.Write("Введiть a2: ");
            str = Console.ReadLine();
            a2 = Convert.ToDouble(str);

            Console.Write("Введiть b2: ");
            str = Console.ReadLine();
            b2 = Convert.ToDouble(str);

            Console.Write("Введiть c2: ");
            str = Console.ReadLine();
            c2 = Convert.ToDouble(str);
            Console.WriteLine($"Отриманi вiдношення:  a1/a2: {a1/a2};   b1/b2: {b1/b2};   c1/c2: {c1/c2}"); // виведення отриманих відношення

            if ((a1/a2 == b1/b2) && (a1/a2 == c1/c2)) // перевірка на те, чи прямі співпадають
            {
                Console.WriteLine("Безлiч розв'язкiв. Прямi спiвпадають");
            }
            else if (a1/a2 != b1/b2) // перевірка на перетин прямих
            {
                Console.WriteLine("Мiстить один розв'язок. Прямi перетинаються");
            }
            else // в іншому випадку прямі палалельні
            {
                Console.WriteLine("Немає розв'язкiв. Прямi паралельнi");
            }
        }
    }
}

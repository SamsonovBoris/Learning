/* Найдите любой чек, либо фотографию этого чека в интернете и схематично нарисуйте его в консоли,  
   только на место динамических, по вашему мнению, данных (это может быть дата, название магазина,
   сумма покупок) подставляйте переменные, которые были заранее заготовлены до вывода на консоль. */
 
using System;

namespace Lesson02_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string NameRestoran = "\"Лукоморье\"";
            string LocationRestoran = "Вологда, ул.Лермонтова, д.4";
            long InnRestoran = long.Parse("3525241650");
            string Line = "****************************************";
            int Employee = int.Parse("1");
            int KKM = int.Parse("00844271");
            long RNM = long.Parse("0000846400");
            string Sale = "№0412";
            string Guest = "3";
            string NameFood = "750р.";
            string Juice = "100р.";
            string ResultSumma = "850р.";
                        
            Console.WriteLine($"Кафе {NameRestoran}");
            Console.WriteLine($"Адрес {LocationRestoran}");
            Console.WriteLine($"ИНН {InnRestoran}");
            Console.WriteLine(Line);
            Console.WriteLine($"Кассир {Employee}");
            Console.WriteLine($"ККМ {KKM}");
            Console.WriteLine($"РНМ {RNM}");
            Console.WriteLine($"Продажа {Sale}");
            Console.WriteLine($"Гостей {Guest}");
            Console.WriteLine(Line);
            Console.WriteLine($"Бизнес-ланч {NameFood}");
            Console.WriteLine($"Сок в ассорт. {Juice}");
            Console.WriteLine(Line);
            Console.WriteLine($"ИТОГ {ResultSumma}");
        }
    }
}
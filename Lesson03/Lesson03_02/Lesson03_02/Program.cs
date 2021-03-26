/*  Написать программу — телефонный справочник — создать двумерный массив 5*2, хранящий список
 телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/e-mail. */

namespace Lesson03_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] TelephoneBook = new string[5, 2];
                                   
             TelephoneBook[0, 0] = "Василий Цой  ";
             TelephoneBook[1, 0] = "Сергей Дзюба ";
             TelephoneBook[2, 0] = "Анна Иванова ";
             TelephoneBook[3, 0] = "Светлана Ким ";
             TelephoneBook[4, 0] = "Денис Сидоров";

             TelephoneBook[0, 1] = "89111890890 / coi@mail.ru";
             TelephoneBook[1, 1] = "89111890891 / dzubas@gmail.com";
             TelephoneBook[2, 1] = "89111890892 / krasotka1985@yandex.ru";
             TelephoneBook[3, 1] = "89111890893 / coiZiv@mail.ru";
             TelephoneBook[4, 1] = "89111890894 / sidorovden@rambler.ru";
            
            for (int i = 0; i < TelephoneBook.GetLength(0); i++)
            {
                for (int j = 0; j < TelephoneBook.GetLength(1); j++)
                {
                    System.Console.Write($"{TelephoneBook[i, j]} ");
                }
                System.Console.WriteLine();
            }

        }
    }
}

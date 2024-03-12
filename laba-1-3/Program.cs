using System;
using System.Collections.Generic;
using System.Linq;

namespace l_1_3
{
    //Дана послідовність непустих рядків.Використовуючи метод Aggregate, отримати рядок, що складається з початкових символів всіх рядків вихідної послідовності. (1)
    //Aggregate : застосовує до елементів послідовності агрегатну функцію, яка зводить їх до одного об’єкта
    class Program
    {
        static void Main()
        {
            //
            List<string> strings = new List<string> { "Привет", "КПI", "ФIОТ", "IK-31" };

            // Использование метода Aggregate для получения строки из первых символов всех строк 
            string result = strings.Aggregate("", (current, next) => current + next[0]);// функция складывает первые символы всех строк в списке добавляя в новую строку

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
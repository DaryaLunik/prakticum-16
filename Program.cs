using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicum_16
{
    internal class Program
    {
        static void Output (ArrayList list)
        {
            foreach ( var el in list)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            // 1). Добавить в коллекцию элементы разных типов 
            // (положительное целое, строковое, логическое, положительное вещественное,
            // отрицательное целое, отрицательное вещественное).
            ArrayList list = new ArrayList();
            list.Add(3);
            list.Add("школа");
            list.Add(true);
            list.Add(9.2);
            list.Add(-4);
            list.Add(-4.8);
            // 2). Вывести список.
            Output(list);
            // 3). Определить количество элементов списка.
            int count = list.Count;
            Console.WriteLine(count);
            // 4). Вставить второй элемент со значением строковой величины.
            list.Insert(2, "дом");
            // 5). Просмотреть список.
            Output(list);
            // 6). Удалить любое положительное число.
            list.Remove(3);
            // 7). Просмотреть список.
            Output(list);
            // 8). Сделать реверс списка и просмотреть его.
            list.Reverse();
            Output(list);
            // 9). Занести в список строковый массив из трех элементов.
            string[] stringList = { "Елка", "Шишки", "Снег" };
            list.AddRange(stringList);
            // 10). Просмотреть список.
            Output(list);
            Console.ReadKey();
        }
    }
}

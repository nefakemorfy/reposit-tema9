using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Создание пустой коллекции
            List<int> ints = new List<int>();
            //2.Добавление целых значений в коллекцию
            ints.Add(1);
            ints.Add(10);
            ints.Add(25);
            ints.Add(17);
            ints.Add(10);
            foreach (int elem in ints)
            {
                Console.Write($"{elem}\t");
            }
            Console.WriteLine();
            ints.Add(30);
            foreach (int elem in ints)
            {
                Console.Write($"{elem}\t");
            }
            //3. Вставка элемента по указанному индексу(сдвиг вправо)
            Console.WriteLine();
            ints.Insert(0, 500);
            foreach (int elem in ints)
            {
                Console.Write($"{elem}\t");
            }
            //4. Добавление в список одномерного массива
            Console.WriteLine();
            ints.AddRange(new[] { -5, 0, 14 });
            foreach (int elem in ints)
            {
                Console.Write($"{elem}\t");
            }
            //5. Определение количества элементов коллекции
            Console.WriteLine();
            //int size = ints.Count;
            //Console.WriteLine($"Текущее количество элементов = {size}");
            Console.WriteLine($"Текущее количество элементов = {ints.Count}");
            //6. Определение индекса элемента со значение 25
            Console.WriteLine();
            Console.WriteLine($"Индекс элемента со значением 25 = {ints.IndexOf(25)}");
            //7. Удаление из коллекции первого вхождения элемента со значения 10
            ints.Remove(10);
            foreach (int elem in ints)
            {
                Console.Write($"{elem}\t");
            }
            //8. Удаление из коллекции элемента с указанным индексом
            Console.WriteLine();
            ints.RemoveAt(2);
            foreach (int elem in ints)
            {
                Console.Write($"{elem}\t");
            }
            //9. Сортировка коллекции по возрастанию
            Console.WriteLine();
            ints.Sort();
            foreach (int elem in ints)
            {
                Console.Write($"{elem}\t");
            }
            //10. Сортировка коллекции по убыванию
            Console.WriteLine();
            ints.Reverse();
            foreach (int elem in ints)
            {
                Console.Write($"{elem}\t");
            }
            Console.Read();
        }
    }
}

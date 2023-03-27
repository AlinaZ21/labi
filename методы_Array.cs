using System;
public class Program
{
    public static void Main()
    {
        Array a = Array.CreateInstance(typeof(int), 6);
        for (int i = a.GetLowerBound(0); i <= a.GetUpperBound(0); i++)
            a.SetValue(i*3%8+1, i);
        var people = new string[] { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };
        while (true)
        {
            Console.WriteLine("1.копия : void Array.Copy(Array sourceArray, Array destinationArray, int length)\n"+
                "2.очищение массива : void Array.Clear(Array array, int index, int length)\n" +
                "3.изменение порядка эллементов  : void Array.reverse<int>(int[] array)\n"+
                "4.cортировка массива : void Array.Sort<int>(int[] array)\n"+
                "5.поиск певого элемента по условию : string? Array.Find<string>(string[] array, Predicate<string> match)\n"+
                "6.поиск последнего элемента по условия : string? Array.FindLast<string>(string[] array, Predicate<string> match)\n"+
                "7.поиск элементов, удовлетворяющих условию : string[] Array.FindAll<string>(string[] array, Predicate<string> match)\n"+
                "8.поиск индекса элемента : int Array.BinarySearch<string>(string[] array, string value)\n"+
                "9.изменение рамера массива : void Array.Resize<string>(ref string[] array, int newSize)\n"+
                "0.Завершение программы");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (s == 1)
            {
                Array copy = Array.CreateInstance(typeof(int), 6);
                Console.Write("исходный: ");
                foreach (int i in a)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
                Array.Copy(a, copy, a.Length);
                Console.Write("копия: ");
                foreach (int i in copy)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
            else if (s == 2)
            {
                Console.Write("до: ");
                foreach (int i in a)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
                Array.Clear(a, 1, 2);
                Console.Write("после очищения 2-го и 3-го элементов: ");
                foreach (int i in a)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
            else if (s == 3)
            {
                Console.Write("до: ");
                foreach (int i in a)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
                Array.Reverse(a);
                Console.Write("после: ");
                foreach (int i in a)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
            else if(s==4)
            {
                Console.Write("до: ");
                foreach (int i in a)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
                Array.Sort(a);
                Console.Write("после: ");
                foreach (int i in a)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
            else if (s == 5)
            {
                people = new string[] { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };
                Console.WriteLine(String.Join(", ", people));
                Console.WriteLine("где длина строки больше 3 символов");
                string first = Array.Find(people, person => person.Length > 3);
                Console.WriteLine(first);
            }
            else if (s == 6)
            {
                people = new string[] { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };
                Console.WriteLine(String.Join(", ", people));
                Console.WriteLine("где длина строки больше 3 символов");
                string last = Array.FindLast(people, person => person.Length > 3);
                Console.WriteLine(last);
            }
            else if (s == 7)
            {
                people = new string[] { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };
                Console.WriteLine(String.Join(", ", people));
                Console.WriteLine("находим элементы, у которых длина строки равна 3");
                string[] group = Array.FindAll(people, person => person.Length == 3);
                foreach (var person in group) Console.WriteLine(person);
            }
            else if (s == 8) 
            {
                people = new string[] { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };
                Console.WriteLine(String.Join(", ", people));
                Console.WriteLine("находим индекс элемента Bob");
                int bobInd = Array.BinarySearch(people, "Bob");
                Console.WriteLine(bobInd);
            }
            else if (s == 9)
            {
                people = new string[] { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };
                Console.WriteLine(String.Join(", ", people));
                Console.WriteLine("уменьшим массив до 4 элементов");
                Array.Resize(ref people, 4);
                Console.WriteLine(String.Join(", ", people));
            }
            else if (s == 0)
            {
                return;
            }
            Console.WriteLine("Вернуться в меню: Enter");
            ConsoleKeyInfo v = Console.ReadKey(true);
            if (v.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                continue;
            }
        }
    }
}
using System;

namespace HW4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var arr = new int[n];
            var countEven = 0;
            var countOdd = 0;

            // заполняем рандомами
            for (var i = 0; i < arr.Length; i++)
            {
                // от 0 до 25 включительно, потому что по индексам с алвавитом выйдет на 1 больше
                arr[i] = new Random().Next(0, 24 + 1);
                if (arr[i] % 2 == 0)
                {
                    countEven++;
                }
                else
                {
                    countOdd++;
                }
            }

            // заполняем четными и нечетными
            var arrEven = new int[countEven];
            var arrOdd = new int[countOdd];
            for (int i = 0, j = 0, k = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arrEven[j] = arr[i];
                    j++;
                }
                else
                {
                    arrOdd[k] = arr[i];
                    k++;
                }
            }

            var alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            // заполняем четными с алфавита
            var arrEvenChar = new char[arrEven.Length];
            for (var i = 0; i < arrEven.Length; i++)
            {
                arrEvenChar[i] = alphabet[arrEven[i]];
            }

            // заполняем нечетными с алфавита
            var arrOddChar = new char[arrOdd.Length];
            for (var i = 0; i < arrOdd.Length; i++)
            {
                arrOddChar[i] = alphabet[arrOdd[i]];
            }

            var arrExString = new string("aeihj");

            // если есть буква из верхнего стринга, то аппером даем по лбу
            // тут же запустим счетчик под контейн, потому что наша буква и так переведется в аппер
            // но можно юзать IsUpper, но будет еще + 2 цикла
            var countForEven = 0;
            for (var i = 0; i < arrEvenChar.Length; i++)
            {
                if (arrExString.Contains(arrEvenChar[i]))
                {
                    arrEvenChar[i] = char.ToUpper(arrEvenChar[i]);
                    countForEven++;
                }
            }

            var countForOdd = 0;
            for (var i = 0; i < arrOddChar.Length; i++)
            {
                if (arrExString.Contains(arrOddChar[i]))
                {
                    arrOddChar[i] = char.ToUpper(arrOddChar[i]);
                    countForOdd++;
                }
            }

            // где апперов больше
            if (countForEven > countForOdd)
            {
                Console.WriteLine("В массиве с четными больше апперов");
            }
            else if (countForEven < countForOdd)
            {
                Console.WriteLine("В массиве с нечетными больше апперов");
            }
            else
            {
                Console.WriteLine("Ёмаё, апперов равно!");
            }

            // вывод
            Console.WriteLine();
            for (var i = 0; i < arrEvenChar.Length; i++)
            {
                Console.Write(arrEvenChar[i] + " ");
            }

            Console.WriteLine();
            for (var i = 0; i < arrOddChar.Length; i++)
            {
                Console.Write(arrOddChar[i] + " ");
            }

            Console.WriteLine();
        }
    }
}

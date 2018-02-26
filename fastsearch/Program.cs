using System;



namespace ConsoleApplication
{

    class Program
    {

        public static int BinarySearch(int[] array, int value)
        {
            if (array.Length == 0 || value < array[0] || value > array[array.Length-1])
                return -1;

            int first = 0;
            int last = array.Length;

            while (first < last)
            {
                int mid = first + (last - first) / 2;
                if (value <= array[mid])
                    last = mid;
                else
                    first = mid + 1;
            }
            if (array[last] == value)
                return last;
            else
                return -1;

        }

        static void Main(string[] args)
        {
            TestNegativeNumbers();
            TestNonExistentElement();
            TestOneElementFromFive();
            TestSameElements();
            TestEmptyArray();
            TestHugeArray();

            Console.ReadKey();
        }



        private static void TestNegativeNumbers()
        {
            //Тестирование поиска в отрицательных числах
            int[] negativeNumbers = new[] { -5, -4, -3, -2 };
            if (BinarySearch(negativeNumbers, -3) != 2)
                Console.WriteLine("! Поиск не нашёл число -3 среди чисел {-5, -4, -3, -2}");
            else
                Console.WriteLine("Поиск среди отрицательных чисел работает корректно");
        }

        private static void TestNonExistentElement()
        {
            //Тестирование поиска отсутствующего элемента
            int[] negativeNumbers = new[] { -5, -4, -3, -2 };
            if (BinarySearch(negativeNumbers, -1) >= 0)
                Console.WriteLine("! Поиск нашёл число -1 среди чисел {-5, -4, -3, -2}");
            else
                Console.WriteLine("Поиск отсутствующего элемента вернул корректный результат работает корректно");
        }

        private static void TestOneElementFromFive()
        {
            //Тестирование поиска одного элемента в массиве из 5
            int[] regularNumbers = new[] { 1, 2, 3, 4, 5 };
            if(BinarySearch(regularNumbers,4) != 3)
                Console.WriteLine("! Поиск не нашёл число 4 среди чисел {1, 2, 3, 4, 5}");
            else
                Console.WriteLine("Поиск одного элемента вернул корректный результат работает корректно");
        }

        private static void TestSameElements()
        {
            //Тестирование поиска элемента, повторяющегося несколько раз
            int[] repetetiveNumbers = new[] { 1, 2, 3, 4, 4, 5 };
            if (BinarySearch(repetetiveNumbers,4)!=3)
                Console.WriteLine("! Поиск нашёл второе число 4, вместо первого среди чисел {1, 2, 3, 4, 4, 5}");
            else
                Console.WriteLine("Поиск повторяющегося элемента вернул корректный результат работает корректно");
        }

        private static void TestEmptyArray()
        {
            //Тестирование поиска в пустом массиве (содержащем 0 элементов)
            int[] emptyArray = new int[0];
            if(BinarySearch(emptyArray,0)!=-1)
                Console.WriteLine("! Поиск нашел число в пустом элементе");
            else
                Console.WriteLine("Поиск в пустом массиве вернул корректный результат работает корректно");
        }

        private static void TestHugeArray()
        {
            //Тестирование поиска в массиве из 100001 элементов
            int size = 100001;
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
                array[i] = i;
            if(BinarySearch(array, 5000) != 5000)
                Console.WriteLine("! Поиск не нашёл число 5000 в большом массиве");
            else
                Console.WriteLine("Поиск элемента в большом массиве вернул корректный результат работает корректно");

        }
    }
}
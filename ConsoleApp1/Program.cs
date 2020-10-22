using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgram
{
    class Program
    {
        static int[] Filling_The_Array_KeyBoard(int[] array)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = Int32.Parse(Console.ReadLine());                
            }

            return array;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введіть розмір одновимірного масива А (тобто від 2 і більше):");

            CreateArray array_A = new CreateArray();
            int size_Array = array_A.size_Array;

            if (size_Array >= 2)
            {
                Console.WriteLine("Введіть в одновимірний масив, під назвою А і який складається з {0} елементів, числа в діапазоні від -10 до 10 (якщо дане вами число не буде входити в цей діапазон, то програма автоматично запише у ваш елемент нуль):", size_Array);

                int[] array = new int[size_Array];

                array = Filling_The_Array_KeyBoard(array);

                array_A = new CreateArray(array);

                int max = 0;
                int min = 0;
                max = Find_Maximum_Element(max, array_A);
                min = Find_Minimum_Element(min, array_A);

                Console.Write("Ваш масив: ");

                for (int i = 0; i < array_A.Length; ++i)
                {
                    Console.Write("{0}, ", array_A[i]);
                }

                Console.Write("(мінімальний елемент в масиві: min = {0}; ", min);
                Console.Write("максимальний: max = {0})!", max);

            }
            else
            {
                Console.WriteLine("Неправильний розмір, спробуйте ще раз!");
            }

            Console.ReadKey();

        }
        
        static int Find_Maximum_Element(int max, CreateArray array)
        {
            max = array[0];

            for (int i = 1; i < array.Length; ++i)
            {
                if (max < array[i])
                {
                    max = array[i];
                }

            }

            

            return max;
        }

        static int Find_Minimum_Element(int min, CreateArray array)
        {
            min = array[0];

            for (int i = 1; i < array.Length; ++i)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
                
            }

            

            return min;
        }

    }
}
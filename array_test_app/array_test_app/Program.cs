using array_test_app.Tools;
using System;

namespace array_test_app
{
    class Program
    {
        static void Main(string[] args) {

            var arraySize = GetRandomArraySize();

            Console.WriteLine();

            int[] testArray = InitialArrayBySize(arraySize);

            Console.WriteLine();

            var mValue = GetRandomMValue(testArray.Length);

            Console.WriteLine();

            if (isZeroInArrayBeforeIndex(testArray, mValue))
            {
                Console.WriteLine("ДА - нулевое значение содержится в массиве.");
            }
            else Console.WriteLine("НЕТ - нулевое значение НЕ содержится в массиве.");

            Console.WriteLine();

            Console.ReadKey();

        }

        private static int GetRandomArraySize() {

            var size = GetRandomInteger();

            Console.WriteLine($"Тестируемый размер массива: {size}");
            return size;
        }

        private static int GetRandomInteger(int maxValue = 21) {

            var rand = new Random();
            var value = rand.Next(10, maxValue);
            
            return value;
        }

        private static int GetRandomMValue(int maxValue) {

            var value = GetRandomInteger(maxValue);

            Console.WriteLine($"M занчение для теста: {value}");
            return value;
        }

        private static int[] InitialArrayBySize(int size) {

            int[] nums = new int[size];
            Console.WriteLine("Элементы массива: ");            
            nums[0] = 0;
            ConsoleTool.WriteLineConsoleGreenMessage($"Элемент 0: {nums[0]}");  
           
            for (int i = 1; i<nums.Length; i++)
            {
                var rand = new Random();
                var data = rand.Next(0, 10);

                nums[i] = data;

                if (data.Equals(0))
                {
                    ConsoleTool.WriteLineConsoleGreenMessage($"Элемент {i}: {nums[i]}");
                }
                else
                {
                    Console.WriteLine($"Элемент {i}: {nums[i]}");
                }                
            }

            return nums;
        }

        private static bool isZeroInArrayBeforeIndex(int[] array , int searchBeforeIndex) {            

            var subArray = array[0..searchBeforeIndex];

            return Array.Exists(subArray, element => element.Equals(0));            
        }
    }
}

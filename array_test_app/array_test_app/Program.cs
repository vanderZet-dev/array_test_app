using System;
using System.Threading;

namespace array_test_app
{
    class Program
    {     
        private static int zeroIsFind = 0;

        private static readonly int maxIndexForCheck = 3;

        static void Main(string[] args) {

            int[] someArray = { 9, 5, 6, 6, 9, 8, 8 };
            int lastIndexToCheck = someArray.Length - maxIndexForCheck - 1;

            RecursionAnalise(someArray, lastIndexToCheck);

            Console.ReadKey();
        }

        private static void RecursionAnalise(int[] someArray, int nextIndex) {

            int currentValue = someArray[nextIndex];

            int result = ConvertToOneZero(currentValue);
            translateResult(result);
            ShowResult();            

            nextIndex = nextIndex - GetIndexDecreasing(nextIndex);
            RecursionAnalise(someArray, nextIndex);
        }

        private static int GetIndexDecreasing(int currentIndex) {

            int coef = ConvertToOneZero(currentIndex);
            int delta = coef * 1 + (1 - coef) * 0;

            return delta;
        }

        private static void ShowResult() {

            Thread.Sleep(500);

            Console.Clear();

            int convertedAnswerCoef = ConvertToOneZero(zeroIsFind);

            Console.Write(Convert.ToChar(convertedAnswerCoef * 'Y' + (1 - convertedAnswerCoef) * 'N'));
            Console.Write(Convert.ToChar(convertedAnswerCoef * 'e' + (1 - convertedAnswerCoef) * 'o'));
            Console.Write(Convert.ToChar(convertedAnswerCoef * 's'));
            Console.WriteLine();
        }

        private static int ConvertToOneZero(int value) {

            double d = Convert.ToDouble(value);
            double roudedValue = Math.Round(d / (d + 1.0), MidpointRounding.AwayFromZero);
            return Convert.ToInt32(roudedValue);
        }

        private static void translateResult(int result) {

            int coef = result * 0 + (1 - result) * 1;

            zeroIsFind = zeroIsFind + coef;
        }
    }
}

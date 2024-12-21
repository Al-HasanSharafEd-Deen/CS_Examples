using System.Diagnostics.Metrics;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_Session05
{
    internal class Program
    {
        #region Q1 Functions
        // Example: Pass By Value
        public static void SwapByValue(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        // Example: Pass By ref
        public static void SwapByReference(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        #endregion

        #region Q2 Functions
        // Example: Pass By Value
        public static void ModifyArrayByValue(int[] arr)
        {
            arr[0] = 30;                    // Modifies the array
            arr = new int[] { 1, 2, 3 };    // This reassignment does not affect the original array
        }

        // Example: Pass By ref
        public static void ModifyArrayByReference(ref int[] arr)
        {
            arr[0] = 30;                   // Modifies the array
            arr = new int[] { 1, 2, 3 };   // This reassignment affects the original array
        }
        #endregion

        #region Q3 Functions
        public static void Calculate(int a, int b, out int sum, out int sub)
        {
            sum = a + b;
            sub = a - b;
        }

        #endregion

        #region Q4 Functions
        public static int SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        #endregion

        #region Q5 Functions
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        #endregion

        #region Q6 Functions
        public static void MinMaxArray(int[] arr, out int min, out int max)
        {
            min = int.MaxValue;
            max = int.MinValue;

            foreach (int num in arr)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }
        }
        #endregion

        #region Q7 Functions
        public static int Factorial(int num)
        {
            int result = 1;
            for (int i = 2; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
        #endregion

        #region Q8 Functions
        public static string ChangeChar(string input, int position, char newChar)
        {
            if (string.IsNullOrEmpty(input))
                return input;              // Return the input as is if it's null or empty

            if (position < 0 || position >= input.Length)
                return input;              // Return the input as is if the position is invalid

            // Create a new string with the modified character
            char[] charArray = input.ToCharArray();
            charArray[position] = newChar;
            return new string(charArray);
        }

        #endregion

        static void Main(string[] args)
        {
            #region 1.Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            /// Passing By Value is Mean:
            /// copy of  variable value is passed to the method.
            /// Changes made to the parameter inside the method.
            /// Not affect the original variable.
            // Example:
            //int num1 = 3 ; int num2 = 5;
            //Console.WriteLine($"Before Swap: num1 = {num1}, num2 = {num2}");
            //SwapByValue(num1, num2);
            //Console.WriteLine($"After SwapByValue: num1 = {num1}, num2 = {num2}");

            /// Passing By Reference is Mean:
            /// A reference to the original variable is passed to the method.
            /// Changes made to the parameter inside the method affect the original variable.
            // Example:
            //int num1 = 3; int num2 = 5;
            //Console.WriteLine($"Before Swap: num1 = {num1}, num2 = {num2}");
            //SwapByReference(ref num1, ref num2);
            //Console.WriteLine($"After SwapByReference:  num1 = {num1}, num2 = {num2}");
            #endregion

            #region 2.Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            /// Passing by Value is Mean that:
            /// copy of the reference is passed.
            /// Changes to the object will persist.
            /// reassigning the reference itself will not affect the original variable.
            /// Example:
            //int[] arr = { 10, 20, 30 };

            //Console.WriteLine("Original array:");
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //ModifyArrayByValue(arr);
            //Console.WriteLine("================================");
            //Console.WriteLine("After ModifyArrayByValue:");
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //ModifyArrayByValue(arr);

            /// Passing by Reference is Mean that:
            /// The actual reference is passed.
            /// changes to the object or reassignments to the reference affect the original variable.
            /// Example:
            //int[] arr = { 10, 20, 30 };

            //Console.WriteLine("Original array:");
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //ModifyArrayByReference(ref arr);
            //Console.WriteLine("================================");
            //Console.WriteLine("After ModifyArrayByRef:");
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //ModifyArrayByValue(arr);
            #endregion

            #region 3.Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers.
            //Console.Write("Enter first number: ");
            //bool isParsed1 = int.TryParse(Console.ReadLine(), out int num1);

            //Console.Write("Enter second number: ");
            //bool isParsed2 = int.TryParse(Console.ReadLine(), out int num2);

            //if (isParsed1 && isParsed2)
            //{
            //    Calculate(num1, num2, out int sum, out int sub);
            //    Console.WriteLine($"Summation: {sum}, Subtraction: {sub}");
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid Numbers");
            //}
            #endregion

            #region 4.Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            /// Output should be like
            /// Enter a number: 25
            /// The sum of the digits of the number 25 is: 7
            //Console.Write("Enter ur number: ");
            //bool isParsed1 = int.TryParse(Console.ReadLine(), out int num1);

            //if (isParsed1)
            //{
            //    int result = SumOfDigits(num1);
            //    Console.WriteLine($"The sum of the digits of the number {num1} is: {result}");
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid Numbers");
            //}
            #endregion

            #region 5.Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not.
            //Console.Write("Enter ur number: ");
            //bool isParsed1 = int.TryParse(Console.ReadLine(), out int num1);

            //if (isParsed1)
            //{
            //    bool result = IsPrime(num1);
            //    Console.WriteLine($"the Number Is Prime? : {result}");
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid Numbers");
            //}
            #endregion

            #region 6.Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters.
            //Console.Write("Enter Ur Array Size: ");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int arrSize);

            //if (isParsed)
            //{
            //    int[] arr = new int[arrSize];
            //    for (int i = 0; i < arrSize; )
            //    {
            //        Console.WriteLine($"Pls Element Number {i + 1}: ");
            //        bool Flag = int.TryParse(Console.ReadLine(), out arr[i]);
            //        if (Flag) ++i;
            //    }

            //    MinMaxArray(arr, out int min, out int max);
            //    Console.WriteLine($"Minimum: {min}, Maximum: {max}");
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid Array Size");
            //}
            #endregion

            #region 7.Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter.
            //Console.Write("Enter ur number: ");
            //bool isParsed1 = int.TryParse(Console.ReadLine(), out int num1);

            //if (isParsed1)
            //{
            //    int result = Factorial(num1);
            //    Console.WriteLine($"Factorial of {num1} is: {result}");
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid Numbers");
            //}
            #endregion

            #region 8.Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter.
            //Console.Write("Enter the original string: ");
            //string originalString = Console.ReadLine();
            //Console.Write("Enter the position to modify (0-based): ");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int position);

            //if (!isParsed)
            //{
            //    Console.WriteLine("Error: Invalid position input");
            //    return;
            //}

            //Console.Write("Enter the new character: ");
            //char newChar = Console.ReadKey().KeyChar;
            //Console.WriteLine();

            //string modifiedString = ChangeChar(originalString, position, newChar);

            //Console.WriteLine($"Modified string: {modifiedString}");
            #endregion

        }
    }
}

using System;
using System.Diagnostics.Metrics;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_Session04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            /// Example: Input: 5
            /// Output: 1, 2, 3, 4, 5
            //Console.Write("Pls Enter The Number: ");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int num);
            //if (isParsed)
            //{
            //    for (int i = 1; i <= num; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid Number");
            //}
            #endregion

            #region 2.Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            /// Example: Input: 5
            /// Outputs: 5 10 15 20 25 30 35 40 45 50 55 60
            //Console.Write("Pls Enter The Number: ");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int num);
            //if (isParsed)
            //{
            //    for (int i = 1; i <= 12; i++)
            //    {
            //        Console.WriteLine($"{num} * {i} = {num * i}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid Number");
            //}
            #endregion

            #region 3.Write a program that allows to user to insert number then print all even numbers between 1 to this number.
            /// Example:  Input: 15
            /// Output: 2 4 6 8 10 12 14
            //Console.Write("Pls Enter The Number: ");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int num);
            //if (isParsed)
            //{
            //    Console.WriteLine("Even Numbers in the Range: ");
            //    for (int i = 1; i <= num; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid Number");
            //}
            #endregion

            #region 4.Write a program that takes two integers then prints the power.
            /// Example:  Input: 4 3
            /// Output: 64
            /// Hint: how to calculate 4 ^ 3 = 4 * 4 * 4 = 64
            //Console.Write("Pls Enter The Base Number: ");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int baseNum);

            //Console.Write("Pls Enter The Power Number: ");
            //bool isParsed2 = int.TryParse(Console.ReadLine(), out int powerNum);

            //if (isParsed && isParsed2)
            //{
            //    int result = 1;
            //    for (int i = 1; i <= powerNum; i++)
            //    {
            //        result *= baseNum;
            //    }
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid Number");
            //}
            #endregion

            #region 5.Write a program to enter marks of five subjects and calculate total, average and percentage.
            /// Input:  Enter Marks of five subjects: 95 76 58 90 89
            /// Output: Total marks   = 408
            ///         Average Marks = 81
            ///         Percentage    = 81
            //Console.Write("Pls Enter Number of Subjects that u need calculate it: ");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int subNum);
            //int total = 0, average = 0, precent = 0;

            //if (isParsed )
            //{
            //    for (int i = 0; i < subNum; /*i++*/)
            //    {
            //        Console.Write($"Mark of Subject {i+1}:  ");
            //        bool isParsed2 = int.TryParse(Console.ReadLine(), out int mark);
            //        if (isParsed2)
            //        {
            //            total += mark;
            //            average = (int)total / subNum;
            //            precent = (int) total / subNum;
            //            i++;
            //        }
            //    }
            //    Console.WriteLine($"Total Marks = {total}");
            //    Console.WriteLine($"Average Marks = {average}");
            //    Console.WriteLine($"Percentage = {precent}%");
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid Number");
            //}
            #endregion

            #region 6.Write a program to allow the user to enter a string and print the REVERSE of it.
            //Console.Write("Enter Ur String that U want reverse it: ");
            //string str = Convert.ToString(Console.ReadLine());
            //string reverse = new string (str.Reverse().ToArray());
            //Console.WriteLine($"Reversed String is: {reverse}");
            #endregion

            #region 7.Write a program to allow the user to enter int and print the REVERSED of it
            //Console.Write("Enter an integer Number that u need reverse it: ");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int inputNum);
            //if (isParsed)
            //{
            //    int reversed = 0 , digit;
            //    // repeat number = number of digit
            //    while (inputNum != 0)
            //    {
            //        digit = inputNum % 10;       // Get the last digit
            //        reversed *= 10 + digit;      // Add it to the reversed number
            //        inputNum /= 10;              // Remove the last digit
            //    }

            //    Console.WriteLine($"Reversed integer: {reversed}");
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid Integer Number");
            //}
            #endregion

            #region 8.Write a program in C# Sharp to find prime numbers within a range of numbers.
            /// Test Data:
            /// Input starting number of ranges: 1
            /// Input ending number of range: 50
            /// Expected Output :
            /// The prime number between 1 and 50 are:
            /// 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47

            //Console.Write("Pls Enter The Starting Number: ");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int startNum);

            //Console.Write("Pls Enter The Ending Number: ");
            //bool isParsed2 = int.TryParse(Console.ReadLine(), out int endNum);
            //Console.Clear();

            //if (isParsed && isParsed2)
            //{
            //    Console.WriteLine($"The Prime Number between {startNum} and {endNum} are: ");
            //    Console.WriteLine("----------------------------------");
            //    for (int num = startNum ; num <= endNum; num++)
            //    {
            //        if (num <= 1) continue;

            //        bool isPrime = true; // initial value --> will change if number is not prime number.

            //        // Check divisibility from 2 to the number-1 (inclusive)
            //        for (int i = 2; i < num; i++)
            //        {
            //            if (num % i == 0)
            //            {
            //                isPrime = false; // Not a prime number if divisible.
            //                break;
            //            }
            //        }

            //        // If the number is prime, print it
            //        if (isPrime)  Console.WriteLine(num);    
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid Number");
            //}
            #endregion

            #region 9.Write a program in C# Sharp to convert a decimal number into binary without using an array.
            /// Test Data :
            /// Enter a number to convert: 25
            /// Expected Output :
            /// The Binary of 25 is 11001.
            //Console.Write("Pls Enter The Decimal Number: ");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int num);
            //if (isParsed)
            //{
            //    // Convert decimal to binary using the built-in Convert.ToString() method
            //    string binaryNum = Convert.ToString(num , 2);

            //    // Display the binary number
            //    Console.WriteLine($"The Binary of {num} is {binaryNum}");
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid Number");
            //}
            #endregion

            #region 10.Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            // take a first point
            //Console.WriteLine("Pls, Enter The First Point [x1 , y1]: ");
            //int[] point1 = new int[2];
            //for (int i = 0; i < point1.Length; /*i++*/)
            //{
            //    bool Flag = int.TryParse(Console.ReadLine(), out point1[i]);
            //    if (Flag)
            //        ++i;
            //}
            //Console.Clear();
            //// take a second point
            //Console.WriteLine("Pls, Enter The Second Point [x2 , y2]: ");
            //int[] point2 = new int[2];
            //for (int j = 0; j < point1.Length; /*i++*/)
            //{
            //    bool Flag = int.TryParse(Console.ReadLine(), out point2[j]);
            //    if (Flag)
            //        ++j;
            //}
            //Console.Clear();
            //// take a third point
            //Console.WriteLine("Pls, Enter The Third Point [x3 , y3]: ");
            //int[] point3 = new int[2];
            //for (int k = 0; k < point1.Length; /*i++*/)
            //{
            //    bool Flag = int.TryParse(Console.ReadLine(), out point2[k]);
            //    if (Flag)
            //        ++k;
            //}
            //Console.Clear();

            //// program logic
            //if (((point2[1] - point1[1]) * (point3[0] - point2[0])) == ((point3[1] - point2[1]) * (point2[0] - point1[0])))
            //{
            //    Console.WriteLine("Points is lie on a straight line");
            //}
            //else
            //{
            //    Console.WriteLine("Points is not lie on a straight line");
            //}
            #endregion

            #region 11.Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            // Take Matrix size From User:
            //Console.Write("Pls Enter The Matrix Size: ");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int matrixSize);
            //if (isParsed)
            //{
            //    int[,] identityMatrix = new int[matrixSize, matrixSize];
            //    for (int i = 0; i < identityMatrix.GetLength(0); i++)
            //    {

            //        for (int k = 0; k < identityMatrix.GetLength(1); )
            //        {
            //            if (i == k)
            //            {
            //                identityMatrix[i, k] = 1;
            //            }
            //            else
            //            {
            //                identityMatrix[i, k] = 0;
            //            }
            //            ++k;
            //        }
            //    }
            //    // Print the identity matrix
            //    Console.WriteLine("Identity Matrix:");
            //    for (int j = 0; j < identityMatrix.GetLength(0); j++)
            //    {
            //        for (int k = 0; k < identityMatrix.GetLength(1); k++)
            //        {
            //            Console.Write($"{identityMatrix[j, k]}  ");
            //        }
            //        Console.WriteLine(); // Move to the next row
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid Matrix Size");
            //}
            #endregion

            #region 12.Write a program in C# Sharp to find the sum of all elements of the array.
            // Take Matrix size From User:
            //Console.Write("Pls Enter The Matrix Size: ");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int arraySize);
            //if (isParsed)
            //{
            //    int sum = 0;
            //    int[] arr = new int[arraySize];
            //    for (int i = 0; i < arr.Length; )
            //    {
            //        Console.WriteLine($"Pls Element Number {i +1}: ");
            //        bool Flag = int.TryParse(Console.ReadLine(), out arr[i]);
            //        sum += arr[i];
            //        if (Flag)  ++i;
            //    }
            //    Console.WriteLine($"The Sum Of The Array Elements = {sum}");
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid Matrix Size");
            //}
            #endregion

            #region 13.Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            // Take Array Size From User:
            //Console.Write("Pls Enter The Matrix Size: ");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int arraySize);
            //if (isParsed)
            //{

            //    int[] arr1     = new int[arraySize];
            //    int[] arr2     = new int[arraySize];
            //    int[] mergeArr = new int[arraySize*2];

            //    // Take Array_1 Elements:
            //    Console.WriteLine("Enter Array_1 Elements: ");
            //    for (int i = 0; i < arr1.Length;)
            //    {
            //        Console.WriteLine($"Pls Element Number {i + 1}: ");
            //        bool Flag = int.TryParse(Console.ReadLine(), out arr1[i]);
            //        mergeArr[i] = arr1[i];
            //        if (Flag) ++i;
            //    }
            //    Console.WriteLine("------------------------");
            //    Console.Clear();

            //    // Take Array_2 Elements:
            //    Console.WriteLine("Enter Array_2 Elements: ");
            //    for (int j = 0; j < arr1.Length;)
            //    {
            //        Console.WriteLine($"Pls Element Number {j + 1}: ");
            //        bool Flag = int.TryParse(Console.ReadLine(), out arr1[j]);
            //        mergeArr[j + arraySize] = arr1[j];
            //        if (Flag) ++j;
            //    }
            //    Console.WriteLine("------------------------");
            //    Console.Clear();

            //    // print Merged Array:
            //    Console.WriteLine("Merged Array Elements: ");
            //    for (int k = 0; k < mergeArr.Length; k++)
            //    {
            //        Console.Write($"{mergeArr[k]} ");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid Matrix Size");
            //}
            #endregion

            #region 14.Write a program in C# Sharp to count the frequency of each element of an array.
            // Take Matrix size From User:
            //Console.Write("Pls Enter The Matrix Size: ");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int arraySize);
            //if (isParsed)
            //{
            //    // Take Elements From User
            //    int[] arr = new int[arraySize];
            //    for (int i = 0; i < arr.Length;)
            //    {
            //        Console.Write($"Pls Element Number {i + 1}: ");
            //        bool Flag = int.TryParse(Console.ReadLine(), out arr[i]);
            //        if (Flag) ++i;
            //    }
            //    // get Frequency of Each Element
            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        int count = 0;
            //        for (int k = 0; k < arr.Length; k++)
            //        {
            //            if (arr[j] == arr[k]) count++;
            //        }
            //        Console.WriteLine($"Frequency of element {arr[j]} is : {count} times ");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid Matrix Size");
            //}
            #endregion

            #region 15.Write a program in C# Sharp to find maximum and minimum element in an array.
            // Take Matrix size From User:
            //Console.Write("Pls Enter The Matrix Size: ");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int arraySize);
            //if (isParsed)
            //{
            //    int[] arr = new int[arraySize];
            //    for (int i = 0; i < arr.Length;)
            //    {
            //        Console.WriteLine($"Pls Element Number {i + 1}: ");
            //        bool Flag = int.TryParse(Console.ReadLine(), out arr[i]);
            //        if (Flag) ++i;
            //    }
            //    Console.WriteLine($"Maximum Element in Array is: {arr.Max()}"); // get max element
            //    Console.WriteLine($"Minimum Element in Array is: {arr.Min()}"); // get min element
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid Matrix Size");
            //}
            #endregion

            #region 16.Write a program in C# Sharp to find the second largest element in an array.
            // Take Matrix size From User:
            //Console.Write("Pls Enter The Matrix Size: ");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int arraySize);
            //if (isParsed)
            //{
            //    int[] arr = new int[arraySize];
            //    for (int i = 0; i < arr.Length;)
            //    {
            //        Console.WriteLine($"Pls Element Number {i + 1}: ");
            //        bool Flag = int.TryParse(Console.ReadLine(), out arr[i]);
            //        if (Flag) ++i;
            //    }

            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        if (arr[j] == arr.Max()) arr[j] = 0;
            //    }
            //    Console.WriteLine($"The Second Largest Element in Array is: {arr.Max()}"); // get the second largest
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid Matrix Size");
            //}
            #endregion

            #region 17.write a program find the longest distance between Two equal cells. 
            //// Take Matrix size From User:
            //Console.Write("Pls Enter The Matrix Size: ");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int arraySize);
            //if (isParsed)
            //{
            //    // Take Elements From User
            //    int[] arr = new int[arraySize];
            //    for (int i = 0; i < arr.Length;)
            //    {
            //        Console.Write($"Pls Element Number {i + 1}: ");
            //        bool Flag = int.TryParse(Console.ReadLine(), out arr[i]);
            //        if (Flag) ++i;
            //    }

            //    // get Longest distance between equal cells
            //    int maxDistance = 0;

            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        for (int j = i + 1; j < arr.Length; j++)
            //        {
            //            if (arr[i] == arr[j])
            //            {
            //                int distance = j - i;
            //                if (distance > maxDistance)
            //                {
            //                    maxDistance = distance - 1;
            //                }
            //            }
            //        }
            //    }
            //    Console.WriteLine($"Longest distance between equal cells is : {maxDistance}");
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid Matrix Size");
            //}
            #endregion

            #region 18.Given a list of space separated words, reverse the order of the words.
            // Example Input: "this is a test"
            // Example Output: "test a is this"
            //Console.Write("Enter a sentence: ");
            //string sentence = Console.ReadLine();
            //string[] words = sentence.Split(' ');
            //Array.Reverse(words);
            //Console.WriteLine(string.Join(" ", words));
            #endregion

            #region 19.Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
            // Take Array Size From User:
            //Console.Write("Please enter the number of rows: ");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int rows);
            //Console.Write("Please enter the number of columns: ");
            //isParsed &= int.TryParse(Console.ReadLine(), out int cols);

            //if (isParsed)
            //{
            //    // Create two 2D arrays of the same size
            //    int[,] arr1 = new int[rows, cols];
            //    int[,] arr2 = new int[rows, cols];

            //    // Take Array_1 Elements from User:
            //    Console.WriteLine("Enter elements for Array_1: ");
            //    for (int i = 0; i < rows; i++)
            //    {
            //        for (int j = 0; j < cols; j++)
            //        {
            //            Console.Write($"Enter element at [{i + 1}, {j + 1}]: ");
            //            bool Flag = int.TryParse(Console.ReadLine(), out arr1[i, j]);
            //            while (!Flag)
            //            {
            //                Console.Write("Invalid input. Please enter a valid number: ");
            //                Flag = int.TryParse(Console.ReadLine(), out arr1[i, j]);
            //            }
            //        }
            //    }

            //    // Copy elements from Array_1 to Array_2:
            //    for (int i = 0; i < rows; i++)
            //    {
            //        for (int j = 0; j < cols; j++)
            //        {
            //            arr2[i, j] = arr1[i, j];
            //        }
            //    }

            //    // Print Array_2:
            //    Console.WriteLine(" Array_2 (copied from Array_1): ");
            //    for (int i = 0; i < rows; i++)
            //    {
            //        for (int j = 0; j < cols; j++)
            //        {
            //            Console.Write($"{arr2[i, j]} ");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid input for rows or columns.");
            //}
            #endregion

            #region 20.Write a Program to Print One Dimensional Array in Reverse Order
            // Take Matrix size From User:
            Console.Write("Pls Enter The Matrix Size: ");
            bool isParsed = int.TryParse(Console.ReadLine(), out int arraySize);
            if (isParsed)
            {
                int[] arr = new int[arraySize];
                for (int i = 0; i < arr.Length;)
                {
                    Console.WriteLine($"Pls Element Number {i + 1}: ");
                    bool Flag = int.TryParse(Console.ReadLine(), out arr[i]);
                    if (Flag) ++i;
                }
                Array.Reverse(arr);
                Console.WriteLine($"Reversed array:  {string.Join(" ", arr)}");
            }
            else
            {
                Console.WriteLine("Error: Invalid Matrix Size");
            }
            #endregion
        }
    }
}

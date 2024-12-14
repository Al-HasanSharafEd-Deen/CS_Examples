using System.Reflection.Metadata;

namespace Assignment_Session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 - Write a program that allows the user to enter a number then print it.
            Console.Write("Pls, Enter Ur Num: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"The Num is: {num}");
            #endregion

            #region Q2 - Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen
            string str = "ALhasan55"; //"55";
            bool IsParsed = int.TryParse(str, out int num);
            Console.WriteLine(num);
            Console.WriteLine(IsParsed);
            /*What Will Happen?
            TryParse Handle Exception in wrong Format and Null so that, Num Return 0 & IsParsed Return False.
            If str in Numeric Format, Num Return the number & IsParsed Return true.*/
            #endregion

            #region Q3 - Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            float num1 = 10.9928f;
            float num2 = 11.9928f;

            float sum = num1 + num2; // 22.9856
            Console.WriteLine($"{num1} + {num2} = {sum}"); // return 22.9856
            /*what will happen?
             * In this case the two number can stored into float datatype, so that the sum will stored in float without problems.
             * In Case We Stored A larger Number that Float cant Store it, may sometimes lose precision or have rounding errors due 
               to the limitations of floating-point representation.
             */
            #endregion

            #region Q4 - Write C# program that Extract a substring from a given string.
            string givString = "Al-Hasan Sharaf El-Deen";
            string subString = givString.Substring(9, 6);
            Console.WriteLine($"subString: {subString}");
            #endregion

            #region Q5 - Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            int Num1 = 55;
            int Num2 = Num1; //55
            // Modifying:
            Num1 *= 2; // 110
            Console.WriteLine($"Number_1 is: {Num1} \nNumber_2 is: {Num2}");
            /*What Will Happen?
             * In the first num1 stored in stack with value = 55, and num2 stored with num1 value so num2 in stack = 55
             * Then, After assign values and store it , we modify num1 value by *2
             * Num1 value will change to = 110, but num2 as it was = 55 because it take num1 value in the first not after modifition
             */
            #endregion

            #region Q6 - Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            int[] array1 = { 1, 2, 3 };
            int[] array2 = array1;
            array2[0] = 10;
            Console.WriteLine($"array1[0]: {array1[0]}, array2[0]: {array2[0]}");
            ///*What Will Happen?
            // * In the first array1 stored in heap with reference, and array2 stored with the same reference
            // * Then, the to array point to the same value so Both changed.
            // */

            #endregion

            #region Q7 - Write C# program that take two string variables and print them as one variable 
            string str1 = "Al-Hasan";
            string str2 = "Sharaf El-Deen";
            string fullString = $"{str1} {str2}";
            Console.WriteLine( fullString );

            #endregion

            #region Q8 - Write a program that calculates the simple interest given the principal amount, rate of interest, and time
            // Note :  The formula for simple interest is Interest = (principal * rate * time ) /100.
            Console.Write("Enter Principal Amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Rate of Interest: ");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Time: ");
            double time = Convert.ToDouble(Console.ReadLine());
            double interest = (principal * rate * time) / 100;
            Console.WriteLine($"Simple Interest: {interest}");
            #endregion

            #region Q9 - Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 
            // Note: The formula for BMI is BMI = (Weight) / (Height * Height)
            Console.Write("Enter Weight in kilograms(kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Height in meters (m): ");
            double height = Convert.ToDouble(Console.ReadLine());
            double bmi = weight / (height * height);
            Console.WriteLine($"BMI: {bmi}"); 
            #endregion

            #region Q10 - Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result.
            ///that below 10 degrees is "Just Cold"
            ///above 30 degrees is "Just Hot"
            ///anything else is "Just Good"
            Console.Write("Enter the Temp: ");
            int temp = Convert.ToInt32(Console.ReadLine());
            string Result = temp < 10 ? "Just Cold" : (temp > 30 ? "Just Hot" : "Just Good");
            Console.Write(Result);
            #endregion

            #region Q11  Write a program that takes the date from the user and displays it in various formats using string interpolation.
            ///Ex:
            ///Today’s date : 20 , 11 , 2001
            ///Today's date : 20 / 11 / 2001
            ///Today's date : 20 – 11 – 2001
            Console.Write("PLS, Enter Day: ");
            int Day = Convert.ToInt32(Console.ReadLine());

            Console.Write("PLS, Enter Month: ");
            int Month = Convert.ToInt32(Console.ReadLine());

            Console.Write("PLS, Enter Year: ");
            int Year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Today’s date: {Day} , {Month} , {Year}");
            Console.WriteLine($"Today’s date: {Day} / {Month} / {Year}");
            Console.WriteLine($"Today’s date: {Day} - {Month} - {Year}");

            #endregion

            #region Q12 - Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            ///Example(1)
            ///Input: 12
            ///Output: Yes
            ///Example(2)
            ///Input: 9
            ///Output: No
            Console.Write("Enter Ur Num: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string Result = num % 3 == 0 && num % 4 == 0 ? "Yes" : "No";
            Console.WriteLine(Result);

            #endregion

            #region Q13 - Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            ///Example(1)
            ///Input: -5
            ///Output: negative
            ///Example(2)
            ///Input: 10
            ///Output: positive
            Console.Write("Enter Ur Num: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string Result = num < 0 ? "Negative" : "Positive";
            Console.WriteLine(Result);

            #endregion

            #region Q14 - Write a program that takes 3 integers from the user then prints the max element and the min element.
            ///Example(1)
            ///Input: 7,8,5
            ///Output:
            ///max element = 8
            ///min element = 5
            ///Example(2)
            ///Input: 3 6 9
            ///Outputs:
            ///Max element = 9
            ///Min element = 3
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            //check max
            if (num1 > num2 && num1 > num3)
            {
               Console.WriteLine($"Max Number: {num1}");
            }
            else if (num2 > num1 && num2 > num3)
            {
               Console.WriteLine($"Max Number: {num2}");
            }
            else if (num3 > num1 && num3 > num2)
            {
               Console.WriteLine($"Max Number: {num3}");
            }
            //check min
            if (num1 < num2 && num1 < num3)
            {
               Console.WriteLine($"Min Number: {num1}");
            }
            else if (num2 < num1 && num2 < num3)
            {
               Console.WriteLine($"Min Number: {num2}");
            }
            else if (num3 < num1 && num3 < num2)
            {
               Console.WriteLine($"Min Number: {num3}");
            }
            #endregion

            #region Q15 - Write a program that allows the user to insert an integer number then check If a number is even or odd.
            Console.Write("Enter Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            //Program Logic
            if (num1 % 2 == 0)
            {
               Console.WriteLine("Even");
            }
            else
            {
               Console.WriteLine("Odd");
            }
            #endregion

            #region Q16 - Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            ///Example(1)
            ///Input: O
            ///Output: vowel
            ///Example(2)
            ///Input: b
            ///Output: Consonant
            Console.Write("Enter Char: ");
            char Char = Convert.ToChar(Console.ReadLine());
            //Program Logic
            if (Char == 'a' || Char == 'e' || Char == 'i' || Char == 'o' || Char == 'u')
            {
               Console.WriteLine("Vowel");
            }
            else
            {
               Console.WriteLine("Consonant");
            }
            #endregion

            #region Q17 - Write a program to input the month number and print the number of days in that month.
            /// Example
            /// Input: Month Number: 1
            /// Output: Days in Month: 31
            Console.Write("Enter Month Number: ");
            int month =Convert.ToInt32(Console.ReadLine());
            int days;
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
               days = 31;
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
               days = 30;
            }
            else if (month == 2)
            {
               days = 28;
            }
            else
            {
               Console.WriteLine("Invalid month number.");
               return;
            }
            Console.WriteLine($"Days in Month: {days}");
            #endregion
        }
    }
}

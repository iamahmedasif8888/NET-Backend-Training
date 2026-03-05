// // See https://aka.ms/new-console-template for more information

// // This is a simple C# console application that prints "Hello, World!" to the console.
Console.WriteLine("Hello, World!");

// // This is a simple C# console application that prints a number to the console.
int number = 42;
Console.WriteLine($"The number is: {number}");

// This is a simple C# console application that prints the value of pi to the console.
float pi = 3.14f;
Console.WriteLine($"The value of pi is: {pi}");
Console.WriteLine($"The product of pi and the number is: {pi * number}");


// This is a simple C# console application that converts a distance from meters to kilometers.
Console.WriteLine("Enter a distance in meters: ");
double meter = Convert.ToDouble(Console.ReadLine());
double kilometer = meter / 1000.0;
Console.WriteLine($"The distance in kilometers is: {kilometer}");

// This is a simple C# console application that demonstrates the use of a char and a string.
char grade = 'A';
Console.WriteLine($"The grade is: {grade}");

// This is a simple C# console application that demonstrates the use of a string.
string name = "Alice";
Console.WriteLine($"Hello, {name}!");

// This is a simple C# console application that demonstrates the use of a boolean.
bool isEven = true;
if (meter % 2 == 0)
{
    isEven = true;
    Console.WriteLine($"{meter} is an even number.");
}
else
{
    isEven = false;
    Console.WriteLine($"{meter} is an odd number.");
}
Console.WriteLine($"Is {meter} even? {isEven}");


// Operations with variables

// This is a simple C# console application that demonstrates basic arithmetic operations with variables.
// int chair = 10;
// int table = 5;
// int totalFurniture = chair + table;
// Console.WriteLine($"Total furniture: {totalFurniture}");

// This is a simple C# console application that demonstrates the use of increment and decrement operators.
// int increment = 1;
// increment++;
// Console.WriteLine($"Incremented value: {increment}");

// increment--;
// Console.WriteLine($"Decremented value: {increment}");

// This is a simple C# console application that demonstrates the use of compound assignment operators.
// int productCount = 5;
// Console.WriteLine($"Product count: {productCount}");
// productCount *= 2;
// Console.WriteLine($"Total product after twice: {productCount}");
// productCount += 1000;
// Console.WriteLine($"Total product count and with 1000 more: {productCount}");

// // This is a simple C# console application that demonstrates the use of comparison operators.
// Console.WriteLine("Enter three numbers one by one: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// int number2 = Convert.ToInt32(Console.ReadLine());
// int number3 = Convert.ToInt32(Console.ReadLine());
// if (number1 > number2 && number1 > number3)
// {
//     Console.WriteLine($"The largest number is: {number1}");
// }
// else if (number2 > number1 && number2 > number3)
// {
//     Console.WriteLine($"The largest number is: {number2}");
// }
// else if (number3 == number1 && number3 == number2)
// {
//     Console.WriteLine($"All numbers are equal: {number3}");
// }
// else
// {
//     Console.WriteLine($"The largest number is: {number3}");
// }


// This is a simple C# console application that demonstrates the use of array with loop and switch statement.
// string[] DaysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

// for (int day = 0; day < DaysOfWeek.Length; day++)
// {
//     switch(DaysOfWeek[day])
//     {
//         case "Monday":
//             Console.WriteLine("It's Monday!");
//             break;
//         case "Tuesday":
//             Console.WriteLine("It's Tuesday!");
//             break;
//         case "Wednesday":
//             Console.WriteLine("It's Wednesday!");
//             break;
//         case "Thursday":
//             Console.WriteLine("It's Thursday!");
//             break;
//         case "Friday":
//             Console.WriteLine("It's Friday!");
//             break;
//         case "Saturday":
//             Console.WriteLine("It's Saturday!");
//             break;
//         case "Sunday":
//             Console.WriteLine("It's Sunday!");
//             break;
//         default:
//             Console.WriteLine("Invalid day of the week.");
//             break;
//     }
// }

// int[] numbers = { 1, 2, 3, 4, 5 };

// Console.WriteLine($"Total numbers in array, not sum: {numbers.Length}");
// Console.WriteLine($"The maximum number is: {numbers.Max()}");
// Console.WriteLine($"The minimum number is: {numbers.Min()}");
// Console.WriteLine($"The average number is: {numbers.Average()}");
// Console.WriteLine($"The sum of the numbers is: {numbers.Sum()}");



// This is a simple C# console application that demonstrates the use of a two-dimensional array (matrix) and nested loops to print its elements.
// int[,] matrix = new int[,]
// {
//     {1, 2, 3, 4},
//     {5, 6, 7, 8},
//     {9, 10, 11, 12}
// };

// for (int i = 0; i < matrix.GetLength(0); i++) // rows
// {
//     for (int j = 0; j < matrix.GetLength(1); j++) // columns
//     {
//         Console.Write(matrix[i, j] + "\t");
//     }
//     Console.WriteLine();
// }



// First methods example in C# console application, like python functions define and call them.
// static void HelloWorld()
// {
//     Console.WriteLine("Hello, World!");
// }

// static void Execute()
// {
//     Console.WriteLine("Executed!");
// }

// HelloWorld();
// Execute();


// Second example of methods in C# console application.
// using System;

// class Program
// {
//     static void Execute()
//     {
//         Console.WriteLine("Executed!");
//     }

//     static void Main(string[] args)
//     {
//         Execute();
//     }
// }


// This is a simple C# console application that demonstrates the use of methods with parameters and return values.
// static int Add(int a, int b)
// {
//     return a + b;
// }

// Console.WriteLine("Enter the first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int result = Add(num1, num2);
// Console.WriteLine($"The sum of {num1} and {num2} is: {result}");




// using System;

// // Class and objects 

// class Person
// {
//     private int Age { get; set; }
//     public string name { get; set; }

//     public void Introduce(string name, int age)
//     {
//         Console.WriteLine($"Hello, my name is {name} and I am {age} years old.");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Person P1 = new Person();
//         P1.Introduce("Ali", 30);
//     }
// }

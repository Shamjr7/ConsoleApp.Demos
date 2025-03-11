﻿// See https://aka.ms/new-console-template for more information

// Simple For Loop Demo
// Print Hello World 10 Times

Console.WriteLine("********** Simple For Loop **********");
for (int i = 0; i < 10; i++)
{
   Console.WriteLine($"Hello, World! - {i}");
}

Console.WriteLine("Loop completed!");


//Ask user how many times they wish to print hello world and print
//Console.WriteLine("How many time should we print hello world?");
//int userCount = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i < userCount; i++)
//{
//    Console.WriteLine($"Hello, World! - {i}");
//}
Console.WriteLine("********** Simple For Loop Completed **********");

//While Loop
Console.WriteLine("********** While Loop **********");

int counter  = 0;
while (counter < 10)
{
    Console.WriteLine($"Hello, World! - {counter}");
    counter+= 2;
}

//Ask he user for a number and find the total for each number that is entered and print the final sum when user enters -1 to exitwhat

int sum = 0;
int num = 0;

while(num != -1)
{
    Console.WriteLine("Please enter numbers to be summed. (-1 to stop or exit)");
    num = Convert.ToInt32(Console.ReadLine());
    if (num != -1)
    {
        sum += num;
    }
}

Console.WriteLine($"Your sum is: {sum}");

Console.WriteLine("********** While Loop completed **********");


Console.WriteLine("********** Do While Loop **********");
do
{
    Console.Write("Please enter number to be summed. (-1 to stop or exit): ");
    num = Convert.ToInt32(Console.ReadLine());
    //nested if statement
    if (num != -1)
    {
        sum += num;
    }
} while (num != -1);
Console.WriteLine($"Your sum is: {sum}");
Console.WriteLine("********** Do While Loop completed **********");
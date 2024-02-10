// Question 1: FizzBuzz
// Write a program that prints the numbers from 1 to 100. For multiples of 3, print "Fizz"; for 
// multiples of 5, print "Buzz"; and for numbers that are multiples of both 3 and 5, print 
// "FizzBuzz".

for (int i = 1; i <= 100; i++)
{

    if (i % 3 == 0)
    {
        Console.WriteLine(i + " =Fizz");
    }
    if (i % 5 == 0)
    {
        Console.WriteLine(i + " =Buzz");
    }
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine(i + " =FizzBuzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}

// Question 2: Fibonacci Sequence
// Write a program to generate the Fibonacci sequence up to 100.
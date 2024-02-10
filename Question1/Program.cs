// Question 1: FizzBuzz
// Write a program that prints the numbers from 1 to 100. For multiples of 3, print "Fizz"; for 
// multiples of 5, print "Buzz"; and for numbers that are multiples of both 3 and 5, print 
// "FizzBuzz".

for (int i = 1; i <= 100; i++)
{

    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine(i + " =FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine(i + " =Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine(i + " =Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}

// Question 2: Fibonacci Sequence
// Write a program to generate the Fibonacci sequence up to 100.


// Question 6: Count Vowels
// Write a program that counts the number of vowels in a sentence.
// eg " Hello World " => returns 2

int count = 0;
var word = "hello world";
foreach (char v in word)
{
    if (v == 'a' || v == 'e' || v == 'i' || v == 'o' || v == 'u')
    {
        count++;
    }
}
Console.Write(count);
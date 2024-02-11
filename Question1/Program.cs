using System;
using System.Collections.Generic;
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

// Question 3: Power of Two
// Write a program that takes an integer as input and returns true if the input is a power of two.
// Examples: 
// 8=> returns true
// 6=> returns false
static bool power2(int n)
{
    const int baseNum = 2;
    while (n % baseNum == 0 && n > 1)
    {
        n /= baseNum;
    }
    if (n == 1)
    {
        return true;
    }
    return false;
}
Console.Write(power2(6));

// Question 4: Capitalize Words
// Write a program that accepts a string as input, capitalizes the first letter of each word in the 
// string, and then returns the result string.
// Examples: 
// "hi"=> returns "Hi"
// "i love programming"=> returns "I Love Programming"
static string Cap(string str)
{
    //string Caps="";
    bool HasWords = str.Contains(" ");
    if (HasWords)
    {
        string[] words = str.Split(' ');
        for (int i = 0; i <= words.Length - 1; i++)
        {
            if (words[i].Length > 0)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
            }
        }
        return string.Join(" ", words);
    }
    else
    {
        //string CapS = str.Insert(0,"d");
        str = char.ToUpper(str[0]) + str.Substring(1);
        return str;
    }
}
Console.Write(Cap("hello world"));

// Question 5: Reverse Integer
// Write a program that takes an integer as input and returns an integer with reversed digit 
// ordering.
// Examples:
// For input 500, the program should return 5.
// For input -56, the program should return -65.
// For input -90, the program should return -9.
// For input 91, the program should return 19. 
static int reverse(int number)
{
    string Snumber = number.ToString();
    bool isNegative = Snumber.StartsWith("-");
    if (isNegative)
    {
        Snumber = Snumber.Substring(1);
    }

    char[] arr = Snumber.ToCharArray();
    char[] Rarry = new char[Snumber.Length];
    int j = 0;

    for (int i = Snumber.Length - 1; i >= 0; i--)
    {
        //Console.Write("index"+i+" ");
        //Console.Write(arr[i] + " ");
        Rarry[j] = arr[i];
        j++;
    }


    string Rstring = new string(Rarry);
    if (isNegative)
    {
        Rstring = "-" + Rstring;
    }
    int Rnumber = int.Parse(Rstring);
    return Rnumber;
}
reverse(100);

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
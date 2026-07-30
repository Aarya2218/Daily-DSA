// Count Digits
//given 12345
// o/p 5

// Rules:
// ❌ Don't convert the number to a string.
// ❌ Don't use .Length.
// ✅ Use arithmetic (/ and %).

//idea:extracting digits using mathematics,
//  which you'll use later for reversing numbers, 
// palindrome numbers, Armstrong numbers, and more.

using System;

int a = 12345;
int count = 0;
 for(; a != 0; a = a/10)
{
    count++;
}
Console.WriteLine("Number of digits = " + count);
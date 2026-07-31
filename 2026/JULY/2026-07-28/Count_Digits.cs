// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

// count digits
// int a = 12345
// what is the theda way to count, bcoz Aegis don't know how to
// ek loop to rahegi hi
// logic: aisa kya kru- position system
// 5+40+300+2000+10000=12345
// For counting digits, we don't care whether the digit is 5 or 9.
// We only care that one digit exists.
// Take a number.
// While it is not zero,
// divide by 10,
// increase count.
// Print count.
int a = 12345;
int count = 0;
for( ;  a != 0; a = a / 10)
//
{

    count++;
}
Console.WriteLine(count);

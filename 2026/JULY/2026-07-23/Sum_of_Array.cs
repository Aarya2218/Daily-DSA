// Sum of Array
//Given an array of integers, find the sum of all its elements.
//{2, 8, 5, 9, 1}
//Rules
//Don't use:
//LINQ
//Sum()
//foreach

//Use only:
//array
//for loop
//one variable to store the answer 

int [] a = new int[] {2 , 8, 5 , 9 , 1};
int sum = 0;
for(int i = 0; i<a.Length; i++)
{
    sum = sum + a[i];
}
Console.WriteLine($"sum of Numbers = {sum}");

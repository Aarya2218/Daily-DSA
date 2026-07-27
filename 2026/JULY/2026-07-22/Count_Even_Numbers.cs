// count even numbers
//Given an integer array, count how many even numbers are present.
//{2, 8, 5, 9, 1}
//Rules
//Don't use:
//LINQ
//.Count()
//.Where()
//foreach

//Use only:
//array
//for loop
//if condition
//one counter variable

int [] a = new int[] {2 , 8, 5 , 9 , 1};
int count = 0;
for(int i = 0; i<a.Length; i++)
{
    if(a[i] % 2 == 0)
    {// how to store the count of it?
     count++;
    }
}
Console.WriteLine($"Even Numbers = {count}");

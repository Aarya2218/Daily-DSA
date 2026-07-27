// Smallest Element in an Array
//Given an integer array, find the smallest element.
//{2, 8, 5, 9, 1}
//Rules
//Don't use:
//LINQ
// sorting

//Use only:
//array
//for loop
//if

int [] a = new int[] {2 , 8, 5 , 9 , 1};
int smallest = a[0];
for (int i = 1; i < a.Length; i++)
{
    if (a[i] < smallest)
    {
        smallest = a[i];
    }
}

 Console.WriteLine($"Smallest Number = {smallest}");

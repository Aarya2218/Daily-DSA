// Second Largest Element
//Given an integer array, find the Second Largest Element.
//{2, 8, 5, 9, 1}
//Rules
//Don't use:
//LINQ
// sorting

//Use only:
//array
//for loop
//if

int[] a = new int[] { 2, 8, 5, 9, 1 };

int largest = int.MinValue;
int secondLargest = int.MinValue;

for (int i = 0; i < a.Length; i++)
{
    if (a[i] > largest)
    {
        // Update both
        secondLargest = largest;
        largest = a[i];
    }
    else if (a[i] > secondLargest && a[i] != largest)
    {
        // Update only second largest
        secondLargest = a[i];
    }
}

Console.WriteLine($"Largest Element = {largest}");
Console.WriteLine($"Second Largest Element = {secondLargest}");

// Linear Search
// Given {2, 8, 5, 9, 1}
// search for 9 -> Found at index 3
// search for 7 - not found

int[] a = new int[] { 2, 8, 5, 9, 1 };
int target = 9;
bool found = false;

for (int i=0; i<a.Length; i++)
{
    if(a[i] == target)
    {
        Console.WriteLine($"Found at index {i}");
        found = true;
        break;
    }
}
if(!found)
{
    Console.WriteLine("Not Found");
}


// Linear search
//searching instead of calculating
// a flag variable(bool found) to remember if something happened.
//break; to stop the loop once the answer is found.
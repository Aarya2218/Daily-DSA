// find the largest number in the array
int[] a = new int[] { 2, 8, 5, 9, 1 };

int largest = a[0];

for (int i = 1; i < a.Length; i++)
{
    if (a[i] > largest)
    {
        largest = a[i];
    }
}

 Console.WriteLine($"Largest Number = {largest}");


// the way i'm thinking about it is, sorting, means, arrange the array in a asscending order 
// now how to arrange this array in asc order, or any order
// sth like comparing two numbers at a time, and swapping them, in order
// ek loop chlate hai jo array mein chlega, aur uske under ek aur loop jo sort krega
// nope, this is bubble sort, what i was thinking, but array not need to be arranged now

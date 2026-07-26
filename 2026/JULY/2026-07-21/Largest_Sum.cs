// find the largest number in the array
public class LargestElement
{
    public static int FindLargest(int[] a)
    {
        int largest = a[0];

        for(int i = 1; i < a.Length; i++)
        {
            if(a[i] > largest)
            {
                largest = a[i];
            }
        }

        return largest;
    }
}

// the way i'm thinking about it is, sorting, means, arrange the array in a asscending order 
// now how to arrange this array in asc order, or any order
// sth like comparing two numbers at a time, and swapping them, in order
// ek loop chlate hai jo array mein chlega, aur uske under ek aur loop jo sort krega
// nope, this is bubble sort, what i was thinking, but array not need to be arranged now

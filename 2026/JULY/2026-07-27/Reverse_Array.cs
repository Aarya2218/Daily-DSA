// Reverse an array {two pointers}
// Given {2, 8, 5, 9, 1}
// o/p {1,9,5,8,2 }

int[] a = new int[] { 2, 8, 5, 9, 1 };
int left = 0;
int right = a.Length - 1;
for (int i=0; i<a.Length/2; i++)
{
   // i do know that we have to do something with 
   // a[length-i] = a[i]
   // that means storing values, but i want left 
   // to be pointing at index 0 not storing the value of index 0
   // now we'll swap
   int temp = a[left];
   a[left] = a[right];
   a[right] = temp;
    //after every swap, what should happen?
   //Left should move one step forward.
   //Right should move one step backward.
   left++;
   right--;
}

for (int i = 0; i < a.Length; i++)
{
    Console.Write(a[i] + " ");
}

//another possible solution
// while (left < right)
// {
//     ...
//     left++;
//     right--;
// }
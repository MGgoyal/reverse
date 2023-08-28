using System;

class Sample
{
    public static void Main()
    {
        int[] intArr = new int[5] { 10, 20, 30, 40, 50 };
        int loop = 0;

        Array.Reverse(intArr);

        Console.WriteLine("Array after Reverse() method: ");
        for (loop = 0; loop < intArr.Length; loop++)
        {
            Console.WriteLine("Element " + (loop + 1) + " is " + intArr[loop]);
        }
    }
}
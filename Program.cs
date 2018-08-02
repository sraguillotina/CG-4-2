using System;

namespace Class4_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Created an array using integer variable. Labeled it "numberList" to describe the
            //list of numbers for the assignment.
            //Used in-line array declaration and initialization.
            int[] numberList = new int[] { 1, 1, 2, 3, 5, 8 };

            //Used foreach iteration to loop through the items of the array.
            //Assigned label "number" to temporary array elements.
            foreach (int number in numberList)
            {
                //Printed the elements by invoking the temp array elements under "number."
                Console.WriteLine(number);
            }
            Console.ReadLine();
            
        }
    }
}

using System.Runtime.CompilerServices;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace Zachary_Renyhart_Assignment_6._2._2
{
    internal class Program
    {
        //2. Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

        static void Main(string[] args)
        {
            int[] nums= { 1, 2, 3, 4 };
            //This is an array to store the product of all elements to the left of the current element.
            //This array is equal to the length of the "Nums" Array.
            int[] firstArray = new int[nums.Length];

            //Temp is a temporary variable to store intermediate products during calculation.
            int temp = 1;

            Console.WriteLine("The initial array of numbers is:");
            foreach (int i in nums)            
            { //This foreach loop is printing out the initial array "nums"
                Console.Write(i + " "); 
            }
            
            for (int i = 0; i < nums.Length; i++)
            { //Loop through each element of the nums array.
              //At each step, store the current value of temp in firstArray[i]. Temp is equal to 1 in the beginning
                firstArray[i] = temp;
                //Update "temp" by multiplying it with the current element of nums.
                temp = firstArray[i] * nums[i];
                
            }
            // ^^EXAMPLE - Console.WriteLine(temp); = 24!

            //This is resetting temp to 1 to prepare for the next loop.
            temp = 1;

            //This is looping through the array in reverse order
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                //At each step, store the current value of nums[i] in a variable called value.
                //Update nums[i] by multiplying it with the product of all elements to the left of nums[i], 
                //which is stored in firstArray[i], and the product of all elements to the right of nums[i], which is stored in temp.
                int value = nums[i];
                nums[i] = temp * firstArray[i];
               //Update temp by multiplying it with value.
                temp = value * temp;    
            }
            Console.WriteLine();
            Console.WriteLine("The numbers multiplied together are: ");
            foreach (int num in nums)
            {//Print out the array nums after all the calculations.
             //This array now contains the product of all elements except the current element.
                Console.Write(num + " ");
            }    
        }
    }
}

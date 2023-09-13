using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayListLibray;

namespace ArrayListLib
{




    internal class Program
    {
        static void DisplayArr(ref ArrayList arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 100, 6, 3, 5, 7, 23, 6, 6, 0, 8 };
            ArrayList arr = new ArrayList(a);
            DisplayArr(ref arr);
            arr.Add(33, 4);
            Console.WriteLine("Add element to index");
            DisplayArr(ref arr);
            arr.DecreaseLengthFromMax(3);
            Console.WriteLine("Decrease Length from _length");
            DisplayArr(ref arr);
            arr.DecreaseLengthFromCount(2);
            Console.WriteLine("Decrease Length Based on Count");
            DisplayArr(ref arr);
            arr.Del(4);
            Console.WriteLine("Delete from index");
            DisplayArr(ref arr);
            arr.DelElement(6);
            Console.WriteLine("Delete all elements equalent to given integer");
            DisplayArr(ref arr);
            Console.WriteLine("Min: " + Convert.ToString(arr.Min()));
            Console.WriteLine("Max: " + Convert.ToString(arr.Max()));


        }
    }
}

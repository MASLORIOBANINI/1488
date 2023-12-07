using System;
using System.Linq;

namespace nigger
{
    class Program
    {
        static T[] Foo<T>(T[] array, int n) => array.Take(n).ToArray();

        static void Main(string[] args)
        {
            var arr1 = new int[] { 1, 2, 3 };
            var arr2 = new char[] { 'x', 'y', 'z' };
            var arr3 = Foo(arr1, 5);
            Console.WriteLine(string.Join(" ", arr3));
            var arr4 = Foo(arr2, 2);
            Console.WriteLine(string.Join(" ", arr4));
        }
    }
}
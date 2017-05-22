using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Threading;

namespace Lesson2205Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 2205 classes");
            //Console.WriteLine(string.Join("\n", typeof(System.IO.File)
            //    .GetMethods(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public)
            //    .Select(f => f.Name)
            //    .Where(f => Regex.Matches(f, "[A-Z][a-z]*").Count> 2)));
            int[] arr = new int[100000000];
            Random r = new Random();
            int s = 0;
            for (int i = 0; i < arr.Length; i++)
                arr[i] = r.Next(0, 20);
            ThreadTest t = new ThreadTest();
            Thread thread = new Thread(new ParameterizedThreadStart(Sum(t.arr, s)));


            Console.WriteLine("over");
            Console.ReadLine();

        }
        static void Sum(int[] arr, int s)
        {
            for (int i = 0; i < arr.Length; i++)
                s += arr[i];
        }
    }
    class ThreadTest
    {
        public int[] arr = new int[100000000];
        Random r = new Random();
        public int s = 0;

        public ThreadTest()
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = r.Next(0, 20);
        }
    }

}

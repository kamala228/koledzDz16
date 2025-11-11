using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koledzDz16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[12];
            //int misats1 = 0, misats2 = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write("Ведіть пробуток фирми за " + (i + 1) + " місяць: ");
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.Write("ведіть місяць від якого будемо рахувати ");
            //misats1= Convert.ToInt32(Console.ReadLine());
            //Console.Write("ведіть місяць до якого будемо рахувати ");
            //misats2= Convert.ToInt32(Console.ReadLine());
            //int min=2147483647;
            //int max=-2147483647;
            //int minIndex = 0, maxIndex = 0;
            //for (int i = misats1-1; i < misats2; i++)
            //{
            //    if (array[i] < min)
            //    {
            //        min = array[i];
            //        minIndex = i;
            //    }
            //    if (array[i] > max)
            //    {
            //        max = array[i];
            //        maxIndex = i;
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Місяць з найменшим прибутком у діапазоні " + (minIndex + 1));
            //Console.WriteLine("Місяць з найбільшим прибутком у діапазоні " + (maxIndex + 1));

            int[] array = new int[10];
            int sum = 0;
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10, 10);
            }
            for (int i = 0; i < array.Length; i++)
                {
                if (array[i] < 0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine("Сума від'ємних елементів: " + sum);
            Console.WriteLine("Масив: " + string.Join(", ", array));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Bugakov_Lecture_4
{
    class Program
    {

        public static int[]LoadArrayFromFile(string filtName)
        {
            if (File.Exists(filtName))
            {
                StreamReader streamReader = new StreamReader(filtName);

                int[] arr = new int[100];
                int count = 0;
                while (!streamReader.EndOfStream)
                {
                    int number = int.Parse(streamReader.ReadLine());
                    arr[count] = number;
                    count++;
                }
                int[] buf = new int[count];

                Array.Copy(arr, 0, buf, 0, count);
                return buf;
            }
            else
            {
                throw new FileNotFoundException();
            }
        }

        
       
        static void Main(string[] args)
        {
            ///Дан целочисленный массив из 20 элементов. 
            ///Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. 
            ///Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
            ///В данной задаче под парой подразумевается два подряд идущих элемента массива.
            #region Задача 1

            int n = 10;
            int min = -10000;
            int max = 10000;

            int[] amr = new int[n];
            
            Random random = new Random();
            for (int i = 0; i < n; i++)
            amr[i] = random.Next(min, max);           
            
            for (int i = 0; i < n; i++)
            {
                amr[i] = random.Next(min, max);
            }                
            
            int count = 0;
            for (int i = 0; i < amr.Length - 1; i++)

            {
                if (amr[i] % 3 == 0 | amr[i + 1] % 3 == 0)
                
                    count++;
                    Console.WriteLine("Пары: {0} и {1}", amr[i], amr[i + 1]);               

            }
            Console.WriteLine("Количество пар: " + count);


            #endregion

            Console.WriteLine("Вывод класса");
            MyArray myArray = new MyArray(20,-10000, 10000);
            Console.WriteLine(myArray.ToString());
            myArray.Divisibility3();
            Console.ReadLine();

            int[] arr = LoadArrayFromFile(AppDomain.CurrentDomain + "Lecture_4.txt");
            
        }

    }

    public class MyArray
    {
        private int[] am;

        public MyArray(int n, int min, int max)
        {
            am = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
                am[i] = random.Next(min, max);
        }

        public int Divisibility3()
        {
            int count = 0;

            for (int i = 0; i < am.Length - 1; i++)

            {
                if (am[i] % 3 == 0 | am[i + 1] % 3 == 0)
                {
                count++;
                Console.WriteLine("Пары: {0} и {1}", am[i], am[i + 1]);

                }
                    
            }
            Console.WriteLine("Количество пар: " + count);
            return count;

        }

        public override string ToString()
        {
            string stringarray = "";
            foreach (int x in am)
                stringarray = stringarray + x + "";
            return stringarray;
        }
    }

}

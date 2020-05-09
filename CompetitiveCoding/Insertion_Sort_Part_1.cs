using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CompetitiveCoding
{
    public class Insertion_Sort_Part_1
    {
        // Complete the insertionSort1 function below.
        static void insertionSort1(int n, int[] arr)
        {

            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                    
                }
                arr[j + 1] = key;
            }
        }

        static int runningTime(int[] arr)
        {
            int count = 0;
            for (int i = 1; i < arr.Length; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                    count++;
                }
                arr[j + 1] = key;
            }
            return count;
        }

        public static void Start(string[] args)
        {
            var fileStream = new FileStream(@"D:\projects\aspProjects\CompetitiveCoding\CompetitiveCoding\question\insertion_sort_part_1.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                int n = Convert.ToInt32(streamReader.ReadLine());

                int[] arr = Array.ConvertAll(streamReader.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
                ;

                Console.WriteLine(runningTime(arr));

                insertionSort1(n, arr);

                
            }
        }
    }
}

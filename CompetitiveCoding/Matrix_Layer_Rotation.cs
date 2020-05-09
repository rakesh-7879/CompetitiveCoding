using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CompetitiveCoding
{
    public class Matrix_Layer_Rotation
    {
        static void matrixRotation(List<List<int>> matrix, int r)
        {
            var left = 0; var right = matrix[0].Count() - 1;
            var up = 0; var down = matrix.Count() - 1;
            List<List<int>> resultMatrix = new List<List<int>>();
            foreach (var list in matrix)
            {
                resultMatrix.Add(list.Select(x => x).ToList());
            }
            while (left < right)
            {
                List<int> temp = new List<int>();
                for (int z = left; z <= right && up < down; z++) { temp.Add(matrix[left][z]); }
                for (int z = up + 1; z <= down; z++) { temp.Add(matrix[z][right]); }
                for (int z = right - 1; z >= left && up < down; z--) { temp.Add(matrix[down][z]); }
                for (int z = down - 1; z > up ; z--) { temp.Add(matrix[z][up]); }
                int tempR = 0;
                if (temp.Count() > 0)
                {
                    tempR = r % temp.Count();
                }
                else
                {
                    tempR = r;
                }
                var tempToApend = temp.Take(tempR);
                temp = temp.Skip(tempR).ToList();
                temp.AddRange(tempToApend);
                var a = 0;
                for (int z = left; z <= right && up < down; z++) { resultMatrix[left][z] = temp[a]; a++; }
                for (int z = up + 1; z <= down; z++) { resultMatrix[z][right] = temp[a]; a++; }
                for (int z = right - 1; z >= left && up < down; z--) { resultMatrix[down][z] = temp[a]; a++; }
                for (int z = down - 1; z > up; z--) { resultMatrix[z][up] = temp[a]; a++; }
                left++;
                right--;
                up++;
                down--;
            }
            foreach (var list in resultMatrix)
            {
                foreach (var item in list)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Start(string[] args)
        {
            var fileStream = new FileStream(@"D:\projects\aspProjects\CompetitiveCoding\CompetitiveCoding\question\matrix_layer_rotation.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string[] mnr = streamReader.ReadLine().TrimEnd().Split(' ');

                int m = Convert.ToInt32(mnr[0]);

                int n = Convert.ToInt32(mnr[1]);

                int r = Convert.ToInt32(mnr[2]);

                List<List<int>> matrix = new List<List<int>>();

                for (int i = 0; i < m; i++)
                {
                    matrix.Add(streamReader.ReadLine().TrimEnd().Split(' ').ToList().Select(matrixTemp => Convert.ToInt32(matrixTemp)).ToList());
                }

                matrixRotation(matrix, r);
            }
        }
    }
}

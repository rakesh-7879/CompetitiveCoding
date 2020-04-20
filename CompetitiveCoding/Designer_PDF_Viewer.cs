using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CompetitiveCoding
{
    public class Designer_PDF_Viewer
    {
        static int designerPdfViewer(int[] h, string word)
        {
            var maxMesure = 0;
            foreach (var item in word)
            {
                var index = (int)item - 97;
                if (h[index] > maxMesure)
                {
                    maxMesure = h[index];
                }
            }

            return maxMesure * word.Length;
        }

        public static void Start(string[] args)
        {
            var fileStream = new FileStream(@"D:\projects\aspProjects\CompetitiveCoding\CompetitiveCoding\question\designer_pdf_viewer.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                int[] h = Array.ConvertAll(streamReader.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp))
            ;
                string word = streamReader.ReadLine();

                int result = designerPdfViewer(h, word);

                Console.WriteLine(result);
            }
        }
    }
}

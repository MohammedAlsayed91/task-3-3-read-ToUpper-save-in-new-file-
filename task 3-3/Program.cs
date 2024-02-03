using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string location = @"C:\Users\User\OneDrive\Desktop\file\task3-3.txt";


            //FileInfo file = new FileInfo(location);
            //file.Create();
            //Console.WriteLine("successfully created");


            using (StreamWriter sw = File.AppendText(location))
            {
                var x = Console.ReadLine();
                sw.WriteLine(x);

                sw.Close();
                Console.WriteLine("done");
            }




            if (File.Exists(location))
            {
                string[] lines;
                using (StreamReader reader = new StreamReader(location))
                {
                    lines = File.ReadAllLines(location);
                }

                for (int i = 0; i < lines.Length; i++)
                {
                  
                    
                    lines[i] = lines[i].ToUpper();
                }


                string newfile = Path.ChangeExtension(location, "null")+"ToUpper.txt";
                File.WriteAllLines(newfile, lines);

                Console.WriteLine("File copied and changend to upper case successfully.");
            }
            else
            {
                Console.WriteLine("Original file does not exist.");
            }
        }
    }
}

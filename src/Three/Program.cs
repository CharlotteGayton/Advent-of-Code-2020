using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string folder = @"/Users/charlottegayton/temp/";
            StreamReader read = new StreamReader(folder + "file.txt");

            string linevalue = string.Empty;
            List<int> values = new List<int>();

            while ((linevalue = read.ReadLine()) != null)
            {
                int numline = Int32.Parse(linevalue);
                values.Add(numline);
            }

            values.ForEach(Console.WriteLine);

            foreach(int i in values){
                int tolookfor = 2020 - i;
                bool contains = values.Contains(tolookfor);
                if(contains == true){
                    Console.WriteLine("The two values that make 2020 are: {0} and: {1}", i, tolookfor);
                    break;
                }
            }

        }
    }


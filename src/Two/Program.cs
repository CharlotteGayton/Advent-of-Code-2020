using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;

namespace Two
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = @"/Users/charlottegayton/temp/";
            StreamReader read = new StreamReader(folder + "filetwo.txt");

            string linevalue = string.Empty;
            List<String> timesAllowed = new List<String>();
            List<String> letter = new List<String>();
            List<String> password = new List<String>();
            int counter = 0;

            while ((linevalue = read.ReadLine()) != null)
            {

                string[] words = linevalue.Split(' ');
                string[] numbers = words[0].Split('-');
                int[] intnum = Array.ConvertAll(numbers, s => int.Parse(s));
                words[1] = words[1].Remove(1);
                string expression = words[1];

                //creating positions 
                int numOne = int.Parse(numbers[0]);
                int numTwo = int.Parse(numbers[1]);

                //Char comparisonLet = words[1];

                Char[] letters = words[2].ToCharArray();
                var result = letters.Select(c => c.ToString()).ToList();
                if((result[numOne-1] == words[1] && !( result[numTwo-1] == words[1])) ||
                !(result[numOne-1] == words[1]) && ( result[numTwo-1] == words[1])){
                    counter += 1;
                }
                
            }

            Console.WriteLine(counter); 

        }
    }
}

/*
Part One 

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Two
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = @"/Users/charlottegayton/temp/";
            StreamReader read = new StreamReader(folder + "filetwo.txt");

            string linevalue = string.Empty;
            List<String> timesAllowed = new List<String>();
            List<String> letter = new List<String>();
            List<String> password = new List<String>();
            int counter = 0;

            while ((linevalue = read.ReadLine()) != null)
            {

                string[] words = linevalue.Split(' ');
                string[] numbers = words[0].Split('-');
                int[] intnum = Array.ConvertAll(numbers, s => int.Parse(s));
                words[1] = words[1].Remove(1);
                string expression = words[1];
                int numOfOccurances = Regex.Matches(words[2], expression).Count;

                if( numOfOccurances <= intnum[1] && numOfOccurances >= intnum[0]){
                    counter += 1;
                }
                
            }

            Console.WriteLine(counter); 

        }
    }
}
*/

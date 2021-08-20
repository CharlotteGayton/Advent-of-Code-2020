using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text.RegularExpressions;

namespace program{
    class Program
    {
        
        public void TaskOnePartOne()
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

        public void TaskTwoPartOne()
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

        public void TaskTwoPartTwo(){
            /* 
            The task validates whether a password under certain conditions. The numbers specified 
            before the password indicate the position of the particular letter. If the letter is present 
            in either of those positions it is accepted, but rejected if the letter is in both or none
            */

            //initialise file location and read the file 
            string folder = @"/Users/charlottegayton/temp/";
            StreamReader read = new StreamReader(folder + "filetwo.txt");

            //Create an empty string that holds a line as it passes through the while loop 
            //make empty lists for each sperate part (how many times the letter is allowed, the letter, and the password)
            string linevalue = string.Empty;
            List<String> timesAllowed = new List<String>();
            List<String> letter = new List<String>();
            List<String> password = new List<String>();
            int counter = 0;

            //while loop that loops through each line of the input code
            while ((linevalue = read.ReadLine()) != null)
            {

                //Split up the line so each part of the string can be used seperately 
                string[] words = linevalue.Split(' ');
                string[] numbers = words[0].Split('-');

                //converting the numbers to integers so they can locate positions in the string 
                //and removing the colon next to the allowed letter
                int[] intnum = Array.ConvertAll(numbers, s => int.Parse(s));
                words[1] = words[1].Remove(1);
                string expression = words[1];

                //creating positions 
                int numOne = int.Parse(numbers[0]);
                int numTwo = int.Parse(numbers[1]);

                //splitting up the password into a string array
                Char[] letters = words[2].ToCharArray();
                var result = letters.Select(c => c.ToString()).ToList();

                //Checking whether the letter is present in only one position
                //if so counter is increased by one to indicate the password was right
                if((result[numOne-1] == words[1] && !( result[numTwo-1] == words[1])) ||
                !(result[numOne-1] == words[1]) && ( result[numTwo-1] == words[1])){
                    counter += 1;
                }
                
            }
            //counter is returned to represent how many passwords passed the check
            Console.WriteLine(counter); 

        }

        public void TaskThreePartOne(){

            // string folder = @"/Users/charlottegayton/temp/";
            // StreamReader read = new StreamReader(folder + "filethree.txt");

            // string linevalue = string.Empty;
            // List<String> timesAllowed = new List<String>();
            // int counter = 2;
            // int tree = 0;

            // while ((linevalue = read.ReadLine()) != null){
            //     if(counter >= (linevalue.Length - 3)){
            //         counter = counter - linevalue.Length - 1; 
            //     }
            //     if(linevalue[counter] == '#'){
            //         tree += 1;
            //     }
            //     counter += 3;

            // }
            // Console.WriteLine(tree);
        }
        public static void Main(string[] args){
            Program p = new Program();
            p.TaskTwoPartTwo();
        }


    }
}


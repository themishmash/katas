

//You are given a collection of ABC blocks (like the ones you had when you were a kid).

//There are twenty blocks with two letters on each block.

//A complete alphabet is guaranteed amongst all sides of the blocks.

//The sample collection of blocks:

// (B O)
// (X K)
// (D Q)
// (C P)
// (N A)
// (G T)
// (R E)
// (T G)
// (Q D)
// (F S)
// (J W)
// (H U)
// (V I)
// (A N)
// (O B)
// (E R)
// (F S)
// (L Y)
// (P C)
// (Z M)
//Write a function that takes a string (word) and determines whether the word can be spelled with the given collection of blocks.

//The rules are simple:

//Once a letter on a block is used that block cannot be used again
//The function should be case-insensitive
//Show the output on this page for the following 7 words in the following example
//>>> can_make_word("A")
//True
//>>> can_make_word("BARK")
//True
//>>> can_make_word("BOOK")
//False
//>>> can_make_word("TREAT")
//True
//>>> can_make_word("COMMON")
//False
//>>> can_make_word("SQUAD")
//True
//>>> can_make_word("CONFUSE")
//True


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ABCKata
{
    public class ABCKata
    {

        public static void Solution()
        {
            //NOT WORKING!!!!
            //List<string> abcList = new List<string>();
            //string[] abcArray = { "B", "O", "X", "K", "D", "Q", "C", "P", "N", "A", "G", "T", "R", "E", "T", "G", "Q", "D", "F", "S", "J", "W", "H", "U", "V", "I", "A", "N", "O", "B", "E", "R", "F", "S", "L", "Y", "P", "C", "Z", "M" };




            // char[] abcArray = { 'B', 'O', 'X', 'K', 'D', 'Q', 'C', 'P', 'N', 'A', 'G', 'T', 'R', 'E', 'T', 'G', 'Q', 'D', 'F', 'S', 'J', 'W', 'H', 'U', 'V', 'I', 'A', 'N', 'O', 'B', 'E', 'R', 'F', 'S', 'L', 'Y', 'P', 'C', 'Z', 'M' };

            // //Console.WriteLine(abcArray.Length

            // Console.WriteLine(abcArray.GetType());

            // Console.WriteLine("What word do you want to check?");
            // var userInput = Console.ReadLine().ToUpper();
            // char[] chars = userInput.ToCharArray();


            // Console.WriteLine(chars.GetType());


            // //How to compare array of characters against array of characters?
            //bool isSubset = !chars.Except(abcArray).Any();

            //Console.WriteLine(isSubset);

            //_____________________________________________________





            //1. Make tuple array



            var blockList = new List<Tuple<string, string>>
            //Tuple<string, string>[] blockList =
            {
            Tuple.Create("B", "O"),
            Tuple.Create("X", "K"),
            Tuple.Create("D", "Q"),
            Tuple.Create("C", "P"),
            Tuple.Create("N", "A"),
            Tuple.Create("G", "T"),
            Tuple.Create("R", "E"),
            Tuple.Create("T", "G"),
            Tuple.Create("Q", "D"),
            Tuple.Create("F", "S"),
            Tuple.Create("J", "W"),
            Tuple.Create("H", "U"),
            Tuple.Create("V", "I"),
            Tuple.Create("A", "N"),
            Tuple.Create("O", "B"),
            Tuple.Create("E", "R"),
            Tuple.Create("F", "S"),
            Tuple.Create("L", "Y"),
            Tuple.Create("P", "C"),
            Tuple.Create("Z", "M"),
            };

           

            Console.WriteLine(blockList.Count);

            Console.WriteLine("What word are you trying to make?");
            var userInput = Console.ReadLine().ToUpper();

            //split word into letters
            char userLetter;
            foreach (char c in userInput)
            {
                userLetter = c;

                Console.WriteLine(userLetter);
                
            }





            string column1;
            string column2;
            foreach (Tuple<string, string> tuple in blockList)
            {
                column1 = tuple.Item1;
                column2 = tuple.Item2;

                //Console.WriteLine(column1);

            }




            //Help from windy
            //var temp = blockList.First(x => x.Item1 == "A" || x.Item2 == "A");
            //blockList.Remove(temp);
            //foreach (var each in blockList)
            //{
            //    Console.WriteLine(each.Item1 + " " + each.Item2);
            //}
            //Console.WriteLine(blockList);


            //try while not found

            bool found = false;
            while (!found)
            {
                //loop through blocklist
                //check if contain user input
                //if yes set found = true
            }
            //loop through index of pairs
            for (int i = 0; i < blockList.Count; i++)
            {
                for (int x = 0; x < userInput.Length; x++)

                {

                    //Console.WriteLine(userInput[x]);

                    string pairs = blockList[i].ToString();
                    if (pairs.Contains(userInput[x]))
                    {



                        pairs = pairs.Remove(x);
                        found = true;



                    }


                    if (found) break;

                    Console.WriteLine(pairs);




                }
                if (found) break;
            }




        }

        
        
    }
}





//Dictionary<string, string> abcDictionary = new Dictionary<string, string>();
//abcDictionary.Add("B", "O");
//abcDictionary.Add("X", "K");
//abcDictionary.Add("D", "Q");
//abcDictionary.Add("C", "P");
//abcDictionary.Add("N", "A");
//abcDictionary.Add("G", "T");
//abcDictionary.Add("R", "E");
//abcDictionary.Add("T", "G");
//abcDictionary.Add("Q", "D");
//abcDictionary.Add("F", "S");
//abcDictionary.Add("J", "W");
//abcDictionary.Add("H", "U");
//abcDictionary.Add("V", "I");
//abcDictionary.Add("A", "N");
//abcDictionary.Add("O", "B");
//abcDictionary.Add("E", "R");
//abcDictionary.Add("F", "S");
//abcDictionary.Add("L", "Y");
//abcDictionary.Add("P", "C");
//abcDictionary.Add("Z", "M");
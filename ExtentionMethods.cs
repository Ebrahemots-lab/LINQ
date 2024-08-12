using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToLinq
{
    public static class ExtentionMethods
    {
        public static void Print(this string message) 
        {
            Console.WriteLine(message);
        }


        public static List<int> ArrayOperation(this List<int> list, Predicate<int> predicate)
        {
            List<int> returnedValus = new List<int>();  
            for(int i = 0; i < list.Count; i++) 
            {
                if (predicate(list[i])) 
                {
                    returnedValus.Add(list[i]);
                }
            }

            return returnedValus;
        }

        public static string ToTitleCase(this string text)
        {
            //hello world => Hello World
            //split the word by space 
            StringBuilder sb = new StringBuilder();
            string[] splitedWord = text.Split(' ');
            for(int i = 0; i < splitedWord.Length; i++) 
            {
                //ebrahem
                //E
                string toUpperText = "";

                char firstCharcter = Char.ToUpper(splitedWord[i][0]);

                toUpperText += firstCharcter;

                string substring = splitedWord[i].Substring(1);

                toUpperText += substring;

               
                sb.Append(toUpperText + " ");

            }

            return sb.ToString(); 
        }


    }


    
}

using ArrayandStringLibrary.Interfaces;
using ArrayandStringLibrary.Methods;
using System;

namespace ArrayActivity.Activities
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Activity 1
            int[] Array1 = { 1, 2, 3, 4, 5 };
            ArrayManipulation arrayManipulation = new ArrayManipulation(Array1);
            arrayManipulation.Output();
            arrayManipulation.SearchArray(null, true);

            //Activity 2
            var arrayManipulation2 = new ArrayManipulation(new int[] { 10, 20, 30, 40, 50 });
            arrayManipulation2.LinearSearch(20, true);


            IString activity = new StringManipulation();
            // Activity 3 – Reverse a word
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            activity.SetWord(word);
            activity.ReverseWord();
            activity.OutputReversed();

            Console.WriteLine();

            // Activity 4 – Split and count sentence
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            activity.SetSentence(sentence);
            activity.SplitSentence();
            activity.OutputWordCount();


        }
    }
}

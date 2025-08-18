using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayandStringLibrary.Interfaces;

namespace ArrayandStringLibrary.Methods
{
    public class StringManipulation : IString
    {
        private string? _word;
        private string? _reversedWord;
        private string? _sentence;
        private int _wordCount;

        public void SetWord(string word)
        {
            _word = word;
        }

        public void ReverseWord()
        {
            char[] chars = _word.ToCharArray();
            Array.Reverse(chars);
            _reversedWord = new string(chars);
        }

        public void OutputReversed()
        {
            Console.WriteLine($"Original Word : {_word}");
            Console.WriteLine($"Reversed Word : {_reversedWord}");
        }

        public void SetSentence(string sentence)
        {
            _sentence = sentence;
        }

        public void SplitSentence()
        {
            if (!string.IsNullOrWhiteSpace(_sentence))
            {
                string[] words = _sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                _wordCount = words.Length;
            }
            else
            {
                _wordCount = 0;
            }
        }

        public void OutputWordCount()
        {
            Console.WriteLine($"Original Sentence : {_sentence}");
            Console.WriteLine($"Word Count        : {_wordCount}");
        }
    }
}

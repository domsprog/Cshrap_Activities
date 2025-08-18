using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayandStringLibrary.Interfaces
{
    public interface IString
    {
        void SetWord(string word);
        void SetSentence(string sentence);
        void ReverseWord();
        void SplitSentence();
        void OutputReversed();
        void OutputWordCount();
    }
}

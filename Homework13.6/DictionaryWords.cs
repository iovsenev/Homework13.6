using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13._6
{
    internal class DictionaryWords
    {
        Dictionary<string, int> _words;
        IEnumerable<string> _wordList;
        public Dictionary<string, int> WordList { get { return _words; } }

        public DictionaryWords(IEnumerable<string> wordList)
        {
            _wordList = wordList;
            _words = GetCountingWords();
        }

        Dictionary<string, int> GetCountingWords()
        {
            var dic = new Dictionary<string, int>();
            foreach (var word in _wordList)
            {
                if (dic.ContainsKey(word))
                {
                    dic[word]++;
                    continue;
                }
                dic[word] = 1;
            }
            return dic;
        }
    }
}

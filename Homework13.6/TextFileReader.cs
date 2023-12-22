using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Homework13._6
{
    internal class TextFileReader
    {
        string[] _arrayText;
        List<string> _list = new List<string>();
        LinkedList<string> _linkedList = new LinkedList<string>();

        string _path;

        public TextFileReader(string path)
        {
            _path = path;
        }

        public List<string> Strings { get { return _list; } }

        void ReadFile()
        {
            string text = File.ReadAllText(_path);
            _arrayText = Regex.Split(text, @"\W+");
        }

        public void TestWright(int count)
        {
            ReadFile();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < count; i++)
            {
                foreach (string line in _arrayText)
                {
                    _list.Add(line.ToLower());
                }
            }
            sw.Stop();
            var milsecList = sw.ElapsedMilliseconds;

            sw.Start();
            for (int i = 0; i < count; i++)
            {
                foreach (string line in _arrayText)
                {
                    _linkedList.AddLast(line.ToLower());
                }
            }
            sw.Stop();
            var milsecLinkedList = sw.ElapsedMilliseconds;

            Console.WriteLine("Вставка текста в List {0} раз заняла {1} миллисекунд.",
                count, milsecList);
            Console.WriteLine("Вставка текста в LinkedList {0} раз заняла {1} миллисекунд.",
                count, milsecLinkedList);
        }
    }
}

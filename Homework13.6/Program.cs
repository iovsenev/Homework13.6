using System.Collections.Immutable;

namespace Homework13._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"D:\Работа и обучение\beckend обучение\skilfactory\Homework13.6\text1.txt";
            if (!File.Exists(path))
            {
                Console.WriteLine("No file.");
                return;
            }
            var fileReader = new TextFileReader(path);
            var countRuns = 100;

            Console.WriteLine("\n=============================================");
            fileReader.TestWright(countRuns);
            Console.WriteLine("=============================================");

            Console.WriteLine("\nВсего слов в тексте: {0}",fileReader.Strings.Count);

            var dictWord = new DictionaryWords(fileReader.Strings);
            Console.WriteLine("\nВсего уникальных в тексте: {0}",dictWord.WordList.Count);

            var wordPopular = dictWord.WordList
               .OrderByDescending(g => g.Value)
               .ToDictionary(g => g.Key, g => g.Value)
               .Take(10);
            Console.WriteLine("\n{0} самых популярных слов тексте:",wordPopular.Count());

            foreach ( var word in wordPopular )
            {
                Console.WriteLine(word);
            }

            Console.ReadLine();
        }
    }
}

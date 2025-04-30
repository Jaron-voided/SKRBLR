namespace SKRBLR;

public class WordList
{
    HashSet<Word> words = new HashSet<Word>();

    internal byte wordCount { get; set; }
    

    internal WordList PlayableWordList(List<Word> wordList)
    {
        WordList resultWords = new WordList();
        resultWords.words = wordList.ToHashSet();
        resultWords.wordCount = (byte)wordList.Count;
        return resultWords;
    }

    internal List<Word> SortByScore()
    {
        return words.OrderBy(w => w.Score).ToList();
    }

    internal List<Word> Topwords(int count, int score)
    {
        return words.Where(w => w.Score >= score).Take(count).ToList();
    }
    
    
}
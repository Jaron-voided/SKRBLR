namespace SKRBLR;

public class Dictionary
{
    HashSet<string> PlayableWords = new HashSet<string>();
    private HashSet<Word> WordsWithScores = new HashSet<Word>();

    // get all possible words from JSON
    internal static Dictionary LoadMasterDictionary()
    {
        throw new NotImplementedException();
    }

    internal Dictionary GetWordsUpToLength(int length)
    {
        throw new NotImplementedException();
    }
    
    // Get words possible for first round, only 7 letter or less words
    internal Dictionary FirstTurnDictionary(Dictionary dictionary, Hand hand)
    {
        throw new NotImplementedException();
    }

    internal Dictionary PlayableWordsDictionary(Dictionary dictionary, Hand hand)
    {
        throw new NotImplementedException();
    }
    
    // I don't have to pass hand to this cuz I already have it pruned
    internal Dictionary PlayableWordsWithScoresDictionary(Dictionary dictionary)
    {
        throw new NotImplementedException();
    }
    
    
}
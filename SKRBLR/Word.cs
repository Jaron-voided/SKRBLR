namespace SKRBLR;

public class Word
{
    internal List<Tile> WordWithScore { get; set; }
    internal string WordString { get; set; }
    internal byte Score { get; set; }
    internal byte Length { get; set; }

    // I will prune a dictionary down to words I need with my hand tiles to play a word
    // pass the list to this function and return words with scores
    internal Word GetWordWithScore(List<Tile> tiles)
    {
        Word word = new Word();
        foreach (var tile in tiles)
        {
            word.Score += tile.Score;
        }
        word.Length = (byte)tiles.Count;

        return word;
    }

    public override string ToString()
    {
        string result = $"{WordString} (Length : {Length}) (Score : {Score}))";
        return result;
    }
}
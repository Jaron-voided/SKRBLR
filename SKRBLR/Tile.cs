namespace SKRBLR;

public class Tile
{
    internal char Letter { get; set; }
    internal byte Score  { get; set; }
    internal byte Count { get; set; }

    internal void Decrement()
    {
        Count -= 1;
    }

    internal Tile Clone()
    {
        Tile newTile = this;
        newTile.Count = 1;
        return newTile;
    }
}
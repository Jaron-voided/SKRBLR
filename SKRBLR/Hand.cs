namespace SKRBLR;

public class Hand
{
    private List<Tile> Tiles { get; set; }

    internal void DrawTile(TileBag bag, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Tiles.Add(bag.DrawTile());
        }
    }

    internal void DrawFirstHand(TileBag bag)
    {
        DrawTile(bag, 7);
    }

    internal void PlayTile(Tile tile) // Maybe take a board parameter once I get that set up so it plays it to the board
    {
        Tiles.Remove(tile);
    }
    
}
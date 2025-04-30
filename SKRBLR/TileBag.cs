namespace SKRBLR;

public class TileBag
{
    List<Tile> RemainingTiles { get; set; }

    // Hand runs DrawTile, uses parameter of bag to do bag.drawtiles then randomly pick tiles
    internal Tile DrawTile() 
    {
        int index = Random.Shared.Next(RemainingTiles.Count);
        Tile selectedTile = RemainingTiles[index];
        selectedTile.Decrement();
        
        if (selectedTile.Count == 0)
            RemainingTiles.RemoveAt(index);
        
        Tile clonedTile = selectedTile.Clone();
        return clonedTile;
    }

    // Factory function to create a new bag for a game
    public static TileBag FillTileBag() 
    {
        TileBag newBag = new TileBag();
        foreach (var tileDefinition in Utils.TileDefinitions)
        {
            Tile tile = new Tile();
            tile.Letter = tileDefinition.Letter;
            tile.Score = tileDefinition.Score;
            tile.Count =  tileDefinition.Count;
            newBag.RemainingTiles.Add(tile);
        }
        return newBag;
    }
}
internal class Player
{
    public Cell Cell { get; }
    public string Symbol { get; }
    public Player(Cell cell, string Symbol)
    {
        Cell = cell;
        this.Symbol = Symbol;
    }

}
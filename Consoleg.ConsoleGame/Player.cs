internal class Player
{
    public Cell Cell { get; }
    public string Symbol { get; }
    public ConsoleColor Color { get; } = ConsoleColor.Green;
    public Player(Cell cell, string symbol)
    {
        Cell = cell;
        Symbol = symbol;
    }

}
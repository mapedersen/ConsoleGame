internal class Player : Creature
{
    public Player(Cell cell) :base(cell, "P ")
    {
        
    }
}

internal class Creature
{
    public Cell Cell { get; }
    public string Symbol { get; }
    public ConsoleColor Color { get; } = ConsoleColor.Green;
    public Creature(Cell cell, string symbol)
    {
        Cell = cell;
        Symbol = symbol;
    }

}
internal class Cell
{
    public string symbol => ".";
    public ConsoleColor Color { get; }


    public Cell(string symbol)
    {
        Color = ConsoleColor.Red;
    }
}
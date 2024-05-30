internal class Cell
{
    public string symbol => ".";
    public ConsoleColor Color { get; }


    public Cell()
    {
        Color = ConsoleColor.Red;
    }
}
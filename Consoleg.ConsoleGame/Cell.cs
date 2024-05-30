internal class Cell
{
    public string Symbol { get; set; }

    public string symbol => ".";

    public Cell(string symbol)
    {
        Symbol = symbol;
    }
}
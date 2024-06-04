using System.Diagnostics.CodeAnalysis;

internal class Creature : IDrawable
{
    //ToDo: validate set
    private Cell _cell;
    public string Symbol { get; }
    public Cell Cell 
    {
        get => _cell;
        [MemberNotNull(nameof(Cell))]
        set
        {
            ArgumentNullException.ThrowIfNull(value, nameof(value));
            _cell = value;
        }
    }
    public ConsoleColor Color { get; protected set; } = ConsoleColor.Green;
    public Creature(Cell cell, string symbol)
    {
        Cell = cell ?? throw new ArgumentNullException(nameof(cell));
        
        if (string.IsNullOrEmpty(symbol))
        {
            throw new ArgumentException($"'{nameof(symbol)}' cannot be null or empty.", nameof(symbol));
        }

        Symbol = symbol;
    }

}
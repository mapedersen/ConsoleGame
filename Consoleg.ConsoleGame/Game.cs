

using System.Data;

internal class Game
{
    public Game()
    {
    }

    internal void Run()
    {
        Initialize();
    }

    private void Initialize()
    {
        //Todo: Read from config
        var map = new Map(width: 10, height: 10);
    }
}
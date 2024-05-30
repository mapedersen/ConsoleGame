

using System.Data;

internal class Game
{
    private Map map = null!;
    private Player player = null!;

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
        map = new Map(width: 10, height: 10);
        player = new Player();
    }
}
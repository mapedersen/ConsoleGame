using Consoleg.LimitedList;

var lli = new LimitedList<int>();
var lli2 = new LimitedList<string>();

var game = new Game();
game.Run();

Console.WriteLine("Game over");
Console.ReadLine();
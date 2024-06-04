using Consoleg.LimitedList;

var li = new LimitedList<int>(10);
li.Add(1);
li.Add(2);
li.Add(3);

var str = "1234";

foreach (var item in str)
{
    Console.WriteLine(item);
}

foreach (var item in li)
{
    Console.WriteLine(item);
}


var game = new Game();
game.Run();

Console.WriteLine("Game over");
Console.ReadLine();
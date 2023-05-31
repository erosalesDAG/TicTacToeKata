using TicTacToe.Console;

var game = new Game();
foreach (var coordinate in Enum.GetValues(typeof(Coordinates)))
{
    Console.WriteLine($"{coordinate}");
}

while (game.GetCurrentResult() == GameResults.GameNotFinished)
{
    Console.WriteLine("Please Select your position:");
    var position = Console.ReadLine();
    game.PlayTurn(Enum.Parse<Coordinates>(position));
}

Console.WriteLine();
Console.WriteLine($"{game.GetCurrentResult()}!!!");
namespace TicTacToe.Console;

public class Game
{
    private string lastPlayer;

    public Game()
    {
        lastPlayer = "";
    }

    public void PlayTurn(string player)
    {
        if (lastPlayer == "" && player == "O")
        {
            throw new InvalidOperationException();
        }
        
        if (lastPlayer != "" && lastPlayer == player)
        {
            throw new InvalidOperationException();
        }
        lastPlayer = player;
    }
}
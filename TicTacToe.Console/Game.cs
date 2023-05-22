namespace TicTacToe.Console;

public class Game
{
    private Token lastToken;

    public Game()
    {
        lastToken = Token.Empty;
    }

    public void PlayTurn(Token token)
    {
        ValidateTurnCanBePlayed(token);

        lastToken = token;
    }

    private void ValidateTurnCanBePlayed(Token token)
    {
        if (lastToken == Token.Empty && token == Token.O)
        {
            throw new InvalidOperationException();
        }

        if (lastToken != Token.Empty && lastToken == token)
        {
            throw new InvalidOperationException();
        }
    }

    public object GetCurrentResult()
    {
        throw new NotImplementedException();
    }
}
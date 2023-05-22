namespace TicTacToe.Console;

public class Game
{
    private Token lastToken;
    private Board board;

    public Game()
    {
        lastToken = Token.Empty;
        board = new Board();
    }

    public void PlayTurn(Token token, Coordinates coordinates)
    {
        ValidateTurnCanBePlayed(token);
        board.PlaceToken(token, coordinates);
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

    public string GetCurrentResult()
    {
        if (board.GetCurrentState()[0, 0] == Token.X && board.GetCurrentState()[1, 0] == Token.X &&
            board.GetCurrentState()[2, 0] == Token.X)
        {
            return "X wins.";
        }
        if (board.GetCurrentState()[0, 1] == Token.X && board.GetCurrentState()[1, 1] == Token.X &&
            board.GetCurrentState()[2, 1] == Token.X)
        {
            return "X wins.";
        }
        if (board.GetCurrentState()[0, 2] == Token.X && board.GetCurrentState()[1, 2] == Token.X &&
            board.GetCurrentState()[2, 2] == Token.X)
        {
            return "X wins.";
        }

        return "";
    }
}
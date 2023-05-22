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
        var boardCurrentState = board.GetCurrentState();
        if (TokenWinsByTakingColumn(0) ||
            TokenWinsByTakingColumn(1) ||
            TokenWinsByTakingColumn(2))
        {
            return $"{lastToken} wins.";
        }

        return "";
    }

    private bool TokenWinsByTakingColumn(int column)
    {
        return board.TokenAt(new Coordinates(0, column)) == lastToken && board.TokenAt(new Coordinates(1, column)) == lastToken &&
               board.TokenAt(new Coordinates(2, column)) == lastToken;
    }
}
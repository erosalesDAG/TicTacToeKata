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
        if (TokenWinsByTakingColumn(0) || TokenWinsByTakingColumn(1) || TokenWinsByTakingColumn(2))
        {
            return $"{lastToken} wins.";
        }

        if (TokenWinsByTakingRow(0) || TokenWinsByTakingRow(1) || TokenWinsByTakingRow(2))
        {
            return $"{lastToken} wins.";
        }

        if (board.TokenAt(new Coordinates(0, 0)) == lastToken && board.TokenAt(new Coordinates(1, 1)) == lastToken &&
            board.TokenAt(new Coordinates(2, 2)) == lastToken)
        {
            return $"{lastToken} wins.";
        }

        return "";
    }

    private bool TokenWinsByTakingRow(int row)
    {
        return board.TokenAt(new Coordinates(row, 0)) == lastToken &&
               board.TokenAt(new Coordinates(row, 1)) == lastToken &&
               board.TokenAt(new Coordinates(row, 2)) == lastToken;
    }

    private bool TokenWinsByTakingColumn(int column)
    {
        return board.TokenAt(new Coordinates(0, column)) == lastToken &&
               board.TokenAt(new Coordinates(1, column)) == lastToken &&
               board.TokenAt(new Coordinates(2, column)) == lastToken;
    }
}
namespace TicTacToe.Console;

public class Game
{
    private Token currentToken;
    private Board board;

    public Game()
    {
        currentToken = Token.O;
        board = new Board();
    }

    public void PlayTurn(Coordinates coordinates)
    {
        currentToken = currentToken == Token.X ? Token.O : Token.X;

        board.PlaceToken(currentToken, coordinates);
    }


    public string GetCurrentResult()
    {
        if (TokenWinsByTakingColumn(0) || TokenWinsByTakingColumn(1) || TokenWinsByTakingColumn(2))
        {
            return $"{currentToken} wins.";
        }

        if (TokenWinsByTakingRow(0) || TokenWinsByTakingRow(1) || TokenWinsByTakingRow(2))
        {
            return $"{currentToken} wins.";
        }

        if (TokenWinsByTakingTopLeftDiagonal() || TokenWinsByTakingTopRightDiagonal())
        {
            return $"{currentToken} wins.";
        }

        return "Draw.";
    }

    private bool TokenWinsByTakingRow(int row)
    {
        return board.TokenAt(new Coordinates(row, 0)) == currentToken &&
               board.TokenAt(new Coordinates(row, 1)) == currentToken &&
               board.TokenAt(new Coordinates(row, 2)) == currentToken;
    }

    private bool TokenWinsByTakingColumn(int column)
    {
        return board.TokenAt(new Coordinates(0, column)) == currentToken &&
               board.TokenAt(new Coordinates(1, column)) == currentToken &&
               board.TokenAt(new Coordinates(2, column)) == currentToken;
    }

    private bool TokenWinsByTakingTopLeftDiagonal()
    {
        return board.TokenAt(new Coordinates(0, 0)) == currentToken && board.TokenAt(new Coordinates(1, 1)) == currentToken &&
               board.TokenAt(new Coordinates(2, 2)) == currentToken;
    }

    private bool TokenWinsByTakingTopRightDiagonal()
    {
        return board.TokenAt(new Coordinates(0, 2)) == currentToken && board.TokenAt(new Coordinates(1, 1)) == currentToken &&
               board.TokenAt(new Coordinates(2, 0)) == currentToken;
    }
}
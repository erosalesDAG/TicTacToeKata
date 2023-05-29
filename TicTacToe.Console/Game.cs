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

        board.PlaceToken(coordinates, currentToken);
    }


    public string GetCurrentResult()
    {
        if (TokenWinsByTakingFirstColumn() || TokenWinsByTakingSecondColumn() || TokenWinsByTakingThirdColumn())
        {
            return $"{currentToken} wins.";
        }

        if (TokenWinsByTakingFirstRow() || TokenWinsByTakingSecondRow() || TokenWinsByTakingThirdRow())
        {
            return $"{currentToken} wins.";
        }

        if (TokenWinsByTakingTopLeftDiagonal() || TokenWinsByTakingTopRightDiagonal())
        {
            return $"{currentToken} wins.";
        }

        return "Draw.";
    }

    private bool TokenWinsByTakingFirstRow()
    {
        return board.TokenAt(Coordinates.TopLeft) == currentToken &&
               board.TokenAt(Coordinates.TopCenter) == currentToken &&
               board.TokenAt(Coordinates.TopRight) == currentToken;
    }

    private bool TokenWinsByTakingSecondRow()
    {
        return board.TokenAt(Coordinates.MiddleLeft) == currentToken &&
               board.TokenAt(Coordinates.MiddleCenter) == currentToken &&
               board.TokenAt(Coordinates.MiddleRight) == currentToken;
    }

    private bool TokenWinsByTakingThirdRow()
    {
        return board.TokenAt(Coordinates.BottomLeft) == currentToken &&
               board.TokenAt(Coordinates.BottomCenter) == currentToken &&
               board.TokenAt(Coordinates.BottomRight) == currentToken;
    }

    private bool TokenWinsByTakingFirstColumn()
    {
        return board.TokenAt(Coordinates.TopLeft) == currentToken &&
               board.TokenAt(Coordinates.MiddleLeft) == currentToken &&
               board.TokenAt(Coordinates.BottomLeft) == currentToken;
    }

    private bool TokenWinsByTakingSecondColumn()
    {
        return board.TokenAt(Coordinates.TopCenter) == currentToken &&
               board.TokenAt(Coordinates.MiddleCenter) == currentToken &&
               board.TokenAt(Coordinates.BottomCenter) == currentToken;
    }

    private bool TokenWinsByTakingThirdColumn()
    {
        return board.TokenAt(Coordinates.TopRight) == currentToken &&
               board.TokenAt(Coordinates.MiddleRight) == currentToken &&
               board.TokenAt(Coordinates.BottomRight) == currentToken;
    }

    private bool TokenWinsByTakingTopLeftDiagonal()
    {
        return board.TokenAt(Coordinates.TopLeft) == currentToken &&
               board.TokenAt(Coordinates.MiddleCenter) == currentToken &&
               board.TokenAt(Coordinates.BottomRight) == currentToken;
    }

    private bool TokenWinsByTakingTopRightDiagonal()
    {
        return board.TokenAt(Coordinates.TopRight) == currentToken &&
               board.TokenAt(Coordinates.MiddleCenter) == currentToken &&
               board.TokenAt(Coordinates.BottomLeft) == currentToken;
    }
}
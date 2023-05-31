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


    public GameResults GetCurrentResult()
    {
        if (TokenWinsByTakingColumn() || TokenWinsByTakingRow() || TokenWinsByTakingDiagonal())
        {
            return currentToken == Token.X ? GameResults.XWins : GameResults.OWins;
        }

        return board.IsFull() ? GameResults.Draw : GameResults.GameNotFinished;
    }

    private bool TokenWinsByTakingColumn() => TokenWinsByTakingFirstColumn() || TokenWinsByTakingSecondColumn() ||
                                              TokenWinsByTakingThirdColumn();

    private bool TokenWinsByTakingRow() => TokenWinsByTakingFirstRow() || TokenWinsByTakingSecondRow() || TokenWinsByTakingThirdRow();

    private bool TokenWinsByTakingDiagonal() => TokenWinsByTakingTopLeftDiagonal() || TokenWinsByTakingTopRightDiagonal();

    private bool TokenWinsByTakingFirstRow() =>
        board.TokenAt(Coordinates.TopLeft) == currentToken && board.TokenAt(Coordinates.TopCenter) == currentToken &&
        board.TokenAt(Coordinates.TopRight) == currentToken;

    private bool TokenWinsByTakingSecondRow() =>
        board.TokenAt(Coordinates.MiddleLeft) == currentToken && board.TokenAt(Coordinates.MiddleCenter) == currentToken &&
        board.TokenAt(Coordinates.MiddleRight) == currentToken;

    private bool TokenWinsByTakingThirdRow() =>
        board.TokenAt(Coordinates.BottomLeft) == currentToken && board.TokenAt(Coordinates.BottomCenter) == currentToken &&
        board.TokenAt(Coordinates.BottomRight) == currentToken;

    private bool TokenWinsByTakingFirstColumn() =>
        board.TokenAt(Coordinates.TopLeft) == currentToken && board.TokenAt(Coordinates.MiddleLeft) == currentToken &&
        board.TokenAt(Coordinates.BottomLeft) == currentToken;

    private bool TokenWinsByTakingSecondColumn() =>
        board.TokenAt(Coordinates.TopCenter) == currentToken &&  board.TokenAt(Coordinates.MiddleCenter) == currentToken &&
        board.TokenAt(Coordinates.BottomCenter) == currentToken;

    private bool TokenWinsByTakingThirdColumn() =>
        board.TokenAt(Coordinates.TopRight) == currentToken &&  board.TokenAt(Coordinates.MiddleRight) == currentToken &&
        board.TokenAt(Coordinates.BottomRight) == currentToken;

    private bool TokenWinsByTakingTopLeftDiagonal() =>
        board.TokenAt(Coordinates.TopLeft) == currentToken && board.TokenAt(Coordinates.MiddleCenter) == currentToken &&
        board.TokenAt(Coordinates.BottomRight) == currentToken;

    private bool TokenWinsByTakingTopRightDiagonal() =>
        board.TokenAt(Coordinates.TopRight) == currentToken && board.TokenAt(Coordinates.MiddleCenter) == currentToken &&
        board.TokenAt(Coordinates.BottomLeft) == currentToken;
}
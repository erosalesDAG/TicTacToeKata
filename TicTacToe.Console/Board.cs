namespace TicTacToe.Console;

public class Board
{
    private readonly Dictionary<Coordinates, Token> currentBoard;

    public Board()
    {
        currentBoard = new Dictionary<Coordinates, Token>();
    }

    public void PlaceToken(Coordinates coordinates, Token token)
    {
        if (currentBoard.ContainsKey(coordinates)) throw new InvalidOperationException();
        currentBoard.Add(coordinates, token);
    }

    public Token TokenAt(Coordinates coordinates) =>
        currentBoard.ContainsKey(coordinates) ? currentBoard[coordinates] : Token.Empty;

    public bool IsEmpty()
    {
        return currentBoard.Count == 0;
    }

    public bool IsFull()
    {
        return currentBoard.Count == 9;
    }
}
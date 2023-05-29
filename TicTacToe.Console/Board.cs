namespace TicTacToe.Console;

public class Board
{
    private readonly Token[,] currentState;
    private readonly Dictionary<Coordinates, Token> currentBoard;

    public Board()
    {
        currentState = new Token[,]
        {
            { Token.Empty, Token.Empty, Token.Empty },
            { Token.Empty, Token.Empty, Token.Empty },
            { Token.Empty, Token.Empty, Token.Empty }
        };

        currentBoard = new Dictionary<Coordinates, Token>();
    }

    public void PlaceToken(Coordinates coordinates, Token token)
    {
        if (currentBoard.ContainsKey(coordinates)) throw new InvalidOperationException();
        currentBoard.Add(coordinates, token);
    }

    public Token[,] GetCurrentState()
    {
        return currentState;
    }

    public Token TokenAt(Coordinates coordinates) =>
        currentBoard.ContainsKey(coordinates) ? currentBoard[coordinates] : Token.Empty;
}
namespace TicTacToe.Console;

public class Board
{
    private readonly Token[,] currentState;

    public Board()
    {
        currentState = new Token[,]
            {
                { Token.Empty, Token.Empty, Token.Empty },
                { Token.Empty, Token.Empty, Token.Empty },
                { Token.Empty, Token.Empty, Token.Empty }
            }
        ;
    }

    public void PlaceToken(Token token, Coordinates coordinates)
    {
        if (coordinates.X > currentState.GetLength(0) || coordinates.Y > currentState.GetLength(1)) throw new ArgumentOutOfRangeException();
        if (currentState[coordinates.X, coordinates.Y] != Token.Empty) throw new InvalidOperationException();
        currentState[coordinates.X,coordinates.Y] = token;
    }

    public Token[,] GetCurrentState()
    {
        return currentState;
    }

    public Token TokenAt(Coordinates coordinates)
    {
        return currentState[coordinates.X,coordinates.Y];
    }
}
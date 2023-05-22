namespace TicTacToe.Console;

public class Board
{
    private Token[,] currentState;

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

    public void PlaceToken(Token token, int x, int y)
    {
        if (x > currentState.GetLength(0) || y > currentState.GetLength(1)) throw new ArgumentOutOfRangeException();
        currentState[x,y] = token;
    }

    public Token[,] GetCurrentState()
    {
        return currentState;
    }
}
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
        currentState[x,y] = token;
    }

    public Token[,] GetCurrentState()
    {
        return currentState;
    }
}
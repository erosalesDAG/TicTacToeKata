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

    public void PlaceToken(Token token, int i, int i1)
    {
        currentState[i,i1] = token;
    }

    public Token[,] GetCurrentState()
    {
        return currentState;
    }
}
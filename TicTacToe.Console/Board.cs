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
        throw new NotImplementedException();
    }

    public Token[,] GetCurrentState()
    {
        return currentState;
    }
}
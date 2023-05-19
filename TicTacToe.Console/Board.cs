namespace TicTacToe.Console;

public class Board
{
    public Token[,] currentState { get; }

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

    public object PlaceToken(Token token, int i, int i1)
    {
        throw new NotImplementedException();
    }
}
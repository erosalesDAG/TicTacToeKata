namespace TicTacToe.Console;

public class Game
{
    private Token lastToken;
    private Board board;

    public Game()
    {
        lastToken = Token.Empty;
        board = new Board();
    }

    public void PlayTurn(Token token, Coordinates coordinates)
    {
        ValidateTurnCanBePlayed(token);
        board.PlaceToken(token, coordinates);
        lastToken = token;
    }

    private void ValidateTurnCanBePlayed(Token token)
    {
        if (lastToken == Token.Empty && token == Token.O)
        {
            throw new InvalidOperationException();
        }

        if (lastToken != Token.Empty && lastToken == token)
        {
            throw new InvalidOperationException();
        }
    }

    public string GetCurrentResult()
    {
        var boardCurrentState = board.GetCurrentState();
        if (HasTokenXTakenFirstColumn(boardCurrentState, lastToken) || HasTokenXTakenSecondColumn(boardCurrentState, lastToken) ||
            HasTokenXTakenThirdColumn(boardCurrentState, lastToken))
        {
            return $"{lastToken.ToString()} wins.";
        }

        return "";
    }

    private static bool HasTokenXTakenFirstColumn(Token[,] boardCurrentState, Token token)
    {
        return boardCurrentState[0, 0] == token && boardCurrentState[1, 0] == token &&
               boardCurrentState[2, 0] == token;
    }

    private static bool HasTokenXTakenSecondColumn(Token[,] boardCurrentState, Token token)
    {
        return boardCurrentState[0, 1] == token && boardCurrentState[1, 1] == token &&
               boardCurrentState[2, 1] == token;
    }

    private static bool HasTokenXTakenThirdColumn(Token[,] boardCurrentState, Token token)
    {
        return boardCurrentState[0, 2] == token && boardCurrentState[1, 2] == token &&
               boardCurrentState[2, 2] == token;
    }
}
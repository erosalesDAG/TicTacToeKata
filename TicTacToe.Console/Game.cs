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
        if (HasTokenXTakenFirstColumn(boardCurrentState) || HasTokenXTakenSecondColumn(boardCurrentState) ||
            HasTokenXTakenThirdColumn(boardCurrentState))
        {
            return "X wins.";
        }

        return "";
    }

    private static bool HasTokenXTakenThirdColumn(Token[,] boardCurrentState)
    {
        return boardCurrentState[0, 2] == Token.X && boardCurrentState[1, 2] == Token.X &&
               boardCurrentState[2, 2] == Token.X;
    }

    private static bool HasTokenXTakenSecondColumn(Token[,] boardCurrentState)
    {
        return boardCurrentState[0, 1] == Token.X && boardCurrentState[1, 1] == Token.X &&
               boardCurrentState[2, 1] == Token.X;
    }

    private static bool HasTokenXTakenFirstColumn(Token[,] boardCurrentState)
    {
        return boardCurrentState[0, 0] == Token.X && boardCurrentState[1, 0] == Token.X &&
               boardCurrentState[2, 0] == Token.X;
    }
}
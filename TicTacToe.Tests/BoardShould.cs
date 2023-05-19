using FluentAssertions;
using TicTacToe.Console;

namespace TicTacToe.Tests;

public class BoardShould
{
    [Test]
    public void CreateEmptyBoard()
    {
        var result = new Board().GetCurrentState();

        result.Should().BeEquivalentTo(new[,]
        {
            { Token.Empty, Token.Empty, Token.Empty },
            { Token.Empty, Token.Empty, Token.Empty },
            { Token.Empty, Token.Empty, Token.Empty }
        });
    }


    [Test]
    public void PlaceOneTokenOnEmptyBoard()
    {
        var board = new Board();
        board.PlaceToken(Token.X, 0, 0);
        var result = board.GetCurrentState();
        result.Should().BeEquivalentTo(new[,]
        {
            { Token.X, Token.Empty, Token.Empty },
            { Token.Empty, Token.Empty, Token.Empty },
            { Token.Empty, Token.Empty, Token.Empty }
        });
    }
}
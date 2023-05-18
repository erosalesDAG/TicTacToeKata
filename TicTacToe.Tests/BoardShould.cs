using FluentAssertions;
using TicTacToe.Console;

namespace TicTacToe.Tests;

public class BoardShould
{
    [Test]
    public void CreateEmptyBoard()
    {
        var boad = new Board();

        boad.Should().Be(new[,]
        {
            { Token.Empty, Token.Empty, Token.Empty },
            { Token.Empty, Token.Empty, Token.Empty },
            { Token.Empty, Token.Empty, Token.Empty }
        });
    }
}
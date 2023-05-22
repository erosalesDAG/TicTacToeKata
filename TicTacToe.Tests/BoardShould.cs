using FluentAssertions;
using TicTacToe.Console;

namespace TicTacToe.Tests;

public class BoardShould
{
    private Board board;

    [SetUp]
    public void SetUp()
    {
        board = new Board();
    }

    [Test]
    public void CreateEmptyBoardOnStart()
    {
        var result = board.GetCurrentState();

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
        board.PlaceToken(Token.X, new Coordinates(0, 0));
        var result = board.GetCurrentState();

        result.Should().BeEquivalentTo(new[,]
        {
            { Token.X, Token.Empty, Token.Empty },
            { Token.Empty, Token.Empty, Token.Empty },
            { Token.Empty, Token.Empty, Token.Empty }
        });
    }

    [Test]
    public void FailToPlaceTokenOutOfBoundaries()
    {
        var result = () => board.PlaceToken(Token.X, new Coordinates(7, 5));

        result.Should().Throw<ArgumentOutOfRangeException>();
    }

    [Test]
    public void FailToPlaceTokenInAlreadyUsedSpot()
    {
        board.PlaceToken(Token.X,new Coordinates(0,0));
        var result = () => board.PlaceToken(Token.X,new Coordinates(0,0));

        result.Should().Throw<InvalidOperationException>();
    }
}
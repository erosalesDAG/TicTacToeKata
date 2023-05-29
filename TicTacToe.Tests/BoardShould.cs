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
        var result = board.IsEmpty();

        result.Should().BeTrue();
    }

    [Test]
    public void PlaceOneTokenOnEmptyBoard()
    {
        board.PlaceToken(Coordinates.TopLeft, Token.X);
        var result = board.TokenAt(Coordinates.TopLeft);

        result.Should().Be(Token.X);
    }
    
    [Test]
    public void FailToPlaceTokenInAlreadyUsedSpot()
    {
        board.PlaceToken(Coordinates.TopLeft, Token.X);
        var result = () => board.PlaceToken(Coordinates.TopLeft, Token.X);

        result.Should().Throw<InvalidOperationException>();
    }
}
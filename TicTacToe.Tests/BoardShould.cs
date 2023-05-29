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

    [Test]
    public void BeFullWhenAllCoordinatesAreTaken()
    {
        board.PlaceToken(Coordinates.TopLeft, Token.X);
        board.PlaceToken(Coordinates.TopCenter,Token.O);
        board.PlaceToken(Coordinates.TopRight, Token.X);
        board.PlaceToken(Coordinates.MiddleLeft, Token.O);
        board.PlaceToken(Coordinates.MiddleCenter, Token.X);
        board.PlaceToken(Coordinates.MiddleRight, Token.O);
        board.PlaceToken(Coordinates.BottomCenter, Token.X);
        board.PlaceToken(Coordinates.BottomLeft, Token.O);
        board.PlaceToken(Coordinates.BottomRight, Token.X);

        var result = board.IsFull();
        result.Should().BeTrue();
    }
}
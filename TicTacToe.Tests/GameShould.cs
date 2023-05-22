using FluentAssertions;
using NUnit.Framework.Constraints;
using TicTacToe.Console;

namespace TicTacToe.Tests
{
    public class GameShould
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FailIfFirstPlayerIsO()
        {
            var game = new Game();

            var result = () => game.PlayTurn(Token.O, new Coordinates(0,0));

            result.Should().Throw<InvalidOperationException>();
        }

        [Test]
        public void FailIfPlayerPlaysTwice()
        {
            var game = new Game();
            game.PlayTurn(Token.X, new Coordinates(0, 0));

            var result = () => game.PlayTurn(Token.X, new Coordinates(0, 1));

            result.Should().Throw<InvalidOperationException>();
        }


        [Test]
        public void GetWinnerWhenFirstColumnHasBeenTakenByTokenX()
        {
            var game = new Game();

            game.PlayTurn(Token.X, new Coordinates(0, 0));
            game.PlayTurn(Token.O, new Coordinates(0, 1));
            game.PlayTurn(Token.X, new Coordinates(1, 0));
            game.PlayTurn(Token.O, new Coordinates(1, 1));
            game.PlayTurn(Token.X, new Coordinates(2, 0));

            var result = game.GetCurrentResult();

            result.Should().BeEquivalentTo("X wins.");
        }
    }
}
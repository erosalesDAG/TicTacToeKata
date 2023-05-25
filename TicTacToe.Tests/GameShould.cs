using FluentAssertions;
using NUnit.Framework.Constraints;
using TicTacToe.Console;

namespace TicTacToe.Tests
{
    public class GameShould
    {
        private Game game;

        [SetUp]
        public void Setup()
        {
            game = new Game();
        }

        [Test]
        public void FailIfFirstPlayerIsO()
        {
            var result = () => game.PlayTurn(Token.O, new Coordinates(0, 0));

            result.Should().Throw<InvalidOperationException>();
        }

        [Test]
        public void FailIfPlayerPlaysTwice()
        {
            game.PlayTurn(Token.X, new Coordinates(0, 0));

            var result = () => game.PlayTurn(Token.X, new Coordinates(0, 1));

            result.Should().Throw<InvalidOperationException>();
        }


        [Test]
        public void GetWinnerWhenFirstColumnHasBeenTakenByTokenX()
        {
            game.PlayTurn(Token.X, new Coordinates(0, 0));
            game.PlayTurn(Token.O, new Coordinates(0, 1));
            game.PlayTurn(Token.X, new Coordinates(1, 0));
            game.PlayTurn(Token.O, new Coordinates(1, 1));
            game.PlayTurn(Token.X, new Coordinates(2, 0));

            var result = game.GetCurrentResult();

            result.Should().BeEquivalentTo("X wins.");
        }

        [Test]
        public void GetWinnerWhenSecondColumnHasBeenTakenByTokenX()
        {
            game.PlayTurn(Token.X, new Coordinates(0, 1));
            game.PlayTurn(Token.O, new Coordinates(0, 0));
            game.PlayTurn(Token.X, new Coordinates(1, 1));
            game.PlayTurn(Token.O, new Coordinates(1, 2));
            game.PlayTurn(Token.X, new Coordinates(2, 1));

            var result = game.GetCurrentResult();

            result.Should().BeEquivalentTo("X wins.");
        }

        [Test]
        public void GetWinnerWhenThirdColumnHasBeenTakenByTokenX()
        {
            game.PlayTurn(Token.X, new Coordinates(0, 2));
            game.PlayTurn(Token.O, new Coordinates(0, 0));
            game.PlayTurn(Token.X, new Coordinates(1, 2));
            game.PlayTurn(Token.O, new Coordinates(1, 1));
            game.PlayTurn(Token.X, new Coordinates(2, 2));

            var result = game.GetCurrentResult();

            result.Should().BeEquivalentTo("X wins.");
        }

        [Test]
        public void GetWinnerWhenFirstColumnHasBeenTakenByTokenO()
        {
            game.PlayTurn(Token.X, new Coordinates(0, 1));
            game.PlayTurn(Token.O, new Coordinates(0, 0));
            game.PlayTurn(Token.X, new Coordinates(1, 1));
            game.PlayTurn(Token.O, new Coordinates(1, 0));
            game.PlayTurn(Token.X, new Coordinates(2, 2));
            game.PlayTurn(Token.O, new Coordinates(2, 0));

            var result = game.GetCurrentResult();

            result.Should().BeEquivalentTo("O wins.");
        }

        [Test]
        public void GetWinnerWhenSecondColumnHasBeenTakenByTokenO()
        {
            game.PlayTurn(Token.X, new Coordinates(0, 0));
            game.PlayTurn(Token.O, new Coordinates(0, 1));
            game.PlayTurn(Token.X, new Coordinates(1, 0));
            game.PlayTurn(Token.O, new Coordinates(1, 1));
            game.PlayTurn(Token.X, new Coordinates(2, 0));
            game.PlayTurn(Token.O, new Coordinates(2, 1));

            var result = game.GetCurrentResult();

            result.Should().BeEquivalentTo("O wins.");
        }

        [Test]
        public void GetWinnerWhenThirdColumnHasBeenTakenByTokenO()
        {
            game.PlayTurn(Token.X, new Coordinates(0, 0));
            game.PlayTurn(Token.O, new Coordinates(0, 2));
            game.PlayTurn(Token.X, new Coordinates(1, 0));
            game.PlayTurn(Token.O, new Coordinates(1, 2));
            game.PlayTurn(Token.X, new Coordinates(2, 0));
            game.PlayTurn(Token.O, new Coordinates(2, 2));

            var result = game.GetCurrentResult();

            result.Should().BeEquivalentTo("O wins.");
        }


        [Test]
        public void GetWinnerWhenFirstRowHasBeenTakenByToken()
        {
            game.PlayTurn(Token.X, new Coordinates(0, 0));
            game.PlayTurn(Token.O, new Coordinates(1, 2));
            game.PlayTurn(Token.X, new Coordinates(0, 1));
            game.PlayTurn(Token.O, new Coordinates(1, 1));
            game.PlayTurn(Token.X, new Coordinates(0, 2));

            var result = game.GetCurrentResult();

            result.Should().BeEquivalentTo("X wins.");
        }

        [Test]
        public void GetWinnerWhenSecondRowHasBeenTakenByToken()
        {
            game.PlayTurn(Token.X, new Coordinates(1, 0));
            game.PlayTurn(Token.O, new Coordinates(0, 0));
            game.PlayTurn(Token.X, new Coordinates(1, 1));
            game.PlayTurn(Token.O, new Coordinates(2, 1));
            game.PlayTurn(Token.X, new Coordinates(1, 2));

            var result = game.GetCurrentResult();

            result.Should().BeEquivalentTo("X wins.");
        }

        [Test]
        public void GetWinnerWhenThirdRowHasBeenTakenByToken()
        {
            game.PlayTurn(Token.X, new Coordinates(2, 0));
            game.PlayTurn(Token.O, new Coordinates(0, 0));
            game.PlayTurn(Token.X, new Coordinates(2, 1));
            game.PlayTurn(Token.O, new Coordinates(1, 1));
            game.PlayTurn(Token.X, new Coordinates(2, 2));

            var result = game.GetCurrentResult();

            result.Should().BeEquivalentTo("X wins.");
        }

        [Test]
        public void GetWinnerWhenDiagonalTopLeftToBottomRightHasBeenTaken()
        {
            game.PlayTurn(Token.X, new Coordinates(0, 0));
            game.PlayTurn(Token.O, new Coordinates(0, 1));
            game.PlayTurn(Token.X, new Coordinates(1, 1));
            game.PlayTurn(Token.O, new Coordinates(1, 2));
            game.PlayTurn(Token.X, new Coordinates(2, 2));

            var result = game.GetCurrentResult();

            result.Should().BeEquivalentTo("X wins.");
        }


        [Test]
        public void GetWinnerWhenDiagonalTopRightToBottomLeftHasBeenTaken()
        {
            game.PlayTurn(Token.X, new Coordinates(0, 2));
            game.PlayTurn(Token.O, new Coordinates(0, 1));
            game.PlayTurn(Token.X, new Coordinates(1, 1));
            game.PlayTurn(Token.O, new Coordinates(1, 2));
            game.PlayTurn(Token.X, new Coordinates(2,0));

            var result = game.GetCurrentResult();

            result.Should().BeEquivalentTo("X wins.");
        }
    }
}
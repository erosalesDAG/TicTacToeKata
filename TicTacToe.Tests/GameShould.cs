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
        public void GetWinnerWhenFirstColumnHasBeenTakenByTokenX()
        {
            game.PlayTurn(new Coordinates(0, 0));
            game.PlayTurn(new Coordinates(0, 1));
            game.PlayTurn(new Coordinates(1, 0));
            game.PlayTurn(new Coordinates(1, 1));
            game.PlayTurn(new Coordinates(2, 0));

            var result = game.GetCurrentResult();

            result.Should().BeEquivalentTo("X wins.");
        }

        [Test]
        public void GetWinnerWhenSecondColumnHasBeenTakenByTokenX()
        {
            game.PlayTurn(new Coordinates(0, 1));
            game.PlayTurn(new Coordinates(0, 0));
            game.PlayTurn(new Coordinates(1, 1));
            game.PlayTurn(new Coordinates(1, 2));
            game.PlayTurn(new Coordinates(2, 1));

            var result = game.GetCurrentResult();

            result.Should().BeEquivalentTo("X wins.");
        }

        [Test]
        public void GetWinnerWhenThirdColumnHasBeenTakenByTokenX()
        {
            game.PlayTurn(new Coordinates(0, 2));
            game.PlayTurn(new Coordinates(0, 0));
            game.PlayTurn(new Coordinates(1, 2));
            game.PlayTurn(new Coordinates(1, 1));
            game.PlayTurn(new Coordinates(2, 2));

            var result = game.GetCurrentResult();

            result.Should().BeEquivalentTo("X wins.");
        }

        [Test]
        public void GetWinnerWhenFirstColumnHasBeenTakenByTokenO()
        {
            game.PlayTurn(new Coordinates(0, 1));
            game.PlayTurn(new Coordinates(0, 0));
            game.PlayTurn(new Coordinates(1, 1));
            game.PlayTurn(new Coordinates(1, 0));
            game.PlayTurn(new Coordinates(2, 2));
            game.PlayTurn(new Coordinates(2, 0));

            var result = game.GetCurrentResult();

            result.Should().BeEquivalentTo("O wins.");
        }

        [Test]
        public void GetWinnerWhenSecondColumnHasBeenTakenByTokenO()
        {
            game.PlayTurn(new Coordinates(0, 0));
            game.PlayTurn(new Coordinates(0, 1));
            game.PlayTurn(new Coordinates(1, 0));
            game.PlayTurn(new Coordinates(1, 1));
            game.PlayTurn(new Coordinates(2, 0));
            game.PlayTurn(new Coordinates(2, 1));

            var result = game.GetCurrentResult();

            result.Should().BeEquivalentTo("O wins.");
        }

        [Test]
        public void GetWinnerWhenThirdColumnHasBeenTakenByTokenO()
        {
            game.PlayTurn(new Coordinates(0, 0));
            game.PlayTurn(new Coordinates(0, 2));
            game.PlayTurn(new Coordinates(1, 0));
            game.PlayTurn(new Coordinates(1, 2));
            game.PlayTurn(new Coordinates(2, 0));
            game.PlayTurn(new Coordinates(2, 2));

            var result = game.GetCurrentResult();

            result.Should().BeEquivalentTo("O wins.");
        }


        [Test]
        public void GetWinnerWhenFirstRowHasBeenTakenByToken()
        {
            game.PlayTurn(new Coordinates(0, 0));
            game.PlayTurn(new Coordinates(1, 2));
            game.PlayTurn(new Coordinates(0, 1));
            game.PlayTurn(new Coordinates(1, 1));
            game.PlayTurn(new Coordinates(0, 2));

            var result = game.GetCurrentResult();

            result.Should().BeEquivalentTo("X wins.");
        }

        [Test]
        public void GetWinnerWhenSecondRowHasBeenTakenByToken()
        {
            game.PlayTurn(new Coordinates(1, 0));
            game.PlayTurn(new Coordinates(0, 0));
            game.PlayTurn(new Coordinates(1, 1));
            game.PlayTurn(new Coordinates(2, 1));
            game.PlayTurn(new Coordinates(1, 2));

            var result = game.GetCurrentResult();

            result.Should().BeEquivalentTo("X wins.");
        }

        [Test]
        public void GetWinnerWhenThirdRowHasBeenTakenByToken()
        {
            game.PlayTurn(new Coordinates(2, 0));
            game.PlayTurn(new Coordinates(0, 0));
            game.PlayTurn(new Coordinates(2, 1));
            game.PlayTurn(new Coordinates(1, 1));
            game.PlayTurn(new Coordinates(2, 2));

            var result = game.GetCurrentResult();

            result.Should().BeEquivalentTo("X wins.");
        }

        [Test]
        public void GetWinnerWhenDiagonalTopLeftToBottomRightHasBeenTaken()
        {
            game.PlayTurn(new Coordinates(0, 0));
            game.PlayTurn(new Coordinates(0, 1));
            game.PlayTurn(new Coordinates(1, 1));
            game.PlayTurn(new Coordinates(1, 2));
            game.PlayTurn(new Coordinates(2, 2));

            var result = game.GetCurrentResult();

            result.Should().BeEquivalentTo("X wins.");
        }


        [Test]
        public void GetWinnerWhenDiagonalTopRightToBottomLeftHasBeenTaken()
        {
            game.PlayTurn(new Coordinates(0, 2));
            game.PlayTurn(new Coordinates(0, 1));
            game.PlayTurn(new Coordinates(1, 1));
            game.PlayTurn(new Coordinates(1, 2));
            game.PlayTurn(new Coordinates(2,0));

            var result = game.GetCurrentResult();

            result.Should().BeEquivalentTo("X wins.");
        }


        [Test]
        public void GetDrawWhenFullBoardButNoTokenWon()
        {
            game.PlayTurn(new Coordinates(0, 0));
            game.PlayTurn(new Coordinates(0, 1));
            game.PlayTurn(new Coordinates(0, 2));
            game.PlayTurn(new Coordinates(1, 0));
            game.PlayTurn(new Coordinates(1, 1));
            game.PlayTurn(new Coordinates(2, 0));
            game.PlayTurn(new Coordinates(2, 1));
            game.PlayTurn(new Coordinates(2, 2));
            game.PlayTurn(new Coordinates(1, 2));

            var result = game.GetCurrentResult();

            result.Should().BeEquivalentTo("Draw.");
        } 
    }
}
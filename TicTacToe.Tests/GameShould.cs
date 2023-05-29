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
            game.PlayTurn(Coordinates.TopLeft);
            game.PlayTurn(Coordinates.TopCenter);
            game.PlayTurn(Coordinates.MiddleLeft);
            game.PlayTurn(Coordinates.MiddleCenter);
            game.PlayTurn(Coordinates.BottomLeft);

            var result = game.GetCurrentResult();

            result.Should().Be(GameResults.XWins);
        }

        [Test]
        public void GetWinnerWhenSecondColumnHasBeenTakenByTokenX()
        {
            game.PlayTurn(Coordinates.TopCenter);
            game.PlayTurn(Coordinates.TopLeft);
            game.PlayTurn(Coordinates.MiddleCenter);
            game.PlayTurn(Coordinates.MiddleRight);
            game.PlayTurn(Coordinates.BottomCenter);

            var result = game.GetCurrentResult();

            result.Should().Be(GameResults.XWins);
        }

        [Test]
        public void GetWinnerWhenThirdColumnHasBeenTakenByTokenX()
        {
            game.PlayTurn(Coordinates.TopRight);
            game.PlayTurn(Coordinates.TopLeft);
            game.PlayTurn(Coordinates.MiddleRight);
            game.PlayTurn(Coordinates.MiddleCenter);
            game.PlayTurn(Coordinates.BottomRight);

            var result = game.GetCurrentResult();

            result.Should().Be(GameResults.XWins);
        }

        [Test]
        public void GetWinnerWhenFirstColumnHasBeenTakenByTokenO()
        {
            game.PlayTurn(Coordinates.TopCenter);
            game.PlayTurn(Coordinates.TopLeft);
            game.PlayTurn(Coordinates.MiddleCenter);
            game.PlayTurn(Coordinates.MiddleLeft);
            game.PlayTurn(Coordinates.BottomRight);
            game.PlayTurn(Coordinates.BottomLeft);

            var result = game.GetCurrentResult();

            result.Should().Be(GameResults.OWins);
        }

        [Test]
        public void GetWinnerWhenSecondColumnHasBeenTakenByTokenO()
        {
            game.PlayTurn(Coordinates.TopLeft);
            game.PlayTurn(Coordinates.TopCenter);
            game.PlayTurn(Coordinates.MiddleLeft);
            game.PlayTurn(Coordinates.MiddleCenter);
            game.PlayTurn(Coordinates.BottomLeft);
            game.PlayTurn(Coordinates.BottomCenter);

            var result = game.GetCurrentResult();

            result.Should().Be(GameResults.OWins);
        }

        [Test]
        public void GetWinnerWhenThirdColumnHasBeenTakenByTokenO()
        {
            game.PlayTurn(Coordinates.TopLeft);
            game.PlayTurn(Coordinates.TopRight);
            game.PlayTurn(Coordinates.MiddleLeft);
            game.PlayTurn(Coordinates.MiddleRight);
            game.PlayTurn(Coordinates.BottomLeft);
            game.PlayTurn(Coordinates.BottomRight);

            var result = game.GetCurrentResult();

            result.Should().Be(GameResults.OWins);
        }


        [Test]
        public void GetWinnerWhenFirstRowHasBeenTakenByToken()
        {
            game.PlayTurn(Coordinates.TopLeft);
            game.PlayTurn(Coordinates.MiddleRight);
            game.PlayTurn(Coordinates.TopCenter);
            game.PlayTurn(Coordinates.MiddleCenter);
            game.PlayTurn(Coordinates.TopRight);

            var result = game.GetCurrentResult();

            result.Should().Be(GameResults.XWins);
        }

        [Test]
        public void GetWinnerWhenSecondRowHasBeenTakenByToken()
        {
            game.PlayTurn(Coordinates.MiddleLeft);
            game.PlayTurn(Coordinates.TopLeft);
            game.PlayTurn(Coordinates.MiddleCenter);
            game.PlayTurn(Coordinates.BottomCenter);
            game.PlayTurn(Coordinates.MiddleRight);

            var result = game.GetCurrentResult();

            result.Should().Be(GameResults.XWins);
        }

        [Test]
        public void GetWinnerWhenThirdRowHasBeenTakenByToken()
        {
            game.PlayTurn(Coordinates.BottomLeft);
            game.PlayTurn(Coordinates.TopLeft);
            game.PlayTurn(Coordinates.BottomCenter);
            game.PlayTurn(Coordinates.MiddleCenter);
            game.PlayTurn(Coordinates.BottomRight);

            var result = game.GetCurrentResult();

            result.Should().Be(GameResults.XWins);
        }

        [Test]
        public void GetWinnerWhenDiagonalTopLeftToBottomRightHasBeenTaken()
        {
            game.PlayTurn(Coordinates.TopLeft);
            game.PlayTurn(Coordinates.TopCenter);
            game.PlayTurn(Coordinates.MiddleCenter);
            game.PlayTurn(Coordinates.MiddleRight);
            game.PlayTurn(Coordinates.BottomRight);

            var result = game.GetCurrentResult();

            result.Should().Be(GameResults.XWins);
        }


        [Test]
        public void GetWinnerWhenDiagonalTopRightToBottomLeftHasBeenTaken()
        {
            game.PlayTurn(Coordinates.TopRight);
            game.PlayTurn(Coordinates.TopCenter);
            game.PlayTurn(Coordinates.MiddleCenter);
            game.PlayTurn(Coordinates.MiddleRight);
            game.PlayTurn(Coordinates.BottomLeft);

            var result = game.GetCurrentResult();

            result.Should().Be(GameResults.XWins);
        }


        [Test]
        public void GetDrawWhenFullBoardButNoTokenWon()
        {
            game.PlayTurn(Coordinates.TopLeft);
            game.PlayTurn(Coordinates.TopCenter);
            game.PlayTurn(Coordinates.TopRight);
            game.PlayTurn(Coordinates.MiddleLeft);
            game.PlayTurn(Coordinates.MiddleCenter);
            game.PlayTurn(Coordinates.BottomLeft);
            game.PlayTurn(Coordinates.BottomCenter);
            game.PlayTurn(Coordinates.BottomRight);
            game.PlayTurn(Coordinates.MiddleRight);

            var result = game.GetCurrentResult();

            result.Should().Be(GameResults.Draw);
        } 
    }
}
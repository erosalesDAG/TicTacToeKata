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

            var result = () => game.PlayTurn(Token.O);

            result.Should().Throw<InvalidOperationException>();
        }

        [Test]
        public void FailIfPlayerPlaysTwice()
        {
            var game = new Game();
            game.PlayTurn(Token.X);

            var result = () => game.PlayTurn(Token.X);

            result.Should().Throw<InvalidOperationException>();
        }


        [Test]
        public void GetWinnerWhenFirstColumnHasBeenTakenByTokenX()
        {
            var game = new Game();

            game.PlayTurn(Token.X);
            game.PlayTurn(Token.O);
            game.PlayTurn(Token.X);
            game.PlayTurn(Token.O);
            game.PlayTurn(Token.X);

            var result = game.GetCurrentResult();

            result.Should().BeEquivalentTo("X wins");
        }
    }
}
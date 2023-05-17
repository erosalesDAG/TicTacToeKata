using FluentAssertions;
using NUnit.Framework.Constraints;
using TicTacToe.Console;

namespace TicTacToe.Tests
{
    public class TicTacToeShould
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
        public void CreateEmptyBoard()
        {
            var game = new Game();

            var result = new Board();

            result.Should().Be(new Token[3,3]);
        }
    }
}
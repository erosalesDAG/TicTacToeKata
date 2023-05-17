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

            var result = () => game.PlayTurn("O");
            
            result.Should().Throw<InvalidOperationException>();
        }

        [Test]
        public void FailIfPlayerPlaysTwice()
        {
            var game = new Game(); 
            game.PlayTurn("X");

            var result = () => game.PlayTurn("X");

            result.Should().Throw<InvalidOperationException>();
        }
    }
}
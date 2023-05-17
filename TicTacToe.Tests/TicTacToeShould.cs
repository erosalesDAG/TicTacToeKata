using FluentAssertions;
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
    }
}
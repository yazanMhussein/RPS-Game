using Xunit;
using RPSGame;


namespace RPSGameTests
{
    public class RPSGameTests
    {
        [Fact]
        public void TestCompareMoves_PlayerWins()
        {
            RPSGame game = new RPSGame();
            Assert.Equal(1, game.CompareMoves("rock", "scissors"));
            Assert.Equal(1, game.CompareMoves("scissors", "paper"));
            Assert.Equal(1, game.CompareMoves("paper", "rock"));
        }

        [Fact]
        public void TestCompareMoves_AIWins()
        {
            RPSGame game = new RPSGame();
            Assert.Equal(-1, game.CompareMoves("rock", "paper"));
            Assert.Equal(-1, game.CompareMoves("scissors", "rock"));
            Assert.Equal(-1, game.CompareMoves("paper", "scissors"));
        }

        [Fact]
        public void TestCompareMoves_Draw()
        {
            RPSGame game = new RPSGame();
            Assert.Equal(0, game.CompareMoves("rock", "rock"));
            Assert.Equal(0, game.CompareMoves("scissors", "scissors"));
            Assert.Equal(0, game.CompareMoves("paper", "paper"));
        }

        [Fact]
        public void TestScoreUpdate()
        {
            Player player = new Player("Player");
            Player ai = new Player("AI");

            player.Score++;
            ai.Score++;

            Assert.Equal(1, player.Score);
            Assert.Equal(1, ai.Score);
        }
    }
}

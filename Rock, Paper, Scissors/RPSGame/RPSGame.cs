using System;

namespace RPSGame
{
    public class RPSGame
    {
        private Player player;
        private Player ai;

        public RPSGame()
        {
            player = new Player("Player");
            ai = new Player("AI");
        }

        public void PlayGame()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");
            while (player.Score < 3 && ai.Score < 3)
            {
                PlayRound();
            }

            Console.WriteLine("Final Scores:");
            Console.WriteLine($"{player.Name}: {player.Score}");
            Console.WriteLine($"{ai.Name}: {ai.Score}");

            if (player.Score == 3)
            {
                Console.WriteLine("Congratulations! You win!");
            }
            else
            {
                Console.WriteLine("AI wins! Better luck next time.");
            }
        }

        private void PlayRound()
        {
            string playerMove = player.ChooseMove();
            string aiMove = GetAIMove();
            Console.WriteLine($"AI chose: {aiMove}");

            int result = CompareMoves(playerMove, aiMove);
            if (result == 1)
            {
                Console.WriteLine("You win this round!");
                player.Score++;
            }
            else if (result == -1)
            {
                Console.WriteLine("AI wins this round!");
                ai.Score++;
            }
            else
            {
                Console.WriteLine("This round is a draw.");
            }

            Console.WriteLine($"Scores: {player.Name}: {player.Score}, {ai.Name}: {ai.Score}");
        }

        private string GetAIMove()
        {
            Random rand = new Random();
            int move = rand.Next(3);
            switch (move)
            {
                case 0: return "rock";
                case 1: return "paper";
                case 2: return "scissors";
                default: return "rock";
            }
        }

        private int CompareMoves(string playerMove, string aiMove)
        {
            if (playerMove == aiMove)
                return 0;

            if ((playerMove == "rock" && aiMove == "scissors") ||
                (playerMove == "scissors" && aiMove == "paper") ||
                (playerMove == "paper" && aiMove == "rock"))
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}

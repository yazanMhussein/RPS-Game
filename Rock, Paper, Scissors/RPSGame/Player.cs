﻿using System;

namespace RPSGame
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Player(string name)
        {
            Name = name;
            Score = 0;
        }

        public string ChooseMove()
        {
            Console.WriteLine($"{Name}, enter your move (rock, paper, or scissors):");
            string move = Console.ReadLine().ToLower();

            while (move != "rock" && move != "paper" && move != "scissors")
            {
                Console.WriteLine("Invalid move. Please enter rock, paper, or scissors:");
                move = Console.ReadLine().ToLower();
            }

            return move;
        }
    }
}

/**
 * Program: Dice Roller for Snake Eyes
 * File: Dice.cs
 * Summary: User selects how many sided dice, then randomly rolls until snake eyes (double 1) is rolled
 * Author: Evan Wilson
 * Date: May 20th, 2018
 **/

using System;

namespace RollSnakeEyes
{
    public class Dice
    {
        private int value;
        //Random random = new Random();

        public int Value
        {
            get => value;
        }

        public int RollDice(int sides, int seed)
        {
            Random random = new Random(seed);
            value = random.Next(sides) + 1;
            return value;
        }
    }
}
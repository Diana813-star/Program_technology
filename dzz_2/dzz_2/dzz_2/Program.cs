
﻿using System;
using System.Collections.Generic;


namespace dzz_2
{
      /// <summary>
    /// Содержит точку входа в программу и демонстрацию работы персонажей.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Запускает программу и демонстрирует работу игровых персонажей.
        /// </summary>
        public static void Main()
        {
            List<Character> characters = new List<Character>
        {
            new Warrior(1, "Conana", 200, 80),
            new Mage(2, "Merlin", 80, 150),
            new Archer(3, "Robin", 120, 10)
        };

            foreach (Character character in characters)
            {
                Console.WriteLine(character);
                Console.WriteLine($"  alive: {character.IsAlive}");
                Console.WriteLine();

                character.Attack();

                if (character is IHealable healable)
                {
                    healable.Heal(50);
                }
                else
                {
                    Console.WriteLine(
                        $"{character.Name} cannot be healed.");
                }

                if (character is Warrior warrior)
                {
                    Console.WriteLine($"  tank: {warrior.IsTank}");
                }
                else if (character is Mage mage)
                {
                    Console.WriteLine(
                        $"  powerful: {mage.IsPowerful}");
                }
                else if (character is Archer archer)
                {
                    Console.WriteLine(
                        $"  out of arrows: {archer.IsOutOfArrows}");
                }
            }
        }
    }
}

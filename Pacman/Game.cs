using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public static class Game
    {
        public static void Start()
        {
            var Pacman = new Pacman();
            var Ghost = new Ghost();
            var GameArray = GetGameArray();

            for (var i = 0; i < GameArray.Length; i++)
            {
                if (Pacman.Lives <= 0)
                    break;

                if (Pacman.Points >= 10000)
                {
                    Pacman.Lives++;
                }

                var currentItem = GameArray[i];

                switch (currentItem)
                {
                    case "Dot":
                        Pacman.Points += 10;
                        break;
                    case "InvincibleGhost":
                        Pacman.Lives -= 1;
                        break;
                    case "VulnerableGhost":
                        Pacman.Points += Ghost.Bonus;
                        Ghost.Bonus *= 2;
                        break;
                    default:
                        var fruit = BonusFruit.Fruit[currentItem];
                        Pacman.Points += fruit;
                        break;
                }
            }

            var points = Pacman.Points;
            int livesGained = Pacman.Points > 10000 ? 1 : 0;

            Console.WriteLine($"Pacman points: {points}");
            Console.WriteLine($"Pacman lives gained: {livesGained}");

        }

        public static string[] GetGameArray()
        {
            string text = File.ReadAllText(@"../../pacman-sequence.txt");
            string[] stream = text.Split(',');
            return stream;
        }
    }
}


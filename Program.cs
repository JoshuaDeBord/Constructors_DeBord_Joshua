using System;

namespace Constructors_DeBord_Joshua
{
    class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game("CS:GO", "FPS");

            Console.WriteLine($"My favorite game is {myGame.title} and it is a {myGame.genre} game."); //tells the user my favorite game and it's genre

            Game myOtherGame = new Game();

            Console.WriteLine($"My favorite game is {myOtherGame.title} and it is a {myOtherGame.genre} game."); //tells the user my 2nd favorite game and its drama

        }
    }
}

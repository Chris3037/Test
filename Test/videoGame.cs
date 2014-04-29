using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class videoGame
    {
        //Properties
        public string Code { get; set; }
        public string Rating { get; set; }
        public int Awesomeness { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

        /// <summary>
        /// This is a constructor (It has the same name as the class!!!)
        /// </summary>
        /// <param name="title">Name of game</param>
        /// <param name="code">Code to make the game</param>
        /// <param name="genre">What type of game it is(RPG, FPS)</param>
        public videoGame(string title, string code, string genre)
        {
            this.Title = title;
            this.Code = code;
            this.Genre = genre;
        }

        /// <summary>
        /// This is a method. It's just a fuction but in an object. Runs the code to play the game.
        /// </summary>
        public void Play()
        {
            Console.WriteLine(this.Code);
        }
    }
}

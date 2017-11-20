using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman {
    class Program {
        static void Main(string[] args) {

            //create a new player for the game
            var player = new Player("Jim");

            //create a new game with hangman object and pass in the player
            var game = new Hangman(player);


            game = new Hangman();


        }
    }
}


//Instance Fields are associated with an instance of a class
// cannot use VAR keyword
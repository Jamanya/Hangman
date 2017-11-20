using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman {
    class Hangman {


        public Hangman(Player player) {
            if (player == null) {
                throw new ArgumentNullException(nameof(player));
            }
            this.Player = player;
        }

        public Hangman() : this(new Player()) { }

       public Player Player { get; set; }

        public List<string> WordList { get; set; }
        public string Word { get; set; }
        public Outcome Outcome { get; set; }

        public void Guess (char letter) {
            //game logic for players guess will go here.. 

            // this is where the game gets impllimented 
        }
       
    }
}
